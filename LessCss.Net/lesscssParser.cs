// $ANTLR 3.1.2 d:\\lesscss.g 2009-07-29 11:01:45


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
		"SELECTOR", 
		"IDENT", 
		"SelectorClass", 
		"SelectorID", 
		"ALPHANUMERIC", 
		"SL_COMMENT", 
		"COMMENT", 
		"WS", 
		"','", 
		"'{'", 
		"'}'", 
		"':'", 
		"';'", 
		"'@'"
    };

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
    // d:\\lesscss.g:16:1: lessCss : ( lessLine )* ;
    public lesscssParser.lessCss_return lessCss() // throws RecognitionException [1]
    {   
        lesscssParser.lessCss_return retval = new lesscssParser.lessCss_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.lessLine_return lessLine1 = null;



        try 
    	{
            // d:\\lesscss.g:17:2: ( ( lessLine )* )
            // d:\\lesscss.g:17:4: ( lessLine )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// d:\\lesscss.g:17:4: ( lessLine )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= IDENT && LA1_0 <= SelectorID) || LA1_0 == 20) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // d:\\lesscss.g:17:5: lessLine
            			    {
            			    	PushFollow(FOLLOW_lessLine_in_lessCss62);
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
    // d:\\lesscss.g:20:10: fragment lessLine : ( variable | ruleset );
    public lesscssParser.lessLine_return lessLine() // throws RecognitionException [1]
    {   
        lesscssParser.lessLine_return retval = new lesscssParser.lessLine_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.variable_return variable2 = null;

        lesscssParser.ruleset_return ruleset3 = null;



        try 
    	{
            // d:\\lesscss.g:21:2: ( variable | ruleset )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0 == 20) )
            {
                alt2 = 1;
            }
            else if ( ((LA2_0 >= IDENT && LA2_0 <= SelectorID)) )
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
                    // d:\\lesscss.g:21:4: variable
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variable_in_lessLine78);
                    	variable2 = variable();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variable2.Tree);

                    }
                    break;
                case 2 :
                    // d:\\lesscss.g:21:15: ruleset
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ruleset_in_lessLine82);
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
    // $ANTLR end "lessLine"

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
    // d:\\lesscss.g:24:1: ruleset : selectors ( ',' selectors )* '{' ( ruleContents )* '}' -> ^( RULE ( selectors )+ ( ruleContents )* ) ;
    public lesscssParser.ruleset_return ruleset() // throws RecognitionException [1]
    {   
        lesscssParser.ruleset_return retval = new lesscssParser.ruleset_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal5 = null;
        IToken char_literal7 = null;
        IToken char_literal9 = null;
        lesscssParser.selectors_return selectors4 = null;

        lesscssParser.selectors_return selectors6 = null;

        lesscssParser.ruleContents_return ruleContents8 = null;


        CommonTree char_literal5_tree=null;
        CommonTree char_literal7_tree=null;
        CommonTree char_literal9_tree=null;
        RewriteRuleTokenStream stream_17 = new RewriteRuleTokenStream(adaptor,"token 17");
        RewriteRuleTokenStream stream_15 = new RewriteRuleTokenStream(adaptor,"token 15");
        RewriteRuleTokenStream stream_16 = new RewriteRuleTokenStream(adaptor,"token 16");
        RewriteRuleSubtreeStream stream_ruleContents = new RewriteRuleSubtreeStream(adaptor,"rule ruleContents");
        RewriteRuleSubtreeStream stream_selectors = new RewriteRuleSubtreeStream(adaptor,"rule selectors");
        try 
    	{
            // d:\\lesscss.g:25:2: ( selectors ( ',' selectors )* '{' ( ruleContents )* '}' -> ^( RULE ( selectors )+ ( ruleContents )* ) )
            // d:\\lesscss.g:25:4: selectors ( ',' selectors )* '{' ( ruleContents )* '}'
            {
            	PushFollow(FOLLOW_selectors_in_ruleset95);
            	selectors4 = selectors();
            	state.followingStackPointer--;

            	stream_selectors.Add(selectors4.Tree);
            	// d:\\lesscss.g:25:14: ( ',' selectors )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == 15) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // d:\\lesscss.g:25:15: ',' selectors
            			    {
            			    	char_literal5=(IToken)Match(input,15,FOLLOW_15_in_ruleset98);  
            			    	stream_15.Add(char_literal5);

            			    	PushFollow(FOLLOW_selectors_in_ruleset100);
            			    	selectors6 = selectors();
            			    	state.followingStackPointer--;

            			    	stream_selectors.Add(selectors6.Tree);

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	char_literal7=(IToken)Match(input,16,FOLLOW_16_in_ruleset104);  
            	stream_16.Add(char_literal7);

            	// d:\\lesscss.g:25:35: ( ruleContents )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( ((LA4_0 >= IDENT && LA4_0 <= SelectorID)) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // d:\\lesscss.g:25:35: ruleContents
            			    {
            			    	PushFollow(FOLLOW_ruleContents_in_ruleset106);
            			    	ruleContents8 = ruleContents();
            			    	state.followingStackPointer--;

            			    	stream_ruleContents.Add(ruleContents8.Tree);

            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements

            	char_literal9=(IToken)Match(input,17,FOLLOW_17_in_ruleset109);  
            	stream_17.Add(char_literal9);



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
            	// 25:53: -> ^( RULE ( selectors )+ ( ruleContents )* )
            	{
            	    // d:\\lesscss.g:25:56: ^( RULE ( selectors )+ ( ruleContents )* )
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
            	    // d:\\lesscss.g:25:74: ( ruleContents )*
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
    // d:\\lesscss.g:28:1: ruleContents : ( ruleset | property );
    public lesscssParser.ruleContents_return ruleContents() // throws RecognitionException [1]
    {   
        lesscssParser.ruleContents_return retval = new lesscssParser.ruleContents_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.ruleset_return ruleset10 = null;

        lesscssParser.property_return property11 = null;



        try 
    	{
            // d:\\lesscss.g:29:2: ( ruleset | property )
            int alt5 = 2;
            int LA5_0 = input.LA(1);

            if ( (LA5_0 == IDENT) )
            {
                int LA5_1 = input.LA(2);

                if ( (LA5_1 == 18) )
                {
                    alt5 = 2;
                }
                else if ( ((LA5_1 >= IDENT && LA5_1 <= SelectorID) || (LA5_1 >= 15 && LA5_1 <= 16)) )
                {
                    alt5 = 1;
                }
                else 
                {
                    NoViableAltException nvae_d5s1 =
                        new NoViableAltException("", 5, 1, input);

                    throw nvae_d5s1;
                }
            }
            else if ( ((LA5_0 >= SelectorClass && LA5_0 <= SelectorID)) )
            {
                alt5 = 1;
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
                    // d:\\lesscss.g:29:4: ruleset
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ruleset_in_ruleContents133);
                    	ruleset10 = ruleset();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ruleset10.Tree);

                    }
                    break;
                case 2 :
                    // d:\\lesscss.g:29:14: property
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_property_in_ruleContents137);
                    	property11 = property();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, property11.Tree);

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
    // d:\\lesscss.g:32:1: selectors : ( selector )+ -> ^( SELECTOR ( selector )+ ) ;
    public lesscssParser.selectors_return selectors() // throws RecognitionException [1]
    {   
        lesscssParser.selectors_return retval = new lesscssParser.selectors_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.selector_return selector12 = null;


        RewriteRuleSubtreeStream stream_selector = new RewriteRuleSubtreeStream(adaptor,"rule selector");
        try 
    	{
            // d:\\lesscss.g:33:2: ( ( selector )+ -> ^( SELECTOR ( selector )+ ) )
            // d:\\lesscss.g:33:4: ( selector )+
            {
            	// d:\\lesscss.g:33:4: ( selector )+
            	int cnt6 = 0;
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= IDENT && LA6_0 <= SelectorID)) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // d:\\lesscss.g:33:4: selector
            			    {
            			    	PushFollow(FOLLOW_selector_in_selectors148);
            			    	selector12 = selector();
            			    	state.followingStackPointer--;

            			    	stream_selector.Add(selector12.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt6 >= 1 ) goto loop6;
            		            EarlyExitException eee6 =
            		                new EarlyExitException(6, input);
            		            throw eee6;
            	    }
            	    cnt6++;
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whinging that label 'loop6' has no statements



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
            	// 33:14: -> ^( SELECTOR ( selector )+ )
            	{
            	    // d:\\lesscss.g:33:17: ^( SELECTOR ( selector )+ )
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
    // d:\\lesscss.g:36:1: selector : ( IDENT | SelectorClass | SelectorID );
    public lesscssParser.selector_return selector() // throws RecognitionException [1]
    {   
        lesscssParser.selector_return retval = new lesscssParser.selector_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set13 = null;

        CommonTree set13_tree=null;

        try 
    	{
            // d:\\lesscss.g:37:2: ( IDENT | SelectorClass | SelectorID )
            // d:\\lesscss.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set13 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IDENT && input.LA(1) <= SelectorID) ) 
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
    // d:\\lesscss.g:49:1: property : IDENT ':' val ';' -> ^( PROPERTY IDENT ( val )? ) ;
    public lesscssParser.property_return property() // throws RecognitionException [1]
    {   
        lesscssParser.property_return retval = new lesscssParser.property_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken IDENT14 = null;
        IToken char_literal15 = null;
        IToken char_literal17 = null;
        lesscssParser.val_return val16 = null;


        CommonTree IDENT14_tree=null;
        CommonTree char_literal15_tree=null;
        CommonTree char_literal17_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_19 = new RewriteRuleTokenStream(adaptor,"token 19");
        RewriteRuleTokenStream stream_18 = new RewriteRuleTokenStream(adaptor,"token 18");
        RewriteRuleSubtreeStream stream_val = new RewriteRuleSubtreeStream(adaptor,"rule val");
        try 
    	{
            // d:\\lesscss.g:50:2: ( IDENT ':' val ';' -> ^( PROPERTY IDENT ( val )? ) )
            // d:\\lesscss.g:50:4: IDENT ':' val ';'
            {
            	IDENT14=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_property218);  
            	stream_IDENT.Add(IDENT14);

            	char_literal15=(IToken)Match(input,18,FOLLOW_18_in_property220);  
            	stream_18.Add(char_literal15);

            	PushFollow(FOLLOW_val_in_property222);
            	val16 = val();
            	state.followingStackPointer--;

            	stream_val.Add(val16.Tree);
            	char_literal17=(IToken)Match(input,19,FOLLOW_19_in_property224);  
            	stream_19.Add(char_literal17);



            	// AST REWRITE
            	// elements:          val, IDENT
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 50:22: -> ^( PROPERTY IDENT ( val )? )
            	{
            	    // d:\\lesscss.g:50:25: ^( PROPERTY IDENT ( val )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PROPERTY, "PROPERTY"), root_1);

            	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
            	    // d:\\lesscss.g:50:42: ( val )?
            	    if ( stream_val.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_val.NextTree());

            	    }
            	    stream_val.Reset();

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
    // $ANTLR end "property"

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
    // d:\\lesscss.g:53:1: variable : '@' IDENT ':' val ';' -> ^( VAR IDENT ( val )? ) ;
    public lesscssParser.variable_return variable() // throws RecognitionException [1]
    {   
        lesscssParser.variable_return retval = new lesscssParser.variable_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal18 = null;
        IToken IDENT19 = null;
        IToken char_literal20 = null;
        IToken char_literal22 = null;
        lesscssParser.val_return val21 = null;


        CommonTree char_literal18_tree=null;
        CommonTree IDENT19_tree=null;
        CommonTree char_literal20_tree=null;
        CommonTree char_literal22_tree=null;
        RewriteRuleTokenStream stream_20 = new RewriteRuleTokenStream(adaptor,"token 20");
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_19 = new RewriteRuleTokenStream(adaptor,"token 19");
        RewriteRuleTokenStream stream_18 = new RewriteRuleTokenStream(adaptor,"token 18");
        RewriteRuleSubtreeStream stream_val = new RewriteRuleSubtreeStream(adaptor,"rule val");
        try 
    	{
            // d:\\lesscss.g:54:2: ( '@' IDENT ':' val ';' -> ^( VAR IDENT ( val )? ) )
            // d:\\lesscss.g:54:4: '@' IDENT ':' val ';'
            {
            	char_literal18=(IToken)Match(input,20,FOLLOW_20_in_variable248);  
            	stream_20.Add(char_literal18);

            	IDENT19=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_variable250);  
            	stream_IDENT.Add(IDENT19);

            	char_literal20=(IToken)Match(input,18,FOLLOW_18_in_variable252);  
            	stream_18.Add(char_literal20);

            	PushFollow(FOLLOW_val_in_variable254);
            	val21 = val();
            	state.followingStackPointer--;

            	stream_val.Add(val21.Tree);
            	char_literal22=(IToken)Match(input,19,FOLLOW_19_in_variable256);  
            	stream_19.Add(char_literal22);



            	// AST REWRITE
            	// elements:          val, IDENT
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 54:26: -> ^( VAR IDENT ( val )? )
            	{
            	    // d:\\lesscss.g:54:29: ^( VAR IDENT ( val )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(VAR, "VAR"), root_1);

            	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
            	    // d:\\lesscss.g:54:41: ( val )?
            	    if ( stream_val.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_val.NextTree());

            	    }
            	    stream_val.Reset();

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
    // d:\\lesscss.g:57:10: fragment val : ( . )* ;
    public lesscssParser.val_return val() // throws RecognitionException [1]
    {   
        lesscssParser.val_return retval = new lesscssParser.val_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken wildcard23 = null;

        CommonTree wildcard23_tree=null;

        try 
    	{
            // d:\\lesscss.g:58:2: ( ( . )* )
            // d:\\lesscss.g:58:5: ( . )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// d:\\lesscss.g:58:5: ( . )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == 19) )
            	    {
            	        alt7 = 2;
            	    }
            	    else if ( ((LA7_0 >= VAR && LA7_0 <= 18) || LA7_0 == 20) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // d:\\lesscss.g:58:5: .
            			    {
            			    	wildcard23 = (IToken)input.LT(1);
            			    	MatchAny(input); 
            			    		wildcard23_tree = (CommonTree)adaptor.Create(wildcard23);
            			    		adaptor.AddChild(root_0, wildcard23_tree);


            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements


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


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_lessLine_in_lessCss62 = new BitSet(new ulong[]{0x0000000000100702UL});
    public static readonly BitSet FOLLOW_variable_in_lessLine78 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ruleset_in_lessLine82 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectors_in_ruleset95 = new BitSet(new ulong[]{0x0000000000018000UL});
    public static readonly BitSet FOLLOW_15_in_ruleset98 = new BitSet(new ulong[]{0x0000000000118700UL});
    public static readonly BitSet FOLLOW_selectors_in_ruleset100 = new BitSet(new ulong[]{0x0000000000018000UL});
    public static readonly BitSet FOLLOW_16_in_ruleset104 = new BitSet(new ulong[]{0x0000000000120700UL});
    public static readonly BitSet FOLLOW_ruleContents_in_ruleset106 = new BitSet(new ulong[]{0x0000000000120700UL});
    public static readonly BitSet FOLLOW_17_in_ruleset109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ruleset_in_ruleContents133 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_property_in_ruleContents137 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selector_in_selectors148 = new BitSet(new ulong[]{0x0000000000100702UL});
    public static readonly BitSet FOLLOW_set_in_selector0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_property218 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_property220 = new BitSet(new ulong[]{0x00000000001FFFF0UL});
    public static readonly BitSet FOLLOW_val_in_property222 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_property224 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_20_in_variable248 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_IDENT_in_variable250 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_variable252 = new BitSet(new ulong[]{0x00000000001FFFF0UL});
    public static readonly BitSet FOLLOW_val_in_variable254 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_variable256 = new BitSet(new ulong[]{0x0000000000000002UL});

}
