// Implementation file for parser generated by fsyacc
module DalaParser
#nowarn "64";; // turn off warnings that type variables used in production annotations are instantiated to concrete type
open Microsoft.FSharp.Text.Lexing
open Microsoft.FSharp.Text.Parsing.ParseHelpers
# 1 "DalaParser.fsy"

open Dala

# 10 "DalaParser.fs"
// This type is the type of tokens accepted by the parser
type token = 
  | EOF
  | LET
  | BEGINSCOPE
  | ENDSCOPE
  | OPENBRACKET
  | CLOSINGBRACKET
  | ENDSTATEMENT
  | IF
  | RETURN
  | PLUS
  | MINUS
  | MULT
  | DIV
  | ASSIGN
  | EQ
  | NE
  | LT
  | GT
  | LTE
  | GTE
  | INT of (int)
  | ID of (string)
// This type is used to give symbolic names to token indexes, useful for error messages
type tokenId = 
    | TOKEN_EOF
    | TOKEN_LET
    | TOKEN_BEGINSCOPE
    | TOKEN_ENDSCOPE
    | TOKEN_OPENBRACKET
    | TOKEN_CLOSINGBRACKET
    | TOKEN_ENDSTATEMENT
    | TOKEN_IF
    | TOKEN_RETURN
    | TOKEN_PLUS
    | TOKEN_MINUS
    | TOKEN_MULT
    | TOKEN_DIV
    | TOKEN_ASSIGN
    | TOKEN_EQ
    | TOKEN_NE
    | TOKEN_LT
    | TOKEN_GT
    | TOKEN_LTE
    | TOKEN_GTE
    | TOKEN_INT
    | TOKEN_ID
    | TOKEN_end_of_input
    | TOKEN_error
// This type is used to give symbolic names to token indexes, useful for error messages
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start
    | NONTERM_statement_list
    | NONTERM_statement
    | NONTERM_expression
    | NONTERM_op

// This function maps tokens to integer indexes
let tagOfToken (t:token) = 
  match t with
  | EOF  -> 0 
  | LET  -> 1 
  | BEGINSCOPE  -> 2 
  | ENDSCOPE  -> 3 
  | OPENBRACKET  -> 4 
  | CLOSINGBRACKET  -> 5 
  | ENDSTATEMENT  -> 6 
  | IF  -> 7 
  | RETURN  -> 8 
  | PLUS  -> 9 
  | MINUS  -> 10 
  | MULT  -> 11 
  | DIV  -> 12 
  | ASSIGN  -> 13 
  | EQ  -> 14 
  | NE  -> 15 
  | LT  -> 16 
  | GT  -> 17 
  | LTE  -> 18 
  | GTE  -> 19 
  | INT _ -> 20 
  | ID _ -> 21 

// This function maps integer indexes to symbolic token ids
let tokenTagToTokenId (tokenIdx:int) = 
  match tokenIdx with
  | 0 -> TOKEN_EOF 
  | 1 -> TOKEN_LET 
  | 2 -> TOKEN_BEGINSCOPE 
  | 3 -> TOKEN_ENDSCOPE 
  | 4 -> TOKEN_OPENBRACKET 
  | 5 -> TOKEN_CLOSINGBRACKET 
  | 6 -> TOKEN_ENDSTATEMENT 
  | 7 -> TOKEN_IF 
  | 8 -> TOKEN_RETURN 
  | 9 -> TOKEN_PLUS 
  | 10 -> TOKEN_MINUS 
  | 11 -> TOKEN_MULT 
  | 12 -> TOKEN_DIV 
  | 13 -> TOKEN_ASSIGN 
  | 14 -> TOKEN_EQ 
  | 15 -> TOKEN_NE 
  | 16 -> TOKEN_LT 
  | 17 -> TOKEN_GT 
  | 18 -> TOKEN_LTE 
  | 19 -> TOKEN_GTE 
  | 20 -> TOKEN_INT 
  | 21 -> TOKEN_ID 
  | 24 -> TOKEN_end_of_input
  | 22 -> TOKEN_error
  | _ -> failwith "tokenTagToTokenId: bad token"

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
let prodIdxToNonTerminal (prodIdx:int) = 
  match prodIdx with
    | 0 -> NONTERM__startstart 
    | 1 -> NONTERM_start 
    | 2 -> NONTERM_statement_list 
    | 3 -> NONTERM_statement_list 
    | 4 -> NONTERM_statement 
    | 5 -> NONTERM_statement 
    | 6 -> NONTERM_statement 
    | 7 -> NONTERM_statement 
    | 8 -> NONTERM_statement 
    | 9 -> NONTERM_expression 
    | 10 -> NONTERM_expression 
    | 11 -> NONTERM_expression 
    | 12 -> NONTERM_expression 
    | 13 -> NONTERM_expression 
    | 14 -> NONTERM_expression 
    | 15 -> NONTERM_op 
    | 16 -> NONTERM_op 
    | 17 -> NONTERM_op 
    | 18 -> NONTERM_op 
    | 19 -> NONTERM_op 
    | 20 -> NONTERM_op 
    | 21 -> NONTERM_op 
    | 22 -> NONTERM_op 
    | 23 -> NONTERM_op 
    | 24 -> NONTERM_op 
    | _ -> failwith "prodIdxToNonTerminal: bad production index"

