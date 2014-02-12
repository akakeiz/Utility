#include "stdafx.h"
#include "TextSearcher.h"
#include <regex>

TextSearcher::TextSearcher()
{
}

TextSearcher::~TextSearcher()
{
}

TextSearcher &
TextSearcher::Instance()
{
	static TextSearcher	Inst;
	return Inst;
}

void			
TextSearcher::SetExpression( string & szExpr )
{
	m_expr.assign( szExpr);
}


void			
TextSearcher::Find( const char * szText )
{
	if( regex_match( szText, m_expr ) )
	{
		string	szResult( szText );
		m_FindBuffer.push_back( szResult );
	}
}

void			
TextSearcher::WriteResult()
{
	FILE * pFile;		
	errno_t nRet	= fopen_s( & pFile, "reulst.txt", "w" );
	if( nRet != 0 )
	{
		return;
	}
	
	for( size_t i=0; i<m_FindBuffer.size(); i++ )
	{
		_ftprintf( pFile, _T("%s"), m_FindBuffer[i].c_str() );
	}	

	fclose( pFile );
}