type Ref<'T> = 'T
type clap_Command = class end
type clap_Arg = class end
type clap_ArgAction = class end
module TraceState = let mutable trace_state = None
type clap_ArgMatches = class end
type std_string_String = string
type System_IO_DirectoryInfo = System.IO.DirectoryInfo

type System_IO_FileInfo = System.IO.FileInfo

type std_path_PathBuf = string
type std_io_Error = string
type std_ffi_OsString = class end
type std_path_Display = string
type regex_Regex = class end
type std_borrow_Cow<'T> = class end
type async_walkdir_WalkDir = class end
type async_walkdir_DirEntry = class end
type std_pin_Pin<'T> = class end
type std_fs_FileType = class end
type async_walkdir_Filtering = class end
type async_walkdir_Error = class end
type Vec<'T> = class end
type std_process_Command = class end
type std_process_Stdio = class end
type std_process_Child = class end
type std_sync_Mutex<'T> = class end
type std_sync_Arc<'T> = class end
type std_sync_MutexGuard<'T> = class end
type std_process_ChildStdout = class end
type std_process_ChildStderr = class end
type std_process_ChildStdin = class end
type std_sync_mpsc_Sender<'T> = class end
type encoding_rs_io_DecodeReaderBytes<'T, 'U> = class end
type std_io_BufReader<'T> = class end
type std_io_Lines<'T> = class end
type std_sync_mpsc_SendError<'T> = class end
type core_ops_Try<'T> = class end
type std_thread_JoinHandle<'T> = class end
type std_process_Output = class end
type std_process_ExitStatus = class end
type std_sync_PoisonError<'T> = class end
type std_str_Utf8Error = class end
type Box<'T> = class end
type std_string_FromUtf8Error = class end
type std_fs_File = class end
type sha2_Sha256 = class end
type Slice'<'T> = class end
type Lifetime<'T, 'U> = class end
type StaticLifetime = class end
type Str = string
let spiralStringIndex (s : string) (i : int) : char = char (System.Text.Encoding.UTF8.GetBytes(s).[i])
let spiralStringSlice (s : string) (from : int) (upto : int) : string =
    let bytes = System.Text.Encoding.UTF8.GetBytes(s)
    let length = bytes.Length
    if from < 0 || from > length || upto < from - 1 || upto >= length then exit 3
    elif upto < from then ""
    elif (bytes.[from] &&& 0xC0uy) = 0x80uy || (upto + 1 < length && (bytes.[upto + 1] &&& 0xC0uy) = 0x80uy) then exit 3
    else System.Text.Encoding.UTF8.GetString(bytes, from, upto - from + 1)
type Dyn<'T> = class end
type std_future_Future<'T> = class end
type std_sync_mpsc_Receiver<'T> = class end
type Mut<'T> = class end
type encoding_rs_Encoding = class end
type Slice<'T> = class end
type LifetimeRef<'T> = class end
type LifetimeJoin<'T, 'U> = class end
type core_any_Any = obj
let __spiral_emit_rust (_ : 'a) (_ : 'b) : 'c = failwith "lib/spiral: Rust-only code reached in an F# build"
type [<Struct>] US0 =
    | US0_Verbose
    | US0_Debug
    | US0_Info
    | US0_Warning
    | US0_Critical
and Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : (string -> unit)}
and Mut2 = {mutable l0 : bool}
and Mut3 = {mutable l0 : string}
and Mut4 = {mutable l0 : US0}
and [<Struct>] US1 =
    | US1_Some of f0_0 : US0
    | US1_None
and [<Struct>] US2 =
    | US2_Some of f0_0 : int64
    | US2_None
and [<Struct>] US3 =
    | US3_Some of f0_0 : string
    | US3_None
and Mut5 = {mutable l0 : int32; mutable l1 : US1}
and [<Struct>] US4 =
    | US4_Some of f0_0 : Mut0 * f0_1 : Mut1 * f0_2 : Mut2 * f0_3 : Mut3 * f0_4 : Mut4 * f0_5 : int64 option
    | US4_None
and Mut6 = {mutable l0 : uint64}
and [<Struct>] US5 =
    | US5_Some of f0_0 : std_string_String
    | US5_None
and [<Struct>] US6 =
    | US6_Ok of f0_0 : std_path_PathBuf
    | US6_Error of f1_0 : std_io_Error
and [<Struct>] US7 =
    | US7_Ok of f0_0 : std_path_PathBuf
    | US7_Error of f1_0 : string
and [<Struct>] US8 =
    | US8_Ok of f0_0 : string
    | US8_Error of f1_0 : exn
and [<Struct>] US9 =
    | US9_Some of f0_0 : std_path_PathBuf
    | US9_None
and [<Struct>] US10 =
    | US10_File
    | US10_Directory
and [<Struct>] US11 =
    | US11_Ok of f0_0 : string
    | US11_Error of f1_0 : string
and [<Struct>] US12 =
    | US12_Ok of f0_0 : std_fs_FileType
    | US12_Error of f1_0 : std_io_Error
and [<Struct>] US13 =
    | US13_Ok of f0_0 : std_fs_FileType
    | US13_Error of f1_0 : std_string_String
and [<Struct>] US14 =
    | US14_Ignore
    | US14_IgnoreDir
    | US14_Continue
and [<Struct>] US15 =
    | US15_Ok of f0_0 : async_walkdir_DirEntry
    | US15_Error of f1_0 : async_walkdir_Error
and [<Struct>] US16 =
    | US16_Ok of f0_0 : async_walkdir_DirEntry
    | US16_Error of f1_0 : std_string_String
and [<Struct>] US17 =
    | US17_Ok of f0_0 : string * f0_1 : US3
    | US17_Error of f1_0 : string
and [<Struct>] US18 =
    | US18_Ok of f0_0 : char * f0_1 : int32 * f0_2 : int32 * f0_3 : int32 * f0_4 : int32 * f0_5 : int32
    | US18_Error of f1_0 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) * f1_1 : int32 * f1_2 : int32 * f1_3 : int32 * f1_4 : int32 * f1_5 : int32
and [<Struct>] US19 =
    | US19_Ok of f0_0 : string * f0_1 : int32 * f0_2 : int32 * f0_3 : int32 * f0_4 : int32 * f0_5 : int32
    | US19_Error of f1_0 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) * f1_1 : int32 * f1_2 : int32 * f1_3 : int32 * f1_4 : int32 * f1_5 : int32
and [<Struct>] US20 =
    | US20_Ok of f0_0 : int32 * f0_1 : int32 * f0_2 : int32 * f0_3 : int32 * f0_4 : int32
    | US20_Error of f1_0 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) * f1_1 : int32 * f1_2 : int32 * f1_3 : int32 * f1_4 : int32 * f1_5 : int32
and [<Struct>] US22 =
    | US22_Some of f0_0 : (unit -> string)
    | US22_None
and [<Struct>] US21 =
    | US21_Ok of f0_0 : (unit -> string) * f0_1 : (unit -> US22) * f0_2 : int32 * f0_3 : int32 * f0_4 : int32 * f0_5 : int32 * f0_6 : int32
    | US21_Error of f1_0 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) * f1_1 : int32 * f1_2 : int32 * f1_3 : int32 * f1_4 : int32 * f1_5 : int32
and [<Struct>] US23 =
    | US23_Ok of f0_0 : US22 * f0_1 : int32 * f0_2 : int32 * f0_3 : int32 * f0_4 : int32 * f0_5 : int32
    | US23_Error of f1_0 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) * f1_1 : int32 * f1_2 : int32 * f1_3 : int32 * f1_4 : int32 * f1_5 : int32
and [<Struct>] US24 =
    | US24_Ok of f0_0 : (unit -> string) * f0_1 : (unit -> US22) * f0_2 : string * f0_3 : int32 * f0_4 : int32 * f0_5 : int32 * f0_6 : int32
    | US24_Error of f1_0 : (unit -> string)
and [<Struct>] US25 =
    | US25_Ok of f0_0 : string * f0_1 : US3
    | US25_Error of f1_0 : (unit -> string)
and [<Struct>] US26 =
    | US26_Ok of f0_0 : (string [])
    | US26_Error of f1_0 : string
and UH0 =
    | UH0_Nil
    | UH0_Cons of string * UH0
and [<Struct>] US27 =
    | US27_Ok of f0_0 : UH0 * f0_1 : int32 * f0_2 : int32 * f0_3 : int32 * f0_4 : int32 * f0_5 : int32
    | US27_Error of f1_0 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) * f1_1 : int32 * f1_2 : int32 * f1_3 : int32 * f1_4 : int32 * f1_5 : int32
and [<Struct>] US28 =
    | US28_Ok of f0_0 : UH0 * f0_1 : string * f0_2 : int32 * f0_3 : int32 * f0_4 : int32 * f0_5 : int32
    | US28_Error of f1_0 : (unit -> string)
and [<Struct>] US29 =
    | US29_Ok of f0_0 : (string [])
    | US29_Error of f1_0 : (unit -> string)
and [<Struct>] US30 =
    | US30_Ok of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>
    | US30_Error of f1_0 : std_string_String
and [<Struct>] US31 =
    | US31_Some of f0_0 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>
    | US31_None
and [<Struct>] US32 =
    | US32_Ok of f0_0 : std_string_String
    | US32_Error of f1_0 : std_string_String
and [<Struct>] US33 =
    | US33_Some of f0_0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)
    | US33_None
and [<Struct>] US34 =
    | US34_Some of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>
    | US34_None
and [<Struct>] US35 =
    | US35_Ok of f0_0 : std_process_Output
    | US35_Error of f1_0 : std_string_String
and [<Struct>] US36 =
    | US36_Some of f0_0 : int32
    | US36_None
and [<Struct>] US37 =
    | US37_Some of f0_0 : US3
    | US37_None
and [<Struct>] US38 =
    | US38_Some of f0_0 : Result<string, (string * string)>
    | US38_None
and UH2 =
    | UH2_Nil
    | UH2_Cons of string * string * (string -> (string -> US38)) * UH2
and UH1 =
    | UH1_Nil
    | UH1_Cons of UH2 * UH1
and [<Struct>] US39 =
    | US39_Ok of f0_0 : unativeint
    | US39_Error of f1_0 : exn
and [<Struct>] US40 =
    | US40_Some of f0_0 : unativeint
    | US40_None
and [<Struct>] US41 =
    | US41_Ok of f0_0 : string
    | US41_Error of f1_0 : std_io_Error
and [<Struct>] US42 =
    | US42_Ok of f0_0 : string
    | US42_Error of f1_0 : std_string_String
and [<Struct>] US43 =
    | US43_Ok of f0_0 : int32 * f0_1 : string
    | US43_Error of f1_0 : int32 * f1_1 : string
and Mut7 = {mutable l0 : int32}
and Mut8 = {mutable l0 : int32; mutable l1 : int32}
and Mut9 = {mutable l0 : int32; mutable l1 : string; mutable l2 : int32; mutable l3 : int32; mutable l4 : bool}
and [<Struct>] US44 =
    | US44_Ok of f0_0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>
    | US44_Error of f1_0 : std_string_String
let rec get_command_0 () : clap_Command =
    let v0 : string = "command"
    let v1 : string = "r#\"" + v0 + "\"#"
    let v2 : Ref<Lifetime<StaticLifetime, Str>> = __spiral_emit_rust () v1 
    let v3 : string = "clap::Command::new($0)"
    let v4 : clap_Command = __spiral_emit_rust v2 v3 
    let v5 : string = "source-dir"
    let v6 : string = "r#\"" + v5 + "\"#"
    let v7 : Ref<Lifetime<StaticLifetime, Str>> = __spiral_emit_rust () v6 
    let v8 : string = "clap::Arg::new($0)"
    let v9 : clap_Arg = __spiral_emit_rust v7 v8 
    let v10 : string = "$0.short($1 as char)"
    let v11 : clap_Arg = __spiral_emit_rust struct (v9, 's') v10 
    let v12 : string = "r#\"" + v5 + "\"#"
    let v13 : Ref<Lifetime<StaticLifetime, Str>> = __spiral_emit_rust () v12 
    let v14 : string = "$0.long($1)"
    let v15 : clap_Arg = __spiral_emit_rust struct (v11, v13) v14 
    let v16 : string = "$0.required($1)"
    let v17 : clap_Arg = __spiral_emit_rust struct (v15, true) v16 
    let v18 : string = "clap::Command::arg($0, $1)"
    let v19 : clap_Command = __spiral_emit_rust struct (v4, v17) v18 
    let v20 : string = "dist-dir"
    let v21 : string = "r#\"" + v20 + "\"#"
    let v22 : Ref<Lifetime<StaticLifetime, Str>> = __spiral_emit_rust () v21 
    let v23 : string = "clap::Arg::new($0)"
    let v24 : clap_Arg = __spiral_emit_rust v22 v23 
    let v25 : string = "$0.short($1 as char)"
    let v26 : clap_Arg = __spiral_emit_rust struct (v24, 'd') v25 
    let v27 : string = "r#\"" + v20 + "\"#"
    let v28 : Ref<Lifetime<StaticLifetime, Str>> = __spiral_emit_rust () v27 
    let v29 : string = "$0.long($1)"
    let v30 : clap_Arg = __spiral_emit_rust struct (v26, v28) v29 
    let v31 : string = "$0.required($1)"
    let v32 : clap_Arg = __spiral_emit_rust struct (v30, true) v31 
    let v33 : string = "clap::Command::arg($0, $1)"
    let v34 : clap_Command = __spiral_emit_rust struct (v19, v32) v33 
    let v35 : string = "cache-dir"
    let v36 : string = "r#\"" + v35 + "\"#"
    let v37 : Ref<Lifetime<StaticLifetime, Str>> = __spiral_emit_rust () v36 
    let v38 : string = "clap::Arg::new($0)"
    let v39 : clap_Arg = __spiral_emit_rust v37 v38 
    let v40 : string = "$0.short($1 as char)"
    let v41 : clap_Arg = __spiral_emit_rust struct (v39, 'c') v40 
    let v42 : string = "r#\"" + v35 + "\"#"
    let v43 : Ref<Lifetime<StaticLifetime, Str>> = __spiral_emit_rust () v42 
    let v44 : string = "$0.long($1)"
    let v45 : clap_Arg = __spiral_emit_rust struct (v41, v43) v44 
    let v46 : string = "$0.required($1)"
    let v47 : clap_Arg = __spiral_emit_rust struct (v45, true) v46 
    let v48 : string = "clap::Command::arg($0, $1)"
    let v49 : clap_Command = __spiral_emit_rust struct (v34, v47) v48 
    let v50 : string = "hangul-spec"
    let v51 : string = "r#\"" + v50 + "\"#"
    let v52 : Ref<Lifetime<StaticLifetime, Str>> = __spiral_emit_rust () v51 
    let v53 : string = "clap::Arg::new($0)"
    let v54 : clap_Arg = __spiral_emit_rust v52 v53 
    let v55 : string = "$0.short($1 as char)"
    let v56 : clap_Arg = __spiral_emit_rust struct (v54, 'H') v55 
    let v57 : string = "r#\"" + v50 + "\"#"
    let v58 : Ref<Lifetime<StaticLifetime, Str>> = __spiral_emit_rust () v57 
    let v59 : string = "$0.long($1)"
    let v60 : clap_Arg = __spiral_emit_rust struct (v56, v58) v59 
    let v61 : string = "clap::Command::arg($0, $1)"
    let v62 : clap_Command = __spiral_emit_rust struct (v49, v60) v61 
    let v63 : string = "filter"
    let v64 : string = "r#\"" + v63 + "\"#"
    let v65 : Ref<Lifetime<StaticLifetime, Str>> = __spiral_emit_rust () v64 
    let v66 : string = "clap::Arg::new($0)"
    let v67 : clap_Arg = __spiral_emit_rust v65 v66 
    let v68 : string = "$0.short($1 as char)"
    let v69 : clap_Arg = __spiral_emit_rust struct (v67, 'f') v68 
    let v70 : string = "r#\"" + v63 + "\"#"
    let v71 : Ref<Lifetime<StaticLifetime, Str>> = __spiral_emit_rust () v70 
    let v72 : string = "$0.long($1)"
    let v73 : clap_Arg = __spiral_emit_rust struct (v69, v71) v72 
    let v74 : string = "clap::Command::arg($0, $1)"
    let v75 : clap_Command = __spiral_emit_rust struct (v62, v73) v74 
    let v76 : string = "transcribe-only"
    let v77 : string = "r#\"" + v76 + "\"#"
    let v78 : Ref<Lifetime<StaticLifetime, Str>> = __spiral_emit_rust () v77 
    let v79 : string = "clap::Arg::new($0)"
    let v80 : clap_Arg = __spiral_emit_rust v78 v79 
    let v81 : string = "$0.short($1 as char)"
    let v82 : clap_Arg = __spiral_emit_rust struct (v80, 't') v81 
    let v83 : string = "r#\"" + v76 + "\"#"
    let v84 : Ref<Lifetime<StaticLifetime, Str>> = __spiral_emit_rust () v83 
    let v85 : string = "$0.long($1)"
    let v86 : clap_Arg = __spiral_emit_rust struct (v82, v84) v85 
    let v87 : string = "false"
    let v88 : string = "r#\"" + v87 + "\"#"
    let v89 : Ref<Str> = __spiral_emit_rust () v88 
    let v90 : string = "$0.default_value(&*Box::leak(String::from($1).into_boxed_str()))"
    let v91 : clap_Arg = __spiral_emit_rust struct (v86, v89) v90 
    let v92 : string = "clap::ArgAction::SetTrue"
    let v93 : clap_ArgAction = __spiral_emit_rust () v92 
    let v94 : string = "$0.action($1)"
    let v95 : clap_Arg = __spiral_emit_rust struct (v91, v93) v94 
    let v96 : string = "clap::Command::arg($0, $1)"
    let v97 : clap_Command = __spiral_emit_rust struct (v75, v95) v96 
    v97
and closure0 () () : unit =
    let v0 : string = "verify_app"
    let v1 : bool = SPIRAL_TEST.with(|t| t.borrow().map_or(false, |s| s == (&*v0)))
    if v1 then
        let v2 : clap_Command = get_command_0()
        let v3 : string = "clap::Command::debug_assert($0)"
        __spiral_emit_rust v2 v3 
        ()
and closure2 () (v0 : string) : US3 =
    US3_Some(v0)
and method4 () : (string -> US3) =
    closure2()
and get_environment_variable_3 (v0 : string) : string =
    let v1 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v2 : string = v1 v0
    let v3 : (string -> string option) = Option.ofObj
    let v4 : string option = v3 v2
    let v5 : (string -> US3) = method4()
    let v6 : US3 option = v4 |> Option.map v5 
    let v7 : US3 = US3_None
    let v8 : US3 = v6 |> Option.defaultValue v7 
    match v8 with
    | US3_None -> (* None *)
        let v10 : string = ""
        v10
    | US3_Some(v9) -> (* Some *)
        v9
and method5 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method2 () : struct (US1 * US2) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = get_environment_variable_3(v0)
    
    
    
    
    
    let v2 : string = "Critical"
    let v3 : (unit -> string) = v2.ToLower
    let v4 : string = v3 ()
    let v5 : string = "Warning"
    let v6 : (unit -> string) = v5.ToLower
    let v7 : string = v6 ()
    let v8 : string = "Info"
    let v9 : (unit -> string) = v8.ToLower
    let v10 : string = v9 ()
    let v11 : string = "Debug"
    let v12 : (unit -> string) = v11.ToLower
    let v13 : string = v12 ()
    let v14 : string = "Verbose"
    let v15 : (unit -> string) = v14.ToLower
    let v16 : string = v15 ()
    let v17 : struct (string * US0) list = []
    let v18 : US0 = US0_Critical
    let v19 : struct (string * US0) list = struct (v4, v18) :: v17 
    let v20 : US0 = US0_Warning
    let v21 : struct (string * US0) list = struct (v7, v20) :: v19 
    let v22 : US0 = US0_Info
    let v23 : struct (string * US0) list = struct (v10, v22) :: v21 
    let v24 : US0 = US0_Debug
    let v25 : struct (string * US0) list = struct (v13, v24) :: v23 
    let v26 : US0 = US0_Verbose
    let v27 : struct (string * US0) list = struct (v16, v26) :: v25 
    let v28 : US0 = US0_Critical
    let v29 : struct (string * US0) list = struct (v2, v28) :: v27 
    let v30 : US0 = US0_Warning
    let v31 : struct (string * US0) list = struct (v5, v30) :: v29 
    let v32 : US0 = US0_Info
    let v33 : struct (string * US0) list = struct (v8, v32) :: v31 
    let v34 : US0 = US0_Debug
    let v35 : struct (string * US0) list = struct (v11, v34) :: v33 
    let v36 : US0 = US0_Verbose
    let v37 : struct (string * US0) list = struct (v14, v36) :: v35 
    let v38 : (struct (string * US0) list -> (struct (string * US0) [])) = List.toArray
    let v39 : (struct (string * US0) []) = v38 v37
    let v40 : int32 = v39.Length
    let v41 : US1 = US1_None
    let v42 : Mut5 = {l0 = 0; l1 = v41} : Mut5
    while method5(v40, v42) do
        let v44 : int32 = v42.l0
        let v45 : int32 =  -v44
        let v46 : int32 = v45 + v40
        let v47 : int32 = v46 - 1
        let v48 : US1 = v42.l1
        let struct (v49 : string, v50 : US0) = v39.[int v47]
        let v57 : US1 =
            match v48 with
            | US1_None -> (* None *)
                let v52 : bool = v49 = v1 
                if v52 then
                    US1_Some(v50)
                else
                    US1_None
            | US1_Some(v51) -> (* Some *)
                v48
        let v58 : int32 = v44 + 1
        v42.l0 <- v58
        v42.l1 <- v57
        ()
    let v59 : US1 = v42.l1
    let v60 : string = "AUTOMATION"
    let v61 : string = get_environment_variable_3(v60)
    let v62 : string = "True"
    let v63 : bool = v61 <> v62 
    let v68 : US2 =
        if v63 then
            US2_None
        else
            let v65 : System.DateTime = System.DateTime.Now
            let v66 : int64 = (v65.Ticks - 621355968000000000L) / 10L
            US2_Some(v66)
    struct (v59, v68)
and closure3 () (v0 : string) : unit =
    ()
and new_trace_state_1 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    let struct (v1 : US1, v2 : US2) = method2()
    let v3 : Mut0 = {l0 = 1L} : Mut0
    let v4 : (string -> unit) = closure3()
    let v5 : Mut1 = {l0 = v4} : Mut1
    let v6 : Mut2 = {l0 = true} : Mut2
    let v7 : string = ""
    let v8 : Mut3 = {l0 = v7} : Mut3
    let v11 : US0 =
        match v1 with
        | US1_None -> (* None *)
            v0
        | US1_Some(v9) -> (* Some *)
            v9
    let v12 : Mut4 = {l0 = v11} : Mut4
    let v17 : int64 option =
        match v2 with
        | US2_None -> (* None *)
            let v15 : int64 option = None
            v15
        | US2_Some(v13) -> (* Some *)
            let v14 : int64 option = Some v13 
            v14
    struct (v3, v5, v6, v8, v12, v17)
and closure4 () (v0 : int64) : US2 =
    US2_Some(v0)
and method7 () : (int64 -> US2) =
    closure4()
and method8 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method6 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    let v6 : (int64 -> US2) = method7()
    let v7 : US2 option = v5 |> Option.map v6 
    let v8 : US2 = US2_None
    let v9 : US2 = v7 |> Option.defaultValue v8 
    let v26 : System.DateTime =
        match v9 with
        | US2_None -> (* None *)
            let v24 : System.DateTime = System.DateTime.Now
            v24
        | US2_Some(v10) -> (* Some *)
            let v11 : System.DateTime = System.DateTime.Now
            let v12 : int64 = (v11.Ticks - 621355968000000000L) / 10L
            let v13 : int64 = v12 - v10
            let v14 : System.TimeSpan = System.TimeSpan.FromTicks(v13 * 10L)
            let v15 : (System.TimeSpan -> int32) = _.Hours
            let v16 : int32 = v15 v14
            let v17 : (System.TimeSpan -> int32) = _.Minutes
            let v18 : int32 = v17 v14
            let v19 : (System.TimeSpan -> int32) = _.Seconds
            let v20 : int32 = v19 v14
            let v21 : (System.TimeSpan -> int32) = _.Milliseconds
            let v22 : int32 = v21 v14
            let v23 : System.DateTime = System.DateTime (1, 1, 1, v16, v18, v20, v22)
            v23
    let v27 : string = method8()
    let v28 : bool = v27 = ""
    let v30 : string =
        if v28 then
            let v29 : string = "M-d-y hh:mm:ss tt"
            v29
        else
            v27
    let v31 : (string -> string) = v26.ToString
    v31 v30
and method11 () : string =
    let v0 : string = ""
    v0
and method12 (v0 : Mut3, v1 : string) : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and format_real_10 (v0 : char) : string =
    let v1 : string = method11()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    method12(v2, v3)
    let v4 : string = v2.l0
    v4
and method9 () : string =
    let v0 : string = "\u001b[92m"
    
    
    
    
    
    let v1 : string = "Info"
    let v2 : (unit -> string) = v1.ToLower
    let v3 : string = v2 ()
    let v4 : char = (spiralStringIndex v3 (int 0))
    let v5 : string = format_real_10(v4)
    let v6 : string = v0 + v5 
    let v7 : string = "\u001b[0m"
    let v8 : string = v6 + v7 
    v8
and format_real_14 (v0 : int64) : string =
    let v1 : string = method11()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    method12(v2, v3)
    let v4 : string = v2.l0
    v4
and method16 (v0 : uint64, v1 : Mut6) : bool =
    let v2 : uint64 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method15 (v0 : (string [])) : string =
    let v1 : uint64 = System.Convert.ToUInt64 v0.Length
    let v2 : uint64 = 0UL
    let v3 : Mut6 = {l0 = v2} : Mut6
    let v4 : string = ""
    let v5 : Mut3 = {l0 = v4} : Mut3
    while method16(v1, v3) do
        let v7 : uint64 = v3.l0
        let v8 : string = v0.[int v7]
        let v9 : bool = v7 = 0UL
        let v14 : string =
            if v9 then
                v8
            else
                let v10 : string = v5.l0
                let v11 : string = ", "
                let v12 : string = v10 + v11 
                let v13 : string = v12 + v8 
                v13
        v5.l0 <- v14
        let v15 : uint64 = v7 + 1UL
        v3.l0 <- v15
        ()
    let v16 : string = v5.l0
    let v17 : string = "["
    let v18 : string = v17 + v16 
    let v19 : string = "]"
    let v20 : string = v18 + v19 
    v20
and method18 (v0 : string, v1 : int32, v2 : int32) : int32 =
    let v3 : bool = v2 >= v1
    if v3 then
        v1
    else
        let v4 : char = (spiralStringIndex v0 (int v2))
        let v5 : bool = v4 = ' '
        let v11 : bool =
            if v5 then
                true
            else
                let v6 : bool = v4 = '\t'
                if v6 then
                    true
                else
                    let v7 : bool = v4 = '\r'
                    if v7 then
                        true
                    else
                        let v8 : bool = v4 = '\n'
                        v8
        if v11 then
            let v12 : int32 = v2 + 1
            method18(v0, v1, v12)
        else
            v2
and method19 (v0 : string, v1 : int32) : int32 =
    let v2 : bool = v1 <= 0
    if v2 then
        -1
    else
        let v3 : int32 = v1 - 1
        let v4 : char = (spiralStringIndex v0 (int v3))
        let v5 : bool = v4 = ' '
        let v7 : bool =
            if v5 then
                true
            else
                let v6 : bool = v4 = '/'
                v6
        if v7 then
            method19(v0, v3)
        else
            v3
and method17 (v0 : string) : string =
    let v1 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v0))
    let v2 : int32 = 0
    let v3 : int32 = method18(v0, v1, v2)
    let v4 : int32 = v1 - 1
    let v5 : string = (spiralStringSlice v0 (int v3) (int v4))
    let v6 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v5))
    let v7 : int32 = method19(v5, v6)
    let v8 : string = (spiralStringSlice v5 (int 0) (int v7))
    v8
and method13 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : (string [])) : string =
    let v9 : int64 = v0.l0
    let v10 : string = " "
    let v11 : string = v6 + v10 
    let v12 : string = format_real_14(v9)
    let v13 : string = v11 + v12 
    let v14 : string = v13 + v7 
    let v15 : string = v14 + v10 
    let v16 : string = "documents.main"
    let v17 : string = v15 + v16 
    let v18 : string = " / "
    let v19 : string = v17 + v18 
    let v20 : string = ""
    let v21 : string = v20 + v20 
    let v22 : string = "args"
    let v23 : string = v21 + v22 
    let v24 : string = " = "
    let v25 : string = v23 + v24 
    let v26 : string = method15(v8)
    let v27 : string = v25 + v26 
    let v28 : string = "{ "
    let v29 : string = v28 + v27 
    let v30 : string = " }"
    let v31 : string = v29 + v30 
    let v32 : string = v19 + v31 
    method17(v32)
and closure5 () (v0 : string) : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and method20 () : string =
    let v0 : string = "source-dir"
    v0
and closure6 () (v0 : std_string_String) : US5 =
    US5_Some(v0)
and method21 () : (std_string_String -> US5) =
    closure6()
and method22 () : string =
    let v0 : string = "dist-dir"
    v0
and method23 () : string =
    let v0 : string = "cache-dir"
    v0
and method24 () : string =
    let v0 : string = "hangul-spec"
    v0
and method25 () : string =
    let v0 : string = "filter"
    v0
and method26 () : string =
    let v0 : string = "transcribe-only"
    v0
and directory_info_attributes_31 (v0 : System_IO_DirectoryInfo) : System.IO.FileAttributes =
    let v1 : (System_IO_DirectoryInfo -> System.IO.FileAttributes) = _.Attributes
    v1 v0
and file_attributes_reparse_point_32 () : System.IO.FileAttributes =
    let v0 : System.IO.FileAttributes = System.IO.FileAttributes.ReparsePoint
    v0
and file_attributes_has_flag_33 (v0 : System.IO.FileAttributes, v1 : System.IO.FileAttributes) : bool =
    let v2 : bool = v1.HasFlag v0 
    v2
and get_file_name_36 (v0 : string) : string =
    let v1 : (string -> string) = System.IO.Path.GetFileName
    v1 v0
and directory_get_parent_37 (v0 : string) : string option =
    let v1 : (string -> System_IO_DirectoryInfo) = System.IO.Directory.GetParent
    let v2 : System_IO_DirectoryInfo = v1 v0
    let v3 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let v4 : bool = v2 = v3 
    let v9 : US3 =
        if v4 then
            US3_None
        else
            let v6 : (System_IO_DirectoryInfo -> string) = _.FullName
            let v7 : string = v6 v2
            US3_Some(v7)
    match v9 with
    | US3_None -> (* None *)
        let v12 : string option = None
        v12
    | US3_Some(v10) -> (* Some *)
        let v11 : string option = Some v10 
        v11
and ok_c9 () (v0 : std_path_PathBuf) : US6 =
    US6_Ok(v0)
and method38 () : (std_path_PathBuf -> US6) =
    ok_c9()
and error_c10 () (v0 : std_io_Error) : US6 =
    US6_Error(v0)
and method39 () : (std_io_Error -> US6) =
    error_c10()
and ok_c11 () (v0 : std_path_PathBuf) : US7 =
    US7_Ok(v0)
and method40 () : (std_path_PathBuf -> US7) =
    ok_c11()
and error_c12 () (v0 : string) : US7 =
    US7_Error(v0)
and method41 () : (string -> US7) =
    error_c12()
and closure13 (v0 : std_path_Display) () : string =
    let v1 : string = v0 |> string 
    v1
and ok_c14 () (v0 : string) : US8 =
    US8_Ok(v0)
and closure15 () (v0 : (unit -> exn)) : exn =
    v0 ()
and error_c16 () (v0 : exn) : US8 =
    US8_Error(v0)
and method42 (v0 : std_path_Display) : US8 =
    let v1 : (unit -> string) = closure13(v0)
    let v2 : (string -> US8) = ok_c14()
    let v3 : ((unit -> exn) -> exn) = closure15()
    let v4 : (exn -> US8) = error_c16()
    let v5 : US8 = try v1 () |> v2 with ex -> (fun () -> ex) |> v3 |> v4 
    v5
and method43 (v0 : string, v1 : string) : string =
    let v2 : string = System.IO.Path.Combine (v0, v1)
    v2
and run_35 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : std_io_Error, v4 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v5 : string = get_file_name_36(v4)
    let v6 : string option = directory_get_parent_37(v4)
    let v7 : (string -> US3) = method4()
    let v8 : US3 option = v6 |> Option.map v7 
    let v9 : US3 = US3_None
    let v10 : US3 = v8 |> Option.defaultValue v9 
    let v11 : string = $"%A{v3}"
    let v12 : bool = v2 >= 11uy
    if v12 then
        let v13 : string = $"file_system.read_link / "
        let v14 : string = $"path: {v0} / n: {v2} / path': {v4} / name: {v5}"
        let v15 : string = v13 + v14 
        let v16 : std_io_Error = v15 |> unbox<std_io_Error>
        let v17 : Result<std_path_PathBuf, std_io_Error> = Error v16 
        v17
    else
        match v10 with
        | US3_Some(v18) -> (* Some *)
            let v19 : string = ""
            let v20 : bool = v4 <> v19 
            if v20 then
                let v21 : uint8 = v2 + 1uy
                let v22 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v21
                let v23 : Result<std_path_PathBuf, std_io_Error> = v22 v18
                let v24 : (std_path_PathBuf -> US6) = method38()
                let v25 : (std_io_Error -> US6) = method39()
                let v26 : US6 = match v23 with Ok x -> v24 x | Error x -> v25 x
                let v33 : US7 =
                    match v26 with
                    | US6_Error(v29) -> (* Error *)
                        let v30 : string = $"%A{v29}"
                        US7_Error(v30)
                    | US6_Ok(v27) -> (* Ok *)
                        US7_Ok(v27)
                let v39 : Result<std_path_PathBuf, string> =
                    match v33 with
                    | US7_Error(v36) -> (* Error *)
                        let v37 : Result<std_path_PathBuf, string> = Error v36 
                        v37
                    | US7_Ok(v34) -> (* Ok *)
                        let v35 : Result<std_path_PathBuf, string> = Ok v34 
                        v35
                let v40 : (std_path_PathBuf -> US7) = method40()
                let v41 : (string -> US7) = method41()
                let v42 : US7 = match v39 with Ok x -> v40 x | Error x -> v41 x
                match v42 with
                | US7_Error(v61) -> (* Error *)
                    let v62 : string = $"file_system.read_link / "
                    let v63 : string = $"error': {v61} / error: {v11} / name: {v5}"
                    let v64 : string = v62 + v63 
                    let v65 : std_io_Error = v64 |> unbox<std_io_Error>
                    let v66 : Result<std_path_PathBuf, std_io_Error> = Error v65 
                    v66
                | US7_Ok(v43) -> (* Ok *)
                    let v44 : std_path_Display = v43 |> unbox<std_path_Display>
                    let v45 : US8 = method42(v44)
                    let v51 : US3 =
                        match v45 with
                        | US8_Error(v48) -> (* Error *)
                            US3_None
                        | US8_Ok(v46) -> (* Ok *)
                            US3_Some(v46)
                    let v55 : string =
                        match v51 with
                        | US3_None -> (* None *)
                            failwith<string> "Option does not have a value."
                        | US3_Some(v52) -> (* Some *)
                            v52
                    let v56 : string = method43(v55, v5)
                    let v57 : Ref<Str> = v56 |> unbox<Ref<Str>>
                    let v58 : std_string_String = v57 |> unbox<std_string_String>
                    let v59 : std_path_PathBuf = v58 |> unbox<std_path_PathBuf>
                    let v60 : Result<std_path_PathBuf, std_io_Error> = Ok v59 
                    v60
            else
                let v69 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v70 : string = $"path: {v0} / error: {v11} / path': {v4} / name: {v5}"
                let v71 : string = v69 + v70 
                let v72 : std_io_Error = v71 |> unbox<std_io_Error>
                let v73 : Result<std_path_PathBuf, std_io_Error> = Error v72 
                v73
        | _ ->
            let v75 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v76 : string = $"path: {v0} / error: {v11} / path': {v4} / name: {v5}"
            let v77 : string = v75 + v76 
            let v78 : std_io_Error = v77 |> unbox<std_io_Error>
            let v79 : Result<std_path_PathBuf, std_io_Error> = Error v78 
            v79
and method34 (v0 : string, v1 : uint8, v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v3 : System_IO_DirectoryInfo = v2 |> System_IO_DirectoryInfo 
    let v4 : System.IO.FileAttributes = directory_info_attributes_31(v3)
    let v5 : System.IO.FileAttributes = file_attributes_reparse_point_32()
    let v6 : bool = file_attributes_has_flag_33(v5, v4)
    if v6 then
        let v7 : System_IO_FileInfo = v2 |> System_IO_FileInfo 
        let v8 : (System_IO_FileInfo -> string) = _.LinkTarget
        let v9 : string = v8 v7
        let v10 : std_path_PathBuf = v9 |> unbox<std_path_PathBuf>
        let v11 : Result<std_path_PathBuf, std_io_Error> = Ok v10 
        v11
    else
        let v12 : string = $"file_system.read_link / Fsharp / "
        let v13 : string = $"The file or directory is not a reparse point. / "
        let v14 : string = v12 + v13 
        let v15 : string = $"path: {v0} / result: {v6} / path': {v2} / n: {v1}"
        let v16 : string = v14 + v15 
        let v17 : std_io_Error = v16 |> unbox<std_io_Error>
        let v18 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure7(v0)
        run_35(v0, v18, v1, v17, v2)
and closure8 (v0 : string, v1 : uint8) (v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    method34(v0, v1, v2)
and closure7 (v0 : string) (v1 : uint8) : (string -> Result<std_path_PathBuf, std_io_Error>) =
    closure8(v0, v1)
and run_44 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : std_io_Error) : Result<std_path_PathBuf, std_io_Error> =
    let v4 : string = get_file_name_36(v0)
    let v5 : string option = directory_get_parent_37(v0)
    let v6 : (string -> US3) = method4()
    let v7 : US3 option = v5 |> Option.map v6 
    let v8 : US3 = US3_None
    let v9 : US3 = v7 |> Option.defaultValue v8 
    let v10 : string = $"%A{v3}"
    let v11 : bool = v2 >= 11uy
    if v11 then
        let v12 : string = $"file_system.read_link / "
        let v13 : string = $"path: {v0} / n: {v2} / path': {v0} / name: {v4}"
        let v14 : string = v12 + v13 
        let v15 : std_io_Error = v14 |> unbox<std_io_Error>
        let v16 : Result<std_path_PathBuf, std_io_Error> = Error v15 
        v16
    else
        match v9 with
        | US3_Some(v17) -> (* Some *)
            let v18 : string = ""
            let v19 : bool = v0 <> v18 
            if v19 then
                let v20 : uint8 = v2 + 1uy
                let v21 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v20
                let v22 : Result<std_path_PathBuf, std_io_Error> = v21 v17
                let v23 : (std_path_PathBuf -> US6) = method38()
                let v24 : (std_io_Error -> US6) = method39()
                let v25 : US6 = match v22 with Ok x -> v23 x | Error x -> v24 x
                let v32 : US7 =
                    match v25 with
                    | US6_Error(v28) -> (* Error *)
                        let v29 : string = $"%A{v28}"
                        US7_Error(v29)
                    | US6_Ok(v26) -> (* Ok *)
                        US7_Ok(v26)
                let v38 : Result<std_path_PathBuf, string> =
                    match v32 with
                    | US7_Error(v35) -> (* Error *)
                        let v36 : Result<std_path_PathBuf, string> = Error v35 
                        v36
                    | US7_Ok(v33) -> (* Ok *)
                        let v34 : Result<std_path_PathBuf, string> = Ok v33 
                        v34
                let v39 : (std_path_PathBuf -> US7) = method40()
                let v40 : (string -> US7) = method41()
                let v41 : US7 = match v38 with Ok x -> v39 x | Error x -> v40 x
                match v41 with
                | US7_Error(v60) -> (* Error *)
                    let v61 : string = $"file_system.read_link / "
                    let v62 : string = $"error': {v60} / error: {v10} / name: {v4}"
                    let v63 : string = v61 + v62 
                    let v64 : std_io_Error = v63 |> unbox<std_io_Error>
                    let v65 : Result<std_path_PathBuf, std_io_Error> = Error v64 
                    v65
                | US7_Ok(v42) -> (* Ok *)
                    let v43 : std_path_Display = v42 |> unbox<std_path_Display>
                    let v44 : US8 = method42(v43)
                    let v50 : US3 =
                        match v44 with
                        | US8_Error(v47) -> (* Error *)
                            US3_None
                        | US8_Ok(v45) -> (* Ok *)
                            US3_Some(v45)
                    let v54 : string =
                        match v50 with
                        | US3_None -> (* None *)
                            failwith<string> "Option does not have a value."
                        | US3_Some(v51) -> (* Some *)
                            v51
                    let v55 : string = method43(v54, v4)
                    let v56 : Ref<Str> = v55 |> unbox<Ref<Str>>
                    let v57 : std_string_String = v56 |> unbox<std_string_String>
                    let v58 : std_path_PathBuf = v57 |> unbox<std_path_PathBuf>
                    let v59 : Result<std_path_PathBuf, std_io_Error> = Ok v58 
                    v59
            else
                let v68 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v69 : string = $"path: {v0} / error: {v10} / path': {v0} / name: {v4}"
                let v70 : string = v68 + v69 
                let v71 : std_io_Error = v70 |> unbox<std_io_Error>
                let v72 : Result<std_path_PathBuf, std_io_Error> = Error v71 
                v72
        | _ ->
            let v74 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v75 : string = $"path: {v0} / error: {v10} / path': {v0} / name: {v4}"
            let v76 : string = v74 + v75 
            let v77 : std_io_Error = v76 |> unbox<std_io_Error>
            let v78 : Result<std_path_PathBuf, std_io_Error> = Error v77 
            v78
and method30 (v0 : string, v1 : uint8) : Result<std_path_PathBuf, std_io_Error> =
    let v2 : System_IO_DirectoryInfo = v0 |> System_IO_DirectoryInfo 
    let v3 : System.IO.FileAttributes = directory_info_attributes_31(v2)
    let v4 : System.IO.FileAttributes = file_attributes_reparse_point_32()
    let v5 : bool = file_attributes_has_flag_33(v4, v3)
    if v5 then
        let v6 : System_IO_FileInfo = v0 |> System_IO_FileInfo 
        let v7 : (System_IO_FileInfo -> string) = _.LinkTarget
        let v8 : string = v7 v6
        let v9 : std_path_PathBuf = v8 |> unbox<std_path_PathBuf>
        let v10 : Result<std_path_PathBuf, std_io_Error> = Ok v9 
        v10
    else
        let v11 : string = $"file_system.read_link / Fsharp / "
        let v12 : string = $"The file or directory is not a reparse point. / "
        let v13 : string = v11 + v12 
        let v14 : string = $"path: {v0} / result: {v5} / path': {v0} / n: {v1}"
        let v15 : string = v13 + v14 
        let v16 : std_io_Error = v15 |> unbox<std_io_Error>
        let v17 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure7(v0)
        run_44(v0, v17, v1, v16)
and read_link_29 (v0 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v1 : uint8 = 0uy
    method30(v0, v1)
and closure17 () (v0 : std_path_PathBuf) : US9 =
    US9_Some(v0)
and method45 () : (std_path_PathBuf -> US9) =
    closure17()
and replace_regex_46 (v0 : string, v1 : string, v2 : string) : string =
    let v3 : string = System.Text.RegularExpressions.Regex.Replace (v2, v0, v1)
    v3
and normalize_path_28 (v0 : string) : string =
    let v1 : bool = v0 = ""
    if v1 then
        let v2 : string = ""
        v2
    else
        let v3 : Result<std_path_PathBuf, std_io_Error> = read_link_29(v0)
        let v4 : (std_path_PathBuf -> US6) = method38()
        let v5 : (std_io_Error -> US6) = method39()
        let v6 : US6 = match v3 with Ok x -> v4 x | Error x -> v5 x
        let v12 : US9 =
            match v6 with
            | US6_Error(v9) -> (* Error *)
                US9_None
            | US6_Ok(v7) -> (* Ok *)
                US9_Some(v7)
        let v17 : std_path_PathBuf option =
            match v12 with
            | US9_None -> (* None *)
                let v15 : std_path_PathBuf option = None
                v15
            | US9_Some(v13) -> (* Some *)
                let v14 : std_path_PathBuf option = Some v13 
                v14
        let v18 : (std_path_PathBuf -> US9) = method45()
        let v19 : US9 option = v17 |> Option.map v18 
        let v20 : US9 = US9_None
        let v21 : US9 = v19 |> Option.defaultValue v20 
        let v36 : string =
            match v21 with
            | US9_None -> (* None *)
                v0
            | US9_Some(v22) -> (* Some *)
                let v23 : std_path_Display = v22 |> unbox<std_path_Display>
                let v24 : US8 = method42(v23)
                let v30 : US3 =
                    match v24 with
                    | US8_Error(v27) -> (* Error *)
                        US3_None
                    | US8_Ok(v25) -> (* Ok *)
                        US3_Some(v25)
                match v30 with
                | US3_None -> (* None *)
                    failwith<string> "Option does not have a value."
                | US3_Some(v31) -> (* Some *)
                    v31
        let v37 : bool = v36 = ""
        let v38 : string =
            if v37 then
                v0
            else
                v36
        let v39 : string = "^\\\\\\\\\\?\\\\"
        let v40 : string = ""
        let v41 : string = replace_regex_46(v39, v40, v38)
        let v42 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v41))
        let v43 : bool = v42 < 2
        if v43 then
            v0
        else
            let v44 : string = (spiralStringSlice v41 (int 0) (int 0))
            let v45 : (unit -> string) = v44.ToLower
            let v46 : string = v45 ()
            let v47 : int32 = v42 - 1
            let v48 : string = (spiralStringSlice v41 (int 1) (int v47))
            let v49 : string = v46 + v48 
            let v50 : string = "\\"
            let v51 : string = "/"
            let v52 : string = v49.Replace (v50, v51)
            v52
and get_current_directory_47 () : string =
    let v0 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    v0 ()
and file_exists_50 (v0 : string) : bool =
    let v1 : (string -> bool) = System.IO.File.Exists
    v1 v0
and closure18 () (v0 : string) : bool =
    file_exists_50(v0)
and directory_exists_51 (v0 : string) : bool =
    let v1 : (string -> bool) = System.IO.Directory.Exists
    v1 v0
and closure19 () (v0 : string) : bool =
    directory_exists_51(v0)
and method53 (v0 : string, v1 : string, v2 : bool, v3 : (string -> bool), v4 : string) : US11 =
    let v5 : string = method43(v4, v0)
    let v6 : bool = v3 v5
    if v6 then
        US11_Ok(v4)
    else
        let v8 : string option = directory_get_parent_37(v4)
        let v9 : (string -> US3) = method4()
        let v10 : US3 option = v8 |> Option.map v9 
        let v11 : US3 = US3_None
        let v12 : US3 = v10 |> Option.defaultValue v11 
        match v12 with
        | US3_None -> (* None *)
            let v17 : string =
                if v2 then
                    let v15 : string = "file"
                    v15
                else
                    let v16 : string = "dir"
                    v16
            let v18 : string = "file_system.find_parent / No parent for "
            let v19 : string = v18 + v17 
            let v20 : string = $" '{v0}' at '{v1}' (until '{v4}')"
            let v21 : string = v19 + v20 
            US11_Error(v21)
        | US3_Some(v13) -> (* Some *)
            method53(v0, v1, v2, v3, v13)
and method52 (v0 : string, v1 : string, v2 : bool, v3 : (string -> bool)) : US11 =
    let v4 : string = method43(v1, v0)
    let v5 : bool = v3 v4
    if v5 then
        US11_Ok(v1)
    else
        let v7 : string option = directory_get_parent_37(v1)
        let v8 : (string -> US3) = method4()
        let v9 : US3 option = v7 |> Option.map v8 
        let v10 : US3 = US3_None
        let v11 : US3 = v9 |> Option.defaultValue v10 
        match v11 with
        | US3_None -> (* None *)
            let v16 : string =
                if v2 then
                    let v14 : string = "file"
                    v14
                else
                    let v15 : string = "dir"
                    v15
            let v17 : string = "file_system.find_parent / No parent for "
            let v18 : string = v17 + v16 
            let v19 : string = $" '{v0}' at '{v1}' (until '{v1}')"
            let v20 : string = v18 + v19 
            US11_Error(v20)
        | US3_Some(v12) -> (* Some *)
            method53(v0, v1, v2, v3, v12)
and find_parent_49 (v0 : US10, v1 : string, v2 : string) : US11 =
    let v3 : bool =
        match v0 with
        | US10_File -> (* File *)
            true
        | _ ->
            false
    let v6 : (string -> bool) =
        if v3 then
            closure18()
        else
            closure19()
    method52(v1, v2, v3, v6)
and method54 () : string =
    let v0 : string = "\u001b[93m"
    
    
    
    
    
    let v1 : string = "Warning"
    let v2 : (unit -> string) = v1.ToLower
    let v3 : string = v2 ()
    let v4 : char = (spiralStringIndex v3 (int 0))
    let v5 : string = format_real_10(v4)
    let v6 : string = v0 + v5 
    let v7 : string = "\u001b[0m"
    let v8 : string = v6 + v7 
    v8
and method55 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_14(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "file_system.get_workspace_root"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "dir"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : string = v26 + v8 
    let v28 : string = "; "
    let v29 : string = v27 + v28 
    let v30 : string = "error"
    let v31 : string = v29 + v30 
    let v32 : string = v31 + v25 
    let v33 : string = v32 + v9 
    let v34 : string = "{ "
    let v35 : string = v34 + v33 
    let v36 : string = " }"
    let v37 : string = v35 + v36 
    let v38 : string = v20 + v37 
    method17(v38)
and run_48 (v0 : string) : US3 =
    let v1 : US10 = US10_Directory
    let v2 : string = "spiral"
    let v3 : string = "workspace"
    let v4 : string = method43(v2, v3)
    let v5 : US11 = find_parent_49(v1, v4, v0)
    match v5 with
    | US11_Error(v9) -> (* Error *)
        let v10 : bool = TraceState.trace_state.IsNone
        if v10 then
            let v11 : US0 = US0_Verbose
            let struct (v12 : Mut0, v13 : Mut1, v14 : Mut2, v15 : Mut3, v16 : Mut4, v17 : int64 option) = new_trace_state_1(v11)
            let v18 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v12, v13, v14, v15, v16, v17) 
            TraceState.trace_state <- v18 
            ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v25 : US0 = v23.l0
        let v30 : int32 =
            match v25 with
            | US0_Critical -> (* Critical *)
                50
            | US0_Debug -> (* Debug *)
                20
            | US0_Info -> (* Info *)
                30
            | US0_Verbose -> (* Verbose *)
                10
            | US0_Warning -> (* Warning *)
                40
        let v31 : bool = v21.l0
        let v32 : bool = v31 = false
        let v34 : bool =
            if v32 then
                false
            else
                let v33 : bool = 40 >= v30
                v33
        let v35 : bool = v34 = false
        let v75 : US4 =
            if v35 then
                US4_None
            else
                let v37 : bool = TraceState.trace_state.IsNone
                if v37 then
                    let v38 : US0 = US0_Verbose
                    let struct (v39 : Mut0, v40 : Mut1, v41 : Mut2, v42 : Mut3, v43 : Mut4, v44 : int64 option) = new_trace_state_1(v38)
                    let v45 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v39, v40, v41, v42, v43, v44) 
                    TraceState.trace_state <- v45 
                    ()
                let struct (v46 : Mut0, v47 : Mut1, v48 : Mut2, v49 : Mut3, v50 : Mut4, v51 : int64 option) = TraceState.trace_state.Value
                let v52 : string = method6(v46, v47, v48, v49, v50, v51)
                let v53 : string = method54()
                let v54 : string = method55(v46, v47, v48, v49, v50, v51, v52, v53, v0, v9)
                let v55 : bool = TraceState.trace_state.IsNone
                if v55 then
                    let v56 : US0 = US0_Verbose
                    let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = new_trace_state_1(v56)
                    let v63 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v57, v58, v59, v60, v61, v62) 
                    TraceState.trace_state <- v63 
                    ()
                let struct (v64 : Mut0, v65 : Mut1, v66 : Mut2, v67 : Mut3, v68 : Mut4, v69 : int64 option) = TraceState.trace_state.Value
                let v70 : int64 = v64.l0
                let v71 : int64 = v70 + 1L
                v64.l0 <- v71
                let v72 : (string -> unit) = closure5()
                v72 v54
                let v73 : (string -> unit) = v65.l0
                v73 v54
                US4_Some(v64, v65, v66, v67, v68, v69)
        US3_None
    | US11_Ok(v6) -> (* Ok *)
        let v7 : string = normalize_path_28(v6)
        US3_Some(v7)
and get_full_path_56 (v0 : string) : string =
    let v1 : (string -> string) = System.IO.Path.GetFullPath
    v1 v0
and method57 () : string =
    let v0 : string = "\u001b[94m"
    
    
    
    
    
    let v1 : string = "Debug"
    let v2 : (unit -> string) = v1.ToLower
    let v3 : string = v2 ()
    let v4 : char = (spiralStringIndex v3 (int 0))
    let v5 : string = format_real_10(v4)
    let v6 : string = v0 + v5 
    let v7 : string = "\u001b[0m"
    let v8 : string = v6 + v7 
    v8
and method59 (v0 : US3) : string =
    match v0 with
    | US3_None -> (* None *)
        let v8 : string = "None"
        v8
    | US3_Some(v1) -> (* Some *)
        let v2 : string = "Some"
        let v3 : string = "("
        let v4 : string = v2 + v3 
        let v5 : string = v4 + v1 
        let v6 : string = ")"
        let v7 : string = v5 + v6 
        v7
and format_real_60 (v0 : bool) : string =
    let v1 : string = method11()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v5 : string =
        if v0 then
            let v3 : string = "true"
            v3
        else
            let v4 : string = "false"
            v4
    method12(v2, v5)
    let v6 : string = v2.l0
    v6
and method58 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : string, v12 : US3, v13 : bool) : string =
    let v14 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v17 : string = format_real_14(v14)
    let v18 : string = v16 + v17 
    let v19 : string = v18 + v7 
    let v20 : string = v19 + v15 
    let v21 : string = "documents.run"
    let v22 : string = v20 + v21 
    let v23 : string = " / "
    let v24 : string = v22 + v23 
    let v25 : string = ""
    let v26 : string = v25 + v25 
    let v27 : string = "source_dir"
    let v28 : string = v26 + v27 
    let v29 : string = " = "
    let v30 : string = v28 + v29 
    let v31 : string = v30 + v8 
    let v32 : string = "; "
    let v33 : string = v31 + v32 
    let v34 : string = "dist_dir"
    let v35 : string = v33 + v34 
    let v36 : string = v35 + v29 
    let v37 : string = v36 + v9 
    let v38 : string = v37 + v32 
    let v39 : string = "cache_dir"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v29 
    let v42 : string = v41 + v10 
    let v43 : string = v42 + v32 
    let v44 : string = "hangul_spec"
    let v45 : string = v43 + v44 
    let v46 : string = v45 + v29 
    let v47 : string = v46 + v11 
    let v48 : string = v47 + v32 
    let v49 : string = "filter"
    let v50 : string = v48 + v49 
    let v51 : string = v50 + v29 
    let v52 : string = method59(v12)
    let v53 : string = v51 + v52 
    let v54 : string = v53 + v32 
    let v55 : string = "transcribe_only"
    let v56 : string = v54 + v55 
    let v57 : string = v56 + v29 
    let v58 : string = format_real_60(v13)
    let v59 : string = v57 + v58 
    let v60 : string = "{ "
    let v61 : string = v60 + v59 
    let v62 : string = " }"
    let v63 : string = v61 + v62 
    let v64 : string = v24 + v63 
    method17(v64)
and ok_c21 () (v0 : std_fs_FileType) : US12 =
    US12_Ok(v0)
and method61 () : (std_fs_FileType -> US12) =
    ok_c21()
and error_c22 () (v0 : std_io_Error) : US12 =
    US12_Error(v0)
and method62 () : (std_io_Error -> US12) =
    error_c22()
and ok_c23 () (v0 : std_fs_FileType) : US13 =
    US13_Ok(v0)
and method63 () : (std_fs_FileType -> US13) =
    ok_c23()
and error_c24 () (v0 : std_string_String) : US13 =
    US13_Error(v0)
and method64 () : (std_string_String -> US13) =
    error_c24()
and fn_c20 (v0 : US3) (v1 : async_walkdir_DirEntry) : std_pin_Pin<Box<Dyn<std_future_Future<async_walkdir_Filtering>>>> =
    let v2 : string = "true; let __future_init = Box::pin(/*"
    let v3 : bool = __spiral_emit_rust () v2 
    let v4 : string = "*/ async { /*"
    let v5 : bool = __spiral_emit_rust () v4 
    let v6 : string = "*/ ()"
    let v7 : bool = __spiral_emit_rust () v6 
    let v8 : string = "true; let __future_init = Box::pin(/*"
    let v9 : bool = __spiral_emit_rust () v8 
    let v10 : string = "*/ async move { /*"
    let v11 : bool = __spiral_emit_rust () v10 
    let v12 : string = "*/ ()"
    let v13 : bool = __spiral_emit_rust () v12 
    let v14 : string = "$0"
    let v15 : async_walkdir_DirEntry = __spiral_emit_rust v1 v14 
    let v16 : string = "Box::pin(async_walkdir::DirEntry::file_type(&v15))"
    let v17 : std_pin_Pin<Box<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>>> = __spiral_emit_rust () v16 
    let v18 : string = "v17.await"
    let v19 : Result<std_fs_FileType, std_io_Error> = __spiral_emit_rust () v18 
    let v20 : (std_fs_FileType -> US12) = method61()
    let v21 : (std_io_Error -> US12) = method62()
    let v22 : US12 = match v19 with Ok x -> v20 x | Error x -> v21 x
    let v29 : US13 =
        match v22 with
        | US12_Error(v25) -> (* Error *)
            let v26 : std_string_String = null |> unbox<std_string_String>
            US13_Error(v26)
        | US12_Ok(v23) -> (* Ok *)
            US13_Ok(v23)
    let v35 : Result<std_fs_FileType, std_string_String> =
        match v29 with
        | US13_Error(v32) -> (* Error *)
            let v33 : Result<std_fs_FileType, std_string_String> = Error v32 
            v33
        | US13_Ok(v30) -> (* Ok *)
            let v31 : Result<std_fs_FileType, std_string_String> = Ok v30 
            v31
    let v36 : (std_fs_FileType -> US13) = method63()
    let v37 : (std_string_String -> US13) = method64()
    let v38 : US13 = match v35 with Ok x -> v36 x | Error x -> v37 x
    let v86 : US14 =
        match v38 with
        | US13_Ok(v39) -> (* Ok *)
            let v40 : string = "std::fs::FileType::is_dir(&$0)"
            let v41 : bool = __spiral_emit_rust v39 v40 
            if v41 then
                US14_Ignore
            else
                let v43 : string = "async_walkdir::DirEntry::path(&$0)"
                let v44 : std_path_PathBuf = __spiral_emit_rust v1 v43 
                let v45 : std_path_Display = v44 |> unbox<std_path_Display>
                let v46 : std_string_String = null |> unbox<std_string_String>
                let v47 : string = "Fsharp"
                let v48 : string = () // backend.backend_switch / record_type_try_find / key: v47 
                let v49 : string = ".md"
                let v50 : bool = v48.EndsWith (v49, false, null)
                let v51 : bool = v50 = false
                let v57 : bool =
                    if v51 then
                        true
                    else
                        match v0 with
                        | US3_None -> (* None *)
                            false
                        | US3_Some(v52) -> (* Some *)
                            let v53 : bool = v48.Contains v52 
                            let v54 : bool = v53 = false
                            v54
                let v60 : bool =
                    if v57 then
                        true
                    else
                        let v58 : string = ".hangul.md"
                        let v59 : bool = v48.EndsWith (v58, false, null)
                        v59
                if v60 then
                    US14_Ignore
                else
                    US14_Continue
        | _ ->
            let v65 : string = "async_walkdir::DirEntry::path(&$0)"
            let v66 : std_path_PathBuf = __spiral_emit_rust v1 v65 
            let v67 : std_path_Display = v66 |> unbox<std_path_Display>
            let v68 : std_string_String = null |> unbox<std_string_String>
            let v69 : string = "Fsharp"
            let v70 : string = () // backend.backend_switch / record_type_try_find / key: v69 
            let v71 : string = ".md"
            let v72 : bool = v70.EndsWith (v71, false, null)
            let v73 : bool = v72 = false
            let v79 : bool =
                if v73 then
                    true
                else
                    match v0 with
                    | US3_None -> (* None *)
                        false
                    | US3_Some(v74) -> (* Some *)
                        let v75 : bool = v70.Contains v74 
                        let v76 : bool = v75 = false
                        v76
            let v82 : bool =
                if v79 then
                    true
                else
                    let v80 : string = ".hangul.md"
                    let v81 : bool = v70.EndsWith (v80, false, null)
                    v81
            if v82 then
                US14_Ignore
            else
                US14_Continue
    let v87 : string = "Fsharp"
    () // backend.backend_switch / record_type_try_find / key: v87 
    let v88 : string = "__future_init"
    let v89 : _ = __spiral_emit_rust () v88 
    let v90 : string = "v89"
    let v91 : std_pin_Pin<Box<Dyn<std_future_Future<US14>>>> = __spiral_emit_rust () v90 
    let v92 : string = "v91.await"
    let v93 : US14 = __spiral_emit_rust () v92 
    let v102 : async_walkdir_Filtering =
        match v93 with
        | US14_Continue -> (* Continue *)
            let v98 : string = "async_walkdir::Filtering::Continue"
            let v99 : async_walkdir_Filtering = __spiral_emit_rust () v98 
            v99
        | US14_Ignore -> (* Ignore *)
            let v94 : string = "async_walkdir::Filtering::Ignore"
            let v95 : async_walkdir_Filtering = __spiral_emit_rust () v94 
            v95
        | US14_IgnoreDir -> (* IgnoreDir *)
            let v96 : string = "async_walkdir::Filtering::IgnoreDir"
            let v97 : async_walkdir_Filtering = __spiral_emit_rust () v96 
            v97
    () // backend.backend_switch / record_type_try_find / key: v87 
    let v103 : string = "__future_init"
    let v104 : _ = __spiral_emit_rust () v103 
    let v105 : string = "v104"
    let v106 : std_pin_Pin<Box<Dyn<std_future_Future<async_walkdir_Filtering>>>> = __spiral_emit_rust () v105 
    v106
and ok_c26 () (v0 : async_walkdir_DirEntry) : US15 =
    US15_Ok(v0)
and method66 () : (async_walkdir_DirEntry -> US15) =
    ok_c26()
and error_c27 () (v0 : async_walkdir_Error) : US15 =
    US15_Error(v0)
and method67 () : (async_walkdir_Error -> US15) =
    error_c27()
and ok_c28 () (v0 : async_walkdir_DirEntry) : US16 =
    US16_Ok(v0)
and method68 () : (async_walkdir_DirEntry -> US16) =
    ok_c28()
and error_c29 () (v0 : std_string_String) : US16 =
    US16_Error(v0)
and method69 () : (std_string_String -> US16) =
    error_c29()
and method70 () : string =
    let v0 : string = "\u001b[91m"
    
    
    
    
    
    let v1 : string = "Critical"
    let v2 : (unit -> string) = v1.ToLower
    let v3 : string = v2 ()
    let v4 : char = (spiralStringIndex v3 (int 0))
    let v5 : string = format_real_10(v4)
    let v6 : string = v0 + v5 
    let v7 : string = "\u001b[0m"
    let v8 : string = v6 + v7 
    v8
and method71 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : int64 = v0.l0
    let v10 : string = " "
    let v11 : string = v6 + v10 
    let v12 : string = format_real_14(v9)
    let v13 : string = v11 + v12 
    let v14 : string = v13 + v7 
    let v15 : string = v14 + v10 
    let v16 : string = "documents.run / stream_filter_map"
    let v17 : string = v15 + v16 
    let v18 : string = " / "
    let v19 : string = v17 + v18 
    let v20 : string = ""
    let v21 : string = v20 + v20 
    let v22 : string = "error"
    let v23 : string = v21 + v22 
    let v24 : string = " = "
    let v25 : string = v23 + v24 
    let v26 : string = $"%A{v8}"
    let v27 : string = v25 + v26 
    let v28 : string = "{ "
    let v29 : string = v28 + v27 
    let v30 : string = " }"
    let v31 : string = v29 + v30 
    let v32 : string = v19 + v31 
    method17(v32)
and closure25 () (v0 : Result<async_walkdir_DirEntry, async_walkdir_Error>) : string option =
    let v1 : (async_walkdir_DirEntry -> US15) = method66()
    let v2 : (async_walkdir_Error -> US15) = method67()
    let v3 : US15 = match v0 with Ok x -> v1 x | Error x -> v2 x
    let v10 : US16 =
        match v3 with
        | US15_Error(v6) -> (* Error *)
            let v7 : std_string_String = null |> unbox<std_string_String>
            US16_Error(v7)
        | US15_Ok(v4) -> (* Ok *)
            US16_Ok(v4)
    let v16 : Result<async_walkdir_DirEntry, std_string_String> =
        match v10 with
        | US16_Error(v13) -> (* Error *)
            let v14 : Result<async_walkdir_DirEntry, std_string_String> = Error v13 
            v14
        | US16_Ok(v11) -> (* Ok *)
            let v12 : Result<async_walkdir_DirEntry, std_string_String> = Ok v11 
            v12
    let v17 : (async_walkdir_DirEntry -> US16) = method68()
    let v18 : (std_string_String -> US16) = method69()
    let v19 : US16 = match v16 with Ok x -> v17 x | Error x -> v18 x
    let v97 : US3 =
        match v19 with
        | US16_Error(v28) -> (* Error *)
            let v29 : bool = TraceState.trace_state.IsNone
            if v29 then
                let v30 : US0 = US0_Verbose
                let struct (v31 : Mut0, v32 : Mut1, v33 : Mut2, v34 : Mut3, v35 : Mut4, v36 : int64 option) = new_trace_state_1(v30)
                let v37 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v31, v32, v33, v34, v35, v36) 
                TraceState.trace_state <- v37 
                ()
            let struct (v38 : Mut0, v39 : Mut1, v40 : Mut2, v41 : Mut3, v42 : Mut4, v43 : int64 option) = TraceState.trace_state.Value
            let v44 : US0 = v42.l0
            let v49 : int32 =
                match v44 with
                | US0_Critical -> (* Critical *)
                    50
                | US0_Debug -> (* Debug *)
                    20
                | US0_Info -> (* Info *)
                    30
                | US0_Verbose -> (* Verbose *)
                    10
                | US0_Warning -> (* Warning *)
                    40
            let v50 : bool = v40.l0
            let v51 : bool = v50 = false
            let v53 : bool =
                if v51 then
                    false
                else
                    let v52 : bool = 50 >= v49
                    v52
            let v54 : bool = v53 = false
            let v94 : US4 =
                if v54 then
                    US4_None
                else
                    let v56 : bool = TraceState.trace_state.IsNone
                    if v56 then
                        let v57 : US0 = US0_Verbose
                        let struct (v58 : Mut0, v59 : Mut1, v60 : Mut2, v61 : Mut3, v62 : Mut4, v63 : int64 option) = new_trace_state_1(v57)
                        let v64 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v58, v59, v60, v61, v62, v63) 
                        TraceState.trace_state <- v64 
                        ()
                    let struct (v65 : Mut0, v66 : Mut1, v67 : Mut2, v68 : Mut3, v69 : Mut4, v70 : int64 option) = TraceState.trace_state.Value
                    let v71 : string = method6(v65, v66, v67, v68, v69, v70)
                    let v72 : string = method70()
                    let v73 : string = method71(v65, v66, v67, v68, v69, v70, v71, v72, v28)
                    let v74 : bool = TraceState.trace_state.IsNone
                    if v74 then
                        let v75 : US0 = US0_Verbose
                        let struct (v76 : Mut0, v77 : Mut1, v78 : Mut2, v79 : Mut3, v80 : Mut4, v81 : int64 option) = new_trace_state_1(v75)
                        let v82 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v76, v77, v78, v79, v80, v81) 
                        TraceState.trace_state <- v82 
                        ()
                    let struct (v83 : Mut0, v84 : Mut1, v85 : Mut2, v86 : Mut3, v87 : Mut4, v88 : int64 option) = TraceState.trace_state.Value
                    let v89 : int64 = v83.l0
                    let v90 : int64 = v89 + 1L
                    v83.l0 <- v90
                    let v91 : (string -> unit) = closure5()
                    v91 v73
                    let v92 : (string -> unit) = v84.l0
                    v92 v73
                    US4_Some(v83, v84, v85, v86, v87, v88)
            US3_None
        | US16_Ok(v20) -> (* Ok *)
            let v21 : string = "async_walkdir::DirEntry::path(&$0)"
            let v22 : std_path_PathBuf = __spiral_emit_rust v20 v21 
            let v23 : std_path_Display = v22 |> unbox<std_path_Display>
            let v24 : std_string_String = null |> unbox<std_string_String>
            let v25 : string = "Fsharp"
            let v26 : string = () // backend.backend_switch / record_type_try_find / key: v25 
            US3_Some(v26)
    match v97 with
    | US3_None -> (* None *)
        let v100 : string option = None
        v100
    | US3_Some(v98) -> (* Some *)
        let v99 : string option = Some v98 
        v99
and method65 () : (Result<async_walkdir_DirEntry, async_walkdir_Error> -> string option) =
    closure25()
and method72 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : unativeint) : string =
    let v9 : int64 = v0.l0
    let v10 : string = " "
    let v11 : string = v6 + v10 
    let v12 : string = format_real_14(v9)
    let v13 : string = v11 + v12 
    let v14 : string = v13 + v7 
    let v15 : string = v14 + v10 
    let v16 : string = "documents.run"
    let v17 : string = v15 + v16 
    let v18 : string = " / "
    let v19 : string = v17 + v18 
    let v20 : string = ""
    let v21 : string = v20 + v20 
    let v22 : string = "files_len"
    let v23 : string = v21 + v22 
    let v24 : string = " = "
    let v25 : string = v23 + v24 
    let v26 : string = $"%A{v8}"
    let v27 : string = v25 + v26 
    let v28 : string = "{ "
    let v29 : string = v28 + v27 
    let v30 : string = " }"
    let v31 : string = v29 + v30 
    let v32 : string = v19 + v31 
    method17(v32)
and method74 () : string =
    let v0 : string = ""
    v0
and standardize_path_75 (v0 : string) : string =
    let v1 : string = get_full_path_56(v0)
    normalize_path_28(v1)
and method77 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : bool) : string =
    v0
and format_real_79 (v0 : int32) : string =
    let v1 : string = method11()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    method12(v2, v3)
    let v4 : string = v2.l0
    v4
and closure30 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = ""
    let v7 : string = v6 + v6 
    let v8 : string = "c"
    let v9 : string = v7 + v8 
    let v10 : string = " = "
    let v11 : string = v9 + v10 
    let v12 : char = '"'
    let v13 : string = format_real_10(v12)
    let v14 : string = v11 + v13 
    let v15 : string = "; "
    let v16 : string = v14 + v15 
    let v17 : string = "s'"
    let v18 : string = v16 + v17 
    let v19 : string = v18 + v10 
    let v20 : string = v6 + v6 
    let v21 : string = "line_start"
    let v22 : string = v20 + v21 
    let v23 : string = v22 + v10 
    let v24 : string = format_real_79(v2)
    let v25 : string = v23 + v24 
    let v26 : string = v25 + v15 
    let v27 : string = "position"
    let v28 : string = v26 + v27 
    let v29 : string = v28 + v10 
    let v30 : string = v6 + v6 
    let v31 : string = "line"
    let v32 : string = v30 + v31 
    let v33 : string = v32 + v10 
    let v34 : string = format_real_79(v3)
    let v35 : string = v33 + v34 
    let v36 : string = v35 + v15 
    let v37 : string = "col"
    let v38 : string = v36 + v37 
    let v39 : string = v38 + v10 
    let v40 : string = format_real_79(v4)
    let v41 : string = v39 + v40 
    let v42 : string = "{ "
    let v43 : string = v42 + v41 
    let v44 : string = " }"
    let v45 : string = v43 + v44 
    let v46 : string = v29 + v45 
    let v47 : string = v46 + v15 
    let v48 : string = "text_length"
    let v49 : string = v47 + v48 
    let v50 : string = v49 + v10 
    let v51 : string = format_real_79(v5)
    let v52 : string = v50 + v51 
    let v53 : string = v42 + v52 
    let v54 : string = v53 + v44 
    let v55 : string = v19 + v54 
    let v56 : string = v42 + v55 
    let v57 : string = v56 + v44 
    let v58 : string = "parsing.p_char / unexpected end of text / "
    let v59 : string = v58 + v57 
    v59
and method80 (v0 : string, v1 : int32, v2 : int32) : int32 =
    let v3 : bool = v2 >= v1
    if v3 then
        v2
    else
        let v4 : char = (spiralStringIndex v0 (int v2))
        let v5 : bool = '\n' = v4
        let v6 : bool = v5 <> true
        if v6 then
            let v7 : int32 = v2 + 1
            method80(v0, v1, v7)
        else
            v2
and closure32 (v0 : int32, v1 : int32) (v2 : string) : string =
    let v3 : bool = v1 >= v0
    if v3 then
        v2
    else
        let v4 : int32 = v1 + 1
        let v5 : (string -> string) = method81(v0, v4)
        let v6 : string = " "
        let v7 : string = v2 + v6 
        v5 v7
and method81 (v0 : int32, v1 : int32) : (string -> string) =
    closure32(v0, v1)
and closure31 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v0))
    let v7 : int32 = method80(v0, v6, v1)
    let v8 : int32 = v1 + 80
    let v9 : bool = v7 < v8
    let v10 : int32 =
        if v9 then
            v7
        else
            v8
    let v11 : bool = v2 >= v10
    let v16 : string =
        if v11 then
            let v12 : string = ""
            v12
        else
            let v13 : bool = v2 = v10
            let v14 : int32 = v10 - 1
            let v15 : string = (spiralStringSlice v0 (int v2) (int v14))
            v15
    let v17 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v16))
    let v18 : bool = v17 > 0
    let v22 : bool =
        if v18 then
            let v19 : int32 = v17 - 1
            let v20 : char = (spiralStringIndex v16 (int v19))
            let v21 : bool = v20 = '\n'
            v21
        else
            false
    let v25 : string =
        if v22 then
            let v23 : string = ""
            v23
        else
            let v24 : string = "\n"
            v24
    let v26 : int32 = v4 - 1
    let v27 : int32 = 0
    let v28 : (string -> string) = method81(v26, v27)
    let v29 : string = ""
    let v30 : string = v28 v29
    let v31 : string = "^"
    let v32 : string = v30 + v31 
    let v33 : string = v29 + v29 
    let v34 : string = "expected"
    let v35 : string = v33 + v34 
    let v36 : string = " = "
    let v37 : string = v35 + v36 
    let v38 : char = '"'
    let v39 : string = format_real_10(v38)
    let v40 : string = v37 + v39 
    let v41 : string = "; "
    let v42 : string = v40 + v41 
    let v43 : string = "line"
    let v44 : string = v42 + v43 
    let v45 : string = v44 + v36 
    let v46 : string = format_real_79(v3)
    let v47 : string = v45 + v46 
    let v48 : string = v47 + v41 
    let v49 : string = "col"
    let v50 : string = v48 + v49 
    let v51 : string = v50 + v36 
    let v52 : string = format_real_79(v4)
    let v53 : string = v51 + v52 
    let v54 : string = "{ "
    let v55 : string = v54 + v53 
    let v56 : string = " }"
    let v57 : string = v55 + v56 
    let v58 : string = "parsing.p_char / "
    let v59 : string = v58 + v57 
    let v60 : string = "\n"
    let v61 : string = v59 + v60 
    let v62 : string = v61 + v16 
    let v63 : string = v62 + v25 
    let v64 : string = v63 + v32 
    let v65 : string = v64 + v60 
    v65
and closure33 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = ""
    let v7 : string = v6 + v6 
    let v8 : string = "c"
    let v9 : string = v7 + v8 
    let v10 : string = " = "
    let v11 : string = v9 + v10 
    let v12 : char = '''
    let v13 : string = format_real_10(v12)
    let v14 : string = v11 + v13 
    let v15 : string = "; "
    let v16 : string = v14 + v15 
    let v17 : string = "s'"
    let v18 : string = v16 + v17 
    let v19 : string = v18 + v10 
    let v20 : string = v6 + v6 
    let v21 : string = "line_start"
    let v22 : string = v20 + v21 
    let v23 : string = v22 + v10 
    let v24 : string = format_real_79(v2)
    let v25 : string = v23 + v24 
    let v26 : string = v25 + v15 
    let v27 : string = "position"
    let v28 : string = v26 + v27 
    let v29 : string = v28 + v10 
    let v30 : string = v6 + v6 
    let v31 : string = "line"
    let v32 : string = v30 + v31 
    let v33 : string = v32 + v10 
    let v34 : string = format_real_79(v3)
    let v35 : string = v33 + v34 
    let v36 : string = v35 + v15 
    let v37 : string = "col"
    let v38 : string = v36 + v37 
    let v39 : string = v38 + v10 
    let v40 : string = format_real_79(v4)
    let v41 : string = v39 + v40 
    let v42 : string = "{ "
    let v43 : string = v42 + v41 
    let v44 : string = " }"
    let v45 : string = v43 + v44 
    let v46 : string = v29 + v45 
    let v47 : string = v46 + v15 
    let v48 : string = "text_length"
    let v49 : string = v47 + v48 
    let v50 : string = v49 + v10 
    let v51 : string = format_real_79(v5)
    let v52 : string = v50 + v51 
    let v53 : string = v42 + v52 
    let v54 : string = v53 + v44 
    let v55 : string = v19 + v54 
    let v56 : string = v42 + v55 
    let v57 : string = v56 + v44 
    let v58 : string = "parsing.p_char / unexpected end of text / "
    let v59 : string = v58 + v57 
    v59
and closure34 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v0))
    let v7 : int32 = method80(v0, v6, v1)
    let v8 : int32 = v1 + 80
    let v9 : bool = v7 < v8
    let v10 : int32 =
        if v9 then
            v7
        else
            v8
    let v11 : bool = v2 >= v10
    let v16 : string =
        if v11 then
            let v12 : string = ""
            v12
        else
            let v13 : bool = v2 = v10
            let v14 : int32 = v10 - 1
            let v15 : string = (spiralStringSlice v0 (int v2) (int v14))
            v15
    let v17 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v16))
    let v18 : bool = v17 > 0
    let v22 : bool =
        if v18 then
            let v19 : int32 = v17 - 1
            let v20 : char = (spiralStringIndex v16 (int v19))
            let v21 : bool = v20 = '\n'
            v21
        else
            false
    let v25 : string =
        if v22 then
            let v23 : string = ""
            v23
        else
            let v24 : string = "\n"
            v24
    let v26 : int32 = v4 - 1
    let v27 : int32 = 0
    let v28 : (string -> string) = method81(v26, v27)
    let v29 : string = ""
    let v30 : string = v28 v29
    let v31 : string = "^"
    let v32 : string = v30 + v31 
    let v33 : string = v29 + v29 
    let v34 : string = "expected"
    let v35 : string = v33 + v34 
    let v36 : string = " = "
    let v37 : string = v35 + v36 
    let v38 : char = '''
    let v39 : string = format_real_10(v38)
    let v40 : string = v37 + v39 
    let v41 : string = "; "
    let v42 : string = v40 + v41 
    let v43 : string = "line"
    let v44 : string = v42 + v43 
    let v45 : string = v44 + v36 
    let v46 : string = format_real_79(v3)
    let v47 : string = v45 + v46 
    let v48 : string = v47 + v41 
    let v49 : string = "col"
    let v50 : string = v48 + v49 
    let v51 : string = v50 + v36 
    let v52 : string = format_real_79(v4)
    let v53 : string = v51 + v52 
    let v54 : string = "{ "
    let v55 : string = v54 + v53 
    let v56 : string = " }"
    let v57 : string = v55 + v56 
    let v58 : string = "parsing.p_char / "
    let v59 : string = v58 + v57 
    let v60 : string = "\n"
    let v61 : string = v59 + v60 
    let v62 : string = v61 + v16 
    let v63 : string = v62 + v25 
    let v64 : string = v63 + v32 
    let v65 : string = v64 + v60 
    v65
and closure35 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = "parsing.choice / no parsers succeeded"
    v6
and method82 (v0 : (char [])) : string =
    let v1 : uint64 = System.Convert.ToUInt64 v0.Length
    let v2 : uint64 = 0UL
    let v3 : Mut6 = {l0 = v2} : Mut6
    let v4 : string = ""
    let v5 : Mut3 = {l0 = v4} : Mut3
    while method16(v1, v3) do
        let v7 : uint64 = v3.l0
        let v8 : char = v0.[int v7]
        let v9 : string = format_real_10(v8)
        let v10 : bool = v7 = 0UL
        let v15 : string =
            if v10 then
                v9
            else
                let v11 : string = v5.l0
                let v12 : string = ", "
                let v13 : string = v11 + v12 
                let v14 : string = v13 + v9 
                v14
        v5.l0 <- v15
        let v16 : uint64 = v7 + 1UL
        v3.l0 <- v16
        ()
    let v17 : string = v5.l0
    let v18 : string = "["
    let v19 : string = v18 + v17 
    let v20 : string = "]"
    let v21 : string = v19 + v20 
    v21
and closure36 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : char list = []
    let v7 : char list = ''' :: v6 
    let v8 : char list = '"' :: v7 
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v11 : string = method82(v10)
    let v12 : string = ""
    let v13 : string = v12 + v12 
    let v14 : string = "chars'"
    let v15 : string = v13 + v14 
    let v16 : string = " = "
    let v17 : string = v15 + v16 
    let v18 : string = v17 + v11 
    let v19 : string = "; "
    let v20 : string = v18 + v19 
    let v21 : string = "s"
    let v22 : string = v20 + v21 
    let v23 : string = v22 + v16 
    let v24 : string = v12 + v12 
    let v25 : string = "line_start"
    let v26 : string = v24 + v25 
    let v27 : string = v26 + v16 
    let v28 : string = format_real_79(v2)
    let v29 : string = v27 + v28 
    let v30 : string = v29 + v19 
    let v31 : string = "position"
    let v32 : string = v30 + v31 
    let v33 : string = v32 + v16 
    let v34 : string = v12 + v12 
    let v35 : string = "line"
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v16 
    let v38 : string = format_real_79(v3)
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v19 
    let v41 : string = "col"
    let v42 : string = v40 + v41 
    let v43 : string = v42 + v16 
    let v44 : string = format_real_79(v4)
    let v45 : string = v43 + v44 
    let v46 : string = "{ "
    let v47 : string = v46 + v45 
    let v48 : string = " }"
    let v49 : string = v47 + v48 
    let v50 : string = v33 + v49 
    let v51 : string = v50 + v19 
    let v52 : string = "text_length"
    let v53 : string = v51 + v52 
    let v54 : string = v53 + v16 
    let v55 : string = format_real_79(v5)
    let v56 : string = v54 + v55 
    let v57 : string = v46 + v56 
    let v58 : string = v57 + v48 
    let v59 : string = v23 + v58 
    let v60 : string = v46 + v59 
    let v61 : string = v60 + v48 
    let v62 : string = "parsing.none_of / unexpected end of text / "
    let v63 : string = v62 + v61 
    v63
and closure37 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : char = (spiralStringIndex v0 (int v1))
    let v7 : char list = []
    let v8 : char list = ''' :: v7 
    let v9 : char list = '"' :: v8 
    let v10 : (char list -> (char [])) = List.toArray
    let v11 : (char []) = v10 v9
    let v12 : string = method82(v11)
    let v13 : string = ""
    let v14 : string = v13 + v13 
    let v15 : string = "first_char"
    let v16 : string = v14 + v15 
    let v17 : string = " = "
    let v18 : string = v16 + v17 
    let v19 : string = format_real_10(v6)
    let v20 : string = v18 + v19 
    let v21 : string = "; "
    let v22 : string = v20 + v21 
    let v23 : string = "chars'"
    let v24 : string = v22 + v23 
    let v25 : string = v24 + v17 
    let v26 : string = v25 + v12 
    let v27 : string = v26 + v21 
    let v28 : string = "s"
    let v29 : string = v27 + v28 
    let v30 : string = v29 + v17 
    let v31 : string = v13 + v13 
    let v32 : string = "line_start"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v17 
    let v35 : string = format_real_79(v2)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v21 
    let v38 : string = "position"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v17 
    let v41 : string = v13 + v13 
    let v42 : string = "line"
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v17 
    let v45 : string = format_real_79(v3)
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v21 
    let v48 : string = "col"
    let v49 : string = v47 + v48 
    let v50 : string = v49 + v17 
    let v51 : string = format_real_79(v4)
    let v52 : string = v50 + v51 
    let v53 : string = "{ "
    let v54 : string = v53 + v52 
    let v55 : string = " }"
    let v56 : string = v54 + v55 
    let v57 : string = v40 + v56 
    let v58 : string = v57 + v21 
    let v59 : string = "text_length"
    let v60 : string = v58 + v59 
    let v61 : string = v60 + v17 
    let v62 : string = format_real_79(v5)
    let v63 : string = v61 + v62 
    let v64 : string = v53 + v63 
    let v65 : string = v64 + v55 
    let v66 : string = v30 + v65 
    let v67 : string = v53 + v66 
    let v68 : string = v67 + v55 
    let v69 : string = "parsing.none_of / unexpected char / "
    let v70 : string = v69 + v68 
    v70
and closure38 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = "parsing.many1_chars / inner parser succeeded without consuming text"
    v6
and method83 (v0 : int32, v1 : string, v2 : int32, v3 : int32, v4 : int32, v5 : int32, v6 : int32) : US19 =
    let v7 : bool = v2 >= v6
    let v28 : US18 =
        if v7 then
            let v8 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
            US18_Error(v8, v2, v3, v4, v5, v6)
        else
            let v10 : char = (spiralStringIndex v1 (int v2))
            let v11 : bool = v10 = '"'
            let v13 : bool =
                if v11 then
                    true
                else
                    let v12 : bool = v10 = '''
                    v12
            let v14 : bool = v13 = false
            if v14 then
                let v15 : int32 = v2 + 1
                let v16 : bool = '\n' = v10
                let struct (v20 : int32, v21 : int32, v22 : int32, v23 : int32) =
                    if v16 then
                        let v17 : int32 = v3 + v5
                        let v18 : int32 = v4 + 1
                        struct (v17, v18, 1, v6)
                    else
                        let v19 : int32 = v5 + 1
                        struct (v3, v4, v19, v6)
                US18_Ok(v10, v15, v20, v21, v22, v23)
            else
                let v25 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                US18_Error(v25, v2, v3, v4, v5, v6)
    match v28 with
    | US18_Error(v29, v30, v31, v32, v33, v34) -> (* Error *)
        let v35 : bool = v0 >= v2
        let v40 : string =
            if v35 then
                let v36 : string = ""
                v36
            else
                let v37 : bool = v0 = v2
                let v38 : int32 = v2 - 1
                let v39 : string = (spiralStringSlice v1 (int v0) (int v38))
                v39
        US19_Ok(v40, v2, v3, v4, v5, v6)
    | US18_Ok(v42, v43, v44, v45, v46, v47) -> (* Ok *)
        let v48 : bool = v43 = v2
        let v49 : bool = v48 <> true
        if v49 then
            method83(v0, v1, v43, v44, v45, v46, v47)
        else
            let v51 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure38()
            US19_Error(v51, v2, v3, v4, v5, v6)
and closure39 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : int32 = v1 + 80
    let v7 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v0))
    let v8 : bool = v7 < v6
    let v9 : int32 =
        if v8 then
            v7
        else
            v6
    let v10 : bool = v1 >= v9
    let v15 : string =
        if v10 then
            let v11 : string = ""
            v11
        else
            let v12 : bool = v1 = v9
            let v13 : int32 = v9 - 1
            let v14 : string = (spiralStringSlice v0 (int v1) (int v13))
            v14
    let v16 : string = ""
    let v17 : string = v16 + v16 
    let v18 : string = "rest'"
    let v19 : string = v17 + v18 
    let v20 : string = " = "
    let v21 : string = v19 + v20 
    let v22 : string = v21 + v15 
    let v23 : string = "{ "
    let v24 : string = v23 + v22 
    let v25 : string = " }"
    let v26 : string = v24 + v25 
    let v27 : string = "parsing.between / expected content or closing delimiter / "
    let v28 : string = v27 + v26 
    v28
and e_c41 (v0 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string), v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32, v6 : string) () : string =
    v0 struct (v6, v1, v2, v3, v4, v5)
and format_real_84 (v0 : (unit -> string)) : string =
    let v1 : string = method11()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = v0 ()
    method12(v2, v3)
    let v4 : string = v2.l0
    v4
and closure40 (v0 : int32, v1 : int32, v2 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string), v3 : int32, v4 : int32, v5 : int32, v6 : int32, v7 : int32) struct (v8 : string, v9 : int32, v10 : int32, v11 : int32, v12 : int32, v13 : int32) : string =
    let v14 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v8))
    let v15 : int32 = v0 + 80
    let v16 : bool = v14 < v15
    let v17 : int32 =
        if v16 then
            v14
        else
            v15
    let v18 : int32 = v1 + 80
    let v19 : bool = v14 < v18
    let v20 : int32 =
        if v19 then
            v14
        else
            v18
    let v21 : bool = v0 >= v17
    let v26 : string =
        if v21 then
            let v22 : string = ""
            v22
        else
            let v23 : bool = v0 = v17
            let v24 : int32 = v17 - 1
            let v25 : string = (spiralStringSlice v8 (int v0) (int v24))
            v25
    let v27 : bool = v1 >= v20
    let v32 : string =
        if v27 then
            let v28 : string = ""
            v28
        else
            let v29 : bool = v1 = v20
            let v30 : int32 = v20 - 1
            let v31 : string = (spiralStringSlice v8 (int v1) (int v30))
            v31
    let v33 : string = ""
    let v34 : string = v33 + v33 
    let v35 : string = "e"
    let v36 : string = v34 + v35 
    let v37 : string = " = "
    let v38 : string = v36 + v37 
    let v39 : (unit -> string) = e_c41(v2, v3, v4, v5, v6, v7, v8)
    let v40 : string = format_real_84(v39)
    let v41 : string = v38 + v40 
    let v42 : string = "; "
    let v43 : string = v41 + v42 
    let v44 : string = "t"
    let v45 : string = v43 + v44 
    let v46 : string = v45 + v37 
    let v47 : string = v46 + v8 
    let v48 : string = v47 + v42 
    let v49 : string = "rest'"
    let v50 : string = v48 + v49 
    let v51 : string = v50 + v37 
    let v52 : string = v51 + v26 
    let v53 : string = v52 + v42 
    let v54 : string = "rest''"
    let v55 : string = v53 + v54 
    let v56 : string = v55 + v37 
    let v57 : string = v56 + v32 
    let v58 : string = "{ "
    let v59 : string = v58 + v57 
    let v60 : string = " }"
    let v61 : string = v59 + v60 
    let v62 : string = "parsing.between / expected closing delimiter / "
    let v63 : string = v62 + v61 
    v63
and closure42 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : char list = []
    let v7 : char list = ' ' :: v6 
    let v8 : char list = ''' :: v7 
    let v9 : char list = '"' :: v8 
    let v10 : (char list -> (char [])) = List.toArray
    let v11 : (char []) = v10 v9
    let v12 : string = method82(v11)
    let v13 : string = ""
    let v14 : string = v13 + v13 
    let v15 : string = "chars'"
    let v16 : string = v14 + v15 
    let v17 : string = " = "
    let v18 : string = v16 + v17 
    let v19 : string = v18 + v12 
    let v20 : string = "; "
    let v21 : string = v19 + v20 
    let v22 : string = "s"
    let v23 : string = v21 + v22 
    let v24 : string = v23 + v17 
    let v25 : string = v13 + v13 
    let v26 : string = "line_start"
    let v27 : string = v25 + v26 
    let v28 : string = v27 + v17 
    let v29 : string = format_real_79(v2)
    let v30 : string = v28 + v29 
    let v31 : string = v30 + v20 
    let v32 : string = "position"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v17 
    let v35 : string = v13 + v13 
    let v36 : string = "line"
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v17 
    let v39 : string = format_real_79(v3)
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v20 
    let v42 : string = "col"
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v17 
    let v45 : string = format_real_79(v4)
    let v46 : string = v44 + v45 
    let v47 : string = "{ "
    let v48 : string = v47 + v46 
    let v49 : string = " }"
    let v50 : string = v48 + v49 
    let v51 : string = v34 + v50 
    let v52 : string = v51 + v20 
    let v53 : string = "text_length"
    let v54 : string = v52 + v53 
    let v55 : string = v54 + v17 
    let v56 : string = format_real_79(v5)
    let v57 : string = v55 + v56 
    let v58 : string = v47 + v57 
    let v59 : string = v58 + v49 
    let v60 : string = v24 + v59 
    let v61 : string = v47 + v60 
    let v62 : string = v61 + v49 
    let v63 : string = "parsing.none_of / unexpected end of text / "
    let v64 : string = v63 + v62 
    v64
and closure43 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : char = (spiralStringIndex v0 (int v1))
    let v7 : char list = []
    let v8 : char list = ' ' :: v7 
    let v9 : char list = ''' :: v8 
    let v10 : char list = '"' :: v9 
    let v11 : (char list -> (char [])) = List.toArray
    let v12 : (char []) = v11 v10
    let v13 : string = method82(v12)
    let v14 : string = ""
    let v15 : string = v14 + v14 
    let v16 : string = "first_char"
    let v17 : string = v15 + v16 
    let v18 : string = " = "
    let v19 : string = v17 + v18 
    let v20 : string = format_real_10(v6)
    let v21 : string = v19 + v20 
    let v22 : string = "; "
    let v23 : string = v21 + v22 
    let v24 : string = "chars'"
    let v25 : string = v23 + v24 
    let v26 : string = v25 + v18 
    let v27 : string = v26 + v13 
    let v28 : string = v27 + v22 
    let v29 : string = "s"
    let v30 : string = v28 + v29 
    let v31 : string = v30 + v18 
    let v32 : string = v14 + v14 
    let v33 : string = "line_start"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v18 
    let v36 : string = format_real_79(v2)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v22 
    let v39 : string = "position"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v18 
    let v42 : string = v14 + v14 
    let v43 : string = "line"
    let v44 : string = v42 + v43 
    let v45 : string = v44 + v18 
    let v46 : string = format_real_79(v3)
    let v47 : string = v45 + v46 
    let v48 : string = v47 + v22 
    let v49 : string = "col"
    let v50 : string = v48 + v49 
    let v51 : string = v50 + v18 
    let v52 : string = format_real_79(v4)
    let v53 : string = v51 + v52 
    let v54 : string = "{ "
    let v55 : string = v54 + v53 
    let v56 : string = " }"
    let v57 : string = v55 + v56 
    let v58 : string = v41 + v57 
    let v59 : string = v58 + v22 
    let v60 : string = "text_length"
    let v61 : string = v59 + v60 
    let v62 : string = v61 + v18 
    let v63 : string = format_real_79(v5)
    let v64 : string = v62 + v63 
    let v65 : string = v54 + v64 
    let v66 : string = v65 + v56 
    let v67 : string = v31 + v66 
    let v68 : string = v54 + v67 
    let v69 : string = v68 + v56 
    let v70 : string = "parsing.none_of / unexpected char / "
    let v71 : string = v70 + v69 
    v71
and method85 (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : US19 =
    let v6 : bool = v1 >= v5
    let v29 : US18 =
        if v6 then
            let v7 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure42()
            US18_Error(v7, v1, v2, v3, v4, v5)
        else
            let v9 : char = (spiralStringIndex v0 (int v1))
            let v10 : bool = v9 = '"'
            let v14 : bool =
                if v10 then
                    true
                else
                    let v11 : bool = v9 = '''
                    if v11 then
                        true
                    else
                        let v12 : bool = v9 = ' '
                        v12
            let v15 : bool = v14 = false
            if v15 then
                let v16 : int32 = v1 + 1
                let v17 : bool = '\n' = v9
                let struct (v21 : int32, v22 : int32, v23 : int32, v24 : int32) =
                    if v17 then
                        let v18 : int32 = v2 + v4
                        let v19 : int32 = v3 + 1
                        struct (v18, v19, 1, v5)
                    else
                        let v20 : int32 = v4 + 1
                        struct (v2, v3, v20, v5)
                US18_Ok(v9, v16, v21, v22, v23, v24)
            else
                let v26 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure43()
                US18_Error(v26, v1, v2, v3, v4, v5)
    match v29 with
    | US18_Error(v30, v31, v32, v33, v34, v35) -> (* Error *)
        let v36 : bool = 0 >= v1
        let v41 : string =
            if v36 then
                let v37 : string = ""
                v37
            else
                let v38 : bool = 0 = v1
                let v39 : int32 = v1 - 1
                let v40 : string = (spiralStringSlice v0 (int 0) (int v39))
                v40
        US19_Ok(v41, v1, v2, v3, v4, v5)
    | US18_Ok(v43, v44, v45, v46, v47, v48) -> (* Ok *)
        let v49 : bool = v44 = v1
        let v50 : bool = v49 <> true
        if v50 then
            method85(v0, v44, v45, v46, v47, v48)
        else
            let v52 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure38()
            US19_Error(v52, v1, v2, v3, v4, v5)
and closure44 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : bool = v1 >= v5
    let v11 : string =
        if v6 then
            let v7 : string = ""
            v7
        else
            let v8 : bool = v1 = v5
            let v9 : int32 = v5 - 1
            let v10 : string = (spiralStringSlice v0 (int v1) (int v9))
            v10
    let v12 : string = ""
    let v13 : string = v12 + v12 
    let v14 : string = "rest"
    let v15 : string = v13 + v14 
    let v16 : string = " = "
    let v17 : string = v15 + v16 
    let v18 : string = v17 + v11 
    let v19 : string = "{ "
    let v20 : string = v19 + v18 
    let v21 : string = " }"
    let v22 : string = v20 + v21 
    let v23 : string = "parsing.eof / expected end of text / "
    let v24 : string = v23 + v22 
    v24
and method86 (v0 : string, v1 : int32, v2 : int32) : int32 =
    let v3 : bool = v2 >= v1
    if v3 then
        v2
    else
        let v4 : char = (spiralStringIndex v0 (int v2))
        let v5 : bool = v4 = ' '
        let v7 : bool =
            if v5 then
                true
            else
                let v6 : bool = v4 = '\t'
                v6
        let v9 : bool =
            if v7 then
                true
            else
                let v8 : bool = v4 = '\r'
                v8
        if v9 then
            let v10 : int32 = v2 + 1
            method86(v0, v1, v10)
        else
            v2
and closure45 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : int32 = v1 + 80
    let v7 : bool = v5 < v6
    let v8 : int32 =
        if v7 then
            v5
        else
            v6
    let v9 : bool = v1 >= v8
    let v14 : string =
        if v9 then
            let v10 : string = ""
            v10
        else
            let v11 : bool = v1 = v8
            let v12 : int32 = v8 - 1
            let v13 : string = (spiralStringSlice v0 (int v1) (int v12))
            v13
    let v15 : string = ""
    let v16 : string = v15 + v15 
    let v17 : string = "rest"
    let v18 : string = v16 + v17 
    let v19 : string = " = "
    let v20 : string = v18 + v19 
    let v21 : string = v20 + v14 
    let v22 : string = "{ "
    let v23 : string = v22 + v21 
    let v24 : string = " }"
    let v25 : string = v23 + v24 
    let v26 : string = "parsing.spaces1 / expected at least one space / "
    let v27 : string = v26 + v25 
    v27
and closure46 (v0 : string) () : string =
    v0
and closure47 (v0 : string) () : string =
    v0
and closure48 (v0 : US22) () : US22 =
    v0
and closure49 (v0 : string, v1 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string), v2 : int32, v3 : int32, v4 : int32, v5 : int32, v6 : int32) () : string =
    v1 struct (v0, v2, v3, v4, v5, v6)
and split_command_78 (v0 : string) : US17 =
    let v1 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v0))
    let v2 : bool = 0 >= v1
    let v16 : US18 =
        if v2 then
            let v3 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
            US18_Error(v3, 0, 0, 1, 1, v1)
        else
            let v5 : char = (spiralStringIndex v0 (int 0))
            let v6 : bool = v5 = '"'
            if v6 then
                let v7 : bool = '\n' = v5
                let struct (v8 : int32, v9 : int32, v10 : int32, v11 : int32) =
                    if v7 then
                        struct (1, 2, 1, v1)
                    else
                        struct (0, 1, 2, v1)
                US18_Ok('"', 1, v8, v9, v10, v11)
            else
                let v13 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                US18_Error(v13, 0, 0, 1, 1, v1)
    let v60 : US18 =
        match v16 with
        | US18_Error(v23, v24, v25, v26, v27, v28) -> (* Error *)
            let v42 : US18 =
                if v2 then
                    let v29 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure33()
                    US18_Error(v29, 0, 0, 1, 1, v1)
                else
                    let v31 : char = (spiralStringIndex v0 (int 0))
                    let v32 : bool = v31 = '''
                    if v32 then
                        let v33 : bool = '\n' = v31
                        let struct (v34 : int32, v35 : int32, v36 : int32, v37 : int32) =
                            if v33 then
                                struct (1, 2, 1, v1)
                            else
                                struct (0, 1, 2, v1)
                        US18_Ok(''', 1, v34, v35, v36, v37)
                    else
                        let v39 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure34()
                        US18_Error(v39, 0, 0, 1, 1, v1)
            match v42 with
            | US18_Error(v49, v50, v51, v52, v53, v54) -> (* Error *)
                let v55 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure35()
                US18_Error(v55, 0, 0, 1, 1, v1)
            | US18_Ok(v43, v44, v45, v46, v47, v48) -> (* Ok *)
                v42
        | US18_Ok(v17, v18, v19, v20, v21, v22) -> (* Ok *)
            v16
    let v312 : US19 =
        match v60 with
        | US18_Error(v304, v305, v306, v307, v308, v309) -> (* Error *)
            US19_Error(v304, v305, v306, v307, v308, v309)
        | US18_Ok(v61, v62, v63, v64, v65, v66) -> (* Ok *)
            let v67 : bool = v62 >= v66
            let v88 : US18 =
                if v67 then
                    let v68 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                    US18_Error(v68, v62, v63, v64, v65, v66)
                else
                    let v70 : char = (spiralStringIndex v0 (int v62))
                    let v71 : bool = v70 = '"'
                    let v73 : bool =
                        if v71 then
                            true
                        else
                            let v72 : bool = v70 = '''
                            v72
                    let v74 : bool = v73 = false
                    if v74 then
                        let v75 : int32 = v62 + 1
                        let v76 : bool = '\n' = v70
                        let struct (v80 : int32, v81 : int32, v82 : int32, v83 : int32) =
                            if v76 then
                                let v77 : int32 = v63 + v65
                                let v78 : int32 = v64 + 1
                                struct (v77, v78, 1, v66)
                            else
                                let v79 : int32 = v65 + 1
                                struct (v63, v64, v79, v66)
                        US18_Ok(v70, v75, v80, v81, v82, v83)
                    else
                        let v85 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                        US18_Error(v85, v62, v63, v64, v65, v66)
            let v104 : US19 =
                match v88 with
                | US18_Error(v89, v90, v91, v92, v93, v94) -> (* Error *)
                    US19_Error(v89, v90, v91, v92, v93, v94)
                | US18_Ok(v96, v97, v98, v99, v100, v101) -> (* Ok *)
                    method83(v62, v0, v97, v98, v99, v100, v101)
            let v121 : US19 =
                match v104 with
                | US19_Error(v112, v113, v114, v115, v116, v117) -> (* Error *)
                    let v118 : string = ""
                    US19_Ok(v118, v62, v63, v64, v65, v66)
                | US19_Ok(v105, v106, v107, v108, v109, v110) -> (* Ok *)
                    US19_Ok(v105, v106, v107, v108, v109, v110)
            match v121 with
            | US19_Error(v212, v213, v214, v215, v216, v217) -> (* Error *)
                let v235 : US18 =
                    if v67 then
                        let v218 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                        US18_Error(v218, v62, v63, v64, v65, v66)
                    else
                        let v220 : char = (spiralStringIndex v0 (int v62))
                        let v221 : bool = v220 = '"'
                        if v221 then
                            let v222 : int32 = v62 + 1
                            let v223 : bool = '\n' = v220
                            let struct (v227 : int32, v228 : int32, v229 : int32, v230 : int32) =
                                if v223 then
                                    let v224 : int32 = v63 + v65
                                    let v225 : int32 = v64 + 1
                                    struct (v224, v225, 1, v66)
                                else
                                    let v226 : int32 = v65 + 1
                                    struct (v63, v64, v226, v66)
                            US18_Ok('"', v222, v227, v228, v229, v230)
                        else
                            let v232 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                            US18_Error(v232, v62, v63, v64, v65, v66)
                let v283 : US18 =
                    match v235 with
                    | US18_Error(v242, v243, v244, v245, v246, v247) -> (* Error *)
                        let v265 : US18 =
                            if v67 then
                                let v248 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure33()
                                US18_Error(v248, v62, v63, v64, v65, v66)
                            else
                                let v250 : char = (spiralStringIndex v0 (int v62))
                                let v251 : bool = v250 = '''
                                if v251 then
                                    let v252 : int32 = v62 + 1
                                    let v253 : bool = '\n' = v250
                                    let struct (v257 : int32, v258 : int32, v259 : int32, v260 : int32) =
                                        if v253 then
                                            let v254 : int32 = v63 + v65
                                            let v255 : int32 = v64 + 1
                                            struct (v254, v255, 1, v66)
                                        else
                                            let v256 : int32 = v65 + 1
                                            struct (v63, v64, v256, v66)
                                    US18_Ok(''', v252, v257, v258, v259, v260)
                                else
                                    let v262 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure34()
                                    US18_Error(v262, v62, v63, v64, v65, v66)
                        match v265 with
                        | US18_Error(v272, v273, v274, v275, v276, v277) -> (* Error *)
                            let v278 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure35()
                            US18_Error(v278, v62, v63, v64, v65, v66)
                        | US18_Ok(v266, v267, v268, v269, v270, v271) -> (* Ok *)
                            v265
                    | US18_Ok(v236, v237, v238, v239, v240, v241) -> (* Ok *)
                        v235
                match v283 with
                | US18_Error(v292, v293, v294, v295, v296, v297) -> (* Error *)
                    let v298 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure39()
                    US19_Error(v298, v62, v63, v64, v65, v66)
                | US18_Ok(v284, v285, v286, v287, v288, v289) -> (* Ok *)
                    let v290 : string = ""
                    US19_Ok(v290, v285, v286, v287, v288, v289)
            | US19_Ok(v122, v123, v124, v125, v126, v127) -> (* Ok *)
                let v128 : bool = v123 >= v127
                let v146 : US18 =
                    if v128 then
                        let v129 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                        US18_Error(v129, v123, v124, v125, v126, v127)
                    else
                        let v131 : char = (spiralStringIndex v0 (int v123))
                        let v132 : bool = v131 = '"'
                        if v132 then
                            let v133 : int32 = v123 + 1
                            let v134 : bool = '\n' = v131
                            let struct (v138 : int32, v139 : int32, v140 : int32, v141 : int32) =
                                if v134 then
                                    let v135 : int32 = v124 + v126
                                    let v136 : int32 = v125 + 1
                                    struct (v135, v136, 1, v127)
                                else
                                    let v137 : int32 = v126 + 1
                                    struct (v124, v125, v137, v127)
                            US18_Ok('"', v133, v138, v139, v140, v141)
                        else
                            let v143 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                            US18_Error(v143, v123, v124, v125, v126, v127)
                let v194 : US18 =
                    match v146 with
                    | US18_Error(v153, v154, v155, v156, v157, v158) -> (* Error *)
                        let v176 : US18 =
                            if v128 then
                                let v159 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure33()
                                US18_Error(v159, v123, v124, v125, v126, v127)
                            else
                                let v161 : char = (spiralStringIndex v0 (int v123))
                                let v162 : bool = v161 = '''
                                if v162 then
                                    let v163 : int32 = v123 + 1
                                    let v164 : bool = '\n' = v161
                                    let struct (v168 : int32, v169 : int32, v170 : int32, v171 : int32) =
                                        if v164 then
                                            let v165 : int32 = v124 + v126
                                            let v166 : int32 = v125 + 1
                                            struct (v165, v166, 1, v127)
                                        else
                                            let v167 : int32 = v126 + 1
                                            struct (v124, v125, v167, v127)
                                    US18_Ok(''', v163, v168, v169, v170, v171)
                                else
                                    let v173 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure34()
                                    US18_Error(v173, v123, v124, v125, v126, v127)
                        match v176 with
                        | US18_Error(v183, v184, v185, v186, v187, v188) -> (* Error *)
                            let v189 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure35()
                            US18_Error(v189, v123, v124, v125, v126, v127)
                        | US18_Ok(v177, v178, v179, v180, v181, v182) -> (* Ok *)
                            v176
                    | US18_Ok(v147, v148, v149, v150, v151, v152) -> (* Ok *)
                        v146
                match v194 with
                | US18_Error(v202, v203, v204, v205, v206, v207) -> (* Error *)
                    let v208 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure40(v62, v123, v202, v203, v204, v205, v206, v207)
                    US19_Error(v208, v123, v124, v125, v126, v127)
                | US18_Ok(v195, v196, v197, v198, v199, v200) -> (* Ok *)
                    US19_Ok(v122, v196, v197, v198, v199, v200)
    let v331 : US19 =
        match v312 with
        | US19_Error(v323, v324, v325, v326, v327, v328) -> (* Error *)
            US19_Error(v323, v324, v325, v326, v327, v328)
        | US19_Ok(v313, v314, v315, v316, v317, v318) -> (* Ok *)
            let v319 : string = "\\"
            let v320 : string = "/"
            let v321 : string = v313.Replace (v319, v320)
            US19_Ok(v321, v314, v315, v316, v317, v318)
    let v399 : US19 =
        match v331 with
        | US19_Error(v338, v339, v340, v341, v342, v343) -> (* Error *)
            let v362 : US18 =
                if v2 then
                    let v344 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure42()
                    US18_Error(v344, 0, 0, 1, 1, v1)
                else
                    let v346 : char = (spiralStringIndex v0 (int 0))
                    let v347 : bool = v346 = '"'
                    let v351 : bool =
                        if v347 then
                            true
                        else
                            let v348 : bool = v346 = '''
                            if v348 then
                                true
                            else
                                let v349 : bool = v346 = ' '
                                v349
                    let v352 : bool = v351 = false
                    if v352 then
                        let v353 : bool = '\n' = v346
                        let struct (v354 : int32, v355 : int32, v356 : int32, v357 : int32) =
                            if v353 then
                                struct (1, 2, 1, v1)
                            else
                                struct (0, 1, 2, v1)
                        US18_Ok(v346, 1, v354, v355, v356, v357)
                    else
                        let v359 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure43()
                        US18_Error(v359, 0, 0, 1, 1, v1)
            let v378 : US19 =
                match v362 with
                | US18_Error(v363, v364, v365, v366, v367, v368) -> (* Error *)
                    US19_Error(v363, v364, v365, v366, v367, v368)
                | US18_Ok(v370, v371, v372, v373, v374, v375) -> (* Ok *)
                    method85(v0, v371, v372, v373, v374, v375)
            match v378 with
            | US19_Error(v389, v390, v391, v392, v393, v394) -> (* Error *)
                US19_Error(v389, v390, v391, v392, v393, v394)
            | US19_Ok(v379, v380, v381, v382, v383, v384) -> (* Ok *)
                let v385 : string = "\\"
                let v386 : string = "/"
                let v387 : string = v379.Replace (v385, v386)
                US19_Ok(v387, v380, v381, v382, v383, v384)
        | US19_Ok(v332, v333, v334, v335, v336, v337) -> (* Ok *)
            v331
    let v434 : US19 =
        match v399 with
        | US19_Error(v406, v407, v408, v409, v410, v411) -> (* Error *)
            let v412 : bool = v1 = 0
            let v416 : US20 =
                if v412 then
                    US20_Ok(0, 0, 1, 1, v1)
                else
                    let v414 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure44()
                    US20_Error(v414, 0, 0, 1, 1, v1)
            match v416 with
            | US20_Error(v424, v425, v426, v427, v428, v429) -> (* Error *)
                US19_Error(v424, v425, v426, v427, v428, v429)
            | US20_Ok(v417, v418, v419, v420, v421) -> (* Ok *)
                let v422 : string = ""
                US19_Ok(v422, v417, v418, v419, v420, v421)
        | US19_Ok(v400, v401, v402, v403, v404, v405) -> (* Ok *)
            v399
    let v547 : US21 =
        match v434 with
        | US19_Error(v435, v436, v437, v438, v439, v440) -> (* Error *)
            US21_Error(v435, v436, v437, v438, v439, v440)
        | US19_Ok(v442, v443, v444, v445, v446, v447) -> (* Ok *)
            let v448 : bool = v443 >= v447
            let struct (v460 : int32, v461 : int32, v462 : int32, v463 : int32, v464 : int32) =
                if v448 then
                    struct (v443, v444, v445, v446, v447)
                else
                    let v449 : int32 = method86(v0, v1, v443)
                    let v450 : bool = v449 > v447
                    let v451 : int32 =
                        if v450 then
                            v447
                        else
                            v449
                    let v452 : int32 = v451 - v443
                    let v453 : bool = v452 = 0
                    if v453 then
                        struct (v443, v444, v445, v446, v447)
                    else
                        let v454 : int32 = v446 + v452
                        struct (v451, v444, v445, v454, v447)
            let v465 : bool = v460 = v443
            let v466 : bool = v465 <> true
            let v470 : US20 =
                if v466 then
                    US20_Ok(v460, v461, v462, v463, v464)
                else
                    let v468 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure45()
                    US20_Error(v468, v443, v444, v445, v446, v447)
            let v508 : US19 =
                match v470 with
                | US20_Error(v500, v501, v502, v503, v504, v505) -> (* Error *)
                    US19_Error(v500, v501, v502, v503, v504, v505)
                | US20_Ok(v471, v472, v473, v474, v475) -> (* Ok *)
                    let v476 : bool = v471 >= v475
                    let struct (v488 : int32, v489 : int32, v490 : int32, v491 : int32, v492 : int32) =
                        if v476 then
                            struct (v471, v472, v473, v474, v475)
                        else
                            let v477 : int32 = method80(v0, v1, v471)
                            let v478 : bool = v477 > v475
                            let v479 : int32 =
                                if v478 then
                                    v475
                                else
                                    v477
                            let v480 : int32 = v479 - v471
                            let v481 : bool = v480 = 0
                            if v481 then
                                struct (v471, v472, v473, v474, v475)
                            else
                                let v482 : int32 = v474 + v480
                                struct (v479, v472, v473, v482, v475)
                    let v493 : bool = v471 >= v488
                    let v498 : string =
                        if v493 then
                            let v494 : string = ""
                            v494
                        else
                            let v495 : bool = v471 = v488
                            let v496 : int32 = v488 - 1
                            let v497 : string = (spiralStringSlice v0 (int v471) (int v496))
                            v497
                    US19_Ok(v498, v488, v489, v490, v491, v492)
            let v527 : US23 =
                match v508 with
                | US19_Error(v518, v519, v520, v521, v522, v523) -> (* Error *)
                    let v524 : US22 = US22_None
                    US23_Ok(v524, v443, v444, v445, v446, v447)
                | US19_Ok(v509, v510, v511, v512, v513, v514) -> (* Ok *)
                    let v515 : (unit -> string) = closure46(v509)
                    let v516 : US22 = US22_Some(v515)
                    US23_Ok(v516, v510, v511, v512, v513, v514)
            match v527 with
            | US23_Error(v537, v538, v539, v540, v541, v542) -> (* Error *)
                US21_Error(v537, v538, v539, v540, v541, v542)
            | US23_Ok(v528, v529, v530, v531, v532, v533) -> (* Ok *)
                let v534 : (unit -> string) = closure47(v442)
                let v535 : (unit -> US22) = closure48(v528)
                US21_Ok(v534, v535, v529, v530, v531, v532, v533)
    let v571 : US24 =
        match v547 with
        | US21_Error(v562, v563, v564, v565, v566, v567) -> (* Error *)
            let v568 : (unit -> string) = closure49(v0, v562, v563, v564, v565, v566, v567)
            US24_Error(v568)
        | US21_Ok(v548, v549, v550, v551, v552, v553, v554) -> (* Ok *)
            let v555 : bool = v550 >= v554
            let v560 : string =
                if v555 then
                    let v556 : string = ""
                    v556
                else
                    let v557 : bool = v550 = v554
                    let v558 : int32 = v554 - 1
                    let v559 : string = (spiralStringSlice v0 (int v550) (int v558))
                    v559
            US24_Ok(v548, v549, v560, v551, v552, v553, v554)
    let v591 : US25 =
        match v571 with
        | US24_Error(v588) -> (* Error *)
            US25_Error(v588)
        | US24_Ok(v572, v573, v574, v575, v576, v577, v578) -> (* Ok *)
            let v579 : string = v572 ()
            let v580 : US22 = v573 ()
            let v586 : US3 =
                match v580 with
                | US22_None -> (* None *)
                    US3_None
                | US22_Some(v581) -> (* Some *)
                    let v582 : string = v581 ()
                    US3_Some(v582)
            US25_Ok(v579, v586)
    match v591 with
    | US25_Error(v595) -> (* Error *)
        let v596 : string = v595 ()
        US17_Error(v596)
    | US25_Ok(v592, v593) -> (* Ok *)
        US17_Ok(v592, v593)
and closure50 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = ""
    let v7 : string = v6 + v6 
    let v8 : string = "c"
    let v9 : string = v7 + v8 
    let v10 : string = " = "
    let v11 : string = v9 + v10 
    let v12 : char = '\\'
    let v13 : string = format_real_10(v12)
    let v14 : string = v11 + v13 
    let v15 : string = "; "
    let v16 : string = v14 + v15 
    let v17 : string = "s'"
    let v18 : string = v16 + v17 
    let v19 : string = v18 + v10 
    let v20 : string = v6 + v6 
    let v21 : string = "line_start"
    let v22 : string = v20 + v21 
    let v23 : string = v22 + v10 
    let v24 : string = format_real_79(v2)
    let v25 : string = v23 + v24 
    let v26 : string = v25 + v15 
    let v27 : string = "position"
    let v28 : string = v26 + v27 
    let v29 : string = v28 + v10 
    let v30 : string = v6 + v6 
    let v31 : string = "line"
    let v32 : string = v30 + v31 
    let v33 : string = v32 + v10 
    let v34 : string = format_real_79(v3)
    let v35 : string = v33 + v34 
    let v36 : string = v35 + v15 
    let v37 : string = "col"
    let v38 : string = v36 + v37 
    let v39 : string = v38 + v10 
    let v40 : string = format_real_79(v4)
    let v41 : string = v39 + v40 
    let v42 : string = "{ "
    let v43 : string = v42 + v41 
    let v44 : string = " }"
    let v45 : string = v43 + v44 
    let v46 : string = v29 + v45 
    let v47 : string = v46 + v15 
    let v48 : string = "text_length"
    let v49 : string = v47 + v48 
    let v50 : string = v49 + v10 
    let v51 : string = format_real_79(v5)
    let v52 : string = v50 + v51 
    let v53 : string = v42 + v52 
    let v54 : string = v53 + v44 
    let v55 : string = v19 + v54 
    let v56 : string = v42 + v55 
    let v57 : string = v56 + v44 
    let v58 : string = "parsing.p_char / unexpected end of text / "
    let v59 : string = v58 + v57 
    v59
and closure51 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v0))
    let v7 : int32 = method80(v0, v6, v1)
    let v8 : int32 = v1 + 80
    let v9 : bool = v7 < v8
    let v10 : int32 =
        if v9 then
            v7
        else
            v8
    let v11 : bool = v2 >= v10
    let v16 : string =
        if v11 then
            let v12 : string = ""
            v12
        else
            let v13 : bool = v2 = v10
            let v14 : int32 = v10 - 1
            let v15 : string = (spiralStringSlice v0 (int v2) (int v14))
            v15
    let v17 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v16))
    let v18 : bool = v17 > 0
    let v22 : bool =
        if v18 then
            let v19 : int32 = v17 - 1
            let v20 : char = (spiralStringIndex v16 (int v19))
            let v21 : bool = v20 = '\n'
            v21
        else
            false
    let v25 : string =
        if v22 then
            let v23 : string = ""
            v23
        else
            let v24 : string = "\n"
            v24
    let v26 : int32 = v4 - 1
    let v27 : int32 = 0
    let v28 : (string -> string) = method81(v26, v27)
    let v29 : string = ""
    let v30 : string = v28 v29
    let v31 : string = "^"
    let v32 : string = v30 + v31 
    let v33 : string = v29 + v29 
    let v34 : string = "expected"
    let v35 : string = v33 + v34 
    let v36 : string = " = "
    let v37 : string = v35 + v36 
    let v38 : char = '\\'
    let v39 : string = format_real_10(v38)
    let v40 : string = v37 + v39 
    let v41 : string = "; "
    let v42 : string = v40 + v41 
    let v43 : string = "line"
    let v44 : string = v42 + v43 
    let v45 : string = v44 + v36 
    let v46 : string = format_real_79(v3)
    let v47 : string = v45 + v46 
    let v48 : string = v47 + v41 
    let v49 : string = "col"
    let v50 : string = v48 + v49 
    let v51 : string = v50 + v36 
    let v52 : string = format_real_79(v4)
    let v53 : string = v51 + v52 
    let v54 : string = "{ "
    let v55 : string = v54 + v53 
    let v56 : string = " }"
    let v57 : string = v55 + v56 
    let v58 : string = "parsing.p_char / "
    let v59 : string = v58 + v57 
    let v60 : string = "\n"
    let v61 : string = v59 + v60 
    let v62 : string = v61 + v16 
    let v63 : string = v62 + v25 
    let v64 : string = v63 + v32 
    let v65 : string = v64 + v60 
    v65
and closure52 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = ""
    let v7 : string = v6 + v6 
    let v8 : string = "c"
    let v9 : string = v7 + v8 
    let v10 : string = " = "
    let v11 : string = v9 + v10 
    let v12 : char = '`'
    let v13 : string = format_real_10(v12)
    let v14 : string = v11 + v13 
    let v15 : string = "; "
    let v16 : string = v14 + v15 
    let v17 : string = "s'"
    let v18 : string = v16 + v17 
    let v19 : string = v18 + v10 
    let v20 : string = v6 + v6 
    let v21 : string = "line_start"
    let v22 : string = v20 + v21 
    let v23 : string = v22 + v10 
    let v24 : string = format_real_79(v2)
    let v25 : string = v23 + v24 
    let v26 : string = v25 + v15 
    let v27 : string = "position"
    let v28 : string = v26 + v27 
    let v29 : string = v28 + v10 
    let v30 : string = v6 + v6 
    let v31 : string = "line"
    let v32 : string = v30 + v31 
    let v33 : string = v32 + v10 
    let v34 : string = format_real_79(v3)
    let v35 : string = v33 + v34 
    let v36 : string = v35 + v15 
    let v37 : string = "col"
    let v38 : string = v36 + v37 
    let v39 : string = v38 + v10 
    let v40 : string = format_real_79(v4)
    let v41 : string = v39 + v40 
    let v42 : string = "{ "
    let v43 : string = v42 + v41 
    let v44 : string = " }"
    let v45 : string = v43 + v44 
    let v46 : string = v29 + v45 
    let v47 : string = v46 + v15 
    let v48 : string = "text_length"
    let v49 : string = v47 + v48 
    let v50 : string = v49 + v10 
    let v51 : string = format_real_79(v5)
    let v52 : string = v50 + v51 
    let v53 : string = v42 + v52 
    let v54 : string = v53 + v44 
    let v55 : string = v19 + v54 
    let v56 : string = v42 + v55 
    let v57 : string = v56 + v44 
    let v58 : string = "parsing.p_char / unexpected end of text / "
    let v59 : string = v58 + v57 
    v59
and closure53 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v0))
    let v7 : int32 = method80(v0, v6, v1)
    let v8 : int32 = v1 + 80
    let v9 : bool = v7 < v8
    let v10 : int32 =
        if v9 then
            v7
        else
            v8
    let v11 : bool = v2 >= v10
    let v16 : string =
        if v11 then
            let v12 : string = ""
            v12
        else
            let v13 : bool = v2 = v10
            let v14 : int32 = v10 - 1
            let v15 : string = (spiralStringSlice v0 (int v2) (int v14))
            v15
    let v17 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v16))
    let v18 : bool = v17 > 0
    let v22 : bool =
        if v18 then
            let v19 : int32 = v17 - 1
            let v20 : char = (spiralStringIndex v16 (int v19))
            let v21 : bool = v20 = '\n'
            v21
        else
            false
    let v25 : string =
        if v22 then
            let v23 : string = ""
            v23
        else
            let v24 : string = "\n"
            v24
    let v26 : int32 = v4 - 1
    let v27 : int32 = 0
    let v28 : (string -> string) = method81(v26, v27)
    let v29 : string = ""
    let v30 : string = v28 v29
    let v31 : string = "^"
    let v32 : string = v30 + v31 
    let v33 : string = v29 + v29 
    let v34 : string = "expected"
    let v35 : string = v33 + v34 
    let v36 : string = " = "
    let v37 : string = v35 + v36 
    let v38 : char = '`'
    let v39 : string = format_real_10(v38)
    let v40 : string = v37 + v39 
    let v41 : string = "; "
    let v42 : string = v40 + v41 
    let v43 : string = "line"
    let v44 : string = v42 + v43 
    let v45 : string = v44 + v36 
    let v46 : string = format_real_79(v3)
    let v47 : string = v45 + v46 
    let v48 : string = v47 + v41 
    let v49 : string = "col"
    let v50 : string = v48 + v49 
    let v51 : string = v50 + v36 
    let v52 : string = format_real_79(v4)
    let v53 : string = v51 + v52 
    let v54 : string = "{ "
    let v55 : string = v54 + v53 
    let v56 : string = " }"
    let v57 : string = v55 + v56 
    let v58 : string = "parsing.p_char / "
    let v59 : string = v58 + v57 
    let v60 : string = "\n"
    let v61 : string = v59 + v60 
    let v62 : string = v61 + v16 
    let v63 : string = v62 + v25 
    let v64 : string = v63 + v32 
    let v65 : string = v64 + v60 
    v65
and method89 (v0 : int32, v1 : int32, v2 : int32, v3 : int32, v4 : string, v5 : int32, v6 : int32, v7 : int32, v8 : int32, v9 : int32) : struct (int32 * int32 * int32 * int32 * int32) =
    let v10 : bool = v5 >= v3
    if v10 then
        struct (v5, v6, v7, v8, v9)
    else
        let v11 : char = (spiralStringIndex v4 (int v5))
        let v12 : bool = v11 = '\\'
        let v16 : bool =
            if v12 then
                true
            else
                let v13 : bool = v11 = '`'
                if v13 then
                    true
                else
                    let v14 : bool = v11 = '"'
                    v14
        let v17 : bool = v16 = false
        if v17 then
            let v18 : int32 = v5 + 1
            let v19 : bool = '\n' = v11
            let struct (v23 : int32, v24 : int32, v25 : int32, v26 : int32) =
                if v19 then
                    let v20 : int32 = v6 + v8
                    let v21 : int32 = v7 + 1
                    struct (v20, v21, 1, v9)
                else
                    let v22 : int32 = v8 + 1
                    struct (v6, v7, v22, v9)
            method89(v0, v1, v2, v3, v4, v18, v23, v24, v25, v26)
        else
            struct (v5, v6, v7, v8, v9)
and method88 (v0 : int32, v1 : int32, v2 : int32, v3 : int32, v4 : string, v5 : int32) : struct (int32 * int32 * int32 * int32 * int32) =
    let v6 : bool = v5 >= v3
    if v6 then
        struct (v5, v0, v1, v2, v3)
    else
        let v7 : char = (spiralStringIndex v4 (int v5))
        let v8 : bool = v7 = '\\'
        let v12 : bool =
            if v8 then
                true
            else
                let v9 : bool = v7 = '`'
                if v9 then
                    true
                else
                    let v10 : bool = v7 = '"'
                    v10
        let v13 : bool = v12 = false
        if v13 then
            let v14 : int32 = v5 + 1
            let v15 : bool = '\n' = v7
            let struct (v19 : int32, v20 : int32, v21 : int32, v22 : int32) =
                if v15 then
                    let v16 : int32 = v0 + v2
                    let v17 : int32 = v1 + 1
                    struct (v16, v17, 1, v3)
                else
                    let v18 : int32 = v2 + 1
                    struct (v0, v1, v18, v3)
            method89(v0, v1, v2, v3, v4, v14, v19, v20, v21, v22)
        else
            struct (v5, v0, v1, v2, v3)
and closure54 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = ""
    let v7 : string = v6 + v6 
    let v8 : string = "i"
    let v9 : string = v7 + v8 
    let v10 : string = " = "
    let v11 : string = v9 + v10 
    let v12 : string = format_real_79(v1)
    let v13 : string = v11 + v12 
    let v14 : string = "; "
    let v15 : string = v13 + v14 
    let v16 : string = "s"
    let v17 : string = v15 + v16 
    let v18 : string = v17 + v10 
    let v19 : string = v6 + v6 
    let v20 : string = "line_start"
    let v21 : string = v19 + v20 
    let v22 : string = v21 + v10 
    let v23 : string = format_real_79(v2)
    let v24 : string = v22 + v23 
    let v25 : string = v24 + v14 
    let v26 : string = "position"
    let v27 : string = v25 + v26 
    let v28 : string = v27 + v10 
    let v29 : string = v6 + v6 
    let v30 : string = "line"
    let v31 : string = v29 + v30 
    let v32 : string = v31 + v10 
    let v33 : string = format_real_79(v3)
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v14 
    let v36 : string = "col"
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v10 
    let v39 : string = format_real_79(v4)
    let v40 : string = v38 + v39 
    let v41 : string = "{ "
    let v42 : string = v41 + v40 
    let v43 : string = " }"
    let v44 : string = v42 + v43 
    let v45 : string = v28 + v44 
    let v46 : string = v45 + v14 
    let v47 : string = "text_length"
    let v48 : string = v46 + v47 
    let v49 : string = v48 + v10 
    let v50 : string = format_real_79(v5)
    let v51 : string = v49 + v50 
    let v52 : string = v41 + v51 
    let v53 : string = v52 + v43 
    let v54 : string = v18 + v53 
    let v55 : string = v41 + v54 
    let v56 : string = v55 + v43 
    let v57 : string = "parsing.many1_satisfy / no matching char / "
    let v58 : string = v57 + v56 
    v58
and closure55 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : char list = []
    let v7 : char list = '"' :: v6 
    let v8 : (char list -> (char [])) = List.toArray
    let v9 : (char []) = v8 v7
    let v10 : string = method82(v9)
    let v11 : string = ""
    let v12 : string = v11 + v11 
    let v13 : string = "chars'"
    let v14 : string = v12 + v13 
    let v15 : string = " = "
    let v16 : string = v14 + v15 
    let v17 : string = v16 + v10 
    let v18 : string = "; "
    let v19 : string = v17 + v18 
    let v20 : string = "s"
    let v21 : string = v19 + v20 
    let v22 : string = v21 + v15 
    let v23 : string = v11 + v11 
    let v24 : string = "line_start"
    let v25 : string = v23 + v24 
    let v26 : string = v25 + v15 
    let v27 : string = format_real_79(v2)
    let v28 : string = v26 + v27 
    let v29 : string = v28 + v18 
    let v30 : string = "position"
    let v31 : string = v29 + v30 
    let v32 : string = v31 + v15 
    let v33 : string = v11 + v11 
    let v34 : string = "line"
    let v35 : string = v33 + v34 
    let v36 : string = v35 + v15 
    let v37 : string = format_real_79(v3)
    let v38 : string = v36 + v37 
    let v39 : string = v38 + v18 
    let v40 : string = "col"
    let v41 : string = v39 + v40 
    let v42 : string = v41 + v15 
    let v43 : string = format_real_79(v4)
    let v44 : string = v42 + v43 
    let v45 : string = "{ "
    let v46 : string = v45 + v44 
    let v47 : string = " }"
    let v48 : string = v46 + v47 
    let v49 : string = v32 + v48 
    let v50 : string = v49 + v18 
    let v51 : string = "text_length"
    let v52 : string = v50 + v51 
    let v53 : string = v52 + v15 
    let v54 : string = format_real_79(v5)
    let v55 : string = v53 + v54 
    let v56 : string = v45 + v55 
    let v57 : string = v56 + v47 
    let v58 : string = v22 + v57 
    let v59 : string = v45 + v58 
    let v60 : string = v59 + v47 
    let v61 : string = "parsing.none_of / unexpected end of text / "
    let v62 : string = v61 + v60 
    v62
and closure56 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : char = (spiralStringIndex v0 (int v1))
    let v7 : char list = []
    let v8 : char list = '"' :: v7 
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v11 : string = method82(v10)
    let v12 : string = ""
    let v13 : string = v12 + v12 
    let v14 : string = "first_char"
    let v15 : string = v13 + v14 
    let v16 : string = " = "
    let v17 : string = v15 + v16 
    let v18 : string = format_real_10(v6)
    let v19 : string = v17 + v18 
    let v20 : string = "; "
    let v21 : string = v19 + v20 
    let v22 : string = "chars'"
    let v23 : string = v21 + v22 
    let v24 : string = v23 + v16 
    let v25 : string = v24 + v11 
    let v26 : string = v25 + v20 
    let v27 : string = "s"
    let v28 : string = v26 + v27 
    let v29 : string = v28 + v16 
    let v30 : string = v12 + v12 
    let v31 : string = "line_start"
    let v32 : string = v30 + v31 
    let v33 : string = v32 + v16 
    let v34 : string = format_real_79(v2)
    let v35 : string = v33 + v34 
    let v36 : string = v35 + v20 
    let v37 : string = "position"
    let v38 : string = v36 + v37 
    let v39 : string = v38 + v16 
    let v40 : string = v12 + v12 
    let v41 : string = "line"
    let v42 : string = v40 + v41 
    let v43 : string = v42 + v16 
    let v44 : string = format_real_79(v3)
    let v45 : string = v43 + v44 
    let v46 : string = v45 + v20 
    let v47 : string = "col"
    let v48 : string = v46 + v47 
    let v49 : string = v48 + v16 
    let v50 : string = format_real_79(v4)
    let v51 : string = v49 + v50 
    let v52 : string = "{ "
    let v53 : string = v52 + v51 
    let v54 : string = " }"
    let v55 : string = v53 + v54 
    let v56 : string = v39 + v55 
    let v57 : string = v56 + v20 
    let v58 : string = "text_length"
    let v59 : string = v57 + v58 
    let v60 : string = v59 + v16 
    let v61 : string = format_real_79(v5)
    let v62 : string = v60 + v61 
    let v63 : string = v52 + v62 
    let v64 : string = v63 + v54 
    let v65 : string = v29 + v64 
    let v66 : string = v52 + v65 
    let v67 : string = v66 + v54 
    let v68 : string = "parsing.none_of / unexpected char / "
    let v69 : string = v68 + v67 
    v69
and closure57 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = "parsing.many_strings / first inner parser consumed no text"
    v6
and pass_92 (v0 : bool, v1 : UH0, v2 : UH0) : UH0 =
    match v1 with
    | UH0_Cons(v3, v4) -> (* Cons *)
        match v4 with
        | UH0_Cons(v5, v6) -> (* Cons *)
            let v9 : string =
                if v0 then
                    let v7 : string = v5 + v3 
                    v7
                else
                    let v8 : string = v3 + v5 
                    v8
            let v10 : UH0 = UH0_Cons(v9, v2)
            pass_92(v0, v6, v10)
        | UH0_Nil -> (* Nil *)
            UH0_Cons(v3, v2)
    | UH0_Nil -> (* Nil *)
        v2
and method91 (v0 : bool, v1 : UH0) : string =
    match v1 with
    | UH0_Cons(v3, v4) -> (* Cons *)
        match v4 with
        | UH0_Nil -> (* Nil *)
            v3
        | _ ->
            let v5 : bool = v0 = false
            let v6 : UH0 = UH0_Nil
            let v7 : UH0 = pass_92(v0, v1, v6)
            method91(v5, v7)
    | UH0_Nil -> (* Nil *)
        let v2 : string = ""
        v2
and closure58 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = "parsing.many_strings / inner parser succeeded without consuming text"
    v6
and method90 (v0 : string, v1 : string, v2 : UH0, v3 : int32, v4 : int32, v5 : int32, v6 : int32, v7 : int32) : US19 =
    let struct (v8 : int32, v9 : int32, v10 : int32, v11 : int32, v12 : int32) = method88(v4, v5, v6, v7, v0, v3)
    let v13 : bool = v8 > v3
    let v23 : US19 =
        if v13 then
            let v14 : bool = v3 >= v8
            let v19 : string =
                if v14 then
                    let v15 : string = ""
                    v15
                else
                    let v16 : bool = v3 = v8
                    let v17 : int32 = v8 - 1
                    let v18 : string = (spiralStringSlice v0 (int v3) (int v17))
                    v18
            US19_Ok(v19, v8, v9, v10, v11, v12)
        else
            let v21 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure54()
            US19_Error(v21, v3, v4, v5, v6, v7)
    let v218 : US19 =
        match v23 with
        | US19_Error(v30, v31, v32, v33, v34, v35) -> (* Error *)
            let v36 : bool = v3 >= v7
            let v54 : US18 =
                if v36 then
                    let v37 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure50()
                    US18_Error(v37, v3, v4, v5, v6, v7)
                else
                    let v39 : char = (spiralStringIndex v0 (int v3))
                    let v40 : bool = v39 = '\\'
                    if v40 then
                        let v41 : int32 = v3 + 1
                        let v42 : bool = '\n' = v39
                        let struct (v46 : int32, v47 : int32, v48 : int32, v49 : int32) =
                            if v42 then
                                let v43 : int32 = v4 + v6
                                let v44 : int32 = v5 + 1
                                struct (v43, v44, 1, v7)
                            else
                                let v45 : int32 = v6 + 1
                                struct (v4, v5, v45, v7)
                        US18_Ok('\\', v41, v46, v47, v48, v49)
                    else
                        let v51 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure51()
                        US18_Error(v51, v3, v4, v5, v6, v7)
            let v89 : US18 =
                match v54 with
                | US18_Error(v81, v82, v83, v84, v85, v86) -> (* Error *)
                    US18_Error(v81, v82, v83, v84, v85, v86)
                | US18_Ok(v55, v56, v57, v58, v59, v60) -> (* Ok *)
                    let v61 : bool = v56 >= v60
                    if v61 then
                        let v62 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure55()
                        US18_Error(v62, v56, v57, v58, v59, v60)
                    else
                        let v64 : char = (spiralStringIndex v0 (int v56))
                        let v65 : bool = v64 = '"'
                        let v66 : bool = v65 = false
                        if v66 then
                            let v67 : int32 = v56 + 1
                            let v68 : bool = '\n' = v64
                            let struct (v72 : int32, v73 : int32, v74 : int32, v75 : int32) =
                                if v68 then
                                    let v69 : int32 = v57 + v59
                                    let v70 : int32 = v58 + 1
                                    struct (v69, v70, 1, v60)
                                else
                                    let v71 : int32 = v59 + 1
                                    struct (v57, v58, v71, v60)
                            US18_Ok(v64, v67, v72, v73, v74, v75)
                        else
                            let v77 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                            US18_Error(v77, v56, v57, v58, v59, v60)
            let v111 : US19 =
                match v89 with
                | US18_Error(v103, v104, v105, v106, v107, v108) -> (* Error *)
                    US19_Error(v103, v104, v105, v106, v107, v108)
                | US18_Ok(v90, v91, v92, v93, v94, v95) -> (* Ok *)
                    let v96 : bool = v3 >= v91
                    let v101 : string =
                        if v96 then
                            let v97 : string = ""
                            v97
                        else
                            let v98 : bool = v3 = v91
                            let v99 : int32 = v91 - 1
                            let v100 : string = (spiralStringSlice v0 (int v3) (int v99))
                            v100
                    US19_Ok(v101, v91, v92, v93, v94, v95)
            match v111 with
            | US19_Error(v118, v119, v120, v121, v122, v123) -> (* Error *)
                let v141 : US18 =
                    if v36 then
                        let v124 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure52()
                        US18_Error(v124, v3, v4, v5, v6, v7)
                    else
                        let v126 : char = (spiralStringIndex v0 (int v3))
                        let v127 : bool = v126 = '`'
                        if v127 then
                            let v128 : int32 = v3 + 1
                            let v129 : bool = '\n' = v126
                            let struct (v133 : int32, v134 : int32, v135 : int32, v136 : int32) =
                                if v129 then
                                    let v130 : int32 = v4 + v6
                                    let v131 : int32 = v5 + 1
                                    struct (v130, v131, 1, v7)
                                else
                                    let v132 : int32 = v6 + 1
                                    struct (v4, v5, v132, v7)
                            US18_Ok('`', v128, v133, v134, v135, v136)
                        else
                            let v138 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure53()
                            US18_Error(v138, v3, v4, v5, v6, v7)
                let v176 : US18 =
                    match v141 with
                    | US18_Error(v168, v169, v170, v171, v172, v173) -> (* Error *)
                        US18_Error(v168, v169, v170, v171, v172, v173)
                    | US18_Ok(v142, v143, v144, v145, v146, v147) -> (* Ok *)
                        let v148 : bool = v143 >= v147
                        if v148 then
                            let v149 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure55()
                            US18_Error(v149, v143, v144, v145, v146, v147)
                        else
                            let v151 : char = (spiralStringIndex v0 (int v143))
                            let v152 : bool = v151 = '"'
                            let v153 : bool = v152 = false
                            if v153 then
                                let v154 : int32 = v143 + 1
                                let v155 : bool = '\n' = v151
                                let struct (v159 : int32, v160 : int32, v161 : int32, v162 : int32) =
                                    if v155 then
                                        let v156 : int32 = v144 + v146
                                        let v157 : int32 = v145 + 1
                                        struct (v156, v157, 1, v147)
                                    else
                                        let v158 : int32 = v146 + 1
                                        struct (v144, v145, v158, v147)
                                US18_Ok(v151, v154, v159, v160, v161, v162)
                            else
                                let v164 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                                US18_Error(v164, v143, v144, v145, v146, v147)
                let v198 : US19 =
                    match v176 with
                    | US18_Error(v190, v191, v192, v193, v194, v195) -> (* Error *)
                        US19_Error(v190, v191, v192, v193, v194, v195)
                    | US18_Ok(v177, v178, v179, v180, v181, v182) -> (* Ok *)
                        let v183 : bool = v3 >= v178
                        let v188 : string =
                            if v183 then
                                let v184 : string = ""
                                v184
                            else
                                let v185 : bool = v3 = v178
                                let v186 : int32 = v178 - 1
                                let v187 : string = (spiralStringSlice v0 (int v3) (int v186))
                                v187
                        US19_Ok(v188, v178, v179, v180, v181, v182)
                match v198 with
                | US19_Error(v205, v206, v207, v208, v209, v210) -> (* Error *)
                    let v211 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure35()
                    US19_Error(v211, v3, v4, v5, v6, v7)
                | US19_Ok(v199, v200, v201, v202, v203, v204) -> (* Ok *)
                    v198
            | US19_Ok(v112, v113, v114, v115, v116, v117) -> (* Ok *)
                v111
        | US19_Ok(v24, v25, v26, v27, v28, v29) -> (* Ok *)
            v23
    match v218 with
    | US19_Error(v219, v220, v221, v222, v223, v224) -> (* Error *)
        let v228 : string =
            match v2 with
            | UH0_Nil -> (* Nil *)
                v1
            | _ ->
                let v225 : bool = true
                let v226 : string = method91(v225, v2)
                let v227 : string = v1 + v226 
                v227
        US19_Ok(v228, v3, v4, v5, v6, v7)
    | US19_Ok(v230, v231, v232, v233, v234, v235) -> (* Ok *)
        let v236 : bool = v231 > v3
        if v236 then
            let v237 : UH0 = UH0_Cons(v230, v2)
            method90(v0, v1, v237, v231, v232, v233, v234, v235)
        else
            let v239 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure58()
            US19_Error(v239, v3, v4, v5, v6, v7)
and closure59 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = ""
    let v7 : string = v6 + v6 
    let v8 : string = "s"
    let v9 : string = v7 + v8 
    let v10 : string = " = "
    let v11 : string = v9 + v10 
    let v12 : string = v6 + v6 
    let v13 : string = "line_start"
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v10 
    let v16 : string = format_real_79(v2)
    let v17 : string = v15 + v16 
    let v18 : string = "; "
    let v19 : string = v17 + v18 
    let v20 : string = "position"
    let v21 : string = v19 + v20 
    let v22 : string = v21 + v10 
    let v23 : string = v6 + v6 
    let v24 : string = "line"
    let v25 : string = v23 + v24 
    let v26 : string = v25 + v10 
    let v27 : string = format_real_79(v3)
    let v28 : string = v26 + v27 
    let v29 : string = v28 + v18 
    let v30 : string = "col"
    let v31 : string = v29 + v30 
    let v32 : string = v31 + v10 
    let v33 : string = format_real_79(v4)
    let v34 : string = v32 + v33 
    let v35 : string = "{ "
    let v36 : string = v35 + v34 
    let v37 : string = " }"
    let v38 : string = v36 + v37 
    let v39 : string = v22 + v38 
    let v40 : string = v39 + v18 
    let v41 : string = "text_length"
    let v42 : string = v40 + v41 
    let v43 : string = v42 + v10 
    let v44 : string = format_real_79(v5)
    let v45 : string = v43 + v44 
    let v46 : string = v35 + v45 
    let v47 : string = v46 + v37 
    let v48 : string = v11 + v47 
    let v49 : string = v35 + v48 
    let v50 : string = v49 + v37 
    let v51 : string = "parsing.any_char / unexpected end of t / "
    let v52 : string = v51 + v50 
    v52
and method93 (v0 : string, v1 : string, v2 : UH0, v3 : int32, v4 : int32, v5 : int32, v6 : int32, v7 : int32) : US19 =
    let struct (v8 : int32, v9 : int32, v10 : int32, v11 : int32, v12 : int32) = method88(v4, v5, v6, v7, v0, v3)
    let v13 : bool = v8 > v3
    let v23 : US19 =
        if v13 then
            let v14 : bool = v3 >= v8
            let v19 : string =
                if v14 then
                    let v15 : string = ""
                    v15
                else
                    let v16 : bool = v3 = v8
                    let v17 : int32 = v8 - 1
                    let v18 : string = (spiralStringSlice v0 (int v3) (int v17))
                    v18
            US19_Ok(v19, v8, v9, v10, v11, v12)
        else
            let v21 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure54()
            US19_Error(v21, v3, v4, v5, v6, v7)
    let v208 : US19 =
        match v23 with
        | US19_Error(v30, v31, v32, v33, v34, v35) -> (* Error *)
            let v36 : bool = v3 >= v7
            let v54 : US18 =
                if v36 then
                    let v37 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure50()
                    US18_Error(v37, v3, v4, v5, v6, v7)
                else
                    let v39 : char = (spiralStringIndex v0 (int v3))
                    let v40 : bool = v39 = '\\'
                    if v40 then
                        let v41 : int32 = v3 + 1
                        let v42 : bool = '\n' = v39
                        let struct (v46 : int32, v47 : int32, v48 : int32, v49 : int32) =
                            if v42 then
                                let v43 : int32 = v4 + v6
                                let v44 : int32 = v5 + 1
                                struct (v43, v44, 1, v7)
                            else
                                let v45 : int32 = v6 + 1
                                struct (v4, v5, v45, v7)
                        US18_Ok('\\', v41, v46, v47, v48, v49)
                    else
                        let v51 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure51()
                        US18_Error(v51, v3, v4, v5, v6, v7)
            let v84 : US18 =
                match v54 with
                | US18_Error(v76, v77, v78, v79, v80, v81) -> (* Error *)
                    US18_Error(v76, v77, v78, v79, v80, v81)
                | US18_Ok(v55, v56, v57, v58, v59, v60) -> (* Ok *)
                    let v61 : bool = v56 >= v60
                    if v61 then
                        let v62 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                        US18_Error(v62, v56, v57, v58, v59, v60)
                    else
                        let v64 : char = (spiralStringIndex v0 (int v56))
                        let v65 : int32 = v56 + 1
                        let v66 : bool = '\n' = v64
                        let struct (v70 : int32, v71 : int32, v72 : int32, v73 : int32) =
                            if v66 then
                                let v67 : int32 = v57 + v59
                                let v68 : int32 = v58 + 1
                                struct (v67, v68, 1, v60)
                            else
                                let v69 : int32 = v59 + 1
                                struct (v57, v58, v69, v60)
                        US18_Ok(v64, v65, v70, v71, v72, v73)
            let v106 : US19 =
                match v84 with
                | US18_Error(v98, v99, v100, v101, v102, v103) -> (* Error *)
                    US19_Error(v98, v99, v100, v101, v102, v103)
                | US18_Ok(v85, v86, v87, v88, v89, v90) -> (* Ok *)
                    let v91 : bool = v3 >= v86
                    let v96 : string =
                        if v91 then
                            let v92 : string = ""
                            v92
                        else
                            let v93 : bool = v3 = v86
                            let v94 : int32 = v86 - 1
                            let v95 : string = (spiralStringSlice v0 (int v3) (int v94))
                            v95
                    US19_Ok(v96, v86, v87, v88, v89, v90)
            match v106 with
            | US19_Error(v113, v114, v115, v116, v117, v118) -> (* Error *)
                let v136 : US18 =
                    if v36 then
                        let v119 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure52()
                        US18_Error(v119, v3, v4, v5, v6, v7)
                    else
                        let v121 : char = (spiralStringIndex v0 (int v3))
                        let v122 : bool = v121 = '`'
                        if v122 then
                            let v123 : int32 = v3 + 1
                            let v124 : bool = '\n' = v121
                            let struct (v128 : int32, v129 : int32, v130 : int32, v131 : int32) =
                                if v124 then
                                    let v125 : int32 = v4 + v6
                                    let v126 : int32 = v5 + 1
                                    struct (v125, v126, 1, v7)
                                else
                                    let v127 : int32 = v6 + 1
                                    struct (v4, v5, v127, v7)
                            US18_Ok('`', v123, v128, v129, v130, v131)
                        else
                            let v133 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure53()
                            US18_Error(v133, v3, v4, v5, v6, v7)
                let v166 : US18 =
                    match v136 with
                    | US18_Error(v158, v159, v160, v161, v162, v163) -> (* Error *)
                        US18_Error(v158, v159, v160, v161, v162, v163)
                    | US18_Ok(v137, v138, v139, v140, v141, v142) -> (* Ok *)
                        let v143 : bool = v138 >= v142
                        if v143 then
                            let v144 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                            US18_Error(v144, v138, v139, v140, v141, v142)
                        else
                            let v146 : char = (spiralStringIndex v0 (int v138))
                            let v147 : int32 = v138 + 1
                            let v148 : bool = '\n' = v146
                            let struct (v152 : int32, v153 : int32, v154 : int32, v155 : int32) =
                                if v148 then
                                    let v149 : int32 = v139 + v141
                                    let v150 : int32 = v140 + 1
                                    struct (v149, v150, 1, v142)
                                else
                                    let v151 : int32 = v141 + 1
                                    struct (v139, v140, v151, v142)
                            US18_Ok(v146, v147, v152, v153, v154, v155)
                let v188 : US19 =
                    match v166 with
                    | US18_Error(v180, v181, v182, v183, v184, v185) -> (* Error *)
                        US19_Error(v180, v181, v182, v183, v184, v185)
                    | US18_Ok(v167, v168, v169, v170, v171, v172) -> (* Ok *)
                        let v173 : bool = v3 >= v168
                        let v178 : string =
                            if v173 then
                                let v174 : string = ""
                                v174
                            else
                                let v175 : bool = v3 = v168
                                let v176 : int32 = v168 - 1
                                let v177 : string = (spiralStringSlice v0 (int v3) (int v176))
                                v177
                        US19_Ok(v178, v168, v169, v170, v171, v172)
                match v188 with
                | US19_Error(v195, v196, v197, v198, v199, v200) -> (* Error *)
                    let v201 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure35()
                    US19_Error(v201, v3, v4, v5, v6, v7)
                | US19_Ok(v189, v190, v191, v192, v193, v194) -> (* Ok *)
                    v188
            | US19_Ok(v107, v108, v109, v110, v111, v112) -> (* Ok *)
                v106
        | US19_Ok(v24, v25, v26, v27, v28, v29) -> (* Ok *)
            v23
    match v208 with
    | US19_Error(v209, v210, v211, v212, v213, v214) -> (* Error *)
        let v218 : string =
            match v2 with
            | UH0_Nil -> (* Nil *)
                v1
            | _ ->
                let v215 : bool = true
                let v216 : string = method91(v215, v2)
                let v217 : string = v1 + v216 
                v217
        US19_Ok(v218, v3, v4, v5, v6, v7)
    | US19_Ok(v220, v221, v222, v223, v224, v225) -> (* Ok *)
        let v226 : bool = v221 > v3
        if v226 then
            let v227 : UH0 = UH0_Cons(v220, v2)
            method93(v0, v1, v227, v221, v222, v223, v224, v225)
        else
            let v229 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure58()
            US19_Error(v229, v3, v4, v5, v6, v7)
and method95 (v0 : int32, v1 : string, v2 : int32, v3 : int32, v4 : int32, v5 : int32, v6 : int32) : struct (int32 * int32 * int32 * int32 * int32) =
    let v7 : bool = v2 >= v0
    if v7 then
        struct (v2, v3, v4, v5, v6)
    else
        let v8 : char = (spiralStringIndex v1 (int v2))
        let v9 : bool = v8 = '\\'
        let v15 : bool =
            if v9 then
                true
            else
                let v10 : bool = v8 = '`'
                if v10 then
                    true
                else
                    let v11 : bool = v8 = '"'
                    if v11 then
                        true
                    else
                        let v12 : bool = v8 = ' '
                        v12
        let v16 : bool = v15 = false
        if v16 then
            let v17 : int32 = v2 + 1
            let v18 : bool = '\n' = v8
            let struct (v22 : int32, v23 : int32, v24 : int32, v25 : int32) =
                if v18 then
                    let v19 : int32 = v3 + v5
                    let v20 : int32 = v4 + 1
                    struct (v19, v20, 1, v6)
                else
                    let v21 : int32 = v5 + 1
                    struct (v3, v4, v21, v6)
            method95(v0, v1, v17, v22, v23, v24, v25)
        else
            struct (v2, v3, v4, v5, v6)
and method94 (v0 : int32, v1 : string, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : struct (int32 * int32 * int32 * int32 * int32) =
    let v6 : bool = v2 >= v0
    if v6 then
        struct (v2, v3, v4, v5, v0)
    else
        let v7 : char = (spiralStringIndex v1 (int v2))
        let v8 : bool = v7 = '\\'
        let v14 : bool =
            if v8 then
                true
            else
                let v9 : bool = v7 = '`'
                if v9 then
                    true
                else
                    let v10 : bool = v7 = '"'
                    if v10 then
                        true
                    else
                        let v11 : bool = v7 = ' '
                        v11
        let v15 : bool = v14 = false
        if v15 then
            let v16 : int32 = v2 + 1
            let v17 : bool = '\n' = v7
            let struct (v21 : int32, v22 : int32, v23 : int32, v24 : int32) =
                if v17 then
                    let v18 : int32 = v3 + v5
                    let v19 : int32 = v4 + 1
                    struct (v18, v19, 1, v0)
                else
                    let v20 : int32 = v5 + 1
                    struct (v3, v4, v20, v0)
            method95(v0, v1, v16, v21, v22, v23, v24)
        else
            struct (v2, v3, v4, v5, v0)
and closure60 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : char list = []
    let v7 : char list = '"' :: v6 
    let v8 : char list = '`' :: v7 
    let v9 : char list = '\\' :: v8 
    let v10 : (char list -> (char [])) = List.toArray
    let v11 : (char []) = v10 v9
    let v12 : string = method82(v11)
    let v13 : string = ""
    let v14 : string = v13 + v13 
    let v15 : string = "chars'"
    let v16 : string = v14 + v15 
    let v17 : string = " = "
    let v18 : string = v16 + v17 
    let v19 : string = v18 + v12 
    let v20 : string = "; "
    let v21 : string = v19 + v20 
    let v22 : string = "s"
    let v23 : string = v21 + v22 
    let v24 : string = v23 + v17 
    let v25 : string = v13 + v13 
    let v26 : string = "line_start"
    let v27 : string = v25 + v26 
    let v28 : string = v27 + v17 
    let v29 : string = format_real_79(v2)
    let v30 : string = v28 + v29 
    let v31 : string = v30 + v20 
    let v32 : string = "position"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v17 
    let v35 : string = v13 + v13 
    let v36 : string = "line"
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v17 
    let v39 : string = format_real_79(v3)
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v20 
    let v42 : string = "col"
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v17 
    let v45 : string = format_real_79(v4)
    let v46 : string = v44 + v45 
    let v47 : string = "{ "
    let v48 : string = v47 + v46 
    let v49 : string = " }"
    let v50 : string = v48 + v49 
    let v51 : string = v34 + v50 
    let v52 : string = v51 + v20 
    let v53 : string = "text_length"
    let v54 : string = v52 + v53 
    let v55 : string = v54 + v17 
    let v56 : string = format_real_79(v5)
    let v57 : string = v55 + v56 
    let v58 : string = v47 + v57 
    let v59 : string = v58 + v49 
    let v60 : string = v24 + v59 
    let v61 : string = v47 + v60 
    let v62 : string = v61 + v49 
    let v63 : string = "parsing.none_of / unexpected end of text / "
    let v64 : string = v63 + v62 
    v64
and closure61 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : char = (spiralStringIndex v0 (int v1))
    let v7 : char list = []
    let v8 : char list = '"' :: v7 
    let v9 : char list = '`' :: v8 
    let v10 : char list = '\\' :: v9 
    let v11 : (char list -> (char [])) = List.toArray
    let v12 : (char []) = v11 v10
    let v13 : string = method82(v12)
    let v14 : string = ""
    let v15 : string = v14 + v14 
    let v16 : string = "first_char"
    let v17 : string = v15 + v16 
    let v18 : string = " = "
    let v19 : string = v17 + v18 
    let v20 : string = format_real_10(v6)
    let v21 : string = v19 + v20 
    let v22 : string = "; "
    let v23 : string = v21 + v22 
    let v24 : string = "chars'"
    let v25 : string = v23 + v24 
    let v26 : string = v25 + v18 
    let v27 : string = v26 + v13 
    let v28 : string = v27 + v22 
    let v29 : string = "s"
    let v30 : string = v28 + v29 
    let v31 : string = v30 + v18 
    let v32 : string = v14 + v14 
    let v33 : string = "line_start"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v18 
    let v36 : string = format_real_79(v2)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v22 
    let v39 : string = "position"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v18 
    let v42 : string = v14 + v14 
    let v43 : string = "line"
    let v44 : string = v42 + v43 
    let v45 : string = v44 + v18 
    let v46 : string = format_real_79(v3)
    let v47 : string = v45 + v46 
    let v48 : string = v47 + v22 
    let v49 : string = "col"
    let v50 : string = v48 + v49 
    let v51 : string = v50 + v18 
    let v52 : string = format_real_79(v4)
    let v53 : string = v51 + v52 
    let v54 : string = "{ "
    let v55 : string = v54 + v53 
    let v56 : string = " }"
    let v57 : string = v55 + v56 
    let v58 : string = v41 + v57 
    let v59 : string = v58 + v22 
    let v60 : string = "text_length"
    let v61 : string = v59 + v60 
    let v62 : string = v61 + v18 
    let v63 : string = format_real_79(v5)
    let v64 : string = v62 + v63 
    let v65 : string = v54 + v64 
    let v66 : string = v65 + v56 
    let v67 : string = v31 + v66 
    let v68 : string = v54 + v67 
    let v69 : string = v68 + v56 
    let v70 : string = "parsing.none_of / unexpected char / "
    let v71 : string = v70 + v69 
    v71
and method97 (v0 : UH0, v1 : UH0) : UH0 =
    match v0 with
    | UH0_Cons(v2, v3) -> (* Cons *)
        let v4 : UH0 = UH0_Cons(v2, v1)
        method97(v3, v4)
    | UH0_Nil -> (* Nil *)
        v1
and closure62 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = "parsing.many / inner parser succeeded without consuming text"
    v6
and method96 (v0 : string, v1 : UH0, v2 : int32, v3 : int32, v4 : int32, v5 : int32, v6 : int32) : US27 =
    let v7 : bool = v2 >= v6
    let v25 : US18 =
        if v7 then
            let v8 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure50()
            US18_Error(v8, v2, v3, v4, v5, v6)
        else
            let v10 : char = (spiralStringIndex v0 (int v2))
            let v11 : bool = v10 = '\\'
            if v11 then
                let v12 : int32 = v2 + 1
                let v13 : bool = '\n' = v10
                let struct (v17 : int32, v18 : int32, v19 : int32, v20 : int32) =
                    if v13 then
                        let v14 : int32 = v3 + v5
                        let v15 : int32 = v4 + 1
                        struct (v14, v15, 1, v6)
                    else
                        let v16 : int32 = v5 + 1
                        struct (v3, v4, v16, v6)
                US18_Ok('\\', v12, v17, v18, v19, v20)
            else
                let v22 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure51()
                US18_Error(v22, v2, v3, v4, v5, v6)
    let v55 : US18 =
        match v25 with
        | US18_Error(v47, v48, v49, v50, v51, v52) -> (* Error *)
            US18_Error(v47, v48, v49, v50, v51, v52)
        | US18_Ok(v26, v27, v28, v29, v30, v31) -> (* Ok *)
            let v32 : bool = v27 >= v31
            if v32 then
                let v33 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                US18_Error(v33, v27, v28, v29, v30, v31)
            else
                let v35 : char = (spiralStringIndex v0 (int v27))
                let v36 : int32 = v27 + 1
                let v37 : bool = '\n' = v35
                let struct (v41 : int32, v42 : int32, v43 : int32, v44 : int32) =
                    if v37 then
                        let v38 : int32 = v28 + v30
                        let v39 : int32 = v29 + 1
                        struct (v38, v39, 1, v31)
                    else
                        let v40 : int32 = v30 + 1
                        struct (v28, v29, v40, v31)
                US18_Ok(v35, v36, v41, v42, v43, v44)
    let v77 : US19 =
        match v55 with
        | US18_Error(v69, v70, v71, v72, v73, v74) -> (* Error *)
            US19_Error(v69, v70, v71, v72, v73, v74)
        | US18_Ok(v56, v57, v58, v59, v60, v61) -> (* Ok *)
            let v62 : bool = v2 >= v57
            let v67 : string =
                if v62 then
                    let v63 : string = ""
                    v63
                else
                    let v64 : bool = v2 = v57
                    let v65 : int32 = v57 - 1
                    let v66 : string = (spiralStringSlice v0 (int v2) (int v65))
                    v66
            US19_Ok(v67, v57, v58, v59, v60, v61)
    let v177 : US19 =
        match v77 with
        | US19_Error(v84, v85, v86, v87, v88, v89) -> (* Error *)
            let v107 : US18 =
                if v7 then
                    let v90 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure52()
                    US18_Error(v90, v2, v3, v4, v5, v6)
                else
                    let v92 : char = (spiralStringIndex v0 (int v2))
                    let v93 : bool = v92 = '`'
                    if v93 then
                        let v94 : int32 = v2 + 1
                        let v95 : bool = '\n' = v92
                        let struct (v99 : int32, v100 : int32, v101 : int32, v102 : int32) =
                            if v95 then
                                let v96 : int32 = v3 + v5
                                let v97 : int32 = v4 + 1
                                struct (v96, v97, 1, v6)
                            else
                                let v98 : int32 = v5 + 1
                                struct (v3, v4, v98, v6)
                        US18_Ok('`', v94, v99, v100, v101, v102)
                    else
                        let v104 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure53()
                        US18_Error(v104, v2, v3, v4, v5, v6)
            let v137 : US18 =
                match v107 with
                | US18_Error(v129, v130, v131, v132, v133, v134) -> (* Error *)
                    US18_Error(v129, v130, v131, v132, v133, v134)
                | US18_Ok(v108, v109, v110, v111, v112, v113) -> (* Ok *)
                    let v114 : bool = v109 >= v113
                    if v114 then
                        let v115 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                        US18_Error(v115, v109, v110, v111, v112, v113)
                    else
                        let v117 : char = (spiralStringIndex v0 (int v109))
                        let v118 : int32 = v109 + 1
                        let v119 : bool = '\n' = v117
                        let struct (v123 : int32, v124 : int32, v125 : int32, v126 : int32) =
                            if v119 then
                                let v120 : int32 = v110 + v112
                                let v121 : int32 = v111 + 1
                                struct (v120, v121, 1, v113)
                            else
                                let v122 : int32 = v112 + 1
                                struct (v110, v111, v122, v113)
                        US18_Ok(v117, v118, v123, v124, v125, v126)
            let v159 : US19 =
                match v137 with
                | US18_Error(v151, v152, v153, v154, v155, v156) -> (* Error *)
                    US19_Error(v151, v152, v153, v154, v155, v156)
                | US18_Ok(v138, v139, v140, v141, v142, v143) -> (* Ok *)
                    let v144 : bool = v2 >= v139
                    let v149 : string =
                        if v144 then
                            let v145 : string = ""
                            v145
                        else
                            let v146 : bool = v2 = v139
                            let v147 : int32 = v139 - 1
                            let v148 : string = (spiralStringSlice v0 (int v2) (int v147))
                            v148
                    US19_Ok(v149, v139, v140, v141, v142, v143)
            match v159 with
            | US19_Error(v166, v167, v168, v169, v170, v171) -> (* Error *)
                let v172 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure35()
                US19_Error(v172, v2, v3, v4, v5, v6)
            | US19_Ok(v160, v161, v162, v163, v164, v165) -> (* Ok *)
                v159
        | US19_Ok(v78, v79, v80, v81, v82, v83) -> (* Ok *)
            v77
    let v194 : US19 =
        match v177 with
        | US19_Error(v186, v187, v188, v189, v190, v191) -> (* Error *)
            US19_Error(v186, v187, v188, v189, v190, v191)
        | US19_Ok(v178, v179, v180, v181, v182, v183) -> (* Ok *)
            let v184 : string = ""
            US19_Ok(v184, v179, v180, v181, v182, v183)
    let v250 : US19 =
        match v194 with
        | US19_Error(v242, v243, v244, v245, v246, v247) -> (* Error *)
            US19_Error(v242, v243, v244, v245, v246, v247)
        | US19_Ok(v195, v196, v197, v198, v199, v200) -> (* Ok *)
            let v201 : bool = v196 >= v200
            let v224 : US18 =
                if v201 then
                    let v202 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure60()
                    US18_Error(v202, v196, v197, v198, v199, v200)
                else
                    let v204 : char = (spiralStringIndex v0 (int v196))
                    let v205 : bool = v204 = '\\'
                    let v209 : bool =
                        if v205 then
                            true
                        else
                            let v206 : bool = v204 = '`'
                            if v206 then
                                true
                            else
                                let v207 : bool = v204 = '"'
                                v207
                    let v210 : bool = v209 = false
                    if v210 then
                        let v211 : int32 = v196 + 1
                        let v212 : bool = '\n' = v204
                        let struct (v216 : int32, v217 : int32, v218 : int32, v219 : int32) =
                            if v212 then
                                let v213 : int32 = v197 + v199
                                let v214 : int32 = v198 + 1
                                struct (v213, v214, 1, v200)
                            else
                                let v215 : int32 = v199 + 1
                                struct (v197, v198, v215, v200)
                        US18_Ok(v204, v211, v216, v217, v218, v219)
                    else
                        let v221 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure61()
                        US18_Error(v221, v196, v197, v198, v199, v200)
            match v224 with
            | US18_Error(v233, v234, v235, v236, v237, v238) -> (* Error *)
                US19_Error(v233, v234, v235, v236, v237, v238)
            | US18_Ok(v225, v226, v227, v228, v229, v230) -> (* Ok *)
                let v231 : string = v225 |> _.ToString()
                US19_Ok(v231, v226, v227, v228, v229, v230)
    match v250 with
    | US19_Error(v251, v252, v253, v254, v255, v256) -> (* Error *)
        let v257 : UH0 = UH0_Nil
        let v258 : UH0 = method97(v1, v257)
        US27_Ok(v258, v2, v3, v4, v5, v6)
    | US19_Ok(v260, v261, v262, v263, v264, v265) -> (* Ok *)
        let v266 : bool = v261 > v2
        if v266 then
            let v267 : UH0 = UH0_Cons(v260, v1)
            method96(v0, v267, v261, v262, v263, v264, v265)
        else
            let v269 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure62()
            US27_Error(v269, v2, v3, v4, v5, v6)
and method98 (v0 : UH0, v1 : string) : struct (string * string) =
    let struct (v11 : string, v12 : string) =
        match v0 with
        | UH0_Cons(v2, v3) -> (* Cons *)
            let struct (v4 : string, v5 : string) = method98(v3, v1)
            let v6 : string = v2 + v5 
            let v7 : string = v6 + v4 
            let v8 : string = ""
            struct (v7, v8)
        | _ ->
            let struct (v9 : string, v10 : string) =
                match v0 with
                | UH0_Nil -> (* Nil *)
                    struct (v1, v1)
            struct (v9, v10)
    struct (v11, v12)
and closure63 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = "runtime.split_args / segment zero-length success"
    v6
and method101 (v0 : int32, v1 : int32, v2 : int32, v3 : int32, v4 : string, v5 : int32, v6 : int32, v7 : int32, v8 : int32, v9 : int32) : struct (int32 * int32 * int32 * int32 * int32) =
    let v10 : bool = v5 >= v3
    if v10 then
        struct (v5, v6, v7, v8, v9)
    else
        let v11 : char = (spiralStringIndex v4 (int v5))
        let v12 : bool = v11 = '\\'
        let v18 : bool =
            if v12 then
                true
            else
                let v13 : bool = v11 = '`'
                if v13 then
                    true
                else
                    let v14 : bool = v11 = '"'
                    if v14 then
                        true
                    else
                        let v15 : bool = v11 = ' '
                        v15
        let v19 : bool = v18 = false
        if v19 then
            let v20 : int32 = v5 + 1
            let v21 : bool = '\n' = v11
            let struct (v25 : int32, v26 : int32, v27 : int32, v28 : int32) =
                if v21 then
                    let v22 : int32 = v6 + v8
                    let v23 : int32 = v7 + 1
                    struct (v22, v23, 1, v9)
                else
                    let v24 : int32 = v8 + 1
                    struct (v6, v7, v24, v9)
            method101(v0, v1, v2, v3, v4, v20, v25, v26, v27, v28)
        else
            struct (v5, v6, v7, v8, v9)
and method100 (v0 : int32, v1 : int32, v2 : int32, v3 : int32, v4 : string, v5 : int32) : struct (int32 * int32 * int32 * int32 * int32) =
    let v6 : bool = v5 >= v3
    if v6 then
        struct (v5, v0, v1, v2, v3)
    else
        let v7 : char = (spiralStringIndex v4 (int v5))
        let v8 : bool = v7 = '\\'
        let v14 : bool =
            if v8 then
                true
            else
                let v9 : bool = v7 = '`'
                if v9 then
                    true
                else
                    let v10 : bool = v7 = '"'
                    if v10 then
                        true
                    else
                        let v11 : bool = v7 = ' '
                        v11
        let v15 : bool = v14 = false
        if v15 then
            let v16 : int32 = v5 + 1
            let v17 : bool = '\n' = v7
            let struct (v21 : int32, v22 : int32, v23 : int32, v24 : int32) =
                if v17 then
                    let v18 : int32 = v0 + v2
                    let v19 : int32 = v1 + 1
                    struct (v18, v19, 1, v3)
                else
                    let v20 : int32 = v2 + 1
                    struct (v0, v1, v20, v3)
            method101(v0, v1, v2, v3, v4, v16, v21, v22, v23, v24)
        else
            struct (v5, v0, v1, v2, v3)
and closure64 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = "parsing.many1_strings / inner parser succeeded without consuming text"
    v6
and method99 (v0 : string, v1 : string, v2 : UH0, v3 : int32, v4 : int32, v5 : int32, v6 : int32, v7 : int32) : US19 =
    let v8 : bool = v3 >= v7
    let v26 : US18 =
        if v8 then
            let v9 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure50()
            US18_Error(v9, v3, v4, v5, v6, v7)
        else
            let v11 : char = (spiralStringIndex v0 (int v3))
            let v12 : bool = v11 = '\\'
            if v12 then
                let v13 : int32 = v3 + 1
                let v14 : bool = '\n' = v11
                let struct (v18 : int32, v19 : int32, v20 : int32, v21 : int32) =
                    if v14 then
                        let v15 : int32 = v4 + v6
                        let v16 : int32 = v5 + 1
                        struct (v15, v16, 1, v7)
                    else
                        let v17 : int32 = v6 + 1
                        struct (v4, v5, v17, v7)
                US18_Ok('\\', v13, v18, v19, v20, v21)
            else
                let v23 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure51()
                US18_Error(v23, v3, v4, v5, v6, v7)
    let v60 : US18 =
        match v26 with
        | US18_Error(v52, v53, v54, v55, v56, v57) -> (* Error *)
            US18_Error(v52, v53, v54, v55, v56, v57)
        | US18_Ok(v27, v28, v29, v30, v31, v32) -> (* Ok *)
            let v33 : bool = v28 >= v32
            if v33 then
                let v34 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                US18_Error(v34, v28, v29, v30, v31, v32)
            else
                let v36 : char = (spiralStringIndex v0 (int v28))
                let v37 : bool = v36 = '"'
                if v37 then
                    let v38 : int32 = v28 + 1
                    let v39 : bool = '\n' = v36
                    let struct (v43 : int32, v44 : int32, v45 : int32, v46 : int32) =
                        if v39 then
                            let v40 : int32 = v29 + v31
                            let v41 : int32 = v30 + 1
                            struct (v40, v41, 1, v32)
                        else
                            let v42 : int32 = v31 + 1
                            struct (v29, v30, v42, v32)
                    US18_Ok('"', v38, v43, v44, v45, v46)
                else
                    let v48 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                    US18_Error(v48, v28, v29, v30, v31, v32)
    let v76 : US18 =
        match v60 with
        | US18_Error(v68, v69, v70, v71, v72, v73) -> (* Error *)
            US18_Error(v68, v69, v70, v71, v72, v73)
        | US18_Ok(v61, v62, v63, v64, v65, v66) -> (* Ok *)
            US18_Ok('"', v62, v63, v64, v65, v66)
    let v174 : US18 =
        match v76 with
        | US18_Error(v83, v84, v85, v86, v87, v88) -> (* Error *)
            let v106 : US18 =
                if v8 then
                    let v89 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure52()
                    US18_Error(v89, v3, v4, v5, v6, v7)
                else
                    let v91 : char = (spiralStringIndex v0 (int v3))
                    let v92 : bool = v91 = '`'
                    if v92 then
                        let v93 : int32 = v3 + 1
                        let v94 : bool = '\n' = v91
                        let struct (v98 : int32, v99 : int32, v100 : int32, v101 : int32) =
                            if v94 then
                                let v95 : int32 = v4 + v6
                                let v96 : int32 = v5 + 1
                                struct (v95, v96, 1, v7)
                            else
                                let v97 : int32 = v6 + 1
                                struct (v4, v5, v97, v7)
                        US18_Ok('`', v93, v98, v99, v100, v101)
                    else
                        let v103 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure53()
                        US18_Error(v103, v3, v4, v5, v6, v7)
            let v140 : US18 =
                match v106 with
                | US18_Error(v132, v133, v134, v135, v136, v137) -> (* Error *)
                    US18_Error(v132, v133, v134, v135, v136, v137)
                | US18_Ok(v107, v108, v109, v110, v111, v112) -> (* Ok *)
                    let v113 : bool = v108 >= v112
                    if v113 then
                        let v114 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                        US18_Error(v114, v108, v109, v110, v111, v112)
                    else
                        let v116 : char = (spiralStringIndex v0 (int v108))
                        let v117 : bool = v116 = '"'
                        if v117 then
                            let v118 : int32 = v108 + 1
                            let v119 : bool = '\n' = v116
                            let struct (v123 : int32, v124 : int32, v125 : int32, v126 : int32) =
                                if v119 then
                                    let v120 : int32 = v109 + v111
                                    let v121 : int32 = v110 + 1
                                    struct (v120, v121, 1, v112)
                                else
                                    let v122 : int32 = v111 + 1
                                    struct (v109, v110, v122, v112)
                            US18_Ok('"', v118, v123, v124, v125, v126)
                        else
                            let v128 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                            US18_Error(v128, v108, v109, v110, v111, v112)
            let v156 : US18 =
                match v140 with
                | US18_Error(v148, v149, v150, v151, v152, v153) -> (* Error *)
                    US18_Error(v148, v149, v150, v151, v152, v153)
                | US18_Ok(v141, v142, v143, v144, v145, v146) -> (* Ok *)
                    US18_Ok('"', v142, v143, v144, v145, v146)
            match v156 with
            | US18_Error(v163, v164, v165, v166, v167, v168) -> (* Error *)
                let v169 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure35()
                US18_Error(v169, v3, v4, v5, v6, v7)
            | US18_Ok(v157, v158, v159, v160, v161, v162) -> (* Ok *)
                v156
        | US18_Ok(v77, v78, v79, v80, v81, v82) -> (* Ok *)
            v76
    let v805 : US19 =
        match v174 with
        | US18_Error(v797, v798, v799, v800, v801, v802) -> (* Error *)
            US19_Error(v797, v798, v799, v800, v801, v802)
        | US18_Ok(v175, v176, v177, v178, v179, v180) -> (* Ok *)
            let struct (v181 : int32, v182 : int32, v183 : int32, v184 : int32, v185 : int32) = method88(v177, v178, v179, v180, v0, v176)
            let v186 : bool = v181 > v176
            let v196 : US19 =
                if v186 then
                    let v187 : bool = v176 >= v181
                    let v192 : string =
                        if v187 then
                            let v188 : string = ""
                            v188
                        else
                            let v189 : bool = v176 = v181
                            let v190 : int32 = v181 - 1
                            let v191 : string = (spiralStringSlice v0 (int v176) (int v190))
                            v191
                    US19_Ok(v192, v181, v182, v183, v184, v185)
                else
                    let v194 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure54()
                    US19_Error(v194, v176, v177, v178, v179, v180)
            let v391 : US19 =
                match v196 with
                | US19_Error(v203, v204, v205, v206, v207, v208) -> (* Error *)
                    let v209 : bool = v176 >= v180
                    let v227 : US18 =
                        if v209 then
                            let v210 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure50()
                            US18_Error(v210, v176, v177, v178, v179, v180)
                        else
                            let v212 : char = (spiralStringIndex v0 (int v176))
                            let v213 : bool = v212 = '\\'
                            if v213 then
                                let v214 : int32 = v176 + 1
                                let v215 : bool = '\n' = v212
                                let struct (v219 : int32, v220 : int32, v221 : int32, v222 : int32) =
                                    if v215 then
                                        let v216 : int32 = v177 + v179
                                        let v217 : int32 = v178 + 1
                                        struct (v216, v217, 1, v180)
                                    else
                                        let v218 : int32 = v179 + 1
                                        struct (v177, v178, v218, v180)
                                US18_Ok('\\', v214, v219, v220, v221, v222)
                            else
                                let v224 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure51()
                                US18_Error(v224, v176, v177, v178, v179, v180)
                    let v262 : US18 =
                        match v227 with
                        | US18_Error(v254, v255, v256, v257, v258, v259) -> (* Error *)
                            US18_Error(v254, v255, v256, v257, v258, v259)
                        | US18_Ok(v228, v229, v230, v231, v232, v233) -> (* Ok *)
                            let v234 : bool = v229 >= v233
                            if v234 then
                                let v235 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure55()
                                US18_Error(v235, v229, v230, v231, v232, v233)
                            else
                                let v237 : char = (spiralStringIndex v0 (int v229))
                                let v238 : bool = v237 = '"'
                                let v239 : bool = v238 = false
                                if v239 then
                                    let v240 : int32 = v229 + 1
                                    let v241 : bool = '\n' = v237
                                    let struct (v245 : int32, v246 : int32, v247 : int32, v248 : int32) =
                                        if v241 then
                                            let v242 : int32 = v230 + v232
                                            let v243 : int32 = v231 + 1
                                            struct (v242, v243, 1, v233)
                                        else
                                            let v244 : int32 = v232 + 1
                                            struct (v230, v231, v244, v233)
                                    US18_Ok(v237, v240, v245, v246, v247, v248)
                                else
                                    let v250 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                                    US18_Error(v250, v229, v230, v231, v232, v233)
                    let v284 : US19 =
                        match v262 with
                        | US18_Error(v276, v277, v278, v279, v280, v281) -> (* Error *)
                            US19_Error(v276, v277, v278, v279, v280, v281)
                        | US18_Ok(v263, v264, v265, v266, v267, v268) -> (* Ok *)
                            let v269 : bool = v176 >= v264
                            let v274 : string =
                                if v269 then
                                    let v270 : string = ""
                                    v270
                                else
                                    let v271 : bool = v176 = v264
                                    let v272 : int32 = v264 - 1
                                    let v273 : string = (spiralStringSlice v0 (int v176) (int v272))
                                    v273
                            US19_Ok(v274, v264, v265, v266, v267, v268)
                    match v284 with
                    | US19_Error(v291, v292, v293, v294, v295, v296) -> (* Error *)
                        let v314 : US18 =
                            if v209 then
                                let v297 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure52()
                                US18_Error(v297, v176, v177, v178, v179, v180)
                            else
                                let v299 : char = (spiralStringIndex v0 (int v176))
                                let v300 : bool = v299 = '`'
                                if v300 then
                                    let v301 : int32 = v176 + 1
                                    let v302 : bool = '\n' = v299
                                    let struct (v306 : int32, v307 : int32, v308 : int32, v309 : int32) =
                                        if v302 then
                                            let v303 : int32 = v177 + v179
                                            let v304 : int32 = v178 + 1
                                            struct (v303, v304, 1, v180)
                                        else
                                            let v305 : int32 = v179 + 1
                                            struct (v177, v178, v305, v180)
                                    US18_Ok('`', v301, v306, v307, v308, v309)
                                else
                                    let v311 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure53()
                                    US18_Error(v311, v176, v177, v178, v179, v180)
                        let v349 : US18 =
                            match v314 with
                            | US18_Error(v341, v342, v343, v344, v345, v346) -> (* Error *)
                                US18_Error(v341, v342, v343, v344, v345, v346)
                            | US18_Ok(v315, v316, v317, v318, v319, v320) -> (* Ok *)
                                let v321 : bool = v316 >= v320
                                if v321 then
                                    let v322 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure55()
                                    US18_Error(v322, v316, v317, v318, v319, v320)
                                else
                                    let v324 : char = (spiralStringIndex v0 (int v316))
                                    let v325 : bool = v324 = '"'
                                    let v326 : bool = v325 = false
                                    if v326 then
                                        let v327 : int32 = v316 + 1
                                        let v328 : bool = '\n' = v324
                                        let struct (v332 : int32, v333 : int32, v334 : int32, v335 : int32) =
                                            if v328 then
                                                let v329 : int32 = v317 + v319
                                                let v330 : int32 = v318 + 1
                                                struct (v329, v330, 1, v320)
                                            else
                                                let v331 : int32 = v319 + 1
                                                struct (v317, v318, v331, v320)
                                        US18_Ok(v324, v327, v332, v333, v334, v335)
                                    else
                                        let v337 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                                        US18_Error(v337, v316, v317, v318, v319, v320)
                        let v371 : US19 =
                            match v349 with
                            | US18_Error(v363, v364, v365, v366, v367, v368) -> (* Error *)
                                US19_Error(v363, v364, v365, v366, v367, v368)
                            | US18_Ok(v350, v351, v352, v353, v354, v355) -> (* Ok *)
                                let v356 : bool = v176 >= v351
                                let v361 : string =
                                    if v356 then
                                        let v357 : string = ""
                                        v357
                                    else
                                        let v358 : bool = v176 = v351
                                        let v359 : int32 = v351 - 1
                                        let v360 : string = (spiralStringSlice v0 (int v176) (int v359))
                                        v360
                                US19_Ok(v361, v351, v352, v353, v354, v355)
                        match v371 with
                        | US19_Error(v378, v379, v380, v381, v382, v383) -> (* Error *)
                            let v384 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure35()
                            US19_Error(v384, v176, v177, v178, v179, v180)
                        | US19_Ok(v372, v373, v374, v375, v376, v377) -> (* Ok *)
                            v371
                    | US19_Ok(v285, v286, v287, v288, v289, v290) -> (* Ok *)
                        v284
                | US19_Ok(v197, v198, v199, v200, v201, v202) -> (* Ok *)
                    v196
            let v413 : US19 =
                match v391 with
                | US19_Error(v392, v393, v394, v395, v396, v397) -> (* Error *)
                    let v398 : string = ""
                    US19_Ok(v398, v176, v177, v178, v179, v180)
                | US19_Ok(v400, v401, v402, v403, v404, v405) -> (* Ok *)
                    let v406 : bool = v401 = v176
                    if v406 then
                        let v407 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                        US19_Error(v407, v176, v177, v178, v179, v180)
                    else
                        let v409 : UH0 = UH0_Nil
                        method90(v0, v400, v409, v401, v402, v403, v404, v405)
            match v413 with
            | US19_Error(v604, v605, v606, v607, v608, v609) -> (* Error *)
                let v610 : bool = v176 >= v180
                let v628 : US18 =
                    if v610 then
                        let v611 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure50()
                        US18_Error(v611, v176, v177, v178, v179, v180)
                    else
                        let v613 : char = (spiralStringIndex v0 (int v176))
                        let v614 : bool = v613 = '\\'
                        if v614 then
                            let v615 : int32 = v176 + 1
                            let v616 : bool = '\n' = v613
                            let struct (v620 : int32, v621 : int32, v622 : int32, v623 : int32) =
                                if v616 then
                                    let v617 : int32 = v177 + v179
                                    let v618 : int32 = v178 + 1
                                    struct (v617, v618, 1, v180)
                                else
                                    let v619 : int32 = v179 + 1
                                    struct (v177, v178, v619, v180)
                            US18_Ok('\\', v615, v620, v621, v622, v623)
                        else
                            let v625 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure51()
                            US18_Error(v625, v176, v177, v178, v179, v180)
                let v662 : US18 =
                    match v628 with
                    | US18_Error(v654, v655, v656, v657, v658, v659) -> (* Error *)
                        US18_Error(v654, v655, v656, v657, v658, v659)
                    | US18_Ok(v629, v630, v631, v632, v633, v634) -> (* Ok *)
                        let v635 : bool = v630 >= v634
                        if v635 then
                            let v636 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                            US18_Error(v636, v630, v631, v632, v633, v634)
                        else
                            let v638 : char = (spiralStringIndex v0 (int v630))
                            let v639 : bool = v638 = '"'
                            if v639 then
                                let v640 : int32 = v630 + 1
                                let v641 : bool = '\n' = v638
                                let struct (v645 : int32, v646 : int32, v647 : int32, v648 : int32) =
                                    if v641 then
                                        let v642 : int32 = v631 + v633
                                        let v643 : int32 = v632 + 1
                                        struct (v642, v643, 1, v634)
                                    else
                                        let v644 : int32 = v633 + 1
                                        struct (v631, v632, v644, v634)
                                US18_Ok('"', v640, v645, v646, v647, v648)
                            else
                                let v650 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                                US18_Error(v650, v630, v631, v632, v633, v634)
                let v678 : US18 =
                    match v662 with
                    | US18_Error(v670, v671, v672, v673, v674, v675) -> (* Error *)
                        US18_Error(v670, v671, v672, v673, v674, v675)
                    | US18_Ok(v663, v664, v665, v666, v667, v668) -> (* Ok *)
                        US18_Ok('"', v664, v665, v666, v667, v668)
                let v776 : US18 =
                    match v678 with
                    | US18_Error(v685, v686, v687, v688, v689, v690) -> (* Error *)
                        let v708 : US18 =
                            if v610 then
                                let v691 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure52()
                                US18_Error(v691, v176, v177, v178, v179, v180)
                            else
                                let v693 : char = (spiralStringIndex v0 (int v176))
                                let v694 : bool = v693 = '`'
                                if v694 then
                                    let v695 : int32 = v176 + 1
                                    let v696 : bool = '\n' = v693
                                    let struct (v700 : int32, v701 : int32, v702 : int32, v703 : int32) =
                                        if v696 then
                                            let v697 : int32 = v177 + v179
                                            let v698 : int32 = v178 + 1
                                            struct (v697, v698, 1, v180)
                                        else
                                            let v699 : int32 = v179 + 1
                                            struct (v177, v178, v699, v180)
                                    US18_Ok('`', v695, v700, v701, v702, v703)
                                else
                                    let v705 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure53()
                                    US18_Error(v705, v176, v177, v178, v179, v180)
                        let v742 : US18 =
                            match v708 with
                            | US18_Error(v734, v735, v736, v737, v738, v739) -> (* Error *)
                                US18_Error(v734, v735, v736, v737, v738, v739)
                            | US18_Ok(v709, v710, v711, v712, v713, v714) -> (* Ok *)
                                let v715 : bool = v710 >= v714
                                if v715 then
                                    let v716 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                                    US18_Error(v716, v710, v711, v712, v713, v714)
                                else
                                    let v718 : char = (spiralStringIndex v0 (int v710))
                                    let v719 : bool = v718 = '"'
                                    if v719 then
                                        let v720 : int32 = v710 + 1
                                        let v721 : bool = '\n' = v718
                                        let struct (v725 : int32, v726 : int32, v727 : int32, v728 : int32) =
                                            if v721 then
                                                let v722 : int32 = v711 + v713
                                                let v723 : int32 = v712 + 1
                                                struct (v722, v723, 1, v714)
                                            else
                                                let v724 : int32 = v713 + 1
                                                struct (v711, v712, v724, v714)
                                        US18_Ok('"', v720, v725, v726, v727, v728)
                                    else
                                        let v730 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                                        US18_Error(v730, v710, v711, v712, v713, v714)
                        let v758 : US18 =
                            match v742 with
                            | US18_Error(v750, v751, v752, v753, v754, v755) -> (* Error *)
                                US18_Error(v750, v751, v752, v753, v754, v755)
                            | US18_Ok(v743, v744, v745, v746, v747, v748) -> (* Ok *)
                                US18_Ok('"', v744, v745, v746, v747, v748)
                        match v758 with
                        | US18_Error(v765, v766, v767, v768, v769, v770) -> (* Error *)
                            let v771 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure35()
                            US18_Error(v771, v176, v177, v178, v179, v180)
                        | US18_Ok(v759, v760, v761, v762, v763, v764) -> (* Ok *)
                            v758
                    | US18_Ok(v679, v680, v681, v682, v683, v684) -> (* Ok *)
                        v678
                match v776 with
                | US18_Error(v785, v786, v787, v788, v789, v790) -> (* Error *)
                    let v791 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure39()
                    US19_Error(v791, v176, v177, v178, v179, v180)
                | US18_Ok(v777, v778, v779, v780, v781, v782) -> (* Ok *)
                    let v783 : string = ""
                    US19_Ok(v783, v778, v779, v780, v781, v782)
            | US19_Ok(v414, v415, v416, v417, v418, v419) -> (* Ok *)
                let v420 : bool = v415 >= v419
                let v438 : US18 =
                    if v420 then
                        let v421 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure50()
                        US18_Error(v421, v415, v416, v417, v418, v419)
                    else
                        let v423 : char = (spiralStringIndex v0 (int v415))
                        let v424 : bool = v423 = '\\'
                        if v424 then
                            let v425 : int32 = v415 + 1
                            let v426 : bool = '\n' = v423
                            let struct (v430 : int32, v431 : int32, v432 : int32, v433 : int32) =
                                if v426 then
                                    let v427 : int32 = v416 + v418
                                    let v428 : int32 = v417 + 1
                                    struct (v427, v428, 1, v419)
                                else
                                    let v429 : int32 = v418 + 1
                                    struct (v416, v417, v429, v419)
                            US18_Ok('\\', v425, v430, v431, v432, v433)
                        else
                            let v435 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure51()
                            US18_Error(v435, v415, v416, v417, v418, v419)
                let v472 : US18 =
                    match v438 with
                    | US18_Error(v464, v465, v466, v467, v468, v469) -> (* Error *)
                        US18_Error(v464, v465, v466, v467, v468, v469)
                    | US18_Ok(v439, v440, v441, v442, v443, v444) -> (* Ok *)
                        let v445 : bool = v440 >= v444
                        if v445 then
                            let v446 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                            US18_Error(v446, v440, v441, v442, v443, v444)
                        else
                            let v448 : char = (spiralStringIndex v0 (int v440))
                            let v449 : bool = v448 = '"'
                            if v449 then
                                let v450 : int32 = v440 + 1
                                let v451 : bool = '\n' = v448
                                let struct (v455 : int32, v456 : int32, v457 : int32, v458 : int32) =
                                    if v451 then
                                        let v452 : int32 = v441 + v443
                                        let v453 : int32 = v442 + 1
                                        struct (v452, v453, 1, v444)
                                    else
                                        let v454 : int32 = v443 + 1
                                        struct (v441, v442, v454, v444)
                                US18_Ok('"', v450, v455, v456, v457, v458)
                            else
                                let v460 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                                US18_Error(v460, v440, v441, v442, v443, v444)
                let v488 : US18 =
                    match v472 with
                    | US18_Error(v480, v481, v482, v483, v484, v485) -> (* Error *)
                        US18_Error(v480, v481, v482, v483, v484, v485)
                    | US18_Ok(v473, v474, v475, v476, v477, v478) -> (* Ok *)
                        US18_Ok('"', v474, v475, v476, v477, v478)
                let v586 : US18 =
                    match v488 with
                    | US18_Error(v495, v496, v497, v498, v499, v500) -> (* Error *)
                        let v518 : US18 =
                            if v420 then
                                let v501 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure52()
                                US18_Error(v501, v415, v416, v417, v418, v419)
                            else
                                let v503 : char = (spiralStringIndex v0 (int v415))
                                let v504 : bool = v503 = '`'
                                if v504 then
                                    let v505 : int32 = v415 + 1
                                    let v506 : bool = '\n' = v503
                                    let struct (v510 : int32, v511 : int32, v512 : int32, v513 : int32) =
                                        if v506 then
                                            let v507 : int32 = v416 + v418
                                            let v508 : int32 = v417 + 1
                                            struct (v507, v508, 1, v419)
                                        else
                                            let v509 : int32 = v418 + 1
                                            struct (v416, v417, v509, v419)
                                    US18_Ok('`', v505, v510, v511, v512, v513)
                                else
                                    let v515 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure53()
                                    US18_Error(v515, v415, v416, v417, v418, v419)
                        let v552 : US18 =
                            match v518 with
                            | US18_Error(v544, v545, v546, v547, v548, v549) -> (* Error *)
                                US18_Error(v544, v545, v546, v547, v548, v549)
                            | US18_Ok(v519, v520, v521, v522, v523, v524) -> (* Ok *)
                                let v525 : bool = v520 >= v524
                                if v525 then
                                    let v526 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                                    US18_Error(v526, v520, v521, v522, v523, v524)
                                else
                                    let v528 : char = (spiralStringIndex v0 (int v520))
                                    let v529 : bool = v528 = '"'
                                    if v529 then
                                        let v530 : int32 = v520 + 1
                                        let v531 : bool = '\n' = v528
                                        let struct (v535 : int32, v536 : int32, v537 : int32, v538 : int32) =
                                            if v531 then
                                                let v532 : int32 = v521 + v523
                                                let v533 : int32 = v522 + 1
                                                struct (v532, v533, 1, v524)
                                            else
                                                let v534 : int32 = v523 + 1
                                                struct (v521, v522, v534, v524)
                                        US18_Ok('"', v530, v535, v536, v537, v538)
                                    else
                                        let v540 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                                        US18_Error(v540, v520, v521, v522, v523, v524)
                        let v568 : US18 =
                            match v552 with
                            | US18_Error(v560, v561, v562, v563, v564, v565) -> (* Error *)
                                US18_Error(v560, v561, v562, v563, v564, v565)
                            | US18_Ok(v553, v554, v555, v556, v557, v558) -> (* Ok *)
                                US18_Ok('"', v554, v555, v556, v557, v558)
                        match v568 with
                        | US18_Error(v575, v576, v577, v578, v579, v580) -> (* Error *)
                            let v581 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure35()
                            US18_Error(v581, v415, v416, v417, v418, v419)
                        | US18_Ok(v569, v570, v571, v572, v573, v574) -> (* Ok *)
                            v568
                    | US18_Ok(v489, v490, v491, v492, v493, v494) -> (* Ok *)
                        v488
                match v586 with
                | US18_Error(v594, v595, v596, v597, v598, v599) -> (* Error *)
                    let v600 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure40(v176, v415, v594, v595, v596, v597, v598, v599)
                    US19_Error(v600, v415, v416, v417, v418, v419)
                | US18_Ok(v587, v588, v589, v590, v591, v592) -> (* Ok *)
                    US19_Ok(v414, v588, v589, v590, v591, v592)
    let v1162 : US19 =
        match v805 with
        | US19_Error(v812, v813, v814, v815, v816, v817) -> (* Error *)
            let v835 : US18 =
                if v8 then
                    let v818 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                    US18_Error(v818, v3, v4, v5, v6, v7)
                else
                    let v820 : char = (spiralStringIndex v0 (int v3))
                    let v821 : bool = v820 = '"'
                    if v821 then
                        let v822 : int32 = v3 + 1
                        let v823 : bool = '\n' = v820
                        let struct (v827 : int32, v828 : int32, v829 : int32, v830 : int32) =
                            if v823 then
                                let v824 : int32 = v4 + v6
                                let v825 : int32 = v5 + 1
                                struct (v824, v825, 1, v7)
                            else
                                let v826 : int32 = v6 + 1
                                struct (v4, v5, v826, v7)
                        US18_Ok('"', v822, v827, v828, v829, v830)
                    else
                        let v832 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                        US18_Error(v832, v3, v4, v5, v6, v7)
            match v835 with
            | US18_Error(v1152, v1153, v1154, v1155, v1156, v1157) -> (* Error *)
                US19_Error(v1152, v1153, v1154, v1155, v1156, v1157)
            | US18_Ok(v836, v837, v838, v839, v840, v841) -> (* Ok *)
                let struct (v842 : int32, v843 : int32, v844 : int32, v845 : int32, v846 : int32) = method88(v838, v839, v840, v841, v0, v837)
                let v847 : bool = v842 > v837
                let v857 : US19 =
                    if v847 then
                        let v848 : bool = v837 >= v842
                        let v853 : string =
                            if v848 then
                                let v849 : string = ""
                                v849
                            else
                                let v850 : bool = v837 = v842
                                let v851 : int32 = v842 - 1
                                let v852 : string = (spiralStringSlice v0 (int v837) (int v851))
                                v852
                        US19_Ok(v853, v842, v843, v844, v845, v846)
                    else
                        let v855 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure54()
                        US19_Error(v855, v837, v838, v839, v840, v841)
                let v1042 : US19 =
                    match v857 with
                    | US19_Error(v864, v865, v866, v867, v868, v869) -> (* Error *)
                        let v870 : bool = v837 >= v841
                        let v888 : US18 =
                            if v870 then
                                let v871 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure50()
                                US18_Error(v871, v837, v838, v839, v840, v841)
                            else
                                let v873 : char = (spiralStringIndex v0 (int v837))
                                let v874 : bool = v873 = '\\'
                                if v874 then
                                    let v875 : int32 = v837 + 1
                                    let v876 : bool = '\n' = v873
                                    let struct (v880 : int32, v881 : int32, v882 : int32, v883 : int32) =
                                        if v876 then
                                            let v877 : int32 = v838 + v840
                                            let v878 : int32 = v839 + 1
                                            struct (v877, v878, 1, v841)
                                        else
                                            let v879 : int32 = v840 + 1
                                            struct (v838, v839, v879, v841)
                                    US18_Ok('\\', v875, v880, v881, v882, v883)
                                else
                                    let v885 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure51()
                                    US18_Error(v885, v837, v838, v839, v840, v841)
                        let v918 : US18 =
                            match v888 with
                            | US18_Error(v910, v911, v912, v913, v914, v915) -> (* Error *)
                                US18_Error(v910, v911, v912, v913, v914, v915)
                            | US18_Ok(v889, v890, v891, v892, v893, v894) -> (* Ok *)
                                let v895 : bool = v890 >= v894
                                if v895 then
                                    let v896 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                                    US18_Error(v896, v890, v891, v892, v893, v894)
                                else
                                    let v898 : char = (spiralStringIndex v0 (int v890))
                                    let v899 : int32 = v890 + 1
                                    let v900 : bool = '\n' = v898
                                    let struct (v904 : int32, v905 : int32, v906 : int32, v907 : int32) =
                                        if v900 then
                                            let v901 : int32 = v891 + v893
                                            let v902 : int32 = v892 + 1
                                            struct (v901, v902, 1, v894)
                                        else
                                            let v903 : int32 = v893 + 1
                                            struct (v891, v892, v903, v894)
                                    US18_Ok(v898, v899, v904, v905, v906, v907)
                        let v940 : US19 =
                            match v918 with
                            | US18_Error(v932, v933, v934, v935, v936, v937) -> (* Error *)
                                US19_Error(v932, v933, v934, v935, v936, v937)
                            | US18_Ok(v919, v920, v921, v922, v923, v924) -> (* Ok *)
                                let v925 : bool = v837 >= v920
                                let v930 : string =
                                    if v925 then
                                        let v926 : string = ""
                                        v926
                                    else
                                        let v927 : bool = v837 = v920
                                        let v928 : int32 = v920 - 1
                                        let v929 : string = (spiralStringSlice v0 (int v837) (int v928))
                                        v929
                                US19_Ok(v930, v920, v921, v922, v923, v924)
                        match v940 with
                        | US19_Error(v947, v948, v949, v950, v951, v952) -> (* Error *)
                            let v970 : US18 =
                                if v870 then
                                    let v953 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure52()
                                    US18_Error(v953, v837, v838, v839, v840, v841)
                                else
                                    let v955 : char = (spiralStringIndex v0 (int v837))
                                    let v956 : bool = v955 = '`'
                                    if v956 then
                                        let v957 : int32 = v837 + 1
                                        let v958 : bool = '\n' = v955
                                        let struct (v962 : int32, v963 : int32, v964 : int32, v965 : int32) =
                                            if v958 then
                                                let v959 : int32 = v838 + v840
                                                let v960 : int32 = v839 + 1
                                                struct (v959, v960, 1, v841)
                                            else
                                                let v961 : int32 = v840 + 1
                                                struct (v838, v839, v961, v841)
                                        US18_Ok('`', v957, v962, v963, v964, v965)
                                    else
                                        let v967 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure53()
                                        US18_Error(v967, v837, v838, v839, v840, v841)
                            let v1000 : US18 =
                                match v970 with
                                | US18_Error(v992, v993, v994, v995, v996, v997) -> (* Error *)
                                    US18_Error(v992, v993, v994, v995, v996, v997)
                                | US18_Ok(v971, v972, v973, v974, v975, v976) -> (* Ok *)
                                    let v977 : bool = v972 >= v976
                                    if v977 then
                                        let v978 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                                        US18_Error(v978, v972, v973, v974, v975, v976)
                                    else
                                        let v980 : char = (spiralStringIndex v0 (int v972))
                                        let v981 : int32 = v972 + 1
                                        let v982 : bool = '\n' = v980
                                        let struct (v986 : int32, v987 : int32, v988 : int32, v989 : int32) =
                                            if v982 then
                                                let v983 : int32 = v973 + v975
                                                let v984 : int32 = v974 + 1
                                                struct (v983, v984, 1, v976)
                                            else
                                                let v985 : int32 = v975 + 1
                                                struct (v973, v974, v985, v976)
                                        US18_Ok(v980, v981, v986, v987, v988, v989)
                            let v1022 : US19 =
                                match v1000 with
                                | US18_Error(v1014, v1015, v1016, v1017, v1018, v1019) -> (* Error *)
                                    US19_Error(v1014, v1015, v1016, v1017, v1018, v1019)
                                | US18_Ok(v1001, v1002, v1003, v1004, v1005, v1006) -> (* Ok *)
                                    let v1007 : bool = v837 >= v1002
                                    let v1012 : string =
                                        if v1007 then
                                            let v1008 : string = ""
                                            v1008
                                        else
                                            let v1009 : bool = v837 = v1002
                                            let v1010 : int32 = v1002 - 1
                                            let v1011 : string = (spiralStringSlice v0 (int v837) (int v1010))
                                            v1011
                                    US19_Ok(v1012, v1002, v1003, v1004, v1005, v1006)
                            match v1022 with
                            | US19_Error(v1029, v1030, v1031, v1032, v1033, v1034) -> (* Error *)
                                let v1035 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure35()
                                US19_Error(v1035, v837, v838, v839, v840, v841)
                            | US19_Ok(v1023, v1024, v1025, v1026, v1027, v1028) -> (* Ok *)
                                v1022
                        | US19_Ok(v941, v942, v943, v944, v945, v946) -> (* Ok *)
                            v940
                    | US19_Ok(v858, v859, v860, v861, v862, v863) -> (* Ok *)
                        v857
                let v1064 : US19 =
                    match v1042 with
                    | US19_Error(v1043, v1044, v1045, v1046, v1047, v1048) -> (* Error *)
                        let v1049 : string = ""
                        US19_Ok(v1049, v837, v838, v839, v840, v841)
                    | US19_Ok(v1051, v1052, v1053, v1054, v1055, v1056) -> (* Ok *)
                        let v1057 : bool = v1052 = v837
                        if v1057 then
                            let v1058 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                            US19_Error(v1058, v837, v838, v839, v840, v841)
                        else
                            let v1060 : UH0 = UH0_Nil
                            method93(v0, v1051, v1060, v1052, v1053, v1054, v1055, v1056)
                match v1064 with
                | US19_Error(v1107, v1108, v1109, v1110, v1111, v1112) -> (* Error *)
                    let v1113 : bool = v837 >= v841
                    let v1131 : US18 =
                        if v1113 then
                            let v1114 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                            US18_Error(v1114, v837, v838, v839, v840, v841)
                        else
                            let v1116 : char = (spiralStringIndex v0 (int v837))
                            let v1117 : bool = v1116 = '"'
                            if v1117 then
                                let v1118 : int32 = v837 + 1
                                let v1119 : bool = '\n' = v1116
                                let struct (v1123 : int32, v1124 : int32, v1125 : int32, v1126 : int32) =
                                    if v1119 then
                                        let v1120 : int32 = v838 + v840
                                        let v1121 : int32 = v839 + 1
                                        struct (v1120, v1121, 1, v841)
                                    else
                                        let v1122 : int32 = v840 + 1
                                        struct (v838, v839, v1122, v841)
                                US18_Ok('"', v1118, v1123, v1124, v1125, v1126)
                            else
                                let v1128 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                                US18_Error(v1128, v837, v838, v839, v840, v841)
                    match v1131 with
                    | US18_Error(v1140, v1141, v1142, v1143, v1144, v1145) -> (* Error *)
                        let v1146 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure39()
                        US19_Error(v1146, v837, v838, v839, v840, v841)
                    | US18_Ok(v1132, v1133, v1134, v1135, v1136, v1137) -> (* Ok *)
                        let v1138 : string = ""
                        US19_Ok(v1138, v1133, v1134, v1135, v1136, v1137)
                | US19_Ok(v1065, v1066, v1067, v1068, v1069, v1070) -> (* Ok *)
                    let v1071 : bool = v1066 >= v1070
                    let v1089 : US18 =
                        if v1071 then
                            let v1072 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                            US18_Error(v1072, v1066, v1067, v1068, v1069, v1070)
                        else
                            let v1074 : char = (spiralStringIndex v0 (int v1066))
                            let v1075 : bool = v1074 = '"'
                            if v1075 then
                                let v1076 : int32 = v1066 + 1
                                let v1077 : bool = '\n' = v1074
                                let struct (v1081 : int32, v1082 : int32, v1083 : int32, v1084 : int32) =
                                    if v1077 then
                                        let v1078 : int32 = v1067 + v1069
                                        let v1079 : int32 = v1068 + 1
                                        struct (v1078, v1079, 1, v1070)
                                    else
                                        let v1080 : int32 = v1069 + 1
                                        struct (v1067, v1068, v1080, v1070)
                                US18_Ok('"', v1076, v1081, v1082, v1083, v1084)
                            else
                                let v1086 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                                US18_Error(v1086, v1066, v1067, v1068, v1069, v1070)
                    match v1089 with
                    | US18_Error(v1097, v1098, v1099, v1100, v1101, v1102) -> (* Error *)
                        let v1103 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure40(v837, v1066, v1097, v1098, v1099, v1100, v1101, v1102)
                        US19_Error(v1103, v1066, v1067, v1068, v1069, v1070)
                    | US18_Ok(v1090, v1091, v1092, v1093, v1094, v1095) -> (* Ok *)
                        US19_Ok(v1065, v1091, v1092, v1093, v1094, v1095)
        | US19_Ok(v806, v807, v808, v809, v810, v811) -> (* Ok *)
            v805
    let v1192 : US19 =
        match v1162 with
        | US19_Error(v1169, v1170, v1171, v1172, v1173, v1174) -> (* Error *)
            let struct (v1175 : int32, v1176 : int32, v1177 : int32, v1178 : int32, v1179 : int32) = method100(v4, v5, v6, v7, v0, v3)
            let v1180 : bool = v1175 > v3
            if v1180 then
                let v1181 : bool = v3 >= v1175
                let v1186 : string =
                    if v1181 then
                        let v1182 : string = ""
                        v1182
                    else
                        let v1183 : bool = v3 = v1175
                        let v1184 : int32 = v1175 - 1
                        let v1185 : string = (spiralStringSlice v0 (int v3) (int v1184))
                        v1185
                US19_Ok(v1186, v1175, v1176, v1177, v1178, v1179)
            else
                let v1188 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure54()
                US19_Error(v1188, v3, v4, v5, v6, v7)
        | US19_Ok(v1163, v1164, v1165, v1166, v1167, v1168) -> (* Ok *)
            v1162
    let v1227 : US19 =
        match v1192 with
        | US19_Error(v1199, v1200, v1201, v1202, v1203, v1204) -> (* Error *)
            let v1205 : UH0 = UH0_Nil
            let v1206 : US27 = method96(v0, v1205, v3, v4, v5, v6, v7)
            match v1206 with
            | US27_Error(v1217, v1218, v1219, v1220, v1221, v1222) -> (* Error *)
                US19_Error(v1217, v1218, v1219, v1220, v1221, v1222)
            | US27_Ok(v1207, v1208, v1209, v1210, v1211, v1212) -> (* Ok *)
                let v1213 : string = ""
                let struct (v1214 : string, v1215 : string) = method98(v1207, v1213)
                US19_Ok(v1214, v1208, v1209, v1210, v1211, v1212)
        | US19_Ok(v1193, v1194, v1195, v1196, v1197, v1198) -> (* Ok *)
            v1192
    let v1238 : US19 =
        match v1227 with
        | US19_Ok(v1228, v1229, v1230, v1231, v1232, v1233) -> (* Ok *)
            let v1234 : bool = v1229 = v3
            if v1234 then
                let v1235 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure63()
                US19_Error(v1235, v3, v4, v5, v6, v7)
            else
                v1227
        | _ ->
            v1227
    match v1238 with
    | US19_Error(v1239, v1240, v1241, v1242, v1243, v1244) -> (* Error *)
        let v1248 : string =
            match v2 with
            | UH0_Nil -> (* Nil *)
                v1
            | _ ->
                let v1245 : bool = true
                let v1246 : string = method91(v1245, v2)
                let v1247 : string = v1 + v1246 
                v1247
        US19_Ok(v1248, v3, v4, v5, v6, v7)
    | US19_Ok(v1250, v1251, v1252, v1253, v1254, v1255) -> (* Ok *)
        let v1256 : bool = v1251 > v3
        if v1256 then
            let v1257 : UH0 = UH0_Cons(v1250, v2)
            method99(v0, v1, v1257, v1251, v1252, v1253, v1254, v1255)
        else
            let v1259 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure64()
            US19_Error(v1259, v3, v4, v5, v6, v7)
and closure65 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = "parsing.sep_by / separator consumed no text"
    v6
and method102 (v0 : string, v1 : UH0, v2 : int32, v3 : int32, v4 : int32, v5 : int32, v6 : int32) : US27 =
    let v7 : bool = v2 >= v6
    let struct (v20 : int32, v21 : int32, v22 : int32, v23 : int32, v24 : int32) =
        if v7 then
            struct (v2, v3, v4, v5, v6)
        else
            let v8 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v0))
            let v9 : int32 = method86(v0, v8, v2)
            let v10 : bool = v9 > v6
            let v11 : int32 =
                if v10 then
                    v6
                else
                    v9
            let v12 : int32 = v11 - v2
            let v13 : bool = v12 = 0
            if v13 then
                struct (v2, v3, v4, v5, v6)
            else
                let v14 : int32 = v5 + v12
                struct (v11, v3, v4, v14, v6)
    let v25 : bool = v20 = v2
    let v26 : bool = v25 <> true
    let v30 : US20 =
        if v26 then
            US20_Ok(v20, v21, v22, v23, v24)
        else
            let v28 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure45()
            US20_Error(v28, v2, v3, v4, v5, v6)
    match v30 with
    | US20_Error(v31, v32, v33, v34, v35, v36) -> (* Error *)
        let v37 : UH0 = UH0_Nil
        let v38 : UH0 = method97(v1, v37)
        US27_Ok(v38, v2, v3, v4, v5, v6)
    | US20_Ok(v40, v41, v42, v43, v44) -> (* Ok *)
        let v45 : bool = v40 = v2
        if v45 then
            let v46 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure65()
            US27_Error(v46, v2, v3, v4, v5, v6)
        else
            let v48 : bool = v40 >= v44
            let v66 : US18 =
                if v48 then
                    let v49 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure50()
                    US18_Error(v49, v40, v41, v42, v43, v44)
                else
                    let v51 : char = (spiralStringIndex v0 (int v40))
                    let v52 : bool = v51 = '\\'
                    if v52 then
                        let v53 : int32 = v40 + 1
                        let v54 : bool = '\n' = v51
                        let struct (v58 : int32, v59 : int32, v60 : int32, v61 : int32) =
                            if v54 then
                                let v55 : int32 = v41 + v43
                                let v56 : int32 = v42 + 1
                                struct (v55, v56, 1, v44)
                            else
                                let v57 : int32 = v43 + 1
                                struct (v41, v42, v57, v44)
                        US18_Ok('\\', v53, v58, v59, v60, v61)
                    else
                        let v63 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure51()
                        US18_Error(v63, v40, v41, v42, v43, v44)
            let v100 : US18 =
                match v66 with
                | US18_Error(v92, v93, v94, v95, v96, v97) -> (* Error *)
                    US18_Error(v92, v93, v94, v95, v96, v97)
                | US18_Ok(v67, v68, v69, v70, v71, v72) -> (* Ok *)
                    let v73 : bool = v68 >= v72
                    if v73 then
                        let v74 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                        US18_Error(v74, v68, v69, v70, v71, v72)
                    else
                        let v76 : char = (spiralStringIndex v0 (int v68))
                        let v77 : bool = v76 = '"'
                        if v77 then
                            let v78 : int32 = v68 + 1
                            let v79 : bool = '\n' = v76
                            let struct (v83 : int32, v84 : int32, v85 : int32, v86 : int32) =
                                if v79 then
                                    let v80 : int32 = v69 + v71
                                    let v81 : int32 = v70 + 1
                                    struct (v80, v81, 1, v72)
                                else
                                    let v82 : int32 = v71 + 1
                                    struct (v69, v70, v82, v72)
                            US18_Ok('"', v78, v83, v84, v85, v86)
                        else
                            let v88 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                            US18_Error(v88, v68, v69, v70, v71, v72)
            let v116 : US18 =
                match v100 with
                | US18_Error(v108, v109, v110, v111, v112, v113) -> (* Error *)
                    US18_Error(v108, v109, v110, v111, v112, v113)
                | US18_Ok(v101, v102, v103, v104, v105, v106) -> (* Ok *)
                    US18_Ok('"', v102, v103, v104, v105, v106)
            let v214 : US18 =
                match v116 with
                | US18_Error(v123, v124, v125, v126, v127, v128) -> (* Error *)
                    let v146 : US18 =
                        if v48 then
                            let v129 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure52()
                            US18_Error(v129, v40, v41, v42, v43, v44)
                        else
                            let v131 : char = (spiralStringIndex v0 (int v40))
                            let v132 : bool = v131 = '`'
                            if v132 then
                                let v133 : int32 = v40 + 1
                                let v134 : bool = '\n' = v131
                                let struct (v138 : int32, v139 : int32, v140 : int32, v141 : int32) =
                                    if v134 then
                                        let v135 : int32 = v41 + v43
                                        let v136 : int32 = v42 + 1
                                        struct (v135, v136, 1, v44)
                                    else
                                        let v137 : int32 = v43 + 1
                                        struct (v41, v42, v137, v44)
                                US18_Ok('`', v133, v138, v139, v140, v141)
                            else
                                let v143 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure53()
                                US18_Error(v143, v40, v41, v42, v43, v44)
                    let v180 : US18 =
                        match v146 with
                        | US18_Error(v172, v173, v174, v175, v176, v177) -> (* Error *)
                            US18_Error(v172, v173, v174, v175, v176, v177)
                        | US18_Ok(v147, v148, v149, v150, v151, v152) -> (* Ok *)
                            let v153 : bool = v148 >= v152
                            if v153 then
                                let v154 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                                US18_Error(v154, v148, v149, v150, v151, v152)
                            else
                                let v156 : char = (spiralStringIndex v0 (int v148))
                                let v157 : bool = v156 = '"'
                                if v157 then
                                    let v158 : int32 = v148 + 1
                                    let v159 : bool = '\n' = v156
                                    let struct (v163 : int32, v164 : int32, v165 : int32, v166 : int32) =
                                        if v159 then
                                            let v160 : int32 = v149 + v151
                                            let v161 : int32 = v150 + 1
                                            struct (v160, v161, 1, v152)
                                        else
                                            let v162 : int32 = v151 + 1
                                            struct (v149, v150, v162, v152)
                                    US18_Ok('"', v158, v163, v164, v165, v166)
                                else
                                    let v168 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                                    US18_Error(v168, v148, v149, v150, v151, v152)
                    let v196 : US18 =
                        match v180 with
                        | US18_Error(v188, v189, v190, v191, v192, v193) -> (* Error *)
                            US18_Error(v188, v189, v190, v191, v192, v193)
                        | US18_Ok(v181, v182, v183, v184, v185, v186) -> (* Ok *)
                            US18_Ok('"', v182, v183, v184, v185, v186)
                    match v196 with
                    | US18_Error(v203, v204, v205, v206, v207, v208) -> (* Error *)
                        let v209 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure35()
                        US18_Error(v209, v40, v41, v42, v43, v44)
                    | US18_Ok(v197, v198, v199, v200, v201, v202) -> (* Ok *)
                        v196
                | US18_Ok(v117, v118, v119, v120, v121, v122) -> (* Ok *)
                    v116
            let v845 : US19 =
                match v214 with
                | US18_Error(v837, v838, v839, v840, v841, v842) -> (* Error *)
                    US19_Error(v837, v838, v839, v840, v841, v842)
                | US18_Ok(v215, v216, v217, v218, v219, v220) -> (* Ok *)
                    let struct (v221 : int32, v222 : int32, v223 : int32, v224 : int32, v225 : int32) = method88(v217, v218, v219, v220, v0, v216)
                    let v226 : bool = v221 > v216
                    let v236 : US19 =
                        if v226 then
                            let v227 : bool = v216 >= v221
                            let v232 : string =
                                if v227 then
                                    let v228 : string = ""
                                    v228
                                else
                                    let v229 : bool = v216 = v221
                                    let v230 : int32 = v221 - 1
                                    let v231 : string = (spiralStringSlice v0 (int v216) (int v230))
                                    v231
                            US19_Ok(v232, v221, v222, v223, v224, v225)
                        else
                            let v234 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure54()
                            US19_Error(v234, v216, v217, v218, v219, v220)
                    let v431 : US19 =
                        match v236 with
                        | US19_Error(v243, v244, v245, v246, v247, v248) -> (* Error *)
                            let v249 : bool = v216 >= v220
                            let v267 : US18 =
                                if v249 then
                                    let v250 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure50()
                                    US18_Error(v250, v216, v217, v218, v219, v220)
                                else
                                    let v252 : char = (spiralStringIndex v0 (int v216))
                                    let v253 : bool = v252 = '\\'
                                    if v253 then
                                        let v254 : int32 = v216 + 1
                                        let v255 : bool = '\n' = v252
                                        let struct (v259 : int32, v260 : int32, v261 : int32, v262 : int32) =
                                            if v255 then
                                                let v256 : int32 = v217 + v219
                                                let v257 : int32 = v218 + 1
                                                struct (v256, v257, 1, v220)
                                            else
                                                let v258 : int32 = v219 + 1
                                                struct (v217, v218, v258, v220)
                                        US18_Ok('\\', v254, v259, v260, v261, v262)
                                    else
                                        let v264 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure51()
                                        US18_Error(v264, v216, v217, v218, v219, v220)
                            let v302 : US18 =
                                match v267 with
                                | US18_Error(v294, v295, v296, v297, v298, v299) -> (* Error *)
                                    US18_Error(v294, v295, v296, v297, v298, v299)
                                | US18_Ok(v268, v269, v270, v271, v272, v273) -> (* Ok *)
                                    let v274 : bool = v269 >= v273
                                    if v274 then
                                        let v275 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure55()
                                        US18_Error(v275, v269, v270, v271, v272, v273)
                                    else
                                        let v277 : char = (spiralStringIndex v0 (int v269))
                                        let v278 : bool = v277 = '"'
                                        let v279 : bool = v278 = false
                                        if v279 then
                                            let v280 : int32 = v269 + 1
                                            let v281 : bool = '\n' = v277
                                            let struct (v285 : int32, v286 : int32, v287 : int32, v288 : int32) =
                                                if v281 then
                                                    let v282 : int32 = v270 + v272
                                                    let v283 : int32 = v271 + 1
                                                    struct (v282, v283, 1, v273)
                                                else
                                                    let v284 : int32 = v272 + 1
                                                    struct (v270, v271, v284, v273)
                                            US18_Ok(v277, v280, v285, v286, v287, v288)
                                        else
                                            let v290 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                                            US18_Error(v290, v269, v270, v271, v272, v273)
                            let v324 : US19 =
                                match v302 with
                                | US18_Error(v316, v317, v318, v319, v320, v321) -> (* Error *)
                                    US19_Error(v316, v317, v318, v319, v320, v321)
                                | US18_Ok(v303, v304, v305, v306, v307, v308) -> (* Ok *)
                                    let v309 : bool = v216 >= v304
                                    let v314 : string =
                                        if v309 then
                                            let v310 : string = ""
                                            v310
                                        else
                                            let v311 : bool = v216 = v304
                                            let v312 : int32 = v304 - 1
                                            let v313 : string = (spiralStringSlice v0 (int v216) (int v312))
                                            v313
                                    US19_Ok(v314, v304, v305, v306, v307, v308)
                            match v324 with
                            | US19_Error(v331, v332, v333, v334, v335, v336) -> (* Error *)
                                let v354 : US18 =
                                    if v249 then
                                        let v337 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure52()
                                        US18_Error(v337, v216, v217, v218, v219, v220)
                                    else
                                        let v339 : char = (spiralStringIndex v0 (int v216))
                                        let v340 : bool = v339 = '`'
                                        if v340 then
                                            let v341 : int32 = v216 + 1
                                            let v342 : bool = '\n' = v339
                                            let struct (v346 : int32, v347 : int32, v348 : int32, v349 : int32) =
                                                if v342 then
                                                    let v343 : int32 = v217 + v219
                                                    let v344 : int32 = v218 + 1
                                                    struct (v343, v344, 1, v220)
                                                else
                                                    let v345 : int32 = v219 + 1
                                                    struct (v217, v218, v345, v220)
                                            US18_Ok('`', v341, v346, v347, v348, v349)
                                        else
                                            let v351 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure53()
                                            US18_Error(v351, v216, v217, v218, v219, v220)
                                let v389 : US18 =
                                    match v354 with
                                    | US18_Error(v381, v382, v383, v384, v385, v386) -> (* Error *)
                                        US18_Error(v381, v382, v383, v384, v385, v386)
                                    | US18_Ok(v355, v356, v357, v358, v359, v360) -> (* Ok *)
                                        let v361 : bool = v356 >= v360
                                        if v361 then
                                            let v362 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure55()
                                            US18_Error(v362, v356, v357, v358, v359, v360)
                                        else
                                            let v364 : char = (spiralStringIndex v0 (int v356))
                                            let v365 : bool = v364 = '"'
                                            let v366 : bool = v365 = false
                                            if v366 then
                                                let v367 : int32 = v356 + 1
                                                let v368 : bool = '\n' = v364
                                                let struct (v372 : int32, v373 : int32, v374 : int32, v375 : int32) =
                                                    if v368 then
                                                        let v369 : int32 = v357 + v359
                                                        let v370 : int32 = v358 + 1
                                                        struct (v369, v370, 1, v360)
                                                    else
                                                        let v371 : int32 = v359 + 1
                                                        struct (v357, v358, v371, v360)
                                                US18_Ok(v364, v367, v372, v373, v374, v375)
                                            else
                                                let v377 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                                                US18_Error(v377, v356, v357, v358, v359, v360)
                                let v411 : US19 =
                                    match v389 with
                                    | US18_Error(v403, v404, v405, v406, v407, v408) -> (* Error *)
                                        US19_Error(v403, v404, v405, v406, v407, v408)
                                    | US18_Ok(v390, v391, v392, v393, v394, v395) -> (* Ok *)
                                        let v396 : bool = v216 >= v391
                                        let v401 : string =
                                            if v396 then
                                                let v397 : string = ""
                                                v397
                                            else
                                                let v398 : bool = v216 = v391
                                                let v399 : int32 = v391 - 1
                                                let v400 : string = (spiralStringSlice v0 (int v216) (int v399))
                                                v400
                                        US19_Ok(v401, v391, v392, v393, v394, v395)
                                match v411 with
                                | US19_Error(v418, v419, v420, v421, v422, v423) -> (* Error *)
                                    let v424 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure35()
                                    US19_Error(v424, v216, v217, v218, v219, v220)
                                | US19_Ok(v412, v413, v414, v415, v416, v417) -> (* Ok *)
                                    v411
                            | US19_Ok(v325, v326, v327, v328, v329, v330) -> (* Ok *)
                                v324
                        | US19_Ok(v237, v238, v239, v240, v241, v242) -> (* Ok *)
                            v236
                    let v453 : US19 =
                        match v431 with
                        | US19_Error(v432, v433, v434, v435, v436, v437) -> (* Error *)
                            let v438 : string = ""
                            US19_Ok(v438, v216, v217, v218, v219, v220)
                        | US19_Ok(v440, v441, v442, v443, v444, v445) -> (* Ok *)
                            let v446 : bool = v441 = v216
                            if v446 then
                                let v447 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                                US19_Error(v447, v216, v217, v218, v219, v220)
                            else
                                let v449 : UH0 = UH0_Nil
                                method90(v0, v440, v449, v441, v442, v443, v444, v445)
                    match v453 with
                    | US19_Error(v644, v645, v646, v647, v648, v649) -> (* Error *)
                        let v650 : bool = v216 >= v220
                        let v668 : US18 =
                            if v650 then
                                let v651 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure50()
                                US18_Error(v651, v216, v217, v218, v219, v220)
                            else
                                let v653 : char = (spiralStringIndex v0 (int v216))
                                let v654 : bool = v653 = '\\'
                                if v654 then
                                    let v655 : int32 = v216 + 1
                                    let v656 : bool = '\n' = v653
                                    let struct (v660 : int32, v661 : int32, v662 : int32, v663 : int32) =
                                        if v656 then
                                            let v657 : int32 = v217 + v219
                                            let v658 : int32 = v218 + 1
                                            struct (v657, v658, 1, v220)
                                        else
                                            let v659 : int32 = v219 + 1
                                            struct (v217, v218, v659, v220)
                                    US18_Ok('\\', v655, v660, v661, v662, v663)
                                else
                                    let v665 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure51()
                                    US18_Error(v665, v216, v217, v218, v219, v220)
                        let v702 : US18 =
                            match v668 with
                            | US18_Error(v694, v695, v696, v697, v698, v699) -> (* Error *)
                                US18_Error(v694, v695, v696, v697, v698, v699)
                            | US18_Ok(v669, v670, v671, v672, v673, v674) -> (* Ok *)
                                let v675 : bool = v670 >= v674
                                if v675 then
                                    let v676 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                                    US18_Error(v676, v670, v671, v672, v673, v674)
                                else
                                    let v678 : char = (spiralStringIndex v0 (int v670))
                                    let v679 : bool = v678 = '"'
                                    if v679 then
                                        let v680 : int32 = v670 + 1
                                        let v681 : bool = '\n' = v678
                                        let struct (v685 : int32, v686 : int32, v687 : int32, v688 : int32) =
                                            if v681 then
                                                let v682 : int32 = v671 + v673
                                                let v683 : int32 = v672 + 1
                                                struct (v682, v683, 1, v674)
                                            else
                                                let v684 : int32 = v673 + 1
                                                struct (v671, v672, v684, v674)
                                        US18_Ok('"', v680, v685, v686, v687, v688)
                                    else
                                        let v690 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                                        US18_Error(v690, v670, v671, v672, v673, v674)
                        let v718 : US18 =
                            match v702 with
                            | US18_Error(v710, v711, v712, v713, v714, v715) -> (* Error *)
                                US18_Error(v710, v711, v712, v713, v714, v715)
                            | US18_Ok(v703, v704, v705, v706, v707, v708) -> (* Ok *)
                                US18_Ok('"', v704, v705, v706, v707, v708)
                        let v816 : US18 =
                            match v718 with
                            | US18_Error(v725, v726, v727, v728, v729, v730) -> (* Error *)
                                let v748 : US18 =
                                    if v650 then
                                        let v731 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure52()
                                        US18_Error(v731, v216, v217, v218, v219, v220)
                                    else
                                        let v733 : char = (spiralStringIndex v0 (int v216))
                                        let v734 : bool = v733 = '`'
                                        if v734 then
                                            let v735 : int32 = v216 + 1
                                            let v736 : bool = '\n' = v733
                                            let struct (v740 : int32, v741 : int32, v742 : int32, v743 : int32) =
                                                if v736 then
                                                    let v737 : int32 = v217 + v219
                                                    let v738 : int32 = v218 + 1
                                                    struct (v737, v738, 1, v220)
                                                else
                                                    let v739 : int32 = v219 + 1
                                                    struct (v217, v218, v739, v220)
                                            US18_Ok('`', v735, v740, v741, v742, v743)
                                        else
                                            let v745 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure53()
                                            US18_Error(v745, v216, v217, v218, v219, v220)
                                let v782 : US18 =
                                    match v748 with
                                    | US18_Error(v774, v775, v776, v777, v778, v779) -> (* Error *)
                                        US18_Error(v774, v775, v776, v777, v778, v779)
                                    | US18_Ok(v749, v750, v751, v752, v753, v754) -> (* Ok *)
                                        let v755 : bool = v750 >= v754
                                        if v755 then
                                            let v756 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                                            US18_Error(v756, v750, v751, v752, v753, v754)
                                        else
                                            let v758 : char = (spiralStringIndex v0 (int v750))
                                            let v759 : bool = v758 = '"'
                                            if v759 then
                                                let v760 : int32 = v750 + 1
                                                let v761 : bool = '\n' = v758
                                                let struct (v765 : int32, v766 : int32, v767 : int32, v768 : int32) =
                                                    if v761 then
                                                        let v762 : int32 = v751 + v753
                                                        let v763 : int32 = v752 + 1
                                                        struct (v762, v763, 1, v754)
                                                    else
                                                        let v764 : int32 = v753 + 1
                                                        struct (v751, v752, v764, v754)
                                                US18_Ok('"', v760, v765, v766, v767, v768)
                                            else
                                                let v770 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                                                US18_Error(v770, v750, v751, v752, v753, v754)
                                let v798 : US18 =
                                    match v782 with
                                    | US18_Error(v790, v791, v792, v793, v794, v795) -> (* Error *)
                                        US18_Error(v790, v791, v792, v793, v794, v795)
                                    | US18_Ok(v783, v784, v785, v786, v787, v788) -> (* Ok *)
                                        US18_Ok('"', v784, v785, v786, v787, v788)
                                match v798 with
                                | US18_Error(v805, v806, v807, v808, v809, v810) -> (* Error *)
                                    let v811 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure35()
                                    US18_Error(v811, v216, v217, v218, v219, v220)
                                | US18_Ok(v799, v800, v801, v802, v803, v804) -> (* Ok *)
                                    v798
                            | US18_Ok(v719, v720, v721, v722, v723, v724) -> (* Ok *)
                                v718
                        match v816 with
                        | US18_Error(v825, v826, v827, v828, v829, v830) -> (* Error *)
                            let v831 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure39()
                            US19_Error(v831, v216, v217, v218, v219, v220)
                        | US18_Ok(v817, v818, v819, v820, v821, v822) -> (* Ok *)
                            let v823 : string = ""
                            US19_Ok(v823, v818, v819, v820, v821, v822)
                    | US19_Ok(v454, v455, v456, v457, v458, v459) -> (* Ok *)
                        let v460 : bool = v455 >= v459
                        let v478 : US18 =
                            if v460 then
                                let v461 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure50()
                                US18_Error(v461, v455, v456, v457, v458, v459)
                            else
                                let v463 : char = (spiralStringIndex v0 (int v455))
                                let v464 : bool = v463 = '\\'
                                if v464 then
                                    let v465 : int32 = v455 + 1
                                    let v466 : bool = '\n' = v463
                                    let struct (v470 : int32, v471 : int32, v472 : int32, v473 : int32) =
                                        if v466 then
                                            let v467 : int32 = v456 + v458
                                            let v468 : int32 = v457 + 1
                                            struct (v467, v468, 1, v459)
                                        else
                                            let v469 : int32 = v458 + 1
                                            struct (v456, v457, v469, v459)
                                    US18_Ok('\\', v465, v470, v471, v472, v473)
                                else
                                    let v475 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure51()
                                    US18_Error(v475, v455, v456, v457, v458, v459)
                        let v512 : US18 =
                            match v478 with
                            | US18_Error(v504, v505, v506, v507, v508, v509) -> (* Error *)
                                US18_Error(v504, v505, v506, v507, v508, v509)
                            | US18_Ok(v479, v480, v481, v482, v483, v484) -> (* Ok *)
                                let v485 : bool = v480 >= v484
                                if v485 then
                                    let v486 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                                    US18_Error(v486, v480, v481, v482, v483, v484)
                                else
                                    let v488 : char = (spiralStringIndex v0 (int v480))
                                    let v489 : bool = v488 = '"'
                                    if v489 then
                                        let v490 : int32 = v480 + 1
                                        let v491 : bool = '\n' = v488
                                        let struct (v495 : int32, v496 : int32, v497 : int32, v498 : int32) =
                                            if v491 then
                                                let v492 : int32 = v481 + v483
                                                let v493 : int32 = v482 + 1
                                                struct (v492, v493, 1, v484)
                                            else
                                                let v494 : int32 = v483 + 1
                                                struct (v481, v482, v494, v484)
                                        US18_Ok('"', v490, v495, v496, v497, v498)
                                    else
                                        let v500 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                                        US18_Error(v500, v480, v481, v482, v483, v484)
                        let v528 : US18 =
                            match v512 with
                            | US18_Error(v520, v521, v522, v523, v524, v525) -> (* Error *)
                                US18_Error(v520, v521, v522, v523, v524, v525)
                            | US18_Ok(v513, v514, v515, v516, v517, v518) -> (* Ok *)
                                US18_Ok('"', v514, v515, v516, v517, v518)
                        let v626 : US18 =
                            match v528 with
                            | US18_Error(v535, v536, v537, v538, v539, v540) -> (* Error *)
                                let v558 : US18 =
                                    if v460 then
                                        let v541 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure52()
                                        US18_Error(v541, v455, v456, v457, v458, v459)
                                    else
                                        let v543 : char = (spiralStringIndex v0 (int v455))
                                        let v544 : bool = v543 = '`'
                                        if v544 then
                                            let v545 : int32 = v455 + 1
                                            let v546 : bool = '\n' = v543
                                            let struct (v550 : int32, v551 : int32, v552 : int32, v553 : int32) =
                                                if v546 then
                                                    let v547 : int32 = v456 + v458
                                                    let v548 : int32 = v457 + 1
                                                    struct (v547, v548, 1, v459)
                                                else
                                                    let v549 : int32 = v458 + 1
                                                    struct (v456, v457, v549, v459)
                                            US18_Ok('`', v545, v550, v551, v552, v553)
                                        else
                                            let v555 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure53()
                                            US18_Error(v555, v455, v456, v457, v458, v459)
                                let v592 : US18 =
                                    match v558 with
                                    | US18_Error(v584, v585, v586, v587, v588, v589) -> (* Error *)
                                        US18_Error(v584, v585, v586, v587, v588, v589)
                                    | US18_Ok(v559, v560, v561, v562, v563, v564) -> (* Ok *)
                                        let v565 : bool = v560 >= v564
                                        if v565 then
                                            let v566 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                                            US18_Error(v566, v560, v561, v562, v563, v564)
                                        else
                                            let v568 : char = (spiralStringIndex v0 (int v560))
                                            let v569 : bool = v568 = '"'
                                            if v569 then
                                                let v570 : int32 = v560 + 1
                                                let v571 : bool = '\n' = v568
                                                let struct (v575 : int32, v576 : int32, v577 : int32, v578 : int32) =
                                                    if v571 then
                                                        let v572 : int32 = v561 + v563
                                                        let v573 : int32 = v562 + 1
                                                        struct (v572, v573, 1, v564)
                                                    else
                                                        let v574 : int32 = v563 + 1
                                                        struct (v561, v562, v574, v564)
                                                US18_Ok('"', v570, v575, v576, v577, v578)
                                            else
                                                let v580 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                                                US18_Error(v580, v560, v561, v562, v563, v564)
                                let v608 : US18 =
                                    match v592 with
                                    | US18_Error(v600, v601, v602, v603, v604, v605) -> (* Error *)
                                        US18_Error(v600, v601, v602, v603, v604, v605)
                                    | US18_Ok(v593, v594, v595, v596, v597, v598) -> (* Ok *)
                                        US18_Ok('"', v594, v595, v596, v597, v598)
                                match v608 with
                                | US18_Error(v615, v616, v617, v618, v619, v620) -> (* Error *)
                                    let v621 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure35()
                                    US18_Error(v621, v455, v456, v457, v458, v459)
                                | US18_Ok(v609, v610, v611, v612, v613, v614) -> (* Ok *)
                                    v608
                            | US18_Ok(v529, v530, v531, v532, v533, v534) -> (* Ok *)
                                v528
                        match v626 with
                        | US18_Error(v634, v635, v636, v637, v638, v639) -> (* Error *)
                            let v640 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure40(v216, v455, v634, v635, v636, v637, v638, v639)
                            US19_Error(v640, v455, v456, v457, v458, v459)
                        | US18_Ok(v627, v628, v629, v630, v631, v632) -> (* Ok *)
                            US19_Ok(v454, v628, v629, v630, v631, v632)
            let v1202 : US19 =
                match v845 with
                | US19_Error(v852, v853, v854, v855, v856, v857) -> (* Error *)
                    let v875 : US18 =
                        if v48 then
                            let v858 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                            US18_Error(v858, v40, v41, v42, v43, v44)
                        else
                            let v860 : char = (spiralStringIndex v0 (int v40))
                            let v861 : bool = v860 = '"'
                            if v861 then
                                let v862 : int32 = v40 + 1
                                let v863 : bool = '\n' = v860
                                let struct (v867 : int32, v868 : int32, v869 : int32, v870 : int32) =
                                    if v863 then
                                        let v864 : int32 = v41 + v43
                                        let v865 : int32 = v42 + 1
                                        struct (v864, v865, 1, v44)
                                    else
                                        let v866 : int32 = v43 + 1
                                        struct (v41, v42, v866, v44)
                                US18_Ok('"', v862, v867, v868, v869, v870)
                            else
                                let v872 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                                US18_Error(v872, v40, v41, v42, v43, v44)
                    match v875 with
                    | US18_Error(v1192, v1193, v1194, v1195, v1196, v1197) -> (* Error *)
                        US19_Error(v1192, v1193, v1194, v1195, v1196, v1197)
                    | US18_Ok(v876, v877, v878, v879, v880, v881) -> (* Ok *)
                        let struct (v882 : int32, v883 : int32, v884 : int32, v885 : int32, v886 : int32) = method88(v878, v879, v880, v881, v0, v877)
                        let v887 : bool = v882 > v877
                        let v897 : US19 =
                            if v887 then
                                let v888 : bool = v877 >= v882
                                let v893 : string =
                                    if v888 then
                                        let v889 : string = ""
                                        v889
                                    else
                                        let v890 : bool = v877 = v882
                                        let v891 : int32 = v882 - 1
                                        let v892 : string = (spiralStringSlice v0 (int v877) (int v891))
                                        v892
                                US19_Ok(v893, v882, v883, v884, v885, v886)
                            else
                                let v895 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure54()
                                US19_Error(v895, v877, v878, v879, v880, v881)
                        let v1082 : US19 =
                            match v897 with
                            | US19_Error(v904, v905, v906, v907, v908, v909) -> (* Error *)
                                let v910 : bool = v877 >= v881
                                let v928 : US18 =
                                    if v910 then
                                        let v911 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure50()
                                        US18_Error(v911, v877, v878, v879, v880, v881)
                                    else
                                        let v913 : char = (spiralStringIndex v0 (int v877))
                                        let v914 : bool = v913 = '\\'
                                        if v914 then
                                            let v915 : int32 = v877 + 1
                                            let v916 : bool = '\n' = v913
                                            let struct (v920 : int32, v921 : int32, v922 : int32, v923 : int32) =
                                                if v916 then
                                                    let v917 : int32 = v878 + v880
                                                    let v918 : int32 = v879 + 1
                                                    struct (v917, v918, 1, v881)
                                                else
                                                    let v919 : int32 = v880 + 1
                                                    struct (v878, v879, v919, v881)
                                            US18_Ok('\\', v915, v920, v921, v922, v923)
                                        else
                                            let v925 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure51()
                                            US18_Error(v925, v877, v878, v879, v880, v881)
                                let v958 : US18 =
                                    match v928 with
                                    | US18_Error(v950, v951, v952, v953, v954, v955) -> (* Error *)
                                        US18_Error(v950, v951, v952, v953, v954, v955)
                                    | US18_Ok(v929, v930, v931, v932, v933, v934) -> (* Ok *)
                                        let v935 : bool = v930 >= v934
                                        if v935 then
                                            let v936 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                                            US18_Error(v936, v930, v931, v932, v933, v934)
                                        else
                                            let v938 : char = (spiralStringIndex v0 (int v930))
                                            let v939 : int32 = v930 + 1
                                            let v940 : bool = '\n' = v938
                                            let struct (v944 : int32, v945 : int32, v946 : int32, v947 : int32) =
                                                if v940 then
                                                    let v941 : int32 = v931 + v933
                                                    let v942 : int32 = v932 + 1
                                                    struct (v941, v942, 1, v934)
                                                else
                                                    let v943 : int32 = v933 + 1
                                                    struct (v931, v932, v943, v934)
                                            US18_Ok(v938, v939, v944, v945, v946, v947)
                                let v980 : US19 =
                                    match v958 with
                                    | US18_Error(v972, v973, v974, v975, v976, v977) -> (* Error *)
                                        US19_Error(v972, v973, v974, v975, v976, v977)
                                    | US18_Ok(v959, v960, v961, v962, v963, v964) -> (* Ok *)
                                        let v965 : bool = v877 >= v960
                                        let v970 : string =
                                            if v965 then
                                                let v966 : string = ""
                                                v966
                                            else
                                                let v967 : bool = v877 = v960
                                                let v968 : int32 = v960 - 1
                                                let v969 : string = (spiralStringSlice v0 (int v877) (int v968))
                                                v969
                                        US19_Ok(v970, v960, v961, v962, v963, v964)
                                match v980 with
                                | US19_Error(v987, v988, v989, v990, v991, v992) -> (* Error *)
                                    let v1010 : US18 =
                                        if v910 then
                                            let v993 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure52()
                                            US18_Error(v993, v877, v878, v879, v880, v881)
                                        else
                                            let v995 : char = (spiralStringIndex v0 (int v877))
                                            let v996 : bool = v995 = '`'
                                            if v996 then
                                                let v997 : int32 = v877 + 1
                                                let v998 : bool = '\n' = v995
                                                let struct (v1002 : int32, v1003 : int32, v1004 : int32, v1005 : int32) =
                                                    if v998 then
                                                        let v999 : int32 = v878 + v880
                                                        let v1000 : int32 = v879 + 1
                                                        struct (v999, v1000, 1, v881)
                                                    else
                                                        let v1001 : int32 = v880 + 1
                                                        struct (v878, v879, v1001, v881)
                                                US18_Ok('`', v997, v1002, v1003, v1004, v1005)
                                            else
                                                let v1007 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure53()
                                                US18_Error(v1007, v877, v878, v879, v880, v881)
                                    let v1040 : US18 =
                                        match v1010 with
                                        | US18_Error(v1032, v1033, v1034, v1035, v1036, v1037) -> (* Error *)
                                            US18_Error(v1032, v1033, v1034, v1035, v1036, v1037)
                                        | US18_Ok(v1011, v1012, v1013, v1014, v1015, v1016) -> (* Ok *)
                                            let v1017 : bool = v1012 >= v1016
                                            if v1017 then
                                                let v1018 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                                                US18_Error(v1018, v1012, v1013, v1014, v1015, v1016)
                                            else
                                                let v1020 : char = (spiralStringIndex v0 (int v1012))
                                                let v1021 : int32 = v1012 + 1
                                                let v1022 : bool = '\n' = v1020
                                                let struct (v1026 : int32, v1027 : int32, v1028 : int32, v1029 : int32) =
                                                    if v1022 then
                                                        let v1023 : int32 = v1013 + v1015
                                                        let v1024 : int32 = v1014 + 1
                                                        struct (v1023, v1024, 1, v1016)
                                                    else
                                                        let v1025 : int32 = v1015 + 1
                                                        struct (v1013, v1014, v1025, v1016)
                                                US18_Ok(v1020, v1021, v1026, v1027, v1028, v1029)
                                    let v1062 : US19 =
                                        match v1040 with
                                        | US18_Error(v1054, v1055, v1056, v1057, v1058, v1059) -> (* Error *)
                                            US19_Error(v1054, v1055, v1056, v1057, v1058, v1059)
                                        | US18_Ok(v1041, v1042, v1043, v1044, v1045, v1046) -> (* Ok *)
                                            let v1047 : bool = v877 >= v1042
                                            let v1052 : string =
                                                if v1047 then
                                                    let v1048 : string = ""
                                                    v1048
                                                else
                                                    let v1049 : bool = v877 = v1042
                                                    let v1050 : int32 = v1042 - 1
                                                    let v1051 : string = (spiralStringSlice v0 (int v877) (int v1050))
                                                    v1051
                                            US19_Ok(v1052, v1042, v1043, v1044, v1045, v1046)
                                    match v1062 with
                                    | US19_Error(v1069, v1070, v1071, v1072, v1073, v1074) -> (* Error *)
                                        let v1075 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure35()
                                        US19_Error(v1075, v877, v878, v879, v880, v881)
                                    | US19_Ok(v1063, v1064, v1065, v1066, v1067, v1068) -> (* Ok *)
                                        v1062
                                | US19_Ok(v981, v982, v983, v984, v985, v986) -> (* Ok *)
                                    v980
                            | US19_Ok(v898, v899, v900, v901, v902, v903) -> (* Ok *)
                                v897
                        let v1104 : US19 =
                            match v1082 with
                            | US19_Error(v1083, v1084, v1085, v1086, v1087, v1088) -> (* Error *)
                                let v1089 : string = ""
                                US19_Ok(v1089, v877, v878, v879, v880, v881)
                            | US19_Ok(v1091, v1092, v1093, v1094, v1095, v1096) -> (* Ok *)
                                let v1097 : bool = v1092 = v877
                                if v1097 then
                                    let v1098 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                                    US19_Error(v1098, v877, v878, v879, v880, v881)
                                else
                                    let v1100 : UH0 = UH0_Nil
                                    method93(v0, v1091, v1100, v1092, v1093, v1094, v1095, v1096)
                        match v1104 with
                        | US19_Error(v1147, v1148, v1149, v1150, v1151, v1152) -> (* Error *)
                            let v1153 : bool = v877 >= v881
                            let v1171 : US18 =
                                if v1153 then
                                    let v1154 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                                    US18_Error(v1154, v877, v878, v879, v880, v881)
                                else
                                    let v1156 : char = (spiralStringIndex v0 (int v877))
                                    let v1157 : bool = v1156 = '"'
                                    if v1157 then
                                        let v1158 : int32 = v877 + 1
                                        let v1159 : bool = '\n' = v1156
                                        let struct (v1163 : int32, v1164 : int32, v1165 : int32, v1166 : int32) =
                                            if v1159 then
                                                let v1160 : int32 = v878 + v880
                                                let v1161 : int32 = v879 + 1
                                                struct (v1160, v1161, 1, v881)
                                            else
                                                let v1162 : int32 = v880 + 1
                                                struct (v878, v879, v1162, v881)
                                        US18_Ok('"', v1158, v1163, v1164, v1165, v1166)
                                    else
                                        let v1168 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                                        US18_Error(v1168, v877, v878, v879, v880, v881)
                            match v1171 with
                            | US18_Error(v1180, v1181, v1182, v1183, v1184, v1185) -> (* Error *)
                                let v1186 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure39()
                                US19_Error(v1186, v877, v878, v879, v880, v881)
                            | US18_Ok(v1172, v1173, v1174, v1175, v1176, v1177) -> (* Ok *)
                                let v1178 : string = ""
                                US19_Ok(v1178, v1173, v1174, v1175, v1176, v1177)
                        | US19_Ok(v1105, v1106, v1107, v1108, v1109, v1110) -> (* Ok *)
                            let v1111 : bool = v1106 >= v1110
                            let v1129 : US18 =
                                if v1111 then
                                    let v1112 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                                    US18_Error(v1112, v1106, v1107, v1108, v1109, v1110)
                                else
                                    let v1114 : char = (spiralStringIndex v0 (int v1106))
                                    let v1115 : bool = v1114 = '"'
                                    if v1115 then
                                        let v1116 : int32 = v1106 + 1
                                        let v1117 : bool = '\n' = v1114
                                        let struct (v1121 : int32, v1122 : int32, v1123 : int32, v1124 : int32) =
                                            if v1117 then
                                                let v1118 : int32 = v1107 + v1109
                                                let v1119 : int32 = v1108 + 1
                                                struct (v1118, v1119, 1, v1110)
                                            else
                                                let v1120 : int32 = v1109 + 1
                                                struct (v1107, v1108, v1120, v1110)
                                        US18_Ok('"', v1116, v1121, v1122, v1123, v1124)
                                    else
                                        let v1126 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                                        US18_Error(v1126, v1106, v1107, v1108, v1109, v1110)
                            match v1129 with
                            | US18_Error(v1137, v1138, v1139, v1140, v1141, v1142) -> (* Error *)
                                let v1143 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure40(v877, v1106, v1137, v1138, v1139, v1140, v1141, v1142)
                                US19_Error(v1143, v1106, v1107, v1108, v1109, v1110)
                            | US18_Ok(v1130, v1131, v1132, v1133, v1134, v1135) -> (* Ok *)
                                US19_Ok(v1105, v1131, v1132, v1133, v1134, v1135)
                | US19_Ok(v846, v847, v848, v849, v850, v851) -> (* Ok *)
                    v845
            let v1232 : US19 =
                match v1202 with
                | US19_Error(v1209, v1210, v1211, v1212, v1213, v1214) -> (* Error *)
                    let struct (v1215 : int32, v1216 : int32, v1217 : int32, v1218 : int32, v1219 : int32) = method100(v41, v42, v43, v44, v0, v40)
                    let v1220 : bool = v1215 > v40
                    if v1220 then
                        let v1221 : bool = v40 >= v1215
                        let v1226 : string =
                            if v1221 then
                                let v1222 : string = ""
                                v1222
                            else
                                let v1223 : bool = v40 = v1215
                                let v1224 : int32 = v1215 - 1
                                let v1225 : string = (spiralStringSlice v0 (int v40) (int v1224))
                                v1225
                        US19_Ok(v1226, v1215, v1216, v1217, v1218, v1219)
                    else
                        let v1228 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure54()
                        US19_Error(v1228, v40, v41, v42, v43, v44)
                | US19_Ok(v1203, v1204, v1205, v1206, v1207, v1208) -> (* Ok *)
                    v1202
            let v1267 : US19 =
                match v1232 with
                | US19_Error(v1239, v1240, v1241, v1242, v1243, v1244) -> (* Error *)
                    let v1245 : UH0 = UH0_Nil
                    let v1246 : US27 = method96(v0, v1245, v40, v41, v42, v43, v44)
                    match v1246 with
                    | US27_Error(v1257, v1258, v1259, v1260, v1261, v1262) -> (* Error *)
                        US19_Error(v1257, v1258, v1259, v1260, v1261, v1262)
                    | US27_Ok(v1247, v1248, v1249, v1250, v1251, v1252) -> (* Ok *)
                        let v1253 : string = ""
                        let struct (v1254 : string, v1255 : string) = method98(v1247, v1253)
                        US19_Ok(v1254, v1248, v1249, v1250, v1251, v1252)
                | US19_Ok(v1233, v1234, v1235, v1236, v1237, v1238) -> (* Ok *)
                    v1232
            let v1278 : US19 =
                match v1267 with
                | US19_Ok(v1268, v1269, v1270, v1271, v1272, v1273) -> (* Ok *)
                    let v1274 : bool = v1269 = v40
                    if v1274 then
                        let v1275 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure63()
                        US19_Error(v1275, v40, v41, v42, v43, v44)
                    else
                        v1267
                | _ ->
                    v1267
            let v1295 : US19 =
                match v1278 with
                | US19_Error(v1279, v1280, v1281, v1282, v1283, v1284) -> (* Error *)
                    US19_Error(v1279, v1280, v1281, v1282, v1283, v1284)
                | US19_Ok(v1286, v1287, v1288, v1289, v1290, v1291) -> (* Ok *)
                    let v1292 : UH0 = UH0_Nil
                    method99(v0, v1286, v1292, v1287, v1288, v1289, v1290, v1291)
            match v1295 with
            | US19_Error(v1304, v1305, v1306, v1307, v1308, v1309) -> (* Error *)
                let v1310 : UH0 = UH0_Nil
                let v1311 : UH0 = method97(v1, v1310)
                US27_Ok(v1311, v2, v3, v4, v5, v6)
            | US19_Ok(v1296, v1297, v1298, v1299, v1300, v1301) -> (* Ok *)
                let v1302 : UH0 = UH0_Cons(v1296, v1)
                method102(v0, v1302, v1297, v1298, v1299, v1300, v1301)
and method103 (v0 : UH0, v1 : string list) : string list =
    match v0 with
    | UH0_Cons(v2, v3) -> (* Cons *)
        let v4 : string list = method103(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH0_Nil -> (* Nil *)
        v1
and split_args_87 (v0 : string) : US26 =
    let v1 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v0))
    let v2 : bool = 0 >= v1
    let v16 : US18 =
        if v2 then
            let v3 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure50()
            US18_Error(v3, 0, 0, 1, 1, v1)
        else
            let v5 : char = (spiralStringIndex v0 (int 0))
            let v6 : bool = v5 = '\\'
            if v6 then
                let v7 : bool = '\n' = v5
                let struct (v8 : int32, v9 : int32, v10 : int32, v11 : int32) =
                    if v7 then
                        struct (1, 2, 1, v1)
                    else
                        struct (0, 1, 2, v1)
                US18_Ok('\\', 1, v8, v9, v10, v11)
            else
                let v13 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure51()
                US18_Error(v13, 0, 0, 1, 1, v1)
    let v50 : US18 =
        match v16 with
        | US18_Error(v42, v43, v44, v45, v46, v47) -> (* Error *)
            US18_Error(v42, v43, v44, v45, v46, v47)
        | US18_Ok(v17, v18, v19, v20, v21, v22) -> (* Ok *)
            let v23 : bool = v18 >= v22
            if v23 then
                let v24 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                US18_Error(v24, v18, v19, v20, v21, v22)
            else
                let v26 : char = (spiralStringIndex v0 (int v18))
                let v27 : bool = v26 = '"'
                if v27 then
                    let v28 : int32 = v18 + 1
                    let v29 : bool = '\n' = v26
                    let struct (v33 : int32, v34 : int32, v35 : int32, v36 : int32) =
                        if v29 then
                            let v30 : int32 = v19 + v21
                            let v31 : int32 = v20 + 1
                            struct (v30, v31, 1, v22)
                        else
                            let v32 : int32 = v21 + 1
                            struct (v19, v20, v32, v22)
                    US18_Ok('"', v28, v33, v34, v35, v36)
                else
                    let v38 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                    US18_Error(v38, v18, v19, v20, v21, v22)
    let v66 : US18 =
        match v50 with
        | US18_Error(v58, v59, v60, v61, v62, v63) -> (* Error *)
            US18_Error(v58, v59, v60, v61, v62, v63)
        | US18_Ok(v51, v52, v53, v54, v55, v56) -> (* Ok *)
            US18_Ok('"', v52, v53, v54, v55, v56)
    let v160 : US18 =
        match v66 with
        | US18_Error(v73, v74, v75, v76, v77, v78) -> (* Error *)
            let v92 : US18 =
                if v2 then
                    let v79 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure52()
                    US18_Error(v79, 0, 0, 1, 1, v1)
                else
                    let v81 : char = (spiralStringIndex v0 (int 0))
                    let v82 : bool = v81 = '`'
                    if v82 then
                        let v83 : bool = '\n' = v81
                        let struct (v84 : int32, v85 : int32, v86 : int32, v87 : int32) =
                            if v83 then
                                struct (1, 2, 1, v1)
                            else
                                struct (0, 1, 2, v1)
                        US18_Ok('`', 1, v84, v85, v86, v87)
                    else
                        let v89 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure53()
                        US18_Error(v89, 0, 0, 1, 1, v1)
            let v126 : US18 =
                match v92 with
                | US18_Error(v118, v119, v120, v121, v122, v123) -> (* Error *)
                    US18_Error(v118, v119, v120, v121, v122, v123)
                | US18_Ok(v93, v94, v95, v96, v97, v98) -> (* Ok *)
                    let v99 : bool = v94 >= v98
                    if v99 then
                        let v100 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                        US18_Error(v100, v94, v95, v96, v97, v98)
                    else
                        let v102 : char = (spiralStringIndex v0 (int v94))
                        let v103 : bool = v102 = '"'
                        if v103 then
                            let v104 : int32 = v94 + 1
                            let v105 : bool = '\n' = v102
                            let struct (v109 : int32, v110 : int32, v111 : int32, v112 : int32) =
                                if v105 then
                                    let v106 : int32 = v95 + v97
                                    let v107 : int32 = v96 + 1
                                    struct (v106, v107, 1, v98)
                                else
                                    let v108 : int32 = v97 + 1
                                    struct (v95, v96, v108, v98)
                            US18_Ok('"', v104, v109, v110, v111, v112)
                        else
                            let v114 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                            US18_Error(v114, v94, v95, v96, v97, v98)
            let v142 : US18 =
                match v126 with
                | US18_Error(v134, v135, v136, v137, v138, v139) -> (* Error *)
                    US18_Error(v134, v135, v136, v137, v138, v139)
                | US18_Ok(v127, v128, v129, v130, v131, v132) -> (* Ok *)
                    US18_Ok('"', v128, v129, v130, v131, v132)
            match v142 with
            | US18_Error(v149, v150, v151, v152, v153, v154) -> (* Error *)
                let v155 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure35()
                US18_Error(v155, 0, 0, 1, 1, v1)
            | US18_Ok(v143, v144, v145, v146, v147, v148) -> (* Ok *)
                v142
        | US18_Ok(v67, v68, v69, v70, v71, v72) -> (* Ok *)
            v66
    let v791 : US19 =
        match v160 with
        | US18_Error(v783, v784, v785, v786, v787, v788) -> (* Error *)
            US19_Error(v783, v784, v785, v786, v787, v788)
        | US18_Ok(v161, v162, v163, v164, v165, v166) -> (* Ok *)
            let struct (v167 : int32, v168 : int32, v169 : int32, v170 : int32, v171 : int32) = method88(v163, v164, v165, v166, v0, v162)
            let v172 : bool = v167 > v162
            let v182 : US19 =
                if v172 then
                    let v173 : bool = v162 >= v167
                    let v178 : string =
                        if v173 then
                            let v174 : string = ""
                            v174
                        else
                            let v175 : bool = v162 = v167
                            let v176 : int32 = v167 - 1
                            let v177 : string = (spiralStringSlice v0 (int v162) (int v176))
                            v177
                    US19_Ok(v178, v167, v168, v169, v170, v171)
                else
                    let v180 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure54()
                    US19_Error(v180, v162, v163, v164, v165, v166)
            let v377 : US19 =
                match v182 with
                | US19_Error(v189, v190, v191, v192, v193, v194) -> (* Error *)
                    let v195 : bool = v162 >= v166
                    let v213 : US18 =
                        if v195 then
                            let v196 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure50()
                            US18_Error(v196, v162, v163, v164, v165, v166)
                        else
                            let v198 : char = (spiralStringIndex v0 (int v162))
                            let v199 : bool = v198 = '\\'
                            if v199 then
                                let v200 : int32 = v162 + 1
                                let v201 : bool = '\n' = v198
                                let struct (v205 : int32, v206 : int32, v207 : int32, v208 : int32) =
                                    if v201 then
                                        let v202 : int32 = v163 + v165
                                        let v203 : int32 = v164 + 1
                                        struct (v202, v203, 1, v166)
                                    else
                                        let v204 : int32 = v165 + 1
                                        struct (v163, v164, v204, v166)
                                US18_Ok('\\', v200, v205, v206, v207, v208)
                            else
                                let v210 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure51()
                                US18_Error(v210, v162, v163, v164, v165, v166)
                    let v248 : US18 =
                        match v213 with
                        | US18_Error(v240, v241, v242, v243, v244, v245) -> (* Error *)
                            US18_Error(v240, v241, v242, v243, v244, v245)
                        | US18_Ok(v214, v215, v216, v217, v218, v219) -> (* Ok *)
                            let v220 : bool = v215 >= v219
                            if v220 then
                                let v221 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure55()
                                US18_Error(v221, v215, v216, v217, v218, v219)
                            else
                                let v223 : char = (spiralStringIndex v0 (int v215))
                                let v224 : bool = v223 = '"'
                                let v225 : bool = v224 = false
                                if v225 then
                                    let v226 : int32 = v215 + 1
                                    let v227 : bool = '\n' = v223
                                    let struct (v231 : int32, v232 : int32, v233 : int32, v234 : int32) =
                                        if v227 then
                                            let v228 : int32 = v216 + v218
                                            let v229 : int32 = v217 + 1
                                            struct (v228, v229, 1, v219)
                                        else
                                            let v230 : int32 = v218 + 1
                                            struct (v216, v217, v230, v219)
                                    US18_Ok(v223, v226, v231, v232, v233, v234)
                                else
                                    let v236 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                                    US18_Error(v236, v215, v216, v217, v218, v219)
                    let v270 : US19 =
                        match v248 with
                        | US18_Error(v262, v263, v264, v265, v266, v267) -> (* Error *)
                            US19_Error(v262, v263, v264, v265, v266, v267)
                        | US18_Ok(v249, v250, v251, v252, v253, v254) -> (* Ok *)
                            let v255 : bool = v162 >= v250
                            let v260 : string =
                                if v255 then
                                    let v256 : string = ""
                                    v256
                                else
                                    let v257 : bool = v162 = v250
                                    let v258 : int32 = v250 - 1
                                    let v259 : string = (spiralStringSlice v0 (int v162) (int v258))
                                    v259
                            US19_Ok(v260, v250, v251, v252, v253, v254)
                    match v270 with
                    | US19_Error(v277, v278, v279, v280, v281, v282) -> (* Error *)
                        let v300 : US18 =
                            if v195 then
                                let v283 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure52()
                                US18_Error(v283, v162, v163, v164, v165, v166)
                            else
                                let v285 : char = (spiralStringIndex v0 (int v162))
                                let v286 : bool = v285 = '`'
                                if v286 then
                                    let v287 : int32 = v162 + 1
                                    let v288 : bool = '\n' = v285
                                    let struct (v292 : int32, v293 : int32, v294 : int32, v295 : int32) =
                                        if v288 then
                                            let v289 : int32 = v163 + v165
                                            let v290 : int32 = v164 + 1
                                            struct (v289, v290, 1, v166)
                                        else
                                            let v291 : int32 = v165 + 1
                                            struct (v163, v164, v291, v166)
                                    US18_Ok('`', v287, v292, v293, v294, v295)
                                else
                                    let v297 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure53()
                                    US18_Error(v297, v162, v163, v164, v165, v166)
                        let v335 : US18 =
                            match v300 with
                            | US18_Error(v327, v328, v329, v330, v331, v332) -> (* Error *)
                                US18_Error(v327, v328, v329, v330, v331, v332)
                            | US18_Ok(v301, v302, v303, v304, v305, v306) -> (* Ok *)
                                let v307 : bool = v302 >= v306
                                if v307 then
                                    let v308 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure55()
                                    US18_Error(v308, v302, v303, v304, v305, v306)
                                else
                                    let v310 : char = (spiralStringIndex v0 (int v302))
                                    let v311 : bool = v310 = '"'
                                    let v312 : bool = v311 = false
                                    if v312 then
                                        let v313 : int32 = v302 + 1
                                        let v314 : bool = '\n' = v310
                                        let struct (v318 : int32, v319 : int32, v320 : int32, v321 : int32) =
                                            if v314 then
                                                let v315 : int32 = v303 + v305
                                                let v316 : int32 = v304 + 1
                                                struct (v315, v316, 1, v306)
                                            else
                                                let v317 : int32 = v305 + 1
                                                struct (v303, v304, v317, v306)
                                        US18_Ok(v310, v313, v318, v319, v320, v321)
                                    else
                                        let v323 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                                        US18_Error(v323, v302, v303, v304, v305, v306)
                        let v357 : US19 =
                            match v335 with
                            | US18_Error(v349, v350, v351, v352, v353, v354) -> (* Error *)
                                US19_Error(v349, v350, v351, v352, v353, v354)
                            | US18_Ok(v336, v337, v338, v339, v340, v341) -> (* Ok *)
                                let v342 : bool = v162 >= v337
                                let v347 : string =
                                    if v342 then
                                        let v343 : string = ""
                                        v343
                                    else
                                        let v344 : bool = v162 = v337
                                        let v345 : int32 = v337 - 1
                                        let v346 : string = (spiralStringSlice v0 (int v162) (int v345))
                                        v346
                                US19_Ok(v347, v337, v338, v339, v340, v341)
                        match v357 with
                        | US19_Error(v364, v365, v366, v367, v368, v369) -> (* Error *)
                            let v370 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure35()
                            US19_Error(v370, v162, v163, v164, v165, v166)
                        | US19_Ok(v358, v359, v360, v361, v362, v363) -> (* Ok *)
                            v357
                    | US19_Ok(v271, v272, v273, v274, v275, v276) -> (* Ok *)
                        v270
                | US19_Ok(v183, v184, v185, v186, v187, v188) -> (* Ok *)
                    v182
            let v399 : US19 =
                match v377 with
                | US19_Error(v378, v379, v380, v381, v382, v383) -> (* Error *)
                    let v384 : string = ""
                    US19_Ok(v384, v162, v163, v164, v165, v166)
                | US19_Ok(v386, v387, v388, v389, v390, v391) -> (* Ok *)
                    let v392 : bool = v387 = v162
                    if v392 then
                        let v393 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                        US19_Error(v393, v162, v163, v164, v165, v166)
                    else
                        let v395 : UH0 = UH0_Nil
                        method90(v0, v386, v395, v387, v388, v389, v390, v391)
            match v399 with
            | US19_Error(v590, v591, v592, v593, v594, v595) -> (* Error *)
                let v596 : bool = v162 >= v166
                let v614 : US18 =
                    if v596 then
                        let v597 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure50()
                        US18_Error(v597, v162, v163, v164, v165, v166)
                    else
                        let v599 : char = (spiralStringIndex v0 (int v162))
                        let v600 : bool = v599 = '\\'
                        if v600 then
                            let v601 : int32 = v162 + 1
                            let v602 : bool = '\n' = v599
                            let struct (v606 : int32, v607 : int32, v608 : int32, v609 : int32) =
                                if v602 then
                                    let v603 : int32 = v163 + v165
                                    let v604 : int32 = v164 + 1
                                    struct (v603, v604, 1, v166)
                                else
                                    let v605 : int32 = v165 + 1
                                    struct (v163, v164, v605, v166)
                            US18_Ok('\\', v601, v606, v607, v608, v609)
                        else
                            let v611 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure51()
                            US18_Error(v611, v162, v163, v164, v165, v166)
                let v648 : US18 =
                    match v614 with
                    | US18_Error(v640, v641, v642, v643, v644, v645) -> (* Error *)
                        US18_Error(v640, v641, v642, v643, v644, v645)
                    | US18_Ok(v615, v616, v617, v618, v619, v620) -> (* Ok *)
                        let v621 : bool = v616 >= v620
                        if v621 then
                            let v622 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                            US18_Error(v622, v616, v617, v618, v619, v620)
                        else
                            let v624 : char = (spiralStringIndex v0 (int v616))
                            let v625 : bool = v624 = '"'
                            if v625 then
                                let v626 : int32 = v616 + 1
                                let v627 : bool = '\n' = v624
                                let struct (v631 : int32, v632 : int32, v633 : int32, v634 : int32) =
                                    if v627 then
                                        let v628 : int32 = v617 + v619
                                        let v629 : int32 = v618 + 1
                                        struct (v628, v629, 1, v620)
                                    else
                                        let v630 : int32 = v619 + 1
                                        struct (v617, v618, v630, v620)
                                US18_Ok('"', v626, v631, v632, v633, v634)
                            else
                                let v636 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                                US18_Error(v636, v616, v617, v618, v619, v620)
                let v664 : US18 =
                    match v648 with
                    | US18_Error(v656, v657, v658, v659, v660, v661) -> (* Error *)
                        US18_Error(v656, v657, v658, v659, v660, v661)
                    | US18_Ok(v649, v650, v651, v652, v653, v654) -> (* Ok *)
                        US18_Ok('"', v650, v651, v652, v653, v654)
                let v762 : US18 =
                    match v664 with
                    | US18_Error(v671, v672, v673, v674, v675, v676) -> (* Error *)
                        let v694 : US18 =
                            if v596 then
                                let v677 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure52()
                                US18_Error(v677, v162, v163, v164, v165, v166)
                            else
                                let v679 : char = (spiralStringIndex v0 (int v162))
                                let v680 : bool = v679 = '`'
                                if v680 then
                                    let v681 : int32 = v162 + 1
                                    let v682 : bool = '\n' = v679
                                    let struct (v686 : int32, v687 : int32, v688 : int32, v689 : int32) =
                                        if v682 then
                                            let v683 : int32 = v163 + v165
                                            let v684 : int32 = v164 + 1
                                            struct (v683, v684, 1, v166)
                                        else
                                            let v685 : int32 = v165 + 1
                                            struct (v163, v164, v685, v166)
                                    US18_Ok('`', v681, v686, v687, v688, v689)
                                else
                                    let v691 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure53()
                                    US18_Error(v691, v162, v163, v164, v165, v166)
                        let v728 : US18 =
                            match v694 with
                            | US18_Error(v720, v721, v722, v723, v724, v725) -> (* Error *)
                                US18_Error(v720, v721, v722, v723, v724, v725)
                            | US18_Ok(v695, v696, v697, v698, v699, v700) -> (* Ok *)
                                let v701 : bool = v696 >= v700
                                if v701 then
                                    let v702 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                                    US18_Error(v702, v696, v697, v698, v699, v700)
                                else
                                    let v704 : char = (spiralStringIndex v0 (int v696))
                                    let v705 : bool = v704 = '"'
                                    if v705 then
                                        let v706 : int32 = v696 + 1
                                        let v707 : bool = '\n' = v704
                                        let struct (v711 : int32, v712 : int32, v713 : int32, v714 : int32) =
                                            if v707 then
                                                let v708 : int32 = v697 + v699
                                                let v709 : int32 = v698 + 1
                                                struct (v708, v709, 1, v700)
                                            else
                                                let v710 : int32 = v699 + 1
                                                struct (v697, v698, v710, v700)
                                        US18_Ok('"', v706, v711, v712, v713, v714)
                                    else
                                        let v716 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                                        US18_Error(v716, v696, v697, v698, v699, v700)
                        let v744 : US18 =
                            match v728 with
                            | US18_Error(v736, v737, v738, v739, v740, v741) -> (* Error *)
                                US18_Error(v736, v737, v738, v739, v740, v741)
                            | US18_Ok(v729, v730, v731, v732, v733, v734) -> (* Ok *)
                                US18_Ok('"', v730, v731, v732, v733, v734)
                        match v744 with
                        | US18_Error(v751, v752, v753, v754, v755, v756) -> (* Error *)
                            let v757 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure35()
                            US18_Error(v757, v162, v163, v164, v165, v166)
                        | US18_Ok(v745, v746, v747, v748, v749, v750) -> (* Ok *)
                            v744
                    | US18_Ok(v665, v666, v667, v668, v669, v670) -> (* Ok *)
                        v664
                match v762 with
                | US18_Error(v771, v772, v773, v774, v775, v776) -> (* Error *)
                    let v777 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure39()
                    US19_Error(v777, v162, v163, v164, v165, v166)
                | US18_Ok(v763, v764, v765, v766, v767, v768) -> (* Ok *)
                    let v769 : string = ""
                    US19_Ok(v769, v764, v765, v766, v767, v768)
            | US19_Ok(v400, v401, v402, v403, v404, v405) -> (* Ok *)
                let v406 : bool = v401 >= v405
                let v424 : US18 =
                    if v406 then
                        let v407 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure50()
                        US18_Error(v407, v401, v402, v403, v404, v405)
                    else
                        let v409 : char = (spiralStringIndex v0 (int v401))
                        let v410 : bool = v409 = '\\'
                        if v410 then
                            let v411 : int32 = v401 + 1
                            let v412 : bool = '\n' = v409
                            let struct (v416 : int32, v417 : int32, v418 : int32, v419 : int32) =
                                if v412 then
                                    let v413 : int32 = v402 + v404
                                    let v414 : int32 = v403 + 1
                                    struct (v413, v414, 1, v405)
                                else
                                    let v415 : int32 = v404 + 1
                                    struct (v402, v403, v415, v405)
                            US18_Ok('\\', v411, v416, v417, v418, v419)
                        else
                            let v421 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure51()
                            US18_Error(v421, v401, v402, v403, v404, v405)
                let v458 : US18 =
                    match v424 with
                    | US18_Error(v450, v451, v452, v453, v454, v455) -> (* Error *)
                        US18_Error(v450, v451, v452, v453, v454, v455)
                    | US18_Ok(v425, v426, v427, v428, v429, v430) -> (* Ok *)
                        let v431 : bool = v426 >= v430
                        if v431 then
                            let v432 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                            US18_Error(v432, v426, v427, v428, v429, v430)
                        else
                            let v434 : char = (spiralStringIndex v0 (int v426))
                            let v435 : bool = v434 = '"'
                            if v435 then
                                let v436 : int32 = v426 + 1
                                let v437 : bool = '\n' = v434
                                let struct (v441 : int32, v442 : int32, v443 : int32, v444 : int32) =
                                    if v437 then
                                        let v438 : int32 = v427 + v429
                                        let v439 : int32 = v428 + 1
                                        struct (v438, v439, 1, v430)
                                    else
                                        let v440 : int32 = v429 + 1
                                        struct (v427, v428, v440, v430)
                                US18_Ok('"', v436, v441, v442, v443, v444)
                            else
                                let v446 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                                US18_Error(v446, v426, v427, v428, v429, v430)
                let v474 : US18 =
                    match v458 with
                    | US18_Error(v466, v467, v468, v469, v470, v471) -> (* Error *)
                        US18_Error(v466, v467, v468, v469, v470, v471)
                    | US18_Ok(v459, v460, v461, v462, v463, v464) -> (* Ok *)
                        US18_Ok('"', v460, v461, v462, v463, v464)
                let v572 : US18 =
                    match v474 with
                    | US18_Error(v481, v482, v483, v484, v485, v486) -> (* Error *)
                        let v504 : US18 =
                            if v406 then
                                let v487 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure52()
                                US18_Error(v487, v401, v402, v403, v404, v405)
                            else
                                let v489 : char = (spiralStringIndex v0 (int v401))
                                let v490 : bool = v489 = '`'
                                if v490 then
                                    let v491 : int32 = v401 + 1
                                    let v492 : bool = '\n' = v489
                                    let struct (v496 : int32, v497 : int32, v498 : int32, v499 : int32) =
                                        if v492 then
                                            let v493 : int32 = v402 + v404
                                            let v494 : int32 = v403 + 1
                                            struct (v493, v494, 1, v405)
                                        else
                                            let v495 : int32 = v404 + 1
                                            struct (v402, v403, v495, v405)
                                    US18_Ok('`', v491, v496, v497, v498, v499)
                                else
                                    let v501 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure53()
                                    US18_Error(v501, v401, v402, v403, v404, v405)
                        let v538 : US18 =
                            match v504 with
                            | US18_Error(v530, v531, v532, v533, v534, v535) -> (* Error *)
                                US18_Error(v530, v531, v532, v533, v534, v535)
                            | US18_Ok(v505, v506, v507, v508, v509, v510) -> (* Ok *)
                                let v511 : bool = v506 >= v510
                                if v511 then
                                    let v512 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                                    US18_Error(v512, v506, v507, v508, v509, v510)
                                else
                                    let v514 : char = (spiralStringIndex v0 (int v506))
                                    let v515 : bool = v514 = '"'
                                    if v515 then
                                        let v516 : int32 = v506 + 1
                                        let v517 : bool = '\n' = v514
                                        let struct (v521 : int32, v522 : int32, v523 : int32, v524 : int32) =
                                            if v517 then
                                                let v518 : int32 = v507 + v509
                                                let v519 : int32 = v508 + 1
                                                struct (v518, v519, 1, v510)
                                            else
                                                let v520 : int32 = v509 + 1
                                                struct (v507, v508, v520, v510)
                                        US18_Ok('"', v516, v521, v522, v523, v524)
                                    else
                                        let v526 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                                        US18_Error(v526, v506, v507, v508, v509, v510)
                        let v554 : US18 =
                            match v538 with
                            | US18_Error(v546, v547, v548, v549, v550, v551) -> (* Error *)
                                US18_Error(v546, v547, v548, v549, v550, v551)
                            | US18_Ok(v539, v540, v541, v542, v543, v544) -> (* Ok *)
                                US18_Ok('"', v540, v541, v542, v543, v544)
                        match v554 with
                        | US18_Error(v561, v562, v563, v564, v565, v566) -> (* Error *)
                            let v567 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure35()
                            US18_Error(v567, v401, v402, v403, v404, v405)
                        | US18_Ok(v555, v556, v557, v558, v559, v560) -> (* Ok *)
                            v554
                    | US18_Ok(v475, v476, v477, v478, v479, v480) -> (* Ok *)
                        v474
                match v572 with
                | US18_Error(v580, v581, v582, v583, v584, v585) -> (* Error *)
                    let v586 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure40(v162, v401, v580, v581, v582, v583, v584, v585)
                    US19_Error(v586, v401, v402, v403, v404, v405)
                | US18_Ok(v573, v574, v575, v576, v577, v578) -> (* Ok *)
                    US19_Ok(v400, v574, v575, v576, v577, v578)
    let v1144 : US19 =
        match v791 with
        | US19_Error(v798, v799, v800, v801, v802, v803) -> (* Error *)
            let v817 : US18 =
                if v2 then
                    let v804 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                    US18_Error(v804, 0, 0, 1, 1, v1)
                else
                    let v806 : char = (spiralStringIndex v0 (int 0))
                    let v807 : bool = v806 = '"'
                    if v807 then
                        let v808 : bool = '\n' = v806
                        let struct (v809 : int32, v810 : int32, v811 : int32, v812 : int32) =
                            if v808 then
                                struct (1, 2, 1, v1)
                            else
                                struct (0, 1, 2, v1)
                        US18_Ok('"', 1, v809, v810, v811, v812)
                    else
                        let v814 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                        US18_Error(v814, 0, 0, 1, 1, v1)
            match v817 with
            | US18_Error(v1134, v1135, v1136, v1137, v1138, v1139) -> (* Error *)
                US19_Error(v1134, v1135, v1136, v1137, v1138, v1139)
            | US18_Ok(v818, v819, v820, v821, v822, v823) -> (* Ok *)
                let struct (v824 : int32, v825 : int32, v826 : int32, v827 : int32, v828 : int32) = method88(v820, v821, v822, v823, v0, v819)
                let v829 : bool = v824 > v819
                let v839 : US19 =
                    if v829 then
                        let v830 : bool = v819 >= v824
                        let v835 : string =
                            if v830 then
                                let v831 : string = ""
                                v831
                            else
                                let v832 : bool = v819 = v824
                                let v833 : int32 = v824 - 1
                                let v834 : string = (spiralStringSlice v0 (int v819) (int v833))
                                v834
                        US19_Ok(v835, v824, v825, v826, v827, v828)
                    else
                        let v837 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure54()
                        US19_Error(v837, v819, v820, v821, v822, v823)
                let v1024 : US19 =
                    match v839 with
                    | US19_Error(v846, v847, v848, v849, v850, v851) -> (* Error *)
                        let v852 : bool = v819 >= v823
                        let v870 : US18 =
                            if v852 then
                                let v853 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure50()
                                US18_Error(v853, v819, v820, v821, v822, v823)
                            else
                                let v855 : char = (spiralStringIndex v0 (int v819))
                                let v856 : bool = v855 = '\\'
                                if v856 then
                                    let v857 : int32 = v819 + 1
                                    let v858 : bool = '\n' = v855
                                    let struct (v862 : int32, v863 : int32, v864 : int32, v865 : int32) =
                                        if v858 then
                                            let v859 : int32 = v820 + v822
                                            let v860 : int32 = v821 + 1
                                            struct (v859, v860, 1, v823)
                                        else
                                            let v861 : int32 = v822 + 1
                                            struct (v820, v821, v861, v823)
                                    US18_Ok('\\', v857, v862, v863, v864, v865)
                                else
                                    let v867 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure51()
                                    US18_Error(v867, v819, v820, v821, v822, v823)
                        let v900 : US18 =
                            match v870 with
                            | US18_Error(v892, v893, v894, v895, v896, v897) -> (* Error *)
                                US18_Error(v892, v893, v894, v895, v896, v897)
                            | US18_Ok(v871, v872, v873, v874, v875, v876) -> (* Ok *)
                                let v877 : bool = v872 >= v876
                                if v877 then
                                    let v878 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                                    US18_Error(v878, v872, v873, v874, v875, v876)
                                else
                                    let v880 : char = (spiralStringIndex v0 (int v872))
                                    let v881 : int32 = v872 + 1
                                    let v882 : bool = '\n' = v880
                                    let struct (v886 : int32, v887 : int32, v888 : int32, v889 : int32) =
                                        if v882 then
                                            let v883 : int32 = v873 + v875
                                            let v884 : int32 = v874 + 1
                                            struct (v883, v884, 1, v876)
                                        else
                                            let v885 : int32 = v875 + 1
                                            struct (v873, v874, v885, v876)
                                    US18_Ok(v880, v881, v886, v887, v888, v889)
                        let v922 : US19 =
                            match v900 with
                            | US18_Error(v914, v915, v916, v917, v918, v919) -> (* Error *)
                                US19_Error(v914, v915, v916, v917, v918, v919)
                            | US18_Ok(v901, v902, v903, v904, v905, v906) -> (* Ok *)
                                let v907 : bool = v819 >= v902
                                let v912 : string =
                                    if v907 then
                                        let v908 : string = ""
                                        v908
                                    else
                                        let v909 : bool = v819 = v902
                                        let v910 : int32 = v902 - 1
                                        let v911 : string = (spiralStringSlice v0 (int v819) (int v910))
                                        v911
                                US19_Ok(v912, v902, v903, v904, v905, v906)
                        match v922 with
                        | US19_Error(v929, v930, v931, v932, v933, v934) -> (* Error *)
                            let v952 : US18 =
                                if v852 then
                                    let v935 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure52()
                                    US18_Error(v935, v819, v820, v821, v822, v823)
                                else
                                    let v937 : char = (spiralStringIndex v0 (int v819))
                                    let v938 : bool = v937 = '`'
                                    if v938 then
                                        let v939 : int32 = v819 + 1
                                        let v940 : bool = '\n' = v937
                                        let struct (v944 : int32, v945 : int32, v946 : int32, v947 : int32) =
                                            if v940 then
                                                let v941 : int32 = v820 + v822
                                                let v942 : int32 = v821 + 1
                                                struct (v941, v942, 1, v823)
                                            else
                                                let v943 : int32 = v822 + 1
                                                struct (v820, v821, v943, v823)
                                        US18_Ok('`', v939, v944, v945, v946, v947)
                                    else
                                        let v949 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure53()
                                        US18_Error(v949, v819, v820, v821, v822, v823)
                            let v982 : US18 =
                                match v952 with
                                | US18_Error(v974, v975, v976, v977, v978, v979) -> (* Error *)
                                    US18_Error(v974, v975, v976, v977, v978, v979)
                                | US18_Ok(v953, v954, v955, v956, v957, v958) -> (* Ok *)
                                    let v959 : bool = v954 >= v958
                                    if v959 then
                                        let v960 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                                        US18_Error(v960, v954, v955, v956, v957, v958)
                                    else
                                        let v962 : char = (spiralStringIndex v0 (int v954))
                                        let v963 : int32 = v954 + 1
                                        let v964 : bool = '\n' = v962
                                        let struct (v968 : int32, v969 : int32, v970 : int32, v971 : int32) =
                                            if v964 then
                                                let v965 : int32 = v955 + v957
                                                let v966 : int32 = v956 + 1
                                                struct (v965, v966, 1, v958)
                                            else
                                                let v967 : int32 = v957 + 1
                                                struct (v955, v956, v967, v958)
                                        US18_Ok(v962, v963, v968, v969, v970, v971)
                            let v1004 : US19 =
                                match v982 with
                                | US18_Error(v996, v997, v998, v999, v1000, v1001) -> (* Error *)
                                    US19_Error(v996, v997, v998, v999, v1000, v1001)
                                | US18_Ok(v983, v984, v985, v986, v987, v988) -> (* Ok *)
                                    let v989 : bool = v819 >= v984
                                    let v994 : string =
                                        if v989 then
                                            let v990 : string = ""
                                            v990
                                        else
                                            let v991 : bool = v819 = v984
                                            let v992 : int32 = v984 - 1
                                            let v993 : string = (spiralStringSlice v0 (int v819) (int v992))
                                            v993
                                    US19_Ok(v994, v984, v985, v986, v987, v988)
                            match v1004 with
                            | US19_Error(v1011, v1012, v1013, v1014, v1015, v1016) -> (* Error *)
                                let v1017 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure35()
                                US19_Error(v1017, v819, v820, v821, v822, v823)
                            | US19_Ok(v1005, v1006, v1007, v1008, v1009, v1010) -> (* Ok *)
                                v1004
                        | US19_Ok(v923, v924, v925, v926, v927, v928) -> (* Ok *)
                            v922
                    | US19_Ok(v840, v841, v842, v843, v844, v845) -> (* Ok *)
                        v839
                let v1046 : US19 =
                    match v1024 with
                    | US19_Error(v1025, v1026, v1027, v1028, v1029, v1030) -> (* Error *)
                        let v1031 : string = ""
                        US19_Ok(v1031, v819, v820, v821, v822, v823)
                    | US19_Ok(v1033, v1034, v1035, v1036, v1037, v1038) -> (* Ok *)
                        let v1039 : bool = v1034 = v819
                        if v1039 then
                            let v1040 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                            US19_Error(v1040, v819, v820, v821, v822, v823)
                        else
                            let v1042 : UH0 = UH0_Nil
                            method93(v0, v1033, v1042, v1034, v1035, v1036, v1037, v1038)
                match v1046 with
                | US19_Error(v1089, v1090, v1091, v1092, v1093, v1094) -> (* Error *)
                    let v1095 : bool = v819 >= v823
                    let v1113 : US18 =
                        if v1095 then
                            let v1096 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                            US18_Error(v1096, v819, v820, v821, v822, v823)
                        else
                            let v1098 : char = (spiralStringIndex v0 (int v819))
                            let v1099 : bool = v1098 = '"'
                            if v1099 then
                                let v1100 : int32 = v819 + 1
                                let v1101 : bool = '\n' = v1098
                                let struct (v1105 : int32, v1106 : int32, v1107 : int32, v1108 : int32) =
                                    if v1101 then
                                        let v1102 : int32 = v820 + v822
                                        let v1103 : int32 = v821 + 1
                                        struct (v1102, v1103, 1, v823)
                                    else
                                        let v1104 : int32 = v822 + 1
                                        struct (v820, v821, v1104, v823)
                                US18_Ok('"', v1100, v1105, v1106, v1107, v1108)
                            else
                                let v1110 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                                US18_Error(v1110, v819, v820, v821, v822, v823)
                    match v1113 with
                    | US18_Error(v1122, v1123, v1124, v1125, v1126, v1127) -> (* Error *)
                        let v1128 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure39()
                        US19_Error(v1128, v819, v820, v821, v822, v823)
                    | US18_Ok(v1114, v1115, v1116, v1117, v1118, v1119) -> (* Ok *)
                        let v1120 : string = ""
                        US19_Ok(v1120, v1115, v1116, v1117, v1118, v1119)
                | US19_Ok(v1047, v1048, v1049, v1050, v1051, v1052) -> (* Ok *)
                    let v1053 : bool = v1048 >= v1052
                    let v1071 : US18 =
                        if v1053 then
                            let v1054 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure30()
                            US18_Error(v1054, v1048, v1049, v1050, v1051, v1052)
                        else
                            let v1056 : char = (spiralStringIndex v0 (int v1048))
                            let v1057 : bool = v1056 = '"'
                            if v1057 then
                                let v1058 : int32 = v1048 + 1
                                let v1059 : bool = '\n' = v1056
                                let struct (v1063 : int32, v1064 : int32, v1065 : int32, v1066 : int32) =
                                    if v1059 then
                                        let v1060 : int32 = v1049 + v1051
                                        let v1061 : int32 = v1050 + 1
                                        struct (v1060, v1061, 1, v1052)
                                    else
                                        let v1062 : int32 = v1051 + 1
                                        struct (v1049, v1050, v1062, v1052)
                                US18_Ok('"', v1058, v1063, v1064, v1065, v1066)
                            else
                                let v1068 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure31()
                                US18_Error(v1068, v1048, v1049, v1050, v1051, v1052)
                    match v1071 with
                    | US18_Error(v1079, v1080, v1081, v1082, v1083, v1084) -> (* Error *)
                        let v1085 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure40(v819, v1048, v1079, v1080, v1081, v1082, v1083, v1084)
                        US19_Error(v1085, v1048, v1049, v1050, v1051, v1052)
                    | US18_Ok(v1072, v1073, v1074, v1075, v1076, v1077) -> (* Ok *)
                        US19_Ok(v1047, v1073, v1074, v1075, v1076, v1077)
        | US19_Ok(v792, v793, v794, v795, v796, v797) -> (* Ok *)
            v791
    let v1178 : US19 =
        match v1144 with
        | US19_Error(v1151, v1152, v1153, v1154, v1155, v1156) -> (* Error *)
            let v1157 : int32 = 0
            let v1158 : int32 = 0
            let v1159 : int32 = 1
            let v1160 : int32 = 1
            let struct (v1161 : int32, v1162 : int32, v1163 : int32, v1164 : int32, v1165 : int32) = method94(v1, v0, v1157, v1158, v1159, v1160)
            let v1166 : bool = v1161 > 0
            if v1166 then
                let v1167 : bool = 0 >= v1161
                let v1172 : string =
                    if v1167 then
                        let v1168 : string = ""
                        v1168
                    else
                        let v1169 : bool = 0 = v1161
                        let v1170 : int32 = v1161 - 1
                        let v1171 : string = (spiralStringSlice v0 (int 0) (int v1170))
                        v1171
                US19_Ok(v1172, v1161, v1162, v1163, v1164, v1165)
            else
                let v1174 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure54()
                US19_Error(v1174, 0, 0, 1, 1, v1)
        | US19_Ok(v1145, v1146, v1147, v1148, v1149, v1150) -> (* Ok *)
            v1144
    let v1217 : US19 =
        match v1178 with
        | US19_Error(v1185, v1186, v1187, v1188, v1189, v1190) -> (* Error *)
            let v1191 : UH0 = UH0_Nil
            let v1192 : int32 = 0
            let v1193 : int32 = 0
            let v1194 : int32 = 1
            let v1195 : int32 = 1
            let v1196 : US27 = method96(v0, v1191, v1192, v1193, v1194, v1195, v1)
            match v1196 with
            | US27_Error(v1207, v1208, v1209, v1210, v1211, v1212) -> (* Error *)
                US19_Error(v1207, v1208, v1209, v1210, v1211, v1212)
            | US27_Ok(v1197, v1198, v1199, v1200, v1201, v1202) -> (* Ok *)
                let v1203 : string = ""
                let struct (v1204 : string, v1205 : string) = method98(v1197, v1203)
                US19_Ok(v1204, v1198, v1199, v1200, v1201, v1202)
        | US19_Ok(v1179, v1180, v1181, v1182, v1183, v1184) -> (* Ok *)
            v1178
    let v1228 : US19 =
        match v1217 with
        | US19_Ok(v1218, v1219, v1220, v1221, v1222, v1223) -> (* Ok *)
            let v1224 : bool = v1219 = 0
            if v1224 then
                let v1225 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure63()
                US19_Error(v1225, 0, 0, 1, 1, v1)
            else
                v1217
        | _ ->
            v1217
    let v1245 : US19 =
        match v1228 with
        | US19_Error(v1229, v1230, v1231, v1232, v1233, v1234) -> (* Error *)
            US19_Error(v1229, v1230, v1231, v1232, v1233, v1234)
        | US19_Ok(v1236, v1237, v1238, v1239, v1240, v1241) -> (* Ok *)
            let v1242 : UH0 = UH0_Nil
            method99(v0, v1236, v1242, v1237, v1238, v1239, v1240, v1241)
    let v1264 : US27 =
        match v1245 with
        | US19_Error(v1246, v1247, v1248, v1249, v1250, v1251) -> (* Error *)
            let v1252 : UH0 = UH0_Nil
            US27_Ok(v1252, 0, 0, 1, 1, v1)
        | US19_Ok(v1254, v1255, v1256, v1257, v1258, v1259) -> (* Ok *)
            let v1260 : UH0 = UH0_Nil
            let v1261 : UH0 = UH0_Cons(v1254, v1260)
            method102(v0, v1261, v1255, v1256, v1257, v1258, v1259)
    let v1287 : US28 =
        match v1264 with
        | US27_Error(v1278, v1279, v1280, v1281, v1282, v1283) -> (* Error *)
            let v1284 : (unit -> string) = closure49(v0, v1278, v1279, v1280, v1281, v1282, v1283)
            US28_Error(v1284)
        | US27_Ok(v1265, v1266, v1267, v1268, v1269, v1270) -> (* Ok *)
            let v1271 : bool = v1266 >= v1270
            let v1276 : string =
                if v1271 then
                    let v1272 : string = ""
                    v1272
                else
                    let v1273 : bool = v1266 = v1270
                    let v1274 : int32 = v1270 - 1
                    let v1275 : string = (spiralStringSlice v0 (int v1266) (int v1274))
                    v1275
            US28_Ok(v1265, v1276, v1267, v1268, v1269, v1270)
    let v1302 : US29 =
        match v1287 with
        | US28_Error(v1299) -> (* Error *)
            US29_Error(v1299)
        | US28_Ok(v1288, v1289, v1290, v1291, v1292, v1293) -> (* Ok *)
            let v1294 : string list = []
            let v1295 : string list = method103(v1288, v1294)
            let v1296 : (string list -> (string [])) = List.toArray
            let v1297 : (string []) = v1296 v1295
            US29_Ok(v1297)
    match v1302 with
    | US29_Error(v1305) -> (* Error *)
        let v1306 : string = v1305 ()
        US26_Error(v1306)
    | US29_Ok(v1303) -> (* Ok *)
        US26_Ok(v1303)
and closure66 () (v0 : (string)) : std_string_String =
    let v1 : string = (v0)
    let v2 : Ref<Str> = v1 |> unbox<Ref<Str>>
    let v3 : std_string_String = v2 |> unbox<std_string_String>
    v3
and method105 (v0 : (struct (string * string) [])) : string =
    let v1 : uint64 = System.Convert.ToUInt64 v0.Length
    let v2 : uint64 = 0UL
    let v3 : Mut6 = {l0 = v2} : Mut6
    let v4 : string = ""
    let v5 : Mut3 = {l0 = v4} : Mut3
    while method16(v1, v3) do
        let v7 : uint64 = v3.l0
        let struct (v8 : string, v9 : string) = v0.[int v7]
        let v10 : string = ", "
        let v11 : string = v8 + v10 
        let v12 : string = v11 + v9 
        let v13 : string = "("
        let v14 : string = v13 + v12 
        let v15 : string = ")"
        let v16 : string = v14 + v15 
        let v17 : bool = v7 = 0UL
        let v21 : string =
            if v17 then
                v16
            else
                let v18 : string = v5.l0
                let v19 : string = v18 + v10 
                let v20 : string = v19 + v16 
                v20
        v5.l0 <- v21
        let v22 : uint64 = v7 + 1UL
        v3.l0 <- v22
        ()
    let v23 : string = v5.l0
    let v24 : string = "["
    let v25 : string = v24 + v23 
    let v26 : string = "]"
    let v27 : string = v25 + v26 
    v27
and method104 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option, v17 : bool) : string =
    let v18 : int64 = v0.l0
    let v19 : string = " "
    let v20 : string = v6 + v19 
    let v21 : string = format_real_14(v18)
    let v22 : string = v20 + v21 
    let v23 : string = v22 + v7 
    let v24 : string = v23 + v19 
    let v25 : string = "runtime.execute_with_options"
    let v26 : string = v24 + v25 
    let v27 : string = " / "
    let v28 : string = v26 + v27 
    let v29 : string = ""
    let v30 : string = v29 + v29 
    let v31 : string = "file_name"
    let v32 : string = v30 + v31 
    let v33 : string = " = "
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v8 
    let v36 : string = "; "
    let v37 : string = v35 + v36 
    let v38 : string = "arguments"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v33 
    let v41 : string = v40 + v9 
    let v42 : string = v41 + v36 
    let v43 : string = "options"
    let v44 : string = v42 + v43 
    let v45 : string = v44 + v33 
    let v46 : string = v29 + v29 
    let v47 : string = "command"
    let v48 : string = v46 + v47 
    let v49 : string = v48 + v33 
    let v50 : string = v49 + v10 
    let v51 : string = v50 + v36 
    let v52 : string = "cancellation_token"
    let v53 : string = v51 + v52 
    let v54 : string = v53 + v33 
    let v55 : string = $"%A{v11}"
    let v56 : string = v54 + v55 
    let v57 : string = v56 + v36 
    let v58 : string = "environment_variables"
    let v59 : string = v57 + v58 
    let v60 : string = v59 + v33 
    let v61 : string = method105(v12)
    let v62 : string = v60 + v61 
    let v63 : string = v62 + v36 
    let v64 : string = "on_line"
    let v65 : string = v63 + v64 
    let v66 : string = v65 + v33 
    let v67 : string = $"%A{v13}"
    let v68 : string = v66 + v67 
    let v69 : string = v68 + v36 
    let v70 : string = "stdin"
    let v71 : string = v69 + v70 
    let v72 : string = v71 + v33 
    let v73 : string = $"%A{v14}"
    let v74 : string = v72 + v73 
    let v75 : string = v74 + v36 
    let v76 : string = "trace"
    let v77 : string = v75 + v76 
    let v78 : string = v77 + v33 
    let v79 : string = format_real_60(v15)
    let v80 : string = v78 + v79 
    let v81 : string = v80 + v36 
    let v82 : string = "working_directory"
    let v83 : string = v81 + v82 
    let v84 : string = v83 + v33 
    let v85 : string = $"%A{v16}"
    let v86 : string = v84 + v85 
    let v87 : string = v86 + v36 
    let v88 : string = "stderr"
    let v89 : string = v87 + v88 
    let v90 : string = v89 + v33 
    let v91 : string = format_real_60(v17)
    let v92 : string = v90 + v91 
    let v93 : string = "{ "
    let v94 : string = v93 + v92 
    let v95 : string = " }"
    let v96 : string = v94 + v95 
    let v97 : string = v45 + v96 
    let v98 : string = v93 + v97 
    let v99 : string = v98 + v95 
    let v100 : string = v28 + v99 
    method17(v100)
and ok_c67 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : US30 =
    US30_Ok(v0)
and method106 () : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US30) =
    ok_c67()
and error_c68 () (v0 : std_string_String) : US30 =
    US30_Error(v0)
and method107 () : (std_string_String -> US30) =
    error_c68()
and method108 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String, v9 : string, v10 : string, v11 : string, v12 : System.Threading.CancellationToken option, v13 : (struct (string * string) []), v14 : (struct (int32 * string * bool) -> Async<unit>) option, v15 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v16 : bool, v17 : string option, v18 : bool) : string =
    let v19 : int64 = v0.l0
    let v20 : string = " "
    let v21 : string = v6 + v20 
    let v22 : string = format_real_14(v19)
    let v23 : string = v21 + v22 
    let v24 : string = v23 + v7 
    let v25 : string = v24 + v20 
    let v26 : string = "runtime.execute_with_options / child error"
    let v27 : string = v25 + v26 
    let v28 : string = " / "
    let v29 : string = v27 + v28 
    let v30 : string = ""
    let v31 : string = v30 + v30 
    let v32 : string = "error"
    let v33 : string = v31 + v32 
    let v34 : string = " = "
    let v35 : string = v33 + v34 
    let v36 : string = $"%A{v8}"
    let v37 : string = v35 + v36 
    let v38 : string = "; "
    let v39 : string = v37 + v38 
    let v40 : string = "file_name"
    let v41 : string = v39 + v40 
    let v42 : string = v41 + v34 
    let v43 : string = v42 + v9 
    let v44 : string = v43 + v38 
    let v45 : string = "arguments"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v34 
    let v48 : string = v47 + v10 
    let v49 : string = v48 + v38 
    let v50 : string = "options"
    let v51 : string = v49 + v50 
    let v52 : string = v51 + v34 
    let v53 : string = v30 + v30 
    let v54 : string = "command"
    let v55 : string = v53 + v54 
    let v56 : string = v55 + v34 
    let v57 : string = v56 + v11 
    let v58 : string = v57 + v38 
    let v59 : string = "cancellation_token"
    let v60 : string = v58 + v59 
    let v61 : string = v60 + v34 
    let v62 : string = $"%A{v12}"
    let v63 : string = v61 + v62 
    let v64 : string = v63 + v38 
    let v65 : string = "environment_variables"
    let v66 : string = v64 + v65 
    let v67 : string = v66 + v34 
    let v68 : string = method105(v13)
    let v69 : string = v67 + v68 
    let v70 : string = v69 + v38 
    let v71 : string = "on_line"
    let v72 : string = v70 + v71 
    let v73 : string = v72 + v34 
    let v74 : string = $"%A{v14}"
    let v75 : string = v73 + v74 
    let v76 : string = v75 + v38 
    let v77 : string = "stdin"
    let v78 : string = v76 + v77 
    let v79 : string = v78 + v34 
    let v80 : string = $"%A{v15}"
    let v81 : string = v79 + v80 
    let v82 : string = v81 + v38 
    let v83 : string = "trace"
    let v84 : string = v82 + v83 
    let v85 : string = v84 + v34 
    let v86 : string = format_real_60(v16)
    let v87 : string = v85 + v86 
    let v88 : string = v87 + v38 
    let v89 : string = "working_directory"
    let v90 : string = v88 + v89 
    let v91 : string = v90 + v34 
    let v92 : string = $"%A{v17}"
    let v93 : string = v91 + v92 
    let v94 : string = v93 + v38 
    let v95 : string = "stderr"
    let v96 : string = v94 + v95 
    let v97 : string = v96 + v34 
    let v98 : string = format_real_60(v18)
    let v99 : string = v97 + v98 
    let v100 : string = "{ "
    let v101 : string = v100 + v99 
    let v102 : string = " }"
    let v103 : string = v101 + v102 
    let v104 : string = v52 + v103 
    let v105 : string = v100 + v104 
    let v106 : string = v105 + v102 
    let v107 : string = v29 + v106 
    method17(v107)
and ok_c69 () (v0 : std_string_String) : US32 =
    US32_Ok(v0)
and method109 () : (std_string_String -> US32) =
    ok_c69()
and error_c70 () (v0 : std_string_String) : US32 =
    US32_Error(v0)
and method110 () : (std_string_String -> US32) =
    error_c70()
and method111 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : bool, v9 : std_string_String) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_14(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "runtime.stdio_line"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "trace'"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : string = format_real_60(v8)
    let v28 : string = v26 + v27 
    let v29 : string = "; "
    let v30 : string = v28 + v29 
    let v31 : string = "e"
    let v32 : string = v30 + v31 
    let v33 : string = v32 + v25 
    let v34 : string = $"%A{v9}"
    let v35 : string = v33 + v34 
    let v36 : string = "{ "
    let v37 : string = v36 + v35 
    let v38 : string = " }"
    let v39 : string = v37 + v38 
    let v40 : string = v20 + v39 
    method17(v40)
and method112 () : string =
    let v0 : string = "\u001b[90m"
    
    
    
    
    
    let v1 : string = "Verbose"
    let v2 : (unit -> string) = v1.ToLower
    let v3 : string = v2 ()
    let v4 : char = (spiralStringIndex v3 (int 0))
    let v5 : string = format_real_10(v4)
    let v6 : string = v0 + v5 
    let v7 : string = "\u001b[0m"
    let v8 : string = v6 + v7 
    v8
and format_real_114 () : string =
    let v0 : string = method11()
    let v1 : Mut3 = {l0 = v0} : Mut3
    let v2 : string = v1.l0
    v2
and method113 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : int64 = v0.l0
    let v10 : string = " "
    let v11 : string = v6 + v10 
    let v12 : string = format_real_14(v9)
    let v13 : string = v11 + v12 
    let v14 : string = v13 + v7 
    let v15 : string = v14 + v10 
    let v16 : string = v15 + v8 
    let v17 : string = " / "
    let v18 : string = v16 + v17 
    let v19 : string = format_real_114()
    let v20 : string = v18 + v19 
    method17(v20)
and method115 (v0 : Result<unit, string>) : Result<unit, string> =
    v0
and closure71 () (v0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)) : US33 =
    US33_Some(v0)
and method116 () : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US33) =
    closure71()
and closure72 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : US34 =
    US34_Some(v0)
and method117 () : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US34) =
    closure72()
and method118 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and ok_c73 () (v0 : std_process_Output) : US35 =
    US35_Ok(v0)
and method119 () : (std_process_Output -> US35) =
    ok_c73()
and error_c74 () (v0 : std_string_String) : US35 =
    US35_Error(v0)
and method120 () : (std_string_String -> US35) =
    error_c74()
and method121 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String, v9 : string, v10 : string, v11 : string, v12 : System.Threading.CancellationToken option, v13 : (struct (string * string) []), v14 : (struct (int32 * string * bool) -> Async<unit>) option, v15 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v16 : bool, v17 : string option, v18 : bool) : string =
    let v19 : int64 = v0.l0
    let v20 : string = " "
    let v21 : string = v6 + v20 
    let v22 : string = format_real_14(v19)
    let v23 : string = v21 + v22 
    let v24 : string = v23 + v7 
    let v25 : string = v24 + v20 
    let v26 : string = "runtime.execute_with_options / output error"
    let v27 : string = v25 + v26 
    let v28 : string = " / "
    let v29 : string = v27 + v28 
    let v30 : string = ""
    let v31 : string = v30 + v30 
    let v32 : string = "error"
    let v33 : string = v31 + v32 
    let v34 : string = " = "
    let v35 : string = v33 + v34 
    let v36 : string = $"%A{v8}"
    let v37 : string = v35 + v36 
    let v38 : string = "; "
    let v39 : string = v37 + v38 
    let v40 : string = "file_name"
    let v41 : string = v39 + v40 
    let v42 : string = v41 + v34 
    let v43 : string = v42 + v9 
    let v44 : string = v43 + v38 
    let v45 : string = "arguments"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v34 
    let v48 : string = v47 + v10 
    let v49 : string = v48 + v38 
    let v50 : string = "options"
    let v51 : string = v49 + v50 
    let v52 : string = v51 + v34 
    let v53 : string = v30 + v30 
    let v54 : string = "command"
    let v55 : string = v53 + v54 
    let v56 : string = v55 + v34 
    let v57 : string = v56 + v11 
    let v58 : string = v57 + v38 
    let v59 : string = "cancellation_token"
    let v60 : string = v58 + v59 
    let v61 : string = v60 + v34 
    let v62 : string = $"%A{v12}"
    let v63 : string = v61 + v62 
    let v64 : string = v63 + v38 
    let v65 : string = "environment_variables"
    let v66 : string = v64 + v65 
    let v67 : string = v66 + v34 
    let v68 : string = method105(v13)
    let v69 : string = v67 + v68 
    let v70 : string = v69 + v38 
    let v71 : string = "on_line"
    let v72 : string = v70 + v71 
    let v73 : string = v72 + v34 
    let v74 : string = $"%A{v14}"
    let v75 : string = v73 + v74 
    let v76 : string = v75 + v38 
    let v77 : string = "stdin"
    let v78 : string = v76 + v77 
    let v79 : string = v78 + v34 
    let v80 : string = $"%A{v15}"
    let v81 : string = v79 + v80 
    let v82 : string = v81 + v38 
    let v83 : string = "trace"
    let v84 : string = v82 + v83 
    let v85 : string = v84 + v34 
    let v86 : string = format_real_60(v16)
    let v87 : string = v85 + v86 
    let v88 : string = v87 + v38 
    let v89 : string = "working_directory"
    let v90 : string = v88 + v89 
    let v91 : string = v90 + v34 
    let v92 : string = $"%A{v17}"
    let v93 : string = v91 + v92 
    let v94 : string = v93 + v38 
    let v95 : string = "stderr"
    let v96 : string = v94 + v95 
    let v97 : string = v96 + v34 
    let v98 : string = format_real_60(v18)
    let v99 : string = v97 + v98 
    let v100 : string = "{ "
    let v101 : string = v100 + v99 
    let v102 : string = " }"
    let v103 : string = v101 + v102 
    let v104 : string = v52 + v103 
    let v105 : string = v100 + v104 
    let v106 : string = v105 + v102 
    let v107 : string = v29 + v106 
    method17(v107)
and closure75 () (v0 : int32) : US36 =
    US36_Some(v0)
and method122 () : (int32 -> US36) =
    closure75()
and method123 (v0 : Vec<uint8>) : Vec<uint8> =
    v0
and method124 (v0 : string, v1 : int32) : int32 =
    let v2 : bool = v1 <= 0
    if v2 then
        -1
    else
        let v3 : int32 = v1 - 1
        let v4 : char = (spiralStringIndex v0 (int v3))
        let v5 : bool = v4 = ' '
        let v11 : bool =
            if v5 then
                true
            else
                let v6 : bool = v4 = '\t'
                if v6 then
                    true
                else
                    let v7 : bool = v4 = '\r'
                    if v7 then
                        true
                    else
                        let v8 : bool = v4 = '\n'
                        v8
        if v11 then
            method124(v0, v3)
        else
            v3
and method125 (v0 : UH0, v1 : string) : struct (string * string) =
    let struct (v11 : string, v12 : string) =
        match v0 with
        | UH0_Cons(v2, v3) -> (* Cons *)
            let struct (v4 : string, v5 : string) = method125(v3, v1)
            let v6 : string = v2 + v5 
            let v7 : string = v6 + v4 
            let v8 : string = "\n"
            struct (v7, v8)
        | _ ->
            let struct (v9 : string, v10 : string) =
                match v0 with
                | UH0_Nil -> (* Nil *)
                    struct (v1, v1)
            struct (v9, v10)
    struct (v11, v12)
and closure76 () (v0 : (std_string_String)) : string =
    let v1 : std_string_String = (v0)
    let v2 : string = "Fsharp"
    let v3 : string = () // backend.backend_switch / record_type_try_find / key: v2 
    v3
and method126 () : string =
    let v0 : string = "\n"
    v0
and method127 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : int32, v10 : int32) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_14(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "runtime.execute_with_options / result"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "file_name"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : string = v27 + v8 
    let v29 : string = "; "
    let v30 : string = v28 + v29 
    let v31 : string = "exit_code"
    let v32 : string = v30 + v31 
    let v33 : string = v32 + v26 
    let v34 : string = format_real_79(v9)
    let v35 : string = v33 + v34 
    let v36 : string = v35 + v29 
    let v37 : string = "std_trace_len"
    let v38 : string = v36 + v37 
    let v39 : string = v38 + v26 
    let v40 : string = format_real_79(v10)
    let v41 : string = v39 + v40 
    let v42 : string = "{ "
    let v43 : string = v42 + v41 
    let v44 : string = " }"
    let v45 : string = v43 + v44 
    let v46 : string = v21 + v45 
    method17(v46)
and execute_with_options_76 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : bool) : struct (int32 * string) =
    let v8 : string = method77(v0, v1, v2, v3, v4, v5, v6, v7)
    let v9 : US17 = split_command_78(v8)
    let struct (v18 : string, v19 : US3) =
        match v9 with
        | US17_Error(v12) -> (* Error *)
            let v13 : string = $"resultm.get / Error x: {v12}"
            failwith<struct (string * US3)> v13
        | US17_Ok(v10, v11) -> (* Ok *)
            struct (v10, v11)
    let v23 : string =
        match v19 with
        | US3_None -> (* None *)
            let v21 : string = ""
            v21
        | US3_Some(v20) -> (* Some *)
            v20
    let v24 : US26 = split_args_87(v23)
    let v30 : (string []) =
        match v24 with
        | US26_Error(v26) -> (* Error *)
            let v27 : string = $"resultm.get / Error x: {v26}"
            failwith<(string [])> v27
        | US26_Ok(v25) -> (* Ok *)
            v25
    let v31 : string = "Fsharp"
    let v32 : Vec<string> = () // backend.backend_switch / record_type_try_find / key: v31 
    let v33 : string = "$0.iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v34 : ((string) -> std_string_String) = closure66()
    let v35 : Vec<std_string_String> = __spiral_emit_rust struct (v32, v34) v33 
    let v36 : bool = TraceState.trace_state.IsNone
    if v36 then
        let v37 : US0 = US0_Verbose
        let struct (v38 : Mut0, v39 : Mut1, v40 : Mut2, v41 : Mut3, v42 : Mut4, v43 : int64 option) = new_trace_state_1(v37)
        let v44 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
        TraceState.trace_state <- v44 
        ()
    let struct (v45 : Mut0, v46 : Mut1, v47 : Mut2, v48 : Mut3, v49 : Mut4, v50 : int64 option) = TraceState.trace_state.Value
    let v51 : US0 = v49.l0
    let v56 : int32 =
        match v51 with
        | US0_Critical -> (* Critical *)
            50
        | US0_Debug -> (* Debug *)
            20
        | US0_Info -> (* Info *)
            30
        | US0_Verbose -> (* Verbose *)
            10
        | US0_Warning -> (* Warning *)
            40
    let v57 : bool = v47.l0
    let v58 : bool = v57 = false
    let v60 : bool =
        if v58 then
            false
        else
            let v59 : bool = 20 >= v56
            v59
    let v61 : bool = v60 = false
    let v102 : US4 =
        if v61 then
            US4_None
        else
            let v63 : bool = TraceState.trace_state.IsNone
            if v63 then
                let v64 : US0 = US0_Verbose
                let struct (v65 : Mut0, v66 : Mut1, v67 : Mut2, v68 : Mut3, v69 : Mut4, v70 : int64 option) = new_trace_state_1(v64)
                let v71 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v65, v66, v67, v68, v69, v70) 
                TraceState.trace_state <- v71 
                ()
            let struct (v72 : Mut0, v73 : Mut1, v74 : Mut2, v75 : Mut3, v76 : Mut4, v77 : int64 option) = TraceState.trace_state.Value
            let v78 : string = method6(v72, v73, v74, v75, v76, v77)
            let v79 : string = method57()
            let v80 : string = $"%A{v35}"
            let v81 : string = method104(v72, v73, v74, v75, v76, v77, v78, v79, v18, v80, v0, v1, v2, v3, v4, v5, v6, v7)
            let v82 : bool = TraceState.trace_state.IsNone
            if v82 then
                let v83 : US0 = US0_Verbose
                let struct (v84 : Mut0, v85 : Mut1, v86 : Mut2, v87 : Mut3, v88 : Mut4, v89 : int64 option) = new_trace_state_1(v83)
                let v90 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v84, v85, v86, v87, v88, v89) 
                TraceState.trace_state <- v90 
                ()
            let struct (v91 : Mut0, v92 : Mut1, v93 : Mut2, v94 : Mut3, v95 : Mut4, v96 : int64 option) = TraceState.trace_state.Value
            let v97 : int64 = v91.l0
            let v98 : int64 = v97 + 1L
            v91.l0 <- v98
            let v99 : (string -> unit) = closure5()
            v99 v81
            let v100 : (string -> unit) = v92.l0
            v100 v81
            US4_Some(v91, v92, v93, v94, v95, v96)
    let v103 : bool = true
    let mutable _capture_v103 : (int32 * string) option = None 
    (
    (fun () ->
    (fun () ->
    let v104 : string = "std::process::Command::new(&*$0)"
    let v105 : std_process_Command = __spiral_emit_rust v18 v104 
    let v106 : string = "true; let mut v105 = v105"
    let v107 : bool = __spiral_emit_rust () v106 
    let v108 : string = "true; std::process::Command::args(&mut v105, &*$0)"
    let v109 : bool = __spiral_emit_rust v35 v108 
    let v110 : string = "$0"
    let v111 : std_process_Command = __spiral_emit_rust v105 v110 
    let v112 : string = "std::process::Stdio::piped()"
    let v113 : std_process_Stdio = __spiral_emit_rust () v112 
    let v114 : string = "true; let mut v111 = v111"
    let v115 : bool = __spiral_emit_rust () v114 
    let v116 : string = "true; std::process::Command::stdout(&mut v111, std::process::Stdio::piped())"
    let v117 : bool = __spiral_emit_rust () v116 
    let v118 : string = "$0"
    let v119 : std_process_Command = __spiral_emit_rust v111 v118 
    let v120 : string = "std::process::Stdio::piped()"
    let v121 : std_process_Stdio = __spiral_emit_rust () v120 
    let v122 : string = "true; let mut v119 = v119"
    let v123 : bool = __spiral_emit_rust () v122 
    let v124 : string = "true; std::process::Command::stderr(&mut v119, std::process::Stdio::piped())"
    let v125 : bool = __spiral_emit_rust () v124 
    let v126 : string = "$0"
    let v127 : std_process_Command = __spiral_emit_rust v119 v126 
    let v128 : string = "std::process::Stdio::piped()"
    let v129 : std_process_Stdio = __spiral_emit_rust () v128 
    let v130 : string = "true; let mut v127 = v127"
    let v131 : bool = __spiral_emit_rust () v130 
    let v132 : string = "true; std::process::Command::stdin(&mut v127, std::process::Stdio::piped())"
    let v133 : bool = __spiral_emit_rust () v132 
    let v134 : string = "$0"
    let v135 : std_process_Command = __spiral_emit_rust v127 v134 
    let v136 : (string -> US3) = method4()
    let v137 : US3 option = v6 |> Option.map v136 
    let v138 : US3 = US3_None
    let v139 : US3 = v137 |> Option.defaultValue v138 
    let v152 : std_process_Command =
        match v139 with
        | US3_None -> (* None *)
            let v147 : string = $"v135"
            let v148 : std_process_Command = __spiral_emit_rust () v147 
            let v149 : string = "$0"
            let v150 : std_process_Command = __spiral_emit_rust v148 v149 
            v150
        | US3_Some(v140) -> (* Some *)
            let v141 : string = "true; let mut v135 = v135"
            let v142 : bool = __spiral_emit_rust () v141 
            let v143 : string = "true; std::process::Command::current_dir(&mut v135, &*$0)"
            let v144 : bool = __spiral_emit_rust v140 v143 
            let v145 : string = $"v135"
            let v146 : std_process_Command = __spiral_emit_rust () v145 
            v146
    let v153 : uint64 = System.Convert.ToUInt64 v2.Length
    let v154 : bool = v153 = 0UL
    let v173 : std_process_Command =
        if v154 then
            v152
        else
            let v155 : Vec<struct (string * string)> = () // backend.backend_switch / record_type_try_find / key: v31 
            let v156 : string = "true; let _vec_fold_ = $0.into_iter().fold(v152, |acc, x| { //"
            let v157 : bool = __spiral_emit_rust v155 v156 
            let v158 : string = "acc"
            let v159 : std_process_Command = __spiral_emit_rust () v158 
            let v160 : string = "x"
            let struct (v161 : string, v162 : string) = __spiral_emit_rust () v160 
            let v163 : string = "true; let mut v159 = v159"
            let v164 : bool = __spiral_emit_rust () v163 
            let v165 : string = "true; std::process::Command::env(&mut v159, &*$0, &*$1)"
            let v166 : bool = __spiral_emit_rust struct (v161, v162) v165 
            let v167 : string = "$0"
            let v168 : std_process_Command = __spiral_emit_rust v159 v167 
            let v169 : string = "true; $0 })"
            let v170 : bool = __spiral_emit_rust v168 v169 
            let v171 : string = "_vec_fold_"
            let v172 : std_process_Command = __spiral_emit_rust () v171 
            v172
    let v174 : string = "true; let mut v173 = v173"
    let v175 : bool = __spiral_emit_rust () v174 
    let v176 : string = "std::process::Command::spawn(&mut v173)"
    let v177 : Result<std_process_Child, std_io_Error> = __spiral_emit_rust () v176 
    let v178 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v179 : bool = __spiral_emit_rust v177 v178 
    let v180 : string = "x"
    let v181 : std_io_Error = __spiral_emit_rust () v180 
    let v182 : std_string_String = null |> unbox<std_string_String>
    let v183 : string = "true; $0 })"
    let v184 : bool = __spiral_emit_rust v182 v183 
    let v185 : string = "_result_map_error__"
    let v186 : Result<std_process_Child, std_string_String> = __spiral_emit_rust () v185 
    let v187 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v188 : bool = __spiral_emit_rust v186 v187 
    let v189 : string = "x"
    let v190 : std_process_Child = __spiral_emit_rust () v189 
    let v191 : string = "$0"
    let v192 : std_process_Child = __spiral_emit_rust v190 v191 
    let v193 : std_process_Child option = Some v192 
    let v194 : string = "$0"
    let v195 : std_process_Child option = __spiral_emit_rust v193 v194 
    let v196 : string = "std::sync::Mutex::new(v195)"
    let v197 : std_sync_Mutex<std_process_Child option> = __spiral_emit_rust () v196 
    let v198 : string = "std::sync::Arc::new(v197)"
    let v199 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = __spiral_emit_rust () v198 
    let v200 : string = "true; $0 })"
    let v201 : bool = __spiral_emit_rust v199 v200 
    let v202 : string = "_result_map_"
    let v203 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_string_String> = __spiral_emit_rust () v202 
    let v204 : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US30) = method106()
    let v205 : (std_string_String -> US30) = method107()
    let v206 : US30 = match v203 with Ok x -> v204 x | Error x -> v205 x
    let struct (v1056 : int32, v1057 : US5, v1058 : US31) =
        match v206 with
        | US30_Error(v983) -> (* Error *)
            let v984 : bool = TraceState.trace_state.IsNone
            if v984 then
                let v985 : US0 = US0_Verbose
                let struct (v986 : Mut0, v987 : Mut1, v988 : Mut2, v989 : Mut3, v990 : Mut4, v991 : int64 option) = new_trace_state_1(v985)
                let v992 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v986, v987, v988, v989, v990, v991) 
                TraceState.trace_state <- v992 
                ()
            let struct (v993 : Mut0, v994 : Mut1, v995 : Mut2, v996 : Mut3, v997 : Mut4, v998 : int64 option) = TraceState.trace_state.Value
            let v999 : US0 = v997.l0
            let v1004 : int32 =
                match v999 with
                | US0_Critical -> (* Critical *)
                    50
                | US0_Debug -> (* Debug *)
                    20
                | US0_Info -> (* Info *)
                    30
                | US0_Verbose -> (* Verbose *)
                    10
                | US0_Warning -> (* Warning *)
                    40
            let v1005 : bool = v995.l0
            let v1006 : bool = v1005 = false
            let v1008 : bool =
                if v1006 then
                    false
                else
                    let v1007 : bool = 50 >= v1004
                    v1007
            let v1009 : bool = v1008 = false
            let v1050 : US4 =
                if v1009 then
                    US4_None
                else
                    let v1011 : bool = TraceState.trace_state.IsNone
                    if v1011 then
                        let v1012 : US0 = US0_Verbose
                        let struct (v1013 : Mut0, v1014 : Mut1, v1015 : Mut2, v1016 : Mut3, v1017 : Mut4, v1018 : int64 option) = new_trace_state_1(v1012)
                        let v1019 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1013, v1014, v1015, v1016, v1017, v1018) 
                        TraceState.trace_state <- v1019 
                        ()
                    let struct (v1020 : Mut0, v1021 : Mut1, v1022 : Mut2, v1023 : Mut3, v1024 : Mut4, v1025 : int64 option) = TraceState.trace_state.Value
                    let v1026 : string = method6(v1020, v1021, v1022, v1023, v1024, v1025)
                    let v1027 : string = method70()
                    let v1028 : string = $"%A{v35}"
                    let v1029 : string = method108(v1020, v1021, v1022, v1023, v1024, v1025, v1026, v1027, v983, v18, v1028, v0, v1, v2, v3, v4, v5, v6, v7)
                    let v1030 : bool = TraceState.trace_state.IsNone
                    if v1030 then
                        let v1031 : US0 = US0_Verbose
                        let struct (v1032 : Mut0, v1033 : Mut1, v1034 : Mut2, v1035 : Mut3, v1036 : Mut4, v1037 : int64 option) = new_trace_state_1(v1031)
                        let v1038 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1032, v1033, v1034, v1035, v1036, v1037) 
                        TraceState.trace_state <- v1038 
                        ()
                    let struct (v1039 : Mut0, v1040 : Mut1, v1041 : Mut2, v1042 : Mut3, v1043 : Mut4, v1044 : int64 option) = TraceState.trace_state.Value
                    let v1045 : int64 = v1039.l0
                    let v1046 : int64 = v1045 + 1L
                    v1039.l0 <- v1046
                    let v1047 : (string -> unit) = closure5()
                    v1047 v1029
                    let v1048 : (string -> unit) = v1040.l0
                    v1048 v1029
                    US4_Some(v1039, v1040, v1041, v1042, v1043, v1044)
            let v1051 : US5 = US5_Some(v983)
            let v1052 : US31 = US31_None
            struct (-1, v1051, v1052)
        | US30_Ok(v207) -> (* Ok *)
            let v208 : string = "true; let _capture = (|| { //"
            let v209 : bool = __spiral_emit_rust () v208 
            let v210 : string = "$0"
            let v211 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = __spiral_emit_rust v207 v210 
            let v212 : string = "v211.lock()"
            let v213 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = __spiral_emit_rust () v212 
            let v214 : string = "$0.unwrap()"
            let v215 : std_sync_MutexGuard<std_process_Child option> = __spiral_emit_rust v213 v214 
            let v216 : string = "$0"
            let v217 : std_sync_MutexGuard<std_process_Child option> = __spiral_emit_rust v215 v216 
            let v218 : string = "true; let mut v217 = v217"
            let v219 : bool = __spiral_emit_rust () v218 
            let v220 : string = "&mut $0"
            let v221 : Ref<Mut<std_process_Child option>> = __spiral_emit_rust v217 v220 
            let v222 : string = "$0.as_mut()"
            let v223 : Ref<Mut<std_process_Child>> option = __spiral_emit_rust v221 v222 
            let v224 : string = "$0.unwrap()"
            let v225 : Ref<Mut<std_process_Child>> = __spiral_emit_rust v223 v224 
            let v226 : string = "&mut $0.stdout"
            let v227 : Ref<Mut<std_process_ChildStdout option>> = __spiral_emit_rust v225 v226 
            let v228 : string = "Option::take($0)"
            let v229 : std_process_ChildStdout option = __spiral_emit_rust v227 v228 
            let v230 : string = "$0.unwrap()"
            let v231 : std_process_ChildStdout = __spiral_emit_rust v229 v230 
            let v232 : string = "true; $0 })()"
            let v233 : bool = __spiral_emit_rust v231 v232 
            let v234 : string = "_capture"
            let v235 : std_process_ChildStdout = __spiral_emit_rust () v234 
            let v236 : string = "true; let _capture = (|| { //"
            let v237 : bool = __spiral_emit_rust () v236 
            let v238 : string = "$0"
            let v239 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = __spiral_emit_rust v207 v238 
            let v240 : string = "v239.lock()"
            let v241 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = __spiral_emit_rust () v240 
            let v242 : string = "$0.unwrap()"
            let v243 : std_sync_MutexGuard<std_process_Child option> = __spiral_emit_rust v241 v242 
            let v244 : string = "$0"
            let v245 : std_sync_MutexGuard<std_process_Child option> = __spiral_emit_rust v243 v244 
            let v246 : string = "true; let mut v245 = v245"
            let v247 : bool = __spiral_emit_rust () v246 
            let v248 : string = "&mut $0"
            let v249 : Ref<Mut<std_process_Child option>> = __spiral_emit_rust v245 v248 
            let v250 : string = "$0.as_mut()"
            let v251 : Ref<Mut<std_process_Child>> option = __spiral_emit_rust v249 v250 
            let v252 : string = "$0.unwrap()"
            let v253 : Ref<Mut<std_process_Child>> = __spiral_emit_rust v251 v252 
            let v254 : string = "&mut $0.stderr"
            let v255 : Ref<Mut<std_process_ChildStderr option>> = __spiral_emit_rust v253 v254 
            let v256 : string = "Option::take($0)"
            let v257 : std_process_ChildStderr option = __spiral_emit_rust v255 v256 
            let v258 : string = "$0.unwrap()"
            let v259 : std_process_ChildStderr = __spiral_emit_rust v257 v258 
            let v260 : string = "true; $0 })()"
            let v261 : bool = __spiral_emit_rust v259 v260 
            let v262 : string = "_capture"
            let v263 : std_process_ChildStderr = __spiral_emit_rust () v262 
            let v264 : string = "true; let _capture = (|| { //"
            let v265 : bool = __spiral_emit_rust () v264 
            let v266 : string = "$0"
            let v267 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = __spiral_emit_rust v207 v266 
            let v268 : string = "v267.lock()"
            let v269 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = __spiral_emit_rust () v268 
            let v270 : string = "$0.unwrap()"
            let v271 : std_sync_MutexGuard<std_process_Child option> = __spiral_emit_rust v269 v270 
            let v272 : string = "$0"
            let v273 : std_sync_MutexGuard<std_process_Child option> = __spiral_emit_rust v271 v272 
            let v274 : string = "true; let mut v273 = v273"
            let v275 : bool = __spiral_emit_rust () v274 
            let v276 : string = "&mut $0"
            let v277 : Ref<Mut<std_process_Child option>> = __spiral_emit_rust v273 v276 
            let v278 : string = "$0.as_mut()"
            let v279 : Ref<Mut<std_process_Child>> option = __spiral_emit_rust v277 v278 
            let v280 : string = "$0.unwrap()"
            let v281 : Ref<Mut<std_process_Child>> = __spiral_emit_rust v279 v280 
            let v282 : string = "&mut $0.stdin"
            let v283 : Ref<Mut<std_process_ChildStdin option>> = __spiral_emit_rust v281 v282 
            let v284 : string = "Option::take($0)"
            let v285 : std_process_ChildStdin option = __spiral_emit_rust v283 v284 
            let v286 : string = "$0.unwrap()"
            let v287 : std_process_ChildStdin = __spiral_emit_rust v285 v286 
            let v288 : std_process_ChildStdin option = Some v287 
            let v289 : string = "$0"
            let v290 : std_process_ChildStdin option = __spiral_emit_rust v288 v289 
            let v291 : string = "std::sync::Mutex::new(v290)"
            let v292 : std_sync_Mutex<std_process_ChildStdin option> = __spiral_emit_rust () v291 
            let v293 : string = "std::sync::Arc::new(v292)"
            let v294 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = __spiral_emit_rust () v293 
            let v295 : string = "true; $0 })()"
            let v296 : bool = __spiral_emit_rust v294 v295 
            let v297 : string = "_capture"
            let v298 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = __spiral_emit_rust () v297 
            let v299 : string = "{ let (sender, receiver) = std::sync::mpsc::channel(); (sender, std::sync::Arc::new(receiver)) }"
            let struct (v300 : std_sync_mpsc_Sender<std_string_String>, v301 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = __spiral_emit_rust () v299 
            let v302 : string = "$0"
            let v303 : std_sync_mpsc_Sender<std_string_String> = __spiral_emit_rust v300 v302 
            let v304 : string = "std::sync::Mutex::new(v303)"
            let v305 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = __spiral_emit_rust () v304 
            let v306 : string = "std::sync::Arc::new(v305)"
            let v307 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = __spiral_emit_rust () v306 
            let v308 : string = "$0"
            let v309 : std_sync_mpsc_Sender<std_string_String> = __spiral_emit_rust v300 v308 
            let v310 : string = "std::sync::Mutex::new(v309)"
            let v311 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = __spiral_emit_rust () v310 
            let v312 : string = "std::sync::Arc::new(v311)"
            let v313 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = __spiral_emit_rust () v312 
            let v314 : string = "$0"
            let v315 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> = __spiral_emit_rust v301 v314 
            let v316 : string = "std::sync::Mutex::new(v315)"
            let v317 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = __spiral_emit_rust () v316 
            let v318 : string = "std::sync::Arc::new(v317)"
            let v319 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = __spiral_emit_rust () v318 
            let v320 : string = "true; let __spawn = std::thread::spawn(move || { //"
            let v321 : bool = __spiral_emit_rust () v320 
            let v322 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v323 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>> = __spiral_emit_rust v235 v322 
            let v324 : string = "std::io::BufReader::new($0)"
            let v325 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>> = __spiral_emit_rust v323 v324 
            let v326 : string = "std::io::BufRead::lines(v325)"
            let v327 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>>> = __spiral_emit_rust () v326 
            let v328 : string = "true; let mut v327 = v327; let _iter_try_for_each = v327.try_for_each(|x| { //"
            let v329 : bool = __spiral_emit_rust () v328 
            let v330 : string = "x"
            let v331 : Result<std_string_String, std_io_Error> = __spiral_emit_rust () v330 
            let v332 : string = "$0.clone()"
            let v333 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = __spiral_emit_rust v307 v332 
            let v334 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
            let v335 : bool = __spiral_emit_rust v331 v334 
            let v336 : string = "x"
            let v337 : std_io_Error = __spiral_emit_rust () v336 
            let v338 : std_string_String = null |> unbox<std_string_String>
            let v339 : string = "true; $0 })"
            let v340 : bool = __spiral_emit_rust v338 v339 
            let v341 : string = "_result_map_error__"
            let v342 : Result<std_string_String, std_string_String> = __spiral_emit_rust () v341 
            let v343 : (std_string_String -> US32) = method109()
            let v344 : (std_string_String -> US32) = method110()
            let v345 : US32 = match v342 with Ok x -> v343 x | Error x -> v344 x
            let v502 : std_string_String =
                match v345 with
                | US32_Error(v431) -> (* Error *)
                    let v432 : bool = TraceState.trace_state.IsNone
                    if v432 then
                        let v433 : US0 = US0_Verbose
                        let struct (v434 : Mut0, v435 : Mut1, v436 : Mut2, v437 : Mut3, v438 : Mut4, v439 : int64 option) = new_trace_state_1(v433)
                        let v440 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v434, v435, v436, v437, v438, v439) 
                        TraceState.trace_state <- v440 
                        ()
                    let struct (v441 : Mut0, v442 : Mut1, v443 : Mut2, v444 : Mut3, v445 : Mut4, v446 : int64 option) = TraceState.trace_state.Value
                    let v447 : US0 = v445.l0
                    let v452 : int32 =
                        match v447 with
                        | US0_Critical -> (* Critical *)
                            50
                        | US0_Debug -> (* Debug *)
                            20
                        | US0_Info -> (* Info *)
                            30
                        | US0_Verbose -> (* Verbose *)
                            10
                        | US0_Warning -> (* Warning *)
                            40
                    let v453 : bool = v443.l0
                    let v454 : bool = v453 = false
                    let v456 : bool =
                        if v454 then
                            false
                        else
                            let v455 : bool = 50 >= v452
                            v455
                    let v457 : bool = v456 = false
                    let v497 : US4 =
                        if v457 then
                            US4_None
                        else
                            let v459 : bool = TraceState.trace_state.IsNone
                            if v459 then
                                let v460 : US0 = US0_Verbose
                                let struct (v461 : Mut0, v462 : Mut1, v463 : Mut2, v464 : Mut3, v465 : Mut4, v466 : int64 option) = new_trace_state_1(v460)
                                let v467 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v461, v462, v463, v464, v465, v466) 
                                TraceState.trace_state <- v467 
                                ()
                            let struct (v468 : Mut0, v469 : Mut1, v470 : Mut2, v471 : Mut3, v472 : Mut4, v473 : int64 option) = TraceState.trace_state.Value
                            let v474 : string = method6(v468, v469, v470, v471, v472, v473)
                            let v475 : string = method70()
                            let v476 : string = method111(v468, v469, v470, v471, v472, v473, v474, v475, v5, v431)
                            let v477 : bool = TraceState.trace_state.IsNone
                            if v477 then
                                let v478 : US0 = US0_Verbose
                                let struct (v479 : Mut0, v480 : Mut1, v481 : Mut2, v482 : Mut3, v483 : Mut4, v484 : int64 option) = new_trace_state_1(v478)
                                let v485 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v479, v480, v481, v482, v483, v484) 
                                TraceState.trace_state <- v485 
                                ()
                            let struct (v486 : Mut0, v487 : Mut1, v488 : Mut2, v489 : Mut3, v490 : Mut4, v491 : int64 option) = TraceState.trace_state.Value
                            let v492 : int64 = v486.l0
                            let v493 : int64 = v492 + 1L
                            v486.l0 <- v493
                            let v494 : (string -> unit) = closure5()
                            v494 v476
                            let v495 : (string -> unit) = v487.l0
                            v495 v476
                            US4_Some(v486, v487, v488, v489, v490, v491)
                    let v498 : string = $"\u001b[4;7m{v431}\u001b[0m"
                    let v499 : Ref<Str> = v498 |> unbox<Ref<Str>>
                    let v500 : std_string_String = v499 |> unbox<std_string_String>
                    v500
                | US32_Ok(v346) -> (* Ok *)
                    let v347 : string = () // backend.backend_switch / record_type_try_find / key: v31 
                    let v348 : string = "encoding_rs::UTF_8"
                    let v349 : Ref<encoding_rs_Encoding> = __spiral_emit_rust () v348 
                    let v350 : string = "$0.encode(&*$1).0"
                    let v351 : std_borrow_Cow<Slice<uint8>> = __spiral_emit_rust struct (v349, v347) v350 
                    let v352 : string = "$0.as_ref()"
                    let v353 : Ref<Slice<uint8>> = __spiral_emit_rust v351 v352 
                    let v354 : string = "std::str::from_utf8($0)"
                    let v355 : Result<Ref<Str>, std_str_Utf8Error> = __spiral_emit_rust v353 v354 
                    let v356 : string = "$0.unwrap()"
                    let v357 : Ref<Str> = __spiral_emit_rust v355 v356 
                    let v358 : std_string_String = v357 |> unbox<std_string_String>
                    let v359 : string = () // backend.backend_switch / record_type_try_find / key: v31 
                    let v360 : string = $"> {v359}"
                    if v5 then
                        let v361 : bool = TraceState.trace_state.IsNone
                        if v361 then
                            let v362 : US0 = US0_Verbose
                            let struct (v363 : Mut0, v364 : Mut1, v365 : Mut2, v366 : Mut3, v367 : Mut4, v368 : int64 option) = new_trace_state_1(v362)
                            let v369 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v363, v364, v365, v366, v367, v368) 
                            TraceState.trace_state <- v369 
                            ()
                        let struct (v370 : Mut0, v371 : Mut1, v372 : Mut2, v373 : Mut3, v374 : Mut4, v375 : int64 option) = TraceState.trace_state.Value
                        let v376 : US0 = v374.l0
                        let v381 : int32 =
                            match v376 with
                            | US0_Critical -> (* Critical *)
                                50
                            | US0_Debug -> (* Debug *)
                                20
                            | US0_Info -> (* Info *)
                                30
                            | US0_Verbose -> (* Verbose *)
                                10
                            | US0_Warning -> (* Warning *)
                                40
                        let v382 : bool = v372.l0
                        let v383 : bool = v382 = false
                        let v385 : bool =
                            if v383 then
                                false
                            else
                                let v384 : bool = 10 >= v381
                                v384
                        let v386 : bool = v385 = false
                        let v429 : US4 =
                            if v386 then
                                US4_None
                            else
                                let v388 : bool = TraceState.trace_state.IsNone
                                if v388 then
                                    let v389 : US0 = US0_Verbose
                                    let struct (v390 : Mut0, v391 : Mut1, v392 : Mut2, v393 : Mut3, v394 : Mut4, v395 : int64 option) = new_trace_state_1(v389)
                                    let v396 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v390, v391, v392, v393, v394, v395) 
                                    TraceState.trace_state <- v396 
                                    ()
                                let struct (v397 : Mut0, v398 : Mut1, v399 : Mut2, v400 : Mut3, v401 : Mut4, v402 : int64 option) = TraceState.trace_state.Value
                                let v403 : string = method6(v397, v398, v399, v400, v401, v402)
                                let v404 : string = method112()
                                let v405 : bool = v360 = ""
                                let v408 : string =
                                    if v405 then
                                        let v406 : string = ""
                                        v406
                                    else
                                        method113(v397, v398, v399, v400, v401, v402, v403, v404, v360)
                                let v409 : bool = TraceState.trace_state.IsNone
                                if v409 then
                                    let v410 : US0 = US0_Verbose
                                    let struct (v411 : Mut0, v412 : Mut1, v413 : Mut2, v414 : Mut3, v415 : Mut4, v416 : int64 option) = new_trace_state_1(v410)
                                    let v417 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v411, v412, v413, v414, v415, v416) 
                                    TraceState.trace_state <- v417 
                                    ()
                                let struct (v418 : Mut0, v419 : Mut1, v420 : Mut2, v421 : Mut3, v422 : Mut4, v423 : int64 option) = TraceState.trace_state.Value
                                let v424 : int64 = v418.l0
                                let v425 : int64 = v424 + 1L
                                v418.l0 <- v425
                                let v426 : (string -> unit) = closure5()
                                v426 v408
                                let v427 : (string -> unit) = v419.l0
                                v427 v408
                                US4_Some(v418, v419, v420, v421, v422, v423)
                        ()
                    else
                        let v430 : (string -> unit) = System.Console.WriteLine
                        v430 v360
                    v358
            let v503 : string = "$0"
            let v504 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = __spiral_emit_rust v333 v503 
            let v505 : string = "v504.lock()"
            let v506 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = __spiral_emit_rust () v505 
            let v507 : string = "$0.unwrap()"
            let v508 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = __spiral_emit_rust v506 v507 
            let v509 : string = "&$0"
            let v510 : Ref<std_sync_mpsc_Sender<std_string_String>> = __spiral_emit_rust v508 v509 
            let v511 : string = "$0.send($1)"
            let v512 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = __spiral_emit_rust struct (v510, v502) v511 
            let v513 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
            let v514 : bool = __spiral_emit_rust v512 v513 
            let v515 : string = "x"
            let v516 : std_sync_mpsc_SendError<std_string_String> = __spiral_emit_rust () v515 
            let v517 : std_string_String = null |> unbox<std_string_String>
            let v518 : string = "true; $0 })"
            let v519 : bool = __spiral_emit_rust v517 v518 
            let v520 : string = "_result_map_error__"
            let v521 : Result<unit, std_string_String> = __spiral_emit_rust () v520 
            let v522 : string = "$0"
            let v523 : core_ops_Try<unit> = __spiral_emit_rust v521 v522 
            let v524 : string = "true; $0 }); //"
            let v525 : bool = __spiral_emit_rust v523 v524 
            let v526 : string = "_iter_try_for_each.map_err(|x| x.into())"
            let v527 : Result<unit, string> = __spiral_emit_rust () v526 
            let v528 : Result<unit, string> = method115(v527)
            () // backend.backend_switch / record_type_try_find / key: v31 
            let v529 : string = "__spawn"
            let v530 : std_thread_JoinHandle<Result<unit, string>> = __spiral_emit_rust () v529 
            let v531 : string = "true; let __spawn = std::thread::spawn(move || { //"
            let v532 : bool = __spiral_emit_rust () v531 
            let v533 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v534 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>> = __spiral_emit_rust v263 v533 
            let v535 : string = "std::io::BufReader::new($0)"
            let v536 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>> = __spiral_emit_rust v534 v535 
            let v537 : string = "std::io::BufRead::lines(v536)"
            let v538 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>>> = __spiral_emit_rust () v537 
            let v539 : string = "true; let mut v538 = v538; let _iter_try_for_each = v538.try_for_each(|x| { //"
            let v540 : bool = __spiral_emit_rust () v539 
            let v541 : string = "x"
            let v542 : Result<std_string_String, std_io_Error> = __spiral_emit_rust () v541 
            let v543 : bool = v7 = false
            let v738 : Result<unit, std_string_String> =
                if v543 then
                    let v544 : Result<unit, std_string_String> = Ok () 
                    v544
                else
                    let v545 : string = "$0.clone()"
                    let v546 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = __spiral_emit_rust v313 v545 
                    let v547 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
                    let v548 : bool = __spiral_emit_rust v542 v547 
                    let v549 : string = "x"
                    let v550 : std_io_Error = __spiral_emit_rust () v549 
                    let v551 : std_string_String = null |> unbox<std_string_String>
                    let v552 : string = "true; $0 })"
                    let v553 : bool = __spiral_emit_rust v551 v552 
                    let v554 : string = "_result_map_error__"
                    let v555 : Result<std_string_String, std_string_String> = __spiral_emit_rust () v554 
                    let v556 : (std_string_String -> US32) = method109()
                    let v557 : (std_string_String -> US32) = method110()
                    let v558 : US32 = match v555 with Ok x -> v556 x | Error x -> v557 x
                    let v718 : std_string_String =
                        match v558 with
                        | US32_Error(v647) -> (* Error *)
                            let v648 : bool = TraceState.trace_state.IsNone
                            if v648 then
                                let v649 : US0 = US0_Verbose
                                let struct (v650 : Mut0, v651 : Mut1, v652 : Mut2, v653 : Mut3, v654 : Mut4, v655 : int64 option) = new_trace_state_1(v649)
                                let v656 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v650, v651, v652, v653, v654, v655) 
                                TraceState.trace_state <- v656 
                                ()
                            let struct (v657 : Mut0, v658 : Mut1, v659 : Mut2, v660 : Mut3, v661 : Mut4, v662 : int64 option) = TraceState.trace_state.Value
                            let v663 : US0 = v661.l0
                            let v668 : int32 =
                                match v663 with
                                | US0_Critical -> (* Critical *)
                                    50
                                | US0_Debug -> (* Debug *)
                                    20
                                | US0_Info -> (* Info *)
                                    30
                                | US0_Verbose -> (* Verbose *)
                                    10
                                | US0_Warning -> (* Warning *)
                                    40
                            let v669 : bool = v659.l0
                            let v670 : bool = v669 = false
                            let v672 : bool =
                                if v670 then
                                    false
                                else
                                    let v671 : bool = 50 >= v668
                                    v671
                            let v673 : bool = v672 = false
                            let v713 : US4 =
                                if v673 then
                                    US4_None
                                else
                                    let v675 : bool = TraceState.trace_state.IsNone
                                    if v675 then
                                        let v676 : US0 = US0_Verbose
                                        let struct (v677 : Mut0, v678 : Mut1, v679 : Mut2, v680 : Mut3, v681 : Mut4, v682 : int64 option) = new_trace_state_1(v676)
                                        let v683 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v677, v678, v679, v680, v681, v682) 
                                        TraceState.trace_state <- v683 
                                        ()
                                    let struct (v684 : Mut0, v685 : Mut1, v686 : Mut2, v687 : Mut3, v688 : Mut4, v689 : int64 option) = TraceState.trace_state.Value
                                    let v690 : string = method6(v684, v685, v686, v687, v688, v689)
                                    let v691 : string = method70()
                                    let v692 : string = method111(v684, v685, v686, v687, v688, v689, v690, v691, v5, v647)
                                    let v693 : bool = TraceState.trace_state.IsNone
                                    if v693 then
                                        let v694 : US0 = US0_Verbose
                                        let struct (v695 : Mut0, v696 : Mut1, v697 : Mut2, v698 : Mut3, v699 : Mut4, v700 : int64 option) = new_trace_state_1(v694)
                                        let v701 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v695, v696, v697, v698, v699, v700) 
                                        TraceState.trace_state <- v701 
                                        ()
                                    let struct (v702 : Mut0, v703 : Mut1, v704 : Mut2, v705 : Mut3, v706 : Mut4, v707 : int64 option) = TraceState.trace_state.Value
                                    let v708 : int64 = v702.l0
                                    let v709 : int64 = v708 + 1L
                                    v702.l0 <- v709
                                    let v710 : (string -> unit) = closure5()
                                    v710 v692
                                    let v711 : (string -> unit) = v703.l0
                                    v711 v692
                                    US4_Some(v702, v703, v704, v705, v706, v707)
                            let v714 : string = $"\u001b[4;7m{v647}\u001b[0m"
                            let v715 : Ref<Str> = v714 |> unbox<Ref<Str>>
                            let v716 : std_string_String = v715 |> unbox<std_string_String>
                            v716
                        | US32_Ok(v559) -> (* Ok *)
                            let v560 : string = () // backend.backend_switch / record_type_try_find / key: v31 
                            let v561 : string = "encoding_rs::UTF_8"
                            let v562 : Ref<encoding_rs_Encoding> = __spiral_emit_rust () v561 
                            let v563 : string = "$0.encode(&*$1).0"
                            let v564 : std_borrow_Cow<Slice<uint8>> = __spiral_emit_rust struct (v562, v560) v563 
                            let v565 : string = "$0.as_ref()"
                            let v566 : Ref<Slice<uint8>> = __spiral_emit_rust v564 v565 
                            let v567 : string = "std::str::from_utf8($0)"
                            let v568 : Result<Ref<Str>, std_str_Utf8Error> = __spiral_emit_rust v566 v567 
                            let v569 : string = "$0.unwrap()"
                            let v570 : Ref<Str> = __spiral_emit_rust v568 v569 
                            let v571 : std_string_String = v570 |> unbox<std_string_String>
                            let v572 : string = () // backend.backend_switch / record_type_try_find / key: v31 
                            let v573 : string = $"! {v572}"
                            if v5 then
                                let v574 : bool = TraceState.trace_state.IsNone
                                if v574 then
                                    let v575 : US0 = US0_Verbose
                                    let struct (v576 : Mut0, v577 : Mut1, v578 : Mut2, v579 : Mut3, v580 : Mut4, v581 : int64 option) = new_trace_state_1(v575)
                                    let v582 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v576, v577, v578, v579, v580, v581) 
                                    TraceState.trace_state <- v582 
                                    ()
                                let struct (v583 : Mut0, v584 : Mut1, v585 : Mut2, v586 : Mut3, v587 : Mut4, v588 : int64 option) = TraceState.trace_state.Value
                                let v589 : US0 = v587.l0
                                let v594 : int32 =
                                    match v589 with
                                    | US0_Critical -> (* Critical *)
                                        50
                                    | US0_Debug -> (* Debug *)
                                        20
                                    | US0_Info -> (* Info *)
                                        30
                                    | US0_Verbose -> (* Verbose *)
                                        10
                                    | US0_Warning -> (* Warning *)
                                        40
                                let v595 : bool = v585.l0
                                let v596 : bool = v595 = false
                                let v598 : bool =
                                    if v596 then
                                        false
                                    else
                                        let v597 : bool = 10 >= v594
                                        v597
                                let v599 : bool = v598 = false
                                let v642 : US4 =
                                    if v599 then
                                        US4_None
                                    else
                                        let v601 : bool = TraceState.trace_state.IsNone
                                        if v601 then
                                            let v602 : US0 = US0_Verbose
                                            let struct (v603 : Mut0, v604 : Mut1, v605 : Mut2, v606 : Mut3, v607 : Mut4, v608 : int64 option) = new_trace_state_1(v602)
                                            let v609 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v603, v604, v605, v606, v607, v608) 
                                            TraceState.trace_state <- v609 
                                            ()
                                        let struct (v610 : Mut0, v611 : Mut1, v612 : Mut2, v613 : Mut3, v614 : Mut4, v615 : int64 option) = TraceState.trace_state.Value
                                        let v616 : string = method6(v610, v611, v612, v613, v614, v615)
                                        let v617 : string = method112()
                                        let v618 : bool = v573 = ""
                                        let v621 : string =
                                            if v618 then
                                                let v619 : string = ""
                                                v619
                                            else
                                                method113(v610, v611, v612, v613, v614, v615, v616, v617, v573)
                                        let v622 : bool = TraceState.trace_state.IsNone
                                        if v622 then
                                            let v623 : US0 = US0_Verbose
                                            let struct (v624 : Mut0, v625 : Mut1, v626 : Mut2, v627 : Mut3, v628 : Mut4, v629 : int64 option) = new_trace_state_1(v623)
                                            let v630 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v624, v625, v626, v627, v628, v629) 
                                            TraceState.trace_state <- v630 
                                            ()
                                        let struct (v631 : Mut0, v632 : Mut1, v633 : Mut2, v634 : Mut3, v635 : Mut4, v636 : int64 option) = TraceState.trace_state.Value
                                        let v637 : int64 = v631.l0
                                        let v638 : int64 = v637 + 1L
                                        v631.l0 <- v638
                                        let v639 : (string -> unit) = closure5()
                                        v639 v621
                                        let v640 : (string -> unit) = v632.l0
                                        v640 v621
                                        US4_Some(v631, v632, v633, v634, v635, v636)
                                ()
                            else
                                let v643 : (string -> unit) = System.Console.WriteLine
                                v643 v573
                            let v644 : string = $"\u001b[4;7m{v571}\u001b[0m"
                            let v645 : Ref<Str> = v644 |> unbox<Ref<Str>>
                            let v646 : std_string_String = v645 |> unbox<std_string_String>
                            v646
                    let v719 : string = "$0"
                    let v720 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = __spiral_emit_rust v546 v719 
                    let v721 : string = "v720.lock()"
                    let v722 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = __spiral_emit_rust () v721 
                    let v723 : string = "$0.unwrap()"
                    let v724 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = __spiral_emit_rust v722 v723 
                    let v725 : string = "&$0"
                    let v726 : Ref<std_sync_mpsc_Sender<std_string_String>> = __spiral_emit_rust v724 v725 
                    let v727 : string = "$0.send($1)"
                    let v728 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = __spiral_emit_rust struct (v726, v718) v727 
                    let v729 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
                    let v730 : bool = __spiral_emit_rust v728 v729 
                    let v731 : string = "x"
                    let v732 : std_sync_mpsc_SendError<std_string_String> = __spiral_emit_rust () v731 
                    let v733 : std_string_String = null |> unbox<std_string_String>
                    let v734 : string = "true; $0 })"
                    let v735 : bool = __spiral_emit_rust v733 v734 
                    let v736 : string = "_result_map_error__"
                    let v737 : Result<unit, std_string_String> = __spiral_emit_rust () v736 
                    v737
            let v739 : string = "$0"
            let v740 : core_ops_Try<unit> = __spiral_emit_rust v738 v739 
            let v741 : string = "true; $0 }); //"
            let v742 : bool = __spiral_emit_rust v740 v741 
            let v743 : string = "_iter_try_for_each.map_err(|x| x.into())"
            let v744 : Result<unit, string> = __spiral_emit_rust () v743 
            let v745 : Result<unit, string> = method115(v744)
            () // backend.backend_switch / record_type_try_find / key: v31 
            let v746 : string = "__spawn"
            let v747 : std_thread_JoinHandle<Result<unit, string>> = __spiral_emit_rust () v746 
            let v748 : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US33) = method116()
            let v749 : US33 option = v4 |> Option.map v748 
            let v750 : US33 = US33_None
            let v751 : US33 = v749 |> Option.defaultValue v750 
            match v751 with
            | US33_None -> (* None *)
                ()
            | US33_Some(v752) -> (* Some *)
                let v753 : string = "$0"
                let v754 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = __spiral_emit_rust v298 v753 
                let v755 : string = "v754.lock()"
                let v756 : Result<std_sync_MutexGuard<std_process_ChildStdin option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin option>>> = __spiral_emit_rust () v755 
                let v757 : string = "$0.unwrap()"
                let v758 : std_sync_MutexGuard<std_process_ChildStdin option> = __spiral_emit_rust v756 v757 
                let v759 : string = "$0"
                let v760 : std_sync_MutexGuard<std_process_ChildStdin option> = __spiral_emit_rust v758 v759 
                let v761 : string = "true; let mut v760 = v760"
                let v762 : bool = __spiral_emit_rust () v761 
                let v763 : string = "&mut $0"
                let v764 : Ref<Mut<std_process_ChildStdin option>> = __spiral_emit_rust v760 v763 
                let v765 : string = "Option::take($0)"
                let v766 : std_process_ChildStdin option = __spiral_emit_rust v764 v765 
                let v767 : string = "true; let _optionm_map_ = $0.map(|x| { //"
                let v768 : bool = __spiral_emit_rust v766 v767 
                let v769 : string = "x"
                let v770 : std_process_ChildStdin = __spiral_emit_rust () v769 
                let v771 : string = "std::sync::Mutex::new(v770)"
                let v772 : std_sync_Mutex<std_process_ChildStdin> = __spiral_emit_rust () v771 
                let v773 : string = "std::sync::Arc::new(v772)"
                let v774 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = __spiral_emit_rust () v773 
                let v775 : string = "true; $0 })"
                let v776 : bool = __spiral_emit_rust v774 v775 
                let v777 : string = "_optionm_map_"
                let v778 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> option = __spiral_emit_rust () v777 
                let v779 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US34) = method117()
                let v780 : US34 option = v778 |> Option.map v779 
                let v781 : US34 = US34_None
                let v782 : US34 = v780 |> Option.defaultValue v781 
                match v782 with
                | US34_None -> (* None *)
                    ()
                | US34_Some(v783) -> (* Some *)
                    v752 v783
                    let v784 : string = "$0.lock()"
                    let v785 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = __spiral_emit_rust v783 v784 
                    let v786 : string = "$0.unwrap()"
                    let v787 : std_sync_MutexGuard<std_process_ChildStdin> = __spiral_emit_rust v785 v786 
                    let v788 : std_sync_MutexGuard<std_process_ChildStdin> = method118(v787)
                    let v789 : string = "true; let mut v788 = v788"
                    let v790 : bool = __spiral_emit_rust () v789 
                    let v791 : string = "true; std::io::Write::flush(&mut *$0).unwrap()"
                    let v792 : bool = __spiral_emit_rust v788 v791 
                    ()
            let v793 : string = "$0.lock()"
            let v794 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = __spiral_emit_rust v207 v793 
            let v795 : string = "$0.unwrap()"
            let v796 : std_sync_MutexGuard<std_process_Child option> = __spiral_emit_rust v794 v795 
            let v797 : string = "$0"
            let v798 : std_sync_MutexGuard<std_process_Child option> = __spiral_emit_rust v796 v797 
            let v799 : string = "true; let mut v798 = v798"
            let v800 : bool = __spiral_emit_rust () v799 
            let v801 : string = "&mut $0"
            let v802 : Ref<Mut<std_process_Child option>> = __spiral_emit_rust v798 v801 
            let v803 : string = "Option::take($0)"
            let v804 : std_process_Child option = __spiral_emit_rust v802 v803 
            let v805 : string = "$0.unwrap()"
            let v806 : std_process_Child = __spiral_emit_rust v804 v805 
            let v807 : string = "$0.wait_with_output()"
            let v808 : Result<std_process_Output, std_io_Error> = __spiral_emit_rust v806 v807 
            let v809 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
            let v810 : bool = __spiral_emit_rust v808 v809 
            let v811 : string = "x"
            let v812 : std_io_Error = __spiral_emit_rust () v811 
            let v813 : std_string_String = null |> unbox<std_string_String>
            let v814 : string = "true; $0 })"
            let v815 : bool = __spiral_emit_rust v813 v814 
            let v816 : string = "_result_map_error__"
            let v817 : Result<std_process_Output, std_string_String> = __spiral_emit_rust () v816 
            let v818 : Vec<std_thread_JoinHandle<Result<unit, string>>> = () // backend.backend_switch / record_type_try_find / key: v31 
            let v819 : string = "true; $0.into_iter().for_each(|x| { //"
            let v820 : bool = __spiral_emit_rust v818 v819 
            let v821 : string = "x"
            let v822 : std_thread_JoinHandle<Result<unit, string>> = __spiral_emit_rust () v821 
            let v823 : string = "std::thread::JoinHandle::join($0)"
            let v824 : Result<Result<unit, string>, Box<LifetimeRef<Dyn<LifetimeJoin<core_any_Any, LifetimeRef<StaticLifetime>>>>>> = __spiral_emit_rust v822 v823 
            let v825 : string = "$0.unwrap()"
            let v826 : Result<unit, string> = __spiral_emit_rust v824 v825 
            let v827 : string = "$0.unwrap()"
            __spiral_emit_rust v826 v827 
            let v828 : string = $"true"
            let v829 : bool = __spiral_emit_rust () v828 
            let v830 : string = "true; }}); //"
            let v831 : bool = __spiral_emit_rust () v830 
            let v832 : (std_process_Output -> US35) = method119()
            let v833 : (std_string_String -> US35) = method120()
            let v834 : US35 = match v817 with Ok x -> v832 x | Error x -> v833 x
            match v834 with
            | US35_Error(v907) -> (* Error *)
                let v908 : bool = TraceState.trace_state.IsNone
                if v908 then
                    let v909 : US0 = US0_Verbose
                    let struct (v910 : Mut0, v911 : Mut1, v912 : Mut2, v913 : Mut3, v914 : Mut4, v915 : int64 option) = new_trace_state_1(v909)
                    let v916 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v910, v911, v912, v913, v914, v915) 
                    TraceState.trace_state <- v916 
                    ()
                let struct (v917 : Mut0, v918 : Mut1, v919 : Mut2, v920 : Mut3, v921 : Mut4, v922 : int64 option) = TraceState.trace_state.Value
                let v923 : US0 = v921.l0
                let v928 : int32 =
                    match v923 with
                    | US0_Critical -> (* Critical *)
                        50
                    | US0_Debug -> (* Debug *)
                        20
                    | US0_Info -> (* Info *)
                        30
                    | US0_Verbose -> (* Verbose *)
                        10
                    | US0_Warning -> (* Warning *)
                        40
                let v929 : bool = v919.l0
                let v930 : bool = v929 = false
                let v932 : bool =
                    if v930 then
                        false
                    else
                        let v931 : bool = 50 >= v928
                        v931
                let v933 : bool = v932 = false
                let v974 : US4 =
                    if v933 then
                        US4_None
                    else
                        let v935 : bool = TraceState.trace_state.IsNone
                        if v935 then
                            let v936 : US0 = US0_Verbose
                            let struct (v937 : Mut0, v938 : Mut1, v939 : Mut2, v940 : Mut3, v941 : Mut4, v942 : int64 option) = new_trace_state_1(v936)
                            let v943 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v937, v938, v939, v940, v941, v942) 
                            TraceState.trace_state <- v943 
                            ()
                        let struct (v944 : Mut0, v945 : Mut1, v946 : Mut2, v947 : Mut3, v948 : Mut4, v949 : int64 option) = TraceState.trace_state.Value
                        let v950 : string = method6(v944, v945, v946, v947, v948, v949)
                        let v951 : string = method70()
                        let v952 : string = $"%A{v35}"
                        let v953 : string = method121(v944, v945, v946, v947, v948, v949, v950, v951, v907, v18, v952, v0, v1, v2, v3, v4, v5, v6, v7)
                        let v954 : bool = TraceState.trace_state.IsNone
                        if v954 then
                            let v955 : US0 = US0_Verbose
                            let struct (v956 : Mut0, v957 : Mut1, v958 : Mut2, v959 : Mut3, v960 : Mut4, v961 : int64 option) = new_trace_state_1(v955)
                            let v962 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v956, v957, v958, v959, v960, v961) 
                            TraceState.trace_state <- v962 
                            ()
                        let struct (v963 : Mut0, v964 : Mut1, v965 : Mut2, v966 : Mut3, v967 : Mut4, v968 : int64 option) = TraceState.trace_state.Value
                        let v969 : int64 = v963.l0
                        let v970 : int64 = v969 + 1L
                        v963.l0 <- v970
                        let v971 : (string -> unit) = closure5()
                        v971 v953
                        let v972 : (string -> unit) = v964.l0
                        v972 v953
                        US4_Some(v963, v964, v965, v966, v967, v968)
                let v975 : US5 = US5_Some(v907)
                let v976 : US31 = US31_None
                struct (-2, v975, v976)
            | US35_Ok(v835) -> (* Ok *)
                let v836 : string = "$0.status"
                let v837 : std_process_ExitStatus = __spiral_emit_rust v835 v836 
                let v838 : string = "$0.code()"
                let v839 : int32 option = __spiral_emit_rust v837 v838 
                let v840 : (int32 -> US36) = method122()
                let v841 : US36 option = v839 |> Option.map v840 
                let v842 : US36 = US36_None
                let v843 : US36 = v841 |> Option.defaultValue v842 
                match v843 with
                | US36_None -> (* None *)
                    let v896 : string = "runtime.execute_with_options / exit_code=None"
                    let v897 : Ref<Str> = v896 |> unbox<Ref<Str>>
                    let v898 : std_string_String = v897 |> unbox<std_string_String>
                    let v899 : US5 = US5_Some(v898)
                    let v900 : US31 = US31_Some(v319)
                    struct (-1, v899, v900)
                | US36_Some(v844) -> (* Some *)
                    let v845 : string = "$0.stdout"
                    let v846 : Vec<uint8> = __spiral_emit_rust v835 v845 
                    let v847 : Vec<uint8> = method123(v846)
                    let v848 : string = "std::string::String::from_utf8($0)"
                    let v849 : Result<std_string_String, std_string_FromUtf8Error> = __spiral_emit_rust v847 v848 
                    let v850 : string = "$0.unwrap()"
                    let v851 : std_string_String = __spiral_emit_rust v849 v850 
                    let v852 : string = "$0.stderr"
                    let v853 : Vec<uint8> = __spiral_emit_rust v835 v852 
                    let v854 : Vec<uint8> = method123(v853)
                    let v855 : string = "std::string::String::from_utf8($0)"
                    let v856 : Result<std_string_String, std_string_FromUtf8Error> = __spiral_emit_rust v854 v855 
                    let v857 : string = "$0.unwrap()"
                    let v858 : std_string_String = __spiral_emit_rust v856 v857 
                    let v859 : string = () // backend.backend_switch / record_type_try_find / key: v31 
                    let v860 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v859))
                    let v861 : int32 = 0
                    let v862 : int32 = method18(v859, v860, v861)
                    let v863 : int32 = v860 - 1
                    let v864 : string = (spiralStringSlice v859 (int v862) (int v863))
                    let v865 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v864))
                    let v866 : int32 = method124(v864, v865)
                    let v867 : string = (spiralStringSlice v864 (int 0) (int v866))
                    let v868 : string = () // backend.backend_switch / record_type_try_find / key: v31 
                    let v869 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v868))
                    let v870 : int32 = 0
                    let v871 : int32 = method18(v868, v869, v870)
                    let v872 : int32 = v869 - 1
                    let v873 : string = (spiralStringSlice v868 (int v871) (int v872))
                    let v874 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v873))
                    let v875 : int32 = method124(v873, v874)
                    let v876 : string = (spiralStringSlice v873 (int 0) (int v875))
                    let v877 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v867))
                    let v878 : bool = v877 = 0
                    let v879 : bool = v878 = false
                    let v883 : UH0 =
                        if v879 then
                            let v880 : UH0 = UH0_Nil
                            UH0_Cons(v867, v880)
                        else
                            UH0_Nil
                    let v884 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v876))
                    let v885 : bool = v884 = 0
                    let v886 : bool = v885 = false
                    let v888 : UH0 =
                        if v886 then
                            UH0_Cons(v876, v883)
                        else
                            v883
                    let v889 : string = ""
                    let struct (v890 : string, v891 : string) = method125(v888, v889)
                    let v892 : Ref<Str> = v890 |> unbox<Ref<Str>>
                    let v893 : std_string_String = v892 |> unbox<std_string_String>
                    let v894 : US5 = US5_Some(v893)
                    let v895 : US31 = US31_Some(v319)
                    struct (v844, v894, v895)
    let v1063 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option =
        match v1058 with
        | US31_None -> (* None *)
            let v1061 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = None
            v1061
        | US31_Some(v1059) -> (* Some *)
            let v1060 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = Some v1059 
            v1060
    let v1064 : string = "true; let _optionm_map_ = $0.map(|x| { //"
    let v1065 : bool = __spiral_emit_rust v1063 v1064 
    let v1066 : string = "x"
    let v1067 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = __spiral_emit_rust () v1066 
    let v1068 : string = "$0.lock()"
    let v1069 : Result<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>> = __spiral_emit_rust v1067 v1068 
    let v1070 : string = "$0.unwrap()"
    let v1071 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = __spiral_emit_rust v1069 v1070 
    let v1072 : string = "$0.iter()"
    let v1073 : _ = __spiral_emit_rust v1071 v1072 
    let v1074 : string = "$0.collect::<Vec<_>>()"
    let v1075 : Vec<std_string_String> = __spiral_emit_rust v1073 v1074 
    let v1076 : string = "$0.iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v1077 : ((std_string_String) -> string) = closure76()
    let v1078 : Vec<string> = __spiral_emit_rust struct (v1075, v1077) v1076 
    let v1079 : (string []) = () // backend.backend_switch / record_type_try_find / key: v31 
    let v1080 : string seq = v1079 |> Seq.ofArray
    let v1081 : string = method126()
    let v1082 : (string -> (string seq -> string)) = String.concat
    let v1083 : (string seq -> string) = v1082 v1081
    let v1084 : string = v1083 v1080
    let v1085 : string = "true; $0 })"
    let v1086 : bool = __spiral_emit_rust v1084 v1085 
    let v1087 : string = "_optionm_map_"
    let v1088 : string option = __spiral_emit_rust () v1087 
    let v1089 : (string -> US3) = method4()
    let v1090 : US3 option = v1088 |> Option.map v1089 
    let v1091 : US3 = US3_None
    let v1092 : US3 = v1090 |> Option.defaultValue v1091 
    let v1110 : US37 =
        match v1092 with
        | US3_None -> (* None *)
            US37_None
        | US3_Some(v1093) -> (* Some *)
            let v1094 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v1093))
            let v1095 : int32 = 0
            let v1096 : int32 = method18(v1093, v1094, v1095)
            let v1097 : int32 = v1094 - 1
            let v1098 : string = (spiralStringSlice v1093 (int v1096) (int v1097))
            let v1099 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v1098))
            let v1100 : int32 = method124(v1098, v1099)
            let v1101 : string = (spiralStringSlice v1098 (int 0) (int v1100))
            let v1102 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v1101))
            let v1103 : bool = v1102 = 0
            let v1106 : US3 =
                if v1103 then
                    US3_None
                else
                    US3_Some(v1101)
            US37_Some(v1106)
    let v1117 : US3 =
        match v1110 with
        | US37_Some(v1111) -> (* Some *)
            match v1111 with
            | US3_Some(v1112) -> (* Some *)
                US3_Some(v1112)
            | _ ->
                US3_None
        | _ ->
            US3_None
    let v1123 : US3 =
        match v1057 with
        | US5_None -> (* None *)
            US3_None
        | US5_Some(v1118) -> (* Some *)
            let v1119 : string = () // backend.backend_switch / record_type_try_find / key: v31 
            US3_Some(v1119)
    let v1127 : string =
        match v1123 with
        | US3_None -> (* None *)
            let v1125 : string = ""
            v1125
        | US3_Some(v1124) -> (* Some *)
            v1124
    let v1130 : string =
        match v1117 with
        | US3_None -> (* None *)
            v1127
        | US3_Some(v1128) -> (* Some *)
            v1128
    let v1131 : bool = TraceState.trace_state.IsNone
    if v1131 then
        let v1132 : US0 = US0_Verbose
        let struct (v1133 : Mut0, v1134 : Mut1, v1135 : Mut2, v1136 : Mut3, v1137 : Mut4, v1138 : int64 option) = new_trace_state_1(v1132)
        let v1139 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1133, v1134, v1135, v1136, v1137, v1138) 
        TraceState.trace_state <- v1139 
        ()
    let struct (v1140 : Mut0, v1141 : Mut1, v1142 : Mut2, v1143 : Mut3, v1144 : Mut4, v1145 : int64 option) = TraceState.trace_state.Value
    let v1146 : US0 = v1144.l0
    let v1151 : int32 =
        match v1146 with
        | US0_Critical -> (* Critical *)
            50
        | US0_Debug -> (* Debug *)
            20
        | US0_Info -> (* Info *)
            30
        | US0_Verbose -> (* Verbose *)
            10
        | US0_Warning -> (* Warning *)
            40
    let v1152 : bool = v1142.l0
    let v1153 : bool = v1152 = false
    let v1155 : bool =
        if v1153 then
            false
        else
            let v1154 : bool = 10 >= v1151
            v1154
    let v1156 : bool = v1155 = false
    let v1197 : US4 =
        if v1156 then
            US4_None
        else
            let v1158 : bool = TraceState.trace_state.IsNone
            if v1158 then
                let v1159 : US0 = US0_Verbose
                let struct (v1160 : Mut0, v1161 : Mut1, v1162 : Mut2, v1163 : Mut3, v1164 : Mut4, v1165 : int64 option) = new_trace_state_1(v1159)
                let v1166 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1160, v1161, v1162, v1163, v1164, v1165) 
                TraceState.trace_state <- v1166 
                ()
            let struct (v1167 : Mut0, v1168 : Mut1, v1169 : Mut2, v1170 : Mut3, v1171 : Mut4, v1172 : int64 option) = TraceState.trace_state.Value
            let v1173 : string = method6(v1167, v1168, v1169, v1170, v1171, v1172)
            let v1174 : string = method112()
            let v1175 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v1130))
            let v1176 : string = method127(v1167, v1168, v1169, v1170, v1171, v1172, v1173, v1174, v18, v1056, v1175)
            let v1177 : bool = TraceState.trace_state.IsNone
            if v1177 then
                let v1178 : US0 = US0_Verbose
                let struct (v1179 : Mut0, v1180 : Mut1, v1181 : Mut2, v1182 : Mut3, v1183 : Mut4, v1184 : int64 option) = new_trace_state_1(v1178)
                let v1185 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1179, v1180, v1181, v1182, v1183, v1184) 
                TraceState.trace_state <- v1185 
                ()
            let struct (v1186 : Mut0, v1187 : Mut1, v1188 : Mut2, v1189 : Mut3, v1190 : Mut4, v1191 : int64 option) = TraceState.trace_state.Value
            let v1192 : int64 = v1186.l0
            let v1193 : int64 = v1192 + 1L
            v1186.l0 <- v1193
            let v1194 : (string -> unit) = closure5()
            v1194 v1176
            let v1195 : (string -> unit) = v1187.l0
            v1195 v1176
            US4_Some(v1186, v1187, v1188, v1189, v1190, v1191)
    let v1198 : (int32 * string) = v1056, v1130 
    v1198 
    )
    |> fun x -> x ()
    ) () )
    |> fun x -> _capture_v103 <- Some x
    let v1199 : (int32 * string) = match _capture_v103 with Some x -> x | None -> failwith "base.capture / _capture_v103=None"
    let v1200 : int32 = fst v1199 
    let v1201 : string = snd v1199 
    struct (v1200, v1201)
and fix_paths_128 (v0 : string, v1 : string, v2 : string) : struct (string * string) =
    let v3 : string = get_file_name_36(v1)
    let v4 : string = method43(v2, v3)
    let v5 : string = "."
    let v6 : int32 = v1.LastIndexOf v5 
    let v7 : int32 = v6 - 1
    let v8 : string = (spiralStringSlice v1 (int 0) (int v7))
    let v9 : int32 = v4.LastIndexOf v5 
    let v10 : int32 = v9 - 1
    let v11 : string = (spiralStringSlice v4 (int 0) (int v10))
    let v12 : string = ".md"
    let v13 : bool = v0.EndsWith (v12, false, null)
    let v14 : bool = v13 = false
    let v17 : string =
        if v14 then
            let v15 : string = $"{v1}.{v0}"
            v15
        else
            let v16 : string = $"{v8}.{v0}"
            v16
    let v20 : string =
        if v14 then
            let v18 : string = $"{v4}.{v0}"
            v18
        else
            let v19 : string = $"{v11}.{v0}"
            v19
    struct (v17, v20)
and closure77 () () : unativeint =
    let v0 : unativeint = 0 |> unativeint 
    v0
and ok_c78 () (v0 : unativeint) : US39 =
    US39_Ok(v0)
and error_c79 () (v0 : exn) : US39 =
    US39_Error(v0)
and method129 () : US39 =
    let v0 : (unit -> unativeint) = closure77()
    let v1 : (unativeint -> US39) = ok_c78()
    let v2 : ((unit -> exn) -> exn) = closure15()
    let v3 : (exn -> US39) = error_c79()
    let v4 : US39 = try v0 () |> v1 with ex -> (fun () -> ex) |> v2 |> v3 
    v4
and closure80 (v0 : unativeint) () : unativeint =
    let v1 : unativeint = v0 |> unativeint 
    v1
and method130 (v0 : unativeint) : US39 =
    let v1 : (unit -> unativeint) = closure80(v0)
    let v2 : (unativeint -> US39) = ok_c78()
    let v3 : ((unit -> exn) -> exn) = closure15()
    let v4 : (exn -> US39) = error_c79()
    let v5 : US39 = try v1 () |> v2 with ex -> (fun () -> ex) |> v3 |> v4 
    v5
and closure81 () (v0 : (uint8)) : string =
    let v1 : uint8 = (v0)
    let v2 : string = "format!(\"{:02x}\", $0)"
    let v3 : std_string_String = __spiral_emit_rust v1 v2 
    let v4 : string = "Fsharp"
    let v5 : string = () // backend.backend_switch / record_type_try_find / key: v4 
    v5
and closure83 (v0 : string) (v1 : UH0) : UH0 =
    UH0_Cons(v0, v1)
and closure82 () (v0 : string) : (UH0 -> UH0) =
    closure83(v0)
and method131 () : (string -> (UH0 -> UH0)) =
    closure82()
and method132 () : string =
    let v0 : string = ""
    v0
and method133 (v0 : string, v1 : UH0, v2 : string) : struct (string * string) =
    let struct (v11 : string, v12 : string) =
        match v1 with
        | UH0_Cons(v3, v4) -> (* Cons *)
            let struct (v5 : string, v6 : string) = method133(v0, v4, v2)
            let v7 : string = v3 + v6 
            let v8 : string = v7 + v5 
            struct (v8, v0)
        | _ ->
            let struct (v9 : string, v10 : string) =
                match v1 with
                | UH0_Nil -> (* Nil *)
                    struct (v2, v2)
            struct (v9, v10)
    struct (v11, v12)
and ok_c84 () (v0 : string) : US41 =
    US41_Ok(v0)
and method134 () : (string -> US41) =
    ok_c84()
and error_c85 () (v0 : std_io_Error) : US41 =
    US41_Error(v0)
and method135 () : (std_io_Error -> US41) =
    error_c85()
and ok_c86 () (v0 : string) : US42 =
    US42_Ok(v0)
and method136 () : (string -> US42) =
    ok_c86()
and error_c87 () (v0 : std_string_String) : US42 =
    US42_Error(v0)
and method137 () : (std_string_String -> US42) =
    error_c87()
and method138 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : string, v12 : int32, v13 : string, v14 : int32, v15 : string, v16 : string, v17 : US3, v18 : string, v19 : string) : string =
    let v20 : int64 = v0.l0
    let v21 : string = " "
    let v22 : string = v6 + v21 
    let v23 : string = format_real_14(v20)
    let v24 : string = v22 + v23 
    let v25 : string = v24 + v7 
    let v26 : string = v25 + v21 
    let v27 : string = v26 + v8 
    let v28 : string = " / "
    let v29 : string = v27 + v28 
    let v30 : string = ""
    let v31 : string = v30 + v30 
    let v32 : string = "file"
    let v33 : string = v31 + v32 
    let v34 : string = " = "
    let v35 : string = v33 + v34 
    let v36 : string = v35 + v9 
    let v37 : string = "; "
    let v38 : string = v36 + v37 
    let v39 : string = "real_path"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v34 
    let v42 : string = v41 + v10 
    let v43 : string = v42 + v37 
    let v44 : string = "relative_path"
    let v45 : string = v43 + v44 
    let v46 : string = v45 + v34 
    let v47 : string = v46 + v11 
    let v48 : string = v47 + v37 
    let v49 : string = "origin_hash_exit_code"
    let v50 : string = v48 + v49 
    let v51 : string = v50 + v34 
    let v52 : string = format_real_79(v12)
    let v53 : string = v51 + v52 
    let v54 : string = v53 + v37 
    let v55 : string = "origin_hash"
    let v56 : string = v54 + v55 
    let v57 : string = v56 + v34 
    let v58 : string = v57 + v13 
    let v59 : string = v58 + v37 
    let v60 : string = "local_git_hash_exit_code"
    let v61 : string = v59 + v60 
    let v62 : string = v61 + v34 
    let v63 : string = format_real_79(v14)
    let v64 : string = v62 + v63 
    let v65 : string = v64 + v37 
    let v66 : string = "local_git_hash"
    let v67 : string = v65 + v66 
    let v68 : string = v67 + v34 
    let v69 : string = v68 + v15 
    let v70 : string = v69 + v37 
    let v71 : string = "hash1"
    let v72 : string = v70 + v71 
    let v73 : string = v72 + v34 
    let v74 : string = v73 + v16 
    let v75 : string = v74 + v37 
    let v76 : string = "hash2"
    let v77 : string = v75 + v76 
    let v78 : string = v77 + v34 
    let v79 : string = method59(v17)
    let v80 : string = v78 + v79 
    let v81 : string = v80 + v37 
    let v82 : string = "dist_path"
    let v83 : string = v81 + v82 
    let v84 : string = v83 + v34 
    let v85 : string = v84 + v18 
    let v86 : string = v85 + v37 
    let v87 : string = "cache_path"
    let v88 : string = v86 + v87 
    let v89 : string = v88 + v34 
    let v90 : string = v89 + v19 
    let v91 : string = "{ "
    let v92 : string = v91 + v90 
    let v93 : string = " }"
    let v94 : string = v92 + v93 
    let v95 : string = v29 + v94 
    method17(v95)
and file_copy_139 (v0 : string, v1 : string) : unit =
    System.IO.File.Copy (v1, v0, true)
    ()
and method141 (v0 : int32, v1 : Mut7) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method142 (v0 : int32, v1 : Mut8) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method143 (v0 : string) : string =
    v0
and method144 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure90 (v0 : string) (v1 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : unit =
    let v2 : string = "$0"
    let v3 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = __spiral_emit_rust v1 v2 
    let v4 : string = "v3.lock()"
    let v5 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = __spiral_emit_rust () v4 
    let v6 : string = "$0.unwrap()"
    let v7 : std_sync_MutexGuard<std_process_ChildStdin> = __spiral_emit_rust v5 v6 
    let v8 : string = method143(v0)
    let v9 : string = "v8.as_bytes()"
    let v10 : Ref<Slice<uint8>> = __spiral_emit_rust () v9 
    let v11 : std_sync_MutexGuard<std_process_ChildStdin> = method144(v7)
    let v12 : string = "true; let mut v11 = v11"
    let v13 : bool = __spiral_emit_rust () v12 
    let v14 : string = "true; std::io::Write::write_all(&mut *$0, v10).unwrap()"
    let v15 : bool = __spiral_emit_rust v11 v14 
    ()
and method145 (v0 : int32, v1 : Mut9) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method146 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32, v10 : string) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_14(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "documents.hangul"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "exit_code"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : string = format_real_79(v8)
    let v29 : string = v27 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "result_len"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v26 
    let v35 : string = format_real_79(v9)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "output_path"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v26 
    let v41 : string = v40 + v10 
    let v42 : string = "{ "
    let v43 : string = v42 + v41 
    let v44 : string = " }"
    let v45 : string = v43 + v44 
    let v46 : string = v21 + v45 
    method17(v46)
and hangul_140 (v0 : string, v1 : string, v2 : bool, v3 : string, v4 : string) : US43 =
    let v5 : string = v4 |> System.IO.File.ReadAllText
    let v6 : string = "\n"
    let v7 : (string []) = v5.Split v6 
    let v8 : int32 = v7.Length
    let v9 : (string []) = Array.zeroCreate<string> (v8)
    let v10 : Mut7 = {l0 = 0} : Mut7
    while method141(v8, v10) do
        let v12 : int32 = v10.l0
        let v13 : string = v7.[int v12]
        let v14 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v13))
        let v15 : int32 = 0
        let v16 : int32 = method18(v13, v14, v15)
        let v17 : int32 = v14 - 1
        let v18 : string = (spiralStringSlice v13 (int v16) (int v17))
        let v19 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v18))
        let v20 : int32 = method124(v18, v19)
        let v21 : string = (spiralStringSlice v18 (int 0) (int v20))
        v9.[int v12] <- v21
        let v22 : int32 = v12 + 1
        v10.l0 <- v22
        ()
    let v23 : int32 = v9.Length
    let v24 : (string []) = Array.zeroCreate<string> (v23)
    let v25 : Mut8 = {l0 = 0; l1 = 0} : Mut8
    while method142(v23, v25) do
        let v27 : int32 = v25.l0
        let v28 : int32 = v25.l1
        let v29 : string = v9.[int v27]
        let v30 : string = ""
        let v31 : bool = v29 <> v30 
        let v33 : int32 =
            if v31 then
                v24.[int v28] <- v29
                let v32 : int32 = v28 + 1
                v32
            else
                v28
        let v34 : int32 = v27 + 1
        v25.l0 <- v34
        v25.l1 <- v33
        ()
    let v35 : int32 = v25.l1
    let v36 : (string []) = Array.zeroCreate<string> (v35)
    let v37 : Mut7 = {l0 = 0} : Mut7
    while method141(v35, v37) do
        let v39 : int32 = v37.l0
        let v40 : string = v24.[int v39]
        v36.[int v39] <- v40
        let v41 : int32 = v39 + 1
        v37.l0 <- v41
        ()
    let v42 : unit = ()
    let _let'_v42 =
        seq {
            for i = 0 to v36.Length - 1 do yield v36.[i]
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v43 : string seq = _let'_v42 
    let v44 : string = method126()
    let v45 : (string -> (string seq -> string)) = String.concat
    let v46 : (string seq -> string) = v45 v44
    let v47 : string = v46 v43
    let v48 : string = $"{v47}

"
    let v49 : string = " the "
    let v50 : bool = v48.Contains v49 
    let v53 : bool =
        if v50 then
            let v51 : string = " and "
            let v52 : bool = v48.Contains v51 
            v52
        else
            false
    let v55 : string =
        if v53 then
            let v54 : string = "eng"
            v54
        else
            v1
    let v56 : System.Threading.CancellationToken option = None
    let v57 : (struct (string * string) []) = [||]
    let v58 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v59 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v60 : string option = None
    let v61 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v62 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v63 : bool = v62 v61
    let v66 : string =
        if v63 then
            let v64 : string = ".exe"
            v64
        else
            let v65 : string = ""
            v65
    let v67 : string = $"../alphabet/deps/hangulize/cmd/hangulize/hangulize{v66}"
    let v68 : string = method43(v0, v67)
    let v69 : string = $"{v68} {v55}"
    let v70 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) = closure90(v48)
    let v71 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = Some v70 
    let v72 : bool = true
    let v73 : bool = true
    let struct (v74 : int32, v75 : string) = execute_with_options_76(v69, v56, v57, v58, v71, v72, v60, v73)
    let v76 : (string []) = v75.Split v6 
    let v77 : int32 = v76.Length
    let v78 : string = ""
    let v79 : Mut9 = {l0 = 0; l1 = v78; l2 = 0; l3 = 0; l4 = false} : Mut9
    while method145(v23, v79) do
        let v81 : int32 = v79.l0
        let struct (v82 : string, v83 : int32, v84 : int32, v85 : bool) = v79.l1, v79.l2, v79.l3, v79.l4
        let v86 : string = v9.[int v81]
        let v87 : bool = v86 = ""
        let struct (v118 : string, v119 : int32, v120 : int32, v121 : bool) =
            if v87 then
                let v88 : string = v82 + v6 
                let v89 : int32 = v83 + 1
                let v90 : int32 = v84 + 1
                struct (v88, v89, v90, v85)
            else
                let v91 : string = "```"
                let v92 : bool = v86.StartsWith (v91, false, null)
                let v93 : int32 = v83 - v84
                let v94 : bool = v93 >= v77
                let v114 : string =
                    if v94 then
                        v82
                    else
                        let v95 : bool = v92 || v85
                        if v95 then
                            let v96 : string = v82 + v86 
                            let v97 : int32 = v77 - 1
                            let v98 : bool = v93 = v97
                            if v98 then
                                v96
                            else
                                let v99 : string = v96 + v6 
                                v99
                        else
                            let v101 : string = v76.[int v93]
                            let v102 : string = "://"
                            let v103 : bool = v101.Contains v102 
                            let v104 : string =
                                if v103 then
                                    v86
                                else
                                    v101
                            let v105 : string = v82 + v104 
                            let v108 : string =
                                if v2 then
                                    v105
                                else
                                    let v106 : string = v105 + v6 
                                    let v107 : string = v106 + v86 
                                    v107
                            let v109 : int32 = v77 - 1
                            let v110 : bool = v93 = v109
                            if v110 then
                                v108
                            else
                                let v111 : string = v108 + v6 
                                v111
                let v115 : int32 = v83 + 1
                let v117 : bool =
                    if v92 then
                        let v116 : bool = v85 = false
                        v116
                    else
                        v85
                struct (v114, v115, v84, v117)
        let v122 : int32 = v81 + 1
        v79.l0 <- v122
        v79.l1 <- v118
        v79.l2 <- v119
        v79.l3 <- v120
        v79.l4 <- v121
        ()
    let struct (v123 : string, v124 : int32, v125 : int32, v126 : bool) = v79.l1, v79.l2, v79.l3, v79.l4
    System.IO.File.WriteAllText (v3, v123)
    let v127 : bool = TraceState.trace_state.IsNone
    if v127 then
        let v128 : US0 = US0_Verbose
        let struct (v129 : Mut0, v130 : Mut1, v131 : Mut2, v132 : Mut3, v133 : Mut4, v134 : int64 option) = new_trace_state_1(v128)
        let v135 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v129, v130, v131, v132, v133, v134) 
        TraceState.trace_state <- v135 
        ()
    let struct (v136 : Mut0, v137 : Mut1, v138 : Mut2, v139 : Mut3, v140 : Mut4, v141 : int64 option) = TraceState.trace_state.Value
    let v142 : US0 = v140.l0
    let v147 : int32 =
        match v142 with
        | US0_Critical -> (* Critical *)
            50
        | US0_Debug -> (* Debug *)
            20
        | US0_Info -> (* Info *)
            30
        | US0_Verbose -> (* Verbose *)
            10
        | US0_Warning -> (* Warning *)
            40
    let v148 : bool = v138.l0
    let v149 : bool = v148 = false
    let v151 : bool =
        if v149 then
            false
        else
            let v150 : bool = 30 >= v147
            v150
    let v152 : bool = v151 = false
    let v193 : US4 =
        if v152 then
            US4_None
        else
            let v154 : bool = TraceState.trace_state.IsNone
            if v154 then
                let v155 : US0 = US0_Verbose
                let struct (v156 : Mut0, v157 : Mut1, v158 : Mut2, v159 : Mut3, v160 : Mut4, v161 : int64 option) = new_trace_state_1(v155)
                let v162 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v156, v157, v158, v159, v160, v161) 
                TraceState.trace_state <- v162 
                ()
            let struct (v163 : Mut0, v164 : Mut1, v165 : Mut2, v166 : Mut3, v167 : Mut4, v168 : int64 option) = TraceState.trace_state.Value
            let v169 : string = method6(v163, v164, v165, v166, v167, v168)
            let v170 : string = method9()
            let v171 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v123))
            let v172 : string = method146(v163, v164, v165, v166, v167, v168, v169, v170, v74, v171, v3)
            let v173 : bool = TraceState.trace_state.IsNone
            if v173 then
                let v174 : US0 = US0_Verbose
                let struct (v175 : Mut0, v176 : Mut1, v177 : Mut2, v178 : Mut3, v179 : Mut4, v180 : int64 option) = new_trace_state_1(v174)
                let v181 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v175, v176, v177, v178, v179, v180) 
                TraceState.trace_state <- v181 
                ()
            let struct (v182 : Mut0, v183 : Mut1, v184 : Mut2, v185 : Mut3, v186 : Mut4, v187 : int64 option) = TraceState.trace_state.Value
            let v188 : int64 = v182.l0
            let v189 : int64 = v188 + 1L
            v182.l0 <- v189
            let v190 : (string -> unit) = closure5()
            v190 v172
            let v191 : (string -> unit) = v183.l0
            v191 v172
            US4_Some(v182, v183, v184, v185, v186, v187)
    US43_Ok(v74, v123)
and method147 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_14(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "documents.files_fn / error"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "exit_code"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : string = format_real_79(v8)
    let v28 : string = v26 + v27 
    let v29 : string = "; "
    let v30 : string = v28 + v29 
    let v31 : string = "result"
    let v32 : string = v30 + v31 
    let v33 : string = v32 + v25 
    let v34 : string = v33 + v9 
    let v35 : string = "{ "
    let v36 : string = v35 + v34 
    let v37 : string = " }"
    let v38 : string = v36 + v37 
    let v39 : string = v20 + v38 
    method17(v39)
and closure89 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : bool, v5 : string) (v6 : string) : US38 =
    let struct (v7 : string, v8 : string) = fix_paths_128(v6, v5, v0)
    let v9 : bool = file_exists_50(v7)
    let v10 : bool = v9 = false
    let v13 : bool =
        if v10 then
            true
        else
            let v11 : bool = file_exists_50(v8)
            let v12 : bool = v11 = false
            v12
    let v236 : bool =
        if v13 then
            false
        else
            let v14 : string = normalize_path_28(v7)
            let v15 : string = "std::fs::File::open(&*v14)"
            let v16 : Result<std_fs_File, std_io_Error> = __spiral_emit_rust () v15 
            let v17 : string = "$0.unwrap()"
            let v18 : std_fs_File = __spiral_emit_rust v16 v17 
            let v19 : string = "std::io::BufReader::new($0)"
            let v20 : std_io_BufReader<std_fs_File> = __spiral_emit_rust v18 v19 
            let v21 : string = "std::io::BufReader::new($0)"
            let v22 : std_io_BufReader<std_io_BufReader<std_fs_File>> = __spiral_emit_rust v20 v21 
            let v23 : string = "true; let mut v22 = v22"
            let v24 : bool = __spiral_emit_rust () v23 
            let v25 : string = "true; let result : sha2::Sha256 = sha2::Digest::new()"
            let v26 : bool = __spiral_emit_rust () v25 
            let v27 : string = "result"
            let v28 : sha2_Sha256 = __spiral_emit_rust () v27 
            let v29 : string = "true; let mut v28 = v28"
            let v30 : bool = __spiral_emit_rust () v29 
            let v31 : US39 = method129()
            let v37 : US40 =
                match v31 with
                | US39_Error(v34) -> (* Error *)
                    US40_None
                | US39_Ok(v32) -> (* Ok *)
                    US40_Some(v32)
            let v41 : unativeint =
                match v37 with
                | US40_None -> (* None *)
                    failwith<unativeint> "Option does not have a value."
                | US40_Some(v38) -> (* Some *)
                    v38
            let v42 : string = "[$0; 1024 as usize]"
            let v43 : Slice'<uint8> = __spiral_emit_rust 0uy v42 
            let v44 : string = "true; loop { // rust.loop 1"
            let v45 : bool = __spiral_emit_rust () v44 
            let v46 : string = "true; let mut v43 = v43"
            let v47 : bool = __spiral_emit_rust () v46 
            let v48 : string = "std::io::Read::read(&mut v22, &mut v43)"
            let v49 : Result<unativeint, std_io_Error> = __spiral_emit_rust () v48 
            let v50 : string = "$0.unwrap()"
            let v51 : unativeint = __spiral_emit_rust v49 v50 
            let v52 : bool = v51 = v41 
            let v55 : bool =
                if v52 then
                    let v53 : string = "true; break ()"
                    let v54 : bool = __spiral_emit_rust () v53 
                    true
                else
                    false
            let v56 : US39 = method130(v51)
            let v62 : US40 =
                match v56 with
                | US39_Error(v59) -> (* Error *)
                    US40_None
                | US39_Ok(v57) -> (* Ok *)
                    US40_Some(v57)
            let v66 : unativeint =
                match v62 with
                | US40_None -> (* None *)
                    failwith<unativeint> "Option does not have a value."
                | US40_Some(v63) -> (* Some *)
                    v63
            let v67 : unativeint = v66 |> unbox<unativeint>
            let v68 : string = "v43.len()"
            let v69 : unativeint = __spiral_emit_rust () v68 
            let v70 : bool = v67 = v69 
            let v75 : Ref<Slice'<uint8>> =
                if v70 then
                    let v71 : string = "&v43[v41..]"
                    let v72 : Ref<Slice'<uint8>> = __spiral_emit_rust () v71 
                    v72
                else
                    let v73 : string = "&v43[$0..$1]"
                    let v74 : Ref<Slice'<uint8>> = __spiral_emit_rust struct (v41, v66) v73 
                    v74
            let v76 : string = "true; sha2::Digest::update(&mut v28, v75)"
            let v77 : bool = __spiral_emit_rust () v76 
            let v78 : string = "true; } // rust.loop 3"
            let v79 : bool = __spiral_emit_rust () v78 
            let v80 : string = "&sha2::Digest::finalize(v28)"
            let v81 : Ref<Slice<uint8>> = __spiral_emit_rust () v80 
            let v82 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v83 : Vec<uint8> = __spiral_emit_rust v81 v82 
            let v84 : string = "$0.iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
            let v85 : ((uint8) -> string) = closure81()
            let v86 : Vec<string> = __spiral_emit_rust struct (v83, v85) v84 
            let v87 : string = "Fsharp"
            let v88 : (string []) = () // backend.backend_switch / record_type_try_find / key: v87 
            let v89 : string list = v88 |> Array.toList
            let v90 : ((string -> (UH0 -> UH0)) -> (string list -> (UH0 -> UH0))) = List.foldBack
            let v91 : (string -> (UH0 -> UH0)) = method131()
            let v92 : (string list -> (UH0 -> UH0)) = v90 v91
            let v93 : (UH0 -> UH0) = v92 v89
            let v94 : UH0 = UH0_Nil
            let v95 : UH0 = v93 v94
            let v96 : string = method132()
            let v97 : string = ""
            let struct (v98 : string, v99 : string) = method133(v96, v95, v97)
            let v100 : Result<string, std_io_Error> = Ok v98 
            let v101 : (string -> US41) = method134()
            let v102 : (std_io_Error -> US41) = method135()
            let v103 : US41 = match v100 with Ok x -> v101 x | Error x -> v102 x
            let v110 : US42 =
                match v103 with
                | US41_Error(v106) -> (* Error *)
                    let v107 : std_string_String = null |> unbox<std_string_String>
                    US42_Error(v107)
                | US41_Ok(v104) -> (* Ok *)
                    US42_Ok(v104)
            let v116 : Result<string, std_string_String> =
                match v110 with
                | US42_Error(v113) -> (* Error *)
                    let v114 : Result<string, std_string_String> = Error v113 
                    v114
                | US42_Ok(v111) -> (* Ok *)
                    let v112 : Result<string, std_string_String> = Ok v111 
                    v112
            let v117 : (string -> US42) = method136()
            let v118 : (std_string_String -> US42) = method137()
            let v119 : US42 = match v116 with Ok x -> v117 x | Error x -> v118 x
            let v125 : string =
                match v119 with
                | US42_Error(v121) -> (* Error *)
                    let v122 : string = $"resultm.get / Error x: {v121}"
                    failwith<string> v122
                | US42_Ok(v120) -> (* Ok *)
                    v120
            let v126 : string = normalize_path_28(v8)
            let v127 : string = "std::fs::File::open(&*v126)"
            let v128 : Result<std_fs_File, std_io_Error> = __spiral_emit_rust () v127 
            let v129 : string = "$0.unwrap()"
            let v130 : std_fs_File = __spiral_emit_rust v128 v129 
            let v131 : string = "std::io::BufReader::new($0)"
            let v132 : std_io_BufReader<std_fs_File> = __spiral_emit_rust v130 v131 
            let v133 : string = "std::io::BufReader::new($0)"
            let v134 : std_io_BufReader<std_io_BufReader<std_fs_File>> = __spiral_emit_rust v132 v133 
            let v135 : string = "true; let mut v134 = v134"
            let v136 : bool = __spiral_emit_rust () v135 
            let v137 : string = "true; let result : sha2::Sha256 = sha2::Digest::new()"
            let v138 : bool = __spiral_emit_rust () v137 
            let v139 : string = "result"
            let v140 : sha2_Sha256 = __spiral_emit_rust () v139 
            let v141 : string = "true; let mut v140 = v140"
            let v142 : bool = __spiral_emit_rust () v141 
            let v143 : US39 = method129()
            let v149 : US40 =
                match v143 with
                | US39_Error(v146) -> (* Error *)
                    US40_None
                | US39_Ok(v144) -> (* Ok *)
                    US40_Some(v144)
            let v153 : unativeint =
                match v149 with
                | US40_None -> (* None *)
                    failwith<unativeint> "Option does not have a value."
                | US40_Some(v150) -> (* Some *)
                    v150
            let v154 : string = "[$0; 1024 as usize]"
            let v155 : Slice'<uint8> = __spiral_emit_rust 0uy v154 
            let v156 : string = "true; loop { // rust.loop 1"
            let v157 : bool = __spiral_emit_rust () v156 
            let v158 : string = "true; let mut v155 = v155"
            let v159 : bool = __spiral_emit_rust () v158 
            let v160 : string = "std::io::Read::read(&mut v134, &mut v155)"
            let v161 : Result<unativeint, std_io_Error> = __spiral_emit_rust () v160 
            let v162 : string = "$0.unwrap()"
            let v163 : unativeint = __spiral_emit_rust v161 v162 
            let v164 : bool = v163 = v153 
            let v167 : bool =
                if v164 then
                    let v165 : string = "true; break ()"
                    let v166 : bool = __spiral_emit_rust () v165 
                    true
                else
                    false
            let v168 : US39 = method130(v163)
            let v174 : US40 =
                match v168 with
                | US39_Error(v171) -> (* Error *)
                    US40_None
                | US39_Ok(v169) -> (* Ok *)
                    US40_Some(v169)
            let v178 : unativeint =
                match v174 with
                | US40_None -> (* None *)
                    failwith<unativeint> "Option does not have a value."
                | US40_Some(v175) -> (* Some *)
                    v175
            let v179 : unativeint = v178 |> unbox<unativeint>
            let v180 : string = "v155.len()"
            let v181 : unativeint = __spiral_emit_rust () v180 
            let v182 : bool = v179 = v181 
            let v187 : Ref<Slice'<uint8>> =
                if v182 then
                    let v183 : string = "&v155[v153..]"
                    let v184 : Ref<Slice'<uint8>> = __spiral_emit_rust () v183 
                    v184
                else
                    let v185 : string = "&v155[$0..$1]"
                    let v186 : Ref<Slice'<uint8>> = __spiral_emit_rust struct (v153, v178) v185 
                    v186
            let v188 : string = "true; sha2::Digest::update(&mut v140, v187)"
            let v189 : bool = __spiral_emit_rust () v188 
            let v190 : string = "true; } // rust.loop 3"
            let v191 : bool = __spiral_emit_rust () v190 
            let v192 : string = "&sha2::Digest::finalize(v140)"
            let v193 : Ref<Slice<uint8>> = __spiral_emit_rust () v192 
            let v194 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v195 : Vec<uint8> = __spiral_emit_rust v193 v194 
            let v196 : string = "$0.iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
            let v197 : Vec<string> = __spiral_emit_rust struct (v195, v85) v196 
            let v198 : (string []) = () // backend.backend_switch / record_type_try_find / key: v87 
            let v199 : string list = v198 |> Array.toList
            let v200 : ((string -> (UH0 -> UH0)) -> (string list -> (UH0 -> UH0))) = List.foldBack
            let v201 : (string -> (UH0 -> UH0)) = method131()
            let v202 : (string list -> (UH0 -> UH0)) = v200 v201
            let v203 : (UH0 -> UH0) = v202 v199
            let v204 : UH0 = UH0_Nil
            let v205 : UH0 = v203 v204
            let v206 : string = method132()
            let struct (v207 : string, v208 : string) = method133(v206, v205, v97)
            let v209 : Result<string, std_io_Error> = Ok v207 
            let v210 : (string -> US41) = method134()
            let v211 : (std_io_Error -> US41) = method135()
            let v212 : US41 = match v209 with Ok x -> v210 x | Error x -> v211 x
            let v219 : US42 =
                match v212 with
                | US41_Error(v215) -> (* Error *)
                    let v216 : std_string_String = null |> unbox<std_string_String>
                    US42_Error(v216)
                | US41_Ok(v213) -> (* Ok *)
                    US42_Ok(v213)
            let v225 : Result<string, std_string_String> =
                match v219 with
                | US42_Error(v222) -> (* Error *)
                    let v223 : Result<string, std_string_String> = Error v222 
                    v223
                | US42_Ok(v220) -> (* Ok *)
                    let v221 : Result<string, std_string_String> = Ok v220 
                    v221
            let v226 : (string -> US42) = method136()
            let v227 : (std_string_String -> US42) = method137()
            let v228 : US42 = match v225 with Ok x -> v226 x | Error x -> v227 x
            let v234 : string =
                match v228 with
                | US42_Error(v230) -> (* Error *)
                    let v231 : string = $"resultm.get / Error x: {v230}"
                    failwith<string> v231
                | US42_Ok(v229) -> (* Ok *)
                    v229
            let v235 : bool = v125 = v234
            v235
    if v236 then
        US38_None
    else
        let v238 : US43 = hangul_140(v2, v3, v4, v7, v5)
        match v238 with
        | US43_Error(v316, v317) -> (* Error *)
            let v318 : (string * string) = v7, v317 
            let v319 : Result<string, (string * string)> = Error v318 
            US38_Some(v319)
        | US43_Ok(v239, v240) -> (* Ok *)
            let v241 : bool = v239 <> 0 
            if v241 then
                let v242 : bool = TraceState.trace_state.IsNone
                if v242 then
                    let v243 : US0 = US0_Verbose
                    let struct (v244 : Mut0, v245 : Mut1, v246 : Mut2, v247 : Mut3, v248 : Mut4, v249 : int64 option) = new_trace_state_1(v243)
                    let v250 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v244, v245, v246, v247, v248, v249) 
                    TraceState.trace_state <- v250 
                    ()
                let struct (v251 : Mut0, v252 : Mut1, v253 : Mut2, v254 : Mut3, v255 : Mut4, v256 : int64 option) = TraceState.trace_state.Value
                let v257 : US0 = v255.l0
                let v262 : int32 =
                    match v257 with
                    | US0_Critical -> (* Critical *)
                        50
                    | US0_Debug -> (* Debug *)
                        20
                    | US0_Info -> (* Info *)
                        30
                    | US0_Verbose -> (* Verbose *)
                        10
                    | US0_Warning -> (* Warning *)
                        40
                let v263 : bool = v253.l0
                let v264 : bool = v263 = false
                let v266 : bool =
                    if v264 then
                        false
                    else
                        let v265 : bool = 30 >= v262
                        v265
                let v267 : bool = v266 = false
                let v307 : US4 =
                    if v267 then
                        US4_None
                    else
                        let v269 : bool = TraceState.trace_state.IsNone
                        if v269 then
                            let v270 : US0 = US0_Verbose
                            let struct (v271 : Mut0, v272 : Mut1, v273 : Mut2, v274 : Mut3, v275 : Mut4, v276 : int64 option) = new_trace_state_1(v270)
                            let v277 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v271, v272, v273, v274, v275, v276) 
                            TraceState.trace_state <- v277 
                            ()
                        let struct (v278 : Mut0, v279 : Mut1, v280 : Mut2, v281 : Mut3, v282 : Mut4, v283 : int64 option) = TraceState.trace_state.Value
                        let v284 : string = method6(v278, v279, v280, v281, v282, v283)
                        let v285 : string = method9()
                        let v286 : string = method147(v278, v279, v280, v281, v282, v283, v284, v285, v239, v240)
                        let v287 : bool = TraceState.trace_state.IsNone
                        if v287 then
                            let v288 : US0 = US0_Verbose
                            let struct (v289 : Mut0, v290 : Mut1, v291 : Mut2, v292 : Mut3, v293 : Mut4, v294 : int64 option) = new_trace_state_1(v288)
                            let v295 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v289, v290, v291, v292, v293, v294) 
                            TraceState.trace_state <- v295 
                            ()
                        let struct (v296 : Mut0, v297 : Mut1, v298 : Mut2, v299 : Mut3, v300 : Mut4, v301 : int64 option) = TraceState.trace_state.Value
                        let v302 : int64 = v296.l0
                        let v303 : int64 = v302 + 1L
                        v296.l0 <- v303
                        let v304 : (string -> unit) = closure5()
                        v304 v286
                        let v305 : (string -> unit) = v297.l0
                        v305 v286
                        US4_Some(v296, v297, v298, v299, v300, v301)
                let v308 : (string * string) = v7, v240 
                let v309 : Result<string, (string * string)> = Error v308 
                US38_Some(v309)
            else
                let v311 : bool = file_exists_50(v7)
                if v311 then
                    file_copy_139(v8, v7)
                else
                    let v312 : string = $"documents.files_fn / {v7} should exist"
                    failwith<unit> v312
                let v313 : Result<string, (string * string)> = Ok v7 
                US38_Some(v313)
and closure88 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : bool) (v5 : string) : (string -> US38) =
    closure89(v0, v1, v2, v3, v4, v5)
and method149 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string, v10 : string) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_14(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "documents.crowbook / attempt error"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "exit_code"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : string = format_real_79(v8)
    let v29 : string = v27 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "output_path"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v26 
    let v35 : string = v34 + v9 
    let v36 : string = v35 + v30 
    let v37 : string = "result"
    let v38 : string = v36 + v37 
    let v39 : string = v38 + v26 
    let v40 : string = v39 + v10 
    let v41 : string = "{ "
    let v42 : string = v41 + v40 
    let v43 : string = " }"
    let v44 : string = v42 + v43 
    let v45 : string = v21 + v44 
    method17(v45)
and method150 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string, v10 : string) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_14(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "documents.crowbook / result contains ERROR"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "exit_code"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : string = format_real_79(v8)
    let v29 : string = v27 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "output_path"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v26 
    let v35 : string = v34 + v9 
    let v36 : string = v35 + v30 
    let v37 : string = "result"
    let v38 : string = v36 + v37 
    let v39 : string = v38 + v26 
    let v40 : string = v39 + v10 
    let v41 : string = "{ "
    let v42 : string = v41 + v40 
    let v43 : string = " }"
    let v44 : string = v42 + v43 
    let v45 : string = v21 + v44 
    method17(v45)
and crowbook_148 (v0 : bool, v1 : string, v2 : string, v3 : string, v4 : string) : US43 =
    let v5 : bool = "html" = v4
    let v63 : string =
        if v5 then
            let v6 : string = $"--set"
            let v7 : string = $" html.css.add \\\"'"
            let v8 : string = v6 + v7 
            let v9 : string = $" body {{ color: #e8e6e3; background-color: #202324; }}"
            let v10 : string = v8 + v9 
            let v11 : string = $" a {{ color: #989693; }}"
            let v12 : string = v10 + v11 
            let v13 : string = $" pre {{ background-color: #1b1b1b; padding: 10px; }}"
            let v14 : string = v12 + v13 
            let v15 : string = $" '\\\""
            let v16 : string = v14 + v15 
            let v17 : string = $" rendering.num_depth 6"
            let v18 : string = $" rendering.highlight.theme \\\"Solarized (dark)\\\""
            let v19 : string = v17 + v18 
            let v20 : string = v16 + v19 
            v20
        else
            let v21 : bool = "pdf" = v4
            if v21 then
                let v22 : string = $"--set"
                let v23 : string = $" tex.paper.size a4paper"
                let v24 : string = v22 + v23 
                let v25 : string = $" tex.command tectonic"
                let v26 : string = v24 + v25 
                let v27 : string = $" tex.template.add \"\\pagenumbering{{gobble}}\""
                let v28 : string = v26 + v27 
                let v29 : bool = v0 = false
                let v38 : string =
                    if v29 then
                        let v30 : string = ""
                        v30
                    else
                        let v31 : string = $" tex.template.add \"\\usepackage{{polyglossia}}\""
                        let v32 : string = $" tex.template.add \"\\setmainlanguage{{korean}}\""
                        let v33 : string = v31 + v32 
                        let v34 : string = $" tex.template.add \"\\setmainfont{{NanumGothicCoding}}\""
                        let v35 : string = v33 + v34 
                        let v36 : string = $" tex.font.size 13"
                        let v37 : string = v35 + v36 
                        v37
                let v39 : string = v28 + v38 
                let v40 : string = $" rendering.num_depth 6"
                let v41 : string = $" rendering.highlight.theme \\\"Solarized (dark)\\\""
                let v42 : string = v40 + v41 
                let v43 : string = v39 + v42 
                v43
            else
                let v44 : bool = "epub" = v4
                if v44 then
                    let v45 : string = $"--set"
                    let v46 : string = $" epub.version 3"
                    let v47 : string = v45 + v46 
                    let v48 : string = $" html.css.add \\\"' "
                    let v49 : string = v47 + v48 
                    let v50 : string = $" body {{ color: #e8e6e3; background-color: #202324; }} "
                    let v51 : string = v49 + v50 
                    let v52 : string = $" a {{ color: #989693; }} "
                    let v53 : string = v51 + v52 
                    let v54 : string = $" '\\\""
                    let v55 : string = v53 + v54 
                    let v56 : string = $" rendering.num_depth 6"
                    let v57 : string = $" rendering.highlight.theme \\\"Solarized (dark)\\\""
                    let v58 : string = v56 + v57 
                    let v59 : string = v55 + v58 
                    v59
                else
                    let v60 : string = ""
                    v60
    let v64 : System.Threading.CancellationToken option = None
    let v65 : (struct (string * string) []) = [||]
    let v66 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v67 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v68 : string option = None
    let v69 : string = $"crowbook --verbose --to {v4}"
    let v70 : string = $" --single \"{v2}\" --output \"{v1}\" {v63}"
    let v71 : string = v69 + v70 
    let v72 : string option = Some v3 
    let v73 : bool = true
    let v74 : bool = true
    let struct (v75 : int32, v76 : string) = execute_with_options_76(v71, v64, v65, v66, v67, v73, v72, v74)
    let v77 : bool = v75 = 0
    let struct (v162 : int32, v163 : string) =
        if v77 then
            struct (v75, v76)
        else
            let v78 : bool = TraceState.trace_state.IsNone
            if v78 then
                let v79 : US0 = US0_Verbose
                let struct (v80 : Mut0, v81 : Mut1, v82 : Mut2, v83 : Mut3, v84 : Mut4, v85 : int64 option) = new_trace_state_1(v79)
                let v86 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v80, v81, v82, v83, v84, v85) 
                TraceState.trace_state <- v86 
                ()
            let struct (v87 : Mut0, v88 : Mut1, v89 : Mut2, v90 : Mut3, v91 : Mut4, v92 : int64 option) = TraceState.trace_state.Value
            let v93 : US0 = v91.l0
            let v98 : int32 =
                match v93 with
                | US0_Critical -> (* Critical *)
                    50
                | US0_Debug -> (* Debug *)
                    20
                | US0_Info -> (* Info *)
                    30
                | US0_Verbose -> (* Verbose *)
                    10
                | US0_Warning -> (* Warning *)
                    40
            let v99 : bool = v89.l0
            let v100 : bool = v99 = false
            let v102 : bool =
                if v100 then
                    false
                else
                    let v101 : bool = 40 >= v98
                    v101
            let v103 : bool = v102 = false
            let v143 : US4 =
                if v103 then
                    US4_None
                else
                    let v105 : bool = TraceState.trace_state.IsNone
                    if v105 then
                        let v106 : US0 = US0_Verbose
                        let struct (v107 : Mut0, v108 : Mut1, v109 : Mut2, v110 : Mut3, v111 : Mut4, v112 : int64 option) = new_trace_state_1(v106)
                        let v113 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v107, v108, v109, v110, v111, v112) 
                        TraceState.trace_state <- v113 
                        ()
                    let struct (v114 : Mut0, v115 : Mut1, v116 : Mut2, v117 : Mut3, v118 : Mut4, v119 : int64 option) = TraceState.trace_state.Value
                    let v120 : string = method6(v114, v115, v116, v117, v118, v119)
                    let v121 : string = method54()
                    let v122 : string = method149(v114, v115, v116, v117, v118, v119, v120, v121, v75, v1, v76)
                    let v123 : bool = TraceState.trace_state.IsNone
                    if v123 then
                        let v124 : US0 = US0_Verbose
                        let struct (v125 : Mut0, v126 : Mut1, v127 : Mut2, v128 : Mut3, v129 : Mut4, v130 : int64 option) = new_trace_state_1(v124)
                        let v131 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v125, v126, v127, v128, v129, v130) 
                        TraceState.trace_state <- v131 
                        ()
                    let struct (v132 : Mut0, v133 : Mut1, v134 : Mut2, v135 : Mut3, v136 : Mut4, v137 : int64 option) = TraceState.trace_state.Value
                    let v138 : int64 = v132.l0
                    let v139 : int64 = v138 + 1L
                    v132.l0 <- v139
                    let v140 : (string -> unit) = closure5()
                    v140 v122
                    let v141 : (string -> unit) = v133.l0
                    v141 v122
                    US4_Some(v132, v133, v134, v135, v136, v137)
            let v144 : System.Threading.CancellationToken option = None
            let v145 : (struct (string * string) []) = [||]
            let v146 : (struct (int32 * string * bool) -> Async<unit>) option = None
            let v147 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
            let v148 : string option = None
            let v149 : string = $"crowbook --verbose --to {v4}"
            let v150 : string = $" --single \"{v2}\" --output \"{v1}\""
            let v151 : string = v149 + v150 
            let v152 : bool = v4 = "pdf"
            let v155 : string =
                if v152 then
                    let v153 : string = $" --set tex.command tectonic"
                    v153
                else
                    let v154 : string = ""
                    v154
            let v156 : string = v151 + v155 
            let v157 : string option = Some v3 
            let v158 : bool = true
            let v159 : bool = true
            execute_with_options_76(v156, v144, v145, v146, v147, v158, v157, v159)
    let v164 : string = "ERROR"
    let v165 : bool = v163.Contains v164 
    let v166 : bool = v165 = false
    if v166 then
        US43_Ok(v162, v163)
    else
        let v168 : bool = TraceState.trace_state.IsNone
        if v168 then
            let v169 : US0 = US0_Verbose
            let struct (v170 : Mut0, v171 : Mut1, v172 : Mut2, v173 : Mut3, v174 : Mut4, v175 : int64 option) = new_trace_state_1(v169)
            let v176 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v170, v171, v172, v173, v174, v175) 
            TraceState.trace_state <- v176 
            ()
        let struct (v177 : Mut0, v178 : Mut1, v179 : Mut2, v180 : Mut3, v181 : Mut4, v182 : int64 option) = TraceState.trace_state.Value
        let v183 : US0 = v181.l0
        let v188 : int32 =
            match v183 with
            | US0_Critical -> (* Critical *)
                50
            | US0_Debug -> (* Debug *)
                20
            | US0_Info -> (* Info *)
                30
            | US0_Verbose -> (* Verbose *)
                10
            | US0_Warning -> (* Warning *)
                40
        let v189 : bool = v179.l0
        let v190 : bool = v189 = false
        let v192 : bool =
            if v190 then
                false
            else
                let v191 : bool = 40 >= v188
                v191
        let v193 : bool = v192 = false
        let v233 : US4 =
            if v193 then
                US4_None
            else
                let v195 : bool = TraceState.trace_state.IsNone
                if v195 then
                    let v196 : US0 = US0_Verbose
                    let struct (v197 : Mut0, v198 : Mut1, v199 : Mut2, v200 : Mut3, v201 : Mut4, v202 : int64 option) = new_trace_state_1(v196)
                    let v203 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v197, v198, v199, v200, v201, v202) 
                    TraceState.trace_state <- v203 
                    ()
                let struct (v204 : Mut0, v205 : Mut1, v206 : Mut2, v207 : Mut3, v208 : Mut4, v209 : int64 option) = TraceState.trace_state.Value
                let v210 : string = method6(v204, v205, v206, v207, v208, v209)
                let v211 : string = method54()
                let v212 : string = method150(v204, v205, v206, v207, v208, v209, v210, v211, v162, v1, v163)
                let v213 : bool = TraceState.trace_state.IsNone
                if v213 then
                    let v214 : US0 = US0_Verbose
                    let struct (v215 : Mut0, v216 : Mut1, v217 : Mut2, v218 : Mut3, v219 : Mut4, v220 : int64 option) = new_trace_state_1(v214)
                    let v221 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v215, v216, v217, v218, v219, v220) 
                    TraceState.trace_state <- v221 
                    ()
                let struct (v222 : Mut0, v223 : Mut1, v224 : Mut2, v225 : Mut3, v226 : Mut4, v227 : int64 option) = TraceState.trace_state.Value
                let v228 : int64 = v222.l0
                let v229 : int64 = v228 + 1L
                v222.l0 <- v229
                let v230 : (string -> unit) = closure5()
                v230 v212
                let v231 : (string -> unit) = v223.l0
                v231 v212
                US4_Some(v222, v223, v224, v225, v226, v227)
        US43_Error(v162, v163)
and closure92 (v0 : string, v1 : string, v2 : bool, v3 : string) (v4 : string) : US38 =
    let struct (v5 : string, v6 : string) = fix_paths_128(v4, v3, v0)
    let v7 : bool = file_exists_50(v5)
    let v8 : bool = v7 = false
    let v11 : bool =
        if v8 then
            true
        else
            let v9 : bool = file_exists_50(v6)
            let v10 : bool = v9 = false
            v10
    let v234 : bool =
        if v11 then
            false
        else
            let v12 : string = normalize_path_28(v5)
            let v13 : string = "std::fs::File::open(&*v12)"
            let v14 : Result<std_fs_File, std_io_Error> = __spiral_emit_rust () v13 
            let v15 : string = "$0.unwrap()"
            let v16 : std_fs_File = __spiral_emit_rust v14 v15 
            let v17 : string = "std::io::BufReader::new($0)"
            let v18 : std_io_BufReader<std_fs_File> = __spiral_emit_rust v16 v17 
            let v19 : string = "std::io::BufReader::new($0)"
            let v20 : std_io_BufReader<std_io_BufReader<std_fs_File>> = __spiral_emit_rust v18 v19 
            let v21 : string = "true; let mut v20 = v20"
            let v22 : bool = __spiral_emit_rust () v21 
            let v23 : string = "true; let result : sha2::Sha256 = sha2::Digest::new()"
            let v24 : bool = __spiral_emit_rust () v23 
            let v25 : string = "result"
            let v26 : sha2_Sha256 = __spiral_emit_rust () v25 
            let v27 : string = "true; let mut v26 = v26"
            let v28 : bool = __spiral_emit_rust () v27 
            let v29 : US39 = method129()
            let v35 : US40 =
                match v29 with
                | US39_Error(v32) -> (* Error *)
                    US40_None
                | US39_Ok(v30) -> (* Ok *)
                    US40_Some(v30)
            let v39 : unativeint =
                match v35 with
                | US40_None -> (* None *)
                    failwith<unativeint> "Option does not have a value."
                | US40_Some(v36) -> (* Some *)
                    v36
            let v40 : string = "[$0; 1024 as usize]"
            let v41 : Slice'<uint8> = __spiral_emit_rust 0uy v40 
            let v42 : string = "true; loop { // rust.loop 1"
            let v43 : bool = __spiral_emit_rust () v42 
            let v44 : string = "true; let mut v41 = v41"
            let v45 : bool = __spiral_emit_rust () v44 
            let v46 : string = "std::io::Read::read(&mut v20, &mut v41)"
            let v47 : Result<unativeint, std_io_Error> = __spiral_emit_rust () v46 
            let v48 : string = "$0.unwrap()"
            let v49 : unativeint = __spiral_emit_rust v47 v48 
            let v50 : bool = v49 = v39 
            let v53 : bool =
                if v50 then
                    let v51 : string = "true; break ()"
                    let v52 : bool = __spiral_emit_rust () v51 
                    true
                else
                    false
            let v54 : US39 = method130(v49)
            let v60 : US40 =
                match v54 with
                | US39_Error(v57) -> (* Error *)
                    US40_None
                | US39_Ok(v55) -> (* Ok *)
                    US40_Some(v55)
            let v64 : unativeint =
                match v60 with
                | US40_None -> (* None *)
                    failwith<unativeint> "Option does not have a value."
                | US40_Some(v61) -> (* Some *)
                    v61
            let v65 : unativeint = v64 |> unbox<unativeint>
            let v66 : string = "v41.len()"
            let v67 : unativeint = __spiral_emit_rust () v66 
            let v68 : bool = v65 = v67 
            let v73 : Ref<Slice'<uint8>> =
                if v68 then
                    let v69 : string = "&v41[v39..]"
                    let v70 : Ref<Slice'<uint8>> = __spiral_emit_rust () v69 
                    v70
                else
                    let v71 : string = "&v41[$0..$1]"
                    let v72 : Ref<Slice'<uint8>> = __spiral_emit_rust struct (v39, v64) v71 
                    v72
            let v74 : string = "true; sha2::Digest::update(&mut v26, v73)"
            let v75 : bool = __spiral_emit_rust () v74 
            let v76 : string = "true; } // rust.loop 3"
            let v77 : bool = __spiral_emit_rust () v76 
            let v78 : string = "&sha2::Digest::finalize(v26)"
            let v79 : Ref<Slice<uint8>> = __spiral_emit_rust () v78 
            let v80 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v81 : Vec<uint8> = __spiral_emit_rust v79 v80 
            let v82 : string = "$0.iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
            let v83 : ((uint8) -> string) = closure81()
            let v84 : Vec<string> = __spiral_emit_rust struct (v81, v83) v82 
            let v85 : string = "Fsharp"
            let v86 : (string []) = () // backend.backend_switch / record_type_try_find / key: v85 
            let v87 : string list = v86 |> Array.toList
            let v88 : ((string -> (UH0 -> UH0)) -> (string list -> (UH0 -> UH0))) = List.foldBack
            let v89 : (string -> (UH0 -> UH0)) = method131()
            let v90 : (string list -> (UH0 -> UH0)) = v88 v89
            let v91 : (UH0 -> UH0) = v90 v87
            let v92 : UH0 = UH0_Nil
            let v93 : UH0 = v91 v92
            let v94 : string = method132()
            let v95 : string = ""
            let struct (v96 : string, v97 : string) = method133(v94, v93, v95)
            let v98 : Result<string, std_io_Error> = Ok v96 
            let v99 : (string -> US41) = method134()
            let v100 : (std_io_Error -> US41) = method135()
            let v101 : US41 = match v98 with Ok x -> v99 x | Error x -> v100 x
            let v108 : US42 =
                match v101 with
                | US41_Error(v104) -> (* Error *)
                    let v105 : std_string_String = null |> unbox<std_string_String>
                    US42_Error(v105)
                | US41_Ok(v102) -> (* Ok *)
                    US42_Ok(v102)
            let v114 : Result<string, std_string_String> =
                match v108 with
                | US42_Error(v111) -> (* Error *)
                    let v112 : Result<string, std_string_String> = Error v111 
                    v112
                | US42_Ok(v109) -> (* Ok *)
                    let v110 : Result<string, std_string_String> = Ok v109 
                    v110
            let v115 : (string -> US42) = method136()
            let v116 : (std_string_String -> US42) = method137()
            let v117 : US42 = match v114 with Ok x -> v115 x | Error x -> v116 x
            let v123 : string =
                match v117 with
                | US42_Error(v119) -> (* Error *)
                    let v120 : string = $"resultm.get / Error x: {v119}"
                    failwith<string> v120
                | US42_Ok(v118) -> (* Ok *)
                    v118
            let v124 : string = normalize_path_28(v6)
            let v125 : string = "std::fs::File::open(&*v124)"
            let v126 : Result<std_fs_File, std_io_Error> = __spiral_emit_rust () v125 
            let v127 : string = "$0.unwrap()"
            let v128 : std_fs_File = __spiral_emit_rust v126 v127 
            let v129 : string = "std::io::BufReader::new($0)"
            let v130 : std_io_BufReader<std_fs_File> = __spiral_emit_rust v128 v129 
            let v131 : string = "std::io::BufReader::new($0)"
            let v132 : std_io_BufReader<std_io_BufReader<std_fs_File>> = __spiral_emit_rust v130 v131 
            let v133 : string = "true; let mut v132 = v132"
            let v134 : bool = __spiral_emit_rust () v133 
            let v135 : string = "true; let result : sha2::Sha256 = sha2::Digest::new()"
            let v136 : bool = __spiral_emit_rust () v135 
            let v137 : string = "result"
            let v138 : sha2_Sha256 = __spiral_emit_rust () v137 
            let v139 : string = "true; let mut v138 = v138"
            let v140 : bool = __spiral_emit_rust () v139 
            let v141 : US39 = method129()
            let v147 : US40 =
                match v141 with
                | US39_Error(v144) -> (* Error *)
                    US40_None
                | US39_Ok(v142) -> (* Ok *)
                    US40_Some(v142)
            let v151 : unativeint =
                match v147 with
                | US40_None -> (* None *)
                    failwith<unativeint> "Option does not have a value."
                | US40_Some(v148) -> (* Some *)
                    v148
            let v152 : string = "[$0; 1024 as usize]"
            let v153 : Slice'<uint8> = __spiral_emit_rust 0uy v152 
            let v154 : string = "true; loop { // rust.loop 1"
            let v155 : bool = __spiral_emit_rust () v154 
            let v156 : string = "true; let mut v153 = v153"
            let v157 : bool = __spiral_emit_rust () v156 
            let v158 : string = "std::io::Read::read(&mut v132, &mut v153)"
            let v159 : Result<unativeint, std_io_Error> = __spiral_emit_rust () v158 
            let v160 : string = "$0.unwrap()"
            let v161 : unativeint = __spiral_emit_rust v159 v160 
            let v162 : bool = v161 = v151 
            let v165 : bool =
                if v162 then
                    let v163 : string = "true; break ()"
                    let v164 : bool = __spiral_emit_rust () v163 
                    true
                else
                    false
            let v166 : US39 = method130(v161)
            let v172 : US40 =
                match v166 with
                | US39_Error(v169) -> (* Error *)
                    US40_None
                | US39_Ok(v167) -> (* Ok *)
                    US40_Some(v167)
            let v176 : unativeint =
                match v172 with
                | US40_None -> (* None *)
                    failwith<unativeint> "Option does not have a value."
                | US40_Some(v173) -> (* Some *)
                    v173
            let v177 : unativeint = v176 |> unbox<unativeint>
            let v178 : string = "v153.len()"
            let v179 : unativeint = __spiral_emit_rust () v178 
            let v180 : bool = v177 = v179 
            let v185 : Ref<Slice'<uint8>> =
                if v180 then
                    let v181 : string = "&v153[v151..]"
                    let v182 : Ref<Slice'<uint8>> = __spiral_emit_rust () v181 
                    v182
                else
                    let v183 : string = "&v153[$0..$1]"
                    let v184 : Ref<Slice'<uint8>> = __spiral_emit_rust struct (v151, v176) v183 
                    v184
            let v186 : string = "true; sha2::Digest::update(&mut v138, v185)"
            let v187 : bool = __spiral_emit_rust () v186 
            let v188 : string = "true; } // rust.loop 3"
            let v189 : bool = __spiral_emit_rust () v188 
            let v190 : string = "&sha2::Digest::finalize(v138)"
            let v191 : Ref<Slice<uint8>> = __spiral_emit_rust () v190 
            let v192 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v193 : Vec<uint8> = __spiral_emit_rust v191 v192 
            let v194 : string = "$0.iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
            let v195 : Vec<string> = __spiral_emit_rust struct (v193, v83) v194 
            let v196 : (string []) = () // backend.backend_switch / record_type_try_find / key: v85 
            let v197 : string list = v196 |> Array.toList
            let v198 : ((string -> (UH0 -> UH0)) -> (string list -> (UH0 -> UH0))) = List.foldBack
            let v199 : (string -> (UH0 -> UH0)) = method131()
            let v200 : (string list -> (UH0 -> UH0)) = v198 v199
            let v201 : (UH0 -> UH0) = v200 v197
            let v202 : UH0 = UH0_Nil
            let v203 : UH0 = v201 v202
            let v204 : string = method132()
            let struct (v205 : string, v206 : string) = method133(v204, v203, v95)
            let v207 : Result<string, std_io_Error> = Ok v205 
            let v208 : (string -> US41) = method134()
            let v209 : (std_io_Error -> US41) = method135()
            let v210 : US41 = match v207 with Ok x -> v208 x | Error x -> v209 x
            let v217 : US42 =
                match v210 with
                | US41_Error(v213) -> (* Error *)
                    let v214 : std_string_String = null |> unbox<std_string_String>
                    US42_Error(v214)
                | US41_Ok(v211) -> (* Ok *)
                    US42_Ok(v211)
            let v223 : Result<string, std_string_String> =
                match v217 with
                | US42_Error(v220) -> (* Error *)
                    let v221 : Result<string, std_string_String> = Error v220 
                    v221
                | US42_Ok(v218) -> (* Ok *)
                    let v219 : Result<string, std_string_String> = Ok v218 
                    v219
            let v224 : (string -> US42) = method136()
            let v225 : (std_string_String -> US42) = method137()
            let v226 : US42 = match v223 with Ok x -> v224 x | Error x -> v225 x
            let v232 : string =
                match v226 with
                | US42_Error(v228) -> (* Error *)
                    let v229 : string = $"resultm.get / Error x: {v228}"
                    failwith<string> v229
                | US42_Ok(v227) -> (* Ok *)
                    v227
            let v233 : bool = v123 = v232
            v233
    if v234 then
        US38_None
    else
        let v236 : US43 = crowbook_148(v2, v5, v3, v1, v4)
        match v236 with
        | US43_Error(v314, v315) -> (* Error *)
            let v316 : (string * string) = v5, v315 
            let v317 : Result<string, (string * string)> = Error v316 
            US38_Some(v317)
        | US43_Ok(v237, v238) -> (* Ok *)
            let v239 : bool = v237 <> 0 
            if v239 then
                let v240 : bool = TraceState.trace_state.IsNone
                if v240 then
                    let v241 : US0 = US0_Verbose
                    let struct (v242 : Mut0, v243 : Mut1, v244 : Mut2, v245 : Mut3, v246 : Mut4, v247 : int64 option) = new_trace_state_1(v241)
                    let v248 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v242, v243, v244, v245, v246, v247) 
                    TraceState.trace_state <- v248 
                    ()
                let struct (v249 : Mut0, v250 : Mut1, v251 : Mut2, v252 : Mut3, v253 : Mut4, v254 : int64 option) = TraceState.trace_state.Value
                let v255 : US0 = v253.l0
                let v260 : int32 =
                    match v255 with
                    | US0_Critical -> (* Critical *)
                        50
                    | US0_Debug -> (* Debug *)
                        20
                    | US0_Info -> (* Info *)
                        30
                    | US0_Verbose -> (* Verbose *)
                        10
                    | US0_Warning -> (* Warning *)
                        40
                let v261 : bool = v251.l0
                let v262 : bool = v261 = false
                let v264 : bool =
                    if v262 then
                        false
                    else
                        let v263 : bool = 30 >= v260
                        v263
                let v265 : bool = v264 = false
                let v305 : US4 =
                    if v265 then
                        US4_None
                    else
                        let v267 : bool = TraceState.trace_state.IsNone
                        if v267 then
                            let v268 : US0 = US0_Verbose
                            let struct (v269 : Mut0, v270 : Mut1, v271 : Mut2, v272 : Mut3, v273 : Mut4, v274 : int64 option) = new_trace_state_1(v268)
                            let v275 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v269, v270, v271, v272, v273, v274) 
                            TraceState.trace_state <- v275 
                            ()
                        let struct (v276 : Mut0, v277 : Mut1, v278 : Mut2, v279 : Mut3, v280 : Mut4, v281 : int64 option) = TraceState.trace_state.Value
                        let v282 : string = method6(v276, v277, v278, v279, v280, v281)
                        let v283 : string = method9()
                        let v284 : string = method147(v276, v277, v278, v279, v280, v281, v282, v283, v237, v238)
                        let v285 : bool = TraceState.trace_state.IsNone
                        if v285 then
                            let v286 : US0 = US0_Verbose
                            let struct (v287 : Mut0, v288 : Mut1, v289 : Mut2, v290 : Mut3, v291 : Mut4, v292 : int64 option) = new_trace_state_1(v286)
                            let v293 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v287, v288, v289, v290, v291, v292) 
                            TraceState.trace_state <- v293 
                            ()
                        let struct (v294 : Mut0, v295 : Mut1, v296 : Mut2, v297 : Mut3, v298 : Mut4, v299 : int64 option) = TraceState.trace_state.Value
                        let v300 : int64 = v294.l0
                        let v301 : int64 = v300 + 1L
                        v294.l0 <- v301
                        let v302 : (string -> unit) = closure5()
                        v302 v284
                        let v303 : (string -> unit) = v295.l0
                        v303 v284
                        US4_Some(v294, v295, v296, v297, v298, v299)
                let v306 : (string * string) = v5, v238 
                let v307 : Result<string, (string * string)> = Error v306 
                US38_Some(v307)
            else
                let v309 : bool = file_exists_50(v5)
                if v309 then
                    file_copy_139(v6, v5)
                else
                    let v310 : string = $"documents.files_fn / {v5} should exist"
                    failwith<unit> v310
                let v311 : Result<string, (string * string)> = Ok v5 
                US38_Some(v311)
and closure91 (v0 : string, v1 : string, v2 : bool) (v3 : string) : (string -> US38) =
    closure92(v0, v1, v2, v3)
and method151 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_14(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "documents.run / par_map / files' = [] / listm.iter"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "output_path"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : string = v26 + v8 
    let v28 : string = "; "
    let v29 : string = v27 + v28 
    let v30 : string = "output_cache_path"
    let v31 : string = v29 + v30 
    let v32 : string = v31 + v25 
    let v33 : string = v32 + v9 
    let v34 : string = "{ "
    let v35 : string = v34 + v33 
    let v36 : string = " }"
    let v37 : string = v35 + v36 
    let v38 : string = v20 + v37 
    method17(v38)
and method152 (v0 : UH1, v1 : UH2 list) : UH2 list =
    match v0 with
    | UH1_Cons(v2, v3) -> (* Cons *)
        let v4 : UH2 list = method152(v3, v1)
        let v5 : UH2 list = v2 :: v4 
        v5
    | UH1_Nil -> (* Nil *)
        v1
and closure94 (v0 : UH2) (v1 : UH1) : UH1 =
    UH1_Cons(v0, v1)
and closure93 () (v0 : UH2) : (UH1 -> UH1) =
    closure94(v0)
and method153 () : (UH2 -> (UH1 -> UH1)) =
    closure93()
and method155 (v0 : UH2, v1 : struct (string * string * (string -> (string -> US38))) list) : struct (string * string * (string -> (string -> US38))) list =
    match v0 with
    | UH2_Cons(v2, v3, v4, v5) -> (* Cons *)
        let v6 : struct (string * string * (string -> (string -> US38))) list = method155(v5, v1)
        let v7 : struct (string * string * (string -> (string -> US38))) list = struct (v2, v3, v4) :: v6 
        v7
    | UH2_Nil -> (* Nil *)
        v1
and method157 (v0 : Result<string, (string * string)> option) : Result<string, (string * string)> option =
    v0
and method158 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and loop_156 (v0 : (struct (string * string * (string -> (string -> US38))) []), v1 : int32, v2 : int32, v3 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    let v4 : bool = v2 < v1
    if v4 then
        let v5 : int32 = v2 + 1
        let struct (v6 : string, v7 : string, v8 : (string -> (string -> US38))) = v0.[int v2]
        let v9 : (string -> US38) = v8 v7
        let v10 : US38 = v9 v6
        let v15 : Result<string, (string * string)> option =
            match v10 with
            | US38_None -> (* None *)
                let v13 : Result<string, (string * string)> option = None
                v13
            | US38_Some(v11) -> (* Some *)
                let v12 : Result<string, (string * string)> option = Some v11 
                v12
        let v16 : Result<string, (string * string)> option = method157(v15)
        let v17 : Vec<Result<string, (string * string)> option> = method158(v3)
        let v18 : string = "true; let mut v17 = v17"
        let v19 : bool = __spiral_emit_rust () v18 
        let v20 : string = "true; v17.push(v16)"
        let v21 : bool = __spiral_emit_rust () v20 
        let v22 : string = "v17"
        let v23 : Vec<Result<string, (string * string)> option> = __spiral_emit_rust () v22 
        loop_156(v0, v1, v5, v23)
    else
        v3
and method159 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and method160 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and method154 (v0 : UH1, v1 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    match v0 with
    | UH1_Cons(v2, v3) -> (* Cons *)
        let v4 : struct (string * string * (string -> (string -> US38))) list = []
        let v5 : struct (string * string * (string -> (string -> US38))) list = method155(v2, v4)
        let v6 : (struct (string * string * (string -> (string -> US38))) list -> (struct (string * string * (string -> (string -> US38))) [])) = List.toArray
        let v7 : (struct (string * string * (string -> (string -> US38))) []) = v6 v5
        let v8 : string = "Fsharp"
        let v9 : Vec<struct (string * string * (string -> (string -> US38)))> = () // backend.backend_switch / record_type_try_find / key: v8 
        let v10 : (struct (string * string * (string -> (string -> US38))) []) = () // backend.backend_switch / record_type_try_find / key: v8 
        let v11 : int32 = (v10.borrow().len() as i32)
        let v12 : int32 = 0
        let v13 : Vec<Result<string, (string * string)> option> = () // backend.backend_switch / record_type_try_find / key: v8 
        let v14 : Vec<Result<string, (string * string)> option> = loop_156(v10, v11, v12, v13)
        let v15 : (Result<string, (string * string)> option []) = () // backend.backend_switch / record_type_try_find / key: v8 
        let v16 : Vec<Result<string, (string * string)> option> = () // backend.backend_switch / record_type_try_find / key: v8 
        let v17 : Vec<Result<string, (string * string)> option> = method159(v16)
        let v18 : Vec<Result<string, (string * string)> option> = method160(v1)
        let v19 : string = "true; let mut v18 = v18"
        let v20 : bool = __spiral_emit_rust () v19 
        let v21 : string = "true; v18.extend(v17)"
        let v22 : bool = __spiral_emit_rust () v21 
        let v23 : string = "v18"
        let v24 : Vec<Result<string, (string * string)> option> = __spiral_emit_rust () v23 
        method154(v3, v24)
    | UH1_Nil -> (* Nil *)
        v1
and method161 (v0 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>) : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> =
    v0
and method162 (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> =
    v0
and loop_73 (v0 : bool, v1 : string, v2 : string, v3 : string, v4 : string, v5 : string, v6 : (string []), v7 : int32, v8 : int32, v9 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> =
    let v10 : bool = v8 < v7
    if v10 then
        let v11 : int32 = v8 + 1
        let v12 : string = v6.[int v8]
        let v13 : string = get_full_path_56(v12)
        let v14 : Ref<Str> = v13 |> unbox<Ref<Str>>
        let v15 : std_string_String = v14 |> unbox<std_string_String>
        let v16 : std_path_PathBuf = v15 |> unbox<std_path_PathBuf>
        let v17 : std_path_Display = v16 |> unbox<std_path_Display>
        let v18 : std_string_String = null |> unbox<std_string_String>
        let v19 : string = "Fsharp"
        let v20 : string = () // backend.backend_switch / record_type_try_find / key: v19 
        let v21 : string = method74()
        let v22 : string = v20.Replace (v4, v21)
        let v23 : string = "\\"
        let v24 : string = "/"
        let v25 : string = v22.Replace (v23, v24)
        let v26 : string = $".{v25}"
        let v27 : string = normalize_path_28(v13)
        let v28 : string = method43(v3, v26)
        let v29 : string = standardize_path_75(v28)
        let v30 : System.Threading.CancellationToken option = None
        let v31 : (struct (string * string) []) = [||]
        let v32 : (struct (int32 * string * bool) -> Async<unit>) option = None
        let v33 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
        let v34 : string option = None
        let v35 : string = $"git ls-tree --format='%%(objectname)' origin/gh-pages \"{v29}\""
        let v36 : string option = Some v3 
        let v37 : bool = true
        let v38 : bool = true
        let struct (v39 : int32, v40 : string) = execute_with_options_76(v35, v30, v31, v32, v33, v37, v36, v38)
        let v41 : string = method43(v4, v26)
        let v42 : string = standardize_path_75(v41)
        let v43 : System.Threading.CancellationToken option = None
        let v44 : (struct (string * string) []) = [||]
        let v45 : (struct (int32 * string * bool) -> Async<unit>) option = None
        let v46 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
        let v47 : string option = None
        let v48 : string = $"git hash-object \"{v42}\""
        let v49 : string option = Some v4 
        let v50 : bool = true
        let v51 : bool = true
        let struct (v52 : int32, v53 : string) = execute_with_options_76(v48, v43, v44, v45, v46, v50, v49, v51)
        let v54 : string = method43(v5, v26)
        let v55 : string = standardize_path_75(v54)
        let v56 : string = "hangul.md"
        let struct (v57 : string, v58 : string) = fix_paths_128(v56, v42, v5)
        let v59 : bool = false
        let v60 : bool = false
        let v61 : bool = false
        let v62 : bool = true
        let v63 : bool = true
        let v64 : bool = true
        let v65 : bool = v40.Contains v53 
        let v486 : UH1 =
            if v65 then
                UH1_Nil
            else
                let v67 : string = normalize_path_28(v42)
                let v68 : string = "std::fs::File::open(&*v67)"
                let v69 : Result<std_fs_File, std_io_Error> = __spiral_emit_rust () v68 
                let v70 : string = "$0.unwrap()"
                let v71 : std_fs_File = __spiral_emit_rust v69 v70 
                let v72 : string = "std::io::BufReader::new($0)"
                let v73 : std_io_BufReader<std_fs_File> = __spiral_emit_rust v71 v72 
                let v74 : string = "std::io::BufReader::new($0)"
                let v75 : std_io_BufReader<std_io_BufReader<std_fs_File>> = __spiral_emit_rust v73 v74 
                let v76 : string = "true; let mut v75 = v75"
                let v77 : bool = __spiral_emit_rust () v76 
                let v78 : string = "true; let result : sha2::Sha256 = sha2::Digest::new()"
                let v79 : bool = __spiral_emit_rust () v78 
                let v80 : string = "result"
                let v81 : sha2_Sha256 = __spiral_emit_rust () v80 
                let v82 : string = "true; let mut v81 = v81"
                let v83 : bool = __spiral_emit_rust () v82 
                let v84 : US39 = method129()
                let v90 : US40 =
                    match v84 with
                    | US39_Error(v87) -> (* Error *)
                        US40_None
                    | US39_Ok(v85) -> (* Ok *)
                        US40_Some(v85)
                let v94 : unativeint =
                    match v90 with
                    | US40_None -> (* None *)
                        failwith<unativeint> "Option does not have a value."
                    | US40_Some(v91) -> (* Some *)
                        v91
                let v95 : string = "[$0; 1024 as usize]"
                let v96 : Slice'<uint8> = __spiral_emit_rust 0uy v95 
                let v97 : string = "true; loop { // rust.loop 1"
                let v98 : bool = __spiral_emit_rust () v97 
                let v99 : string = "true; let mut v96 = v96"
                let v100 : bool = __spiral_emit_rust () v99 
                let v101 : string = "std::io::Read::read(&mut v75, &mut v96)"
                let v102 : Result<unativeint, std_io_Error> = __spiral_emit_rust () v101 
                let v103 : string = "$0.unwrap()"
                let v104 : unativeint = __spiral_emit_rust v102 v103 
                let v105 : bool = v104 = v94 
                let v108 : bool =
                    if v105 then
                        let v106 : string = "true; break ()"
                        let v107 : bool = __spiral_emit_rust () v106 
                        true
                    else
                        false
                let v109 : US39 = method130(v104)
                let v115 : US40 =
                    match v109 with
                    | US39_Error(v112) -> (* Error *)
                        US40_None
                    | US39_Ok(v110) -> (* Ok *)
                        US40_Some(v110)
                let v119 : unativeint =
                    match v115 with
                    | US40_None -> (* None *)
                        failwith<unativeint> "Option does not have a value."
                    | US40_Some(v116) -> (* Some *)
                        v116
                let v120 : unativeint = v119 |> unbox<unativeint>
                let v121 : string = "v96.len()"
                let v122 : unativeint = __spiral_emit_rust () v121 
                let v123 : bool = v120 = v122 
                let v128 : Ref<Slice'<uint8>> =
                    if v123 then
                        let v124 : string = "&v96[v94..]"
                        let v125 : Ref<Slice'<uint8>> = __spiral_emit_rust () v124 
                        v125
                    else
                        let v126 : string = "&v96[$0..$1]"
                        let v127 : Ref<Slice'<uint8>> = __spiral_emit_rust struct (v94, v119) v126 
                        v127
                let v129 : string = "true; sha2::Digest::update(&mut v81, v128)"
                let v130 : bool = __spiral_emit_rust () v129 
                let v131 : string = "true; } // rust.loop 3"
                let v132 : bool = __spiral_emit_rust () v131 
                let v133 : string = "&sha2::Digest::finalize(v81)"
                let v134 : Ref<Slice<uint8>> = __spiral_emit_rust () v133 
                let v135 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
                let v136 : Vec<uint8> = __spiral_emit_rust v134 v135 
                let v137 : string = "$0.iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
                let v138 : ((uint8) -> string) = closure81()
                let v139 : Vec<string> = __spiral_emit_rust struct (v136, v138) v137 
                let v140 : (string []) = () // backend.backend_switch / record_type_try_find / key: v19 
                let v141 : string list = v140 |> Array.toList
                let v142 : ((string -> (UH0 -> UH0)) -> (string list -> (UH0 -> UH0))) = List.foldBack
                let v143 : (string -> (UH0 -> UH0)) = method131()
                let v144 : (string list -> (UH0 -> UH0)) = v142 v143
                let v145 : (UH0 -> UH0) = v144 v141
                let v146 : UH0 = UH0_Nil
                let v147 : UH0 = v145 v146
                let v148 : string = method132()
                let v149 : string = ""
                let struct (v150 : string, v151 : string) = method133(v148, v147, v149)
                let v152 : Result<string, std_io_Error> = Ok v150 
                let v153 : (string -> US41) = method134()
                let v154 : (std_io_Error -> US41) = method135()
                let v155 : US41 = match v152 with Ok x -> v153 x | Error x -> v154 x
                let v162 : US42 =
                    match v155 with
                    | US41_Error(v158) -> (* Error *)
                        let v159 : std_string_String = null |> unbox<std_string_String>
                        US42_Error(v159)
                    | US41_Ok(v156) -> (* Ok *)
                        US42_Ok(v156)
                let v168 : Result<string, std_string_String> =
                    match v162 with
                    | US42_Error(v165) -> (* Error *)
                        let v166 : Result<string, std_string_String> = Error v165 
                        v166
                    | US42_Ok(v163) -> (* Ok *)
                        let v164 : Result<string, std_string_String> = Ok v163 
                        v164
                let v169 : (string -> US42) = method136()
                let v170 : (std_string_String -> US42) = method137()
                let v171 : US42 = match v168 with Ok x -> v169 x | Error x -> v170 x
                let v177 : string =
                    match v171 with
                    | US42_Error(v173) -> (* Error *)
                        let v174 : string = $"resultm.get / Error x: {v173}"
                        failwith<string> v174
                    | US42_Ok(v172) -> (* Ok *)
                        v172
                let v178 : bool = file_exists_50(v55)
                let v179 : bool = v178 = false
                let v290 : US3 =
                    if v179 then
                        US3_None
                    else
                        let v181 : string = normalize_path_28(v55)
                        let v182 : string = "std::fs::File::open(&*v181)"
                        let v183 : Result<std_fs_File, std_io_Error> = __spiral_emit_rust () v182 
                        let v184 : string = "$0.unwrap()"
                        let v185 : std_fs_File = __spiral_emit_rust v183 v184 
                        let v186 : string = "std::io::BufReader::new($0)"
                        let v187 : std_io_BufReader<std_fs_File> = __spiral_emit_rust v185 v186 
                        let v188 : string = "std::io::BufReader::new($0)"
                        let v189 : std_io_BufReader<std_io_BufReader<std_fs_File>> = __spiral_emit_rust v187 v188 
                        let v190 : string = "true; let mut v189 = v189"
                        let v191 : bool = __spiral_emit_rust () v190 
                        let v192 : string = "true; let result : sha2::Sha256 = sha2::Digest::new()"
                        let v193 : bool = __spiral_emit_rust () v192 
                        let v194 : string = "result"
                        let v195 : sha2_Sha256 = __spiral_emit_rust () v194 
                        let v196 : string = "true; let mut v195 = v195"
                        let v197 : bool = __spiral_emit_rust () v196 
                        let v198 : US39 = method129()
                        let v204 : US40 =
                            match v198 with
                            | US39_Error(v201) -> (* Error *)
                                US40_None
                            | US39_Ok(v199) -> (* Ok *)
                                US40_Some(v199)
                        let v208 : unativeint =
                            match v204 with
                            | US40_None -> (* None *)
                                failwith<unativeint> "Option does not have a value."
                            | US40_Some(v205) -> (* Some *)
                                v205
                        let v209 : string = "[$0; 1024 as usize]"
                        let v210 : Slice'<uint8> = __spiral_emit_rust 0uy v209 
                        let v211 : string = "true; loop { // rust.loop 1"
                        let v212 : bool = __spiral_emit_rust () v211 
                        let v213 : string = "true; let mut v210 = v210"
                        let v214 : bool = __spiral_emit_rust () v213 
                        let v215 : string = "std::io::Read::read(&mut v189, &mut v210)"
                        let v216 : Result<unativeint, std_io_Error> = __spiral_emit_rust () v215 
                        let v217 : string = "$0.unwrap()"
                        let v218 : unativeint = __spiral_emit_rust v216 v217 
                        let v219 : bool = v218 = v208 
                        let v222 : bool =
                            if v219 then
                                let v220 : string = "true; break ()"
                                let v221 : bool = __spiral_emit_rust () v220 
                                true
                            else
                                false
                        let v223 : US39 = method130(v218)
                        let v229 : US40 =
                            match v223 with
                            | US39_Error(v226) -> (* Error *)
                                US40_None
                            | US39_Ok(v224) -> (* Ok *)
                                US40_Some(v224)
                        let v233 : unativeint =
                            match v229 with
                            | US40_None -> (* None *)
                                failwith<unativeint> "Option does not have a value."
                            | US40_Some(v230) -> (* Some *)
                                v230
                        let v234 : unativeint = v233 |> unbox<unativeint>
                        let v235 : string = "v210.len()"
                        let v236 : unativeint = __spiral_emit_rust () v235 
                        let v237 : bool = v234 = v236 
                        let v242 : Ref<Slice'<uint8>> =
                            if v237 then
                                let v238 : string = "&v210[v208..]"
                                let v239 : Ref<Slice'<uint8>> = __spiral_emit_rust () v238 
                                v239
                            else
                                let v240 : string = "&v210[$0..$1]"
                                let v241 : Ref<Slice'<uint8>> = __spiral_emit_rust struct (v208, v233) v240 
                                v241
                        let v243 : string = "true; sha2::Digest::update(&mut v195, v242)"
                        let v244 : bool = __spiral_emit_rust () v243 
                        let v245 : string = "true; } // rust.loop 3"
                        let v246 : bool = __spiral_emit_rust () v245 
                        let v247 : string = "&sha2::Digest::finalize(v195)"
                        let v248 : Ref<Slice<uint8>> = __spiral_emit_rust () v247 
                        let v249 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
                        let v250 : Vec<uint8> = __spiral_emit_rust v248 v249 
                        let v251 : string = "$0.iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
                        let v252 : Vec<string> = __spiral_emit_rust struct (v250, v138) v251 
                        let v253 : (string []) = () // backend.backend_switch / record_type_try_find / key: v19 
                        let v254 : string list = v253 |> Array.toList
                        let v255 : ((string -> (UH0 -> UH0)) -> (string list -> (UH0 -> UH0))) = List.foldBack
                        let v256 : (string -> (UH0 -> UH0)) = method131()
                        let v257 : (string list -> (UH0 -> UH0)) = v255 v256
                        let v258 : (UH0 -> UH0) = v257 v254
                        let v259 : UH0 = UH0_Nil
                        let v260 : UH0 = v258 v259
                        let v261 : string = method132()
                        let struct (v262 : string, v263 : string) = method133(v261, v260, v149)
                        let v264 : Result<string, std_io_Error> = Ok v262 
                        let v265 : (string -> US41) = method134()
                        let v266 : (std_io_Error -> US41) = method135()
                        let v267 : US41 = match v264 with Ok x -> v265 x | Error x -> v266 x
                        let v274 : US42 =
                            match v267 with
                            | US41_Error(v270) -> (* Error *)
                                let v271 : std_string_String = null |> unbox<std_string_String>
                                US42_Error(v271)
                            | US41_Ok(v268) -> (* Ok *)
                                US42_Ok(v268)
                        let v280 : Result<string, std_string_String> =
                            match v274 with
                            | US42_Error(v277) -> (* Error *)
                                let v278 : Result<string, std_string_String> = Error v277 
                                v278
                            | US42_Ok(v275) -> (* Ok *)
                                let v276 : Result<string, std_string_String> = Ok v275 
                                v276
                        let v281 : (string -> US42) = method136()
                        let v282 : (std_string_String -> US42) = method137()
                        let v283 : US42 = match v280 with Ok x -> v281 x | Error x -> v282 x
                        match v283 with
                        | US42_Error(v286) -> (* Error *)
                            US3_None
                        | US42_Ok(v284) -> (* Ok *)
                            US3_Some(v284)
                match v290 with
                | US3_Some(v291) -> (* Some *)
                    let v292 : bool = v177 = v291
                    if v292 then
                        UH1_Nil
                    else
                        let v294 : bool = TraceState.trace_state.IsNone
                        if v294 then
                            let v295 : US0 = US0_Verbose
                            let struct (v296 : Mut0, v297 : Mut1, v298 : Mut2, v299 : Mut3, v300 : Mut4, v301 : int64 option) = new_trace_state_1(v295)
                            let v302 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v296, v297, v298, v299, v300, v301) 
                            TraceState.trace_state <- v302 
                            ()
                        let struct (v303 : Mut0, v304 : Mut1, v305 : Mut2, v306 : Mut3, v307 : Mut4, v308 : int64 option) = TraceState.trace_state.Value
                        let v309 : US0 = v307.l0
                        let v314 : int32 =
                            match v309 with
                            | US0_Critical -> (* Critical *)
                                50
                            | US0_Debug -> (* Debug *)
                                20
                            | US0_Info -> (* Info *)
                                30
                            | US0_Verbose -> (* Verbose *)
                                10
                            | US0_Warning -> (* Warning *)
                                40
                        let v315 : bool = v305.l0
                        let v316 : bool = v315 = false
                        let v318 : bool =
                            if v316 then
                                false
                            else
                                let v317 : bool = 30 >= v314
                                v317
                        let v319 : bool = v318 = false
                        let v366 : US4 =
                            if v319 then
                                US4_None
                            else
                                let v321 : bool = TraceState.trace_state.IsNone
                                if v321 then
                                    let v322 : US0 = US0_Verbose
                                    let struct (v323 : Mut0, v324 : Mut1, v325 : Mut2, v326 : Mut3, v327 : Mut4, v328 : int64 option) = new_trace_state_1(v322)
                                    let v329 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v323, v324, v325, v326, v327, v328) 
                                    TraceState.trace_state <- v329 
                                    ()
                                let struct (v330 : Mut0, v331 : Mut1, v332 : Mut2, v333 : Mut3, v334 : Mut4, v335 : int64 option) = TraceState.trace_state.Value
                                let v336 : string = method6(v330, v331, v332, v333, v334, v335)
                                let v337 : string = method9()
                                let v338 : string = "documents.run / par_map"
                                let v339 : string = " / origin_hash |> sm'.contains local_git_hash |> not"
                                let v340 : string = v338 + v339 
                                let v341 : string = " / Some hash2 when hash1 = hash2"
                                let v342 : string = v340 + v341 
                                let v343 : bool = v342 = ""
                                let v345 : string =
                                    if v343 then
                                        v149
                                    else
                                        method138(v330, v331, v332, v333, v334, v335, v336, v337, v342, v27, v29, v26, v39, v40, v52, v53, v177, v290, v42, v55)
                                let v346 : bool = TraceState.trace_state.IsNone
                                if v346 then
                                    let v347 : US0 = US0_Verbose
                                    let struct (v348 : Mut0, v349 : Mut1, v350 : Mut2, v351 : Mut3, v352 : Mut4, v353 : int64 option) = new_trace_state_1(v347)
                                    let v354 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v348, v349, v350, v351, v352, v353) 
                                    TraceState.trace_state <- v354 
                                    ()
                                let struct (v355 : Mut0, v356 : Mut1, v357 : Mut2, v358 : Mut3, v359 : Mut4, v360 : int64 option) = TraceState.trace_state.Value
                                let v361 : int64 = v355.l0
                                let v362 : int64 = v361 + 1L
                                v355.l0 <- v362
                                let v363 : (string -> unit) = closure5()
                                v363 v345
                                let v364 : (string -> unit) = v356.l0
                                v364 v345
                                US4_Some(v355, v356, v357, v358, v359, v360)
                        file_copy_139(v55, v42)
                        let v367 : (string -> (string -> US38)) = closure88(v5, v4, v2, v1, v0)
                        let v368 : UH2 = UH2_Nil
                        let v369 : UH2 = UH2_Cons(v56, v42, v367, v368)
                        let v370 : string = "html"
                        let v371 : (string -> (string -> US38)) = closure91(v5, v4, v59)
                        let v372 : string = "pdf"
                        let v373 : (string -> (string -> US38)) = closure91(v5, v4, v60)
                        let v374 : string = "epub"
                        let v375 : (string -> (string -> US38)) = closure91(v5, v4, v61)
                        let v376 : (string -> (string -> US38)) = closure91(v5, v4, v62)
                        let v377 : (string -> (string -> US38)) = closure91(v5, v4, v63)
                        let v378 : (string -> (string -> US38)) = closure91(v5, v4, v64)
                        let v379 : UH2 = UH2_Nil
                        let v380 : UH2 = UH2_Cons(v374, v57, v378, v379)
                        let v381 : UH2 = UH2_Cons(v372, v57, v377, v380)
                        let v382 : UH2 = UH2_Cons(v370, v57, v376, v381)
                        let v383 : UH2 = UH2_Cons(v374, v42, v375, v382)
                        let v384 : UH2 = UH2_Cons(v372, v42, v373, v383)
                        let v385 : UH2 = UH2_Cons(v370, v42, v371, v384)
                        let v386 : UH1 = UH1_Nil
                        let v387 : UH1 = UH1_Cons(v385, v386)
                        UH1_Cons(v369, v387)
                | _ ->
                    let v390 : bool = TraceState.trace_state.IsNone
                    if v390 then
                        let v391 : US0 = US0_Verbose
                        let struct (v392 : Mut0, v393 : Mut1, v394 : Mut2, v395 : Mut3, v396 : Mut4, v397 : int64 option) = new_trace_state_1(v391)
                        let v398 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v392, v393, v394, v395, v396, v397) 
                        TraceState.trace_state <- v398 
                        ()
                    let struct (v399 : Mut0, v400 : Mut1, v401 : Mut2, v402 : Mut3, v403 : Mut4, v404 : int64 option) = TraceState.trace_state.Value
                    let v405 : US0 = v403.l0
                    let v410 : int32 =
                        match v405 with
                        | US0_Critical -> (* Critical *)
                            50
                        | US0_Debug -> (* Debug *)
                            20
                        | US0_Info -> (* Info *)
                            30
                        | US0_Verbose -> (* Verbose *)
                            10
                        | US0_Warning -> (* Warning *)
                            40
                    let v411 : bool = v401.l0
                    let v412 : bool = v411 = false
                    let v414 : bool =
                        if v412 then
                            false
                        else
                            let v413 : bool = 30 >= v410
                            v413
                    let v415 : bool = v414 = false
                    let v462 : US4 =
                        if v415 then
                            US4_None
                        else
                            let v417 : bool = TraceState.trace_state.IsNone
                            if v417 then
                                let v418 : US0 = US0_Verbose
                                let struct (v419 : Mut0, v420 : Mut1, v421 : Mut2, v422 : Mut3, v423 : Mut4, v424 : int64 option) = new_trace_state_1(v418)
                                let v425 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v419, v420, v421, v422, v423, v424) 
                                TraceState.trace_state <- v425 
                                ()
                            let struct (v426 : Mut0, v427 : Mut1, v428 : Mut2, v429 : Mut3, v430 : Mut4, v431 : int64 option) = TraceState.trace_state.Value
                            let v432 : string = method6(v426, v427, v428, v429, v430, v431)
                            let v433 : string = method9()
                            let v434 : string = "documents.run / par_map"
                            let v435 : string = " / origin_hash |> sm'.contains local_git_hash |> not"
                            let v436 : string = v434 + v435 
                            let v437 : string = " / Some hash2 when hash1 = hash2"
                            let v438 : string = v436 + v437 
                            let v439 : bool = v438 = ""
                            let v441 : string =
                                if v439 then
                                    v149
                                else
                                    method138(v426, v427, v428, v429, v430, v431, v432, v433, v438, v27, v29, v26, v39, v40, v52, v53, v177, v290, v42, v55)
                            let v442 : bool = TraceState.trace_state.IsNone
                            if v442 then
                                let v443 : US0 = US0_Verbose
                                let struct (v444 : Mut0, v445 : Mut1, v446 : Mut2, v447 : Mut3, v448 : Mut4, v449 : int64 option) = new_trace_state_1(v443)
                                let v450 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v444, v445, v446, v447, v448, v449) 
                                TraceState.trace_state <- v450 
                                ()
                            let struct (v451 : Mut0, v452 : Mut1, v453 : Mut2, v454 : Mut3, v455 : Mut4, v456 : int64 option) = TraceState.trace_state.Value
                            let v457 : int64 = v451.l0
                            let v458 : int64 = v457 + 1L
                            v451.l0 <- v458
                            let v459 : (string -> unit) = closure5()
                            v459 v441
                            let v460 : (string -> unit) = v452.l0
                            v460 v441
                            US4_Some(v451, v452, v453, v454, v455, v456)
                    file_copy_139(v55, v42)
                    let v463 : (string -> (string -> US38)) = closure88(v5, v4, v2, v1, v0)
                    let v464 : UH2 = UH2_Nil
                    let v465 : UH2 = UH2_Cons(v56, v42, v463, v464)
                    let v466 : string = "html"
                    let v467 : (string -> (string -> US38)) = closure91(v5, v4, v59)
                    let v468 : string = "pdf"
                    let v469 : (string -> (string -> US38)) = closure91(v5, v4, v60)
                    let v470 : string = "epub"
                    let v471 : (string -> (string -> US38)) = closure91(v5, v4, v61)
                    let v472 : (string -> (string -> US38)) = closure91(v5, v4, v62)
                    let v473 : (string -> (string -> US38)) = closure91(v5, v4, v63)
                    let v474 : (string -> (string -> US38)) = closure91(v5, v4, v64)
                    let v475 : UH2 = UH2_Nil
                    let v476 : UH2 = UH2_Cons(v470, v57, v474, v475)
                    let v477 : UH2 = UH2_Cons(v468, v57, v473, v476)
                    let v478 : UH2 = UH2_Cons(v466, v57, v472, v477)
                    let v479 : UH2 = UH2_Cons(v470, v42, v471, v478)
                    let v480 : UH2 = UH2_Cons(v468, v42, v469, v479)
                    let v481 : UH2 = UH2_Cons(v466, v42, v467, v480)
                    let v482 : UH1 = UH1_Nil
                    let v483 : UH1 = UH1_Cons(v481, v482)
                    UH1_Cons(v465, v483)
        let v487 : bool =
            match v486 with
            | UH1_Nil -> (* Nil *)
                true
            | _ ->
                false
        let v488 : bool = v487 <> true
        let v1031 : UH1 =
            if v488 then
                v486
            else
                let v489 : string = "epub"
                let struct (v490 : string, v491 : string) = fix_paths_128(v489, v57, v5)
                let v492 : bool = file_exists_50(v490)
                let v562 : bool =
                    if v492 then
                        true
                    else
                        let v493 : bool = file_exists_50(v491)
                        let v494 : bool = v493 = false
                        if v494 then
                            true
                        else
                            let v495 : bool = TraceState.trace_state.IsNone
                            if v495 then
                                let v496 : US0 = US0_Verbose
                                let struct (v497 : Mut0, v498 : Mut1, v499 : Mut2, v500 : Mut3, v501 : Mut4, v502 : int64 option) = new_trace_state_1(v496)
                                let v503 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v497, v498, v499, v500, v501, v502) 
                                TraceState.trace_state <- v503 
                                ()
                            let struct (v504 : Mut0, v505 : Mut1, v506 : Mut2, v507 : Mut3, v508 : Mut4, v509 : int64 option) = TraceState.trace_state.Value
                            let v510 : US0 = v508.l0
                            let v515 : int32 =
                                match v510 with
                                | US0_Critical -> (* Critical *)
                                    50
                                | US0_Debug -> (* Debug *)
                                    20
                                | US0_Info -> (* Info *)
                                    30
                                | US0_Verbose -> (* Verbose *)
                                    10
                                | US0_Warning -> (* Warning *)
                                    40
                            let v516 : bool = v506.l0
                            let v517 : bool = v516 = false
                            let v519 : bool =
                                if v517 then
                                    false
                                else
                                    let v518 : bool = 30 >= v515
                                    v518
                            let v520 : bool = v519 = false
                            let v560 : US4 =
                                if v520 then
                                    US4_None
                                else
                                    let v522 : bool = TraceState.trace_state.IsNone
                                    if v522 then
                                        let v523 : US0 = US0_Verbose
                                        let struct (v524 : Mut0, v525 : Mut1, v526 : Mut2, v527 : Mut3, v528 : Mut4, v529 : int64 option) = new_trace_state_1(v523)
                                        let v530 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v524, v525, v526, v527, v528, v529) 
                                        TraceState.trace_state <- v530 
                                        ()
                                    let struct (v531 : Mut0, v532 : Mut1, v533 : Mut2, v534 : Mut3, v535 : Mut4, v536 : int64 option) = TraceState.trace_state.Value
                                    let v537 : string = method6(v531, v532, v533, v534, v535, v536)
                                    let v538 : string = method9()
                                    let v539 : string = method151(v531, v532, v533, v534, v535, v536, v537, v538, v490, v491)
                                    let v540 : bool = TraceState.trace_state.IsNone
                                    if v540 then
                                        let v541 : US0 = US0_Verbose
                                        let struct (v542 : Mut0, v543 : Mut1, v544 : Mut2, v545 : Mut3, v546 : Mut4, v547 : int64 option) = new_trace_state_1(v541)
                                        let v548 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v542, v543, v544, v545, v546, v547) 
                                        TraceState.trace_state <- v548 
                                        ()
                                    let struct (v549 : Mut0, v550 : Mut1, v551 : Mut2, v552 : Mut3, v553 : Mut4, v554 : int64 option) = TraceState.trace_state.Value
                                    let v555 : int64 = v549.l0
                                    let v556 : int64 = v555 + 1L
                                    v549.l0 <- v556
                                    let v557 : (string -> unit) = closure5()
                                    v557 v539
                                    let v558 : (string -> unit) = v550.l0
                                    v558 v539
                                    US4_Some(v549, v550, v551, v552, v553, v554)
                            file_copy_139(v490, v491)
                            false
                let v567 : UH2 =
                    if v562 then
                        let v563 : (string -> (string -> US38)) = closure91(v5, v4, v64)
                        let v564 : UH2 = UH2_Nil
                        UH2_Cons(v489, v57, v563, v564)
                    else
                        UH2_Nil
                let v568 : string = "pdf"
                let struct (v569 : string, v570 : string) = fix_paths_128(v568, v57, v5)
                let v571 : bool = file_exists_50(v569)
                let v641 : bool =
                    if v571 then
                        true
                    else
                        let v572 : bool = file_exists_50(v570)
                        let v573 : bool = v572 = false
                        if v573 then
                            true
                        else
                            let v574 : bool = TraceState.trace_state.IsNone
                            if v574 then
                                let v575 : US0 = US0_Verbose
                                let struct (v576 : Mut0, v577 : Mut1, v578 : Mut2, v579 : Mut3, v580 : Mut4, v581 : int64 option) = new_trace_state_1(v575)
                                let v582 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v576, v577, v578, v579, v580, v581) 
                                TraceState.trace_state <- v582 
                                ()
                            let struct (v583 : Mut0, v584 : Mut1, v585 : Mut2, v586 : Mut3, v587 : Mut4, v588 : int64 option) = TraceState.trace_state.Value
                            let v589 : US0 = v587.l0
                            let v594 : int32 =
                                match v589 with
                                | US0_Critical -> (* Critical *)
                                    50
                                | US0_Debug -> (* Debug *)
                                    20
                                | US0_Info -> (* Info *)
                                    30
                                | US0_Verbose -> (* Verbose *)
                                    10
                                | US0_Warning -> (* Warning *)
                                    40
                            let v595 : bool = v585.l0
                            let v596 : bool = v595 = false
                            let v598 : bool =
                                if v596 then
                                    false
                                else
                                    let v597 : bool = 30 >= v594
                                    v597
                            let v599 : bool = v598 = false
                            let v639 : US4 =
                                if v599 then
                                    US4_None
                                else
                                    let v601 : bool = TraceState.trace_state.IsNone
                                    if v601 then
                                        let v602 : US0 = US0_Verbose
                                        let struct (v603 : Mut0, v604 : Mut1, v605 : Mut2, v606 : Mut3, v607 : Mut4, v608 : int64 option) = new_trace_state_1(v602)
                                        let v609 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v603, v604, v605, v606, v607, v608) 
                                        TraceState.trace_state <- v609 
                                        ()
                                    let struct (v610 : Mut0, v611 : Mut1, v612 : Mut2, v613 : Mut3, v614 : Mut4, v615 : int64 option) = TraceState.trace_state.Value
                                    let v616 : string = method6(v610, v611, v612, v613, v614, v615)
                                    let v617 : string = method9()
                                    let v618 : string = method151(v610, v611, v612, v613, v614, v615, v616, v617, v569, v570)
                                    let v619 : bool = TraceState.trace_state.IsNone
                                    if v619 then
                                        let v620 : US0 = US0_Verbose
                                        let struct (v621 : Mut0, v622 : Mut1, v623 : Mut2, v624 : Mut3, v625 : Mut4, v626 : int64 option) = new_trace_state_1(v620)
                                        let v627 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v621, v622, v623, v624, v625, v626) 
                                        TraceState.trace_state <- v627 
                                        ()
                                    let struct (v628 : Mut0, v629 : Mut1, v630 : Mut2, v631 : Mut3, v632 : Mut4, v633 : int64 option) = TraceState.trace_state.Value
                                    let v634 : int64 = v628.l0
                                    let v635 : int64 = v634 + 1L
                                    v628.l0 <- v635
                                    let v636 : (string -> unit) = closure5()
                                    v636 v618
                                    let v637 : (string -> unit) = v629.l0
                                    v637 v618
                                    US4_Some(v628, v629, v630, v631, v632, v633)
                            file_copy_139(v569, v570)
                            false
                let v644 : UH2 =
                    if v641 then
                        let v642 : (string -> (string -> US38)) = closure91(v5, v4, v63)
                        UH2_Cons(v568, v57, v642, v567)
                    else
                        v567
                let v645 : string = "html"
                let struct (v646 : string, v647 : string) = fix_paths_128(v645, v57, v5)
                let v648 : bool = file_exists_50(v646)
                let v718 : bool =
                    if v648 then
                        true
                    else
                        let v649 : bool = file_exists_50(v647)
                        let v650 : bool = v649 = false
                        if v650 then
                            true
                        else
                            let v651 : bool = TraceState.trace_state.IsNone
                            if v651 then
                                let v652 : US0 = US0_Verbose
                                let struct (v653 : Mut0, v654 : Mut1, v655 : Mut2, v656 : Mut3, v657 : Mut4, v658 : int64 option) = new_trace_state_1(v652)
                                let v659 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v653, v654, v655, v656, v657, v658) 
                                TraceState.trace_state <- v659 
                                ()
                            let struct (v660 : Mut0, v661 : Mut1, v662 : Mut2, v663 : Mut3, v664 : Mut4, v665 : int64 option) = TraceState.trace_state.Value
                            let v666 : US0 = v664.l0
                            let v671 : int32 =
                                match v666 with
                                | US0_Critical -> (* Critical *)
                                    50
                                | US0_Debug -> (* Debug *)
                                    20
                                | US0_Info -> (* Info *)
                                    30
                                | US0_Verbose -> (* Verbose *)
                                    10
                                | US0_Warning -> (* Warning *)
                                    40
                            let v672 : bool = v662.l0
                            let v673 : bool = v672 = false
                            let v675 : bool =
                                if v673 then
                                    false
                                else
                                    let v674 : bool = 30 >= v671
                                    v674
                            let v676 : bool = v675 = false
                            let v716 : US4 =
                                if v676 then
                                    US4_None
                                else
                                    let v678 : bool = TraceState.trace_state.IsNone
                                    if v678 then
                                        let v679 : US0 = US0_Verbose
                                        let struct (v680 : Mut0, v681 : Mut1, v682 : Mut2, v683 : Mut3, v684 : Mut4, v685 : int64 option) = new_trace_state_1(v679)
                                        let v686 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v680, v681, v682, v683, v684, v685) 
                                        TraceState.trace_state <- v686 
                                        ()
                                    let struct (v687 : Mut0, v688 : Mut1, v689 : Mut2, v690 : Mut3, v691 : Mut4, v692 : int64 option) = TraceState.trace_state.Value
                                    let v693 : string = method6(v687, v688, v689, v690, v691, v692)
                                    let v694 : string = method9()
                                    let v695 : string = method151(v687, v688, v689, v690, v691, v692, v693, v694, v646, v647)
                                    let v696 : bool = TraceState.trace_state.IsNone
                                    if v696 then
                                        let v697 : US0 = US0_Verbose
                                        let struct (v698 : Mut0, v699 : Mut1, v700 : Mut2, v701 : Mut3, v702 : Mut4, v703 : int64 option) = new_trace_state_1(v697)
                                        let v704 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v698, v699, v700, v701, v702, v703) 
                                        TraceState.trace_state <- v704 
                                        ()
                                    let struct (v705 : Mut0, v706 : Mut1, v707 : Mut2, v708 : Mut3, v709 : Mut4, v710 : int64 option) = TraceState.trace_state.Value
                                    let v711 : int64 = v705.l0
                                    let v712 : int64 = v711 + 1L
                                    v705.l0 <- v712
                                    let v713 : (string -> unit) = closure5()
                                    v713 v695
                                    let v714 : (string -> unit) = v706.l0
                                    v714 v695
                                    US4_Some(v705, v706, v707, v708, v709, v710)
                            file_copy_139(v646, v647)
                            false
                let v721 : UH2 =
                    if v718 then
                        let v719 : (string -> (string -> US38)) = closure91(v5, v4, v62)
                        UH2_Cons(v645, v57, v719, v644)
                    else
                        v644
                let struct (v722 : string, v723 : string) = fix_paths_128(v489, v42, v5)
                let v724 : bool = file_exists_50(v722)
                let v794 : bool =
                    if v724 then
                        true
                    else
                        let v725 : bool = file_exists_50(v723)
                        let v726 : bool = v725 = false
                        if v726 then
                            true
                        else
                            let v727 : bool = TraceState.trace_state.IsNone
                            if v727 then
                                let v728 : US0 = US0_Verbose
                                let struct (v729 : Mut0, v730 : Mut1, v731 : Mut2, v732 : Mut3, v733 : Mut4, v734 : int64 option) = new_trace_state_1(v728)
                                let v735 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v729, v730, v731, v732, v733, v734) 
                                TraceState.trace_state <- v735 
                                ()
                            let struct (v736 : Mut0, v737 : Mut1, v738 : Mut2, v739 : Mut3, v740 : Mut4, v741 : int64 option) = TraceState.trace_state.Value
                            let v742 : US0 = v740.l0
                            let v747 : int32 =
                                match v742 with
                                | US0_Critical -> (* Critical *)
                                    50
                                | US0_Debug -> (* Debug *)
                                    20
                                | US0_Info -> (* Info *)
                                    30
                                | US0_Verbose -> (* Verbose *)
                                    10
                                | US0_Warning -> (* Warning *)
                                    40
                            let v748 : bool = v738.l0
                            let v749 : bool = v748 = false
                            let v751 : bool =
                                if v749 then
                                    false
                                else
                                    let v750 : bool = 30 >= v747
                                    v750
                            let v752 : bool = v751 = false
                            let v792 : US4 =
                                if v752 then
                                    US4_None
                                else
                                    let v754 : bool = TraceState.trace_state.IsNone
                                    if v754 then
                                        let v755 : US0 = US0_Verbose
                                        let struct (v756 : Mut0, v757 : Mut1, v758 : Mut2, v759 : Mut3, v760 : Mut4, v761 : int64 option) = new_trace_state_1(v755)
                                        let v762 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v756, v757, v758, v759, v760, v761) 
                                        TraceState.trace_state <- v762 
                                        ()
                                    let struct (v763 : Mut0, v764 : Mut1, v765 : Mut2, v766 : Mut3, v767 : Mut4, v768 : int64 option) = TraceState.trace_state.Value
                                    let v769 : string = method6(v763, v764, v765, v766, v767, v768)
                                    let v770 : string = method9()
                                    let v771 : string = method151(v763, v764, v765, v766, v767, v768, v769, v770, v722, v723)
                                    let v772 : bool = TraceState.trace_state.IsNone
                                    if v772 then
                                        let v773 : US0 = US0_Verbose
                                        let struct (v774 : Mut0, v775 : Mut1, v776 : Mut2, v777 : Mut3, v778 : Mut4, v779 : int64 option) = new_trace_state_1(v773)
                                        let v780 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v774, v775, v776, v777, v778, v779) 
                                        TraceState.trace_state <- v780 
                                        ()
                                    let struct (v781 : Mut0, v782 : Mut1, v783 : Mut2, v784 : Mut3, v785 : Mut4, v786 : int64 option) = TraceState.trace_state.Value
                                    let v787 : int64 = v781.l0
                                    let v788 : int64 = v787 + 1L
                                    v781.l0 <- v788
                                    let v789 : (string -> unit) = closure5()
                                    v789 v771
                                    let v790 : (string -> unit) = v782.l0
                                    v790 v771
                                    US4_Some(v781, v782, v783, v784, v785, v786)
                            file_copy_139(v722, v723)
                            false
                let v797 : UH2 =
                    if v794 then
                        let v795 : (string -> (string -> US38)) = closure91(v5, v4, v61)
                        UH2_Cons(v489, v42, v795, v721)
                    else
                        v721
                let struct (v798 : string, v799 : string) = fix_paths_128(v568, v42, v5)
                let v800 : bool = file_exists_50(v798)
                let v870 : bool =
                    if v800 then
                        true
                    else
                        let v801 : bool = file_exists_50(v799)
                        let v802 : bool = v801 = false
                        if v802 then
                            true
                        else
                            let v803 : bool = TraceState.trace_state.IsNone
                            if v803 then
                                let v804 : US0 = US0_Verbose
                                let struct (v805 : Mut0, v806 : Mut1, v807 : Mut2, v808 : Mut3, v809 : Mut4, v810 : int64 option) = new_trace_state_1(v804)
                                let v811 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v805, v806, v807, v808, v809, v810) 
                                TraceState.trace_state <- v811 
                                ()
                            let struct (v812 : Mut0, v813 : Mut1, v814 : Mut2, v815 : Mut3, v816 : Mut4, v817 : int64 option) = TraceState.trace_state.Value
                            let v818 : US0 = v816.l0
                            let v823 : int32 =
                                match v818 with
                                | US0_Critical -> (* Critical *)
                                    50
                                | US0_Debug -> (* Debug *)
                                    20
                                | US0_Info -> (* Info *)
                                    30
                                | US0_Verbose -> (* Verbose *)
                                    10
                                | US0_Warning -> (* Warning *)
                                    40
                            let v824 : bool = v814.l0
                            let v825 : bool = v824 = false
                            let v827 : bool =
                                if v825 then
                                    false
                                else
                                    let v826 : bool = 30 >= v823
                                    v826
                            let v828 : bool = v827 = false
                            let v868 : US4 =
                                if v828 then
                                    US4_None
                                else
                                    let v830 : bool = TraceState.trace_state.IsNone
                                    if v830 then
                                        let v831 : US0 = US0_Verbose
                                        let struct (v832 : Mut0, v833 : Mut1, v834 : Mut2, v835 : Mut3, v836 : Mut4, v837 : int64 option) = new_trace_state_1(v831)
                                        let v838 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v832, v833, v834, v835, v836, v837) 
                                        TraceState.trace_state <- v838 
                                        ()
                                    let struct (v839 : Mut0, v840 : Mut1, v841 : Mut2, v842 : Mut3, v843 : Mut4, v844 : int64 option) = TraceState.trace_state.Value
                                    let v845 : string = method6(v839, v840, v841, v842, v843, v844)
                                    let v846 : string = method9()
                                    let v847 : string = method151(v839, v840, v841, v842, v843, v844, v845, v846, v798, v799)
                                    let v848 : bool = TraceState.trace_state.IsNone
                                    if v848 then
                                        let v849 : US0 = US0_Verbose
                                        let struct (v850 : Mut0, v851 : Mut1, v852 : Mut2, v853 : Mut3, v854 : Mut4, v855 : int64 option) = new_trace_state_1(v849)
                                        let v856 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v850, v851, v852, v853, v854, v855) 
                                        TraceState.trace_state <- v856 
                                        ()
                                    let struct (v857 : Mut0, v858 : Mut1, v859 : Mut2, v860 : Mut3, v861 : Mut4, v862 : int64 option) = TraceState.trace_state.Value
                                    let v863 : int64 = v857.l0
                                    let v864 : int64 = v863 + 1L
                                    v857.l0 <- v864
                                    let v865 : (string -> unit) = closure5()
                                    v865 v847
                                    let v866 : (string -> unit) = v858.l0
                                    v866 v847
                                    US4_Some(v857, v858, v859, v860, v861, v862)
                            file_copy_139(v798, v799)
                            false
                let v873 : UH2 =
                    if v870 then
                        let v871 : (string -> (string -> US38)) = closure91(v5, v4, v60)
                        UH2_Cons(v568, v42, v871, v797)
                    else
                        v797
                let struct (v874 : string, v875 : string) = fix_paths_128(v645, v42, v5)
                let v876 : bool = file_exists_50(v874)
                let v946 : bool =
                    if v876 then
                        true
                    else
                        let v877 : bool = file_exists_50(v875)
                        let v878 : bool = v877 = false
                        if v878 then
                            true
                        else
                            let v879 : bool = TraceState.trace_state.IsNone
                            if v879 then
                                let v880 : US0 = US0_Verbose
                                let struct (v881 : Mut0, v882 : Mut1, v883 : Mut2, v884 : Mut3, v885 : Mut4, v886 : int64 option) = new_trace_state_1(v880)
                                let v887 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v881, v882, v883, v884, v885, v886) 
                                TraceState.trace_state <- v887 
                                ()
                            let struct (v888 : Mut0, v889 : Mut1, v890 : Mut2, v891 : Mut3, v892 : Mut4, v893 : int64 option) = TraceState.trace_state.Value
                            let v894 : US0 = v892.l0
                            let v899 : int32 =
                                match v894 with
                                | US0_Critical -> (* Critical *)
                                    50
                                | US0_Debug -> (* Debug *)
                                    20
                                | US0_Info -> (* Info *)
                                    30
                                | US0_Verbose -> (* Verbose *)
                                    10
                                | US0_Warning -> (* Warning *)
                                    40
                            let v900 : bool = v890.l0
                            let v901 : bool = v900 = false
                            let v903 : bool =
                                if v901 then
                                    false
                                else
                                    let v902 : bool = 30 >= v899
                                    v902
                            let v904 : bool = v903 = false
                            let v944 : US4 =
                                if v904 then
                                    US4_None
                                else
                                    let v906 : bool = TraceState.trace_state.IsNone
                                    if v906 then
                                        let v907 : US0 = US0_Verbose
                                        let struct (v908 : Mut0, v909 : Mut1, v910 : Mut2, v911 : Mut3, v912 : Mut4, v913 : int64 option) = new_trace_state_1(v907)
                                        let v914 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v908, v909, v910, v911, v912, v913) 
                                        TraceState.trace_state <- v914 
                                        ()
                                    let struct (v915 : Mut0, v916 : Mut1, v917 : Mut2, v918 : Mut3, v919 : Mut4, v920 : int64 option) = TraceState.trace_state.Value
                                    let v921 : string = method6(v915, v916, v917, v918, v919, v920)
                                    let v922 : string = method9()
                                    let v923 : string = method151(v915, v916, v917, v918, v919, v920, v921, v922, v874, v875)
                                    let v924 : bool = TraceState.trace_state.IsNone
                                    if v924 then
                                        let v925 : US0 = US0_Verbose
                                        let struct (v926 : Mut0, v927 : Mut1, v928 : Mut2, v929 : Mut3, v930 : Mut4, v931 : int64 option) = new_trace_state_1(v925)
                                        let v932 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v926, v927, v928, v929, v930, v931) 
                                        TraceState.trace_state <- v932 
                                        ()
                                    let struct (v933 : Mut0, v934 : Mut1, v935 : Mut2, v936 : Mut3, v937 : Mut4, v938 : int64 option) = TraceState.trace_state.Value
                                    let v939 : int64 = v933.l0
                                    let v940 : int64 = v939 + 1L
                                    v933.l0 <- v940
                                    let v941 : (string -> unit) = closure5()
                                    v941 v923
                                    let v942 : (string -> unit) = v934.l0
                                    v942 v923
                                    US4_Some(v933, v934, v935, v936, v937, v938)
                            file_copy_139(v874, v875)
                            false
                let v949 : UH2 =
                    if v946 then
                        let v947 : (string -> (string -> US38)) = closure91(v5, v4, v59)
                        UH2_Cons(v645, v42, v947, v873)
                    else
                        v873
                let struct (v950 : string, v951 : string) = fix_paths_128(v56, v42, v5)
                let v952 : bool = file_exists_50(v950)
                let v1022 : bool =
                    if v952 then
                        true
                    else
                        let v953 : bool = file_exists_50(v951)
                        let v954 : bool = v953 = false
                        if v954 then
                            true
                        else
                            let v955 : bool = TraceState.trace_state.IsNone
                            if v955 then
                                let v956 : US0 = US0_Verbose
                                let struct (v957 : Mut0, v958 : Mut1, v959 : Mut2, v960 : Mut3, v961 : Mut4, v962 : int64 option) = new_trace_state_1(v956)
                                let v963 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v957, v958, v959, v960, v961, v962) 
                                TraceState.trace_state <- v963 
                                ()
                            let struct (v964 : Mut0, v965 : Mut1, v966 : Mut2, v967 : Mut3, v968 : Mut4, v969 : int64 option) = TraceState.trace_state.Value
                            let v970 : US0 = v968.l0
                            let v975 : int32 =
                                match v970 with
                                | US0_Critical -> (* Critical *)
                                    50
                                | US0_Debug -> (* Debug *)
                                    20
                                | US0_Info -> (* Info *)
                                    30
                                | US0_Verbose -> (* Verbose *)
                                    10
                                | US0_Warning -> (* Warning *)
                                    40
                            let v976 : bool = v966.l0
                            let v977 : bool = v976 = false
                            let v979 : bool =
                                if v977 then
                                    false
                                else
                                    let v978 : bool = 30 >= v975
                                    v978
                            let v980 : bool = v979 = false
                            let v1020 : US4 =
                                if v980 then
                                    US4_None
                                else
                                    let v982 : bool = TraceState.trace_state.IsNone
                                    if v982 then
                                        let v983 : US0 = US0_Verbose
                                        let struct (v984 : Mut0, v985 : Mut1, v986 : Mut2, v987 : Mut3, v988 : Mut4, v989 : int64 option) = new_trace_state_1(v983)
                                        let v990 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v984, v985, v986, v987, v988, v989) 
                                        TraceState.trace_state <- v990 
                                        ()
                                    let struct (v991 : Mut0, v992 : Mut1, v993 : Mut2, v994 : Mut3, v995 : Mut4, v996 : int64 option) = TraceState.trace_state.Value
                                    let v997 : string = method6(v991, v992, v993, v994, v995, v996)
                                    let v998 : string = method9()
                                    let v999 : string = method151(v991, v992, v993, v994, v995, v996, v997, v998, v950, v951)
                                    let v1000 : bool = TraceState.trace_state.IsNone
                                    if v1000 then
                                        let v1001 : US0 = US0_Verbose
                                        let struct (v1002 : Mut0, v1003 : Mut1, v1004 : Mut2, v1005 : Mut3, v1006 : Mut4, v1007 : int64 option) = new_trace_state_1(v1001)
                                        let v1008 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1002, v1003, v1004, v1005, v1006, v1007) 
                                        TraceState.trace_state <- v1008 
                                        ()
                                    let struct (v1009 : Mut0, v1010 : Mut1, v1011 : Mut2, v1012 : Mut3, v1013 : Mut4, v1014 : int64 option) = TraceState.trace_state.Value
                                    let v1015 : int64 = v1009.l0
                                    let v1016 : int64 = v1015 + 1L
                                    v1009.l0 <- v1016
                                    let v1017 : (string -> unit) = closure5()
                                    v1017 v999
                                    let v1018 : (string -> unit) = v1010.l0
                                    v1018 v999
                                    US4_Some(v1009, v1010, v1011, v1012, v1013, v1014)
                            file_copy_139(v950, v951)
                            false
                let v1027 : UH2 =
                    if v1022 then
                        let v1023 : (string -> (string -> US38)) = closure88(v5, v4, v2, v1, v0)
                        let v1024 : UH2 = UH2_Nil
                        UH2_Cons(v56, v42, v1023, v1024)
                    else
                        UH2_Nil
                let v1028 : UH1 = UH1_Nil
                let v1029 : UH1 = UH1_Cons(v949, v1028)
                UH1_Cons(v1027, v1029)
        let v1032 : UH2 list = []
        let v1033 : UH2 list = method152(v1031, v1032)
        let v1034 : (UH2 list -> (UH2 [])) = List.toArray
        let v1035 : (UH2 []) = v1034 v1033
        let v1036 : Vec<UH2> = () // backend.backend_switch / record_type_try_find / key: v19 
        let v1037 : (Result<string, (string * string)> option []) = [||]
        let v1038 : Vec<Result<string, (string * string)> option> = () // backend.backend_switch / record_type_try_find / key: v19 
        let v1039 : (UH2 []) = () // backend.backend_switch / record_type_try_find / key: v19 
        let v1040 : UH2 list = v1039 |> Array.toList
        let v1041 : ((UH2 -> (UH1 -> UH1)) -> (UH2 list -> (UH1 -> UH1))) = List.foldBack
        let v1042 : (UH2 -> (UH1 -> UH1)) = method153()
        let v1043 : (UH2 list -> (UH1 -> UH1)) = v1041 v1042
        let v1044 : (UH1 -> UH1) = v1043 v1040
        let v1045 : UH1 = UH1_Nil
        let v1046 : UH1 = v1044 v1045
        let v1047 : Vec<Result<string, (string * string)> option> = method154(v1046, v1038)
        let v1048 : (string * Vec<Result<string, (string * string)> option>) = v27, v1047 
        let v1049 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = Ok v1048 
        let v1050 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = method161(v1049)
        let v1051 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = method162(v9)
        let v1052 : string = "true; let mut v1051 = v1051"
        let v1053 : bool = __spiral_emit_rust () v1052 
        let v1054 : string = "true; v1051.push(v1050)"
        let v1055 : bool = __spiral_emit_rust () v1054 
        let v1056 : string = "v1051"
        let v1057 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = __spiral_emit_rust () v1056 
        loop_73(v0, v1, v2, v3, v4, v5, v6, v7, v11, v1057)
    else
        v9
and run_27 (v0 : bool, v1 : US3, v2 : string, v3 : string, v4 : string, v5 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> =
    let v6 : string = "SPIRAL_REPO_ROOT"
    let v7 : string = get_environment_variable_3(v6)
    let v8 : bool = v7 = ""
    let v9 : bool = v8 <> true
    let v41 : string =
        if v9 then
            normalize_path_28(v7)
        else
            let v11 : string = get_current_directory_47()
            let v12 : US3 = run_48(v11)
            let v18 : US3 =
                match v12 with
                | US3_None -> (* None *)
                    let v15 : string = __SOURCE_DIRECTORY__
                    run_48(v15)
                | US3_Some(v13) -> (* Some *)
                    US3_Some(v13)
            let v24 : US3 =
                match v18 with
                | US3_None -> (* None *)
                    let v21 : string = "/workspaces"
                    run_48(v21)
                | US3_Some(v19) -> (* Some *)
                    US3_Some(v19)
            let v28 : string =
                match v24 with
                | US3_None -> (* None *)
                    failwith<string> "Option does not have a value."
                | US3_Some(v25) -> (* Some *)
                    v25
            let v29 : string = get_file_name_36(v28)
            let v30 : bool = "deps" = v29
            let v38 : string =
                if v30 then
                    let v31 : string option = directory_get_parent_37(v28)
                    let v32 : string = v31 |> Option.get
                    let v33 : US3 = run_48(v32)
                    match v33 with
                    | US3_None -> (* None *)
                        failwith<string> "Option does not have a value."
                    | US3_Some(v34) -> (* Some *)
                        v34
                else
                    v28
            let v39 : string = "spiral"
            method43(v38, v39)
    let v42 : string = get_full_path_56(v5)
    let v43 : string = get_full_path_56(v4)
    let v44 : string = get_full_path_56(v3)
    let v45 : bool = TraceState.trace_state.IsNone
    if v45 then
        let v46 : US0 = US0_Verbose
        let struct (v47 : Mut0, v48 : Mut1, v49 : Mut2, v50 : Mut3, v51 : Mut4, v52 : int64 option) = new_trace_state_1(v46)
        let v53 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v47, v48, v49, v50, v51, v52) 
        TraceState.trace_state <- v53 
        ()
    let struct (v54 : Mut0, v55 : Mut1, v56 : Mut2, v57 : Mut3, v58 : Mut4, v59 : int64 option) = TraceState.trace_state.Value
    let v60 : US0 = v58.l0
    let v65 : int32 =
        match v60 with
        | US0_Critical -> (* Critical *)
            50
        | US0_Debug -> (* Debug *)
            20
        | US0_Info -> (* Info *)
            30
        | US0_Verbose -> (* Verbose *)
            10
        | US0_Warning -> (* Warning *)
            40
    let v66 : bool = v56.l0
    let v67 : bool = v66 = false
    let v69 : bool =
        if v67 then
            false
        else
            let v68 : bool = 20 >= v65
            v68
    let v70 : bool = v69 = false
    let v110 : US4 =
        if v70 then
            US4_None
        else
            let v72 : bool = TraceState.trace_state.IsNone
            if v72 then
                let v73 : US0 = US0_Verbose
                let struct (v74 : Mut0, v75 : Mut1, v76 : Mut2, v77 : Mut3, v78 : Mut4, v79 : int64 option) = new_trace_state_1(v73)
                let v80 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v74, v75, v76, v77, v78, v79) 
                TraceState.trace_state <- v80 
                ()
            let struct (v81 : Mut0, v82 : Mut1, v83 : Mut2, v84 : Mut3, v85 : Mut4, v86 : int64 option) = TraceState.trace_state.Value
            let v87 : string = method6(v81, v82, v83, v84, v85, v86)
            let v88 : string = method57()
            let v89 : string = method58(v81, v82, v83, v84, v85, v86, v87, v88, v42, v43, v44, v2, v1, v0)
            let v90 : bool = TraceState.trace_state.IsNone
            if v90 then
                let v91 : US0 = US0_Verbose
                let struct (v92 : Mut0, v93 : Mut1, v94 : Mut2, v95 : Mut3, v96 : Mut4, v97 : int64 option) = new_trace_state_1(v91)
                let v98 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v92, v93, v94, v95, v96, v97) 
                TraceState.trace_state <- v98 
                ()
            let struct (v99 : Mut0, v100 : Mut1, v101 : Mut2, v102 : Mut3, v103 : Mut4, v104 : int64 option) = TraceState.trace_state.Value
            let v105 : int64 = v99.l0
            let v106 : int64 = v105 + 1L
            v99.l0 <- v106
            let v107 : (string -> unit) = closure5()
            v107 v89
            let v108 : (string -> unit) = v100.l0
            v108 v89
            US4_Some(v99, v100, v101, v102, v103, v104)
    let v111 : string = "true; let __future_init = Box::pin(/*"
    let v112 : bool = __spiral_emit_rust () v111 
    let v113 : string = "*/ async move { /*"
    let v114 : bool = __spiral_emit_rust () v113 
    let v115 : string = "*/ ()"
    let v116 : bool = __spiral_emit_rust () v115 
    let v117 : string = "async_walkdir::WalkDir::new(&*$0)"
    let v118 : async_walkdir_WalkDir = __spiral_emit_rust v43 v117 
    let v119 : string = "async_walkdir::WalkDir::filter($0, move |x| $1(x))"
    let v120 : (async_walkdir_DirEntry -> std_pin_Pin<Box<Dyn<std_future_Future<async_walkdir_Filtering>>>>) = fn_c20(v1)
    let v121 : async_walkdir_WalkDir = __spiral_emit_rust struct (v118, v120) v119 
    let v122 : (Result<async_walkdir_DirEntry, async_walkdir_Error> -> string option) = method65()
    let v123 : string = "futures::stream::StreamExt::filter_map(v121, |x| async { v122(x) })"
    let v124 : _ = __spiral_emit_rust () v123 
    let v125 : string = "Box::pin(futures::stream::StreamExt::collect(v124))"
    let v126 : std_pin_Pin<Box<Dyn<std_future_Future<Vec<string>>>>> = __spiral_emit_rust () v125 
    let v127 : string = "v126.await"
    let v128 : Vec<string> = __spiral_emit_rust () v127 
    let v129 : bool = TraceState.trace_state.IsNone
    if v129 then
        let v130 : US0 = US0_Verbose
        let struct (v131 : Mut0, v132 : Mut1, v133 : Mut2, v134 : Mut3, v135 : Mut4, v136 : int64 option) = new_trace_state_1(v130)
        let v137 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v131, v132, v133, v134, v135, v136) 
        TraceState.trace_state <- v137 
        ()
    let struct (v138 : Mut0, v139 : Mut1, v140 : Mut2, v141 : Mut3, v142 : Mut4, v143 : int64 option) = TraceState.trace_state.Value
    let v144 : US0 = v142.l0
    let v149 : int32 =
        match v144 with
        | US0_Critical -> (* Critical *)
            50
        | US0_Debug -> (* Debug *)
            20
        | US0_Info -> (* Info *)
            30
        | US0_Verbose -> (* Verbose *)
            10
        | US0_Warning -> (* Warning *)
            40
    let v150 : bool = v140.l0
    let v151 : bool = v150 = false
    let v153 : bool =
        if v151 then
            false
        else
            let v152 : bool = 20 >= v149
            v152
    let v154 : bool = v153 = false
    let v196 : US4 =
        if v154 then
            US4_None
        else
            let v156 : bool = TraceState.trace_state.IsNone
            if v156 then
                let v157 : US0 = US0_Verbose
                let struct (v158 : Mut0, v159 : Mut1, v160 : Mut2, v161 : Mut3, v162 : Mut4, v163 : int64 option) = new_trace_state_1(v157)
                let v164 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v158, v159, v160, v161, v162, v163) 
                TraceState.trace_state <- v164 
                ()
            let struct (v165 : Mut0, v166 : Mut1, v167 : Mut2, v168 : Mut3, v169 : Mut4, v170 : int64 option) = TraceState.trace_state.Value
            let v171 : string = method6(v165, v166, v167, v168, v169, v170)
            let v172 : string = method57()
            let v173 : string = "Fsharp"
            let v174 : unativeint = () // backend.backend_switch / record_type_try_find / key: v173 
            let v175 : string = method72(v165, v166, v167, v168, v169, v170, v171, v172, v174)
            let v176 : bool = TraceState.trace_state.IsNone
            if v176 then
                let v177 : US0 = US0_Verbose
                let struct (v178 : Mut0, v179 : Mut1, v180 : Mut2, v181 : Mut3, v182 : Mut4, v183 : int64 option) = new_trace_state_1(v177)
                let v184 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v178, v179, v180, v181, v182, v183) 
                TraceState.trace_state <- v184 
                ()
            let struct (v185 : Mut0, v186 : Mut1, v187 : Mut2, v188 : Mut3, v189 : Mut4, v190 : int64 option) = TraceState.trace_state.Value
            let v191 : int64 = v185.l0
            let v192 : int64 = v191 + 1L
            v185.l0 <- v192
            let v193 : (string -> unit) = closure5()
            v193 v175
            let v194 : (string -> unit) = v186.l0
            v194 v175
            US4_Some(v185, v186, v187, v188, v189, v190)
    let v197 : string = "Fsharp"
    let v198 : (string []) = () // backend.backend_switch / record_type_try_find / key: v197 
    let v199 : int32 = (v198.borrow().len() as i32)
    let v200 : int32 = 0
    let v201 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = () // backend.backend_switch / record_type_try_find / key: v197 
    let v202 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = loop_73(v0, v2, v41, v42, v43, v44, v198, v199, v200, v201)
    let v203 : (Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> []) = () // backend.backend_switch / record_type_try_find / key: v197 
    let v204 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = () // backend.backend_switch / record_type_try_find / key: v197 
    let v205 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Ok v204 
    () // backend.backend_switch / record_type_try_find / key: v197 
    let v206 : string = "__future_init"
    let v207 : _ = __spiral_emit_rust () v206 
    let v208 : string = "v207"
    let v209 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = __spiral_emit_rust () v208 
    v209
and ok_c95 () (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) : US44 =
    US44_Ok(v0)
and method163 () : (Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> -> US44) =
    ok_c95()
and error_c96 () (v0 : std_string_String) : US44 =
    US44_Error(v0)
and method164 () : (std_string_String -> US44) =
    error_c96()
and method165 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : int64 = v0.l0
    let v10 : string = " "
    let v11 : string = v6 + v10 
    let v12 : string = format_real_14(v9)
    let v13 : string = v11 + v12 
    let v14 : string = v13 + v7 
    let v15 : string = v14 + v10 
    let v16 : string = "documents.main"
    let v17 : string = v15 + v16 
    let v18 : string = " / "
    let v19 : string = v17 + v18 
    let v20 : string = ""
    let v21 : string = v20 + v20 
    let v22 : string = "error"
    let v23 : string = v21 + v22 
    let v24 : string = " = "
    let v25 : string = v23 + v24 
    let v26 : string = $"%A{v8}"
    let v27 : string = v25 + v26 
    let v28 : string = "{ "
    let v29 : string = v28 + v27 
    let v30 : string = " }"
    let v31 : string = v29 + v30 
    let v32 : string = v19 + v31 
    method17(v32)
and method166 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : unativeint) : string =
    let v9 : int64 = v0.l0
    let v10 : string = " "
    let v11 : string = v6 + v10 
    let v12 : string = format_real_14(v9)
    let v13 : string = v11 + v12 
    let v14 : string = v13 + v7 
    let v15 : string = v14 + v10 
    let v16 : string = "documents.main"
    let v17 : string = v15 + v16 
    let v18 : string = " / "
    let v19 : string = v17 + v18 
    let v20 : string = ""
    let v21 : string = v20 + v20 
    let v22 : string = "result_len"
    let v23 : string = v21 + v22 
    let v24 : string = " = "
    let v25 : string = v23 + v24 
    let v26 : string = $"%A{v8}"
    let v27 : string = v25 + v26 
    let v28 : string = "{ "
    let v29 : string = v28 + v27 
    let v30 : string = " }"
    let v31 : string = v29 + v30 
    let v32 : string = v19 + v31 
    method17(v32)
and closure1 () (v0 : (string [])) : int32 =
    let v1 : bool = TraceState.trace_state.IsNone
    if v1 then
        let v2 : US0 = US0_Info
        let struct (v3 : Mut0, v4 : Mut1, v5 : Mut2, v6 : Mut3, v7 : Mut4, v8 : int64 option) = new_trace_state_1(v2)
        let v9 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v3, v4, v5, v6, v7, v8) 
        TraceState.trace_state <- v9 
        ()
    let v10 : bool = TraceState.trace_state.IsNone
    if v10 then
        let v11 : US0 = US0_Verbose
        let struct (v12 : Mut0, v13 : Mut1, v14 : Mut2, v15 : Mut3, v16 : Mut4, v17 : int64 option) = new_trace_state_1(v11)
        let v18 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v12, v13, v14, v15, v16, v17) 
        TraceState.trace_state <- v18 
        ()
    let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
    let v25 : US0 = v23.l0
    let v30 : int32 =
        match v25 with
        | US0_Critical -> (* Critical *)
            50
        | US0_Debug -> (* Debug *)
            20
        | US0_Info -> (* Info *)
            30
        | US0_Verbose -> (* Verbose *)
            10
        | US0_Warning -> (* Warning *)
            40
    let v31 : bool = v21.l0
    let v32 : bool = v31 = false
    let v34 : bool =
        if v32 then
            false
        else
            let v33 : bool = 30 >= v30
            v33
    let v35 : bool = v34 = false
    let v75 : US4 =
        if v35 then
            US4_None
        else
            let v37 : bool = TraceState.trace_state.IsNone
            if v37 then
                let v38 : US0 = US0_Verbose
                let struct (v39 : Mut0, v40 : Mut1, v41 : Mut2, v42 : Mut3, v43 : Mut4, v44 : int64 option) = new_trace_state_1(v38)
                let v45 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v39, v40, v41, v42, v43, v44) 
                TraceState.trace_state <- v45 
                ()
            let struct (v46 : Mut0, v47 : Mut1, v48 : Mut2, v49 : Mut3, v50 : Mut4, v51 : int64 option) = TraceState.trace_state.Value
            let v52 : string = method6(v46, v47, v48, v49, v50, v51)
            let v53 : string = method9()
            let v54 : string = method13(v46, v47, v48, v49, v50, v51, v52, v53, v0)
            let v55 : bool = TraceState.trace_state.IsNone
            if v55 then
                let v56 : US0 = US0_Verbose
                let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = new_trace_state_1(v56)
                let v63 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v57, v58, v59, v60, v61, v62) 
                TraceState.trace_state <- v63 
                ()
            let struct (v64 : Mut0, v65 : Mut1, v66 : Mut2, v67 : Mut3, v68 : Mut4, v69 : int64 option) = TraceState.trace_state.Value
            let v70 : int64 = v64.l0
            let v71 : int64 = v70 + 1L
            v64.l0 <- v71
            let v72 : (string -> unit) = closure5()
            v72 v54
            let v73 : (string -> unit) = v65.l0
            v73 v54
            US4_Some(v64, v65, v66, v67, v68, v69)
    let v76 : clap_Command = get_command_0()
    let v77 : string = "clap::Command::get_matches($0)"
    let v78 : clap_ArgMatches = __spiral_emit_rust v76 v77 
    let v79 : string = method20()
    let v80 : Ref<Str> = v79 |> unbox<Ref<Str>>
    let v81 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v82 : std_string_String option = __spiral_emit_rust struct (v78, v80) v81 
    let v83 : (std_string_String -> US5) = method21()
    let v84 : US5 option = v82 |> Option.map v83 
    let v85 : US5 = US5_None
    let v86 : US5 = v84 |> Option.defaultValue v85 
    let v90 : std_string_String =
        match v86 with
        | US5_None -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US5_Some(v87) -> (* Some *)
            v87
    let v91 : string = "Fsharp"
    let v92 : string = () // backend.backend_switch / record_type_try_find / key: v91 
    let v93 : string = method22()
    let v94 : Ref<Str> = v93 |> unbox<Ref<Str>>
    let v95 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v96 : std_string_String option = __spiral_emit_rust struct (v78, v94) v95 
    let v97 : (std_string_String -> US5) = method21()
    let v98 : US5 option = v96 |> Option.map v97 
    let v99 : US5 = US5_None
    let v100 : US5 = v98 |> Option.defaultValue v99 
    let v104 : std_string_String =
        match v100 with
        | US5_None -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US5_Some(v101) -> (* Some *)
            v101
    let v105 : string = () // backend.backend_switch / record_type_try_find / key: v91 
    let v106 : string = method23()
    let v107 : Ref<Str> = v106 |> unbox<Ref<Str>>
    let v108 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v109 : std_string_String option = __spiral_emit_rust struct (v78, v107) v108 
    let v110 : (std_string_String -> US5) = method21()
    let v111 : US5 option = v109 |> Option.map v110 
    let v112 : US5 = US5_None
    let v113 : US5 = v111 |> Option.defaultValue v112 
    let v117 : std_string_String =
        match v113 with
        | US5_None -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US5_Some(v114) -> (* Some *)
            v114
    let v118 : string = () // backend.backend_switch / record_type_try_find / key: v91 
    let v119 : string = method24()
    let v120 : Ref<Str> = v119 |> unbox<Ref<Str>>
    let v121 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v122 : std_string_String option = __spiral_emit_rust struct (v78, v120) v121 
    let v123 : (std_string_String -> US5) = method21()
    let v124 : US5 option = v122 |> Option.map v123 
    let v125 : US5 = US5_None
    let v126 : US5 = v124 |> Option.defaultValue v125 
    let v132 : US3 =
        match v126 with
        | US5_None -> (* None *)
            US3_None
        | US5_Some(v127) -> (* Some *)
            let v128 : string = () // backend.backend_switch / record_type_try_find / key: v91 
            US3_Some(v128)
    let v136 : string =
        match v132 with
        | US3_None -> (* None *)
            let v134 : string = "por-br"
            v134
        | US3_Some(v133) -> (* Some *)
            v133
    let v137 : string = method25()
    let v138 : Ref<Str> = v137 |> unbox<Ref<Str>>
    let v139 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v140 : std_string_String option = __spiral_emit_rust struct (v78, v138) v139 
    let v141 : (std_string_String -> US5) = method21()
    let v142 : US5 option = v140 |> Option.map v141 
    let v143 : US5 = US5_None
    let v144 : US5 = v142 |> Option.defaultValue v143 
    let v150 : US3 =
        match v144 with
        | US5_None -> (* None *)
            US3_None
        | US5_Some(v145) -> (* Some *)
            let v146 : string = () // backend.backend_switch / record_type_try_find / key: v91 
            US3_Some(v146)
    let v151 : string = method26()
    let v152 : Ref<Str> = v151 |> unbox<Ref<Str>>
    let v153 : string = "clap::ArgMatches::get_flag(&$0, $1)"
    let v154 : bool = __spiral_emit_rust struct (v78, v152) v153 
    let v155 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = run_27(v154, v150, v136, v118, v105, v92)
    let v156 : string = "futures::executor::block_on($0)"
    let v157 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = __spiral_emit_rust v155 v156 
    let v158 : (Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> -> US44) = method163()
    let v159 : (std_string_String -> US44) = method164()
    let v160 : US44 = match v157 with Ok x -> v158 x | Error x -> v159 x
    match v160 with
    | US44_Error(v229) -> (* Error *)
        let v230 : bool = TraceState.trace_state.IsNone
        if v230 then
            let v231 : US0 = US0_Verbose
            let struct (v232 : Mut0, v233 : Mut1, v234 : Mut2, v235 : Mut3, v236 : Mut4, v237 : int64 option) = new_trace_state_1(v231)
            let v238 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v232, v233, v234, v235, v236, v237) 
            TraceState.trace_state <- v238 
            ()
        let struct (v239 : Mut0, v240 : Mut1, v241 : Mut2, v242 : Mut3, v243 : Mut4, v244 : int64 option) = TraceState.trace_state.Value
        let v245 : US0 = v243.l0
        let v250 : int32 =
            match v245 with
            | US0_Critical -> (* Critical *)
                50
            | US0_Debug -> (* Debug *)
                20
            | US0_Info -> (* Info *)
                30
            | US0_Verbose -> (* Verbose *)
                10
            | US0_Warning -> (* Warning *)
                40
        let v251 : bool = v241.l0
        let v252 : bool = v251 = false
        let v254 : bool =
            if v252 then
                false
            else
                let v253 : bool = 50 >= v250
                v253
        let v255 : bool = v254 = false
        let v295 : US4 =
            if v255 then
                US4_None
            else
                let v257 : bool = TraceState.trace_state.IsNone
                if v257 then
                    let v258 : US0 = US0_Verbose
                    let struct (v259 : Mut0, v260 : Mut1, v261 : Mut2, v262 : Mut3, v263 : Mut4, v264 : int64 option) = new_trace_state_1(v258)
                    let v265 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v259, v260, v261, v262, v263, v264) 
                    TraceState.trace_state <- v265 
                    ()
                let struct (v266 : Mut0, v267 : Mut1, v268 : Mut2, v269 : Mut3, v270 : Mut4, v271 : int64 option) = TraceState.trace_state.Value
                let v272 : string = method6(v266, v267, v268, v269, v270, v271)
                let v273 : string = method70()
                let v274 : string = method165(v266, v267, v268, v269, v270, v271, v272, v273, v229)
                let v275 : bool = TraceState.trace_state.IsNone
                if v275 then
                    let v276 : US0 = US0_Verbose
                    let struct (v277 : Mut0, v278 : Mut1, v279 : Mut2, v280 : Mut3, v281 : Mut4, v282 : int64 option) = new_trace_state_1(v276)
                    let v283 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v277, v278, v279, v280, v281, v282) 
                    TraceState.trace_state <- v283 
                    ()
                let struct (v284 : Mut0, v285 : Mut1, v286 : Mut2, v287 : Mut3, v288 : Mut4, v289 : int64 option) = TraceState.trace_state.Value
                let v290 : int64 = v284.l0
                let v291 : int64 = v290 + 1L
                v284.l0 <- v291
                let v292 : (string -> unit) = closure5()
                v292 v274
                let v293 : (string -> unit) = v285.l0
                v293 v274
                US4_Some(v284, v285, v286, v287, v288, v289)
        1
    | US44_Ok(v161) -> (* Ok *)
        let v162 : bool = TraceState.trace_state.IsNone
        if v162 then
            let v163 : US0 = US0_Verbose
            let struct (v164 : Mut0, v165 : Mut1, v166 : Mut2, v167 : Mut3, v168 : Mut4, v169 : int64 option) = new_trace_state_1(v163)
            let v170 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v164, v165, v166, v167, v168, v169) 
            TraceState.trace_state <- v170 
            ()
        let struct (v171 : Mut0, v172 : Mut1, v173 : Mut2, v174 : Mut3, v175 : Mut4, v176 : int64 option) = TraceState.trace_state.Value
        let v177 : US0 = v175.l0
        let v182 : int32 =
            match v177 with
            | US0_Critical -> (* Critical *)
                50
            | US0_Debug -> (* Debug *)
                20
            | US0_Info -> (* Info *)
                30
            | US0_Verbose -> (* Verbose *)
                10
            | US0_Warning -> (* Warning *)
                40
        let v183 : bool = v173.l0
        let v184 : bool = v183 = false
        let v186 : bool =
            if v184 then
                false
            else
                let v185 : bool = 30 >= v182
                v185
        let v187 : bool = v186 = false
        let v228 : US4 =
            if v187 then
                US4_None
            else
                let v189 : bool = TraceState.trace_state.IsNone
                if v189 then
                    let v190 : US0 = US0_Verbose
                    let struct (v191 : Mut0, v192 : Mut1, v193 : Mut2, v194 : Mut3, v195 : Mut4, v196 : int64 option) = new_trace_state_1(v190)
                    let v197 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v191, v192, v193, v194, v195, v196) 
                    TraceState.trace_state <- v197 
                    ()
                let struct (v198 : Mut0, v199 : Mut1, v200 : Mut2, v201 : Mut3, v202 : Mut4, v203 : int64 option) = TraceState.trace_state.Value
                let v204 : string = method6(v198, v199, v200, v201, v202, v203)
                let v205 : string = method9()
                let v206 : unativeint = () // backend.backend_switch / record_type_try_find / key: v91 
                let v207 : string = method166(v198, v199, v200, v201, v202, v203, v204, v205, v206)
                let v208 : bool = TraceState.trace_state.IsNone
                if v208 then
                    let v209 : US0 = US0_Verbose
                    let struct (v210 : Mut0, v211 : Mut1, v212 : Mut2, v213 : Mut3, v214 : Mut4, v215 : int64 option) = new_trace_state_1(v209)
                    let v216 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v210, v211, v212, v213, v214, v215) 
                    TraceState.trace_state <- v216 
                    ()
                let struct (v217 : Mut0, v218 : Mut1, v219 : Mut2, v220 : Mut3, v221 : Mut4, v222 : int64 option) = TraceState.trace_state.Value
                let v223 : int64 = v217.l0
                let v224 : int64 = v223 + 1L
                v217.l0 <- v224
                let v225 : (string -> unit) = closure5()
                v225 v207
                let v226 : (string -> unit) = v218.l0
                v226 v207
                US4_Some(v217, v218, v219, v220, v221, v222)
        0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