let _fsyacc_endOfInputTag = 24 
let _fsyacc_tagOfErrorTerminal = 22

// This function gets the name of a token as a string
let token_to_string (t:token) = 
  match t with 
  | EOF  -> "EOF" 
  | LET  -> "LET" 
  | BEGINSCOPE  -> "BEGINSCOPE" 
  | ENDSCOPE  -> "ENDSCOPE" 
  | OPENBRACKET  -> "OPENBRACKET" 
  | CLOSINGBRACKET  -> "CLOSINGBRACKET" 
  | ENDSTATEMENT  -> "ENDSTATEMENT" 
  | IF  -> "IF" 
  | RETURN  -> "RETURN" 
  | PLUS  -> "PLUS" 
  | MINUS  -> "MINUS" 
  | MULT  -> "MULT" 
  | DIV  -> "DIV" 
  | ASSIGN  -> "ASSIGN" 
  | EQ  -> "EQ" 
  | NE  -> "NE" 
  | LT  -> "LT" 
  | GT  -> "GT" 
  | LTE  -> "LTE" 
  | GTE  -> "GTE" 
  | INT _ -> "INT" 
  | ID _ -> "ID" 

// This function gets the data carried by a token as an object
let _fsyacc_dataOfToken (t:token) = 
  match t with 
  | EOF  -> (null : System.Object) 
  | LET  -> (null : System.Object) 
  | BEGINSCOPE  -> (null : System.Object) 
  | ENDSCOPE  -> (null : System.Object) 
  | OPENBRACKET  -> (null : System.Object) 
  | CLOSINGBRACKET  -> (null : System.Object) 
  | ENDSTATEMENT  -> (null : System.Object) 
  | IF  -> (null : System.Object) 
  | RETURN  -> (null : System.Object) 
  | PLUS  -> (null : System.Object) 
  | MINUS  -> (null : System.Object) 
  | MULT  -> (null : System.Object) 
  | DIV  -> (null : System.Object) 
  | ASSIGN  -> (null : System.Object) 
  | EQ  -> (null : System.Object) 
  | NE  -> (null : System.Object) 
  | LT  -> (null : System.Object) 
  | GT  -> (null : System.Object) 
  | LTE  -> (null : System.Object) 
  | GTE  -> (null : System.Object) 
  | INT _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | ID _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
