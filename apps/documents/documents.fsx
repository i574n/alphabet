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

type IOsEnviron = abstract environ: x: unit -> obj
module TraceState = let mutable trace_state = None
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

type IFs = abstract realpathSync: path: string -> string
type IPathJoin = abstract join: [<System.ParamArray>] paths: string[] -> string
type IFsExistsSync = abstract existsSync: path: string -> bool
type IPathDirname = abstract dirname: path: string -> string
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
type IPathBasename = abstract basename: path: string -> string
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
[<CompilationRepresentation (CompilationRepresentationFlags.ModuleSuffix)>]
module System =
 module Diagnostics =
  type Process = bool
  type DataReceivedEventArgs = bool
#endif
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

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
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
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsStr")>]
#endif
type std_ffi_OsStr = class end
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
    | US4_6 of f6_0 : US3
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
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method4(v0)
    let v4 : string = "std::env::var(&*$0)"
    let v5 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "x"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : string = "fable_library_rust::String_::fromString($0)"
    let v11 : string = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "true; $0 })"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "_result_map_"
    let v15 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = method5()
    let v17 : string = "$0.unwrap_or($1)"
    let v18 : string = Fable.Core.RustInterop.emitRustExpr struct (v15, v16) v17 
    let _run_target_args'_v2 = v18 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v19 : US3 = US3_1
    let v20 : US4 = US4_4(v19)
    let v21 : string = $"env.get_environment_variable / target: {v20} / var: {v0}"
    let v22 : string = failwith<string> v21
    let _run_target_args'_v2 = v22 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v23 : US3 = US3_2
    let v24 : US4 = US4_4(v23)
    let v25 : string = $"env.get_environment_variable / target: {v24} / var: {v0}"
    let v26 : string = failwith<string> v25
    let _run_target_args'_v2 = v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : string = "process.env[$0] ?? \"\""
    let v28 : string = Fable.Core.JsInterop.emitJsExpr v0 v27 
    let _run_target_args'_v2 = v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v30 : string = "os"
    let v31 : IOsEnviron = Fable.Core.PyInterop.importAll v30 
    let v32 : string = "v31.environ"
    let v33 : obj = Fable.Core.PyInterop.emitPyExpr () v32 
    let v37 : string = "v33.get($0)"
    let v38 : string = Fable.Core.PyInterop.emitPyExpr v0 v37 
    let mutable _v38 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v42 : (string -> string option) = Option.ofObj
    let v43 : string option = v42 v38
    v43 
    #else
    Some v38 
    #endif
    |> fun x -> _v38 <- Some x
    let v44 : string option = match _v38 with Some x -> x | None -> failwith "optionm'.of_obj / _v38=None"
    let v49 : (string -> US5) = method6()
    let v50 : US5 option = v44 |> Option.map v49 
    let v70 : US5 = US5_1
    let v71 : US5 = v50 |> Option.defaultValue v70 
    let v78 : string =
        match v71 with
        | US5_1 -> (* None *)
            let v76 : string = ""
            v76
        | US5_0(v75) -> (* Some *)
            v75
    let _run_target_args'_v2 = v78 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v79 : US3 = US3_1
    let v80 : US4 = US4_1(v79)
    let v81 : string = $"env.get_environment_variable / target: {v80} / var: {v0}"
    let v82 : string = failwith<string> v81
    let _run_target_args'_v2 = v82 
    #endif
#else
    let v83 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v84 : string = v83 v0
    let mutable _v84 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v86 : (string -> string option) = Option.ofObj
    let v87 : string option = v86 v84
    v87 
    #else
    Some v84 
    #endif
    |> fun x -> _v84 <- Some x
    let v88 : string option = match _v84 with Some x -> x | None -> failwith "optionm'.of_obj / _v84=None"
    let v93 : (string -> US5) = method6()
    let v94 : US5 option = v88 |> Option.map v93 
    let v114 : US5 = US5_1
    let v115 : US5 = v94 |> Option.defaultValue v114 
    let v122 : string =
        match v115 with
        | US5_1 -> (* None *)
            let v120 : string = ""
            v120
        | US5_0(v119) -> (* Some *)
            v119
    let _run_target_args'_v2 = v122 
    #endif
    let v123 : string = _run_target_args'_v2 
    v123
and method2 () : struct (US1 * US2) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = method3(v0)
    
    
    
    
    
    
    
    
    
    
    let v4 : string = "Critical"
    let v5 : (unit -> string) = v4.ToLower
    let v6 : string = v5 ()
    let v11 : string = "Warning"
    let v12 : (unit -> string) = v11.ToLower
    let v13 : string = v12 ()
    let v18 : string = "Info"
    let v19 : (unit -> string) = v18.ToLower
    let v20 : string = v19 ()
    let v25 : string = "Debug"
    let v26 : (unit -> string) = v25.ToLower
    let v27 : string = v26 ()
    let v32 : string = "Verbose"
    let v33 : (unit -> string) = v32.ToLower
    let v34 : string = v33 ()
    let v37 : bool = "Verbose" = v1
    let v41 : US1 =
        if v37 then
            let v38 : US0 = US0_0
            US1_0(v38)
        else
            US1_1
    let v127 : US1 =
        match v41 with
        | US1_1 -> (* None *)
            let v44 : bool = "Debug" = v1
            let v48 : US1 =
                if v44 then
                    let v45 : US0 = US0_1
                    US1_0(v45)
                else
                    US1_1
            match v48 with
            | US1_1 -> (* None *)
                let v51 : bool = "Info" = v1
                let v55 : US1 =
                    if v51 then
                        let v52 : US0 = US0_2
                        US1_0(v52)
                    else
                        US1_1
                match v55 with
                | US1_1 -> (* None *)
                    let v58 : bool = "Warning" = v1
                    let v62 : US1 =
                        if v58 then
                            let v59 : US0 = US0_3
                            US1_0(v59)
                        else
                            US1_1
                    match v62 with
                    | US1_1 -> (* None *)
                        let v65 : bool = "Critical" = v1
                        let v69 : US1 =
                            if v65 then
                                let v66 : US0 = US0_4
                                US1_0(v66)
                            else
                                US1_1
                        match v69 with
                        | US1_1 -> (* None *)
                            let v72 : bool = v34 = v1
                            let v76 : US1 =
                                if v72 then
                                    let v73 : US0 = US0_0
                                    US1_0(v73)
                                else
                                    US1_1
                            match v76 with
                            | US1_1 -> (* None *)
                                let v79 : bool = v27 = v1
                                let v83 : US1 =
                                    if v79 then
                                        let v80 : US0 = US0_1
                                        US1_0(v80)
                                    else
                                        US1_1
                                match v83 with
                                | US1_1 -> (* None *)
                                    let v86 : bool = v20 = v1
                                    let v90 : US1 =
                                        if v86 then
                                            let v87 : US0 = US0_2
                                            US1_0(v87)
                                        else
                                            US1_1
                                    match v90 with
                                    | US1_1 -> (* None *)
                                        let v93 : bool = v13 = v1
                                        let v97 : US1 =
                                            if v93 then
                                                let v94 : US0 = US0_3
                                                US1_0(v94)
                                            else
                                                US1_1
                                        match v97 with
                                        | US1_1 -> (* None *)
                                            let v100 : bool = v6 = v1
                                            let v104 : US1 =
                                                if v100 then
                                                    let v101 : US0 = US0_4
                                                    US1_0(v101)
                                                else
                                                    US1_1
                                            match v104 with
                                            | US1_1 -> (* None *)
                                                US1_1
                                            | US1_0(v105) -> (* Some *)
                                                US1_0(v105)
                                        | US1_0(v98) -> (* Some *)
                                            US1_0(v98)
                                    | US1_0(v91) -> (* Some *)
                                        US1_0(v91)
                                | US1_0(v84) -> (* Some *)
                                    US1_0(v84)
                            | US1_0(v77) -> (* Some *)
                                US1_0(v77)
                        | US1_0(v70) -> (* Some *)
                            US1_0(v70)
                    | US1_0(v63) -> (* Some *)
                        US1_0(v63)
                | US1_0(v56) -> (* Some *)
                    US1_0(v56)
            | US1_0(v49) -> (* Some *)
                US1_0(v49)
        | US1_0(v42) -> (* Some *)
            US1_0(v42)
    let v128 : string = "AUTOMATION"
    let v129 : string = method3(v128)
    let v132 : string = "True"
    let v133 : bool = v129 <> v132 
    let v210 : US2 =
        if v133 then
            US2_1
        else
            (* run_target_args'
            let v143 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v144 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v143 = v144 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v145 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v143 = v145 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v147 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v143 = v147 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v150 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v143 = v150 
            #endif
#if FABLE_COMPILER_PYTHON
            let v151 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v143 = v151 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v152 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v143 = v152 
            #endif
#else
            let v153 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v143 = v153 
            #endif
            let v154 : System.DateTime = _run_target_args'_v143 
            (* run_target_args'
            let v165 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v166 : (System.DateTime -> int64) = _.Ticks
            let v167 : int64 = v166 v154
            let _run_target_args'_v165 = v167 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v168 : (System.DateTime -> int64) = _.Ticks
            let v169 : int64 = v168 v154
            let _run_target_args'_v165 = v169 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v171 : int64 = null |> unbox<int64>
            let _run_target_args'_v165 = v171 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v174 : (System.DateTime -> int64) = _.Ticks
            let v175 : int64 = v174 v154
            let _run_target_args'_v165 = v175 
            #endif
#if FABLE_COMPILER_PYTHON
            let v176 : (System.DateTime -> int64) = _.Ticks
            let v177 : int64 = v176 v154
            let _run_target_args'_v165 = v177 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v178 : (System.DateTime -> int64) = _.Ticks
            let v179 : int64 = v178 v154
            let _run_target_args'_v165 = v179 
            #endif
#else
            let v180 : (System.DateTime -> int64) = _.Ticks
            let v181 : int64 = v180 v154
            let _run_target_args'_v165 = v181 
            #endif
            let v182 : int64 = _run_target_args'_v165 
            let v204 : int64 = v182 |> int64 
            US2_0(v204)
    struct (v127, v210)
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
    let v52 : string = "fable_library_rust::String_::fromString($0)"
    let v53 : string = Fable.Core.RustInterop.emitRustExpr v43 v52 
    let _run_target_args'_v13 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "option_env!(\"" + v8 + "\").unwrap_or(\"\")"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v54 
    (* run_target_args'
    let v60 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v61 : string = "String::from($0)"
    let v62 : std_string_String = Fable.Core.RustInterop.emitRustExpr v55 v61 
    let _run_target_args'_v60 = v62 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : string = "String::from($0)"
    let v64 : std_string_String = Fable.Core.RustInterop.emitRustExpr v55 v63 
    let _run_target_args'_v60 = v64 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = "String::from($0)"
    let v66 : std_string_String = Fable.Core.RustInterop.emitRustExpr v55 v65 
    let _run_target_args'_v60 = v66 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : std_string_String = v55 |> unbox<std_string_String>
    let _run_target_args'_v60 = v68 
    #endif
#if FABLE_COMPILER_PYTHON
    let v72 : std_string_String = v55 |> unbox<std_string_String>
    let _run_target_args'_v60 = v72 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v76 : std_string_String = v55 |> unbox<std_string_String>
    let _run_target_args'_v60 = v76 
    #endif
#else
    let v80 : std_string_String = v55 |> unbox<std_string_String>
    let _run_target_args'_v60 = v80 
    #endif
    let v83 : std_string_String = _run_target_args'_v60 
    let v92 : string = "fable_library_rust::String_::fromString($0)"
    let v93 : string = Fable.Core.RustInterop.emitRustExpr v83 v92 
    let _run_target_args'_v13 = v93 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v94 : string = "option_env!(\"" + v8 + "\").unwrap_or(\"\")"
    let v95 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v94 
    (* run_target_args'
    let v100 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v101 : string = "String::from($0)"
    let v102 : std_string_String = Fable.Core.RustInterop.emitRustExpr v95 v101 
    let _run_target_args'_v100 = v102 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v103 : string = "String::from($0)"
    let v104 : std_string_String = Fable.Core.RustInterop.emitRustExpr v95 v103 
    let _run_target_args'_v100 = v104 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v105 : string = "String::from($0)"
    let v106 : std_string_String = Fable.Core.RustInterop.emitRustExpr v95 v105 
    let _run_target_args'_v100 = v106 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v108 : std_string_String = v95 |> unbox<std_string_String>
    let _run_target_args'_v100 = v108 
    #endif
#if FABLE_COMPILER_PYTHON
    let v112 : std_string_String = v95 |> unbox<std_string_String>
    let _run_target_args'_v100 = v112 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v116 : std_string_String = v95 |> unbox<std_string_String>
    let _run_target_args'_v100 = v116 
    #endif
#else
    let v120 : std_string_String = v95 |> unbox<std_string_String>
    let _run_target_args'_v100 = v120 
    #endif
    let v123 : std_string_String = _run_target_args'_v100 
    let v132 : string = "fable_library_rust::String_::fromString($0)"
    let v133 : string = Fable.Core.RustInterop.emitRustExpr v123 v132 
    let _run_target_args'_v13 = v133 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v135 : string = null |> unbox<string>
    let _run_target_args'_v13 = v135 
    #endif
#if FABLE_COMPILER_PYTHON
    let v139 : string = null |> unbox<string>
    let _run_target_args'_v13 = v139 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v143 : string = null |> unbox<string>
    let _run_target_args'_v13 = v143 
    #endif
#else
    let v147 : string = null |> unbox<string>
    let _run_target_args'_v13 = v147 
    #endif
    let v150 : string = _run_target_args'_v13 
    let v161 : string = "True"
    let v162 : bool = v150 <> v161 
    let v174 : US2 =
        if v162 then
            US2_1
        else
            let v166 : string = $"near_sdk::env::block_timestamp()"
            let v167 : uint64 = Fable.Core.RustInterop.emitRustExpr () v166 
            let v169 : (uint64 -> int64) = int64
            let v170 : int64 = v169 v167
            US2_0(v170)
    let v175 : US1 = US1_1
    let _run_target_args'_v3 = struct (v175, v174) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v176 : US1, v177 : US2) = method2()
    let _run_target_args'_v3 = struct (v176, v177) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v178 : US1, v179 : US2) = method2()
    let _run_target_args'_v3 = struct (v178, v179) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v180 : US1, v181 : US2) = method2()
    let _run_target_args'_v3 = struct (v180, v181) 
    #endif
#else
    let struct (v182 : US1, v183 : US2) = method2()
    let _run_target_args'_v3 = struct (v182, v183) 
    #endif
    let struct (v184 : US1, v185 : US2) = _run_target_args'_v3 
    let v190 : Mut0 = {l0 = 1L} : Mut0
    let v191 : (string -> unit) = closure4()
    let v192 : Mut1 = {l0 = v191} : Mut1
    let v193 : Mut2 = {l0 = true} : Mut2
    let v194 : string = ""
    let v195 : Mut3 = {l0 = v194} : Mut3
    let v198 : US0 =
        match v184 with
        | US1_1 -> (* None *)
            v0
        | US1_0(v196) -> (* Some *)
            v196
    let v199 : Mut4 = {l0 = v198} : Mut4
    let v210 : int64 option =
        match v185 with
        | US2_1 -> (* None *)
            let v206 : int64 option = None
            v206
        | US2_0(v200) -> (* Some *)
            let v202 : int64 option = Some v200 
            v202
    struct (v190, v192, v193, v195, v199, v210)
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
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure6()
    let v17 : unit = (fun () -> v16 (); v15) ()
    let struct (v38 : Mut0, v39 : Mut1, v40 : Mut2, v41 : Mut3, v42 : Mut4, v43 : int64 option) = TraceState.trace_state.Value
    let v56 : US0 = v42.l0
    let v57 : bool = v40.l0
    let v58 : bool = v57 = false
    if v58 then
        false
    else
        let v59 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
        let v60 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v56
        let v61 : bool = v59 >= v60
        v61
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
    let v195 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v198 : (int64 -> US2) = method9()
    let v199 : US2 option = v5 |> Option.map v198 
    let v219 : US2 = US2_1
    let v220 : US2 = v199 |> Option.defaultValue v219 
    let v360 : System.DateTime =
        match v220 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v343 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v344 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v343 = v344 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v345 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v343 = v345 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v347 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v343 = v347 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v350 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v343 = v350 
            #endif
#if FABLE_COMPILER_PYTHON
            let v351 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v343 = v351 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v352 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v343 = v352 
            #endif
#else
            let v353 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v343 = v353 
            #endif
            let v354 : System.DateTime = _run_target_args'_v343 
            v354
        | US2_0(v224) -> (* Some *)
            (* run_target_args'
            let v231 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v232 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v231 = v232 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v233 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v231 = v233 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v235 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v231 = v235 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v238 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v231 = v238 
            #endif
#if FABLE_COMPILER_PYTHON
            let v239 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v231 = v239 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v240 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v231 = v240 
            #endif
#else
            let v241 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v231 = v241 
            #endif
            let v242 : System.DateTime = _run_target_args'_v231 
            (* run_target_args'
            let v253 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v254 : (System.DateTime -> int64) = _.Ticks
            let v255 : int64 = v254 v242
            let _run_target_args'_v253 = v255 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v256 : (System.DateTime -> int64) = _.Ticks
            let v257 : int64 = v256 v242
            let _run_target_args'_v253 = v257 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v259 : int64 = null |> unbox<int64>
            let _run_target_args'_v253 = v259 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v262 : (System.DateTime -> int64) = _.Ticks
            let v263 : int64 = v262 v242
            let _run_target_args'_v253 = v263 
            #endif
#if FABLE_COMPILER_PYTHON
            let v264 : (System.DateTime -> int64) = _.Ticks
            let v265 : int64 = v264 v242
            let _run_target_args'_v253 = v265 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v266 : (System.DateTime -> int64) = _.Ticks
            let v267 : int64 = v266 v242
            let _run_target_args'_v253 = v267 
            #endif
#else
            let v268 : (System.DateTime -> int64) = _.Ticks
            let v269 : int64 = v268 v242
            let _run_target_args'_v253 = v269 
            #endif
            let v270 : int64 = _run_target_args'_v253 
            let v292 : int64 = v270 |> int64 
            let v297 : int64 = v292 - v224
            let v303 : System.TimeSpan = v297 |> System.TimeSpan 
            let v309 : (System.TimeSpan -> int32) = _.Hours
            let v310 : int32 = v309 v303
            let v314 : (System.TimeSpan -> int32) = _.Minutes
            let v315 : int32 = v314 v303
            let v319 : (System.TimeSpan -> int32) = _.Seconds
            let v320 : int32 = v319 v303
            let v324 : (System.TimeSpan -> int32) = _.Milliseconds
            let v325 : int32 = v324 v303
            let v334 : System.DateTime = System.DateTime (1, 1, 1, v310, v315, v320, v325)
            v334
    let v361 : string = method10()
    let v363 : bool = v361 = ""
    let v365 : string =
        if v363 then
            let v364 : string = "M-d-y hh:mm:ss tt"
            v364
        else
            v361
    let v366 : (string -> string) = v360.ToString
    let v367 : string = v366 v365
    let _run_target_args'_v195 = v367 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v384 : (int64 -> US2) = method9()
    let v385 : US2 option = v5 |> Option.map v384 
    let v405 : US2 = US2_1
    let v406 : US2 = v385 |> Option.defaultValue v405 
    let v546 : System.DateTime =
        match v406 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v529 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v530 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v529 = v530 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v531 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v529 = v531 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v533 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v529 = v533 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v536 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v529 = v536 
            #endif
#if FABLE_COMPILER_PYTHON
            let v537 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v529 = v537 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v538 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v529 = v538 
            #endif
#else
            let v539 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v529 = v539 
            #endif
            let v540 : System.DateTime = _run_target_args'_v529 
            v540
        | US2_0(v410) -> (* Some *)
            (* run_target_args'
            let v417 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v418 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v417 = v418 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v419 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v417 = v419 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v421 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v417 = v421 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v424 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v417 = v424 
            #endif
#if FABLE_COMPILER_PYTHON
            let v425 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v417 = v425 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v426 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v417 = v426 
            #endif
#else
            let v427 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v417 = v427 
            #endif
            let v428 : System.DateTime = _run_target_args'_v417 
            (* run_target_args'
            let v439 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v440 : (System.DateTime -> int64) = _.Ticks
            let v441 : int64 = v440 v428
            let _run_target_args'_v439 = v441 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v442 : (System.DateTime -> int64) = _.Ticks
            let v443 : int64 = v442 v428
            let _run_target_args'_v439 = v443 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v445 : int64 = null |> unbox<int64>
            let _run_target_args'_v439 = v445 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v448 : (System.DateTime -> int64) = _.Ticks
            let v449 : int64 = v448 v428
            let _run_target_args'_v439 = v449 
            #endif
#if FABLE_COMPILER_PYTHON
            let v450 : (System.DateTime -> int64) = _.Ticks
            let v451 : int64 = v450 v428
            let _run_target_args'_v439 = v451 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v452 : (System.DateTime -> int64) = _.Ticks
            let v453 : int64 = v452 v428
            let _run_target_args'_v439 = v453 
            #endif
#else
            let v454 : (System.DateTime -> int64) = _.Ticks
            let v455 : int64 = v454 v428
            let _run_target_args'_v439 = v455 
            #endif
            let v456 : int64 = _run_target_args'_v439 
            let v478 : int64 = v456 |> int64 
            let v483 : int64 = v478 - v410
            let v489 : System.TimeSpan = v483 |> System.TimeSpan 
            let v495 : (System.TimeSpan -> int32) = _.Hours
            let v496 : int32 = v495 v489
            let v500 : (System.TimeSpan -> int32) = _.Minutes
            let v501 : int32 = v500 v489
            let v505 : (System.TimeSpan -> int32) = _.Seconds
            let v506 : int32 = v505 v489
            let v510 : (System.TimeSpan -> int32) = _.Milliseconds
            let v511 : int32 = v510 v489
            let v520 : System.DateTime = System.DateTime (1, 1, 1, v496, v501, v506, v511)
            v520
    let v547 : string = method10()
    let v549 : bool = v547 = ""
    let v551 : string =
        if v549 then
            let v550 : string = "M-d-y hh:mm:ss tt"
            v550
        else
            v547
    let v552 : (string -> string) = v546.ToString
    let v553 : string = v552 v551
    let _run_target_args'_v195 = v553 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v568 : string = $"near_sdk::env::block_timestamp()"
    let v569 : uint64 = Fable.Core.RustInterop.emitRustExpr () v568 
    let v572 : (int64 -> US2) = method9()
    let v573 : US2 option = v5 |> Option.map v572 
    let v593 : US2 = US2_1
    let v594 : US2 = v573 |> Option.defaultValue v593 
    let v606 : uint64 =
        match v594 with
        | US2_1 -> (* None *)
            v569
        | US2_0(v598) -> (* Some *)
            let v600 : (int64 -> uint64) = uint64
            let v601 : uint64 = v600 v598
            let v604 : uint64 = v569 - v601
            v604
    let v607 : uint64 = v606 / 1000000000UL
    let v608 : uint64 = v607 % 60UL
    let v609 : uint64 = v607 / 60UL
    let v610 : uint64 = v609 % 60UL
    let v611 : uint64 = v607 / 3600UL
    let v612 : uint64 = v611 % 24UL
    let v613 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v614 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v612, v610, v608) v613 
    let v615 : string = "fable_library_rust::String_::fromString($0)"
    let v616 : string = Fable.Core.RustInterop.emitRustExpr v614 v615 
    let _run_target_args'_v195 = v616 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v619 : (int64 -> US2) = method9()
    let v620 : US2 option = v5 |> Option.map v619 
    let v640 : US2 = US2_1
    let v641 : US2 = v620 |> Option.defaultValue v640 
    let v781 : System.DateTime =
        match v641 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v764 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v765 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v764 = v765 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v766 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v764 = v766 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v768 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v764 = v768 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v771 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v764 = v771 
            #endif
#if FABLE_COMPILER_PYTHON
            let v772 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v764 = v772 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v773 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v764 = v773 
            #endif
#else
            let v774 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v764 = v774 
            #endif
            let v775 : System.DateTime = _run_target_args'_v764 
            v775
        | US2_0(v645) -> (* Some *)
            (* run_target_args'
            let v652 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v653 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v653 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v654 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v654 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v656 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v652 = v656 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v659 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v659 
            #endif
#if FABLE_COMPILER_PYTHON
            let v660 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v660 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v661 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v661 
            #endif
#else
            let v662 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v662 
            #endif
            let v663 : System.DateTime = _run_target_args'_v652 
            (* run_target_args'
            let v674 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v675 : (System.DateTime -> int64) = _.Ticks
            let v676 : int64 = v675 v663
            let _run_target_args'_v674 = v676 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v677 : (System.DateTime -> int64) = _.Ticks
            let v678 : int64 = v677 v663
            let _run_target_args'_v674 = v678 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v680 : int64 = null |> unbox<int64>
            let _run_target_args'_v674 = v680 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v683 : (System.DateTime -> int64) = _.Ticks
            let v684 : int64 = v683 v663
            let _run_target_args'_v674 = v684 
            #endif
#if FABLE_COMPILER_PYTHON
            let v685 : (System.DateTime -> int64) = _.Ticks
            let v686 : int64 = v685 v663
            let _run_target_args'_v674 = v686 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v687 : (System.DateTime -> int64) = _.Ticks
            let v688 : int64 = v687 v663
            let _run_target_args'_v674 = v688 
            #endif
#else
            let v689 : (System.DateTime -> int64) = _.Ticks
            let v690 : int64 = v689 v663
            let _run_target_args'_v674 = v690 
            #endif
            let v691 : int64 = _run_target_args'_v674 
            let v713 : int64 = v691 |> int64 
            let v718 : int64 = v713 - v645
            let v724 : System.TimeSpan = v718 |> System.TimeSpan 
            let v730 : (System.TimeSpan -> int32) = _.Hours
            let v731 : int32 = v730 v724
            let v735 : (System.TimeSpan -> int32) = _.Minutes
            let v736 : int32 = v735 v724
            let v740 : (System.TimeSpan -> int32) = _.Seconds
            let v741 : int32 = v740 v724
            let v745 : (System.TimeSpan -> int32) = _.Milliseconds
            let v746 : int32 = v745 v724
            let v755 : System.DateTime = System.DateTime (1, 1, 1, v731, v736, v741, v746)
            v755
    let v782 : string = method11()
    let v784 : bool = v782 = ""
    let v786 : string =
        if v784 then
            let v785 : string = "M-d-y hh:mm:ss tt"
            v785
        else
            v782
    let v787 : (string -> string) = v781.ToString
    let v788 : string = v787 v786
    let _run_target_args'_v195 = v788 
    #endif
#if FABLE_COMPILER_PYTHON
    let v805 : (int64 -> US2) = method9()
    let v806 : US2 option = v5 |> Option.map v805 
    let v826 : US2 = US2_1
    let v827 : US2 = v806 |> Option.defaultValue v826 
    let v967 : System.DateTime =
        match v827 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v950 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v951 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v950 = v951 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v952 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v950 = v952 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v954 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v950 = v954 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v957 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v950 = v957 
            #endif
#if FABLE_COMPILER_PYTHON
            let v958 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v950 = v958 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v959 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v950 = v959 
            #endif
#else
            let v960 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v950 = v960 
            #endif
            let v961 : System.DateTime = _run_target_args'_v950 
            v961
        | US2_0(v831) -> (* Some *)
            (* run_target_args'
            let v838 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v839 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v838 = v839 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v840 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v838 = v840 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v842 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v838 = v842 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v845 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v838 = v845 
            #endif
#if FABLE_COMPILER_PYTHON
            let v846 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v838 = v846 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v847 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v838 = v847 
            #endif
#else
            let v848 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v838 = v848 
            #endif
            let v849 : System.DateTime = _run_target_args'_v838 
            (* run_target_args'
            let v860 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v861 : (System.DateTime -> int64) = _.Ticks
            let v862 : int64 = v861 v849
            let _run_target_args'_v860 = v862 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v863 : (System.DateTime -> int64) = _.Ticks
            let v864 : int64 = v863 v849
            let _run_target_args'_v860 = v864 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v866 : int64 = null |> unbox<int64>
            let _run_target_args'_v860 = v866 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v869 : (System.DateTime -> int64) = _.Ticks
            let v870 : int64 = v869 v849
            let _run_target_args'_v860 = v870 
            #endif
#if FABLE_COMPILER_PYTHON
            let v871 : (System.DateTime -> int64) = _.Ticks
            let v872 : int64 = v871 v849
            let _run_target_args'_v860 = v872 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v873 : (System.DateTime -> int64) = _.Ticks
            let v874 : int64 = v873 v849
            let _run_target_args'_v860 = v874 
            #endif
#else
            let v875 : (System.DateTime -> int64) = _.Ticks
            let v876 : int64 = v875 v849
            let _run_target_args'_v860 = v876 
            #endif
            let v877 : int64 = _run_target_args'_v860 
            let v899 : int64 = v877 |> int64 
            let v904 : int64 = v899 - v831
            let v910 : System.TimeSpan = v904 |> System.TimeSpan 
            let v916 : (System.TimeSpan -> int32) = _.Hours
            let v917 : int32 = v916 v910
            let v921 : (System.TimeSpan -> int32) = _.Minutes
            let v922 : int32 = v921 v910
            let v926 : (System.TimeSpan -> int32) = _.Seconds
            let v927 : int32 = v926 v910
            let v931 : (System.TimeSpan -> int32) = _.Milliseconds
            let v932 : int32 = v931 v910
            let v941 : System.DateTime = System.DateTime (1, 1, 1, v917, v922, v927, v932)
            v941
    let v968 : string = method11()
    let v970 : bool = v968 = ""
    let v972 : string =
        if v970 then
            let v971 : string = "M-d-y hh:mm:ss tt"
            v971
        else
            v968
    let v973 : (string -> string) = v967.ToString
    let v974 : string = v973 v972
    let _run_target_args'_v195 = v974 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v991 : (int64 -> US2) = method9()
    let v992 : US2 option = v5 |> Option.map v991 
    let v1012 : US2 = US2_1
    let v1013 : US2 = v992 |> Option.defaultValue v1012 
    let v1153 : System.DateTime =
        match v1013 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v1136 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1137 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1136 = v1137 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1138 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1136 = v1138 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1140 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1136 = v1140 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1143 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1136 = v1143 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1144 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1136 = v1144 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1145 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1136 = v1145 
            #endif
#else
            let v1146 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1136 = v1146 
            #endif
            let v1147 : System.DateTime = _run_target_args'_v1136 
            v1147
        | US2_0(v1017) -> (* Some *)
            (* run_target_args'
            let v1024 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1025 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1024 = v1025 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1026 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1024 = v1026 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1028 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1024 = v1028 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1031 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1024 = v1031 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1032 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1024 = v1032 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1033 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1024 = v1033 
            #endif
#else
            let v1034 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1024 = v1034 
            #endif
            let v1035 : System.DateTime = _run_target_args'_v1024 
            (* run_target_args'
            let v1046 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1047 : (System.DateTime -> int64) = _.Ticks
            let v1048 : int64 = v1047 v1035
            let _run_target_args'_v1046 = v1048 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1049 : (System.DateTime -> int64) = _.Ticks
            let v1050 : int64 = v1049 v1035
            let _run_target_args'_v1046 = v1050 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1052 : int64 = null |> unbox<int64>
            let _run_target_args'_v1046 = v1052 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1055 : (System.DateTime -> int64) = _.Ticks
            let v1056 : int64 = v1055 v1035
            let _run_target_args'_v1046 = v1056 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1057 : (System.DateTime -> int64) = _.Ticks
            let v1058 : int64 = v1057 v1035
            let _run_target_args'_v1046 = v1058 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1059 : (System.DateTime -> int64) = _.Ticks
            let v1060 : int64 = v1059 v1035
            let _run_target_args'_v1046 = v1060 
            #endif
#else
            let v1061 : (System.DateTime -> int64) = _.Ticks
            let v1062 : int64 = v1061 v1035
            let _run_target_args'_v1046 = v1062 
            #endif
            let v1063 : int64 = _run_target_args'_v1046 
            let v1085 : int64 = v1063 |> int64 
            let v1090 : int64 = v1085 - v1017
            let v1096 : System.TimeSpan = v1090 |> System.TimeSpan 
            let v1102 : (System.TimeSpan -> int32) = _.Hours
            let v1103 : int32 = v1102 v1096
            let v1107 : (System.TimeSpan -> int32) = _.Minutes
            let v1108 : int32 = v1107 v1096
            let v1112 : (System.TimeSpan -> int32) = _.Seconds
            let v1113 : int32 = v1112 v1096
            let v1117 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1118 : int32 = v1117 v1096
            let v1127 : System.DateTime = System.DateTime (1, 1, 1, v1103, v1108, v1113, v1118)
            v1127
    let v1154 : string = method11()
    let v1156 : bool = v1154 = ""
    let v1158 : string =
        if v1156 then
            let v1157 : string = "M-d-y hh:mm:ss tt"
            v1157
        else
            v1154
    let v1159 : (string -> string) = v1153.ToString
    let v1160 : string = v1159 v1158
    let _run_target_args'_v195 = v1160 
    #endif
#else
    let v1177 : (int64 -> US2) = method9()
    let v1178 : US2 option = v5 |> Option.map v1177 
    let v1198 : US2 = US2_1
    let v1199 : US2 = v1178 |> Option.defaultValue v1198 
    let v1339 : System.DateTime =
        match v1199 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v1322 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1323 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1322 = v1323 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1324 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1322 = v1324 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1326 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1322 = v1326 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1329 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1322 = v1329 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1330 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1322 = v1330 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1331 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1322 = v1331 
            #endif
#else
            let v1332 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1322 = v1332 
            #endif
            let v1333 : System.DateTime = _run_target_args'_v1322 
            v1333
        | US2_0(v1203) -> (* Some *)
            (* run_target_args'
            let v1210 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1211 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1210 = v1211 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1212 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1210 = v1212 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1214 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1210 = v1214 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1217 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1210 = v1217 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1218 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1210 = v1218 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1219 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1210 = v1219 
            #endif
#else
            let v1220 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1210 = v1220 
            #endif
            let v1221 : System.DateTime = _run_target_args'_v1210 
            (* run_target_args'
            let v1232 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1233 : (System.DateTime -> int64) = _.Ticks
            let v1234 : int64 = v1233 v1221
            let _run_target_args'_v1232 = v1234 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1235 : (System.DateTime -> int64) = _.Ticks
            let v1236 : int64 = v1235 v1221
            let _run_target_args'_v1232 = v1236 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1238 : int64 = null |> unbox<int64>
            let _run_target_args'_v1232 = v1238 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1241 : (System.DateTime -> int64) = _.Ticks
            let v1242 : int64 = v1241 v1221
            let _run_target_args'_v1232 = v1242 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1243 : (System.DateTime -> int64) = _.Ticks
            let v1244 : int64 = v1243 v1221
            let _run_target_args'_v1232 = v1244 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1245 : (System.DateTime -> int64) = _.Ticks
            let v1246 : int64 = v1245 v1221
            let _run_target_args'_v1232 = v1246 
            #endif
#else
            let v1247 : (System.DateTime -> int64) = _.Ticks
            let v1248 : int64 = v1247 v1221
            let _run_target_args'_v1232 = v1248 
            #endif
            let v1249 : int64 = _run_target_args'_v1232 
            let v1271 : int64 = v1249 |> int64 
            let v1276 : int64 = v1271 - v1203
            let v1282 : System.TimeSpan = v1276 |> System.TimeSpan 
            let v1288 : (System.TimeSpan -> int32) = _.Hours
            let v1289 : int32 = v1288 v1282
            let v1293 : (System.TimeSpan -> int32) = _.Minutes
            let v1294 : int32 = v1293 v1282
            let v1298 : (System.TimeSpan -> int32) = _.Seconds
            let v1299 : int32 = v1298 v1282
            let v1303 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1304 : int32 = v1303 v1282
            let v1313 : System.DateTime = System.DateTime (1, 1, 1, v1289, v1294, v1299, v1304)
            v1313
    let v1340 : string = method11()
    let v1342 : bool = v1340 = ""
    let v1344 : string =
        if v1342 then
            let v1343 : string = "M-d-y hh:mm:ss tt"
            v1343
        else
            v1340
    let v1345 : (string -> string) = v1339.ToString
    let v1346 : string = v1345 v1344
    let _run_target_args'_v195 = v1346 
    #endif
    let v1361 : string = _run_target_args'_v195 
    v1361
and method13 () : string =
    let v0 : string = ""
    v0
and closure8 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v4 : string = v2 + v1 
    v0.l0 <- v4
    ()
and method14 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method12 () : string =
    
    
    
    
    
    let v2 : string = "Info"
    let v3 : (unit -> string) = v2.ToLower
    let v4 : string = v3 ()
    let v7 : char = v4.[int 0]
    let v8 : string = method13()
    let v9 : Mut3 = {l0 = v8} : Mut3
    let v14 : string = $"{v7}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure8(v9, v14)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v30 : string = v9.l0
    (* run_target_args'
    let v47 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v48 : string = "inline_colorization::color_bright_green"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48 
    (* run_target_args'
    let v54 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v55 : string = "&*$0"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v55 
    let _run_target_args'_v54 = v56 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v57 : string = "&*$0"
    let v58 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v57 
    let _run_target_args'_v54 = v58 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v59 : string = "&*$0"
    let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v59 
    let _run_target_args'_v54 = v60 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v62 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v62 
    #endif
#if FABLE_COMPILER_PYTHON
    let v66 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v66 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v70 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v70 
    #endif
#else
    let v74 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v74 
    #endif
    let v77 : Ref<Str> = _run_target_args'_v54 
    let v86 : string = "inline_colorization::color_reset"
    let v87 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v86 
    let v88 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v89 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v49, v77, v87) v88 
    let v90 : string = "fable_library_rust::String_::fromString($0)"
    let v91 : string = Fable.Core.RustInterop.emitRustExpr v89 v90 
    let _run_target_args'_v47 = v91 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v92 : string = "inline_colorization::color_bright_green"
    let v93 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v92 
    (* run_target_args'
    let v98 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v99 : string = "&*$0"
    let v100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v99 
    let _run_target_args'_v98 = v100 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v101 : string = "&*$0"
    let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v101 
    let _run_target_args'_v98 = v102 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v103 : string = "&*$0"
    let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v103 
    let _run_target_args'_v98 = v104 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v106 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v106 
    #endif
#if FABLE_COMPILER_PYTHON
    let v110 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v110 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v114 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v114 
    #endif
#else
    let v118 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v118 
    #endif
    let v121 : Ref<Str> = _run_target_args'_v98 
    let v130 : string = "inline_colorization::color_reset"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v93, v121, v131) v132 
    let v134 : string = "fable_library_rust::String_::fromString($0)"
    let v135 : string = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let _run_target_args'_v47 = v135 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v136 : string = "inline_colorization::color_bright_green"
    let v137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v136 
    (* run_target_args'
    let v142 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v143 : string = "&*$0"
    let v144 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v143 
    let _run_target_args'_v142 = v144 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v145 : string = "&*$0"
    let v146 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v145 
    let _run_target_args'_v142 = v146 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v147 : string = "&*$0"
    let v148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v147 
    let _run_target_args'_v142 = v148 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v150 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v150 
    #endif
#if FABLE_COMPILER_PYTHON
    let v154 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v154 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v158 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v158 
    #endif
#else
    let v162 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v162 
    #endif
    let v165 : Ref<Str> = _run_target_args'_v142 
    let v174 : string = "inline_colorization::color_reset"
    let v175 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v174 
    let v176 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v177 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v137, v165, v175) v176 
    let v178 : string = "fable_library_rust::String_::fromString($0)"
    let v179 : string = Fable.Core.RustInterop.emitRustExpr v177 v178 
    let _run_target_args'_v47 = v179 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v181 : string = "\u001b[92m"
    let v185 : string = method14()
    let v189 : string = v181 + v30 
    let v193 : string = v189 + v185 
    let _run_target_args'_v47 = v193 
    #endif
#if FABLE_COMPILER_PYTHON
    let v197 : string = "\u001b[92m"
    let v201 : string = method14()
    let v205 : string = v197 + v30 
    let v209 : string = v205 + v201 
    let _run_target_args'_v47 = v209 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v213 : string = "\u001b[92m"
    let v217 : string = method14()
    let v221 : string = v213 + v30 
    let v225 : string = v221 + v217 
    let _run_target_args'_v47 = v225 
    #endif
#else
    let v229 : string = "\u001b[92m"
    let v233 : string = method14()
    let v237 : string = v229 + v30 
    let v241 : string = v237 + v233 
    let _run_target_args'_v47 = v241 
    #endif
    let v244 : string = _run_target_args'_v47 
    v244
and method16 (v0 : string) : string =
    let v1 : char list = []
    let v4 : (char list -> (char [])) = List.toArray
    let v5 : (char []) = v4 v1
    let v8 : string = v0.TrimStart v5 
    let v42 : char list = []
    let v44 : char list = '/' :: v42 
    let v48 : char list = ' ' :: v44 
    let v53 : (char list -> (char [])) = List.toArray
    let v54 : (char []) = v53 v48
    let v57 : string = v8.TrimEnd v54 
    v57
and method15 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : (string [])) : string =
    let v9 : string = method13()
    let v10 : Mut3 = {l0 = v9} : Mut3
    let v13 : string = "{ "
    let v14 : string = $"{v13}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure8(v10, v14)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v32 : string = "args"
    let v33 : string = $"{v32}"
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure8(v10, v33)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v51 : string = " = "
    let v52 : string = $"{v51}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure8(v10, v52)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v69 : string = $"%A{v8}"
    let v73 : string = $"{v69}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure8(v10, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = " }"
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure8(v10, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v108 : string = v10.l0
    let v109 : int64 = v0.l0
    let v112 : string = " "
    let v113 : string = v6 + v112 
    let v117 : string = v113 + v7 
    let v122 : string = " #"
    let v123 : string = v117 + v122 
    let v127 : (int64 -> string) = _.ToString()
    let v128 : string = v127 v109
    let v132 : string = v123 + v128 
    let v136 : string = v132 + v112 
    let v141 : string = "documents.main"
    let v142 : string = v136 + v141 
    let v147 : string = " / "
    let v148 : string = v142 + v147 
    let v152 : string = v148 + v108 
    method16(v152)
and closure9 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure11 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure10 () (v0 : string) : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure11(v0)
    let v4 : unit = (fun () -> v3 (); v2) ()
    ()
and method17 (v0 : string) : unit =
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure6()
    let v17 : unit = (fun () -> v16 (); v15) ()
    let struct (v38 : Mut0, v39 : Mut1, v40 : Mut2, v41 : Mut3, v42 : Mut4, v43 : int64 option) = TraceState.trace_state.Value
    let v58 : unit = ()
    let v59 : (unit -> unit) = closure9(v38)
    let v60 : unit = (fun () -> v59 (); v58) ()
    let v63 : (string -> unit) = closure10()
    (* run_target_args'
    let v64 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v65 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v66 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = v41.l0
    let v68 : bool = v67 = ""
    let v83 : string =
        if v68 then
            v0
        else
            let v69 : bool = v0 = ""
            if v69 then
                let v70 : string = v41.l0
                v70
            else
                let v71 : string = v41.l0
                let v74 : string = "\n"
                let v75 : string = v71 + v74 
                let v79 : string = v75 + v0 
                v79
    (* run_target_args'
    let v88 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v89 : string = "&*$0"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v83 v89 
    let _run_target_args'_v88 = v90 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v91 : string = "&*$0"
    let v92 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v83 v91 
    let _run_target_args'_v88 = v92 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v93 : string = "&*$0"
    let v94 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v83 v93 
    let _run_target_args'_v88 = v94 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v96 : Ref<Str> = v83 |> unbox<Ref<Str>>
    let _run_target_args'_v88 = v96 
    #endif
#if FABLE_COMPILER_PYTHON
    let v100 : Ref<Str> = v83 |> unbox<Ref<Str>>
    let _run_target_args'_v88 = v100 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v104 : Ref<Str> = v83 |> unbox<Ref<Str>>
    let _run_target_args'_v88 = v104 
    #endif
#else
    let v108 : Ref<Str> = v83 |> unbox<Ref<Str>>
    let _run_target_args'_v88 = v108 
    #endif
    let v111 : Ref<Str> = _run_target_args'_v88 
    let v120 : string = $"$0.chars()"
    let v121 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v111 v120 
    let v122 : string = "$0"
    let v123 : _ = Fable.Core.RustInterop.emitRustExpr v121 v122 
    let v124 : string = "$0.collect::<Vec<_>>()"
    let v125 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v123 v124 
    let v126 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v127 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v125 v126 
    let v128 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v129 : bool = Fable.Core.RustInterop.emitRustExpr v127 v128 
    let v130 : string = "x"
    let v131 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : string = "String::from_iter($0)"
    let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr v131 v132 
    let v134 : string = "true; $0 }).collect::<Vec<_>>()"
    let v135 : bool = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let v136 : string = "_vec_map"
    let v137 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v136 
    let v138 : string = "$0.len()"
    let v139 : unativeint = Fable.Core.RustInterop.emitRustExpr v137 v138 
    let v145 : int32 = v139 |> int32 
    let v155 : string = ""
    let v156 : bool = v0 <> v155 
    let v160 : bool =
        if v156 then
            let v159 : bool = v145 <= 1
            v159
        else
            false
    if v160 then
        v41.l0 <- v83
        ()
    else
        v41.l0 <- v155
        let v161 : string = "true; $0.into_iter().for_each(|x| { //"
        let v162 : bool = Fable.Core.RustInterop.emitRustExpr v137 v161 
        let v163 : string = "x"
        let v164 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v163 
        let v165 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v166 : bool = Fable.Core.RustInterop.emitRustExpr v164 v165 
        let v167 : string = $"true"
        let v168 : bool = Fable.Core.RustInterop.emitRustExpr () v167 
        let v169 : string = "true; }); //"
        let v170 : bool = Fable.Core.RustInterop.emitRustExpr () v169 
        ()
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v63 v0
    #endif
#if FABLE_COMPILER_PYTHON
    v63 v0
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v63 v0
    #endif
#else
    v63 v0
    #endif
    // run_target_args' is_unit
    let v171 : (string -> unit) = v39.l0
    v171 v0
and closure5 (v0 : (string [])) () : unit =
    let v1 : US0 = US0_2
    let v2 : bool = method7(v1)
    if v2 then
        let v17 : unit = ()
        let v18 : (unit -> unit) = closure6()
        let v19 : unit = (fun () -> v18 (); v17) ()
        let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
        let v58 : string = method8(v40, v41, v42, v43, v44, v45)
        let v59 : string = method12()
        let v60 : string = method15(v40, v41, v42, v43, v44, v45, v58, v59, v0)
        method17(v60)
and method18 () : string =
    let v0 : string = "source-dir"
    v0
and closure12 () (v0 : std_string_String) : US6 =
    US6_0(v0)
and method19 () : (std_string_String -> US6) =
    closure12()
and method20 () : string =
    let v0 : string = "dist-dir"
    v0
and method21 () : string =
    let v0 : string = "cache-dir"
    v0
and method22 () : string =
    let v0 : string = "hangul-spec"
    v0
and method24 () : string =
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
    let v62 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v63 : string = "format!(\"{}\", $0)"
    let v64 : std_string_String = Fable.Core.RustInterop.emitRustExpr v49 v63 
    let _run_target_args'_v62 = v64 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v65 : string = "format!(\"{}\", $0)"
    let v66 : std_string_String = Fable.Core.RustInterop.emitRustExpr v49 v65 
    let _run_target_args'_v62 = v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = "format!(\"{}\", $0)"
    let v68 : std_string_String = Fable.Core.RustInterop.emitRustExpr v49 v67 
    let _run_target_args'_v62 = v68 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v70 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v62 = v70 
    #endif
#if FABLE_COMPILER_PYTHON
    let v74 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v62 = v74 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v78 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v62 = v78 
    #endif
#else
    let v82 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v62 = v82 
    #endif
    let v85 : std_string_String = _run_target_args'_v62 
    let v94 : string = "fable_library_rust::String_::fromString($0)"
    let v95 : string = Fable.Core.RustInterop.emitRustExpr v85 v94 
    let _run_target_args'_v4 = v95 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v97 : string = null |> unbox<string>
    let _run_target_args'_v4 = v97 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v101 : string = null |> unbox<string>
    let _run_target_args'_v4 = v101 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v104 : string = "fs"
    let v105 : IFs = Fable.Core.JsInterop.importAll v104 
    let v106 : string = "fs.realpathSync('.')"
    let v107 : string = Fable.Core.JsInterop.emitJsExpr () v106 
    let _run_target_args'_v4 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v109 : string = null |> unbox<string>
    let _run_target_args'_v4 = v109 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v113 : string = null |> unbox<string>
    let _run_target_args'_v4 = v113 
    #endif
#else
    let v116 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v117 : string = v116 ()
    let _run_target_args'_v4 = v117 
    #endif
    let v118 : string = _run_target_args'_v4 
    v118
and method26 (v0 : string, v1 : string) : string =
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
    let v47 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v48 : string = "String::from($0)"
    let v49 : std_string_String = Fable.Core.RustInterop.emitRustExpr v34 v48 
    let _run_target_args'_v47 = v49 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v50 : string = "String::from($0)"
    let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr v34 v50 
    let _run_target_args'_v47 = v51 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v52 : string = "String::from($0)"
    let v53 : std_string_String = Fable.Core.RustInterop.emitRustExpr v34 v52 
    let _run_target_args'_v47 = v53 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v55 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v47 = v55 
    #endif
#if FABLE_COMPILER_PYTHON
    let v59 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v47 = v59 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v63 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v47 = v63 
    #endif
#else
    let v67 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v47 = v67 
    #endif
    let v70 : std_string_String = _run_target_args'_v47 
    (* run_target_args'
    let v83 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v84 : string = "std::path::PathBuf::from($0)"
    let v85 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v70 v84 
    let _run_target_args'_v83 = v85 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v86 : string = "std::path::PathBuf::from($0)"
    let v87 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v70 v86 
    let _run_target_args'_v83 = v87 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v88 : string = "std::path::PathBuf::from($0)"
    let v89 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v70 v88 
    let _run_target_args'_v83 = v89 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v91 : std_path_PathBuf = v70 |> unbox<std_path_PathBuf>
    let _run_target_args'_v83 = v91 
    #endif
#if FABLE_COMPILER_PYTHON
    let v95 : std_path_PathBuf = v70 |> unbox<std_path_PathBuf>
    let _run_target_args'_v83 = v95 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v99 : std_path_PathBuf = v70 |> unbox<std_path_PathBuf>
    let _run_target_args'_v83 = v99 
    #endif
#else
    let v103 : std_path_PathBuf = v70 |> unbox<std_path_PathBuf>
    let _run_target_args'_v83 = v103 
    #endif
    let v106 : std_path_PathBuf = _run_target_args'_v83 
    (* run_target_args'
    let v119 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v120 : string = "&*$0"
    let v121 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v120 
    let _run_target_args'_v119 = v121 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v122 : string = "&*$0"
    let v123 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v122 
    let _run_target_args'_v119 = v123 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v124 : string = "&*$0"
    let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v124 
    let _run_target_args'_v119 = v125 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v127 : Ref<Str> = v1 |> unbox<Ref<Str>>
    let _run_target_args'_v119 = v127 
    #endif
#if FABLE_COMPILER_PYTHON
    let v131 : Ref<Str> = v1 |> unbox<Ref<Str>>
    let _run_target_args'_v119 = v131 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v135 : Ref<Str> = v1 |> unbox<Ref<Str>>
    let _run_target_args'_v119 = v135 
    #endif
#else
    let v139 : Ref<Str> = v1 |> unbox<Ref<Str>>
    let _run_target_args'_v119 = v139 
    #endif
    let v142 : Ref<Str> = _run_target_args'_v119 
    (* run_target_args'
    let v155 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v156 : string = "String::from($0)"
    let v157 : std_string_String = Fable.Core.RustInterop.emitRustExpr v142 v156 
    let _run_target_args'_v155 = v157 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v158 : string = "String::from($0)"
    let v159 : std_string_String = Fable.Core.RustInterop.emitRustExpr v142 v158 
    let _run_target_args'_v155 = v159 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v160 : string = "String::from($0)"
    let v161 : std_string_String = Fable.Core.RustInterop.emitRustExpr v142 v160 
    let _run_target_args'_v155 = v161 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v163 : std_string_String = v142 |> unbox<std_string_String>
    let _run_target_args'_v155 = v163 
    #endif
#if FABLE_COMPILER_PYTHON
    let v167 : std_string_String = v142 |> unbox<std_string_String>
    let _run_target_args'_v155 = v167 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v171 : std_string_String = v142 |> unbox<std_string_String>
    let _run_target_args'_v155 = v171 
    #endif
#else
    let v175 : std_string_String = v142 |> unbox<std_string_String>
    let _run_target_args'_v155 = v175 
    #endif
    let v178 : std_string_String = _run_target_args'_v155 
    let v187 : string = "$0.join($1)"
    let v188 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v106, v178) v187 
    (* run_target_args'
    let v193 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v194 : string = "$0.display()"
    let v195 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v188 v194 
    let _run_target_args'_v193 = v195 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v196 : string = "$0.display()"
    let v197 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v188 v196 
    let _run_target_args'_v193 = v197 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v198 : string = "$0.display()"
    let v199 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v188 v198 
    let _run_target_args'_v193 = v199 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v201 : std_path_Display = v188 |> unbox<std_path_Display>
    let _run_target_args'_v193 = v201 
    #endif
#if FABLE_COMPILER_PYTHON
    let v205 : std_path_Display = v188 |> unbox<std_path_Display>
    let _run_target_args'_v193 = v205 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v209 : std_path_Display = v188 |> unbox<std_path_Display>
    let _run_target_args'_v193 = v209 
    #endif
#else
    let v213 : std_path_Display = v188 |> unbox<std_path_Display>
    let _run_target_args'_v193 = v213 
    #endif
    let v216 : std_path_Display = _run_target_args'_v193 
    (* run_target_args'
    let v229 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v230 : string = "format!(\"{}\", $0)"
    let v231 : std_string_String = Fable.Core.RustInterop.emitRustExpr v216 v230 
    let _run_target_args'_v229 = v231 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v232 : string = "format!(\"{}\", $0)"
    let v233 : std_string_String = Fable.Core.RustInterop.emitRustExpr v216 v232 
    let _run_target_args'_v229 = v233 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v234 : string = "format!(\"{}\", $0)"
    let v235 : std_string_String = Fable.Core.RustInterop.emitRustExpr v216 v234 
    let _run_target_args'_v229 = v235 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v237 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v229 = v237 
    #endif
#if FABLE_COMPILER_PYTHON
    let v241 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v229 = v241 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v245 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v229 = v245 
    #endif
#else
    let v249 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v229 = v249 
    #endif
    let v252 : std_string_String = _run_target_args'_v229 
    let v261 : string = "fable_library_rust::String_::fromString($0)"
    let v262 : string = Fable.Core.RustInterop.emitRustExpr v252 v261 
    let _run_target_args'_v6 = v262 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v263 : US3 = US3_1
    let v264 : US4 = US4_4(v263)
    let v265 : string = $"file_system.(</>) / target: {v264} / a: {v0} / b: {v1}"
    let v266 : string = failwith<string> v265
    let _run_target_args'_v6 = v266 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v268 : string = null |> unbox<string>
    let _run_target_args'_v6 = v268 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v271 : string = "path"
    let v272 : IPathJoin = Fable.Core.JsInterop.importAll v271 
    let v273 : string = "v272.join($0, $1)"
    let v274 : string = Fable.Core.JsInterop.emitJsExpr struct (v0, v1) v273 
    let _run_target_args'_v6 = v274 
    #endif
#if FABLE_COMPILER_PYTHON
    let v275 : US3 = US3_0
    let v276 : US4 = US4_6(v275)
    let v277 : string = $"file_system.(</>) / target: {v276} / a: {v0} / b: {v1}"
    let v278 : string = failwith<string> v277
    let _run_target_args'_v6 = v278 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v279 : US3 = US3_1
    let v280 : US4 = US4_1(v279)
    let v281 : string = $"file_system.(</>) / target: {v280} / a: {v0} / b: {v1}"
    let v282 : string = failwith<string> v281
    let _run_target_args'_v6 = v282 
    #endif
#else
    let v283 : string = System.IO.Path.Combine (v0, v1)
    let _run_target_args'_v6 = v283 
    #endif
    let v284 : string = _run_target_args'_v6 
    v284
and method28 (v0 : string) : bool =
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
    let v46 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v47 : string = "String::from($0)"
    let v48 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v47 
    let _run_target_args'_v46 = v48 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v49 : string = "String::from($0)"
    let v50 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v49 
    let _run_target_args'_v46 = v50 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v51 : string = "String::from($0)"
    let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v51 
    let _run_target_args'_v46 = v52 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v54 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v46 = v54 
    #endif
#if FABLE_COMPILER_PYTHON
    let v58 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v46 = v58 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v62 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v46 = v62 
    #endif
#else
    let v66 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v46 = v66 
    #endif
    let v69 : std_string_String = _run_target_args'_v46 
    (* run_target_args'
    let v82 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v83 : string = "std::path::PathBuf::from($0)"
    let v84 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v69 v83 
    let _run_target_args'_v82 = v84 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v85 : string = "std::path::PathBuf::from($0)"
    let v86 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v69 v85 
    let _run_target_args'_v82 = v86 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v87 : string = "std::path::PathBuf::from($0)"
    let v88 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v69 v87 
    let _run_target_args'_v82 = v88 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v90 : std_path_PathBuf = v69 |> unbox<std_path_PathBuf>
    let _run_target_args'_v82 = v90 
    #endif
#if FABLE_COMPILER_PYTHON
    let v94 : std_path_PathBuf = v69 |> unbox<std_path_PathBuf>
    let _run_target_args'_v82 = v94 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v98 : std_path_PathBuf = v69 |> unbox<std_path_PathBuf>
    let _run_target_args'_v82 = v98 
    #endif
#else
    let v102 : std_path_PathBuf = v69 |> unbox<std_path_PathBuf>
    let _run_target_args'_v82 = v102 
    #endif
    let v105 : std_path_PathBuf = _run_target_args'_v82 
    let v114 : string = "$0.exists()"
    let v115 : bool = Fable.Core.RustInterop.emitRustExpr v105 v114 
    let v118 : bool =
        if v115 then
            let v116 : string = "$0.is_file()"
            let v117 : bool = Fable.Core.RustInterop.emitRustExpr v105 v116 
            v117
        else
            false
    let _run_target_args'_v5 = v118 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v120 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v120 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v124 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v124 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v127 : string = "fs"
    let v128 : IFsExistsSync = Fable.Core.JsInterop.importAll v127 
    let v129 : string = "$0.existsSync($1)"
    let v130 : bool = Fable.Core.JsInterop.emitJsExpr struct (v128, v0) v129 
    let _run_target_args'_v5 = v130 
    #endif
#if FABLE_COMPILER_PYTHON
    let v132 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v132 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v136 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v136 
    #endif
#else
    let v139 : (string -> bool) = System.IO.File.Exists
    let v140 : bool = v139 v0
    let _run_target_args'_v5 = v140 
    #endif
    let v141 : bool = _run_target_args'_v5 
    v141
and closure13 () (v0 : string) : bool =
    method28(v0)
and method29 (v0 : string) : bool =
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
    let v46 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v47 : string = "String::from($0)"
    let v48 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v47 
    let _run_target_args'_v46 = v48 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v49 : string = "String::from($0)"
    let v50 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v49 
    let _run_target_args'_v46 = v50 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v51 : string = "String::from($0)"
    let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v51 
    let _run_target_args'_v46 = v52 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v54 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v46 = v54 
    #endif
#if FABLE_COMPILER_PYTHON
    let v58 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v46 = v58 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v62 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v46 = v62 
    #endif
#else
    let v66 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v46 = v66 
    #endif
    let v69 : std_string_String = _run_target_args'_v46 
    (* run_target_args'
    let v82 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v83 : string = "std::path::PathBuf::from($0)"
    let v84 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v69 v83 
    let _run_target_args'_v82 = v84 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v85 : string = "std::path::PathBuf::from($0)"
    let v86 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v69 v85 
    let _run_target_args'_v82 = v86 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v87 : string = "std::path::PathBuf::from($0)"
    let v88 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v69 v87 
    let _run_target_args'_v82 = v88 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v90 : std_path_PathBuf = v69 |> unbox<std_path_PathBuf>
    let _run_target_args'_v82 = v90 
    #endif
#if FABLE_COMPILER_PYTHON
    let v94 : std_path_PathBuf = v69 |> unbox<std_path_PathBuf>
    let _run_target_args'_v82 = v94 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v98 : std_path_PathBuf = v69 |> unbox<std_path_PathBuf>
    let _run_target_args'_v82 = v98 
    #endif
#else
    let v102 : std_path_PathBuf = v69 |> unbox<std_path_PathBuf>
    let _run_target_args'_v82 = v102 
    #endif
    let v105 : std_path_PathBuf = _run_target_args'_v82 
    let v114 : string = "$0.exists()"
    let v115 : bool = Fable.Core.RustInterop.emitRustExpr v105 v114 
    let v118 : bool =
        if v115 then
            let v116 : string = "$0.is_dir()"
            let v117 : bool = Fable.Core.RustInterop.emitRustExpr v105 v116 
            v117
        else
            false
    let _run_target_args'_v5 = v118 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v120 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v120 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v124 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v124 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v127 : string = "fs"
    let v128 : IFsExistsSync = Fable.Core.JsInterop.importAll v127 
    let v129 : string = "$0.existsSync($1)"
    let v130 : bool = Fable.Core.JsInterop.emitJsExpr struct (v128, v0) v129 
    let _run_target_args'_v5 = v130 
    #endif
#if FABLE_COMPILER_PYTHON
    let v132 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v132 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v136 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v136 
    #endif
#else
    let v139 : (string -> bool) = System.IO.Directory.Exists
    let v140 : bool = v139 v0
    let _run_target_args'_v5 = v140 
    #endif
    let v141 : bool = _run_target_args'_v5 
    v141
and closure14 () (v0 : string) : bool =
    method29(v0)
and method31 (v0 : string) : string option =
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
    let v46 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v47 : string = "String::from($0)"
    let v48 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v47 
    let _run_target_args'_v46 = v48 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v49 : string = "String::from($0)"
    let v50 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v49 
    let _run_target_args'_v46 = v50 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v51 : string = "String::from($0)"
    let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v51 
    let _run_target_args'_v46 = v52 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v54 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v46 = v54 
    #endif
#if FABLE_COMPILER_PYTHON
    let v58 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v46 = v58 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v62 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v46 = v62 
    #endif
#else
    let v66 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v46 = v66 
    #endif
    let v69 : std_string_String = _run_target_args'_v46 
    (* run_target_args'
    let v82 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v83 : string = "std::path::PathBuf::from($0)"
    let v84 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v69 v83 
    let _run_target_args'_v82 = v84 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v85 : string = "std::path::PathBuf::from($0)"
    let v86 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v69 v85 
    let _run_target_args'_v82 = v86 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v87 : string = "std::path::PathBuf::from($0)"
    let v88 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v69 v87 
    let _run_target_args'_v82 = v88 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v90 : std_path_PathBuf = v69 |> unbox<std_path_PathBuf>
    let _run_target_args'_v82 = v90 
    #endif
#if FABLE_COMPILER_PYTHON
    let v94 : std_path_PathBuf = v69 |> unbox<std_path_PathBuf>
    let _run_target_args'_v82 = v94 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v98 : std_path_PathBuf = v69 |> unbox<std_path_PathBuf>
    let _run_target_args'_v82 = v98 
    #endif
#else
    let v102 : std_path_PathBuf = v69 |> unbox<std_path_PathBuf>
    let _run_target_args'_v82 = v102 
    #endif
    let v105 : std_path_PathBuf = _run_target_args'_v82 
    let v114 : string = "$0.parent().map(std::path::PathBuf::from)"
    let v115 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v105 v114 
    let v116 : string = "true; let _optionm_map_ = $0.map(|x| { //"
    let v117 : bool = Fable.Core.RustInterop.emitRustExpr v115 v116 
    let v118 : string = "x"
    let v119 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v118 
    (* run_target_args'
    let v124 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v125 : string = "$0.display()"
    let v126 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v119 v125 
    let _run_target_args'_v124 = v126 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v127 : string = "$0.display()"
    let v128 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v119 v127 
    let _run_target_args'_v124 = v128 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v129 : string = "$0.display()"
    let v130 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v119 v129 
    let _run_target_args'_v124 = v130 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v132 : std_path_Display = v119 |> unbox<std_path_Display>
    let _run_target_args'_v124 = v132 
    #endif
#if FABLE_COMPILER_PYTHON
    let v136 : std_path_Display = v119 |> unbox<std_path_Display>
    let _run_target_args'_v124 = v136 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v140 : std_path_Display = v119 |> unbox<std_path_Display>
    let _run_target_args'_v124 = v140 
    #endif
#else
    let v144 : std_path_Display = v119 |> unbox<std_path_Display>
    let _run_target_args'_v124 = v144 
    #endif
    let v147 : std_path_Display = _run_target_args'_v124 
    (* run_target_args'
    let v160 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v161 : string = "format!(\"{}\", $0)"
    let v162 : std_string_String = Fable.Core.RustInterop.emitRustExpr v147 v161 
    let _run_target_args'_v160 = v162 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v163 : string = "format!(\"{}\", $0)"
    let v164 : std_string_String = Fable.Core.RustInterop.emitRustExpr v147 v163 
    let _run_target_args'_v160 = v164 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v165 : string = "format!(\"{}\", $0)"
    let v166 : std_string_String = Fable.Core.RustInterop.emitRustExpr v147 v165 
    let _run_target_args'_v160 = v166 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v168 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v160 = v168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v172 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v160 = v172 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v176 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v160 = v176 
    #endif
#else
    let v180 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v160 = v180 
    #endif
    let v183 : std_string_String = _run_target_args'_v160 
    let v192 : string = "fable_library_rust::String_::fromString($0)"
    let v193 : string = Fable.Core.RustInterop.emitRustExpr v183 v192 
    let v194 : string = "true; $0 })"
    let v195 : bool = Fable.Core.RustInterop.emitRustExpr v193 v194 
    let v196 : string = "_optionm_map_"
    let v197 : string option = Fable.Core.RustInterop.emitRustExpr () v196 
    let _run_target_args'_v5 = v197 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v199 : string option = None
    let _run_target_args'_v5 = v199 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v203 : string option = None
    let _run_target_args'_v5 = v203 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v206 : string = "path"
    let v207 : IPathDirname = Fable.Core.JsInterop.importAll v206 
    let v208 : string = "v207.dirname($0)"
    let v209 : string = Fable.Core.JsInterop.emitJsExpr v0 v208 
    let v210 : bool = v209 = v0
    let v213 : US5 =
        if v210 then
            US5_1
        else
            US5_0(v209)
    let v224 : string option =
        match v213 with
        | US5_1 -> (* None *)
            let v220 : string option = None
            v220
        | US5_0(v214) -> (* Some *)
            let v216 : string option = Some v214 
            v216
    let _run_target_args'_v5 = v224 
    #endif
#if FABLE_COMPILER_PYTHON
    let v226 : string option = None
    let _run_target_args'_v5 = v226 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v230 : string option = None
    let _run_target_args'_v5 = v230 
    #endif
#else
    let v233 : (string -> System_IO_DirectoryInfo) = System.IO.Directory.GetParent
    let v234 : System_IO_DirectoryInfo = v233 v0
    let v236 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let v240 : bool = v234 = v236 
    let v285 : US5 =
        if v240 then
            US5_1
        else
            (* run_target_args'
            let v248 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v250 : string = null |> unbox<string>
            let _run_target_args'_v248 = v250 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v254 : string = null |> unbox<string>
            let _run_target_args'_v248 = v254 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v258 : string = null |> unbox<string>
            let _run_target_args'_v248 = v258 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v262 : string = null |> unbox<string>
            let _run_target_args'_v248 = v262 
            #endif
#if FABLE_COMPILER_PYTHON
            let v266 : string = null |> unbox<string>
            let _run_target_args'_v248 = v266 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v270 : string = null |> unbox<string>
            let _run_target_args'_v248 = v270 
            #endif
#else
            let v273 : (System_IO_DirectoryInfo -> string) = _.FullName
            let v274 : string = v273 v234
            let _run_target_args'_v248 = v274 
            #endif
            let v275 : string = _run_target_args'_v248 
            US5_0(v275)
    let v296 : string option =
        match v285 with
        | US5_1 -> (* None *)
            let v292 : string option = None
            v292
        | US5_0(v286) -> (* Some *)
            let v288 : string option = Some v286 
            v288
    let _run_target_args'_v5 = v296 
    #endif
    let v297 : string option = _run_target_args'_v5 
    v297
and method32 (v0 : string, v1 : string, v2 : bool, v3 : (string -> bool), v4 : string) : US8 =
    let v5 : string = method26(v4, v0)
    let v6 : bool = v3 v5
    if v6 then
        US8_0(v4)
    else
        let v8 : string option = method31(v4)
        let v11 : (string -> US5) = method6()
        let v12 : US5 option = v8 |> Option.map v11 
        let v32 : US5 = US5_1
        let v33 : US5 = v12 |> Option.defaultValue v32 
        match v33 with
        | US5_1 -> (* None *)
            let v39 : string = $"""file_system.find_parent / No parent for {if v2 then "file" else "dir"}"""
            let v40 : string = $" '{v0}' at '{v1}' (until '{v4}')"
            let v41 : string = v39 + v40 
            US8_1(v41)
        | US5_0(v37) -> (* Some *)
            method32(v0, v1, v2, v3, v37)
and method30 (v0 : string, v1 : string, v2 : bool, v3 : (string -> bool)) : US8 =
    let v4 : string = method26(v1, v0)
    let v5 : bool = v3 v4
    if v5 then
        US8_0(v1)
    else
        let v7 : string option = method31(v1)
        let v10 : (string -> US5) = method6()
        let v11 : US5 option = v7 |> Option.map v10 
        let v31 : US5 = US5_1
        let v32 : US5 = v11 |> Option.defaultValue v31 
        match v32 with
        | US5_1 -> (* None *)
            let v38 : string = $"""file_system.find_parent / No parent for {if v2 then "file" else "dir"}"""
            let v39 : string = $" '{v0}' at '{v1}' (until '{v1}')"
            let v40 : string = v38 + v39 
            US8_1(v40)
        | US5_0(v36) -> (* Some *)
            method32(v0, v1, v2, v3, v36)
and method27 (v0 : US7, v1 : string, v2 : string) : US8 =
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
    method30(v1, v2, v3, v6)
and method33 () : string =
    
    
    
    
    
    let v2 : string = "Warning"
    let v3 : (unit -> string) = v2.ToLower
    let v4 : string = v3 ()
    let v7 : char = v4.[int 0]
    let v8 : string = method13()
    let v9 : Mut3 = {l0 = v8} : Mut3
    let v14 : string = $"{v7}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure8(v9, v14)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v30 : string = v9.l0
    (* run_target_args'
    let v47 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v48 : string = "inline_colorization::color_yellow"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48 
    (* run_target_args'
    let v54 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v55 : string = "&*$0"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v55 
    let _run_target_args'_v54 = v56 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v57 : string = "&*$0"
    let v58 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v57 
    let _run_target_args'_v54 = v58 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v59 : string = "&*$0"
    let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v59 
    let _run_target_args'_v54 = v60 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v62 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v62 
    #endif
#if FABLE_COMPILER_PYTHON
    let v66 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v66 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v70 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v70 
    #endif
#else
    let v74 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v74 
    #endif
    let v77 : Ref<Str> = _run_target_args'_v54 
    let v86 : string = "inline_colorization::color_reset"
    let v87 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v86 
    let v88 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v89 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v49, v77, v87) v88 
    let v90 : string = "fable_library_rust::String_::fromString($0)"
    let v91 : string = Fable.Core.RustInterop.emitRustExpr v89 v90 
    let _run_target_args'_v47 = v91 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v92 : string = "inline_colorization::color_yellow"
    let v93 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v92 
    (* run_target_args'
    let v98 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v99 : string = "&*$0"
    let v100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v99 
    let _run_target_args'_v98 = v100 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v101 : string = "&*$0"
    let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v101 
    let _run_target_args'_v98 = v102 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v103 : string = "&*$0"
    let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v103 
    let _run_target_args'_v98 = v104 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v106 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v106 
    #endif
#if FABLE_COMPILER_PYTHON
    let v110 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v110 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v114 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v114 
    #endif
#else
    let v118 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v118 
    #endif
    let v121 : Ref<Str> = _run_target_args'_v98 
    let v130 : string = "inline_colorization::color_reset"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v93, v121, v131) v132 
    let v134 : string = "fable_library_rust::String_::fromString($0)"
    let v135 : string = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let _run_target_args'_v47 = v135 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v136 : string = "inline_colorization::color_yellow"
    let v137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v136 
    (* run_target_args'
    let v142 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v143 : string = "&*$0"
    let v144 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v143 
    let _run_target_args'_v142 = v144 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v145 : string = "&*$0"
    let v146 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v145 
    let _run_target_args'_v142 = v146 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v147 : string = "&*$0"
    let v148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v147 
    let _run_target_args'_v142 = v148 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v150 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v150 
    #endif
#if FABLE_COMPILER_PYTHON
    let v154 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v154 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v158 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v158 
    #endif
#else
    let v162 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v162 
    #endif
    let v165 : Ref<Str> = _run_target_args'_v142 
    let v174 : string = "inline_colorization::color_reset"
    let v175 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v174 
    let v176 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v177 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v137, v165, v175) v176 
    let v178 : string = "fable_library_rust::String_::fromString($0)"
    let v179 : string = Fable.Core.RustInterop.emitRustExpr v177 v178 
    let _run_target_args'_v47 = v179 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v181 : string = "\u001b[93m"
    let v185 : string = method14()
    let v189 : string = v181 + v30 
    let v193 : string = v189 + v185 
    let _run_target_args'_v47 = v193 
    #endif
#if FABLE_COMPILER_PYTHON
    let v197 : string = "\u001b[93m"
    let v201 : string = method14()
    let v205 : string = v197 + v30 
    let v209 : string = v205 + v201 
    let _run_target_args'_v47 = v209 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v213 : string = "\u001b[93m"
    let v217 : string = method14()
    let v221 : string = v213 + v30 
    let v225 : string = v221 + v217 
    let _run_target_args'_v47 = v225 
    #endif
#else
    let v229 : string = "\u001b[93m"
    let v233 : string = method14()
    let v237 : string = v229 + v30 
    let v241 : string = v237 + v233 
    let _run_target_args'_v47 = v241 
    #endif
    let v244 : string = _run_target_args'_v47 
    v244
and method34 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string) : string =
    let v10 : string = method13()
    let v11 : Mut3 = {l0 = v10} : Mut3
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure8(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "dir"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure8(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure8(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v70 : string = $"{v8}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure8(v11, v70)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v88 : string = "; "
    let v89 : string = $"{v88}"
    let v97 : unit = ()
    let v98 : (unit -> unit) = closure8(v11, v89)
    let v99 : unit = (fun () -> v98 (); v97) ()
    let v107 : string = "error"
    let v108 : string = $"{v107}"
    let v116 : unit = ()
    let v117 : (unit -> unit) = closure8(v11, v108)
    let v118 : unit = (fun () -> v117 (); v116) ()
    let v125 : string = $"{v52}"
    let v133 : unit = ()
    let v134 : (unit -> unit) = closure8(v11, v125)
    let v135 : unit = (fun () -> v134 (); v133) ()
    let v142 : string = $"{v9}"
    let v150 : unit = ()
    let v151 : (unit -> unit) = closure8(v11, v142)
    let v152 : unit = (fun () -> v151 (); v150) ()
    let v160 : string = " }"
    let v161 : string = $"{v160}"
    let v169 : unit = ()
    let v170 : (unit -> unit) = closure8(v11, v161)
    let v171 : unit = (fun () -> v170 (); v169) ()
    let v177 : string = v11.l0
    let v178 : int64 = v0.l0
    let v181 : string = " "
    let v182 : string = v6 + v181 
    let v186 : string = v182 + v7 
    let v191 : string = " #"
    let v192 : string = v186 + v191 
    let v196 : (int64 -> string) = _.ToString()
    let v197 : string = v196 v178
    let v201 : string = v192 + v197 
    let v205 : string = v201 + v181 
    let v210 : string = "file_system.get_workspace_root"
    let v211 : string = v205 + v210 
    let v216 : string = " / "
    let v217 : string = v211 + v216 
    let v221 : string = v217 + v177 
    method16(v221)
and closure15 (v0 : string, v1 : string) () : unit =
    let v2 : US0 = US0_3
    let v3 : bool = method7(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure6()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut0, v42 : Mut1, v43 : Mut2, v44 : Mut3, v45 : Mut4, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method8(v41, v42, v43, v44, v45, v46)
        let v60 : string = method33()
        let v61 : string = method34(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method17(v61)
and closure16 () (v0 : std_io_Error) : string =
    let v1 : string = method13()
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
    let v46 : string = $"{v36}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure8(v2, v46)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v62 : string = v2.l0
    v62
and method38 () : (std_io_Error -> string) =
    closure16()
and closure17 () (v0 : std_path_PathBuf) : US9 =
    US9_0(v0)
and method39 () : (std_path_PathBuf -> US9) =
    closure17()
and closure18 () (v0 : string) : US9 =
    US9_1(v0)
and method40 () : (string -> US9) =
    closure18()
and method43 (v0 : string) : string =
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
    let v46 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v47 : string = "String::from($0)"
    let v48 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v47 
    let _run_target_args'_v46 = v48 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v49 : string = "String::from($0)"
    let v50 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v49 
    let _run_target_args'_v46 = v50 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v51 : string = "String::from($0)"
    let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v51 
    let _run_target_args'_v46 = v52 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v54 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v46 = v54 
    #endif
#if FABLE_COMPILER_PYTHON
    let v58 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v46 = v58 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v62 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v46 = v62 
    #endif
#else
    let v66 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v46 = v66 
    #endif
    let v69 : std_string_String = _run_target_args'_v46 
    (* run_target_args'
    let v82 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v83 : string = "std::path::PathBuf::from($0)"
    let v84 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v69 v83 
    let _run_target_args'_v82 = v84 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v85 : string = "std::path::PathBuf::from($0)"
    let v86 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v69 v85 
    let _run_target_args'_v82 = v86 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v87 : string = "std::path::PathBuf::from($0)"
    let v88 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v69 v87 
    let _run_target_args'_v82 = v88 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v90 : std_path_PathBuf = v69 |> unbox<std_path_PathBuf>
    let _run_target_args'_v82 = v90 
    #endif
#if FABLE_COMPILER_PYTHON
    let v94 : std_path_PathBuf = v69 |> unbox<std_path_PathBuf>
    let _run_target_args'_v82 = v94 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v98 : std_path_PathBuf = v69 |> unbox<std_path_PathBuf>
    let _run_target_args'_v82 = v98 
    #endif
#else
    let v102 : std_path_PathBuf = v69 |> unbox<std_path_PathBuf>
    let _run_target_args'_v82 = v102 
    #endif
    let v105 : std_path_PathBuf = _run_target_args'_v82 
    let v114 : string = "$0.file_name()"
    let v115 : Ref<std_ffi_OsStr> option = Fable.Core.RustInterop.emitRustExpr v105 v114 
    let v116 : string = "true; let _optionm_map_ = $0.map(|x| { //"
    let v117 : bool = Fable.Core.RustInterop.emitRustExpr v115 v116 
    let v118 : string = "x"
    let v119 : Ref<std_ffi_OsStr> = Fable.Core.RustInterop.emitRustExpr () v118 
    let v120 : string = "$0.to_os_string()"
    let v121 : std_ffi_OsString = Fable.Core.RustInterop.emitRustExpr v119 v120 
    let v122 : string = "$0.to_str()"
    let v123 : Ref<Str> option = Fable.Core.RustInterop.emitRustExpr v121 v122 
    let v124 : string = "$0.unwrap()"
    let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v123 v124 
    (* run_target_args'
    let v130 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v131 : string = "String::from($0)"
    let v132 : std_string_String = Fable.Core.RustInterop.emitRustExpr v125 v131 
    let _run_target_args'_v130 = v132 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v133 : string = "String::from($0)"
    let v134 : std_string_String = Fable.Core.RustInterop.emitRustExpr v125 v133 
    let _run_target_args'_v130 = v134 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v135 : string = "String::from($0)"
    let v136 : std_string_String = Fable.Core.RustInterop.emitRustExpr v125 v135 
    let _run_target_args'_v130 = v136 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v138 : std_string_String = v125 |> unbox<std_string_String>
    let _run_target_args'_v130 = v138 
    #endif
#if FABLE_COMPILER_PYTHON
    let v142 : std_string_String = v125 |> unbox<std_string_String>
    let _run_target_args'_v130 = v142 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v146 : std_string_String = v125 |> unbox<std_string_String>
    let _run_target_args'_v130 = v146 
    #endif
#else
    let v150 : std_string_String = v125 |> unbox<std_string_String>
    let _run_target_args'_v130 = v150 
    #endif
    let v153 : std_string_String = _run_target_args'_v130 
    let v162 : string = "fable_library_rust::String_::fromString($0)"
    let v163 : string = Fable.Core.RustInterop.emitRustExpr v153 v162 
    let v164 : string = "true; $0 })"
    let v165 : bool = Fable.Core.RustInterop.emitRustExpr v163 v164 
    let v166 : string = "_optionm_map_"
    let v167 : string option = Fable.Core.RustInterop.emitRustExpr () v166 
    let v170 : (string -> US5) = method6()
    let v171 : US5 option = v167 |> Option.map v170 
    let v191 : US5 = US5_1
    let v192 : US5 = v171 |> Option.defaultValue v191 
    let v199 : string =
        match v192 with
        | US5_1 -> (* None *)
            let v197 : string = ""
            v197
        | US5_0(v196) -> (* Some *)
            v196
    let _run_target_args'_v5 = v199 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v200 : US3 = US3_1
    let v201 : US4 = US4_4(v200)
    let v202 : string = $"file_system.get_file_name / target: {v201} / path: {v0}"
    let v203 : string = failwith<string> v202
    let _run_target_args'_v5 = v203 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v205 : string = null |> unbox<string>
    let _run_target_args'_v5 = v205 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v208 : string = "path"
    let v209 : IPathBasename = Fable.Core.JsInterop.importAll v208 
    let v210 : string = "v209.basename($0)"
    let v211 : string = Fable.Core.JsInterop.emitJsExpr v0 v210 
    let _run_target_args'_v5 = v211 
    #endif
#if FABLE_COMPILER_PYTHON
    let v212 : US3 = US3_0
    let v213 : US4 = US4_6(v212)
    let v214 : string = $"file_system.get_file_name / target: {v213} / path: {v0}"
    let v215 : string = failwith<string> v214
    let _run_target_args'_v5 = v215 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v216 : US3 = US3_1
    let v217 : US4 = US4_1(v216)
    let v218 : string = $"file_system.get_file_name / target: {v217} / path: {v0}"
    let v219 : string = failwith<string> v218
    let _run_target_args'_v5 = v219 
    #endif
#else
    let v220 : (string -> string) = System.IO.Path.GetFileName
    let v221 : string = v220 v0
    let _run_target_args'_v5 = v221 
    #endif
    let v222 : string = _run_target_args'_v5 
    v222
and method42 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : string, v4 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v5 : string = method43(v4)
    let v6 : string option = method31(v4)
    let v9 : (string -> US5) = method6()
    let v10 : US5 option = v6 |> Option.map v9 
    let v30 : US5 = US5_1
    let v31 : US5 = v10 |> Option.defaultValue v30 
    let v35 : string = method13()
    let v36 : Mut3 = {l0 = v35} : Mut3
    let v38 : string = $"{v3}"
    let v46 : unit = ()
    let v47 : (unit -> unit) = closure8(v36, v38)
    let v48 : unit = (fun () -> v47 (); v46) ()
    let v54 : string = v36.l0
    let v55 : bool = v2 >= 11uy
    if v55 then
        let v56 : string = $"file_system.read_link / "
        let v57 : string = $"path: {v0} / n: {v2} / path': {v4} / name: {v5}"
        let v58 : string = v56 + v57 
        (* run_target_args'
        let v63 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v64 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v65 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v58 v64 
        let _run_target_args'_v63 = v65 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v66 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v67 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v58 v66 
        let _run_target_args'_v63 = v67 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v68 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v69 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v58 v68 
        let _run_target_args'_v63 = v69 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v71 : std_io_Error = v58 |> unbox<std_io_Error>
        let _run_target_args'_v63 = v71 
        #endif
#if FABLE_COMPILER_PYTHON
        let v75 : std_io_Error = v58 |> unbox<std_io_Error>
        let _run_target_args'_v63 = v75 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v79 : std_io_Error = v58 |> unbox<std_io_Error>
        let _run_target_args'_v63 = v79 
        #endif
#else
        let v83 : std_io_Error = v58 |> unbox<std_io_Error>
        let _run_target_args'_v63 = v83 
        #endif
        let v86 : std_io_Error = _run_target_args'_v63 
        (* run_target_args'
        let v96 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v97 : string = "Err($0)"
        let v98 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v86 v97 
        let _run_target_args'_v96 = v98 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v99 : string = "Err($0)"
        let v100 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v86 v99 
        let _run_target_args'_v96 = v100 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v101 : string = "Err($0)"
        let v102 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v86 v101 
        let _run_target_args'_v96 = v102 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v103 : Result<std_path_PathBuf, std_io_Error> = v86 |> Error
        let _run_target_args'_v96 = v103 
        #endif
#if FABLE_COMPILER_PYTHON
        let v104 : Result<std_path_PathBuf, std_io_Error> = v86 |> Error
        let _run_target_args'_v96 = v104 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v105 : Result<std_path_PathBuf, std_io_Error> = v86 |> Error
        let _run_target_args'_v96 = v105 
        #endif
#else
        let v106 : Result<std_path_PathBuf, std_io_Error> = v86 |> Error
        let _run_target_args'_v96 = v106 
        #endif
        let v107 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v96 
        v107
    else
        match v31 with
        | US5_0(v110) -> (* Some *)
            let v113 : string = ""
            let v114 : bool = v4 <> v113 
            if v114 then
                let v117 : uint8 = v2 + 1uy
                let v118 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v117
                let v119 : Result<std_path_PathBuf, std_io_Error> = v118 v110
                let v120 : (std_io_Error -> string) = method38()
                (* run_target_args'
                let v122 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v123 : string = "$0.map_err(|x| $1(x))"
                let v124 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v119, v120) v123 
                let _run_target_args'_v122 = v124 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v125 : string = "$0.map_err(|x| $1(x))"
                let v126 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v119, v120) v125 
                let _run_target_args'_v122 = v126 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v127 : string = "$0.map_err(|x| $1(x))"
                let v128 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v119, v120) v127 
                let _run_target_args'_v122 = v128 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v129 : Result<std_path_PathBuf, string> = match v119 with Ok x -> Ok x | Error x -> Error (v120 x)
                let _run_target_args'_v122 = v129 
                #endif
#if FABLE_COMPILER_PYTHON
                let v130 : Result<std_path_PathBuf, string> = match v119 with Ok x -> Ok x | Error x -> Error (v120 x)
                let _run_target_args'_v122 = v130 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v131 : Result<std_path_PathBuf, string> = match v119 with Ok x -> Ok x | Error x -> Error (v120 x)
                let _run_target_args'_v122 = v131 
                #endif
#else
                let v132 : Result<std_path_PathBuf, string> = match v119 with Ok x -> Ok x | Error x -> Error (v120 x)
                let _run_target_args'_v122 = v132 
                #endif
                let v133 : Result<std_path_PathBuf, string> = _run_target_args'_v122 
                let v136 : (std_path_PathBuf -> US9) = method39()
                let v137 : (string -> US9) = method40()
                let v139 : US9 = match v133 with Ok x -> v136 x | Error x -> v137 x
                match v139 with
                | US9_1(v307) -> (* Error *)
                    let v308 : string = $"file_system.read_link / "
                    let v309 : string = $"error': {v307} / error: {v54} / name: {v5}"
                    let v310 : string = v308 + v309 
                    (* run_target_args'
                    let v315 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v316 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v317 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v310 v316 
                    let _run_target_args'_v315 = v317 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v318 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v319 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v310 v318 
                    let _run_target_args'_v315 = v319 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v320 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v321 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v310 v320 
                    let _run_target_args'_v315 = v321 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v323 : std_io_Error = v310 |> unbox<std_io_Error>
                    let _run_target_args'_v315 = v323 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v327 : std_io_Error = v310 |> unbox<std_io_Error>
                    let _run_target_args'_v315 = v327 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v331 : std_io_Error = v310 |> unbox<std_io_Error>
                    let _run_target_args'_v315 = v331 
                    #endif
#else
                    let v335 : std_io_Error = v310 |> unbox<std_io_Error>
                    let _run_target_args'_v315 = v335 
                    #endif
                    let v338 : std_io_Error = _run_target_args'_v315 
                    (* run_target_args'
                    let v348 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v349 : string = "Err($0)"
                    let v350 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v338 v349 
                    let _run_target_args'_v348 = v350 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v351 : string = "Err($0)"
                    let v352 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v338 v351 
                    let _run_target_args'_v348 = v352 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v353 : string = "Err($0)"
                    let v354 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v338 v353 
                    let _run_target_args'_v348 = v354 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v355 : Result<std_path_PathBuf, std_io_Error> = v338 |> Error
                    let _run_target_args'_v348 = v355 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v356 : Result<std_path_PathBuf, std_io_Error> = v338 |> Error
                    let _run_target_args'_v348 = v356 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v357 : Result<std_path_PathBuf, std_io_Error> = v338 |> Error
                    let _run_target_args'_v348 = v357 
                    #endif
#else
                    let v358 : Result<std_path_PathBuf, std_io_Error> = v338 |> Error
                    let _run_target_args'_v348 = v358 
                    #endif
                    let v359 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v348 
                    v359
                | US9_0(v142) -> (* Ok *)
                    (* run_target_args'
                    let v147 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v148 : string = "$0.display()"
                    let v149 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v142 v148 
                    let _run_target_args'_v147 = v149 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v150 : string = "$0.display()"
                    let v151 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v142 v150 
                    let _run_target_args'_v147 = v151 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v152 : string = "$0.display()"
                    let v153 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v142 v152 
                    let _run_target_args'_v147 = v153 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v155 : std_path_Display = v142 |> unbox<std_path_Display>
                    let _run_target_args'_v147 = v155 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v159 : std_path_Display = v142 |> unbox<std_path_Display>
                    let _run_target_args'_v147 = v159 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v163 : std_path_Display = v142 |> unbox<std_path_Display>
                    let _run_target_args'_v147 = v163 
                    #endif
#else
                    let v167 : std_path_Display = v142 |> unbox<std_path_Display>
                    let _run_target_args'_v147 = v167 
                    #endif
                    let v170 : std_path_Display = _run_target_args'_v147 
                    let v180 : string = v170 |> string 
                    let v183 : string = method26(v180, v5)
                    (* run_target_args'
                    let v188 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v189 : string = "&*$0"
                    let v190 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v183 v189 
                    let _run_target_args'_v188 = v190 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v191 : string = "&*$0"
                    let v192 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v183 v191 
                    let _run_target_args'_v188 = v192 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v193 : string = "&*$0"
                    let v194 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v183 v193 
                    let _run_target_args'_v188 = v194 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v196 : Ref<Str> = v183 |> unbox<Ref<Str>>
                    let _run_target_args'_v188 = v196 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v200 : Ref<Str> = v183 |> unbox<Ref<Str>>
                    let _run_target_args'_v188 = v200 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v204 : Ref<Str> = v183 |> unbox<Ref<Str>>
                    let _run_target_args'_v188 = v204 
                    #endif
#else
                    let v208 : Ref<Str> = v183 |> unbox<Ref<Str>>
                    let _run_target_args'_v188 = v208 
                    #endif
                    let v211 : Ref<Str> = _run_target_args'_v188 
                    (* run_target_args'
                    let v224 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v225 : string = "String::from($0)"
                    let v226 : std_string_String = Fable.Core.RustInterop.emitRustExpr v211 v225 
                    let _run_target_args'_v224 = v226 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v227 : string = "String::from($0)"
                    let v228 : std_string_String = Fable.Core.RustInterop.emitRustExpr v211 v227 
                    let _run_target_args'_v224 = v228 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v229 : string = "String::from($0)"
                    let v230 : std_string_String = Fable.Core.RustInterop.emitRustExpr v211 v229 
                    let _run_target_args'_v224 = v230 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v232 : std_string_String = v211 |> unbox<std_string_String>
                    let _run_target_args'_v224 = v232 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v236 : std_string_String = v211 |> unbox<std_string_String>
                    let _run_target_args'_v224 = v236 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v240 : std_string_String = v211 |> unbox<std_string_String>
                    let _run_target_args'_v224 = v240 
                    #endif
#else
                    let v244 : std_string_String = v211 |> unbox<std_string_String>
                    let _run_target_args'_v224 = v244 
                    #endif
                    let v247 : std_string_String = _run_target_args'_v224 
                    (* run_target_args'
                    let v260 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v261 : string = "std::path::PathBuf::from($0)"
                    let v262 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v247 v261 
                    let _run_target_args'_v260 = v262 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v263 : string = "std::path::PathBuf::from($0)"
                    let v264 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v247 v263 
                    let _run_target_args'_v260 = v264 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v265 : string = "std::path::PathBuf::from($0)"
                    let v266 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v247 v265 
                    let _run_target_args'_v260 = v266 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v268 : std_path_PathBuf = v247 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v260 = v268 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v272 : std_path_PathBuf = v247 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v260 = v272 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v276 : std_path_PathBuf = v247 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v260 = v276 
                    #endif
#else
                    let v280 : std_path_PathBuf = v247 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v260 = v280 
                    #endif
                    let v283 : std_path_PathBuf = _run_target_args'_v260 
                    (* run_target_args'
                    let v293 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v294 : string = "Ok($0)"
                    let v295 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v283 v294 
                    let _run_target_args'_v293 = v295 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v296 : string = "Ok($0)"
                    let v297 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v283 v296 
                    let _run_target_args'_v293 = v297 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v298 : string = "Ok($0)"
                    let v299 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v283 v298 
                    let _run_target_args'_v293 = v299 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v300 : Result<std_path_PathBuf, std_io_Error> = v283 |> Ok
                    let _run_target_args'_v293 = v300 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v301 : Result<std_path_PathBuf, std_io_Error> = v283 |> Ok
                    let _run_target_args'_v293 = v301 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v302 : Result<std_path_PathBuf, std_io_Error> = v283 |> Ok
                    let _run_target_args'_v293 = v302 
                    #endif
#else
                    let v303 : Result<std_path_PathBuf, std_io_Error> = v283 |> Ok
                    let _run_target_args'_v293 = v303 
                    #endif
                    let v304 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v293 
                    v304
            else
                let v364 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v365 : string = $"path: {v0} / error: {v54} / path': {v4} / name: {v5}"
                let v366 : string = v364 + v365 
                (* run_target_args'
                let v371 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v372 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v373 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v366 v372 
                let _run_target_args'_v371 = v373 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v374 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v375 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v366 v374 
                let _run_target_args'_v371 = v375 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v376 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v377 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v366 v376 
                let _run_target_args'_v371 = v377 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v379 : std_io_Error = v366 |> unbox<std_io_Error>
                let _run_target_args'_v371 = v379 
                #endif
#if FABLE_COMPILER_PYTHON
                let v383 : std_io_Error = v366 |> unbox<std_io_Error>
                let _run_target_args'_v371 = v383 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v387 : std_io_Error = v366 |> unbox<std_io_Error>
                let _run_target_args'_v371 = v387 
                #endif
#else
                let v391 : std_io_Error = v366 |> unbox<std_io_Error>
                let _run_target_args'_v371 = v391 
                #endif
                let v394 : std_io_Error = _run_target_args'_v371 
                (* run_target_args'
                let v404 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v405 : string = "Err($0)"
                let v406 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v394 v405 
                let _run_target_args'_v404 = v406 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v407 : string = "Err($0)"
                let v408 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v394 v407 
                let _run_target_args'_v404 = v408 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v409 : string = "Err($0)"
                let v410 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v394 v409 
                let _run_target_args'_v404 = v410 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v411 : Result<std_path_PathBuf, std_io_Error> = v394 |> Error
                let _run_target_args'_v404 = v411 
                #endif
#if FABLE_COMPILER_PYTHON
                let v412 : Result<std_path_PathBuf, std_io_Error> = v394 |> Error
                let _run_target_args'_v404 = v412 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v413 : Result<std_path_PathBuf, std_io_Error> = v394 |> Error
                let _run_target_args'_v404 = v413 
                #endif
#else
                let v414 : Result<std_path_PathBuf, std_io_Error> = v394 |> Error
                let _run_target_args'_v404 = v414 
                #endif
                let v415 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v404 
                v415
        | _ ->
            let v419 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v420 : string = $"path: {v0} / error: {v54} / path': {v4} / name: {v5}"
            let v421 : string = v419 + v420 
            (* run_target_args'
            let v426 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v427 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v428 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v421 v427 
            let _run_target_args'_v426 = v428 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v429 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v430 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v421 v429 
            let _run_target_args'_v426 = v430 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v431 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v432 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v421 v431 
            let _run_target_args'_v426 = v432 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v434 : std_io_Error = v421 |> unbox<std_io_Error>
            let _run_target_args'_v426 = v434 
            #endif
#if FABLE_COMPILER_PYTHON
            let v438 : std_io_Error = v421 |> unbox<std_io_Error>
            let _run_target_args'_v426 = v438 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v442 : std_io_Error = v421 |> unbox<std_io_Error>
            let _run_target_args'_v426 = v442 
            #endif
#else
            let v446 : std_io_Error = v421 |> unbox<std_io_Error>
            let _run_target_args'_v426 = v446 
            #endif
            let v449 : std_io_Error = _run_target_args'_v426 
            (* run_target_args'
            let v459 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v460 : string = "Err($0)"
            let v461 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v449 v460 
            let _run_target_args'_v459 = v461 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v462 : string = "Err($0)"
            let v463 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v449 v462 
            let _run_target_args'_v459 = v463 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v464 : string = "Err($0)"
            let v465 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v449 v464 
            let _run_target_args'_v459 = v465 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v466 : Result<std_path_PathBuf, std_io_Error> = v449 |> Error
            let _run_target_args'_v459 = v466 
            #endif
#if FABLE_COMPILER_PYTHON
            let v467 : Result<std_path_PathBuf, std_io_Error> = v449 |> Error
            let _run_target_args'_v459 = v467 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v468 : Result<std_path_PathBuf, std_io_Error> = v449 |> Error
            let _run_target_args'_v459 = v468 
            #endif
#else
            let v469 : Result<std_path_PathBuf, std_io_Error> = v449 |> Error
            let _run_target_args'_v459 = v469 
            #endif
            let v470 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v459 
            v470
and method41 (v0 : string, v1 : uint8, v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    (* run_target_args'
    let v7 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "std::fs::read_link(&*$0)"
    let v9 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v8 
    let v10 : (std_io_Error -> string) = method38()
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
    let v26 : (std_path_PathBuf -> US9) = method39()
    let v27 : (string -> US9) = method40()
    let v29 : US9 = match v23 with Ok x -> v26 x | Error x -> v27 x
    let v52 : Result<std_path_PathBuf, std_io_Error> =
        match v29 with
        | US9_1(v48) -> (* Error *)
            let v49 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method42(v0, v49, v1, v48, v2)
        | US9_0(v32) -> (* Ok *)
            (* run_target_args'
            let v34 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v35 : string = "Ok($0)"
            let v36 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v32 v35 
            let _run_target_args'_v34 = v36 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v37 : string = "Ok($0)"
            let v38 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v32 v37 
            let _run_target_args'_v34 = v38 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v39 : string = "Ok($0)"
            let v40 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v32 v39 
            let _run_target_args'_v34 = v40 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v41 : Result<std_path_PathBuf, std_io_Error> = v32 |> Ok
            let _run_target_args'_v34 = v41 
            #endif
#if FABLE_COMPILER_PYTHON
            let v42 : Result<std_path_PathBuf, std_io_Error> = v32 |> Ok
            let _run_target_args'_v34 = v42 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v43 : Result<std_path_PathBuf, std_io_Error> = v32 |> Ok
            let _run_target_args'_v34 = v43 
            #endif
#else
            let v44 : Result<std_path_PathBuf, std_io_Error> = v32 |> Ok
            let _run_target_args'_v34 = v44 
            #endif
            let v45 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v34 
            v45
    let _run_target_args'_v7 = v52 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v53 : string = "std::fs::read_link(&*$0)"
    let v54 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v53 
    let v55 : (std_io_Error -> string) = method38()
    (* run_target_args'
    let v57 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v58 : string = "$0.map_err(|x| $1(x))"
    let v59 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v54, v55) v58 
    let _run_target_args'_v57 = v59 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v60 : string = "$0.map_err(|x| $1(x))"
    let v61 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v54, v55) v60 
    let _run_target_args'_v57 = v61 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v62 : string = "$0.map_err(|x| $1(x))"
    let v63 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v54, v55) v62 
    let _run_target_args'_v57 = v63 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v64 : Result<std_path_PathBuf, string> = match v54 with Ok x -> Ok x | Error x -> Error (v55 x)
    let _run_target_args'_v57 = v64 
    #endif
#if FABLE_COMPILER_PYTHON
    let v65 : Result<std_path_PathBuf, string> = match v54 with Ok x -> Ok x | Error x -> Error (v55 x)
    let _run_target_args'_v57 = v65 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v66 : Result<std_path_PathBuf, string> = match v54 with Ok x -> Ok x | Error x -> Error (v55 x)
    let _run_target_args'_v57 = v66 
    #endif
#else
    let v67 : Result<std_path_PathBuf, string> = match v54 with Ok x -> Ok x | Error x -> Error (v55 x)
    let _run_target_args'_v57 = v67 
    #endif
    let v68 : Result<std_path_PathBuf, string> = _run_target_args'_v57 
    let v71 : (std_path_PathBuf -> US9) = method39()
    let v72 : (string -> US9) = method40()
    let v74 : US9 = match v68 with Ok x -> v71 x | Error x -> v72 x
    let v97 : Result<std_path_PathBuf, std_io_Error> =
        match v74 with
        | US9_1(v93) -> (* Error *)
            let v94 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method42(v0, v94, v1, v93, v2)
        | US9_0(v77) -> (* Ok *)
            (* run_target_args'
            let v79 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v80 : string = "Ok($0)"
            let v81 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v77 v80 
            let _run_target_args'_v79 = v81 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v82 : string = "Ok($0)"
            let v83 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v77 v82 
            let _run_target_args'_v79 = v83 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v84 : string = "Ok($0)"
            let v85 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v77 v84 
            let _run_target_args'_v79 = v85 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v86 : Result<std_path_PathBuf, std_io_Error> = v77 |> Ok
            let _run_target_args'_v79 = v86 
            #endif
#if FABLE_COMPILER_PYTHON
            let v87 : Result<std_path_PathBuf, std_io_Error> = v77 |> Ok
            let _run_target_args'_v79 = v87 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v88 : Result<std_path_PathBuf, std_io_Error> = v77 |> Ok
            let _run_target_args'_v79 = v88 
            #endif
#else
            let v89 : Result<std_path_PathBuf, std_io_Error> = v77 |> Ok
            let _run_target_args'_v79 = v89 
            #endif
            let v90 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v79 
            v90
    let _run_target_args'_v7 = v97 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v98 : string = "std::fs::read_link(&*$0)"
    let v99 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v98 
    let v100 : (std_io_Error -> string) = method38()
    (* run_target_args'
    let v102 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v103 : string = "$0.map_err(|x| $1(x))"
    let v104 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v99, v100) v103 
    let _run_target_args'_v102 = v104 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v105 : string = "$0.map_err(|x| $1(x))"
    let v106 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v99, v100) v105 
    let _run_target_args'_v102 = v106 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v107 : string = "$0.map_err(|x| $1(x))"
    let v108 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v99, v100) v107 
    let _run_target_args'_v102 = v108 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v109 : Result<std_path_PathBuf, string> = match v99 with Ok x -> Ok x | Error x -> Error (v100 x)
    let _run_target_args'_v102 = v109 
    #endif
#if FABLE_COMPILER_PYTHON
    let v110 : Result<std_path_PathBuf, string> = match v99 with Ok x -> Ok x | Error x -> Error (v100 x)
    let _run_target_args'_v102 = v110 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v111 : Result<std_path_PathBuf, string> = match v99 with Ok x -> Ok x | Error x -> Error (v100 x)
    let _run_target_args'_v102 = v111 
    #endif
#else
    let v112 : Result<std_path_PathBuf, string> = match v99 with Ok x -> Ok x | Error x -> Error (v100 x)
    let _run_target_args'_v102 = v112 
    #endif
    let v113 : Result<std_path_PathBuf, string> = _run_target_args'_v102 
    let v116 : (std_path_PathBuf -> US9) = method39()
    let v117 : (string -> US9) = method40()
    let v119 : US9 = match v113 with Ok x -> v116 x | Error x -> v117 x
    let v142 : Result<std_path_PathBuf, std_io_Error> =
        match v119 with
        | US9_1(v138) -> (* Error *)
            let v139 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method42(v0, v139, v1, v138, v2)
        | US9_0(v122) -> (* Ok *)
            (* run_target_args'
            let v124 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v125 : string = "Ok($0)"
            let v126 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v122 v125 
            let _run_target_args'_v124 = v126 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v127 : string = "Ok($0)"
            let v128 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v122 v127 
            let _run_target_args'_v124 = v128 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v129 : string = "Ok($0)"
            let v130 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v122 v129 
            let _run_target_args'_v124 = v130 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v131 : Result<std_path_PathBuf, std_io_Error> = v122 |> Ok
            let _run_target_args'_v124 = v131 
            #endif
#if FABLE_COMPILER_PYTHON
            let v132 : Result<std_path_PathBuf, std_io_Error> = v122 |> Ok
            let _run_target_args'_v124 = v132 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v133 : Result<std_path_PathBuf, std_io_Error> = v122 |> Ok
            let _run_target_args'_v124 = v133 
            #endif
#else
            let v134 : Result<std_path_PathBuf, std_io_Error> = v122 |> Ok
            let _run_target_args'_v124 = v134 
            #endif
            let v135 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v124 
            v135
    let _run_target_args'_v7 = v142 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v144 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v7 = v144 
    #endif
#if FABLE_COMPILER_PYTHON
    let v148 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v7 = v148 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v152 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v7 = v152 
    #endif
#else
    let v156 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v7 = v156 
    #endif
    let v159 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v7 
    v159
and closure20 (v0 : string, v1 : uint8) (v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    method41(v0, v1, v2)
and closure19 (v0 : string) (v1 : uint8) : (string -> Result<std_path_PathBuf, std_io_Error>) =
    closure20(v0, v1)
and method44 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v4 : string = method43(v0)
    let v5 : string option = method31(v0)
    let v8 : (string -> US5) = method6()
    let v9 : US5 option = v5 |> Option.map v8 
    let v29 : US5 = US5_1
    let v30 : US5 = v9 |> Option.defaultValue v29 
    let v34 : string = method13()
    let v35 : Mut3 = {l0 = v34} : Mut3
    let v37 : string = $"{v3}"
    let v45 : unit = ()
    let v46 : (unit -> unit) = closure8(v35, v37)
    let v47 : unit = (fun () -> v46 (); v45) ()
    let v53 : string = v35.l0
    let v54 : bool = v2 >= 11uy
    if v54 then
        let v55 : string = $"file_system.read_link / "
        let v56 : string = $"path: {v0} / n: {v2} / path': {v0} / name: {v4}"
        let v57 : string = v55 + v56 
        (* run_target_args'
        let v62 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v63 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v64 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v57 v63 
        let _run_target_args'_v62 = v64 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v65 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v66 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v57 v65 
        let _run_target_args'_v62 = v66 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v67 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v68 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v57 v67 
        let _run_target_args'_v62 = v68 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v70 : std_io_Error = v57 |> unbox<std_io_Error>
        let _run_target_args'_v62 = v70 
        #endif
#if FABLE_COMPILER_PYTHON
        let v74 : std_io_Error = v57 |> unbox<std_io_Error>
        let _run_target_args'_v62 = v74 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v78 : std_io_Error = v57 |> unbox<std_io_Error>
        let _run_target_args'_v62 = v78 
        #endif
#else
        let v82 : std_io_Error = v57 |> unbox<std_io_Error>
        let _run_target_args'_v62 = v82 
        #endif
        let v85 : std_io_Error = _run_target_args'_v62 
        (* run_target_args'
        let v95 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v96 : string = "Err($0)"
        let v97 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v85 v96 
        let _run_target_args'_v95 = v97 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v98 : string = "Err($0)"
        let v99 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v85 v98 
        let _run_target_args'_v95 = v99 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v100 : string = "Err($0)"
        let v101 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v85 v100 
        let _run_target_args'_v95 = v101 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v102 : Result<std_path_PathBuf, std_io_Error> = v85 |> Error
        let _run_target_args'_v95 = v102 
        #endif
#if FABLE_COMPILER_PYTHON
        let v103 : Result<std_path_PathBuf, std_io_Error> = v85 |> Error
        let _run_target_args'_v95 = v103 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v104 : Result<std_path_PathBuf, std_io_Error> = v85 |> Error
        let _run_target_args'_v95 = v104 
        #endif
#else
        let v105 : Result<std_path_PathBuf, std_io_Error> = v85 |> Error
        let _run_target_args'_v95 = v105 
        #endif
        let v106 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v95 
        v106
    else
        match v30 with
        | US5_0(v109) -> (* Some *)
            let v112 : string = ""
            let v113 : bool = v0 <> v112 
            if v113 then
                let v116 : uint8 = v2 + 1uy
                let v117 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v116
                let v118 : Result<std_path_PathBuf, std_io_Error> = v117 v109
                let v119 : (std_io_Error -> string) = method38()
                (* run_target_args'
                let v121 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v122 : string = "$0.map_err(|x| $1(x))"
                let v123 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v118, v119) v122 
                let _run_target_args'_v121 = v123 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v124 : string = "$0.map_err(|x| $1(x))"
                let v125 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v118, v119) v124 
                let _run_target_args'_v121 = v125 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v126 : string = "$0.map_err(|x| $1(x))"
                let v127 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v118, v119) v126 
                let _run_target_args'_v121 = v127 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v128 : Result<std_path_PathBuf, string> = match v118 with Ok x -> Ok x | Error x -> Error (v119 x)
                let _run_target_args'_v121 = v128 
                #endif
#if FABLE_COMPILER_PYTHON
                let v129 : Result<std_path_PathBuf, string> = match v118 with Ok x -> Ok x | Error x -> Error (v119 x)
                let _run_target_args'_v121 = v129 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v130 : Result<std_path_PathBuf, string> = match v118 with Ok x -> Ok x | Error x -> Error (v119 x)
                let _run_target_args'_v121 = v130 
                #endif
#else
                let v131 : Result<std_path_PathBuf, string> = match v118 with Ok x -> Ok x | Error x -> Error (v119 x)
                let _run_target_args'_v121 = v131 
                #endif
                let v132 : Result<std_path_PathBuf, string> = _run_target_args'_v121 
                let v135 : (std_path_PathBuf -> US9) = method39()
                let v136 : (string -> US9) = method40()
                let v138 : US9 = match v132 with Ok x -> v135 x | Error x -> v136 x
                match v138 with
                | US9_1(v306) -> (* Error *)
                    let v307 : string = $"file_system.read_link / "
                    let v308 : string = $"error': {v306} / error: {v53} / name: {v4}"
                    let v309 : string = v307 + v308 
                    (* run_target_args'
                    let v314 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v315 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v316 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v309 v315 
                    let _run_target_args'_v314 = v316 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v317 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v318 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v309 v317 
                    let _run_target_args'_v314 = v318 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v319 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v320 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v309 v319 
                    let _run_target_args'_v314 = v320 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v322 : std_io_Error = v309 |> unbox<std_io_Error>
                    let _run_target_args'_v314 = v322 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v326 : std_io_Error = v309 |> unbox<std_io_Error>
                    let _run_target_args'_v314 = v326 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v330 : std_io_Error = v309 |> unbox<std_io_Error>
                    let _run_target_args'_v314 = v330 
                    #endif
#else
                    let v334 : std_io_Error = v309 |> unbox<std_io_Error>
                    let _run_target_args'_v314 = v334 
                    #endif
                    let v337 : std_io_Error = _run_target_args'_v314 
                    (* run_target_args'
                    let v347 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v348 : string = "Err($0)"
                    let v349 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v337 v348 
                    let _run_target_args'_v347 = v349 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v350 : string = "Err($0)"
                    let v351 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v337 v350 
                    let _run_target_args'_v347 = v351 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v352 : string = "Err($0)"
                    let v353 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v337 v352 
                    let _run_target_args'_v347 = v353 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v354 : Result<std_path_PathBuf, std_io_Error> = v337 |> Error
                    let _run_target_args'_v347 = v354 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v355 : Result<std_path_PathBuf, std_io_Error> = v337 |> Error
                    let _run_target_args'_v347 = v355 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v356 : Result<std_path_PathBuf, std_io_Error> = v337 |> Error
                    let _run_target_args'_v347 = v356 
                    #endif
#else
                    let v357 : Result<std_path_PathBuf, std_io_Error> = v337 |> Error
                    let _run_target_args'_v347 = v357 
                    #endif
                    let v358 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v347 
                    v358
                | US9_0(v141) -> (* Ok *)
                    (* run_target_args'
                    let v146 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v147 : string = "$0.display()"
                    let v148 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v141 v147 
                    let _run_target_args'_v146 = v148 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v149 : string = "$0.display()"
                    let v150 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v141 v149 
                    let _run_target_args'_v146 = v150 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v151 : string = "$0.display()"
                    let v152 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v141 v151 
                    let _run_target_args'_v146 = v152 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v154 : std_path_Display = v141 |> unbox<std_path_Display>
                    let _run_target_args'_v146 = v154 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v158 : std_path_Display = v141 |> unbox<std_path_Display>
                    let _run_target_args'_v146 = v158 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v162 : std_path_Display = v141 |> unbox<std_path_Display>
                    let _run_target_args'_v146 = v162 
                    #endif
#else
                    let v166 : std_path_Display = v141 |> unbox<std_path_Display>
                    let _run_target_args'_v146 = v166 
                    #endif
                    let v169 : std_path_Display = _run_target_args'_v146 
                    let v179 : string = v169 |> string 
                    let v182 : string = method26(v179, v4)
                    (* run_target_args'
                    let v187 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v188 : string = "&*$0"
                    let v189 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v182 v188 
                    let _run_target_args'_v187 = v189 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v190 : string = "&*$0"
                    let v191 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v182 v190 
                    let _run_target_args'_v187 = v191 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v192 : string = "&*$0"
                    let v193 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v182 v192 
                    let _run_target_args'_v187 = v193 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v195 : Ref<Str> = v182 |> unbox<Ref<Str>>
                    let _run_target_args'_v187 = v195 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v199 : Ref<Str> = v182 |> unbox<Ref<Str>>
                    let _run_target_args'_v187 = v199 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v203 : Ref<Str> = v182 |> unbox<Ref<Str>>
                    let _run_target_args'_v187 = v203 
                    #endif
#else
                    let v207 : Ref<Str> = v182 |> unbox<Ref<Str>>
                    let _run_target_args'_v187 = v207 
                    #endif
                    let v210 : Ref<Str> = _run_target_args'_v187 
                    (* run_target_args'
                    let v223 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v224 : string = "String::from($0)"
                    let v225 : std_string_String = Fable.Core.RustInterop.emitRustExpr v210 v224 
                    let _run_target_args'_v223 = v225 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v226 : string = "String::from($0)"
                    let v227 : std_string_String = Fable.Core.RustInterop.emitRustExpr v210 v226 
                    let _run_target_args'_v223 = v227 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v228 : string = "String::from($0)"
                    let v229 : std_string_String = Fable.Core.RustInterop.emitRustExpr v210 v228 
                    let _run_target_args'_v223 = v229 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v231 : std_string_String = v210 |> unbox<std_string_String>
                    let _run_target_args'_v223 = v231 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v235 : std_string_String = v210 |> unbox<std_string_String>
                    let _run_target_args'_v223 = v235 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v239 : std_string_String = v210 |> unbox<std_string_String>
                    let _run_target_args'_v223 = v239 
                    #endif
#else
                    let v243 : std_string_String = v210 |> unbox<std_string_String>
                    let _run_target_args'_v223 = v243 
                    #endif
                    let v246 : std_string_String = _run_target_args'_v223 
                    (* run_target_args'
                    let v259 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v260 : string = "std::path::PathBuf::from($0)"
                    let v261 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v246 v260 
                    let _run_target_args'_v259 = v261 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v262 : string = "std::path::PathBuf::from($0)"
                    let v263 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v246 v262 
                    let _run_target_args'_v259 = v263 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v264 : string = "std::path::PathBuf::from($0)"
                    let v265 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v246 v264 
                    let _run_target_args'_v259 = v265 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v267 : std_path_PathBuf = v246 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v259 = v267 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v271 : std_path_PathBuf = v246 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v259 = v271 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v275 : std_path_PathBuf = v246 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v259 = v275 
                    #endif
#else
                    let v279 : std_path_PathBuf = v246 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v259 = v279 
                    #endif
                    let v282 : std_path_PathBuf = _run_target_args'_v259 
                    (* run_target_args'
                    let v292 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v293 : string = "Ok($0)"
                    let v294 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v282 v293 
                    let _run_target_args'_v292 = v294 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v295 : string = "Ok($0)"
                    let v296 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v282 v295 
                    let _run_target_args'_v292 = v296 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v297 : string = "Ok($0)"
                    let v298 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v282 v297 
                    let _run_target_args'_v292 = v298 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v299 : Result<std_path_PathBuf, std_io_Error> = v282 |> Ok
                    let _run_target_args'_v292 = v299 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v300 : Result<std_path_PathBuf, std_io_Error> = v282 |> Ok
                    let _run_target_args'_v292 = v300 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v301 : Result<std_path_PathBuf, std_io_Error> = v282 |> Ok
                    let _run_target_args'_v292 = v301 
                    #endif
#else
                    let v302 : Result<std_path_PathBuf, std_io_Error> = v282 |> Ok
                    let _run_target_args'_v292 = v302 
                    #endif
                    let v303 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v292 
                    v303
            else
                let v363 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v364 : string = $"path: {v0} / error: {v53} / path': {v0} / name: {v4}"
                let v365 : string = v363 + v364 
                (* run_target_args'
                let v370 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v371 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v372 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v365 v371 
                let _run_target_args'_v370 = v372 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v373 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v374 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v365 v373 
                let _run_target_args'_v370 = v374 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v375 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v376 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v365 v375 
                let _run_target_args'_v370 = v376 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v378 : std_io_Error = v365 |> unbox<std_io_Error>
                let _run_target_args'_v370 = v378 
                #endif
#if FABLE_COMPILER_PYTHON
                let v382 : std_io_Error = v365 |> unbox<std_io_Error>
                let _run_target_args'_v370 = v382 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v386 : std_io_Error = v365 |> unbox<std_io_Error>
                let _run_target_args'_v370 = v386 
                #endif
#else
                let v390 : std_io_Error = v365 |> unbox<std_io_Error>
                let _run_target_args'_v370 = v390 
                #endif
                let v393 : std_io_Error = _run_target_args'_v370 
                (* run_target_args'
                let v403 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v404 : string = "Err($0)"
                let v405 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v393 v404 
                let _run_target_args'_v403 = v405 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v406 : string = "Err($0)"
                let v407 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v393 v406 
                let _run_target_args'_v403 = v407 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v408 : string = "Err($0)"
                let v409 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v393 v408 
                let _run_target_args'_v403 = v409 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v410 : Result<std_path_PathBuf, std_io_Error> = v393 |> Error
                let _run_target_args'_v403 = v410 
                #endif
#if FABLE_COMPILER_PYTHON
                let v411 : Result<std_path_PathBuf, std_io_Error> = v393 |> Error
                let _run_target_args'_v403 = v411 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v412 : Result<std_path_PathBuf, std_io_Error> = v393 |> Error
                let _run_target_args'_v403 = v412 
                #endif
#else
                let v413 : Result<std_path_PathBuf, std_io_Error> = v393 |> Error
                let _run_target_args'_v403 = v413 
                #endif
                let v414 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v403 
                v414
        | _ ->
            let v418 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v419 : string = $"path: {v0} / error: {v53} / path': {v0} / name: {v4}"
            let v420 : string = v418 + v419 
            (* run_target_args'
            let v425 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v426 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v427 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v420 v426 
            let _run_target_args'_v425 = v427 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v428 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v429 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v420 v428 
            let _run_target_args'_v425 = v429 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v430 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v431 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v420 v430 
            let _run_target_args'_v425 = v431 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v433 : std_io_Error = v420 |> unbox<std_io_Error>
            let _run_target_args'_v425 = v433 
            #endif
#if FABLE_COMPILER_PYTHON
            let v437 : std_io_Error = v420 |> unbox<std_io_Error>
            let _run_target_args'_v425 = v437 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v441 : std_io_Error = v420 |> unbox<std_io_Error>
            let _run_target_args'_v425 = v441 
            #endif
#else
            let v445 : std_io_Error = v420 |> unbox<std_io_Error>
            let _run_target_args'_v425 = v445 
            #endif
            let v448 : std_io_Error = _run_target_args'_v425 
            (* run_target_args'
            let v458 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v459 : string = "Err($0)"
            let v460 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v448 v459 
            let _run_target_args'_v458 = v460 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v461 : string = "Err($0)"
            let v462 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v448 v461 
            let _run_target_args'_v458 = v462 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v463 : string = "Err($0)"
            let v464 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v448 v463 
            let _run_target_args'_v458 = v464 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v465 : Result<std_path_PathBuf, std_io_Error> = v448 |> Error
            let _run_target_args'_v458 = v465 
            #endif
#if FABLE_COMPILER_PYTHON
            let v466 : Result<std_path_PathBuf, std_io_Error> = v448 |> Error
            let _run_target_args'_v458 = v466 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v467 : Result<std_path_PathBuf, std_io_Error> = v448 |> Error
            let _run_target_args'_v458 = v467 
            #endif
#else
            let v468 : Result<std_path_PathBuf, std_io_Error> = v448 |> Error
            let _run_target_args'_v458 = v468 
            #endif
            let v469 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v458 
            v469
and method37 (v0 : string, v1 : uint8) : Result<std_path_PathBuf, std_io_Error> =
    (* run_target_args'
    let v6 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = "std::fs::read_link(&*$0)"
    let v8 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v7 
    let v9 : (std_io_Error -> string) = method38()
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
    let v25 : (std_path_PathBuf -> US9) = method39()
    let v26 : (string -> US9) = method40()
    let v28 : US9 = match v22 with Ok x -> v25 x | Error x -> v26 x
    let v51 : Result<std_path_PathBuf, std_io_Error> =
        match v28 with
        | US9_1(v47) -> (* Error *)
            let v48 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method44(v0, v48, v1, v47)
        | US9_0(v31) -> (* Ok *)
            (* run_target_args'
            let v33 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v34 : string = "Ok($0)"
            let v35 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v31 v34 
            let _run_target_args'_v33 = v35 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v36 : string = "Ok($0)"
            let v37 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v31 v36 
            let _run_target_args'_v33 = v37 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v38 : string = "Ok($0)"
            let v39 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v31 v38 
            let _run_target_args'_v33 = v39 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v40 : Result<std_path_PathBuf, std_io_Error> = v31 |> Ok
            let _run_target_args'_v33 = v40 
            #endif
#if FABLE_COMPILER_PYTHON
            let v41 : Result<std_path_PathBuf, std_io_Error> = v31 |> Ok
            let _run_target_args'_v33 = v41 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v42 : Result<std_path_PathBuf, std_io_Error> = v31 |> Ok
            let _run_target_args'_v33 = v42 
            #endif
#else
            let v43 : Result<std_path_PathBuf, std_io_Error> = v31 |> Ok
            let _run_target_args'_v33 = v43 
            #endif
            let v44 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v33 
            v44
    let _run_target_args'_v6 = v51 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v52 : string = "std::fs::read_link(&*$0)"
    let v53 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v52 
    let v54 : (std_io_Error -> string) = method38()
    (* run_target_args'
    let v56 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v57 : string = "$0.map_err(|x| $1(x))"
    let v58 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v53, v54) v57 
    let _run_target_args'_v56 = v58 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v59 : string = "$0.map_err(|x| $1(x))"
    let v60 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v53, v54) v59 
    let _run_target_args'_v56 = v60 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v61 : string = "$0.map_err(|x| $1(x))"
    let v62 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v53, v54) v61 
    let _run_target_args'_v56 = v62 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v63 : Result<std_path_PathBuf, string> = match v53 with Ok x -> Ok x | Error x -> Error (v54 x)
    let _run_target_args'_v56 = v63 
    #endif
#if FABLE_COMPILER_PYTHON
    let v64 : Result<std_path_PathBuf, string> = match v53 with Ok x -> Ok x | Error x -> Error (v54 x)
    let _run_target_args'_v56 = v64 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v65 : Result<std_path_PathBuf, string> = match v53 with Ok x -> Ok x | Error x -> Error (v54 x)
    let _run_target_args'_v56 = v65 
    #endif
#else
    let v66 : Result<std_path_PathBuf, string> = match v53 with Ok x -> Ok x | Error x -> Error (v54 x)
    let _run_target_args'_v56 = v66 
    #endif
    let v67 : Result<std_path_PathBuf, string> = _run_target_args'_v56 
    let v70 : (std_path_PathBuf -> US9) = method39()
    let v71 : (string -> US9) = method40()
    let v73 : US9 = match v67 with Ok x -> v70 x | Error x -> v71 x
    let v96 : Result<std_path_PathBuf, std_io_Error> =
        match v73 with
        | US9_1(v92) -> (* Error *)
            let v93 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method44(v0, v93, v1, v92)
        | US9_0(v76) -> (* Ok *)
            (* run_target_args'
            let v78 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v79 : string = "Ok($0)"
            let v80 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v76 v79 
            let _run_target_args'_v78 = v80 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v81 : string = "Ok($0)"
            let v82 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v76 v81 
            let _run_target_args'_v78 = v82 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v83 : string = "Ok($0)"
            let v84 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v76 v83 
            let _run_target_args'_v78 = v84 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v85 : Result<std_path_PathBuf, std_io_Error> = v76 |> Ok
            let _run_target_args'_v78 = v85 
            #endif
#if FABLE_COMPILER_PYTHON
            let v86 : Result<std_path_PathBuf, std_io_Error> = v76 |> Ok
            let _run_target_args'_v78 = v86 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v87 : Result<std_path_PathBuf, std_io_Error> = v76 |> Ok
            let _run_target_args'_v78 = v87 
            #endif
#else
            let v88 : Result<std_path_PathBuf, std_io_Error> = v76 |> Ok
            let _run_target_args'_v78 = v88 
            #endif
            let v89 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v78 
            v89
    let _run_target_args'_v6 = v96 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v97 : string = "std::fs::read_link(&*$0)"
    let v98 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v97 
    let v99 : (std_io_Error -> string) = method38()
    (* run_target_args'
    let v101 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v102 : string = "$0.map_err(|x| $1(x))"
    let v103 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v98, v99) v102 
    let _run_target_args'_v101 = v103 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : string = "$0.map_err(|x| $1(x))"
    let v105 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v98, v99) v104 
    let _run_target_args'_v101 = v105 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v106 : string = "$0.map_err(|x| $1(x))"
    let v107 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v98, v99) v106 
    let _run_target_args'_v101 = v107 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v108 : Result<std_path_PathBuf, string> = match v98 with Ok x -> Ok x | Error x -> Error (v99 x)
    let _run_target_args'_v101 = v108 
    #endif
#if FABLE_COMPILER_PYTHON
    let v109 : Result<std_path_PathBuf, string> = match v98 with Ok x -> Ok x | Error x -> Error (v99 x)
    let _run_target_args'_v101 = v109 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v110 : Result<std_path_PathBuf, string> = match v98 with Ok x -> Ok x | Error x -> Error (v99 x)
    let _run_target_args'_v101 = v110 
    #endif
#else
    let v111 : Result<std_path_PathBuf, string> = match v98 with Ok x -> Ok x | Error x -> Error (v99 x)
    let _run_target_args'_v101 = v111 
    #endif
    let v112 : Result<std_path_PathBuf, string> = _run_target_args'_v101 
    let v115 : (std_path_PathBuf -> US9) = method39()
    let v116 : (string -> US9) = method40()
    let v118 : US9 = match v112 with Ok x -> v115 x | Error x -> v116 x
    let v141 : Result<std_path_PathBuf, std_io_Error> =
        match v118 with
        | US9_1(v137) -> (* Error *)
            let v138 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method44(v0, v138, v1, v137)
        | US9_0(v121) -> (* Ok *)
            (* run_target_args'
            let v123 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v124 : string = "Ok($0)"
            let v125 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v121 v124 
            let _run_target_args'_v123 = v125 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v126 : string = "Ok($0)"
            let v127 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v121 v126 
            let _run_target_args'_v123 = v127 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v128 : string = "Ok($0)"
            let v129 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v121 v128 
            let _run_target_args'_v123 = v129 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v130 : Result<std_path_PathBuf, std_io_Error> = v121 |> Ok
            let _run_target_args'_v123 = v130 
            #endif
#if FABLE_COMPILER_PYTHON
            let v131 : Result<std_path_PathBuf, std_io_Error> = v121 |> Ok
            let _run_target_args'_v123 = v131 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v132 : Result<std_path_PathBuf, std_io_Error> = v121 |> Ok
            let _run_target_args'_v123 = v132 
            #endif
#else
            let v133 : Result<std_path_PathBuf, std_io_Error> = v121 |> Ok
            let _run_target_args'_v123 = v133 
            #endif
            let v134 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v123 
            v134
    let _run_target_args'_v6 = v141 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v143 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v6 = v143 
    #endif
#if FABLE_COMPILER_PYTHON
    let v147 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v6 = v147 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v151 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v6 = v151 
    #endif
#else
    let v155 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v6 = v155 
    #endif
    let v158 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v6 
    v158
and method46 (v0 : System_IO_DirectoryInfo) : System.IO.FileAttributes =
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
and method47 () : System.IO.FileAttributes =
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
and method48 (v0 : System.IO.FileAttributes, v1 : System.IO.FileAttributes) : bool =
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
and method50 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : std_io_Error, v4 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v5 : string = method43(v4)
    let v6 : string option = method31(v4)
    let v9 : (string -> US5) = method6()
    let v10 : US5 option = v6 |> Option.map v9 
    let v30 : US5 = US5_1
    let v31 : US5 = v10 |> Option.defaultValue v30 
    let v35 : string = method13()
    let v36 : Mut3 = {l0 = v35} : Mut3
    (* run_target_args'
    let v41 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v42 : string = "format!(\"{:#?}\", $0)"
    let v43 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v42 
    let v44 : string = "fable_library_rust::String_::fromString($0)"
    let v45 : string = Fable.Core.RustInterop.emitRustExpr v43 v44 
    let _run_target_args'_v41 = v45 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v46 : string = "format!(\"{:#?}\", $0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v46 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let _run_target_args'_v41 = v49 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v50 : string = "format!(\"{:#?}\", $0)"
    let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v50 
    let v52 : string = "fable_library_rust::String_::fromString($0)"
    let v53 : string = Fable.Core.RustInterop.emitRustExpr v51 v52 
    let _run_target_args'_v41 = v53 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v55 : string = $"%A{v3}"
    let _run_target_args'_v41 = v55 
    #endif
#if FABLE_COMPILER_PYTHON
    let v59 : string = $"%A{v3}"
    let _run_target_args'_v41 = v59 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v63 : string = $"%A{v3}"
    let _run_target_args'_v41 = v63 
    #endif
#else
    let v67 : string = $"%A{v3}"
    let _run_target_args'_v41 = v67 
    #endif
    let v70 : string = _run_target_args'_v41 
    let v80 : string = $"{v70}"
    let v88 : unit = ()
    let v89 : (unit -> unit) = closure8(v36, v80)
    let v90 : unit = (fun () -> v89 (); v88) ()
    let v96 : string = v36.l0
    let v97 : bool = v2 >= 11uy
    if v97 then
        let v98 : string = $"file_system.read_link / "
        let v99 : string = $"path: {v0} / n: {v2} / path': {v4} / name: {v5}"
        let v100 : string = v98 + v99 
        (* run_target_args'
        let v105 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v106 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v107 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v100 v106 
        let _run_target_args'_v105 = v107 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v108 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v109 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v100 v108 
        let _run_target_args'_v105 = v109 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v110 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v111 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v100 v110 
        let _run_target_args'_v105 = v111 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v113 : std_io_Error = v100 |> unbox<std_io_Error>
        let _run_target_args'_v105 = v113 
        #endif
#if FABLE_COMPILER_PYTHON
        let v117 : std_io_Error = v100 |> unbox<std_io_Error>
        let _run_target_args'_v105 = v117 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v121 : std_io_Error = v100 |> unbox<std_io_Error>
        let _run_target_args'_v105 = v121 
        #endif
#else
        let v125 : std_io_Error = v100 |> unbox<std_io_Error>
        let _run_target_args'_v105 = v125 
        #endif
        let v128 : std_io_Error = _run_target_args'_v105 
        (* run_target_args'
        let v138 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v139 : string = "Err($0)"
        let v140 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v128 v139 
        let _run_target_args'_v138 = v140 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v141 : string = "Err($0)"
        let v142 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v128 v141 
        let _run_target_args'_v138 = v142 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v143 : string = "Err($0)"
        let v144 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v128 v143 
        let _run_target_args'_v138 = v144 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v145 : Result<std_path_PathBuf, std_io_Error> = v128 |> Error
        let _run_target_args'_v138 = v145 
        #endif
#if FABLE_COMPILER_PYTHON
        let v146 : Result<std_path_PathBuf, std_io_Error> = v128 |> Error
        let _run_target_args'_v138 = v146 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v147 : Result<std_path_PathBuf, std_io_Error> = v128 |> Error
        let _run_target_args'_v138 = v147 
        #endif
#else
        let v148 : Result<std_path_PathBuf, std_io_Error> = v128 |> Error
        let _run_target_args'_v138 = v148 
        #endif
        let v149 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v138 
        v149
    else
        match v31 with
        | US5_0(v152) -> (* Some *)
            let v155 : string = ""
            let v156 : bool = v4 <> v155 
            if v156 then
                let v159 : uint8 = v2 + 1uy
                let v160 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v159
                let v161 : Result<std_path_PathBuf, std_io_Error> = v160 v152
                let v162 : (std_io_Error -> string) = method38()
                (* run_target_args'
                let v164 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v165 : string = "$0.map_err(|x| $1(x))"
                let v166 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v161, v162) v165 
                let _run_target_args'_v164 = v166 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v167 : string = "$0.map_err(|x| $1(x))"
                let v168 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v161, v162) v167 
                let _run_target_args'_v164 = v168 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v169 : string = "$0.map_err(|x| $1(x))"
                let v170 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v161, v162) v169 
                let _run_target_args'_v164 = v170 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v171 : Result<std_path_PathBuf, string> = match v161 with Ok x -> Ok x | Error x -> Error (v162 x)
                let _run_target_args'_v164 = v171 
                #endif
#if FABLE_COMPILER_PYTHON
                let v172 : Result<std_path_PathBuf, string> = match v161 with Ok x -> Ok x | Error x -> Error (v162 x)
                let _run_target_args'_v164 = v172 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v173 : Result<std_path_PathBuf, string> = match v161 with Ok x -> Ok x | Error x -> Error (v162 x)
                let _run_target_args'_v164 = v173 
                #endif
#else
                let v174 : Result<std_path_PathBuf, string> = match v161 with Ok x -> Ok x | Error x -> Error (v162 x)
                let _run_target_args'_v164 = v174 
                #endif
                let v175 : Result<std_path_PathBuf, string> = _run_target_args'_v164 
                let v178 : (std_path_PathBuf -> US9) = method39()
                let v179 : (string -> US9) = method40()
                let v181 : US9 = match v175 with Ok x -> v178 x | Error x -> v179 x
                match v181 with
                | US9_1(v349) -> (* Error *)
                    let v350 : string = $"file_system.read_link / "
                    let v351 : string = $"error': {v349} / error: {v96} / name: {v5}"
                    let v352 : string = v350 + v351 
                    (* run_target_args'
                    let v357 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v358 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v359 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v352 v358 
                    let _run_target_args'_v357 = v359 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v360 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v361 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v352 v360 
                    let _run_target_args'_v357 = v361 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v362 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v363 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v352 v362 
                    let _run_target_args'_v357 = v363 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v365 : std_io_Error = v352 |> unbox<std_io_Error>
                    let _run_target_args'_v357 = v365 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v369 : std_io_Error = v352 |> unbox<std_io_Error>
                    let _run_target_args'_v357 = v369 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v373 : std_io_Error = v352 |> unbox<std_io_Error>
                    let _run_target_args'_v357 = v373 
                    #endif
#else
                    let v377 : std_io_Error = v352 |> unbox<std_io_Error>
                    let _run_target_args'_v357 = v377 
                    #endif
                    let v380 : std_io_Error = _run_target_args'_v357 
                    (* run_target_args'
                    let v390 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v391 : string = "Err($0)"
                    let v392 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v380 v391 
                    let _run_target_args'_v390 = v392 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v393 : string = "Err($0)"
                    let v394 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v380 v393 
                    let _run_target_args'_v390 = v394 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v395 : string = "Err($0)"
                    let v396 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v380 v395 
                    let _run_target_args'_v390 = v396 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v397 : Result<std_path_PathBuf, std_io_Error> = v380 |> Error
                    let _run_target_args'_v390 = v397 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v398 : Result<std_path_PathBuf, std_io_Error> = v380 |> Error
                    let _run_target_args'_v390 = v398 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v399 : Result<std_path_PathBuf, std_io_Error> = v380 |> Error
                    let _run_target_args'_v390 = v399 
                    #endif
#else
                    let v400 : Result<std_path_PathBuf, std_io_Error> = v380 |> Error
                    let _run_target_args'_v390 = v400 
                    #endif
                    let v401 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v390 
                    v401
                | US9_0(v184) -> (* Ok *)
                    (* run_target_args'
                    let v189 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v190 : string = "$0.display()"
                    let v191 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v184 v190 
                    let _run_target_args'_v189 = v191 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v192 : string = "$0.display()"
                    let v193 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v184 v192 
                    let _run_target_args'_v189 = v193 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v194 : string = "$0.display()"
                    let v195 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v184 v194 
                    let _run_target_args'_v189 = v195 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v197 : std_path_Display = v184 |> unbox<std_path_Display>
                    let _run_target_args'_v189 = v197 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v201 : std_path_Display = v184 |> unbox<std_path_Display>
                    let _run_target_args'_v189 = v201 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v205 : std_path_Display = v184 |> unbox<std_path_Display>
                    let _run_target_args'_v189 = v205 
                    #endif
#else
                    let v209 : std_path_Display = v184 |> unbox<std_path_Display>
                    let _run_target_args'_v189 = v209 
                    #endif
                    let v212 : std_path_Display = _run_target_args'_v189 
                    let v222 : string = v212 |> string 
                    let v225 : string = method26(v222, v5)
                    (* run_target_args'
                    let v230 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v231 : string = "&*$0"
                    let v232 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v225 v231 
                    let _run_target_args'_v230 = v232 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v233 : string = "&*$0"
                    let v234 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v225 v233 
                    let _run_target_args'_v230 = v234 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v235 : string = "&*$0"
                    let v236 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v225 v235 
                    let _run_target_args'_v230 = v236 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v238 : Ref<Str> = v225 |> unbox<Ref<Str>>
                    let _run_target_args'_v230 = v238 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v242 : Ref<Str> = v225 |> unbox<Ref<Str>>
                    let _run_target_args'_v230 = v242 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v246 : Ref<Str> = v225 |> unbox<Ref<Str>>
                    let _run_target_args'_v230 = v246 
                    #endif
#else
                    let v250 : Ref<Str> = v225 |> unbox<Ref<Str>>
                    let _run_target_args'_v230 = v250 
                    #endif
                    let v253 : Ref<Str> = _run_target_args'_v230 
                    (* run_target_args'
                    let v266 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v267 : string = "String::from($0)"
                    let v268 : std_string_String = Fable.Core.RustInterop.emitRustExpr v253 v267 
                    let _run_target_args'_v266 = v268 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v269 : string = "String::from($0)"
                    let v270 : std_string_String = Fable.Core.RustInterop.emitRustExpr v253 v269 
                    let _run_target_args'_v266 = v270 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v271 : string = "String::from($0)"
                    let v272 : std_string_String = Fable.Core.RustInterop.emitRustExpr v253 v271 
                    let _run_target_args'_v266 = v272 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v274 : std_string_String = v253 |> unbox<std_string_String>
                    let _run_target_args'_v266 = v274 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v278 : std_string_String = v253 |> unbox<std_string_String>
                    let _run_target_args'_v266 = v278 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v282 : std_string_String = v253 |> unbox<std_string_String>
                    let _run_target_args'_v266 = v282 
                    #endif
#else
                    let v286 : std_string_String = v253 |> unbox<std_string_String>
                    let _run_target_args'_v266 = v286 
                    #endif
                    let v289 : std_string_String = _run_target_args'_v266 
                    (* run_target_args'
                    let v302 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v303 : string = "std::path::PathBuf::from($0)"
                    let v304 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v289 v303 
                    let _run_target_args'_v302 = v304 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v305 : string = "std::path::PathBuf::from($0)"
                    let v306 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v289 v305 
                    let _run_target_args'_v302 = v306 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v307 : string = "std::path::PathBuf::from($0)"
                    let v308 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v289 v307 
                    let _run_target_args'_v302 = v308 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v310 : std_path_PathBuf = v289 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v302 = v310 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v314 : std_path_PathBuf = v289 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v302 = v314 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v318 : std_path_PathBuf = v289 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v302 = v318 
                    #endif
#else
                    let v322 : std_path_PathBuf = v289 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v302 = v322 
                    #endif
                    let v325 : std_path_PathBuf = _run_target_args'_v302 
                    (* run_target_args'
                    let v335 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v336 : string = "Ok($0)"
                    let v337 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v325 v336 
                    let _run_target_args'_v335 = v337 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v338 : string = "Ok($0)"
                    let v339 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v325 v338 
                    let _run_target_args'_v335 = v339 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v340 : string = "Ok($0)"
                    let v341 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v325 v340 
                    let _run_target_args'_v335 = v341 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v342 : Result<std_path_PathBuf, std_io_Error> = v325 |> Ok
                    let _run_target_args'_v335 = v342 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v343 : Result<std_path_PathBuf, std_io_Error> = v325 |> Ok
                    let _run_target_args'_v335 = v343 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v344 : Result<std_path_PathBuf, std_io_Error> = v325 |> Ok
                    let _run_target_args'_v335 = v344 
                    #endif
#else
                    let v345 : Result<std_path_PathBuf, std_io_Error> = v325 |> Ok
                    let _run_target_args'_v335 = v345 
                    #endif
                    let v346 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v335 
                    v346
            else
                let v406 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v407 : string = $"path: {v0} / error: {v96} / path': {v4} / name: {v5}"
                let v408 : string = v406 + v407 
                (* run_target_args'
                let v413 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v414 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v415 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v408 v414 
                let _run_target_args'_v413 = v415 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v416 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v417 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v408 v416 
                let _run_target_args'_v413 = v417 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v418 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v419 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v408 v418 
                let _run_target_args'_v413 = v419 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v421 : std_io_Error = v408 |> unbox<std_io_Error>
                let _run_target_args'_v413 = v421 
                #endif
#if FABLE_COMPILER_PYTHON
                let v425 : std_io_Error = v408 |> unbox<std_io_Error>
                let _run_target_args'_v413 = v425 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v429 : std_io_Error = v408 |> unbox<std_io_Error>
                let _run_target_args'_v413 = v429 
                #endif
#else
                let v433 : std_io_Error = v408 |> unbox<std_io_Error>
                let _run_target_args'_v413 = v433 
                #endif
                let v436 : std_io_Error = _run_target_args'_v413 
                (* run_target_args'
                let v446 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v447 : string = "Err($0)"
                let v448 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v436 v447 
                let _run_target_args'_v446 = v448 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v449 : string = "Err($0)"
                let v450 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v436 v449 
                let _run_target_args'_v446 = v450 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v451 : string = "Err($0)"
                let v452 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v436 v451 
                let _run_target_args'_v446 = v452 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v453 : Result<std_path_PathBuf, std_io_Error> = v436 |> Error
                let _run_target_args'_v446 = v453 
                #endif
#if FABLE_COMPILER_PYTHON
                let v454 : Result<std_path_PathBuf, std_io_Error> = v436 |> Error
                let _run_target_args'_v446 = v454 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v455 : Result<std_path_PathBuf, std_io_Error> = v436 |> Error
                let _run_target_args'_v446 = v455 
                #endif
#else
                let v456 : Result<std_path_PathBuf, std_io_Error> = v436 |> Error
                let _run_target_args'_v446 = v456 
                #endif
                let v457 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v446 
                v457
        | _ ->
            let v461 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v462 : string = $"path: {v0} / error: {v96} / path': {v4} / name: {v5}"
            let v463 : string = v461 + v462 
            (* run_target_args'
            let v468 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v469 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v470 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v463 v469 
            let _run_target_args'_v468 = v470 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v471 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v472 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v463 v471 
            let _run_target_args'_v468 = v472 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v473 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v474 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v463 v473 
            let _run_target_args'_v468 = v474 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v476 : std_io_Error = v463 |> unbox<std_io_Error>
            let _run_target_args'_v468 = v476 
            #endif
#if FABLE_COMPILER_PYTHON
            let v480 : std_io_Error = v463 |> unbox<std_io_Error>
            let _run_target_args'_v468 = v480 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v484 : std_io_Error = v463 |> unbox<std_io_Error>
            let _run_target_args'_v468 = v484 
            #endif
#else
            let v488 : std_io_Error = v463 |> unbox<std_io_Error>
            let _run_target_args'_v468 = v488 
            #endif
            let v491 : std_io_Error = _run_target_args'_v468 
            (* run_target_args'
            let v501 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v502 : string = "Err($0)"
            let v503 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v491 v502 
            let _run_target_args'_v501 = v503 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v504 : string = "Err($0)"
            let v505 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v491 v504 
            let _run_target_args'_v501 = v505 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v506 : string = "Err($0)"
            let v507 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v491 v506 
            let _run_target_args'_v501 = v507 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v508 : Result<std_path_PathBuf, std_io_Error> = v491 |> Error
            let _run_target_args'_v501 = v508 
            #endif
#if FABLE_COMPILER_PYTHON
            let v509 : Result<std_path_PathBuf, std_io_Error> = v491 |> Error
            let _run_target_args'_v501 = v509 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v510 : Result<std_path_PathBuf, std_io_Error> = v491 |> Error
            let _run_target_args'_v501 = v510 
            #endif
#else
            let v511 : Result<std_path_PathBuf, std_io_Error> = v491 |> Error
            let _run_target_args'_v501 = v511 
            #endif
            let v512 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v501 
            v512
and method49 (v0 : string, v1 : uint8, v2 : string) : Result<std_path_PathBuf, std_io_Error> =
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
    let v45 : System.IO.FileAttributes = method46(v36)
    let v46 : System.IO.FileAttributes = method47()
    let v47 : bool = method48(v46, v45)
    if v47 then
        (* run_target_args'
        let v52 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v54 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v52 = v54 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v58 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v52 = v58 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v62 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v52 = v62 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v66 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v52 = v66 
        #endif
#if FABLE_COMPILER_PYTHON
        let v70 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v52 = v70 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v74 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v52 = v74 
        #endif
#else
        let v78 : System_IO_FileInfo = v2 |> System_IO_FileInfo 
        let _run_target_args'_v52 = v78 
        #endif
        let v81 : System_IO_FileInfo = _run_target_args'_v52 
        (* run_target_args'
        let v94 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v96 : string = null |> unbox<string>
        let _run_target_args'_v94 = v96 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v100 : string = null |> unbox<string>
        let _run_target_args'_v94 = v100 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v104 : string = null |> unbox<string>
        let _run_target_args'_v94 = v104 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v108 : string = null |> unbox<string>
        let _run_target_args'_v94 = v108 
        #endif
#if FABLE_COMPILER_PYTHON
        let v112 : string = null |> unbox<string>
        let _run_target_args'_v94 = v112 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v116 : string = null |> unbox<string>
        let _run_target_args'_v94 = v116 
        #endif
#else
        let v119 : (System_IO_FileInfo -> string) = _.LinkTarget
        let v120 : string = v119 v81
        let _run_target_args'_v94 = v120 
        #endif
        let v121 : string = _run_target_args'_v94 
        let v131 : std_path_PathBuf = v121 |> unbox<std_path_PathBuf>
        (* run_target_args'
        let v135 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v136 : string = "Ok($0)"
        let v137 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v131 v136 
        let _run_target_args'_v135 = v137 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v138 : string = "Ok($0)"
        let v139 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v131 v138 
        let _run_target_args'_v135 = v139 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v140 : string = "Ok($0)"
        let v141 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v131 v140 
        let _run_target_args'_v135 = v141 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v142 : Result<std_path_PathBuf, std_io_Error> = v131 |> Ok
        let _run_target_args'_v135 = v142 
        #endif
#if FABLE_COMPILER_PYTHON
        let v143 : Result<std_path_PathBuf, std_io_Error> = v131 |> Ok
        let _run_target_args'_v135 = v143 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v144 : Result<std_path_PathBuf, std_io_Error> = v131 |> Ok
        let _run_target_args'_v135 = v144 
        #endif
#else
        let v145 : Result<std_path_PathBuf, std_io_Error> = v131 |> Ok
        let _run_target_args'_v135 = v145 
        #endif
        let v146 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v135 
        v146
    else
        let v149 : string = $"file_system.read_link / Fsharp / "
        let v150 : string = $"The file or directory is not a reparse point. / "
        let v151 : string = v149 + v150 
        let v152 : string = $"path: {v0} / result: {v47} / path': {v2} / n: {v1}"
        let v153 : string = v151 + v152 
        (* run_target_args'
        let v158 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v159 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v160 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v153 v159 
        let _run_target_args'_v158 = v160 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v161 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v162 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v153 v161 
        let _run_target_args'_v158 = v162 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v163 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v164 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v153 v163 
        let _run_target_args'_v158 = v164 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v166 : std_io_Error = v153 |> unbox<std_io_Error>
        let _run_target_args'_v158 = v166 
        #endif
#if FABLE_COMPILER_PYTHON
        let v170 : std_io_Error = v153 |> unbox<std_io_Error>
        let _run_target_args'_v158 = v170 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v174 : std_io_Error = v153 |> unbox<std_io_Error>
        let _run_target_args'_v158 = v174 
        #endif
#else
        let v178 : std_io_Error = v153 |> unbox<std_io_Error>
        let _run_target_args'_v158 = v178 
        #endif
        let v181 : std_io_Error = _run_target_args'_v158 
        let v190 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure21(v0)
        method50(v0, v190, v1, v181, v2)
and closure22 (v0 : string, v1 : uint8) (v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    method49(v0, v1, v2)
and closure21 (v0 : string) (v1 : uint8) : (string -> Result<std_path_PathBuf, std_io_Error>) =
    closure22(v0, v1)
and method51 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : std_io_Error) : Result<std_path_PathBuf, std_io_Error> =
    let v4 : string = method43(v0)
    let v5 : string option = method31(v0)
    let v8 : (string -> US5) = method6()
    let v9 : US5 option = v5 |> Option.map v8 
    let v29 : US5 = US5_1
    let v30 : US5 = v9 |> Option.defaultValue v29 
    let v34 : string = method13()
    let v35 : Mut3 = {l0 = v34} : Mut3
    (* run_target_args'
    let v40 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v41 : string = "format!(\"{:#?}\", $0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v41 
    let v43 : string = "fable_library_rust::String_::fromString($0)"
    let v44 : string = Fable.Core.RustInterop.emitRustExpr v42 v43 
    let _run_target_args'_v40 = v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : string = "format!(\"{:#?}\", $0)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v45 
    let v47 : string = "fable_library_rust::String_::fromString($0)"
    let v48 : string = Fable.Core.RustInterop.emitRustExpr v46 v47 
    let _run_target_args'_v40 = v48 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v49 : string = "format!(\"{:#?}\", $0)"
    let v50 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v49 
    let v51 : string = "fable_library_rust::String_::fromString($0)"
    let v52 : string = Fable.Core.RustInterop.emitRustExpr v50 v51 
    let _run_target_args'_v40 = v52 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v54 : string = $"%A{v3}"
    let _run_target_args'_v40 = v54 
    #endif
#if FABLE_COMPILER_PYTHON
    let v58 : string = $"%A{v3}"
    let _run_target_args'_v40 = v58 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v62 : string = $"%A{v3}"
    let _run_target_args'_v40 = v62 
    #endif
#else
    let v66 : string = $"%A{v3}"
    let _run_target_args'_v40 = v66 
    #endif
    let v69 : string = _run_target_args'_v40 
    let v79 : string = $"{v69}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure8(v35, v79)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v95 : string = v35.l0
    let v96 : bool = v2 >= 11uy
    if v96 then
        let v97 : string = $"file_system.read_link / "
        let v98 : string = $"path: {v0} / n: {v2} / path': {v0} / name: {v4}"
        let v99 : string = v97 + v98 
        (* run_target_args'
        let v104 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v105 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v106 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v99 v105 
        let _run_target_args'_v104 = v106 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v107 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v108 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v99 v107 
        let _run_target_args'_v104 = v108 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v109 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v110 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v99 v109 
        let _run_target_args'_v104 = v110 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v112 : std_io_Error = v99 |> unbox<std_io_Error>
        let _run_target_args'_v104 = v112 
        #endif
#if FABLE_COMPILER_PYTHON
        let v116 : std_io_Error = v99 |> unbox<std_io_Error>
        let _run_target_args'_v104 = v116 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v120 : std_io_Error = v99 |> unbox<std_io_Error>
        let _run_target_args'_v104 = v120 
        #endif
#else
        let v124 : std_io_Error = v99 |> unbox<std_io_Error>
        let _run_target_args'_v104 = v124 
        #endif
        let v127 : std_io_Error = _run_target_args'_v104 
        (* run_target_args'
        let v137 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v138 : string = "Err($0)"
        let v139 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v127 v138 
        let _run_target_args'_v137 = v139 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v140 : string = "Err($0)"
        let v141 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v127 v140 
        let _run_target_args'_v137 = v141 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v142 : string = "Err($0)"
        let v143 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v127 v142 
        let _run_target_args'_v137 = v143 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v144 : Result<std_path_PathBuf, std_io_Error> = v127 |> Error
        let _run_target_args'_v137 = v144 
        #endif
#if FABLE_COMPILER_PYTHON
        let v145 : Result<std_path_PathBuf, std_io_Error> = v127 |> Error
        let _run_target_args'_v137 = v145 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v146 : Result<std_path_PathBuf, std_io_Error> = v127 |> Error
        let _run_target_args'_v137 = v146 
        #endif
#else
        let v147 : Result<std_path_PathBuf, std_io_Error> = v127 |> Error
        let _run_target_args'_v137 = v147 
        #endif
        let v148 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v137 
        v148
    else
        match v30 with
        | US5_0(v151) -> (* Some *)
            let v154 : string = ""
            let v155 : bool = v0 <> v154 
            if v155 then
                let v158 : uint8 = v2 + 1uy
                let v159 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v158
                let v160 : Result<std_path_PathBuf, std_io_Error> = v159 v151
                let v161 : (std_io_Error -> string) = method38()
                (* run_target_args'
                let v163 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v164 : string = "$0.map_err(|x| $1(x))"
                let v165 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v160, v161) v164 
                let _run_target_args'_v163 = v165 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v166 : string = "$0.map_err(|x| $1(x))"
                let v167 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v160, v161) v166 
                let _run_target_args'_v163 = v167 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v168 : string = "$0.map_err(|x| $1(x))"
                let v169 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v160, v161) v168 
                let _run_target_args'_v163 = v169 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v170 : Result<std_path_PathBuf, string> = match v160 with Ok x -> Ok x | Error x -> Error (v161 x)
                let _run_target_args'_v163 = v170 
                #endif
#if FABLE_COMPILER_PYTHON
                let v171 : Result<std_path_PathBuf, string> = match v160 with Ok x -> Ok x | Error x -> Error (v161 x)
                let _run_target_args'_v163 = v171 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v172 : Result<std_path_PathBuf, string> = match v160 with Ok x -> Ok x | Error x -> Error (v161 x)
                let _run_target_args'_v163 = v172 
                #endif
#else
                let v173 : Result<std_path_PathBuf, string> = match v160 with Ok x -> Ok x | Error x -> Error (v161 x)
                let _run_target_args'_v163 = v173 
                #endif
                let v174 : Result<std_path_PathBuf, string> = _run_target_args'_v163 
                let v177 : (std_path_PathBuf -> US9) = method39()
                let v178 : (string -> US9) = method40()
                let v180 : US9 = match v174 with Ok x -> v177 x | Error x -> v178 x
                match v180 with
                | US9_1(v348) -> (* Error *)
                    let v349 : string = $"file_system.read_link / "
                    let v350 : string = $"error': {v348} / error: {v95} / name: {v4}"
                    let v351 : string = v349 + v350 
                    (* run_target_args'
                    let v356 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v357 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v358 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v351 v357 
                    let _run_target_args'_v356 = v358 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v359 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v360 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v351 v359 
                    let _run_target_args'_v356 = v360 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v361 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v362 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v351 v361 
                    let _run_target_args'_v356 = v362 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v364 : std_io_Error = v351 |> unbox<std_io_Error>
                    let _run_target_args'_v356 = v364 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v368 : std_io_Error = v351 |> unbox<std_io_Error>
                    let _run_target_args'_v356 = v368 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v372 : std_io_Error = v351 |> unbox<std_io_Error>
                    let _run_target_args'_v356 = v372 
                    #endif
#else
                    let v376 : std_io_Error = v351 |> unbox<std_io_Error>
                    let _run_target_args'_v356 = v376 
                    #endif
                    let v379 : std_io_Error = _run_target_args'_v356 
                    (* run_target_args'
                    let v389 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v390 : string = "Err($0)"
                    let v391 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v379 v390 
                    let _run_target_args'_v389 = v391 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v392 : string = "Err($0)"
                    let v393 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v379 v392 
                    let _run_target_args'_v389 = v393 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v394 : string = "Err($0)"
                    let v395 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v379 v394 
                    let _run_target_args'_v389 = v395 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v396 : Result<std_path_PathBuf, std_io_Error> = v379 |> Error
                    let _run_target_args'_v389 = v396 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v397 : Result<std_path_PathBuf, std_io_Error> = v379 |> Error
                    let _run_target_args'_v389 = v397 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v398 : Result<std_path_PathBuf, std_io_Error> = v379 |> Error
                    let _run_target_args'_v389 = v398 
                    #endif
#else
                    let v399 : Result<std_path_PathBuf, std_io_Error> = v379 |> Error
                    let _run_target_args'_v389 = v399 
                    #endif
                    let v400 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v389 
                    v400
                | US9_0(v183) -> (* Ok *)
                    (* run_target_args'
                    let v188 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v189 : string = "$0.display()"
                    let v190 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v183 v189 
                    let _run_target_args'_v188 = v190 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v191 : string = "$0.display()"
                    let v192 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v183 v191 
                    let _run_target_args'_v188 = v192 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v193 : string = "$0.display()"
                    let v194 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v183 v193 
                    let _run_target_args'_v188 = v194 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v196 : std_path_Display = v183 |> unbox<std_path_Display>
                    let _run_target_args'_v188 = v196 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v200 : std_path_Display = v183 |> unbox<std_path_Display>
                    let _run_target_args'_v188 = v200 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v204 : std_path_Display = v183 |> unbox<std_path_Display>
                    let _run_target_args'_v188 = v204 
                    #endif
#else
                    let v208 : std_path_Display = v183 |> unbox<std_path_Display>
                    let _run_target_args'_v188 = v208 
                    #endif
                    let v211 : std_path_Display = _run_target_args'_v188 
                    let v221 : string = v211 |> string 
                    let v224 : string = method26(v221, v4)
                    (* run_target_args'
                    let v229 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v230 : string = "&*$0"
                    let v231 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v224 v230 
                    let _run_target_args'_v229 = v231 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v232 : string = "&*$0"
                    let v233 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v224 v232 
                    let _run_target_args'_v229 = v233 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v234 : string = "&*$0"
                    let v235 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v224 v234 
                    let _run_target_args'_v229 = v235 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v237 : Ref<Str> = v224 |> unbox<Ref<Str>>
                    let _run_target_args'_v229 = v237 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v241 : Ref<Str> = v224 |> unbox<Ref<Str>>
                    let _run_target_args'_v229 = v241 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v245 : Ref<Str> = v224 |> unbox<Ref<Str>>
                    let _run_target_args'_v229 = v245 
                    #endif
#else
                    let v249 : Ref<Str> = v224 |> unbox<Ref<Str>>
                    let _run_target_args'_v229 = v249 
                    #endif
                    let v252 : Ref<Str> = _run_target_args'_v229 
                    (* run_target_args'
                    let v265 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v266 : string = "String::from($0)"
                    let v267 : std_string_String = Fable.Core.RustInterop.emitRustExpr v252 v266 
                    let _run_target_args'_v265 = v267 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v268 : string = "String::from($0)"
                    let v269 : std_string_String = Fable.Core.RustInterop.emitRustExpr v252 v268 
                    let _run_target_args'_v265 = v269 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v270 : string = "String::from($0)"
                    let v271 : std_string_String = Fable.Core.RustInterop.emitRustExpr v252 v270 
                    let _run_target_args'_v265 = v271 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v273 : std_string_String = v252 |> unbox<std_string_String>
                    let _run_target_args'_v265 = v273 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v277 : std_string_String = v252 |> unbox<std_string_String>
                    let _run_target_args'_v265 = v277 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v281 : std_string_String = v252 |> unbox<std_string_String>
                    let _run_target_args'_v265 = v281 
                    #endif
#else
                    let v285 : std_string_String = v252 |> unbox<std_string_String>
                    let _run_target_args'_v265 = v285 
                    #endif
                    let v288 : std_string_String = _run_target_args'_v265 
                    (* run_target_args'
                    let v301 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v302 : string = "std::path::PathBuf::from($0)"
                    let v303 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v288 v302 
                    let _run_target_args'_v301 = v303 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v304 : string = "std::path::PathBuf::from($0)"
                    let v305 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v288 v304 
                    let _run_target_args'_v301 = v305 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v306 : string = "std::path::PathBuf::from($0)"
                    let v307 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v288 v306 
                    let _run_target_args'_v301 = v307 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v309 : std_path_PathBuf = v288 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v301 = v309 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v313 : std_path_PathBuf = v288 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v301 = v313 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v317 : std_path_PathBuf = v288 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v301 = v317 
                    #endif
#else
                    let v321 : std_path_PathBuf = v288 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v301 = v321 
                    #endif
                    let v324 : std_path_PathBuf = _run_target_args'_v301 
                    (* run_target_args'
                    let v334 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v335 : string = "Ok($0)"
                    let v336 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v324 v335 
                    let _run_target_args'_v334 = v336 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v337 : string = "Ok($0)"
                    let v338 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v324 v337 
                    let _run_target_args'_v334 = v338 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v339 : string = "Ok($0)"
                    let v340 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v324 v339 
                    let _run_target_args'_v334 = v340 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v341 : Result<std_path_PathBuf, std_io_Error> = v324 |> Ok
                    let _run_target_args'_v334 = v341 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v342 : Result<std_path_PathBuf, std_io_Error> = v324 |> Ok
                    let _run_target_args'_v334 = v342 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v343 : Result<std_path_PathBuf, std_io_Error> = v324 |> Ok
                    let _run_target_args'_v334 = v343 
                    #endif
#else
                    let v344 : Result<std_path_PathBuf, std_io_Error> = v324 |> Ok
                    let _run_target_args'_v334 = v344 
                    #endif
                    let v345 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v334 
                    v345
            else
                let v405 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v406 : string = $"path: {v0} / error: {v95} / path': {v0} / name: {v4}"
                let v407 : string = v405 + v406 
                (* run_target_args'
                let v412 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v413 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v414 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v407 v413 
                let _run_target_args'_v412 = v414 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v415 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v416 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v407 v415 
                let _run_target_args'_v412 = v416 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v417 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v418 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v407 v417 
                let _run_target_args'_v412 = v418 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v420 : std_io_Error = v407 |> unbox<std_io_Error>
                let _run_target_args'_v412 = v420 
                #endif
#if FABLE_COMPILER_PYTHON
                let v424 : std_io_Error = v407 |> unbox<std_io_Error>
                let _run_target_args'_v412 = v424 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v428 : std_io_Error = v407 |> unbox<std_io_Error>
                let _run_target_args'_v412 = v428 
                #endif
#else
                let v432 : std_io_Error = v407 |> unbox<std_io_Error>
                let _run_target_args'_v412 = v432 
                #endif
                let v435 : std_io_Error = _run_target_args'_v412 
                (* run_target_args'
                let v445 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v446 : string = "Err($0)"
                let v447 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v435 v446 
                let _run_target_args'_v445 = v447 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v448 : string = "Err($0)"
                let v449 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v435 v448 
                let _run_target_args'_v445 = v449 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v450 : string = "Err($0)"
                let v451 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v435 v450 
                let _run_target_args'_v445 = v451 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v452 : Result<std_path_PathBuf, std_io_Error> = v435 |> Error
                let _run_target_args'_v445 = v452 
                #endif
#if FABLE_COMPILER_PYTHON
                let v453 : Result<std_path_PathBuf, std_io_Error> = v435 |> Error
                let _run_target_args'_v445 = v453 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v454 : Result<std_path_PathBuf, std_io_Error> = v435 |> Error
                let _run_target_args'_v445 = v454 
                #endif
#else
                let v455 : Result<std_path_PathBuf, std_io_Error> = v435 |> Error
                let _run_target_args'_v445 = v455 
                #endif
                let v456 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v445 
                v456
        | _ ->
            let v460 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v461 : string = $"path: {v0} / error: {v95} / path': {v0} / name: {v4}"
            let v462 : string = v460 + v461 
            (* run_target_args'
            let v467 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v468 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v469 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v462 v468 
            let _run_target_args'_v467 = v469 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v470 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v471 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v462 v470 
            let _run_target_args'_v467 = v471 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v472 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v473 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v462 v472 
            let _run_target_args'_v467 = v473 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v475 : std_io_Error = v462 |> unbox<std_io_Error>
            let _run_target_args'_v467 = v475 
            #endif
#if FABLE_COMPILER_PYTHON
            let v479 : std_io_Error = v462 |> unbox<std_io_Error>
            let _run_target_args'_v467 = v479 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v483 : std_io_Error = v462 |> unbox<std_io_Error>
            let _run_target_args'_v467 = v483 
            #endif
#else
            let v487 : std_io_Error = v462 |> unbox<std_io_Error>
            let _run_target_args'_v467 = v487 
            #endif
            let v490 : std_io_Error = _run_target_args'_v467 
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = "Err($0)"
            let v502 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v490 v501 
            let _run_target_args'_v500 = v502 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v503 : string = "Err($0)"
            let v504 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v490 v503 
            let _run_target_args'_v500 = v504 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v505 : string = "Err($0)"
            let v506 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v490 v505 
            let _run_target_args'_v500 = v506 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v507 : Result<std_path_PathBuf, std_io_Error> = v490 |> Error
            let _run_target_args'_v500 = v507 
            #endif
#if FABLE_COMPILER_PYTHON
            let v508 : Result<std_path_PathBuf, std_io_Error> = v490 |> Error
            let _run_target_args'_v500 = v508 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v509 : Result<std_path_PathBuf, std_io_Error> = v490 |> Error
            let _run_target_args'_v500 = v509 
            #endif
#else
            let v510 : Result<std_path_PathBuf, std_io_Error> = v490 |> Error
            let _run_target_args'_v500 = v510 
            #endif
            let v511 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v500 
            v511
and method45 (v0 : string, v1 : uint8) : Result<std_path_PathBuf, std_io_Error> =
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
    let v44 : System.IO.FileAttributes = method46(v35)
    let v45 : System.IO.FileAttributes = method47()
    let v46 : bool = method48(v45, v44)
    if v46 then
        (* run_target_args'
        let v51 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v53 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v51 = v53 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v57 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v51 = v57 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v61 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v51 = v61 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v65 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v51 = v65 
        #endif
#if FABLE_COMPILER_PYTHON
        let v69 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v51 = v69 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v73 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v51 = v73 
        #endif
#else
        let v77 : System_IO_FileInfo = v0 |> System_IO_FileInfo 
        let _run_target_args'_v51 = v77 
        #endif
        let v80 : System_IO_FileInfo = _run_target_args'_v51 
        (* run_target_args'
        let v93 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v95 : string = null |> unbox<string>
        let _run_target_args'_v93 = v95 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v99 : string = null |> unbox<string>
        let _run_target_args'_v93 = v99 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v103 : string = null |> unbox<string>
        let _run_target_args'_v93 = v103 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v107 : string = null |> unbox<string>
        let _run_target_args'_v93 = v107 
        #endif
#if FABLE_COMPILER_PYTHON
        let v111 : string = null |> unbox<string>
        let _run_target_args'_v93 = v111 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v115 : string = null |> unbox<string>
        let _run_target_args'_v93 = v115 
        #endif
#else
        let v118 : (System_IO_FileInfo -> string) = _.LinkTarget
        let v119 : string = v118 v80
        let _run_target_args'_v93 = v119 
        #endif
        let v120 : string = _run_target_args'_v93 
        let v130 : std_path_PathBuf = v120 |> unbox<std_path_PathBuf>
        (* run_target_args'
        let v134 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v135 : string = "Ok($0)"
        let v136 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v130 v135 
        let _run_target_args'_v134 = v136 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v137 : string = "Ok($0)"
        let v138 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v130 v137 
        let _run_target_args'_v134 = v138 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v139 : string = "Ok($0)"
        let v140 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v130 v139 
        let _run_target_args'_v134 = v140 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v141 : Result<std_path_PathBuf, std_io_Error> = v130 |> Ok
        let _run_target_args'_v134 = v141 
        #endif
#if FABLE_COMPILER_PYTHON
        let v142 : Result<std_path_PathBuf, std_io_Error> = v130 |> Ok
        let _run_target_args'_v134 = v142 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v143 : Result<std_path_PathBuf, std_io_Error> = v130 |> Ok
        let _run_target_args'_v134 = v143 
        #endif
#else
        let v144 : Result<std_path_PathBuf, std_io_Error> = v130 |> Ok
        let _run_target_args'_v134 = v144 
        #endif
        let v145 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v134 
        v145
    else
        let v148 : string = $"file_system.read_link / Fsharp / "
        let v149 : string = $"The file or directory is not a reparse point. / "
        let v150 : string = v148 + v149 
        let v151 : string = $"path: {v0} / result: {v46} / path': {v0} / n: {v1}"
        let v152 : string = v150 + v151 
        (* run_target_args'
        let v157 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v158 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v159 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v152 v158 
        let _run_target_args'_v157 = v159 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v160 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v161 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v152 v160 
        let _run_target_args'_v157 = v161 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v162 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v163 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v152 v162 
        let _run_target_args'_v157 = v163 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v165 : std_io_Error = v152 |> unbox<std_io_Error>
        let _run_target_args'_v157 = v165 
        #endif
#if FABLE_COMPILER_PYTHON
        let v169 : std_io_Error = v152 |> unbox<std_io_Error>
        let _run_target_args'_v157 = v169 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v173 : std_io_Error = v152 |> unbox<std_io_Error>
        let _run_target_args'_v157 = v173 
        #endif
#else
        let v177 : std_io_Error = v152 |> unbox<std_io_Error>
        let _run_target_args'_v157 = v177 
        #endif
        let v180 : std_io_Error = _run_target_args'_v157 
        let v189 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure21(v0)
        method51(v0, v189, v1, v180)
and method36 (v0 : string) : Result<std_path_PathBuf, std_io_Error> =
    (* run_target_args'
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : bool = method29(v0)
    let v8 : Result<std_path_PathBuf, std_io_Error> =
        if v3 then
            let v4 : string = "std::fs::read_link(&*$0)"
            let v5 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v4 
            v5
        else
            let v6 : uint8 = 0uy
            method37(v0, v6)
    let _run_target_args'_v2 = v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9 : bool = method29(v0)
    let v14 : Result<std_path_PathBuf, std_io_Error> =
        if v9 then
            let v10 : string = "std::fs::read_link(&*$0)"
            let v11 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v10 
            v11
        else
            let v12 : uint8 = 0uy
            method37(v0, v12)
    let _run_target_args'_v2 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : bool = method29(v0)
    let v20 : Result<std_path_PathBuf, std_io_Error> =
        if v15 then
            let v16 : string = "std::fs::read_link(&*$0)"
            let v17 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v16 
            v17
        else
            let v18 : uint8 = 0uy
            method37(v0, v18)
    let _run_target_args'_v2 = v20 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v21 : uint8 = 0uy
    let v22 : Result<std_path_PathBuf, std_io_Error> = method45(v0, v21)
    let _run_target_args'_v2 = v22 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : Result<std_path_PathBuf, std_io_Error> = Unchecked.defaultof<_>
    let _run_target_args'_v2 = v23 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v24 : uint8 = 0uy
    let v25 : Result<std_path_PathBuf, std_io_Error> = method45(v0, v24)
    let _run_target_args'_v2 = v25 
    #endif
#else
    let v26 : uint8 = 0uy
    let v27 : Result<std_path_PathBuf, std_io_Error> = method45(v0, v26)
    let _run_target_args'_v2 = v27 
    #endif
    let v28 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v2 
    v28
and closure23 () (v0 : std_path_PathBuf) : US10 =
    US10_0(v0)
and method52 () : (std_path_PathBuf -> US10) =
    closure23()
and method54 (v0 : string) : string =
    v0
and method55 () : string =
    let v0 : string = ""
    v0
and method53 (v0 : string, v1 : string, v2 : string) : string =
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
    let v22 : string = method54(v2)
    let v23 : string = $"$0.replace_all(&*$1, &*$2)"
    let v24 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v19, v22, v1) v23 
    let v25 : string = "String::from($0)"
    let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let v27 : string = "fable_library_rust::String_::fromString($0)"
    let v28 : string = Fable.Core.RustInterop.emitRustExpr v26 v27 
    let _run_target_args'_v4 = v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = method55()
    let _run_target_args'_v4 = v29 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v30 : string = method55()
    let _run_target_args'_v4 = v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v31 : string = method55()
    let _run_target_args'_v4 = v31 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : string = method55()
    let _run_target_args'_v4 = v32 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v33 : string = method55()
    let _run_target_args'_v4 = v33 
    #endif
#else
    let v34 : string = System.Text.RegularExpressions.Regex.Replace (v2, v0, v1)
    let _run_target_args'_v4 = v34 
    #endif
    let v35 : string = _run_target_args'_v4 
    v35
and method35 (v0 : string) : string =
    let v1 : bool = v0 = ""
    if v1 then
        let v2 : string = ""
        v2
    else
        let v3 : Result<std_path_PathBuf, std_io_Error> = method36(v0)
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
        let v21 : (std_path_PathBuf -> US10) = method52()
        let v22 : US10 option = v16 |> Option.map v21 
        let v42 : US10 = US10_1
        let v43 : US10 = v22 |> Option.defaultValue v42 
        let v89 : string =
            match v43 with
            | US10_1 -> (* None *)
                v0
            | US10_0(v47) -> (* Some *)
                (* run_target_args'
                let v52 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v53 : string = "$0.display()"
                let v54 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v47 v53 
                let _run_target_args'_v52 = v54 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v55 : string = "$0.display()"
                let v56 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v47 v55 
                let _run_target_args'_v52 = v56 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v57 : string = "$0.display()"
                let v58 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v47 v57 
                let _run_target_args'_v52 = v58 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v60 : std_path_Display = v47 |> unbox<std_path_Display>
                let _run_target_args'_v52 = v60 
                #endif
#if FABLE_COMPILER_PYTHON
                let v64 : std_path_Display = v47 |> unbox<std_path_Display>
                let _run_target_args'_v52 = v64 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v68 : std_path_Display = v47 |> unbox<std_path_Display>
                let _run_target_args'_v52 = v68 
                #endif
#else
                let v72 : std_path_Display = v47 |> unbox<std_path_Display>
                let _run_target_args'_v52 = v72 
                #endif
                let v75 : std_path_Display = _run_target_args'_v52 
                let v85 : string = v75 |> string 
                v85
        let v90 : bool = v89 = ""
        let v91 : string =
            if v90 then
                v0
            else
                v89
        let v92 : string = "^\\\\\\\\\\?\\\\"
        let v93 : string = ""
        let v94 : string = method53(v92, v93, v91)
        let v95 : int32 = v94.Length
        let v96 : bool = v95 < 2
        if v96 then
            v0
        else
            let v97 : string = $"{v94.[0] |> string |> _.ToLower()}{v94.[1..]}"
            let v98 : string = "\\"
            let v99 : string = "/"
            let v100 : string = v97.Replace (v98, v99)
            v100
and method25 (v0 : string) : US5 =
    let v1 : US7 = US7_1
    let v2 : string = "spiral"
    let v3 : string = "workspace"
    let v4 : string = method26(v2, v3)
    let v5 : US8 = method27(v1, v4, v0)
    match v5 with
    | US8_1(v9) -> (* Error *)
        let v70 : unit = ()
        let v71 : (unit -> unit) = closure15(v0, v9)
        let v72 : unit = (fun () -> v71 (); v70) ()
        US5_1
    | US8_0(v6) -> (* Ok *)
        let v7 : string = method35(v6)
        US5_0(v7)
and method57 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method58 (v0 : int32, v1 : Mut6) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method59 () : char =
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
and method60 (v0 : string) : string =
    v0
and method56 (v0 : string) : string =
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
    let v46 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v47 : string = "String::from($0)"
    let v48 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v47 
    let _run_target_args'_v46 = v48 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v49 : string = "String::from($0)"
    let v50 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v49 
    let _run_target_args'_v46 = v50 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v51 : string = "String::from($0)"
    let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v51 
    let _run_target_args'_v46 = v52 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v54 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v46 = v54 
    #endif
#if FABLE_COMPILER_PYTHON
    let v58 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v46 = v58 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v62 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v46 = v62 
    #endif
#else
    let v66 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v46 = v66 
    #endif
    let v69 : std_string_String = _run_target_args'_v46 
    (* run_target_args'
    let v82 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v83 : string = "std::path::PathBuf::from($0)"
    let v84 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v69 v83 
    let _run_target_args'_v82 = v84 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v85 : string = "std::path::PathBuf::from($0)"
    let v86 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v69 v85 
    let _run_target_args'_v82 = v86 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v87 : string = "std::path::PathBuf::from($0)"
    let v88 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v69 v87 
    let _run_target_args'_v82 = v88 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v90 : std_path_PathBuf = v69 |> unbox<std_path_PathBuf>
    let _run_target_args'_v82 = v90 
    #endif
#if FABLE_COMPILER_PYTHON
    let v94 : std_path_PathBuf = v69 |> unbox<std_path_PathBuf>
    let _run_target_args'_v82 = v94 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v98 : std_path_PathBuf = v69 |> unbox<std_path_PathBuf>
    let _run_target_args'_v82 = v98 
    #endif
#else
    let v102 : std_path_PathBuf = v69 |> unbox<std_path_PathBuf>
    let _run_target_args'_v82 = v102 
    #endif
    let v105 : std_path_PathBuf = _run_target_args'_v82 
    let v114 : string = "$0.exists()"
    let v115 : bool = Fable.Core.RustInterop.emitRustExpr v105 v114 
    let v116 : bool = v115 = false
    let v312 : string =
        if v116 then
            let v117 : string = method24()
            let v118 : string = method26(v117, v0)
            let v119 : string = method35(v118)
            let v127 : string = "/"
            let v128 : (string []) = v119.Split v127 
            let v131 : (string []) = [||]
            let v132 : int32 = v128.Length
            let v133 : Mut5 = {l0 = 0; l1 = 0; l2 = v131} : Mut5
            while method57(v132, v133) do
                let v135 : int32 = v133.l0
                let v136 : int32 =  -v135
                let v137 : int32 = v136 + v132
                let v138 : int32 = v137 - 1
                let struct (v139 : int32, v140 : (string [])) = v133.l1, v133.l2
                let v141 : string = v128.[int v138]
                let v142 : bool = ".." = v141
                let struct (v188 : int32, v189 : (string [])) =
                    if v142 then
                        let v143 : int32 = v139 + 1
                        struct (v143, v140)
                    else
                        let v144 : bool = "." = v141
                        if v144 then
                            struct (v139, v140)
                        else
                            let v145 : bool = 0 = v139
                            if v145 then
                                let v148 : string = ":"
                                let v149 : bool = v141.EndsWith (v148, false, null)
                                if v149 then
                                    let v152 : string = $"{v117.[0]}:"
                                    let v153 : (string []) = [|v152|]
                                    let v154 : int32 = v153.Length
                                    let v155 : int32 = v140.Length
                                    let v156 : int32 = v154 + v155
                                    let v157 : (string []) = Array.zeroCreate<string> (v156)
                                    let v158 : Mut6 = {l0 = 0} : Mut6
                                    while method58(v156, v158) do
                                        let v160 : int32 = v158.l0
                                        let v161 : bool = v160 < v154
                                        let v165 : string =
                                            if v161 then
                                                let v162 : string = v153.[int v160]
                                                v162
                                            else
                                                let v163 : int32 = v160 - v154
                                                let v164 : string = v140.[int v163]
                                                v164
                                        v157.[int v160] <- v165
                                        let v166 : int32 = v160 + 1
                                        v158.l0 <- v166
                                        ()
                                    struct (0, v157)
                                else
                                    let v167 : (string []) = [|v141|]
                                    let v168 : int32 = v167.Length
                                    let v169 : int32 = v140.Length
                                    let v170 : int32 = v168 + v169
                                    let v171 : (string []) = Array.zeroCreate<string> (v170)
                                    let v172 : Mut6 = {l0 = 0} : Mut6
                                    while method58(v170, v172) do
                                        let v174 : int32 = v172.l0
                                        let v175 : bool = v174 < v168
                                        let v179 : string =
                                            if v175 then
                                                let v176 : string = v167.[int v174]
                                                v176
                                            else
                                                let v177 : int32 = v174 - v168
                                                let v178 : string = v140.[int v177]
                                                v178
                                        v171.[int v174] <- v179
                                        let v180 : int32 = v174 + 1
                                        v172.l0 <- v180
                                        ()
                                    struct (0, v171)
                            else
                                let v183 : int32 = v139 - 1
                                struct (v183, v140)
                let v190 : int32 = v135 + 1
                v133.l0 <- v190
                v133.l1 <- v188
                v133.l2 <- v189
                ()
            let struct (v191 : int32, v192 : (string [])) = v133.l1, v133.l2
            let v197 : unit = ()
            let _let'_v197 =
                seq {
                    for i = 0 to v192.Length - 1 do yield v192.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v200 : string seq = _let'_v197 
            let v206 : char = method59()
            let v208 : (char -> string) = _.ToString()
            let v209 : string = v208 v206
            let v213 : bool = v209 = "\n"
            let v215 : string =
                if v213 then
                    method60(v209)
                else
                    v209
            let v216 : (string -> (string seq -> string)) = String.concat
            let v217 : (string seq -> string) = v216 v215
            v217 v200
        else
            let v221 : string = "std::fs::canonicalize(&*$0)"
            let v222 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v221 
            (* run_target_args'
            let v224 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v225 : string = "$0.unwrap()"
            let v226 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v222 v225 
            let _run_target_args'_v224 = v226 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v227 : string = "$0.unwrap()"
            let v228 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v222 v227 
            let _run_target_args'_v224 = v228 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v229 : string = "$0.unwrap()"
            let v230 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v222 v229 
            let _run_target_args'_v224 = v230 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v231 : std_path_PathBuf = match v222 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v224 = v231 
            #endif
#if FABLE_COMPILER_PYTHON
            let v232 : std_path_PathBuf = match v222 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v224 = v232 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v233 : std_path_PathBuf = match v222 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v224 = v233 
            #endif
#else
            let v234 : std_path_PathBuf = match v222 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v224 = v234 
            #endif
            let v235 : std_path_PathBuf = _run_target_args'_v224 
            (* run_target_args'
            let v242 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v243 : string = "$0.display()"
            let v244 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v235 v243 
            let _run_target_args'_v242 = v244 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v245 : string = "$0.display()"
            let v246 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v235 v245 
            let _run_target_args'_v242 = v246 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v247 : string = "$0.display()"
            let v248 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v235 v247 
            let _run_target_args'_v242 = v248 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v250 : std_path_Display = v235 |> unbox<std_path_Display>
            let _run_target_args'_v242 = v250 
            #endif
#if FABLE_COMPILER_PYTHON
            let v254 : std_path_Display = v235 |> unbox<std_path_Display>
            let _run_target_args'_v242 = v254 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v258 : std_path_Display = v235 |> unbox<std_path_Display>
            let _run_target_args'_v242 = v258 
            #endif
#else
            let v262 : std_path_Display = v235 |> unbox<std_path_Display>
            let _run_target_args'_v242 = v262 
            #endif
            let v265 : std_path_Display = _run_target_args'_v242 
            (* run_target_args'
            let v278 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v279 : string = "format!(\"{}\", $0)"
            let v280 : std_string_String = Fable.Core.RustInterop.emitRustExpr v265 v279 
            let _run_target_args'_v278 = v280 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v281 : string = "format!(\"{}\", $0)"
            let v282 : std_string_String = Fable.Core.RustInterop.emitRustExpr v265 v281 
            let _run_target_args'_v278 = v282 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v283 : string = "format!(\"{}\", $0)"
            let v284 : std_string_String = Fable.Core.RustInterop.emitRustExpr v265 v283 
            let _run_target_args'_v278 = v284 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v286 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v278 = v286 
            #endif
#if FABLE_COMPILER_PYTHON
            let v290 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v278 = v290 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v294 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v278 = v294 
            #endif
#else
            let v298 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v278 = v298 
            #endif
            let v301 : std_string_String = _run_target_args'_v278 
            let v310 : string = "fable_library_rust::String_::fromString($0)"
            let v311 : string = Fable.Core.RustInterop.emitRustExpr v301 v310 
            v311
    let _run_target_args'_v5 = v312 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v314 : string = null |> unbox<string>
    let _run_target_args'_v5 = v314 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v318 : string = null |> unbox<string>
    let _run_target_args'_v5 = v318 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v322 : string = null |> unbox<string>
    let _run_target_args'_v5 = v322 
    #endif
#if FABLE_COMPILER_PYTHON
    let v326 : string = null |> unbox<string>
    let _run_target_args'_v5 = v326 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v330 : string = null |> unbox<string>
    let _run_target_args'_v5 = v330 
    #endif
#else
    let v333 : (string -> string) = System.IO.Path.GetFullPath
    let v334 : string = v333 v0
    let _run_target_args'_v5 = v334 
    #endif
    let v335 : string = _run_target_args'_v5 
    v335
and method61 () : string =
    
    
    
    
    
    let v2 : string = "Debug"
    let v3 : (unit -> string) = v2.ToLower
    let v4 : string = v3 ()
    let v7 : char = v4.[int 0]
    let v8 : string = method13()
    let v9 : Mut3 = {l0 = v8} : Mut3
    let v14 : string = $"{v7}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure8(v9, v14)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v30 : string = v9.l0
    (* run_target_args'
    let v47 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v48 : string = "inline_colorization::color_bright_blue"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48 
    (* run_target_args'
    let v54 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v55 : string = "&*$0"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v55 
    let _run_target_args'_v54 = v56 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v57 : string = "&*$0"
    let v58 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v57 
    let _run_target_args'_v54 = v58 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v59 : string = "&*$0"
    let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v59 
    let _run_target_args'_v54 = v60 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v62 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v62 
    #endif
#if FABLE_COMPILER_PYTHON
    let v66 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v66 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v70 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v70 
    #endif
#else
    let v74 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v74 
    #endif
    let v77 : Ref<Str> = _run_target_args'_v54 
    let v86 : string = "inline_colorization::color_reset"
    let v87 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v86 
    let v88 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v89 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v49, v77, v87) v88 
    let v90 : string = "fable_library_rust::String_::fromString($0)"
    let v91 : string = Fable.Core.RustInterop.emitRustExpr v89 v90 
    let _run_target_args'_v47 = v91 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v92 : string = "inline_colorization::color_bright_blue"
    let v93 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v92 
    (* run_target_args'
    let v98 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v99 : string = "&*$0"
    let v100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v99 
    let _run_target_args'_v98 = v100 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v101 : string = "&*$0"
    let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v101 
    let _run_target_args'_v98 = v102 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v103 : string = "&*$0"
    let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v103 
    let _run_target_args'_v98 = v104 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v106 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v106 
    #endif
#if FABLE_COMPILER_PYTHON
    let v110 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v110 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v114 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v114 
    #endif
#else
    let v118 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v118 
    #endif
    let v121 : Ref<Str> = _run_target_args'_v98 
    let v130 : string = "inline_colorization::color_reset"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v93, v121, v131) v132 
    let v134 : string = "fable_library_rust::String_::fromString($0)"
    let v135 : string = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let _run_target_args'_v47 = v135 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v136 : string = "inline_colorization::color_bright_blue"
    let v137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v136 
    (* run_target_args'
    let v142 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v143 : string = "&*$0"
    let v144 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v143 
    let _run_target_args'_v142 = v144 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v145 : string = "&*$0"
    let v146 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v145 
    let _run_target_args'_v142 = v146 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v147 : string = "&*$0"
    let v148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v147 
    let _run_target_args'_v142 = v148 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v150 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v150 
    #endif
#if FABLE_COMPILER_PYTHON
    let v154 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v154 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v158 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v158 
    #endif
#else
    let v162 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v162 
    #endif
    let v165 : Ref<Str> = _run_target_args'_v142 
    let v174 : string = "inline_colorization::color_reset"
    let v175 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v174 
    let v176 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v177 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v137, v165, v175) v176 
    let v178 : string = "fable_library_rust::String_::fromString($0)"
    let v179 : string = Fable.Core.RustInterop.emitRustExpr v177 v178 
    let _run_target_args'_v47 = v179 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v181 : string = "\u001b[94m"
    let v185 : string = method14()
    let v189 : string = v181 + v30 
    let v193 : string = v189 + v185 
    let _run_target_args'_v47 = v193 
    #endif
#if FABLE_COMPILER_PYTHON
    let v197 : string = "\u001b[94m"
    let v201 : string = method14()
    let v205 : string = v197 + v30 
    let v209 : string = v205 + v201 
    let _run_target_args'_v47 = v209 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v213 : string = "\u001b[94m"
    let v217 : string = method14()
    let v221 : string = v213 + v30 
    let v225 : string = v221 + v217 
    let _run_target_args'_v47 = v225 
    #endif
#else
    let v229 : string = "\u001b[94m"
    let v233 : string = method14()
    let v237 : string = v229 + v30 
    let v241 : string = v237 + v233 
    let _run_target_args'_v47 = v241 
    #endif
    let v244 : string = _run_target_args'_v47 
    v244
and method62 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : string) : string =
    let v12 : string = method13()
    let v13 : Mut3 = {l0 = v12} : Mut3
    let v16 : string = "{ "
    let v17 : string = $"{v16}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure8(v13, v17)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v35 : string = "source_dir"
    let v36 : string = $"{v35}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure8(v13, v36)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v54 : string = " = "
    let v55 : string = $"{v54}"
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure8(v13, v55)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v72 : string = $"{v8}"
    let v80 : unit = ()
    let v81 : (unit -> unit) = closure8(v13, v72)
    let v82 : unit = (fun () -> v81 (); v80) ()
    let v90 : string = "; "
    let v91 : string = $"{v90}"
    let v99 : unit = ()
    let v100 : (unit -> unit) = closure8(v13, v91)
    let v101 : unit = (fun () -> v100 (); v99) ()
    let v109 : string = "dist_dir"
    let v110 : string = $"{v109}"
    let v118 : unit = ()
    let v119 : (unit -> unit) = closure8(v13, v110)
    let v120 : unit = (fun () -> v119 (); v118) ()
    let v127 : string = $"{v54}"
    let v135 : unit = ()
    let v136 : (unit -> unit) = closure8(v13, v127)
    let v137 : unit = (fun () -> v136 (); v135) ()
    let v144 : string = $"{v9}"
    let v152 : unit = ()
    let v153 : (unit -> unit) = closure8(v13, v144)
    let v154 : unit = (fun () -> v153 (); v152) ()
    let v161 : string = $"{v90}"
    let v169 : unit = ()
    let v170 : (unit -> unit) = closure8(v13, v161)
    let v171 : unit = (fun () -> v170 (); v169) ()
    let v179 : string = "cache_dir"
    let v180 : string = $"{v179}"
    let v188 : unit = ()
    let v189 : (unit -> unit) = closure8(v13, v180)
    let v190 : unit = (fun () -> v189 (); v188) ()
    let v197 : string = $"{v54}"
    let v205 : unit = ()
    let v206 : (unit -> unit) = closure8(v13, v197)
    let v207 : unit = (fun () -> v206 (); v205) ()
    let v214 : string = $"{v10}"
    let v222 : unit = ()
    let v223 : (unit -> unit) = closure8(v13, v214)
    let v224 : unit = (fun () -> v223 (); v222) ()
    let v231 : string = $"{v90}"
    let v239 : unit = ()
    let v240 : (unit -> unit) = closure8(v13, v231)
    let v241 : unit = (fun () -> v240 (); v239) ()
    let v249 : string = "hangul_spec"
    let v250 : string = $"{v249}"
    let v258 : unit = ()
    let v259 : (unit -> unit) = closure8(v13, v250)
    let v260 : unit = (fun () -> v259 (); v258) ()
    let v267 : string = $"{v54}"
    let v275 : unit = ()
    let v276 : (unit -> unit) = closure8(v13, v267)
    let v277 : unit = (fun () -> v276 (); v275) ()
    let v284 : string = $"{v11}"
    let v292 : unit = ()
    let v293 : (unit -> unit) = closure8(v13, v284)
    let v294 : unit = (fun () -> v293 (); v292) ()
    let v302 : string = " }"
    let v303 : string = $"{v302}"
    let v311 : unit = ()
    let v312 : (unit -> unit) = closure8(v13, v303)
    let v313 : unit = (fun () -> v312 (); v311) ()
    let v319 : string = v13.l0
    let v320 : int64 = v0.l0
    let v323 : string = " "
    let v324 : string = v6 + v323 
    let v328 : string = v324 + v7 
    let v333 : string = " #"
    let v334 : string = v328 + v333 
    let v338 : (int64 -> string) = _.ToString()
    let v339 : string = v338 v320
    let v343 : string = v334 + v339 
    let v347 : string = v343 + v323 
    let v352 : string = "documents.run"
    let v353 : string = v347 + v352 
    let v358 : string = " / "
    let v359 : string = v353 + v358 
    let v363 : string = v359 + v319 
    method16(v363)
and closure24 (v0 : string, v1 : string, v2 : string, v3 : string) () : unit =
    let v4 : US0 = US0_1
    let v5 : bool = method7(v4)
    if v5 then
        let v20 : unit = ()
        let v21 : (unit -> unit) = closure6()
        let v22 : unit = (fun () -> v21 (); v20) ()
        let struct (v43 : Mut0, v44 : Mut1, v45 : Mut2, v46 : Mut3, v47 : Mut4, v48 : int64 option) = TraceState.trace_state.Value
        let v61 : string = method8(v43, v44, v45, v46, v47, v48)
        let v62 : string = method61()
        let v63 : string = method62(v43, v44, v45, v46, v47, v48, v61, v62, v1, v2, v3, v0)
        method17(v63)
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
and method63 () : (std_io_Error -> std_string_String) =
    closure26()
and closure27 () (v0 : std_fs_FileType) : US11 =
    US11_0(v0)
and method64 () : (std_fs_FileType -> US11) =
    closure27()
and closure28 () (v0 : std_string_String) : US11 =
    US11_1(v0)
and method65 () : (std_string_String -> US11) =
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
    let v19 : (std_io_Error -> std_string_String) = method63()
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
    let v35 : (std_fs_FileType -> US11) = method64()
    let v36 : (std_string_String -> US11) = method65()
    let v38 : US11 = match v32 with Ok x -> v35 x | Error x -> v36 x
    let v232 : US12 =
        match v38 with
        | US11_0(v41) -> (* Ok *)
            let v42 : string = "std::fs::FileType::is_dir(&$0)"
            let v43 : bool = Fable.Core.RustInterop.emitRustExpr v41 v42 
            if v43 then
                US12_0
            else
                let v45 : string = "async_walkdir::DirEntry::path(&$0)"
                let v46 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v0 v45 
                (* run_target_args'
                let v51 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v52 : string = "$0.display()"
                let v53 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v46 v52 
                let _run_target_args'_v51 = v53 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v54 : string = "$0.display()"
                let v55 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v46 v54 
                let _run_target_args'_v51 = v55 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v56 : string = "$0.display()"
                let v57 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v46 v56 
                let _run_target_args'_v51 = v57 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v59 : std_path_Display = v46 |> unbox<std_path_Display>
                let _run_target_args'_v51 = v59 
                #endif
#if FABLE_COMPILER_PYTHON
                let v63 : std_path_Display = v46 |> unbox<std_path_Display>
                let _run_target_args'_v51 = v63 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v67 : std_path_Display = v46 |> unbox<std_path_Display>
                let _run_target_args'_v51 = v67 
                #endif
#else
                let v71 : std_path_Display = v46 |> unbox<std_path_Display>
                let _run_target_args'_v51 = v71 
                #endif
                let v74 : std_path_Display = _run_target_args'_v51 
                (* run_target_args'
                let v87 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v88 : string = "format!(\"{}\", $0)"
                let v89 : std_string_String = Fable.Core.RustInterop.emitRustExpr v74 v88 
                let _run_target_args'_v87 = v89 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v90 : string = "format!(\"{}\", $0)"
                let v91 : std_string_String = Fable.Core.RustInterop.emitRustExpr v74 v90 
                let _run_target_args'_v87 = v91 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v92 : string = "format!(\"{}\", $0)"
                let v93 : std_string_String = Fable.Core.RustInterop.emitRustExpr v74 v92 
                let _run_target_args'_v87 = v93 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v95 : std_string_String = null |> unbox<std_string_String>
                let _run_target_args'_v87 = v95 
                #endif
#if FABLE_COMPILER_PYTHON
                let v99 : std_string_String = null |> unbox<std_string_String>
                let _run_target_args'_v87 = v99 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v103 : std_string_String = null |> unbox<std_string_String>
                let _run_target_args'_v87 = v103 
                #endif
#else
                let v107 : std_string_String = null |> unbox<std_string_String>
                let _run_target_args'_v87 = v107 
                #endif
                let v110 : std_string_String = _run_target_args'_v87 
                let v119 : string = "fable_library_rust::String_::fromString($0)"
                let v120 : string = Fable.Core.RustInterop.emitRustExpr v110 v119 
                let v123 : string = ".md"
                let v124 : bool = v120.EndsWith (v123, false, null)
                let v127 : bool = v124 = false
                let v134 : bool =
                    if v127 then
                        true
                    else
                        let v130 : string = ".hangul.md"
                        let v131 : bool = v120.EndsWith (v130, false, null)
                        v131
                if v134 then
                    US12_0
                else
                    US12_2
        | _ ->
            let v139 : string = "async_walkdir::DirEntry::path(&$0)"
            let v140 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v0 v139 
            (* run_target_args'
            let v145 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v146 : string = "$0.display()"
            let v147 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v140 v146 
            let _run_target_args'_v145 = v147 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v148 : string = "$0.display()"
            let v149 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v140 v148 
            let _run_target_args'_v145 = v149 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v150 : string = "$0.display()"
            let v151 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v140 v150 
            let _run_target_args'_v145 = v151 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v153 : std_path_Display = v140 |> unbox<std_path_Display>
            let _run_target_args'_v145 = v153 
            #endif
#if FABLE_COMPILER_PYTHON
            let v157 : std_path_Display = v140 |> unbox<std_path_Display>
            let _run_target_args'_v145 = v157 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v161 : std_path_Display = v140 |> unbox<std_path_Display>
            let _run_target_args'_v145 = v161 
            #endif
#else
            let v165 : std_path_Display = v140 |> unbox<std_path_Display>
            let _run_target_args'_v145 = v165 
            #endif
            let v168 : std_path_Display = _run_target_args'_v145 
            (* run_target_args'
            let v181 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v182 : string = "format!(\"{}\", $0)"
            let v183 : std_string_String = Fable.Core.RustInterop.emitRustExpr v168 v182 
            let _run_target_args'_v181 = v183 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v184 : string = "format!(\"{}\", $0)"
            let v185 : std_string_String = Fable.Core.RustInterop.emitRustExpr v168 v184 
            let _run_target_args'_v181 = v185 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v186 : string = "format!(\"{}\", $0)"
            let v187 : std_string_String = Fable.Core.RustInterop.emitRustExpr v168 v186 
            let _run_target_args'_v181 = v187 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v189 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v181 = v189 
            #endif
#if FABLE_COMPILER_PYTHON
            let v193 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v181 = v193 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v197 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v181 = v197 
            #endif
#else
            let v201 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v181 = v201 
            #endif
            let v204 : std_string_String = _run_target_args'_v181 
            let v213 : string = "fable_library_rust::String_::fromString($0)"
            let v214 : string = Fable.Core.RustInterop.emitRustExpr v204 v213 
            let v217 : string = ".md"
            let v218 : bool = v214.EndsWith (v217, false, null)
            let v221 : bool = v218 = false
            let v228 : bool =
                if v221 then
                    true
                else
                    let v224 : string = ".hangul.md"
                    let v225 : bool = v214.EndsWith (v224, false, null)
                    v225
            if v228 then
                US12_0
            else
                US12_2
    let v233 : string = ""
    let v234 : string = "}"
    let v235 : string = v233 + v234 
    let x = v232 //
    let v236 : _ = x
    let v237 : unit = ()
    (* run_target_args'
    let v238 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v239 : string = $"true; let _fix_closure_v237 = $0"
    let v240 : bool = Fable.Core.RustInterop.emitRustExpr v236 v239 
    let _run_target_args'_v238 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v241 : string = $"true; let _fix_closure_v237 = $0"
    let v242 : bool = Fable.Core.RustInterop.emitRustExpr v236 v241 
    let _run_target_args'_v238 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v243 : string = $"true; let _fix_closure_v237 = $0"
    let v244 : bool = Fable.Core.RustInterop.emitRustExpr v236 v243 
    let _run_target_args'_v238 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v238 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v238 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v238 = false 
    #endif
#else
    let _run_target_args'_v238 = false 
    #endif
    let v245 : bool = _run_target_args'_v238 
    let v246 : string = $"true; _fix_closure_v237 " + v235 + "); " + v233 + " // rust.fix_closure'"
    let v247 : bool = Fable.Core.RustInterop.emitRustExpr () v246 
    let v248 : string = "__future_init"
    let v249 : _ = Fable.Core.RustInterop.emitRustExpr () v248 
    let v250 : string = "v249"
    let v251 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US12>>, Send<Dyn<std_future_Future<US12>>>>>> = Fable.Core.RustInterop.emitRustExpr () v250 
    let v252 : string = "v251.await"
    let v253 : US12 = Fable.Core.RustInterop.emitRustExpr () v252 
    let v262 : async_walkdir_Filtering =
        match v253 with
        | US12_2 -> (* Continue *)
            let v258 : string = "async_walkdir::Filtering::Continue"
            let v259 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v258 
            v259
        | US12_0 -> (* Ignore *)
            let v254 : string = "async_walkdir::Filtering::Ignore"
            let v255 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v254 
            v255
        | US12_1 -> (* IgnoreDir *)
            let v256 : string = "async_walkdir::Filtering::IgnoreDir"
            let v257 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v256 
            v257
    let v263 : string = v233 + v234 
    let x = v262 //
    let v264 : _ = x
    let v265 : unit = ()
    (* run_target_args'
    let v266 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v267 : string = $"true; let _fix_closure_v265 = $0"
    let v268 : bool = Fable.Core.RustInterop.emitRustExpr v264 v267 
    let _run_target_args'_v266 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v269 : string = $"true; let _fix_closure_v265 = $0"
    let v270 : bool = Fable.Core.RustInterop.emitRustExpr v264 v269 
    let _run_target_args'_v266 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v271 : string = $"true; let _fix_closure_v265 = $0"
    let v272 : bool = Fable.Core.RustInterop.emitRustExpr v264 v271 
    let _run_target_args'_v266 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v266 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v266 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v266 = false 
    #endif
#else
    let _run_target_args'_v266 = false 
    #endif
    let v273 : bool = _run_target_args'_v266 
    let v274 : string = $"true; _fix_closure_v265 " + v263 + "); " + v233 + " // rust.fix_closure'"
    let v275 : bool = Fable.Core.RustInterop.emitRustExpr () v274 
    let v276 : string = "__future_init"
    let v277 : _ = Fable.Core.RustInterop.emitRustExpr () v276 
    let v278 : string = "v277"
    let v279 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> = Fable.Core.RustInterop.emitRustExpr () v278 
    v279
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
and method67 () : (async_walkdir_Error -> std_string_String) =
    closure30()
and closure31 () (v0 : async_walkdir_DirEntry) : US13 =
    US13_0(v0)
and method68 () : (async_walkdir_DirEntry -> US13) =
    closure31()
and closure32 () (v0 : std_string_String) : US13 =
    US13_1(v0)
and method69 () : (std_string_String -> US13) =
    closure32()
and method70 () : string =
    
    
    
    
    
    let v2 : string = "Critical"
    let v3 : (unit -> string) = v2.ToLower
    let v4 : string = v3 ()
    let v7 : char = v4.[int 0]
    let v8 : string = method13()
    let v9 : Mut3 = {l0 = v8} : Mut3
    let v14 : string = $"{v7}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure8(v9, v14)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v30 : string = v9.l0
    (* run_target_args'
    let v47 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v48 : string = "inline_colorization::color_bright_red"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48 
    (* run_target_args'
    let v54 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v55 : string = "&*$0"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v55 
    let _run_target_args'_v54 = v56 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v57 : string = "&*$0"
    let v58 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v57 
    let _run_target_args'_v54 = v58 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v59 : string = "&*$0"
    let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v59 
    let _run_target_args'_v54 = v60 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v62 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v62 
    #endif
#if FABLE_COMPILER_PYTHON
    let v66 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v66 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v70 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v70 
    #endif
#else
    let v74 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v74 
    #endif
    let v77 : Ref<Str> = _run_target_args'_v54 
    let v86 : string = "inline_colorization::color_reset"
    let v87 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v86 
    let v88 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v89 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v49, v77, v87) v88 
    let v90 : string = "fable_library_rust::String_::fromString($0)"
    let v91 : string = Fable.Core.RustInterop.emitRustExpr v89 v90 
    let _run_target_args'_v47 = v91 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v92 : string = "inline_colorization::color_bright_red"
    let v93 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v92 
    (* run_target_args'
    let v98 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v99 : string = "&*$0"
    let v100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v99 
    let _run_target_args'_v98 = v100 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v101 : string = "&*$0"
    let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v101 
    let _run_target_args'_v98 = v102 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v103 : string = "&*$0"
    let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v103 
    let _run_target_args'_v98 = v104 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v106 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v106 
    #endif
#if FABLE_COMPILER_PYTHON
    let v110 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v110 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v114 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v114 
    #endif
#else
    let v118 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v118 
    #endif
    let v121 : Ref<Str> = _run_target_args'_v98 
    let v130 : string = "inline_colorization::color_reset"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v93, v121, v131) v132 
    let v134 : string = "fable_library_rust::String_::fromString($0)"
    let v135 : string = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let _run_target_args'_v47 = v135 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v136 : string = "inline_colorization::color_bright_red"
    let v137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v136 
    (* run_target_args'
    let v142 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v143 : string = "&*$0"
    let v144 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v143 
    let _run_target_args'_v142 = v144 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v145 : string = "&*$0"
    let v146 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v145 
    let _run_target_args'_v142 = v146 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v147 : string = "&*$0"
    let v148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v147 
    let _run_target_args'_v142 = v148 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v150 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v150 
    #endif
#if FABLE_COMPILER_PYTHON
    let v154 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v154 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v158 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v158 
    #endif
#else
    let v162 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v162 
    #endif
    let v165 : Ref<Str> = _run_target_args'_v142 
    let v174 : string = "inline_colorization::color_reset"
    let v175 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v174 
    let v176 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v177 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v137, v165, v175) v176 
    let v178 : string = "fable_library_rust::String_::fromString($0)"
    let v179 : string = Fable.Core.RustInterop.emitRustExpr v177 v178 
    let _run_target_args'_v47 = v179 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v181 : string = "\u001b[91m"
    let v185 : string = method14()
    let v189 : string = v181 + v30 
    let v193 : string = v189 + v185 
    let _run_target_args'_v47 = v193 
    #endif
#if FABLE_COMPILER_PYTHON
    let v197 : string = "\u001b[91m"
    let v201 : string = method14()
    let v205 : string = v197 + v30 
    let v209 : string = v205 + v201 
    let _run_target_args'_v47 = v209 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v213 : string = "\u001b[91m"
    let v217 : string = method14()
    let v221 : string = v213 + v30 
    let v225 : string = v221 + v217 
    let _run_target_args'_v47 = v225 
    #endif
#else
    let v229 : string = "\u001b[91m"
    let v233 : string = method14()
    let v237 : string = v229 + v30 
    let v241 : string = v237 + v233 
    let _run_target_args'_v47 = v241 
    #endif
    let v244 : string = _run_target_args'_v47 
    v244
and method71 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method13()
    let v10 : Mut3 = {l0 = v9} : Mut3
    let v13 : string = "{ "
    let v14 : string = $"{v13}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure8(v10, v14)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v32 : string = "error"
    let v33 : string = $"{v32}"
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure8(v10, v33)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v51 : string = " = "
    let v52 : string = $"{v51}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure8(v10, v52)
    let v62 : unit = (fun () -> v61 (); v60) ()
    (* run_target_args'
    let v72 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v73 : string = "format!(\"{:#?}\", $0)"
    let v74 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v73 
    let v75 : string = "fable_library_rust::String_::fromString($0)"
    let v76 : string = Fable.Core.RustInterop.emitRustExpr v74 v75 
    let _run_target_args'_v72 = v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : string = "format!(\"{:#?}\", $0)"
    let v78 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v77 
    let v79 : string = "fable_library_rust::String_::fromString($0)"
    let v80 : string = Fable.Core.RustInterop.emitRustExpr v78 v79 
    let _run_target_args'_v72 = v80 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : string = "format!(\"{:#?}\", $0)"
    let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v81 
    let v83 : string = "fable_library_rust::String_::fromString($0)"
    let v84 : string = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let _run_target_args'_v72 = v84 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v86 : string = $"%A{v8}"
    let _run_target_args'_v72 = v86 
    #endif
#if FABLE_COMPILER_PYTHON
    let v90 : string = $"%A{v8}"
    let _run_target_args'_v72 = v90 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v94 : string = $"%A{v8}"
    let _run_target_args'_v72 = v94 
    #endif
#else
    let v98 : string = $"%A{v8}"
    let _run_target_args'_v72 = v98 
    #endif
    let v101 : string = _run_target_args'_v72 
    let v111 : string = $"{v101}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure8(v10, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v129 : string = " }"
    let v130 : string = $"{v129}"
    let v138 : unit = ()
    let v139 : (unit -> unit) = closure8(v10, v130)
    let v140 : unit = (fun () -> v139 (); v138) ()
    let v146 : string = v10.l0
    let v147 : int64 = v0.l0
    let v150 : string = " "
    let v151 : string = v6 + v150 
    let v155 : string = v151 + v7 
    let v160 : string = " #"
    let v161 : string = v155 + v160 
    let v165 : (int64 -> string) = _.ToString()
    let v166 : string = v165 v147
    let v170 : string = v161 + v166 
    let v174 : string = v170 + v150 
    let v179 : string = "documents.run / stream_filter_map"
    let v180 : string = v174 + v179 
    let v185 : string = " / "
    let v186 : string = v180 + v185 
    let v190 : string = v186 + v146 
    method16(v190)
and closure33 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_4
    let v2 : bool = method7(v1)
    if v2 then
        let v17 : unit = ()
        let v18 : (unit -> unit) = closure6()
        let v19 : unit = (fun () -> v18 (); v17) ()
        let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
        let v58 : string = method8(v40, v41, v42, v43, v44, v45)
        let v59 : string = method70()
        let v60 : string = method71(v40, v41, v42, v43, v44, v45, v58, v59, v0)
        method17(v60)
and closure29 () (v0 : Result<async_walkdir_DirEntry, async_walkdir_Error>) : string option =
    let v1 : (async_walkdir_Error -> std_string_String) = method67()
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
    let v17 : (async_walkdir_DirEntry -> US13) = method68()
    let v18 : (std_string_String -> US13) = method69()
    let v20 : US13 = match v14 with Ok x -> v17 x | Error x -> v18 x
    let v227 : US5 =
        match v20 with
        | US13_1(v101) -> (* Error *)
            let v162 : unit = ()
            let v163 : (unit -> unit) = closure33(v101)
            let v164 : unit = (fun () -> v163 (); v162) ()
            US5_1
        | US13_0(v23) -> (* Ok *)
            let v24 : string = "async_walkdir::DirEntry::path(&$0)"
            let v25 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v23 v24 
            (* run_target_args'
            let v30 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v31 : string = "$0.display()"
            let v32 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v25 v31 
            let _run_target_args'_v30 = v32 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v33 : string = "$0.display()"
            let v34 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v25 v33 
            let _run_target_args'_v30 = v34 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v35 : string = "$0.display()"
            let v36 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v25 v35 
            let _run_target_args'_v30 = v36 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v38 : std_path_Display = v25 |> unbox<std_path_Display>
            let _run_target_args'_v30 = v38 
            #endif
#if FABLE_COMPILER_PYTHON
            let v42 : std_path_Display = v25 |> unbox<std_path_Display>
            let _run_target_args'_v30 = v42 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v46 : std_path_Display = v25 |> unbox<std_path_Display>
            let _run_target_args'_v30 = v46 
            #endif
#else
            let v50 : std_path_Display = v25 |> unbox<std_path_Display>
            let _run_target_args'_v30 = v50 
            #endif
            let v53 : std_path_Display = _run_target_args'_v30 
            (* run_target_args'
            let v66 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v67 : string = "format!(\"{}\", $0)"
            let v68 : std_string_String = Fable.Core.RustInterop.emitRustExpr v53 v67 
            let _run_target_args'_v66 = v68 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v69 : string = "format!(\"{}\", $0)"
            let v70 : std_string_String = Fable.Core.RustInterop.emitRustExpr v53 v69 
            let _run_target_args'_v66 = v70 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v71 : string = "format!(\"{}\", $0)"
            let v72 : std_string_String = Fable.Core.RustInterop.emitRustExpr v53 v71 
            let _run_target_args'_v66 = v72 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v74 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v66 = v74 
            #endif
#if FABLE_COMPILER_PYTHON
            let v78 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v66 = v78 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v82 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v66 = v82 
            #endif
#else
            let v86 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v66 = v86 
            #endif
            let v89 : std_string_String = _run_target_args'_v66 
            let v98 : string = "fable_library_rust::String_::fromString($0)"
            let v99 : string = Fable.Core.RustInterop.emitRustExpr v89 v98 
            US5_0(v99)
    match v227 with
    | US5_1 -> (* None *)
        let v234 : string option = None
        v234
    | US5_0(v228) -> (* Some *)
        let v230 : string option = Some v228 
        v230
and method66 () : (Result<async_walkdir_DirEntry, async_walkdir_Error> -> string option) =
    closure29()
and method72 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : unativeint) : string =
    let v9 : string = method13()
    let v10 : Mut3 = {l0 = v9} : Mut3
    let v13 : string = "{ "
    let v14 : string = $"{v13}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure8(v10, v14)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v32 : string = "files_len"
    let v33 : string = $"{v32}"
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure8(v10, v33)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v51 : string = " = "
    let v52 : string = $"{v51}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure8(v10, v52)
    let v62 : unit = (fun () -> v61 (); v60) ()
    (* run_target_args'
    let v72 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v73 : string = "format!(\"{:#?}\", $0)"
    let v74 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v73 
    let v75 : string = "fable_library_rust::String_::fromString($0)"
    let v76 : string = Fable.Core.RustInterop.emitRustExpr v74 v75 
    let _run_target_args'_v72 = v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : string = "format!(\"{:#?}\", $0)"
    let v78 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v77 
    let v79 : string = "fable_library_rust::String_::fromString($0)"
    let v80 : string = Fable.Core.RustInterop.emitRustExpr v78 v79 
    let _run_target_args'_v72 = v80 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : string = "format!(\"{:#?}\", $0)"
    let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v81 
    let v83 : string = "fable_library_rust::String_::fromString($0)"
    let v84 : string = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let _run_target_args'_v72 = v84 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v86 : string = $"%A{v8}"
    let _run_target_args'_v72 = v86 
    #endif
#if FABLE_COMPILER_PYTHON
    let v90 : string = $"%A{v8}"
    let _run_target_args'_v72 = v90 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v94 : string = $"%A{v8}"
    let _run_target_args'_v72 = v94 
    #endif
#else
    let v98 : string = $"%A{v8}"
    let _run_target_args'_v72 = v98 
    #endif
    let v101 : string = _run_target_args'_v72 
    let v111 : string = $"{v101}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure8(v10, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v129 : string = " }"
    let v130 : string = $"{v129}"
    let v138 : unit = ()
    let v139 : (unit -> unit) = closure8(v10, v130)
    let v140 : unit = (fun () -> v139 (); v138) ()
    let v146 : string = v10.l0
    let v147 : int64 = v0.l0
    let v150 : string = " "
    let v151 : string = v6 + v150 
    let v155 : string = v151 + v7 
    let v160 : string = " #"
    let v161 : string = v155 + v160 
    let v165 : (int64 -> string) = _.ToString()
    let v166 : string = v165 v147
    let v170 : string = v161 + v166 
    let v174 : string = v170 + v150 
    let v179 : string = "documents.run"
    let v180 : string = v174 + v179 
    let v185 : string = " / "
    let v186 : string = v180 + v185 
    let v190 : string = v186 + v146 
    method16(v190)
and closure34 (v0 : Vec<string>) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method7(v1)
    if v2 then
        let v17 : unit = ()
        let v18 : (unit -> unit) = closure6()
        let v19 : unit = (fun () -> v18 (); v17) ()
        let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
        let v58 : string = method8(v40, v41, v42, v43, v44, v45)
        let v59 : string = method61()
        let v60 : string = "$0.len()"
        let v61 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v60 
        let v62 : string = method72(v40, v41, v42, v43, v44, v45, v58, v59, v61)
        method17(v62)
and method73 () : string =
    let v0 : string = ""
    v0
and method74 (v0 : string) : string =
    let v1 : string = method56(v0)
    method35(v1)
and method76 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : string =
    v0
and method78 () : string =
    let v0 : string = ""
    v0
and method79 (v0 : int64, v1 : string, v2 : int64) : UH0 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : char = v1.[int v2]
        let v5 : int64 = v2 + 1L
        let v6 : UH0 = method79(v0, v1, v5)
        UH0_1(v4, v6)
    else
        UH0_0
and method80 (v0 : UH0, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : struct (System.Text.StringBuilder * int32 * int32) =
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
        method80(v5, v27, v9, v10)
    | UH0_0 -> (* Nil *)
        struct (v1, v2, v3)
and closure37 (v0 : int32, v1 : int32) (v2 : string) : string =
    let v3 : bool = v1 >= v0
    if v3 then
        v2
    else
        let v4 : int32 = v1 + 1
        let v5 : (string -> string) = method81(v0, v4)
        let v8 : string = " "
        let v9 : string = v2 + v8 
        v5 v9
and method81 (v0 : int32, v1 : int32) : (string -> string) =
    closure37(v0, v1)
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
            let v54 : int64 = System.Convert.ToInt64 v51.Length
            let v55 : int64 = 0L
            let v56 : UH0 = method79(v54, v51, v55)
            let struct (v57 : System.Text.StringBuilder, v58 : int32, v59 : int32) = method80(v56, v1, v2, v3)
            US15_0(v10, v45, v57, v58, v59)
        else
            let v62 : string = "\n"
            let v63 : int32 = v0.IndexOf v62 
            let v66 : int32 = v63 - 1
            let v67 : bool = -2 = v66
            let v75 : int32 =
                if v67 then
                    let v69 : (string -> int32) = String.length
                    let v70 : int32 = v69 v0
                    let v73 : int32 = v70 + 1
                    v73
                else
                    let v74 : int32 = v66 + 1
                    v74
            let v81 : int32 = 0 |> int32 
            let v94 : int32 = v75 |> int32 
            let v102 : int32 = v94 - 1
            let v104 : string = v0.[int v81..int v102]
            let v109 : string = $"parsing.p_char / expected: '{'"'}' / line: {v2} / col: {v3}
{v1}{v104}"
            let v112 : int32 = v3 - 1
            let v113 : int32 = 0
            let v114 : (string -> string) = method81(v112, v113)
            let v115 : string = ""
            let v116 : string = v114 v115
            let v117 : string = "^"
            let v118 : string = v116 + v117 
            let v120 : string = $"{v109}
{v118}
"
            US15_1(v120)
and closure38 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US15 =
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
            let v54 : int64 = System.Convert.ToInt64 v51.Length
            let v55 : int64 = 0L
            let v56 : UH0 = method79(v54, v51, v55)
            let struct (v57 : System.Text.StringBuilder, v58 : int32, v59 : int32) = method80(v56, v1, v2, v3)
            US15_0(v10, v45, v57, v58, v59)
        else
            let v62 : string = "\n"
            let v63 : int32 = v0.IndexOf v62 
            let v66 : int32 = v63 - 1
            let v67 : bool = -2 = v66
            let v75 : int32 =
                if v67 then
                    let v69 : (string -> int32) = String.length
                    let v70 : int32 = v69 v0
                    let v73 : int32 = v70 + 1
                    v73
                else
                    let v74 : int32 = v66 + 1
                    v74
            let v81 : int32 = 0 |> int32 
            let v94 : int32 = v75 |> int32 
            let v102 : int32 = v94 - 1
            let v104 : string = v0.[int v81..int v102]
            let v109 : string = $"parsing.p_char / expected: '{'''}' / line: {v2} / col: {v3}
{v1}{v104}"
            let v112 : int32 = v3 - 1
            let v113 : int32 = 0
            let v114 : (string -> string) = method81(v112, v113)
            let v115 : string = ""
            let v116 : string = v114 v115
            let v117 : string = "^"
            let v118 : string = v116 + v117 
            let v120 : string = $"{v109}
{v118}
"
            US15_1(v120)
and method82 (v0 : string, v1 : System.Text.StringBuilder, v2 : UH1) : US15 =
    match v2 with
    | UH1_1(v5, v6) -> (* Cons *)
        let v7 : US15 = v5 struct (v0, v1, 1, 1)
        match v7 with
        | US15_1(v13) -> (* Error *)
            method82(v0, v1, v6)
        | US15_0(v8, v9, v10, v11, v12) -> (* Ok *)
            v7
    | UH1_0 -> (* Nil *)
        let v3 : string = "parsing.choice / no parsers succeeded"
        US15_1(v3)
and method83 (v0 : char, v1 : int64) : bool =
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
            method83(v0, v17)
and method84 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
    let v5 : bool = "" = v1
    let v98 : US15 =
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
            let v27 : bool = method83(v25, v26)
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
                let v71 : int64 = System.Convert.ToInt64 v68.Length
                let v72 : int64 = 0L
                let v73 : UH0 = method79(v71, v68, v72)
                let struct (v74 : System.Text.StringBuilder, v75 : int32, v76 : int32) = method80(v73, v2, v3, v4)
                US15_0(v25, v62, v74, v75, v76)
            else
                let v78 : char list = []
                let v80 : char list = ''' :: v78 
                let v84 : char list = '"' :: v80 
                let v88 : (char list -> (char [])) = List.toArray
                let v89 : (char []) = v88 v84
                let v93 : string = $"parsing.none_of / unexpected char: '{v25}' / chars: %A{v89} / s: %A{struct (v2, v3, v4)}"
                US15_1(v93)
    let v110 : US15 =
        match v98 with
        | US15_1(v107) -> (* Error *)
            US15_1(v107)
        | US15_0(v99, v100, v101, v102, v103) -> (* Ok *)
            let v104 : bool = '\\' = v99
            let v105 : char =
                if v104 then
                    '/'
                else
                    v99
            US15_0(v105, v100, v101, v102, v103)
    match v110 with
    | US15_1(v127) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US15_0(v111, v112, v113, v114, v115) -> (* Ok *)
        let v117 : (char -> string) = _.ToString()
        let v118 : string = v117 v111
        let v121 : string = v0 + v118 
        method84(v121, v112, v113, v114, v115)
and method85 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH1) : US15 =
    match v4 with
    | UH1_1(v7, v8) -> (* Cons *)
        let v9 : US15 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US15_1(v15) -> (* Error *)
            method85(v0, v1, v2, v3, v8)
        | US15_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH1_0 -> (* Nil *)
        let v5 : string = "parsing.choice / no parsers succeeded"
        US15_1(v5)
and method86 (v0 : char, v1 : int64) : bool =
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
            method86(v0, v21)
and method87 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
    let v5 : bool = "" = v1
    let v106 : US15 =
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
            let v31 : bool = method86(v29, v30)
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
                let v75 : int64 = System.Convert.ToInt64 v72.Length
                let v76 : int64 = 0L
                let v77 : UH0 = method79(v75, v72, v76)
                let struct (v78 : System.Text.StringBuilder, v79 : int32, v80 : int32) = method80(v77, v2, v3, v4)
                US15_0(v29, v66, v78, v79, v80)
            else
                let v82 : char list = []
                let v84 : char list = ' ' :: v82 
                let v88 : char list = ''' :: v84 
                let v92 : char list = '"' :: v88 
                let v96 : (char list -> (char [])) = List.toArray
                let v97 : (char []) = v96 v92
                let v101 : string = $"parsing.none_of / unexpected char: '{v29}' / chars: %A{v97} / s: %A{struct (v2, v3, v4)}"
                US15_1(v101)
    let v118 : US15 =
        match v106 with
        | US15_1(v115) -> (* Error *)
            US15_1(v115)
        | US15_0(v107, v108, v109, v110, v111) -> (* Ok *)
            let v112 : bool = '\\' = v107
            let v113 : char =
                if v112 then
                    '/'
                else
                    v107
            US15_0(v113, v108, v109, v110, v111)
    match v118 with
    | US15_1(v135) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US15_0(v119, v120, v121, v122, v123) -> (* Ok *)
        let v125 : (char -> string) = _.ToString()
        let v126 : string = v125 v119
        let v129 : string = v0 + v126 
        method87(v129, v120, v121, v122, v123)
and method88 (v0 : string, v1 : int32) : int32 =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 >= v2
    if v3 then
        v1
    else
        let v4 : char = v0.[int v1]
        let v5 : bool = ' ' = v4
        if v5 then
            let v6 : int32 = v1 + 1
            method88(v0, v6)
        else
            v1
and method89 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
    let v5 : bool = "" = v1
    let v66 : US15 =
        if v5 then
            let v12 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v2, v3, v4)}"
            US15_1(v12)
        else
            let v16 : char = v1.[int 0]
            let v18 : (string -> int32) = String.length
            let v19 : int32 = v18 v1
            let v27 : int32 = 1 |> int32 
            let v40 : int32 = v19 |> int32 
            let v48 : int32 = v40 - 1
            let v50 : string = v1.[int v27..int v48]
            let v55 : (char -> string) = _.ToString()
            let v56 : string = v55 v16
            let v59 : int64 = System.Convert.ToInt64 v56.Length
            let v60 : int64 = 0L
            let v61 : UH0 = method79(v59, v56, v60)
            let struct (v62 : System.Text.StringBuilder, v63 : int32, v64 : int32) = method80(v61, v2, v3, v4)
            US15_0(v16, v50, v62, v63, v64)
    match v66 with
    | US15_1(v83) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US15_0(v67, v68, v69, v70, v71) -> (* Ok *)
        let v73 : (char -> string) = _.ToString()
        let v74 : string = v73 v67
        let v77 : string = v0 + v74 
        method89(v77, v68, v69, v70, v71)
and method77 (v0 : string) : US14 =
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
    let v9 : string = ""
    let v10 : string = v4 |> Option.defaultValue v9 
    let v13 : string = method78()
    let v15 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v16 : System.Text.StringBuilder = v15 v13
    let v19 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US15) = closure36()
    let v20 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US15) = closure38()
    let v21 : UH1 = UH1_0
    let v22 : UH1 = UH1_1(v20, v21)
    let v23 : UH1 = UH1_1(v19, v22)
    let v24 : US15 = method82(v10, v16, v23)
    let v197 : US16 =
        match v24 with
        | US15_1(v194) -> (* Error *)
            US16_1(v194)
        | US15_0(v25, v26, v27, v28, v29) -> (* Ok *)
            let v30 : bool = "" = v26
            let v123 : US15 =
                if v30 then
                    let v31 : char list = []
                    let v33 : char list = ''' :: v31 
                    let v37 : char list = '"' :: v33 
                    let v41 : (char list -> (char [])) = List.toArray
                    let v42 : (char []) = v41 v37
                    let v46 : string = $"parsing.none_of / unexpected end of input / chars: %A{v42} / s: %A{struct (v27, v28, v29)}"
                    US15_1(v46)
                else
                    let v50 : char = v26.[int 0]
                    let v51 : int64 = 0L
                    let v52 : bool = method83(v50, v51)
                    let v53 : bool = v52 = false
                    if v53 then
                        let v55 : (string -> int32) = String.length
                        let v56 : int32 = v55 v26
                        let v64 : int32 = 1 |> int32 
                        let v77 : int32 = v56 |> int32 
                        let v85 : int32 = v77 - 1
                        let v87 : string = v26.[int v64..int v85]
                        let v92 : (char -> string) = _.ToString()
                        let v93 : string = v92 v50
                        let v96 : int64 = System.Convert.ToInt64 v93.Length
                        let v97 : int64 = 0L
                        let v98 : UH0 = method79(v96, v93, v97)
                        let struct (v99 : System.Text.StringBuilder, v100 : int32, v101 : int32) = method80(v98, v27, v28, v29)
                        US15_0(v50, v87, v99, v100, v101)
                    else
                        let v103 : char list = []
                        let v105 : char list = ''' :: v103 
                        let v109 : char list = '"' :: v105 
                        let v113 : (char list -> (char [])) = List.toArray
                        let v114 : (char []) = v113 v109
                        let v118 : string = $"parsing.none_of / unexpected char: '{v50}' / chars: %A{v114} / s: %A{struct (v27, v28, v29)}"
                        US15_1(v118)
            let v135 : US15 =
                match v123 with
                | US15_1(v132) -> (* Error *)
                    US15_1(v132)
                | US15_0(v124, v125, v126, v127, v128) -> (* Ok *)
                    let v129 : bool = '\\' = v124
                    let v130 : char =
                        if v129 then
                            '/'
                        else
                            v124
                    US15_0(v130, v125, v126, v127, v128)
            let v155 : US16 =
                match v135 with
                | US15_1(v152) -> (* Error *)
                    US16_1(v152)
                | US15_0(v136, v137, v138, v139, v140) -> (* Ok *)
                    let v142 : (char -> string) = _.ToString()
                    let v143 : string = v142 v136
                    let struct (v146 : string, v147 : string, v148 : System.Text.StringBuilder, v149 : int32, v150 : int32) = method84(v143, v137, v138, v139, v140)
                    US16_0(v146, v147, v148, v149, v150)
            let v165 : US16 =
                match v155 with
                | US16_1(v162) -> (* Error *)
                    US16_0(v9, v26, v27, v28, v29)
                | US16_0(v156, v157, v158, v159, v160) -> (* Ok *)
                    US16_0(v156, v157, v158, v159, v160)
            match v165 with
            | US16_1(v189) -> (* Error *)
                let v190 : string = "parsing.between / expected content"
                US16_1(v190)
            | US16_0(v166, v167, v168, v169, v170) -> (* Ok *)
                let v171 : UH1 = UH1_0
                let v172 : UH1 = UH1_1(v20, v171)
                let v173 : UH1 = UH1_1(v19, v172)
                let v174 : US15 = method85(v167, v168, v169, v170, v173)
                match v174 with
                | US15_1(v181) -> (* Error *)
                    let v183 : string = $"parsing.between / expected closing delimiter / e: %A{v181} / input: %A{struct (v10, v16, 1, 1)} / rest1: %A{struct (v26, v27, v28, v29)} / rest2: %A{struct (v167, v168, v169, v170)}"
                    US16_1(v183)
                | US15_0(v175, v176, v177, v178, v179) -> (* Ok *)
                    US16_0(v166, v176, v177, v178, v179)
    let v416 : US16 =
        match v197 with
        | US16_1(v203) -> (* Error *)
            let v204 : bool = "" = v10
            let v307 : US15 =
                if v204 then
                    let v205 : char list = []
                    let v207 : char list = ' ' :: v205 
                    let v211 : char list = ''' :: v207 
                    let v215 : char list = '"' :: v211 
                    let v219 : (char list -> (char [])) = List.toArray
                    let v220 : (char []) = v219 v215
                    let v224 : string = $"parsing.none_of / unexpected end of input / chars: %A{v220} / s: %A{struct (v16, 1, 1)}"
                    US15_1(v224)
                else
                    let v228 : char = v10.[int 0]
                    let v229 : int64 = 0L
                    let v230 : bool = method86(v228, v229)
                    let v231 : bool = v230 = false
                    if v231 then
                        let v233 : (string -> int32) = String.length
                        let v234 : int32 = v233 v10
                        let v242 : int32 = 1 |> int32 
                        let v255 : int32 = v234 |> int32 
                        let v263 : int32 = v255 - 1
                        let v265 : string = v10.[int v242..int v263]
                        let v270 : (char -> string) = _.ToString()
                        let v271 : string = v270 v228
                        let v274 : int64 = System.Convert.ToInt64 v271.Length
                        let v275 : int64 = 0L
                        let v276 : UH0 = method79(v274, v271, v275)
                        let v277 : int32 = 1
                        let v278 : int32 = 1
                        let struct (v279 : System.Text.StringBuilder, v280 : int32, v281 : int32) = method80(v276, v16, v277, v278)
                        US15_0(v228, v265, v279, v280, v281)
                    else
                        let v283 : char list = []
                        let v285 : char list = ' ' :: v283 
                        let v289 : char list = ''' :: v285 
                        let v293 : char list = '"' :: v289 
                        let v297 : (char list -> (char [])) = List.toArray
                        let v298 : (char []) = v297 v293
                        let v302 : string = $"parsing.none_of / unexpected char: '{v228}' / chars: %A{v298} / s: %A{struct (v16, 1, 1)}"
                        US15_1(v302)
            let v319 : US15 =
                match v307 with
                | US15_1(v316) -> (* Error *)
                    US15_1(v316)
                | US15_0(v308, v309, v310, v311, v312) -> (* Ok *)
                    let v313 : bool = '\\' = v308
                    let v314 : char =
                        if v313 then
                            '/'
                        else
                            v308
                    US15_0(v314, v309, v310, v311, v312)
            let v339 : US16 =
                match v319 with
                | US15_1(v336) -> (* Error *)
                    US16_1(v336)
                | US15_0(v320, v321, v322, v323, v324) -> (* Ok *)
                    let v326 : (char -> string) = _.ToString()
                    let v327 : string = v326 v320
                    let struct (v330 : string, v331 : string, v332 : System.Text.StringBuilder, v333 : int32, v334 : int32) = method87(v327, v321, v322, v323, v324)
                    US16_0(v330, v331, v332, v333, v334)
            match v339 with
            | US16_1(v345) -> (* Error *)
                let v346 : int32 = v10.Length
                let v347 : bool = v346 = 0
                let v354 : US18 =
                    if v347 then
                        US18_0(v10, v16, 1, 1)
                    else
                        let v350 : string = $"parsing.eof / expected end of input / input: %A{v10}"
                        US18_1(v350)
                let v363 : US16 =
                    match v354 with
                    | US18_1(v360) -> (* Error *)
                        US16_1(v360)
                    | US18_0(v355, v356, v357, v358) -> (* Ok *)
                        US16_0(v9, v355, v356, v357, v358)
                match v363 with
                | US16_1(v409) -> (* Error *)
                    US16_1(v409)
                | US16_0(v364, v365, v366, v367, v368) -> (* Ok *)
                    let v369 : int32 = 0
                    let v370 : int32 = method88(v365, v369)
                    let v372 : (string -> int32) = String.length
                    let v373 : int32 = v372 v365
                    let v381 : int32 = v370 |> int32 
                    let v394 : int32 = v373 |> int32 
                    let v402 : int32 = v394 - 1
                    let v404 : string = v365.[int v381..int v402]
                    US16_0(v364, v404, v366, v367, v368)
            | US16_0(v340, v341, v342, v343, v344) -> (* Ok *)
                v339
        | US16_0(v198, v199, v200, v201, v202) -> (* Ok *)
            v197
    let v671 : US19 =
        match v416 with
        | US16_1(v668) -> (* Error *)
            US19_1(v668)
        | US16_0(v417, v418, v419, v420, v421) -> (* Ok *)
            let v422 : bool = "" = v418
            let v542 : US15 =
                if v422 then
                    let v424 : string = $"parsing.p_char / unexpected end of input / c: '{' '}' / s: %A{struct (v419, v420, v421)}"
                    US15_1(v424)
                else
                    let v428 : char = v418.[int 0]
                    let v429 : bool = v428 = ' '
                    if v429 then
                        let v431 : (string -> int32) = String.length
                        let v432 : int32 = v431 v418
                        let v440 : int32 = 1 |> int32 
                        let v453 : int32 = v432 |> int32 
                        let v461 : int32 = v453 - 1
                        let v463 : string = v418.[int v440..int v461]
                        let v468 : (char -> string) = _.ToString()
                        let v469 : string = v468 v428
                        let v472 : int64 = System.Convert.ToInt64 v469.Length
                        let v473 : int64 = 0L
                        let v474 : UH0 = method79(v472, v469, v473)
                        let struct (v475 : System.Text.StringBuilder, v476 : int32, v477 : int32) = method80(v474, v419, v420, v421)
                        US15_0(v428, v463, v475, v476, v477)
                    else
                        let v480 : string = "\n"
                        let v481 : int32 = v418.IndexOf v480 
                        let v484 : int32 = v481 - 1
                        let v485 : bool = -2 = v484
                        let v493 : int32 =
                            if v485 then
                                let v487 : (string -> int32) = String.length
                                let v488 : int32 = v487 v418
                                let v491 : int32 = v488 + 1
                                v491
                            else
                                let v492 : int32 = v484 + 1
                                v492
                        let v499 : int32 = 0 |> int32 
                        let v512 : int32 = v493 |> int32 
                        let v520 : int32 = v512 - 1
                        let v522 : string = v418.[int v499..int v520]
                        let v527 : string = $"parsing.p_char / expected: '{' '}' / line: {v420} / col: {v421}
{v419}{v522}"
                        let v530 : int32 = v421 - 1
                        let v531 : int32 = 0
                        let v532 : (string -> string) = method81(v530, v531)
                        let v533 : string = v532 v9
                        let v534 : string = "^"
                        let v535 : string = v533 + v534 
                        let v537 : string = $"{v527}
{v535}
"
                        US15_1(v537)
            let v554 : US20 =
                match v542 with
                | US15_1(v550) -> (* Error *)
                    let v551 : US17 = US17_1
                    US20_0(v551, v418, v419, v420, v421)
                | US15_0(v543, v544, v545, v546, v547) -> (* Ok *)
                    let v548 : US17 = US17_0(v543)
                    US20_0(v548, v544, v545, v546, v547)
            let v645 : US16 =
                match v554 with
                | US20_1(v642) -> (* Error *)
                    US16_1(v642)
                | US20_0(v555, v556, v557, v558, v559) -> (* Ok *)
                    let v560 : bool = "" = v556
                    let v621 : US15 =
                        if v560 then
                            let v567 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v557, v558, v559)}"
                            US15_1(v567)
                        else
                            let v571 : char = v556.[int 0]
                            let v573 : (string -> int32) = String.length
                            let v574 : int32 = v573 v556
                            let v582 : int32 = 1 |> int32 
                            let v595 : int32 = v574 |> int32 
                            let v603 : int32 = v595 - 1
                            let v605 : string = v556.[int v582..int v603]
                            let v610 : (char -> string) = _.ToString()
                            let v611 : string = v610 v571
                            let v614 : int64 = System.Convert.ToInt64 v611.Length
                            let v615 : int64 = 0L
                            let v616 : UH0 = method79(v614, v611, v615)
                            let struct (v617 : System.Text.StringBuilder, v618 : int32, v619 : int32) = method80(v616, v557, v558, v559)
                            US15_0(v571, v605, v617, v618, v619)
                    match v621 with
                    | US15_1(v638) -> (* Error *)
                        US16_1(v638)
                    | US15_0(v622, v623, v624, v625, v626) -> (* Ok *)
                        let v628 : (char -> string) = _.ToString()
                        let v629 : string = v628 v622
                        let struct (v632 : string, v633 : string, v634 : System.Text.StringBuilder, v635 : int32, v636 : int32) = method89(v629, v623, v624, v625, v626)
                        US16_0(v632, v633, v634, v635, v636)
            let v657 : US21 =
                match v645 with
                | US16_1(v653) -> (* Error *)
                    let v654 : US5 = US5_1
                    US21_0(v654, v418, v419, v420, v421)
                | US16_0(v646, v647, v648, v649, v650) -> (* Ok *)
                    let v651 : US5 = US5_0(v646)
                    US21_0(v651, v647, v648, v649, v650)
            match v657 with
            | US21_1(v664) -> (* Error *)
                US19_1(v664)
            | US21_0(v658, v659, v660, v661, v662) -> (* Ok *)
                US19_0(v417, v658, v659, v660, v661, v662)
    match v671 with
    | US19_1(v679) -> (* Error *)
        US14_1(v679)
    | US19_0(v672, v673, v674, v675, v676, v677) -> (* Ok *)
        US14_0(v672, v673)
and method92 (v0 : char, v1 : int64) : bool =
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
            method92(v0, v25)
and method93 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
    let v5 : bool = "" = v1
    let v114 : US15 =
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
            let v35 : bool = method92(v33, v34)
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
                let v79 : int64 = System.Convert.ToInt64 v76.Length
                let v80 : int64 = 0L
                let v81 : UH0 = method79(v79, v76, v80)
                let struct (v82 : System.Text.StringBuilder, v83 : int32, v84 : int32) = method80(v81, v2, v3, v4)
                US15_0(v33, v70, v82, v83, v84)
            else
                let v86 : char list = []
                let v88 : char list = ' ' :: v86 
                let v92 : char list = '"' :: v88 
                let v96 : char list = '`' :: v92 
                let v100 : char list = '\\' :: v96 
                let v104 : (char list -> (char [])) = List.toArray
                let v105 : (char []) = v104 v100
                let v109 : string = $"parsing.none_of / unexpected char: '{v33}' / chars: %A{v105} / s: %A{struct (v2, v3, v4)}"
                US15_1(v109)
    match v114 with
    | US15_1(v131) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US15_0(v115, v116, v117, v118, v119) -> (* Ok *)
        let v121 : (char -> string) = _.ToString()
        let v122 : string = v121 v115
        let v125 : string = v0 + v122 
        method93(v125, v116, v117, v118, v119)
and method95 (v0 : char, v1 : int64) : bool =
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
            method95(v0, v21)
and closure39 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US16 =
    let v4 : bool = "" = v0
    let v125 : US15 =
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
                let v54 : int64 = System.Convert.ToInt64 v51.Length
                let v55 : int64 = 0L
                let v56 : UH0 = method79(v54, v51, v55)
                let struct (v57 : System.Text.StringBuilder, v58 : int32, v59 : int32) = method80(v56, v1, v2, v3)
                US15_0(v10, v45, v57, v58, v59)
            else
                let v62 : string = "\n"
                let v63 : int32 = v0.IndexOf v62 
                let v66 : int32 = v63 - 1
                let v67 : bool = -2 = v66
                let v75 : int32 =
                    if v67 then
                        let v69 : (string -> int32) = String.length
                        let v70 : int32 = v69 v0
                        let v73 : int32 = v70 + 1
                        v73
                    else
                        let v74 : int32 = v66 + 1
                        v74
                let v81 : int32 = 0 |> int32 
                let v94 : int32 = v75 |> int32 
                let v102 : int32 = v94 - 1
                let v104 : string = v0.[int v81..int v102]
                let v109 : string = $"parsing.p_char / expected: '{'\\'}' / line: {v2} / col: {v3}
{v1}{v104}"
                let v112 : int32 = v3 - 1
                let v113 : int32 = 0
                let v114 : (string -> string) = method81(v112, v113)
                let v115 : string = ""
                let v116 : string = v114 v115
                let v117 : string = "^"
                let v118 : string = v116 + v117 
                let v120 : string = $"{v109}
{v118}
"
                US15_1(v120)
    let v196 : US15 =
        match v125 with
        | US15_1(v193) -> (* Error *)
            US15_1(v193)
        | US15_0(v126, v127, v128, v129, v130) -> (* Ok *)
            let v131 : bool = "" = v127
            if v131 then
                let v138 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v128, v129, v130)}"
                US15_1(v138)
            else
                let v142 : char = v127.[int 0]
                let v144 : (string -> int32) = String.length
                let v145 : int32 = v144 v127
                let v153 : int32 = 1 |> int32 
                let v166 : int32 = v145 |> int32 
                let v174 : int32 = v166 - 1
                let v176 : string = v127.[int v153..int v174]
                let v181 : (char -> string) = _.ToString()
                let v182 : string = v181 v142
                let v185 : int64 = System.Convert.ToInt64 v182.Length
                let v186 : int64 = 0L
                let v187 : UH0 = method79(v185, v182, v186)
                let struct (v188 : System.Text.StringBuilder, v189 : int32, v190 : int32) = method80(v187, v128, v129, v130)
                US15_0(v142, v176, v188, v189, v190)
    match v196 with
    | US15_1(v214) -> (* Error *)
        US16_1(v214)
    | US15_0(v197, v198, v199, v200, v201) -> (* Ok *)
        let v203 : (char -> string) = _.ToString()
        let v204 : string = v203 '\\'
        let v208 : (char -> string) = _.ToString()
        let v209 : string = v208 v197
        let v212 : string = v204 + v209 
        US16_0(v212, v198, v199, v200, v201)
and closure40 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US16 =
    let v4 : bool = "" = v0
    let v125 : US15 =
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
                let v54 : int64 = System.Convert.ToInt64 v51.Length
                let v55 : int64 = 0L
                let v56 : UH0 = method79(v54, v51, v55)
                let struct (v57 : System.Text.StringBuilder, v58 : int32, v59 : int32) = method80(v56, v1, v2, v3)
                US15_0(v10, v45, v57, v58, v59)
            else
                let v62 : string = "\n"
                let v63 : int32 = v0.IndexOf v62 
                let v66 : int32 = v63 - 1
                let v67 : bool = -2 = v66
                let v75 : int32 =
                    if v67 then
                        let v69 : (string -> int32) = String.length
                        let v70 : int32 = v69 v0
                        let v73 : int32 = v70 + 1
                        v73
                    else
                        let v74 : int32 = v66 + 1
                        v74
                let v81 : int32 = 0 |> int32 
                let v94 : int32 = v75 |> int32 
                let v102 : int32 = v94 - 1
                let v104 : string = v0.[int v81..int v102]
                let v109 : string = $"parsing.p_char / expected: '{'`'}' / line: {v2} / col: {v3}
{v1}{v104}"
                let v112 : int32 = v3 - 1
                let v113 : int32 = 0
                let v114 : (string -> string) = method81(v112, v113)
                let v115 : string = ""
                let v116 : string = v114 v115
                let v117 : string = "^"
                let v118 : string = v116 + v117 
                let v120 : string = $"{v109}
{v118}
"
                US15_1(v120)
    let v196 : US15 =
        match v125 with
        | US15_1(v193) -> (* Error *)
            US15_1(v193)
        | US15_0(v126, v127, v128, v129, v130) -> (* Ok *)
            let v131 : bool = "" = v127
            if v131 then
                let v138 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v128, v129, v130)}"
                US15_1(v138)
            else
                let v142 : char = v127.[int 0]
                let v144 : (string -> int32) = String.length
                let v145 : int32 = v144 v127
                let v153 : int32 = 1 |> int32 
                let v166 : int32 = v145 |> int32 
                let v174 : int32 = v166 - 1
                let v176 : string = v127.[int v153..int v174]
                let v181 : (char -> string) = _.ToString()
                let v182 : string = v181 v142
                let v185 : int64 = System.Convert.ToInt64 v182.Length
                let v186 : int64 = 0L
                let v187 : UH0 = method79(v185, v182, v186)
                let struct (v188 : System.Text.StringBuilder, v189 : int32, v190 : int32) = method80(v187, v128, v129, v130)
                US15_0(v142, v176, v188, v189, v190)
    match v196 with
    | US15_1(v214) -> (* Error *)
        US16_1(v214)
    | US15_0(v197, v198, v199, v200, v201) -> (* Ok *)
        let v203 : (char -> string) = _.ToString()
        let v204 : string = v203 '`'
        let v208 : (char -> string) = _.ToString()
        let v209 : string = v208 v197
        let v212 : string = v204 + v209 
        US16_0(v212, v198, v199, v200, v201)
and method96 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH3) : US16 =
    match v4 with
    | UH3_1(v7, v8) -> (* Cons *)
        let v9 : US16 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US16_1(v15) -> (* Error *)
            method96(v0, v1, v2, v3, v8)
        | US16_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH3_0 -> (* Nil *)
        let v5 : string = "parsing.choice / no parsers succeeded"
        US16_1(v5)
and method97 (v0 : UH2, v1 : UH2) : UH2 =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : UH2 = UH2_1(v2, v1)
        method97(v3, v4)
    | UH2_0 -> (* Nil *)
        v1
and method94 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US23 =
    let v5 : bool = "" = v1
    let v106 : US15 =
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
            let v31 : bool = method95(v29, v30)
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
                let v75 : int64 = System.Convert.ToInt64 v72.Length
                let v76 : int64 = 0L
                let v77 : UH0 = method79(v75, v72, v76)
                let struct (v78 : System.Text.StringBuilder, v79 : int32, v80 : int32) = method80(v77, v2, v3, v4)
                US15_0(v29, v66, v78, v79, v80)
            else
                let v82 : char list = []
                let v84 : char list = '"' :: v82 
                let v88 : char list = '`' :: v84 
                let v92 : char list = '\\' :: v88 
                let v96 : (char list -> (char [])) = List.toArray
                let v97 : (char []) = v96 v92
                let v101 : string = $"parsing.none_of / unexpected char: '{v29}' / chars: %A{v97} / s: %A{struct (v2, v3, v4)}"
                US15_1(v101)
    let v121 : US16 =
        match v106 with
        | US15_1(v118) -> (* Error *)
            US16_1(v118)
        | US15_0(v107, v108, v109, v110, v111) -> (* Ok *)
            let v113 : (char -> string) = _.ToString()
            let v114 : string = v113 v107
            US16_0(v114, v108, v109, v110, v111)
    let v135 : US16 =
        match v121 with
        | US16_1(v127) -> (* Error *)
            let v128 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US16) = closure39()
            let v129 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US16) = closure40()
            let v130 : UH3 = UH3_0
            let v131 : UH3 = UH3_1(v129, v130)
            let v132 : UH3 = UH3_1(v128, v131)
            method96(v1, v2, v3, v4, v132)
        | US16_0(v122, v123, v124, v125, v126) -> (* Ok *)
            v121
    match v135 with
    | US16_1(v143) -> (* Error *)
        let v144 : UH2 = UH2_0
        let v145 : UH2 = method97(v0, v144)
        US23_0(v145, v1, v2, v3, v4)
    | US16_0(v136, v137, v138, v139, v140) -> (* Ok *)
        let v141 : UH2 = UH2_1(v136, v0)
        method94(v141, v137, v138, v139, v140)
and method98 (v0 : UH2, v1 : string list) : string list =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : string list = method98(v3, v1)
        let v6 : string list = v2 :: v4 
        v6
    | UH2_0 -> (* Nil *)
        v1
and method99 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US23 =
    let v5 : bool = "" = v1
    let v106 : US15 =
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
            let v31 : bool = method95(v29, v30)
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
                let v75 : int64 = System.Convert.ToInt64 v72.Length
                let v76 : int64 = 0L
                let v77 : UH0 = method79(v75, v72, v76)
                let struct (v78 : System.Text.StringBuilder, v79 : int32, v80 : int32) = method80(v77, v2, v3, v4)
                US15_0(v29, v66, v78, v79, v80)
            else
                let v82 : char list = []
                let v84 : char list = '"' :: v82 
                let v88 : char list = '`' :: v84 
                let v92 : char list = '\\' :: v88 
                let v96 : (char list -> (char [])) = List.toArray
                let v97 : (char []) = v96 v92
                let v101 : string = $"parsing.none_of / unexpected char: '{v29}' / chars: %A{v97} / s: %A{struct (v2, v3, v4)}"
                US15_1(v101)
    let v121 : US16 =
        match v106 with
        | US15_1(v118) -> (* Error *)
            US16_1(v118)
        | US15_0(v107, v108, v109, v110, v111) -> (* Ok *)
            let v113 : (char -> string) = _.ToString()
            let v114 : string = v113 v107
            US16_0(v114, v108, v109, v110, v111)
    match v121 with
    | US16_1(v129) -> (* Error *)
        let v130 : UH2 = UH2_0
        let v131 : UH2 = method97(v0, v130)
        US23_0(v131, v1, v2, v3, v4)
    | US16_0(v122, v123, v124, v125, v126) -> (* Ok *)
        let v127 : UH2 = UH2_1(v122, v0)
        method99(v127, v123, v124, v125, v126)
and method91 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US23 =
    let v5 : bool = "" = v1
    let v114 : US15 =
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
            let v35 : bool = method92(v33, v34)
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
                let v79 : int64 = System.Convert.ToInt64 v76.Length
                let v80 : int64 = 0L
                let v81 : UH0 = method79(v79, v76, v80)
                let struct (v82 : System.Text.StringBuilder, v83 : int32, v84 : int32) = method80(v81, v2, v3, v4)
                US15_0(v33, v70, v82, v83, v84)
            else
                let v86 : char list = []
                let v88 : char list = ' ' :: v86 
                let v92 : char list = '"' :: v88 
                let v96 : char list = '`' :: v92 
                let v100 : char list = '\\' :: v96 
                let v104 : (char list -> (char [])) = List.toArray
                let v105 : (char []) = v104 v100
                let v109 : string = $"parsing.none_of / unexpected char: '{v33}' / chars: %A{v105} / s: %A{struct (v2, v3, v4)}"
                US15_1(v109)
    let v134 : US16 =
        match v114 with
        | US15_1(v131) -> (* Error *)
            US16_1(v131)
        | US15_0(v115, v116, v117, v118, v119) -> (* Ok *)
            let v121 : (char -> string) = _.ToString()
            let v122 : string = v121 v115
            let struct (v125 : string, v126 : string, v127 : System.Text.StringBuilder, v128 : int32, v129 : int32) = method93(v122, v116, v117, v118, v119)
            US16_0(v125, v126, v127, v128, v129)
    let v522 : US16 =
        match v134 with
        | US16_1(v140) -> (* Error *)
            let v261 : US15 =
                if v5 then
                    let v142 : string = $"parsing.p_char / unexpected end of input / c: '{'"'}' / s: %A{struct (v2, v3, v4)}"
                    US15_1(v142)
                else
                    let v146 : char = v1.[int 0]
                    let v147 : bool = v146 = '"'
                    if v147 then
                        let v149 : (string -> int32) = String.length
                        let v150 : int32 = v149 v1
                        let v158 : int32 = 1 |> int32 
                        let v171 : int32 = v150 |> int32 
                        let v179 : int32 = v171 - 1
                        let v181 : string = v1.[int v158..int v179]
                        let v186 : (char -> string) = _.ToString()
                        let v187 : string = v186 v146
                        let v190 : int64 = System.Convert.ToInt64 v187.Length
                        let v191 : int64 = 0L
                        let v192 : UH0 = method79(v190, v187, v191)
                        let struct (v193 : System.Text.StringBuilder, v194 : int32, v195 : int32) = method80(v192, v2, v3, v4)
                        US15_0(v146, v181, v193, v194, v195)
                    else
                        let v198 : string = "\n"
                        let v199 : int32 = v1.IndexOf v198 
                        let v202 : int32 = v199 - 1
                        let v203 : bool = -2 = v202
                        let v211 : int32 =
                            if v203 then
                                let v205 : (string -> int32) = String.length
                                let v206 : int32 = v205 v1
                                let v209 : int32 = v206 + 1
                                v209
                            else
                                let v210 : int32 = v202 + 1
                                v210
                        let v217 : int32 = 0 |> int32 
                        let v230 : int32 = v211 |> int32 
                        let v238 : int32 = v230 - 1
                        let v240 : string = v1.[int v217..int v238]
                        let v245 : string = $"parsing.p_char / expected: '{'"'}' / line: {v3} / col: {v4}
{v2}{v240}"
                        let v248 : int32 = v4 - 1
                        let v249 : int32 = 0
                        let v250 : (string -> string) = method81(v248, v249)
                        let v251 : string = ""
                        let v252 : string = v250 v251
                        let v253 : string = "^"
                        let v254 : string = v252 + v253 
                        let v256 : string = $"{v245}
{v254}
"
                        US15_1(v256)
            let v451 : US16 =
                match v261 with
                | US15_1(v448) -> (* Error *)
                    US16_1(v448)
                | US15_0(v262, v263, v264, v265, v266) -> (* Ok *)
                    let v267 : UH2 = UH2_0
                    let v268 : US23 = method94(v267, v263, v264, v265, v266)
                    let v301 : US16 =
                        match v268 with
                        | US23_1(v298) -> (* Error *)
                            US16_1(v298)
                        | US23_0(v269, v270, v271, v272, v273) -> (* Ok *)
                            let v274 : string list = []
                            let v275 : string list = method98(v269, v274)
                            let v280 : unit = ()
                            let _let'_v280 =
                                seq {
                                    yield! v275 
                                    (* indent
                                    ()
                                indent *)
                                }
                                (* indent
                                ()
                            indent *)
                            let v283 : string seq = _let'_v280 
                            let v291 : (string -> (string seq -> string)) = String.concat
                            let v292 : string = ""
                            let v293 : (string seq -> string) = v291 v292
                            let v294 : string = v293 v283
                            US16_0(v294, v270, v271, v272, v273)
                    match v301 with
                    | US16_1(v443) -> (* Error *)
                        let v444 : string = "parsing.between / expected content"
                        US16_1(v444)
                    | US16_0(v302, v303, v304, v305, v306) -> (* Ok *)
                        let v307 : bool = "" = v303
                        let v428 : US15 =
                            if v307 then
                                let v309 : string = $"parsing.p_char / unexpected end of input / c: '{'"'}' / s: %A{struct (v304, v305, v306)}"
                                US15_1(v309)
                            else
                                let v313 : char = v303.[int 0]
                                let v314 : bool = v313 = '"'
                                if v314 then
                                    let v316 : (string -> int32) = String.length
                                    let v317 : int32 = v316 v303
                                    let v325 : int32 = 1 |> int32 
                                    let v338 : int32 = v317 |> int32 
                                    let v346 : int32 = v338 - 1
                                    let v348 : string = v303.[int v325..int v346]
                                    let v353 : (char -> string) = _.ToString()
                                    let v354 : string = v353 v313
                                    let v357 : int64 = System.Convert.ToInt64 v354.Length
                                    let v358 : int64 = 0L
                                    let v359 : UH0 = method79(v357, v354, v358)
                                    let struct (v360 : System.Text.StringBuilder, v361 : int32, v362 : int32) = method80(v359, v304, v305, v306)
                                    US15_0(v313, v348, v360, v361, v362)
                                else
                                    let v365 : string = "\n"
                                    let v366 : int32 = v303.IndexOf v365 
                                    let v369 : int32 = v366 - 1
                                    let v370 : bool = -2 = v369
                                    let v378 : int32 =
                                        if v370 then
                                            let v372 : (string -> int32) = String.length
                                            let v373 : int32 = v372 v303
                                            let v376 : int32 = v373 + 1
                                            v376
                                        else
                                            let v377 : int32 = v369 + 1
                                            v377
                                    let v384 : int32 = 0 |> int32 
                                    let v397 : int32 = v378 |> int32 
                                    let v405 : int32 = v397 - 1
                                    let v407 : string = v303.[int v384..int v405]
                                    let v412 : string = $"parsing.p_char / expected: '{'"'}' / line: {v305} / col: {v306}
{v304}{v407}"
                                    let v415 : int32 = v306 - 1
                                    let v416 : int32 = 0
                                    let v417 : (string -> string) = method81(v415, v416)
                                    let v418 : string = ""
                                    let v419 : string = v417 v418
                                    let v420 : string = "^"
                                    let v421 : string = v419 + v420 
                                    let v423 : string = $"{v412}
{v421}
"
                                    US15_1(v423)
                        match v428 with
                        | US15_1(v435) -> (* Error *)
                            let v437 : string = $"parsing.between / expected closing delimiter / e: %A{v435} / input: %A{struct (v1, v2, v3, v4)} / rest1: %A{struct (v263, v264, v265, v266)} / rest2: %A{struct (v303, v304, v305, v306)}"
                            US16_1(v437)
                        | US15_0(v429, v430, v431, v432, v433) -> (* Ok *)
                            US16_0(v302, v430, v431, v432, v433)
            match v451 with
            | US16_1(v457) -> (* Error *)
                let v458 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US16) = closure39()
                let v459 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US16) = closure40()
                let v460 : UH3 = UH3_0
                let v461 : UH3 = UH3_1(v459, v460)
                let v462 : UH3 = UH3_1(v458, v461)
                let v463 : US16 = method96(v1, v2, v3, v4, v462)
                let v474 : US16 =
                    match v463 with
                    | US16_1(v471) -> (* Error *)
                        US16_1(v471)
                    | US16_0(v464, v465, v466, v467, v468) -> (* Ok *)
                        let v469 : string = ""
                        US16_0(v469, v465, v466, v467, v468)
                let v485 : US23 =
                    match v474 with
                    | US16_1(v482) -> (* Error *)
                        US23_1(v482)
                    | US16_0(v475, v476, v477, v478, v479) -> (* Ok *)
                        let v480 : UH2 = UH2_0
                        method99(v480, v476, v477, v478, v479)
                match v485 with
                | US23_1(v515) -> (* Error *)
                    US16_1(v515)
                | US23_0(v486, v487, v488, v489, v490) -> (* Ok *)
                    let v491 : string list = []
                    let v492 : string list = method98(v486, v491)
                    let v497 : unit = ()
                    let _let'_v497 =
                        seq {
                            yield! v492 
                            (* indent
                            ()
                        indent *)
                        }
                        (* indent
                        ()
                    indent *)
                    let v500 : string seq = _let'_v497 
                    let v508 : (string -> (string seq -> string)) = String.concat
                    let v509 : string = ""
                    let v510 : (string seq -> string) = v508 v509
                    let v511 : string = v510 v500
                    US16_0(v511, v487, v488, v489, v490)
            | US16_0(v452, v453, v454, v455, v456) -> (* Ok *)
                v451
        | US16_0(v135, v136, v137, v138, v139) -> (* Ok *)
            v134
    match v522 with
    | US16_1(v585) -> (* Error *)
        let v586 : UH2 = UH2_0
        let v587 : UH2 = method97(v0, v586)
        US23_0(v587, v1, v2, v3, v4)
    | US16_0(v523, v524, v525, v526, v527) -> (* Ok *)
        let v528 : int32 = 0
        let v529 : int32 = method88(v524, v528)
        let v530 : bool = 0 = v529
        let v571 : US18 =
            if v530 then
                let v531 : string = "parsing.spaces1 / expected at least one space"
                US18_1(v531)
            else
                let v534 : (string -> int32) = String.length
                let v535 : int32 = v534 v524
                let v543 : int32 = v529 |> int32 
                let v556 : int32 = v535 |> int32 
                let v564 : int32 = v556 - 1
                let v566 : string = v524.[int v543..int v564]
                US18_0(v566, v525, v526, v527)
        match v571 with
        | US18_1(v578) -> (* Error *)
            let v579 : UH2 = UH2_0
            let v580 : UH2 = UH2_1(v523, v579)
            let v581 : UH2 = method97(v0, v580)
            US23_0(v581, v524, v525, v526, v527)
        | US18_0(v572, v573, v574, v575) -> (* Ok *)
            let v576 : UH2 = UH2_1(v523, v0)
            method91(v576, v572, v573, v574, v575)
and method90 (v0 : string) : US22 =
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
    let v9 : string = ""
    let v10 : string = v4 |> Option.defaultValue v9 
    let v13 : string = method78()
    let v15 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v16 : System.Text.StringBuilder = v15 v13
    let v19 : UH2 = UH2_0
    let v20 : int32 = 1
    let v21 : int32 = 1
    let v22 : US23 = method91(v19, v10, v16, v20, v21)
    match v22 with
    | US23_1(v36) -> (* Error *)
        US22_1(v36)
    | US23_0(v23, v24, v25, v26, v27) -> (* Ok *)
        let v28 : string list = []
        let v29 : string list = method98(v23, v28)
        let v31 : (string list -> (string [])) = List.toArray
        let v32 : (string []) = v31 v29
        US22_0(v32)
and method100 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option) : string =
    let v17 : string = method13()
    let v18 : Mut3 = {l0 = v17} : Mut3
    let v21 : string = "{ "
    let v22 : string = $"{v21}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure8(v18, v22)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v40 : string = "file_name"
    let v41 : string = $"{v40}"
    let v49 : unit = ()
    let v50 : (unit -> unit) = closure8(v18, v41)
    let v51 : unit = (fun () -> v50 (); v49) ()
    let v59 : string = " = "
    let v60 : string = $"{v59}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure8(v18, v60)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v77 : string = $"{v8}"
    let v85 : unit = ()
    let v86 : (unit -> unit) = closure8(v18, v77)
    let v87 : unit = (fun () -> v86 (); v85) ()
    let v95 : string = "; "
    let v96 : string = $"{v95}"
    let v104 : unit = ()
    let v105 : (unit -> unit) = closure8(v18, v96)
    let v106 : unit = (fun () -> v105 (); v104) ()
    let v114 : string = "arguments"
    let v115 : string = $"{v114}"
    let v123 : unit = ()
    let v124 : (unit -> unit) = closure8(v18, v115)
    let v125 : unit = (fun () -> v124 (); v123) ()
    let v132 : string = $"{v59}"
    let v140 : unit = ()
    let v141 : (unit -> unit) = closure8(v18, v132)
    let v142 : unit = (fun () -> v141 (); v140) ()
    let v149 : string = $"{v9}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure8(v18, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v95}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure8(v18, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "options"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure8(v18, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v59}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure8(v18, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v219 : string = $"{v21}"
    let v227 : unit = ()
    let v228 : (unit -> unit) = closure8(v18, v219)
    let v229 : unit = (fun () -> v228 (); v227) ()
    let v237 : string = "command"
    let v238 : string = $"{v237}"
    let v246 : unit = ()
    let v247 : (unit -> unit) = closure8(v18, v238)
    let v248 : unit = (fun () -> v247 (); v246) ()
    let v255 : string = $"{v59}"
    let v263 : unit = ()
    let v264 : (unit -> unit) = closure8(v18, v255)
    let v265 : unit = (fun () -> v264 (); v263) ()
    let v272 : string = $"{v10}"
    let v280 : unit = ()
    let v281 : (unit -> unit) = closure8(v18, v272)
    let v282 : unit = (fun () -> v281 (); v280) ()
    let v289 : string = $"{v95}"
    let v297 : unit = ()
    let v298 : (unit -> unit) = closure8(v18, v289)
    let v299 : unit = (fun () -> v298 (); v297) ()
    let v307 : string = "cancellation_token"
    let v308 : string = $"{v307}"
    let v316 : unit = ()
    let v317 : (unit -> unit) = closure8(v18, v308)
    let v318 : unit = (fun () -> v317 (); v316) ()
    let v325 : string = $"{v59}"
    let v333 : unit = ()
    let v334 : (unit -> unit) = closure8(v18, v325)
    let v335 : unit = (fun () -> v334 (); v333) ()
    (* run_target_args'
    let v345 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v346 : string = "format!(\"{:#?}\", $0)"
    let v347 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v346 
    let v348 : string = "fable_library_rust::String_::fromString($0)"
    let v349 : string = Fable.Core.RustInterop.emitRustExpr v347 v348 
    let _run_target_args'_v345 = v349 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v350 : string = "format!(\"{:#?}\", $0)"
    let v351 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v350 
    let v352 : string = "fable_library_rust::String_::fromString($0)"
    let v353 : string = Fable.Core.RustInterop.emitRustExpr v351 v352 
    let _run_target_args'_v345 = v353 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v354 : string = "format!(\"{:#?}\", $0)"
    let v355 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v354 
    let v356 : string = "fable_library_rust::String_::fromString($0)"
    let v357 : string = Fable.Core.RustInterop.emitRustExpr v355 v356 
    let _run_target_args'_v345 = v357 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v359 : string = $"%A{v11}"
    let _run_target_args'_v345 = v359 
    #endif
#if FABLE_COMPILER_PYTHON
    let v363 : string = $"%A{v11}"
    let _run_target_args'_v345 = v363 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v367 : string = $"%A{v11}"
    let _run_target_args'_v345 = v367 
    #endif
#else
    let v371 : string = $"%A{v11}"
    let _run_target_args'_v345 = v371 
    #endif
    let v374 : string = _run_target_args'_v345 
    let v384 : string = $"{v374}"
    let v392 : unit = ()
    let v393 : (unit -> unit) = closure8(v18, v384)
    let v394 : unit = (fun () -> v393 (); v392) ()
    let v401 : string = $"{v95}"
    let v409 : unit = ()
    let v410 : (unit -> unit) = closure8(v18, v401)
    let v411 : unit = (fun () -> v410 (); v409) ()
    let v419 : string = "environment_variables"
    let v420 : string = $"{v419}"
    let v428 : unit = ()
    let v429 : (unit -> unit) = closure8(v18, v420)
    let v430 : unit = (fun () -> v429 (); v428) ()
    let v437 : string = $"{v59}"
    let v445 : unit = ()
    let v446 : (unit -> unit) = closure8(v18, v437)
    let v447 : unit = (fun () -> v446 (); v445) ()
    let v454 : string = $"%A{v12}"
    let v458 : string = $"{v454}"
    let v466 : unit = ()
    let v467 : (unit -> unit) = closure8(v18, v458)
    let v468 : unit = (fun () -> v467 (); v466) ()
    let v475 : string = $"{v95}"
    let v483 : unit = ()
    let v484 : (unit -> unit) = closure8(v18, v475)
    let v485 : unit = (fun () -> v484 (); v483) ()
    let v493 : string = "on_line"
    let v494 : string = $"{v493}"
    let v502 : unit = ()
    let v503 : (unit -> unit) = closure8(v18, v494)
    let v504 : unit = (fun () -> v503 (); v502) ()
    let v511 : string = $"{v59}"
    let v519 : unit = ()
    let v520 : (unit -> unit) = closure8(v18, v511)
    let v521 : unit = (fun () -> v520 (); v519) ()
    (* run_target_args'
    let v531 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v532 : string = "format!(\"{:#?}\", $0)"
    let v533 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v532 
    let v534 : string = "fable_library_rust::String_::fromString($0)"
    let v535 : string = Fable.Core.RustInterop.emitRustExpr v533 v534 
    let _run_target_args'_v531 = v535 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v536 : string = "format!(\"{:#?}\", $0)"
    let v537 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v536 
    let v538 : string = "fable_library_rust::String_::fromString($0)"
    let v539 : string = Fable.Core.RustInterop.emitRustExpr v537 v538 
    let _run_target_args'_v531 = v539 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v540 : string = "format!(\"{:#?}\", $0)"
    let v541 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v540 
    let v542 : string = "fable_library_rust::String_::fromString($0)"
    let v543 : string = Fable.Core.RustInterop.emitRustExpr v541 v542 
    let _run_target_args'_v531 = v543 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v545 : string = $"%A{v13}"
    let _run_target_args'_v531 = v545 
    #endif
#if FABLE_COMPILER_PYTHON
    let v549 : string = $"%A{v13}"
    let _run_target_args'_v531 = v549 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v553 : string = $"%A{v13}"
    let _run_target_args'_v531 = v553 
    #endif
#else
    let v557 : string = $"%A{v13}"
    let _run_target_args'_v531 = v557 
    #endif
    let v560 : string = _run_target_args'_v531 
    let v570 : string = $"{v560}"
    let v578 : unit = ()
    let v579 : (unit -> unit) = closure8(v18, v570)
    let v580 : unit = (fun () -> v579 (); v578) ()
    let v587 : string = $"{v95}"
    let v595 : unit = ()
    let v596 : (unit -> unit) = closure8(v18, v587)
    let v597 : unit = (fun () -> v596 (); v595) ()
    let v605 : string = "stdin"
    let v606 : string = $"{v605}"
    let v614 : unit = ()
    let v615 : (unit -> unit) = closure8(v18, v606)
    let v616 : unit = (fun () -> v615 (); v614) ()
    let v623 : string = $"{v59}"
    let v631 : unit = ()
    let v632 : (unit -> unit) = closure8(v18, v623)
    let v633 : unit = (fun () -> v632 (); v631) ()
    (* run_target_args'
    let v643 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v644 : string = "format!(\"{:#?}\", $0)"
    let v645 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v644 
    let v646 : string = "fable_library_rust::String_::fromString($0)"
    let v647 : string = Fable.Core.RustInterop.emitRustExpr v645 v646 
    let _run_target_args'_v643 = v647 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v648 : string = "format!(\"{:#?}\", $0)"
    let v649 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v648 
    let v650 : string = "fable_library_rust::String_::fromString($0)"
    let v651 : string = Fable.Core.RustInterop.emitRustExpr v649 v650 
    let _run_target_args'_v643 = v651 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v652 : string = "format!(\"{:#?}\", $0)"
    let v653 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v652 
    let v654 : string = "fable_library_rust::String_::fromString($0)"
    let v655 : string = Fable.Core.RustInterop.emitRustExpr v653 v654 
    let _run_target_args'_v643 = v655 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v657 : string = $"%A{v14}"
    let _run_target_args'_v643 = v657 
    #endif
#if FABLE_COMPILER_PYTHON
    let v661 : string = $"%A{v14}"
    let _run_target_args'_v643 = v661 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v665 : string = $"%A{v14}"
    let _run_target_args'_v643 = v665 
    #endif
#else
    let v669 : string = $"%A{v14}"
    let _run_target_args'_v643 = v669 
    #endif
    let v672 : string = _run_target_args'_v643 
    let v682 : string = $"{v672}"
    let v690 : unit = ()
    let v691 : (unit -> unit) = closure8(v18, v682)
    let v692 : unit = (fun () -> v691 (); v690) ()
    let v699 : string = $"{v95}"
    let v707 : unit = ()
    let v708 : (unit -> unit) = closure8(v18, v699)
    let v709 : unit = (fun () -> v708 (); v707) ()
    let v717 : string = "trace"
    let v718 : string = $"{v717}"
    let v726 : unit = ()
    let v727 : (unit -> unit) = closure8(v18, v718)
    let v728 : unit = (fun () -> v727 (); v726) ()
    let v735 : string = $"{v59}"
    let v743 : unit = ()
    let v744 : (unit -> unit) = closure8(v18, v735)
    let v745 : unit = (fun () -> v744 (); v743) ()
    let v753 : string =
        if v15 then
            let v751 : string = "true"
            v751
        else
            let v752 : string = "false"
            v752
    let v755 : string = $"{v753}"
    let v763 : unit = ()
    let v764 : (unit -> unit) = closure8(v18, v755)
    let v765 : unit = (fun () -> v764 (); v763) ()
    let v772 : string = $"{v95}"
    let v780 : unit = ()
    let v781 : (unit -> unit) = closure8(v18, v772)
    let v782 : unit = (fun () -> v781 (); v780) ()
    let v790 : string = "working_directory"
    let v791 : string = $"{v790}"
    let v799 : unit = ()
    let v800 : (unit -> unit) = closure8(v18, v791)
    let v801 : unit = (fun () -> v800 (); v799) ()
    let v808 : string = $"{v59}"
    let v816 : unit = ()
    let v817 : (unit -> unit) = closure8(v18, v808)
    let v818 : unit = (fun () -> v817 (); v816) ()
    (* run_target_args'
    let v828 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v829 : string = "format!(\"{:#?}\", $0)"
    let v830 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v829 
    let v831 : string = "fable_library_rust::String_::fromString($0)"
    let v832 : string = Fable.Core.RustInterop.emitRustExpr v830 v831 
    let _run_target_args'_v828 = v832 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v833 : string = "format!(\"{:#?}\", $0)"
    let v834 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v833 
    let v835 : string = "fable_library_rust::String_::fromString($0)"
    let v836 : string = Fable.Core.RustInterop.emitRustExpr v834 v835 
    let _run_target_args'_v828 = v836 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v837 : string = "format!(\"{:#?}\", $0)"
    let v838 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v837 
    let v839 : string = "fable_library_rust::String_::fromString($0)"
    let v840 : string = Fable.Core.RustInterop.emitRustExpr v838 v839 
    let _run_target_args'_v828 = v840 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v842 : string = $"%A{v16}"
    let _run_target_args'_v828 = v842 
    #endif
#if FABLE_COMPILER_PYTHON
    let v846 : string = $"%A{v16}"
    let _run_target_args'_v828 = v846 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v850 : string = $"%A{v16}"
    let _run_target_args'_v828 = v850 
    #endif
#else
    let v854 : string = $"%A{v16}"
    let _run_target_args'_v828 = v854 
    #endif
    let v857 : string = _run_target_args'_v828 
    let v867 : string = $"{v857}"
    let v875 : unit = ()
    let v876 : (unit -> unit) = closure8(v18, v867)
    let v877 : unit = (fun () -> v876 (); v875) ()
    let v885 : string = " }"
    let v886 : string = $"{v885}"
    let v894 : unit = ()
    let v895 : (unit -> unit) = closure8(v18, v886)
    let v896 : unit = (fun () -> v895 (); v894) ()
    let v903 : string = $"{v885}"
    let v911 : unit = ()
    let v912 : (unit -> unit) = closure8(v18, v903)
    let v913 : unit = (fun () -> v912 (); v911) ()
    let v919 : string = v18.l0
    let v920 : int64 = v0.l0
    let v923 : string = " "
    let v924 : string = v6 + v923 
    let v928 : string = v924 + v7 
    let v933 : string = " #"
    let v934 : string = v928 + v933 
    let v938 : (int64 -> string) = _.ToString()
    let v939 : string = v938 v920
    let v943 : string = v934 + v939 
    let v947 : string = v943 + v923 
    let v952 : string = "runtime.execute_with_options"
    let v953 : string = v947 + v952 
    let v958 : string = " / "
    let v959 : string = v953 + v958 
    let v963 : string = v959 + v919 
    method16(v963)
and closure41 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : string, v8 : Vec<std_string_String>) () : unit =
    let v9 : US0 = US0_1
    let v10 : bool = method7(v9)
    if v10 then
        let v25 : unit = ()
        let v26 : (unit -> unit) = closure6()
        let v27 : unit = (fun () -> v26 (); v25) ()
        let struct (v48 : Mut0, v49 : Mut1, v50 : Mut2, v51 : Mut3, v52 : Mut4, v53 : int64 option) = TraceState.trace_state.Value
        let v66 : string = method8(v48, v49, v50, v51, v52, v53)
        let v67 : string = method61()
        let v69 : string = $"%A{v8}"
        let v72 : string = method100(v48, v49, v50, v51, v52, v53, v66, v67, v7, v69, v0, v1, v2, v3, v4, v5, v6)
        method17(v72)
and closure42 () (v0 : std_process_Child option) : std_process_Child option =
    v0
and method101 () : (std_process_Child option -> std_process_Child option) =
    closure42()
and closure43 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : US24 =
    US24_0(v0)
and method102 () : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US24) =
    closure43()
and closure44 () (v0 : std_string_String) : US24 =
    US24_1(v0)
and method103 () : (std_string_String -> US24) =
    closure44()
and method104 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String, v9 : string, v10 : string, v11 : string, v12 : System.Threading.CancellationToken option, v13 : (struct (string * string) []), v14 : (struct (int32 * string * bool) -> Async<unit>) option, v15 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v16 : bool, v17 : string option) : string =
    let v18 : string = method13()
    let v19 : Mut3 = {l0 = v18} : Mut3
    let v22 : string = "{ "
    let v23 : string = $"{v22}"
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure8(v19, v23)
    let v33 : unit = (fun () -> v32 (); v31) ()
    let v41 : string = "error"
    let v42 : string = $"{v41}"
    let v50 : unit = ()
    let v51 : (unit -> unit) = closure8(v19, v42)
    let v52 : unit = (fun () -> v51 (); v50) ()
    let v60 : string = " = "
    let v61 : string = $"{v60}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure8(v19, v61)
    let v71 : unit = (fun () -> v70 (); v69) ()
    (* run_target_args'
    let v81 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v82 : string = "format!(\"{:#?}\", $0)"
    let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v82 
    let v84 : string = "fable_library_rust::String_::fromString($0)"
    let v85 : string = Fable.Core.RustInterop.emitRustExpr v83 v84 
    let _run_target_args'_v81 = v85 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v86 : string = "format!(\"{:#?}\", $0)"
    let v87 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v86 
    let v88 : string = "fable_library_rust::String_::fromString($0)"
    let v89 : string = Fable.Core.RustInterop.emitRustExpr v87 v88 
    let _run_target_args'_v81 = v89 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v90 : string = "format!(\"{:#?}\", $0)"
    let v91 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v90 
    let v92 : string = "fable_library_rust::String_::fromString($0)"
    let v93 : string = Fable.Core.RustInterop.emitRustExpr v91 v92 
    let _run_target_args'_v81 = v93 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v95 : string = $"%A{v8}"
    let _run_target_args'_v81 = v95 
    #endif
#if FABLE_COMPILER_PYTHON
    let v99 : string = $"%A{v8}"
    let _run_target_args'_v81 = v99 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v103 : string = $"%A{v8}"
    let _run_target_args'_v81 = v103 
    #endif
#else
    let v107 : string = $"%A{v8}"
    let _run_target_args'_v81 = v107 
    #endif
    let v110 : string = _run_target_args'_v81 
    let v120 : string = $"{v110}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure8(v19, v120)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v138 : string = "; "
    let v139 : string = $"{v138}"
    let v147 : unit = ()
    let v148 : (unit -> unit) = closure8(v19, v139)
    let v149 : unit = (fun () -> v148 (); v147) ()
    let v157 : string = "file_name"
    let v158 : string = $"{v157}"
    let v166 : unit = ()
    let v167 : (unit -> unit) = closure8(v19, v158)
    let v168 : unit = (fun () -> v167 (); v166) ()
    let v175 : string = $"{v60}"
    let v183 : unit = ()
    let v184 : (unit -> unit) = closure8(v19, v175)
    let v185 : unit = (fun () -> v184 (); v183) ()
    let v192 : string = $"{v9}"
    let v200 : unit = ()
    let v201 : (unit -> unit) = closure8(v19, v192)
    let v202 : unit = (fun () -> v201 (); v200) ()
    let v209 : string = $"{v138}"
    let v217 : unit = ()
    let v218 : (unit -> unit) = closure8(v19, v209)
    let v219 : unit = (fun () -> v218 (); v217) ()
    let v227 : string = "arguments"
    let v228 : string = $"{v227}"
    let v236 : unit = ()
    let v237 : (unit -> unit) = closure8(v19, v228)
    let v238 : unit = (fun () -> v237 (); v236) ()
    let v245 : string = $"{v60}"
    let v253 : unit = ()
    let v254 : (unit -> unit) = closure8(v19, v245)
    let v255 : unit = (fun () -> v254 (); v253) ()
    let v262 : string = $"{v10}"
    let v270 : unit = ()
    let v271 : (unit -> unit) = closure8(v19, v262)
    let v272 : unit = (fun () -> v271 (); v270) ()
    let v279 : string = $"{v138}"
    let v287 : unit = ()
    let v288 : (unit -> unit) = closure8(v19, v279)
    let v289 : unit = (fun () -> v288 (); v287) ()
    let v297 : string = "options"
    let v298 : string = $"{v297}"
    let v306 : unit = ()
    let v307 : (unit -> unit) = closure8(v19, v298)
    let v308 : unit = (fun () -> v307 (); v306) ()
    let v315 : string = $"{v60}"
    let v323 : unit = ()
    let v324 : (unit -> unit) = closure8(v19, v315)
    let v325 : unit = (fun () -> v324 (); v323) ()
    let v332 : string = $"{v22}"
    let v340 : unit = ()
    let v341 : (unit -> unit) = closure8(v19, v332)
    let v342 : unit = (fun () -> v341 (); v340) ()
    let v350 : string = "command"
    let v351 : string = $"{v350}"
    let v359 : unit = ()
    let v360 : (unit -> unit) = closure8(v19, v351)
    let v361 : unit = (fun () -> v360 (); v359) ()
    let v368 : string = $"{v60}"
    let v376 : unit = ()
    let v377 : (unit -> unit) = closure8(v19, v368)
    let v378 : unit = (fun () -> v377 (); v376) ()
    let v385 : string = $"{v11}"
    let v393 : unit = ()
    let v394 : (unit -> unit) = closure8(v19, v385)
    let v395 : unit = (fun () -> v394 (); v393) ()
    let v402 : string = $"{v138}"
    let v410 : unit = ()
    let v411 : (unit -> unit) = closure8(v19, v402)
    let v412 : unit = (fun () -> v411 (); v410) ()
    let v420 : string = "cancellation_token"
    let v421 : string = $"{v420}"
    let v429 : unit = ()
    let v430 : (unit -> unit) = closure8(v19, v421)
    let v431 : unit = (fun () -> v430 (); v429) ()
    let v438 : string = $"{v60}"
    let v446 : unit = ()
    let v447 : (unit -> unit) = closure8(v19, v438)
    let v448 : unit = (fun () -> v447 (); v446) ()
    (* run_target_args'
    let v458 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v459 : string = "format!(\"{:#?}\", $0)"
    let v460 : std_string_String = Fable.Core.RustInterop.emitRustExpr v12 v459 
    let v461 : string = "fable_library_rust::String_::fromString($0)"
    let v462 : string = Fable.Core.RustInterop.emitRustExpr v460 v461 
    let _run_target_args'_v458 = v462 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v463 : string = "format!(\"{:#?}\", $0)"
    let v464 : std_string_String = Fable.Core.RustInterop.emitRustExpr v12 v463 
    let v465 : string = "fable_library_rust::String_::fromString($0)"
    let v466 : string = Fable.Core.RustInterop.emitRustExpr v464 v465 
    let _run_target_args'_v458 = v466 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v467 : string = "format!(\"{:#?}\", $0)"
    let v468 : std_string_String = Fable.Core.RustInterop.emitRustExpr v12 v467 
    let v469 : string = "fable_library_rust::String_::fromString($0)"
    let v470 : string = Fable.Core.RustInterop.emitRustExpr v468 v469 
    let _run_target_args'_v458 = v470 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v472 : string = $"%A{v12}"
    let _run_target_args'_v458 = v472 
    #endif
#if FABLE_COMPILER_PYTHON
    let v476 : string = $"%A{v12}"
    let _run_target_args'_v458 = v476 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v480 : string = $"%A{v12}"
    let _run_target_args'_v458 = v480 
    #endif
#else
    let v484 : string = $"%A{v12}"
    let _run_target_args'_v458 = v484 
    #endif
    let v487 : string = _run_target_args'_v458 
    let v497 : string = $"{v487}"
    let v505 : unit = ()
    let v506 : (unit -> unit) = closure8(v19, v497)
    let v507 : unit = (fun () -> v506 (); v505) ()
    let v514 : string = $"{v138}"
    let v522 : unit = ()
    let v523 : (unit -> unit) = closure8(v19, v514)
    let v524 : unit = (fun () -> v523 (); v522) ()
    let v532 : string = "environment_variables"
    let v533 : string = $"{v532}"
    let v541 : unit = ()
    let v542 : (unit -> unit) = closure8(v19, v533)
    let v543 : unit = (fun () -> v542 (); v541) ()
    let v550 : string = $"{v60}"
    let v558 : unit = ()
    let v559 : (unit -> unit) = closure8(v19, v550)
    let v560 : unit = (fun () -> v559 (); v558) ()
    let v567 : string = $"%A{v13}"
    let v571 : string = $"{v567}"
    let v579 : unit = ()
    let v580 : (unit -> unit) = closure8(v19, v571)
    let v581 : unit = (fun () -> v580 (); v579) ()
    let v588 : string = $"{v138}"
    let v596 : unit = ()
    let v597 : (unit -> unit) = closure8(v19, v588)
    let v598 : unit = (fun () -> v597 (); v596) ()
    let v606 : string = "on_line"
    let v607 : string = $"{v606}"
    let v615 : unit = ()
    let v616 : (unit -> unit) = closure8(v19, v607)
    let v617 : unit = (fun () -> v616 (); v615) ()
    let v624 : string = $"{v60}"
    let v632 : unit = ()
    let v633 : (unit -> unit) = closure8(v19, v624)
    let v634 : unit = (fun () -> v633 (); v632) ()
    (* run_target_args'
    let v644 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v645 : string = "format!(\"{:#?}\", $0)"
    let v646 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v645 
    let v647 : string = "fable_library_rust::String_::fromString($0)"
    let v648 : string = Fable.Core.RustInterop.emitRustExpr v646 v647 
    let _run_target_args'_v644 = v648 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v649 : string = "format!(\"{:#?}\", $0)"
    let v650 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v649 
    let v651 : string = "fable_library_rust::String_::fromString($0)"
    let v652 : string = Fable.Core.RustInterop.emitRustExpr v650 v651 
    let _run_target_args'_v644 = v652 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v653 : string = "format!(\"{:#?}\", $0)"
    let v654 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v653 
    let v655 : string = "fable_library_rust::String_::fromString($0)"
    let v656 : string = Fable.Core.RustInterop.emitRustExpr v654 v655 
    let _run_target_args'_v644 = v656 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v658 : string = $"%A{v14}"
    let _run_target_args'_v644 = v658 
    #endif
#if FABLE_COMPILER_PYTHON
    let v662 : string = $"%A{v14}"
    let _run_target_args'_v644 = v662 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v666 : string = $"%A{v14}"
    let _run_target_args'_v644 = v666 
    #endif
#else
    let v670 : string = $"%A{v14}"
    let _run_target_args'_v644 = v670 
    #endif
    let v673 : string = _run_target_args'_v644 
    let v683 : string = $"{v673}"
    let v691 : unit = ()
    let v692 : (unit -> unit) = closure8(v19, v683)
    let v693 : unit = (fun () -> v692 (); v691) ()
    let v700 : string = $"{v138}"
    let v708 : unit = ()
    let v709 : (unit -> unit) = closure8(v19, v700)
    let v710 : unit = (fun () -> v709 (); v708) ()
    let v718 : string = "stdin"
    let v719 : string = $"{v718}"
    let v727 : unit = ()
    let v728 : (unit -> unit) = closure8(v19, v719)
    let v729 : unit = (fun () -> v728 (); v727) ()
    let v736 : string = $"{v60}"
    let v744 : unit = ()
    let v745 : (unit -> unit) = closure8(v19, v736)
    let v746 : unit = (fun () -> v745 (); v744) ()
    (* run_target_args'
    let v756 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v757 : string = "format!(\"{:#?}\", $0)"
    let v758 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v757 
    let v759 : string = "fable_library_rust::String_::fromString($0)"
    let v760 : string = Fable.Core.RustInterop.emitRustExpr v758 v759 
    let _run_target_args'_v756 = v760 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v761 : string = "format!(\"{:#?}\", $0)"
    let v762 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v761 
    let v763 : string = "fable_library_rust::String_::fromString($0)"
    let v764 : string = Fable.Core.RustInterop.emitRustExpr v762 v763 
    let _run_target_args'_v756 = v764 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v765 : string = "format!(\"{:#?}\", $0)"
    let v766 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v765 
    let v767 : string = "fable_library_rust::String_::fromString($0)"
    let v768 : string = Fable.Core.RustInterop.emitRustExpr v766 v767 
    let _run_target_args'_v756 = v768 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v770 : string = $"%A{v15}"
    let _run_target_args'_v756 = v770 
    #endif
#if FABLE_COMPILER_PYTHON
    let v774 : string = $"%A{v15}"
    let _run_target_args'_v756 = v774 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v778 : string = $"%A{v15}"
    let _run_target_args'_v756 = v778 
    #endif
#else
    let v782 : string = $"%A{v15}"
    let _run_target_args'_v756 = v782 
    #endif
    let v785 : string = _run_target_args'_v756 
    let v795 : string = $"{v785}"
    let v803 : unit = ()
    let v804 : (unit -> unit) = closure8(v19, v795)
    let v805 : unit = (fun () -> v804 (); v803) ()
    let v812 : string = $"{v138}"
    let v820 : unit = ()
    let v821 : (unit -> unit) = closure8(v19, v812)
    let v822 : unit = (fun () -> v821 (); v820) ()
    let v830 : string = "trace"
    let v831 : string = $"{v830}"
    let v839 : unit = ()
    let v840 : (unit -> unit) = closure8(v19, v831)
    let v841 : unit = (fun () -> v840 (); v839) ()
    let v848 : string = $"{v60}"
    let v856 : unit = ()
    let v857 : (unit -> unit) = closure8(v19, v848)
    let v858 : unit = (fun () -> v857 (); v856) ()
    let v866 : string =
        if v16 then
            let v864 : string = "true"
            v864
        else
            let v865 : string = "false"
            v865
    let v868 : string = $"{v866}"
    let v876 : unit = ()
    let v877 : (unit -> unit) = closure8(v19, v868)
    let v878 : unit = (fun () -> v877 (); v876) ()
    let v885 : string = $"{v138}"
    let v893 : unit = ()
    let v894 : (unit -> unit) = closure8(v19, v885)
    let v895 : unit = (fun () -> v894 (); v893) ()
    let v903 : string = "working_directory"
    let v904 : string = $"{v903}"
    let v912 : unit = ()
    let v913 : (unit -> unit) = closure8(v19, v904)
    let v914 : unit = (fun () -> v913 (); v912) ()
    let v921 : string = $"{v60}"
    let v929 : unit = ()
    let v930 : (unit -> unit) = closure8(v19, v921)
    let v931 : unit = (fun () -> v930 (); v929) ()
    (* run_target_args'
    let v941 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v942 : string = "format!(\"{:#?}\", $0)"
    let v943 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v942 
    let v944 : string = "fable_library_rust::String_::fromString($0)"
    let v945 : string = Fable.Core.RustInterop.emitRustExpr v943 v944 
    let _run_target_args'_v941 = v945 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v946 : string = "format!(\"{:#?}\", $0)"
    let v947 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v946 
    let v948 : string = "fable_library_rust::String_::fromString($0)"
    let v949 : string = Fable.Core.RustInterop.emitRustExpr v947 v948 
    let _run_target_args'_v941 = v949 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v950 : string = "format!(\"{:#?}\", $0)"
    let v951 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v950 
    let v952 : string = "fable_library_rust::String_::fromString($0)"
    let v953 : string = Fable.Core.RustInterop.emitRustExpr v951 v952 
    let _run_target_args'_v941 = v953 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v955 : string = $"%A{v17}"
    let _run_target_args'_v941 = v955 
    #endif
#if FABLE_COMPILER_PYTHON
    let v959 : string = $"%A{v17}"
    let _run_target_args'_v941 = v959 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v963 : string = $"%A{v17}"
    let _run_target_args'_v941 = v963 
    #endif
#else
    let v967 : string = $"%A{v17}"
    let _run_target_args'_v941 = v967 
    #endif
    let v970 : string = _run_target_args'_v941 
    let v980 : string = $"{v970}"
    let v988 : unit = ()
    let v989 : (unit -> unit) = closure8(v19, v980)
    let v990 : unit = (fun () -> v989 (); v988) ()
    let v998 : string = " }"
    let v999 : string = $"{v998}"
    let v1007 : unit = ()
    let v1008 : (unit -> unit) = closure8(v19, v999)
    let v1009 : unit = (fun () -> v1008 (); v1007) ()
    let v1016 : string = $"{v998}"
    let v1024 : unit = ()
    let v1025 : (unit -> unit) = closure8(v19, v1016)
    let v1026 : unit = (fun () -> v1025 (); v1024) ()
    let v1032 : string = v19.l0
    let v1033 : int64 = v0.l0
    let v1036 : string = " "
    let v1037 : string = v6 + v1036 
    let v1041 : string = v1037 + v7 
    let v1046 : string = " #"
    let v1047 : string = v1041 + v1046 
    let v1051 : (int64 -> string) = _.ToString()
    let v1052 : string = v1051 v1033
    let v1056 : string = v1047 + v1052 
    let v1060 : string = v1056 + v1036 
    let v1065 : string = "runtime.execute_with_options / child error"
    let v1066 : string = v1060 + v1065 
    let v1071 : string = " / "
    let v1072 : string = v1066 + v1071 
    let v1076 : string = v1072 + v1032 
    method16(v1076)
and closure45 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : string, v8 : Vec<std_string_String>, v9 : std_string_String) () : unit =
    let v10 : US0 = US0_4
    let v11 : bool = method7(v10)
    if v11 then
        let v26 : unit = ()
        let v27 : (unit -> unit) = closure6()
        let v28 : unit = (fun () -> v27 (); v26) ()
        let struct (v49 : Mut0, v50 : Mut1, v51 : Mut2, v52 : Mut3, v53 : Mut4, v54 : int64 option) = TraceState.trace_state.Value
        let v67 : string = method8(v49, v50, v51, v52, v53, v54)
        let v68 : string = method70()
        let v70 : string = $"%A{v8}"
        let v73 : string = method104(v49, v50, v51, v52, v53, v54, v67, v68, v9, v7, v70, v0, v1, v2, v3, v4, v5, v6)
        method17(v73)
and method105 (v0 : std_sync_MutexGuard<std_process_Child option>) : std_sync_MutexGuard<std_process_Child option> =
    v0
and closure46 () (v0 : std_process_ChildStdin option) : std_process_ChildStdin option =
    v0
and method106 () : (std_process_ChildStdin option -> std_process_ChildStdin option) =
    closure46()
and closure47 () (v0 : std_sync_mpsc_Sender<std_string_String>) : std_sync_mpsc_Sender<std_string_String> =
    v0
and method107 () : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) =
    closure47()
and method108 () : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) =
    closure47()
and closure48 () (v0 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> =
    v0
and method109 () : (std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> -> std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) =
    closure48()
and closure49 () (v0 : std_string_String) : US26 =
    US26_0(v0)
and method110 () : (std_string_String -> US26) =
    closure49()
and closure50 () (v0 : std_string_String) : US26 =
    US26_1(v0)
and method111 () : (std_string_String -> US26) =
    closure50()
and method112 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : bool, v9 : std_string_String) : string =
    let v10 : string = method13()
    let v11 : Mut3 = {l0 = v10} : Mut3
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure8(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "trace'"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure8(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure8(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v71 : string =
        if v8 then
            let v69 : string = "true"
            v69
        else
            let v70 : string = "false"
            v70
    let v73 : string = $"{v71}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure8(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure8(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "e"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure8(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure8(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    (* run_target_args'
    let v148 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v149 : string = "format!(\"{:#?}\", $0)"
    let v150 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v149 
    let v151 : string = "fable_library_rust::String_::fromString($0)"
    let v152 : string = Fable.Core.RustInterop.emitRustExpr v150 v151 
    let _run_target_args'_v148 = v152 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v153 : string = "format!(\"{:#?}\", $0)"
    let v154 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v153 
    let v155 : string = "fable_library_rust::String_::fromString($0)"
    let v156 : string = Fable.Core.RustInterop.emitRustExpr v154 v155 
    let _run_target_args'_v148 = v156 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v157 : string = "format!(\"{:#?}\", $0)"
    let v158 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v157 
    let v159 : string = "fable_library_rust::String_::fromString($0)"
    let v160 : string = Fable.Core.RustInterop.emitRustExpr v158 v159 
    let _run_target_args'_v148 = v160 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v162 : string = $"%A{v9}"
    let _run_target_args'_v148 = v162 
    #endif
#if FABLE_COMPILER_PYTHON
    let v166 : string = $"%A{v9}"
    let _run_target_args'_v148 = v166 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v170 : string = $"%A{v9}"
    let _run_target_args'_v148 = v170 
    #endif
#else
    let v174 : string = $"%A{v9}"
    let _run_target_args'_v148 = v174 
    #endif
    let v177 : string = _run_target_args'_v148 
    let v187 : string = $"{v177}"
    let v195 : unit = ()
    let v196 : (unit -> unit) = closure8(v11, v187)
    let v197 : unit = (fun () -> v196 (); v195) ()
    let v205 : string = " }"
    let v206 : string = $"{v205}"
    let v214 : unit = ()
    let v215 : (unit -> unit) = closure8(v11, v206)
    let v216 : unit = (fun () -> v215 (); v214) ()
    let v222 : string = v11.l0
    let v223 : int64 = v0.l0
    let v226 : string = " "
    let v227 : string = v6 + v226 
    let v231 : string = v227 + v7 
    let v236 : string = " #"
    let v237 : string = v231 + v236 
    let v241 : (int64 -> string) = _.ToString()
    let v242 : string = v241 v223
    let v246 : string = v237 + v242 
    let v250 : string = v246 + v226 
    let v255 : string = "runtime.stdio_line"
    let v256 : string = v250 + v255 
    let v261 : string = " / "
    let v262 : string = v256 + v261 
    let v266 : string = v262 + v222 
    method16(v266)
and closure51 (v0 : bool, v1 : std_string_String) () : unit =
    let v2 : US0 = US0_4
    let v3 : bool = method7(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure6()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut0, v42 : Mut1, v43 : Mut2, v44 : Mut3, v45 : Mut4, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method8(v41, v42, v43, v44, v45, v46)
        let v60 : string = method70()
        let v61 : string = method112(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method17(v61)
and method113 () : string =
    
    
    
    
    
    let v2 : string = "Verbose"
    let v3 : (unit -> string) = v2.ToLower
    let v4 : string = v3 ()
    let v7 : char = v4.[int 0]
    let v8 : string = method13()
    let v9 : Mut3 = {l0 = v8} : Mut3
    let v14 : string = $"{v7}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure8(v9, v14)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v30 : string = v9.l0
    (* run_target_args'
    let v47 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v48 : string = "inline_colorization::color_bright_black"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48 
    (* run_target_args'
    let v54 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v55 : string = "&*$0"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v55 
    let _run_target_args'_v54 = v56 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v57 : string = "&*$0"
    let v58 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v57 
    let _run_target_args'_v54 = v58 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v59 : string = "&*$0"
    let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v59 
    let _run_target_args'_v54 = v60 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v62 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v62 
    #endif
#if FABLE_COMPILER_PYTHON
    let v66 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v66 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v70 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v70 
    #endif
#else
    let v74 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v74 
    #endif
    let v77 : Ref<Str> = _run_target_args'_v54 
    let v86 : string = "inline_colorization::color_reset"
    let v87 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v86 
    let v88 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v89 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v49, v77, v87) v88 
    let v90 : string = "fable_library_rust::String_::fromString($0)"
    let v91 : string = Fable.Core.RustInterop.emitRustExpr v89 v90 
    let _run_target_args'_v47 = v91 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v92 : string = "inline_colorization::color_bright_black"
    let v93 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v92 
    (* run_target_args'
    let v98 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v99 : string = "&*$0"
    let v100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v99 
    let _run_target_args'_v98 = v100 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v101 : string = "&*$0"
    let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v101 
    let _run_target_args'_v98 = v102 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v103 : string = "&*$0"
    let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v103 
    let _run_target_args'_v98 = v104 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v106 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v106 
    #endif
#if FABLE_COMPILER_PYTHON
    let v110 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v110 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v114 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v114 
    #endif
#else
    let v118 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v118 
    #endif
    let v121 : Ref<Str> = _run_target_args'_v98 
    let v130 : string = "inline_colorization::color_reset"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v93, v121, v131) v132 
    let v134 : string = "fable_library_rust::String_::fromString($0)"
    let v135 : string = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let _run_target_args'_v47 = v135 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v136 : string = "inline_colorization::color_bright_black"
    let v137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v136 
    (* run_target_args'
    let v142 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v143 : string = "&*$0"
    let v144 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v143 
    let _run_target_args'_v142 = v144 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v145 : string = "&*$0"
    let v146 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v145 
    let _run_target_args'_v142 = v146 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v147 : string = "&*$0"
    let v148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v147 
    let _run_target_args'_v142 = v148 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v150 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v150 
    #endif
#if FABLE_COMPILER_PYTHON
    let v154 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v154 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v158 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v158 
    #endif
#else
    let v162 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v162 
    #endif
    let v165 : Ref<Str> = _run_target_args'_v142 
    let v174 : string = "inline_colorization::color_reset"
    let v175 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v174 
    let v176 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v177 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v137, v165, v175) v176 
    let v178 : string = "fable_library_rust::String_::fromString($0)"
    let v179 : string = Fable.Core.RustInterop.emitRustExpr v177 v178 
    let _run_target_args'_v47 = v179 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v181 : string = "\u001b[90m"
    let v185 : string = method14()
    let v189 : string = v181 + v30 
    let v193 : string = v189 + v185 
    let _run_target_args'_v47 = v193 
    #endif
#if FABLE_COMPILER_PYTHON
    let v197 : string = "\u001b[90m"
    let v201 : string = method14()
    let v205 : string = v197 + v30 
    let v209 : string = v205 + v201 
    let _run_target_args'_v47 = v209 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v213 : string = "\u001b[90m"
    let v217 : string = method14()
    let v221 : string = v213 + v30 
    let v225 : string = v221 + v217 
    let _run_target_args'_v47 = v225 
    #endif
#else
    let v229 : string = "\u001b[90m"
    let v233 : string = method14()
    let v237 : string = v229 + v30 
    let v241 : string = v237 + v233 
    let _run_target_args'_v47 = v241 
    #endif
    let v244 : string = _run_target_args'_v47 
    v244
and method114 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method13()
    let v10 : Mut3 = {l0 = v9} : Mut3
    let v11 : string = v10.l0
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v43 : string = v39 + v8 
    let v48 : string = " / "
    let v49 : string = v43 + v48 
    let v53 : string = v49 + v11 
    method16(v53)
and closure52 (v0 : string) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method7(v1)
    if v2 then
        let v17 : unit = ()
        let v18 : (unit -> unit) = closure6()
        let v19 : unit = (fun () -> v18 (); v17) ()
        let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
        let v58 : string = method8(v40, v41, v42, v43, v44, v45)
        let v59 : string = method113()
        let v60 : bool = v0 = ""
        let v63 : string =
            if v60 then
                let v61 : string = ""
                v61
            else
                method114(v40, v41, v42, v43, v44, v45, v58, v59, v0)
        method17(v63)
and closure53 () (v0 : std_sync_mpsc_SendError<std_string_String>) : std_string_String =
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
and method115 () : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) =
    closure53()
and method116 (v0 : Result<unit, string>) : Result<unit, string> =
    v0
and closure54 () (v0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)) : US27 =
    US27_0(v0)
and method117 () : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US27) =
    closure54()
and method118 (v0 : std_sync_MutexGuard<std_process_ChildStdin option>) : std_sync_MutexGuard<std_process_ChildStdin option> =
    v0
and closure55 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : US28 =
    US28_0(v0)
and method119 () : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US28) =
    closure55()
and method120 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure56 () (v0 : std_process_Output) : US29 =
    US29_0(v0)
and method121 () : (std_process_Output -> US29) =
    closure56()
and closure57 () (v0 : std_string_String) : US29 =
    US29_1(v0)
and method122 () : (std_string_String -> US29) =
    closure57()
and method123 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String, v9 : string, v10 : string, v11 : string, v12 : System.Threading.CancellationToken option, v13 : (struct (string * string) []), v14 : (struct (int32 * string * bool) -> Async<unit>) option, v15 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v16 : bool, v17 : string option) : string =
    let v18 : string = method13()
    let v19 : Mut3 = {l0 = v18} : Mut3
    let v22 : string = "{ "
    let v23 : string = $"{v22}"
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure8(v19, v23)
    let v33 : unit = (fun () -> v32 (); v31) ()
    let v41 : string = "error"
    let v42 : string = $"{v41}"
    let v50 : unit = ()
    let v51 : (unit -> unit) = closure8(v19, v42)
    let v52 : unit = (fun () -> v51 (); v50) ()
    let v60 : string = " = "
    let v61 : string = $"{v60}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure8(v19, v61)
    let v71 : unit = (fun () -> v70 (); v69) ()
    (* run_target_args'
    let v81 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v82 : string = "format!(\"{:#?}\", $0)"
    let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v82 
    let v84 : string = "fable_library_rust::String_::fromString($0)"
    let v85 : string = Fable.Core.RustInterop.emitRustExpr v83 v84 
    let _run_target_args'_v81 = v85 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v86 : string = "format!(\"{:#?}\", $0)"
    let v87 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v86 
    let v88 : string = "fable_library_rust::String_::fromString($0)"
    let v89 : string = Fable.Core.RustInterop.emitRustExpr v87 v88 
    let _run_target_args'_v81 = v89 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v90 : string = "format!(\"{:#?}\", $0)"
    let v91 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v90 
    let v92 : string = "fable_library_rust::String_::fromString($0)"
    let v93 : string = Fable.Core.RustInterop.emitRustExpr v91 v92 
    let _run_target_args'_v81 = v93 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v95 : string = $"%A{v8}"
    let _run_target_args'_v81 = v95 
    #endif
#if FABLE_COMPILER_PYTHON
    let v99 : string = $"%A{v8}"
    let _run_target_args'_v81 = v99 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v103 : string = $"%A{v8}"
    let _run_target_args'_v81 = v103 
    #endif
#else
    let v107 : string = $"%A{v8}"
    let _run_target_args'_v81 = v107 
    #endif
    let v110 : string = _run_target_args'_v81 
    let v120 : string = $"{v110}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure8(v19, v120)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v138 : string = "; "
    let v139 : string = $"{v138}"
    let v147 : unit = ()
    let v148 : (unit -> unit) = closure8(v19, v139)
    let v149 : unit = (fun () -> v148 (); v147) ()
    let v157 : string = "file_name"
    let v158 : string = $"{v157}"
    let v166 : unit = ()
    let v167 : (unit -> unit) = closure8(v19, v158)
    let v168 : unit = (fun () -> v167 (); v166) ()
    let v175 : string = $"{v60}"
    let v183 : unit = ()
    let v184 : (unit -> unit) = closure8(v19, v175)
    let v185 : unit = (fun () -> v184 (); v183) ()
    let v192 : string = $"{v9}"
    let v200 : unit = ()
    let v201 : (unit -> unit) = closure8(v19, v192)
    let v202 : unit = (fun () -> v201 (); v200) ()
    let v209 : string = $"{v138}"
    let v217 : unit = ()
    let v218 : (unit -> unit) = closure8(v19, v209)
    let v219 : unit = (fun () -> v218 (); v217) ()
    let v227 : string = "arguments"
    let v228 : string = $"{v227}"
    let v236 : unit = ()
    let v237 : (unit -> unit) = closure8(v19, v228)
    let v238 : unit = (fun () -> v237 (); v236) ()
    let v245 : string = $"{v60}"
    let v253 : unit = ()
    let v254 : (unit -> unit) = closure8(v19, v245)
    let v255 : unit = (fun () -> v254 (); v253) ()
    let v262 : string = $"{v10}"
    let v270 : unit = ()
    let v271 : (unit -> unit) = closure8(v19, v262)
    let v272 : unit = (fun () -> v271 (); v270) ()
    let v279 : string = $"{v138}"
    let v287 : unit = ()
    let v288 : (unit -> unit) = closure8(v19, v279)
    let v289 : unit = (fun () -> v288 (); v287) ()
    let v297 : string = "options"
    let v298 : string = $"{v297}"
    let v306 : unit = ()
    let v307 : (unit -> unit) = closure8(v19, v298)
    let v308 : unit = (fun () -> v307 (); v306) ()
    let v315 : string = $"{v60}"
    let v323 : unit = ()
    let v324 : (unit -> unit) = closure8(v19, v315)
    let v325 : unit = (fun () -> v324 (); v323) ()
    let v332 : string = $"{v22}"
    let v340 : unit = ()
    let v341 : (unit -> unit) = closure8(v19, v332)
    let v342 : unit = (fun () -> v341 (); v340) ()
    let v350 : string = "command"
    let v351 : string = $"{v350}"
    let v359 : unit = ()
    let v360 : (unit -> unit) = closure8(v19, v351)
    let v361 : unit = (fun () -> v360 (); v359) ()
    let v368 : string = $"{v60}"
    let v376 : unit = ()
    let v377 : (unit -> unit) = closure8(v19, v368)
    let v378 : unit = (fun () -> v377 (); v376) ()
    let v385 : string = $"{v11}"
    let v393 : unit = ()
    let v394 : (unit -> unit) = closure8(v19, v385)
    let v395 : unit = (fun () -> v394 (); v393) ()
    let v402 : string = $"{v138}"
    let v410 : unit = ()
    let v411 : (unit -> unit) = closure8(v19, v402)
    let v412 : unit = (fun () -> v411 (); v410) ()
    let v420 : string = "cancellation_token"
    let v421 : string = $"{v420}"
    let v429 : unit = ()
    let v430 : (unit -> unit) = closure8(v19, v421)
    let v431 : unit = (fun () -> v430 (); v429) ()
    let v438 : string = $"{v60}"
    let v446 : unit = ()
    let v447 : (unit -> unit) = closure8(v19, v438)
    let v448 : unit = (fun () -> v447 (); v446) ()
    (* run_target_args'
    let v458 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v459 : string = "format!(\"{:#?}\", $0)"
    let v460 : std_string_String = Fable.Core.RustInterop.emitRustExpr v12 v459 
    let v461 : string = "fable_library_rust::String_::fromString($0)"
    let v462 : string = Fable.Core.RustInterop.emitRustExpr v460 v461 
    let _run_target_args'_v458 = v462 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v463 : string = "format!(\"{:#?}\", $0)"
    let v464 : std_string_String = Fable.Core.RustInterop.emitRustExpr v12 v463 
    let v465 : string = "fable_library_rust::String_::fromString($0)"
    let v466 : string = Fable.Core.RustInterop.emitRustExpr v464 v465 
    let _run_target_args'_v458 = v466 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v467 : string = "format!(\"{:#?}\", $0)"
    let v468 : std_string_String = Fable.Core.RustInterop.emitRustExpr v12 v467 
    let v469 : string = "fable_library_rust::String_::fromString($0)"
    let v470 : string = Fable.Core.RustInterop.emitRustExpr v468 v469 
    let _run_target_args'_v458 = v470 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v472 : string = $"%A{v12}"
    let _run_target_args'_v458 = v472 
    #endif
#if FABLE_COMPILER_PYTHON
    let v476 : string = $"%A{v12}"
    let _run_target_args'_v458 = v476 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v480 : string = $"%A{v12}"
    let _run_target_args'_v458 = v480 
    #endif
#else
    let v484 : string = $"%A{v12}"
    let _run_target_args'_v458 = v484 
    #endif
    let v487 : string = _run_target_args'_v458 
    let v497 : string = $"{v487}"
    let v505 : unit = ()
    let v506 : (unit -> unit) = closure8(v19, v497)
    let v507 : unit = (fun () -> v506 (); v505) ()
    let v514 : string = $"{v138}"
    let v522 : unit = ()
    let v523 : (unit -> unit) = closure8(v19, v514)
    let v524 : unit = (fun () -> v523 (); v522) ()
    let v532 : string = "environment_variables"
    let v533 : string = $"{v532}"
    let v541 : unit = ()
    let v542 : (unit -> unit) = closure8(v19, v533)
    let v543 : unit = (fun () -> v542 (); v541) ()
    let v550 : string = $"{v60}"
    let v558 : unit = ()
    let v559 : (unit -> unit) = closure8(v19, v550)
    let v560 : unit = (fun () -> v559 (); v558) ()
    let v567 : string = $"%A{v13}"
    let v571 : string = $"{v567}"
    let v579 : unit = ()
    let v580 : (unit -> unit) = closure8(v19, v571)
    let v581 : unit = (fun () -> v580 (); v579) ()
    let v588 : string = $"{v138}"
    let v596 : unit = ()
    let v597 : (unit -> unit) = closure8(v19, v588)
    let v598 : unit = (fun () -> v597 (); v596) ()
    let v606 : string = "on_line"
    let v607 : string = $"{v606}"
    let v615 : unit = ()
    let v616 : (unit -> unit) = closure8(v19, v607)
    let v617 : unit = (fun () -> v616 (); v615) ()
    let v624 : string = $"{v60}"
    let v632 : unit = ()
    let v633 : (unit -> unit) = closure8(v19, v624)
    let v634 : unit = (fun () -> v633 (); v632) ()
    (* run_target_args'
    let v644 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v645 : string = "format!(\"{:#?}\", $0)"
    let v646 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v645 
    let v647 : string = "fable_library_rust::String_::fromString($0)"
    let v648 : string = Fable.Core.RustInterop.emitRustExpr v646 v647 
    let _run_target_args'_v644 = v648 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v649 : string = "format!(\"{:#?}\", $0)"
    let v650 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v649 
    let v651 : string = "fable_library_rust::String_::fromString($0)"
    let v652 : string = Fable.Core.RustInterop.emitRustExpr v650 v651 
    let _run_target_args'_v644 = v652 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v653 : string = "format!(\"{:#?}\", $0)"
    let v654 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v653 
    let v655 : string = "fable_library_rust::String_::fromString($0)"
    let v656 : string = Fable.Core.RustInterop.emitRustExpr v654 v655 
    let _run_target_args'_v644 = v656 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v658 : string = $"%A{v14}"
    let _run_target_args'_v644 = v658 
    #endif
#if FABLE_COMPILER_PYTHON
    let v662 : string = $"%A{v14}"
    let _run_target_args'_v644 = v662 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v666 : string = $"%A{v14}"
    let _run_target_args'_v644 = v666 
    #endif
#else
    let v670 : string = $"%A{v14}"
    let _run_target_args'_v644 = v670 
    #endif
    let v673 : string = _run_target_args'_v644 
    let v683 : string = $"{v673}"
    let v691 : unit = ()
    let v692 : (unit -> unit) = closure8(v19, v683)
    let v693 : unit = (fun () -> v692 (); v691) ()
    let v700 : string = $"{v138}"
    let v708 : unit = ()
    let v709 : (unit -> unit) = closure8(v19, v700)
    let v710 : unit = (fun () -> v709 (); v708) ()
    let v718 : string = "stdin"
    let v719 : string = $"{v718}"
    let v727 : unit = ()
    let v728 : (unit -> unit) = closure8(v19, v719)
    let v729 : unit = (fun () -> v728 (); v727) ()
    let v736 : string = $"{v60}"
    let v744 : unit = ()
    let v745 : (unit -> unit) = closure8(v19, v736)
    let v746 : unit = (fun () -> v745 (); v744) ()
    (* run_target_args'
    let v756 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v757 : string = "format!(\"{:#?}\", $0)"
    let v758 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v757 
    let v759 : string = "fable_library_rust::String_::fromString($0)"
    let v760 : string = Fable.Core.RustInterop.emitRustExpr v758 v759 
    let _run_target_args'_v756 = v760 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v761 : string = "format!(\"{:#?}\", $0)"
    let v762 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v761 
    let v763 : string = "fable_library_rust::String_::fromString($0)"
    let v764 : string = Fable.Core.RustInterop.emitRustExpr v762 v763 
    let _run_target_args'_v756 = v764 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v765 : string = "format!(\"{:#?}\", $0)"
    let v766 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v765 
    let v767 : string = "fable_library_rust::String_::fromString($0)"
    let v768 : string = Fable.Core.RustInterop.emitRustExpr v766 v767 
    let _run_target_args'_v756 = v768 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v770 : string = $"%A{v15}"
    let _run_target_args'_v756 = v770 
    #endif
#if FABLE_COMPILER_PYTHON
    let v774 : string = $"%A{v15}"
    let _run_target_args'_v756 = v774 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v778 : string = $"%A{v15}"
    let _run_target_args'_v756 = v778 
    #endif
#else
    let v782 : string = $"%A{v15}"
    let _run_target_args'_v756 = v782 
    #endif
    let v785 : string = _run_target_args'_v756 
    let v795 : string = $"{v785}"
    let v803 : unit = ()
    let v804 : (unit -> unit) = closure8(v19, v795)
    let v805 : unit = (fun () -> v804 (); v803) ()
    let v812 : string = $"{v138}"
    let v820 : unit = ()
    let v821 : (unit -> unit) = closure8(v19, v812)
    let v822 : unit = (fun () -> v821 (); v820) ()
    let v830 : string = "trace"
    let v831 : string = $"{v830}"
    let v839 : unit = ()
    let v840 : (unit -> unit) = closure8(v19, v831)
    let v841 : unit = (fun () -> v840 (); v839) ()
    let v848 : string = $"{v60}"
    let v856 : unit = ()
    let v857 : (unit -> unit) = closure8(v19, v848)
    let v858 : unit = (fun () -> v857 (); v856) ()
    let v866 : string =
        if v16 then
            let v864 : string = "true"
            v864
        else
            let v865 : string = "false"
            v865
    let v868 : string = $"{v866}"
    let v876 : unit = ()
    let v877 : (unit -> unit) = closure8(v19, v868)
    let v878 : unit = (fun () -> v877 (); v876) ()
    let v885 : string = $"{v138}"
    let v893 : unit = ()
    let v894 : (unit -> unit) = closure8(v19, v885)
    let v895 : unit = (fun () -> v894 (); v893) ()
    let v903 : string = "working_directory"
    let v904 : string = $"{v903}"
    let v912 : unit = ()
    let v913 : (unit -> unit) = closure8(v19, v904)
    let v914 : unit = (fun () -> v913 (); v912) ()
    let v921 : string = $"{v60}"
    let v929 : unit = ()
    let v930 : (unit -> unit) = closure8(v19, v921)
    let v931 : unit = (fun () -> v930 (); v929) ()
    (* run_target_args'
    let v941 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v942 : string = "format!(\"{:#?}\", $0)"
    let v943 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v942 
    let v944 : string = "fable_library_rust::String_::fromString($0)"
    let v945 : string = Fable.Core.RustInterop.emitRustExpr v943 v944 
    let _run_target_args'_v941 = v945 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v946 : string = "format!(\"{:#?}\", $0)"
    let v947 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v946 
    let v948 : string = "fable_library_rust::String_::fromString($0)"
    let v949 : string = Fable.Core.RustInterop.emitRustExpr v947 v948 
    let _run_target_args'_v941 = v949 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v950 : string = "format!(\"{:#?}\", $0)"
    let v951 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v950 
    let v952 : string = "fable_library_rust::String_::fromString($0)"
    let v953 : string = Fable.Core.RustInterop.emitRustExpr v951 v952 
    let _run_target_args'_v941 = v953 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v955 : string = $"%A{v17}"
    let _run_target_args'_v941 = v955 
    #endif
#if FABLE_COMPILER_PYTHON
    let v959 : string = $"%A{v17}"
    let _run_target_args'_v941 = v959 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v963 : string = $"%A{v17}"
    let _run_target_args'_v941 = v963 
    #endif
#else
    let v967 : string = $"%A{v17}"
    let _run_target_args'_v941 = v967 
    #endif
    let v970 : string = _run_target_args'_v941 
    let v980 : string = $"{v970}"
    let v988 : unit = ()
    let v989 : (unit -> unit) = closure8(v19, v980)
    let v990 : unit = (fun () -> v989 (); v988) ()
    let v998 : string = " }"
    let v999 : string = $"{v998}"
    let v1007 : unit = ()
    let v1008 : (unit -> unit) = closure8(v19, v999)
    let v1009 : unit = (fun () -> v1008 (); v1007) ()
    let v1016 : string = $"{v998}"
    let v1024 : unit = ()
    let v1025 : (unit -> unit) = closure8(v19, v1016)
    let v1026 : unit = (fun () -> v1025 (); v1024) ()
    let v1032 : string = v19.l0
    let v1033 : int64 = v0.l0
    let v1036 : string = " "
    let v1037 : string = v6 + v1036 
    let v1041 : string = v1037 + v7 
    let v1046 : string = " #"
    let v1047 : string = v1041 + v1046 
    let v1051 : (int64 -> string) = _.ToString()
    let v1052 : string = v1051 v1033
    let v1056 : string = v1047 + v1052 
    let v1060 : string = v1056 + v1036 
    let v1065 : string = "runtime.execute_with_options / output error"
    let v1066 : string = v1060 + v1065 
    let v1071 : string = " / "
    let v1072 : string = v1066 + v1071 
    let v1076 : string = v1072 + v1032 
    method16(v1076)
and closure58 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : string, v8 : Vec<std_string_String>, v9 : std_string_String) () : unit =
    let v10 : US0 = US0_4
    let v11 : bool = method7(v10)
    if v11 then
        let v26 : unit = ()
        let v27 : (unit -> unit) = closure6()
        let v28 : unit = (fun () -> v27 (); v26) ()
        let struct (v49 : Mut0, v50 : Mut1, v51 : Mut2, v52 : Mut3, v53 : Mut4, v54 : int64 option) = TraceState.trace_state.Value
        let v67 : string = method8(v49, v50, v51, v52, v53, v54)
        let v68 : string = method70()
        let v70 : string = $"%A{v8}"
        let v73 : string = method123(v49, v50, v51, v52, v53, v54, v67, v68, v9, v7, v70, v0, v1, v2, v3, v4, v5, v6)
        method17(v73)
and closure59 () (v0 : int32) : US30 =
    US30_0(v0)
and method124 () : (int32 -> US30) =
    closure59()
and method125 () : string =
    let v0 : string = "\n"
    v0
and method126 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32) : string =
    let v10 : string = method13()
    let v11 : Mut3 = {l0 = v10} : Mut3
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure8(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "exit_code"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure8(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure8(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{v8}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure8(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure8(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "std_trace_length"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure8(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure8(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v9}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure8(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v166 : string = " }"
    let v167 : string = $"{v166}"
    let v175 : unit = ()
    let v176 : (unit -> unit) = closure8(v11, v167)
    let v177 : unit = (fun () -> v176 (); v175) ()
    let v183 : string = v11.l0
    let v184 : int64 = v0.l0
    let v187 : string = " "
    let v188 : string = v6 + v187 
    let v192 : string = v188 + v7 
    let v197 : string = " #"
    let v198 : string = v192 + v197 
    let v202 : (int64 -> string) = _.ToString()
    let v203 : string = v202 v184
    let v207 : string = v198 + v203 
    let v211 : string = v207 + v187 
    let v216 : string = "runtime.execute_with_options / result"
    let v217 : string = v211 + v216 
    let v222 : string = " / "
    let v223 : string = v217 + v222 
    let v227 : string = v223 + v183 
    method16(v227)
and closure60 (v0 : int32, v1 : string) () : unit =
    let v2 : US0 = US0_0
    let v3 : bool = method7(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure6()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut0, v42 : Mut1, v43 : Mut2, v44 : Mut3, v45 : Mut4, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method8(v41, v42, v43, v44, v45, v46)
        let v60 : string = method113()
        let v61 : int32 = v1.Length
        let v62 : string = method126(v41, v42, v43, v44, v45, v46, v59, v60, v0, v61)
        method17(v62)
and method129 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : US5, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option) : string =
    let v17 : string = method13()
    let v18 : Mut3 = {l0 = v17} : Mut3
    let v21 : string = "{ "
    let v22 : string = $"{v21}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure8(v18, v22)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v40 : string = "file_name"
    let v41 : string = $"{v40}"
    let v49 : unit = ()
    let v50 : (unit -> unit) = closure8(v18, v41)
    let v51 : unit = (fun () -> v50 (); v49) ()
    let v59 : string = " = "
    let v60 : string = $"{v59}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure8(v18, v60)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v77 : string = $"{v8}"
    let v85 : unit = ()
    let v86 : (unit -> unit) = closure8(v18, v77)
    let v87 : unit = (fun () -> v86 (); v85) ()
    let v95 : string = "; "
    let v96 : string = $"{v95}"
    let v104 : unit = ()
    let v105 : (unit -> unit) = closure8(v18, v96)
    let v106 : unit = (fun () -> v105 (); v104) ()
    let v114 : string = "arguments"
    let v115 : string = $"{v114}"
    let v123 : unit = ()
    let v124 : (unit -> unit) = closure8(v18, v115)
    let v125 : unit = (fun () -> v124 (); v123) ()
    let v132 : string = $"{v59}"
    let v140 : unit = ()
    let v141 : (unit -> unit) = closure8(v18, v132)
    let v142 : unit = (fun () -> v141 (); v140) ()
    let v149 : string = $"%A{v9}"
    let v153 : string = $"{v149}"
    let v161 : unit = ()
    let v162 : (unit -> unit) = closure8(v18, v153)
    let v163 : unit = (fun () -> v162 (); v161) ()
    let v170 : string = $"{v95}"
    let v178 : unit = ()
    let v179 : (unit -> unit) = closure8(v18, v170)
    let v180 : unit = (fun () -> v179 (); v178) ()
    let v188 : string = "options"
    let v189 : string = $"{v188}"
    let v197 : unit = ()
    let v198 : (unit -> unit) = closure8(v18, v189)
    let v199 : unit = (fun () -> v198 (); v197) ()
    let v206 : string = $"{v59}"
    let v214 : unit = ()
    let v215 : (unit -> unit) = closure8(v18, v206)
    let v216 : unit = (fun () -> v215 (); v214) ()
    let v223 : string = $"{v21}"
    let v231 : unit = ()
    let v232 : (unit -> unit) = closure8(v18, v223)
    let v233 : unit = (fun () -> v232 (); v231) ()
    let v241 : string = "command"
    let v242 : string = $"{v241}"
    let v250 : unit = ()
    let v251 : (unit -> unit) = closure8(v18, v242)
    let v252 : unit = (fun () -> v251 (); v250) ()
    let v259 : string = $"{v59}"
    let v267 : unit = ()
    let v268 : (unit -> unit) = closure8(v18, v259)
    let v269 : unit = (fun () -> v268 (); v267) ()
    let v276 : string = $"{v10}"
    let v284 : unit = ()
    let v285 : (unit -> unit) = closure8(v18, v276)
    let v286 : unit = (fun () -> v285 (); v284) ()
    let v293 : string = $"{v95}"
    let v301 : unit = ()
    let v302 : (unit -> unit) = closure8(v18, v293)
    let v303 : unit = (fun () -> v302 (); v301) ()
    let v311 : string = "cancellation_token"
    let v312 : string = $"{v311}"
    let v320 : unit = ()
    let v321 : (unit -> unit) = closure8(v18, v312)
    let v322 : unit = (fun () -> v321 (); v320) ()
    let v329 : string = $"{v59}"
    let v337 : unit = ()
    let v338 : (unit -> unit) = closure8(v18, v329)
    let v339 : unit = (fun () -> v338 (); v337) ()
    (* run_target_args'
    let v349 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v350 : string = "format!(\"{:#?}\", $0)"
    let v351 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v350 
    let v352 : string = "fable_library_rust::String_::fromString($0)"
    let v353 : string = Fable.Core.RustInterop.emitRustExpr v351 v352 
    let _run_target_args'_v349 = v353 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v354 : string = "format!(\"{:#?}\", $0)"
    let v355 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v354 
    let v356 : string = "fable_library_rust::String_::fromString($0)"
    let v357 : string = Fable.Core.RustInterop.emitRustExpr v355 v356 
    let _run_target_args'_v349 = v357 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v358 : string = "format!(\"{:#?}\", $0)"
    let v359 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v358 
    let v360 : string = "fable_library_rust::String_::fromString($0)"
    let v361 : string = Fable.Core.RustInterop.emitRustExpr v359 v360 
    let _run_target_args'_v349 = v361 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v363 : string = $"%A{v11}"
    let _run_target_args'_v349 = v363 
    #endif
#if FABLE_COMPILER_PYTHON
    let v367 : string = $"%A{v11}"
    let _run_target_args'_v349 = v367 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v371 : string = $"%A{v11}"
    let _run_target_args'_v349 = v371 
    #endif
#else
    let v375 : string = $"%A{v11}"
    let _run_target_args'_v349 = v375 
    #endif
    let v378 : string = _run_target_args'_v349 
    let v388 : string = $"{v378}"
    let v396 : unit = ()
    let v397 : (unit -> unit) = closure8(v18, v388)
    let v398 : unit = (fun () -> v397 (); v396) ()
    let v405 : string = $"{v95}"
    let v413 : unit = ()
    let v414 : (unit -> unit) = closure8(v18, v405)
    let v415 : unit = (fun () -> v414 (); v413) ()
    let v423 : string = "environment_variables"
    let v424 : string = $"{v423}"
    let v432 : unit = ()
    let v433 : (unit -> unit) = closure8(v18, v424)
    let v434 : unit = (fun () -> v433 (); v432) ()
    let v441 : string = $"{v59}"
    let v449 : unit = ()
    let v450 : (unit -> unit) = closure8(v18, v441)
    let v451 : unit = (fun () -> v450 (); v449) ()
    let v458 : string = $"%A{v12}"
    let v462 : string = $"{v458}"
    let v470 : unit = ()
    let v471 : (unit -> unit) = closure8(v18, v462)
    let v472 : unit = (fun () -> v471 (); v470) ()
    let v479 : string = $"{v95}"
    let v487 : unit = ()
    let v488 : (unit -> unit) = closure8(v18, v479)
    let v489 : unit = (fun () -> v488 (); v487) ()
    let v497 : string = "on_line"
    let v498 : string = $"{v497}"
    let v506 : unit = ()
    let v507 : (unit -> unit) = closure8(v18, v498)
    let v508 : unit = (fun () -> v507 (); v506) ()
    let v515 : string = $"{v59}"
    let v523 : unit = ()
    let v524 : (unit -> unit) = closure8(v18, v515)
    let v525 : unit = (fun () -> v524 (); v523) ()
    (* run_target_args'
    let v535 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v536 : string = "format!(\"{:#?}\", $0)"
    let v537 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v536 
    let v538 : string = "fable_library_rust::String_::fromString($0)"
    let v539 : string = Fable.Core.RustInterop.emitRustExpr v537 v538 
    let _run_target_args'_v535 = v539 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v540 : string = "format!(\"{:#?}\", $0)"
    let v541 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v540 
    let v542 : string = "fable_library_rust::String_::fromString($0)"
    let v543 : string = Fable.Core.RustInterop.emitRustExpr v541 v542 
    let _run_target_args'_v535 = v543 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v544 : string = "format!(\"{:#?}\", $0)"
    let v545 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v544 
    let v546 : string = "fable_library_rust::String_::fromString($0)"
    let v547 : string = Fable.Core.RustInterop.emitRustExpr v545 v546 
    let _run_target_args'_v535 = v547 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v549 : string = $"%A{v13}"
    let _run_target_args'_v535 = v549 
    #endif
#if FABLE_COMPILER_PYTHON
    let v553 : string = $"%A{v13}"
    let _run_target_args'_v535 = v553 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v557 : string = $"%A{v13}"
    let _run_target_args'_v535 = v557 
    #endif
#else
    let v561 : string = $"%A{v13}"
    let _run_target_args'_v535 = v561 
    #endif
    let v564 : string = _run_target_args'_v535 
    let v574 : string = $"{v564}"
    let v582 : unit = ()
    let v583 : (unit -> unit) = closure8(v18, v574)
    let v584 : unit = (fun () -> v583 (); v582) ()
    let v591 : string = $"{v95}"
    let v599 : unit = ()
    let v600 : (unit -> unit) = closure8(v18, v591)
    let v601 : unit = (fun () -> v600 (); v599) ()
    let v609 : string = "stdin"
    let v610 : string = $"{v609}"
    let v618 : unit = ()
    let v619 : (unit -> unit) = closure8(v18, v610)
    let v620 : unit = (fun () -> v619 (); v618) ()
    let v627 : string = $"{v59}"
    let v635 : unit = ()
    let v636 : (unit -> unit) = closure8(v18, v627)
    let v637 : unit = (fun () -> v636 (); v635) ()
    (* run_target_args'
    let v647 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v648 : string = "format!(\"{:#?}\", $0)"
    let v649 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v648 
    let v650 : string = "fable_library_rust::String_::fromString($0)"
    let v651 : string = Fable.Core.RustInterop.emitRustExpr v649 v650 
    let _run_target_args'_v647 = v651 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v652 : string = "format!(\"{:#?}\", $0)"
    let v653 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v652 
    let v654 : string = "fable_library_rust::String_::fromString($0)"
    let v655 : string = Fable.Core.RustInterop.emitRustExpr v653 v654 
    let _run_target_args'_v647 = v655 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v656 : string = "format!(\"{:#?}\", $0)"
    let v657 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v656 
    let v658 : string = "fable_library_rust::String_::fromString($0)"
    let v659 : string = Fable.Core.RustInterop.emitRustExpr v657 v658 
    let _run_target_args'_v647 = v659 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v661 : string = $"%A{v14}"
    let _run_target_args'_v647 = v661 
    #endif
#if FABLE_COMPILER_PYTHON
    let v665 : string = $"%A{v14}"
    let _run_target_args'_v647 = v665 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v669 : string = $"%A{v14}"
    let _run_target_args'_v647 = v669 
    #endif
#else
    let v673 : string = $"%A{v14}"
    let _run_target_args'_v647 = v673 
    #endif
    let v676 : string = _run_target_args'_v647 
    let v686 : string = $"{v676}"
    let v694 : unit = ()
    let v695 : (unit -> unit) = closure8(v18, v686)
    let v696 : unit = (fun () -> v695 (); v694) ()
    let v703 : string = $"{v95}"
    let v711 : unit = ()
    let v712 : (unit -> unit) = closure8(v18, v703)
    let v713 : unit = (fun () -> v712 (); v711) ()
    let v721 : string = "trace"
    let v722 : string = $"{v721}"
    let v730 : unit = ()
    let v731 : (unit -> unit) = closure8(v18, v722)
    let v732 : unit = (fun () -> v731 (); v730) ()
    let v739 : string = $"{v59}"
    let v747 : unit = ()
    let v748 : (unit -> unit) = closure8(v18, v739)
    let v749 : unit = (fun () -> v748 (); v747) ()
    let v757 : string =
        if v15 then
            let v755 : string = "true"
            v755
        else
            let v756 : string = "false"
            v756
    let v759 : string = $"{v757}"
    let v767 : unit = ()
    let v768 : (unit -> unit) = closure8(v18, v759)
    let v769 : unit = (fun () -> v768 (); v767) ()
    let v776 : string = $"{v95}"
    let v784 : unit = ()
    let v785 : (unit -> unit) = closure8(v18, v776)
    let v786 : unit = (fun () -> v785 (); v784) ()
    let v794 : string = "working_directory"
    let v795 : string = $"{v794}"
    let v803 : unit = ()
    let v804 : (unit -> unit) = closure8(v18, v795)
    let v805 : unit = (fun () -> v804 (); v803) ()
    let v812 : string = $"{v59}"
    let v820 : unit = ()
    let v821 : (unit -> unit) = closure8(v18, v812)
    let v822 : unit = (fun () -> v821 (); v820) ()
    (* run_target_args'
    let v832 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v833 : string = "format!(\"{:#?}\", $0)"
    let v834 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v833 
    let v835 : string = "fable_library_rust::String_::fromString($0)"
    let v836 : string = Fable.Core.RustInterop.emitRustExpr v834 v835 
    let _run_target_args'_v832 = v836 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v837 : string = "format!(\"{:#?}\", $0)"
    let v838 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v837 
    let v839 : string = "fable_library_rust::String_::fromString($0)"
    let v840 : string = Fable.Core.RustInterop.emitRustExpr v838 v839 
    let _run_target_args'_v832 = v840 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v841 : string = "format!(\"{:#?}\", $0)"
    let v842 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v841 
    let v843 : string = "fable_library_rust::String_::fromString($0)"
    let v844 : string = Fable.Core.RustInterop.emitRustExpr v842 v843 
    let _run_target_args'_v832 = v844 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v846 : string = $"%A{v16}"
    let _run_target_args'_v832 = v846 
    #endif
#if FABLE_COMPILER_PYTHON
    let v850 : string = $"%A{v16}"
    let _run_target_args'_v832 = v850 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v854 : string = $"%A{v16}"
    let _run_target_args'_v832 = v854 
    #endif
#else
    let v858 : string = $"%A{v16}"
    let _run_target_args'_v832 = v858 
    #endif
    let v861 : string = _run_target_args'_v832 
    let v871 : string = $"{v861}"
    let v879 : unit = ()
    let v880 : (unit -> unit) = closure8(v18, v871)
    let v881 : unit = (fun () -> v880 (); v879) ()
    let v889 : string = " }"
    let v890 : string = $"{v889}"
    let v898 : unit = ()
    let v899 : (unit -> unit) = closure8(v18, v890)
    let v900 : unit = (fun () -> v899 (); v898) ()
    let v907 : string = $"{v889}"
    let v915 : unit = ()
    let v916 : (unit -> unit) = closure8(v18, v907)
    let v917 : unit = (fun () -> v916 (); v915) ()
    let v923 : string = v18.l0
    let v924 : int64 = v0.l0
    let v927 : string = " "
    let v928 : string = v6 + v927 
    let v932 : string = v928 + v7 
    let v937 : string = " #"
    let v938 : string = v932 + v937 
    let v942 : (int64 -> string) = _.ToString()
    let v943 : string = v942 v924
    let v947 : string = v938 + v943 
    let v951 : string = v947 + v927 
    let v956 : string = "runtime.execute_with_options_async"
    let v957 : string = v951 + v956 
    let v962 : string = " / "
    let v963 : string = v957 + v962 
    let v967 : string = v963 + v923 
    method16(v967)
and closure61 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : US5, v8 : string) () : unit =
    let v9 : US0 = US0_1
    let v10 : bool = method7(v9)
    if v10 then
        let v25 : unit = ()
        let v26 : (unit -> unit) = closure6()
        let v27 : unit = (fun () -> v26 (); v25) ()
        let struct (v48 : Mut0, v49 : Mut1, v50 : Mut2, v51 : Mut3, v52 : Mut4, v53 : int64 option) = TraceState.trace_state.Value
        let v66 : string = method8(v48, v49, v50, v51, v52, v53)
        let v67 : string = method61()
        let v68 : string = method129(v48, v49, v50, v51, v52, v53, v66, v67, v8, v7, v0, v1, v2, v3, v4, v5, v6)
        method17(v68)
and method130 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : (struct (string * string) []) =
    v2
and method133 (v0 : System.Diagnostics.DataReceivedEventArgs) : string =
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
and closure63 () (v0 : (struct (int32 * string * bool) -> Async<unit>)) : US31 =
    US31_0(v0)
and method134 () : ((struct (int32 * string * bool) -> Async<unit>) -> US31) =
    closure63()
and method135 (v0 : System.Diagnostics.Process) : int32 =
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
and closure64 (v0 : string) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method7(v1)
    if v2 then
        let v17 : unit = ()
        let v18 : (unit -> unit) = closure6()
        let v19 : unit = (fun () -> v18 (); v17) ()
        let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
        let v58 : string = method8(v40, v41, v42, v43, v44, v45)
        let v59 : string = method113()
        let v60 : bool = v0 = ""
        let v63 : string =
            if v60 then
                let v61 : string = ""
                v61
            else
                method114(v40, v41, v42, v43, v44, v45, v58, v59, v0)
        method17(v63)
and method132 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>, v9 : bool, v10 : System.Diagnostics.DataReceivedEventArgs) : Async<unit> =
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
            let v2424 : string = method133(v10)
            let v2426 : string = null |> unbox<string>
            let v2429 : bool = v2424 = v2426
            let v2430 : bool = v2429 <> true
            if v2430 then
                let v2433 : ((struct (int32 * string * bool) -> Async<unit>) -> US31) = method134()
                let v2434 : US31 option = v3 |> Option.map v2433 
                let v2454 : US31 = US31_1
                let v2455 : US31 = v2434 |> Option.defaultValue v2454 
                match v2455 with
                | US31_1 -> (* None *)
                    ()
                | US31_0(v2459) -> (* Some *)
                    let v2460 : int32 = method135(v7)
                    let v2461 : Async<unit> = v2459 struct (v2460, v2424, v9)
                    do! v2461 
                    ()
                let v2464 : string =
                    if v9 then
                        let v2462 : string = $"! {v2424}"
                        v2462
                    else
                        let v2463 : string = $"> {v2424}"
                        v2463
                if v5 then
                    let v2528 : unit = ()
                    let v2529 : (unit -> unit) = closure64(v2464)
                    let v2530 : unit = (fun () -> v2529 (); v2528) ()
                    ()
                else
                    let v2595 : unit = ()
                    let v2596 : (unit -> unit) = closure11(v2464)
                    let v2597 : unit = (fun () -> v2596 (); v2595) ()
                    ()
                let v2601 : string =
                    if v9 then
                        let v2599 : string = "\u001b[7;4m"
                        v2599
                    else
                        let v2600 : string = ""
                        v2600
                let v2604 : string =
                    if v9 then
                        let v2602 : string = "\u001b[0m"
                        v2602
                    else
                        let v2603 : string = ""
                        v2603
                let v2605 : string = $"{v2601}{v2424}{v2604}"
                (* run_target_args'
                let v2606 : unit = ()
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
                let v2607 : (string -> unit) = v8.Push
                v2607 v2605
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
    let v5000 : Async<unit> = _let'_v29 
    let _run_target_args'_v15 = v5000 
    #endif
#if FABLE_COMPILER_PYTHON
    let v5002 : unit = ()
    let _let'_v5002 =
        async {
            let v7397 : string = method133(v10)
            let v7399 : string = null |> unbox<string>
            let v7402 : bool = v7397 = v7399
            let v7403 : bool = v7402 <> true
            if v7403 then
                let v7406 : ((struct (int32 * string * bool) -> Async<unit>) -> US31) = method134()
                let v7407 : US31 option = v3 |> Option.map v7406 
                let v7427 : US31 = US31_1
                let v7428 : US31 = v7407 |> Option.defaultValue v7427 
                match v7428 with
                | US31_1 -> (* None *)
                    ()
                | US31_0(v7432) -> (* Some *)
                    let v7433 : int32 = method135(v7)
                    let v7434 : Async<unit> = v7432 struct (v7433, v7397, v9)
                    do! v7434 
                    ()
                let v7437 : string =
                    if v9 then
                        let v7435 : string = $"! {v7397}"
                        v7435
                    else
                        let v7436 : string = $"> {v7397}"
                        v7436
                if v5 then
                    let v7501 : unit = ()
                    let v7502 : (unit -> unit) = closure64(v7437)
                    let v7503 : unit = (fun () -> v7502 (); v7501) ()
                    ()
                else
                    let v7568 : unit = ()
                    let v7569 : (unit -> unit) = closure11(v7437)
                    let v7570 : unit = (fun () -> v7569 (); v7568) ()
                    ()
                let v7574 : string =
                    if v9 then
                        let v7572 : string = "\u001b[7;4m"
                        v7572
                    else
                        let v7573 : string = ""
                        v7573
                let v7577 : string =
                    if v9 then
                        let v7575 : string = "\u001b[0m"
                        v7575
                    else
                        let v7576 : string = ""
                        v7576
                let v7578 : string = $"{v7574}{v7397}{v7577}"
                (* run_target_args'
                let v7579 : unit = ()
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
                let v7580 : (string -> unit) = v8.Push
                v7580 v7578
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
    let v9973 : Async<unit> = _let'_v5002 
    let _run_target_args'_v15 = v9973 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v9975 : unit = ()
    let _let'_v9975 =
        async {
            let v12370 : string = method133(v10)
            let v12372 : string = null |> unbox<string>
            let v12375 : bool = v12370 = v12372
            let v12376 : bool = v12375 <> true
            if v12376 then
                let v12379 : ((struct (int32 * string * bool) -> Async<unit>) -> US31) = method134()
                let v12380 : US31 option = v3 |> Option.map v12379 
                let v12400 : US31 = US31_1
                let v12401 : US31 = v12380 |> Option.defaultValue v12400 
                match v12401 with
                | US31_1 -> (* None *)
                    ()
                | US31_0(v12405) -> (* Some *)
                    let v12406 : int32 = method135(v7)
                    let v12407 : Async<unit> = v12405 struct (v12406, v12370, v9)
                    do! v12407 
                    ()
                let v12410 : string =
                    if v9 then
                        let v12408 : string = $"! {v12370}"
                        v12408
                    else
                        let v12409 : string = $"> {v12370}"
                        v12409
                if v5 then
                    let v12474 : unit = ()
                    let v12475 : (unit -> unit) = closure64(v12410)
                    let v12476 : unit = (fun () -> v12475 (); v12474) ()
                    ()
                else
                    let v12541 : unit = ()
                    let v12542 : (unit -> unit) = closure11(v12410)
                    let v12543 : unit = (fun () -> v12542 (); v12541) ()
                    ()
                let v12547 : string =
                    if v9 then
                        let v12545 : string = "\u001b[7;4m"
                        v12545
                    else
                        let v12546 : string = ""
                        v12546
                let v12550 : string =
                    if v9 then
                        let v12548 : string = "\u001b[0m"
                        v12548
                    else
                        let v12549 : string = ""
                        v12549
                let v12551 : string = $"{v12547}{v12370}{v12550}"
                (* run_target_args'
                let v12552 : unit = ()
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
                let v12553 : (string -> unit) = v8.Push
                v12553 v12551
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
    let v14946 : Async<unit> = _let'_v9975 
    let _run_target_args'_v15 = v14946 
    #endif
#else
    let v14948 : unit = ()
    let _let'_v14948 =
        async {
            let v17343 : string = method133(v10)
            let v17345 : string = null |> unbox<string>
            let v17348 : bool = v17343 = v17345
            let v17349 : bool = v17348 <> true
            if v17349 then
                let v17352 : ((struct (int32 * string * bool) -> Async<unit>) -> US31) = method134()
                let v17353 : US31 option = v3 |> Option.map v17352 
                let v17373 : US31 = US31_1
                let v17374 : US31 = v17353 |> Option.defaultValue v17373 
                match v17374 with
                | US31_1 -> (* None *)
                    ()
                | US31_0(v17378) -> (* Some *)
                    let v17379 : int32 = method135(v7)
                    let v17380 : Async<unit> = v17378 struct (v17379, v17343, v9)
                    do! v17380 
                    ()
                let v17383 : string =
                    if v9 then
                        let v17381 : string = $"! {v17343}"
                        v17381
                    else
                        let v17382 : string = $"> {v17343}"
                        v17382
                if v5 then
                    let v17447 : unit = ()
                    let v17448 : (unit -> unit) = closure64(v17383)
                    let v17449 : unit = (fun () -> v17448 (); v17447) ()
                    ()
                else
                    let v17514 : unit = ()
                    let v17515 : (unit -> unit) = closure11(v17383)
                    let v17516 : unit = (fun () -> v17515 (); v17514) ()
                    ()
                let v17520 : string =
                    if v9 then
                        let v17518 : string = "\u001b[7;4m"
                        v17518
                    else
                        let v17519 : string = ""
                        v17519
                let v17523 : string =
                    if v9 then
                        let v17521 : string = "\u001b[0m"
                        v17521
                    else
                        let v17522 : string = ""
                        v17522
                let v17524 : string = $"{v17520}{v17343}{v17523}"
                (* run_target_args'
                let v17525 : unit = ()
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
                let v17526 : (string -> unit) = v8.Push
                v17526 v17524
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
    let v19919 : Async<unit> = _let'_v14948 
    let _run_target_args'_v15 = v19919 
    #endif
    let v19920 : Async<unit> = _run_target_args'_v15 
    v19920
and method131 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>, v9 : bool, v10 : System.Diagnostics.DataReceivedEventArgs) : Async<unit> =
    method132(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
and closure62 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>, v9 : bool) (v10 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v11 : Async<unit> = method131(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
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
and closure65 () (v0 : System.Threading.CancellationToken) : US32 =
    US32_0(v0)
and method136 () : (System.Threading.CancellationToken -> US32) =
    closure65()
and method137 (v0 : System.Threading.CancellationToken) : Async<System.Threading.CancellationToken> =
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
            let v598 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v600 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v600 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v604 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v604 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v608 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v608 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v612 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v612 
            #endif
#if FABLE_COMPILER_PYTHON
            let v616 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v616 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v620 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v620 
            #endif
#else
            let v623 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v623 = v623 
            let v624 : System.Threading.CancellationToken = v623 
            let v625 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v626 : (System.Threading.CancellationToken []) = [|v624; v625; v0|]
            let v627 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v628 : System.Threading.CancellationTokenSource = v627 v626
            let v629 : System.Threading.CancellationToken = v628.Token
            return v629 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1210 : Async<System.Threading.CancellationToken> = _let'_v19 
    let _run_target_args'_v5 = v1210 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1212 : unit = ()
    let _let'_v1212 =
        async {
            (* run_target_args'
            let v1791 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1793 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1793 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1797 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1797 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1801 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1801 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1805 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1805 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1809 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1809 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1813 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1813 
            #endif
#else
            let v1816 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v1816 = v1816 
            let v1817 : System.Threading.CancellationToken = v1816 
            let v1818 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v1819 : (System.Threading.CancellationToken []) = [|v1817; v1818; v0|]
            let v1820 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v1821 : System.Threading.CancellationTokenSource = v1820 v1819
            let v1822 : System.Threading.CancellationToken = v1821.Token
            return v1822 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2403 : Async<System.Threading.CancellationToken> = _let'_v1212 
    let _run_target_args'_v5 = v2403 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v2405 : unit = ()
    let _let'_v2405 =
        async {
            (* run_target_args'
            let v2984 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2986 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v2986 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2990 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v2990 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2994 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v2994 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2998 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v2998 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3002 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v3002 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3006 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v3006 
            #endif
#else
            let v3009 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v3009 = v3009 
            let v3010 : System.Threading.CancellationToken = v3009 
            let v3011 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v3012 : (System.Threading.CancellationToken []) = [|v3010; v3011; v0|]
            let v3013 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v3014 : System.Threading.CancellationTokenSource = v3013 v3012
            let v3015 : System.Threading.CancellationToken = v3014.Token
            return v3015 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v3596 : Async<System.Threading.CancellationToken> = _let'_v2405 
    let _run_target_args'_v5 = v3596 
    #endif
#else
    let v3598 : unit = ()
    let _let'_v3598 =
        async {
            (* run_target_args'
            let v4177 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v4179 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v4179 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v4183 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v4183 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v4187 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v4187 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v4191 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v4191 
            #endif
#if FABLE_COMPILER_PYTHON
            let v4195 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v4195 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v4199 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v4199 
            #endif
#else
            let v4202 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v4202 = v4202 
            let v4203 : System.Threading.CancellationToken = v4202 
            let v4204 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v4205 : (System.Threading.CancellationToken []) = [|v4203; v4204; v0|]
            let v4206 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v4207 : System.Threading.CancellationTokenSource = v4206 v4205
            let v4208 : System.Threading.CancellationToken = v4207.Token
            return v4208 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v4789 : Async<System.Threading.CancellationToken> = _let'_v3598 
    let _run_target_args'_v5 = v4789 
    #endif
    let v4790 : Async<System.Threading.CancellationToken> = _run_target_args'_v5 
    v4790
and method138 (v0 : System.Diagnostics.Process) : bool =
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
and method139 (v0 : System.Diagnostics.Process) : unit =
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
and closure66 (v0 : System.Diagnostics.Process) () : unit =
    let v1 : bool = method138(v0)
    let v2 : bool = v1 = false
    if v2 then
        method139(v0)
and method141 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : System.Threading.Tasks.TaskCanceledException) : string =
    let v9 : string = method13()
    let v10 : Mut3 = {l0 = v9} : Mut3
    let v13 : string = "{ "
    let v14 : string = $"{v13}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure8(v10, v14)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v32 : string = "ex"
    let v33 : string = $"{v32}"
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure8(v10, v33)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v51 : string = " = "
    let v52 : string = $"{v51}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure8(v10, v52)
    let v62 : unit = (fun () -> v61 (); v60) ()
    (* run_target_args'
    let v72 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v73 : string = "format!(\"{:#?}\", $0)"
    let v74 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v73 
    let v75 : string = "fable_library_rust::String_::fromString($0)"
    let v76 : string = Fable.Core.RustInterop.emitRustExpr v74 v75 
    let _run_target_args'_v72 = v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : string = "format!(\"{:#?}\", $0)"
    let v78 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v77 
    let v79 : string = "fable_library_rust::String_::fromString($0)"
    let v80 : string = Fable.Core.RustInterop.emitRustExpr v78 v79 
    let _run_target_args'_v72 = v80 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : string = "format!(\"{:#?}\", $0)"
    let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v81 
    let v83 : string = "fable_library_rust::String_::fromString($0)"
    let v84 : string = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let _run_target_args'_v72 = v84 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v86 : string = $"%A{v8}"
    let _run_target_args'_v72 = v86 
    #endif
#if FABLE_COMPILER_PYTHON
    let v90 : string = $"%A{v8}"
    let _run_target_args'_v72 = v90 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v94 : string = $"%A{v8}"
    let _run_target_args'_v72 = v94 
    #endif
#else
    let v98 : string = $"%A{v8}"
    let _run_target_args'_v72 = v98 
    #endif
    let v101 : string = _run_target_args'_v72 
    let v111 : string = $"{v101}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure8(v10, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v129 : string = " }"
    let v130 : string = $"{v129}"
    let v138 : unit = ()
    let v139 : (unit -> unit) = closure8(v10, v130)
    let v140 : unit = (fun () -> v139 (); v138) ()
    let v146 : string = v10.l0
    let v147 : int64 = v0.l0
    let v150 : string = " "
    let v151 : string = v6 + v150 
    let v155 : string = v151 + v7 
    let v160 : string = " #"
    let v161 : string = v155 + v160 
    let v165 : (int64 -> string) = _.ToString()
    let v166 : string = v165 v147
    let v170 : string = v161 + v166 
    let v174 : string = v170 + v150 
    let v179 : string = "runtime.execute_with_options_async / WaitForExitAsync"
    let v180 : string = v174 + v179 
    let v185 : string = " / "
    let v186 : string = v180 + v185 
    let v190 : string = v186 + v146 
    method16(v190)
and closure67 (v0 : System.Threading.Tasks.TaskCanceledException) () : unit =
    let v1 : US0 = US0_3
    let v2 : bool = method7(v1)
    if v2 then
        let v17 : unit = ()
        let v18 : (unit -> unit) = closure6()
        let v19 : unit = (fun () -> v18 (); v17) ()
        let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
        let v58 : string = method8(v40, v41, v42, v43, v44, v45)
        let v59 : string = method33()
        let v60 : string = method141(v40, v41, v42, v43, v44, v45, v58, v59, v0)
        method17(v60)
and method140 (v0 : System.Diagnostics.Process, v1 : System.Collections.Concurrent.ConcurrentStack<string>, v2 : System.Threading.CancellationToken) : Async<int32> =
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
                let v11099 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v11101 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v11099 = v11101 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v11105 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v11099 = v11105 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v11109 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v11099 = v11109 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v11113 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v11099 = v11113 
                #endif
#if FABLE_COMPILER_PYTHON
                let v11117 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v11099 = v11117 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v11121 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v11099 = v11121 
                #endif
#else
                let v11124 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _run_target_args'_v11099 = v11124 
                #endif
                let v11125 : System.Threading.Tasks.Task = _run_target_args'_v11099 
                (* run_target_args'
                let v11138 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v11140 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v11138 = v11140 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v11144 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v11138 = v11144 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v11148 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v11138 = v11148 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v11151 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v11152 : Async<unit> = v11151 v11125
                let _run_target_args'_v11138 = v11152 
                #endif
#if FABLE_COMPILER_PYTHON
                let v11153 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v11154 : Async<unit> = v11153 v11125
                let _run_target_args'_v11138 = v11154 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v11155 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v11156 : Async<unit> = v11155 v11125
                let _run_target_args'_v11138 = v11156 
                #endif
#else
                let v11157 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v11158 : Async<unit> = v11157 v11125
                let _run_target_args'_v11138 = v11158 
                #endif
                let v11159 : Async<unit> = _run_target_args'_v11138 
                do! v11159 
                (* run_target_args'
                let v11172 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v11174 : int32 = null |> unbox<int32>
                let _run_target_args'_v11172 = v11174 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v11178 : int32 = null |> unbox<int32>
                let _run_target_args'_v11172 = v11178 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v11182 : int32 = null |> unbox<int32>
                let _run_target_args'_v11172 = v11182 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v11186 : int32 = null |> unbox<int32>
                let _run_target_args'_v11172 = v11186 
                #endif
#if FABLE_COMPILER_PYTHON
                let v11190 : int32 = null |> unbox<int32>
                let _run_target_args'_v11172 = v11190 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v11194 : int32 = null |> unbox<int32>
                let _run_target_args'_v11172 = v11194 
                #endif
#else
                let v11197 : int32 = v0.ExitCode
                let _run_target_args'_v11172 = v11197 
                #endif
                let v11198 : int32 = _run_target_args'_v11172 
                return v11198 
                (* indent
                ()
            indent *)
            with ex ->
                let v11488 : exn = ex
                (* run_target_args'
                let v11493 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v11495 : string = $"%A{v11488}"
                let _run_target_args'_v11493 = v11495 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v11499 : string = $"%A{v11488}"
                let _run_target_args'_v11493 = v11499 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v11503 : string = $"%A{v11488}"
                let _run_target_args'_v11493 = v11503 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v11507 : string = $"%A{v11488}"
                let _run_target_args'_v11493 = v11507 
                #endif
#if FABLE_COMPILER_PYTHON
                let v11511 : string = $"%A{v11488}"
                let _run_target_args'_v11493 = v11511 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v11515 : string = $"%A{v11488}"
                let _run_target_args'_v11493 = v11515 
                #endif
#else
                let v11518 : string = $"{v11488.GetType ()}: {v11488.Message}"
                let _run_target_args'_v11493 = v11518 
                #endif
                let v11519 : string = _run_target_args'_v11493 
                (* run_target_args'
                let v11528 : unit = ()
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
                let v11529 : (string -> unit) = v1.Push
                v11529 v11519
                #endif
                // run_target_args' is_unit
                let v11531 : System.Threading.Tasks.TaskCanceledException = v11488 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v11594 : unit = ()
                let v11595 : (unit -> unit) = closure67(v11531)
                let v11596 : unit = (fun () -> v11595 (); v11594) ()
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
    let v22785 : Async<int32> = _let'_v21 
    let _run_target_args'_v7 = v22785 
    #endif
#if FABLE_COMPILER_PYTHON
    let v22787 : unit = ()
    let _let'_v22787 =
        async {
            try
                (* run_target_args'
                let v33865 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v33867 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v33865 = v33867 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v33871 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v33865 = v33871 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v33875 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v33865 = v33875 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v33879 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v33865 = v33879 
                #endif
#if FABLE_COMPILER_PYTHON
                let v33883 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v33865 = v33883 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v33887 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v33865 = v33887 
                #endif
#else
                let v33890 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _run_target_args'_v33865 = v33890 
                #endif
                let v33891 : System.Threading.Tasks.Task = _run_target_args'_v33865 
                (* run_target_args'
                let v33904 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v33906 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v33904 = v33906 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v33910 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v33904 = v33910 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v33914 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v33904 = v33914 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v33917 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v33918 : Async<unit> = v33917 v33891
                let _run_target_args'_v33904 = v33918 
                #endif
#if FABLE_COMPILER_PYTHON
                let v33919 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v33920 : Async<unit> = v33919 v33891
                let _run_target_args'_v33904 = v33920 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v33921 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v33922 : Async<unit> = v33921 v33891
                let _run_target_args'_v33904 = v33922 
                #endif
#else
                let v33923 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v33924 : Async<unit> = v33923 v33891
                let _run_target_args'_v33904 = v33924 
                #endif
                let v33925 : Async<unit> = _run_target_args'_v33904 
                do! v33925 
                (* run_target_args'
                let v33938 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v33940 : int32 = null |> unbox<int32>
                let _run_target_args'_v33938 = v33940 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v33944 : int32 = null |> unbox<int32>
                let _run_target_args'_v33938 = v33944 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v33948 : int32 = null |> unbox<int32>
                let _run_target_args'_v33938 = v33948 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v33952 : int32 = null |> unbox<int32>
                let _run_target_args'_v33938 = v33952 
                #endif
#if FABLE_COMPILER_PYTHON
                let v33956 : int32 = null |> unbox<int32>
                let _run_target_args'_v33938 = v33956 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v33960 : int32 = null |> unbox<int32>
                let _run_target_args'_v33938 = v33960 
                #endif
#else
                let v33963 : int32 = v0.ExitCode
                let _run_target_args'_v33938 = v33963 
                #endif
                let v33964 : int32 = _run_target_args'_v33938 
                return v33964 
                (* indent
                ()
            indent *)
            with ex ->
                let v34254 : exn = ex
                (* run_target_args'
                let v34259 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v34261 : string = $"%A{v34254}"
                let _run_target_args'_v34259 = v34261 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v34265 : string = $"%A{v34254}"
                let _run_target_args'_v34259 = v34265 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v34269 : string = $"%A{v34254}"
                let _run_target_args'_v34259 = v34269 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v34273 : string = $"%A{v34254}"
                let _run_target_args'_v34259 = v34273 
                #endif
#if FABLE_COMPILER_PYTHON
                let v34277 : string = $"%A{v34254}"
                let _run_target_args'_v34259 = v34277 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v34281 : string = $"%A{v34254}"
                let _run_target_args'_v34259 = v34281 
                #endif
#else
                let v34284 : string = $"{v34254.GetType ()}: {v34254.Message}"
                let _run_target_args'_v34259 = v34284 
                #endif
                let v34285 : string = _run_target_args'_v34259 
                (* run_target_args'
                let v34294 : unit = ()
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
                let v34295 : (string -> unit) = v1.Push
                v34295 v34285
                #endif
                // run_target_args' is_unit
                let v34297 : System.Threading.Tasks.TaskCanceledException = v34254 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v34360 : unit = ()
                let v34361 : (unit -> unit) = closure67(v34297)
                let v34362 : unit = (fun () -> v34361 (); v34360) ()
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
    let v45551 : Async<int32> = _let'_v22787 
    let _run_target_args'_v7 = v45551 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v45553 : unit = ()
    let _let'_v45553 =
        async {
            try
                (* run_target_args'
                let v56631 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v56633 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v56631 = v56633 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v56637 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v56631 = v56637 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v56641 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v56631 = v56641 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v56645 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v56631 = v56645 
                #endif
#if FABLE_COMPILER_PYTHON
                let v56649 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v56631 = v56649 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v56653 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v56631 = v56653 
                #endif
#else
                let v56656 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _run_target_args'_v56631 = v56656 
                #endif
                let v56657 : System.Threading.Tasks.Task = _run_target_args'_v56631 
                (* run_target_args'
                let v56670 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v56672 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v56670 = v56672 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v56676 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v56670 = v56676 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v56680 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v56670 = v56680 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v56683 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v56684 : Async<unit> = v56683 v56657
                let _run_target_args'_v56670 = v56684 
                #endif
#if FABLE_COMPILER_PYTHON
                let v56685 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v56686 : Async<unit> = v56685 v56657
                let _run_target_args'_v56670 = v56686 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v56687 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v56688 : Async<unit> = v56687 v56657
                let _run_target_args'_v56670 = v56688 
                #endif
#else
                let v56689 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v56690 : Async<unit> = v56689 v56657
                let _run_target_args'_v56670 = v56690 
                #endif
                let v56691 : Async<unit> = _run_target_args'_v56670 
                do! v56691 
                (* run_target_args'
                let v56704 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v56706 : int32 = null |> unbox<int32>
                let _run_target_args'_v56704 = v56706 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v56710 : int32 = null |> unbox<int32>
                let _run_target_args'_v56704 = v56710 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v56714 : int32 = null |> unbox<int32>
                let _run_target_args'_v56704 = v56714 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v56718 : int32 = null |> unbox<int32>
                let _run_target_args'_v56704 = v56718 
                #endif
#if FABLE_COMPILER_PYTHON
                let v56722 : int32 = null |> unbox<int32>
                let _run_target_args'_v56704 = v56722 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v56726 : int32 = null |> unbox<int32>
                let _run_target_args'_v56704 = v56726 
                #endif
#else
                let v56729 : int32 = v0.ExitCode
                let _run_target_args'_v56704 = v56729 
                #endif
                let v56730 : int32 = _run_target_args'_v56704 
                return v56730 
                (* indent
                ()
            indent *)
            with ex ->
                let v57020 : exn = ex
                (* run_target_args'
                let v57025 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v57027 : string = $"%A{v57020}"
                let _run_target_args'_v57025 = v57027 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v57031 : string = $"%A{v57020}"
                let _run_target_args'_v57025 = v57031 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v57035 : string = $"%A{v57020}"
                let _run_target_args'_v57025 = v57035 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v57039 : string = $"%A{v57020}"
                let _run_target_args'_v57025 = v57039 
                #endif
#if FABLE_COMPILER_PYTHON
                let v57043 : string = $"%A{v57020}"
                let _run_target_args'_v57025 = v57043 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v57047 : string = $"%A{v57020}"
                let _run_target_args'_v57025 = v57047 
                #endif
#else
                let v57050 : string = $"{v57020.GetType ()}: {v57020.Message}"
                let _run_target_args'_v57025 = v57050 
                #endif
                let v57051 : string = _run_target_args'_v57025 
                (* run_target_args'
                let v57060 : unit = ()
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
                let v57061 : (string -> unit) = v1.Push
                v57061 v57051
                #endif
                // run_target_args' is_unit
                let v57063 : System.Threading.Tasks.TaskCanceledException = v57020 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v57126 : unit = ()
                let v57127 : (unit -> unit) = closure67(v57063)
                let v57128 : unit = (fun () -> v57127 (); v57126) ()
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
    let v68317 : Async<int32> = _let'_v45553 
    let _run_target_args'_v7 = v68317 
    #endif
#else
    let v68319 : unit = ()
    let _let'_v68319 =
        async {
            try
                (* run_target_args'
                let v79397 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v79399 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v79397 = v79399 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v79403 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v79397 = v79403 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v79407 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v79397 = v79407 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v79411 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v79397 = v79411 
                #endif
#if FABLE_COMPILER_PYTHON
                let v79415 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v79397 = v79415 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v79419 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v79397 = v79419 
                #endif
#else
                let v79422 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _run_target_args'_v79397 = v79422 
                #endif
                let v79423 : System.Threading.Tasks.Task = _run_target_args'_v79397 
                (* run_target_args'
                let v79436 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v79438 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v79436 = v79438 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v79442 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v79436 = v79442 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v79446 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v79436 = v79446 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v79449 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v79450 : Async<unit> = v79449 v79423
                let _run_target_args'_v79436 = v79450 
                #endif
#if FABLE_COMPILER_PYTHON
                let v79451 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v79452 : Async<unit> = v79451 v79423
                let _run_target_args'_v79436 = v79452 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v79453 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v79454 : Async<unit> = v79453 v79423
                let _run_target_args'_v79436 = v79454 
                #endif
#else
                let v79455 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v79456 : Async<unit> = v79455 v79423
                let _run_target_args'_v79436 = v79456 
                #endif
                let v79457 : Async<unit> = _run_target_args'_v79436 
                do! v79457 
                (* run_target_args'
                let v79470 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v79472 : int32 = null |> unbox<int32>
                let _run_target_args'_v79470 = v79472 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v79476 : int32 = null |> unbox<int32>
                let _run_target_args'_v79470 = v79476 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v79480 : int32 = null |> unbox<int32>
                let _run_target_args'_v79470 = v79480 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v79484 : int32 = null |> unbox<int32>
                let _run_target_args'_v79470 = v79484 
                #endif
#if FABLE_COMPILER_PYTHON
                let v79488 : int32 = null |> unbox<int32>
                let _run_target_args'_v79470 = v79488 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v79492 : int32 = null |> unbox<int32>
                let _run_target_args'_v79470 = v79492 
                #endif
#else
                let v79495 : int32 = v0.ExitCode
                let _run_target_args'_v79470 = v79495 
                #endif
                let v79496 : int32 = _run_target_args'_v79470 
                return v79496 
                (* indent
                ()
            indent *)
            with ex ->
                let v79786 : exn = ex
                (* run_target_args'
                let v79791 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v79793 : string = $"%A{v79786}"
                let _run_target_args'_v79791 = v79793 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v79797 : string = $"%A{v79786}"
                let _run_target_args'_v79791 = v79797 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v79801 : string = $"%A{v79786}"
                let _run_target_args'_v79791 = v79801 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v79805 : string = $"%A{v79786}"
                let _run_target_args'_v79791 = v79805 
                #endif
#if FABLE_COMPILER_PYTHON
                let v79809 : string = $"%A{v79786}"
                let _run_target_args'_v79791 = v79809 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v79813 : string = $"%A{v79786}"
                let _run_target_args'_v79791 = v79813 
                #endif
#else
                let v79816 : string = $"{v79786.GetType ()}: {v79786.Message}"
                let _run_target_args'_v79791 = v79816 
                #endif
                let v79817 : string = _run_target_args'_v79791 
                (* run_target_args'
                let v79826 : unit = ()
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
                let v79827 : (string -> unit) = v1.Push
                v79827 v79817
                #endif
                // run_target_args' is_unit
                let v79829 : System.Threading.Tasks.TaskCanceledException = v79786 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v79892 : unit = ()
                let v79893 : (unit -> unit) = closure67(v79829)
                let v79894 : unit = (fun () -> v79893 (); v79892) ()
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
    let v91083 : Async<int32> = _let'_v68319 
    let _run_target_args'_v7 = v91083 
    #endif
    let v91084 : Async<int32> = _run_target_args'_v7 
    v91084
and method142 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option) : string =
    let v17 : string = method13()
    let v18 : Mut3 = {l0 = v17} : Mut3
    let v21 : string = "{ "
    let v22 : string = $"{v21}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure8(v18, v22)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v40 : string = "exit_code"
    let v41 : string = $"{v40}"
    let v49 : unit = ()
    let v50 : (unit -> unit) = closure8(v18, v41)
    let v51 : unit = (fun () -> v50 (); v49) ()
    let v59 : string = " = "
    let v60 : string = $"{v59}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure8(v18, v60)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v80 : string = $"{v8}"
    let v88 : unit = ()
    let v89 : (unit -> unit) = closure8(v18, v80)
    let v90 : unit = (fun () -> v89 (); v88) ()
    let v98 : string = "; "
    let v99 : string = $"{v98}"
    let v107 : unit = ()
    let v108 : (unit -> unit) = closure8(v18, v99)
    let v109 : unit = (fun () -> v108 (); v107) ()
    let v117 : string = "output_length"
    let v118 : string = $"{v117}"
    let v126 : unit = ()
    let v127 : (unit -> unit) = closure8(v18, v118)
    let v128 : unit = (fun () -> v127 (); v126) ()
    let v135 : string = $"{v59}"
    let v143 : unit = ()
    let v144 : (unit -> unit) = closure8(v18, v135)
    let v145 : unit = (fun () -> v144 (); v143) ()
    let v155 : string = $"{v9}"
    let v163 : unit = ()
    let v164 : (unit -> unit) = closure8(v18, v155)
    let v165 : unit = (fun () -> v164 (); v163) ()
    let v172 : string = $"{v98}"
    let v180 : unit = ()
    let v181 : (unit -> unit) = closure8(v18, v172)
    let v182 : unit = (fun () -> v181 (); v180) ()
    let v190 : string = "options"
    let v191 : string = $"{v190}"
    let v199 : unit = ()
    let v200 : (unit -> unit) = closure8(v18, v191)
    let v201 : unit = (fun () -> v200 (); v199) ()
    let v208 : string = $"{v59}"
    let v216 : unit = ()
    let v217 : (unit -> unit) = closure8(v18, v208)
    let v218 : unit = (fun () -> v217 (); v216) ()
    let v225 : string = $"{v21}"
    let v233 : unit = ()
    let v234 : (unit -> unit) = closure8(v18, v225)
    let v235 : unit = (fun () -> v234 (); v233) ()
    let v243 : string = "command"
    let v244 : string = $"{v243}"
    let v252 : unit = ()
    let v253 : (unit -> unit) = closure8(v18, v244)
    let v254 : unit = (fun () -> v253 (); v252) ()
    let v261 : string = $"{v59}"
    let v269 : unit = ()
    let v270 : (unit -> unit) = closure8(v18, v261)
    let v271 : unit = (fun () -> v270 (); v269) ()
    let v278 : string = $"{v10}"
    let v286 : unit = ()
    let v287 : (unit -> unit) = closure8(v18, v278)
    let v288 : unit = (fun () -> v287 (); v286) ()
    let v295 : string = $"{v98}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure8(v18, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = "cancellation_token"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure8(v18, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v331 : string = $"{v59}"
    let v339 : unit = ()
    let v340 : (unit -> unit) = closure8(v18, v331)
    let v341 : unit = (fun () -> v340 (); v339) ()
    (* run_target_args'
    let v351 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v352 : string = "format!(\"{:#?}\", $0)"
    let v353 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v352 
    let v354 : string = "fable_library_rust::String_::fromString($0)"
    let v355 : string = Fable.Core.RustInterop.emitRustExpr v353 v354 
    let _run_target_args'_v351 = v355 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v356 : string = "format!(\"{:#?}\", $0)"
    let v357 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v356 
    let v358 : string = "fable_library_rust::String_::fromString($0)"
    let v359 : string = Fable.Core.RustInterop.emitRustExpr v357 v358 
    let _run_target_args'_v351 = v359 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v360 : string = "format!(\"{:#?}\", $0)"
    let v361 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v360 
    let v362 : string = "fable_library_rust::String_::fromString($0)"
    let v363 : string = Fable.Core.RustInterop.emitRustExpr v361 v362 
    let _run_target_args'_v351 = v363 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v365 : string = $"%A{v11}"
    let _run_target_args'_v351 = v365 
    #endif
#if FABLE_COMPILER_PYTHON
    let v369 : string = $"%A{v11}"
    let _run_target_args'_v351 = v369 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v373 : string = $"%A{v11}"
    let _run_target_args'_v351 = v373 
    #endif
#else
    let v377 : string = $"%A{v11}"
    let _run_target_args'_v351 = v377 
    #endif
    let v380 : string = _run_target_args'_v351 
    let v390 : string = $"{v380}"
    let v398 : unit = ()
    let v399 : (unit -> unit) = closure8(v18, v390)
    let v400 : unit = (fun () -> v399 (); v398) ()
    let v407 : string = $"{v98}"
    let v415 : unit = ()
    let v416 : (unit -> unit) = closure8(v18, v407)
    let v417 : unit = (fun () -> v416 (); v415) ()
    let v425 : string = "environment_variables"
    let v426 : string = $"{v425}"
    let v434 : unit = ()
    let v435 : (unit -> unit) = closure8(v18, v426)
    let v436 : unit = (fun () -> v435 (); v434) ()
    let v443 : string = $"{v59}"
    let v451 : unit = ()
    let v452 : (unit -> unit) = closure8(v18, v443)
    let v453 : unit = (fun () -> v452 (); v451) ()
    let v460 : string = $"%A{v12}"
    let v464 : string = $"{v460}"
    let v472 : unit = ()
    let v473 : (unit -> unit) = closure8(v18, v464)
    let v474 : unit = (fun () -> v473 (); v472) ()
    let v481 : string = $"{v98}"
    let v489 : unit = ()
    let v490 : (unit -> unit) = closure8(v18, v481)
    let v491 : unit = (fun () -> v490 (); v489) ()
    let v499 : string = "on_line"
    let v500 : string = $"{v499}"
    let v508 : unit = ()
    let v509 : (unit -> unit) = closure8(v18, v500)
    let v510 : unit = (fun () -> v509 (); v508) ()
    let v517 : string = $"{v59}"
    let v525 : unit = ()
    let v526 : (unit -> unit) = closure8(v18, v517)
    let v527 : unit = (fun () -> v526 (); v525) ()
    (* run_target_args'
    let v537 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v538 : string = "format!(\"{:#?}\", $0)"
    let v539 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v538 
    let v540 : string = "fable_library_rust::String_::fromString($0)"
    let v541 : string = Fable.Core.RustInterop.emitRustExpr v539 v540 
    let _run_target_args'_v537 = v541 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v542 : string = "format!(\"{:#?}\", $0)"
    let v543 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v542 
    let v544 : string = "fable_library_rust::String_::fromString($0)"
    let v545 : string = Fable.Core.RustInterop.emitRustExpr v543 v544 
    let _run_target_args'_v537 = v545 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v546 : string = "format!(\"{:#?}\", $0)"
    let v547 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v546 
    let v548 : string = "fable_library_rust::String_::fromString($0)"
    let v549 : string = Fable.Core.RustInterop.emitRustExpr v547 v548 
    let _run_target_args'_v537 = v549 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v551 : string = $"%A{v13}"
    let _run_target_args'_v537 = v551 
    #endif
#if FABLE_COMPILER_PYTHON
    let v555 : string = $"%A{v13}"
    let _run_target_args'_v537 = v555 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v559 : string = $"%A{v13}"
    let _run_target_args'_v537 = v559 
    #endif
#else
    let v563 : string = $"%A{v13}"
    let _run_target_args'_v537 = v563 
    #endif
    let v566 : string = _run_target_args'_v537 
    let v576 : string = $"{v566}"
    let v584 : unit = ()
    let v585 : (unit -> unit) = closure8(v18, v576)
    let v586 : unit = (fun () -> v585 (); v584) ()
    let v593 : string = $"{v98}"
    let v601 : unit = ()
    let v602 : (unit -> unit) = closure8(v18, v593)
    let v603 : unit = (fun () -> v602 (); v601) ()
    let v611 : string = "stdin"
    let v612 : string = $"{v611}"
    let v620 : unit = ()
    let v621 : (unit -> unit) = closure8(v18, v612)
    let v622 : unit = (fun () -> v621 (); v620) ()
    let v629 : string = $"{v59}"
    let v637 : unit = ()
    let v638 : (unit -> unit) = closure8(v18, v629)
    let v639 : unit = (fun () -> v638 (); v637) ()
    (* run_target_args'
    let v649 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v650 : string = "format!(\"{:#?}\", $0)"
    let v651 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v650 
    let v652 : string = "fable_library_rust::String_::fromString($0)"
    let v653 : string = Fable.Core.RustInterop.emitRustExpr v651 v652 
    let _run_target_args'_v649 = v653 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v654 : string = "format!(\"{:#?}\", $0)"
    let v655 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v654 
    let v656 : string = "fable_library_rust::String_::fromString($0)"
    let v657 : string = Fable.Core.RustInterop.emitRustExpr v655 v656 
    let _run_target_args'_v649 = v657 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v658 : string = "format!(\"{:#?}\", $0)"
    let v659 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v658 
    let v660 : string = "fable_library_rust::String_::fromString($0)"
    let v661 : string = Fable.Core.RustInterop.emitRustExpr v659 v660 
    let _run_target_args'_v649 = v661 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v663 : string = $"%A{v14}"
    let _run_target_args'_v649 = v663 
    #endif
#if FABLE_COMPILER_PYTHON
    let v667 : string = $"%A{v14}"
    let _run_target_args'_v649 = v667 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v671 : string = $"%A{v14}"
    let _run_target_args'_v649 = v671 
    #endif
#else
    let v675 : string = $"%A{v14}"
    let _run_target_args'_v649 = v675 
    #endif
    let v678 : string = _run_target_args'_v649 
    let v688 : string = $"{v678}"
    let v696 : unit = ()
    let v697 : (unit -> unit) = closure8(v18, v688)
    let v698 : unit = (fun () -> v697 (); v696) ()
    let v705 : string = $"{v98}"
    let v713 : unit = ()
    let v714 : (unit -> unit) = closure8(v18, v705)
    let v715 : unit = (fun () -> v714 (); v713) ()
    let v723 : string = "trace"
    let v724 : string = $"{v723}"
    let v732 : unit = ()
    let v733 : (unit -> unit) = closure8(v18, v724)
    let v734 : unit = (fun () -> v733 (); v732) ()
    let v741 : string = $"{v59}"
    let v749 : unit = ()
    let v750 : (unit -> unit) = closure8(v18, v741)
    let v751 : unit = (fun () -> v750 (); v749) ()
    let v759 : string =
        if v15 then
            let v757 : string = "true"
            v757
        else
            let v758 : string = "false"
            v758
    let v761 : string = $"{v759}"
    let v769 : unit = ()
    let v770 : (unit -> unit) = closure8(v18, v761)
    let v771 : unit = (fun () -> v770 (); v769) ()
    let v778 : string = $"{v98}"
    let v786 : unit = ()
    let v787 : (unit -> unit) = closure8(v18, v778)
    let v788 : unit = (fun () -> v787 (); v786) ()
    let v796 : string = "working_directory"
    let v797 : string = $"{v796}"
    let v805 : unit = ()
    let v806 : (unit -> unit) = closure8(v18, v797)
    let v807 : unit = (fun () -> v806 (); v805) ()
    let v814 : string = $"{v59}"
    let v822 : unit = ()
    let v823 : (unit -> unit) = closure8(v18, v814)
    let v824 : unit = (fun () -> v823 (); v822) ()
    (* run_target_args'
    let v834 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v835 : string = "format!(\"{:#?}\", $0)"
    let v836 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v835 
    let v837 : string = "fable_library_rust::String_::fromString($0)"
    let v838 : string = Fable.Core.RustInterop.emitRustExpr v836 v837 
    let _run_target_args'_v834 = v838 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v839 : string = "format!(\"{:#?}\", $0)"
    let v840 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v839 
    let v841 : string = "fable_library_rust::String_::fromString($0)"
    let v842 : string = Fable.Core.RustInterop.emitRustExpr v840 v841 
    let _run_target_args'_v834 = v842 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v843 : string = "format!(\"{:#?}\", $0)"
    let v844 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v843 
    let v845 : string = "fable_library_rust::String_::fromString($0)"
    let v846 : string = Fable.Core.RustInterop.emitRustExpr v844 v845 
    let _run_target_args'_v834 = v846 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v848 : string = $"%A{v16}"
    let _run_target_args'_v834 = v848 
    #endif
#if FABLE_COMPILER_PYTHON
    let v852 : string = $"%A{v16}"
    let _run_target_args'_v834 = v852 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v856 : string = $"%A{v16}"
    let _run_target_args'_v834 = v856 
    #endif
#else
    let v860 : string = $"%A{v16}"
    let _run_target_args'_v834 = v860 
    #endif
    let v863 : string = _run_target_args'_v834 
    let v873 : string = $"{v863}"
    let v881 : unit = ()
    let v882 : (unit -> unit) = closure8(v18, v873)
    let v883 : unit = (fun () -> v882 (); v881) ()
    let v891 : string = " }"
    let v892 : string = $"{v891}"
    let v900 : unit = ()
    let v901 : (unit -> unit) = closure8(v18, v892)
    let v902 : unit = (fun () -> v901 (); v900) ()
    let v909 : string = $"{v891}"
    let v917 : unit = ()
    let v918 : (unit -> unit) = closure8(v18, v909)
    let v919 : unit = (fun () -> v918 (); v917) ()
    let v925 : string = v18.l0
    let v926 : int64 = v0.l0
    let v929 : string = " "
    let v930 : string = v6 + v929 
    let v934 : string = v930 + v7 
    let v939 : string = " #"
    let v940 : string = v934 + v939 
    let v944 : (int64 -> string) = _.ToString()
    let v945 : string = v944 v926
    let v949 : string = v940 + v945 
    let v953 : string = v949 + v929 
    let v958 : string = "runtime.execute_with_options_async"
    let v959 : string = v953 + v958 
    let v964 : string = " / "
    let v965 : string = v959 + v964 
    let v969 : string = v965 + v925 
    method16(v969)
and closure68 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : int32, v8 : string) () : unit =
    let v9 : US0 = US0_1
    let v10 : bool = method7(v9)
    if v10 then
        let v25 : unit = ()
        let v26 : (unit -> unit) = closure6()
        let v27 : unit = (fun () -> v26 (); v25) ()
        let struct (v48 : Mut0, v49 : Mut1, v50 : Mut2, v51 : Mut3, v52 : Mut4, v53 : int64 option) = TraceState.trace_state.Value
        let v66 : string = method8(v48, v49, v50, v51, v52, v53)
        let v67 : string = method61()
        let v68 : int32 = v8.Length
        let v69 : string = method142(v48, v49, v50, v51, v52, v53, v66, v67, v7, v68, v0, v1, v2, v3, v4, v5, v6)
        method17(v69)
and method128 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
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
            let v5938 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v5941 : int32, v5942 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5941, v5942) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v5949 : int32, v5950 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5949, v5950) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v5957 : int32, v5958 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5957, v5958) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v5965 : int32, v5966 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5965, v5966) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v5973 : int32, v5974 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5973, v5974) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v5981 : int32, v5982 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5981, v5982) 
            #endif
#else
            let v5987 : US14 = method77(v0)
            let struct (v5999 : string, v6000 : US5) =
                match v5987 with
                | US14_1(v5990) -> (* Error *)
                    let v5992 : string = $"resultm.get / Result value was Error: {v5990}"
                    failwith<struct (string * US5)> v5992
                | US14_0(v5988, v5989) -> (* Ok *)
                    struct (v5988, v5989)
            let v6003 : (string -> US5) = method6()
            let v6004 : US5 option = v6 |> Option.map v6003 
            let v6024 : US5 = US5_1
            let v6025 : US5 = v6004 |> Option.defaultValue v6024 
            let v6032 : string =
                match v6025 with
                | US5_1 -> (* None *)
                    let v6030 : string = ""
                    v6030
                | US5_0(v6029) -> (* Some *)
                    v6029
            let v6093 : unit = ()
            let v6094 : (unit -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v6000, v5999)
            let v6095 : unit = (fun () -> v6094 (); v6093) ()
            let v6156 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v6160 : string =
                match v6000 with
                | US5_1 -> (* None *)
                    let v6158 : string = ""
                    v6158
                | US5_0(v6157) -> (* Some *)
                    v6157
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v6160,
              StandardOutputEncoding = v6156,
              WorkingDirectory = v6032,
              FileName = v5999,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v6161 : System.Diagnostics.ProcessStartInfo = start_info
            let v6162 : (struct (string * string) []) = method130(v0, v1, v2, v3, v4, v5, v6)
            let v6163 : int32 = v6162.Length
            let v6164 : Mut6 = {l0 = 0} : Mut6
            while method58(v6163, v6164) do
                let v6166 : int32 = v6164.l0
                let struct (v6167 : string, v6168 : string) = v6162.[int v6166]
                v6161.EnvironmentVariables.[v6167] <- v6168 
                let v6169 : int32 = v6166 + 1
                v6164.l0 <- v6169
                ()
            let v6170 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v6161)
            use v6170 = v6170 
            let v6171 : System.Diagnostics.Process = v6170 
            let v6172 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v6173 : System.Collections.Concurrent.ConcurrentStack<string> = v6172 ()
            let v6174 : bool = false
            let v6175 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v6171, v6173, v6174)
            v6171.OutputDataReceived.Add v6175 
            let v6176 : bool = true
            let v6177 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v6171, v6173, v6176)
            v6171.ErrorDataReceived.Add v6177 
            let v6178 : (unit -> bool) = v6171.Start
            let v6179 : bool = v6178 ()
            let v6180 : bool = v6179 = false
            if v6180 then
                let v6181 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v6181
            let v6182 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v6182 v6171
            let v6183 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v6183 v6171
            let v6186 : (System.Threading.CancellationToken -> US32) = method136()
            let v6187 : US32 option = v1 |> Option.map v6186 
            let v6207 : US32 = US32_1
            let v6208 : US32 = v6187 |> Option.defaultValue v6207 
            let v6215 : System.Threading.CancellationToken =
                match v6208 with
                | US32_1 -> (* None *)
                    let v6213 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v6213
                | US32_0(v6212) -> (* Some *)
                    v6212
            let v6216 : Async<System.Threading.CancellationToken> = method137(v6215)
            let! v6216 = v6216 
            let v6217 : System.Threading.CancellationToken = v6216 
            let v6218 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v6217.Register
            let v6219 : (unit -> unit) = closure66(v6171)
            let v6220 : System.Threading.CancellationTokenRegistration = v6218 v6219
            use v6220 = v6220 
            let v6221 : System.Threading.CancellationTokenRegistration = v6220 
            let v6222 : Async<int32> = method140(v6171, v6173, v6217)
            let! v6222 = v6222 
            let v6223 : int32 = v6222 
            let v6225 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v6226 : string seq = v6225 v6173
            let v6230 : (string seq -> string seq) = Seq.rev
            let v6231 : string seq = v6230 v6226
            let v6236 : string = method125()
            let v6237 : (string -> (string seq -> string)) = String.concat
            let v6238 : (string seq -> string) = v6237 v6236
            let v6239 : string = v6238 v6231
            let v6304 : unit = ()
            let v6305 : (unit -> unit) = closure68(v0, v1, v2, v3, v4, v5, v6, v6223, v6239)
            let v6306 : unit = (fun () -> v6305 (); v6304) ()
            return struct (v6223, v6239) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v12286 : Async<struct (int32 * string)> = _let'_v25 
    let _run_target_args'_v11 = v12286 
    #endif
#if FABLE_COMPILER_PYTHON
    let v12288 : unit = ()
    let _let'_v12288 =
        async {
            (* run_target_args'
            let v18201 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v18204 : int32, v18205 : string) = null |> unbox<struct (int32 * string)>
            return struct (v18204, v18205) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v18212 : int32, v18213 : string) = null |> unbox<struct (int32 * string)>
            return struct (v18212, v18213) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v18220 : int32, v18221 : string) = null |> unbox<struct (int32 * string)>
            return struct (v18220, v18221) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v18228 : int32, v18229 : string) = null |> unbox<struct (int32 * string)>
            return struct (v18228, v18229) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v18236 : int32, v18237 : string) = null |> unbox<struct (int32 * string)>
            return struct (v18236, v18237) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v18244 : int32, v18245 : string) = null |> unbox<struct (int32 * string)>
            return struct (v18244, v18245) 
            #endif
#else
            let v18250 : US14 = method77(v0)
            let struct (v18262 : string, v18263 : US5) =
                match v18250 with
                | US14_1(v18253) -> (* Error *)
                    let v18255 : string = $"resultm.get / Result value was Error: {v18253}"
                    failwith<struct (string * US5)> v18255
                | US14_0(v18251, v18252) -> (* Ok *)
                    struct (v18251, v18252)
            let v18266 : (string -> US5) = method6()
            let v18267 : US5 option = v6 |> Option.map v18266 
            let v18287 : US5 = US5_1
            let v18288 : US5 = v18267 |> Option.defaultValue v18287 
            let v18295 : string =
                match v18288 with
                | US5_1 -> (* None *)
                    let v18293 : string = ""
                    v18293
                | US5_0(v18292) -> (* Some *)
                    v18292
            let v18356 : unit = ()
            let v18357 : (unit -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v18263, v18262)
            let v18358 : unit = (fun () -> v18357 (); v18356) ()
            let v18419 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v18423 : string =
                match v18263 with
                | US5_1 -> (* None *)
                    let v18421 : string = ""
                    v18421
                | US5_0(v18420) -> (* Some *)
                    v18420
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v18423,
              StandardOutputEncoding = v18419,
              WorkingDirectory = v18295,
              FileName = v18262,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v18424 : System.Diagnostics.ProcessStartInfo = start_info
            let v18425 : (struct (string * string) []) = method130(v0, v1, v2, v3, v4, v5, v6)
            let v18426 : int32 = v18425.Length
            let v18427 : Mut6 = {l0 = 0} : Mut6
            while method58(v18426, v18427) do
                let v18429 : int32 = v18427.l0
                let struct (v18430 : string, v18431 : string) = v18425.[int v18429]
                v18424.EnvironmentVariables.[v18430] <- v18431 
                let v18432 : int32 = v18429 + 1
                v18427.l0 <- v18432
                ()
            let v18433 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v18424)
            use v18433 = v18433 
            let v18434 : System.Diagnostics.Process = v18433 
            let v18435 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v18436 : System.Collections.Concurrent.ConcurrentStack<string> = v18435 ()
            let v18437 : bool = false
            let v18438 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v18434, v18436, v18437)
            v18434.OutputDataReceived.Add v18438 
            let v18439 : bool = true
            let v18440 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v18434, v18436, v18439)
            v18434.ErrorDataReceived.Add v18440 
            let v18441 : (unit -> bool) = v18434.Start
            let v18442 : bool = v18441 ()
            let v18443 : bool = v18442 = false
            if v18443 then
                let v18444 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v18444
            let v18445 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v18445 v18434
            let v18446 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v18446 v18434
            let v18449 : (System.Threading.CancellationToken -> US32) = method136()
            let v18450 : US32 option = v1 |> Option.map v18449 
            let v18470 : US32 = US32_1
            let v18471 : US32 = v18450 |> Option.defaultValue v18470 
            let v18478 : System.Threading.CancellationToken =
                match v18471 with
                | US32_1 -> (* None *)
                    let v18476 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v18476
                | US32_0(v18475) -> (* Some *)
                    v18475
            let v18479 : Async<System.Threading.CancellationToken> = method137(v18478)
            let! v18479 = v18479 
            let v18480 : System.Threading.CancellationToken = v18479 
            let v18481 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v18480.Register
            let v18482 : (unit -> unit) = closure66(v18434)
            let v18483 : System.Threading.CancellationTokenRegistration = v18481 v18482
            use v18483 = v18483 
            let v18484 : System.Threading.CancellationTokenRegistration = v18483 
            let v18485 : Async<int32> = method140(v18434, v18436, v18480)
            let! v18485 = v18485 
            let v18486 : int32 = v18485 
            let v18488 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v18489 : string seq = v18488 v18436
            let v18493 : (string seq -> string seq) = Seq.rev
            let v18494 : string seq = v18493 v18489
            let v18499 : string = method125()
            let v18500 : (string -> (string seq -> string)) = String.concat
            let v18501 : (string seq -> string) = v18500 v18499
            let v18502 : string = v18501 v18494
            let v18567 : unit = ()
            let v18568 : (unit -> unit) = closure68(v0, v1, v2, v3, v4, v5, v6, v18486, v18502)
            let v18569 : unit = (fun () -> v18568 (); v18567) ()
            return struct (v18486, v18502) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v24549 : Async<struct (int32 * string)> = _let'_v12288 
    let _run_target_args'_v11 = v24549 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v24551 : unit = ()
    let _let'_v24551 =
        async {
            (* run_target_args'
            let v30464 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v30467 : int32, v30468 : string) = null |> unbox<struct (int32 * string)>
            return struct (v30467, v30468) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v30475 : int32, v30476 : string) = null |> unbox<struct (int32 * string)>
            return struct (v30475, v30476) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v30483 : int32, v30484 : string) = null |> unbox<struct (int32 * string)>
            return struct (v30483, v30484) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v30491 : int32, v30492 : string) = null |> unbox<struct (int32 * string)>
            return struct (v30491, v30492) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v30499 : int32, v30500 : string) = null |> unbox<struct (int32 * string)>
            return struct (v30499, v30500) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v30507 : int32, v30508 : string) = null |> unbox<struct (int32 * string)>
            return struct (v30507, v30508) 
            #endif
#else
            let v30513 : US14 = method77(v0)
            let struct (v30525 : string, v30526 : US5) =
                match v30513 with
                | US14_1(v30516) -> (* Error *)
                    let v30518 : string = $"resultm.get / Result value was Error: {v30516}"
                    failwith<struct (string * US5)> v30518
                | US14_0(v30514, v30515) -> (* Ok *)
                    struct (v30514, v30515)
            let v30529 : (string -> US5) = method6()
            let v30530 : US5 option = v6 |> Option.map v30529 
            let v30550 : US5 = US5_1
            let v30551 : US5 = v30530 |> Option.defaultValue v30550 
            let v30558 : string =
                match v30551 with
                | US5_1 -> (* None *)
                    let v30556 : string = ""
                    v30556
                | US5_0(v30555) -> (* Some *)
                    v30555
            let v30619 : unit = ()
            let v30620 : (unit -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v30526, v30525)
            let v30621 : unit = (fun () -> v30620 (); v30619) ()
            let v30682 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v30686 : string =
                match v30526 with
                | US5_1 -> (* None *)
                    let v30684 : string = ""
                    v30684
                | US5_0(v30683) -> (* Some *)
                    v30683
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v30686,
              StandardOutputEncoding = v30682,
              WorkingDirectory = v30558,
              FileName = v30525,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v30687 : System.Diagnostics.ProcessStartInfo = start_info
            let v30688 : (struct (string * string) []) = method130(v0, v1, v2, v3, v4, v5, v6)
            let v30689 : int32 = v30688.Length
            let v30690 : Mut6 = {l0 = 0} : Mut6
            while method58(v30689, v30690) do
                let v30692 : int32 = v30690.l0
                let struct (v30693 : string, v30694 : string) = v30688.[int v30692]
                v30687.EnvironmentVariables.[v30693] <- v30694 
                let v30695 : int32 = v30692 + 1
                v30690.l0 <- v30695
                ()
            let v30696 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v30687)
            use v30696 = v30696 
            let v30697 : System.Diagnostics.Process = v30696 
            let v30698 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v30699 : System.Collections.Concurrent.ConcurrentStack<string> = v30698 ()
            let v30700 : bool = false
            let v30701 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v30697, v30699, v30700)
            v30697.OutputDataReceived.Add v30701 
            let v30702 : bool = true
            let v30703 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v30697, v30699, v30702)
            v30697.ErrorDataReceived.Add v30703 
            let v30704 : (unit -> bool) = v30697.Start
            let v30705 : bool = v30704 ()
            let v30706 : bool = v30705 = false
            if v30706 then
                let v30707 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v30707
            let v30708 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v30708 v30697
            let v30709 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v30709 v30697
            let v30712 : (System.Threading.CancellationToken -> US32) = method136()
            let v30713 : US32 option = v1 |> Option.map v30712 
            let v30733 : US32 = US32_1
            let v30734 : US32 = v30713 |> Option.defaultValue v30733 
            let v30741 : System.Threading.CancellationToken =
                match v30734 with
                | US32_1 -> (* None *)
                    let v30739 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v30739
                | US32_0(v30738) -> (* Some *)
                    v30738
            let v30742 : Async<System.Threading.CancellationToken> = method137(v30741)
            let! v30742 = v30742 
            let v30743 : System.Threading.CancellationToken = v30742 
            let v30744 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v30743.Register
            let v30745 : (unit -> unit) = closure66(v30697)
            let v30746 : System.Threading.CancellationTokenRegistration = v30744 v30745
            use v30746 = v30746 
            let v30747 : System.Threading.CancellationTokenRegistration = v30746 
            let v30748 : Async<int32> = method140(v30697, v30699, v30743)
            let! v30748 = v30748 
            let v30749 : int32 = v30748 
            let v30751 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v30752 : string seq = v30751 v30699
            let v30756 : (string seq -> string seq) = Seq.rev
            let v30757 : string seq = v30756 v30752
            let v30762 : string = method125()
            let v30763 : (string -> (string seq -> string)) = String.concat
            let v30764 : (string seq -> string) = v30763 v30762
            let v30765 : string = v30764 v30757
            let v30830 : unit = ()
            let v30831 : (unit -> unit) = closure68(v0, v1, v2, v3, v4, v5, v6, v30749, v30765)
            let v30832 : unit = (fun () -> v30831 (); v30830) ()
            return struct (v30749, v30765) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v36812 : Async<struct (int32 * string)> = _let'_v24551 
    let _run_target_args'_v11 = v36812 
    #endif
#else
    let v36814 : unit = ()
    let _let'_v36814 =
        async {
            (* run_target_args'
            let v42727 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v42730 : int32, v42731 : string) = null |> unbox<struct (int32 * string)>
            return struct (v42730, v42731) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v42738 : int32, v42739 : string) = null |> unbox<struct (int32 * string)>
            return struct (v42738, v42739) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v42746 : int32, v42747 : string) = null |> unbox<struct (int32 * string)>
            return struct (v42746, v42747) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v42754 : int32, v42755 : string) = null |> unbox<struct (int32 * string)>
            return struct (v42754, v42755) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v42762 : int32, v42763 : string) = null |> unbox<struct (int32 * string)>
            return struct (v42762, v42763) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v42770 : int32, v42771 : string) = null |> unbox<struct (int32 * string)>
            return struct (v42770, v42771) 
            #endif
#else
            let v42776 : US14 = method77(v0)
            let struct (v42788 : string, v42789 : US5) =
                match v42776 with
                | US14_1(v42779) -> (* Error *)
                    let v42781 : string = $"resultm.get / Result value was Error: {v42779}"
                    failwith<struct (string * US5)> v42781
                | US14_0(v42777, v42778) -> (* Ok *)
                    struct (v42777, v42778)
            let v42792 : (string -> US5) = method6()
            let v42793 : US5 option = v6 |> Option.map v42792 
            let v42813 : US5 = US5_1
            let v42814 : US5 = v42793 |> Option.defaultValue v42813 
            let v42821 : string =
                match v42814 with
                | US5_1 -> (* None *)
                    let v42819 : string = ""
                    v42819
                | US5_0(v42818) -> (* Some *)
                    v42818
            let v42882 : unit = ()
            let v42883 : (unit -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v42789, v42788)
            let v42884 : unit = (fun () -> v42883 (); v42882) ()
            let v42945 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v42949 : string =
                match v42789 with
                | US5_1 -> (* None *)
                    let v42947 : string = ""
                    v42947
                | US5_0(v42946) -> (* Some *)
                    v42946
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v42949,
              StandardOutputEncoding = v42945,
              WorkingDirectory = v42821,
              FileName = v42788,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v42950 : System.Diagnostics.ProcessStartInfo = start_info
            let v42951 : (struct (string * string) []) = method130(v0, v1, v2, v3, v4, v5, v6)
            let v42952 : int32 = v42951.Length
            let v42953 : Mut6 = {l0 = 0} : Mut6
            while method58(v42952, v42953) do
                let v42955 : int32 = v42953.l0
                let struct (v42956 : string, v42957 : string) = v42951.[int v42955]
                v42950.EnvironmentVariables.[v42956] <- v42957 
                let v42958 : int32 = v42955 + 1
                v42953.l0 <- v42958
                ()
            let v42959 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v42950)
            use v42959 = v42959 
            let v42960 : System.Diagnostics.Process = v42959 
            let v42961 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v42962 : System.Collections.Concurrent.ConcurrentStack<string> = v42961 ()
            let v42963 : bool = false
            let v42964 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v42960, v42962, v42963)
            v42960.OutputDataReceived.Add v42964 
            let v42965 : bool = true
            let v42966 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v42960, v42962, v42965)
            v42960.ErrorDataReceived.Add v42966 
            let v42967 : (unit -> bool) = v42960.Start
            let v42968 : bool = v42967 ()
            let v42969 : bool = v42968 = false
            if v42969 then
                let v42970 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v42970
            let v42971 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v42971 v42960
            let v42972 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v42972 v42960
            let v42975 : (System.Threading.CancellationToken -> US32) = method136()
            let v42976 : US32 option = v1 |> Option.map v42975 
            let v42996 : US32 = US32_1
            let v42997 : US32 = v42976 |> Option.defaultValue v42996 
            let v43004 : System.Threading.CancellationToken =
                match v42997 with
                | US32_1 -> (* None *)
                    let v43002 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v43002
                | US32_0(v43001) -> (* Some *)
                    v43001
            let v43005 : Async<System.Threading.CancellationToken> = method137(v43004)
            let! v43005 = v43005 
            let v43006 : System.Threading.CancellationToken = v43005 
            let v43007 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v43006.Register
            let v43008 : (unit -> unit) = closure66(v42960)
            let v43009 : System.Threading.CancellationTokenRegistration = v43007 v43008
            use v43009 = v43009 
            let v43010 : System.Threading.CancellationTokenRegistration = v43009 
            let v43011 : Async<int32> = method140(v42960, v42962, v43006)
            let! v43011 = v43011 
            let v43012 : int32 = v43011 
            let v43014 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v43015 : string seq = v43014 v42962
            let v43019 : (string seq -> string seq) = Seq.rev
            let v43020 : string seq = v43019 v43015
            let v43025 : string = method125()
            let v43026 : (string -> (string seq -> string)) = String.concat
            let v43027 : (string seq -> string) = v43026 v43025
            let v43028 : string = v43027 v43020
            let v43093 : unit = ()
            let v43094 : (unit -> unit) = closure68(v0, v1, v2, v3, v4, v5, v6, v43012, v43028)
            let v43095 : unit = (fun () -> v43094 (); v43093) ()
            return struct (v43012, v43028) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v49075 : Async<struct (int32 * string)> = _let'_v36814 
    let _run_target_args'_v11 = v49075 
    #endif
    let v49076 : Async<struct (int32 * string)> = _run_target_args'_v11 
    v49076
and method127 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    method128(v0, v1, v2, v3, v4, v5, v6)
and method75 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : struct (int32 * string) =
    (* run_target_args'
    let v15 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v16 : string = method76(v0, v1, v2, v3, v4, v5, v6)
    let v17 : US14 = method77(v16)
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
    let v35 : US22 = method90(v34)
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
    let v91 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v92 : string = "String::from($0)"
    let v93 : std_string_String = Fable.Core.RustInterop.emitRustExpr v78 v92 
    let _run_target_args'_v91 = v93 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v94 : string = "String::from($0)"
    let v95 : std_string_String = Fable.Core.RustInterop.emitRustExpr v78 v94 
    let _run_target_args'_v91 = v95 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v96 : string = "String::from($0)"
    let v97 : std_string_String = Fable.Core.RustInterop.emitRustExpr v78 v96 
    let _run_target_args'_v91 = v97 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v99 : std_string_String = v78 |> unbox<std_string_String>
    let _run_target_args'_v91 = v99 
    #endif
#if FABLE_COMPILER_PYTHON
    let v103 : std_string_String = v78 |> unbox<std_string_String>
    let _run_target_args'_v91 = v103 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v107 : std_string_String = v78 |> unbox<std_string_String>
    let _run_target_args'_v91 = v107 
    #endif
#else
    let v111 : std_string_String = v78 |> unbox<std_string_String>
    let _run_target_args'_v91 = v111 
    #endif
    let v114 : std_string_String = _run_target_args'_v91 
    let v123 : string = "true; $0 }).collect::<Vec<_>>()"
    let v124 : bool = Fable.Core.RustInterop.emitRustExpr v114 v123 
    let v125 : string = "_vec_map"
    let v126 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v125 
    let v191 : unit = ()
    let v192 : (unit -> unit) = closure41(v0, v1, v2, v3, v4, v5, v6, v29, v126)
    let v193 : unit = (fun () -> v192 (); v191) ()
    let v259 : bool = true
    let mutable _capture_v259 : (int32 * string) option = None 
    (
    (fun () ->
    (fun () ->
    let v260 : string = "std::process::Command::new(&*$0)"
    let v261 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v29 v260 
    let v262 : string = "true; let mut v261 = v261"
    let v263 : bool = Fable.Core.RustInterop.emitRustExpr () v262 
    let v264 : string = "true; std::process::Command::args(&mut v261, &*$0)"
    let v265 : bool = Fable.Core.RustInterop.emitRustExpr v126 v264 
    let v266 : string = "$0"
    let v267 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v261 v266 
    let v268 : string = "std::process::Stdio::piped()"
    let v269 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v268 
    let v270 : string = "true; let mut v267 = v267"
    let v271 : bool = Fable.Core.RustInterop.emitRustExpr () v270 
    let v272 : string = "true; std::process::Command::stdout(&mut v267, std::process::Stdio::piped())"
    let v273 : bool = Fable.Core.RustInterop.emitRustExpr () v272 
    let v274 : string = "$0"
    let v275 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v267 v274 
    let v276 : string = "std::process::Stdio::piped()"
    let v277 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v276 
    let v278 : string = "true; let mut v275 = v275"
    let v279 : bool = Fable.Core.RustInterop.emitRustExpr () v278 
    let v280 : string = "true; std::process::Command::stderr(&mut v275, std::process::Stdio::piped())"
    let v281 : bool = Fable.Core.RustInterop.emitRustExpr () v280 
    let v282 : string = "$0"
    let v283 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v275 v282 
    let v284 : string = "std::process::Stdio::piped()"
    let v285 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v284 
    let v286 : string = "true; let mut v283 = v283"
    let v287 : bool = Fable.Core.RustInterop.emitRustExpr () v286 
    let v288 : string = "true; std::process::Command::stdin(&mut v283, std::process::Stdio::piped())"
    let v289 : bool = Fable.Core.RustInterop.emitRustExpr () v288 
    let v290 : string = "$0"
    let v291 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v283 v290 
    let v294 : (string -> US5) = method6()
    let v295 : US5 option = v6 |> Option.map v294 
    let v315 : US5 = US5_1
    let v316 : US5 = v295 |> Option.defaultValue v315 
    let v330 : std_process_Command =
        match v316 with
        | US5_1 -> (* None *)
            let v327 : string = $"v291"
            let v328 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v327 
            v328
        | US5_0(v320) -> (* Some *)
            let v321 : string = "true; let mut v291 = v291"
            let v322 : bool = Fable.Core.RustInterop.emitRustExpr () v321 
            let v323 : string = "true; std::process::Command::current_dir(&mut v291, &*$0)"
            let v324 : bool = Fable.Core.RustInterop.emitRustExpr v320 v323 
            let v325 : string = $"v291"
            let v326 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v325 
            v326
    let v331 : uint64 = System.Convert.ToUInt64 v2.Length
    let v332 : bool = v331 = 0UL
    let v352 : std_process_Command =
        if v332 then
            v330
        else
            let v333 : string = "$0.to_vec()"
            let v334 : Vec<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr v2 v333 
            let v335 : string = "true; let _vec_fold_ = $0.into_iter().fold(v330, |acc, x| { //"
            let v336 : bool = Fable.Core.RustInterop.emitRustExpr v334 v335 
            let v337 : string = "acc"
            let v338 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v337 
            let v339 : string = "x"
            let struct (v340 : string, v341 : string) = Fable.Core.RustInterop.emitRustExpr () v339 
            let v342 : string = "true; let mut v338 = v338"
            let v343 : bool = Fable.Core.RustInterop.emitRustExpr () v342 
            let v344 : string = "true; std::process::Command::env(&mut v338, &*$0, &*$1)"
            let v345 : bool = Fable.Core.RustInterop.emitRustExpr struct (v340, v341) v344 
            let v346 : string = "$0"
            let v347 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v338 v346 
            let v348 : string = "true; $0 })"
            let v349 : bool = Fable.Core.RustInterop.emitRustExpr v347 v348 
            let v350 : string = "_vec_fold_"
            let v351 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v350 
            v351
    let v353 : string = "true; let mut v352 = v352"
    let v354 : bool = Fable.Core.RustInterop.emitRustExpr () v353 
    let v355 : string = "std::process::Command::spawn(&mut v352)"
    let v356 : Result<std_process_Child, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v355 
    let v357 : (std_io_Error -> std_string_String) = method63()
    (* run_target_args'
    let v359 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v360 : string = "$0.map_err(|x| $1(x))"
    let v361 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v356, v357) v360 
    let _run_target_args'_v359 = v361 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v362 : string = "$0.map_err(|x| $1(x))"
    let v363 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v356, v357) v362 
    let _run_target_args'_v359 = v363 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v364 : string = "$0.map_err(|x| $1(x))"
    let v365 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v356, v357) v364 
    let _run_target_args'_v359 = v365 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v366 : Result<std_process_Child, std_string_String> = match v356 with Ok x -> Ok x | Error x -> Error (v357 x)
    let _run_target_args'_v359 = v366 
    #endif
#if FABLE_COMPILER_PYTHON
    let v367 : Result<std_process_Child, std_string_String> = match v356 with Ok x -> Ok x | Error x -> Error (v357 x)
    let _run_target_args'_v359 = v367 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v368 : Result<std_process_Child, std_string_String> = match v356 with Ok x -> Ok x | Error x -> Error (v357 x)
    let _run_target_args'_v359 = v368 
    #endif
#else
    let v369 : Result<std_process_Child, std_string_String> = match v356 with Ok x -> Ok x | Error x -> Error (v357 x)
    let _run_target_args'_v359 = v369 
    #endif
    let v370 : Result<std_process_Child, std_string_String> = _run_target_args'_v359 
    let v373 : (std_process_Child option -> std_process_Child option) = method101()
    let v374 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v375 : bool = Fable.Core.RustInterop.emitRustExpr v370 v374 
    let v376 : string = "x"
    let v377 : std_process_Child = Fable.Core.RustInterop.emitRustExpr () v376 
    let v379 : std_process_Child option = Some v377 
    let v382 : std_process_Child option = v373 v379
    let v383 : string = "std::sync::Mutex::new(v382)"
    let v384 : std_sync_Mutex<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr () v383 
    let v385 : string = "std::sync::Arc::new(v384)"
    let v386 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr () v385 
    let v387 : string = "true; $0 })"
    let v388 : bool = Fable.Core.RustInterop.emitRustExpr v386 v387 
    let v389 : string = "_result_map_"
    let v390 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v389 
    let v391 : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US24) = method102()
    let v392 : (std_string_String -> US24) = method103()
    let v393 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
    let v394 : US24 = Fable.Core.RustInterop.emitRustExpr struct (v391, v392, v390) v393 
    let struct (v2210 : int32, v2211 : US6, v2212 : US25) =
        match v394 with
        | US24_1(v2073) -> (* Error *)
            let v2138 : unit = ()
            let v2139 : (unit -> unit) = closure45(v0, v1, v2, v3, v4, v5, v6, v29, v126, v2073)
            let v2140 : unit = (fun () -> v2139 (); v2138) ()
            let v2205 : US6 = US6_0(v2073)
            let v2206 : US25 = US25_1
            struct (-1, v2205, v2206)
        | US24_0(v395) -> (* Ok *)
            let v396 : string = "true; let _capture = (|| { //"
            let v397 : bool = Fable.Core.RustInterop.emitRustExpr () v396 
            let v398 : string = "$0"
            let v399 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v395 v398 
            let v400 : string = "v399.lock()"
            let v401 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v400 
            (* run_target_args'
            let v403 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v404 : string = "$0.unwrap()"
            let v405 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v401 v404 
            let _run_target_args'_v403 = v405 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v406 : string = "$0.unwrap()"
            let v407 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v401 v406 
            let _run_target_args'_v403 = v407 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v408 : string = "$0.unwrap()"
            let v409 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v401 v408 
            let _run_target_args'_v403 = v409 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v410 : std_sync_MutexGuard<std_process_Child option> = match v401 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v403 = v410 
            #endif
#if FABLE_COMPILER_PYTHON
            let v411 : std_sync_MutexGuard<std_process_Child option> = match v401 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v403 = v411 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v412 : std_sync_MutexGuard<std_process_Child option> = match v401 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v403 = v412 
            #endif
#else
            let v413 : std_sync_MutexGuard<std_process_Child option> = match v401 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v403 = v413 
            #endif
            let v414 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v403 
            let v417 : std_sync_MutexGuard<std_process_Child option> = method105(v414)
            let v418 : string = "true; let mut v417 = v417"
            let v419 : bool = Fable.Core.RustInterop.emitRustExpr () v418 
            let v420 : string = "&mut $0"
            let v421 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v417 v420 
            let v422 : string = "$0.as_mut()"
            let v423 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v421 v422 
            let v424 : string = "$0.unwrap()"
            let v425 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v423 v424 
            let v426 : string = "&mut $0.stdout"
            let v427 : Ref<Mut<std_process_ChildStdout option>> = Fable.Core.RustInterop.emitRustExpr v425 v426 
            let v428 : string = "Option::take($0)"
            let v429 : std_process_ChildStdout option = Fable.Core.RustInterop.emitRustExpr v427 v428 
            let v430 : string = "$0.unwrap()"
            let v431 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr v429 v430 
            let v432 : string = "true; $0 })()"
            let v433 : bool = Fable.Core.RustInterop.emitRustExpr v431 v432 
            let v434 : string = "_capture"
            let v435 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr () v434 
            let v436 : string = "true; let _capture = (|| { //"
            let v437 : bool = Fable.Core.RustInterop.emitRustExpr () v436 
            let v438 : string = "$0"
            let v439 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v395 v438 
            let v440 : string = "v439.lock()"
            let v441 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v440 
            (* run_target_args'
            let v443 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v444 : string = "$0.unwrap()"
            let v445 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v441 v444 
            let _run_target_args'_v443 = v445 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v446 : string = "$0.unwrap()"
            let v447 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v441 v446 
            let _run_target_args'_v443 = v447 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v448 : string = "$0.unwrap()"
            let v449 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v441 v448 
            let _run_target_args'_v443 = v449 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v450 : std_sync_MutexGuard<std_process_Child option> = match v441 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v443 = v450 
            #endif
#if FABLE_COMPILER_PYTHON
            let v451 : std_sync_MutexGuard<std_process_Child option> = match v441 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v443 = v451 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v452 : std_sync_MutexGuard<std_process_Child option> = match v441 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v443 = v452 
            #endif
#else
            let v453 : std_sync_MutexGuard<std_process_Child option> = match v441 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v443 = v453 
            #endif
            let v454 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v443 
            let v457 : std_sync_MutexGuard<std_process_Child option> = method105(v454)
            let v458 : string = "true; let mut v457 = v457"
            let v459 : bool = Fable.Core.RustInterop.emitRustExpr () v458 
            let v460 : string = "&mut $0"
            let v461 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v457 v460 
            let v462 : string = "$0.as_mut()"
            let v463 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v461 v462 
            let v464 : string = "$0.unwrap()"
            let v465 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v463 v464 
            let v466 : string = "&mut $0.stderr"
            let v467 : Ref<Mut<std_process_ChildStderr option>> = Fable.Core.RustInterop.emitRustExpr v465 v466 
            let v468 : string = "Option::take($0)"
            let v469 : std_process_ChildStderr option = Fable.Core.RustInterop.emitRustExpr v467 v468 
            let v470 : string = "$0.unwrap()"
            let v471 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr v469 v470 
            let v472 : string = "true; $0 })()"
            let v473 : bool = Fable.Core.RustInterop.emitRustExpr v471 v472 
            let v474 : string = "_capture"
            let v475 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr () v474 
            let v476 : string = "true; let _capture = (|| { //"
            let v477 : bool = Fable.Core.RustInterop.emitRustExpr () v476 
            let v478 : string = "$0"
            let v479 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v395 v478 
            let v480 : string = "v479.lock()"
            let v481 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v480 
            (* run_target_args'
            let v483 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v484 : string = "$0.unwrap()"
            let v485 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v481 v484 
            let _run_target_args'_v483 = v485 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v486 : string = "$0.unwrap()"
            let v487 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v481 v486 
            let _run_target_args'_v483 = v487 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v488 : string = "$0.unwrap()"
            let v489 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v481 v488 
            let _run_target_args'_v483 = v489 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v490 : std_sync_MutexGuard<std_process_Child option> = match v481 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v483 = v490 
            #endif
#if FABLE_COMPILER_PYTHON
            let v491 : std_sync_MutexGuard<std_process_Child option> = match v481 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v483 = v491 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v492 : std_sync_MutexGuard<std_process_Child option> = match v481 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v483 = v492 
            #endif
#else
            let v493 : std_sync_MutexGuard<std_process_Child option> = match v481 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v483 = v493 
            #endif
            let v494 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v483 
            let v497 : std_sync_MutexGuard<std_process_Child option> = method105(v494)
            let v498 : string = "true; let mut v497 = v497"
            let v499 : bool = Fable.Core.RustInterop.emitRustExpr () v498 
            let v500 : string = "&mut $0"
            let v501 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v497 v500 
            let v502 : string = "$0.as_mut()"
            let v503 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v501 v502 
            let v504 : string = "$0.unwrap()"
            let v505 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v503 v504 
            let v506 : string = "&mut $0.stdin"
            let v507 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v505 v506 
            let v508 : string = "Option::take($0)"
            let v509 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v507 v508 
            let v510 : string = "$0.unwrap()"
            let v511 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr v509 v510 
            let v513 : std_process_ChildStdin option = Some v511 
            let v516 : (std_process_ChildStdin option -> std_process_ChildStdin option) = method106()
            let v517 : std_process_ChildStdin option = v516 v513
            let v518 : string = "std::sync::Mutex::new(v517)"
            let v519 : std_sync_Mutex<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr () v518 
            let v520 : string = "std::sync::Arc::new(v519)"
            let v521 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v520 
            let v522 : string = "true; $0 })()"
            let v523 : bool = Fable.Core.RustInterop.emitRustExpr v521 v522 
            let v524 : string = "_capture"
            let v525 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v524 
            let v526 : string = "{ let (sender, receiver) = std::sync::mpsc::channel(); (sender, std::sync::Arc::new(receiver)) }"
            let struct (v527 : std_sync_mpsc_Sender<std_string_String>, v528 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = Fable.Core.RustInterop.emitRustExpr () v526 
            let v529 : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) = method107()
            let v530 : std_sync_mpsc_Sender<std_string_String> = v529 v527
            let v531 : string = "std::sync::Mutex::new(v530)"
            let v532 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v531 
            let v533 : string = "std::sync::Arc::new(v532)"
            let v534 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v533 
            let v535 : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) = method108()
            let v536 : std_sync_mpsc_Sender<std_string_String> = v535 v527
            let v537 : string = "std::sync::Mutex::new(v536)"
            let v538 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v537 
            let v539 : string = "std::sync::Arc::new(v538)"
            let v540 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v539 
            let v541 : (std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> -> std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = method109()
            let v542 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> = v541 v528
            let v543 : string = "std::sync::Mutex::new(v542)"
            let v544 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v543 
            let v545 : string = "std::sync::Arc::new(v544)"
            let v546 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v545 
            let v547 : string = "true; let __spawn = std::thread::spawn(move || { //"
            let v548 : bool = Fable.Core.RustInterop.emitRustExpr () v547 
            let v549 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v550 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v435 v549 
            let v551 : string = "std::io::BufReader::new($0)"
            let v552 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr v550 v551 
            let v553 : string = "std::io::BufRead::lines(v552)"
            let v554 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v553 
            let v555 : string = "true; let mut v554 = v554; let _iter_try_for_each = v554.try_for_each(|x| { //"
            let v556 : bool = Fable.Core.RustInterop.emitRustExpr () v555 
            let v557 : string = "x"
            let v558 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v557 
            let v559 : string = "$0.clone()"
            let v560 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v534 v559 
            let v561 : (std_io_Error -> std_string_String) = method63()
            (* run_target_args'
            let v563 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v564 : string = "$0.map_err(|x| $1(x))"
            let v565 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v558, v561) v564 
            let _run_target_args'_v563 = v565 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v566 : string = "$0.map_err(|x| $1(x))"
            let v567 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v558, v561) v566 
            let _run_target_args'_v563 = v567 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v568 : string = "$0.map_err(|x| $1(x))"
            let v569 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v558, v561) v568 
            let _run_target_args'_v563 = v569 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v570 : Result<std_string_String, std_string_String> = match v558 with Ok x -> Ok x | Error x -> Error (v561 x)
            let _run_target_args'_v563 = v570 
            #endif
#if FABLE_COMPILER_PYTHON
            let v571 : Result<std_string_String, std_string_String> = match v558 with Ok x -> Ok x | Error x -> Error (v561 x)
            let _run_target_args'_v563 = v571 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v572 : Result<std_string_String, std_string_String> = match v558 with Ok x -> Ok x | Error x -> Error (v561 x)
            let _run_target_args'_v563 = v572 
            #endif
#else
            let v573 : Result<std_string_String, std_string_String> = match v558 with Ok x -> Ok x | Error x -> Error (v561 x)
            let _run_target_args'_v563 = v573 
            #endif
            let v574 : Result<std_string_String, std_string_String> = _run_target_args'_v563 
            let v577 : (std_string_String -> US26) = method110()
            let v578 : (std_string_String -> US26) = method111()
            let v579 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v580 : US26 = Fable.Core.RustInterop.emitRustExpr struct (v577, v578, v574) v579 
            let v978 : std_string_String =
                match v580 with
                | US26_1(v780) -> (* Error *)
                    let v841 : unit = ()
                    let v842 : (unit -> unit) = closure51(v5, v780)
                    let v843 : unit = (fun () -> v842 (); v841) ()
                    let v904 : string = $"\u001b[4;7m{v780}\u001b[0m"
                    (* run_target_args'
                    let v909 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v910 : string = "&*$0"
                    let v911 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v904 v910 
                    let _run_target_args'_v909 = v911 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v912 : string = "&*$0"
                    let v913 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v904 v912 
                    let _run_target_args'_v909 = v913 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v914 : string = "&*$0"
                    let v915 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v904 v914 
                    let _run_target_args'_v909 = v915 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v917 : Ref<Str> = v904 |> unbox<Ref<Str>>
                    let _run_target_args'_v909 = v917 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v921 : Ref<Str> = v904 |> unbox<Ref<Str>>
                    let _run_target_args'_v909 = v921 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v925 : Ref<Str> = v904 |> unbox<Ref<Str>>
                    let _run_target_args'_v909 = v925 
                    #endif
#else
                    let v929 : Ref<Str> = v904 |> unbox<Ref<Str>>
                    let _run_target_args'_v909 = v929 
                    #endif
                    let v932 : Ref<Str> = _run_target_args'_v909 
                    (* run_target_args'
                    let v945 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v946 : string = "String::from($0)"
                    let v947 : std_string_String = Fable.Core.RustInterop.emitRustExpr v932 v946 
                    let _run_target_args'_v945 = v947 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v948 : string = "String::from($0)"
                    let v949 : std_string_String = Fable.Core.RustInterop.emitRustExpr v932 v948 
                    let _run_target_args'_v945 = v949 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v950 : string = "String::from($0)"
                    let v951 : std_string_String = Fable.Core.RustInterop.emitRustExpr v932 v950 
                    let _run_target_args'_v945 = v951 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v953 : std_string_String = v932 |> unbox<std_string_String>
                    let _run_target_args'_v945 = v953 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v957 : std_string_String = v932 |> unbox<std_string_String>
                    let _run_target_args'_v945 = v957 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v961 : std_string_String = v932 |> unbox<std_string_String>
                    let _run_target_args'_v945 = v961 
                    #endif
#else
                    let v965 : std_string_String = v932 |> unbox<std_string_String>
                    let _run_target_args'_v945 = v965 
                    #endif
                    let v968 : std_string_String = _run_target_args'_v945 
                    v968
                | US26_0(v581) -> (* Ok *)
                    let v582 : string = "fable_library_rust::String_::fromString($0)"
                    let v583 : string = Fable.Core.RustInterop.emitRustExpr v581 v582 
                    let v584 : string = "encoding_rs::UTF_8"
                    let v585 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v584 
                    let v586 : string = "$0.encode(&*$1).0"
                    let v587 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v585, v583) v586 
                    let v588 : string = "$0.as_ref()"
                    let v589 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v587 v588 
                    let v590 : string = "std::str::from_utf8($0)"
                    let v591 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr v589 v590 
                    (* run_target_args'
                    let v593 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v594 : string = "$0.unwrap()"
                    let v595 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v591 v594 
                    let _run_target_args'_v593 = v595 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v596 : string = "$0.unwrap()"
                    let v597 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v591 v596 
                    let _run_target_args'_v593 = v597 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v598 : string = "$0.unwrap()"
                    let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v591 v598 
                    let _run_target_args'_v593 = v599 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v600 : Ref<Str> = match v591 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v593 = v600 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v601 : Ref<Str> = match v591 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v593 = v601 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v602 : Ref<Str> = match v591 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v593 = v602 
                    #endif
#else
                    let v603 : Ref<Str> = match v591 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v593 = v603 
                    #endif
                    let v604 : Ref<Str> = _run_target_args'_v593 
                    (* run_target_args'
                    let v611 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v612 : string = "String::from($0)"
                    let v613 : std_string_String = Fable.Core.RustInterop.emitRustExpr v604 v612 
                    let _run_target_args'_v611 = v613 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v614 : string = "String::from($0)"
                    let v615 : std_string_String = Fable.Core.RustInterop.emitRustExpr v604 v614 
                    let _run_target_args'_v611 = v615 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v616 : string = "String::from($0)"
                    let v617 : std_string_String = Fable.Core.RustInterop.emitRustExpr v604 v616 
                    let _run_target_args'_v611 = v617 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v619 : std_string_String = v604 |> unbox<std_string_String>
                    let _run_target_args'_v611 = v619 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v623 : std_string_String = v604 |> unbox<std_string_String>
                    let _run_target_args'_v611 = v623 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v627 : std_string_String = v604 |> unbox<std_string_String>
                    let _run_target_args'_v611 = v627 
                    #endif
#else
                    let v631 : std_string_String = v604 |> unbox<std_string_String>
                    let _run_target_args'_v611 = v631 
                    #endif
                    let v634 : std_string_String = _run_target_args'_v611 
                    let v643 : string = "fable_library_rust::String_::fromString($0)"
                    let v644 : string = Fable.Core.RustInterop.emitRustExpr v634 v643 
                    let v645 : string = $"> {v644}"
                    if v5 then
                        let v709 : unit = ()
                        let v710 : (unit -> unit) = closure52(v645)
                        let v711 : unit = (fun () -> v710 (); v709) ()
                        ()
                    else
                        let v776 : unit = ()
                        let v777 : (unit -> unit) = closure11(v645)
                        let v778 : unit = (fun () -> v777 (); v776) ()
                        ()
                    v634
            let v979 : string = "$0"
            let v980 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v560 v979 
            let v981 : string = "v980.lock()"
            let v982 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v981 
            (* run_target_args'
            let v984 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v985 : string = "$0.unwrap()"
            let v986 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v982 v985 
            let _run_target_args'_v984 = v986 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v987 : string = "$0.unwrap()"
            let v988 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v982 v987 
            let _run_target_args'_v984 = v988 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v989 : string = "$0.unwrap()"
            let v990 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v982 v989 
            let _run_target_args'_v984 = v990 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v991 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v982 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v984 = v991 
            #endif
#if FABLE_COMPILER_PYTHON
            let v992 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v982 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v984 = v992 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v993 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v982 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v984 = v993 
            #endif
#else
            let v994 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v982 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v984 = v994 
            #endif
            let v995 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = _run_target_args'_v984 
            let v998 : string = "&$0"
            let v999 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v995 v998 
            let v1000 : string = "$0.send($1)"
            let v1001 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v999, v978) v1000 
            let v1002 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method115()
            (* run_target_args'
            let v1004 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1005 : string = "$0.map_err(|x| $1(x))"
            let v1006 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1001, v1002) v1005 
            let _run_target_args'_v1004 = v1006 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1007 : string = "$0.map_err(|x| $1(x))"
            let v1008 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1001, v1002) v1007 
            let _run_target_args'_v1004 = v1008 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1009 : string = "$0.map_err(|x| $1(x))"
            let v1010 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1001, v1002) v1009 
            let _run_target_args'_v1004 = v1010 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1011 : Result<unit, std_string_String> = match v1001 with Ok x -> Ok x | Error x -> Error (v1002 x)
            let _run_target_args'_v1004 = v1011 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1012 : Result<unit, std_string_String> = match v1001 with Ok x -> Ok x | Error x -> Error (v1002 x)
            let _run_target_args'_v1004 = v1012 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1013 : Result<unit, std_string_String> = match v1001 with Ok x -> Ok x | Error x -> Error (v1002 x)
            let _run_target_args'_v1004 = v1013 
            #endif
#else
            let v1014 : Result<unit, std_string_String> = match v1001 with Ok x -> Ok x | Error x -> Error (v1002 x)
            let _run_target_args'_v1004 = v1014 
            #endif
            let v1015 : Result<unit, std_string_String> = _run_target_args'_v1004 
            let v1018 : string = "$0"
            let v1019 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v1015 v1018 
            let v1020 : string = "true; $0 }); //"
            let v1021 : bool = Fable.Core.RustInterop.emitRustExpr v1019 v1020 
            let v1022 : string = "_iter_try_for_each.map_err(|x| x.into())"
            let v1023 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v1022 
            let v1024 : Result<unit, string> = method116(v1023)
            let v1025 : string = ""
            let v1026 : string = "}"
            let v1027 : string = v1025 + v1026 
            let x = v1024 //
            let v1028 : _ = x
            let v1029 : unit = ()
            (* run_target_args'
            let v1030 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1031 : string = $"true; let _fix_closure_v1029 = $0"
            let v1032 : bool = Fable.Core.RustInterop.emitRustExpr v1028 v1031 
            let _run_target_args'_v1030 = true 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1033 : string = $"true; let _fix_closure_v1029 = $0"
            let v1034 : bool = Fable.Core.RustInterop.emitRustExpr v1028 v1033 
            let _run_target_args'_v1030 = true 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1035 : string = $"true; let _fix_closure_v1029 = $0"
            let v1036 : bool = Fable.Core.RustInterop.emitRustExpr v1028 v1035 
            let _run_target_args'_v1030 = true 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let _run_target_args'_v1030 = false 
            #endif
#if FABLE_COMPILER_PYTHON
            let _run_target_args'_v1030 = false 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let _run_target_args'_v1030 = false 
            #endif
#else
            let _run_target_args'_v1030 = false 
            #endif
            let v1037 : bool = _run_target_args'_v1030 
            let v1038 : string = $"true; _fix_closure_v1029 " + v1027 + "); " + v1025 + " // rust.fix_closure'"
            let v1039 : bool = Fable.Core.RustInterop.emitRustExpr () v1038 
            let v1040 : string = "__spawn"
            let v1041 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v1040 
            let v1042 : string = "true; let __spawn = std::thread::spawn(move || { //"
            let v1043 : bool = Fable.Core.RustInterop.emitRustExpr () v1042 
            let v1044 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v1045 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v475 v1044 
            let v1046 : string = "std::io::BufReader::new($0)"
            let v1047 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr v1045 v1046 
            let v1048 : string = "std::io::BufRead::lines(v1047)"
            let v1049 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v1048 
            let v1050 : string = "true; let mut v1049 = v1049; let _iter_try_for_each = v1049.try_for_each(|x| { //"
            let v1051 : bool = Fable.Core.RustInterop.emitRustExpr () v1050 
            let v1052 : string = "x"
            let v1053 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v1052 
            let v1054 : string = "$0.clone()"
            let v1055 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v540 v1054 
            let v1056 : (std_io_Error -> std_string_String) = method63()
            (* run_target_args'
            let v1058 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1059 : string = "$0.map_err(|x| $1(x))"
            let v1060 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1053, v1056) v1059 
            let _run_target_args'_v1058 = v1060 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1061 : string = "$0.map_err(|x| $1(x))"
            let v1062 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1053, v1056) v1061 
            let _run_target_args'_v1058 = v1062 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1063 : string = "$0.map_err(|x| $1(x))"
            let v1064 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1053, v1056) v1063 
            let _run_target_args'_v1058 = v1064 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1065 : Result<std_string_String, std_string_String> = match v1053 with Ok x -> Ok x | Error x -> Error (v1056 x)
            let _run_target_args'_v1058 = v1065 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1066 : Result<std_string_String, std_string_String> = match v1053 with Ok x -> Ok x | Error x -> Error (v1056 x)
            let _run_target_args'_v1058 = v1066 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1067 : Result<std_string_String, std_string_String> = match v1053 with Ok x -> Ok x | Error x -> Error (v1056 x)
            let _run_target_args'_v1058 = v1067 
            #endif
#else
            let v1068 : Result<std_string_String, std_string_String> = match v1053 with Ok x -> Ok x | Error x -> Error (v1056 x)
            let _run_target_args'_v1058 = v1068 
            #endif
            let v1069 : Result<std_string_String, std_string_String> = _run_target_args'_v1058 
            let v1072 : (std_string_String -> US26) = method110()
            let v1073 : (std_string_String -> US26) = method111()
            let v1074 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v1075 : US26 = Fable.Core.RustInterop.emitRustExpr struct (v1072, v1073, v1069) v1074 
            let v1544 : std_string_String =
                match v1075 with
                | US26_1(v1346) -> (* Error *)
                    let v1407 : unit = ()
                    let v1408 : (unit -> unit) = closure51(v5, v1346)
                    let v1409 : unit = (fun () -> v1408 (); v1407) ()
                    let v1470 : string = $"\u001b[4;7m{v1346}\u001b[0m"
                    (* run_target_args'
                    let v1475 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1476 : string = "&*$0"
                    let v1477 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1470 v1476 
                    let _run_target_args'_v1475 = v1477 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1478 : string = "&*$0"
                    let v1479 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1470 v1478 
                    let _run_target_args'_v1475 = v1479 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1480 : string = "&*$0"
                    let v1481 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1470 v1480 
                    let _run_target_args'_v1475 = v1481 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1483 : Ref<Str> = v1470 |> unbox<Ref<Str>>
                    let _run_target_args'_v1475 = v1483 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1487 : Ref<Str> = v1470 |> unbox<Ref<Str>>
                    let _run_target_args'_v1475 = v1487 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1491 : Ref<Str> = v1470 |> unbox<Ref<Str>>
                    let _run_target_args'_v1475 = v1491 
                    #endif
#else
                    let v1495 : Ref<Str> = v1470 |> unbox<Ref<Str>>
                    let _run_target_args'_v1475 = v1495 
                    #endif
                    let v1498 : Ref<Str> = _run_target_args'_v1475 
                    (* run_target_args'
                    let v1511 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1512 : string = "String::from($0)"
                    let v1513 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1498 v1512 
                    let _run_target_args'_v1511 = v1513 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1514 : string = "String::from($0)"
                    let v1515 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1498 v1514 
                    let _run_target_args'_v1511 = v1515 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1516 : string = "String::from($0)"
                    let v1517 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1498 v1516 
                    let _run_target_args'_v1511 = v1517 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1519 : std_string_String = v1498 |> unbox<std_string_String>
                    let _run_target_args'_v1511 = v1519 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1523 : std_string_String = v1498 |> unbox<std_string_String>
                    let _run_target_args'_v1511 = v1523 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1527 : std_string_String = v1498 |> unbox<std_string_String>
                    let _run_target_args'_v1511 = v1527 
                    #endif
#else
                    let v1531 : std_string_String = v1498 |> unbox<std_string_String>
                    let _run_target_args'_v1511 = v1531 
                    #endif
                    let v1534 : std_string_String = _run_target_args'_v1511 
                    v1534
                | US26_0(v1076) -> (* Ok *)
                    let v1077 : string = "fable_library_rust::String_::fromString($0)"
                    let v1078 : string = Fable.Core.RustInterop.emitRustExpr v1076 v1077 
                    let v1079 : string = "encoding_rs::UTF_8"
                    let v1080 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v1079 
                    let v1081 : string = "$0.encode(&*$1).0"
                    let v1082 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v1080, v1078) v1081 
                    let v1083 : string = "$0.as_ref()"
                    let v1084 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v1082 v1083 
                    let v1085 : string = "std::str::from_utf8($0)"
                    let v1086 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr v1084 v1085 
                    (* run_target_args'
                    let v1088 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1089 : string = "$0.unwrap()"
                    let v1090 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1086 v1089 
                    let _run_target_args'_v1088 = v1090 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1091 : string = "$0.unwrap()"
                    let v1092 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1086 v1091 
                    let _run_target_args'_v1088 = v1092 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1093 : string = "$0.unwrap()"
                    let v1094 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1086 v1093 
                    let _run_target_args'_v1088 = v1094 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1095 : Ref<Str> = match v1086 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1088 = v1095 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1096 : Ref<Str> = match v1086 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1088 = v1096 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1097 : Ref<Str> = match v1086 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1088 = v1097 
                    #endif
#else
                    let v1098 : Ref<Str> = match v1086 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1088 = v1098 
                    #endif
                    let v1099 : Ref<Str> = _run_target_args'_v1088 
                    (* run_target_args'
                    let v1106 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1107 : string = "String::from($0)"
                    let v1108 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1099 v1107 
                    let _run_target_args'_v1106 = v1108 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1109 : string = "String::from($0)"
                    let v1110 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1099 v1109 
                    let _run_target_args'_v1106 = v1110 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1111 : string = "String::from($0)"
                    let v1112 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1099 v1111 
                    let _run_target_args'_v1106 = v1112 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1114 : std_string_String = v1099 |> unbox<std_string_String>
                    let _run_target_args'_v1106 = v1114 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1118 : std_string_String = v1099 |> unbox<std_string_String>
                    let _run_target_args'_v1106 = v1118 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1122 : std_string_String = v1099 |> unbox<std_string_String>
                    let _run_target_args'_v1106 = v1122 
                    #endif
#else
                    let v1126 : std_string_String = v1099 |> unbox<std_string_String>
                    let _run_target_args'_v1106 = v1126 
                    #endif
                    let v1129 : std_string_String = _run_target_args'_v1106 
                    let v1138 : string = "fable_library_rust::String_::fromString($0)"
                    let v1139 : string = Fable.Core.RustInterop.emitRustExpr v1129 v1138 
                    let v1140 : string = $"! {v1139}"
                    if v5 then
                        let v1203 : unit = ()
                        let v1204 : (unit -> unit) = closure52(v1140)
                        let v1205 : unit = (fun () -> v1204 (); v1203) ()
                        ()
                    else
                        let v1269 : unit = ()
                        let v1270 : (unit -> unit) = closure11(v1140)
                        let v1271 : unit = (fun () -> v1270 (); v1269) ()
                        ()
                    let v1273 : string = $"\u001b[4;7m{v1129}\u001b[0m"
                    (* run_target_args'
                    let v1278 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1279 : string = "&*$0"
                    let v1280 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1273 v1279 
                    let _run_target_args'_v1278 = v1280 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1281 : string = "&*$0"
                    let v1282 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1273 v1281 
                    let _run_target_args'_v1278 = v1282 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1283 : string = "&*$0"
                    let v1284 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1273 v1283 
                    let _run_target_args'_v1278 = v1284 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1286 : Ref<Str> = v1273 |> unbox<Ref<Str>>
                    let _run_target_args'_v1278 = v1286 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1290 : Ref<Str> = v1273 |> unbox<Ref<Str>>
                    let _run_target_args'_v1278 = v1290 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1294 : Ref<Str> = v1273 |> unbox<Ref<Str>>
                    let _run_target_args'_v1278 = v1294 
                    #endif
#else
                    let v1298 : Ref<Str> = v1273 |> unbox<Ref<Str>>
                    let _run_target_args'_v1278 = v1298 
                    #endif
                    let v1301 : Ref<Str> = _run_target_args'_v1278 
                    (* run_target_args'
                    let v1314 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1315 : string = "String::from($0)"
                    let v1316 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1301 v1315 
                    let _run_target_args'_v1314 = v1316 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1317 : string = "String::from($0)"
                    let v1318 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1301 v1317 
                    let _run_target_args'_v1314 = v1318 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1319 : string = "String::from($0)"
                    let v1320 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1301 v1319 
                    let _run_target_args'_v1314 = v1320 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1322 : std_string_String = v1301 |> unbox<std_string_String>
                    let _run_target_args'_v1314 = v1322 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1326 : std_string_String = v1301 |> unbox<std_string_String>
                    let _run_target_args'_v1314 = v1326 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1330 : std_string_String = v1301 |> unbox<std_string_String>
                    let _run_target_args'_v1314 = v1330 
                    #endif
#else
                    let v1334 : std_string_String = v1301 |> unbox<std_string_String>
                    let _run_target_args'_v1314 = v1334 
                    #endif
                    let v1337 : std_string_String = _run_target_args'_v1314 
                    v1337
            let v1545 : string = "$0"
            let v1546 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v1055 v1545 
            let v1547 : string = "v1546.lock()"
            let v1548 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v1547 
            (* run_target_args'
            let v1550 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1551 : string = "$0.unwrap()"
            let v1552 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1548 v1551 
            let _run_target_args'_v1550 = v1552 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1553 : string = "$0.unwrap()"
            let v1554 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1548 v1553 
            let _run_target_args'_v1550 = v1554 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1555 : string = "$0.unwrap()"
            let v1556 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1548 v1555 
            let _run_target_args'_v1550 = v1556 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1557 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1548 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1550 = v1557 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1558 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1548 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1550 = v1558 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1559 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1548 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1550 = v1559 
            #endif
#else
            let v1560 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1548 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1550 = v1560 
            #endif
            let v1561 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = _run_target_args'_v1550 
            let v1564 : string = "&$0"
            let v1565 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1561 v1564 
            let v1566 : string = "$0.send($1)"
            let v1567 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v1565, v1544) v1566 
            let v1568 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method115()
            (* run_target_args'
            let v1570 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1571 : string = "$0.map_err(|x| $1(x))"
            let v1572 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1567, v1568) v1571 
            let _run_target_args'_v1570 = v1572 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1573 : string = "$0.map_err(|x| $1(x))"
            let v1574 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1567, v1568) v1573 
            let _run_target_args'_v1570 = v1574 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1575 : string = "$0.map_err(|x| $1(x))"
            let v1576 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1567, v1568) v1575 
            let _run_target_args'_v1570 = v1576 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1577 : Result<unit, std_string_String> = match v1567 with Ok x -> Ok x | Error x -> Error (v1568 x)
            let _run_target_args'_v1570 = v1577 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1578 : Result<unit, std_string_String> = match v1567 with Ok x -> Ok x | Error x -> Error (v1568 x)
            let _run_target_args'_v1570 = v1578 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1579 : Result<unit, std_string_String> = match v1567 with Ok x -> Ok x | Error x -> Error (v1568 x)
            let _run_target_args'_v1570 = v1579 
            #endif
#else
            let v1580 : Result<unit, std_string_String> = match v1567 with Ok x -> Ok x | Error x -> Error (v1568 x)
            let _run_target_args'_v1570 = v1580 
            #endif
            let v1581 : Result<unit, std_string_String> = _run_target_args'_v1570 
            let v1584 : string = "$0"
            let v1585 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v1581 v1584 
            let v1586 : string = "true; $0 }); //"
            let v1587 : bool = Fable.Core.RustInterop.emitRustExpr v1585 v1586 
            let v1588 : string = "_iter_try_for_each.map_err(|x| x.into())"
            let v1589 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v1588 
            let v1590 : Result<unit, string> = method116(v1589)
            let v1591 : string = v1025 + v1026 
            let x = v1590 //
            let v1592 : _ = x
            let v1593 : unit = ()
            (* run_target_args'
            let v1594 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1595 : string = $"true; let _fix_closure_v1593 = $0"
            let v1596 : bool = Fable.Core.RustInterop.emitRustExpr v1592 v1595 
            let _run_target_args'_v1594 = true 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1597 : string = $"true; let _fix_closure_v1593 = $0"
            let v1598 : bool = Fable.Core.RustInterop.emitRustExpr v1592 v1597 
            let _run_target_args'_v1594 = true 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1599 : string = $"true; let _fix_closure_v1593 = $0"
            let v1600 : bool = Fable.Core.RustInterop.emitRustExpr v1592 v1599 
            let _run_target_args'_v1594 = true 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let _run_target_args'_v1594 = false 
            #endif
#if FABLE_COMPILER_PYTHON
            let _run_target_args'_v1594 = false 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let _run_target_args'_v1594 = false 
            #endif
#else
            let _run_target_args'_v1594 = false 
            #endif
            let v1601 : bool = _run_target_args'_v1594 
            let v1602 : string = $"true; _fix_closure_v1593 " + v1591 + "); " + v1025 + " // rust.fix_closure'"
            let v1603 : bool = Fable.Core.RustInterop.emitRustExpr () v1602 
            let v1604 : string = "__spawn"
            let v1605 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v1604 
            let v1608 : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US27) = method117()
            let v1609 : US27 option = v4 |> Option.map v1608 
            let v1629 : US27 = US27_1
            let v1630 : US27 = v1609 |> Option.defaultValue v1629 
            match v1630 with
            | US27_1 -> (* None *)
                ()
            | US27_0(v1634) -> (* Some *)
                let v1635 : string = "$0"
                let v1636 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v525 v1635 
                let v1637 : string = "v1636.lock()"
                let v1638 : Result<std_sync_MutexGuard<std_process_ChildStdin option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin option>>> = Fable.Core.RustInterop.emitRustExpr () v1637 
                (* run_target_args'
                let v1640 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1641 : string = "$0.unwrap()"
                let v1642 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1638 v1641 
                let _run_target_args'_v1640 = v1642 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1643 : string = "$0.unwrap()"
                let v1644 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1638 v1643 
                let _run_target_args'_v1640 = v1644 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1645 : string = "$0.unwrap()"
                let v1646 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1638 v1645 
                let _run_target_args'_v1640 = v1646 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1647 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1638 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1640 = v1647 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1648 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1638 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1640 = v1648 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v1649 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1638 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1640 = v1649 
                #endif
#else
                let v1650 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1638 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1640 = v1650 
                #endif
                let v1651 : std_sync_MutexGuard<std_process_ChildStdin option> = _run_target_args'_v1640 
                let v1654 : std_sync_MutexGuard<std_process_ChildStdin option> = method118(v1651)
                let v1655 : string = "true; let mut v1654 = v1654"
                let v1656 : bool = Fable.Core.RustInterop.emitRustExpr () v1655 
                let v1657 : string = "&mut $0"
                let v1658 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v1654 v1657 
                let v1659 : string = "Option::take($0)"
                let v1660 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v1658 v1659 
                let v1661 : string = "true; let _optionm_map_ = $0.map(|x| { //"
                let v1662 : bool = Fable.Core.RustInterop.emitRustExpr v1660 v1661 
                let v1663 : string = "x"
                let v1664 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr () v1663 
                let v1665 : string = "std::sync::Mutex::new(v1664)"
                let v1666 : std_sync_Mutex<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr () v1665 
                let v1667 : string = "std::sync::Arc::new(v1666)"
                let v1668 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr () v1667 
                let v1669 : string = "true; $0 })"
                let v1670 : bool = Fable.Core.RustInterop.emitRustExpr v1668 v1669 
                let v1671 : string = "_optionm_map_"
                let v1672 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> option = Fable.Core.RustInterop.emitRustExpr () v1671 
                let v1675 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US28) = method119()
                let v1676 : US28 option = v1672 |> Option.map v1675 
                let v1696 : US28 = US28_1
                let v1697 : US28 = v1676 |> Option.defaultValue v1696 
                match v1697 with
                | US28_1 -> (* None *)
                    ()
                | US28_0(v1701) -> (* Some *)
                    v1634 v1701
                    let v1702 : string = "$0"
                    let v1703 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr v1701 v1702 
                    let v1704 : string = "v1703.lock()"
                    let v1705 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr () v1704 
                    (* run_target_args'
                    let v1707 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1708 : string = "$0.unwrap()"
                    let v1709 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1705 v1708 
                    let _run_target_args'_v1707 = v1709 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1710 : string = "$0.unwrap()"
                    let v1711 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1705 v1710 
                    let _run_target_args'_v1707 = v1711 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1712 : string = "$0.unwrap()"
                    let v1713 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1705 v1712 
                    let _run_target_args'_v1707 = v1713 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1714 : std_sync_MutexGuard<std_process_ChildStdin> = match v1705 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1707 = v1714 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1715 : std_sync_MutexGuard<std_process_ChildStdin> = match v1705 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1707 = v1715 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1716 : std_sync_MutexGuard<std_process_ChildStdin> = match v1705 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1707 = v1716 
                    #endif
#else
                    let v1717 : std_sync_MutexGuard<std_process_ChildStdin> = match v1705 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1707 = v1717 
                    #endif
                    let v1718 : std_sync_MutexGuard<std_process_ChildStdin> = _run_target_args'_v1707 
                    let v1721 : std_sync_MutexGuard<std_process_ChildStdin> = method120(v1718)
                    let v1722 : string = "true; let mut v1721 = v1721"
                    let v1723 : bool = Fable.Core.RustInterop.emitRustExpr () v1722 
                    let v1724 : string = "true; std::io::Write::flush(&mut *$0).unwrap()"
                    let v1725 : bool = Fable.Core.RustInterop.emitRustExpr v1721 v1724 
                    ()
            let v1726 : string = "$0"
            let v1727 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v395 v1726 
            let v1728 : string = "v1727.lock()"
            let v1729 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v1728 
            (* run_target_args'
            let v1731 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1732 : string = "$0.unwrap()"
            let v1733 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1729 v1732 
            let _run_target_args'_v1731 = v1733 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1734 : string = "$0.unwrap()"
            let v1735 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1729 v1734 
            let _run_target_args'_v1731 = v1735 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1736 : string = "$0.unwrap()"
            let v1737 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1729 v1736 
            let _run_target_args'_v1731 = v1737 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1738 : std_sync_MutexGuard<std_process_Child option> = match v1729 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1731 = v1738 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1739 : std_sync_MutexGuard<std_process_Child option> = match v1729 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1731 = v1739 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1740 : std_sync_MutexGuard<std_process_Child option> = match v1729 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1731 = v1740 
            #endif
#else
            let v1741 : std_sync_MutexGuard<std_process_Child option> = match v1729 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1731 = v1741 
            #endif
            let v1742 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v1731 
            let v1745 : std_sync_MutexGuard<std_process_Child option> = method105(v1742)
            let v1746 : string = "true; let mut v1745 = v1745"
            let v1747 : bool = Fable.Core.RustInterop.emitRustExpr () v1746 
            let v1748 : string = "&mut $0"
            let v1749 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v1745 v1748 
            let v1750 : string = "Option::take($0)"
            let v1751 : std_process_Child option = Fable.Core.RustInterop.emitRustExpr v1749 v1750 
            let v1752 : string = "$0.unwrap()"
            let v1753 : std_process_Child = Fable.Core.RustInterop.emitRustExpr v1751 v1752 
            let v1754 : string = "$0.wait_with_output()"
            let v1755 : Result<std_process_Output, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1753 v1754 
            let v1756 : (std_io_Error -> std_string_String) = method63()
            (* run_target_args'
            let v1758 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1759 : string = "$0.map_err(|x| $1(x))"
            let v1760 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1755, v1756) v1759 
            let _run_target_args'_v1758 = v1760 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1761 : string = "$0.map_err(|x| $1(x))"
            let v1762 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1755, v1756) v1761 
            let _run_target_args'_v1758 = v1762 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1763 : string = "$0.map_err(|x| $1(x))"
            let v1764 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1755, v1756) v1763 
            let _run_target_args'_v1758 = v1764 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1765 : Result<std_process_Output, std_string_String> = match v1755 with Ok x -> Ok x | Error x -> Error (v1756 x)
            let _run_target_args'_v1758 = v1765 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1766 : Result<std_process_Output, std_string_String> = match v1755 with Ok x -> Ok x | Error x -> Error (v1756 x)
            let _run_target_args'_v1758 = v1766 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1767 : Result<std_process_Output, std_string_String> = match v1755 with Ok x -> Ok x | Error x -> Error (v1756 x)
            let _run_target_args'_v1758 = v1767 
            #endif
#else
            let v1768 : Result<std_process_Output, std_string_String> = match v1755 with Ok x -> Ok x | Error x -> Error (v1756 x)
            let _run_target_args'_v1758 = v1768 
            #endif
            let v1769 : Result<std_process_Output, std_string_String> = _run_target_args'_v1758 
            let v1772 : string = "v1605"
            let v1773 : string = v1772 + v1025 
            let v1774 : string = v1773 + v1025 
            let v1775 : string = "v1041"
            let v1776 : string = ", "
            let v1777 : string = v1775 + v1776 
            let v1778 : string = v1777 + v1774 
            let v1779 : string = "vec![" + v1778 + "]"
            let v1780 : Vec<std_thread_JoinHandle<Result<unit, string>>> = Fable.Core.RustInterop.emitRustExpr () v1779 
            let v1781 : string = "true; $0.into_iter().for_each(|x| { //"
            let v1782 : bool = Fable.Core.RustInterop.emitRustExpr v1780 v1781 
            let v1783 : string = "x"
            let v1784 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v1783 
            let v1785 : string = "std::thread::JoinHandle::join($0)"
            let v1786 : Result<Result<unit, string>, Box<LifetimeRef<Dyn<LifetimeJoin<core_any_Any, LifetimeRef<LifetimeJoin<StaticLifetime, Send<StaticLifetime>>>>>>>> = Fable.Core.RustInterop.emitRustExpr v1784 v1785 
            (* run_target_args'
            let v1788 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1789 : string = "$0.unwrap()"
            let v1790 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1786 v1789 
            let _run_target_args'_v1788 = v1790 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1791 : string = "$0.unwrap()"
            let v1792 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1786 v1791 
            let _run_target_args'_v1788 = v1792 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1793 : string = "$0.unwrap()"
            let v1794 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1786 v1793 
            let _run_target_args'_v1788 = v1794 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1795 : Result<unit, string> = match v1786 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1788 = v1795 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1796 : Result<unit, string> = match v1786 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1788 = v1796 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1797 : Result<unit, string> = match v1786 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1788 = v1797 
            #endif
#else
            let v1798 : Result<unit, string> = match v1786 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1788 = v1798 
            #endif
            let v1799 : Result<unit, string> = _run_target_args'_v1788 
            (* run_target_args'
            let v1802 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1803 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1799 v1803 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1804 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1799 v1804 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1805 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1799 v1805 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            match v1799 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#if FABLE_COMPILER_PYTHON
            match v1799 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            match v1799 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#else
            match v1799 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
            // run_target_args' is_unit
            let v1806 : string = $"true"
            let v1807 : bool = Fable.Core.RustInterop.emitRustExpr () v1806 
            let v1808 : string = "true; }}); { //"
            let v1809 : bool = Fable.Core.RustInterop.emitRustExpr () v1808 
            let v1810 : (std_process_Output -> US29) = method121()
            let v1811 : (std_string_String -> US29) = method122()
            let v1813 : US29 = match v1769 with Ok x -> v1810 x | Error x -> v1811 x
            match v1813 with
            | US29_1(v1933) -> (* Error *)
                let v1998 : unit = ()
                let v1999 : (unit -> unit) = closure58(v0, v1, v2, v3, v4, v5, v6, v29, v126, v1933)
                let v2000 : unit = (fun () -> v1999 (); v1998) ()
                let v2065 : US6 = US6_0(v1933)
                let v2066 : US25 = US25_1
                struct (-2, v2065, v2066)
            | US29_0(v1816) -> (* Ok *)
                let v1817 : string = "$0.status"
                let v1818 : std_process_ExitStatus = Fable.Core.RustInterop.emitRustExpr v1816 v1817 
                let v1819 : string = "$0.code()"
                let v1820 : int32 option = Fable.Core.RustInterop.emitRustExpr v1818 v1819 
                let v1823 : (int32 -> US30) = method124()
                let v1824 : US30 option = v1820 |> Option.map v1823 
                let v1844 : US30 = US30_1
                let v1845 : US30 = v1824 |> Option.defaultValue v1844 
                match v1845 with
                | US30_1 -> (* None *)
                    let v1852 : string = "runtime.execute_with_options / exit_code=None"
                    (* run_target_args'
                    let v1857 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1858 : string = "&*$0"
                    let v1859 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1852 v1858 
                    let _run_target_args'_v1857 = v1859 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1860 : string = "&*$0"
                    let v1861 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1852 v1860 
                    let _run_target_args'_v1857 = v1861 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1862 : string = "&*$0"
                    let v1863 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1852 v1862 
                    let _run_target_args'_v1857 = v1863 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1865 : Ref<Str> = v1852 |> unbox<Ref<Str>>
                    let _run_target_args'_v1857 = v1865 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1869 : Ref<Str> = v1852 |> unbox<Ref<Str>>
                    let _run_target_args'_v1857 = v1869 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1873 : Ref<Str> = v1852 |> unbox<Ref<Str>>
                    let _run_target_args'_v1857 = v1873 
                    #endif
#else
                    let v1877 : Ref<Str> = v1852 |> unbox<Ref<Str>>
                    let _run_target_args'_v1857 = v1877 
                    #endif
                    let v1880 : Ref<Str> = _run_target_args'_v1857 
                    (* run_target_args'
                    let v1893 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1894 : string = "String::from($0)"
                    let v1895 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1880 v1894 
                    let _run_target_args'_v1893 = v1895 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1896 : string = "String::from($0)"
                    let v1897 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1880 v1896 
                    let _run_target_args'_v1893 = v1897 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1898 : string = "String::from($0)"
                    let v1899 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1880 v1898 
                    let _run_target_args'_v1893 = v1899 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1901 : std_string_String = v1880 |> unbox<std_string_String>
                    let _run_target_args'_v1893 = v1901 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1905 : std_string_String = v1880 |> unbox<std_string_String>
                    let _run_target_args'_v1893 = v1905 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1909 : std_string_String = v1880 |> unbox<std_string_String>
                    let _run_target_args'_v1893 = v1909 
                    #endif
#else
                    let v1913 : std_string_String = v1880 |> unbox<std_string_String>
                    let _run_target_args'_v1893 = v1913 
                    #endif
                    let v1916 : std_string_String = _run_target_args'_v1893 
                    let v1925 : US6 = US6_0(v1916)
                    let v1926 : US25 = US25_0(v546)
                    struct (-1, v1925, v1926)
                | US30_0(v1849) -> (* Some *)
                    let v1850 : US6 = US6_1
                    let v1851 : US25 = US25_0(v546)
                    struct (v1849, v1850, v1851)
    let v2223 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option =
        match v2212 with
        | US25_1 -> (* None *)
            let v2219 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = None
            v2219
        | US25_0(v2213) -> (* Some *)
            let v2215 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = Some v2213 
            v2215
    let v2224 : string = "true; let _optionm_map_ = $0.map(|x| { //"
    let v2225 : bool = Fable.Core.RustInterop.emitRustExpr v2223 v2224 
    let v2226 : string = "x"
    let v2227 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v2226 
    let v2228 : string = "$0"
    let v2229 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr v2227 v2228 
    let v2230 : string = "v2229.lock()"
    let v2231 : Result<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v2230 
    (* run_target_args'
    let v2233 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2234 : string = "$0.unwrap()"
    let v2235 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v2231 v2234 
    let _run_target_args'_v2233 = v2235 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2236 : string = "$0.unwrap()"
    let v2237 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v2231 v2236 
    let _run_target_args'_v2233 = v2237 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2238 : string = "$0.unwrap()"
    let v2239 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v2231 v2238 
    let _run_target_args'_v2233 = v2239 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2240 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v2231 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v2233 = v2240 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2241 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v2231 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v2233 = v2241 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v2242 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v2231 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v2233 = v2242 
    #endif
#else
    let v2243 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v2231 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v2233 = v2243 
    #endif
    let v2244 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = _run_target_args'_v2233 
    let v2247 : string = "$0.iter()"
    let v2248 : _ = Fable.Core.RustInterop.emitRustExpr v2244 v2247 
    let v2249 : string = "$0.collect::<Vec<_>>()"
    let v2250 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v2248 v2249 
    let v2251 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v2252 : bool = Fable.Core.RustInterop.emitRustExpr v2250 v2251 
    let v2253 : string = "x"
    let v2254 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2253 
    let v2255 : string = "fable_library_rust::String_::fromString($0)"
    let v2256 : string = Fable.Core.RustInterop.emitRustExpr v2254 v2255 
    let v2257 : string = "true; $0 }).collect::<Vec<_>>()"
    let v2258 : bool = Fable.Core.RustInterop.emitRustExpr v2256 v2257 
    let v2259 : string = "_vec_map"
    let v2260 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v2259 
    let v2261 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v2262 : (string []) = Fable.Core.RustInterop.emitRustExpr v2260 v2261 
    let v2264 : string seq = v2262 |> Seq.ofArray
    let v2269 : string = method125()
    let v2270 : (string -> (string seq -> string)) = String.concat
    let v2271 : (string seq -> string) = v2270 v2269
    let v2272 : string = v2271 v2264
    let v2276 : string = "true; $0 })"
    let v2277 : bool = Fable.Core.RustInterop.emitRustExpr v2272 v2276 
    let v2278 : string = "_optionm_map_"
    let v2279 : string option = Fable.Core.RustInterop.emitRustExpr () v2278 
    let v2286 : US5 =
        match v2211 with
        | US6_1 -> (* None *)
            US5_1
        | US6_0(v2280) -> (* Some *)
            let v2281 : string = "fable_library_rust::String_::fromString($0)"
            let v2282 : string = Fable.Core.RustInterop.emitRustExpr v2280 v2281 
            US5_0(v2282)
    let v2290 : string =
        match v2286 with
        | US5_1 -> (* None *)
            let v2288 : string = ""
            v2288
        | US5_0(v2287) -> (* Some *)
            v2287
    let v2292 : string = v2279 |> Option.defaultValue v2290 
    let v2356 : unit = ()
    let v2357 : (unit -> unit) = closure60(v2210, v2292)
    let v2358 : unit = (fun () -> v2357 (); v2356) ()
    let v2421 : (int32 * string) = v2210, v2292 
    v2421 
    )
    |> fun x -> x ()
    ) () )
    |> fun x -> _capture_v259 <- Some x
    let v2424 : (int32 * string) = match _capture_v259 with Some x -> x | None -> failwith "base.capture / _capture_v259=None"
    let (a, b) = v2424 
    let v4592 : int32 = a
    let v4593 : string = b
    let _run_target_args'_v15 = struct (v4592, v4593) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v4600 : int32, v4601 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v4600, v4601) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v4608 : int32, v4609 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v4608, v4609) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v4616 : int32, v4617 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v4616, v4617) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v4624 : int32, v4625 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v4624, v4625) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v4632 : int32, v4633 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v4632, v4633) 
    #endif
#else
    let v4638 : Async<struct (int32 * string)> = method127(v0, v1, v2, v3, v4, v5, v6)
    (* run_target_args'
    let v4647 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v4650 : int32, v4651 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v4647 = struct (v4650, v4651) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v4658 : int32, v4659 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v4647 = struct (v4658, v4659) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v4666 : int32, v4667 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v4647 = struct (v4666, v4667) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v4674 : int32, v4675 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v4647 = struct (v4674, v4675) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v4680 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v4681 : int32, v4682 : string) = v4680 v4638
    let _run_target_args'_v4647 = struct (v4681, v4682) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v4683 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v4684 : int32, v4685 : string) = v4683 v4638
    let _run_target_args'_v4647 = struct (v4684, v4685) 
    #endif
#else
    let v4686 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v4687 : int32, v4688 : string) = v4686 v4638
    let _run_target_args'_v4647 = struct (v4687, v4688) 
    #endif
    let struct (v4689 : int32, v4690 : string) = _run_target_args'_v4647 
    let _run_target_args'_v15 = struct (v4689, v4690) 
    #endif
    let struct (v4701 : int32, v4702 : string) = _run_target_args'_v15 
    struct (v4701, v4702)
and method143 (v0 : string, v1 : string, v2 : string) : struct (string * string) =
    let v3 : string = method43(v1)
    let v4 : string = method26(v2, v3)
    let v5 : string = "."
    let v6 : int32 = v1.LastIndexOf v5 
    let v7 : int32 = v6 - 1
    let v9 : string = v1.[int 0..int v7]
    let v13 : int32 = v4.LastIndexOf v5 
    let v14 : int32 = v13 - 1
    let v16 : string = v4.[int 0..int v14]
    let v22 : string = ".md"
    let v23 : bool = v0.EndsWith (v22, false, null)
    let v26 : bool = v23 = false
    let v29 : string =
        if v26 then
            let v27 : string = $"{v1}.{v0}"
            v27
        else
            let v28 : string = $"{v9}.{v0}"
            v28
    let v32 : string =
        if v26 then
            let v30 : string = $"{v4}.{v0}"
            v30
        else
            let v31 : string = $"{v16}.{v0}"
            v31
    struct (v29, v32)
and method144 () : string =
    let v0 : string = ""
    v0
and closure69 () (v0 : string) : US34 =
    US34_0(v0)
and method145 () : (string -> US34) =
    closure69()
and closure70 () (v0 : std_string_String) : US34 =
    US34_1(v0)
and method146 () : (std_string_String -> US34) =
    closure70()
and method147 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : string, v12 : int32, v13 : string, v14 : int32, v15 : string, v16 : string, v17 : US5, v18 : string, v19 : string) : string =
    let v20 : string = method13()
    let v21 : Mut3 = {l0 = v20} : Mut3
    let v24 : string = "{ "
    let v25 : string = $"{v24}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure8(v21, v25)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v43 : string = "file"
    let v44 : string = $"{v43}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure8(v21, v44)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v62 : string = " = "
    let v63 : string = $"{v62}"
    let v71 : unit = ()
    let v72 : (unit -> unit) = closure8(v21, v63)
    let v73 : unit = (fun () -> v72 (); v71) ()
    let v80 : string = $"{v9}"
    let v88 : unit = ()
    let v89 : (unit -> unit) = closure8(v21, v80)
    let v90 : unit = (fun () -> v89 (); v88) ()
    let v98 : string = "; "
    let v99 : string = $"{v98}"
    let v107 : unit = ()
    let v108 : (unit -> unit) = closure8(v21, v99)
    let v109 : unit = (fun () -> v108 (); v107) ()
    let v117 : string = "real_path"
    let v118 : string = $"{v117}"
    let v126 : unit = ()
    let v127 : (unit -> unit) = closure8(v21, v118)
    let v128 : unit = (fun () -> v127 (); v126) ()
    let v135 : string = $"{v62}"
    let v143 : unit = ()
    let v144 : (unit -> unit) = closure8(v21, v135)
    let v145 : unit = (fun () -> v144 (); v143) ()
    let v152 : string = $"{v10}"
    let v160 : unit = ()
    let v161 : (unit -> unit) = closure8(v21, v152)
    let v162 : unit = (fun () -> v161 (); v160) ()
    let v169 : string = $"{v98}"
    let v177 : unit = ()
    let v178 : (unit -> unit) = closure8(v21, v169)
    let v179 : unit = (fun () -> v178 (); v177) ()
    let v187 : string = "relative_path"
    let v188 : string = $"{v187}"
    let v196 : unit = ()
    let v197 : (unit -> unit) = closure8(v21, v188)
    let v198 : unit = (fun () -> v197 (); v196) ()
    let v205 : string = $"{v62}"
    let v213 : unit = ()
    let v214 : (unit -> unit) = closure8(v21, v205)
    let v215 : unit = (fun () -> v214 (); v213) ()
    let v222 : string = $"{v11}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure8(v21, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v98}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure8(v21, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "origin_hash_exit_code"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure8(v21, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v62}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure8(v21, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v12}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure8(v21, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v312 : string = $"{v98}"
    let v320 : unit = ()
    let v321 : (unit -> unit) = closure8(v21, v312)
    let v322 : unit = (fun () -> v321 (); v320) ()
    let v330 : string = "origin_hash"
    let v331 : string = $"{v330}"
    let v339 : unit = ()
    let v340 : (unit -> unit) = closure8(v21, v331)
    let v341 : unit = (fun () -> v340 (); v339) ()
    let v348 : string = $"{v62}"
    let v356 : unit = ()
    let v357 : (unit -> unit) = closure8(v21, v348)
    let v358 : unit = (fun () -> v357 (); v356) ()
    let v365 : string = $"{v13}"
    let v373 : unit = ()
    let v374 : (unit -> unit) = closure8(v21, v365)
    let v375 : unit = (fun () -> v374 (); v373) ()
    let v382 : string = $"{v98}"
    let v390 : unit = ()
    let v391 : (unit -> unit) = closure8(v21, v382)
    let v392 : unit = (fun () -> v391 (); v390) ()
    let v400 : string = "local_git_hash_exit_code"
    let v401 : string = $"{v400}"
    let v409 : unit = ()
    let v410 : (unit -> unit) = closure8(v21, v401)
    let v411 : unit = (fun () -> v410 (); v409) ()
    let v418 : string = $"{v62}"
    let v426 : unit = ()
    let v427 : (unit -> unit) = closure8(v21, v418)
    let v428 : unit = (fun () -> v427 (); v426) ()
    let v438 : string = $"{v14}"
    let v446 : unit = ()
    let v447 : (unit -> unit) = closure8(v21, v438)
    let v448 : unit = (fun () -> v447 (); v446) ()
    let v455 : string = $"{v98}"
    let v463 : unit = ()
    let v464 : (unit -> unit) = closure8(v21, v455)
    let v465 : unit = (fun () -> v464 (); v463) ()
    let v473 : string = "local_git_hash"
    let v474 : string = $"{v473}"
    let v482 : unit = ()
    let v483 : (unit -> unit) = closure8(v21, v474)
    let v484 : unit = (fun () -> v483 (); v482) ()
    let v491 : string = $"{v62}"
    let v499 : unit = ()
    let v500 : (unit -> unit) = closure8(v21, v491)
    let v501 : unit = (fun () -> v500 (); v499) ()
    let v508 : string = $"{v15}"
    let v516 : unit = ()
    let v517 : (unit -> unit) = closure8(v21, v508)
    let v518 : unit = (fun () -> v517 (); v516) ()
    let v525 : string = $"{v98}"
    let v533 : unit = ()
    let v534 : (unit -> unit) = closure8(v21, v525)
    let v535 : unit = (fun () -> v534 (); v533) ()
    let v543 : string = "hash1"
    let v544 : string = $"{v543}"
    let v552 : unit = ()
    let v553 : (unit -> unit) = closure8(v21, v544)
    let v554 : unit = (fun () -> v553 (); v552) ()
    let v561 : string = $"{v62}"
    let v569 : unit = ()
    let v570 : (unit -> unit) = closure8(v21, v561)
    let v571 : unit = (fun () -> v570 (); v569) ()
    let v578 : string = $"{v16}"
    let v586 : unit = ()
    let v587 : (unit -> unit) = closure8(v21, v578)
    let v588 : unit = (fun () -> v587 (); v586) ()
    let v595 : string = $"{v98}"
    let v603 : unit = ()
    let v604 : (unit -> unit) = closure8(v21, v595)
    let v605 : unit = (fun () -> v604 (); v603) ()
    let v613 : string = "hash2"
    let v614 : string = $"{v613}"
    let v622 : unit = ()
    let v623 : (unit -> unit) = closure8(v21, v614)
    let v624 : unit = (fun () -> v623 (); v622) ()
    let v631 : string = $"{v62}"
    let v639 : unit = ()
    let v640 : (unit -> unit) = closure8(v21, v631)
    let v641 : unit = (fun () -> v640 (); v639) ()
    let v648 : string = $"%A{v17}"
    let v652 : string = $"{v648}"
    let v660 : unit = ()
    let v661 : (unit -> unit) = closure8(v21, v652)
    let v662 : unit = (fun () -> v661 (); v660) ()
    let v669 : string = $"{v98}"
    let v677 : unit = ()
    let v678 : (unit -> unit) = closure8(v21, v669)
    let v679 : unit = (fun () -> v678 (); v677) ()
    let v687 : string = "dist_path"
    let v688 : string = $"{v687}"
    let v696 : unit = ()
    let v697 : (unit -> unit) = closure8(v21, v688)
    let v698 : unit = (fun () -> v697 (); v696) ()
    let v705 : string = $"{v62}"
    let v713 : unit = ()
    let v714 : (unit -> unit) = closure8(v21, v705)
    let v715 : unit = (fun () -> v714 (); v713) ()
    let v722 : string = $"{v18}"
    let v730 : unit = ()
    let v731 : (unit -> unit) = closure8(v21, v722)
    let v732 : unit = (fun () -> v731 (); v730) ()
    let v739 : string = $"{v98}"
    let v747 : unit = ()
    let v748 : (unit -> unit) = closure8(v21, v739)
    let v749 : unit = (fun () -> v748 (); v747) ()
    let v757 : string = "cache_path"
    let v758 : string = $"{v757}"
    let v766 : unit = ()
    let v767 : (unit -> unit) = closure8(v21, v758)
    let v768 : unit = (fun () -> v767 (); v766) ()
    let v775 : string = $"{v62}"
    let v783 : unit = ()
    let v784 : (unit -> unit) = closure8(v21, v775)
    let v785 : unit = (fun () -> v784 (); v783) ()
    let v792 : string = $"{v19}"
    let v800 : unit = ()
    let v801 : (unit -> unit) = closure8(v21, v792)
    let v802 : unit = (fun () -> v801 (); v800) ()
    let v810 : string = " }"
    let v811 : string = $"{v810}"
    let v819 : unit = ()
    let v820 : (unit -> unit) = closure8(v21, v811)
    let v821 : unit = (fun () -> v820 (); v819) ()
    let v827 : string = v21.l0
    let v828 : int64 = v0.l0
    let v831 : string = " "
    let v832 : string = v6 + v831 
    let v836 : string = v832 + v7 
    let v841 : string = " #"
    let v842 : string = v836 + v841 
    let v846 : (int64 -> string) = _.ToString()
    let v847 : string = v846 v828
    let v851 : string = v842 + v847 
    let v855 : string = v851 + v831 
    let v859 : string = v855 + v8 
    let v864 : string = " / "
    let v865 : string = v859 + v864 
    let v869 : string = v865 + v827 
    method16(v869)
and closure71 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : int32, v5 : string, v6 : string, v7 : int32, v8 : string, v9 : string, v10 : US5) () : unit =
    let v11 : US0 = US0_2
    let v12 : bool = method7(v11)
    if v12 then
        let v27 : unit = ()
        let v28 : (unit -> unit) = closure6()
        let v29 : unit = (fun () -> v28 (); v27) ()
        let struct (v50 : Mut0, v51 : Mut1, v52 : Mut2, v53 : Mut3, v54 : Mut4, v55 : int64 option) = TraceState.trace_state.Value
        let v68 : string = method8(v50, v51, v52, v53, v54, v55)
        let v69 : string = method12()
        let v70 : string = "documents.run / par_map"
        let v71 : string = " / origin_hash |> sm'.contains local_git_hash |> not"
        let v72 : string = v70 + v71 
        let v73 : string = " / Some hash2 when hash1 = hash2"
        let v74 : string = v72 + v73 
        let v75 : bool = v74 = ""
        let v78 : string =
            if v75 then
                let v76 : string = ""
                v76
            else
                method147(v50, v51, v52, v53, v54, v55, v68, v69, v74, v1, v2, v0, v4, v3, v7, v6, v9, v10, v5, v8)
        method17(v78)
and closure72 () (v0 : uint64) : US35 =
    US35_0(v0)
and method149 () : (uint64 -> US35) =
    closure72()
and closure73 () (v0 : std_string_String) : US35 =
    US35_1(v0)
and method150 () : (std_string_String -> US35) =
    closure73()
and method151 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : std_string_String) : string =
    let v11 : string = method13()
    let v12 : Mut3 = {l0 = v11} : Mut3
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure8(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "old_path"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure8(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure8(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v71 : string = $"{v8}"
    let v79 : unit = ()
    let v80 : (unit -> unit) = closure8(v12, v71)
    let v81 : unit = (fun () -> v80 (); v79) ()
    let v89 : string = "; "
    let v90 : string = $"{v89}"
    let v98 : unit = ()
    let v99 : (unit -> unit) = closure8(v12, v90)
    let v100 : unit = (fun () -> v99 (); v98) ()
    let v108 : string = "new_path"
    let v109 : string = $"{v108}"
    let v117 : unit = ()
    let v118 : (unit -> unit) = closure8(v12, v109)
    let v119 : unit = (fun () -> v118 (); v117) ()
    let v126 : string = $"{v53}"
    let v134 : unit = ()
    let v135 : (unit -> unit) = closure8(v12, v126)
    let v136 : unit = (fun () -> v135 (); v134) ()
    let v143 : string = $"{v9}"
    let v151 : unit = ()
    let v152 : (unit -> unit) = closure8(v12, v143)
    let v153 : unit = (fun () -> v152 (); v151) ()
    let v160 : string = $"{v89}"
    let v168 : unit = ()
    let v169 : (unit -> unit) = closure8(v12, v160)
    let v170 : unit = (fun () -> v169 (); v168) ()
    let v178 : string = "error"
    let v179 : string = $"{v178}"
    let v187 : unit = ()
    let v188 : (unit -> unit) = closure8(v12, v179)
    let v189 : unit = (fun () -> v188 (); v187) ()
    let v196 : string = $"{v53}"
    let v204 : unit = ()
    let v205 : (unit -> unit) = closure8(v12, v196)
    let v206 : unit = (fun () -> v205 (); v204) ()
    (* run_target_args'
    let v216 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v217 : string = "format!(\"{:#?}\", $0)"
    let v218 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v217 
    let v219 : string = "fable_library_rust::String_::fromString($0)"
    let v220 : string = Fable.Core.RustInterop.emitRustExpr v218 v219 
    let _run_target_args'_v216 = v220 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v221 : string = "format!(\"{:#?}\", $0)"
    let v222 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v221 
    let v223 : string = "fable_library_rust::String_::fromString($0)"
    let v224 : string = Fable.Core.RustInterop.emitRustExpr v222 v223 
    let _run_target_args'_v216 = v224 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v225 : string = "format!(\"{:#?}\", $0)"
    let v226 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v225 
    let v227 : string = "fable_library_rust::String_::fromString($0)"
    let v228 : string = Fable.Core.RustInterop.emitRustExpr v226 v227 
    let _run_target_args'_v216 = v228 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v230 : string = $"%A{v10}"
    let _run_target_args'_v216 = v230 
    #endif
#if FABLE_COMPILER_PYTHON
    let v234 : string = $"%A{v10}"
    let _run_target_args'_v216 = v234 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v238 : string = $"%A{v10}"
    let _run_target_args'_v216 = v238 
    #endif
#else
    let v242 : string = $"%A{v10}"
    let _run_target_args'_v216 = v242 
    #endif
    let v245 : string = _run_target_args'_v216 
    let v255 : string = $"{v245}"
    let v263 : unit = ()
    let v264 : (unit -> unit) = closure8(v12, v255)
    let v265 : unit = (fun () -> v264 (); v263) ()
    let v273 : string = " }"
    let v274 : string = $"{v273}"
    let v282 : unit = ()
    let v283 : (unit -> unit) = closure8(v12, v274)
    let v284 : unit = (fun () -> v283 (); v282) ()
    let v290 : string = v12.l0
    let v291 : int64 = v0.l0
    let v294 : string = " "
    let v295 : string = v6 + v294 
    let v299 : string = v295 + v7 
    let v304 : string = " #"
    let v305 : string = v299 + v304 
    let v309 : (int64 -> string) = _.ToString()
    let v310 : string = v309 v291
    let v314 : string = v305 + v310 
    let v318 : string = v314 + v294 
    let v323 : string = "file_system.file_copy"
    let v324 : string = v318 + v323 
    let v329 : string = " / "
    let v330 : string = v324 + v329 
    let v334 : string = v330 + v290 
    method16(v334)
and closure74 (v0 : string, v1 : string, v2 : std_string_String) () : unit =
    let v3 : US0 = US0_3
    let v4 : bool = method7(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure6()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut0, v43 : Mut1, v44 : Mut2, v45 : Mut3, v46 : Mut4, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method8(v42, v43, v44, v45, v46, v47)
        let v61 : string = method33()
        let v62 : string = method151(v42, v43, v44, v45, v46, v47, v60, v61, v1, v0, v2)
        method17(v62)
and method152 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : uint64) : string =
    let v11 : string = method13()
    let v12 : Mut3 = {l0 = v11} : Mut3
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure8(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "old_path"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure8(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure8(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v71 : string = $"{v8}"
    let v79 : unit = ()
    let v80 : (unit -> unit) = closure8(v12, v71)
    let v81 : unit = (fun () -> v80 (); v79) ()
    let v89 : string = "; "
    let v90 : string = $"{v89}"
    let v98 : unit = ()
    let v99 : (unit -> unit) = closure8(v12, v90)
    let v100 : unit = (fun () -> v99 (); v98) ()
    let v108 : string = "new_path"
    let v109 : string = $"{v108}"
    let v117 : unit = ()
    let v118 : (unit -> unit) = closure8(v12, v109)
    let v119 : unit = (fun () -> v118 (); v117) ()
    let v126 : string = $"{v53}"
    let v134 : unit = ()
    let v135 : (unit -> unit) = closure8(v12, v126)
    let v136 : unit = (fun () -> v135 (); v134) ()
    let v143 : string = $"{v9}"
    let v151 : unit = ()
    let v152 : (unit -> unit) = closure8(v12, v143)
    let v153 : unit = (fun () -> v152 (); v151) ()
    let v160 : string = $"{v89}"
    let v168 : unit = ()
    let v169 : (unit -> unit) = closure8(v12, v160)
    let v170 : unit = (fun () -> v169 (); v168) ()
    let v178 : string = "result"
    let v179 : string = $"{v178}"
    let v187 : unit = ()
    let v188 : (unit -> unit) = closure8(v12, v179)
    let v189 : unit = (fun () -> v188 (); v187) ()
    let v196 : string = $"{v53}"
    let v204 : unit = ()
    let v205 : (unit -> unit) = closure8(v12, v196)
    let v206 : unit = (fun () -> v205 (); v204) ()
    let v216 : string = $"{v10}"
    let v224 : unit = ()
    let v225 : (unit -> unit) = closure8(v12, v216)
    let v226 : unit = (fun () -> v225 (); v224) ()
    let v234 : string = " }"
    let v235 : string = $"{v234}"
    let v243 : unit = ()
    let v244 : (unit -> unit) = closure8(v12, v235)
    let v245 : unit = (fun () -> v244 (); v243) ()
    let v251 : string = v12.l0
    let v252 : int64 = v0.l0
    let v255 : string = " "
    let v256 : string = v6 + v255 
    let v260 : string = v256 + v7 
    let v265 : string = " #"
    let v266 : string = v260 + v265 
    let v270 : (int64 -> string) = _.ToString()
    let v271 : string = v270 v252
    let v275 : string = v266 + v271 
    let v279 : string = v275 + v255 
    let v284 : string = "file_system.file_copy"
    let v285 : string = v279 + v284 
    let v290 : string = " / "
    let v291 : string = v285 + v290 
    let v295 : string = v291 + v251 
    method16(v295)
and closure75 (v0 : string, v1 : string, v2 : uint64) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method7(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure6()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut0, v43 : Mut1, v44 : Mut2, v45 : Mut3, v46 : Mut4, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method8(v42, v43, v44, v45, v46, v47)
        let v61 : string = method61()
        let v62 : string = method152(v42, v43, v44, v45, v46, v47, v60, v61, v1, v0, v2)
        method17(v62)
and method148 (v0 : string, v1 : string) : unit =
    (* run_target_args'
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "std::fs::copy(&*$0, &*$1)"
    let v4 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr struct (v1, v0) v3 
    let v5 : (std_io_Error -> std_string_String) = method63()
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
    let v21 : (uint64 -> US35) = method149()
    let v22 : (std_string_String -> US35) = method150()
    let v24 : US35 = match v18 with Ok x -> v21 x | Error x -> v22 x
    match v24 with
    | US35_1(v151) -> (* Error *)
        let v212 : unit = ()
        let v213 : (unit -> unit) = closure74(v0, v1, v151)
        let v214 : unit = (fun () -> v213 (); v212) ()
        ()
    | US35_0(v27) -> (* Ok *)
        let v88 : unit = ()
        let v89 : (unit -> unit) = closure75(v0, v1, v27)
        let v90 : unit = (fun () -> v89 (); v88) ()
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
and method154 (v0 : Vec<uint8>) : Vec<uint8> =
    v0
and method155 (v0 : int32, v1 : Mut7) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method156 (v0 : string) : string =
    v0
and method157 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure78 (v0 : string) (v1 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : unit =
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
    let v21 : string = method156(v0)
    let v22 : string = "v21.as_bytes()"
    let v23 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : std_sync_MutexGuard<std_process_ChildStdin> = method157(v18)
    let v25 : string = "true; let mut v24 = v24"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr () v25 
    let v27 : string = "true; std::io::Write::write_all(&mut *$0, v23).unwrap()"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v24 v27 
    ()
and method158 (v0 : int32, v1 : Mut8) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method159 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32, v10 : string) : string =
    let v11 : string = method13()
    let v12 : Mut3 = {l0 = v11} : Mut3
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure8(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "exit_code"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure8(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure8(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{v8}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure8(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure8(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "result_len"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure8(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure8(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v9}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure8(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure8(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "output_path"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure8(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure8(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v219 : string = $"{v10}"
    let v227 : unit = ()
    let v228 : (unit -> unit) = closure8(v12, v219)
    let v229 : unit = (fun () -> v228 (); v227) ()
    let v237 : string = " }"
    let v238 : string = $"{v237}"
    let v246 : unit = ()
    let v247 : (unit -> unit) = closure8(v12, v238)
    let v248 : unit = (fun () -> v247 (); v246) ()
    let v254 : string = v12.l0
    let v255 : int64 = v0.l0
    let v258 : string = " "
    let v259 : string = v6 + v258 
    let v263 : string = v259 + v7 
    let v268 : string = " #"
    let v269 : string = v263 + v268 
    let v273 : (int64 -> string) = _.ToString()
    let v274 : string = v273 v255
    let v278 : string = v269 + v274 
    let v282 : string = v278 + v258 
    let v287 : string = "documents.hangul"
    let v288 : string = v282 + v287 
    let v293 : string = " / "
    let v294 : string = v288 + v293 
    let v298 : string = v294 + v254 
    method16(v298)
and closure79 (v0 : string, v1 : int32, v2 : string) () : unit =
    let v3 : US0 = US0_2
    let v4 : bool = method7(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure6()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut0, v43 : Mut1, v44 : Mut2, v45 : Mut3, v46 : Mut4, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method8(v42, v43, v44, v45, v46, v47)
        let v61 : string = method12()
        let v62 : int32 = v2.Length
        let v63 : string = method159(v42, v43, v44, v45, v46, v47, v60, v61, v1, v62, v0)
        method17(v63)
and method153 (v0 : string, v1 : string, v2 : string, v3 : string) : US36 =
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
    let v63 : Vec<uint8> = method154(v54)
    let v64 : string = "std::string::String::from_utf8($0)"
    let v65 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr v63 v64 
    (* run_target_args'
    let v67 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v68 : string = "$0.unwrap()"
    let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v68 
    let _run_target_args'_v67 = v69 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v70 : string = "$0.unwrap()"
    let v71 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v70 
    let _run_target_args'_v67 = v71 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v72 : string = "$0.unwrap()"
    let v73 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v72 
    let _run_target_args'_v67 = v73 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v74 : std_string_String = match v65 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v67 = v74 
    #endif
#if FABLE_COMPILER_PYTHON
    let v75 : std_string_String = match v65 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v67 = v75 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v76 : std_string_String = match v65 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v67 = v76 
    #endif
#else
    let v77 : std_string_String = match v65 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v67 = v77 
    #endif
    let v78 : std_string_String = _run_target_args'_v67 
    let v81 : string = "fable_library_rust::String_::fromString($0)"
    let v82 : string = Fable.Core.RustInterop.emitRustExpr v78 v81 
    let _run_target_args'_v8 = v82 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v84 : string = null |> unbox<string>
    let _run_target_args'_v8 = v84 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v88 : string = null |> unbox<string>
    let _run_target_args'_v8 = v88 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v92 : string = null |> unbox<string>
    let _run_target_args'_v8 = v92 
    #endif
#if FABLE_COMPILER_PYTHON
    let v96 : string = null |> unbox<string>
    let _run_target_args'_v8 = v96 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v100 : string = null |> unbox<string>
    let _run_target_args'_v8 = v100 
    #endif
#else
    let v103 : string = v3 |> System.IO.File.ReadAllText
    let _run_target_args'_v8 = v103 
    #endif
    let v104 : string = _run_target_args'_v8 
    let v120 : string = "\n"
    let v121 : (string []) = v104.Split v120 
    let v124 : int32 = v121.Length
    let v125 : (string []) = Array.zeroCreate<string> (v124)
    let v126 : Mut6 = {l0 = 0} : Mut6
    while method58(v124, v126) do
        let v128 : int32 = v126.l0
        let v129 : string = v121.[int v128]
        let v131 : (unit -> string) = v129.Trim
        let v132 : string = v131 ()
        v125.[int v128] <- v132
        let v135 : int32 = v128 + 1
        v126.l0 <- v135
        ()
    let v136 : int32 = v125.Length
    let v137 : (string []) = Array.zeroCreate<string> (v136)
    let v138 : Mut7 = {l0 = 0; l1 = 0} : Mut7
    while method155(v136, v138) do
        let v140 : int32 = v138.l0
        let v141 : int32 = v138.l1
        let v142 : string = v125.[int v140]
        let v145 : string = ""
        let v146 : bool = v142 <> v145 
        let v150 : int32 =
            if v146 then
                v137.[int v141] <- v142
                let v149 : int32 = v141 + 1
                v149
            else
                v141
        let v151 : int32 = v140 + 1
        v138.l0 <- v151
        v138.l1 <- v150
        ()
    let v152 : int32 = v138.l1
    let v153 : (string []) = Array.zeroCreate<string> (v152)
    let v154 : Mut6 = {l0 = 0} : Mut6
    while method58(v152, v154) do
        let v156 : int32 = v154.l0
        let v157 : string = v137.[int v156]
        v153.[int v156] <- v157
        let v158 : int32 = v156 + 1
        v154.l0 <- v158
        ()
    let v163 : unit = ()
    let _let'_v163 =
        seq {
            for i = 0 to v153.Length - 1 do yield v153.[i]
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v166 : string seq = _let'_v163 
    let v173 : string = method125()
    let v174 : (string -> (string seq -> string)) = String.concat
    let v175 : (string seq -> string) = v174 v173
    let v176 : string = v175 v166
    let v179 : string = $"{v176}

"
    let v181 : System.Threading.CancellationToken option = None
    let v184 : (struct (string * string) []) = [||]
    let v186 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v190 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v194 : string option = None
    (* run_target_args'
    let v198 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v199 : string = "cfg!(windows)"
    let v200 : bool = Fable.Core.RustInterop.emitRustExpr () v199 
    let _run_target_args'_v198 = v200 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v201 : string = "cfg!(windows)"
    let v202 : bool = Fable.Core.RustInterop.emitRustExpr () v201 
    let _run_target_args'_v198 = v202 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v203 : string = "cfg!(windows)"
    let v204 : bool = Fable.Core.RustInterop.emitRustExpr () v203 
    let _run_target_args'_v198 = v204 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v205 : US3 = US3_0
    let v206 : US4 = US4_5(v205)
    let v207 : string = $"platform.is_windows / target: {v206}"
    let v208 : bool = failwith<bool> v207
    let _run_target_args'_v198 = v208 
    #endif
#if FABLE_COMPILER_PYTHON
    let v209 : US3 = US3_0
    let v210 : US4 = US4_6(v209)
    let v211 : string = $"platform.is_windows / target: {v210}"
    let v212 : bool = failwith<bool> v211
    let _run_target_args'_v198 = v212 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v213 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v214 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v215 : bool = v214 v213
    let _run_target_args'_v198 = v215 
    #endif
#else
    let v216 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v217 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v218 : bool = v217 v216
    let _run_target_args'_v198 = v218 
    #endif
    let v219 : bool = _run_target_args'_v198 
    let v230 : string =
        if v219 then
            let v228 : string = ".exe"
            v228
        else
            let v229 : string = ""
            v229
    let v231 : string = $"../alphabet/deps/hangulize/cmd/hangulize/hangulize{v230}"
    let v232 : string = method26(v0, v231)
    let v233 : string = $"{v232} {v1}"
    let v236 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) = closure78(v179)
    let v237 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = Some v236 
    let v241 : bool = true
    let struct (v242 : int32, v243 : string) = method75(v233, v181, v184, v186, v237, v241, v194)
    let v250 : (string []) = v243.Split v120 
    let v253 : int32 = v250.Length
    let v254 : string = ""
    let v255 : Mut8 = {l0 = 0; l1 = v254; l2 = 0; l3 = 0} : Mut8
    while method158(v136, v255) do
        let v257 : int32 = v255.l0
        let struct (v258 : string, v259 : int32, v260 : int32) = v255.l1, v255.l2, v255.l3
        let v261 : string = v125.[int v257]
        let v262 : bool = v261 = ""
        let struct (v286 : string, v287 : int32, v288 : int32) =
            if v262 then
                let v263 : string = $"{v258}
"
                let v264 : int32 = v259 + 1
                let v265 : int32 = v260 + 1
                struct (v263, v264, v265)
            else
                let v266 : int32 = v259 - v260
                let v267 : bool = v266 >= v253
                let v284 : string =
                    if v267 then
                        v258
                    else
                        let v269 : string = v250.[int v266]
                        let v274 : string = "://"
                        let v275 : bool = v269.Contains v274 
                        let v278 : string =
                            if v275 then
                                v261
                            else
                                v269
                        let v279 : int32 = v253 - 1
                        let v280 : bool = v266 = v279
                        if v280 then
                            let v281 : string = $"{v258}{v278}"
                            v281
                        else
                            let v282 : string = $"{v258}{v278}
"
                            v282
                let v285 : int32 = v259 + 1
                struct (v284, v285, v260)
        let v289 : int32 = v257 + 1
        v255.l0 <- v289
        v255.l1 <- v286
        v255.l2 <- v287
        v255.l3 <- v288
        ()
    let struct (v290 : string, v291 : int32, v292 : int32) = v255.l1, v255.l2, v255.l3
    (* run_target_args'
    let v293 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v294 : string = "std::fs::write(&*$0, &*$1).unwrap()"
    Fable.Core.RustInterop.emitRustExpr struct (v2, v290) v294 
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
    System.IO.File.WriteAllText (v2, v290)
    #endif
    // run_target_args' is_unit
    let v356 : unit = ()
    let v357 : (unit -> unit) = closure79(v2, v242, v290)
    let v358 : unit = (fun () -> v357 (); v356) ()
    US36_0(v242, v290)
and method160 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method13()
    let v11 : Mut3 = {l0 = v10} : Mut3
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure8(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "exit_code"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure8(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure8(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{v8}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure8(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure8(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "result"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure8(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure8(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v145 : string = $"{v9}"
    let v153 : unit = ()
    let v154 : (unit -> unit) = closure8(v11, v145)
    let v155 : unit = (fun () -> v154 (); v153) ()
    let v163 : string = " }"
    let v164 : string = $"{v163}"
    let v172 : unit = ()
    let v173 : (unit -> unit) = closure8(v11, v164)
    let v174 : unit = (fun () -> v173 (); v172) ()
    let v180 : string = v11.l0
    let v181 : int64 = v0.l0
    let v184 : string = " "
    let v185 : string = v6 + v184 
    let v189 : string = v185 + v7 
    let v194 : string = " #"
    let v195 : string = v189 + v194 
    let v199 : (int64 -> string) = _.ToString()
    let v200 : string = v199 v181
    let v204 : string = v195 + v200 
    let v208 : string = v204 + v184 
    let v213 : string = "documents.files_fn / error"
    let v214 : string = v208 + v213 
    let v219 : string = " / "
    let v220 : string = v214 + v219 
    let v224 : string = v220 + v180 
    method16(v224)
and closure80 (v0 : string, v1 : int32) () : unit =
    let v2 : US0 = US0_2
    let v3 : bool = method7(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure6()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut0, v42 : Mut1, v43 : Mut2, v44 : Mut3, v45 : Mut4, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method8(v41, v42, v43, v44, v45, v46)
        let v60 : string = method12()
        let v61 : string = method160(v41, v42, v43, v44, v45, v46, v59, v60, v1, v0)
        method17(v61)
and closure77 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) (v5 : string) : US33 =
    let struct (v6 : string, v7 : string) = method143(v5, v4, v0)
    let v8 : bool = method28(v6)
    let v9 : bool = v8 = false
    let v12 : bool =
        if v9 then
            true
        else
            let v10 : bool = method28(v7)
            let v11 : bool = v10 = false
            v11
    let v346 : bool =
        if v12 then
            false
        else
            let v13 : string = method35(v6)
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
            let v127 : unit = ()
            let _let'_v127 =
                seq {
                    for i = 0 to v122.Length - 1 do yield v122.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v130 : string seq = _let'_v127 
            let v136 : string = method144()
            let v138 : bool = v136 = "\n"
            let v140 : string =
                if v138 then
                    method60(v136)
                else
                    v136
            let v141 : (string -> (string seq -> string)) = String.concat
            let v142 : (string seq -> string) = v141 v140
            let v143 : string = v142 v130
            let v147 : Result<string, std_io_Error> = Ok v143 
            let v150 : (std_io_Error -> std_string_String) = method63()
            (* run_target_args'
            let v152 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v153 : string = "$0.map_err(|x| $1(x))"
            let v154 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v147, v150) v153 
            let _run_target_args'_v152 = v154 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v155 : string = "$0.map_err(|x| $1(x))"
            let v156 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v147, v150) v155 
            let _run_target_args'_v152 = v156 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v157 : string = "$0.map_err(|x| $1(x))"
            let v158 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v147, v150) v157 
            let _run_target_args'_v152 = v158 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v159 : Result<string, std_string_String> = match v147 with Ok x -> Ok x | Error x -> Error (v150 x)
            let _run_target_args'_v152 = v159 
            #endif
#if FABLE_COMPILER_PYTHON
            let v160 : Result<string, std_string_String> = match v147 with Ok x -> Ok x | Error x -> Error (v150 x)
            let _run_target_args'_v152 = v160 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v161 : Result<string, std_string_String> = match v147 with Ok x -> Ok x | Error x -> Error (v150 x)
            let _run_target_args'_v152 = v161 
            #endif
#else
            let v162 : Result<string, std_string_String> = match v147 with Ok x -> Ok x | Error x -> Error (v150 x)
            let _run_target_args'_v152 = v162 
            #endif
            let v163 : Result<string, std_string_String> = _run_target_args'_v152 
            let v166 : (string -> US34) = method145()
            let v167 : (std_string_String -> US34) = method146()
            let v168 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v169 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v166, v167, v163) v168 
            let v178 : string =
                match v169 with
                | US34_1(v171) -> (* Error *)
                    let v173 : string = $"resultm.get / Result value was Error: {v171}"
                    failwith<string> v173
                | US34_0(v170) -> (* Ok *)
                    v170
            let v179 : string = method35(v7)
            let v180 : string = "std::fs::File::open(&*v179)"
            let v181 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v180 
            (* run_target_args'
            let v183 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v184 : string = "$0.unwrap()"
            let v185 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v181 v184 
            let _run_target_args'_v183 = v185 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v186 : string = "$0.unwrap()"
            let v187 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v181 v186 
            let _run_target_args'_v183 = v187 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v188 : string = "$0.unwrap()"
            let v189 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v181 v188 
            let _run_target_args'_v183 = v189 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v190 : std_fs_File = match v181 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v183 = v190 
            #endif
#if FABLE_COMPILER_PYTHON
            let v191 : std_fs_File = match v181 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v183 = v191 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v192 : std_fs_File = match v181 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v183 = v192 
            #endif
#else
            let v193 : std_fs_File = match v181 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v183 = v193 
            #endif
            let v194 : std_fs_File = _run_target_args'_v183 
            let v197 : string = "std::io::BufReader::new($0)"
            let v198 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v194 v197 
            let v199 : string = "std::io::BufReader::new($0)"
            let v200 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v198 v199 
            let v201 : string = "true; let mut v200 = v200"
            let v202 : bool = Fable.Core.RustInterop.emitRustExpr () v201 
            let v203 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v203 
            let v204 : string = "result"
            let v205 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v204 
            let v206 : string = "true; let mut v205 = v205"
            let v207 : bool = Fable.Core.RustInterop.emitRustExpr () v206 
            let v209 : unativeint = 0 |> unativeint 
            let v212 : string = "[$0; 1024]"
            let v213 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v212 
            let v214 : string = "true; loop { // rust.loop"
            let v215 : bool = Fable.Core.RustInterop.emitRustExpr () v214 
            let v216 : string = "true; let mut v213 = v213"
            let v217 : bool = Fable.Core.RustInterop.emitRustExpr () v216 
            let v218 : string = "std::io::Read::read(&mut v200, &mut v213)"
            let v219 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v218 
            (* run_target_args'
            let v221 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v222 : string = "$0.unwrap()"
            let v223 : unativeint = Fable.Core.RustInterop.emitRustExpr v219 v222 
            let _run_target_args'_v221 = v223 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v224 : string = "$0.unwrap()"
            let v225 : unativeint = Fable.Core.RustInterop.emitRustExpr v219 v224 
            let _run_target_args'_v221 = v225 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v226 : string = "$0.unwrap()"
            let v227 : unativeint = Fable.Core.RustInterop.emitRustExpr v219 v226 
            let _run_target_args'_v221 = v227 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v228 : unativeint = match v219 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v221 = v228 
            #endif
#if FABLE_COMPILER_PYTHON
            let v229 : unativeint = match v219 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v221 = v229 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : unativeint = match v219 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v221 = v230 
            #endif
#else
            let v231 : unativeint = match v219 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v221 = v231 
            #endif
            let v232 : unativeint = _run_target_args'_v221 
            let v236 : bool = v232 = v209 
            if v236 then
                let v239 : string = "true; break"
                let v240 : bool = Fable.Core.RustInterop.emitRustExpr () v239 
                ()
            let v242 : unativeint = v232 |> unativeint 
            let v246 : unativeint = v242 |> unbox<unativeint>
            let v249 : string = "v213.len()"
            let v250 : unativeint = Fable.Core.RustInterop.emitRustExpr () v249 
            let v252 : bool = v246 = v250 
            let v259 : Ref<Slice'<uint8>> =
                if v252 then
                    let v255 : string = "&v213[v209..]"
                    let v256 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v255 
                    v256
                else
                    let v257 : string = "&v213[$0..$1]"
                    let v258 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v209, v242) v257 
                    v258
            let v260 : string = "sha2::Digest::update(&mut v205, v259)"
            Fable.Core.RustInterop.emitRustExpr () v260 
            let v261 : string = "true; } // rust.loop"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr () v261 
            let v263 : string = "true; } // rust.loop"
            let v264 : bool = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "true; } // rust.loop"
            let v266 : bool = Fable.Core.RustInterop.emitRustExpr () v265 
            let v267 : string = "true; { // rust.loop"
            let v268 : bool = Fable.Core.RustInterop.emitRustExpr () v267 
            let v269 : string = "true; { // rust.loop"
            let v270 : bool = Fable.Core.RustInterop.emitRustExpr () v269 
            let v271 : string = "&sha2::Digest::finalize(v205)"
            let v272 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v271 
            let v273 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v274 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v272 v273 
            let v275 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v276 : bool = Fable.Core.RustInterop.emitRustExpr v274 v275 
            let v277 : string = "x"
            let v278 : uint8 = Fable.Core.RustInterop.emitRustExpr () v277 
            let v279 : string = "format!(\"{:02x}\", $0)"
            let v280 : std_string_String = Fable.Core.RustInterop.emitRustExpr v278 v279 
            let v281 : string = "fable_library_rust::String_::fromString($0)"
            let v282 : string = Fable.Core.RustInterop.emitRustExpr v280 v281 
            let v283 : string = "true; $0 }).collect::<Vec<_>>()"
            let v284 : bool = Fable.Core.RustInterop.emitRustExpr v282 v283 
            let v285 : string = "_vec_map"
            let v286 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v285 
            let v287 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v288 : (string []) = Fable.Core.RustInterop.emitRustExpr v286 v287 
            let v293 : unit = ()
            let _let'_v293 =
                seq {
                    for i = 0 to v288.Length - 1 do yield v288.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v296 : string seq = _let'_v293 
            let v302 : string = method144()
            let v304 : bool = v302 = "\n"
            let v306 : string =
                if v304 then
                    method60(v302)
                else
                    v302
            let v307 : (string -> (string seq -> string)) = String.concat
            let v308 : (string seq -> string) = v307 v306
            let v309 : string = v308 v296
            let v313 : Result<string, std_io_Error> = Ok v309 
            let v316 : (std_io_Error -> std_string_String) = method63()
            (* run_target_args'
            let v318 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v319 : string = "$0.map_err(|x| $1(x))"
            let v320 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v313, v316) v319 
            let _run_target_args'_v318 = v320 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v321 : string = "$0.map_err(|x| $1(x))"
            let v322 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v313, v316) v321 
            let _run_target_args'_v318 = v322 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v323 : string = "$0.map_err(|x| $1(x))"
            let v324 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v313, v316) v323 
            let _run_target_args'_v318 = v324 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v325 : Result<string, std_string_String> = match v313 with Ok x -> Ok x | Error x -> Error (v316 x)
            let _run_target_args'_v318 = v325 
            #endif
#if FABLE_COMPILER_PYTHON
            let v326 : Result<string, std_string_String> = match v313 with Ok x -> Ok x | Error x -> Error (v316 x)
            let _run_target_args'_v318 = v326 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v327 : Result<string, std_string_String> = match v313 with Ok x -> Ok x | Error x -> Error (v316 x)
            let _run_target_args'_v318 = v327 
            #endif
#else
            let v328 : Result<string, std_string_String> = match v313 with Ok x -> Ok x | Error x -> Error (v316 x)
            let _run_target_args'_v318 = v328 
            #endif
            let v329 : Result<string, std_string_String> = _run_target_args'_v318 
            let v332 : (string -> US34) = method145()
            let v333 : (std_string_String -> US34) = method146()
            let v334 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v335 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v332, v333, v329) v334 
            let v344 : string =
                match v335 with
                | US34_1(v337) -> (* Error *)
                    let v339 : string = $"resultm.get / Result value was Error: {v337}"
                    failwith<string> v339
                | US34_0(v336) -> (* Ok *)
                    v336
            let v345 : bool = v178 = v344
            v345
    if v346 then
        US33_1
    else
        let v348 : US36 = method153(v2, v3, v6, v4)
        match v348 with
        | US36_1(v495, v496) -> (* Error *)
            let v498 : (string * string) = v6, v496 
            let v502 : Result<string, (string * string)> = Error v498 
            US33_0(v502)
        | US36_0(v349, v350) -> (* Ok *)
            let v352 : bool = v349 <> 0 
            if v352 then
                let v415 : unit = ()
                let v416 : (unit -> unit) = closure80(v350, v349)
                let v417 : unit = (fun () -> v416 (); v415) ()
                let v479 : (string * string) = v6, v350 
                let v483 : Result<string, (string * string)> = Error v479 
                US33_0(v483)
            else
                let v487 : bool = method28(v6)
                if v487 then
                    method148(v7, v6)
                else
                    let v488 : string = $"documents.files_fn / {v6} should exist"
                    failwith<unit> v488
                let v490 : Result<string, (string * string)> = Ok v6 
                US33_0(v490)
and closure76 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : string) : (string -> US33) =
    closure77(v0, v1, v2, v3, v4)
and method162 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string, v10 : string) : string =
    let v11 : string = method13()
    let v12 : Mut3 = {l0 = v11} : Mut3
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure8(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "exit_code"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure8(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure8(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{v8}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure8(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure8(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "output_path"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure8(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure8(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v146 : string = $"{v9}"
    let v154 : unit = ()
    let v155 : (unit -> unit) = closure8(v12, v146)
    let v156 : unit = (fun () -> v155 (); v154) ()
    let v163 : string = $"{v92}"
    let v171 : unit = ()
    let v172 : (unit -> unit) = closure8(v12, v163)
    let v173 : unit = (fun () -> v172 (); v171) ()
    let v181 : string = "result"
    let v182 : string = $"{v181}"
    let v190 : unit = ()
    let v191 : (unit -> unit) = closure8(v12, v182)
    let v192 : unit = (fun () -> v191 (); v190) ()
    let v199 : string = $"{v53}"
    let v207 : unit = ()
    let v208 : (unit -> unit) = closure8(v12, v199)
    let v209 : unit = (fun () -> v208 (); v207) ()
    let v216 : string = $"{v10}"
    let v224 : unit = ()
    let v225 : (unit -> unit) = closure8(v12, v216)
    let v226 : unit = (fun () -> v225 (); v224) ()
    let v234 : string = " }"
    let v235 : string = $"{v234}"
    let v243 : unit = ()
    let v244 : (unit -> unit) = closure8(v12, v235)
    let v245 : unit = (fun () -> v244 (); v243) ()
    let v251 : string = v12.l0
    let v252 : int64 = v0.l0
    let v255 : string = " "
    let v256 : string = v6 + v255 
    let v260 : string = v256 + v7 
    let v265 : string = " #"
    let v266 : string = v260 + v265 
    let v270 : (int64 -> string) = _.ToString()
    let v271 : string = v270 v252
    let v275 : string = v266 + v271 
    let v279 : string = v275 + v255 
    let v284 : string = "documents.crowbook / result contains ERROR"
    let v285 : string = v279 + v284 
    let v290 : string = " / "
    let v291 : string = v285 + v290 
    let v295 : string = v291 + v251 
    method16(v295)
and closure83 (v0 : string, v1 : string, v2 : int32) () : unit =
    let v3 : US0 = US0_3
    let v4 : bool = method7(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure6()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut0, v43 : Mut1, v44 : Mut2, v45 : Mut3, v46 : Mut4, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method8(v42, v43, v44, v45, v46, v47)
        let v61 : string = method33()
        let v62 : string = method162(v42, v43, v44, v45, v46, v47, v60, v61, v2, v0, v1)
        method17(v62)
and method161 (v0 : bool, v1 : string, v2 : string, v3 : string, v4 : string) : US36 =
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
    let v63 : System.Threading.CancellationToken option = None
    let v66 : (struct (string * string) []) = [||]
    let v68 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v72 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v76 : string option = None
    let v79 : string = $"crowbook --verbose --to {v4}"
    let v80 : string = $" --single \"{v2}\" --output \"{v1}\" {v61}"
    let v81 : string = v79 + v80 
    let v83 : string option = Some v3 
    let v86 : bool = true
    let struct (v87 : int32, v88 : string) = method75(v81, v63, v66, v68, v72, v86, v83)
    let v91 : string = "ERROR"
    let v92 : bool = v88.Contains v91 
    let v95 : bool = v92 = false
    if v95 then
        US36_0(v87, v88)
    else
        let v157 : unit = ()
        let v158 : (unit -> unit) = closure83(v1, v88, v87)
        let v159 : unit = (fun () -> v158 (); v157) ()
        US36_1(v87, v88)
and closure82 (v0 : string, v1 : string, v2 : bool, v3 : string) (v4 : string) : US33 =
    let struct (v5 : string, v6 : string) = method143(v4, v3, v0)
    let v7 : bool = method28(v5)
    let v8 : bool = v7 = false
    let v11 : bool =
        if v8 then
            true
        else
            let v9 : bool = method28(v6)
            let v10 : bool = v9 = false
            v10
    let v345 : bool =
        if v11 then
            false
        else
            let v12 : string = method35(v5)
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
            let v126 : unit = ()
            let _let'_v126 =
                seq {
                    for i = 0 to v121.Length - 1 do yield v121.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v129 : string seq = _let'_v126 
            let v135 : string = method144()
            let v137 : bool = v135 = "\n"
            let v139 : string =
                if v137 then
                    method60(v135)
                else
                    v135
            let v140 : (string -> (string seq -> string)) = String.concat
            let v141 : (string seq -> string) = v140 v139
            let v142 : string = v141 v129
            let v146 : Result<string, std_io_Error> = Ok v142 
            let v149 : (std_io_Error -> std_string_String) = method63()
            (* run_target_args'
            let v151 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v152 : string = "$0.map_err(|x| $1(x))"
            let v153 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v146, v149) v152 
            let _run_target_args'_v151 = v153 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v154 : string = "$0.map_err(|x| $1(x))"
            let v155 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v146, v149) v154 
            let _run_target_args'_v151 = v155 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v156 : string = "$0.map_err(|x| $1(x))"
            let v157 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v146, v149) v156 
            let _run_target_args'_v151 = v157 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v158 : Result<string, std_string_String> = match v146 with Ok x -> Ok x | Error x -> Error (v149 x)
            let _run_target_args'_v151 = v158 
            #endif
#if FABLE_COMPILER_PYTHON
            let v159 : Result<string, std_string_String> = match v146 with Ok x -> Ok x | Error x -> Error (v149 x)
            let _run_target_args'_v151 = v159 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v160 : Result<string, std_string_String> = match v146 with Ok x -> Ok x | Error x -> Error (v149 x)
            let _run_target_args'_v151 = v160 
            #endif
#else
            let v161 : Result<string, std_string_String> = match v146 with Ok x -> Ok x | Error x -> Error (v149 x)
            let _run_target_args'_v151 = v161 
            #endif
            let v162 : Result<string, std_string_String> = _run_target_args'_v151 
            let v165 : (string -> US34) = method145()
            let v166 : (std_string_String -> US34) = method146()
            let v167 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v168 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v165, v166, v162) v167 
            let v177 : string =
                match v168 with
                | US34_1(v170) -> (* Error *)
                    let v172 : string = $"resultm.get / Result value was Error: {v170}"
                    failwith<string> v172
                | US34_0(v169) -> (* Ok *)
                    v169
            let v178 : string = method35(v6)
            let v179 : string = "std::fs::File::open(&*v178)"
            let v180 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v179 
            (* run_target_args'
            let v182 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v183 : string = "$0.unwrap()"
            let v184 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v180 v183 
            let _run_target_args'_v182 = v184 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v185 : string = "$0.unwrap()"
            let v186 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v180 v185 
            let _run_target_args'_v182 = v186 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v187 : string = "$0.unwrap()"
            let v188 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v180 v187 
            let _run_target_args'_v182 = v188 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v189 : std_fs_File = match v180 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v182 = v189 
            #endif
#if FABLE_COMPILER_PYTHON
            let v190 : std_fs_File = match v180 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v182 = v190 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v191 : std_fs_File = match v180 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v182 = v191 
            #endif
#else
            let v192 : std_fs_File = match v180 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v182 = v192 
            #endif
            let v193 : std_fs_File = _run_target_args'_v182 
            let v196 : string = "std::io::BufReader::new($0)"
            let v197 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v193 v196 
            let v198 : string = "std::io::BufReader::new($0)"
            let v199 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v197 v198 
            let v200 : string = "true; let mut v199 = v199"
            let v201 : bool = Fable.Core.RustInterop.emitRustExpr () v200 
            let v202 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v202 
            let v203 : string = "result"
            let v204 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v203 
            let v205 : string = "true; let mut v204 = v204"
            let v206 : bool = Fable.Core.RustInterop.emitRustExpr () v205 
            let v208 : unativeint = 0 |> unativeint 
            let v211 : string = "[$0; 1024]"
            let v212 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v211 
            let v213 : string = "true; loop { // rust.loop"
            let v214 : bool = Fable.Core.RustInterop.emitRustExpr () v213 
            let v215 : string = "true; let mut v212 = v212"
            let v216 : bool = Fable.Core.RustInterop.emitRustExpr () v215 
            let v217 : string = "std::io::Read::read(&mut v199, &mut v212)"
            let v218 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v217 
            (* run_target_args'
            let v220 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v221 : string = "$0.unwrap()"
            let v222 : unativeint = Fable.Core.RustInterop.emitRustExpr v218 v221 
            let _run_target_args'_v220 = v222 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v223 : string = "$0.unwrap()"
            let v224 : unativeint = Fable.Core.RustInterop.emitRustExpr v218 v223 
            let _run_target_args'_v220 = v224 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v225 : string = "$0.unwrap()"
            let v226 : unativeint = Fable.Core.RustInterop.emitRustExpr v218 v225 
            let _run_target_args'_v220 = v226 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v227 : unativeint = match v218 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v220 = v227 
            #endif
#if FABLE_COMPILER_PYTHON
            let v228 : unativeint = match v218 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v220 = v228 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v229 : unativeint = match v218 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v220 = v229 
            #endif
#else
            let v230 : unativeint = match v218 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v220 = v230 
            #endif
            let v231 : unativeint = _run_target_args'_v220 
            let v235 : bool = v231 = v208 
            if v235 then
                let v238 : string = "true; break"
                let v239 : bool = Fable.Core.RustInterop.emitRustExpr () v238 
                ()
            let v241 : unativeint = v231 |> unativeint 
            let v245 : unativeint = v241 |> unbox<unativeint>
            let v248 : string = "v212.len()"
            let v249 : unativeint = Fable.Core.RustInterop.emitRustExpr () v248 
            let v251 : bool = v245 = v249 
            let v258 : Ref<Slice'<uint8>> =
                if v251 then
                    let v254 : string = "&v212[v208..]"
                    let v255 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v254 
                    v255
                else
                    let v256 : string = "&v212[$0..$1]"
                    let v257 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v208, v241) v256 
                    v257
            let v259 : string = "sha2::Digest::update(&mut v204, v258)"
            Fable.Core.RustInterop.emitRustExpr () v259 
            let v260 : string = "true; } // rust.loop"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr () v260 
            let v262 : string = "true; } // rust.loop"
            let v263 : bool = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "true; } // rust.loop"
            let v265 : bool = Fable.Core.RustInterop.emitRustExpr () v264 
            let v266 : string = "true; { // rust.loop"
            let v267 : bool = Fable.Core.RustInterop.emitRustExpr () v266 
            let v268 : string = "true; { // rust.loop"
            let v269 : bool = Fable.Core.RustInterop.emitRustExpr () v268 
            let v270 : string = "&sha2::Digest::finalize(v204)"
            let v271 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v270 
            let v272 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v273 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v271 v272 
            let v274 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v275 : bool = Fable.Core.RustInterop.emitRustExpr v273 v274 
            let v276 : string = "x"
            let v277 : uint8 = Fable.Core.RustInterop.emitRustExpr () v276 
            let v278 : string = "format!(\"{:02x}\", $0)"
            let v279 : std_string_String = Fable.Core.RustInterop.emitRustExpr v277 v278 
            let v280 : string = "fable_library_rust::String_::fromString($0)"
            let v281 : string = Fable.Core.RustInterop.emitRustExpr v279 v280 
            let v282 : string = "true; $0 }).collect::<Vec<_>>()"
            let v283 : bool = Fable.Core.RustInterop.emitRustExpr v281 v282 
            let v284 : string = "_vec_map"
            let v285 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v284 
            let v286 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v287 : (string []) = Fable.Core.RustInterop.emitRustExpr v285 v286 
            let v292 : unit = ()
            let _let'_v292 =
                seq {
                    for i = 0 to v287.Length - 1 do yield v287.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v295 : string seq = _let'_v292 
            let v301 : string = method144()
            let v303 : bool = v301 = "\n"
            let v305 : string =
                if v303 then
                    method60(v301)
                else
                    v301
            let v306 : (string -> (string seq -> string)) = String.concat
            let v307 : (string seq -> string) = v306 v305
            let v308 : string = v307 v295
            let v312 : Result<string, std_io_Error> = Ok v308 
            let v315 : (std_io_Error -> std_string_String) = method63()
            (* run_target_args'
            let v317 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v318 : string = "$0.map_err(|x| $1(x))"
            let v319 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v312, v315) v318 
            let _run_target_args'_v317 = v319 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v320 : string = "$0.map_err(|x| $1(x))"
            let v321 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v312, v315) v320 
            let _run_target_args'_v317 = v321 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v322 : string = "$0.map_err(|x| $1(x))"
            let v323 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v312, v315) v322 
            let _run_target_args'_v317 = v323 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v324 : Result<string, std_string_String> = match v312 with Ok x -> Ok x | Error x -> Error (v315 x)
            let _run_target_args'_v317 = v324 
            #endif
#if FABLE_COMPILER_PYTHON
            let v325 : Result<string, std_string_String> = match v312 with Ok x -> Ok x | Error x -> Error (v315 x)
            let _run_target_args'_v317 = v325 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v326 : Result<string, std_string_String> = match v312 with Ok x -> Ok x | Error x -> Error (v315 x)
            let _run_target_args'_v317 = v326 
            #endif
#else
            let v327 : Result<string, std_string_String> = match v312 with Ok x -> Ok x | Error x -> Error (v315 x)
            let _run_target_args'_v317 = v327 
            #endif
            let v328 : Result<string, std_string_String> = _run_target_args'_v317 
            let v331 : (string -> US34) = method145()
            let v332 : (std_string_String -> US34) = method146()
            let v333 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v334 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v331, v332, v328) v333 
            let v343 : string =
                match v334 with
                | US34_1(v336) -> (* Error *)
                    let v338 : string = $"resultm.get / Result value was Error: {v336}"
                    failwith<string> v338
                | US34_0(v335) -> (* Ok *)
                    v335
            let v344 : bool = v177 = v343
            v344
    if v345 then
        US33_1
    else
        let v347 : US36 = method161(v2, v5, v3, v1, v4)
        match v347 with
        | US36_1(v494, v495) -> (* Error *)
            let v497 : (string * string) = v5, v495 
            let v501 : Result<string, (string * string)> = Error v497 
            US33_0(v501)
        | US36_0(v348, v349) -> (* Ok *)
            let v351 : bool = v348 <> 0 
            if v351 then
                let v414 : unit = ()
                let v415 : (unit -> unit) = closure80(v349, v348)
                let v416 : unit = (fun () -> v415 (); v414) ()
                let v478 : (string * string) = v5, v349 
                let v482 : Result<string, (string * string)> = Error v478 
                US33_0(v482)
            else
                let v486 : bool = method28(v5)
                if v486 then
                    method148(v6, v5)
                else
                    let v487 : string = $"documents.files_fn / {v5} should exist"
                    failwith<unit> v487
                let v489 : Result<string, (string * string)> = Ok v5 
                US33_0(v489)
and closure81 (v0 : string, v1 : string, v2 : bool) (v3 : string) : (string -> US33) =
    closure82(v0, v1, v2, v3)
and method163 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string) : string =
    let v10 : string = method13()
    let v11 : Mut3 = {l0 = v10} : Mut3
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure8(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "output_path"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure8(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure8(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v70 : string = $"{v8}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure8(v11, v70)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v88 : string = "; "
    let v89 : string = $"{v88}"
    let v97 : unit = ()
    let v98 : (unit -> unit) = closure8(v11, v89)
    let v99 : unit = (fun () -> v98 (); v97) ()
    let v107 : string = "output_cache_path"
    let v108 : string = $"{v107}"
    let v116 : unit = ()
    let v117 : (unit -> unit) = closure8(v11, v108)
    let v118 : unit = (fun () -> v117 (); v116) ()
    let v125 : string = $"{v52}"
    let v133 : unit = ()
    let v134 : (unit -> unit) = closure8(v11, v125)
    let v135 : unit = (fun () -> v134 (); v133) ()
    let v142 : string = $"{v9}"
    let v150 : unit = ()
    let v151 : (unit -> unit) = closure8(v11, v142)
    let v152 : unit = (fun () -> v151 (); v150) ()
    let v160 : string = " }"
    let v161 : string = $"{v160}"
    let v169 : unit = ()
    let v170 : (unit -> unit) = closure8(v11, v161)
    let v171 : unit = (fun () -> v170 (); v169) ()
    let v177 : string = v11.l0
    let v178 : int64 = v0.l0
    let v181 : string = " "
    let v182 : string = v6 + v181 
    let v186 : string = v182 + v7 
    let v191 : string = " #"
    let v192 : string = v186 + v191 
    let v196 : (int64 -> string) = _.ToString()
    let v197 : string = v196 v178
    let v201 : string = v192 + v197 
    let v205 : string = v201 + v181 
    let v210 : string = "documents.run / par_map / files' = [] / listm.iter"
    let v211 : string = v205 + v210 
    let v216 : string = " / "
    let v217 : string = v211 + v216 
    let v221 : string = v217 + v177 
    method16(v221)
and closure84 (v0 : string, v1 : string) () : unit =
    let v2 : US0 = US0_2
    let v3 : bool = method7(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure6()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut0, v42 : Mut1, v43 : Mut2, v44 : Mut3, v45 : Mut4, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method8(v41, v42, v43, v44, v45, v46)
        let v60 : string = method12()
        let v61 : string = method163(v41, v42, v43, v44, v45, v46, v59, v60, v1, v0)
        method17(v61)
and method164 (v0 : UH4, v1 : UH5 list) : UH5 list =
    match v0 with
    | UH4_1(v2, v3) -> (* Cons *)
        let v4 : UH5 list = method164(v3, v1)
        let v6 : UH5 list = v2 :: v4 
        v6
    | UH4_0 -> (* Nil *)
        v1
and closure86 (v0 : UH5) (v1 : UH4) : UH4 =
    UH4_1(v0, v1)
and closure85 () (v0 : UH5) : (UH4 -> UH4) =
    closure86(v0)
and method165 () : (UH5 -> (UH4 -> UH4)) =
    closure85()
and method167 (v0 : UH5, v1 : struct (string * string * (string -> (string -> US33))) list) : struct (string * string * (string -> (string -> US33))) list =
    match v0 with
    | UH5_1(v2, v3, v4, v5) -> (* Cons *)
        let v6 : struct (string * string * (string -> (string -> US33))) list = method167(v5, v1)
        let v8 : struct (string * string * (string -> (string -> US33))) list = struct (v2, v3, v4) :: v6 
        v8
    | UH5_0 -> (* Nil *)
        v1
and closure87 () struct (v0 : string, v1 : string, v2 : (string -> (string -> US33))) : Result<string, (string * string)> option =
    let v3 : (string -> US33) = v2 v1
    let v4 : US33 = v3 v0
    match v4 with
    | US33_1 -> (* None *)
        let v11 : Result<string, (string * string)> option = None
        v11
    | US33_0(v5) -> (* Some *)
        let v7 : Result<string, (string * string)> option = Some v5 
        v7
and method168 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and method169 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and method166 (v0 : UH4, v1 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    match v0 with
    | UH4_1(v2, v3) -> (* Cons *)
        let v4 : struct (string * string * (string -> (string -> US33))) list = []
        let v5 : struct (string * string * (string -> (string -> US33))) list = method167(v2, v4)
        let v7 : (struct (string * string * (string -> (string -> US33))) list -> (struct (string * string * (string -> (string -> US33))) [])) = List.toArray
        let v8 : (struct (string * string * (string -> (string -> US33))) []) = v7 v5
        let v11 : string = "$0.to_vec()"
        let v12 : Vec<struct (string * string * (string -> (string -> US33)))> = Fable.Core.RustInterop.emitRustExpr v8 v11 
        let v13 : string = "rayon::iter::IntoParallelIterator::into_par_iter($0)"
        let v14 : rayon_vec_IntoIter<struct (string * string * (string -> (string -> US33)))> = Fable.Core.RustInterop.emitRustExpr v12 v13 
        let v15 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
        let v16 : (struct (string * string * (string -> (string -> US33))) -> Result<string, (string * string)> option) = closure87()
        let v17 : rayon_iter_Map<rayon_vec_IntoIter<struct (string * string * (string -> (string -> US33)))>> = Fable.Core.RustInterop.emitRustExpr struct (v14, v16) v15 
        let v18 : string = "rayon::iter::ParallelIterator::collect($0)"
        let v19 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v17 v18 
        let v20 : Vec<Result<string, (string * string)> option> = method168(v19)
        let v21 : Vec<Result<string, (string * string)> option> = method169(v1)
        let v22 : string = "true; let mut v21 = v21"
        let v23 : bool = Fable.Core.RustInterop.emitRustExpr () v22 
        let v24 : string = "true; v21.extend(v20)"
        let v25 : bool = Fable.Core.RustInterop.emitRustExpr () v24 
        let v26 : string = "v21"
        let v27 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr () v26 
        method166(v3, v27)
    | UH4_0 -> (* Nil *)
        v1
and closure35 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) (v5 : string) : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> =
    let v6 : string = method56(v5)
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
    let v47 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v48 : string = "String::from($0)"
    let v49 : std_string_String = Fable.Core.RustInterop.emitRustExpr v34 v48 
    let _run_target_args'_v47 = v49 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v50 : string = "String::from($0)"
    let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr v34 v50 
    let _run_target_args'_v47 = v51 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v52 : string = "String::from($0)"
    let v53 : std_string_String = Fable.Core.RustInterop.emitRustExpr v34 v52 
    let _run_target_args'_v47 = v53 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v55 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v47 = v55 
    #endif
#if FABLE_COMPILER_PYTHON
    let v59 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v47 = v59 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v63 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v47 = v63 
    #endif
#else
    let v67 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v47 = v67 
    #endif
    let v70 : std_string_String = _run_target_args'_v47 
    (* run_target_args'
    let v83 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v84 : string = "std::path::PathBuf::from($0)"
    let v85 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v70 v84 
    let _run_target_args'_v83 = v85 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v86 : string = "std::path::PathBuf::from($0)"
    let v87 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v70 v86 
    let _run_target_args'_v83 = v87 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v88 : string = "std::path::PathBuf::from($0)"
    let v89 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v70 v88 
    let _run_target_args'_v83 = v89 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v91 : std_path_PathBuf = v70 |> unbox<std_path_PathBuf>
    let _run_target_args'_v83 = v91 
    #endif
#if FABLE_COMPILER_PYTHON
    let v95 : std_path_PathBuf = v70 |> unbox<std_path_PathBuf>
    let _run_target_args'_v83 = v95 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v99 : std_path_PathBuf = v70 |> unbox<std_path_PathBuf>
    let _run_target_args'_v83 = v99 
    #endif
#else
    let v103 : std_path_PathBuf = v70 |> unbox<std_path_PathBuf>
    let _run_target_args'_v83 = v103 
    #endif
    let v106 : std_path_PathBuf = _run_target_args'_v83 
    (* run_target_args'
    let v119 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v120 : string = "$0.display()"
    let v121 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v106 v120 
    let _run_target_args'_v119 = v121 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v122 : string = "$0.display()"
    let v123 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v106 v122 
    let _run_target_args'_v119 = v123 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v124 : string = "$0.display()"
    let v125 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v106 v124 
    let _run_target_args'_v119 = v125 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v127 : std_path_Display = v106 |> unbox<std_path_Display>
    let _run_target_args'_v119 = v127 
    #endif
#if FABLE_COMPILER_PYTHON
    let v131 : std_path_Display = v106 |> unbox<std_path_Display>
    let _run_target_args'_v119 = v131 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v135 : std_path_Display = v106 |> unbox<std_path_Display>
    let _run_target_args'_v119 = v135 
    #endif
#else
    let v139 : std_path_Display = v106 |> unbox<std_path_Display>
    let _run_target_args'_v119 = v139 
    #endif
    let v142 : std_path_Display = _run_target_args'_v119 
    (* run_target_args'
    let v155 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v156 : string = "format!(\"{}\", $0)"
    let v157 : std_string_String = Fable.Core.RustInterop.emitRustExpr v142 v156 
    let _run_target_args'_v155 = v157 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v158 : string = "format!(\"{}\", $0)"
    let v159 : std_string_String = Fable.Core.RustInterop.emitRustExpr v142 v158 
    let _run_target_args'_v155 = v159 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v160 : string = "format!(\"{}\", $0)"
    let v161 : std_string_String = Fable.Core.RustInterop.emitRustExpr v142 v160 
    let _run_target_args'_v155 = v161 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v163 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v155 = v163 
    #endif
#if FABLE_COMPILER_PYTHON
    let v167 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v155 = v167 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v171 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v155 = v171 
    #endif
#else
    let v175 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v155 = v175 
    #endif
    let v178 : std_string_String = _run_target_args'_v155 
    let v187 : string = "fable_library_rust::String_::fromString($0)"
    let v188 : string = Fable.Core.RustInterop.emitRustExpr v178 v187 
    let v189 : string = method73()
    let v190 : string = v188.Replace (v3, v189)
    let v191 : string = "\\"
    let v192 : string = "/"
    let v193 : string = v190.Replace (v191, v192)
    let v194 : string = $".{v193}"
    let v195 : string = method35(v6)
    let v196 : string = method26(v2, v194)
    let v197 : string = method74(v196)
    let v199 : System.Threading.CancellationToken option = None
    let v202 : (struct (string * string) []) = [||]
    let v204 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v208 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v212 : string option = None
    let v215 : string = $"git ls-tree --format='%%(objectname)' origin/gh-pages \"{v197}\""
    let v217 : string option = Some v2 
    let v220 : bool = true
    let struct (v221 : int32, v222 : string) = method75(v215, v199, v202, v204, v208, v220, v217)
    let v223 : string = method26(v3, v194)
    let v224 : string = method74(v223)
    let v226 : System.Threading.CancellationToken option = None
    let v229 : (struct (string * string) []) = [||]
    let v231 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v235 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v239 : string option = None
    let v242 : string = $"git hash-object \"{v224}\""
    let v244 : string option = Some v3 
    let v247 : bool = true
    let struct (v248 : int32, v249 : string) = method75(v242, v226, v229, v231, v235, v247, v244)
    let v250 : string = method26(v4, v194)
    let v251 : string = method74(v250)
    let v252 : string = "hangul.md"
    let struct (v253 : string, v254 : string) = method143(v252, v224, v4)
    let v255 : bool = false
    let v256 : bool = false
    let v257 : bool = false
    let v258 : bool = true
    let v259 : bool = true
    let v260 : bool = true
    let v262 : bool = v222.Contains v249 
    let v926 : UH4 =
        if v262 then
            UH4_0
        else
            let v266 : string = method35(v224)
            let v267 : string = "std::fs::File::open(&*v266)"
            let v268 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v267 
            (* run_target_args'
            let v270 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v271 : string = "$0.unwrap()"
            let v272 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v268 v271 
            let _run_target_args'_v270 = v272 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v273 : string = "$0.unwrap()"
            let v274 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v268 v273 
            let _run_target_args'_v270 = v274 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v275 : string = "$0.unwrap()"
            let v276 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v268 v275 
            let _run_target_args'_v270 = v276 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v277 : std_fs_File = match v268 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v270 = v277 
            #endif
#if FABLE_COMPILER_PYTHON
            let v278 : std_fs_File = match v268 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v270 = v278 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v279 : std_fs_File = match v268 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v270 = v279 
            #endif
#else
            let v280 : std_fs_File = match v268 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v270 = v280 
            #endif
            let v281 : std_fs_File = _run_target_args'_v270 
            let v284 : string = "std::io::BufReader::new($0)"
            let v285 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v281 v284 
            let v286 : string = "std::io::BufReader::new($0)"
            let v287 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v285 v286 
            let v288 : string = "true; let mut v287 = v287"
            let v289 : bool = Fable.Core.RustInterop.emitRustExpr () v288 
            let v290 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v290 
            let v291 : string = "result"
            let v292 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v291 
            let v293 : string = "true; let mut v292 = v292"
            let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
            let v296 : unativeint = 0 |> unativeint 
            let v299 : string = "[$0; 1024]"
            let v300 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v299 
            let v301 : string = "true; loop { // rust.loop"
            let v302 : bool = Fable.Core.RustInterop.emitRustExpr () v301 
            let v303 : string = "true; let mut v300 = v300"
            let v304 : bool = Fable.Core.RustInterop.emitRustExpr () v303 
            let v305 : string = "std::io::Read::read(&mut v287, &mut v300)"
            let v306 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v305 
            (* run_target_args'
            let v308 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v309 : string = "$0.unwrap()"
            let v310 : unativeint = Fable.Core.RustInterop.emitRustExpr v306 v309 
            let _run_target_args'_v308 = v310 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v311 : string = "$0.unwrap()"
            let v312 : unativeint = Fable.Core.RustInterop.emitRustExpr v306 v311 
            let _run_target_args'_v308 = v312 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v313 : string = "$0.unwrap()"
            let v314 : unativeint = Fable.Core.RustInterop.emitRustExpr v306 v313 
            let _run_target_args'_v308 = v314 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v315 : unativeint = match v306 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v308 = v315 
            #endif
#if FABLE_COMPILER_PYTHON
            let v316 : unativeint = match v306 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v308 = v316 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v317 : unativeint = match v306 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v308 = v317 
            #endif
#else
            let v318 : unativeint = match v306 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v308 = v318 
            #endif
            let v319 : unativeint = _run_target_args'_v308 
            let v323 : bool = v319 = v296 
            if v323 then
                let v326 : string = "true; break"
                let v327 : bool = Fable.Core.RustInterop.emitRustExpr () v326 
                ()
            let v329 : unativeint = v319 |> unativeint 
            let v333 : unativeint = v329 |> unbox<unativeint>
            let v336 : string = "v300.len()"
            let v337 : unativeint = Fable.Core.RustInterop.emitRustExpr () v336 
            let v339 : bool = v333 = v337 
            let v346 : Ref<Slice'<uint8>> =
                if v339 then
                    let v342 : string = "&v300[v296..]"
                    let v343 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v342 
                    v343
                else
                    let v344 : string = "&v300[$0..$1]"
                    let v345 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v296, v329) v344 
                    v345
            let v347 : string = "sha2::Digest::update(&mut v292, v346)"
            Fable.Core.RustInterop.emitRustExpr () v347 
            let v348 : string = "true; } // rust.loop"
            let v349 : bool = Fable.Core.RustInterop.emitRustExpr () v348 
            let v350 : string = "true; } // rust.loop"
            let v351 : bool = Fable.Core.RustInterop.emitRustExpr () v350 
            let v352 : string = "true; } // rust.loop"
            let v353 : bool = Fable.Core.RustInterop.emitRustExpr () v352 
            let v354 : string = "true; { // rust.loop"
            let v355 : bool = Fable.Core.RustInterop.emitRustExpr () v354 
            let v356 : string = "true; { // rust.loop"
            let v357 : bool = Fable.Core.RustInterop.emitRustExpr () v356 
            let v358 : string = "&sha2::Digest::finalize(v292)"
            let v359 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v358 
            let v360 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v361 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v359 v360 
            let v362 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v363 : bool = Fable.Core.RustInterop.emitRustExpr v361 v362 
            let v364 : string = "x"
            let v365 : uint8 = Fable.Core.RustInterop.emitRustExpr () v364 
            let v366 : string = "format!(\"{:02x}\", $0)"
            let v367 : std_string_String = Fable.Core.RustInterop.emitRustExpr v365 v366 
            let v368 : string = "fable_library_rust::String_::fromString($0)"
            let v369 : string = Fable.Core.RustInterop.emitRustExpr v367 v368 
            let v370 : string = "true; $0 }).collect::<Vec<_>>()"
            let v371 : bool = Fable.Core.RustInterop.emitRustExpr v369 v370 
            let v372 : string = "_vec_map"
            let v373 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v372 
            let v374 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v375 : (string []) = Fable.Core.RustInterop.emitRustExpr v373 v374 
            let v380 : unit = ()
            let _let'_v380 =
                seq {
                    for i = 0 to v375.Length - 1 do yield v375.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v383 : string seq = _let'_v380 
            let v389 : string = method144()
            let v391 : bool = v389 = "\n"
            let v393 : string =
                if v391 then
                    method60(v389)
                else
                    v389
            let v394 : (string -> (string seq -> string)) = String.concat
            let v395 : (string seq -> string) = v394 v393
            let v396 : string = v395 v383
            let v400 : Result<string, std_io_Error> = Ok v396 
            let v403 : (std_io_Error -> std_string_String) = method63()
            (* run_target_args'
            let v405 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v406 : string = "$0.map_err(|x| $1(x))"
            let v407 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v400, v403) v406 
            let _run_target_args'_v405 = v407 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v408 : string = "$0.map_err(|x| $1(x))"
            let v409 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v400, v403) v408 
            let _run_target_args'_v405 = v409 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v410 : string = "$0.map_err(|x| $1(x))"
            let v411 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v400, v403) v410 
            let _run_target_args'_v405 = v411 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v412 : Result<string, std_string_String> = match v400 with Ok x -> Ok x | Error x -> Error (v403 x)
            let _run_target_args'_v405 = v412 
            #endif
#if FABLE_COMPILER_PYTHON
            let v413 : Result<string, std_string_String> = match v400 with Ok x -> Ok x | Error x -> Error (v403 x)
            let _run_target_args'_v405 = v413 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v414 : Result<string, std_string_String> = match v400 with Ok x -> Ok x | Error x -> Error (v403 x)
            let _run_target_args'_v405 = v414 
            #endif
#else
            let v415 : Result<string, std_string_String> = match v400 with Ok x -> Ok x | Error x -> Error (v403 x)
            let _run_target_args'_v405 = v415 
            #endif
            let v416 : Result<string, std_string_String> = _run_target_args'_v405 
            let v419 : (string -> US34) = method145()
            let v420 : (std_string_String -> US34) = method146()
            let v421 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v422 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v419, v420, v416) v421 
            let v431 : string =
                match v422 with
                | US34_1(v424) -> (* Error *)
                    let v426 : string = $"resultm.get / Result value was Error: {v424}"
                    failwith<string> v426
                | US34_0(v423) -> (* Ok *)
                    v423
            let v432 : bool = method28(v251)
            let v433 : bool = v432 = false
            let v598 : US5 =
                if v433 then
                    US5_1
                else
                    let v435 : string = method35(v251)
                    let v436 : string = "std::fs::File::open(&*v435)"
                    let v437 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v436 
                    (* run_target_args'
                    let v439 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v440 : string = "$0.unwrap()"
                    let v441 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v437 v440 
                    let _run_target_args'_v439 = v441 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v442 : string = "$0.unwrap()"
                    let v443 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v437 v442 
                    let _run_target_args'_v439 = v443 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v444 : string = "$0.unwrap()"
                    let v445 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v437 v444 
                    let _run_target_args'_v439 = v445 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v446 : std_fs_File = match v437 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v439 = v446 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v447 : std_fs_File = match v437 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v439 = v447 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v448 : std_fs_File = match v437 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v439 = v448 
                    #endif
#else
                    let v449 : std_fs_File = match v437 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v439 = v449 
                    #endif
                    let v450 : std_fs_File = _run_target_args'_v439 
                    let v453 : string = "std::io::BufReader::new($0)"
                    let v454 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v450 v453 
                    let v455 : string = "std::io::BufReader::new($0)"
                    let v456 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v454 v455 
                    let v457 : string = "true; let mut v456 = v456"
                    let v458 : bool = Fable.Core.RustInterop.emitRustExpr () v457 
                    let v459 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
                    Fable.Core.RustInterop.emitRustExpr () v459 
                    let v460 : string = "result"
                    let v461 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v460 
                    let v462 : string = "true; let mut v461 = v461"
                    let v463 : bool = Fable.Core.RustInterop.emitRustExpr () v462 
                    let v465 : unativeint = 0 |> unativeint 
                    let v468 : string = "[$0; 1024]"
                    let v469 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v468 
                    let v470 : string = "true; loop { // rust.loop"
                    let v471 : bool = Fable.Core.RustInterop.emitRustExpr () v470 
                    let v472 : string = "true; let mut v469 = v469"
                    let v473 : bool = Fable.Core.RustInterop.emitRustExpr () v472 
                    let v474 : string = "std::io::Read::read(&mut v456, &mut v469)"
                    let v475 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v474 
                    (* run_target_args'
                    let v477 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v478 : string = "$0.unwrap()"
                    let v479 : unativeint = Fable.Core.RustInterop.emitRustExpr v475 v478 
                    let _run_target_args'_v477 = v479 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v480 : string = "$0.unwrap()"
                    let v481 : unativeint = Fable.Core.RustInterop.emitRustExpr v475 v480 
                    let _run_target_args'_v477 = v481 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v482 : string = "$0.unwrap()"
                    let v483 : unativeint = Fable.Core.RustInterop.emitRustExpr v475 v482 
                    let _run_target_args'_v477 = v483 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v484 : unativeint = match v475 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v477 = v484 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v485 : unativeint = match v475 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v477 = v485 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v486 : unativeint = match v475 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v477 = v486 
                    #endif
#else
                    let v487 : unativeint = match v475 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v477 = v487 
                    #endif
                    let v488 : unativeint = _run_target_args'_v477 
                    let v492 : bool = v488 = v465 
                    if v492 then
                        let v495 : string = "true; break"
                        let v496 : bool = Fable.Core.RustInterop.emitRustExpr () v495 
                        ()
                    let v498 : unativeint = v488 |> unativeint 
                    let v502 : unativeint = v498 |> unbox<unativeint>
                    let v505 : string = "v469.len()"
                    let v506 : unativeint = Fable.Core.RustInterop.emitRustExpr () v505 
                    let v508 : bool = v502 = v506 
                    let v515 : Ref<Slice'<uint8>> =
                        if v508 then
                            let v511 : string = "&v469[v465..]"
                            let v512 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v511 
                            v512
                        else
                            let v513 : string = "&v469[$0..$1]"
                            let v514 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v465, v498) v513 
                            v514
                    let v516 : string = "sha2::Digest::update(&mut v461, v515)"
                    Fable.Core.RustInterop.emitRustExpr () v516 
                    let v517 : string = "true; } // rust.loop"
                    let v518 : bool = Fable.Core.RustInterop.emitRustExpr () v517 
                    let v519 : string = "true; } // rust.loop"
                    let v520 : bool = Fable.Core.RustInterop.emitRustExpr () v519 
                    let v521 : string = "true; } // rust.loop"
                    let v522 : bool = Fable.Core.RustInterop.emitRustExpr () v521 
                    let v523 : string = "true; { // rust.loop"
                    let v524 : bool = Fable.Core.RustInterop.emitRustExpr () v523 
                    let v525 : string = "true; { // rust.loop"
                    let v526 : bool = Fable.Core.RustInterop.emitRustExpr () v525 
                    let v527 : string = "&sha2::Digest::finalize(v461)"
                    let v528 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v527 
                    let v529 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
                    let v530 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v528 v529 
                    let v531 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
                    let v532 : bool = Fable.Core.RustInterop.emitRustExpr v530 v531 
                    let v533 : string = "x"
                    let v534 : uint8 = Fable.Core.RustInterop.emitRustExpr () v533 
                    let v535 : string = "format!(\"{:02x}\", $0)"
                    let v536 : std_string_String = Fable.Core.RustInterop.emitRustExpr v534 v535 
                    let v537 : string = "fable_library_rust::String_::fromString($0)"
                    let v538 : string = Fable.Core.RustInterop.emitRustExpr v536 v537 
                    let v539 : string = "true; $0 }).collect::<Vec<_>>()"
                    let v540 : bool = Fable.Core.RustInterop.emitRustExpr v538 v539 
                    let v541 : string = "_vec_map"
                    let v542 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v541 
                    let v543 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
                    let v544 : (string []) = Fable.Core.RustInterop.emitRustExpr v542 v543 
                    let v549 : unit = ()
                    let _let'_v549 =
                        seq {
                            for i = 0 to v544.Length - 1 do yield v544.[i]
                            (* indent
                            ()
                        indent *)
                        }
                        (* indent
                        ()
                    indent *)
                    let v552 : string seq = _let'_v549 
                    let v558 : string = method144()
                    let v560 : bool = v558 = "\n"
                    let v562 : string =
                        if v560 then
                            method60(v558)
                        else
                            v558
                    let v563 : (string -> (string seq -> string)) = String.concat
                    let v564 : (string seq -> string) = v563 v562
                    let v565 : string = v564 v552
                    let v569 : Result<string, std_io_Error> = Ok v565 
                    let v572 : (std_io_Error -> std_string_String) = method63()
                    (* run_target_args'
                    let v574 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v575 : string = "$0.map_err(|x| $1(x))"
                    let v576 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v569, v572) v575 
                    let _run_target_args'_v574 = v576 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v577 : string = "$0.map_err(|x| $1(x))"
                    let v578 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v569, v572) v577 
                    let _run_target_args'_v574 = v578 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v579 : string = "$0.map_err(|x| $1(x))"
                    let v580 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v569, v572) v579 
                    let _run_target_args'_v574 = v580 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v581 : Result<string, std_string_String> = match v569 with Ok x -> Ok x | Error x -> Error (v572 x)
                    let _run_target_args'_v574 = v581 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v582 : Result<string, std_string_String> = match v569 with Ok x -> Ok x | Error x -> Error (v572 x)
                    let _run_target_args'_v574 = v582 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v583 : Result<string, std_string_String> = match v569 with Ok x -> Ok x | Error x -> Error (v572 x)
                    let _run_target_args'_v574 = v583 
                    #endif
#else
                    let v584 : Result<string, std_string_String> = match v569 with Ok x -> Ok x | Error x -> Error (v572 x)
                    let _run_target_args'_v574 = v584 
                    #endif
                    let v585 : Result<string, std_string_String> = _run_target_args'_v574 
                    let v588 : (string -> US34) = method145()
                    let v589 : (std_string_String -> US34) = method146()
                    let v590 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
                    let v591 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v588, v589, v585) v590 
                    match v591 with
                    | US34_1(v594) -> (* Error *)
                        US5_1
                    | US34_0(v592) -> (* Ok *)
                        US5_0(v592)
            match v598 with
            | US5_0(v599) -> (* Some *)
                let v600 : bool = v431 = v599
                if v600 then
                    UH4_0
                else
                    let v670 : unit = ()
                    let v671 : (unit -> unit) = closure71(v194, v195, v197, v222, v221, v224, v249, v248, v251, v431, v598)
                    let v672 : unit = (fun () -> v671 (); v670) ()
                    method148(v251, v224)
                    let v741 : (string -> (string -> US33)) = closure76(v4, v3, v1, v0)
                    let v742 : UH5 = UH5_0
                    let v743 : UH5 = UH5_1(v252, v224, v741, v742)
                    let v744 : string = "html"
                    let v745 : (string -> (string -> US33)) = closure81(v4, v3, v255)
                    let v746 : string = "pdf"
                    let v747 : (string -> (string -> US33)) = closure81(v4, v3, v256)
                    let v748 : string = "epub"
                    let v749 : (string -> (string -> US33)) = closure81(v4, v3, v257)
                    let v750 : (string -> (string -> US33)) = closure81(v4, v3, v258)
                    let v751 : (string -> (string -> US33)) = closure81(v4, v3, v259)
                    let v752 : (string -> (string -> US33)) = closure81(v4, v3, v260)
                    let v753 : UH5 = UH5_0
                    let v754 : UH5 = UH5_1(v748, v253, v752, v753)
                    let v755 : UH5 = UH5_1(v746, v253, v751, v754)
                    let v756 : UH5 = UH5_1(v744, v253, v750, v755)
                    let v757 : UH5 = UH5_1(v748, v224, v749, v756)
                    let v758 : UH5 = UH5_1(v746, v224, v747, v757)
                    let v759 : UH5 = UH5_1(v744, v224, v745, v758)
                    let v760 : UH4 = UH4_0
                    let v761 : UH4 = UH4_1(v759, v760)
                    UH4_1(v743, v761)
            | _ ->
                let v832 : unit = ()
                let v833 : (unit -> unit) = closure71(v194, v195, v197, v222, v221, v224, v249, v248, v251, v431, v598)
                let v834 : unit = (fun () -> v833 (); v832) ()
                method148(v251, v224)
                let v903 : (string -> (string -> US33)) = closure76(v4, v3, v1, v0)
                let v904 : UH5 = UH5_0
                let v905 : UH5 = UH5_1(v252, v224, v903, v904)
                let v906 : string = "html"
                let v907 : (string -> (string -> US33)) = closure81(v4, v3, v255)
                let v908 : string = "pdf"
                let v909 : (string -> (string -> US33)) = closure81(v4, v3, v256)
                let v910 : string = "epub"
                let v911 : (string -> (string -> US33)) = closure81(v4, v3, v257)
                let v912 : (string -> (string -> US33)) = closure81(v4, v3, v258)
                let v913 : (string -> (string -> US33)) = closure81(v4, v3, v259)
                let v914 : (string -> (string -> US33)) = closure81(v4, v3, v260)
                let v915 : UH5 = UH5_0
                let v916 : UH5 = UH5_1(v910, v253, v914, v915)
                let v917 : UH5 = UH5_1(v908, v253, v913, v916)
                let v918 : UH5 = UH5_1(v906, v253, v912, v917)
                let v919 : UH5 = UH5_1(v910, v224, v911, v918)
                let v920 : UH5 = UH5_1(v908, v224, v909, v919)
                let v921 : UH5 = UH5_1(v906, v224, v907, v920)
                let v922 : UH4 = UH4_0
                let v923 : UH4 = UH4_1(v921, v922)
                UH4_1(v905, v923)
    let v927 : bool =
        match v926 with
        | UH4_0 -> (* Nil *)
            true
        | _ ->
            false
    let v928 : bool = v927 <> true
    let v1870 : UH4 =
        if v928 then
            v926
        else
            let v929 : string = "epub"
            let struct (v930 : string, v931 : string) = method143(v929, v253, v4)
            let v932 : bool = method28(v930)
            let v1059 : bool =
                if v932 then
                    true
                else
                    let v933 : bool = method28(v931)
                    let v934 : bool = v933 = false
                    if v934 then
                        true
                    else
                        let v995 : unit = ()
                        let v996 : (unit -> unit) = closure84(v931, v930)
                        let v997 : unit = (fun () -> v996 (); v995) ()
                        method148(v930, v931)
                        false
            let v1064 : UH5 =
                if v1059 then
                    let v1060 : (string -> (string -> US33)) = closure81(v4, v3, v260)
                    let v1061 : UH5 = UH5_0
                    UH5_1(v929, v253, v1060, v1061)
                else
                    UH5_0
            let v1065 : string = "pdf"
            let struct (v1066 : string, v1067 : string) = method143(v1065, v253, v4)
            let v1068 : bool = method28(v1066)
            let v1195 : bool =
                if v1068 then
                    true
                else
                    let v1069 : bool = method28(v1067)
                    let v1070 : bool = v1069 = false
                    if v1070 then
                        true
                    else
                        let v1131 : unit = ()
                        let v1132 : (unit -> unit) = closure84(v1067, v1066)
                        let v1133 : unit = (fun () -> v1132 (); v1131) ()
                        method148(v1066, v1067)
                        false
            let v1198 : UH5 =
                if v1195 then
                    let v1196 : (string -> (string -> US33)) = closure81(v4, v3, v259)
                    UH5_1(v1065, v253, v1196, v1064)
                else
                    v1064
            let v1199 : string = "html"
            let struct (v1200 : string, v1201 : string) = method143(v1199, v253, v4)
            let v1202 : bool = method28(v1200)
            let v1329 : bool =
                if v1202 then
                    true
                else
                    let v1203 : bool = method28(v1201)
                    let v1204 : bool = v1203 = false
                    if v1204 then
                        true
                    else
                        let v1265 : unit = ()
                        let v1266 : (unit -> unit) = closure84(v1201, v1200)
                        let v1267 : unit = (fun () -> v1266 (); v1265) ()
                        method148(v1200, v1201)
                        false
            let v1332 : UH5 =
                if v1329 then
                    let v1330 : (string -> (string -> US33)) = closure81(v4, v3, v258)
                    UH5_1(v1199, v253, v1330, v1198)
                else
                    v1198
            let struct (v1333 : string, v1334 : string) = method143(v929, v224, v4)
            let v1335 : bool = method28(v1333)
            let v1462 : bool =
                if v1335 then
                    true
                else
                    let v1336 : bool = method28(v1334)
                    let v1337 : bool = v1336 = false
                    if v1337 then
                        true
                    else
                        let v1398 : unit = ()
                        let v1399 : (unit -> unit) = closure84(v1334, v1333)
                        let v1400 : unit = (fun () -> v1399 (); v1398) ()
                        method148(v1333, v1334)
                        false
            let v1465 : UH5 =
                if v1462 then
                    let v1463 : (string -> (string -> US33)) = closure81(v4, v3, v257)
                    UH5_1(v929, v224, v1463, v1332)
                else
                    v1332
            let struct (v1466 : string, v1467 : string) = method143(v1065, v224, v4)
            let v1468 : bool = method28(v1466)
            let v1595 : bool =
                if v1468 then
                    true
                else
                    let v1469 : bool = method28(v1467)
                    let v1470 : bool = v1469 = false
                    if v1470 then
                        true
                    else
                        let v1531 : unit = ()
                        let v1532 : (unit -> unit) = closure84(v1467, v1466)
                        let v1533 : unit = (fun () -> v1532 (); v1531) ()
                        method148(v1466, v1467)
                        false
            let v1598 : UH5 =
                if v1595 then
                    let v1596 : (string -> (string -> US33)) = closure81(v4, v3, v256)
                    UH5_1(v1065, v224, v1596, v1465)
                else
                    v1465
            let struct (v1599 : string, v1600 : string) = method143(v1199, v224, v4)
            let v1601 : bool = method28(v1599)
            let v1728 : bool =
                if v1601 then
                    true
                else
                    let v1602 : bool = method28(v1600)
                    let v1603 : bool = v1602 = false
                    if v1603 then
                        true
                    else
                        let v1664 : unit = ()
                        let v1665 : (unit -> unit) = closure84(v1600, v1599)
                        let v1666 : unit = (fun () -> v1665 (); v1664) ()
                        method148(v1599, v1600)
                        false
            let v1731 : UH5 =
                if v1728 then
                    let v1729 : (string -> (string -> US33)) = closure81(v4, v3, v255)
                    UH5_1(v1199, v224, v1729, v1598)
                else
                    v1598
            let struct (v1732 : string, v1733 : string) = method143(v252, v224, v4)
            let v1734 : bool = method28(v1732)
            let v1861 : bool =
                if v1734 then
                    true
                else
                    let v1735 : bool = method28(v1733)
                    let v1736 : bool = v1735 = false
                    if v1736 then
                        true
                    else
                        let v1797 : unit = ()
                        let v1798 : (unit -> unit) = closure84(v1733, v1732)
                        let v1799 : unit = (fun () -> v1798 (); v1797) ()
                        method148(v1732, v1733)
                        false
            let v1866 : UH5 =
                if v1861 then
                    let v1862 : (string -> (string -> US33)) = closure76(v4, v3, v1, v0)
                    let v1863 : UH5 = UH5_0
                    UH5_1(v252, v224, v1862, v1863)
                else
                    UH5_0
            let v1867 : UH4 = UH4_0
            let v1868 : UH4 = UH4_1(v1731, v1867)
            UH4_1(v1866, v1868)
    let v1871 : UH5 list = []
    let v1872 : UH5 list = method164(v1870, v1871)
    let v1874 : (UH5 list -> (UH5 [])) = List.toArray
    let v1875 : (UH5 []) = v1874 v1872
    let v1878 : string = "$0.to_vec()"
    let v1879 : Vec<UH5> = Fable.Core.RustInterop.emitRustExpr v1875 v1878 
    let v1880 : (Result<string, (string * string)> option []) = [||]
    let v1881 : string = "$0.to_vec()"
    let v1882 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1880 v1881 
    let v1883 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v1884 : (UH5 []) = Fable.Core.RustInterop.emitRustExpr v1879 v1883 
    let v1886 : UH5 list = v1884 |> Array.toList
    let v1894 : ((UH5 -> (UH4 -> UH4)) -> (UH5 list -> (UH4 -> UH4))) = List.foldBack
    let v1895 : (UH5 -> (UH4 -> UH4)) = method165()
    let v1896 : (UH5 list -> (UH4 -> UH4)) = v1894 v1895
    let v1897 : (UH4 -> UH4) = v1896 v1886
    let v1898 : UH4 = UH4_0
    let v1899 : UH4 = v1897 v1898
    let v1928 : Vec<Result<string, (string * string)> option> = method166(v1899, v1882)
    let v1930 : (string * Vec<Result<string, (string * string)> option>) = v195, v1928 
    let v1934 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = Ok v1930 
    v1934
and method23 (v0 : string, v1 : string, v2 : string, v3 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> =
    let v4 : string = method24()
    let v5 : US5 = method25(v4)
    let v11 : US5 =
        match v5 with
        | US5_1 -> (* None *)
            let v8 : string = __SOURCE_DIRECTORY__
            method25(v8)
        | US5_0(v6) -> (* Some *)
            US5_0(v6)
    let v17 : US5 =
        match v11 with
        | US5_1 -> (* None *)
            let v14 : string = "/workspaces"
            method25(v14)
        | US5_0(v12) -> (* Some *)
            US5_0(v12)
    let v21 : string =
        match v17 with
        | US5_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US5_0(v18) -> (* Some *)
            v18
    let v22 : string = method43(v21)
    let v23 : bool = "deps" = v22
    let v34 : string =
        if v23 then
            let v24 : string option = method31(v21)
            let v26 : string = v24 |> Option.get
            let v29 : US5 = method25(v26)
            match v29 with
            | US5_1 -> (* None *)
                failwith<string> "Option does not have a value."
            | US5_0(v30) -> (* Some *)
                v30
        else
            v21
    let v35 : string = "polyglot"
    let v36 : string = method26(v34, v35)
    let v37 : string = method56(v3)
    let v38 : string = method56(v2)
    let v39 : string = method56(v1)
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure24(v0, v37, v38, v39)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v163 : string = "true; let __future_init = Box::pin(/*"
    let v164 : bool = Fable.Core.RustInterop.emitRustExpr () v163 
    let v165 : string = "*/ async move { /*"
    let v166 : bool = Fable.Core.RustInterop.emitRustExpr () v165 
    let v167 : string = "*/ ()"
    let v168 : bool = Fable.Core.RustInterop.emitRustExpr () v167 
    let v169 : string = "async_walkdir::WalkDir::new(&*$0)"
    let v170 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr v38 v169 
    let v171 : string = "async_walkdir::WalkDir::filter($0, move |x| $1(x))"
    let v172 : (async_walkdir_DirEntry -> std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>>) = closure25()
    let v173 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr struct (v170, v172) v171 
    let v174 : (Result<async_walkdir_DirEntry, async_walkdir_Error> -> string option) = method66()
    let v175 : string = "futures::stream::StreamExt::filter_map(v173, |x| async { v174(x) })"
    let v176 : _ = Fable.Core.RustInterop.emitRustExpr () v175 
    let v177 : string = "Box::pin(futures::stream::StreamExt::collect(v176))"
    let v178 : std_pin_Pin<Box<Dyn<std_future_Future<Vec<string>>>>> = Fable.Core.RustInterop.emitRustExpr () v177 
    let v179 : string = "v178.await"
    let v180 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v179 
    let v243 : unit = ()
    let v244 : (unit -> unit) = closure34(v180)
    let v245 : unit = (fun () -> v244 (); v243) ()
    let v308 : string = "rayon::iter::IntoParallelIterator::into_par_iter($0)"
    let v309 : rayon_vec_IntoIter<string> = Fable.Core.RustInterop.emitRustExpr v180 v308 
    let v310 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
    let v311 : (string -> Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>) = closure35(v0, v36, v37, v38, v39)
    let v312 : rayon_iter_Map<rayon_vec_IntoIter<string>> = Fable.Core.RustInterop.emitRustExpr struct (v309, v311) v310 
    let v313 : string = "rayon::iter::ParallelIterator::collect($0)"
    let v314 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = Fable.Core.RustInterop.emitRustExpr v312 v313 
    let v316 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Ok v314 
    let v319 : string = ""
    let v320 : string = "}"
    let v321 : string = v319 + v320 
    let x = v316 //
    let v322 : _ = x
    let v323 : unit = ()
    (* run_target_args'
    let v324 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v325 : string = $"true; let _fix_closure_v323 = $0"
    let v326 : bool = Fable.Core.RustInterop.emitRustExpr v322 v325 
    let _run_target_args'_v324 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v327 : string = $"true; let _fix_closure_v323 = $0"
    let v328 : bool = Fable.Core.RustInterop.emitRustExpr v322 v327 
    let _run_target_args'_v324 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v329 : string = $"true; let _fix_closure_v323 = $0"
    let v330 : bool = Fable.Core.RustInterop.emitRustExpr v322 v329 
    let _run_target_args'_v324 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v324 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v324 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v324 = false 
    #endif
#else
    let _run_target_args'_v324 = false 
    #endif
    let v331 : bool = _run_target_args'_v324 
    let v332 : string = $"true; _fix_closure_v323 " + v321 + "); " + v319 + " // rust.fix_closure'"
    let v333 : bool = Fable.Core.RustInterop.emitRustExpr () v332 
    let v334 : string = "__future_init"
    let v335 : _ = Fable.Core.RustInterop.emitRustExpr () v334 
    let v336 : string = "v335"
    let v337 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v336 
    v337
and closure88 () (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) : US37 =
    US37_0(v0)
and method170 () : (Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> -> US37) =
    closure88()
and closure89 () (v0 : std_string_String) : US37 =
    US37_1(v0)
and method171 () : (std_string_String -> US37) =
    closure89()
and method172 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method13()
    let v10 : Mut3 = {l0 = v9} : Mut3
    let v13 : string = "{ "
    let v14 : string = $"{v13}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure8(v10, v14)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v32 : string = "error"
    let v33 : string = $"{v32}"
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure8(v10, v33)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v51 : string = " = "
    let v52 : string = $"{v51}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure8(v10, v52)
    let v62 : unit = (fun () -> v61 (); v60) ()
    (* run_target_args'
    let v72 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v73 : string = "format!(\"{:#?}\", $0)"
    let v74 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v73 
    let v75 : string = "fable_library_rust::String_::fromString($0)"
    let v76 : string = Fable.Core.RustInterop.emitRustExpr v74 v75 
    let _run_target_args'_v72 = v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : string = "format!(\"{:#?}\", $0)"
    let v78 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v77 
    let v79 : string = "fable_library_rust::String_::fromString($0)"
    let v80 : string = Fable.Core.RustInterop.emitRustExpr v78 v79 
    let _run_target_args'_v72 = v80 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : string = "format!(\"{:#?}\", $0)"
    let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v81 
    let v83 : string = "fable_library_rust::String_::fromString($0)"
    let v84 : string = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let _run_target_args'_v72 = v84 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v86 : string = $"%A{v8}"
    let _run_target_args'_v72 = v86 
    #endif
#if FABLE_COMPILER_PYTHON
    let v90 : string = $"%A{v8}"
    let _run_target_args'_v72 = v90 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v94 : string = $"%A{v8}"
    let _run_target_args'_v72 = v94 
    #endif
#else
    let v98 : string = $"%A{v8}"
    let _run_target_args'_v72 = v98 
    #endif
    let v101 : string = _run_target_args'_v72 
    let v111 : string = $"{v101}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure8(v10, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v129 : string = " }"
    let v130 : string = $"{v129}"
    let v138 : unit = ()
    let v139 : (unit -> unit) = closure8(v10, v130)
    let v140 : unit = (fun () -> v139 (); v138) ()
    let v146 : string = v10.l0
    let v147 : int64 = v0.l0
    let v150 : string = " "
    let v151 : string = v6 + v150 
    let v155 : string = v151 + v7 
    let v160 : string = " #"
    let v161 : string = v155 + v160 
    let v165 : (int64 -> string) = _.ToString()
    let v166 : string = v165 v147
    let v170 : string = v161 + v166 
    let v174 : string = v170 + v150 
    let v179 : string = "documents.main"
    let v180 : string = v174 + v179 
    let v185 : string = " / "
    let v186 : string = v180 + v185 
    let v190 : string = v186 + v146 
    method16(v190)
and closure90 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_4
    let v2 : bool = method7(v1)
    if v2 then
        let v17 : unit = ()
        let v18 : (unit -> unit) = closure6()
        let v19 : unit = (fun () -> v18 (); v17) ()
        let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
        let v58 : string = method8(v40, v41, v42, v43, v44, v45)
        let v59 : string = method70()
        let v60 : string = method172(v40, v41, v42, v43, v44, v45, v58, v59, v0)
        method17(v60)
and method173 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : unativeint) : string =
    let v9 : string = method13()
    let v10 : Mut3 = {l0 = v9} : Mut3
    let v13 : string = "{ "
    let v14 : string = $"{v13}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure8(v10, v14)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v32 : string = "result_len"
    let v33 : string = $"{v32}"
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure8(v10, v33)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v51 : string = " = "
    let v52 : string = $"{v51}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure8(v10, v52)
    let v62 : unit = (fun () -> v61 (); v60) ()
    (* run_target_args'
    let v72 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v73 : string = "format!(\"{:#?}\", $0)"
    let v74 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v73 
    let v75 : string = "fable_library_rust::String_::fromString($0)"
    let v76 : string = Fable.Core.RustInterop.emitRustExpr v74 v75 
    let _run_target_args'_v72 = v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : string = "format!(\"{:#?}\", $0)"
    let v78 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v77 
    let v79 : string = "fable_library_rust::String_::fromString($0)"
    let v80 : string = Fable.Core.RustInterop.emitRustExpr v78 v79 
    let _run_target_args'_v72 = v80 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : string = "format!(\"{:#?}\", $0)"
    let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v81 
    let v83 : string = "fable_library_rust::String_::fromString($0)"
    let v84 : string = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let _run_target_args'_v72 = v84 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v86 : string = $"%A{v8}"
    let _run_target_args'_v72 = v86 
    #endif
#if FABLE_COMPILER_PYTHON
    let v90 : string = $"%A{v8}"
    let _run_target_args'_v72 = v90 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v94 : string = $"%A{v8}"
    let _run_target_args'_v72 = v94 
    #endif
#else
    let v98 : string = $"%A{v8}"
    let _run_target_args'_v72 = v98 
    #endif
    let v101 : string = _run_target_args'_v72 
    let v111 : string = $"{v101}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure8(v10, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v129 : string = " }"
    let v130 : string = $"{v129}"
    let v138 : unit = ()
    let v139 : (unit -> unit) = closure8(v10, v130)
    let v140 : unit = (fun () -> v139 (); v138) ()
    let v146 : string = v10.l0
    let v147 : int64 = v0.l0
    let v150 : string = " "
    let v151 : string = v6 + v150 
    let v155 : string = v151 + v7 
    let v160 : string = " #"
    let v161 : string = v155 + v160 
    let v165 : (int64 -> string) = _.ToString()
    let v166 : string = v165 v147
    let v170 : string = v161 + v166 
    let v174 : string = v170 + v150 
    let v179 : string = "documents.main"
    let v180 : string = v174 + v179 
    let v185 : string = " / "
    let v186 : string = v180 + v185 
    let v190 : string = v186 + v146 
    method16(v190)
and closure91 (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) () : unit =
    let v1 : US0 = US0_2
    let v2 : bool = method7(v1)
    if v2 then
        let v17 : unit = ()
        let v18 : (unit -> unit) = closure6()
        let v19 : unit = (fun () -> v18 (); v17) ()
        let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
        let v58 : string = method8(v40, v41, v42, v43, v44, v45)
        let v59 : string = method12()
        let v60 : string = "$0.len()"
        let v61 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v60 
        let v62 : string = method173(v40, v41, v42, v43, v44, v45, v58, v59, v61)
        method17(v62)
and closure1 () (v0 : (string [])) : int32 =
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure2()
    let v17 : unit = (fun () -> v16 (); v15) ()
    let v92 : unit = ()
    let v93 : (unit -> unit) = closure5(v0)
    let v94 : unit = (fun () -> v93 (); v92) ()
    let v155 : clap_Command = method0()
    let v156 : string = "clap::Command::get_matches($0)"
    let v157 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v155 v156 
    let v158 : string = method18()
    (* run_target_args'
    let v163 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v164 : string = "&*$0"
    let v165 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v158 v164 
    let _run_target_args'_v163 = v165 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v166 : string = "&*$0"
    let v167 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v158 v166 
    let _run_target_args'_v163 = v167 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v168 : string = "&*$0"
    let v169 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v158 v168 
    let _run_target_args'_v163 = v169 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v171 : Ref<Str> = v158 |> unbox<Ref<Str>>
    let _run_target_args'_v163 = v171 
    #endif
#if FABLE_COMPILER_PYTHON
    let v175 : Ref<Str> = v158 |> unbox<Ref<Str>>
    let _run_target_args'_v163 = v175 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v179 : Ref<Str> = v158 |> unbox<Ref<Str>>
    let _run_target_args'_v163 = v179 
    #endif
#else
    let v183 : Ref<Str> = v158 |> unbox<Ref<Str>>
    let _run_target_args'_v163 = v183 
    #endif
    let v186 : Ref<Str> = _run_target_args'_v163 
    let v195 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v196 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v157, v186) v195 
    let v199 : (std_string_String -> US6) = method19()
    let v200 : US6 option = v196 |> Option.map v199 
    let v220 : US6 = US6_1
    let v221 : US6 = v200 |> Option.defaultValue v220 
    let v228 : std_string_String =
        match v221 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v225) -> (* Some *)
            v225
    let v229 : string = "fable_library_rust::String_::fromString($0)"
    let v230 : string = Fable.Core.RustInterop.emitRustExpr v228 v229 
    let v231 : string = method20()
    (* run_target_args'
    let v236 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v237 : string = "&*$0"
    let v238 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v231 v237 
    let _run_target_args'_v236 = v238 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v239 : string = "&*$0"
    let v240 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v231 v239 
    let _run_target_args'_v236 = v240 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v241 : string = "&*$0"
    let v242 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v231 v241 
    let _run_target_args'_v236 = v242 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v244 : Ref<Str> = v231 |> unbox<Ref<Str>>
    let _run_target_args'_v236 = v244 
    #endif
#if FABLE_COMPILER_PYTHON
    let v248 : Ref<Str> = v231 |> unbox<Ref<Str>>
    let _run_target_args'_v236 = v248 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v252 : Ref<Str> = v231 |> unbox<Ref<Str>>
    let _run_target_args'_v236 = v252 
    #endif
#else
    let v256 : Ref<Str> = v231 |> unbox<Ref<Str>>
    let _run_target_args'_v236 = v256 
    #endif
    let v259 : Ref<Str> = _run_target_args'_v236 
    let v268 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v269 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v157, v259) v268 
    let v272 : (std_string_String -> US6) = method19()
    let v273 : US6 option = v269 |> Option.map v272 
    let v293 : US6 = US6_1
    let v294 : US6 = v273 |> Option.defaultValue v293 
    let v301 : std_string_String =
        match v294 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v298) -> (* Some *)
            v298
    let v302 : string = "fable_library_rust::String_::fromString($0)"
    let v303 : string = Fable.Core.RustInterop.emitRustExpr v301 v302 
    let v304 : string = method21()
    (* run_target_args'
    let v309 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v310 : string = "&*$0"
    let v311 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v304 v310 
    let _run_target_args'_v309 = v311 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v312 : string = "&*$0"
    let v313 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v304 v312 
    let _run_target_args'_v309 = v313 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v314 : string = "&*$0"
    let v315 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v304 v314 
    let _run_target_args'_v309 = v315 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v317 : Ref<Str> = v304 |> unbox<Ref<Str>>
    let _run_target_args'_v309 = v317 
    #endif
#if FABLE_COMPILER_PYTHON
    let v321 : Ref<Str> = v304 |> unbox<Ref<Str>>
    let _run_target_args'_v309 = v321 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v325 : Ref<Str> = v304 |> unbox<Ref<Str>>
    let _run_target_args'_v309 = v325 
    #endif
#else
    let v329 : Ref<Str> = v304 |> unbox<Ref<Str>>
    let _run_target_args'_v309 = v329 
    #endif
    let v332 : Ref<Str> = _run_target_args'_v309 
    let v341 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v342 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v157, v332) v341 
    let v345 : (std_string_String -> US6) = method19()
    let v346 : US6 option = v342 |> Option.map v345 
    let v366 : US6 = US6_1
    let v367 : US6 = v346 |> Option.defaultValue v366 
    let v374 : std_string_String =
        match v367 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v371) -> (* Some *)
            v371
    let v375 : string = "fable_library_rust::String_::fromString($0)"
    let v376 : string = Fable.Core.RustInterop.emitRustExpr v374 v375 
    let v377 : string = method22()
    (* run_target_args'
    let v382 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v383 : string = "&*$0"
    let v384 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v377 v383 
    let _run_target_args'_v382 = v384 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v385 : string = "&*$0"
    let v386 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v377 v385 
    let _run_target_args'_v382 = v386 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v387 : string = "&*$0"
    let v388 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v377 v387 
    let _run_target_args'_v382 = v388 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v390 : Ref<Str> = v377 |> unbox<Ref<Str>>
    let _run_target_args'_v382 = v390 
    #endif
#if FABLE_COMPILER_PYTHON
    let v394 : Ref<Str> = v377 |> unbox<Ref<Str>>
    let _run_target_args'_v382 = v394 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v398 : Ref<Str> = v377 |> unbox<Ref<Str>>
    let _run_target_args'_v382 = v398 
    #endif
#else
    let v402 : Ref<Str> = v377 |> unbox<Ref<Str>>
    let _run_target_args'_v382 = v402 
    #endif
    let v405 : Ref<Str> = _run_target_args'_v382 
    let v414 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v415 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v157, v405) v414 
    let v418 : (std_string_String -> US6) = method19()
    let v419 : US6 option = v415 |> Option.map v418 
    let v439 : US6 = US6_1
    let v440 : US6 = v419 |> Option.defaultValue v439 
    let v447 : std_string_String =
        match v440 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v444) -> (* Some *)
            v444
    let v448 : string = "fable_library_rust::String_::fromString($0)"
    let v449 : string = Fable.Core.RustInterop.emitRustExpr v447 v448 
    let v450 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = method23(v449, v376, v303, v230)
    let v451 : string = "futures::executor::block_on($0)"
    let v452 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr v450 v451 
    let v453 : (Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> -> US37) = method170()
    let v454 : (std_string_String -> US37) = method171()
    let v456 : US37 = match v452 with Ok x -> v453 x | Error x -> v454 x
    match v456 with
    | US37_1(v587) -> (* Error *)
        let v648 : unit = ()
        let v649 : (unit -> unit) = closure90(v587)
        let v650 : unit = (fun () -> v649 (); v648) ()
        1
    | US37_0(v459) -> (* Ok *)
        let v522 : unit = ()
        let v523 : (unit -> unit) = closure91(v459)
        let v524 : unit = (fun () -> v523 (); v522) ()
        0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
