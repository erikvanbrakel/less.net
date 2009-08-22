// $ANTLR 3.1.2 D:\\development\\Less.Net\\lesscss.g 2009-08-22 06:00:27

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

public partial class lesscssParser : Parser
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
		"COLOR", 
		"IDENT", 
		"STRING", 
		"NUM", 
		"UNIT", 
		"SL_COMMENT", 
		"COMMENT", 
		"WS", 
		"'@'", 
		"':'", 
		"';'", 
		"','", 
		"'+'", 
		"'-'", 
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
		"'#'", 
		"'.'"
    };

    public const int SELECTORGROUP = 7;
    public const int CLASS = 10;
    public const int T__29 = 29;
    public const int T__28 = 28;
    public const int T__27 = 27;
    public const int T__26 = 26;
    public const int ID = 12;
    public const int EOF = -1;
    public const int COLOR = 18;
    public const int SELECTOR = 8;
    public const int EXPR = 14;
    public const int WILDCARD = 13;
    public const int IDENT = 19;
    public const int VAR = 4;
    public const int COMMENT = 24;
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
    public const int NUM = 21;
    public const int TAG = 11;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int UNIT = 22;
    public const int T__32 = 32;
    public const int MIXIN = 17;
    public const int WS = 25;
    public const int T__33 = 33;
    public const int FONTDEFINITION = 9;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int PROPERTY = 6;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int SL_COMMENT = 23;
    public const int CONSTANT = 15;
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
		get { return "D:\\development\\Less.Net\\lesscss.g"; }
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
    // D:\\development\\Less.Net\\lesscss.g:27:1: lessCss : ( lessLine )+ ;
    public lesscssParser.lessCss_return lessCss() // throws RecognitionException [1]
    {   
        lesscssParser.lessCss_return retval = new lesscssParser.lessCss_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.lessLine_return lessLine1 = default(lesscssParser.lessLine_return);



        try 
    	{
            // D:\\development\\Less.Net\\lesscss.g:28:2: ( ( lessLine )+ )
            // D:\\development\\Less.Net\\lesscss.g:28:4: ( lessLine )+
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// D:\\development\\Less.Net\\lesscss.g:28:4: ( lessLine )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == IDENT || LA1_0 == 26 || LA1_0 == 36 || (LA1_0 >= 49 && LA1_0 <= 50)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // D:\\development\\Less.Net\\lesscss.g:28:5: lessLine
            			    {
            			    	PushFollow(FOLLOW_lessLine_in_lessCss101);
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
    // D:\\development\\Less.Net\\lesscss.g:32:10: fragment variable : '@' IDENT ':' ( literal -> ^( VAR IDENT ^( LITERAL literal ) ) | expression -> ^( VAR IDENT expression ) ) ';' ;
    public lesscssParser.variable_return variable() // throws RecognitionException [1]
    {   
        lesscssParser.variable_return retval = new lesscssParser.variable_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal2 = null;
        IToken IDENT3 = null;
        IToken char_literal4 = null;
        IToken char_literal7 = null;
        lesscssParser.literal_return literal5 = default(lesscssParser.literal_return);

        lesscssParser.expression_return expression6 = default(lesscssParser.expression_return);


        CommonTree char_literal2_tree=null;
        CommonTree IDENT3_tree=null;
        CommonTree char_literal4_tree=null;
        CommonTree char_literal7_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_26 = new RewriteRuleTokenStream(adaptor,"token 26");
        RewriteRuleTokenStream stream_27 = new RewriteRuleTokenStream(adaptor,"token 27");
        RewriteRuleTokenStream stream_28 = new RewriteRuleTokenStream(adaptor,"token 28");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_literal = new RewriteRuleSubtreeStream(adaptor,"rule literal");
        try 
    	{
            // D:\\development\\Less.Net\\lesscss.g:33:2: ( '@' IDENT ':' ( literal -> ^( VAR IDENT ^( LITERAL literal ) ) | expression -> ^( VAR IDENT expression ) ) ';' )
            // D:\\development\\Less.Net\\lesscss.g:33:4: '@' IDENT ':' ( literal -> ^( VAR IDENT ^( LITERAL literal ) ) | expression -> ^( VAR IDENT expression ) ) ';'
            {
            	char_literal2=(IToken)Match(input,26,FOLLOW_26_in_variable118);  
            	stream_26.Add(char_literal2);

            	IDENT3=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_variable120);  
            	stream_IDENT.Add(IDENT3);

            	char_literal4=(IToken)Match(input,27,FOLLOW_27_in_variable122);  
            	stream_27.Add(char_literal4);

            	// D:\\development\\Less.Net\\lesscss.g:33:18: ( literal -> ^( VAR IDENT ^( LITERAL literal ) ) | expression -> ^( VAR IDENT expression ) )
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( ((LA2_0 >= IDENT && LA2_0 <= STRING)) )
            	{
            	    alt2 = 1;
            	}
            	else if ( (LA2_0 == COLOR || LA2_0 == NUM || LA2_0 == 26 || LA2_0 == 34) )
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
            	        // D:\\development\\Less.Net\\lesscss.g:33:19: literal
            	        {
            	        	PushFollow(FOLLOW_literal_in_variable125);
            	        	literal5 = literal();
            	        	state.followingStackPointer--;

            	        	stream_literal.Add(literal5.Tree);


            	        	// AST REWRITE
            	        	// elements:          IDENT, literal
            	        	// token labels:      
            	        	// rule labels:       retval
            	        	// token list labels: 
            	        	// rule list labels:  
            	        	// wildcard labels: 
            	        	retval.Tree = root_0;
            	        	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	        	root_0 = (CommonTree)adaptor.GetNilNode();
            	        	// 33:27: -> ^( VAR IDENT ^( LITERAL literal ) )
            	        	{
            	        	    // D:\\development\\Less.Net\\lesscss.g:33:30: ^( VAR IDENT ^( LITERAL literal ) )
            	        	    {
            	        	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	        	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(VAR, "VAR"), root_1);

            	        	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
            	        	    // D:\\development\\Less.Net\\lesscss.g:33:42: ^( LITERAL literal )
            	        	    {
            	        	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	        	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(LITERAL, "LITERAL"), root_2);

            	        	    adaptor.AddChild(root_2, stream_literal.NextTree());

            	        	    adaptor.AddChild(root_1, root_2);
            	        	    }

            	        	    adaptor.AddChild(root_0, root_1);
            	        	    }

            	        	}

            	        	retval.Tree = root_0;retval.Tree = root_0;
            	        }
            	        break;
            	    case 2 :
            	        // D:\\development\\Less.Net\\lesscss.g:33:64: expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_variable143);
            	        	expression6 = expression();
            	        	state.followingStackPointer--;

            	        	stream_expression.Add(expression6.Tree);


            	        	// AST REWRITE
            	        	// elements:          IDENT, expression
            	        	// token labels:      
            	        	// rule labels:       retval
            	        	// token list labels: 
            	        	// rule list labels:  
            	        	// wildcard labels: 
            	        	retval.Tree = root_0;
            	        	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	        	root_0 = (CommonTree)adaptor.GetNilNode();
            	        	// 33:75: -> ^( VAR IDENT expression )
            	        	{
            	        	    // D:\\development\\Less.Net\\lesscss.g:33:78: ^( VAR IDENT expression )
            	        	    {
            	        	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	        	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(VAR, "VAR"), root_1);

            	        	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
            	        	    adaptor.AddChild(root_1, stream_expression.NextTree());

            	        	    adaptor.AddChild(root_0, root_1);
            	        	    }

            	        	}

            	        	retval.Tree = root_0;retval.Tree = root_0;
            	        }
            	        break;

            	}

            	char_literal7=(IToken)Match(input,28,FOLLOW_28_in_variable156);  
            	stream_28.Add(char_literal7);


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
    // D:\\development\\Less.Net\\lesscss.g:37:10: fragment lessLine : ( ruleset -> ^( ruleset ) | mediadefinition -> ^( mediadefinition ) | variable -> ^( variable ) );
    public lesscssParser.lessLine_return lessLine() // throws RecognitionException [1]
    {   
        lesscssParser.lessLine_return retval = new lesscssParser.lessLine_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.ruleset_return ruleset8 = default(lesscssParser.ruleset_return);

        lesscssParser.mediadefinition_return mediadefinition9 = default(lesscssParser.mediadefinition_return);

        lesscssParser.variable_return variable10 = default(lesscssParser.variable_return);


        RewriteRuleSubtreeStream stream_ruleset = new RewriteRuleSubtreeStream(adaptor,"rule ruleset");
        RewriteRuleSubtreeStream stream_mediadefinition = new RewriteRuleSubtreeStream(adaptor,"rule mediadefinition");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
            // D:\\development\\Less.Net\\lesscss.g:38:2: ( ruleset -> ^( ruleset ) | mediadefinition -> ^( mediadefinition ) | variable -> ^( variable ) )
            int alt3 = 3;
            switch ( input.LA(1) ) 
            {
            case IDENT:
            case 49:
            case 50:
            	{
                alt3 = 1;
                }
                break;
            case 36:
            	{
                alt3 = 2;
                }
                break;
            case 26:
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
                    // D:\\development\\Less.Net\\lesscss.g:38:4: ruleset
                    {
                    	PushFollow(FOLLOW_ruleset_in_lessLine172);
                    	ruleset8 = ruleset();
                    	state.followingStackPointer--;

                    	stream_ruleset.Add(ruleset8.Tree);


                    	// AST REWRITE
                    	// elements:          ruleset
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 38:12: -> ^( ruleset )
                    	{
                    	    // D:\\development\\Less.Net\\lesscss.g:38:15: ^( ruleset )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_ruleset.NextNode(), root_1);

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // D:\\development\\Less.Net\\lesscss.g:38:28: mediadefinition
                    {
                    	PushFollow(FOLLOW_mediadefinition_in_lessLine182);
                    	mediadefinition9 = mediadefinition();
                    	state.followingStackPointer--;

                    	stream_mediadefinition.Add(mediadefinition9.Tree);


                    	// AST REWRITE
                    	// elements:          mediadefinition
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 38:44: -> ^( mediadefinition )
                    	{
                    	    // D:\\development\\Less.Net\\lesscss.g:38:47: ^( mediadefinition )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_mediadefinition.NextNode(), root_1);

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 3 :
                    // D:\\development\\Less.Net\\lesscss.g:38:68: variable
                    {
                    	PushFollow(FOLLOW_variable_in_lessLine192);
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
                    	// 38:77: -> ^( variable )
                    	{
                    	    // D:\\development\\Less.Net\\lesscss.g:38:80: ^( variable )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_variable.NextNode(), root_1);

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
    // D:\\development\\Less.Net\\lesscss.g:43:10: fragment literal : ( STRING | IDENT ) ( ',' ( STRING | IDENT ) )* ;
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
            // D:\\development\\Less.Net\\lesscss.g:44:2: ( ( STRING | IDENT ) ( ',' ( STRING | IDENT ) )* )
            // D:\\development\\Less.Net\\lesscss.g:44:4: ( STRING | IDENT ) ( ',' ( STRING | IDENT ) )*
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

            	// D:\\development\\Less.Net\\lesscss.g:44:21: ( ',' ( STRING | IDENT ) )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == 29) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // D:\\development\\Less.Net\\lesscss.g:44:22: ',' ( STRING | IDENT )
            			    {
            			    	char_literal12=(IToken)Match(input,29,FOLLOW_29_in_literal223); 
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
    // D:\\development\\Less.Net\\lesscss.g:47:10: fragment varname : '@' IDENT -> IDENT ;
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
        RewriteRuleTokenStream stream_26 = new RewriteRuleTokenStream(adaptor,"token 26");

        try 
    	{
            // D:\\development\\Less.Net\\lesscss.g:48:2: ( '@' IDENT -> IDENT )
            // D:\\development\\Less.Net\\lesscss.g:48:4: '@' IDENT
            {
            	char_literal14=(IToken)Match(input,26,FOLLOW_26_in_varname247);  
            	stream_26.Add(char_literal14);

            	IDENT15=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_varname249);  
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
            	// 48:14: -> IDENT
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
    // D:\\development\\Less.Net\\lesscss.g:52:10: fragment expression : additiveExpression -> ^( EXPR ^( additiveExpression ) ) ;
    public lesscssParser.expression_return expression() // throws RecognitionException [1]
    {   
        lesscssParser.expression_return retval = new lesscssParser.expression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.additiveExpression_return additiveExpression16 = default(lesscssParser.additiveExpression_return);


        RewriteRuleSubtreeStream stream_additiveExpression = new RewriteRuleSubtreeStream(adaptor,"rule additiveExpression");
        try 
    	{
            // D:\\development\\Less.Net\\lesscss.g:53:2: ( additiveExpression -> ^( EXPR ^( additiveExpression ) ) )
            // D:\\development\\Less.Net\\lesscss.g:53:5: additiveExpression
            {
            	PushFollow(FOLLOW_additiveExpression_in_expression268);
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
            	// 53:24: -> ^( EXPR ^( additiveExpression ) )
            	{
            	    // D:\\development\\Less.Net\\lesscss.g:53:27: ^( EXPR ^( additiveExpression ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(EXPR, "EXPR"), root_1);

            	    // D:\\development\\Less.Net\\lesscss.g:53:34: ^( additiveExpression )
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot(stream_additiveExpression.NextNode(), root_2);

            	    adaptor.AddChild(root_1, root_2);
            	    }

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
    // D:\\development\\Less.Net\\lesscss.g:56:10: fragment additiveExpression : multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* ;
    public lesscssParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        lesscssParser.additiveExpression_return retval = new lesscssParser.additiveExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set18 = null;
        lesscssParser.multiplicativeExpression_return multiplicativeExpression17 = default(lesscssParser.multiplicativeExpression_return);

        lesscssParser.multiplicativeExpression_return multiplicativeExpression19 = default(lesscssParser.multiplicativeExpression_return);


        CommonTree set18_tree=null;

        try 
    	{
            // D:\\development\\Less.Net\\lesscss.g:57:2: ( multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* )
            // D:\\development\\Less.Net\\lesscss.g:57:4: multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression291);
            	multiplicativeExpression17 = multiplicativeExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, multiplicativeExpression17.Tree);
            	// D:\\development\\Less.Net\\lesscss.g:57:29: ( ( '+' | '-' ) multiplicativeExpression )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= 30 && LA5_0 <= 31)) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // D:\\development\\Less.Net\\lesscss.g:57:31: ( '+' | '-' ) multiplicativeExpression
            			    {
            			    	set18=(IToken)input.LT(1);
            			    	set18 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= 30 && input.LA(1) <= 31) ) 
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

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression302);
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
    // D:\\development\\Less.Net\\lesscss.g:60:10: fragment multiplicativeExpression : primaryExpression ( ( '*' | '/' ) primaryExpression )* ;
    public lesscssParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        lesscssParser.multiplicativeExpression_return retval = new lesscssParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set21 = null;
        lesscssParser.primaryExpression_return primaryExpression20 = default(lesscssParser.primaryExpression_return);

        lesscssParser.primaryExpression_return primaryExpression22 = default(lesscssParser.primaryExpression_return);


        CommonTree set21_tree=null;

        try 
    	{
            // D:\\development\\Less.Net\\lesscss.g:61:2: ( primaryExpression ( ( '*' | '/' ) primaryExpression )* )
            // D:\\development\\Less.Net\\lesscss.g:61:4: primaryExpression ( ( '*' | '/' ) primaryExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_primaryExpression_in_multiplicativeExpression319);
            	primaryExpression20 = primaryExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, primaryExpression20.Tree);
            	// D:\\development\\Less.Net\\lesscss.g:61:22: ( ( '*' | '/' ) primaryExpression )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= 32 && LA6_0 <= 33)) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // D:\\development\\Less.Net\\lesscss.g:61:24: ( '*' | '/' ) primaryExpression
            			    {
            			    	set21=(IToken)input.LT(1);
            			    	set21 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= 32 && input.LA(1) <= 33) ) 
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

            			    	PushFollow(FOLLOW_primaryExpression_in_multiplicativeExpression330);
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
    // D:\\development\\Less.Net\\lesscss.g:64:10: fragment primaryExpression : ( '(' additiveExpression ')' | value );
    public lesscssParser.primaryExpression_return primaryExpression() // throws RecognitionException [1]
    {   
        lesscssParser.primaryExpression_return retval = new lesscssParser.primaryExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal23 = null;
        IToken char_literal25 = null;
        lesscssParser.additiveExpression_return additiveExpression24 = default(lesscssParser.additiveExpression_return);

        lesscssParser.value_return value26 = default(lesscssParser.value_return);


        CommonTree char_literal23_tree=null;
        CommonTree char_literal25_tree=null;

        try 
    	{
            // D:\\development\\Less.Net\\lesscss.g:65:2: ( '(' additiveExpression ')' | value )
            int alt7 = 2;
            int LA7_0 = input.LA(1);

            if ( (LA7_0 == 34) )
            {
                alt7 = 1;
            }
            else if ( (LA7_0 == COLOR || LA7_0 == NUM || LA7_0 == 26) )
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
                    // D:\\development\\Less.Net\\lesscss.g:65:4: '(' additiveExpression ')'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal23=(IToken)Match(input,34,FOLLOW_34_in_primaryExpression345); 
                    	PushFollow(FOLLOW_additiveExpression_in_primaryExpression348);
                    	additiveExpression24 = additiveExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, additiveExpression24.Tree);
                    	char_literal25=(IToken)Match(input,35,FOLLOW_35_in_primaryExpression350); 

                    }
                    break;
                case 2 :
                    // D:\\development\\Less.Net\\lesscss.g:66:4: value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_value_in_primaryExpression356);
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
    // D:\\development\\Less.Net\\lesscss.g:69:10: fragment value : ( varname -> ^( VAR varname ) | numeric -> ^( CONSTANT numeric ) );
    public lesscssParser.value_return value() // throws RecognitionException [1]
    {   
        lesscssParser.value_return retval = new lesscssParser.value_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.varname_return varname27 = default(lesscssParser.varname_return);

        lesscssParser.numeric_return numeric28 = default(lesscssParser.numeric_return);


        RewriteRuleSubtreeStream stream_numeric = new RewriteRuleSubtreeStream(adaptor,"rule numeric");
        RewriteRuleSubtreeStream stream_varname = new RewriteRuleSubtreeStream(adaptor,"rule varname");
        try 
    	{
            // D:\\development\\Less.Net\\lesscss.g:70:2: ( varname -> ^( VAR varname ) | numeric -> ^( CONSTANT numeric ) )
            int alt8 = 2;
            int LA8_0 = input.LA(1);

            if ( (LA8_0 == 26) )
            {
                alt8 = 1;
            }
            else if ( (LA8_0 == COLOR || LA8_0 == NUM) )
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
                    // D:\\development\\Less.Net\\lesscss.g:70:5: varname
                    {
                    	PushFollow(FOLLOW_varname_in_value372);
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
                    	// 70:13: -> ^( VAR varname )
                    	{
                    	    // D:\\development\\Less.Net\\lesscss.g:70:16: ^( VAR varname )
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
                    // D:\\development\\Less.Net\\lesscss.g:71:4: numeric
                    {
                    	PushFollow(FOLLOW_numeric_in_value385);
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
                    	// 71:12: -> ^( CONSTANT numeric )
                    	{
                    	    // D:\\development\\Less.Net\\lesscss.g:71:15: ^( CONSTANT numeric )
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
    // D:\\development\\Less.Net\\lesscss.g:74:10: fragment numeric : ( ( NUM ( UNIT )? ) | COLOR );
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
            // D:\\development\\Less.Net\\lesscss.g:75:2: ( ( NUM ( UNIT )? ) | COLOR )
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
                    // D:\\development\\Less.Net\\lesscss.g:75:4: ( NUM ( UNIT )? )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// D:\\development\\Less.Net\\lesscss.g:75:4: ( NUM ( UNIT )? )
                    	// D:\\development\\Less.Net\\lesscss.g:75:5: NUM ( UNIT )?
                    	{
                    		NUM29=(IToken)Match(input,NUM,FOLLOW_NUM_in_numeric408); 
                    			NUM29_tree = (CommonTree)adaptor.Create(NUM29);
                    			adaptor.AddChild(root_0, NUM29_tree);

                    		// D:\\development\\Less.Net\\lesscss.g:75:9: ( UNIT )?
                    		int alt9 = 2;
                    		int LA9_0 = input.LA(1);

                    		if ( (LA9_0 == UNIT) )
                    		{
                    		    alt9 = 1;
                    		}
                    		switch (alt9) 
                    		{
                    		    case 1 :
                    		        // D:\\development\\Less.Net\\lesscss.g:75:9: UNIT
                    		        {
                    		        	UNIT30=(IToken)Match(input,UNIT,FOLLOW_UNIT_in_numeric410); 
                    		        		UNIT30_tree = (CommonTree)adaptor.Create(UNIT30);
                    		        		adaptor.AddChild(root_0, UNIT30_tree);


                    		        }
                    		        break;

                    		}


                    	}


                    }
                    break;
                case 2 :
                    // D:\\development\\Less.Net\\lesscss.g:75:18: COLOR
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	COLOR31=(IToken)Match(input,COLOR,FOLLOW_COLOR_in_numeric416); 
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
    // D:\\development\\Less.Net\\lesscss.g:78:10: fragment mediadefinition : ( '@media' media '{' lessCss '}' ) ;
    public lesscssParser.mediadefinition_return mediadefinition() // throws RecognitionException [1]
    {   
        lesscssParser.mediadefinition_return retval = new lesscssParser.mediadefinition_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal32 = null;
        IToken char_literal34 = null;
        IToken char_literal36 = null;
        lesscssParser.media_return media33 = default(lesscssParser.media_return);

        lesscssParser.lessCss_return lessCss35 = default(lesscssParser.lessCss_return);


        CommonTree string_literal32_tree=null;
        CommonTree char_literal34_tree=null;
        CommonTree char_literal36_tree=null;

        try 
    	{
            // D:\\development\\Less.Net\\lesscss.g:79:2: ( ( '@media' media '{' lessCss '}' ) )
            // D:\\development\\Less.Net\\lesscss.g:79:4: ( '@media' media '{' lessCss '}' )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// D:\\development\\Less.Net\\lesscss.g:79:4: ( '@media' media '{' lessCss '}' )
            	// D:\\development\\Less.Net\\lesscss.g:79:5: '@media' media '{' lessCss '}'
            	{
            		string_literal32=(IToken)Match(input,36,FOLLOW_36_in_mediadefinition431); 
            			string_literal32_tree = (CommonTree)adaptor.Create(string_literal32);
            			adaptor.AddChild(root_0, string_literal32_tree);

            		PushFollow(FOLLOW_media_in_mediadefinition433);
            		media33 = media();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, media33.Tree);
            		char_literal34=(IToken)Match(input,37,FOLLOW_37_in_mediadefinition435); 
            			char_literal34_tree = (CommonTree)adaptor.Create(char_literal34);
            			adaptor.AddChild(root_0, char_literal34_tree);

            		PushFollow(FOLLOW_lessCss_in_mediadefinition437);
            		lessCss35 = lessCss();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, lessCss35.Tree);
            		char_literal36=(IToken)Match(input,38,FOLLOW_38_in_mediadefinition439); 
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
    // D:\\development\\Less.Net\\lesscss.g:81:10: fragment ruleset : selectors '{' ( ruleContents )* '}' -> ^( RULE selectors ( ruleContents )* ) ;
    public lesscssParser.ruleset_return ruleset() // throws RecognitionException [1]
    {   
        lesscssParser.ruleset_return retval = new lesscssParser.ruleset_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal38 = null;
        IToken char_literal40 = null;
        lesscssParser.selectors_return selectors37 = default(lesscssParser.selectors_return);

        lesscssParser.ruleContents_return ruleContents39 = default(lesscssParser.ruleContents_return);


        CommonTree char_literal38_tree=null;
        CommonTree char_literal40_tree=null;
        RewriteRuleTokenStream stream_37 = new RewriteRuleTokenStream(adaptor,"token 37");
        RewriteRuleTokenStream stream_38 = new RewriteRuleTokenStream(adaptor,"token 38");
        RewriteRuleSubtreeStream stream_ruleContents = new RewriteRuleSubtreeStream(adaptor,"rule ruleContents");
        RewriteRuleSubtreeStream stream_selectors = new RewriteRuleSubtreeStream(adaptor,"rule selectors");
        try 
    	{
            // D:\\development\\Less.Net\\lesscss.g:82:2: ( selectors '{' ( ruleContents )* '}' -> ^( RULE selectors ( ruleContents )* ) )
            // D:\\development\\Less.Net\\lesscss.g:82:4: selectors '{' ( ruleContents )* '}'
            {
            	PushFollow(FOLLOW_selectors_in_ruleset454);
            	selectors37 = selectors();
            	state.followingStackPointer--;

            	stream_selectors.Add(selectors37.Tree);
            	char_literal38=(IToken)Match(input,37,FOLLOW_37_in_ruleset456);  
            	stream_37.Add(char_literal38);

            	// D:\\development\\Less.Net\\lesscss.g:82:18: ( ruleContents )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == IDENT || (LA11_0 >= 49 && LA11_0 <= 50)) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // D:\\development\\Less.Net\\lesscss.g:82:18: ruleContents
            			    {
            			    	PushFollow(FOLLOW_ruleContents_in_ruleset458);
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

            	char_literal40=(IToken)Match(input,38,FOLLOW_38_in_ruleset461);  
            	stream_38.Add(char_literal40);



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
            	// 82:36: -> ^( RULE selectors ( ruleContents )* )
            	{
            	    // D:\\development\\Less.Net\\lesscss.g:82:39: ^( RULE selectors ( ruleContents )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(RULE, "RULE"), root_1);

            	    adaptor.AddChild(root_1, stream_selectors.NextTree());
            	    // D:\\development\\Less.Net\\lesscss.g:82:56: ( ruleContents )*
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
    // D:\\development\\Less.Net\\lesscss.g:85:10: fragment ruleContents : ( property | mixin | ruleset );
    public lesscssParser.ruleContents_return ruleContents() // throws RecognitionException [1]
    {   
        lesscssParser.ruleContents_return retval = new lesscssParser.ruleContents_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.property_return property41 = default(lesscssParser.property_return);

        lesscssParser.mixin_return mixin42 = default(lesscssParser.mixin_return);

        lesscssParser.ruleset_return ruleset43 = default(lesscssParser.ruleset_return);



        try 
    	{
            // D:\\development\\Less.Net\\lesscss.g:86:2: ( property | mixin | ruleset )
            int alt12 = 3;
            alt12 = dfa12.Predict(input);
            switch (alt12) 
            {
                case 1 :
                    // D:\\development\\Less.Net\\lesscss.g:86:4: property
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_property_in_ruleContents486);
                    	property41 = property();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, property41.Tree);

                    }
                    break;
                case 2 :
                    // D:\\development\\Less.Net\\lesscss.g:86:15: mixin
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_mixin_in_ruleContents490);
                    	mixin42 = mixin();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, mixin42.Tree);

                    }
                    break;
                case 3 :
                    // D:\\development\\Less.Net\\lesscss.g:86:23: ruleset
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ruleset_in_ruleContents494);
                    	ruleset43 = ruleset();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ruleset43.Tree);

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

    public class mixin_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "mixin"
    // D:\\development\\Less.Net\\lesscss.g:88:10: fragment mixin : selectors ';' -> MIXIN selectors ;
    public lesscssParser.mixin_return mixin() // throws RecognitionException [1]
    {   
        lesscssParser.mixin_return retval = new lesscssParser.mixin_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal45 = null;
        lesscssParser.selectors_return selectors44 = default(lesscssParser.selectors_return);


        CommonTree char_literal45_tree=null;
        RewriteRuleTokenStream stream_28 = new RewriteRuleTokenStream(adaptor,"token 28");
        RewriteRuleSubtreeStream stream_selectors = new RewriteRuleSubtreeStream(adaptor,"rule selectors");
        try 
    	{
            // D:\\development\\Less.Net\\lesscss.g:89:2: ( selectors ';' -> MIXIN selectors )
            // D:\\development\\Less.Net\\lesscss.g:89:4: selectors ';'
            {
            	PushFollow(FOLLOW_selectors_in_mixin505);
            	selectors44 = selectors();
            	state.followingStackPointer--;

            	stream_selectors.Add(selectors44.Tree);
            	char_literal45=(IToken)Match(input,28,FOLLOW_28_in_mixin507);  
            	stream_28.Add(char_literal45);



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
            	// 89:18: -> MIXIN selectors
            	{
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(MIXIN, "MIXIN"));
            	    adaptor.AddChild(root_0, stream_selectors.NextTree());

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
    // $ANTLR end "mixin"

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
    // D:\\development\\Less.Net\\lesscss.g:91:10: fragment media : ( 'all' | 'braille' | 'embossed' | 'handheld' | 'print' | 'projection' | 'screen' | 'speech' | 'tty' | 'tv' );
    public lesscssParser.media_return media() // throws RecognitionException [1]
    {   
        lesscssParser.media_return retval = new lesscssParser.media_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set46 = null;

        CommonTree set46_tree=null;

        try 
    	{
            // D:\\development\\Less.Net\\lesscss.g:91:17: ( 'all' | 'braille' | 'embossed' | 'handheld' | 'print' | 'projection' | 'screen' | 'speech' | 'tty' | 'tv' )
            // D:\\development\\Less.Net\\lesscss.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set46 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 39 && input.LA(1) <= 48) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set46));
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
    // D:\\development\\Less.Net\\lesscss.g:93:10: fragment selectors : selectorGrouping ( ',' selectorGrouping )* -> ( selectorGrouping )+ ;
    public lesscssParser.selectors_return selectors() // throws RecognitionException [1]
    {   
        lesscssParser.selectors_return retval = new lesscssParser.selectors_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal48 = null;
        lesscssParser.selectorGrouping_return selectorGrouping47 = default(lesscssParser.selectorGrouping_return);

        lesscssParser.selectorGrouping_return selectorGrouping49 = default(lesscssParser.selectorGrouping_return);


        CommonTree char_literal48_tree=null;
        RewriteRuleTokenStream stream_29 = new RewriteRuleTokenStream(adaptor,"token 29");
        RewriteRuleSubtreeStream stream_selectorGrouping = new RewriteRuleSubtreeStream(adaptor,"rule selectorGrouping");
        try 
    	{
            // D:\\development\\Less.Net\\lesscss.g:94:2: ( selectorGrouping ( ',' selectorGrouping )* -> ( selectorGrouping )+ )
            // D:\\development\\Less.Net\\lesscss.g:94:4: selectorGrouping ( ',' selectorGrouping )*
            {
            	PushFollow(FOLLOW_selectorGrouping_in_selectors554);
            	selectorGrouping47 = selectorGrouping();
            	state.followingStackPointer--;

            	stream_selectorGrouping.Add(selectorGrouping47.Tree);
            	// D:\\development\\Less.Net\\lesscss.g:94:21: ( ',' selectorGrouping )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( (LA13_0 == 29) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // D:\\development\\Less.Net\\lesscss.g:94:22: ',' selectorGrouping
            			    {
            			    	char_literal48=(IToken)Match(input,29,FOLLOW_29_in_selectors557);  
            			    	stream_29.Add(char_literal48);

            			    	PushFollow(FOLLOW_selectorGrouping_in_selectors559);
            			    	selectorGrouping49 = selectorGrouping();
            			    	state.followingStackPointer--;

            			    	stream_selectorGrouping.Add(selectorGrouping49.Tree);

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
            	// 94:45: -> ( selectorGrouping )+
            	{
            	    if ( !(stream_selectorGrouping.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_selectorGrouping.HasNext() )
            	    {
            	        adaptor.AddChild(root_0, stream_selectorGrouping.NextTree());

            	    }
            	    stream_selectorGrouping.Reset();

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
    // D:\\development\\Less.Net\\lesscss.g:97:10: fragment selectorGrouping : ( selector )+ -> ^( SELECTOR ( selector )+ ) ;
    public lesscssParser.selectorGrouping_return selectorGrouping() // throws RecognitionException [1]
    {   
        lesscssParser.selectorGrouping_return retval = new lesscssParser.selectorGrouping_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.selector_return selector50 = default(lesscssParser.selector_return);


        RewriteRuleSubtreeStream stream_selector = new RewriteRuleSubtreeStream(adaptor,"rule selector");
        try 
    	{
            // D:\\development\\Less.Net\\lesscss.g:98:2: ( ( selector )+ -> ^( SELECTOR ( selector )+ ) )
            // D:\\development\\Less.Net\\lesscss.g:98:4: ( selector )+
            {
            	// D:\\development\\Less.Net\\lesscss.g:98:4: ( selector )+
            	int cnt14 = 0;
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == IDENT || (LA14_0 >= 49 && LA14_0 <= 50)) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // D:\\development\\Less.Net\\lesscss.g:98:4: selector
            			    {
            			    	PushFollow(FOLLOW_selector_in_selectorGrouping580);
            			    	selector50 = selector();
            			    	state.followingStackPointer--;

            			    	stream_selector.Add(selector50.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt14 >= 1 ) goto loop14;
            		            EarlyExitException eee14 =
            		                new EarlyExitException(14, input);
            		            throw eee14;
            	    }
            	    cnt14++;
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whinging that label 'loop14' has no statements



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
            	// 98:14: -> ^( SELECTOR ( selector )+ )
            	{
            	    // D:\\development\\Less.Net\\lesscss.g:98:17: ^( SELECTOR ( selector )+ )
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
    // D:\\development\\Less.Net\\lesscss.g:102:10: fragment property : IDENT ':' ( propval )+ ';' -> ^( PROPERTY IDENT ( propval )+ ) ;
    public lesscssParser.property_return property() // throws RecognitionException [1]
    {   
        lesscssParser.property_return retval = new lesscssParser.property_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken IDENT51 = null;
        IToken char_literal52 = null;
        IToken char_literal54 = null;
        lesscssParser.propval_return propval53 = default(lesscssParser.propval_return);


        CommonTree IDENT51_tree=null;
        CommonTree char_literal52_tree=null;
        CommonTree char_literal54_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_27 = new RewriteRuleTokenStream(adaptor,"token 27");
        RewriteRuleTokenStream stream_28 = new RewriteRuleTokenStream(adaptor,"token 28");
        RewriteRuleSubtreeStream stream_propval = new RewriteRuleSubtreeStream(adaptor,"rule propval");
        try 
    	{
            // D:\\development\\Less.Net\\lesscss.g:103:2: ( IDENT ':' ( propval )+ ';' -> ^( PROPERTY IDENT ( propval )+ ) )
            // D:\\development\\Less.Net\\lesscss.g:103:4: IDENT ':' ( propval )+ ';'
            {
            	IDENT51=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_property605);  
            	stream_IDENT.Add(IDENT51);

            	char_literal52=(IToken)Match(input,27,FOLLOW_27_in_property607);  
            	stream_27.Add(char_literal52);

            	// D:\\development\\Less.Net\\lesscss.g:103:14: ( propval )+
            	int cnt15 = 0;
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( ((LA15_0 >= COLOR && LA15_0 <= NUM) || LA15_0 == 26 || LA15_0 == 34) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // D:\\development\\Less.Net\\lesscss.g:103:14: propval
            			    {
            			    	PushFollow(FOLLOW_propval_in_property609);
            			    	propval53 = propval();
            			    	state.followingStackPointer--;

            			    	stream_propval.Add(propval53.Tree);

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

            	char_literal54=(IToken)Match(input,28,FOLLOW_28_in_property612);  
            	stream_28.Add(char_literal54);



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
            	// 103:27: -> ^( PROPERTY IDENT ( propval )+ )
            	{
            	    // D:\\development\\Less.Net\\lesscss.g:103:30: ^( PROPERTY IDENT ( propval )+ )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PROPERTY, "PROPERTY"), root_1);

            	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
            	    if ( !(stream_propval.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_propval.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_propval.NextTree());

            	    }
            	    stream_propval.Reset();

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
    // D:\\development\\Less.Net\\lesscss.g:106:10: fragment propval : ( literal | additiveExpression -> ^( EXPR additiveExpression ) );
    public lesscssParser.propval_return propval() // throws RecognitionException [1]
    {   
        lesscssParser.propval_return retval = new lesscssParser.propval_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        lesscssParser.literal_return literal55 = default(lesscssParser.literal_return);

        lesscssParser.additiveExpression_return additiveExpression56 = default(lesscssParser.additiveExpression_return);


        RewriteRuleSubtreeStream stream_additiveExpression = new RewriteRuleSubtreeStream(adaptor,"rule additiveExpression");
        try 
    	{
            // D:\\development\\Less.Net\\lesscss.g:107:2: ( literal | additiveExpression -> ^( EXPR additiveExpression ) )
            int alt16 = 2;
            int LA16_0 = input.LA(1);

            if ( ((LA16_0 >= IDENT && LA16_0 <= STRING)) )
            {
                alt16 = 1;
            }
            else if ( (LA16_0 == COLOR || LA16_0 == NUM || LA16_0 == 26 || LA16_0 == 34) )
            {
                alt16 = 2;
            }
            else 
            {
                NoViableAltException nvae_d16s0 =
                    new NoViableAltException("", 16, 0, input);

                throw nvae_d16s0;
            }
            switch (alt16) 
            {
                case 1 :
                    // D:\\development\\Less.Net\\lesscss.g:107:4: literal
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_literal_in_propval636);
                    	literal55 = literal();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, literal55.Tree);

                    }
                    break;
                case 2 :
                    // D:\\development\\Less.Net\\lesscss.g:107:14: additiveExpression
                    {
                    	PushFollow(FOLLOW_additiveExpression_in_propval640);
                    	additiveExpression56 = additiveExpression();
                    	state.followingStackPointer--;

                    	stream_additiveExpression.Add(additiveExpression56.Tree);


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
                    	// 107:33: -> ^( EXPR additiveExpression )
                    	{
                    	    // D:\\development\\Less.Net\\lesscss.g:107:36: ^( EXPR additiveExpression )
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
    // D:\\development\\Less.Net\\lesscss.g:109:10: fragment selector : ( IDENT -> ^( TAG IDENT ) | '#' IDENT -> ^( ID IDENT ) | '.' IDENT -> ^( CLASS IDENT ) );
    public lesscssParser.selector_return selector() // throws RecognitionException [1]
    {   
        lesscssParser.selector_return retval = new lesscssParser.selector_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken IDENT57 = null;
        IToken char_literal58 = null;
        IToken IDENT59 = null;
        IToken char_literal60 = null;
        IToken IDENT61 = null;

        CommonTree IDENT57_tree=null;
        CommonTree char_literal58_tree=null;
        CommonTree IDENT59_tree=null;
        CommonTree char_literal60_tree=null;
        CommonTree IDENT61_tree=null;
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");

        try 
    	{
            // D:\\development\\Less.Net\\lesscss.g:110:2: ( IDENT -> ^( TAG IDENT ) | '#' IDENT -> ^( ID IDENT ) | '.' IDENT -> ^( CLASS IDENT ) )
            int alt17 = 3;
            switch ( input.LA(1) ) 
            {
            case IDENT:
            	{
                alt17 = 1;
                }
                break;
            case 49:
            	{
                alt17 = 2;
                }
                break;
            case 50:
            	{
                alt17 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d17s0 =
            	        new NoViableAltException("", 17, 0, input);

            	    throw nvae_d17s0;
            }

            switch (alt17) 
            {
                case 1 :
                    // D:\\development\\Less.Net\\lesscss.g:110:4: IDENT
                    {
                    	IDENT57=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_selector660);  
                    	stream_IDENT.Add(IDENT57);



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
                    	// 110:10: -> ^( TAG IDENT )
                    	{
                    	    // D:\\development\\Less.Net\\lesscss.g:110:13: ^( TAG IDENT )
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
                    // D:\\development\\Less.Net\\lesscss.g:110:28: '#' IDENT
                    {
                    	char_literal58=(IToken)Match(input,49,FOLLOW_49_in_selector672);  
                    	stream_49.Add(char_literal58);

                    	IDENT59=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_selector674);  
                    	stream_IDENT.Add(IDENT59);



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
                    	// 110:38: -> ^( ID IDENT )
                    	{
                    	    // D:\\development\\Less.Net\\lesscss.g:110:41: ^( ID IDENT )
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
                    // D:\\development\\Less.Net\\lesscss.g:110:55: '.' IDENT
                    {
                    	char_literal60=(IToken)Match(input,50,FOLLOW_50_in_selector686);  
                    	stream_50.Add(char_literal60);

                    	IDENT61=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_selector688);  
                    	stream_IDENT.Add(IDENT61);



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
                    	// 110:65: -> ^( CLASS IDENT )
                    	{
                    	    // D:\\development\\Less.Net\\lesscss.g:110:68: ^( CLASS IDENT )
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
    // $ANTLR end "selector"

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
    // D:\\development\\Less.Net\\lesscss.g:113:10: fragment val : ( IDENT '(' ( STRING | ( NUM ( UNIT )? ) ) ( ',' ( STRING | ( NUM ( UNIT )? ) ) )* ')' | IDENT | STRING | ( NUM ( UNIT )? ) | COLOR );
    public lesscssParser.val_return val() // throws RecognitionException [1]
    {   
        lesscssParser.val_return retval = new lesscssParser.val_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken IDENT62 = null;
        IToken char_literal63 = null;
        IToken STRING64 = null;
        IToken NUM65 = null;
        IToken UNIT66 = null;
        IToken char_literal67 = null;
        IToken STRING68 = null;
        IToken NUM69 = null;
        IToken UNIT70 = null;
        IToken char_literal71 = null;
        IToken IDENT72 = null;
        IToken STRING73 = null;
        IToken NUM74 = null;
        IToken UNIT75 = null;
        IToken COLOR76 = null;

        CommonTree IDENT62_tree=null;
        CommonTree char_literal63_tree=null;
        CommonTree STRING64_tree=null;
        CommonTree NUM65_tree=null;
        CommonTree UNIT66_tree=null;
        CommonTree char_literal67_tree=null;
        CommonTree STRING68_tree=null;
        CommonTree NUM69_tree=null;
        CommonTree UNIT70_tree=null;
        CommonTree char_literal71_tree=null;
        CommonTree IDENT72_tree=null;
        CommonTree STRING73_tree=null;
        CommonTree NUM74_tree=null;
        CommonTree UNIT75_tree=null;
        CommonTree COLOR76_tree=null;

        try 
    	{
            // D:\\development\\Less.Net\\lesscss.g:114:2: ( IDENT '(' ( STRING | ( NUM ( UNIT )? ) ) ( ',' ( STRING | ( NUM ( UNIT )? ) ) )* ')' | IDENT | STRING | ( NUM ( UNIT )? ) | COLOR )
            int alt24 = 5;
            switch ( input.LA(1) ) 
            {
            case IDENT:
            	{
                int LA24_1 = input.LA(2);

                if ( (LA24_1 == 34) )
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
                    // D:\\development\\Less.Net\\lesscss.g:114:4: IDENT '(' ( STRING | ( NUM ( UNIT )? ) ) ( ',' ( STRING | ( NUM ( UNIT )? ) ) )* ')'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	IDENT62=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_val712); 
                    		IDENT62_tree = (CommonTree)adaptor.Create(IDENT62);
                    		adaptor.AddChild(root_0, IDENT62_tree);

                    	char_literal63=(IToken)Match(input,34,FOLLOW_34_in_val714); 
                    		char_literal63_tree = (CommonTree)adaptor.Create(char_literal63);
                    		adaptor.AddChild(root_0, char_literal63_tree);

                    	// D:\\development\\Less.Net\\lesscss.g:114:14: ( STRING | ( NUM ( UNIT )? ) )
                    	int alt19 = 2;
                    	int LA19_0 = input.LA(1);

                    	if ( (LA19_0 == STRING) )
                    	{
                    	    alt19 = 1;
                    	}
                    	else if ( (LA19_0 == NUM) )
                    	{
                    	    alt19 = 2;
                    	}
                    	else 
                    	{
                    	    NoViableAltException nvae_d19s0 =
                    	        new NoViableAltException("", 19, 0, input);

                    	    throw nvae_d19s0;
                    	}
                    	switch (alt19) 
                    	{
                    	    case 1 :
                    	        // D:\\development\\Less.Net\\lesscss.g:114:15: STRING
                    	        {
                    	        	STRING64=(IToken)Match(input,STRING,FOLLOW_STRING_in_val717); 
                    	        		STRING64_tree = (CommonTree)adaptor.Create(STRING64);
                    	        		adaptor.AddChild(root_0, STRING64_tree);


                    	        }
                    	        break;
                    	    case 2 :
                    	        // D:\\development\\Less.Net\\lesscss.g:114:24: ( NUM ( UNIT )? )
                    	        {
                    	        	// D:\\development\\Less.Net\\lesscss.g:114:24: ( NUM ( UNIT )? )
                    	        	// D:\\development\\Less.Net\\lesscss.g:114:25: NUM ( UNIT )?
                    	        	{
                    	        		NUM65=(IToken)Match(input,NUM,FOLLOW_NUM_in_val722); 
                    	        			NUM65_tree = (CommonTree)adaptor.Create(NUM65);
                    	        			adaptor.AddChild(root_0, NUM65_tree);

                    	        		// D:\\development\\Less.Net\\lesscss.g:114:29: ( UNIT )?
                    	        		int alt18 = 2;
                    	        		int LA18_0 = input.LA(1);

                    	        		if ( (LA18_0 == UNIT) )
                    	        		{
                    	        		    alt18 = 1;
                    	        		}
                    	        		switch (alt18) 
                    	        		{
                    	        		    case 1 :
                    	        		        // D:\\development\\Less.Net\\lesscss.g:114:29: UNIT
                    	        		        {
                    	        		        	UNIT66=(IToken)Match(input,UNIT,FOLLOW_UNIT_in_val724); 
                    	        		        		UNIT66_tree = (CommonTree)adaptor.Create(UNIT66);
                    	        		        		adaptor.AddChild(root_0, UNIT66_tree);


                    	        		        }
                    	        		        break;

                    	        		}


                    	        	}


                    	        }
                    	        break;

                    	}

                    	// D:\\development\\Less.Net\\lesscss.g:114:37: ( ',' ( STRING | ( NUM ( UNIT )? ) ) )*
                    	do 
                    	{
                    	    int alt22 = 2;
                    	    int LA22_0 = input.LA(1);

                    	    if ( (LA22_0 == 29) )
                    	    {
                    	        alt22 = 1;
                    	    }


                    	    switch (alt22) 
                    		{
                    			case 1 :
                    			    // D:\\development\\Less.Net\\lesscss.g:114:38: ',' ( STRING | ( NUM ( UNIT )? ) )
                    			    {
                    			    	char_literal67=(IToken)Match(input,29,FOLLOW_29_in_val730); 
                    			    		char_literal67_tree = (CommonTree)adaptor.Create(char_literal67);
                    			    		adaptor.AddChild(root_0, char_literal67_tree);

                    			    	// D:\\development\\Less.Net\\lesscss.g:114:42: ( STRING | ( NUM ( UNIT )? ) )
                    			    	int alt21 = 2;
                    			    	int LA21_0 = input.LA(1);

                    			    	if ( (LA21_0 == STRING) )
                    			    	{
                    			    	    alt21 = 1;
                    			    	}
                    			    	else if ( (LA21_0 == NUM) )
                    			    	{
                    			    	    alt21 = 2;
                    			    	}
                    			    	else 
                    			    	{
                    			    	    NoViableAltException nvae_d21s0 =
                    			    	        new NoViableAltException("", 21, 0, input);

                    			    	    throw nvae_d21s0;
                    			    	}
                    			    	switch (alt21) 
                    			    	{
                    			    	    case 1 :
                    			    	        // D:\\development\\Less.Net\\lesscss.g:114:43: STRING
                    			    	        {
                    			    	        	STRING68=(IToken)Match(input,STRING,FOLLOW_STRING_in_val733); 
                    			    	        		STRING68_tree = (CommonTree)adaptor.Create(STRING68);
                    			    	        		adaptor.AddChild(root_0, STRING68_tree);


                    			    	        }
                    			    	        break;
                    			    	    case 2 :
                    			    	        // D:\\development\\Less.Net\\lesscss.g:114:50: ( NUM ( UNIT )? )
                    			    	        {
                    			    	        	// D:\\development\\Less.Net\\lesscss.g:114:50: ( NUM ( UNIT )? )
                    			    	        	// D:\\development\\Less.Net\\lesscss.g:114:51: NUM ( UNIT )?
                    			    	        	{
                    			    	        		NUM69=(IToken)Match(input,NUM,FOLLOW_NUM_in_val736); 
                    			    	        			NUM69_tree = (CommonTree)adaptor.Create(NUM69);
                    			    	        			adaptor.AddChild(root_0, NUM69_tree);

                    			    	        		// D:\\development\\Less.Net\\lesscss.g:114:55: ( UNIT )?
                    			    	        		int alt20 = 2;
                    			    	        		int LA20_0 = input.LA(1);

                    			    	        		if ( (LA20_0 == UNIT) )
                    			    	        		{
                    			    	        		    alt20 = 1;
                    			    	        		}
                    			    	        		switch (alt20) 
                    			    	        		{
                    			    	        		    case 1 :
                    			    	        		        // D:\\development\\Less.Net\\lesscss.g:114:55: UNIT
                    			    	        		        {
                    			    	        		        	UNIT70=(IToken)Match(input,UNIT,FOLLOW_UNIT_in_val738); 
                    			    	        		        		UNIT70_tree = (CommonTree)adaptor.Create(UNIT70);
                    			    	        		        		adaptor.AddChild(root_0, UNIT70_tree);


                    			    	        		        }
                    			    	        		        break;

                    			    	        		}


                    			    	        	}


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

                    	char_literal71=(IToken)Match(input,35,FOLLOW_35_in_val745); 
                    		char_literal71_tree = (CommonTree)adaptor.Create(char_literal71);
                    		adaptor.AddChild(root_0, char_literal71_tree);


                    }
                    break;
                case 2 :
                    // D:\\development\\Less.Net\\lesscss.g:115:4: IDENT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	IDENT72=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_val750); 
                    		IDENT72_tree = (CommonTree)adaptor.Create(IDENT72);
                    		adaptor.AddChild(root_0, IDENT72_tree);


                    }
                    break;
                case 3 :
                    // D:\\development\\Less.Net\\lesscss.g:116:4: STRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	STRING73=(IToken)Match(input,STRING,FOLLOW_STRING_in_val755); 
                    		STRING73_tree = (CommonTree)adaptor.Create(STRING73);
                    		adaptor.AddChild(root_0, STRING73_tree);


                    }
                    break;
                case 4 :
                    // D:\\development\\Less.Net\\lesscss.g:117:4: ( NUM ( UNIT )? )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// D:\\development\\Less.Net\\lesscss.g:117:4: ( NUM ( UNIT )? )
                    	// D:\\development\\Less.Net\\lesscss.g:117:5: NUM ( UNIT )?
                    	{
                    		NUM74=(IToken)Match(input,NUM,FOLLOW_NUM_in_val761); 
                    			NUM74_tree = (CommonTree)adaptor.Create(NUM74);
                    			adaptor.AddChild(root_0, NUM74_tree);

                    		// D:\\development\\Less.Net\\lesscss.g:117:9: ( UNIT )?
                    		int alt23 = 2;
                    		int LA23_0 = input.LA(1);

                    		if ( (LA23_0 == UNIT) )
                    		{
                    		    alt23 = 1;
                    		}
                    		switch (alt23) 
                    		{
                    		    case 1 :
                    		        // D:\\development\\Less.Net\\lesscss.g:117:9: UNIT
                    		        {
                    		        	UNIT75=(IToken)Match(input,UNIT,FOLLOW_UNIT_in_val763); 
                    		        		UNIT75_tree = (CommonTree)adaptor.Create(UNIT75);
                    		        		adaptor.AddChild(root_0, UNIT75_tree);


                    		        }
                    		        break;

                    		}


                    	}


                    }
                    break;
                case 5 :
                    // D:\\development\\Less.Net\\lesscss.g:118:4: COLOR
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	COLOR76=(IToken)Match(input,COLOR,FOLLOW_COLOR_in_val770); 
                    		COLOR76_tree = (CommonTree)adaptor.Create(COLOR76);
                    		adaptor.AddChild(root_0, COLOR76_tree);


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
        "\x10\uffff";
    const string DFA12_eofS =
        "\x10\uffff";
    const string DFA12_minS =
        "\x04\x13\x01\uffff\x01\x13\x01\uffff\x01\x13\x01\uffff\x07\x13";
    const string DFA12_maxS =
        "\x02\x32\x02\x13\x01\uffff\x01\x32\x01\uffff\x01\x32\x01\uffff"+
        "\x03\x32\x02\x13\x02\x32";
    const string DFA12_acceptS =
        "\x04\uffff\x01\x01\x01\uffff\x01\x03\x01\uffff\x01\x02\x07\uffff";
    const string DFA12_specialS =
        "\x10\uffff}>";
    static readonly string[] DFA12_transitionS = {
            "\x01\x01\x1d\uffff\x01\x02\x01\x03",
            "\x01\x07\x07\uffff\x01\x04\x01\x08\x01\x05\x07\uffff\x01\x06"+
            "\x0b\uffff\x01\x02\x01\x03",
            "\x01\x09",
            "\x01\x0a",
            "",
            "\x01\x0b\x1d\uffff\x01\x0c\x01\x0d",
            "",
            "\x01\x07\x08\uffff\x01\x08\x01\x05\x07\uffff\x01\x06\x0b\uffff"+
            "\x01\x02\x01\x03",
            "",
            "\x01\x07\x08\uffff\x01\x08\x01\x05\x07\uffff\x01\x06\x0b\uffff"+
            "\x01\x02\x01\x03",
            "\x01\x07\x08\uffff\x01\x08\x01\x05\x07\uffff\x01\x06\x0b\uffff"+
            "\x01\x02\x01\x03",
            "\x01\x0b\x08\uffff\x01\x08\x01\x05\x07\uffff\x01\x06\x0b\uffff"+
            "\x01\x0c\x01\x0d",
            "\x01\x0e",
            "\x01\x0f",
            "\x01\x0b\x08\uffff\x01\x08\x01\x05\x07\uffff\x01\x06\x0b\uffff"+
            "\x01\x0c\x01\x0d",
            "\x01\x0b\x08\uffff\x01\x08\x01\x05\x07\uffff\x01\x06\x0b\uffff"+
            "\x01\x0c\x01\x0d"
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
            get { return "85:10: fragment ruleContents : ( property | mixin | ruleset );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_lessLine_in_lessCss101 = new BitSet(new ulong[]{0x0006001004080002UL});
    public static readonly BitSet FOLLOW_26_in_variable118 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_IDENT_in_variable120 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_variable122 = new BitSet(new ulong[]{0x00000004043C0000UL});
    public static readonly BitSet FOLLOW_literal_in_variable125 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_expression_in_variable143 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_variable156 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ruleset_in_lessLine172 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mediadefinition_in_lessLine182 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_lessLine192 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_literal214 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_29_in_literal223 = new BitSet(new ulong[]{0x0000000000180000UL});
    public static readonly BitSet FOLLOW_set_in_literal225 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_26_in_varname247 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_IDENT_in_varname249 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_expression268 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression291 = new BitSet(new ulong[]{0x00000000C0000002UL});
    public static readonly BitSet FOLLOW_set_in_additiveExpression295 = new BitSet(new ulong[]{0x00000004043C0000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression302 = new BitSet(new ulong[]{0x00000000C0000002UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_multiplicativeExpression319 = new BitSet(new ulong[]{0x0000000300000002UL});
    public static readonly BitSet FOLLOW_set_in_multiplicativeExpression323 = new BitSet(new ulong[]{0x00000004043C0000UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_multiplicativeExpression330 = new BitSet(new ulong[]{0x0000000300000002UL});
    public static readonly BitSet FOLLOW_34_in_primaryExpression345 = new BitSet(new ulong[]{0x00000004043C0000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_primaryExpression348 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_35_in_primaryExpression350 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_primaryExpression356 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varname_in_value372 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numeric_in_value385 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUM_in_numeric408 = new BitSet(new ulong[]{0x0000000000400002UL});
    public static readonly BitSet FOLLOW_UNIT_in_numeric410 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COLOR_in_numeric416 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_mediadefinition431 = new BitSet(new ulong[]{0x0001FF8000000000UL});
    public static readonly BitSet FOLLOW_media_in_mediadefinition433 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_37_in_mediadefinition435 = new BitSet(new ulong[]{0x0006001004080000UL});
    public static readonly BitSet FOLLOW_lessCss_in_mediadefinition437 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_38_in_mediadefinition439 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectors_in_ruleset454 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_37_in_ruleset456 = new BitSet(new ulong[]{0x0006004000080000UL});
    public static readonly BitSet FOLLOW_ruleContents_in_ruleset458 = new BitSet(new ulong[]{0x0006004000080000UL});
    public static readonly BitSet FOLLOW_38_in_ruleset461 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_property_in_ruleContents486 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mixin_in_ruleContents490 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ruleset_in_ruleContents494 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectors_in_mixin505 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_mixin507 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_media0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectorGrouping_in_selectors554 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_29_in_selectors557 = new BitSet(new ulong[]{0x0006000000080000UL});
    public static readonly BitSet FOLLOW_selectorGrouping_in_selectors559 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_selector_in_selectorGrouping580 = new BitSet(new ulong[]{0x0006000000080002UL});
    public static readonly BitSet FOLLOW_IDENT_in_property605 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_property607 = new BitSet(new ulong[]{0x00000004043C0000UL});
    public static readonly BitSet FOLLOW_propval_in_property609 = new BitSet(new ulong[]{0x00000004143C0000UL});
    public static readonly BitSet FOLLOW_28_in_property612 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_propval636 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_propval640 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_selector660 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_49_in_selector672 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_IDENT_in_selector674 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_selector686 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_IDENT_in_selector688 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_val712 = new BitSet(new ulong[]{0x0000000400000000UL});
    public static readonly BitSet FOLLOW_34_in_val714 = new BitSet(new ulong[]{0x0000000000300000UL});
    public static readonly BitSet FOLLOW_STRING_in_val717 = new BitSet(new ulong[]{0x0000000820000000UL});
    public static readonly BitSet FOLLOW_NUM_in_val722 = new BitSet(new ulong[]{0x0000000820400000UL});
    public static readonly BitSet FOLLOW_UNIT_in_val724 = new BitSet(new ulong[]{0x0000000820000000UL});
    public static readonly BitSet FOLLOW_29_in_val730 = new BitSet(new ulong[]{0x0000000000300000UL});
    public static readonly BitSet FOLLOW_STRING_in_val733 = new BitSet(new ulong[]{0x0000000820000000UL});
    public static readonly BitSet FOLLOW_NUM_in_val736 = new BitSet(new ulong[]{0x0000000820400000UL});
    public static readonly BitSet FOLLOW_UNIT_in_val738 = new BitSet(new ulong[]{0x0000000820000000UL});
    public static readonly BitSet FOLLOW_35_in_val745 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_val750 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_val755 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUM_in_val761 = new BitSet(new ulong[]{0x0000000000400002UL});
    public static readonly BitSet FOLLOW_UNIT_in_val763 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COLOR_in_val770 = new BitSet(new ulong[]{0x0000000000000002UL});

}
