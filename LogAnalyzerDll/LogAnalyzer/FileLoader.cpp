#include "stdafx.h"
#include "FileLoader.h"
#include <regex>
#include <Windows.h>
#include <iostream>
#include <fstream>
#include "TextSearcher.h"

LogAnalyzer::LogAnalyzer()
{
}

LogAnalyzer::~LogAnalyzer()
{
}

LogAnalyzer &
LogAnalyzer::Instance()
{
	static LogAnalyzer	Inst;
	return Inst;
}

void 
LogAnalyzer::Initialize( const char* szPath, const char* szFExpr, const char* szSExpr )
{
	m_szFilePath	= szPath;
	m_szFileExpr	= szFExpr;
	m_szSearchExpr	= szSExpr;
	m_szFilePath	+= "\\";
	m_szSearchExpr	+= "\n";

	TextSearcher::Instance().SetExpression( m_szSearchExpr );
}

int		
LogAnalyzer::Run()
{
	WIN32_FIND_DATA		FindFileData;
	HANDLE				hFind;
	string				szSearchPath( m_szFilePath );
	szSearchPath		+= "*.*";
	
	tr1::regex			expr( m_szFileExpr );

	hFind				= FindFirstFile( szSearchPath.c_str(), &FindFileData );
	if( hFind == INVALID_HANDLE_VALUE )
	{
		return -1;
	}

	do
	{
		if( regex_match( FindFileData.cFileName, expr) )
		{
			ProcTextScan( FindFileData.cFileName );
		}
	} while( FindNextFile( hFind, &FindFileData ) );
	
	FindClose( hFind );

	TextSearcher::Instance().WriteResult();

	return 0;
}

void		
LogAnalyzer::ProcTextScan( const char* szFileName )
{
	CHAR szBuffer[4096] = {0, };
	char szFilePath[1024] = {0, };

	strcpy_s<1024>( szFilePath, m_szFilePath.c_str() );
	strcat_s<1024>( szFilePath, szFileName );
	
	FILE * pFile;		
	errno_t nRet	= fopen_s( & pFile, szFilePath, "r" );
	if( nRet != 0 )
	{
		return;
	}
	
	for( int i=0; ; i++ )
	{
		if( _fgetts( szBuffer, 4096, pFile) == NULL )
		{
			break;
		}

		TextSearcher::Instance().Find( szBuffer );
	}
}


void 
LogAnalyze( char * szPath, char * szFileRegex, char * szSearchRegex )
{
	////$$ Å×½ºÆ®
	//FILE * pFile;		
	//errno_t nRet	= fopen_s( & pFile, "Test.txt", "w" );
	//if( nRet != 0 )
	//{
	//	return;
	//}
	//_ftprintf( pFile, _T("%s \n"), szPath );
	//_ftprintf( pFile, _T("%s \n"), szFileRegex );
	//_ftprintf( pFile, _T("%s \n"), szSearchRegex );
	//fclose( pFile );

	LogAnalyzer::Instance().Initialize( szPath, szFileRegex, szSearchRegex );
	LogAnalyzer::Instance().Run();
}

void 
Wide2Multi( wchar_t * pWide, char * pMulti )
{
	int nLen = -1;

	int nCount = WideCharToMultiByte( CP_ACP, 0, pWide, nLen, NULL, 0, NULL, NULL);

	WideCharToMultiByte( CP_ACP, 0, pWide, nLen, pMulti, nCount, NULL, NULL);
}