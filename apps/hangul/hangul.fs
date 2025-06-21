#if !INTERACTIVE
namespace Polyglot
#endif

module Hangul =

    /// ## Tests
    let AssertAreEqual (expected: 'T, actual: 'T) =
        if expected <> actual then
            failwithf "Expected %A but got %A" expected actual

    let AssertIsTrue (condition: bool) =
        if not condition then
            failwith "Expected condition to be true."

    let AssertIsFalse (condition: bool) =
        if condition then
            failwith "Expected condition to be false."

    /// ## Hanja

    /// ### hanjaConvert
    let hanjaConvert (s: string) =
        s
        |> Seq.map (fun c ->
            match hanjaToHangulTable.TryFind(int c) with
            | Some h -> char h
            | None -> c
        )
        |> String.Concat

    /// ### isHanja
    let isHanja (c: char) =
        hanjaToHangulTable.ContainsKey(int c)

    /// ## Hangul

    /// ### Literals
    let [<Literal>] G = 0x3131
    let [<Literal>] GG = 0x3132
    let [<Literal>] GS = 0x3133
    let [<Literal>] N = 0x3134
    let [<Literal>] NJ = 0x3135
    let [<Literal>] NH = 0x3136
    let [<Literal>] D = 0x3137
    let [<Literal>] DD = 0x3138
    let [<Literal>] L = 0x3139
    let [<Literal>] LG = 0x313a
    let [<Literal>] LM = 0x313b
    let [<Literal>] LB = 0x313c
    let [<Literal>] LS = 0x313d
    let [<Literal>] LT = 0x313e
    let [<Literal>] LP = 0x313f
    let [<Literal>] LH = 0x3140
    let [<Literal>] M = 0x3141
    let [<Literal>] B = 0x3142
    let [<Literal>] BB = 0x3143
    let [<Literal>] BS = 0x3144
    let [<Literal>] S = 0x3145
    let [<Literal>] SS = 0x3146
    let [<Literal>] ZS = 0x3147
    let [<Literal>] J = 0x3148
    let [<Literal>] JJ = 0x3149
    let [<Literal>] C = 0x314a
    let [<Literal>] K = 0x314b
    let [<Literal>] T = 0x314c
    let [<Literal>] P = 0x314d
    let [<Literal>] H = 0x314e
    let [<Literal>] A = 0x314f
    let [<Literal>] AE = 0x3150
    let [<Literal>] YA = 0x3151
    let [<Literal>] YAE = 0x3152
    let [<Literal>] EO = 0x3153
    let [<Literal>] E = 0x3154
    let [<Literal>] YEO = 0x3155
    let [<Literal>] YE = 0x3156
    let [<Literal>] O = 0x3157
    let [<Literal>] WA = 0x3158
    let [<Literal>] WAE = 0x3159
    let [<Literal>] OE = 0x315a
    let [<Literal>] YO = 0x315b
    let [<Literal>] U = 0x315c
    let [<Literal>] WEO = 0x315d
    let [<Literal>] WE = 0x315e
    let [<Literal>] WI = 0x315f
    let [<Literal>] YU = 0x3160
    let [<Literal>] EU = 0x3161
    let [<Literal>] YI = 0x3162
    let [<Literal>] I = 0x3163
    let [<Literal>] LeadG = 0x1100
    let [<Literal>] LeadGG = 0x1101
    let [<Literal>] LeadN = 0x1102
    let [<Literal>] LeadD = 0x1103
    let [<Literal>] LeadDD = 0x1104
    let [<Literal>] LeadR = 0x1105
    let [<Literal>] LeadM = 0x1106
    let [<Literal>] LeadB = 0x1107
    let [<Literal>] LeadBB = 0x1108
    let [<Literal>] LeadS = 0x1109
    let [<Literal>] LeadSS = 0x110a
    let [<Literal>] LeadZS = 0x110b
    let [<Literal>] LeadJ = 0x110c
    let [<Literal>] LeadJJ = 0x110d
    let [<Literal>] LeadC = 0x110e
    let [<Literal>] LeadK = 0x110f
    let [<Literal>] LeadT = 0x1110
    let [<Literal>] LeadP = 0x1111
    let [<Literal>] LeadH = 0x1112
    let [<Literal>] MedialA = 0x1161
    let [<Literal>] MedialAE = 0x1162
    let [<Literal>] MedialYA = 0x1163
    let [<Literal>] MedialYAE = 0x1164
    let [<Literal>] MedialEO = 0x1165
    let [<Literal>] MedialE = 0x1166
    let [<Literal>] MedialYEO = 0x1167
    let [<Literal>] MedialYE = 0x1168
    let [<Literal>] MedialO = 0x1169
    let [<Literal>] MedialWA = 0x116a
    let [<Literal>] MedialWAE = 0x116b
    let [<Literal>] MedialOE = 0x116c
    let [<Literal>] MedialYO = 0x116d
    let [<Literal>] MedialU = 0x116e
    let [<Literal>] MedialWEO = 0x116f
    let [<Literal>] MedialWE = 0x1170
    let [<Literal>] MedialWI = 0x1171
    let [<Literal>] MedialYU = 0x1172
    let [<Literal>] MedialEU = 0x1173
    let [<Literal>] MedialYI = 0x1174
    let [<Literal>] MedialI = 0x1175
    let [<Literal>] TailG = 0x11a8
    let [<Literal>] TailGG = 0x11a9
    let [<Literal>] TailGS = 0x11aa
    let [<Literal>] TailN = 0x11ab
    let [<Literal>] TailNJ = 0x11ac
    let [<Literal>] TailNH = 0x11ad
    let [<Literal>] TailD = 0x11ae
    let [<Literal>] TailL = 0x11af
    let [<Literal>] TailLG = 0x11b0
    let [<Literal>] TailLM = 0x11b1
    let [<Literal>] TailLB = 0x11b2
    let [<Literal>] TailLS = 0x11b3
    let [<Literal>] TailLT = 0x11b4
    let [<Literal>] TailLP = 0x11b5
    let [<Literal>] TailLH = 0x11b6
    let [<Literal>] TailM = 0x11b7
    let [<Literal>] TailB = 0x11b8
    let [<Literal>] TailBS = 0x11b9
    let [<Literal>] TailS = 0x11ba
    let [<Literal>] TailSS = 0x11bb
    let [<Literal>] TailNG = 0x11bc
    let [<Literal>] TailJ = 0x11bd
    let [<Literal>] TailC = 0x11be
    let [<Literal>] TailK = 0x11bf
    let [<Literal>] TailT = 0x11c0
    let [<Literal>] TailP = 0x11c1
    let [<Literal>] TailH = 0x11c2

    let [<Literal>] leadBase = 0x1100
    let [<Literal>] medialBase = 0x1161
    let [<Literal>] tailBase = 0x11A8

    let [<Literal>] maxLeadIdx = LeadH - LeadG
    let [<Literal>] maxMedialIdx = MedialI - MedialA
    let [<Literal>] maxTailIdx = TailH - TailG

    /// ### toCompatJamoMap
    let toCompatJamoMap =
        Map.ofList [
            (LeadG, G); (LeadGG, GG); (LeadN, N); (LeadD, D); (LeadDD, DD);
            (LeadR, L); (LeadM, M); (LeadB, B); (LeadBB, BB); (LeadS, S);
            (LeadSS, SS); (LeadZS, ZS); (LeadJ, J); (LeadJJ, JJ); (LeadC, C);
            (LeadK, K); (LeadT, T); (LeadP, P); (LeadH, H); (TailG, G);
            (TailGG, GG); (TailGS, GS); (TailN, N); (TailNJ, NJ); (TailNH, NH);
            (TailD, D); (TailL, L); (TailLG, LG); (TailLM, LM); (TailLB, LB);
            (TailLS, LS); (TailLT, LT); (TailLP, LP); (TailLH, LH); (TailM, M);
            (TailB, B); (TailBS, BS); (TailS, S); (TailSS, SS); (TailNG, ZS);
            (TailJ, J); (TailC, C); (TailK, K); (TailT, T); (TailP, P); (TailH, H)
        ]

    /// ### compatJamo
    let compatJamo (r: char) =
        let r' = int r
        if r' >= G && r' <= H then Some r
        elif r' >= A && r' <= I then Some r
        elif r' >= MedialA && r' <= MedialI then
            char (r' - medialBase + A) |> Some
        else
            toCompatJamoMap.TryFind(r') |> Option.map char

    /// ### isHangul
    let isHangul (r: char) =
        let r = int r
        match r with
        | _ when r >= 0xAC00 && r <= 0xD7A3 -> true
        | _ when (r >= G && r <= H) -> true
        | _ when (r >= LeadG && r <= LeadH) -> true
        | _ when (r >= MedialA && r <= MedialI) -> true
        | _ when (r >= TailG && r <= TailH) -> true
        | _ -> false

    /// ### isJaeum
    let isJaeum (r: char) =
        let r = int r
        match r with
        | _ when r >= G && r <= H -> true
        | _ when r >= LeadG && r <= LeadH -> true
        | _ when r >= TailG && r <= TailH -> true
        | _ -> false

    /// ### isMoeum
    let isMoeum (r: char) =
        let r = int r
        match r with
        | _ when r >= A && r <= I -> true
        | _ when r >= MedialA && r <= MedialI -> true
        | _ -> false

    /// ### leadIdx
    let leadIdx (r: int) =
        let i = r - leadBase
        if i >= 0 && i <= maxLeadIdx then Some i
        else None

    /// ### medialIdx
    let medialIdx (r: int) =
        let i = r - medialBase
        if i >= 0 && i <= maxMedialIdx then Some i
        else None

    /// ### tailIdx
    let tailIdx (r: int) =
        if r = 0 then Some 0
        else
            let i = r - tailBase
            if i >= 0 && i <= maxTailIdx then Some (i + 1)
            else None

    /// ### toLead
    let toLead (r: int) =
        match r with
        | G -> Some LeadG
        | GG -> Some LeadGG
        | N -> Some LeadN
        | D -> Some LeadD
        | DD -> Some LeadDD
        | L -> Some LeadR
        | M -> Some LeadM
        | B -> Some LeadB
        | BB -> Some LeadBB
        | S -> Some LeadS
        | SS -> Some LeadSS
        | ZS -> Some LeadZS
        | J -> Some LeadJ
        | JJ -> Some LeadJJ
        | C -> Some LeadC
        | K -> Some LeadK
        | T -> Some LeadT
        | P -> Some LeadP
        | H -> Some LeadH
        | _ -> None

    /// ### toMedial
    let toMedial (r: int) =
        if r >= A && r <= I then Some(r - A + MedialA)
        else None

    /// ### toTail
    let toTail (r: int) =
        match r with
        | G -> Some TailG
        | GG -> Some TailGG
        | GS -> Some TailGS
        | N -> Some TailN
        | NJ -> Some TailNJ
        | NH -> Some TailNH
        | D -> Some TailD
        | L -> Some TailL
        | LG -> Some TailLG
        | LM -> Some TailLM
        | LB -> Some TailLB
        | LS -> Some TailLS
        | LT -> Some TailLT
        | LP -> Some TailLP
        | LH -> Some TailLH
        | M -> Some TailM
        | B -> Some TailB
        | BS -> Some TailBS
        | S -> Some TailS
        | SS -> Some TailSS
        | ZS -> Some TailNG
        | J -> Some TailJ
        | C -> Some TailC
        | K -> Some TailK
        | T -> Some TailT
        | P -> Some TailP
        | H -> Some TailH
        | _ -> None

    /// ### lead
    let lead (r: int) =
        match toLead r with
        | Some l -> l
        | None -> r

    /// ### medial
    let medial (r: int) =
        match toMedial r with
        | Some m -> m
        | None -> r

    /// ### tail
    let tail (r: int) =
        match toTail r with
        | Some t -> t
        | None -> r

    /// ### join
    let join (l: char) (m: char) (t: char) =
        let li, mi, ti = lead (int l), medial (int m), tail (int t)
        match leadIdx li, medialIdx mi, tailIdx ti with
        | Some li', Some mi', Some ti' -> char (0xAC00 + (li' * 21 + mi') * 28 + ti')
        | _ -> char 0xFFFD

    /// ### split
    let split (c: char) =
        let c' = int c
        if c' < 0xAC00 || c' > 0xD7A3
        then (char 0, char 0, char 0)
        else
            let syllableIndex = c' - 0xAC00
            let lIndex = syllableIndex / (21 * 28)
            let mIndex = (syllableIndex % (21 * 28)) / 28
            let tIndex = syllableIndex % 28
            let l = char (LeadG + lIndex)
            let m = char (MedialA + mIndex)
            let t =
                if tIndex = 0 then char 0
                else char (tailBase + tIndex - 1)
            l, m, t

    /// ### splitCompat
    let splitCompat (c: char) =
        let l, m, t = split c
        compatJamo l, compatJamo m, compatJamo t

    /// ### strokeMap
    let strokeMap =
        Map.ofList [
            (G, 1); (N, 1); (D, 2); (L, 3); (M, 3); (B, 4); (S, 2); (ZS, 1);
            (J, 3); (C, 4); (K, 2); (T, 3); (P, 4); (H, 3); (A, 2); (YA, 3);
            (EO, 2); (YEO, 3); (O, 2); (YO, 3); (U, 2); (YU, 3); (EU, 1); (I, 1)
        ]

    /// ### multiElementMap
    let multiElementMap =
        Map.ofList [
            (GG, [|G; G|]); (GS, [|G; S|]); (NJ, [|N; J|]); (NH, [|N; H|]);
            (DD, [|D; D|]); (LG, [|L; G|]); (LM, [|L; M|]); (LB, [|L; B|]);
            (LS, [|L; S|]); (LT, [|L; T|]); (LP, [|L; P|]); (LH, [|L; H|]);
            (BB, [|B; B|]); (BS, [|B; S|]); (SS, [|S; S|]); (JJ, [|J; J|]);
            (AE, [|A; I|]); (E, [|EO; I|]); (YAE, [|YA; I|]); (YE, [|YEO; I|]);
            (WA, [|O; A|]); (WAE, [|O; A; I|]); (OE, [|O; I|]); (WEO, [|U; EO|]);
            (WE, [|U; E|]); (WI, [|U; I|]); (YI, [|EU; I|])
        ]

    /// ### splitMultiElement
    let splitMultiElement (c: char) =
        let c' = int (compatJamo c |> Option.defaultValue (char 0))
        multiElementMap.TryFind(c')

    /// ### stroke
    let rec stroke (r: char) =
        let r' = int r
        if r' >= 0xAC00 && r' <= 0xD7A3 then
            let l, m, t = split r
            stroke l + stroke m + stroke t
        else
            let jm = int (compatJamo r |> Option.defaultValue (char 0))
            match multiElementMap.TryFind(jm) with
            | Some elements -> elements |> Array.sumBy (fun e -> strokeMap.[e])
            | None -> strokeMap.TryFind(jm) |> Option.defaultValue 0

    /// ### endsWithConsonant
    let endsWithConsonant (s: string) =
        if String.IsNullOrEmpty(s) then false
        else
            let lastChar = s.[s.Length - 1]
            if not (isHangul lastChar) then false
            else
                let _, _, t = split lastChar
                t <> char 0

    /// ### lastConsonant
    let lastConsonant (s: string) =
        if String.IsNullOrEmpty(s) then char 0
        else
            let lastChar = s.[s.Length - 1]
            if not (isHangul lastChar) then char 0
            else
                let _, _, t = split lastChar
                t

    /// ### appendPostposition
    let appendPostposition (s: string) (withConsonant: string) (withoutConsonant: string) =
        let lastTail = lastConsonant s
        if int lastTail <> 0 then
            if withConsonant = "으로" && int lastTail = TailL then
                s + withoutConsonant
            else
                s + withConsonant
        else
            s + withoutConsonant

    /// ## CP949
    // type LookupItem = { cp949: int; ucs2: int }

    // let cp949FromTable : LookupItem[] =
    //     [|
    //         { cp949 = 0x8141; ucs2 = 0xac02 };
    //         { cp949 = 0x8142; ucs2 = 0xac03 };
    //         // (...)
    //         { cp949 = 0xfdfd; ucs2 = 0x7fb2 };
    //         { cp949 = 0xfdfe; ucs2 = 0x8a70 };
    //     |]

    // let cp949ToTable : LookupItem[] =
    //     [|
    //         { ucs2 = 0x00a1; cp949 = 0xa2ae };
    //         { ucs2 = 0x00a4; cp949 = 0xa2b4 };
    //         // (...)
    //         { ucs2 = 0xffe5; cp949 = 0xa1cd };
    //         { ucs2 = 0xffe6; cp949 = 0xa3dc };
    //     |]

    /// ### binarySearch
    let binarySearch (length: int) (predicate: int -> bool) =
        let rec search low high =
            if low >= high then
                low
            else
                let mid = low + (high - low) / 2
                if predicate mid then
                    search low mid
                else
                    search (mid + 1) high
        search 0 length

    /// ### fromCp949
    let fromCp949 (data: byte[]) =
        let rec processBytes bytes =
            match bytes with
            | [] -> []
            | b1 :: rest when b1 < 0x80uy ->
                char b1 :: processBytes rest
            | b1 :: b2 :: rest ->
                let cp949code = (uint16 b1 <<< 8) ||| uint16 b2
                let predicate i = cp949FromTable.[i].cp949 >= int cp949code
                let idx = binarySearch cp949FromTable.Length predicate
                let charToYield =
                    if idx < cp949FromTable.Length && cp949FromTable.[idx].cp949 = int cp949code then
                        char cp949FromTable.[idx].ucs2
                    else
                        char 0xFFFD
                charToYield :: processBytes rest
            | _ -> [char 0xFFFD]
        data |> Array.toList |> processBytes |> List.toArray |> System.String

    /// ### toCp949
    let toCp949 (s: string) =
        s
        |> Seq.collect (fun c ->
            let ucs2code = uint16 c
            if ucs2code < 0x80us then
                [| byte ucs2code |]
            else
                let predicate i = cp949ToTable.[i].ucs2 >= int ucs2code
                let idx = binarySearch cp949ToTable.Length predicate

                if idx < cp949ToTable.Length && cp949ToTable.[idx].ucs2 = int ucs2code then
                    let cp949code = cp949ToTable.[idx].cp949
                    [| byte (cp949code >>> 8); byte (cp949code &&& 0xFF) |]
                else
                    [| byte 0x3F |]
        )
        |> Seq.toArray
