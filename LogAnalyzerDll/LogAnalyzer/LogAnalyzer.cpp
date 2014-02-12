// LogAnalyzer.cpp : �ܼ� ���� ���α׷��� ���� �������� �����մϴ�.
//

#include "stdafx.h"
#include <string>
#include "FileLoader.h"
#include "TextSearcher.h"


int _tmain(int argc, _TCHAR* argv[])
{
	std::string	szPath( "C:\\server_work\\source\\Server2010.root\\Binary\\gameserver\\EventLog\\" );
	std::string szFile( "Event.*" );
	std::string szSearch( ".*172.32.61.29:9291.*\n" );

	LogAnalyzer::Instance().Initialize( szPath.c_str(), szFile.c_str(), szSearch.c_str() );
	LogAnalyzer::Instance().Run();

	return 0;
}

