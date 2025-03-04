#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
type Ref<'T> = class end
#else
type Ref<'T> = 'T
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::Command")>]
#endif
type clap_Command = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::Arg")>]
#endif
type clap_Arg = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
type std_string_String = class end
#else
type std_string_String = string
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>]
#endif
type Mut<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::ArgMatches")>]
#endif
type clap_ArgMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::path::PathBuf")>]
type std_path_PathBuf = class end
#else
type std_path_PathBuf = string
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::path::Display")>]
type std_path_Display = class end
#else
type std_path_Display = string
#endif

#if FABLE_COMPILER
type System_IO_DirectoryInfo = bool
#else
type System_IO_DirectoryInfo = System.IO.DirectoryInfo
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Error")>]
type std_io_Error = class end
#else
type std_io_Error = string
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsString")>]
#endif
type std_ffi_OsString = class end
#if FABLE_COMPILER
type System_IO_FileInfo = bool
#else
type System_IO_FileInfo = System.IO.FileInfo
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Regex")>]
#endif
type regex_Regex = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::borrow::Cow<$0>")>]
#endif
type std_borrow_Cow<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::WalkDir")>]
#endif
type async_walkdir_WalkDir = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::DirEntry")>]
#endif
type async_walkdir_DirEntry = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::pin::Pin<$0>")>]
#endif
type std_pin_Pin<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::fs::FileType")>]
#endif
type std_fs_FileType = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::Filtering")>]
#endif
type async_walkdir_Filtering = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::Error")>]
#endif
type async_walkdir_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rayon::vec::IntoIter<$0>")>]
#endif
type rayon_vec_IntoIter<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Command")>]
#endif
type std_process_Command = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Stdio")>]
#endif
type std_process_Stdio = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Child")>]
#endif
type std_process_Child = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Mutex<$0>")>]
#endif
type std_sync_Mutex<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Arc<$0>")>]
#endif
type std_sync_Arc<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::MutexGuard<$0>")>]
#endif
type std_sync_MutexGuard<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ChildStdout")>]
#endif
type std_process_ChildStdout = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ChildStderr")>]
#endif
type std_process_ChildStderr = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ChildStdin")>]
#endif
type std_process_ChildStdin = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::Sender<$0>")>]
#endif
type std_sync_mpsc_Sender<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("encoding_rs_io::DecodeReaderBytes<$0, $1>")>]
#endif
type encoding_rs_io_DecodeReaderBytes<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::BufReader<$0>")>]
#endif
type std_io_BufReader<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Lines<$0>")>]
#endif
type std_io_Lines<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::SendError<$0>")>]
#endif
type std_sync_mpsc_SendError<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type core_ops_Try<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::thread::JoinHandle<$0>")>]
#endif
type std_thread_JoinHandle<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Output")>]
#endif
type std_process_Output = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ExitStatus")>]
#endif
type std_process_ExitStatus = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::fs::File")>]
#endif
type std_fs_File = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("sha2::Sha256")>]
#endif
type sha2_Sha256 = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type Slice'<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rayon::iter::Map<$0, _>")>]
#endif
type rayon_iter_Map<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0 $1")>]
#endif
type Lifetime<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("'static")>]
#endif
type StaticLifetime = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("str")>]
type Str = class end
#else
type Str = string
#endif

module TraceState = let mutable trace_state = None
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
type IOsEnviron = abstract environ: x: unit -> obj
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>]
#endif
type Box<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>]
#endif
type Dyn<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::future::Future<Output = $0>")>]
#endif
type std_future_Future<'T> = class end
type IFs = abstract realpathSync: path: string -> string
type IPathJoin = abstract join: [<System.ParamArray>] paths: string[] -> string
type IFsExistsSync = abstract existsSync: path: string -> bool
type IPathDirname = abstract dirname: path: string -> string
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsStr")>]
#endif
type std_ffi_OsStr = class end
type IPathBasename = abstract basename: path: string -> string
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Error")>]
#endif
type regex_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Send")>]
#endif
type Send<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0 + $1")>]
#endif
type LifetimeJoin<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::Receiver<$0>")>]
#endif
type std_sync_mpsc_Receiver<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::PoisonError<$0>")>]
#endif
type std_sync_PoisonError<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("encoding_rs::Encoding")>]
#endif
type encoding_rs_Encoding = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::str::Utf8Error")>]
#endif
type std_str_Utf8Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0")>]
#endif
type LifetimeRef<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("core::any::Any")>]
type core_any_Any = class end
#else
type core_any_Any = obj
#endif

#if FABLE_COMPILER
[<CompilationRepresentation (CompilationRepresentationFlags.ModuleSuffix)>]
module System =
 module Diagnostics =
  type Process = bool
  type DataReceivedEventArgs = bool
#endif
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::FromUtf8Error")>]
#endif
type std_string_FromUtf8Error = class end
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
    | US3_0
    | US3_1
    | US3_2
and [<Struct>] US4 =
    | US4_0 of f0_0 : US3
    | US4_1 of f1_0 : US3
    | US4_2 of f2_0 : US3
    | US4_3 of f3_0 : US3
    | US4_4 of f4_0 : US3
    | US4_5 of f5_0 : US3
and [<Struct>] US5 =
    | US5_0 of f0_0 : string
    | US5_1
and [<Struct>] US6 =
    | US6_0 of f0_0 : std_string_String
    | US6_1
and [<Struct>] US7 =
    | US7_0
    | US7_1
and [<Struct>] US8 =
    | US8_0 of f0_0 : string
    | US8_1 of f1_0 : string
and [<Struct>] US9 =
    | US9_0 of f0_0 : std_path_PathBuf
    | US9_1 of f1_0 : string
and [<Struct>] US10 =
    | US10_0 of f0_0 : std_path_PathBuf
    | US10_1
and Mut5 = {mutable l0 : int32; mutable l1 : int32; mutable l2 : (string [])}
and Mut6 = {mutable l0 : int32}
and [<Struct>] US11 =
    | US11_0 of f0_0 : std_fs_FileType
    | US11_1 of f1_0 : std_string_String
and [<Struct>] US12 =
    | US12_0
    | US12_1
    | US12_2
and [<Struct>] US13 =
    | US13_0 of f0_0 : async_walkdir_DirEntry
    | US13_1 of f1_0 : std_string_String
and [<Struct>] US14 =
    | US14_0 of f0_0 : string * f0_1 : US5
    | US14_1 of f1_0 : string
and [<Struct>] US15 =
    | US15_0 of f0_0 : char * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US15_1 of f1_0 : string
and UH0 =
    | UH0_0
    | UH0_1 of char * UH0
and UH1 =
    | UH1_0
    | UH1_1 of (struct (string * System.Text.StringBuilder * int32 * int32) -> US15) * UH1
and [<Struct>] US16 =
    | US16_0 of f0_0 : string * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US16_1 of f1_0 : string
and [<Struct>] US17 =
    | US17_0 of f0_0 : char
    | US17_1
and [<Struct>] US18 =
    | US18_0 of f0_0 : string * f0_1 : System.Text.StringBuilder * f0_2 : int32 * f0_3 : int32
    | US18_1 of f1_0 : string
and [<Struct>] US19 =
    | US19_0 of f0_0 : string * f0_1 : US5 * f0_2 : string * f0_3 : System.Text.StringBuilder * f0_4 : int32 * f0_5 : int32
    | US19_1 of f1_0 : string
and [<Struct>] US20 =
    | US20_0 of f0_0 : US17 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US20_1 of f1_0 : string
and [<Struct>] US21 =
    | US21_0 of f0_0 : US5 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US21_1 of f1_0 : string
and [<Struct>] US22 =
    | US22_0 of f0_0 : (string [])
    | US22_1 of f1_0 : string
and UH2 =
    | UH2_0
    | UH2_1 of string * UH2
and [<Struct>] US23 =
    | US23_0 of f0_0 : UH2 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US23_1 of f1_0 : string
and UH3 =
    | UH3_0
    | UH3_1 of (struct (string * System.Text.StringBuilder * int32 * int32) -> US16) * UH3
and [<Struct>] US24 =
    | US24_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>
    | US24_1 of f1_0 : std_string_String
and [<Struct>] US25 =
    | US25_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>
    | US25_1
and [<Struct>] US26 =
    | US26_0 of f0_0 : std_string_String
    | US26_1 of f1_0 : std_string_String
and [<Struct>] US27 =
    | US27_0 of f0_0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)
    | US27_1
and [<Struct>] US28 =
    | US28_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>
    | US28_1
and [<Struct>] US29 =
    | US29_0 of f0_0 : std_process_Output
    | US29_1 of f1_0 : std_string_String
and [<Struct>] US30 =
    | US30_0 of f0_0 : int32
    | US30_1
and [<Struct>] US31 =
    | US31_0 of f0_0 : (struct (int32 * string * bool) -> Async<unit>)
    | US31_1
and [<Struct>] US32 =
    | US32_0 of f0_0 : System.Threading.CancellationToken
    | US32_1
and [<Struct>] US33 =
    | US33_0 of f0_0 : Result<string, (string * string)>
    | US33_1
and UH5 =
    | UH5_0
    | UH5_1 of string * string * (string -> (string -> US33)) * UH5
and UH4 =
    | UH4_0
    | UH4_1 of UH5 * UH4
and [<Struct>] US34 =
    | US34_0 of f0_0 : string
    | US34_1 of f1_0 : std_string_String
and [<Struct>] US35 =
    | US35_0 of f0_0 : uint64
    | US35_1 of f1_0 : std_string_String
and [<Struct>] US36 =
    | US36_0 of f0_0 : int32 * f0_1 : string
    | US36_1 of f1_0 : int32 * f1_1 : string
and Mut7 = {mutable l0 : int32; mutable l1 : int32}
and Mut8 = {mutable l0 : int32; mutable l1 : string; mutable l2 : int32; mutable l3 : int32}
and [<Struct>] US37 =
    | US37_0 of f0_0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>
    | US37_1 of f1_0 : std_string_String
let rec method0 () : clap_Command =
    let v0 : string = "command"
    let v1 : string = "r#\"" + v0 + "\"#"
    let v2 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = "clap::Command::new($0)"
    let v4 : clap_Command = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "source-dir"
    let v6 : string = "r#\"" + v5 + "\"#"
    let v7 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v6 
    let v8 : string = "clap::Arg::new($0)"
    let v9 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "$0.short($1)"
    let v11 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v9, 's') v10 
    let v12 : string = "r#\"" + v5 + "\"#"
    let v13 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "$0.long($1)"
    let v15 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v11, v13) v14 
    let v16 : string = "$0.required($1)"
    let v17 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v15, true) v16 
    let v18 : string = "clap::Command::arg($0, $1)"
    let v19 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v4, v17) v18 
    let v20 : string = "dist-dir"
    let v21 : string = "r#\"" + v20 + "\"#"
    let v22 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v21 
    let v23 : string = "clap::Arg::new($0)"
    let v24 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "$0.short($1)"
    let v26 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v24, 'd') v25 
    let v27 : string = "r#\"" + v20 + "\"#"
    let v28 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "$0.long($1)"
    let v30 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v26, v28) v29 
    let v31 : string = "$0.required($1)"
    let v32 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v30, true) v31 
    let v33 : string = "clap::Command::arg($0, $1)"
    let v34 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v19, v32) v33 
    let v35 : string = "cache-dir"
    let v36 : string = "r#\"" + v35 + "\"#"
    let v37 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "clap::Arg::new($0)"
    let v39 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let v40 : string = "$0.short($1)"
    let v41 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v39, 'c') v40 
    let v42 : string = "r#\"" + v35 + "\"#"
    let v43 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v42 
    let v44 : string = "$0.long($1)"
    let v45 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v41, v43) v44 
    let v46 : string = "$0.required($1)"
    let v47 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v45, true) v46 
    let v48 : string = "clap::Command::arg($0, $1)"
    let v49 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v34, v47) v48 
    let v50 : string = "hangul-spec"
    let v51 : string = "r#\"" + v50 + "\"#"
    let v52 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v51 
    let v53 : string = "clap::Arg::new($0)"
    let v54 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v52 v53 
    let v55 : string = "$0.short($1)"
    let v56 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v54, 'h') v55 
    let v57 : string = "r#\"" + v50 + "\"#"
    let v58 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v57 
    let v59 : string = "$0.long($1)"
    let v60 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v56, v58) v59 
    let v61 : string = "$0.required($1)"
    let v62 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v60, true) v61 
    let v63 : string = "clap::Command::arg($0, $1)"
    let v64 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v49, v62) v63 
    v64
and closure0 () () : unit =
    let v0 : string = "true; () //"
    let v1 : bool = Fable.Core.RustInterop.emitRustExpr () v0 
    let v2 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v2 
    let v3 : string = "verify_app"
    let v4 : string = $"*/ #[test] fn " + v3 + "() { //"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr () v4 
    let v6 : clap_Command = method0()
    let v7 : string = "clap::Command::debug_assert($0)"
    Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v8 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v8 
    ()
and method4 (v0 : string) : string =
    v0
and method5 () : string =
    let v0 : string = ""
    v0
and closure3 () (v0 : string) : US5 =
    US5_0(v0)
and method6 () : (string -> US5) =
    closure3()
and method3 (v0 : string) : string =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = method4(v0)
    let v7 : string = "std::env::var(&*$0)"
    let v8 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr v8 v9 
    let v11 : string = "x"
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v11 
    let v13 : string = "fable_library_rust::String_::fromString($0)"
    let v14 : string = Fable.Core.RustInterop.emitRustExpr v12 v13 
    let v15 : string = "true; $0 })"
    let v16 : bool = Fable.Core.RustInterop.emitRustExpr v14 v15 
    let v17 : string = "_result_map_"
    let v18 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v17 
    let v19 : string = method5()
    let v20 : string = "$0.unwrap_or($1)"
    let v21 : string = Fable.Core.RustInterop.emitRustExpr struct (v18, v19) v20 
    let _run_target_args'_v5 = v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : US3 = US3_1
    let v23 : US4 = US4_3(v22)
    let v24 : string = $"env.get_environment_variable / target: {v23} / var: {v0}"
    let v25 : string = failwith<string> v24
    let _run_target_args'_v5 = v25 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : US3 = US3_2
    let v27 : US4 = US4_3(v26)
    let v28 : string = $"env.get_environment_variable / target: {v27} / var: {v0}"
    let v29 : string = failwith<string> v28
    let _run_target_args'_v5 = v29 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v30 : string = "process.env[$0] ?? \"\""
    let v31 : string = Fable.Core.JsInterop.emitJsExpr v0 v30 
    let _run_target_args'_v5 = v31 
    #endif
#if FABLE_COMPILER_PYTHON
    let v33 : string = "os"
    let v34 : IOsEnviron = Fable.Core.PyInterop.importAll v33 
    let v35 : string = "v34.environ"
    let v36 : obj = Fable.Core.PyInterop.emitPyExpr () v35 
    let v40 : string = "v36.get($0)"
    let v41 : string = Fable.Core.PyInterop.emitPyExpr v0 v40 
    let mutable _v41 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v45 : (string -> string option) = Option.ofObj
    let v46 : string option = v45 v41
    v46 
    #else
    Some v41 
    #endif
    |> fun x -> _v41 <- Some x
    let v47 : string option = match _v41 with Some x -> x | None -> failwith "optionm'.of_obj / _v41=None"
    let v51 : (string -> US5) = method6()
    let v52 : US5 option = v47 |> Option.map v51 
    let v65 : US5 = US5_1
    let v66 : US5 = v52 |> Option.defaultValue v65 
    let v73 : string =
        match v66 with
        | US5_1 -> (* None *)
            let v71 : string = ""
            v71
        | US5_0(v70) -> (* Some *)
            v70
    let _run_target_args'_v5 = v73 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v74 : US3 = US3_1
    let v75 : US4 = US4_1(v74)
    let v76 : string = $"env.get_environment_variable / target: {v75} / var: {v0}"
    let v77 : string = failwith<string> v76
    let _run_target_args'_v5 = v77 
    #endif
#else
    let v78 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v79 : string = v78 v0
    let mutable _v79 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v81 : (string -> string option) = Option.ofObj
    let v82 : string option = v81 v79
    v82 
    #else
    Some v79 
    #endif
    |> fun x -> _v79 <- Some x
    let v83 : string option = match _v79 with Some x -> x | None -> failwith "optionm'.of_obj / _v79=None"
    let v87 : (string -> US5) = method6()
    let v88 : US5 option = v83 |> Option.map v87 
    let v101 : US5 = US5_1
    let v102 : US5 = v88 |> Option.defaultValue v101 
    let v109 : string =
        match v102 with
        | US5_1 -> (* None *)
            let v107 : string = ""
            v107
        | US5_0(v106) -> (* Some *)
            v106
    let _run_target_args'_v5 = v109 
    #endif
    let v110 : string = _run_target_args'_v5 
    v110
and method2 () : struct (US1 * US2) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = method3(v0)
    
    
    
    
    
    let v2 : bool = "Verbose" = v1
    let v6 : US1 =
        if v2 then
            let v3 : US0 = US0_0
            US1_0(v3)
        else
            US1_1
    let v47 : US1 =
        match v6 with
        | US1_1 -> (* None *)
            let v9 : bool = "Debug" = v1
            let v13 : US1 =
                if v9 then
                    let v10 : US0 = US0_1
                    US1_0(v10)
                else
                    US1_1
            match v13 with
            | US1_1 -> (* None *)
                let v16 : bool = "Info" = v1
                let v20 : US1 =
                    if v16 then
                        let v17 : US0 = US0_2
                        US1_0(v17)
                    else
                        US1_1
                match v20 with
                | US1_1 -> (* None *)
                    let v23 : bool = "Warning" = v1
                    let v27 : US1 =
                        if v23 then
                            let v24 : US0 = US0_3
                            US1_0(v24)
                        else
                            US1_1
                    match v27 with
                    | US1_1 -> (* None *)
                        let v30 : bool = "Critical" = v1
                        let v34 : US1 =
                            if v30 then
                                let v31 : US0 = US0_4
                                US1_0(v31)
                            else
                                US1_1
                        match v34 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v35) -> (* Some *)
                            US1_0(v35)
                    | US1_0(v28) -> (* Some *)
                        US1_0(v28)
                | US1_0(v21) -> (* Some *)
                    US1_0(v21)
            | US1_0(v14) -> (* Some *)
                US1_0(v14)
        | US1_0(v7) -> (* Some *)
            US1_0(v7)
    let v48 : string = "AUTOMATION"
    let v49 : string = method3(v48)
    let v52 : string = "True"
    let v53 : bool = v49 <> v52 
    let v120 : US2 =
        if v53 then
            US2_1
        else
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v59 = v60 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v61 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v63 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v59 = v66 
            #endif
#if FABLE_COMPILER_PYTHON
            let v67 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v59 = v67 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v68 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v59 = v68 
            #endif
#else
            let v69 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v59 = v69 
            #endif
            let v70 : System.DateTime = _run_target_args'_v59 
            (* run_target_args'
            let v78 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v79 : (System.DateTime -> int64) = _.Ticks
            let v80 : int64 = v79 v70
            let _run_target_args'_v78 = v80 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v81 : (System.DateTime -> int64) = _.Ticks
            let v82 : int64 = v81 v70
            let _run_target_args'_v78 = v82 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v84 : int64 = null |> unbox<int64>
            let _run_target_args'_v78 = v84 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v87 : (System.DateTime -> int64) = _.Ticks
            let v88 : int64 = v87 v70
            let _run_target_args'_v78 = v88 
            #endif
#if FABLE_COMPILER_PYTHON
            let v89 : (System.DateTime -> int64) = _.Ticks
            let v90 : int64 = v89 v70
            let _run_target_args'_v78 = v90 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v91 : (System.DateTime -> int64) = _.Ticks
            let v92 : int64 = v91 v70
            let _run_target_args'_v78 = v92 
            #endif
#else
            let v93 : (System.DateTime -> int64) = _.Ticks
            let v94 : int64 = v93 v70
            let _run_target_args'_v78 = v94 
            #endif
            let v95 : int64 = _run_target_args'_v78 
            let v116 : int64 = v95 |> int64 
            US2_0(v116)
    struct (v47, v120)
and closure4 () (v0 : string) : unit =
    ()
and method1 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    (* run_target_args'
    let v3 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v4 : US1, v5 : US2) = method2()
    let _run_target_args'_v3 = struct (v4, v5) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : US1 = US1_1
    let v7 : US2 = US2_1
    let _run_target_args'_v3 = struct (v6, v7) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "AUTOMATION"
    (* run_target_args'
    let v13 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = "option_env!(\"" + v8 + "\").unwrap_or(\"\")"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v14 
    (* run_target_args'
    let v20 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : string = "String::from($0)"
    let v22 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v21 
    let _run_target_args'_v20 = v22 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v23 : string = "String::from($0)"
    let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v23 
    let _run_target_args'_v20 = v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : string = "String::from($0)"
    let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v25 
    let _run_target_args'_v20 = v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v28 : std_string_String = v15 |> unbox<std_string_String>
    let _run_target_args'_v20 = v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : std_string_String = v15 |> unbox<std_string_String>
    let _run_target_args'_v20 = v32 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v36 : std_string_String = v15 |> unbox<std_string_String>
    let _run_target_args'_v20 = v36 
    #endif
#else
    let v40 : std_string_String = v15 |> unbox<std_string_String>
    let _run_target_args'_v20 = v40 
    #endif
    let v43 : std_string_String = _run_target_args'_v20 
    let v49 : string = "fable_library_rust::String_::fromString($0)"
    let v50 : string = Fable.Core.RustInterop.emitRustExpr v43 v49 
    let _run_target_args'_v13 = v50 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v51 : string = "option_env!(\"" + v8 + "\").unwrap_or(\"\")"
    let v52 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v51 
    (* run_target_args'
    let v57 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v58 : string = "String::from($0)"
    let v59 : std_string_String = Fable.Core.RustInterop.emitRustExpr v52 v58 
    let _run_target_args'_v57 = v59 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v60 : string = "String::from($0)"
    let v61 : std_string_String = Fable.Core.RustInterop.emitRustExpr v52 v60 
    let _run_target_args'_v57 = v61 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v62 : string = "String::from($0)"
    let v63 : std_string_String = Fable.Core.RustInterop.emitRustExpr v52 v62 
    let _run_target_args'_v57 = v63 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v65 : std_string_String = v52 |> unbox<std_string_String>
    let _run_target_args'_v57 = v65 
    #endif
#if FABLE_COMPILER_PYTHON
    let v69 : std_string_String = v52 |> unbox<std_string_String>
    let _run_target_args'_v57 = v69 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v73 : std_string_String = v52 |> unbox<std_string_String>
    let _run_target_args'_v57 = v73 
    #endif
#else
    let v77 : std_string_String = v52 |> unbox<std_string_String>
    let _run_target_args'_v57 = v77 
    #endif
    let v80 : std_string_String = _run_target_args'_v57 
    let v86 : string = "fable_library_rust::String_::fromString($0)"
    let v87 : string = Fable.Core.RustInterop.emitRustExpr v80 v86 
    let _run_target_args'_v13 = v87 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v88 : string = "option_env!(\"" + v8 + "\").unwrap_or(\"\")"
    let v89 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v88 
    (* run_target_args'
    let v94 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v95 : string = "String::from($0)"
    let v96 : std_string_String = Fable.Core.RustInterop.emitRustExpr v89 v95 
    let _run_target_args'_v94 = v96 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v97 : string = "String::from($0)"
    let v98 : std_string_String = Fable.Core.RustInterop.emitRustExpr v89 v97 
    let _run_target_args'_v94 = v98 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v99 : string = "String::from($0)"
    let v100 : std_string_String = Fable.Core.RustInterop.emitRustExpr v89 v99 
    let _run_target_args'_v94 = v100 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v102 : std_string_String = v89 |> unbox<std_string_String>
    let _run_target_args'_v94 = v102 
    #endif
#if FABLE_COMPILER_PYTHON
    let v106 : std_string_String = v89 |> unbox<std_string_String>
    let _run_target_args'_v94 = v106 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v110 : std_string_String = v89 |> unbox<std_string_String>
    let _run_target_args'_v94 = v110 
    #endif
#else
    let v114 : std_string_String = v89 |> unbox<std_string_String>
    let _run_target_args'_v94 = v114 
    #endif
    let v117 : std_string_String = _run_target_args'_v94 
    let v123 : string = "fable_library_rust::String_::fromString($0)"
    let v124 : string = Fable.Core.RustInterop.emitRustExpr v117 v123 
    let _run_target_args'_v13 = v124 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v126 : string = null |> unbox<string>
    let _run_target_args'_v13 = v126 
    #endif
#if FABLE_COMPILER_PYTHON
    let v130 : string = null |> unbox<string>
    let _run_target_args'_v13 = v130 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v134 : string = null |> unbox<string>
    let _run_target_args'_v13 = v134 
    #endif
#else
    let v138 : string = null |> unbox<string>
    let _run_target_args'_v13 = v138 
    #endif
    let v141 : string = _run_target_args'_v13 
    let v149 : string = "True"
    let v150 : bool = v141 <> v149 
    let v162 : US2 =
        if v150 then
            US2_1
        else
            let v154 : string = $"near_sdk::env::block_timestamp()"
            let v155 : uint64 = Fable.Core.RustInterop.emitRustExpr () v154 
            let v157 : (uint64 -> int64) = int64
            let v158 : int64 = v157 v155
            US2_0(v158)
    let v163 : US1 = US1_1
    let _run_target_args'_v3 = struct (v163, v162) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v164 : US1, v165 : US2) = method2()
    let _run_target_args'_v3 = struct (v164, v165) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v166 : US1, v167 : US2) = method2()
    let _run_target_args'_v3 = struct (v166, v167) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v168 : US1, v169 : US2) = method2()
    let _run_target_args'_v3 = struct (v168, v169) 
    #endif
#else
    let struct (v170 : US1, v171 : US2) = method2()
    let _run_target_args'_v3 = struct (v170, v171) 
    #endif
    let struct (v172 : US1, v173 : US2) = _run_target_args'_v3 
    let v178 : Mut0 = {l0 = 1L} : Mut0
    let v179 : (string -> unit) = closure4()
    let v180 : Mut1 = {l0 = v179} : Mut1
    let v181 : Mut2 = {l0 = true} : Mut2
    let v182 : string = ""
    let v183 : Mut3 = {l0 = v182} : Mut3
    let v186 : US0 =
        match v172 with
        | US1_1 -> (* None *)
            v0
        | US1_0(v184) -> (* Some *)
            v184
    let v187 : Mut4 = {l0 = v186} : Mut4
    let v195 : int64 option =
        match v173 with
        | US2_1 -> (* None *)
            let v193 : int64 option = None
            v193
        | US2_0(v188) -> (* Some *)
            let v190 : int64 option = Some v188 
            v190
    struct (v178, v180, v181, v183, v187, v195)
and closure2 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_2
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method1(v1)
        let v9 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v9 
        ()
and closure6 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method1(v1)
        let v9 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v9 
        ()
and method7 (v0 : US0) : bool =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v24 : Mut0, v25 : Mut1, v26 : Mut2, v27 : Mut3, v28 : Mut4, v29 : int64 option) = TraceState.trace_state.Value
    let v42 : US0 = v28.l0
    let v43 : bool = v26.l0
    let v44 : bool = v43 = false
    if v44 then
        false
    else
        let v45 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
        let v46 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v42
        let v47 : bool = v45 >= v46
        v47
and closure7 () (v0 : int64) : US2 =
    US2_0(v0)
and method9 () : (int64 -> US2) =
    closure7()
and method10 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method11 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method8 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    (* run_target_args'
    let v165 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v167 : (int64 -> US2) = method9()
    let v168 : US2 option = v5 |> Option.map v167 
    let v181 : US2 = US2_1
    let v182 : US2 = v168 |> Option.defaultValue v181 
    let v300 : System.DateTime =
        match v182 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v283 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v284 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v283 = v284 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v285 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v283 = v285 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v287 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v283 = v287 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v290 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v283 = v290 
            #endif
#if FABLE_COMPILER_PYTHON
            let v291 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v283 = v291 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v292 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v283 = v292 
            #endif
#else
            let v293 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v283 = v293 
            #endif
            let v294 : System.DateTime = _run_target_args'_v283 
            v294
        | US2_0(v186) -> (* Some *)
            (* run_target_args'
            let v189 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v190 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v189 = v190 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v191 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v189 = v191 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v189 = v193 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v196 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v189 = v196 
            #endif
#if FABLE_COMPILER_PYTHON
            let v197 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v189 = v197 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v198 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v189 = v198 
            #endif
#else
            let v199 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v189 = v199 
            #endif
            let v200 : System.DateTime = _run_target_args'_v189 
            (* run_target_args'
            let v208 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v209 : (System.DateTime -> int64) = _.Ticks
            let v210 : int64 = v209 v200
            let _run_target_args'_v208 = v210 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v211 : (System.DateTime -> int64) = _.Ticks
            let v212 : int64 = v211 v200
            let _run_target_args'_v208 = v212 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v214 : int64 = null |> unbox<int64>
            let _run_target_args'_v208 = v214 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v217 : (System.DateTime -> int64) = _.Ticks
            let v218 : int64 = v217 v200
            let _run_target_args'_v208 = v218 
            #endif
#if FABLE_COMPILER_PYTHON
            let v219 : (System.DateTime -> int64) = _.Ticks
            let v220 : int64 = v219 v200
            let _run_target_args'_v208 = v220 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v221 : (System.DateTime -> int64) = _.Ticks
            let v222 : int64 = v221 v200
            let _run_target_args'_v208 = v222 
            #endif
#else
            let v223 : (System.DateTime -> int64) = _.Ticks
            let v224 : int64 = v223 v200
            let _run_target_args'_v208 = v224 
            #endif
            let v225 : int64 = _run_target_args'_v208 
            let v246 : int64 = v225 |> int64 
            let v249 : int64 = v246 - v186
            let v252 : System.TimeSpan = v249 |> System.TimeSpan 
            let v258 : (System.TimeSpan -> int32) = _.Hours
            let v259 : int32 = v258 v252
            let v263 : (System.TimeSpan -> int32) = _.Minutes
            let v264 : int32 = v263 v252
            let v268 : (System.TimeSpan -> int32) = _.Seconds
            let v269 : int32 = v268 v252
            let v273 : (System.TimeSpan -> int32) = _.Milliseconds
            let v274 : int32 = v273 v252
            let v278 : System.DateTime = System.DateTime (1, 1, 1, v259, v264, v269, v274)
            v278
    let v302 : string = method10()
    let v306 : bool = v302 = ""
    let v308 : string =
        if v306 then
            let v307 : string = "M-d-y hh:mm:ss tt"
            v307
        else
            v302
    let v309 : (string -> string) = v300.ToString
    let v310 : string = v309 v308
    let _run_target_args'_v165 = v310 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v326 : (int64 -> US2) = method9()
    let v327 : US2 option = v5 |> Option.map v326 
    let v340 : US2 = US2_1
    let v341 : US2 = v327 |> Option.defaultValue v340 
    let v459 : System.DateTime =
        match v341 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v442 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v443 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v442 = v443 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v444 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v442 = v444 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v446 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v442 = v446 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v449 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v442 = v449 
            #endif
#if FABLE_COMPILER_PYTHON
            let v450 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v442 = v450 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v451 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v442 = v451 
            #endif
#else
            let v452 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v442 = v452 
            #endif
            let v453 : System.DateTime = _run_target_args'_v442 
            v453
        | US2_0(v345) -> (* Some *)
            (* run_target_args'
            let v348 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v349 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v348 = v349 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v350 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v348 = v350 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v352 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v348 = v352 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v355 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v348 = v355 
            #endif
#if FABLE_COMPILER_PYTHON
            let v356 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v348 = v356 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v357 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v348 = v357 
            #endif
#else
            let v358 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v348 = v358 
            #endif
            let v359 : System.DateTime = _run_target_args'_v348 
            (* run_target_args'
            let v367 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v368 : (System.DateTime -> int64) = _.Ticks
            let v369 : int64 = v368 v359
            let _run_target_args'_v367 = v369 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v370 : (System.DateTime -> int64) = _.Ticks
            let v371 : int64 = v370 v359
            let _run_target_args'_v367 = v371 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v373 : int64 = null |> unbox<int64>
            let _run_target_args'_v367 = v373 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v376 : (System.DateTime -> int64) = _.Ticks
            let v377 : int64 = v376 v359
            let _run_target_args'_v367 = v377 
            #endif
#if FABLE_COMPILER_PYTHON
            let v378 : (System.DateTime -> int64) = _.Ticks
            let v379 : int64 = v378 v359
            let _run_target_args'_v367 = v379 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v380 : (System.DateTime -> int64) = _.Ticks
            let v381 : int64 = v380 v359
            let _run_target_args'_v367 = v381 
            #endif
#else
            let v382 : (System.DateTime -> int64) = _.Ticks
            let v383 : int64 = v382 v359
            let _run_target_args'_v367 = v383 
            #endif
            let v384 : int64 = _run_target_args'_v367 
            let v405 : int64 = v384 |> int64 
            let v408 : int64 = v405 - v345
            let v411 : System.TimeSpan = v408 |> System.TimeSpan 
            let v417 : (System.TimeSpan -> int32) = _.Hours
            let v418 : int32 = v417 v411
            let v422 : (System.TimeSpan -> int32) = _.Minutes
            let v423 : int32 = v422 v411
            let v427 : (System.TimeSpan -> int32) = _.Seconds
            let v428 : int32 = v427 v411
            let v432 : (System.TimeSpan -> int32) = _.Milliseconds
            let v433 : int32 = v432 v411
            let v437 : System.DateTime = System.DateTime (1, 1, 1, v418, v423, v428, v433)
            v437
    let v461 : string = method10()
    let v465 : bool = v461 = ""
    let v467 : string =
        if v465 then
            let v466 : string = "M-d-y hh:mm:ss tt"
            v466
        else
            v461
    let v468 : (string -> string) = v459.ToString
    let v469 : string = v468 v467
    let _run_target_args'_v165 = v469 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v484 : string = $"near_sdk::env::block_timestamp()"
    let v485 : uint64 = Fable.Core.RustInterop.emitRustExpr () v484 
    let v487 : (int64 -> US2) = method9()
    let v488 : US2 option = v5 |> Option.map v487 
    let v501 : US2 = US2_1
    let v502 : US2 = v488 |> Option.defaultValue v501 
    let v514 : uint64 =
        match v502 with
        | US2_1 -> (* None *)
            v485
        | US2_0(v506) -> (* Some *)
            let v508 : (int64 -> uint64) = uint64
            let v509 : uint64 = v508 v506
            let v512 : uint64 = v485 - v509
            v512
    let v515 : uint64 = v514 / 1000000000UL
    let v516 : uint64 = v515 % 60UL
    let v517 : uint64 = v515 / 60UL
    let v518 : uint64 = v517 % 60UL
    let v519 : uint64 = v515 / 3600UL
    let v520 : uint64 = v519 % 24UL
    let v521 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v522 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v520, v518, v516) v521 
    let v523 : string = "fable_library_rust::String_::fromString($0)"
    let v524 : string = Fable.Core.RustInterop.emitRustExpr v522 v523 
    let _run_target_args'_v165 = v524 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v526 : (int64 -> US2) = method9()
    let v527 : US2 option = v5 |> Option.map v526 
    let v540 : US2 = US2_1
    let v541 : US2 = v527 |> Option.defaultValue v540 
    let v659 : System.DateTime =
        match v541 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v642 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v643 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v642 = v643 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v644 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v642 = v644 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v646 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v642 = v646 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v649 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v642 = v649 
            #endif
#if FABLE_COMPILER_PYTHON
            let v650 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v642 = v650 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v651 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v642 = v651 
            #endif
#else
            let v652 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v642 = v652 
            #endif
            let v653 : System.DateTime = _run_target_args'_v642 
            v653
        | US2_0(v545) -> (* Some *)
            (* run_target_args'
            let v548 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v549 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v548 = v549 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v550 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v548 = v550 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v552 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v548 = v552 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v555 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v548 = v555 
            #endif
#if FABLE_COMPILER_PYTHON
            let v556 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v548 = v556 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v557 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v548 = v557 
            #endif
#else
            let v558 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v548 = v558 
            #endif
            let v559 : System.DateTime = _run_target_args'_v548 
            (* run_target_args'
            let v567 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v568 : (System.DateTime -> int64) = _.Ticks
            let v569 : int64 = v568 v559
            let _run_target_args'_v567 = v569 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v570 : (System.DateTime -> int64) = _.Ticks
            let v571 : int64 = v570 v559
            let _run_target_args'_v567 = v571 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v573 : int64 = null |> unbox<int64>
            let _run_target_args'_v567 = v573 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v576 : (System.DateTime -> int64) = _.Ticks
            let v577 : int64 = v576 v559
            let _run_target_args'_v567 = v577 
            #endif
#if FABLE_COMPILER_PYTHON
            let v578 : (System.DateTime -> int64) = _.Ticks
            let v579 : int64 = v578 v559
            let _run_target_args'_v567 = v579 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v580 : (System.DateTime -> int64) = _.Ticks
            let v581 : int64 = v580 v559
            let _run_target_args'_v567 = v581 
            #endif
#else
            let v582 : (System.DateTime -> int64) = _.Ticks
            let v583 : int64 = v582 v559
            let _run_target_args'_v567 = v583 
            #endif
            let v584 : int64 = _run_target_args'_v567 
            let v605 : int64 = v584 |> int64 
            let v608 : int64 = v605 - v545
            let v611 : System.TimeSpan = v608 |> System.TimeSpan 
            let v617 : (System.TimeSpan -> int32) = _.Hours
            let v618 : int32 = v617 v611
            let v622 : (System.TimeSpan -> int32) = _.Minutes
            let v623 : int32 = v622 v611
            let v627 : (System.TimeSpan -> int32) = _.Seconds
            let v628 : int32 = v627 v611
            let v632 : (System.TimeSpan -> int32) = _.Milliseconds
            let v633 : int32 = v632 v611
            let v637 : System.DateTime = System.DateTime (1, 1, 1, v618, v623, v628, v633)
            v637
    let v661 : string = method11()
    let v665 : bool = v661 = ""
    let v667 : string =
        if v665 then
            let v666 : string = "M-d-y hh:mm:ss tt"
            v666
        else
            v661
    let v668 : (string -> string) = v659.ToString
    let v669 : string = v668 v667
    let _run_target_args'_v165 = v669 
    #endif
#if FABLE_COMPILER_PYTHON
    let v685 : (int64 -> US2) = method9()
    let v686 : US2 option = v5 |> Option.map v685 
    let v699 : US2 = US2_1
    let v700 : US2 = v686 |> Option.defaultValue v699 
    let v818 : System.DateTime =
        match v700 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v801 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v802 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v801 = v802 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v803 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v801 = v803 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v805 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v801 = v805 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v808 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v801 = v808 
            #endif
#if FABLE_COMPILER_PYTHON
            let v809 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v801 = v809 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v810 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v801 = v810 
            #endif
#else
            let v811 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v801 = v811 
            #endif
            let v812 : System.DateTime = _run_target_args'_v801 
            v812
        | US2_0(v704) -> (* Some *)
            (* run_target_args'
            let v707 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v708 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v707 = v708 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v709 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v707 = v709 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v711 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v707 = v711 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v714 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v707 = v714 
            #endif
#if FABLE_COMPILER_PYTHON
            let v715 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v707 = v715 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v716 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v707 = v716 
            #endif
#else
            let v717 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v707 = v717 
            #endif
            let v718 : System.DateTime = _run_target_args'_v707 
            (* run_target_args'
            let v726 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v727 : (System.DateTime -> int64) = _.Ticks
            let v728 : int64 = v727 v718
            let _run_target_args'_v726 = v728 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v729 : (System.DateTime -> int64) = _.Ticks
            let v730 : int64 = v729 v718
            let _run_target_args'_v726 = v730 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v732 : int64 = null |> unbox<int64>
            let _run_target_args'_v726 = v732 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v735 : (System.DateTime -> int64) = _.Ticks
            let v736 : int64 = v735 v718
            let _run_target_args'_v726 = v736 
            #endif
#if FABLE_COMPILER_PYTHON
            let v737 : (System.DateTime -> int64) = _.Ticks
            let v738 : int64 = v737 v718
            let _run_target_args'_v726 = v738 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v739 : (System.DateTime -> int64) = _.Ticks
            let v740 : int64 = v739 v718
            let _run_target_args'_v726 = v740 
            #endif
#else
            let v741 : (System.DateTime -> int64) = _.Ticks
            let v742 : int64 = v741 v718
            let _run_target_args'_v726 = v742 
            #endif
            let v743 : int64 = _run_target_args'_v726 
            let v764 : int64 = v743 |> int64 
            let v767 : int64 = v764 - v704
            let v770 : System.TimeSpan = v767 |> System.TimeSpan 
            let v776 : (System.TimeSpan -> int32) = _.Hours
            let v777 : int32 = v776 v770
            let v781 : (System.TimeSpan -> int32) = _.Minutes
            let v782 : int32 = v781 v770
            let v786 : (System.TimeSpan -> int32) = _.Seconds
            let v787 : int32 = v786 v770
            let v791 : (System.TimeSpan -> int32) = _.Milliseconds
            let v792 : int32 = v791 v770
            let v796 : System.DateTime = System.DateTime (1, 1, 1, v777, v782, v787, v792)
            v796
    let v820 : string = method11()
    let v824 : bool = v820 = ""
    let v826 : string =
        if v824 then
            let v825 : string = "M-d-y hh:mm:ss tt"
            v825
        else
            v820
    let v827 : (string -> string) = v818.ToString
    let v828 : string = v827 v826
    let _run_target_args'_v165 = v828 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v844 : (int64 -> US2) = method9()
    let v845 : US2 option = v5 |> Option.map v844 
    let v858 : US2 = US2_1
    let v859 : US2 = v845 |> Option.defaultValue v858 
    let v977 : System.DateTime =
        match v859 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v960 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v961 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v960 = v961 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v962 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v960 = v962 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v964 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v960 = v964 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v967 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v960 = v967 
            #endif
#if FABLE_COMPILER_PYTHON
            let v968 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v960 = v968 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v969 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v960 = v969 
            #endif
#else
            let v970 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v960 = v970 
            #endif
            let v971 : System.DateTime = _run_target_args'_v960 
            v971
        | US2_0(v863) -> (* Some *)
            (* run_target_args'
            let v866 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v867 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v866 = v867 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v868 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v866 = v868 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v870 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v866 = v870 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v873 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v866 = v873 
            #endif
#if FABLE_COMPILER_PYTHON
            let v874 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v866 = v874 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v875 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v866 = v875 
            #endif
#else
            let v876 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v866 = v876 
            #endif
            let v877 : System.DateTime = _run_target_args'_v866 
            (* run_target_args'
            let v885 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v886 : (System.DateTime -> int64) = _.Ticks
            let v887 : int64 = v886 v877
            let _run_target_args'_v885 = v887 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v888 : (System.DateTime -> int64) = _.Ticks
            let v889 : int64 = v888 v877
            let _run_target_args'_v885 = v889 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v891 : int64 = null |> unbox<int64>
            let _run_target_args'_v885 = v891 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v894 : (System.DateTime -> int64) = _.Ticks
            let v895 : int64 = v894 v877
            let _run_target_args'_v885 = v895 
            #endif
#if FABLE_COMPILER_PYTHON
            let v896 : (System.DateTime -> int64) = _.Ticks
            let v897 : int64 = v896 v877
            let _run_target_args'_v885 = v897 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v898 : (System.DateTime -> int64) = _.Ticks
            let v899 : int64 = v898 v877
            let _run_target_args'_v885 = v899 
            #endif
#else
            let v900 : (System.DateTime -> int64) = _.Ticks
            let v901 : int64 = v900 v877
            let _run_target_args'_v885 = v901 
            #endif
            let v902 : int64 = _run_target_args'_v885 
            let v923 : int64 = v902 |> int64 
            let v926 : int64 = v923 - v863
            let v929 : System.TimeSpan = v926 |> System.TimeSpan 
            let v935 : (System.TimeSpan -> int32) = _.Hours
            let v936 : int32 = v935 v929
            let v940 : (System.TimeSpan -> int32) = _.Minutes
            let v941 : int32 = v940 v929
            let v945 : (System.TimeSpan -> int32) = _.Seconds
            let v946 : int32 = v945 v929
            let v950 : (System.TimeSpan -> int32) = _.Milliseconds
            let v951 : int32 = v950 v929
            let v955 : System.DateTime = System.DateTime (1, 1, 1, v936, v941, v946, v951)
            v955
    let v979 : string = method11()
    let v983 : bool = v979 = ""
    let v985 : string =
        if v983 then
            let v984 : string = "M-d-y hh:mm:ss tt"
            v984
        else
            v979
    let v986 : (string -> string) = v977.ToString
    let v987 : string = v986 v985
    let _run_target_args'_v165 = v987 
    #endif
#else
    let v1003 : (int64 -> US2) = method9()
    let v1004 : US2 option = v5 |> Option.map v1003 
    let v1017 : US2 = US2_1
    let v1018 : US2 = v1004 |> Option.defaultValue v1017 
    let v1136 : System.DateTime =
        match v1018 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v1119 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1120 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1119 = v1120 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1121 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1119 = v1121 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1123 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1119 = v1123 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1126 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1119 = v1126 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1127 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1119 = v1127 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1128 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1119 = v1128 
            #endif
#else
            let v1129 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1119 = v1129 
            #endif
            let v1130 : System.DateTime = _run_target_args'_v1119 
            v1130
        | US2_0(v1022) -> (* Some *)
            (* run_target_args'
            let v1025 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1026 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1025 = v1026 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1027 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1025 = v1027 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1029 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1025 = v1029 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1032 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1025 = v1032 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1033 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1025 = v1033 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1034 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1025 = v1034 
            #endif
#else
            let v1035 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1025 = v1035 
            #endif
            let v1036 : System.DateTime = _run_target_args'_v1025 
            (* run_target_args'
            let v1044 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1045 : (System.DateTime -> int64) = _.Ticks
            let v1046 : int64 = v1045 v1036
            let _run_target_args'_v1044 = v1046 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1047 : (System.DateTime -> int64) = _.Ticks
            let v1048 : int64 = v1047 v1036
            let _run_target_args'_v1044 = v1048 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1050 : int64 = null |> unbox<int64>
            let _run_target_args'_v1044 = v1050 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1053 : (System.DateTime -> int64) = _.Ticks
            let v1054 : int64 = v1053 v1036
            let _run_target_args'_v1044 = v1054 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1055 : (System.DateTime -> int64) = _.Ticks
            let v1056 : int64 = v1055 v1036
            let _run_target_args'_v1044 = v1056 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1057 : (System.DateTime -> int64) = _.Ticks
            let v1058 : int64 = v1057 v1036
            let _run_target_args'_v1044 = v1058 
            #endif
#else
            let v1059 : (System.DateTime -> int64) = _.Ticks
            let v1060 : int64 = v1059 v1036
            let _run_target_args'_v1044 = v1060 
            #endif
            let v1061 : int64 = _run_target_args'_v1044 
            let v1082 : int64 = v1061 |> int64 
            let v1085 : int64 = v1082 - v1022
            let v1088 : System.TimeSpan = v1085 |> System.TimeSpan 
            let v1094 : (System.TimeSpan -> int32) = _.Hours
            let v1095 : int32 = v1094 v1088
            let v1099 : (System.TimeSpan -> int32) = _.Minutes
            let v1100 : int32 = v1099 v1088
            let v1104 : (System.TimeSpan -> int32) = _.Seconds
            let v1105 : int32 = v1104 v1088
            let v1109 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1110 : int32 = v1109 v1088
            let v1114 : System.DateTime = System.DateTime (1, 1, 1, v1095, v1100, v1105, v1110)
            v1114
    let v1138 : string = method11()
    let v1142 : bool = v1138 = ""
    let v1144 : string =
        if v1142 then
            let v1143 : string = "M-d-y hh:mm:ss tt"
            v1143
        else
            v1138
    let v1145 : (string -> string) = v1136.ToString
    let v1146 : string = v1145 v1144
    let _run_target_args'_v165 = v1146 
    #endif
    let v1161 : string = _run_target_args'_v165 
    v1161
and method14 () : string =
    let v0 : string = ""
    v0
and closure8 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method13 (v0 : char) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v4 : string = $"{v0}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure8(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = v2.l0
    v12
and method15 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method12 () : string =
    
    
    
    
    
    let v1 : string = "Info"
    let v2 : (unit -> string) = v1.ToLower
    let v3 : string = v2 ()
    let v6 : char = v3.[int 0]
    let v7 : string = method13(v6)
    (* run_target_args'
    let v12 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : string = "inline_colorization::color_bright_green"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v13 
    (* run_target_args'
    let v19 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "&*$0"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v20 
    let _run_target_args'_v19 = v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v22 
    let _run_target_args'_v19 = v23 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : string = "&*$0"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v24 
    let _run_target_args'_v19 = v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v27 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v31 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v35 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v35 
    #endif
#else
    let v39 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v39 
    #endif
    let v42 : Ref<Str> = _run_target_args'_v19 
    let v48 : string = "inline_colorization::color_reset"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v14, v42, v49) v50 
    let v52 : string = "fable_library_rust::String_::fromString($0)"
    let v53 : string = Fable.Core.RustInterop.emitRustExpr v51 v52 
    let _run_target_args'_v12 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "inline_colorization::color_bright_green"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v54 
    (* run_target_args'
    let v60 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v61 : string = "&*$0"
    let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v61 
    let _run_target_args'_v60 = v62 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : string = "&*$0"
    let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v63 
    let _run_target_args'_v60 = v64 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = "&*$0"
    let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v65 
    let _run_target_args'_v60 = v66 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v68 
    #endif
#if FABLE_COMPILER_PYTHON
    let v72 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v72 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v76 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v76 
    #endif
#else
    let v80 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v80 
    #endif
    let v83 : Ref<Str> = _run_target_args'_v60 
    let v89 : string = "inline_colorization::color_reset"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v55, v83, v90) v91 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let _run_target_args'_v12 = v94 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v95 : string = "inline_colorization::color_bright_green"
    let v96 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v95 
    (* run_target_args'
    let v101 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v102 : string = "&*$0"
    let v103 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v102 
    let _run_target_args'_v101 = v103 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : string = "&*$0"
    let v105 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v104 
    let _run_target_args'_v101 = v105 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v106 : string = "&*$0"
    let v107 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v106 
    let _run_target_args'_v101 = v107 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v109 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v109 
    #endif
#if FABLE_COMPILER_PYTHON
    let v113 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v113 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v117 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v117 
    #endif
#else
    let v121 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v121 
    #endif
    let v124 : Ref<Str> = _run_target_args'_v101 
    let v130 : string = "inline_colorization::color_reset"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v96, v124, v131) v132 
    let v134 : string = "fable_library_rust::String_::fromString($0)"
    let v135 : string = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let _run_target_args'_v12 = v135 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v136 : string = "\u001b[92m"
    let v137 : string = method15()
    let v138 : string = v136 + v7 
    let v139 : string = v138 + v137 
    let _run_target_args'_v12 = v139 
    #endif
#if FABLE_COMPILER_PYTHON
    let v140 : string = "\u001b[92m"
    let v141 : string = method15()
    let v142 : string = v140 + v7 
    let v143 : string = v142 + v141 
    let _run_target_args'_v12 = v143 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v144 : string = "\u001b[92m"
    let v145 : string = method15()
    let v146 : string = v144 + v7 
    let v147 : string = v146 + v145 
    let _run_target_args'_v12 = v147 
    #endif
#else
    let v148 : string = "\u001b[92m"
    let v149 : string = method15()
    let v150 : string = v148 + v7 
    let v151 : string = v150 + v149 
    let _run_target_args'_v12 = v151 
    #endif
    let v152 : string = _run_target_args'_v12 
    v152
and method17 (v0 : (string [])) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v2, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v14 : string = "args"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure8(v2, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure8(v2, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v34 : string = $"%A{v0}"
    let v38 : string = $"{v34}"
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure8(v2, v38)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v47 : string = " }"
    let v48 : string = $"{v47}"
    let v51 : unit = ()
    let v52 : (unit -> unit) = closure8(v2, v48)
    let v53 : unit = (fun () -> v52 (); v51) ()
    let v56 : string = v2.l0
    v56
and method18 (v0 : string) : string =
    let v1 : char list = []
    let v4 : (char list -> (char [])) = List.toArray
    let v5 : (char []) = v4 v1
    let v8 : string = v0.TrimStart v5 
    let v37 : char list = []
    let v39 : char list = '/' :: v37 
    let v43 : char list = ' ' :: v39 
    let v48 : (char list -> (char [])) = List.toArray
    let v49 : (char []) = v48 v43
    let v52 : string = v8.TrimEnd v49 
    v52
and method16 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : (string [])) : string =
    let v9 : string = method17(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "documents.main"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method18(v13)
and closure9 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure11 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure10 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure11(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and method19 (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v24 : Mut0, v25 : Mut1, v26 : Mut2, v27 : Mut3, v28 : Mut4, v29 : int64 option) = TraceState.trace_state.Value
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure9(v24)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v47 : (string -> unit) = closure10()
    (* run_target_args'
    let v48 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v49 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v49 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v50 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v50 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v51 : string = v27.l0
    let v52 : bool = v51 = ""
    let v60 : string =
        if v52 then
            v0
        else
            let v53 : bool = v0 = ""
            if v53 then
                let v54 : string = v27.l0
                v54
            else
                let v55 : string = v27.l0
                let v56 : string = "\n"
                let v57 : string = v55 + v56 
                let v58 : string = v57 + v0 
                v58
    (* run_target_args'
    let v65 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v66 : string = "&*$0"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v66 
    let _run_target_args'_v65 = v67 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v68 : string = "&*$0"
    let v69 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v68 
    let _run_target_args'_v65 = v69 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v70 : string = "&*$0"
    let v71 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v70 
    let _run_target_args'_v65 = v71 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v73 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v73 
    #endif
#if FABLE_COMPILER_PYTHON
    let v77 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v77 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v81 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v81 
    #endif
#else
    let v85 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v85 
    #endif
    let v88 : Ref<Str> = _run_target_args'_v65 
    let v94 : string = $"$0.chars()"
    let v95 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v88 v94 
    let v96 : string = "$0"
    let v97 : _ = Fable.Core.RustInterop.emitRustExpr v95 v96 
    let v98 : string = "$0.collect::<Vec<_>>()"
    let v99 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v97 v98 
    let v100 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v101 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v99 v100 
    let v102 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v103 : bool = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let v104 : string = "x"
    let v105 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v104 
    let v106 : string = "String::from_iter($0)"
    let v107 : std_string_String = Fable.Core.RustInterop.emitRustExpr v105 v106 
    let v108 : string = "true; $0 }).collect::<Vec<_>>()"
    let v109 : bool = Fable.Core.RustInterop.emitRustExpr v107 v108 
    let v110 : string = "_vec_map"
    let v111 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v110 
    let v112 : string = "$0.len()"
    let v113 : unativeint = Fable.Core.RustInterop.emitRustExpr v111 v112 
    let v119 : int32 = v113 |> int32 
    let v129 : string = ""
    let v130 : bool = v0 <> v129 
    let v134 : bool =
        if v130 then
            let v133 : bool = v119 <= 1
            v133
        else
            false
    if v134 then
        v27.l0 <- v60
        ()
    else
        v27.l0 <- v129
        let v135 : string = "true; $0.into_iter().for_each(|x| { //"
        let v136 : bool = Fable.Core.RustInterop.emitRustExpr v111 v135 
        let v137 : string = "x"
        let v138 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v137 
        let v139 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v140 : bool = Fable.Core.RustInterop.emitRustExpr v138 v139 
        let v141 : string = $"true"
        let v142 : bool = Fable.Core.RustInterop.emitRustExpr () v141 
        let v143 : string = "true; }); //"
        let v144 : bool = Fable.Core.RustInterop.emitRustExpr () v143 
        ()
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v47 v0
    #endif
#if FABLE_COMPILER_PYTHON
    v47 v0
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v47 v0
    #endif
#else
    v47 v0
    #endif
    // run_target_args' is_unit
    let v145 : (string -> unit) = v25.l0
    v145 v0
and closure5 (v0 : (string [])) () : unit =
    let v1 : US0 = US0_2
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method12()
        let v46 : string = method16(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method19(v46)
and method20 () : string =
    let v0 : string = "source-dir"
    v0
and closure12 () (v0 : std_string_String) : US6 =
    US6_0(v0)
and method21 () : (std_string_String -> US6) =
    closure12()
and method22 () : string =
    let v0 : string = "dist-dir"
    v0
and method23 () : string =
    let v0 : string = "cache-dir"
    v0
and method24 () : string =
    let v0 : string = "hangul-spec"
    v0
and method26 () : string =
    (* run_target_args'
    let v4 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = "std::env::current_dir()"
    let v6 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v5 
    (* run_target_args'
    let v8 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : string = "$0.unwrap()"
    let v10 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v6 v9 
    let _run_target_args'_v8 = v10 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : string = "$0.unwrap()"
    let v12 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v6 v11 
    let _run_target_args'_v8 = v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v13 : string = "$0.unwrap()"
    let v14 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v6 v13 
    let _run_target_args'_v8 = v14 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : std_path_PathBuf = match v6 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v8 = v15 
    #endif
#if FABLE_COMPILER_PYTHON
    let v16 : std_path_PathBuf = match v6 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v8 = v16 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : std_path_PathBuf = match v6 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v8 = v17 
    #endif
#else
    let v18 : std_path_PathBuf = match v6 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v8 = v18 
    #endif
    let v19 : std_path_PathBuf = _run_target_args'_v8 
    (* run_target_args'
    let v26 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = "$0.display()"
    let v28 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v19 v27 
    let _run_target_args'_v26 = v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "$0.display()"
    let v30 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v19 v29 
    let _run_target_args'_v26 = v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = "$0.display()"
    let v32 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v19 v31 
    let _run_target_args'_v26 = v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v34 : std_path_Display = v19 |> unbox<std_path_Display>
    let _run_target_args'_v26 = v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v38 : std_path_Display = v19 |> unbox<std_path_Display>
    let _run_target_args'_v26 = v38 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v42 : std_path_Display = v19 |> unbox<std_path_Display>
    let _run_target_args'_v26 = v42 
    #endif
#else
    let v46 : std_path_Display = v19 |> unbox<std_path_Display>
    let _run_target_args'_v26 = v46 
    #endif
    let v49 : std_path_Display = _run_target_args'_v26 
    (* run_target_args'
    let v59 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v60 : string = "format!(\"{}\", $0)"
    let v61 : std_string_String = Fable.Core.RustInterop.emitRustExpr v49 v60 
    let _run_target_args'_v59 = v61 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v62 : string = "format!(\"{}\", $0)"
    let v63 : std_string_String = Fable.Core.RustInterop.emitRustExpr v49 v62 
    let _run_target_args'_v59 = v63 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v64 : string = "format!(\"{}\", $0)"
    let v65 : std_string_String = Fable.Core.RustInterop.emitRustExpr v49 v64 
    let _run_target_args'_v59 = v65 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v67 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v59 = v67 
    #endif
#if FABLE_COMPILER_PYTHON
    let v71 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v59 = v71 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v75 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v59 = v75 
    #endif
#else
    let v79 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v59 = v79 
    #endif
    let v82 : std_string_String = _run_target_args'_v59 
    let v88 : string = "fable_library_rust::String_::fromString($0)"
    let v89 : string = Fable.Core.RustInterop.emitRustExpr v82 v88 
    let _run_target_args'_v4 = v89 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v91 : string = null |> unbox<string>
    let _run_target_args'_v4 = v91 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v95 : string = null |> unbox<string>
    let _run_target_args'_v4 = v95 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v98 : string = "fs"
    let v99 : IFs = Fable.Core.JsInterop.importAll v98 
    let v100 : string = "fs.realpathSync('.')"
    let v101 : string = Fable.Core.JsInterop.emitJsExpr () v100 
    let _run_target_args'_v4 = v101 
    #endif
#if FABLE_COMPILER_PYTHON
    let v103 : string = null |> unbox<string>
    let _run_target_args'_v4 = v103 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v107 : string = null |> unbox<string>
    let _run_target_args'_v4 = v107 
    #endif
#else
    let v110 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v111 : string = v110 ()
    let _run_target_args'_v4 = v111 
    #endif
    let v112 : string = _run_target_args'_v4 
    v112
and method28 (v0 : string, v1 : string) : string =
    (* run_target_args'
    let v6 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    (* run_target_args'
    let v11 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12 : string = "&*$0"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v12 
    let _run_target_args'_v11 = v13 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v14 : string = "&*$0"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v14 
    let _run_target_args'_v11 = v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : string = "&*$0"
    let v17 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v16 
    let _run_target_args'_v11 = v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v11 = v19 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v11 = v23 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v27 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v11 = v27 
    #endif
#else
    let v31 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v11 = v31 
    #endif
    let v34 : Ref<Str> = _run_target_args'_v11 
    (* run_target_args'
    let v44 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v45 : string = "String::from($0)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr v34 v45 
    let _run_target_args'_v44 = v46 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : string = "String::from($0)"
    let v48 : std_string_String = Fable.Core.RustInterop.emitRustExpr v34 v47 
    let _run_target_args'_v44 = v48 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v49 : string = "String::from($0)"
    let v50 : std_string_String = Fable.Core.RustInterop.emitRustExpr v34 v49 
    let _run_target_args'_v44 = v50 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v52 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v44 = v52 
    #endif
#if FABLE_COMPILER_PYTHON
    let v56 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v44 = v56 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v60 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v44 = v60 
    #endif
#else
    let v64 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v44 = v64 
    #endif
    let v67 : std_string_String = _run_target_args'_v44 
    (* run_target_args'
    let v77 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v78 : string = "std::path::PathBuf::from($0)"
    let v79 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v67 v78 
    let _run_target_args'_v77 = v79 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v80 : string = "std::path::PathBuf::from($0)"
    let v81 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v67 v80 
    let _run_target_args'_v77 = v81 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v82 : string = "std::path::PathBuf::from($0)"
    let v83 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v67 v82 
    let _run_target_args'_v77 = v83 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v85 : std_path_PathBuf = v67 |> unbox<std_path_PathBuf>
    let _run_target_args'_v77 = v85 
    #endif
#if FABLE_COMPILER_PYTHON
    let v89 : std_path_PathBuf = v67 |> unbox<std_path_PathBuf>
    let _run_target_args'_v77 = v89 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v93 : std_path_PathBuf = v67 |> unbox<std_path_PathBuf>
    let _run_target_args'_v77 = v93 
    #endif
#else
    let v97 : std_path_PathBuf = v67 |> unbox<std_path_PathBuf>
    let _run_target_args'_v77 = v97 
    #endif
    let v100 : std_path_PathBuf = _run_target_args'_v77 
    (* run_target_args'
    let v110 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v111 : string = "&*$0"
    let v112 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v111 
    let _run_target_args'_v110 = v112 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v113 : string = "&*$0"
    let v114 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v113 
    let _run_target_args'_v110 = v114 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v115 : string = "&*$0"
    let v116 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v115 
    let _run_target_args'_v110 = v116 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v118 : Ref<Str> = v1 |> unbox<Ref<Str>>
    let _run_target_args'_v110 = v118 
    #endif
#if FABLE_COMPILER_PYTHON
    let v122 : Ref<Str> = v1 |> unbox<Ref<Str>>
    let _run_target_args'_v110 = v122 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v126 : Ref<Str> = v1 |> unbox<Ref<Str>>
    let _run_target_args'_v110 = v126 
    #endif
#else
    let v130 : Ref<Str> = v1 |> unbox<Ref<Str>>
    let _run_target_args'_v110 = v130 
    #endif
    let v133 : Ref<Str> = _run_target_args'_v110 
    (* run_target_args'
    let v143 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v144 : string = "String::from($0)"
    let v145 : std_string_String = Fable.Core.RustInterop.emitRustExpr v133 v144 
    let _run_target_args'_v143 = v145 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v146 : string = "String::from($0)"
    let v147 : std_string_String = Fable.Core.RustInterop.emitRustExpr v133 v146 
    let _run_target_args'_v143 = v147 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v148 : string = "String::from($0)"
    let v149 : std_string_String = Fable.Core.RustInterop.emitRustExpr v133 v148 
    let _run_target_args'_v143 = v149 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v151 : std_string_String = v133 |> unbox<std_string_String>
    let _run_target_args'_v143 = v151 
    #endif
#if FABLE_COMPILER_PYTHON
    let v155 : std_string_String = v133 |> unbox<std_string_String>
    let _run_target_args'_v143 = v155 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v159 : std_string_String = v133 |> unbox<std_string_String>
    let _run_target_args'_v143 = v159 
    #endif
#else
    let v163 : std_string_String = v133 |> unbox<std_string_String>
    let _run_target_args'_v143 = v163 
    #endif
    let v166 : std_string_String = _run_target_args'_v143 
    let v172 : string = "$0.join($1)"
    let v173 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v100, v166) v172 
    (* run_target_args'
    let v178 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v179 : string = "$0.display()"
    let v180 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v173 v179 
    let _run_target_args'_v178 = v180 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v181 : string = "$0.display()"
    let v182 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v173 v181 
    let _run_target_args'_v178 = v182 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v183 : string = "$0.display()"
    let v184 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v173 v183 
    let _run_target_args'_v178 = v184 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v186 : std_path_Display = v173 |> unbox<std_path_Display>
    let _run_target_args'_v178 = v186 
    #endif
#if FABLE_COMPILER_PYTHON
    let v190 : std_path_Display = v173 |> unbox<std_path_Display>
    let _run_target_args'_v178 = v190 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v194 : std_path_Display = v173 |> unbox<std_path_Display>
    let _run_target_args'_v178 = v194 
    #endif
#else
    let v198 : std_path_Display = v173 |> unbox<std_path_Display>
    let _run_target_args'_v178 = v198 
    #endif
    let v201 : std_path_Display = _run_target_args'_v178 
    (* run_target_args'
    let v211 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v212 : string = "format!(\"{}\", $0)"
    let v213 : std_string_String = Fable.Core.RustInterop.emitRustExpr v201 v212 
    let _run_target_args'_v211 = v213 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v214 : string = "format!(\"{}\", $0)"
    let v215 : std_string_String = Fable.Core.RustInterop.emitRustExpr v201 v214 
    let _run_target_args'_v211 = v215 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v216 : string = "format!(\"{}\", $0)"
    let v217 : std_string_String = Fable.Core.RustInterop.emitRustExpr v201 v216 
    let _run_target_args'_v211 = v217 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v219 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v211 = v219 
    #endif
#if FABLE_COMPILER_PYTHON
    let v223 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v211 = v223 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v227 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v211 = v227 
    #endif
#else
    let v231 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v211 = v231 
    #endif
    let v234 : std_string_String = _run_target_args'_v211 
    let v240 : string = "fable_library_rust::String_::fromString($0)"
    let v241 : string = Fable.Core.RustInterop.emitRustExpr v234 v240 
    let _run_target_args'_v6 = v241 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v242 : US3 = US3_1
    let v243 : US4 = US4_3(v242)
    let v244 : string = $"file_system.(</>) / target: {v243} / a: {v0} / b: {v1}"
    let v245 : string = failwith<string> v244
    let _run_target_args'_v6 = v245 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v247 : string = null |> unbox<string>
    let _run_target_args'_v6 = v247 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v250 : string = "path"
    let v251 : IPathJoin = Fable.Core.JsInterop.importAll v250 
    let v252 : string = "v251.join($0, $1)"
    let v253 : string = Fable.Core.JsInterop.emitJsExpr struct (v0, v1) v252 
    let _run_target_args'_v6 = v253 
    #endif
#if FABLE_COMPILER_PYTHON
    let v254 : US3 = US3_0
    let v255 : US4 = US4_5(v254)
    let v256 : string = $"file_system.(</>) / target: {v255} / a: {v0} / b: {v1}"
    let v257 : string = failwith<string> v256
    let _run_target_args'_v6 = v257 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v258 : US3 = US3_1
    let v259 : US4 = US4_1(v258)
    let v260 : string = $"file_system.(</>) / target: {v259} / a: {v0} / b: {v1}"
    let v261 : string = failwith<string> v260
    let _run_target_args'_v6 = v261 
    #endif
#else
    let v262 : string = System.IO.Path.Combine (v0, v1)
    let _run_target_args'_v6 = v262 
    #endif
    let v263 : string = _run_target_args'_v6 
    v263
and method30 (v0 : string) : bool =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    (* run_target_args'
    let v10 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v11 
    let _run_target_args'_v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v13 
    let _run_target_args'_v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v15 
    let _run_target_args'_v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v18 
    #endif
#if FABLE_COMPILER_PYTHON
    let v22 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v22 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v26 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v26 
    #endif
#else
    let v30 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v30 
    #endif
    let v33 : Ref<Str> = _run_target_args'_v10 
    (* run_target_args'
    let v43 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v44 : string = "String::from($0)"
    let v45 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v44 
    let _run_target_args'_v43 = v45 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v46 : string = "String::from($0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v46 
    let _run_target_args'_v43 = v47 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v48 : string = "String::from($0)"
    let v49 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v48 
    let _run_target_args'_v43 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v51 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v51 
    #endif
#if FABLE_COMPILER_PYTHON
    let v55 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v55 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v59 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v59 
    #endif
#else
    let v63 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v63 
    #endif
    let v66 : std_string_String = _run_target_args'_v43 
    (* run_target_args'
    let v76 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v77 : string = "std::path::PathBuf::from($0)"
    let v78 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v77 
    let _run_target_args'_v76 = v78 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v79 : string = "std::path::PathBuf::from($0)"
    let v80 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v79 
    let _run_target_args'_v76 = v80 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : string = "std::path::PathBuf::from($0)"
    let v82 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v81 
    let _run_target_args'_v76 = v82 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v84 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v84 
    #endif
#if FABLE_COMPILER_PYTHON
    let v88 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v88 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v92 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v92 
    #endif
#else
    let v96 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v96 
    #endif
    let v99 : std_path_PathBuf = _run_target_args'_v76 
    let v105 : string = "$0.exists()"
    let v106 : bool = Fable.Core.RustInterop.emitRustExpr v99 v105 
    let v109 : bool =
        if v106 then
            let v107 : string = "$0.is_file()"
            let v108 : bool = Fable.Core.RustInterop.emitRustExpr v99 v107 
            v108
        else
            false
    let _run_target_args'_v5 = v109 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v111 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v111 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v115 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v115 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v118 : string = "fs"
    let v119 : IFsExistsSync = Fable.Core.JsInterop.importAll v118 
    let v120 : string = "$0.existsSync($1)"
    let v121 : bool = Fable.Core.JsInterop.emitJsExpr struct (v119, v0) v120 
    let _run_target_args'_v5 = v121 
    #endif
#if FABLE_COMPILER_PYTHON
    let v123 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v123 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v127 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v127 
    #endif
#else
    let v130 : (string -> bool) = System.IO.File.Exists
    let v131 : bool = v130 v0
    let _run_target_args'_v5 = v131 
    #endif
    let v132 : bool = _run_target_args'_v5 
    v132
and closure13 () (v0 : string) : bool =
    method30(v0)
and method31 (v0 : string) : bool =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    (* run_target_args'
    let v10 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v11 
    let _run_target_args'_v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v13 
    let _run_target_args'_v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v15 
    let _run_target_args'_v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v18 
    #endif
#if FABLE_COMPILER_PYTHON
    let v22 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v22 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v26 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v26 
    #endif
#else
    let v30 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v30 
    #endif
    let v33 : Ref<Str> = _run_target_args'_v10 
    (* run_target_args'
    let v43 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v44 : string = "String::from($0)"
    let v45 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v44 
    let _run_target_args'_v43 = v45 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v46 : string = "String::from($0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v46 
    let _run_target_args'_v43 = v47 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v48 : string = "String::from($0)"
    let v49 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v48 
    let _run_target_args'_v43 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v51 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v51 
    #endif
#if FABLE_COMPILER_PYTHON
    let v55 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v55 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v59 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v59 
    #endif
#else
    let v63 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v63 
    #endif
    let v66 : std_string_String = _run_target_args'_v43 
    (* run_target_args'
    let v76 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v77 : string = "std::path::PathBuf::from($0)"
    let v78 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v77 
    let _run_target_args'_v76 = v78 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v79 : string = "std::path::PathBuf::from($0)"
    let v80 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v79 
    let _run_target_args'_v76 = v80 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : string = "std::path::PathBuf::from($0)"
    let v82 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v81 
    let _run_target_args'_v76 = v82 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v84 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v84 
    #endif
#if FABLE_COMPILER_PYTHON
    let v88 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v88 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v92 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v92 
    #endif
#else
    let v96 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v96 
    #endif
    let v99 : std_path_PathBuf = _run_target_args'_v76 
    let v105 : string = "$0.exists()"
    let v106 : bool = Fable.Core.RustInterop.emitRustExpr v99 v105 
    let v109 : bool =
        if v106 then
            let v107 : string = "$0.is_dir()"
            let v108 : bool = Fable.Core.RustInterop.emitRustExpr v99 v107 
            v108
        else
            false
    let _run_target_args'_v5 = v109 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v111 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v111 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v115 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v115 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v118 : string = "fs"
    let v119 : IFsExistsSync = Fable.Core.JsInterop.importAll v118 
    let v120 : string = "$0.existsSync($1)"
    let v121 : bool = Fable.Core.JsInterop.emitJsExpr struct (v119, v0) v120 
    let _run_target_args'_v5 = v121 
    #endif
#if FABLE_COMPILER_PYTHON
    let v123 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v123 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v127 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v127 
    #endif
#else
    let v130 : (string -> bool) = System.IO.Directory.Exists
    let v131 : bool = v130 v0
    let _run_target_args'_v5 = v131 
    #endif
    let v132 : bool = _run_target_args'_v5 
    v132
and closure14 () (v0 : string) : bool =
    method31(v0)
and method33 (v0 : string) : string option =
    (* run_target_args'
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    (* run_target_args'
    let v7 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "&*$0"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v8 
    let _run_target_args'_v7 = v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : string = "&*$0"
    let v11 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v10 
    let _run_target_args'_v7 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : string = "&*$0"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v12 
    let _run_target_args'_v7 = v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v7 = v15 
    #endif
#if FABLE_COMPILER_PYTHON
    let v19 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v7 = v19 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v7 = v23 
    #endif
#else
    let v27 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v7 = v27 
    #endif
    let v30 : Ref<Str> = _run_target_args'_v7 
    (* run_target_args'
    let v40 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v41 : string = "String::from($0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v30 v41 
    let _run_target_args'_v40 = v42 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v43 : string = "String::from($0)"
    let v44 : std_string_String = Fable.Core.RustInterop.emitRustExpr v30 v43 
    let _run_target_args'_v40 = v44 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v45 : string = "String::from($0)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr v30 v45 
    let _run_target_args'_v40 = v46 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v48 : std_string_String = v30 |> unbox<std_string_String>
    let _run_target_args'_v40 = v48 
    #endif
#if FABLE_COMPILER_PYTHON
    let v52 : std_string_String = v30 |> unbox<std_string_String>
    let _run_target_args'_v40 = v52 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v56 : std_string_String = v30 |> unbox<std_string_String>
    let _run_target_args'_v40 = v56 
    #endif
#else
    let v60 : std_string_String = v30 |> unbox<std_string_String>
    let _run_target_args'_v40 = v60 
    #endif
    let v63 : std_string_String = _run_target_args'_v40 
    (* run_target_args'
    let v73 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v74 : string = "std::path::PathBuf::from($0)"
    let v75 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v63 v74 
    let _run_target_args'_v73 = v75 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v76 : string = "std::path::PathBuf::from($0)"
    let v77 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v63 v76 
    let _run_target_args'_v73 = v77 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v78 : string = "std::path::PathBuf::from($0)"
    let v79 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v63 v78 
    let _run_target_args'_v73 = v79 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : std_path_PathBuf = v63 |> unbox<std_path_PathBuf>
    let _run_target_args'_v73 = v81 
    #endif
#if FABLE_COMPILER_PYTHON
    let v85 : std_path_PathBuf = v63 |> unbox<std_path_PathBuf>
    let _run_target_args'_v73 = v85 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v89 : std_path_PathBuf = v63 |> unbox<std_path_PathBuf>
    let _run_target_args'_v73 = v89 
    #endif
#else
    let v93 : std_path_PathBuf = v63 |> unbox<std_path_PathBuf>
    let _run_target_args'_v73 = v93 
    #endif
    let v96 : std_path_PathBuf = _run_target_args'_v73 
    let v102 : string = "$0.parent().map(std::path::PathBuf::from)"
    let v103 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v96 v102 
    let v104 : string = "true; let _optionm_map_ = $0.map(|x| { //"
    let v105 : bool = Fable.Core.RustInterop.emitRustExpr v103 v104 
    let v106 : string = "x"
    let v107 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v106 
    (* run_target_args'
    let v112 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v113 : string = "$0.display()"
    let v114 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v107 v113 
    let _run_target_args'_v112 = v114 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v115 : string = "$0.display()"
    let v116 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v107 v115 
    let _run_target_args'_v112 = v116 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v117 : string = "$0.display()"
    let v118 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v107 v117 
    let _run_target_args'_v112 = v118 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v120 : std_path_Display = v107 |> unbox<std_path_Display>
    let _run_target_args'_v112 = v120 
    #endif
#if FABLE_COMPILER_PYTHON
    let v124 : std_path_Display = v107 |> unbox<std_path_Display>
    let _run_target_args'_v112 = v124 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v128 : std_path_Display = v107 |> unbox<std_path_Display>
    let _run_target_args'_v112 = v128 
    #endif
#else
    let v132 : std_path_Display = v107 |> unbox<std_path_Display>
    let _run_target_args'_v112 = v132 
    #endif
    let v135 : std_path_Display = _run_target_args'_v112 
    (* run_target_args'
    let v145 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v146 : string = "format!(\"{}\", $0)"
    let v147 : std_string_String = Fable.Core.RustInterop.emitRustExpr v135 v146 
    let _run_target_args'_v145 = v147 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v148 : string = "format!(\"{}\", $0)"
    let v149 : std_string_String = Fable.Core.RustInterop.emitRustExpr v135 v148 
    let _run_target_args'_v145 = v149 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v150 : string = "format!(\"{}\", $0)"
    let v151 : std_string_String = Fable.Core.RustInterop.emitRustExpr v135 v150 
    let _run_target_args'_v145 = v151 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v153 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v145 = v153 
    #endif
#if FABLE_COMPILER_PYTHON
    let v157 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v145 = v157 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v161 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v145 = v161 
    #endif
#else
    let v165 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v145 = v165 
    #endif
    let v168 : std_string_String = _run_target_args'_v145 
    let v174 : string = "fable_library_rust::String_::fromString($0)"
    let v175 : string = Fable.Core.RustInterop.emitRustExpr v168 v174 
    let v176 : string = "true; $0 })"
    let v177 : bool = Fable.Core.RustInterop.emitRustExpr v175 v176 
    let v178 : string = "_optionm_map_"
    let v179 : string option = Fable.Core.RustInterop.emitRustExpr () v178 
    let _run_target_args'_v2 = v179 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v180 : string option = None
    let _run_target_args'_v2 = v180 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v181 : string option = None
    let _run_target_args'_v2 = v181 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v182 : string = "path"
    let v183 : IPathDirname = Fable.Core.JsInterop.importAll v182 
    let v184 : string = "v183.dirname($0)"
    let v185 : string = Fable.Core.JsInterop.emitJsExpr v0 v184 
    let v186 : bool = v185 = v0
    let v189 : US5 =
        if v186 then
            US5_1
        else
            US5_0(v185)
    let v197 : string option =
        match v189 with
        | US5_1 -> (* None *)
            let v195 : string option = None
            v195
        | US5_0(v190) -> (* Some *)
            let v192 : string option = Some v190 
            v192
    let _run_target_args'_v2 = v197 
    #endif
#if FABLE_COMPILER_PYTHON
    let v198 : string option = None
    let _run_target_args'_v2 = v198 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v199 : string option = None
    let _run_target_args'_v2 = v199 
    #endif
#else
    let v200 : (string -> System_IO_DirectoryInfo) = System.IO.Directory.GetParent
    let v201 : System_IO_DirectoryInfo = v200 v0
    let v203 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let v207 : bool = v201 = v203 
    let v249 : US5 =
        if v207 then
            US5_1
        else
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v217 : string = null |> unbox<string>
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v221 : string = null |> unbox<string>
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v225 : string = null |> unbox<string>
            let _run_target_args'_v215 = v225 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v229 : string = null |> unbox<string>
            let _run_target_args'_v215 = v229 
            #endif
#if FABLE_COMPILER_PYTHON
            let v233 : string = null |> unbox<string>
            let _run_target_args'_v215 = v233 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v237 : string = null |> unbox<string>
            let _run_target_args'_v215 = v237 
            #endif
#else
            let v240 : (System_IO_DirectoryInfo -> string) = _.FullName
            let v241 : string = v240 v201
            let _run_target_args'_v215 = v241 
            #endif
            let v242 : string = _run_target_args'_v215 
            US5_0(v242)
    let v257 : string option =
        match v249 with
        | US5_1 -> (* None *)
            let v255 : string option = None
            v255
        | US5_0(v250) -> (* Some *)
            let v252 : string option = Some v250 
            v252
    let _run_target_args'_v2 = v257 
    #endif
    let v258 : string option = _run_target_args'_v2 
    v258
and method34 (v0 : string, v1 : string, v2 : bool, v3 : (string -> bool), v4 : string) : US8 =
    let v5 : string = method28(v4, v0)
    let v6 : bool = v3 v5
    if v6 then
        US8_0(v4)
    else
        let v8 : string option = method33(v4)
        let v10 : (string -> US5) = method6()
        let v11 : US5 option = v8 |> Option.map v10 
        let v24 : US5 = US5_1
        let v25 : US5 = v11 |> Option.defaultValue v24 
        match v25 with
        | US5_1 -> (* None *)
            let v31 : string = $"""file_system.find_parent / No parent for {if v2 then "file" else "dir"}"""
            let v32 : string = $" '{v0}' at '{v1}' (until '{v4}')"
            let v33 : string = v31 + v32 
            US8_1(v33)
        | US5_0(v29) -> (* Some *)
            method34(v0, v1, v2, v3, v29)
and method32 (v0 : string, v1 : string, v2 : bool, v3 : (string -> bool)) : US8 =
    let v4 : string = method28(v1, v0)
    let v5 : bool = v3 v4
    if v5 then
        US8_0(v1)
    else
        let v7 : string option = method33(v1)
        let v9 : (string -> US5) = method6()
        let v10 : US5 option = v7 |> Option.map v9 
        let v23 : US5 = US5_1
        let v24 : US5 = v10 |> Option.defaultValue v23 
        match v24 with
        | US5_1 -> (* None *)
            let v30 : string = $"""file_system.find_parent / No parent for {if v2 then "file" else "dir"}"""
            let v31 : string = $" '{v0}' at '{v1}' (until '{v1}')"
            let v32 : string = v30 + v31 
            US8_1(v32)
        | US5_0(v28) -> (* Some *)
            method34(v0, v1, v2, v3, v28)
and method29 (v0 : US7, v1 : string, v2 : string) : US8 =
    let v3 : bool =
        match v0 with
        | US7_0 -> (* File *)
            true
        | _ ->
            false
    let v6 : (string -> bool) =
        if v3 then
            closure13()
        else
            closure14()
    method32(v1, v2, v3, v6)
and method35 () : string =
    
    
    
    
    
    let v1 : string = "Warning"
    let v2 : (unit -> string) = v1.ToLower
    let v3 : string = v2 ()
    let v6 : char = v3.[int 0]
    let v7 : string = method13(v6)
    (* run_target_args'
    let v12 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : string = "inline_colorization::color_yellow"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v13 
    (* run_target_args'
    let v19 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "&*$0"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v20 
    let _run_target_args'_v19 = v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v22 
    let _run_target_args'_v19 = v23 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : string = "&*$0"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v24 
    let _run_target_args'_v19 = v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v27 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v31 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v35 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v35 
    #endif
#else
    let v39 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v39 
    #endif
    let v42 : Ref<Str> = _run_target_args'_v19 
    let v48 : string = "inline_colorization::color_reset"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v14, v42, v49) v50 
    let v52 : string = "fable_library_rust::String_::fromString($0)"
    let v53 : string = Fable.Core.RustInterop.emitRustExpr v51 v52 
    let _run_target_args'_v12 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "inline_colorization::color_yellow"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v54 
    (* run_target_args'
    let v60 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v61 : string = "&*$0"
    let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v61 
    let _run_target_args'_v60 = v62 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : string = "&*$0"
    let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v63 
    let _run_target_args'_v60 = v64 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = "&*$0"
    let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v65 
    let _run_target_args'_v60 = v66 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v68 
    #endif
#if FABLE_COMPILER_PYTHON
    let v72 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v72 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v76 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v76 
    #endif
#else
    let v80 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v80 
    #endif
    let v83 : Ref<Str> = _run_target_args'_v60 
    let v89 : string = "inline_colorization::color_reset"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v55, v83, v90) v91 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let _run_target_args'_v12 = v94 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v95 : string = "inline_colorization::color_yellow"
    let v96 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v95 
    (* run_target_args'
    let v101 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v102 : string = "&*$0"
    let v103 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v102 
    let _run_target_args'_v101 = v103 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : string = "&*$0"
    let v105 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v104 
    let _run_target_args'_v101 = v105 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v106 : string = "&*$0"
    let v107 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v106 
    let _run_target_args'_v101 = v107 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v109 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v109 
    #endif
#if FABLE_COMPILER_PYTHON
    let v113 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v113 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v117 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v117 
    #endif
#else
    let v121 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v121 
    #endif
    let v124 : Ref<Str> = _run_target_args'_v101 
    let v130 : string = "inline_colorization::color_reset"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v96, v124, v131) v132 
    let v134 : string = "fable_library_rust::String_::fromString($0)"
    let v135 : string = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let _run_target_args'_v12 = v135 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v136 : string = "\u001b[93m"
    let v137 : string = method15()
    let v138 : string = v136 + v7 
    let v139 : string = v138 + v137 
    let _run_target_args'_v12 = v139 
    #endif
#if FABLE_COMPILER_PYTHON
    let v140 : string = "\u001b[93m"
    let v141 : string = method15()
    let v142 : string = v140 + v7 
    let v143 : string = v142 + v141 
    let _run_target_args'_v12 = v143 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v144 : string = "\u001b[93m"
    let v145 : string = method15()
    let v146 : string = v144 + v7 
    let v147 : string = v146 + v145 
    let _run_target_args'_v12 = v147 
    #endif
#else
    let v148 : string = "\u001b[93m"
    let v149 : string = method15()
    let v150 : string = v148 + v7 
    let v151 : string = v150 + v149 
    let _run_target_args'_v12 = v151 
    #endif
    let v152 : string = _run_target_args'_v12 
    v152
and method37 (v0 : string, v1 : string) : string =
    let v2 : string = method14()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure8(v3, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v15 : string = "dir"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure8(v3, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v25 : string = " = "
    let v26 : string = $"{v25}"
    let v29 : unit = ()
    let v30 : (unit -> unit) = closure8(v3, v26)
    let v31 : unit = (fun () -> v30 (); v29) ()
    let v35 : string = $"{v0}"
    let v38 : unit = ()
    let v39 : (unit -> unit) = closure8(v3, v35)
    let v40 : unit = (fun () -> v39 (); v38) ()
    let v44 : string = "; "
    let v45 : string = $"{v44}"
    let v48 : unit = ()
    let v49 : (unit -> unit) = closure8(v3, v45)
    let v50 : unit = (fun () -> v49 (); v48) ()
    let v54 : string = "error"
    let v55 : string = $"{v54}"
    let v58 : unit = ()
    let v59 : (unit -> unit) = closure8(v3, v55)
    let v60 : unit = (fun () -> v59 (); v58) ()
    let v64 : string = $"{v25}"
    let v67 : unit = ()
    let v68 : (unit -> unit) = closure8(v3, v64)
    let v69 : unit = (fun () -> v68 (); v67) ()
    let v73 : string = $"{v1}"
    let v76 : unit = ()
    let v77 : (unit -> unit) = closure8(v3, v73)
    let v78 : unit = (fun () -> v77 (); v76) ()
    let v82 : string = " }"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v3, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = v3.l0
    v91
and method36 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string) : string =
    let v10 : string = method37(v8, v9)
    let v11 : int64 = v0.l0
    let v13 : string = "file_system.get_workspace_root"
    let v14 : string = $"{v6} {v7} #{v11} %s{v13} / {v10}"
    method18(v14)
and closure15 (v0 : string, v1 : string) () : unit =
    let v2 : US0 = US0_3
    let v3 : bool = method7(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method8(v27, v28, v29, v30, v31, v32)
        let v46 : string = method35()
        let v47 : string = method36(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method19(v47)
and method42 (v0 : std_io_Error) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    (* run_target_args'
    let v7 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "format!(\"{:#?}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    let v10 : string = "fable_library_rust::String_::fromString($0)"
    let v11 : string = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let _run_target_args'_v7 = v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12 : string = "format!(\"{:#?}\", $0)"
    let v13 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v12 
    let v14 : string = "fable_library_rust::String_::fromString($0)"
    let v15 : string = Fable.Core.RustInterop.emitRustExpr v13 v14 
    let _run_target_args'_v7 = v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : string = "format!(\"{:#?}\", $0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v16 
    let v18 : string = "fable_library_rust::String_::fromString($0)"
    let v19 : string = Fable.Core.RustInterop.emitRustExpr v17 v18 
    let _run_target_args'_v7 = v19 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v21 : string = $"%A{v0}"
    let _run_target_args'_v7 = v21 
    #endif
#if FABLE_COMPILER_PYTHON
    let v25 : string = $"%A{v0}"
    let _run_target_args'_v7 = v25 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v29 : string = $"%A{v0}"
    let _run_target_args'_v7 = v29 
    #endif
#else
    let v33 : string = $"%A{v0}"
    let _run_target_args'_v7 = v33 
    #endif
    let v36 : string = _run_target_args'_v7 
    let v43 : string = $"{v36}"
    let v46 : unit = ()
    let v47 : (unit -> unit) = closure8(v2, v43)
    let v48 : unit = (fun () -> v47 (); v46) ()
    let v51 : string = v2.l0
    v51
and closure16 () (v0 : std_io_Error) : string =
    method42(v0)
and method41 () : (std_io_Error -> string) =
    closure16()
and closure17 () (v0 : std_path_PathBuf) : US9 =
    US9_0(v0)
and method43 () : (std_path_PathBuf -> US9) =
    closure17()
and closure18 () (v0 : string) : US9 =
    US9_1(v0)
and method44 () : (string -> US9) =
    closure18()
and method47 (v0 : string) : string =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    (* run_target_args'
    let v10 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v11 
    let _run_target_args'_v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v13 
    let _run_target_args'_v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v15 
    let _run_target_args'_v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v18 
    #endif
#if FABLE_COMPILER_PYTHON
    let v22 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v22 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v26 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v26 
    #endif
#else
    let v30 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v30 
    #endif
    let v33 : Ref<Str> = _run_target_args'_v10 
    (* run_target_args'
    let v43 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v44 : string = "String::from($0)"
    let v45 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v44 
    let _run_target_args'_v43 = v45 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v46 : string = "String::from($0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v46 
    let _run_target_args'_v43 = v47 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v48 : string = "String::from($0)"
    let v49 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v48 
    let _run_target_args'_v43 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v51 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v51 
    #endif
#if FABLE_COMPILER_PYTHON
    let v55 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v55 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v59 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v59 
    #endif
#else
    let v63 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v63 
    #endif
    let v66 : std_string_String = _run_target_args'_v43 
    (* run_target_args'
    let v76 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v77 : string = "std::path::PathBuf::from($0)"
    let v78 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v77 
    let _run_target_args'_v76 = v78 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v79 : string = "std::path::PathBuf::from($0)"
    let v80 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v79 
    let _run_target_args'_v76 = v80 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : string = "std::path::PathBuf::from($0)"
    let v82 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v81 
    let _run_target_args'_v76 = v82 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v84 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v84 
    #endif
#if FABLE_COMPILER_PYTHON
    let v88 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v88 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v92 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v92 
    #endif
#else
    let v96 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v96 
    #endif
    let v99 : std_path_PathBuf = _run_target_args'_v76 
    let v105 : string = "$0.file_name()"
    let v106 : Ref<std_ffi_OsStr> option = Fable.Core.RustInterop.emitRustExpr v99 v105 
    let v107 : string = "true; let _optionm_map_ = $0.map(|x| { //"
    let v108 : bool = Fable.Core.RustInterop.emitRustExpr v106 v107 
    let v109 : string = "x"
    let v110 : Ref<std_ffi_OsStr> = Fable.Core.RustInterop.emitRustExpr () v109 
    let v111 : string = "$0.to_os_string()"
    let v112 : std_ffi_OsString = Fable.Core.RustInterop.emitRustExpr v110 v111 
    let v113 : string = "$0.to_str()"
    let v114 : Ref<Str> option = Fable.Core.RustInterop.emitRustExpr v112 v113 
    let v115 : string = "$0.unwrap()"
    let v116 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v114 v115 
    (* run_target_args'
    let v121 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v122 : string = "String::from($0)"
    let v123 : std_string_String = Fable.Core.RustInterop.emitRustExpr v116 v122 
    let _run_target_args'_v121 = v123 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v124 : string = "String::from($0)"
    let v125 : std_string_String = Fable.Core.RustInterop.emitRustExpr v116 v124 
    let _run_target_args'_v121 = v125 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v126 : string = "String::from($0)"
    let v127 : std_string_String = Fable.Core.RustInterop.emitRustExpr v116 v126 
    let _run_target_args'_v121 = v127 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v129 : std_string_String = v116 |> unbox<std_string_String>
    let _run_target_args'_v121 = v129 
    #endif
#if FABLE_COMPILER_PYTHON
    let v133 : std_string_String = v116 |> unbox<std_string_String>
    let _run_target_args'_v121 = v133 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v137 : std_string_String = v116 |> unbox<std_string_String>
    let _run_target_args'_v121 = v137 
    #endif
#else
    let v141 : std_string_String = v116 |> unbox<std_string_String>
    let _run_target_args'_v121 = v141 
    #endif
    let v144 : std_string_String = _run_target_args'_v121 
    let v150 : string = "fable_library_rust::String_::fromString($0)"
    let v151 : string = Fable.Core.RustInterop.emitRustExpr v144 v150 
    let v152 : string = "true; $0 })"
    let v153 : bool = Fable.Core.RustInterop.emitRustExpr v151 v152 
    let v154 : string = "_optionm_map_"
    let v155 : string option = Fable.Core.RustInterop.emitRustExpr () v154 
    let v157 : (string -> US5) = method6()
    let v158 : US5 option = v155 |> Option.map v157 
    let v171 : US5 = US5_1
    let v172 : US5 = v158 |> Option.defaultValue v171 
    let v179 : string =
        match v172 with
        | US5_1 -> (* None *)
            let v177 : string = ""
            v177
        | US5_0(v176) -> (* Some *)
            v176
    let _run_target_args'_v5 = v179 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v180 : US3 = US3_1
    let v181 : US4 = US4_3(v180)
    let v182 : string = $"file_system.get_file_name / target: {v181} / path: {v0}"
    let v183 : string = failwith<string> v182
    let _run_target_args'_v5 = v183 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v185 : string = null |> unbox<string>
    let _run_target_args'_v5 = v185 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v188 : string = "path"
    let v189 : IPathBasename = Fable.Core.JsInterop.importAll v188 
    let v190 : string = "v189.basename($0)"
    let v191 : string = Fable.Core.JsInterop.emitJsExpr v0 v190 
    let _run_target_args'_v5 = v191 
    #endif
#if FABLE_COMPILER_PYTHON
    let v192 : US3 = US3_0
    let v193 : US4 = US4_5(v192)
    let v194 : string = $"file_system.get_file_name / target: {v193} / path: {v0}"
    let v195 : string = failwith<string> v194
    let _run_target_args'_v5 = v195 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v196 : US3 = US3_1
    let v197 : US4 = US4_1(v196)
    let v198 : string = $"file_system.get_file_name / target: {v197} / path: {v0}"
    let v199 : string = failwith<string> v198
    let _run_target_args'_v5 = v199 
    #endif
#else
    let v200 : (string -> string) = System.IO.Path.GetFileName
    let v201 : string = v200 v0
    let _run_target_args'_v5 = v201 
    #endif
    let v202 : string = _run_target_args'_v5 
    v202
and method48 (v0 : string) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v4 : string = $"{v0}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure8(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = v2.l0
    v12
and method46 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : string, v4 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v5 : string = method47(v4)
    let v6 : string option = method33(v4)
    let v8 : (string -> US5) = method6()
    let v9 : US5 option = v6 |> Option.map v8 
    let v22 : US5 = US5_1
    let v23 : US5 = v9 |> Option.defaultValue v22 
    let v27 : string = method48(v3)
    let v28 : bool = v2 >= 11uy
    if v28 then
        let v29 : string = $"file_system.read_link / "
        let v30 : string = $"path: {v0} / n: {v2} / path': {v4} / name: {v5}"
        let v31 : string = v29 + v30 
        (* run_target_args'
        let v36 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v37 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v38 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v31 v37 
        let _run_target_args'_v36 = v38 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v39 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v40 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v31 v39 
        let _run_target_args'_v36 = v40 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v41 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v42 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v31 v41 
        let _run_target_args'_v36 = v42 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v44 : std_io_Error = v31 |> unbox<std_io_Error>
        let _run_target_args'_v36 = v44 
        #endif
#if FABLE_COMPILER_PYTHON
        let v48 : std_io_Error = v31 |> unbox<std_io_Error>
        let _run_target_args'_v36 = v48 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v52 : std_io_Error = v31 |> unbox<std_io_Error>
        let _run_target_args'_v36 = v52 
        #endif
#else
        let v56 : std_io_Error = v31 |> unbox<std_io_Error>
        let _run_target_args'_v36 = v56 
        #endif
        let v59 : std_io_Error = _run_target_args'_v36 
        (* run_target_args'
        let v66 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v67 : string = "Err($0)"
        let v68 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v59 v67 
        let _run_target_args'_v66 = v68 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v69 : string = "Err($0)"
        let v70 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v59 v69 
        let _run_target_args'_v66 = v70 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v71 : string = "Err($0)"
        let v72 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v59 v71 
        let _run_target_args'_v66 = v72 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v73 : Result<std_path_PathBuf, std_io_Error> = v59 |> Error
        let _run_target_args'_v66 = v73 
        #endif
#if FABLE_COMPILER_PYTHON
        let v74 : Result<std_path_PathBuf, std_io_Error> = v59 |> Error
        let _run_target_args'_v66 = v74 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v75 : Result<std_path_PathBuf, std_io_Error> = v59 |> Error
        let _run_target_args'_v66 = v75 
        #endif
#else
        let v76 : Result<std_path_PathBuf, std_io_Error> = v59 |> Error
        let _run_target_args'_v66 = v76 
        #endif
        let v77 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v66 
        v77
    else
        match v23 with
        | US5_0(v80) -> (* Some *)
            let v83 : string = ""
            let v84 : bool = v4 <> v83 
            if v84 then
                let v87 : uint8 = v2 + 1uy
                let v88 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v87
                let v89 : Result<std_path_PathBuf, std_io_Error> = v88 v80
                let v90 : (std_io_Error -> string) = method41()
                (* run_target_args'
                let v92 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v93 : string = "$0.map_err(|x| $1(x))"
                let v94 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v89, v90) v93 
                let _run_target_args'_v92 = v94 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v95 : string = "$0.map_err(|x| $1(x))"
                let v96 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v89, v90) v95 
                let _run_target_args'_v92 = v96 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v97 : string = "$0.map_err(|x| $1(x))"
                let v98 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v89, v90) v97 
                let _run_target_args'_v92 = v98 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v99 : Result<std_path_PathBuf, string> = match v89 with Ok x -> Ok x | Error x -> Error (v90 x)
                let _run_target_args'_v92 = v99 
                #endif
#if FABLE_COMPILER_PYTHON
                let v100 : Result<std_path_PathBuf, string> = match v89 with Ok x -> Ok x | Error x -> Error (v90 x)
                let _run_target_args'_v92 = v100 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v101 : Result<std_path_PathBuf, string> = match v89 with Ok x -> Ok x | Error x -> Error (v90 x)
                let _run_target_args'_v92 = v101 
                #endif
#else
                let v102 : Result<std_path_PathBuf, string> = match v89 with Ok x -> Ok x | Error x -> Error (v90 x)
                let _run_target_args'_v92 = v102 
                #endif
                let v103 : Result<std_path_PathBuf, string> = _run_target_args'_v92 
                let v106 : (std_path_PathBuf -> US9) = method43()
                let v107 : (string -> US9) = method44()
                let v108 : US9 = match v103 with Ok x -> v106 x | Error x -> v107 x
                match v108 with
                | US9_1(v262) -> (* Error *)
                    let v263 : string = $"file_system.read_link / "
                    let v264 : string = $"error': {v262} / error: {v27} / name: {v5}"
                    let v265 : string = v263 + v264 
                    (* run_target_args'
                    let v270 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v271 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v272 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v265 v271 
                    let _run_target_args'_v270 = v272 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v273 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v274 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v265 v273 
                    let _run_target_args'_v270 = v274 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v275 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v276 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v265 v275 
                    let _run_target_args'_v270 = v276 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v278 : std_io_Error = v265 |> unbox<std_io_Error>
                    let _run_target_args'_v270 = v278 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v282 : std_io_Error = v265 |> unbox<std_io_Error>
                    let _run_target_args'_v270 = v282 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v286 : std_io_Error = v265 |> unbox<std_io_Error>
                    let _run_target_args'_v270 = v286 
                    #endif
#else
                    let v290 : std_io_Error = v265 |> unbox<std_io_Error>
                    let _run_target_args'_v270 = v290 
                    #endif
                    let v293 : std_io_Error = _run_target_args'_v270 
                    (* run_target_args'
                    let v300 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v301 : string = "Err($0)"
                    let v302 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v293 v301 
                    let _run_target_args'_v300 = v302 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v303 : string = "Err($0)"
                    let v304 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v293 v303 
                    let _run_target_args'_v300 = v304 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v305 : string = "Err($0)"
                    let v306 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v293 v305 
                    let _run_target_args'_v300 = v306 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v307 : Result<std_path_PathBuf, std_io_Error> = v293 |> Error
                    let _run_target_args'_v300 = v307 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v308 : Result<std_path_PathBuf, std_io_Error> = v293 |> Error
                    let _run_target_args'_v300 = v308 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v309 : Result<std_path_PathBuf, std_io_Error> = v293 |> Error
                    let _run_target_args'_v300 = v309 
                    #endif
#else
                    let v310 : Result<std_path_PathBuf, std_io_Error> = v293 |> Error
                    let _run_target_args'_v300 = v310 
                    #endif
                    let v311 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v300 
                    v311
                | US9_0(v109) -> (* Ok *)
                    (* run_target_args'
                    let v114 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v115 : string = "$0.display()"
                    let v116 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v109 v115 
                    let _run_target_args'_v114 = v116 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v117 : string = "$0.display()"
                    let v118 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v109 v117 
                    let _run_target_args'_v114 = v118 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v119 : string = "$0.display()"
                    let v120 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v109 v119 
                    let _run_target_args'_v114 = v120 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v122 : std_path_Display = v109 |> unbox<std_path_Display>
                    let _run_target_args'_v114 = v122 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v126 : std_path_Display = v109 |> unbox<std_path_Display>
                    let _run_target_args'_v114 = v126 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v130 : std_path_Display = v109 |> unbox<std_path_Display>
                    let _run_target_args'_v114 = v130 
                    #endif
#else
                    let v134 : std_path_Display = v109 |> unbox<std_path_Display>
                    let _run_target_args'_v114 = v134 
                    #endif
                    let v137 : std_path_Display = _run_target_args'_v114 
                    let v144 : string = v137 |> string 
                    let v147 : string = method28(v144, v5)
                    (* run_target_args'
                    let v152 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v153 : string = "&*$0"
                    let v154 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v147 v153 
                    let _run_target_args'_v152 = v154 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v155 : string = "&*$0"
                    let v156 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v147 v155 
                    let _run_target_args'_v152 = v156 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v157 : string = "&*$0"
                    let v158 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v147 v157 
                    let _run_target_args'_v152 = v158 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v160 : Ref<Str> = v147 |> unbox<Ref<Str>>
                    let _run_target_args'_v152 = v160 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v164 : Ref<Str> = v147 |> unbox<Ref<Str>>
                    let _run_target_args'_v152 = v164 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v168 : Ref<Str> = v147 |> unbox<Ref<Str>>
                    let _run_target_args'_v152 = v168 
                    #endif
#else
                    let v172 : Ref<Str> = v147 |> unbox<Ref<Str>>
                    let _run_target_args'_v152 = v172 
                    #endif
                    let v175 : Ref<Str> = _run_target_args'_v152 
                    (* run_target_args'
                    let v185 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v186 : string = "String::from($0)"
                    let v187 : std_string_String = Fable.Core.RustInterop.emitRustExpr v175 v186 
                    let _run_target_args'_v185 = v187 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v188 : string = "String::from($0)"
                    let v189 : std_string_String = Fable.Core.RustInterop.emitRustExpr v175 v188 
                    let _run_target_args'_v185 = v189 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v190 : string = "String::from($0)"
                    let v191 : std_string_String = Fable.Core.RustInterop.emitRustExpr v175 v190 
                    let _run_target_args'_v185 = v191 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v193 : std_string_String = v175 |> unbox<std_string_String>
                    let _run_target_args'_v185 = v193 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v197 : std_string_String = v175 |> unbox<std_string_String>
                    let _run_target_args'_v185 = v197 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v201 : std_string_String = v175 |> unbox<std_string_String>
                    let _run_target_args'_v185 = v201 
                    #endif
#else
                    let v205 : std_string_String = v175 |> unbox<std_string_String>
                    let _run_target_args'_v185 = v205 
                    #endif
                    let v208 : std_string_String = _run_target_args'_v185 
                    (* run_target_args'
                    let v218 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v219 : string = "std::path::PathBuf::from($0)"
                    let v220 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v208 v219 
                    let _run_target_args'_v218 = v220 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v221 : string = "std::path::PathBuf::from($0)"
                    let v222 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v208 v221 
                    let _run_target_args'_v218 = v222 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v223 : string = "std::path::PathBuf::from($0)"
                    let v224 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v208 v223 
                    let _run_target_args'_v218 = v224 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v226 : std_path_PathBuf = v208 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v218 = v226 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v230 : std_path_PathBuf = v208 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v218 = v230 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v234 : std_path_PathBuf = v208 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v218 = v234 
                    #endif
#else
                    let v238 : std_path_PathBuf = v208 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v218 = v238 
                    #endif
                    let v241 : std_path_PathBuf = _run_target_args'_v218 
                    (* run_target_args'
                    let v248 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v249 : string = "Ok($0)"
                    let v250 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v241 v249 
                    let _run_target_args'_v248 = v250 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v251 : string = "Ok($0)"
                    let v252 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v241 v251 
                    let _run_target_args'_v248 = v252 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v253 : string = "Ok($0)"
                    let v254 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v241 v253 
                    let _run_target_args'_v248 = v254 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v255 : Result<std_path_PathBuf, std_io_Error> = v241 |> Ok
                    let _run_target_args'_v248 = v255 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v256 : Result<std_path_PathBuf, std_io_Error> = v241 |> Ok
                    let _run_target_args'_v248 = v256 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v257 : Result<std_path_PathBuf, std_io_Error> = v241 |> Ok
                    let _run_target_args'_v248 = v257 
                    #endif
#else
                    let v258 : Result<std_path_PathBuf, std_io_Error> = v241 |> Ok
                    let _run_target_args'_v248 = v258 
                    #endif
                    let v259 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v248 
                    v259
            else
                let v316 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v317 : string = $"path: {v0} / error: {v27} / path': {v4} / name: {v5}"
                let v318 : string = v316 + v317 
                (* run_target_args'
                let v323 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v324 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v325 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v318 v324 
                let _run_target_args'_v323 = v325 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v326 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v327 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v318 v326 
                let _run_target_args'_v323 = v327 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v328 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v329 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v318 v328 
                let _run_target_args'_v323 = v329 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v331 : std_io_Error = v318 |> unbox<std_io_Error>
                let _run_target_args'_v323 = v331 
                #endif
#if FABLE_COMPILER_PYTHON
                let v335 : std_io_Error = v318 |> unbox<std_io_Error>
                let _run_target_args'_v323 = v335 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v339 : std_io_Error = v318 |> unbox<std_io_Error>
                let _run_target_args'_v323 = v339 
                #endif
#else
                let v343 : std_io_Error = v318 |> unbox<std_io_Error>
                let _run_target_args'_v323 = v343 
                #endif
                let v346 : std_io_Error = _run_target_args'_v323 
                (* run_target_args'
                let v353 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v354 : string = "Err($0)"
                let v355 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v346 v354 
                let _run_target_args'_v353 = v355 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v356 : string = "Err($0)"
                let v357 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v346 v356 
                let _run_target_args'_v353 = v357 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v358 : string = "Err($0)"
                let v359 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v346 v358 
                let _run_target_args'_v353 = v359 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v360 : Result<std_path_PathBuf, std_io_Error> = v346 |> Error
                let _run_target_args'_v353 = v360 
                #endif
#if FABLE_COMPILER_PYTHON
                let v361 : Result<std_path_PathBuf, std_io_Error> = v346 |> Error
                let _run_target_args'_v353 = v361 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v362 : Result<std_path_PathBuf, std_io_Error> = v346 |> Error
                let _run_target_args'_v353 = v362 
                #endif
#else
                let v363 : Result<std_path_PathBuf, std_io_Error> = v346 |> Error
                let _run_target_args'_v353 = v363 
                #endif
                let v364 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v353 
                v364
        | _ ->
            let v368 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v369 : string = $"path: {v0} / error: {v27} / path': {v4} / name: {v5}"
            let v370 : string = v368 + v369 
            (* run_target_args'
            let v375 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v376 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v377 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v370 v376 
            let _run_target_args'_v375 = v377 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v378 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v379 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v370 v378 
            let _run_target_args'_v375 = v379 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v380 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v381 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v370 v380 
            let _run_target_args'_v375 = v381 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v383 : std_io_Error = v370 |> unbox<std_io_Error>
            let _run_target_args'_v375 = v383 
            #endif
#if FABLE_COMPILER_PYTHON
            let v387 : std_io_Error = v370 |> unbox<std_io_Error>
            let _run_target_args'_v375 = v387 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v391 : std_io_Error = v370 |> unbox<std_io_Error>
            let _run_target_args'_v375 = v391 
            #endif
#else
            let v395 : std_io_Error = v370 |> unbox<std_io_Error>
            let _run_target_args'_v375 = v395 
            #endif
            let v398 : std_io_Error = _run_target_args'_v375 
            (* run_target_args'
            let v405 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v406 : string = "Err($0)"
            let v407 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v398 v406 
            let _run_target_args'_v405 = v407 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v408 : string = "Err($0)"
            let v409 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v398 v408 
            let _run_target_args'_v405 = v409 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v410 : string = "Err($0)"
            let v411 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v398 v410 
            let _run_target_args'_v405 = v411 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v412 : Result<std_path_PathBuf, std_io_Error> = v398 |> Error
            let _run_target_args'_v405 = v412 
            #endif
#if FABLE_COMPILER_PYTHON
            let v413 : Result<std_path_PathBuf, std_io_Error> = v398 |> Error
            let _run_target_args'_v405 = v413 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v414 : Result<std_path_PathBuf, std_io_Error> = v398 |> Error
            let _run_target_args'_v405 = v414 
            #endif
#else
            let v415 : Result<std_path_PathBuf, std_io_Error> = v398 |> Error
            let _run_target_args'_v405 = v415 
            #endif
            let v416 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v405 
            v416
and method45 (v0 : string, v1 : uint8, v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    (* run_target_args'
    let v7 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "std::fs::read_link(&*$0)"
    let v9 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v8 
    let v10 : (std_io_Error -> string) = method41()
    (* run_target_args'
    let v12 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : string = "$0.map_err(|x| $1(x))"
    let v14 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v9, v10) v13 
    let _run_target_args'_v12 = v14 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : string = "$0.map_err(|x| $1(x))"
    let v16 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v9, v10) v15 
    let _run_target_args'_v12 = v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v17 : string = "$0.map_err(|x| $1(x))"
    let v18 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v9, v10) v17 
    let _run_target_args'_v12 = v18 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : Result<std_path_PathBuf, string> = match v9 with Ok x -> Ok x | Error x -> Error (v10 x)
    let _run_target_args'_v12 = v19 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : Result<std_path_PathBuf, string> = match v9 with Ok x -> Ok x | Error x -> Error (v10 x)
    let _run_target_args'_v12 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v21 : Result<std_path_PathBuf, string> = match v9 with Ok x -> Ok x | Error x -> Error (v10 x)
    let _run_target_args'_v12 = v21 
    #endif
#else
    let v22 : Result<std_path_PathBuf, string> = match v9 with Ok x -> Ok x | Error x -> Error (v10 x)
    let _run_target_args'_v12 = v22 
    #endif
    let v23 : Result<std_path_PathBuf, string> = _run_target_args'_v12 
    let v26 : (std_path_PathBuf -> US9) = method43()
    let v27 : (string -> US9) = method44()
    let v28 : US9 = match v23 with Ok x -> v26 x | Error x -> v27 x
    let v49 : Result<std_path_PathBuf, std_io_Error> =
        match v28 with
        | US9_1(v45) -> (* Error *)
            let v46 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method46(v0, v46, v1, v45, v2)
        | US9_0(v29) -> (* Ok *)
            (* run_target_args'
            let v31 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v32 : string = "Ok($0)"
            let v33 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v29 v32 
            let _run_target_args'_v31 = v33 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v34 : string = "Ok($0)"
            let v35 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v29 v34 
            let _run_target_args'_v31 = v35 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v36 : string = "Ok($0)"
            let v37 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v29 v36 
            let _run_target_args'_v31 = v37 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v38 : Result<std_path_PathBuf, std_io_Error> = v29 |> Ok
            let _run_target_args'_v31 = v38 
            #endif
#if FABLE_COMPILER_PYTHON
            let v39 : Result<std_path_PathBuf, std_io_Error> = v29 |> Ok
            let _run_target_args'_v31 = v39 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v40 : Result<std_path_PathBuf, std_io_Error> = v29 |> Ok
            let _run_target_args'_v31 = v40 
            #endif
#else
            let v41 : Result<std_path_PathBuf, std_io_Error> = v29 |> Ok
            let _run_target_args'_v31 = v41 
            #endif
            let v42 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v31 
            v42
    let _run_target_args'_v7 = v49 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v50 : string = "std::fs::read_link(&*$0)"
    let v51 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v50 
    let v52 : (std_io_Error -> string) = method41()
    (* run_target_args'
    let v54 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v55 : string = "$0.map_err(|x| $1(x))"
    let v56 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v51, v52) v55 
    let _run_target_args'_v54 = v56 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v57 : string = "$0.map_err(|x| $1(x))"
    let v58 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v51, v52) v57 
    let _run_target_args'_v54 = v58 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v59 : string = "$0.map_err(|x| $1(x))"
    let v60 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v51, v52) v59 
    let _run_target_args'_v54 = v60 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v61 : Result<std_path_PathBuf, string> = match v51 with Ok x -> Ok x | Error x -> Error (v52 x)
    let _run_target_args'_v54 = v61 
    #endif
#if FABLE_COMPILER_PYTHON
    let v62 : Result<std_path_PathBuf, string> = match v51 with Ok x -> Ok x | Error x -> Error (v52 x)
    let _run_target_args'_v54 = v62 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v63 : Result<std_path_PathBuf, string> = match v51 with Ok x -> Ok x | Error x -> Error (v52 x)
    let _run_target_args'_v54 = v63 
    #endif
#else
    let v64 : Result<std_path_PathBuf, string> = match v51 with Ok x -> Ok x | Error x -> Error (v52 x)
    let _run_target_args'_v54 = v64 
    #endif
    let v65 : Result<std_path_PathBuf, string> = _run_target_args'_v54 
    let v68 : (std_path_PathBuf -> US9) = method43()
    let v69 : (string -> US9) = method44()
    let v70 : US9 = match v65 with Ok x -> v68 x | Error x -> v69 x
    let v91 : Result<std_path_PathBuf, std_io_Error> =
        match v70 with
        | US9_1(v87) -> (* Error *)
            let v88 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method46(v0, v88, v1, v87, v2)
        | US9_0(v71) -> (* Ok *)
            (* run_target_args'
            let v73 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v74 : string = "Ok($0)"
            let v75 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v71 v74 
            let _run_target_args'_v73 = v75 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v76 : string = "Ok($0)"
            let v77 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v71 v76 
            let _run_target_args'_v73 = v77 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v78 : string = "Ok($0)"
            let v79 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v71 v78 
            let _run_target_args'_v73 = v79 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v80 : Result<std_path_PathBuf, std_io_Error> = v71 |> Ok
            let _run_target_args'_v73 = v80 
            #endif
#if FABLE_COMPILER_PYTHON
            let v81 : Result<std_path_PathBuf, std_io_Error> = v71 |> Ok
            let _run_target_args'_v73 = v81 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v82 : Result<std_path_PathBuf, std_io_Error> = v71 |> Ok
            let _run_target_args'_v73 = v82 
            #endif
#else
            let v83 : Result<std_path_PathBuf, std_io_Error> = v71 |> Ok
            let _run_target_args'_v73 = v83 
            #endif
            let v84 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v73 
            v84
    let _run_target_args'_v7 = v91 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v92 : string = "std::fs::read_link(&*$0)"
    let v93 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v92 
    let v94 : (std_io_Error -> string) = method41()
    (* run_target_args'
    let v96 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v97 : string = "$0.map_err(|x| $1(x))"
    let v98 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v93, v94) v97 
    let _run_target_args'_v96 = v98 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v99 : string = "$0.map_err(|x| $1(x))"
    let v100 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v93, v94) v99 
    let _run_target_args'_v96 = v100 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v101 : string = "$0.map_err(|x| $1(x))"
    let v102 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v93, v94) v101 
    let _run_target_args'_v96 = v102 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v103 : Result<std_path_PathBuf, string> = match v93 with Ok x -> Ok x | Error x -> Error (v94 x)
    let _run_target_args'_v96 = v103 
    #endif
#if FABLE_COMPILER_PYTHON
    let v104 : Result<std_path_PathBuf, string> = match v93 with Ok x -> Ok x | Error x -> Error (v94 x)
    let _run_target_args'_v96 = v104 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v105 : Result<std_path_PathBuf, string> = match v93 with Ok x -> Ok x | Error x -> Error (v94 x)
    let _run_target_args'_v96 = v105 
    #endif
#else
    let v106 : Result<std_path_PathBuf, string> = match v93 with Ok x -> Ok x | Error x -> Error (v94 x)
    let _run_target_args'_v96 = v106 
    #endif
    let v107 : Result<std_path_PathBuf, string> = _run_target_args'_v96 
    let v110 : (std_path_PathBuf -> US9) = method43()
    let v111 : (string -> US9) = method44()
    let v112 : US9 = match v107 with Ok x -> v110 x | Error x -> v111 x
    let v133 : Result<std_path_PathBuf, std_io_Error> =
        match v112 with
        | US9_1(v129) -> (* Error *)
            let v130 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method46(v0, v130, v1, v129, v2)
        | US9_0(v113) -> (* Ok *)
            (* run_target_args'
            let v115 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v116 : string = "Ok($0)"
            let v117 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v113 v116 
            let _run_target_args'_v115 = v117 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v118 : string = "Ok($0)"
            let v119 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v113 v118 
            let _run_target_args'_v115 = v119 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v120 : string = "Ok($0)"
            let v121 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v113 v120 
            let _run_target_args'_v115 = v121 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v122 : Result<std_path_PathBuf, std_io_Error> = v113 |> Ok
            let _run_target_args'_v115 = v122 
            #endif
#if FABLE_COMPILER_PYTHON
            let v123 : Result<std_path_PathBuf, std_io_Error> = v113 |> Ok
            let _run_target_args'_v115 = v123 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v124 : Result<std_path_PathBuf, std_io_Error> = v113 |> Ok
            let _run_target_args'_v115 = v124 
            #endif
#else
            let v125 : Result<std_path_PathBuf, std_io_Error> = v113 |> Ok
            let _run_target_args'_v115 = v125 
            #endif
            let v126 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v115 
            v126
    let _run_target_args'_v7 = v133 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v135 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v7 = v135 
    #endif
#if FABLE_COMPILER_PYTHON
    let v139 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v7 = v139 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v143 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v7 = v143 
    #endif
#else
    let v147 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v7 = v147 
    #endif
    let v150 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v7 
    v150
and closure20 (v0 : string, v1 : uint8) (v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    method45(v0, v1, v2)
and closure19 (v0 : string) (v1 : uint8) : (string -> Result<std_path_PathBuf, std_io_Error>) =
    closure20(v0, v1)
and method49 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v4 : string = method47(v0)
    let v5 : string option = method33(v0)
    let v7 : (string -> US5) = method6()
    let v8 : US5 option = v5 |> Option.map v7 
    let v21 : US5 = US5_1
    let v22 : US5 = v8 |> Option.defaultValue v21 
    let v26 : string = method48(v3)
    let v27 : bool = v2 >= 11uy
    if v27 then
        let v28 : string = $"file_system.read_link / "
        let v29 : string = $"path: {v0} / n: {v2} / path': {v0} / name: {v4}"
        let v30 : string = v28 + v29 
        (* run_target_args'
        let v35 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v36 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v37 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v30 v36 
        let _run_target_args'_v35 = v37 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v38 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v39 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v30 v38 
        let _run_target_args'_v35 = v39 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v40 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v41 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v30 v40 
        let _run_target_args'_v35 = v41 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v43 : std_io_Error = v30 |> unbox<std_io_Error>
        let _run_target_args'_v35 = v43 
        #endif
#if FABLE_COMPILER_PYTHON
        let v47 : std_io_Error = v30 |> unbox<std_io_Error>
        let _run_target_args'_v35 = v47 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v51 : std_io_Error = v30 |> unbox<std_io_Error>
        let _run_target_args'_v35 = v51 
        #endif
#else
        let v55 : std_io_Error = v30 |> unbox<std_io_Error>
        let _run_target_args'_v35 = v55 
        #endif
        let v58 : std_io_Error = _run_target_args'_v35 
        (* run_target_args'
        let v65 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v66 : string = "Err($0)"
        let v67 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v58 v66 
        let _run_target_args'_v65 = v67 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v68 : string = "Err($0)"
        let v69 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v58 v68 
        let _run_target_args'_v65 = v69 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v70 : string = "Err($0)"
        let v71 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v58 v70 
        let _run_target_args'_v65 = v71 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v72 : Result<std_path_PathBuf, std_io_Error> = v58 |> Error
        let _run_target_args'_v65 = v72 
        #endif
#if FABLE_COMPILER_PYTHON
        let v73 : Result<std_path_PathBuf, std_io_Error> = v58 |> Error
        let _run_target_args'_v65 = v73 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v74 : Result<std_path_PathBuf, std_io_Error> = v58 |> Error
        let _run_target_args'_v65 = v74 
        #endif
#else
        let v75 : Result<std_path_PathBuf, std_io_Error> = v58 |> Error
        let _run_target_args'_v65 = v75 
        #endif
        let v76 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v65 
        v76
    else
        match v22 with
        | US5_0(v79) -> (* Some *)
            let v82 : string = ""
            let v83 : bool = v0 <> v82 
            if v83 then
                let v86 : uint8 = v2 + 1uy
                let v87 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v86
                let v88 : Result<std_path_PathBuf, std_io_Error> = v87 v79
                let v89 : (std_io_Error -> string) = method41()
                (* run_target_args'
                let v91 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v92 : string = "$0.map_err(|x| $1(x))"
                let v93 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v88, v89) v92 
                let _run_target_args'_v91 = v93 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v94 : string = "$0.map_err(|x| $1(x))"
                let v95 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v88, v89) v94 
                let _run_target_args'_v91 = v95 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v96 : string = "$0.map_err(|x| $1(x))"
                let v97 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v88, v89) v96 
                let _run_target_args'_v91 = v97 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v98 : Result<std_path_PathBuf, string> = match v88 with Ok x -> Ok x | Error x -> Error (v89 x)
                let _run_target_args'_v91 = v98 
                #endif
#if FABLE_COMPILER_PYTHON
                let v99 : Result<std_path_PathBuf, string> = match v88 with Ok x -> Ok x | Error x -> Error (v89 x)
                let _run_target_args'_v91 = v99 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v100 : Result<std_path_PathBuf, string> = match v88 with Ok x -> Ok x | Error x -> Error (v89 x)
                let _run_target_args'_v91 = v100 
                #endif
#else
                let v101 : Result<std_path_PathBuf, string> = match v88 with Ok x -> Ok x | Error x -> Error (v89 x)
                let _run_target_args'_v91 = v101 
                #endif
                let v102 : Result<std_path_PathBuf, string> = _run_target_args'_v91 
                let v105 : (std_path_PathBuf -> US9) = method43()
                let v106 : (string -> US9) = method44()
                let v107 : US9 = match v102 with Ok x -> v105 x | Error x -> v106 x
                match v107 with
                | US9_1(v261) -> (* Error *)
                    let v262 : string = $"file_system.read_link / "
                    let v263 : string = $"error': {v261} / error: {v26} / name: {v4}"
                    let v264 : string = v262 + v263 
                    (* run_target_args'
                    let v269 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v270 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v271 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v264 v270 
                    let _run_target_args'_v269 = v271 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v272 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v273 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v264 v272 
                    let _run_target_args'_v269 = v273 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v274 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v275 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v264 v274 
                    let _run_target_args'_v269 = v275 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v277 : std_io_Error = v264 |> unbox<std_io_Error>
                    let _run_target_args'_v269 = v277 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v281 : std_io_Error = v264 |> unbox<std_io_Error>
                    let _run_target_args'_v269 = v281 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v285 : std_io_Error = v264 |> unbox<std_io_Error>
                    let _run_target_args'_v269 = v285 
                    #endif
#else
                    let v289 : std_io_Error = v264 |> unbox<std_io_Error>
                    let _run_target_args'_v269 = v289 
                    #endif
                    let v292 : std_io_Error = _run_target_args'_v269 
                    (* run_target_args'
                    let v299 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v300 : string = "Err($0)"
                    let v301 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v292 v300 
                    let _run_target_args'_v299 = v301 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v302 : string = "Err($0)"
                    let v303 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v292 v302 
                    let _run_target_args'_v299 = v303 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v304 : string = "Err($0)"
                    let v305 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v292 v304 
                    let _run_target_args'_v299 = v305 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v306 : Result<std_path_PathBuf, std_io_Error> = v292 |> Error
                    let _run_target_args'_v299 = v306 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v307 : Result<std_path_PathBuf, std_io_Error> = v292 |> Error
                    let _run_target_args'_v299 = v307 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v308 : Result<std_path_PathBuf, std_io_Error> = v292 |> Error
                    let _run_target_args'_v299 = v308 
                    #endif
#else
                    let v309 : Result<std_path_PathBuf, std_io_Error> = v292 |> Error
                    let _run_target_args'_v299 = v309 
                    #endif
                    let v310 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v299 
                    v310
                | US9_0(v108) -> (* Ok *)
                    (* run_target_args'
                    let v113 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v114 : string = "$0.display()"
                    let v115 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v108 v114 
                    let _run_target_args'_v113 = v115 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v116 : string = "$0.display()"
                    let v117 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v108 v116 
                    let _run_target_args'_v113 = v117 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v118 : string = "$0.display()"
                    let v119 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v108 v118 
                    let _run_target_args'_v113 = v119 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v121 : std_path_Display = v108 |> unbox<std_path_Display>
                    let _run_target_args'_v113 = v121 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v125 : std_path_Display = v108 |> unbox<std_path_Display>
                    let _run_target_args'_v113 = v125 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v129 : std_path_Display = v108 |> unbox<std_path_Display>
                    let _run_target_args'_v113 = v129 
                    #endif
#else
                    let v133 : std_path_Display = v108 |> unbox<std_path_Display>
                    let _run_target_args'_v113 = v133 
                    #endif
                    let v136 : std_path_Display = _run_target_args'_v113 
                    let v143 : string = v136 |> string 
                    let v146 : string = method28(v143, v4)
                    (* run_target_args'
                    let v151 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v152 : string = "&*$0"
                    let v153 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v146 v152 
                    let _run_target_args'_v151 = v153 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v154 : string = "&*$0"
                    let v155 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v146 v154 
                    let _run_target_args'_v151 = v155 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v156 : string = "&*$0"
                    let v157 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v146 v156 
                    let _run_target_args'_v151 = v157 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v159 : Ref<Str> = v146 |> unbox<Ref<Str>>
                    let _run_target_args'_v151 = v159 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v163 : Ref<Str> = v146 |> unbox<Ref<Str>>
                    let _run_target_args'_v151 = v163 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v167 : Ref<Str> = v146 |> unbox<Ref<Str>>
                    let _run_target_args'_v151 = v167 
                    #endif
#else
                    let v171 : Ref<Str> = v146 |> unbox<Ref<Str>>
                    let _run_target_args'_v151 = v171 
                    #endif
                    let v174 : Ref<Str> = _run_target_args'_v151 
                    (* run_target_args'
                    let v184 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v185 : string = "String::from($0)"
                    let v186 : std_string_String = Fable.Core.RustInterop.emitRustExpr v174 v185 
                    let _run_target_args'_v184 = v186 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v187 : string = "String::from($0)"
                    let v188 : std_string_String = Fable.Core.RustInterop.emitRustExpr v174 v187 
                    let _run_target_args'_v184 = v188 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v189 : string = "String::from($0)"
                    let v190 : std_string_String = Fable.Core.RustInterop.emitRustExpr v174 v189 
                    let _run_target_args'_v184 = v190 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v192 : std_string_String = v174 |> unbox<std_string_String>
                    let _run_target_args'_v184 = v192 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v196 : std_string_String = v174 |> unbox<std_string_String>
                    let _run_target_args'_v184 = v196 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v200 : std_string_String = v174 |> unbox<std_string_String>
                    let _run_target_args'_v184 = v200 
                    #endif
#else
                    let v204 : std_string_String = v174 |> unbox<std_string_String>
                    let _run_target_args'_v184 = v204 
                    #endif
                    let v207 : std_string_String = _run_target_args'_v184 
                    (* run_target_args'
                    let v217 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v218 : string = "std::path::PathBuf::from($0)"
                    let v219 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v207 v218 
                    let _run_target_args'_v217 = v219 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v220 : string = "std::path::PathBuf::from($0)"
                    let v221 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v207 v220 
                    let _run_target_args'_v217 = v221 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v222 : string = "std::path::PathBuf::from($0)"
                    let v223 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v207 v222 
                    let _run_target_args'_v217 = v223 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v225 : std_path_PathBuf = v207 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v217 = v225 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v229 : std_path_PathBuf = v207 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v217 = v229 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v233 : std_path_PathBuf = v207 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v217 = v233 
                    #endif
#else
                    let v237 : std_path_PathBuf = v207 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v217 = v237 
                    #endif
                    let v240 : std_path_PathBuf = _run_target_args'_v217 
                    (* run_target_args'
                    let v247 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v248 : string = "Ok($0)"
                    let v249 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v240 v248 
                    let _run_target_args'_v247 = v249 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v250 : string = "Ok($0)"
                    let v251 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v240 v250 
                    let _run_target_args'_v247 = v251 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v252 : string = "Ok($0)"
                    let v253 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v240 v252 
                    let _run_target_args'_v247 = v253 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v254 : Result<std_path_PathBuf, std_io_Error> = v240 |> Ok
                    let _run_target_args'_v247 = v254 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v255 : Result<std_path_PathBuf, std_io_Error> = v240 |> Ok
                    let _run_target_args'_v247 = v255 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v256 : Result<std_path_PathBuf, std_io_Error> = v240 |> Ok
                    let _run_target_args'_v247 = v256 
                    #endif
#else
                    let v257 : Result<std_path_PathBuf, std_io_Error> = v240 |> Ok
                    let _run_target_args'_v247 = v257 
                    #endif
                    let v258 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v247 
                    v258
            else
                let v315 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v316 : string = $"path: {v0} / error: {v26} / path': {v0} / name: {v4}"
                let v317 : string = v315 + v316 
                (* run_target_args'
                let v322 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v323 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v324 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v317 v323 
                let _run_target_args'_v322 = v324 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v325 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v326 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v317 v325 
                let _run_target_args'_v322 = v326 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v327 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v328 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v317 v327 
                let _run_target_args'_v322 = v328 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v330 : std_io_Error = v317 |> unbox<std_io_Error>
                let _run_target_args'_v322 = v330 
                #endif
#if FABLE_COMPILER_PYTHON
                let v334 : std_io_Error = v317 |> unbox<std_io_Error>
                let _run_target_args'_v322 = v334 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v338 : std_io_Error = v317 |> unbox<std_io_Error>
                let _run_target_args'_v322 = v338 
                #endif
#else
                let v342 : std_io_Error = v317 |> unbox<std_io_Error>
                let _run_target_args'_v322 = v342 
                #endif
                let v345 : std_io_Error = _run_target_args'_v322 
                (* run_target_args'
                let v352 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v353 : string = "Err($0)"
                let v354 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v345 v353 
                let _run_target_args'_v352 = v354 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v355 : string = "Err($0)"
                let v356 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v345 v355 
                let _run_target_args'_v352 = v356 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v357 : string = "Err($0)"
                let v358 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v345 v357 
                let _run_target_args'_v352 = v358 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v359 : Result<std_path_PathBuf, std_io_Error> = v345 |> Error
                let _run_target_args'_v352 = v359 
                #endif
#if FABLE_COMPILER_PYTHON
                let v360 : Result<std_path_PathBuf, std_io_Error> = v345 |> Error
                let _run_target_args'_v352 = v360 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v361 : Result<std_path_PathBuf, std_io_Error> = v345 |> Error
                let _run_target_args'_v352 = v361 
                #endif
#else
                let v362 : Result<std_path_PathBuf, std_io_Error> = v345 |> Error
                let _run_target_args'_v352 = v362 
                #endif
                let v363 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v352 
                v363
        | _ ->
            let v367 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v368 : string = $"path: {v0} / error: {v26} / path': {v0} / name: {v4}"
            let v369 : string = v367 + v368 
            (* run_target_args'
            let v374 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v375 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v376 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v369 v375 
            let _run_target_args'_v374 = v376 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v377 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v378 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v369 v377 
            let _run_target_args'_v374 = v378 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v379 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v380 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v369 v379 
            let _run_target_args'_v374 = v380 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v382 : std_io_Error = v369 |> unbox<std_io_Error>
            let _run_target_args'_v374 = v382 
            #endif
#if FABLE_COMPILER_PYTHON
            let v386 : std_io_Error = v369 |> unbox<std_io_Error>
            let _run_target_args'_v374 = v386 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v390 : std_io_Error = v369 |> unbox<std_io_Error>
            let _run_target_args'_v374 = v390 
            #endif
#else
            let v394 : std_io_Error = v369 |> unbox<std_io_Error>
            let _run_target_args'_v374 = v394 
            #endif
            let v397 : std_io_Error = _run_target_args'_v374 
            (* run_target_args'
            let v404 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v405 : string = "Err($0)"
            let v406 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v397 v405 
            let _run_target_args'_v404 = v406 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v407 : string = "Err($0)"
            let v408 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v397 v407 
            let _run_target_args'_v404 = v408 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v409 : string = "Err($0)"
            let v410 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v397 v409 
            let _run_target_args'_v404 = v410 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v411 : Result<std_path_PathBuf, std_io_Error> = v397 |> Error
            let _run_target_args'_v404 = v411 
            #endif
#if FABLE_COMPILER_PYTHON
            let v412 : Result<std_path_PathBuf, std_io_Error> = v397 |> Error
            let _run_target_args'_v404 = v412 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v413 : Result<std_path_PathBuf, std_io_Error> = v397 |> Error
            let _run_target_args'_v404 = v413 
            #endif
#else
            let v414 : Result<std_path_PathBuf, std_io_Error> = v397 |> Error
            let _run_target_args'_v404 = v414 
            #endif
            let v415 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v404 
            v415
and method40 (v0 : string, v1 : uint8) : Result<std_path_PathBuf, std_io_Error> =
    (* run_target_args'
    let v6 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = "std::fs::read_link(&*$0)"
    let v8 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v7 
    let v9 : (std_io_Error -> string) = method41()
    (* run_target_args'
    let v11 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12 : string = "$0.map_err(|x| $1(x))"
    let v13 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v8, v9) v12 
    let _run_target_args'_v11 = v13 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v14 : string = "$0.map_err(|x| $1(x))"
    let v15 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v8, v9) v14 
    let _run_target_args'_v11 = v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : string = "$0.map_err(|x| $1(x))"
    let v17 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v8, v9) v16 
    let _run_target_args'_v11 = v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : Result<std_path_PathBuf, string> = match v8 with Ok x -> Ok x | Error x -> Error (v9 x)
    let _run_target_args'_v11 = v18 
    #endif
#if FABLE_COMPILER_PYTHON
    let v19 : Result<std_path_PathBuf, string> = match v8 with Ok x -> Ok x | Error x -> Error (v9 x)
    let _run_target_args'_v11 = v19 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v20 : Result<std_path_PathBuf, string> = match v8 with Ok x -> Ok x | Error x -> Error (v9 x)
    let _run_target_args'_v11 = v20 
    #endif
#else
    let v21 : Result<std_path_PathBuf, string> = match v8 with Ok x -> Ok x | Error x -> Error (v9 x)
    let _run_target_args'_v11 = v21 
    #endif
    let v22 : Result<std_path_PathBuf, string> = _run_target_args'_v11 
    let v25 : (std_path_PathBuf -> US9) = method43()
    let v26 : (string -> US9) = method44()
    let v27 : US9 = match v22 with Ok x -> v25 x | Error x -> v26 x
    let v48 : Result<std_path_PathBuf, std_io_Error> =
        match v27 with
        | US9_1(v44) -> (* Error *)
            let v45 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method49(v0, v45, v1, v44)
        | US9_0(v28) -> (* Ok *)
            (* run_target_args'
            let v30 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v31 : string = "Ok($0)"
            let v32 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v28 v31 
            let _run_target_args'_v30 = v32 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v33 : string = "Ok($0)"
            let v34 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v28 v33 
            let _run_target_args'_v30 = v34 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v35 : string = "Ok($0)"
            let v36 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v28 v35 
            let _run_target_args'_v30 = v36 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v37 : Result<std_path_PathBuf, std_io_Error> = v28 |> Ok
            let _run_target_args'_v30 = v37 
            #endif
#if FABLE_COMPILER_PYTHON
            let v38 : Result<std_path_PathBuf, std_io_Error> = v28 |> Ok
            let _run_target_args'_v30 = v38 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v39 : Result<std_path_PathBuf, std_io_Error> = v28 |> Ok
            let _run_target_args'_v30 = v39 
            #endif
#else
            let v40 : Result<std_path_PathBuf, std_io_Error> = v28 |> Ok
            let _run_target_args'_v30 = v40 
            #endif
            let v41 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v30 
            v41
    let _run_target_args'_v6 = v48 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v49 : string = "std::fs::read_link(&*$0)"
    let v50 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v49 
    let v51 : (std_io_Error -> string) = method41()
    (* run_target_args'
    let v53 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v54 : string = "$0.map_err(|x| $1(x))"
    let v55 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v50, v51) v54 
    let _run_target_args'_v53 = v55 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v56 : string = "$0.map_err(|x| $1(x))"
    let v57 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v50, v51) v56 
    let _run_target_args'_v53 = v57 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v58 : string = "$0.map_err(|x| $1(x))"
    let v59 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v50, v51) v58 
    let _run_target_args'_v53 = v59 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v60 : Result<std_path_PathBuf, string> = match v50 with Ok x -> Ok x | Error x -> Error (v51 x)
    let _run_target_args'_v53 = v60 
    #endif
#if FABLE_COMPILER_PYTHON
    let v61 : Result<std_path_PathBuf, string> = match v50 with Ok x -> Ok x | Error x -> Error (v51 x)
    let _run_target_args'_v53 = v61 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v62 : Result<std_path_PathBuf, string> = match v50 with Ok x -> Ok x | Error x -> Error (v51 x)
    let _run_target_args'_v53 = v62 
    #endif
#else
    let v63 : Result<std_path_PathBuf, string> = match v50 with Ok x -> Ok x | Error x -> Error (v51 x)
    let _run_target_args'_v53 = v63 
    #endif
    let v64 : Result<std_path_PathBuf, string> = _run_target_args'_v53 
    let v67 : (std_path_PathBuf -> US9) = method43()
    let v68 : (string -> US9) = method44()
    let v69 : US9 = match v64 with Ok x -> v67 x | Error x -> v68 x
    let v90 : Result<std_path_PathBuf, std_io_Error> =
        match v69 with
        | US9_1(v86) -> (* Error *)
            let v87 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method49(v0, v87, v1, v86)
        | US9_0(v70) -> (* Ok *)
            (* run_target_args'
            let v72 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v73 : string = "Ok($0)"
            let v74 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v70 v73 
            let _run_target_args'_v72 = v74 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v75 : string = "Ok($0)"
            let v76 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v70 v75 
            let _run_target_args'_v72 = v76 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v77 : string = "Ok($0)"
            let v78 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v70 v77 
            let _run_target_args'_v72 = v78 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v79 : Result<std_path_PathBuf, std_io_Error> = v70 |> Ok
            let _run_target_args'_v72 = v79 
            #endif
#if FABLE_COMPILER_PYTHON
            let v80 : Result<std_path_PathBuf, std_io_Error> = v70 |> Ok
            let _run_target_args'_v72 = v80 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v81 : Result<std_path_PathBuf, std_io_Error> = v70 |> Ok
            let _run_target_args'_v72 = v81 
            #endif
#else
            let v82 : Result<std_path_PathBuf, std_io_Error> = v70 |> Ok
            let _run_target_args'_v72 = v82 
            #endif
            let v83 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v72 
            v83
    let _run_target_args'_v6 = v90 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v91 : string = "std::fs::read_link(&*$0)"
    let v92 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v91 
    let v93 : (std_io_Error -> string) = method41()
    (* run_target_args'
    let v95 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v96 : string = "$0.map_err(|x| $1(x))"
    let v97 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v92, v93) v96 
    let _run_target_args'_v95 = v97 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v98 : string = "$0.map_err(|x| $1(x))"
    let v99 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v92, v93) v98 
    let _run_target_args'_v95 = v99 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v100 : string = "$0.map_err(|x| $1(x))"
    let v101 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v92, v93) v100 
    let _run_target_args'_v95 = v101 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v102 : Result<std_path_PathBuf, string> = match v92 with Ok x -> Ok x | Error x -> Error (v93 x)
    let _run_target_args'_v95 = v102 
    #endif
#if FABLE_COMPILER_PYTHON
    let v103 : Result<std_path_PathBuf, string> = match v92 with Ok x -> Ok x | Error x -> Error (v93 x)
    let _run_target_args'_v95 = v103 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v104 : Result<std_path_PathBuf, string> = match v92 with Ok x -> Ok x | Error x -> Error (v93 x)
    let _run_target_args'_v95 = v104 
    #endif
#else
    let v105 : Result<std_path_PathBuf, string> = match v92 with Ok x -> Ok x | Error x -> Error (v93 x)
    let _run_target_args'_v95 = v105 
    #endif
    let v106 : Result<std_path_PathBuf, string> = _run_target_args'_v95 
    let v109 : (std_path_PathBuf -> US9) = method43()
    let v110 : (string -> US9) = method44()
    let v111 : US9 = match v106 with Ok x -> v109 x | Error x -> v110 x
    let v132 : Result<std_path_PathBuf, std_io_Error> =
        match v111 with
        | US9_1(v128) -> (* Error *)
            let v129 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method49(v0, v129, v1, v128)
        | US9_0(v112) -> (* Ok *)
            (* run_target_args'
            let v114 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v115 : string = "Ok($0)"
            let v116 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v112 v115 
            let _run_target_args'_v114 = v116 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v117 : string = "Ok($0)"
            let v118 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v112 v117 
            let _run_target_args'_v114 = v118 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v119 : string = "Ok($0)"
            let v120 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v112 v119 
            let _run_target_args'_v114 = v120 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v121 : Result<std_path_PathBuf, std_io_Error> = v112 |> Ok
            let _run_target_args'_v114 = v121 
            #endif
#if FABLE_COMPILER_PYTHON
            let v122 : Result<std_path_PathBuf, std_io_Error> = v112 |> Ok
            let _run_target_args'_v114 = v122 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v123 : Result<std_path_PathBuf, std_io_Error> = v112 |> Ok
            let _run_target_args'_v114 = v123 
            #endif
#else
            let v124 : Result<std_path_PathBuf, std_io_Error> = v112 |> Ok
            let _run_target_args'_v114 = v124 
            #endif
            let v125 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v114 
            v125
    let _run_target_args'_v6 = v132 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v134 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v6 = v134 
    #endif
#if FABLE_COMPILER_PYTHON
    let v138 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v6 = v138 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v142 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v6 = v142 
    #endif
#else
    let v146 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v6 = v146 
    #endif
    let v149 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v6 
    v149
and method51 (v0 : System_IO_DirectoryInfo) : System.IO.FileAttributes =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v5 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v5 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v5 = v15 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v5 = v19 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v5 = v23 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v27 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v5 = v27 
    #endif
#else
    let v30 : (System_IO_DirectoryInfo -> System.IO.FileAttributes) = _.Attributes
    let v31 : System.IO.FileAttributes = v30 v0
    let _run_target_args'_v5 = v31 
    #endif
    let v32 : System.IO.FileAttributes = _run_target_args'_v5 
    v32
and method52 () : System.IO.FileAttributes =
    (* run_target_args'
    let v4 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v4 = v6 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v4 = v10 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v14 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v4 = v14 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v4 = v18 
    #endif
#if FABLE_COMPILER_PYTHON
    let v22 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v4 = v22 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v26 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v4 = v26 
    #endif
#else
    let v29 : System.IO.FileAttributes = System.IO.FileAttributes.ReparsePoint
    let _run_target_args'_v4 = v29 
    #endif
    let v30 : System.IO.FileAttributes = _run_target_args'_v4 
    v30
and method53 (v0 : System.IO.FileAttributes, v1 : System.IO.FileAttributes) : bool =
    (* run_target_args'
    let v6 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : bool = null |> unbox<bool>
    let _run_target_args'_v6 = v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12 : bool = null |> unbox<bool>
    let _run_target_args'_v6 = v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : bool = null |> unbox<bool>
    let _run_target_args'_v6 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : bool = null |> unbox<bool>
    let _run_target_args'_v6 = v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v24 : bool = null |> unbox<bool>
    let _run_target_args'_v6 = v24 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v28 : bool = null |> unbox<bool>
    let _run_target_args'_v6 = v28 
    #endif
#else
    let v31 : bool = v1.HasFlag v0 
    let _run_target_args'_v6 = v31 
    #endif
    let v32 : bool = _run_target_args'_v6 
    v32
and method55 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : std_io_Error, v4 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v5 : string = method47(v4)
    let v6 : string option = method33(v4)
    let v8 : (string -> US5) = method6()
    let v9 : US5 option = v6 |> Option.map v8 
    let v22 : US5 = US5_1
    let v23 : US5 = v9 |> Option.defaultValue v22 
    let v27 : string = method42(v3)
    let v28 : bool = v2 >= 11uy
    if v28 then
        let v29 : string = $"file_system.read_link / "
        let v30 : string = $"path: {v0} / n: {v2} / path': {v4} / name: {v5}"
        let v31 : string = v29 + v30 
        (* run_target_args'
        let v36 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v37 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v38 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v31 v37 
        let _run_target_args'_v36 = v38 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v39 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v40 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v31 v39 
        let _run_target_args'_v36 = v40 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v41 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v42 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v31 v41 
        let _run_target_args'_v36 = v42 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v44 : std_io_Error = v31 |> unbox<std_io_Error>
        let _run_target_args'_v36 = v44 
        #endif
#if FABLE_COMPILER_PYTHON
        let v48 : std_io_Error = v31 |> unbox<std_io_Error>
        let _run_target_args'_v36 = v48 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v52 : std_io_Error = v31 |> unbox<std_io_Error>
        let _run_target_args'_v36 = v52 
        #endif
#else
        let v56 : std_io_Error = v31 |> unbox<std_io_Error>
        let _run_target_args'_v36 = v56 
        #endif
        let v59 : std_io_Error = _run_target_args'_v36 
        (* run_target_args'
        let v66 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v67 : string = "Err($0)"
        let v68 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v59 v67 
        let _run_target_args'_v66 = v68 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v69 : string = "Err($0)"
        let v70 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v59 v69 
        let _run_target_args'_v66 = v70 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v71 : string = "Err($0)"
        let v72 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v59 v71 
        let _run_target_args'_v66 = v72 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v73 : Result<std_path_PathBuf, std_io_Error> = v59 |> Error
        let _run_target_args'_v66 = v73 
        #endif
#if FABLE_COMPILER_PYTHON
        let v74 : Result<std_path_PathBuf, std_io_Error> = v59 |> Error
        let _run_target_args'_v66 = v74 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v75 : Result<std_path_PathBuf, std_io_Error> = v59 |> Error
        let _run_target_args'_v66 = v75 
        #endif
#else
        let v76 : Result<std_path_PathBuf, std_io_Error> = v59 |> Error
        let _run_target_args'_v66 = v76 
        #endif
        let v77 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v66 
        v77
    else
        match v23 with
        | US5_0(v80) -> (* Some *)
            let v83 : string = ""
            let v84 : bool = v4 <> v83 
            if v84 then
                let v87 : uint8 = v2 + 1uy
                let v88 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v87
                let v89 : Result<std_path_PathBuf, std_io_Error> = v88 v80
                let v90 : (std_io_Error -> string) = method41()
                (* run_target_args'
                let v92 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v93 : string = "$0.map_err(|x| $1(x))"
                let v94 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v89, v90) v93 
                let _run_target_args'_v92 = v94 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v95 : string = "$0.map_err(|x| $1(x))"
                let v96 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v89, v90) v95 
                let _run_target_args'_v92 = v96 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v97 : string = "$0.map_err(|x| $1(x))"
                let v98 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v89, v90) v97 
                let _run_target_args'_v92 = v98 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v99 : Result<std_path_PathBuf, string> = match v89 with Ok x -> Ok x | Error x -> Error (v90 x)
                let _run_target_args'_v92 = v99 
                #endif
#if FABLE_COMPILER_PYTHON
                let v100 : Result<std_path_PathBuf, string> = match v89 with Ok x -> Ok x | Error x -> Error (v90 x)
                let _run_target_args'_v92 = v100 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v101 : Result<std_path_PathBuf, string> = match v89 with Ok x -> Ok x | Error x -> Error (v90 x)
                let _run_target_args'_v92 = v101 
                #endif
#else
                let v102 : Result<std_path_PathBuf, string> = match v89 with Ok x -> Ok x | Error x -> Error (v90 x)
                let _run_target_args'_v92 = v102 
                #endif
                let v103 : Result<std_path_PathBuf, string> = _run_target_args'_v92 
                let v106 : (std_path_PathBuf -> US9) = method43()
                let v107 : (string -> US9) = method44()
                let v108 : US9 = match v103 with Ok x -> v106 x | Error x -> v107 x
                match v108 with
                | US9_1(v262) -> (* Error *)
                    let v263 : string = $"file_system.read_link / "
                    let v264 : string = $"error': {v262} / error: {v27} / name: {v5}"
                    let v265 : string = v263 + v264 
                    (* run_target_args'
                    let v270 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v271 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v272 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v265 v271 
                    let _run_target_args'_v270 = v272 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v273 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v274 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v265 v273 
                    let _run_target_args'_v270 = v274 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v275 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v276 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v265 v275 
                    let _run_target_args'_v270 = v276 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v278 : std_io_Error = v265 |> unbox<std_io_Error>
                    let _run_target_args'_v270 = v278 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v282 : std_io_Error = v265 |> unbox<std_io_Error>
                    let _run_target_args'_v270 = v282 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v286 : std_io_Error = v265 |> unbox<std_io_Error>
                    let _run_target_args'_v270 = v286 
                    #endif
#else
                    let v290 : std_io_Error = v265 |> unbox<std_io_Error>
                    let _run_target_args'_v270 = v290 
                    #endif
                    let v293 : std_io_Error = _run_target_args'_v270 
                    (* run_target_args'
                    let v300 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v301 : string = "Err($0)"
                    let v302 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v293 v301 
                    let _run_target_args'_v300 = v302 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v303 : string = "Err($0)"
                    let v304 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v293 v303 
                    let _run_target_args'_v300 = v304 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v305 : string = "Err($0)"
                    let v306 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v293 v305 
                    let _run_target_args'_v300 = v306 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v307 : Result<std_path_PathBuf, std_io_Error> = v293 |> Error
                    let _run_target_args'_v300 = v307 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v308 : Result<std_path_PathBuf, std_io_Error> = v293 |> Error
                    let _run_target_args'_v300 = v308 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v309 : Result<std_path_PathBuf, std_io_Error> = v293 |> Error
                    let _run_target_args'_v300 = v309 
                    #endif
#else
                    let v310 : Result<std_path_PathBuf, std_io_Error> = v293 |> Error
                    let _run_target_args'_v300 = v310 
                    #endif
                    let v311 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v300 
                    v311
                | US9_0(v109) -> (* Ok *)
                    (* run_target_args'
                    let v114 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v115 : string = "$0.display()"
                    let v116 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v109 v115 
                    let _run_target_args'_v114 = v116 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v117 : string = "$0.display()"
                    let v118 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v109 v117 
                    let _run_target_args'_v114 = v118 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v119 : string = "$0.display()"
                    let v120 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v109 v119 
                    let _run_target_args'_v114 = v120 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v122 : std_path_Display = v109 |> unbox<std_path_Display>
                    let _run_target_args'_v114 = v122 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v126 : std_path_Display = v109 |> unbox<std_path_Display>
                    let _run_target_args'_v114 = v126 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v130 : std_path_Display = v109 |> unbox<std_path_Display>
                    let _run_target_args'_v114 = v130 
                    #endif
#else
                    let v134 : std_path_Display = v109 |> unbox<std_path_Display>
                    let _run_target_args'_v114 = v134 
                    #endif
                    let v137 : std_path_Display = _run_target_args'_v114 
                    let v144 : string = v137 |> string 
                    let v147 : string = method28(v144, v5)
                    (* run_target_args'
                    let v152 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v153 : string = "&*$0"
                    let v154 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v147 v153 
                    let _run_target_args'_v152 = v154 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v155 : string = "&*$0"
                    let v156 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v147 v155 
                    let _run_target_args'_v152 = v156 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v157 : string = "&*$0"
                    let v158 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v147 v157 
                    let _run_target_args'_v152 = v158 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v160 : Ref<Str> = v147 |> unbox<Ref<Str>>
                    let _run_target_args'_v152 = v160 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v164 : Ref<Str> = v147 |> unbox<Ref<Str>>
                    let _run_target_args'_v152 = v164 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v168 : Ref<Str> = v147 |> unbox<Ref<Str>>
                    let _run_target_args'_v152 = v168 
                    #endif
#else
                    let v172 : Ref<Str> = v147 |> unbox<Ref<Str>>
                    let _run_target_args'_v152 = v172 
                    #endif
                    let v175 : Ref<Str> = _run_target_args'_v152 
                    (* run_target_args'
                    let v185 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v186 : string = "String::from($0)"
                    let v187 : std_string_String = Fable.Core.RustInterop.emitRustExpr v175 v186 
                    let _run_target_args'_v185 = v187 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v188 : string = "String::from($0)"
                    let v189 : std_string_String = Fable.Core.RustInterop.emitRustExpr v175 v188 
                    let _run_target_args'_v185 = v189 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v190 : string = "String::from($0)"
                    let v191 : std_string_String = Fable.Core.RustInterop.emitRustExpr v175 v190 
                    let _run_target_args'_v185 = v191 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v193 : std_string_String = v175 |> unbox<std_string_String>
                    let _run_target_args'_v185 = v193 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v197 : std_string_String = v175 |> unbox<std_string_String>
                    let _run_target_args'_v185 = v197 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v201 : std_string_String = v175 |> unbox<std_string_String>
                    let _run_target_args'_v185 = v201 
                    #endif
#else
                    let v205 : std_string_String = v175 |> unbox<std_string_String>
                    let _run_target_args'_v185 = v205 
                    #endif
                    let v208 : std_string_String = _run_target_args'_v185 
                    (* run_target_args'
                    let v218 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v219 : string = "std::path::PathBuf::from($0)"
                    let v220 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v208 v219 
                    let _run_target_args'_v218 = v220 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v221 : string = "std::path::PathBuf::from($0)"
                    let v222 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v208 v221 
                    let _run_target_args'_v218 = v222 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v223 : string = "std::path::PathBuf::from($0)"
                    let v224 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v208 v223 
                    let _run_target_args'_v218 = v224 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v226 : std_path_PathBuf = v208 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v218 = v226 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v230 : std_path_PathBuf = v208 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v218 = v230 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v234 : std_path_PathBuf = v208 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v218 = v234 
                    #endif
#else
                    let v238 : std_path_PathBuf = v208 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v218 = v238 
                    #endif
                    let v241 : std_path_PathBuf = _run_target_args'_v218 
                    (* run_target_args'
                    let v248 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v249 : string = "Ok($0)"
                    let v250 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v241 v249 
                    let _run_target_args'_v248 = v250 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v251 : string = "Ok($0)"
                    let v252 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v241 v251 
                    let _run_target_args'_v248 = v252 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v253 : string = "Ok($0)"
                    let v254 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v241 v253 
                    let _run_target_args'_v248 = v254 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v255 : Result<std_path_PathBuf, std_io_Error> = v241 |> Ok
                    let _run_target_args'_v248 = v255 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v256 : Result<std_path_PathBuf, std_io_Error> = v241 |> Ok
                    let _run_target_args'_v248 = v256 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v257 : Result<std_path_PathBuf, std_io_Error> = v241 |> Ok
                    let _run_target_args'_v248 = v257 
                    #endif
#else
                    let v258 : Result<std_path_PathBuf, std_io_Error> = v241 |> Ok
                    let _run_target_args'_v248 = v258 
                    #endif
                    let v259 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v248 
                    v259
            else
                let v316 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v317 : string = $"path: {v0} / error: {v27} / path': {v4} / name: {v5}"
                let v318 : string = v316 + v317 
                (* run_target_args'
                let v323 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v324 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v325 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v318 v324 
                let _run_target_args'_v323 = v325 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v326 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v327 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v318 v326 
                let _run_target_args'_v323 = v327 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v328 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v329 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v318 v328 
                let _run_target_args'_v323 = v329 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v331 : std_io_Error = v318 |> unbox<std_io_Error>
                let _run_target_args'_v323 = v331 
                #endif
#if FABLE_COMPILER_PYTHON
                let v335 : std_io_Error = v318 |> unbox<std_io_Error>
                let _run_target_args'_v323 = v335 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v339 : std_io_Error = v318 |> unbox<std_io_Error>
                let _run_target_args'_v323 = v339 
                #endif
#else
                let v343 : std_io_Error = v318 |> unbox<std_io_Error>
                let _run_target_args'_v323 = v343 
                #endif
                let v346 : std_io_Error = _run_target_args'_v323 
                (* run_target_args'
                let v353 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v354 : string = "Err($0)"
                let v355 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v346 v354 
                let _run_target_args'_v353 = v355 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v356 : string = "Err($0)"
                let v357 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v346 v356 
                let _run_target_args'_v353 = v357 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v358 : string = "Err($0)"
                let v359 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v346 v358 
                let _run_target_args'_v353 = v359 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v360 : Result<std_path_PathBuf, std_io_Error> = v346 |> Error
                let _run_target_args'_v353 = v360 
                #endif
#if FABLE_COMPILER_PYTHON
                let v361 : Result<std_path_PathBuf, std_io_Error> = v346 |> Error
                let _run_target_args'_v353 = v361 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v362 : Result<std_path_PathBuf, std_io_Error> = v346 |> Error
                let _run_target_args'_v353 = v362 
                #endif
#else
                let v363 : Result<std_path_PathBuf, std_io_Error> = v346 |> Error
                let _run_target_args'_v353 = v363 
                #endif
                let v364 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v353 
                v364
        | _ ->
            let v368 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v369 : string = $"path: {v0} / error: {v27} / path': {v4} / name: {v5}"
            let v370 : string = v368 + v369 
            (* run_target_args'
            let v375 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v376 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v377 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v370 v376 
            let _run_target_args'_v375 = v377 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v378 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v379 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v370 v378 
            let _run_target_args'_v375 = v379 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v380 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v381 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v370 v380 
            let _run_target_args'_v375 = v381 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v383 : std_io_Error = v370 |> unbox<std_io_Error>
            let _run_target_args'_v375 = v383 
            #endif
#if FABLE_COMPILER_PYTHON
            let v387 : std_io_Error = v370 |> unbox<std_io_Error>
            let _run_target_args'_v375 = v387 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v391 : std_io_Error = v370 |> unbox<std_io_Error>
            let _run_target_args'_v375 = v391 
            #endif
#else
            let v395 : std_io_Error = v370 |> unbox<std_io_Error>
            let _run_target_args'_v375 = v395 
            #endif
            let v398 : std_io_Error = _run_target_args'_v375 
            (* run_target_args'
            let v405 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v406 : string = "Err($0)"
            let v407 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v398 v406 
            let _run_target_args'_v405 = v407 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v408 : string = "Err($0)"
            let v409 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v398 v408 
            let _run_target_args'_v405 = v409 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v410 : string = "Err($0)"
            let v411 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v398 v410 
            let _run_target_args'_v405 = v411 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v412 : Result<std_path_PathBuf, std_io_Error> = v398 |> Error
            let _run_target_args'_v405 = v412 
            #endif
#if FABLE_COMPILER_PYTHON
            let v413 : Result<std_path_PathBuf, std_io_Error> = v398 |> Error
            let _run_target_args'_v405 = v413 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v414 : Result<std_path_PathBuf, std_io_Error> = v398 |> Error
            let _run_target_args'_v405 = v414 
            #endif
#else
            let v415 : Result<std_path_PathBuf, std_io_Error> = v398 |> Error
            let _run_target_args'_v405 = v415 
            #endif
            let v416 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v405 
            v416
and method54 (v0 : string, v1 : uint8, v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    (* run_target_args'
    let v7 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v7 = v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v7 = v13 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v17 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v7 = v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v21 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v7 = v21 
    #endif
#if FABLE_COMPILER_PYTHON
    let v25 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v7 = v25 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v29 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v7 = v29 
    #endif
#else
    let v33 : System_IO_DirectoryInfo = v2 |> System_IO_DirectoryInfo 
    let _run_target_args'_v7 = v33 
    #endif
    let v36 : System_IO_DirectoryInfo = _run_target_args'_v7 
    let v42 : System.IO.FileAttributes = method51(v36)
    let v43 : System.IO.FileAttributes = method52()
    let v44 : bool = method53(v43, v42)
    if v44 then
        (* run_target_args'
        let v49 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v51 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v49 = v51 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v55 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v49 = v55 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v59 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v49 = v59 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v63 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v49 = v63 
        #endif
#if FABLE_COMPILER_PYTHON
        let v67 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v49 = v67 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v71 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v49 = v71 
        #endif
#else
        let v75 : System_IO_FileInfo = v2 |> System_IO_FileInfo 
        let _run_target_args'_v49 = v75 
        #endif
        let v78 : System_IO_FileInfo = _run_target_args'_v49 
        (* run_target_args'
        let v88 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v90 : string = null |> unbox<string>
        let _run_target_args'_v88 = v90 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v94 : string = null |> unbox<string>
        let _run_target_args'_v88 = v94 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v98 : string = null |> unbox<string>
        let _run_target_args'_v88 = v98 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v102 : string = null |> unbox<string>
        let _run_target_args'_v88 = v102 
        #endif
#if FABLE_COMPILER_PYTHON
        let v106 : string = null |> unbox<string>
        let _run_target_args'_v88 = v106 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v110 : string = null |> unbox<string>
        let _run_target_args'_v88 = v110 
        #endif
#else
        let v113 : (System_IO_FileInfo -> string) = _.LinkTarget
        let v114 : string = v113 v78
        let _run_target_args'_v88 = v114 
        #endif
        let v115 : string = _run_target_args'_v88 
        let v122 : std_path_PathBuf = v115 |> unbox<std_path_PathBuf>
        (* run_target_args'
        let v126 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v127 : string = "Ok($0)"
        let v128 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v122 v127 
        let _run_target_args'_v126 = v128 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v129 : string = "Ok($0)"
        let v130 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v122 v129 
        let _run_target_args'_v126 = v130 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v131 : string = "Ok($0)"
        let v132 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v122 v131 
        let _run_target_args'_v126 = v132 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v133 : Result<std_path_PathBuf, std_io_Error> = v122 |> Ok
        let _run_target_args'_v126 = v133 
        #endif
#if FABLE_COMPILER_PYTHON
        let v134 : Result<std_path_PathBuf, std_io_Error> = v122 |> Ok
        let _run_target_args'_v126 = v134 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v135 : Result<std_path_PathBuf, std_io_Error> = v122 |> Ok
        let _run_target_args'_v126 = v135 
        #endif
#else
        let v136 : Result<std_path_PathBuf, std_io_Error> = v122 |> Ok
        let _run_target_args'_v126 = v136 
        #endif
        let v137 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v126 
        v137
    else
        let v140 : string = $"file_system.read_link / Fsharp / "
        let v141 : string = $"The file or directory is not a reparse point. / "
        let v142 : string = v140 + v141 
        let v143 : string = $"path: {v0} / result: {v44} / path': {v2} / n: {v1}"
        let v144 : string = v142 + v143 
        (* run_target_args'
        let v149 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v150 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v151 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v144 v150 
        let _run_target_args'_v149 = v151 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v152 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v153 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v144 v152 
        let _run_target_args'_v149 = v153 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v154 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v155 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v144 v154 
        let _run_target_args'_v149 = v155 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v157 : std_io_Error = v144 |> unbox<std_io_Error>
        let _run_target_args'_v149 = v157 
        #endif
#if FABLE_COMPILER_PYTHON
        let v161 : std_io_Error = v144 |> unbox<std_io_Error>
        let _run_target_args'_v149 = v161 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v165 : std_io_Error = v144 |> unbox<std_io_Error>
        let _run_target_args'_v149 = v165 
        #endif
#else
        let v169 : std_io_Error = v144 |> unbox<std_io_Error>
        let _run_target_args'_v149 = v169 
        #endif
        let v172 : std_io_Error = _run_target_args'_v149 
        let v178 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure21(v0)
        method55(v0, v178, v1, v172, v2)
and closure22 (v0 : string, v1 : uint8) (v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    method54(v0, v1, v2)
and closure21 (v0 : string) (v1 : uint8) : (string -> Result<std_path_PathBuf, std_io_Error>) =
    closure22(v0, v1)
and method56 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : std_io_Error) : Result<std_path_PathBuf, std_io_Error> =
    let v4 : string = method47(v0)
    let v5 : string option = method33(v0)
    let v7 : (string -> US5) = method6()
    let v8 : US5 option = v5 |> Option.map v7 
    let v21 : US5 = US5_1
    let v22 : US5 = v8 |> Option.defaultValue v21 
    let v26 : string = method42(v3)
    let v27 : bool = v2 >= 11uy
    if v27 then
        let v28 : string = $"file_system.read_link / "
        let v29 : string = $"path: {v0} / n: {v2} / path': {v0} / name: {v4}"
        let v30 : string = v28 + v29 
        (* run_target_args'
        let v35 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v36 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v37 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v30 v36 
        let _run_target_args'_v35 = v37 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v38 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v39 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v30 v38 
        let _run_target_args'_v35 = v39 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v40 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v41 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v30 v40 
        let _run_target_args'_v35 = v41 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v43 : std_io_Error = v30 |> unbox<std_io_Error>
        let _run_target_args'_v35 = v43 
        #endif
#if FABLE_COMPILER_PYTHON
        let v47 : std_io_Error = v30 |> unbox<std_io_Error>
        let _run_target_args'_v35 = v47 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v51 : std_io_Error = v30 |> unbox<std_io_Error>
        let _run_target_args'_v35 = v51 
        #endif
#else
        let v55 : std_io_Error = v30 |> unbox<std_io_Error>
        let _run_target_args'_v35 = v55 
        #endif
        let v58 : std_io_Error = _run_target_args'_v35 
        (* run_target_args'
        let v65 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v66 : string = "Err($0)"
        let v67 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v58 v66 
        let _run_target_args'_v65 = v67 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v68 : string = "Err($0)"
        let v69 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v58 v68 
        let _run_target_args'_v65 = v69 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v70 : string = "Err($0)"
        let v71 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v58 v70 
        let _run_target_args'_v65 = v71 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v72 : Result<std_path_PathBuf, std_io_Error> = v58 |> Error
        let _run_target_args'_v65 = v72 
        #endif
#if FABLE_COMPILER_PYTHON
        let v73 : Result<std_path_PathBuf, std_io_Error> = v58 |> Error
        let _run_target_args'_v65 = v73 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v74 : Result<std_path_PathBuf, std_io_Error> = v58 |> Error
        let _run_target_args'_v65 = v74 
        #endif
#else
        let v75 : Result<std_path_PathBuf, std_io_Error> = v58 |> Error
        let _run_target_args'_v65 = v75 
        #endif
        let v76 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v65 
        v76
    else
        match v22 with
        | US5_0(v79) -> (* Some *)
            let v82 : string = ""
            let v83 : bool = v0 <> v82 
            if v83 then
                let v86 : uint8 = v2 + 1uy
                let v87 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v86
                let v88 : Result<std_path_PathBuf, std_io_Error> = v87 v79
                let v89 : (std_io_Error -> string) = method41()
                (* run_target_args'
                let v91 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v92 : string = "$0.map_err(|x| $1(x))"
                let v93 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v88, v89) v92 
                let _run_target_args'_v91 = v93 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v94 : string = "$0.map_err(|x| $1(x))"
                let v95 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v88, v89) v94 
                let _run_target_args'_v91 = v95 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v96 : string = "$0.map_err(|x| $1(x))"
                let v97 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v88, v89) v96 
                let _run_target_args'_v91 = v97 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v98 : Result<std_path_PathBuf, string> = match v88 with Ok x -> Ok x | Error x -> Error (v89 x)
                let _run_target_args'_v91 = v98 
                #endif
#if FABLE_COMPILER_PYTHON
                let v99 : Result<std_path_PathBuf, string> = match v88 with Ok x -> Ok x | Error x -> Error (v89 x)
                let _run_target_args'_v91 = v99 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v100 : Result<std_path_PathBuf, string> = match v88 with Ok x -> Ok x | Error x -> Error (v89 x)
                let _run_target_args'_v91 = v100 
                #endif
#else
                let v101 : Result<std_path_PathBuf, string> = match v88 with Ok x -> Ok x | Error x -> Error (v89 x)
                let _run_target_args'_v91 = v101 
                #endif
                let v102 : Result<std_path_PathBuf, string> = _run_target_args'_v91 
                let v105 : (std_path_PathBuf -> US9) = method43()
                let v106 : (string -> US9) = method44()
                let v107 : US9 = match v102 with Ok x -> v105 x | Error x -> v106 x
                match v107 with
                | US9_1(v261) -> (* Error *)
                    let v262 : string = $"file_system.read_link / "
                    let v263 : string = $"error': {v261} / error: {v26} / name: {v4}"
                    let v264 : string = v262 + v263 
                    (* run_target_args'
                    let v269 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v270 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v271 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v264 v270 
                    let _run_target_args'_v269 = v271 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v272 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v273 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v264 v272 
                    let _run_target_args'_v269 = v273 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v274 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v275 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v264 v274 
                    let _run_target_args'_v269 = v275 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v277 : std_io_Error = v264 |> unbox<std_io_Error>
                    let _run_target_args'_v269 = v277 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v281 : std_io_Error = v264 |> unbox<std_io_Error>
                    let _run_target_args'_v269 = v281 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v285 : std_io_Error = v264 |> unbox<std_io_Error>
                    let _run_target_args'_v269 = v285 
                    #endif
#else
                    let v289 : std_io_Error = v264 |> unbox<std_io_Error>
                    let _run_target_args'_v269 = v289 
                    #endif
                    let v292 : std_io_Error = _run_target_args'_v269 
                    (* run_target_args'
                    let v299 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v300 : string = "Err($0)"
                    let v301 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v292 v300 
                    let _run_target_args'_v299 = v301 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v302 : string = "Err($0)"
                    let v303 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v292 v302 
                    let _run_target_args'_v299 = v303 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v304 : string = "Err($0)"
                    let v305 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v292 v304 
                    let _run_target_args'_v299 = v305 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v306 : Result<std_path_PathBuf, std_io_Error> = v292 |> Error
                    let _run_target_args'_v299 = v306 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v307 : Result<std_path_PathBuf, std_io_Error> = v292 |> Error
                    let _run_target_args'_v299 = v307 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v308 : Result<std_path_PathBuf, std_io_Error> = v292 |> Error
                    let _run_target_args'_v299 = v308 
                    #endif
#else
                    let v309 : Result<std_path_PathBuf, std_io_Error> = v292 |> Error
                    let _run_target_args'_v299 = v309 
                    #endif
                    let v310 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v299 
                    v310
                | US9_0(v108) -> (* Ok *)
                    (* run_target_args'
                    let v113 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v114 : string = "$0.display()"
                    let v115 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v108 v114 
                    let _run_target_args'_v113 = v115 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v116 : string = "$0.display()"
                    let v117 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v108 v116 
                    let _run_target_args'_v113 = v117 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v118 : string = "$0.display()"
                    let v119 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v108 v118 
                    let _run_target_args'_v113 = v119 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v121 : std_path_Display = v108 |> unbox<std_path_Display>
                    let _run_target_args'_v113 = v121 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v125 : std_path_Display = v108 |> unbox<std_path_Display>
                    let _run_target_args'_v113 = v125 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v129 : std_path_Display = v108 |> unbox<std_path_Display>
                    let _run_target_args'_v113 = v129 
                    #endif
#else
                    let v133 : std_path_Display = v108 |> unbox<std_path_Display>
                    let _run_target_args'_v113 = v133 
                    #endif
                    let v136 : std_path_Display = _run_target_args'_v113 
                    let v143 : string = v136 |> string 
                    let v146 : string = method28(v143, v4)
                    (* run_target_args'
                    let v151 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v152 : string = "&*$0"
                    let v153 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v146 v152 
                    let _run_target_args'_v151 = v153 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v154 : string = "&*$0"
                    let v155 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v146 v154 
                    let _run_target_args'_v151 = v155 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v156 : string = "&*$0"
                    let v157 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v146 v156 
                    let _run_target_args'_v151 = v157 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v159 : Ref<Str> = v146 |> unbox<Ref<Str>>
                    let _run_target_args'_v151 = v159 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v163 : Ref<Str> = v146 |> unbox<Ref<Str>>
                    let _run_target_args'_v151 = v163 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v167 : Ref<Str> = v146 |> unbox<Ref<Str>>
                    let _run_target_args'_v151 = v167 
                    #endif
#else
                    let v171 : Ref<Str> = v146 |> unbox<Ref<Str>>
                    let _run_target_args'_v151 = v171 
                    #endif
                    let v174 : Ref<Str> = _run_target_args'_v151 
                    (* run_target_args'
                    let v184 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v185 : string = "String::from($0)"
                    let v186 : std_string_String = Fable.Core.RustInterop.emitRustExpr v174 v185 
                    let _run_target_args'_v184 = v186 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v187 : string = "String::from($0)"
                    let v188 : std_string_String = Fable.Core.RustInterop.emitRustExpr v174 v187 
                    let _run_target_args'_v184 = v188 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v189 : string = "String::from($0)"
                    let v190 : std_string_String = Fable.Core.RustInterop.emitRustExpr v174 v189 
                    let _run_target_args'_v184 = v190 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v192 : std_string_String = v174 |> unbox<std_string_String>
                    let _run_target_args'_v184 = v192 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v196 : std_string_String = v174 |> unbox<std_string_String>
                    let _run_target_args'_v184 = v196 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v200 : std_string_String = v174 |> unbox<std_string_String>
                    let _run_target_args'_v184 = v200 
                    #endif
#else
                    let v204 : std_string_String = v174 |> unbox<std_string_String>
                    let _run_target_args'_v184 = v204 
                    #endif
                    let v207 : std_string_String = _run_target_args'_v184 
                    (* run_target_args'
                    let v217 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v218 : string = "std::path::PathBuf::from($0)"
                    let v219 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v207 v218 
                    let _run_target_args'_v217 = v219 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v220 : string = "std::path::PathBuf::from($0)"
                    let v221 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v207 v220 
                    let _run_target_args'_v217 = v221 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v222 : string = "std::path::PathBuf::from($0)"
                    let v223 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v207 v222 
                    let _run_target_args'_v217 = v223 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v225 : std_path_PathBuf = v207 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v217 = v225 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v229 : std_path_PathBuf = v207 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v217 = v229 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v233 : std_path_PathBuf = v207 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v217 = v233 
                    #endif
#else
                    let v237 : std_path_PathBuf = v207 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v217 = v237 
                    #endif
                    let v240 : std_path_PathBuf = _run_target_args'_v217 
                    (* run_target_args'
                    let v247 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v248 : string = "Ok($0)"
                    let v249 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v240 v248 
                    let _run_target_args'_v247 = v249 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v250 : string = "Ok($0)"
                    let v251 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v240 v250 
                    let _run_target_args'_v247 = v251 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v252 : string = "Ok($0)"
                    let v253 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v240 v252 
                    let _run_target_args'_v247 = v253 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v254 : Result<std_path_PathBuf, std_io_Error> = v240 |> Ok
                    let _run_target_args'_v247 = v254 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v255 : Result<std_path_PathBuf, std_io_Error> = v240 |> Ok
                    let _run_target_args'_v247 = v255 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v256 : Result<std_path_PathBuf, std_io_Error> = v240 |> Ok
                    let _run_target_args'_v247 = v256 
                    #endif
#else
                    let v257 : Result<std_path_PathBuf, std_io_Error> = v240 |> Ok
                    let _run_target_args'_v247 = v257 
                    #endif
                    let v258 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v247 
                    v258
            else
                let v315 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v316 : string = $"path: {v0} / error: {v26} / path': {v0} / name: {v4}"
                let v317 : string = v315 + v316 
                (* run_target_args'
                let v322 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v323 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v324 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v317 v323 
                let _run_target_args'_v322 = v324 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v325 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v326 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v317 v325 
                let _run_target_args'_v322 = v326 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v327 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v328 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v317 v327 
                let _run_target_args'_v322 = v328 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v330 : std_io_Error = v317 |> unbox<std_io_Error>
                let _run_target_args'_v322 = v330 
                #endif
#if FABLE_COMPILER_PYTHON
                let v334 : std_io_Error = v317 |> unbox<std_io_Error>
                let _run_target_args'_v322 = v334 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v338 : std_io_Error = v317 |> unbox<std_io_Error>
                let _run_target_args'_v322 = v338 
                #endif
#else
                let v342 : std_io_Error = v317 |> unbox<std_io_Error>
                let _run_target_args'_v322 = v342 
                #endif
                let v345 : std_io_Error = _run_target_args'_v322 
                (* run_target_args'
                let v352 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v353 : string = "Err($0)"
                let v354 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v345 v353 
                let _run_target_args'_v352 = v354 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v355 : string = "Err($0)"
                let v356 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v345 v355 
                let _run_target_args'_v352 = v356 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v357 : string = "Err($0)"
                let v358 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v345 v357 
                let _run_target_args'_v352 = v358 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v359 : Result<std_path_PathBuf, std_io_Error> = v345 |> Error
                let _run_target_args'_v352 = v359 
                #endif
#if FABLE_COMPILER_PYTHON
                let v360 : Result<std_path_PathBuf, std_io_Error> = v345 |> Error
                let _run_target_args'_v352 = v360 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v361 : Result<std_path_PathBuf, std_io_Error> = v345 |> Error
                let _run_target_args'_v352 = v361 
                #endif
#else
                let v362 : Result<std_path_PathBuf, std_io_Error> = v345 |> Error
                let _run_target_args'_v352 = v362 
                #endif
                let v363 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v352 
                v363
        | _ ->
            let v367 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v368 : string = $"path: {v0} / error: {v26} / path': {v0} / name: {v4}"
            let v369 : string = v367 + v368 
            (* run_target_args'
            let v374 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v375 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v376 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v369 v375 
            let _run_target_args'_v374 = v376 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v377 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v378 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v369 v377 
            let _run_target_args'_v374 = v378 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v379 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v380 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v369 v379 
            let _run_target_args'_v374 = v380 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v382 : std_io_Error = v369 |> unbox<std_io_Error>
            let _run_target_args'_v374 = v382 
            #endif
#if FABLE_COMPILER_PYTHON
            let v386 : std_io_Error = v369 |> unbox<std_io_Error>
            let _run_target_args'_v374 = v386 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v390 : std_io_Error = v369 |> unbox<std_io_Error>
            let _run_target_args'_v374 = v390 
            #endif
#else
            let v394 : std_io_Error = v369 |> unbox<std_io_Error>
            let _run_target_args'_v374 = v394 
            #endif
            let v397 : std_io_Error = _run_target_args'_v374 
            (* run_target_args'
            let v404 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v405 : string = "Err($0)"
            let v406 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v397 v405 
            let _run_target_args'_v404 = v406 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v407 : string = "Err($0)"
            let v408 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v397 v407 
            let _run_target_args'_v404 = v408 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v409 : string = "Err($0)"
            let v410 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v397 v409 
            let _run_target_args'_v404 = v410 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v411 : Result<std_path_PathBuf, std_io_Error> = v397 |> Error
            let _run_target_args'_v404 = v411 
            #endif
#if FABLE_COMPILER_PYTHON
            let v412 : Result<std_path_PathBuf, std_io_Error> = v397 |> Error
            let _run_target_args'_v404 = v412 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v413 : Result<std_path_PathBuf, std_io_Error> = v397 |> Error
            let _run_target_args'_v404 = v413 
            #endif
#else
            let v414 : Result<std_path_PathBuf, std_io_Error> = v397 |> Error
            let _run_target_args'_v404 = v414 
            #endif
            let v415 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v404 
            v415
and method50 (v0 : string, v1 : uint8) : Result<std_path_PathBuf, std_io_Error> =
    (* run_target_args'
    let v6 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v6 = v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v6 = v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v6 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v6 = v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v24 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v6 = v24 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v28 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v6 = v28 
    #endif
#else
    let v32 : System_IO_DirectoryInfo = v0 |> System_IO_DirectoryInfo 
    let _run_target_args'_v6 = v32 
    #endif
    let v35 : System_IO_DirectoryInfo = _run_target_args'_v6 
    let v41 : System.IO.FileAttributes = method51(v35)
    let v42 : System.IO.FileAttributes = method52()
    let v43 : bool = method53(v42, v41)
    if v43 then
        (* run_target_args'
        let v48 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v50 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v48 = v50 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v54 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v48 = v54 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v58 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v48 = v58 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v62 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v48 = v62 
        #endif
#if FABLE_COMPILER_PYTHON
        let v66 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v48 = v66 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v70 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v48 = v70 
        #endif
#else
        let v74 : System_IO_FileInfo = v0 |> System_IO_FileInfo 
        let _run_target_args'_v48 = v74 
        #endif
        let v77 : System_IO_FileInfo = _run_target_args'_v48 
        (* run_target_args'
        let v87 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v89 : string = null |> unbox<string>
        let _run_target_args'_v87 = v89 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v93 : string = null |> unbox<string>
        let _run_target_args'_v87 = v93 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v97 : string = null |> unbox<string>
        let _run_target_args'_v87 = v97 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v101 : string = null |> unbox<string>
        let _run_target_args'_v87 = v101 
        #endif
#if FABLE_COMPILER_PYTHON
        let v105 : string = null |> unbox<string>
        let _run_target_args'_v87 = v105 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v109 : string = null |> unbox<string>
        let _run_target_args'_v87 = v109 
        #endif
#else
        let v112 : (System_IO_FileInfo -> string) = _.LinkTarget
        let v113 : string = v112 v77
        let _run_target_args'_v87 = v113 
        #endif
        let v114 : string = _run_target_args'_v87 
        let v121 : std_path_PathBuf = v114 |> unbox<std_path_PathBuf>
        (* run_target_args'
        let v125 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v126 : string = "Ok($0)"
        let v127 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v121 v126 
        let _run_target_args'_v125 = v127 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v128 : string = "Ok($0)"
        let v129 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v121 v128 
        let _run_target_args'_v125 = v129 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v130 : string = "Ok($0)"
        let v131 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v121 v130 
        let _run_target_args'_v125 = v131 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v132 : Result<std_path_PathBuf, std_io_Error> = v121 |> Ok
        let _run_target_args'_v125 = v132 
        #endif
#if FABLE_COMPILER_PYTHON
        let v133 : Result<std_path_PathBuf, std_io_Error> = v121 |> Ok
        let _run_target_args'_v125 = v133 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v134 : Result<std_path_PathBuf, std_io_Error> = v121 |> Ok
        let _run_target_args'_v125 = v134 
        #endif
#else
        let v135 : Result<std_path_PathBuf, std_io_Error> = v121 |> Ok
        let _run_target_args'_v125 = v135 
        #endif
        let v136 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v125 
        v136
    else
        let v139 : string = $"file_system.read_link / Fsharp / "
        let v140 : string = $"The file or directory is not a reparse point. / "
        let v141 : string = v139 + v140 
        let v142 : string = $"path: {v0} / result: {v43} / path': {v0} / n: {v1}"
        let v143 : string = v141 + v142 
        (* run_target_args'
        let v148 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v149 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v150 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v143 v149 
        let _run_target_args'_v148 = v150 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v151 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v152 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v143 v151 
        let _run_target_args'_v148 = v152 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v153 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v154 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v143 v153 
        let _run_target_args'_v148 = v154 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v156 : std_io_Error = v143 |> unbox<std_io_Error>
        let _run_target_args'_v148 = v156 
        #endif
#if FABLE_COMPILER_PYTHON
        let v160 : std_io_Error = v143 |> unbox<std_io_Error>
        let _run_target_args'_v148 = v160 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v164 : std_io_Error = v143 |> unbox<std_io_Error>
        let _run_target_args'_v148 = v164 
        #endif
#else
        let v168 : std_io_Error = v143 |> unbox<std_io_Error>
        let _run_target_args'_v148 = v168 
        #endif
        let v171 : std_io_Error = _run_target_args'_v148 
        let v177 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure21(v0)
        method56(v0, v177, v1, v171)
and method39 (v0 : string) : Result<std_path_PathBuf, std_io_Error> =
    (* run_target_args'
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : bool = method31(v0)
    let v8 : Result<std_path_PathBuf, std_io_Error> =
        if v3 then
            let v4 : string = "std::fs::read_link(&*$0)"
            let v5 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v4 
            v5
        else
            let v6 : uint8 = 0uy
            method40(v0, v6)
    let _run_target_args'_v2 = v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9 : bool = method31(v0)
    let v14 : Result<std_path_PathBuf, std_io_Error> =
        if v9 then
            let v10 : string = "std::fs::read_link(&*$0)"
            let v11 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v10 
            v11
        else
            let v12 : uint8 = 0uy
            method40(v0, v12)
    let _run_target_args'_v2 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : bool = method31(v0)
    let v20 : Result<std_path_PathBuf, std_io_Error> =
        if v15 then
            let v16 : string = "std::fs::read_link(&*$0)"
            let v17 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v16 
            v17
        else
            let v18 : uint8 = 0uy
            method40(v0, v18)
    let _run_target_args'_v2 = v20 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v21 : uint8 = 0uy
    let v22 : Result<std_path_PathBuf, std_io_Error> = method50(v0, v21)
    let _run_target_args'_v2 = v22 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : Result<std_path_PathBuf, std_io_Error> = Unchecked.defaultof<_>
    let _run_target_args'_v2 = v23 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v24 : uint8 = 0uy
    let v25 : Result<std_path_PathBuf, std_io_Error> = method50(v0, v24)
    let _run_target_args'_v2 = v25 
    #endif
#else
    let v26 : uint8 = 0uy
    let v27 : Result<std_path_PathBuf, std_io_Error> = method50(v0, v26)
    let _run_target_args'_v2 = v27 
    #endif
    let v28 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v2 
    v28
and closure23 () (v0 : std_path_PathBuf) : US10 =
    US10_0(v0)
and method57 () : (std_path_PathBuf -> US10) =
    closure23()
and method59 (v0 : string) : string =
    v0
and method60 () : string =
    let v0 : string = ""
    v0
and method58 (v0 : string, v1 : string, v2 : string) : string =
    (* run_target_args'
    let v4 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = $"regex::Regex::new(&$0)"
    let v6 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v0 v5 
    (* run_target_args'
    let v8 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : string = "$0.unwrap()"
    let v10 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v6 v9 
    let _run_target_args'_v8 = v10 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : string = "$0.unwrap()"
    let v12 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v6 v11 
    let _run_target_args'_v8 = v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v13 : string = "$0.unwrap()"
    let v14 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v6 v13 
    let _run_target_args'_v8 = v14 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : regex_Regex = match v6 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v8 = v15 
    #endif
#if FABLE_COMPILER_PYTHON
    let v16 : regex_Regex = match v6 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v8 = v16 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : regex_Regex = match v6 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v8 = v17 
    #endif
#else
    let v18 : regex_Regex = match v6 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v8 = v18 
    #endif
    let v19 : regex_Regex = _run_target_args'_v8 
    let v22 : string = method59(v2)
    let v23 : string = $"$0.replace_all(&*$1, &*$2)"
    let v24 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v19, v22, v1) v23 
    let v25 : string = "String::from($0)"
    let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let v27 : string = "fable_library_rust::String_::fromString($0)"
    let v28 : string = Fable.Core.RustInterop.emitRustExpr v26 v27 
    let _run_target_args'_v4 = v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = method60()
    let _run_target_args'_v4 = v29 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v30 : string = method60()
    let _run_target_args'_v4 = v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v31 : string = method60()
    let _run_target_args'_v4 = v31 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : string = method60()
    let _run_target_args'_v4 = v32 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v33 : string = method60()
    let _run_target_args'_v4 = v33 
    #endif
#else
    let v34 : string = System.Text.RegularExpressions.Regex.Replace (v2, v0, v1)
    let _run_target_args'_v4 = v34 
    #endif
    let v35 : string = _run_target_args'_v4 
    v35
and method38 (v0 : string) : string =
    let v1 : bool = v0 = ""
    if v1 then
        let v2 : string = ""
        v2
    else
        let v3 : Result<std_path_PathBuf, std_io_Error> = method39(v0)
        (* run_target_args'
        let v5 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v6 : string = "$0.ok()"
        let v7 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v3 v6 
        let _run_target_args'_v5 = v7 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v8 : string = "$0.ok()"
        let v9 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v3 v8 
        let _run_target_args'_v5 = v9 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v10 : string = "$0.ok()"
        let v11 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v3 v10 
        let _run_target_args'_v5 = v11 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v12 : std_path_PathBuf option = match v3 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v5 = v12 
        #endif
#if FABLE_COMPILER_PYTHON
        let v13 : std_path_PathBuf option = match v3 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v5 = v13 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v14 : std_path_PathBuf option = match v3 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v5 = v14 
        #endif
#else
        let v15 : std_path_PathBuf option = match v3 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v5 = v15 
        #endif
        let v16 : std_path_PathBuf option = _run_target_args'_v5 
        let v20 : (std_path_PathBuf -> US10) = method57()
        let v21 : US10 option = v16 |> Option.map v20 
        let v34 : US10 = US10_1
        let v35 : US10 = v21 |> Option.defaultValue v34 
        let v78 : string =
            match v35 with
            | US10_1 -> (* None *)
                v0
            | US10_0(v39) -> (* Some *)
                (* run_target_args'
                let v44 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v45 : string = "$0.display()"
                let v46 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v39 v45 
                let _run_target_args'_v44 = v46 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v47 : string = "$0.display()"
                let v48 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v39 v47 
                let _run_target_args'_v44 = v48 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v49 : string = "$0.display()"
                let v50 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v39 v49 
                let _run_target_args'_v44 = v50 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v52 : std_path_Display = v39 |> unbox<std_path_Display>
                let _run_target_args'_v44 = v52 
                #endif
#if FABLE_COMPILER_PYTHON
                let v56 : std_path_Display = v39 |> unbox<std_path_Display>
                let _run_target_args'_v44 = v56 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v60 : std_path_Display = v39 |> unbox<std_path_Display>
                let _run_target_args'_v44 = v60 
                #endif
#else
                let v64 : std_path_Display = v39 |> unbox<std_path_Display>
                let _run_target_args'_v44 = v64 
                #endif
                let v67 : std_path_Display = _run_target_args'_v44 
                let v74 : string = v67 |> string 
                v74
        let v79 : bool = v78 = ""
        let v80 : string =
            if v79 then
                v0
            else
                v78
        let v81 : string = "^\\\\\\\\\\?\\\\"
        let v82 : string = ""
        let v83 : string = method58(v81, v82, v80)
        let v84 : int32 = v83.Length
        let v85 : bool = v84 < 2
        if v85 then
            v0
        else
            let v86 : string = $"{v83.[0] |> string |> _.ToLower()}{v83.[1..]}"
            let v87 : string = "\\"
            let v88 : string = "/"
            let v89 : string = v86.Replace (v87, v88)
            v89
and method27 (v0 : string) : US5 =
    let v1 : US7 = US7_1
    let v2 : string = "spiral"
    let v3 : string = "workspace"
    let v4 : string = method28(v2, v3)
    let v5 : US8 = method29(v1, v4, v0)
    match v5 with
    | US8_1(v9) -> (* Error *)
        let v10 : unit = ()
        let v11 : (unit -> unit) = closure15(v0, v9)
        let v12 : unit = (fun () -> v11 (); v10) ()
        US5_1
    | US8_0(v6) -> (* Ok *)
        let v7 : string = method38(v6)
        US5_0(v7)
and method62 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method63 (v0 : int32, v1 : Mut6) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method64 () : char =
    (* run_target_args'
    let v1 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "std::path::MAIN_SEPARATOR"
    let v3 : char = Fable.Core.RustInterop.emitRustExpr () v2 
    let _run_target_args'_v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "std::path::MAIN_SEPARATOR"
    let v5 : char = Fable.Core.RustInterop.emitRustExpr () v4 
    let _run_target_args'_v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "std::path::MAIN_SEPARATOR"
    let v7 : char = Fable.Core.RustInterop.emitRustExpr () v6 
    let _run_target_args'_v1 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v1 = '/' 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v1 = '/' 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v8 : char = System.IO.Path.DirectorySeparatorChar
    let _run_target_args'_v1 = v8 
    #endif
#else
    let v9 : char = System.IO.Path.DirectorySeparatorChar
    let _run_target_args'_v1 = v9 
    #endif
    let v10 : char = _run_target_args'_v1 
    v10
and method65 (v0 : string) : string =
    v0
and method61 (v0 : string) : string =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    (* run_target_args'
    let v10 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v11 
    let _run_target_args'_v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v13 
    let _run_target_args'_v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v15 
    let _run_target_args'_v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v18 
    #endif
#if FABLE_COMPILER_PYTHON
    let v22 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v22 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v26 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v26 
    #endif
#else
    let v30 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v30 
    #endif
    let v33 : Ref<Str> = _run_target_args'_v10 
    (* run_target_args'
    let v43 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v44 : string = "String::from($0)"
    let v45 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v44 
    let _run_target_args'_v43 = v45 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v46 : string = "String::from($0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v46 
    let _run_target_args'_v43 = v47 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v48 : string = "String::from($0)"
    let v49 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v48 
    let _run_target_args'_v43 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v51 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v51 
    #endif
#if FABLE_COMPILER_PYTHON
    let v55 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v55 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v59 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v59 
    #endif
#else
    let v63 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v63 
    #endif
    let v66 : std_string_String = _run_target_args'_v43 
    (* run_target_args'
    let v76 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v77 : string = "std::path::PathBuf::from($0)"
    let v78 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v77 
    let _run_target_args'_v76 = v78 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v79 : string = "std::path::PathBuf::from($0)"
    let v80 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v79 
    let _run_target_args'_v76 = v80 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : string = "std::path::PathBuf::from($0)"
    let v82 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v81 
    let _run_target_args'_v76 = v82 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v84 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v84 
    #endif
#if FABLE_COMPILER_PYTHON
    let v88 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v88 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v92 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v92 
    #endif
#else
    let v96 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v96 
    #endif
    let v99 : std_path_PathBuf = _run_target_args'_v76 
    let v105 : string = "$0.exists()"
    let v106 : bool = Fable.Core.RustInterop.emitRustExpr v99 v105 
    let v107 : bool = v106 = false
    let v289 : string =
        if v107 then
            let v108 : string = method26()
            let v109 : string = method28(v108, v0)
            let v110 : string = method38(v109)
            let v112 : string = "/"
            let v113 : (string []) = v110.Split v112 
            let v116 : (string []) = [||]
            let v117 : int32 = v113.Length
            let v118 : Mut5 = {l0 = 0; l1 = 0; l2 = v116} : Mut5
            while method62(v117, v118) do
                let v120 : int32 = v118.l0
                let v121 : int32 =  -v120
                let v122 : int32 = v121 + v117
                let v123 : int32 = v122 - 1
                let struct (v124 : int32, v125 : (string [])) = v118.l1, v118.l2
                let v126 : string = v113.[int v123]
                let v127 : bool = ".." = v126
                let struct (v172 : int32, v173 : (string [])) =
                    if v127 then
                        let v128 : int32 = v124 + 1
                        struct (v128, v125)
                    else
                        let v129 : bool = "." = v126
                        if v129 then
                            struct (v124, v125)
                        else
                            let v130 : bool = 0 = v124
                            if v130 then
                                let v132 : string = ":"
                                let v133 : bool = v126.EndsWith (v132, false, null)
                                if v133 then
                                    let v136 : string = $"{v108.[0]}:"
                                    let v137 : (string []) = [|v136|]
                                    let v138 : int32 = v137.Length
                                    let v139 : int32 = v125.Length
                                    let v140 : int32 = v138 + v139
                                    let v141 : (string []) = Array.zeroCreate<string> (v140)
                                    let v142 : Mut6 = {l0 = 0} : Mut6
                                    while method63(v140, v142) do
                                        let v144 : int32 = v142.l0
                                        let v145 : bool = v144 < v138
                                        let v149 : string =
                                            if v145 then
                                                let v146 : string = v137.[int v144]
                                                v146
                                            else
                                                let v147 : int32 = v144 - v138
                                                let v148 : string = v125.[int v147]
                                                v148
                                        v141.[int v144] <- v149
                                        let v150 : int32 = v144 + 1
                                        v142.l0 <- v150
                                        ()
                                    struct (0, v141)
                                else
                                    let v151 : (string []) = [|v126|]
                                    let v152 : int32 = v151.Length
                                    let v153 : int32 = v125.Length
                                    let v154 : int32 = v152 + v153
                                    let v155 : (string []) = Array.zeroCreate<string> (v154)
                                    let v156 : Mut6 = {l0 = 0} : Mut6
                                    while method63(v154, v156) do
                                        let v158 : int32 = v156.l0
                                        let v159 : bool = v158 < v152
                                        let v163 : string =
                                            if v159 then
                                                let v160 : string = v151.[int v158]
                                                v160
                                            else
                                                let v161 : int32 = v158 - v152
                                                let v162 : string = v125.[int v161]
                                                v162
                                        v155.[int v158] <- v163
                                        let v164 : int32 = v158 + 1
                                        v156.l0 <- v164
                                        ()
                                    struct (0, v155)
                            else
                                let v167 : int32 = v124 - 1
                                struct (v167, v125)
                let v174 : int32 = v120 + 1
                v118.l0 <- v174
                v118.l1 <- v172
                v118.l2 <- v173
                ()
            let struct (v175 : int32, v176 : (string [])) = v118.l1, v118.l2
            let v180 : unit = ()
            let _let'_v180 =
                seq {
                    for i = 0 to v176.Length - 1 do yield v176.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v183 : string seq = _let'_v180 
            let v189 : char = method64()
            let v191 : (char -> string) = _.ToString()
            let v192 : string = v191 v189
            let v196 : bool = v192 = "\n"
            let v198 : string =
                if v196 then
                    method65(v192)
                else
                    v192
            let v199 : (string -> (string seq -> string)) = String.concat
            let v200 : (string seq -> string) = v199 v198
            v200 v183
        else
            let v204 : string = "std::fs::canonicalize(&*$0)"
            let v205 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v204 
            (* run_target_args'
            let v207 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v208 : string = "$0.unwrap()"
            let v209 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v205 v208 
            let _run_target_args'_v207 = v209 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v210 : string = "$0.unwrap()"
            let v211 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v205 v210 
            let _run_target_args'_v207 = v211 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v212 : string = "$0.unwrap()"
            let v213 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v205 v212 
            let _run_target_args'_v207 = v213 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v214 : std_path_PathBuf = match v205 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v207 = v214 
            #endif
#if FABLE_COMPILER_PYTHON
            let v215 : std_path_PathBuf = match v205 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v207 = v215 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v216 : std_path_PathBuf = match v205 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v207 = v216 
            #endif
#else
            let v217 : std_path_PathBuf = match v205 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v207 = v217 
            #endif
            let v218 : std_path_PathBuf = _run_target_args'_v207 
            (* run_target_args'
            let v225 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v226 : string = "$0.display()"
            let v227 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v218 v226 
            let _run_target_args'_v225 = v227 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v228 : string = "$0.display()"
            let v229 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v218 v228 
            let _run_target_args'_v225 = v229 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v230 : string = "$0.display()"
            let v231 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v218 v230 
            let _run_target_args'_v225 = v231 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v233 : std_path_Display = v218 |> unbox<std_path_Display>
            let _run_target_args'_v225 = v233 
            #endif
#if FABLE_COMPILER_PYTHON
            let v237 : std_path_Display = v218 |> unbox<std_path_Display>
            let _run_target_args'_v225 = v237 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v241 : std_path_Display = v218 |> unbox<std_path_Display>
            let _run_target_args'_v225 = v241 
            #endif
#else
            let v245 : std_path_Display = v218 |> unbox<std_path_Display>
            let _run_target_args'_v225 = v245 
            #endif
            let v248 : std_path_Display = _run_target_args'_v225 
            (* run_target_args'
            let v258 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v259 : string = "format!(\"{}\", $0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v248 v259 
            let _run_target_args'_v258 = v260 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v261 : string = "format!(\"{}\", $0)"
            let v262 : std_string_String = Fable.Core.RustInterop.emitRustExpr v248 v261 
            let _run_target_args'_v258 = v262 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v263 : string = "format!(\"{}\", $0)"
            let v264 : std_string_String = Fable.Core.RustInterop.emitRustExpr v248 v263 
            let _run_target_args'_v258 = v264 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v266 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v258 = v266 
            #endif
#if FABLE_COMPILER_PYTHON
            let v270 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v258 = v270 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v274 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v258 = v274 
            #endif
#else
            let v278 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v258 = v278 
            #endif
            let v281 : std_string_String = _run_target_args'_v258 
            let v287 : string = "fable_library_rust::String_::fromString($0)"
            let v288 : string = Fable.Core.RustInterop.emitRustExpr v281 v287 
            v288
    let _run_target_args'_v5 = v289 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v291 : string = null |> unbox<string>
    let _run_target_args'_v5 = v291 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v295 : string = null |> unbox<string>
    let _run_target_args'_v5 = v295 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v299 : string = null |> unbox<string>
    let _run_target_args'_v5 = v299 
    #endif
#if FABLE_COMPILER_PYTHON
    let v303 : string = null |> unbox<string>
    let _run_target_args'_v5 = v303 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v307 : string = null |> unbox<string>
    let _run_target_args'_v5 = v307 
    #endif
#else
    let v310 : (string -> string) = System.IO.Path.GetFullPath
    let v311 : string = v310 v0
    let _run_target_args'_v5 = v311 
    #endif
    let v312 : string = _run_target_args'_v5 
    v312
and method66 () : string =
    
    
    
    
    
    let v1 : string = "Debug"
    let v2 : (unit -> string) = v1.ToLower
    let v3 : string = v2 ()
    let v6 : char = v3.[int 0]
    let v7 : string = method13(v6)
    (* run_target_args'
    let v12 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : string = "inline_colorization::color_bright_blue"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v13 
    (* run_target_args'
    let v19 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "&*$0"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v20 
    let _run_target_args'_v19 = v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v22 
    let _run_target_args'_v19 = v23 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : string = "&*$0"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v24 
    let _run_target_args'_v19 = v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v27 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v31 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v35 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v35 
    #endif
#else
    let v39 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v39 
    #endif
    let v42 : Ref<Str> = _run_target_args'_v19 
    let v48 : string = "inline_colorization::color_reset"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v14, v42, v49) v50 
    let v52 : string = "fable_library_rust::String_::fromString($0)"
    let v53 : string = Fable.Core.RustInterop.emitRustExpr v51 v52 
    let _run_target_args'_v12 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "inline_colorization::color_bright_blue"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v54 
    (* run_target_args'
    let v60 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v61 : string = "&*$0"
    let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v61 
    let _run_target_args'_v60 = v62 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : string = "&*$0"
    let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v63 
    let _run_target_args'_v60 = v64 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = "&*$0"
    let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v65 
    let _run_target_args'_v60 = v66 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v68 
    #endif
#if FABLE_COMPILER_PYTHON
    let v72 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v72 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v76 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v76 
    #endif
#else
    let v80 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v80 
    #endif
    let v83 : Ref<Str> = _run_target_args'_v60 
    let v89 : string = "inline_colorization::color_reset"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v55, v83, v90) v91 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let _run_target_args'_v12 = v94 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v95 : string = "inline_colorization::color_bright_blue"
    let v96 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v95 
    (* run_target_args'
    let v101 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v102 : string = "&*$0"
    let v103 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v102 
    let _run_target_args'_v101 = v103 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : string = "&*$0"
    let v105 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v104 
    let _run_target_args'_v101 = v105 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v106 : string = "&*$0"
    let v107 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v106 
    let _run_target_args'_v101 = v107 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v109 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v109 
    #endif
#if FABLE_COMPILER_PYTHON
    let v113 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v113 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v117 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v117 
    #endif
#else
    let v121 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v121 
    #endif
    let v124 : Ref<Str> = _run_target_args'_v101 
    let v130 : string = "inline_colorization::color_reset"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v96, v124, v131) v132 
    let v134 : string = "fable_library_rust::String_::fromString($0)"
    let v135 : string = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let _run_target_args'_v12 = v135 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v136 : string = "\u001b[94m"
    let v137 : string = method15()
    let v138 : string = v136 + v7 
    let v139 : string = v138 + v137 
    let _run_target_args'_v12 = v139 
    #endif
#if FABLE_COMPILER_PYTHON
    let v140 : string = "\u001b[94m"
    let v141 : string = method15()
    let v142 : string = v140 + v7 
    let v143 : string = v142 + v141 
    let _run_target_args'_v12 = v143 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v144 : string = "\u001b[94m"
    let v145 : string = method15()
    let v146 : string = v144 + v7 
    let v147 : string = v146 + v145 
    let _run_target_args'_v12 = v147 
    #endif
#else
    let v148 : string = "\u001b[94m"
    let v149 : string = method15()
    let v150 : string = v148 + v7 
    let v151 : string = v150 + v149 
    let _run_target_args'_v12 = v151 
    #endif
    let v152 : string = _run_target_args'_v12 
    v152
and method68 (v0 : string, v1 : string, v2 : string, v3 : string) : string =
    let v4 : string = method14()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v11 : unit = ()
    let v12 : (unit -> unit) = closure8(v5, v8)
    let v13 : unit = (fun () -> v12 (); v11) ()
    let v17 : string = "source_dir"
    let v18 : string = $"{v17}"
    let v21 : unit = ()
    let v22 : (unit -> unit) = closure8(v5, v18)
    let v23 : unit = (fun () -> v22 (); v21) ()
    let v27 : string = " = "
    let v28 : string = $"{v27}"
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure8(v5, v28)
    let v33 : unit = (fun () -> v32 (); v31) ()
    let v37 : string = $"{v0}"
    let v40 : unit = ()
    let v41 : (unit -> unit) = closure8(v5, v37)
    let v42 : unit = (fun () -> v41 (); v40) ()
    let v46 : string = "; "
    let v47 : string = $"{v46}"
    let v50 : unit = ()
    let v51 : (unit -> unit) = closure8(v5, v47)
    let v52 : unit = (fun () -> v51 (); v50) ()
    let v56 : string = "dist_dir"
    let v57 : string = $"{v56}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure8(v5, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v66 : string = $"{v27}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure8(v5, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v75 : string = $"{v1}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure8(v5, v75)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v84 : string = $"{v46}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure8(v5, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v93 : string = "cache_dir"
    let v94 : string = $"{v93}"
    let v97 : unit = ()
    let v98 : (unit -> unit) = closure8(v5, v94)
    let v99 : unit = (fun () -> v98 (); v97) ()
    let v103 : string = $"{v27}"
    let v106 : unit = ()
    let v107 : (unit -> unit) = closure8(v5, v103)
    let v108 : unit = (fun () -> v107 (); v106) ()
    let v112 : string = $"{v2}"
    let v115 : unit = ()
    let v116 : (unit -> unit) = closure8(v5, v112)
    let v117 : unit = (fun () -> v116 (); v115) ()
    let v121 : string = $"{v46}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure8(v5, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v130 : string = "hangul_spec"
    let v131 : string = $"{v130}"
    let v134 : unit = ()
    let v135 : (unit -> unit) = closure8(v5, v131)
    let v136 : unit = (fun () -> v135 (); v134) ()
    let v140 : string = $"{v27}"
    let v143 : unit = ()
    let v144 : (unit -> unit) = closure8(v5, v140)
    let v145 : unit = (fun () -> v144 (); v143) ()
    let v149 : string = $"{v3}"
    let v152 : unit = ()
    let v153 : (unit -> unit) = closure8(v5, v149)
    let v154 : unit = (fun () -> v153 (); v152) ()
    let v158 : string = " }"
    let v159 : string = $"{v158}"
    let v162 : unit = ()
    let v163 : (unit -> unit) = closure8(v5, v159)
    let v164 : unit = (fun () -> v163 (); v162) ()
    let v167 : string = v5.l0
    v167
and method67 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : string) : string =
    let v12 : string = method68(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v15 : string = "documents.run"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method18(v16)
and closure24 (v0 : string, v1 : string, v2 : string, v3 : string) () : unit =
    let v4 : US0 = US0_1
    let v5 : bool = method7(v4)
    if v5 then
        let v6 : unit = ()
        let v7 : (unit -> unit) = closure6()
        let v8 : unit = (fun () -> v7 (); v6) ()
        let struct (v29 : Mut0, v30 : Mut1, v31 : Mut2, v32 : Mut3, v33 : Mut4, v34 : int64 option) = TraceState.trace_state.Value
        let v47 : string = method8(v29, v30, v31, v32, v33, v34)
        let v48 : string = method66()
        let v49 : string = method67(v29, v30, v31, v32, v33, v34, v47, v48, v1, v2, v3, v0)
        method19(v49)
and closure26 () (v0 : std_io_Error) : std_string_String =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    let _run_target_args'_v5 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    let _run_target_args'_v5 = v9 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : string = "format!(\"{}\", $0)"
    let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v10 
    let _run_target_args'_v5 = v11 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v17 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v17 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v21 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v21 
    #endif
#else
    let v25 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v25 
    #endif
    let v28 : std_string_String = _run_target_args'_v5 
    v28
and method69 () : (std_io_Error -> std_string_String) =
    closure26()
and closure27 () (v0 : std_fs_FileType) : US11 =
    US11_0(v0)
and method70 () : (std_fs_FileType -> US11) =
    closure27()
and closure28 () (v0 : std_string_String) : US11 =
    US11_1(v0)
and method71 () : (std_string_String -> US11) =
    closure28()
and closure25 () (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> =
    let v1 : string = "true; let __future_init = Box::pin(/*"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = "*/ async { /*"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr () v3 
    let v5 : string = "*/ ()"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr () v5 
    let v7 : string = "true; let __future_init = Box::pin(/*"
    let v8 : bool = Fable.Core.RustInterop.emitRustExpr () v7 
    let v9 : string = "*/ async move { /*"
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr () v9 
    let v11 : string = "*/ ()"
    let v12 : bool = Fable.Core.RustInterop.emitRustExpr () v11 
    let v13 : string = "$0"
    let v14 : async_walkdir_DirEntry = Fable.Core.RustInterop.emitRustExpr v0 v13 
    let v15 : string = "Box::pin(async_walkdir::DirEntry::file_type(&v14))"
    let v16 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>, Send<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>>>>> = Fable.Core.RustInterop.emitRustExpr () v15 
    let v17 : string = "v16.await"
    let v18 : Result<std_fs_FileType, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v17 
    let v19 : (std_io_Error -> std_string_String) = method69()
    (* run_target_args'
    let v21 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v22 : string = "$0.map_err(|x| $1(x))"
    let v23 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v18, v19) v22 
    let _run_target_args'_v21 = v23 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v24 : string = "$0.map_err(|x| $1(x))"
    let v25 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v18, v19) v24 
    let _run_target_args'_v21 = v25 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : string = "$0.map_err(|x| $1(x))"
    let v27 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v18, v19) v26 
    let _run_target_args'_v21 = v27 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v28 : Result<std_fs_FileType, std_string_String> = match v18 with Ok x -> Ok x | Error x -> Error (v19 x)
    let _run_target_args'_v21 = v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v29 : Result<std_fs_FileType, std_string_String> = match v18 with Ok x -> Ok x | Error x -> Error (v19 x)
    let _run_target_args'_v21 = v29 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v30 : Result<std_fs_FileType, std_string_String> = match v18 with Ok x -> Ok x | Error x -> Error (v19 x)
    let _run_target_args'_v21 = v30 
    #endif
#else
    let v31 : Result<std_fs_FileType, std_string_String> = match v18 with Ok x -> Ok x | Error x -> Error (v19 x)
    let _run_target_args'_v21 = v31 
    #endif
    let v32 : Result<std_fs_FileType, std_string_String> = _run_target_args'_v21 
    let v35 : (std_fs_FileType -> US11) = method70()
    let v36 : (std_string_String -> US11) = method71()
    let v37 : US11 = match v32 with Ok x -> v35 x | Error x -> v36 x
    let v213 : US12 =
        match v37 with
        | US11_0(v38) -> (* Ok *)
            let v39 : string = "std::fs::FileType::is_dir(&$0)"
            let v40 : bool = Fable.Core.RustInterop.emitRustExpr v38 v39 
            if v40 then
                US12_0
            else
                let v42 : string = "async_walkdir::DirEntry::path(&$0)"
                let v43 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v0 v42 
                (* run_target_args'
                let v48 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v49 : string = "$0.display()"
                let v50 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v43 v49 
                let _run_target_args'_v48 = v50 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v51 : string = "$0.display()"
                let v52 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v43 v51 
                let _run_target_args'_v48 = v52 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v53 : string = "$0.display()"
                let v54 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v43 v53 
                let _run_target_args'_v48 = v54 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v56 : std_path_Display = v43 |> unbox<std_path_Display>
                let _run_target_args'_v48 = v56 
                #endif
#if FABLE_COMPILER_PYTHON
                let v60 : std_path_Display = v43 |> unbox<std_path_Display>
                let _run_target_args'_v48 = v60 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v64 : std_path_Display = v43 |> unbox<std_path_Display>
                let _run_target_args'_v48 = v64 
                #endif
#else
                let v68 : std_path_Display = v43 |> unbox<std_path_Display>
                let _run_target_args'_v48 = v68 
                #endif
                let v71 : std_path_Display = _run_target_args'_v48 
                (* run_target_args'
                let v81 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v82 : string = "format!(\"{}\", $0)"
                let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v71 v82 
                let _run_target_args'_v81 = v83 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v84 : string = "format!(\"{}\", $0)"
                let v85 : std_string_String = Fable.Core.RustInterop.emitRustExpr v71 v84 
                let _run_target_args'_v81 = v85 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v86 : string = "format!(\"{}\", $0)"
                let v87 : std_string_String = Fable.Core.RustInterop.emitRustExpr v71 v86 
                let _run_target_args'_v81 = v87 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v89 : std_string_String = null |> unbox<std_string_String>
                let _run_target_args'_v81 = v89 
                #endif
#if FABLE_COMPILER_PYTHON
                let v93 : std_string_String = null |> unbox<std_string_String>
                let _run_target_args'_v81 = v93 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v97 : std_string_String = null |> unbox<std_string_String>
                let _run_target_args'_v81 = v97 
                #endif
#else
                let v101 : std_string_String = null |> unbox<std_string_String>
                let _run_target_args'_v81 = v101 
                #endif
                let v104 : std_string_String = _run_target_args'_v81 
                let v110 : string = "fable_library_rust::String_::fromString($0)"
                let v111 : string = Fable.Core.RustInterop.emitRustExpr v104 v110 
                let v113 : string = ".md"
                let v114 : bool = v111.EndsWith (v113, false, null)
                let v117 : bool = v114 = false
                let v123 : bool =
                    if v117 then
                        true
                    else
                        let v119 : string = ".hangul.md"
                        let v120 : bool = v111.EndsWith (v119, false, null)
                        v120
                if v123 then
                    US12_0
                else
                    US12_2
        | _ ->
            let v128 : string = "async_walkdir::DirEntry::path(&$0)"
            let v129 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v0 v128 
            (* run_target_args'
            let v134 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v135 : string = "$0.display()"
            let v136 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v129 v135 
            let _run_target_args'_v134 = v136 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v137 : string = "$0.display()"
            let v138 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v129 v137 
            let _run_target_args'_v134 = v138 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v139 : string = "$0.display()"
            let v140 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v129 v139 
            let _run_target_args'_v134 = v140 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v142 : std_path_Display = v129 |> unbox<std_path_Display>
            let _run_target_args'_v134 = v142 
            #endif
#if FABLE_COMPILER_PYTHON
            let v146 : std_path_Display = v129 |> unbox<std_path_Display>
            let _run_target_args'_v134 = v146 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v150 : std_path_Display = v129 |> unbox<std_path_Display>
            let _run_target_args'_v134 = v150 
            #endif
#else
            let v154 : std_path_Display = v129 |> unbox<std_path_Display>
            let _run_target_args'_v134 = v154 
            #endif
            let v157 : std_path_Display = _run_target_args'_v134 
            (* run_target_args'
            let v167 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v168 : string = "format!(\"{}\", $0)"
            let v169 : std_string_String = Fable.Core.RustInterop.emitRustExpr v157 v168 
            let _run_target_args'_v167 = v169 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v170 : string = "format!(\"{}\", $0)"
            let v171 : std_string_String = Fable.Core.RustInterop.emitRustExpr v157 v170 
            let _run_target_args'_v167 = v171 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v172 : string = "format!(\"{}\", $0)"
            let v173 : std_string_String = Fable.Core.RustInterop.emitRustExpr v157 v172 
            let _run_target_args'_v167 = v173 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v175 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v167 = v175 
            #endif
#if FABLE_COMPILER_PYTHON
            let v179 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v167 = v179 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v183 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v167 = v183 
            #endif
#else
            let v187 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v167 = v187 
            #endif
            let v190 : std_string_String = _run_target_args'_v167 
            let v196 : string = "fable_library_rust::String_::fromString($0)"
            let v197 : string = Fable.Core.RustInterop.emitRustExpr v190 v196 
            let v199 : string = ".md"
            let v200 : bool = v197.EndsWith (v199, false, null)
            let v203 : bool = v200 = false
            let v209 : bool =
                if v203 then
                    true
                else
                    let v205 : string = ".hangul.md"
                    let v206 : bool = v197.EndsWith (v205, false, null)
                    v206
            if v209 then
                US12_0
            else
                US12_2
    let v214 : string = ""
    let v215 : string = "}"
    let v216 : string = v214 + v215 
    let x = v213 //
    let v217 : _ = x
    let v218 : unit = ()
    (* run_target_args'
    let v219 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v220 : string = $"true; let _fix_closure_v218 = $0"
    let v221 : bool = Fable.Core.RustInterop.emitRustExpr v217 v220 
    let _run_target_args'_v219 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v222 : string = $"true; let _fix_closure_v218 = $0"
    let v223 : bool = Fable.Core.RustInterop.emitRustExpr v217 v222 
    let _run_target_args'_v219 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v224 : string = $"true; let _fix_closure_v218 = $0"
    let v225 : bool = Fable.Core.RustInterop.emitRustExpr v217 v224 
    let _run_target_args'_v219 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v219 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v219 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v219 = false 
    #endif
#else
    let _run_target_args'_v219 = false 
    #endif
    let v226 : bool = _run_target_args'_v219 
    let v228 : string = $"true; _fix_closure_v218 " + v216 + "); " + v214 + " // rust.fix_closure'"
    let v229 : bool = Fable.Core.RustInterop.emitRustExpr () v228 
    let v230 : string = "__future_init"
    let v231 : _ = Fable.Core.RustInterop.emitRustExpr () v230 
    let v232 : string = "v231"
    let v233 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US12>>, Send<Dyn<std_future_Future<US12>>>>>> = Fable.Core.RustInterop.emitRustExpr () v232 
    let v234 : string = "v233.await"
    let v235 : US12 = Fable.Core.RustInterop.emitRustExpr () v234 
    let v244 : async_walkdir_Filtering =
        match v235 with
        | US12_2 -> (* Continue *)
            let v240 : string = "async_walkdir::Filtering::Continue"
            let v241 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v240 
            v241
        | US12_0 -> (* Ignore *)
            let v236 : string = "async_walkdir::Filtering::Ignore"
            let v237 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v236 
            v237
        | US12_1 -> (* IgnoreDir *)
            let v238 : string = "async_walkdir::Filtering::IgnoreDir"
            let v239 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v238 
            v239
    let v245 : string = v214 + v215 
    let x = v244 //
    let v246 : _ = x
    let v247 : unit = ()
    (* run_target_args'
    let v248 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v249 : string = $"true; let _fix_closure_v247 = $0"
    let v250 : bool = Fable.Core.RustInterop.emitRustExpr v246 v249 
    let _run_target_args'_v248 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v251 : string = $"true; let _fix_closure_v247 = $0"
    let v252 : bool = Fable.Core.RustInterop.emitRustExpr v246 v251 
    let _run_target_args'_v248 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v253 : string = $"true; let _fix_closure_v247 = $0"
    let v254 : bool = Fable.Core.RustInterop.emitRustExpr v246 v253 
    let _run_target_args'_v248 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v248 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v248 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v248 = false 
    #endif
#else
    let _run_target_args'_v248 = false 
    #endif
    let v255 : bool = _run_target_args'_v248 
    let v257 : string = $"true; _fix_closure_v247 " + v245 + "); " + v214 + " // rust.fix_closure'"
    let v258 : bool = Fable.Core.RustInterop.emitRustExpr () v257 
    let v259 : string = "__future_init"
    let v260 : _ = Fable.Core.RustInterop.emitRustExpr () v259 
    let v261 : string = "v260"
    let v262 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> = Fable.Core.RustInterop.emitRustExpr () v261 
    v262
and closure30 () (v0 : async_walkdir_Error) : std_string_String =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    let _run_target_args'_v5 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    let _run_target_args'_v5 = v9 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : string = "format!(\"{}\", $0)"
    let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v10 
    let _run_target_args'_v5 = v11 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v17 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v17 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v21 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v21 
    #endif
#else
    let v25 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v25 
    #endif
    let v28 : std_string_String = _run_target_args'_v5 
    v28
and method73 () : (async_walkdir_Error -> std_string_String) =
    closure30()
and closure31 () (v0 : async_walkdir_DirEntry) : US13 =
    US13_0(v0)
and method74 () : (async_walkdir_DirEntry -> US13) =
    closure31()
and closure32 () (v0 : std_string_String) : US13 =
    US13_1(v0)
and method75 () : (std_string_String -> US13) =
    closure32()
and method76 () : string =
    
    
    
    
    
    let v1 : string = "Critical"
    let v2 : (unit -> string) = v1.ToLower
    let v3 : string = v2 ()
    let v6 : char = v3.[int 0]
    let v7 : string = method13(v6)
    (* run_target_args'
    let v12 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : string = "inline_colorization::color_bright_red"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v13 
    (* run_target_args'
    let v19 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "&*$0"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v20 
    let _run_target_args'_v19 = v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v22 
    let _run_target_args'_v19 = v23 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : string = "&*$0"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v24 
    let _run_target_args'_v19 = v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v27 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v31 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v35 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v35 
    #endif
#else
    let v39 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v39 
    #endif
    let v42 : Ref<Str> = _run_target_args'_v19 
    let v48 : string = "inline_colorization::color_reset"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v14, v42, v49) v50 
    let v52 : string = "fable_library_rust::String_::fromString($0)"
    let v53 : string = Fable.Core.RustInterop.emitRustExpr v51 v52 
    let _run_target_args'_v12 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "inline_colorization::color_bright_red"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v54 
    (* run_target_args'
    let v60 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v61 : string = "&*$0"
    let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v61 
    let _run_target_args'_v60 = v62 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : string = "&*$0"
    let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v63 
    let _run_target_args'_v60 = v64 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = "&*$0"
    let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v65 
    let _run_target_args'_v60 = v66 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v68 
    #endif
#if FABLE_COMPILER_PYTHON
    let v72 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v72 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v76 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v76 
    #endif
#else
    let v80 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v80 
    #endif
    let v83 : Ref<Str> = _run_target_args'_v60 
    let v89 : string = "inline_colorization::color_reset"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v55, v83, v90) v91 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let _run_target_args'_v12 = v94 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v95 : string = "inline_colorization::color_bright_red"
    let v96 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v95 
    (* run_target_args'
    let v101 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v102 : string = "&*$0"
    let v103 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v102 
    let _run_target_args'_v101 = v103 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : string = "&*$0"
    let v105 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v104 
    let _run_target_args'_v101 = v105 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v106 : string = "&*$0"
    let v107 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v106 
    let _run_target_args'_v101 = v107 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v109 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v109 
    #endif
#if FABLE_COMPILER_PYTHON
    let v113 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v113 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v117 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v117 
    #endif
#else
    let v121 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v121 
    #endif
    let v124 : Ref<Str> = _run_target_args'_v101 
    let v130 : string = "inline_colorization::color_reset"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v96, v124, v131) v132 
    let v134 : string = "fable_library_rust::String_::fromString($0)"
    let v135 : string = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let _run_target_args'_v12 = v135 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v136 : string = "\u001b[91m"
    let v137 : string = method15()
    let v138 : string = v136 + v7 
    let v139 : string = v138 + v137 
    let _run_target_args'_v12 = v139 
    #endif
#if FABLE_COMPILER_PYTHON
    let v140 : string = "\u001b[91m"
    let v141 : string = method15()
    let v142 : string = v140 + v7 
    let v143 : string = v142 + v141 
    let _run_target_args'_v12 = v143 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v144 : string = "\u001b[91m"
    let v145 : string = method15()
    let v146 : string = v144 + v7 
    let v147 : string = v146 + v145 
    let _run_target_args'_v12 = v147 
    #endif
#else
    let v148 : string = "\u001b[91m"
    let v149 : string = method15()
    let v150 : string = v148 + v7 
    let v151 : string = v150 + v149 
    let _run_target_args'_v12 = v151 
    #endif
    let v152 : string = _run_target_args'_v12 
    v152
and method78 (v0 : std_string_String) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v2, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v14 : string = "error"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure8(v2, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure8(v2, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    (* run_target_args'
    let v37 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : string = "format!(\"{:#?}\", $0)"
    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v38 
    let v40 : string = "fable_library_rust::String_::fromString($0)"
    let v41 : string = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let _run_target_args'_v37 = v41 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v42 : string = "format!(\"{:#?}\", $0)"
    let v43 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v42 
    let v44 : string = "fable_library_rust::String_::fromString($0)"
    let v45 : string = Fable.Core.RustInterop.emitRustExpr v43 v44 
    let _run_target_args'_v37 = v45 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v46 : string = "format!(\"{:#?}\", $0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v46 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let _run_target_args'_v37 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v51 : string = $"%A{v0}"
    let _run_target_args'_v37 = v51 
    #endif
#if FABLE_COMPILER_PYTHON
    let v55 : string = $"%A{v0}"
    let _run_target_args'_v37 = v55 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v59 : string = $"%A{v0}"
    let _run_target_args'_v37 = v59 
    #endif
#else
    let v63 : string = $"%A{v0}"
    let _run_target_args'_v37 = v63 
    #endif
    let v66 : string = _run_target_args'_v37 
    let v73 : string = $"{v66}"
    let v76 : unit = ()
    let v77 : (unit -> unit) = closure8(v2, v73)
    let v78 : unit = (fun () -> v77 (); v76) ()
    let v82 : string = " }"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v2, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = v2.l0
    v91
and method77 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method78(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "documents.run / stream_filter_map"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method18(v13)
and closure33 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_4
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method76()
        let v46 : string = method77(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method19(v46)
and closure29 () (v0 : Result<async_walkdir_DirEntry, async_walkdir_Error>) : string option =
    let v1 : (async_walkdir_Error -> std_string_String) = method73()
    (* run_target_args'
    let v3 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "$0.map_err(|x| $1(x))"
    let v5 : Result<async_walkdir_DirEntry, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v4 
    let _run_target_args'_v3 = v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "$0.map_err(|x| $1(x))"
    let v7 : Result<async_walkdir_DirEntry, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v6 
    let _run_target_args'_v3 = v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "$0.map_err(|x| $1(x))"
    let v9 : Result<async_walkdir_DirEntry, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v8 
    let _run_target_args'_v3 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v10 : Result<async_walkdir_DirEntry, std_string_String> = match v0 with Ok x -> Ok x | Error x -> Error (v1 x)
    let _run_target_args'_v3 = v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : Result<async_walkdir_DirEntry, std_string_String> = match v0 with Ok x -> Ok x | Error x -> Error (v1 x)
    let _run_target_args'_v3 = v11 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v12 : Result<async_walkdir_DirEntry, std_string_String> = match v0 with Ok x -> Ok x | Error x -> Error (v1 x)
    let _run_target_args'_v3 = v12 
    #endif
#else
    let v13 : Result<async_walkdir_DirEntry, std_string_String> = match v0 with Ok x -> Ok x | Error x -> Error (v1 x)
    let _run_target_args'_v3 = v13 
    #endif
    let v14 : Result<async_walkdir_DirEntry, std_string_String> = _run_target_args'_v3 
    let v17 : (async_walkdir_DirEntry -> US13) = method74()
    let v18 : (std_string_String -> US13) = method75()
    let v19 : US13 = match v14 with Ok x -> v17 x | Error x -> v18 x
    let v144 : US5 =
        match v19 with
        | US13_1(v92) -> (* Error *)
            let v93 : unit = ()
            let v94 : (unit -> unit) = closure33(v92)
            let v95 : unit = (fun () -> v94 (); v93) ()
            US5_1
        | US13_0(v20) -> (* Ok *)
            let v21 : string = "async_walkdir::DirEntry::path(&$0)"
            let v22 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v20 v21 
            (* run_target_args'
            let v27 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v28 : string = "$0.display()"
            let v29 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v22 v28 
            let _run_target_args'_v27 = v29 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v30 : string = "$0.display()"
            let v31 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v22 v30 
            let _run_target_args'_v27 = v31 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v32 : string = "$0.display()"
            let v33 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v22 v32 
            let _run_target_args'_v27 = v33 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v35 : std_path_Display = v22 |> unbox<std_path_Display>
            let _run_target_args'_v27 = v35 
            #endif
#if FABLE_COMPILER_PYTHON
            let v39 : std_path_Display = v22 |> unbox<std_path_Display>
            let _run_target_args'_v27 = v39 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v43 : std_path_Display = v22 |> unbox<std_path_Display>
            let _run_target_args'_v27 = v43 
            #endif
#else
            let v47 : std_path_Display = v22 |> unbox<std_path_Display>
            let _run_target_args'_v27 = v47 
            #endif
            let v50 : std_path_Display = _run_target_args'_v27 
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "format!(\"{}\", $0)"
            let v62 : std_string_String = Fable.Core.RustInterop.emitRustExpr v50 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "format!(\"{}\", $0)"
            let v64 : std_string_String = Fable.Core.RustInterop.emitRustExpr v50 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "format!(\"{}\", $0)"
            let v66 : std_string_String = Fable.Core.RustInterop.emitRustExpr v50 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v68 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v60 = v68 
            #endif
#if FABLE_COMPILER_PYTHON
            let v72 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v60 = v72 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v76 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v60 = v76 
            #endif
#else
            let v80 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v60 = v80 
            #endif
            let v83 : std_string_String = _run_target_args'_v60 
            let v89 : string = "fable_library_rust::String_::fromString($0)"
            let v90 : string = Fable.Core.RustInterop.emitRustExpr v83 v89 
            US5_0(v90)
    match v144 with
    | US5_1 -> (* None *)
        let v150 : string option = None
        v150
    | US5_0(v145) -> (* Some *)
        let v147 : string option = Some v145 
        v147
and method72 () : (Result<async_walkdir_DirEntry, async_walkdir_Error> -> string option) =
    closure29()
and method80 (v0 : unativeint) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v2, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v14 : string = "files_len"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure8(v2, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure8(v2, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    (* run_target_args'
    let v37 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : string = "format!(\"{:#?}\", $0)"
    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v38 
    let v40 : string = "fable_library_rust::String_::fromString($0)"
    let v41 : string = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let _run_target_args'_v37 = v41 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v42 : string = "format!(\"{:#?}\", $0)"
    let v43 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v42 
    let v44 : string = "fable_library_rust::String_::fromString($0)"
    let v45 : string = Fable.Core.RustInterop.emitRustExpr v43 v44 
    let _run_target_args'_v37 = v45 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v46 : string = "format!(\"{:#?}\", $0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v46 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let _run_target_args'_v37 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v51 : string = $"%A{v0}"
    let _run_target_args'_v37 = v51 
    #endif
#if FABLE_COMPILER_PYTHON
    let v55 : string = $"%A{v0}"
    let _run_target_args'_v37 = v55 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v59 : string = $"%A{v0}"
    let _run_target_args'_v37 = v59 
    #endif
#else
    let v63 : string = $"%A{v0}"
    let _run_target_args'_v37 = v63 
    #endif
    let v66 : string = _run_target_args'_v37 
    let v73 : string = $"{v66}"
    let v76 : unit = ()
    let v77 : (unit -> unit) = closure8(v2, v73)
    let v78 : unit = (fun () -> v77 (); v76) ()
    let v82 : string = " }"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v2, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = v2.l0
    v91
and method79 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : unativeint) : string =
    let v9 : string = method80(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "documents.run"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method18(v13)
and closure34 (v0 : Vec<string>) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method66()
        let v46 : string = "$0.len()"
        let v47 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v46 
        let v48 : string = method79(v26, v27, v28, v29, v30, v31, v44, v45, v47)
        method19(v48)
and method81 () : string =
    let v0 : string = ""
    v0
and method82 (v0 : string) : string =
    let v1 : string = method61(v0)
    method38(v1)
and method84 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : string =
    v0
and method86 () : string =
    let v0 : string = ""
    v0
and closure38 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure37 () (v0 : char) : (UH0 -> UH0) =
    closure38(v0)
and method87 () : (char -> (UH0 -> UH0)) =
    closure37()
and method88 (v0 : UH0, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : struct (System.Text.StringBuilder * int32 * int32) =
    match v0 with
    | UH0_1(v4, v5) -> (* Cons *)
        let v6 : bool = '\n' = v4
        let struct (v9 : int32, v10 : int32) =
            if v6 then
                let v7 : int32 = v2 + 1
                struct (v7, 1)
            else
                let v8 : int32 = v3 + 1
                struct (v2, v8)
        let v27 : System.Text.StringBuilder =
            if v6 then
                let v12 : (unit -> System.Text.StringBuilder) = v1.Clear
                let v13 : System.Text.StringBuilder = v12 ()
                v1
            else
                let v18 : (char -> string) = _.ToString()
                let v19 : string = v18 v4
                let v23 : (string -> System.Text.StringBuilder) = v1.Append
                let v24 : System.Text.StringBuilder = v23 v19
                v1
        method88(v5, v27, v9, v10)
    | UH0_0 -> (* Nil *)
        struct (v1, v2, v3)
and closure39 (v0 : int32, v1 : int32) (v2 : string) : string =
    let v3 : bool = v1 >= v0
    if v3 then
        v2
    else
        let v4 : int32 = v1 + 1
        let v5 : (string -> string) = method89(v0, v4)
        let v6 : string = " "
        let v7 : string = v2 + v6 
        v5 v7
and method89 (v0 : int32, v1 : int32) : (string -> string) =
    closure39(v0, v1)
and closure36 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US15 =
    let v4 : bool = "" = v0
    if v4 then
        let v6 : string = $"parsing.p_char / unexpected end of input / c: '{'"'}' / s: %A{struct (v1, v2, v3)}"
        US15_1(v6)
    else
        let v10 : char = v0.[int 0]
        let v11 : bool = v10 = '"'
        if v11 then
            let v13 : (string -> int32) = String.length
            let v14 : int32 = v13 v0
            let v22 : int32 = 1 |> int32 
            let v35 : int32 = v14 |> int32 
            let v43 : int32 = v35 - 1
            let v45 : string = v0.[int v22..int v43]
            let v50 : (char -> string) = _.ToString()
            let v51 : string = v50 v10
            let v54 : int32 = v51.Length
            let v55 : (char []) = Array.zeroCreate<char> (v54)
            let v56 : Mut6 = {l0 = 0} : Mut6
            while method63(v54, v56) do
                let v58 : int32 = v56.l0
                let v59 : char = v51.[int v58]
                v55.[int v58] <- v59
                let v60 : int32 = v58 + 1
                v56.l0 <- v60
                ()
            let v62 : char list = v55 |> Array.toList
            let v66 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v67 : (char -> (UH0 -> UH0)) = method87()
            let v68 : (char list -> (UH0 -> UH0)) = v66 v67
            let v69 : (UH0 -> UH0) = v68 v62
            let v70 : UH0 = UH0_0
            let v71 : UH0 = v69 v70
            let struct (v96 : System.Text.StringBuilder, v97 : int32, v98 : int32) = method88(v71, v1, v2, v3)
            US15_0(v10, v45, v96, v97, v98)
        else
            let v101 : string = "\n"
            let v102 : int32 = v0.IndexOf v101 
            let v105 : int32 = v102 - 1
            let v106 : bool = -2 = v105
            let v114 : int32 =
                if v106 then
                    let v108 : (string -> int32) = String.length
                    let v109 : int32 = v108 v0
                    let v112 : int32 = v109 + 1
                    v112
                else
                    let v113 : int32 = v105 + 1
                    v113
            let v120 : int32 = 0 |> int32 
            let v133 : int32 = v114 |> int32 
            let v141 : int32 = v133 - 1
            let v143 : string = v0.[int v120..int v141]
            let v148 : string = $"parsing.p_char / expected: '{'"'}' / line: {v2} / col: {v3}
{v1}{v143}"
            let v151 : int32 = v3 - 1
            let v152 : int32 = 0
            let v153 : (string -> string) = method89(v151, v152)
            let v154 : string = ""
            let v155 : string = v153 v154
            let v156 : string = "^"
            let v157 : string = v155 + v156 
            let v159 : string = $"{v148}
{v157}
"
            US15_1(v159)
and closure40 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US15 =
    let v4 : bool = "" = v0
    if v4 then
        let v6 : string = $"parsing.p_char / unexpected end of input / c: '{'''}' / s: %A{struct (v1, v2, v3)}"
        US15_1(v6)
    else
        let v10 : char = v0.[int 0]
        let v11 : bool = v10 = '''
        if v11 then
            let v13 : (string -> int32) = String.length
            let v14 : int32 = v13 v0
            let v22 : int32 = 1 |> int32 
            let v35 : int32 = v14 |> int32 
            let v43 : int32 = v35 - 1
            let v45 : string = v0.[int v22..int v43]
            let v50 : (char -> string) = _.ToString()
            let v51 : string = v50 v10
            let v54 : int32 = v51.Length
            let v55 : (char []) = Array.zeroCreate<char> (v54)
            let v56 : Mut6 = {l0 = 0} : Mut6
            while method63(v54, v56) do
                let v58 : int32 = v56.l0
                let v59 : char = v51.[int v58]
                v55.[int v58] <- v59
                let v60 : int32 = v58 + 1
                v56.l0 <- v60
                ()
            let v62 : char list = v55 |> Array.toList
            let v66 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v67 : (char -> (UH0 -> UH0)) = method87()
            let v68 : (char list -> (UH0 -> UH0)) = v66 v67
            let v69 : (UH0 -> UH0) = v68 v62
            let v70 : UH0 = UH0_0
            let v71 : UH0 = v69 v70
            let struct (v96 : System.Text.StringBuilder, v97 : int32, v98 : int32) = method88(v71, v1, v2, v3)
            US15_0(v10, v45, v96, v97, v98)
        else
            let v101 : string = "\n"
            let v102 : int32 = v0.IndexOf v101 
            let v105 : int32 = v102 - 1
            let v106 : bool = -2 = v105
            let v114 : int32 =
                if v106 then
                    let v108 : (string -> int32) = String.length
                    let v109 : int32 = v108 v0
                    let v112 : int32 = v109 + 1
                    v112
                else
                    let v113 : int32 = v105 + 1
                    v113
            let v120 : int32 = 0 |> int32 
            let v133 : int32 = v114 |> int32 
            let v141 : int32 = v133 - 1
            let v143 : string = v0.[int v120..int v141]
            let v148 : string = $"parsing.p_char / expected: '{'''}' / line: {v2} / col: {v3}
{v1}{v143}"
            let v151 : int32 = v3 - 1
            let v152 : int32 = 0
            let v153 : (string -> string) = method89(v151, v152)
            let v154 : string = ""
            let v155 : string = v153 v154
            let v156 : string = "^"
            let v157 : string = v155 + v156 
            let v159 : string = $"{v148}
{v157}
"
            US15_1(v159)
and method90 (v0 : string, v1 : System.Text.StringBuilder, v2 : UH1) : US15 =
    match v2 with
    | UH1_1(v5, v6) -> (* Cons *)
        let v7 : US15 = v5 struct (v0, v1, 1, 1)
        match v7 with
        | US15_1(v13) -> (* Error *)
            method90(v0, v1, v6)
        | US15_0(v8, v9, v10, v11, v12) -> (* Ok *)
            v7
    | UH1_0 -> (* Nil *)
        let v3 : string = "parsing.choice / no parsers succeeded"
        US15_1(v3)
and method91 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 2L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v11 : US17 =
            if v3 then
                US17_0('"')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US17_0(''')
                else
                    let v8 : int64 = v5 - 1L
                    US17_1
        let v15 : char =
            match v11 with
            | US17_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US17_0(v12) -> (* Some *)
                v12
        let v16 : bool = v0 = v15
        if v16 then
            true
        else
            let v17 : int64 = v1 + 1L
            method91(v0, v17)
and method92 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
    let v5 : bool = "" = v1
    let v137 : US15 =
        if v5 then
            let v6 : char list = []
            let v8 : char list = ''' :: v6 
            let v12 : char list = '"' :: v8 
            let v16 : (char list -> (char [])) = List.toArray
            let v17 : (char []) = v16 v12
            let v21 : string = $"parsing.none_of / unexpected end of input / chars: %A{v17} / s: %A{struct (v2, v3, v4)}"
            US15_1(v21)
        else
            let v25 : char = v1.[int 0]
            let v26 : int64 = 0L
            let v27 : bool = method91(v25, v26)
            let v28 : bool = v27 = false
            if v28 then
                let v30 : (string -> int32) = String.length
                let v31 : int32 = v30 v1
                let v39 : int32 = 1 |> int32 
                let v52 : int32 = v31 |> int32 
                let v60 : int32 = v52 - 1
                let v62 : string = v1.[int v39..int v60]
                let v67 : (char -> string) = _.ToString()
                let v68 : string = v67 v25
                let v71 : int32 = v68.Length
                let v72 : (char []) = Array.zeroCreate<char> (v71)
                let v73 : Mut6 = {l0 = 0} : Mut6
                while method63(v71, v73) do
                    let v75 : int32 = v73.l0
                    let v76 : char = v68.[int v75]
                    v72.[int v75] <- v76
                    let v77 : int32 = v75 + 1
                    v73.l0 <- v77
                    ()
                let v79 : char list = v72 |> Array.toList
                let v83 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v84 : (char -> (UH0 -> UH0)) = method87()
                let v85 : (char list -> (UH0 -> UH0)) = v83 v84
                let v86 : (UH0 -> UH0) = v85 v79
                let v87 : UH0 = UH0_0
                let v88 : UH0 = v86 v87
                let struct (v113 : System.Text.StringBuilder, v114 : int32, v115 : int32) = method88(v88, v2, v3, v4)
                US15_0(v25, v62, v113, v114, v115)
            else
                let v117 : char list = []
                let v119 : char list = ''' :: v117 
                let v123 : char list = '"' :: v119 
                let v127 : (char list -> (char [])) = List.toArray
                let v128 : (char []) = v127 v123
                let v132 : string = $"parsing.none_of / unexpected char: '{v25}' / chars: %A{v128} / s: %A{struct (v2, v3, v4)}"
                US15_1(v132)
    let v149 : US15 =
        match v137 with
        | US15_1(v146) -> (* Error *)
            US15_1(v146)
        | US15_0(v138, v139, v140, v141, v142) -> (* Ok *)
            let v143 : bool = '\\' = v138
            let v144 : char =
                if v143 then
                    '/'
                else
                    v138
            US15_0(v144, v139, v140, v141, v142)
    match v149 with
    | US15_1(v166) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US15_0(v150, v151, v152, v153, v154) -> (* Ok *)
        let v156 : (char -> string) = _.ToString()
        let v157 : string = v156 v150
        let v160 : string = v0 + v157 
        method92(v160, v151, v152, v153, v154)
and method93 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH1) : US15 =
    match v4 with
    | UH1_1(v7, v8) -> (* Cons *)
        let v9 : US15 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US15_1(v15) -> (* Error *)
            method93(v0, v1, v2, v3, v8)
        | US15_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH1_0 -> (* Nil *)
        let v5 : string = "parsing.choice / no parsers succeeded"
        US15_1(v5)
and method94 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 3L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v15 : US17 =
            if v3 then
                US17_0('"')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US17_0(''')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US17_0(' ')
                    else
                        let v11 : int64 = v8 - 1L
                        US17_1
        let v19 : char =
            match v15 with
            | US17_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US17_0(v16) -> (* Some *)
                v16
        let v20 : bool = v0 = v19
        if v20 then
            true
        else
            let v21 : int64 = v1 + 1L
            method94(v0, v21)
and method95 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
    let v5 : bool = "" = v1
    let v145 : US15 =
        if v5 then
            let v6 : char list = []
            let v8 : char list = ' ' :: v6 
            let v12 : char list = ''' :: v8 
            let v16 : char list = '"' :: v12 
            let v20 : (char list -> (char [])) = List.toArray
            let v21 : (char []) = v20 v16
            let v25 : string = $"parsing.none_of / unexpected end of input / chars: %A{v21} / s: %A{struct (v2, v3, v4)}"
            US15_1(v25)
        else
            let v29 : char = v1.[int 0]
            let v30 : int64 = 0L
            let v31 : bool = method94(v29, v30)
            let v32 : bool = v31 = false
            if v32 then
                let v34 : (string -> int32) = String.length
                let v35 : int32 = v34 v1
                let v43 : int32 = 1 |> int32 
                let v56 : int32 = v35 |> int32 
                let v64 : int32 = v56 - 1
                let v66 : string = v1.[int v43..int v64]
                let v71 : (char -> string) = _.ToString()
                let v72 : string = v71 v29
                let v75 : int32 = v72.Length
                let v76 : (char []) = Array.zeroCreate<char> (v75)
                let v77 : Mut6 = {l0 = 0} : Mut6
                while method63(v75, v77) do
                    let v79 : int32 = v77.l0
                    let v80 : char = v72.[int v79]
                    v76.[int v79] <- v80
                    let v81 : int32 = v79 + 1
                    v77.l0 <- v81
                    ()
                let v83 : char list = v76 |> Array.toList
                let v87 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v88 : (char -> (UH0 -> UH0)) = method87()
                let v89 : (char list -> (UH0 -> UH0)) = v87 v88
                let v90 : (UH0 -> UH0) = v89 v83
                let v91 : UH0 = UH0_0
                let v92 : UH0 = v90 v91
                let struct (v117 : System.Text.StringBuilder, v118 : int32, v119 : int32) = method88(v92, v2, v3, v4)
                US15_0(v29, v66, v117, v118, v119)
            else
                let v121 : char list = []
                let v123 : char list = ' ' :: v121 
                let v127 : char list = ''' :: v123 
                let v131 : char list = '"' :: v127 
                let v135 : (char list -> (char [])) = List.toArray
                let v136 : (char []) = v135 v131
                let v140 : string = $"parsing.none_of / unexpected char: '{v29}' / chars: %A{v136} / s: %A{struct (v2, v3, v4)}"
                US15_1(v140)
    let v157 : US15 =
        match v145 with
        | US15_1(v154) -> (* Error *)
            US15_1(v154)
        | US15_0(v146, v147, v148, v149, v150) -> (* Ok *)
            let v151 : bool = '\\' = v146
            let v152 : char =
                if v151 then
                    '/'
                else
                    v146
            US15_0(v152, v147, v148, v149, v150)
    match v157 with
    | US15_1(v174) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US15_0(v158, v159, v160, v161, v162) -> (* Ok *)
        let v164 : (char -> string) = _.ToString()
        let v165 : string = v164 v158
        let v168 : string = v0 + v165 
        method95(v168, v159, v160, v161, v162)
and method96 (v0 : string, v1 : int32) : int32 =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 >= v2
    if v3 then
        v1
    else
        let v4 : char = v0.[int v1]
        let v5 : bool = ' ' = v4
        if v5 then
            let v6 : int32 = v1 + 1
            method96(v0, v6)
        else
            v1
and method97 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
    let v5 : bool = "" = v1
    let v100 : US15 =
        if v5 then
            let v7 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v2, v3, v4)}"
            US15_1(v7)
        else
            let v11 : char = v1.[int 0]
            let v13 : (string -> int32) = String.length
            let v14 : int32 = v13 v1
            let v22 : int32 = 1 |> int32 
            let v35 : int32 = v14 |> int32 
            let v43 : int32 = v35 - 1
            let v45 : string = v1.[int v22..int v43]
            let v50 : (char -> string) = _.ToString()
            let v51 : string = v50 v11
            let v54 : int32 = v51.Length
            let v55 : (char []) = Array.zeroCreate<char> (v54)
            let v56 : Mut6 = {l0 = 0} : Mut6
            while method63(v54, v56) do
                let v58 : int32 = v56.l0
                let v59 : char = v51.[int v58]
                v55.[int v58] <- v59
                let v60 : int32 = v58 + 1
                v56.l0 <- v60
                ()
            let v62 : char list = v55 |> Array.toList
            let v66 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v67 : (char -> (UH0 -> UH0)) = method87()
            let v68 : (char list -> (UH0 -> UH0)) = v66 v67
            let v69 : (UH0 -> UH0) = v68 v62
            let v70 : UH0 = UH0_0
            let v71 : UH0 = v69 v70
            let struct (v96 : System.Text.StringBuilder, v97 : int32, v98 : int32) = method88(v71, v2, v3, v4)
            US15_0(v11, v45, v96, v97, v98)
    match v100 with
    | US15_1(v117) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US15_0(v101, v102, v103, v104, v105) -> (* Ok *)
        let v107 : (char -> string) = _.ToString()
        let v108 : string = v107 v101
        let v111 : string = v0 + v108 
        method97(v111, v102, v103, v104, v105)
and method85 (v0 : string) : US14 =
    let mutable _v0 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v2 : (string -> string option) = Option.ofObj
    let v3 : string option = v2 v0
    v3 
    #else
    Some v0 
    #endif
    |> fun x -> _v0 <- Some x
    let v4 : string option = match _v0 with Some x -> x | None -> failwith "optionm'.of_obj / _v0=None"
    let v8 : string = ""
    let v9 : string = v4 |> Option.defaultValue v8 
    let v12 : string = method86()
    let v14 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v15 : System.Text.StringBuilder = v14 v12
    let v18 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US15) = closure36()
    let v19 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US15) = closure40()
    let v20 : UH1 = UH1_0
    let v21 : UH1 = UH1_1(v19, v20)
    let v22 : UH1 = UH1_1(v18, v21)
    let v23 : US15 = method90(v9, v15, v22)
    let v235 : US16 =
        match v23 with
        | US15_1(v232) -> (* Error *)
            US16_1(v232)
        | US15_0(v24, v25, v26, v27, v28) -> (* Ok *)
            let v29 : bool = "" = v25
            let v161 : US15 =
                if v29 then
                    let v30 : char list = []
                    let v32 : char list = ''' :: v30 
                    let v36 : char list = '"' :: v32 
                    let v40 : (char list -> (char [])) = List.toArray
                    let v41 : (char []) = v40 v36
                    let v45 : string = $"parsing.none_of / unexpected end of input / chars: %A{v41} / s: %A{struct (v26, v27, v28)}"
                    US15_1(v45)
                else
                    let v49 : char = v25.[int 0]
                    let v50 : int64 = 0L
                    let v51 : bool = method91(v49, v50)
                    let v52 : bool = v51 = false
                    if v52 then
                        let v54 : (string -> int32) = String.length
                        let v55 : int32 = v54 v25
                        let v63 : int32 = 1 |> int32 
                        let v76 : int32 = v55 |> int32 
                        let v84 : int32 = v76 - 1
                        let v86 : string = v25.[int v63..int v84]
                        let v91 : (char -> string) = _.ToString()
                        let v92 : string = v91 v49
                        let v95 : int32 = v92.Length
                        let v96 : (char []) = Array.zeroCreate<char> (v95)
                        let v97 : Mut6 = {l0 = 0} : Mut6
                        while method63(v95, v97) do
                            let v99 : int32 = v97.l0
                            let v100 : char = v92.[int v99]
                            v96.[int v99] <- v100
                            let v101 : int32 = v99 + 1
                            v97.l0 <- v101
                            ()
                        let v103 : char list = v96 |> Array.toList
                        let v107 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v108 : (char -> (UH0 -> UH0)) = method87()
                        let v109 : (char list -> (UH0 -> UH0)) = v107 v108
                        let v110 : (UH0 -> UH0) = v109 v103
                        let v111 : UH0 = UH0_0
                        let v112 : UH0 = v110 v111
                        let struct (v137 : System.Text.StringBuilder, v138 : int32, v139 : int32) = method88(v112, v26, v27, v28)
                        US15_0(v49, v86, v137, v138, v139)
                    else
                        let v141 : char list = []
                        let v143 : char list = ''' :: v141 
                        let v147 : char list = '"' :: v143 
                        let v151 : (char list -> (char [])) = List.toArray
                        let v152 : (char []) = v151 v147
                        let v156 : string = $"parsing.none_of / unexpected char: '{v49}' / chars: %A{v152} / s: %A{struct (v26, v27, v28)}"
                        US15_1(v156)
            let v173 : US15 =
                match v161 with
                | US15_1(v170) -> (* Error *)
                    US15_1(v170)
                | US15_0(v162, v163, v164, v165, v166) -> (* Ok *)
                    let v167 : bool = '\\' = v162
                    let v168 : char =
                        if v167 then
                            '/'
                        else
                            v162
                    US15_0(v168, v163, v164, v165, v166)
            let v193 : US16 =
                match v173 with
                | US15_1(v190) -> (* Error *)
                    US16_1(v190)
                | US15_0(v174, v175, v176, v177, v178) -> (* Ok *)
                    let v180 : (char -> string) = _.ToString()
                    let v181 : string = v180 v174
                    let struct (v184 : string, v185 : string, v186 : System.Text.StringBuilder, v187 : int32, v188 : int32) = method92(v181, v175, v176, v177, v178)
                    US16_0(v184, v185, v186, v187, v188)
            let v203 : US16 =
                match v193 with
                | US16_1(v200) -> (* Error *)
                    US16_0(v8, v25, v26, v27, v28)
                | US16_0(v194, v195, v196, v197, v198) -> (* Ok *)
                    US16_0(v194, v195, v196, v197, v198)
            match v203 with
            | US16_1(v227) -> (* Error *)
                let v228 : string = "parsing.between / expected content"
                US16_1(v228)
            | US16_0(v204, v205, v206, v207, v208) -> (* Ok *)
                let v209 : UH1 = UH1_0
                let v210 : UH1 = UH1_1(v19, v209)
                let v211 : UH1 = UH1_1(v18, v210)
                let v212 : US15 = method93(v205, v206, v207, v208, v211)
                match v212 with
                | US15_1(v219) -> (* Error *)
                    let v221 : string = $"parsing.between / expected closing delimiter / e: %A{v219} / input: %A{struct (v9, v15, 1, 1)} / rest1: %A{struct (v25, v26, v27, v28)} / rest2: %A{struct (v205, v206, v207, v208)}"
                    US16_1(v221)
                | US15_0(v213, v214, v215, v216, v217) -> (* Ok *)
                    US16_0(v204, v214, v215, v216, v217)
    let v493 : US16 =
        match v235 with
        | US16_1(v241) -> (* Error *)
            let v242 : bool = "" = v9
            let v384 : US15 =
                if v242 then
                    let v243 : char list = []
                    let v245 : char list = ' ' :: v243 
                    let v249 : char list = ''' :: v245 
                    let v253 : char list = '"' :: v249 
                    let v257 : (char list -> (char [])) = List.toArray
                    let v258 : (char []) = v257 v253
                    let v262 : string = $"parsing.none_of / unexpected end of input / chars: %A{v258} / s: %A{struct (v15, 1, 1)}"
                    US15_1(v262)
                else
                    let v266 : char = v9.[int 0]
                    let v267 : int64 = 0L
                    let v268 : bool = method94(v266, v267)
                    let v269 : bool = v268 = false
                    if v269 then
                        let v271 : (string -> int32) = String.length
                        let v272 : int32 = v271 v9
                        let v280 : int32 = 1 |> int32 
                        let v293 : int32 = v272 |> int32 
                        let v301 : int32 = v293 - 1
                        let v303 : string = v9.[int v280..int v301]
                        let v308 : (char -> string) = _.ToString()
                        let v309 : string = v308 v266
                        let v312 : int32 = v309.Length
                        let v313 : (char []) = Array.zeroCreate<char> (v312)
                        let v314 : Mut6 = {l0 = 0} : Mut6
                        while method63(v312, v314) do
                            let v316 : int32 = v314.l0
                            let v317 : char = v309.[int v316]
                            v313.[int v316] <- v317
                            let v318 : int32 = v316 + 1
                            v314.l0 <- v318
                            ()
                        let v320 : char list = v313 |> Array.toList
                        let v324 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v325 : (char -> (UH0 -> UH0)) = method87()
                        let v326 : (char list -> (UH0 -> UH0)) = v324 v325
                        let v327 : (UH0 -> UH0) = v326 v320
                        let v328 : UH0 = UH0_0
                        let v329 : UH0 = v327 v328
                        let v354 : int32 = 1
                        let v355 : int32 = 1
                        let struct (v356 : System.Text.StringBuilder, v357 : int32, v358 : int32) = method88(v329, v15, v354, v355)
                        US15_0(v266, v303, v356, v357, v358)
                    else
                        let v360 : char list = []
                        let v362 : char list = ' ' :: v360 
                        let v366 : char list = ''' :: v362 
                        let v370 : char list = '"' :: v366 
                        let v374 : (char list -> (char [])) = List.toArray
                        let v375 : (char []) = v374 v370
                        let v379 : string = $"parsing.none_of / unexpected char: '{v266}' / chars: %A{v375} / s: %A{struct (v15, 1, 1)}"
                        US15_1(v379)
            let v396 : US15 =
                match v384 with
                | US15_1(v393) -> (* Error *)
                    US15_1(v393)
                | US15_0(v385, v386, v387, v388, v389) -> (* Ok *)
                    let v390 : bool = '\\' = v385
                    let v391 : char =
                        if v390 then
                            '/'
                        else
                            v385
                    US15_0(v391, v386, v387, v388, v389)
            let v416 : US16 =
                match v396 with
                | US15_1(v413) -> (* Error *)
                    US16_1(v413)
                | US15_0(v397, v398, v399, v400, v401) -> (* Ok *)
                    let v403 : (char -> string) = _.ToString()
                    let v404 : string = v403 v397
                    let struct (v407 : string, v408 : string, v409 : System.Text.StringBuilder, v410 : int32, v411 : int32) = method95(v404, v398, v399, v400, v401)
                    US16_0(v407, v408, v409, v410, v411)
            match v416 with
            | US16_1(v422) -> (* Error *)
                let v423 : int32 = v9.Length
                let v424 : bool = v423 = 0
                let v431 : US18 =
                    if v424 then
                        US18_0(v9, v15, 1, 1)
                    else
                        let v427 : string = $"parsing.eof / expected end of input / input: %A{v9}"
                        US18_1(v427)
                let v440 : US16 =
                    match v431 with
                    | US18_1(v437) -> (* Error *)
                        US16_1(v437)
                    | US18_0(v432, v433, v434, v435) -> (* Ok *)
                        US16_0(v8, v432, v433, v434, v435)
                match v440 with
                | US16_1(v486) -> (* Error *)
                    US16_1(v486)
                | US16_0(v441, v442, v443, v444, v445) -> (* Ok *)
                    let v446 : int32 = 0
                    let v447 : int32 = method96(v442, v446)
                    let v449 : (string -> int32) = String.length
                    let v450 : int32 = v449 v442
                    let v458 : int32 = v447 |> int32 
                    let v471 : int32 = v450 |> int32 
                    let v479 : int32 = v471 - 1
                    let v481 : string = v442.[int v458..int v479]
                    US16_0(v441, v481, v443, v444, v445)
            | US16_0(v417, v418, v419, v420, v421) -> (* Ok *)
                v416
        | US16_0(v236, v237, v238, v239, v240) -> (* Ok *)
            v235
    let v821 : US19 =
        match v493 with
        | US16_1(v818) -> (* Error *)
            US19_1(v818)
        | US16_0(v494, v495, v496, v497, v498) -> (* Ok *)
            let v499 : bool = "" = v495
            let v658 : US15 =
                if v499 then
                    let v501 : string = $"parsing.p_char / unexpected end of input / c: '{' '}' / s: %A{struct (v496, v497, v498)}"
                    US15_1(v501)
                else
                    let v505 : char = v495.[int 0]
                    let v506 : bool = v505 = ' '
                    if v506 then
                        let v508 : (string -> int32) = String.length
                        let v509 : int32 = v508 v495
                        let v517 : int32 = 1 |> int32 
                        let v530 : int32 = v509 |> int32 
                        let v538 : int32 = v530 - 1
                        let v540 : string = v495.[int v517..int v538]
                        let v545 : (char -> string) = _.ToString()
                        let v546 : string = v545 v505
                        let v549 : int32 = v546.Length
                        let v550 : (char []) = Array.zeroCreate<char> (v549)
                        let v551 : Mut6 = {l0 = 0} : Mut6
                        while method63(v549, v551) do
                            let v553 : int32 = v551.l0
                            let v554 : char = v546.[int v553]
                            v550.[int v553] <- v554
                            let v555 : int32 = v553 + 1
                            v551.l0 <- v555
                            ()
                        let v557 : char list = v550 |> Array.toList
                        let v561 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v562 : (char -> (UH0 -> UH0)) = method87()
                        let v563 : (char list -> (UH0 -> UH0)) = v561 v562
                        let v564 : (UH0 -> UH0) = v563 v557
                        let v565 : UH0 = UH0_0
                        let v566 : UH0 = v564 v565
                        let struct (v591 : System.Text.StringBuilder, v592 : int32, v593 : int32) = method88(v566, v496, v497, v498)
                        US15_0(v505, v540, v591, v592, v593)
                    else
                        let v596 : string = "\n"
                        let v597 : int32 = v495.IndexOf v596 
                        let v600 : int32 = v597 - 1
                        let v601 : bool = -2 = v600
                        let v609 : int32 =
                            if v601 then
                                let v603 : (string -> int32) = String.length
                                let v604 : int32 = v603 v495
                                let v607 : int32 = v604 + 1
                                v607
                            else
                                let v608 : int32 = v600 + 1
                                v608
                        let v615 : int32 = 0 |> int32 
                        let v628 : int32 = v609 |> int32 
                        let v636 : int32 = v628 - 1
                        let v638 : string = v495.[int v615..int v636]
                        let v643 : string = $"parsing.p_char / expected: '{' '}' / line: {v497} / col: {v498}
{v496}{v638}"
                        let v646 : int32 = v498 - 1
                        let v647 : int32 = 0
                        let v648 : (string -> string) = method89(v646, v647)
                        let v649 : string = v648 v8
                        let v650 : string = "^"
                        let v651 : string = v649 + v650 
                        let v653 : string = $"{v643}
{v651}
"
                        US15_1(v653)
            let v670 : US20 =
                match v658 with
                | US15_1(v666) -> (* Error *)
                    let v667 : US17 = US17_1
                    US20_0(v667, v495, v496, v497, v498)
                | US15_0(v659, v660, v661, v662, v663) -> (* Ok *)
                    let v664 : US17 = US17_0(v659)
                    US20_0(v664, v660, v661, v662, v663)
            let v795 : US16 =
                match v670 with
                | US20_1(v792) -> (* Error *)
                    US16_1(v792)
                | US20_0(v671, v672, v673, v674, v675) -> (* Ok *)
                    let v676 : bool = "" = v672
                    let v771 : US15 =
                        if v676 then
                            let v678 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v673, v674, v675)}"
                            US15_1(v678)
                        else
                            let v682 : char = v672.[int 0]
                            let v684 : (string -> int32) = String.length
                            let v685 : int32 = v684 v672
                            let v693 : int32 = 1 |> int32 
                            let v706 : int32 = v685 |> int32 
                            let v714 : int32 = v706 - 1
                            let v716 : string = v672.[int v693..int v714]
                            let v721 : (char -> string) = _.ToString()
                            let v722 : string = v721 v682
                            let v725 : int32 = v722.Length
                            let v726 : (char []) = Array.zeroCreate<char> (v725)
                            let v727 : Mut6 = {l0 = 0} : Mut6
                            while method63(v725, v727) do
                                let v729 : int32 = v727.l0
                                let v730 : char = v722.[int v729]
                                v726.[int v729] <- v730
                                let v731 : int32 = v729 + 1
                                v727.l0 <- v731
                                ()
                            let v733 : char list = v726 |> Array.toList
                            let v737 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                            let v738 : (char -> (UH0 -> UH0)) = method87()
                            let v739 : (char list -> (UH0 -> UH0)) = v737 v738
                            let v740 : (UH0 -> UH0) = v739 v733
                            let v741 : UH0 = UH0_0
                            let v742 : UH0 = v740 v741
                            let struct (v767 : System.Text.StringBuilder, v768 : int32, v769 : int32) = method88(v742, v673, v674, v675)
                            US15_0(v682, v716, v767, v768, v769)
                    match v771 with
                    | US15_1(v788) -> (* Error *)
                        US16_1(v788)
                    | US15_0(v772, v773, v774, v775, v776) -> (* Ok *)
                        let v778 : (char -> string) = _.ToString()
                        let v779 : string = v778 v772
                        let struct (v782 : string, v783 : string, v784 : System.Text.StringBuilder, v785 : int32, v786 : int32) = method97(v779, v773, v774, v775, v776)
                        US16_0(v782, v783, v784, v785, v786)
            let v807 : US21 =
                match v795 with
                | US16_1(v803) -> (* Error *)
                    let v804 : US5 = US5_1
                    US21_0(v804, v495, v496, v497, v498)
                | US16_0(v796, v797, v798, v799, v800) -> (* Ok *)
                    let v801 : US5 = US5_0(v796)
                    US21_0(v801, v797, v798, v799, v800)
            match v807 with
            | US21_1(v814) -> (* Error *)
                US19_1(v814)
            | US21_0(v808, v809, v810, v811, v812) -> (* Ok *)
                US19_0(v494, v808, v809, v810, v811, v812)
    match v821 with
    | US19_1(v829) -> (* Error *)
        US14_1(v829)
    | US19_0(v822, v823, v824, v825, v826, v827) -> (* Ok *)
        US14_0(v822, v823)
and method100 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 4L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v19 : US17 =
            if v3 then
                US17_0('\\')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US17_0('`')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US17_0('"')
                    else
                        let v11 : int64 = v8 - 1L
                        let v12 : bool = v11 = 0L
                        if v12 then
                            US17_0(' ')
                        else
                            let v14 : int64 = v11 - 1L
                            US17_1
        let v23 : char =
            match v19 with
            | US17_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US17_0(v20) -> (* Some *)
                v20
        let v24 : bool = v0 = v23
        if v24 then
            true
        else
            let v25 : int64 = v1 + 1L
            method100(v0, v25)
and method101 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
    let v5 : bool = "" = v1
    let v153 : US15 =
        if v5 then
            let v6 : char list = []
            let v8 : char list = ' ' :: v6 
            let v12 : char list = '"' :: v8 
            let v16 : char list = '`' :: v12 
            let v20 : char list = '\\' :: v16 
            let v24 : (char list -> (char [])) = List.toArray
            let v25 : (char []) = v24 v20
            let v29 : string = $"parsing.none_of / unexpected end of input / chars: %A{v25} / s: %A{struct (v2, v3, v4)}"
            US15_1(v29)
        else
            let v33 : char = v1.[int 0]
            let v34 : int64 = 0L
            let v35 : bool = method100(v33, v34)
            let v36 : bool = v35 = false
            if v36 then
                let v38 : (string -> int32) = String.length
                let v39 : int32 = v38 v1
                let v47 : int32 = 1 |> int32 
                let v60 : int32 = v39 |> int32 
                let v68 : int32 = v60 - 1
                let v70 : string = v1.[int v47..int v68]
                let v75 : (char -> string) = _.ToString()
                let v76 : string = v75 v33
                let v79 : int32 = v76.Length
                let v80 : (char []) = Array.zeroCreate<char> (v79)
                let v81 : Mut6 = {l0 = 0} : Mut6
                while method63(v79, v81) do
                    let v83 : int32 = v81.l0
                    let v84 : char = v76.[int v83]
                    v80.[int v83] <- v84
                    let v85 : int32 = v83 + 1
                    v81.l0 <- v85
                    ()
                let v87 : char list = v80 |> Array.toList
                let v91 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v92 : (char -> (UH0 -> UH0)) = method87()
                let v93 : (char list -> (UH0 -> UH0)) = v91 v92
                let v94 : (UH0 -> UH0) = v93 v87
                let v95 : UH0 = UH0_0
                let v96 : UH0 = v94 v95
                let struct (v121 : System.Text.StringBuilder, v122 : int32, v123 : int32) = method88(v96, v2, v3, v4)
                US15_0(v33, v70, v121, v122, v123)
            else
                let v125 : char list = []
                let v127 : char list = ' ' :: v125 
                let v131 : char list = '"' :: v127 
                let v135 : char list = '`' :: v131 
                let v139 : char list = '\\' :: v135 
                let v143 : (char list -> (char [])) = List.toArray
                let v144 : (char []) = v143 v139
                let v148 : string = $"parsing.none_of / unexpected char: '{v33}' / chars: %A{v144} / s: %A{struct (v2, v3, v4)}"
                US15_1(v148)
    match v153 with
    | US15_1(v170) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US15_0(v154, v155, v156, v157, v158) -> (* Ok *)
        let v160 : (char -> string) = _.ToString()
        let v161 : string = v160 v154
        let v164 : string = v0 + v161 
        method101(v164, v155, v156, v157, v158)
and method103 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 3L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v15 : US17 =
            if v3 then
                US17_0('\\')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US17_0('`')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US17_0('"')
                    else
                        let v11 : int64 = v8 - 1L
                        US17_1
        let v19 : char =
            match v15 with
            | US17_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US17_0(v16) -> (* Some *)
                v16
        let v20 : bool = v0 = v19
        if v20 then
            true
        else
            let v21 : int64 = v1 + 1L
            method103(v0, v21)
and closure41 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US16 =
    let v4 : bool = "" = v0
    let v164 : US15 =
        if v4 then
            let v6 : string = $"parsing.p_char / unexpected end of input / c: '{'\\'}' / s: %A{struct (v1, v2, v3)}"
            US15_1(v6)
        else
            let v10 : char = v0.[int 0]
            let v11 : bool = v10 = '\\'
            if v11 then
                let v13 : (string -> int32) = String.length
                let v14 : int32 = v13 v0
                let v22 : int32 = 1 |> int32 
                let v35 : int32 = v14 |> int32 
                let v43 : int32 = v35 - 1
                let v45 : string = v0.[int v22..int v43]
                let v50 : (char -> string) = _.ToString()
                let v51 : string = v50 v10
                let v54 : int32 = v51.Length
                let v55 : (char []) = Array.zeroCreate<char> (v54)
                let v56 : Mut6 = {l0 = 0} : Mut6
                while method63(v54, v56) do
                    let v58 : int32 = v56.l0
                    let v59 : char = v51.[int v58]
                    v55.[int v58] <- v59
                    let v60 : int32 = v58 + 1
                    v56.l0 <- v60
                    ()
                let v62 : char list = v55 |> Array.toList
                let v66 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v67 : (char -> (UH0 -> UH0)) = method87()
                let v68 : (char list -> (UH0 -> UH0)) = v66 v67
                let v69 : (UH0 -> UH0) = v68 v62
                let v70 : UH0 = UH0_0
                let v71 : UH0 = v69 v70
                let struct (v96 : System.Text.StringBuilder, v97 : int32, v98 : int32) = method88(v71, v1, v2, v3)
                US15_0(v10, v45, v96, v97, v98)
            else
                let v101 : string = "\n"
                let v102 : int32 = v0.IndexOf v101 
                let v105 : int32 = v102 - 1
                let v106 : bool = -2 = v105
                let v114 : int32 =
                    if v106 then
                        let v108 : (string -> int32) = String.length
                        let v109 : int32 = v108 v0
                        let v112 : int32 = v109 + 1
                        v112
                    else
                        let v113 : int32 = v105 + 1
                        v113
                let v120 : int32 = 0 |> int32 
                let v133 : int32 = v114 |> int32 
                let v141 : int32 = v133 - 1
                let v143 : string = v0.[int v120..int v141]
                let v148 : string = $"parsing.p_char / expected: '{'\\'}' / line: {v2} / col: {v3}
{v1}{v143}"
                let v151 : int32 = v3 - 1
                let v152 : int32 = 0
                let v153 : (string -> string) = method89(v151, v152)
                let v154 : string = ""
                let v155 : string = v153 v154
                let v156 : string = "^"
                let v157 : string = v155 + v156 
                let v159 : string = $"{v148}
{v157}
"
                US15_1(v159)
    let v269 : US15 =
        match v164 with
        | US15_1(v266) -> (* Error *)
            US15_1(v266)
        | US15_0(v165, v166, v167, v168, v169) -> (* Ok *)
            let v170 : bool = "" = v166
            if v170 then
                let v172 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v167, v168, v169)}"
                US15_1(v172)
            else
                let v176 : char = v166.[int 0]
                let v178 : (string -> int32) = String.length
                let v179 : int32 = v178 v166
                let v187 : int32 = 1 |> int32 
                let v200 : int32 = v179 |> int32 
                let v208 : int32 = v200 - 1
                let v210 : string = v166.[int v187..int v208]
                let v215 : (char -> string) = _.ToString()
                let v216 : string = v215 v176
                let v219 : int32 = v216.Length
                let v220 : (char []) = Array.zeroCreate<char> (v219)
                let v221 : Mut6 = {l0 = 0} : Mut6
                while method63(v219, v221) do
                    let v223 : int32 = v221.l0
                    let v224 : char = v216.[int v223]
                    v220.[int v223] <- v224
                    let v225 : int32 = v223 + 1
                    v221.l0 <- v225
                    ()
                let v227 : char list = v220 |> Array.toList
                let v231 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v232 : (char -> (UH0 -> UH0)) = method87()
                let v233 : (char list -> (UH0 -> UH0)) = v231 v232
                let v234 : (UH0 -> UH0) = v233 v227
                let v235 : UH0 = UH0_0
                let v236 : UH0 = v234 v235
                let struct (v261 : System.Text.StringBuilder, v262 : int32, v263 : int32) = method88(v236, v167, v168, v169)
                US15_0(v176, v210, v261, v262, v263)
    match v269 with
    | US15_1(v287) -> (* Error *)
        US16_1(v287)
    | US15_0(v270, v271, v272, v273, v274) -> (* Ok *)
        let v276 : (char -> string) = _.ToString()
        let v277 : string = v276 '\\'
        let v281 : (char -> string) = _.ToString()
        let v282 : string = v281 v270
        let v285 : string = v277 + v282 
        US16_0(v285, v271, v272, v273, v274)
and closure42 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US16 =
    let v4 : bool = "" = v0
    let v164 : US15 =
        if v4 then
            let v6 : string = $"parsing.p_char / unexpected end of input / c: '{'`'}' / s: %A{struct (v1, v2, v3)}"
            US15_1(v6)
        else
            let v10 : char = v0.[int 0]
            let v11 : bool = v10 = '`'
            if v11 then
                let v13 : (string -> int32) = String.length
                let v14 : int32 = v13 v0
                let v22 : int32 = 1 |> int32 
                let v35 : int32 = v14 |> int32 
                let v43 : int32 = v35 - 1
                let v45 : string = v0.[int v22..int v43]
                let v50 : (char -> string) = _.ToString()
                let v51 : string = v50 v10
                let v54 : int32 = v51.Length
                let v55 : (char []) = Array.zeroCreate<char> (v54)
                let v56 : Mut6 = {l0 = 0} : Mut6
                while method63(v54, v56) do
                    let v58 : int32 = v56.l0
                    let v59 : char = v51.[int v58]
                    v55.[int v58] <- v59
                    let v60 : int32 = v58 + 1
                    v56.l0 <- v60
                    ()
                let v62 : char list = v55 |> Array.toList
                let v66 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v67 : (char -> (UH0 -> UH0)) = method87()
                let v68 : (char list -> (UH0 -> UH0)) = v66 v67
                let v69 : (UH0 -> UH0) = v68 v62
                let v70 : UH0 = UH0_0
                let v71 : UH0 = v69 v70
                let struct (v96 : System.Text.StringBuilder, v97 : int32, v98 : int32) = method88(v71, v1, v2, v3)
                US15_0(v10, v45, v96, v97, v98)
            else
                let v101 : string = "\n"
                let v102 : int32 = v0.IndexOf v101 
                let v105 : int32 = v102 - 1
                let v106 : bool = -2 = v105
                let v114 : int32 =
                    if v106 then
                        let v108 : (string -> int32) = String.length
                        let v109 : int32 = v108 v0
                        let v112 : int32 = v109 + 1
                        v112
                    else
                        let v113 : int32 = v105 + 1
                        v113
                let v120 : int32 = 0 |> int32 
                let v133 : int32 = v114 |> int32 
                let v141 : int32 = v133 - 1
                let v143 : string = v0.[int v120..int v141]
                let v148 : string = $"parsing.p_char / expected: '{'`'}' / line: {v2} / col: {v3}
{v1}{v143}"
                let v151 : int32 = v3 - 1
                let v152 : int32 = 0
                let v153 : (string -> string) = method89(v151, v152)
                let v154 : string = ""
                let v155 : string = v153 v154
                let v156 : string = "^"
                let v157 : string = v155 + v156 
                let v159 : string = $"{v148}
{v157}
"
                US15_1(v159)
    let v269 : US15 =
        match v164 with
        | US15_1(v266) -> (* Error *)
            US15_1(v266)
        | US15_0(v165, v166, v167, v168, v169) -> (* Ok *)
            let v170 : bool = "" = v166
            if v170 then
                let v172 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v167, v168, v169)}"
                US15_1(v172)
            else
                let v176 : char = v166.[int 0]
                let v178 : (string -> int32) = String.length
                let v179 : int32 = v178 v166
                let v187 : int32 = 1 |> int32 
                let v200 : int32 = v179 |> int32 
                let v208 : int32 = v200 - 1
                let v210 : string = v166.[int v187..int v208]
                let v215 : (char -> string) = _.ToString()
                let v216 : string = v215 v176
                let v219 : int32 = v216.Length
                let v220 : (char []) = Array.zeroCreate<char> (v219)
                let v221 : Mut6 = {l0 = 0} : Mut6
                while method63(v219, v221) do
                    let v223 : int32 = v221.l0
                    let v224 : char = v216.[int v223]
                    v220.[int v223] <- v224
                    let v225 : int32 = v223 + 1
                    v221.l0 <- v225
                    ()
                let v227 : char list = v220 |> Array.toList
                let v231 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v232 : (char -> (UH0 -> UH0)) = method87()
                let v233 : (char list -> (UH0 -> UH0)) = v231 v232
                let v234 : (UH0 -> UH0) = v233 v227
                let v235 : UH0 = UH0_0
                let v236 : UH0 = v234 v235
                let struct (v261 : System.Text.StringBuilder, v262 : int32, v263 : int32) = method88(v236, v167, v168, v169)
                US15_0(v176, v210, v261, v262, v263)
    match v269 with
    | US15_1(v287) -> (* Error *)
        US16_1(v287)
    | US15_0(v270, v271, v272, v273, v274) -> (* Ok *)
        let v276 : (char -> string) = _.ToString()
        let v277 : string = v276 '`'
        let v281 : (char -> string) = _.ToString()
        let v282 : string = v281 v270
        let v285 : string = v277 + v282 
        US16_0(v285, v271, v272, v273, v274)
and method104 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH3) : US16 =
    match v4 with
    | UH3_1(v7, v8) -> (* Cons *)
        let v9 : US16 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US16_1(v15) -> (* Error *)
            method104(v0, v1, v2, v3, v8)
        | US16_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH3_0 -> (* Nil *)
        let v5 : string = "parsing.choice / no parsers succeeded"
        US16_1(v5)
and method105 (v0 : UH2, v1 : UH2) : UH2 =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : UH2 = UH2_1(v2, v1)
        method105(v3, v4)
    | UH2_0 -> (* Nil *)
        v1
and method102 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US23 =
    let v5 : bool = "" = v1
    let v145 : US15 =
        if v5 then
            let v6 : char list = []
            let v8 : char list = '"' :: v6 
            let v12 : char list = '`' :: v8 
            let v16 : char list = '\\' :: v12 
            let v20 : (char list -> (char [])) = List.toArray
            let v21 : (char []) = v20 v16
            let v25 : string = $"parsing.none_of / unexpected end of input / chars: %A{v21} / s: %A{struct (v2, v3, v4)}"
            US15_1(v25)
        else
            let v29 : char = v1.[int 0]
            let v30 : int64 = 0L
            let v31 : bool = method103(v29, v30)
            let v32 : bool = v31 = false
            if v32 then
                let v34 : (string -> int32) = String.length
                let v35 : int32 = v34 v1
                let v43 : int32 = 1 |> int32 
                let v56 : int32 = v35 |> int32 
                let v64 : int32 = v56 - 1
                let v66 : string = v1.[int v43..int v64]
                let v71 : (char -> string) = _.ToString()
                let v72 : string = v71 v29
                let v75 : int32 = v72.Length
                let v76 : (char []) = Array.zeroCreate<char> (v75)
                let v77 : Mut6 = {l0 = 0} : Mut6
                while method63(v75, v77) do
                    let v79 : int32 = v77.l0
                    let v80 : char = v72.[int v79]
                    v76.[int v79] <- v80
                    let v81 : int32 = v79 + 1
                    v77.l0 <- v81
                    ()
                let v83 : char list = v76 |> Array.toList
                let v87 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v88 : (char -> (UH0 -> UH0)) = method87()
                let v89 : (char list -> (UH0 -> UH0)) = v87 v88
                let v90 : (UH0 -> UH0) = v89 v83
                let v91 : UH0 = UH0_0
                let v92 : UH0 = v90 v91
                let struct (v117 : System.Text.StringBuilder, v118 : int32, v119 : int32) = method88(v92, v2, v3, v4)
                US15_0(v29, v66, v117, v118, v119)
            else
                let v121 : char list = []
                let v123 : char list = '"' :: v121 
                let v127 : char list = '`' :: v123 
                let v131 : char list = '\\' :: v127 
                let v135 : (char list -> (char [])) = List.toArray
                let v136 : (char []) = v135 v131
                let v140 : string = $"parsing.none_of / unexpected char: '{v29}' / chars: %A{v136} / s: %A{struct (v2, v3, v4)}"
                US15_1(v140)
    let v160 : US16 =
        match v145 with
        | US15_1(v157) -> (* Error *)
            US16_1(v157)
        | US15_0(v146, v147, v148, v149, v150) -> (* Ok *)
            let v152 : (char -> string) = _.ToString()
            let v153 : string = v152 v146
            US16_0(v153, v147, v148, v149, v150)
    let v174 : US16 =
        match v160 with
        | US16_1(v166) -> (* Error *)
            let v167 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US16) = closure41()
            let v168 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US16) = closure42()
            let v169 : UH3 = UH3_0
            let v170 : UH3 = UH3_1(v168, v169)
            let v171 : UH3 = UH3_1(v167, v170)
            method104(v1, v2, v3, v4, v171)
        | US16_0(v161, v162, v163, v164, v165) -> (* Ok *)
            v160
    match v174 with
    | US16_1(v182) -> (* Error *)
        let v183 : UH2 = UH2_0
        let v184 : UH2 = method105(v0, v183)
        US23_0(v184, v1, v2, v3, v4)
    | US16_0(v175, v176, v177, v178, v179) -> (* Ok *)
        let v180 : UH2 = UH2_1(v175, v0)
        method102(v180, v176, v177, v178, v179)
and method106 (v0 : UH2, v1 : string list) : string list =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : string list = method106(v3, v1)
        let v6 : string list = v2 :: v4 
        v6
    | UH2_0 -> (* Nil *)
        v1
and method107 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US23 =
    let v5 : bool = "" = v1
    let v145 : US15 =
        if v5 then
            let v6 : char list = []
            let v8 : char list = '"' :: v6 
            let v12 : char list = '`' :: v8 
            let v16 : char list = '\\' :: v12 
            let v20 : (char list -> (char [])) = List.toArray
            let v21 : (char []) = v20 v16
            let v25 : string = $"parsing.none_of / unexpected end of input / chars: %A{v21} / s: %A{struct (v2, v3, v4)}"
            US15_1(v25)
        else
            let v29 : char = v1.[int 0]
            let v30 : int64 = 0L
            let v31 : bool = method103(v29, v30)
            let v32 : bool = v31 = false
            if v32 then
                let v34 : (string -> int32) = String.length
                let v35 : int32 = v34 v1
                let v43 : int32 = 1 |> int32 
                let v56 : int32 = v35 |> int32 
                let v64 : int32 = v56 - 1
                let v66 : string = v1.[int v43..int v64]
                let v71 : (char -> string) = _.ToString()
                let v72 : string = v71 v29
                let v75 : int32 = v72.Length
                let v76 : (char []) = Array.zeroCreate<char> (v75)
                let v77 : Mut6 = {l0 = 0} : Mut6
                while method63(v75, v77) do
                    let v79 : int32 = v77.l0
                    let v80 : char = v72.[int v79]
                    v76.[int v79] <- v80
                    let v81 : int32 = v79 + 1
                    v77.l0 <- v81
                    ()
                let v83 : char list = v76 |> Array.toList
                let v87 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v88 : (char -> (UH0 -> UH0)) = method87()
                let v89 : (char list -> (UH0 -> UH0)) = v87 v88
                let v90 : (UH0 -> UH0) = v89 v83
                let v91 : UH0 = UH0_0
                let v92 : UH0 = v90 v91
                let struct (v117 : System.Text.StringBuilder, v118 : int32, v119 : int32) = method88(v92, v2, v3, v4)
                US15_0(v29, v66, v117, v118, v119)
            else
                let v121 : char list = []
                let v123 : char list = '"' :: v121 
                let v127 : char list = '`' :: v123 
                let v131 : char list = '\\' :: v127 
                let v135 : (char list -> (char [])) = List.toArray
                let v136 : (char []) = v135 v131
                let v140 : string = $"parsing.none_of / unexpected char: '{v29}' / chars: %A{v136} / s: %A{struct (v2, v3, v4)}"
                US15_1(v140)
    let v160 : US16 =
        match v145 with
        | US15_1(v157) -> (* Error *)
            US16_1(v157)
        | US15_0(v146, v147, v148, v149, v150) -> (* Ok *)
            let v152 : (char -> string) = _.ToString()
            let v153 : string = v152 v146
            US16_0(v153, v147, v148, v149, v150)
    match v160 with
    | US16_1(v168) -> (* Error *)
        let v169 : UH2 = UH2_0
        let v170 : UH2 = method105(v0, v169)
        US23_0(v170, v1, v2, v3, v4)
    | US16_0(v161, v162, v163, v164, v165) -> (* Ok *)
        let v166 : UH2 = UH2_1(v161, v0)
        method107(v166, v162, v163, v164, v165)
and method99 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US23 =
    let v5 : bool = "" = v1
    let v153 : US15 =
        if v5 then
            let v6 : char list = []
            let v8 : char list = ' ' :: v6 
            let v12 : char list = '"' :: v8 
            let v16 : char list = '`' :: v12 
            let v20 : char list = '\\' :: v16 
            let v24 : (char list -> (char [])) = List.toArray
            let v25 : (char []) = v24 v20
            let v29 : string = $"parsing.none_of / unexpected end of input / chars: %A{v25} / s: %A{struct (v2, v3, v4)}"
            US15_1(v29)
        else
            let v33 : char = v1.[int 0]
            let v34 : int64 = 0L
            let v35 : bool = method100(v33, v34)
            let v36 : bool = v35 = false
            if v36 then
                let v38 : (string -> int32) = String.length
                let v39 : int32 = v38 v1
                let v47 : int32 = 1 |> int32 
                let v60 : int32 = v39 |> int32 
                let v68 : int32 = v60 - 1
                let v70 : string = v1.[int v47..int v68]
                let v75 : (char -> string) = _.ToString()
                let v76 : string = v75 v33
                let v79 : int32 = v76.Length
                let v80 : (char []) = Array.zeroCreate<char> (v79)
                let v81 : Mut6 = {l0 = 0} : Mut6
                while method63(v79, v81) do
                    let v83 : int32 = v81.l0
                    let v84 : char = v76.[int v83]
                    v80.[int v83] <- v84
                    let v85 : int32 = v83 + 1
                    v81.l0 <- v85
                    ()
                let v87 : char list = v80 |> Array.toList
                let v91 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v92 : (char -> (UH0 -> UH0)) = method87()
                let v93 : (char list -> (UH0 -> UH0)) = v91 v92
                let v94 : (UH0 -> UH0) = v93 v87
                let v95 : UH0 = UH0_0
                let v96 : UH0 = v94 v95
                let struct (v121 : System.Text.StringBuilder, v122 : int32, v123 : int32) = method88(v96, v2, v3, v4)
                US15_0(v33, v70, v121, v122, v123)
            else
                let v125 : char list = []
                let v127 : char list = ' ' :: v125 
                let v131 : char list = '"' :: v127 
                let v135 : char list = '`' :: v131 
                let v139 : char list = '\\' :: v135 
                let v143 : (char list -> (char [])) = List.toArray
                let v144 : (char []) = v143 v139
                let v148 : string = $"parsing.none_of / unexpected char: '{v33}' / chars: %A{v144} / s: %A{struct (v2, v3, v4)}"
                US15_1(v148)
    let v173 : US16 =
        match v153 with
        | US15_1(v170) -> (* Error *)
            US16_1(v170)
        | US15_0(v154, v155, v156, v157, v158) -> (* Ok *)
            let v160 : (char -> string) = _.ToString()
            let v161 : string = v160 v154
            let struct (v164 : string, v165 : string, v166 : System.Text.StringBuilder, v167 : int32, v168 : int32) = method101(v161, v155, v156, v157, v158)
            US16_0(v164, v165, v166, v167, v168)
    let v635 : US16 =
        match v173 with
        | US16_1(v179) -> (* Error *)
            let v339 : US15 =
                if v5 then
                    let v181 : string = $"parsing.p_char / unexpected end of input / c: '{'"'}' / s: %A{struct (v2, v3, v4)}"
                    US15_1(v181)
                else
                    let v185 : char = v1.[int 0]
                    let v186 : bool = v185 = '"'
                    if v186 then
                        let v188 : (string -> int32) = String.length
                        let v189 : int32 = v188 v1
                        let v197 : int32 = 1 |> int32 
                        let v210 : int32 = v189 |> int32 
                        let v218 : int32 = v210 - 1
                        let v220 : string = v1.[int v197..int v218]
                        let v225 : (char -> string) = _.ToString()
                        let v226 : string = v225 v185
                        let v229 : int32 = v226.Length
                        let v230 : (char []) = Array.zeroCreate<char> (v229)
                        let v231 : Mut6 = {l0 = 0} : Mut6
                        while method63(v229, v231) do
                            let v233 : int32 = v231.l0
                            let v234 : char = v226.[int v233]
                            v230.[int v233] <- v234
                            let v235 : int32 = v233 + 1
                            v231.l0 <- v235
                            ()
                        let v237 : char list = v230 |> Array.toList
                        let v241 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v242 : (char -> (UH0 -> UH0)) = method87()
                        let v243 : (char list -> (UH0 -> UH0)) = v241 v242
                        let v244 : (UH0 -> UH0) = v243 v237
                        let v245 : UH0 = UH0_0
                        let v246 : UH0 = v244 v245
                        let struct (v271 : System.Text.StringBuilder, v272 : int32, v273 : int32) = method88(v246, v2, v3, v4)
                        US15_0(v185, v220, v271, v272, v273)
                    else
                        let v276 : string = "\n"
                        let v277 : int32 = v1.IndexOf v276 
                        let v280 : int32 = v277 - 1
                        let v281 : bool = -2 = v280
                        let v289 : int32 =
                            if v281 then
                                let v283 : (string -> int32) = String.length
                                let v284 : int32 = v283 v1
                                let v287 : int32 = v284 + 1
                                v287
                            else
                                let v288 : int32 = v280 + 1
                                v288
                        let v295 : int32 = 0 |> int32 
                        let v308 : int32 = v289 |> int32 
                        let v316 : int32 = v308 - 1
                        let v318 : string = v1.[int v295..int v316]
                        let v323 : string = $"parsing.p_char / expected: '{'"'}' / line: {v3} / col: {v4}
{v2}{v318}"
                        let v326 : int32 = v4 - 1
                        let v327 : int32 = 0
                        let v328 : (string -> string) = method89(v326, v327)
                        let v329 : string = ""
                        let v330 : string = v328 v329
                        let v331 : string = "^"
                        let v332 : string = v330 + v331 
                        let v334 : string = $"{v323}
{v332}
"
                        US15_1(v334)
            let v566 : US16 =
                match v339 with
                | US15_1(v563) -> (* Error *)
                    US16_1(v563)
                | US15_0(v340, v341, v342, v343, v344) -> (* Ok *)
                    let v345 : UH2 = UH2_0
                    let v346 : US23 = method102(v345, v341, v342, v343, v344)
                    let v377 : US16 =
                        match v346 with
                        | US23_1(v374) -> (* Error *)
                            US16_1(v374)
                        | US23_0(v347, v348, v349, v350, v351) -> (* Ok *)
                            let v352 : string list = []
                            let v353 : string list = method106(v347, v352)
                            let v357 : unit = ()
                            let _let'_v357 =
                                seq {
                                    yield! v353 
                                    (* indent
                                    ()
                                indent *)
                                }
                                (* indent
                                ()
                            indent *)
                            let v360 : string seq = _let'_v357 
                            let v367 : (string -> (string seq -> string)) = String.concat
                            let v368 : string = ""
                            let v369 : (string seq -> string) = v367 v368
                            let v370 : string = v369 v360
                            US16_0(v370, v348, v349, v350, v351)
                    match v377 with
                    | US16_1(v558) -> (* Error *)
                        let v559 : string = "parsing.between / expected content"
                        US16_1(v559)
                    | US16_0(v378, v379, v380, v381, v382) -> (* Ok *)
                        let v383 : bool = "" = v379
                        let v543 : US15 =
                            if v383 then
                                let v385 : string = $"parsing.p_char / unexpected end of input / c: '{'"'}' / s: %A{struct (v380, v381, v382)}"
                                US15_1(v385)
                            else
                                let v389 : char = v379.[int 0]
                                let v390 : bool = v389 = '"'
                                if v390 then
                                    let v392 : (string -> int32) = String.length
                                    let v393 : int32 = v392 v379
                                    let v401 : int32 = 1 |> int32 
                                    let v414 : int32 = v393 |> int32 
                                    let v422 : int32 = v414 - 1
                                    let v424 : string = v379.[int v401..int v422]
                                    let v429 : (char -> string) = _.ToString()
                                    let v430 : string = v429 v389
                                    let v433 : int32 = v430.Length
                                    let v434 : (char []) = Array.zeroCreate<char> (v433)
                                    let v435 : Mut6 = {l0 = 0} : Mut6
                                    while method63(v433, v435) do
                                        let v437 : int32 = v435.l0
                                        let v438 : char = v430.[int v437]
                                        v434.[int v437] <- v438
                                        let v439 : int32 = v437 + 1
                                        v435.l0 <- v439
                                        ()
                                    let v441 : char list = v434 |> Array.toList
                                    let v445 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                                    let v446 : (char -> (UH0 -> UH0)) = method87()
                                    let v447 : (char list -> (UH0 -> UH0)) = v445 v446
                                    let v448 : (UH0 -> UH0) = v447 v441
                                    let v449 : UH0 = UH0_0
                                    let v450 : UH0 = v448 v449
                                    let struct (v475 : System.Text.StringBuilder, v476 : int32, v477 : int32) = method88(v450, v380, v381, v382)
                                    US15_0(v389, v424, v475, v476, v477)
                                else
                                    let v480 : string = "\n"
                                    let v481 : int32 = v379.IndexOf v480 
                                    let v484 : int32 = v481 - 1
                                    let v485 : bool = -2 = v484
                                    let v493 : int32 =
                                        if v485 then
                                            let v487 : (string -> int32) = String.length
                                            let v488 : int32 = v487 v379
                                            let v491 : int32 = v488 + 1
                                            v491
                                        else
                                            let v492 : int32 = v484 + 1
                                            v492
                                    let v499 : int32 = 0 |> int32 
                                    let v512 : int32 = v493 |> int32 
                                    let v520 : int32 = v512 - 1
                                    let v522 : string = v379.[int v499..int v520]
                                    let v527 : string = $"parsing.p_char / expected: '{'"'}' / line: {v381} / col: {v382}
{v380}{v522}"
                                    let v530 : int32 = v382 - 1
                                    let v531 : int32 = 0
                                    let v532 : (string -> string) = method89(v530, v531)
                                    let v533 : string = ""
                                    let v534 : string = v532 v533
                                    let v535 : string = "^"
                                    let v536 : string = v534 + v535 
                                    let v538 : string = $"{v527}
{v536}
"
                                    US15_1(v538)
                        match v543 with
                        | US15_1(v550) -> (* Error *)
                            let v552 : string = $"parsing.between / expected closing delimiter / e: %A{v550} / input: %A{struct (v1, v2, v3, v4)} / rest1: %A{struct (v341, v342, v343, v344)} / rest2: %A{struct (v379, v380, v381, v382)}"
                            US16_1(v552)
                        | US15_0(v544, v545, v546, v547, v548) -> (* Ok *)
                            US16_0(v378, v545, v546, v547, v548)
            match v566 with
            | US16_1(v572) -> (* Error *)
                let v573 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US16) = closure41()
                let v574 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US16) = closure42()
                let v575 : UH3 = UH3_0
                let v576 : UH3 = UH3_1(v574, v575)
                let v577 : UH3 = UH3_1(v573, v576)
                let v578 : US16 = method104(v1, v2, v3, v4, v577)
                let v589 : US16 =
                    match v578 with
                    | US16_1(v586) -> (* Error *)
                        US16_1(v586)
                    | US16_0(v579, v580, v581, v582, v583) -> (* Ok *)
                        let v584 : string = ""
                        US16_0(v584, v580, v581, v582, v583)
                let v600 : US23 =
                    match v589 with
                    | US16_1(v597) -> (* Error *)
                        US23_1(v597)
                    | US16_0(v590, v591, v592, v593, v594) -> (* Ok *)
                        let v595 : UH2 = UH2_0
                        method107(v595, v591, v592, v593, v594)
                match v600 with
                | US23_1(v628) -> (* Error *)
                    US16_1(v628)
                | US23_0(v601, v602, v603, v604, v605) -> (* Ok *)
                    let v606 : string list = []
                    let v607 : string list = method106(v601, v606)
                    let v611 : unit = ()
                    let _let'_v611 =
                        seq {
                            yield! v607 
                            (* indent
                            ()
                        indent *)
                        }
                        (* indent
                        ()
                    indent *)
                    let v614 : string seq = _let'_v611 
                    let v621 : (string -> (string seq -> string)) = String.concat
                    let v622 : string = ""
                    let v623 : (string seq -> string) = v621 v622
                    let v624 : string = v623 v614
                    US16_0(v624, v602, v603, v604, v605)
            | US16_0(v567, v568, v569, v570, v571) -> (* Ok *)
                v566
        | US16_0(v174, v175, v176, v177, v178) -> (* Ok *)
            v173
    match v635 with
    | US16_1(v698) -> (* Error *)
        let v699 : UH2 = UH2_0
        let v700 : UH2 = method105(v0, v699)
        US23_0(v700, v1, v2, v3, v4)
    | US16_0(v636, v637, v638, v639, v640) -> (* Ok *)
        let v641 : int32 = 0
        let v642 : int32 = method96(v637, v641)
        let v643 : bool = 0 = v642
        let v684 : US18 =
            if v643 then
                let v644 : string = "parsing.spaces1 / expected at least one space"
                US18_1(v644)
            else
                let v647 : (string -> int32) = String.length
                let v648 : int32 = v647 v637
                let v656 : int32 = v642 |> int32 
                let v669 : int32 = v648 |> int32 
                let v677 : int32 = v669 - 1
                let v679 : string = v637.[int v656..int v677]
                US18_0(v679, v638, v639, v640)
        match v684 with
        | US18_1(v691) -> (* Error *)
            let v692 : UH2 = UH2_0
            let v693 : UH2 = UH2_1(v636, v692)
            let v694 : UH2 = method105(v0, v693)
            US23_0(v694, v637, v638, v639, v640)
        | US18_0(v685, v686, v687, v688) -> (* Ok *)
            let v689 : UH2 = UH2_1(v636, v0)
            method99(v689, v685, v686, v687, v688)
and method98 (v0 : string) : US22 =
    let mutable _v0 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v2 : (string -> string option) = Option.ofObj
    let v3 : string option = v2 v0
    v3 
    #else
    Some v0 
    #endif
    |> fun x -> _v0 <- Some x
    let v4 : string option = match _v0 with Some x -> x | None -> failwith "optionm'.of_obj / _v0=None"
    let v8 : string = ""
    let v9 : string = v4 |> Option.defaultValue v8 
    let v12 : string = method86()
    let v14 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v15 : System.Text.StringBuilder = v14 v12
    let v18 : UH2 = UH2_0
    let v19 : int32 = 1
    let v20 : int32 = 1
    let v21 : US23 = method99(v18, v9, v15, v19, v20)
    match v21 with
    | US23_1(v35) -> (* Error *)
        US22_1(v35)
    | US23_0(v22, v23, v24, v25, v26) -> (* Ok *)
        let v27 : string list = []
        let v28 : string list = method106(v22, v27)
        let v30 : (string list -> (string [])) = List.toArray
        let v31 : (string []) = v30 v28
        US22_0(v31)
and method109 (v0 : string, v1 : string, v2 : string, v3 : System.Threading.CancellationToken option, v4 : (struct (string * string) []), v5 : (struct (int32 * string * bool) -> Async<unit>) option, v6 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v7 : bool, v8 : string option) : string =
    let v9 : string = method14()
    let v10 : Mut3 = {l0 = v9} : Mut3
    let v12 : string = "{ "
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure8(v10, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v22 : string = "file_name"
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure8(v10, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v32 : string = " = "
    let v33 : string = $"{v32}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure8(v10, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v42 : string = $"{v0}"
    let v45 : unit = ()
    let v46 : (unit -> unit) = closure8(v10, v42)
    let v47 : unit = (fun () -> v46 (); v45) ()
    let v51 : string = "; "
    let v52 : string = $"{v51}"
    let v55 : unit = ()
    let v56 : (unit -> unit) = closure8(v10, v52)
    let v57 : unit = (fun () -> v56 (); v55) ()
    let v61 : string = "arguments"
    let v62 : string = $"{v61}"
    let v65 : unit = ()
    let v66 : (unit -> unit) = closure8(v10, v62)
    let v67 : unit = (fun () -> v66 (); v65) ()
    let v71 : string = $"{v32}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure8(v10, v71)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v80 : string = $"{v1}"
    let v83 : unit = ()
    let v84 : (unit -> unit) = closure8(v10, v80)
    let v85 : unit = (fun () -> v84 (); v83) ()
    let v89 : string = $"{v51}"
    let v92 : unit = ()
    let v93 : (unit -> unit) = closure8(v10, v89)
    let v94 : unit = (fun () -> v93 (); v92) ()
    let v98 : string = "options"
    let v99 : string = $"{v98}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure8(v10, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v108 : string = $"{v32}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure8(v10, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v117 : string = $"{v12}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure8(v10, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v126 : string = "command"
    let v127 : string = $"{v126}"
    let v130 : unit = ()
    let v131 : (unit -> unit) = closure8(v10, v127)
    let v132 : unit = (fun () -> v131 (); v130) ()
    let v136 : string = $"{v32}"
    let v139 : unit = ()
    let v140 : (unit -> unit) = closure8(v10, v136)
    let v141 : unit = (fun () -> v140 (); v139) ()
    let v145 : string = $"{v2}"
    let v148 : unit = ()
    let v149 : (unit -> unit) = closure8(v10, v145)
    let v150 : unit = (fun () -> v149 (); v148) ()
    let v154 : string = $"{v51}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure8(v10, v154)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v163 : string = "cancellation_token"
    let v164 : string = $"{v163}"
    let v167 : unit = ()
    let v168 : (unit -> unit) = closure8(v10, v164)
    let v169 : unit = (fun () -> v168 (); v167) ()
    let v173 : string = $"{v32}"
    let v176 : unit = ()
    let v177 : (unit -> unit) = closure8(v10, v173)
    let v178 : unit = (fun () -> v177 (); v176) ()
    (* run_target_args'
    let v185 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v186 : string = "format!(\"{:#?}\", $0)"
    let v187 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v186 
    let v188 : string = "fable_library_rust::String_::fromString($0)"
    let v189 : string = Fable.Core.RustInterop.emitRustExpr v187 v188 
    let _run_target_args'_v185 = v189 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v190 : string = "format!(\"{:#?}\", $0)"
    let v191 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v190 
    let v192 : string = "fable_library_rust::String_::fromString($0)"
    let v193 : string = Fable.Core.RustInterop.emitRustExpr v191 v192 
    let _run_target_args'_v185 = v193 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v194 : string = "format!(\"{:#?}\", $0)"
    let v195 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v194 
    let v196 : string = "fable_library_rust::String_::fromString($0)"
    let v197 : string = Fable.Core.RustInterop.emitRustExpr v195 v196 
    let _run_target_args'_v185 = v197 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v199 : string = $"%A{v3}"
    let _run_target_args'_v185 = v199 
    #endif
#if FABLE_COMPILER_PYTHON
    let v203 : string = $"%A{v3}"
    let _run_target_args'_v185 = v203 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v207 : string = $"%A{v3}"
    let _run_target_args'_v185 = v207 
    #endif
#else
    let v211 : string = $"%A{v3}"
    let _run_target_args'_v185 = v211 
    #endif
    let v214 : string = _run_target_args'_v185 
    let v221 : string = $"{v214}"
    let v224 : unit = ()
    let v225 : (unit -> unit) = closure8(v10, v221)
    let v226 : unit = (fun () -> v225 (); v224) ()
    let v230 : string = $"{v51}"
    let v233 : unit = ()
    let v234 : (unit -> unit) = closure8(v10, v230)
    let v235 : unit = (fun () -> v234 (); v233) ()
    let v239 : string = "environment_variables"
    let v240 : string = $"{v239}"
    let v243 : unit = ()
    let v244 : (unit -> unit) = closure8(v10, v240)
    let v245 : unit = (fun () -> v244 (); v243) ()
    let v249 : string = $"{v32}"
    let v252 : unit = ()
    let v253 : (unit -> unit) = closure8(v10, v249)
    let v254 : unit = (fun () -> v253 (); v252) ()
    let v258 : string = $"%A{v4}"
    let v262 : string = $"{v258}"
    let v265 : unit = ()
    let v266 : (unit -> unit) = closure8(v10, v262)
    let v267 : unit = (fun () -> v266 (); v265) ()
    let v271 : string = $"{v51}"
    let v274 : unit = ()
    let v275 : (unit -> unit) = closure8(v10, v271)
    let v276 : unit = (fun () -> v275 (); v274) ()
    let v280 : string = "on_line"
    let v281 : string = $"{v280}"
    let v284 : unit = ()
    let v285 : (unit -> unit) = closure8(v10, v281)
    let v286 : unit = (fun () -> v285 (); v284) ()
    let v290 : string = $"{v32}"
    let v293 : unit = ()
    let v294 : (unit -> unit) = closure8(v10, v290)
    let v295 : unit = (fun () -> v294 (); v293) ()
    (* run_target_args'
    let v302 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v303 : string = "format!(\"{:#?}\", $0)"
    let v304 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v303 
    let v305 : string = "fable_library_rust::String_::fromString($0)"
    let v306 : string = Fable.Core.RustInterop.emitRustExpr v304 v305 
    let _run_target_args'_v302 = v306 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v307 : string = "format!(\"{:#?}\", $0)"
    let v308 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v307 
    let v309 : string = "fable_library_rust::String_::fromString($0)"
    let v310 : string = Fable.Core.RustInterop.emitRustExpr v308 v309 
    let _run_target_args'_v302 = v310 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v311 : string = "format!(\"{:#?}\", $0)"
    let v312 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v311 
    let v313 : string = "fable_library_rust::String_::fromString($0)"
    let v314 : string = Fable.Core.RustInterop.emitRustExpr v312 v313 
    let _run_target_args'_v302 = v314 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v316 : string = $"%A{v5}"
    let _run_target_args'_v302 = v316 
    #endif
#if FABLE_COMPILER_PYTHON
    let v320 : string = $"%A{v5}"
    let _run_target_args'_v302 = v320 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v324 : string = $"%A{v5}"
    let _run_target_args'_v302 = v324 
    #endif
#else
    let v328 : string = $"%A{v5}"
    let _run_target_args'_v302 = v328 
    #endif
    let v331 : string = _run_target_args'_v302 
    let v338 : string = $"{v331}"
    let v341 : unit = ()
    let v342 : (unit -> unit) = closure8(v10, v338)
    let v343 : unit = (fun () -> v342 (); v341) ()
    let v347 : string = $"{v51}"
    let v350 : unit = ()
    let v351 : (unit -> unit) = closure8(v10, v347)
    let v352 : unit = (fun () -> v351 (); v350) ()
    let v356 : string = "stdin"
    let v357 : string = $"{v356}"
    let v360 : unit = ()
    let v361 : (unit -> unit) = closure8(v10, v357)
    let v362 : unit = (fun () -> v361 (); v360) ()
    let v366 : string = $"{v32}"
    let v369 : unit = ()
    let v370 : (unit -> unit) = closure8(v10, v366)
    let v371 : unit = (fun () -> v370 (); v369) ()
    (* run_target_args'
    let v378 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v379 : string = "format!(\"{:#?}\", $0)"
    let v380 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v379 
    let v381 : string = "fable_library_rust::String_::fromString($0)"
    let v382 : string = Fable.Core.RustInterop.emitRustExpr v380 v381 
    let _run_target_args'_v378 = v382 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v383 : string = "format!(\"{:#?}\", $0)"
    let v384 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v383 
    let v385 : string = "fable_library_rust::String_::fromString($0)"
    let v386 : string = Fable.Core.RustInterop.emitRustExpr v384 v385 
    let _run_target_args'_v378 = v386 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v387 : string = "format!(\"{:#?}\", $0)"
    let v388 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v387 
    let v389 : string = "fable_library_rust::String_::fromString($0)"
    let v390 : string = Fable.Core.RustInterop.emitRustExpr v388 v389 
    let _run_target_args'_v378 = v390 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v392 : string = $"%A{v6}"
    let _run_target_args'_v378 = v392 
    #endif
#if FABLE_COMPILER_PYTHON
    let v396 : string = $"%A{v6}"
    let _run_target_args'_v378 = v396 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v400 : string = $"%A{v6}"
    let _run_target_args'_v378 = v400 
    #endif
#else
    let v404 : string = $"%A{v6}"
    let _run_target_args'_v378 = v404 
    #endif
    let v407 : string = _run_target_args'_v378 
    let v414 : string = $"{v407}"
    let v417 : unit = ()
    let v418 : (unit -> unit) = closure8(v10, v414)
    let v419 : unit = (fun () -> v418 (); v417) ()
    let v423 : string = $"{v51}"
    let v426 : unit = ()
    let v427 : (unit -> unit) = closure8(v10, v423)
    let v428 : unit = (fun () -> v427 (); v426) ()
    let v432 : string = "trace"
    let v433 : string = $"{v432}"
    let v436 : unit = ()
    let v437 : (unit -> unit) = closure8(v10, v433)
    let v438 : unit = (fun () -> v437 (); v436) ()
    let v442 : string = $"{v32}"
    let v445 : unit = ()
    let v446 : (unit -> unit) = closure8(v10, v442)
    let v447 : unit = (fun () -> v446 (); v445) ()
    let v452 : string =
        if v7 then
            let v450 : string = "true"
            v450
        else
            let v451 : string = "false"
            v451
    let v454 : string = $"{v452}"
    let v457 : unit = ()
    let v458 : (unit -> unit) = closure8(v10, v454)
    let v459 : unit = (fun () -> v458 (); v457) ()
    let v463 : string = $"{v51}"
    let v466 : unit = ()
    let v467 : (unit -> unit) = closure8(v10, v463)
    let v468 : unit = (fun () -> v467 (); v466) ()
    let v472 : string = "working_directory"
    let v473 : string = $"{v472}"
    let v476 : unit = ()
    let v477 : (unit -> unit) = closure8(v10, v473)
    let v478 : unit = (fun () -> v477 (); v476) ()
    let v482 : string = $"{v32}"
    let v485 : unit = ()
    let v486 : (unit -> unit) = closure8(v10, v482)
    let v487 : unit = (fun () -> v486 (); v485) ()
    (* run_target_args'
    let v494 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v495 : string = "format!(\"{:#?}\", $0)"
    let v496 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v495 
    let v497 : string = "fable_library_rust::String_::fromString($0)"
    let v498 : string = Fable.Core.RustInterop.emitRustExpr v496 v497 
    let _run_target_args'_v494 = v498 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v499 : string = "format!(\"{:#?}\", $0)"
    let v500 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v499 
    let v501 : string = "fable_library_rust::String_::fromString($0)"
    let v502 : string = Fable.Core.RustInterop.emitRustExpr v500 v501 
    let _run_target_args'_v494 = v502 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v503 : string = "format!(\"{:#?}\", $0)"
    let v504 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v503 
    let v505 : string = "fable_library_rust::String_::fromString($0)"
    let v506 : string = Fable.Core.RustInterop.emitRustExpr v504 v505 
    let _run_target_args'_v494 = v506 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v508 : string = $"%A{v8}"
    let _run_target_args'_v494 = v508 
    #endif
#if FABLE_COMPILER_PYTHON
    let v512 : string = $"%A{v8}"
    let _run_target_args'_v494 = v512 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v516 : string = $"%A{v8}"
    let _run_target_args'_v494 = v516 
    #endif
#else
    let v520 : string = $"%A{v8}"
    let _run_target_args'_v494 = v520 
    #endif
    let v523 : string = _run_target_args'_v494 
    let v530 : string = $"{v523}"
    let v533 : unit = ()
    let v534 : (unit -> unit) = closure8(v10, v530)
    let v535 : unit = (fun () -> v534 (); v533) ()
    let v539 : string = " }"
    let v540 : string = $"{v539}"
    let v543 : unit = ()
    let v544 : (unit -> unit) = closure8(v10, v540)
    let v545 : unit = (fun () -> v544 (); v543) ()
    let v549 : string = $"{v539}"
    let v552 : unit = ()
    let v553 : (unit -> unit) = closure8(v10, v549)
    let v554 : unit = (fun () -> v553 (); v552) ()
    let v557 : string = v10.l0
    v557
and method108 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option) : string =
    let v17 : string = method109(v8, v9, v10, v11, v12, v13, v14, v15, v16)
    let v18 : int64 = v0.l0
    let v20 : string = "runtime.execute_with_options"
    let v21 : string = $"{v6} {v7} #{v18} %s{v20} / {v17}"
    method18(v21)
and closure43 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : string, v8 : Vec<std_string_String>) () : unit =
    let v9 : US0 = US0_1
    let v10 : bool = method7(v9)
    if v10 then
        let v11 : unit = ()
        let v12 : (unit -> unit) = closure6()
        let v13 : unit = (fun () -> v12 (); v11) ()
        let struct (v34 : Mut0, v35 : Mut1, v36 : Mut2, v37 : Mut3, v38 : Mut4, v39 : int64 option) = TraceState.trace_state.Value
        let v52 : string = method8(v34, v35, v36, v37, v38, v39)
        let v53 : string = method66()
        let v55 : string = $"%A{v8}"
        let v58 : string = method108(v34, v35, v36, v37, v38, v39, v52, v53, v7, v55, v0, v1, v2, v3, v4, v5, v6)
        method19(v58)
and closure44 () (v0 : std_process_Child option) : std_process_Child option =
    v0
and method110 () : (std_process_Child option -> std_process_Child option) =
    closure44()
and closure45 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : US24 =
    US24_0(v0)
and method111 () : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US24) =
    closure45()
and closure46 () (v0 : std_string_String) : US24 =
    US24_1(v0)
and method112 () : (std_string_String -> US24) =
    closure46()
and method113 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method78(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "runtime.execute_with_options / child error"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method18(v13)
and closure47 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_4
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method76()
        let v46 : string = method113(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method19(v46)
and method114 (v0 : std_sync_MutexGuard<std_process_Child option>) : std_sync_MutexGuard<std_process_Child option> =
    v0
and closure48 () (v0 : std_process_ChildStdin option) : std_process_ChildStdin option =
    v0
and method115 () : (std_process_ChildStdin option -> std_process_ChildStdin option) =
    closure48()
and closure49 () (v0 : std_sync_mpsc_Sender<std_string_String>) : std_sync_mpsc_Sender<std_string_String> =
    v0
and method116 () : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) =
    closure49()
and method117 () : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) =
    closure49()
and closure50 () (v0 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> =
    v0
and method118 () : (std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> -> std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) =
    closure50()
and closure51 () (v0 : std_string_String) : US26 =
    US26_0(v0)
and method119 () : (std_string_String -> US26) =
    closure51()
and closure52 () (v0 : std_string_String) : US26 =
    US26_1(v0)
and method120 () : (std_string_String -> US26) =
    closure52()
and method122 (v0 : bool, v1 : std_string_String) : string =
    let v2 : string = method14()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure8(v3, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v15 : string = "trace'"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure8(v3, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v25 : string = " = "
    let v26 : string = $"{v25}"
    let v29 : unit = ()
    let v30 : (unit -> unit) = closure8(v3, v26)
    let v31 : unit = (fun () -> v30 (); v29) ()
    let v36 : string =
        if v0 then
            let v34 : string = "true"
            v34
        else
            let v35 : string = "false"
            v35
    let v38 : string = $"{v36}"
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure8(v3, v38)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v47 : string = "; "
    let v48 : string = $"{v47}"
    let v51 : unit = ()
    let v52 : (unit -> unit) = closure8(v3, v48)
    let v53 : unit = (fun () -> v52 (); v51) ()
    let v57 : string = "e"
    let v58 : string = $"{v57}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure8(v3, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v67 : string = $"{v25}"
    let v70 : unit = ()
    let v71 : (unit -> unit) = closure8(v3, v67)
    let v72 : unit = (fun () -> v71 (); v70) ()
    (* run_target_args'
    let v79 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v80 : string = "format!(\"{:#?}\", $0)"
    let v81 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v80 
    let v82 : string = "fable_library_rust::String_::fromString($0)"
    let v83 : string = Fable.Core.RustInterop.emitRustExpr v81 v82 
    let _run_target_args'_v79 = v83 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v84 : string = "format!(\"{:#?}\", $0)"
    let v85 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v84 
    let v86 : string = "fable_library_rust::String_::fromString($0)"
    let v87 : string = Fable.Core.RustInterop.emitRustExpr v85 v86 
    let _run_target_args'_v79 = v87 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v88 : string = "format!(\"{:#?}\", $0)"
    let v89 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v88 
    let v90 : string = "fable_library_rust::String_::fromString($0)"
    let v91 : string = Fable.Core.RustInterop.emitRustExpr v89 v90 
    let _run_target_args'_v79 = v91 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v93 : string = $"%A{v1}"
    let _run_target_args'_v79 = v93 
    #endif
#if FABLE_COMPILER_PYTHON
    let v97 : string = $"%A{v1}"
    let _run_target_args'_v79 = v97 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v101 : string = $"%A{v1}"
    let _run_target_args'_v79 = v101 
    #endif
#else
    let v105 : string = $"%A{v1}"
    let _run_target_args'_v79 = v105 
    #endif
    let v108 : string = _run_target_args'_v79 
    let v115 : string = $"{v108}"
    let v118 : unit = ()
    let v119 : (unit -> unit) = closure8(v3, v115)
    let v120 : unit = (fun () -> v119 (); v118) ()
    let v124 : string = " }"
    let v125 : string = $"{v124}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure8(v3, v125)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v133 : string = v3.l0
    v133
and method121 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : bool, v9 : std_string_String) : string =
    let v10 : string = method122(v8, v9)
    let v11 : int64 = v0.l0
    let v13 : string = "runtime.stdio_line"
    let v14 : string = $"{v6} {v7} #{v11} %s{v13} / {v10}"
    method18(v14)
and closure53 (v0 : bool, v1 : std_string_String) () : unit =
    let v2 : US0 = US0_4
    let v3 : bool = method7(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method8(v27, v28, v29, v30, v31, v32)
        let v46 : string = method76()
        let v47 : string = method121(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method19(v47)
and method123 () : string =
    
    
    
    
    
    let v1 : string = "Verbose"
    let v2 : (unit -> string) = v1.ToLower
    let v3 : string = v2 ()
    let v6 : char = v3.[int 0]
    let v7 : string = method13(v6)
    (* run_target_args'
    let v12 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : string = "inline_colorization::color_bright_black"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v13 
    (* run_target_args'
    let v19 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "&*$0"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v20 
    let _run_target_args'_v19 = v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v22 
    let _run_target_args'_v19 = v23 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : string = "&*$0"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v24 
    let _run_target_args'_v19 = v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v27 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v31 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v35 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v35 
    #endif
#else
    let v39 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v39 
    #endif
    let v42 : Ref<Str> = _run_target_args'_v19 
    let v48 : string = "inline_colorization::color_reset"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v14, v42, v49) v50 
    let v52 : string = "fable_library_rust::String_::fromString($0)"
    let v53 : string = Fable.Core.RustInterop.emitRustExpr v51 v52 
    let _run_target_args'_v12 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "inline_colorization::color_bright_black"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v54 
    (* run_target_args'
    let v60 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v61 : string = "&*$0"
    let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v61 
    let _run_target_args'_v60 = v62 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : string = "&*$0"
    let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v63 
    let _run_target_args'_v60 = v64 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = "&*$0"
    let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v65 
    let _run_target_args'_v60 = v66 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v68 
    #endif
#if FABLE_COMPILER_PYTHON
    let v72 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v72 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v76 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v76 
    #endif
#else
    let v80 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v80 
    #endif
    let v83 : Ref<Str> = _run_target_args'_v60 
    let v89 : string = "inline_colorization::color_reset"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v55, v83, v90) v91 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let _run_target_args'_v12 = v94 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v95 : string = "inline_colorization::color_bright_black"
    let v96 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v95 
    (* run_target_args'
    let v101 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v102 : string = "&*$0"
    let v103 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v102 
    let _run_target_args'_v101 = v103 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : string = "&*$0"
    let v105 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v104 
    let _run_target_args'_v101 = v105 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v106 : string = "&*$0"
    let v107 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v106 
    let _run_target_args'_v101 = v107 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v109 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v109 
    #endif
#if FABLE_COMPILER_PYTHON
    let v113 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v113 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v117 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v117 
    #endif
#else
    let v121 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v121 
    #endif
    let v124 : Ref<Str> = _run_target_args'_v101 
    let v130 : string = "inline_colorization::color_reset"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v96, v124, v131) v132 
    let v134 : string = "fable_library_rust::String_::fromString($0)"
    let v135 : string = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let _run_target_args'_v12 = v135 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v136 : string = "\u001b[90m"
    let v137 : string = method15()
    let v138 : string = v136 + v7 
    let v139 : string = v138 + v137 
    let _run_target_args'_v12 = v139 
    #endif
#if FABLE_COMPILER_PYTHON
    let v140 : string = "\u001b[90m"
    let v141 : string = method15()
    let v142 : string = v140 + v7 
    let v143 : string = v142 + v141 
    let _run_target_args'_v12 = v143 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v144 : string = "\u001b[90m"
    let v145 : string = method15()
    let v146 : string = v144 + v7 
    let v147 : string = v146 + v145 
    let _run_target_args'_v12 = v147 
    #endif
#else
    let v148 : string = "\u001b[90m"
    let v149 : string = method15()
    let v150 : string = v148 + v7 
    let v151 : string = v150 + v149 
    let _run_target_args'_v12 = v151 
    #endif
    let v152 : string = _run_target_args'_v12 
    v152
and method125 () : string =
    let v0 : string = method14()
    let v1 : Mut3 = {l0 = v0} : Mut3
    let v2 : string = v1.l0
    v2
and method124 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method125()
    let v10 : int64 = v0.l0
    let v12 : string = $"{v6} {v7} #{v10} %s{v8} / {v9}"
    method18(v12)
and closure54 (v0 : string) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method123()
        let v46 : bool = v0 = ""
        let v49 : string =
            if v46 then
                let v47 : string = ""
                v47
            else
                method124(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method19(v49)
and closure55 () (v0 : std_sync_mpsc_SendError<std_string_String>) : std_string_String =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    let _run_target_args'_v5 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    let _run_target_args'_v5 = v9 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : string = "format!(\"{}\", $0)"
    let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v10 
    let _run_target_args'_v5 = v11 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v17 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v17 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v21 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v21 
    #endif
#else
    let v25 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v25 
    #endif
    let v28 : std_string_String = _run_target_args'_v5 
    v28
and method126 () : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) =
    closure55()
and method127 (v0 : Result<unit, string>) : Result<unit, string> =
    v0
and closure56 () (v0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)) : US27 =
    US27_0(v0)
and method128 () : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US27) =
    closure56()
and method129 (v0 : std_sync_MutexGuard<std_process_ChildStdin option>) : std_sync_MutexGuard<std_process_ChildStdin option> =
    v0
and closure57 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : US28 =
    US28_0(v0)
and method130 () : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US28) =
    closure57()
and method131 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure58 () (v0 : std_process_Output) : US29 =
    US29_0(v0)
and method132 () : (std_process_Output -> US29) =
    closure58()
and closure59 () (v0 : std_string_String) : US29 =
    US29_1(v0)
and method133 () : (std_string_String -> US29) =
    closure59()
and method134 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method78(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "runtime.execute_with_options / output error"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method18(v13)
and closure60 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_4
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method76()
        let v46 : string = method134(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method19(v46)
and closure61 () (v0 : int32) : US30 =
    US30_0(v0)
and method135 () : (int32 -> US30) =
    closure61()
and method136 () : string =
    let v0 : string = "\n"
    v0
and method138 (v0 : int32, v1 : int32) : string =
    let v2 : string = method14()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure8(v3, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v15 : string = "exit_code"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure8(v3, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v25 : string = " = "
    let v26 : string = $"{v25}"
    let v29 : unit = ()
    let v30 : (unit -> unit) = closure8(v3, v26)
    let v31 : unit = (fun () -> v30 (); v29) ()
    let v35 : string = $"{v0}"
    let v38 : unit = ()
    let v39 : (unit -> unit) = closure8(v3, v35)
    let v40 : unit = (fun () -> v39 (); v38) ()
    let v44 : string = "; "
    let v45 : string = $"{v44}"
    let v48 : unit = ()
    let v49 : (unit -> unit) = closure8(v3, v45)
    let v50 : unit = (fun () -> v49 (); v48) ()
    let v54 : string = "std_trace_length"
    let v55 : string = $"{v54}"
    let v58 : unit = ()
    let v59 : (unit -> unit) = closure8(v3, v55)
    let v60 : unit = (fun () -> v59 (); v58) ()
    let v64 : string = $"{v25}"
    let v67 : unit = ()
    let v68 : (unit -> unit) = closure8(v3, v64)
    let v69 : unit = (fun () -> v68 (); v67) ()
    let v73 : string = $"{v1}"
    let v76 : unit = ()
    let v77 : (unit -> unit) = closure8(v3, v73)
    let v78 : unit = (fun () -> v77 (); v76) ()
    let v82 : string = " }"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v3, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = v3.l0
    v91
and method137 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32) : string =
    let v10 : string = method138(v8, v9)
    let v11 : int64 = v0.l0
    let v13 : string = "runtime.execute_with_options / result"
    let v14 : string = $"{v6} {v7} #{v11} %s{v13} / {v10}"
    method18(v14)
and closure62 (v0 : int32, v1 : string) () : unit =
    let v2 : US0 = US0_0
    let v3 : bool = method7(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method8(v27, v28, v29, v30, v31, v32)
        let v46 : string = method123()
        let v47 : int32 = v1.Length
        let v48 : string = method137(v27, v28, v29, v30, v31, v32, v45, v46, v0, v47)
        method19(v48)
and method142 (v0 : string, v1 : US5, v2 : string, v3 : System.Threading.CancellationToken option, v4 : (struct (string * string) []), v5 : (struct (int32 * string * bool) -> Async<unit>) option, v6 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v7 : bool, v8 : string option) : string =
    let v9 : string = method14()
    let v10 : Mut3 = {l0 = v9} : Mut3
    let v12 : string = "{ "
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure8(v10, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v22 : string = "file_name"
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure8(v10, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v32 : string = " = "
    let v33 : string = $"{v32}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure8(v10, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v42 : string = $"{v0}"
    let v45 : unit = ()
    let v46 : (unit -> unit) = closure8(v10, v42)
    let v47 : unit = (fun () -> v46 (); v45) ()
    let v51 : string = "; "
    let v52 : string = $"{v51}"
    let v55 : unit = ()
    let v56 : (unit -> unit) = closure8(v10, v52)
    let v57 : unit = (fun () -> v56 (); v55) ()
    let v61 : string = "arguments"
    let v62 : string = $"{v61}"
    let v65 : unit = ()
    let v66 : (unit -> unit) = closure8(v10, v62)
    let v67 : unit = (fun () -> v66 (); v65) ()
    let v71 : string = $"{v32}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure8(v10, v71)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v80 : string = $"%A{v1}"
    let v84 : string = $"{v80}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure8(v10, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v93 : string = $"{v51}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure8(v10, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v102 : string = "options"
    let v103 : string = $"{v102}"
    let v106 : unit = ()
    let v107 : (unit -> unit) = closure8(v10, v103)
    let v108 : unit = (fun () -> v107 (); v106) ()
    let v112 : string = $"{v32}"
    let v115 : unit = ()
    let v116 : (unit -> unit) = closure8(v10, v112)
    let v117 : unit = (fun () -> v116 (); v115) ()
    let v121 : string = $"{v12}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure8(v10, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v130 : string = "command"
    let v131 : string = $"{v130}"
    let v134 : unit = ()
    let v135 : (unit -> unit) = closure8(v10, v131)
    let v136 : unit = (fun () -> v135 (); v134) ()
    let v140 : string = $"{v32}"
    let v143 : unit = ()
    let v144 : (unit -> unit) = closure8(v10, v140)
    let v145 : unit = (fun () -> v144 (); v143) ()
    let v149 : string = $"{v2}"
    let v152 : unit = ()
    let v153 : (unit -> unit) = closure8(v10, v149)
    let v154 : unit = (fun () -> v153 (); v152) ()
    let v158 : string = $"{v51}"
    let v161 : unit = ()
    let v162 : (unit -> unit) = closure8(v10, v158)
    let v163 : unit = (fun () -> v162 (); v161) ()
    let v167 : string = "cancellation_token"
    let v168 : string = $"{v167}"
    let v171 : unit = ()
    let v172 : (unit -> unit) = closure8(v10, v168)
    let v173 : unit = (fun () -> v172 (); v171) ()
    let v177 : string = $"{v32}"
    let v180 : unit = ()
    let v181 : (unit -> unit) = closure8(v10, v177)
    let v182 : unit = (fun () -> v181 (); v180) ()
    (* run_target_args'
    let v189 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v190 : string = "format!(\"{:#?}\", $0)"
    let v191 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v190 
    let v192 : string = "fable_library_rust::String_::fromString($0)"
    let v193 : string = Fable.Core.RustInterop.emitRustExpr v191 v192 
    let _run_target_args'_v189 = v193 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v194 : string = "format!(\"{:#?}\", $0)"
    let v195 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v194 
    let v196 : string = "fable_library_rust::String_::fromString($0)"
    let v197 : string = Fable.Core.RustInterop.emitRustExpr v195 v196 
    let _run_target_args'_v189 = v197 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v198 : string = "format!(\"{:#?}\", $0)"
    let v199 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v198 
    let v200 : string = "fable_library_rust::String_::fromString($0)"
    let v201 : string = Fable.Core.RustInterop.emitRustExpr v199 v200 
    let _run_target_args'_v189 = v201 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v203 : string = $"%A{v3}"
    let _run_target_args'_v189 = v203 
    #endif
#if FABLE_COMPILER_PYTHON
    let v207 : string = $"%A{v3}"
    let _run_target_args'_v189 = v207 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v211 : string = $"%A{v3}"
    let _run_target_args'_v189 = v211 
    #endif
#else
    let v215 : string = $"%A{v3}"
    let _run_target_args'_v189 = v215 
    #endif
    let v218 : string = _run_target_args'_v189 
    let v225 : string = $"{v218}"
    let v228 : unit = ()
    let v229 : (unit -> unit) = closure8(v10, v225)
    let v230 : unit = (fun () -> v229 (); v228) ()
    let v234 : string = $"{v51}"
    let v237 : unit = ()
    let v238 : (unit -> unit) = closure8(v10, v234)
    let v239 : unit = (fun () -> v238 (); v237) ()
    let v243 : string = "environment_variables"
    let v244 : string = $"{v243}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure8(v10, v244)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v253 : string = $"{v32}"
    let v256 : unit = ()
    let v257 : (unit -> unit) = closure8(v10, v253)
    let v258 : unit = (fun () -> v257 (); v256) ()
    let v262 : string = $"%A{v4}"
    let v266 : string = $"{v262}"
    let v269 : unit = ()
    let v270 : (unit -> unit) = closure8(v10, v266)
    let v271 : unit = (fun () -> v270 (); v269) ()
    let v275 : string = $"{v51}"
    let v278 : unit = ()
    let v279 : (unit -> unit) = closure8(v10, v275)
    let v280 : unit = (fun () -> v279 (); v278) ()
    let v284 : string = "on_line"
    let v285 : string = $"{v284}"
    let v288 : unit = ()
    let v289 : (unit -> unit) = closure8(v10, v285)
    let v290 : unit = (fun () -> v289 (); v288) ()
    let v294 : string = $"{v32}"
    let v297 : unit = ()
    let v298 : (unit -> unit) = closure8(v10, v294)
    let v299 : unit = (fun () -> v298 (); v297) ()
    (* run_target_args'
    let v306 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v307 : string = "format!(\"{:#?}\", $0)"
    let v308 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v307 
    let v309 : string = "fable_library_rust::String_::fromString($0)"
    let v310 : string = Fable.Core.RustInterop.emitRustExpr v308 v309 
    let _run_target_args'_v306 = v310 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v311 : string = "format!(\"{:#?}\", $0)"
    let v312 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v311 
    let v313 : string = "fable_library_rust::String_::fromString($0)"
    let v314 : string = Fable.Core.RustInterop.emitRustExpr v312 v313 
    let _run_target_args'_v306 = v314 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v315 : string = "format!(\"{:#?}\", $0)"
    let v316 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v315 
    let v317 : string = "fable_library_rust::String_::fromString($0)"
    let v318 : string = Fable.Core.RustInterop.emitRustExpr v316 v317 
    let _run_target_args'_v306 = v318 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v320 : string = $"%A{v5}"
    let _run_target_args'_v306 = v320 
    #endif
#if FABLE_COMPILER_PYTHON
    let v324 : string = $"%A{v5}"
    let _run_target_args'_v306 = v324 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v328 : string = $"%A{v5}"
    let _run_target_args'_v306 = v328 
    #endif
#else
    let v332 : string = $"%A{v5}"
    let _run_target_args'_v306 = v332 
    #endif
    let v335 : string = _run_target_args'_v306 
    let v342 : string = $"{v335}"
    let v345 : unit = ()
    let v346 : (unit -> unit) = closure8(v10, v342)
    let v347 : unit = (fun () -> v346 (); v345) ()
    let v351 : string = $"{v51}"
    let v354 : unit = ()
    let v355 : (unit -> unit) = closure8(v10, v351)
    let v356 : unit = (fun () -> v355 (); v354) ()
    let v360 : string = "stdin"
    let v361 : string = $"{v360}"
    let v364 : unit = ()
    let v365 : (unit -> unit) = closure8(v10, v361)
    let v366 : unit = (fun () -> v365 (); v364) ()
    let v370 : string = $"{v32}"
    let v373 : unit = ()
    let v374 : (unit -> unit) = closure8(v10, v370)
    let v375 : unit = (fun () -> v374 (); v373) ()
    (* run_target_args'
    let v382 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v383 : string = "format!(\"{:#?}\", $0)"
    let v384 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v383 
    let v385 : string = "fable_library_rust::String_::fromString($0)"
    let v386 : string = Fable.Core.RustInterop.emitRustExpr v384 v385 
    let _run_target_args'_v382 = v386 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v387 : string = "format!(\"{:#?}\", $0)"
    let v388 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v387 
    let v389 : string = "fable_library_rust::String_::fromString($0)"
    let v390 : string = Fable.Core.RustInterop.emitRustExpr v388 v389 
    let _run_target_args'_v382 = v390 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v391 : string = "format!(\"{:#?}\", $0)"
    let v392 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v391 
    let v393 : string = "fable_library_rust::String_::fromString($0)"
    let v394 : string = Fable.Core.RustInterop.emitRustExpr v392 v393 
    let _run_target_args'_v382 = v394 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v396 : string = $"%A{v6}"
    let _run_target_args'_v382 = v396 
    #endif
#if FABLE_COMPILER_PYTHON
    let v400 : string = $"%A{v6}"
    let _run_target_args'_v382 = v400 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v404 : string = $"%A{v6}"
    let _run_target_args'_v382 = v404 
    #endif
#else
    let v408 : string = $"%A{v6}"
    let _run_target_args'_v382 = v408 
    #endif
    let v411 : string = _run_target_args'_v382 
    let v418 : string = $"{v411}"
    let v421 : unit = ()
    let v422 : (unit -> unit) = closure8(v10, v418)
    let v423 : unit = (fun () -> v422 (); v421) ()
    let v427 : string = $"{v51}"
    let v430 : unit = ()
    let v431 : (unit -> unit) = closure8(v10, v427)
    let v432 : unit = (fun () -> v431 (); v430) ()
    let v436 : string = "trace"
    let v437 : string = $"{v436}"
    let v440 : unit = ()
    let v441 : (unit -> unit) = closure8(v10, v437)
    let v442 : unit = (fun () -> v441 (); v440) ()
    let v446 : string = $"{v32}"
    let v449 : unit = ()
    let v450 : (unit -> unit) = closure8(v10, v446)
    let v451 : unit = (fun () -> v450 (); v449) ()
    let v456 : string =
        if v7 then
            let v454 : string = "true"
            v454
        else
            let v455 : string = "false"
            v455
    let v458 : string = $"{v456}"
    let v461 : unit = ()
    let v462 : (unit -> unit) = closure8(v10, v458)
    let v463 : unit = (fun () -> v462 (); v461) ()
    let v467 : string = $"{v51}"
    let v470 : unit = ()
    let v471 : (unit -> unit) = closure8(v10, v467)
    let v472 : unit = (fun () -> v471 (); v470) ()
    let v476 : string = "working_directory"
    let v477 : string = $"{v476}"
    let v480 : unit = ()
    let v481 : (unit -> unit) = closure8(v10, v477)
    let v482 : unit = (fun () -> v481 (); v480) ()
    let v486 : string = $"{v32}"
    let v489 : unit = ()
    let v490 : (unit -> unit) = closure8(v10, v486)
    let v491 : unit = (fun () -> v490 (); v489) ()
    (* run_target_args'
    let v498 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v499 : string = "format!(\"{:#?}\", $0)"
    let v500 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v499 
    let v501 : string = "fable_library_rust::String_::fromString($0)"
    let v502 : string = Fable.Core.RustInterop.emitRustExpr v500 v501 
    let _run_target_args'_v498 = v502 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v503 : string = "format!(\"{:#?}\", $0)"
    let v504 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v503 
    let v505 : string = "fable_library_rust::String_::fromString($0)"
    let v506 : string = Fable.Core.RustInterop.emitRustExpr v504 v505 
    let _run_target_args'_v498 = v506 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v507 : string = "format!(\"{:#?}\", $0)"
    let v508 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v507 
    let v509 : string = "fable_library_rust::String_::fromString($0)"
    let v510 : string = Fable.Core.RustInterop.emitRustExpr v508 v509 
    let _run_target_args'_v498 = v510 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v512 : string = $"%A{v8}"
    let _run_target_args'_v498 = v512 
    #endif
#if FABLE_COMPILER_PYTHON
    let v516 : string = $"%A{v8}"
    let _run_target_args'_v498 = v516 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v520 : string = $"%A{v8}"
    let _run_target_args'_v498 = v520 
    #endif
#else
    let v524 : string = $"%A{v8}"
    let _run_target_args'_v498 = v524 
    #endif
    let v527 : string = _run_target_args'_v498 
    let v534 : string = $"{v527}"
    let v537 : unit = ()
    let v538 : (unit -> unit) = closure8(v10, v534)
    let v539 : unit = (fun () -> v538 (); v537) ()
    let v543 : string = " }"
    let v544 : string = $"{v543}"
    let v547 : unit = ()
    let v548 : (unit -> unit) = closure8(v10, v544)
    let v549 : unit = (fun () -> v548 (); v547) ()
    let v553 : string = $"{v543}"
    let v556 : unit = ()
    let v557 : (unit -> unit) = closure8(v10, v553)
    let v558 : unit = (fun () -> v557 (); v556) ()
    let v561 : string = v10.l0
    v561
and method141 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : US5, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option) : string =
    let v17 : string = method142(v8, v9, v10, v11, v12, v13, v14, v15, v16)
    let v18 : int64 = v0.l0
    let v20 : string = "runtime.execute_with_options_async"
    let v21 : string = $"{v6} {v7} #{v18} %s{v20} / {v17}"
    method18(v21)
and closure63 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : US5, v8 : string) () : unit =
    let v9 : US0 = US0_1
    let v10 : bool = method7(v9)
    if v10 then
        let v11 : unit = ()
        let v12 : (unit -> unit) = closure6()
        let v13 : unit = (fun () -> v12 (); v11) ()
        let struct (v34 : Mut0, v35 : Mut1, v36 : Mut2, v37 : Mut3, v38 : Mut4, v39 : int64 option) = TraceState.trace_state.Value
        let v52 : string = method8(v34, v35, v36, v37, v38, v39)
        let v53 : string = method66()
        let v54 : string = method141(v34, v35, v36, v37, v38, v39, v52, v53, v8, v7, v0, v1, v2, v3, v4, v5, v6)
        method19(v54)
and method143 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : (struct (string * string) []) =
    v2
and method146 (v0 : System.Diagnostics.DataReceivedEventArgs) : string =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = null |> unbox<string>
    let _run_target_args'_v5 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : string = null |> unbox<string>
    let _run_target_args'_v5 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = null |> unbox<string>
    let _run_target_args'_v5 = v15 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : string = null |> unbox<string>
    let _run_target_args'_v5 = v19 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : string = null |> unbox<string>
    let _run_target_args'_v5 = v23 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v27 : string = null |> unbox<string>
    let _run_target_args'_v5 = v27 
    #endif
#else
    let v30 : (System.Diagnostics.DataReceivedEventArgs -> string) = _.Data
    let v31 : string = v30 v0
    let _run_target_args'_v5 = v31 
    #endif
    let v32 : string = _run_target_args'_v5 
    v32
and closure65 () (v0 : (struct (int32 * string * bool) -> Async<unit>)) : US31 =
    US31_0(v0)
and method147 () : ((struct (int32 * string * bool) -> Async<unit>) -> US31) =
    closure65()
and method148 (v0 : System.Diagnostics.Process) : int32 =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : int32 = null |> unbox<int32>
    let _run_target_args'_v5 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : int32 = null |> unbox<int32>
    let _run_target_args'_v5 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : int32 = null |> unbox<int32>
    let _run_target_args'_v5 = v15 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : int32 = null |> unbox<int32>
    let _run_target_args'_v5 = v19 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : int32 = null |> unbox<int32>
    let _run_target_args'_v5 = v23 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v27 : int32 = null |> unbox<int32>
    let _run_target_args'_v5 = v27 
    #endif
#else
    let v30 : (System.Diagnostics.Process -> int32) = _.Id
    let v31 : int32 = v30 v0
    let _run_target_args'_v5 = v31 
    #endif
    let v32 : int32 = _run_target_args'_v5 
    v32
and closure66 (v0 : string) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method123()
        let v46 : bool = v0 = ""
        let v49 : string =
            if v46 then
                let v47 : string = ""
                v47
            else
                method124(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method19(v49)
and method145 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>, v9 : bool, v10 : System.Diagnostics.DataReceivedEventArgs) : Async<unit> =
    (* run_target_args'
    let v15 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v17 : Async<unit> = null |> unbox<Async<unit>>
    let _run_target_args'_v15 = v17 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v21 : Async<unit> = null |> unbox<Async<unit>>
    let _run_target_args'_v15 = v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : Async<unit> = null |> unbox<Async<unit>>
    let _run_target_args'_v15 = v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : unit = ()
    let _let'_v29 =
        async {
            let v32 : string = method146(v10)
            let v34 : string = null |> unbox<string>
            let v37 : bool = v32 = v34
            let v38 : bool = v37 <> true
            if v38 then
                let v40 : ((struct (int32 * string * bool) -> Async<unit>) -> US31) = method147()
                let v41 : US31 option = v3 |> Option.map v40 
                let v54 : US31 = US31_1
                let v55 : US31 = v41 |> Option.defaultValue v54 
                match v55 with
                | US31_1 -> (* None *)
                    ()
                | US31_0(v59) -> (* Some *)
                    let v60 : int32 = method148(v7)
                    let v61 : Async<unit> = v59 struct (v60, v32, v9)
                    do! v61 
                    ()
                let v64 : string =
                    if v9 then
                        let v62 : string = $"! {v32}"
                        v62
                    else
                        let v63 : string = $"> {v32}"
                        v63
                if v5 then
                    let v65 : unit = ()
                    let v66 : (unit -> unit) = closure66(v64)
                    let v67 : unit = (fun () -> v66 (); v65) ()
                    ()
                else
                    let v117 : unit = ()
                    let v118 : (unit -> unit) = closure11(v64)
                    let v119 : unit = (fun () -> v118 (); v117) ()
                    ()
                let v123 : string =
                    if v9 then
                        let v121 : string = "\u001b[7;4m"
                        v121
                    else
                        let v122 : string = ""
                        v122
                let v126 : string =
                    if v9 then
                        let v124 : string = "\u001b[0m"
                        v124
                    else
                        let v125 : string = ""
                        v125
                let v127 : string = $"{v123}{v32}{v126}"
                (* run_target_args'
                let v128 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v129 : (string -> unit) = v8.Push
                v129 v127
                #endif
                // run_target_args' is_unit
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v816 : Async<unit> = _let'_v29 
    let _run_target_args'_v15 = v816 
    #endif
#if FABLE_COMPILER_PYTHON
    let v818 : unit = ()
    let _let'_v818 =
        async {
            let v821 : string = method146(v10)
            let v823 : string = null |> unbox<string>
            let v826 : bool = v821 = v823
            let v827 : bool = v826 <> true
            if v827 then
                let v829 : ((struct (int32 * string * bool) -> Async<unit>) -> US31) = method147()
                let v830 : US31 option = v3 |> Option.map v829 
                let v843 : US31 = US31_1
                let v844 : US31 = v830 |> Option.defaultValue v843 
                match v844 with
                | US31_1 -> (* None *)
                    ()
                | US31_0(v848) -> (* Some *)
                    let v849 : int32 = method148(v7)
                    let v850 : Async<unit> = v848 struct (v849, v821, v9)
                    do! v850 
                    ()
                let v853 : string =
                    if v9 then
                        let v851 : string = $"! {v821}"
                        v851
                    else
                        let v852 : string = $"> {v821}"
                        v852
                if v5 then
                    let v854 : unit = ()
                    let v855 : (unit -> unit) = closure66(v853)
                    let v856 : unit = (fun () -> v855 (); v854) ()
                    ()
                else
                    let v906 : unit = ()
                    let v907 : (unit -> unit) = closure11(v853)
                    let v908 : unit = (fun () -> v907 (); v906) ()
                    ()
                let v912 : string =
                    if v9 then
                        let v910 : string = "\u001b[7;4m"
                        v910
                    else
                        let v911 : string = ""
                        v911
                let v915 : string =
                    if v9 then
                        let v913 : string = "\u001b[0m"
                        v913
                    else
                        let v914 : string = ""
                        v914
                let v916 : string = $"{v912}{v821}{v915}"
                (* run_target_args'
                let v917 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v918 : (string -> unit) = v8.Push
                v918 v916
                #endif
                // run_target_args' is_unit
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1605 : Async<unit> = _let'_v818 
    let _run_target_args'_v15 = v1605 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1607 : unit = ()
    let _let'_v1607 =
        async {
            let v1610 : string = method146(v10)
            let v1612 : string = null |> unbox<string>
            let v1615 : bool = v1610 = v1612
            let v1616 : bool = v1615 <> true
            if v1616 then
                let v1618 : ((struct (int32 * string * bool) -> Async<unit>) -> US31) = method147()
                let v1619 : US31 option = v3 |> Option.map v1618 
                let v1632 : US31 = US31_1
                let v1633 : US31 = v1619 |> Option.defaultValue v1632 
                match v1633 with
                | US31_1 -> (* None *)
                    ()
                | US31_0(v1637) -> (* Some *)
                    let v1638 : int32 = method148(v7)
                    let v1639 : Async<unit> = v1637 struct (v1638, v1610, v9)
                    do! v1639 
                    ()
                let v1642 : string =
                    if v9 then
                        let v1640 : string = $"! {v1610}"
                        v1640
                    else
                        let v1641 : string = $"> {v1610}"
                        v1641
                if v5 then
                    let v1643 : unit = ()
                    let v1644 : (unit -> unit) = closure66(v1642)
                    let v1645 : unit = (fun () -> v1644 (); v1643) ()
                    ()
                else
                    let v1695 : unit = ()
                    let v1696 : (unit -> unit) = closure11(v1642)
                    let v1697 : unit = (fun () -> v1696 (); v1695) ()
                    ()
                let v1701 : string =
                    if v9 then
                        let v1699 : string = "\u001b[7;4m"
                        v1699
                    else
                        let v1700 : string = ""
                        v1700
                let v1704 : string =
                    if v9 then
                        let v1702 : string = "\u001b[0m"
                        v1702
                    else
                        let v1703 : string = ""
                        v1703
                let v1705 : string = $"{v1701}{v1610}{v1704}"
                (* run_target_args'
                let v1706 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v1707 : (string -> unit) = v8.Push
                v1707 v1705
                #endif
                // run_target_args' is_unit
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2394 : Async<unit> = _let'_v1607 
    let _run_target_args'_v15 = v2394 
    #endif
#else
    let v2396 : unit = ()
    let _let'_v2396 =
        async {
            let v2399 : string = method146(v10)
            let v2401 : string = null |> unbox<string>
            let v2404 : bool = v2399 = v2401
            let v2405 : bool = v2404 <> true
            if v2405 then
                let v2407 : ((struct (int32 * string * bool) -> Async<unit>) -> US31) = method147()
                let v2408 : US31 option = v3 |> Option.map v2407 
                let v2421 : US31 = US31_1
                let v2422 : US31 = v2408 |> Option.defaultValue v2421 
                match v2422 with
                | US31_1 -> (* None *)
                    ()
                | US31_0(v2426) -> (* Some *)
                    let v2427 : int32 = method148(v7)
                    let v2428 : Async<unit> = v2426 struct (v2427, v2399, v9)
                    do! v2428 
                    ()
                let v2431 : string =
                    if v9 then
                        let v2429 : string = $"! {v2399}"
                        v2429
                    else
                        let v2430 : string = $"> {v2399}"
                        v2430
                if v5 then
                    let v2432 : unit = ()
                    let v2433 : (unit -> unit) = closure66(v2431)
                    let v2434 : unit = (fun () -> v2433 (); v2432) ()
                    ()
                else
                    let v2484 : unit = ()
                    let v2485 : (unit -> unit) = closure11(v2431)
                    let v2486 : unit = (fun () -> v2485 (); v2484) ()
                    ()
                let v2490 : string =
                    if v9 then
                        let v2488 : string = "\u001b[7;4m"
                        v2488
                    else
                        let v2489 : string = ""
                        v2489
                let v2493 : string =
                    if v9 then
                        let v2491 : string = "\u001b[0m"
                        v2491
                    else
                        let v2492 : string = ""
                        v2492
                let v2494 : string = $"{v2490}{v2399}{v2493}"
                (* run_target_args'
                let v2495 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v2496 : (string -> unit) = v8.Push
                v2496 v2494
                #endif
                // run_target_args' is_unit
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v3183 : Async<unit> = _let'_v2396 
    let _run_target_args'_v15 = v3183 
    #endif
    let v3184 : Async<unit> = _run_target_args'_v15 
    v3184
and method144 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>, v9 : bool, v10 : System.Diagnostics.DataReceivedEventArgs) : Async<unit> =
    method145(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
and closure64 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>, v9 : bool) (v10 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v11 : Async<unit> = method144(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
    (* run_target_args'
    let v12 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : (Async<unit> -> unit) = Async.StartImmediate
    v13 v11
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : (Async<unit> -> unit) = Async.StartImmediate
    v14 v11
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : (Async<unit> -> unit) = Async.StartImmediate
    v15 v11
    #endif
#else
    let v16 : (Async<unit> -> unit) = Async.StartImmediate
    v16 v11
    #endif
    // run_target_args' is_unit
    ()
and closure67 () (v0 : System.Threading.CancellationToken) : US32 =
    US32_0(v0)
and method149 () : (System.Threading.CancellationToken -> US32) =
    closure67()
and method150 (v0 : System.Threading.CancellationToken) : Async<System.Threading.CancellationToken> =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _run_target_args'_v5 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _run_target_args'_v5 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _run_target_args'_v5 = v15 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : unit = ()
    let _let'_v19 =
        async {
            (* run_target_args'
            let v26 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v28 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v28 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v32 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v32 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v36 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v36 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v40 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v40 
            #endif
#if FABLE_COMPILER_PYTHON
            let v44 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v44 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v48 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v48 
            #endif
#else
            let v51 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v51 = v51 
            let v52 : System.Threading.CancellationToken = v51 
            let v53 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v54 : (System.Threading.CancellationToken []) = [|v52; v53; v0|]
            let v55 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v56 : System.Threading.CancellationTokenSource = v55 v54
            let v57 : System.Threading.CancellationToken = v56.Token
            return v57 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v342 : Async<System.Threading.CancellationToken> = _let'_v19 
    let _run_target_args'_v5 = v342 
    #endif
#if FABLE_COMPILER_PYTHON
    let v344 : unit = ()
    let _let'_v344 =
        async {
            (* run_target_args'
            let v351 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v353 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v353 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v357 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v357 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v361 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v361 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v365 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v365 
            #endif
#if FABLE_COMPILER_PYTHON
            let v369 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v369 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v373 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v373 
            #endif
#else
            let v376 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v376 = v376 
            let v377 : System.Threading.CancellationToken = v376 
            let v378 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v379 : (System.Threading.CancellationToken []) = [|v377; v378; v0|]
            let v380 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v381 : System.Threading.CancellationTokenSource = v380 v379
            let v382 : System.Threading.CancellationToken = v381.Token
            return v382 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v667 : Async<System.Threading.CancellationToken> = _let'_v344 
    let _run_target_args'_v5 = v667 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v669 : unit = ()
    let _let'_v669 =
        async {
            (* run_target_args'
            let v676 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v678 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v678 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v682 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v682 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v686 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v686 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v690 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v690 
            #endif
#if FABLE_COMPILER_PYTHON
            let v694 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v694 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v698 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v698 
            #endif
#else
            let v701 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v701 = v701 
            let v702 : System.Threading.CancellationToken = v701 
            let v703 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v704 : (System.Threading.CancellationToken []) = [|v702; v703; v0|]
            let v705 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v706 : System.Threading.CancellationTokenSource = v705 v704
            let v707 : System.Threading.CancellationToken = v706.Token
            return v707 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v992 : Async<System.Threading.CancellationToken> = _let'_v669 
    let _run_target_args'_v5 = v992 
    #endif
#else
    let v994 : unit = ()
    let _let'_v994 =
        async {
            (* run_target_args'
            let v1001 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1003 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1003 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1007 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1007 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1011 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1011 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1015 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1015 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1019 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1019 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1023 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1023 
            #endif
#else
            let v1026 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v1026 = v1026 
            let v1027 : System.Threading.CancellationToken = v1026 
            let v1028 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v1029 : (System.Threading.CancellationToken []) = [|v1027; v1028; v0|]
            let v1030 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v1031 : System.Threading.CancellationTokenSource = v1030 v1029
            let v1032 : System.Threading.CancellationToken = v1031.Token
            return v1032 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1317 : Async<System.Threading.CancellationToken> = _let'_v994 
    let _run_target_args'_v5 = v1317 
    #endif
    let v1318 : Async<System.Threading.CancellationToken> = _run_target_args'_v5 
    v1318
and method151 (v0 : System.Diagnostics.Process) : bool =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v15 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v19 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v23 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v27 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v27 
    #endif
#else
    let v30 : (System.Diagnostics.Process -> bool) = _.HasExited
    let v31 : bool = v30 v0
    let _run_target_args'_v5 = v31 
    #endif
    let v32 : bool = _run_target_args'_v5 
    v32
and method152 (v0 : System.Diagnostics.Process) : unit =
    (* run_target_args'
    let v1 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    #endif
#if FABLE_COMPILER_RUST && WASM
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    #endif
#if FABLE_COMPILER_PYTHON
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    #endif
#else
    let v2 : (System.Diagnostics.Process -> unit) = _.Kill()
    v2 v0
    #endif
    // run_target_args' is_unit
    ()
and closure68 (v0 : System.Diagnostics.Process) () : unit =
    let v1 : bool = method151(v0)
    let v2 : bool = v1 = false
    if v2 then
        method152(v0)
and method155 (v0 : System.Threading.Tasks.TaskCanceledException) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v2, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v14 : string = "ex"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure8(v2, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure8(v2, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    (* run_target_args'
    let v37 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : string = "format!(\"{:#?}\", $0)"
    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v38 
    let v40 : string = "fable_library_rust::String_::fromString($0)"
    let v41 : string = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let _run_target_args'_v37 = v41 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v42 : string = "format!(\"{:#?}\", $0)"
    let v43 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v42 
    let v44 : string = "fable_library_rust::String_::fromString($0)"
    let v45 : string = Fable.Core.RustInterop.emitRustExpr v43 v44 
    let _run_target_args'_v37 = v45 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v46 : string = "format!(\"{:#?}\", $0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v46 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let _run_target_args'_v37 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v51 : string = $"%A{v0}"
    let _run_target_args'_v37 = v51 
    #endif
#if FABLE_COMPILER_PYTHON
    let v55 : string = $"%A{v0}"
    let _run_target_args'_v37 = v55 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v59 : string = $"%A{v0}"
    let _run_target_args'_v37 = v59 
    #endif
#else
    let v63 : string = $"%A{v0}"
    let _run_target_args'_v37 = v63 
    #endif
    let v66 : string = _run_target_args'_v37 
    let v73 : string = $"{v66}"
    let v76 : unit = ()
    let v77 : (unit -> unit) = closure8(v2, v73)
    let v78 : unit = (fun () -> v77 (); v76) ()
    let v82 : string = " }"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v2, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = v2.l0
    v91
and method154 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : System.Threading.Tasks.TaskCanceledException) : string =
    let v9 : string = method155(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "runtime.execute_with_options_async / WaitForExitAsync"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method18(v13)
and closure69 (v0 : System.Threading.Tasks.TaskCanceledException) () : unit =
    let v1 : US0 = US0_3
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method35()
        let v46 : string = method154(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method19(v46)
and method153 (v0 : System.Diagnostics.Process, v1 : System.Collections.Concurrent.ConcurrentStack<string>, v2 : System.Threading.CancellationToken) : Async<int32> =
    (* run_target_args'
    let v7 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : Async<int32> = null |> unbox<Async<int32>>
    let _run_target_args'_v7 = v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : Async<int32> = null |> unbox<Async<int32>>
    let _run_target_args'_v7 = v13 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v17 : Async<int32> = null |> unbox<Async<int32>>
    let _run_target_args'_v7 = v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v21 : unit = ()
    let _let'_v21 =
        async {
            try
                (* run_target_args'
                let v28 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v30 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v28 = v30 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v34 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v28 = v34 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v38 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v28 = v38 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v42 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v28 = v42 
                #endif
#if FABLE_COMPILER_PYTHON
                let v46 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v28 = v46 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v50 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v28 = v50 
                #endif
#else
                let v53 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _run_target_args'_v28 = v53 
                #endif
                let v54 : System.Threading.Tasks.Task = _run_target_args'_v28 
                (* run_target_args'
                let v64 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v66 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v64 = v66 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v70 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v64 = v70 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v74 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v64 = v74 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v77 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v78 : Async<unit> = v77 v54
                let _run_target_args'_v64 = v78 
                #endif
#if FABLE_COMPILER_PYTHON
                let v79 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v80 : Async<unit> = v79 v54
                let _run_target_args'_v64 = v80 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v81 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v82 : Async<unit> = v81 v54
                let _run_target_args'_v64 = v82 
                #endif
#else
                let v83 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v84 : Async<unit> = v83 v54
                let _run_target_args'_v64 = v84 
                #endif
                let v85 : Async<unit> = _run_target_args'_v64 
                do! v85 
                (* run_target_args'
                let v95 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v97 : int32 = null |> unbox<int32>
                let _run_target_args'_v95 = v97 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v101 : int32 = null |> unbox<int32>
                let _run_target_args'_v95 = v101 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v105 : int32 = null |> unbox<int32>
                let _run_target_args'_v95 = v105 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v109 : int32 = null |> unbox<int32>
                let _run_target_args'_v95 = v109 
                #endif
#if FABLE_COMPILER_PYTHON
                let v113 : int32 = null |> unbox<int32>
                let _run_target_args'_v95 = v113 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v117 : int32 = null |> unbox<int32>
                let _run_target_args'_v95 = v117 
                #endif
#else
                let v120 : int32 = v0.ExitCode
                let _run_target_args'_v95 = v120 
                #endif
                let v121 : int32 = _run_target_args'_v95 
                return v121 
                (* indent
                ()
            indent *)
            with ex ->
                let v230 : exn = ex
                (* run_target_args'
                let v235 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v237 : string = $"%A{v230}"
                let _run_target_args'_v235 = v237 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v241 : string = $"%A{v230}"
                let _run_target_args'_v235 = v241 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v245 : string = $"%A{v230}"
                let _run_target_args'_v235 = v245 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v249 : string = $"%A{v230}"
                let _run_target_args'_v235 = v249 
                #endif
#if FABLE_COMPILER_PYTHON
                let v253 : string = $"%A{v230}"
                let _run_target_args'_v235 = v253 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v257 : string = $"%A{v230}"
                let _run_target_args'_v235 = v257 
                #endif
#else
                let v260 : string = $"{v230.GetType ()}: {v230.Message}"
                let _run_target_args'_v235 = v260 
                #endif
                let v261 : string = _run_target_args'_v235 
                (* run_target_args'
                let v267 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v268 : (string -> unit) = v1.Push
                v268 v261
                #endif
                // run_target_args' is_unit
                let v270 : System.Threading.Tasks.TaskCanceledException = v230 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v273 : unit = ()
                let v274 : (unit -> unit) = closure69(v270)
                let v275 : unit = (fun () -> v274 (); v273) ()
                return -2147483648 
                (* indent
                ()
            indent *)
            (* try_unit
            try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v3144 : Async<int32> = _let'_v21 
    let _run_target_args'_v7 = v3144 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3146 : unit = ()
    let _let'_v3146 =
        async {
            try
                (* run_target_args'
                let v3153 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3155 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v3153 = v3155 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v3159 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v3153 = v3159 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v3163 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v3153 = v3163 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v3167 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v3153 = v3167 
                #endif
#if FABLE_COMPILER_PYTHON
                let v3171 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v3153 = v3171 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v3175 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v3153 = v3175 
                #endif
#else
                let v3178 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _run_target_args'_v3153 = v3178 
                #endif
                let v3179 : System.Threading.Tasks.Task = _run_target_args'_v3153 
                (* run_target_args'
                let v3189 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3191 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v3189 = v3191 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v3195 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v3189 = v3195 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v3199 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v3189 = v3199 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v3202 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v3203 : Async<unit> = v3202 v3179
                let _run_target_args'_v3189 = v3203 
                #endif
#if FABLE_COMPILER_PYTHON
                let v3204 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v3205 : Async<unit> = v3204 v3179
                let _run_target_args'_v3189 = v3205 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v3206 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v3207 : Async<unit> = v3206 v3179
                let _run_target_args'_v3189 = v3207 
                #endif
#else
                let v3208 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v3209 : Async<unit> = v3208 v3179
                let _run_target_args'_v3189 = v3209 
                #endif
                let v3210 : Async<unit> = _run_target_args'_v3189 
                do! v3210 
                (* run_target_args'
                let v3220 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3222 : int32 = null |> unbox<int32>
                let _run_target_args'_v3220 = v3222 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v3226 : int32 = null |> unbox<int32>
                let _run_target_args'_v3220 = v3226 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v3230 : int32 = null |> unbox<int32>
                let _run_target_args'_v3220 = v3230 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v3234 : int32 = null |> unbox<int32>
                let _run_target_args'_v3220 = v3234 
                #endif
#if FABLE_COMPILER_PYTHON
                let v3238 : int32 = null |> unbox<int32>
                let _run_target_args'_v3220 = v3238 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v3242 : int32 = null |> unbox<int32>
                let _run_target_args'_v3220 = v3242 
                #endif
#else
                let v3245 : int32 = v0.ExitCode
                let _run_target_args'_v3220 = v3245 
                #endif
                let v3246 : int32 = _run_target_args'_v3220 
                return v3246 
                (* indent
                ()
            indent *)
            with ex ->
                let v3355 : exn = ex
                (* run_target_args'
                let v3360 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3362 : string = $"%A{v3355}"
                let _run_target_args'_v3360 = v3362 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v3366 : string = $"%A{v3355}"
                let _run_target_args'_v3360 = v3366 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v3370 : string = $"%A{v3355}"
                let _run_target_args'_v3360 = v3370 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v3374 : string = $"%A{v3355}"
                let _run_target_args'_v3360 = v3374 
                #endif
#if FABLE_COMPILER_PYTHON
                let v3378 : string = $"%A{v3355}"
                let _run_target_args'_v3360 = v3378 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v3382 : string = $"%A{v3355}"
                let _run_target_args'_v3360 = v3382 
                #endif
#else
                let v3385 : string = $"{v3355.GetType ()}: {v3355.Message}"
                let _run_target_args'_v3360 = v3385 
                #endif
                let v3386 : string = _run_target_args'_v3360 
                (* run_target_args'
                let v3392 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v3393 : (string -> unit) = v1.Push
                v3393 v3386
                #endif
                // run_target_args' is_unit
                let v3395 : System.Threading.Tasks.TaskCanceledException = v3355 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v3398 : unit = ()
                let v3399 : (unit -> unit) = closure69(v3395)
                let v3400 : unit = (fun () -> v3399 (); v3398) ()
                return -2147483648 
                (* indent
                ()
            indent *)
            (* try_unit
            try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v6269 : Async<int32> = _let'_v3146 
    let _run_target_args'_v7 = v6269 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v6271 : unit = ()
    let _let'_v6271 =
        async {
            try
                (* run_target_args'
                let v6278 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v6280 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v6278 = v6280 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v6284 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v6278 = v6284 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v6288 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v6278 = v6288 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v6292 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v6278 = v6292 
                #endif
#if FABLE_COMPILER_PYTHON
                let v6296 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v6278 = v6296 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v6300 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v6278 = v6300 
                #endif
#else
                let v6303 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _run_target_args'_v6278 = v6303 
                #endif
                let v6304 : System.Threading.Tasks.Task = _run_target_args'_v6278 
                (* run_target_args'
                let v6314 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v6316 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v6314 = v6316 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v6320 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v6314 = v6320 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v6324 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v6314 = v6324 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v6327 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v6328 : Async<unit> = v6327 v6304
                let _run_target_args'_v6314 = v6328 
                #endif
#if FABLE_COMPILER_PYTHON
                let v6329 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v6330 : Async<unit> = v6329 v6304
                let _run_target_args'_v6314 = v6330 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v6331 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v6332 : Async<unit> = v6331 v6304
                let _run_target_args'_v6314 = v6332 
                #endif
#else
                let v6333 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v6334 : Async<unit> = v6333 v6304
                let _run_target_args'_v6314 = v6334 
                #endif
                let v6335 : Async<unit> = _run_target_args'_v6314 
                do! v6335 
                (* run_target_args'
                let v6345 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v6347 : int32 = null |> unbox<int32>
                let _run_target_args'_v6345 = v6347 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v6351 : int32 = null |> unbox<int32>
                let _run_target_args'_v6345 = v6351 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v6355 : int32 = null |> unbox<int32>
                let _run_target_args'_v6345 = v6355 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v6359 : int32 = null |> unbox<int32>
                let _run_target_args'_v6345 = v6359 
                #endif
#if FABLE_COMPILER_PYTHON
                let v6363 : int32 = null |> unbox<int32>
                let _run_target_args'_v6345 = v6363 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v6367 : int32 = null |> unbox<int32>
                let _run_target_args'_v6345 = v6367 
                #endif
#else
                let v6370 : int32 = v0.ExitCode
                let _run_target_args'_v6345 = v6370 
                #endif
                let v6371 : int32 = _run_target_args'_v6345 
                return v6371 
                (* indent
                ()
            indent *)
            with ex ->
                let v6480 : exn = ex
                (* run_target_args'
                let v6485 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v6487 : string = $"%A{v6480}"
                let _run_target_args'_v6485 = v6487 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v6491 : string = $"%A{v6480}"
                let _run_target_args'_v6485 = v6491 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v6495 : string = $"%A{v6480}"
                let _run_target_args'_v6485 = v6495 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v6499 : string = $"%A{v6480}"
                let _run_target_args'_v6485 = v6499 
                #endif
#if FABLE_COMPILER_PYTHON
                let v6503 : string = $"%A{v6480}"
                let _run_target_args'_v6485 = v6503 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v6507 : string = $"%A{v6480}"
                let _run_target_args'_v6485 = v6507 
                #endif
#else
                let v6510 : string = $"{v6480.GetType ()}: {v6480.Message}"
                let _run_target_args'_v6485 = v6510 
                #endif
                let v6511 : string = _run_target_args'_v6485 
                (* run_target_args'
                let v6517 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v6518 : (string -> unit) = v1.Push
                v6518 v6511
                #endif
                // run_target_args' is_unit
                let v6520 : System.Threading.Tasks.TaskCanceledException = v6480 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v6523 : unit = ()
                let v6524 : (unit -> unit) = closure69(v6520)
                let v6525 : unit = (fun () -> v6524 (); v6523) ()
                return -2147483648 
                (* indent
                ()
            indent *)
            (* try_unit
            try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v9394 : Async<int32> = _let'_v6271 
    let _run_target_args'_v7 = v9394 
    #endif
#else
    let v9396 : unit = ()
    let _let'_v9396 =
        async {
            try
                (* run_target_args'
                let v9403 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v9405 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v9403 = v9405 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v9409 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v9403 = v9409 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v9413 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v9403 = v9413 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v9417 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v9403 = v9417 
                #endif
#if FABLE_COMPILER_PYTHON
                let v9421 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v9403 = v9421 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v9425 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v9403 = v9425 
                #endif
#else
                let v9428 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _run_target_args'_v9403 = v9428 
                #endif
                let v9429 : System.Threading.Tasks.Task = _run_target_args'_v9403 
                (* run_target_args'
                let v9439 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v9441 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v9439 = v9441 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v9445 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v9439 = v9445 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v9449 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v9439 = v9449 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v9452 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v9453 : Async<unit> = v9452 v9429
                let _run_target_args'_v9439 = v9453 
                #endif
#if FABLE_COMPILER_PYTHON
                let v9454 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v9455 : Async<unit> = v9454 v9429
                let _run_target_args'_v9439 = v9455 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v9456 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v9457 : Async<unit> = v9456 v9429
                let _run_target_args'_v9439 = v9457 
                #endif
#else
                let v9458 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v9459 : Async<unit> = v9458 v9429
                let _run_target_args'_v9439 = v9459 
                #endif
                let v9460 : Async<unit> = _run_target_args'_v9439 
                do! v9460 
                (* run_target_args'
                let v9470 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v9472 : int32 = null |> unbox<int32>
                let _run_target_args'_v9470 = v9472 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v9476 : int32 = null |> unbox<int32>
                let _run_target_args'_v9470 = v9476 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v9480 : int32 = null |> unbox<int32>
                let _run_target_args'_v9470 = v9480 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v9484 : int32 = null |> unbox<int32>
                let _run_target_args'_v9470 = v9484 
                #endif
#if FABLE_COMPILER_PYTHON
                let v9488 : int32 = null |> unbox<int32>
                let _run_target_args'_v9470 = v9488 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v9492 : int32 = null |> unbox<int32>
                let _run_target_args'_v9470 = v9492 
                #endif
#else
                let v9495 : int32 = v0.ExitCode
                let _run_target_args'_v9470 = v9495 
                #endif
                let v9496 : int32 = _run_target_args'_v9470 
                return v9496 
                (* indent
                ()
            indent *)
            with ex ->
                let v9605 : exn = ex
                (* run_target_args'
                let v9610 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v9612 : string = $"%A{v9605}"
                let _run_target_args'_v9610 = v9612 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v9616 : string = $"%A{v9605}"
                let _run_target_args'_v9610 = v9616 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v9620 : string = $"%A{v9605}"
                let _run_target_args'_v9610 = v9620 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v9624 : string = $"%A{v9605}"
                let _run_target_args'_v9610 = v9624 
                #endif
#if FABLE_COMPILER_PYTHON
                let v9628 : string = $"%A{v9605}"
                let _run_target_args'_v9610 = v9628 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v9632 : string = $"%A{v9605}"
                let _run_target_args'_v9610 = v9632 
                #endif
#else
                let v9635 : string = $"{v9605.GetType ()}: {v9605.Message}"
                let _run_target_args'_v9610 = v9635 
                #endif
                let v9636 : string = _run_target_args'_v9610 
                (* run_target_args'
                let v9642 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v9643 : (string -> unit) = v1.Push
                v9643 v9636
                #endif
                // run_target_args' is_unit
                let v9645 : System.Threading.Tasks.TaskCanceledException = v9605 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v9648 : unit = ()
                let v9649 : (unit -> unit) = closure69(v9645)
                let v9650 : unit = (fun () -> v9649 (); v9648) ()
                return -2147483648 
                (* indent
                ()
            indent *)
            (* try_unit
            try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v12519 : Async<int32> = _let'_v9396 
    let _run_target_args'_v7 = v12519 
    #endif
    let v12520 : Async<int32> = _run_target_args'_v7 
    v12520
and method157 (v0 : int32, v1 : int32, v2 : string, v3 : System.Threading.CancellationToken option, v4 : (struct (string * string) []), v5 : (struct (int32 * string * bool) -> Async<unit>) option, v6 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v7 : bool, v8 : string option) : string =
    let v9 : string = method14()
    let v10 : Mut3 = {l0 = v9} : Mut3
    let v12 : string = "{ "
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure8(v10, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v22 : string = "exit_code"
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure8(v10, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v32 : string = " = "
    let v33 : string = $"{v32}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure8(v10, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v42 : string = $"{v0}"
    let v45 : unit = ()
    let v46 : (unit -> unit) = closure8(v10, v42)
    let v47 : unit = (fun () -> v46 (); v45) ()
    let v51 : string = "; "
    let v52 : string = $"{v51}"
    let v55 : unit = ()
    let v56 : (unit -> unit) = closure8(v10, v52)
    let v57 : unit = (fun () -> v56 (); v55) ()
    let v61 : string = "output_length"
    let v62 : string = $"{v61}"
    let v65 : unit = ()
    let v66 : (unit -> unit) = closure8(v10, v62)
    let v67 : unit = (fun () -> v66 (); v65) ()
    let v71 : string = $"{v32}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure8(v10, v71)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v80 : string = $"{v1}"
    let v83 : unit = ()
    let v84 : (unit -> unit) = closure8(v10, v80)
    let v85 : unit = (fun () -> v84 (); v83) ()
    let v89 : string = $"{v51}"
    let v92 : unit = ()
    let v93 : (unit -> unit) = closure8(v10, v89)
    let v94 : unit = (fun () -> v93 (); v92) ()
    let v98 : string = "options"
    let v99 : string = $"{v98}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure8(v10, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v108 : string = $"{v32}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure8(v10, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v117 : string = $"{v12}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure8(v10, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v126 : string = "command"
    let v127 : string = $"{v126}"
    let v130 : unit = ()
    let v131 : (unit -> unit) = closure8(v10, v127)
    let v132 : unit = (fun () -> v131 (); v130) ()
    let v136 : string = $"{v32}"
    let v139 : unit = ()
    let v140 : (unit -> unit) = closure8(v10, v136)
    let v141 : unit = (fun () -> v140 (); v139) ()
    let v145 : string = $"{v2}"
    let v148 : unit = ()
    let v149 : (unit -> unit) = closure8(v10, v145)
    let v150 : unit = (fun () -> v149 (); v148) ()
    let v154 : string = $"{v51}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure8(v10, v154)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v163 : string = "cancellation_token"
    let v164 : string = $"{v163}"
    let v167 : unit = ()
    let v168 : (unit -> unit) = closure8(v10, v164)
    let v169 : unit = (fun () -> v168 (); v167) ()
    let v173 : string = $"{v32}"
    let v176 : unit = ()
    let v177 : (unit -> unit) = closure8(v10, v173)
    let v178 : unit = (fun () -> v177 (); v176) ()
    (* run_target_args'
    let v185 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v186 : string = "format!(\"{:#?}\", $0)"
    let v187 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v186 
    let v188 : string = "fable_library_rust::String_::fromString($0)"
    let v189 : string = Fable.Core.RustInterop.emitRustExpr v187 v188 
    let _run_target_args'_v185 = v189 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v190 : string = "format!(\"{:#?}\", $0)"
    let v191 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v190 
    let v192 : string = "fable_library_rust::String_::fromString($0)"
    let v193 : string = Fable.Core.RustInterop.emitRustExpr v191 v192 
    let _run_target_args'_v185 = v193 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v194 : string = "format!(\"{:#?}\", $0)"
    let v195 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v194 
    let v196 : string = "fable_library_rust::String_::fromString($0)"
    let v197 : string = Fable.Core.RustInterop.emitRustExpr v195 v196 
    let _run_target_args'_v185 = v197 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v199 : string = $"%A{v3}"
    let _run_target_args'_v185 = v199 
    #endif
#if FABLE_COMPILER_PYTHON
    let v203 : string = $"%A{v3}"
    let _run_target_args'_v185 = v203 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v207 : string = $"%A{v3}"
    let _run_target_args'_v185 = v207 
    #endif
#else
    let v211 : string = $"%A{v3}"
    let _run_target_args'_v185 = v211 
    #endif
    let v214 : string = _run_target_args'_v185 
    let v221 : string = $"{v214}"
    let v224 : unit = ()
    let v225 : (unit -> unit) = closure8(v10, v221)
    let v226 : unit = (fun () -> v225 (); v224) ()
    let v230 : string = $"{v51}"
    let v233 : unit = ()
    let v234 : (unit -> unit) = closure8(v10, v230)
    let v235 : unit = (fun () -> v234 (); v233) ()
    let v239 : string = "environment_variables"
    let v240 : string = $"{v239}"
    let v243 : unit = ()
    let v244 : (unit -> unit) = closure8(v10, v240)
    let v245 : unit = (fun () -> v244 (); v243) ()
    let v249 : string = $"{v32}"
    let v252 : unit = ()
    let v253 : (unit -> unit) = closure8(v10, v249)
    let v254 : unit = (fun () -> v253 (); v252) ()
    let v258 : string = $"%A{v4}"
    let v262 : string = $"{v258}"
    let v265 : unit = ()
    let v266 : (unit -> unit) = closure8(v10, v262)
    let v267 : unit = (fun () -> v266 (); v265) ()
    let v271 : string = $"{v51}"
    let v274 : unit = ()
    let v275 : (unit -> unit) = closure8(v10, v271)
    let v276 : unit = (fun () -> v275 (); v274) ()
    let v280 : string = "on_line"
    let v281 : string = $"{v280}"
    let v284 : unit = ()
    let v285 : (unit -> unit) = closure8(v10, v281)
    let v286 : unit = (fun () -> v285 (); v284) ()
    let v290 : string = $"{v32}"
    let v293 : unit = ()
    let v294 : (unit -> unit) = closure8(v10, v290)
    let v295 : unit = (fun () -> v294 (); v293) ()
    (* run_target_args'
    let v302 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v303 : string = "format!(\"{:#?}\", $0)"
    let v304 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v303 
    let v305 : string = "fable_library_rust::String_::fromString($0)"
    let v306 : string = Fable.Core.RustInterop.emitRustExpr v304 v305 
    let _run_target_args'_v302 = v306 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v307 : string = "format!(\"{:#?}\", $0)"
    let v308 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v307 
    let v309 : string = "fable_library_rust::String_::fromString($0)"
    let v310 : string = Fable.Core.RustInterop.emitRustExpr v308 v309 
    let _run_target_args'_v302 = v310 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v311 : string = "format!(\"{:#?}\", $0)"
    let v312 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v311 
    let v313 : string = "fable_library_rust::String_::fromString($0)"
    let v314 : string = Fable.Core.RustInterop.emitRustExpr v312 v313 
    let _run_target_args'_v302 = v314 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v316 : string = $"%A{v5}"
    let _run_target_args'_v302 = v316 
    #endif
#if FABLE_COMPILER_PYTHON
    let v320 : string = $"%A{v5}"
    let _run_target_args'_v302 = v320 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v324 : string = $"%A{v5}"
    let _run_target_args'_v302 = v324 
    #endif
#else
    let v328 : string = $"%A{v5}"
    let _run_target_args'_v302 = v328 
    #endif
    let v331 : string = _run_target_args'_v302 
    let v338 : string = $"{v331}"
    let v341 : unit = ()
    let v342 : (unit -> unit) = closure8(v10, v338)
    let v343 : unit = (fun () -> v342 (); v341) ()
    let v347 : string = $"{v51}"
    let v350 : unit = ()
    let v351 : (unit -> unit) = closure8(v10, v347)
    let v352 : unit = (fun () -> v351 (); v350) ()
    let v356 : string = "stdin"
    let v357 : string = $"{v356}"
    let v360 : unit = ()
    let v361 : (unit -> unit) = closure8(v10, v357)
    let v362 : unit = (fun () -> v361 (); v360) ()
    let v366 : string = $"{v32}"
    let v369 : unit = ()
    let v370 : (unit -> unit) = closure8(v10, v366)
    let v371 : unit = (fun () -> v370 (); v369) ()
    (* run_target_args'
    let v378 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v379 : string = "format!(\"{:#?}\", $0)"
    let v380 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v379 
    let v381 : string = "fable_library_rust::String_::fromString($0)"
    let v382 : string = Fable.Core.RustInterop.emitRustExpr v380 v381 
    let _run_target_args'_v378 = v382 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v383 : string = "format!(\"{:#?}\", $0)"
    let v384 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v383 
    let v385 : string = "fable_library_rust::String_::fromString($0)"
    let v386 : string = Fable.Core.RustInterop.emitRustExpr v384 v385 
    let _run_target_args'_v378 = v386 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v387 : string = "format!(\"{:#?}\", $0)"
    let v388 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v387 
    let v389 : string = "fable_library_rust::String_::fromString($0)"
    let v390 : string = Fable.Core.RustInterop.emitRustExpr v388 v389 
    let _run_target_args'_v378 = v390 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v392 : string = $"%A{v6}"
    let _run_target_args'_v378 = v392 
    #endif
#if FABLE_COMPILER_PYTHON
    let v396 : string = $"%A{v6}"
    let _run_target_args'_v378 = v396 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v400 : string = $"%A{v6}"
    let _run_target_args'_v378 = v400 
    #endif
#else
    let v404 : string = $"%A{v6}"
    let _run_target_args'_v378 = v404 
    #endif
    let v407 : string = _run_target_args'_v378 
    let v414 : string = $"{v407}"
    let v417 : unit = ()
    let v418 : (unit -> unit) = closure8(v10, v414)
    let v419 : unit = (fun () -> v418 (); v417) ()
    let v423 : string = $"{v51}"
    let v426 : unit = ()
    let v427 : (unit -> unit) = closure8(v10, v423)
    let v428 : unit = (fun () -> v427 (); v426) ()
    let v432 : string = "trace"
    let v433 : string = $"{v432}"
    let v436 : unit = ()
    let v437 : (unit -> unit) = closure8(v10, v433)
    let v438 : unit = (fun () -> v437 (); v436) ()
    let v442 : string = $"{v32}"
    let v445 : unit = ()
    let v446 : (unit -> unit) = closure8(v10, v442)
    let v447 : unit = (fun () -> v446 (); v445) ()
    let v452 : string =
        if v7 then
            let v450 : string = "true"
            v450
        else
            let v451 : string = "false"
            v451
    let v454 : string = $"{v452}"
    let v457 : unit = ()
    let v458 : (unit -> unit) = closure8(v10, v454)
    let v459 : unit = (fun () -> v458 (); v457) ()
    let v463 : string = $"{v51}"
    let v466 : unit = ()
    let v467 : (unit -> unit) = closure8(v10, v463)
    let v468 : unit = (fun () -> v467 (); v466) ()
    let v472 : string = "working_directory"
    let v473 : string = $"{v472}"
    let v476 : unit = ()
    let v477 : (unit -> unit) = closure8(v10, v473)
    let v478 : unit = (fun () -> v477 (); v476) ()
    let v482 : string = $"{v32}"
    let v485 : unit = ()
    let v486 : (unit -> unit) = closure8(v10, v482)
    let v487 : unit = (fun () -> v486 (); v485) ()
    (* run_target_args'
    let v494 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v495 : string = "format!(\"{:#?}\", $0)"
    let v496 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v495 
    let v497 : string = "fable_library_rust::String_::fromString($0)"
    let v498 : string = Fable.Core.RustInterop.emitRustExpr v496 v497 
    let _run_target_args'_v494 = v498 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v499 : string = "format!(\"{:#?}\", $0)"
    let v500 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v499 
    let v501 : string = "fable_library_rust::String_::fromString($0)"
    let v502 : string = Fable.Core.RustInterop.emitRustExpr v500 v501 
    let _run_target_args'_v494 = v502 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v503 : string = "format!(\"{:#?}\", $0)"
    let v504 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v503 
    let v505 : string = "fable_library_rust::String_::fromString($0)"
    let v506 : string = Fable.Core.RustInterop.emitRustExpr v504 v505 
    let _run_target_args'_v494 = v506 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v508 : string = $"%A{v8}"
    let _run_target_args'_v494 = v508 
    #endif
#if FABLE_COMPILER_PYTHON
    let v512 : string = $"%A{v8}"
    let _run_target_args'_v494 = v512 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v516 : string = $"%A{v8}"
    let _run_target_args'_v494 = v516 
    #endif
#else
    let v520 : string = $"%A{v8}"
    let _run_target_args'_v494 = v520 
    #endif
    let v523 : string = _run_target_args'_v494 
    let v530 : string = $"{v523}"
    let v533 : unit = ()
    let v534 : (unit -> unit) = closure8(v10, v530)
    let v535 : unit = (fun () -> v534 (); v533) ()
    let v539 : string = " }"
    let v540 : string = $"{v539}"
    let v543 : unit = ()
    let v544 : (unit -> unit) = closure8(v10, v540)
    let v545 : unit = (fun () -> v544 (); v543) ()
    let v549 : string = $"{v539}"
    let v552 : unit = ()
    let v553 : (unit -> unit) = closure8(v10, v549)
    let v554 : unit = (fun () -> v553 (); v552) ()
    let v557 : string = v10.l0
    v557
and method156 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option) : string =
    let v17 : string = method157(v8, v9, v10, v11, v12, v13, v14, v15, v16)
    let v18 : int64 = v0.l0
    let v20 : string = "runtime.execute_with_options_async"
    let v21 : string = $"{v6} {v7} #{v18} %s{v20} / {v17}"
    method18(v21)
and closure70 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : int32, v8 : string) () : unit =
    let v9 : US0 = US0_1
    let v10 : bool = method7(v9)
    if v10 then
        let v11 : unit = ()
        let v12 : (unit -> unit) = closure6()
        let v13 : unit = (fun () -> v12 (); v11) ()
        let struct (v34 : Mut0, v35 : Mut1, v36 : Mut2, v37 : Mut3, v38 : Mut4, v39 : int64 option) = TraceState.trace_state.Value
        let v52 : string = method8(v34, v35, v36, v37, v38, v39)
        let v53 : string = method66()
        let v54 : int32 = v8.Length
        let v55 : string = method156(v34, v35, v36, v37, v38, v39, v52, v53, v7, v54, v0, v1, v2, v3, v4, v5, v6)
        method19(v55)
and method140 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    (* run_target_args'
    let v11 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _run_target_args'_v11 = v13 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _run_target_args'_v11 = v17 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v21 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _run_target_args'_v11 = v21 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v25 : unit = ()
    let _let'_v25 =
        async {
            (* run_target_args'
            let v36 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v39 : int32, v40 : string) = null |> unbox<struct (int32 * string)>
            return struct (v39, v40) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v47 : int32, v48 : string) = null |> unbox<struct (int32 * string)>
            return struct (v47, v48) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v55 : int32, v56 : string) = null |> unbox<struct (int32 * string)>
            return struct (v55, v56) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v63 : int32, v64 : string) = null |> unbox<struct (int32 * string)>
            return struct (v63, v64) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v71 : int32, v72 : string) = null |> unbox<struct (int32 * string)>
            return struct (v71, v72) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v79 : int32, v80 : string) = null |> unbox<struct (int32 * string)>
            return struct (v79, v80) 
            #endif
#else
            let v85 : US14 = method85(v0)
            let struct (v97 : string, v98 : US5) =
                match v85 with
                | US14_1(v88) -> (* Error *)
                    let v90 : string = $"resultm.get / Result value was Error: {v88}"
                    failwith<struct (string * US5)> v90
                | US14_0(v86, v87) -> (* Ok *)
                    struct (v86, v87)
            let v100 : (string -> US5) = method6()
            let v101 : US5 option = v6 |> Option.map v100 
            let v114 : US5 = US5_1
            let v115 : US5 = v101 |> Option.defaultValue v114 
            let v122 : string =
                match v115 with
                | US5_1 -> (* None *)
                    let v120 : string = ""
                    v120
                | US5_0(v119) -> (* Some *)
                    v119
            let v123 : unit = ()
            let v124 : (unit -> unit) = closure63(v0, v1, v2, v3, v4, v5, v6, v98, v97)
            let v125 : unit = (fun () -> v124 (); v123) ()
            let v172 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v176 : string =
                match v98 with
                | US5_1 -> (* None *)
                    let v174 : string = ""
                    v174
                | US5_0(v173) -> (* Some *)
                    v173
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v176,
              StandardOutputEncoding = v172,
              WorkingDirectory = v122,
              FileName = v97,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v177 : System.Diagnostics.ProcessStartInfo = start_info
            let v178 : (struct (string * string) []) = method143(v0, v1, v2, v3, v4, v5, v6)
            let v179 : int32 = v178.Length
            let v180 : Mut6 = {l0 = 0} : Mut6
            while method63(v179, v180) do
                let v182 : int32 = v180.l0
                let struct (v183 : string, v184 : string) = v178.[int v182]
                v177.EnvironmentVariables.[v183] <- v184 
                let v185 : int32 = v182 + 1
                v180.l0 <- v185
                ()
            let v186 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v177)
            use v186 = v186 
            let v187 : System.Diagnostics.Process = v186 
            let v188 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v189 : System.Collections.Concurrent.ConcurrentStack<string> = v188 ()
            let v190 : bool = false
            let v191 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure64(v0, v1, v2, v3, v4, v5, v6, v187, v189, v190)
            v187.OutputDataReceived.Add v191 
            let v192 : bool = true
            let v193 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure64(v0, v1, v2, v3, v4, v5, v6, v187, v189, v192)
            v187.ErrorDataReceived.Add v193 
            let v194 : (unit -> bool) = v187.Start
            let v195 : bool = v194 ()
            let v196 : bool = v195 = false
            if v196 then
                let v197 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v197
            let v198 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v198 v187
            let v199 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v199 v187
            let v201 : (System.Threading.CancellationToken -> US32) = method149()
            let v202 : US32 option = v1 |> Option.map v201 
            let v215 : US32 = US32_1
            let v216 : US32 = v202 |> Option.defaultValue v215 
            let v223 : System.Threading.CancellationToken =
                match v216 with
                | US32_1 -> (* None *)
                    let v221 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v221
                | US32_0(v220) -> (* Some *)
                    v220
            let v224 : Async<System.Threading.CancellationToken> = method150(v223)
            let! v224 = v224 
            let v225 : System.Threading.CancellationToken = v224 
            let v226 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v225.Register
            let v227 : (unit -> unit) = closure68(v187)
            let v228 : System.Threading.CancellationTokenRegistration = v226 v227
            use v228 = v228 
            let v229 : System.Threading.CancellationTokenRegistration = v228 
            let v230 : Async<int32> = method153(v187, v189, v225)
            let! v230 = v230 
            let v231 : int32 = v230 
            let v233 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v234 : string seq = v233 v189
            let v238 : (string seq -> string seq) = Seq.rev
            let v239 : string seq = v238 v234
            let v243 : string = method136()
            let v244 : (string -> (string seq -> string)) = String.concat
            let v245 : (string seq -> string) = v244 v243
            let v246 : string = v245 v239
            let v250 : unit = ()
            let v251 : (unit -> unit) = closure70(v0, v1, v2, v3, v4, v5, v6, v231, v246)
            let v252 : unit = (fun () -> v251 (); v250) ()
            return struct (v231, v246) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2268 : Async<struct (int32 * string)> = _let'_v25 
    let _run_target_args'_v11 = v2268 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2270 : unit = ()
    let _let'_v2270 =
        async {
            (* run_target_args'
            let v2281 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v2284 : int32, v2285 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2284, v2285) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v2292 : int32, v2293 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2292, v2293) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v2300 : int32, v2301 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2300, v2301) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v2308 : int32, v2309 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2308, v2309) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v2316 : int32, v2317 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2316, v2317) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v2324 : int32, v2325 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2324, v2325) 
            #endif
#else
            let v2330 : US14 = method85(v0)
            let struct (v2342 : string, v2343 : US5) =
                match v2330 with
                | US14_1(v2333) -> (* Error *)
                    let v2335 : string = $"resultm.get / Result value was Error: {v2333}"
                    failwith<struct (string * US5)> v2335
                | US14_0(v2331, v2332) -> (* Ok *)
                    struct (v2331, v2332)
            let v2345 : (string -> US5) = method6()
            let v2346 : US5 option = v6 |> Option.map v2345 
            let v2359 : US5 = US5_1
            let v2360 : US5 = v2346 |> Option.defaultValue v2359 
            let v2367 : string =
                match v2360 with
                | US5_1 -> (* None *)
                    let v2365 : string = ""
                    v2365
                | US5_0(v2364) -> (* Some *)
                    v2364
            let v2368 : unit = ()
            let v2369 : (unit -> unit) = closure63(v0, v1, v2, v3, v4, v5, v6, v2343, v2342)
            let v2370 : unit = (fun () -> v2369 (); v2368) ()
            let v2417 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v2421 : string =
                match v2343 with
                | US5_1 -> (* None *)
                    let v2419 : string = ""
                    v2419
                | US5_0(v2418) -> (* Some *)
                    v2418
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v2421,
              StandardOutputEncoding = v2417,
              WorkingDirectory = v2367,
              FileName = v2342,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v2422 : System.Diagnostics.ProcessStartInfo = start_info
            let v2423 : (struct (string * string) []) = method143(v0, v1, v2, v3, v4, v5, v6)
            let v2424 : int32 = v2423.Length
            let v2425 : Mut6 = {l0 = 0} : Mut6
            while method63(v2424, v2425) do
                let v2427 : int32 = v2425.l0
                let struct (v2428 : string, v2429 : string) = v2423.[int v2427]
                v2422.EnvironmentVariables.[v2428] <- v2429 
                let v2430 : int32 = v2427 + 1
                v2425.l0 <- v2430
                ()
            let v2431 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v2422)
            use v2431 = v2431 
            let v2432 : System.Diagnostics.Process = v2431 
            let v2433 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v2434 : System.Collections.Concurrent.ConcurrentStack<string> = v2433 ()
            let v2435 : bool = false
            let v2436 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure64(v0, v1, v2, v3, v4, v5, v6, v2432, v2434, v2435)
            v2432.OutputDataReceived.Add v2436 
            let v2437 : bool = true
            let v2438 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure64(v0, v1, v2, v3, v4, v5, v6, v2432, v2434, v2437)
            v2432.ErrorDataReceived.Add v2438 
            let v2439 : (unit -> bool) = v2432.Start
            let v2440 : bool = v2439 ()
            let v2441 : bool = v2440 = false
            if v2441 then
                let v2442 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v2442
            let v2443 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v2443 v2432
            let v2444 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v2444 v2432
            let v2446 : (System.Threading.CancellationToken -> US32) = method149()
            let v2447 : US32 option = v1 |> Option.map v2446 
            let v2460 : US32 = US32_1
            let v2461 : US32 = v2447 |> Option.defaultValue v2460 
            let v2468 : System.Threading.CancellationToken =
                match v2461 with
                | US32_1 -> (* None *)
                    let v2466 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v2466
                | US32_0(v2465) -> (* Some *)
                    v2465
            let v2469 : Async<System.Threading.CancellationToken> = method150(v2468)
            let! v2469 = v2469 
            let v2470 : System.Threading.CancellationToken = v2469 
            let v2471 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v2470.Register
            let v2472 : (unit -> unit) = closure68(v2432)
            let v2473 : System.Threading.CancellationTokenRegistration = v2471 v2472
            use v2473 = v2473 
            let v2474 : System.Threading.CancellationTokenRegistration = v2473 
            let v2475 : Async<int32> = method153(v2432, v2434, v2470)
            let! v2475 = v2475 
            let v2476 : int32 = v2475 
            let v2478 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v2479 : string seq = v2478 v2434
            let v2483 : (string seq -> string seq) = Seq.rev
            let v2484 : string seq = v2483 v2479
            let v2488 : string = method136()
            let v2489 : (string -> (string seq -> string)) = String.concat
            let v2490 : (string seq -> string) = v2489 v2488
            let v2491 : string = v2490 v2484
            let v2495 : unit = ()
            let v2496 : (unit -> unit) = closure70(v0, v1, v2, v3, v4, v5, v6, v2476, v2491)
            let v2497 : unit = (fun () -> v2496 (); v2495) ()
            return struct (v2476, v2491) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v4513 : Async<struct (int32 * string)> = _let'_v2270 
    let _run_target_args'_v11 = v4513 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v4515 : unit = ()
    let _let'_v4515 =
        async {
            (* run_target_args'
            let v4526 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v4529 : int32, v4530 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4529, v4530) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v4537 : int32, v4538 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4537, v4538) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v4545 : int32, v4546 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4545, v4546) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v4553 : int32, v4554 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4553, v4554) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v4561 : int32, v4562 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4561, v4562) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v4569 : int32, v4570 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4569, v4570) 
            #endif
#else
            let v4575 : US14 = method85(v0)
            let struct (v4587 : string, v4588 : US5) =
                match v4575 with
                | US14_1(v4578) -> (* Error *)
                    let v4580 : string = $"resultm.get / Result value was Error: {v4578}"
                    failwith<struct (string * US5)> v4580
                | US14_0(v4576, v4577) -> (* Ok *)
                    struct (v4576, v4577)
            let v4590 : (string -> US5) = method6()
            let v4591 : US5 option = v6 |> Option.map v4590 
            let v4604 : US5 = US5_1
            let v4605 : US5 = v4591 |> Option.defaultValue v4604 
            let v4612 : string =
                match v4605 with
                | US5_1 -> (* None *)
                    let v4610 : string = ""
                    v4610
                | US5_0(v4609) -> (* Some *)
                    v4609
            let v4613 : unit = ()
            let v4614 : (unit -> unit) = closure63(v0, v1, v2, v3, v4, v5, v6, v4588, v4587)
            let v4615 : unit = (fun () -> v4614 (); v4613) ()
            let v4662 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v4666 : string =
                match v4588 with
                | US5_1 -> (* None *)
                    let v4664 : string = ""
                    v4664
                | US5_0(v4663) -> (* Some *)
                    v4663
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v4666,
              StandardOutputEncoding = v4662,
              WorkingDirectory = v4612,
              FileName = v4587,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v4667 : System.Diagnostics.ProcessStartInfo = start_info
            let v4668 : (struct (string * string) []) = method143(v0, v1, v2, v3, v4, v5, v6)
            let v4669 : int32 = v4668.Length
            let v4670 : Mut6 = {l0 = 0} : Mut6
            while method63(v4669, v4670) do
                let v4672 : int32 = v4670.l0
                let struct (v4673 : string, v4674 : string) = v4668.[int v4672]
                v4667.EnvironmentVariables.[v4673] <- v4674 
                let v4675 : int32 = v4672 + 1
                v4670.l0 <- v4675
                ()
            let v4676 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v4667)
            use v4676 = v4676 
            let v4677 : System.Diagnostics.Process = v4676 
            let v4678 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v4679 : System.Collections.Concurrent.ConcurrentStack<string> = v4678 ()
            let v4680 : bool = false
            let v4681 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure64(v0, v1, v2, v3, v4, v5, v6, v4677, v4679, v4680)
            v4677.OutputDataReceived.Add v4681 
            let v4682 : bool = true
            let v4683 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure64(v0, v1, v2, v3, v4, v5, v6, v4677, v4679, v4682)
            v4677.ErrorDataReceived.Add v4683 
            let v4684 : (unit -> bool) = v4677.Start
            let v4685 : bool = v4684 ()
            let v4686 : bool = v4685 = false
            if v4686 then
                let v4687 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v4687
            let v4688 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v4688 v4677
            let v4689 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v4689 v4677
            let v4691 : (System.Threading.CancellationToken -> US32) = method149()
            let v4692 : US32 option = v1 |> Option.map v4691 
            let v4705 : US32 = US32_1
            let v4706 : US32 = v4692 |> Option.defaultValue v4705 
            let v4713 : System.Threading.CancellationToken =
                match v4706 with
                | US32_1 -> (* None *)
                    let v4711 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v4711
                | US32_0(v4710) -> (* Some *)
                    v4710
            let v4714 : Async<System.Threading.CancellationToken> = method150(v4713)
            let! v4714 = v4714 
            let v4715 : System.Threading.CancellationToken = v4714 
            let v4716 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v4715.Register
            let v4717 : (unit -> unit) = closure68(v4677)
            let v4718 : System.Threading.CancellationTokenRegistration = v4716 v4717
            use v4718 = v4718 
            let v4719 : System.Threading.CancellationTokenRegistration = v4718 
            let v4720 : Async<int32> = method153(v4677, v4679, v4715)
            let! v4720 = v4720 
            let v4721 : int32 = v4720 
            let v4723 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v4724 : string seq = v4723 v4679
            let v4728 : (string seq -> string seq) = Seq.rev
            let v4729 : string seq = v4728 v4724
            let v4733 : string = method136()
            let v4734 : (string -> (string seq -> string)) = String.concat
            let v4735 : (string seq -> string) = v4734 v4733
            let v4736 : string = v4735 v4729
            let v4740 : unit = ()
            let v4741 : (unit -> unit) = closure70(v0, v1, v2, v3, v4, v5, v6, v4721, v4736)
            let v4742 : unit = (fun () -> v4741 (); v4740) ()
            return struct (v4721, v4736) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v6758 : Async<struct (int32 * string)> = _let'_v4515 
    let _run_target_args'_v11 = v6758 
    #endif
#else
    let v6760 : unit = ()
    let _let'_v6760 =
        async {
            (* run_target_args'
            let v6771 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v6774 : int32, v6775 : string) = null |> unbox<struct (int32 * string)>
            return struct (v6774, v6775) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v6782 : int32, v6783 : string) = null |> unbox<struct (int32 * string)>
            return struct (v6782, v6783) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v6790 : int32, v6791 : string) = null |> unbox<struct (int32 * string)>
            return struct (v6790, v6791) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v6798 : int32, v6799 : string) = null |> unbox<struct (int32 * string)>
            return struct (v6798, v6799) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v6806 : int32, v6807 : string) = null |> unbox<struct (int32 * string)>
            return struct (v6806, v6807) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v6814 : int32, v6815 : string) = null |> unbox<struct (int32 * string)>
            return struct (v6814, v6815) 
            #endif
#else
            let v6820 : US14 = method85(v0)
            let struct (v6832 : string, v6833 : US5) =
                match v6820 with
                | US14_1(v6823) -> (* Error *)
                    let v6825 : string = $"resultm.get / Result value was Error: {v6823}"
                    failwith<struct (string * US5)> v6825
                | US14_0(v6821, v6822) -> (* Ok *)
                    struct (v6821, v6822)
            let v6835 : (string -> US5) = method6()
            let v6836 : US5 option = v6 |> Option.map v6835 
            let v6849 : US5 = US5_1
            let v6850 : US5 = v6836 |> Option.defaultValue v6849 
            let v6857 : string =
                match v6850 with
                | US5_1 -> (* None *)
                    let v6855 : string = ""
                    v6855
                | US5_0(v6854) -> (* Some *)
                    v6854
            let v6858 : unit = ()
            let v6859 : (unit -> unit) = closure63(v0, v1, v2, v3, v4, v5, v6, v6833, v6832)
            let v6860 : unit = (fun () -> v6859 (); v6858) ()
            let v6907 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v6911 : string =
                match v6833 with
                | US5_1 -> (* None *)
                    let v6909 : string = ""
                    v6909
                | US5_0(v6908) -> (* Some *)
                    v6908
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v6911,
              StandardOutputEncoding = v6907,
              WorkingDirectory = v6857,
              FileName = v6832,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v6912 : System.Diagnostics.ProcessStartInfo = start_info
            let v6913 : (struct (string * string) []) = method143(v0, v1, v2, v3, v4, v5, v6)
            let v6914 : int32 = v6913.Length
            let v6915 : Mut6 = {l0 = 0} : Mut6
            while method63(v6914, v6915) do
                let v6917 : int32 = v6915.l0
                let struct (v6918 : string, v6919 : string) = v6913.[int v6917]
                v6912.EnvironmentVariables.[v6918] <- v6919 
                let v6920 : int32 = v6917 + 1
                v6915.l0 <- v6920
                ()
            let v6921 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v6912)
            use v6921 = v6921 
            let v6922 : System.Diagnostics.Process = v6921 
            let v6923 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v6924 : System.Collections.Concurrent.ConcurrentStack<string> = v6923 ()
            let v6925 : bool = false
            let v6926 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure64(v0, v1, v2, v3, v4, v5, v6, v6922, v6924, v6925)
            v6922.OutputDataReceived.Add v6926 
            let v6927 : bool = true
            let v6928 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure64(v0, v1, v2, v3, v4, v5, v6, v6922, v6924, v6927)
            v6922.ErrorDataReceived.Add v6928 
            let v6929 : (unit -> bool) = v6922.Start
            let v6930 : bool = v6929 ()
            let v6931 : bool = v6930 = false
            if v6931 then
                let v6932 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v6932
            let v6933 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v6933 v6922
            let v6934 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v6934 v6922
            let v6936 : (System.Threading.CancellationToken -> US32) = method149()
            let v6937 : US32 option = v1 |> Option.map v6936 
            let v6950 : US32 = US32_1
            let v6951 : US32 = v6937 |> Option.defaultValue v6950 
            let v6958 : System.Threading.CancellationToken =
                match v6951 with
                | US32_1 -> (* None *)
                    let v6956 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v6956
                | US32_0(v6955) -> (* Some *)
                    v6955
            let v6959 : Async<System.Threading.CancellationToken> = method150(v6958)
            let! v6959 = v6959 
            let v6960 : System.Threading.CancellationToken = v6959 
            let v6961 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v6960.Register
            let v6962 : (unit -> unit) = closure68(v6922)
            let v6963 : System.Threading.CancellationTokenRegistration = v6961 v6962
            use v6963 = v6963 
            let v6964 : System.Threading.CancellationTokenRegistration = v6963 
            let v6965 : Async<int32> = method153(v6922, v6924, v6960)
            let! v6965 = v6965 
            let v6966 : int32 = v6965 
            let v6968 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v6969 : string seq = v6968 v6924
            let v6973 : (string seq -> string seq) = Seq.rev
            let v6974 : string seq = v6973 v6969
            let v6978 : string = method136()
            let v6979 : (string -> (string seq -> string)) = String.concat
            let v6980 : (string seq -> string) = v6979 v6978
            let v6981 : string = v6980 v6974
            let v6985 : unit = ()
            let v6986 : (unit -> unit) = closure70(v0, v1, v2, v3, v4, v5, v6, v6966, v6981)
            let v6987 : unit = (fun () -> v6986 (); v6985) ()
            return struct (v6966, v6981) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v9003 : Async<struct (int32 * string)> = _let'_v6760 
    let _run_target_args'_v11 = v9003 
    #endif
    let v9004 : Async<struct (int32 * string)> = _run_target_args'_v11 
    v9004
and method139 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    method140(v0, v1, v2, v3, v4, v5, v6)
and method83 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : struct (int32 * string) =
    (* run_target_args'
    let v15 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v16 : string = method84(v0, v1, v2, v3, v4, v5, v6)
    let v17 : US14 = method85(v16)
    let struct (v29 : string, v30 : US5) =
        match v17 with
        | US14_1(v20) -> (* Error *)
            let v22 : string = $"resultm.get / Result value was Error: {v20}"
            failwith<struct (string * US5)> v22
        | US14_0(v18, v19) -> (* Ok *)
            struct (v18, v19)
    let v34 : string =
        match v30 with
        | US5_1 -> (* None *)
            let v32 : string = ""
            v32
        | US5_0(v31) -> (* Some *)
            v31
    let v35 : US22 = method98(v34)
    let v44 : (string []) =
        match v35 with
        | US22_1(v37) -> (* Error *)
            let v39 : string = $"resultm.get / Result value was Error: {v37}"
            failwith<(string [])> v39
        | US22_0(v36) -> (* Ok *)
            v36
    let v45 : string = "$0.to_vec()"
    let v46 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v44 v45 
    let v47 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v48 : bool = Fable.Core.RustInterop.emitRustExpr v46 v47 
    let v49 : string = "x"
    let v50 : string = Fable.Core.RustInterop.emitRustExpr () v49 
    (* run_target_args'
    let v55 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v56 : string = "&*$0"
    let v57 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v50 v56 
    let _run_target_args'_v55 = v57 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v58 : string = "&*$0"
    let v59 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v50 v58 
    let _run_target_args'_v55 = v59 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v60 : string = "&*$0"
    let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v50 v60 
    let _run_target_args'_v55 = v61 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v63 : Ref<Str> = v50 |> unbox<Ref<Str>>
    let _run_target_args'_v55 = v63 
    #endif
#if FABLE_COMPILER_PYTHON
    let v67 : Ref<Str> = v50 |> unbox<Ref<Str>>
    let _run_target_args'_v55 = v67 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v71 : Ref<Str> = v50 |> unbox<Ref<Str>>
    let _run_target_args'_v55 = v71 
    #endif
#else
    let v75 : Ref<Str> = v50 |> unbox<Ref<Str>>
    let _run_target_args'_v55 = v75 
    #endif
    let v78 : Ref<Str> = _run_target_args'_v55 
    (* run_target_args'
    let v88 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v89 : string = "String::from($0)"
    let v90 : std_string_String = Fable.Core.RustInterop.emitRustExpr v78 v89 
    let _run_target_args'_v88 = v90 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v91 : string = "String::from($0)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr v78 v91 
    let _run_target_args'_v88 = v92 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v93 : string = "String::from($0)"
    let v94 : std_string_String = Fable.Core.RustInterop.emitRustExpr v78 v93 
    let _run_target_args'_v88 = v94 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v96 : std_string_String = v78 |> unbox<std_string_String>
    let _run_target_args'_v88 = v96 
    #endif
#if FABLE_COMPILER_PYTHON
    let v100 : std_string_String = v78 |> unbox<std_string_String>
    let _run_target_args'_v88 = v100 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v104 : std_string_String = v78 |> unbox<std_string_String>
    let _run_target_args'_v88 = v104 
    #endif
#else
    let v108 : std_string_String = v78 |> unbox<std_string_String>
    let _run_target_args'_v88 = v108 
    #endif
    let v111 : std_string_String = _run_target_args'_v88 
    let v117 : string = "true; $0 }).collect::<Vec<_>>()"
    let v118 : bool = Fable.Core.RustInterop.emitRustExpr v111 v117 
    let v119 : string = "_vec_map"
    let v120 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v119 
    let v121 : unit = ()
    let v122 : (unit -> unit) = closure43(v0, v1, v2, v3, v4, v5, v6, v29, v120)
    let v123 : unit = (fun () -> v122 (); v121) ()
    let v175 : bool = true
    let mutable _capture_v175 : (int32 * string) option = None 
    (
    (fun () ->
    (fun () ->
    let v176 : string = "std::process::Command::new(&*$0)"
    let v177 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v29 v176 
    let v178 : string = "true; let mut v177 = v177"
    let v179 : bool = Fable.Core.RustInterop.emitRustExpr () v178 
    let v180 : string = "true; std::process::Command::args(&mut v177, &*$0)"
    let v181 : bool = Fable.Core.RustInterop.emitRustExpr v120 v180 
    let v182 : string = "$0"
    let v183 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v177 v182 
    let v184 : string = "std::process::Stdio::piped()"
    let v185 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v184 
    let v186 : string = "true; let mut v183 = v183"
    let v187 : bool = Fable.Core.RustInterop.emitRustExpr () v186 
    let v188 : string = "true; std::process::Command::stdout(&mut v183, std::process::Stdio::piped())"
    let v189 : bool = Fable.Core.RustInterop.emitRustExpr () v188 
    let v190 : string = "$0"
    let v191 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v183 v190 
    let v192 : string = "std::process::Stdio::piped()"
    let v193 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v192 
    let v194 : string = "true; let mut v191 = v191"
    let v195 : bool = Fable.Core.RustInterop.emitRustExpr () v194 
    let v196 : string = "true; std::process::Command::stderr(&mut v191, std::process::Stdio::piped())"
    let v197 : bool = Fable.Core.RustInterop.emitRustExpr () v196 
    let v198 : string = "$0"
    let v199 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v191 v198 
    let v200 : string = "std::process::Stdio::piped()"
    let v201 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v200 
    let v202 : string = "true; let mut v199 = v199"
    let v203 : bool = Fable.Core.RustInterop.emitRustExpr () v202 
    let v204 : string = "true; std::process::Command::stdin(&mut v199, std::process::Stdio::piped())"
    let v205 : bool = Fable.Core.RustInterop.emitRustExpr () v204 
    let v206 : string = "$0"
    let v207 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v199 v206 
    let v209 : (string -> US5) = method6()
    let v210 : US5 option = v6 |> Option.map v209 
    let v223 : US5 = US5_1
    let v224 : US5 = v210 |> Option.defaultValue v223 
    let v238 : std_process_Command =
        match v224 with
        | US5_1 -> (* None *)
            let v235 : string = $"v207"
            let v236 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v235 
            v236
        | US5_0(v228) -> (* Some *)
            let v229 : string = "true; let mut v207 = v207"
            let v230 : bool = Fable.Core.RustInterop.emitRustExpr () v229 
            let v231 : string = "true; std::process::Command::current_dir(&mut v207, &*$0)"
            let v232 : bool = Fable.Core.RustInterop.emitRustExpr v228 v231 
            let v233 : string = $"v207"
            let v234 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v233 
            v234
    let v239 : uint64 = System.Convert.ToUInt64 v2.Length
    let v240 : bool = v239 = 0UL
    let v260 : std_process_Command =
        if v240 then
            v238
        else
            let v241 : string = "$0.to_vec()"
            let v242 : Vec<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr v2 v241 
            let v243 : string = "true; let _vec_fold_ = $0.into_iter().fold(v238, |acc, x| { //"
            let v244 : bool = Fable.Core.RustInterop.emitRustExpr v242 v243 
            let v245 : string = "acc"
            let v246 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v245 
            let v247 : string = "x"
            let struct (v248 : string, v249 : string) = Fable.Core.RustInterop.emitRustExpr () v247 
            let v250 : string = "true; let mut v246 = v246"
            let v251 : bool = Fable.Core.RustInterop.emitRustExpr () v250 
            let v252 : string = "true; std::process::Command::env(&mut v246, &*$0, &*$1)"
            let v253 : bool = Fable.Core.RustInterop.emitRustExpr struct (v248, v249) v252 
            let v254 : string = "$0"
            let v255 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v246 v254 
            let v256 : string = "true; $0 })"
            let v257 : bool = Fable.Core.RustInterop.emitRustExpr v255 v256 
            let v258 : string = "_vec_fold_"
            let v259 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v258 
            v259
    let v261 : string = "true; let mut v260 = v260"
    let v262 : bool = Fable.Core.RustInterop.emitRustExpr () v261 
    let v263 : string = "std::process::Command::spawn(&mut v260)"
    let v264 : Result<std_process_Child, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v263 
    let v265 : (std_io_Error -> std_string_String) = method69()
    (* run_target_args'
    let v267 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v268 : string = "$0.map_err(|x| $1(x))"
    let v269 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v264, v265) v268 
    let _run_target_args'_v267 = v269 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v270 : string = "$0.map_err(|x| $1(x))"
    let v271 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v264, v265) v270 
    let _run_target_args'_v267 = v271 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v272 : string = "$0.map_err(|x| $1(x))"
    let v273 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v264, v265) v272 
    let _run_target_args'_v267 = v273 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v274 : Result<std_process_Child, std_string_String> = match v264 with Ok x -> Ok x | Error x -> Error (v265 x)
    let _run_target_args'_v267 = v274 
    #endif
#if FABLE_COMPILER_PYTHON
    let v275 : Result<std_process_Child, std_string_String> = match v264 with Ok x -> Ok x | Error x -> Error (v265 x)
    let _run_target_args'_v267 = v275 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v276 : Result<std_process_Child, std_string_String> = match v264 with Ok x -> Ok x | Error x -> Error (v265 x)
    let _run_target_args'_v267 = v276 
    #endif
#else
    let v277 : Result<std_process_Child, std_string_String> = match v264 with Ok x -> Ok x | Error x -> Error (v265 x)
    let _run_target_args'_v267 = v277 
    #endif
    let v278 : Result<std_process_Child, std_string_String> = _run_target_args'_v267 
    let v281 : (std_process_Child option -> std_process_Child option) = method110()
    let v282 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v283 : bool = Fable.Core.RustInterop.emitRustExpr v278 v282 
    let v284 : string = "x"
    let v285 : std_process_Child = Fable.Core.RustInterop.emitRustExpr () v284 
    let v287 : std_process_Child option = Some v285 
    let v290 : std_process_Child option = v281 v287
    let v291 : string = "std::sync::Mutex::new(v290)"
    let v292 : std_sync_Mutex<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr () v291 
    let v293 : string = "std::sync::Arc::new(v292)"
    let v294 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr () v293 
    let v295 : string = "true; $0 })"
    let v296 : bool = Fable.Core.RustInterop.emitRustExpr v294 v295 
    let v297 : string = "_result_map_"
    let v298 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v297 
    let v299 : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US24) = method111()
    let v300 : (std_string_String -> US24) = method112()
    let v301 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
    let v302 : US24 = Fable.Core.RustInterop.emitRustExpr struct (v299, v300, v298) v301 
    let struct (v1596 : int32, v1597 : US6, v1598 : US25) =
        match v302 with
        | US24_1(v1541) -> (* Error *)
            let v1542 : unit = ()
            let v1543 : (unit -> unit) = closure47(v1541)
            let v1544 : unit = (fun () -> v1543 (); v1542) ()
            let v1591 : US6 = US6_0(v1541)
            let v1592 : US25 = US25_1
            struct (-1, v1591, v1592)
        | US24_0(v303) -> (* Ok *)
            let v304 : string = "true; let _capture = (|| { //"
            let v305 : bool = Fable.Core.RustInterop.emitRustExpr () v304 
            let v306 : string = "$0"
            let v307 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v303 v306 
            let v308 : string = "v307.lock()"
            let v309 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v308 
            (* run_target_args'
            let v311 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v312 : string = "$0.unwrap()"
            let v313 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v309 v312 
            let _run_target_args'_v311 = v313 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v314 : string = "$0.unwrap()"
            let v315 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v309 v314 
            let _run_target_args'_v311 = v315 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v316 : string = "$0.unwrap()"
            let v317 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v309 v316 
            let _run_target_args'_v311 = v317 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v318 : std_sync_MutexGuard<std_process_Child option> = match v309 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v311 = v318 
            #endif
#if FABLE_COMPILER_PYTHON
            let v319 : std_sync_MutexGuard<std_process_Child option> = match v309 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v311 = v319 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v320 : std_sync_MutexGuard<std_process_Child option> = match v309 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v311 = v320 
            #endif
#else
            let v321 : std_sync_MutexGuard<std_process_Child option> = match v309 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v311 = v321 
            #endif
            let v322 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v311 
            let v325 : std_sync_MutexGuard<std_process_Child option> = method114(v322)
            let v326 : string = "true; let mut v325 = v325"
            let v327 : bool = Fable.Core.RustInterop.emitRustExpr () v326 
            let v328 : string = "&mut $0"
            let v329 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v325 v328 
            let v330 : string = "$0.as_mut()"
            let v331 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v329 v330 
            let v332 : string = "$0.unwrap()"
            let v333 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v331 v332 
            let v334 : string = "&mut $0.stdout"
            let v335 : Ref<Mut<std_process_ChildStdout option>> = Fable.Core.RustInterop.emitRustExpr v333 v334 
            let v336 : string = "Option::take($0)"
            let v337 : std_process_ChildStdout option = Fable.Core.RustInterop.emitRustExpr v335 v336 
            let v338 : string = "$0.unwrap()"
            let v339 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr v337 v338 
            let v340 : string = "true; $0 })()"
            let v341 : bool = Fable.Core.RustInterop.emitRustExpr v339 v340 
            let v342 : string = "_capture"
            let v343 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr () v342 
            let v344 : string = "true; let _capture = (|| { //"
            let v345 : bool = Fable.Core.RustInterop.emitRustExpr () v344 
            let v346 : string = "$0"
            let v347 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v303 v346 
            let v348 : string = "v347.lock()"
            let v349 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v348 
            (* run_target_args'
            let v351 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v352 : string = "$0.unwrap()"
            let v353 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v349 v352 
            let _run_target_args'_v351 = v353 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v354 : string = "$0.unwrap()"
            let v355 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v349 v354 
            let _run_target_args'_v351 = v355 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v356 : string = "$0.unwrap()"
            let v357 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v349 v356 
            let _run_target_args'_v351 = v357 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v358 : std_sync_MutexGuard<std_process_Child option> = match v349 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v351 = v358 
            #endif
#if FABLE_COMPILER_PYTHON
            let v359 : std_sync_MutexGuard<std_process_Child option> = match v349 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v351 = v359 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v360 : std_sync_MutexGuard<std_process_Child option> = match v349 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v351 = v360 
            #endif
#else
            let v361 : std_sync_MutexGuard<std_process_Child option> = match v349 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v351 = v361 
            #endif
            let v362 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v351 
            let v365 : std_sync_MutexGuard<std_process_Child option> = method114(v362)
            let v366 : string = "true; let mut v365 = v365"
            let v367 : bool = Fable.Core.RustInterop.emitRustExpr () v366 
            let v368 : string = "&mut $0"
            let v369 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v365 v368 
            let v370 : string = "$0.as_mut()"
            let v371 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v369 v370 
            let v372 : string = "$0.unwrap()"
            let v373 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v371 v372 
            let v374 : string = "&mut $0.stderr"
            let v375 : Ref<Mut<std_process_ChildStderr option>> = Fable.Core.RustInterop.emitRustExpr v373 v374 
            let v376 : string = "Option::take($0)"
            let v377 : std_process_ChildStderr option = Fable.Core.RustInterop.emitRustExpr v375 v376 
            let v378 : string = "$0.unwrap()"
            let v379 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr v377 v378 
            let v380 : string = "true; $0 })()"
            let v381 : bool = Fable.Core.RustInterop.emitRustExpr v379 v380 
            let v382 : string = "_capture"
            let v383 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr () v382 
            let v384 : string = "true; let _capture = (|| { //"
            let v385 : bool = Fable.Core.RustInterop.emitRustExpr () v384 
            let v386 : string = "$0"
            let v387 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v303 v386 
            let v388 : string = "v387.lock()"
            let v389 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v388 
            (* run_target_args'
            let v391 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v392 : string = "$0.unwrap()"
            let v393 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v389 v392 
            let _run_target_args'_v391 = v393 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v394 : string = "$0.unwrap()"
            let v395 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v389 v394 
            let _run_target_args'_v391 = v395 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v396 : string = "$0.unwrap()"
            let v397 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v389 v396 
            let _run_target_args'_v391 = v397 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v398 : std_sync_MutexGuard<std_process_Child option> = match v389 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v391 = v398 
            #endif
#if FABLE_COMPILER_PYTHON
            let v399 : std_sync_MutexGuard<std_process_Child option> = match v389 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v391 = v399 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v400 : std_sync_MutexGuard<std_process_Child option> = match v389 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v391 = v400 
            #endif
#else
            let v401 : std_sync_MutexGuard<std_process_Child option> = match v389 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v391 = v401 
            #endif
            let v402 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v391 
            let v405 : std_sync_MutexGuard<std_process_Child option> = method114(v402)
            let v406 : string = "true; let mut v405 = v405"
            let v407 : bool = Fable.Core.RustInterop.emitRustExpr () v406 
            let v408 : string = "&mut $0"
            let v409 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v405 v408 
            let v410 : string = "$0.as_mut()"
            let v411 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v409 v410 
            let v412 : string = "$0.unwrap()"
            let v413 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v411 v412 
            let v414 : string = "&mut $0.stdin"
            let v415 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v413 v414 
            let v416 : string = "Option::take($0)"
            let v417 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v415 v416 
            let v418 : string = "$0.unwrap()"
            let v419 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr v417 v418 
            let v421 : std_process_ChildStdin option = Some v419 
            let v424 : (std_process_ChildStdin option -> std_process_ChildStdin option) = method115()
            let v425 : std_process_ChildStdin option = v424 v421
            let v426 : string = "std::sync::Mutex::new(v425)"
            let v427 : std_sync_Mutex<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr () v426 
            let v428 : string = "std::sync::Arc::new(v427)"
            let v429 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v428 
            let v430 : string = "true; $0 })()"
            let v431 : bool = Fable.Core.RustInterop.emitRustExpr v429 v430 
            let v432 : string = "_capture"
            let v433 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v432 
            let v434 : string = "{ let (sender, receiver) = std::sync::mpsc::channel(); (sender, std::sync::Arc::new(receiver)) }"
            let struct (v435 : std_sync_mpsc_Sender<std_string_String>, v436 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = Fable.Core.RustInterop.emitRustExpr () v434 
            let v437 : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) = method116()
            let v438 : std_sync_mpsc_Sender<std_string_String> = v437 v435
            let v439 : string = "std::sync::Mutex::new(v438)"
            let v440 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v439 
            let v441 : string = "std::sync::Arc::new(v440)"
            let v442 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v441 
            let v443 : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) = method117()
            let v444 : std_sync_mpsc_Sender<std_string_String> = v443 v435
            let v445 : string = "std::sync::Mutex::new(v444)"
            let v446 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v445 
            let v447 : string = "std::sync::Arc::new(v446)"
            let v448 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v447 
            let v449 : (std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> -> std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = method118()
            let v450 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> = v449 v436
            let v451 : string = "std::sync::Mutex::new(v450)"
            let v452 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v451 
            let v453 : string = "std::sync::Arc::new(v452)"
            let v454 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v453 
            let v455 : string = "true; let __spawn = std::thread::spawn(move || { //"
            let v456 : bool = Fable.Core.RustInterop.emitRustExpr () v455 
            let v457 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v458 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v343 v457 
            let v459 : string = "std::io::BufReader::new($0)"
            let v460 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr v458 v459 
            let v461 : string = "std::io::BufRead::lines(v460)"
            let v462 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v461 
            let v463 : string = "true; let mut v462 = v462; let _iter_try_for_each = v462.try_for_each(|x| { //"
            let v464 : bool = Fable.Core.RustInterop.emitRustExpr () v463 
            let v465 : string = "x"
            let v466 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v465 
            let v467 : string = "$0.clone()"
            let v468 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v442 v467 
            let v469 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v471 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v472 : string = "$0.map_err(|x| $1(x))"
            let v473 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v466, v469) v472 
            let _run_target_args'_v471 = v473 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v474 : string = "$0.map_err(|x| $1(x))"
            let v475 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v466, v469) v474 
            let _run_target_args'_v471 = v475 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v476 : string = "$0.map_err(|x| $1(x))"
            let v477 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v466, v469) v476 
            let _run_target_args'_v471 = v477 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v478 : Result<std_string_String, std_string_String> = match v466 with Ok x -> Ok x | Error x -> Error (v469 x)
            let _run_target_args'_v471 = v478 
            #endif
#if FABLE_COMPILER_PYTHON
            let v479 : Result<std_string_String, std_string_String> = match v466 with Ok x -> Ok x | Error x -> Error (v469 x)
            let _run_target_args'_v471 = v479 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v480 : Result<std_string_String, std_string_String> = match v466 with Ok x -> Ok x | Error x -> Error (v469 x)
            let _run_target_args'_v471 = v480 
            #endif
#else
            let v481 : Result<std_string_String, std_string_String> = match v466 with Ok x -> Ok x | Error x -> Error (v469 x)
            let _run_target_args'_v471 = v481 
            #endif
            let v482 : Result<std_string_String, std_string_String> = _run_target_args'_v471 
            let v485 : (std_string_String -> US26) = method119()
            let v486 : (std_string_String -> US26) = method120()
            let v487 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v488 : US26 = Fable.Core.RustInterop.emitRustExpr struct (v485, v486, v482) v487 
            let v725 : std_string_String =
                match v488 with
                | US26_1(v607) -> (* Error *)
                    let v608 : unit = ()
                    let v609 : (unit -> unit) = closure53(v5, v607)
                    let v610 : unit = (fun () -> v609 (); v608) ()
                    let v657 : string = $"\u001b[4;7m{v607}\u001b[0m"
                    (* run_target_args'
                    let v662 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v663 : string = "&*$0"
                    let v664 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v657 v663 
                    let _run_target_args'_v662 = v664 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v665 : string = "&*$0"
                    let v666 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v657 v665 
                    let _run_target_args'_v662 = v666 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v667 : string = "&*$0"
                    let v668 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v657 v667 
                    let _run_target_args'_v662 = v668 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v670 : Ref<Str> = v657 |> unbox<Ref<Str>>
                    let _run_target_args'_v662 = v670 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v674 : Ref<Str> = v657 |> unbox<Ref<Str>>
                    let _run_target_args'_v662 = v674 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v678 : Ref<Str> = v657 |> unbox<Ref<Str>>
                    let _run_target_args'_v662 = v678 
                    #endif
#else
                    let v682 : Ref<Str> = v657 |> unbox<Ref<Str>>
                    let _run_target_args'_v662 = v682 
                    #endif
                    let v685 : Ref<Str> = _run_target_args'_v662 
                    (* run_target_args'
                    let v695 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v696 : string = "String::from($0)"
                    let v697 : std_string_String = Fable.Core.RustInterop.emitRustExpr v685 v696 
                    let _run_target_args'_v695 = v697 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v698 : string = "String::from($0)"
                    let v699 : std_string_String = Fable.Core.RustInterop.emitRustExpr v685 v698 
                    let _run_target_args'_v695 = v699 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v700 : string = "String::from($0)"
                    let v701 : std_string_String = Fable.Core.RustInterop.emitRustExpr v685 v700 
                    let _run_target_args'_v695 = v701 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v703 : std_string_String = v685 |> unbox<std_string_String>
                    let _run_target_args'_v695 = v703 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v707 : std_string_String = v685 |> unbox<std_string_String>
                    let _run_target_args'_v695 = v707 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v711 : std_string_String = v685 |> unbox<std_string_String>
                    let _run_target_args'_v695 = v711 
                    #endif
#else
                    let v715 : std_string_String = v685 |> unbox<std_string_String>
                    let _run_target_args'_v695 = v715 
                    #endif
                    let v718 : std_string_String = _run_target_args'_v695 
                    v718
                | US26_0(v489) -> (* Ok *)
                    let v490 : string = "fable_library_rust::String_::fromString($0)"
                    let v491 : string = Fable.Core.RustInterop.emitRustExpr v489 v490 
                    let v492 : string = "encoding_rs::UTF_8"
                    let v493 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v492 
                    let v494 : string = "$0.encode(&*$1).0"
                    let v495 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v493, v491) v494 
                    let v496 : string = "$0.as_ref()"
                    let v497 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v495 v496 
                    let v498 : string = "std::str::from_utf8($0)"
                    let v499 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr v497 v498 
                    (* run_target_args'
                    let v501 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v502 : string = "$0.unwrap()"
                    let v503 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v499 v502 
                    let _run_target_args'_v501 = v503 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v504 : string = "$0.unwrap()"
                    let v505 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v499 v504 
                    let _run_target_args'_v501 = v505 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v506 : string = "$0.unwrap()"
                    let v507 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v499 v506 
                    let _run_target_args'_v501 = v507 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v508 : Ref<Str> = match v499 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v501 = v508 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v509 : Ref<Str> = match v499 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v501 = v509 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v510 : Ref<Str> = match v499 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v501 = v510 
                    #endif
#else
                    let v511 : Ref<Str> = match v499 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v501 = v511 
                    #endif
                    let v512 : Ref<Str> = _run_target_args'_v501 
                    (* run_target_args'
                    let v519 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v520 : string = "String::from($0)"
                    let v521 : std_string_String = Fable.Core.RustInterop.emitRustExpr v512 v520 
                    let _run_target_args'_v519 = v521 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v522 : string = "String::from($0)"
                    let v523 : std_string_String = Fable.Core.RustInterop.emitRustExpr v512 v522 
                    let _run_target_args'_v519 = v523 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v524 : string = "String::from($0)"
                    let v525 : std_string_String = Fable.Core.RustInterop.emitRustExpr v512 v524 
                    let _run_target_args'_v519 = v525 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v527 : std_string_String = v512 |> unbox<std_string_String>
                    let _run_target_args'_v519 = v527 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v531 : std_string_String = v512 |> unbox<std_string_String>
                    let _run_target_args'_v519 = v531 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v535 : std_string_String = v512 |> unbox<std_string_String>
                    let _run_target_args'_v519 = v535 
                    #endif
#else
                    let v539 : std_string_String = v512 |> unbox<std_string_String>
                    let _run_target_args'_v519 = v539 
                    #endif
                    let v542 : std_string_String = _run_target_args'_v519 
                    let v548 : string = "fable_library_rust::String_::fromString($0)"
                    let v549 : string = Fable.Core.RustInterop.emitRustExpr v542 v548 
                    let v550 : string = $"> {v549}"
                    if v5 then
                        let v551 : unit = ()
                        let v552 : (unit -> unit) = closure54(v550)
                        let v553 : unit = (fun () -> v552 (); v551) ()
                        ()
                    else
                        let v603 : unit = ()
                        let v604 : (unit -> unit) = closure11(v550)
                        let v605 : unit = (fun () -> v604 (); v603) ()
                        ()
                    v542
            let v726 : string = "$0"
            let v727 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v468 v726 
            let v728 : string = "v727.lock()"
            let v729 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v728 
            (* run_target_args'
            let v731 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v732 : string = "$0.unwrap()"
            let v733 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v729 v732 
            let _run_target_args'_v731 = v733 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v734 : string = "$0.unwrap()"
            let v735 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v729 v734 
            let _run_target_args'_v731 = v735 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v736 : string = "$0.unwrap()"
            let v737 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v729 v736 
            let _run_target_args'_v731 = v737 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v738 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v729 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v731 = v738 
            #endif
#if FABLE_COMPILER_PYTHON
            let v739 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v729 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v731 = v739 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v740 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v729 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v731 = v740 
            #endif
#else
            let v741 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v729 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v731 = v741 
            #endif
            let v742 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = _run_target_args'_v731 
            let v745 : string = "&$0"
            let v746 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v742 v745 
            let v747 : string = "$0.send($1)"
            let v748 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v746, v725) v747 
            let v749 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method126()
            (* run_target_args'
            let v751 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v752 : string = "$0.map_err(|x| $1(x))"
            let v753 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v748, v749) v752 
            let _run_target_args'_v751 = v753 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v754 : string = "$0.map_err(|x| $1(x))"
            let v755 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v748, v749) v754 
            let _run_target_args'_v751 = v755 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v756 : string = "$0.map_err(|x| $1(x))"
            let v757 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v748, v749) v756 
            let _run_target_args'_v751 = v757 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v758 : Result<unit, std_string_String> = match v748 with Ok x -> Ok x | Error x -> Error (v749 x)
            let _run_target_args'_v751 = v758 
            #endif
#if FABLE_COMPILER_PYTHON
            let v759 : Result<unit, std_string_String> = match v748 with Ok x -> Ok x | Error x -> Error (v749 x)
            let _run_target_args'_v751 = v759 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v760 : Result<unit, std_string_String> = match v748 with Ok x -> Ok x | Error x -> Error (v749 x)
            let _run_target_args'_v751 = v760 
            #endif
#else
            let v761 : Result<unit, std_string_String> = match v748 with Ok x -> Ok x | Error x -> Error (v749 x)
            let _run_target_args'_v751 = v761 
            #endif
            let v762 : Result<unit, std_string_String> = _run_target_args'_v751 
            let v765 : string = "$0"
            let v766 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v762 v765 
            let v767 : string = "true; $0 }); //"
            let v768 : bool = Fable.Core.RustInterop.emitRustExpr v766 v767 
            let v769 : string = "_iter_try_for_each.map_err(|x| x.into())"
            let v770 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v769 
            let v771 : Result<unit, string> = method127(v770)
            let v772 : string = ""
            let v773 : string = "}"
            let v774 : string = v772 + v773 
            let x = v771 //
            let v775 : _ = x
            let v776 : unit = ()
            (* run_target_args'
            let v777 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v778 : string = $"true; let _fix_closure_v776 = $0"
            let v779 : bool = Fable.Core.RustInterop.emitRustExpr v775 v778 
            let _run_target_args'_v777 = true 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v780 : string = $"true; let _fix_closure_v776 = $0"
            let v781 : bool = Fable.Core.RustInterop.emitRustExpr v775 v780 
            let _run_target_args'_v777 = true 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v782 : string = $"true; let _fix_closure_v776 = $0"
            let v783 : bool = Fable.Core.RustInterop.emitRustExpr v775 v782 
            let _run_target_args'_v777 = true 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let _run_target_args'_v777 = false 
            #endif
#if FABLE_COMPILER_PYTHON
            let _run_target_args'_v777 = false 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let _run_target_args'_v777 = false 
            #endif
#else
            let _run_target_args'_v777 = false 
            #endif
            let v784 : bool = _run_target_args'_v777 
            let v786 : string = $"true; _fix_closure_v776 " + v774 + "); " + v772 + " // rust.fix_closure'"
            let v787 : bool = Fable.Core.RustInterop.emitRustExpr () v786 
            let v788 : string = "__spawn"
            let v789 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v788 
            let v790 : string = "true; let __spawn = std::thread::spawn(move || { //"
            let v791 : bool = Fable.Core.RustInterop.emitRustExpr () v790 
            let v792 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v793 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v383 v792 
            let v794 : string = "std::io::BufReader::new($0)"
            let v795 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr v793 v794 
            let v796 : string = "std::io::BufRead::lines(v795)"
            let v797 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v796 
            let v798 : string = "true; let mut v797 = v797; let _iter_try_for_each = v797.try_for_each(|x| { //"
            let v799 : bool = Fable.Core.RustInterop.emitRustExpr () v798 
            let v800 : string = "x"
            let v801 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v800 
            let v802 : string = "$0.clone()"
            let v803 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v448 v802 
            let v804 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v806 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v807 : string = "$0.map_err(|x| $1(x))"
            let v808 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v801, v804) v807 
            let _run_target_args'_v806 = v808 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v809 : string = "$0.map_err(|x| $1(x))"
            let v810 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v801, v804) v809 
            let _run_target_args'_v806 = v810 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v811 : string = "$0.map_err(|x| $1(x))"
            let v812 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v801, v804) v811 
            let _run_target_args'_v806 = v812 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v813 : Result<std_string_String, std_string_String> = match v801 with Ok x -> Ok x | Error x -> Error (v804 x)
            let _run_target_args'_v806 = v813 
            #endif
#if FABLE_COMPILER_PYTHON
            let v814 : Result<std_string_String, std_string_String> = match v801 with Ok x -> Ok x | Error x -> Error (v804 x)
            let _run_target_args'_v806 = v814 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v815 : Result<std_string_String, std_string_String> = match v801 with Ok x -> Ok x | Error x -> Error (v804 x)
            let _run_target_args'_v806 = v815 
            #endif
#else
            let v816 : Result<std_string_String, std_string_String> = match v801 with Ok x -> Ok x | Error x -> Error (v804 x)
            let _run_target_args'_v806 = v816 
            #endif
            let v817 : Result<std_string_String, std_string_String> = _run_target_args'_v806 
            let v820 : (std_string_String -> US26) = method119()
            let v821 : (std_string_String -> US26) = method120()
            let v822 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v823 : US26 = Fable.Core.RustInterop.emitRustExpr struct (v820, v821, v817) v822 
            let v1126 : std_string_String =
                match v823 with
                | US26_1(v1008) -> (* Error *)
                    let v1009 : unit = ()
                    let v1010 : (unit -> unit) = closure53(v5, v1008)
                    let v1011 : unit = (fun () -> v1010 (); v1009) ()
                    let v1058 : string = $"\u001b[4;7m{v1008}\u001b[0m"
                    (* run_target_args'
                    let v1063 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1064 : string = "&*$0"
                    let v1065 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1058 v1064 
                    let _run_target_args'_v1063 = v1065 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1066 : string = "&*$0"
                    let v1067 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1058 v1066 
                    let _run_target_args'_v1063 = v1067 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1068 : string = "&*$0"
                    let v1069 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1058 v1068 
                    let _run_target_args'_v1063 = v1069 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1071 : Ref<Str> = v1058 |> unbox<Ref<Str>>
                    let _run_target_args'_v1063 = v1071 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1075 : Ref<Str> = v1058 |> unbox<Ref<Str>>
                    let _run_target_args'_v1063 = v1075 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1079 : Ref<Str> = v1058 |> unbox<Ref<Str>>
                    let _run_target_args'_v1063 = v1079 
                    #endif
#else
                    let v1083 : Ref<Str> = v1058 |> unbox<Ref<Str>>
                    let _run_target_args'_v1063 = v1083 
                    #endif
                    let v1086 : Ref<Str> = _run_target_args'_v1063 
                    (* run_target_args'
                    let v1096 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1097 : string = "String::from($0)"
                    let v1098 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1086 v1097 
                    let _run_target_args'_v1096 = v1098 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1099 : string = "String::from($0)"
                    let v1100 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1086 v1099 
                    let _run_target_args'_v1096 = v1100 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1101 : string = "String::from($0)"
                    let v1102 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1086 v1101 
                    let _run_target_args'_v1096 = v1102 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1104 : std_string_String = v1086 |> unbox<std_string_String>
                    let _run_target_args'_v1096 = v1104 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1108 : std_string_String = v1086 |> unbox<std_string_String>
                    let _run_target_args'_v1096 = v1108 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1112 : std_string_String = v1086 |> unbox<std_string_String>
                    let _run_target_args'_v1096 = v1112 
                    #endif
#else
                    let v1116 : std_string_String = v1086 |> unbox<std_string_String>
                    let _run_target_args'_v1096 = v1116 
                    #endif
                    let v1119 : std_string_String = _run_target_args'_v1096 
                    v1119
                | US26_0(v824) -> (* Ok *)
                    let v825 : string = "fable_library_rust::String_::fromString($0)"
                    let v826 : string = Fable.Core.RustInterop.emitRustExpr v824 v825 
                    let v827 : string = "encoding_rs::UTF_8"
                    let v828 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v827 
                    let v829 : string = "$0.encode(&*$1).0"
                    let v830 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v828, v826) v829 
                    let v831 : string = "$0.as_ref()"
                    let v832 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v830 v831 
                    let v833 : string = "std::str::from_utf8($0)"
                    let v834 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr v832 v833 
                    (* run_target_args'
                    let v836 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v837 : string = "$0.unwrap()"
                    let v838 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v834 v837 
                    let _run_target_args'_v836 = v838 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v839 : string = "$0.unwrap()"
                    let v840 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v834 v839 
                    let _run_target_args'_v836 = v840 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v841 : string = "$0.unwrap()"
                    let v842 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v834 v841 
                    let _run_target_args'_v836 = v842 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v843 : Ref<Str> = match v834 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v836 = v843 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v844 : Ref<Str> = match v834 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v836 = v844 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v845 : Ref<Str> = match v834 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v836 = v845 
                    #endif
#else
                    let v846 : Ref<Str> = match v834 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v836 = v846 
                    #endif
                    let v847 : Ref<Str> = _run_target_args'_v836 
                    (* run_target_args'
                    let v854 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v855 : string = "String::from($0)"
                    let v856 : std_string_String = Fable.Core.RustInterop.emitRustExpr v847 v855 
                    let _run_target_args'_v854 = v856 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v857 : string = "String::from($0)"
                    let v858 : std_string_String = Fable.Core.RustInterop.emitRustExpr v847 v857 
                    let _run_target_args'_v854 = v858 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v859 : string = "String::from($0)"
                    let v860 : std_string_String = Fable.Core.RustInterop.emitRustExpr v847 v859 
                    let _run_target_args'_v854 = v860 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v862 : std_string_String = v847 |> unbox<std_string_String>
                    let _run_target_args'_v854 = v862 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v866 : std_string_String = v847 |> unbox<std_string_String>
                    let _run_target_args'_v854 = v866 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v870 : std_string_String = v847 |> unbox<std_string_String>
                    let _run_target_args'_v854 = v870 
                    #endif
#else
                    let v874 : std_string_String = v847 |> unbox<std_string_String>
                    let _run_target_args'_v854 = v874 
                    #endif
                    let v877 : std_string_String = _run_target_args'_v854 
                    let v883 : string = "fable_library_rust::String_::fromString($0)"
                    let v884 : string = Fable.Core.RustInterop.emitRustExpr v877 v883 
                    let v885 : string = $"! {v884}"
                    if v5 then
                        let v886 : unit = ()
                        let v887 : (unit -> unit) = closure54(v885)
                        let v888 : unit = (fun () -> v887 (); v886) ()
                        ()
                    else
                        let v937 : unit = ()
                        let v938 : (unit -> unit) = closure11(v885)
                        let v939 : unit = (fun () -> v938 (); v937) ()
                        ()
                    let v941 : string = $"\u001b[4;7m{v877}\u001b[0m"
                    (* run_target_args'
                    let v946 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v947 : string = "&*$0"
                    let v948 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v941 v947 
                    let _run_target_args'_v946 = v948 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v949 : string = "&*$0"
                    let v950 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v941 v949 
                    let _run_target_args'_v946 = v950 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v951 : string = "&*$0"
                    let v952 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v941 v951 
                    let _run_target_args'_v946 = v952 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v954 : Ref<Str> = v941 |> unbox<Ref<Str>>
                    let _run_target_args'_v946 = v954 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v958 : Ref<Str> = v941 |> unbox<Ref<Str>>
                    let _run_target_args'_v946 = v958 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v962 : Ref<Str> = v941 |> unbox<Ref<Str>>
                    let _run_target_args'_v946 = v962 
                    #endif
#else
                    let v966 : Ref<Str> = v941 |> unbox<Ref<Str>>
                    let _run_target_args'_v946 = v966 
                    #endif
                    let v969 : Ref<Str> = _run_target_args'_v946 
                    (* run_target_args'
                    let v979 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v980 : string = "String::from($0)"
                    let v981 : std_string_String = Fable.Core.RustInterop.emitRustExpr v969 v980 
                    let _run_target_args'_v979 = v981 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v982 : string = "String::from($0)"
                    let v983 : std_string_String = Fable.Core.RustInterop.emitRustExpr v969 v982 
                    let _run_target_args'_v979 = v983 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v984 : string = "String::from($0)"
                    let v985 : std_string_String = Fable.Core.RustInterop.emitRustExpr v969 v984 
                    let _run_target_args'_v979 = v985 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v987 : std_string_String = v969 |> unbox<std_string_String>
                    let _run_target_args'_v979 = v987 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v991 : std_string_String = v969 |> unbox<std_string_String>
                    let _run_target_args'_v979 = v991 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v995 : std_string_String = v969 |> unbox<std_string_String>
                    let _run_target_args'_v979 = v995 
                    #endif
#else
                    let v999 : std_string_String = v969 |> unbox<std_string_String>
                    let _run_target_args'_v979 = v999 
                    #endif
                    let v1002 : std_string_String = _run_target_args'_v979 
                    v1002
            let v1127 : string = "$0"
            let v1128 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v803 v1127 
            let v1129 : string = "v1128.lock()"
            let v1130 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v1129 
            (* run_target_args'
            let v1132 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1133 : string = "$0.unwrap()"
            let v1134 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1130 v1133 
            let _run_target_args'_v1132 = v1134 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1135 : string = "$0.unwrap()"
            let v1136 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1130 v1135 
            let _run_target_args'_v1132 = v1136 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1137 : string = "$0.unwrap()"
            let v1138 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1130 v1137 
            let _run_target_args'_v1132 = v1138 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1139 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1130 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1132 = v1139 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1140 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1130 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1132 = v1140 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1141 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1130 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1132 = v1141 
            #endif
#else
            let v1142 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1130 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1132 = v1142 
            #endif
            let v1143 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = _run_target_args'_v1132 
            let v1146 : string = "&$0"
            let v1147 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1143 v1146 
            let v1148 : string = "$0.send($1)"
            let v1149 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v1147, v1126) v1148 
            let v1150 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method126()
            (* run_target_args'
            let v1152 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1153 : string = "$0.map_err(|x| $1(x))"
            let v1154 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1149, v1150) v1153 
            let _run_target_args'_v1152 = v1154 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1155 : string = "$0.map_err(|x| $1(x))"
            let v1156 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1149, v1150) v1155 
            let _run_target_args'_v1152 = v1156 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1157 : string = "$0.map_err(|x| $1(x))"
            let v1158 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1149, v1150) v1157 
            let _run_target_args'_v1152 = v1158 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1159 : Result<unit, std_string_String> = match v1149 with Ok x -> Ok x | Error x -> Error (v1150 x)
            let _run_target_args'_v1152 = v1159 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1160 : Result<unit, std_string_String> = match v1149 with Ok x -> Ok x | Error x -> Error (v1150 x)
            let _run_target_args'_v1152 = v1160 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1161 : Result<unit, std_string_String> = match v1149 with Ok x -> Ok x | Error x -> Error (v1150 x)
            let _run_target_args'_v1152 = v1161 
            #endif
#else
            let v1162 : Result<unit, std_string_String> = match v1149 with Ok x -> Ok x | Error x -> Error (v1150 x)
            let _run_target_args'_v1152 = v1162 
            #endif
            let v1163 : Result<unit, std_string_String> = _run_target_args'_v1152 
            let v1166 : string = "$0"
            let v1167 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v1163 v1166 
            let v1168 : string = "true; $0 }); //"
            let v1169 : bool = Fable.Core.RustInterop.emitRustExpr v1167 v1168 
            let v1170 : string = "_iter_try_for_each.map_err(|x| x.into())"
            let v1171 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v1170 
            let v1172 : Result<unit, string> = method127(v1171)
            let v1173 : string = v772 + v773 
            let x = v1172 //
            let v1174 : _ = x
            let v1175 : unit = ()
            (* run_target_args'
            let v1176 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1177 : string = $"true; let _fix_closure_v1175 = $0"
            let v1178 : bool = Fable.Core.RustInterop.emitRustExpr v1174 v1177 
            let _run_target_args'_v1176 = true 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1179 : string = $"true; let _fix_closure_v1175 = $0"
            let v1180 : bool = Fable.Core.RustInterop.emitRustExpr v1174 v1179 
            let _run_target_args'_v1176 = true 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1181 : string = $"true; let _fix_closure_v1175 = $0"
            let v1182 : bool = Fable.Core.RustInterop.emitRustExpr v1174 v1181 
            let _run_target_args'_v1176 = true 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let _run_target_args'_v1176 = false 
            #endif
#if FABLE_COMPILER_PYTHON
            let _run_target_args'_v1176 = false 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let _run_target_args'_v1176 = false 
            #endif
#else
            let _run_target_args'_v1176 = false 
            #endif
            let v1183 : bool = _run_target_args'_v1176 
            let v1185 : string = $"true; _fix_closure_v1175 " + v1173 + "); " + v772 + " // rust.fix_closure'"
            let v1186 : bool = Fable.Core.RustInterop.emitRustExpr () v1185 
            let v1187 : string = "__spawn"
            let v1188 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v1187 
            let v1190 : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US27) = method128()
            let v1191 : US27 option = v4 |> Option.map v1190 
            let v1204 : US27 = US27_1
            let v1205 : US27 = v1191 |> Option.defaultValue v1204 
            match v1205 with
            | US27_1 -> (* None *)
                ()
            | US27_0(v1209) -> (* Some *)
                let v1210 : string = "$0"
                let v1211 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v433 v1210 
                let v1212 : string = "v1211.lock()"
                let v1213 : Result<std_sync_MutexGuard<std_process_ChildStdin option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin option>>> = Fable.Core.RustInterop.emitRustExpr () v1212 
                (* run_target_args'
                let v1215 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1216 : string = "$0.unwrap()"
                let v1217 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1213 v1216 
                let _run_target_args'_v1215 = v1217 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1218 : string = "$0.unwrap()"
                let v1219 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1213 v1218 
                let _run_target_args'_v1215 = v1219 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1220 : string = "$0.unwrap()"
                let v1221 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1213 v1220 
                let _run_target_args'_v1215 = v1221 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1222 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1213 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1215 = v1222 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1223 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1213 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1215 = v1223 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v1224 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1213 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1215 = v1224 
                #endif
#else
                let v1225 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1213 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1215 = v1225 
                #endif
                let v1226 : std_sync_MutexGuard<std_process_ChildStdin option> = _run_target_args'_v1215 
                let v1229 : std_sync_MutexGuard<std_process_ChildStdin option> = method129(v1226)
                let v1230 : string = "true; let mut v1229 = v1229"
                let v1231 : bool = Fable.Core.RustInterop.emitRustExpr () v1230 
                let v1232 : string = "&mut $0"
                let v1233 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v1229 v1232 
                let v1234 : string = "Option::take($0)"
                let v1235 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v1233 v1234 
                let v1236 : string = "true; let _optionm_map_ = $0.map(|x| { //"
                let v1237 : bool = Fable.Core.RustInterop.emitRustExpr v1235 v1236 
                let v1238 : string = "x"
                let v1239 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr () v1238 
                let v1240 : string = "std::sync::Mutex::new(v1239)"
                let v1241 : std_sync_Mutex<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr () v1240 
                let v1242 : string = "std::sync::Arc::new(v1241)"
                let v1243 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr () v1242 
                let v1244 : string = "true; $0 })"
                let v1245 : bool = Fable.Core.RustInterop.emitRustExpr v1243 v1244 
                let v1246 : string = "_optionm_map_"
                let v1247 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> option = Fable.Core.RustInterop.emitRustExpr () v1246 
                let v1249 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US28) = method130()
                let v1250 : US28 option = v1247 |> Option.map v1249 
                let v1263 : US28 = US28_1
                let v1264 : US28 = v1250 |> Option.defaultValue v1263 
                match v1264 with
                | US28_1 -> (* None *)
                    ()
                | US28_0(v1268) -> (* Some *)
                    v1209 v1268
                    let v1269 : string = "$0"
                    let v1270 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr v1268 v1269 
                    let v1271 : string = "v1270.lock()"
                    let v1272 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr () v1271 
                    (* run_target_args'
                    let v1274 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1275 : string = "$0.unwrap()"
                    let v1276 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1272 v1275 
                    let _run_target_args'_v1274 = v1276 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1277 : string = "$0.unwrap()"
                    let v1278 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1272 v1277 
                    let _run_target_args'_v1274 = v1278 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1279 : string = "$0.unwrap()"
                    let v1280 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1272 v1279 
                    let _run_target_args'_v1274 = v1280 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1281 : std_sync_MutexGuard<std_process_ChildStdin> = match v1272 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1274 = v1281 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1282 : std_sync_MutexGuard<std_process_ChildStdin> = match v1272 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1274 = v1282 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1283 : std_sync_MutexGuard<std_process_ChildStdin> = match v1272 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1274 = v1283 
                    #endif
#else
                    let v1284 : std_sync_MutexGuard<std_process_ChildStdin> = match v1272 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1274 = v1284 
                    #endif
                    let v1285 : std_sync_MutexGuard<std_process_ChildStdin> = _run_target_args'_v1274 
                    let v1288 : std_sync_MutexGuard<std_process_ChildStdin> = method131(v1285)
                    let v1289 : string = "true; let mut v1288 = v1288"
                    let v1290 : bool = Fable.Core.RustInterop.emitRustExpr () v1289 
                    let v1291 : string = "true; std::io::Write::flush(&mut *$0).unwrap()"
                    let v1292 : bool = Fable.Core.RustInterop.emitRustExpr v1288 v1291 
                    ()
            let v1293 : string = "$0"
            let v1294 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v303 v1293 
            let v1295 : string = "v1294.lock()"
            let v1296 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v1295 
            (* run_target_args'
            let v1298 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1299 : string = "$0.unwrap()"
            let v1300 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1296 v1299 
            let _run_target_args'_v1298 = v1300 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1301 : string = "$0.unwrap()"
            let v1302 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1296 v1301 
            let _run_target_args'_v1298 = v1302 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1303 : string = "$0.unwrap()"
            let v1304 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1296 v1303 
            let _run_target_args'_v1298 = v1304 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1305 : std_sync_MutexGuard<std_process_Child option> = match v1296 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1298 = v1305 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1306 : std_sync_MutexGuard<std_process_Child option> = match v1296 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1298 = v1306 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1307 : std_sync_MutexGuard<std_process_Child option> = match v1296 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1298 = v1307 
            #endif
#else
            let v1308 : std_sync_MutexGuard<std_process_Child option> = match v1296 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1298 = v1308 
            #endif
            let v1309 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v1298 
            let v1312 : std_sync_MutexGuard<std_process_Child option> = method114(v1309)
            let v1313 : string = "true; let mut v1312 = v1312"
            let v1314 : bool = Fable.Core.RustInterop.emitRustExpr () v1313 
            let v1315 : string = "&mut $0"
            let v1316 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v1312 v1315 
            let v1317 : string = "Option::take($0)"
            let v1318 : std_process_Child option = Fable.Core.RustInterop.emitRustExpr v1316 v1317 
            let v1319 : string = "$0.unwrap()"
            let v1320 : std_process_Child = Fable.Core.RustInterop.emitRustExpr v1318 v1319 
            let v1321 : string = "$0.wait_with_output()"
            let v1322 : Result<std_process_Output, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1320 v1321 
            let v1323 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v1325 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1326 : string = "$0.map_err(|x| $1(x))"
            let v1327 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1322, v1323) v1326 
            let _run_target_args'_v1325 = v1327 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1328 : string = "$0.map_err(|x| $1(x))"
            let v1329 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1322, v1323) v1328 
            let _run_target_args'_v1325 = v1329 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1330 : string = "$0.map_err(|x| $1(x))"
            let v1331 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1322, v1323) v1330 
            let _run_target_args'_v1325 = v1331 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1332 : Result<std_process_Output, std_string_String> = match v1322 with Ok x -> Ok x | Error x -> Error (v1323 x)
            let _run_target_args'_v1325 = v1332 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1333 : Result<std_process_Output, std_string_String> = match v1322 with Ok x -> Ok x | Error x -> Error (v1323 x)
            let _run_target_args'_v1325 = v1333 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1334 : Result<std_process_Output, std_string_String> = match v1322 with Ok x -> Ok x | Error x -> Error (v1323 x)
            let _run_target_args'_v1325 = v1334 
            #endif
#else
            let v1335 : Result<std_process_Output, std_string_String> = match v1322 with Ok x -> Ok x | Error x -> Error (v1323 x)
            let _run_target_args'_v1325 = v1335 
            #endif
            let v1336 : Result<std_process_Output, std_string_String> = _run_target_args'_v1325 
            let v1339 : string = "v1188"
            let v1340 : string = v1339 + v772 
            let v1341 : string = v1340 + v772 
            let v1342 : string = "v789"
            let v1343 : string = ", "
            let v1344 : string = v1342 + v1343 
            let v1345 : string = v1344 + v1341 
            let v1346 : string = "vec![" + v1345 + "]"
            let v1347 : Vec<std_thread_JoinHandle<Result<unit, string>>> = Fable.Core.RustInterop.emitRustExpr () v1346 
            let v1348 : string = "true; $0.into_iter().for_each(|x| { //"
            let v1349 : bool = Fable.Core.RustInterop.emitRustExpr v1347 v1348 
            let v1350 : string = "x"
            let v1351 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v1350 
            let v1352 : string = "std::thread::JoinHandle::join($0)"
            let v1353 : Result<Result<unit, string>, Box<LifetimeRef<Dyn<LifetimeJoin<core_any_Any, LifetimeRef<LifetimeJoin<StaticLifetime, Send<StaticLifetime>>>>>>>> = Fable.Core.RustInterop.emitRustExpr v1351 v1352 
            (* run_target_args'
            let v1355 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1356 : string = "$0.unwrap()"
            let v1357 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1353 v1356 
            let _run_target_args'_v1355 = v1357 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1358 : string = "$0.unwrap()"
            let v1359 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1353 v1358 
            let _run_target_args'_v1355 = v1359 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1360 : string = "$0.unwrap()"
            let v1361 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1353 v1360 
            let _run_target_args'_v1355 = v1361 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1362 : Result<unit, string> = match v1353 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1355 = v1362 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1363 : Result<unit, string> = match v1353 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1355 = v1363 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1364 : Result<unit, string> = match v1353 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1355 = v1364 
            #endif
#else
            let v1365 : Result<unit, string> = match v1353 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1355 = v1365 
            #endif
            let v1366 : Result<unit, string> = _run_target_args'_v1355 
            (* run_target_args'
            let v1369 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1370 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1366 v1370 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1371 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1366 v1371 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1372 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1366 v1372 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            match v1366 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#if FABLE_COMPILER_PYTHON
            match v1366 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            match v1366 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#else
            match v1366 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
            // run_target_args' is_unit
            let v1373 : string = $"true"
            let v1374 : bool = Fable.Core.RustInterop.emitRustExpr () v1373 
            let v1375 : string = "true; }}); { //"
            let v1376 : bool = Fable.Core.RustInterop.emitRustExpr () v1375 
            let v1377 : (std_process_Output -> US29) = method132()
            let v1378 : (std_string_String -> US29) = method133()
            let v1379 : US29 = match v1336 with Ok x -> v1377 x | Error x -> v1378 x
            match v1379 with
            | US29_1(v1483) -> (* Error *)
                let v1484 : unit = ()
                let v1485 : (unit -> unit) = closure60(v1483)
                let v1486 : unit = (fun () -> v1485 (); v1484) ()
                let v1533 : US6 = US6_0(v1483)
                let v1534 : US25 = US25_1
                struct (-2, v1533, v1534)
            | US29_0(v1380) -> (* Ok *)
                let v1381 : string = "$0.status"
                let v1382 : std_process_ExitStatus = Fable.Core.RustInterop.emitRustExpr v1380 v1381 
                let v1383 : string = "$0.code()"
                let v1384 : int32 option = Fable.Core.RustInterop.emitRustExpr v1382 v1383 
                let v1386 : (int32 -> US30) = method135()
                let v1387 : US30 option = v1384 |> Option.map v1386 
                let v1400 : US30 = US30_1
                let v1401 : US30 = v1387 |> Option.defaultValue v1400 
                match v1401 with
                | US30_1 -> (* None *)
                    let v1408 : string = "runtime.execute_with_options / exit_code=None"
                    (* run_target_args'
                    let v1413 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1414 : string = "&*$0"
                    let v1415 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1408 v1414 
                    let _run_target_args'_v1413 = v1415 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1416 : string = "&*$0"
                    let v1417 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1408 v1416 
                    let _run_target_args'_v1413 = v1417 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1418 : string = "&*$0"
                    let v1419 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1408 v1418 
                    let _run_target_args'_v1413 = v1419 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1421 : Ref<Str> = v1408 |> unbox<Ref<Str>>
                    let _run_target_args'_v1413 = v1421 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1425 : Ref<Str> = v1408 |> unbox<Ref<Str>>
                    let _run_target_args'_v1413 = v1425 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1429 : Ref<Str> = v1408 |> unbox<Ref<Str>>
                    let _run_target_args'_v1413 = v1429 
                    #endif
#else
                    let v1433 : Ref<Str> = v1408 |> unbox<Ref<Str>>
                    let _run_target_args'_v1413 = v1433 
                    #endif
                    let v1436 : Ref<Str> = _run_target_args'_v1413 
                    (* run_target_args'
                    let v1446 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1447 : string = "String::from($0)"
                    let v1448 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1436 v1447 
                    let _run_target_args'_v1446 = v1448 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1449 : string = "String::from($0)"
                    let v1450 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1436 v1449 
                    let _run_target_args'_v1446 = v1450 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1451 : string = "String::from($0)"
                    let v1452 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1436 v1451 
                    let _run_target_args'_v1446 = v1452 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1454 : std_string_String = v1436 |> unbox<std_string_String>
                    let _run_target_args'_v1446 = v1454 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1458 : std_string_String = v1436 |> unbox<std_string_String>
                    let _run_target_args'_v1446 = v1458 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1462 : std_string_String = v1436 |> unbox<std_string_String>
                    let _run_target_args'_v1446 = v1462 
                    #endif
#else
                    let v1466 : std_string_String = v1436 |> unbox<std_string_String>
                    let _run_target_args'_v1446 = v1466 
                    #endif
                    let v1469 : std_string_String = _run_target_args'_v1446 
                    let v1475 : US6 = US6_0(v1469)
                    let v1476 : US25 = US25_0(v454)
                    struct (-1, v1475, v1476)
                | US30_0(v1405) -> (* Some *)
                    let v1406 : US6 = US6_1
                    let v1407 : US25 = US25_0(v454)
                    struct (v1405, v1406, v1407)
    let v1606 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option =
        match v1598 with
        | US25_1 -> (* None *)
            let v1604 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = None
            v1604
        | US25_0(v1599) -> (* Some *)
            let v1601 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = Some v1599 
            v1601
    let v1607 : string = "true; let _optionm_map_ = $0.map(|x| { //"
    let v1608 : bool = Fable.Core.RustInterop.emitRustExpr v1606 v1607 
    let v1609 : string = "x"
    let v1610 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v1609 
    let v1611 : string = "$0"
    let v1612 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr v1610 v1611 
    let v1613 : string = "v1612.lock()"
    let v1614 : Result<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v1613 
    (* run_target_args'
    let v1616 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1617 : string = "$0.unwrap()"
    let v1618 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v1614 v1617 
    let _run_target_args'_v1616 = v1618 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1619 : string = "$0.unwrap()"
    let v1620 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v1614 v1619 
    let _run_target_args'_v1616 = v1620 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1621 : string = "$0.unwrap()"
    let v1622 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v1614 v1621 
    let _run_target_args'_v1616 = v1622 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1623 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1614 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1616 = v1623 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1624 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1614 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1616 = v1624 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1625 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1614 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1616 = v1625 
    #endif
#else
    let v1626 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1614 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1616 = v1626 
    #endif
    let v1627 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = _run_target_args'_v1616 
    let v1630 : string = "$0.iter()"
    let v1631 : _ = Fable.Core.RustInterop.emitRustExpr v1627 v1630 
    let v1632 : string = "$0.collect::<Vec<_>>()"
    let v1633 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v1631 v1632 
    let v1634 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v1635 : bool = Fable.Core.RustInterop.emitRustExpr v1633 v1634 
    let v1636 : string = "x"
    let v1637 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1636 
    let v1638 : string = "fable_library_rust::String_::fromString($0)"
    let v1639 : string = Fable.Core.RustInterop.emitRustExpr v1637 v1638 
    let v1640 : string = "true; $0 }).collect::<Vec<_>>()"
    let v1641 : bool = Fable.Core.RustInterop.emitRustExpr v1639 v1640 
    let v1642 : string = "_vec_map"
    let v1643 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v1642 
    let v1644 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v1645 : (string []) = Fable.Core.RustInterop.emitRustExpr v1643 v1644 
    let v1647 : string seq = v1645 |> Seq.ofArray
    let v1651 : string = method136()
    let v1652 : (string -> (string seq -> string)) = String.concat
    let v1653 : (string seq -> string) = v1652 v1651
    let v1654 : string = v1653 v1647
    let v1658 : string = "true; $0 })"
    let v1659 : bool = Fable.Core.RustInterop.emitRustExpr v1654 v1658 
    let v1660 : string = "_optionm_map_"
    let v1661 : string option = Fable.Core.RustInterop.emitRustExpr () v1660 
    let v1668 : US5 =
        match v1597 with
        | US6_1 -> (* None *)
            US5_1
        | US6_0(v1662) -> (* Some *)
            let v1663 : string = "fable_library_rust::String_::fromString($0)"
            let v1664 : string = Fable.Core.RustInterop.emitRustExpr v1662 v1663 
            US5_0(v1664)
    let v1672 : string =
        match v1668 with
        | US5_1 -> (* None *)
            let v1670 : string = ""
            v1670
        | US5_0(v1669) -> (* Some *)
            v1669
    let v1674 : string = v1661 |> Option.defaultValue v1672 
    let v1677 : unit = ()
    let v1678 : (unit -> unit) = closure62(v1596, v1674)
    let v1679 : unit = (fun () -> v1678 (); v1677) ()
    let v1728 : (int32 * string) = v1596, v1674 
    v1728 
    )
    |> fun x -> x ()
    ) () )
    |> fun x -> _capture_v175 <- Some x
    let v1731 : (int32 * string) = match _capture_v175 with Some x -> x | None -> failwith "base.capture / _capture_v175=None"
    let (a, b) = v1731 
    let v3288 : int32 = a
    let v3289 : string = b
    let _run_target_args'_v15 = struct (v3288, v3289) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v3296 : int32, v3297 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v3296, v3297) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v3304 : int32, v3305 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v3304, v3305) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v3312 : int32, v3313 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v3312, v3313) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v3320 : int32, v3321 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v3320, v3321) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v3328 : int32, v3329 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v3328, v3329) 
    #endif
#else
    let v3334 : Async<struct (int32 * string)> = method139(v0, v1, v2, v3, v4, v5, v6)
    (* run_target_args'
    let v3343 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v3346 : int32, v3347 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v3343 = struct (v3346, v3347) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v3354 : int32, v3355 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v3343 = struct (v3354, v3355) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v3362 : int32, v3363 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v3343 = struct (v3362, v3363) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v3370 : int32, v3371 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v3343 = struct (v3370, v3371) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3376 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v3377 : int32, v3378 : string) = v3376 v3334
    let _run_target_args'_v3343 = struct (v3377, v3378) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v3379 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v3380 : int32, v3381 : string) = v3379 v3334
    let _run_target_args'_v3343 = struct (v3380, v3381) 
    #endif
#else
    let v3382 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v3383 : int32, v3384 : string) = v3382 v3334
    let _run_target_args'_v3343 = struct (v3383, v3384) 
    #endif
    let struct (v3385 : int32, v3386 : string) = _run_target_args'_v3343 
    let _run_target_args'_v15 = struct (v3385, v3386) 
    #endif
    let struct (v3391 : int32, v3392 : string) = _run_target_args'_v15 
    struct (v3391, v3392)
and method158 (v0 : string, v1 : string, v2 : string) : struct (string * string) =
    let v3 : string = method47(v1)
    let v4 : string = method28(v2, v3)
    let v5 : string = "."
    let v6 : int32 = v1.LastIndexOf v5 
    let v7 : int32 = v6 - 1
    let v9 : string = v1.[int 0..int v7]
    let v13 : int32 = v4.LastIndexOf v5 
    let v14 : int32 = v13 - 1
    let v16 : string = v4.[int 0..int v14]
    let v21 : string = ".md"
    let v22 : bool = v0.EndsWith (v21, false, null)
    let v25 : bool = v22 = false
    let v28 : string =
        if v25 then
            let v26 : string = $"{v1}.{v0}"
            v26
        else
            let v27 : string = $"{v9}.{v0}"
            v27
    let v31 : string =
        if v25 then
            let v29 : string = $"{v4}.{v0}"
            v29
        else
            let v30 : string = $"{v16}.{v0}"
            v30
    struct (v28, v31)
and method159 () : string =
    let v0 : string = ""
    v0
and closure71 () (v0 : string) : US34 =
    US34_0(v0)
and method160 () : (string -> US34) =
    closure71()
and closure72 () (v0 : std_string_String) : US34 =
    US34_1(v0)
and method161 () : (std_string_String -> US34) =
    closure72()
and method163 (v0 : string, v1 : string, v2 : string, v3 : int32, v4 : string, v5 : int32, v6 : string, v7 : string, v8 : US5, v9 : string, v10 : string) : string =
    let v11 : string = method14()
    let v12 : Mut3 = {l0 = v11} : Mut3
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure8(v12, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v24 : string = "file"
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure8(v12, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v34 : string = " = "
    let v35 : string = $"{v34}"
    let v38 : unit = ()
    let v39 : (unit -> unit) = closure8(v12, v35)
    let v40 : unit = (fun () -> v39 (); v38) ()
    let v44 : string = $"{v0}"
    let v47 : unit = ()
    let v48 : (unit -> unit) = closure8(v12, v44)
    let v49 : unit = (fun () -> v48 (); v47) ()
    let v53 : string = "; "
    let v54 : string = $"{v53}"
    let v57 : unit = ()
    let v58 : (unit -> unit) = closure8(v12, v54)
    let v59 : unit = (fun () -> v58 (); v57) ()
    let v63 : string = "real_path"
    let v64 : string = $"{v63}"
    let v67 : unit = ()
    let v68 : (unit -> unit) = closure8(v12, v64)
    let v69 : unit = (fun () -> v68 (); v67) ()
    let v73 : string = $"{v34}"
    let v76 : unit = ()
    let v77 : (unit -> unit) = closure8(v12, v73)
    let v78 : unit = (fun () -> v77 (); v76) ()
    let v82 : string = $"{v1}"
    let v85 : unit = ()
    let v86 : (unit -> unit) = closure8(v12, v82)
    let v87 : unit = (fun () -> v86 (); v85) ()
    let v91 : string = $"{v53}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure8(v12, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v100 : string = "relative_path"
    let v101 : string = $"{v100}"
    let v104 : unit = ()
    let v105 : (unit -> unit) = closure8(v12, v101)
    let v106 : unit = (fun () -> v105 (); v104) ()
    let v110 : string = $"{v34}"
    let v113 : unit = ()
    let v114 : (unit -> unit) = closure8(v12, v110)
    let v115 : unit = (fun () -> v114 (); v113) ()
    let v119 : string = $"{v2}"
    let v122 : unit = ()
    let v123 : (unit -> unit) = closure8(v12, v119)
    let v124 : unit = (fun () -> v123 (); v122) ()
    let v128 : string = $"{v53}"
    let v131 : unit = ()
    let v132 : (unit -> unit) = closure8(v12, v128)
    let v133 : unit = (fun () -> v132 (); v131) ()
    let v137 : string = "origin_hash_exit_code"
    let v138 : string = $"{v137}"
    let v141 : unit = ()
    let v142 : (unit -> unit) = closure8(v12, v138)
    let v143 : unit = (fun () -> v142 (); v141) ()
    let v147 : string = $"{v34}"
    let v150 : unit = ()
    let v151 : (unit -> unit) = closure8(v12, v147)
    let v152 : unit = (fun () -> v151 (); v150) ()
    let v156 : string = $"{v3}"
    let v159 : unit = ()
    let v160 : (unit -> unit) = closure8(v12, v156)
    let v161 : unit = (fun () -> v160 (); v159) ()
    let v165 : string = $"{v53}"
    let v168 : unit = ()
    let v169 : (unit -> unit) = closure8(v12, v165)
    let v170 : unit = (fun () -> v169 (); v168) ()
    let v174 : string = "origin_hash"
    let v175 : string = $"{v174}"
    let v178 : unit = ()
    let v179 : (unit -> unit) = closure8(v12, v175)
    let v180 : unit = (fun () -> v179 (); v178) ()
    let v184 : string = $"{v34}"
    let v187 : unit = ()
    let v188 : (unit -> unit) = closure8(v12, v184)
    let v189 : unit = (fun () -> v188 (); v187) ()
    let v193 : string = $"{v4}"
    let v196 : unit = ()
    let v197 : (unit -> unit) = closure8(v12, v193)
    let v198 : unit = (fun () -> v197 (); v196) ()
    let v202 : string = $"{v53}"
    let v205 : unit = ()
    let v206 : (unit -> unit) = closure8(v12, v202)
    let v207 : unit = (fun () -> v206 (); v205) ()
    let v211 : string = "local_git_hash_exit_code"
    let v212 : string = $"{v211}"
    let v215 : unit = ()
    let v216 : (unit -> unit) = closure8(v12, v212)
    let v217 : unit = (fun () -> v216 (); v215) ()
    let v221 : string = $"{v34}"
    let v224 : unit = ()
    let v225 : (unit -> unit) = closure8(v12, v221)
    let v226 : unit = (fun () -> v225 (); v224) ()
    let v230 : string = $"{v5}"
    let v233 : unit = ()
    let v234 : (unit -> unit) = closure8(v12, v230)
    let v235 : unit = (fun () -> v234 (); v233) ()
    let v239 : string = $"{v53}"
    let v242 : unit = ()
    let v243 : (unit -> unit) = closure8(v12, v239)
    let v244 : unit = (fun () -> v243 (); v242) ()
    let v248 : string = "local_git_hash"
    let v249 : string = $"{v248}"
    let v252 : unit = ()
    let v253 : (unit -> unit) = closure8(v12, v249)
    let v254 : unit = (fun () -> v253 (); v252) ()
    let v258 : string = $"{v34}"
    let v261 : unit = ()
    let v262 : (unit -> unit) = closure8(v12, v258)
    let v263 : unit = (fun () -> v262 (); v261) ()
    let v267 : string = $"{v6}"
    let v270 : unit = ()
    let v271 : (unit -> unit) = closure8(v12, v267)
    let v272 : unit = (fun () -> v271 (); v270) ()
    let v276 : string = $"{v53}"
    let v279 : unit = ()
    let v280 : (unit -> unit) = closure8(v12, v276)
    let v281 : unit = (fun () -> v280 (); v279) ()
    let v285 : string = "hash1"
    let v286 : string = $"{v285}"
    let v289 : unit = ()
    let v290 : (unit -> unit) = closure8(v12, v286)
    let v291 : unit = (fun () -> v290 (); v289) ()
    let v295 : string = $"{v34}"
    let v298 : unit = ()
    let v299 : (unit -> unit) = closure8(v12, v295)
    let v300 : unit = (fun () -> v299 (); v298) ()
    let v304 : string = $"{v7}"
    let v307 : unit = ()
    let v308 : (unit -> unit) = closure8(v12, v304)
    let v309 : unit = (fun () -> v308 (); v307) ()
    let v313 : string = $"{v53}"
    let v316 : unit = ()
    let v317 : (unit -> unit) = closure8(v12, v313)
    let v318 : unit = (fun () -> v317 (); v316) ()
    let v322 : string = "hash2"
    let v323 : string = $"{v322}"
    let v326 : unit = ()
    let v327 : (unit -> unit) = closure8(v12, v323)
    let v328 : unit = (fun () -> v327 (); v326) ()
    let v332 : string = $"{v34}"
    let v335 : unit = ()
    let v336 : (unit -> unit) = closure8(v12, v332)
    let v337 : unit = (fun () -> v336 (); v335) ()
    let v341 : string = $"%A{v8}"
    let v345 : string = $"{v341}"
    let v348 : unit = ()
    let v349 : (unit -> unit) = closure8(v12, v345)
    let v350 : unit = (fun () -> v349 (); v348) ()
    let v354 : string = $"{v53}"
    let v357 : unit = ()
    let v358 : (unit -> unit) = closure8(v12, v354)
    let v359 : unit = (fun () -> v358 (); v357) ()
    let v363 : string = "dist_path"
    let v364 : string = $"{v363}"
    let v367 : unit = ()
    let v368 : (unit -> unit) = closure8(v12, v364)
    let v369 : unit = (fun () -> v368 (); v367) ()
    let v373 : string = $"{v34}"
    let v376 : unit = ()
    let v377 : (unit -> unit) = closure8(v12, v373)
    let v378 : unit = (fun () -> v377 (); v376) ()
    let v382 : string = $"{v9}"
    let v385 : unit = ()
    let v386 : (unit -> unit) = closure8(v12, v382)
    let v387 : unit = (fun () -> v386 (); v385) ()
    let v391 : string = $"{v53}"
    let v394 : unit = ()
    let v395 : (unit -> unit) = closure8(v12, v391)
    let v396 : unit = (fun () -> v395 (); v394) ()
    let v400 : string = "cache_path"
    let v401 : string = $"{v400}"
    let v404 : unit = ()
    let v405 : (unit -> unit) = closure8(v12, v401)
    let v406 : unit = (fun () -> v405 (); v404) ()
    let v410 : string = $"{v34}"
    let v413 : unit = ()
    let v414 : (unit -> unit) = closure8(v12, v410)
    let v415 : unit = (fun () -> v414 (); v413) ()
    let v419 : string = $"{v10}"
    let v422 : unit = ()
    let v423 : (unit -> unit) = closure8(v12, v419)
    let v424 : unit = (fun () -> v423 (); v422) ()
    let v428 : string = " }"
    let v429 : string = $"{v428}"
    let v432 : unit = ()
    let v433 : (unit -> unit) = closure8(v12, v429)
    let v434 : unit = (fun () -> v433 (); v432) ()
    let v437 : string = v12.l0
    v437
and method162 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : string, v12 : int32, v13 : string, v14 : int32, v15 : string, v16 : string, v17 : US5, v18 : string, v19 : string) : string =
    let v20 : string = method163(v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19)
    let v21 : int64 = v0.l0
    let v23 : string = $"{v6} {v7} #{v21} %s{v8} / {v20}"
    method18(v23)
and closure73 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : int32, v5 : string, v6 : string, v7 : int32, v8 : string, v9 : string, v10 : US5) () : unit =
    let v11 : US0 = US0_2
    let v12 : bool = method7(v11)
    if v12 then
        let v13 : unit = ()
        let v14 : (unit -> unit) = closure6()
        let v15 : unit = (fun () -> v14 (); v13) ()
        let struct (v36 : Mut0, v37 : Mut1, v38 : Mut2, v39 : Mut3, v40 : Mut4, v41 : int64 option) = TraceState.trace_state.Value
        let v54 : string = method8(v36, v37, v38, v39, v40, v41)
        let v55 : string = method12()
        let v56 : string = "documents.run / par_map"
        let v57 : string = " / origin_hash |> sm'.contains local_git_hash |> not"
        let v58 : string = v56 + v57 
        let v59 : string = " / Some hash2 when hash1 = hash2"
        let v60 : string = v58 + v59 
        let v61 : bool = v60 = ""
        let v64 : string =
            if v61 then
                let v62 : string = ""
                v62
            else
                method162(v36, v37, v38, v39, v40, v41, v54, v55, v60, v1, v2, v0, v4, v3, v7, v6, v9, v10, v5, v8)
        method19(v64)
and closure74 () (v0 : uint64) : US35 =
    US35_0(v0)
and method165 () : (uint64 -> US35) =
    closure74()
and closure75 () (v0 : std_string_String) : US35 =
    US35_1(v0)
and method166 () : (std_string_String -> US35) =
    closure75()
and method168 (v0 : string, v1 : string, v2 : std_string_String) : string =
    let v3 : string = method14()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure8(v4, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v16 : string = "old_path"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure8(v4, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v26 : string = " = "
    let v27 : string = $"{v26}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure8(v4, v27)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v36 : string = $"{v0}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure8(v4, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v45 : string = "; "
    let v46 : string = $"{v45}"
    let v49 : unit = ()
    let v50 : (unit -> unit) = closure8(v4, v46)
    let v51 : unit = (fun () -> v50 (); v49) ()
    let v55 : string = "new_path"
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure8(v4, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v65 : string = $"{v26}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure8(v4, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v74 : string = $"{v1}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure8(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v83 : string = $"{v45}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v92 : string = "error"
    let v93 : string = $"{v92}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure8(v4, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v102 : string = $"{v26}"
    let v105 : unit = ()
    let v106 : (unit -> unit) = closure8(v4, v102)
    let v107 : unit = (fun () -> v106 (); v105) ()
    (* run_target_args'
    let v114 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v115 : string = "format!(\"{:#?}\", $0)"
    let v116 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v115 
    let v117 : string = "fable_library_rust::String_::fromString($0)"
    let v118 : string = Fable.Core.RustInterop.emitRustExpr v116 v117 
    let _run_target_args'_v114 = v118 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v119 : string = "format!(\"{:#?}\", $0)"
    let v120 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v119 
    let v121 : string = "fable_library_rust::String_::fromString($0)"
    let v122 : string = Fable.Core.RustInterop.emitRustExpr v120 v121 
    let _run_target_args'_v114 = v122 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v123 : string = "format!(\"{:#?}\", $0)"
    let v124 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v123 
    let v125 : string = "fable_library_rust::String_::fromString($0)"
    let v126 : string = Fable.Core.RustInterop.emitRustExpr v124 v125 
    let _run_target_args'_v114 = v126 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v128 : string = $"%A{v2}"
    let _run_target_args'_v114 = v128 
    #endif
#if FABLE_COMPILER_PYTHON
    let v132 : string = $"%A{v2}"
    let _run_target_args'_v114 = v132 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v136 : string = $"%A{v2}"
    let _run_target_args'_v114 = v136 
    #endif
#else
    let v140 : string = $"%A{v2}"
    let _run_target_args'_v114 = v140 
    #endif
    let v143 : string = _run_target_args'_v114 
    let v150 : string = $"{v143}"
    let v153 : unit = ()
    let v154 : (unit -> unit) = closure8(v4, v150)
    let v155 : unit = (fun () -> v154 (); v153) ()
    let v159 : string = " }"
    let v160 : string = $"{v159}"
    let v163 : unit = ()
    let v164 : (unit -> unit) = closure8(v4, v160)
    let v165 : unit = (fun () -> v164 (); v163) ()
    let v168 : string = v4.l0
    v168
and method167 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : std_string_String) : string =
    let v11 : string = method168(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v14 : string = "file_system.file_copy"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method18(v15)
and closure76 (v0 : string, v1 : string, v2 : std_string_String) () : unit =
    let v3 : US0 = US0_3
    let v4 : bool = method7(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut0, v29 : Mut1, v30 : Mut2, v31 : Mut3, v32 : Mut4, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method8(v28, v29, v30, v31, v32, v33)
        let v47 : string = method35()
        let v48 : string = method167(v28, v29, v30, v31, v32, v33, v46, v47, v1, v0, v2)
        method19(v48)
and method170 (v0 : string, v1 : string, v2 : uint64) : string =
    let v3 : string = method14()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure8(v4, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v16 : string = "old_path"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure8(v4, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v26 : string = " = "
    let v27 : string = $"{v26}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure8(v4, v27)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v36 : string = $"{v0}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure8(v4, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v45 : string = "; "
    let v46 : string = $"{v45}"
    let v49 : unit = ()
    let v50 : (unit -> unit) = closure8(v4, v46)
    let v51 : unit = (fun () -> v50 (); v49) ()
    let v55 : string = "new_path"
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure8(v4, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v65 : string = $"{v26}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure8(v4, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v74 : string = $"{v1}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure8(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v83 : string = $"{v45}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v92 : string = "result"
    let v93 : string = $"{v92}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure8(v4, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v102 : string = $"{v26}"
    let v105 : unit = ()
    let v106 : (unit -> unit) = closure8(v4, v102)
    let v107 : unit = (fun () -> v106 (); v105) ()
    let v111 : string = $"{v2}"
    let v114 : unit = ()
    let v115 : (unit -> unit) = closure8(v4, v111)
    let v116 : unit = (fun () -> v115 (); v114) ()
    let v120 : string = " }"
    let v121 : string = $"{v120}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure8(v4, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v129 : string = v4.l0
    v129
and method169 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : uint64) : string =
    let v11 : string = method170(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v14 : string = "file_system.file_copy"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method18(v15)
and closure77 (v0 : string, v1 : string, v2 : uint64) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method7(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut0, v29 : Mut1, v30 : Mut2, v31 : Mut3, v32 : Mut4, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method8(v28, v29, v30, v31, v32, v33)
        let v47 : string = method66()
        let v48 : string = method169(v28, v29, v30, v31, v32, v33, v46, v47, v1, v0, v2)
        method19(v48)
and method164 (v0 : string, v1 : string) : unit =
    (* run_target_args'
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "std::fs::copy(&*$0, &*$1)"
    let v4 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr struct (v1, v0) v3 
    let v5 : (std_io_Error -> std_string_String) = method69()
    (* run_target_args'
    let v7 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "$0.map_err(|x| $1(x))"
    let v9 : Result<uint64, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4, v5) v8 
    let _run_target_args'_v7 = v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : string = "$0.map_err(|x| $1(x))"
    let v11 : Result<uint64, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4, v5) v10 
    let _run_target_args'_v7 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : string = "$0.map_err(|x| $1(x))"
    let v13 : Result<uint64, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4, v5) v12 
    let _run_target_args'_v7 = v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : Result<uint64, std_string_String> = match v4 with Ok x -> Ok x | Error x -> Error (v5 x)
    let _run_target_args'_v7 = v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : Result<uint64, std_string_String> = match v4 with Ok x -> Ok x | Error x -> Error (v5 x)
    let _run_target_args'_v7 = v15 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v16 : Result<uint64, std_string_String> = match v4 with Ok x -> Ok x | Error x -> Error (v5 x)
    let _run_target_args'_v7 = v16 
    #endif
#else
    let v17 : Result<uint64, std_string_String> = match v4 with Ok x -> Ok x | Error x -> Error (v5 x)
    let _run_target_args'_v7 = v17 
    #endif
    let v18 : Result<uint64, std_string_String> = _run_target_args'_v7 
    let v21 : (uint64 -> US35) = method165()
    let v22 : (std_string_String -> US35) = method166()
    let v23 : US35 = match v18 with Ok x -> v21 x | Error x -> v22 x
    match v23 with
    | US35_1(v74) -> (* Error *)
        let v75 : unit = ()
        let v76 : (unit -> unit) = closure76(v0, v1, v74)
        let v77 : unit = (fun () -> v76 (); v75) ()
        ()
    | US35_0(v24) -> (* Ok *)
        let v25 : unit = ()
        let v26 : (unit -> unit) = closure77(v0, v1, v24)
        let v27 : unit = (fun () -> v26 (); v25) ()
        ()
    #endif
#if FABLE_COMPILER_RUST && WASM
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    #endif
#if FABLE_COMPILER_PYTHON
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    #endif
#else
    System.IO.File.Copy (v1, v0, true)
    #endif
    // run_target_args' is_unit
    ()
and method172 (v0 : Vec<uint8>) : Vec<uint8> =
    v0
and method173 (v0 : int32, v1 : Mut7) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method174 (v0 : string) : string =
    v0
and method175 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure80 (v0 : string) (v1 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : unit =
    let v2 : string = "$0"
    let v3 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : string = "v3.lock()"
    let v5 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr () v4 
    (* run_target_args'
    let v7 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "$0.unwrap()"
    let v9 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v5 v8 
    let _run_target_args'_v7 = v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : string = "$0.unwrap()"
    let v11 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v5 v10 
    let _run_target_args'_v7 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : string = "$0.unwrap()"
    let v13 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v5 v12 
    let _run_target_args'_v7 = v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : std_sync_MutexGuard<std_process_ChildStdin> = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v7 = v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : std_sync_MutexGuard<std_process_ChildStdin> = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v7 = v15 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v16 : std_sync_MutexGuard<std_process_ChildStdin> = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v7 = v16 
    #endif
#else
    let v17 : std_sync_MutexGuard<std_process_ChildStdin> = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v7 = v17 
    #endif
    let v18 : std_sync_MutexGuard<std_process_ChildStdin> = _run_target_args'_v7 
    let v21 : string = method174(v0)
    let v22 : string = "v21.as_bytes()"
    let v23 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : std_sync_MutexGuard<std_process_ChildStdin> = method175(v18)
    let v25 : string = "true; let mut v24 = v24"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr () v25 
    let v27 : string = "true; std::io::Write::write_all(&mut *$0, v23).unwrap()"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v24 v27 
    ()
and method176 (v0 : int32, v1 : Mut8) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method178 (v0 : int32, v1 : int32, v2 : string) : string =
    let v3 : string = method14()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure8(v4, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v16 : string = "exit_code"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure8(v4, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v26 : string = " = "
    let v27 : string = $"{v26}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure8(v4, v27)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v36 : string = $"{v0}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure8(v4, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v45 : string = "; "
    let v46 : string = $"{v45}"
    let v49 : unit = ()
    let v50 : (unit -> unit) = closure8(v4, v46)
    let v51 : unit = (fun () -> v50 (); v49) ()
    let v55 : string = "result_len"
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure8(v4, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v65 : string = $"{v26}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure8(v4, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v74 : string = $"{v1}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure8(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v83 : string = $"{v45}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v92 : string = "output_path"
    let v93 : string = $"{v92}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure8(v4, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v102 : string = $"{v26}"
    let v105 : unit = ()
    let v106 : (unit -> unit) = closure8(v4, v102)
    let v107 : unit = (fun () -> v106 (); v105) ()
    let v111 : string = $"{v2}"
    let v114 : unit = ()
    let v115 : (unit -> unit) = closure8(v4, v111)
    let v116 : unit = (fun () -> v115 (); v114) ()
    let v120 : string = " }"
    let v121 : string = $"{v120}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure8(v4, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v129 : string = v4.l0
    v129
and method177 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32, v10 : string) : string =
    let v11 : string = method178(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v14 : string = "documents.hangul"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method18(v15)
and closure81 (v0 : string, v1 : int32, v2 : string) () : unit =
    let v3 : US0 = US0_2
    let v4 : bool = method7(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut0, v29 : Mut1, v30 : Mut2, v31 : Mut3, v32 : Mut4, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method8(v28, v29, v30, v31, v32, v33)
        let v47 : string = method12()
        let v48 : int32 = v2.Length
        let v49 : string = method177(v28, v29, v30, v31, v32, v33, v46, v47, v1, v48, v0)
        method19(v49)
and method171 (v0 : string, v1 : string, v2 : string, v3 : string) : US36 =
    (* run_target_args'
    let v8 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    (* run_target_args'
    let v13 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = "std::fs::read(&*$0)"
    let v15 : Result<Vec<uint8>, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v3 v14 
    (* run_target_args'
    let v17 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = "$0.unwrap()"
    let v19 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v15 v18 
    let _run_target_args'_v17 = v19 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = "$0.unwrap()"
    let v21 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v15 v20 
    let _run_target_args'_v17 = v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = "$0.unwrap()"
    let v23 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v15 v22 
    let _run_target_args'_v17 = v23 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v24 : Vec<uint8> = match v15 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v17 = v24 
    #endif
#if FABLE_COMPILER_PYTHON
    let v25 : Vec<uint8> = match v15 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v17 = v25 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v26 : Vec<uint8> = match v15 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v17 = v26 
    #endif
#else
    let v27 : Vec<uint8> = match v15 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v17 = v27 
    #endif
    let v28 : Vec<uint8> = _run_target_args'_v17 
    let _run_target_args'_v13 = v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : Vec<uint8> = null |> unbox<Vec<uint8>>
    let _run_target_args'_v13 = v32 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v36 : Vec<uint8> = null |> unbox<Vec<uint8>>
    let _run_target_args'_v13 = v36 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v40 : Vec<uint8> = null |> unbox<Vec<uint8>>
    let _run_target_args'_v13 = v40 
    #endif
#if FABLE_COMPILER_PYTHON
    let v44 : Vec<uint8> = null |> unbox<Vec<uint8>>
    let _run_target_args'_v13 = v44 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v48 : Vec<uint8> = null |> unbox<Vec<uint8>>
    let _run_target_args'_v13 = v48 
    #endif
#else
    let v51 : (uint8 []) = v3 |> System.IO.File.ReadAllBytes
    let v52 : string = "$0.to_vec()"
    let v53 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v51 v52 
    let _run_target_args'_v13 = v53 
    #endif
    let v54 : Vec<uint8> = _run_target_args'_v13 
    let v60 : Vec<uint8> = method172(v54)
    let v61 : string = "std::string::String::from_utf8($0)"
    let v62 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr v60 v61 
    (* run_target_args'
    let v64 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v65 : string = "$0.unwrap()"
    let v66 : std_string_String = Fable.Core.RustInterop.emitRustExpr v62 v65 
    let _run_target_args'_v64 = v66 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v67 : string = "$0.unwrap()"
    let v68 : std_string_String = Fable.Core.RustInterop.emitRustExpr v62 v67 
    let _run_target_args'_v64 = v68 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v69 : string = "$0.unwrap()"
    let v70 : std_string_String = Fable.Core.RustInterop.emitRustExpr v62 v69 
    let _run_target_args'_v64 = v70 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v71 : std_string_String = match v62 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v64 = v71 
    #endif
#if FABLE_COMPILER_PYTHON
    let v72 : std_string_String = match v62 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v64 = v72 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v73 : std_string_String = match v62 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v64 = v73 
    #endif
#else
    let v74 : std_string_String = match v62 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v64 = v74 
    #endif
    let v75 : std_string_String = _run_target_args'_v64 
    let v78 : string = "fable_library_rust::String_::fromString($0)"
    let v79 : string = Fable.Core.RustInterop.emitRustExpr v75 v78 
    let _run_target_args'_v8 = v79 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v81 : string = null |> unbox<string>
    let _run_target_args'_v8 = v81 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v85 : string = null |> unbox<string>
    let _run_target_args'_v8 = v85 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v89 : string = null |> unbox<string>
    let _run_target_args'_v8 = v89 
    #endif
#if FABLE_COMPILER_PYTHON
    let v93 : string = null |> unbox<string>
    let _run_target_args'_v8 = v93 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v97 : string = null |> unbox<string>
    let _run_target_args'_v8 = v97 
    #endif
#else
    let v100 : string = v3 |> System.IO.File.ReadAllText
    let _run_target_args'_v8 = v100 
    #endif
    let v101 : string = _run_target_args'_v8 
    let v108 : string = "\n"
    let v109 : (string []) = v101.Split v108 
    let v112 : int32 = v109.Length
    let v113 : (string []) = Array.zeroCreate<string> (v112)
    let v114 : Mut6 = {l0 = 0} : Mut6
    while method63(v112, v114) do
        let v116 : int32 = v114.l0
        let v117 : string = v109.[int v116]
        let v119 : (unit -> string) = v117.Trim
        let v120 : string = v119 ()
        v113.[int v116] <- v120
        let v123 : int32 = v116 + 1
        v114.l0 <- v123
        ()
    let v124 : int32 = v113.Length
    let v125 : (string []) = Array.zeroCreate<string> (v124)
    let v126 : Mut7 = {l0 = 0; l1 = 0} : Mut7
    while method173(v124, v126) do
        let v128 : int32 = v126.l0
        let v129 : int32 = v126.l1
        let v130 : string = v113.[int v128]
        let v133 : string = ""
        let v134 : bool = v130 <> v133 
        let v138 : int32 =
            if v134 then
                v125.[int v129] <- v130
                let v137 : int32 = v129 + 1
                v137
            else
                v129
        let v139 : int32 = v128 + 1
        v126.l0 <- v139
        v126.l1 <- v138
        ()
    let v140 : int32 = v126.l1
    let v141 : (string []) = Array.zeroCreate<string> (v140)
    let v142 : Mut6 = {l0 = 0} : Mut6
    while method63(v140, v142) do
        let v144 : int32 = v142.l0
        let v145 : string = v125.[int v144]
        v141.[int v144] <- v145
        let v146 : int32 = v144 + 1
        v142.l0 <- v146
        ()
    let v150 : unit = ()
    let _let'_v150 =
        seq {
            for i = 0 to v141.Length - 1 do yield v141.[i]
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v153 : string seq = _let'_v150 
    let v160 : string = method136()
    let v161 : (string -> (string seq -> string)) = String.concat
    let v162 : (string seq -> string) = v161 v160
    let v163 : string = v162 v153
    let v166 : string = $"{v163}

"
    let v167 : System.Threading.CancellationToken option = None
    let v168 : (struct (string * string) []) = [||]
    let v169 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v170 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v171 : string option = None
    (* run_target_args'
    let v176 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v177 : string = "cfg!(windows)"
    let v178 : bool = Fable.Core.RustInterop.emitRustExpr () v177 
    let _run_target_args'_v176 = v178 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v179 : string = "cfg!(windows)"
    let v180 : bool = Fable.Core.RustInterop.emitRustExpr () v179 
    let _run_target_args'_v176 = v180 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v181 : string = "cfg!(windows)"
    let v182 : bool = Fable.Core.RustInterop.emitRustExpr () v181 
    let _run_target_args'_v176 = v182 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v183 : US3 = US3_0
    let v184 : US4 = US4_4(v183)
    let v185 : string = $"platform.is_windows / target: {v184}"
    let v186 : bool = failwith<bool> v185
    let _run_target_args'_v176 = v186 
    #endif
#if FABLE_COMPILER_PYTHON
    let v187 : US3 = US3_0
    let v188 : US4 = US4_5(v187)
    let v189 : string = $"platform.is_windows / target: {v188}"
    let v190 : bool = failwith<bool> v189
    let _run_target_args'_v176 = v190 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v191 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v192 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v193 : bool = v192 v191
    let _run_target_args'_v176 = v193 
    #endif
#else
    let v194 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v195 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v196 : bool = v195 v194
    let _run_target_args'_v176 = v196 
    #endif
    let v197 : bool = _run_target_args'_v176 
    let v205 : string =
        if v197 then
            let v203 : string = ".exe"
            v203
        else
            let v204 : string = ""
            v204
    let v206 : string = $"../alphabet/deps/hangulize/cmd/hangulize/hangulize{v205}"
    let v207 : string = method28(v0, v206)
    let v208 : string = $"{v207} {v1}"
    let v210 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) = closure80(v166)
    let v211 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = Some v210 
    let v214 : bool = true
    let struct (v215 : int32, v216 : string) = method83(v208, v167, v168, v169, v211, v214, v171)
    let v218 : (string []) = v216.Split v108 
    let v221 : int32 = v218.Length
    let v222 : string = ""
    let v223 : Mut8 = {l0 = 0; l1 = v222; l2 = 0; l3 = 0} : Mut8
    while method176(v124, v223) do
        let v225 : int32 = v223.l0
        let struct (v226 : string, v227 : int32, v228 : int32) = v223.l1, v223.l2, v223.l3
        let v229 : string = v113.[int v225]
        let v230 : bool = v229 = ""
        let struct (v253 : string, v254 : int32, v255 : int32) =
            if v230 then
                let v231 : string = $"{v226}
"
                let v232 : int32 = v227 + 1
                let v233 : int32 = v228 + 1
                struct (v231, v232, v233)
            else
                let v234 : int32 = v227 - v228
                let v235 : bool = v234 >= v221
                let v251 : string =
                    if v235 then
                        v226
                    else
                        let v237 : string = v218.[int v234]
                        let v241 : string = "://"
                        let v242 : bool = v237.Contains v241 
                        let v245 : string =
                            if v242 then
                                v229
                            else
                                v237
                        let v246 : int32 = v221 - 1
                        let v247 : bool = v234 = v246
                        if v247 then
                            let v248 : string = $"{v226}{v245}"
                            v248
                        else
                            let v249 : string = $"{v226}{v245}
"
                            v249
                let v252 : int32 = v227 + 1
                struct (v251, v252, v228)
        let v256 : int32 = v225 + 1
        v223.l0 <- v256
        v223.l1 <- v253
        v223.l2 <- v254
        v223.l3 <- v255
        ()
    let struct (v257 : string, v258 : int32, v259 : int32) = v223.l1, v223.l2, v223.l3
    (* run_target_args'
    let v260 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v261 : string = "std::fs::write(&*$0, &*$1).unwrap()"
    Fable.Core.RustInterop.emitRustExpr struct (v2, v257) v261 
    #endif
#if FABLE_COMPILER_RUST && WASM
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    #endif
#if FABLE_COMPILER_PYTHON
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    #endif
#else
    System.IO.File.WriteAllText (v2, v257)
    #endif
    // run_target_args' is_unit
    let v262 : unit = ()
    let v263 : (unit -> unit) = closure81(v2, v215, v257)
    let v264 : unit = (fun () -> v263 (); v262) ()
    US36_0(v215, v257)
and method180 (v0 : int32, v1 : string) : string =
    let v2 : string = method14()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure8(v3, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v15 : string = "exit_code"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure8(v3, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v25 : string = " = "
    let v26 : string = $"{v25}"
    let v29 : unit = ()
    let v30 : (unit -> unit) = closure8(v3, v26)
    let v31 : unit = (fun () -> v30 (); v29) ()
    let v35 : string = $"{v0}"
    let v38 : unit = ()
    let v39 : (unit -> unit) = closure8(v3, v35)
    let v40 : unit = (fun () -> v39 (); v38) ()
    let v44 : string = "; "
    let v45 : string = $"{v44}"
    let v48 : unit = ()
    let v49 : (unit -> unit) = closure8(v3, v45)
    let v50 : unit = (fun () -> v49 (); v48) ()
    let v54 : string = "result"
    let v55 : string = $"{v54}"
    let v58 : unit = ()
    let v59 : (unit -> unit) = closure8(v3, v55)
    let v60 : unit = (fun () -> v59 (); v58) ()
    let v64 : string = $"{v25}"
    let v67 : unit = ()
    let v68 : (unit -> unit) = closure8(v3, v64)
    let v69 : unit = (fun () -> v68 (); v67) ()
    let v73 : string = $"{v1}"
    let v76 : unit = ()
    let v77 : (unit -> unit) = closure8(v3, v73)
    let v78 : unit = (fun () -> v77 (); v76) ()
    let v82 : string = " }"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v3, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = v3.l0
    v91
and method179 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method180(v8, v9)
    let v11 : int64 = v0.l0
    let v13 : string = "documents.files_fn / error"
    let v14 : string = $"{v6} {v7} #{v11} %s{v13} / {v10}"
    method18(v14)
and closure82 (v0 : string, v1 : int32) () : unit =
    let v2 : US0 = US0_2
    let v3 : bool = method7(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method8(v27, v28, v29, v30, v31, v32)
        let v46 : string = method12()
        let v47 : string = method179(v27, v28, v29, v30, v31, v32, v45, v46, v1, v0)
        method19(v47)
and closure79 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) (v5 : string) : US33 =
    let struct (v6 : string, v7 : string) = method158(v5, v4, v0)
    let v8 : bool = method30(v6)
    let v9 : bool = v8 = false
    let v12 : bool =
        if v9 then
            true
        else
            let v10 : bool = method30(v7)
            let v11 : bool = v10 = false
            v11
    let v338 : bool =
        if v12 then
            false
        else
            let v13 : string = method38(v6)
            let v14 : string = "std::fs::File::open(&*v13)"
            let v15 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v14 
            (* run_target_args'
            let v17 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v18 : string = "$0.unwrap()"
            let v19 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v15 v18 
            let _run_target_args'_v17 = v19 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v20 : string = "$0.unwrap()"
            let v21 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v15 v20 
            let _run_target_args'_v17 = v21 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v22 : string = "$0.unwrap()"
            let v23 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v15 v22 
            let _run_target_args'_v17 = v23 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v24 : std_fs_File = match v15 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v17 = v24 
            #endif
#if FABLE_COMPILER_PYTHON
            let v25 : std_fs_File = match v15 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v17 = v25 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v26 : std_fs_File = match v15 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v17 = v26 
            #endif
#else
            let v27 : std_fs_File = match v15 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v17 = v27 
            #endif
            let v28 : std_fs_File = _run_target_args'_v17 
            let v31 : string = "std::io::BufReader::new($0)"
            let v32 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v28 v31 
            let v33 : string = "std::io::BufReader::new($0)"
            let v34 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v32 v33 
            let v35 : string = "true; let mut v34 = v34"
            let v36 : bool = Fable.Core.RustInterop.emitRustExpr () v35 
            let v37 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v37 
            let v38 : string = "result"
            let v39 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v38 
            let v40 : string = "true; let mut v39 = v39"
            let v41 : bool = Fable.Core.RustInterop.emitRustExpr () v40 
            let v43 : unativeint = 0 |> unativeint 
            let v46 : string = "[$0; 1024]"
            let v47 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v46 
            let v48 : string = "true; loop { // rust.loop"
            let v49 : bool = Fable.Core.RustInterop.emitRustExpr () v48 
            let v50 : string = "true; let mut v47 = v47"
            let v51 : bool = Fable.Core.RustInterop.emitRustExpr () v50 
            let v52 : string = "std::io::Read::read(&mut v34, &mut v47)"
            let v53 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v52 
            (* run_target_args'
            let v55 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v56 : string = "$0.unwrap()"
            let v57 : unativeint = Fable.Core.RustInterop.emitRustExpr v53 v56 
            let _run_target_args'_v55 = v57 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v58 : string = "$0.unwrap()"
            let v59 : unativeint = Fable.Core.RustInterop.emitRustExpr v53 v58 
            let _run_target_args'_v55 = v59 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v60 : string = "$0.unwrap()"
            let v61 : unativeint = Fable.Core.RustInterop.emitRustExpr v53 v60 
            let _run_target_args'_v55 = v61 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v62 : unativeint = match v53 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v55 = v62 
            #endif
#if FABLE_COMPILER_PYTHON
            let v63 : unativeint = match v53 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v55 = v63 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v64 : unativeint = match v53 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v55 = v64 
            #endif
#else
            let v65 : unativeint = match v53 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v55 = v65 
            #endif
            let v66 : unativeint = _run_target_args'_v55 
            let v70 : bool = v66 = v43 
            if v70 then
                let v73 : string = "true; break"
                let v74 : bool = Fable.Core.RustInterop.emitRustExpr () v73 
                ()
            let v76 : unativeint = v66 |> unativeint 
            let v80 : unativeint = v76 |> unbox<unativeint>
            let v83 : string = "v47.len()"
            let v84 : unativeint = Fable.Core.RustInterop.emitRustExpr () v83 
            let v86 : bool = v80 = v84 
            let v93 : Ref<Slice'<uint8>> =
                if v86 then
                    let v89 : string = "&v47[v43..]"
                    let v90 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v89 
                    v90
                else
                    let v91 : string = "&v47[$0..$1]"
                    let v92 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v43, v76) v91 
                    v92
            let v94 : string = "sha2::Digest::update(&mut v39, v93)"
            Fable.Core.RustInterop.emitRustExpr () v94 
            let v95 : string = "true; } // rust.loop"
            let v96 : bool = Fable.Core.RustInterop.emitRustExpr () v95 
            let v97 : string = "true; } // rust.loop"
            let v98 : bool = Fable.Core.RustInterop.emitRustExpr () v97 
            let v99 : string = "true; } // rust.loop"
            let v100 : bool = Fable.Core.RustInterop.emitRustExpr () v99 
            let v101 : string = "true; { // rust.loop"
            let v102 : bool = Fable.Core.RustInterop.emitRustExpr () v101 
            let v103 : string = "true; { // rust.loop"
            let v104 : bool = Fable.Core.RustInterop.emitRustExpr () v103 
            let v105 : string = "&sha2::Digest::finalize(v39)"
            let v106 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v105 
            let v107 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v108 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v106 v107 
            let v109 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v110 : bool = Fable.Core.RustInterop.emitRustExpr v108 v109 
            let v111 : string = "x"
            let v112 : uint8 = Fable.Core.RustInterop.emitRustExpr () v111 
            let v113 : string = "format!(\"{:02x}\", $0)"
            let v114 : std_string_String = Fable.Core.RustInterop.emitRustExpr v112 v113 
            let v115 : string = "fable_library_rust::String_::fromString($0)"
            let v116 : string = Fable.Core.RustInterop.emitRustExpr v114 v115 
            let v117 : string = "true; $0 }).collect::<Vec<_>>()"
            let v118 : bool = Fable.Core.RustInterop.emitRustExpr v116 v117 
            let v119 : string = "_vec_map"
            let v120 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v119 
            let v121 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v122 : (string []) = Fable.Core.RustInterop.emitRustExpr v120 v121 
            let v126 : unit = ()
            let _let'_v126 =
                seq {
                    for i = 0 to v122.Length - 1 do yield v122.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v129 : string seq = _let'_v126 
            let v135 : string = method159()
            let v137 : bool = v135 = "\n"
            let v139 : string =
                if v137 then
                    method65(v135)
                else
                    v135
            let v140 : (string -> (string seq -> string)) = String.concat
            let v141 : (string seq -> string) = v140 v139
            let v142 : string = v141 v129
            let v145 : Result<string, std_io_Error> = Ok v142 
            let v146 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v148 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v149 : string = "$0.map_err(|x| $1(x))"
            let v150 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v145, v146) v149 
            let _run_target_args'_v148 = v150 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v151 : string = "$0.map_err(|x| $1(x))"
            let v152 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v145, v146) v151 
            let _run_target_args'_v148 = v152 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v153 : string = "$0.map_err(|x| $1(x))"
            let v154 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v145, v146) v153 
            let _run_target_args'_v148 = v154 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v155 : Result<string, std_string_String> = match v145 with Ok x -> Ok x | Error x -> Error (v146 x)
            let _run_target_args'_v148 = v155 
            #endif
#if FABLE_COMPILER_PYTHON
            let v156 : Result<string, std_string_String> = match v145 with Ok x -> Ok x | Error x -> Error (v146 x)
            let _run_target_args'_v148 = v156 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v157 : Result<string, std_string_String> = match v145 with Ok x -> Ok x | Error x -> Error (v146 x)
            let _run_target_args'_v148 = v157 
            #endif
#else
            let v158 : Result<string, std_string_String> = match v145 with Ok x -> Ok x | Error x -> Error (v146 x)
            let _run_target_args'_v148 = v158 
            #endif
            let v159 : Result<string, std_string_String> = _run_target_args'_v148 
            let v162 : (string -> US34) = method160()
            let v163 : (std_string_String -> US34) = method161()
            let v164 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v165 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v162, v163, v159) v164 
            let v174 : string =
                match v165 with
                | US34_1(v167) -> (* Error *)
                    let v169 : string = $"resultm.get / Result value was Error: {v167}"
                    failwith<string> v169
                | US34_0(v166) -> (* Ok *)
                    v166
            let v175 : string = method38(v7)
            let v176 : string = "std::fs::File::open(&*v175)"
            let v177 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v176 
            (* run_target_args'
            let v179 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v180 : string = "$0.unwrap()"
            let v181 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v177 v180 
            let _run_target_args'_v179 = v181 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v182 : string = "$0.unwrap()"
            let v183 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v177 v182 
            let _run_target_args'_v179 = v183 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v184 : string = "$0.unwrap()"
            let v185 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v177 v184 
            let _run_target_args'_v179 = v185 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v186 : std_fs_File = match v177 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v179 = v186 
            #endif
#if FABLE_COMPILER_PYTHON
            let v187 : std_fs_File = match v177 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v179 = v187 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v188 : std_fs_File = match v177 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v179 = v188 
            #endif
#else
            let v189 : std_fs_File = match v177 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v179 = v189 
            #endif
            let v190 : std_fs_File = _run_target_args'_v179 
            let v193 : string = "std::io::BufReader::new($0)"
            let v194 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v190 v193 
            let v195 : string = "std::io::BufReader::new($0)"
            let v196 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v194 v195 
            let v197 : string = "true; let mut v196 = v196"
            let v198 : bool = Fable.Core.RustInterop.emitRustExpr () v197 
            let v199 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v199 
            let v200 : string = "result"
            let v201 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v200 
            let v202 : string = "true; let mut v201 = v201"
            let v203 : bool = Fable.Core.RustInterop.emitRustExpr () v202 
            let v205 : unativeint = 0 |> unativeint 
            let v208 : string = "[$0; 1024]"
            let v209 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v208 
            let v210 : string = "true; loop { // rust.loop"
            let v211 : bool = Fable.Core.RustInterop.emitRustExpr () v210 
            let v212 : string = "true; let mut v209 = v209"
            let v213 : bool = Fable.Core.RustInterop.emitRustExpr () v212 
            let v214 : string = "std::io::Read::read(&mut v196, &mut v209)"
            let v215 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v214 
            (* run_target_args'
            let v217 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v218 : string = "$0.unwrap()"
            let v219 : unativeint = Fable.Core.RustInterop.emitRustExpr v215 v218 
            let _run_target_args'_v217 = v219 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v220 : string = "$0.unwrap()"
            let v221 : unativeint = Fable.Core.RustInterop.emitRustExpr v215 v220 
            let _run_target_args'_v217 = v221 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v222 : string = "$0.unwrap()"
            let v223 : unativeint = Fable.Core.RustInterop.emitRustExpr v215 v222 
            let _run_target_args'_v217 = v223 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v224 : unativeint = match v215 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v217 = v224 
            #endif
#if FABLE_COMPILER_PYTHON
            let v225 : unativeint = match v215 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v217 = v225 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v226 : unativeint = match v215 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v217 = v226 
            #endif
#else
            let v227 : unativeint = match v215 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v217 = v227 
            #endif
            let v228 : unativeint = _run_target_args'_v217 
            let v232 : bool = v228 = v205 
            if v232 then
                let v235 : string = "true; break"
                let v236 : bool = Fable.Core.RustInterop.emitRustExpr () v235 
                ()
            let v238 : unativeint = v228 |> unativeint 
            let v242 : unativeint = v238 |> unbox<unativeint>
            let v245 : string = "v209.len()"
            let v246 : unativeint = Fable.Core.RustInterop.emitRustExpr () v245 
            let v248 : bool = v242 = v246 
            let v255 : Ref<Slice'<uint8>> =
                if v248 then
                    let v251 : string = "&v209[v205..]"
                    let v252 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v251 
                    v252
                else
                    let v253 : string = "&v209[$0..$1]"
                    let v254 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v205, v238) v253 
                    v254
            let v256 : string = "sha2::Digest::update(&mut v201, v255)"
            Fable.Core.RustInterop.emitRustExpr () v256 
            let v257 : string = "true; } // rust.loop"
            let v258 : bool = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "true; } // rust.loop"
            let v260 : bool = Fable.Core.RustInterop.emitRustExpr () v259 
            let v261 : string = "true; } // rust.loop"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr () v261 
            let v263 : string = "true; { // rust.loop"
            let v264 : bool = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "true; { // rust.loop"
            let v266 : bool = Fable.Core.RustInterop.emitRustExpr () v265 
            let v267 : string = "&sha2::Digest::finalize(v201)"
            let v268 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v267 
            let v269 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v270 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v268 v269 
            let v271 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v272 : bool = Fable.Core.RustInterop.emitRustExpr v270 v271 
            let v273 : string = "x"
            let v274 : uint8 = Fable.Core.RustInterop.emitRustExpr () v273 
            let v275 : string = "format!(\"{:02x}\", $0)"
            let v276 : std_string_String = Fable.Core.RustInterop.emitRustExpr v274 v275 
            let v277 : string = "fable_library_rust::String_::fromString($0)"
            let v278 : string = Fable.Core.RustInterop.emitRustExpr v276 v277 
            let v279 : string = "true; $0 }).collect::<Vec<_>>()"
            let v280 : bool = Fable.Core.RustInterop.emitRustExpr v278 v279 
            let v281 : string = "_vec_map"
            let v282 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v281 
            let v283 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v284 : (string []) = Fable.Core.RustInterop.emitRustExpr v282 v283 
            let v288 : unit = ()
            let _let'_v288 =
                seq {
                    for i = 0 to v284.Length - 1 do yield v284.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v291 : string seq = _let'_v288 
            let v297 : string = method159()
            let v299 : bool = v297 = "\n"
            let v301 : string =
                if v299 then
                    method65(v297)
                else
                    v297
            let v302 : (string -> (string seq -> string)) = String.concat
            let v303 : (string seq -> string) = v302 v301
            let v304 : string = v303 v291
            let v307 : Result<string, std_io_Error> = Ok v304 
            let v308 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v310 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v311 : string = "$0.map_err(|x| $1(x))"
            let v312 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v307, v308) v311 
            let _run_target_args'_v310 = v312 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v313 : string = "$0.map_err(|x| $1(x))"
            let v314 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v307, v308) v313 
            let _run_target_args'_v310 = v314 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v315 : string = "$0.map_err(|x| $1(x))"
            let v316 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v307, v308) v315 
            let _run_target_args'_v310 = v316 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v317 : Result<string, std_string_String> = match v307 with Ok x -> Ok x | Error x -> Error (v308 x)
            let _run_target_args'_v310 = v317 
            #endif
#if FABLE_COMPILER_PYTHON
            let v318 : Result<string, std_string_String> = match v307 with Ok x -> Ok x | Error x -> Error (v308 x)
            let _run_target_args'_v310 = v318 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v319 : Result<string, std_string_String> = match v307 with Ok x -> Ok x | Error x -> Error (v308 x)
            let _run_target_args'_v310 = v319 
            #endif
#else
            let v320 : Result<string, std_string_String> = match v307 with Ok x -> Ok x | Error x -> Error (v308 x)
            let _run_target_args'_v310 = v320 
            #endif
            let v321 : Result<string, std_string_String> = _run_target_args'_v310 
            let v324 : (string -> US34) = method160()
            let v325 : (std_string_String -> US34) = method161()
            let v326 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v327 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v324, v325, v321) v326 
            let v336 : string =
                match v327 with
                | US34_1(v329) -> (* Error *)
                    let v331 : string = $"resultm.get / Result value was Error: {v329}"
                    failwith<string> v331
                | US34_0(v328) -> (* Ok *)
                    v328
            let v337 : bool = v174 = v336
            v337
    if v338 then
        US33_1
    else
        let v340 : US36 = method171(v2, v3, v6, v4)
        match v340 with
        | US36_1(v407, v408) -> (* Error *)
            let v410 : (string * string) = v6, v408 
            let v413 : Result<string, (string * string)> = Error v410 
            US33_0(v413)
        | US36_0(v341, v342) -> (* Ok *)
            let v344 : bool = v341 <> 0 
            if v344 then
                let v347 : unit = ()
                let v348 : (unit -> unit) = closure82(v342, v341)
                let v349 : unit = (fun () -> v348 (); v347) ()
                let v397 : (string * string) = v6, v342 
                let v400 : Result<string, (string * string)> = Error v397 
                US33_0(v400)
            else
                let v402 : bool = method30(v6)
                if v402 then
                    method164(v7, v6)
                else
                    let v403 : string = $"documents.files_fn / {v6} should exist"
                    failwith<unit> v403
                let v404 : Result<string, (string * string)> = Ok v6 
                US33_0(v404)
and closure78 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : string) : (string -> US33) =
    closure79(v0, v1, v2, v3, v4)
and method183 (v0 : int32, v1 : string, v2 : string) : string =
    let v3 : string = method14()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure8(v4, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v16 : string = "exit_code"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure8(v4, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v26 : string = " = "
    let v27 : string = $"{v26}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure8(v4, v27)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v36 : string = $"{v0}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure8(v4, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v45 : string = "; "
    let v46 : string = $"{v45}"
    let v49 : unit = ()
    let v50 : (unit -> unit) = closure8(v4, v46)
    let v51 : unit = (fun () -> v50 (); v49) ()
    let v55 : string = "output_path"
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure8(v4, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v65 : string = $"{v26}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure8(v4, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v74 : string = $"{v1}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure8(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v83 : string = $"{v45}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v92 : string = "result"
    let v93 : string = $"{v92}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure8(v4, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v102 : string = $"{v26}"
    let v105 : unit = ()
    let v106 : (unit -> unit) = closure8(v4, v102)
    let v107 : unit = (fun () -> v106 (); v105) ()
    let v111 : string = $"{v2}"
    let v114 : unit = ()
    let v115 : (unit -> unit) = closure8(v4, v111)
    let v116 : unit = (fun () -> v115 (); v114) ()
    let v120 : string = " }"
    let v121 : string = $"{v120}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure8(v4, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v129 : string = v4.l0
    v129
and method182 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string, v10 : string) : string =
    let v11 : string = method183(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v14 : string = "documents.crowbook / result contains ERROR"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method18(v15)
and closure85 (v0 : string, v1 : string, v2 : int32) () : unit =
    let v3 : US0 = US0_3
    let v4 : bool = method7(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut0, v29 : Mut1, v30 : Mut2, v31 : Mut3, v32 : Mut4, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method8(v28, v29, v30, v31, v32, v33)
        let v47 : string = method35()
        let v48 : string = method182(v28, v29, v30, v31, v32, v33, v46, v47, v2, v0, v1)
        method19(v48)
and method181 (v0 : bool, v1 : string, v2 : string, v3 : string, v4 : string) : US36 =
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
    let v71 : string option = Some v3 
    let v74 : bool = true
    let struct (v75 : int32, v76 : string) = method83(v69, v62, v63, v64, v65, v74, v71)
    let v78 : string = "ERROR"
    let v79 : bool = v76.Contains v78 
    let v82 : bool = v79 = false
    if v82 then
        US36_0(v75, v76)
    else
        let v84 : unit = ()
        let v85 : (unit -> unit) = closure85(v1, v76, v75)
        let v86 : unit = (fun () -> v85 (); v84) ()
        US36_1(v75, v76)
and closure84 (v0 : string, v1 : string, v2 : bool, v3 : string) (v4 : string) : US33 =
    let struct (v5 : string, v6 : string) = method158(v4, v3, v0)
    let v7 : bool = method30(v5)
    let v8 : bool = v7 = false
    let v11 : bool =
        if v8 then
            true
        else
            let v9 : bool = method30(v6)
            let v10 : bool = v9 = false
            v10
    let v337 : bool =
        if v11 then
            false
        else
            let v12 : string = method38(v5)
            let v13 : string = "std::fs::File::open(&*v12)"
            let v14 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v13 
            (* run_target_args'
            let v16 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17 : string = "$0.unwrap()"
            let v18 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v14 v17 
            let _run_target_args'_v16 = v18 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v19 : string = "$0.unwrap()"
            let v20 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v14 v19 
            let _run_target_args'_v16 = v20 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v21 : string = "$0.unwrap()"
            let v22 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v14 v21 
            let _run_target_args'_v16 = v22 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v23 : std_fs_File = match v14 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v16 = v23 
            #endif
#if FABLE_COMPILER_PYTHON
            let v24 : std_fs_File = match v14 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v16 = v24 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v25 : std_fs_File = match v14 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v16 = v25 
            #endif
#else
            let v26 : std_fs_File = match v14 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v16 = v26 
            #endif
            let v27 : std_fs_File = _run_target_args'_v16 
            let v30 : string = "std::io::BufReader::new($0)"
            let v31 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v27 v30 
            let v32 : string = "std::io::BufReader::new($0)"
            let v33 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v31 v32 
            let v34 : string = "true; let mut v33 = v33"
            let v35 : bool = Fable.Core.RustInterop.emitRustExpr () v34 
            let v36 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v36 
            let v37 : string = "result"
            let v38 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v37 
            let v39 : string = "true; let mut v38 = v38"
            let v40 : bool = Fable.Core.RustInterop.emitRustExpr () v39 
            let v42 : unativeint = 0 |> unativeint 
            let v45 : string = "[$0; 1024]"
            let v46 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v45 
            let v47 : string = "true; loop { // rust.loop"
            let v48 : bool = Fable.Core.RustInterop.emitRustExpr () v47 
            let v49 : string = "true; let mut v46 = v46"
            let v50 : bool = Fable.Core.RustInterop.emitRustExpr () v49 
            let v51 : string = "std::io::Read::read(&mut v33, &mut v46)"
            let v52 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v51 
            (* run_target_args'
            let v54 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v55 : string = "$0.unwrap()"
            let v56 : unativeint = Fable.Core.RustInterop.emitRustExpr v52 v55 
            let _run_target_args'_v54 = v56 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v57 : string = "$0.unwrap()"
            let v58 : unativeint = Fable.Core.RustInterop.emitRustExpr v52 v57 
            let _run_target_args'_v54 = v58 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v59 : string = "$0.unwrap()"
            let v60 : unativeint = Fable.Core.RustInterop.emitRustExpr v52 v59 
            let _run_target_args'_v54 = v60 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v61 : unativeint = match v52 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v54 = v61 
            #endif
#if FABLE_COMPILER_PYTHON
            let v62 : unativeint = match v52 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v54 = v62 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v63 : unativeint = match v52 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v54 = v63 
            #endif
#else
            let v64 : unativeint = match v52 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v54 = v64 
            #endif
            let v65 : unativeint = _run_target_args'_v54 
            let v69 : bool = v65 = v42 
            if v69 then
                let v72 : string = "true; break"
                let v73 : bool = Fable.Core.RustInterop.emitRustExpr () v72 
                ()
            let v75 : unativeint = v65 |> unativeint 
            let v79 : unativeint = v75 |> unbox<unativeint>
            let v82 : string = "v46.len()"
            let v83 : unativeint = Fable.Core.RustInterop.emitRustExpr () v82 
            let v85 : bool = v79 = v83 
            let v92 : Ref<Slice'<uint8>> =
                if v85 then
                    let v88 : string = "&v46[v42..]"
                    let v89 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v88 
                    v89
                else
                    let v90 : string = "&v46[$0..$1]"
                    let v91 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v42, v75) v90 
                    v91
            let v93 : string = "sha2::Digest::update(&mut v38, v92)"
            Fable.Core.RustInterop.emitRustExpr () v93 
            let v94 : string = "true; } // rust.loop"
            let v95 : bool = Fable.Core.RustInterop.emitRustExpr () v94 
            let v96 : string = "true; } // rust.loop"
            let v97 : bool = Fable.Core.RustInterop.emitRustExpr () v96 
            let v98 : string = "true; } // rust.loop"
            let v99 : bool = Fable.Core.RustInterop.emitRustExpr () v98 
            let v100 : string = "true; { // rust.loop"
            let v101 : bool = Fable.Core.RustInterop.emitRustExpr () v100 
            let v102 : string = "true; { // rust.loop"
            let v103 : bool = Fable.Core.RustInterop.emitRustExpr () v102 
            let v104 : string = "&sha2::Digest::finalize(v38)"
            let v105 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v104 
            let v106 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v107 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v105 v106 
            let v108 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v109 : bool = Fable.Core.RustInterop.emitRustExpr v107 v108 
            let v110 : string = "x"
            let v111 : uint8 = Fable.Core.RustInterop.emitRustExpr () v110 
            let v112 : string = "format!(\"{:02x}\", $0)"
            let v113 : std_string_String = Fable.Core.RustInterop.emitRustExpr v111 v112 
            let v114 : string = "fable_library_rust::String_::fromString($0)"
            let v115 : string = Fable.Core.RustInterop.emitRustExpr v113 v114 
            let v116 : string = "true; $0 }).collect::<Vec<_>>()"
            let v117 : bool = Fable.Core.RustInterop.emitRustExpr v115 v116 
            let v118 : string = "_vec_map"
            let v119 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v118 
            let v120 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v121 : (string []) = Fable.Core.RustInterop.emitRustExpr v119 v120 
            let v125 : unit = ()
            let _let'_v125 =
                seq {
                    for i = 0 to v121.Length - 1 do yield v121.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v128 : string seq = _let'_v125 
            let v134 : string = method159()
            let v136 : bool = v134 = "\n"
            let v138 : string =
                if v136 then
                    method65(v134)
                else
                    v134
            let v139 : (string -> (string seq -> string)) = String.concat
            let v140 : (string seq -> string) = v139 v138
            let v141 : string = v140 v128
            let v144 : Result<string, std_io_Error> = Ok v141 
            let v145 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v147 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v148 : string = "$0.map_err(|x| $1(x))"
            let v149 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v144, v145) v148 
            let _run_target_args'_v147 = v149 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v150 : string = "$0.map_err(|x| $1(x))"
            let v151 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v144, v145) v150 
            let _run_target_args'_v147 = v151 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v152 : string = "$0.map_err(|x| $1(x))"
            let v153 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v144, v145) v152 
            let _run_target_args'_v147 = v153 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v154 : Result<string, std_string_String> = match v144 with Ok x -> Ok x | Error x -> Error (v145 x)
            let _run_target_args'_v147 = v154 
            #endif
#if FABLE_COMPILER_PYTHON
            let v155 : Result<string, std_string_String> = match v144 with Ok x -> Ok x | Error x -> Error (v145 x)
            let _run_target_args'_v147 = v155 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v156 : Result<string, std_string_String> = match v144 with Ok x -> Ok x | Error x -> Error (v145 x)
            let _run_target_args'_v147 = v156 
            #endif
#else
            let v157 : Result<string, std_string_String> = match v144 with Ok x -> Ok x | Error x -> Error (v145 x)
            let _run_target_args'_v147 = v157 
            #endif
            let v158 : Result<string, std_string_String> = _run_target_args'_v147 
            let v161 : (string -> US34) = method160()
            let v162 : (std_string_String -> US34) = method161()
            let v163 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v164 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v161, v162, v158) v163 
            let v173 : string =
                match v164 with
                | US34_1(v166) -> (* Error *)
                    let v168 : string = $"resultm.get / Result value was Error: {v166}"
                    failwith<string> v168
                | US34_0(v165) -> (* Ok *)
                    v165
            let v174 : string = method38(v6)
            let v175 : string = "std::fs::File::open(&*v174)"
            let v176 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v175 
            (* run_target_args'
            let v178 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v179 : string = "$0.unwrap()"
            let v180 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v176 v179 
            let _run_target_args'_v178 = v180 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v181 : string = "$0.unwrap()"
            let v182 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v176 v181 
            let _run_target_args'_v178 = v182 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v183 : string = "$0.unwrap()"
            let v184 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v176 v183 
            let _run_target_args'_v178 = v184 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v185 : std_fs_File = match v176 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v178 = v185 
            #endif
#if FABLE_COMPILER_PYTHON
            let v186 : std_fs_File = match v176 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v178 = v186 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v187 : std_fs_File = match v176 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v178 = v187 
            #endif
#else
            let v188 : std_fs_File = match v176 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v178 = v188 
            #endif
            let v189 : std_fs_File = _run_target_args'_v178 
            let v192 : string = "std::io::BufReader::new($0)"
            let v193 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v189 v192 
            let v194 : string = "std::io::BufReader::new($0)"
            let v195 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v193 v194 
            let v196 : string = "true; let mut v195 = v195"
            let v197 : bool = Fable.Core.RustInterop.emitRustExpr () v196 
            let v198 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v198 
            let v199 : string = "result"
            let v200 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v199 
            let v201 : string = "true; let mut v200 = v200"
            let v202 : bool = Fable.Core.RustInterop.emitRustExpr () v201 
            let v204 : unativeint = 0 |> unativeint 
            let v207 : string = "[$0; 1024]"
            let v208 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v207 
            let v209 : string = "true; loop { // rust.loop"
            let v210 : bool = Fable.Core.RustInterop.emitRustExpr () v209 
            let v211 : string = "true; let mut v208 = v208"
            let v212 : bool = Fable.Core.RustInterop.emitRustExpr () v211 
            let v213 : string = "std::io::Read::read(&mut v195, &mut v208)"
            let v214 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v213 
            (* run_target_args'
            let v216 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v217 : string = "$0.unwrap()"
            let v218 : unativeint = Fable.Core.RustInterop.emitRustExpr v214 v217 
            let _run_target_args'_v216 = v218 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v219 : string = "$0.unwrap()"
            let v220 : unativeint = Fable.Core.RustInterop.emitRustExpr v214 v219 
            let _run_target_args'_v216 = v220 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v221 : string = "$0.unwrap()"
            let v222 : unativeint = Fable.Core.RustInterop.emitRustExpr v214 v221 
            let _run_target_args'_v216 = v222 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : unativeint = match v214 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v216 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v224 : unativeint = match v214 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v216 = v224 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v225 : unativeint = match v214 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v216 = v225 
            #endif
#else
            let v226 : unativeint = match v214 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v216 = v226 
            #endif
            let v227 : unativeint = _run_target_args'_v216 
            let v231 : bool = v227 = v204 
            if v231 then
                let v234 : string = "true; break"
                let v235 : bool = Fable.Core.RustInterop.emitRustExpr () v234 
                ()
            let v237 : unativeint = v227 |> unativeint 
            let v241 : unativeint = v237 |> unbox<unativeint>
            let v244 : string = "v208.len()"
            let v245 : unativeint = Fable.Core.RustInterop.emitRustExpr () v244 
            let v247 : bool = v241 = v245 
            let v254 : Ref<Slice'<uint8>> =
                if v247 then
                    let v250 : string = "&v208[v204..]"
                    let v251 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v250 
                    v251
                else
                    let v252 : string = "&v208[$0..$1]"
                    let v253 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v204, v237) v252 
                    v253
            let v255 : string = "sha2::Digest::update(&mut v200, v254)"
            Fable.Core.RustInterop.emitRustExpr () v255 
            let v256 : string = "true; } // rust.loop"
            let v257 : bool = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "true; } // rust.loop"
            let v259 : bool = Fable.Core.RustInterop.emitRustExpr () v258 
            let v260 : string = "true; } // rust.loop"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr () v260 
            let v262 : string = "true; { // rust.loop"
            let v263 : bool = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "true; { // rust.loop"
            let v265 : bool = Fable.Core.RustInterop.emitRustExpr () v264 
            let v266 : string = "&sha2::Digest::finalize(v200)"
            let v267 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v266 
            let v268 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v269 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v267 v268 
            let v270 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v271 : bool = Fable.Core.RustInterop.emitRustExpr v269 v270 
            let v272 : string = "x"
            let v273 : uint8 = Fable.Core.RustInterop.emitRustExpr () v272 
            let v274 : string = "format!(\"{:02x}\", $0)"
            let v275 : std_string_String = Fable.Core.RustInterop.emitRustExpr v273 v274 
            let v276 : string = "fable_library_rust::String_::fromString($0)"
            let v277 : string = Fable.Core.RustInterop.emitRustExpr v275 v276 
            let v278 : string = "true; $0 }).collect::<Vec<_>>()"
            let v279 : bool = Fable.Core.RustInterop.emitRustExpr v277 v278 
            let v280 : string = "_vec_map"
            let v281 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v280 
            let v282 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v283 : (string []) = Fable.Core.RustInterop.emitRustExpr v281 v282 
            let v287 : unit = ()
            let _let'_v287 =
                seq {
                    for i = 0 to v283.Length - 1 do yield v283.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v290 : string seq = _let'_v287 
            let v296 : string = method159()
            let v298 : bool = v296 = "\n"
            let v300 : string =
                if v298 then
                    method65(v296)
                else
                    v296
            let v301 : (string -> (string seq -> string)) = String.concat
            let v302 : (string seq -> string) = v301 v300
            let v303 : string = v302 v290
            let v306 : Result<string, std_io_Error> = Ok v303 
            let v307 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v309 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v310 : string = "$0.map_err(|x| $1(x))"
            let v311 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v306, v307) v310 
            let _run_target_args'_v309 = v311 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v312 : string = "$0.map_err(|x| $1(x))"
            let v313 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v306, v307) v312 
            let _run_target_args'_v309 = v313 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v314 : string = "$0.map_err(|x| $1(x))"
            let v315 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v306, v307) v314 
            let _run_target_args'_v309 = v315 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v316 : Result<string, std_string_String> = match v306 with Ok x -> Ok x | Error x -> Error (v307 x)
            let _run_target_args'_v309 = v316 
            #endif
#if FABLE_COMPILER_PYTHON
            let v317 : Result<string, std_string_String> = match v306 with Ok x -> Ok x | Error x -> Error (v307 x)
            let _run_target_args'_v309 = v317 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v318 : Result<string, std_string_String> = match v306 with Ok x -> Ok x | Error x -> Error (v307 x)
            let _run_target_args'_v309 = v318 
            #endif
#else
            let v319 : Result<string, std_string_String> = match v306 with Ok x -> Ok x | Error x -> Error (v307 x)
            let _run_target_args'_v309 = v319 
            #endif
            let v320 : Result<string, std_string_String> = _run_target_args'_v309 
            let v323 : (string -> US34) = method160()
            let v324 : (std_string_String -> US34) = method161()
            let v325 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v326 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v323, v324, v320) v325 
            let v335 : string =
                match v326 with
                | US34_1(v328) -> (* Error *)
                    let v330 : string = $"resultm.get / Result value was Error: {v328}"
                    failwith<string> v330
                | US34_0(v327) -> (* Ok *)
                    v327
            let v336 : bool = v173 = v335
            v336
    if v337 then
        US33_1
    else
        let v339 : US36 = method181(v2, v5, v3, v1, v4)
        match v339 with
        | US36_1(v406, v407) -> (* Error *)
            let v409 : (string * string) = v5, v407 
            let v412 : Result<string, (string * string)> = Error v409 
            US33_0(v412)
        | US36_0(v340, v341) -> (* Ok *)
            let v343 : bool = v340 <> 0 
            if v343 then
                let v346 : unit = ()
                let v347 : (unit -> unit) = closure82(v341, v340)
                let v348 : unit = (fun () -> v347 (); v346) ()
                let v396 : (string * string) = v5, v341 
                let v399 : Result<string, (string * string)> = Error v396 
                US33_0(v399)
            else
                let v401 : bool = method30(v5)
                if v401 then
                    method164(v6, v5)
                else
                    let v402 : string = $"documents.files_fn / {v5} should exist"
                    failwith<unit> v402
                let v403 : Result<string, (string * string)> = Ok v5 
                US33_0(v403)
and closure83 (v0 : string, v1 : string, v2 : bool) (v3 : string) : (string -> US33) =
    closure84(v0, v1, v2, v3)
and method185 (v0 : string, v1 : string) : string =
    let v2 : string = method14()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure8(v3, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v15 : string = "output_path"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure8(v3, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v25 : string = " = "
    let v26 : string = $"{v25}"
    let v29 : unit = ()
    let v30 : (unit -> unit) = closure8(v3, v26)
    let v31 : unit = (fun () -> v30 (); v29) ()
    let v35 : string = $"{v0}"
    let v38 : unit = ()
    let v39 : (unit -> unit) = closure8(v3, v35)
    let v40 : unit = (fun () -> v39 (); v38) ()
    let v44 : string = "; "
    let v45 : string = $"{v44}"
    let v48 : unit = ()
    let v49 : (unit -> unit) = closure8(v3, v45)
    let v50 : unit = (fun () -> v49 (); v48) ()
    let v54 : string = "output_cache_path"
    let v55 : string = $"{v54}"
    let v58 : unit = ()
    let v59 : (unit -> unit) = closure8(v3, v55)
    let v60 : unit = (fun () -> v59 (); v58) ()
    let v64 : string = $"{v25}"
    let v67 : unit = ()
    let v68 : (unit -> unit) = closure8(v3, v64)
    let v69 : unit = (fun () -> v68 (); v67) ()
    let v73 : string = $"{v1}"
    let v76 : unit = ()
    let v77 : (unit -> unit) = closure8(v3, v73)
    let v78 : unit = (fun () -> v77 (); v76) ()
    let v82 : string = " }"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v3, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = v3.l0
    v91
and method184 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string) : string =
    let v10 : string = method185(v8, v9)
    let v11 : int64 = v0.l0
    let v13 : string = "documents.run / par_map / files' = [] / listm.iter"
    let v14 : string = $"{v6} {v7} #{v11} %s{v13} / {v10}"
    method18(v14)
and closure86 (v0 : string, v1 : string) () : unit =
    let v2 : US0 = US0_2
    let v3 : bool = method7(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method8(v27, v28, v29, v30, v31, v32)
        let v46 : string = method12()
        let v47 : string = method184(v27, v28, v29, v30, v31, v32, v45, v46, v1, v0)
        method19(v47)
and method186 (v0 : UH4, v1 : UH5 list) : UH5 list =
    match v0 with
    | UH4_1(v2, v3) -> (* Cons *)
        let v4 : UH5 list = method186(v3, v1)
        let v6 : UH5 list = v2 :: v4 
        v6
    | UH4_0 -> (* Nil *)
        v1
and closure88 (v0 : UH5) (v1 : UH4) : UH4 =
    UH4_1(v0, v1)
and closure87 () (v0 : UH5) : (UH4 -> UH4) =
    closure88(v0)
and method187 () : (UH5 -> (UH4 -> UH4)) =
    closure87()
and method189 (v0 : UH5, v1 : struct (string * string * (string -> (string -> US33))) list) : struct (string * string * (string -> (string -> US33))) list =
    match v0 with
    | UH5_1(v2, v3, v4, v5) -> (* Cons *)
        let v6 : struct (string * string * (string -> (string -> US33))) list = method189(v5, v1)
        let v8 : struct (string * string * (string -> (string -> US33))) list = struct (v2, v3, v4) :: v6 
        v8
    | UH5_0 -> (* Nil *)
        v1
and closure89 () struct (v0 : string, v1 : string, v2 : (string -> (string -> US33))) : Result<string, (string * string)> option =
    let v3 : (string -> US33) = v2 v1
    let v4 : US33 = v3 v0
    match v4 with
    | US33_1 -> (* None *)
        let v10 : Result<string, (string * string)> option = None
        v10
    | US33_0(v5) -> (* Some *)
        let v7 : Result<string, (string * string)> option = Some v5 
        v7
and method190 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and method191 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and method188 (v0 : UH4, v1 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    match v0 with
    | UH4_1(v2, v3) -> (* Cons *)
        let v4 : struct (string * string * (string -> (string -> US33))) list = []
        let v5 : struct (string * string * (string -> (string -> US33))) list = method189(v2, v4)
        let v7 : (struct (string * string * (string -> (string -> US33))) list -> (struct (string * string * (string -> (string -> US33))) [])) = List.toArray
        let v8 : (struct (string * string * (string -> (string -> US33))) []) = v7 v5
        let v11 : string = "$0.to_vec()"
        let v12 : Vec<struct (string * string * (string -> (string -> US33)))> = Fable.Core.RustInterop.emitRustExpr v8 v11 
        let v13 : string = "rayon::iter::IntoParallelIterator::into_par_iter($0)"
        let v14 : rayon_vec_IntoIter<struct (string * string * (string -> (string -> US33)))> = Fable.Core.RustInterop.emitRustExpr v12 v13 
        let v15 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
        let v16 : (struct (string * string * (string -> (string -> US33))) -> Result<string, (string * string)> option) = closure89()
        let v17 : rayon_iter_Map<rayon_vec_IntoIter<struct (string * string * (string -> (string -> US33)))>> = Fable.Core.RustInterop.emitRustExpr struct (v14, v16) v15 
        let v18 : string = "rayon::iter::ParallelIterator::collect($0)"
        let v19 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v17 v18 
        let v20 : Vec<Result<string, (string * string)> option> = method190(v19)
        let v21 : Vec<Result<string, (string * string)> option> = method191(v1)
        let v22 : string = "true; let mut v21 = v21"
        let v23 : bool = Fable.Core.RustInterop.emitRustExpr () v22 
        let v24 : string = "true; v21.extend(v20)"
        let v25 : bool = Fable.Core.RustInterop.emitRustExpr () v24 
        let v26 : string = "v21"
        let v27 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr () v26 
        method188(v3, v27)
    | UH4_0 -> (* Nil *)
        v1
and closure35 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) (v5 : string) : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> =
    let v6 : string = method61(v5)
    (* run_target_args'
    let v11 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12 : string = "&*$0"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v12 
    let _run_target_args'_v11 = v13 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v14 : string = "&*$0"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v14 
    let _run_target_args'_v11 = v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : string = "&*$0"
    let v17 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v16 
    let _run_target_args'_v11 = v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v11 = v19 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v11 = v23 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v27 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v11 = v27 
    #endif
#else
    let v31 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v11 = v31 
    #endif
    let v34 : Ref<Str> = _run_target_args'_v11 
    (* run_target_args'
    let v44 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v45 : string = "String::from($0)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr v34 v45 
    let _run_target_args'_v44 = v46 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : string = "String::from($0)"
    let v48 : std_string_String = Fable.Core.RustInterop.emitRustExpr v34 v47 
    let _run_target_args'_v44 = v48 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v49 : string = "String::from($0)"
    let v50 : std_string_String = Fable.Core.RustInterop.emitRustExpr v34 v49 
    let _run_target_args'_v44 = v50 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v52 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v44 = v52 
    #endif
#if FABLE_COMPILER_PYTHON
    let v56 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v44 = v56 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v60 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v44 = v60 
    #endif
#else
    let v64 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v44 = v64 
    #endif
    let v67 : std_string_String = _run_target_args'_v44 
    (* run_target_args'
    let v77 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v78 : string = "std::path::PathBuf::from($0)"
    let v79 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v67 v78 
    let _run_target_args'_v77 = v79 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v80 : string = "std::path::PathBuf::from($0)"
    let v81 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v67 v80 
    let _run_target_args'_v77 = v81 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v82 : string = "std::path::PathBuf::from($0)"
    let v83 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v67 v82 
    let _run_target_args'_v77 = v83 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v85 : std_path_PathBuf = v67 |> unbox<std_path_PathBuf>
    let _run_target_args'_v77 = v85 
    #endif
#if FABLE_COMPILER_PYTHON
    let v89 : std_path_PathBuf = v67 |> unbox<std_path_PathBuf>
    let _run_target_args'_v77 = v89 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v93 : std_path_PathBuf = v67 |> unbox<std_path_PathBuf>
    let _run_target_args'_v77 = v93 
    #endif
#else
    let v97 : std_path_PathBuf = v67 |> unbox<std_path_PathBuf>
    let _run_target_args'_v77 = v97 
    #endif
    let v100 : std_path_PathBuf = _run_target_args'_v77 
    (* run_target_args'
    let v110 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v111 : string = "$0.display()"
    let v112 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v100 v111 
    let _run_target_args'_v110 = v112 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v113 : string = "$0.display()"
    let v114 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v100 v113 
    let _run_target_args'_v110 = v114 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v115 : string = "$0.display()"
    let v116 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v100 v115 
    let _run_target_args'_v110 = v116 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v118 : std_path_Display = v100 |> unbox<std_path_Display>
    let _run_target_args'_v110 = v118 
    #endif
#if FABLE_COMPILER_PYTHON
    let v122 : std_path_Display = v100 |> unbox<std_path_Display>
    let _run_target_args'_v110 = v122 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v126 : std_path_Display = v100 |> unbox<std_path_Display>
    let _run_target_args'_v110 = v126 
    #endif
#else
    let v130 : std_path_Display = v100 |> unbox<std_path_Display>
    let _run_target_args'_v110 = v130 
    #endif
    let v133 : std_path_Display = _run_target_args'_v110 
    (* run_target_args'
    let v143 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v144 : string = "format!(\"{}\", $0)"
    let v145 : std_string_String = Fable.Core.RustInterop.emitRustExpr v133 v144 
    let _run_target_args'_v143 = v145 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v146 : string = "format!(\"{}\", $0)"
    let v147 : std_string_String = Fable.Core.RustInterop.emitRustExpr v133 v146 
    let _run_target_args'_v143 = v147 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v148 : string = "format!(\"{}\", $0)"
    let v149 : std_string_String = Fable.Core.RustInterop.emitRustExpr v133 v148 
    let _run_target_args'_v143 = v149 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v151 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v143 = v151 
    #endif
#if FABLE_COMPILER_PYTHON
    let v155 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v143 = v155 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v159 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v143 = v159 
    #endif
#else
    let v163 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v143 = v163 
    #endif
    let v166 : std_string_String = _run_target_args'_v143 
    let v172 : string = "fable_library_rust::String_::fromString($0)"
    let v173 : string = Fable.Core.RustInterop.emitRustExpr v166 v172 
    let v174 : string = method81()
    let v175 : string = v173.Replace (v3, v174)
    let v176 : string = "\\"
    let v177 : string = "/"
    let v178 : string = v175.Replace (v176, v177)
    let v179 : string = $".{v178}"
    let v180 : string = method38(v6)
    let v181 : string = method28(v2, v179)
    let v182 : string = method82(v181)
    let v183 : System.Threading.CancellationToken option = None
    let v184 : (struct (string * string) []) = [||]
    let v185 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v186 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v187 : string option = None
    let v188 : string = $"git ls-tree --format='%%(objectname)' origin/gh-pages \"{v182}\""
    let v190 : string option = Some v2 
    let v193 : bool = true
    let struct (v194 : int32, v195 : string) = method83(v188, v183, v184, v185, v186, v193, v190)
    let v196 : string = method28(v3, v179)
    let v197 : string = method82(v196)
    let v198 : System.Threading.CancellationToken option = None
    let v199 : (struct (string * string) []) = [||]
    let v200 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v201 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v202 : string option = None
    let v203 : string = $"git hash-object \"{v197}\""
    let v205 : string option = Some v3 
    let v208 : bool = true
    let struct (v209 : int32, v210 : string) = method83(v203, v198, v199, v200, v201, v208, v205)
    let v211 : string = method28(v4, v179)
    let v212 : string = method82(v211)
    let v213 : string = "hangul.md"
    let struct (v214 : string, v215 : string) = method158(v213, v197, v4)
    let v216 : bool = false
    let v217 : bool = false
    let v218 : bool = false
    let v219 : bool = true
    let v220 : bool = true
    let v221 : bool = true
    let v223 : bool = v195.Contains v210 
    let v715 : UH4 =
        if v223 then
            UH4_0
        else
            let v227 : string = method38(v197)
            let v228 : string = "std::fs::File::open(&*v227)"
            let v229 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v228 
            (* run_target_args'
            let v231 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v232 : string = "$0.unwrap()"
            let v233 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v229 v232 
            let _run_target_args'_v231 = v233 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v234 : string = "$0.unwrap()"
            let v235 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v229 v234 
            let _run_target_args'_v231 = v235 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v236 : string = "$0.unwrap()"
            let v237 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v229 v236 
            let _run_target_args'_v231 = v237 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v238 : std_fs_File = match v229 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v231 = v238 
            #endif
#if FABLE_COMPILER_PYTHON
            let v239 : std_fs_File = match v229 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v231 = v239 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v240 : std_fs_File = match v229 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v231 = v240 
            #endif
#else
            let v241 : std_fs_File = match v229 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v231 = v241 
            #endif
            let v242 : std_fs_File = _run_target_args'_v231 
            let v245 : string = "std::io::BufReader::new($0)"
            let v246 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v242 v245 
            let v247 : string = "std::io::BufReader::new($0)"
            let v248 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v246 v247 
            let v249 : string = "true; let mut v248 = v248"
            let v250 : bool = Fable.Core.RustInterop.emitRustExpr () v249 
            let v251 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v251 
            let v252 : string = "result"
            let v253 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v252 
            let v254 : string = "true; let mut v253 = v253"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr () v254 
            let v257 : unativeint = 0 |> unativeint 
            let v260 : string = "[$0; 1024]"
            let v261 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v260 
            let v262 : string = "true; loop { // rust.loop"
            let v263 : bool = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "true; let mut v261 = v261"
            let v265 : bool = Fable.Core.RustInterop.emitRustExpr () v264 
            let v266 : string = "std::io::Read::read(&mut v248, &mut v261)"
            let v267 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v266 
            (* run_target_args'
            let v269 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v270 : string = "$0.unwrap()"
            let v271 : unativeint = Fable.Core.RustInterop.emitRustExpr v267 v270 
            let _run_target_args'_v269 = v271 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v272 : string = "$0.unwrap()"
            let v273 : unativeint = Fable.Core.RustInterop.emitRustExpr v267 v272 
            let _run_target_args'_v269 = v273 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v274 : string = "$0.unwrap()"
            let v275 : unativeint = Fable.Core.RustInterop.emitRustExpr v267 v274 
            let _run_target_args'_v269 = v275 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v276 : unativeint = match v267 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v269 = v276 
            #endif
#if FABLE_COMPILER_PYTHON
            let v277 : unativeint = match v267 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v269 = v277 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v278 : unativeint = match v267 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v269 = v278 
            #endif
#else
            let v279 : unativeint = match v267 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v269 = v279 
            #endif
            let v280 : unativeint = _run_target_args'_v269 
            let v284 : bool = v280 = v257 
            if v284 then
                let v287 : string = "true; break"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr () v287 
                ()
            let v290 : unativeint = v280 |> unativeint 
            let v294 : unativeint = v290 |> unbox<unativeint>
            let v297 : string = "v261.len()"
            let v298 : unativeint = Fable.Core.RustInterop.emitRustExpr () v297 
            let v300 : bool = v294 = v298 
            let v307 : Ref<Slice'<uint8>> =
                if v300 then
                    let v303 : string = "&v261[v257..]"
                    let v304 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v303 
                    v304
                else
                    let v305 : string = "&v261[$0..$1]"
                    let v306 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v257, v290) v305 
                    v306
            let v308 : string = "sha2::Digest::update(&mut v253, v307)"
            Fable.Core.RustInterop.emitRustExpr () v308 
            let v309 : string = "true; } // rust.loop"
            let v310 : bool = Fable.Core.RustInterop.emitRustExpr () v309 
            let v311 : string = "true; } // rust.loop"
            let v312 : bool = Fable.Core.RustInterop.emitRustExpr () v311 
            let v313 : string = "true; } // rust.loop"
            let v314 : bool = Fable.Core.RustInterop.emitRustExpr () v313 
            let v315 : string = "true; { // rust.loop"
            let v316 : bool = Fable.Core.RustInterop.emitRustExpr () v315 
            let v317 : string = "true; { // rust.loop"
            let v318 : bool = Fable.Core.RustInterop.emitRustExpr () v317 
            let v319 : string = "&sha2::Digest::finalize(v253)"
            let v320 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v319 
            let v321 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v322 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v320 v321 
            let v323 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v324 : bool = Fable.Core.RustInterop.emitRustExpr v322 v323 
            let v325 : string = "x"
            let v326 : uint8 = Fable.Core.RustInterop.emitRustExpr () v325 
            let v327 : string = "format!(\"{:02x}\", $0)"
            let v328 : std_string_String = Fable.Core.RustInterop.emitRustExpr v326 v327 
            let v329 : string = "fable_library_rust::String_::fromString($0)"
            let v330 : string = Fable.Core.RustInterop.emitRustExpr v328 v329 
            let v331 : string = "true; $0 }).collect::<Vec<_>>()"
            let v332 : bool = Fable.Core.RustInterop.emitRustExpr v330 v331 
            let v333 : string = "_vec_map"
            let v334 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v333 
            let v335 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v336 : (string []) = Fable.Core.RustInterop.emitRustExpr v334 v335 
            let v340 : unit = ()
            let _let'_v340 =
                seq {
                    for i = 0 to v336.Length - 1 do yield v336.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v343 : string seq = _let'_v340 
            let v349 : string = method159()
            let v351 : bool = v349 = "\n"
            let v353 : string =
                if v351 then
                    method65(v349)
                else
                    v349
            let v354 : (string -> (string seq -> string)) = String.concat
            let v355 : (string seq -> string) = v354 v353
            let v356 : string = v355 v343
            let v359 : Result<string, std_io_Error> = Ok v356 
            let v360 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v362 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v363 : string = "$0.map_err(|x| $1(x))"
            let v364 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v359, v360) v363 
            let _run_target_args'_v362 = v364 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v365 : string = "$0.map_err(|x| $1(x))"
            let v366 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v359, v360) v365 
            let _run_target_args'_v362 = v366 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v367 : string = "$0.map_err(|x| $1(x))"
            let v368 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v359, v360) v367 
            let _run_target_args'_v362 = v368 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v369 : Result<string, std_string_String> = match v359 with Ok x -> Ok x | Error x -> Error (v360 x)
            let _run_target_args'_v362 = v369 
            #endif
#if FABLE_COMPILER_PYTHON
            let v370 : Result<string, std_string_String> = match v359 with Ok x -> Ok x | Error x -> Error (v360 x)
            let _run_target_args'_v362 = v370 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v371 : Result<string, std_string_String> = match v359 with Ok x -> Ok x | Error x -> Error (v360 x)
            let _run_target_args'_v362 = v371 
            #endif
#else
            let v372 : Result<string, std_string_String> = match v359 with Ok x -> Ok x | Error x -> Error (v360 x)
            let _run_target_args'_v362 = v372 
            #endif
            let v373 : Result<string, std_string_String> = _run_target_args'_v362 
            let v376 : (string -> US34) = method160()
            let v377 : (std_string_String -> US34) = method161()
            let v378 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v379 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v376, v377, v373) v378 
            let v388 : string =
                match v379 with
                | US34_1(v381) -> (* Error *)
                    let v383 : string = $"resultm.get / Result value was Error: {v381}"
                    failwith<string> v383
                | US34_0(v380) -> (* Ok *)
                    v380
            let v389 : bool = method30(v212)
            let v390 : bool = v389 = false
            let v551 : US5 =
                if v390 then
                    US5_1
                else
                    let v392 : string = method38(v212)
                    let v393 : string = "std::fs::File::open(&*v392)"
                    let v394 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v393 
                    (* run_target_args'
                    let v396 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v397 : string = "$0.unwrap()"
                    let v398 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v394 v397 
                    let _run_target_args'_v396 = v398 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v399 : string = "$0.unwrap()"
                    let v400 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v394 v399 
                    let _run_target_args'_v396 = v400 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v401 : string = "$0.unwrap()"
                    let v402 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v394 v401 
                    let _run_target_args'_v396 = v402 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v403 : std_fs_File = match v394 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v396 = v403 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v404 : std_fs_File = match v394 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v396 = v404 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v405 : std_fs_File = match v394 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v396 = v405 
                    #endif
#else
                    let v406 : std_fs_File = match v394 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v396 = v406 
                    #endif
                    let v407 : std_fs_File = _run_target_args'_v396 
                    let v410 : string = "std::io::BufReader::new($0)"
                    let v411 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v407 v410 
                    let v412 : string = "std::io::BufReader::new($0)"
                    let v413 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v411 v412 
                    let v414 : string = "true; let mut v413 = v413"
                    let v415 : bool = Fable.Core.RustInterop.emitRustExpr () v414 
                    let v416 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
                    Fable.Core.RustInterop.emitRustExpr () v416 
                    let v417 : string = "result"
                    let v418 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v417 
                    let v419 : string = "true; let mut v418 = v418"
                    let v420 : bool = Fable.Core.RustInterop.emitRustExpr () v419 
                    let v422 : unativeint = 0 |> unativeint 
                    let v425 : string = "[$0; 1024]"
                    let v426 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v425 
                    let v427 : string = "true; loop { // rust.loop"
                    let v428 : bool = Fable.Core.RustInterop.emitRustExpr () v427 
                    let v429 : string = "true; let mut v426 = v426"
                    let v430 : bool = Fable.Core.RustInterop.emitRustExpr () v429 
                    let v431 : string = "std::io::Read::read(&mut v413, &mut v426)"
                    let v432 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v431 
                    (* run_target_args'
                    let v434 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v435 : string = "$0.unwrap()"
                    let v436 : unativeint = Fable.Core.RustInterop.emitRustExpr v432 v435 
                    let _run_target_args'_v434 = v436 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v437 : string = "$0.unwrap()"
                    let v438 : unativeint = Fable.Core.RustInterop.emitRustExpr v432 v437 
                    let _run_target_args'_v434 = v438 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v439 : string = "$0.unwrap()"
                    let v440 : unativeint = Fable.Core.RustInterop.emitRustExpr v432 v439 
                    let _run_target_args'_v434 = v440 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v441 : unativeint = match v432 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v434 = v441 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v442 : unativeint = match v432 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v434 = v442 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v443 : unativeint = match v432 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v434 = v443 
                    #endif
#else
                    let v444 : unativeint = match v432 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v434 = v444 
                    #endif
                    let v445 : unativeint = _run_target_args'_v434 
                    let v449 : bool = v445 = v422 
                    if v449 then
                        let v452 : string = "true; break"
                        let v453 : bool = Fable.Core.RustInterop.emitRustExpr () v452 
                        ()
                    let v455 : unativeint = v445 |> unativeint 
                    let v459 : unativeint = v455 |> unbox<unativeint>
                    let v462 : string = "v426.len()"
                    let v463 : unativeint = Fable.Core.RustInterop.emitRustExpr () v462 
                    let v465 : bool = v459 = v463 
                    let v472 : Ref<Slice'<uint8>> =
                        if v465 then
                            let v468 : string = "&v426[v422..]"
                            let v469 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v468 
                            v469
                        else
                            let v470 : string = "&v426[$0..$1]"
                            let v471 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v422, v455) v470 
                            v471
                    let v473 : string = "sha2::Digest::update(&mut v418, v472)"
                    Fable.Core.RustInterop.emitRustExpr () v473 
                    let v474 : string = "true; } // rust.loop"
                    let v475 : bool = Fable.Core.RustInterop.emitRustExpr () v474 
                    let v476 : string = "true; } // rust.loop"
                    let v477 : bool = Fable.Core.RustInterop.emitRustExpr () v476 
                    let v478 : string = "true; } // rust.loop"
                    let v479 : bool = Fable.Core.RustInterop.emitRustExpr () v478 
                    let v480 : string = "true; { // rust.loop"
                    let v481 : bool = Fable.Core.RustInterop.emitRustExpr () v480 
                    let v482 : string = "true; { // rust.loop"
                    let v483 : bool = Fable.Core.RustInterop.emitRustExpr () v482 
                    let v484 : string = "&sha2::Digest::finalize(v418)"
                    let v485 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v484 
                    let v486 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
                    let v487 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v485 v486 
                    let v488 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
                    let v489 : bool = Fable.Core.RustInterop.emitRustExpr v487 v488 
                    let v490 : string = "x"
                    let v491 : uint8 = Fable.Core.RustInterop.emitRustExpr () v490 
                    let v492 : string = "format!(\"{:02x}\", $0)"
                    let v493 : std_string_String = Fable.Core.RustInterop.emitRustExpr v491 v492 
                    let v494 : string = "fable_library_rust::String_::fromString($0)"
                    let v495 : string = Fable.Core.RustInterop.emitRustExpr v493 v494 
                    let v496 : string = "true; $0 }).collect::<Vec<_>>()"
                    let v497 : bool = Fable.Core.RustInterop.emitRustExpr v495 v496 
                    let v498 : string = "_vec_map"
                    let v499 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v498 
                    let v500 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
                    let v501 : (string []) = Fable.Core.RustInterop.emitRustExpr v499 v500 
                    let v505 : unit = ()
                    let _let'_v505 =
                        seq {
                            for i = 0 to v501.Length - 1 do yield v501.[i]
                            (* indent
                            ()
                        indent *)
                        }
                        (* indent
                        ()
                    indent *)
                    let v508 : string seq = _let'_v505 
                    let v514 : string = method159()
                    let v516 : bool = v514 = "\n"
                    let v518 : string =
                        if v516 then
                            method65(v514)
                        else
                            v514
                    let v519 : (string -> (string seq -> string)) = String.concat
                    let v520 : (string seq -> string) = v519 v518
                    let v521 : string = v520 v508
                    let v524 : Result<string, std_io_Error> = Ok v521 
                    let v525 : (std_io_Error -> std_string_String) = method69()
                    (* run_target_args'
                    let v527 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v528 : string = "$0.map_err(|x| $1(x))"
                    let v529 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v524, v525) v528 
                    let _run_target_args'_v527 = v529 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v530 : string = "$0.map_err(|x| $1(x))"
                    let v531 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v524, v525) v530 
                    let _run_target_args'_v527 = v531 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v532 : string = "$0.map_err(|x| $1(x))"
                    let v533 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v524, v525) v532 
                    let _run_target_args'_v527 = v533 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v534 : Result<string, std_string_String> = match v524 with Ok x -> Ok x | Error x -> Error (v525 x)
                    let _run_target_args'_v527 = v534 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v535 : Result<string, std_string_String> = match v524 with Ok x -> Ok x | Error x -> Error (v525 x)
                    let _run_target_args'_v527 = v535 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v536 : Result<string, std_string_String> = match v524 with Ok x -> Ok x | Error x -> Error (v525 x)
                    let _run_target_args'_v527 = v536 
                    #endif
#else
                    let v537 : Result<string, std_string_String> = match v524 with Ok x -> Ok x | Error x -> Error (v525 x)
                    let _run_target_args'_v527 = v537 
                    #endif
                    let v538 : Result<string, std_string_String> = _run_target_args'_v527 
                    let v541 : (string -> US34) = method160()
                    let v542 : (std_string_String -> US34) = method161()
                    let v543 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
                    let v544 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v541, v542, v538) v543 
                    match v544 with
                    | US34_1(v547) -> (* Error *)
                        US5_1
                    | US34_0(v545) -> (* Ok *)
                        US5_0(v545)
            match v551 with
            | US5_0(v552) -> (* Some *)
                let v553 : bool = v388 = v552
                if v553 then
                    UH4_0
                else
                    let v555 : unit = ()
                    let v556 : (unit -> unit) = closure73(v179, v180, v182, v195, v194, v197, v210, v209, v212, v388, v551)
                    let v557 : unit = (fun () -> v556 (); v555) ()
                    method164(v212, v197)
                    let v612 : (string -> (string -> US33)) = closure78(v4, v3, v1, v0)
                    let v613 : UH5 = UH5_0
                    let v614 : UH5 = UH5_1(v213, v197, v612, v613)
                    let v615 : string = "html"
                    let v616 : (string -> (string -> US33)) = closure83(v4, v3, v216)
                    let v617 : string = "pdf"
                    let v618 : (string -> (string -> US33)) = closure83(v4, v3, v217)
                    let v619 : string = "epub"
                    let v620 : (string -> (string -> US33)) = closure83(v4, v3, v218)
                    let v621 : (string -> (string -> US33)) = closure83(v4, v3, v219)
                    let v622 : (string -> (string -> US33)) = closure83(v4, v3, v220)
                    let v623 : (string -> (string -> US33)) = closure83(v4, v3, v221)
                    let v624 : UH5 = UH5_0
                    let v625 : UH5 = UH5_1(v619, v214, v623, v624)
                    let v626 : UH5 = UH5_1(v617, v214, v622, v625)
                    let v627 : UH5 = UH5_1(v615, v214, v621, v626)
                    let v628 : UH5 = UH5_1(v619, v197, v620, v627)
                    let v629 : UH5 = UH5_1(v617, v197, v618, v628)
                    let v630 : UH5 = UH5_1(v615, v197, v616, v629)
                    let v631 : UH4 = UH4_0
                    let v632 : UH4 = UH4_1(v630, v631)
                    UH4_1(v614, v632)
            | _ ->
                let v635 : unit = ()
                let v636 : (unit -> unit) = closure73(v179, v180, v182, v195, v194, v197, v210, v209, v212, v388, v551)
                let v637 : unit = (fun () -> v636 (); v635) ()
                method164(v212, v197)
                let v692 : (string -> (string -> US33)) = closure78(v4, v3, v1, v0)
                let v693 : UH5 = UH5_0
                let v694 : UH5 = UH5_1(v213, v197, v692, v693)
                let v695 : string = "html"
                let v696 : (string -> (string -> US33)) = closure83(v4, v3, v216)
                let v697 : string = "pdf"
                let v698 : (string -> (string -> US33)) = closure83(v4, v3, v217)
                let v699 : string = "epub"
                let v700 : (string -> (string -> US33)) = closure83(v4, v3, v218)
                let v701 : (string -> (string -> US33)) = closure83(v4, v3, v219)
                let v702 : (string -> (string -> US33)) = closure83(v4, v3, v220)
                let v703 : (string -> (string -> US33)) = closure83(v4, v3, v221)
                let v704 : UH5 = UH5_0
                let v705 : UH5 = UH5_1(v699, v214, v703, v704)
                let v706 : UH5 = UH5_1(v697, v214, v702, v705)
                let v707 : UH5 = UH5_1(v695, v214, v701, v706)
                let v708 : UH5 = UH5_1(v699, v197, v700, v707)
                let v709 : UH5 = UH5_1(v697, v197, v698, v708)
                let v710 : UH5 = UH5_1(v695, v197, v696, v709)
                let v711 : UH4 = UH4_0
                let v712 : UH4 = UH4_1(v710, v711)
                UH4_1(v694, v712)
    let v716 : bool =
        match v715 with
        | UH4_0 -> (* Nil *)
            true
        | _ ->
            false
    let v717 : bool = v716 <> true
    let v1141 : UH4 =
        if v717 then
            v715
        else
            let v718 : string = "epub"
            let struct (v719 : string, v720 : string) = method158(v718, v214, v4)
            let v721 : bool = method30(v719)
            let v774 : bool =
                if v721 then
                    true
                else
                    let v722 : bool = method30(v720)
                    let v723 : bool = v722 = false
                    if v723 then
                        true
                    else
                        let v724 : unit = ()
                        let v725 : (unit -> unit) = closure86(v720, v719)
                        let v726 : unit = (fun () -> v725 (); v724) ()
                        method164(v719, v720)
                        false
            let v779 : UH5 =
                if v774 then
                    let v775 : (string -> (string -> US33)) = closure83(v4, v3, v221)
                    let v776 : UH5 = UH5_0
                    UH5_1(v718, v214, v775, v776)
                else
                    UH5_0
            let v780 : string = "pdf"
            let struct (v781 : string, v782 : string) = method158(v780, v214, v4)
            let v783 : bool = method30(v781)
            let v836 : bool =
                if v783 then
                    true
                else
                    let v784 : bool = method30(v782)
                    let v785 : bool = v784 = false
                    if v785 then
                        true
                    else
                        let v786 : unit = ()
                        let v787 : (unit -> unit) = closure86(v782, v781)
                        let v788 : unit = (fun () -> v787 (); v786) ()
                        method164(v781, v782)
                        false
            let v839 : UH5 =
                if v836 then
                    let v837 : (string -> (string -> US33)) = closure83(v4, v3, v220)
                    UH5_1(v780, v214, v837, v779)
                else
                    v779
            let v840 : string = "html"
            let struct (v841 : string, v842 : string) = method158(v840, v214, v4)
            let v843 : bool = method30(v841)
            let v896 : bool =
                if v843 then
                    true
                else
                    let v844 : bool = method30(v842)
                    let v845 : bool = v844 = false
                    if v845 then
                        true
                    else
                        let v846 : unit = ()
                        let v847 : (unit -> unit) = closure86(v842, v841)
                        let v848 : unit = (fun () -> v847 (); v846) ()
                        method164(v841, v842)
                        false
            let v899 : UH5 =
                if v896 then
                    let v897 : (string -> (string -> US33)) = closure83(v4, v3, v219)
                    UH5_1(v840, v214, v897, v839)
                else
                    v839
            let struct (v900 : string, v901 : string) = method158(v718, v197, v4)
            let v902 : bool = method30(v900)
            let v955 : bool =
                if v902 then
                    true
                else
                    let v903 : bool = method30(v901)
                    let v904 : bool = v903 = false
                    if v904 then
                        true
                    else
                        let v905 : unit = ()
                        let v906 : (unit -> unit) = closure86(v901, v900)
                        let v907 : unit = (fun () -> v906 (); v905) ()
                        method164(v900, v901)
                        false
            let v958 : UH5 =
                if v955 then
                    let v956 : (string -> (string -> US33)) = closure83(v4, v3, v218)
                    UH5_1(v718, v197, v956, v899)
                else
                    v899
            let struct (v959 : string, v960 : string) = method158(v780, v197, v4)
            let v961 : bool = method30(v959)
            let v1014 : bool =
                if v961 then
                    true
                else
                    let v962 : bool = method30(v960)
                    let v963 : bool = v962 = false
                    if v963 then
                        true
                    else
                        let v964 : unit = ()
                        let v965 : (unit -> unit) = closure86(v960, v959)
                        let v966 : unit = (fun () -> v965 (); v964) ()
                        method164(v959, v960)
                        false
            let v1017 : UH5 =
                if v1014 then
                    let v1015 : (string -> (string -> US33)) = closure83(v4, v3, v217)
                    UH5_1(v780, v197, v1015, v958)
                else
                    v958
            let struct (v1018 : string, v1019 : string) = method158(v840, v197, v4)
            let v1020 : bool = method30(v1018)
            let v1073 : bool =
                if v1020 then
                    true
                else
                    let v1021 : bool = method30(v1019)
                    let v1022 : bool = v1021 = false
                    if v1022 then
                        true
                    else
                        let v1023 : unit = ()
                        let v1024 : (unit -> unit) = closure86(v1019, v1018)
                        let v1025 : unit = (fun () -> v1024 (); v1023) ()
                        method164(v1018, v1019)
                        false
            let v1076 : UH5 =
                if v1073 then
                    let v1074 : (string -> (string -> US33)) = closure83(v4, v3, v216)
                    UH5_1(v840, v197, v1074, v1017)
                else
                    v1017
            let struct (v1077 : string, v1078 : string) = method158(v213, v197, v4)
            let v1079 : bool = method30(v1077)
            let v1132 : bool =
                if v1079 then
                    true
                else
                    let v1080 : bool = method30(v1078)
                    let v1081 : bool = v1080 = false
                    if v1081 then
                        true
                    else
                        let v1082 : unit = ()
                        let v1083 : (unit -> unit) = closure86(v1078, v1077)
                        let v1084 : unit = (fun () -> v1083 (); v1082) ()
                        method164(v1077, v1078)
                        false
            let v1137 : UH5 =
                if v1132 then
                    let v1133 : (string -> (string -> US33)) = closure78(v4, v3, v1, v0)
                    let v1134 : UH5 = UH5_0
                    UH5_1(v213, v197, v1133, v1134)
                else
                    UH5_0
            let v1138 : UH4 = UH4_0
            let v1139 : UH4 = UH4_1(v1076, v1138)
            UH4_1(v1137, v1139)
    let v1142 : UH5 list = []
    let v1143 : UH5 list = method186(v1141, v1142)
    let v1145 : (UH5 list -> (UH5 [])) = List.toArray
    let v1146 : (UH5 []) = v1145 v1143
    let v1149 : string = "$0.to_vec()"
    let v1150 : Vec<UH5> = Fable.Core.RustInterop.emitRustExpr v1146 v1149 
    let v1151 : (Result<string, (string * string)> option []) = [||]
    let v1152 : string = "$0.to_vec()"
    let v1153 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1151 v1152 
    let v1154 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v1155 : (UH5 []) = Fable.Core.RustInterop.emitRustExpr v1150 v1154 
    let v1157 : UH5 list = v1155 |> Array.toList
    let v1161 : ((UH5 -> (UH4 -> UH4)) -> (UH5 list -> (UH4 -> UH4))) = List.foldBack
    let v1162 : (UH5 -> (UH4 -> UH4)) = method187()
    let v1163 : (UH5 list -> (UH4 -> UH4)) = v1161 v1162
    let v1164 : (UH4 -> UH4) = v1163 v1157
    let v1165 : UH4 = UH4_0
    let v1166 : UH4 = v1164 v1165
    let v1191 : Vec<Result<string, (string * string)> option> = method188(v1166, v1153)
    let v1193 : (string * Vec<Result<string, (string * string)> option>) = v180, v1191 
    let v1196 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = Ok v1193 
    v1196
and method25 (v0 : string, v1 : string, v2 : string, v3 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> =
    let v4 : string = method26()
    let v5 : US5 = method27(v4)
    let v11 : US5 =
        match v5 with
        | US5_1 -> (* None *)
            let v8 : string = __SOURCE_DIRECTORY__
            method27(v8)
        | US5_0(v6) -> (* Some *)
            US5_0(v6)
    let v17 : US5 =
        match v11 with
        | US5_1 -> (* None *)
            let v14 : string = "/workspaces"
            method27(v14)
        | US5_0(v12) -> (* Some *)
            US5_0(v12)
    let v21 : string =
        match v17 with
        | US5_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US5_0(v18) -> (* Some *)
            v18
    let v22 : string = method47(v21)
    let v23 : bool = "deps" = v22
    let v34 : string =
        if v23 then
            let v24 : string option = method33(v21)
            let v26 : string = v24 |> Option.get
            let v29 : US5 = method27(v26)
            match v29 with
            | US5_1 -> (* None *)
                failwith<string> "Option does not have a value."
            | US5_0(v30) -> (* Some *)
                v30
        else
            v21
    let v35 : string = "polyglot"
    let v36 : string = method28(v34, v35)
    let v37 : string = method61(v3)
    let v38 : string = method61(v2)
    let v39 : string = method61(v1)
    let v40 : unit = ()
    let v41 : (unit -> unit) = closure24(v0, v37, v38, v39)
    let v42 : unit = (fun () -> v41 (); v40) ()
    let v89 : string = "true; let __future_init = Box::pin(/*"
    let v90 : bool = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = "*/ async move { /*"
    let v92 : bool = Fable.Core.RustInterop.emitRustExpr () v91 
    let v93 : string = "*/ ()"
    let v94 : bool = Fable.Core.RustInterop.emitRustExpr () v93 
    let v95 : string = "async_walkdir::WalkDir::new(&*$0)"
    let v96 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr v38 v95 
    let v97 : string = "async_walkdir::WalkDir::filter($0, move |x| $1(x))"
    let v98 : (async_walkdir_DirEntry -> std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>>) = closure25()
    let v99 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr struct (v96, v98) v97 
    let v100 : (Result<async_walkdir_DirEntry, async_walkdir_Error> -> string option) = method72()
    let v101 : string = "futures::stream::StreamExt::filter_map(v99, |x| async { v100(x) })"
    let v102 : _ = Fable.Core.RustInterop.emitRustExpr () v101 
    let v103 : string = "Box::pin(futures::stream::StreamExt::collect(v102))"
    let v104 : std_pin_Pin<Box<Dyn<std_future_Future<Vec<string>>>>> = Fable.Core.RustInterop.emitRustExpr () v103 
    let v105 : string = "v104.await"
    let v106 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v105 
    let v107 : unit = ()
    let v108 : (unit -> unit) = closure34(v106)
    let v109 : unit = (fun () -> v108 (); v107) ()
    let v158 : string = "rayon::iter::IntoParallelIterator::into_par_iter($0)"
    let v159 : rayon_vec_IntoIter<string> = Fable.Core.RustInterop.emitRustExpr v106 v158 
    let v160 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
    let v161 : (string -> Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>) = closure35(v0, v36, v37, v38, v39)
    let v162 : rayon_iter_Map<rayon_vec_IntoIter<string>> = Fable.Core.RustInterop.emitRustExpr struct (v159, v161) v160 
    let v163 : string = "rayon::iter::ParallelIterator::collect($0)"
    let v164 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = Fable.Core.RustInterop.emitRustExpr v162 v163 
    let v165 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Ok v164 
    let v166 : string = ""
    let v167 : string = "}"
    let v168 : string = v166 + v167 
    let x = v165 //
    let v169 : _ = x
    let v170 : unit = ()
    (* run_target_args'
    let v171 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v172 : string = $"true; let _fix_closure_v170 = $0"
    let v173 : bool = Fable.Core.RustInterop.emitRustExpr v169 v172 
    let _run_target_args'_v171 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v174 : string = $"true; let _fix_closure_v170 = $0"
    let v175 : bool = Fable.Core.RustInterop.emitRustExpr v169 v174 
    let _run_target_args'_v171 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v176 : string = $"true; let _fix_closure_v170 = $0"
    let v177 : bool = Fable.Core.RustInterop.emitRustExpr v169 v176 
    let _run_target_args'_v171 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v171 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v171 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v171 = false 
    #endif
#else
    let _run_target_args'_v171 = false 
    #endif
    let v178 : bool = _run_target_args'_v171 
    let v180 : string = $"true; _fix_closure_v170 " + v168 + "); " + v166 + " // rust.fix_closure'"
    let v181 : bool = Fable.Core.RustInterop.emitRustExpr () v180 
    let v182 : string = "__future_init"
    let v183 : _ = Fable.Core.RustInterop.emitRustExpr () v182 
    let v184 : string = "v183"
    let v185 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v184 
    v185
and closure90 () (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) : US37 =
    US37_0(v0)
and method192 () : (Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> -> US37) =
    closure90()
and closure91 () (v0 : std_string_String) : US37 =
    US37_1(v0)
and method193 () : (std_string_String -> US37) =
    closure91()
and method194 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method78(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "documents.main"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method18(v13)
and closure92 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_4
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method76()
        let v46 : string = method194(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method19(v46)
and method196 (v0 : unativeint) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v2, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v14 : string = "result_len"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure8(v2, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure8(v2, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    (* run_target_args'
    let v37 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : string = "format!(\"{:#?}\", $0)"
    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v38 
    let v40 : string = "fable_library_rust::String_::fromString($0)"
    let v41 : string = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let _run_target_args'_v37 = v41 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v42 : string = "format!(\"{:#?}\", $0)"
    let v43 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v42 
    let v44 : string = "fable_library_rust::String_::fromString($0)"
    let v45 : string = Fable.Core.RustInterop.emitRustExpr v43 v44 
    let _run_target_args'_v37 = v45 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v46 : string = "format!(\"{:#?}\", $0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v46 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let _run_target_args'_v37 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v51 : string = $"%A{v0}"
    let _run_target_args'_v37 = v51 
    #endif
#if FABLE_COMPILER_PYTHON
    let v55 : string = $"%A{v0}"
    let _run_target_args'_v37 = v55 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v59 : string = $"%A{v0}"
    let _run_target_args'_v37 = v59 
    #endif
#else
    let v63 : string = $"%A{v0}"
    let _run_target_args'_v37 = v63 
    #endif
    let v66 : string = _run_target_args'_v37 
    let v73 : string = $"{v66}"
    let v76 : unit = ()
    let v77 : (unit -> unit) = closure8(v2, v73)
    let v78 : unit = (fun () -> v77 (); v76) ()
    let v82 : string = " }"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v2, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = v2.l0
    v91
and method195 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : unativeint) : string =
    let v9 : string = method196(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "documents.main"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method18(v13)
and closure93 (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) () : unit =
    let v1 : US0 = US0_2
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method12()
        let v46 : string = "$0.len()"
        let v47 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v46 
        let v48 : string = method195(v26, v27, v28, v29, v30, v31, v44, v45, v47)
        method19(v48)
and closure1 () (v0 : (string [])) : int32 =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure2()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure5(v0)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v67 : clap_Command = method0()
    let v68 : string = "clap::Command::get_matches($0)"
    let v69 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v67 v68 
    let v70 : string = method20()
    (* run_target_args'
    let v75 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v76 : string = "&*$0"
    let v77 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v70 v76 
    let _run_target_args'_v75 = v77 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v78 : string = "&*$0"
    let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v70 v78 
    let _run_target_args'_v75 = v79 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v80 : string = "&*$0"
    let v81 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v70 v80 
    let _run_target_args'_v75 = v81 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v83 : Ref<Str> = v70 |> unbox<Ref<Str>>
    let _run_target_args'_v75 = v83 
    #endif
#if FABLE_COMPILER_PYTHON
    let v87 : Ref<Str> = v70 |> unbox<Ref<Str>>
    let _run_target_args'_v75 = v87 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v91 : Ref<Str> = v70 |> unbox<Ref<Str>>
    let _run_target_args'_v75 = v91 
    #endif
#else
    let v95 : Ref<Str> = v70 |> unbox<Ref<Str>>
    let _run_target_args'_v75 = v95 
    #endif
    let v98 : Ref<Str> = _run_target_args'_v75 
    let v104 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v105 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v69, v98) v104 
    let v107 : (std_string_String -> US6) = method21()
    let v108 : US6 option = v105 |> Option.map v107 
    let v121 : US6 = US6_1
    let v122 : US6 = v108 |> Option.defaultValue v121 
    let v129 : std_string_String =
        match v122 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v126) -> (* Some *)
            v126
    let v130 : string = "fable_library_rust::String_::fromString($0)"
    let v131 : string = Fable.Core.RustInterop.emitRustExpr v129 v130 
    let v132 : string = method22()
    (* run_target_args'
    let v137 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v138 : string = "&*$0"
    let v139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v132 v138 
    let _run_target_args'_v137 = v139 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v140 : string = "&*$0"
    let v141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v132 v140 
    let _run_target_args'_v137 = v141 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v142 : string = "&*$0"
    let v143 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v132 v142 
    let _run_target_args'_v137 = v143 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v145 : Ref<Str> = v132 |> unbox<Ref<Str>>
    let _run_target_args'_v137 = v145 
    #endif
#if FABLE_COMPILER_PYTHON
    let v149 : Ref<Str> = v132 |> unbox<Ref<Str>>
    let _run_target_args'_v137 = v149 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v153 : Ref<Str> = v132 |> unbox<Ref<Str>>
    let _run_target_args'_v137 = v153 
    #endif
#else
    let v157 : Ref<Str> = v132 |> unbox<Ref<Str>>
    let _run_target_args'_v137 = v157 
    #endif
    let v160 : Ref<Str> = _run_target_args'_v137 
    let v166 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v167 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v69, v160) v166 
    let v169 : (std_string_String -> US6) = method21()
    let v170 : US6 option = v167 |> Option.map v169 
    let v183 : US6 = US6_1
    let v184 : US6 = v170 |> Option.defaultValue v183 
    let v191 : std_string_String =
        match v184 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v188) -> (* Some *)
            v188
    let v192 : string = "fable_library_rust::String_::fromString($0)"
    let v193 : string = Fable.Core.RustInterop.emitRustExpr v191 v192 
    let v194 : string = method23()
    (* run_target_args'
    let v199 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v200 : string = "&*$0"
    let v201 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v194 v200 
    let _run_target_args'_v199 = v201 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v202 : string = "&*$0"
    let v203 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v194 v202 
    let _run_target_args'_v199 = v203 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v204 : string = "&*$0"
    let v205 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v194 v204 
    let _run_target_args'_v199 = v205 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v207 : Ref<Str> = v194 |> unbox<Ref<Str>>
    let _run_target_args'_v199 = v207 
    #endif
#if FABLE_COMPILER_PYTHON
    let v211 : Ref<Str> = v194 |> unbox<Ref<Str>>
    let _run_target_args'_v199 = v211 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v215 : Ref<Str> = v194 |> unbox<Ref<Str>>
    let _run_target_args'_v199 = v215 
    #endif
#else
    let v219 : Ref<Str> = v194 |> unbox<Ref<Str>>
    let _run_target_args'_v199 = v219 
    #endif
    let v222 : Ref<Str> = _run_target_args'_v199 
    let v228 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v229 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v69, v222) v228 
    let v231 : (std_string_String -> US6) = method21()
    let v232 : US6 option = v229 |> Option.map v231 
    let v245 : US6 = US6_1
    let v246 : US6 = v232 |> Option.defaultValue v245 
    let v253 : std_string_String =
        match v246 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v250) -> (* Some *)
            v250
    let v254 : string = "fable_library_rust::String_::fromString($0)"
    let v255 : string = Fable.Core.RustInterop.emitRustExpr v253 v254 
    let v256 : string = method24()
    (* run_target_args'
    let v261 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v262 : string = "&*$0"
    let v263 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v256 v262 
    let _run_target_args'_v261 = v263 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v264 : string = "&*$0"
    let v265 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v256 v264 
    let _run_target_args'_v261 = v265 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v266 : string = "&*$0"
    let v267 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v256 v266 
    let _run_target_args'_v261 = v267 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v269 : Ref<Str> = v256 |> unbox<Ref<Str>>
    let _run_target_args'_v261 = v269 
    #endif
#if FABLE_COMPILER_PYTHON
    let v273 : Ref<Str> = v256 |> unbox<Ref<Str>>
    let _run_target_args'_v261 = v273 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v277 : Ref<Str> = v256 |> unbox<Ref<Str>>
    let _run_target_args'_v261 = v277 
    #endif
#else
    let v281 : Ref<Str> = v256 |> unbox<Ref<Str>>
    let _run_target_args'_v261 = v281 
    #endif
    let v284 : Ref<Str> = _run_target_args'_v261 
    let v290 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v291 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v69, v284) v290 
    let v293 : (std_string_String -> US6) = method21()
    let v294 : US6 option = v291 |> Option.map v293 
    let v307 : US6 = US6_1
    let v308 : US6 = v294 |> Option.defaultValue v307 
    let v315 : std_string_String =
        match v308 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v312) -> (* Some *)
            v312
    let v316 : string = "fable_library_rust::String_::fromString($0)"
    let v317 : string = Fable.Core.RustInterop.emitRustExpr v315 v316 
    let v318 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = method25(v317, v255, v193, v131)
    let v319 : string = "futures::executor::block_on($0)"
    let v320 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr v318 v319 
    let v321 : (Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> -> US37) = method192()
    let v322 : (std_string_String -> US37) = method193()
    let v323 : US37 = match v320 with Ok x -> v321 x | Error x -> v322 x
    match v323 with
    | US37_1(v376) -> (* Error *)
        let v377 : unit = ()
        let v378 : (unit -> unit) = closure92(v376)
        let v379 : unit = (fun () -> v378 (); v377) ()
        1
    | US37_0(v324) -> (* Ok *)
        let v325 : unit = ()
        let v326 : (unit -> unit) = closure93(v324)
        let v327 : unit = (fun () -> v326 (); v325) ()
        0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
