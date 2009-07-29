// $ANTLR 3.1.2 d:\\lesscss.g 2009-07-29 11:01:45


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class lesscssLexer : Lexer {
    public const int RULE = 5;
    public const int T__20 = 20;
    public const int EOF = -1;
    public const int T__19 = 19;
    public const int WS = 14;
    public const int T__16 = 16;
    public const int SELECTOR = 7;
    public const int T__15 = 15;
    public const int T__18 = 18;
    public const int T__17 = 17;
    public const int PROPERTY = 6;
    public const int SelectorID = 10;
    public const int ALPHANUMERIC = 11;
    public const int SL_COMMENT = 12;
    public const int IDENT = 8;
    public const int SelectorClass = 9;
    public const int VAR = 4;
    public const int COMMENT = 13;

    // delegates
    // delegators

    public lesscssLexer() 
    {
		InitializeCyclicDFAs();
    }
    public lesscssLexer(ICharStream input)
		: this(input, null) {
    }
    public lesscssLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "d:\\lesscss.g";} 
    }

    // $ANTLR start "T__15"
    public void mT__15() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__15;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:7:7: ( ',' )
            // d:\\lesscss.g:7:9: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__15"

    // $ANTLR start "T__16"
    public void mT__16() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__16;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:8:7: ( '{' )
            // d:\\lesscss.g:8:9: '{'
            {
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__16"

    // $ANTLR start "T__17"
    public void mT__17() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__17;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:9:7: ( '}' )
            // d:\\lesscss.g:9:9: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__17"

    // $ANTLR start "T__18"
    public void mT__18() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__18;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:10:7: ( ':' )
            // d:\\lesscss.g:10:9: ':'
            {
            	Match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__18"

    // $ANTLR start "T__19"
    public void mT__19() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__19;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:11:7: ( ';' )
            // d:\\lesscss.g:11:9: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__19"

    // $ANTLR start "T__20"
    public void mT__20() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__20;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:12:7: ( '@' )
            // d:\\lesscss.g:12:9: '@'
            {
            	Match('@'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__20"

    // $ANTLR start "SelectorClass"
    public void mSelectorClass() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SelectorClass;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:43:2: ( '.' IDENT )
            // d:\\lesscss.g:43:4: '.' IDENT
            {
            	Match('.'); 
            	mIDENT(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SelectorClass"

    // $ANTLR start "SelectorID"
    public void mSelectorID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SelectorID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:46:2: ( '#' IDENT )
            // d:\\lesscss.g:46:4: '#' IDENT
            {
            	Match('#'); 
            	mIDENT(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SelectorID"

    // $ANTLR start "IDENT"
    public void mIDENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IDENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:60:2: ( ( '_' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' ) ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' | '0' .. '9' )* | '-' ( '_' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' ) ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' | '0' .. '9' )* )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( ((LA3_0 >= 'A' && LA3_0 <= 'Z') || LA3_0 == '_' || (LA3_0 >= 'a' && LA3_0 <= 'z') || (LA3_0 >= '\u0100' && LA3_0 <= '\uFFFE')) )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == '-') )
            {
                alt3 = 2;
            }
            else 
            {
                NoViableAltException nvae_d3s0 =
                    new NoViableAltException("", 3, 0, input);

                throw nvae_d3s0;
            }
            switch (alt3) 
            {
                case 1 :
                    // d:\\lesscss.g:60:4: ( '_' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' ) ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' | '0' .. '9' )*
                    {
                    	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || (input.LA(1) >= '\u0100' && input.LA(1) <= '\uFFFE') ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}

                    	// d:\\lesscss.g:61:3: ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' | '0' .. '9' )*
                    	do 
                    	{
                    	    int alt1 = 2;
                    	    int LA1_0 = input.LA(1);

                    	    if ( (LA1_0 == '-' || (LA1_0 >= '0' && LA1_0 <= '9') || (LA1_0 >= 'A' && LA1_0 <= 'Z') || LA1_0 == '_' || (LA1_0 >= 'a' && LA1_0 <= 'z') || (LA1_0 >= '\u0100' && LA1_0 <= '\uFFFE')) )
                    	    {
                    	        alt1 = 1;
                    	    }


                    	    switch (alt1) 
                    		{
                    			case 1 :
                    			    // d:\\lesscss.g:
                    			    {
                    			    	if ( input.LA(1) == '-' || (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || (input.LA(1) >= '\u0100' && input.LA(1) <= '\uFFFE') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop1;
                    	    }
                    	} while (true);

                    	loop1:
                    		;	// Stops C# compiler whining that label 'loop1' has no statements


                    }
                    break;
                case 2 :
                    // d:\\lesscss.g:62:4: '-' ( '_' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' ) ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' | '0' .. '9' )*
                    {
                    	Match('-'); 
                    	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || (input.LA(1) >= '\u0100' && input.LA(1) <= '\uFFFE') ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}

                    	// d:\\lesscss.g:63:3: ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' | '0' .. '9' )*
                    	do 
                    	{
                    	    int alt2 = 2;
                    	    int LA2_0 = input.LA(1);

                    	    if ( (LA2_0 == '-' || (LA2_0 >= '0' && LA2_0 <= '9') || (LA2_0 >= 'A' && LA2_0 <= 'Z') || LA2_0 == '_' || (LA2_0 >= 'a' && LA2_0 <= 'z') || (LA2_0 >= '\u0100' && LA2_0 <= '\uFFFE')) )
                    	    {
                    	        alt2 = 1;
                    	    }


                    	    switch (alt2) 
                    		{
                    			case 1 :
                    			    // d:\\lesscss.g:
                    			    {
                    			    	if ( input.LA(1) == '-' || (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || (input.LA(1) >= '\u0100' && input.LA(1) <= '\uFFFE') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop2;
                    	    }
                    	} while (true);

                    	loop2:
                    		;	// Stops C# compiler whining that label 'loop2' has no statements


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IDENT"

    // $ANTLR start "ALPHANUMERIC"
    public void mALPHANUMERIC() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ALPHANUMERIC;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:67:2: ( ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )+ )
            // d:\\lesscss.g:67:4: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )+
            {
            	// d:\\lesscss.g:67:4: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )+
            	int cnt4 = 0;
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( ((LA4_0 >= '0' && LA4_0 <= '9') || (LA4_0 >= 'A' && LA4_0 <= 'Z') || (LA4_0 >= 'a' && LA4_0 <= 'z')) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // d:\\lesscss.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt4 >= 1 ) goto loop4;
            		            EarlyExitException eee4 =
            		                new EarlyExitException(4, input);
            		            throw eee4;
            	    }
            	    cnt4++;
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whinging that label 'loop4' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ALPHANUMERIC"

    // $ANTLR start "SL_COMMENT"
    public void mSL_COMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SL_COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:73:2: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\n' | '\\r' ( '\\n' )? ) )
            // d:\\lesscss.g:73:4: '//' (~ ( '\\n' | '\\r' ) )* ( '\\n' | '\\r' ( '\\n' )? )
            {
            	Match("//"); 

            	// d:\\lesscss.g:74:3: (~ ( '\\n' | '\\r' ) )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= '\u0000' && LA5_0 <= '\t') || (LA5_0 >= '\u000B' && LA5_0 <= '\f') || (LA5_0 >= '\u000E' && LA5_0 <= '\uFFFF')) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // d:\\lesscss.g:74:4: ~ ( '\\n' | '\\r' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

            	// d:\\lesscss.g:74:19: ( '\\n' | '\\r' ( '\\n' )? )
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == '\n') )
            	{
            	    alt7 = 1;
            	}
            	else if ( (LA7_0 == '\r') )
            	{
            	    alt7 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d7s0 =
            	        new NoViableAltException("", 7, 0, input);

            	    throw nvae_d7s0;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // d:\\lesscss.g:74:20: '\\n'
            	        {
            	        	Match('\n'); 

            	        }
            	        break;
            	    case 2 :
            	        // d:\\lesscss.g:74:25: '\\r' ( '\\n' )?
            	        {
            	        	Match('\r'); 
            	        	// d:\\lesscss.g:74:29: ( '\\n' )?
            	        	int alt6 = 2;
            	        	int LA6_0 = input.LA(1);

            	        	if ( (LA6_0 == '\n') )
            	        	{
            	        	    alt6 = 1;
            	        	}
            	        	switch (alt6) 
            	        	{
            	        	    case 1 :
            	        	        // d:\\lesscss.g:74:30: '\\n'
            	        	        {
            	        	        	Match('\n'); 

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SL_COMMENT"

    // $ANTLR start "COMMENT"
    public void mCOMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:79:2: ( '/*' ( . )* '*/' )
            // d:\\lesscss.g:79:4: '/*' ( . )* '*/'
            {
            	Match("/*"); 

            	// d:\\lesscss.g:79:9: ( . )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == '*') )
            	    {
            	        int LA8_1 = input.LA(2);

            	        if ( (LA8_1 == '/') )
            	        {
            	            alt8 = 2;
            	        }
            	        else if ( ((LA8_1 >= '\u0000' && LA8_1 <= '.') || (LA8_1 >= '0' && LA8_1 <= '\uFFFF')) )
            	        {
            	            alt8 = 1;
            	        }


            	    }
            	    else if ( ((LA8_0 >= '\u0000' && LA8_0 <= ')') || (LA8_0 >= '+' && LA8_0 <= '\uFFFF')) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // d:\\lesscss.g:79:9: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

            	Match("*/"); 

            	 _channel = HIDDEN; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMENT"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:82:4: ( ( ' ' | '\\t' | '\\r' | '\\n' | '\\f' )+ )
            // d:\\lesscss.g:82:6: ( ' ' | '\\t' | '\\r' | '\\n' | '\\f' )+
            {
            	// d:\\lesscss.g:82:6: ( ' ' | '\\t' | '\\r' | '\\n' | '\\f' )+
            	int cnt9 = 0;
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( ((LA9_0 >= '\t' && LA9_0 <= '\n') || (LA9_0 >= '\f' && LA9_0 <= '\r') || LA9_0 == ' ') )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // d:\\lesscss.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || (input.LA(1) >= '\f' && input.LA(1) <= '\r') || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt9 >= 1 ) goto loop9;
            		            EarlyExitException eee9 =
            		                new EarlyExitException(9, input);
            		            throw eee9;
            	    }
            	    cnt9++;
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whinging that label 'loop9' has no statements

            	 _channel = HIDDEN; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    override public void mTokens() // throws RecognitionException 
    {
        // d:\\lesscss.g:1:8: ( T__15 | T__16 | T__17 | T__18 | T__19 | T__20 | SelectorClass | SelectorID | IDENT | ALPHANUMERIC | SL_COMMENT | COMMENT | WS )
        int alt10 = 13;
        alt10 = dfa10.Predict(input);
        switch (alt10) 
        {
            case 1 :
                // d:\\lesscss.g:1:10: T__15
                {
                	mT__15(); 

                }
                break;
            case 2 :
                // d:\\lesscss.g:1:16: T__16
                {
                	mT__16(); 

                }
                break;
            case 3 :
                // d:\\lesscss.g:1:22: T__17
                {
                	mT__17(); 

                }
                break;
            case 4 :
                // d:\\lesscss.g:1:28: T__18
                {
                	mT__18(); 

                }
                break;
            case 5 :
                // d:\\lesscss.g:1:34: T__19
                {
                	mT__19(); 

                }
                break;
            case 6 :
                // d:\\lesscss.g:1:40: T__20
                {
                	mT__20(); 

                }
                break;
            case 7 :
                // d:\\lesscss.g:1:46: SelectorClass
                {
                	mSelectorClass(); 

                }
                break;
            case 8 :
                // d:\\lesscss.g:1:60: SelectorID
                {
                	mSelectorID(); 

                }
                break;
            case 9 :
                // d:\\lesscss.g:1:71: IDENT
                {
                	mIDENT(); 

                }
                break;
            case 10 :
                // d:\\lesscss.g:1:77: ALPHANUMERIC
                {
                	mALPHANUMERIC(); 

                }
                break;
            case 11 :
                // d:\\lesscss.g:1:90: SL_COMMENT
                {
                	mSL_COMMENT(); 

                }
                break;
            case 12 :
                // d:\\lesscss.g:1:101: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 13 :
                // d:\\lesscss.g:1:109: WS
                {
                	mWS(); 

                }
                break;

        }

    }


    protected DFA10 dfa10;
	private void InitializeCyclicDFAs()
	{
	    this.dfa10 = new DFA10(this);
	}

    const string DFA10_eotS =
        "\x09\uffff\x01\x0a\x04\uffff\x01\x0a\x02\uffff";
    const string DFA10_eofS =
        "\x11\uffff";
    const string DFA10_minS =
        "\x01\x09\x08\uffff\x01\x30\x02\uffff\x01\x2a\x01\uffff\x01\x30"+
        "\x02\uffff";
    const string DFA10_maxS =
        "\x01\ufffe\x08\uffff\x01\x7a\x02\uffff\x01\x2f\x01\uffff\x01\x7a"+
        "\x02\uffff";
    const string DFA10_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\uffff\x01\x09\x01\x0a\x01\uffff\x01\x0d\x01\uffff"+
        "\x01\x0b\x01\x0c";
    const string DFA10_specialS =
        "\x11\uffff}>";
    static readonly string[] DFA10_transitionS = {
            "\x02\x0d\x01\uffff\x02\x0d\x12\uffff\x01\x0d\x02\uffff\x01"+
            "\x08\x08\uffff\x01\x01\x01\x0a\x01\x07\x01\x0c\x0a\x0b\x01\x04"+
            "\x01\x05\x04\uffff\x01\x06\x1a\x09\x04\uffff\x01\x0a\x01\uffff"+
            "\x1a\x09\x01\x02\x01\uffff\x01\x03\u0082\uffff\ufeff\x0a",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x0a\x0e\x07\uffff\x1a\x0e\x06\uffff\x1a\x0e",
            "",
            "",
            "\x01\x10\x04\uffff\x01\x0f",
            "",
            "\x0a\x0e\x07\uffff\x1a\x0e\x06\uffff\x1a\x0e",
            "",
            ""
    };

    static readonly short[] DFA10_eot = DFA.UnpackEncodedString(DFA10_eotS);
    static readonly short[] DFA10_eof = DFA.UnpackEncodedString(DFA10_eofS);
    static readonly char[] DFA10_min = DFA.UnpackEncodedStringToUnsignedChars(DFA10_minS);
    static readonly char[] DFA10_max = DFA.UnpackEncodedStringToUnsignedChars(DFA10_maxS);
    static readonly short[] DFA10_accept = DFA.UnpackEncodedString(DFA10_acceptS);
    static readonly short[] DFA10_special = DFA.UnpackEncodedString(DFA10_specialS);
    static readonly short[][] DFA10_transition = DFA.UnpackEncodedStringArray(DFA10_transitionS);

    protected class DFA10 : DFA
    {
        public DFA10(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 10;
            this.eot = DFA10_eot;
            this.eof = DFA10_eof;
            this.min = DFA10_min;
            this.max = DFA10_max;
            this.accept = DFA10_accept;
            this.special = DFA10_special;
            this.transition = DFA10_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__15 | T__16 | T__17 | T__18 | T__19 | T__20 | SelectorClass | SelectorID | IDENT | ALPHANUMERIC | SL_COMMENT | COMMENT | WS );"; }
        }

    }

 
    
}
