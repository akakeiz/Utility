#pragma once

#include <vector>
#include <string>
#include <regex>

using	namespace std;
using	namespace std::tr1;

class TextSearcher
{
public:
	void			SetExpression( string & szExpr );
	void			Find( const char * szText );
	void			WriteResult();


private:
	typedef			vector<string>
					VECTOR;
	VECTOR			m_FindBuffer;
	regex			m_expr;

public:
	TextSearcher();
	static TextSearcher & Instance();
private:
	~TextSearcher();
};