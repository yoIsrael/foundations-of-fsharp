// Implementation file for parser generated by fsyacc 
#nowarn "64";; // turn off warnings that type variables used in production annotations are instantiated to concrete type
open Microsoft.FSharp.Tools.FsYacc.ParseHelpers
# 4 "pars.fsy"


open Strangelights.ExpressionParser.Ast


# 10000 "pars.fs"
type token = 
  | LPAREN
  | RPAREN
  | EOF
  | MULTI
  | DIV
  | PLUS
  | MINUS
  | FLOAT of (System.Double)
  | ID of (string)
let _fspars_tagof (t:token) = 
  match t with 
  | LPAREN  -> 0 
  | RPAREN  -> 1 
  | EOF  -> 2 
  | MULTI  -> 3 
  | DIV  -> 4 
  | PLUS  -> 5 
  | MINUS  -> 6 
  | FLOAT _ -> 7 
  | ID _ -> 8 
let _fspars_end_of_input_tag = 11 
let _fspars_tagof_error_term = 9
let _fspars_token_to_string (t:token) = 
  match t with 
  | LPAREN  -> "LPAREN" 
  | RPAREN  -> "RPAREN" 
  | EOF  -> "EOF" 
  | MULTI  -> "MULTI" 
  | DIV  -> "DIV" 
  | PLUS  -> "PLUS" 
  | MINUS  -> "MINUS" 
  | FLOAT _ -> "FLOAT" 
  | ID _ -> "ID" 
let _fspars_dataof (t:token) = 
  match t with 
  | LPAREN  -> (null : System.Object) 
  | RPAREN  -> (null : System.Object) 
  | EOF  -> (null : System.Object) 
  | MULTI  -> (null : System.Object) 
  | DIV  -> (null : System.Object) 
  | PLUS  -> (null : System.Object) 
  | MINUS  -> (null : System.Object) 
  | FLOAT _fspars_x -> Microsoft.FSharp.Core.Operators.box _fspars_x 
  | ID _fspars_x -> Microsoft.FSharp.Core.Operators.box _fspars_x 
