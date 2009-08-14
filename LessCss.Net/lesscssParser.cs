// $ANTLR 3.1.2 D:\\lesscss.g 2009-08-14 02:31:19


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

public class lesscssParser : Parser 
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"VAR", 
		"RULE", 
		"PROPERTY", 
		"SELECTORGROUP", 
		"SELECTOR", 
		"FONTDEFINITION", 
		"CLASS", 
		"TAG", 
		"ID", 
		"WILDCARD", 
		"EXPR", 
		"CONSTANT", 
		"LITERAL", 
		"MIXIN", 
		"IDENT", 
		"STRING", 
		"MINUS", 
		"NUM", 
		"UNIT", 
		"COLOR", 
		"SelectorClass", 
		"SelectorID", 
		"HEXDIGIT", 
		"SL_COMMENT", 
		"COMMENT", 
		"WS", 
		"'@'", 
		"':'", 
		"';'", 
		"','", 
		"'+'", 
		"'*'", 
		"'/'", 
		"'('", 
		"')'", 
		"'@media'", 
		"'{'", 
		"'}'", 
		"'all'", 
		"'braille'", 
		"'embossed'", 
		"'handheld'", 
		"'print'", 
		"'projection'", 
		"'screen'", 
		"'speech'", 
		"'tty'", 
		"'tv'", 
		"'>'"
    };

    public const int SELECTORGROUP = 7;
    public const int CLASS = 10;
    public const int ID = 12;
    public const int EOF = -1;
    public const int COLOR = 23;
    public const int T__51 = 51;
    public const int SELECTOR = 8;
    public const int EXPR = 14;
    public const int T__52 = 52;
    public const int WILDCARD = 13;
    public const int IDENT = 18;
    public const int VAR = 4;
    public const int COMMENT = 28;
    public const int T__50 = 50;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int RULE = 5;
    public const int T__45 = 45;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int LITERAL = 16;
    public const int MINUS = 20;
    public const int NUM = 21;
    public const int TAG = 11;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int UNIT = 22;
    public const int T__32 = 32;
    public const int MIXIN = 17;
    public const int WS = 29;
    public const int T__33 = 33;
    public const int FONTDEFINITION = 9;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int PROPERTY = 6;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int SelectorID = 25;
    public const int SL_COMMENT = 27;
    public const int CONSTANT = 15;
    public const int SelectorClass = 24;
    public const int STRING = 19;
    public const int HEXDIGIT = 26;

    // delegates
    // delegators



        public lesscssParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public lesscssParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
       }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return lesscssParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "D:\\lesscss.g"; }
    }


    public class lessCss_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "lessCss"
    // D:\\lesscss.g:26:1: lessCss : ( lessLine )+ ;
    public lesscssParser.lessCss_return lessCss() // throws RecognitionException [1]
    {   
        lesscssParser.lessCss_return retval = new lesscssParser.lessCss_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.lessLine_return lessLine1 = null;



        try 
    	{
            // D:\\lesscss.g:27:2: ( ( lessLine )+ )
            // D:\\lesscss.g:27:4: ( lessLine )+
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// D:\\lesscss.g:27:4: ( lessLine )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == IDENT || (LA1_0 >= SelectorClass && LA1_0 <= SelectorID) || LA1_0 == 30 || LA1_0 == 34 || LA1_0 == 39 || LA1_0 == 52) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // D:\\lesscss.g:27:5: lessLine
            			    {
            			    	PushFollow(FOLLOW_lessLine_in_lessCss97);
            			    	lessLine1 = lessLine();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, lessLine1.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whinging that label 'loop1' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "lessCss"

    public class variable_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "variable"
    // D:\\lesscss.g:31:10: fragment variable : '@' IDENT ':' ( additiveExpression -> IDENT ^( EXPR additiveExpression ) | literal -> IDENT ^( LITERAL literal ) ) ';' ;
    public lesscssParser.variable_return variable() // throws RecognitionException [1]
    {   
        lesscssParser.variable_return retval = new lesscssParser.variable_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal2 = null;
        IToken IDENT3 = null;
        IToken char_literal4 = null;
        IToken char_literal7 = null;
        lesscssParser.additiveExpression_return additiveExpression5 = null;

        lesscssParser.literal_return literal6 = null;


        CommonTree char_literal2_tree=null;
        CommonTree IDENT3_tree=null;
        CommonTree char_literal4_tree=null;
        CommonTree char_literal7_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_30 = new RewriteRuleTokenStream(adaptor,"token 30");
        RewriteRuleTokenStream stream_32 = new RewriteRuleTokenStream(adaptor,"token 32");
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleSubtreeStream stream_additiveExpression = new RewriteRuleSubtreeStream(adaptor,"rule additiveExpression");
        RewriteRuleSubtreeStream stream_literal = new RewriteRuleSubtreeStream(adaptor,"rule literal");
        try 
    	{
            // D:\\lesscss.g:32:2: ( '@' IDENT ':' ( additiveExpression -> IDENT ^( EXPR additiveExpression ) | literal -> IDENT ^( LITERAL literal ) ) ';' )
            // D:\\lesscss.g:32:4: '@' IDENT ':' ( additiveExpression -> IDENT ^( EXPR additiveExpression ) | literal -> IDENT ^( LITERAL literal ) ) ';'
            {
            	char_literal2=(IToken)Match(input,30,FOLLOW_30_in_variable114);  
            	stream_30.Add(char_literal2);

            	IDENT3=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_variable116);  
            	stream_IDENT.Add(IDENT3);

            	char_literal4=(IToken)Match(input,31,FOLLOW_31_in_variable118);  
            	stream_31.Add(char_literal4);

            	// D:\\lesscss.g:32:18: ( additiveExpression -> IDENT ^( EXPR additiveExpression ) | literal -> IDENT ^( LITERAL literal ) )
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == NUM || LA2_0 == COLOR || LA2_0 == 30 || LA2_0 == 37) )
            	{
            	    alt2 = 1;
            	}
            	else if ( ((LA2_0 >= IDENT && LA2_0 <= STRING)) )
            	{
            	    alt2 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    throw nvae_d2s0;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // D:\\lesscss.g:32:19: additiveExpression
            	        {
            	        	PushFollow(FOLLOW_additiveExpression_in_variable121);
            	        	additiveExpression5 = additiveExpression();
            	        	state.followingStackPointer--;

            	        	stream_additiveExpression.Add(additiveExpression5.Tree);


            	        	// AST REWRITE
            	        	// elements:          IDENT, additiveExpression
            	        	// token labels:      
            	        	// rule labels:       retval
            	        	// token list labels: 
            	        	// rule list labels:  
            	        	// wildcard labels: 
            	        	retval.Tree = root_0;
            	        	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	        	root_0 = (CommonTree)adaptor.GetNilNode();
            	        	// 32:38: -> IDENT ^( EXPR additiveExpression )
            	        	{
            	        	    adaptor.AddChild(root_0, stream_IDENT.NextNode());
            	        	    // D:\\lesscss.g:32:47: ^( EXPR additiveExpression )
            	        	    {
            	        	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	        	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(EXPR, "EXPR"), root_1);

            	        	    adaptor.AddChild(root_1, stream_additiveExpression.NextTree());

            	        	    adaptor.AddChild(root_0, root_1);
            	        	    }

            	        	}

            	        	retval.Tree = root_0;retval.Tree = root_0;
            	        }
            	        break;
            	    case 2 :
            	        // D:\\lesscss.g:32:76: literal
            	        {
            	        	PushFollow(FOLLOW_literal_in_variable135);
            	        	literal6 = literal();
            	        	state.followingStackPointer--;

            	        	stream_literal.Add(literal6.Tree);


            	        	// AST REWRITE
            	        	// elements:          literal, IDENT
            	        	// token labels:      
            	        	// rule labels:       retval
            	        	// token list labels: 
            	        	// rule list labels:  
            	        	// wildcard labels: 
            	        	retval.Tree = root_0;
            	        	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	        	root_0 = (CommonTree)adaptor.GetNilNode();
            	        	// 32:84: -> IDENT ^( LITERAL literal )
            	        	{
            	        	    adaptor.AddChild(root_0, stream_IDENT.NextNode());
            	        	    // D:\\lesscss.g:32:93: ^( LITERAL literal )
            	        	    {
            	        	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	        	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(LITERAL, "LITERAL"), root_1);

            	        	    adaptor.AddChild(root_1, stream_literal.NextTree());

            	        	    adaptor.AddChild(root_0, root_1);
            	        	    }

            	        	}

            	        	retval.Tree = root_0;retval.Tree = root_0;
            	        }
            	        break;

            	}

            	char_literal7=(IToken)Match(input,32,FOLLOW_32_in_variable148);  
            	stream_32.Add(char_literal7);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variable"

    public class lessLine_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "lessLine"
    // D:\\lesscss.g:34:10: fragment lessLine : ( ruleset | mediadefinition | ( variable -> ^( VAR variable ) ) );
    public lesscssParser.lessLine_return lessLine() // throws RecognitionException [1]
    {   
        lesscssParser.lessLine_return retval = new lesscssParser.lessLine_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.ruleset_return ruleset8 = null;

        lesscssParser.mediadefinition_return mediadefinition9 = null;

        lesscssParser.variable_return variable10 = null;


        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
            // D:\\lesscss.g:35:2: ( ruleset | mediadefinition | ( variable -> ^( VAR variable ) ) )
            int alt3 = 3;
            switch ( input.LA(1) ) 
            {
            case IDENT:
            case SelectorClass:
            case SelectorID:
            case 34:
            case 52:
            	{
                alt3 = 1;
                }
                break;
            case 39:
            	{
                alt3 = 2;
                }
                break;
            case 30:
            	{
                alt3 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d3s0 =
            	        new NoViableAltException("", 3, 0, input);

            	    throw nvae_d3s0;
            }

            switch (alt3) 
            {
                case 1 :
                    // D:\\lesscss.g:35:4: ruleset
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ruleset_in_lessLine160);
                    	ruleset8 = ruleset();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ruleset8.Tree);

                    }
                    break;
                case 2 :
                    // D:\\lesscss.g:35:14: mediadefinition
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_mediadefinition_in_lessLine164);
                    	mediadefinition9 = mediadefinition();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, mediadefinition9.Tree);

                    }
                    break;
                case 3 :
                    // D:\\lesscss.g:35:32: ( variable -> ^( VAR variable ) )
                    {
                    	// D:\\lesscss.g:35:32: ( variable -> ^( VAR variable ) )
                    	// D:\\lesscss.g:35:33: variable
                    	{
                    		PushFollow(FOLLOW_variable_in_lessLine169);
                    		variable10 = variable();
                    		state.followingStackPointer--;

                    		stream_variable.Add(variable10.Tree);


                    		// AST REWRITE
                    		// elements:          variable
                    		// token labels:      
                    		// rule labels:       retval
                    		// token list labels: 
                    		// rule list labels:  
                    		// wildcard labels: 
                    		retval.Tree = root_0;
                    		RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    		root_0 = (CommonTree)adaptor.GetNilNode();
                    		// 35:42: -> ^( VAR variable )
                    		{
                    		    // D:\\lesscss.g:35:45: ^( VAR variable )
                    		    {
                    		    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    		    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(VAR, "VAR"), root_1);

                    		    adaptor.AddChild(root_1, stream_variable.NextTree());

                    		    adaptor.AddChild(root_0, root_1);
                    		    }

                    		}

                    		retval.Tree = root_0;retval.Tree = root_0;
                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "lessLine"

    public class literal_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "literal"
    // D:\\lesscss.g:40:10: fragment literal : ( STRING | IDENT ) ( ',' ( STRING | IDENT ) )* ;
    public lesscssParser.literal_return literal() // throws RecognitionException [1]
    {   
        lesscssParser.literal_return retval = new lesscssParser.literal_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set11 = null;
        IToken char_literal12 = null;
        IToken set13 = null;

        CommonTree set11_tree=null;
        CommonTree char_literal12_tree=null;
        CommonTree set13_tree=null;

        try 
    	{
            // D:\\lesscss.g:41:2: ( ( STRING | IDENT ) ( ',' ( STRING | IDENT ) )* )
            // D:\\lesscss.g:41:4: ( STRING | IDENT ) ( ',' ( STRING | IDENT ) )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set11 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IDENT && input.LA(1) <= STRING) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set11));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}

            	// D:\\lesscss.g:41:21: ( ',' ( STRING | IDENT ) )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == 33) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // D:\\lesscss.g:41:22: ',' ( STRING | IDENT )
            			    {
            			    	char_literal12=(IToken)Match(input,33,FOLLOW_33_in_literal203); 
            			    		char_literal12_tree = (CommonTree)adaptor.Create(char_literal12);
            			    		adaptor.AddChild(root_0, char_literal12_tree);

            			    	set13 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= IDENT && input.LA(1) <= STRING) ) 
            			    	{
            			    	    input.Consume();
            			    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set13));
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "literal"

    public class varname_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "varname"
    // D:\\lesscss.g:44:10: fragment varname : '@' IDENT -> IDENT ;
    public lesscssParser.varname_return varname() // throws RecognitionException [1]
    {   
        lesscssParser.varname_return retval = new lesscssParser.varname_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal14 = null;
        IToken IDENT15 = null;

        CommonTree char_literal14_tree=null;
        CommonTree IDENT15_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_30 = new RewriteRuleTokenStream(adaptor,"token 30");

        try 
    	{
            // D:\\lesscss.g:45:2: ( '@' IDENT -> IDENT )
            // D:\\lesscss.g:45:4: '@' IDENT
            {
            	char_literal14=(IToken)Match(input,30,FOLLOW_30_in_varname227);  
            	stream_30.Add(char_literal14);

            	IDENT15=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_varname229);  
            	stream_IDENT.Add(IDENT15);



            	// AST REWRITE
            	// elements:          IDENT
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 45:14: -> IDENT
            	{
            	    adaptor.AddChild(root_0, stream_IDENT.NextNode());

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "varname"

    public class expression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "expression"
    // D:\\lesscss.g:49:10: fragment expression : additiveExpression -> ^( EXPR additiveExpression ) ;
    public lesscssParser.expression_return expression() // throws RecognitionException [1]
    {   
        lesscssParser.expression_return retval = new lesscssParser.expression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.additiveExpression_return additiveExpression16 = null;


        RewriteRuleSubtreeStream stream_additiveExpression = new RewriteRuleSubtreeStream(adaptor,"rule additiveExpression");
        try 
    	{
            // D:\\lesscss.g:50:2: ( additiveExpression -> ^( EXPR additiveExpression ) )
            // D:\\lesscss.g:50:5: additiveExpression
            {
            	PushFollow(FOLLOW_additiveExpression_in_expression248);
            	additiveExpression16 = additiveExpression();
            	state.followingStackPointer--;

            	stream_additiveExpression.Add(additiveExpression16.Tree);


            	// AST REWRITE
            	// elements:          additiveExpression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 50:24: -> ^( EXPR additiveExpression )
            	{
            	    // D:\\lesscss.g:50:27: ^( EXPR additiveExpression )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(EXPR, "EXPR"), root_1);

            	    adaptor.AddChild(root_1, stream_additiveExpression.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expression"

    public class additiveExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "additiveExpression"
    // D:\\lesscss.g:53:10: fragment additiveExpression : multiplicativeExpression ( ( '+' | MINUS ) multiplicativeExpression )* ;
    public lesscssParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        lesscssParser.additiveExpression_return retval = new lesscssParser.additiveExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set18 = null;
        lesscssParser.multiplicativeExpression_return multiplicativeExpression17 = null;

        lesscssParser.multiplicativeExpression_return multiplicativeExpression19 = null;


        CommonTree set18_tree=null;

        try 
    	{
            // D:\\lesscss.g:54:2: ( multiplicativeExpression ( ( '+' | MINUS ) multiplicativeExpression )* )
            // D:\\lesscss.g:54:4: multiplicativeExpression ( ( '+' | MINUS ) multiplicativeExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression269);
            	multiplicativeExpression17 = multiplicativeExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, multiplicativeExpression17.Tree);
            	// D:\\lesscss.g:54:29: ( ( '+' | MINUS ) multiplicativeExpression )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == MINUS || LA5_0 == 34) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // D:\\lesscss.g:54:31: ( '+' | MINUS ) multiplicativeExpression
            			    {
            			    	set18=(IToken)input.LT(1);
            			    	set18 = (IToken)input.LT(1);
            			    	if ( input.LA(1) == MINUS || input.LA(1) == 34 ) 
            			    	{
            			    	    input.Consume();
            			    	    root_0 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(set18), root_0);
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression280);
            			    	multiplicativeExpression19 = multiplicativeExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, multiplicativeExpression19.Tree);

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "additiveExpression"

    public class multiplicativeExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "multiplicativeExpression"
    // D:\\lesscss.g:58:10: fragment multiplicativeExpression : primaryExpression ( ( '*' | '/' ) primaryExpression )* ;
    public lesscssParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        lesscssParser.multiplicativeExpression_return retval = new lesscssParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set21 = null;
        lesscssParser.primaryExpression_return primaryExpression20 = null;

        lesscssParser.primaryExpression_return primaryExpression22 = null;


        CommonTree set21_tree=null;

        try 
    	{
            // D:\\lesscss.g:59:2: ( primaryExpression ( ( '*' | '/' ) primaryExpression )* )
            // D:\\lesscss.g:59:4: primaryExpression ( ( '*' | '/' ) primaryExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_primaryExpression_in_multiplicativeExpression305);
            	primaryExpression20 = primaryExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, primaryExpression20.Tree);
            	// D:\\lesscss.g:59:22: ( ( '*' | '/' ) primaryExpression )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= 35 && LA6_0 <= 36)) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // D:\\lesscss.g:59:24: ( '*' | '/' ) primaryExpression
            			    {
            			    	set21=(IToken)input.LT(1);
            			    	set21 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= 35 && input.LA(1) <= 36) ) 
            			    	{
            			    	    input.Consume();
            			    	    root_0 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(set21), root_0);
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_primaryExpression_in_multiplicativeExpression316);
            			    	primaryExpression22 = primaryExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, primaryExpression22.Tree);

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "multiplicativeExpression"

    public class primaryExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "primaryExpression"
    // D:\\lesscss.g:62:10: fragment primaryExpression : ( '(' additiveExpression ')' | value );
    public lesscssParser.primaryExpression_return primaryExpression() // throws RecognitionException [1]
    {   
        lesscssParser.primaryExpression_return retval = new lesscssParser.primaryExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal23 = null;
        IToken char_literal25 = null;
        lesscssParser.additiveExpression_return additiveExpression24 = null;

        lesscssParser.value_return value26 = null;


        CommonTree char_literal23_tree=null;
        CommonTree char_literal25_tree=null;

        try 
    	{
            // D:\\lesscss.g:63:2: ( '(' additiveExpression ')' | value )
            int alt7 = 2;
            int LA7_0 = input.LA(1);

            if ( (LA7_0 == 37) )
            {
                alt7 = 1;
            }
            else if ( (LA7_0 == NUM || LA7_0 == COLOR || LA7_0 == 30) )
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
                    // D:\\lesscss.g:63:4: '(' additiveExpression ')'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal23=(IToken)Match(input,37,FOLLOW_37_in_primaryExpression331); 
                    	PushFollow(FOLLOW_additiveExpression_in_primaryExpression334);
                    	additiveExpression24 = additiveExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, additiveExpression24.Tree);
                    	char_literal25=(IToken)Match(input,38,FOLLOW_38_in_primaryExpression336); 

                    }
                    break;
                case 2 :
                    // D:\\lesscss.g:64:4: value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_value_in_primaryExpression342);
                    	value26 = value();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, value26.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "primaryExpression"

    public class value_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "value"
    // D:\\lesscss.g:67:10: fragment value : ( varname -> ^( VAR varname ) | numeric -> ^( CONSTANT numeric ) );
    public lesscssParser.value_return value() // throws RecognitionException [1]
    {   
        lesscssParser.value_return retval = new lesscssParser.value_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.varname_return varname27 = null;

        lesscssParser.numeric_return numeric28 = null;


        RewriteRuleSubtreeStream stream_numeric = new RewriteRuleSubtreeStream(adaptor,"rule numeric");
        RewriteRuleSubtreeStream stream_varname = new RewriteRuleSubtreeStream(adaptor,"rule varname");
        try 
    	{
            // D:\\lesscss.g:68:2: ( varname -> ^( VAR varname ) | numeric -> ^( CONSTANT numeric ) )
            int alt8 = 2;
            int LA8_0 = input.LA(1);

            if ( (LA8_0 == 30) )
            {
                alt8 = 1;
            }
            else if ( (LA8_0 == NUM || LA8_0 == COLOR) )
            {
                alt8 = 2;
            }
            else 
            {
                NoViableAltException nvae_d8s0 =
                    new NoViableAltException("", 8, 0, input);

                throw nvae_d8s0;
            }
            switch (alt8) 
            {
                case 1 :
                    // D:\\lesscss.g:68:5: varname
                    {
                    	PushFollow(FOLLOW_varname_in_value358);
                    	varname27 = varname();
                    	state.followingStackPointer--;

                    	stream_varname.Add(varname27.Tree);


                    	// AST REWRITE
                    	// elements:          varname
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 68:13: -> ^( VAR varname )
                    	{
                    	    // D:\\lesscss.g:68:16: ^( VAR varname )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(VAR, "VAR"), root_1);

                    	    adaptor.AddChild(root_1, stream_varname.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // D:\\lesscss.g:69:4: numeric
                    {
                    	PushFollow(FOLLOW_numeric_in_value372);
                    	numeric28 = numeric();
                    	state.followingStackPointer--;

                    	stream_numeric.Add(numeric28.Tree);


                    	// AST REWRITE
                    	// elements:          numeric
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 69:12: -> ^( CONSTANT numeric )
                    	{
                    	    // D:\\lesscss.g:69:15: ^( CONSTANT numeric )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(CONSTANT, "CONSTANT"), root_1);

                    	    adaptor.AddChild(root_1, stream_numeric.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "value"

    public class numeric_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "numeric"
    // D:\\lesscss.g:72:1: numeric : ( ( NUM ( UNIT )? ) | COLOR );
    public lesscssParser.numeric_return numeric() // throws RecognitionException [1]
    {   
        lesscssParser.numeric_return retval = new lesscssParser.numeric_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken NUM29 = null;
        IToken UNIT30 = null;
        IToken COLOR31 = null;

        CommonTree NUM29_tree=null;
        CommonTree UNIT30_tree=null;
        CommonTree COLOR31_tree=null;

        try 
    	{
            // D:\\lesscss.g:73:2: ( ( NUM ( UNIT )? ) | COLOR )
            int alt10 = 2;
            int LA10_0 = input.LA(1);

            if ( (LA10_0 == NUM) )
            {
                alt10 = 1;
            }
            else if ( (LA10_0 == COLOR) )
            {
                alt10 = 2;
            }
            else 
            {
                NoViableAltException nvae_d10s0 =
                    new NoViableAltException("", 10, 0, input);

                throw nvae_d10s0;
            }
            switch (alt10) 
            {
                case 1 :
                    // D:\\lesscss.g:73:4: ( NUM ( UNIT )? )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// D:\\lesscss.g:73:4: ( NUM ( UNIT )? )
                    	// D:\\lesscss.g:73:5: NUM ( UNIT )?
                    	{
                    		NUM29=(IToken)Match(input,NUM,FOLLOW_NUM_in_numeric393); 
                    			NUM29_tree = (CommonTree)adaptor.Create(NUM29);
                    			adaptor.AddChild(root_0, NUM29_tree);

                    		// D:\\lesscss.g:73:9: ( UNIT )?
                    		int alt9 = 2;
                    		int LA9_0 = input.LA(1);

                    		if ( (LA9_0 == UNIT) )
                    		{
                    		    alt9 = 1;
                    		}
                    		switch (alt9) 
                    		{
                    		    case 1 :
                    		        // D:\\lesscss.g:73:9: UNIT
                    		        {
                    		        	UNIT30=(IToken)Match(input,UNIT,FOLLOW_UNIT_in_numeric395); 
                    		        		UNIT30_tree = (CommonTree)adaptor.Create(UNIT30);
                    		        		adaptor.AddChild(root_0, UNIT30_tree);


                    		        }
                    		        break;

                    		}


                    	}


                    }
                    break;
                case 2 :
                    // D:\\lesscss.g:74:4: COLOR
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	COLOR31=(IToken)Match(input,COLOR,FOLLOW_COLOR_in_numeric402); 
                    		COLOR31_tree = (CommonTree)adaptor.Create(COLOR31);
                    		adaptor.AddChild(root_0, COLOR31_tree);


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "numeric"

    public class mediadefinition_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "mediadefinition"
    // D:\\lesscss.g:77:10: fragment mediadefinition : ( '@media' media '{' lessCss '}' ) ;
    public lesscssParser.mediadefinition_return mediadefinition() // throws RecognitionException [1]
    {   
        lesscssParser.mediadefinition_return retval = new lesscssParser.mediadefinition_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal32 = null;
        IToken char_literal34 = null;
        IToken char_literal36 = null;
        lesscssParser.media_return media33 = null;

        lesscssParser.lessCss_return lessCss35 = null;


        CommonTree string_literal32_tree=null;
        CommonTree char_literal34_tree=null;
        CommonTree char_literal36_tree=null;

        try 
    	{
            // D:\\lesscss.g:78:2: ( ( '@media' media '{' lessCss '}' ) )
            // D:\\lesscss.g:78:4: ( '@media' media '{' lessCss '}' )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// D:\\lesscss.g:78:4: ( '@media' media '{' lessCss '}' )
            	// D:\\lesscss.g:78:5: '@media' media '{' lessCss '}'
            	{
            		string_literal32=(IToken)Match(input,39,FOLLOW_39_in_mediadefinition418); 
            			string_literal32_tree = (CommonTree)adaptor.Create(string_literal32);
            			adaptor.AddChild(root_0, string_literal32_tree);

            		PushFollow(FOLLOW_media_in_mediadefinition420);
            		media33 = media();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, media33.Tree);
            		char_literal34=(IToken)Match(input,40,FOLLOW_40_in_mediadefinition422); 
            			char_literal34_tree = (CommonTree)adaptor.Create(char_literal34);
            			adaptor.AddChild(root_0, char_literal34_tree);

            		PushFollow(FOLLOW_lessCss_in_mediadefinition424);
            		lessCss35 = lessCss();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, lessCss35.Tree);
            		char_literal36=(IToken)Match(input,41,FOLLOW_41_in_mediadefinition426); 
            			char_literal36_tree = (CommonTree)adaptor.Create(char_literal36);
            			adaptor.AddChild(root_0, char_literal36_tree);


            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "mediadefinition"

    public class ruleset_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "ruleset"
    // D:\\lesscss.g:80:10: fragment ruleset : selectors '{' ( ruleContents )* '}' -> ^( RULE selectors ( ruleContents )* ) ;
    public lesscssParser.ruleset_return ruleset() // throws RecognitionException [1]
    {   
        lesscssParser.ruleset_return retval = new lesscssParser.ruleset_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal38 = null;
        IToken char_literal40 = null;
        lesscssParser.selectors_return selectors37 = null;

        lesscssParser.ruleContents_return ruleContents39 = null;


        CommonTree char_literal38_tree=null;
        CommonTree char_literal40_tree=null;
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleSubtreeStream stream_ruleContents = new RewriteRuleSubtreeStream(adaptor,"rule ruleContents");
        RewriteRuleSubtreeStream stream_selectors = new RewriteRuleSubtreeStream(adaptor,"rule selectors");
        try 
    	{
            // D:\\lesscss.g:81:2: ( selectors '{' ( ruleContents )* '}' -> ^( RULE selectors ( ruleContents )* ) )
            // D:\\lesscss.g:81:4: selectors '{' ( ruleContents )* '}'
            {
            	PushFollow(FOLLOW_selectors_in_ruleset441);
            	selectors37 = selectors();
            	state.followingStackPointer--;

            	stream_selectors.Add(selectors37.Tree);
            	char_literal38=(IToken)Match(input,40,FOLLOW_40_in_ruleset443);  
            	stream_40.Add(char_literal38);

            	// D:\\lesscss.g:81:18: ( ruleContents )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == IDENT || (LA11_0 >= SelectorClass && LA11_0 <= SelectorID) || LA11_0 == 34 || LA11_0 == 52) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // D:\\lesscss.g:81:18: ruleContents
            			    {
            			    	PushFollow(FOLLOW_ruleContents_in_ruleset445);
            			    	ruleContents39 = ruleContents();
            			    	state.followingStackPointer--;

            			    	stream_ruleContents.Add(ruleContents39.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	char_literal40=(IToken)Match(input,41,FOLLOW_41_in_ruleset448);  
            	stream_41.Add(char_literal40);



            	// AST REWRITE
            	// elements:          ruleContents, selectors
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 81:36: -> ^( RULE selectors ( ruleContents )* )
            	{
            	    // D:\\lesscss.g:81:39: ^( RULE selectors ( ruleContents )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(RULE, "RULE"), root_1);

            	    adaptor.AddChild(root_1, stream_selectors.NextTree());
            	    // D:\\lesscss.g:81:56: ( ruleContents )*
            	    while ( stream_ruleContents.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_ruleContents.NextTree());

            	    }
            	    stream_ruleContents.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "ruleset"

    public class ruleContents_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "ruleContents"
    // D:\\lesscss.g:84:10: fragment ruleContents : ( property -> ^( PROPERTY property ) | ( ( selectors ';' ) -> ^( MIXIN selectors ) ) | ruleset );
    public lesscssParser.ruleContents_return ruleContents() // throws RecognitionException [1]
    {   
        lesscssParser.ruleContents_return retval = new lesscssParser.ruleContents_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal43 = null;
        lesscssParser.property_return property41 = null;

        lesscssParser.selectors_return selectors42 = null;

        lesscssParser.ruleset_return ruleset44 = null;


        CommonTree char_literal43_tree=null;
        RewriteRuleTokenStream stream_32 = new RewriteRuleTokenStream(adaptor,"token 32");
        RewriteRuleSubtreeStream stream_selectors = new RewriteRuleSubtreeStream(adaptor,"rule selectors");
        RewriteRuleSubtreeStream stream_property = new RewriteRuleSubtreeStream(adaptor,"rule property");
        try 
    	{
            // D:\\lesscss.g:85:2: ( property -> ^( PROPERTY property ) | ( ( selectors ';' ) -> ^( MIXIN selectors ) ) | ruleset )
            int alt12 = 3;
            alt12 = dfa12.Predict(input);
            switch (alt12) 
            {
                case 1 :
                    // D:\\lesscss.g:85:4: property
                    {
                    	PushFollow(FOLLOW_property_in_ruleContents473);
                    	property41 = property();
                    	state.followingStackPointer--;

                    	stream_property.Add(property41.Tree);


                    	// AST REWRITE
                    	// elements:          property
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 85:13: -> ^( PROPERTY property )
                    	{
                    	    // D:\\lesscss.g:85:16: ^( PROPERTY property )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PROPERTY, "PROPERTY"), root_1);

                    	    adaptor.AddChild(root_1, stream_property.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // D:\\lesscss.g:85:39: ( ( selectors ';' ) -> ^( MIXIN selectors ) )
                    {
                    	// D:\\lesscss.g:85:39: ( ( selectors ';' ) -> ^( MIXIN selectors ) )
                    	// D:\\lesscss.g:85:40: ( selectors ';' )
                    	{
                    		// D:\\lesscss.g:85:40: ( selectors ';' )
                    		// D:\\lesscss.g:85:41: selectors ';'
                    		{
                    			PushFollow(FOLLOW_selectors_in_ruleContents487);
                    			selectors42 = selectors();
                    			state.followingStackPointer--;

                    			stream_selectors.Add(selectors42.Tree);
                    			char_literal43=(IToken)Match(input,32,FOLLOW_32_in_ruleContents489);  
                    			stream_32.Add(char_literal43);


                    		}



                    		// AST REWRITE
                    		// elements:          selectors
                    		// token labels:      
                    		// rule labels:       retval
                    		// token list labels: 
                    		// rule list labels:  
                    		// wildcard labels: 
                    		retval.Tree = root_0;
                    		RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    		root_0 = (CommonTree)adaptor.GetNilNode();
                    		// 85:56: -> ^( MIXIN selectors )
                    		{
                    		    // D:\\lesscss.g:85:59: ^( MIXIN selectors )
                    		    {
                    		    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    		    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(MIXIN, "MIXIN"), root_1);

                    		    adaptor.AddChild(root_1, stream_selectors.NextTree());

                    		    adaptor.AddChild(root_0, root_1);
                    		    }

                    		}

                    		retval.Tree = root_0;retval.Tree = root_0;
                    	}


                    }
                    break;
                case 3 :
                    // D:\\lesscss.g:85:81: ruleset
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ruleset_in_ruleContents503);
                    	ruleset44 = ruleset();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ruleset44.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "ruleContents"

    public class media_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "media"
    // D:\\lesscss.g:87:10: fragment media : ( 'all' | 'braille' | 'embossed' | 'handheld' | 'print' | 'projection' | 'screen' | 'speech' | 'tty' | 'tv' );
    public lesscssParser.media_return media() // throws RecognitionException [1]
    {   
        lesscssParser.media_return retval = new lesscssParser.media_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set45 = null;

        CommonTree set45_tree=null;

        try 
    	{
            // D:\\lesscss.g:87:17: ( 'all' | 'braille' | 'embossed' | 'handheld' | 'print' | 'projection' | 'screen' | 'speech' | 'tty' | 'tv' )
            // D:\\lesscss.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set45 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 42 && input.LA(1) <= 51) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set45));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "media"

    public class selectors_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "selectors"
    // D:\\lesscss.g:89:10: fragment selectors : selectorGrouping ( ',' selectorGrouping )* -> ^( SELECTORGROUP ( selectorGrouping )+ ) ;
    public lesscssParser.selectors_return selectors() // throws RecognitionException [1]
    {   
        lesscssParser.selectors_return retval = new lesscssParser.selectors_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal47 = null;
        lesscssParser.selectorGrouping_return selectorGrouping46 = null;

        lesscssParser.selectorGrouping_return selectorGrouping48 = null;


        CommonTree char_literal47_tree=null;
        RewriteRuleTokenStream stream_33 = new RewriteRuleTokenStream(adaptor,"token 33");
        RewriteRuleSubtreeStream stream_selectorGrouping = new RewriteRuleSubtreeStream(adaptor,"rule selectorGrouping");
        try 
    	{
            // D:\\lesscss.g:90:2: ( selectorGrouping ( ',' selectorGrouping )* -> ^( SELECTORGROUP ( selectorGrouping )+ ) )
            // D:\\lesscss.g:90:4: selectorGrouping ( ',' selectorGrouping )*
            {
            	PushFollow(FOLLOW_selectorGrouping_in_selectors543);
            	selectorGrouping46 = selectorGrouping();
            	state.followingStackPointer--;

            	stream_selectorGrouping.Add(selectorGrouping46.Tree);
            	// D:\\lesscss.g:90:21: ( ',' selectorGrouping )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( (LA13_0 == 33) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // D:\\lesscss.g:90:22: ',' selectorGrouping
            			    {
            			    	char_literal47=(IToken)Match(input,33,FOLLOW_33_in_selectors546);  
            			    	stream_33.Add(char_literal47);

            			    	PushFollow(FOLLOW_selectorGrouping_in_selectors548);
            			    	selectorGrouping48 = selectorGrouping();
            			    	state.followingStackPointer--;

            			    	stream_selectorGrouping.Add(selectorGrouping48.Tree);

            			    }
            			    break;

            			default:
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements



            	// AST REWRITE
            	// elements:          selectorGrouping
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 90:45: -> ^( SELECTORGROUP ( selectorGrouping )+ )
            	{
            	    // D:\\lesscss.g:90:48: ^( SELECTORGROUP ( selectorGrouping )+ )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(SELECTORGROUP, "SELECTORGROUP"), root_1);

            	    if ( !(stream_selectorGrouping.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_selectorGrouping.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_selectorGrouping.NextTree());

            	    }
            	    stream_selectorGrouping.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "selectors"

    public class selectorGrouping_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "selectorGrouping"
    // D:\\lesscss.g:93:10: fragment selectorGrouping : ( ( selectorOps )? selector )+ -> ^( SELECTOR ( selector )+ ) ;
    public lesscssParser.selectorGrouping_return selectorGrouping() // throws RecognitionException [1]
    {   
        lesscssParser.selectorGrouping_return retval = new lesscssParser.selectorGrouping_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.selectorOps_return selectorOps49 = null;

        lesscssParser.selector_return selector50 = null;


        RewriteRuleSubtreeStream stream_selector = new RewriteRuleSubtreeStream(adaptor,"rule selector");
        RewriteRuleSubtreeStream stream_selectorOps = new RewriteRuleSubtreeStream(adaptor,"rule selectorOps");
        try 
    	{
            // D:\\lesscss.g:94:2: ( ( ( selectorOps )? selector )+ -> ^( SELECTOR ( selector )+ ) )
            // D:\\lesscss.g:94:4: ( ( selectorOps )? selector )+
            {
            	// D:\\lesscss.g:94:4: ( ( selectorOps )? selector )+
            	int cnt15 = 0;
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( (LA15_0 == IDENT || (LA15_0 >= SelectorClass && LA15_0 <= SelectorID) || LA15_0 == 34 || LA15_0 == 52) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // D:\\lesscss.g:94:5: ( selectorOps )? selector
            			    {
            			    	// D:\\lesscss.g:94:5: ( selectorOps )?
            			    	int alt14 = 2;
            			    	int LA14_0 = input.LA(1);

            			    	if ( (LA14_0 == 34 || LA14_0 == 52) )
            			    	{
            			    	    alt14 = 1;
            			    	}
            			    	switch (alt14) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\lesscss.g:94:5: selectorOps
            			    	        {
            			    	        	PushFollow(FOLLOW_selectorOps_in_selectorGrouping574);
            			    	        	selectorOps49 = selectorOps();
            			    	        	state.followingStackPointer--;

            			    	        	stream_selectorOps.Add(selectorOps49.Tree);

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_selector_in_selectorGrouping577);
            			    	selector50 = selector();
            			    	state.followingStackPointer--;

            			    	stream_selector.Add(selector50.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt15 >= 1 ) goto loop15;
            		            EarlyExitException eee15 =
            		                new EarlyExitException(15, input);
            		            throw eee15;
            	    }
            	    cnt15++;
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whinging that label 'loop15' has no statements



            	// AST REWRITE
            	// elements:          selector
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 94:29: -> ^( SELECTOR ( selector )+ )
            	{
            	    // D:\\lesscss.g:94:32: ^( SELECTOR ( selector )+ )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(SELECTOR, "SELECTOR"), root_1);

            	    if ( !(stream_selector.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_selector.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_selector.NextTree());

            	    }
            	    stream_selector.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "selectorGrouping"

    public class property_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "property"
    // D:\\lesscss.g:98:10: fragment property : IDENT ':' ( propval )+ ';' -> IDENT ( propval )+ ;
    public lesscssParser.property_return property() // throws RecognitionException [1]
    {   
        lesscssParser.property_return retval = new lesscssParser.property_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken IDENT51 = null;
        IToken char_literal52 = null;
        IToken char_literal54 = null;
        lesscssParser.propval_return propval53 = null;


        CommonTree IDENT51_tree=null;
        CommonTree char_literal52_tree=null;
        CommonTree char_literal54_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_32 = new RewriteRuleTokenStream(adaptor,"token 32");
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleSubtreeStream stream_propval = new RewriteRuleSubtreeStream(adaptor,"rule propval");
        try 
    	{
            // D:\\lesscss.g:99:2: ( IDENT ':' ( propval )+ ';' -> IDENT ( propval )+ )
            // D:\\lesscss.g:99:4: IDENT ':' ( propval )+ ';'
            {
            	IDENT51=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_property603);  
            	stream_IDENT.Add(IDENT51);

            	char_literal52=(IToken)Match(input,31,FOLLOW_31_in_property605);  
            	stream_31.Add(char_literal52);

            	// D:\\lesscss.g:99:14: ( propval )+
            	int cnt16 = 0;
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( ((LA16_0 >= IDENT && LA16_0 <= STRING) || LA16_0 == NUM || LA16_0 == COLOR || LA16_0 == 30 || LA16_0 == 37) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // D:\\lesscss.g:99:14: propval
            			    {
            			    	PushFollow(FOLLOW_propval_in_property607);
            			    	propval53 = propval();
            			    	state.followingStackPointer--;

            			    	stream_propval.Add(propval53.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt16 >= 1 ) goto loop16;
            		            EarlyExitException eee16 =
            		                new EarlyExitException(16, input);
            		            throw eee16;
            	    }
            	    cnt16++;
            	} while (true);

            	loop16:
            		;	// Stops C# compiler whinging that label 'loop16' has no statements

            	char_literal54=(IToken)Match(input,32,FOLLOW_32_in_property610);  
            	stream_32.Add(char_literal54);



            	// AST REWRITE
            	// elements:          propval, IDENT
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 99:27: -> IDENT ( propval )+
            	{
            	    adaptor.AddChild(root_0, stream_IDENT.NextNode());
            	    if ( !(stream_propval.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_propval.HasNext() )
            	    {
            	        adaptor.AddChild(root_0, stream_propval.NextTree());

            	    }
            	    stream_propval.Reset();

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "property"

    public class propval_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "propval"
    // D:\\lesscss.g:102:10: fragment propval : ( additiveExpression -> ^( EXPR additiveExpression ) | literal );
    public lesscssParser.propval_return propval() // throws RecognitionException [1]
    {   
        lesscssParser.propval_return retval = new lesscssParser.propval_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.additiveExpression_return additiveExpression55 = null;

        lesscssParser.literal_return literal56 = null;


        RewriteRuleSubtreeStream stream_additiveExpression = new RewriteRuleSubtreeStream(adaptor,"rule additiveExpression");
        try 
    	{
            // D:\\lesscss.g:103:2: ( additiveExpression -> ^( EXPR additiveExpression ) | literal )
            int alt17 = 2;
            int LA17_0 = input.LA(1);

            if ( (LA17_0 == NUM || LA17_0 == COLOR || LA17_0 == 30 || LA17_0 == 37) )
            {
                alt17 = 1;
            }
            else if ( ((LA17_0 >= IDENT && LA17_0 <= STRING)) )
            {
                alt17 = 2;
            }
            else 
            {
                NoViableAltException nvae_d17s0 =
                    new NoViableAltException("", 17, 0, input);

                throw nvae_d17s0;
            }
            switch (alt17) 
            {
                case 1 :
                    // D:\\lesscss.g:103:4: additiveExpression
                    {
                    	PushFollow(FOLLOW_additiveExpression_in_propval630);
                    	additiveExpression55 = additiveExpression();
                    	state.followingStackPointer--;

                    	stream_additiveExpression.Add(additiveExpression55.Tree);


                    	// AST REWRITE
                    	// elements:          additiveExpression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 103:23: -> ^( EXPR additiveExpression )
                    	{
                    	    // D:\\lesscss.g:103:26: ^( EXPR additiveExpression )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(EXPR, "EXPR"), root_1);

                    	    adaptor.AddChild(root_1, stream_additiveExpression.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // D:\\lesscss.g:103:55: literal
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_literal_in_propval642);
                    	literal56 = literal();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, literal56.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "propval"

    public class selector_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "selector"
    // D:\\lesscss.g:105:10: fragment selector : ( IDENT | SelectorClass | SelectorID );
    public lesscssParser.selector_return selector() // throws RecognitionException [1]
    {   
        lesscssParser.selector_return retval = new lesscssParser.selector_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set57 = null;

        CommonTree set57_tree=null;

        try 
    	{
            // D:\\lesscss.g:106:2: ( IDENT | SelectorClass | SelectorID )
            // D:\\lesscss.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set57 = (IToken)input.LT(1);
            	if ( input.LA(1) == IDENT || (input.LA(1) >= SelectorClass && input.LA(1) <= SelectorID) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set57));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "selector"

    public class selectorOps_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "selectorOps"
    // D:\\lesscss.g:110:10: fragment selectorOps : ( '>' | '+' );
    public lesscssParser.selectorOps_return selectorOps() // throws RecognitionException [1]
    {   
        lesscssParser.selectorOps_return retval = new lesscssParser.selectorOps_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set58 = null;

        CommonTree set58_tree=null;

        try 
    	{
            // D:\\lesscss.g:111:2: ( '>' | '+' )
            // D:\\lesscss.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set58 = (IToken)input.LT(1);
            	if ( input.LA(1) == 34 || input.LA(1) == 52 ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set58));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "selectorOps"

    public class val_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "val"
    // D:\\lesscss.g:115:1: val : ( IDENT '(' ( STRING | ( NUM ( UNIT )? ) | COLOR ) ( ',' ( STRING | ( NUM ( UNIT )? ) | COLOR ) )* ')' | IDENT | STRING | ( NUM ( UNIT )? ) | COLOR );
    public lesscssParser.val_return val() // throws RecognitionException [1]
    {   
        lesscssParser.val_return retval = new lesscssParser.val_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken IDENT59 = null;
        IToken char_literal60 = null;
        IToken STRING61 = null;
        IToken NUM62 = null;
        IToken UNIT63 = null;
        IToken COLOR64 = null;
        IToken char_literal65 = null;
        IToken STRING66 = null;
        IToken NUM67 = null;
        IToken UNIT68 = null;
        IToken COLOR69 = null;
        IToken char_literal70 = null;
        IToken IDENT71 = null;
        IToken STRING72 = null;
        IToken NUM73 = null;
        IToken UNIT74 = null;
        IToken COLOR75 = null;

        CommonTree IDENT59_tree=null;
        CommonTree char_literal60_tree=null;
        CommonTree STRING61_tree=null;
        CommonTree NUM62_tree=null;
        CommonTree UNIT63_tree=null;
        CommonTree COLOR64_tree=null;
        CommonTree char_literal65_tree=null;
        CommonTree STRING66_tree=null;
        CommonTree NUM67_tree=null;
        CommonTree UNIT68_tree=null;
        CommonTree COLOR69_tree=null;
        CommonTree char_literal70_tree=null;
        CommonTree IDENT71_tree=null;
        CommonTree STRING72_tree=null;
        CommonTree NUM73_tree=null;
        CommonTree UNIT74_tree=null;
        CommonTree COLOR75_tree=null;

        try 
    	{
            // D:\\lesscss.g:116:2: ( IDENT '(' ( STRING | ( NUM ( UNIT )? ) | COLOR ) ( ',' ( STRING | ( NUM ( UNIT )? ) | COLOR ) )* ')' | IDENT | STRING | ( NUM ( UNIT )? ) | COLOR )
            int alt24 = 5;
            switch ( input.LA(1) ) 
            {
            case IDENT:
            	{
                int LA24_1 = input.LA(2);

                if ( (LA24_1 == 37) )
                {
                    alt24 = 1;
                }
                else if ( (LA24_1 == EOF) )
                {
                    alt24 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d24s1 =
                        new NoViableAltException("", 24, 1, input);

                    throw nvae_d24s1;
                }
                }
                break;
            case STRING:
            	{
                alt24 = 3;
                }
                break;
            case NUM:
            	{
                alt24 = 4;
                }
                break;
            case COLOR:
            	{
                alt24 = 5;
                }
                break;
            	default:
            	    NoViableAltException nvae_d24s0 =
            	        new NoViableAltException("", 24, 0, input);

            	    throw nvae_d24s0;
            }

            switch (alt24) 
            {
                case 1 :
                    // D:\\lesscss.g:116:4: IDENT '(' ( STRING | ( NUM ( UNIT )? ) | COLOR ) ( ',' ( STRING | ( NUM ( UNIT )? ) | COLOR ) )* ')'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	IDENT59=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_val697); 
                    		IDENT59_tree = (CommonTree)adaptor.Create(IDENT59);
                    		adaptor.AddChild(root_0, IDENT59_tree);

                    	char_literal60=(IToken)Match(input,37,FOLLOW_37_in_val699); 
                    		char_literal60_tree = (CommonTree)adaptor.Create(char_literal60);
                    		adaptor.AddChild(root_0, char_literal60_tree);

                    	// D:\\lesscss.g:116:14: ( STRING | ( NUM ( UNIT )? ) | COLOR )
                    	int alt19 = 3;
                    	switch ( input.LA(1) ) 
                    	{
                    	case STRING:
                    		{
                    	    alt19 = 1;
                    	    }
                    	    break;
                    	case NUM:
                    		{
                    	    alt19 = 2;
                    	    }
                    	    break;
                    	case COLOR:
                    		{
                    	    alt19 = 3;
                    	    }
                    	    break;
                    		default:
                    		    NoViableAltException nvae_d19s0 =
                    		        new NoViableAltException("", 19, 0, input);

                    		    throw nvae_d19s0;
                    	}

                    	switch (alt19) 
                    	{
                    	    case 1 :
                    	        // D:\\lesscss.g:116:15: STRING
                    	        {
                    	        	STRING61=(IToken)Match(input,STRING,FOLLOW_STRING_in_val702); 
                    	        		STRING61_tree = (CommonTree)adaptor.Create(STRING61);
                    	        		adaptor.AddChild(root_0, STRING61_tree);


                    	        }
                    	        break;
                    	    case 2 :
                    	        // D:\\lesscss.g:116:24: ( NUM ( UNIT )? )
                    	        {
                    	        	// D:\\lesscss.g:116:24: ( NUM ( UNIT )? )
                    	        	// D:\\lesscss.g:116:25: NUM ( UNIT )?
                    	        	{
                    	        		NUM62=(IToken)Match(input,NUM,FOLLOW_NUM_in_val707); 
                    	        			NUM62_tree = (CommonTree)adaptor.Create(NUM62);
                    	        			adaptor.AddChild(root_0, NUM62_tree);

                    	        		// D:\\lesscss.g:116:29: ( UNIT )?
                    	        		int alt18 = 2;
                    	        		int LA18_0 = input.LA(1);

                    	        		if ( (LA18_0 == UNIT) )
                    	        		{
                    	        		    alt18 = 1;
                    	        		}
                    	        		switch (alt18) 
                    	        		{
                    	        		    case 1 :
                    	        		        // D:\\lesscss.g:116:29: UNIT
                    	        		        {
                    	        		        	UNIT63=(IToken)Match(input,UNIT,FOLLOW_UNIT_in_val709); 
                    	        		        		UNIT63_tree = (CommonTree)adaptor.Create(UNIT63);
                    	        		        		adaptor.AddChild(root_0, UNIT63_tree);


                    	        		        }
                    	        		        break;

                    	        		}


                    	        	}


                    	        }
                    	        break;
                    	    case 3 :
                    	        // D:\\lesscss.g:116:38: COLOR
                    	        {
                    	        	COLOR64=(IToken)Match(input,COLOR,FOLLOW_COLOR_in_val715); 
                    	        		COLOR64_tree = (CommonTree)adaptor.Create(COLOR64);
                    	        		adaptor.AddChild(root_0, COLOR64_tree);


                    	        }
                    	        break;

                    	}

                    	// D:\\lesscss.g:116:45: ( ',' ( STRING | ( NUM ( UNIT )? ) | COLOR ) )*
                    	do 
                    	{
                    	    int alt22 = 2;
                    	    int LA22_0 = input.LA(1);

                    	    if ( (LA22_0 == 33) )
                    	    {
                    	        alt22 = 1;
                    	    }


                    	    switch (alt22) 
                    		{
                    			case 1 :
                    			    // D:\\lesscss.g:116:46: ',' ( STRING | ( NUM ( UNIT )? ) | COLOR )
                    			    {
                    			    	char_literal65=(IToken)Match(input,33,FOLLOW_33_in_val719); 
                    			    		char_literal65_tree = (CommonTree)adaptor.Create(char_literal65);
                    			    		adaptor.AddChild(root_0, char_literal65_tree);

                    			    	// D:\\lesscss.g:116:50: ( STRING | ( NUM ( UNIT )? ) | COLOR )
                    			    	int alt21 = 3;
                    			    	switch ( input.LA(1) ) 
                    			    	{
                    			    	case STRING:
                    			    		{
                    			    	    alt21 = 1;
                    			    	    }
                    			    	    break;
                    			    	case NUM:
                    			    		{
                    			    	    alt21 = 2;
                    			    	    }
                    			    	    break;
                    			    	case COLOR:
                    			    		{
                    			    	    alt21 = 3;
                    			    	    }
                    			    	    break;
                    			    		default:
                    			    		    NoViableAltException nvae_d21s0 =
                    			    		        new NoViableAltException("", 21, 0, input);

                    			    		    throw nvae_d21s0;
                    			    	}

                    			    	switch (alt21) 
                    			    	{
                    			    	    case 1 :
                    			    	        // D:\\lesscss.g:116:51: STRING
                    			    	        {
                    			    	        	STRING66=(IToken)Match(input,STRING,FOLLOW_STRING_in_val722); 
                    			    	        		STRING66_tree = (CommonTree)adaptor.Create(STRING66);
                    			    	        		adaptor.AddChild(root_0, STRING66_tree);


                    			    	        }
                    			    	        break;
                    			    	    case 2 :
                    			    	        // D:\\lesscss.g:116:58: ( NUM ( UNIT )? )
                    			    	        {
                    			    	        	// D:\\lesscss.g:116:58: ( NUM ( UNIT )? )
                    			    	        	// D:\\lesscss.g:116:59: NUM ( UNIT )?
                    			    	        	{
                    			    	        		NUM67=(IToken)Match(input,NUM,FOLLOW_NUM_in_val725); 
                    			    	        			NUM67_tree = (CommonTree)adaptor.Create(NUM67);
                    			    	        			adaptor.AddChild(root_0, NUM67_tree);

                    			    	        		// D:\\lesscss.g:116:63: ( UNIT )?
                    			    	        		int alt20 = 2;
                    			    	        		int LA20_0 = input.LA(1);

                    			    	        		if ( (LA20_0 == UNIT) )
                    			    	        		{
                    			    	        		    alt20 = 1;
                    			    	        		}
                    			    	        		switch (alt20) 
                    			    	        		{
                    			    	        		    case 1 :
                    			    	        		        // D:\\lesscss.g:116:63: UNIT
                    			    	        		        {
                    			    	        		        	UNIT68=(IToken)Match(input,UNIT,FOLLOW_UNIT_in_val727); 
                    			    	        		        		UNIT68_tree = (CommonTree)adaptor.Create(UNIT68);
                    			    	        		        		adaptor.AddChild(root_0, UNIT68_tree);


                    			    	        		        }
                    			    	        		        break;

                    			    	        		}


                    			    	        	}


                    			    	        }
                    			    	        break;
                    			    	    case 3 :
                    			    	        // D:\\lesscss.g:116:70: COLOR
                    			    	        {
                    			    	        	COLOR69=(IToken)Match(input,COLOR,FOLLOW_COLOR_in_val731); 
                    			    	        		COLOR69_tree = (CommonTree)adaptor.Create(COLOR69);
                    			    	        		adaptor.AddChild(root_0, COLOR69_tree);


                    			    	        }
                    			    	        break;

                    			    	}


                    			    }
                    			    break;

                    			default:
                    			    goto loop22;
                    	    }
                    	} while (true);

                    	loop22:
                    		;	// Stops C# compiler whining that label 'loop22' has no statements

                    	char_literal70=(IToken)Match(input,38,FOLLOW_38_in_val736); 
                    		char_literal70_tree = (CommonTree)adaptor.Create(char_literal70);
                    		adaptor.AddChild(root_0, char_literal70_tree);


                    }
                    break;
                case 2 :
                    // D:\\lesscss.g:117:4: IDENT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	IDENT71=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_val741); 
                    		IDENT71_tree = (CommonTree)adaptor.Create(IDENT71);
                    		adaptor.AddChild(root_0, IDENT71_tree);


                    }
                    break;
                case 3 :
                    // D:\\lesscss.g:118:4: STRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	STRING72=(IToken)Match(input,STRING,FOLLOW_STRING_in_val746); 
                    		STRING72_tree = (CommonTree)adaptor.Create(STRING72);
                    		adaptor.AddChild(root_0, STRING72_tree);


                    }
                    break;
                case 4 :
                    // D:\\lesscss.g:119:4: ( NUM ( UNIT )? )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// D:\\lesscss.g:119:4: ( NUM ( UNIT )? )
                    	// D:\\lesscss.g:119:5: NUM ( UNIT )?
                    	{
                    		NUM73=(IToken)Match(input,NUM,FOLLOW_NUM_in_val752); 
                    			NUM73_tree = (CommonTree)adaptor.Create(NUM73);
                    			adaptor.AddChild(root_0, NUM73_tree);

                    		// D:\\lesscss.g:119:9: ( UNIT )?
                    		int alt23 = 2;
                    		int LA23_0 = input.LA(1);

                    		if ( (LA23_0 == UNIT) )
                    		{
                    		    alt23 = 1;
                    		}
                    		switch (alt23) 
                    		{
                    		    case 1 :
                    		        // D:\\lesscss.g:119:9: UNIT
                    		        {
                    		        	UNIT74=(IToken)Match(input,UNIT,FOLLOW_UNIT_in_val754); 
                    		        		UNIT74_tree = (CommonTree)adaptor.Create(UNIT74);
                    		        		adaptor.AddChild(root_0, UNIT74_tree);


                    		        }
                    		        break;

                    		}


                    	}


                    }
                    break;
                case 5 :
                    // D:\\lesscss.g:120:4: COLOR
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	COLOR75=(IToken)Match(input,COLOR,FOLLOW_COLOR_in_val761); 
                    		COLOR75_tree = (CommonTree)adaptor.Create(COLOR75);
                    		adaptor.AddChild(root_0, COLOR75_tree);


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "val"

    // Delegated rules


   	protected DFA12 dfa12;
	private void InitializeCyclicDFAs()
	{
    	this.dfa12 = new DFA12(this);
	}

    const string DFA12_eotS =
        "\x0a\uffff";
    const string DFA12_eofS =
        "\x0a\uffff";
    const string DFA12_minS =
        "\x04\x12\x01\uffff\x01\x12\x02\uffff\x02\x12";
    const string DFA12_maxS =
        "\x02\x34\x01\x19\x01\x34\x01\uffff\x01\x34\x02\uffff\x01\x19\x01"+
        "\x34";
    const string DFA12_acceptS =
        "\x04\uffff\x01\x01\x01\uffff\x01\x03\x01\x02\x02\uffff";
    const string DFA12_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA12_transitionS = {
            "\x01\x01\x05\uffff\x02\x03\x08\uffff\x01\x02\x11\uffff\x01"+
            "\x02",
            "\x01\x03\x05\uffff\x02\x03\x05\uffff\x01\x04\x01\x07\x01\x05"+
            "\x01\x02\x05\uffff\x01\x06\x0b\uffff\x01\x02",
            "\x01\x03\x05\uffff\x02\x03",
            "\x01\x03\x05\uffff\x02\x03\x06\uffff\x01\x07\x01\x05\x01\x02"+
            "\x05\uffff\x01\x06\x0b\uffff\x01\x02",
            "",
            "\x01\x09\x05\uffff\x02\x09\x08\uffff\x01\x08\x11\uffff\x01"+
            "\x08",
            "",
            "",
            "\x01\x09\x05\uffff\x02\x09",
            "\x01\x09\x05\uffff\x02\x09\x06\uffff\x01\x07\x01\x05\x01\x08"+
            "\x05\uffff\x01\x06\x0b\uffff\x01\x08"
    };

    static readonly short[] DFA12_eot = DFA.UnpackEncodedString(DFA12_eotS);
    static readonly short[] DFA12_eof = DFA.UnpackEncodedString(DFA12_eofS);
    static readonly char[] DFA12_min = DFA.UnpackEncodedStringToUnsignedChars(DFA12_minS);
    static readonly char[] DFA12_max = DFA.UnpackEncodedStringToUnsignedChars(DFA12_maxS);
    static readonly short[] DFA12_accept = DFA.UnpackEncodedString(DFA12_acceptS);
    static readonly short[] DFA12_special = DFA.UnpackEncodedString(DFA12_specialS);
    static readonly short[][] DFA12_transition = DFA.UnpackEncodedStringArray(DFA12_transitionS);

    protected class DFA12 : DFA
    {
        public DFA12(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 12;
            this.eot = DFA12_eot;
            this.eof = DFA12_eof;
            this.min = DFA12_min;
            this.max = DFA12_max;
            this.accept = DFA12_accept;
            this.special = DFA12_special;
            this.transition = DFA12_transition;

        }

        override public string Description
        {
            get { return "84:10: fragment ruleContents : ( property -> ^( PROPERTY property ) | ( ( selectors ';' ) -> ^( MIXIN selectors ) ) | ruleset );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_lessLine_in_lessCss97 = new BitSet(new ulong[]{0x0010008443040002UL});
    public static readonly BitSet FOLLOW_30_in_variable114 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_IDENT_in_variable116 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_variable118 = new BitSet(new ulong[]{0x0000002040AC0000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_variable121 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_literal_in_variable135 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_variable148 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ruleset_in_lessLine160 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mediadefinition_in_lessLine164 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_lessLine169 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_literal194 = new BitSet(new ulong[]{0x0000000200000002UL});
    public static readonly BitSet FOLLOW_33_in_literal203 = new BitSet(new ulong[]{0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_set_in_literal205 = new BitSet(new ulong[]{0x0000000200000002UL});
    public static readonly BitSet FOLLOW_30_in_varname227 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_IDENT_in_varname229 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_expression248 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression269 = new BitSet(new ulong[]{0x0000000400100002UL});
    public static readonly BitSet FOLLOW_set_in_additiveExpression273 = new BitSet(new ulong[]{0x0000002040A00000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression280 = new BitSet(new ulong[]{0x0000000400100002UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_multiplicativeExpression305 = new BitSet(new ulong[]{0x0000001800000002UL});
    public static readonly BitSet FOLLOW_set_in_multiplicativeExpression309 = new BitSet(new ulong[]{0x0000002040A00000UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_multiplicativeExpression316 = new BitSet(new ulong[]{0x0000001800000002UL});
    public static readonly BitSet FOLLOW_37_in_primaryExpression331 = new BitSet(new ulong[]{0x0000002040A00000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_primaryExpression334 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_38_in_primaryExpression336 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_primaryExpression342 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varname_in_value358 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numeric_in_value372 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUM_in_numeric393 = new BitSet(new ulong[]{0x0000000000400002UL});
    public static readonly BitSet FOLLOW_UNIT_in_numeric395 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COLOR_in_numeric402 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_mediadefinition418 = new BitSet(new ulong[]{0x000FFC0000000000UL});
    public static readonly BitSet FOLLOW_media_in_mediadefinition420 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_mediadefinition422 = new BitSet(new ulong[]{0x0010008443040000UL});
    public static readonly BitSet FOLLOW_lessCss_in_mediadefinition424 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_mediadefinition426 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectors_in_ruleset441 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_ruleset443 = new BitSet(new ulong[]{0x0010020403040000UL});
    public static readonly BitSet FOLLOW_ruleContents_in_ruleset445 = new BitSet(new ulong[]{0x0010020403040000UL});
    public static readonly BitSet FOLLOW_41_in_ruleset448 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_property_in_ruleContents473 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectors_in_ruleContents487 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_ruleContents489 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ruleset_in_ruleContents503 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_media0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectorGrouping_in_selectors543 = new BitSet(new ulong[]{0x0000000200000002UL});
    public static readonly BitSet FOLLOW_33_in_selectors546 = new BitSet(new ulong[]{0x0010000403040000UL});
    public static readonly BitSet FOLLOW_selectorGrouping_in_selectors548 = new BitSet(new ulong[]{0x0000000200000002UL});
    public static readonly BitSet FOLLOW_selectorOps_in_selectorGrouping574 = new BitSet(new ulong[]{0x0010000403040000UL});
    public static readonly BitSet FOLLOW_selector_in_selectorGrouping577 = new BitSet(new ulong[]{0x0010000403040002UL});
    public static readonly BitSet FOLLOW_IDENT_in_property603 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_property605 = new BitSet(new ulong[]{0x0000002040AC0000UL});
    public static readonly BitSet FOLLOW_propval_in_property607 = new BitSet(new ulong[]{0x0000002140AC0000UL});
    public static readonly BitSet FOLLOW_32_in_property610 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_propval630 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_propval642 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_selector0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_selectorOps0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_val697 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_37_in_val699 = new BitSet(new ulong[]{0x0000000000A80000UL});
    public static readonly BitSet FOLLOW_STRING_in_val702 = new BitSet(new ulong[]{0x0000004200000000UL});
    public static readonly BitSet FOLLOW_NUM_in_val707 = new BitSet(new ulong[]{0x0000004200400000UL});
    public static readonly BitSet FOLLOW_UNIT_in_val709 = new BitSet(new ulong[]{0x0000004200000000UL});
    public static readonly BitSet FOLLOW_COLOR_in_val715 = new BitSet(new ulong[]{0x0000004200000000UL});
    public static readonly BitSet FOLLOW_33_in_val719 = new BitSet(new ulong[]{0x0000000000A80000UL});
    public static readonly BitSet FOLLOW_STRING_in_val722 = new BitSet(new ulong[]{0x0000004200000000UL});
    public static readonly BitSet FOLLOW_NUM_in_val725 = new BitSet(new ulong[]{0x0000004200400000UL});
    public static readonly BitSet FOLLOW_UNIT_in_val727 = new BitSet(new ulong[]{0x0000004200000000UL});
    public static readonly BitSet FOLLOW_COLOR_in_val731 = new BitSet(new ulong[]{0x0000004200000000UL});
    public static readonly BitSet FOLLOW_38_in_val736 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_val741 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_val746 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUM_in_val752 = new BitSet(new ulong[]{0x0000000000400002UL});
    public static readonly BitSet FOLLOW_UNIT_in_val754 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COLOR_in_val761 = new BitSet(new ulong[]{0x0000000000000002UL});

}