let _fsyacc_gotos = [| 0us; 65535us; 1us; 65535us; 0us; 1us; 2us; 65535us; 15us; 5us; 23us; 6us; 5us; 65535us; 0us; 2us; 5us; 7us; 6us; 7us; 15us; 4us; 23us; 4us; 12us; 65535us; 0us; 8us; 5us; 8us; 6us; 8us; 15us; 8us; 17us; 18us; 20us; 21us; 23us; 8us; 25us; 26us; 29us; 30us; 34us; 31us; 35us; 32us; 37us; 33us; 8us; 65535us; 8us; 34us; 18us; 34us; 21us; 34us; 26us; 34us; 30us; 34us; 31us; 34us; 32us; 34us; 33us; 34us; |]
let _fsyacc_sparseGotoTableRowOffsets = [|0us; 1us; 3us; 6us; 12us; 25us; |]
let _fsyacc_stateToProdIdxsTableElements = [| 1us; 0us; 1us; 0us; 1us; 1us; 1us; 1us; 1us; 2us; 2us; 3us; 5us; 2us; 3us; 7us; 1us; 3us; 3us; 4us; 12us; 14us; 2us; 5us; 6us; 2us; 5us; 6us; 1us; 5us; 1us; 5us; 1us; 5us; 1us; 5us; 1us; 5us; 1us; 5us; 1us; 6us; 3us; 6us; 12us; 14us; 1us; 7us; 1us; 7us; 3us; 7us; 12us; 14us; 1us; 7us; 1us; 7us; 1us; 7us; 1us; 8us; 3us; 8us; 12us; 14us; 1us; 9us; 1us; 10us; 1us; 11us; 3us; 11us; 12us; 14us; 3us; 12us; 12us; 14us; 3us; 12us; 13us; 14us; 3us; 12us; 14us; 14us; 1us; 12us; 1us; 13us; 1us; 13us; 1us; 14us; 1us; 14us; 1us; 15us; 1us; 16us; 1us; 17us; 1us; 18us; 1us; 19us; 1us; 20us; 1us; 21us; 1us; 22us; 1us; 23us; 1us; 24us; |]
let _fsyacc_stateToProdIdxsTableRowOffsets = [|0us; 2us; 4us; 6us; 8us; 10us; 13us; 16us; 18us; 22us; 25us; 28us; 30us; 32us; 34us; 36us; 38us; 40us; 42us; 46us; 48us; 50us; 54us; 56us; 58us; 60us; 62us; 66us; 68us; 70us; 72us; 76us; 80us; 84us; 88us; 90us; 92us; 94us; 96us; 98us; 100us; 102us; 104us; 106us; 108us; 110us; 112us; 114us; 116us; |]
let _fsyacc_action_rows = 49
let _fsyacc_actionTableElements = [|7us; 32768us; 1us; 9us; 4us; 35us; 7us; 19us; 8us; 25us; 10us; 29us; 20us; 27us; 21us; 28us; 0us; 49152us; 1us; 32768us; 0us; 3us; 0us; 16385us; 0us; 16386us; 8us; 32768us; 1us; 9us; 3us; 16us; 4us; 35us; 7us; 19us; 8us; 25us; 10us; 29us; 20us; 27us; 21us; 28us; 8us; 32768us; 1us; 9us; 3us; 24us; 4us; 35us; 7us; 19us; 8us; 25us; 10us; 29us; 20us; 27us; 21us; 28us; 0us; 16387us; 11us; 16388us; 4us; 37us; 9us; 41us; 10us; 42us; 11us; 39us; 12us; 40us; 14us; 43us; 15us; 44us; 16us; 45us; 17us; 46us; 18us; 47us; 19us; 48us; 1us; 32768us; 21us; 10us; 2us; 32768us; 4us; 11us; 13us; 17us; 1us; 32768us; 21us; 12us; 1us; 32768us; 5us; 13us; 1us; 32768us; 13us; 14us; 1us; 32768us; 2us; 15us; 7us; 32768us; 1us; 9us; 4us; 35us; 7us; 19us; 8us; 25us; 10us; 29us; 20us; 27us; 21us; 28us; 0us; 16389us; 4us; 32768us; 4us; 35us; 10us; 29us; 20us; 27us; 21us; 28us; 11us; 16390us; 4us; 37us; 9us; 41us; 10us; 42us; 11us; 39us; 12us; 40us; 14us; 43us; 15us; 44us; 16us; 45us; 17us; 46us; 18us; 47us; 19us; 48us; 1us; 32768us; 4us; 20us; 4us; 32768us; 4us; 35us; 10us; 29us; 20us; 27us; 21us; 28us; 12us; 32768us; 4us; 37us; 5us; 22us; 9us; 41us; 10us; 42us; 11us; 39us; 12us; 40us; 14us; 43us; 15us; 44us; 16us; 45us; 17us; 46us; 18us; 47us; 19us; 48us; 1us; 32768us; 2us; 23us; 7us; 32768us; 1us; 9us; 4us; 35us; 7us; 19us; 8us; 25us; 10us; 29us; 20us; 27us; 21us; 28us; 0us; 16391us; 4us; 32768us; 4us; 35us; 10us; 29us; 20us; 27us; 21us; 28us; 11us; 16392us; 4us; 37us; 9us; 41us; 10us; 42us; 11us; 39us; 12us; 40us; 14us; 43us; 15us; 44us; 16us; 45us; 17us; 46us; 18us; 47us; 19us; 48us; 0us; 16393us; 0us; 16394us; 4us; 32768us; 4us; 35us; 10us; 29us; 20us; 27us; 21us; 28us; 0us; 16395us; 11us; 16396us; 4us; 37us; 9us; 41us; 10us; 42us; 11us; 39us; 12us; 40us; 14us; 43us; 15us; 44us; 16us; 45us; 17us; 46us; 18us; 47us; 19us; 48us; 12us; 32768us; 4us; 37us; 5us; 36us; 9us; 41us; 10us; 42us; 11us; 39us; 12us; 40us; 14us; 43us; 15us; 44us; 16us; 45us; 17us; 46us; 18us; 47us; 19us; 48us; 12us; 32768us; 4us; 37us; 5us; 38us; 9us; 41us; 10us; 42us; 11us; 39us; 12us; 40us; 14us; 43us; 15us; 44us; 16us; 45us; 17us; 46us; 18us; 47us; 19us; 48us; 4us; 32768us; 4us; 35us; 10us; 29us; 20us; 27us; 21us; 28us; 4us; 32768us; 4us; 35us; 10us; 29us; 20us; 27us; 21us; 28us; 0us; 16397us; 4us; 32768us; 4us; 35us; 10us; 29us; 20us; 27us; 21us; 28us; 0us; 16398us; 0us; 16399us; 0us; 16400us; 0us; 16401us; 0us; 16402us; 0us; 16403us; 0us; 16404us; 0us; 16405us; 0us; 16406us; 0us; 16407us; 0us; 16408us; |]
let _fsyacc_actionTableRowOffsets = [|0us; 8us; 9us; 11us; 12us; 13us; 22us; 31us; 32us; 44us; 46us; 49us; 51us; 53us; 55us; 57us; 65us; 66us; 71us; 83us; 85us; 90us; 103us; 105us; 113us; 114us; 119us; 131us; 132us; 133us; 138us; 139us; 151us; 164us; 177us; 182us; 187us; 188us; 193us; 194us; 195us; 196us; 197us; 198us; 199us; 200us; 201us; 202us; 203us; |]
let _fsyacc_reductionSymbolCounts = [|1us; 2us; 1us; 2us; 1us; 9us; 4us; 7us; 2us; 1us; 1us; 2us; 3us; 3us; 4us; 1us; 1us; 1us; 1us; 1us; 1us; 1us; 1us; 1us; 1us; |]
let _fsyacc_productionToNonTerminalTable = [|0us; 1us; 2us; 2us; 3us; 3us; 3us; 3us; 3us; 4us; 4us; 4us; 4us; 4us; 4us; 5us; 5us; 5us; 5us; 5us; 5us; 5us; 5us; 5us; 5us; |]
let _fsyacc_immediateActions = [|65535us; 49152us; 65535us; 16385us; 16386us; 65535us; 65535us; 16387us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 16389us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 16391us; 65535us; 65535us; 16393us; 16394us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 16397us; 65535us; 16398us; 16399us; 16400us; 16401us; 16402us; 16403us; 16404us; 16405us; 16406us; 16407us; 16408us; |]
let _fsyacc_reductions ()  =    [| 
# 220 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : Dala.stmt)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
                      raise (Microsoft.FSharp.Text.Parsing.Accept(Microsoft.FSharp.Core.Operators.box _1))
                   )
                 : '_startstart));
