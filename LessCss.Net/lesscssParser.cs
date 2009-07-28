// $ANTLR 3.1.2 d:\\lesscss.g 2009-07-28 14:55:21


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
		"SELECTOR", 
		"VAR", 
		"TAG", 
		"ATTRIB", 
		"ATTRIBEQUAL", 
		"RULE", 
		"PARENTOF", 
		"PRECEDEDS", 
		"ID", 
		"CLASS", 
		"PSEUDO", 
		"HASVALUE", 
		"BEGINSWITH", 
		"PROPERTY", 
		"LESS", 
		"IDENT", 
		"STRING", 
		"NUM", 
		"COLOR", 
		"SL_COMMENT", 
		"COMMENT", 
		"WS", 
		"'@'", 
		"':'", 
		"';'", 
		"'{'", 
		"'}'", 
		"','", 
		"'>'", 
		"'+'", 
		"'#'", 
		"'.'", 
		"'::'", 
		"'['", 
		"']'", 
		"'='", 
		"'~='", 
		"'|='", 
		"'%'", 
		"'px'", 
		"'cm'", 
		"'mm'", 
		"'in'", 
		"'pt'", 
		"'pc'", 
		"'em'", 
		"'ex'", 
		"'deg'", 
		"'rad'", 
		"'grad'", 
		"'ms'", 
		"'s'", 
		"'hz'", 
		"'khz'", 
		"'('", 
		"')'"
    };

    public const int CLASS = 13;
    public const int ATTRIB = 7;
    public const int T__29 = 29;
    public const int T__28 = 28;
    public const int T__27 = 27;
    public const int T__26 = 26;
    public const int HASVALUE = 15;
    public const int PSEUDO = 14;
    public const int ID = 12;
    public const int EOF = -1;
    public const int ATTRIBEQUAL = 8;
    public const int COLOR = 22;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int SELECTOR = 4;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int T__59 = 59;
    public const int LESS = 18;
    public const int IDENT = 19;
    public const int VAR = 5;
    public const int COMMENT = 24;
    public const int T__50 = 50;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int RULE = 9;
    public const int BEGINSWITH = 16;
    public const int PARENTOF = 10;
    public const int T__45 = 45;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int PRECEDEDS = 11;
    public const int NUM = 21;
    public const int TAG = 6;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int WS = 25;
    public const int T__33 = 33;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int PROPERTY = 17;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int SL_COMMENT = 23;
    public const int STRING = 20;

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
		get { return "d:\\lesscss.g"; }
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
    // d:\\lesscss.g:26:1: lessCss : ( cssRule )* -> ^( LESS ( cssRule )* ) ;
    public lesscssParser.lessCss_return lessCss() // throws RecognitionException [1]
    {   
        lesscssParser.lessCss_return retval = new lesscssParser.lessCss_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.cssRule_return cssRule1 = null;


        RewriteRuleSubtreeStream stream_cssRule = new RewriteRuleSubtreeStream(adaptor,"rule cssRule");
        try 
    	{
            // d:\\lesscss.g:27:2: ( ( cssRule )* -> ^( LESS ( cssRule )* ) )
            // d:\\lesscss.g:27:4: ( cssRule )*
            {
            	// d:\\lesscss.g:27:4: ( cssRule )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == IDENT || LA1_0 == 26 || (LA1_0 >= 34 && LA1_0 <= 35)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // d:\\lesscss.g:27:4: cssRule
            			    {
            			    	PushFollow(FOLLOW_cssRule_in_lessCss104);
            			    	cssRule1 = cssRule();
            			    	state.followingStackPointer--;

            			    	stream_cssRule.Add(cssRule1.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements



            	// AST REWRITE
            	// elements:          cssRule
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 27:13: -> ^( LESS ( cssRule )* )
            	{
            	    // d:\\lesscss.g:27:16: ^( LESS ( cssRule )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(LESS, "LESS"), root_1);

            	    // d:\\lesscss.g:27:23: ( cssRule )*
            	    while ( stream_cssRule.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_cssRule.NextTree());

            	    }
            	    stream_cssRule.Reset();

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
    // $ANTLR end "lessCss"

    public class cssRule_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "cssRule"
    // d:\\lesscss.g:30:10: fragment cssRule : ( variable | ruleset );
    public lesscssParser.cssRule_return cssRule() // throws RecognitionException [1]
    {   
        lesscssParser.cssRule_return retval = new lesscssParser.cssRule_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.variable_return variable2 = null;

        lesscssParser.ruleset_return ruleset3 = null;



        try 
    	{
            // d:\\lesscss.g:31:2: ( variable | ruleset )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0 == 26) )
            {
                alt2 = 1;
            }
            else if ( (LA2_0 == IDENT || (LA2_0 >= 34 && LA2_0 <= 35)) )
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
                    // d:\\lesscss.g:31:5: variable
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variable_in_cssRule128);
                    	variable2 = variable();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variable2.Tree);

                    }
                    break;
                case 2 :
                    // d:\\lesscss.g:31:16: ruleset
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ruleset_in_cssRule132);
                    	ruleset3 = ruleset();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ruleset3.Tree);

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
    // $ANTLR end "cssRule"

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
    // d:\\lesscss.g:32:1: variable : '@' IDENT ':' expr ';' -> ^( VAR IDENT expr ) ;
    public lesscssParser.variable_return variable() // throws RecognitionException [1]
    {   
        lesscssParser.variable_return retval = new lesscssParser.variable_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal4 = null;
        IToken IDENT5 = null;
        IToken char_literal6 = null;
        IToken char_literal8 = null;
        lesscssParser.expr_return expr7 = null;


        CommonTree char_literal4_tree=null;
        CommonTree IDENT5_tree=null;
        CommonTree char_literal6_tree=null;
        CommonTree char_literal8_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_26 = new RewriteRuleTokenStream(adaptor,"token 26");
        RewriteRuleTokenStream stream_27 = new RewriteRuleTokenStream(adaptor,"token 27");
        RewriteRuleTokenStream stream_28 = new RewriteRuleTokenStream(adaptor,"token 28");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        try 
    	{
            // d:\\lesscss.g:33:2: ( '@' IDENT ':' expr ';' -> ^( VAR IDENT expr ) )
            // d:\\lesscss.g:33:4: '@' IDENT ':' expr ';'
            {
            	char_literal4=(IToken)Match(input,26,FOLLOW_26_in_variable140);  
            	stream_26.Add(char_literal4);

            	IDENT5=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_variable142);  
            	stream_IDENT.Add(IDENT5);

            	char_literal6=(IToken)Match(input,27,FOLLOW_27_in_variable144);  
            	stream_27.Add(char_literal6);

            	PushFollow(FOLLOW_expr_in_variable146);
            	expr7 = expr();
            	state.followingStackPointer--;

            	stream_expr.Add(expr7.Tree);
            	char_literal8=(IToken)Match(input,28,FOLLOW_28_in_variable148);  
            	stream_28.Add(char_literal8);



            	// AST REWRITE
            	// elements:          expr, IDENT
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 33:27: -> ^( VAR IDENT expr )
            	{
            	    // d:\\lesscss.g:33:30: ^( VAR IDENT expr )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(VAR, "VAR"), root_1);

            	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
            	    adaptor.AddChild(root_1, stream_expr.NextTree());

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
    // d:\\lesscss.g:35:1: ruleset : selectors '{' ( rulesetLine )* '}' -> ^( RULE selectors ( rulesetLine )* ) ;
    public lesscssParser.ruleset_return ruleset() // throws RecognitionException [1]
    {   
        lesscssParser.ruleset_return retval = new lesscssParser.ruleset_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal10 = null;
        IToken char_literal12 = null;
        lesscssParser.selectors_return selectors9 = null;

        lesscssParser.rulesetLine_return rulesetLine11 = null;


        CommonTree char_literal10_tree=null;
        CommonTree char_literal12_tree=null;
        RewriteRuleTokenStream stream_30 = new RewriteRuleTokenStream(adaptor,"token 30");
        RewriteRuleTokenStream stream_29 = new RewriteRuleTokenStream(adaptor,"token 29");
        RewriteRuleSubtreeStream stream_selectors = new RewriteRuleSubtreeStream(adaptor,"rule selectors");
        RewriteRuleSubtreeStream stream_rulesetLine = new RewriteRuleSubtreeStream(adaptor,"rule rulesetLine");
        try 
    	{
            // d:\\lesscss.g:36:3: ( selectors '{' ( rulesetLine )* '}' -> ^( RULE selectors ( rulesetLine )* ) )
            // d:\\lesscss.g:36:5: selectors '{' ( rulesetLine )* '}'
            {
            	PushFollow(FOLLOW_selectors_in_ruleset170);
            	selectors9 = selectors();
            	state.followingStackPointer--;

            	stream_selectors.Add(selectors9.Tree);
            	char_literal10=(IToken)Match(input,29,FOLLOW_29_in_ruleset172);  
            	stream_29.Add(char_literal10);

            	// d:\\lesscss.g:36:19: ( rulesetLine )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == IDENT || (LA3_0 >= 34 && LA3_0 <= 35)) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // d:\\lesscss.g:36:19: rulesetLine
            			    {
            			    	PushFollow(FOLLOW_rulesetLine_in_ruleset174);
            			    	rulesetLine11 = rulesetLine();
            			    	state.followingStackPointer--;

            			    	stream_rulesetLine.Add(rulesetLine11.Tree);

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	char_literal12=(IToken)Match(input,30,FOLLOW_30_in_ruleset177);  
            	stream_30.Add(char_literal12);



            	// AST REWRITE
            	// elements:          selectors, rulesetLine
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 36:36: -> ^( RULE selectors ( rulesetLine )* )
            	{
            	    // d:\\lesscss.g:36:39: ^( RULE selectors ( rulesetLine )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(RULE, "RULE"), root_1);

            	    adaptor.AddChild(root_1, stream_selectors.NextTree());
            	    // d:\\lesscss.g:36:57: ( rulesetLine )*
            	    while ( stream_rulesetLine.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_rulesetLine.NextTree());

            	    }
            	    stream_rulesetLine.Reset();

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

    public class rulesetLine_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "rulesetLine"
    // d:\\lesscss.g:39:10: fragment rulesetLine : ( ruleset | property );
    public lesscssParser.rulesetLine_return rulesetLine() // throws RecognitionException [1]
    {   
        lesscssParser.rulesetLine_return retval = new lesscssParser.rulesetLine_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.ruleset_return ruleset13 = null;

        lesscssParser.property_return property14 = null;



        try 
    	{
            // d:\\lesscss.g:40:2: ( ruleset | property )
            int alt4 = 2;
            alt4 = dfa4.Predict(input);
            switch (alt4) 
            {
                case 1 :
                    // d:\\lesscss.g:40:4: ruleset
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ruleset_in_rulesetLine205);
                    	ruleset13 = ruleset();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ruleset13.Tree);

                    }
                    break;
                case 2 :
                    // d:\\lesscss.g:40:14: property
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_property_in_rulesetLine209);
                    	property14 = property();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, property14.Tree);

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
    // $ANTLR end "rulesetLine"

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
    // d:\\lesscss.g:42:1: selectors : selector ( ',' selector )* -> ^( SELECTOR ( selector )+ ) ;
    public lesscssParser.selectors_return selectors() // throws RecognitionException [1]
    {   
        lesscssParser.selectors_return retval = new lesscssParser.selectors_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal16 = null;
        lesscssParser.selector_return selector15 = null;

        lesscssParser.selector_return selector17 = null;


        CommonTree char_literal16_tree=null;
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleSubtreeStream stream_selector = new RewriteRuleSubtreeStream(adaptor,"rule selector");
        try 
    	{
            // d:\\lesscss.g:43:2: ( selector ( ',' selector )* -> ^( SELECTOR ( selector )+ ) )
            // d:\\lesscss.g:43:4: selector ( ',' selector )*
            {
            	PushFollow(FOLLOW_selector_in_selectors219);
            	selector15 = selector();
            	state.followingStackPointer--;

            	stream_selector.Add(selector15.Tree);
            	// d:\\lesscss.g:43:13: ( ',' selector )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == 31) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // d:\\lesscss.g:43:14: ',' selector
            			    {
            			    	char_literal16=(IToken)Match(input,31,FOLLOW_31_in_selectors222);  
            			    	stream_31.Add(char_literal16);

            			    	PushFollow(FOLLOW_selector_in_selectors224);
            			    	selector17 = selector();
            			    	state.followingStackPointer--;

            			    	stream_selector.Add(selector17.Tree);

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements



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
            	// 43:29: -> ^( SELECTOR ( selector )+ )
            	{
            	    // d:\\lesscss.g:43:32: ^( SELECTOR ( selector )+ )
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
    // $ANTLR end "selectors"

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
    // d:\\lesscss.g:46:1: selector : elem ( selectorOperation )* ( attrib )* -> elem ( selectorOperation )* ( attrib )* ;
    public lesscssParser.selector_return selector() // throws RecognitionException [1]
    {   
        lesscssParser.selector_return retval = new lesscssParser.selector_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.elem_return elem18 = null;

        lesscssParser.selectorOperation_return selectorOperation19 = null;

        lesscssParser.attrib_return attrib20 = null;


        RewriteRuleSubtreeStream stream_elem = new RewriteRuleSubtreeStream(adaptor,"rule elem");
        RewriteRuleSubtreeStream stream_selectorOperation = new RewriteRuleSubtreeStream(adaptor,"rule selectorOperation");
        RewriteRuleSubtreeStream stream_attrib = new RewriteRuleSubtreeStream(adaptor,"rule attrib");
        try 
    	{
            // d:\\lesscss.g:47:2: ( elem ( selectorOperation )* ( attrib )* -> elem ( selectorOperation )* ( attrib )* )
            // d:\\lesscss.g:47:4: elem ( selectorOperation )* ( attrib )*
            {
            	PushFollow(FOLLOW_elem_in_selector248);
            	elem18 = elem();
            	state.followingStackPointer--;

            	stream_elem.Add(elem18.Tree);
            	// d:\\lesscss.g:47:9: ( selectorOperation )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == IDENT || (LA6_0 >= 32 && LA6_0 <= 35)) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // d:\\lesscss.g:47:9: selectorOperation
            			    {
            			    	PushFollow(FOLLOW_selectorOperation_in_selector250);
            			    	selectorOperation19 = selectorOperation();
            			    	state.followingStackPointer--;

            			    	stream_selectorOperation.Add(selectorOperation19.Tree);

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements

            	// d:\\lesscss.g:47:28: ( attrib )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == 37) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // d:\\lesscss.g:47:28: attrib
            			    {
            			    	PushFollow(FOLLOW_attrib_in_selector253);
            			    	attrib20 = attrib();
            			    	state.followingStackPointer--;

            			    	stream_attrib.Add(attrib20.Tree);

            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements



            	// AST REWRITE
            	// elements:          attrib, elem, selectorOperation
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 47:36: -> elem ( selectorOperation )* ( attrib )*
            	{
            	    adaptor.AddChild(root_0, stream_elem.NextTree());
            	    // d:\\lesscss.g:47:45: ( selectorOperation )*
            	    while ( stream_selectorOperation.HasNext() )
            	    {
            	        adaptor.AddChild(root_0, stream_selectorOperation.NextTree());

            	    }
            	    stream_selectorOperation.Reset();
            	    // d:\\lesscss.g:47:64: ( attrib )*
            	    while ( stream_attrib.HasNext() )
            	    {
            	        adaptor.AddChild(root_0, stream_attrib.NextTree());

            	    }
            	    stream_attrib.Reset();

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
    // $ANTLR end "selector"

    public class selectorOperation_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "selectorOperation"
    // d:\\lesscss.g:50:1: selectorOperation : ( selectop )? elem -> ( selectop )* elem ;
    public lesscssParser.selectorOperation_return selectorOperation() // throws RecognitionException [1]
    {   
        lesscssParser.selectorOperation_return retval = new lesscssParser.selectorOperation_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.selectop_return selectop21 = null;

        lesscssParser.elem_return elem22 = null;


        RewriteRuleSubtreeStream stream_elem = new RewriteRuleSubtreeStream(adaptor,"rule elem");
        RewriteRuleSubtreeStream stream_selectop = new RewriteRuleSubtreeStream(adaptor,"rule selectop");
        try 
    	{
            // d:\\lesscss.g:51:2: ( ( selectop )? elem -> ( selectop )* elem )
            // d:\\lesscss.g:51:4: ( selectop )? elem
            {
            	// d:\\lesscss.g:51:4: ( selectop )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( ((LA8_0 >= 32 && LA8_0 <= 33)) )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // d:\\lesscss.g:51:4: selectop
            	        {
            	        	PushFollow(FOLLOW_selectop_in_selectorOperation276);
            	        	selectop21 = selectop();
            	        	state.followingStackPointer--;

            	        	stream_selectop.Add(selectop21.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_elem_in_selectorOperation279);
            	elem22 = elem();
            	state.followingStackPointer--;

            	stream_elem.Add(elem22.Tree);


            	// AST REWRITE
            	// elements:          selectop, elem
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 51:19: -> ( selectop )* elem
            	{
            	    // d:\\lesscss.g:51:22: ( selectop )*
            	    while ( stream_selectop.HasNext() )
            	    {
            	        adaptor.AddChild(root_0, stream_selectop.NextTree());

            	    }
            	    stream_selectop.Reset();
            	    adaptor.AddChild(root_0, stream_elem.NextTree());

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
    // $ANTLR end "selectorOperation"

    public class selectop_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "selectop"
    // d:\\lesscss.g:54:10: fragment selectop : ( '>' -> PARENTOF | '+' -> PRECEDEDS );
    public lesscssParser.selectop_return selectop() // throws RecognitionException [1]
    {   
        lesscssParser.selectop_return retval = new lesscssParser.selectop_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal23 = null;
        IToken char_literal24 = null;

        CommonTree char_literal23_tree=null;
        CommonTree char_literal24_tree=null;
        RewriteRuleTokenStream stream_32 = new RewriteRuleTokenStream(adaptor,"token 32");
        RewriteRuleTokenStream stream_33 = new RewriteRuleTokenStream(adaptor,"token 33");

        try 
    	{
            // d:\\lesscss.g:55:2: ( '>' -> PARENTOF | '+' -> PRECEDEDS )
            int alt9 = 2;
            int LA9_0 = input.LA(1);

            if ( (LA9_0 == 32) )
            {
                alt9 = 1;
            }
            else if ( (LA9_0 == 33) )
            {
                alt9 = 2;
            }
            else 
            {
                NoViableAltException nvae_d9s0 =
                    new NoViableAltException("", 9, 0, input);

                throw nvae_d9s0;
            }
            switch (alt9) 
            {
                case 1 :
                    // d:\\lesscss.g:55:4: '>'
                    {
                    	char_literal23=(IToken)Match(input,32,FOLLOW_32_in_selectop299);  
                    	stream_32.Add(char_literal23);



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
                    	// 55:8: -> PARENTOF
                    	{
                    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(PARENTOF, "PARENTOF"));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // d:\\lesscss.g:56:11: '+'
                    {
                    	char_literal24=(IToken)Match(input,33,FOLLOW_33_in_selectop315);  
                    	stream_33.Add(char_literal24);



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
                    	// 56:16: -> PRECEDEDS
                    	{
                    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(PRECEDEDS, "PRECEDEDS"));

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
    // $ANTLR end "selectop"

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
    // d:\\lesscss.g:59:10: fragment property : declaration ';' -> declaration ;
    public lesscssParser.property_return property() // throws RecognitionException [1]
    {   
        lesscssParser.property_return retval = new lesscssParser.property_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal26 = null;
        lesscssParser.declaration_return declaration25 = null;


        CommonTree char_literal26_tree=null;
        RewriteRuleTokenStream stream_28 = new RewriteRuleTokenStream(adaptor,"token 28");
        RewriteRuleSubtreeStream stream_declaration = new RewriteRuleSubtreeStream(adaptor,"rule declaration");
        try 
    	{
            // d:\\lesscss.g:60:2: ( declaration ';' -> declaration )
            // d:\\lesscss.g:60:4: declaration ';'
            {
            	PushFollow(FOLLOW_declaration_in_property333);
            	declaration25 = declaration();
            	state.followingStackPointer--;

            	stream_declaration.Add(declaration25.Tree);
            	char_literal26=(IToken)Match(input,28,FOLLOW_28_in_property335);  
            	stream_28.Add(char_literal26);



            	// AST REWRITE
            	// elements:          declaration
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 60:20: -> declaration
            	{
            	    adaptor.AddChild(root_0, stream_declaration.NextTree());

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

    public class elem_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "elem"
    // d:\\lesscss.g:63:10: fragment elem : ( IDENT -> ^( TAG IDENT ) | '#' IDENT -> ^( ID IDENT ) | '.' IDENT -> ^( CLASS IDENT ) );
    public lesscssParser.elem_return elem() // throws RecognitionException [1]
    {   
        lesscssParser.elem_return retval = new lesscssParser.elem_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken IDENT27 = null;
        IToken char_literal28 = null;
        IToken IDENT29 = null;
        IToken char_literal30 = null;
        IToken IDENT31 = null;

        CommonTree IDENT27_tree=null;
        CommonTree char_literal28_tree=null;
        CommonTree IDENT29_tree=null;
        CommonTree char_literal30_tree=null;
        CommonTree IDENT31_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_35 = new RewriteRuleTokenStream(adaptor,"token 35");
        RewriteRuleTokenStream stream_34 = new RewriteRuleTokenStream(adaptor,"token 34");

        try 
    	{
            // d:\\lesscss.g:64:2: ( IDENT -> ^( TAG IDENT ) | '#' IDENT -> ^( ID IDENT ) | '.' IDENT -> ^( CLASS IDENT ) )
            int alt10 = 3;
            switch ( input.LA(1) ) 
            {
            case IDENT:
            	{
                alt10 = 1;
                }
                break;
            case 34:
            	{
                alt10 = 2;
                }
                break;
            case 35:
            	{
                alt10 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d10s0 =
            	        new NoViableAltException("", 10, 0, input);

            	    throw nvae_d10s0;
            }

            switch (alt10) 
            {
                case 1 :
                    // d:\\lesscss.g:64:4: IDENT
                    {
                    	IDENT27=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_elem354);  
                    	stream_IDENT.Add(IDENT27);



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
                    	// 64:10: -> ^( TAG IDENT )
                    	{
                    	    // d:\\lesscss.g:64:13: ^( TAG IDENT )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TAG, "TAG"), root_1);

                    	    adaptor.AddChild(root_1, stream_IDENT.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // d:\\lesscss.g:65:4: '#' IDENT
                    {
                    	char_literal28=(IToken)Match(input,34,FOLLOW_34_in_elem369);  
                    	stream_34.Add(char_literal28);

                    	IDENT29=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_elem371);  
                    	stream_IDENT.Add(IDENT29);



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
                    	// 65:14: -> ^( ID IDENT )
                    	{
                    	    // d:\\lesscss.g:65:17: ^( ID IDENT )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ID, "ID"), root_1);

                    	    adaptor.AddChild(root_1, stream_IDENT.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 3 :
                    // d:\\lesscss.g:66:4: '.' IDENT
                    {
                    	char_literal30=(IToken)Match(input,35,FOLLOW_35_in_elem386);  
                    	stream_35.Add(char_literal30);

                    	IDENT31=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_elem388);  
                    	stream_IDENT.Add(IDENT31);



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
                    	// 66:14: -> ^( CLASS IDENT )
                    	{
                    	    // d:\\lesscss.g:66:17: ^( CLASS IDENT )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(CLASS, "CLASS"), root_1);

                    	    adaptor.AddChild(root_1, stream_IDENT.NextNode());

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
    // $ANTLR end "elem"

    public class pseudo_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "pseudo"
    // d:\\lesscss.g:69:1: pseudo : ( ( ':' | '::' ) IDENT -> ^( PSEUDO IDENT ) | ( ':' | '::' ) function -> ^( PSEUDO function ) );
    public lesscssParser.pseudo_return pseudo() // throws RecognitionException [1]
    {   
        lesscssParser.pseudo_return retval = new lesscssParser.pseudo_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal32 = null;
        IToken string_literal33 = null;
        IToken IDENT34 = null;
        IToken char_literal35 = null;
        IToken string_literal36 = null;
        lesscssParser.function_return function37 = null;


        CommonTree char_literal32_tree=null;
        CommonTree string_literal33_tree=null;
        CommonTree IDENT34_tree=null;
        CommonTree char_literal35_tree=null;
        CommonTree string_literal36_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_36 = new RewriteRuleTokenStream(adaptor,"token 36");
        RewriteRuleTokenStream stream_27 = new RewriteRuleTokenStream(adaptor,"token 27");
        RewriteRuleSubtreeStream stream_function = new RewriteRuleSubtreeStream(adaptor,"rule function");
        try 
    	{
            // d:\\lesscss.g:70:2: ( ( ':' | '::' ) IDENT -> ^( PSEUDO IDENT ) | ( ':' | '::' ) function -> ^( PSEUDO function ) )
            int alt13 = 2;
            int LA13_0 = input.LA(1);

            if ( (LA13_0 == 27) )
            {
                int LA13_1 = input.LA(2);

                if ( (LA13_1 == IDENT) )
                {
                    int LA13_3 = input.LA(3);

                    if ( (LA13_3 == 58) )
                    {
                        alt13 = 2;
                    }
                    else if ( (LA13_3 == EOF) )
                    {
                        alt13 = 1;
                    }
                    else 
                    {
                        NoViableAltException nvae_d13s3 =
                            new NoViableAltException("", 13, 3, input);

                        throw nvae_d13s3;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d13s1 =
                        new NoViableAltException("", 13, 1, input);

                    throw nvae_d13s1;
                }
            }
            else if ( (LA13_0 == 36) )
            {
                int LA13_2 = input.LA(2);

                if ( (LA13_2 == IDENT) )
                {
                    int LA13_4 = input.LA(3);

                    if ( (LA13_4 == 58) )
                    {
                        alt13 = 2;
                    }
                    else if ( (LA13_4 == EOF) )
                    {
                        alt13 = 1;
                    }
                    else 
                    {
                        NoViableAltException nvae_d13s4 =
                            new NoViableAltException("", 13, 4, input);

                        throw nvae_d13s4;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d13s2 =
                        new NoViableAltException("", 13, 2, input);

                    throw nvae_d13s2;
                }
            }
            else 
            {
                NoViableAltException nvae_d13s0 =
                    new NoViableAltException("", 13, 0, input);

                throw nvae_d13s0;
            }
            switch (alt13) 
            {
                case 1 :
                    // d:\\lesscss.g:70:4: ( ':' | '::' ) IDENT
                    {
                    	// d:\\lesscss.g:70:4: ( ':' | '::' )
                    	int alt11 = 2;
                    	int LA11_0 = input.LA(1);

                    	if ( (LA11_0 == 27) )
                    	{
                    	    alt11 = 1;
                    	}
                    	else if ( (LA11_0 == 36) )
                    	{
                    	    alt11 = 2;
                    	}
                    	else 
                    	{
                    	    NoViableAltException nvae_d11s0 =
                    	        new NoViableAltException("", 11, 0, input);

                    	    throw nvae_d11s0;
                    	}
                    	switch (alt11) 
                    	{
                    	    case 1 :
                    	        // d:\\lesscss.g:70:5: ':'
                    	        {
                    	        	char_literal32=(IToken)Match(input,27,FOLLOW_27_in_pseudo410);  
                    	        	stream_27.Add(char_literal32);


                    	        }
                    	        break;
                    	    case 2 :
                    	        // d:\\lesscss.g:70:9: '::'
                    	        {
                    	        	string_literal33=(IToken)Match(input,36,FOLLOW_36_in_pseudo412);  
                    	        	stream_36.Add(string_literal33);


                    	        }
                    	        break;

                    	}

                    	IDENT34=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_pseudo415);  
                    	stream_IDENT.Add(IDENT34);



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
                    	// 70:21: -> ^( PSEUDO IDENT )
                    	{
                    	    // d:\\lesscss.g:70:24: ^( PSEUDO IDENT )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PSEUDO, "PSEUDO"), root_1);

                    	    adaptor.AddChild(root_1, stream_IDENT.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // d:\\lesscss.g:71:4: ( ':' | '::' ) function
                    {
                    	// d:\\lesscss.g:71:4: ( ':' | '::' )
                    	int alt12 = 2;
                    	int LA12_0 = input.LA(1);

                    	if ( (LA12_0 == 27) )
                    	{
                    	    alt12 = 1;
                    	}
                    	else if ( (LA12_0 == 36) )
                    	{
                    	    alt12 = 2;
                    	}
                    	else 
                    	{
                    	    NoViableAltException nvae_d12s0 =
                    	        new NoViableAltException("", 12, 0, input);

                    	    throw nvae_d12s0;
                    	}
                    	switch (alt12) 
                    	{
                    	    case 1 :
                    	        // d:\\lesscss.g:71:5: ':'
                    	        {
                    	        	char_literal35=(IToken)Match(input,27,FOLLOW_27_in_pseudo431);  
                    	        	stream_27.Add(char_literal35);


                    	        }
                    	        break;
                    	    case 2 :
                    	        // d:\\lesscss.g:71:9: '::'
                    	        {
                    	        	string_literal36=(IToken)Match(input,36,FOLLOW_36_in_pseudo433);  
                    	        	stream_36.Add(string_literal36);


                    	        }
                    	        break;

                    	}

                    	PushFollow(FOLLOW_function_in_pseudo436);
                    	function37 = function();
                    	state.followingStackPointer--;

                    	stream_function.Add(function37.Tree);


                    	// AST REWRITE
                    	// elements:          function
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 71:24: -> ^( PSEUDO function )
                    	{
                    	    // d:\\lesscss.g:71:27: ^( PSEUDO function )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PSEUDO, "PSEUDO"), root_1);

                    	    adaptor.AddChild(root_1, stream_function.NextTree());

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
    // $ANTLR end "pseudo"

    public class attrib_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "attrib"
    // d:\\lesscss.g:74:1: attrib : '[' IDENT ( attribRelate ( STRING | IDENT ) )? ']' -> ^( ATTRIB IDENT ( attribRelate ( STRING )* ( IDENT )* )? ) ;
    public lesscssParser.attrib_return attrib() // throws RecognitionException [1]
    {   
        lesscssParser.attrib_return retval = new lesscssParser.attrib_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal38 = null;
        IToken IDENT39 = null;
        IToken STRING41 = null;
        IToken IDENT42 = null;
        IToken char_literal43 = null;
        lesscssParser.attribRelate_return attribRelate40 = null;


        CommonTree char_literal38_tree=null;
        CommonTree IDENT39_tree=null;
        CommonTree STRING41_tree=null;
        CommonTree IDENT42_tree=null;
        CommonTree char_literal43_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_STRING = new RewriteRuleTokenStream(adaptor,"token STRING");
        RewriteRuleTokenStream stream_37 = new RewriteRuleTokenStream(adaptor,"token 37");
        RewriteRuleTokenStream stream_38 = new RewriteRuleTokenStream(adaptor,"token 38");
        RewriteRuleSubtreeStream stream_attribRelate = new RewriteRuleSubtreeStream(adaptor,"rule attribRelate");
        try 
    	{
            // d:\\lesscss.g:75:2: ( '[' IDENT ( attribRelate ( STRING | IDENT ) )? ']' -> ^( ATTRIB IDENT ( attribRelate ( STRING )* ( IDENT )* )? ) )
            // d:\\lesscss.g:75:4: '[' IDENT ( attribRelate ( STRING | IDENT ) )? ']'
            {
            	char_literal38=(IToken)Match(input,37,FOLLOW_37_in_attrib457);  
            	stream_37.Add(char_literal38);

            	IDENT39=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_attrib459);  
            	stream_IDENT.Add(IDENT39);

            	// d:\\lesscss.g:75:14: ( attribRelate ( STRING | IDENT ) )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( ((LA15_0 >= 39 && LA15_0 <= 41)) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // d:\\lesscss.g:75:15: attribRelate ( STRING | IDENT )
            	        {
            	        	PushFollow(FOLLOW_attribRelate_in_attrib462);
            	        	attribRelate40 = attribRelate();
            	        	state.followingStackPointer--;

            	        	stream_attribRelate.Add(attribRelate40.Tree);
            	        	// d:\\lesscss.g:75:28: ( STRING | IDENT )
            	        	int alt14 = 2;
            	        	int LA14_0 = input.LA(1);

            	        	if ( (LA14_0 == STRING) )
            	        	{
            	        	    alt14 = 1;
            	        	}
            	        	else if ( (LA14_0 == IDENT) )
            	        	{
            	        	    alt14 = 2;
            	        	}
            	        	else 
            	        	{
            	        	    NoViableAltException nvae_d14s0 =
            	        	        new NoViableAltException("", 14, 0, input);

            	        	    throw nvae_d14s0;
            	        	}
            	        	switch (alt14) 
            	        	{
            	        	    case 1 :
            	        	        // d:\\lesscss.g:75:29: STRING
            	        	        {
            	        	        	STRING41=(IToken)Match(input,STRING,FOLLOW_STRING_in_attrib465);  
            	        	        	stream_STRING.Add(STRING41);


            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // d:\\lesscss.g:75:38: IDENT
            	        	        {
            	        	        	IDENT42=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_attrib469);  
            	        	        	stream_IDENT.Add(IDENT42);


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	char_literal43=(IToken)Match(input,38,FOLLOW_38_in_attrib474);  
            	stream_38.Add(char_literal43);



            	// AST REWRITE
            	// elements:          IDENT, STRING, IDENT, attribRelate
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 75:51: -> ^( ATTRIB IDENT ( attribRelate ( STRING )* ( IDENT )* )? )
            	{
            	    // d:\\lesscss.g:75:54: ^( ATTRIB IDENT ( attribRelate ( STRING )* ( IDENT )* )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ATTRIB, "ATTRIB"), root_1);

            	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
            	    // d:\\lesscss.g:75:70: ( attribRelate ( STRING )* ( IDENT )* )?
            	    if ( stream_STRING.HasNext() || stream_IDENT.HasNext() || stream_attribRelate.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_attribRelate.NextTree());
            	        // d:\\lesscss.g:75:84: ( STRING )*
            	        while ( stream_STRING.HasNext() )
            	        {
            	            adaptor.AddChild(root_1, stream_STRING.NextNode());

            	        }
            	        stream_STRING.Reset();
            	        // d:\\lesscss.g:75:92: ( IDENT )*
            	        while ( stream_IDENT.HasNext() )
            	        {
            	            adaptor.AddChild(root_1, stream_IDENT.NextNode());

            	        }
            	        stream_IDENT.Reset();

            	    }
            	    stream_STRING.Reset();
            	    stream_IDENT.Reset();
            	    stream_attribRelate.Reset();

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
    // $ANTLR end "attrib"

    public class attribRelate_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "attribRelate"
    // d:\\lesscss.g:78:1: attribRelate : ( '=' -> ATTRIBEQUAL | '~=' -> HASVALUE | '|=' -> BEGINSWITH );
    public lesscssParser.attribRelate_return attribRelate() // throws RecognitionException [1]
    {   
        lesscssParser.attribRelate_return retval = new lesscssParser.attribRelate_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal44 = null;
        IToken string_literal45 = null;
        IToken string_literal46 = null;

        CommonTree char_literal44_tree=null;
        CommonTree string_literal45_tree=null;
        CommonTree string_literal46_tree=null;
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");

        try 
    	{
            // d:\\lesscss.g:79:2: ( '=' -> ATTRIBEQUAL | '~=' -> HASVALUE | '|=' -> BEGINSWITH )
            int alt16 = 3;
            switch ( input.LA(1) ) 
            {
            case 39:
            	{
                alt16 = 1;
                }
                break;
            case 40:
            	{
                alt16 = 2;
                }
                break;
            case 41:
            	{
                alt16 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d16s0 =
            	        new NoViableAltException("", 16, 0, input);

            	    throw nvae_d16s0;
            }

            switch (alt16) 
            {
                case 1 :
                    // d:\\lesscss.g:79:4: '='
                    {
                    	char_literal44=(IToken)Match(input,39,FOLLOW_39_in_attribRelate507);  
                    	stream_39.Add(char_literal44);



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
                    	// 79:9: -> ATTRIBEQUAL
                    	{
                    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(ATTRIBEQUAL, "ATTRIBEQUAL"));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // d:\\lesscss.g:80:4: '~='
                    {
                    	string_literal45=(IToken)Match(input,40,FOLLOW_40_in_attribRelate517);  
                    	stream_40.Add(string_literal45);



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
                    	// 80:9: -> HASVALUE
                    	{
                    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(HASVALUE, "HASVALUE"));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 3 :
                    // d:\\lesscss.g:81:4: '|='
                    {
                    	string_literal46=(IToken)Match(input,41,FOLLOW_41_in_attribRelate526);  
                    	stream_41.Add(string_literal46);



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
                    	// 81:9: -> BEGINSWITH
                    	{
                    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(BEGINSWITH, "BEGINSWITH"));

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
    // $ANTLR end "attribRelate"

    public class declaration_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "declaration"
    // d:\\lesscss.g:84:1: declaration : IDENT ':' args -> ^( PROPERTY IDENT args ) ;
    public lesscssParser.declaration_return declaration() // throws RecognitionException [1]
    {   
        lesscssParser.declaration_return retval = new lesscssParser.declaration_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken IDENT47 = null;
        IToken char_literal48 = null;
        lesscssParser.args_return args49 = null;


        CommonTree IDENT47_tree=null;
        CommonTree char_literal48_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_27 = new RewriteRuleTokenStream(adaptor,"token 27");
        RewriteRuleSubtreeStream stream_args = new RewriteRuleSubtreeStream(adaptor,"rule args");
        try 
    	{
            // d:\\lesscss.g:85:2: ( IDENT ':' args -> ^( PROPERTY IDENT args ) )
            // d:\\lesscss.g:85:4: IDENT ':' args
            {
            	IDENT47=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_declaration544);  
            	stream_IDENT.Add(IDENT47);

            	char_literal48=(IToken)Match(input,27,FOLLOW_27_in_declaration546);  
            	stream_27.Add(char_literal48);

            	PushFollow(FOLLOW_args_in_declaration548);
            	args49 = args();
            	state.followingStackPointer--;

            	stream_args.Add(args49.Tree);


            	// AST REWRITE
            	// elements:          IDENT, args
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 85:19: -> ^( PROPERTY IDENT args )
            	{
            	    // d:\\lesscss.g:85:22: ^( PROPERTY IDENT args )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PROPERTY, "PROPERTY"), root_1);

            	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
            	    adaptor.AddChild(root_1, stream_args.NextTree());

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
    // $ANTLR end "declaration"

    public class expr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "expr"
    // d:\\lesscss.g:89:1: expr : ( ( NUM ( unit )? ) | IDENT | COLOR | STRING | function );
    public lesscssParser.expr_return expr() // throws RecognitionException [1]
    {   
        lesscssParser.expr_return retval = new lesscssParser.expr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken NUM50 = null;
        IToken IDENT52 = null;
        IToken COLOR53 = null;
        IToken STRING54 = null;
        lesscssParser.unit_return unit51 = null;

        lesscssParser.function_return function55 = null;


        CommonTree NUM50_tree=null;
        CommonTree IDENT52_tree=null;
        CommonTree COLOR53_tree=null;
        CommonTree STRING54_tree=null;

        try 
    	{
            // d:\\lesscss.g:90:2: ( ( NUM ( unit )? ) | IDENT | COLOR | STRING | function )
            int alt18 = 5;
            alt18 = dfa18.Predict(input);
            switch (alt18) 
            {
                case 1 :
                    // d:\\lesscss.g:90:4: ( NUM ( unit )? )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// d:\\lesscss.g:90:4: ( NUM ( unit )? )
                    	// d:\\lesscss.g:90:5: NUM ( unit )?
                    	{
                    		NUM50=(IToken)Match(input,NUM,FOLLOW_NUM_in_expr573); 
                    			NUM50_tree = (CommonTree)adaptor.Create(NUM50);
                    			adaptor.AddChild(root_0, NUM50_tree);

                    		// d:\\lesscss.g:90:9: ( unit )?
                    		int alt17 = 2;
                    		int LA17_0 = input.LA(1);

                    		if ( ((LA17_0 >= 42 && LA17_0 <= 57)) )
                    		{
                    		    alt17 = 1;
                    		}
                    		switch (alt17) 
                    		{
                    		    case 1 :
                    		        // d:\\lesscss.g:90:9: unit
                    		        {
                    		        	PushFollow(FOLLOW_unit_in_expr575);
                    		        	unit51 = unit();
                    		        	state.followingStackPointer--;

                    		        	adaptor.AddChild(root_0, unit51.Tree);

                    		        }
                    		        break;

                    		}


                    	}


                    }
                    break;
                case 2 :
                    // d:\\lesscss.g:91:4: IDENT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	IDENT52=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr582); 
                    		IDENT52_tree = (CommonTree)adaptor.Create(IDENT52);
                    		adaptor.AddChild(root_0, IDENT52_tree);


                    }
                    break;
                case 3 :
                    // d:\\lesscss.g:92:4: COLOR
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	COLOR53=(IToken)Match(input,COLOR,FOLLOW_COLOR_in_expr587); 
                    		COLOR53_tree = (CommonTree)adaptor.Create(COLOR53);
                    		adaptor.AddChild(root_0, COLOR53_tree);


                    }
                    break;
                case 4 :
                    // d:\\lesscss.g:93:4: STRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	STRING54=(IToken)Match(input,STRING,FOLLOW_STRING_in_expr592); 
                    		STRING54_tree = (CommonTree)adaptor.Create(STRING54);
                    		adaptor.AddChild(root_0, STRING54_tree);


                    }
                    break;
                case 5 :
                    // d:\\lesscss.g:94:4: function
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_function_in_expr597);
                    	function55 = function();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, function55.Tree);

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
    // $ANTLR end "expr"

    public class unit_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "unit"
    // d:\\lesscss.g:97:1: unit : ( '%' | 'px' | 'cm' | 'mm' | 'in' | 'pt' | 'pc' | 'em' | 'ex' | 'deg' | 'rad' | 'grad' | 'ms' | 's' | 'hz' | 'khz' ) ;
    public lesscssParser.unit_return unit() // throws RecognitionException [1]
    {   
        lesscssParser.unit_return retval = new lesscssParser.unit_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set56 = null;

        CommonTree set56_tree=null;

        try 
    	{
            // d:\\lesscss.g:98:2: ( ( '%' | 'px' | 'cm' | 'mm' | 'in' | 'pt' | 'pc' | 'em' | 'ex' | 'deg' | 'rad' | 'grad' | 'ms' | 's' | 'hz' | 'khz' ) )
            // d:\\lesscss.g:98:4: ( '%' | 'px' | 'cm' | 'mm' | 'in' | 'pt' | 'pc' | 'em' | 'ex' | 'deg' | 'rad' | 'grad' | 'ms' | 's' | 'hz' | 'khz' )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set56 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 42 && input.LA(1) <= 57) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set56));
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
    // $ANTLR end "unit"

    public class args_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "args"
    // d:\\lesscss.g:101:1: args : expr ( ( ',' )? expr )* -> ( expr )* ;
    public lesscssParser.args_return args() // throws RecognitionException [1]
    {   
        lesscssParser.args_return retval = new lesscssParser.args_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal58 = null;
        lesscssParser.expr_return expr57 = null;

        lesscssParser.expr_return expr59 = null;


        CommonTree char_literal58_tree=null;
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        try 
    	{
            // d:\\lesscss.g:102:2: ( expr ( ( ',' )? expr )* -> ( expr )* )
            // d:\\lesscss.g:102:4: expr ( ( ',' )? expr )*
            {
            	PushFollow(FOLLOW_expr_in_args652);
            	expr57 = expr();
            	state.followingStackPointer--;

            	stream_expr.Add(expr57.Tree);
            	// d:\\lesscss.g:102:9: ( ( ',' )? expr )*
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( ((LA20_0 >= IDENT && LA20_0 <= COLOR) || LA20_0 == 31) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // d:\\lesscss.g:102:10: ( ',' )? expr
            			    {
            			    	// d:\\lesscss.g:102:10: ( ',' )?
            			    	int alt19 = 2;
            			    	int LA19_0 = input.LA(1);

            			    	if ( (LA19_0 == 31) )
            			    	{
            			    	    alt19 = 1;
            			    	}
            			    	switch (alt19) 
            			    	{
            			    	    case 1 :
            			    	        // d:\\lesscss.g:102:10: ','
            			    	        {
            			    	        	char_literal58=(IToken)Match(input,31,FOLLOW_31_in_args655);  
            			    	        	stream_31.Add(char_literal58);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_expr_in_args658);
            			    	expr59 = expr();
            			    	state.followingStackPointer--;

            			    	stream_expr.Add(expr59.Tree);

            			    }
            			    break;

            			default:
            			    goto loop20;
            	    }
            	} while (true);

            	loop20:
            		;	// Stops C# compiler whining that label 'loop20' has no statements



            	// AST REWRITE
            	// elements:          expr
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 102:22: -> ( expr )*
            	{
            	    // d:\\lesscss.g:102:25: ( expr )*
            	    while ( stream_expr.HasNext() )
            	    {
            	        adaptor.AddChild(root_0, stream_expr.NextTree());

            	    }
            	    stream_expr.Reset();

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
    // $ANTLR end "args"

    public class function_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "function"
    // d:\\lesscss.g:105:1: function : IDENT '(' ( args )? ')' -> IDENT '(' ( args )* ')' ;
    public lesscssParser.function_return function() // throws RecognitionException [1]
    {   
        lesscssParser.function_return retval = new lesscssParser.function_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken IDENT60 = null;
        IToken char_literal61 = null;
        IToken char_literal63 = null;
        lesscssParser.args_return args62 = null;


        CommonTree IDENT60_tree=null;
        CommonTree char_literal61_tree=null;
        CommonTree char_literal63_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_59 = new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleTokenStream stream_58 = new RewriteRuleTokenStream(adaptor,"token 58");
        RewriteRuleSubtreeStream stream_args = new RewriteRuleSubtreeStream(adaptor,"rule args");
        try 
    	{
            // d:\\lesscss.g:106:2: ( IDENT '(' ( args )? ')' -> IDENT '(' ( args )* ')' )
            // d:\\lesscss.g:106:4: IDENT '(' ( args )? ')'
            {
            	IDENT60=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_function676);  
            	stream_IDENT.Add(IDENT60);

            	char_literal61=(IToken)Match(input,58,FOLLOW_58_in_function678);  
            	stream_58.Add(char_literal61);

            	// d:\\lesscss.g:106:14: ( args )?
            	int alt21 = 2;
            	int LA21_0 = input.LA(1);

            	if ( ((LA21_0 >= IDENT && LA21_0 <= COLOR)) )
            	{
            	    alt21 = 1;
            	}
            	switch (alt21) 
            	{
            	    case 1 :
            	        // d:\\lesscss.g:106:14: args
            	        {
            	        	PushFollow(FOLLOW_args_in_function680);
            	        	args62 = args();
            	        	state.followingStackPointer--;

            	        	stream_args.Add(args62.Tree);

            	        }
            	        break;

            	}

            	char_literal63=(IToken)Match(input,59,FOLLOW_59_in_function683);  
            	stream_59.Add(char_literal63);



            	// AST REWRITE
            	// elements:          args, 58, IDENT, 59
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 106:24: -> IDENT '(' ( args )* ')'
            	{
            	    adaptor.AddChild(root_0, stream_IDENT.NextNode());
            	    adaptor.AddChild(root_0, stream_58.NextNode());
            	    // d:\\lesscss.g:106:37: ( args )*
            	    while ( stream_args.HasNext() )
            	    {
            	        adaptor.AddChild(root_0, stream_args.NextTree());

            	    }
            	    stream_args.Reset();
            	    adaptor.AddChild(root_0, stream_59.NextNode());

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
    // $ANTLR end "function"

    // Delegated rules


   	protected DFA4 dfa4;
   	protected DFA18 dfa18;
	private void InitializeCyclicDFAs()
	{
    	this.dfa4 = new DFA4(this);
    	this.dfa18 = new DFA18(this);


	}

    const string DFA4_eotS =
        "\x0d\uffff";
    const string DFA4_eofS =
        "\x0d\uffff";
    const string DFA4_minS =
        "\x02\x13\x0b\uffff";
    const string DFA4_maxS =
        "\x01\x23\x01\x25\x0b\uffff";
    const string DFA4_acceptS =
        "\x02\uffff\x01\x01\x01\uffff\x01\x02\x08\uffff";
    const string DFA4_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x01\x01\x0e\uffff\x02\x02",
            "\x01\x02\x07\uffff\x01\x04\x01\uffff\x01\x02\x01\uffff\x05"+
            "\x02\x01\uffff\x01\x02",
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

    static readonly short[] DFA4_eot = DFA.UnpackEncodedString(DFA4_eotS);
    static readonly short[] DFA4_eof = DFA.UnpackEncodedString(DFA4_eofS);
    static readonly char[] DFA4_min = DFA.UnpackEncodedStringToUnsignedChars(DFA4_minS);
    static readonly char[] DFA4_max = DFA.UnpackEncodedStringToUnsignedChars(DFA4_maxS);
    static readonly short[] DFA4_accept = DFA.UnpackEncodedString(DFA4_acceptS);
    static readonly short[] DFA4_special = DFA.UnpackEncodedString(DFA4_specialS);
    static readonly short[][] DFA4_transition = DFA.UnpackEncodedStringArray(DFA4_transitionS);

    protected class DFA4 : DFA
    {
        public DFA4(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 4;
            this.eot = DFA4_eot;
            this.eof = DFA4_eof;
            this.min = DFA4_min;
            this.max = DFA4_max;
            this.accept = DFA4_accept;
            this.special = DFA4_special;
            this.transition = DFA4_transition;

        }

        override public string Description
        {
            get { return "39:10: fragment rulesetLine : ( ruleset | property );"; }
        }

    }

    const string DFA18_eotS =
        "\x0d\uffff";
    const string DFA18_eofS =
        "\x0d\uffff";
    const string DFA18_minS =
        "\x01\x13\x01\uffff\x01\x13\x0a\uffff";
    const string DFA18_maxS =
        "\x01\x16\x01\uffff\x01\x3b\x0a\uffff";
    const string DFA18_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x02\x06"+
        "\uffff";
    const string DFA18_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA18_transitionS = {
            "\x01\x02\x01\x04\x01\x01\x01\x03",
            "",
            "\x04\x06\x05\uffff\x01\x06\x02\uffff\x01\x06\x1a\uffff\x01"+
            "\x05\x01\x06",
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

    static readonly short[] DFA18_eot = DFA.UnpackEncodedString(DFA18_eotS);
    static readonly short[] DFA18_eof = DFA.UnpackEncodedString(DFA18_eofS);
    static readonly char[] DFA18_min = DFA.UnpackEncodedStringToUnsignedChars(DFA18_minS);
    static readonly char[] DFA18_max = DFA.UnpackEncodedStringToUnsignedChars(DFA18_maxS);
    static readonly short[] DFA18_accept = DFA.UnpackEncodedString(DFA18_acceptS);
    static readonly short[] DFA18_special = DFA.UnpackEncodedString(DFA18_specialS);
    static readonly short[][] DFA18_transition = DFA.UnpackEncodedStringArray(DFA18_transitionS);

    protected class DFA18 : DFA
    {
        public DFA18(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 18;
            this.eot = DFA18_eot;
            this.eof = DFA18_eof;
            this.min = DFA18_min;
            this.max = DFA18_max;
            this.accept = DFA18_accept;
            this.special = DFA18_special;
            this.transition = DFA18_transition;

        }

        override public string Description
        {
            get { return "89:1: expr : ( ( NUM ( unit )? ) | IDENT | COLOR | STRING | function );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_cssRule_in_lessCss104 = new BitSet(new ulong[]{0x0000000C04080002UL});
    public static readonly BitSet FOLLOW_variable_in_cssRule128 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ruleset_in_cssRule132 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_26_in_variable140 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_IDENT_in_variable142 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_variable144 = new BitSet(new ulong[]{0x0000000000780000UL});
    public static readonly BitSet FOLLOW_expr_in_variable146 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_variable148 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectors_in_ruleset170 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_ruleset172 = new BitSet(new ulong[]{0x0000000C44080000UL});
    public static readonly BitSet FOLLOW_rulesetLine_in_ruleset174 = new BitSet(new ulong[]{0x0000000C44080000UL});
    public static readonly BitSet FOLLOW_30_in_ruleset177 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ruleset_in_rulesetLine205 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_property_in_rulesetLine209 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selector_in_selectors219 = new BitSet(new ulong[]{0x0000000080000002UL});
    public static readonly BitSet FOLLOW_31_in_selectors222 = new BitSet(new ulong[]{0x0000000C84080000UL});
    public static readonly BitSet FOLLOW_selector_in_selectors224 = new BitSet(new ulong[]{0x0000000080000002UL});
    public static readonly BitSet FOLLOW_elem_in_selector248 = new BitSet(new ulong[]{0x0000002F04080002UL});
    public static readonly BitSet FOLLOW_selectorOperation_in_selector250 = new BitSet(new ulong[]{0x0000002F04080002UL});
    public static readonly BitSet FOLLOW_attrib_in_selector253 = new BitSet(new ulong[]{0x0000002000000002UL});
    public static readonly BitSet FOLLOW_selectop_in_selectorOperation276 = new BitSet(new ulong[]{0x0000000C04080000UL});
    public static readonly BitSet FOLLOW_elem_in_selectorOperation279 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_32_in_selectop299 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_33_in_selectop315 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_declaration_in_property333 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_property335 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_elem354 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_34_in_elem369 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_IDENT_in_elem371 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_35_in_elem386 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_IDENT_in_elem388 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_27_in_pseudo410 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_36_in_pseudo412 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_IDENT_in_pseudo415 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_27_in_pseudo431 = new BitSet(new ulong[]{0x0000000000780000UL});
    public static readonly BitSet FOLLOW_36_in_pseudo433 = new BitSet(new ulong[]{0x0000000000780000UL});
    public static readonly BitSet FOLLOW_function_in_pseudo436 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_attrib457 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_IDENT_in_attrib459 = new BitSet(new ulong[]{0x000003C000000000UL});
    public static readonly BitSet FOLLOW_attribRelate_in_attrib462 = new BitSet(new ulong[]{0x0000000000180000UL});
    public static readonly BitSet FOLLOW_STRING_in_attrib465 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_attrib469 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_38_in_attrib474 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_attribRelate507 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_attribRelate517 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_attribRelate526 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_declaration544 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_declaration546 = new BitSet(new ulong[]{0x0000000000780000UL});
    public static readonly BitSet FOLLOW_args_in_declaration548 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUM_in_expr573 = new BitSet(new ulong[]{0x03FFFC0000000002UL});
    public static readonly BitSet FOLLOW_unit_in_expr575 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_expr582 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COLOR_in_expr587 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_expr592 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_function_in_expr597 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unit608 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_args652 = new BitSet(new ulong[]{0x0000000080780002UL});
    public static readonly BitSet FOLLOW_31_in_args655 = new BitSet(new ulong[]{0x0000000000780000UL});
    public static readonly BitSet FOLLOW_expr_in_args658 = new BitSet(new ulong[]{0x0000000080780002UL});
    public static readonly BitSet FOLLOW_IDENT_in_function676 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_function678 = new BitSet(new ulong[]{0x0800000000780000UL});
    public static readonly BitSet FOLLOW_args_in_function680 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_function683 = new BitSet(new ulong[]{0x0000000000000002UL});

}
