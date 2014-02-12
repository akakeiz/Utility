#pragma once

#include <string>

using	namespace std;
using	namespace std::tr1;

class LogAnalyzer
{
public:
	void		Initialize( const char* szPath, const char* szFExpr, const char* szSExpr );

	int 		Run();
	
private:
	void		ProcTextScan( const char* szFileName );
	
	string		m_szFilePath;
	string		m_szFileExpr;
	string		m_szSearchExpr;

	// Singleton
public:
	LogAnalyzer();
	static LogAnalyzer & Instance();
private:
	~LogAnalyzer();
};

//extern "C" __declspec(dllexport) void LogAnalyze( wchar_t * szPath, wchar_t * szFileRegex, wchar_t * szSearchRegex );
extern "C" __declspec(dllexport) void LogAnalyze( char * szPath, char * szFileRegex, char * szSearchRegex );

void Wide2Multi( wchar_t * pWide, char * pMulti );