# 229 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : 'statement)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 30 "DalaParser.fsy"
                                  _1 
                   )
# 30 "DalaParser.fsy"
                 : Dala.stmt));
# 240 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : 'statement)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 33 "DalaParser.fsy"
                                       [_1] 
                   )
# 33 "DalaParser.fsy"
                 : 'statement_list));
# 251 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : 'statement_list)) in
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : 'statement)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 34 "DalaParser.fsy"
                                                      _2::_1 
                   )
# 34 "DalaParser.fsy"
                 : 'statement_list));
# 263 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : 'expression)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 37 "DalaParser.fsy"
                                            Expr _1 
                   )
# 37 "DalaParser.fsy"
                 : 'statement));
# 274 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : string)) in
            let _4 = (let data = parseState.GetInput(4) in (Microsoft.FSharp.Core.Operators.unbox data : string)) in
            let _8 = (let data = parseState.GetInput(8) in (Microsoft.FSharp.Core.Operators.unbox data : 'statement_list)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 38 "DalaParser.fsy"
                                                                                                                Fun(_2,_4,_8) 
                   )
# 38 "DalaParser.fsy"
                 : 'statement));
# 287 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : string)) in
            let _4 = (let data = parseState.GetInput(4) in (Microsoft.FSharp.Core.Operators.unbox data : 'expression)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 39 "DalaParser.fsy"
                                                          Assignment(_2,_4) 
                   )
# 39 "DalaParser.fsy"
                 : 'statement));
# 299 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _3 = (let data = parseState.GetInput(3) in (Microsoft.FSharp.Core.Operators.unbox data : 'expression)) in
            let _6 = (let data = parseState.GetInput(6) in (Microsoft.FSharp.Core.Operators.unbox data : 'statement_list)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 40 "DalaParser.fsy"
                                                                                                             IfCond(_3,_6) 
                   )
# 40 "DalaParser.fsy"
                 : 'statement));
# 311 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : 'expression)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 41 "DalaParser.fsy"
                                                   Ret(_2) 
                   )
# 41 "DalaParser.fsy"
                 : 'statement));
# 322 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : int)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 44 "DalaParser.fsy"
                                     Int(_1) 
                   )
# 44 "DalaParser.fsy"
                 : 'expression));
# 333 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : string)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 45 "DalaParser.fsy"
                                     Id(_1) 
                   )
