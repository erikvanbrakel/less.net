// $ANTLR 3.1.2 D:\\lesscss.g 2009-08-03 22:55:31


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
		"EXPRESSION", 
		"PLUS", 
		"MINUS", 
		"MUL", 
		"DIV", 
		"IDENT", 
		"SelectorClass", 
		"SelectorID", 
		"PSEUDO", 
		"STRING", 
		"NUM", 
		"COLOR", 
		"UNIT", 
		"SL_COMMENT", 
		"COMMENT", 
		"WS", 
		"':'", 
		"';'", 
		"'@'", 
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
		"','", 
		"'>'", 
		"'+'", 
		"'('", 
		"')'", 
		"'-'", 
		"'*'", 
		"'/'"
    };

    public const int SELECTORGROUP = 7;
    public const int CLASS = 10;
    public const int PSEUDO = 22;
    public const int ID = 12;
    public const int EOF = -1;
    public const int COLOR = 25;
    public const int T__51 = 51;
    public const int SELECTOR = 8;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int WILDCARD = 13;
    public const int IDENT = 19;
    public const int PLUS = 15;
    public const int VAR = 4;
    public const int COMMENT = 28;
    public const int T__50 = 50;
    public const int EXPRESSION = 14;
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
    public const int MINUS = 16;
    public const int MUL = 17;
    public const int NUM = 24;
    public const int TAG = 11;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int UNIT = 26;
    public const int T__32 = 32;
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
    public const int SelectorID = 21;
    public const int SL_COMMENT = 27;
    public const int SelectorClass = 20;
    public const int DIV = 18;
    public const int STRING = 23;

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
    // D:\\lesscss.g:27:1: lessCss : ( lessLine )* ;
    public lesscssParser.lessCss_return lessCss() // throws RecognitionException [1]
    {   
        lesscssParser.lessCss_return retval = new lesscssParser.lessCss_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.lessLine_return lessLine1 = null;



        try 
    	{
            // D:\\lesscss.g:28:2: ( ( lessLine )* )
            // D:\\lesscss.g:28:4: ( lessLine )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// D:\\lesscss.g:28:4: ( lessLine )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= IDENT && LA1_0 <= SelectorID) || (LA1_0 >= 32 && LA1_0 <= 33) || (LA1_0 >= 47 && LA1_0 <= 48)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // D:\\lesscss.g:28:5: lessLine
            			    {
            			    	PushFollow(FOLLOW_lessLine_in_lessCss105);
            			    	lessLine1 = lessLine();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, lessLine1.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


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
    // D:\\lesscss.g:31:10: fragment lessLine : ( ruleset | mediadefinition | variable );
    public lesscssParser.lessLine_return lessLine() // throws RecognitionException [1]
    {   
        lesscssParser.lessLine_return retval = new lesscssParser.lessLine_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.ruleset_return ruleset2 = null;

        lesscssParser.mediadefinition_return mediadefinition3 = null;

        lesscssParser.variable_return variable4 = null;



        try 
    	{
            // D:\\lesscss.g:32:2: ( ruleset | mediadefinition | variable )
            int alt2 = 3;
            switch ( input.LA(1) ) 
            {
            case IDENT:
            case SelectorClass:
            case SelectorID:
            case 47:
            case 48:
            	{
                alt2 = 1;
                }
                break;
            case 33:
            	{
                alt2 = 2;
                }
                break;
            case 32:
            	{
                alt2 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    throw nvae_d2s0;
            }

            switch (alt2) 
            {
                case 1 :
                    // D:\\lesscss.g:32:4: ruleset
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ruleset_in_lessLine121);
                    	ruleset2 = ruleset();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ruleset2.Tree);

                    }
                    break;
                case 2 :
                    // D:\\lesscss.g:32:14: mediadefinition
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_mediadefinition_in_lessLine125);
                    	mediadefinition3 = mediadefinition();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, mediadefinition3.Tree);

                    }
                    break;
                case 3 :
                    // D:\\lesscss.g:32:32: variable
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variable_in_lessLine129);
                    	variable4 = variable();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variable4.Tree);

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
    // D:\\lesscss.g:36:10: fragment variable : varname ':' expression ';' -> ^( VAR varname expression ) ;
    public lesscssParser.variable_return variable() // throws RecognitionException [1]
    {   
        lesscssParser.variable_return retval = new lesscssParser.variable_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal6 = null;
        IToken char_literal8 = null;
        lesscssParser.varname_return varname5 = null;

        lesscssParser.expression_return expression7 = null;


        CommonTree char_literal6_tree=null;
        CommonTree char_literal8_tree=null;
        RewriteRuleTokenStream stream_30 = new RewriteRuleTokenStream(adaptor,"token 30");
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_varname = new RewriteRuleSubtreeStream(adaptor,"rule varname");
        try 
    	{
            // D:\\lesscss.g:37:2: ( varname ':' expression ';' -> ^( VAR varname expression ) )
            // D:\\lesscss.g:37:4: varname ':' expression ';'
            {
            	PushFollow(FOLLOW_varname_in_variable143);
            	varname5 = varname();
            	state.followingStackPointer--;

            	stream_varname.Add(varname5.Tree);
            	char_literal6=(IToken)Match(input,30,FOLLOW_30_in_variable145);  
            	stream_30.Add(char_literal6);

            	PushFollow(FOLLOW_expression_in_variable147);
            	expression7 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression7.Tree);
            	char_literal8=(IToken)Match(input,31,FOLLOW_31_in_variable149);  
            	stream_31.Add(char_literal8);



            	// AST REWRITE
            	// elements:          expression, varname
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 37:31: -> ^( VAR varname expression )
            	{
            	    // D:\\lesscss.g:37:34: ^( VAR varname expression )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(VAR, "VAR"), root_1);

            	    adaptor.AddChild(root_1, stream_varname.NextTree());
            	    adaptor.AddChild(root_1, stream_expression.NextTree());

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
    // $ANTLR end "variable"

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
    // D:\\lesscss.g:40:10: fragment varname : '@' IDENT -> IDENT ;
    public lesscssParser.varname_return varname() // throws RecognitionException [1]
    {   
        lesscssParser.varname_return retval = new lesscssParser.varname_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal9 = null;
        IToken IDENT10 = null;

        CommonTree char_literal9_tree=null;
        CommonTree IDENT10_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_32 = new RewriteRuleTokenStream(adaptor,"token 32");

        try 
    	{
            // D:\\lesscss.g:41:2: ( '@' IDENT -> IDENT )
            // D:\\lesscss.g:41:4: '@' IDENT
            {
            	char_literal9=(IToken)Match(input,32,FOLLOW_32_in_varname173);  
            	stream_32.Add(char_literal9);

            	IDENT10=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_varname175);  
            	stream_IDENT.Add(IDENT10);



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
            	// 41:14: -> IDENT
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
    // D:\\lesscss.g:45:10: fragment expression : expressionToken ( ( plus | minus | mul | div ) expression )* -> ^( EXPRESSION expressionToken ( expression )* ) ;
    public lesscssParser.expression_return expression() // throws RecognitionException [1]
    {   
        lesscssParser.expression_return retval = new lesscssParser.expression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.expressionToken_return expressionToken11 = null;

        lesscssParser.plus_return plus12 = null;

        lesscssParser.minus_return minus13 = null;

        lesscssParser.mul_return mul14 = null;

        lesscssParser.div_return div15 = null;

        lesscssParser.expression_return expression16 = null;


        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_plus = new RewriteRuleSubtreeStream(adaptor,"rule plus");
        RewriteRuleSubtreeStream stream_minus = new RewriteRuleSubtreeStream(adaptor,"rule minus");
        RewriteRuleSubtreeStream stream_expressionToken = new RewriteRuleSubtreeStream(adaptor,"rule expressionToken");
        RewriteRuleSubtreeStream stream_div = new RewriteRuleSubtreeStream(adaptor,"rule div");
        RewriteRuleSubtreeStream stream_mul = new RewriteRuleSubtreeStream(adaptor,"rule mul");
        try 
    	{
            // D:\\lesscss.g:46:2: ( expressionToken ( ( plus | minus | mul | div ) expression )* -> ^( EXPRESSION expressionToken ( expression )* ) )
            // D:\\lesscss.g:46:4: expressionToken ( ( plus | minus | mul | div ) expression )*
            {
            	PushFollow(FOLLOW_expressionToken_in_expression193);
            	expressionToken11 = expressionToken();
            	state.followingStackPointer--;

            	stream_expressionToken.Add(expressionToken11.Tree);
            	// D:\\lesscss.g:46:20: ( ( plus | minus | mul | div ) expression )*
            	do 
            	{
            	    int alt4 = 2;
            	    switch ( input.LA(1) ) 
            	    {
            	    case 48:
            	    	{
            	        alt4 = 1;
            	        }
            	        break;
            	    case 51:
            	    	{
            	        alt4 = 1;
            	        }
            	        break;
            	    case 52:
            	    	{
            	        alt4 = 1;
            	        }
            	        break;
            	    case 53:
            	    	{
            	        alt4 = 1;
            	        }
            	        break;

            	    }

            	    switch (alt4) 
            		{
            			case 1 :
            			    // D:\\lesscss.g:46:21: ( plus | minus | mul | div ) expression
            			    {
            			    	// D:\\lesscss.g:46:21: ( plus | minus | mul | div )
            			    	int alt3 = 4;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 48:
            			    		{
            			    	    alt3 = 1;
            			    	    }
            			    	    break;
            			    	case 51:
            			    		{
            			    	    alt3 = 2;
            			    	    }
            			    	    break;
            			    	case 52:
            			    		{
            			    	    alt3 = 3;
            			    	    }
            			    	    break;
            			    	case 53:
            			    		{
            			    	    alt3 = 4;
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
            			    	        // D:\\lesscss.g:46:22: plus
            			    	        {
            			    	        	PushFollow(FOLLOW_plus_in_expression197);
            			    	        	plus12 = plus();
            			    	        	state.followingStackPointer--;

            			    	        	stream_plus.Add(plus12.Tree);

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\lesscss.g:46:27: minus
            			    	        {
            			    	        	PushFollow(FOLLOW_minus_in_expression199);
            			    	        	minus13 = minus();
            			    	        	state.followingStackPointer--;

            			    	        	stream_minus.Add(minus13.Tree);

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // D:\\lesscss.g:46:33: mul
            			    	        {
            			    	        	PushFollow(FOLLOW_mul_in_expression201);
            			    	        	mul14 = mul();
            			    	        	state.followingStackPointer--;

            			    	        	stream_mul.Add(mul14.Tree);

            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // D:\\lesscss.g:46:37: div
            			    	        {
            			    	        	PushFollow(FOLLOW_div_in_expression203);
            			    	        	div15 = div();
            			    	        	state.followingStackPointer--;

            			    	        	stream_div.Add(div15.Tree);

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_expression_in_expression206);
            			    	expression16 = expression();
            			    	state.followingStackPointer--;

            			    	stream_expression.Add(expression16.Tree);

            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements



            	// AST REWRITE
            	// elements:          expressionToken, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 46:55: -> ^( EXPRESSION expressionToken ( expression )* )
            	{
            	    // D:\\lesscss.g:46:58: ^( EXPRESSION expressionToken ( expression )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(EXPRESSION, "EXPRESSION"), root_1);

            	    adaptor.AddChild(root_1, stream_expressionToken.NextTree());
            	    // D:\\lesscss.g:46:87: ( expression )*
            	    while ( stream_expression.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_expression.NextTree());

            	    }
            	    stream_expression.Reset();

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

    public class expressionToken_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "expressionToken"
    // D:\\lesscss.g:49:10: fragment expressionToken : ( val | varname ) ;
    public lesscssParser.expressionToken_return expressionToken() // throws RecognitionException [1]
    {   
        lesscssParser.expressionToken_return retval = new lesscssParser.expressionToken_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.val_return val17 = null;

        lesscssParser.varname_return varname18 = null;



        try 
    	{
            // D:\\lesscss.g:50:2: ( ( val | varname ) )
            // D:\\lesscss.g:50:4: ( val | varname )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// D:\\lesscss.g:50:4: ( val | varname )
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == IDENT || (LA5_0 >= STRING && LA5_0 <= COLOR)) )
            	{
            	    alt5 = 1;
            	}
            	else if ( (LA5_0 == 32) )
            	{
            	    alt5 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d5s0 =
            	        new NoViableAltException("", 5, 0, input);

            	    throw nvae_d5s0;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // D:\\lesscss.g:50:5: val
            	        {
            	        	PushFollow(FOLLOW_val_in_expressionToken233);
            	        	val17 = val();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, val17.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // D:\\lesscss.g:50:11: varname
            	        {
            	        	PushFollow(FOLLOW_varname_in_expressionToken237);
            	        	varname18 = varname();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, varname18.Tree);

            	        }
            	        break;

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
    // $ANTLR end "expressionToken"

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
    // D:\\lesscss.g:53:10: fragment mediadefinition : ( '@media' media '{' lessCss '}' ) ;
    public lesscssParser.mediadefinition_return mediadefinition() // throws RecognitionException [1]
    {   
        lesscssParser.mediadefinition_return retval = new lesscssParser.mediadefinition_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal19 = null;
        IToken char_literal21 = null;
        IToken char_literal23 = null;
        lesscssParser.media_return media20 = null;

        lesscssParser.lessCss_return lessCss22 = null;


        CommonTree string_literal19_tree=null;
        CommonTree char_literal21_tree=null;
        CommonTree char_literal23_tree=null;

        try 
    	{
            // D:\\lesscss.g:54:2: ( ( '@media' media '{' lessCss '}' ) )
            // D:\\lesscss.g:54:4: ( '@media' media '{' lessCss '}' )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// D:\\lesscss.g:54:4: ( '@media' media '{' lessCss '}' )
            	// D:\\lesscss.g:54:5: '@media' media '{' lessCss '}'
            	{
            		string_literal19=(IToken)Match(input,33,FOLLOW_33_in_mediadefinition253); 
            			string_literal19_tree = (CommonTree)adaptor.Create(string_literal19);
            			adaptor.AddChild(root_0, string_literal19_tree);

            		PushFollow(FOLLOW_media_in_mediadefinition255);
            		media20 = media();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, media20.Tree);
            		char_literal21=(IToken)Match(input,34,FOLLOW_34_in_mediadefinition257); 
            			char_literal21_tree = (CommonTree)adaptor.Create(char_literal21);
            			adaptor.AddChild(root_0, char_literal21_tree);

            		PushFollow(FOLLOW_lessCss_in_mediadefinition259);
            		lessCss22 = lessCss();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, lessCss22.Tree);
            		char_literal23=(IToken)Match(input,35,FOLLOW_35_in_mediadefinition261); 
            			char_literal23_tree = (CommonTree)adaptor.Create(char_literal23);
            			adaptor.AddChild(root_0, char_literal23_tree);


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
    // D:\\lesscss.g:56:1: ruleset : selectors '{' ( ruleContents )* '}' -> ^( RULE ( selectors )+ ( ruleContents )* ) ;
    public lesscssParser.ruleset_return ruleset() // throws RecognitionException [1]
    {   
        lesscssParser.ruleset_return retval = new lesscssParser.ruleset_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal25 = null;
        IToken char_literal27 = null;
        lesscssParser.selectors_return selectors24 = null;

        lesscssParser.ruleContents_return ruleContents26 = null;


        CommonTree char_literal25_tree=null;
        CommonTree char_literal27_tree=null;
        RewriteRuleTokenStream stream_35 = new RewriteRuleTokenStream(adaptor,"token 35");
        RewriteRuleTokenStream stream_34 = new RewriteRuleTokenStream(adaptor,"token 34");
        RewriteRuleSubtreeStream stream_ruleContents = new RewriteRuleSubtreeStream(adaptor,"rule ruleContents");
        RewriteRuleSubtreeStream stream_selectors = new RewriteRuleSubtreeStream(adaptor,"rule selectors");
        try 
    	{
            // D:\\lesscss.g:57:2: ( selectors '{' ( ruleContents )* '}' -> ^( RULE ( selectors )+ ( ruleContents )* ) )
            // D:\\lesscss.g:57:4: selectors '{' ( ruleContents )* '}'
            {
            	PushFollow(FOLLOW_selectors_in_ruleset274);
            	selectors24 = selectors();
            	state.followingStackPointer--;

            	stream_selectors.Add(selectors24.Tree);
            	char_literal25=(IToken)Match(input,34,FOLLOW_34_in_ruleset276);  
            	stream_34.Add(char_literal25);

            	// D:\\lesscss.g:57:18: ( ruleContents )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= IDENT && LA6_0 <= SelectorID) || (LA6_0 >= 47 && LA6_0 <= 48)) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // D:\\lesscss.g:57:18: ruleContents
            			    {
            			    	PushFollow(FOLLOW_ruleContents_in_ruleset278);
            			    	ruleContents26 = ruleContents();
            			    	state.followingStackPointer--;

            			    	stream_ruleContents.Add(ruleContents26.Tree);

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements

            	char_literal27=(IToken)Match(input,35,FOLLOW_35_in_ruleset281);  
            	stream_35.Add(char_literal27);



            	// AST REWRITE
            	// elements:          selectors, ruleContents
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 57:36: -> ^( RULE ( selectors )+ ( ruleContents )* )
            	{
            	    // D:\\lesscss.g:57:39: ^( RULE ( selectors )+ ( ruleContents )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(RULE, "RULE"), root_1);

            	    if ( !(stream_selectors.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_selectors.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_selectors.NextTree());

            	    }
            	    stream_selectors.Reset();
            	    // D:\\lesscss.g:57:57: ( ruleContents )*
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
    // D:\\lesscss.g:60:10: fragment ruleContents : ( property | ruleset );
    public lesscssParser.ruleContents_return ruleContents() // throws RecognitionException [1]
    {   
        lesscssParser.ruleContents_return retval = new lesscssParser.ruleContents_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.property_return property28 = null;

        lesscssParser.ruleset_return ruleset29 = null;



        try 
    	{
            // D:\\lesscss.g:61:2: ( property | ruleset )
            int alt7 = 2;
            alt7 = dfa7.Predict(input);
            switch (alt7) 
            {
                case 1 :
                    // D:\\lesscss.g:61:4: property
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_property_in_ruleContents307);
                    	property28 = property();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, property28.Tree);

                    }
                    break;
                case 2 :
                    // D:\\lesscss.g:61:15: ruleset
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ruleset_in_ruleContents311);
                    	ruleset29 = ruleset();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ruleset29.Tree);

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
    // D:\\lesscss.g:63:10: fragment media : ( 'all' | 'braille' | 'embossed' | 'handheld' | 'print' | 'projection' | 'screen' | 'speech' | 'tty' | 'tv' );
    public lesscssParser.media_return media() // throws RecognitionException [1]
    {   
        lesscssParser.media_return retval = new lesscssParser.media_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set30 = null;

        CommonTree set30_tree=null;

        try 
    	{
            // D:\\lesscss.g:63:17: ( 'all' | 'braille' | 'embossed' | 'handheld' | 'print' | 'projection' | 'screen' | 'speech' | 'tty' | 'tv' )
            // D:\\lesscss.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set30 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 36 && input.LA(1) <= 45) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set30));
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
    // D:\\lesscss.g:65:10: fragment selectors : selectorGrouping ( ',' selectorGrouping )* -> ^( SELECTORGROUP ( selectorGrouping )+ ) ;
    public lesscssParser.selectors_return selectors() // throws RecognitionException [1]
    {   
        lesscssParser.selectors_return retval = new lesscssParser.selectors_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal32 = null;
        lesscssParser.selectorGrouping_return selectorGrouping31 = null;

        lesscssParser.selectorGrouping_return selectorGrouping33 = null;


        CommonTree char_literal32_tree=null;
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleSubtreeStream stream_selectorGrouping = new RewriteRuleSubtreeStream(adaptor,"rule selectorGrouping");
        try 
    	{
            // D:\\lesscss.g:66:2: ( selectorGrouping ( ',' selectorGrouping )* -> ^( SELECTORGROUP ( selectorGrouping )+ ) )
            // D:\\lesscss.g:66:4: selectorGrouping ( ',' selectorGrouping )*
            {
            	PushFollow(FOLLOW_selectorGrouping_in_selectors351);
            	selectorGrouping31 = selectorGrouping();
            	state.followingStackPointer--;

            	stream_selectorGrouping.Add(selectorGrouping31.Tree);
            	// D:\\lesscss.g:66:21: ( ',' selectorGrouping )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == 46) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // D:\\lesscss.g:66:22: ',' selectorGrouping
            			    {
            			    	char_literal32=(IToken)Match(input,46,FOLLOW_46_in_selectors354);  
            			    	stream_46.Add(char_literal32);

            			    	PushFollow(FOLLOW_selectorGrouping_in_selectors356);
            			    	selectorGrouping33 = selectorGrouping();
            			    	state.followingStackPointer--;

            			    	stream_selectorGrouping.Add(selectorGrouping33.Tree);

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements



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
            	// 66:45: -> ^( SELECTORGROUP ( selectorGrouping )+ )
            	{
            	    // D:\\lesscss.g:66:48: ^( SELECTORGROUP ( selectorGrouping )+ )
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
    // D:\\lesscss.g:69:10: fragment selectorGrouping : ( ( selectorOps )? selector )+ -> ^( SELECTOR ( selector )+ ) ;
    public lesscssParser.selectorGrouping_return selectorGrouping() // throws RecognitionException [1]
    {   
        lesscssParser.selectorGrouping_return retval = new lesscssParser.selectorGrouping_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.selectorOps_return selectorOps34 = null;

        lesscssParser.selector_return selector35 = null;


        RewriteRuleSubtreeStream stream_selector = new RewriteRuleSubtreeStream(adaptor,"rule selector");
        RewriteRuleSubtreeStream stream_selectorOps = new RewriteRuleSubtreeStream(adaptor,"rule selectorOps");
        try 
    	{
            // D:\\lesscss.g:70:2: ( ( ( selectorOps )? selector )+ -> ^( SELECTOR ( selector )+ ) )
            // D:\\lesscss.g:70:4: ( ( selectorOps )? selector )+
            {
            	// D:\\lesscss.g:70:4: ( ( selectorOps )? selector )+
            	int cnt10 = 0;
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= IDENT && LA10_0 <= SelectorID) || (LA10_0 >= 47 && LA10_0 <= 48)) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // D:\\lesscss.g:70:5: ( selectorOps )? selector
            			    {
            			    	// D:\\lesscss.g:70:5: ( selectorOps )?
            			    	int alt9 = 2;
            			    	int LA9_0 = input.LA(1);

            			    	if ( ((LA9_0 >= 47 && LA9_0 <= 48)) )
            			    	{
            			    	    alt9 = 1;
            			    	}
            			    	switch (alt9) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\lesscss.g:70:5: selectorOps
            			    	        {
            			    	        	PushFollow(FOLLOW_selectorOps_in_selectorGrouping382);
            			    	        	selectorOps34 = selectorOps();
            			    	        	state.followingStackPointer--;

            			    	        	stream_selectorOps.Add(selectorOps34.Tree);

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_selector_in_selectorGrouping385);
            			    	selector35 = selector();
            			    	state.followingStackPointer--;

            			    	stream_selector.Add(selector35.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt10 >= 1 ) goto loop10;
            		            EarlyExitException eee10 =
            		                new EarlyExitException(10, input);
            		            throw eee10;
            	    }
            	    cnt10++;
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whinging that label 'loop10' has no statements



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
            	// 70:29: -> ^( SELECTOR ( selector )+ )
            	{
            	    // D:\\lesscss.g:70:32: ^( SELECTOR ( selector )+ )
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
    // D:\\lesscss.g:73:10: fragment selector : ( IDENT | SelectorClass | SelectorID ) ( PSEUDO )? ;
    public lesscssParser.selector_return selector() // throws RecognitionException [1]
    {   
        lesscssParser.selector_return retval = new lesscssParser.selector_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set36 = null;
        IToken PSEUDO37 = null;

        CommonTree set36_tree=null;
        CommonTree PSEUDO37_tree=null;

        try 
    	{
            // D:\\lesscss.g:74:2: ( ( IDENT | SelectorClass | SelectorID ) ( PSEUDO )? )
            // D:\\lesscss.g:74:4: ( IDENT | SelectorClass | SelectorID ) ( PSEUDO )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set36 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IDENT && input.LA(1) <= SelectorID) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set36));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}

            	// D:\\lesscss.g:74:41: ( PSEUDO )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == PSEUDO) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // D:\\lesscss.g:74:41: PSEUDO
            	        {
            	        	PSEUDO37=(IToken)Match(input,PSEUDO,FOLLOW_PSEUDO_in_selector422); 
            	        		PSEUDO37_tree = (CommonTree)adaptor.Create(PSEUDO37);
            	        		adaptor.AddChild(root_0, PSEUDO37_tree);


            	        }
            	        break;

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
    // D:\\lesscss.g:80:10: fragment selectorOps : ( '>' | '+' );
    public lesscssParser.selectorOps_return selectorOps() // throws RecognitionException [1]
    {   
        lesscssParser.selectorOps_return retval = new lesscssParser.selectorOps_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set38 = null;

        CommonTree set38_tree=null;

        try 
    	{
            // D:\\lesscss.g:81:2: ( '>' | '+' )
            // D:\\lesscss.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set38 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 47 && input.LA(1) <= 48) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set38));
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
    // D:\\lesscss.g:84:10: fragment property : ( IDENT ':' ( val )+ ';' -> ^( PROPERTY IDENT ( val )+ ) | IDENT ':' expression ';' -> ^( PROPERTY IDENT expression ) );
    public lesscssParser.property_return property() // throws RecognitionException [1]
    {   
        lesscssParser.property_return retval = new lesscssParser.property_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken IDENT39 = null;
        IToken char_literal40 = null;
        IToken char_literal42 = null;
        IToken IDENT43 = null;
        IToken char_literal44 = null;
        IToken char_literal46 = null;
        lesscssParser.val_return val41 = null;

        lesscssParser.expression_return expression45 = null;


        CommonTree IDENT39_tree=null;
        CommonTree char_literal40_tree=null;
        CommonTree char_literal42_tree=null;
        CommonTree IDENT43_tree=null;
        CommonTree char_literal44_tree=null;
        CommonTree char_literal46_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_30 = new RewriteRuleTokenStream(adaptor,"token 30");
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_val = new RewriteRuleSubtreeStream(adaptor,"rule val");
        try 
    	{
            // D:\\lesscss.g:85:2: ( IDENT ':' ( val )+ ';' -> ^( PROPERTY IDENT ( val )+ ) | IDENT ':' expression ';' -> ^( PROPERTY IDENT expression ) )
            int alt13 = 2;
            alt13 = dfa13.Predict(input);
            switch (alt13) 
            {
                case 1 :
                    // D:\\lesscss.g:85:4: IDENT ':' ( val )+ ';'
                    {
                    	IDENT39=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_property477);  
                    	stream_IDENT.Add(IDENT39);

                    	char_literal40=(IToken)Match(input,30,FOLLOW_30_in_property479);  
                    	stream_30.Add(char_literal40);

                    	// D:\\lesscss.g:85:14: ( val )+
                    	int cnt12 = 0;
                    	do 
                    	{
                    	    int alt12 = 2;
                    	    int LA12_0 = input.LA(1);

                    	    if ( (LA12_0 == IDENT || (LA12_0 >= STRING && LA12_0 <= COLOR)) )
                    	    {
                    	        alt12 = 1;
                    	    }


                    	    switch (alt12) 
                    		{
                    			case 1 :
                    			    // D:\\lesscss.g:85:14: val
                    			    {
                    			    	PushFollow(FOLLOW_val_in_property481);
                    			    	val41 = val();
                    			    	state.followingStackPointer--;

                    			    	stream_val.Add(val41.Tree);

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt12 >= 1 ) goto loop12;
                    		            EarlyExitException eee12 =
                    		                new EarlyExitException(12, input);
                    		            throw eee12;
                    	    }
                    	    cnt12++;
                    	} while (true);

                    	loop12:
                    		;	// Stops C# compiler whinging that label 'loop12' has no statements

                    	char_literal42=(IToken)Match(input,31,FOLLOW_31_in_property484);  
                    	stream_31.Add(char_literal42);



                    	// AST REWRITE
                    	// elements:          IDENT, val
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 85:23: -> ^( PROPERTY IDENT ( val )+ )
                    	{
                    	    // D:\\lesscss.g:85:26: ^( PROPERTY IDENT ( val )+ )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PROPERTY, "PROPERTY"), root_1);

                    	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
                    	    if ( !(stream_val.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_val.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_val.NextTree());

                    	    }
                    	    stream_val.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // D:\\lesscss.g:86:4: IDENT ':' expression ';'
                    {
                    	IDENT43=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_property500);  
                    	stream_IDENT.Add(IDENT43);

                    	char_literal44=(IToken)Match(input,30,FOLLOW_30_in_property502);  
                    	stream_30.Add(char_literal44);

                    	PushFollow(FOLLOW_expression_in_property504);
                    	expression45 = expression();
                    	state.followingStackPointer--;

                    	stream_expression.Add(expression45.Tree);
                    	char_literal46=(IToken)Match(input,31,FOLLOW_31_in_property506);  
                    	stream_31.Add(char_literal46);



                    	// AST REWRITE
                    	// elements:          expression, IDENT
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 86:29: -> ^( PROPERTY IDENT expression )
                    	{
                    	    // D:\\lesscss.g:86:32: ^( PROPERTY IDENT expression )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PROPERTY, "PROPERTY"), root_1);

                    	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
                    	    adaptor.AddChild(root_1, stream_expression.NextTree());

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
    // $ANTLR end "property"

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
    // D:\\lesscss.g:89:10: fragment val : ( IDENT | STRING | NUM | COLOR | IDENT '(' ( STRING | NUM | COLOR ) ( ',' ( STRING | NUM | COLOR ) )* ')' );
    public lesscssParser.val_return val() // throws RecognitionException [1]
    {   
        lesscssParser.val_return retval = new lesscssParser.val_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken IDENT47 = null;
        IToken STRING48 = null;
        IToken NUM49 = null;
        IToken COLOR50 = null;
        IToken IDENT51 = null;
        IToken char_literal52 = null;
        IToken set53 = null;
        IToken char_literal54 = null;
        IToken set55 = null;
        IToken char_literal56 = null;

        CommonTree IDENT47_tree=null;
        CommonTree STRING48_tree=null;
        CommonTree NUM49_tree=null;
        CommonTree COLOR50_tree=null;
        CommonTree IDENT51_tree=null;
        CommonTree char_literal52_tree=null;
        CommonTree set53_tree=null;
        CommonTree char_literal54_tree=null;
        CommonTree set55_tree=null;
        CommonTree char_literal56_tree=null;

        try 
    	{
            // D:\\lesscss.g:90:2: ( IDENT | STRING | NUM | COLOR | IDENT '(' ( STRING | NUM | COLOR ) ( ',' ( STRING | NUM | COLOR ) )* ')' )
            int alt15 = 5;
            alt15 = dfa15.Predict(input);
            switch (alt15) 
            {
                case 1 :
                    // D:\\lesscss.g:90:4: IDENT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	IDENT47=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_val533); 
                    		IDENT47_tree = (CommonTree)adaptor.Create(IDENT47);
                    		adaptor.AddChild(root_0, IDENT47_tree);


                    }
                    break;
                case 2 :
                    // D:\\lesscss.g:90:12: STRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	STRING48=(IToken)Match(input,STRING,FOLLOW_STRING_in_val537); 
                    		STRING48_tree = (CommonTree)adaptor.Create(STRING48);
                    		adaptor.AddChild(root_0, STRING48_tree);


                    }
                    break;
                case 3 :
                    // D:\\lesscss.g:90:21: NUM
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	NUM49=(IToken)Match(input,NUM,FOLLOW_NUM_in_val541); 
                    		NUM49_tree = (CommonTree)adaptor.Create(NUM49);
                    		adaptor.AddChild(root_0, NUM49_tree);


                    }
                    break;
                case 4 :
                    // D:\\lesscss.g:90:27: COLOR
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	COLOR50=(IToken)Match(input,COLOR,FOLLOW_COLOR_in_val545); 
                    		COLOR50_tree = (CommonTree)adaptor.Create(COLOR50);
                    		adaptor.AddChild(root_0, COLOR50_tree);


                    }
                    break;
                case 5 :
                    // D:\\lesscss.g:91:4: IDENT '(' ( STRING | NUM | COLOR ) ( ',' ( STRING | NUM | COLOR ) )* ')'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	IDENT51=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_val550); 
                    		IDENT51_tree = (CommonTree)adaptor.Create(IDENT51);
                    		adaptor.AddChild(root_0, IDENT51_tree);

                    	char_literal52=(IToken)Match(input,49,FOLLOW_49_in_val552); 
                    		char_literal52_tree = (CommonTree)adaptor.Create(char_literal52);
                    		adaptor.AddChild(root_0, char_literal52_tree);

                    	set53 = (IToken)input.LT(1);
                    	if ( (input.LA(1) >= STRING && input.LA(1) <= COLOR) ) 
                    	{
                    	    input.Consume();
                    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set53));
                    	    state.errorRecovery = false;
                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    throw mse;
                    	}

                    	// D:\\lesscss.g:91:37: ( ',' ( STRING | NUM | COLOR ) )*
                    	do 
                    	{
                    	    int alt14 = 2;
                    	    int LA14_0 = input.LA(1);

                    	    if ( (LA14_0 == 46) )
                    	    {
                    	        alt14 = 1;
                    	    }


                    	    switch (alt14) 
                    		{
                    			case 1 :
                    			    // D:\\lesscss.g:91:38: ',' ( STRING | NUM | COLOR )
                    			    {
                    			    	char_literal54=(IToken)Match(input,46,FOLLOW_46_in_val567); 
                    			    		char_literal54_tree = (CommonTree)adaptor.Create(char_literal54);
                    			    		adaptor.AddChild(root_0, char_literal54_tree);

                    			    	set55 = (IToken)input.LT(1);
                    			    	if ( (input.LA(1) >= STRING && input.LA(1) <= COLOR) ) 
                    			    	{
                    			    	    input.Consume();
                    			    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set55));
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
                    			    goto loop14;
                    	    }
                    	} while (true);

                    	loop14:
                    		;	// Stops C# compiler whining that label 'loop14' has no statements

                    	char_literal56=(IToken)Match(input,50,FOLLOW_50_in_val579); 
                    		char_literal56_tree = (CommonTree)adaptor.Create(char_literal56);
                    		adaptor.AddChild(root_0, char_literal56_tree);


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

    public class plus_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "plus"
    // D:\\lesscss.g:130:1: plus : '+' -> PLUS ;
    public lesscssParser.plus_return plus() // throws RecognitionException [1]
    {   
        lesscssParser.plus_return retval = new lesscssParser.plus_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal57 = null;

        CommonTree char_literal57_tree=null;
        RewriteRuleTokenStream stream_48 = new RewriteRuleTokenStream(adaptor,"token 48");

        try 
    	{
            // D:\\lesscss.g:130:7: ( '+' -> PLUS )
            // D:\\lesscss.g:130:9: '+'
            {
            	char_literal57=(IToken)Match(input,48,FOLLOW_48_in_plus921);  
            	stream_48.Add(char_literal57);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 130:13: -> PLUS
            	{
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(PLUS, "PLUS"));

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
    // $ANTLR end "plus"

    public class minus_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "minus"
    // D:\\lesscss.g:131:1: minus : '-' -> MINUS ;
    public lesscssParser.minus_return minus() // throws RecognitionException [1]
    {   
        lesscssParser.minus_return retval = new lesscssParser.minus_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal58 = null;

        CommonTree char_literal58_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");

        try 
    	{
            // D:\\lesscss.g:131:7: ( '-' -> MINUS )
            // D:\\lesscss.g:131:9: '-'
            {
            	char_literal58=(IToken)Match(input,51,FOLLOW_51_in_minus932);  
            	stream_51.Add(char_literal58);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 131:13: -> MINUS
            	{
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(MINUS, "MINUS"));

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
    // $ANTLR end "minus"

    public class mul_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "mul"
    // D:\\lesscss.g:132:1: mul : '*' -> MUL ;
    public lesscssParser.mul_return mul() // throws RecognitionException [1]
    {   
        lesscssParser.mul_return retval = new lesscssParser.mul_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal59 = null;

        CommonTree char_literal59_tree=null;
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");

        try 
    	{
            // D:\\lesscss.g:132:5: ( '*' -> MUL )
            // D:\\lesscss.g:132:7: '*'
            {
            	char_literal59=(IToken)Match(input,52,FOLLOW_52_in_mul943);  
            	stream_52.Add(char_literal59);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 132:11: -> MUL
            	{
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(MUL, "MUL"));

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
    // $ANTLR end "mul"

    public class div_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "div"
    // D:\\lesscss.g:133:1: div : '/' -> DIV ;
    public lesscssParser.div_return div() // throws RecognitionException [1]
    {   
        lesscssParser.div_return retval = new lesscssParser.div_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal60 = null;

        CommonTree char_literal60_tree=null;
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");

        try 
    	{
            // D:\\lesscss.g:133:5: ( '/' -> DIV )
            // D:\\lesscss.g:133:7: '/'
            {
            	char_literal60=(IToken)Match(input,53,FOLLOW_53_in_div954);  
            	stream_53.Add(char_literal60);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 133:11: -> DIV
            	{
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(DIV, "DIV"));

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
    // $ANTLR end "div"

    // Delegated rules


   	protected DFA7 dfa7;
   	protected DFA13 dfa13;
   	protected DFA15 dfa15;
	private void InitializeCyclicDFAs()
	{
    	this.dfa7 = new DFA7(this);
    	this.dfa13 = new DFA13(this);
    	this.dfa15 = new DFA15(this);



	}

    const string DFA7_eotS =
        "\x0a\uffff";
    const string DFA7_eofS =
        "\x0a\uffff";
    const string DFA7_minS =
        "\x02\x13\x08\uffff";
    const string DFA7_maxS =
        "\x02\x30\x08\uffff";
    const string DFA7_acceptS =
        "\x02\uffff\x01\x02\x01\uffff\x01\x01\x05\uffff";
    const string DFA7_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA7_transitionS = {
            "\x01\x01\x02\x02\x19\uffff\x02\x02",
            "\x04\x02\x07\uffff\x01\x04\x03\uffff\x01\x02\x0b\uffff\x03"+
            "\x02",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
    static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
    static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
    static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
    static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
    static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
    static readonly short[][] DFA7_transition = DFA.UnpackEncodedStringArray(DFA7_transitionS);

    protected class DFA7 : DFA
    {
        public DFA7(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 7;
            this.eot = DFA7_eot;
            this.eof = DFA7_eof;
            this.min = DFA7_min;
            this.max = DFA7_max;
            this.accept = DFA7_accept;
            this.special = DFA7_special;
            this.transition = DFA7_transition;

        }

        override public string Description
        {
            get { return "60:10: fragment ruleContents : ( property | ruleset );"; }
        }

    }

    const string DFA13_eotS =
        "\x2d\uffff";
    const string DFA13_eofS =
        "\x2d\uffff";
    const string DFA13_minS =
        "\x01\x13\x01\x1e\x05\x13\x26\uffff";
    const string DFA13_maxS =
        "\x01\x13\x01\x1e\x01\x20\x04\x35\x26\uffff";
    const string DFA13_acceptS =
        "\x07\uffff\x01\x02\x02\x01\x0c\uffff\x01\x01\x04\uffff\x01\x01"+
        "\x0c\uffff\x01\x01\x04\uffff";
    const string DFA13_specialS =
        "\x2d\uffff}>";
    static readonly string[] DFA13_transitionS = {
            "\x01\x01",
            "\x01\x02",
            "\x01\x03\x03\uffff\x01\x04\x01\x05\x01\x06\x06\uffff\x01\x07",
            "\x01\x09\x03\uffff\x03\x09\x05\uffff\x01\x09\x10\uffff\x01"+
            "\x07\x01\x08\x01\uffff\x03\x07",
            "\x01\x16\x03\uffff\x03\x16\x05\uffff\x01\x16\x10\uffff\x01"+
            "\x07\x02\uffff\x03\x07",
            "\x01\x1b\x03\uffff\x03\x1b\x05\uffff\x01\x1b\x10\uffff\x01"+
            "\x07\x02\uffff\x03\x07",
            "\x01\x28\x03\uffff\x03\x28\x05\uffff\x01\x28\x10\uffff\x01"+
            "\x07\x02\uffff\x03\x07",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA13_eot = DFA.UnpackEncodedString(DFA13_eotS);
    static readonly short[] DFA13_eof = DFA.UnpackEncodedString(DFA13_eofS);
    static readonly char[] DFA13_min = DFA.UnpackEncodedStringToUnsignedChars(DFA13_minS);
    static readonly char[] DFA13_max = DFA.UnpackEncodedStringToUnsignedChars(DFA13_maxS);
    static readonly short[] DFA13_accept = DFA.UnpackEncodedString(DFA13_acceptS);
    static readonly short[] DFA13_special = DFA.UnpackEncodedString(DFA13_specialS);
    static readonly short[][] DFA13_transition = DFA.UnpackEncodedStringArray(DFA13_transitionS);

    protected class DFA13 : DFA
    {
        public DFA13(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 13;
            this.eot = DFA13_eot;
            this.eof = DFA13_eof;
            this.min = DFA13_min;
            this.max = DFA13_max;
            this.accept = DFA13_accept;
            this.special = DFA13_special;
            this.transition = DFA13_transition;

        }

        override public string Description
        {
            get { return "84:10: fragment property : ( IDENT ':' ( val )+ ';' -> ^( PROPERTY IDENT ( val )+ ) | IDENT ':' expression ';' -> ^( PROPERTY IDENT expression ) );"; }
        }

    }

    const string DFA15_eotS =
        "\x0f\uffff";
    const string DFA15_eofS =
        "\x0f\uffff";
    const string DFA15_minS =
        "\x02\x13\x0d\uffff";
    const string DFA15_maxS =
        "\x01\x19\x01\x35\x0d\uffff";
    const string DFA15_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x01\x08\uffff";
    const string DFA15_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA15_transitionS = {
            "\x01\x01\x03\uffff\x01\x02\x01\x03\x01\x04",
            "\x01\x06\x03\uffff\x03\x06\x05\uffff\x01\x06\x10\uffff\x01"+
            "\x06\x01\x05\x01\uffff\x03\x06",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA15_eot = DFA.UnpackEncodedString(DFA15_eotS);
    static readonly short[] DFA15_eof = DFA.UnpackEncodedString(DFA15_eofS);
    static readonly char[] DFA15_min = DFA.UnpackEncodedStringToUnsignedChars(DFA15_minS);
    static readonly char[] DFA15_max = DFA.UnpackEncodedStringToUnsignedChars(DFA15_maxS);
    static readonly short[] DFA15_accept = DFA.UnpackEncodedString(DFA15_acceptS);
    static readonly short[] DFA15_special = DFA.UnpackEncodedString(DFA15_specialS);
    static readonly short[][] DFA15_transition = DFA.UnpackEncodedStringArray(DFA15_transitionS);

    protected class DFA15 : DFA
    {
        public DFA15(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 15;
            this.eot = DFA15_eot;
            this.eof = DFA15_eof;
            this.min = DFA15_min;
            this.max = DFA15_max;
            this.accept = DFA15_accept;
            this.special = DFA15_special;
            this.transition = DFA15_transition;

        }

        override public string Description
        {
            get { return "89:10: fragment val : ( IDENT | STRING | NUM | COLOR | IDENT '(' ( STRING | NUM | COLOR ) ( ',' ( STRING | NUM | COLOR ) )* ')' );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_lessLine_in_lessCss105 = new BitSet(new ulong[]{0x0001800300380002UL});
    public static readonly BitSet FOLLOW_ruleset_in_lessLine121 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mediadefinition_in_lessLine125 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_lessLine129 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varname_in_variable143 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_variable145 = new BitSet(new ulong[]{0x0001800303B80000UL});
    public static readonly BitSet FOLLOW_expression_in_variable147 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_variable149 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_32_in_varname173 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_IDENT_in_varname175 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expressionToken_in_expression193 = new BitSet(new ulong[]{0x0039000000000002UL});
    public static readonly BitSet FOLLOW_plus_in_expression197 = new BitSet(new ulong[]{0x0001800303B80000UL});
    public static readonly BitSet FOLLOW_minus_in_expression199 = new BitSet(new ulong[]{0x0001800303B80000UL});
    public static readonly BitSet FOLLOW_mul_in_expression201 = new BitSet(new ulong[]{0x0001800303B80000UL});
    public static readonly BitSet FOLLOW_div_in_expression203 = new BitSet(new ulong[]{0x0001800303B80000UL});
    public static readonly BitSet FOLLOW_expression_in_expression206 = new BitSet(new ulong[]{0x0039000000000002UL});
    public static readonly BitSet FOLLOW_val_in_expressionToken233 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varname_in_expressionToken237 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_33_in_mediadefinition253 = new BitSet(new ulong[]{0x00003FF000000000UL});
    public static readonly BitSet FOLLOW_media_in_mediadefinition255 = new BitSet(new ulong[]{0x0000000400000000UL});
    public static readonly BitSet FOLLOW_34_in_mediadefinition257 = new BitSet(new ulong[]{0x0001800300380000UL});
    public static readonly BitSet FOLLOW_lessCss_in_mediadefinition259 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_35_in_mediadefinition261 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectors_in_ruleset274 = new BitSet(new ulong[]{0x0000000400000000UL});
    public static readonly BitSet FOLLOW_34_in_ruleset276 = new BitSet(new ulong[]{0x0001800800380000UL});
    public static readonly BitSet FOLLOW_ruleContents_in_ruleset278 = new BitSet(new ulong[]{0x0001800800380000UL});
    public static readonly BitSet FOLLOW_35_in_ruleset281 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_property_in_ruleContents307 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ruleset_in_ruleContents311 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_media0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectorGrouping_in_selectors351 = new BitSet(new ulong[]{0x0000400000000002UL});
    public static readonly BitSet FOLLOW_46_in_selectors354 = new BitSet(new ulong[]{0x0001800000380000UL});
    public static readonly BitSet FOLLOW_selectorGrouping_in_selectors356 = new BitSet(new ulong[]{0x0000400000000002UL});
    public static readonly BitSet FOLLOW_selectorOps_in_selectorGrouping382 = new BitSet(new ulong[]{0x0001800000380000UL});
    public static readonly BitSet FOLLOW_selector_in_selectorGrouping385 = new BitSet(new ulong[]{0x0001800000380002UL});
    public static readonly BitSet FOLLOW_set_in_selector410 = new BitSet(new ulong[]{0x0000000000400002UL});
    public static readonly BitSet FOLLOW_PSEUDO_in_selector422 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_selectorOps0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_property477 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_property479 = new BitSet(new ulong[]{0x0000000003880000UL});
    public static readonly BitSet FOLLOW_val_in_property481 = new BitSet(new ulong[]{0x0000000083880000UL});
    public static readonly BitSet FOLLOW_31_in_property484 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_property500 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_property502 = new BitSet(new ulong[]{0x0001800303B80000UL});
    public static readonly BitSet FOLLOW_expression_in_property504 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_property506 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_val533 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_val537 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUM_in_val541 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COLOR_in_val545 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_val550 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_val552 = new BitSet(new ulong[]{0x0000000003800000UL});
    public static readonly BitSet FOLLOW_set_in_val554 = new BitSet(new ulong[]{0x0004400000000000UL});
    public static readonly BitSet FOLLOW_46_in_val567 = new BitSet(new ulong[]{0x0000000003800000UL});
    public static readonly BitSet FOLLOW_set_in_val569 = new BitSet(new ulong[]{0x0004400000000000UL});
    public static readonly BitSet FOLLOW_50_in_val579 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_48_in_plus921 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_minus932 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_mul943 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_div954 = new BitSet(new ulong[]{0x0000000000000002UL});

}
