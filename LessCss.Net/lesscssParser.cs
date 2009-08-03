// $ANTLR 3.1.2 D:\\lesscss.g 2009-08-02 22:25:16


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
		"SelectorClass", 
		"IDENT", 
		"SelectorID", 
		"PSEUDO", 
		"STRING", 
		"NUM", 
		"COLOR", 
		"UNIT", 
		"SL_COMMENT", 
		"COMMENT", 
		"WS", 
		"'{'", 
		"'}'", 
		"','", 
		"'>'", 
		"'+'", 
		"':'", 
		"';'", 
		"'@'"
    };

    public const int SELECTORGROUP = 7;
    public const int T__27 = 27;
    public const int RULE = 5;
    public const int T__26 = 26;
    public const int T__25 = 25;
    public const int T__24 = 24;
    public const int T__23 = 23;
    public const int T__22 = 22;
    public const int T__21 = 21;
    public const int PSEUDO = 12;
    public const int T__20 = 20;
    public const int EOF = -1;
    public const int COLOR = 15;
    public const int NUM = 14;
    public const int UNIT = 16;
    public const int WS = 19;
    public const int SELECTOR = 8;
    public const int PROPERTY = 6;
    public const int SelectorID = 11;
    public const int SL_COMMENT = 17;
    public const int IDENT = 10;
    public const int SelectorClass = 9;
    public const int VAR = 4;
    public const int COMMENT = 18;
    public const int STRING = 13;

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
    // D:\\lesscss.g:17:1: lessCss : ( lessLine )* ;
    public lesscssParser.lessCss_return lessCss() // throws RecognitionException [1]
    {   
        lesscssParser.lessCss_return retval = new lesscssParser.lessCss_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.lessLine_return lessLine1 = null;



        try 
    	{
            // D:\\lesscss.g:18:2: ( ( lessLine )* )
            // D:\\lesscss.g:18:4: ( lessLine )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// D:\\lesscss.g:18:4: ( lessLine )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= SelectorClass && LA1_0 <= PSEUDO) || (LA1_0 >= 23 && LA1_0 <= 24) || LA1_0 == 27) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // D:\\lesscss.g:18:5: lessLine
            			    {
            			    	PushFollow(FOLLOW_lessLine_in_lessCss66);
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
    // D:\\lesscss.g:21:10: fragment lessLine : ( variable | ruleset );
    public lesscssParser.lessLine_return lessLine() // throws RecognitionException [1]
    {   
        lesscssParser.lessLine_return retval = new lesscssParser.lessLine_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.variable_return variable2 = null;

        lesscssParser.ruleset_return ruleset3 = null;



        try 
    	{
            // D:\\lesscss.g:22:2: ( variable | ruleset )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0 == 27) )
            {
                alt2 = 1;
            }
            else if ( ((LA2_0 >= SelectorClass && LA2_0 <= PSEUDO) || (LA2_0 >= 23 && LA2_0 <= 24)) )
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
                    // D:\\lesscss.g:22:4: variable
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variable_in_lessLine82);
                    	variable2 = variable();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variable2.Tree);

                    }
                    break;
                case 2 :
                    // D:\\lesscss.g:22:15: ruleset
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ruleset_in_lessLine86);
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
    // D:\\lesscss.g:25:1: ruleset : selectors '{' ( ruleContents )* '}' -> ^( RULE ( selectors )+ ( ruleContents )* ) ;
    public lesscssParser.ruleset_return ruleset() // throws RecognitionException [1]
    {   
        lesscssParser.ruleset_return retval = new lesscssParser.ruleset_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal5 = null;
        IToken char_literal7 = null;
        lesscssParser.selectors_return selectors4 = null;

        lesscssParser.ruleContents_return ruleContents6 = null;


        CommonTree char_literal5_tree=null;
        CommonTree char_literal7_tree=null;
        RewriteRuleTokenStream stream_21 = new RewriteRuleTokenStream(adaptor,"token 21");
        RewriteRuleTokenStream stream_20 = new RewriteRuleTokenStream(adaptor,"token 20");
        RewriteRuleSubtreeStream stream_ruleContents = new RewriteRuleSubtreeStream(adaptor,"rule ruleContents");
        RewriteRuleSubtreeStream stream_selectors = new RewriteRuleSubtreeStream(adaptor,"rule selectors");
        try 
    	{
            // D:\\lesscss.g:26:2: ( selectors '{' ( ruleContents )* '}' -> ^( RULE ( selectors )+ ( ruleContents )* ) )
            // D:\\lesscss.g:26:4: selectors '{' ( ruleContents )* '}'
            {
            	PushFollow(FOLLOW_selectors_in_ruleset99);
            	selectors4 = selectors();
            	state.followingStackPointer--;

            	stream_selectors.Add(selectors4.Tree);
            	char_literal5=(IToken)Match(input,20,FOLLOW_20_in_ruleset101);  
            	stream_20.Add(char_literal5);

            	// D:\\lesscss.g:26:18: ( ruleContents )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= SelectorClass && LA3_0 <= PSEUDO) || (LA3_0 >= 23 && LA3_0 <= 24)) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // D:\\lesscss.g:26:18: ruleContents
            			    {
            			    	PushFollow(FOLLOW_ruleContents_in_ruleset103);
            			    	ruleContents6 = ruleContents();
            			    	state.followingStackPointer--;

            			    	stream_ruleContents.Add(ruleContents6.Tree);

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	char_literal7=(IToken)Match(input,21,FOLLOW_21_in_ruleset106);  
            	stream_21.Add(char_literal7);



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
            	// 26:36: -> ^( RULE ( selectors )+ ( ruleContents )* )
            	{
            	    // D:\\lesscss.g:26:39: ^( RULE ( selectors )+ ( ruleContents )* )
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
            	    // D:\\lesscss.g:26:57: ( ruleContents )*
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
    // D:\\lesscss.g:29:10: fragment ruleContents : ( property | ruleset );
    public lesscssParser.ruleContents_return ruleContents() // throws RecognitionException [1]
    {   
        lesscssParser.ruleContents_return retval = new lesscssParser.ruleContents_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.property_return property8 = null;

        lesscssParser.ruleset_return ruleset9 = null;



        try 
    	{
            // D:\\lesscss.g:30:2: ( property | ruleset )
            int alt4 = 2;
            alt4 = dfa4.Predict(input);
            switch (alt4) 
            {
                case 1 :
                    // D:\\lesscss.g:30:4: property
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_property_in_ruleContents132);
                    	property8 = property();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, property8.Tree);

                    }
                    break;
                case 2 :
                    // D:\\lesscss.g:30:15: ruleset
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ruleset_in_ruleContents136);
                    	ruleset9 = ruleset();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ruleset9.Tree);

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
    // D:\\lesscss.g:33:10: fragment selectors : selectorGrouping ( ',' selectorGrouping )* -> ^( SELECTORGROUP ( selectorGrouping )+ ) ;
    public lesscssParser.selectors_return selectors() // throws RecognitionException [1]
    {   
        lesscssParser.selectors_return retval = new lesscssParser.selectors_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal11 = null;
        lesscssParser.selectorGrouping_return selectorGrouping10 = null;

        lesscssParser.selectorGrouping_return selectorGrouping12 = null;


        CommonTree char_literal11_tree=null;
        RewriteRuleTokenStream stream_22 = new RewriteRuleTokenStream(adaptor,"token 22");
        RewriteRuleSubtreeStream stream_selectorGrouping = new RewriteRuleSubtreeStream(adaptor,"rule selectorGrouping");
        try 
    	{
            // D:\\lesscss.g:34:2: ( selectorGrouping ( ',' selectorGrouping )* -> ^( SELECTORGROUP ( selectorGrouping )+ ) )
            // D:\\lesscss.g:34:4: selectorGrouping ( ',' selectorGrouping )*
            {
            	PushFollow(FOLLOW_selectorGrouping_in_selectors149);
            	selectorGrouping10 = selectorGrouping();
            	state.followingStackPointer--;

            	stream_selectorGrouping.Add(selectorGrouping10.Tree);
            	// D:\\lesscss.g:34:21: ( ',' selectorGrouping )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == 22) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // D:\\lesscss.g:34:22: ',' selectorGrouping
            			    {
            			    	char_literal11=(IToken)Match(input,22,FOLLOW_22_in_selectors152);  
            			    	stream_22.Add(char_literal11);

            			    	PushFollow(FOLLOW_selectorGrouping_in_selectors154);
            			    	selectorGrouping12 = selectorGrouping();
            			    	state.followingStackPointer--;

            			    	stream_selectorGrouping.Add(selectorGrouping12.Tree);

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements



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
            	// 34:45: -> ^( SELECTORGROUP ( selectorGrouping )+ )
            	{
            	    // D:\\lesscss.g:34:48: ^( SELECTORGROUP ( selectorGrouping )+ )
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
    // D:\\lesscss.g:37:10: fragment selectorGrouping : ( ( selectorOps )? selector )+ -> ^( SELECTOR ( selector )+ ) ;
    public lesscssParser.selectorGrouping_return selectorGrouping() // throws RecognitionException [1]
    {   
        lesscssParser.selectorGrouping_return retval = new lesscssParser.selectorGrouping_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.selectorOps_return selectorOps13 = null;

        lesscssParser.selector_return selector14 = null;


        RewriteRuleSubtreeStream stream_selector = new RewriteRuleSubtreeStream(adaptor,"rule selector");
        RewriteRuleSubtreeStream stream_selectorOps = new RewriteRuleSubtreeStream(adaptor,"rule selectorOps");
        try 
    	{
            // D:\\lesscss.g:38:2: ( ( ( selectorOps )? selector )+ -> ^( SELECTOR ( selector )+ ) )
            // D:\\lesscss.g:38:4: ( ( selectorOps )? selector )+
            {
            	// D:\\lesscss.g:38:4: ( ( selectorOps )? selector )+
            	int cnt7 = 0;
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( ((LA7_0 >= SelectorClass && LA7_0 <= PSEUDO) || (LA7_0 >= 23 && LA7_0 <= 24)) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // D:\\lesscss.g:38:5: ( selectorOps )? selector
            			    {
            			    	// D:\\lesscss.g:38:5: ( selectorOps )?
            			    	int alt6 = 2;
            			    	int LA6_0 = input.LA(1);

            			    	if ( ((LA6_0 >= 23 && LA6_0 <= 24)) )
            			    	{
            			    	    alt6 = 1;
            			    	}
            			    	switch (alt6) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\lesscss.g:38:5: selectorOps
            			    	        {
            			    	        	PushFollow(FOLLOW_selectorOps_in_selectorGrouping180);
            			    	        	selectorOps13 = selectorOps();
            			    	        	state.followingStackPointer--;

            			    	        	stream_selectorOps.Add(selectorOps13.Tree);

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_selector_in_selectorGrouping183);
            			    	selector14 = selector();
            			    	state.followingStackPointer--;

            			    	stream_selector.Add(selector14.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt7 >= 1 ) goto loop7;
            		            EarlyExitException eee7 =
            		                new EarlyExitException(7, input);
            		            throw eee7;
            	    }
            	    cnt7++;
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whinging that label 'loop7' has no statements



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
            	// 38:29: -> ^( SELECTOR ( selector )+ )
            	{
            	    // D:\\lesscss.g:38:32: ^( SELECTOR ( selector )+ )
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
    // D:\\lesscss.g:41:10: fragment selector : ( ( SelectorClass | IDENT | SelectorID ) ( PSEUDO )? | PSEUDO );
    public lesscssParser.selector_return selector() // throws RecognitionException [1]
    {   
        lesscssParser.selector_return retval = new lesscssParser.selector_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set15 = null;
        IToken PSEUDO16 = null;
        IToken PSEUDO17 = null;

        CommonTree set15_tree=null;
        CommonTree PSEUDO16_tree=null;
        CommonTree PSEUDO17_tree=null;

        try 
    	{
            // D:\\lesscss.g:42:2: ( ( SelectorClass | IDENT | SelectorID ) ( PSEUDO )? | PSEUDO )
            int alt9 = 2;
            int LA9_0 = input.LA(1);

            if ( ((LA9_0 >= SelectorClass && LA9_0 <= SelectorID)) )
            {
                alt9 = 1;
            }
            else if ( (LA9_0 == PSEUDO) )
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
                    // D:\\lesscss.g:42:4: ( SelectorClass | IDENT | SelectorID ) ( PSEUDO )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	set15 = (IToken)input.LT(1);
                    	if ( (input.LA(1) >= SelectorClass && input.LA(1) <= SelectorID) ) 
                    	{
                    	    input.Consume();
                    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set15));
                    	    state.errorRecovery = false;
                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    throw mse;
                    	}

                    	// D:\\lesscss.g:42:41: ( PSEUDO )?
                    	int alt8 = 2;
                    	int LA8_0 = input.LA(1);

                    	if ( (LA8_0 == PSEUDO) )
                    	{
                    	    alt8 = 1;
                    	}
                    	switch (alt8) 
                    	{
                    	    case 1 :
                    	        // D:\\lesscss.g:42:42: PSEUDO
                    	        {
                    	        	PSEUDO16=(IToken)Match(input,PSEUDO,FOLLOW_PSEUDO_in_selector221); 
                    	        		PSEUDO16_tree = (CommonTree)adaptor.Create(PSEUDO16);
                    	        		adaptor.AddChild(root_0, PSEUDO16_tree);


                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // D:\\lesscss.g:43:4: PSEUDO
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PSEUDO17=(IToken)Match(input,PSEUDO,FOLLOW_PSEUDO_in_selector228); 
                    		PSEUDO17_tree = (CommonTree)adaptor.Create(PSEUDO17);
                    		adaptor.AddChild(root_0, PSEUDO17_tree);


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
    // D:\\lesscss.g:49:10: fragment selectorOps : ( '>' | '+' );
    public lesscssParser.selectorOps_return selectorOps() // throws RecognitionException [1]
    {   
        lesscssParser.selectorOps_return retval = new lesscssParser.selectorOps_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set18 = null;

        CommonTree set18_tree=null;

        try 
    	{
            // D:\\lesscss.g:50:2: ( '>' | '+' )
            // D:\\lesscss.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set18 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 23 && input.LA(1) <= 24) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set18));
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
    // D:\\lesscss.g:53:10: fragment property : ( IDENT ':' ( val )+ ';' -> ^( PROPERTY IDENT ( val )? ) | IDENT ':' varname ';' -> ^( PROPERTY IDENT VAR varname ) );
    public lesscssParser.property_return property() // throws RecognitionException [1]
    {   
        lesscssParser.property_return retval = new lesscssParser.property_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken IDENT19 = null;
        IToken char_literal20 = null;
        IToken char_literal22 = null;
        IToken IDENT23 = null;
        IToken char_literal24 = null;
        IToken char_literal26 = null;
        lesscssParser.val_return val21 = null;

        lesscssParser.varname_return varname25 = null;


        CommonTree IDENT19_tree=null;
        CommonTree char_literal20_tree=null;
        CommonTree char_literal22_tree=null;
        CommonTree IDENT23_tree=null;
        CommonTree char_literal24_tree=null;
        CommonTree char_literal26_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_25 = new RewriteRuleTokenStream(adaptor,"token 25");
        RewriteRuleTokenStream stream_26 = new RewriteRuleTokenStream(adaptor,"token 26");
        RewriteRuleSubtreeStream stream_val = new RewriteRuleSubtreeStream(adaptor,"rule val");
        RewriteRuleSubtreeStream stream_varname = new RewriteRuleSubtreeStream(adaptor,"rule varname");
        try 
    	{
            // D:\\lesscss.g:54:2: ( IDENT ':' ( val )+ ';' -> ^( PROPERTY IDENT ( val )? ) | IDENT ':' varname ';' -> ^( PROPERTY IDENT VAR varname ) )
            int alt11 = 2;
            int LA11_0 = input.LA(1);

            if ( (LA11_0 == IDENT) )
            {
                int LA11_1 = input.LA(2);

                if ( (LA11_1 == 25) )
                {
                    int LA11_2 = input.LA(3);

                    if ( (LA11_2 == IDENT || (LA11_2 >= STRING && LA11_2 <= COLOR)) )
                    {
                        alt11 = 1;
                    }
                    else if ( (LA11_2 == 27) )
                    {
                        alt11 = 2;
                    }
                    else 
                    {
                        NoViableAltException nvae_d11s2 =
                            new NoViableAltException("", 11, 2, input);

                        throw nvae_d11s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d11s1 =
                        new NoViableAltException("", 11, 1, input);

                    throw nvae_d11s1;
                }
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
                    // D:\\lesscss.g:54:4: IDENT ':' ( val )+ ';'
                    {
                    	IDENT19=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_property272);  
                    	stream_IDENT.Add(IDENT19);

                    	char_literal20=(IToken)Match(input,25,FOLLOW_25_in_property274);  
                    	stream_25.Add(char_literal20);

                    	// D:\\lesscss.g:54:14: ( val )+
                    	int cnt10 = 0;
                    	do 
                    	{
                    	    int alt10 = 2;
                    	    int LA10_0 = input.LA(1);

                    	    if ( (LA10_0 == IDENT || (LA10_0 >= STRING && LA10_0 <= COLOR)) )
                    	    {
                    	        alt10 = 1;
                    	    }


                    	    switch (alt10) 
                    		{
                    			case 1 :
                    			    // D:\\lesscss.g:54:14: val
                    			    {
                    			    	PushFollow(FOLLOW_val_in_property276);
                    			    	val21 = val();
                    			    	state.followingStackPointer--;

                    			    	stream_val.Add(val21.Tree);

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

                    	char_literal22=(IToken)Match(input,26,FOLLOW_26_in_property279);  
                    	stream_26.Add(char_literal22);



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
                    	// 54:23: -> ^( PROPERTY IDENT ( val )? )
                    	{
                    	    // D:\\lesscss.g:54:26: ^( PROPERTY IDENT ( val )? )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PROPERTY, "PROPERTY"), root_1);

                    	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
                    	    // D:\\lesscss.g:54:43: ( val )?
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
                    break;
                case 2 :
                    // D:\\lesscss.g:55:4: IDENT ':' varname ';'
                    {
                    	IDENT23=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_property295);  
                    	stream_IDENT.Add(IDENT23);

                    	char_literal24=(IToken)Match(input,25,FOLLOW_25_in_property297);  
                    	stream_25.Add(char_literal24);

                    	PushFollow(FOLLOW_varname_in_property299);
                    	varname25 = varname();
                    	state.followingStackPointer--;

                    	stream_varname.Add(varname25.Tree);
                    	char_literal26=(IToken)Match(input,26,FOLLOW_26_in_property301);  
                    	stream_26.Add(char_literal26);



                    	// AST REWRITE
                    	// elements:          varname, IDENT
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 55:26: -> ^( PROPERTY IDENT VAR varname )
                    	{
                    	    // D:\\lesscss.g:55:29: ^( PROPERTY IDENT VAR varname )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PROPERTY, "PROPERTY"), root_1);

                    	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
                    	    adaptor.AddChild(root_1, (CommonTree)adaptor.Create(VAR, "VAR"));
                    	    adaptor.AddChild(root_1, stream_varname.NextTree());

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
    // D:\\lesscss.g:58:1: variable : varname ':' val ';' -> ^( VAR IDENT val ) ;
    public lesscssParser.variable_return variable() // throws RecognitionException [1]
    {   
        lesscssParser.variable_return retval = new lesscssParser.variable_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal28 = null;
        IToken char_literal30 = null;
        lesscssParser.varname_return varname27 = null;

        lesscssParser.val_return val29 = null;


        CommonTree char_literal28_tree=null;
        CommonTree char_literal30_tree=null;
        RewriteRuleTokenStream stream_25 = new RewriteRuleTokenStream(adaptor,"token 25");
        RewriteRuleTokenStream stream_26 = new RewriteRuleTokenStream(adaptor,"token 26");
        RewriteRuleSubtreeStream stream_val = new RewriteRuleSubtreeStream(adaptor,"rule val");
        RewriteRuleSubtreeStream stream_varname = new RewriteRuleSubtreeStream(adaptor,"rule varname");
        try 
    	{
            // D:\\lesscss.g:59:2: ( varname ':' val ';' -> ^( VAR IDENT val ) )
            // D:\\lesscss.g:59:4: varname ':' val ';'
            {
            	PushFollow(FOLLOW_varname_in_variable326);
            	varname27 = varname();
            	state.followingStackPointer--;

            	stream_varname.Add(varname27.Tree);
            	char_literal28=(IToken)Match(input,25,FOLLOW_25_in_variable328);  
            	stream_25.Add(char_literal28);

            	PushFollow(FOLLOW_val_in_variable330);
            	val29 = val();
            	state.followingStackPointer--;

            	stream_val.Add(val29.Tree);
            	char_literal30=(IToken)Match(input,26,FOLLOW_26_in_variable332);  
            	stream_26.Add(char_literal30);



            	// AST REWRITE
            	// elements:          val
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 59:24: -> ^( VAR IDENT val )
            	{
            	    // D:\\lesscss.g:59:27: ^( VAR IDENT val )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(VAR, "VAR"), root_1);

            	    adaptor.AddChild(root_1, (CommonTree)adaptor.Create(IDENT, "IDENT"));
            	    adaptor.AddChild(root_1, stream_val.NextTree());

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
    // D:\\lesscss.g:62:1: varname : '@' IDENT ;
    public lesscssParser.varname_return varname() // throws RecognitionException [1]
    {   
        lesscssParser.varname_return retval = new lesscssParser.varname_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal31 = null;
        IToken IDENT32 = null;

        CommonTree char_literal31_tree=null;
        CommonTree IDENT32_tree=null;

        try 
    	{
            // D:\\lesscss.g:63:2: ( '@' IDENT )
            // D:\\lesscss.g:63:4: '@' IDENT
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal31=(IToken)Match(input,27,FOLLOW_27_in_varname354); 
            		char_literal31_tree = (CommonTree)adaptor.Create(char_literal31);
            		adaptor.AddChild(root_0, char_literal31_tree);

            	IDENT32=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_varname356); 
            		IDENT32_tree = (CommonTree)adaptor.Create(IDENT32);
            		adaptor.AddChild(root_0, IDENT32_tree);


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
    // D:\\lesscss.g:66:10: fragment val : ( IDENT | STRING | NUM | COLOR );
    public lesscssParser.val_return val() // throws RecognitionException [1]
    {   
        lesscssParser.val_return retval = new lesscssParser.val_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set33 = null;

        CommonTree set33_tree=null;

        try 
    	{
            // D:\\lesscss.g:67:2: ( IDENT | STRING | NUM | COLOR )
            // D:\\lesscss.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set33 = (IToken)input.LT(1);
            	if ( input.LA(1) == IDENT || (input.LA(1) >= STRING && input.LA(1) <= COLOR) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set33));
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
    // $ANTLR end "val"

    // Delegated rules


   	protected DFA4 dfa4;
	private void InitializeCyclicDFAs()
	{
    	this.dfa4 = new DFA4(this);
	}

    const string DFA4_eotS =
        "\x0b\uffff";
    const string DFA4_eofS =
        "\x0b\uffff";
    const string DFA4_minS =
        "\x02\x09\x09\uffff";
    const string DFA4_maxS =
        "\x01\x18\x01\x19\x09\uffff";
    const string DFA4_acceptS =
        "\x02\uffff\x01\x02\x02\uffff\x01\x01\x05\uffff";
    const string DFA4_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x01\x02\x01\x01\x02\x02\x0a\uffff\x02\x02",
            "\x04\x02\x07\uffff\x01\x02\x01\uffff\x03\x02\x01\x05",
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
            get { return "29:10: fragment ruleContents : ( property | ruleset );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_lessLine_in_lessCss66 = new BitSet(new ulong[]{0x0000000009801E02UL});
    public static readonly BitSet FOLLOW_variable_in_lessLine82 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ruleset_in_lessLine86 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectors_in_ruleset99 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_20_in_ruleset101 = new BitSet(new ulong[]{0x0000000009A01E00UL});
    public static readonly BitSet FOLLOW_ruleContents_in_ruleset103 = new BitSet(new ulong[]{0x0000000009A01E00UL});
    public static readonly BitSet FOLLOW_21_in_ruleset106 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_property_in_ruleContents132 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ruleset_in_ruleContents136 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectorGrouping_in_selectors149 = new BitSet(new ulong[]{0x0000000000400002UL});
    public static readonly BitSet FOLLOW_22_in_selectors152 = new BitSet(new ulong[]{0x0000000009C01E00UL});
    public static readonly BitSet FOLLOW_selectorGrouping_in_selectors154 = new BitSet(new ulong[]{0x0000000000400002UL});
    public static readonly BitSet FOLLOW_selectorOps_in_selectorGrouping180 = new BitSet(new ulong[]{0x0000000009801E00UL});
    public static readonly BitSet FOLLOW_selector_in_selectorGrouping183 = new BitSet(new ulong[]{0x0000000009801E02UL});
    public static readonly BitSet FOLLOW_set_in_selector208 = new BitSet(new ulong[]{0x0000000000001002UL});
    public static readonly BitSet FOLLOW_PSEUDO_in_selector221 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PSEUDO_in_selector228 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_selectorOps0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_property272 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_25_in_property274 = new BitSet(new ulong[]{0x000000000000E400UL});
    public static readonly BitSet FOLLOW_val_in_property276 = new BitSet(new ulong[]{0x000000000400E400UL});
    public static readonly BitSet FOLLOW_26_in_property279 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_property295 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_25_in_property297 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_varname_in_property299 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_property301 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varname_in_variable326 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_25_in_variable328 = new BitSet(new ulong[]{0x000000000000E400UL});
    public static readonly BitSet FOLLOW_val_in_variable330 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_variable332 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_27_in_varname354 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_IDENT_in_varname356 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_val0 = new BitSet(new ulong[]{0x0000000000000002UL});

}