# 45 "DalaParser.fsy"
                 : 'expression));
# 344 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : 'expression)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 46 "DalaParser.fsy"
                                                               EXP(Int(-1), Mult, _2) 
                   )
# 46 "DalaParser.fsy"
                 : 'expression));
# 355 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : 'expression)) in
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : 'op)) in
            let _3 = (let data = parseState.GetInput(3) in (Microsoft.FSharp.Core.Operators.unbox data : 'expression)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 47 "DalaParser.fsy"
                                                          EXP(_1, _2, _3) 
                   )
# 47 "DalaParser.fsy"
                 : 'expression));
# 368 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : 'expression)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 48 "DalaParser.fsy"
                                                                       _2 
                   )
# 48 "DalaParser.fsy"
                 : 'expression));
# 379 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : 'expression)) in
            let _3 = (let data = parseState.GetInput(3) in (Microsoft.FSharp.Core.Operators.unbox data : 'expression)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 49 "DalaParser.fsy"
                                                                                  Invoc(_1,_3) 
                   )
# 49 "DalaParser.fsy"
                 : 'expression));
# 391 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 52 "DalaParser.fsy"
                                 Mult
                   )
# 52 "DalaParser.fsy"
                 : 'op));
# 401 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 53 "DalaParser.fsy"
                                Div
                   )
# 53 "DalaParser.fsy"
                 : 'op));
# 411 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 54 "DalaParser.fsy"
                                 Plus
                   )
# 54 "DalaParser.fsy"
                 : 'op));
# 421 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 55 "DalaParser.fsy"
                                  Minus
                   )
# 55 "DalaParser.fsy"
                 : 'op));
# 431 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 56 "DalaParser.fsy"
                               Eq
                   )
# 56 "DalaParser.fsy"
                 : 'op));
# 441 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 57 "DalaParser.fsy"
                               Ne
                   )
# 57 "DalaParser.fsy"
                 : 'op));
# 451 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 58 "DalaParser.fsy"
                               Lt
                   )
# 58 "DalaParser.fsy"
                 : 'op));
# 461 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 59 "DalaParser.fsy"
                               Gt
                   )
# 59 "DalaParser.fsy"
                 : 'op));
# 471 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 60 "DalaParser.fsy"
                                Lte
                   )
# 60 "DalaParser.fsy"
                 : 'op));
# 481 "DalaParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 61 "DalaParser.fsy"
                                Gte
                   )
# 61 "DalaParser.fsy"
                 : 'op));
|]
# 492 "DalaParser.fs"
let tables () : Microsoft.FSharp.Text.Parsing.Tables<_> = 
  { reductions= _fsyacc_reductions ();
    endOfInputTag = _fsyacc_endOfInputTag;
    tagOfToken = tagOfToken;
    dataOfToken = _fsyacc_dataOfToken; 
    actionTableElements = _fsyacc_actionTableElements;
    actionTableRowOffsets = _fsyacc_actionTableRowOffsets;
    stateToProdIdxsTableElements = _fsyacc_stateToProdIdxsTableElements;
    stateToProdIdxsTableRowOffsets = _fsyacc_stateToProdIdxsTableRowOffsets;
    reductionSymbolCounts = _fsyacc_reductionSymbolCounts;
    immediateActions = _fsyacc_immediateActions;
    gotos = _fsyacc_gotos;
    sparseGotoTableRowOffsets = _fsyacc_sparseGotoTableRowOffsets;
    tagOfErrorTerminal = _fsyacc_tagOfErrorTerminal;
    parseError = (fun (ctxt:Microsoft.FSharp.Text.Parsing.ParseErrorContext<_>) -> 
                              match parse_error_rich with 
                              | Some f -> f ctxt
                              | None -> parse_error ctxt.Message);
    numTerminals = 25;
    productionToNonTerminalTable = _fsyacc_productionToNonTerminalTable  }
let engine lexer lexbuf startState = (tables ()).Interpret(lexer, lexbuf, startState)
let start lexer lexbuf : Dala.stmt =
    Microsoft.FSharp.Core.Operators.unbox ((tables ()).Interpret(lexer, lexbuf, 0))
