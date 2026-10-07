thread_local! { static SPIRAL_TEST: std::cell::RefCell<Option<&'static str>> = const { std::cell::RefCell::new(None) }; }
#[test] fn verify_app() { std::thread::Builder::new().stack_size(1 << 30).spawn(|| { SPIRAL_TEST.with(|t| *t.borrow_mut() = Some("verify_app")); spiral_main() }).unwrap().join().unwrap(); }
type Ref<'T> = 'T
type clap_Command = class end
type clap_Arg = class end
type clap_ArgAction = class end
module TraceState = let mutable trace_state = None
type clap_ArgMatches = class end
type std_string_String = string
type std_path_PathBuf = string
type std_path_Display = string
#if FABLE_COMPILER
type System_IO_DirectoryInfo = bool
#else
type System_IO_DirectoryInfo = System.IO.DirectoryInfo
#endif

#if FABLE_COMPILER
type System_IO_FileInfo = bool
#else
type System_IO_FileInfo = System.IO.FileInfo
#endif

type std_io_Error = string
type std_ffi_OsString = class end
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
type Dyn<'T> = class end
type std_future_Future<'T> = class end
type std_sync_mpsc_Receiver<'T> = class end
type Mut<'T> = class end
type encoding_rs_Encoding = class end
type Slice<'T> = class end
type LifetimeRef<'T> = class end
type LifetimeJoin<'T, 'U> = class end
type core_any_Any = obj
type [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
    | US0_4
and Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : (string -> unit)}
and Mut2 = {mutable l0 : bool}
and Mut3 = {mutable l0 : string}
and Mut4 = {mutable l0 : US0}
and [<Struct>] US1 =
    | US1_0 of f0_0 : US0
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : int64
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : string
    | US3_1
and Mut5 = {mutable l0 : int32; mutable l1 : US1}
and [<Struct>] US4 =
    | US4_0 of f0_0 : int64
    | US4_1 of f1_0 : exn
and [<Struct>] US5 =
    | US5_0 of f0_0 : int64
    | US5_1
and [<Struct>] US6 =
    | US6_0 of f0_0 : int64
    | US6_1 of f1_0 : exn
and [<Struct>] US7 =
    | US7_0 of f0_0 : Mut0 * f0_1 : Mut1 * f0_2 : Mut2 * f0_3 : Mut3 * f0_4 : Mut4 * f0_5 : int64 option
    | US7_1
and [<Struct>] US8 =
    | US8_0 of f0_0 : std_string_String
    | US8_1
and [<Struct>] US9 =
    | US9_0
    | US9_1
and [<Struct>] US10 =
    | US10_0 of f0_0 : string
    | US10_1 of f1_0 : string
and [<Struct>] US11 =
    | US11_0 of f0_0 : std_path_PathBuf
    | US11_1 of f1_0 : std_io_Error
and [<Struct>] US12 =
    | US12_0 of f0_0 : std_path_PathBuf
    | US12_1 of f1_0 : string
and [<Struct>] US13 =
    | US13_0 of f0_0 : string
    | US13_1 of f1_0 : exn
and [<Struct>] US14 =
    | US14_0 of f0_0 : std_path_PathBuf
    | US14_1
and [<Struct>] US15 =
    | US15_0 of f0_0 : std_fs_FileType
    | US15_1 of f1_0 : std_io_Error
and [<Struct>] US16 =
    | US16_0 of f0_0 : std_fs_FileType
    | US16_1 of f1_0 : std_string_String
and [<Struct>] US17 =
    | US17_0
    | US17_1
    | US17_2
and [<Struct>] US18 =
    | US18_0 of f0_0 : async_walkdir_DirEntry
    | US18_1 of f1_0 : async_walkdir_Error
and [<Struct>] US19 =
    | US19_0 of f0_0 : async_walkdir_DirEntry
    | US19_1 of f1_0 : std_string_String
and [<Struct>] US20 =
    | US20_0 of f0_0 : string * f0_1 : US3
    | US20_1 of f1_0 : string
and [<Struct>] US21 =
    | US21_0 of f0_0 : char * f0_1 : int32 * f0_2 : int32 * f0_3 : int32 * f0_4 : int32 * f0_5 : int32
    | US21_1 of f1_0 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) * f1_1 : int32 * f1_2 : int32 * f1_3 : int32 * f1_4 : int32 * f1_5 : int32
and [<Struct>] US22 =
    | US22_0 of f0_0 : string * f0_1 : int32 * f0_2 : int32 * f0_3 : int32 * f0_4 : int32 * f0_5 : int32
    | US22_1 of f1_0 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) * f1_1 : int32 * f1_2 : int32 * f1_3 : int32 * f1_4 : int32 * f1_5 : int32
and [<Struct>] US23 =
    | US23_0 of f0_0 : int32 * f0_1 : int32 * f0_2 : int32 * f0_3 : int32 * f0_4 : int32
    | US23_1 of f1_0 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) * f1_1 : int32 * f1_2 : int32 * f1_3 : int32 * f1_4 : int32 * f1_5 : int32
and [<Struct>] US25 =
    | US25_0 of f0_0 : (unit -> string)
    | US25_1
and [<Struct>] US24 =
    | US24_0 of f0_0 : (unit -> string) * f0_1 : (unit -> US25) * f0_2 : int32 * f0_3 : int32 * f0_4 : int32 * f0_5 : int32 * f0_6 : int32
    | US24_1 of f1_0 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) * f1_1 : int32 * f1_2 : int32 * f1_3 : int32 * f1_4 : int32 * f1_5 : int32
and [<Struct>] US26 =
    | US26_0 of f0_0 : US25 * f0_1 : int32 * f0_2 : int32 * f0_3 : int32 * f0_4 : int32 * f0_5 : int32
    | US26_1 of f1_0 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) * f1_1 : int32 * f1_2 : int32 * f1_3 : int32 * f1_4 : int32 * f1_5 : int32
and [<Struct>] US27 =
    | US27_0 of f0_0 : (unit -> string) * f0_1 : (unit -> US25) * f0_2 : string * f0_3 : int32 * f0_4 : int32 * f0_5 : int32 * f0_6 : int32
    | US27_1 of f1_0 : (unit -> string)
and [<Struct>] US28 =
    | US28_0 of f0_0 : string * f0_1 : US3
    | US28_1 of f1_0 : (unit -> string)
and [<Struct>] US29 =
    | US29_0 of f0_0 : (string [])
    | US29_1 of f1_0 : string
and UH0 =
    | UH0_0
    | UH0_1 of string * UH0
and [<Struct>] US30 =
    | US30_0 of f0_0 : UH0 * f0_1 : int32 * f0_2 : int32 * f0_3 : int32 * f0_4 : int32 * f0_5 : int32
    | US30_1 of f1_0 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) * f1_1 : int32 * f1_2 : int32 * f1_3 : int32 * f1_4 : int32 * f1_5 : int32
and [<Struct>] US31 =
    | US31_0 of f0_0 : UH0 * f0_1 : string * f0_2 : int32 * f0_3 : int32 * f0_4 : int32 * f0_5 : int32
    | US31_1 of f1_0 : (unit -> string)
and [<Struct>] US32 =
    | US32_0 of f0_0 : (string [])
    | US32_1 of f1_0 : (unit -> string)
and [<Struct>] US33 =
    | US33_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>
    | US33_1 of f1_0 : std_string_String
and [<Struct>] US34 =
    | US34_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>
    | US34_1
and [<Struct>] US35 =
    | US35_0 of f0_0 : std_string_String
    | US35_1 of f1_0 : std_string_String
and [<Struct>] US36 =
    | US36_0 of f0_0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)
    | US36_1
and [<Struct>] US37 =
    | US37_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>
    | US37_1
and [<Struct>] US38 =
    | US38_0 of f0_0 : std_process_Output
    | US38_1 of f1_0 : std_string_String
and [<Struct>] US39 =
    | US39_0 of f0_0 : int32
    | US39_1
and [<Struct>] US40 =
    | US40_0 of f0_0 : US3
    | US40_1
and [<Struct>] US41 =
    | US41_0 of f0_0 : Result<string, (string * string)>
    | US41_1
and UH2 =
    | UH2_0
    | UH2_1 of string * string * (string -> (string -> US41)) * UH2
and UH1 =
    | UH1_0
    | UH1_1 of UH2 * UH1
and [<Struct>] US42 =
    | US42_0 of f0_0 : unativeint
    | US42_1 of f1_0 : exn
and [<Struct>] US43 =
    | US43_0 of f0_0 : unativeint
    | US43_1
and [<Struct>] US44 =
    | US44_0 of f0_0 : string
    | US44_1 of f1_0 : std_io_Error
and [<Struct>] US45 =
    | US45_0 of f0_0 : string
    | US45_1 of f1_0 : std_string_String
and [<Struct>] US46 =
    | US46_0 of f0_0 : int32 * f0_1 : string
    | US46_1 of f1_0 : int32 * f1_1 : string
and Mut6 = {mutable l0 : int32}
and Mut7 = {mutable l0 : int32; mutable l1 : int32}
and Mut8 = {mutable l0 : int32; mutable l1 : string; mutable l2 : int32; mutable l3 : int32}
and [<Struct>] US47 =
    | US47_0 of f0_0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>
    | US47_1 of f1_0 : std_string_String
let rec method0 () : clap_Command =
    let v20 : string = "command"
    let v21 : string = "r#\"" + v20 + "\"#"
    let v22 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v21 
    let v56 : string = "clap::Command::new($0)"
    let v57 : clap_Command = Fable.Core.RustInterop.emitRustExpr v22 v56 
    let v61 : string = "source-dir"
    let v62 : string = "r#\"" + v61 + "\"#"
    let v63 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v62 
    let v72 : string = "clap::Arg::new($0)"
    let v73 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v63 v72 
    let v74 : string = "$0.short($1 as char)"
    let v75 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v73, 's') v74 
    let v76 : string = "r#\"" + v61 + "\"#"
    let v77 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v76 
    let v78 : string = "$0.long($1)"
    let v79 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v75, v77) v78 
    let v80 : string = "$0.required($1)"
    let v81 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v79, true) v80 
    let v82 : string = "clap::Command::arg($0, $1)"
    let v83 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v57, v81) v82 
    let v87 : string = "dist-dir"
    let v88 : string = "r#\"" + v87 + "\"#"
    let v89 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v88 
    let v98 : string = "clap::Arg::new($0)"
    let v99 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v89 v98 
    let v100 : string = "$0.short($1 as char)"
    let v101 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v99, 'd') v100 
    let v102 : string = "r#\"" + v87 + "\"#"
    let v103 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v102 
    let v104 : string = "$0.long($1)"
    let v105 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v101, v103) v104 
    let v106 : string = "$0.required($1)"
    let v107 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v105, true) v106 
    let v108 : string = "clap::Command::arg($0, $1)"
    let v109 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v83, v107) v108 
    let v113 : string = "cache-dir"
    let v114 : string = "r#\"" + v113 + "\"#"
    let v115 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v114 
    let v124 : string = "clap::Arg::new($0)"
    let v125 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v115 v124 
    let v126 : string = "$0.short($1 as char)"
    let v127 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v125, 'c') v126 
    let v128 : string = "r#\"" + v113 + "\"#"
    let v129 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v128 
    let v130 : string = "$0.long($1)"
    let v131 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v127, v129) v130 
    let v132 : string = "$0.required($1)"
    let v133 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v131, true) v132 
    let v134 : string = "clap::Command::arg($0, $1)"
    let v135 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v109, v133) v134 
    let v139 : string = "hangul-spec"
    let v140 : string = "r#\"" + v139 + "\"#"
    let v141 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v140 
    let v150 : string = "clap::Arg::new($0)"
    let v151 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v141 v150 
    let v152 : string = "$0.short($1 as char)"
    let v153 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v151, 'H') v152 
    let v154 : string = "r#\"" + v139 + "\"#"
    let v155 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v154 
    let v156 : string = "$0.long($1)"
    let v157 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v153, v155) v156 
    let v158 : string = "clap::Command::arg($0, $1)"
    let v159 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v135, v157) v158 
    let v163 : string = "filter"
    let v164 : string = "r#\"" + v163 + "\"#"
    let v165 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v164 
    let v174 : string = "clap::Arg::new($0)"
    let v175 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v165 v174 
    let v176 : string = "$0.short($1 as char)"
    let v177 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v175, 'f') v176 
    let v178 : string = "r#\"" + v163 + "\"#"
    let v179 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v178 
    let v180 : string = "$0.long($1)"
    let v181 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v177, v179) v180 
    let v182 : string = "clap::Command::arg($0, $1)"
    let v183 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v159, v181) v182 
    let v187 : string = "transcribe-only"
    let v188 : string = "r#\"" + v187 + "\"#"
    let v189 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v188 
    let v198 : string = "clap::Arg::new($0)"
    let v199 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v189 v198 
    let v200 : string = "$0.short($1 as char)"
    let v201 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v199, 't') v200 
    let v202 : string = "r#\"" + v187 + "\"#"
    let v203 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v202 
    let v204 : string = "$0.long($1)"
    let v205 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v201, v203) v204 
    let v226 : string = "false"
    let v227 : string = "r#\"" + v226 + "\"#"
    let v228 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v227 
    let v262 : string = "$0.default_value(&*Box::leak(String::from($1).into_boxed_str()))"
    let v263 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v205, v228) v262 
    let v264 : string = "clap::ArgAction::SetTrue"
    let v265 : clap_ArgAction = Fable.Core.RustInterop.emitRustExpr () v264 
    let v266 : string = "$0.action($1)"
    let v267 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v263, v265) v266 
    let v268 : string = "clap::Command::arg($0, $1)"
    let v269 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v183, v267) v268 
    v269
and closure0 () () : unit =
    let v0 : string = "verify_app"
    let v1 : bool = SPIRAL_TEST.with(|t| t.borrow().map_or(false, |s| s == (&*v0)))
    if v1 then
        let v2 : clap_Command = method0()
        let v3 : string = "clap::Command::debug_assert($0)"
        Fable.Core.RustInterop.emitRustExpr v2 v3 
        ()
and closure2 () (v0 : string) : US3 =
    US3_0(v0)
and method4 () : (string -> US3) =
    closure2()
and method3 (v0 : string) : string =
    let v2 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v3 : string = v2 v0
    let v4 : (string -> string option) = Option.ofObj
    let v5 : string option = v4 v3
    let v6 : (string -> US3) = method4()
    let v7 : US3 option = v5 |> Option.map v6 
    let v8 : US3 = US3_1
    let v9 : US3 = v7 |> Option.defaultValue v8 
    match v9 with
    | US3_1 -> (* None *)
        let v11 : string = ""
        v11
    | US3_0(v10) -> (* Some *)
        v10
and method5 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure3 (v0 : float) () : int64 =
    let v1 : int64 = v0 |> int64 
    v1
and closure4 () (v0 : int64) : US4 =
    US4_0(v0)
and closure5 () (v0 : (unit -> exn)) : exn =
    v0 ()
and closure6 () (v0 : exn) : US4 =
    US4_1(v0)
and method6 (v0 : float) : US4 =
    let v1 : (unit -> int64) = closure3(v0)
    let v2 : (int64 -> US4) = closure4()
    let v3 : ((unit -> exn) -> exn) = closure5()
    let v4 : (exn -> US4) = closure6()
    let v5 : US4 = try v1 () |> v2 with ex -> (fun () -> ex) |> v3 |> v4 
    v5
and closure7 (v0 : int64) () : int64 =
    let v1 : int64 = v0 |> int64 
    v1
and closure8 () (v0 : int64) : US6 =
    US6_0(v0)
and closure9 () (v0 : exn) : US6 =
    US6_1(v0)
and method7 (v0 : int64) : US6 =
    let v1 : (unit -> int64) = closure7(v0)
    let v2 : (int64 -> US6) = closure8()
    let v3 : ((unit -> exn) -> exn) = closure5()
    let v4 : (exn -> US6) = closure9()
    let v5 : US6 = try v1 () |> v2 with ex -> (fun () -> ex) |> v3 |> v4 
    v5
and method2 () : struct (US1 * US2) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = method3(v0)
    
    
    
    
    
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
    let v18 : US0 = US0_4
    let v19 : struct (string * US0) list = struct (v4, v18) :: v17 
    let v20 : US0 = US0_3
    let v21 : struct (string * US0) list = struct (v7, v20) :: v19 
    let v22 : US0 = US0_2
    let v23 : struct (string * US0) list = struct (v10, v22) :: v21 
    let v24 : US0 = US0_1
    let v25 : struct (string * US0) list = struct (v13, v24) :: v23 
    let v26 : US0 = US0_0
    let v27 : struct (string * US0) list = struct (v16, v26) :: v25 
    let v28 : US0 = US0_4
    let v29 : struct (string * US0) list = struct (v2, v28) :: v27 
    let v30 : US0 = US0_3
    let v31 : struct (string * US0) list = struct (v5, v30) :: v29 
    let v32 : US0 = US0_2
    let v33 : struct (string * US0) list = struct (v8, v32) :: v31 
    let v34 : US0 = US0_1
    let v35 : struct (string * US0) list = struct (v11, v34) :: v33 
    let v36 : US0 = US0_0
    let v37 : struct (string * US0) list = struct (v14, v36) :: v35 
    let v38 : (struct (string * US0) list -> (struct (string * US0) [])) = List.toArray
    let v39 : (struct (string * US0) []) = v38 v37
    let v40 : int32 = v39.Length
    let v41 : US1 = US1_1
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
            | US1_1 -> (* None *)
                let v52 : bool = v49 = v1 
                if v52 then
                    US1_0(v50)
                else
                    US1_1
            | US1_0(v51) -> (* Some *)
                v48
        let v58 : int32 = v44 + 1
        v42.l0 <- v58
        v42.l1 <- v57
        ()
    let v59 : US1 = v42.l1
    let v60 : string = "AUTOMATION"
    let v61 : string = method3(v60)
    let v62 : string = "True"
    let v63 : bool = v61 <> v62 
    let v96 : US2 =
        if v63 then
            US2_1
        else
            let v65 : System.DateTime = System.DateTime.Now
            let v66 : System.DateTime = System.DateTime.MinValue
            let v67 : System.TimeSpan = v65 - v66 
            let v68 : (System.TimeSpan -> int64) = _.Ticks
            let v69 : int64 = v68 v67
            let v70 : int64 = v69 / 10000000L
            let v71 : float = float v70
            let v72 : float = 10000000.0 * v71
            let v73 : US4 = method6(v72)
            let v79 : US5 =
                match v73 with
                | US4_1(v76) -> (* Error *)
                    US5_1
                | US4_0(v74) -> (* Ok *)
                    US5_0(v74)
            let v83 : int64 =
                match v79 with
                | US5_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US5_0(v80) -> (* Some *)
                    v80
            let v84 : US6 = method7(v83)
            let v90 : US2 =
                match v84 with
                | US6_1(v87) -> (* Error *)
                    US2_1
                | US6_0(v85) -> (* Ok *)
                    US2_0(v85)
            let v94 : int64 =
                match v90 with
                | US2_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US2_0(v91) -> (* Some *)
                    v91
            US2_0(v94)
    struct (v59, v96)
and closure10 () (v0 : string) : unit =
    ()
and method1 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    let struct (v1 : US1, v2 : US2) = method2()
    let v3 : Mut0 = {l0 = 1L} : Mut0
    let v4 : (string -> unit) = closure10()
    let v5 : Mut1 = {l0 = v4} : Mut1
    let v6 : Mut2 = {l0 = true} : Mut2
    let v7 : string = ""
    let v8 : Mut3 = {l0 = v7} : Mut3
    let v11 : US0 =
        match v1 with
        | US1_1 -> (* None *)
            v0
        | US1_0(v9) -> (* Some *)
            v9
    let v12 : Mut4 = {l0 = v11} : Mut4
    let v17 : int64 option =
        match v2 with
        | US2_1 -> (* None *)
            let v15 : int64 option = None
            v15
        | US2_0(v13) -> (* Some *)
            let v14 : int64 option = Some v13 
            v14
    struct (v3, v5, v6, v8, v12, v17)
and closure11 () (v0 : int64) : US2 =
    US2_0(v0)
and method9 () : (int64 -> US2) =
    closure11()
and method10 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method8 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    let v747 : (int64 -> US2) = method9()
    let v748 : US2 option = v5 |> Option.map v747 
    let v749 : US2 = US2_1
    let v750 : US2 = v748 |> Option.defaultValue v749 
    let v795 : System.DateTime =
        match v750 with
        | US2_1 -> (* None *)
            let v793 : System.DateTime = System.DateTime.Now
            v793
        | US2_0(v751) -> (* Some *)
            let v752 : System.DateTime = System.DateTime.Now
            let v753 : System.DateTime = System.DateTime.MinValue
            let v754 : System.TimeSpan = v752 - v753 
            let v755 : (System.TimeSpan -> int64) = _.Ticks
            let v756 : int64 = v755 v754
            let v757 : int64 = v756 / 10000000L
            let v758 : float = float v757
            let v759 : float = 10000000.0 * v758
            let v760 : US4 = method6(v759)
            let v766 : US5 =
                match v760 with
                | US4_1(v763) -> (* Error *)
                    US5_1
                | US4_0(v761) -> (* Ok *)
                    US5_0(v761)
            let v770 : int64 =
                match v766 with
                | US5_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US5_0(v767) -> (* Some *)
                    v767
            let v771 : US6 = method7(v770)
            let v777 : US2 =
                match v771 with
                | US6_1(v774) -> (* Error *)
                    US2_1
                | US6_0(v772) -> (* Ok *)
                    US2_0(v772)
            let v781 : int64 =
                match v777 with
                | US2_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US2_0(v778) -> (* Some *)
                    v778
            let v782 : int64 = v781 - v751
            let v783 : System.TimeSpan = v782 |> System.TimeSpan 
            let v784 : (System.TimeSpan -> int32) = _.Hours
            let v785 : int32 = v784 v783
            let v786 : (System.TimeSpan -> int32) = _.Minutes
            let v787 : int32 = v786 v783
            let v788 : (System.TimeSpan -> int32) = _.Seconds
            let v789 : int32 = v788 v783
            let v790 : (System.TimeSpan -> int32) = _.Milliseconds
            let v791 : int32 = v790 v783
            let v792 : System.DateTime = System.DateTime (1, 1, 1, v785, v787, v789, v791)
            v792
    let v796 : string = method10()
    let v852 : bool = v796 = ""
    let v854 : string =
        if v852 then
            let v853 : string = "M-d-y hh:mm:ss tt"
            v853
        else
            v796
    let v855 : (string -> string) = v795.ToString
    v855 v854
and method13 () : string =
    let v0 : string = ""
    v0
and method14 (v0 : Mut3, v1 : string) : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method12 (v0 : char) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v15 : string = $"{v0}"
    method14(v2, v15)
    let v23 : string = v2.l0
    v23
and method11 () : string =
    let v2 : string = "\u001b[92m"
    
    
    
    
    
    let v8 : string = "Info"
    let v9 : (unit -> string) = v8.ToLower
    let v10 : string = v9 ()
    let v11 : char = v10.[int 0]
    let v12 : string = method12(v11)
    let v13 : string = v2 + v12 
    let v16 : string = "\u001b[0m"
    let v22 : string = v13 + v16 
    v22
and method16 (v0 : int64) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v15 : string = $"{v0}"
    method14(v2, v15)
    let v23 : string = v2.l0
    v23
and method18 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "{ "
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method19 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "args"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method20 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = " = "
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method21 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = " }"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method17 (v0 : (string [])) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    method18(v2)
    method19(v2)
    method20(v2)
    let v99 : string = $"%A{v0}"
    method14(v2, v99)
    method21(v2)
    let v130 : string = v2.l0
    v130
and method23 (v0 : string, v1 : int32, v2 : int32) : int32 =
    let v3 : bool = v2 >= v1
    if v3 then
        v1
    else
        let v4 : char = v0.[int v2]
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
            method23(v0, v1, v12)
        else
            v2
and method24 (v0 : string, v1 : int32) : int32 =
    let v2 : bool = v1 <= 0
    if v2 then
        -1
    else
        let v3 : int32 = v1 - 1
        let v4 : char = v0.[int v3]
        let v5 : bool = v4 = ' '
        let v7 : bool =
            if v5 then
                true
            else
                let v6 : bool = v4 = '/'
                v6
        if v7 then
            method24(v0, v3)
        else
            v3
and method22 (v0 : string) : string =
    let v1 : int32 = v0.Length
    let v2 : int32 = 0
    let v3 : int32 = method23(v0, v1, v2)
    let v4 : int32 = v1 - 1
    let v7 : string = v0.[int v3..int v4]
    let v14 : int32 = v7.Length
    let v15 : int32 = method24(v7, v14)
    let v18 : string = v7.[int 0..int v15]
    v18
and method15 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : (string [])) : string =
    let v9 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method16(v9)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v22 : string = "documents.main"
    let v23 : string = v17 + v22 
    let v35 : string = " / "
    let v36 : string = v23 + v35 
    let v44 : string = method17(v8)
    let v45 : string = v36 + v44 
    method22(v45)
and closure12 () (v0 : string) : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and method25 () : string =
    let v0 : string = "source-dir"
    v0
and closure13 () (v0 : std_string_String) : US8 =
    US8_0(v0)
and method26 () : (std_string_String -> US8) =
    closure13()
and method27 () : string =
    let v0 : string = "dist-dir"
    v0
and method28 () : string =
    let v0 : string = "cache-dir"
    v0
and method29 () : string =
    let v0 : string = "hangul-spec"
    v0
and method30 () : string =
    let v0 : string = "filter"
    v0
and method31 () : string =
    let v0 : string = "transcribe-only"
    v0
and method33 () : string =
    let v12 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    v12 ()
and method35 (v0 : string, v1 : string) : string =
    let v8 : string = System.IO.Path.Combine (v0, v1)
    v8
and method37 (v0 : string) : bool =
    let v33 : (string -> bool) = System.IO.File.Exists
    v33 v0
and closure14 () (v0 : string) : bool =
    method37(v0)
and method38 (v0 : string) : bool =
    let v3 : (string -> bool) = System.IO.Directory.Exists
    v3 v0
and closure15 () (v0 : string) : bool =
    method38(v0)
and method40 (v0 : string) : string option =
    let v3 : (string -> System_IO_DirectoryInfo) = System.IO.Directory.GetParent
    let v4 : System_IO_DirectoryInfo = v3 v0
    let v7 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let v49 : bool = v4 = v7 
    let v70 : US3 =
        if v49 then
            US3_1
        else
            let v60 : (System_IO_DirectoryInfo -> string) = _.FullName
            let v61 : string = v60 v4
            US3_0(v61)
    match v70 with
    | US3_1 -> (* None *)
        let v82 : string option = None
        v82
    | US3_0(v71) -> (* Some *)
        let v74 : string option = Some v71 
        v74
and method41 (v0 : string, v1 : string, v2 : bool, v3 : (string -> bool), v4 : string) : US10 =
    let v5 : string = method35(v4, v0)
    let v6 : bool = v3 v5
    if v6 then
        US10_0(v4)
    else
        let v8 : string option = method40(v4)
        let v9 : (string -> US3) = method4()
        let v10 : US3 option = v8 |> Option.map v9 
        let v11 : US3 = US3_1
        let v12 : US3 = v10 |> Option.defaultValue v11 
        match v12 with
        | US3_1 -> (* None *)
            let v17 : string =
                if v2 then
                    let v15 : string = "file"
                    v15
                else
                    let v16 : string = "dir"
                    v16
            let v22 : string = "file_system.find_parent / No parent for "
            let v23 : string = v22 + v17 
            let v31 : string = $" '{v0}' at '{v1}' (until '{v4}')"
            let v32 : string = v23 + v31 
            US10_1(v32)
        | US3_0(v13) -> (* Some *)
            method41(v0, v1, v2, v3, v13)
and method39 (v0 : string, v1 : string, v2 : bool, v3 : (string -> bool)) : US10 =
    let v4 : string = method35(v1, v0)
    let v5 : bool = v3 v4
    if v5 then
        US10_0(v1)
    else
        let v7 : string option = method40(v1)
        let v8 : (string -> US3) = method4()
        let v9 : US3 option = v7 |> Option.map v8 
        let v10 : US3 = US3_1
        let v11 : US3 = v9 |> Option.defaultValue v10 
        match v11 with
        | US3_1 -> (* None *)
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
            US10_1(v20)
        | US3_0(v12) -> (* Some *)
            method41(v0, v1, v2, v3, v12)
and method36 (v0 : US9, v1 : string, v2 : string) : US10 =
    let v3 : bool =
        match v0 with
        | US9_0 -> (* File *)
            true
        | _ ->
            false
    let v6 : (string -> bool) =
        if v3 then
            closure14()
        else
            closure15()
    method39(v1, v2, v3, v6)
and method42 () : string =
    let v2 : string = "\u001b[93m"
    
    
    
    
    
    let v8 : string = "Warning"
    let v9 : (unit -> string) = v8.ToLower
    let v10 : string = v9 ()
    let v11 : char = v10.[int 0]
    let v12 : string = method12(v11)
    let v13 : string = v2 + v12 
    let v14 : string = "\u001b[0m"
    let v15 : string = v13 + v14 
    v15
and method45 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "dir"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method46 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "; "
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method47 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "error"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method44 (v0 : string, v1 : string) : string =
    let v2 : string = method13()
    let v3 : Mut3 = {l0 = v2} : Mut3
    method18(v3)
    method45(v3)
    method20(v3)
    method14(v3, v0)
    method46(v3)
    method47(v3)
    method20(v3)
    method14(v3, v1)
    method21(v3)
    let v73 : string = v3.l0
    v73
and method43 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method16(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v21 : string = "file_system.get_workspace_root"
    let v22 : string = v16 + v21 
    let v30 : string = " / "
    let v31 : string = v22 + v30 
    let v32 : string = method44(v8, v9)
    let v33 : string = v31 + v32 
    method22(v33)
and method51 (v0 : System_IO_DirectoryInfo) : System.IO.FileAttributes =
    let v45 : (System_IO_DirectoryInfo -> System.IO.FileAttributes) = _.Attributes
    v45 v0
and method52 () : System.IO.FileAttributes =
    let v2 : System.IO.FileAttributes = System.IO.FileAttributes.ReparsePoint
    v2
and method53 (v0 : System.IO.FileAttributes, v1 : System.IO.FileAttributes) : bool =
    let v4 : bool = v1.HasFlag v0 
    v4
and method56 (v0 : string) : string =
    let v7 : (string -> string) = System.IO.Path.GetFileName
    v7 v0
and method57 (v0 : std_io_Error) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v15 : string = $"%A{v0}"
    method14(v2, v15)
    let v26 : string = v2.l0
    v26
and closure18 () (v0 : std_path_PathBuf) : US11 =
    US11_0(v0)
and method58 () : (std_path_PathBuf -> US11) =
    closure18()
and closure19 () (v0 : std_io_Error) : US11 =
    US11_1(v0)
and method59 () : (std_io_Error -> US11) =
    closure19()
and closure20 () (v0 : std_path_PathBuf) : US12 =
    US12_0(v0)
and method60 () : (std_path_PathBuf -> US12) =
    closure20()
and closure21 () (v0 : string) : US12 =
    US12_1(v0)
and method61 () : (string -> US12) =
    closure21()
and closure22 (v0 : std_path_Display) () : string =
    let v1 : string = v0 |> string 
    v1
and closure23 () (v0 : string) : US13 =
    US13_0(v0)
and closure24 () (v0 : exn) : US13 =
    US13_1(v0)
and method62 (v0 : std_path_Display) : US13 =
    let v1 : (unit -> string) = closure22(v0)
    let v2 : (string -> US13) = closure23()
    let v3 : ((unit -> exn) -> exn) = closure5()
    let v4 : (exn -> US13) = closure24()
    let v5 : US13 = try v1 () |> v2 with ex -> (fun () -> ex) |> v3 |> v4 
    v5
and method55 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : std_io_Error, v4 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v5 : string = method56(v4)
    let v6 : string option = method40(v4)
    let v7 : (string -> US3) = method4()
    let v8 : US3 option = v6 |> Option.map v7 
    let v9 : US3 = US3_1
    let v10 : US3 = v8 |> Option.defaultValue v9 
    let v11 : string = method57(v3)
    let v12 : bool = v2 >= 11uy
    if v12 then
        let v13 : string = $"file_system.read_link / "
        let v14 : string = $"path: {v0} / n: {v2} / path': {v4} / name: {v5}"
        let v15 : string = v13 + v14 
        let v16 : std_io_Error = v15 |> unbox<std_io_Error>
        let v19 : Result<std_path_PathBuf, std_io_Error> = Error v16 
        v19
    else
        match v10 with
        | US3_0(v27) -> (* Some *)
            let v28 : string = ""
            let v29 : bool = v4 <> v28 
            if v29 then
                let v31 : uint8 = v2 + 1uy
                let v32 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v31
                let v33 : Result<std_path_PathBuf, std_io_Error> = v32 v27
                let v34 : (std_path_PathBuf -> US11) = method58()
                let v35 : (std_io_Error -> US11) = method59()
                let v38 : US11 = match v33 with Ok x -> v34 x | Error x -> v35 x
                let v74 : US12 =
                    match v38 with
                    | US11_1(v70) -> (* Error *)
                        let v71 : string = method57(v70)
                        US12_1(v71)
                    | US11_0(v68) -> (* Ok *)
                        US12_0(v68)
                let v120 : Result<std_path_PathBuf, string> =
                    match v74 with
                    | US12_1(v108) -> (* Error *)
                        let v111 : Result<std_path_PathBuf, string> = Error v108 
                        v111
                    | US12_0(v75) -> (* Ok *)
                        let v78 : Result<std_path_PathBuf, string> = Ok v75 
                        v78
                let v121 : (std_path_PathBuf -> US12) = method60()
                let v122 : (string -> US12) = method61()
                let v125 : US12 = match v120 with Ok x -> v121 x | Error x -> v122 x
                match v125 with
                | US12_1(v277) -> (* Error *)
                    let v278 : string = $"file_system.read_link / "
                    let v279 : string = $"error': {v277} / error: {v11} / name: {v5}"
                    let v280 : string = v278 + v279 
                    let v281 : std_io_Error = v280 |> unbox<std_io_Error>
                    let v282 : Result<std_path_PathBuf, std_io_Error> = Error v281 
                    v282
                | US12_0(v155) -> (* Ok *)
                    let v156 : std_path_Display = v155 |> unbox<std_path_Display>
                    let v176 : US13 = method62(v156)
                    let v222 : US3 =
                        match v176 with
                        | US13_1(v219) -> (* Error *)
                            US3_1
                        | US13_0(v217) -> (* Ok *)
                            US3_0(v217)
                    let v267 : string =
                        match v222 with
                        | US3_1 -> (* None *)
                            failwith<string> "Option does not have a value."
                        | US3_0(v264) -> (* Some *)
                            v264
                    let v268 : string = method35(v267, v5)
                    let v269 : Ref<Str> = v268 |> unbox<Ref<Str>>
                    let v270 : std_string_String = v269 |> unbox<std_string_String>
                    let v273 : std_path_PathBuf = v270 |> unbox<std_path_PathBuf>
                    let v276 : Result<std_path_PathBuf, std_io_Error> = Ok v273 
                    v276
            else
                let v285 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v286 : string = $"path: {v0} / error: {v11} / path': {v4} / name: {v5}"
                let v287 : string = v285 + v286 
                let v288 : std_io_Error = v287 |> unbox<std_io_Error>
                let v289 : Result<std_path_PathBuf, std_io_Error> = Error v288 
                v289
        | _ ->
            let v291 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v292 : string = $"path: {v0} / error: {v11} / path': {v4} / name: {v5}"
            let v293 : string = v291 + v292 
            let v294 : std_io_Error = v293 |> unbox<std_io_Error>
            let v295 : Result<std_path_PathBuf, std_io_Error> = Error v294 
            v295
and method54 (v0 : string, v1 : uint8, v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v3 : System_IO_DirectoryInfo = v2 |> System_IO_DirectoryInfo 
    let v4 : System.IO.FileAttributes = method51(v3)
    let v5 : System.IO.FileAttributes = method52()
    let v6 : bool = method53(v5, v4)
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
        let v18 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure16(v0)
        method55(v0, v18, v1, v17, v2)
and closure17 (v0 : string, v1 : uint8) (v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    method54(v0, v1, v2)
and closure16 (v0 : string) (v1 : uint8) : (string -> Result<std_path_PathBuf, std_io_Error>) =
    closure17(v0, v1)
and method63 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : std_io_Error) : Result<std_path_PathBuf, std_io_Error> =
    let v4 : string = method56(v0)
    let v5 : string option = method40(v0)
    let v6 : (string -> US3) = method4()
    let v7 : US3 option = v5 |> Option.map v6 
    let v8 : US3 = US3_1
    let v9 : US3 = v7 |> Option.defaultValue v8 
    let v10 : string = method57(v3)
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
        | US3_0(v17) -> (* Some *)
            let v18 : string = ""
            let v19 : bool = v0 <> v18 
            if v19 then
                let v20 : uint8 = v2 + 1uy
                let v21 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v20
                let v22 : Result<std_path_PathBuf, std_io_Error> = v21 v17
                let v23 : (std_path_PathBuf -> US11) = method58()
                let v24 : (std_io_Error -> US11) = method59()
                let v25 : US11 = match v22 with Ok x -> v23 x | Error x -> v24 x
                let v32 : US12 =
                    match v25 with
                    | US11_1(v28) -> (* Error *)
                        let v29 : string = method57(v28)
                        US12_1(v29)
                    | US11_0(v26) -> (* Ok *)
                        US12_0(v26)
                let v38 : Result<std_path_PathBuf, string> =
                    match v32 with
                    | US12_1(v35) -> (* Error *)
                        let v36 : Result<std_path_PathBuf, string> = Error v35 
                        v36
                    | US12_0(v33) -> (* Ok *)
                        let v34 : Result<std_path_PathBuf, string> = Ok v33 
                        v34
                let v39 : (std_path_PathBuf -> US12) = method60()
                let v40 : (string -> US12) = method61()
                let v41 : US12 = match v38 with Ok x -> v39 x | Error x -> v40 x
                match v41 with
                | US12_1(v60) -> (* Error *)
                    let v61 : string = $"file_system.read_link / "
                    let v62 : string = $"error': {v60} / error: {v10} / name: {v4}"
                    let v63 : string = v61 + v62 
                    let v64 : std_io_Error = v63 |> unbox<std_io_Error>
                    let v65 : Result<std_path_PathBuf, std_io_Error> = Error v64 
                    v65
                | US12_0(v42) -> (* Ok *)
                    let v43 : std_path_Display = v42 |> unbox<std_path_Display>
                    let v44 : US13 = method62(v43)
                    let v50 : US3 =
                        match v44 with
                        | US13_1(v47) -> (* Error *)
                            US3_1
                        | US13_0(v45) -> (* Ok *)
                            US3_0(v45)
                    let v54 : string =
                        match v50 with
                        | US3_1 -> (* None *)
                            failwith<string> "Option does not have a value."
                        | US3_0(v51) -> (* Some *)
                            v51
                    let v55 : string = method35(v54, v4)
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
and method50 (v0 : string, v1 : uint8) : Result<std_path_PathBuf, std_io_Error> =
    let v5 : System_IO_DirectoryInfo = v0 |> System_IO_DirectoryInfo 
    let v13 : System.IO.FileAttributes = method51(v5)
    let v14 : System.IO.FileAttributes = method52()
    let v15 : bool = method53(v14, v13)
    if v15 then
        let v60 : System_IO_FileInfo = v0 |> System_IO_FileInfo 
        let v70 : (System_IO_FileInfo -> string) = _.LinkTarget
        let v71 : string = v70 v60
        let v239 : std_path_PathBuf = v71 |> unbox<std_path_PathBuf>
        let v249 : Result<std_path_PathBuf, std_io_Error> = Ok v239 
        v249
    else
        let v279 : string = $"file_system.read_link / Fsharp / "
        let v280 : string = $"The file or directory is not a reparse point. / "
        let v281 : string = v279 + v280 
        let v282 : string = $"path: {v0} / result: {v15} / path': {v0} / n: {v1}"
        let v283 : string = v281 + v282 
        let v534 : std_io_Error = v283 |> unbox<std_io_Error>
        let v543 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure16(v0)
        method63(v0, v543, v1, v534)
and method49 (v0 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v3 : uint8 = 0uy
    method50(v0, v3)
and closure25 () (v0 : std_path_PathBuf) : US14 =
    US14_0(v0)
and method64 () : (std_path_PathBuf -> US14) =
    closure25()
and method65 (v0 : string, v1 : string, v2 : string) : string =
    let v5 : string = System.Text.RegularExpressions.Regex.Replace (v2, v0, v1)
    v5
and method48 (v0 : string) : string =
    let v1 : bool = v0 = ""
    if v1 then
        let v2 : string = ""
        v2
    else
        let v3 : Result<std_path_PathBuf, std_io_Error> = method49(v0)
        let v4 : (std_path_PathBuf -> US11) = method58()
        let v5 : (std_io_Error -> US11) = method59()
        let v6 : US11 = match v3 with Ok x -> v4 x | Error x -> v5 x
        let v12 : US14 =
            match v6 with
            | US11_1(v9) -> (* Error *)
                US14_1
            | US11_0(v7) -> (* Ok *)
                US14_0(v7)
        let v26 : std_path_PathBuf option =
            match v12 with
            | US14_1 -> (* None *)
                let v24 : std_path_PathBuf option = None
                v24
            | US14_0(v13) -> (* Some *)
                let v16 : std_path_PathBuf option = Some v13 
                v16
        let v27 : (std_path_PathBuf -> US14) = method64()
        let v28 : US14 option = v26 |> Option.map v27 
        let v32 : US14 = US14_1
        let v33 : US14 = v28 |> Option.defaultValue v32 
        let v50 : string =
            match v33 with
            | US14_1 -> (* None *)
                v0
            | US14_0(v36) -> (* Some *)
                let v37 : std_path_Display = v36 |> unbox<std_path_Display>
                let v38 : US13 = method62(v37)
                let v44 : US3 =
                    match v38 with
                    | US13_1(v41) -> (* Error *)
                        US3_1
                    | US13_0(v39) -> (* Ok *)
                        US3_0(v39)
                match v44 with
                | US3_1 -> (* None *)
                    failwith<string> "Option does not have a value."
                | US3_0(v45) -> (* Some *)
                    v45
        let v51 : bool = v50 = ""
        let v52 : string =
            if v51 then
                v0
            else
                v50
        let v53 : string = "^\\\\\\\\\\?\\\\"
        let v54 : string = ""
        let v55 : string = method65(v53, v54, v52)
        let v56 : int32 = v55.Length
        let v57 : bool = v56 < 2
        if v57 then
            v0
        else
            let v60 : string = v55.[int 0..int 0]
            let v68 : (unit -> string) = v60.ToLower
            let v69 : string = v68 ()
            let v77 : int32 = v56 - 1
            let v80 : string = v55.[int 1..int v77]
            let v87 : string = v69 + v80 
            let v94 : string = "\\"
            let v95 : string = "/"
            let v96 : string = v87.Replace (v94, v95)
            v96
and method34 (v0 : string) : US3 =
    let v1 : US9 = US9_1
    let v2 : string = "spiral"
    let v3 : string = "workspace"
    let v4 : string = method35(v2, v3)
    let v5 : US10 = method36(v1, v4, v0)
    match v5 with
    | US10_1(v9) -> (* Error *)
        let v10 : bool = TraceState.trace_state.IsNone
        if v10 then
            let v11 : US0 = US0_0
            let struct (v12 : Mut0, v13 : Mut1, v14 : Mut2, v15 : Mut3, v16 : Mut4, v17 : int64 option) = method1(v11)
            let v18 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v12, v13, v14, v15, v16, v17) 
            TraceState.trace_state <- v18 
            ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v25 : US0 = v23.l0
        let v30 : int32 =
            match v25 with
            | US0_4 -> (* Critical *)
                50
            | US0_1 -> (* Debug *)
                20
            | US0_2 -> (* Info *)
                30
            | US0_0 -> (* Verbose *)
                10
            | US0_3 -> (* Warning *)
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
        let v75 : US7 =
            if v35 then
                US7_1
            else
                let v37 : bool = TraceState.trace_state.IsNone
                if v37 then
                    let v38 : US0 = US0_0
                    let struct (v39 : Mut0, v40 : Mut1, v41 : Mut2, v42 : Mut3, v43 : Mut4, v44 : int64 option) = method1(v38)
                    let v45 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v39, v40, v41, v42, v43, v44) 
                    TraceState.trace_state <- v45 
                    ()
                let struct (v46 : Mut0, v47 : Mut1, v48 : Mut2, v49 : Mut3, v50 : Mut4, v51 : int64 option) = TraceState.trace_state.Value
                let v52 : string = method8(v46, v47, v48, v49, v50, v51)
                let v53 : string = method42()
                let v54 : string = method43(v46, v47, v48, v49, v50, v51, v52, v53, v0, v9)
                let v55 : bool = TraceState.trace_state.IsNone
                if v55 then
                    let v56 : US0 = US0_0
                    let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = method1(v56)
                    let v63 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v57, v58, v59, v60, v61, v62) 
                    TraceState.trace_state <- v63 
                    ()
                let struct (v64 : Mut0, v65 : Mut1, v66 : Mut2, v67 : Mut3, v68 : Mut4, v69 : int64 option) = TraceState.trace_state.Value
                let v70 : int64 = v64.l0
                let v71 : int64 = v70 + 1L
                v64.l0 <- v71
                let v72 : (string -> unit) = closure12()
                v72 v54
                let v73 : (string -> unit) = v65.l0
                v73 v54
                US7_0(v64, v65, v66, v67, v68, v69)
        US3_1
    | US10_0(v6) -> (* Ok *)
        let v7 : string = method48(v6)
        US3_0(v7)
and method66 (v0 : string) : string =
    let v3 : (string -> string) = System.IO.Path.GetFullPath
    v3 v0
and method67 () : string =
    let v2 : string = "\u001b[94m"
    
    
    
    
    
    let v8 : string = "Debug"
    let v9 : (unit -> string) = v8.ToLower
    let v10 : string = v9 ()
    let v11 : char = v10.[int 0]
    let v12 : string = method12(v11)
    let v13 : string = v2 + v12 
    let v14 : string = "\u001b[0m"
    let v15 : string = v13 + v14 
    v15
and method70 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "source_dir"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method71 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "dist_dir"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method72 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "cache_dir"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method73 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "hangul_spec"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method74 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "filter"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method75 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "transcribe_only"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method69 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : US3, v5 : bool) : string =
    let v6 : string = method13()
    let v7 : Mut3 = {l0 = v6} : Mut3
    method18(v7)
    method70(v7)
    method20(v7)
    method14(v7, v0)
    method46(v7)
    method71(v7)
    method20(v7)
    method14(v7, v1)
    method46(v7)
    method72(v7)
    method20(v7)
    method14(v7, v2)
    method46(v7)
    method73(v7)
    method20(v7)
    method14(v7, v3)
    method46(v7)
    method74(v7)
    method20(v7)
    let v125 : string = $"%A{v4}"
    method14(v7, v125)
    method46(v7)
    method75(v7)
    method20(v7)
    let v158 : string =
        if v5 then
            let v156 : string = "true"
            v156
        else
            let v157 : string = "false"
            v157
    method14(v7, v158)
    method21(v7)
    let v159 : string = v7.l0
    v159
and method68 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : string, v12 : US3, v13 : bool) : string =
    let v14 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v17 : string = method16(v14)
    let v18 : string = v16 + v17 
    let v19 : string = v18 + v7 
    let v20 : string = v19 + v15 
    let v25 : string = "documents.run"
    let v26 : string = v20 + v25 
    let v34 : string = " / "
    let v35 : string = v26 + v34 
    let v36 : string = method69(v8, v9, v10, v11, v12, v13)
    let v37 : string = v35 + v36 
    method22(v37)
and closure27 () (v0 : std_fs_FileType) : US15 =
    US15_0(v0)
and method76 () : (std_fs_FileType -> US15) =
    closure27()
and closure28 () (v0 : std_io_Error) : US15 =
    US15_1(v0)
and method77 () : (std_io_Error -> US15) =
    closure28()
and closure29 () (v0 : std_fs_FileType) : US16 =
    US16_0(v0)
and method78 () : (std_fs_FileType -> US16) =
    closure29()
and closure30 () (v0 : std_string_String) : US16 =
    US16_1(v0)
and method79 () : (std_string_String -> US16) =
    closure30()
and closure26 (v0 : US3) (v1 : async_walkdir_DirEntry) : std_pin_Pin<Box<Dyn<std_future_Future<async_walkdir_Filtering>>>> =
    let v2 : string = "true; let __future_init = Box::pin(/*"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr () v2 
    let v4 : string = "*/ async { /*"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr () v4 
    let v6 : string = "*/ ()"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr () v6 
    let v8 : string = "true; let __future_init = Box::pin(/*"
    let v9 : bool = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : string = "*/ async move { /*"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr () v10 
    let v12 : string = "*/ ()"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "$0"
    let v15 : async_walkdir_DirEntry = Fable.Core.RustInterop.emitRustExpr v1 v14 
    let v16 : string = "Box::pin(async_walkdir::DirEntry::file_type(&v15))"
    let v17 : std_pin_Pin<Box<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v16 
    let v18 : string = "v17.await"
    let v19 : Result<std_fs_FileType, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v18 
    let v20 : (std_fs_FileType -> US15) = method76()
    let v21 : (std_io_Error -> US15) = method77()
    let v23 : US15 = match v19 with Ok x -> v20 x | Error x -> v21 x
    let v30 : US16 =
        match v23 with
        | US15_1(v26) -> (* Error *)
            let v27 : std_string_String = null |> unbox<std_string_String>
            US16_1(v27)
        | US15_0(v24) -> (* Ok *)
            US16_0(v24)
    let v38 : Result<std_fs_FileType, std_string_String> =
        match v30 with
        | US16_1(v34) -> (* Error *)
            let v36 : Result<std_fs_FileType, std_string_String> = Error v34 
            v36
        | US16_0(v31) -> (* Ok *)
            let v33 : Result<std_fs_FileType, std_string_String> = Ok v31 
            v33
    let v39 : (std_fs_FileType -> US16) = method78()
    let v40 : (std_string_String -> US16) = method79()
    let v42 : US16 = match v38 with Ok x -> v39 x | Error x -> v40 x
    let v90 : US17 =
        match v42 with
        | US16_0(v43) -> (* Ok *)
            let v44 : string = "std::fs::FileType::is_dir(&$0)"
            let v45 : bool = Fable.Core.RustInterop.emitRustExpr v43 v44 
            if v45 then
                US17_0
            else
                let v47 : string = "async_walkdir::DirEntry::path(&$0)"
                let v48 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1 v47 
                let v49 : std_path_Display = v48 |> unbox<std_path_Display>
                let v50 : std_string_String = null |> unbox<std_string_String>
                let v51 : string = "Fsharp"
                let v52 : string = () // backend.backend_switch / record_type_try_find / key: v51 
                let v53 : string = ".md"
                let v54 : bool = v52.EndsWith (v53, false, null)
                let v55 : bool = v54 = false
                let v61 : bool =
                    if v55 then
                        true
                    else
                        match v0 with
                        | US3_1 -> (* None *)
                            false
                        | US3_0(v56) -> (* Some *)
                            let v57 : bool = v52.Contains v56 
                            let v58 : bool = v57 = false
                            v58
                let v64 : bool =
                    if v61 then
                        true
                    else
                        let v62 : string = ".hangul.md"
                        let v63 : bool = v52.EndsWith (v62, false, null)
                        v63
                if v64 then
                    US17_0
                else
                    US17_2
        | _ ->
            let v69 : string = "async_walkdir::DirEntry::path(&$0)"
            let v70 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1 v69 
            let v71 : std_path_Display = v70 |> unbox<std_path_Display>
            let v72 : std_string_String = null |> unbox<std_string_String>
            let v73 : string = "Fsharp"
            let v74 : string = () // backend.backend_switch / record_type_try_find / key: v73 
            let v75 : string = ".md"
            let v76 : bool = v74.EndsWith (v75, false, null)
            let v77 : bool = v76 = false
            let v83 : bool =
                if v77 then
                    true
                else
                    match v0 with
                    | US3_1 -> (* None *)
                        false
                    | US3_0(v78) -> (* Some *)
                        let v79 : bool = v74.Contains v78 
                        let v80 : bool = v79 = false
                        v80
            let v86 : bool =
                if v83 then
                    true
                else
                    let v84 : string = ".hangul.md"
                    let v85 : bool = v74.EndsWith (v84, false, null)
                    v85
            if v86 then
                US17_0
            else
                US17_2
    let v91 : string = "Fsharp"
    () // backend.backend_switch / record_type_try_find / key: v91 
    let v92 : string = "__future_init"
    let v93 : _ = Fable.Core.RustInterop.emitRustExpr () v92 
    let v94 : string = "v93"
    let v95 : std_pin_Pin<Box<Dyn<std_future_Future<US17>>>> = Fable.Core.RustInterop.emitRustExpr () v94 
    let v96 : string = "v95.await"
    let v97 : US17 = Fable.Core.RustInterop.emitRustExpr () v96 
    let v106 : async_walkdir_Filtering =
        match v97 with
        | US17_2 -> (* Continue *)
            let v102 : string = "async_walkdir::Filtering::Continue"
            let v103 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v102 
            v103
        | US17_0 -> (* Ignore *)
            let v98 : string = "async_walkdir::Filtering::Ignore"
            let v99 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v98 
            v99
        | US17_1 -> (* IgnoreDir *)
            let v100 : string = "async_walkdir::Filtering::IgnoreDir"
            let v101 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v100 
            v101
    () // backend.backend_switch / record_type_try_find / key: v91 
    let v107 : string = "__future_init"
    let v108 : _ = Fable.Core.RustInterop.emitRustExpr () v107 
    let v109 : string = "v108"
    let v110 : std_pin_Pin<Box<Dyn<std_future_Future<async_walkdir_Filtering>>>> = Fable.Core.RustInterop.emitRustExpr () v109 
    v110
and closure32 () (v0 : async_walkdir_DirEntry) : US18 =
    US18_0(v0)
and method81 () : (async_walkdir_DirEntry -> US18) =
    closure32()
and closure33 () (v0 : async_walkdir_Error) : US18 =
    US18_1(v0)
and method82 () : (async_walkdir_Error -> US18) =
    closure33()
and closure34 () (v0 : async_walkdir_DirEntry) : US19 =
    US19_0(v0)
and method83 () : (async_walkdir_DirEntry -> US19) =
    closure34()
and closure35 () (v0 : std_string_String) : US19 =
    US19_1(v0)
and method84 () : (std_string_String -> US19) =
    closure35()
and method85 () : string =
    let v0 : string = "\u001b[91m"
    
    
    
    
    
    let v1 : string = "Critical"
    let v2 : (unit -> string) = v1.ToLower
    let v3 : string = v2 ()
    let v4 : char = v3.[int 0]
    let v5 : string = method12(v4)
    let v6 : string = v0 + v5 
    let v7 : string = "\u001b[0m"
    let v8 : string = v6 + v7 
    v8
and method87 (v0 : std_string_String) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    method18(v2)
    method47(v2)
    method20(v2)
    let v3 : string = $"%A{v0}"
    method14(v2, v3)
    method21(v2)
    let v4 : string = v2.l0
    v4
and method86 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : int64 = v0.l0
    let v10 : string = " "
    let v11 : string = v6 + v10 
    let v12 : string = method16(v9)
    let v13 : string = v11 + v12 
    let v14 : string = v13 + v7 
    let v15 : string = v14 + v10 
    let v16 : string = "documents.run / stream_filter_map"
    let v17 : string = v15 + v16 
    let v18 : string = " / "
    let v19 : string = v17 + v18 
    let v20 : string = method87(v8)
    let v21 : string = v19 + v20 
    method22(v21)
and closure31 () (v0 : Result<async_walkdir_DirEntry, async_walkdir_Error>) : string option =
    let v1 : (async_walkdir_DirEntry -> US18) = method81()
    let v2 : (async_walkdir_Error -> US18) = method82()
    let v4 : US18 = match v0 with Ok x -> v1 x | Error x -> v2 x
    let v11 : US19 =
        match v4 with
        | US18_1(v7) -> (* Error *)
            let v8 : std_string_String = null |> unbox<std_string_String>
            US19_1(v8)
        | US18_0(v5) -> (* Ok *)
            US19_0(v5)
    let v19 : Result<async_walkdir_DirEntry, std_string_String> =
        match v11 with
        | US19_1(v15) -> (* Error *)
            let v17 : Result<async_walkdir_DirEntry, std_string_String> = Error v15 
            v17
        | US19_0(v12) -> (* Ok *)
            let v14 : Result<async_walkdir_DirEntry, std_string_String> = Ok v12 
            v14
    let v20 : (async_walkdir_DirEntry -> US19) = method83()
    let v21 : (std_string_String -> US19) = method84()
    let v23 : US19 = match v19 with Ok x -> v20 x | Error x -> v21 x
    let v101 : US3 =
        match v23 with
        | US19_1(v32) -> (* Error *)
            let v33 : bool = TraceState.trace_state.IsNone
            if v33 then
                let v34 : US0 = US0_0
                let struct (v35 : Mut0, v36 : Mut1, v37 : Mut2, v38 : Mut3, v39 : Mut4, v40 : int64 option) = method1(v34)
                let v41 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v35, v36, v37, v38, v39, v40) 
                TraceState.trace_state <- v41 
                ()
            let struct (v42 : Mut0, v43 : Mut1, v44 : Mut2, v45 : Mut3, v46 : Mut4, v47 : int64 option) = TraceState.trace_state.Value
            let v48 : US0 = v46.l0
            let v53 : int32 =
                match v48 with
                | US0_4 -> (* Critical *)
                    50
                | US0_1 -> (* Debug *)
                    20
                | US0_2 -> (* Info *)
                    30
                | US0_0 -> (* Verbose *)
                    10
                | US0_3 -> (* Warning *)
                    40
            let v54 : bool = v44.l0
            let v55 : bool = v54 = false
            let v57 : bool =
                if v55 then
                    false
                else
                    let v56 : bool = 50 >= v53
                    v56
            let v58 : bool = v57 = false
            let v98 : US7 =
                if v58 then
                    US7_1
                else
                    let v60 : bool = TraceState.trace_state.IsNone
                    if v60 then
                        let v61 : US0 = US0_0
                        let struct (v62 : Mut0, v63 : Mut1, v64 : Mut2, v65 : Mut3, v66 : Mut4, v67 : int64 option) = method1(v61)
                        let v68 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v62, v63, v64, v65, v66, v67) 
                        TraceState.trace_state <- v68 
                        ()
                    let struct (v69 : Mut0, v70 : Mut1, v71 : Mut2, v72 : Mut3, v73 : Mut4, v74 : int64 option) = TraceState.trace_state.Value
                    let v75 : string = method8(v69, v70, v71, v72, v73, v74)
                    let v76 : string = method85()
                    let v77 : string = method86(v69, v70, v71, v72, v73, v74, v75, v76, v32)
                    let v78 : bool = TraceState.trace_state.IsNone
                    if v78 then
                        let v79 : US0 = US0_0
                        let struct (v80 : Mut0, v81 : Mut1, v82 : Mut2, v83 : Mut3, v84 : Mut4, v85 : int64 option) = method1(v79)
                        let v86 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v80, v81, v82, v83, v84, v85) 
                        TraceState.trace_state <- v86 
                        ()
                    let struct (v87 : Mut0, v88 : Mut1, v89 : Mut2, v90 : Mut3, v91 : Mut4, v92 : int64 option) = TraceState.trace_state.Value
                    let v93 : int64 = v87.l0
                    let v94 : int64 = v93 + 1L
                    v87.l0 <- v94
                    let v95 : (string -> unit) = closure12()
                    v95 v77
                    let v96 : (string -> unit) = v88.l0
                    v96 v77
                    US7_0(v87, v88, v89, v90, v91, v92)
            US3_1
        | US19_0(v24) -> (* Ok *)
            let v25 : string = "async_walkdir::DirEntry::path(&$0)"
            let v26 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v24 v25 
            let v27 : std_path_Display = v26 |> unbox<std_path_Display>
            let v28 : std_string_String = null |> unbox<std_string_String>
            let v29 : string = "Fsharp"
            let v30 : string = () // backend.backend_switch / record_type_try_find / key: v29 
            US3_0(v30)
    match v101 with
    | US3_1 -> (* None *)
        let v104 : string option = None
        v104
    | US3_0(v102) -> (* Some *)
        let v103 : string option = Some v102 
        v103
and method80 () : (Result<async_walkdir_DirEntry, async_walkdir_Error> -> string option) =
    closure31()
and method90 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "files_len"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method89 (v0 : unativeint) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    method18(v2)
    method90(v2)
    method20(v2)
    let v38 : string = $"%A{v0}"
    method14(v2, v38)
    method21(v2)
    let v49 : string = v2.l0
    v49
and method88 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : unativeint) : string =
    let v9 : int64 = v0.l0
    let v10 : string = " "
    let v11 : string = v6 + v10 
    let v12 : string = method16(v9)
    let v13 : string = v11 + v12 
    let v14 : string = v13 + v7 
    let v15 : string = v14 + v10 
    let v16 : string = "documents.run"
    let v17 : string = v15 + v16 
    let v18 : string = " / "
    let v19 : string = v17 + v18 
    let v20 : string = method89(v8)
    let v21 : string = v19 + v20 
    method22(v21)
and method92 () : string =
    let v0 : string = ""
    v0
and method93 (v0 : string) : string =
    let v1 : string = method66(v0)
    method48(v1)
and method95 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : bool) : string =
    v0
and method98 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "c"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method99 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "s'"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method100 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "line_start"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method101 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "position"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method102 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "line"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method103 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "col"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method104 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "text_length"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method97 (v0 : char, v1 : int32, v2 : int32, v3 : int32, v4 : int32) : string =
    let v5 : string = method13()
    let v6 : Mut3 = {l0 = v5} : Mut3
    method18(v6)
    method98(v6)
    method20(v6)
    let v30 : string = $"{v0}"
    method14(v6, v30)
    method46(v6)
    method99(v6)
    method20(v6)
    method18(v6)
    method100(v6)
    method20(v6)
    let v89 : string = $"{v1}"
    method14(v6, v89)
    method46(v6)
    method101(v6)
    method20(v6)
    method18(v6)
    method102(v6)
    method20(v6)
    let v143 : string = $"{v2}"
    method14(v6, v143)
    method46(v6)
    method103(v6)
    method20(v6)
    let v167 : string = $"{v3}"
    method14(v6, v167)
    method21(v6)
    method46(v6)
    method104(v6)
    method20(v6)
    let v191 : string = $"{v4}"
    method14(v6, v191)
    method21(v6)
    method21(v6)
    let v192 : string = v6.l0
    v192
and closure36 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : char = '"'
    let v7 : string = method97(v6, v2, v3, v4, v5)
    let v12 : string = "parsing.p_char / unexpected end of text / "
    let v13 : string = v12 + v7 
    v13
and method105 (v0 : string, v1 : int32, v2 : int32) : int32 =
    let v3 : bool = v2 >= v1
    if v3 then
        v2
    else
        let v4 : char = v0.[int v2]
        let v5 : bool = '\n' = v4
        let v6 : bool = v5 <> true
        if v6 then
            let v7 : int32 = v2 + 1
            method105(v0, v1, v7)
        else
            v2
and closure38 (v0 : int32, v1 : int32) (v2 : string) : string =
    let v3 : bool = v1 >= v0
    if v3 then
        v2
    else
        let v4 : int32 = v1 + 1
        let v5 : (string -> string) = method106(v0, v4)
        let v6 : string = " "
        let v7 : string = v2 + v6 
        v5 v7
and method106 (v0 : int32, v1 : int32) : (string -> string) =
    closure38(v0, v1)
and method108 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "expected"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method107 (v0 : char, v1 : int32, v2 : int32) : string =
    let v3 : string = method13()
    let v4 : Mut3 = {l0 = v3} : Mut3
    method18(v4)
    method108(v4)
    method20(v4)
    let v28 : string = $"{v0}"
    method14(v4, v28)
    method46(v4)
    method102(v4)
    method20(v4)
    let v29 : string = $"{v1}"
    method14(v4, v29)
    method46(v4)
    method103(v4)
    method20(v4)
    let v30 : string = $"{v2}"
    method14(v4, v30)
    method21(v4)
    let v31 : string = v4.l0
    v31
and closure37 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : int32 = v0.Length
    let v7 : int32 = method105(v0, v6, v1)
    let v8 : int32 = v1 + 80
    let v9 : bool = v7 < v8
    let v10 : int32 =
        if v9 then
            v7
        else
            v8
    let v11 : bool = v2 >= v10
    let v18 : string =
        if v11 then
            let v12 : string = ""
            v12
        else
            let v13 : bool = v2 = v10
            let v16 : int32 = v10 - 1
            let v17 : string = v0.[int v2..int v16]
            v17
    let v19 : int32 = v18.Length
    let v20 : bool = v19 > 0
    let v24 : bool =
        if v20 then
            let v21 : int32 = v19 - 1
            let v22 : char = v18.[int v21]
            let v23 : bool = v22 = '\n'
            v23
        else
            false
    let v27 : string =
        if v24 then
            let v25 : string = ""
            v25
        else
            let v26 : string = "\n"
            v26
    let v28 : int32 = v4 - 1
    let v29 : int32 = 0
    let v30 : (string -> string) = method106(v28, v29)
    let v31 : string = ""
    let v32 : string = v30 v31
    let v37 : string = "^"
    let v38 : string = v32 + v37 
    let v46 : char = '"'
    let v47 : string = method107(v46, v3, v4)
    let v52 : string = "parsing.p_char / "
    let v53 : string = v52 + v47 
    let v61 : string = "\n"
    let v62 : string = v53 + v61 
    let v64 : string = v62 + v18 
    let v65 : string = v64 + v27 
    let v66 : string = v65 + v38 
    let v67 : string = v66 + v61 
    v67
and closure39 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : char = '''
    let v7 : string = method97(v6, v2, v3, v4, v5)
    let v8 : string = "parsing.p_char / unexpected end of text / "
    let v9 : string = v8 + v7 
    v9
and closure40 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : int32 = v0.Length
    let v7 : int32 = method105(v0, v6, v1)
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
            let v15 : string = v0.[int v2..int v14]
            v15
    let v17 : int32 = v16.Length
    let v18 : bool = v17 > 0
    let v22 : bool =
        if v18 then
            let v19 : int32 = v17 - 1
            let v20 : char = v16.[int v19]
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
    let v28 : (string -> string) = method106(v26, v27)
    let v29 : string = ""
    let v30 : string = v28 v29
    let v31 : string = "^"
    let v32 : string = v30 + v31 
    let v33 : char = '''
    let v34 : string = method107(v33, v3, v4)
    let v35 : string = "parsing.p_char / "
    let v36 : string = v35 + v34 
    let v37 : string = "\n"
    let v38 : string = v36 + v37 
    let v39 : string = v38 + v16 
    let v40 : string = v39 + v25 
    let v41 : string = v40 + v32 
    let v42 : string = v41 + v37 
    v42
and closure41 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = "parsing.choice / no parsers succeeded"
    v6
and method109 (v0 : (char [])) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v10 : string = $"%A{v0}"
    method14(v2, v10)
    let v18 : string = v2.l0
    v18
and method111 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "chars'"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method112 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "s"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method110 (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32) : string =
    let v5 : string = method13()
    let v6 : Mut3 = {l0 = v5} : Mut3
    method18(v6)
    method111(v6)
    method20(v6)
    method14(v6, v0)
    method46(v6)
    method112(v6)
    method20(v6)
    let v65 : string = $"%A{struct (v1, v2, v3, v4)}"
    method14(v6, v65)
    method21(v6)
    let v76 : string = v6.l0
    v76
and closure42 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v64 : char list = []
    let v65 : char list = ''' :: v64 
    let v66 : char list = '"' :: v65 
    let v119 : (char list -> (char [])) = List.toArray
    let v120 : (char []) = v119 v66
    let v153 : string = method109(v120)
    let v154 : string = method110(v153, v2, v3, v4, v5)
    let v159 : string = "parsing.none_of / unexpected end of text / "
    let v160 : string = v159 + v154 
    v160
and method114 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "first_char"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method113 (v0 : char, v1 : string, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = method13()
    let v7 : Mut3 = {l0 = v6} : Mut3
    method18(v7)
    method114(v7)
    method20(v7)
    let v31 : string = $"{v0}"
    method14(v7, v31)
    method46(v7)
    method111(v7)
    method20(v7)
    method14(v7, v1)
    method46(v7)
    method112(v7)
    method20(v7)
    let v32 : string = $"%A{struct (v2, v3, v4, v5)}"
    method14(v7, v32)
    method21(v7)
    let v33 : string = v7.l0
    v33
and closure43 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : char = v0.[int v1]
    let v7 : char list = []
    let v8 : char list = ''' :: v7 
    let v9 : char list = '"' :: v8 
    let v10 : (char list -> (char [])) = List.toArray
    let v11 : (char []) = v10 v9
    let v12 : string = method109(v11)
    let v13 : string = method113(v6, v12, v2, v3, v4, v5)
    let v18 : string = "parsing.none_of / unexpected char / "
    let v19 : string = v18 + v13 
    v19
and closure44 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = "parsing.many1_chars / inner parser succeeded without consuming text"
    v6
and method115 (v0 : int32, v1 : string, v2 : int32, v3 : int32, v4 : int32, v5 : int32, v6 : int32) : US22 =
    let v7 : bool = v2 >= v6
    let v28 : US21 =
        if v7 then
            let v8 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure42()
            US21_1(v8, v2, v3, v4, v5, v6)
        else
            let v10 : char = v1.[int v2]
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
                US21_0(v10, v15, v20, v21, v22, v23)
            else
                let v25 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure43()
                US21_1(v25, v2, v3, v4, v5, v6)
    match v28 with
    | US21_1(v29, v30, v31, v32, v33, v34) -> (* Error *)
        let v35 : bool = v0 >= v2
        let v40 : string =
            if v35 then
                let v36 : string = ""
                v36
            else
                let v37 : bool = v0 = v2
                let v38 : int32 = v2 - 1
                let v39 : string = v1.[int v0..int v38]
                v39
        US22_0(v40, v2, v3, v4, v5, v6)
    | US21_0(v42, v43, v44, v45, v46, v47) -> (* Ok *)
        let v48 : bool = v43 = v2
        let v49 : bool = v48 <> true
        if v49 then
            method115(v0, v1, v43, v44, v45, v46, v47)
        else
            let v51 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure44()
            US22_1(v51, v2, v3, v4, v5, v6)
and method117 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "rest'"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method116 (v0 : string) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    method18(v2)
    method117(v2)
    method20(v2)
    method14(v2, v0)
    method21(v2)
    let v3 : string = v2.l0
    v3
and closure45 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : int32 = v1 + 80
    let v7 : int32 = v0.Length
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
            let v14 : string = v0.[int v1..int v13]
            v14
    let v16 : string = method116(v15)
    let v21 : string = "parsing.between / expected content or closing delimiter / "
    let v22 : string = v21 + v16 
    v22
and closure47 (v0 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string), v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32, v6 : string) () : string =
    v0 struct (v6, v1, v2, v3, v4, v5)
and method119 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "e"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method120 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "t"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method121 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "rest''"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method118 (v0 : (unit -> string), v1 : string, v2 : string, v3 : string) : string =
    let v4 : string = method13()
    let v5 : Mut3 = {l0 = v4} : Mut3
    method18(v5)
    method119(v5)
    method20(v5)
    let v29 : string = v0 ()
    method14(v5, v29)
    method46(v5)
    method120(v5)
    method20(v5)
    method14(v5, v1)
    method46(v5)
    method117(v5)
    method20(v5)
    method14(v5, v2)
    method46(v5)
    method121(v5)
    method20(v5)
    method14(v5, v3)
    method21(v5)
    let v99 : string = v5.l0
    v99
and closure46 (v0 : int32, v1 : int32, v2 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string), v3 : int32, v4 : int32, v5 : int32, v6 : int32, v7 : int32) struct (v8 : string, v9 : int32, v10 : int32, v11 : int32, v12 : int32, v13 : int32) : string =
    let v14 : int32 = v8.Length
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
            let v25 : string = v8.[int v0..int v24]
            v25
    let v27 : bool = v1 >= v20
    let v32 : string =
        if v27 then
            let v28 : string = ""
            v28
        else
            let v29 : bool = v1 = v20
            let v30 : int32 = v20 - 1
            let v31 : string = v8.[int v1..int v30]
            v31
    let v33 : (unit -> string) = closure47(v2, v3, v4, v5, v6, v7, v8)
    let v34 : string = method118(v33, v8, v26, v32)
    let v39 : string = "parsing.between / expected closing delimiter / "
    let v40 : string = v39 + v34 
    v40
and closure48 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v24 : char list = []
    let v25 : char list = ' ' :: v24 
    let v26 : char list = ''' :: v25 
    let v27 : char list = '"' :: v26 
    let v48 : (char list -> (char [])) = List.toArray
    let v49 : (char []) = v48 v27
    let v50 : string = method109(v49)
    let v51 : string = method110(v50, v2, v3, v4, v5)
    let v52 : string = "parsing.none_of / unexpected end of text / "
    let v53 : string = v52 + v51 
    v53
and closure49 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : char = v0.[int v1]
    let v7 : char list = []
    let v8 : char list = ' ' :: v7 
    let v9 : char list = ''' :: v8 
    let v10 : char list = '"' :: v9 
    let v11 : (char list -> (char [])) = List.toArray
    let v12 : (char []) = v11 v10
    let v13 : string = method109(v12)
    let v14 : string = method113(v6, v13, v2, v3, v4, v5)
    let v15 : string = "parsing.none_of / unexpected char / "
    let v16 : string = v15 + v14 
    v16
and method122 (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : US22 =
    let v6 : bool = v1 >= v5
    let v29 : US21 =
        if v6 then
            let v7 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure48()
            US21_1(v7, v1, v2, v3, v4, v5)
        else
            let v9 : char = v0.[int v1]
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
                US21_0(v9, v16, v21, v22, v23, v24)
            else
                let v26 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure49()
                US21_1(v26, v1, v2, v3, v4, v5)
    match v29 with
    | US21_1(v30, v31, v32, v33, v34, v35) -> (* Error *)
        let v36 : bool = 0 >= v1
        let v41 : string =
            if v36 then
                let v37 : string = ""
                v37
            else
                let v38 : bool = 0 = v1
                let v39 : int32 = v1 - 1
                let v40 : string = v0.[int 0..int v39]
                v40
        US22_0(v41, v1, v2, v3, v4, v5)
    | US21_0(v43, v44, v45, v46, v47, v48) -> (* Ok *)
        let v49 : bool = v44 = v1
        let v50 : bool = v49 <> true
        if v50 then
            method122(v0, v44, v45, v46, v47, v48)
        else
            let v52 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure44()
            US22_1(v52, v1, v2, v3, v4, v5)
and method124 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "rest"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method123 (v0 : string) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    method18(v2)
    method124(v2)
    method20(v2)
    method14(v2, v0)
    method21(v2)
    let v26 : string = v2.l0
    v26
and closure50 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : bool = v1 >= v5
    let v11 : string =
        if v6 then
            let v7 : string = ""
            v7
        else
            let v8 : bool = v1 = v5
            let v9 : int32 = v5 - 1
            let v10 : string = v0.[int v1..int v9]
            v10
    let v12 : string = method123(v11)
    let v17 : string = "parsing.eof / expected end of text / "
    let v18 : string = v17 + v12 
    v18
and method125 (v0 : string, v1 : int32, v2 : int32) : int32 =
    let v3 : bool = v2 >= v1
    if v3 then
        v2
    else
        let v4 : char = v0.[int v2]
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
            method125(v0, v1, v10)
        else
            v2
and closure51 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
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
            let v13 : string = v0.[int v1..int v12]
            v13
    let v15 : string = method123(v14)
    let v20 : string = "parsing.spaces1 / expected at least one space / "
    let v21 : string = v20 + v15 
    v21
and closure52 (v0 : string) () : string =
    v0
and closure53 (v0 : string) () : string =
    v0
and closure54 (v0 : US25) () : US25 =
    v0
and closure55 (v0 : string, v1 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string), v2 : int32, v3 : int32, v4 : int32, v5 : int32, v6 : int32) () : string =
    v1 struct (v0, v2, v3, v4, v5, v6)
and method96 (v0 : string) : US20 =
    let v1 : int32 = v0.Length
    let v2 : bool = 0 >= v1
    let v16 : US21 =
        if v2 then
            let v3 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
            US21_1(v3, 0, 0, 1, 1, v1)
        else
            let v5 : char = v0.[int 0]
            let v6 : bool = v5 = '"'
            if v6 then
                let v7 : bool = '\n' = v5
                let struct (v8 : int32, v9 : int32, v10 : int32, v11 : int32) =
                    if v7 then
                        struct (1, 2, 1, v1)
                    else
                        struct (0, 1, 2, v1)
                US21_0('"', 1, v8, v9, v10, v11)
            else
                let v13 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                US21_1(v13, 0, 0, 1, 1, v1)
    let v60 : US21 =
        match v16 with
        | US21_1(v23, v24, v25, v26, v27, v28) -> (* Error *)
            let v42 : US21 =
                if v2 then
                    let v29 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure39()
                    US21_1(v29, 0, 0, 1, 1, v1)
                else
                    let v31 : char = v0.[int 0]
                    let v32 : bool = v31 = '''
                    if v32 then
                        let v33 : bool = '\n' = v31
                        let struct (v34 : int32, v35 : int32, v36 : int32, v37 : int32) =
                            if v33 then
                                struct (1, 2, 1, v1)
                            else
                                struct (0, 1, 2, v1)
                        US21_0(''', 1, v34, v35, v36, v37)
                    else
                        let v39 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure40()
                        US21_1(v39, 0, 0, 1, 1, v1)
            match v42 with
            | US21_1(v49, v50, v51, v52, v53, v54) -> (* Error *)
                let v55 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure41()
                US21_1(v55, 0, 0, 1, 1, v1)
            | US21_0(v43, v44, v45, v46, v47, v48) -> (* Ok *)
                v42
        | US21_0(v17, v18, v19, v20, v21, v22) -> (* Ok *)
            v16
    let v312 : US22 =
        match v60 with
        | US21_1(v304, v305, v306, v307, v308, v309) -> (* Error *)
            US22_1(v304, v305, v306, v307, v308, v309)
        | US21_0(v61, v62, v63, v64, v65, v66) -> (* Ok *)
            let v67 : bool = v62 >= v66
            let v88 : US21 =
                if v67 then
                    let v68 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure42()
                    US21_1(v68, v62, v63, v64, v65, v66)
                else
                    let v70 : char = v0.[int v62]
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
                        US21_0(v70, v75, v80, v81, v82, v83)
                    else
                        let v85 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure43()
                        US21_1(v85, v62, v63, v64, v65, v66)
            let v104 : US22 =
                match v88 with
                | US21_1(v89, v90, v91, v92, v93, v94) -> (* Error *)
                    US22_1(v89, v90, v91, v92, v93, v94)
                | US21_0(v96, v97, v98, v99, v100, v101) -> (* Ok *)
                    method115(v62, v0, v97, v98, v99, v100, v101)
            let v121 : US22 =
                match v104 with
                | US22_1(v112, v113, v114, v115, v116, v117) -> (* Error *)
                    let v118 : string = ""
                    US22_0(v118, v62, v63, v64, v65, v66)
                | US22_0(v105, v106, v107, v108, v109, v110) -> (* Ok *)
                    US22_0(v105, v106, v107, v108, v109, v110)
            match v121 with
            | US22_1(v212, v213, v214, v215, v216, v217) -> (* Error *)
                let v235 : US21 =
                    if v67 then
                        let v218 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                        US21_1(v218, v62, v63, v64, v65, v66)
                    else
                        let v220 : char = v0.[int v62]
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
                            US21_0('"', v222, v227, v228, v229, v230)
                        else
                            let v232 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                            US21_1(v232, v62, v63, v64, v65, v66)
                let v283 : US21 =
                    match v235 with
                    | US21_1(v242, v243, v244, v245, v246, v247) -> (* Error *)
                        let v265 : US21 =
                            if v67 then
                                let v248 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure39()
                                US21_1(v248, v62, v63, v64, v65, v66)
                            else
                                let v250 : char = v0.[int v62]
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
                                    US21_0(''', v252, v257, v258, v259, v260)
                                else
                                    let v262 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure40()
                                    US21_1(v262, v62, v63, v64, v65, v66)
                        match v265 with
                        | US21_1(v272, v273, v274, v275, v276, v277) -> (* Error *)
                            let v278 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure41()
                            US21_1(v278, v62, v63, v64, v65, v66)
                        | US21_0(v266, v267, v268, v269, v270, v271) -> (* Ok *)
                            v265
                    | US21_0(v236, v237, v238, v239, v240, v241) -> (* Ok *)
                        v235
                match v283 with
                | US21_1(v292, v293, v294, v295, v296, v297) -> (* Error *)
                    let v298 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure45()
                    US22_1(v298, v62, v63, v64, v65, v66)
                | US21_0(v284, v285, v286, v287, v288, v289) -> (* Ok *)
                    let v290 : string = ""
                    US22_0(v290, v285, v286, v287, v288, v289)
            | US22_0(v122, v123, v124, v125, v126, v127) -> (* Ok *)
                let v128 : bool = v123 >= v127
                let v146 : US21 =
                    if v128 then
                        let v129 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                        US21_1(v129, v123, v124, v125, v126, v127)
                    else
                        let v131 : char = v0.[int v123]
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
                            US21_0('"', v133, v138, v139, v140, v141)
                        else
                            let v143 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                            US21_1(v143, v123, v124, v125, v126, v127)
                let v194 : US21 =
                    match v146 with
                    | US21_1(v153, v154, v155, v156, v157, v158) -> (* Error *)
                        let v176 : US21 =
                            if v128 then
                                let v159 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure39()
                                US21_1(v159, v123, v124, v125, v126, v127)
                            else
                                let v161 : char = v0.[int v123]
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
                                    US21_0(''', v163, v168, v169, v170, v171)
                                else
                                    let v173 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure40()
                                    US21_1(v173, v123, v124, v125, v126, v127)
                        match v176 with
                        | US21_1(v183, v184, v185, v186, v187, v188) -> (* Error *)
                            let v189 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure41()
                            US21_1(v189, v123, v124, v125, v126, v127)
                        | US21_0(v177, v178, v179, v180, v181, v182) -> (* Ok *)
                            v176
                    | US21_0(v147, v148, v149, v150, v151, v152) -> (* Ok *)
                        v146
                match v194 with
                | US21_1(v202, v203, v204, v205, v206, v207) -> (* Error *)
                    let v208 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure46(v62, v123, v202, v203, v204, v205, v206, v207)
                    US22_1(v208, v123, v124, v125, v126, v127)
                | US21_0(v195, v196, v197, v198, v199, v200) -> (* Ok *)
                    US22_0(v122, v196, v197, v198, v199, v200)
    let v331 : US22 =
        match v312 with
        | US22_1(v323, v324, v325, v326, v327, v328) -> (* Error *)
            US22_1(v323, v324, v325, v326, v327, v328)
        | US22_0(v313, v314, v315, v316, v317, v318) -> (* Ok *)
            let v319 : string = "\\"
            let v320 : string = "/"
            let v321 : string = v313.Replace (v319, v320)
            US22_0(v321, v314, v315, v316, v317, v318)
    let v399 : US22 =
        match v331 with
        | US22_1(v338, v339, v340, v341, v342, v343) -> (* Error *)
            let v362 : US21 =
                if v2 then
                    let v344 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure48()
                    US21_1(v344, 0, 0, 1, 1, v1)
                else
                    let v346 : char = v0.[int 0]
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
                        US21_0(v346, 1, v354, v355, v356, v357)
                    else
                        let v359 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure49()
                        US21_1(v359, 0, 0, 1, 1, v1)
            let v378 : US22 =
                match v362 with
                | US21_1(v363, v364, v365, v366, v367, v368) -> (* Error *)
                    US22_1(v363, v364, v365, v366, v367, v368)
                | US21_0(v370, v371, v372, v373, v374, v375) -> (* Ok *)
                    method122(v0, v371, v372, v373, v374, v375)
            match v378 with
            | US22_1(v389, v390, v391, v392, v393, v394) -> (* Error *)
                US22_1(v389, v390, v391, v392, v393, v394)
            | US22_0(v379, v380, v381, v382, v383, v384) -> (* Ok *)
                let v385 : string = "\\"
                let v386 : string = "/"
                let v387 : string = v379.Replace (v385, v386)
                US22_0(v387, v380, v381, v382, v383, v384)
        | US22_0(v332, v333, v334, v335, v336, v337) -> (* Ok *)
            v331
    let v434 : US22 =
        match v399 with
        | US22_1(v406, v407, v408, v409, v410, v411) -> (* Error *)
            let v412 : bool = v1 = 0
            let v416 : US23 =
                if v412 then
                    US23_0(0, 0, 1, 1, v1)
                else
                    let v414 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure50()
                    US23_1(v414, 0, 0, 1, 1, v1)
            match v416 with
            | US23_1(v424, v425, v426, v427, v428, v429) -> (* Error *)
                US22_1(v424, v425, v426, v427, v428, v429)
            | US23_0(v417, v418, v419, v420, v421) -> (* Ok *)
                let v422 : string = ""
                US22_0(v422, v417, v418, v419, v420, v421)
        | US22_0(v400, v401, v402, v403, v404, v405) -> (* Ok *)
            v399
    let v547 : US24 =
        match v434 with
        | US22_1(v435, v436, v437, v438, v439, v440) -> (* Error *)
            US24_1(v435, v436, v437, v438, v439, v440)
        | US22_0(v442, v443, v444, v445, v446, v447) -> (* Ok *)
            let v448 : bool = v443 >= v447
            let struct (v460 : int32, v461 : int32, v462 : int32, v463 : int32, v464 : int32) =
                if v448 then
                    struct (v443, v444, v445, v446, v447)
                else
                    let v449 : int32 = method125(v0, v1, v443)
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
            let v470 : US23 =
                if v466 then
                    US23_0(v460, v461, v462, v463, v464)
                else
                    let v468 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure51()
                    US23_1(v468, v443, v444, v445, v446, v447)
            let v508 : US22 =
                match v470 with
                | US23_1(v500, v501, v502, v503, v504, v505) -> (* Error *)
                    US22_1(v500, v501, v502, v503, v504, v505)
                | US23_0(v471, v472, v473, v474, v475) -> (* Ok *)
                    let v476 : bool = v471 >= v475
                    let struct (v488 : int32, v489 : int32, v490 : int32, v491 : int32, v492 : int32) =
                        if v476 then
                            struct (v471, v472, v473, v474, v475)
                        else
                            let v477 : int32 = method105(v0, v1, v471)
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
                            let v497 : string = v0.[int v471..int v496]
                            v497
                    US22_0(v498, v488, v489, v490, v491, v492)
            let v527 : US26 =
                match v508 with
                | US22_1(v518, v519, v520, v521, v522, v523) -> (* Error *)
                    let v524 : US25 = US25_1
                    US26_0(v524, v443, v444, v445, v446, v447)
                | US22_0(v509, v510, v511, v512, v513, v514) -> (* Ok *)
                    let v515 : (unit -> string) = closure52(v509)
                    let v516 : US25 = US25_0(v515)
                    US26_0(v516, v510, v511, v512, v513, v514)
            match v527 with
            | US26_1(v537, v538, v539, v540, v541, v542) -> (* Error *)
                US24_1(v537, v538, v539, v540, v541, v542)
            | US26_0(v528, v529, v530, v531, v532, v533) -> (* Ok *)
                let v534 : (unit -> string) = closure53(v442)
                let v535 : (unit -> US25) = closure54(v528)
                US24_0(v534, v535, v529, v530, v531, v532, v533)
    let v571 : US27 =
        match v547 with
        | US24_1(v562, v563, v564, v565, v566, v567) -> (* Error *)
            let v568 : (unit -> string) = closure55(v0, v562, v563, v564, v565, v566, v567)
            US27_1(v568)
        | US24_0(v548, v549, v550, v551, v552, v553, v554) -> (* Ok *)
            let v555 : bool = v550 >= v554
            let v560 : string =
                if v555 then
                    let v556 : string = ""
                    v556
                else
                    let v557 : bool = v550 = v554
                    let v558 : int32 = v554 - 1
                    let v559 : string = v0.[int v550..int v558]
                    v559
            US27_0(v548, v549, v560, v551, v552, v553, v554)
    let v591 : US28 =
        match v571 with
        | US27_1(v588) -> (* Error *)
            US28_1(v588)
        | US27_0(v572, v573, v574, v575, v576, v577, v578) -> (* Ok *)
            let v579 : string = v572 ()
            let v580 : US25 = v573 ()
            let v586 : US3 =
                match v580 with
                | US25_1 -> (* None *)
                    US3_1
                | US25_0(v581) -> (* Some *)
                    let v582 : string = v581 ()
                    US3_0(v582)
            US28_0(v579, v586)
    match v591 with
    | US28_1(v595) -> (* Error *)
        let v596 : string = v595 ()
        US20_1(v596)
    | US28_0(v592, v593) -> (* Ok *)
        US20_0(v592, v593)
and closure56 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : char = '\\'
    let v7 : string = method97(v6, v2, v3, v4, v5)
    let v8 : string = "parsing.p_char / unexpected end of text / "
    let v9 : string = v8 + v7 
    v9
and closure57 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : int32 = v0.Length
    let v7 : int32 = method105(v0, v6, v1)
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
            let v15 : string = v0.[int v2..int v14]
            v15
    let v17 : int32 = v16.Length
    let v18 : bool = v17 > 0
    let v22 : bool =
        if v18 then
            let v19 : int32 = v17 - 1
            let v20 : char = v16.[int v19]
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
    let v28 : (string -> string) = method106(v26, v27)
    let v29 : string = ""
    let v30 : string = v28 v29
    let v31 : string = "^"
    let v32 : string = v30 + v31 
    let v33 : char = '\\'
    let v34 : string = method107(v33, v3, v4)
    let v35 : string = "parsing.p_char / "
    let v36 : string = v35 + v34 
    let v37 : string = "\n"
    let v38 : string = v36 + v37 
    let v39 : string = v38 + v16 
    let v40 : string = v39 + v25 
    let v41 : string = v40 + v32 
    let v42 : string = v41 + v37 
    v42
and closure58 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : char = '`'
    let v7 : string = method97(v6, v2, v3, v4, v5)
    let v8 : string = "parsing.p_char / unexpected end of text / "
    let v9 : string = v8 + v7 
    v9
and closure59 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : int32 = v0.Length
    let v7 : int32 = method105(v0, v6, v1)
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
            let v15 : string = v0.[int v2..int v14]
            v15
    let v17 : int32 = v16.Length
    let v18 : bool = v17 > 0
    let v22 : bool =
        if v18 then
            let v19 : int32 = v17 - 1
            let v20 : char = v16.[int v19]
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
    let v28 : (string -> string) = method106(v26, v27)
    let v29 : string = ""
    let v30 : string = v28 v29
    let v31 : string = "^"
    let v32 : string = v30 + v31 
    let v33 : char = '`'
    let v34 : string = method107(v33, v3, v4)
    let v35 : string = "parsing.p_char / "
    let v36 : string = v35 + v34 
    let v37 : string = "\n"
    let v38 : string = v36 + v37 
    let v39 : string = v38 + v16 
    let v40 : string = v39 + v25 
    let v41 : string = v40 + v32 
    let v42 : string = v41 + v37 
    v42
and method128 (v0 : int32, v1 : int32, v2 : int32, v3 : int32, v4 : string, v5 : int32, v6 : int32, v7 : int32, v8 : int32, v9 : int32) : struct (int32 * int32 * int32 * int32 * int32) =
    let v10 : bool = v5 >= v3
    if v10 then
        struct (v5, v6, v7, v8, v9)
    else
        let v11 : char = v4.[int v5]
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
            method128(v0, v1, v2, v3, v4, v18, v23, v24, v25, v26)
        else
            struct (v5, v6, v7, v8, v9)
and method127 (v0 : int32, v1 : int32, v2 : int32, v3 : int32, v4 : string, v5 : int32) : struct (int32 * int32 * int32 * int32 * int32) =
    let v6 : bool = v5 >= v3
    if v6 then
        struct (v5, v0, v1, v2, v3)
    else
        let v7 : char = v4.[int v5]
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
            method128(v0, v1, v2, v3, v4, v14, v19, v20, v21, v22)
        else
            struct (v5, v0, v1, v2, v3)
and method130 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "i"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method129 (v0 : int32, v1 : int32, v2 : int32, v3 : int32, v4 : int32) : string =
    let v5 : string = method13()
    let v6 : Mut3 = {l0 = v5} : Mut3
    method18(v6)
    method130(v6)
    method20(v6)
    let v30 : string = $"{v0}"
    method14(v6, v30)
    method46(v6)
    method112(v6)
    method20(v6)
    let v31 : string = $"%A{struct (v1, v2, v3, v4)}"
    method14(v6, v31)
    method21(v6)
    let v32 : string = v6.l0
    v32
and closure60 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = method129(v1, v2, v3, v4, v5)
    let v11 : string = "parsing.many1_satisfy / no matching char / "
    let v12 : string = v11 + v6 
    v12
and closure61 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v10 : char list = []
    let v11 : char list = '"' :: v10 
    let v24 : (char list -> (char [])) = List.toArray
    let v25 : (char []) = v24 v11
    let v26 : string = method109(v25)
    let v27 : string = method110(v26, v2, v3, v4, v5)
    let v28 : string = "parsing.none_of / unexpected end of text / "
    let v29 : string = v28 + v27 
    v29
and closure62 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : char = v0.[int v1]
    let v7 : char list = []
    let v8 : char list = '"' :: v7 
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v11 : string = method109(v10)
    let v12 : string = method113(v6, v11, v2, v3, v4, v5)
    let v13 : string = "parsing.none_of / unexpected char / "
    let v14 : string = v13 + v12 
    v14
and closure63 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = "parsing.many_strings / first inner parser consumed no text"
    v6
and method133 (v0 : bool, v1 : UH0, v2 : UH0) : UH0 =
    match v1 with
    | UH0_1(v3, v4) -> (* Cons *)
        match v4 with
        | UH0_1(v5, v6) -> (* Cons *)
            let v9 : string =
                if v0 then
                    let v7 : string = v5 + v3 
                    v7
                else
                    let v8 : string = v3 + v5 
                    v8
            let v10 : UH0 = UH0_1(v9, v2)
            method133(v0, v6, v10)
        | UH0_0 -> (* Nil *)
            UH0_1(v3, v2)
    | UH0_0 -> (* Nil *)
        v2
and method132 (v0 : bool, v1 : UH0) : string =
    match v1 with
    | UH0_1(v3, v4) -> (* Cons *)
        match v4 with
        | UH0_0 -> (* Nil *)
            v3
        | _ ->
            let v5 : bool = v0 = false
            let v6 : UH0 = UH0_0
            let v7 : UH0 = method133(v0, v1, v6)
            method132(v5, v7)
    | UH0_0 -> (* Nil *)
        let v2 : string = ""
        v2
and closure64 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = "parsing.many_strings / inner parser succeeded without consuming text"
    v6
and method131 (v0 : string, v1 : string, v2 : UH0, v3 : int32, v4 : int32, v5 : int32, v6 : int32, v7 : int32) : US22 =
    let struct (v8 : int32, v9 : int32, v10 : int32, v11 : int32, v12 : int32) = method127(v4, v5, v6, v7, v0, v3)
    let v13 : bool = v8 > v3
    let v23 : US22 =
        if v13 then
            let v14 : bool = v3 >= v8
            let v19 : string =
                if v14 then
                    let v15 : string = ""
                    v15
                else
                    let v16 : bool = v3 = v8
                    let v17 : int32 = v8 - 1
                    let v18 : string = v0.[int v3..int v17]
                    v18
            US22_0(v19, v8, v9, v10, v11, v12)
        else
            let v21 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure60()
            US22_1(v21, v3, v4, v5, v6, v7)
    let v218 : US22 =
        match v23 with
        | US22_1(v30, v31, v32, v33, v34, v35) -> (* Error *)
            let v36 : bool = v3 >= v7
            let v54 : US21 =
                if v36 then
                    let v37 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                    US21_1(v37, v3, v4, v5, v6, v7)
                else
                    let v39 : char = v0.[int v3]
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
                        US21_0('\\', v41, v46, v47, v48, v49)
                    else
                        let v51 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                        US21_1(v51, v3, v4, v5, v6, v7)
            let v89 : US21 =
                match v54 with
                | US21_1(v81, v82, v83, v84, v85, v86) -> (* Error *)
                    US21_1(v81, v82, v83, v84, v85, v86)
                | US21_0(v55, v56, v57, v58, v59, v60) -> (* Ok *)
                    let v61 : bool = v56 >= v60
                    if v61 then
                        let v62 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure61()
                        US21_1(v62, v56, v57, v58, v59, v60)
                    else
                        let v64 : char = v0.[int v56]
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
                            US21_0(v64, v67, v72, v73, v74, v75)
                        else
                            let v77 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure62()
                            US21_1(v77, v56, v57, v58, v59, v60)
            let v111 : US22 =
                match v89 with
                | US21_1(v103, v104, v105, v106, v107, v108) -> (* Error *)
                    US22_1(v103, v104, v105, v106, v107, v108)
                | US21_0(v90, v91, v92, v93, v94, v95) -> (* Ok *)
                    let v96 : bool = v3 >= v91
                    let v101 : string =
                        if v96 then
                            let v97 : string = ""
                            v97
                        else
                            let v98 : bool = v3 = v91
                            let v99 : int32 = v91 - 1
                            let v100 : string = v0.[int v3..int v99]
                            v100
                    US22_0(v101, v91, v92, v93, v94, v95)
            match v111 with
            | US22_1(v118, v119, v120, v121, v122, v123) -> (* Error *)
                let v141 : US21 =
                    if v36 then
                        let v124 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure58()
                        US21_1(v124, v3, v4, v5, v6, v7)
                    else
                        let v126 : char = v0.[int v3]
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
                            US21_0('`', v128, v133, v134, v135, v136)
                        else
                            let v138 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                            US21_1(v138, v3, v4, v5, v6, v7)
                let v176 : US21 =
                    match v141 with
                    | US21_1(v168, v169, v170, v171, v172, v173) -> (* Error *)
                        US21_1(v168, v169, v170, v171, v172, v173)
                    | US21_0(v142, v143, v144, v145, v146, v147) -> (* Ok *)
                        let v148 : bool = v143 >= v147
                        if v148 then
                            let v149 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure61()
                            US21_1(v149, v143, v144, v145, v146, v147)
                        else
                            let v151 : char = v0.[int v143]
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
                                US21_0(v151, v154, v159, v160, v161, v162)
                            else
                                let v164 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure62()
                                US21_1(v164, v143, v144, v145, v146, v147)
                let v198 : US22 =
                    match v176 with
                    | US21_1(v190, v191, v192, v193, v194, v195) -> (* Error *)
                        US22_1(v190, v191, v192, v193, v194, v195)
                    | US21_0(v177, v178, v179, v180, v181, v182) -> (* Ok *)
                        let v183 : bool = v3 >= v178
                        let v188 : string =
                            if v183 then
                                let v184 : string = ""
                                v184
                            else
                                let v185 : bool = v3 = v178
                                let v186 : int32 = v178 - 1
                                let v187 : string = v0.[int v3..int v186]
                                v187
                        US22_0(v188, v178, v179, v180, v181, v182)
                match v198 with
                | US22_1(v205, v206, v207, v208, v209, v210) -> (* Error *)
                    let v211 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure41()
                    US22_1(v211, v3, v4, v5, v6, v7)
                | US22_0(v199, v200, v201, v202, v203, v204) -> (* Ok *)
                    v198
            | US22_0(v112, v113, v114, v115, v116, v117) -> (* Ok *)
                v111
        | US22_0(v24, v25, v26, v27, v28, v29) -> (* Ok *)
            v23
    match v218 with
    | US22_1(v219, v220, v221, v222, v223, v224) -> (* Error *)
        let v228 : string =
            match v2 with
            | UH0_0 -> (* Nil *)
                v1
            | _ ->
                let v225 : bool = true
                let v226 : string = method132(v225, v2)
                let v227 : string = v1 + v226 
                v227
        US22_0(v228, v3, v4, v5, v6, v7)
    | US22_0(v230, v231, v232, v233, v234, v235) -> (* Ok *)
        let v236 : bool = v231 > v3
        if v236 then
            let v237 : UH0 = UH0_1(v230, v2)
            method131(v0, v1, v237, v231, v232, v233, v234, v235)
        else
            let v239 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure64()
            US22_1(v239, v3, v4, v5, v6, v7)
and method134 (v0 : int32, v1 : int32, v2 : int32, v3 : int32) : string =
    let v4 : string = method13()
    let v5 : Mut3 = {l0 = v4} : Mut3
    method18(v5)
    method112(v5)
    method20(v5)
    let v6 : string = $"%A{struct (v0, v1, v2, v3)}"
    method14(v5, v6)
    method21(v5)
    let v7 : string = v5.l0
    v7
and closure65 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = method134(v2, v3, v4, v5)
    let v11 : string = "parsing.any_char / unexpected end of t / "
    let v12 : string = v11 + v6 
    v12
and method135 (v0 : string, v1 : string, v2 : UH0, v3 : int32, v4 : int32, v5 : int32, v6 : int32, v7 : int32) : US22 =
    let struct (v8 : int32, v9 : int32, v10 : int32, v11 : int32, v12 : int32) = method127(v4, v5, v6, v7, v0, v3)
    let v13 : bool = v8 > v3
    let v23 : US22 =
        if v13 then
            let v14 : bool = v3 >= v8
            let v19 : string =
                if v14 then
                    let v15 : string = ""
                    v15
                else
                    let v16 : bool = v3 = v8
                    let v17 : int32 = v8 - 1
                    let v18 : string = v0.[int v3..int v17]
                    v18
            US22_0(v19, v8, v9, v10, v11, v12)
        else
            let v21 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure60()
            US22_1(v21, v3, v4, v5, v6, v7)
    let v208 : US22 =
        match v23 with
        | US22_1(v30, v31, v32, v33, v34, v35) -> (* Error *)
            let v36 : bool = v3 >= v7
            let v54 : US21 =
                if v36 then
                    let v37 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                    US21_1(v37, v3, v4, v5, v6, v7)
                else
                    let v39 : char = v0.[int v3]
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
                        US21_0('\\', v41, v46, v47, v48, v49)
                    else
                        let v51 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                        US21_1(v51, v3, v4, v5, v6, v7)
            let v84 : US21 =
                match v54 with
                | US21_1(v76, v77, v78, v79, v80, v81) -> (* Error *)
                    US21_1(v76, v77, v78, v79, v80, v81)
                | US21_0(v55, v56, v57, v58, v59, v60) -> (* Ok *)
                    let v61 : bool = v56 >= v60
                    if v61 then
                        let v62 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure65()
                        US21_1(v62, v56, v57, v58, v59, v60)
                    else
                        let v64 : char = v0.[int v56]
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
                        US21_0(v64, v65, v70, v71, v72, v73)
            let v106 : US22 =
                match v84 with
                | US21_1(v98, v99, v100, v101, v102, v103) -> (* Error *)
                    US22_1(v98, v99, v100, v101, v102, v103)
                | US21_0(v85, v86, v87, v88, v89, v90) -> (* Ok *)
                    let v91 : bool = v3 >= v86
                    let v96 : string =
                        if v91 then
                            let v92 : string = ""
                            v92
                        else
                            let v93 : bool = v3 = v86
                            let v94 : int32 = v86 - 1
                            let v95 : string = v0.[int v3..int v94]
                            v95
                    US22_0(v96, v86, v87, v88, v89, v90)
            match v106 with
            | US22_1(v113, v114, v115, v116, v117, v118) -> (* Error *)
                let v136 : US21 =
                    if v36 then
                        let v119 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure58()
                        US21_1(v119, v3, v4, v5, v6, v7)
                    else
                        let v121 : char = v0.[int v3]
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
                            US21_0('`', v123, v128, v129, v130, v131)
                        else
                            let v133 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                            US21_1(v133, v3, v4, v5, v6, v7)
                let v166 : US21 =
                    match v136 with
                    | US21_1(v158, v159, v160, v161, v162, v163) -> (* Error *)
                        US21_1(v158, v159, v160, v161, v162, v163)
                    | US21_0(v137, v138, v139, v140, v141, v142) -> (* Ok *)
                        let v143 : bool = v138 >= v142
                        if v143 then
                            let v144 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure65()
                            US21_1(v144, v138, v139, v140, v141, v142)
                        else
                            let v146 : char = v0.[int v138]
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
                            US21_0(v146, v147, v152, v153, v154, v155)
                let v188 : US22 =
                    match v166 with
                    | US21_1(v180, v181, v182, v183, v184, v185) -> (* Error *)
                        US22_1(v180, v181, v182, v183, v184, v185)
                    | US21_0(v167, v168, v169, v170, v171, v172) -> (* Ok *)
                        let v173 : bool = v3 >= v168
                        let v178 : string =
                            if v173 then
                                let v174 : string = ""
                                v174
                            else
                                let v175 : bool = v3 = v168
                                let v176 : int32 = v168 - 1
                                let v177 : string = v0.[int v3..int v176]
                                v177
                        US22_0(v178, v168, v169, v170, v171, v172)
                match v188 with
                | US22_1(v195, v196, v197, v198, v199, v200) -> (* Error *)
                    let v201 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure41()
                    US22_1(v201, v3, v4, v5, v6, v7)
                | US22_0(v189, v190, v191, v192, v193, v194) -> (* Ok *)
                    v188
            | US22_0(v107, v108, v109, v110, v111, v112) -> (* Ok *)
                v106
        | US22_0(v24, v25, v26, v27, v28, v29) -> (* Ok *)
            v23
    match v208 with
    | US22_1(v209, v210, v211, v212, v213, v214) -> (* Error *)
        let v218 : string =
            match v2 with
            | UH0_0 -> (* Nil *)
                v1
            | _ ->
                let v215 : bool = true
                let v216 : string = method132(v215, v2)
                let v217 : string = v1 + v216 
                v217
        US22_0(v218, v3, v4, v5, v6, v7)
    | US22_0(v220, v221, v222, v223, v224, v225) -> (* Ok *)
        let v226 : bool = v221 > v3
        if v226 then
            let v227 : UH0 = UH0_1(v220, v2)
            method135(v0, v1, v227, v221, v222, v223, v224, v225)
        else
            let v229 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure64()
            US22_1(v229, v3, v4, v5, v6, v7)
and method137 (v0 : int32, v1 : string, v2 : int32, v3 : int32, v4 : int32, v5 : int32, v6 : int32) : struct (int32 * int32 * int32 * int32 * int32) =
    let v7 : bool = v2 >= v0
    if v7 then
        struct (v2, v3, v4, v5, v6)
    else
        let v8 : char = v1.[int v2]
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
            method137(v0, v1, v17, v22, v23, v24, v25)
        else
            struct (v2, v3, v4, v5, v6)
and method136 (v0 : int32, v1 : string, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : struct (int32 * int32 * int32 * int32 * int32) =
    let v6 : bool = v2 >= v0
    if v6 then
        struct (v2, v3, v4, v5, v0)
    else
        let v7 : char = v1.[int v2]
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
            method137(v0, v1, v16, v21, v22, v23, v24)
        else
            struct (v2, v3, v4, v5, v0)
and closure66 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v34 : char list = []
    let v35 : char list = '"' :: v34 
    let v36 : char list = '`' :: v35 
    let v37 : char list = '\\' :: v36 
    let v58 : (char list -> (char [])) = List.toArray
    let v59 : (char []) = v58 v37
    let v60 : string = method109(v59)
    let v61 : string = method110(v60, v2, v3, v4, v5)
    let v62 : string = "parsing.none_of / unexpected end of text / "
    let v63 : string = v62 + v61 
    v63
and closure67 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : char = v0.[int v1]
    let v7 : char list = []
    let v8 : char list = '"' :: v7 
    let v9 : char list = '`' :: v8 
    let v10 : char list = '\\' :: v9 
    let v11 : (char list -> (char [])) = List.toArray
    let v12 : (char []) = v11 v10
    let v13 : string = method109(v12)
    let v14 : string = method113(v6, v13, v2, v3, v4, v5)
    let v15 : string = "parsing.none_of / unexpected char / "
    let v16 : string = v15 + v14 
    v16
and method139 (v0 : UH0, v1 : UH0) : UH0 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH0 = UH0_1(v2, v1)
        method139(v3, v4)
    | UH0_0 -> (* Nil *)
        v1
and closure68 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = "parsing.many / inner parser succeeded without consuming text"
    v6
and method138 (v0 : string, v1 : UH0, v2 : int32, v3 : int32, v4 : int32, v5 : int32, v6 : int32) : US30 =
    let v7 : bool = v2 >= v6
    let v25 : US21 =
        if v7 then
            let v8 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
            US21_1(v8, v2, v3, v4, v5, v6)
        else
            let v10 : char = v0.[int v2]
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
                US21_0('\\', v12, v17, v18, v19, v20)
            else
                let v22 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                US21_1(v22, v2, v3, v4, v5, v6)
    let v55 : US21 =
        match v25 with
        | US21_1(v47, v48, v49, v50, v51, v52) -> (* Error *)
            US21_1(v47, v48, v49, v50, v51, v52)
        | US21_0(v26, v27, v28, v29, v30, v31) -> (* Ok *)
            let v32 : bool = v27 >= v31
            if v32 then
                let v33 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure65()
                US21_1(v33, v27, v28, v29, v30, v31)
            else
                let v35 : char = v0.[int v27]
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
                US21_0(v35, v36, v41, v42, v43, v44)
    let v77 : US22 =
        match v55 with
        | US21_1(v69, v70, v71, v72, v73, v74) -> (* Error *)
            US22_1(v69, v70, v71, v72, v73, v74)
        | US21_0(v56, v57, v58, v59, v60, v61) -> (* Ok *)
            let v62 : bool = v2 >= v57
            let v67 : string =
                if v62 then
                    let v63 : string = ""
                    v63
                else
                    let v64 : bool = v2 = v57
                    let v65 : int32 = v57 - 1
                    let v66 : string = v0.[int v2..int v65]
                    v66
            US22_0(v67, v57, v58, v59, v60, v61)
    let v177 : US22 =
        match v77 with
        | US22_1(v84, v85, v86, v87, v88, v89) -> (* Error *)
            let v107 : US21 =
                if v7 then
                    let v90 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure58()
                    US21_1(v90, v2, v3, v4, v5, v6)
                else
                    let v92 : char = v0.[int v2]
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
                        US21_0('`', v94, v99, v100, v101, v102)
                    else
                        let v104 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                        US21_1(v104, v2, v3, v4, v5, v6)
            let v137 : US21 =
                match v107 with
                | US21_1(v129, v130, v131, v132, v133, v134) -> (* Error *)
                    US21_1(v129, v130, v131, v132, v133, v134)
                | US21_0(v108, v109, v110, v111, v112, v113) -> (* Ok *)
                    let v114 : bool = v109 >= v113
                    if v114 then
                        let v115 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure65()
                        US21_1(v115, v109, v110, v111, v112, v113)
                    else
                        let v117 : char = v0.[int v109]
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
                        US21_0(v117, v118, v123, v124, v125, v126)
            let v159 : US22 =
                match v137 with
                | US21_1(v151, v152, v153, v154, v155, v156) -> (* Error *)
                    US22_1(v151, v152, v153, v154, v155, v156)
                | US21_0(v138, v139, v140, v141, v142, v143) -> (* Ok *)
                    let v144 : bool = v2 >= v139
                    let v149 : string =
                        if v144 then
                            let v145 : string = ""
                            v145
                        else
                            let v146 : bool = v2 = v139
                            let v147 : int32 = v139 - 1
                            let v148 : string = v0.[int v2..int v147]
                            v148
                    US22_0(v149, v139, v140, v141, v142, v143)
            match v159 with
            | US22_1(v166, v167, v168, v169, v170, v171) -> (* Error *)
                let v172 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure41()
                US22_1(v172, v2, v3, v4, v5, v6)
            | US22_0(v160, v161, v162, v163, v164, v165) -> (* Ok *)
                v159
        | US22_0(v78, v79, v80, v81, v82, v83) -> (* Ok *)
            v77
    let v194 : US22 =
        match v177 with
        | US22_1(v186, v187, v188, v189, v190, v191) -> (* Error *)
            US22_1(v186, v187, v188, v189, v190, v191)
        | US22_0(v178, v179, v180, v181, v182, v183) -> (* Ok *)
            let v184 : string = ""
            US22_0(v184, v179, v180, v181, v182, v183)
    let v251 : US22 =
        match v194 with
        | US22_1(v243, v244, v245, v246, v247, v248) -> (* Error *)
            US22_1(v243, v244, v245, v246, v247, v248)
        | US22_0(v195, v196, v197, v198, v199, v200) -> (* Ok *)
            let v201 : bool = v196 >= v200
            let v224 : US21 =
                if v201 then
                    let v202 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure66()
                    US21_1(v202, v196, v197, v198, v199, v200)
                else
                    let v204 : char = v0.[int v196]
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
                        US21_0(v204, v211, v216, v217, v218, v219)
                    else
                        let v221 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure67()
                        US21_1(v221, v196, v197, v198, v199, v200)
            match v224 with
            | US21_1(v234, v235, v236, v237, v238, v239) -> (* Error *)
                US22_1(v234, v235, v236, v237, v238, v239)
            | US21_0(v225, v226, v227, v228, v229, v230) -> (* Ok *)
                let v231 : string = v225 |> _.ToString()
                US22_0(v231, v226, v227, v228, v229, v230)
    match v251 with
    | US22_1(v252, v253, v254, v255, v256, v257) -> (* Error *)
        let v258 : UH0 = UH0_0
        let v259 : UH0 = method139(v1, v258)
        US30_0(v259, v2, v3, v4, v5, v6)
    | US22_0(v261, v262, v263, v264, v265, v266) -> (* Ok *)
        let v267 : bool = v262 > v2
        if v267 then
            let v268 : UH0 = UH0_1(v261, v1)
            method138(v0, v268, v262, v263, v264, v265, v266)
        else
            let v270 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure68()
            US30_1(v270, v2, v3, v4, v5, v6)
and method140 (v0 : UH0, v1 : string) : struct (string * string) =
    let struct (v11 : string, v12 : string) =
        match v0 with
        | UH0_1(v2, v3) -> (* Cons *)
            let struct (v4 : string, v5 : string) = method140(v3, v1)
            let v6 : string = v2 + v5 
            let v7 : string = v6 + v4 
            let v8 : string = ""
            struct (v7, v8)
        | _ ->
            let struct (v9 : string, v10 : string) =
                match v0 with
                | UH0_0 -> (* Nil *)
                    struct (v1, v1)
            struct (v9, v10)
    struct (v11, v12)
and closure69 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = "runtime.split_args / segment zero-length success"
    v6
and method143 (v0 : int32, v1 : int32, v2 : int32, v3 : int32, v4 : string, v5 : int32, v6 : int32, v7 : int32, v8 : int32, v9 : int32) : struct (int32 * int32 * int32 * int32 * int32) =
    let v10 : bool = v5 >= v3
    if v10 then
        struct (v5, v6, v7, v8, v9)
    else
        let v11 : char = v4.[int v5]
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
            method143(v0, v1, v2, v3, v4, v20, v25, v26, v27, v28)
        else
            struct (v5, v6, v7, v8, v9)
and method142 (v0 : int32, v1 : int32, v2 : int32, v3 : int32, v4 : string, v5 : int32) : struct (int32 * int32 * int32 * int32 * int32) =
    let v6 : bool = v5 >= v3
    if v6 then
        struct (v5, v0, v1, v2, v3)
    else
        let v7 : char = v4.[int v5]
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
            method143(v0, v1, v2, v3, v4, v16, v21, v22, v23, v24)
        else
            struct (v5, v0, v1, v2, v3)
and closure70 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = "parsing.many1_strings / inner parser succeeded without consuming text"
    v6
and method141 (v0 : string, v1 : string, v2 : UH0, v3 : int32, v4 : int32, v5 : int32, v6 : int32, v7 : int32) : US22 =
    let v8 : bool = v3 >= v7
    let v26 : US21 =
        if v8 then
            let v9 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
            US21_1(v9, v3, v4, v5, v6, v7)
        else
            let v11 : char = v0.[int v3]
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
                US21_0('\\', v13, v18, v19, v20, v21)
            else
                let v23 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                US21_1(v23, v3, v4, v5, v6, v7)
    let v60 : US21 =
        match v26 with
        | US21_1(v52, v53, v54, v55, v56, v57) -> (* Error *)
            US21_1(v52, v53, v54, v55, v56, v57)
        | US21_0(v27, v28, v29, v30, v31, v32) -> (* Ok *)
            let v33 : bool = v28 >= v32
            if v33 then
                let v34 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                US21_1(v34, v28, v29, v30, v31, v32)
            else
                let v36 : char = v0.[int v28]
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
                    US21_0('"', v38, v43, v44, v45, v46)
                else
                    let v48 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                    US21_1(v48, v28, v29, v30, v31, v32)
    let v76 : US21 =
        match v60 with
        | US21_1(v68, v69, v70, v71, v72, v73) -> (* Error *)
            US21_1(v68, v69, v70, v71, v72, v73)
        | US21_0(v61, v62, v63, v64, v65, v66) -> (* Ok *)
            US21_0('"', v62, v63, v64, v65, v66)
    let v174 : US21 =
        match v76 with
        | US21_1(v83, v84, v85, v86, v87, v88) -> (* Error *)
            let v106 : US21 =
                if v8 then
                    let v89 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure58()
                    US21_1(v89, v3, v4, v5, v6, v7)
                else
                    let v91 : char = v0.[int v3]
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
                        US21_0('`', v93, v98, v99, v100, v101)
                    else
                        let v103 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                        US21_1(v103, v3, v4, v5, v6, v7)
            let v140 : US21 =
                match v106 with
                | US21_1(v132, v133, v134, v135, v136, v137) -> (* Error *)
                    US21_1(v132, v133, v134, v135, v136, v137)
                | US21_0(v107, v108, v109, v110, v111, v112) -> (* Ok *)
                    let v113 : bool = v108 >= v112
                    if v113 then
                        let v114 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                        US21_1(v114, v108, v109, v110, v111, v112)
                    else
                        let v116 : char = v0.[int v108]
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
                            US21_0('"', v118, v123, v124, v125, v126)
                        else
                            let v128 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                            US21_1(v128, v108, v109, v110, v111, v112)
            let v156 : US21 =
                match v140 with
                | US21_1(v148, v149, v150, v151, v152, v153) -> (* Error *)
                    US21_1(v148, v149, v150, v151, v152, v153)
                | US21_0(v141, v142, v143, v144, v145, v146) -> (* Ok *)
                    US21_0('"', v142, v143, v144, v145, v146)
            match v156 with
            | US21_1(v163, v164, v165, v166, v167, v168) -> (* Error *)
                let v169 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure41()
                US21_1(v169, v3, v4, v5, v6, v7)
            | US21_0(v157, v158, v159, v160, v161, v162) -> (* Ok *)
                v156
        | US21_0(v77, v78, v79, v80, v81, v82) -> (* Ok *)
            v76
    let v805 : US22 =
        match v174 with
        | US21_1(v797, v798, v799, v800, v801, v802) -> (* Error *)
            US22_1(v797, v798, v799, v800, v801, v802)
        | US21_0(v175, v176, v177, v178, v179, v180) -> (* Ok *)
            let struct (v181 : int32, v182 : int32, v183 : int32, v184 : int32, v185 : int32) = method127(v177, v178, v179, v180, v0, v176)
            let v186 : bool = v181 > v176
            let v196 : US22 =
                if v186 then
                    let v187 : bool = v176 >= v181
                    let v192 : string =
                        if v187 then
                            let v188 : string = ""
                            v188
                        else
                            let v189 : bool = v176 = v181
                            let v190 : int32 = v181 - 1
                            let v191 : string = v0.[int v176..int v190]
                            v191
                    US22_0(v192, v181, v182, v183, v184, v185)
                else
                    let v194 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure60()
                    US22_1(v194, v176, v177, v178, v179, v180)
            let v391 : US22 =
                match v196 with
                | US22_1(v203, v204, v205, v206, v207, v208) -> (* Error *)
                    let v209 : bool = v176 >= v180
                    let v227 : US21 =
                        if v209 then
                            let v210 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                            US21_1(v210, v176, v177, v178, v179, v180)
                        else
                            let v212 : char = v0.[int v176]
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
                                US21_0('\\', v214, v219, v220, v221, v222)
                            else
                                let v224 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                                US21_1(v224, v176, v177, v178, v179, v180)
                    let v262 : US21 =
                        match v227 with
                        | US21_1(v254, v255, v256, v257, v258, v259) -> (* Error *)
                            US21_1(v254, v255, v256, v257, v258, v259)
                        | US21_0(v228, v229, v230, v231, v232, v233) -> (* Ok *)
                            let v234 : bool = v229 >= v233
                            if v234 then
                                let v235 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure61()
                                US21_1(v235, v229, v230, v231, v232, v233)
                            else
                                let v237 : char = v0.[int v229]
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
                                    US21_0(v237, v240, v245, v246, v247, v248)
                                else
                                    let v250 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure62()
                                    US21_1(v250, v229, v230, v231, v232, v233)
                    let v284 : US22 =
                        match v262 with
                        | US21_1(v276, v277, v278, v279, v280, v281) -> (* Error *)
                            US22_1(v276, v277, v278, v279, v280, v281)
                        | US21_0(v263, v264, v265, v266, v267, v268) -> (* Ok *)
                            let v269 : bool = v176 >= v264
                            let v274 : string =
                                if v269 then
                                    let v270 : string = ""
                                    v270
                                else
                                    let v271 : bool = v176 = v264
                                    let v272 : int32 = v264 - 1
                                    let v273 : string = v0.[int v176..int v272]
                                    v273
                            US22_0(v274, v264, v265, v266, v267, v268)
                    match v284 with
                    | US22_1(v291, v292, v293, v294, v295, v296) -> (* Error *)
                        let v314 : US21 =
                            if v209 then
                                let v297 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure58()
                                US21_1(v297, v176, v177, v178, v179, v180)
                            else
                                let v299 : char = v0.[int v176]
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
                                    US21_0('`', v301, v306, v307, v308, v309)
                                else
                                    let v311 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                                    US21_1(v311, v176, v177, v178, v179, v180)
                        let v349 : US21 =
                            match v314 with
                            | US21_1(v341, v342, v343, v344, v345, v346) -> (* Error *)
                                US21_1(v341, v342, v343, v344, v345, v346)
                            | US21_0(v315, v316, v317, v318, v319, v320) -> (* Ok *)
                                let v321 : bool = v316 >= v320
                                if v321 then
                                    let v322 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure61()
                                    US21_1(v322, v316, v317, v318, v319, v320)
                                else
                                    let v324 : char = v0.[int v316]
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
                                        US21_0(v324, v327, v332, v333, v334, v335)
                                    else
                                        let v337 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure62()
                                        US21_1(v337, v316, v317, v318, v319, v320)
                        let v371 : US22 =
                            match v349 with
                            | US21_1(v363, v364, v365, v366, v367, v368) -> (* Error *)
                                US22_1(v363, v364, v365, v366, v367, v368)
                            | US21_0(v350, v351, v352, v353, v354, v355) -> (* Ok *)
                                let v356 : bool = v176 >= v351
                                let v361 : string =
                                    if v356 then
                                        let v357 : string = ""
                                        v357
                                    else
                                        let v358 : bool = v176 = v351
                                        let v359 : int32 = v351 - 1
                                        let v360 : string = v0.[int v176..int v359]
                                        v360
                                US22_0(v361, v351, v352, v353, v354, v355)
                        match v371 with
                        | US22_1(v378, v379, v380, v381, v382, v383) -> (* Error *)
                            let v384 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure41()
                            US22_1(v384, v176, v177, v178, v179, v180)
                        | US22_0(v372, v373, v374, v375, v376, v377) -> (* Ok *)
                            v371
                    | US22_0(v285, v286, v287, v288, v289, v290) -> (* Ok *)
                        v284
                | US22_0(v197, v198, v199, v200, v201, v202) -> (* Ok *)
                    v196
            let v413 : US22 =
                match v391 with
                | US22_1(v392, v393, v394, v395, v396, v397) -> (* Error *)
                    let v398 : string = ""
                    US22_0(v398, v176, v177, v178, v179, v180)
                | US22_0(v400, v401, v402, v403, v404, v405) -> (* Ok *)
                    let v406 : bool = v401 = v176
                    if v406 then
                        let v407 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure63()
                        US22_1(v407, v176, v177, v178, v179, v180)
                    else
                        let v409 : UH0 = UH0_0
                        method131(v0, v400, v409, v401, v402, v403, v404, v405)
            match v413 with
            | US22_1(v604, v605, v606, v607, v608, v609) -> (* Error *)
                let v610 : bool = v176 >= v180
                let v628 : US21 =
                    if v610 then
                        let v611 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                        US21_1(v611, v176, v177, v178, v179, v180)
                    else
                        let v613 : char = v0.[int v176]
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
                            US21_0('\\', v615, v620, v621, v622, v623)
                        else
                            let v625 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                            US21_1(v625, v176, v177, v178, v179, v180)
                let v662 : US21 =
                    match v628 with
                    | US21_1(v654, v655, v656, v657, v658, v659) -> (* Error *)
                        US21_1(v654, v655, v656, v657, v658, v659)
                    | US21_0(v629, v630, v631, v632, v633, v634) -> (* Ok *)
                        let v635 : bool = v630 >= v634
                        if v635 then
                            let v636 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                            US21_1(v636, v630, v631, v632, v633, v634)
                        else
                            let v638 : char = v0.[int v630]
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
                                US21_0('"', v640, v645, v646, v647, v648)
                            else
                                let v650 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                                US21_1(v650, v630, v631, v632, v633, v634)
                let v678 : US21 =
                    match v662 with
                    | US21_1(v670, v671, v672, v673, v674, v675) -> (* Error *)
                        US21_1(v670, v671, v672, v673, v674, v675)
                    | US21_0(v663, v664, v665, v666, v667, v668) -> (* Ok *)
                        US21_0('"', v664, v665, v666, v667, v668)
                let v776 : US21 =
                    match v678 with
                    | US21_1(v685, v686, v687, v688, v689, v690) -> (* Error *)
                        let v708 : US21 =
                            if v610 then
                                let v691 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure58()
                                US21_1(v691, v176, v177, v178, v179, v180)
                            else
                                let v693 : char = v0.[int v176]
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
                                    US21_0('`', v695, v700, v701, v702, v703)
                                else
                                    let v705 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                                    US21_1(v705, v176, v177, v178, v179, v180)
                        let v742 : US21 =
                            match v708 with
                            | US21_1(v734, v735, v736, v737, v738, v739) -> (* Error *)
                                US21_1(v734, v735, v736, v737, v738, v739)
                            | US21_0(v709, v710, v711, v712, v713, v714) -> (* Ok *)
                                let v715 : bool = v710 >= v714
                                if v715 then
                                    let v716 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                                    US21_1(v716, v710, v711, v712, v713, v714)
                                else
                                    let v718 : char = v0.[int v710]
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
                                        US21_0('"', v720, v725, v726, v727, v728)
                                    else
                                        let v730 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                                        US21_1(v730, v710, v711, v712, v713, v714)
                        let v758 : US21 =
                            match v742 with
                            | US21_1(v750, v751, v752, v753, v754, v755) -> (* Error *)
                                US21_1(v750, v751, v752, v753, v754, v755)
                            | US21_0(v743, v744, v745, v746, v747, v748) -> (* Ok *)
                                US21_0('"', v744, v745, v746, v747, v748)
                        match v758 with
                        | US21_1(v765, v766, v767, v768, v769, v770) -> (* Error *)
                            let v771 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure41()
                            US21_1(v771, v176, v177, v178, v179, v180)
                        | US21_0(v759, v760, v761, v762, v763, v764) -> (* Ok *)
                            v758
                    | US21_0(v679, v680, v681, v682, v683, v684) -> (* Ok *)
                        v678
                match v776 with
                | US21_1(v785, v786, v787, v788, v789, v790) -> (* Error *)
                    let v791 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure45()
                    US22_1(v791, v176, v177, v178, v179, v180)
                | US21_0(v777, v778, v779, v780, v781, v782) -> (* Ok *)
                    let v783 : string = ""
                    US22_0(v783, v778, v779, v780, v781, v782)
            | US22_0(v414, v415, v416, v417, v418, v419) -> (* Ok *)
                let v420 : bool = v415 >= v419
                let v438 : US21 =
                    if v420 then
                        let v421 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                        US21_1(v421, v415, v416, v417, v418, v419)
                    else
                        let v423 : char = v0.[int v415]
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
                            US21_0('\\', v425, v430, v431, v432, v433)
                        else
                            let v435 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                            US21_1(v435, v415, v416, v417, v418, v419)
                let v472 : US21 =
                    match v438 with
                    | US21_1(v464, v465, v466, v467, v468, v469) -> (* Error *)
                        US21_1(v464, v465, v466, v467, v468, v469)
                    | US21_0(v439, v440, v441, v442, v443, v444) -> (* Ok *)
                        let v445 : bool = v440 >= v444
                        if v445 then
                            let v446 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                            US21_1(v446, v440, v441, v442, v443, v444)
                        else
                            let v448 : char = v0.[int v440]
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
                                US21_0('"', v450, v455, v456, v457, v458)
                            else
                                let v460 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                                US21_1(v460, v440, v441, v442, v443, v444)
                let v488 : US21 =
                    match v472 with
                    | US21_1(v480, v481, v482, v483, v484, v485) -> (* Error *)
                        US21_1(v480, v481, v482, v483, v484, v485)
                    | US21_0(v473, v474, v475, v476, v477, v478) -> (* Ok *)
                        US21_0('"', v474, v475, v476, v477, v478)
                let v586 : US21 =
                    match v488 with
                    | US21_1(v495, v496, v497, v498, v499, v500) -> (* Error *)
                        let v518 : US21 =
                            if v420 then
                                let v501 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure58()
                                US21_1(v501, v415, v416, v417, v418, v419)
                            else
                                let v503 : char = v0.[int v415]
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
                                    US21_0('`', v505, v510, v511, v512, v513)
                                else
                                    let v515 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                                    US21_1(v515, v415, v416, v417, v418, v419)
                        let v552 : US21 =
                            match v518 with
                            | US21_1(v544, v545, v546, v547, v548, v549) -> (* Error *)
                                US21_1(v544, v545, v546, v547, v548, v549)
                            | US21_0(v519, v520, v521, v522, v523, v524) -> (* Ok *)
                                let v525 : bool = v520 >= v524
                                if v525 then
                                    let v526 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                                    US21_1(v526, v520, v521, v522, v523, v524)
                                else
                                    let v528 : char = v0.[int v520]
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
                                        US21_0('"', v530, v535, v536, v537, v538)
                                    else
                                        let v540 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                                        US21_1(v540, v520, v521, v522, v523, v524)
                        let v568 : US21 =
                            match v552 with
                            | US21_1(v560, v561, v562, v563, v564, v565) -> (* Error *)
                                US21_1(v560, v561, v562, v563, v564, v565)
                            | US21_0(v553, v554, v555, v556, v557, v558) -> (* Ok *)
                                US21_0('"', v554, v555, v556, v557, v558)
                        match v568 with
                        | US21_1(v575, v576, v577, v578, v579, v580) -> (* Error *)
                            let v581 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure41()
                            US21_1(v581, v415, v416, v417, v418, v419)
                        | US21_0(v569, v570, v571, v572, v573, v574) -> (* Ok *)
                            v568
                    | US21_0(v489, v490, v491, v492, v493, v494) -> (* Ok *)
                        v488
                match v586 with
                | US21_1(v594, v595, v596, v597, v598, v599) -> (* Error *)
                    let v600 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure46(v176, v415, v594, v595, v596, v597, v598, v599)
                    US22_1(v600, v415, v416, v417, v418, v419)
                | US21_0(v587, v588, v589, v590, v591, v592) -> (* Ok *)
                    US22_0(v414, v588, v589, v590, v591, v592)
    let v1162 : US22 =
        match v805 with
        | US22_1(v812, v813, v814, v815, v816, v817) -> (* Error *)
            let v835 : US21 =
                if v8 then
                    let v818 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                    US21_1(v818, v3, v4, v5, v6, v7)
                else
                    let v820 : char = v0.[int v3]
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
                        US21_0('"', v822, v827, v828, v829, v830)
                    else
                        let v832 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                        US21_1(v832, v3, v4, v5, v6, v7)
            match v835 with
            | US21_1(v1152, v1153, v1154, v1155, v1156, v1157) -> (* Error *)
                US22_1(v1152, v1153, v1154, v1155, v1156, v1157)
            | US21_0(v836, v837, v838, v839, v840, v841) -> (* Ok *)
                let struct (v842 : int32, v843 : int32, v844 : int32, v845 : int32, v846 : int32) = method127(v838, v839, v840, v841, v0, v837)
                let v847 : bool = v842 > v837
                let v857 : US22 =
                    if v847 then
                        let v848 : bool = v837 >= v842
                        let v853 : string =
                            if v848 then
                                let v849 : string = ""
                                v849
                            else
                                let v850 : bool = v837 = v842
                                let v851 : int32 = v842 - 1
                                let v852 : string = v0.[int v837..int v851]
                                v852
                        US22_0(v853, v842, v843, v844, v845, v846)
                    else
                        let v855 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure60()
                        US22_1(v855, v837, v838, v839, v840, v841)
                let v1042 : US22 =
                    match v857 with
                    | US22_1(v864, v865, v866, v867, v868, v869) -> (* Error *)
                        let v870 : bool = v837 >= v841
                        let v888 : US21 =
                            if v870 then
                                let v871 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                                US21_1(v871, v837, v838, v839, v840, v841)
                            else
                                let v873 : char = v0.[int v837]
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
                                    US21_0('\\', v875, v880, v881, v882, v883)
                                else
                                    let v885 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                                    US21_1(v885, v837, v838, v839, v840, v841)
                        let v918 : US21 =
                            match v888 with
                            | US21_1(v910, v911, v912, v913, v914, v915) -> (* Error *)
                                US21_1(v910, v911, v912, v913, v914, v915)
                            | US21_0(v889, v890, v891, v892, v893, v894) -> (* Ok *)
                                let v895 : bool = v890 >= v894
                                if v895 then
                                    let v896 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure65()
                                    US21_1(v896, v890, v891, v892, v893, v894)
                                else
                                    let v898 : char = v0.[int v890]
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
                                    US21_0(v898, v899, v904, v905, v906, v907)
                        let v940 : US22 =
                            match v918 with
                            | US21_1(v932, v933, v934, v935, v936, v937) -> (* Error *)
                                US22_1(v932, v933, v934, v935, v936, v937)
                            | US21_0(v919, v920, v921, v922, v923, v924) -> (* Ok *)
                                let v925 : bool = v837 >= v920
                                let v930 : string =
                                    if v925 then
                                        let v926 : string = ""
                                        v926
                                    else
                                        let v927 : bool = v837 = v920
                                        let v928 : int32 = v920 - 1
                                        let v929 : string = v0.[int v837..int v928]
                                        v929
                                US22_0(v930, v920, v921, v922, v923, v924)
                        match v940 with
                        | US22_1(v947, v948, v949, v950, v951, v952) -> (* Error *)
                            let v970 : US21 =
                                if v870 then
                                    let v953 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure58()
                                    US21_1(v953, v837, v838, v839, v840, v841)
                                else
                                    let v955 : char = v0.[int v837]
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
                                        US21_0('`', v957, v962, v963, v964, v965)
                                    else
                                        let v967 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                                        US21_1(v967, v837, v838, v839, v840, v841)
                            let v1000 : US21 =
                                match v970 with
                                | US21_1(v992, v993, v994, v995, v996, v997) -> (* Error *)
                                    US21_1(v992, v993, v994, v995, v996, v997)
                                | US21_0(v971, v972, v973, v974, v975, v976) -> (* Ok *)
                                    let v977 : bool = v972 >= v976
                                    if v977 then
                                        let v978 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure65()
                                        US21_1(v978, v972, v973, v974, v975, v976)
                                    else
                                        let v980 : char = v0.[int v972]
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
                                        US21_0(v980, v981, v986, v987, v988, v989)
                            let v1022 : US22 =
                                match v1000 with
                                | US21_1(v1014, v1015, v1016, v1017, v1018, v1019) -> (* Error *)
                                    US22_1(v1014, v1015, v1016, v1017, v1018, v1019)
                                | US21_0(v1001, v1002, v1003, v1004, v1005, v1006) -> (* Ok *)
                                    let v1007 : bool = v837 >= v1002
                                    let v1012 : string =
                                        if v1007 then
                                            let v1008 : string = ""
                                            v1008
                                        else
                                            let v1009 : bool = v837 = v1002
                                            let v1010 : int32 = v1002 - 1
                                            let v1011 : string = v0.[int v837..int v1010]
                                            v1011
                                    US22_0(v1012, v1002, v1003, v1004, v1005, v1006)
                            match v1022 with
                            | US22_1(v1029, v1030, v1031, v1032, v1033, v1034) -> (* Error *)
                                let v1035 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure41()
                                US22_1(v1035, v837, v838, v839, v840, v841)
                            | US22_0(v1023, v1024, v1025, v1026, v1027, v1028) -> (* Ok *)
                                v1022
                        | US22_0(v941, v942, v943, v944, v945, v946) -> (* Ok *)
                            v940
                    | US22_0(v858, v859, v860, v861, v862, v863) -> (* Ok *)
                        v857
                let v1064 : US22 =
                    match v1042 with
                    | US22_1(v1043, v1044, v1045, v1046, v1047, v1048) -> (* Error *)
                        let v1049 : string = ""
                        US22_0(v1049, v837, v838, v839, v840, v841)
                    | US22_0(v1051, v1052, v1053, v1054, v1055, v1056) -> (* Ok *)
                        let v1057 : bool = v1052 = v837
                        if v1057 then
                            let v1058 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure63()
                            US22_1(v1058, v837, v838, v839, v840, v841)
                        else
                            let v1060 : UH0 = UH0_0
                            method135(v0, v1051, v1060, v1052, v1053, v1054, v1055, v1056)
                match v1064 with
                | US22_1(v1107, v1108, v1109, v1110, v1111, v1112) -> (* Error *)
                    let v1113 : bool = v837 >= v841
                    let v1131 : US21 =
                        if v1113 then
                            let v1114 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                            US21_1(v1114, v837, v838, v839, v840, v841)
                        else
                            let v1116 : char = v0.[int v837]
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
                                US21_0('"', v1118, v1123, v1124, v1125, v1126)
                            else
                                let v1128 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                                US21_1(v1128, v837, v838, v839, v840, v841)
                    match v1131 with
                    | US21_1(v1140, v1141, v1142, v1143, v1144, v1145) -> (* Error *)
                        let v1146 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure45()
                        US22_1(v1146, v837, v838, v839, v840, v841)
                    | US21_0(v1132, v1133, v1134, v1135, v1136, v1137) -> (* Ok *)
                        let v1138 : string = ""
                        US22_0(v1138, v1133, v1134, v1135, v1136, v1137)
                | US22_0(v1065, v1066, v1067, v1068, v1069, v1070) -> (* Ok *)
                    let v1071 : bool = v1066 >= v1070
                    let v1089 : US21 =
                        if v1071 then
                            let v1072 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                            US21_1(v1072, v1066, v1067, v1068, v1069, v1070)
                        else
                            let v1074 : char = v0.[int v1066]
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
                                US21_0('"', v1076, v1081, v1082, v1083, v1084)
                            else
                                let v1086 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                                US21_1(v1086, v1066, v1067, v1068, v1069, v1070)
                    match v1089 with
                    | US21_1(v1097, v1098, v1099, v1100, v1101, v1102) -> (* Error *)
                        let v1103 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure46(v837, v1066, v1097, v1098, v1099, v1100, v1101, v1102)
                        US22_1(v1103, v1066, v1067, v1068, v1069, v1070)
                    | US21_0(v1090, v1091, v1092, v1093, v1094, v1095) -> (* Ok *)
                        US22_0(v1065, v1091, v1092, v1093, v1094, v1095)
        | US22_0(v806, v807, v808, v809, v810, v811) -> (* Ok *)
            v805
    let v1192 : US22 =
        match v1162 with
        | US22_1(v1169, v1170, v1171, v1172, v1173, v1174) -> (* Error *)
            let struct (v1175 : int32, v1176 : int32, v1177 : int32, v1178 : int32, v1179 : int32) = method142(v4, v5, v6, v7, v0, v3)
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
                        let v1185 : string = v0.[int v3..int v1184]
                        v1185
                US22_0(v1186, v1175, v1176, v1177, v1178, v1179)
            else
                let v1188 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure60()
                US22_1(v1188, v3, v4, v5, v6, v7)
        | US22_0(v1163, v1164, v1165, v1166, v1167, v1168) -> (* Ok *)
            v1162
    let v1227 : US22 =
        match v1192 with
        | US22_1(v1199, v1200, v1201, v1202, v1203, v1204) -> (* Error *)
            let v1205 : UH0 = UH0_0
            let v1206 : US30 = method138(v0, v1205, v3, v4, v5, v6, v7)
            match v1206 with
            | US30_1(v1217, v1218, v1219, v1220, v1221, v1222) -> (* Error *)
                US22_1(v1217, v1218, v1219, v1220, v1221, v1222)
            | US30_0(v1207, v1208, v1209, v1210, v1211, v1212) -> (* Ok *)
                let v1213 : string = ""
                let struct (v1214 : string, v1215 : string) = method140(v1207, v1213)
                US22_0(v1214, v1208, v1209, v1210, v1211, v1212)
        | US22_0(v1193, v1194, v1195, v1196, v1197, v1198) -> (* Ok *)
            v1192
    let v1238 : US22 =
        match v1227 with
        | US22_0(v1228, v1229, v1230, v1231, v1232, v1233) -> (* Ok *)
            let v1234 : bool = v1229 = v3
            if v1234 then
                let v1235 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure69()
                US22_1(v1235, v3, v4, v5, v6, v7)
            else
                v1227
        | _ ->
            v1227
    match v1238 with
    | US22_1(v1239, v1240, v1241, v1242, v1243, v1244) -> (* Error *)
        let v1248 : string =
            match v2 with
            | UH0_0 -> (* Nil *)
                v1
            | _ ->
                let v1245 : bool = true
                let v1246 : string = method132(v1245, v2)
                let v1247 : string = v1 + v1246 
                v1247
        US22_0(v1248, v3, v4, v5, v6, v7)
    | US22_0(v1250, v1251, v1252, v1253, v1254, v1255) -> (* Ok *)
        let v1256 : bool = v1251 > v3
        if v1256 then
            let v1257 : UH0 = UH0_1(v1250, v2)
            method141(v0, v1, v1257, v1251, v1252, v1253, v1254, v1255)
        else
            let v1259 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure70()
            US22_1(v1259, v3, v4, v5, v6, v7)
and closure71 () struct (v0 : string, v1 : int32, v2 : int32, v3 : int32, v4 : int32, v5 : int32) : string =
    let v6 : string = "parsing.sep_by / separator consumed no text"
    v6
and method144 (v0 : string, v1 : UH0, v2 : int32, v3 : int32, v4 : int32, v5 : int32, v6 : int32) : US30 =
    let v7 : bool = v2 >= v6
    let struct (v20 : int32, v21 : int32, v22 : int32, v23 : int32, v24 : int32) =
        if v7 then
            struct (v2, v3, v4, v5, v6)
        else
            let v8 : int32 = v0.Length
            let v9 : int32 = method125(v0, v8, v2)
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
    let v30 : US23 =
        if v26 then
            US23_0(v20, v21, v22, v23, v24)
        else
            let v28 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure51()
            US23_1(v28, v2, v3, v4, v5, v6)
    match v30 with
    | US23_1(v31, v32, v33, v34, v35, v36) -> (* Error *)
        let v37 : UH0 = UH0_0
        let v38 : UH0 = method139(v1, v37)
        US30_0(v38, v2, v3, v4, v5, v6)
    | US23_0(v40, v41, v42, v43, v44) -> (* Ok *)
        let v45 : bool = v40 = v2
        if v45 then
            let v46 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure71()
            US30_1(v46, v2, v3, v4, v5, v6)
        else
            let v48 : bool = v40 >= v44
            let v66 : US21 =
                if v48 then
                    let v49 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                    US21_1(v49, v40, v41, v42, v43, v44)
                else
                    let v51 : char = v0.[int v40]
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
                        US21_0('\\', v53, v58, v59, v60, v61)
                    else
                        let v63 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                        US21_1(v63, v40, v41, v42, v43, v44)
            let v100 : US21 =
                match v66 with
                | US21_1(v92, v93, v94, v95, v96, v97) -> (* Error *)
                    US21_1(v92, v93, v94, v95, v96, v97)
                | US21_0(v67, v68, v69, v70, v71, v72) -> (* Ok *)
                    let v73 : bool = v68 >= v72
                    if v73 then
                        let v74 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                        US21_1(v74, v68, v69, v70, v71, v72)
                    else
                        let v76 : char = v0.[int v68]
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
                            US21_0('"', v78, v83, v84, v85, v86)
                        else
                            let v88 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                            US21_1(v88, v68, v69, v70, v71, v72)
            let v116 : US21 =
                match v100 with
                | US21_1(v108, v109, v110, v111, v112, v113) -> (* Error *)
                    US21_1(v108, v109, v110, v111, v112, v113)
                | US21_0(v101, v102, v103, v104, v105, v106) -> (* Ok *)
                    US21_0('"', v102, v103, v104, v105, v106)
            let v214 : US21 =
                match v116 with
                | US21_1(v123, v124, v125, v126, v127, v128) -> (* Error *)
                    let v146 : US21 =
                        if v48 then
                            let v129 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure58()
                            US21_1(v129, v40, v41, v42, v43, v44)
                        else
                            let v131 : char = v0.[int v40]
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
                                US21_0('`', v133, v138, v139, v140, v141)
                            else
                                let v143 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                                US21_1(v143, v40, v41, v42, v43, v44)
                    let v180 : US21 =
                        match v146 with
                        | US21_1(v172, v173, v174, v175, v176, v177) -> (* Error *)
                            US21_1(v172, v173, v174, v175, v176, v177)
                        | US21_0(v147, v148, v149, v150, v151, v152) -> (* Ok *)
                            let v153 : bool = v148 >= v152
                            if v153 then
                                let v154 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                                US21_1(v154, v148, v149, v150, v151, v152)
                            else
                                let v156 : char = v0.[int v148]
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
                                    US21_0('"', v158, v163, v164, v165, v166)
                                else
                                    let v168 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                                    US21_1(v168, v148, v149, v150, v151, v152)
                    let v196 : US21 =
                        match v180 with
                        | US21_1(v188, v189, v190, v191, v192, v193) -> (* Error *)
                            US21_1(v188, v189, v190, v191, v192, v193)
                        | US21_0(v181, v182, v183, v184, v185, v186) -> (* Ok *)
                            US21_0('"', v182, v183, v184, v185, v186)
                    match v196 with
                    | US21_1(v203, v204, v205, v206, v207, v208) -> (* Error *)
                        let v209 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure41()
                        US21_1(v209, v40, v41, v42, v43, v44)
                    | US21_0(v197, v198, v199, v200, v201, v202) -> (* Ok *)
                        v196
                | US21_0(v117, v118, v119, v120, v121, v122) -> (* Ok *)
                    v116
            let v845 : US22 =
                match v214 with
                | US21_1(v837, v838, v839, v840, v841, v842) -> (* Error *)
                    US22_1(v837, v838, v839, v840, v841, v842)
                | US21_0(v215, v216, v217, v218, v219, v220) -> (* Ok *)
                    let struct (v221 : int32, v222 : int32, v223 : int32, v224 : int32, v225 : int32) = method127(v217, v218, v219, v220, v0, v216)
                    let v226 : bool = v221 > v216
                    let v236 : US22 =
                        if v226 then
                            let v227 : bool = v216 >= v221
                            let v232 : string =
                                if v227 then
                                    let v228 : string = ""
                                    v228
                                else
                                    let v229 : bool = v216 = v221
                                    let v230 : int32 = v221 - 1
                                    let v231 : string = v0.[int v216..int v230]
                                    v231
                            US22_0(v232, v221, v222, v223, v224, v225)
                        else
                            let v234 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure60()
                            US22_1(v234, v216, v217, v218, v219, v220)
                    let v431 : US22 =
                        match v236 with
                        | US22_1(v243, v244, v245, v246, v247, v248) -> (* Error *)
                            let v249 : bool = v216 >= v220
                            let v267 : US21 =
                                if v249 then
                                    let v250 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                                    US21_1(v250, v216, v217, v218, v219, v220)
                                else
                                    let v252 : char = v0.[int v216]
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
                                        US21_0('\\', v254, v259, v260, v261, v262)
                                    else
                                        let v264 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                                        US21_1(v264, v216, v217, v218, v219, v220)
                            let v302 : US21 =
                                match v267 with
                                | US21_1(v294, v295, v296, v297, v298, v299) -> (* Error *)
                                    US21_1(v294, v295, v296, v297, v298, v299)
                                | US21_0(v268, v269, v270, v271, v272, v273) -> (* Ok *)
                                    let v274 : bool = v269 >= v273
                                    if v274 then
                                        let v275 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure61()
                                        US21_1(v275, v269, v270, v271, v272, v273)
                                    else
                                        let v277 : char = v0.[int v269]
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
                                            US21_0(v277, v280, v285, v286, v287, v288)
                                        else
                                            let v290 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure62()
                                            US21_1(v290, v269, v270, v271, v272, v273)
                            let v324 : US22 =
                                match v302 with
                                | US21_1(v316, v317, v318, v319, v320, v321) -> (* Error *)
                                    US22_1(v316, v317, v318, v319, v320, v321)
                                | US21_0(v303, v304, v305, v306, v307, v308) -> (* Ok *)
                                    let v309 : bool = v216 >= v304
                                    let v314 : string =
                                        if v309 then
                                            let v310 : string = ""
                                            v310
                                        else
                                            let v311 : bool = v216 = v304
                                            let v312 : int32 = v304 - 1
                                            let v313 : string = v0.[int v216..int v312]
                                            v313
                                    US22_0(v314, v304, v305, v306, v307, v308)
                            match v324 with
                            | US22_1(v331, v332, v333, v334, v335, v336) -> (* Error *)
                                let v354 : US21 =
                                    if v249 then
                                        let v337 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure58()
                                        US21_1(v337, v216, v217, v218, v219, v220)
                                    else
                                        let v339 : char = v0.[int v216]
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
                                            US21_0('`', v341, v346, v347, v348, v349)
                                        else
                                            let v351 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                                            US21_1(v351, v216, v217, v218, v219, v220)
                                let v389 : US21 =
                                    match v354 with
                                    | US21_1(v381, v382, v383, v384, v385, v386) -> (* Error *)
                                        US21_1(v381, v382, v383, v384, v385, v386)
                                    | US21_0(v355, v356, v357, v358, v359, v360) -> (* Ok *)
                                        let v361 : bool = v356 >= v360
                                        if v361 then
                                            let v362 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure61()
                                            US21_1(v362, v356, v357, v358, v359, v360)
                                        else
                                            let v364 : char = v0.[int v356]
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
                                                US21_0(v364, v367, v372, v373, v374, v375)
                                            else
                                                let v377 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure62()
                                                US21_1(v377, v356, v357, v358, v359, v360)
                                let v411 : US22 =
                                    match v389 with
                                    | US21_1(v403, v404, v405, v406, v407, v408) -> (* Error *)
                                        US22_1(v403, v404, v405, v406, v407, v408)
                                    | US21_0(v390, v391, v392, v393, v394, v395) -> (* Ok *)
                                        let v396 : bool = v216 >= v391
                                        let v401 : string =
                                            if v396 then
                                                let v397 : string = ""
                                                v397
                                            else
                                                let v398 : bool = v216 = v391
                                                let v399 : int32 = v391 - 1
                                                let v400 : string = v0.[int v216..int v399]
                                                v400
                                        US22_0(v401, v391, v392, v393, v394, v395)
                                match v411 with
                                | US22_1(v418, v419, v420, v421, v422, v423) -> (* Error *)
                                    let v424 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure41()
                                    US22_1(v424, v216, v217, v218, v219, v220)
                                | US22_0(v412, v413, v414, v415, v416, v417) -> (* Ok *)
                                    v411
                            | US22_0(v325, v326, v327, v328, v329, v330) -> (* Ok *)
                                v324
                        | US22_0(v237, v238, v239, v240, v241, v242) -> (* Ok *)
                            v236
                    let v453 : US22 =
                        match v431 with
                        | US22_1(v432, v433, v434, v435, v436, v437) -> (* Error *)
                            let v438 : string = ""
                            US22_0(v438, v216, v217, v218, v219, v220)
                        | US22_0(v440, v441, v442, v443, v444, v445) -> (* Ok *)
                            let v446 : bool = v441 = v216
                            if v446 then
                                let v447 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure63()
                                US22_1(v447, v216, v217, v218, v219, v220)
                            else
                                let v449 : UH0 = UH0_0
                                method131(v0, v440, v449, v441, v442, v443, v444, v445)
                    match v453 with
                    | US22_1(v644, v645, v646, v647, v648, v649) -> (* Error *)
                        let v650 : bool = v216 >= v220
                        let v668 : US21 =
                            if v650 then
                                let v651 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                                US21_1(v651, v216, v217, v218, v219, v220)
                            else
                                let v653 : char = v0.[int v216]
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
                                    US21_0('\\', v655, v660, v661, v662, v663)
                                else
                                    let v665 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                                    US21_1(v665, v216, v217, v218, v219, v220)
                        let v702 : US21 =
                            match v668 with
                            | US21_1(v694, v695, v696, v697, v698, v699) -> (* Error *)
                                US21_1(v694, v695, v696, v697, v698, v699)
                            | US21_0(v669, v670, v671, v672, v673, v674) -> (* Ok *)
                                let v675 : bool = v670 >= v674
                                if v675 then
                                    let v676 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                                    US21_1(v676, v670, v671, v672, v673, v674)
                                else
                                    let v678 : char = v0.[int v670]
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
                                        US21_0('"', v680, v685, v686, v687, v688)
                                    else
                                        let v690 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                                        US21_1(v690, v670, v671, v672, v673, v674)
                        let v718 : US21 =
                            match v702 with
                            | US21_1(v710, v711, v712, v713, v714, v715) -> (* Error *)
                                US21_1(v710, v711, v712, v713, v714, v715)
                            | US21_0(v703, v704, v705, v706, v707, v708) -> (* Ok *)
                                US21_0('"', v704, v705, v706, v707, v708)
                        let v816 : US21 =
                            match v718 with
                            | US21_1(v725, v726, v727, v728, v729, v730) -> (* Error *)
                                let v748 : US21 =
                                    if v650 then
                                        let v731 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure58()
                                        US21_1(v731, v216, v217, v218, v219, v220)
                                    else
                                        let v733 : char = v0.[int v216]
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
                                            US21_0('`', v735, v740, v741, v742, v743)
                                        else
                                            let v745 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                                            US21_1(v745, v216, v217, v218, v219, v220)
                                let v782 : US21 =
                                    match v748 with
                                    | US21_1(v774, v775, v776, v777, v778, v779) -> (* Error *)
                                        US21_1(v774, v775, v776, v777, v778, v779)
                                    | US21_0(v749, v750, v751, v752, v753, v754) -> (* Ok *)
                                        let v755 : bool = v750 >= v754
                                        if v755 then
                                            let v756 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                                            US21_1(v756, v750, v751, v752, v753, v754)
                                        else
                                            let v758 : char = v0.[int v750]
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
                                                US21_0('"', v760, v765, v766, v767, v768)
                                            else
                                                let v770 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                                                US21_1(v770, v750, v751, v752, v753, v754)
                                let v798 : US21 =
                                    match v782 with
                                    | US21_1(v790, v791, v792, v793, v794, v795) -> (* Error *)
                                        US21_1(v790, v791, v792, v793, v794, v795)
                                    | US21_0(v783, v784, v785, v786, v787, v788) -> (* Ok *)
                                        US21_0('"', v784, v785, v786, v787, v788)
                                match v798 with
                                | US21_1(v805, v806, v807, v808, v809, v810) -> (* Error *)
                                    let v811 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure41()
                                    US21_1(v811, v216, v217, v218, v219, v220)
                                | US21_0(v799, v800, v801, v802, v803, v804) -> (* Ok *)
                                    v798
                            | US21_0(v719, v720, v721, v722, v723, v724) -> (* Ok *)
                                v718
                        match v816 with
                        | US21_1(v825, v826, v827, v828, v829, v830) -> (* Error *)
                            let v831 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure45()
                            US22_1(v831, v216, v217, v218, v219, v220)
                        | US21_0(v817, v818, v819, v820, v821, v822) -> (* Ok *)
                            let v823 : string = ""
                            US22_0(v823, v818, v819, v820, v821, v822)
                    | US22_0(v454, v455, v456, v457, v458, v459) -> (* Ok *)
                        let v460 : bool = v455 >= v459
                        let v478 : US21 =
                            if v460 then
                                let v461 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                                US21_1(v461, v455, v456, v457, v458, v459)
                            else
                                let v463 : char = v0.[int v455]
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
                                    US21_0('\\', v465, v470, v471, v472, v473)
                                else
                                    let v475 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                                    US21_1(v475, v455, v456, v457, v458, v459)
                        let v512 : US21 =
                            match v478 with
                            | US21_1(v504, v505, v506, v507, v508, v509) -> (* Error *)
                                US21_1(v504, v505, v506, v507, v508, v509)
                            | US21_0(v479, v480, v481, v482, v483, v484) -> (* Ok *)
                                let v485 : bool = v480 >= v484
                                if v485 then
                                    let v486 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                                    US21_1(v486, v480, v481, v482, v483, v484)
                                else
                                    let v488 : char = v0.[int v480]
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
                                        US21_0('"', v490, v495, v496, v497, v498)
                                    else
                                        let v500 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                                        US21_1(v500, v480, v481, v482, v483, v484)
                        let v528 : US21 =
                            match v512 with
                            | US21_1(v520, v521, v522, v523, v524, v525) -> (* Error *)
                                US21_1(v520, v521, v522, v523, v524, v525)
                            | US21_0(v513, v514, v515, v516, v517, v518) -> (* Ok *)
                                US21_0('"', v514, v515, v516, v517, v518)
                        let v626 : US21 =
                            match v528 with
                            | US21_1(v535, v536, v537, v538, v539, v540) -> (* Error *)
                                let v558 : US21 =
                                    if v460 then
                                        let v541 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure58()
                                        US21_1(v541, v455, v456, v457, v458, v459)
                                    else
                                        let v543 : char = v0.[int v455]
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
                                            US21_0('`', v545, v550, v551, v552, v553)
                                        else
                                            let v555 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                                            US21_1(v555, v455, v456, v457, v458, v459)
                                let v592 : US21 =
                                    match v558 with
                                    | US21_1(v584, v585, v586, v587, v588, v589) -> (* Error *)
                                        US21_1(v584, v585, v586, v587, v588, v589)
                                    | US21_0(v559, v560, v561, v562, v563, v564) -> (* Ok *)
                                        let v565 : bool = v560 >= v564
                                        if v565 then
                                            let v566 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                                            US21_1(v566, v560, v561, v562, v563, v564)
                                        else
                                            let v568 : char = v0.[int v560]
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
                                                US21_0('"', v570, v575, v576, v577, v578)
                                            else
                                                let v580 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                                                US21_1(v580, v560, v561, v562, v563, v564)
                                let v608 : US21 =
                                    match v592 with
                                    | US21_1(v600, v601, v602, v603, v604, v605) -> (* Error *)
                                        US21_1(v600, v601, v602, v603, v604, v605)
                                    | US21_0(v593, v594, v595, v596, v597, v598) -> (* Ok *)
                                        US21_0('"', v594, v595, v596, v597, v598)
                                match v608 with
                                | US21_1(v615, v616, v617, v618, v619, v620) -> (* Error *)
                                    let v621 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure41()
                                    US21_1(v621, v455, v456, v457, v458, v459)
                                | US21_0(v609, v610, v611, v612, v613, v614) -> (* Ok *)
                                    v608
                            | US21_0(v529, v530, v531, v532, v533, v534) -> (* Ok *)
                                v528
                        match v626 with
                        | US21_1(v634, v635, v636, v637, v638, v639) -> (* Error *)
                            let v640 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure46(v216, v455, v634, v635, v636, v637, v638, v639)
                            US22_1(v640, v455, v456, v457, v458, v459)
                        | US21_0(v627, v628, v629, v630, v631, v632) -> (* Ok *)
                            US22_0(v454, v628, v629, v630, v631, v632)
            let v1202 : US22 =
                match v845 with
                | US22_1(v852, v853, v854, v855, v856, v857) -> (* Error *)
                    let v875 : US21 =
                        if v48 then
                            let v858 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                            US21_1(v858, v40, v41, v42, v43, v44)
                        else
                            let v860 : char = v0.[int v40]
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
                                US21_0('"', v862, v867, v868, v869, v870)
                            else
                                let v872 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                                US21_1(v872, v40, v41, v42, v43, v44)
                    match v875 with
                    | US21_1(v1192, v1193, v1194, v1195, v1196, v1197) -> (* Error *)
                        US22_1(v1192, v1193, v1194, v1195, v1196, v1197)
                    | US21_0(v876, v877, v878, v879, v880, v881) -> (* Ok *)
                        let struct (v882 : int32, v883 : int32, v884 : int32, v885 : int32, v886 : int32) = method127(v878, v879, v880, v881, v0, v877)
                        let v887 : bool = v882 > v877
                        let v897 : US22 =
                            if v887 then
                                let v888 : bool = v877 >= v882
                                let v893 : string =
                                    if v888 then
                                        let v889 : string = ""
                                        v889
                                    else
                                        let v890 : bool = v877 = v882
                                        let v891 : int32 = v882 - 1
                                        let v892 : string = v0.[int v877..int v891]
                                        v892
                                US22_0(v893, v882, v883, v884, v885, v886)
                            else
                                let v895 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure60()
                                US22_1(v895, v877, v878, v879, v880, v881)
                        let v1082 : US22 =
                            match v897 with
                            | US22_1(v904, v905, v906, v907, v908, v909) -> (* Error *)
                                let v910 : bool = v877 >= v881
                                let v928 : US21 =
                                    if v910 then
                                        let v911 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                                        US21_1(v911, v877, v878, v879, v880, v881)
                                    else
                                        let v913 : char = v0.[int v877]
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
                                            US21_0('\\', v915, v920, v921, v922, v923)
                                        else
                                            let v925 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                                            US21_1(v925, v877, v878, v879, v880, v881)
                                let v958 : US21 =
                                    match v928 with
                                    | US21_1(v950, v951, v952, v953, v954, v955) -> (* Error *)
                                        US21_1(v950, v951, v952, v953, v954, v955)
                                    | US21_0(v929, v930, v931, v932, v933, v934) -> (* Ok *)
                                        let v935 : bool = v930 >= v934
                                        if v935 then
                                            let v936 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure65()
                                            US21_1(v936, v930, v931, v932, v933, v934)
                                        else
                                            let v938 : char = v0.[int v930]
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
                                            US21_0(v938, v939, v944, v945, v946, v947)
                                let v980 : US22 =
                                    match v958 with
                                    | US21_1(v972, v973, v974, v975, v976, v977) -> (* Error *)
                                        US22_1(v972, v973, v974, v975, v976, v977)
                                    | US21_0(v959, v960, v961, v962, v963, v964) -> (* Ok *)
                                        let v965 : bool = v877 >= v960
                                        let v970 : string =
                                            if v965 then
                                                let v966 : string = ""
                                                v966
                                            else
                                                let v967 : bool = v877 = v960
                                                let v968 : int32 = v960 - 1
                                                let v969 : string = v0.[int v877..int v968]
                                                v969
                                        US22_0(v970, v960, v961, v962, v963, v964)
                                match v980 with
                                | US22_1(v987, v988, v989, v990, v991, v992) -> (* Error *)
                                    let v1010 : US21 =
                                        if v910 then
                                            let v993 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure58()
                                            US21_1(v993, v877, v878, v879, v880, v881)
                                        else
                                            let v995 : char = v0.[int v877]
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
                                                US21_0('`', v997, v1002, v1003, v1004, v1005)
                                            else
                                                let v1007 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                                                US21_1(v1007, v877, v878, v879, v880, v881)
                                    let v1040 : US21 =
                                        match v1010 with
                                        | US21_1(v1032, v1033, v1034, v1035, v1036, v1037) -> (* Error *)
                                            US21_1(v1032, v1033, v1034, v1035, v1036, v1037)
                                        | US21_0(v1011, v1012, v1013, v1014, v1015, v1016) -> (* Ok *)
                                            let v1017 : bool = v1012 >= v1016
                                            if v1017 then
                                                let v1018 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure65()
                                                US21_1(v1018, v1012, v1013, v1014, v1015, v1016)
                                            else
                                                let v1020 : char = v0.[int v1012]
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
                                                US21_0(v1020, v1021, v1026, v1027, v1028, v1029)
                                    let v1062 : US22 =
                                        match v1040 with
                                        | US21_1(v1054, v1055, v1056, v1057, v1058, v1059) -> (* Error *)
                                            US22_1(v1054, v1055, v1056, v1057, v1058, v1059)
                                        | US21_0(v1041, v1042, v1043, v1044, v1045, v1046) -> (* Ok *)
                                            let v1047 : bool = v877 >= v1042
                                            let v1052 : string =
                                                if v1047 then
                                                    let v1048 : string = ""
                                                    v1048
                                                else
                                                    let v1049 : bool = v877 = v1042
                                                    let v1050 : int32 = v1042 - 1
                                                    let v1051 : string = v0.[int v877..int v1050]
                                                    v1051
                                            US22_0(v1052, v1042, v1043, v1044, v1045, v1046)
                                    match v1062 with
                                    | US22_1(v1069, v1070, v1071, v1072, v1073, v1074) -> (* Error *)
                                        let v1075 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure41()
                                        US22_1(v1075, v877, v878, v879, v880, v881)
                                    | US22_0(v1063, v1064, v1065, v1066, v1067, v1068) -> (* Ok *)
                                        v1062
                                | US22_0(v981, v982, v983, v984, v985, v986) -> (* Ok *)
                                    v980
                            | US22_0(v898, v899, v900, v901, v902, v903) -> (* Ok *)
                                v897
                        let v1104 : US22 =
                            match v1082 with
                            | US22_1(v1083, v1084, v1085, v1086, v1087, v1088) -> (* Error *)
                                let v1089 : string = ""
                                US22_0(v1089, v877, v878, v879, v880, v881)
                            | US22_0(v1091, v1092, v1093, v1094, v1095, v1096) -> (* Ok *)
                                let v1097 : bool = v1092 = v877
                                if v1097 then
                                    let v1098 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure63()
                                    US22_1(v1098, v877, v878, v879, v880, v881)
                                else
                                    let v1100 : UH0 = UH0_0
                                    method135(v0, v1091, v1100, v1092, v1093, v1094, v1095, v1096)
                        match v1104 with
                        | US22_1(v1147, v1148, v1149, v1150, v1151, v1152) -> (* Error *)
                            let v1153 : bool = v877 >= v881
                            let v1171 : US21 =
                                if v1153 then
                                    let v1154 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                                    US21_1(v1154, v877, v878, v879, v880, v881)
                                else
                                    let v1156 : char = v0.[int v877]
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
                                        US21_0('"', v1158, v1163, v1164, v1165, v1166)
                                    else
                                        let v1168 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                                        US21_1(v1168, v877, v878, v879, v880, v881)
                            match v1171 with
                            | US21_1(v1180, v1181, v1182, v1183, v1184, v1185) -> (* Error *)
                                let v1186 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure45()
                                US22_1(v1186, v877, v878, v879, v880, v881)
                            | US21_0(v1172, v1173, v1174, v1175, v1176, v1177) -> (* Ok *)
                                let v1178 : string = ""
                                US22_0(v1178, v1173, v1174, v1175, v1176, v1177)
                        | US22_0(v1105, v1106, v1107, v1108, v1109, v1110) -> (* Ok *)
                            let v1111 : bool = v1106 >= v1110
                            let v1129 : US21 =
                                if v1111 then
                                    let v1112 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                                    US21_1(v1112, v1106, v1107, v1108, v1109, v1110)
                                else
                                    let v1114 : char = v0.[int v1106]
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
                                        US21_0('"', v1116, v1121, v1122, v1123, v1124)
                                    else
                                        let v1126 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                                        US21_1(v1126, v1106, v1107, v1108, v1109, v1110)
                            match v1129 with
                            | US21_1(v1137, v1138, v1139, v1140, v1141, v1142) -> (* Error *)
                                let v1143 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure46(v877, v1106, v1137, v1138, v1139, v1140, v1141, v1142)
                                US22_1(v1143, v1106, v1107, v1108, v1109, v1110)
                            | US21_0(v1130, v1131, v1132, v1133, v1134, v1135) -> (* Ok *)
                                US22_0(v1105, v1131, v1132, v1133, v1134, v1135)
                | US22_0(v846, v847, v848, v849, v850, v851) -> (* Ok *)
                    v845
            let v1232 : US22 =
                match v1202 with
                | US22_1(v1209, v1210, v1211, v1212, v1213, v1214) -> (* Error *)
                    let struct (v1215 : int32, v1216 : int32, v1217 : int32, v1218 : int32, v1219 : int32) = method142(v41, v42, v43, v44, v0, v40)
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
                                let v1225 : string = v0.[int v40..int v1224]
                                v1225
                        US22_0(v1226, v1215, v1216, v1217, v1218, v1219)
                    else
                        let v1228 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure60()
                        US22_1(v1228, v40, v41, v42, v43, v44)
                | US22_0(v1203, v1204, v1205, v1206, v1207, v1208) -> (* Ok *)
                    v1202
            let v1267 : US22 =
                match v1232 with
                | US22_1(v1239, v1240, v1241, v1242, v1243, v1244) -> (* Error *)
                    let v1245 : UH0 = UH0_0
                    let v1246 : US30 = method138(v0, v1245, v40, v41, v42, v43, v44)
                    match v1246 with
                    | US30_1(v1257, v1258, v1259, v1260, v1261, v1262) -> (* Error *)
                        US22_1(v1257, v1258, v1259, v1260, v1261, v1262)
                    | US30_0(v1247, v1248, v1249, v1250, v1251, v1252) -> (* Ok *)
                        let v1253 : string = ""
                        let struct (v1254 : string, v1255 : string) = method140(v1247, v1253)
                        US22_0(v1254, v1248, v1249, v1250, v1251, v1252)
                | US22_0(v1233, v1234, v1235, v1236, v1237, v1238) -> (* Ok *)
                    v1232
            let v1278 : US22 =
                match v1267 with
                | US22_0(v1268, v1269, v1270, v1271, v1272, v1273) -> (* Ok *)
                    let v1274 : bool = v1269 = v40
                    if v1274 then
                        let v1275 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure69()
                        US22_1(v1275, v40, v41, v42, v43, v44)
                    else
                        v1267
                | _ ->
                    v1267
            let v1295 : US22 =
                match v1278 with
                | US22_1(v1279, v1280, v1281, v1282, v1283, v1284) -> (* Error *)
                    US22_1(v1279, v1280, v1281, v1282, v1283, v1284)
                | US22_0(v1286, v1287, v1288, v1289, v1290, v1291) -> (* Ok *)
                    let v1292 : UH0 = UH0_0
                    method141(v0, v1286, v1292, v1287, v1288, v1289, v1290, v1291)
            match v1295 with
            | US22_1(v1304, v1305, v1306, v1307, v1308, v1309) -> (* Error *)
                let v1310 : UH0 = UH0_0
                let v1311 : UH0 = method139(v1, v1310)
                US30_0(v1311, v2, v3, v4, v5, v6)
            | US22_0(v1296, v1297, v1298, v1299, v1300, v1301) -> (* Ok *)
                let v1302 : UH0 = UH0_1(v1296, v1)
                method144(v0, v1302, v1297, v1298, v1299, v1300, v1301)
and method145 (v0 : UH0, v1 : string list) : string list =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : string list = method145(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH0_0 -> (* Nil *)
        v1
and method126 (v0 : string) : US29 =
    let v1 : int32 = v0.Length
    let v2 : bool = 0 >= v1
    let v16 : US21 =
        if v2 then
            let v3 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
            US21_1(v3, 0, 0, 1, 1, v1)
        else
            let v5 : char = v0.[int 0]
            let v6 : bool = v5 = '\\'
            if v6 then
                let v7 : bool = '\n' = v5
                let struct (v8 : int32, v9 : int32, v10 : int32, v11 : int32) =
                    if v7 then
                        struct (1, 2, 1, v1)
                    else
                        struct (0, 1, 2, v1)
                US21_0('\\', 1, v8, v9, v10, v11)
            else
                let v13 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                US21_1(v13, 0, 0, 1, 1, v1)
    let v50 : US21 =
        match v16 with
        | US21_1(v42, v43, v44, v45, v46, v47) -> (* Error *)
            US21_1(v42, v43, v44, v45, v46, v47)
        | US21_0(v17, v18, v19, v20, v21, v22) -> (* Ok *)
            let v23 : bool = v18 >= v22
            if v23 then
                let v24 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                US21_1(v24, v18, v19, v20, v21, v22)
            else
                let v26 : char = v0.[int v18]
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
                    US21_0('"', v28, v33, v34, v35, v36)
                else
                    let v38 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                    US21_1(v38, v18, v19, v20, v21, v22)
    let v66 : US21 =
        match v50 with
        | US21_1(v58, v59, v60, v61, v62, v63) -> (* Error *)
            US21_1(v58, v59, v60, v61, v62, v63)
        | US21_0(v51, v52, v53, v54, v55, v56) -> (* Ok *)
            US21_0('"', v52, v53, v54, v55, v56)
    let v160 : US21 =
        match v66 with
        | US21_1(v73, v74, v75, v76, v77, v78) -> (* Error *)
            let v92 : US21 =
                if v2 then
                    let v79 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure58()
                    US21_1(v79, 0, 0, 1, 1, v1)
                else
                    let v81 : char = v0.[int 0]
                    let v82 : bool = v81 = '`'
                    if v82 then
                        let v83 : bool = '\n' = v81
                        let struct (v84 : int32, v85 : int32, v86 : int32, v87 : int32) =
                            if v83 then
                                struct (1, 2, 1, v1)
                            else
                                struct (0, 1, 2, v1)
                        US21_0('`', 1, v84, v85, v86, v87)
                    else
                        let v89 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                        US21_1(v89, 0, 0, 1, 1, v1)
            let v126 : US21 =
                match v92 with
                | US21_1(v118, v119, v120, v121, v122, v123) -> (* Error *)
                    US21_1(v118, v119, v120, v121, v122, v123)
                | US21_0(v93, v94, v95, v96, v97, v98) -> (* Ok *)
                    let v99 : bool = v94 >= v98
                    if v99 then
                        let v100 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                        US21_1(v100, v94, v95, v96, v97, v98)
                    else
                        let v102 : char = v0.[int v94]
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
                            US21_0('"', v104, v109, v110, v111, v112)
                        else
                            let v114 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                            US21_1(v114, v94, v95, v96, v97, v98)
            let v142 : US21 =
                match v126 with
                | US21_1(v134, v135, v136, v137, v138, v139) -> (* Error *)
                    US21_1(v134, v135, v136, v137, v138, v139)
                | US21_0(v127, v128, v129, v130, v131, v132) -> (* Ok *)
                    US21_0('"', v128, v129, v130, v131, v132)
            match v142 with
            | US21_1(v149, v150, v151, v152, v153, v154) -> (* Error *)
                let v155 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure41()
                US21_1(v155, 0, 0, 1, 1, v1)
            | US21_0(v143, v144, v145, v146, v147, v148) -> (* Ok *)
                v142
        | US21_0(v67, v68, v69, v70, v71, v72) -> (* Ok *)
            v66
    let v791 : US22 =
        match v160 with
        | US21_1(v783, v784, v785, v786, v787, v788) -> (* Error *)
            US22_1(v783, v784, v785, v786, v787, v788)
        | US21_0(v161, v162, v163, v164, v165, v166) -> (* Ok *)
            let struct (v167 : int32, v168 : int32, v169 : int32, v170 : int32, v171 : int32) = method127(v163, v164, v165, v166, v0, v162)
            let v172 : bool = v167 > v162
            let v182 : US22 =
                if v172 then
                    let v173 : bool = v162 >= v167
                    let v178 : string =
                        if v173 then
                            let v174 : string = ""
                            v174
                        else
                            let v175 : bool = v162 = v167
                            let v176 : int32 = v167 - 1
                            let v177 : string = v0.[int v162..int v176]
                            v177
                    US22_0(v178, v167, v168, v169, v170, v171)
                else
                    let v180 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure60()
                    US22_1(v180, v162, v163, v164, v165, v166)
            let v377 : US22 =
                match v182 with
                | US22_1(v189, v190, v191, v192, v193, v194) -> (* Error *)
                    let v195 : bool = v162 >= v166
                    let v213 : US21 =
                        if v195 then
                            let v196 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                            US21_1(v196, v162, v163, v164, v165, v166)
                        else
                            let v198 : char = v0.[int v162]
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
                                US21_0('\\', v200, v205, v206, v207, v208)
                            else
                                let v210 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                                US21_1(v210, v162, v163, v164, v165, v166)
                    let v248 : US21 =
                        match v213 with
                        | US21_1(v240, v241, v242, v243, v244, v245) -> (* Error *)
                            US21_1(v240, v241, v242, v243, v244, v245)
                        | US21_0(v214, v215, v216, v217, v218, v219) -> (* Ok *)
                            let v220 : bool = v215 >= v219
                            if v220 then
                                let v221 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure61()
                                US21_1(v221, v215, v216, v217, v218, v219)
                            else
                                let v223 : char = v0.[int v215]
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
                                    US21_0(v223, v226, v231, v232, v233, v234)
                                else
                                    let v236 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure62()
                                    US21_1(v236, v215, v216, v217, v218, v219)
                    let v270 : US22 =
                        match v248 with
                        | US21_1(v262, v263, v264, v265, v266, v267) -> (* Error *)
                            US22_1(v262, v263, v264, v265, v266, v267)
                        | US21_0(v249, v250, v251, v252, v253, v254) -> (* Ok *)
                            let v255 : bool = v162 >= v250
                            let v260 : string =
                                if v255 then
                                    let v256 : string = ""
                                    v256
                                else
                                    let v257 : bool = v162 = v250
                                    let v258 : int32 = v250 - 1
                                    let v259 : string = v0.[int v162..int v258]
                                    v259
                            US22_0(v260, v250, v251, v252, v253, v254)
                    match v270 with
                    | US22_1(v277, v278, v279, v280, v281, v282) -> (* Error *)
                        let v300 : US21 =
                            if v195 then
                                let v283 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure58()
                                US21_1(v283, v162, v163, v164, v165, v166)
                            else
                                let v285 : char = v0.[int v162]
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
                                    US21_0('`', v287, v292, v293, v294, v295)
                                else
                                    let v297 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                                    US21_1(v297, v162, v163, v164, v165, v166)
                        let v335 : US21 =
                            match v300 with
                            | US21_1(v327, v328, v329, v330, v331, v332) -> (* Error *)
                                US21_1(v327, v328, v329, v330, v331, v332)
                            | US21_0(v301, v302, v303, v304, v305, v306) -> (* Ok *)
                                let v307 : bool = v302 >= v306
                                if v307 then
                                    let v308 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure61()
                                    US21_1(v308, v302, v303, v304, v305, v306)
                                else
                                    let v310 : char = v0.[int v302]
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
                                        US21_0(v310, v313, v318, v319, v320, v321)
                                    else
                                        let v323 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure62()
                                        US21_1(v323, v302, v303, v304, v305, v306)
                        let v357 : US22 =
                            match v335 with
                            | US21_1(v349, v350, v351, v352, v353, v354) -> (* Error *)
                                US22_1(v349, v350, v351, v352, v353, v354)
                            | US21_0(v336, v337, v338, v339, v340, v341) -> (* Ok *)
                                let v342 : bool = v162 >= v337
                                let v347 : string =
                                    if v342 then
                                        let v343 : string = ""
                                        v343
                                    else
                                        let v344 : bool = v162 = v337
                                        let v345 : int32 = v337 - 1
                                        let v346 : string = v0.[int v162..int v345]
                                        v346
                                US22_0(v347, v337, v338, v339, v340, v341)
                        match v357 with
                        | US22_1(v364, v365, v366, v367, v368, v369) -> (* Error *)
                            let v370 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure41()
                            US22_1(v370, v162, v163, v164, v165, v166)
                        | US22_0(v358, v359, v360, v361, v362, v363) -> (* Ok *)
                            v357
                    | US22_0(v271, v272, v273, v274, v275, v276) -> (* Ok *)
                        v270
                | US22_0(v183, v184, v185, v186, v187, v188) -> (* Ok *)
                    v182
            let v399 : US22 =
                match v377 with
                | US22_1(v378, v379, v380, v381, v382, v383) -> (* Error *)
                    let v384 : string = ""
                    US22_0(v384, v162, v163, v164, v165, v166)
                | US22_0(v386, v387, v388, v389, v390, v391) -> (* Ok *)
                    let v392 : bool = v387 = v162
                    if v392 then
                        let v393 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure63()
                        US22_1(v393, v162, v163, v164, v165, v166)
                    else
                        let v395 : UH0 = UH0_0
                        method131(v0, v386, v395, v387, v388, v389, v390, v391)
            match v399 with
            | US22_1(v590, v591, v592, v593, v594, v595) -> (* Error *)
                let v596 : bool = v162 >= v166
                let v614 : US21 =
                    if v596 then
                        let v597 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                        US21_1(v597, v162, v163, v164, v165, v166)
                    else
                        let v599 : char = v0.[int v162]
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
                            US21_0('\\', v601, v606, v607, v608, v609)
                        else
                            let v611 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                            US21_1(v611, v162, v163, v164, v165, v166)
                let v648 : US21 =
                    match v614 with
                    | US21_1(v640, v641, v642, v643, v644, v645) -> (* Error *)
                        US21_1(v640, v641, v642, v643, v644, v645)
                    | US21_0(v615, v616, v617, v618, v619, v620) -> (* Ok *)
                        let v621 : bool = v616 >= v620
                        if v621 then
                            let v622 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                            US21_1(v622, v616, v617, v618, v619, v620)
                        else
                            let v624 : char = v0.[int v616]
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
                                US21_0('"', v626, v631, v632, v633, v634)
                            else
                                let v636 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                                US21_1(v636, v616, v617, v618, v619, v620)
                let v664 : US21 =
                    match v648 with
                    | US21_1(v656, v657, v658, v659, v660, v661) -> (* Error *)
                        US21_1(v656, v657, v658, v659, v660, v661)
                    | US21_0(v649, v650, v651, v652, v653, v654) -> (* Ok *)
                        US21_0('"', v650, v651, v652, v653, v654)
                let v762 : US21 =
                    match v664 with
                    | US21_1(v671, v672, v673, v674, v675, v676) -> (* Error *)
                        let v694 : US21 =
                            if v596 then
                                let v677 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure58()
                                US21_1(v677, v162, v163, v164, v165, v166)
                            else
                                let v679 : char = v0.[int v162]
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
                                    US21_0('`', v681, v686, v687, v688, v689)
                                else
                                    let v691 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                                    US21_1(v691, v162, v163, v164, v165, v166)
                        let v728 : US21 =
                            match v694 with
                            | US21_1(v720, v721, v722, v723, v724, v725) -> (* Error *)
                                US21_1(v720, v721, v722, v723, v724, v725)
                            | US21_0(v695, v696, v697, v698, v699, v700) -> (* Ok *)
                                let v701 : bool = v696 >= v700
                                if v701 then
                                    let v702 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                                    US21_1(v702, v696, v697, v698, v699, v700)
                                else
                                    let v704 : char = v0.[int v696]
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
                                        US21_0('"', v706, v711, v712, v713, v714)
                                    else
                                        let v716 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                                        US21_1(v716, v696, v697, v698, v699, v700)
                        let v744 : US21 =
                            match v728 with
                            | US21_1(v736, v737, v738, v739, v740, v741) -> (* Error *)
                                US21_1(v736, v737, v738, v739, v740, v741)
                            | US21_0(v729, v730, v731, v732, v733, v734) -> (* Ok *)
                                US21_0('"', v730, v731, v732, v733, v734)
                        match v744 with
                        | US21_1(v751, v752, v753, v754, v755, v756) -> (* Error *)
                            let v757 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure41()
                            US21_1(v757, v162, v163, v164, v165, v166)
                        | US21_0(v745, v746, v747, v748, v749, v750) -> (* Ok *)
                            v744
                    | US21_0(v665, v666, v667, v668, v669, v670) -> (* Ok *)
                        v664
                match v762 with
                | US21_1(v771, v772, v773, v774, v775, v776) -> (* Error *)
                    let v777 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure45()
                    US22_1(v777, v162, v163, v164, v165, v166)
                | US21_0(v763, v764, v765, v766, v767, v768) -> (* Ok *)
                    let v769 : string = ""
                    US22_0(v769, v764, v765, v766, v767, v768)
            | US22_0(v400, v401, v402, v403, v404, v405) -> (* Ok *)
                let v406 : bool = v401 >= v405
                let v424 : US21 =
                    if v406 then
                        let v407 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                        US21_1(v407, v401, v402, v403, v404, v405)
                    else
                        let v409 : char = v0.[int v401]
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
                            US21_0('\\', v411, v416, v417, v418, v419)
                        else
                            let v421 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                            US21_1(v421, v401, v402, v403, v404, v405)
                let v458 : US21 =
                    match v424 with
                    | US21_1(v450, v451, v452, v453, v454, v455) -> (* Error *)
                        US21_1(v450, v451, v452, v453, v454, v455)
                    | US21_0(v425, v426, v427, v428, v429, v430) -> (* Ok *)
                        let v431 : bool = v426 >= v430
                        if v431 then
                            let v432 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                            US21_1(v432, v426, v427, v428, v429, v430)
                        else
                            let v434 : char = v0.[int v426]
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
                                US21_0('"', v436, v441, v442, v443, v444)
                            else
                                let v446 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                                US21_1(v446, v426, v427, v428, v429, v430)
                let v474 : US21 =
                    match v458 with
                    | US21_1(v466, v467, v468, v469, v470, v471) -> (* Error *)
                        US21_1(v466, v467, v468, v469, v470, v471)
                    | US21_0(v459, v460, v461, v462, v463, v464) -> (* Ok *)
                        US21_0('"', v460, v461, v462, v463, v464)
                let v572 : US21 =
                    match v474 with
                    | US21_1(v481, v482, v483, v484, v485, v486) -> (* Error *)
                        let v504 : US21 =
                            if v406 then
                                let v487 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure58()
                                US21_1(v487, v401, v402, v403, v404, v405)
                            else
                                let v489 : char = v0.[int v401]
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
                                    US21_0('`', v491, v496, v497, v498, v499)
                                else
                                    let v501 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                                    US21_1(v501, v401, v402, v403, v404, v405)
                        let v538 : US21 =
                            match v504 with
                            | US21_1(v530, v531, v532, v533, v534, v535) -> (* Error *)
                                US21_1(v530, v531, v532, v533, v534, v535)
                            | US21_0(v505, v506, v507, v508, v509, v510) -> (* Ok *)
                                let v511 : bool = v506 >= v510
                                if v511 then
                                    let v512 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                                    US21_1(v512, v506, v507, v508, v509, v510)
                                else
                                    let v514 : char = v0.[int v506]
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
                                        US21_0('"', v516, v521, v522, v523, v524)
                                    else
                                        let v526 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                                        US21_1(v526, v506, v507, v508, v509, v510)
                        let v554 : US21 =
                            match v538 with
                            | US21_1(v546, v547, v548, v549, v550, v551) -> (* Error *)
                                US21_1(v546, v547, v548, v549, v550, v551)
                            | US21_0(v539, v540, v541, v542, v543, v544) -> (* Ok *)
                                US21_0('"', v540, v541, v542, v543, v544)
                        match v554 with
                        | US21_1(v561, v562, v563, v564, v565, v566) -> (* Error *)
                            let v567 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure41()
                            US21_1(v567, v401, v402, v403, v404, v405)
                        | US21_0(v555, v556, v557, v558, v559, v560) -> (* Ok *)
                            v554
                    | US21_0(v475, v476, v477, v478, v479, v480) -> (* Ok *)
                        v474
                match v572 with
                | US21_1(v580, v581, v582, v583, v584, v585) -> (* Error *)
                    let v586 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure46(v162, v401, v580, v581, v582, v583, v584, v585)
                    US22_1(v586, v401, v402, v403, v404, v405)
                | US21_0(v573, v574, v575, v576, v577, v578) -> (* Ok *)
                    US22_0(v400, v574, v575, v576, v577, v578)
    let v1144 : US22 =
        match v791 with
        | US22_1(v798, v799, v800, v801, v802, v803) -> (* Error *)
            let v817 : US21 =
                if v2 then
                    let v804 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                    US21_1(v804, 0, 0, 1, 1, v1)
                else
                    let v806 : char = v0.[int 0]
                    let v807 : bool = v806 = '"'
                    if v807 then
                        let v808 : bool = '\n' = v806
                        let struct (v809 : int32, v810 : int32, v811 : int32, v812 : int32) =
                            if v808 then
                                struct (1, 2, 1, v1)
                            else
                                struct (0, 1, 2, v1)
                        US21_0('"', 1, v809, v810, v811, v812)
                    else
                        let v814 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                        US21_1(v814, 0, 0, 1, 1, v1)
            match v817 with
            | US21_1(v1134, v1135, v1136, v1137, v1138, v1139) -> (* Error *)
                US22_1(v1134, v1135, v1136, v1137, v1138, v1139)
            | US21_0(v818, v819, v820, v821, v822, v823) -> (* Ok *)
                let struct (v824 : int32, v825 : int32, v826 : int32, v827 : int32, v828 : int32) = method127(v820, v821, v822, v823, v0, v819)
                let v829 : bool = v824 > v819
                let v839 : US22 =
                    if v829 then
                        let v830 : bool = v819 >= v824
                        let v835 : string =
                            if v830 then
                                let v831 : string = ""
                                v831
                            else
                                let v832 : bool = v819 = v824
                                let v833 : int32 = v824 - 1
                                let v834 : string = v0.[int v819..int v833]
                                v834
                        US22_0(v835, v824, v825, v826, v827, v828)
                    else
                        let v837 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure60()
                        US22_1(v837, v819, v820, v821, v822, v823)
                let v1024 : US22 =
                    match v839 with
                    | US22_1(v846, v847, v848, v849, v850, v851) -> (* Error *)
                        let v852 : bool = v819 >= v823
                        let v870 : US21 =
                            if v852 then
                                let v853 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure56()
                                US21_1(v853, v819, v820, v821, v822, v823)
                            else
                                let v855 : char = v0.[int v819]
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
                                    US21_0('\\', v857, v862, v863, v864, v865)
                                else
                                    let v867 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure57()
                                    US21_1(v867, v819, v820, v821, v822, v823)
                        let v900 : US21 =
                            match v870 with
                            | US21_1(v892, v893, v894, v895, v896, v897) -> (* Error *)
                                US21_1(v892, v893, v894, v895, v896, v897)
                            | US21_0(v871, v872, v873, v874, v875, v876) -> (* Ok *)
                                let v877 : bool = v872 >= v876
                                if v877 then
                                    let v878 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure65()
                                    US21_1(v878, v872, v873, v874, v875, v876)
                                else
                                    let v880 : char = v0.[int v872]
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
                                    US21_0(v880, v881, v886, v887, v888, v889)
                        let v922 : US22 =
                            match v900 with
                            | US21_1(v914, v915, v916, v917, v918, v919) -> (* Error *)
                                US22_1(v914, v915, v916, v917, v918, v919)
                            | US21_0(v901, v902, v903, v904, v905, v906) -> (* Ok *)
                                let v907 : bool = v819 >= v902
                                let v912 : string =
                                    if v907 then
                                        let v908 : string = ""
                                        v908
                                    else
                                        let v909 : bool = v819 = v902
                                        let v910 : int32 = v902 - 1
                                        let v911 : string = v0.[int v819..int v910]
                                        v911
                                US22_0(v912, v902, v903, v904, v905, v906)
                        match v922 with
                        | US22_1(v929, v930, v931, v932, v933, v934) -> (* Error *)
                            let v952 : US21 =
                                if v852 then
                                    let v935 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure58()
                                    US21_1(v935, v819, v820, v821, v822, v823)
                                else
                                    let v937 : char = v0.[int v819]
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
                                        US21_0('`', v939, v944, v945, v946, v947)
                                    else
                                        let v949 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure59()
                                        US21_1(v949, v819, v820, v821, v822, v823)
                            let v982 : US21 =
                                match v952 with
                                | US21_1(v974, v975, v976, v977, v978, v979) -> (* Error *)
                                    US21_1(v974, v975, v976, v977, v978, v979)
                                | US21_0(v953, v954, v955, v956, v957, v958) -> (* Ok *)
                                    let v959 : bool = v954 >= v958
                                    if v959 then
                                        let v960 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure65()
                                        US21_1(v960, v954, v955, v956, v957, v958)
                                    else
                                        let v962 : char = v0.[int v954]
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
                                        US21_0(v962, v963, v968, v969, v970, v971)
                            let v1004 : US22 =
                                match v982 with
                                | US21_1(v996, v997, v998, v999, v1000, v1001) -> (* Error *)
                                    US22_1(v996, v997, v998, v999, v1000, v1001)
                                | US21_0(v983, v984, v985, v986, v987, v988) -> (* Ok *)
                                    let v989 : bool = v819 >= v984
                                    let v994 : string =
                                        if v989 then
                                            let v990 : string = ""
                                            v990
                                        else
                                            let v991 : bool = v819 = v984
                                            let v992 : int32 = v984 - 1
                                            let v993 : string = v0.[int v819..int v992]
                                            v993
                                    US22_0(v994, v984, v985, v986, v987, v988)
                            match v1004 with
                            | US22_1(v1011, v1012, v1013, v1014, v1015, v1016) -> (* Error *)
                                let v1017 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure41()
                                US22_1(v1017, v819, v820, v821, v822, v823)
                            | US22_0(v1005, v1006, v1007, v1008, v1009, v1010) -> (* Ok *)
                                v1004
                        | US22_0(v923, v924, v925, v926, v927, v928) -> (* Ok *)
                            v922
                    | US22_0(v840, v841, v842, v843, v844, v845) -> (* Ok *)
                        v839
                let v1046 : US22 =
                    match v1024 with
                    | US22_1(v1025, v1026, v1027, v1028, v1029, v1030) -> (* Error *)
                        let v1031 : string = ""
                        US22_0(v1031, v819, v820, v821, v822, v823)
                    | US22_0(v1033, v1034, v1035, v1036, v1037, v1038) -> (* Ok *)
                        let v1039 : bool = v1034 = v819
                        if v1039 then
                            let v1040 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure63()
                            US22_1(v1040, v819, v820, v821, v822, v823)
                        else
                            let v1042 : UH0 = UH0_0
                            method135(v0, v1033, v1042, v1034, v1035, v1036, v1037, v1038)
                match v1046 with
                | US22_1(v1089, v1090, v1091, v1092, v1093, v1094) -> (* Error *)
                    let v1095 : bool = v819 >= v823
                    let v1113 : US21 =
                        if v1095 then
                            let v1096 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                            US21_1(v1096, v819, v820, v821, v822, v823)
                        else
                            let v1098 : char = v0.[int v819]
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
                                US21_0('"', v1100, v1105, v1106, v1107, v1108)
                            else
                                let v1110 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                                US21_1(v1110, v819, v820, v821, v822, v823)
                    match v1113 with
                    | US21_1(v1122, v1123, v1124, v1125, v1126, v1127) -> (* Error *)
                        let v1128 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure45()
                        US22_1(v1128, v819, v820, v821, v822, v823)
                    | US21_0(v1114, v1115, v1116, v1117, v1118, v1119) -> (* Ok *)
                        let v1120 : string = ""
                        US22_0(v1120, v1115, v1116, v1117, v1118, v1119)
                | US22_0(v1047, v1048, v1049, v1050, v1051, v1052) -> (* Ok *)
                    let v1053 : bool = v1048 >= v1052
                    let v1071 : US21 =
                        if v1053 then
                            let v1054 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure36()
                            US21_1(v1054, v1048, v1049, v1050, v1051, v1052)
                        else
                            let v1056 : char = v0.[int v1048]
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
                                US21_0('"', v1058, v1063, v1064, v1065, v1066)
                            else
                                let v1068 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure37()
                                US21_1(v1068, v1048, v1049, v1050, v1051, v1052)
                    match v1071 with
                    | US21_1(v1079, v1080, v1081, v1082, v1083, v1084) -> (* Error *)
                        let v1085 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure46(v819, v1048, v1079, v1080, v1081, v1082, v1083, v1084)
                        US22_1(v1085, v1048, v1049, v1050, v1051, v1052)
                    | US21_0(v1072, v1073, v1074, v1075, v1076, v1077) -> (* Ok *)
                        US22_0(v1047, v1073, v1074, v1075, v1076, v1077)
        | US22_0(v792, v793, v794, v795, v796, v797) -> (* Ok *)
            v791
    let v1178 : US22 =
        match v1144 with
        | US22_1(v1151, v1152, v1153, v1154, v1155, v1156) -> (* Error *)
            let v1157 : int32 = 0
            let v1158 : int32 = 0
            let v1159 : int32 = 1
            let v1160 : int32 = 1
            let struct (v1161 : int32, v1162 : int32, v1163 : int32, v1164 : int32, v1165 : int32) = method136(v1, v0, v1157, v1158, v1159, v1160)
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
                        let v1171 : string = v0.[int 0..int v1170]
                        v1171
                US22_0(v1172, v1161, v1162, v1163, v1164, v1165)
            else
                let v1174 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure60()
                US22_1(v1174, 0, 0, 1, 1, v1)
        | US22_0(v1145, v1146, v1147, v1148, v1149, v1150) -> (* Ok *)
            v1144
    let v1217 : US22 =
        match v1178 with
        | US22_1(v1185, v1186, v1187, v1188, v1189, v1190) -> (* Error *)
            let v1191 : UH0 = UH0_0
            let v1192 : int32 = 0
            let v1193 : int32 = 0
            let v1194 : int32 = 1
            let v1195 : int32 = 1
            let v1196 : US30 = method138(v0, v1191, v1192, v1193, v1194, v1195, v1)
            match v1196 with
            | US30_1(v1207, v1208, v1209, v1210, v1211, v1212) -> (* Error *)
                US22_1(v1207, v1208, v1209, v1210, v1211, v1212)
            | US30_0(v1197, v1198, v1199, v1200, v1201, v1202) -> (* Ok *)
                let v1203 : string = ""
                let struct (v1204 : string, v1205 : string) = method140(v1197, v1203)
                US22_0(v1204, v1198, v1199, v1200, v1201, v1202)
        | US22_0(v1179, v1180, v1181, v1182, v1183, v1184) -> (* Ok *)
            v1178
    let v1228 : US22 =
        match v1217 with
        | US22_0(v1218, v1219, v1220, v1221, v1222, v1223) -> (* Ok *)
            let v1224 : bool = v1219 = 0
            if v1224 then
                let v1225 : (struct (string * int32 * int32 * int32 * int32 * int32) -> string) = closure69()
                US22_1(v1225, 0, 0, 1, 1, v1)
            else
                v1217
        | _ ->
            v1217
    let v1245 : US22 =
        match v1228 with
        | US22_1(v1229, v1230, v1231, v1232, v1233, v1234) -> (* Error *)
            US22_1(v1229, v1230, v1231, v1232, v1233, v1234)
        | US22_0(v1236, v1237, v1238, v1239, v1240, v1241) -> (* Ok *)
            let v1242 : UH0 = UH0_0
            method141(v0, v1236, v1242, v1237, v1238, v1239, v1240, v1241)
    let v1264 : US30 =
        match v1245 with
        | US22_1(v1246, v1247, v1248, v1249, v1250, v1251) -> (* Error *)
            let v1252 : UH0 = UH0_0
            US30_0(v1252, 0, 0, 1, 1, v1)
        | US22_0(v1254, v1255, v1256, v1257, v1258, v1259) -> (* Ok *)
            let v1260 : UH0 = UH0_0
            let v1261 : UH0 = UH0_1(v1254, v1260)
            method144(v0, v1261, v1255, v1256, v1257, v1258, v1259)
    let v1287 : US31 =
        match v1264 with
        | US30_1(v1278, v1279, v1280, v1281, v1282, v1283) -> (* Error *)
            let v1284 : (unit -> string) = closure55(v0, v1278, v1279, v1280, v1281, v1282, v1283)
            US31_1(v1284)
        | US30_0(v1265, v1266, v1267, v1268, v1269, v1270) -> (* Ok *)
            let v1271 : bool = v1266 >= v1270
            let v1276 : string =
                if v1271 then
                    let v1272 : string = ""
                    v1272
                else
                    let v1273 : bool = v1266 = v1270
                    let v1274 : int32 = v1270 - 1
                    let v1275 : string = v0.[int v1266..int v1274]
                    v1275
            US31_0(v1265, v1276, v1267, v1268, v1269, v1270)
    let v1354 : US32 =
        match v1287 with
        | US31_1(v1351) -> (* Error *)
            US32_1(v1351)
        | US31_0(v1288, v1289, v1290, v1291, v1292, v1293) -> (* Ok *)
            let v1330 : string list = []
            let v1331 : string list = method145(v1288, v1330)
            let v1348 : (string list -> (string [])) = List.toArray
            let v1349 : (string []) = v1348 v1331
            US32_0(v1349)
    match v1354 with
    | US32_1(v1357) -> (* Error *)
        let v1358 : string = v1357 ()
        US29_1(v1358)
    | US32_0(v1355) -> (* Ok *)
        US29_0(v1355)
and closure72 () (v0 : (string)) : std_string_String =
    let v1 : string = (v0)
    let v2 : Ref<Str> = v1 |> unbox<Ref<Str>>
    let v3 : std_string_String = v2 |> unbox<std_string_String>
    v3
and method148 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "file_name"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method149 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "arguments"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method150 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "options"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method151 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "command"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method152 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "cancellation_token"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method153 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "environment_variables"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method154 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "on_line"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method155 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "stdin"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method156 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "trace"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method157 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "working_directory"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method158 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "stderr"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method147 (v0 : string, v1 : string, v2 : string, v3 : System.Threading.CancellationToken option, v4 : (struct (string * string) []), v5 : (struct (int32 * string * bool) -> Async<unit>) option, v6 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v7 : bool, v8 : string option, v9 : bool) : string =
    let v10 : string = method13()
    let v11 : Mut3 = {l0 = v10} : Mut3
    method18(v11)
    method148(v11)
    method20(v11)
    method14(v11, v0)
    method46(v11)
    method149(v11)
    method20(v11)
    method14(v11, v1)
    method46(v11)
    method150(v11)
    method20(v11)
    method18(v11)
    method151(v11)
    method20(v11)
    method14(v11, v2)
    method46(v11)
    method152(v11)
    method20(v11)
    let v178 : string = $"%A{v3}"
    method14(v11, v178)
    method46(v11)
    method153(v11)
    method20(v11)
    let v230 : string = $"%A{v4}"
    method14(v11, v230)
    method46(v11)
    method154(v11)
    method20(v11)
    let v297 : string = $"%A{v5}"
    method14(v11, v297)
    method46(v11)
    method155(v11)
    method20(v11)
    let v378 : string = $"%A{v6}"
    method14(v11, v378)
    method46(v11)
    method156(v11)
    method20(v11)
    let v425 : string =
        if v7 then
            let v423 : string = "true"
            v423
        else
            let v424 : string = "false"
            v424
    method14(v11, v425)
    method46(v11)
    method157(v11)
    method20(v11)
    let v466 : string = $"%A{v8}"
    method14(v11, v466)
    method46(v11)
    method158(v11)
    method20(v11)
    let v507 : string =
        if v9 then
            let v505 : string = "true"
            v505
        else
            let v506 : string = "false"
            v506
    method14(v11, v507)
    method21(v11)
    method21(v11)
    let v508 : string = v11.l0
    v508
and method146 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option, v17 : bool) : string =
    let v18 : int64 = v0.l0
    let v19 : string = " "
    let v20 : string = v6 + v19 
    let v21 : string = method16(v18)
    let v22 : string = v20 + v21 
    let v23 : string = v22 + v7 
    let v24 : string = v23 + v19 
    let v29 : string = "runtime.execute_with_options"
    let v30 : string = v24 + v29 
    let v38 : string = " / "
    let v39 : string = v30 + v38 
    let v40 : string = method147(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17)
    let v41 : string = v39 + v40 
    method22(v41)
and closure73 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : US33 =
    US33_0(v0)
and method159 () : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US33) =
    closure73()
and closure74 () (v0 : std_string_String) : US33 =
    US33_1(v0)
and method160 () : (std_string_String -> US33) =
    closure74()
and method162 (v0 : std_string_String, v1 : string, v2 : string, v3 : string, v4 : System.Threading.CancellationToken option, v5 : (struct (string * string) []), v6 : (struct (int32 * string * bool) -> Async<unit>) option, v7 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v8 : bool, v9 : string option, v10 : bool) : string =
    let v11 : string = method13()
    let v12 : Mut3 = {l0 = v11} : Mut3
    method18(v12)
    method47(v12)
    method20(v12)
    let v13 : string = $"%A{v0}"
    method14(v12, v13)
    method46(v12)
    method148(v12)
    method20(v12)
    method14(v12, v1)
    method46(v12)
    method149(v12)
    method20(v12)
    method14(v12, v2)
    method46(v12)
    method150(v12)
    method20(v12)
    method18(v12)
    method151(v12)
    method20(v12)
    method14(v12, v3)
    method46(v12)
    method152(v12)
    method20(v12)
    let v14 : string = $"%A{v4}"
    method14(v12, v14)
    method46(v12)
    method153(v12)
    method20(v12)
    let v15 : string = $"%A{v5}"
    method14(v12, v15)
    method46(v12)
    method154(v12)
    method20(v12)
    let v16 : string = $"%A{v6}"
    method14(v12, v16)
    method46(v12)
    method155(v12)
    method20(v12)
    let v17 : string = $"%A{v7}"
    method14(v12, v17)
    method46(v12)
    method156(v12)
    method20(v12)
    let v20 : string =
        if v8 then
            let v18 : string = "true"
            v18
        else
            let v19 : string = "false"
            v19
    method14(v12, v20)
    method46(v12)
    method157(v12)
    method20(v12)
    let v21 : string = $"%A{v9}"
    method14(v12, v21)
    method46(v12)
    method158(v12)
    method20(v12)
    let v24 : string =
        if v10 then
            let v22 : string = "true"
            v22
        else
            let v23 : string = "false"
            v23
    method14(v12, v24)
    method21(v12)
    method21(v12)
    let v25 : string = v12.l0
    v25
and method161 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String, v9 : string, v10 : string, v11 : string, v12 : System.Threading.CancellationToken option, v13 : (struct (string * string) []), v14 : (struct (int32 * string * bool) -> Async<unit>) option, v15 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v16 : bool, v17 : string option, v18 : bool) : string =
    let v19 : int64 = v0.l0
    let v20 : string = " "
    let v21 : string = v6 + v20 
    let v22 : string = method16(v19)
    let v23 : string = v21 + v22 
    let v24 : string = v23 + v7 
    let v25 : string = v24 + v20 
    let v26 : string = "runtime.execute_with_options / child error"
    let v27 : string = v25 + v26 
    let v28 : string = " / "
    let v29 : string = v27 + v28 
    let v30 : string = method162(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18)
    let v31 : string = v29 + v30 
    method22(v31)
and closure75 () (v0 : std_string_String) : US35 =
    US35_0(v0)
and method163 () : (std_string_String -> US35) =
    closure75()
and closure76 () (v0 : std_string_String) : US35 =
    US35_1(v0)
and method164 () : (std_string_String -> US35) =
    closure76()
and method167 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "trace'"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method166 (v0 : bool, v1 : std_string_String) : string =
    let v2 : string = method13()
    let v3 : Mut3 = {l0 = v2} : Mut3
    method18(v3)
    method167(v3)
    method20(v3)
    let v6 : string =
        if v0 then
            let v4 : string = "true"
            v4
        else
            let v5 : string = "false"
            v5
    method14(v3, v6)
    method46(v3)
    method119(v3)
    method20(v3)
    let v7 : string = $"%A{v1}"
    method14(v3, v7)
    method21(v3)
    let v8 : string = v3.l0
    v8
and method165 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : bool, v9 : std_string_String) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method16(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "runtime.stdio_line"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = method166(v8, v9)
    let v22 : string = v20 + v21 
    method22(v22)
and method168 () : string =
    let v0 : string = "\u001b[90m"
    
    
    
    
    
    let v1 : string = "Verbose"
    let v2 : (unit -> string) = v1.ToLower
    let v3 : string = v2 ()
    let v4 : char = v3.[int 0]
    let v5 : string = method12(v4)
    let v6 : string = v0 + v5 
    let v7 : string = "\u001b[0m"
    let v8 : string = v6 + v7 
    v8
and method170 () : string =
    let v0 : string = method13()
    let v1 : Mut3 = {l0 = v0} : Mut3
    let v2 : string = v1.l0
    v2
and method169 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : int64 = v0.l0
    let v10 : string = " "
    let v11 : string = v6 + v10 
    let v12 : string = method16(v9)
    let v13 : string = v11 + v12 
    let v14 : string = v13 + v7 
    let v15 : string = v14 + v10 
    let v16 : string = v15 + v8 
    let v17 : string = " / "
    let v18 : string = v16 + v17 
    let v19 : string = method170()
    let v20 : string = v18 + v19 
    method22(v20)
and method171 (v0 : Result<unit, string>) : Result<unit, string> =
    v0
and closure77 () (v0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)) : US36 =
    US36_0(v0)
and method172 () : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US36) =
    closure77()
and closure78 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : US37 =
    US37_0(v0)
and method173 () : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US37) =
    closure78()
and method174 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure79 () (v0 : std_process_Output) : US38 =
    US38_0(v0)
and method175 () : (std_process_Output -> US38) =
    closure79()
and closure80 () (v0 : std_string_String) : US38 =
    US38_1(v0)
and method176 () : (std_string_String -> US38) =
    closure80()
and method177 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String, v9 : string, v10 : string, v11 : string, v12 : System.Threading.CancellationToken option, v13 : (struct (string * string) []), v14 : (struct (int32 * string * bool) -> Async<unit>) option, v15 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v16 : bool, v17 : string option, v18 : bool) : string =
    let v19 : int64 = v0.l0
    let v20 : string = " "
    let v21 : string = v6 + v20 
    let v22 : string = method16(v19)
    let v23 : string = v21 + v22 
    let v24 : string = v23 + v7 
    let v25 : string = v24 + v20 
    let v26 : string = "runtime.execute_with_options / output error"
    let v27 : string = v25 + v26 
    let v28 : string = " / "
    let v29 : string = v27 + v28 
    let v30 : string = method162(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18)
    let v31 : string = v29 + v30 
    method22(v31)
and closure81 () (v0 : int32) : US39 =
    US39_0(v0)
and method178 () : (int32 -> US39) =
    closure81()
and method179 (v0 : Vec<uint8>) : Vec<uint8> =
    v0
and method180 (v0 : string, v1 : int32) : int32 =
    let v2 : bool = v1 <= 0
    if v2 then
        -1
    else
        let v3 : int32 = v1 - 1
        let v4 : char = v0.[int v3]
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
            method180(v0, v3)
        else
            v3
and method181 (v0 : UH0, v1 : string) : struct (string * string) =
    let struct (v11 : string, v12 : string) =
        match v0 with
        | UH0_1(v2, v3) -> (* Cons *)
            let struct (v4 : string, v5 : string) = method181(v3, v1)
            let v6 : string = v2 + v5 
            let v7 : string = v6 + v4 
            let v8 : string = "\n"
            struct (v7, v8)
        | _ ->
            let struct (v9 : string, v10 : string) =
                match v0 with
                | UH0_0 -> (* Nil *)
                    struct (v1, v1)
            struct (v9, v10)
    struct (v11, v12)
and closure82 () (v0 : (std_string_String)) : string =
    let v1 : std_string_String = (v0)
    let v2 : string = "Fsharp"
    let v3 : string = () // backend.backend_switch / record_type_try_find / key: v2 
    v3
and method182 () : string =
    let v0 : string = "\n"
    v0
and method185 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "exit_code"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method186 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "std_trace_len"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method184 (v0 : string, v1 : int32, v2 : int32) : string =
    let v3 : string = method13()
    let v4 : Mut3 = {l0 = v3} : Mut3
    method18(v4)
    method148(v4)
    method20(v4)
    method14(v4, v0)
    method46(v4)
    method185(v4)
    method20(v4)
    let v5 : string = $"{v1}"
    method14(v4, v5)
    method46(v4)
    method186(v4)
    method20(v4)
    let v6 : string = $"{v2}"
    method14(v4, v6)
    method21(v4)
    let v7 : string = v4.l0
    v7
and method183 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : int32, v10 : int32) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method16(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "runtime.execute_with_options / result"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = method184(v8, v9, v10)
    let v23 : string = v21 + v22 
    method22(v23)
and method94 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : bool) : struct (int32 * string) =
    let v42 : string = method95(v0, v1, v2, v3, v4, v5, v6, v7)
    let v43 : US20 = method96(v42)
    let struct (v61 : string, v62 : US3) =
        match v43 with
        | US20_1(v46) -> (* Error *)
            let v49 : string = $"resultm.get / Error x: {v46}"
            failwith<struct (string * US3)> v49
        | US20_0(v44, v45) -> (* Ok *)
            struct (v44, v45)
    let v66 : string =
        match v62 with
        | US3_1 -> (* None *)
            let v64 : string = ""
            v64
        | US3_0(v63) -> (* Some *)
            v63
    let v67 : US29 = method126(v66)
    let v73 : (string []) =
        match v67 with
        | US29_1(v69) -> (* Error *)
            let v70 : string = $"resultm.get / Error x: {v69}"
            failwith<(string [])> v70
        | US29_0(v68) -> (* Ok *)
            v68
    let v96 : string = "Fsharp"
    let v97 : Vec<string> = () // backend.backend_switch / record_type_try_find / key: v96 
    let v134 : string = "$0.iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v135 : ((string) -> std_string_String) = closure72()
    let v136 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v97, v135) v134 
    let v137 : bool = TraceState.trace_state.IsNone
    if v137 then
        let v138 : US0 = US0_0
        let struct (v139 : Mut0, v140 : Mut1, v141 : Mut2, v142 : Mut3, v143 : Mut4, v144 : int64 option) = method1(v138)
        let v145 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v139, v140, v141, v142, v143, v144) 
        TraceState.trace_state <- v145 
        ()
    let struct (v146 : Mut0, v147 : Mut1, v148 : Mut2, v149 : Mut3, v150 : Mut4, v151 : int64 option) = TraceState.trace_state.Value
    let v152 : US0 = v150.l0
    let v157 : int32 =
        match v152 with
        | US0_4 -> (* Critical *)
            50
        | US0_1 -> (* Debug *)
            20
        | US0_2 -> (* Info *)
            30
        | US0_0 -> (* Verbose *)
            10
        | US0_3 -> (* Warning *)
            40
    let v158 : bool = v148.l0
    let v159 : bool = v158 = false
    let v161 : bool =
        if v159 then
            false
        else
            let v160 : bool = 20 >= v157
            v160
    let v162 : bool = v161 = false
    let v212 : US7 =
        if v162 then
            US7_1
        else
            let v164 : bool = TraceState.trace_state.IsNone
            if v164 then
                let v165 : US0 = US0_0
                let struct (v166 : Mut0, v167 : Mut1, v168 : Mut2, v169 : Mut3, v170 : Mut4, v171 : int64 option) = method1(v165)
                let v172 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v166, v167, v168, v169, v170, v171) 
                TraceState.trace_state <- v172 
                ()
            let struct (v173 : Mut0, v174 : Mut1, v175 : Mut2, v176 : Mut3, v177 : Mut4, v178 : int64 option) = TraceState.trace_state.Value
            let v179 : string = method8(v173, v174, v175, v176, v177, v178)
            let v180 : string = method67()
            let v183 : string = $"%A{v136}"
            let v191 : string = method146(v173, v174, v175, v176, v177, v178, v179, v180, v61, v183, v0, v1, v2, v3, v4, v5, v6, v7)
            let v192 : bool = TraceState.trace_state.IsNone
            if v192 then
                let v193 : US0 = US0_0
                let struct (v194 : Mut0, v195 : Mut1, v196 : Mut2, v197 : Mut3, v198 : Mut4, v199 : int64 option) = method1(v193)
                let v200 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v194, v195, v196, v197, v198, v199) 
                TraceState.trace_state <- v200 
                ()
            let struct (v201 : Mut0, v202 : Mut1, v203 : Mut2, v204 : Mut3, v205 : Mut4, v206 : int64 option) = TraceState.trace_state.Value
            let v207 : int64 = v201.l0
            let v208 : int64 = v207 + 1L
            v201.l0 <- v208
            let v209 : (string -> unit) = closure12()
            v209 v191
            let v210 : (string -> unit) = v202.l0
            v210 v191
            US7_0(v201, v202, v203, v204, v205, v206)
    let v3024 : bool = true
    let mutable _capture_v3024 : (int32 * string) option = None 
    (
    (fun () ->
    (fun () ->
    let v3025 : string = "std::process::Command::new(&*$0)"
    let v3026 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v61 v3025 
    let v3027 : string = "true; let mut v3026 = v3026"
    let v3028 : bool = Fable.Core.RustInterop.emitRustExpr () v3027 
    let v3029 : string = "true; std::process::Command::args(&mut v3026, &*$0)"
    let v3030 : bool = Fable.Core.RustInterop.emitRustExpr v136 v3029 
    let v3031 : string = "$0"
    let v3032 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v3026 v3031 
    let v3033 : string = "std::process::Stdio::piped()"
    let v3034 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v3033 
    let v3035 : string = "true; let mut v3032 = v3032"
    let v3036 : bool = Fable.Core.RustInterop.emitRustExpr () v3035 
    let v3037 : string = "true; std::process::Command::stdout(&mut v3032, std::process::Stdio::piped())"
    let v3038 : bool = Fable.Core.RustInterop.emitRustExpr () v3037 
    let v3039 : string = "$0"
    let v3040 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v3032 v3039 
    let v3041 : string = "std::process::Stdio::piped()"
    let v3042 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v3041 
    let v3043 : string = "true; let mut v3040 = v3040"
    let v3044 : bool = Fable.Core.RustInterop.emitRustExpr () v3043 
    let v3045 : string = "true; std::process::Command::stderr(&mut v3040, std::process::Stdio::piped())"
    let v3046 : bool = Fable.Core.RustInterop.emitRustExpr () v3045 
    let v3047 : string = "$0"
    let v3048 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v3040 v3047 
    let v3049 : string = "std::process::Stdio::piped()"
    let v3050 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v3049 
    let v3051 : string = "true; let mut v3048 = v3048"
    let v3052 : bool = Fable.Core.RustInterop.emitRustExpr () v3051 
    let v3053 : string = "true; std::process::Command::stdin(&mut v3048, std::process::Stdio::piped())"
    let v3054 : bool = Fable.Core.RustInterop.emitRustExpr () v3053 
    let v3055 : string = "$0"
    let v3056 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v3048 v3055 
    let v3057 : (string -> US3) = method4()
    let v3058 : US3 option = v6 |> Option.map v3057 
    let v3059 : US3 = US3_1
    let v3060 : US3 = v3058 |> Option.defaultValue v3059 
    let v3073 : std_process_Command =
        match v3060 with
        | US3_1 -> (* None *)
            let v3068 : string = $"v3056"
            let v3069 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v3068 
            let v3070 : string = "$0"
            let v3071 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v3069 v3070 
            v3071
        | US3_0(v3061) -> (* Some *)
            let v3062 : string = "true; let mut v3056 = v3056"
            let v3063 : bool = Fable.Core.RustInterop.emitRustExpr () v3062 
            let v3064 : string = "true; std::process::Command::current_dir(&mut v3056, &*$0)"
            let v3065 : bool = Fable.Core.RustInterop.emitRustExpr v3061 v3064 
            let v3066 : string = $"v3056"
            let v3067 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v3066 
            v3067
    let v3074 : uint64 = System.Convert.ToUInt64 v2.Length
    let v3075 : bool = v3074 = 0UL
    let v3094 : std_process_Command =
        if v3075 then
            v3073
        else
            let v3076 : Vec<struct (string * string)> = () // backend.backend_switch / record_type_try_find / key: v96 
            let v3077 : string = "true; let _vec_fold_ = $0.into_iter().fold(v3073, |acc, x| { //"
            let v3078 : bool = Fable.Core.RustInterop.emitRustExpr v3076 v3077 
            let v3079 : string = "acc"
            let v3080 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v3079 
            let v3081 : string = "x"
            let struct (v3082 : string, v3083 : string) = Fable.Core.RustInterop.emitRustExpr () v3081 
            let v3084 : string = "true; let mut v3080 = v3080"
            let v3085 : bool = Fable.Core.RustInterop.emitRustExpr () v3084 
            let v3086 : string = "true; std::process::Command::env(&mut v3080, &*$0, &*$1)"
            let v3087 : bool = Fable.Core.RustInterop.emitRustExpr struct (v3082, v3083) v3086 
            let v3088 : string = "$0"
            let v3089 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v3080 v3088 
            let v3090 : string = "true; $0 })"
            let v3091 : bool = Fable.Core.RustInterop.emitRustExpr v3089 v3090 
            let v3092 : string = "_vec_fold_"
            let v3093 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v3092 
            v3093
    let v3095 : string = "true; let mut v3094 = v3094"
    let v3096 : bool = Fable.Core.RustInterop.emitRustExpr () v3095 
    let v3097 : string = "std::process::Command::spawn(&mut v3094)"
    let v3098 : Result<std_process_Child, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v3097 
    let v3099 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v3100 : bool = Fable.Core.RustInterop.emitRustExpr v3098 v3099 
    let v3101 : string = "x"
    let v3102 : std_io_Error = Fable.Core.RustInterop.emitRustExpr () v3101 
    let v3103 : std_string_String = null |> unbox<std_string_String>
    let v3104 : string = "true; $0 })"
    let v3105 : bool = Fable.Core.RustInterop.emitRustExpr v3103 v3104 
    let v3106 : string = "_result_map_error__"
    let v3107 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3106 
    let v3108 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v3109 : bool = Fable.Core.RustInterop.emitRustExpr v3107 v3108 
    let v3110 : string = "x"
    let v3111 : std_process_Child = Fable.Core.RustInterop.emitRustExpr () v3110 
    let v3112 : string = "$0"
    let v3113 : std_process_Child = Fable.Core.RustInterop.emitRustExpr v3111 v3112 
    let v3114 : std_process_Child option = Some v3113 
    let v3115 : string = "$0"
    let v3116 : std_process_Child option = Fable.Core.RustInterop.emitRustExpr v3114 v3115 
    let v3117 : string = "std::sync::Mutex::new(v3116)"
    let v3118 : std_sync_Mutex<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr () v3117 
    let v3119 : string = "std::sync::Arc::new(v3118)"
    let v3120 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr () v3119 
    let v3121 : string = "true; $0 })"
    let v3122 : bool = Fable.Core.RustInterop.emitRustExpr v3120 v3121 
    let v3123 : string = "_result_map_"
    let v3124 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3123 
    let v3125 : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US33) = method159()
    let v3126 : (std_string_String -> US33) = method160()
    let v3128 : US33 = match v3124 with Ok x -> v3125 x | Error x -> v3126 x
    let struct (v3981 : int32, v3982 : US8, v3983 : US34) =
        match v3128 with
        | US33_1(v3908) -> (* Error *)
            let v3909 : bool = TraceState.trace_state.IsNone
            if v3909 then
                let v3910 : US0 = US0_0
                let struct (v3911 : Mut0, v3912 : Mut1, v3913 : Mut2, v3914 : Mut3, v3915 : Mut4, v3916 : int64 option) = method1(v3910)
                let v3917 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v3911, v3912, v3913, v3914, v3915, v3916) 
                TraceState.trace_state <- v3917 
                ()
            let struct (v3918 : Mut0, v3919 : Mut1, v3920 : Mut2, v3921 : Mut3, v3922 : Mut4, v3923 : int64 option) = TraceState.trace_state.Value
            let v3924 : US0 = v3922.l0
            let v3929 : int32 =
                match v3924 with
                | US0_4 -> (* Critical *)
                    50
                | US0_1 -> (* Debug *)
                    20
                | US0_2 -> (* Info *)
                    30
                | US0_0 -> (* Verbose *)
                    10
                | US0_3 -> (* Warning *)
                    40
            let v3930 : bool = v3920.l0
            let v3931 : bool = v3930 = false
            let v3933 : bool =
                if v3931 then
                    false
                else
                    let v3932 : bool = 50 >= v3929
                    v3932
            let v3934 : bool = v3933 = false
            let v3975 : US7 =
                if v3934 then
                    US7_1
                else
                    let v3936 : bool = TraceState.trace_state.IsNone
                    if v3936 then
                        let v3937 : US0 = US0_0
                        let struct (v3938 : Mut0, v3939 : Mut1, v3940 : Mut2, v3941 : Mut3, v3942 : Mut4, v3943 : int64 option) = method1(v3937)
                        let v3944 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v3938, v3939, v3940, v3941, v3942, v3943) 
                        TraceState.trace_state <- v3944 
                        ()
                    let struct (v3945 : Mut0, v3946 : Mut1, v3947 : Mut2, v3948 : Mut3, v3949 : Mut4, v3950 : int64 option) = TraceState.trace_state.Value
                    let v3951 : string = method8(v3945, v3946, v3947, v3948, v3949, v3950)
                    let v3952 : string = method85()
                    let v3953 : string = $"%A{v136}"
                    let v3954 : string = method161(v3945, v3946, v3947, v3948, v3949, v3950, v3951, v3952, v3908, v61, v3953, v0, v1, v2, v3, v4, v5, v6, v7)
                    let v3955 : bool = TraceState.trace_state.IsNone
                    if v3955 then
                        let v3956 : US0 = US0_0
                        let struct (v3957 : Mut0, v3958 : Mut1, v3959 : Mut2, v3960 : Mut3, v3961 : Mut4, v3962 : int64 option) = method1(v3956)
                        let v3963 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v3957, v3958, v3959, v3960, v3961, v3962) 
                        TraceState.trace_state <- v3963 
                        ()
                    let struct (v3964 : Mut0, v3965 : Mut1, v3966 : Mut2, v3967 : Mut3, v3968 : Mut4, v3969 : int64 option) = TraceState.trace_state.Value
                    let v3970 : int64 = v3964.l0
                    let v3971 : int64 = v3970 + 1L
                    v3964.l0 <- v3971
                    let v3972 : (string -> unit) = closure12()
                    v3972 v3954
                    let v3973 : (string -> unit) = v3965.l0
                    v3973 v3954
                    US7_0(v3964, v3965, v3966, v3967, v3968, v3969)
            let v3976 : US8 = US8_0(v3908)
            let v3977 : US34 = US34_1
            struct (-1, v3976, v3977)
        | US33_0(v3129) -> (* Ok *)
            let v3130 : string = "true; let _capture = (|| { //"
            let v3131 : bool = Fable.Core.RustInterop.emitRustExpr () v3130 
            let v3132 : string = "$0"
            let v3133 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v3129 v3132 
            let v3134 : string = "v3133.lock()"
            let v3135 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v3134 
            let v3136 : string = "$0.unwrap()"
            let v3137 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v3135 v3136 
            let v3138 : string = "$0"
            let v3139 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v3137 v3138 
            let v3140 : string = "true; let mut v3139 = v3139"
            let v3141 : bool = Fable.Core.RustInterop.emitRustExpr () v3140 
            let v3142 : string = "&mut $0"
            let v3143 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v3139 v3142 
            let v3144 : string = "$0.as_mut()"
            let v3145 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v3143 v3144 
            let v3146 : string = "$0.unwrap()"
            let v3147 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v3145 v3146 
            let v3148 : string = "&mut $0.stdout"
            let v3149 : Ref<Mut<std_process_ChildStdout option>> = Fable.Core.RustInterop.emitRustExpr v3147 v3148 
            let v3150 : string = "Option::take($0)"
            let v3151 : std_process_ChildStdout option = Fable.Core.RustInterop.emitRustExpr v3149 v3150 
            let v3152 : string = "$0.unwrap()"
            let v3153 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr v3151 v3152 
            let v3154 : string = "true; $0 })()"
            let v3155 : bool = Fable.Core.RustInterop.emitRustExpr v3153 v3154 
            let v3156 : string = "_capture"
            let v3157 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr () v3156 
            let v3158 : string = "true; let _capture = (|| { //"
            let v3159 : bool = Fable.Core.RustInterop.emitRustExpr () v3158 
            let v3160 : string = "$0"
            let v3161 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v3129 v3160 
            let v3162 : string = "v3161.lock()"
            let v3163 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v3162 
            let v3164 : string = "$0.unwrap()"
            let v3165 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v3163 v3164 
            let v3166 : string = "$0"
            let v3167 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v3165 v3166 
            let v3168 : string = "true; let mut v3167 = v3167"
            let v3169 : bool = Fable.Core.RustInterop.emitRustExpr () v3168 
            let v3170 : string = "&mut $0"
            let v3171 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v3167 v3170 
            let v3172 : string = "$0.as_mut()"
            let v3173 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v3171 v3172 
            let v3174 : string = "$0.unwrap()"
            let v3175 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v3173 v3174 
            let v3176 : string = "&mut $0.stderr"
            let v3177 : Ref<Mut<std_process_ChildStderr option>> = Fable.Core.RustInterop.emitRustExpr v3175 v3176 
            let v3178 : string = "Option::take($0)"
            let v3179 : std_process_ChildStderr option = Fable.Core.RustInterop.emitRustExpr v3177 v3178 
            let v3180 : string = "$0.unwrap()"
            let v3181 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr v3179 v3180 
            let v3182 : string = "true; $0 })()"
            let v3183 : bool = Fable.Core.RustInterop.emitRustExpr v3181 v3182 
            let v3184 : string = "_capture"
            let v3185 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr () v3184 
            let v3186 : string = "true; let _capture = (|| { //"
            let v3187 : bool = Fable.Core.RustInterop.emitRustExpr () v3186 
            let v3188 : string = "$0"
            let v3189 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v3129 v3188 
            let v3190 : string = "v3189.lock()"
            let v3191 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v3190 
            let v3192 : string = "$0.unwrap()"
            let v3193 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v3191 v3192 
            let v3194 : string = "$0"
            let v3195 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v3193 v3194 
            let v3196 : string = "true; let mut v3195 = v3195"
            let v3197 : bool = Fable.Core.RustInterop.emitRustExpr () v3196 
            let v3198 : string = "&mut $0"
            let v3199 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v3195 v3198 
            let v3200 : string = "$0.as_mut()"
            let v3201 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v3199 v3200 
            let v3202 : string = "$0.unwrap()"
            let v3203 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v3201 v3202 
            let v3204 : string = "&mut $0.stdin"
            let v3205 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v3203 v3204 
            let v3206 : string = "Option::take($0)"
            let v3207 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v3205 v3206 
            let v3208 : string = "$0.unwrap()"
            let v3209 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr v3207 v3208 
            let v3210 : std_process_ChildStdin option = Some v3209 
            let v3211 : string = "$0"
            let v3212 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v3210 v3211 
            let v3213 : string = "std::sync::Mutex::new(v3212)"
            let v3214 : std_sync_Mutex<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr () v3213 
            let v3215 : string = "std::sync::Arc::new(v3214)"
            let v3216 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v3215 
            let v3217 : string = "true; $0 })()"
            let v3218 : bool = Fable.Core.RustInterop.emitRustExpr v3216 v3217 
            let v3219 : string = "_capture"
            let v3220 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v3219 
            let v3221 : string = "{ let (sender, receiver) = std::sync::mpsc::channel(); (sender, std::sync::Arc::new(receiver)) }"
            let struct (v3222 : std_sync_mpsc_Sender<std_string_String>, v3223 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = Fable.Core.RustInterop.emitRustExpr () v3221 
            let v3224 : string = "$0"
            let v3225 : std_sync_mpsc_Sender<std_string_String> = Fable.Core.RustInterop.emitRustExpr v3222 v3224 
            let v3226 : string = "std::sync::Mutex::new(v3225)"
            let v3227 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v3226 
            let v3228 : string = "std::sync::Arc::new(v3227)"
            let v3229 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v3228 
            let v3230 : string = "$0"
            let v3231 : std_sync_mpsc_Sender<std_string_String> = Fable.Core.RustInterop.emitRustExpr v3222 v3230 
            let v3232 : string = "std::sync::Mutex::new(v3231)"
            let v3233 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v3232 
            let v3234 : string = "std::sync::Arc::new(v3233)"
            let v3235 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v3234 
            let v3236 : string = "$0"
            let v3237 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v3223 v3236 
            let v3238 : string = "std::sync::Mutex::new(v3237)"
            let v3239 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v3238 
            let v3240 : string = "std::sync::Arc::new(v3239)"
            let v3241 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v3240 
            let v3242 : string = "true; let __spawn = std::thread::spawn(move || { //"
            let v3243 : bool = Fable.Core.RustInterop.emitRustExpr () v3242 
            let v3244 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v3245 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v3157 v3244 
            let v3246 : string = "std::io::BufReader::new($0)"
            let v3247 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr v3245 v3246 
            let v3248 : string = "std::io::BufRead::lines(v3247)"
            let v3249 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v3248 
            let v3250 : string = "true; let mut v3249 = v3249; let _iter_try_for_each = v3249.try_for_each(|x| { //"
            let v3251 : bool = Fable.Core.RustInterop.emitRustExpr () v3250 
            let v3252 : string = "x"
            let v3253 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v3252 
            let v3254 : string = "$0.clone()"
            let v3255 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v3229 v3254 
            let v3256 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
            let v3257 : bool = Fable.Core.RustInterop.emitRustExpr v3253 v3256 
            let v3258 : string = "x"
            let v3259 : std_io_Error = Fable.Core.RustInterop.emitRustExpr () v3258 
            let v3260 : std_string_String = null |> unbox<std_string_String>
            let v3261 : string = "true; $0 })"
            let v3262 : bool = Fable.Core.RustInterop.emitRustExpr v3260 v3261 
            let v3263 : string = "_result_map_error__"
            let v3264 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3263 
            let v3265 : (std_string_String -> US35) = method163()
            let v3266 : (std_string_String -> US35) = method164()
            let v3268 : US35 = match v3264 with Ok x -> v3265 x | Error x -> v3266 x
            let v3425 : std_string_String =
                match v3268 with
                | US35_1(v3354) -> (* Error *)
                    let v3355 : bool = TraceState.trace_state.IsNone
                    if v3355 then
                        let v3356 : US0 = US0_0
                        let struct (v3357 : Mut0, v3358 : Mut1, v3359 : Mut2, v3360 : Mut3, v3361 : Mut4, v3362 : int64 option) = method1(v3356)
                        let v3363 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v3357, v3358, v3359, v3360, v3361, v3362) 
                        TraceState.trace_state <- v3363 
                        ()
                    let struct (v3364 : Mut0, v3365 : Mut1, v3366 : Mut2, v3367 : Mut3, v3368 : Mut4, v3369 : int64 option) = TraceState.trace_state.Value
                    let v3370 : US0 = v3368.l0
                    let v3375 : int32 =
                        match v3370 with
                        | US0_4 -> (* Critical *)
                            50
                        | US0_1 -> (* Debug *)
                            20
                        | US0_2 -> (* Info *)
                            30
                        | US0_0 -> (* Verbose *)
                            10
                        | US0_3 -> (* Warning *)
                            40
                    let v3376 : bool = v3366.l0
                    let v3377 : bool = v3376 = false
                    let v3379 : bool =
                        if v3377 then
                            false
                        else
                            let v3378 : bool = 50 >= v3375
                            v3378
                    let v3380 : bool = v3379 = false
                    let v3420 : US7 =
                        if v3380 then
                            US7_1
                        else
                            let v3382 : bool = TraceState.trace_state.IsNone
                            if v3382 then
                                let v3383 : US0 = US0_0
                                let struct (v3384 : Mut0, v3385 : Mut1, v3386 : Mut2, v3387 : Mut3, v3388 : Mut4, v3389 : int64 option) = method1(v3383)
                                let v3390 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v3384, v3385, v3386, v3387, v3388, v3389) 
                                TraceState.trace_state <- v3390 
                                ()
                            let struct (v3391 : Mut0, v3392 : Mut1, v3393 : Mut2, v3394 : Mut3, v3395 : Mut4, v3396 : int64 option) = TraceState.trace_state.Value
                            let v3397 : string = method8(v3391, v3392, v3393, v3394, v3395, v3396)
                            let v3398 : string = method85()
                            let v3399 : string = method165(v3391, v3392, v3393, v3394, v3395, v3396, v3397, v3398, v5, v3354)
                            let v3400 : bool = TraceState.trace_state.IsNone
                            if v3400 then
                                let v3401 : US0 = US0_0
                                let struct (v3402 : Mut0, v3403 : Mut1, v3404 : Mut2, v3405 : Mut3, v3406 : Mut4, v3407 : int64 option) = method1(v3401)
                                let v3408 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v3402, v3403, v3404, v3405, v3406, v3407) 
                                TraceState.trace_state <- v3408 
                                ()
                            let struct (v3409 : Mut0, v3410 : Mut1, v3411 : Mut2, v3412 : Mut3, v3413 : Mut4, v3414 : int64 option) = TraceState.trace_state.Value
                            let v3415 : int64 = v3409.l0
                            let v3416 : int64 = v3415 + 1L
                            v3409.l0 <- v3416
                            let v3417 : (string -> unit) = closure12()
                            v3417 v3399
                            let v3418 : (string -> unit) = v3410.l0
                            v3418 v3399
                            US7_0(v3409, v3410, v3411, v3412, v3413, v3414)
                    let v3421 : string = $"\u001b[4;7m{v3354}\u001b[0m"
                    let v3422 : Ref<Str> = v3421 |> unbox<Ref<Str>>
                    let v3423 : std_string_String = v3422 |> unbox<std_string_String>
                    v3423
                | US35_0(v3269) -> (* Ok *)
                    let v3270 : string = () // backend.backend_switch / record_type_try_find / key: v96 
                    let v3271 : string = "encoding_rs::UTF_8"
                    let v3272 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v3271 
                    let v3273 : string = "$0.encode(&*$1).0"
                    let v3274 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v3272, v3270) v3273 
                    let v3275 : string = "$0.as_ref()"
                    let v3276 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v3274 v3275 
                    let v3277 : string = "std::str::from_utf8($0)"
                    let v3278 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr v3276 v3277 
                    let v3279 : string = "$0.unwrap()"
                    let v3280 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3278 v3279 
                    let v3281 : std_string_String = v3280 |> unbox<std_string_String>
                    let v3282 : string = () // backend.backend_switch / record_type_try_find / key: v96 
                    let v3283 : string = $"> {v3282}"
                    if v5 then
                        let v3284 : bool = TraceState.trace_state.IsNone
                        if v3284 then
                            let v3285 : US0 = US0_0
                            let struct (v3286 : Mut0, v3287 : Mut1, v3288 : Mut2, v3289 : Mut3, v3290 : Mut4, v3291 : int64 option) = method1(v3285)
                            let v3292 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v3286, v3287, v3288, v3289, v3290, v3291) 
                            TraceState.trace_state <- v3292 
                            ()
                        let struct (v3293 : Mut0, v3294 : Mut1, v3295 : Mut2, v3296 : Mut3, v3297 : Mut4, v3298 : int64 option) = TraceState.trace_state.Value
                        let v3299 : US0 = v3297.l0
                        let v3304 : int32 =
                            match v3299 with
                            | US0_4 -> (* Critical *)
                                50
                            | US0_1 -> (* Debug *)
                                20
                            | US0_2 -> (* Info *)
                                30
                            | US0_0 -> (* Verbose *)
                                10
                            | US0_3 -> (* Warning *)
                                40
                        let v3305 : bool = v3295.l0
                        let v3306 : bool = v3305 = false
                        let v3308 : bool =
                            if v3306 then
                                false
                            else
                                let v3307 : bool = 10 >= v3304
                                v3307
                        let v3309 : bool = v3308 = false
                        let v3352 : US7 =
                            if v3309 then
                                US7_1
                            else
                                let v3311 : bool = TraceState.trace_state.IsNone
                                if v3311 then
                                    let v3312 : US0 = US0_0
                                    let struct (v3313 : Mut0, v3314 : Mut1, v3315 : Mut2, v3316 : Mut3, v3317 : Mut4, v3318 : int64 option) = method1(v3312)
                                    let v3319 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v3313, v3314, v3315, v3316, v3317, v3318) 
                                    TraceState.trace_state <- v3319 
                                    ()
                                let struct (v3320 : Mut0, v3321 : Mut1, v3322 : Mut2, v3323 : Mut3, v3324 : Mut4, v3325 : int64 option) = TraceState.trace_state.Value
                                let v3326 : string = method8(v3320, v3321, v3322, v3323, v3324, v3325)
                                let v3327 : string = method168()
                                let v3328 : bool = v3283 = ""
                                let v3331 : string =
                                    if v3328 then
                                        let v3329 : string = ""
                                        v3329
                                    else
                                        method169(v3320, v3321, v3322, v3323, v3324, v3325, v3326, v3327, v3283)
                                let v3332 : bool = TraceState.trace_state.IsNone
                                if v3332 then
                                    let v3333 : US0 = US0_0
                                    let struct (v3334 : Mut0, v3335 : Mut1, v3336 : Mut2, v3337 : Mut3, v3338 : Mut4, v3339 : int64 option) = method1(v3333)
                                    let v3340 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v3334, v3335, v3336, v3337, v3338, v3339) 
                                    TraceState.trace_state <- v3340 
                                    ()
                                let struct (v3341 : Mut0, v3342 : Mut1, v3343 : Mut2, v3344 : Mut3, v3345 : Mut4, v3346 : int64 option) = TraceState.trace_state.Value
                                let v3347 : int64 = v3341.l0
                                let v3348 : int64 = v3347 + 1L
                                v3341.l0 <- v3348
                                let v3349 : (string -> unit) = closure12()
                                v3349 v3331
                                let v3350 : (string -> unit) = v3342.l0
                                v3350 v3331
                                US7_0(v3341, v3342, v3343, v3344, v3345, v3346)
                        ()
                    else
                        let v3353 : (string -> unit) = System.Console.WriteLine
                        v3353 v3283
                    v3281
            let v3426 : string = "$0"
            let v3427 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v3255 v3426 
            let v3428 : string = "v3427.lock()"
            let v3429 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v3428 
            let v3430 : string = "$0.unwrap()"
            let v3431 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v3429 v3430 
            let v3432 : string = "&$0"
            let v3433 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v3431 v3432 
            let v3434 : string = "$0.send($1)"
            let v3435 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v3433, v3425) v3434 
            let v3436 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
            let v3437 : bool = Fable.Core.RustInterop.emitRustExpr v3435 v3436 
            let v3438 : string = "x"
            let v3439 : std_sync_mpsc_SendError<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3438 
            let v3440 : std_string_String = null |> unbox<std_string_String>
            let v3441 : string = "true; $0 })"
            let v3442 : bool = Fable.Core.RustInterop.emitRustExpr v3440 v3441 
            let v3443 : string = "_result_map_error__"
            let v3444 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3443 
            let v3445 : string = "$0"
            let v3446 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v3444 v3445 
            let v3447 : string = "true; $0 }); //"
            let v3448 : bool = Fable.Core.RustInterop.emitRustExpr v3446 v3447 
            let v3449 : string = "_iter_try_for_each.map_err(|x| x.into())"
            let v3450 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v3449 
            let v3451 : Result<unit, string> = method171(v3450)
            () // backend.backend_switch / record_type_try_find / key: v96 
            let v3452 : string = "__spawn"
            let v3453 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v3452 
            let v3454 : string = "true; let __spawn = std::thread::spawn(move || { //"
            let v3455 : bool = Fable.Core.RustInterop.emitRustExpr () v3454 
            let v3456 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v3457 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v3185 v3456 
            let v3458 : string = "std::io::BufReader::new($0)"
            let v3459 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr v3457 v3458 
            let v3460 : string = "std::io::BufRead::lines(v3459)"
            let v3461 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v3460 
            let v3462 : string = "true; let mut v3461 = v3461; let _iter_try_for_each = v3461.try_for_each(|x| { //"
            let v3463 : bool = Fable.Core.RustInterop.emitRustExpr () v3462 
            let v3464 : string = "x"
            let v3465 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v3464 
            let v3466 : bool = v7 = false
            let v3662 : Result<unit, std_string_String> =
                if v3466 then
                    let v3468 : Result<unit, std_string_String> = Ok () 
                    v3468
                else
                    let v3469 : string = "$0.clone()"
                    let v3470 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v3235 v3469 
                    let v3471 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
                    let v3472 : bool = Fable.Core.RustInterop.emitRustExpr v3465 v3471 
                    let v3473 : string = "x"
                    let v3474 : std_io_Error = Fable.Core.RustInterop.emitRustExpr () v3473 
                    let v3475 : std_string_String = null |> unbox<std_string_String>
                    let v3476 : string = "true; $0 })"
                    let v3477 : bool = Fable.Core.RustInterop.emitRustExpr v3475 v3476 
                    let v3478 : string = "_result_map_error__"
                    let v3479 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3478 
                    let v3480 : (std_string_String -> US35) = method163()
                    let v3481 : (std_string_String -> US35) = method164()
                    let v3482 : US35 = match v3479 with Ok x -> v3480 x | Error x -> v3481 x
                    let v3642 : std_string_String =
                        match v3482 with
                        | US35_1(v3571) -> (* Error *)
                            let v3572 : bool = TraceState.trace_state.IsNone
                            if v3572 then
                                let v3573 : US0 = US0_0
                                let struct (v3574 : Mut0, v3575 : Mut1, v3576 : Mut2, v3577 : Mut3, v3578 : Mut4, v3579 : int64 option) = method1(v3573)
                                let v3580 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v3574, v3575, v3576, v3577, v3578, v3579) 
                                TraceState.trace_state <- v3580 
                                ()
                            let struct (v3581 : Mut0, v3582 : Mut1, v3583 : Mut2, v3584 : Mut3, v3585 : Mut4, v3586 : int64 option) = TraceState.trace_state.Value
                            let v3587 : US0 = v3585.l0
                            let v3592 : int32 =
                                match v3587 with
                                | US0_4 -> (* Critical *)
                                    50
                                | US0_1 -> (* Debug *)
                                    20
                                | US0_2 -> (* Info *)
                                    30
                                | US0_0 -> (* Verbose *)
                                    10
                                | US0_3 -> (* Warning *)
                                    40
                            let v3593 : bool = v3583.l0
                            let v3594 : bool = v3593 = false
                            let v3596 : bool =
                                if v3594 then
                                    false
                                else
                                    let v3595 : bool = 50 >= v3592
                                    v3595
                            let v3597 : bool = v3596 = false
                            let v3637 : US7 =
                                if v3597 then
                                    US7_1
                                else
                                    let v3599 : bool = TraceState.trace_state.IsNone
                                    if v3599 then
                                        let v3600 : US0 = US0_0
                                        let struct (v3601 : Mut0, v3602 : Mut1, v3603 : Mut2, v3604 : Mut3, v3605 : Mut4, v3606 : int64 option) = method1(v3600)
                                        let v3607 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v3601, v3602, v3603, v3604, v3605, v3606) 
                                        TraceState.trace_state <- v3607 
                                        ()
                                    let struct (v3608 : Mut0, v3609 : Mut1, v3610 : Mut2, v3611 : Mut3, v3612 : Mut4, v3613 : int64 option) = TraceState.trace_state.Value
                                    let v3614 : string = method8(v3608, v3609, v3610, v3611, v3612, v3613)
                                    let v3615 : string = method85()
                                    let v3616 : string = method165(v3608, v3609, v3610, v3611, v3612, v3613, v3614, v3615, v5, v3571)
                                    let v3617 : bool = TraceState.trace_state.IsNone
                                    if v3617 then
                                        let v3618 : US0 = US0_0
                                        let struct (v3619 : Mut0, v3620 : Mut1, v3621 : Mut2, v3622 : Mut3, v3623 : Mut4, v3624 : int64 option) = method1(v3618)
                                        let v3625 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v3619, v3620, v3621, v3622, v3623, v3624) 
                                        TraceState.trace_state <- v3625 
                                        ()
                                    let struct (v3626 : Mut0, v3627 : Mut1, v3628 : Mut2, v3629 : Mut3, v3630 : Mut4, v3631 : int64 option) = TraceState.trace_state.Value
                                    let v3632 : int64 = v3626.l0
                                    let v3633 : int64 = v3632 + 1L
                                    v3626.l0 <- v3633
                                    let v3634 : (string -> unit) = closure12()
                                    v3634 v3616
                                    let v3635 : (string -> unit) = v3627.l0
                                    v3635 v3616
                                    US7_0(v3626, v3627, v3628, v3629, v3630, v3631)
                            let v3638 : string = $"\u001b[4;7m{v3571}\u001b[0m"
                            let v3639 : Ref<Str> = v3638 |> unbox<Ref<Str>>
                            let v3640 : std_string_String = v3639 |> unbox<std_string_String>
                            v3640
                        | US35_0(v3483) -> (* Ok *)
                            let v3484 : string = () // backend.backend_switch / record_type_try_find / key: v96 
                            let v3485 : string = "encoding_rs::UTF_8"
                            let v3486 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v3485 
                            let v3487 : string = "$0.encode(&*$1).0"
                            let v3488 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v3486, v3484) v3487 
                            let v3489 : string = "$0.as_ref()"
                            let v3490 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v3488 v3489 
                            let v3491 : string = "std::str::from_utf8($0)"
                            let v3492 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr v3490 v3491 
                            let v3493 : string = "$0.unwrap()"
                            let v3494 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3492 v3493 
                            let v3495 : std_string_String = v3494 |> unbox<std_string_String>
                            let v3496 : string = () // backend.backend_switch / record_type_try_find / key: v96 
                            let v3497 : string = $"! {v3496}"
                            if v5 then
                                let v3498 : bool = TraceState.trace_state.IsNone
                                if v3498 then
                                    let v3499 : US0 = US0_0
                                    let struct (v3500 : Mut0, v3501 : Mut1, v3502 : Mut2, v3503 : Mut3, v3504 : Mut4, v3505 : int64 option) = method1(v3499)
                                    let v3506 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v3500, v3501, v3502, v3503, v3504, v3505) 
                                    TraceState.trace_state <- v3506 
                                    ()
                                let struct (v3507 : Mut0, v3508 : Mut1, v3509 : Mut2, v3510 : Mut3, v3511 : Mut4, v3512 : int64 option) = TraceState.trace_state.Value
                                let v3513 : US0 = v3511.l0
                                let v3518 : int32 =
                                    match v3513 with
                                    | US0_4 -> (* Critical *)
                                        50
                                    | US0_1 -> (* Debug *)
                                        20
                                    | US0_2 -> (* Info *)
                                        30
                                    | US0_0 -> (* Verbose *)
                                        10
                                    | US0_3 -> (* Warning *)
                                        40
                                let v3519 : bool = v3509.l0
                                let v3520 : bool = v3519 = false
                                let v3522 : bool =
                                    if v3520 then
                                        false
                                    else
                                        let v3521 : bool = 10 >= v3518
                                        v3521
                                let v3523 : bool = v3522 = false
                                let v3566 : US7 =
                                    if v3523 then
                                        US7_1
                                    else
                                        let v3525 : bool = TraceState.trace_state.IsNone
                                        if v3525 then
                                            let v3526 : US0 = US0_0
                                            let struct (v3527 : Mut0, v3528 : Mut1, v3529 : Mut2, v3530 : Mut3, v3531 : Mut4, v3532 : int64 option) = method1(v3526)
                                            let v3533 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v3527, v3528, v3529, v3530, v3531, v3532) 
                                            TraceState.trace_state <- v3533 
                                            ()
                                        let struct (v3534 : Mut0, v3535 : Mut1, v3536 : Mut2, v3537 : Mut3, v3538 : Mut4, v3539 : int64 option) = TraceState.trace_state.Value
                                        let v3540 : string = method8(v3534, v3535, v3536, v3537, v3538, v3539)
                                        let v3541 : string = method168()
                                        let v3542 : bool = v3497 = ""
                                        let v3545 : string =
                                            if v3542 then
                                                let v3543 : string = ""
                                                v3543
                                            else
                                                method169(v3534, v3535, v3536, v3537, v3538, v3539, v3540, v3541, v3497)
                                        let v3546 : bool = TraceState.trace_state.IsNone
                                        if v3546 then
                                            let v3547 : US0 = US0_0
                                            let struct (v3548 : Mut0, v3549 : Mut1, v3550 : Mut2, v3551 : Mut3, v3552 : Mut4, v3553 : int64 option) = method1(v3547)
                                            let v3554 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v3548, v3549, v3550, v3551, v3552, v3553) 
                                            TraceState.trace_state <- v3554 
                                            ()
                                        let struct (v3555 : Mut0, v3556 : Mut1, v3557 : Mut2, v3558 : Mut3, v3559 : Mut4, v3560 : int64 option) = TraceState.trace_state.Value
                                        let v3561 : int64 = v3555.l0
                                        let v3562 : int64 = v3561 + 1L
                                        v3555.l0 <- v3562
                                        let v3563 : (string -> unit) = closure12()
                                        v3563 v3545
                                        let v3564 : (string -> unit) = v3556.l0
                                        v3564 v3545
                                        US7_0(v3555, v3556, v3557, v3558, v3559, v3560)
                                ()
                            else
                                let v3567 : (string -> unit) = System.Console.WriteLine
                                v3567 v3497
                            let v3568 : string = $"\u001b[4;7m{v3495}\u001b[0m"
                            let v3569 : Ref<Str> = v3568 |> unbox<Ref<Str>>
                            let v3570 : std_string_String = v3569 |> unbox<std_string_String>
                            v3570
                    let v3643 : string = "$0"
                    let v3644 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v3470 v3643 
                    let v3645 : string = "v3644.lock()"
                    let v3646 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v3645 
                    let v3647 : string = "$0.unwrap()"
                    let v3648 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v3646 v3647 
                    let v3649 : string = "&$0"
                    let v3650 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v3648 v3649 
                    let v3651 : string = "$0.send($1)"
                    let v3652 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v3650, v3642) v3651 
                    let v3653 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
                    let v3654 : bool = Fable.Core.RustInterop.emitRustExpr v3652 v3653 
                    let v3655 : string = "x"
                    let v3656 : std_sync_mpsc_SendError<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3655 
                    let v3657 : std_string_String = null |> unbox<std_string_String>
                    let v3658 : string = "true; $0 })"
                    let v3659 : bool = Fable.Core.RustInterop.emitRustExpr v3657 v3658 
                    let v3660 : string = "_result_map_error__"
                    let v3661 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3660 
                    v3661
            let v3663 : string = "$0"
            let v3664 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v3662 v3663 
            let v3665 : string = "true; $0 }); //"
            let v3666 : bool = Fable.Core.RustInterop.emitRustExpr v3664 v3665 
            let v3667 : string = "_iter_try_for_each.map_err(|x| x.into())"
            let v3668 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v3667 
            let v3669 : Result<unit, string> = method171(v3668)
            () // backend.backend_switch / record_type_try_find / key: v96 
            let v3670 : string = "__spawn"
            let v3671 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v3670 
            let v3672 : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US36) = method172()
            let v3673 : US36 option = v4 |> Option.map v3672 
            let v3674 : US36 = US36_1
            let v3675 : US36 = v3673 |> Option.defaultValue v3674 
            match v3675 with
            | US36_1 -> (* None *)
                ()
            | US36_0(v3676) -> (* Some *)
                let v3677 : string = "$0"
                let v3678 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v3220 v3677 
                let v3679 : string = "v3678.lock()"
                let v3680 : Result<std_sync_MutexGuard<std_process_ChildStdin option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin option>>> = Fable.Core.RustInterop.emitRustExpr () v3679 
                let v3681 : string = "$0.unwrap()"
                let v3682 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v3680 v3681 
                let v3683 : string = "$0"
                let v3684 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v3682 v3683 
                let v3685 : string = "true; let mut v3684 = v3684"
                let v3686 : bool = Fable.Core.RustInterop.emitRustExpr () v3685 
                let v3687 : string = "&mut $0"
                let v3688 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v3684 v3687 
                let v3689 : string = "Option::take($0)"
                let v3690 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v3688 v3689 
                let v3691 : string = "true; let _optionm_map_ = $0.map(|x| { //"
                let v3692 : bool = Fable.Core.RustInterop.emitRustExpr v3690 v3691 
                let v3693 : string = "x"
                let v3694 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr () v3693 
                let v3695 : string = "std::sync::Mutex::new(v3694)"
                let v3696 : std_sync_Mutex<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr () v3695 
                let v3697 : string = "std::sync::Arc::new(v3696)"
                let v3698 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr () v3697 
                let v3699 : string = "true; $0 })"
                let v3700 : bool = Fable.Core.RustInterop.emitRustExpr v3698 v3699 
                let v3701 : string = "_optionm_map_"
                let v3702 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> option = Fable.Core.RustInterop.emitRustExpr () v3701 
                let v3703 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US37) = method173()
                let v3704 : US37 option = v3702 |> Option.map v3703 
                let v3705 : US37 = US37_1
                let v3706 : US37 = v3704 |> Option.defaultValue v3705 
                match v3706 with
                | US37_1 -> (* None *)
                    ()
                | US37_0(v3707) -> (* Some *)
                    v3676 v3707
                    let v3708 : string = "$0.lock()"
                    let v3709 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr v3707 v3708 
                    let v3710 : string = "$0.unwrap()"
                    let v3711 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v3709 v3710 
                    let v3712 : std_sync_MutexGuard<std_process_ChildStdin> = method174(v3711)
                    let v3713 : string = "true; let mut v3712 = v3712"
                    let v3714 : bool = Fable.Core.RustInterop.emitRustExpr () v3713 
                    let v3715 : string = "true; std::io::Write::flush(&mut *$0).unwrap()"
                    let v3716 : bool = Fable.Core.RustInterop.emitRustExpr v3712 v3715 
                    ()
            let v3717 : string = "$0.lock()"
            let v3718 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr v3129 v3717 
            let v3719 : string = "$0.unwrap()"
            let v3720 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v3718 v3719 
            let v3721 : string = "$0"
            let v3722 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v3720 v3721 
            let v3723 : string = "true; let mut v3722 = v3722"
            let v3724 : bool = Fable.Core.RustInterop.emitRustExpr () v3723 
            let v3725 : string = "&mut $0"
            let v3726 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v3722 v3725 
            let v3727 : string = "Option::take($0)"
            let v3728 : std_process_Child option = Fable.Core.RustInterop.emitRustExpr v3726 v3727 
            let v3729 : string = "$0.unwrap()"
            let v3730 : std_process_Child = Fable.Core.RustInterop.emitRustExpr v3728 v3729 
            let v3731 : string = "$0.wait_with_output()"
            let v3732 : Result<std_process_Output, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v3730 v3731 
            let v3733 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
            let v3734 : bool = Fable.Core.RustInterop.emitRustExpr v3732 v3733 
            let v3735 : string = "x"
            let v3736 : std_io_Error = Fable.Core.RustInterop.emitRustExpr () v3735 
            let v3737 : std_string_String = null |> unbox<std_string_String>
            let v3738 : string = "true; $0 })"
            let v3739 : bool = Fable.Core.RustInterop.emitRustExpr v3737 v3738 
            let v3740 : string = "_result_map_error__"
            let v3741 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3740 
            let v3742 : Vec<std_thread_JoinHandle<Result<unit, string>>> = () // backend.backend_switch / record_type_try_find / key: v96 
            let v3743 : string = "true; $0.into_iter().for_each(|x| { //"
            let v3744 : bool = Fable.Core.RustInterop.emitRustExpr v3742 v3743 
            let v3745 : string = "x"
            let v3746 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v3745 
            let v3747 : string = "std::thread::JoinHandle::join($0)"
            let v3748 : Result<Result<unit, string>, Box<LifetimeRef<Dyn<LifetimeJoin<core_any_Any, LifetimeRef<StaticLifetime>>>>>> = Fable.Core.RustInterop.emitRustExpr v3746 v3747 
            let v3749 : string = "$0.unwrap()"
            let v3750 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v3748 v3749 
            let v3751 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v3750 v3751 
            let v3752 : string = $"true"
            let v3753 : bool = Fable.Core.RustInterop.emitRustExpr () v3752 
            let v3754 : string = "true; }}); //"
            let v3755 : bool = Fable.Core.RustInterop.emitRustExpr () v3754 
            let v3756 : (std_process_Output -> US38) = method175()
            let v3757 : (std_string_String -> US38) = method176()
            let v3759 : US38 = match v3741 with Ok x -> v3756 x | Error x -> v3757 x
            match v3759 with
            | US38_1(v3832) -> (* Error *)
                let v3833 : bool = TraceState.trace_state.IsNone
                if v3833 then
                    let v3834 : US0 = US0_0
                    let struct (v3835 : Mut0, v3836 : Mut1, v3837 : Mut2, v3838 : Mut3, v3839 : Mut4, v3840 : int64 option) = method1(v3834)
                    let v3841 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v3835, v3836, v3837, v3838, v3839, v3840) 
                    TraceState.trace_state <- v3841 
                    ()
                let struct (v3842 : Mut0, v3843 : Mut1, v3844 : Mut2, v3845 : Mut3, v3846 : Mut4, v3847 : int64 option) = TraceState.trace_state.Value
                let v3848 : US0 = v3846.l0
                let v3853 : int32 =
                    match v3848 with
                    | US0_4 -> (* Critical *)
                        50
                    | US0_1 -> (* Debug *)
                        20
                    | US0_2 -> (* Info *)
                        30
                    | US0_0 -> (* Verbose *)
                        10
                    | US0_3 -> (* Warning *)
                        40
                let v3854 : bool = v3844.l0
                let v3855 : bool = v3854 = false
                let v3857 : bool =
                    if v3855 then
                        false
                    else
                        let v3856 : bool = 50 >= v3853
                        v3856
                let v3858 : bool = v3857 = false
                let v3899 : US7 =
                    if v3858 then
                        US7_1
                    else
                        let v3860 : bool = TraceState.trace_state.IsNone
                        if v3860 then
                            let v3861 : US0 = US0_0
                            let struct (v3862 : Mut0, v3863 : Mut1, v3864 : Mut2, v3865 : Mut3, v3866 : Mut4, v3867 : int64 option) = method1(v3861)
                            let v3868 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v3862, v3863, v3864, v3865, v3866, v3867) 
                            TraceState.trace_state <- v3868 
                            ()
                        let struct (v3869 : Mut0, v3870 : Mut1, v3871 : Mut2, v3872 : Mut3, v3873 : Mut4, v3874 : int64 option) = TraceState.trace_state.Value
                        let v3875 : string = method8(v3869, v3870, v3871, v3872, v3873, v3874)
                        let v3876 : string = method85()
                        let v3877 : string = $"%A{v136}"
                        let v3878 : string = method177(v3869, v3870, v3871, v3872, v3873, v3874, v3875, v3876, v3832, v61, v3877, v0, v1, v2, v3, v4, v5, v6, v7)
                        let v3879 : bool = TraceState.trace_state.IsNone
                        if v3879 then
                            let v3880 : US0 = US0_0
                            let struct (v3881 : Mut0, v3882 : Mut1, v3883 : Mut2, v3884 : Mut3, v3885 : Mut4, v3886 : int64 option) = method1(v3880)
                            let v3887 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v3881, v3882, v3883, v3884, v3885, v3886) 
                            TraceState.trace_state <- v3887 
                            ()
                        let struct (v3888 : Mut0, v3889 : Mut1, v3890 : Mut2, v3891 : Mut3, v3892 : Mut4, v3893 : int64 option) = TraceState.trace_state.Value
                        let v3894 : int64 = v3888.l0
                        let v3895 : int64 = v3894 + 1L
                        v3888.l0 <- v3895
                        let v3896 : (string -> unit) = closure12()
                        v3896 v3878
                        let v3897 : (string -> unit) = v3889.l0
                        v3897 v3878
                        US7_0(v3888, v3889, v3890, v3891, v3892, v3893)
                let v3900 : US8 = US8_0(v3832)
                let v3901 : US34 = US34_1
                struct (-2, v3900, v3901)
            | US38_0(v3760) -> (* Ok *)
                let v3761 : string = "$0.status"
                let v3762 : std_process_ExitStatus = Fable.Core.RustInterop.emitRustExpr v3760 v3761 
                let v3763 : string = "$0.code()"
                let v3764 : int32 option = Fable.Core.RustInterop.emitRustExpr v3762 v3763 
                let v3765 : (int32 -> US39) = method178()
                let v3766 : US39 option = v3764 |> Option.map v3765 
                let v3767 : US39 = US39_1
                let v3768 : US39 = v3766 |> Option.defaultValue v3767 
                match v3768 with
                | US39_1 -> (* None *)
                    let v3821 : string = "runtime.execute_with_options / exit_code=None"
                    let v3822 : Ref<Str> = v3821 |> unbox<Ref<Str>>
                    let v3823 : std_string_String = v3822 |> unbox<std_string_String>
                    let v3824 : US8 = US8_0(v3823)
                    let v3825 : US34 = US34_0(v3241)
                    struct (-1, v3824, v3825)
                | US39_0(v3769) -> (* Some *)
                    let v3770 : string = "$0.stdout"
                    let v3771 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v3760 v3770 
                    let v3772 : Vec<uint8> = method179(v3771)
                    let v3773 : string = "std::string::String::from_utf8($0)"
                    let v3774 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr v3772 v3773 
                    let v3775 : string = "$0.unwrap()"
                    let v3776 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3774 v3775 
                    let v3777 : string = "$0.stderr"
                    let v3778 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v3760 v3777 
                    let v3779 : Vec<uint8> = method179(v3778)
                    let v3780 : string = "std::string::String::from_utf8($0)"
                    let v3781 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr v3779 v3780 
                    let v3782 : string = "$0.unwrap()"
                    let v3783 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3781 v3782 
                    let v3784 : string = () // backend.backend_switch / record_type_try_find / key: v96 
                    let v3785 : int32 = v3784.Length
                    let v3786 : int32 = 0
                    let v3787 : int32 = method23(v3784, v3785, v3786)
                    let v3788 : int32 = v3785 - 1
                    let v3789 : string = v3784.[int v3787..int v3788]
                    let v3790 : int32 = v3789.Length
                    let v3791 : int32 = method180(v3789, v3790)
                    let v3792 : string = v3789.[int 0..int v3791]
                    let v3793 : string = () // backend.backend_switch / record_type_try_find / key: v96 
                    let v3794 : int32 = v3793.Length
                    let v3795 : int32 = 0
                    let v3796 : int32 = method23(v3793, v3794, v3795)
                    let v3797 : int32 = v3794 - 1
                    let v3798 : string = v3793.[int v3796..int v3797]
                    let v3799 : int32 = v3798.Length
                    let v3800 : int32 = method180(v3798, v3799)
                    let v3801 : string = v3798.[int 0..int v3800]
                    let v3802 : int32 = v3792.Length
                    let v3803 : bool = v3802 = 0
                    let v3804 : bool = v3803 = false
                    let v3808 : UH0 =
                        if v3804 then
                            let v3805 : UH0 = UH0_0
                            UH0_1(v3792, v3805)
                        else
                            UH0_0
                    let v3809 : int32 = v3801.Length
                    let v3810 : bool = v3809 = 0
                    let v3811 : bool = v3810 = false
                    let v3813 : UH0 =
                        if v3811 then
                            UH0_1(v3801, v3808)
                        else
                            v3808
                    let v3814 : string = ""
                    let struct (v3815 : string, v3816 : string) = method181(v3813, v3814)
                    let v3817 : Ref<Str> = v3815 |> unbox<Ref<Str>>
                    let v3818 : std_string_String = v3817 |> unbox<std_string_String>
                    let v3819 : US8 = US8_0(v3818)
                    let v3820 : US34 = US34_0(v3241)
                    struct (v3769, v3819, v3820)
    let v3988 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option =
        match v3983 with
        | US34_1 -> (* None *)
            let v3986 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = None
            v3986
        | US34_0(v3984) -> (* Some *)
            let v3985 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = Some v3984 
            v3985
    let v3989 : string = "true; let _optionm_map_ = $0.map(|x| { //"
    let v3990 : bool = Fable.Core.RustInterop.emitRustExpr v3988 v3989 
    let v3991 : string = "x"
    let v3992 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v3991 
    let v3993 : string = "$0.lock()"
    let v3994 : Result<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr v3992 v3993 
    let v3995 : string = "$0.unwrap()"
    let v3996 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v3994 v3995 
    let v3997 : string = "$0.iter()"
    let v3998 : _ = Fable.Core.RustInterop.emitRustExpr v3996 v3997 
    let v3999 : string = "$0.collect::<Vec<_>>()"
    let v4000 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v3998 v3999 
    let v4001 : string = "$0.iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v4002 : ((std_string_String) -> string) = closure82()
    let v4003 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v4000, v4002) v4001 
    let v4004 : (string []) = () // backend.backend_switch / record_type_try_find / key: v96 
    let v4005 : string seq = v4004 |> Seq.ofArray
    let v4006 : string = method182()
    let v4007 : (string -> (string seq -> string)) = String.concat
    let v4008 : (string seq -> string) = v4007 v4006
    let v4009 : string = v4008 v4005
    let v4010 : string = "true; $0 })"
    let v4011 : bool = Fable.Core.RustInterop.emitRustExpr v4009 v4010 
    let v4012 : string = "_optionm_map_"
    let v4013 : string option = Fable.Core.RustInterop.emitRustExpr () v4012 
    let v4014 : (string -> US3) = method4()
    let v4015 : US3 option = v4013 |> Option.map v4014 
    let v4016 : US3 = US3_1
    let v4017 : US3 = v4015 |> Option.defaultValue v4016 
    let v4035 : US40 =
        match v4017 with
        | US3_1 -> (* None *)
            US40_1
        | US3_0(v4018) -> (* Some *)
            let v4019 : int32 = v4018.Length
            let v4020 : int32 = 0
            let v4021 : int32 = method23(v4018, v4019, v4020)
            let v4022 : int32 = v4019 - 1
            let v4023 : string = v4018.[int v4021..int v4022]
            let v4024 : int32 = v4023.Length
            let v4025 : int32 = method180(v4023, v4024)
            let v4026 : string = v4023.[int 0..int v4025]
            let v4027 : int32 = v4026.Length
            let v4028 : bool = v4027 = 0
            let v4031 : US3 =
                if v4028 then
                    US3_1
                else
                    US3_0(v4026)
            US40_0(v4031)
    let v4042 : US3 =
        match v4035 with
        | US40_0(v4036) -> (* Some *)
            match v4036 with
            | US3_0(v4037) -> (* Some *)
                US3_0(v4037)
            | _ ->
                US3_1
        | _ ->
            US3_1
    let v4048 : US3 =
        match v3982 with
        | US8_1 -> (* None *)
            US3_1
        | US8_0(v4043) -> (* Some *)
            let v4044 : string = () // backend.backend_switch / record_type_try_find / key: v96 
            US3_0(v4044)
    let v4052 : string =
        match v4048 with
        | US3_1 -> (* None *)
            let v4050 : string = ""
            v4050
        | US3_0(v4049) -> (* Some *)
            v4049
    let v4055 : string =
        match v4042 with
        | US3_1 -> (* None *)
            v4052
        | US3_0(v4053) -> (* Some *)
            v4053
    let v4056 : bool = TraceState.trace_state.IsNone
    if v4056 then
        let v4057 : US0 = US0_0
        let struct (v4058 : Mut0, v4059 : Mut1, v4060 : Mut2, v4061 : Mut3, v4062 : Mut4, v4063 : int64 option) = method1(v4057)
        let v4064 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v4058, v4059, v4060, v4061, v4062, v4063) 
        TraceState.trace_state <- v4064 
        ()
    let struct (v4065 : Mut0, v4066 : Mut1, v4067 : Mut2, v4068 : Mut3, v4069 : Mut4, v4070 : int64 option) = TraceState.trace_state.Value
    let v4071 : US0 = v4069.l0
    let v4076 : int32 =
        match v4071 with
        | US0_4 -> (* Critical *)
            50
        | US0_1 -> (* Debug *)
            20
        | US0_2 -> (* Info *)
            30
        | US0_0 -> (* Verbose *)
            10
        | US0_3 -> (* Warning *)
            40
    let v4077 : bool = v4067.l0
    let v4078 : bool = v4077 = false
    let v4080 : bool =
        if v4078 then
            false
        else
            let v4079 : bool = 10 >= v4076
            v4079
    let v4081 : bool = v4080 = false
    let v4122 : US7 =
        if v4081 then
            US7_1
        else
            let v4083 : bool = TraceState.trace_state.IsNone
            if v4083 then
                let v4084 : US0 = US0_0
                let struct (v4085 : Mut0, v4086 : Mut1, v4087 : Mut2, v4088 : Mut3, v4089 : Mut4, v4090 : int64 option) = method1(v4084)
                let v4091 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v4085, v4086, v4087, v4088, v4089, v4090) 
                TraceState.trace_state <- v4091 
                ()
            let struct (v4092 : Mut0, v4093 : Mut1, v4094 : Mut2, v4095 : Mut3, v4096 : Mut4, v4097 : int64 option) = TraceState.trace_state.Value
            let v4098 : string = method8(v4092, v4093, v4094, v4095, v4096, v4097)
            let v4099 : string = method168()
            let v4100 : int32 = v4055.Length
            let v4101 : string = method183(v4092, v4093, v4094, v4095, v4096, v4097, v4098, v4099, v61, v3981, v4100)
            let v4102 : bool = TraceState.trace_state.IsNone
            if v4102 then
                let v4103 : US0 = US0_0
                let struct (v4104 : Mut0, v4105 : Mut1, v4106 : Mut2, v4107 : Mut3, v4108 : Mut4, v4109 : int64 option) = method1(v4103)
                let v4110 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v4104, v4105, v4106, v4107, v4108, v4109) 
                TraceState.trace_state <- v4110 
                ()
            let struct (v4111 : Mut0, v4112 : Mut1, v4113 : Mut2, v4114 : Mut3, v4115 : Mut4, v4116 : int64 option) = TraceState.trace_state.Value
            let v4117 : int64 = v4111.l0
            let v4118 : int64 = v4117 + 1L
            v4111.l0 <- v4118
            let v4119 : (string -> unit) = closure12()
            v4119 v4101
            let v4120 : (string -> unit) = v4112.l0
            v4120 v4101
            US7_0(v4111, v4112, v4113, v4114, v4115, v4116)
    let v4123 : (int32 * string) = v3981, v4055 
    v4123 
    )
    |> fun x -> x ()
    ) () )
    |> fun x -> _capture_v3024 <- Some x
    let v4124 : (int32 * string) = match _capture_v3024 with Some x -> x | None -> failwith "base.capture / _capture_v3024=None"
    let (a, b) = v4124 
    let v6274 : int32 = a
    let v6275 : string = b
    struct (v6274, v6275)
and method187 (v0 : string, v1 : string, v2 : string) : struct (string * string) =
    let v3 : string = method56(v1)
    let v4 : string = method35(v2, v3)
    let v5 : string = "."
    let v8 : int32 = v1.LastIndexOf v5 
    let v14 : int32 = v8 - 1
    let v15 : string = v1.[int 0..int v14]
    let v16 : int32 = v4.LastIndexOf v5 
    let v17 : int32 = v16 - 1
    let v18 : string = v4.[int 0..int v17]
    let v19 : string = ".md"
    let v20 : bool = v0.EndsWith (v19, false, null)
    let v21 : bool = v20 = false
    let v24 : string =
        if v21 then
            let v22 : string = $"{v1}.{v0}"
            v22
        else
            let v23 : string = $"{v15}.{v0}"
            v23
    let v27 : string =
        if v21 then
            let v25 : string = $"{v4}.{v0}"
            v25
        else
            let v26 : string = $"{v18}.{v0}"
            v26
    struct (v24, v27)
and closure83 () () : unativeint =
    let v0 : unativeint = 0 |> unativeint 
    v0
and closure84 () (v0 : unativeint) : US42 =
    US42_0(v0)
and closure85 () (v0 : exn) : US42 =
    US42_1(v0)
and method188 () : US42 =
    let v0 : (unit -> unativeint) = closure83()
    let v1 : (unativeint -> US42) = closure84()
    let v2 : ((unit -> exn) -> exn) = closure5()
    let v3 : (exn -> US42) = closure85()
    let v4 : US42 = try v0 () |> v1 with ex -> (fun () -> ex) |> v2 |> v3 
    v4
and closure86 (v0 : unativeint) () : unativeint =
    let v1 : unativeint = v0 |> unativeint 
    v1
and method189 (v0 : unativeint) : US42 =
    let v1 : (unit -> unativeint) = closure86(v0)
    let v2 : (unativeint -> US42) = closure84()
    let v3 : ((unit -> exn) -> exn) = closure5()
    let v4 : (exn -> US42) = closure85()
    let v5 : US42 = try v1 () |> v2 with ex -> (fun () -> ex) |> v3 |> v4 
    v5
and closure87 () (v0 : (uint8)) : string =
    let v1 : uint8 = (v0)
    let v2 : string = "format!(\"{:02x}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : string = "Fsharp"
    let v5 : string = () // backend.backend_switch / record_type_try_find / key: v4 
    v5
and closure89 (v0 : string) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure88 () (v0 : string) : (UH0 -> UH0) =
    closure89(v0)
and method190 () : (string -> (UH0 -> UH0)) =
    closure88()
and method191 () : string =
    let v0 : string = ""
    v0
and method192 (v0 : string, v1 : UH0, v2 : string) : struct (string * string) =
    let struct (v11 : string, v12 : string) =
        match v1 with
        | UH0_1(v3, v4) -> (* Cons *)
            let struct (v5 : string, v6 : string) = method192(v0, v4, v2)
            let v7 : string = v3 + v6 
            let v8 : string = v7 + v5 
            struct (v8, v0)
        | _ ->
            let struct (v9 : string, v10 : string) =
                match v1 with
                | UH0_0 -> (* Nil *)
                    struct (v2, v2)
            struct (v9, v10)
    struct (v11, v12)
and closure90 () (v0 : string) : US44 =
    US44_0(v0)
and method193 () : (string -> US44) =
    closure90()
and closure91 () (v0 : std_io_Error) : US44 =
    US44_1(v0)
and method194 () : (std_io_Error -> US44) =
    closure91()
and closure92 () (v0 : string) : US45 =
    US45_0(v0)
and method195 () : (string -> US45) =
    closure92()
and closure93 () (v0 : std_string_String) : US45 =
    US45_1(v0)
and method196 () : (std_string_String -> US45) =
    closure93()
and method199 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "file"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method200 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "real_path"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method201 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "relative_path"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method202 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "origin_hash_exit_code"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method203 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "origin_hash"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method204 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "local_git_hash_exit_code"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method205 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "local_git_hash"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method206 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "hash1"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method207 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "hash2"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method208 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "dist_path"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method209 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "cache_path"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method198 (v0 : string, v1 : string, v2 : string, v3 : int32, v4 : string, v5 : int32, v6 : string, v7 : string, v8 : US3, v9 : string, v10 : string) : string =
    let v11 : string = method13()
    let v12 : Mut3 = {l0 = v11} : Mut3
    method18(v12)
    method199(v12)
    method20(v12)
    method14(v12, v0)
    method46(v12)
    method200(v12)
    method20(v12)
    method14(v12, v1)
    method46(v12)
    method201(v12)
    method20(v12)
    method14(v12, v2)
    method46(v12)
    method202(v12)
    method20(v12)
    let v105 : string = $"{v3}"
    method14(v12, v105)
    method46(v12)
    method203(v12)
    method20(v12)
    method14(v12, v4)
    method46(v12)
    method204(v12)
    method20(v12)
    let v152 : string = $"{v5}"
    method14(v12, v152)
    method46(v12)
    method205(v12)
    method20(v12)
    method14(v12, v6)
    method46(v12)
    method206(v12)
    method20(v12)
    method14(v12, v7)
    method46(v12)
    method207(v12)
    method20(v12)
    let v222 : string = $"%A{v8}"
    method14(v12, v222)
    method46(v12)
    method208(v12)
    method20(v12)
    method14(v12, v9)
    method46(v12)
    method209(v12)
    method20(v12)
    method14(v12, v10)
    method21(v12)
    let v269 : string = v12.l0
    v269
and method197 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : string, v12 : int32, v13 : string, v14 : int32, v15 : string, v16 : string, v17 : US3, v18 : string, v19 : string) : string =
    let v20 : int64 = v0.l0
    let v21 : string = " "
    let v22 : string = v6 + v21 
    let v23 : string = method16(v20)
    let v24 : string = v22 + v23 
    let v25 : string = v24 + v7 
    let v26 : string = v25 + v21 
    let v27 : string = v26 + v8 
    let v28 : string = " / "
    let v29 : string = v27 + v28 
    let v30 : string = method198(v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19)
    let v31 : string = v29 + v30 
    method22(v31)
and method210 (v0 : string, v1 : string) : unit =
    System.IO.File.Copy (v1, v0, true)
    ()
and method212 (v0 : int32, v1 : Mut6) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method213 (v0 : int32, v1 : Mut7) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method214 (v0 : string) : string =
    v0
and method215 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure96 (v0 : string) (v1 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : unit =
    let v2 : string = "$0"
    let v3 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : string = "v3.lock()"
    let v5 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr () v4 
    let v6 : string = "$0.unwrap()"
    let v7 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = method214(v0)
    let v9 : string = "v8.as_bytes()"
    let v10 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v9 
    let v11 : std_sync_MutexGuard<std_process_ChildStdin> = method215(v7)
    let v12 : string = "true; let mut v11 = v11"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "true; std::io::Write::write_all(&mut *$0, v10).unwrap()"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr v11 v14 
    ()
and method216 (v0 : int32, v1 : Mut8) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method219 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "result_len"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method220 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "output_path"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method218 (v0 : int32, v1 : int32, v2 : string) : string =
    let v3 : string = method13()
    let v4 : Mut3 = {l0 = v3} : Mut3
    method18(v4)
    method185(v4)
    method20(v4)
    let v5 : string = $"{v0}"
    method14(v4, v5)
    method46(v4)
    method219(v4)
    method20(v4)
    let v29 : string = $"{v1}"
    method14(v4, v29)
    method46(v4)
    method220(v4)
    method20(v4)
    method14(v4, v2)
    method21(v4)
    let v53 : string = v4.l0
    v53
and method217 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32, v10 : string) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method16(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v22 : string = "documents.hangul"
    let v23 : string = v17 + v22 
    let v31 : string = " / "
    let v32 : string = v23 + v31 
    let v33 : string = method218(v8, v9, v10)
    let v34 : string = v32 + v33 
    method22(v34)
and method211 (v0 : string, v1 : string, v2 : bool, v3 : string, v4 : string) : US46 =
    let v7 : string = v4 |> System.IO.File.ReadAllText
    let v119 : string = "\n"
    let v120 : (string []) = v7.Split v119 
    let v128 : int32 = v120.Length
    let v129 : (string []) = Array.zeroCreate<string> (v128)
    let v130 : Mut6 = {l0 = 0} : Mut6
    while method212(v128, v130) do
        let v132 : int32 = v130.l0
        let v133 : string = v120.[int v132]
        let v134 : int32 = v133.Length
        let v135 : int32 = 0
        let v136 : int32 = method23(v133, v134, v135)
        let v137 : int32 = v134 - 1
        let v138 : string = v133.[int v136..int v137]
        let v139 : int32 = v138.Length
        let v140 : int32 = method180(v138, v139)
        let v141 : string = v138.[int 0..int v140]
        v129.[int v132] <- v141
        let v142 : int32 = v132 + 1
        v130.l0 <- v142
        ()
    let v143 : int32 = v129.Length
    let v144 : (string []) = Array.zeroCreate<string> (v143)
    let v145 : Mut7 = {l0 = 0; l1 = 0} : Mut7
    while method213(v143, v145) do
        let v147 : int32 = v145.l0
        let v148 : int32 = v145.l1
        let v149 : string = v129.[int v147]
        let v150 : string = ""
        let v151 : bool = v149 <> v150 
        let v153 : int32 =
            if v151 then
                v144.[int v148] <- v149
                let v152 : int32 = v148 + 1
                v152
            else
                v148
        let v154 : int32 = v147 + 1
        v145.l0 <- v154
        v145.l1 <- v153
        ()
    let v155 : int32 = v145.l1
    let v156 : (string []) = Array.zeroCreate<string> (v155)
    let v157 : Mut6 = {l0 = 0} : Mut6
    while method212(v155, v157) do
        let v159 : int32 = v157.l0
        let v160 : string = v144.[int v159]
        v156.[int v159] <- v160
        let v161 : int32 = v159 + 1
        v157.l0 <- v161
        ()
    let v162 : unit = ()
    let _let'_v162 =
        seq {
            for i = 0 to v156.Length - 1 do yield v156.[i]
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v163 : string seq = _let'_v162 
    let v165 : string = method182()
    let v166 : (string -> (string seq -> string)) = String.concat
    let v167 : (string seq -> string) = v166 v165
    let v168 : string = v167 v163
    let v169 : string = $"{v168}

"
    let v174 : string = " the "
    let v175 : bool = v169.Contains v174 
    let v196 : bool =
        if v175 then
            let v187 : string = " and "
            let v188 : bool = v169.Contains v187 
            v188
        else
            false
    let v198 : string =
        if v196 then
            let v197 : string = "eng"
            v197
        else
            v1
    let v199 : System.Threading.CancellationToken option = None
    let v200 : (struct (string * string) []) = [||]
    let v201 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v202 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v203 : string option = None
    let v212 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v213 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v214 : bool = v213 v212
    let v230 : string =
        if v214 then
            let v228 : string = ".exe"
            v228
        else
            let v229 : string = ""
            v229
    let v231 : string = $"../alphabet/deps/hangulize/cmd/hangulize/hangulize{v230}"
    let v232 : string = method35(v0, v231)
    let v233 : string = $"{v232} {v198}"
    let v238 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) = closure96(v169)
    let v239 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = Some v238 
    let v250 : bool = true
    let v251 : bool = true
    let struct (v252 : int32, v253 : string) = method94(v233, v199, v200, v201, v239, v250, v203, v251)
    let v254 : (string []) = v253.Split v119 
    let v255 : int32 = v254.Length
    let v256 : string = ""
    let v257 : Mut8 = {l0 = 0; l1 = v256; l2 = 0; l3 = 0} : Mut8
    while method216(v143, v257) do
        let v259 : int32 = v257.l0
        let struct (v260 : string, v261 : int32, v262 : int32) = v257.l1, v257.l2, v257.l3
        let v263 : string = v129.[int v259]
        let v264 : bool = v263 = ""
        let struct (v295 : string, v296 : int32, v297 : int32) =
            if v264 then
                let v265 : string = v260 + v119 
                let v266 : int32 = v261 + 1
                let v267 : int32 = v262 + 1
                struct (v265, v266, v267)
            else
                let v268 : int32 = v261 - v262
                let v269 : bool = v268 >= v255
                let v293 : string =
                    if v269 then
                        v260
                    else
                        let v270 : string = v254.[int v268]
                        let v275 : string = "://"
                        let v276 : bool = v270.Contains v275 
                        let v284 : string =
                            if v276 then
                                v263
                            else
                                v270
                        let v285 : string = v260 + v284 
                        let v288 : string =
                            if v2 then
                                v285
                            else
                                let v286 : string = v285 + v119 
                                let v287 : string = v286 + v263 
                                v287
                        let v289 : int32 = v255 - 1
                        let v290 : bool = v268 = v289
                        if v290 then
                            v288
                        else
                            let v291 : string = v288 + v119 
                            v291
                let v294 : int32 = v261 + 1
                struct (v293, v294, v262)
        let v298 : int32 = v259 + 1
        v257.l0 <- v298
        v257.l1 <- v295
        v257.l2 <- v296
        v257.l3 <- v297
        ()
    let struct (v299 : string, v300 : int32, v301 : int32) = v257.l1, v257.l2, v257.l3
    System.IO.File.WriteAllText (v3, v299)
    let v303 : bool = TraceState.trace_state.IsNone
    if v303 then
        let v304 : US0 = US0_0
        let struct (v305 : Mut0, v306 : Mut1, v307 : Mut2, v308 : Mut3, v309 : Mut4, v310 : int64 option) = method1(v304)
        let v311 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v305, v306, v307, v308, v309, v310) 
        TraceState.trace_state <- v311 
        ()
    let struct (v312 : Mut0, v313 : Mut1, v314 : Mut2, v315 : Mut3, v316 : Mut4, v317 : int64 option) = TraceState.trace_state.Value
    let v318 : US0 = v316.l0
    let v323 : int32 =
        match v318 with
        | US0_4 -> (* Critical *)
            50
        | US0_1 -> (* Debug *)
            20
        | US0_2 -> (* Info *)
            30
        | US0_0 -> (* Verbose *)
            10
        | US0_3 -> (* Warning *)
            40
    let v324 : bool = v314.l0
    let v325 : bool = v324 = false
    let v327 : bool =
        if v325 then
            false
        else
            let v326 : bool = 30 >= v323
            v326
    let v328 : bool = v327 = false
    let v369 : US7 =
        if v328 then
            US7_1
        else
            let v330 : bool = TraceState.trace_state.IsNone
            if v330 then
                let v331 : US0 = US0_0
                let struct (v332 : Mut0, v333 : Mut1, v334 : Mut2, v335 : Mut3, v336 : Mut4, v337 : int64 option) = method1(v331)
                let v338 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v332, v333, v334, v335, v336, v337) 
                TraceState.trace_state <- v338 
                ()
            let struct (v339 : Mut0, v340 : Mut1, v341 : Mut2, v342 : Mut3, v343 : Mut4, v344 : int64 option) = TraceState.trace_state.Value
            let v345 : string = method8(v339, v340, v341, v342, v343, v344)
            let v346 : string = method11()
            let v347 : int32 = v299.Length
            let v348 : string = method217(v339, v340, v341, v342, v343, v344, v345, v346, v252, v347, v3)
            let v349 : bool = TraceState.trace_state.IsNone
            if v349 then
                let v350 : US0 = US0_0
                let struct (v351 : Mut0, v352 : Mut1, v353 : Mut2, v354 : Mut3, v355 : Mut4, v356 : int64 option) = method1(v350)
                let v357 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v351, v352, v353, v354, v355, v356) 
                TraceState.trace_state <- v357 
                ()
            let struct (v358 : Mut0, v359 : Mut1, v360 : Mut2, v361 : Mut3, v362 : Mut4, v363 : int64 option) = TraceState.trace_state.Value
            let v364 : int64 = v358.l0
            let v365 : int64 = v364 + 1L
            v358.l0 <- v365
            let v366 : (string -> unit) = closure12()
            v366 v348
            let v367 : (string -> unit) = v359.l0
            v367 v348
            US7_0(v358, v359, v360, v361, v362, v363)
    US46_0(v252, v299)
and method223 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "result"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method222 (v0 : int32, v1 : string) : string =
    let v2 : string = method13()
    let v3 : Mut3 = {l0 = v2} : Mut3
    method18(v3)
    method185(v3)
    method20(v3)
    let v4 : string = $"{v0}"
    method14(v3, v4)
    method46(v3)
    method223(v3)
    method20(v3)
    method14(v3, v1)
    method21(v3)
    let v5 : string = v3.l0
    v5
and method221 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method16(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v21 : string = "documents.files_fn / error"
    let v22 : string = v16 + v21 
    let v30 : string = " / "
    let v31 : string = v22 + v30 
    let v32 : string = method222(v8, v9)
    let v33 : string = v31 + v32 
    method22(v33)
and closure95 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : bool, v5 : string) (v6 : string) : US41 =
    let struct (v7 : string, v8 : string) = method187(v6, v5, v0)
    let v9 : bool = method37(v7)
    let v10 : bool = v9 = false
    let v13 : bool =
        if v10 then
            true
        else
            let v11 : bool = method37(v8)
            let v12 : bool = v11 = false
            v12
    let v236 : bool =
        if v13 then
            false
        else
            let v14 : string = method48(v7)
            let v15 : string = "std::fs::File::open(&*v14)"
            let v16 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v15 
            let v17 : string = "$0.unwrap()"
            let v18 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v16 v17 
            let v19 : string = "std::io::BufReader::new($0)"
            let v20 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v18 v19 
            let v21 : string = "std::io::BufReader::new($0)"
            let v22 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v20 v21 
            let v23 : string = "true; let mut v22 = v22"
            let v24 : bool = Fable.Core.RustInterop.emitRustExpr () v23 
            let v25 : string = "true; let result : sha2::Sha256 = sha2::Digest::new()"
            let v26 : bool = Fable.Core.RustInterop.emitRustExpr () v25 
            let v27 : string = "result"
            let v28 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v27 
            let v29 : string = "true; let mut v28 = v28"
            let v30 : bool = Fable.Core.RustInterop.emitRustExpr () v29 
            let v31 : US42 = method188()
            let v37 : US43 =
                match v31 with
                | US42_1(v34) -> (* Error *)
                    US43_1
                | US42_0(v32) -> (* Ok *)
                    US43_0(v32)
            let v41 : unativeint =
                match v37 with
                | US43_1 -> (* None *)
                    failwith<unativeint> "Option does not have a value."
                | US43_0(v38) -> (* Some *)
                    v38
            let v42 : string = "[$0; 1024 as usize]"
            let v43 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v42 
            let v44 : string = "true; loop { // rust.loop 1"
            let v45 : bool = Fable.Core.RustInterop.emitRustExpr () v44 
            let v46 : string = "true; let mut v43 = v43"
            let v47 : bool = Fable.Core.RustInterop.emitRustExpr () v46 
            let v48 : string = "std::io::Read::read(&mut v22, &mut v43)"
            let v49 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v48 
            let v50 : string = "$0.unwrap()"
            let v51 : unativeint = Fable.Core.RustInterop.emitRustExpr v49 v50 
            let v52 : bool = v51 = v41 
            let v55 : bool =
                if v52 then
                    let v53 : string = "true; break ()"
                    let v54 : bool = Fable.Core.RustInterop.emitRustExpr () v53 
                    true
                else
                    false
            let v56 : US42 = method189(v51)
            let v62 : US43 =
                match v56 with
                | US42_1(v59) -> (* Error *)
                    US43_1
                | US42_0(v57) -> (* Ok *)
                    US43_0(v57)
            let v66 : unativeint =
                match v62 with
                | US43_1 -> (* None *)
                    failwith<unativeint> "Option does not have a value."
                | US43_0(v63) -> (* Some *)
                    v63
            let v67 : unativeint = v66 |> unbox<unativeint>
            let v68 : string = "v43.len()"
            let v69 : unativeint = Fable.Core.RustInterop.emitRustExpr () v68 
            let v70 : bool = v67 = v69 
            let v75 : Ref<Slice'<uint8>> =
                if v70 then
                    let v71 : string = "&v43[v41..]"
                    let v72 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v71 
                    v72
                else
                    let v73 : string = "&v43[$0..$1]"
                    let v74 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v41, v66) v73 
                    v74
            let v76 : string = "true; sha2::Digest::update(&mut v28, v75)"
            let v77 : bool = Fable.Core.RustInterop.emitRustExpr () v76 
            let v78 : string = "true; } // rust.loop 3"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr () v78 
            let v80 : string = "&sha2::Digest::finalize(v28)"
            let v81 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v83 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "$0.iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
            let v85 : ((uint8) -> string) = closure87()
            let v86 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v83, v85) v84 
            let v87 : string = "Fsharp"
            let v88 : (string []) = () // backend.backend_switch / record_type_try_find / key: v87 
            let v89 : string list = v88 |> Array.toList
            let v90 : ((string -> (UH0 -> UH0)) -> (string list -> (UH0 -> UH0))) = List.foldBack
            let v91 : (string -> (UH0 -> UH0)) = method190()
            let v92 : (string list -> (UH0 -> UH0)) = v90 v91
            let v93 : (UH0 -> UH0) = v92 v89
            let v94 : UH0 = UH0_0
            let v95 : UH0 = v93 v94
            let v96 : string = method191()
            let v97 : string = ""
            let struct (v98 : string, v99 : string) = method192(v96, v95, v97)
            let v100 : Result<string, std_io_Error> = Ok v98 
            let v101 : (string -> US44) = method193()
            let v102 : (std_io_Error -> US44) = method194()
            let v103 : US44 = match v100 with Ok x -> v101 x | Error x -> v102 x
            let v110 : US45 =
                match v103 with
                | US44_1(v106) -> (* Error *)
                    let v107 : std_string_String = null |> unbox<std_string_String>
                    US45_1(v107)
                | US44_0(v104) -> (* Ok *)
                    US45_0(v104)
            let v116 : Result<string, std_string_String> =
                match v110 with
                | US45_1(v113) -> (* Error *)
                    let v114 : Result<string, std_string_String> = Error v113 
                    v114
                | US45_0(v111) -> (* Ok *)
                    let v112 : Result<string, std_string_String> = Ok v111 
                    v112
            let v117 : (string -> US45) = method195()
            let v118 : (std_string_String -> US45) = method196()
            let v119 : US45 = match v116 with Ok x -> v117 x | Error x -> v118 x
            let v125 : string =
                match v119 with
                | US45_1(v121) -> (* Error *)
                    let v122 : string = $"resultm.get / Error x: {v121}"
                    failwith<string> v122
                | US45_0(v120) -> (* Ok *)
                    v120
            let v126 : string = method48(v8)
            let v127 : string = "std::fs::File::open(&*v126)"
            let v128 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v127 
            let v129 : string = "$0.unwrap()"
            let v130 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v128 v129 
            let v131 : string = "std::io::BufReader::new($0)"
            let v132 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v130 v131 
            let v133 : string = "std::io::BufReader::new($0)"
            let v134 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v132 v133 
            let v135 : string = "true; let mut v134 = v134"
            let v136 : bool = Fable.Core.RustInterop.emitRustExpr () v135 
            let v137 : string = "true; let result : sha2::Sha256 = sha2::Digest::new()"
            let v138 : bool = Fable.Core.RustInterop.emitRustExpr () v137 
            let v139 : string = "result"
            let v140 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v139 
            let v141 : string = "true; let mut v140 = v140"
            let v142 : bool = Fable.Core.RustInterop.emitRustExpr () v141 
            let v143 : US42 = method188()
            let v149 : US43 =
                match v143 with
                | US42_1(v146) -> (* Error *)
                    US43_1
                | US42_0(v144) -> (* Ok *)
                    US43_0(v144)
            let v153 : unativeint =
                match v149 with
                | US43_1 -> (* None *)
                    failwith<unativeint> "Option does not have a value."
                | US43_0(v150) -> (* Some *)
                    v150
            let v154 : string = "[$0; 1024 as usize]"
            let v155 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v154 
            let v156 : string = "true; loop { // rust.loop 1"
            let v157 : bool = Fable.Core.RustInterop.emitRustExpr () v156 
            let v158 : string = "true; let mut v155 = v155"
            let v159 : bool = Fable.Core.RustInterop.emitRustExpr () v158 
            let v160 : string = "std::io::Read::read(&mut v134, &mut v155)"
            let v161 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v160 
            let v162 : string = "$0.unwrap()"
            let v163 : unativeint = Fable.Core.RustInterop.emitRustExpr v161 v162 
            let v164 : bool = v163 = v153 
            let v167 : bool =
                if v164 then
                    let v165 : string = "true; break ()"
                    let v166 : bool = Fable.Core.RustInterop.emitRustExpr () v165 
                    true
                else
                    false
            let v168 : US42 = method189(v163)
            let v174 : US43 =
                match v168 with
                | US42_1(v171) -> (* Error *)
                    US43_1
                | US42_0(v169) -> (* Ok *)
                    US43_0(v169)
            let v178 : unativeint =
                match v174 with
                | US43_1 -> (* None *)
                    failwith<unativeint> "Option does not have a value."
                | US43_0(v175) -> (* Some *)
                    v175
            let v179 : unativeint = v178 |> unbox<unativeint>
            let v180 : string = "v155.len()"
            let v181 : unativeint = Fable.Core.RustInterop.emitRustExpr () v180 
            let v182 : bool = v179 = v181 
            let v187 : Ref<Slice'<uint8>> =
                if v182 then
                    let v183 : string = "&v155[v153..]"
                    let v184 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v183 
                    v184
                else
                    let v185 : string = "&v155[$0..$1]"
                    let v186 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v153, v178) v185 
                    v186
            let v188 : string = "true; sha2::Digest::update(&mut v140, v187)"
            let v189 : bool = Fable.Core.RustInterop.emitRustExpr () v188 
            let v190 : string = "true; } // rust.loop 3"
            let v191 : bool = Fable.Core.RustInterop.emitRustExpr () v190 
            let v192 : string = "&sha2::Digest::finalize(v140)"
            let v193 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v192 
            let v194 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v195 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v193 v194 
            let v196 : string = "$0.iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
            let v197 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v195, v85) v196 
            let v198 : (string []) = () // backend.backend_switch / record_type_try_find / key: v87 
            let v199 : string list = v198 |> Array.toList
            let v200 : ((string -> (UH0 -> UH0)) -> (string list -> (UH0 -> UH0))) = List.foldBack
            let v201 : (string -> (UH0 -> UH0)) = method190()
            let v202 : (string list -> (UH0 -> UH0)) = v200 v201
            let v203 : (UH0 -> UH0) = v202 v199
            let v204 : UH0 = UH0_0
            let v205 : UH0 = v203 v204
            let v206 : string = method191()
            let struct (v207 : string, v208 : string) = method192(v206, v205, v97)
            let v209 : Result<string, std_io_Error> = Ok v207 
            let v210 : (string -> US44) = method193()
            let v211 : (std_io_Error -> US44) = method194()
            let v212 : US44 = match v209 with Ok x -> v210 x | Error x -> v211 x
            let v219 : US45 =
                match v212 with
                | US44_1(v215) -> (* Error *)
                    let v216 : std_string_String = null |> unbox<std_string_String>
                    US45_1(v216)
                | US44_0(v213) -> (* Ok *)
                    US45_0(v213)
            let v225 : Result<string, std_string_String> =
                match v219 with
                | US45_1(v222) -> (* Error *)
                    let v223 : Result<string, std_string_String> = Error v222 
                    v223
                | US45_0(v220) -> (* Ok *)
                    let v221 : Result<string, std_string_String> = Ok v220 
                    v221
            let v226 : (string -> US45) = method195()
            let v227 : (std_string_String -> US45) = method196()
            let v228 : US45 = match v225 with Ok x -> v226 x | Error x -> v227 x
            let v234 : string =
                match v228 with
                | US45_1(v230) -> (* Error *)
                    let v231 : string = $"resultm.get / Error x: {v230}"
                    failwith<string> v231
                | US45_0(v229) -> (* Ok *)
                    v229
            let v235 : bool = v125 = v234
            v235
    if v236 then
        US41_1
    else
        let v238 : US46 = method211(v2, v3, v4, v7, v5)
        match v238 with
        | US46_1(v398, v399) -> (* Error *)
            let v400 : (string * string) = v7, v399 
            let v401 : Result<string, (string * string)> = Error v400 
            US41_0(v401)
        | US46_0(v239, v240) -> (* Ok *)
            let v243 : bool = v239 <> 0 
            if v243 then
                let v251 : bool = TraceState.trace_state.IsNone
                if v251 then
                    let v252 : US0 = US0_0
                    let struct (v253 : Mut0, v254 : Mut1, v255 : Mut2, v256 : Mut3, v257 : Mut4, v258 : int64 option) = method1(v252)
                    let v259 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v253, v254, v255, v256, v257, v258) 
                    TraceState.trace_state <- v259 
                    ()
                let struct (v260 : Mut0, v261 : Mut1, v262 : Mut2, v263 : Mut3, v264 : Mut4, v265 : int64 option) = TraceState.trace_state.Value
                let v266 : US0 = v264.l0
                let v271 : int32 =
                    match v266 with
                    | US0_4 -> (* Critical *)
                        50
                    | US0_1 -> (* Debug *)
                        20
                    | US0_2 -> (* Info *)
                        30
                    | US0_0 -> (* Verbose *)
                        10
                    | US0_3 -> (* Warning *)
                        40
                let v272 : bool = v262.l0
                let v273 : bool = v272 = false
                let v275 : bool =
                    if v273 then
                        false
                    else
                        let v274 : bool = 30 >= v271
                        v274
                let v276 : bool = v275 = false
                let v316 : US7 =
                    if v276 then
                        US7_1
                    else
                        let v278 : bool = TraceState.trace_state.IsNone
                        if v278 then
                            let v279 : US0 = US0_0
                            let struct (v280 : Mut0, v281 : Mut1, v282 : Mut2, v283 : Mut3, v284 : Mut4, v285 : int64 option) = method1(v279)
                            let v286 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v280, v281, v282, v283, v284, v285) 
                            TraceState.trace_state <- v286 
                            ()
                        let struct (v287 : Mut0, v288 : Mut1, v289 : Mut2, v290 : Mut3, v291 : Mut4, v292 : int64 option) = TraceState.trace_state.Value
                        let v293 : string = method8(v287, v288, v289, v290, v291, v292)
                        let v294 : string = method11()
                        let v295 : string = method221(v287, v288, v289, v290, v291, v292, v293, v294, v239, v240)
                        let v296 : bool = TraceState.trace_state.IsNone
                        if v296 then
                            let v297 : US0 = US0_0
                            let struct (v298 : Mut0, v299 : Mut1, v300 : Mut2, v301 : Mut3, v302 : Mut4, v303 : int64 option) = method1(v297)
                            let v304 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v298, v299, v300, v301, v302, v303) 
                            TraceState.trace_state <- v304 
                            ()
                        let struct (v305 : Mut0, v306 : Mut1, v307 : Mut2, v308 : Mut3, v309 : Mut4, v310 : int64 option) = TraceState.trace_state.Value
                        let v311 : int64 = v305.l0
                        let v312 : int64 = v311 + 1L
                        v305.l0 <- v312
                        let v313 : (string -> unit) = closure12()
                        v313 v295
                        let v314 : (string -> unit) = v306.l0
                        v314 v295
                        US7_0(v305, v306, v307, v308, v309, v310)
                let v319 : (string * string) = v7, v240 
                let v353 : Result<string, (string * string)> = Error v319 
                US41_0(v353)
            else
                let v384 : bool = method37(v7)
                if v384 then
                    method210(v8, v7)
                else
                    let v385 : string = $"documents.files_fn / {v7} should exist"
                    failwith<unit> v385
                let v388 : Result<string, (string * string)> = Ok v7 
                US41_0(v388)
and closure94 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : bool) (v5 : string) : (string -> US41) =
    closure95(v0, v1, v2, v3, v4, v5)
and method226 (v0 : int32, v1 : string, v2 : string) : string =
    let v3 : string = method13()
    let v4 : Mut3 = {l0 = v3} : Mut3
    method18(v4)
    method185(v4)
    method20(v4)
    let v5 : string = $"{v0}"
    method14(v4, v5)
    method46(v4)
    method220(v4)
    method20(v4)
    method14(v4, v1)
    method46(v4)
    method223(v4)
    method20(v4)
    method14(v4, v2)
    method21(v4)
    let v6 : string = v4.l0
    v6
and method225 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string, v10 : string) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method16(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v22 : string = "documents.crowbook / attempt error"
    let v23 : string = v17 + v22 
    let v31 : string = " / "
    let v32 : string = v23 + v31 
    let v33 : string = method226(v8, v9, v10)
    let v34 : string = v32 + v33 
    method22(v34)
and method227 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string, v10 : string) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method16(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v22 : string = "documents.crowbook / result contains ERROR"
    let v23 : string = v17 + v22 
    let v31 : string = " / "
    let v32 : string = v23 + v31 
    let v33 : string = method226(v8, v9, v10)
    let v34 : string = v32 + v33 
    method22(v34)
and method224 (v0 : bool, v1 : string, v2 : string, v3 : string, v4 : string) : US46 =
    let v5 : bool = "html" = v4
    let v61 : string =
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
                let v25 : string = $" tex.template.add \"\\pagenumbering{{gobble}}\""
                let v26 : string = v24 + v25 
                let v27 : bool = v0 = false
                let v36 : string =
                    if v27 then
                        let v28 : string = ""
                        v28
                    else
                        let v29 : string = $" tex.template.add \"\\usepackage{{polyglossia}}\""
                        let v30 : string = $" tex.template.add \"\\setmainlanguage{{korean}}\""
                        let v31 : string = v29 + v30 
                        let v32 : string = $" tex.template.add \"\\setmainfont{{NanumGothicCoding}}\""
                        let v33 : string = v31 + v32 
                        let v34 : string = $" tex.font.size 13"
                        let v35 : string = v33 + v34 
                        v35
                let v37 : string = v26 + v36 
                let v38 : string = $" rendering.num_depth 6"
                let v39 : string = $" rendering.highlight.theme \\\"Solarized (dark)\\\""
                let v40 : string = v38 + v39 
                let v41 : string = v37 + v40 
                v41
            else
                let v42 : bool = "epub" = v4
                if v42 then
                    let v43 : string = $"--set"
                    let v44 : string = $" epub.version 3"
                    let v45 : string = v43 + v44 
                    let v46 : string = $" html.css.add \\\"' "
                    let v47 : string = v45 + v46 
                    let v48 : string = $" body {{ color: #e8e6e3; background-color: #202324; }} "
                    let v49 : string = v47 + v48 
                    let v50 : string = $" a {{ color: #989693; }} "
                    let v51 : string = v49 + v50 
                    let v52 : string = $" '\\\""
                    let v53 : string = v51 + v52 
                    let v54 : string = $" rendering.num_depth 6"
                    let v55 : string = $" rendering.highlight.theme \\\"Solarized (dark)\\\""
                    let v56 : string = v54 + v55 
                    let v57 : string = v53 + v56 
                    v57
                else
                    let v58 : string = ""
                    v58
    let v62 : System.Threading.CancellationToken option = None
    let v63 : (struct (string * string) []) = [||]
    let v64 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v65 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v66 : string option = None
    let v67 : string = $"crowbook --verbose --to {v4}"
    let v68 : string = $" --single \"{v2}\" --output \"{v1}\" {v61}"
    let v69 : string = v67 + v68 
    let v70 : string option = Some v3 
    let v71 : bool = true
    let v72 : bool = true
    let struct (v73 : int32, v74 : string) = method94(v69, v62, v63, v64, v65, v71, v70, v72)
    let v75 : bool = v73 = 0
    let struct (v155 : int32, v156 : string) =
        if v75 then
            struct (v73, v74)
        else
            let v76 : bool = TraceState.trace_state.IsNone
            if v76 then
                let v77 : US0 = US0_0
                let struct (v78 : Mut0, v79 : Mut1, v80 : Mut2, v81 : Mut3, v82 : Mut4, v83 : int64 option) = method1(v77)
                let v84 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v78, v79, v80, v81, v82, v83) 
                TraceState.trace_state <- v84 
                ()
            let struct (v85 : Mut0, v86 : Mut1, v87 : Mut2, v88 : Mut3, v89 : Mut4, v90 : int64 option) = TraceState.trace_state.Value
            let v91 : US0 = v89.l0
            let v96 : int32 =
                match v91 with
                | US0_4 -> (* Critical *)
                    50
                | US0_1 -> (* Debug *)
                    20
                | US0_2 -> (* Info *)
                    30
                | US0_0 -> (* Verbose *)
                    10
                | US0_3 -> (* Warning *)
                    40
            let v97 : bool = v87.l0
            let v98 : bool = v97 = false
            let v100 : bool =
                if v98 then
                    false
                else
                    let v99 : bool = 40 >= v96
                    v99
            let v101 : bool = v100 = false
            let v141 : US7 =
                if v101 then
                    US7_1
                else
                    let v103 : bool = TraceState.trace_state.IsNone
                    if v103 then
                        let v104 : US0 = US0_0
                        let struct (v105 : Mut0, v106 : Mut1, v107 : Mut2, v108 : Mut3, v109 : Mut4, v110 : int64 option) = method1(v104)
                        let v111 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v105, v106, v107, v108, v109, v110) 
                        TraceState.trace_state <- v111 
                        ()
                    let struct (v112 : Mut0, v113 : Mut1, v114 : Mut2, v115 : Mut3, v116 : Mut4, v117 : int64 option) = TraceState.trace_state.Value
                    let v118 : string = method8(v112, v113, v114, v115, v116, v117)
                    let v119 : string = method42()
                    let v120 : string = method225(v112, v113, v114, v115, v116, v117, v118, v119, v73, v1, v74)
                    let v121 : bool = TraceState.trace_state.IsNone
                    if v121 then
                        let v122 : US0 = US0_0
                        let struct (v123 : Mut0, v124 : Mut1, v125 : Mut2, v126 : Mut3, v127 : Mut4, v128 : int64 option) = method1(v122)
                        let v129 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v123, v124, v125, v126, v127, v128) 
                        TraceState.trace_state <- v129 
                        ()
                    let struct (v130 : Mut0, v131 : Mut1, v132 : Mut2, v133 : Mut3, v134 : Mut4, v135 : int64 option) = TraceState.trace_state.Value
                    let v136 : int64 = v130.l0
                    let v137 : int64 = v136 + 1L
                    v130.l0 <- v137
                    let v138 : (string -> unit) = closure12()
                    v138 v120
                    let v139 : (string -> unit) = v131.l0
                    v139 v120
                    US7_0(v130, v131, v132, v133, v134, v135)
            let v142 : System.Threading.CancellationToken option = None
            let v143 : (struct (string * string) []) = [||]
            let v144 : (struct (int32 * string * bool) -> Async<unit>) option = None
            let v145 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
            let v146 : string option = None
            let v147 : string = $"crowbook --verbose --to {v4}"
            let v148 : string = $" --single \"{v2}\" --output \"{v1}\""
            let v149 : string = v147 + v148 
            let v150 : string option = Some v3 
            let v151 : bool = true
            let v152 : bool = true
            method94(v149, v142, v143, v144, v145, v151, v150, v152)
    let v161 : string = "ERROR"
    let v162 : bool = v156.Contains v161 
    let v170 : bool = v162 = false
    if v170 then
        US46_0(v155, v156)
    else
        let v172 : bool = TraceState.trace_state.IsNone
        if v172 then
            let v173 : US0 = US0_0
            let struct (v174 : Mut0, v175 : Mut1, v176 : Mut2, v177 : Mut3, v178 : Mut4, v179 : int64 option) = method1(v173)
            let v180 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v174, v175, v176, v177, v178, v179) 
            TraceState.trace_state <- v180 
            ()
        let struct (v181 : Mut0, v182 : Mut1, v183 : Mut2, v184 : Mut3, v185 : Mut4, v186 : int64 option) = TraceState.trace_state.Value
        let v187 : US0 = v185.l0
        let v192 : int32 =
            match v187 with
            | US0_4 -> (* Critical *)
                50
            | US0_1 -> (* Debug *)
                20
            | US0_2 -> (* Info *)
                30
            | US0_0 -> (* Verbose *)
                10
            | US0_3 -> (* Warning *)
                40
        let v193 : bool = v183.l0
        let v194 : bool = v193 = false
        let v196 : bool =
            if v194 then
                false
            else
                let v195 : bool = 40 >= v192
                v195
        let v197 : bool = v196 = false
        let v237 : US7 =
            if v197 then
                US7_1
            else
                let v199 : bool = TraceState.trace_state.IsNone
                if v199 then
                    let v200 : US0 = US0_0
                    let struct (v201 : Mut0, v202 : Mut1, v203 : Mut2, v204 : Mut3, v205 : Mut4, v206 : int64 option) = method1(v200)
                    let v207 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v201, v202, v203, v204, v205, v206) 
                    TraceState.trace_state <- v207 
                    ()
                let struct (v208 : Mut0, v209 : Mut1, v210 : Mut2, v211 : Mut3, v212 : Mut4, v213 : int64 option) = TraceState.trace_state.Value
                let v214 : string = method8(v208, v209, v210, v211, v212, v213)
                let v215 : string = method42()
                let v216 : string = method227(v208, v209, v210, v211, v212, v213, v214, v215, v155, v1, v156)
                let v217 : bool = TraceState.trace_state.IsNone
                if v217 then
                    let v218 : US0 = US0_0
                    let struct (v219 : Mut0, v220 : Mut1, v221 : Mut2, v222 : Mut3, v223 : Mut4, v224 : int64 option) = method1(v218)
                    let v225 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v219, v220, v221, v222, v223, v224) 
                    TraceState.trace_state <- v225 
                    ()
                let struct (v226 : Mut0, v227 : Mut1, v228 : Mut2, v229 : Mut3, v230 : Mut4, v231 : int64 option) = TraceState.trace_state.Value
                let v232 : int64 = v226.l0
                let v233 : int64 = v232 + 1L
                v226.l0 <- v233
                let v234 : (string -> unit) = closure12()
                v234 v216
                let v235 : (string -> unit) = v227.l0
                v235 v216
                US7_0(v226, v227, v228, v229, v230, v231)
        US46_1(v155, v156)
and closure98 (v0 : string, v1 : string, v2 : bool, v3 : string) (v4 : string) : US41 =
    let struct (v5 : string, v6 : string) = method187(v4, v3, v0)
    let v7 : bool = method37(v5)
    let v8 : bool = v7 = false
    let v11 : bool =
        if v8 then
            true
        else
            let v9 : bool = method37(v6)
            let v10 : bool = v9 = false
            v10
    let v234 : bool =
        if v11 then
            false
        else
            let v12 : string = method48(v5)
            let v13 : string = "std::fs::File::open(&*v12)"
            let v14 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v13 
            let v15 : string = "$0.unwrap()"
            let v16 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v14 v15 
            let v17 : string = "std::io::BufReader::new($0)"
            let v18 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v16 v17 
            let v19 : string = "std::io::BufReader::new($0)"
            let v20 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v18 v19 
            let v21 : string = "true; let mut v20 = v20"
            let v22 : bool = Fable.Core.RustInterop.emitRustExpr () v21 
            let v23 : string = "true; let result : sha2::Sha256 = sha2::Digest::new()"
            let v24 : bool = Fable.Core.RustInterop.emitRustExpr () v23 
            let v25 : string = "result"
            let v26 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v25 
            let v27 : string = "true; let mut v26 = v26"
            let v28 : bool = Fable.Core.RustInterop.emitRustExpr () v27 
            let v29 : US42 = method188()
            let v35 : US43 =
                match v29 with
                | US42_1(v32) -> (* Error *)
                    US43_1
                | US42_0(v30) -> (* Ok *)
                    US43_0(v30)
            let v39 : unativeint =
                match v35 with
                | US43_1 -> (* None *)
                    failwith<unativeint> "Option does not have a value."
                | US43_0(v36) -> (* Some *)
                    v36
            let v40 : string = "[$0; 1024 as usize]"
            let v41 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v40 
            let v42 : string = "true; loop { // rust.loop 1"
            let v43 : bool = Fable.Core.RustInterop.emitRustExpr () v42 
            let v44 : string = "true; let mut v41 = v41"
            let v45 : bool = Fable.Core.RustInterop.emitRustExpr () v44 
            let v46 : string = "std::io::Read::read(&mut v20, &mut v41)"
            let v47 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v46 
            let v48 : string = "$0.unwrap()"
            let v49 : unativeint = Fable.Core.RustInterop.emitRustExpr v47 v48 
            let v50 : bool = v49 = v39 
            let v53 : bool =
                if v50 then
                    let v51 : string = "true; break ()"
                    let v52 : bool = Fable.Core.RustInterop.emitRustExpr () v51 
                    true
                else
                    false
            let v54 : US42 = method189(v49)
            let v60 : US43 =
                match v54 with
                | US42_1(v57) -> (* Error *)
                    US43_1
                | US42_0(v55) -> (* Ok *)
                    US43_0(v55)
            let v64 : unativeint =
                match v60 with
                | US43_1 -> (* None *)
                    failwith<unativeint> "Option does not have a value."
                | US43_0(v61) -> (* Some *)
                    v61
            let v65 : unativeint = v64 |> unbox<unativeint>
            let v66 : string = "v41.len()"
            let v67 : unativeint = Fable.Core.RustInterop.emitRustExpr () v66 
            let v68 : bool = v65 = v67 
            let v73 : Ref<Slice'<uint8>> =
                if v68 then
                    let v69 : string = "&v41[v39..]"
                    let v70 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v69 
                    v70
                else
                    let v71 : string = "&v41[$0..$1]"
                    let v72 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v39, v64) v71 
                    v72
            let v74 : string = "true; sha2::Digest::update(&mut v26, v73)"
            let v75 : bool = Fable.Core.RustInterop.emitRustExpr () v74 
            let v76 : string = "true; } // rust.loop 3"
            let v77 : bool = Fable.Core.RustInterop.emitRustExpr () v76 
            let v78 : string = "&sha2::Digest::finalize(v26)"
            let v79 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v78 
            let v80 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v81 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v79 v80 
            let v82 : string = "$0.iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
            let v83 : ((uint8) -> string) = closure87()
            let v84 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v81, v83) v82 
            let v85 : string = "Fsharp"
            let v86 : (string []) = () // backend.backend_switch / record_type_try_find / key: v85 
            let v87 : string list = v86 |> Array.toList
            let v88 : ((string -> (UH0 -> UH0)) -> (string list -> (UH0 -> UH0))) = List.foldBack
            let v89 : (string -> (UH0 -> UH0)) = method190()
            let v90 : (string list -> (UH0 -> UH0)) = v88 v89
            let v91 : (UH0 -> UH0) = v90 v87
            let v92 : UH0 = UH0_0
            let v93 : UH0 = v91 v92
            let v94 : string = method191()
            let v95 : string = ""
            let struct (v96 : string, v97 : string) = method192(v94, v93, v95)
            let v98 : Result<string, std_io_Error> = Ok v96 
            let v99 : (string -> US44) = method193()
            let v100 : (std_io_Error -> US44) = method194()
            let v101 : US44 = match v98 with Ok x -> v99 x | Error x -> v100 x
            let v108 : US45 =
                match v101 with
                | US44_1(v104) -> (* Error *)
                    let v105 : std_string_String = null |> unbox<std_string_String>
                    US45_1(v105)
                | US44_0(v102) -> (* Ok *)
                    US45_0(v102)
            let v114 : Result<string, std_string_String> =
                match v108 with
                | US45_1(v111) -> (* Error *)
                    let v112 : Result<string, std_string_String> = Error v111 
                    v112
                | US45_0(v109) -> (* Ok *)
                    let v110 : Result<string, std_string_String> = Ok v109 
                    v110
            let v115 : (string -> US45) = method195()
            let v116 : (std_string_String -> US45) = method196()
            let v117 : US45 = match v114 with Ok x -> v115 x | Error x -> v116 x
            let v123 : string =
                match v117 with
                | US45_1(v119) -> (* Error *)
                    let v120 : string = $"resultm.get / Error x: {v119}"
                    failwith<string> v120
                | US45_0(v118) -> (* Ok *)
                    v118
            let v124 : string = method48(v6)
            let v125 : string = "std::fs::File::open(&*v124)"
            let v126 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v125 
            let v127 : string = "$0.unwrap()"
            let v128 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v126 v127 
            let v129 : string = "std::io::BufReader::new($0)"
            let v130 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v128 v129 
            let v131 : string = "std::io::BufReader::new($0)"
            let v132 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v130 v131 
            let v133 : string = "true; let mut v132 = v132"
            let v134 : bool = Fable.Core.RustInterop.emitRustExpr () v133 
            let v135 : string = "true; let result : sha2::Sha256 = sha2::Digest::new()"
            let v136 : bool = Fable.Core.RustInterop.emitRustExpr () v135 
            let v137 : string = "result"
            let v138 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v137 
            let v139 : string = "true; let mut v138 = v138"
            let v140 : bool = Fable.Core.RustInterop.emitRustExpr () v139 
            let v141 : US42 = method188()
            let v147 : US43 =
                match v141 with
                | US42_1(v144) -> (* Error *)
                    US43_1
                | US42_0(v142) -> (* Ok *)
                    US43_0(v142)
            let v151 : unativeint =
                match v147 with
                | US43_1 -> (* None *)
                    failwith<unativeint> "Option does not have a value."
                | US43_0(v148) -> (* Some *)
                    v148
            let v152 : string = "[$0; 1024 as usize]"
            let v153 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v152 
            let v154 : string = "true; loop { // rust.loop 1"
            let v155 : bool = Fable.Core.RustInterop.emitRustExpr () v154 
            let v156 : string = "true; let mut v153 = v153"
            let v157 : bool = Fable.Core.RustInterop.emitRustExpr () v156 
            let v158 : string = "std::io::Read::read(&mut v132, &mut v153)"
            let v159 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v158 
            let v160 : string = "$0.unwrap()"
            let v161 : unativeint = Fable.Core.RustInterop.emitRustExpr v159 v160 
            let v162 : bool = v161 = v151 
            let v165 : bool =
                if v162 then
                    let v163 : string = "true; break ()"
                    let v164 : bool = Fable.Core.RustInterop.emitRustExpr () v163 
                    true
                else
                    false
            let v166 : US42 = method189(v161)
            let v172 : US43 =
                match v166 with
                | US42_1(v169) -> (* Error *)
                    US43_1
                | US42_0(v167) -> (* Ok *)
                    US43_0(v167)
            let v176 : unativeint =
                match v172 with
                | US43_1 -> (* None *)
                    failwith<unativeint> "Option does not have a value."
                | US43_0(v173) -> (* Some *)
                    v173
            let v177 : unativeint = v176 |> unbox<unativeint>
            let v178 : string = "v153.len()"
            let v179 : unativeint = Fable.Core.RustInterop.emitRustExpr () v178 
            let v180 : bool = v177 = v179 
            let v185 : Ref<Slice'<uint8>> =
                if v180 then
                    let v181 : string = "&v153[v151..]"
                    let v182 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v181 
                    v182
                else
                    let v183 : string = "&v153[$0..$1]"
                    let v184 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v151, v176) v183 
                    v184
            let v186 : string = "true; sha2::Digest::update(&mut v138, v185)"
            let v187 : bool = Fable.Core.RustInterop.emitRustExpr () v186 
            let v188 : string = "true; } // rust.loop 3"
            let v189 : bool = Fable.Core.RustInterop.emitRustExpr () v188 
            let v190 : string = "&sha2::Digest::finalize(v138)"
            let v191 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v190 
            let v192 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v193 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v191 v192 
            let v194 : string = "$0.iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
            let v195 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v193, v83) v194 
            let v196 : (string []) = () // backend.backend_switch / record_type_try_find / key: v85 
            let v197 : string list = v196 |> Array.toList
            let v198 : ((string -> (UH0 -> UH0)) -> (string list -> (UH0 -> UH0))) = List.foldBack
            let v199 : (string -> (UH0 -> UH0)) = method190()
            let v200 : (string list -> (UH0 -> UH0)) = v198 v199
            let v201 : (UH0 -> UH0) = v200 v197
            let v202 : UH0 = UH0_0
            let v203 : UH0 = v201 v202
            let v204 : string = method191()
            let struct (v205 : string, v206 : string) = method192(v204, v203, v95)
            let v207 : Result<string, std_io_Error> = Ok v205 
            let v208 : (string -> US44) = method193()
            let v209 : (std_io_Error -> US44) = method194()
            let v210 : US44 = match v207 with Ok x -> v208 x | Error x -> v209 x
            let v217 : US45 =
                match v210 with
                | US44_1(v213) -> (* Error *)
                    let v214 : std_string_String = null |> unbox<std_string_String>
                    US45_1(v214)
                | US44_0(v211) -> (* Ok *)
                    US45_0(v211)
            let v223 : Result<string, std_string_String> =
                match v217 with
                | US45_1(v220) -> (* Error *)
                    let v221 : Result<string, std_string_String> = Error v220 
                    v221
                | US45_0(v218) -> (* Ok *)
                    let v219 : Result<string, std_string_String> = Ok v218 
                    v219
            let v224 : (string -> US45) = method195()
            let v225 : (std_string_String -> US45) = method196()
            let v226 : US45 = match v223 with Ok x -> v224 x | Error x -> v225 x
            let v232 : string =
                match v226 with
                | US45_1(v228) -> (* Error *)
                    let v229 : string = $"resultm.get / Error x: {v228}"
                    failwith<string> v229
                | US45_0(v227) -> (* Ok *)
                    v227
            let v233 : bool = v123 = v232
            v233
    if v234 then
        US41_1
    else
        let v236 : US46 = method224(v2, v5, v3, v1, v4)
        match v236 with
        | US46_1(v314, v315) -> (* Error *)
            let v316 : (string * string) = v5, v315 
            let v317 : Result<string, (string * string)> = Error v316 
            US41_0(v317)
        | US46_0(v237, v238) -> (* Ok *)
            let v239 : bool = v237 <> 0 
            if v239 then
                let v240 : bool = TraceState.trace_state.IsNone
                if v240 then
                    let v241 : US0 = US0_0
                    let struct (v242 : Mut0, v243 : Mut1, v244 : Mut2, v245 : Mut3, v246 : Mut4, v247 : int64 option) = method1(v241)
                    let v248 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v242, v243, v244, v245, v246, v247) 
                    TraceState.trace_state <- v248 
                    ()
                let struct (v249 : Mut0, v250 : Mut1, v251 : Mut2, v252 : Mut3, v253 : Mut4, v254 : int64 option) = TraceState.trace_state.Value
                let v255 : US0 = v253.l0
                let v260 : int32 =
                    match v255 with
                    | US0_4 -> (* Critical *)
                        50
                    | US0_1 -> (* Debug *)
                        20
                    | US0_2 -> (* Info *)
                        30
                    | US0_0 -> (* Verbose *)
                        10
                    | US0_3 -> (* Warning *)
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
                let v305 : US7 =
                    if v265 then
                        US7_1
                    else
                        let v267 : bool = TraceState.trace_state.IsNone
                        if v267 then
                            let v268 : US0 = US0_0
                            let struct (v269 : Mut0, v270 : Mut1, v271 : Mut2, v272 : Mut3, v273 : Mut4, v274 : int64 option) = method1(v268)
                            let v275 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v269, v270, v271, v272, v273, v274) 
                            TraceState.trace_state <- v275 
                            ()
                        let struct (v276 : Mut0, v277 : Mut1, v278 : Mut2, v279 : Mut3, v280 : Mut4, v281 : int64 option) = TraceState.trace_state.Value
                        let v282 : string = method8(v276, v277, v278, v279, v280, v281)
                        let v283 : string = method11()
                        let v284 : string = method221(v276, v277, v278, v279, v280, v281, v282, v283, v237, v238)
                        let v285 : bool = TraceState.trace_state.IsNone
                        if v285 then
                            let v286 : US0 = US0_0
                            let struct (v287 : Mut0, v288 : Mut1, v289 : Mut2, v290 : Mut3, v291 : Mut4, v292 : int64 option) = method1(v286)
                            let v293 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v287, v288, v289, v290, v291, v292) 
                            TraceState.trace_state <- v293 
                            ()
                        let struct (v294 : Mut0, v295 : Mut1, v296 : Mut2, v297 : Mut3, v298 : Mut4, v299 : int64 option) = TraceState.trace_state.Value
                        let v300 : int64 = v294.l0
                        let v301 : int64 = v300 + 1L
                        v294.l0 <- v301
                        let v302 : (string -> unit) = closure12()
                        v302 v284
                        let v303 : (string -> unit) = v295.l0
                        v303 v284
                        US7_0(v294, v295, v296, v297, v298, v299)
                let v306 : (string * string) = v5, v238 
                let v307 : Result<string, (string * string)> = Error v306 
                US41_0(v307)
            else
                let v309 : bool = method37(v5)
                if v309 then
                    method210(v6, v5)
                else
                    let v310 : string = $"documents.files_fn / {v5} should exist"
                    failwith<unit> v310
                let v311 : Result<string, (string * string)> = Ok v5 
                US41_0(v311)
and closure97 (v0 : string, v1 : string, v2 : bool) (v3 : string) : (string -> US41) =
    closure98(v0, v1, v2, v3)
and method230 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v2 : string = "output_cache_path"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method229 (v0 : string, v1 : string) : string =
    let v2 : string = method13()
    let v3 : Mut3 = {l0 = v2} : Mut3
    method18(v3)
    method220(v3)
    method20(v3)
    method14(v3, v0)
    method46(v3)
    method230(v3)
    method20(v3)
    method14(v3, v1)
    method21(v3)
    let v27 : string = v3.l0
    v27
and method228 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method16(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v21 : string = "documents.run / par_map / files' = [] / listm.iter"
    let v22 : string = v16 + v21 
    let v30 : string = " / "
    let v31 : string = v22 + v30 
    let v32 : string = method229(v8, v9)
    let v33 : string = v31 + v32 
    method22(v33)
and method231 (v0 : UH1, v1 : UH2 list) : UH2 list =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : UH2 list = method231(v3, v1)
        let v5 : UH2 list = v2 :: v4 
        v5
    | UH1_0 -> (* Nil *)
        v1
and closure100 (v0 : UH2) (v1 : UH1) : UH1 =
    UH1_1(v0, v1)
and closure99 () (v0 : UH2) : (UH1 -> UH1) =
    closure100(v0)
and method232 () : (UH2 -> (UH1 -> UH1)) =
    closure99()
and method234 (v0 : UH2, v1 : struct (string * string * (string -> (string -> US41))) list) : struct (string * string * (string -> (string -> US41))) list =
    match v0 with
    | UH2_1(v2, v3, v4, v5) -> (* Cons *)
        let v6 : struct (string * string * (string -> (string -> US41))) list = method234(v5, v1)
        let v7 : struct (string * string * (string -> (string -> US41))) list = struct (v2, v3, v4) :: v6 
        v7
    | UH2_0 -> (* Nil *)
        v1
and method236 (v0 : Result<string, (string * string)> option) : Result<string, (string * string)> option =
    v0
and method237 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and method235 (v0 : (struct (string * string * (string -> (string -> US41))) []), v1 : int32, v2 : int32, v3 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    let v4 : bool = v2 < v1
    if v4 then
        let v5 : int32 = v2 + 1
        let struct (v12 : string, v13 : string, v14 : (string -> (string -> US41))) = v0.[int v2]
        let v32 : (string -> US41) = v14 v13
        let v33 : US41 = v32 v12
        let v68 : Result<string, (string * string)> option =
            match v33 with
            | US41_1 -> (* None *)
                let v59 : Result<string, (string * string)> option = None
                v59
            | US41_0(v34) -> (* Some *)
                let v37 : Result<string, (string * string)> option = Some v34 
                v37
        let v69 : Result<string, (string * string)> option = method236(v68)
        let v70 : Vec<Result<string, (string * string)> option> = method237(v3)
        let v71 : string = "true; let mut v70 = v70"
        let v72 : bool = Fable.Core.RustInterop.emitRustExpr () v71 
        let v73 : string = "true; v70.push(v69)"
        let v74 : bool = Fable.Core.RustInterop.emitRustExpr () v73 
        let v75 : string = "v70"
        let v76 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr () v75 
        method235(v0, v1, v5, v76)
    else
        v3
and method238 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and method239 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and method233 (v0 : UH1, v1 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v40 : struct (string * string * (string -> (string -> US41))) list = []
        let v41 : struct (string * string * (string -> (string -> US41))) list = method234(v2, v40)
        let v213 : (struct (string * string * (string -> (string -> US41))) list -> (struct (string * string * (string -> (string -> US41))) [])) = List.toArray
        let v214 : (struct (string * string * (string -> (string -> US41))) []) = v213 v41
        let v269 : string = "Fsharp"
        let v270 : Vec<struct (string * string * (string -> (string -> US41)))> = () // backend.backend_switch / record_type_try_find / key: v269 
        let v325 : (struct (string * string * (string -> (string -> US41))) []) = () // backend.backend_switch / record_type_try_find / key: v269 
        let v344 : int32 = (v325.borrow().len() as i32)
        let v345 : int32 = 0
        let v349 : Vec<Result<string, (string * string)> option> = () // backend.backend_switch / record_type_try_find / key: v269 
        let v358 : Vec<Result<string, (string * string)> option> = method235(v325, v344, v345, v349)
        let v380 : (Result<string, (string * string)> option []) = () // backend.backend_switch / record_type_try_find / key: v269 
        let v418 : Vec<Result<string, (string * string)> option> = () // backend.backend_switch / record_type_try_find / key: v269 
        let v419 : Vec<Result<string, (string * string)> option> = method238(v418)
        let v420 : Vec<Result<string, (string * string)> option> = method239(v1)
        let v421 : string = "true; let mut v420 = v420"
        let v422 : bool = Fable.Core.RustInterop.emitRustExpr () v421 
        let v423 : string = "true; v420.extend(v419)"
        let v424 : bool = Fable.Core.RustInterop.emitRustExpr () v423 
        let v425 : string = "v420"
        let v426 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr () v425 
        method233(v3, v426)
    | UH1_0 -> (* Nil *)
        v1
and method240 (v0 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>) : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> =
    v0
and method241 (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> =
    v0
and method91 (v0 : bool, v1 : string, v2 : string, v3 : string, v4 : string, v5 : string, v6 : (string []), v7 : int32, v8 : int32, v9 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> =
    let v10 : bool = v8 < v7
    if v10 then
        let v11 : int32 = v8 + 1
        let v14 : string = v6.[int v8]
        let v22 : string = method66(v14)
        let v23 : Ref<Str> = v22 |> unbox<Ref<Str>>
        let v24 : std_string_String = v23 |> unbox<std_string_String>
        let v25 : std_path_PathBuf = v24 |> unbox<std_path_PathBuf>
        let v26 : std_path_Display = v25 |> unbox<std_path_Display>
        let v27 : std_string_String = null |> unbox<std_string_String>
        let v28 : string = "Fsharp"
        let v29 : string = () // backend.backend_switch / record_type_try_find / key: v28 
        let v30 : string = method92()
        let v33 : string = v29.Replace (v4, v30)
        let v41 : string = "\\"
        let v42 : string = "/"
        let v43 : string = v33.Replace (v41, v42)
        let v44 : string = $".{v43}"
        let v45 : string = method48(v22)
        let v46 : string = method35(v3, v44)
        let v47 : string = method93(v46)
        let v50 : System.Threading.CancellationToken option = None
        let v70 : (struct (string * string) []) = [||]
        let v73 : (struct (int32 * string * bool) -> Async<unit>) option = None
        let v95 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
        let v115 : string option = None
        let v116 : string = $"git ls-tree --format='%%(objectname)' origin/gh-pages \"{v47}\""
        let v117 : string option = Some v3 
        let v118 : bool = true
        let v119 : bool = true
        let struct (v120 : int32, v121 : string) = method94(v116, v50, v70, v73, v95, v118, v117, v119)
        let v122 : string = method35(v4, v44)
        let v123 : string = method93(v122)
        let v124 : System.Threading.CancellationToken option = None
        let v125 : (struct (string * string) []) = [||]
        let v126 : (struct (int32 * string * bool) -> Async<unit>) option = None
        let v127 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
        let v128 : string option = None
        let v129 : string = $"git hash-object \"{v123}\""
        let v130 : string option = Some v4 
        let v131 : bool = true
        let v132 : bool = true
        let struct (v133 : int32, v134 : string) = method94(v129, v124, v125, v126, v127, v131, v130, v132)
        let v135 : string = method35(v5, v44)
        let v136 : string = method93(v135)
        let v137 : string = "hangul.md"
        let struct (v138 : string, v139 : string) = method187(v137, v123, v5)
        let v140 : bool = false
        let v141 : bool = false
        let v142 : bool = false
        let v143 : bool = true
        let v144 : bool = true
        let v145 : bool = true
        let v146 : bool = v121.Contains v134 
        let v1002 : UH1 =
            if v146 then
                UH1_0
            else
                let v148 : string = method48(v123)
                let v149 : string = "std::fs::File::open(&*v148)"
                let v150 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v149 
                let v151 : string = "$0.unwrap()"
                let v152 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v150 v151 
                let v153 : string = "std::io::BufReader::new($0)"
                let v154 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v152 v153 
                let v155 : string = "std::io::BufReader::new($0)"
                let v156 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v154 v155 
                let v157 : string = "true; let mut v156 = v156"
                let v158 : bool = Fable.Core.RustInterop.emitRustExpr () v157 
                let v159 : string = "true; let result : sha2::Sha256 = sha2::Digest::new()"
                let v160 : bool = Fable.Core.RustInterop.emitRustExpr () v159 
                let v161 : string = "result"
                let v162 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v161 
                let v163 : string = "true; let mut v162 = v162"
                let v164 : bool = Fable.Core.RustInterop.emitRustExpr () v163 
                let v181 : US42 = method188()
                let v227 : US43 =
                    match v181 with
                    | US42_1(v224) -> (* Error *)
                        US43_1
                    | US42_0(v222) -> (* Ok *)
                        US43_0(v222)
                let v284 : unativeint =
                    match v227 with
                    | US43_1 -> (* None *)
                        failwith<unativeint> "Option does not have a value."
                    | US43_0(v281) -> (* Some *)
                        v281
                let v285 : string = "[$0; 1024 as usize]"
                let v286 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v285 
                let v287 : string = "true; loop { // rust.loop 1"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr () v287 
                let v289 : string = "true; let mut v286 = v286"
                let v290 : bool = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = "std::io::Read::read(&mut v156, &mut v286)"
                let v292 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v291 
                let v293 : string = "$0.unwrap()"
                let v294 : unativeint = Fable.Core.RustInterop.emitRustExpr v292 v293 
                let v297 : bool = v294 = v284 
                let v307 : bool =
                    if v297 then
                        let v305 : string = "true; break ()"
                        let v306 : bool = Fable.Core.RustInterop.emitRustExpr () v305 
                        true
                    else
                        false
                let v317 : US42 = method189(v294)
                let v334 : US43 =
                    match v317 with
                    | US42_1(v331) -> (* Error *)
                        US43_1
                    | US42_0(v329) -> (* Ok *)
                        US43_0(v329)
                let v369 : unativeint =
                    match v334 with
                    | US43_1 -> (* None *)
                        failwith<unativeint> "Option does not have a value."
                    | US43_0(v366) -> (* Some *)
                        v366
                let v370 : unativeint = v369 |> unbox<unativeint>
                let v377 : string = "v286.len()"
                let v378 : unativeint = Fable.Core.RustInterop.emitRustExpr () v377 
                let v379 : bool = v370 = v378 
                let v384 : Ref<Slice'<uint8>> =
                    if v379 then
                        let v380 : string = "&v286[v284..]"
                        let v381 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v380 
                        v381
                    else
                        let v382 : string = "&v286[$0..$1]"
                        let v383 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v284, v369) v382 
                        v383
                let v385 : string = "true; sha2::Digest::update(&mut v162, v384)"
                let v386 : bool = Fable.Core.RustInterop.emitRustExpr () v385 
                let v387 : string = "true; } // rust.loop 3"
                let v388 : bool = Fable.Core.RustInterop.emitRustExpr () v387 
                let v389 : string = "&sha2::Digest::finalize(v162)"
                let v390 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v389 
                let v391 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
                let v392 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v390 v391 
                let v393 : string = "$0.iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
                let v394 : ((uint8) -> string) = closure87()
                let v395 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v392, v394) v393 
                let v396 : (string []) = () // backend.backend_switch / record_type_try_find / key: v28 
                let v399 : string list = v396 |> Array.toList
                let v495 : ((string -> (UH0 -> UH0)) -> (string list -> (UH0 -> UH0))) = List.foldBack
                let v496 : (string -> (UH0 -> UH0)) = method190()
                let v497 : (string list -> (UH0 -> UH0)) = v495 v496
                let v498 : (UH0 -> UH0) = v497 v399
                let v499 : UH0 = UH0_0
                let v500 : UH0 = v498 v499
                let v522 : string = method191()
                let v523 : string = ""
                let struct (v524 : string, v525 : string) = method192(v522, v500, v523)
                let v528 : Result<string, std_io_Error> = Ok v524 
                let v558 : (string -> US44) = method193()
                let v559 : (std_io_Error -> US44) = method194()
                let v562 : US44 = match v528 with Ok x -> v558 x | Error x -> v559 x
                let v598 : US45 =
                    match v562 with
                    | US44_1(v594) -> (* Error *)
                        let v595 : std_string_String = null |> unbox<std_string_String>
                        US45_1(v595)
                    | US44_0(v592) -> (* Ok *)
                        US45_0(v592)
                let v644 : Result<string, std_string_String> =
                    match v598 with
                    | US45_1(v632) -> (* Error *)
                        let v635 : Result<string, std_string_String> = Error v632 
                        v635
                    | US45_0(v599) -> (* Ok *)
                        let v602 : Result<string, std_string_String> = Ok v599 
                        v602
                let v645 : (string -> US45) = method195()
                let v646 : (std_string_String -> US45) = method196()
                let v649 : US45 = match v644 with Ok x -> v645 x | Error x -> v646 x
                let v693 : string =
                    match v649 with
                    | US45_1(v680) -> (* Error *)
                        let v683 : string = $"resultm.get / Error x: {v680}"
                        failwith<string> v683
                    | US45_0(v679) -> (* Ok *)
                        v679
                let v694 : bool = method37(v136)
                let v695 : bool = v694 = false
                let v806 : US3 =
                    if v695 then
                        US3_1
                    else
                        let v697 : string = method48(v136)
                        let v698 : string = "std::fs::File::open(&*v697)"
                        let v699 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v698 
                        let v700 : string = "$0.unwrap()"
                        let v701 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v699 v700 
                        let v702 : string = "std::io::BufReader::new($0)"
                        let v703 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v701 v702 
                        let v704 : string = "std::io::BufReader::new($0)"
                        let v705 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v703 v704 
                        let v706 : string = "true; let mut v705 = v705"
                        let v707 : bool = Fable.Core.RustInterop.emitRustExpr () v706 
                        let v708 : string = "true; let result : sha2::Sha256 = sha2::Digest::new()"
                        let v709 : bool = Fable.Core.RustInterop.emitRustExpr () v708 
                        let v710 : string = "result"
                        let v711 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v710 
                        let v712 : string = "true; let mut v711 = v711"
                        let v713 : bool = Fable.Core.RustInterop.emitRustExpr () v712 
                        let v714 : US42 = method188()
                        let v720 : US43 =
                            match v714 with
                            | US42_1(v717) -> (* Error *)
                                US43_1
                            | US42_0(v715) -> (* Ok *)
                                US43_0(v715)
                        let v724 : unativeint =
                            match v720 with
                            | US43_1 -> (* None *)
                                failwith<unativeint> "Option does not have a value."
                            | US43_0(v721) -> (* Some *)
                                v721
                        let v725 : string = "[$0; 1024 as usize]"
                        let v726 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v725 
                        let v727 : string = "true; loop { // rust.loop 1"
                        let v728 : bool = Fable.Core.RustInterop.emitRustExpr () v727 
                        let v729 : string = "true; let mut v726 = v726"
                        let v730 : bool = Fable.Core.RustInterop.emitRustExpr () v729 
                        let v731 : string = "std::io::Read::read(&mut v705, &mut v726)"
                        let v732 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v731 
                        let v733 : string = "$0.unwrap()"
                        let v734 : unativeint = Fable.Core.RustInterop.emitRustExpr v732 v733 
                        let v735 : bool = v734 = v724 
                        let v738 : bool =
                            if v735 then
                                let v736 : string = "true; break ()"
                                let v737 : bool = Fable.Core.RustInterop.emitRustExpr () v736 
                                true
                            else
                                false
                        let v739 : US42 = method189(v734)
                        let v745 : US43 =
                            match v739 with
                            | US42_1(v742) -> (* Error *)
                                US43_1
                            | US42_0(v740) -> (* Ok *)
                                US43_0(v740)
                        let v749 : unativeint =
                            match v745 with
                            | US43_1 -> (* None *)
                                failwith<unativeint> "Option does not have a value."
                            | US43_0(v746) -> (* Some *)
                                v746
                        let v750 : unativeint = v749 |> unbox<unativeint>
                        let v751 : string = "v726.len()"
                        let v752 : unativeint = Fable.Core.RustInterop.emitRustExpr () v751 
                        let v753 : bool = v750 = v752 
                        let v758 : Ref<Slice'<uint8>> =
                            if v753 then
                                let v754 : string = "&v726[v724..]"
                                let v755 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v754 
                                v755
                            else
                                let v756 : string = "&v726[$0..$1]"
                                let v757 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v724, v749) v756 
                                v757
                        let v759 : string = "true; sha2::Digest::update(&mut v711, v758)"
                        let v760 : bool = Fable.Core.RustInterop.emitRustExpr () v759 
                        let v761 : string = "true; } // rust.loop 3"
                        let v762 : bool = Fable.Core.RustInterop.emitRustExpr () v761 
                        let v763 : string = "&sha2::Digest::finalize(v711)"
                        let v764 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v763 
                        let v765 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
                        let v766 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v764 v765 
                        let v767 : string = "$0.iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
                        let v768 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v766, v394) v767 
                        let v769 : (string []) = () // backend.backend_switch / record_type_try_find / key: v28 
                        let v770 : string list = v769 |> Array.toList
                        let v771 : ((string -> (UH0 -> UH0)) -> (string list -> (UH0 -> UH0))) = List.foldBack
                        let v772 : (string -> (UH0 -> UH0)) = method190()
                        let v773 : (string list -> (UH0 -> UH0)) = v771 v772
                        let v774 : (UH0 -> UH0) = v773 v770
                        let v775 : UH0 = UH0_0
                        let v776 : UH0 = v774 v775
                        let v777 : string = method191()
                        let struct (v778 : string, v779 : string) = method192(v777, v776, v523)
                        let v780 : Result<string, std_io_Error> = Ok v778 
                        let v781 : (string -> US44) = method193()
                        let v782 : (std_io_Error -> US44) = method194()
                        let v783 : US44 = match v780 with Ok x -> v781 x | Error x -> v782 x
                        let v790 : US45 =
                            match v783 with
                            | US44_1(v786) -> (* Error *)
                                let v787 : std_string_String = null |> unbox<std_string_String>
                                US45_1(v787)
                            | US44_0(v784) -> (* Ok *)
                                US45_0(v784)
                        let v796 : Result<string, std_string_String> =
                            match v790 with
                            | US45_1(v793) -> (* Error *)
                                let v794 : Result<string, std_string_String> = Error v793 
                                v794
                            | US45_0(v791) -> (* Ok *)
                                let v792 : Result<string, std_string_String> = Ok v791 
                                v792
                        let v797 : (string -> US45) = method195()
                        let v798 : (std_string_String -> US45) = method196()
                        let v799 : US45 = match v796 with Ok x -> v797 x | Error x -> v798 x
                        match v799 with
                        | US45_1(v802) -> (* Error *)
                            US3_1
                        | US45_0(v800) -> (* Ok *)
                            US3_0(v800)
                match v806 with
                | US3_0(v807) -> (* Some *)
                    let v808 : bool = v693 = v807
                    if v808 then
                        UH1_0
                    else
                        let v810 : bool = TraceState.trace_state.IsNone
                        if v810 then
                            let v811 : US0 = US0_0
                            let struct (v812 : Mut0, v813 : Mut1, v814 : Mut2, v815 : Mut3, v816 : Mut4, v817 : int64 option) = method1(v811)
                            let v818 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v812, v813, v814, v815, v816, v817) 
                            TraceState.trace_state <- v818 
                            ()
                        let struct (v819 : Mut0, v820 : Mut1, v821 : Mut2, v822 : Mut3, v823 : Mut4, v824 : int64 option) = TraceState.trace_state.Value
                        let v825 : US0 = v823.l0
                        let v830 : int32 =
                            match v825 with
                            | US0_4 -> (* Critical *)
                                50
                            | US0_1 -> (* Debug *)
                                20
                            | US0_2 -> (* Info *)
                                30
                            | US0_0 -> (* Verbose *)
                                10
                            | US0_3 -> (* Warning *)
                                40
                        let v831 : bool = v821.l0
                        let v832 : bool = v831 = false
                        let v834 : bool =
                            if v832 then
                                false
                            else
                                let v833 : bool = 30 >= v830
                                v833
                        let v835 : bool = v834 = false
                        let v882 : US7 =
                            if v835 then
                                US7_1
                            else
                                let v837 : bool = TraceState.trace_state.IsNone
                                if v837 then
                                    let v838 : US0 = US0_0
                                    let struct (v839 : Mut0, v840 : Mut1, v841 : Mut2, v842 : Mut3, v843 : Mut4, v844 : int64 option) = method1(v838)
                                    let v845 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v839, v840, v841, v842, v843, v844) 
                                    TraceState.trace_state <- v845 
                                    ()
                                let struct (v846 : Mut0, v847 : Mut1, v848 : Mut2, v849 : Mut3, v850 : Mut4, v851 : int64 option) = TraceState.trace_state.Value
                                let v852 : string = method8(v846, v847, v848, v849, v850, v851)
                                let v853 : string = method11()
                                let v854 : string = "documents.run / par_map"
                                let v855 : string = " / origin_hash |> sm'.contains local_git_hash |> not"
                                let v856 : string = v854 + v855 
                                let v857 : string = " / Some hash2 when hash1 = hash2"
                                let v858 : string = v856 + v857 
                                let v859 : bool = v858 = ""
                                let v861 : string =
                                    if v859 then
                                        v523
                                    else
                                        method197(v846, v847, v848, v849, v850, v851, v852, v853, v858, v45, v47, v44, v120, v121, v133, v134, v693, v806, v123, v136)
                                let v862 : bool = TraceState.trace_state.IsNone
                                if v862 then
                                    let v863 : US0 = US0_0
                                    let struct (v864 : Mut0, v865 : Mut1, v866 : Mut2, v867 : Mut3, v868 : Mut4, v869 : int64 option) = method1(v863)
                                    let v870 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v864, v865, v866, v867, v868, v869) 
                                    TraceState.trace_state <- v870 
                                    ()
                                let struct (v871 : Mut0, v872 : Mut1, v873 : Mut2, v874 : Mut3, v875 : Mut4, v876 : int64 option) = TraceState.trace_state.Value
                                let v877 : int64 = v871.l0
                                let v878 : int64 = v877 + 1L
                                v871.l0 <- v878
                                let v879 : (string -> unit) = closure12()
                                v879 v861
                                let v880 : (string -> unit) = v872.l0
                                v880 v861
                                US7_0(v871, v872, v873, v874, v875, v876)
                        method210(v136, v123)
                        let v883 : (string -> (string -> US41)) = closure94(v5, v4, v2, v1, v0)
                        let v884 : UH2 = UH2_0
                        let v885 : UH2 = UH2_1(v137, v123, v883, v884)
                        let v886 : string = "html"
                        let v887 : (string -> (string -> US41)) = closure97(v5, v4, v140)
                        let v888 : string = "pdf"
                        let v889 : (string -> (string -> US41)) = closure97(v5, v4, v141)
                        let v890 : string = "epub"
                        let v891 : (string -> (string -> US41)) = closure97(v5, v4, v142)
                        let v892 : (string -> (string -> US41)) = closure97(v5, v4, v143)
                        let v893 : (string -> (string -> US41)) = closure97(v5, v4, v144)
                        let v894 : (string -> (string -> US41)) = closure97(v5, v4, v145)
                        let v895 : UH2 = UH2_0
                        let v896 : UH2 = UH2_1(v890, v138, v894, v895)
                        let v897 : UH2 = UH2_1(v888, v138, v893, v896)
                        let v898 : UH2 = UH2_1(v886, v138, v892, v897)
                        let v899 : UH2 = UH2_1(v890, v123, v891, v898)
                        let v900 : UH2 = UH2_1(v888, v123, v889, v899)
                        let v901 : UH2 = UH2_1(v886, v123, v887, v900)
                        let v902 : UH1 = UH1_0
                        let v903 : UH1 = UH1_1(v901, v902)
                        UH1_1(v885, v903)
                | _ ->
                    let v906 : bool = TraceState.trace_state.IsNone
                    if v906 then
                        let v907 : US0 = US0_0
                        let struct (v908 : Mut0, v909 : Mut1, v910 : Mut2, v911 : Mut3, v912 : Mut4, v913 : int64 option) = method1(v907)
                        let v914 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v908, v909, v910, v911, v912, v913) 
                        TraceState.trace_state <- v914 
                        ()
                    let struct (v915 : Mut0, v916 : Mut1, v917 : Mut2, v918 : Mut3, v919 : Mut4, v920 : int64 option) = TraceState.trace_state.Value
                    let v921 : US0 = v919.l0
                    let v926 : int32 =
                        match v921 with
                        | US0_4 -> (* Critical *)
                            50
                        | US0_1 -> (* Debug *)
                            20
                        | US0_2 -> (* Info *)
                            30
                        | US0_0 -> (* Verbose *)
                            10
                        | US0_3 -> (* Warning *)
                            40
                    let v927 : bool = v917.l0
                    let v928 : bool = v927 = false
                    let v930 : bool =
                        if v928 then
                            false
                        else
                            let v929 : bool = 30 >= v926
                            v929
                    let v931 : bool = v930 = false
                    let v978 : US7 =
                        if v931 then
                            US7_1
                        else
                            let v933 : bool = TraceState.trace_state.IsNone
                            if v933 then
                                let v934 : US0 = US0_0
                                let struct (v935 : Mut0, v936 : Mut1, v937 : Mut2, v938 : Mut3, v939 : Mut4, v940 : int64 option) = method1(v934)
                                let v941 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v935, v936, v937, v938, v939, v940) 
                                TraceState.trace_state <- v941 
                                ()
                            let struct (v942 : Mut0, v943 : Mut1, v944 : Mut2, v945 : Mut3, v946 : Mut4, v947 : int64 option) = TraceState.trace_state.Value
                            let v948 : string = method8(v942, v943, v944, v945, v946, v947)
                            let v949 : string = method11()
                            let v950 : string = "documents.run / par_map"
                            let v951 : string = " / origin_hash |> sm'.contains local_git_hash |> not"
                            let v952 : string = v950 + v951 
                            let v953 : string = " / Some hash2 when hash1 = hash2"
                            let v954 : string = v952 + v953 
                            let v955 : bool = v954 = ""
                            let v957 : string =
                                if v955 then
                                    v523
                                else
                                    method197(v942, v943, v944, v945, v946, v947, v948, v949, v954, v45, v47, v44, v120, v121, v133, v134, v693, v806, v123, v136)
                            let v958 : bool = TraceState.trace_state.IsNone
                            if v958 then
                                let v959 : US0 = US0_0
                                let struct (v960 : Mut0, v961 : Mut1, v962 : Mut2, v963 : Mut3, v964 : Mut4, v965 : int64 option) = method1(v959)
                                let v966 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v960, v961, v962, v963, v964, v965) 
                                TraceState.trace_state <- v966 
                                ()
                            let struct (v967 : Mut0, v968 : Mut1, v969 : Mut2, v970 : Mut3, v971 : Mut4, v972 : int64 option) = TraceState.trace_state.Value
                            let v973 : int64 = v967.l0
                            let v974 : int64 = v973 + 1L
                            v967.l0 <- v974
                            let v975 : (string -> unit) = closure12()
                            v975 v957
                            let v976 : (string -> unit) = v968.l0
                            v976 v957
                            US7_0(v967, v968, v969, v970, v971, v972)
                    method210(v136, v123)
                    let v979 : (string -> (string -> US41)) = closure94(v5, v4, v2, v1, v0)
                    let v980 : UH2 = UH2_0
                    let v981 : UH2 = UH2_1(v137, v123, v979, v980)
                    let v982 : string = "html"
                    let v983 : (string -> (string -> US41)) = closure97(v5, v4, v140)
                    let v984 : string = "pdf"
                    let v985 : (string -> (string -> US41)) = closure97(v5, v4, v141)
                    let v986 : string = "epub"
                    let v987 : (string -> (string -> US41)) = closure97(v5, v4, v142)
                    let v988 : (string -> (string -> US41)) = closure97(v5, v4, v143)
                    let v989 : (string -> (string -> US41)) = closure97(v5, v4, v144)
                    let v990 : (string -> (string -> US41)) = closure97(v5, v4, v145)
                    let v991 : UH2 = UH2_0
                    let v992 : UH2 = UH2_1(v986, v138, v990, v991)
                    let v993 : UH2 = UH2_1(v984, v138, v989, v992)
                    let v994 : UH2 = UH2_1(v982, v138, v988, v993)
                    let v995 : UH2 = UH2_1(v986, v123, v987, v994)
                    let v996 : UH2 = UH2_1(v984, v123, v985, v995)
                    let v997 : UH2 = UH2_1(v982, v123, v983, v996)
                    let v998 : UH1 = UH1_0
                    let v999 : UH1 = UH1_1(v997, v998)
                    UH1_1(v981, v999)
        let v1003 : bool =
            match v1002 with
            | UH1_0 -> (* Nil *)
                true
            | _ ->
                false
        let v1004 : bool = v1003 <> true
        let v1547 : UH1 =
            if v1004 then
                v1002
            else
                let v1005 : string = "epub"
                let struct (v1006 : string, v1007 : string) = method187(v1005, v138, v5)
                let v1008 : bool = method37(v1006)
                let v1078 : bool =
                    if v1008 then
                        true
                    else
                        let v1009 : bool = method37(v1007)
                        let v1010 : bool = v1009 = false
                        if v1010 then
                            true
                        else
                            let v1011 : bool = TraceState.trace_state.IsNone
                            if v1011 then
                                let v1012 : US0 = US0_0
                                let struct (v1013 : Mut0, v1014 : Mut1, v1015 : Mut2, v1016 : Mut3, v1017 : Mut4, v1018 : int64 option) = method1(v1012)
                                let v1019 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1013, v1014, v1015, v1016, v1017, v1018) 
                                TraceState.trace_state <- v1019 
                                ()
                            let struct (v1020 : Mut0, v1021 : Mut1, v1022 : Mut2, v1023 : Mut3, v1024 : Mut4, v1025 : int64 option) = TraceState.trace_state.Value
                            let v1026 : US0 = v1024.l0
                            let v1031 : int32 =
                                match v1026 with
                                | US0_4 -> (* Critical *)
                                    50
                                | US0_1 -> (* Debug *)
                                    20
                                | US0_2 -> (* Info *)
                                    30
                                | US0_0 -> (* Verbose *)
                                    10
                                | US0_3 -> (* Warning *)
                                    40
                            let v1032 : bool = v1022.l0
                            let v1033 : bool = v1032 = false
                            let v1035 : bool =
                                if v1033 then
                                    false
                                else
                                    let v1034 : bool = 30 >= v1031
                                    v1034
                            let v1036 : bool = v1035 = false
                            let v1076 : US7 =
                                if v1036 then
                                    US7_1
                                else
                                    let v1038 : bool = TraceState.trace_state.IsNone
                                    if v1038 then
                                        let v1039 : US0 = US0_0
                                        let struct (v1040 : Mut0, v1041 : Mut1, v1042 : Mut2, v1043 : Mut3, v1044 : Mut4, v1045 : int64 option) = method1(v1039)
                                        let v1046 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1040, v1041, v1042, v1043, v1044, v1045) 
                                        TraceState.trace_state <- v1046 
                                        ()
                                    let struct (v1047 : Mut0, v1048 : Mut1, v1049 : Mut2, v1050 : Mut3, v1051 : Mut4, v1052 : int64 option) = TraceState.trace_state.Value
                                    let v1053 : string = method8(v1047, v1048, v1049, v1050, v1051, v1052)
                                    let v1054 : string = method11()
                                    let v1055 : string = method228(v1047, v1048, v1049, v1050, v1051, v1052, v1053, v1054, v1006, v1007)
                                    let v1056 : bool = TraceState.trace_state.IsNone
                                    if v1056 then
                                        let v1057 : US0 = US0_0
                                        let struct (v1058 : Mut0, v1059 : Mut1, v1060 : Mut2, v1061 : Mut3, v1062 : Mut4, v1063 : int64 option) = method1(v1057)
                                        let v1064 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1058, v1059, v1060, v1061, v1062, v1063) 
                                        TraceState.trace_state <- v1064 
                                        ()
                                    let struct (v1065 : Mut0, v1066 : Mut1, v1067 : Mut2, v1068 : Mut3, v1069 : Mut4, v1070 : int64 option) = TraceState.trace_state.Value
                                    let v1071 : int64 = v1065.l0
                                    let v1072 : int64 = v1071 + 1L
                                    v1065.l0 <- v1072
                                    let v1073 : (string -> unit) = closure12()
                                    v1073 v1055
                                    let v1074 : (string -> unit) = v1066.l0
                                    v1074 v1055
                                    US7_0(v1065, v1066, v1067, v1068, v1069, v1070)
                            method210(v1006, v1007)
                            false
                let v1083 : UH2 =
                    if v1078 then
                        let v1079 : (string -> (string -> US41)) = closure97(v5, v4, v145)
                        let v1080 : UH2 = UH2_0
                        UH2_1(v1005, v138, v1079, v1080)
                    else
                        UH2_0
                let v1084 : string = "pdf"
                let struct (v1085 : string, v1086 : string) = method187(v1084, v138, v5)
                let v1087 : bool = method37(v1085)
                let v1157 : bool =
                    if v1087 then
                        true
                    else
                        let v1088 : bool = method37(v1086)
                        let v1089 : bool = v1088 = false
                        if v1089 then
                            true
                        else
                            let v1090 : bool = TraceState.trace_state.IsNone
                            if v1090 then
                                let v1091 : US0 = US0_0
                                let struct (v1092 : Mut0, v1093 : Mut1, v1094 : Mut2, v1095 : Mut3, v1096 : Mut4, v1097 : int64 option) = method1(v1091)
                                let v1098 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1092, v1093, v1094, v1095, v1096, v1097) 
                                TraceState.trace_state <- v1098 
                                ()
                            let struct (v1099 : Mut0, v1100 : Mut1, v1101 : Mut2, v1102 : Mut3, v1103 : Mut4, v1104 : int64 option) = TraceState.trace_state.Value
                            let v1105 : US0 = v1103.l0
                            let v1110 : int32 =
                                match v1105 with
                                | US0_4 -> (* Critical *)
                                    50
                                | US0_1 -> (* Debug *)
                                    20
                                | US0_2 -> (* Info *)
                                    30
                                | US0_0 -> (* Verbose *)
                                    10
                                | US0_3 -> (* Warning *)
                                    40
                            let v1111 : bool = v1101.l0
                            let v1112 : bool = v1111 = false
                            let v1114 : bool =
                                if v1112 then
                                    false
                                else
                                    let v1113 : bool = 30 >= v1110
                                    v1113
                            let v1115 : bool = v1114 = false
                            let v1155 : US7 =
                                if v1115 then
                                    US7_1
                                else
                                    let v1117 : bool = TraceState.trace_state.IsNone
                                    if v1117 then
                                        let v1118 : US0 = US0_0
                                        let struct (v1119 : Mut0, v1120 : Mut1, v1121 : Mut2, v1122 : Mut3, v1123 : Mut4, v1124 : int64 option) = method1(v1118)
                                        let v1125 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1119, v1120, v1121, v1122, v1123, v1124) 
                                        TraceState.trace_state <- v1125 
                                        ()
                                    let struct (v1126 : Mut0, v1127 : Mut1, v1128 : Mut2, v1129 : Mut3, v1130 : Mut4, v1131 : int64 option) = TraceState.trace_state.Value
                                    let v1132 : string = method8(v1126, v1127, v1128, v1129, v1130, v1131)
                                    let v1133 : string = method11()
                                    let v1134 : string = method228(v1126, v1127, v1128, v1129, v1130, v1131, v1132, v1133, v1085, v1086)
                                    let v1135 : bool = TraceState.trace_state.IsNone
                                    if v1135 then
                                        let v1136 : US0 = US0_0
                                        let struct (v1137 : Mut0, v1138 : Mut1, v1139 : Mut2, v1140 : Mut3, v1141 : Mut4, v1142 : int64 option) = method1(v1136)
                                        let v1143 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1137, v1138, v1139, v1140, v1141, v1142) 
                                        TraceState.trace_state <- v1143 
                                        ()
                                    let struct (v1144 : Mut0, v1145 : Mut1, v1146 : Mut2, v1147 : Mut3, v1148 : Mut4, v1149 : int64 option) = TraceState.trace_state.Value
                                    let v1150 : int64 = v1144.l0
                                    let v1151 : int64 = v1150 + 1L
                                    v1144.l0 <- v1151
                                    let v1152 : (string -> unit) = closure12()
                                    v1152 v1134
                                    let v1153 : (string -> unit) = v1145.l0
                                    v1153 v1134
                                    US7_0(v1144, v1145, v1146, v1147, v1148, v1149)
                            method210(v1085, v1086)
                            false
                let v1160 : UH2 =
                    if v1157 then
                        let v1158 : (string -> (string -> US41)) = closure97(v5, v4, v144)
                        UH2_1(v1084, v138, v1158, v1083)
                    else
                        v1083
                let v1161 : string = "html"
                let struct (v1162 : string, v1163 : string) = method187(v1161, v138, v5)
                let v1164 : bool = method37(v1162)
                let v1234 : bool =
                    if v1164 then
                        true
                    else
                        let v1165 : bool = method37(v1163)
                        let v1166 : bool = v1165 = false
                        if v1166 then
                            true
                        else
                            let v1167 : bool = TraceState.trace_state.IsNone
                            if v1167 then
                                let v1168 : US0 = US0_0
                                let struct (v1169 : Mut0, v1170 : Mut1, v1171 : Mut2, v1172 : Mut3, v1173 : Mut4, v1174 : int64 option) = method1(v1168)
                                let v1175 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1169, v1170, v1171, v1172, v1173, v1174) 
                                TraceState.trace_state <- v1175 
                                ()
                            let struct (v1176 : Mut0, v1177 : Mut1, v1178 : Mut2, v1179 : Mut3, v1180 : Mut4, v1181 : int64 option) = TraceState.trace_state.Value
                            let v1182 : US0 = v1180.l0
                            let v1187 : int32 =
                                match v1182 with
                                | US0_4 -> (* Critical *)
                                    50
                                | US0_1 -> (* Debug *)
                                    20
                                | US0_2 -> (* Info *)
                                    30
                                | US0_0 -> (* Verbose *)
                                    10
                                | US0_3 -> (* Warning *)
                                    40
                            let v1188 : bool = v1178.l0
                            let v1189 : bool = v1188 = false
                            let v1191 : bool =
                                if v1189 then
                                    false
                                else
                                    let v1190 : bool = 30 >= v1187
                                    v1190
                            let v1192 : bool = v1191 = false
                            let v1232 : US7 =
                                if v1192 then
                                    US7_1
                                else
                                    let v1194 : bool = TraceState.trace_state.IsNone
                                    if v1194 then
                                        let v1195 : US0 = US0_0
                                        let struct (v1196 : Mut0, v1197 : Mut1, v1198 : Mut2, v1199 : Mut3, v1200 : Mut4, v1201 : int64 option) = method1(v1195)
                                        let v1202 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1196, v1197, v1198, v1199, v1200, v1201) 
                                        TraceState.trace_state <- v1202 
                                        ()
                                    let struct (v1203 : Mut0, v1204 : Mut1, v1205 : Mut2, v1206 : Mut3, v1207 : Mut4, v1208 : int64 option) = TraceState.trace_state.Value
                                    let v1209 : string = method8(v1203, v1204, v1205, v1206, v1207, v1208)
                                    let v1210 : string = method11()
                                    let v1211 : string = method228(v1203, v1204, v1205, v1206, v1207, v1208, v1209, v1210, v1162, v1163)
                                    let v1212 : bool = TraceState.trace_state.IsNone
                                    if v1212 then
                                        let v1213 : US0 = US0_0
                                        let struct (v1214 : Mut0, v1215 : Mut1, v1216 : Mut2, v1217 : Mut3, v1218 : Mut4, v1219 : int64 option) = method1(v1213)
                                        let v1220 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1214, v1215, v1216, v1217, v1218, v1219) 
                                        TraceState.trace_state <- v1220 
                                        ()
                                    let struct (v1221 : Mut0, v1222 : Mut1, v1223 : Mut2, v1224 : Mut3, v1225 : Mut4, v1226 : int64 option) = TraceState.trace_state.Value
                                    let v1227 : int64 = v1221.l0
                                    let v1228 : int64 = v1227 + 1L
                                    v1221.l0 <- v1228
                                    let v1229 : (string -> unit) = closure12()
                                    v1229 v1211
                                    let v1230 : (string -> unit) = v1222.l0
                                    v1230 v1211
                                    US7_0(v1221, v1222, v1223, v1224, v1225, v1226)
                            method210(v1162, v1163)
                            false
                let v1237 : UH2 =
                    if v1234 then
                        let v1235 : (string -> (string -> US41)) = closure97(v5, v4, v143)
                        UH2_1(v1161, v138, v1235, v1160)
                    else
                        v1160
                let struct (v1238 : string, v1239 : string) = method187(v1005, v123, v5)
                let v1240 : bool = method37(v1238)
                let v1310 : bool =
                    if v1240 then
                        true
                    else
                        let v1241 : bool = method37(v1239)
                        let v1242 : bool = v1241 = false
                        if v1242 then
                            true
                        else
                            let v1243 : bool = TraceState.trace_state.IsNone
                            if v1243 then
                                let v1244 : US0 = US0_0
                                let struct (v1245 : Mut0, v1246 : Mut1, v1247 : Mut2, v1248 : Mut3, v1249 : Mut4, v1250 : int64 option) = method1(v1244)
                                let v1251 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1245, v1246, v1247, v1248, v1249, v1250) 
                                TraceState.trace_state <- v1251 
                                ()
                            let struct (v1252 : Mut0, v1253 : Mut1, v1254 : Mut2, v1255 : Mut3, v1256 : Mut4, v1257 : int64 option) = TraceState.trace_state.Value
                            let v1258 : US0 = v1256.l0
                            let v1263 : int32 =
                                match v1258 with
                                | US0_4 -> (* Critical *)
                                    50
                                | US0_1 -> (* Debug *)
                                    20
                                | US0_2 -> (* Info *)
                                    30
                                | US0_0 -> (* Verbose *)
                                    10
                                | US0_3 -> (* Warning *)
                                    40
                            let v1264 : bool = v1254.l0
                            let v1265 : bool = v1264 = false
                            let v1267 : bool =
                                if v1265 then
                                    false
                                else
                                    let v1266 : bool = 30 >= v1263
                                    v1266
                            let v1268 : bool = v1267 = false
                            let v1308 : US7 =
                                if v1268 then
                                    US7_1
                                else
                                    let v1270 : bool = TraceState.trace_state.IsNone
                                    if v1270 then
                                        let v1271 : US0 = US0_0
                                        let struct (v1272 : Mut0, v1273 : Mut1, v1274 : Mut2, v1275 : Mut3, v1276 : Mut4, v1277 : int64 option) = method1(v1271)
                                        let v1278 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1272, v1273, v1274, v1275, v1276, v1277) 
                                        TraceState.trace_state <- v1278 
                                        ()
                                    let struct (v1279 : Mut0, v1280 : Mut1, v1281 : Mut2, v1282 : Mut3, v1283 : Mut4, v1284 : int64 option) = TraceState.trace_state.Value
                                    let v1285 : string = method8(v1279, v1280, v1281, v1282, v1283, v1284)
                                    let v1286 : string = method11()
                                    let v1287 : string = method228(v1279, v1280, v1281, v1282, v1283, v1284, v1285, v1286, v1238, v1239)
                                    let v1288 : bool = TraceState.trace_state.IsNone
                                    if v1288 then
                                        let v1289 : US0 = US0_0
                                        let struct (v1290 : Mut0, v1291 : Mut1, v1292 : Mut2, v1293 : Mut3, v1294 : Mut4, v1295 : int64 option) = method1(v1289)
                                        let v1296 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1290, v1291, v1292, v1293, v1294, v1295) 
                                        TraceState.trace_state <- v1296 
                                        ()
                                    let struct (v1297 : Mut0, v1298 : Mut1, v1299 : Mut2, v1300 : Mut3, v1301 : Mut4, v1302 : int64 option) = TraceState.trace_state.Value
                                    let v1303 : int64 = v1297.l0
                                    let v1304 : int64 = v1303 + 1L
                                    v1297.l0 <- v1304
                                    let v1305 : (string -> unit) = closure12()
                                    v1305 v1287
                                    let v1306 : (string -> unit) = v1298.l0
                                    v1306 v1287
                                    US7_0(v1297, v1298, v1299, v1300, v1301, v1302)
                            method210(v1238, v1239)
                            false
                let v1313 : UH2 =
                    if v1310 then
                        let v1311 : (string -> (string -> US41)) = closure97(v5, v4, v142)
                        UH2_1(v1005, v123, v1311, v1237)
                    else
                        v1237
                let struct (v1314 : string, v1315 : string) = method187(v1084, v123, v5)
                let v1316 : bool = method37(v1314)
                let v1386 : bool =
                    if v1316 then
                        true
                    else
                        let v1317 : bool = method37(v1315)
                        let v1318 : bool = v1317 = false
                        if v1318 then
                            true
                        else
                            let v1319 : bool = TraceState.trace_state.IsNone
                            if v1319 then
                                let v1320 : US0 = US0_0
                                let struct (v1321 : Mut0, v1322 : Mut1, v1323 : Mut2, v1324 : Mut3, v1325 : Mut4, v1326 : int64 option) = method1(v1320)
                                let v1327 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1321, v1322, v1323, v1324, v1325, v1326) 
                                TraceState.trace_state <- v1327 
                                ()
                            let struct (v1328 : Mut0, v1329 : Mut1, v1330 : Mut2, v1331 : Mut3, v1332 : Mut4, v1333 : int64 option) = TraceState.trace_state.Value
                            let v1334 : US0 = v1332.l0
                            let v1339 : int32 =
                                match v1334 with
                                | US0_4 -> (* Critical *)
                                    50
                                | US0_1 -> (* Debug *)
                                    20
                                | US0_2 -> (* Info *)
                                    30
                                | US0_0 -> (* Verbose *)
                                    10
                                | US0_3 -> (* Warning *)
                                    40
                            let v1340 : bool = v1330.l0
                            let v1341 : bool = v1340 = false
                            let v1343 : bool =
                                if v1341 then
                                    false
                                else
                                    let v1342 : bool = 30 >= v1339
                                    v1342
                            let v1344 : bool = v1343 = false
                            let v1384 : US7 =
                                if v1344 then
                                    US7_1
                                else
                                    let v1346 : bool = TraceState.trace_state.IsNone
                                    if v1346 then
                                        let v1347 : US0 = US0_0
                                        let struct (v1348 : Mut0, v1349 : Mut1, v1350 : Mut2, v1351 : Mut3, v1352 : Mut4, v1353 : int64 option) = method1(v1347)
                                        let v1354 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1348, v1349, v1350, v1351, v1352, v1353) 
                                        TraceState.trace_state <- v1354 
                                        ()
                                    let struct (v1355 : Mut0, v1356 : Mut1, v1357 : Mut2, v1358 : Mut3, v1359 : Mut4, v1360 : int64 option) = TraceState.trace_state.Value
                                    let v1361 : string = method8(v1355, v1356, v1357, v1358, v1359, v1360)
                                    let v1362 : string = method11()
                                    let v1363 : string = method228(v1355, v1356, v1357, v1358, v1359, v1360, v1361, v1362, v1314, v1315)
                                    let v1364 : bool = TraceState.trace_state.IsNone
                                    if v1364 then
                                        let v1365 : US0 = US0_0
                                        let struct (v1366 : Mut0, v1367 : Mut1, v1368 : Mut2, v1369 : Mut3, v1370 : Mut4, v1371 : int64 option) = method1(v1365)
                                        let v1372 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1366, v1367, v1368, v1369, v1370, v1371) 
                                        TraceState.trace_state <- v1372 
                                        ()
                                    let struct (v1373 : Mut0, v1374 : Mut1, v1375 : Mut2, v1376 : Mut3, v1377 : Mut4, v1378 : int64 option) = TraceState.trace_state.Value
                                    let v1379 : int64 = v1373.l0
                                    let v1380 : int64 = v1379 + 1L
                                    v1373.l0 <- v1380
                                    let v1381 : (string -> unit) = closure12()
                                    v1381 v1363
                                    let v1382 : (string -> unit) = v1374.l0
                                    v1382 v1363
                                    US7_0(v1373, v1374, v1375, v1376, v1377, v1378)
                            method210(v1314, v1315)
                            false
                let v1389 : UH2 =
                    if v1386 then
                        let v1387 : (string -> (string -> US41)) = closure97(v5, v4, v141)
                        UH2_1(v1084, v123, v1387, v1313)
                    else
                        v1313
                let struct (v1390 : string, v1391 : string) = method187(v1161, v123, v5)
                let v1392 : bool = method37(v1390)
                let v1462 : bool =
                    if v1392 then
                        true
                    else
                        let v1393 : bool = method37(v1391)
                        let v1394 : bool = v1393 = false
                        if v1394 then
                            true
                        else
                            let v1395 : bool = TraceState.trace_state.IsNone
                            if v1395 then
                                let v1396 : US0 = US0_0
                                let struct (v1397 : Mut0, v1398 : Mut1, v1399 : Mut2, v1400 : Mut3, v1401 : Mut4, v1402 : int64 option) = method1(v1396)
                                let v1403 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1397, v1398, v1399, v1400, v1401, v1402) 
                                TraceState.trace_state <- v1403 
                                ()
                            let struct (v1404 : Mut0, v1405 : Mut1, v1406 : Mut2, v1407 : Mut3, v1408 : Mut4, v1409 : int64 option) = TraceState.trace_state.Value
                            let v1410 : US0 = v1408.l0
                            let v1415 : int32 =
                                match v1410 with
                                | US0_4 -> (* Critical *)
                                    50
                                | US0_1 -> (* Debug *)
                                    20
                                | US0_2 -> (* Info *)
                                    30
                                | US0_0 -> (* Verbose *)
                                    10
                                | US0_3 -> (* Warning *)
                                    40
                            let v1416 : bool = v1406.l0
                            let v1417 : bool = v1416 = false
                            let v1419 : bool =
                                if v1417 then
                                    false
                                else
                                    let v1418 : bool = 30 >= v1415
                                    v1418
                            let v1420 : bool = v1419 = false
                            let v1460 : US7 =
                                if v1420 then
                                    US7_1
                                else
                                    let v1422 : bool = TraceState.trace_state.IsNone
                                    if v1422 then
                                        let v1423 : US0 = US0_0
                                        let struct (v1424 : Mut0, v1425 : Mut1, v1426 : Mut2, v1427 : Mut3, v1428 : Mut4, v1429 : int64 option) = method1(v1423)
                                        let v1430 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1424, v1425, v1426, v1427, v1428, v1429) 
                                        TraceState.trace_state <- v1430 
                                        ()
                                    let struct (v1431 : Mut0, v1432 : Mut1, v1433 : Mut2, v1434 : Mut3, v1435 : Mut4, v1436 : int64 option) = TraceState.trace_state.Value
                                    let v1437 : string = method8(v1431, v1432, v1433, v1434, v1435, v1436)
                                    let v1438 : string = method11()
                                    let v1439 : string = method228(v1431, v1432, v1433, v1434, v1435, v1436, v1437, v1438, v1390, v1391)
                                    let v1440 : bool = TraceState.trace_state.IsNone
                                    if v1440 then
                                        let v1441 : US0 = US0_0
                                        let struct (v1442 : Mut0, v1443 : Mut1, v1444 : Mut2, v1445 : Mut3, v1446 : Mut4, v1447 : int64 option) = method1(v1441)
                                        let v1448 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1442, v1443, v1444, v1445, v1446, v1447) 
                                        TraceState.trace_state <- v1448 
                                        ()
                                    let struct (v1449 : Mut0, v1450 : Mut1, v1451 : Mut2, v1452 : Mut3, v1453 : Mut4, v1454 : int64 option) = TraceState.trace_state.Value
                                    let v1455 : int64 = v1449.l0
                                    let v1456 : int64 = v1455 + 1L
                                    v1449.l0 <- v1456
                                    let v1457 : (string -> unit) = closure12()
                                    v1457 v1439
                                    let v1458 : (string -> unit) = v1450.l0
                                    v1458 v1439
                                    US7_0(v1449, v1450, v1451, v1452, v1453, v1454)
                            method210(v1390, v1391)
                            false
                let v1465 : UH2 =
                    if v1462 then
                        let v1463 : (string -> (string -> US41)) = closure97(v5, v4, v140)
                        UH2_1(v1161, v123, v1463, v1389)
                    else
                        v1389
                let struct (v1466 : string, v1467 : string) = method187(v137, v123, v5)
                let v1468 : bool = method37(v1466)
                let v1538 : bool =
                    if v1468 then
                        true
                    else
                        let v1469 : bool = method37(v1467)
                        let v1470 : bool = v1469 = false
                        if v1470 then
                            true
                        else
                            let v1471 : bool = TraceState.trace_state.IsNone
                            if v1471 then
                                let v1472 : US0 = US0_0
                                let struct (v1473 : Mut0, v1474 : Mut1, v1475 : Mut2, v1476 : Mut3, v1477 : Mut4, v1478 : int64 option) = method1(v1472)
                                let v1479 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1473, v1474, v1475, v1476, v1477, v1478) 
                                TraceState.trace_state <- v1479 
                                ()
                            let struct (v1480 : Mut0, v1481 : Mut1, v1482 : Mut2, v1483 : Mut3, v1484 : Mut4, v1485 : int64 option) = TraceState.trace_state.Value
                            let v1486 : US0 = v1484.l0
                            let v1491 : int32 =
                                match v1486 with
                                | US0_4 -> (* Critical *)
                                    50
                                | US0_1 -> (* Debug *)
                                    20
                                | US0_2 -> (* Info *)
                                    30
                                | US0_0 -> (* Verbose *)
                                    10
                                | US0_3 -> (* Warning *)
                                    40
                            let v1492 : bool = v1482.l0
                            let v1493 : bool = v1492 = false
                            let v1495 : bool =
                                if v1493 then
                                    false
                                else
                                    let v1494 : bool = 30 >= v1491
                                    v1494
                            let v1496 : bool = v1495 = false
                            let v1536 : US7 =
                                if v1496 then
                                    US7_1
                                else
                                    let v1498 : bool = TraceState.trace_state.IsNone
                                    if v1498 then
                                        let v1499 : US0 = US0_0
                                        let struct (v1500 : Mut0, v1501 : Mut1, v1502 : Mut2, v1503 : Mut3, v1504 : Mut4, v1505 : int64 option) = method1(v1499)
                                        let v1506 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1500, v1501, v1502, v1503, v1504, v1505) 
                                        TraceState.trace_state <- v1506 
                                        ()
                                    let struct (v1507 : Mut0, v1508 : Mut1, v1509 : Mut2, v1510 : Mut3, v1511 : Mut4, v1512 : int64 option) = TraceState.trace_state.Value
                                    let v1513 : string = method8(v1507, v1508, v1509, v1510, v1511, v1512)
                                    let v1514 : string = method11()
                                    let v1515 : string = method228(v1507, v1508, v1509, v1510, v1511, v1512, v1513, v1514, v1466, v1467)
                                    let v1516 : bool = TraceState.trace_state.IsNone
                                    if v1516 then
                                        let v1517 : US0 = US0_0
                                        let struct (v1518 : Mut0, v1519 : Mut1, v1520 : Mut2, v1521 : Mut3, v1522 : Mut4, v1523 : int64 option) = method1(v1517)
                                        let v1524 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v1518, v1519, v1520, v1521, v1522, v1523) 
                                        TraceState.trace_state <- v1524 
                                        ()
                                    let struct (v1525 : Mut0, v1526 : Mut1, v1527 : Mut2, v1528 : Mut3, v1529 : Mut4, v1530 : int64 option) = TraceState.trace_state.Value
                                    let v1531 : int64 = v1525.l0
                                    let v1532 : int64 = v1531 + 1L
                                    v1525.l0 <- v1532
                                    let v1533 : (string -> unit) = closure12()
                                    v1533 v1515
                                    let v1534 : (string -> unit) = v1526.l0
                                    v1534 v1515
                                    US7_0(v1525, v1526, v1527, v1528, v1529, v1530)
                            method210(v1466, v1467)
                            false
                let v1543 : UH2 =
                    if v1538 then
                        let v1539 : (string -> (string -> US41)) = closure94(v5, v4, v2, v1, v0)
                        let v1540 : UH2 = UH2_0
                        UH2_1(v137, v123, v1539, v1540)
                    else
                        UH2_0
                let v1544 : UH1 = UH1_0
                let v1545 : UH1 = UH1_1(v1465, v1544)
                UH1_1(v1543, v1545)
        let v1584 : UH2 list = []
        let v1585 : UH2 list = method231(v1547, v1584)
        let v1638 : (UH2 list -> (UH2 [])) = List.toArray
        let v1639 : (UH2 []) = v1638 v1585
        let v1693 : Vec<UH2> = () // backend.backend_switch / record_type_try_find / key: v28 
        let v1730 : (Result<string, (string * string)> option []) = [||]
        let v1752 : Vec<Result<string, (string * string)> option> = () // backend.backend_switch / record_type_try_find / key: v28 
        let v1810 : (UH2 []) = () // backend.backend_switch / record_type_try_find / key: v28 
        let v1850 : UH2 list = v1810 |> Array.toList
        let v1946 : ((UH2 -> (UH1 -> UH1)) -> (UH2 list -> (UH1 -> UH1))) = List.foldBack
        let v1947 : (UH2 -> (UH1 -> UH1)) = method232()
        let v1948 : (UH2 list -> (UH1 -> UH1)) = v1946 v1947
        let v1949 : (UH1 -> UH1) = v1948 v1850
        let v1950 : UH1 = UH1_0
        let v1951 : UH1 = v1949 v1950
        let v1973 : Vec<Result<string, (string * string)> option> = method233(v1951, v1752)
        let v1976 : (string * Vec<Result<string, (string * string)> option>) = v45, v1973 
        let v2010 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = Ok v1976 
        let v2040 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = method240(v2010)
        let v2041 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = method241(v9)
        let v2042 : string = "true; let mut v2041 = v2041"
        let v2043 : bool = Fable.Core.RustInterop.emitRustExpr () v2042 
        let v2044 : string = "true; v2041.push(v2040)"
        let v2045 : bool = Fable.Core.RustInterop.emitRustExpr () v2044 
        let v2046 : string = "v2041"
        let v2047 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v2046 
        method91(v0, v1, v2, v3, v4, v5, v6, v7, v11, v2047)
    else
        v9
and method32 (v0 : bool, v1 : US3, v2 : string, v3 : string, v4 : string, v5 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> =
    let v6 : string = method33()
    let v7 : US3 = method34(v6)
    let v20 : US3 =
        match v7 with
        | US3_1 -> (* None *)
            let v12 : string = __SOURCE_DIRECTORY__
            method34(v12)
        | US3_0(v8) -> (* Some *)
            US3_0(v8)
    let v26 : US3 =
        match v20 with
        | US3_1 -> (* None *)
            let v23 : string = "/workspaces"
            method34(v23)
        | US3_0(v21) -> (* Some *)
            US3_0(v21)
    let v30 : string =
        match v26 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v27) -> (* Some *)
            v27
    let v31 : string = method56(v30)
    let v32 : bool = "deps" = v31
    let v49 : string =
        if v32 then
            let v33 : string option = method40(v30)
            let v36 : string = v33 |> Option.get
            let v44 : US3 = method34(v36)
            match v44 with
            | US3_1 -> (* None *)
                failwith<string> "Option does not have a value."
            | US3_0(v45) -> (* Some *)
                v45
        else
            v30
    let v50 : string = "polyglot"
    let v51 : string = method35(v49, v50)
    let v52 : string = method66(v5)
    let v53 : string = method66(v4)
    let v54 : string = method66(v3)
    let v55 : bool = TraceState.trace_state.IsNone
    if v55 then
        let v56 : US0 = US0_0
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = method1(v56)
        let v63 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v57, v58, v59, v60, v61, v62) 
        TraceState.trace_state <- v63 
        ()
    let struct (v64 : Mut0, v65 : Mut1, v66 : Mut2, v67 : Mut3, v68 : Mut4, v69 : int64 option) = TraceState.trace_state.Value
    let v70 : US0 = v68.l0
    let v75 : int32 =
        match v70 with
        | US0_4 -> (* Critical *)
            50
        | US0_1 -> (* Debug *)
            20
        | US0_2 -> (* Info *)
            30
        | US0_0 -> (* Verbose *)
            10
        | US0_3 -> (* Warning *)
            40
    let v76 : bool = v66.l0
    let v77 : bool = v76 = false
    let v79 : bool =
        if v77 then
            false
        else
            let v78 : bool = 20 >= v75
            v78
    let v80 : bool = v79 = false
    let v120 : US7 =
        if v80 then
            US7_1
        else
            let v82 : bool = TraceState.trace_state.IsNone
            if v82 then
                let v83 : US0 = US0_0
                let struct (v84 : Mut0, v85 : Mut1, v86 : Mut2, v87 : Mut3, v88 : Mut4, v89 : int64 option) = method1(v83)
                let v90 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v84, v85, v86, v87, v88, v89) 
                TraceState.trace_state <- v90 
                ()
            let struct (v91 : Mut0, v92 : Mut1, v93 : Mut2, v94 : Mut3, v95 : Mut4, v96 : int64 option) = TraceState.trace_state.Value
            let v97 : string = method8(v91, v92, v93, v94, v95, v96)
            let v98 : string = method67()
            let v99 : string = method68(v91, v92, v93, v94, v95, v96, v97, v98, v52, v53, v54, v2, v1, v0)
            let v100 : bool = TraceState.trace_state.IsNone
            if v100 then
                let v101 : US0 = US0_0
                let struct (v102 : Mut0, v103 : Mut1, v104 : Mut2, v105 : Mut3, v106 : Mut4, v107 : int64 option) = method1(v101)
                let v108 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v102, v103, v104, v105, v106, v107) 
                TraceState.trace_state <- v108 
                ()
            let struct (v109 : Mut0, v110 : Mut1, v111 : Mut2, v112 : Mut3, v113 : Mut4, v114 : int64 option) = TraceState.trace_state.Value
            let v115 : int64 = v109.l0
            let v116 : int64 = v115 + 1L
            v109.l0 <- v116
            let v117 : (string -> unit) = closure12()
            v117 v99
            let v118 : (string -> unit) = v110.l0
            v118 v99
            US7_0(v109, v110, v111, v112, v113, v114)
    let v121 : string = "true; let __future_init = Box::pin(/*"
    let v122 : bool = Fable.Core.RustInterop.emitRustExpr () v121 
    let v123 : string = "*/ async move { /*"
    let v124 : bool = Fable.Core.RustInterop.emitRustExpr () v123 
    let v125 : string = "*/ ()"
    let v126 : bool = Fable.Core.RustInterop.emitRustExpr () v125 
    let v151 : string = "async_walkdir::WalkDir::new(&*$0)"
    let v152 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr v53 v151 
    let v153 : string = "async_walkdir::WalkDir::filter($0, move |x| $1(x))"
    let v154 : (async_walkdir_DirEntry -> std_pin_Pin<Box<Dyn<std_future_Future<async_walkdir_Filtering>>>>) = closure26(v1)
    let v155 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr struct (v152, v154) v153 
    let v156 : (Result<async_walkdir_DirEntry, async_walkdir_Error> -> string option) = method80()
    let v157 : string = "futures::stream::StreamExt::filter_map(v155, |x| async { v156(x) })"
    let v158 : _ = Fable.Core.RustInterop.emitRustExpr () v157 
    let v159 : string = "Box::pin(futures::stream::StreamExt::collect(v158))"
    let v160 : std_pin_Pin<Box<Dyn<std_future_Future<Vec<string>>>>> = Fable.Core.RustInterop.emitRustExpr () v159 
    let v161 : string = "v160.await"
    let v162 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v161 
    let v218 : bool = TraceState.trace_state.IsNone
    if v218 then
        let v219 : US0 = US0_0
        let struct (v220 : Mut0, v221 : Mut1, v222 : Mut2, v223 : Mut3, v224 : Mut4, v225 : int64 option) = method1(v219)
        let v226 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v220, v221, v222, v223, v224, v225) 
        TraceState.trace_state <- v226 
        ()
    let struct (v227 : Mut0, v228 : Mut1, v229 : Mut2, v230 : Mut3, v231 : Mut4, v232 : int64 option) = TraceState.trace_state.Value
    let v233 : US0 = v231.l0
    let v238 : int32 =
        match v233 with
        | US0_4 -> (* Critical *)
            50
        | US0_1 -> (* Debug *)
            20
        | US0_2 -> (* Info *)
            30
        | US0_0 -> (* Verbose *)
            10
        | US0_3 -> (* Warning *)
            40
    let v239 : bool = v229.l0
    let v240 : bool = v239 = false
    let v242 : bool =
        if v240 then
            false
        else
            let v241 : bool = 20 >= v238
            v241
    let v243 : bool = v242 = false
    let v343 : US7 =
        if v243 then
            US7_1
        else
            let v245 : bool = TraceState.trace_state.IsNone
            if v245 then
                let v246 : US0 = US0_0
                let struct (v247 : Mut0, v248 : Mut1, v249 : Mut2, v250 : Mut3, v251 : Mut4, v252 : int64 option) = method1(v246)
                let v253 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v247, v248, v249, v250, v251, v252) 
                TraceState.trace_state <- v253 
                ()
            let struct (v254 : Mut0, v255 : Mut1, v256 : Mut2, v257 : Mut3, v258 : Mut4, v259 : int64 option) = TraceState.trace_state.Value
            let v260 : string = method8(v254, v255, v256, v257, v258, v259)
            let v261 : string = method67()
            let v284 : string = "Fsharp"
            let v285 : unativeint = () // backend.backend_switch / record_type_try_find / key: v284 
            let v322 : string = method88(v254, v255, v256, v257, v258, v259, v260, v261, v285)
            let v323 : bool = TraceState.trace_state.IsNone
            if v323 then
                let v324 : US0 = US0_0
                let struct (v325 : Mut0, v326 : Mut1, v327 : Mut2, v328 : Mut3, v329 : Mut4, v330 : int64 option) = method1(v324)
                let v331 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v325, v326, v327, v328, v329, v330) 
                TraceState.trace_state <- v331 
                ()
            let struct (v332 : Mut0, v333 : Mut1, v334 : Mut2, v335 : Mut3, v336 : Mut4, v337 : int64 option) = TraceState.trace_state.Value
            let v338 : int64 = v332.l0
            let v339 : int64 = v338 + 1L
            v332.l0 <- v339
            let v340 : (string -> unit) = closure12()
            v340 v322
            let v341 : (string -> unit) = v333.l0
            v341 v322
            US7_0(v332, v333, v334, v335, v336, v337)
    let v353 : string = "Fsharp"
    let v354 : (string []) = () // backend.backend_switch / record_type_try_find / key: v353 
    let v373 : int32 = (v354.borrow().len() as i32)
    let v374 : int32 = 0
    let v396 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = () // backend.backend_switch / record_type_try_find / key: v353 
    let v433 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = method91(v0, v2, v51, v52, v53, v54, v354, v373, v374, v396)
    let v455 : (Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> []) = () // backend.backend_switch / record_type_try_find / key: v353 
    let v496 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = () // backend.backend_switch / record_type_try_find / key: v353 
    let v507 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Ok v496 
    () // backend.backend_switch / record_type_try_find / key: v353 
    let v542 : string = "__future_init"
    let v543 : _ = Fable.Core.RustInterop.emitRustExpr () v542 
    let v544 : string = "v543"
    let v545 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v544 
    v545
and closure101 () (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) : US47 =
    US47_0(v0)
and method242 () : (Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> -> US47) =
    closure101()
and closure102 () (v0 : std_string_String) : US47 =
    US47_1(v0)
and method243 () : (std_string_String -> US47) =
    closure102()
and method244 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : int64 = v0.l0
    let v10 : string = " "
    let v11 : string = v6 + v10 
    let v12 : string = method16(v9)
    let v13 : string = v11 + v12 
    let v14 : string = v13 + v7 
    let v15 : string = v14 + v10 
    let v16 : string = "documents.main"
    let v17 : string = v15 + v16 
    let v18 : string = " / "
    let v19 : string = v17 + v18 
    let v20 : string = method87(v8)
    let v21 : string = v19 + v20 
    method22(v21)
and method246 (v0 : unativeint) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    method18(v2)
    method219(v2)
    method20(v2)
    let v3 : string = $"%A{v0}"
    method14(v2, v3)
    method21(v2)
    let v4 : string = v2.l0
    v4
and method245 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : unativeint) : string =
    let v9 : int64 = v0.l0
    let v10 : string = " "
    let v11 : string = v6 + v10 
    let v12 : string = method16(v9)
    let v13 : string = v11 + v12 
    let v14 : string = v13 + v7 
    let v15 : string = v14 + v10 
    let v16 : string = "documents.main"
    let v17 : string = v15 + v16 
    let v18 : string = " / "
    let v19 : string = v17 + v18 
    let v20 : string = method246(v8)
    let v21 : string = v19 + v20 
    method22(v21)
and closure1 () (v0 : (string [])) : int32 =
    let v9 : bool = TraceState.trace_state.IsNone
    if v9 then
        let v10 : US0 = US0_2
        let struct (v11 : Mut0, v12 : Mut1, v13 : Mut2, v14 : Mut3, v15 : Mut4, v16 : int64 option) = method1(v10)
        let v19 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
        TraceState.trace_state <- v19 
        ()
    let v51 : bool = TraceState.trace_state.IsNone
    if v51 then
        let v52 : US0 = US0_0
        let struct (v53 : Mut0, v54 : Mut1, v55 : Mut2, v56 : Mut3, v57 : Mut4, v58 : int64 option) = method1(v52)
        let v59 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v53, v54, v55, v56, v57, v58) 
        TraceState.trace_state <- v59 
        ()
    let struct (v82 : Mut0, v83 : Mut1, v84 : Mut2, v85 : Mut3, v86 : Mut4, v87 : int64 option) = TraceState.trace_state.Value
    let v174 : US0 = v86.l0
    let v179 : int32 =
        match v174 with
        | US0_4 -> (* Critical *)
            50
        | US0_1 -> (* Debug *)
            20
        | US0_2 -> (* Info *)
            30
        | US0_0 -> (* Verbose *)
            10
        | US0_3 -> (* Warning *)
            40
    let v180 : bool = v84.l0
    let v181 : bool = v180 = false
    let v183 : bool =
        if v181 then
            false
        else
            let v182 : bool = 30 >= v179
            v182
    let v184 : bool = v183 = false
    let v269 : US7 =
        if v184 then
            US7_1
        else
            let v186 : bool = TraceState.trace_state.IsNone
            if v186 then
                let v187 : US0 = US0_0
                let struct (v188 : Mut0, v189 : Mut1, v190 : Mut2, v191 : Mut3, v192 : Mut4, v193 : int64 option) = method1(v187)
                let v194 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v188, v189, v190, v191, v192, v193) 
                TraceState.trace_state <- v194 
                ()
            let struct (v195 : Mut0, v196 : Mut1, v197 : Mut2, v198 : Mut3, v199 : Mut4, v200 : int64 option) = TraceState.trace_state.Value
            let v201 : string = method8(v195, v196, v197, v198, v199, v200)
            let v202 : string = method11()
            let v203 : string = method15(v195, v196, v197, v198, v199, v200, v201, v202, v0)
            let v204 : bool = TraceState.trace_state.IsNone
            if v204 then
                let v205 : US0 = US0_0
                let struct (v206 : Mut0, v207 : Mut1, v208 : Mut2, v209 : Mut3, v210 : Mut4, v211 : int64 option) = method1(v205)
                let v212 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v206, v207, v208, v209, v210, v211) 
                TraceState.trace_state <- v212 
                ()
            let struct (v213 : Mut0, v214 : Mut1, v215 : Mut2, v216 : Mut3, v217 : Mut4, v218 : int64 option) = TraceState.trace_state.Value
            let v219 : int64 = v213.l0
            let v220 : int64 = v219 + 1L
            v213.l0 <- v220
            let v221 : (string -> unit) = closure12()
            v221 v203
            let v267 : (string -> unit) = v214.l0
            v267 v203
            US7_0(v213, v214, v215, v216, v217, v218)
    let v292 : clap_Command = method0()
    let v293 : string = "clap::Command::get_matches($0)"
    let v294 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v292 v293 
    let v295 : string = method25()
    let v524 : Ref<Str> = v295 |> unbox<Ref<Str>>
    let v533 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v534 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v294, v524) v533 
    let v595 : (std_string_String -> US8) = method26()
    let v596 : US8 option = v534 |> Option.map v595 
    let v624 : US8 = US8_1
    let v625 : US8 = v596 |> Option.defaultValue v624 
    let v651 : std_string_String =
        match v625 with
        | US8_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US8_0(v648) -> (* Some *)
            v648
    let v669 : string = "Fsharp"
    let v670 : string = () // backend.backend_switch / record_type_try_find / key: v669 
    let v686 : string = method27()
    let v687 : Ref<Str> = v686 |> unbox<Ref<Str>>
    let v688 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v689 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v294, v687) v688 
    let v690 : (std_string_String -> US8) = method26()
    let v691 : US8 option = v689 |> Option.map v690 
    let v692 : US8 = US8_1
    let v693 : US8 = v691 |> Option.defaultValue v692 
    let v697 : std_string_String =
        match v693 with
        | US8_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US8_0(v694) -> (* Some *)
            v694
    let v698 : string = () // backend.backend_switch / record_type_try_find / key: v669 
    let v699 : string = method28()
    let v700 : Ref<Str> = v699 |> unbox<Ref<Str>>
    let v701 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v702 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v294, v700) v701 
    let v703 : (std_string_String -> US8) = method26()
    let v704 : US8 option = v702 |> Option.map v703 
    let v705 : US8 = US8_1
    let v706 : US8 = v704 |> Option.defaultValue v705 
    let v710 : std_string_String =
        match v706 with
        | US8_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US8_0(v707) -> (* Some *)
            v707
    let v711 : string = () // backend.backend_switch / record_type_try_find / key: v669 
    let v712 : string = method29()
    let v713 : Ref<Str> = v712 |> unbox<Ref<Str>>
    let v714 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v715 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v294, v713) v714 
    let v716 : (std_string_String -> US8) = method26()
    let v717 : US8 option = v715 |> Option.map v716 
    let v718 : US8 = US8_1
    let v719 : US8 = v717 |> Option.defaultValue v718 
    let v725 : US3 =
        match v719 with
        | US8_1 -> (* None *)
            US3_1
        | US8_0(v720) -> (* Some *)
            let v721 : string = () // backend.backend_switch / record_type_try_find / key: v669 
            US3_0(v721)
    let v729 : string =
        match v725 with
        | US3_1 -> (* None *)
            let v727 : string = "por-br"
            v727
        | US3_0(v726) -> (* Some *)
            v726
    let v730 : string = method30()
    let v731 : Ref<Str> = v730 |> unbox<Ref<Str>>
    let v732 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v733 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v294, v731) v732 
    let v734 : (std_string_String -> US8) = method26()
    let v735 : US8 option = v733 |> Option.map v734 
    let v736 : US8 = US8_1
    let v737 : US8 = v735 |> Option.defaultValue v736 
    let v743 : US3 =
        match v737 with
        | US8_1 -> (* None *)
            US3_1
        | US8_0(v738) -> (* Some *)
            let v739 : string = () // backend.backend_switch / record_type_try_find / key: v669 
            US3_0(v739)
    let v744 : string = method31()
    let v745 : Ref<Str> = v744 |> unbox<Ref<Str>>
    let v746 : string = "clap::ArgMatches::get_flag(&$0, $1)"
    let v747 : bool = Fable.Core.RustInterop.emitRustExpr struct (v294, v745) v746 
    let v748 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = method32(v747, v743, v729, v711, v698, v670)
    let v749 : string = "futures::executor::block_on($0)"
    let v750 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr v748 v749 
    let v751 : (Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> -> US47) = method242()
    let v752 : (std_string_String -> US47) = method243()
    let v755 : US47 = match v750 with Ok x -> v751 x | Error x -> v752 x
    match v755 with
    | US47_1(v864) -> (* Error *)
        let v865 : bool = TraceState.trace_state.IsNone
        if v865 then
            let v866 : US0 = US0_0
            let struct (v867 : Mut0, v868 : Mut1, v869 : Mut2, v870 : Mut3, v871 : Mut4, v872 : int64 option) = method1(v866)
            let v873 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v867, v868, v869, v870, v871, v872) 
            TraceState.trace_state <- v873 
            ()
        let struct (v874 : Mut0, v875 : Mut1, v876 : Mut2, v877 : Mut3, v878 : Mut4, v879 : int64 option) = TraceState.trace_state.Value
        let v880 : US0 = v878.l0
        let v885 : int32 =
            match v880 with
            | US0_4 -> (* Critical *)
                50
            | US0_1 -> (* Debug *)
                20
            | US0_2 -> (* Info *)
                30
            | US0_0 -> (* Verbose *)
                10
            | US0_3 -> (* Warning *)
                40
        let v886 : bool = v876.l0
        let v887 : bool = v886 = false
        let v889 : bool =
            if v887 then
                false
            else
                let v888 : bool = 50 >= v885
                v888
        let v890 : bool = v889 = false
        let v930 : US7 =
            if v890 then
                US7_1
            else
                let v892 : bool = TraceState.trace_state.IsNone
                if v892 then
                    let v893 : US0 = US0_0
                    let struct (v894 : Mut0, v895 : Mut1, v896 : Mut2, v897 : Mut3, v898 : Mut4, v899 : int64 option) = method1(v893)
                    let v900 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v894, v895, v896, v897, v898, v899) 
                    TraceState.trace_state <- v900 
                    ()
                let struct (v901 : Mut0, v902 : Mut1, v903 : Mut2, v904 : Mut3, v905 : Mut4, v906 : int64 option) = TraceState.trace_state.Value
                let v907 : string = method8(v901, v902, v903, v904, v905, v906)
                let v908 : string = method85()
                let v909 : string = method244(v901, v902, v903, v904, v905, v906, v907, v908, v864)
                let v910 : bool = TraceState.trace_state.IsNone
                if v910 then
                    let v911 : US0 = US0_0
                    let struct (v912 : Mut0, v913 : Mut1, v914 : Mut2, v915 : Mut3, v916 : Mut4, v917 : int64 option) = method1(v911)
                    let v918 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v912, v913, v914, v915, v916, v917) 
                    TraceState.trace_state <- v918 
                    ()
                let struct (v919 : Mut0, v920 : Mut1, v921 : Mut2, v922 : Mut3, v923 : Mut4, v924 : int64 option) = TraceState.trace_state.Value
                let v925 : int64 = v919.l0
                let v926 : int64 = v925 + 1L
                v919.l0 <- v926
                let v927 : (string -> unit) = closure12()
                v927 v909
                let v928 : (string -> unit) = v920.l0
                v928 v909
                US7_0(v919, v920, v921, v922, v923, v924)
        1
    | US47_0(v785) -> (* Ok *)
        let v786 : bool = TraceState.trace_state.IsNone
        if v786 then
            let v787 : US0 = US0_0
            let struct (v788 : Mut0, v789 : Mut1, v790 : Mut2, v791 : Mut3, v792 : Mut4, v793 : int64 option) = method1(v787)
            let v794 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v788, v789, v790, v791, v792, v793) 
            TraceState.trace_state <- v794 
            ()
        let struct (v795 : Mut0, v796 : Mut1, v797 : Mut2, v798 : Mut3, v799 : Mut4, v800 : int64 option) = TraceState.trace_state.Value
        let v801 : US0 = v799.l0
        let v806 : int32 =
            match v801 with
            | US0_4 -> (* Critical *)
                50
            | US0_1 -> (* Debug *)
                20
            | US0_2 -> (* Info *)
                30
            | US0_0 -> (* Verbose *)
                10
            | US0_3 -> (* Warning *)
                40
        let v807 : bool = v797.l0
        let v808 : bool = v807 = false
        let v810 : bool =
            if v808 then
                false
            else
                let v809 : bool = 30 >= v806
                v809
        let v811 : bool = v810 = false
        let v863 : US7 =
            if v811 then
                US7_1
            else
                let v813 : bool = TraceState.trace_state.IsNone
                if v813 then
                    let v814 : US0 = US0_0
                    let struct (v815 : Mut0, v816 : Mut1, v817 : Mut2, v818 : Mut3, v819 : Mut4, v820 : int64 option) = method1(v814)
                    let v821 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v815, v816, v817, v818, v819, v820) 
                    TraceState.trace_state <- v821 
                    ()
                let struct (v822 : Mut0, v823 : Mut1, v824 : Mut2, v825 : Mut3, v826 : Mut4, v827 : int64 option) = TraceState.trace_state.Value
                let v828 : string = method8(v822, v823, v824, v825, v826, v827)
                let v829 : string = method11()
                let v833 : unativeint = () // backend.backend_switch / record_type_try_find / key: v669 
                let v842 : string = method245(v822, v823, v824, v825, v826, v827, v828, v829, v833)
                let v843 : bool = TraceState.trace_state.IsNone
                if v843 then
                    let v844 : US0 = US0_0
                    let struct (v845 : Mut0, v846 : Mut1, v847 : Mut2, v848 : Mut3, v849 : Mut4, v850 : int64 option) = method1(v844)
                    let v851 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v845, v846, v847, v848, v849, v850) 
                    TraceState.trace_state <- v851 
                    ()
                let struct (v852 : Mut0, v853 : Mut1, v854 : Mut2, v855 : Mut3, v856 : Mut4, v857 : int64 option) = TraceState.trace_state.Value
                let v858 : int64 = v852.l0
                let v859 : int64 = v858 + 1L
                v852.l0 <- v859
                let v860 : (string -> unit) = closure12()
                v860 v842
                let v861 : (string -> unit) = v853.l0
                v861 v842
                US7_0(v852, v853, v854, v855, v856, v857)
        0
let v6 : (unit -> unit) = closure0()
let tests () = v6 ()
let v7 : ((string []) -> int32) = closure1()
let main args = v7 args
()