let _fspars_gotos = "\000\000\255\255\000\006\255\255\000\000\000\001\000\004\000\005\000\011\000\007\000\012\000\008\000\013\000\009\000\014\000\010"B
let _fspars_gotos_row_offsets = "\000\000\000\001"B
let _fspars_action_rows = 15
let _fspars_action_table_elements = "\000\003\128\000\000\000\000\004\000\007\000\003\000\008\000\002\000\004\192\000\000\003\000\011\000\004\000\012\000\005\000\013\000\006\000\014\000\000\064\001\000\000\064\002\000\003\128\000\000\000\000\004\000\007\000\003\000\008\000\002\000\005\128\000\000\001\000\006\000\003\000\011\000\004\000\012\000\005\000\013\000\006\000\014\000\000\064\003\000\003\064\004\000\004\000\012\000\005\000\013\000\006\000\014\000\002\064\005\000\005\000\013\000\006\000\014\000\001\064\006\000\006\000\014\000\000\064\007\000\003\128\000\000\000\000\004\000\007\000\003\000\008\000\002\000\003\128\000\000\000\000\004\000\007\000\003\000\008\000\002\000\003\128\000\000\000\000\004\000\007\000\003\000\008\000\002\000\003\128\000\000\000\000\004\000\007\000\003\000\008\000\002"B
let _fspars_action_table_row_offsets = "\000\000\000\004\000\009\000\010\000\011\000\015\000\021\000\022\000\026\000\029\000\031\000\032\000\036\000\040\000\044"B
let _fspars_reduction_nsyms = "\000\001\000\001\000\001\000\003\000\003\000\003\000\003\000\003"B
let _fspars_nonterms = "\000\000\000\001\000\001\000\001\000\001\000\001\000\001\000\001"B
let _fspars_immediate_actions = "\255\255\255\255\064\001\064\002\255\255\255\255\064\003\255\255\255\255\255\255\255\255\255\255\255\255\255\255\255\255"B
let _fspars_reductions ()  = [| (fun (parseState : _ Microsoft.FSharp.Tools.FsYacc.IParseState) -> 

 let _1 = let data = parseState.GetData(1) in (Microsoft.FSharp.Core.Operators.unbox data :  Strangelights.ExpressionParser.Ast.Expr )in
Microsoft.FSharp.Core.Operators.box(
((raise (Microsoft.FSharp.Tools.FsYacc.AcceptException(Microsoft.FSharp.Core.Operators.box _1)))
 : '_startExpression) )); 
(fun (parseState : _ Microsoft.FSharp.Tools.FsYacc.IParseState) -> 

 let _1 = let data = parseState.GetData(1) in (Microsoft.FSharp.Core.Operators.unbox data : string)in
Microsoft.FSharp.Core.Operators.box(
# 23 "pars.fsy"
(( Ident(_1) )
 :  Strangelights.ExpressionParser.Ast.Expr ) )); 
(fun (parseState : _ Microsoft.FSharp.Tools.FsYacc.IParseState) -> 

 let _1 = let data = parseState.GetData(1) in (Microsoft.FSharp.Core.Operators.unbox data : System.Double)in
Microsoft.FSharp.Core.Operators.box(
# 24 "pars.fsy"
((  Val(_1)  )
 :  Strangelights.ExpressionParser.Ast.Expr ) )); 
(fun (parseState : _ Microsoft.FSharp.Tools.FsYacc.IParseState) -> 

 let _2 = let data = parseState.GetData(2) in (Microsoft.FSharp.Core.Operators.unbox data :  Strangelights.ExpressionParser.Ast.Expr )in
Microsoft.FSharp.Core.Operators.box(
# 25 "pars.fsy"
((  _2  )
 :  Strangelights.ExpressionParser.Ast.Expr ) )); 
(fun (parseState : _ Microsoft.FSharp.Tools.FsYacc.IParseState) -> 

 let _1 = let data = parseState.GetData(1) in (Microsoft.FSharp.Core.Operators.unbox data :  Strangelights.ExpressionParser.Ast.Expr )in
let _3 = let data = parseState.GetData(3) in (Microsoft.FSharp.Core.Operators.unbox data :  Strangelights.ExpressionParser.Ast.Expr )in
Microsoft.FSharp.Core.Operators.box(
# 26 "pars.fsy"
((  Multi(_1, _3)  )
 :  Strangelights.ExpressionParser.Ast.Expr ) )); 
(fun (parseState : _ Microsoft.FSharp.Tools.FsYacc.IParseState) -> 

 let _1 = let data = parseState.GetData(1) in (Microsoft.FSharp.Core.Operators.unbox data :  Strangelights.ExpressionParser.Ast.Expr )in
let _3 = let data = parseState.GetData(3) in (Microsoft.FSharp.Core.Operators.unbox data :  Strangelights.ExpressionParser.Ast.Expr )in
Microsoft.FSharp.Core.Operators.box(
# 27 "pars.fsy"
((  Div(_1, _3)  )
 :  Strangelights.ExpressionParser.Ast.Expr ) )); 
(fun (parseState : _ Microsoft.FSharp.Tools.FsYacc.IParseState) -> 

 let _1 = let data = parseState.GetData(1) in (Microsoft.FSharp.Core.Operators.unbox data :  Strangelights.ExpressionParser.Ast.Expr )in
let _3 = let data = parseState.GetData(3) in (Microsoft.FSharp.Core.Operators.unbox data :  Strangelights.ExpressionParser.Ast.Expr )in
Microsoft.FSharp.Core.Operators.box(
# 28 "pars.fsy"
((  Plus(_1, _3)  )
 :  Strangelights.ExpressionParser.Ast.Expr ) )); 
(fun (parseState : _ Microsoft.FSharp.Tools.FsYacc.IParseState) -> 

 let _1 = let data = parseState.GetData(1) in (Microsoft.FSharp.Core.Operators.unbox data :  Strangelights.ExpressionParser.Ast.Expr )in
let _3 = let data = parseState.GetData(3) in (Microsoft.FSharp.Core.Operators.unbox data :  Strangelights.ExpressionParser.Ast.Expr )in
Microsoft.FSharp.Core.Operators.box(
# 29 "pars.fsy"
((  Minus(_1, _3)  )
 :  Strangelights.ExpressionParser.Ast.Expr ) )); 
|]
# 20000 "pars.fs"
                                           
let tables () = 
{ new Microsoft.FSharp.Tools.FsYacc.Tables<_,_> 
with reductions= _fspars_reductions ();
and  end_of_input_tag = _fspars_end_of_input_tag;
and  tagof = _fspars_tagof;
and  dataof = _fspars_dataof; 
and  action_table_elements = _fspars_action_table_elements;
and  action_table_row_offsets = _fspars_action_table_row_offsets;
and  reduction_nsyms = _fspars_reduction_nsyms;
and  immediate_action = _fspars_immediate_actions;
and  gotos = _fspars_gotos;
and  gotos_row_offsets = _fspars_gotos_row_offsets;
and  tagof_error_term = _fspars_tagof_error_term;
and  parse_error = parse_error;
and  nonterms = _fspars_nonterms  }

let engine lexer lexbuf startState = (tables ()).Interpret(lexer, lexbuf, startState)
let token_to_string (t:token) = _fspars_token_to_string t
let Expression (lexer : Microsoft.FSharp.Tools.FsLex.LexBuffer<_,_> -> token) (lexbuf:  Microsoft.FSharp.Tools.FsLex.LexBuffer<_,_>) : ( Strangelights.ExpressionParser.Ast.Expr ) = 
(Microsoft.FSharp.Core.Operators.unbox (engine lexer lexbuf 0) :  Strangelights.ExpressionParser.Ast.Expr ) 
