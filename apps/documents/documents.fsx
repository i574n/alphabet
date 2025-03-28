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
    let v20 : US4 = US4_3(v19)
    let v21 : string = $"env.get_environment_variable / target: {v20} / var: {v0}"
    let v22 : string = failwith<string> v21
    let _run_target_args'_v2 = v22 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v23 : US3 = US3_2
    let v24 : US4 = US4_3(v23)
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
    let v209 : US2 =
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
            let v203 : int64 = v182 |> int64 
            US2_0(v203)
    struct (v127, v209)
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
    let v198 : int64 option =
        match v173 with
        | US2_1 -> (* None *)
            let v194 : int64 option = None
            v194
        | US2_0(v188) -> (* Some *)
            let v190 : int64 option = Some v188 
            v190
    struct (v178, v180, v181, v183, v187, v198)
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
    let v187 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v190 : (int64 -> US2) = method9()
    let v191 : US2 option = v5 |> Option.map v190 
    let v211 : US2 = US2_1
    let v212 : US2 = v191 |> Option.defaultValue v211 
    let v344 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v327 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v328 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v327 = v328 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v329 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v327 = v329 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v331 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v327 = v331 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v334 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v327 = v334 
            #endif
#if FABLE_COMPILER_PYTHON
            let v335 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v327 = v335 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v336 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v327 = v336 
            #endif
#else
            let v337 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v327 = v337 
            #endif
            let v338 : System.DateTime = _run_target_args'_v327 
            v338
        | US2_0(v216) -> (* Some *)
            (* run_target_args'
            let v223 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v224 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v223 = v224 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v225 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v223 = v225 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v227 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v223 = v227 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v230 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v223 = v230 
            #endif
#if FABLE_COMPILER_PYTHON
            let v231 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v223 = v231 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v232 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v223 = v232 
            #endif
#else
            let v233 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v223 = v233 
            #endif
            let v234 : System.DateTime = _run_target_args'_v223 
            (* run_target_args'
            let v245 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v246 : (System.DateTime -> int64) = _.Ticks
            let v247 : int64 = v246 v234
            let _run_target_args'_v245 = v247 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v248 : (System.DateTime -> int64) = _.Ticks
            let v249 : int64 = v248 v234
            let _run_target_args'_v245 = v249 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v251 : int64 = null |> unbox<int64>
            let _run_target_args'_v245 = v251 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v254 : (System.DateTime -> int64) = _.Ticks
            let v255 : int64 = v254 v234
            let _run_target_args'_v245 = v255 
            #endif
#if FABLE_COMPILER_PYTHON
            let v256 : (System.DateTime -> int64) = _.Ticks
            let v257 : int64 = v256 v234
            let _run_target_args'_v245 = v257 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v258 : (System.DateTime -> int64) = _.Ticks
            let v259 : int64 = v258 v234
            let _run_target_args'_v245 = v259 
            #endif
#else
            let v260 : (System.DateTime -> int64) = _.Ticks
            let v261 : int64 = v260 v234
            let _run_target_args'_v245 = v261 
            #endif
            let v262 : int64 = _run_target_args'_v245 
            let v283 : int64 = v262 |> int64 
            let v286 : int64 = v283 - v216
            let v292 : System.TimeSpan = v286 |> System.TimeSpan 
            let v298 : (System.TimeSpan -> int32) = _.Hours
            let v299 : int32 = v298 v292
            let v303 : (System.TimeSpan -> int32) = _.Minutes
            let v304 : int32 = v303 v292
            let v308 : (System.TimeSpan -> int32) = _.Seconds
            let v309 : int32 = v308 v292
            let v313 : (System.TimeSpan -> int32) = _.Milliseconds
            let v314 : int32 = v313 v292
            let v318 : System.DateTime = System.DateTime (1, 1, 1, v299, v304, v309, v314)
            v318
    let v346 : string = method10()
    let v350 : bool = v346 = ""
    let v352 : string =
        if v350 then
            let v351 : string = "M-d-y hh:mm:ss tt"
            v351
        else
            v346
    let v353 : (string -> string) = v344.ToString
    let v354 : string = v353 v352
    let _run_target_args'_v187 = v354 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v371 : (int64 -> US2) = method9()
    let v372 : US2 option = v5 |> Option.map v371 
    let v392 : US2 = US2_1
    let v393 : US2 = v372 |> Option.defaultValue v392 
    let v525 : System.DateTime =
        match v393 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v508 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v509 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v508 = v509 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v510 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v508 = v510 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v512 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v508 = v512 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v515 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v508 = v515 
            #endif
#if FABLE_COMPILER_PYTHON
            let v516 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v508 = v516 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v517 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v508 = v517 
            #endif
#else
            let v518 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v508 = v518 
            #endif
            let v519 : System.DateTime = _run_target_args'_v508 
            v519
        | US2_0(v397) -> (* Some *)
            (* run_target_args'
            let v404 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v405 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v404 = v405 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v406 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v404 = v406 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v408 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v404 = v408 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v411 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v404 = v411 
            #endif
#if FABLE_COMPILER_PYTHON
            let v412 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v404 = v412 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v413 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v404 = v413 
            #endif
#else
            let v414 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v404 = v414 
            #endif
            let v415 : System.DateTime = _run_target_args'_v404 
            (* run_target_args'
            let v426 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v427 : (System.DateTime -> int64) = _.Ticks
            let v428 : int64 = v427 v415
            let _run_target_args'_v426 = v428 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v429 : (System.DateTime -> int64) = _.Ticks
            let v430 : int64 = v429 v415
            let _run_target_args'_v426 = v430 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v432 : int64 = null |> unbox<int64>
            let _run_target_args'_v426 = v432 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v435 : (System.DateTime -> int64) = _.Ticks
            let v436 : int64 = v435 v415
            let _run_target_args'_v426 = v436 
            #endif
#if FABLE_COMPILER_PYTHON
            let v437 : (System.DateTime -> int64) = _.Ticks
            let v438 : int64 = v437 v415
            let _run_target_args'_v426 = v438 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v439 : (System.DateTime -> int64) = _.Ticks
            let v440 : int64 = v439 v415
            let _run_target_args'_v426 = v440 
            #endif
#else
            let v441 : (System.DateTime -> int64) = _.Ticks
            let v442 : int64 = v441 v415
            let _run_target_args'_v426 = v442 
            #endif
            let v443 : int64 = _run_target_args'_v426 
            let v464 : int64 = v443 |> int64 
            let v467 : int64 = v464 - v397
            let v473 : System.TimeSpan = v467 |> System.TimeSpan 
            let v479 : (System.TimeSpan -> int32) = _.Hours
            let v480 : int32 = v479 v473
            let v484 : (System.TimeSpan -> int32) = _.Minutes
            let v485 : int32 = v484 v473
            let v489 : (System.TimeSpan -> int32) = _.Seconds
            let v490 : int32 = v489 v473
            let v494 : (System.TimeSpan -> int32) = _.Milliseconds
            let v495 : int32 = v494 v473
            let v499 : System.DateTime = System.DateTime (1, 1, 1, v480, v485, v490, v495)
            v499
    let v527 : string = method10()
    let v531 : bool = v527 = ""
    let v533 : string =
        if v531 then
            let v532 : string = "M-d-y hh:mm:ss tt"
            v532
        else
            v527
    let v534 : (string -> string) = v525.ToString
    let v535 : string = v534 v533
    let _run_target_args'_v187 = v535 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v550 : string = $"near_sdk::env::block_timestamp()"
    let v551 : uint64 = Fable.Core.RustInterop.emitRustExpr () v550 
    let v554 : (int64 -> US2) = method9()
    let v555 : US2 option = v5 |> Option.map v554 
    let v575 : US2 = US2_1
    let v576 : US2 = v555 |> Option.defaultValue v575 
    let v588 : uint64 =
        match v576 with
        | US2_1 -> (* None *)
            v551
        | US2_0(v580) -> (* Some *)
            let v582 : (int64 -> uint64) = uint64
            let v583 : uint64 = v582 v580
            let v586 : uint64 = v551 - v583
            v586
    let v589 : uint64 = v588 / 1000000000UL
    let v590 : uint64 = v589 % 60UL
    let v591 : uint64 = v589 / 60UL
    let v592 : uint64 = v591 % 60UL
    let v593 : uint64 = v589 / 3600UL
    let v594 : uint64 = v593 % 24UL
    let v595 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v596 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v594, v592, v590) v595 
    let v597 : string = "fable_library_rust::String_::fromString($0)"
    let v598 : string = Fable.Core.RustInterop.emitRustExpr v596 v597 
    let _run_target_args'_v187 = v598 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v601 : (int64 -> US2) = method9()
    let v602 : US2 option = v5 |> Option.map v601 
    let v622 : US2 = US2_1
    let v623 : US2 = v602 |> Option.defaultValue v622 
    let v755 : System.DateTime =
        match v623 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v738 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v739 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v738 = v739 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v740 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v738 = v740 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v742 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v738 = v742 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v745 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v738 = v745 
            #endif
#if FABLE_COMPILER_PYTHON
            let v746 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v738 = v746 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v747 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v738 = v747 
            #endif
#else
            let v748 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v738 = v748 
            #endif
            let v749 : System.DateTime = _run_target_args'_v738 
            v749
        | US2_0(v627) -> (* Some *)
            (* run_target_args'
            let v634 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v635 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v634 = v635 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v636 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v634 = v636 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v638 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v634 = v638 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v641 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v634 = v641 
            #endif
#if FABLE_COMPILER_PYTHON
            let v642 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v634 = v642 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v643 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v634 = v643 
            #endif
#else
            let v644 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v634 = v644 
            #endif
            let v645 : System.DateTime = _run_target_args'_v634 
            (* run_target_args'
            let v656 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v657 : (System.DateTime -> int64) = _.Ticks
            let v658 : int64 = v657 v645
            let _run_target_args'_v656 = v658 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v659 : (System.DateTime -> int64) = _.Ticks
            let v660 : int64 = v659 v645
            let _run_target_args'_v656 = v660 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v662 : int64 = null |> unbox<int64>
            let _run_target_args'_v656 = v662 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v665 : (System.DateTime -> int64) = _.Ticks
            let v666 : int64 = v665 v645
            let _run_target_args'_v656 = v666 
            #endif
#if FABLE_COMPILER_PYTHON
            let v667 : (System.DateTime -> int64) = _.Ticks
            let v668 : int64 = v667 v645
            let _run_target_args'_v656 = v668 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v669 : (System.DateTime -> int64) = _.Ticks
            let v670 : int64 = v669 v645
            let _run_target_args'_v656 = v670 
            #endif
#else
            let v671 : (System.DateTime -> int64) = _.Ticks
            let v672 : int64 = v671 v645
            let _run_target_args'_v656 = v672 
            #endif
            let v673 : int64 = _run_target_args'_v656 
            let v694 : int64 = v673 |> int64 
            let v697 : int64 = v694 - v627
            let v703 : System.TimeSpan = v697 |> System.TimeSpan 
            let v709 : (System.TimeSpan -> int32) = _.Hours
            let v710 : int32 = v709 v703
            let v714 : (System.TimeSpan -> int32) = _.Minutes
            let v715 : int32 = v714 v703
            let v719 : (System.TimeSpan -> int32) = _.Seconds
            let v720 : int32 = v719 v703
            let v724 : (System.TimeSpan -> int32) = _.Milliseconds
            let v725 : int32 = v724 v703
            let v729 : System.DateTime = System.DateTime (1, 1, 1, v710, v715, v720, v725)
            v729
    let v757 : string = method11()
    let v761 : bool = v757 = ""
    let v763 : string =
        if v761 then
            let v762 : string = "M-d-y hh:mm:ss tt"
            v762
        else
            v757
    let v764 : (string -> string) = v755.ToString
    let v765 : string = v764 v763
    let _run_target_args'_v187 = v765 
    #endif
#if FABLE_COMPILER_PYTHON
    let v782 : (int64 -> US2) = method9()
    let v783 : US2 option = v5 |> Option.map v782 
    let v803 : US2 = US2_1
    let v804 : US2 = v783 |> Option.defaultValue v803 
    let v936 : System.DateTime =
        match v804 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v919 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v920 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v919 = v920 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v921 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v919 = v921 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v923 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v919 = v923 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v926 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v919 = v926 
            #endif
#if FABLE_COMPILER_PYTHON
            let v927 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v919 = v927 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v928 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v919 = v928 
            #endif
#else
            let v929 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v919 = v929 
            #endif
            let v930 : System.DateTime = _run_target_args'_v919 
            v930
        | US2_0(v808) -> (* Some *)
            (* run_target_args'
            let v815 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v816 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v815 = v816 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v817 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v815 = v817 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v819 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v815 = v819 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v822 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v815 = v822 
            #endif
#if FABLE_COMPILER_PYTHON
            let v823 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v815 = v823 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v824 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v815 = v824 
            #endif
#else
            let v825 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v815 = v825 
            #endif
            let v826 : System.DateTime = _run_target_args'_v815 
            (* run_target_args'
            let v837 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v838 : (System.DateTime -> int64) = _.Ticks
            let v839 : int64 = v838 v826
            let _run_target_args'_v837 = v839 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v840 : (System.DateTime -> int64) = _.Ticks
            let v841 : int64 = v840 v826
            let _run_target_args'_v837 = v841 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v843 : int64 = null |> unbox<int64>
            let _run_target_args'_v837 = v843 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v846 : (System.DateTime -> int64) = _.Ticks
            let v847 : int64 = v846 v826
            let _run_target_args'_v837 = v847 
            #endif
#if FABLE_COMPILER_PYTHON
            let v848 : (System.DateTime -> int64) = _.Ticks
            let v849 : int64 = v848 v826
            let _run_target_args'_v837 = v849 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v850 : (System.DateTime -> int64) = _.Ticks
            let v851 : int64 = v850 v826
            let _run_target_args'_v837 = v851 
            #endif
#else
            let v852 : (System.DateTime -> int64) = _.Ticks
            let v853 : int64 = v852 v826
            let _run_target_args'_v837 = v853 
            #endif
            let v854 : int64 = _run_target_args'_v837 
            let v875 : int64 = v854 |> int64 
            let v878 : int64 = v875 - v808
            let v884 : System.TimeSpan = v878 |> System.TimeSpan 
            let v890 : (System.TimeSpan -> int32) = _.Hours
            let v891 : int32 = v890 v884
            let v895 : (System.TimeSpan -> int32) = _.Minutes
            let v896 : int32 = v895 v884
            let v900 : (System.TimeSpan -> int32) = _.Seconds
            let v901 : int32 = v900 v884
            let v905 : (System.TimeSpan -> int32) = _.Milliseconds
            let v906 : int32 = v905 v884
            let v910 : System.DateTime = System.DateTime (1, 1, 1, v891, v896, v901, v906)
            v910
    let v938 : string = method11()
    let v942 : bool = v938 = ""
    let v944 : string =
        if v942 then
            let v943 : string = "M-d-y hh:mm:ss tt"
            v943
        else
            v938
    let v945 : (string -> string) = v936.ToString
    let v946 : string = v945 v944
    let _run_target_args'_v187 = v946 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v963 : (int64 -> US2) = method9()
    let v964 : US2 option = v5 |> Option.map v963 
    let v984 : US2 = US2_1
    let v985 : US2 = v964 |> Option.defaultValue v984 
    let v1117 : System.DateTime =
        match v985 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v1100 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1101 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1100 = v1101 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1102 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1100 = v1102 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1104 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1100 = v1104 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1107 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1100 = v1107 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1108 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1100 = v1108 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1109 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1100 = v1109 
            #endif
#else
            let v1110 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1100 = v1110 
            #endif
            let v1111 : System.DateTime = _run_target_args'_v1100 
            v1111
        | US2_0(v989) -> (* Some *)
            (* run_target_args'
            let v996 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v997 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v996 = v997 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v998 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v996 = v998 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1000 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v996 = v1000 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1003 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v996 = v1003 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1004 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v996 = v1004 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1005 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v996 = v1005 
            #endif
#else
            let v1006 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v996 = v1006 
            #endif
            let v1007 : System.DateTime = _run_target_args'_v996 
            (* run_target_args'
            let v1018 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1019 : (System.DateTime -> int64) = _.Ticks
            let v1020 : int64 = v1019 v1007
            let _run_target_args'_v1018 = v1020 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1021 : (System.DateTime -> int64) = _.Ticks
            let v1022 : int64 = v1021 v1007
            let _run_target_args'_v1018 = v1022 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1024 : int64 = null |> unbox<int64>
            let _run_target_args'_v1018 = v1024 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1027 : (System.DateTime -> int64) = _.Ticks
            let v1028 : int64 = v1027 v1007
            let _run_target_args'_v1018 = v1028 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1029 : (System.DateTime -> int64) = _.Ticks
            let v1030 : int64 = v1029 v1007
            let _run_target_args'_v1018 = v1030 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1031 : (System.DateTime -> int64) = _.Ticks
            let v1032 : int64 = v1031 v1007
            let _run_target_args'_v1018 = v1032 
            #endif
#else
            let v1033 : (System.DateTime -> int64) = _.Ticks
            let v1034 : int64 = v1033 v1007
            let _run_target_args'_v1018 = v1034 
            #endif
            let v1035 : int64 = _run_target_args'_v1018 
            let v1056 : int64 = v1035 |> int64 
            let v1059 : int64 = v1056 - v989
            let v1065 : System.TimeSpan = v1059 |> System.TimeSpan 
            let v1071 : (System.TimeSpan -> int32) = _.Hours
            let v1072 : int32 = v1071 v1065
            let v1076 : (System.TimeSpan -> int32) = _.Minutes
            let v1077 : int32 = v1076 v1065
            let v1081 : (System.TimeSpan -> int32) = _.Seconds
            let v1082 : int32 = v1081 v1065
            let v1086 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1087 : int32 = v1086 v1065
            let v1091 : System.DateTime = System.DateTime (1, 1, 1, v1072, v1077, v1082, v1087)
            v1091
    let v1119 : string = method11()
    let v1123 : bool = v1119 = ""
    let v1125 : string =
        if v1123 then
            let v1124 : string = "M-d-y hh:mm:ss tt"
            v1124
        else
            v1119
    let v1126 : (string -> string) = v1117.ToString
    let v1127 : string = v1126 v1125
    let _run_target_args'_v187 = v1127 
    #endif
#else
    let v1144 : (int64 -> US2) = method9()
    let v1145 : US2 option = v5 |> Option.map v1144 
    let v1165 : US2 = US2_1
    let v1166 : US2 = v1145 |> Option.defaultValue v1165 
    let v1298 : System.DateTime =
        match v1166 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v1281 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1282 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1281 = v1282 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1283 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1281 = v1283 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1285 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1281 = v1285 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1288 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1281 = v1288 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1289 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1281 = v1289 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1290 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1281 = v1290 
            #endif
#else
            let v1291 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1281 = v1291 
            #endif
            let v1292 : System.DateTime = _run_target_args'_v1281 
            v1292
        | US2_0(v1170) -> (* Some *)
            (* run_target_args'
            let v1177 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1178 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1177 = v1178 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1179 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1177 = v1179 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1181 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1177 = v1181 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1184 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1177 = v1184 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1185 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1177 = v1185 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1186 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1177 = v1186 
            #endif
#else
            let v1187 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1177 = v1187 
            #endif
            let v1188 : System.DateTime = _run_target_args'_v1177 
            (* run_target_args'
            let v1199 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1200 : (System.DateTime -> int64) = _.Ticks
            let v1201 : int64 = v1200 v1188
            let _run_target_args'_v1199 = v1201 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1202 : (System.DateTime -> int64) = _.Ticks
            let v1203 : int64 = v1202 v1188
            let _run_target_args'_v1199 = v1203 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1205 : int64 = null |> unbox<int64>
            let _run_target_args'_v1199 = v1205 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1208 : (System.DateTime -> int64) = _.Ticks
            let v1209 : int64 = v1208 v1188
            let _run_target_args'_v1199 = v1209 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1210 : (System.DateTime -> int64) = _.Ticks
            let v1211 : int64 = v1210 v1188
            let _run_target_args'_v1199 = v1211 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1212 : (System.DateTime -> int64) = _.Ticks
            let v1213 : int64 = v1212 v1188
            let _run_target_args'_v1199 = v1213 
            #endif
#else
            let v1214 : (System.DateTime -> int64) = _.Ticks
            let v1215 : int64 = v1214 v1188
            let _run_target_args'_v1199 = v1215 
            #endif
            let v1216 : int64 = _run_target_args'_v1199 
            let v1237 : int64 = v1216 |> int64 
            let v1240 : int64 = v1237 - v1170
            let v1246 : System.TimeSpan = v1240 |> System.TimeSpan 
            let v1252 : (System.TimeSpan -> int32) = _.Hours
            let v1253 : int32 = v1252 v1246
            let v1257 : (System.TimeSpan -> int32) = _.Minutes
            let v1258 : int32 = v1257 v1246
            let v1262 : (System.TimeSpan -> int32) = _.Seconds
            let v1263 : int32 = v1262 v1246
            let v1267 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1268 : int32 = v1267 v1246
            let v1272 : System.DateTime = System.DateTime (1, 1, 1, v1253, v1258, v1263, v1268)
            v1272
    let v1300 : string = method11()
    let v1304 : bool = v1300 = ""
    let v1306 : string =
        if v1304 then
            let v1305 : string = "M-d-y hh:mm:ss tt"
            v1305
        else
            v1300
    let v1307 : (string -> string) = v1298.ToString
    let v1308 : string = v1307 v1306
    let _run_target_args'_v187 = v1308 
    #endif
    let v1323 : string = _run_target_args'_v187 
    v1323
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
    let v83 : string = "inline_colorization::color_reset"
    let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v83 
    let v85 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v86 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v49, v77, v84) v85 
    let v87 : string = "fable_library_rust::String_::fromString($0)"
    let v88 : string = Fable.Core.RustInterop.emitRustExpr v86 v87 
    let _run_target_args'_v47 = v88 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v89 : string = "inline_colorization::color_bright_green"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    (* run_target_args'
    let v95 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v96 : string = "&*$0"
    let v97 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v96 
    let _run_target_args'_v95 = v97 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v98 : string = "&*$0"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v98 
    let _run_target_args'_v95 = v99 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v100 : string = "&*$0"
    let v101 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v100 
    let _run_target_args'_v95 = v101 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v103 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v103 
    #endif
#if FABLE_COMPILER_PYTHON
    let v107 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v107 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v111 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v111 
    #endif
#else
    let v115 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v115 
    #endif
    let v118 : Ref<Str> = _run_target_args'_v95 
    let v124 : string = "inline_colorization::color_reset"
    let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v124 
    let v126 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v127 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v90, v118, v125) v126 
    let v128 : string = "fable_library_rust::String_::fromString($0)"
    let v129 : string = Fable.Core.RustInterop.emitRustExpr v127 v128 
    let _run_target_args'_v47 = v129 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v130 : string = "inline_colorization::color_bright_green"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    (* run_target_args'
    let v136 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v137 : string = "&*$0"
    let v138 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v137 
    let _run_target_args'_v136 = v138 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v139 : string = "&*$0"
    let v140 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v139 
    let _run_target_args'_v136 = v140 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v141 : string = "&*$0"
    let v142 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v141 
    let _run_target_args'_v136 = v142 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v144 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v144 
    #endif
#if FABLE_COMPILER_PYTHON
    let v148 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v148 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v152 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v152 
    #endif
#else
    let v156 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v156 
    #endif
    let v159 : Ref<Str> = _run_target_args'_v136 
    let v165 : string = "inline_colorization::color_reset"
    let v166 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v165 
    let v167 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v168 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v131, v159, v166) v167 
    let v169 : string = "fable_library_rust::String_::fromString($0)"
    let v170 : string = Fable.Core.RustInterop.emitRustExpr v168 v169 
    let _run_target_args'_v47 = v170 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v172 : string = "\u001b[92m"
    let v176 : string = method14()
    let v180 : string = v172 + v30 
    let v184 : string = v180 + v176 
    let _run_target_args'_v47 = v184 
    #endif
#if FABLE_COMPILER_PYTHON
    let v188 : string = "\u001b[92m"
    let v192 : string = method14()
    let v196 : string = v188 + v30 
    let v200 : string = v196 + v192 
    let _run_target_args'_v47 = v200 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v204 : string = "\u001b[92m"
    let v208 : string = method14()
    let v212 : string = v204 + v30 
    let v216 : string = v212 + v208 
    let _run_target_args'_v47 = v216 
    #endif
#else
    let v220 : string = "\u001b[92m"
    let v224 : string = method14()
    let v228 : string = v220 + v30 
    let v232 : string = v228 + v224 
    let _run_target_args'_v47 = v232 
    #endif
    let v235 : string = _run_target_args'_v47 
    v235
and method16 (v0 : string) : string =
    let v1 : char list = []
    let v4 : (char list -> (char [])) = List.toArray
    let v5 : (char []) = v4 v1
    let v8 : string = v0.TrimStart v5 
    let v40 : char list = []
    let v42 : char list = '/' :: v40 
    let v46 : char list = ' ' :: v42 
    let v51 : (char list -> (char [])) = List.toArray
    let v52 : (char []) = v51 v46
    let v55 : string = v8.TrimEnd v52 
    v55
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
    let v117 : string = $"$0.chars()"
    let v118 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v111 v117 
    let v119 : string = "$0"
    let v120 : _ = Fable.Core.RustInterop.emitRustExpr v118 v119 
    let v121 : string = "$0.collect::<Vec<_>>()"
    let v122 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v120 v121 
    let v123 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v124 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v122 v123 
    let v125 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v126 : bool = Fable.Core.RustInterop.emitRustExpr v124 v125 
    let v127 : string = "x"
    let v128 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v127 
    let v129 : string = "String::from_iter($0)"
    let v130 : std_string_String = Fable.Core.RustInterop.emitRustExpr v128 v129 
    let v131 : string = "true; $0 }).collect::<Vec<_>>()"
    let v132 : bool = Fable.Core.RustInterop.emitRustExpr v130 v131 
    let v133 : string = "_vec_map"
    let v134 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v133 
    let v135 : string = "$0.len()"
    let v136 : unativeint = Fable.Core.RustInterop.emitRustExpr v134 v135 
    let v142 : int32 = v136 |> int32 
    let v152 : string = ""
    let v153 : bool = v0 <> v152 
    let v157 : bool =
        if v153 then
            let v156 : bool = v142 <= 1
            v156
        else
            false
    if v157 then
        v41.l0 <- v83
        ()
    else
        v41.l0 <- v152
        let v158 : string = "true; $0.into_iter().for_each(|x| { //"
        let v159 : bool = Fable.Core.RustInterop.emitRustExpr v134 v158 
        let v160 : string = "x"
        let v161 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v160 
        let v162 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v163 : bool = Fable.Core.RustInterop.emitRustExpr v161 v162 
        let v164 : string = $"true"
        let v165 : bool = Fable.Core.RustInterop.emitRustExpr () v164 
        let v166 : string = "true; }); //"
        let v167 : bool = Fable.Core.RustInterop.emitRustExpr () v166 
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
    let v168 : (string -> unit) = v39.l0
    v168 v0
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
    let v105 : string = "$0.parent().map(std::path::PathBuf::from)"
    let v106 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v99 v105 
    let v107 : string = "true; let _optionm_map_ = $0.map(|x| { //"
    let v108 : bool = Fable.Core.RustInterop.emitRustExpr v106 v107 
    let v109 : string = "x"
    let v110 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v109 
    (* run_target_args'
    let v115 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v116 : string = "$0.display()"
    let v117 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v110 v116 
    let _run_target_args'_v115 = v117 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v118 : string = "$0.display()"
    let v119 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v110 v118 
    let _run_target_args'_v115 = v119 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v120 : string = "$0.display()"
    let v121 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v110 v120 
    let _run_target_args'_v115 = v121 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v123 : std_path_Display = v110 |> unbox<std_path_Display>
    let _run_target_args'_v115 = v123 
    #endif
#if FABLE_COMPILER_PYTHON
    let v127 : std_path_Display = v110 |> unbox<std_path_Display>
    let _run_target_args'_v115 = v127 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v131 : std_path_Display = v110 |> unbox<std_path_Display>
    let _run_target_args'_v115 = v131 
    #endif
#else
    let v135 : std_path_Display = v110 |> unbox<std_path_Display>
    let _run_target_args'_v115 = v135 
    #endif
    let v138 : std_path_Display = _run_target_args'_v115 
    (* run_target_args'
    let v148 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v149 : string = "format!(\"{}\", $0)"
    let v150 : std_string_String = Fable.Core.RustInterop.emitRustExpr v138 v149 
    let _run_target_args'_v148 = v150 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v151 : string = "format!(\"{}\", $0)"
    let v152 : std_string_String = Fable.Core.RustInterop.emitRustExpr v138 v151 
    let _run_target_args'_v148 = v152 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v153 : string = "format!(\"{}\", $0)"
    let v154 : std_string_String = Fable.Core.RustInterop.emitRustExpr v138 v153 
    let _run_target_args'_v148 = v154 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v156 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v148 = v156 
    #endif
#if FABLE_COMPILER_PYTHON
    let v160 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v148 = v160 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v164 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v148 = v164 
    #endif
#else
    let v168 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v148 = v168 
    #endif
    let v171 : std_string_String = _run_target_args'_v148 
    let v177 : string = "fable_library_rust::String_::fromString($0)"
    let v178 : string = Fable.Core.RustInterop.emitRustExpr v171 v177 
    let v179 : string = "true; $0 })"
    let v180 : bool = Fable.Core.RustInterop.emitRustExpr v178 v179 
    let v181 : string = "_optionm_map_"
    let v182 : string option = Fable.Core.RustInterop.emitRustExpr () v181 
    let _run_target_args'_v5 = v182 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v184 : string option = None
    let _run_target_args'_v5 = v184 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v188 : string option = None
    let _run_target_args'_v5 = v188 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v191 : string = "path"
    let v192 : IPathDirname = Fable.Core.JsInterop.importAll v191 
    let v193 : string = "v192.dirname($0)"
    let v194 : string = Fable.Core.JsInterop.emitJsExpr v0 v193 
    let v195 : bool = v194 = v0
    let v198 : US5 =
        if v195 then
            US5_1
        else
            US5_0(v194)
    let v209 : string option =
        match v198 with
        | US5_1 -> (* None *)
            let v205 : string option = None
            v205
        | US5_0(v199) -> (* Some *)
            let v201 : string option = Some v199 
            v201
    let _run_target_args'_v5 = v209 
    #endif
#if FABLE_COMPILER_PYTHON
    let v211 : string option = None
    let _run_target_args'_v5 = v211 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v215 : string option = None
    let _run_target_args'_v5 = v215 
    #endif
#else
    let v218 : (string -> System_IO_DirectoryInfo) = System.IO.Directory.GetParent
    let v219 : System_IO_DirectoryInfo = v218 v0
    let v221 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let v225 : bool = v219 = v221 
    let v267 : US5 =
        if v225 then
            US5_1
        else
            (* run_target_args'
            let v233 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v235 : string = null |> unbox<string>
            let _run_target_args'_v233 = v235 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v239 : string = null |> unbox<string>
            let _run_target_args'_v233 = v239 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v243 : string = null |> unbox<string>
            let _run_target_args'_v233 = v243 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v247 : string = null |> unbox<string>
            let _run_target_args'_v233 = v247 
            #endif
#if FABLE_COMPILER_PYTHON
            let v251 : string = null |> unbox<string>
            let _run_target_args'_v233 = v251 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v255 : string = null |> unbox<string>
            let _run_target_args'_v233 = v255 
            #endif
#else
            let v258 : (System_IO_DirectoryInfo -> string) = _.FullName
            let v259 : string = v258 v219
            let _run_target_args'_v233 = v259 
            #endif
            let v260 : string = _run_target_args'_v233 
            US5_0(v260)
    let v278 : string option =
        match v267 with
        | US5_1 -> (* None *)
            let v274 : string option = None
            v274
        | US5_0(v268) -> (* Some *)
            let v270 : string option = Some v268 
            v270
    let _run_target_args'_v5 = v278 
    #endif
    let v279 : string option = _run_target_args'_v5 
    v279
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
    let v83 : string = "inline_colorization::color_reset"
    let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v83 
    let v85 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v86 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v49, v77, v84) v85 
    let v87 : string = "fable_library_rust::String_::fromString($0)"
    let v88 : string = Fable.Core.RustInterop.emitRustExpr v86 v87 
    let _run_target_args'_v47 = v88 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v89 : string = "inline_colorization::color_yellow"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    (* run_target_args'
    let v95 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v96 : string = "&*$0"
    let v97 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v96 
    let _run_target_args'_v95 = v97 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v98 : string = "&*$0"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v98 
    let _run_target_args'_v95 = v99 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v100 : string = "&*$0"
    let v101 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v100 
    let _run_target_args'_v95 = v101 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v103 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v103 
    #endif
#if FABLE_COMPILER_PYTHON
    let v107 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v107 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v111 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v111 
    #endif
#else
    let v115 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v115 
    #endif
    let v118 : Ref<Str> = _run_target_args'_v95 
    let v124 : string = "inline_colorization::color_reset"
    let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v124 
    let v126 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v127 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v90, v118, v125) v126 
    let v128 : string = "fable_library_rust::String_::fromString($0)"
    let v129 : string = Fable.Core.RustInterop.emitRustExpr v127 v128 
    let _run_target_args'_v47 = v129 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v130 : string = "inline_colorization::color_yellow"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    (* run_target_args'
    let v136 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v137 : string = "&*$0"
    let v138 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v137 
    let _run_target_args'_v136 = v138 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v139 : string = "&*$0"
    let v140 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v139 
    let _run_target_args'_v136 = v140 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v141 : string = "&*$0"
    let v142 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v141 
    let _run_target_args'_v136 = v142 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v144 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v144 
    #endif
#if FABLE_COMPILER_PYTHON
    let v148 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v148 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v152 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v152 
    #endif
#else
    let v156 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v156 
    #endif
    let v159 : Ref<Str> = _run_target_args'_v136 
    let v165 : string = "inline_colorization::color_reset"
    let v166 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v165 
    let v167 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v168 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v131, v159, v166) v167 
    let v169 : string = "fable_library_rust::String_::fromString($0)"
    let v170 : string = Fable.Core.RustInterop.emitRustExpr v168 v169 
    let _run_target_args'_v47 = v170 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v172 : string = "\u001b[93m"
    let v176 : string = method14()
    let v180 : string = v172 + v30 
    let v184 : string = v180 + v176 
    let _run_target_args'_v47 = v184 
    #endif
#if FABLE_COMPILER_PYTHON
    let v188 : string = "\u001b[93m"
    let v192 : string = method14()
    let v196 : string = v188 + v30 
    let v200 : string = v196 + v192 
    let _run_target_args'_v47 = v200 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v204 : string = "\u001b[93m"
    let v208 : string = method14()
    let v212 : string = v204 + v30 
    let v216 : string = v212 + v208 
    let _run_target_args'_v47 = v216 
    #endif
#else
    let v220 : string = "\u001b[93m"
    let v224 : string = method14()
    let v228 : string = v220 + v30 
    let v232 : string = v228 + v224 
    let _run_target_args'_v47 = v232 
    #endif
    let v235 : string = _run_target_args'_v47 
    v235
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
    let v43 : string = $"{v36}"
    let v51 : unit = ()
    let v52 : (unit -> unit) = closure8(v2, v43)
    let v53 : unit = (fun () -> v52 (); v51) ()
    let v59 : string = v2.l0
    v59
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
    let v158 : (string -> US5) = method6()
    let v159 : US5 option = v155 |> Option.map v158 
    let v179 : US5 = US5_1
    let v180 : US5 = v159 |> Option.defaultValue v179 
    let v187 : string =
        match v180 with
        | US5_1 -> (* None *)
            let v185 : string = ""
            v185
        | US5_0(v184) -> (* Some *)
            v184
    let _run_target_args'_v5 = v187 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v188 : US3 = US3_1
    let v189 : US4 = US4_3(v188)
    let v190 : string = $"file_system.get_file_name / target: {v189} / path: {v0}"
    let v191 : string = failwith<string> v190
    let _run_target_args'_v5 = v191 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v193 : string = null |> unbox<string>
    let _run_target_args'_v5 = v193 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v196 : string = "path"
    let v197 : IPathBasename = Fable.Core.JsInterop.importAll v196 
    let v198 : string = "v197.basename($0)"
    let v199 : string = Fable.Core.JsInterop.emitJsExpr v0 v198 
    let _run_target_args'_v5 = v199 
    #endif
#if FABLE_COMPILER_PYTHON
    let v200 : US3 = US3_0
    let v201 : US4 = US4_5(v200)
    let v202 : string = $"file_system.get_file_name / target: {v201} / path: {v0}"
    let v203 : string = failwith<string> v202
    let _run_target_args'_v5 = v203 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v204 : US3 = US3_1
    let v205 : US4 = US4_1(v204)
    let v206 : string = $"file_system.get_file_name / target: {v205} / path: {v0}"
    let v207 : string = failwith<string> v206
    let _run_target_args'_v5 = v207 
    #endif
#else
    let v208 : (string -> string) = System.IO.Path.GetFileName
    let v209 : string = v208 v0
    let _run_target_args'_v5 = v209 
    #endif
    let v210 : string = _run_target_args'_v5 
    v210
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
        let v93 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v94 : string = "Err($0)"
        let v95 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v86 v94 
        let _run_target_args'_v93 = v95 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v96 : string = "Err($0)"
        let v97 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v86 v96 
        let _run_target_args'_v93 = v97 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v98 : string = "Err($0)"
        let v99 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v86 v98 
        let _run_target_args'_v93 = v99 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v100 : Result<std_path_PathBuf, std_io_Error> = v86 |> Error
        let _run_target_args'_v93 = v100 
        #endif
#if FABLE_COMPILER_PYTHON
        let v101 : Result<std_path_PathBuf, std_io_Error> = v86 |> Error
        let _run_target_args'_v93 = v101 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v102 : Result<std_path_PathBuf, std_io_Error> = v86 |> Error
        let _run_target_args'_v93 = v102 
        #endif
#else
        let v103 : Result<std_path_PathBuf, std_io_Error> = v86 |> Error
        let _run_target_args'_v93 = v103 
        #endif
        let v104 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v93 
        v104
    else
        match v31 with
        | US5_0(v107) -> (* Some *)
            let v110 : string = ""
            let v111 : bool = v4 <> v110 
            if v111 then
                let v114 : uint8 = v2 + 1uy
                let v115 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v114
                let v116 : Result<std_path_PathBuf, std_io_Error> = v115 v107
                let v117 : (std_io_Error -> string) = method38()
                (* run_target_args'
                let v119 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v120 : string = "$0.map_err(|x| $1(x))"
                let v121 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v116, v117) v120 
                let _run_target_args'_v119 = v121 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v122 : string = "$0.map_err(|x| $1(x))"
                let v123 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v116, v117) v122 
                let _run_target_args'_v119 = v123 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v124 : string = "$0.map_err(|x| $1(x))"
                let v125 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v116, v117) v124 
                let _run_target_args'_v119 = v125 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v126 : Result<std_path_PathBuf, string> = match v116 with Ok x -> Ok x | Error x -> Error (v117 x)
                let _run_target_args'_v119 = v126 
                #endif
#if FABLE_COMPILER_PYTHON
                let v127 : Result<std_path_PathBuf, string> = match v116 with Ok x -> Ok x | Error x -> Error (v117 x)
                let _run_target_args'_v119 = v127 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v128 : Result<std_path_PathBuf, string> = match v116 with Ok x -> Ok x | Error x -> Error (v117 x)
                let _run_target_args'_v119 = v128 
                #endif
#else
                let v129 : Result<std_path_PathBuf, string> = match v116 with Ok x -> Ok x | Error x -> Error (v117 x)
                let _run_target_args'_v119 = v129 
                #endif
                let v130 : Result<std_path_PathBuf, string> = _run_target_args'_v119 
                let v133 : (std_path_PathBuf -> US9) = method39()
                let v134 : (string -> US9) = method40()
                let v136 : US9 = match v130 with Ok x -> v133 x | Error x -> v134 x
                match v136 with
                | US9_1(v292) -> (* Error *)
                    let v293 : string = $"file_system.read_link / "
                    let v294 : string = $"error': {v292} / error: {v54} / name: {v5}"
                    let v295 : string = v293 + v294 
                    (* run_target_args'
                    let v300 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v301 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v302 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v295 v301 
                    let _run_target_args'_v300 = v302 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v303 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v304 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v295 v303 
                    let _run_target_args'_v300 = v304 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v305 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v306 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v295 v305 
                    let _run_target_args'_v300 = v306 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v308 : std_io_Error = v295 |> unbox<std_io_Error>
                    let _run_target_args'_v300 = v308 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v312 : std_io_Error = v295 |> unbox<std_io_Error>
                    let _run_target_args'_v300 = v312 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v316 : std_io_Error = v295 |> unbox<std_io_Error>
                    let _run_target_args'_v300 = v316 
                    #endif
#else
                    let v320 : std_io_Error = v295 |> unbox<std_io_Error>
                    let _run_target_args'_v300 = v320 
                    #endif
                    let v323 : std_io_Error = _run_target_args'_v300 
                    (* run_target_args'
                    let v330 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v331 : string = "Err($0)"
                    let v332 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v323 v331 
                    let _run_target_args'_v330 = v332 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v333 : string = "Err($0)"
                    let v334 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v323 v333 
                    let _run_target_args'_v330 = v334 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v335 : string = "Err($0)"
                    let v336 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v323 v335 
                    let _run_target_args'_v330 = v336 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v337 : Result<std_path_PathBuf, std_io_Error> = v323 |> Error
                    let _run_target_args'_v330 = v337 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v338 : Result<std_path_PathBuf, std_io_Error> = v323 |> Error
                    let _run_target_args'_v330 = v338 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v339 : Result<std_path_PathBuf, std_io_Error> = v323 |> Error
                    let _run_target_args'_v330 = v339 
                    #endif
#else
                    let v340 : Result<std_path_PathBuf, std_io_Error> = v323 |> Error
                    let _run_target_args'_v330 = v340 
                    #endif
                    let v341 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v330 
                    v341
                | US9_0(v139) -> (* Ok *)
                    (* run_target_args'
                    let v144 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v145 : string = "$0.display()"
                    let v146 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v139 v145 
                    let _run_target_args'_v144 = v146 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v147 : string = "$0.display()"
                    let v148 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v139 v147 
                    let _run_target_args'_v144 = v148 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v149 : string = "$0.display()"
                    let v150 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v139 v149 
                    let _run_target_args'_v144 = v150 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v152 : std_path_Display = v139 |> unbox<std_path_Display>
                    let _run_target_args'_v144 = v152 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v156 : std_path_Display = v139 |> unbox<std_path_Display>
                    let _run_target_args'_v144 = v156 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v160 : std_path_Display = v139 |> unbox<std_path_Display>
                    let _run_target_args'_v144 = v160 
                    #endif
#else
                    let v164 : std_path_Display = v139 |> unbox<std_path_Display>
                    let _run_target_args'_v144 = v164 
                    #endif
                    let v167 : std_path_Display = _run_target_args'_v144 
                    let v174 : string = v167 |> string 
                    let v177 : string = method26(v174, v5)
                    (* run_target_args'
                    let v182 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v183 : string = "&*$0"
                    let v184 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v177 v183 
                    let _run_target_args'_v182 = v184 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v185 : string = "&*$0"
                    let v186 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v177 v185 
                    let _run_target_args'_v182 = v186 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v187 : string = "&*$0"
                    let v188 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v177 v187 
                    let _run_target_args'_v182 = v188 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v190 : Ref<Str> = v177 |> unbox<Ref<Str>>
                    let _run_target_args'_v182 = v190 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v194 : Ref<Str> = v177 |> unbox<Ref<Str>>
                    let _run_target_args'_v182 = v194 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v198 : Ref<Str> = v177 |> unbox<Ref<Str>>
                    let _run_target_args'_v182 = v198 
                    #endif
#else
                    let v202 : Ref<Str> = v177 |> unbox<Ref<Str>>
                    let _run_target_args'_v182 = v202 
                    #endif
                    let v205 : Ref<Str> = _run_target_args'_v182 
                    (* run_target_args'
                    let v215 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v216 : string = "String::from($0)"
                    let v217 : std_string_String = Fable.Core.RustInterop.emitRustExpr v205 v216 
                    let _run_target_args'_v215 = v217 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v218 : string = "String::from($0)"
                    let v219 : std_string_String = Fable.Core.RustInterop.emitRustExpr v205 v218 
                    let _run_target_args'_v215 = v219 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v220 : string = "String::from($0)"
                    let v221 : std_string_String = Fable.Core.RustInterop.emitRustExpr v205 v220 
                    let _run_target_args'_v215 = v221 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v223 : std_string_String = v205 |> unbox<std_string_String>
                    let _run_target_args'_v215 = v223 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v227 : std_string_String = v205 |> unbox<std_string_String>
                    let _run_target_args'_v215 = v227 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v231 : std_string_String = v205 |> unbox<std_string_String>
                    let _run_target_args'_v215 = v231 
                    #endif
#else
                    let v235 : std_string_String = v205 |> unbox<std_string_String>
                    let _run_target_args'_v215 = v235 
                    #endif
                    let v238 : std_string_String = _run_target_args'_v215 
                    (* run_target_args'
                    let v248 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v249 : string = "std::path::PathBuf::from($0)"
                    let v250 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v238 v249 
                    let _run_target_args'_v248 = v250 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v251 : string = "std::path::PathBuf::from($0)"
                    let v252 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v238 v251 
                    let _run_target_args'_v248 = v252 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v253 : string = "std::path::PathBuf::from($0)"
                    let v254 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v238 v253 
                    let _run_target_args'_v248 = v254 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v256 : std_path_PathBuf = v238 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v248 = v256 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v260 : std_path_PathBuf = v238 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v248 = v260 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v264 : std_path_PathBuf = v238 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v248 = v264 
                    #endif
#else
                    let v268 : std_path_PathBuf = v238 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v248 = v268 
                    #endif
                    let v271 : std_path_PathBuf = _run_target_args'_v248 
                    (* run_target_args'
                    let v278 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v279 : string = "Ok($0)"
                    let v280 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v271 v279 
                    let _run_target_args'_v278 = v280 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v281 : string = "Ok($0)"
                    let v282 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v271 v281 
                    let _run_target_args'_v278 = v282 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v283 : string = "Ok($0)"
                    let v284 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v271 v283 
                    let _run_target_args'_v278 = v284 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v285 : Result<std_path_PathBuf, std_io_Error> = v271 |> Ok
                    let _run_target_args'_v278 = v285 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v286 : Result<std_path_PathBuf, std_io_Error> = v271 |> Ok
                    let _run_target_args'_v278 = v286 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v287 : Result<std_path_PathBuf, std_io_Error> = v271 |> Ok
                    let _run_target_args'_v278 = v287 
                    #endif
#else
                    let v288 : Result<std_path_PathBuf, std_io_Error> = v271 |> Ok
                    let _run_target_args'_v278 = v288 
                    #endif
                    let v289 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v278 
                    v289
            else
                let v346 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v347 : string = $"path: {v0} / error: {v54} / path': {v4} / name: {v5}"
                let v348 : string = v346 + v347 
                (* run_target_args'
                let v353 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v354 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v355 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v348 v354 
                let _run_target_args'_v353 = v355 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v356 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v357 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v348 v356 
                let _run_target_args'_v353 = v357 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v358 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v359 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v348 v358 
                let _run_target_args'_v353 = v359 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v361 : std_io_Error = v348 |> unbox<std_io_Error>
                let _run_target_args'_v353 = v361 
                #endif
#if FABLE_COMPILER_PYTHON
                let v365 : std_io_Error = v348 |> unbox<std_io_Error>
                let _run_target_args'_v353 = v365 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v369 : std_io_Error = v348 |> unbox<std_io_Error>
                let _run_target_args'_v353 = v369 
                #endif
#else
                let v373 : std_io_Error = v348 |> unbox<std_io_Error>
                let _run_target_args'_v353 = v373 
                #endif
                let v376 : std_io_Error = _run_target_args'_v353 
                (* run_target_args'
                let v383 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v384 : string = "Err($0)"
                let v385 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v376 v384 
                let _run_target_args'_v383 = v385 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v386 : string = "Err($0)"
                let v387 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v376 v386 
                let _run_target_args'_v383 = v387 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v388 : string = "Err($0)"
                let v389 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v376 v388 
                let _run_target_args'_v383 = v389 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v390 : Result<std_path_PathBuf, std_io_Error> = v376 |> Error
                let _run_target_args'_v383 = v390 
                #endif
#if FABLE_COMPILER_PYTHON
                let v391 : Result<std_path_PathBuf, std_io_Error> = v376 |> Error
                let _run_target_args'_v383 = v391 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v392 : Result<std_path_PathBuf, std_io_Error> = v376 |> Error
                let _run_target_args'_v383 = v392 
                #endif
#else
                let v393 : Result<std_path_PathBuf, std_io_Error> = v376 |> Error
                let _run_target_args'_v383 = v393 
                #endif
                let v394 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v383 
                v394
        | _ ->
            let v398 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v399 : string = $"path: {v0} / error: {v54} / path': {v4} / name: {v5}"
            let v400 : string = v398 + v399 
            (* run_target_args'
            let v405 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v406 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v407 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v400 v406 
            let _run_target_args'_v405 = v407 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v408 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v409 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v400 v408 
            let _run_target_args'_v405 = v409 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v410 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v411 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v400 v410 
            let _run_target_args'_v405 = v411 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v413 : std_io_Error = v400 |> unbox<std_io_Error>
            let _run_target_args'_v405 = v413 
            #endif
#if FABLE_COMPILER_PYTHON
            let v417 : std_io_Error = v400 |> unbox<std_io_Error>
            let _run_target_args'_v405 = v417 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v421 : std_io_Error = v400 |> unbox<std_io_Error>
            let _run_target_args'_v405 = v421 
            #endif
#else
            let v425 : std_io_Error = v400 |> unbox<std_io_Error>
            let _run_target_args'_v405 = v425 
            #endif
            let v428 : std_io_Error = _run_target_args'_v405 
            (* run_target_args'
            let v435 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v436 : string = "Err($0)"
            let v437 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v428 v436 
            let _run_target_args'_v435 = v437 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v438 : string = "Err($0)"
            let v439 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v428 v438 
            let _run_target_args'_v435 = v439 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v440 : string = "Err($0)"
            let v441 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v428 v440 
            let _run_target_args'_v435 = v441 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v442 : Result<std_path_PathBuf, std_io_Error> = v428 |> Error
            let _run_target_args'_v435 = v442 
            #endif
#if FABLE_COMPILER_PYTHON
            let v443 : Result<std_path_PathBuf, std_io_Error> = v428 |> Error
            let _run_target_args'_v435 = v443 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v444 : Result<std_path_PathBuf, std_io_Error> = v428 |> Error
            let _run_target_args'_v435 = v444 
            #endif
#else
            let v445 : Result<std_path_PathBuf, std_io_Error> = v428 |> Error
            let _run_target_args'_v435 = v445 
            #endif
            let v446 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v435 
            v446
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
        let v92 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v93 : string = "Err($0)"
        let v94 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v85 v93 
        let _run_target_args'_v92 = v94 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v95 : string = "Err($0)"
        let v96 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v85 v95 
        let _run_target_args'_v92 = v96 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v97 : string = "Err($0)"
        let v98 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v85 v97 
        let _run_target_args'_v92 = v98 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v99 : Result<std_path_PathBuf, std_io_Error> = v85 |> Error
        let _run_target_args'_v92 = v99 
        #endif
#if FABLE_COMPILER_PYTHON
        let v100 : Result<std_path_PathBuf, std_io_Error> = v85 |> Error
        let _run_target_args'_v92 = v100 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v101 : Result<std_path_PathBuf, std_io_Error> = v85 |> Error
        let _run_target_args'_v92 = v101 
        #endif
#else
        let v102 : Result<std_path_PathBuf, std_io_Error> = v85 |> Error
        let _run_target_args'_v92 = v102 
        #endif
        let v103 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v92 
        v103
    else
        match v30 with
        | US5_0(v106) -> (* Some *)
            let v109 : string = ""
            let v110 : bool = v0 <> v109 
            if v110 then
                let v113 : uint8 = v2 + 1uy
                let v114 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v113
                let v115 : Result<std_path_PathBuf, std_io_Error> = v114 v106
                let v116 : (std_io_Error -> string) = method38()
                (* run_target_args'
                let v118 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v119 : string = "$0.map_err(|x| $1(x))"
                let v120 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v115, v116) v119 
                let _run_target_args'_v118 = v120 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v121 : string = "$0.map_err(|x| $1(x))"
                let v122 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v115, v116) v121 
                let _run_target_args'_v118 = v122 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v123 : string = "$0.map_err(|x| $1(x))"
                let v124 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v115, v116) v123 
                let _run_target_args'_v118 = v124 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v125 : Result<std_path_PathBuf, string> = match v115 with Ok x -> Ok x | Error x -> Error (v116 x)
                let _run_target_args'_v118 = v125 
                #endif
#if FABLE_COMPILER_PYTHON
                let v126 : Result<std_path_PathBuf, string> = match v115 with Ok x -> Ok x | Error x -> Error (v116 x)
                let _run_target_args'_v118 = v126 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v127 : Result<std_path_PathBuf, string> = match v115 with Ok x -> Ok x | Error x -> Error (v116 x)
                let _run_target_args'_v118 = v127 
                #endif
#else
                let v128 : Result<std_path_PathBuf, string> = match v115 with Ok x -> Ok x | Error x -> Error (v116 x)
                let _run_target_args'_v118 = v128 
                #endif
                let v129 : Result<std_path_PathBuf, string> = _run_target_args'_v118 
                let v132 : (std_path_PathBuf -> US9) = method39()
                let v133 : (string -> US9) = method40()
                let v135 : US9 = match v129 with Ok x -> v132 x | Error x -> v133 x
                match v135 with
                | US9_1(v291) -> (* Error *)
                    let v292 : string = $"file_system.read_link / "
                    let v293 : string = $"error': {v291} / error: {v53} / name: {v4}"
                    let v294 : string = v292 + v293 
                    (* run_target_args'
                    let v299 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v300 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v301 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v294 v300 
                    let _run_target_args'_v299 = v301 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v302 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v303 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v294 v302 
                    let _run_target_args'_v299 = v303 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v304 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v305 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v294 v304 
                    let _run_target_args'_v299 = v305 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v307 : std_io_Error = v294 |> unbox<std_io_Error>
                    let _run_target_args'_v299 = v307 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v311 : std_io_Error = v294 |> unbox<std_io_Error>
                    let _run_target_args'_v299 = v311 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v315 : std_io_Error = v294 |> unbox<std_io_Error>
                    let _run_target_args'_v299 = v315 
                    #endif
#else
                    let v319 : std_io_Error = v294 |> unbox<std_io_Error>
                    let _run_target_args'_v299 = v319 
                    #endif
                    let v322 : std_io_Error = _run_target_args'_v299 
                    (* run_target_args'
                    let v329 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v330 : string = "Err($0)"
                    let v331 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v322 v330 
                    let _run_target_args'_v329 = v331 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v332 : string = "Err($0)"
                    let v333 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v322 v332 
                    let _run_target_args'_v329 = v333 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v334 : string = "Err($0)"
                    let v335 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v322 v334 
                    let _run_target_args'_v329 = v335 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v336 : Result<std_path_PathBuf, std_io_Error> = v322 |> Error
                    let _run_target_args'_v329 = v336 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v337 : Result<std_path_PathBuf, std_io_Error> = v322 |> Error
                    let _run_target_args'_v329 = v337 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v338 : Result<std_path_PathBuf, std_io_Error> = v322 |> Error
                    let _run_target_args'_v329 = v338 
                    #endif
#else
                    let v339 : Result<std_path_PathBuf, std_io_Error> = v322 |> Error
                    let _run_target_args'_v329 = v339 
                    #endif
                    let v340 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v329 
                    v340
                | US9_0(v138) -> (* Ok *)
                    (* run_target_args'
                    let v143 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v144 : string = "$0.display()"
                    let v145 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v138 v144 
                    let _run_target_args'_v143 = v145 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v146 : string = "$0.display()"
                    let v147 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v138 v146 
                    let _run_target_args'_v143 = v147 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v148 : string = "$0.display()"
                    let v149 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v138 v148 
                    let _run_target_args'_v143 = v149 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v151 : std_path_Display = v138 |> unbox<std_path_Display>
                    let _run_target_args'_v143 = v151 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v155 : std_path_Display = v138 |> unbox<std_path_Display>
                    let _run_target_args'_v143 = v155 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v159 : std_path_Display = v138 |> unbox<std_path_Display>
                    let _run_target_args'_v143 = v159 
                    #endif
#else
                    let v163 : std_path_Display = v138 |> unbox<std_path_Display>
                    let _run_target_args'_v143 = v163 
                    #endif
                    let v166 : std_path_Display = _run_target_args'_v143 
                    let v173 : string = v166 |> string 
                    let v176 : string = method26(v173, v4)
                    (* run_target_args'
                    let v181 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v182 : string = "&*$0"
                    let v183 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v176 v182 
                    let _run_target_args'_v181 = v183 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v184 : string = "&*$0"
                    let v185 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v176 v184 
                    let _run_target_args'_v181 = v185 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v186 : string = "&*$0"
                    let v187 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v176 v186 
                    let _run_target_args'_v181 = v187 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v189 : Ref<Str> = v176 |> unbox<Ref<Str>>
                    let _run_target_args'_v181 = v189 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v193 : Ref<Str> = v176 |> unbox<Ref<Str>>
                    let _run_target_args'_v181 = v193 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v197 : Ref<Str> = v176 |> unbox<Ref<Str>>
                    let _run_target_args'_v181 = v197 
                    #endif
#else
                    let v201 : Ref<Str> = v176 |> unbox<Ref<Str>>
                    let _run_target_args'_v181 = v201 
                    #endif
                    let v204 : Ref<Str> = _run_target_args'_v181 
                    (* run_target_args'
                    let v214 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v215 : string = "String::from($0)"
                    let v216 : std_string_String = Fable.Core.RustInterop.emitRustExpr v204 v215 
                    let _run_target_args'_v214 = v216 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v217 : string = "String::from($0)"
                    let v218 : std_string_String = Fable.Core.RustInterop.emitRustExpr v204 v217 
                    let _run_target_args'_v214 = v218 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v219 : string = "String::from($0)"
                    let v220 : std_string_String = Fable.Core.RustInterop.emitRustExpr v204 v219 
                    let _run_target_args'_v214 = v220 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v222 : std_string_String = v204 |> unbox<std_string_String>
                    let _run_target_args'_v214 = v222 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v226 : std_string_String = v204 |> unbox<std_string_String>
                    let _run_target_args'_v214 = v226 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v230 : std_string_String = v204 |> unbox<std_string_String>
                    let _run_target_args'_v214 = v230 
                    #endif
#else
                    let v234 : std_string_String = v204 |> unbox<std_string_String>
                    let _run_target_args'_v214 = v234 
                    #endif
                    let v237 : std_string_String = _run_target_args'_v214 
                    (* run_target_args'
                    let v247 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v248 : string = "std::path::PathBuf::from($0)"
                    let v249 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v237 v248 
                    let _run_target_args'_v247 = v249 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v250 : string = "std::path::PathBuf::from($0)"
                    let v251 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v237 v250 
                    let _run_target_args'_v247 = v251 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v252 : string = "std::path::PathBuf::from($0)"
                    let v253 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v237 v252 
                    let _run_target_args'_v247 = v253 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v255 : std_path_PathBuf = v237 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v247 = v255 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v259 : std_path_PathBuf = v237 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v247 = v259 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v263 : std_path_PathBuf = v237 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v247 = v263 
                    #endif
#else
                    let v267 : std_path_PathBuf = v237 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v247 = v267 
                    #endif
                    let v270 : std_path_PathBuf = _run_target_args'_v247 
                    (* run_target_args'
                    let v277 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v278 : string = "Ok($0)"
                    let v279 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v270 v278 
                    let _run_target_args'_v277 = v279 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v280 : string = "Ok($0)"
                    let v281 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v270 v280 
                    let _run_target_args'_v277 = v281 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v282 : string = "Ok($0)"
                    let v283 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v270 v282 
                    let _run_target_args'_v277 = v283 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v284 : Result<std_path_PathBuf, std_io_Error> = v270 |> Ok
                    let _run_target_args'_v277 = v284 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v285 : Result<std_path_PathBuf, std_io_Error> = v270 |> Ok
                    let _run_target_args'_v277 = v285 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v286 : Result<std_path_PathBuf, std_io_Error> = v270 |> Ok
                    let _run_target_args'_v277 = v286 
                    #endif
#else
                    let v287 : Result<std_path_PathBuf, std_io_Error> = v270 |> Ok
                    let _run_target_args'_v277 = v287 
                    #endif
                    let v288 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v277 
                    v288
            else
                let v345 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v346 : string = $"path: {v0} / error: {v53} / path': {v0} / name: {v4}"
                let v347 : string = v345 + v346 
                (* run_target_args'
                let v352 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v353 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v354 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v347 v353 
                let _run_target_args'_v352 = v354 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v355 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v356 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v347 v355 
                let _run_target_args'_v352 = v356 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v357 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v358 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v347 v357 
                let _run_target_args'_v352 = v358 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v360 : std_io_Error = v347 |> unbox<std_io_Error>
                let _run_target_args'_v352 = v360 
                #endif
#if FABLE_COMPILER_PYTHON
                let v364 : std_io_Error = v347 |> unbox<std_io_Error>
                let _run_target_args'_v352 = v364 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v368 : std_io_Error = v347 |> unbox<std_io_Error>
                let _run_target_args'_v352 = v368 
                #endif
#else
                let v372 : std_io_Error = v347 |> unbox<std_io_Error>
                let _run_target_args'_v352 = v372 
                #endif
                let v375 : std_io_Error = _run_target_args'_v352 
                (* run_target_args'
                let v382 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v383 : string = "Err($0)"
                let v384 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v375 v383 
                let _run_target_args'_v382 = v384 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v385 : string = "Err($0)"
                let v386 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v375 v385 
                let _run_target_args'_v382 = v386 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v387 : string = "Err($0)"
                let v388 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v375 v387 
                let _run_target_args'_v382 = v388 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v389 : Result<std_path_PathBuf, std_io_Error> = v375 |> Error
                let _run_target_args'_v382 = v389 
                #endif
#if FABLE_COMPILER_PYTHON
                let v390 : Result<std_path_PathBuf, std_io_Error> = v375 |> Error
                let _run_target_args'_v382 = v390 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v391 : Result<std_path_PathBuf, std_io_Error> = v375 |> Error
                let _run_target_args'_v382 = v391 
                #endif
#else
                let v392 : Result<std_path_PathBuf, std_io_Error> = v375 |> Error
                let _run_target_args'_v382 = v392 
                #endif
                let v393 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v382 
                v393
        | _ ->
            let v397 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v398 : string = $"path: {v0} / error: {v53} / path': {v0} / name: {v4}"
            let v399 : string = v397 + v398 
            (* run_target_args'
            let v404 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v405 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v406 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v399 v405 
            let _run_target_args'_v404 = v406 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v407 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v408 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v399 v407 
            let _run_target_args'_v404 = v408 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v409 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v410 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v399 v409 
            let _run_target_args'_v404 = v410 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v412 : std_io_Error = v399 |> unbox<std_io_Error>
            let _run_target_args'_v404 = v412 
            #endif
#if FABLE_COMPILER_PYTHON
            let v416 : std_io_Error = v399 |> unbox<std_io_Error>
            let _run_target_args'_v404 = v416 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v420 : std_io_Error = v399 |> unbox<std_io_Error>
            let _run_target_args'_v404 = v420 
            #endif
#else
            let v424 : std_io_Error = v399 |> unbox<std_io_Error>
            let _run_target_args'_v404 = v424 
            #endif
            let v427 : std_io_Error = _run_target_args'_v404 
            (* run_target_args'
            let v434 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v435 : string = "Err($0)"
            let v436 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v427 v435 
            let _run_target_args'_v434 = v436 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v437 : string = "Err($0)"
            let v438 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v427 v437 
            let _run_target_args'_v434 = v438 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v439 : string = "Err($0)"
            let v440 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v427 v439 
            let _run_target_args'_v434 = v440 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v441 : Result<std_path_PathBuf, std_io_Error> = v427 |> Error
            let _run_target_args'_v434 = v441 
            #endif
#if FABLE_COMPILER_PYTHON
            let v442 : Result<std_path_PathBuf, std_io_Error> = v427 |> Error
            let _run_target_args'_v434 = v442 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v443 : Result<std_path_PathBuf, std_io_Error> = v427 |> Error
            let _run_target_args'_v434 = v443 
            #endif
#else
            let v444 : Result<std_path_PathBuf, std_io_Error> = v427 |> Error
            let _run_target_args'_v434 = v444 
            #endif
            let v445 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v434 
            v445
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
    let v77 : string = $"{v70}"
    let v85 : unit = ()
    let v86 : (unit -> unit) = closure8(v36, v77)
    let v87 : unit = (fun () -> v86 (); v85) ()
    let v93 : string = v36.l0
    let v94 : bool = v2 >= 11uy
    if v94 then
        let v95 : string = $"file_system.read_link / "
        let v96 : string = $"path: {v0} / n: {v2} / path': {v4} / name: {v5}"
        let v97 : string = v95 + v96 
        (* run_target_args'
        let v102 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v103 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v104 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v97 v103 
        let _run_target_args'_v102 = v104 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v105 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v106 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v97 v105 
        let _run_target_args'_v102 = v106 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v107 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v108 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v97 v107 
        let _run_target_args'_v102 = v108 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v110 : std_io_Error = v97 |> unbox<std_io_Error>
        let _run_target_args'_v102 = v110 
        #endif
#if FABLE_COMPILER_PYTHON
        let v114 : std_io_Error = v97 |> unbox<std_io_Error>
        let _run_target_args'_v102 = v114 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v118 : std_io_Error = v97 |> unbox<std_io_Error>
        let _run_target_args'_v102 = v118 
        #endif
#else
        let v122 : std_io_Error = v97 |> unbox<std_io_Error>
        let _run_target_args'_v102 = v122 
        #endif
        let v125 : std_io_Error = _run_target_args'_v102 
        (* run_target_args'
        let v132 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v133 : string = "Err($0)"
        let v134 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v125 v133 
        let _run_target_args'_v132 = v134 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v135 : string = "Err($0)"
        let v136 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v125 v135 
        let _run_target_args'_v132 = v136 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v137 : string = "Err($0)"
        let v138 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v125 v137 
        let _run_target_args'_v132 = v138 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v139 : Result<std_path_PathBuf, std_io_Error> = v125 |> Error
        let _run_target_args'_v132 = v139 
        #endif
#if FABLE_COMPILER_PYTHON
        let v140 : Result<std_path_PathBuf, std_io_Error> = v125 |> Error
        let _run_target_args'_v132 = v140 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v141 : Result<std_path_PathBuf, std_io_Error> = v125 |> Error
        let _run_target_args'_v132 = v141 
        #endif
#else
        let v142 : Result<std_path_PathBuf, std_io_Error> = v125 |> Error
        let _run_target_args'_v132 = v142 
        #endif
        let v143 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v132 
        v143
    else
        match v31 with
        | US5_0(v146) -> (* Some *)
            let v149 : string = ""
            let v150 : bool = v4 <> v149 
            if v150 then
                let v153 : uint8 = v2 + 1uy
                let v154 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v153
                let v155 : Result<std_path_PathBuf, std_io_Error> = v154 v146
                let v156 : (std_io_Error -> string) = method38()
                (* run_target_args'
                let v158 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v159 : string = "$0.map_err(|x| $1(x))"
                let v160 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v155, v156) v159 
                let _run_target_args'_v158 = v160 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v161 : string = "$0.map_err(|x| $1(x))"
                let v162 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v155, v156) v161 
                let _run_target_args'_v158 = v162 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v163 : string = "$0.map_err(|x| $1(x))"
                let v164 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v155, v156) v163 
                let _run_target_args'_v158 = v164 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v165 : Result<std_path_PathBuf, string> = match v155 with Ok x -> Ok x | Error x -> Error (v156 x)
                let _run_target_args'_v158 = v165 
                #endif
#if FABLE_COMPILER_PYTHON
                let v166 : Result<std_path_PathBuf, string> = match v155 with Ok x -> Ok x | Error x -> Error (v156 x)
                let _run_target_args'_v158 = v166 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v167 : Result<std_path_PathBuf, string> = match v155 with Ok x -> Ok x | Error x -> Error (v156 x)
                let _run_target_args'_v158 = v167 
                #endif
#else
                let v168 : Result<std_path_PathBuf, string> = match v155 with Ok x -> Ok x | Error x -> Error (v156 x)
                let _run_target_args'_v158 = v168 
                #endif
                let v169 : Result<std_path_PathBuf, string> = _run_target_args'_v158 
                let v172 : (std_path_PathBuf -> US9) = method39()
                let v173 : (string -> US9) = method40()
                let v175 : US9 = match v169 with Ok x -> v172 x | Error x -> v173 x
                match v175 with
                | US9_1(v331) -> (* Error *)
                    let v332 : string = $"file_system.read_link / "
                    let v333 : string = $"error': {v331} / error: {v93} / name: {v5}"
                    let v334 : string = v332 + v333 
                    (* run_target_args'
                    let v339 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v340 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v341 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v334 v340 
                    let _run_target_args'_v339 = v341 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v342 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v343 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v334 v342 
                    let _run_target_args'_v339 = v343 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v344 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v345 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v334 v344 
                    let _run_target_args'_v339 = v345 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v347 : std_io_Error = v334 |> unbox<std_io_Error>
                    let _run_target_args'_v339 = v347 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v351 : std_io_Error = v334 |> unbox<std_io_Error>
                    let _run_target_args'_v339 = v351 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v355 : std_io_Error = v334 |> unbox<std_io_Error>
                    let _run_target_args'_v339 = v355 
                    #endif
#else
                    let v359 : std_io_Error = v334 |> unbox<std_io_Error>
                    let _run_target_args'_v339 = v359 
                    #endif
                    let v362 : std_io_Error = _run_target_args'_v339 
                    (* run_target_args'
                    let v369 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v370 : string = "Err($0)"
                    let v371 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v362 v370 
                    let _run_target_args'_v369 = v371 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v372 : string = "Err($0)"
                    let v373 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v362 v372 
                    let _run_target_args'_v369 = v373 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v374 : string = "Err($0)"
                    let v375 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v362 v374 
                    let _run_target_args'_v369 = v375 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v376 : Result<std_path_PathBuf, std_io_Error> = v362 |> Error
                    let _run_target_args'_v369 = v376 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v377 : Result<std_path_PathBuf, std_io_Error> = v362 |> Error
                    let _run_target_args'_v369 = v377 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v378 : Result<std_path_PathBuf, std_io_Error> = v362 |> Error
                    let _run_target_args'_v369 = v378 
                    #endif
#else
                    let v379 : Result<std_path_PathBuf, std_io_Error> = v362 |> Error
                    let _run_target_args'_v369 = v379 
                    #endif
                    let v380 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v369 
                    v380
                | US9_0(v178) -> (* Ok *)
                    (* run_target_args'
                    let v183 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v184 : string = "$0.display()"
                    let v185 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v178 v184 
                    let _run_target_args'_v183 = v185 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v186 : string = "$0.display()"
                    let v187 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v178 v186 
                    let _run_target_args'_v183 = v187 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v188 : string = "$0.display()"
                    let v189 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v178 v188 
                    let _run_target_args'_v183 = v189 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v191 : std_path_Display = v178 |> unbox<std_path_Display>
                    let _run_target_args'_v183 = v191 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v195 : std_path_Display = v178 |> unbox<std_path_Display>
                    let _run_target_args'_v183 = v195 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v199 : std_path_Display = v178 |> unbox<std_path_Display>
                    let _run_target_args'_v183 = v199 
                    #endif
#else
                    let v203 : std_path_Display = v178 |> unbox<std_path_Display>
                    let _run_target_args'_v183 = v203 
                    #endif
                    let v206 : std_path_Display = _run_target_args'_v183 
                    let v213 : string = v206 |> string 
                    let v216 : string = method26(v213, v5)
                    (* run_target_args'
                    let v221 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v222 : string = "&*$0"
                    let v223 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v216 v222 
                    let _run_target_args'_v221 = v223 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v224 : string = "&*$0"
                    let v225 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v216 v224 
                    let _run_target_args'_v221 = v225 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v226 : string = "&*$0"
                    let v227 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v216 v226 
                    let _run_target_args'_v221 = v227 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v229 : Ref<Str> = v216 |> unbox<Ref<Str>>
                    let _run_target_args'_v221 = v229 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v233 : Ref<Str> = v216 |> unbox<Ref<Str>>
                    let _run_target_args'_v221 = v233 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v237 : Ref<Str> = v216 |> unbox<Ref<Str>>
                    let _run_target_args'_v221 = v237 
                    #endif
#else
                    let v241 : Ref<Str> = v216 |> unbox<Ref<Str>>
                    let _run_target_args'_v221 = v241 
                    #endif
                    let v244 : Ref<Str> = _run_target_args'_v221 
                    (* run_target_args'
                    let v254 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v255 : string = "String::from($0)"
                    let v256 : std_string_String = Fable.Core.RustInterop.emitRustExpr v244 v255 
                    let _run_target_args'_v254 = v256 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v257 : string = "String::from($0)"
                    let v258 : std_string_String = Fable.Core.RustInterop.emitRustExpr v244 v257 
                    let _run_target_args'_v254 = v258 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v259 : string = "String::from($0)"
                    let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v244 v259 
                    let _run_target_args'_v254 = v260 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v262 : std_string_String = v244 |> unbox<std_string_String>
                    let _run_target_args'_v254 = v262 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v266 : std_string_String = v244 |> unbox<std_string_String>
                    let _run_target_args'_v254 = v266 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v270 : std_string_String = v244 |> unbox<std_string_String>
                    let _run_target_args'_v254 = v270 
                    #endif
#else
                    let v274 : std_string_String = v244 |> unbox<std_string_String>
                    let _run_target_args'_v254 = v274 
                    #endif
                    let v277 : std_string_String = _run_target_args'_v254 
                    (* run_target_args'
                    let v287 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v288 : string = "std::path::PathBuf::from($0)"
                    let v289 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v277 v288 
                    let _run_target_args'_v287 = v289 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v290 : string = "std::path::PathBuf::from($0)"
                    let v291 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v277 v290 
                    let _run_target_args'_v287 = v291 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v292 : string = "std::path::PathBuf::from($0)"
                    let v293 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v277 v292 
                    let _run_target_args'_v287 = v293 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v295 : std_path_PathBuf = v277 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v287 = v295 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v299 : std_path_PathBuf = v277 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v287 = v299 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v303 : std_path_PathBuf = v277 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v287 = v303 
                    #endif
#else
                    let v307 : std_path_PathBuf = v277 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v287 = v307 
                    #endif
                    let v310 : std_path_PathBuf = _run_target_args'_v287 
                    (* run_target_args'
                    let v317 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v318 : string = "Ok($0)"
                    let v319 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v310 v318 
                    let _run_target_args'_v317 = v319 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v320 : string = "Ok($0)"
                    let v321 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v310 v320 
                    let _run_target_args'_v317 = v321 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v322 : string = "Ok($0)"
                    let v323 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v310 v322 
                    let _run_target_args'_v317 = v323 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v324 : Result<std_path_PathBuf, std_io_Error> = v310 |> Ok
                    let _run_target_args'_v317 = v324 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v325 : Result<std_path_PathBuf, std_io_Error> = v310 |> Ok
                    let _run_target_args'_v317 = v325 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v326 : Result<std_path_PathBuf, std_io_Error> = v310 |> Ok
                    let _run_target_args'_v317 = v326 
                    #endif
#else
                    let v327 : Result<std_path_PathBuf, std_io_Error> = v310 |> Ok
                    let _run_target_args'_v317 = v327 
                    #endif
                    let v328 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v317 
                    v328
            else
                let v385 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v386 : string = $"path: {v0} / error: {v93} / path': {v4} / name: {v5}"
                let v387 : string = v385 + v386 
                (* run_target_args'
                let v392 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v393 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v394 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v387 v393 
                let _run_target_args'_v392 = v394 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v395 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v396 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v387 v395 
                let _run_target_args'_v392 = v396 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v397 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v398 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v387 v397 
                let _run_target_args'_v392 = v398 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v400 : std_io_Error = v387 |> unbox<std_io_Error>
                let _run_target_args'_v392 = v400 
                #endif
#if FABLE_COMPILER_PYTHON
                let v404 : std_io_Error = v387 |> unbox<std_io_Error>
                let _run_target_args'_v392 = v404 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v408 : std_io_Error = v387 |> unbox<std_io_Error>
                let _run_target_args'_v392 = v408 
                #endif
#else
                let v412 : std_io_Error = v387 |> unbox<std_io_Error>
                let _run_target_args'_v392 = v412 
                #endif
                let v415 : std_io_Error = _run_target_args'_v392 
                (* run_target_args'
                let v422 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v423 : string = "Err($0)"
                let v424 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v415 v423 
                let _run_target_args'_v422 = v424 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v425 : string = "Err($0)"
                let v426 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v415 v425 
                let _run_target_args'_v422 = v426 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v427 : string = "Err($0)"
                let v428 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v415 v427 
                let _run_target_args'_v422 = v428 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v429 : Result<std_path_PathBuf, std_io_Error> = v415 |> Error
                let _run_target_args'_v422 = v429 
                #endif
#if FABLE_COMPILER_PYTHON
                let v430 : Result<std_path_PathBuf, std_io_Error> = v415 |> Error
                let _run_target_args'_v422 = v430 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v431 : Result<std_path_PathBuf, std_io_Error> = v415 |> Error
                let _run_target_args'_v422 = v431 
                #endif
#else
                let v432 : Result<std_path_PathBuf, std_io_Error> = v415 |> Error
                let _run_target_args'_v422 = v432 
                #endif
                let v433 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v422 
                v433
        | _ ->
            let v437 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v438 : string = $"path: {v0} / error: {v93} / path': {v4} / name: {v5}"
            let v439 : string = v437 + v438 
            (* run_target_args'
            let v444 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v445 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v446 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v439 v445 
            let _run_target_args'_v444 = v446 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v447 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v448 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v439 v447 
            let _run_target_args'_v444 = v448 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v449 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v450 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v439 v449 
            let _run_target_args'_v444 = v450 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v452 : std_io_Error = v439 |> unbox<std_io_Error>
            let _run_target_args'_v444 = v452 
            #endif
#if FABLE_COMPILER_PYTHON
            let v456 : std_io_Error = v439 |> unbox<std_io_Error>
            let _run_target_args'_v444 = v456 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v460 : std_io_Error = v439 |> unbox<std_io_Error>
            let _run_target_args'_v444 = v460 
            #endif
#else
            let v464 : std_io_Error = v439 |> unbox<std_io_Error>
            let _run_target_args'_v444 = v464 
            #endif
            let v467 : std_io_Error = _run_target_args'_v444 
            (* run_target_args'
            let v474 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v475 : string = "Err($0)"
            let v476 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v467 v475 
            let _run_target_args'_v474 = v476 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v477 : string = "Err($0)"
            let v478 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v467 v477 
            let _run_target_args'_v474 = v478 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v479 : string = "Err($0)"
            let v480 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v467 v479 
            let _run_target_args'_v474 = v480 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v481 : Result<std_path_PathBuf, std_io_Error> = v467 |> Error
            let _run_target_args'_v474 = v481 
            #endif
#if FABLE_COMPILER_PYTHON
            let v482 : Result<std_path_PathBuf, std_io_Error> = v467 |> Error
            let _run_target_args'_v474 = v482 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v483 : Result<std_path_PathBuf, std_io_Error> = v467 |> Error
            let _run_target_args'_v474 = v483 
            #endif
#else
            let v484 : Result<std_path_PathBuf, std_io_Error> = v467 |> Error
            let _run_target_args'_v474 = v484 
            #endif
            let v485 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v474 
            v485
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
    let v42 : System.IO.FileAttributes = method46(v36)
    let v43 : System.IO.FileAttributes = method47()
    let v44 : bool = method48(v43, v42)
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
        method50(v0, v178, v1, v172, v2)
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
    let v76 : string = $"{v69}"
    let v84 : unit = ()
    let v85 : (unit -> unit) = closure8(v35, v76)
    let v86 : unit = (fun () -> v85 (); v84) ()
    let v92 : string = v35.l0
    let v93 : bool = v2 >= 11uy
    if v93 then
        let v94 : string = $"file_system.read_link / "
        let v95 : string = $"path: {v0} / n: {v2} / path': {v0} / name: {v4}"
        let v96 : string = v94 + v95 
        (* run_target_args'
        let v101 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v102 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v103 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v96 v102 
        let _run_target_args'_v101 = v103 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v104 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v105 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v96 v104 
        let _run_target_args'_v101 = v105 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v106 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v107 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v96 v106 
        let _run_target_args'_v101 = v107 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v109 : std_io_Error = v96 |> unbox<std_io_Error>
        let _run_target_args'_v101 = v109 
        #endif
#if FABLE_COMPILER_PYTHON
        let v113 : std_io_Error = v96 |> unbox<std_io_Error>
        let _run_target_args'_v101 = v113 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v117 : std_io_Error = v96 |> unbox<std_io_Error>
        let _run_target_args'_v101 = v117 
        #endif
#else
        let v121 : std_io_Error = v96 |> unbox<std_io_Error>
        let _run_target_args'_v101 = v121 
        #endif
        let v124 : std_io_Error = _run_target_args'_v101 
        (* run_target_args'
        let v131 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v132 : string = "Err($0)"
        let v133 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v124 v132 
        let _run_target_args'_v131 = v133 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v134 : string = "Err($0)"
        let v135 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v124 v134 
        let _run_target_args'_v131 = v135 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v136 : string = "Err($0)"
        let v137 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v124 v136 
        let _run_target_args'_v131 = v137 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v138 : Result<std_path_PathBuf, std_io_Error> = v124 |> Error
        let _run_target_args'_v131 = v138 
        #endif
#if FABLE_COMPILER_PYTHON
        let v139 : Result<std_path_PathBuf, std_io_Error> = v124 |> Error
        let _run_target_args'_v131 = v139 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v140 : Result<std_path_PathBuf, std_io_Error> = v124 |> Error
        let _run_target_args'_v131 = v140 
        #endif
#else
        let v141 : Result<std_path_PathBuf, std_io_Error> = v124 |> Error
        let _run_target_args'_v131 = v141 
        #endif
        let v142 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v131 
        v142
    else
        match v30 with
        | US5_0(v145) -> (* Some *)
            let v148 : string = ""
            let v149 : bool = v0 <> v148 
            if v149 then
                let v152 : uint8 = v2 + 1uy
                let v153 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v152
                let v154 : Result<std_path_PathBuf, std_io_Error> = v153 v145
                let v155 : (std_io_Error -> string) = method38()
                (* run_target_args'
                let v157 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v158 : string = "$0.map_err(|x| $1(x))"
                let v159 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v154, v155) v158 
                let _run_target_args'_v157 = v159 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v160 : string = "$0.map_err(|x| $1(x))"
                let v161 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v154, v155) v160 
                let _run_target_args'_v157 = v161 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v162 : string = "$0.map_err(|x| $1(x))"
                let v163 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v154, v155) v162 
                let _run_target_args'_v157 = v163 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v164 : Result<std_path_PathBuf, string> = match v154 with Ok x -> Ok x | Error x -> Error (v155 x)
                let _run_target_args'_v157 = v164 
                #endif
#if FABLE_COMPILER_PYTHON
                let v165 : Result<std_path_PathBuf, string> = match v154 with Ok x -> Ok x | Error x -> Error (v155 x)
                let _run_target_args'_v157 = v165 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v166 : Result<std_path_PathBuf, string> = match v154 with Ok x -> Ok x | Error x -> Error (v155 x)
                let _run_target_args'_v157 = v166 
                #endif
#else
                let v167 : Result<std_path_PathBuf, string> = match v154 with Ok x -> Ok x | Error x -> Error (v155 x)
                let _run_target_args'_v157 = v167 
                #endif
                let v168 : Result<std_path_PathBuf, string> = _run_target_args'_v157 
                let v171 : (std_path_PathBuf -> US9) = method39()
                let v172 : (string -> US9) = method40()
                let v174 : US9 = match v168 with Ok x -> v171 x | Error x -> v172 x
                match v174 with
                | US9_1(v330) -> (* Error *)
                    let v331 : string = $"file_system.read_link / "
                    let v332 : string = $"error': {v330} / error: {v92} / name: {v4}"
                    let v333 : string = v331 + v332 
                    (* run_target_args'
                    let v338 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v339 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v340 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v333 v339 
                    let _run_target_args'_v338 = v340 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v341 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v342 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v333 v341 
                    let _run_target_args'_v338 = v342 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v343 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v344 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v333 v343 
                    let _run_target_args'_v338 = v344 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v346 : std_io_Error = v333 |> unbox<std_io_Error>
                    let _run_target_args'_v338 = v346 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v350 : std_io_Error = v333 |> unbox<std_io_Error>
                    let _run_target_args'_v338 = v350 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v354 : std_io_Error = v333 |> unbox<std_io_Error>
                    let _run_target_args'_v338 = v354 
                    #endif
#else
                    let v358 : std_io_Error = v333 |> unbox<std_io_Error>
                    let _run_target_args'_v338 = v358 
                    #endif
                    let v361 : std_io_Error = _run_target_args'_v338 
                    (* run_target_args'
                    let v368 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v369 : string = "Err($0)"
                    let v370 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v361 v369 
                    let _run_target_args'_v368 = v370 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v371 : string = "Err($0)"
                    let v372 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v361 v371 
                    let _run_target_args'_v368 = v372 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v373 : string = "Err($0)"
                    let v374 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v361 v373 
                    let _run_target_args'_v368 = v374 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v375 : Result<std_path_PathBuf, std_io_Error> = v361 |> Error
                    let _run_target_args'_v368 = v375 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v376 : Result<std_path_PathBuf, std_io_Error> = v361 |> Error
                    let _run_target_args'_v368 = v376 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v377 : Result<std_path_PathBuf, std_io_Error> = v361 |> Error
                    let _run_target_args'_v368 = v377 
                    #endif
#else
                    let v378 : Result<std_path_PathBuf, std_io_Error> = v361 |> Error
                    let _run_target_args'_v368 = v378 
                    #endif
                    let v379 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v368 
                    v379
                | US9_0(v177) -> (* Ok *)
                    (* run_target_args'
                    let v182 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v183 : string = "$0.display()"
                    let v184 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v177 v183 
                    let _run_target_args'_v182 = v184 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v185 : string = "$0.display()"
                    let v186 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v177 v185 
                    let _run_target_args'_v182 = v186 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v187 : string = "$0.display()"
                    let v188 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v177 v187 
                    let _run_target_args'_v182 = v188 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v190 : std_path_Display = v177 |> unbox<std_path_Display>
                    let _run_target_args'_v182 = v190 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v194 : std_path_Display = v177 |> unbox<std_path_Display>
                    let _run_target_args'_v182 = v194 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v198 : std_path_Display = v177 |> unbox<std_path_Display>
                    let _run_target_args'_v182 = v198 
                    #endif
#else
                    let v202 : std_path_Display = v177 |> unbox<std_path_Display>
                    let _run_target_args'_v182 = v202 
                    #endif
                    let v205 : std_path_Display = _run_target_args'_v182 
                    let v212 : string = v205 |> string 
                    let v215 : string = method26(v212, v4)
                    (* run_target_args'
                    let v220 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v221 : string = "&*$0"
                    let v222 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v215 v221 
                    let _run_target_args'_v220 = v222 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v223 : string = "&*$0"
                    let v224 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v215 v223 
                    let _run_target_args'_v220 = v224 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v225 : string = "&*$0"
                    let v226 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v215 v225 
                    let _run_target_args'_v220 = v226 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v228 : Ref<Str> = v215 |> unbox<Ref<Str>>
                    let _run_target_args'_v220 = v228 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v232 : Ref<Str> = v215 |> unbox<Ref<Str>>
                    let _run_target_args'_v220 = v232 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v236 : Ref<Str> = v215 |> unbox<Ref<Str>>
                    let _run_target_args'_v220 = v236 
                    #endif
#else
                    let v240 : Ref<Str> = v215 |> unbox<Ref<Str>>
                    let _run_target_args'_v220 = v240 
                    #endif
                    let v243 : Ref<Str> = _run_target_args'_v220 
                    (* run_target_args'
                    let v253 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v254 : string = "String::from($0)"
                    let v255 : std_string_String = Fable.Core.RustInterop.emitRustExpr v243 v254 
                    let _run_target_args'_v253 = v255 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v256 : string = "String::from($0)"
                    let v257 : std_string_String = Fable.Core.RustInterop.emitRustExpr v243 v256 
                    let _run_target_args'_v253 = v257 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v258 : string = "String::from($0)"
                    let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v243 v258 
                    let _run_target_args'_v253 = v259 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v261 : std_string_String = v243 |> unbox<std_string_String>
                    let _run_target_args'_v253 = v261 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v265 : std_string_String = v243 |> unbox<std_string_String>
                    let _run_target_args'_v253 = v265 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v269 : std_string_String = v243 |> unbox<std_string_String>
                    let _run_target_args'_v253 = v269 
                    #endif
#else
                    let v273 : std_string_String = v243 |> unbox<std_string_String>
                    let _run_target_args'_v253 = v273 
                    #endif
                    let v276 : std_string_String = _run_target_args'_v253 
                    (* run_target_args'
                    let v286 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v287 : string = "std::path::PathBuf::from($0)"
                    let v288 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v276 v287 
                    let _run_target_args'_v286 = v288 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v289 : string = "std::path::PathBuf::from($0)"
                    let v290 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v276 v289 
                    let _run_target_args'_v286 = v290 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v291 : string = "std::path::PathBuf::from($0)"
                    let v292 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v276 v291 
                    let _run_target_args'_v286 = v292 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v294 : std_path_PathBuf = v276 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v286 = v294 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v298 : std_path_PathBuf = v276 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v286 = v298 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v302 : std_path_PathBuf = v276 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v286 = v302 
                    #endif
#else
                    let v306 : std_path_PathBuf = v276 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v286 = v306 
                    #endif
                    let v309 : std_path_PathBuf = _run_target_args'_v286 
                    (* run_target_args'
                    let v316 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v317 : string = "Ok($0)"
                    let v318 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v309 v317 
                    let _run_target_args'_v316 = v318 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v319 : string = "Ok($0)"
                    let v320 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v309 v319 
                    let _run_target_args'_v316 = v320 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v321 : string = "Ok($0)"
                    let v322 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v309 v321 
                    let _run_target_args'_v316 = v322 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v323 : Result<std_path_PathBuf, std_io_Error> = v309 |> Ok
                    let _run_target_args'_v316 = v323 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v324 : Result<std_path_PathBuf, std_io_Error> = v309 |> Ok
                    let _run_target_args'_v316 = v324 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v325 : Result<std_path_PathBuf, std_io_Error> = v309 |> Ok
                    let _run_target_args'_v316 = v325 
                    #endif
#else
                    let v326 : Result<std_path_PathBuf, std_io_Error> = v309 |> Ok
                    let _run_target_args'_v316 = v326 
                    #endif
                    let v327 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v316 
                    v327
            else
                let v384 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v385 : string = $"path: {v0} / error: {v92} / path': {v0} / name: {v4}"
                let v386 : string = v384 + v385 
                (* run_target_args'
                let v391 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v392 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v393 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v386 v392 
                let _run_target_args'_v391 = v393 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v394 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v395 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v386 v394 
                let _run_target_args'_v391 = v395 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v396 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v397 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v386 v396 
                let _run_target_args'_v391 = v397 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v399 : std_io_Error = v386 |> unbox<std_io_Error>
                let _run_target_args'_v391 = v399 
                #endif
#if FABLE_COMPILER_PYTHON
                let v403 : std_io_Error = v386 |> unbox<std_io_Error>
                let _run_target_args'_v391 = v403 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v407 : std_io_Error = v386 |> unbox<std_io_Error>
                let _run_target_args'_v391 = v407 
                #endif
#else
                let v411 : std_io_Error = v386 |> unbox<std_io_Error>
                let _run_target_args'_v391 = v411 
                #endif
                let v414 : std_io_Error = _run_target_args'_v391 
                (* run_target_args'
                let v421 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v422 : string = "Err($0)"
                let v423 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v414 v422 
                let _run_target_args'_v421 = v423 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v424 : string = "Err($0)"
                let v425 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v414 v424 
                let _run_target_args'_v421 = v425 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v426 : string = "Err($0)"
                let v427 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v414 v426 
                let _run_target_args'_v421 = v427 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v428 : Result<std_path_PathBuf, std_io_Error> = v414 |> Error
                let _run_target_args'_v421 = v428 
                #endif
#if FABLE_COMPILER_PYTHON
                let v429 : Result<std_path_PathBuf, std_io_Error> = v414 |> Error
                let _run_target_args'_v421 = v429 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v430 : Result<std_path_PathBuf, std_io_Error> = v414 |> Error
                let _run_target_args'_v421 = v430 
                #endif
#else
                let v431 : Result<std_path_PathBuf, std_io_Error> = v414 |> Error
                let _run_target_args'_v421 = v431 
                #endif
                let v432 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v421 
                v432
        | _ ->
            let v436 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v437 : string = $"path: {v0} / error: {v92} / path': {v0} / name: {v4}"
            let v438 : string = v436 + v437 
            (* run_target_args'
            let v443 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v444 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v445 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v438 v444 
            let _run_target_args'_v443 = v445 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v446 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v447 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v438 v446 
            let _run_target_args'_v443 = v447 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v448 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v449 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v438 v448 
            let _run_target_args'_v443 = v449 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v451 : std_io_Error = v438 |> unbox<std_io_Error>
            let _run_target_args'_v443 = v451 
            #endif
#if FABLE_COMPILER_PYTHON
            let v455 : std_io_Error = v438 |> unbox<std_io_Error>
            let _run_target_args'_v443 = v455 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v459 : std_io_Error = v438 |> unbox<std_io_Error>
            let _run_target_args'_v443 = v459 
            #endif
#else
            let v463 : std_io_Error = v438 |> unbox<std_io_Error>
            let _run_target_args'_v443 = v463 
            #endif
            let v466 : std_io_Error = _run_target_args'_v443 
            (* run_target_args'
            let v473 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v474 : string = "Err($0)"
            let v475 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v466 v474 
            let _run_target_args'_v473 = v475 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v476 : string = "Err($0)"
            let v477 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v466 v476 
            let _run_target_args'_v473 = v477 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v478 : string = "Err($0)"
            let v479 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v466 v478 
            let _run_target_args'_v473 = v479 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v480 : Result<std_path_PathBuf, std_io_Error> = v466 |> Error
            let _run_target_args'_v473 = v480 
            #endif
#if FABLE_COMPILER_PYTHON
            let v481 : Result<std_path_PathBuf, std_io_Error> = v466 |> Error
            let _run_target_args'_v473 = v481 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v482 : Result<std_path_PathBuf, std_io_Error> = v466 |> Error
            let _run_target_args'_v473 = v482 
            #endif
#else
            let v483 : Result<std_path_PathBuf, std_io_Error> = v466 |> Error
            let _run_target_args'_v473 = v483 
            #endif
            let v484 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v473 
            v484
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
    let v41 : System.IO.FileAttributes = method46(v35)
    let v42 : System.IO.FileAttributes = method47()
    let v43 : bool = method48(v42, v41)
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
        method51(v0, v177, v1, v171)
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
        let v86 : string =
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
                let v82 : string = v75 |> string 
                v82
        let v87 : bool = v86 = ""
        let v88 : string =
            if v87 then
                v0
            else
                v86
        let v89 : string = "^\\\\\\\\\\?\\\\"
        let v90 : string = ""
        let v91 : string = method53(v89, v90, v88)
        let v92 : int32 = v91.Length
        let v93 : bool = v92 < 2
        if v93 then
            v0
        else
            let v94 : string = $"{v91.[0] |> string |> _.ToLower()}{v91.[1..]}"
            let v95 : string = "\\"
            let v96 : string = "/"
            let v97 : string = v94.Replace (v95, v96)
            v97
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
    let v297 : string =
        if v107 then
            let v108 : string = method24()
            let v109 : string = method26(v108, v0)
            let v110 : string = method35(v109)
            let v118 : string = "/"
            let v119 : (string []) = v110.Split v118 
            let v122 : (string []) = [||]
            let v123 : int32 = v119.Length
            let v124 : Mut5 = {l0 = 0; l1 = 0; l2 = v122} : Mut5
            while method57(v123, v124) do
                let v126 : int32 = v124.l0
                let v127 : int32 =  -v126
                let v128 : int32 = v127 + v123
                let v129 : int32 = v128 - 1
                let struct (v130 : int32, v131 : (string [])) = v124.l1, v124.l2
                let v132 : string = v119.[int v129]
                let v133 : bool = ".." = v132
                let struct (v179 : int32, v180 : (string [])) =
                    if v133 then
                        let v134 : int32 = v130 + 1
                        struct (v134, v131)
                    else
                        let v135 : bool = "." = v132
                        if v135 then
                            struct (v130, v131)
                        else
                            let v136 : bool = 0 = v130
                            if v136 then
                                let v139 : string = ":"
                                let v140 : bool = v132.EndsWith (v139, false, null)
                                if v140 then
                                    let v143 : string = $"{v108.[0]}:"
                                    let v144 : (string []) = [|v143|]
                                    let v145 : int32 = v144.Length
                                    let v146 : int32 = v131.Length
                                    let v147 : int32 = v145 + v146
                                    let v148 : (string []) = Array.zeroCreate<string> (v147)
                                    let v149 : Mut6 = {l0 = 0} : Mut6
                                    while method58(v147, v149) do
                                        let v151 : int32 = v149.l0
                                        let v152 : bool = v151 < v145
                                        let v156 : string =
                                            if v152 then
                                                let v153 : string = v144.[int v151]
                                                v153
                                            else
                                                let v154 : int32 = v151 - v145
                                                let v155 : string = v131.[int v154]
                                                v155
                                        v148.[int v151] <- v156
                                        let v157 : int32 = v151 + 1
                                        v149.l0 <- v157
                                        ()
                                    struct (0, v148)
                                else
                                    let v158 : (string []) = [|v132|]
                                    let v159 : int32 = v158.Length
                                    let v160 : int32 = v131.Length
                                    let v161 : int32 = v159 + v160
                                    let v162 : (string []) = Array.zeroCreate<string> (v161)
                                    let v163 : Mut6 = {l0 = 0} : Mut6
                                    while method58(v161, v163) do
                                        let v165 : int32 = v163.l0
                                        let v166 : bool = v165 < v159
                                        let v170 : string =
                                            if v166 then
                                                let v167 : string = v158.[int v165]
                                                v167
                                            else
                                                let v168 : int32 = v165 - v159
                                                let v169 : string = v131.[int v168]
                                                v169
                                        v162.[int v165] <- v170
                                        let v171 : int32 = v165 + 1
                                        v163.l0 <- v171
                                        ()
                                    struct (0, v162)
                            else
                                let v174 : int32 = v130 - 1
                                struct (v174, v131)
                let v181 : int32 = v126 + 1
                v124.l0 <- v181
                v124.l1 <- v179
                v124.l2 <- v180
                ()
            let struct (v182 : int32, v183 : (string [])) = v124.l1, v124.l2
            let v188 : unit = ()
            let _let'_v188 =
                seq {
                    for i = 0 to v183.Length - 1 do yield v183.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v191 : string seq = _let'_v188 
            let v197 : char = method59()
            let v199 : (char -> string) = _.ToString()
            let v200 : string = v199 v197
            let v204 : bool = v200 = "\n"
            let v206 : string =
                if v204 then
                    method60(v200)
                else
                    v200
            let v207 : (string -> (string seq -> string)) = String.concat
            let v208 : (string seq -> string) = v207 v206
            v208 v191
        else
            let v212 : string = "std::fs::canonicalize(&*$0)"
            let v213 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v212 
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "$0.unwrap()"
            let v217 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v213 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "$0.unwrap()"
            let v219 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v213 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "$0.unwrap()"
            let v221 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v213 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : std_path_PathBuf = match v213 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v215 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v223 : std_path_PathBuf = match v213 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v215 = v223 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v224 : std_path_PathBuf = match v213 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v215 = v224 
            #endif
#else
            let v225 : std_path_PathBuf = match v213 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v215 = v225 
            #endif
            let v226 : std_path_PathBuf = _run_target_args'_v215 
            (* run_target_args'
            let v233 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v234 : string = "$0.display()"
            let v235 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v226 v234 
            let _run_target_args'_v233 = v235 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v236 : string = "$0.display()"
            let v237 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v226 v236 
            let _run_target_args'_v233 = v237 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v238 : string = "$0.display()"
            let v239 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v226 v238 
            let _run_target_args'_v233 = v239 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v241 : std_path_Display = v226 |> unbox<std_path_Display>
            let _run_target_args'_v233 = v241 
            #endif
#if FABLE_COMPILER_PYTHON
            let v245 : std_path_Display = v226 |> unbox<std_path_Display>
            let _run_target_args'_v233 = v245 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v249 : std_path_Display = v226 |> unbox<std_path_Display>
            let _run_target_args'_v233 = v249 
            #endif
#else
            let v253 : std_path_Display = v226 |> unbox<std_path_Display>
            let _run_target_args'_v233 = v253 
            #endif
            let v256 : std_path_Display = _run_target_args'_v233 
            (* run_target_args'
            let v266 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v267 : string = "format!(\"{}\", $0)"
            let v268 : std_string_String = Fable.Core.RustInterop.emitRustExpr v256 v267 
            let _run_target_args'_v266 = v268 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v269 : string = "format!(\"{}\", $0)"
            let v270 : std_string_String = Fable.Core.RustInterop.emitRustExpr v256 v269 
            let _run_target_args'_v266 = v270 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v271 : string = "format!(\"{}\", $0)"
            let v272 : std_string_String = Fable.Core.RustInterop.emitRustExpr v256 v271 
            let _run_target_args'_v266 = v272 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v274 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v266 = v274 
            #endif
#if FABLE_COMPILER_PYTHON
            let v278 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v266 = v278 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v282 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v266 = v282 
            #endif
#else
            let v286 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v266 = v286 
            #endif
            let v289 : std_string_String = _run_target_args'_v266 
            let v295 : string = "fable_library_rust::String_::fromString($0)"
            let v296 : string = Fable.Core.RustInterop.emitRustExpr v289 v295 
            v296
    let _run_target_args'_v5 = v297 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v299 : string = null |> unbox<string>
    let _run_target_args'_v5 = v299 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v303 : string = null |> unbox<string>
    let _run_target_args'_v5 = v303 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v307 : string = null |> unbox<string>
    let _run_target_args'_v5 = v307 
    #endif
#if FABLE_COMPILER_PYTHON
    let v311 : string = null |> unbox<string>
    let _run_target_args'_v5 = v311 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v315 : string = null |> unbox<string>
    let _run_target_args'_v5 = v315 
    #endif
#else
    let v318 : (string -> string) = System.IO.Path.GetFullPath
    let v319 : string = v318 v0
    let _run_target_args'_v5 = v319 
    #endif
    let v320 : string = _run_target_args'_v5 
    v320
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
    let v83 : string = "inline_colorization::color_reset"
    let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v83 
    let v85 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v86 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v49, v77, v84) v85 
    let v87 : string = "fable_library_rust::String_::fromString($0)"
    let v88 : string = Fable.Core.RustInterop.emitRustExpr v86 v87 
    let _run_target_args'_v47 = v88 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v89 : string = "inline_colorization::color_bright_blue"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    (* run_target_args'
    let v95 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v96 : string = "&*$0"
    let v97 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v96 
    let _run_target_args'_v95 = v97 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v98 : string = "&*$0"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v98 
    let _run_target_args'_v95 = v99 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v100 : string = "&*$0"
    let v101 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v100 
    let _run_target_args'_v95 = v101 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v103 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v103 
    #endif
#if FABLE_COMPILER_PYTHON
    let v107 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v107 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v111 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v111 
    #endif
#else
    let v115 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v115 
    #endif
    let v118 : Ref<Str> = _run_target_args'_v95 
    let v124 : string = "inline_colorization::color_reset"
    let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v124 
    let v126 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v127 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v90, v118, v125) v126 
    let v128 : string = "fable_library_rust::String_::fromString($0)"
    let v129 : string = Fable.Core.RustInterop.emitRustExpr v127 v128 
    let _run_target_args'_v47 = v129 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v130 : string = "inline_colorization::color_bright_blue"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    (* run_target_args'
    let v136 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v137 : string = "&*$0"
    let v138 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v137 
    let _run_target_args'_v136 = v138 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v139 : string = "&*$0"
    let v140 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v139 
    let _run_target_args'_v136 = v140 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v141 : string = "&*$0"
    let v142 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v141 
    let _run_target_args'_v136 = v142 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v144 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v144 
    #endif
#if FABLE_COMPILER_PYTHON
    let v148 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v148 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v152 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v152 
    #endif
#else
    let v156 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v156 
    #endif
    let v159 : Ref<Str> = _run_target_args'_v136 
    let v165 : string = "inline_colorization::color_reset"
    let v166 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v165 
    let v167 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v168 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v131, v159, v166) v167 
    let v169 : string = "fable_library_rust::String_::fromString($0)"
    let v170 : string = Fable.Core.RustInterop.emitRustExpr v168 v169 
    let _run_target_args'_v47 = v170 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v172 : string = "\u001b[94m"
    let v176 : string = method14()
    let v180 : string = v172 + v30 
    let v184 : string = v180 + v176 
    let _run_target_args'_v47 = v184 
    #endif
#if FABLE_COMPILER_PYTHON
    let v188 : string = "\u001b[94m"
    let v192 : string = method14()
    let v196 : string = v188 + v30 
    let v200 : string = v196 + v192 
    let _run_target_args'_v47 = v200 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v204 : string = "\u001b[94m"
    let v208 : string = method14()
    let v212 : string = v204 + v30 
    let v216 : string = v212 + v208 
    let _run_target_args'_v47 = v216 
    #endif
#else
    let v220 : string = "\u001b[94m"
    let v224 : string = method14()
    let v228 : string = v220 + v30 
    let v232 : string = v228 + v224 
    let _run_target_args'_v47 = v232 
    #endif
    let v235 : string = _run_target_args'_v47 
    v235
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
    let v220 : US12 =
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
                let v84 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v85 : string = "format!(\"{}\", $0)"
                let v86 : std_string_String = Fable.Core.RustInterop.emitRustExpr v74 v85 
                let _run_target_args'_v84 = v86 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v87 : string = "format!(\"{}\", $0)"
                let v88 : std_string_String = Fable.Core.RustInterop.emitRustExpr v74 v87 
                let _run_target_args'_v84 = v88 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v89 : string = "format!(\"{}\", $0)"
                let v90 : std_string_String = Fable.Core.RustInterop.emitRustExpr v74 v89 
                let _run_target_args'_v84 = v90 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v92 : std_string_String = null |> unbox<std_string_String>
                let _run_target_args'_v84 = v92 
                #endif
#if FABLE_COMPILER_PYTHON
                let v96 : std_string_String = null |> unbox<std_string_String>
                let _run_target_args'_v84 = v96 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v100 : std_string_String = null |> unbox<std_string_String>
                let _run_target_args'_v84 = v100 
                #endif
#else
                let v104 : std_string_String = null |> unbox<std_string_String>
                let _run_target_args'_v84 = v104 
                #endif
                let v107 : std_string_String = _run_target_args'_v84 
                let v113 : string = "fable_library_rust::String_::fromString($0)"
                let v114 : string = Fable.Core.RustInterop.emitRustExpr v107 v113 
                let v117 : string = ".md"
                let v118 : bool = v114.EndsWith (v117, false, null)
                let v121 : bool = v118 = false
                let v128 : bool =
                    if v121 then
                        true
                    else
                        let v124 : string = ".hangul.md"
                        let v125 : bool = v114.EndsWith (v124, false, null)
                        v125
                if v128 then
                    US12_0
                else
                    US12_2
        | _ ->
            let v133 : string = "async_walkdir::DirEntry::path(&$0)"
            let v134 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v0 v133 
            (* run_target_args'
            let v139 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v140 : string = "$0.display()"
            let v141 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v134 v140 
            let _run_target_args'_v139 = v141 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v142 : string = "$0.display()"
            let v143 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v134 v142 
            let _run_target_args'_v139 = v143 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v144 : string = "$0.display()"
            let v145 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v134 v144 
            let _run_target_args'_v139 = v145 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v147 : std_path_Display = v134 |> unbox<std_path_Display>
            let _run_target_args'_v139 = v147 
            #endif
#if FABLE_COMPILER_PYTHON
            let v151 : std_path_Display = v134 |> unbox<std_path_Display>
            let _run_target_args'_v139 = v151 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v155 : std_path_Display = v134 |> unbox<std_path_Display>
            let _run_target_args'_v139 = v155 
            #endif
#else
            let v159 : std_path_Display = v134 |> unbox<std_path_Display>
            let _run_target_args'_v139 = v159 
            #endif
            let v162 : std_path_Display = _run_target_args'_v139 
            (* run_target_args'
            let v172 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v173 : string = "format!(\"{}\", $0)"
            let v174 : std_string_String = Fable.Core.RustInterop.emitRustExpr v162 v173 
            let _run_target_args'_v172 = v174 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v175 : string = "format!(\"{}\", $0)"
            let v176 : std_string_String = Fable.Core.RustInterop.emitRustExpr v162 v175 
            let _run_target_args'_v172 = v176 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v177 : string = "format!(\"{}\", $0)"
            let v178 : std_string_String = Fable.Core.RustInterop.emitRustExpr v162 v177 
            let _run_target_args'_v172 = v178 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v180 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v172 = v180 
            #endif
#if FABLE_COMPILER_PYTHON
            let v184 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v172 = v184 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v188 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v172 = v188 
            #endif
#else
            let v192 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v172 = v192 
            #endif
            let v195 : std_string_String = _run_target_args'_v172 
            let v201 : string = "fable_library_rust::String_::fromString($0)"
            let v202 : string = Fable.Core.RustInterop.emitRustExpr v195 v201 
            let v205 : string = ".md"
            let v206 : bool = v202.EndsWith (v205, false, null)
            let v209 : bool = v206 = false
            let v216 : bool =
                if v209 then
                    true
                else
                    let v212 : string = ".hangul.md"
                    let v213 : bool = v202.EndsWith (v212, false, null)
                    v213
            if v216 then
                US12_0
            else
                US12_2
    let v221 : string = ""
    let v222 : string = "}"
    let v223 : string = v221 + v222 
    let x = v220 //
    let v224 : _ = x
    let v225 : unit = ()
    (* run_target_args'
    let v226 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v227 : string = $"true; let _fix_closure_v225 = $0"
    let v228 : bool = Fable.Core.RustInterop.emitRustExpr v224 v227 
    let _run_target_args'_v226 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v229 : string = $"true; let _fix_closure_v225 = $0"
    let v230 : bool = Fable.Core.RustInterop.emitRustExpr v224 v229 
    let _run_target_args'_v226 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v231 : string = $"true; let _fix_closure_v225 = $0"
    let v232 : bool = Fable.Core.RustInterop.emitRustExpr v224 v231 
    let _run_target_args'_v226 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v226 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v226 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v226 = false 
    #endif
#else
    let _run_target_args'_v226 = false 
    #endif
    let v233 : bool = _run_target_args'_v226 
    let v235 : string = $"true; _fix_closure_v225 " + v223 + "); " + v221 + " // rust.fix_closure'"
    let v236 : bool = Fable.Core.RustInterop.emitRustExpr () v235 
    let v237 : string = "__future_init"
    let v238 : _ = Fable.Core.RustInterop.emitRustExpr () v237 
    let v239 : string = "v238"
    let v240 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US12>>, Send<Dyn<std_future_Future<US12>>>>>> = Fable.Core.RustInterop.emitRustExpr () v239 
    let v241 : string = "v240.await"
    let v242 : US12 = Fable.Core.RustInterop.emitRustExpr () v241 
    let v251 : async_walkdir_Filtering =
        match v242 with
        | US12_2 -> (* Continue *)
            let v247 : string = "async_walkdir::Filtering::Continue"
            let v248 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v247 
            v248
        | US12_0 -> (* Ignore *)
            let v243 : string = "async_walkdir::Filtering::Ignore"
            let v244 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v243 
            v244
        | US12_1 -> (* IgnoreDir *)
            let v245 : string = "async_walkdir::Filtering::IgnoreDir"
            let v246 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v245 
            v246
    let v252 : string = v221 + v222 
    let x = v251 //
    let v253 : _ = x
    let v254 : unit = ()
    (* run_target_args'
    let v255 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v256 : string = $"true; let _fix_closure_v254 = $0"
    let v257 : bool = Fable.Core.RustInterop.emitRustExpr v253 v256 
    let _run_target_args'_v255 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v258 : string = $"true; let _fix_closure_v254 = $0"
    let v259 : bool = Fable.Core.RustInterop.emitRustExpr v253 v258 
    let _run_target_args'_v255 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v260 : string = $"true; let _fix_closure_v254 = $0"
    let v261 : bool = Fable.Core.RustInterop.emitRustExpr v253 v260 
    let _run_target_args'_v255 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v255 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v255 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v255 = false 
    #endif
#else
    let _run_target_args'_v255 = false 
    #endif
    let v262 : bool = _run_target_args'_v255 
    let v264 : string = $"true; _fix_closure_v254 " + v252 + "); " + v221 + " // rust.fix_closure'"
    let v265 : bool = Fable.Core.RustInterop.emitRustExpr () v264 
    let v266 : string = "__future_init"
    let v267 : _ = Fable.Core.RustInterop.emitRustExpr () v266 
    let v268 : string = "v267"
    let v269 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> = Fable.Core.RustInterop.emitRustExpr () v268 
    v269
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
    let v83 : string = "inline_colorization::color_reset"
    let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v83 
    let v85 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v86 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v49, v77, v84) v85 
    let v87 : string = "fable_library_rust::String_::fromString($0)"
    let v88 : string = Fable.Core.RustInterop.emitRustExpr v86 v87 
    let _run_target_args'_v47 = v88 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v89 : string = "inline_colorization::color_bright_red"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    (* run_target_args'
    let v95 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v96 : string = "&*$0"
    let v97 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v96 
    let _run_target_args'_v95 = v97 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v98 : string = "&*$0"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v98 
    let _run_target_args'_v95 = v99 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v100 : string = "&*$0"
    let v101 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v100 
    let _run_target_args'_v95 = v101 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v103 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v103 
    #endif
#if FABLE_COMPILER_PYTHON
    let v107 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v107 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v111 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v111 
    #endif
#else
    let v115 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v115 
    #endif
    let v118 : Ref<Str> = _run_target_args'_v95 
    let v124 : string = "inline_colorization::color_reset"
    let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v124 
    let v126 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v127 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v90, v118, v125) v126 
    let v128 : string = "fable_library_rust::String_::fromString($0)"
    let v129 : string = Fable.Core.RustInterop.emitRustExpr v127 v128 
    let _run_target_args'_v47 = v129 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v130 : string = "inline_colorization::color_bright_red"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    (* run_target_args'
    let v136 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v137 : string = "&*$0"
    let v138 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v137 
    let _run_target_args'_v136 = v138 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v139 : string = "&*$0"
    let v140 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v139 
    let _run_target_args'_v136 = v140 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v141 : string = "&*$0"
    let v142 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v141 
    let _run_target_args'_v136 = v142 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v144 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v144 
    #endif
#if FABLE_COMPILER_PYTHON
    let v148 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v148 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v152 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v152 
    #endif
#else
    let v156 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v156 
    #endif
    let v159 : Ref<Str> = _run_target_args'_v136 
    let v165 : string = "inline_colorization::color_reset"
    let v166 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v165 
    let v167 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v168 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v131, v159, v166) v167 
    let v169 : string = "fable_library_rust::String_::fromString($0)"
    let v170 : string = Fable.Core.RustInterop.emitRustExpr v168 v169 
    let _run_target_args'_v47 = v170 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v172 : string = "\u001b[91m"
    let v176 : string = method14()
    let v180 : string = v172 + v30 
    let v184 : string = v180 + v176 
    let _run_target_args'_v47 = v184 
    #endif
#if FABLE_COMPILER_PYTHON
    let v188 : string = "\u001b[91m"
    let v192 : string = method14()
    let v196 : string = v188 + v30 
    let v200 : string = v196 + v192 
    let _run_target_args'_v47 = v200 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v204 : string = "\u001b[91m"
    let v208 : string = method14()
    let v212 : string = v204 + v30 
    let v216 : string = v212 + v208 
    let _run_target_args'_v47 = v216 
    #endif
#else
    let v220 : string = "\u001b[91m"
    let v224 : string = method14()
    let v228 : string = v220 + v30 
    let v232 : string = v228 + v224 
    let _run_target_args'_v47 = v232 
    #endif
    let v235 : string = _run_target_args'_v47 
    v235
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
    let v108 : string = $"{v101}"
    let v116 : unit = ()
    let v117 : (unit -> unit) = closure8(v10, v108)
    let v118 : unit = (fun () -> v117 (); v116) ()
    let v126 : string = " }"
    let v127 : string = $"{v126}"
    let v135 : unit = ()
    let v136 : (unit -> unit) = closure8(v10, v127)
    let v137 : unit = (fun () -> v136 (); v135) ()
    let v143 : string = v10.l0
    let v144 : int64 = v0.l0
    let v147 : string = " "
    let v148 : string = v6 + v147 
    let v152 : string = v148 + v7 
    let v157 : string = " #"
    let v158 : string = v152 + v157 
    let v162 : (int64 -> string) = _.ToString()
    let v163 : string = v162 v144
    let v167 : string = v158 + v163 
    let v171 : string = v167 + v147 
    let v176 : string = "documents.run / stream_filter_map"
    let v177 : string = v171 + v176 
    let v182 : string = " / "
    let v183 : string = v177 + v182 
    let v187 : string = v183 + v143 
    method16(v187)
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
    let v221 : US5 =
        match v20 with
        | US13_1(v95) -> (* Error *)
            let v156 : unit = ()
            let v157 : (unit -> unit) = closure33(v95)
            let v158 : unit = (fun () -> v157 (); v156) ()
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
            let v63 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v64 : string = "format!(\"{}\", $0)"
            let v65 : std_string_String = Fable.Core.RustInterop.emitRustExpr v53 v64 
            let _run_target_args'_v63 = v65 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v66 : string = "format!(\"{}\", $0)"
            let v67 : std_string_String = Fable.Core.RustInterop.emitRustExpr v53 v66 
            let _run_target_args'_v63 = v67 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v68 : string = "format!(\"{}\", $0)"
            let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr v53 v68 
            let _run_target_args'_v63 = v69 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v71 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v63 = v71 
            #endif
#if FABLE_COMPILER_PYTHON
            let v75 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v63 = v75 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v79 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v63 = v79 
            #endif
#else
            let v83 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v63 = v83 
            #endif
            let v86 : std_string_String = _run_target_args'_v63 
            let v92 : string = "fable_library_rust::String_::fromString($0)"
            let v93 : string = Fable.Core.RustInterop.emitRustExpr v86 v92 
            US5_0(v93)
    match v221 with
    | US5_1 -> (* None *)
        let v228 : string option = None
        v228
    | US5_0(v222) -> (* Some *)
        let v224 : string option = Some v222 
        v224
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
    let v108 : string = $"{v101}"
    let v116 : unit = ()
    let v117 : (unit -> unit) = closure8(v10, v108)
    let v118 : unit = (fun () -> v117 (); v116) ()
    let v126 : string = " }"
    let v127 : string = $"{v126}"
    let v135 : unit = ()
    let v136 : (unit -> unit) = closure8(v10, v127)
    let v137 : unit = (fun () -> v136 (); v135) ()
    let v143 : string = v10.l0
    let v144 : int64 = v0.l0
    let v147 : string = " "
    let v148 : string = v6 + v147 
    let v152 : string = v148 + v7 
    let v157 : string = " #"
    let v158 : string = v152 + v157 
    let v162 : (int64 -> string) = _.ToString()
    let v163 : string = v162 v144
    let v167 : string = v158 + v163 
    let v171 : string = v167 + v147 
    let v176 : string = "documents.run"
    let v177 : string = v171 + v176 
    let v182 : string = " / "
    let v183 : string = v177 + v182 
    let v187 : string = v183 + v143 
    method16(v187)
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
    let v381 : string = $"{v374}"
    let v389 : unit = ()
    let v390 : (unit -> unit) = closure8(v18, v381)
    let v391 : unit = (fun () -> v390 (); v389) ()
    let v398 : string = $"{v95}"
    let v406 : unit = ()
    let v407 : (unit -> unit) = closure8(v18, v398)
    let v408 : unit = (fun () -> v407 (); v406) ()
    let v416 : string = "environment_variables"
    let v417 : string = $"{v416}"
    let v425 : unit = ()
    let v426 : (unit -> unit) = closure8(v18, v417)
    let v427 : unit = (fun () -> v426 (); v425) ()
    let v434 : string = $"{v59}"
    let v442 : unit = ()
    let v443 : (unit -> unit) = closure8(v18, v434)
    let v444 : unit = (fun () -> v443 (); v442) ()
    let v451 : string = $"%A{v12}"
    let v455 : string = $"{v451}"
    let v463 : unit = ()
    let v464 : (unit -> unit) = closure8(v18, v455)
    let v465 : unit = (fun () -> v464 (); v463) ()
    let v472 : string = $"{v95}"
    let v480 : unit = ()
    let v481 : (unit -> unit) = closure8(v18, v472)
    let v482 : unit = (fun () -> v481 (); v480) ()
    let v490 : string = "on_line"
    let v491 : string = $"{v490}"
    let v499 : unit = ()
    let v500 : (unit -> unit) = closure8(v18, v491)
    let v501 : unit = (fun () -> v500 (); v499) ()
    let v508 : string = $"{v59}"
    let v516 : unit = ()
    let v517 : (unit -> unit) = closure8(v18, v508)
    let v518 : unit = (fun () -> v517 (); v516) ()
    (* run_target_args'
    let v528 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v529 : string = "format!(\"{:#?}\", $0)"
    let v530 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v529 
    let v531 : string = "fable_library_rust::String_::fromString($0)"
    let v532 : string = Fable.Core.RustInterop.emitRustExpr v530 v531 
    let _run_target_args'_v528 = v532 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v533 : string = "format!(\"{:#?}\", $0)"
    let v534 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v533 
    let v535 : string = "fable_library_rust::String_::fromString($0)"
    let v536 : string = Fable.Core.RustInterop.emitRustExpr v534 v535 
    let _run_target_args'_v528 = v536 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v537 : string = "format!(\"{:#?}\", $0)"
    let v538 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v537 
    let v539 : string = "fable_library_rust::String_::fromString($0)"
    let v540 : string = Fable.Core.RustInterop.emitRustExpr v538 v539 
    let _run_target_args'_v528 = v540 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v542 : string = $"%A{v13}"
    let _run_target_args'_v528 = v542 
    #endif
#if FABLE_COMPILER_PYTHON
    let v546 : string = $"%A{v13}"
    let _run_target_args'_v528 = v546 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v550 : string = $"%A{v13}"
    let _run_target_args'_v528 = v550 
    #endif
#else
    let v554 : string = $"%A{v13}"
    let _run_target_args'_v528 = v554 
    #endif
    let v557 : string = _run_target_args'_v528 
    let v564 : string = $"{v557}"
    let v572 : unit = ()
    let v573 : (unit -> unit) = closure8(v18, v564)
    let v574 : unit = (fun () -> v573 (); v572) ()
    let v581 : string = $"{v95}"
    let v589 : unit = ()
    let v590 : (unit -> unit) = closure8(v18, v581)
    let v591 : unit = (fun () -> v590 (); v589) ()
    let v599 : string = "stdin"
    let v600 : string = $"{v599}"
    let v608 : unit = ()
    let v609 : (unit -> unit) = closure8(v18, v600)
    let v610 : unit = (fun () -> v609 (); v608) ()
    let v617 : string = $"{v59}"
    let v625 : unit = ()
    let v626 : (unit -> unit) = closure8(v18, v617)
    let v627 : unit = (fun () -> v626 (); v625) ()
    (* run_target_args'
    let v637 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v638 : string = "format!(\"{:#?}\", $0)"
    let v639 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v638 
    let v640 : string = "fable_library_rust::String_::fromString($0)"
    let v641 : string = Fable.Core.RustInterop.emitRustExpr v639 v640 
    let _run_target_args'_v637 = v641 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v642 : string = "format!(\"{:#?}\", $0)"
    let v643 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v642 
    let v644 : string = "fable_library_rust::String_::fromString($0)"
    let v645 : string = Fable.Core.RustInterop.emitRustExpr v643 v644 
    let _run_target_args'_v637 = v645 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v646 : string = "format!(\"{:#?}\", $0)"
    let v647 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v646 
    let v648 : string = "fable_library_rust::String_::fromString($0)"
    let v649 : string = Fable.Core.RustInterop.emitRustExpr v647 v648 
    let _run_target_args'_v637 = v649 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v651 : string = $"%A{v14}"
    let _run_target_args'_v637 = v651 
    #endif
#if FABLE_COMPILER_PYTHON
    let v655 : string = $"%A{v14}"
    let _run_target_args'_v637 = v655 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v659 : string = $"%A{v14}"
    let _run_target_args'_v637 = v659 
    #endif
#else
    let v663 : string = $"%A{v14}"
    let _run_target_args'_v637 = v663 
    #endif
    let v666 : string = _run_target_args'_v637 
    let v673 : string = $"{v666}"
    let v681 : unit = ()
    let v682 : (unit -> unit) = closure8(v18, v673)
    let v683 : unit = (fun () -> v682 (); v681) ()
    let v690 : string = $"{v95}"
    let v698 : unit = ()
    let v699 : (unit -> unit) = closure8(v18, v690)
    let v700 : unit = (fun () -> v699 (); v698) ()
    let v708 : string = "trace"
    let v709 : string = $"{v708}"
    let v717 : unit = ()
    let v718 : (unit -> unit) = closure8(v18, v709)
    let v719 : unit = (fun () -> v718 (); v717) ()
    let v726 : string = $"{v59}"
    let v734 : unit = ()
    let v735 : (unit -> unit) = closure8(v18, v726)
    let v736 : unit = (fun () -> v735 (); v734) ()
    let v744 : string =
        if v15 then
            let v742 : string = "true"
            v742
        else
            let v743 : string = "false"
            v743
    let v746 : string = $"{v744}"
    let v754 : unit = ()
    let v755 : (unit -> unit) = closure8(v18, v746)
    let v756 : unit = (fun () -> v755 (); v754) ()
    let v763 : string = $"{v95}"
    let v771 : unit = ()
    let v772 : (unit -> unit) = closure8(v18, v763)
    let v773 : unit = (fun () -> v772 (); v771) ()
    let v781 : string = "working_directory"
    let v782 : string = $"{v781}"
    let v790 : unit = ()
    let v791 : (unit -> unit) = closure8(v18, v782)
    let v792 : unit = (fun () -> v791 (); v790) ()
    let v799 : string = $"{v59}"
    let v807 : unit = ()
    let v808 : (unit -> unit) = closure8(v18, v799)
    let v809 : unit = (fun () -> v808 (); v807) ()
    (* run_target_args'
    let v819 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v820 : string = "format!(\"{:#?}\", $0)"
    let v821 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v820 
    let v822 : string = "fable_library_rust::String_::fromString($0)"
    let v823 : string = Fable.Core.RustInterop.emitRustExpr v821 v822 
    let _run_target_args'_v819 = v823 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v824 : string = "format!(\"{:#?}\", $0)"
    let v825 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v824 
    let v826 : string = "fable_library_rust::String_::fromString($0)"
    let v827 : string = Fable.Core.RustInterop.emitRustExpr v825 v826 
    let _run_target_args'_v819 = v827 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v828 : string = "format!(\"{:#?}\", $0)"
    let v829 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v828 
    let v830 : string = "fable_library_rust::String_::fromString($0)"
    let v831 : string = Fable.Core.RustInterop.emitRustExpr v829 v830 
    let _run_target_args'_v819 = v831 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v833 : string = $"%A{v16}"
    let _run_target_args'_v819 = v833 
    #endif
#if FABLE_COMPILER_PYTHON
    let v837 : string = $"%A{v16}"
    let _run_target_args'_v819 = v837 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v841 : string = $"%A{v16}"
    let _run_target_args'_v819 = v841 
    #endif
#else
    let v845 : string = $"%A{v16}"
    let _run_target_args'_v819 = v845 
    #endif
    let v848 : string = _run_target_args'_v819 
    let v855 : string = $"{v848}"
    let v863 : unit = ()
    let v864 : (unit -> unit) = closure8(v18, v855)
    let v865 : unit = (fun () -> v864 (); v863) ()
    let v873 : string = " }"
    let v874 : string = $"{v873}"
    let v882 : unit = ()
    let v883 : (unit -> unit) = closure8(v18, v874)
    let v884 : unit = (fun () -> v883 (); v882) ()
    let v891 : string = $"{v873}"
    let v899 : unit = ()
    let v900 : (unit -> unit) = closure8(v18, v891)
    let v901 : unit = (fun () -> v900 (); v899) ()
    let v907 : string = v18.l0
    let v908 : int64 = v0.l0
    let v911 : string = " "
    let v912 : string = v6 + v911 
    let v916 : string = v912 + v7 
    let v921 : string = " #"
    let v922 : string = v916 + v921 
    let v926 : (int64 -> string) = _.ToString()
    let v927 : string = v926 v908
    let v931 : string = v922 + v927 
    let v935 : string = v931 + v911 
    let v940 : string = "runtime.execute_with_options"
    let v941 : string = v935 + v940 
    let v946 : string = " / "
    let v947 : string = v941 + v946 
    let v951 : string = v947 + v907 
    method16(v951)
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
    let v117 : string = $"{v110}"
    let v125 : unit = ()
    let v126 : (unit -> unit) = closure8(v19, v117)
    let v127 : unit = (fun () -> v126 (); v125) ()
    let v135 : string = "; "
    let v136 : string = $"{v135}"
    let v144 : unit = ()
    let v145 : (unit -> unit) = closure8(v19, v136)
    let v146 : unit = (fun () -> v145 (); v144) ()
    let v154 : string = "file_name"
    let v155 : string = $"{v154}"
    let v163 : unit = ()
    let v164 : (unit -> unit) = closure8(v19, v155)
    let v165 : unit = (fun () -> v164 (); v163) ()
    let v172 : string = $"{v60}"
    let v180 : unit = ()
    let v181 : (unit -> unit) = closure8(v19, v172)
    let v182 : unit = (fun () -> v181 (); v180) ()
    let v189 : string = $"{v9}"
    let v197 : unit = ()
    let v198 : (unit -> unit) = closure8(v19, v189)
    let v199 : unit = (fun () -> v198 (); v197) ()
    let v206 : string = $"{v135}"
    let v214 : unit = ()
    let v215 : (unit -> unit) = closure8(v19, v206)
    let v216 : unit = (fun () -> v215 (); v214) ()
    let v224 : string = "arguments"
    let v225 : string = $"{v224}"
    let v233 : unit = ()
    let v234 : (unit -> unit) = closure8(v19, v225)
    let v235 : unit = (fun () -> v234 (); v233) ()
    let v242 : string = $"{v60}"
    let v250 : unit = ()
    let v251 : (unit -> unit) = closure8(v19, v242)
    let v252 : unit = (fun () -> v251 (); v250) ()
    let v259 : string = $"{v10}"
    let v267 : unit = ()
    let v268 : (unit -> unit) = closure8(v19, v259)
    let v269 : unit = (fun () -> v268 (); v267) ()
    let v276 : string = $"{v135}"
    let v284 : unit = ()
    let v285 : (unit -> unit) = closure8(v19, v276)
    let v286 : unit = (fun () -> v285 (); v284) ()
    let v294 : string = "options"
    let v295 : string = $"{v294}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure8(v19, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v312 : string = $"{v60}"
    let v320 : unit = ()
    let v321 : (unit -> unit) = closure8(v19, v312)
    let v322 : unit = (fun () -> v321 (); v320) ()
    let v329 : string = $"{v22}"
    let v337 : unit = ()
    let v338 : (unit -> unit) = closure8(v19, v329)
    let v339 : unit = (fun () -> v338 (); v337) ()
    let v347 : string = "command"
    let v348 : string = $"{v347}"
    let v356 : unit = ()
    let v357 : (unit -> unit) = closure8(v19, v348)
    let v358 : unit = (fun () -> v357 (); v356) ()
    let v365 : string = $"{v60}"
    let v373 : unit = ()
    let v374 : (unit -> unit) = closure8(v19, v365)
    let v375 : unit = (fun () -> v374 (); v373) ()
    let v382 : string = $"{v11}"
    let v390 : unit = ()
    let v391 : (unit -> unit) = closure8(v19, v382)
    let v392 : unit = (fun () -> v391 (); v390) ()
    let v399 : string = $"{v135}"
    let v407 : unit = ()
    let v408 : (unit -> unit) = closure8(v19, v399)
    let v409 : unit = (fun () -> v408 (); v407) ()
    let v417 : string = "cancellation_token"
    let v418 : string = $"{v417}"
    let v426 : unit = ()
    let v427 : (unit -> unit) = closure8(v19, v418)
    let v428 : unit = (fun () -> v427 (); v426) ()
    let v435 : string = $"{v60}"
    let v443 : unit = ()
    let v444 : (unit -> unit) = closure8(v19, v435)
    let v445 : unit = (fun () -> v444 (); v443) ()
    (* run_target_args'
    let v455 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v456 : string = "format!(\"{:#?}\", $0)"
    let v457 : std_string_String = Fable.Core.RustInterop.emitRustExpr v12 v456 
    let v458 : string = "fable_library_rust::String_::fromString($0)"
    let v459 : string = Fable.Core.RustInterop.emitRustExpr v457 v458 
    let _run_target_args'_v455 = v459 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v460 : string = "format!(\"{:#?}\", $0)"
    let v461 : std_string_String = Fable.Core.RustInterop.emitRustExpr v12 v460 
    let v462 : string = "fable_library_rust::String_::fromString($0)"
    let v463 : string = Fable.Core.RustInterop.emitRustExpr v461 v462 
    let _run_target_args'_v455 = v463 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v464 : string = "format!(\"{:#?}\", $0)"
    let v465 : std_string_String = Fable.Core.RustInterop.emitRustExpr v12 v464 
    let v466 : string = "fable_library_rust::String_::fromString($0)"
    let v467 : string = Fable.Core.RustInterop.emitRustExpr v465 v466 
    let _run_target_args'_v455 = v467 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v469 : string = $"%A{v12}"
    let _run_target_args'_v455 = v469 
    #endif
#if FABLE_COMPILER_PYTHON
    let v473 : string = $"%A{v12}"
    let _run_target_args'_v455 = v473 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v477 : string = $"%A{v12}"
    let _run_target_args'_v455 = v477 
    #endif
#else
    let v481 : string = $"%A{v12}"
    let _run_target_args'_v455 = v481 
    #endif
    let v484 : string = _run_target_args'_v455 
    let v491 : string = $"{v484}"
    let v499 : unit = ()
    let v500 : (unit -> unit) = closure8(v19, v491)
    let v501 : unit = (fun () -> v500 (); v499) ()
    let v508 : string = $"{v135}"
    let v516 : unit = ()
    let v517 : (unit -> unit) = closure8(v19, v508)
    let v518 : unit = (fun () -> v517 (); v516) ()
    let v526 : string = "environment_variables"
    let v527 : string = $"{v526}"
    let v535 : unit = ()
    let v536 : (unit -> unit) = closure8(v19, v527)
    let v537 : unit = (fun () -> v536 (); v535) ()
    let v544 : string = $"{v60}"
    let v552 : unit = ()
    let v553 : (unit -> unit) = closure8(v19, v544)
    let v554 : unit = (fun () -> v553 (); v552) ()
    let v561 : string = $"%A{v13}"
    let v565 : string = $"{v561}"
    let v573 : unit = ()
    let v574 : (unit -> unit) = closure8(v19, v565)
    let v575 : unit = (fun () -> v574 (); v573) ()
    let v582 : string = $"{v135}"
    let v590 : unit = ()
    let v591 : (unit -> unit) = closure8(v19, v582)
    let v592 : unit = (fun () -> v591 (); v590) ()
    let v600 : string = "on_line"
    let v601 : string = $"{v600}"
    let v609 : unit = ()
    let v610 : (unit -> unit) = closure8(v19, v601)
    let v611 : unit = (fun () -> v610 (); v609) ()
    let v618 : string = $"{v60}"
    let v626 : unit = ()
    let v627 : (unit -> unit) = closure8(v19, v618)
    let v628 : unit = (fun () -> v627 (); v626) ()
    (* run_target_args'
    let v638 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v639 : string = "format!(\"{:#?}\", $0)"
    let v640 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v639 
    let v641 : string = "fable_library_rust::String_::fromString($0)"
    let v642 : string = Fable.Core.RustInterop.emitRustExpr v640 v641 
    let _run_target_args'_v638 = v642 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v643 : string = "format!(\"{:#?}\", $0)"
    let v644 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v643 
    let v645 : string = "fable_library_rust::String_::fromString($0)"
    let v646 : string = Fable.Core.RustInterop.emitRustExpr v644 v645 
    let _run_target_args'_v638 = v646 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v647 : string = "format!(\"{:#?}\", $0)"
    let v648 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v647 
    let v649 : string = "fable_library_rust::String_::fromString($0)"
    let v650 : string = Fable.Core.RustInterop.emitRustExpr v648 v649 
    let _run_target_args'_v638 = v650 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v652 : string = $"%A{v14}"
    let _run_target_args'_v638 = v652 
    #endif
#if FABLE_COMPILER_PYTHON
    let v656 : string = $"%A{v14}"
    let _run_target_args'_v638 = v656 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v660 : string = $"%A{v14}"
    let _run_target_args'_v638 = v660 
    #endif
#else
    let v664 : string = $"%A{v14}"
    let _run_target_args'_v638 = v664 
    #endif
    let v667 : string = _run_target_args'_v638 
    let v674 : string = $"{v667}"
    let v682 : unit = ()
    let v683 : (unit -> unit) = closure8(v19, v674)
    let v684 : unit = (fun () -> v683 (); v682) ()
    let v691 : string = $"{v135}"
    let v699 : unit = ()
    let v700 : (unit -> unit) = closure8(v19, v691)
    let v701 : unit = (fun () -> v700 (); v699) ()
    let v709 : string = "stdin"
    let v710 : string = $"{v709}"
    let v718 : unit = ()
    let v719 : (unit -> unit) = closure8(v19, v710)
    let v720 : unit = (fun () -> v719 (); v718) ()
    let v727 : string = $"{v60}"
    let v735 : unit = ()
    let v736 : (unit -> unit) = closure8(v19, v727)
    let v737 : unit = (fun () -> v736 (); v735) ()
    (* run_target_args'
    let v747 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v748 : string = "format!(\"{:#?}\", $0)"
    let v749 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v748 
    let v750 : string = "fable_library_rust::String_::fromString($0)"
    let v751 : string = Fable.Core.RustInterop.emitRustExpr v749 v750 
    let _run_target_args'_v747 = v751 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v752 : string = "format!(\"{:#?}\", $0)"
    let v753 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v752 
    let v754 : string = "fable_library_rust::String_::fromString($0)"
    let v755 : string = Fable.Core.RustInterop.emitRustExpr v753 v754 
    let _run_target_args'_v747 = v755 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v756 : string = "format!(\"{:#?}\", $0)"
    let v757 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v756 
    let v758 : string = "fable_library_rust::String_::fromString($0)"
    let v759 : string = Fable.Core.RustInterop.emitRustExpr v757 v758 
    let _run_target_args'_v747 = v759 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v761 : string = $"%A{v15}"
    let _run_target_args'_v747 = v761 
    #endif
#if FABLE_COMPILER_PYTHON
    let v765 : string = $"%A{v15}"
    let _run_target_args'_v747 = v765 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v769 : string = $"%A{v15}"
    let _run_target_args'_v747 = v769 
    #endif
#else
    let v773 : string = $"%A{v15}"
    let _run_target_args'_v747 = v773 
    #endif
    let v776 : string = _run_target_args'_v747 
    let v783 : string = $"{v776}"
    let v791 : unit = ()
    let v792 : (unit -> unit) = closure8(v19, v783)
    let v793 : unit = (fun () -> v792 (); v791) ()
    let v800 : string = $"{v135}"
    let v808 : unit = ()
    let v809 : (unit -> unit) = closure8(v19, v800)
    let v810 : unit = (fun () -> v809 (); v808) ()
    let v818 : string = "trace"
    let v819 : string = $"{v818}"
    let v827 : unit = ()
    let v828 : (unit -> unit) = closure8(v19, v819)
    let v829 : unit = (fun () -> v828 (); v827) ()
    let v836 : string = $"{v60}"
    let v844 : unit = ()
    let v845 : (unit -> unit) = closure8(v19, v836)
    let v846 : unit = (fun () -> v845 (); v844) ()
    let v854 : string =
        if v16 then
            let v852 : string = "true"
            v852
        else
            let v853 : string = "false"
            v853
    let v856 : string = $"{v854}"
    let v864 : unit = ()
    let v865 : (unit -> unit) = closure8(v19, v856)
    let v866 : unit = (fun () -> v865 (); v864) ()
    let v873 : string = $"{v135}"
    let v881 : unit = ()
    let v882 : (unit -> unit) = closure8(v19, v873)
    let v883 : unit = (fun () -> v882 (); v881) ()
    let v891 : string = "working_directory"
    let v892 : string = $"{v891}"
    let v900 : unit = ()
    let v901 : (unit -> unit) = closure8(v19, v892)
    let v902 : unit = (fun () -> v901 (); v900) ()
    let v909 : string = $"{v60}"
    let v917 : unit = ()
    let v918 : (unit -> unit) = closure8(v19, v909)
    let v919 : unit = (fun () -> v918 (); v917) ()
    (* run_target_args'
    let v929 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v930 : string = "format!(\"{:#?}\", $0)"
    let v931 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v930 
    let v932 : string = "fable_library_rust::String_::fromString($0)"
    let v933 : string = Fable.Core.RustInterop.emitRustExpr v931 v932 
    let _run_target_args'_v929 = v933 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v934 : string = "format!(\"{:#?}\", $0)"
    let v935 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v934 
    let v936 : string = "fable_library_rust::String_::fromString($0)"
    let v937 : string = Fable.Core.RustInterop.emitRustExpr v935 v936 
    let _run_target_args'_v929 = v937 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v938 : string = "format!(\"{:#?}\", $0)"
    let v939 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v938 
    let v940 : string = "fable_library_rust::String_::fromString($0)"
    let v941 : string = Fable.Core.RustInterop.emitRustExpr v939 v940 
    let _run_target_args'_v929 = v941 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v943 : string = $"%A{v17}"
    let _run_target_args'_v929 = v943 
    #endif
#if FABLE_COMPILER_PYTHON
    let v947 : string = $"%A{v17}"
    let _run_target_args'_v929 = v947 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v951 : string = $"%A{v17}"
    let _run_target_args'_v929 = v951 
    #endif
#else
    let v955 : string = $"%A{v17}"
    let _run_target_args'_v929 = v955 
    #endif
    let v958 : string = _run_target_args'_v929 
    let v965 : string = $"{v958}"
    let v973 : unit = ()
    let v974 : (unit -> unit) = closure8(v19, v965)
    let v975 : unit = (fun () -> v974 (); v973) ()
    let v983 : string = " }"
    let v984 : string = $"{v983}"
    let v992 : unit = ()
    let v993 : (unit -> unit) = closure8(v19, v984)
    let v994 : unit = (fun () -> v993 (); v992) ()
    let v1001 : string = $"{v983}"
    let v1009 : unit = ()
    let v1010 : (unit -> unit) = closure8(v19, v1001)
    let v1011 : unit = (fun () -> v1010 (); v1009) ()
    let v1017 : string = v19.l0
    let v1018 : int64 = v0.l0
    let v1021 : string = " "
    let v1022 : string = v6 + v1021 
    let v1026 : string = v1022 + v7 
    let v1031 : string = " #"
    let v1032 : string = v1026 + v1031 
    let v1036 : (int64 -> string) = _.ToString()
    let v1037 : string = v1036 v1018
    let v1041 : string = v1032 + v1037 
    let v1045 : string = v1041 + v1021 
    let v1050 : string = "runtime.execute_with_options / child error"
    let v1051 : string = v1045 + v1050 
    let v1056 : string = " / "
    let v1057 : string = v1051 + v1056 
    let v1061 : string = v1057 + v1017 
    method16(v1061)
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
    let v184 : string = $"{v177}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure8(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v202 : string = " }"
    let v203 : string = $"{v202}"
    let v211 : unit = ()
    let v212 : (unit -> unit) = closure8(v11, v203)
    let v213 : unit = (fun () -> v212 (); v211) ()
    let v219 : string = v11.l0
    let v220 : int64 = v0.l0
    let v223 : string = " "
    let v224 : string = v6 + v223 
    let v228 : string = v224 + v7 
    let v233 : string = " #"
    let v234 : string = v228 + v233 
    let v238 : (int64 -> string) = _.ToString()
    let v239 : string = v238 v220
    let v243 : string = v234 + v239 
    let v247 : string = v243 + v223 
    let v252 : string = "runtime.stdio_line"
    let v253 : string = v247 + v252 
    let v258 : string = " / "
    let v259 : string = v253 + v258 
    let v263 : string = v259 + v219 
    method16(v263)
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
    let v83 : string = "inline_colorization::color_reset"
    let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v83 
    let v85 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v86 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v49, v77, v84) v85 
    let v87 : string = "fable_library_rust::String_::fromString($0)"
    let v88 : string = Fable.Core.RustInterop.emitRustExpr v86 v87 
    let _run_target_args'_v47 = v88 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v89 : string = "inline_colorization::color_bright_black"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    (* run_target_args'
    let v95 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v96 : string = "&*$0"
    let v97 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v96 
    let _run_target_args'_v95 = v97 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v98 : string = "&*$0"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v98 
    let _run_target_args'_v95 = v99 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v100 : string = "&*$0"
    let v101 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v100 
    let _run_target_args'_v95 = v101 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v103 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v103 
    #endif
#if FABLE_COMPILER_PYTHON
    let v107 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v107 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v111 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v111 
    #endif
#else
    let v115 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v115 
    #endif
    let v118 : Ref<Str> = _run_target_args'_v95 
    let v124 : string = "inline_colorization::color_reset"
    let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v124 
    let v126 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v127 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v90, v118, v125) v126 
    let v128 : string = "fable_library_rust::String_::fromString($0)"
    let v129 : string = Fable.Core.RustInterop.emitRustExpr v127 v128 
    let _run_target_args'_v47 = v129 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v130 : string = "inline_colorization::color_bright_black"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    (* run_target_args'
    let v136 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v137 : string = "&*$0"
    let v138 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v137 
    let _run_target_args'_v136 = v138 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v139 : string = "&*$0"
    let v140 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v139 
    let _run_target_args'_v136 = v140 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v141 : string = "&*$0"
    let v142 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v141 
    let _run_target_args'_v136 = v142 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v144 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v144 
    #endif
#if FABLE_COMPILER_PYTHON
    let v148 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v148 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v152 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v152 
    #endif
#else
    let v156 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v156 
    #endif
    let v159 : Ref<Str> = _run_target_args'_v136 
    let v165 : string = "inline_colorization::color_reset"
    let v166 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v165 
    let v167 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v168 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v131, v159, v166) v167 
    let v169 : string = "fable_library_rust::String_::fromString($0)"
    let v170 : string = Fable.Core.RustInterop.emitRustExpr v168 v169 
    let _run_target_args'_v47 = v170 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v172 : string = "\u001b[90m"
    let v176 : string = method14()
    let v180 : string = v172 + v30 
    let v184 : string = v180 + v176 
    let _run_target_args'_v47 = v184 
    #endif
#if FABLE_COMPILER_PYTHON
    let v188 : string = "\u001b[90m"
    let v192 : string = method14()
    let v196 : string = v188 + v30 
    let v200 : string = v196 + v192 
    let _run_target_args'_v47 = v200 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v204 : string = "\u001b[90m"
    let v208 : string = method14()
    let v212 : string = v204 + v30 
    let v216 : string = v212 + v208 
    let _run_target_args'_v47 = v216 
    #endif
#else
    let v220 : string = "\u001b[90m"
    let v224 : string = method14()
    let v228 : string = v220 + v30 
    let v232 : string = v228 + v224 
    let _run_target_args'_v47 = v232 
    #endif
    let v235 : string = _run_target_args'_v47 
    v235
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
    let v117 : string = $"{v110}"
    let v125 : unit = ()
    let v126 : (unit -> unit) = closure8(v19, v117)
    let v127 : unit = (fun () -> v126 (); v125) ()
    let v135 : string = "; "
    let v136 : string = $"{v135}"
    let v144 : unit = ()
    let v145 : (unit -> unit) = closure8(v19, v136)
    let v146 : unit = (fun () -> v145 (); v144) ()
    let v154 : string = "file_name"
    let v155 : string = $"{v154}"
    let v163 : unit = ()
    let v164 : (unit -> unit) = closure8(v19, v155)
    let v165 : unit = (fun () -> v164 (); v163) ()
    let v172 : string = $"{v60}"
    let v180 : unit = ()
    let v181 : (unit -> unit) = closure8(v19, v172)
    let v182 : unit = (fun () -> v181 (); v180) ()
    let v189 : string = $"{v9}"
    let v197 : unit = ()
    let v198 : (unit -> unit) = closure8(v19, v189)
    let v199 : unit = (fun () -> v198 (); v197) ()
    let v206 : string = $"{v135}"
    let v214 : unit = ()
    let v215 : (unit -> unit) = closure8(v19, v206)
    let v216 : unit = (fun () -> v215 (); v214) ()
    let v224 : string = "arguments"
    let v225 : string = $"{v224}"
    let v233 : unit = ()
    let v234 : (unit -> unit) = closure8(v19, v225)
    let v235 : unit = (fun () -> v234 (); v233) ()
    let v242 : string = $"{v60}"
    let v250 : unit = ()
    let v251 : (unit -> unit) = closure8(v19, v242)
    let v252 : unit = (fun () -> v251 (); v250) ()
    let v259 : string = $"{v10}"
    let v267 : unit = ()
    let v268 : (unit -> unit) = closure8(v19, v259)
    let v269 : unit = (fun () -> v268 (); v267) ()
    let v276 : string = $"{v135}"
    let v284 : unit = ()
    let v285 : (unit -> unit) = closure8(v19, v276)
    let v286 : unit = (fun () -> v285 (); v284) ()
    let v294 : string = "options"
    let v295 : string = $"{v294}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure8(v19, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v312 : string = $"{v60}"
    let v320 : unit = ()
    let v321 : (unit -> unit) = closure8(v19, v312)
    let v322 : unit = (fun () -> v321 (); v320) ()
    let v329 : string = $"{v22}"
    let v337 : unit = ()
    let v338 : (unit -> unit) = closure8(v19, v329)
    let v339 : unit = (fun () -> v338 (); v337) ()
    let v347 : string = "command"
    let v348 : string = $"{v347}"
    let v356 : unit = ()
    let v357 : (unit -> unit) = closure8(v19, v348)
    let v358 : unit = (fun () -> v357 (); v356) ()
    let v365 : string = $"{v60}"
    let v373 : unit = ()
    let v374 : (unit -> unit) = closure8(v19, v365)
    let v375 : unit = (fun () -> v374 (); v373) ()
    let v382 : string = $"{v11}"
    let v390 : unit = ()
    let v391 : (unit -> unit) = closure8(v19, v382)
    let v392 : unit = (fun () -> v391 (); v390) ()
    let v399 : string = $"{v135}"
    let v407 : unit = ()
    let v408 : (unit -> unit) = closure8(v19, v399)
    let v409 : unit = (fun () -> v408 (); v407) ()
    let v417 : string = "cancellation_token"
    let v418 : string = $"{v417}"
    let v426 : unit = ()
    let v427 : (unit -> unit) = closure8(v19, v418)
    let v428 : unit = (fun () -> v427 (); v426) ()
    let v435 : string = $"{v60}"
    let v443 : unit = ()
    let v444 : (unit -> unit) = closure8(v19, v435)
    let v445 : unit = (fun () -> v444 (); v443) ()
    (* run_target_args'
    let v455 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v456 : string = "format!(\"{:#?}\", $0)"
    let v457 : std_string_String = Fable.Core.RustInterop.emitRustExpr v12 v456 
    let v458 : string = "fable_library_rust::String_::fromString($0)"
    let v459 : string = Fable.Core.RustInterop.emitRustExpr v457 v458 
    let _run_target_args'_v455 = v459 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v460 : string = "format!(\"{:#?}\", $0)"
    let v461 : std_string_String = Fable.Core.RustInterop.emitRustExpr v12 v460 
    let v462 : string = "fable_library_rust::String_::fromString($0)"
    let v463 : string = Fable.Core.RustInterop.emitRustExpr v461 v462 
    let _run_target_args'_v455 = v463 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v464 : string = "format!(\"{:#?}\", $0)"
    let v465 : std_string_String = Fable.Core.RustInterop.emitRustExpr v12 v464 
    let v466 : string = "fable_library_rust::String_::fromString($0)"
    let v467 : string = Fable.Core.RustInterop.emitRustExpr v465 v466 
    let _run_target_args'_v455 = v467 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v469 : string = $"%A{v12}"
    let _run_target_args'_v455 = v469 
    #endif
#if FABLE_COMPILER_PYTHON
    let v473 : string = $"%A{v12}"
    let _run_target_args'_v455 = v473 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v477 : string = $"%A{v12}"
    let _run_target_args'_v455 = v477 
    #endif
#else
    let v481 : string = $"%A{v12}"
    let _run_target_args'_v455 = v481 
    #endif
    let v484 : string = _run_target_args'_v455 
    let v491 : string = $"{v484}"
    let v499 : unit = ()
    let v500 : (unit -> unit) = closure8(v19, v491)
    let v501 : unit = (fun () -> v500 (); v499) ()
    let v508 : string = $"{v135}"
    let v516 : unit = ()
    let v517 : (unit -> unit) = closure8(v19, v508)
    let v518 : unit = (fun () -> v517 (); v516) ()
    let v526 : string = "environment_variables"
    let v527 : string = $"{v526}"
    let v535 : unit = ()
    let v536 : (unit -> unit) = closure8(v19, v527)
    let v537 : unit = (fun () -> v536 (); v535) ()
    let v544 : string = $"{v60}"
    let v552 : unit = ()
    let v553 : (unit -> unit) = closure8(v19, v544)
    let v554 : unit = (fun () -> v553 (); v552) ()
    let v561 : string = $"%A{v13}"
    let v565 : string = $"{v561}"
    let v573 : unit = ()
    let v574 : (unit -> unit) = closure8(v19, v565)
    let v575 : unit = (fun () -> v574 (); v573) ()
    let v582 : string = $"{v135}"
    let v590 : unit = ()
    let v591 : (unit -> unit) = closure8(v19, v582)
    let v592 : unit = (fun () -> v591 (); v590) ()
    let v600 : string = "on_line"
    let v601 : string = $"{v600}"
    let v609 : unit = ()
    let v610 : (unit -> unit) = closure8(v19, v601)
    let v611 : unit = (fun () -> v610 (); v609) ()
    let v618 : string = $"{v60}"
    let v626 : unit = ()
    let v627 : (unit -> unit) = closure8(v19, v618)
    let v628 : unit = (fun () -> v627 (); v626) ()
    (* run_target_args'
    let v638 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v639 : string = "format!(\"{:#?}\", $0)"
    let v640 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v639 
    let v641 : string = "fable_library_rust::String_::fromString($0)"
    let v642 : string = Fable.Core.RustInterop.emitRustExpr v640 v641 
    let _run_target_args'_v638 = v642 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v643 : string = "format!(\"{:#?}\", $0)"
    let v644 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v643 
    let v645 : string = "fable_library_rust::String_::fromString($0)"
    let v646 : string = Fable.Core.RustInterop.emitRustExpr v644 v645 
    let _run_target_args'_v638 = v646 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v647 : string = "format!(\"{:#?}\", $0)"
    let v648 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v647 
    let v649 : string = "fable_library_rust::String_::fromString($0)"
    let v650 : string = Fable.Core.RustInterop.emitRustExpr v648 v649 
    let _run_target_args'_v638 = v650 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v652 : string = $"%A{v14}"
    let _run_target_args'_v638 = v652 
    #endif
#if FABLE_COMPILER_PYTHON
    let v656 : string = $"%A{v14}"
    let _run_target_args'_v638 = v656 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v660 : string = $"%A{v14}"
    let _run_target_args'_v638 = v660 
    #endif
#else
    let v664 : string = $"%A{v14}"
    let _run_target_args'_v638 = v664 
    #endif
    let v667 : string = _run_target_args'_v638 
    let v674 : string = $"{v667}"
    let v682 : unit = ()
    let v683 : (unit -> unit) = closure8(v19, v674)
    let v684 : unit = (fun () -> v683 (); v682) ()
    let v691 : string = $"{v135}"
    let v699 : unit = ()
    let v700 : (unit -> unit) = closure8(v19, v691)
    let v701 : unit = (fun () -> v700 (); v699) ()
    let v709 : string = "stdin"
    let v710 : string = $"{v709}"
    let v718 : unit = ()
    let v719 : (unit -> unit) = closure8(v19, v710)
    let v720 : unit = (fun () -> v719 (); v718) ()
    let v727 : string = $"{v60}"
    let v735 : unit = ()
    let v736 : (unit -> unit) = closure8(v19, v727)
    let v737 : unit = (fun () -> v736 (); v735) ()
    (* run_target_args'
    let v747 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v748 : string = "format!(\"{:#?}\", $0)"
    let v749 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v748 
    let v750 : string = "fable_library_rust::String_::fromString($0)"
    let v751 : string = Fable.Core.RustInterop.emitRustExpr v749 v750 
    let _run_target_args'_v747 = v751 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v752 : string = "format!(\"{:#?}\", $0)"
    let v753 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v752 
    let v754 : string = "fable_library_rust::String_::fromString($0)"
    let v755 : string = Fable.Core.RustInterop.emitRustExpr v753 v754 
    let _run_target_args'_v747 = v755 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v756 : string = "format!(\"{:#?}\", $0)"
    let v757 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v756 
    let v758 : string = "fable_library_rust::String_::fromString($0)"
    let v759 : string = Fable.Core.RustInterop.emitRustExpr v757 v758 
    let _run_target_args'_v747 = v759 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v761 : string = $"%A{v15}"
    let _run_target_args'_v747 = v761 
    #endif
#if FABLE_COMPILER_PYTHON
    let v765 : string = $"%A{v15}"
    let _run_target_args'_v747 = v765 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v769 : string = $"%A{v15}"
    let _run_target_args'_v747 = v769 
    #endif
#else
    let v773 : string = $"%A{v15}"
    let _run_target_args'_v747 = v773 
    #endif
    let v776 : string = _run_target_args'_v747 
    let v783 : string = $"{v776}"
    let v791 : unit = ()
    let v792 : (unit -> unit) = closure8(v19, v783)
    let v793 : unit = (fun () -> v792 (); v791) ()
    let v800 : string = $"{v135}"
    let v808 : unit = ()
    let v809 : (unit -> unit) = closure8(v19, v800)
    let v810 : unit = (fun () -> v809 (); v808) ()
    let v818 : string = "trace"
    let v819 : string = $"{v818}"
    let v827 : unit = ()
    let v828 : (unit -> unit) = closure8(v19, v819)
    let v829 : unit = (fun () -> v828 (); v827) ()
    let v836 : string = $"{v60}"
    let v844 : unit = ()
    let v845 : (unit -> unit) = closure8(v19, v836)
    let v846 : unit = (fun () -> v845 (); v844) ()
    let v854 : string =
        if v16 then
            let v852 : string = "true"
            v852
        else
            let v853 : string = "false"
            v853
    let v856 : string = $"{v854}"
    let v864 : unit = ()
    let v865 : (unit -> unit) = closure8(v19, v856)
    let v866 : unit = (fun () -> v865 (); v864) ()
    let v873 : string = $"{v135}"
    let v881 : unit = ()
    let v882 : (unit -> unit) = closure8(v19, v873)
    let v883 : unit = (fun () -> v882 (); v881) ()
    let v891 : string = "working_directory"
    let v892 : string = $"{v891}"
    let v900 : unit = ()
    let v901 : (unit -> unit) = closure8(v19, v892)
    let v902 : unit = (fun () -> v901 (); v900) ()
    let v909 : string = $"{v60}"
    let v917 : unit = ()
    let v918 : (unit -> unit) = closure8(v19, v909)
    let v919 : unit = (fun () -> v918 (); v917) ()
    (* run_target_args'
    let v929 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v930 : string = "format!(\"{:#?}\", $0)"
    let v931 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v930 
    let v932 : string = "fable_library_rust::String_::fromString($0)"
    let v933 : string = Fable.Core.RustInterop.emitRustExpr v931 v932 
    let _run_target_args'_v929 = v933 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v934 : string = "format!(\"{:#?}\", $0)"
    let v935 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v934 
    let v936 : string = "fable_library_rust::String_::fromString($0)"
    let v937 : string = Fable.Core.RustInterop.emitRustExpr v935 v936 
    let _run_target_args'_v929 = v937 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v938 : string = "format!(\"{:#?}\", $0)"
    let v939 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v938 
    let v940 : string = "fable_library_rust::String_::fromString($0)"
    let v941 : string = Fable.Core.RustInterop.emitRustExpr v939 v940 
    let _run_target_args'_v929 = v941 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v943 : string = $"%A{v17}"
    let _run_target_args'_v929 = v943 
    #endif
#if FABLE_COMPILER_PYTHON
    let v947 : string = $"%A{v17}"
    let _run_target_args'_v929 = v947 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v951 : string = $"%A{v17}"
    let _run_target_args'_v929 = v951 
    #endif
#else
    let v955 : string = $"%A{v17}"
    let _run_target_args'_v929 = v955 
    #endif
    let v958 : string = _run_target_args'_v929 
    let v965 : string = $"{v958}"
    let v973 : unit = ()
    let v974 : (unit -> unit) = closure8(v19, v965)
    let v975 : unit = (fun () -> v974 (); v973) ()
    let v983 : string = " }"
    let v984 : string = $"{v983}"
    let v992 : unit = ()
    let v993 : (unit -> unit) = closure8(v19, v984)
    let v994 : unit = (fun () -> v993 (); v992) ()
    let v1001 : string = $"{v983}"
    let v1009 : unit = ()
    let v1010 : (unit -> unit) = closure8(v19, v1001)
    let v1011 : unit = (fun () -> v1010 (); v1009) ()
    let v1017 : string = v19.l0
    let v1018 : int64 = v0.l0
    let v1021 : string = " "
    let v1022 : string = v6 + v1021 
    let v1026 : string = v1022 + v7 
    let v1031 : string = " #"
    let v1032 : string = v1026 + v1031 
    let v1036 : (int64 -> string) = _.ToString()
    let v1037 : string = v1036 v1018
    let v1041 : string = v1032 + v1037 
    let v1045 : string = v1041 + v1021 
    let v1050 : string = "runtime.execute_with_options / output error"
    let v1051 : string = v1045 + v1050 
    let v1056 : string = " / "
    let v1057 : string = v1051 + v1056 
    let v1061 : string = v1057 + v1017 
    method16(v1061)
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
    let v385 : string = $"{v378}"
    let v393 : unit = ()
    let v394 : (unit -> unit) = closure8(v18, v385)
    let v395 : unit = (fun () -> v394 (); v393) ()
    let v402 : string = $"{v95}"
    let v410 : unit = ()
    let v411 : (unit -> unit) = closure8(v18, v402)
    let v412 : unit = (fun () -> v411 (); v410) ()
    let v420 : string = "environment_variables"
    let v421 : string = $"{v420}"
    let v429 : unit = ()
    let v430 : (unit -> unit) = closure8(v18, v421)
    let v431 : unit = (fun () -> v430 (); v429) ()
    let v438 : string = $"{v59}"
    let v446 : unit = ()
    let v447 : (unit -> unit) = closure8(v18, v438)
    let v448 : unit = (fun () -> v447 (); v446) ()
    let v455 : string = $"%A{v12}"
    let v459 : string = $"{v455}"
    let v467 : unit = ()
    let v468 : (unit -> unit) = closure8(v18, v459)
    let v469 : unit = (fun () -> v468 (); v467) ()
    let v476 : string = $"{v95}"
    let v484 : unit = ()
    let v485 : (unit -> unit) = closure8(v18, v476)
    let v486 : unit = (fun () -> v485 (); v484) ()
    let v494 : string = "on_line"
    let v495 : string = $"{v494}"
    let v503 : unit = ()
    let v504 : (unit -> unit) = closure8(v18, v495)
    let v505 : unit = (fun () -> v504 (); v503) ()
    let v512 : string = $"{v59}"
    let v520 : unit = ()
    let v521 : (unit -> unit) = closure8(v18, v512)
    let v522 : unit = (fun () -> v521 (); v520) ()
    (* run_target_args'
    let v532 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v533 : string = "format!(\"{:#?}\", $0)"
    let v534 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v533 
    let v535 : string = "fable_library_rust::String_::fromString($0)"
    let v536 : string = Fable.Core.RustInterop.emitRustExpr v534 v535 
    let _run_target_args'_v532 = v536 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v537 : string = "format!(\"{:#?}\", $0)"
    let v538 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v537 
    let v539 : string = "fable_library_rust::String_::fromString($0)"
    let v540 : string = Fable.Core.RustInterop.emitRustExpr v538 v539 
    let _run_target_args'_v532 = v540 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v541 : string = "format!(\"{:#?}\", $0)"
    let v542 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v541 
    let v543 : string = "fable_library_rust::String_::fromString($0)"
    let v544 : string = Fable.Core.RustInterop.emitRustExpr v542 v543 
    let _run_target_args'_v532 = v544 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v546 : string = $"%A{v13}"
    let _run_target_args'_v532 = v546 
    #endif
#if FABLE_COMPILER_PYTHON
    let v550 : string = $"%A{v13}"
    let _run_target_args'_v532 = v550 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v554 : string = $"%A{v13}"
    let _run_target_args'_v532 = v554 
    #endif
#else
    let v558 : string = $"%A{v13}"
    let _run_target_args'_v532 = v558 
    #endif
    let v561 : string = _run_target_args'_v532 
    let v568 : string = $"{v561}"
    let v576 : unit = ()
    let v577 : (unit -> unit) = closure8(v18, v568)
    let v578 : unit = (fun () -> v577 (); v576) ()
    let v585 : string = $"{v95}"
    let v593 : unit = ()
    let v594 : (unit -> unit) = closure8(v18, v585)
    let v595 : unit = (fun () -> v594 (); v593) ()
    let v603 : string = "stdin"
    let v604 : string = $"{v603}"
    let v612 : unit = ()
    let v613 : (unit -> unit) = closure8(v18, v604)
    let v614 : unit = (fun () -> v613 (); v612) ()
    let v621 : string = $"{v59}"
    let v629 : unit = ()
    let v630 : (unit -> unit) = closure8(v18, v621)
    let v631 : unit = (fun () -> v630 (); v629) ()
    (* run_target_args'
    let v641 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v642 : string = "format!(\"{:#?}\", $0)"
    let v643 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v642 
    let v644 : string = "fable_library_rust::String_::fromString($0)"
    let v645 : string = Fable.Core.RustInterop.emitRustExpr v643 v644 
    let _run_target_args'_v641 = v645 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v646 : string = "format!(\"{:#?}\", $0)"
    let v647 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v646 
    let v648 : string = "fable_library_rust::String_::fromString($0)"
    let v649 : string = Fable.Core.RustInterop.emitRustExpr v647 v648 
    let _run_target_args'_v641 = v649 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v650 : string = "format!(\"{:#?}\", $0)"
    let v651 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v650 
    let v652 : string = "fable_library_rust::String_::fromString($0)"
    let v653 : string = Fable.Core.RustInterop.emitRustExpr v651 v652 
    let _run_target_args'_v641 = v653 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v655 : string = $"%A{v14}"
    let _run_target_args'_v641 = v655 
    #endif
#if FABLE_COMPILER_PYTHON
    let v659 : string = $"%A{v14}"
    let _run_target_args'_v641 = v659 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v663 : string = $"%A{v14}"
    let _run_target_args'_v641 = v663 
    #endif
#else
    let v667 : string = $"%A{v14}"
    let _run_target_args'_v641 = v667 
    #endif
    let v670 : string = _run_target_args'_v641 
    let v677 : string = $"{v670}"
    let v685 : unit = ()
    let v686 : (unit -> unit) = closure8(v18, v677)
    let v687 : unit = (fun () -> v686 (); v685) ()
    let v694 : string = $"{v95}"
    let v702 : unit = ()
    let v703 : (unit -> unit) = closure8(v18, v694)
    let v704 : unit = (fun () -> v703 (); v702) ()
    let v712 : string = "trace"
    let v713 : string = $"{v712}"
    let v721 : unit = ()
    let v722 : (unit -> unit) = closure8(v18, v713)
    let v723 : unit = (fun () -> v722 (); v721) ()
    let v730 : string = $"{v59}"
    let v738 : unit = ()
    let v739 : (unit -> unit) = closure8(v18, v730)
    let v740 : unit = (fun () -> v739 (); v738) ()
    let v748 : string =
        if v15 then
            let v746 : string = "true"
            v746
        else
            let v747 : string = "false"
            v747
    let v750 : string = $"{v748}"
    let v758 : unit = ()
    let v759 : (unit -> unit) = closure8(v18, v750)
    let v760 : unit = (fun () -> v759 (); v758) ()
    let v767 : string = $"{v95}"
    let v775 : unit = ()
    let v776 : (unit -> unit) = closure8(v18, v767)
    let v777 : unit = (fun () -> v776 (); v775) ()
    let v785 : string = "working_directory"
    let v786 : string = $"{v785}"
    let v794 : unit = ()
    let v795 : (unit -> unit) = closure8(v18, v786)
    let v796 : unit = (fun () -> v795 (); v794) ()
    let v803 : string = $"{v59}"
    let v811 : unit = ()
    let v812 : (unit -> unit) = closure8(v18, v803)
    let v813 : unit = (fun () -> v812 (); v811) ()
    (* run_target_args'
    let v823 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v824 : string = "format!(\"{:#?}\", $0)"
    let v825 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v824 
    let v826 : string = "fable_library_rust::String_::fromString($0)"
    let v827 : string = Fable.Core.RustInterop.emitRustExpr v825 v826 
    let _run_target_args'_v823 = v827 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v828 : string = "format!(\"{:#?}\", $0)"
    let v829 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v828 
    let v830 : string = "fable_library_rust::String_::fromString($0)"
    let v831 : string = Fable.Core.RustInterop.emitRustExpr v829 v830 
    let _run_target_args'_v823 = v831 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v832 : string = "format!(\"{:#?}\", $0)"
    let v833 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v832 
    let v834 : string = "fable_library_rust::String_::fromString($0)"
    let v835 : string = Fable.Core.RustInterop.emitRustExpr v833 v834 
    let _run_target_args'_v823 = v835 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v837 : string = $"%A{v16}"
    let _run_target_args'_v823 = v837 
    #endif
#if FABLE_COMPILER_PYTHON
    let v841 : string = $"%A{v16}"
    let _run_target_args'_v823 = v841 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v845 : string = $"%A{v16}"
    let _run_target_args'_v823 = v845 
    #endif
#else
    let v849 : string = $"%A{v16}"
    let _run_target_args'_v823 = v849 
    #endif
    let v852 : string = _run_target_args'_v823 
    let v859 : string = $"{v852}"
    let v867 : unit = ()
    let v868 : (unit -> unit) = closure8(v18, v859)
    let v869 : unit = (fun () -> v868 (); v867) ()
    let v877 : string = " }"
    let v878 : string = $"{v877}"
    let v886 : unit = ()
    let v887 : (unit -> unit) = closure8(v18, v878)
    let v888 : unit = (fun () -> v887 (); v886) ()
    let v895 : string = $"{v877}"
    let v903 : unit = ()
    let v904 : (unit -> unit) = closure8(v18, v895)
    let v905 : unit = (fun () -> v904 (); v903) ()
    let v911 : string = v18.l0
    let v912 : int64 = v0.l0
    let v915 : string = " "
    let v916 : string = v6 + v915 
    let v920 : string = v916 + v7 
    let v925 : string = " #"
    let v926 : string = v920 + v925 
    let v930 : (int64 -> string) = _.ToString()
    let v931 : string = v930 v912
    let v935 : string = v926 + v931 
    let v939 : string = v935 + v915 
    let v944 : string = "runtime.execute_with_options_async"
    let v945 : string = v939 + v944 
    let v950 : string = " / "
    let v951 : string = v945 + v950 
    let v955 : string = v951 + v911 
    method16(v955)
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
            let v546 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v548 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v548 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v552 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v552 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v556 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v556 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v560 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v560 
            #endif
#if FABLE_COMPILER_PYTHON
            let v564 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v564 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v568 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v568 
            #endif
#else
            let v571 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v571 = v571 
            let v572 : System.Threading.CancellationToken = v571 
            let v573 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v574 : (System.Threading.CancellationToken []) = [|v572; v573; v0|]
            let v575 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v576 : System.Threading.CancellationTokenSource = v575 v574
            let v577 : System.Threading.CancellationToken = v576.Token
            return v577 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1102 : Async<System.Threading.CancellationToken> = _let'_v19 
    let _run_target_args'_v5 = v1102 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1104 : unit = ()
    let _let'_v1104 =
        async {
            (* run_target_args'
            let v1631 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1633 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1637 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1637 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1641 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1641 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1645 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1645 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1649 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1649 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1653 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1653 
            #endif
#else
            let v1656 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v1656 = v1656 
            let v1657 : System.Threading.CancellationToken = v1656 
            let v1658 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v1659 : (System.Threading.CancellationToken []) = [|v1657; v1658; v0|]
            let v1660 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v1661 : System.Threading.CancellationTokenSource = v1660 v1659
            let v1662 : System.Threading.CancellationToken = v1661.Token
            return v1662 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2187 : Async<System.Threading.CancellationToken> = _let'_v1104 
    let _run_target_args'_v5 = v2187 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v2189 : unit = ()
    let _let'_v2189 =
        async {
            (* run_target_args'
            let v2716 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2718 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v2718 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2722 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v2722 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2726 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v2726 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2730 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v2730 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2734 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v2734 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2738 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v2738 
            #endif
#else
            let v2741 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v2741 = v2741 
            let v2742 : System.Threading.CancellationToken = v2741 
            let v2743 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v2744 : (System.Threading.CancellationToken []) = [|v2742; v2743; v0|]
            let v2745 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v2746 : System.Threading.CancellationTokenSource = v2745 v2744
            let v2747 : System.Threading.CancellationToken = v2746.Token
            return v2747 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v3272 : Async<System.Threading.CancellationToken> = _let'_v2189 
    let _run_target_args'_v5 = v3272 
    #endif
#else
    let v3274 : unit = ()
    let _let'_v3274 =
        async {
            (* run_target_args'
            let v3801 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3803 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v3803 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3807 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v3807 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3811 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v3811 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3815 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v3815 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3819 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v3819 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3823 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v3823 
            #endif
#else
            let v3826 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v3826 = v3826 
            let v3827 : System.Threading.CancellationToken = v3826 
            let v3828 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v3829 : (System.Threading.CancellationToken []) = [|v3827; v3828; v0|]
            let v3830 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v3831 : System.Threading.CancellationTokenSource = v3830 v3829
            let v3832 : System.Threading.CancellationToken = v3831.Token
            return v3832 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v4357 : Async<System.Threading.CancellationToken> = _let'_v3274 
    let _run_target_args'_v5 = v4357 
    #endif
    let v4358 : Async<System.Threading.CancellationToken> = _run_target_args'_v5 
    v4358
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
    let v108 : string = $"{v101}"
    let v116 : unit = ()
    let v117 : (unit -> unit) = closure8(v10, v108)
    let v118 : unit = (fun () -> v117 (); v116) ()
    let v126 : string = " }"
    let v127 : string = $"{v126}"
    let v135 : unit = ()
    let v136 : (unit -> unit) = closure8(v10, v127)
    let v137 : unit = (fun () -> v136 (); v135) ()
    let v143 : string = v10.l0
    let v144 : int64 = v0.l0
    let v147 : string = " "
    let v148 : string = v6 + v147 
    let v152 : string = v148 + v7 
    let v157 : string = " #"
    let v158 : string = v152 + v157 
    let v162 : (int64 -> string) = _.ToString()
    let v163 : string = v162 v144
    let v167 : string = v158 + v163 
    let v171 : string = v167 + v147 
    let v176 : string = "runtime.execute_with_options_async / WaitForExitAsync"
    let v177 : string = v171 + v176 
    let v182 : string = " / "
    let v183 : string = v177 + v182 
    let v187 : string = v183 + v143 
    method16(v187)
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
                let v10622 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v10624 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v10622 = v10624 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v10628 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v10622 = v10628 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v10632 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v10622 = v10632 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v10636 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v10622 = v10636 
                #endif
#if FABLE_COMPILER_PYTHON
                let v10640 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v10622 = v10640 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v10644 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v10622 = v10644 
                #endif
#else
                let v10647 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _run_target_args'_v10622 = v10647 
                #endif
                let v10648 : System.Threading.Tasks.Task = _run_target_args'_v10622 
                (* run_target_args'
                let v10658 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v10660 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v10658 = v10660 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v10664 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v10658 = v10664 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v10668 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v10658 = v10668 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v10671 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v10672 : Async<unit> = v10671 v10648
                let _run_target_args'_v10658 = v10672 
                #endif
#if FABLE_COMPILER_PYTHON
                let v10673 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v10674 : Async<unit> = v10673 v10648
                let _run_target_args'_v10658 = v10674 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v10675 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v10676 : Async<unit> = v10675 v10648
                let _run_target_args'_v10658 = v10676 
                #endif
#else
                let v10677 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v10678 : Async<unit> = v10677 v10648
                let _run_target_args'_v10658 = v10678 
                #endif
                let v10679 : Async<unit> = _run_target_args'_v10658 
                do! v10679 
                (* run_target_args'
                let v10689 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v10691 : int32 = null |> unbox<int32>
                let _run_target_args'_v10689 = v10691 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v10695 : int32 = null |> unbox<int32>
                let _run_target_args'_v10689 = v10695 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v10699 : int32 = null |> unbox<int32>
                let _run_target_args'_v10689 = v10699 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v10703 : int32 = null |> unbox<int32>
                let _run_target_args'_v10689 = v10703 
                #endif
#if FABLE_COMPILER_PYTHON
                let v10707 : int32 = null |> unbox<int32>
                let _run_target_args'_v10689 = v10707 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v10711 : int32 = null |> unbox<int32>
                let _run_target_args'_v10689 = v10711 
                #endif
#else
                let v10714 : int32 = v0.ExitCode
                let _run_target_args'_v10689 = v10714 
                #endif
                let v10715 : int32 = _run_target_args'_v10689 
                return v10715 
                (* indent
                ()
            indent *)
            with ex ->
                let v10990 : exn = ex
                (* run_target_args'
                let v10995 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v10997 : string = $"%A{v10990}"
                let _run_target_args'_v10995 = v10997 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v11001 : string = $"%A{v10990}"
                let _run_target_args'_v10995 = v11001 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v11005 : string = $"%A{v10990}"
                let _run_target_args'_v10995 = v11005 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v11009 : string = $"%A{v10990}"
                let _run_target_args'_v10995 = v11009 
                #endif
#if FABLE_COMPILER_PYTHON
                let v11013 : string = $"%A{v10990}"
                let _run_target_args'_v10995 = v11013 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v11017 : string = $"%A{v10990}"
                let _run_target_args'_v10995 = v11017 
                #endif
#else
                let v11020 : string = $"{v10990.GetType ()}: {v10990.Message}"
                let _run_target_args'_v10995 = v11020 
                #endif
                let v11021 : string = _run_target_args'_v10995 
                (* run_target_args'
                let v11027 : unit = ()
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
                let v11028 : (string -> unit) = v1.Push
                v11028 v11021
                #endif
                // run_target_args' is_unit
                let v11030 : System.Threading.Tasks.TaskCanceledException = v10990 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v11093 : unit = ()
                let v11094 : (unit -> unit) = closure67(v11030)
                let v11095 : unit = (fun () -> v11094 (); v11093) ()
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
    let v21813 : Async<int32> = _let'_v21 
    let _run_target_args'_v7 = v21813 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21815 : unit = ()
    let _let'_v21815 =
        async {
            try
                (* run_target_args'
                let v32416 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v32418 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v32416 = v32418 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v32422 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v32416 = v32422 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v32426 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v32416 = v32426 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v32430 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v32416 = v32430 
                #endif
#if FABLE_COMPILER_PYTHON
                let v32434 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v32416 = v32434 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v32438 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v32416 = v32438 
                #endif
#else
                let v32441 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _run_target_args'_v32416 = v32441 
                #endif
                let v32442 : System.Threading.Tasks.Task = _run_target_args'_v32416 
                (* run_target_args'
                let v32452 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v32454 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v32452 = v32454 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v32458 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v32452 = v32458 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v32462 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v32452 = v32462 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v32465 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v32466 : Async<unit> = v32465 v32442
                let _run_target_args'_v32452 = v32466 
                #endif
#if FABLE_COMPILER_PYTHON
                let v32467 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v32468 : Async<unit> = v32467 v32442
                let _run_target_args'_v32452 = v32468 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v32469 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v32470 : Async<unit> = v32469 v32442
                let _run_target_args'_v32452 = v32470 
                #endif
#else
                let v32471 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v32472 : Async<unit> = v32471 v32442
                let _run_target_args'_v32452 = v32472 
                #endif
                let v32473 : Async<unit> = _run_target_args'_v32452 
                do! v32473 
                (* run_target_args'
                let v32483 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v32485 : int32 = null |> unbox<int32>
                let _run_target_args'_v32483 = v32485 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v32489 : int32 = null |> unbox<int32>
                let _run_target_args'_v32483 = v32489 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v32493 : int32 = null |> unbox<int32>
                let _run_target_args'_v32483 = v32493 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v32497 : int32 = null |> unbox<int32>
                let _run_target_args'_v32483 = v32497 
                #endif
#if FABLE_COMPILER_PYTHON
                let v32501 : int32 = null |> unbox<int32>
                let _run_target_args'_v32483 = v32501 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v32505 : int32 = null |> unbox<int32>
                let _run_target_args'_v32483 = v32505 
                #endif
#else
                let v32508 : int32 = v0.ExitCode
                let _run_target_args'_v32483 = v32508 
                #endif
                let v32509 : int32 = _run_target_args'_v32483 
                return v32509 
                (* indent
                ()
            indent *)
            with ex ->
                let v32784 : exn = ex
                (* run_target_args'
                let v32789 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v32791 : string = $"%A{v32784}"
                let _run_target_args'_v32789 = v32791 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v32795 : string = $"%A{v32784}"
                let _run_target_args'_v32789 = v32795 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v32799 : string = $"%A{v32784}"
                let _run_target_args'_v32789 = v32799 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v32803 : string = $"%A{v32784}"
                let _run_target_args'_v32789 = v32803 
                #endif
#if FABLE_COMPILER_PYTHON
                let v32807 : string = $"%A{v32784}"
                let _run_target_args'_v32789 = v32807 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v32811 : string = $"%A{v32784}"
                let _run_target_args'_v32789 = v32811 
                #endif
#else
                let v32814 : string = $"{v32784.GetType ()}: {v32784.Message}"
                let _run_target_args'_v32789 = v32814 
                #endif
                let v32815 : string = _run_target_args'_v32789 
                (* run_target_args'
                let v32821 : unit = ()
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
                let v32822 : (string -> unit) = v1.Push
                v32822 v32815
                #endif
                // run_target_args' is_unit
                let v32824 : System.Threading.Tasks.TaskCanceledException = v32784 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v32887 : unit = ()
                let v32888 : (unit -> unit) = closure67(v32824)
                let v32889 : unit = (fun () -> v32888 (); v32887) ()
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
    let v43607 : Async<int32> = _let'_v21815 
    let _run_target_args'_v7 = v43607 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v43609 : unit = ()
    let _let'_v43609 =
        async {
            try
                (* run_target_args'
                let v54210 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v54212 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v54210 = v54212 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v54216 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v54210 = v54216 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v54220 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v54210 = v54220 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v54224 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v54210 = v54224 
                #endif
#if FABLE_COMPILER_PYTHON
                let v54228 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v54210 = v54228 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v54232 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v54210 = v54232 
                #endif
#else
                let v54235 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _run_target_args'_v54210 = v54235 
                #endif
                let v54236 : System.Threading.Tasks.Task = _run_target_args'_v54210 
                (* run_target_args'
                let v54246 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v54248 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v54246 = v54248 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v54252 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v54246 = v54252 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v54256 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v54246 = v54256 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v54259 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v54260 : Async<unit> = v54259 v54236
                let _run_target_args'_v54246 = v54260 
                #endif
#if FABLE_COMPILER_PYTHON
                let v54261 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v54262 : Async<unit> = v54261 v54236
                let _run_target_args'_v54246 = v54262 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v54263 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v54264 : Async<unit> = v54263 v54236
                let _run_target_args'_v54246 = v54264 
                #endif
#else
                let v54265 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v54266 : Async<unit> = v54265 v54236
                let _run_target_args'_v54246 = v54266 
                #endif
                let v54267 : Async<unit> = _run_target_args'_v54246 
                do! v54267 
                (* run_target_args'
                let v54277 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v54279 : int32 = null |> unbox<int32>
                let _run_target_args'_v54277 = v54279 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v54283 : int32 = null |> unbox<int32>
                let _run_target_args'_v54277 = v54283 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v54287 : int32 = null |> unbox<int32>
                let _run_target_args'_v54277 = v54287 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v54291 : int32 = null |> unbox<int32>
                let _run_target_args'_v54277 = v54291 
                #endif
#if FABLE_COMPILER_PYTHON
                let v54295 : int32 = null |> unbox<int32>
                let _run_target_args'_v54277 = v54295 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v54299 : int32 = null |> unbox<int32>
                let _run_target_args'_v54277 = v54299 
                #endif
#else
                let v54302 : int32 = v0.ExitCode
                let _run_target_args'_v54277 = v54302 
                #endif
                let v54303 : int32 = _run_target_args'_v54277 
                return v54303 
                (* indent
                ()
            indent *)
            with ex ->
                let v54578 : exn = ex
                (* run_target_args'
                let v54583 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v54585 : string = $"%A{v54578}"
                let _run_target_args'_v54583 = v54585 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v54589 : string = $"%A{v54578}"
                let _run_target_args'_v54583 = v54589 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v54593 : string = $"%A{v54578}"
                let _run_target_args'_v54583 = v54593 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v54597 : string = $"%A{v54578}"
                let _run_target_args'_v54583 = v54597 
                #endif
#if FABLE_COMPILER_PYTHON
                let v54601 : string = $"%A{v54578}"
                let _run_target_args'_v54583 = v54601 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v54605 : string = $"%A{v54578}"
                let _run_target_args'_v54583 = v54605 
                #endif
#else
                let v54608 : string = $"{v54578.GetType ()}: {v54578.Message}"
                let _run_target_args'_v54583 = v54608 
                #endif
                let v54609 : string = _run_target_args'_v54583 
                (* run_target_args'
                let v54615 : unit = ()
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
                let v54616 : (string -> unit) = v1.Push
                v54616 v54609
                #endif
                // run_target_args' is_unit
                let v54618 : System.Threading.Tasks.TaskCanceledException = v54578 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v54681 : unit = ()
                let v54682 : (unit -> unit) = closure67(v54618)
                let v54683 : unit = (fun () -> v54682 (); v54681) ()
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
    let v65401 : Async<int32> = _let'_v43609 
    let _run_target_args'_v7 = v65401 
    #endif
#else
    let v65403 : unit = ()
    let _let'_v65403 =
        async {
            try
                (* run_target_args'
                let v76004 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v76006 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v76004 = v76006 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v76010 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v76004 = v76010 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v76014 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v76004 = v76014 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v76018 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v76004 = v76018 
                #endif
#if FABLE_COMPILER_PYTHON
                let v76022 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v76004 = v76022 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v76026 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v76004 = v76026 
                #endif
#else
                let v76029 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _run_target_args'_v76004 = v76029 
                #endif
                let v76030 : System.Threading.Tasks.Task = _run_target_args'_v76004 
                (* run_target_args'
                let v76040 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v76042 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v76040 = v76042 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v76046 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v76040 = v76046 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v76050 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v76040 = v76050 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v76053 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v76054 : Async<unit> = v76053 v76030
                let _run_target_args'_v76040 = v76054 
                #endif
#if FABLE_COMPILER_PYTHON
                let v76055 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v76056 : Async<unit> = v76055 v76030
                let _run_target_args'_v76040 = v76056 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v76057 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v76058 : Async<unit> = v76057 v76030
                let _run_target_args'_v76040 = v76058 
                #endif
#else
                let v76059 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v76060 : Async<unit> = v76059 v76030
                let _run_target_args'_v76040 = v76060 
                #endif
                let v76061 : Async<unit> = _run_target_args'_v76040 
                do! v76061 
                (* run_target_args'
                let v76071 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v76073 : int32 = null |> unbox<int32>
                let _run_target_args'_v76071 = v76073 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v76077 : int32 = null |> unbox<int32>
                let _run_target_args'_v76071 = v76077 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v76081 : int32 = null |> unbox<int32>
                let _run_target_args'_v76071 = v76081 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v76085 : int32 = null |> unbox<int32>
                let _run_target_args'_v76071 = v76085 
                #endif
#if FABLE_COMPILER_PYTHON
                let v76089 : int32 = null |> unbox<int32>
                let _run_target_args'_v76071 = v76089 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v76093 : int32 = null |> unbox<int32>
                let _run_target_args'_v76071 = v76093 
                #endif
#else
                let v76096 : int32 = v0.ExitCode
                let _run_target_args'_v76071 = v76096 
                #endif
                let v76097 : int32 = _run_target_args'_v76071 
                return v76097 
                (* indent
                ()
            indent *)
            with ex ->
                let v76372 : exn = ex
                (* run_target_args'
                let v76377 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v76379 : string = $"%A{v76372}"
                let _run_target_args'_v76377 = v76379 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v76383 : string = $"%A{v76372}"
                let _run_target_args'_v76377 = v76383 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v76387 : string = $"%A{v76372}"
                let _run_target_args'_v76377 = v76387 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v76391 : string = $"%A{v76372}"
                let _run_target_args'_v76377 = v76391 
                #endif
#if FABLE_COMPILER_PYTHON
                let v76395 : string = $"%A{v76372}"
                let _run_target_args'_v76377 = v76395 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v76399 : string = $"%A{v76372}"
                let _run_target_args'_v76377 = v76399 
                #endif
#else
                let v76402 : string = $"{v76372.GetType ()}: {v76372.Message}"
                let _run_target_args'_v76377 = v76402 
                #endif
                let v76403 : string = _run_target_args'_v76377 
                (* run_target_args'
                let v76409 : unit = ()
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
                let v76410 : (string -> unit) = v1.Push
                v76410 v76403
                #endif
                // run_target_args' is_unit
                let v76412 : System.Threading.Tasks.TaskCanceledException = v76372 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v76475 : unit = ()
                let v76476 : (unit -> unit) = closure67(v76412)
                let v76477 : unit = (fun () -> v76476 (); v76475) ()
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
    let v87195 : Async<int32> = _let'_v65403 
    let _run_target_args'_v7 = v87195 
    #endif
    let v87196 : Async<int32> = _run_target_args'_v7 
    v87196
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
    let v387 : string = $"{v380}"
    let v395 : unit = ()
    let v396 : (unit -> unit) = closure8(v18, v387)
    let v397 : unit = (fun () -> v396 (); v395) ()
    let v404 : string = $"{v98}"
    let v412 : unit = ()
    let v413 : (unit -> unit) = closure8(v18, v404)
    let v414 : unit = (fun () -> v413 (); v412) ()
    let v422 : string = "environment_variables"
    let v423 : string = $"{v422}"
    let v431 : unit = ()
    let v432 : (unit -> unit) = closure8(v18, v423)
    let v433 : unit = (fun () -> v432 (); v431) ()
    let v440 : string = $"{v59}"
    let v448 : unit = ()
    let v449 : (unit -> unit) = closure8(v18, v440)
    let v450 : unit = (fun () -> v449 (); v448) ()
    let v457 : string = $"%A{v12}"
    let v461 : string = $"{v457}"
    let v469 : unit = ()
    let v470 : (unit -> unit) = closure8(v18, v461)
    let v471 : unit = (fun () -> v470 (); v469) ()
    let v478 : string = $"{v98}"
    let v486 : unit = ()
    let v487 : (unit -> unit) = closure8(v18, v478)
    let v488 : unit = (fun () -> v487 (); v486) ()
    let v496 : string = "on_line"
    let v497 : string = $"{v496}"
    let v505 : unit = ()
    let v506 : (unit -> unit) = closure8(v18, v497)
    let v507 : unit = (fun () -> v506 (); v505) ()
    let v514 : string = $"{v59}"
    let v522 : unit = ()
    let v523 : (unit -> unit) = closure8(v18, v514)
    let v524 : unit = (fun () -> v523 (); v522) ()
    (* run_target_args'
    let v534 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v535 : string = "format!(\"{:#?}\", $0)"
    let v536 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v535 
    let v537 : string = "fable_library_rust::String_::fromString($0)"
    let v538 : string = Fable.Core.RustInterop.emitRustExpr v536 v537 
    let _run_target_args'_v534 = v538 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v539 : string = "format!(\"{:#?}\", $0)"
    let v540 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v539 
    let v541 : string = "fable_library_rust::String_::fromString($0)"
    let v542 : string = Fable.Core.RustInterop.emitRustExpr v540 v541 
    let _run_target_args'_v534 = v542 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v543 : string = "format!(\"{:#?}\", $0)"
    let v544 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v543 
    let v545 : string = "fable_library_rust::String_::fromString($0)"
    let v546 : string = Fable.Core.RustInterop.emitRustExpr v544 v545 
    let _run_target_args'_v534 = v546 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v548 : string = $"%A{v13}"
    let _run_target_args'_v534 = v548 
    #endif
#if FABLE_COMPILER_PYTHON
    let v552 : string = $"%A{v13}"
    let _run_target_args'_v534 = v552 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v556 : string = $"%A{v13}"
    let _run_target_args'_v534 = v556 
    #endif
#else
    let v560 : string = $"%A{v13}"
    let _run_target_args'_v534 = v560 
    #endif
    let v563 : string = _run_target_args'_v534 
    let v570 : string = $"{v563}"
    let v578 : unit = ()
    let v579 : (unit -> unit) = closure8(v18, v570)
    let v580 : unit = (fun () -> v579 (); v578) ()
    let v587 : string = $"{v98}"
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
    let v679 : string = $"{v672}"
    let v687 : unit = ()
    let v688 : (unit -> unit) = closure8(v18, v679)
    let v689 : unit = (fun () -> v688 (); v687) ()
    let v696 : string = $"{v98}"
    let v704 : unit = ()
    let v705 : (unit -> unit) = closure8(v18, v696)
    let v706 : unit = (fun () -> v705 (); v704) ()
    let v714 : string = "trace"
    let v715 : string = $"{v714}"
    let v723 : unit = ()
    let v724 : (unit -> unit) = closure8(v18, v715)
    let v725 : unit = (fun () -> v724 (); v723) ()
    let v732 : string = $"{v59}"
    let v740 : unit = ()
    let v741 : (unit -> unit) = closure8(v18, v732)
    let v742 : unit = (fun () -> v741 (); v740) ()
    let v750 : string =
        if v15 then
            let v748 : string = "true"
            v748
        else
            let v749 : string = "false"
            v749
    let v752 : string = $"{v750}"
    let v760 : unit = ()
    let v761 : (unit -> unit) = closure8(v18, v752)
    let v762 : unit = (fun () -> v761 (); v760) ()
    let v769 : string = $"{v98}"
    let v777 : unit = ()
    let v778 : (unit -> unit) = closure8(v18, v769)
    let v779 : unit = (fun () -> v778 (); v777) ()
    let v787 : string = "working_directory"
    let v788 : string = $"{v787}"
    let v796 : unit = ()
    let v797 : (unit -> unit) = closure8(v18, v788)
    let v798 : unit = (fun () -> v797 (); v796) ()
    let v805 : string = $"{v59}"
    let v813 : unit = ()
    let v814 : (unit -> unit) = closure8(v18, v805)
    let v815 : unit = (fun () -> v814 (); v813) ()
    (* run_target_args'
    let v825 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v826 : string = "format!(\"{:#?}\", $0)"
    let v827 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v826 
    let v828 : string = "fable_library_rust::String_::fromString($0)"
    let v829 : string = Fable.Core.RustInterop.emitRustExpr v827 v828 
    let _run_target_args'_v825 = v829 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v830 : string = "format!(\"{:#?}\", $0)"
    let v831 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v830 
    let v832 : string = "fable_library_rust::String_::fromString($0)"
    let v833 : string = Fable.Core.RustInterop.emitRustExpr v831 v832 
    let _run_target_args'_v825 = v833 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v834 : string = "format!(\"{:#?}\", $0)"
    let v835 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v834 
    let v836 : string = "fable_library_rust::String_::fromString($0)"
    let v837 : string = Fable.Core.RustInterop.emitRustExpr v835 v836 
    let _run_target_args'_v825 = v837 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v839 : string = $"%A{v16}"
    let _run_target_args'_v825 = v839 
    #endif
#if FABLE_COMPILER_PYTHON
    let v843 : string = $"%A{v16}"
    let _run_target_args'_v825 = v843 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v847 : string = $"%A{v16}"
    let _run_target_args'_v825 = v847 
    #endif
#else
    let v851 : string = $"%A{v16}"
    let _run_target_args'_v825 = v851 
    #endif
    let v854 : string = _run_target_args'_v825 
    let v861 : string = $"{v854}"
    let v869 : unit = ()
    let v870 : (unit -> unit) = closure8(v18, v861)
    let v871 : unit = (fun () -> v870 (); v869) ()
    let v879 : string = " }"
    let v880 : string = $"{v879}"
    let v888 : unit = ()
    let v889 : (unit -> unit) = closure8(v18, v880)
    let v890 : unit = (fun () -> v889 (); v888) ()
    let v897 : string = $"{v879}"
    let v905 : unit = ()
    let v906 : (unit -> unit) = closure8(v18, v897)
    let v907 : unit = (fun () -> v906 (); v905) ()
    let v913 : string = v18.l0
    let v914 : int64 = v0.l0
    let v917 : string = " "
    let v918 : string = v6 + v917 
    let v922 : string = v918 + v7 
    let v927 : string = " #"
    let v928 : string = v922 + v927 
    let v932 : (int64 -> string) = _.ToString()
    let v933 : string = v932 v914
    let v937 : string = v928 + v933 
    let v941 : string = v937 + v917 
    let v946 : string = "runtime.execute_with_options_async"
    let v947 : string = v941 + v946 
    let v952 : string = " / "
    let v953 : string = v947 + v952 
    let v957 : string = v953 + v913 
    method16(v957)
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
            let v5834 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v5837 : int32, v5838 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5837, v5838) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v5845 : int32, v5846 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5845, v5846) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v5853 : int32, v5854 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5853, v5854) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v5861 : int32, v5862 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5861, v5862) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v5869 : int32, v5870 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5869, v5870) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v5877 : int32, v5878 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5877, v5878) 
            #endif
#else
            let v5883 : US14 = method77(v0)
            let struct (v5895 : string, v5896 : US5) =
                match v5883 with
                | US14_1(v5886) -> (* Error *)
                    let v5888 : string = $"resultm.get / Result value was Error: {v5886}"
                    failwith<struct (string * US5)> v5888
                | US14_0(v5884, v5885) -> (* Ok *)
                    struct (v5884, v5885)
            let v5899 : (string -> US5) = method6()
            let v5900 : US5 option = v6 |> Option.map v5899 
            let v5920 : US5 = US5_1
            let v5921 : US5 = v5900 |> Option.defaultValue v5920 
            let v5928 : string =
                match v5921 with
                | US5_1 -> (* None *)
                    let v5926 : string = ""
                    v5926
                | US5_0(v5925) -> (* Some *)
                    v5925
            let v5989 : unit = ()
            let v5990 : (unit -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v5896, v5895)
            let v5991 : unit = (fun () -> v5990 (); v5989) ()
            let v6052 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v6056 : string =
                match v5896 with
                | US5_1 -> (* None *)
                    let v6054 : string = ""
                    v6054
                | US5_0(v6053) -> (* Some *)
                    v6053
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v6056,
              StandardOutputEncoding = v6052,
              WorkingDirectory = v5928,
              FileName = v5895,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v6057 : System.Diagnostics.ProcessStartInfo = start_info
            let v6058 : (struct (string * string) []) = method130(v0, v1, v2, v3, v4, v5, v6)
            let v6059 : int32 = v6058.Length
            let v6060 : Mut6 = {l0 = 0} : Mut6
            while method58(v6059, v6060) do
                let v6062 : int32 = v6060.l0
                let struct (v6063 : string, v6064 : string) = v6058.[int v6062]
                v6057.EnvironmentVariables.[v6063] <- v6064 
                let v6065 : int32 = v6062 + 1
                v6060.l0 <- v6065
                ()
            let v6066 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v6057)
            use v6066 = v6066 
            let v6067 : System.Diagnostics.Process = v6066 
            let v6068 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v6069 : System.Collections.Concurrent.ConcurrentStack<string> = v6068 ()
            let v6070 : bool = false
            let v6071 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v6067, v6069, v6070)
            v6067.OutputDataReceived.Add v6071 
            let v6072 : bool = true
            let v6073 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v6067, v6069, v6072)
            v6067.ErrorDataReceived.Add v6073 
            let v6074 : (unit -> bool) = v6067.Start
            let v6075 : bool = v6074 ()
            let v6076 : bool = v6075 = false
            if v6076 then
                let v6077 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v6077
            let v6078 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v6078 v6067
            let v6079 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v6079 v6067
            let v6082 : (System.Threading.CancellationToken -> US32) = method136()
            let v6083 : US32 option = v1 |> Option.map v6082 
            let v6103 : US32 = US32_1
            let v6104 : US32 = v6083 |> Option.defaultValue v6103 
            let v6111 : System.Threading.CancellationToken =
                match v6104 with
                | US32_1 -> (* None *)
                    let v6109 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v6109
                | US32_0(v6108) -> (* Some *)
                    v6108
            let v6112 : Async<System.Threading.CancellationToken> = method137(v6111)
            let! v6112 = v6112 
            let v6113 : System.Threading.CancellationToken = v6112 
            let v6114 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v6113.Register
            let v6115 : (unit -> unit) = closure66(v6067)
            let v6116 : System.Threading.CancellationTokenRegistration = v6114 v6115
            use v6116 = v6116 
            let v6117 : System.Threading.CancellationTokenRegistration = v6116 
            let v6118 : Async<int32> = method140(v6067, v6069, v6113)
            let! v6118 = v6118 
            let v6119 : int32 = v6118 
            let v6121 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v6122 : string seq = v6121 v6069
            let v6126 : (string seq -> string seq) = Seq.rev
            let v6127 : string seq = v6126 v6122
            let v6132 : string = method125()
            let v6133 : (string -> (string seq -> string)) = String.concat
            let v6134 : (string seq -> string) = v6133 v6132
            let v6135 : string = v6134 v6127
            let v6200 : unit = ()
            let v6201 : (unit -> unit) = closure68(v0, v1, v2, v3, v4, v5, v6, v6119, v6135)
            let v6202 : unit = (fun () -> v6201 (); v6200) ()
            return struct (v6119, v6135) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v12070 : Async<struct (int32 * string)> = _let'_v25 
    let _run_target_args'_v11 = v12070 
    #endif
#if FABLE_COMPILER_PYTHON
    let v12072 : unit = ()
    let _let'_v12072 =
        async {
            (* run_target_args'
            let v17881 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v17884 : int32, v17885 : string) = null |> unbox<struct (int32 * string)>
            return struct (v17884, v17885) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v17892 : int32, v17893 : string) = null |> unbox<struct (int32 * string)>
            return struct (v17892, v17893) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v17900 : int32, v17901 : string) = null |> unbox<struct (int32 * string)>
            return struct (v17900, v17901) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v17908 : int32, v17909 : string) = null |> unbox<struct (int32 * string)>
            return struct (v17908, v17909) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v17916 : int32, v17917 : string) = null |> unbox<struct (int32 * string)>
            return struct (v17916, v17917) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v17924 : int32, v17925 : string) = null |> unbox<struct (int32 * string)>
            return struct (v17924, v17925) 
            #endif
#else
            let v17930 : US14 = method77(v0)
            let struct (v17942 : string, v17943 : US5) =
                match v17930 with
                | US14_1(v17933) -> (* Error *)
                    let v17935 : string = $"resultm.get / Result value was Error: {v17933}"
                    failwith<struct (string * US5)> v17935
                | US14_0(v17931, v17932) -> (* Ok *)
                    struct (v17931, v17932)
            let v17946 : (string -> US5) = method6()
            let v17947 : US5 option = v6 |> Option.map v17946 
            let v17967 : US5 = US5_1
            let v17968 : US5 = v17947 |> Option.defaultValue v17967 
            let v17975 : string =
                match v17968 with
                | US5_1 -> (* None *)
                    let v17973 : string = ""
                    v17973
                | US5_0(v17972) -> (* Some *)
                    v17972
            let v18036 : unit = ()
            let v18037 : (unit -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v17943, v17942)
            let v18038 : unit = (fun () -> v18037 (); v18036) ()
            let v18099 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v18103 : string =
                match v17943 with
                | US5_1 -> (* None *)
                    let v18101 : string = ""
                    v18101
                | US5_0(v18100) -> (* Some *)
                    v18100
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v18103,
              StandardOutputEncoding = v18099,
              WorkingDirectory = v17975,
              FileName = v17942,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v18104 : System.Diagnostics.ProcessStartInfo = start_info
            let v18105 : (struct (string * string) []) = method130(v0, v1, v2, v3, v4, v5, v6)
            let v18106 : int32 = v18105.Length
            let v18107 : Mut6 = {l0 = 0} : Mut6
            while method58(v18106, v18107) do
                let v18109 : int32 = v18107.l0
                let struct (v18110 : string, v18111 : string) = v18105.[int v18109]
                v18104.EnvironmentVariables.[v18110] <- v18111 
                let v18112 : int32 = v18109 + 1
                v18107.l0 <- v18112
                ()
            let v18113 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v18104)
            use v18113 = v18113 
            let v18114 : System.Diagnostics.Process = v18113 
            let v18115 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v18116 : System.Collections.Concurrent.ConcurrentStack<string> = v18115 ()
            let v18117 : bool = false
            let v18118 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v18114, v18116, v18117)
            v18114.OutputDataReceived.Add v18118 
            let v18119 : bool = true
            let v18120 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v18114, v18116, v18119)
            v18114.ErrorDataReceived.Add v18120 
            let v18121 : (unit -> bool) = v18114.Start
            let v18122 : bool = v18121 ()
            let v18123 : bool = v18122 = false
            if v18123 then
                let v18124 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v18124
            let v18125 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v18125 v18114
            let v18126 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v18126 v18114
            let v18129 : (System.Threading.CancellationToken -> US32) = method136()
            let v18130 : US32 option = v1 |> Option.map v18129 
            let v18150 : US32 = US32_1
            let v18151 : US32 = v18130 |> Option.defaultValue v18150 
            let v18158 : System.Threading.CancellationToken =
                match v18151 with
                | US32_1 -> (* None *)
                    let v18156 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v18156
                | US32_0(v18155) -> (* Some *)
                    v18155
            let v18159 : Async<System.Threading.CancellationToken> = method137(v18158)
            let! v18159 = v18159 
            let v18160 : System.Threading.CancellationToken = v18159 
            let v18161 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v18160.Register
            let v18162 : (unit -> unit) = closure66(v18114)
            let v18163 : System.Threading.CancellationTokenRegistration = v18161 v18162
            use v18163 = v18163 
            let v18164 : System.Threading.CancellationTokenRegistration = v18163 
            let v18165 : Async<int32> = method140(v18114, v18116, v18160)
            let! v18165 = v18165 
            let v18166 : int32 = v18165 
            let v18168 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v18169 : string seq = v18168 v18116
            let v18173 : (string seq -> string seq) = Seq.rev
            let v18174 : string seq = v18173 v18169
            let v18179 : string = method125()
            let v18180 : (string -> (string seq -> string)) = String.concat
            let v18181 : (string seq -> string) = v18180 v18179
            let v18182 : string = v18181 v18174
            let v18247 : unit = ()
            let v18248 : (unit -> unit) = closure68(v0, v1, v2, v3, v4, v5, v6, v18166, v18182)
            let v18249 : unit = (fun () -> v18248 (); v18247) ()
            return struct (v18166, v18182) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v24117 : Async<struct (int32 * string)> = _let'_v12072 
    let _run_target_args'_v11 = v24117 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v24119 : unit = ()
    let _let'_v24119 =
        async {
            (* run_target_args'
            let v29928 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v29931 : int32, v29932 : string) = null |> unbox<struct (int32 * string)>
            return struct (v29931, v29932) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v29939 : int32, v29940 : string) = null |> unbox<struct (int32 * string)>
            return struct (v29939, v29940) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v29947 : int32, v29948 : string) = null |> unbox<struct (int32 * string)>
            return struct (v29947, v29948) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v29955 : int32, v29956 : string) = null |> unbox<struct (int32 * string)>
            return struct (v29955, v29956) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v29963 : int32, v29964 : string) = null |> unbox<struct (int32 * string)>
            return struct (v29963, v29964) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v29971 : int32, v29972 : string) = null |> unbox<struct (int32 * string)>
            return struct (v29971, v29972) 
            #endif
#else
            let v29977 : US14 = method77(v0)
            let struct (v29989 : string, v29990 : US5) =
                match v29977 with
                | US14_1(v29980) -> (* Error *)
                    let v29982 : string = $"resultm.get / Result value was Error: {v29980}"
                    failwith<struct (string * US5)> v29982
                | US14_0(v29978, v29979) -> (* Ok *)
                    struct (v29978, v29979)
            let v29993 : (string -> US5) = method6()
            let v29994 : US5 option = v6 |> Option.map v29993 
            let v30014 : US5 = US5_1
            let v30015 : US5 = v29994 |> Option.defaultValue v30014 
            let v30022 : string =
                match v30015 with
                | US5_1 -> (* None *)
                    let v30020 : string = ""
                    v30020
                | US5_0(v30019) -> (* Some *)
                    v30019
            let v30083 : unit = ()
            let v30084 : (unit -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v29990, v29989)
            let v30085 : unit = (fun () -> v30084 (); v30083) ()
            let v30146 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v30150 : string =
                match v29990 with
                | US5_1 -> (* None *)
                    let v30148 : string = ""
                    v30148
                | US5_0(v30147) -> (* Some *)
                    v30147
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v30150,
              StandardOutputEncoding = v30146,
              WorkingDirectory = v30022,
              FileName = v29989,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v30151 : System.Diagnostics.ProcessStartInfo = start_info
            let v30152 : (struct (string * string) []) = method130(v0, v1, v2, v3, v4, v5, v6)
            let v30153 : int32 = v30152.Length
            let v30154 : Mut6 = {l0 = 0} : Mut6
            while method58(v30153, v30154) do
                let v30156 : int32 = v30154.l0
                let struct (v30157 : string, v30158 : string) = v30152.[int v30156]
                v30151.EnvironmentVariables.[v30157] <- v30158 
                let v30159 : int32 = v30156 + 1
                v30154.l0 <- v30159
                ()
            let v30160 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v30151)
            use v30160 = v30160 
            let v30161 : System.Diagnostics.Process = v30160 
            let v30162 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v30163 : System.Collections.Concurrent.ConcurrentStack<string> = v30162 ()
            let v30164 : bool = false
            let v30165 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v30161, v30163, v30164)
            v30161.OutputDataReceived.Add v30165 
            let v30166 : bool = true
            let v30167 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v30161, v30163, v30166)
            v30161.ErrorDataReceived.Add v30167 
            let v30168 : (unit -> bool) = v30161.Start
            let v30169 : bool = v30168 ()
            let v30170 : bool = v30169 = false
            if v30170 then
                let v30171 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v30171
            let v30172 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v30172 v30161
            let v30173 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v30173 v30161
            let v30176 : (System.Threading.CancellationToken -> US32) = method136()
            let v30177 : US32 option = v1 |> Option.map v30176 
            let v30197 : US32 = US32_1
            let v30198 : US32 = v30177 |> Option.defaultValue v30197 
            let v30205 : System.Threading.CancellationToken =
                match v30198 with
                | US32_1 -> (* None *)
                    let v30203 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v30203
                | US32_0(v30202) -> (* Some *)
                    v30202
            let v30206 : Async<System.Threading.CancellationToken> = method137(v30205)
            let! v30206 = v30206 
            let v30207 : System.Threading.CancellationToken = v30206 
            let v30208 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v30207.Register
            let v30209 : (unit -> unit) = closure66(v30161)
            let v30210 : System.Threading.CancellationTokenRegistration = v30208 v30209
            use v30210 = v30210 
            let v30211 : System.Threading.CancellationTokenRegistration = v30210 
            let v30212 : Async<int32> = method140(v30161, v30163, v30207)
            let! v30212 = v30212 
            let v30213 : int32 = v30212 
            let v30215 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v30216 : string seq = v30215 v30163
            let v30220 : (string seq -> string seq) = Seq.rev
            let v30221 : string seq = v30220 v30216
            let v30226 : string = method125()
            let v30227 : (string -> (string seq -> string)) = String.concat
            let v30228 : (string seq -> string) = v30227 v30226
            let v30229 : string = v30228 v30221
            let v30294 : unit = ()
            let v30295 : (unit -> unit) = closure68(v0, v1, v2, v3, v4, v5, v6, v30213, v30229)
            let v30296 : unit = (fun () -> v30295 (); v30294) ()
            return struct (v30213, v30229) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v36164 : Async<struct (int32 * string)> = _let'_v24119 
    let _run_target_args'_v11 = v36164 
    #endif
#else
    let v36166 : unit = ()
    let _let'_v36166 =
        async {
            (* run_target_args'
            let v41975 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v41978 : int32, v41979 : string) = null |> unbox<struct (int32 * string)>
            return struct (v41978, v41979) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v41986 : int32, v41987 : string) = null |> unbox<struct (int32 * string)>
            return struct (v41986, v41987) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v41994 : int32, v41995 : string) = null |> unbox<struct (int32 * string)>
            return struct (v41994, v41995) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v42002 : int32, v42003 : string) = null |> unbox<struct (int32 * string)>
            return struct (v42002, v42003) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v42010 : int32, v42011 : string) = null |> unbox<struct (int32 * string)>
            return struct (v42010, v42011) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v42018 : int32, v42019 : string) = null |> unbox<struct (int32 * string)>
            return struct (v42018, v42019) 
            #endif
#else
            let v42024 : US14 = method77(v0)
            let struct (v42036 : string, v42037 : US5) =
                match v42024 with
                | US14_1(v42027) -> (* Error *)
                    let v42029 : string = $"resultm.get / Result value was Error: {v42027}"
                    failwith<struct (string * US5)> v42029
                | US14_0(v42025, v42026) -> (* Ok *)
                    struct (v42025, v42026)
            let v42040 : (string -> US5) = method6()
            let v42041 : US5 option = v6 |> Option.map v42040 
            let v42061 : US5 = US5_1
            let v42062 : US5 = v42041 |> Option.defaultValue v42061 
            let v42069 : string =
                match v42062 with
                | US5_1 -> (* None *)
                    let v42067 : string = ""
                    v42067
                | US5_0(v42066) -> (* Some *)
                    v42066
            let v42130 : unit = ()
            let v42131 : (unit -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v42037, v42036)
            let v42132 : unit = (fun () -> v42131 (); v42130) ()
            let v42193 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v42197 : string =
                match v42037 with
                | US5_1 -> (* None *)
                    let v42195 : string = ""
                    v42195
                | US5_0(v42194) -> (* Some *)
                    v42194
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v42197,
              StandardOutputEncoding = v42193,
              WorkingDirectory = v42069,
              FileName = v42036,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v42198 : System.Diagnostics.ProcessStartInfo = start_info
            let v42199 : (struct (string * string) []) = method130(v0, v1, v2, v3, v4, v5, v6)
            let v42200 : int32 = v42199.Length
            let v42201 : Mut6 = {l0 = 0} : Mut6
            while method58(v42200, v42201) do
                let v42203 : int32 = v42201.l0
                let struct (v42204 : string, v42205 : string) = v42199.[int v42203]
                v42198.EnvironmentVariables.[v42204] <- v42205 
                let v42206 : int32 = v42203 + 1
                v42201.l0 <- v42206
                ()
            let v42207 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v42198)
            use v42207 = v42207 
            let v42208 : System.Diagnostics.Process = v42207 
            let v42209 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v42210 : System.Collections.Concurrent.ConcurrentStack<string> = v42209 ()
            let v42211 : bool = false
            let v42212 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v42208, v42210, v42211)
            v42208.OutputDataReceived.Add v42212 
            let v42213 : bool = true
            let v42214 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v42208, v42210, v42213)
            v42208.ErrorDataReceived.Add v42214 
            let v42215 : (unit -> bool) = v42208.Start
            let v42216 : bool = v42215 ()
            let v42217 : bool = v42216 = false
            if v42217 then
                let v42218 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v42218
            let v42219 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v42219 v42208
            let v42220 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v42220 v42208
            let v42223 : (System.Threading.CancellationToken -> US32) = method136()
            let v42224 : US32 option = v1 |> Option.map v42223 
            let v42244 : US32 = US32_1
            let v42245 : US32 = v42224 |> Option.defaultValue v42244 
            let v42252 : System.Threading.CancellationToken =
                match v42245 with
                | US32_1 -> (* None *)
                    let v42250 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v42250
                | US32_0(v42249) -> (* Some *)
                    v42249
            let v42253 : Async<System.Threading.CancellationToken> = method137(v42252)
            let! v42253 = v42253 
            let v42254 : System.Threading.CancellationToken = v42253 
            let v42255 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v42254.Register
            let v42256 : (unit -> unit) = closure66(v42208)
            let v42257 : System.Threading.CancellationTokenRegistration = v42255 v42256
            use v42257 = v42257 
            let v42258 : System.Threading.CancellationTokenRegistration = v42257 
            let v42259 : Async<int32> = method140(v42208, v42210, v42254)
            let! v42259 = v42259 
            let v42260 : int32 = v42259 
            let v42262 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v42263 : string seq = v42262 v42210
            let v42267 : (string seq -> string seq) = Seq.rev
            let v42268 : string seq = v42267 v42263
            let v42273 : string = method125()
            let v42274 : (string -> (string seq -> string)) = String.concat
            let v42275 : (string seq -> string) = v42274 v42273
            let v42276 : string = v42275 v42268
            let v42341 : unit = ()
            let v42342 : (unit -> unit) = closure68(v0, v1, v2, v3, v4, v5, v6, v42260, v42276)
            let v42343 : unit = (fun () -> v42342 (); v42341) ()
            return struct (v42260, v42276) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v48211 : Async<struct (int32 * string)> = _let'_v36166 
    let _run_target_args'_v11 = v48211 
    #endif
    let v48212 : Async<struct (int32 * string)> = _run_target_args'_v11 
    v48212
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
    let v185 : unit = ()
    let v186 : (unit -> unit) = closure41(v0, v1, v2, v3, v4, v5, v6, v29, v120)
    let v187 : unit = (fun () -> v186 (); v185) ()
    let v253 : bool = true
    let mutable _capture_v253 : (int32 * string) option = None 
    (
    (fun () ->
    (fun () ->
    let v254 : string = "std::process::Command::new(&*$0)"
    let v255 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v29 v254 
    let v256 : string = "true; let mut v255 = v255"
    let v257 : bool = Fable.Core.RustInterop.emitRustExpr () v256 
    let v258 : string = "true; std::process::Command::args(&mut v255, &*$0)"
    let v259 : bool = Fable.Core.RustInterop.emitRustExpr v120 v258 
    let v260 : string = "$0"
    let v261 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v255 v260 
    let v262 : string = "std::process::Stdio::piped()"
    let v263 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v262 
    let v264 : string = "true; let mut v261 = v261"
    let v265 : bool = Fable.Core.RustInterop.emitRustExpr () v264 
    let v266 : string = "true; std::process::Command::stdout(&mut v261, std::process::Stdio::piped())"
    let v267 : bool = Fable.Core.RustInterop.emitRustExpr () v266 
    let v268 : string = "$0"
    let v269 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v261 v268 
    let v270 : string = "std::process::Stdio::piped()"
    let v271 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v270 
    let v272 : string = "true; let mut v269 = v269"
    let v273 : bool = Fable.Core.RustInterop.emitRustExpr () v272 
    let v274 : string = "true; std::process::Command::stderr(&mut v269, std::process::Stdio::piped())"
    let v275 : bool = Fable.Core.RustInterop.emitRustExpr () v274 
    let v276 : string = "$0"
    let v277 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v269 v276 
    let v278 : string = "std::process::Stdio::piped()"
    let v279 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v278 
    let v280 : string = "true; let mut v277 = v277"
    let v281 : bool = Fable.Core.RustInterop.emitRustExpr () v280 
    let v282 : string = "true; std::process::Command::stdin(&mut v277, std::process::Stdio::piped())"
    let v283 : bool = Fable.Core.RustInterop.emitRustExpr () v282 
    let v284 : string = "$0"
    let v285 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v277 v284 
    let v288 : (string -> US5) = method6()
    let v289 : US5 option = v6 |> Option.map v288 
    let v309 : US5 = US5_1
    let v310 : US5 = v289 |> Option.defaultValue v309 
    let v324 : std_process_Command =
        match v310 with
        | US5_1 -> (* None *)
            let v321 : string = $"v285"
            let v322 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v321 
            v322
        | US5_0(v314) -> (* Some *)
            let v315 : string = "true; let mut v285 = v285"
            let v316 : bool = Fable.Core.RustInterop.emitRustExpr () v315 
            let v317 : string = "true; std::process::Command::current_dir(&mut v285, &*$0)"
            let v318 : bool = Fable.Core.RustInterop.emitRustExpr v314 v317 
            let v319 : string = $"v285"
            let v320 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v319 
            v320
    let v325 : uint64 = System.Convert.ToUInt64 v2.Length
    let v326 : bool = v325 = 0UL
    let v346 : std_process_Command =
        if v326 then
            v324
        else
            let v327 : string = "$0.to_vec()"
            let v328 : Vec<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr v2 v327 
            let v329 : string = "true; let _vec_fold_ = $0.into_iter().fold(v324, |acc, x| { //"
            let v330 : bool = Fable.Core.RustInterop.emitRustExpr v328 v329 
            let v331 : string = "acc"
            let v332 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v331 
            let v333 : string = "x"
            let struct (v334 : string, v335 : string) = Fable.Core.RustInterop.emitRustExpr () v333 
            let v336 : string = "true; let mut v332 = v332"
            let v337 : bool = Fable.Core.RustInterop.emitRustExpr () v336 
            let v338 : string = "true; std::process::Command::env(&mut v332, &*$0, &*$1)"
            let v339 : bool = Fable.Core.RustInterop.emitRustExpr struct (v334, v335) v338 
            let v340 : string = "$0"
            let v341 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v332 v340 
            let v342 : string = "true; $0 })"
            let v343 : bool = Fable.Core.RustInterop.emitRustExpr v341 v342 
            let v344 : string = "_vec_fold_"
            let v345 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v344 
            v345
    let v347 : string = "true; let mut v346 = v346"
    let v348 : bool = Fable.Core.RustInterop.emitRustExpr () v347 
    let v349 : string = "std::process::Command::spawn(&mut v346)"
    let v350 : Result<std_process_Child, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v349 
    let v351 : (std_io_Error -> std_string_String) = method63()
    (* run_target_args'
    let v353 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v354 : string = "$0.map_err(|x| $1(x))"
    let v355 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v350, v351) v354 
    let _run_target_args'_v353 = v355 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v356 : string = "$0.map_err(|x| $1(x))"
    let v357 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v350, v351) v356 
    let _run_target_args'_v353 = v357 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v358 : string = "$0.map_err(|x| $1(x))"
    let v359 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v350, v351) v358 
    let _run_target_args'_v353 = v359 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v360 : Result<std_process_Child, std_string_String> = match v350 with Ok x -> Ok x | Error x -> Error (v351 x)
    let _run_target_args'_v353 = v360 
    #endif
#if FABLE_COMPILER_PYTHON
    let v361 : Result<std_process_Child, std_string_String> = match v350 with Ok x -> Ok x | Error x -> Error (v351 x)
    let _run_target_args'_v353 = v361 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v362 : Result<std_process_Child, std_string_String> = match v350 with Ok x -> Ok x | Error x -> Error (v351 x)
    let _run_target_args'_v353 = v362 
    #endif
#else
    let v363 : Result<std_process_Child, std_string_String> = match v350 with Ok x -> Ok x | Error x -> Error (v351 x)
    let _run_target_args'_v353 = v363 
    #endif
    let v364 : Result<std_process_Child, std_string_String> = _run_target_args'_v353 
    let v367 : (std_process_Child option -> std_process_Child option) = method101()
    let v368 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v369 : bool = Fable.Core.RustInterop.emitRustExpr v364 v368 
    let v370 : string = "x"
    let v371 : std_process_Child = Fable.Core.RustInterop.emitRustExpr () v370 
    let v373 : std_process_Child option = Some v371 
    let v376 : std_process_Child option = v367 v373
    let v377 : string = "std::sync::Mutex::new(v376)"
    let v378 : std_sync_Mutex<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr () v377 
    let v379 : string = "std::sync::Arc::new(v378)"
    let v380 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr () v379 
    let v381 : string = "true; $0 })"
    let v382 : bool = Fable.Core.RustInterop.emitRustExpr v380 v381 
    let v383 : string = "_result_map_"
    let v384 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v383 
    let v385 : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US24) = method102()
    let v386 : (std_string_String -> US24) = method103()
    let v387 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
    let v388 : US24 = Fable.Core.RustInterop.emitRustExpr struct (v385, v386, v384) v387 
    let struct (v2176 : int32, v2177 : US6, v2178 : US25) =
        match v388 with
        | US24_1(v2039) -> (* Error *)
            let v2104 : unit = ()
            let v2105 : (unit -> unit) = closure45(v0, v1, v2, v3, v4, v5, v6, v29, v120, v2039)
            let v2106 : unit = (fun () -> v2105 (); v2104) ()
            let v2171 : US6 = US6_0(v2039)
            let v2172 : US25 = US25_1
            struct (-1, v2171, v2172)
        | US24_0(v389) -> (* Ok *)
            let v390 : string = "true; let _capture = (|| { //"
            let v391 : bool = Fable.Core.RustInterop.emitRustExpr () v390 
            let v392 : string = "$0"
            let v393 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v389 v392 
            let v394 : string = "v393.lock()"
            let v395 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v394 
            (* run_target_args'
            let v397 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v398 : string = "$0.unwrap()"
            let v399 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v395 v398 
            let _run_target_args'_v397 = v399 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v400 : string = "$0.unwrap()"
            let v401 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v395 v400 
            let _run_target_args'_v397 = v401 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v402 : string = "$0.unwrap()"
            let v403 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v395 v402 
            let _run_target_args'_v397 = v403 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v404 : std_sync_MutexGuard<std_process_Child option> = match v395 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v397 = v404 
            #endif
#if FABLE_COMPILER_PYTHON
            let v405 : std_sync_MutexGuard<std_process_Child option> = match v395 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v397 = v405 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v406 : std_sync_MutexGuard<std_process_Child option> = match v395 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v397 = v406 
            #endif
#else
            let v407 : std_sync_MutexGuard<std_process_Child option> = match v395 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v397 = v407 
            #endif
            let v408 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v397 
            let v411 : std_sync_MutexGuard<std_process_Child option> = method105(v408)
            let v412 : string = "true; let mut v411 = v411"
            let v413 : bool = Fable.Core.RustInterop.emitRustExpr () v412 
            let v414 : string = "&mut $0"
            let v415 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v411 v414 
            let v416 : string = "$0.as_mut()"
            let v417 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v415 v416 
            let v418 : string = "$0.unwrap()"
            let v419 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v417 v418 
            let v420 : string = "&mut $0.stdout"
            let v421 : Ref<Mut<std_process_ChildStdout option>> = Fable.Core.RustInterop.emitRustExpr v419 v420 
            let v422 : string = "Option::take($0)"
            let v423 : std_process_ChildStdout option = Fable.Core.RustInterop.emitRustExpr v421 v422 
            let v424 : string = "$0.unwrap()"
            let v425 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr v423 v424 
            let v426 : string = "true; $0 })()"
            let v427 : bool = Fable.Core.RustInterop.emitRustExpr v425 v426 
            let v428 : string = "_capture"
            let v429 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr () v428 
            let v430 : string = "true; let _capture = (|| { //"
            let v431 : bool = Fable.Core.RustInterop.emitRustExpr () v430 
            let v432 : string = "$0"
            let v433 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v389 v432 
            let v434 : string = "v433.lock()"
            let v435 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v434 
            (* run_target_args'
            let v437 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v438 : string = "$0.unwrap()"
            let v439 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v435 v438 
            let _run_target_args'_v437 = v439 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v440 : string = "$0.unwrap()"
            let v441 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v435 v440 
            let _run_target_args'_v437 = v441 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v442 : string = "$0.unwrap()"
            let v443 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v435 v442 
            let _run_target_args'_v437 = v443 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v444 : std_sync_MutexGuard<std_process_Child option> = match v435 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v437 = v444 
            #endif
#if FABLE_COMPILER_PYTHON
            let v445 : std_sync_MutexGuard<std_process_Child option> = match v435 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v437 = v445 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v446 : std_sync_MutexGuard<std_process_Child option> = match v435 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v437 = v446 
            #endif
#else
            let v447 : std_sync_MutexGuard<std_process_Child option> = match v435 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v437 = v447 
            #endif
            let v448 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v437 
            let v451 : std_sync_MutexGuard<std_process_Child option> = method105(v448)
            let v452 : string = "true; let mut v451 = v451"
            let v453 : bool = Fable.Core.RustInterop.emitRustExpr () v452 
            let v454 : string = "&mut $0"
            let v455 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v451 v454 
            let v456 : string = "$0.as_mut()"
            let v457 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v455 v456 
            let v458 : string = "$0.unwrap()"
            let v459 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v457 v458 
            let v460 : string = "&mut $0.stderr"
            let v461 : Ref<Mut<std_process_ChildStderr option>> = Fable.Core.RustInterop.emitRustExpr v459 v460 
            let v462 : string = "Option::take($0)"
            let v463 : std_process_ChildStderr option = Fable.Core.RustInterop.emitRustExpr v461 v462 
            let v464 : string = "$0.unwrap()"
            let v465 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr v463 v464 
            let v466 : string = "true; $0 })()"
            let v467 : bool = Fable.Core.RustInterop.emitRustExpr v465 v466 
            let v468 : string = "_capture"
            let v469 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr () v468 
            let v470 : string = "true; let _capture = (|| { //"
            let v471 : bool = Fable.Core.RustInterop.emitRustExpr () v470 
            let v472 : string = "$0"
            let v473 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v389 v472 
            let v474 : string = "v473.lock()"
            let v475 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v474 
            (* run_target_args'
            let v477 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v478 : string = "$0.unwrap()"
            let v479 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v475 v478 
            let _run_target_args'_v477 = v479 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v480 : string = "$0.unwrap()"
            let v481 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v475 v480 
            let _run_target_args'_v477 = v481 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v482 : string = "$0.unwrap()"
            let v483 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v475 v482 
            let _run_target_args'_v477 = v483 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v484 : std_sync_MutexGuard<std_process_Child option> = match v475 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v477 = v484 
            #endif
#if FABLE_COMPILER_PYTHON
            let v485 : std_sync_MutexGuard<std_process_Child option> = match v475 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v477 = v485 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v486 : std_sync_MutexGuard<std_process_Child option> = match v475 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v477 = v486 
            #endif
#else
            let v487 : std_sync_MutexGuard<std_process_Child option> = match v475 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v477 = v487 
            #endif
            let v488 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v477 
            let v491 : std_sync_MutexGuard<std_process_Child option> = method105(v488)
            let v492 : string = "true; let mut v491 = v491"
            let v493 : bool = Fable.Core.RustInterop.emitRustExpr () v492 
            let v494 : string = "&mut $0"
            let v495 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v491 v494 
            let v496 : string = "$0.as_mut()"
            let v497 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v495 v496 
            let v498 : string = "$0.unwrap()"
            let v499 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v497 v498 
            let v500 : string = "&mut $0.stdin"
            let v501 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v499 v500 
            let v502 : string = "Option::take($0)"
            let v503 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v501 v502 
            let v504 : string = "$0.unwrap()"
            let v505 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr v503 v504 
            let v507 : std_process_ChildStdin option = Some v505 
            let v510 : (std_process_ChildStdin option -> std_process_ChildStdin option) = method106()
            let v511 : std_process_ChildStdin option = v510 v507
            let v512 : string = "std::sync::Mutex::new(v511)"
            let v513 : std_sync_Mutex<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr () v512 
            let v514 : string = "std::sync::Arc::new(v513)"
            let v515 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v514 
            let v516 : string = "true; $0 })()"
            let v517 : bool = Fable.Core.RustInterop.emitRustExpr v515 v516 
            let v518 : string = "_capture"
            let v519 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v518 
            let v520 : string = "{ let (sender, receiver) = std::sync::mpsc::channel(); (sender, std::sync::Arc::new(receiver)) }"
            let struct (v521 : std_sync_mpsc_Sender<std_string_String>, v522 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = Fable.Core.RustInterop.emitRustExpr () v520 
            let v523 : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) = method107()
            let v524 : std_sync_mpsc_Sender<std_string_String> = v523 v521
            let v525 : string = "std::sync::Mutex::new(v524)"
            let v526 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v525 
            let v527 : string = "std::sync::Arc::new(v526)"
            let v528 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v527 
            let v529 : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) = method108()
            let v530 : std_sync_mpsc_Sender<std_string_String> = v529 v521
            let v531 : string = "std::sync::Mutex::new(v530)"
            let v532 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v531 
            let v533 : string = "std::sync::Arc::new(v532)"
            let v534 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v533 
            let v535 : (std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> -> std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = method109()
            let v536 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> = v535 v522
            let v537 : string = "std::sync::Mutex::new(v536)"
            let v538 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v537 
            let v539 : string = "std::sync::Arc::new(v538)"
            let v540 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v539 
            let v541 : string = "true; let __spawn = std::thread::spawn(move || { //"
            let v542 : bool = Fable.Core.RustInterop.emitRustExpr () v541 
            let v543 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v544 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v429 v543 
            let v545 : string = "std::io::BufReader::new($0)"
            let v546 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr v544 v545 
            let v547 : string = "std::io::BufRead::lines(v546)"
            let v548 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v547 
            let v549 : string = "true; let mut v548 = v548; let _iter_try_for_each = v548.try_for_each(|x| { //"
            let v550 : bool = Fable.Core.RustInterop.emitRustExpr () v549 
            let v551 : string = "x"
            let v552 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v551 
            let v553 : string = "$0.clone()"
            let v554 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v528 v553 
            let v555 : (std_io_Error -> std_string_String) = method63()
            (* run_target_args'
            let v557 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v558 : string = "$0.map_err(|x| $1(x))"
            let v559 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v552, v555) v558 
            let _run_target_args'_v557 = v559 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v560 : string = "$0.map_err(|x| $1(x))"
            let v561 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v552, v555) v560 
            let _run_target_args'_v557 = v561 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v562 : string = "$0.map_err(|x| $1(x))"
            let v563 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v552, v555) v562 
            let _run_target_args'_v557 = v563 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v564 : Result<std_string_String, std_string_String> = match v552 with Ok x -> Ok x | Error x -> Error (v555 x)
            let _run_target_args'_v557 = v564 
            #endif
#if FABLE_COMPILER_PYTHON
            let v565 : Result<std_string_String, std_string_String> = match v552 with Ok x -> Ok x | Error x -> Error (v555 x)
            let _run_target_args'_v557 = v565 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v566 : Result<std_string_String, std_string_String> = match v552 with Ok x -> Ok x | Error x -> Error (v555 x)
            let _run_target_args'_v557 = v566 
            #endif
#else
            let v567 : Result<std_string_String, std_string_String> = match v552 with Ok x -> Ok x | Error x -> Error (v555 x)
            let _run_target_args'_v557 = v567 
            #endif
            let v568 : Result<std_string_String, std_string_String> = _run_target_args'_v557 
            let v571 : (std_string_String -> US26) = method110()
            let v572 : (std_string_String -> US26) = method111()
            let v573 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v574 : US26 = Fable.Core.RustInterop.emitRustExpr struct (v571, v572, v568) v573 
            let v963 : std_string_String =
                match v574 with
                | US26_1(v771) -> (* Error *)
                    let v832 : unit = ()
                    let v833 : (unit -> unit) = closure51(v5, v771)
                    let v834 : unit = (fun () -> v833 (); v832) ()
                    let v895 : string = $"\u001b[4;7m{v771}\u001b[0m"
                    (* run_target_args'
                    let v900 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v901 : string = "&*$0"
                    let v902 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v895 v901 
                    let _run_target_args'_v900 = v902 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v903 : string = "&*$0"
                    let v904 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v895 v903 
                    let _run_target_args'_v900 = v904 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v905 : string = "&*$0"
                    let v906 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v895 v905 
                    let _run_target_args'_v900 = v906 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v908 : Ref<Str> = v895 |> unbox<Ref<Str>>
                    let _run_target_args'_v900 = v908 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v912 : Ref<Str> = v895 |> unbox<Ref<Str>>
                    let _run_target_args'_v900 = v912 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v916 : Ref<Str> = v895 |> unbox<Ref<Str>>
                    let _run_target_args'_v900 = v916 
                    #endif
#else
                    let v920 : Ref<Str> = v895 |> unbox<Ref<Str>>
                    let _run_target_args'_v900 = v920 
                    #endif
                    let v923 : Ref<Str> = _run_target_args'_v900 
                    (* run_target_args'
                    let v933 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v934 : string = "String::from($0)"
                    let v935 : std_string_String = Fable.Core.RustInterop.emitRustExpr v923 v934 
                    let _run_target_args'_v933 = v935 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v936 : string = "String::from($0)"
                    let v937 : std_string_String = Fable.Core.RustInterop.emitRustExpr v923 v936 
                    let _run_target_args'_v933 = v937 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v938 : string = "String::from($0)"
                    let v939 : std_string_String = Fable.Core.RustInterop.emitRustExpr v923 v938 
                    let _run_target_args'_v933 = v939 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v941 : std_string_String = v923 |> unbox<std_string_String>
                    let _run_target_args'_v933 = v941 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v945 : std_string_String = v923 |> unbox<std_string_String>
                    let _run_target_args'_v933 = v945 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v949 : std_string_String = v923 |> unbox<std_string_String>
                    let _run_target_args'_v933 = v949 
                    #endif
#else
                    let v953 : std_string_String = v923 |> unbox<std_string_String>
                    let _run_target_args'_v933 = v953 
                    #endif
                    let v956 : std_string_String = _run_target_args'_v933 
                    v956
                | US26_0(v575) -> (* Ok *)
                    let v576 : string = "fable_library_rust::String_::fromString($0)"
                    let v577 : string = Fable.Core.RustInterop.emitRustExpr v575 v576 
                    let v578 : string = "encoding_rs::UTF_8"
                    let v579 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v578 
                    let v580 : string = "$0.encode(&*$1).0"
                    let v581 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v579, v577) v580 
                    let v582 : string = "$0.as_ref()"
                    let v583 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v581 v582 
                    let v584 : string = "std::str::from_utf8($0)"
                    let v585 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr v583 v584 
                    (* run_target_args'
                    let v587 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v588 : string = "$0.unwrap()"
                    let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v585 v588 
                    let _run_target_args'_v587 = v589 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v590 : string = "$0.unwrap()"
                    let v591 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v585 v590 
                    let _run_target_args'_v587 = v591 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v592 : string = "$0.unwrap()"
                    let v593 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v585 v592 
                    let _run_target_args'_v587 = v593 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v594 : Ref<Str> = match v585 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v587 = v594 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v595 : Ref<Str> = match v585 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v587 = v595 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v596 : Ref<Str> = match v585 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v587 = v596 
                    #endif
#else
                    let v597 : Ref<Str> = match v585 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v587 = v597 
                    #endif
                    let v598 : Ref<Str> = _run_target_args'_v587 
                    (* run_target_args'
                    let v605 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v606 : string = "String::from($0)"
                    let v607 : std_string_String = Fable.Core.RustInterop.emitRustExpr v598 v606 
                    let _run_target_args'_v605 = v607 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v608 : string = "String::from($0)"
                    let v609 : std_string_String = Fable.Core.RustInterop.emitRustExpr v598 v608 
                    let _run_target_args'_v605 = v609 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v610 : string = "String::from($0)"
                    let v611 : std_string_String = Fable.Core.RustInterop.emitRustExpr v598 v610 
                    let _run_target_args'_v605 = v611 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v613 : std_string_String = v598 |> unbox<std_string_String>
                    let _run_target_args'_v605 = v613 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v617 : std_string_String = v598 |> unbox<std_string_String>
                    let _run_target_args'_v605 = v617 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v621 : std_string_String = v598 |> unbox<std_string_String>
                    let _run_target_args'_v605 = v621 
                    #endif
#else
                    let v625 : std_string_String = v598 |> unbox<std_string_String>
                    let _run_target_args'_v605 = v625 
                    #endif
                    let v628 : std_string_String = _run_target_args'_v605 
                    let v634 : string = "fable_library_rust::String_::fromString($0)"
                    let v635 : string = Fable.Core.RustInterop.emitRustExpr v628 v634 
                    let v636 : string = $"> {v635}"
                    if v5 then
                        let v700 : unit = ()
                        let v701 : (unit -> unit) = closure52(v636)
                        let v702 : unit = (fun () -> v701 (); v700) ()
                        ()
                    else
                        let v767 : unit = ()
                        let v768 : (unit -> unit) = closure11(v636)
                        let v769 : unit = (fun () -> v768 (); v767) ()
                        ()
                    v628
            let v964 : string = "$0"
            let v965 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v554 v964 
            let v966 : string = "v965.lock()"
            let v967 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v966 
            (* run_target_args'
            let v969 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v970 : string = "$0.unwrap()"
            let v971 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v967 v970 
            let _run_target_args'_v969 = v971 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v972 : string = "$0.unwrap()"
            let v973 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v967 v972 
            let _run_target_args'_v969 = v973 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v974 : string = "$0.unwrap()"
            let v975 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v967 v974 
            let _run_target_args'_v969 = v975 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v976 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v967 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v969 = v976 
            #endif
#if FABLE_COMPILER_PYTHON
            let v977 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v967 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v969 = v977 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v978 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v967 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v969 = v978 
            #endif
#else
            let v979 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v967 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v969 = v979 
            #endif
            let v980 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = _run_target_args'_v969 
            let v983 : string = "&$0"
            let v984 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v980 v983 
            let v985 : string = "$0.send($1)"
            let v986 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v984, v963) v985 
            let v987 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method115()
            (* run_target_args'
            let v989 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v990 : string = "$0.map_err(|x| $1(x))"
            let v991 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v986, v987) v990 
            let _run_target_args'_v989 = v991 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v992 : string = "$0.map_err(|x| $1(x))"
            let v993 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v986, v987) v992 
            let _run_target_args'_v989 = v993 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v994 : string = "$0.map_err(|x| $1(x))"
            let v995 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v986, v987) v994 
            let _run_target_args'_v989 = v995 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v996 : Result<unit, std_string_String> = match v986 with Ok x -> Ok x | Error x -> Error (v987 x)
            let _run_target_args'_v989 = v996 
            #endif
#if FABLE_COMPILER_PYTHON
            let v997 : Result<unit, std_string_String> = match v986 with Ok x -> Ok x | Error x -> Error (v987 x)
            let _run_target_args'_v989 = v997 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v998 : Result<unit, std_string_String> = match v986 with Ok x -> Ok x | Error x -> Error (v987 x)
            let _run_target_args'_v989 = v998 
            #endif
#else
            let v999 : Result<unit, std_string_String> = match v986 with Ok x -> Ok x | Error x -> Error (v987 x)
            let _run_target_args'_v989 = v999 
            #endif
            let v1000 : Result<unit, std_string_String> = _run_target_args'_v989 
            let v1003 : string = "$0"
            let v1004 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v1000 v1003 
            let v1005 : string = "true; $0 }); //"
            let v1006 : bool = Fable.Core.RustInterop.emitRustExpr v1004 v1005 
            let v1007 : string = "_iter_try_for_each.map_err(|x| x.into())"
            let v1008 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v1007 
            let v1009 : Result<unit, string> = method116(v1008)
            let v1010 : string = ""
            let v1011 : string = "}"
            let v1012 : string = v1010 + v1011 
            let x = v1009 //
            let v1013 : _ = x
            let v1014 : unit = ()
            (* run_target_args'
            let v1015 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1016 : string = $"true; let _fix_closure_v1014 = $0"
            let v1017 : bool = Fable.Core.RustInterop.emitRustExpr v1013 v1016 
            let _run_target_args'_v1015 = true 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1018 : string = $"true; let _fix_closure_v1014 = $0"
            let v1019 : bool = Fable.Core.RustInterop.emitRustExpr v1013 v1018 
            let _run_target_args'_v1015 = true 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1020 : string = $"true; let _fix_closure_v1014 = $0"
            let v1021 : bool = Fable.Core.RustInterop.emitRustExpr v1013 v1020 
            let _run_target_args'_v1015 = true 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let _run_target_args'_v1015 = false 
            #endif
#if FABLE_COMPILER_PYTHON
            let _run_target_args'_v1015 = false 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let _run_target_args'_v1015 = false 
            #endif
#else
            let _run_target_args'_v1015 = false 
            #endif
            let v1022 : bool = _run_target_args'_v1015 
            let v1024 : string = $"true; _fix_closure_v1014 " + v1012 + "); " + v1010 + " // rust.fix_closure'"
            let v1025 : bool = Fable.Core.RustInterop.emitRustExpr () v1024 
            let v1026 : string = "__spawn"
            let v1027 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v1026 
            let v1028 : string = "true; let __spawn = std::thread::spawn(move || { //"
            let v1029 : bool = Fable.Core.RustInterop.emitRustExpr () v1028 
            let v1030 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v1031 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v469 v1030 
            let v1032 : string = "std::io::BufReader::new($0)"
            let v1033 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr v1031 v1032 
            let v1034 : string = "std::io::BufRead::lines(v1033)"
            let v1035 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v1034 
            let v1036 : string = "true; let mut v1035 = v1035; let _iter_try_for_each = v1035.try_for_each(|x| { //"
            let v1037 : bool = Fable.Core.RustInterop.emitRustExpr () v1036 
            let v1038 : string = "x"
            let v1039 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v1038 
            let v1040 : string = "$0.clone()"
            let v1041 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v534 v1040 
            let v1042 : (std_io_Error -> std_string_String) = method63()
            (* run_target_args'
            let v1044 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1045 : string = "$0.map_err(|x| $1(x))"
            let v1046 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1039, v1042) v1045 
            let _run_target_args'_v1044 = v1046 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1047 : string = "$0.map_err(|x| $1(x))"
            let v1048 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1039, v1042) v1047 
            let _run_target_args'_v1044 = v1048 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1049 : string = "$0.map_err(|x| $1(x))"
            let v1050 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1039, v1042) v1049 
            let _run_target_args'_v1044 = v1050 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1051 : Result<std_string_String, std_string_String> = match v1039 with Ok x -> Ok x | Error x -> Error (v1042 x)
            let _run_target_args'_v1044 = v1051 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1052 : Result<std_string_String, std_string_String> = match v1039 with Ok x -> Ok x | Error x -> Error (v1042 x)
            let _run_target_args'_v1044 = v1052 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1053 : Result<std_string_String, std_string_String> = match v1039 with Ok x -> Ok x | Error x -> Error (v1042 x)
            let _run_target_args'_v1044 = v1053 
            #endif
#else
            let v1054 : Result<std_string_String, std_string_String> = match v1039 with Ok x -> Ok x | Error x -> Error (v1042 x)
            let _run_target_args'_v1044 = v1054 
            #endif
            let v1055 : Result<std_string_String, std_string_String> = _run_target_args'_v1044 
            let v1058 : (std_string_String -> US26) = method110()
            let v1059 : (std_string_String -> US26) = method111()
            let v1060 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v1061 : US26 = Fable.Core.RustInterop.emitRustExpr struct (v1058, v1059, v1055) v1060 
            let v1515 : std_string_String =
                match v1061 with
                | US26_1(v1323) -> (* Error *)
                    let v1384 : unit = ()
                    let v1385 : (unit -> unit) = closure51(v5, v1323)
                    let v1386 : unit = (fun () -> v1385 (); v1384) ()
                    let v1447 : string = $"\u001b[4;7m{v1323}\u001b[0m"
                    (* run_target_args'
                    let v1452 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1453 : string = "&*$0"
                    let v1454 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1447 v1453 
                    let _run_target_args'_v1452 = v1454 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1455 : string = "&*$0"
                    let v1456 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1447 v1455 
                    let _run_target_args'_v1452 = v1456 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1457 : string = "&*$0"
                    let v1458 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1447 v1457 
                    let _run_target_args'_v1452 = v1458 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1460 : Ref<Str> = v1447 |> unbox<Ref<Str>>
                    let _run_target_args'_v1452 = v1460 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1464 : Ref<Str> = v1447 |> unbox<Ref<Str>>
                    let _run_target_args'_v1452 = v1464 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1468 : Ref<Str> = v1447 |> unbox<Ref<Str>>
                    let _run_target_args'_v1452 = v1468 
                    #endif
#else
                    let v1472 : Ref<Str> = v1447 |> unbox<Ref<Str>>
                    let _run_target_args'_v1452 = v1472 
                    #endif
                    let v1475 : Ref<Str> = _run_target_args'_v1452 
                    (* run_target_args'
                    let v1485 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1486 : string = "String::from($0)"
                    let v1487 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1475 v1486 
                    let _run_target_args'_v1485 = v1487 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1488 : string = "String::from($0)"
                    let v1489 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1475 v1488 
                    let _run_target_args'_v1485 = v1489 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1490 : string = "String::from($0)"
                    let v1491 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1475 v1490 
                    let _run_target_args'_v1485 = v1491 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1493 : std_string_String = v1475 |> unbox<std_string_String>
                    let _run_target_args'_v1485 = v1493 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1497 : std_string_String = v1475 |> unbox<std_string_String>
                    let _run_target_args'_v1485 = v1497 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1501 : std_string_String = v1475 |> unbox<std_string_String>
                    let _run_target_args'_v1485 = v1501 
                    #endif
#else
                    let v1505 : std_string_String = v1475 |> unbox<std_string_String>
                    let _run_target_args'_v1485 = v1505 
                    #endif
                    let v1508 : std_string_String = _run_target_args'_v1485 
                    v1508
                | US26_0(v1062) -> (* Ok *)
                    let v1063 : string = "fable_library_rust::String_::fromString($0)"
                    let v1064 : string = Fable.Core.RustInterop.emitRustExpr v1062 v1063 
                    let v1065 : string = "encoding_rs::UTF_8"
                    let v1066 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v1065 
                    let v1067 : string = "$0.encode(&*$1).0"
                    let v1068 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v1066, v1064) v1067 
                    let v1069 : string = "$0.as_ref()"
                    let v1070 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v1068 v1069 
                    let v1071 : string = "std::str::from_utf8($0)"
                    let v1072 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr v1070 v1071 
                    (* run_target_args'
                    let v1074 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1075 : string = "$0.unwrap()"
                    let v1076 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1072 v1075 
                    let _run_target_args'_v1074 = v1076 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1077 : string = "$0.unwrap()"
                    let v1078 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1072 v1077 
                    let _run_target_args'_v1074 = v1078 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1079 : string = "$0.unwrap()"
                    let v1080 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1072 v1079 
                    let _run_target_args'_v1074 = v1080 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1081 : Ref<Str> = match v1072 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1074 = v1081 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1082 : Ref<Str> = match v1072 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1074 = v1082 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1083 : Ref<Str> = match v1072 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1074 = v1083 
                    #endif
#else
                    let v1084 : Ref<Str> = match v1072 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1074 = v1084 
                    #endif
                    let v1085 : Ref<Str> = _run_target_args'_v1074 
                    (* run_target_args'
                    let v1092 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1093 : string = "String::from($0)"
                    let v1094 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1085 v1093 
                    let _run_target_args'_v1092 = v1094 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1095 : string = "String::from($0)"
                    let v1096 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1085 v1095 
                    let _run_target_args'_v1092 = v1096 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1097 : string = "String::from($0)"
                    let v1098 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1085 v1097 
                    let _run_target_args'_v1092 = v1098 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1100 : std_string_String = v1085 |> unbox<std_string_String>
                    let _run_target_args'_v1092 = v1100 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1104 : std_string_String = v1085 |> unbox<std_string_String>
                    let _run_target_args'_v1092 = v1104 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1108 : std_string_String = v1085 |> unbox<std_string_String>
                    let _run_target_args'_v1092 = v1108 
                    #endif
#else
                    let v1112 : std_string_String = v1085 |> unbox<std_string_String>
                    let _run_target_args'_v1092 = v1112 
                    #endif
                    let v1115 : std_string_String = _run_target_args'_v1092 
                    let v1121 : string = "fable_library_rust::String_::fromString($0)"
                    let v1122 : string = Fable.Core.RustInterop.emitRustExpr v1115 v1121 
                    let v1123 : string = $"! {v1122}"
                    if v5 then
                        let v1186 : unit = ()
                        let v1187 : (unit -> unit) = closure52(v1123)
                        let v1188 : unit = (fun () -> v1187 (); v1186) ()
                        ()
                    else
                        let v1252 : unit = ()
                        let v1253 : (unit -> unit) = closure11(v1123)
                        let v1254 : unit = (fun () -> v1253 (); v1252) ()
                        ()
                    let v1256 : string = $"\u001b[4;7m{v1115}\u001b[0m"
                    (* run_target_args'
                    let v1261 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1262 : string = "&*$0"
                    let v1263 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1256 v1262 
                    let _run_target_args'_v1261 = v1263 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1264 : string = "&*$0"
                    let v1265 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1256 v1264 
                    let _run_target_args'_v1261 = v1265 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1266 : string = "&*$0"
                    let v1267 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1256 v1266 
                    let _run_target_args'_v1261 = v1267 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1269 : Ref<Str> = v1256 |> unbox<Ref<Str>>
                    let _run_target_args'_v1261 = v1269 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1273 : Ref<Str> = v1256 |> unbox<Ref<Str>>
                    let _run_target_args'_v1261 = v1273 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1277 : Ref<Str> = v1256 |> unbox<Ref<Str>>
                    let _run_target_args'_v1261 = v1277 
                    #endif
#else
                    let v1281 : Ref<Str> = v1256 |> unbox<Ref<Str>>
                    let _run_target_args'_v1261 = v1281 
                    #endif
                    let v1284 : Ref<Str> = _run_target_args'_v1261 
                    (* run_target_args'
                    let v1294 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1295 : string = "String::from($0)"
                    let v1296 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1284 v1295 
                    let _run_target_args'_v1294 = v1296 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1297 : string = "String::from($0)"
                    let v1298 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1284 v1297 
                    let _run_target_args'_v1294 = v1298 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1299 : string = "String::from($0)"
                    let v1300 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1284 v1299 
                    let _run_target_args'_v1294 = v1300 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1302 : std_string_String = v1284 |> unbox<std_string_String>
                    let _run_target_args'_v1294 = v1302 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1306 : std_string_String = v1284 |> unbox<std_string_String>
                    let _run_target_args'_v1294 = v1306 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1310 : std_string_String = v1284 |> unbox<std_string_String>
                    let _run_target_args'_v1294 = v1310 
                    #endif
#else
                    let v1314 : std_string_String = v1284 |> unbox<std_string_String>
                    let _run_target_args'_v1294 = v1314 
                    #endif
                    let v1317 : std_string_String = _run_target_args'_v1294 
                    v1317
            let v1516 : string = "$0"
            let v1517 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v1041 v1516 
            let v1518 : string = "v1517.lock()"
            let v1519 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v1518 
            (* run_target_args'
            let v1521 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1522 : string = "$0.unwrap()"
            let v1523 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1519 v1522 
            let _run_target_args'_v1521 = v1523 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1524 : string = "$0.unwrap()"
            let v1525 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1519 v1524 
            let _run_target_args'_v1521 = v1525 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1526 : string = "$0.unwrap()"
            let v1527 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1519 v1526 
            let _run_target_args'_v1521 = v1527 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1528 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1519 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1521 = v1528 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1529 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1519 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1521 = v1529 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1530 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1519 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1521 = v1530 
            #endif
#else
            let v1531 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1519 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1521 = v1531 
            #endif
            let v1532 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = _run_target_args'_v1521 
            let v1535 : string = "&$0"
            let v1536 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1532 v1535 
            let v1537 : string = "$0.send($1)"
            let v1538 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v1536, v1515) v1537 
            let v1539 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method115()
            (* run_target_args'
            let v1541 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1542 : string = "$0.map_err(|x| $1(x))"
            let v1543 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1538, v1539) v1542 
            let _run_target_args'_v1541 = v1543 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1544 : string = "$0.map_err(|x| $1(x))"
            let v1545 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1538, v1539) v1544 
            let _run_target_args'_v1541 = v1545 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1546 : string = "$0.map_err(|x| $1(x))"
            let v1547 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1538, v1539) v1546 
            let _run_target_args'_v1541 = v1547 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1548 : Result<unit, std_string_String> = match v1538 with Ok x -> Ok x | Error x -> Error (v1539 x)
            let _run_target_args'_v1541 = v1548 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1549 : Result<unit, std_string_String> = match v1538 with Ok x -> Ok x | Error x -> Error (v1539 x)
            let _run_target_args'_v1541 = v1549 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1550 : Result<unit, std_string_String> = match v1538 with Ok x -> Ok x | Error x -> Error (v1539 x)
            let _run_target_args'_v1541 = v1550 
            #endif
#else
            let v1551 : Result<unit, std_string_String> = match v1538 with Ok x -> Ok x | Error x -> Error (v1539 x)
            let _run_target_args'_v1541 = v1551 
            #endif
            let v1552 : Result<unit, std_string_String> = _run_target_args'_v1541 
            let v1555 : string = "$0"
            let v1556 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v1552 v1555 
            let v1557 : string = "true; $0 }); //"
            let v1558 : bool = Fable.Core.RustInterop.emitRustExpr v1556 v1557 
            let v1559 : string = "_iter_try_for_each.map_err(|x| x.into())"
            let v1560 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v1559 
            let v1561 : Result<unit, string> = method116(v1560)
            let v1562 : string = v1010 + v1011 
            let x = v1561 //
            let v1563 : _ = x
            let v1564 : unit = ()
            (* run_target_args'
            let v1565 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1566 : string = $"true; let _fix_closure_v1564 = $0"
            let v1567 : bool = Fable.Core.RustInterop.emitRustExpr v1563 v1566 
            let _run_target_args'_v1565 = true 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1568 : string = $"true; let _fix_closure_v1564 = $0"
            let v1569 : bool = Fable.Core.RustInterop.emitRustExpr v1563 v1568 
            let _run_target_args'_v1565 = true 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1570 : string = $"true; let _fix_closure_v1564 = $0"
            let v1571 : bool = Fable.Core.RustInterop.emitRustExpr v1563 v1570 
            let _run_target_args'_v1565 = true 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let _run_target_args'_v1565 = false 
            #endif
#if FABLE_COMPILER_PYTHON
            let _run_target_args'_v1565 = false 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let _run_target_args'_v1565 = false 
            #endif
#else
            let _run_target_args'_v1565 = false 
            #endif
            let v1572 : bool = _run_target_args'_v1565 
            let v1574 : string = $"true; _fix_closure_v1564 " + v1562 + "); " + v1010 + " // rust.fix_closure'"
            let v1575 : bool = Fable.Core.RustInterop.emitRustExpr () v1574 
            let v1576 : string = "__spawn"
            let v1577 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v1576 
            let v1580 : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US27) = method117()
            let v1581 : US27 option = v4 |> Option.map v1580 
            let v1601 : US27 = US27_1
            let v1602 : US27 = v1581 |> Option.defaultValue v1601 
            match v1602 with
            | US27_1 -> (* None *)
                ()
            | US27_0(v1606) -> (* Some *)
                let v1607 : string = "$0"
                let v1608 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v519 v1607 
                let v1609 : string = "v1608.lock()"
                let v1610 : Result<std_sync_MutexGuard<std_process_ChildStdin option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin option>>> = Fable.Core.RustInterop.emitRustExpr () v1609 
                (* run_target_args'
                let v1612 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1613 : string = "$0.unwrap()"
                let v1614 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1610 v1613 
                let _run_target_args'_v1612 = v1614 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1615 : string = "$0.unwrap()"
                let v1616 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1610 v1615 
                let _run_target_args'_v1612 = v1616 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1617 : string = "$0.unwrap()"
                let v1618 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1610 v1617 
                let _run_target_args'_v1612 = v1618 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1619 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1610 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1612 = v1619 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1620 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1610 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1612 = v1620 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v1621 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1610 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1612 = v1621 
                #endif
#else
                let v1622 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1610 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1612 = v1622 
                #endif
                let v1623 : std_sync_MutexGuard<std_process_ChildStdin option> = _run_target_args'_v1612 
                let v1626 : std_sync_MutexGuard<std_process_ChildStdin option> = method118(v1623)
                let v1627 : string = "true; let mut v1626 = v1626"
                let v1628 : bool = Fable.Core.RustInterop.emitRustExpr () v1627 
                let v1629 : string = "&mut $0"
                let v1630 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v1626 v1629 
                let v1631 : string = "Option::take($0)"
                let v1632 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v1630 v1631 
                let v1633 : string = "true; let _optionm_map_ = $0.map(|x| { //"
                let v1634 : bool = Fable.Core.RustInterop.emitRustExpr v1632 v1633 
                let v1635 : string = "x"
                let v1636 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr () v1635 
                let v1637 : string = "std::sync::Mutex::new(v1636)"
                let v1638 : std_sync_Mutex<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr () v1637 
                let v1639 : string = "std::sync::Arc::new(v1638)"
                let v1640 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr () v1639 
                let v1641 : string = "true; $0 })"
                let v1642 : bool = Fable.Core.RustInterop.emitRustExpr v1640 v1641 
                let v1643 : string = "_optionm_map_"
                let v1644 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> option = Fable.Core.RustInterop.emitRustExpr () v1643 
                let v1647 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US28) = method119()
                let v1648 : US28 option = v1644 |> Option.map v1647 
                let v1668 : US28 = US28_1
                let v1669 : US28 = v1648 |> Option.defaultValue v1668 
                match v1669 with
                | US28_1 -> (* None *)
                    ()
                | US28_0(v1673) -> (* Some *)
                    v1606 v1673
                    let v1674 : string = "$0"
                    let v1675 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr v1673 v1674 
                    let v1676 : string = "v1675.lock()"
                    let v1677 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr () v1676 
                    (* run_target_args'
                    let v1679 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1680 : string = "$0.unwrap()"
                    let v1681 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1677 v1680 
                    let _run_target_args'_v1679 = v1681 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1682 : string = "$0.unwrap()"
                    let v1683 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1677 v1682 
                    let _run_target_args'_v1679 = v1683 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1684 : string = "$0.unwrap()"
                    let v1685 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1677 v1684 
                    let _run_target_args'_v1679 = v1685 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1686 : std_sync_MutexGuard<std_process_ChildStdin> = match v1677 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1679 = v1686 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1687 : std_sync_MutexGuard<std_process_ChildStdin> = match v1677 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1679 = v1687 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1688 : std_sync_MutexGuard<std_process_ChildStdin> = match v1677 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1679 = v1688 
                    #endif
#else
                    let v1689 : std_sync_MutexGuard<std_process_ChildStdin> = match v1677 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1679 = v1689 
                    #endif
                    let v1690 : std_sync_MutexGuard<std_process_ChildStdin> = _run_target_args'_v1679 
                    let v1693 : std_sync_MutexGuard<std_process_ChildStdin> = method120(v1690)
                    let v1694 : string = "true; let mut v1693 = v1693"
                    let v1695 : bool = Fable.Core.RustInterop.emitRustExpr () v1694 
                    let v1696 : string = "true; std::io::Write::flush(&mut *$0).unwrap()"
                    let v1697 : bool = Fable.Core.RustInterop.emitRustExpr v1693 v1696 
                    ()
            let v1698 : string = "$0"
            let v1699 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v389 v1698 
            let v1700 : string = "v1699.lock()"
            let v1701 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v1700 
            (* run_target_args'
            let v1703 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1704 : string = "$0.unwrap()"
            let v1705 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1701 v1704 
            let _run_target_args'_v1703 = v1705 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1706 : string = "$0.unwrap()"
            let v1707 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1701 v1706 
            let _run_target_args'_v1703 = v1707 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1708 : string = "$0.unwrap()"
            let v1709 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1701 v1708 
            let _run_target_args'_v1703 = v1709 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1710 : std_sync_MutexGuard<std_process_Child option> = match v1701 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1703 = v1710 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1711 : std_sync_MutexGuard<std_process_Child option> = match v1701 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1703 = v1711 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1712 : std_sync_MutexGuard<std_process_Child option> = match v1701 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1703 = v1712 
            #endif
#else
            let v1713 : std_sync_MutexGuard<std_process_Child option> = match v1701 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1703 = v1713 
            #endif
            let v1714 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v1703 
            let v1717 : std_sync_MutexGuard<std_process_Child option> = method105(v1714)
            let v1718 : string = "true; let mut v1717 = v1717"
            let v1719 : bool = Fable.Core.RustInterop.emitRustExpr () v1718 
            let v1720 : string = "&mut $0"
            let v1721 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v1717 v1720 
            let v1722 : string = "Option::take($0)"
            let v1723 : std_process_Child option = Fable.Core.RustInterop.emitRustExpr v1721 v1722 
            let v1724 : string = "$0.unwrap()"
            let v1725 : std_process_Child = Fable.Core.RustInterop.emitRustExpr v1723 v1724 
            let v1726 : string = "$0.wait_with_output()"
            let v1727 : Result<std_process_Output, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1725 v1726 
            let v1728 : (std_io_Error -> std_string_String) = method63()
            (* run_target_args'
            let v1730 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1731 : string = "$0.map_err(|x| $1(x))"
            let v1732 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1727, v1728) v1731 
            let _run_target_args'_v1730 = v1732 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1733 : string = "$0.map_err(|x| $1(x))"
            let v1734 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1727, v1728) v1733 
            let _run_target_args'_v1730 = v1734 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1735 : string = "$0.map_err(|x| $1(x))"
            let v1736 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1727, v1728) v1735 
            let _run_target_args'_v1730 = v1736 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1737 : Result<std_process_Output, std_string_String> = match v1727 with Ok x -> Ok x | Error x -> Error (v1728 x)
            let _run_target_args'_v1730 = v1737 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1738 : Result<std_process_Output, std_string_String> = match v1727 with Ok x -> Ok x | Error x -> Error (v1728 x)
            let _run_target_args'_v1730 = v1738 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1739 : Result<std_process_Output, std_string_String> = match v1727 with Ok x -> Ok x | Error x -> Error (v1728 x)
            let _run_target_args'_v1730 = v1739 
            #endif
#else
            let v1740 : Result<std_process_Output, std_string_String> = match v1727 with Ok x -> Ok x | Error x -> Error (v1728 x)
            let _run_target_args'_v1730 = v1740 
            #endif
            let v1741 : Result<std_process_Output, std_string_String> = _run_target_args'_v1730 
            let v1744 : string = "v1577"
            let v1745 : string = v1744 + v1010 
            let v1746 : string = v1745 + v1010 
            let v1747 : string = "v1027"
            let v1748 : string = ", "
            let v1749 : string = v1747 + v1748 
            let v1750 : string = v1749 + v1746 
            let v1751 : string = "vec![" + v1750 + "]"
            let v1752 : Vec<std_thread_JoinHandle<Result<unit, string>>> = Fable.Core.RustInterop.emitRustExpr () v1751 
            let v1753 : string = "true; $0.into_iter().for_each(|x| { //"
            let v1754 : bool = Fable.Core.RustInterop.emitRustExpr v1752 v1753 
            let v1755 : string = "x"
            let v1756 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v1755 
            let v1757 : string = "std::thread::JoinHandle::join($0)"
            let v1758 : Result<Result<unit, string>, Box<LifetimeRef<Dyn<LifetimeJoin<core_any_Any, LifetimeRef<LifetimeJoin<StaticLifetime, Send<StaticLifetime>>>>>>>> = Fable.Core.RustInterop.emitRustExpr v1756 v1757 
            (* run_target_args'
            let v1760 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1761 : string = "$0.unwrap()"
            let v1762 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1758 v1761 
            let _run_target_args'_v1760 = v1762 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1763 : string = "$0.unwrap()"
            let v1764 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1758 v1763 
            let _run_target_args'_v1760 = v1764 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1765 : string = "$0.unwrap()"
            let v1766 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1758 v1765 
            let _run_target_args'_v1760 = v1766 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1767 : Result<unit, string> = match v1758 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1760 = v1767 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1768 : Result<unit, string> = match v1758 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1760 = v1768 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1769 : Result<unit, string> = match v1758 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1760 = v1769 
            #endif
#else
            let v1770 : Result<unit, string> = match v1758 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1760 = v1770 
            #endif
            let v1771 : Result<unit, string> = _run_target_args'_v1760 
            (* run_target_args'
            let v1774 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1775 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1771 v1775 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1776 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1771 v1776 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1777 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1771 v1777 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            match v1771 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#if FABLE_COMPILER_PYTHON
            match v1771 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            match v1771 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#else
            match v1771 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
            // run_target_args' is_unit
            let v1778 : string = $"true"
            let v1779 : bool = Fable.Core.RustInterop.emitRustExpr () v1778 
            let v1780 : string = "true; }}); { //"
            let v1781 : bool = Fable.Core.RustInterop.emitRustExpr () v1780 
            let v1782 : (std_process_Output -> US29) = method121()
            let v1783 : (std_string_String -> US29) = method122()
            let v1785 : US29 = match v1741 with Ok x -> v1782 x | Error x -> v1783 x
            match v1785 with
            | US29_1(v1899) -> (* Error *)
                let v1964 : unit = ()
                let v1965 : (unit -> unit) = closure58(v0, v1, v2, v3, v4, v5, v6, v29, v120, v1899)
                let v1966 : unit = (fun () -> v1965 (); v1964) ()
                let v2031 : US6 = US6_0(v1899)
                let v2032 : US25 = US25_1
                struct (-2, v2031, v2032)
            | US29_0(v1788) -> (* Ok *)
                let v1789 : string = "$0.status"
                let v1790 : std_process_ExitStatus = Fable.Core.RustInterop.emitRustExpr v1788 v1789 
                let v1791 : string = "$0.code()"
                let v1792 : int32 option = Fable.Core.RustInterop.emitRustExpr v1790 v1791 
                let v1795 : (int32 -> US30) = method124()
                let v1796 : US30 option = v1792 |> Option.map v1795 
                let v1816 : US30 = US30_1
                let v1817 : US30 = v1796 |> Option.defaultValue v1816 
                match v1817 with
                | US30_1 -> (* None *)
                    let v1824 : string = "runtime.execute_with_options / exit_code=None"
                    (* run_target_args'
                    let v1829 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1830 : string = "&*$0"
                    let v1831 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1824 v1830 
                    let _run_target_args'_v1829 = v1831 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1832 : string = "&*$0"
                    let v1833 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1824 v1832 
                    let _run_target_args'_v1829 = v1833 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1834 : string = "&*$0"
                    let v1835 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1824 v1834 
                    let _run_target_args'_v1829 = v1835 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1837 : Ref<Str> = v1824 |> unbox<Ref<Str>>
                    let _run_target_args'_v1829 = v1837 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1841 : Ref<Str> = v1824 |> unbox<Ref<Str>>
                    let _run_target_args'_v1829 = v1841 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1845 : Ref<Str> = v1824 |> unbox<Ref<Str>>
                    let _run_target_args'_v1829 = v1845 
                    #endif
#else
                    let v1849 : Ref<Str> = v1824 |> unbox<Ref<Str>>
                    let _run_target_args'_v1829 = v1849 
                    #endif
                    let v1852 : Ref<Str> = _run_target_args'_v1829 
                    (* run_target_args'
                    let v1862 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1863 : string = "String::from($0)"
                    let v1864 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1852 v1863 
                    let _run_target_args'_v1862 = v1864 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1865 : string = "String::from($0)"
                    let v1866 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1852 v1865 
                    let _run_target_args'_v1862 = v1866 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1867 : string = "String::from($0)"
                    let v1868 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1852 v1867 
                    let _run_target_args'_v1862 = v1868 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1870 : std_string_String = v1852 |> unbox<std_string_String>
                    let _run_target_args'_v1862 = v1870 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1874 : std_string_String = v1852 |> unbox<std_string_String>
                    let _run_target_args'_v1862 = v1874 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1878 : std_string_String = v1852 |> unbox<std_string_String>
                    let _run_target_args'_v1862 = v1878 
                    #endif
#else
                    let v1882 : std_string_String = v1852 |> unbox<std_string_String>
                    let _run_target_args'_v1862 = v1882 
                    #endif
                    let v1885 : std_string_String = _run_target_args'_v1862 
                    let v1891 : US6 = US6_0(v1885)
                    let v1892 : US25 = US25_0(v540)
                    struct (-1, v1891, v1892)
                | US30_0(v1821) -> (* Some *)
                    let v1822 : US6 = US6_1
                    let v1823 : US25 = US25_0(v540)
                    struct (v1821, v1822, v1823)
    let v2189 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option =
        match v2178 with
        | US25_1 -> (* None *)
            let v2185 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = None
            v2185
        | US25_0(v2179) -> (* Some *)
            let v2181 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = Some v2179 
            v2181
    let v2190 : string = "true; let _optionm_map_ = $0.map(|x| { //"
    let v2191 : bool = Fable.Core.RustInterop.emitRustExpr v2189 v2190 
    let v2192 : string = "x"
    let v2193 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v2192 
    let v2194 : string = "$0"
    let v2195 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr v2193 v2194 
    let v2196 : string = "v2195.lock()"
    let v2197 : Result<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v2196 
    (* run_target_args'
    let v2199 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2200 : string = "$0.unwrap()"
    let v2201 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v2197 v2200 
    let _run_target_args'_v2199 = v2201 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2202 : string = "$0.unwrap()"
    let v2203 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v2197 v2202 
    let _run_target_args'_v2199 = v2203 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2204 : string = "$0.unwrap()"
    let v2205 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v2197 v2204 
    let _run_target_args'_v2199 = v2205 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2206 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v2197 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v2199 = v2206 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2207 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v2197 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v2199 = v2207 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v2208 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v2197 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v2199 = v2208 
    #endif
#else
    let v2209 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v2197 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v2199 = v2209 
    #endif
    let v2210 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = _run_target_args'_v2199 
    let v2213 : string = "$0.iter()"
    let v2214 : _ = Fable.Core.RustInterop.emitRustExpr v2210 v2213 
    let v2215 : string = "$0.collect::<Vec<_>>()"
    let v2216 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v2214 v2215 
    let v2217 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v2218 : bool = Fable.Core.RustInterop.emitRustExpr v2216 v2217 
    let v2219 : string = "x"
    let v2220 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2219 
    let v2221 : string = "fable_library_rust::String_::fromString($0)"
    let v2222 : string = Fable.Core.RustInterop.emitRustExpr v2220 v2221 
    let v2223 : string = "true; $0 }).collect::<Vec<_>>()"
    let v2224 : bool = Fable.Core.RustInterop.emitRustExpr v2222 v2223 
    let v2225 : string = "_vec_map"
    let v2226 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v2225 
    let v2227 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v2228 : (string []) = Fable.Core.RustInterop.emitRustExpr v2226 v2227 
    let v2230 : string seq = v2228 |> Seq.ofArray
    let v2235 : string = method125()
    let v2236 : (string -> (string seq -> string)) = String.concat
    let v2237 : (string seq -> string) = v2236 v2235
    let v2238 : string = v2237 v2230
    let v2242 : string = "true; $0 })"
    let v2243 : bool = Fable.Core.RustInterop.emitRustExpr v2238 v2242 
    let v2244 : string = "_optionm_map_"
    let v2245 : string option = Fable.Core.RustInterop.emitRustExpr () v2244 
    let v2252 : US5 =
        match v2177 with
        | US6_1 -> (* None *)
            US5_1
        | US6_0(v2246) -> (* Some *)
            let v2247 : string = "fable_library_rust::String_::fromString($0)"
            let v2248 : string = Fable.Core.RustInterop.emitRustExpr v2246 v2247 
            US5_0(v2248)
    let v2256 : string =
        match v2252 with
        | US5_1 -> (* None *)
            let v2254 : string = ""
            v2254
        | US5_0(v2253) -> (* Some *)
            v2253
    let v2258 : string = v2245 |> Option.defaultValue v2256 
    let v2322 : unit = ()
    let v2323 : (unit -> unit) = closure60(v2176, v2258)
    let v2324 : unit = (fun () -> v2323 (); v2322) ()
    let v2387 : (int32 * string) = v2176, v2258 
    v2387 
    )
    |> fun x -> x ()
    ) () )
    |> fun x -> _capture_v253 <- Some x
    let v2390 : (int32 * string) = match _capture_v253 with Some x -> x | None -> failwith "base.capture / _capture_v253=None"
    let (a, b) = v2390 
    let v4528 : int32 = a
    let v4529 : string = b
    let _run_target_args'_v15 = struct (v4528, v4529) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v4536 : int32, v4537 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v4536, v4537) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v4544 : int32, v4545 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v4544, v4545) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v4552 : int32, v4553 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v4552, v4553) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v4560 : int32, v4561 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v4560, v4561) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v4568 : int32, v4569 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v4568, v4569) 
    #endif
#else
    let v4574 : Async<struct (int32 * string)> = method127(v0, v1, v2, v3, v4, v5, v6)
    (* run_target_args'
    let v4583 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v4586 : int32, v4587 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v4583 = struct (v4586, v4587) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v4594 : int32, v4595 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v4583 = struct (v4594, v4595) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v4602 : int32, v4603 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v4583 = struct (v4602, v4603) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v4610 : int32, v4611 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v4583 = struct (v4610, v4611) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v4616 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v4617 : int32, v4618 : string) = v4616 v4574
    let _run_target_args'_v4583 = struct (v4617, v4618) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v4619 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v4620 : int32, v4621 : string) = v4619 v4574
    let _run_target_args'_v4583 = struct (v4620, v4621) 
    #endif
#else
    let v4622 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v4623 : int32, v4624 : string) = v4622 v4574
    let _run_target_args'_v4583 = struct (v4623, v4624) 
    #endif
    let struct (v4625 : int32, v4626 : string) = _run_target_args'_v4583 
    let _run_target_args'_v15 = struct (v4625, v4626) 
    #endif
    let struct (v4631 : int32, v4632 : string) = _run_target_args'_v15 
    struct (v4631, v4632)
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
    let v252 : string = $"{v245}"
    let v260 : unit = ()
    let v261 : (unit -> unit) = closure8(v12, v252)
    let v262 : unit = (fun () -> v261 (); v260) ()
    let v270 : string = " }"
    let v271 : string = $"{v270}"
    let v279 : unit = ()
    let v280 : (unit -> unit) = closure8(v12, v271)
    let v281 : unit = (fun () -> v280 (); v279) ()
    let v287 : string = v12.l0
    let v288 : int64 = v0.l0
    let v291 : string = " "
    let v292 : string = v6 + v291 
    let v296 : string = v292 + v7 
    let v301 : string = " #"
    let v302 : string = v296 + v301 
    let v306 : (int64 -> string) = _.ToString()
    let v307 : string = v306 v288
    let v311 : string = v302 + v307 
    let v315 : string = v311 + v291 
    let v320 : string = "file_system.file_copy"
    let v321 : string = v315 + v320 
    let v326 : string = " / "
    let v327 : string = v321 + v326 
    let v331 : string = v327 + v287 
    method16(v331)
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
    let v60 : Vec<uint8> = method154(v54)
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
    let v114 : string = "\n"
    let v115 : (string []) = v101.Split v114 
    let v118 : int32 = v115.Length
    let v119 : (string []) = Array.zeroCreate<string> (v118)
    let v120 : Mut6 = {l0 = 0} : Mut6
    while method58(v118, v120) do
        let v122 : int32 = v120.l0
        let v123 : string = v115.[int v122]
        let v125 : (unit -> string) = v123.Trim
        let v126 : string = v125 ()
        v119.[int v122] <- v126
        let v129 : int32 = v122 + 1
        v120.l0 <- v129
        ()
    let v130 : int32 = v119.Length
    let v131 : (string []) = Array.zeroCreate<string> (v130)
    let v132 : Mut7 = {l0 = 0; l1 = 0} : Mut7
    while method155(v130, v132) do
        let v134 : int32 = v132.l0
        let v135 : int32 = v132.l1
        let v136 : string = v119.[int v134]
        let v139 : string = ""
        let v140 : bool = v136 <> v139 
        let v144 : int32 =
            if v140 then
                v131.[int v135] <- v136
                let v143 : int32 = v135 + 1
                v143
            else
                v135
        let v145 : int32 = v134 + 1
        v132.l0 <- v145
        v132.l1 <- v144
        ()
    let v146 : int32 = v132.l1
    let v147 : (string []) = Array.zeroCreate<string> (v146)
    let v148 : Mut6 = {l0 = 0} : Mut6
    while method58(v146, v148) do
        let v150 : int32 = v148.l0
        let v151 : string = v131.[int v150]
        v147.[int v150] <- v151
        let v152 : int32 = v150 + 1
        v148.l0 <- v152
        ()
    let v157 : unit = ()
    let _let'_v157 =
        seq {
            for i = 0 to v147.Length - 1 do yield v147.[i]
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v160 : string seq = _let'_v157 
    let v167 : string = method125()
    let v168 : (string -> (string seq -> string)) = String.concat
    let v169 : (string seq -> string) = v168 v167
    let v170 : string = v169 v160
    let v173 : string = $"{v170}

"
    let v175 : System.Threading.CancellationToken option = None
    let v178 : (struct (string * string) []) = [||]
    let v180 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v184 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v188 : string option = None
    (* run_target_args'
    let v192 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v193 : string = "cfg!(windows)"
    let v194 : bool = Fable.Core.RustInterop.emitRustExpr () v193 
    let _run_target_args'_v192 = v194 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v195 : string = "cfg!(windows)"
    let v196 : bool = Fable.Core.RustInterop.emitRustExpr () v195 
    let _run_target_args'_v192 = v196 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v197 : string = "cfg!(windows)"
    let v198 : bool = Fable.Core.RustInterop.emitRustExpr () v197 
    let _run_target_args'_v192 = v198 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v199 : US3 = US3_0
    let v200 : US4 = US4_4(v199)
    let v201 : string = $"platform.is_windows / target: {v200}"
    let v202 : bool = failwith<bool> v201
    let _run_target_args'_v192 = v202 
    #endif
#if FABLE_COMPILER_PYTHON
    let v203 : US3 = US3_0
    let v204 : US4 = US4_5(v203)
    let v205 : string = $"platform.is_windows / target: {v204}"
    let v206 : bool = failwith<bool> v205
    let _run_target_args'_v192 = v206 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v207 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v208 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v209 : bool = v208 v207
    let _run_target_args'_v192 = v209 
    #endif
#else
    let v210 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v211 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v212 : bool = v211 v210
    let _run_target_args'_v192 = v212 
    #endif
    let v213 : bool = _run_target_args'_v192 
    let v221 : string =
        if v213 then
            let v219 : string = ".exe"
            v219
        else
            let v220 : string = ""
            v220
    let v222 : string = $"../alphabet/deps/hangulize/cmd/hangulize/hangulize{v221}"
    let v223 : string = method26(v0, v222)
    let v224 : string = $"{v223} {v1}"
    let v227 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) = closure78(v173)
    let v228 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = Some v227 
    let v231 : bool = true
    let struct (v232 : int32, v233 : string) = method75(v224, v175, v178, v180, v228, v231, v188)
    let v240 : (string []) = v233.Split v114 
    let v243 : int32 = v240.Length
    let v244 : string = ""
    let v245 : Mut8 = {l0 = 0; l1 = v244; l2 = 0; l3 = 0} : Mut8
    while method158(v130, v245) do
        let v247 : int32 = v245.l0
        let struct (v248 : string, v249 : int32, v250 : int32) = v245.l1, v245.l2, v245.l3
        let v251 : string = v119.[int v247]
        let v252 : bool = v251 = ""
        let struct (v276 : string, v277 : int32, v278 : int32) =
            if v252 then
                let v253 : string = $"{v248}
"
                let v254 : int32 = v249 + 1
                let v255 : int32 = v250 + 1
                struct (v253, v254, v255)
            else
                let v256 : int32 = v249 - v250
                let v257 : bool = v256 >= v243
                let v274 : string =
                    if v257 then
                        v248
                    else
                        let v259 : string = v240.[int v256]
                        let v264 : string = "://"
                        let v265 : bool = v259.Contains v264 
                        let v268 : string =
                            if v265 then
                                v251
                            else
                                v259
                        let v269 : int32 = v243 - 1
                        let v270 : bool = v256 = v269
                        if v270 then
                            let v271 : string = $"{v248}{v268}"
                            v271
                        else
                            let v272 : string = $"{v248}{v268}
"
                            v272
                let v275 : int32 = v249 + 1
                struct (v274, v275, v250)
        let v279 : int32 = v247 + 1
        v245.l0 <- v279
        v245.l1 <- v276
        v245.l2 <- v277
        v245.l3 <- v278
        ()
    let struct (v280 : string, v281 : int32, v282 : int32) = v245.l1, v245.l2, v245.l3
    (* run_target_args'
    let v283 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v284 : string = "std::fs::write(&*$0, &*$1).unwrap()"
    Fable.Core.RustInterop.emitRustExpr struct (v2, v280) v284 
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
    System.IO.File.WriteAllText (v2, v280)
    #endif
    // run_target_args' is_unit
    let v346 : unit = ()
    let v347 : (unit -> unit) = closure79(v2, v232, v280)
    let v348 : unit = (fun () -> v347 (); v346) ()
    US36_0(v232, v280)
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
    let v174 : string = method73()
    let v175 : string = v173.Replace (v3, v174)
    let v176 : string = "\\"
    let v177 : string = "/"
    let v178 : string = v175.Replace (v176, v177)
    let v179 : string = $".{v178}"
    let v180 : string = method35(v6)
    let v181 : string = method26(v2, v179)
    let v182 : string = method74(v181)
    let v184 : System.Threading.CancellationToken option = None
    let v187 : (struct (string * string) []) = [||]
    let v189 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v193 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v197 : string option = None
    let v200 : string = $"git ls-tree --format='%%(objectname)' origin/gh-pages \"{v182}\""
    let v202 : string option = Some v2 
    let v205 : bool = true
    let struct (v206 : int32, v207 : string) = method75(v200, v184, v187, v189, v193, v205, v202)
    let v208 : string = method26(v3, v179)
    let v209 : string = method74(v208)
    let v211 : System.Threading.CancellationToken option = None
    let v214 : (struct (string * string) []) = [||]
    let v216 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v220 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v224 : string option = None
    let v227 : string = $"git hash-object \"{v209}\""
    let v229 : string option = Some v3 
    let v232 : bool = true
    let struct (v233 : int32, v234 : string) = method75(v227, v211, v214, v216, v220, v232, v229)
    let v235 : string = method26(v4, v179)
    let v236 : string = method74(v235)
    let v237 : string = "hangul.md"
    let struct (v238 : string, v239 : string) = method143(v237, v209, v4)
    let v240 : bool = false
    let v241 : bool = false
    let v242 : bool = false
    let v243 : bool = true
    let v244 : bool = true
    let v245 : bool = true
    let v247 : bool = v207.Contains v234 
    let v911 : UH4 =
        if v247 then
            UH4_0
        else
            let v251 : string = method35(v209)
            let v252 : string = "std::fs::File::open(&*v251)"
            let v253 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v252 
            (* run_target_args'
            let v255 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v256 : string = "$0.unwrap()"
            let v257 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v253 v256 
            let _run_target_args'_v255 = v257 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v258 : string = "$0.unwrap()"
            let v259 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v253 v258 
            let _run_target_args'_v255 = v259 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v260 : string = "$0.unwrap()"
            let v261 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v253 v260 
            let _run_target_args'_v255 = v261 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v262 : std_fs_File = match v253 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v255 = v262 
            #endif
#if FABLE_COMPILER_PYTHON
            let v263 : std_fs_File = match v253 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v255 = v263 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v264 : std_fs_File = match v253 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v255 = v264 
            #endif
#else
            let v265 : std_fs_File = match v253 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v255 = v265 
            #endif
            let v266 : std_fs_File = _run_target_args'_v255 
            let v269 : string = "std::io::BufReader::new($0)"
            let v270 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v266 v269 
            let v271 : string = "std::io::BufReader::new($0)"
            let v272 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v270 v271 
            let v273 : string = "true; let mut v272 = v272"
            let v274 : bool = Fable.Core.RustInterop.emitRustExpr () v273 
            let v275 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v275 
            let v276 : string = "result"
            let v277 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v276 
            let v278 : string = "true; let mut v277 = v277"
            let v279 : bool = Fable.Core.RustInterop.emitRustExpr () v278 
            let v281 : unativeint = 0 |> unativeint 
            let v284 : string = "[$0; 1024]"
            let v285 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v284 
            let v286 : string = "true; loop { // rust.loop"
            let v287 : bool = Fable.Core.RustInterop.emitRustExpr () v286 
            let v288 : string = "true; let mut v285 = v285"
            let v289 : bool = Fable.Core.RustInterop.emitRustExpr () v288 
            let v290 : string = "std::io::Read::read(&mut v272, &mut v285)"
            let v291 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v290 
            (* run_target_args'
            let v293 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v294 : string = "$0.unwrap()"
            let v295 : unativeint = Fable.Core.RustInterop.emitRustExpr v291 v294 
            let _run_target_args'_v293 = v295 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v296 : string = "$0.unwrap()"
            let v297 : unativeint = Fable.Core.RustInterop.emitRustExpr v291 v296 
            let _run_target_args'_v293 = v297 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v298 : string = "$0.unwrap()"
            let v299 : unativeint = Fable.Core.RustInterop.emitRustExpr v291 v298 
            let _run_target_args'_v293 = v299 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v300 : unativeint = match v291 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v293 = v300 
            #endif
#if FABLE_COMPILER_PYTHON
            let v301 : unativeint = match v291 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v293 = v301 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v302 : unativeint = match v291 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v293 = v302 
            #endif
#else
            let v303 : unativeint = match v291 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v293 = v303 
            #endif
            let v304 : unativeint = _run_target_args'_v293 
            let v308 : bool = v304 = v281 
            if v308 then
                let v311 : string = "true; break"
                let v312 : bool = Fable.Core.RustInterop.emitRustExpr () v311 
                ()
            let v314 : unativeint = v304 |> unativeint 
            let v318 : unativeint = v314 |> unbox<unativeint>
            let v321 : string = "v285.len()"
            let v322 : unativeint = Fable.Core.RustInterop.emitRustExpr () v321 
            let v324 : bool = v318 = v322 
            let v331 : Ref<Slice'<uint8>> =
                if v324 then
                    let v327 : string = "&v285[v281..]"
                    let v328 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v327 
                    v328
                else
                    let v329 : string = "&v285[$0..$1]"
                    let v330 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v281, v314) v329 
                    v330
            let v332 : string = "sha2::Digest::update(&mut v277, v331)"
            Fable.Core.RustInterop.emitRustExpr () v332 
            let v333 : string = "true; } // rust.loop"
            let v334 : bool = Fable.Core.RustInterop.emitRustExpr () v333 
            let v335 : string = "true; } // rust.loop"
            let v336 : bool = Fable.Core.RustInterop.emitRustExpr () v335 
            let v337 : string = "true; } // rust.loop"
            let v338 : bool = Fable.Core.RustInterop.emitRustExpr () v337 
            let v339 : string = "true; { // rust.loop"
            let v340 : bool = Fable.Core.RustInterop.emitRustExpr () v339 
            let v341 : string = "true; { // rust.loop"
            let v342 : bool = Fable.Core.RustInterop.emitRustExpr () v341 
            let v343 : string = "&sha2::Digest::finalize(v277)"
            let v344 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v343 
            let v345 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v346 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v344 v345 
            let v347 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v348 : bool = Fable.Core.RustInterop.emitRustExpr v346 v347 
            let v349 : string = "x"
            let v350 : uint8 = Fable.Core.RustInterop.emitRustExpr () v349 
            let v351 : string = "format!(\"{:02x}\", $0)"
            let v352 : std_string_String = Fable.Core.RustInterop.emitRustExpr v350 v351 
            let v353 : string = "fable_library_rust::String_::fromString($0)"
            let v354 : string = Fable.Core.RustInterop.emitRustExpr v352 v353 
            let v355 : string = "true; $0 }).collect::<Vec<_>>()"
            let v356 : bool = Fable.Core.RustInterop.emitRustExpr v354 v355 
            let v357 : string = "_vec_map"
            let v358 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v357 
            let v359 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v360 : (string []) = Fable.Core.RustInterop.emitRustExpr v358 v359 
            let v365 : unit = ()
            let _let'_v365 =
                seq {
                    for i = 0 to v360.Length - 1 do yield v360.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v368 : string seq = _let'_v365 
            let v374 : string = method144()
            let v376 : bool = v374 = "\n"
            let v378 : string =
                if v376 then
                    method60(v374)
                else
                    v374
            let v379 : (string -> (string seq -> string)) = String.concat
            let v380 : (string seq -> string) = v379 v378
            let v381 : string = v380 v368
            let v385 : Result<string, std_io_Error> = Ok v381 
            let v388 : (std_io_Error -> std_string_String) = method63()
            (* run_target_args'
            let v390 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v391 : string = "$0.map_err(|x| $1(x))"
            let v392 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v385, v388) v391 
            let _run_target_args'_v390 = v392 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v393 : string = "$0.map_err(|x| $1(x))"
            let v394 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v385, v388) v393 
            let _run_target_args'_v390 = v394 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v395 : string = "$0.map_err(|x| $1(x))"
            let v396 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v385, v388) v395 
            let _run_target_args'_v390 = v396 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v397 : Result<string, std_string_String> = match v385 with Ok x -> Ok x | Error x -> Error (v388 x)
            let _run_target_args'_v390 = v397 
            #endif
#if FABLE_COMPILER_PYTHON
            let v398 : Result<string, std_string_String> = match v385 with Ok x -> Ok x | Error x -> Error (v388 x)
            let _run_target_args'_v390 = v398 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v399 : Result<string, std_string_String> = match v385 with Ok x -> Ok x | Error x -> Error (v388 x)
            let _run_target_args'_v390 = v399 
            #endif
#else
            let v400 : Result<string, std_string_String> = match v385 with Ok x -> Ok x | Error x -> Error (v388 x)
            let _run_target_args'_v390 = v400 
            #endif
            let v401 : Result<string, std_string_String> = _run_target_args'_v390 
            let v404 : (string -> US34) = method145()
            let v405 : (std_string_String -> US34) = method146()
            let v406 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v407 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v404, v405, v401) v406 
            let v416 : string =
                match v407 with
                | US34_1(v409) -> (* Error *)
                    let v411 : string = $"resultm.get / Result value was Error: {v409}"
                    failwith<string> v411
                | US34_0(v408) -> (* Ok *)
                    v408
            let v417 : bool = method28(v236)
            let v418 : bool = v417 = false
            let v583 : US5 =
                if v418 then
                    US5_1
                else
                    let v420 : string = method35(v236)
                    let v421 : string = "std::fs::File::open(&*v420)"
                    let v422 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v421 
                    (* run_target_args'
                    let v424 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v425 : string = "$0.unwrap()"
                    let v426 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v422 v425 
                    let _run_target_args'_v424 = v426 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v427 : string = "$0.unwrap()"
                    let v428 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v422 v427 
                    let _run_target_args'_v424 = v428 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v429 : string = "$0.unwrap()"
                    let v430 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v422 v429 
                    let _run_target_args'_v424 = v430 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v431 : std_fs_File = match v422 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v424 = v431 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v432 : std_fs_File = match v422 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v424 = v432 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v433 : std_fs_File = match v422 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v424 = v433 
                    #endif
#else
                    let v434 : std_fs_File = match v422 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v424 = v434 
                    #endif
                    let v435 : std_fs_File = _run_target_args'_v424 
                    let v438 : string = "std::io::BufReader::new($0)"
                    let v439 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v435 v438 
                    let v440 : string = "std::io::BufReader::new($0)"
                    let v441 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v439 v440 
                    let v442 : string = "true; let mut v441 = v441"
                    let v443 : bool = Fable.Core.RustInterop.emitRustExpr () v442 
                    let v444 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
                    Fable.Core.RustInterop.emitRustExpr () v444 
                    let v445 : string = "result"
                    let v446 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v445 
                    let v447 : string = "true; let mut v446 = v446"
                    let v448 : bool = Fable.Core.RustInterop.emitRustExpr () v447 
                    let v450 : unativeint = 0 |> unativeint 
                    let v453 : string = "[$0; 1024]"
                    let v454 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v453 
                    let v455 : string = "true; loop { // rust.loop"
                    let v456 : bool = Fable.Core.RustInterop.emitRustExpr () v455 
                    let v457 : string = "true; let mut v454 = v454"
                    let v458 : bool = Fable.Core.RustInterop.emitRustExpr () v457 
                    let v459 : string = "std::io::Read::read(&mut v441, &mut v454)"
                    let v460 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v459 
                    (* run_target_args'
                    let v462 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v463 : string = "$0.unwrap()"
                    let v464 : unativeint = Fable.Core.RustInterop.emitRustExpr v460 v463 
                    let _run_target_args'_v462 = v464 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v465 : string = "$0.unwrap()"
                    let v466 : unativeint = Fable.Core.RustInterop.emitRustExpr v460 v465 
                    let _run_target_args'_v462 = v466 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v467 : string = "$0.unwrap()"
                    let v468 : unativeint = Fable.Core.RustInterop.emitRustExpr v460 v467 
                    let _run_target_args'_v462 = v468 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v469 : unativeint = match v460 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v462 = v469 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v470 : unativeint = match v460 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v462 = v470 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v471 : unativeint = match v460 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v462 = v471 
                    #endif
#else
                    let v472 : unativeint = match v460 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v462 = v472 
                    #endif
                    let v473 : unativeint = _run_target_args'_v462 
                    let v477 : bool = v473 = v450 
                    if v477 then
                        let v480 : string = "true; break"
                        let v481 : bool = Fable.Core.RustInterop.emitRustExpr () v480 
                        ()
                    let v483 : unativeint = v473 |> unativeint 
                    let v487 : unativeint = v483 |> unbox<unativeint>
                    let v490 : string = "v454.len()"
                    let v491 : unativeint = Fable.Core.RustInterop.emitRustExpr () v490 
                    let v493 : bool = v487 = v491 
                    let v500 : Ref<Slice'<uint8>> =
                        if v493 then
                            let v496 : string = "&v454[v450..]"
                            let v497 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v496 
                            v497
                        else
                            let v498 : string = "&v454[$0..$1]"
                            let v499 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v450, v483) v498 
                            v499
                    let v501 : string = "sha2::Digest::update(&mut v446, v500)"
                    Fable.Core.RustInterop.emitRustExpr () v501 
                    let v502 : string = "true; } // rust.loop"
                    let v503 : bool = Fable.Core.RustInterop.emitRustExpr () v502 
                    let v504 : string = "true; } // rust.loop"
                    let v505 : bool = Fable.Core.RustInterop.emitRustExpr () v504 
                    let v506 : string = "true; } // rust.loop"
                    let v507 : bool = Fable.Core.RustInterop.emitRustExpr () v506 
                    let v508 : string = "true; { // rust.loop"
                    let v509 : bool = Fable.Core.RustInterop.emitRustExpr () v508 
                    let v510 : string = "true; { // rust.loop"
                    let v511 : bool = Fable.Core.RustInterop.emitRustExpr () v510 
                    let v512 : string = "&sha2::Digest::finalize(v446)"
                    let v513 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v512 
                    let v514 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
                    let v515 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v513 v514 
                    let v516 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
                    let v517 : bool = Fable.Core.RustInterop.emitRustExpr v515 v516 
                    let v518 : string = "x"
                    let v519 : uint8 = Fable.Core.RustInterop.emitRustExpr () v518 
                    let v520 : string = "format!(\"{:02x}\", $0)"
                    let v521 : std_string_String = Fable.Core.RustInterop.emitRustExpr v519 v520 
                    let v522 : string = "fable_library_rust::String_::fromString($0)"
                    let v523 : string = Fable.Core.RustInterop.emitRustExpr v521 v522 
                    let v524 : string = "true; $0 }).collect::<Vec<_>>()"
                    let v525 : bool = Fable.Core.RustInterop.emitRustExpr v523 v524 
                    let v526 : string = "_vec_map"
                    let v527 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v526 
                    let v528 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
                    let v529 : (string []) = Fable.Core.RustInterop.emitRustExpr v527 v528 
                    let v534 : unit = ()
                    let _let'_v534 =
                        seq {
                            for i = 0 to v529.Length - 1 do yield v529.[i]
                            (* indent
                            ()
                        indent *)
                        }
                        (* indent
                        ()
                    indent *)
                    let v537 : string seq = _let'_v534 
                    let v543 : string = method144()
                    let v545 : bool = v543 = "\n"
                    let v547 : string =
                        if v545 then
                            method60(v543)
                        else
                            v543
                    let v548 : (string -> (string seq -> string)) = String.concat
                    let v549 : (string seq -> string) = v548 v547
                    let v550 : string = v549 v537
                    let v554 : Result<string, std_io_Error> = Ok v550 
                    let v557 : (std_io_Error -> std_string_String) = method63()
                    (* run_target_args'
                    let v559 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v560 : string = "$0.map_err(|x| $1(x))"
                    let v561 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v554, v557) v560 
                    let _run_target_args'_v559 = v561 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v562 : string = "$0.map_err(|x| $1(x))"
                    let v563 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v554, v557) v562 
                    let _run_target_args'_v559 = v563 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v564 : string = "$0.map_err(|x| $1(x))"
                    let v565 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v554, v557) v564 
                    let _run_target_args'_v559 = v565 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v566 : Result<string, std_string_String> = match v554 with Ok x -> Ok x | Error x -> Error (v557 x)
                    let _run_target_args'_v559 = v566 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v567 : Result<string, std_string_String> = match v554 with Ok x -> Ok x | Error x -> Error (v557 x)
                    let _run_target_args'_v559 = v567 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v568 : Result<string, std_string_String> = match v554 with Ok x -> Ok x | Error x -> Error (v557 x)
                    let _run_target_args'_v559 = v568 
                    #endif
#else
                    let v569 : Result<string, std_string_String> = match v554 with Ok x -> Ok x | Error x -> Error (v557 x)
                    let _run_target_args'_v559 = v569 
                    #endif
                    let v570 : Result<string, std_string_String> = _run_target_args'_v559 
                    let v573 : (string -> US34) = method145()
                    let v574 : (std_string_String -> US34) = method146()
                    let v575 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
                    let v576 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v573, v574, v570) v575 
                    match v576 with
                    | US34_1(v579) -> (* Error *)
                        US5_1
                    | US34_0(v577) -> (* Ok *)
                        US5_0(v577)
            match v583 with
            | US5_0(v584) -> (* Some *)
                let v585 : bool = v416 = v584
                if v585 then
                    UH4_0
                else
                    let v655 : unit = ()
                    let v656 : (unit -> unit) = closure71(v179, v180, v182, v207, v206, v209, v234, v233, v236, v416, v583)
                    let v657 : unit = (fun () -> v656 (); v655) ()
                    method148(v236, v209)
                    let v726 : (string -> (string -> US33)) = closure76(v4, v3, v1, v0)
                    let v727 : UH5 = UH5_0
                    let v728 : UH5 = UH5_1(v237, v209, v726, v727)
                    let v729 : string = "html"
                    let v730 : (string -> (string -> US33)) = closure81(v4, v3, v240)
                    let v731 : string = "pdf"
                    let v732 : (string -> (string -> US33)) = closure81(v4, v3, v241)
                    let v733 : string = "epub"
                    let v734 : (string -> (string -> US33)) = closure81(v4, v3, v242)
                    let v735 : (string -> (string -> US33)) = closure81(v4, v3, v243)
                    let v736 : (string -> (string -> US33)) = closure81(v4, v3, v244)
                    let v737 : (string -> (string -> US33)) = closure81(v4, v3, v245)
                    let v738 : UH5 = UH5_0
                    let v739 : UH5 = UH5_1(v733, v238, v737, v738)
                    let v740 : UH5 = UH5_1(v731, v238, v736, v739)
                    let v741 : UH5 = UH5_1(v729, v238, v735, v740)
                    let v742 : UH5 = UH5_1(v733, v209, v734, v741)
                    let v743 : UH5 = UH5_1(v731, v209, v732, v742)
                    let v744 : UH5 = UH5_1(v729, v209, v730, v743)
                    let v745 : UH4 = UH4_0
                    let v746 : UH4 = UH4_1(v744, v745)
                    UH4_1(v728, v746)
            | _ ->
                let v817 : unit = ()
                let v818 : (unit -> unit) = closure71(v179, v180, v182, v207, v206, v209, v234, v233, v236, v416, v583)
                let v819 : unit = (fun () -> v818 (); v817) ()
                method148(v236, v209)
                let v888 : (string -> (string -> US33)) = closure76(v4, v3, v1, v0)
                let v889 : UH5 = UH5_0
                let v890 : UH5 = UH5_1(v237, v209, v888, v889)
                let v891 : string = "html"
                let v892 : (string -> (string -> US33)) = closure81(v4, v3, v240)
                let v893 : string = "pdf"
                let v894 : (string -> (string -> US33)) = closure81(v4, v3, v241)
                let v895 : string = "epub"
                let v896 : (string -> (string -> US33)) = closure81(v4, v3, v242)
                let v897 : (string -> (string -> US33)) = closure81(v4, v3, v243)
                let v898 : (string -> (string -> US33)) = closure81(v4, v3, v244)
                let v899 : (string -> (string -> US33)) = closure81(v4, v3, v245)
                let v900 : UH5 = UH5_0
                let v901 : UH5 = UH5_1(v895, v238, v899, v900)
                let v902 : UH5 = UH5_1(v893, v238, v898, v901)
                let v903 : UH5 = UH5_1(v891, v238, v897, v902)
                let v904 : UH5 = UH5_1(v895, v209, v896, v903)
                let v905 : UH5 = UH5_1(v893, v209, v894, v904)
                let v906 : UH5 = UH5_1(v891, v209, v892, v905)
                let v907 : UH4 = UH4_0
                let v908 : UH4 = UH4_1(v906, v907)
                UH4_1(v890, v908)
    let v912 : bool =
        match v911 with
        | UH4_0 -> (* Nil *)
            true
        | _ ->
            false
    let v913 : bool = v912 <> true
    let v1855 : UH4 =
        if v913 then
            v911
        else
            let v914 : string = "epub"
            let struct (v915 : string, v916 : string) = method143(v914, v238, v4)
            let v917 : bool = method28(v915)
            let v1044 : bool =
                if v917 then
                    true
                else
                    let v918 : bool = method28(v916)
                    let v919 : bool = v918 = false
                    if v919 then
                        true
                    else
                        let v980 : unit = ()
                        let v981 : (unit -> unit) = closure84(v916, v915)
                        let v982 : unit = (fun () -> v981 (); v980) ()
                        method148(v915, v916)
                        false
            let v1049 : UH5 =
                if v1044 then
                    let v1045 : (string -> (string -> US33)) = closure81(v4, v3, v245)
                    let v1046 : UH5 = UH5_0
                    UH5_1(v914, v238, v1045, v1046)
                else
                    UH5_0
            let v1050 : string = "pdf"
            let struct (v1051 : string, v1052 : string) = method143(v1050, v238, v4)
            let v1053 : bool = method28(v1051)
            let v1180 : bool =
                if v1053 then
                    true
                else
                    let v1054 : bool = method28(v1052)
                    let v1055 : bool = v1054 = false
                    if v1055 then
                        true
                    else
                        let v1116 : unit = ()
                        let v1117 : (unit -> unit) = closure84(v1052, v1051)
                        let v1118 : unit = (fun () -> v1117 (); v1116) ()
                        method148(v1051, v1052)
                        false
            let v1183 : UH5 =
                if v1180 then
                    let v1181 : (string -> (string -> US33)) = closure81(v4, v3, v244)
                    UH5_1(v1050, v238, v1181, v1049)
                else
                    v1049
            let v1184 : string = "html"
            let struct (v1185 : string, v1186 : string) = method143(v1184, v238, v4)
            let v1187 : bool = method28(v1185)
            let v1314 : bool =
                if v1187 then
                    true
                else
                    let v1188 : bool = method28(v1186)
                    let v1189 : bool = v1188 = false
                    if v1189 then
                        true
                    else
                        let v1250 : unit = ()
                        let v1251 : (unit -> unit) = closure84(v1186, v1185)
                        let v1252 : unit = (fun () -> v1251 (); v1250) ()
                        method148(v1185, v1186)
                        false
            let v1317 : UH5 =
                if v1314 then
                    let v1315 : (string -> (string -> US33)) = closure81(v4, v3, v243)
                    UH5_1(v1184, v238, v1315, v1183)
                else
                    v1183
            let struct (v1318 : string, v1319 : string) = method143(v914, v209, v4)
            let v1320 : bool = method28(v1318)
            let v1447 : bool =
                if v1320 then
                    true
                else
                    let v1321 : bool = method28(v1319)
                    let v1322 : bool = v1321 = false
                    if v1322 then
                        true
                    else
                        let v1383 : unit = ()
                        let v1384 : (unit -> unit) = closure84(v1319, v1318)
                        let v1385 : unit = (fun () -> v1384 (); v1383) ()
                        method148(v1318, v1319)
                        false
            let v1450 : UH5 =
                if v1447 then
                    let v1448 : (string -> (string -> US33)) = closure81(v4, v3, v242)
                    UH5_1(v914, v209, v1448, v1317)
                else
                    v1317
            let struct (v1451 : string, v1452 : string) = method143(v1050, v209, v4)
            let v1453 : bool = method28(v1451)
            let v1580 : bool =
                if v1453 then
                    true
                else
                    let v1454 : bool = method28(v1452)
                    let v1455 : bool = v1454 = false
                    if v1455 then
                        true
                    else
                        let v1516 : unit = ()
                        let v1517 : (unit -> unit) = closure84(v1452, v1451)
                        let v1518 : unit = (fun () -> v1517 (); v1516) ()
                        method148(v1451, v1452)
                        false
            let v1583 : UH5 =
                if v1580 then
                    let v1581 : (string -> (string -> US33)) = closure81(v4, v3, v241)
                    UH5_1(v1050, v209, v1581, v1450)
                else
                    v1450
            let struct (v1584 : string, v1585 : string) = method143(v1184, v209, v4)
            let v1586 : bool = method28(v1584)
            let v1713 : bool =
                if v1586 then
                    true
                else
                    let v1587 : bool = method28(v1585)
                    let v1588 : bool = v1587 = false
                    if v1588 then
                        true
                    else
                        let v1649 : unit = ()
                        let v1650 : (unit -> unit) = closure84(v1585, v1584)
                        let v1651 : unit = (fun () -> v1650 (); v1649) ()
                        method148(v1584, v1585)
                        false
            let v1716 : UH5 =
                if v1713 then
                    let v1714 : (string -> (string -> US33)) = closure81(v4, v3, v240)
                    UH5_1(v1184, v209, v1714, v1583)
                else
                    v1583
            let struct (v1717 : string, v1718 : string) = method143(v237, v209, v4)
            let v1719 : bool = method28(v1717)
            let v1846 : bool =
                if v1719 then
                    true
                else
                    let v1720 : bool = method28(v1718)
                    let v1721 : bool = v1720 = false
                    if v1721 then
                        true
                    else
                        let v1782 : unit = ()
                        let v1783 : (unit -> unit) = closure84(v1718, v1717)
                        let v1784 : unit = (fun () -> v1783 (); v1782) ()
                        method148(v1717, v1718)
                        false
            let v1851 : UH5 =
                if v1846 then
                    let v1847 : (string -> (string -> US33)) = closure76(v4, v3, v1, v0)
                    let v1848 : UH5 = UH5_0
                    UH5_1(v237, v209, v1847, v1848)
                else
                    UH5_0
            let v1852 : UH4 = UH4_0
            let v1853 : UH4 = UH4_1(v1716, v1852)
            UH4_1(v1851, v1853)
    let v1856 : UH5 list = []
    let v1857 : UH5 list = method164(v1855, v1856)
    let v1859 : (UH5 list -> (UH5 [])) = List.toArray
    let v1860 : (UH5 []) = v1859 v1857
    let v1863 : string = "$0.to_vec()"
    let v1864 : Vec<UH5> = Fable.Core.RustInterop.emitRustExpr v1860 v1863 
    let v1865 : (Result<string, (string * string)> option []) = [||]
    let v1866 : string = "$0.to_vec()"
    let v1867 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1865 v1866 
    let v1868 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v1869 : (UH5 []) = Fable.Core.RustInterop.emitRustExpr v1864 v1868 
    let v1871 : UH5 list = v1869 |> Array.toList
    let v1879 : ((UH5 -> (UH4 -> UH4)) -> (UH5 list -> (UH4 -> UH4))) = List.foldBack
    let v1880 : (UH5 -> (UH4 -> UH4)) = method165()
    let v1881 : (UH5 list -> (UH4 -> UH4)) = v1879 v1880
    let v1882 : (UH4 -> UH4) = v1881 v1871
    let v1883 : UH4 = UH4_0
    let v1884 : UH4 = v1882 v1883
    let v1913 : Vec<Result<string, (string * string)> option> = method166(v1884, v1867)
    let v1915 : (string * Vec<Result<string, (string * string)> option>) = v180, v1913 
    let v1919 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = Ok v1915 
    v1919
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
    let v333 : string = $"true; _fix_closure_v323 " + v321 + "); " + v319 + " // rust.fix_closure'"
    let v334 : bool = Fable.Core.RustInterop.emitRustExpr () v333 
    let v335 : string = "__future_init"
    let v336 : _ = Fable.Core.RustInterop.emitRustExpr () v335 
    let v337 : string = "v336"
    let v338 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v337 
    v338
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
    let v108 : string = $"{v101}"
    let v116 : unit = ()
    let v117 : (unit -> unit) = closure8(v10, v108)
    let v118 : unit = (fun () -> v117 (); v116) ()
    let v126 : string = " }"
    let v127 : string = $"{v126}"
    let v135 : unit = ()
    let v136 : (unit -> unit) = closure8(v10, v127)
    let v137 : unit = (fun () -> v136 (); v135) ()
    let v143 : string = v10.l0
    let v144 : int64 = v0.l0
    let v147 : string = " "
    let v148 : string = v6 + v147 
    let v152 : string = v148 + v7 
    let v157 : string = " #"
    let v158 : string = v152 + v157 
    let v162 : (int64 -> string) = _.ToString()
    let v163 : string = v162 v144
    let v167 : string = v158 + v163 
    let v171 : string = v167 + v147 
    let v176 : string = "documents.main"
    let v177 : string = v171 + v176 
    let v182 : string = " / "
    let v183 : string = v177 + v182 
    let v187 : string = v183 + v143 
    method16(v187)
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
    let v108 : string = $"{v101}"
    let v116 : unit = ()
    let v117 : (unit -> unit) = closure8(v10, v108)
    let v118 : unit = (fun () -> v117 (); v116) ()
    let v126 : string = " }"
    let v127 : string = $"{v126}"
    let v135 : unit = ()
    let v136 : (unit -> unit) = closure8(v10, v127)
    let v137 : unit = (fun () -> v136 (); v135) ()
    let v143 : string = v10.l0
    let v144 : int64 = v0.l0
    let v147 : string = " "
    let v148 : string = v6 + v147 
    let v152 : string = v148 + v7 
    let v157 : string = " #"
    let v158 : string = v152 + v157 
    let v162 : (int64 -> string) = _.ToString()
    let v163 : string = v162 v144
    let v167 : string = v158 + v163 
    let v171 : string = v167 + v147 
    let v176 : string = "documents.main"
    let v177 : string = v171 + v176 
    let v182 : string = " / "
    let v183 : string = v177 + v182 
    let v187 : string = v183 + v143 
    method16(v187)
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
    let v192 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v193 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v157, v186) v192 
    let v196 : (std_string_String -> US6) = method19()
    let v197 : US6 option = v193 |> Option.map v196 
    let v217 : US6 = US6_1
    let v218 : US6 = v197 |> Option.defaultValue v217 
    let v225 : std_string_String =
        match v218 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v222) -> (* Some *)
            v222
    let v226 : string = "fable_library_rust::String_::fromString($0)"
    let v227 : string = Fable.Core.RustInterop.emitRustExpr v225 v226 
    let v228 : string = method20()
    (* run_target_args'
    let v233 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v234 : string = "&*$0"
    let v235 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v228 v234 
    let _run_target_args'_v233 = v235 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v236 : string = "&*$0"
    let v237 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v228 v236 
    let _run_target_args'_v233 = v237 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v238 : string = "&*$0"
    let v239 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v228 v238 
    let _run_target_args'_v233 = v239 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v241 : Ref<Str> = v228 |> unbox<Ref<Str>>
    let _run_target_args'_v233 = v241 
    #endif
#if FABLE_COMPILER_PYTHON
    let v245 : Ref<Str> = v228 |> unbox<Ref<Str>>
    let _run_target_args'_v233 = v245 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v249 : Ref<Str> = v228 |> unbox<Ref<Str>>
    let _run_target_args'_v233 = v249 
    #endif
#else
    let v253 : Ref<Str> = v228 |> unbox<Ref<Str>>
    let _run_target_args'_v233 = v253 
    #endif
    let v256 : Ref<Str> = _run_target_args'_v233 
    let v262 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v263 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v157, v256) v262 
    let v266 : (std_string_String -> US6) = method19()
    let v267 : US6 option = v263 |> Option.map v266 
    let v287 : US6 = US6_1
    let v288 : US6 = v267 |> Option.defaultValue v287 
    let v295 : std_string_String =
        match v288 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v292) -> (* Some *)
            v292
    let v296 : string = "fable_library_rust::String_::fromString($0)"
    let v297 : string = Fable.Core.RustInterop.emitRustExpr v295 v296 
    let v298 : string = method21()
    (* run_target_args'
    let v303 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v304 : string = "&*$0"
    let v305 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v298 v304 
    let _run_target_args'_v303 = v305 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v306 : string = "&*$0"
    let v307 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v298 v306 
    let _run_target_args'_v303 = v307 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v308 : string = "&*$0"
    let v309 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v298 v308 
    let _run_target_args'_v303 = v309 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v311 : Ref<Str> = v298 |> unbox<Ref<Str>>
    let _run_target_args'_v303 = v311 
    #endif
#if FABLE_COMPILER_PYTHON
    let v315 : Ref<Str> = v298 |> unbox<Ref<Str>>
    let _run_target_args'_v303 = v315 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v319 : Ref<Str> = v298 |> unbox<Ref<Str>>
    let _run_target_args'_v303 = v319 
    #endif
#else
    let v323 : Ref<Str> = v298 |> unbox<Ref<Str>>
    let _run_target_args'_v303 = v323 
    #endif
    let v326 : Ref<Str> = _run_target_args'_v303 
    let v332 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v333 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v157, v326) v332 
    let v336 : (std_string_String -> US6) = method19()
    let v337 : US6 option = v333 |> Option.map v336 
    let v357 : US6 = US6_1
    let v358 : US6 = v337 |> Option.defaultValue v357 
    let v365 : std_string_String =
        match v358 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v362) -> (* Some *)
            v362
    let v366 : string = "fable_library_rust::String_::fromString($0)"
    let v367 : string = Fable.Core.RustInterop.emitRustExpr v365 v366 
    let v368 : string = method22()
    (* run_target_args'
    let v373 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v374 : string = "&*$0"
    let v375 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v368 v374 
    let _run_target_args'_v373 = v375 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v376 : string = "&*$0"
    let v377 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v368 v376 
    let _run_target_args'_v373 = v377 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v378 : string = "&*$0"
    let v379 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v368 v378 
    let _run_target_args'_v373 = v379 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v381 : Ref<Str> = v368 |> unbox<Ref<Str>>
    let _run_target_args'_v373 = v381 
    #endif
#if FABLE_COMPILER_PYTHON
    let v385 : Ref<Str> = v368 |> unbox<Ref<Str>>
    let _run_target_args'_v373 = v385 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v389 : Ref<Str> = v368 |> unbox<Ref<Str>>
    let _run_target_args'_v373 = v389 
    #endif
#else
    let v393 : Ref<Str> = v368 |> unbox<Ref<Str>>
    let _run_target_args'_v373 = v393 
    #endif
    let v396 : Ref<Str> = _run_target_args'_v373 
    let v402 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v403 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v157, v396) v402 
    let v406 : (std_string_String -> US6) = method19()
    let v407 : US6 option = v403 |> Option.map v406 
    let v427 : US6 = US6_1
    let v428 : US6 = v407 |> Option.defaultValue v427 
    let v435 : std_string_String =
        match v428 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v432) -> (* Some *)
            v432
    let v436 : string = "fable_library_rust::String_::fromString($0)"
    let v437 : string = Fable.Core.RustInterop.emitRustExpr v435 v436 
    let v438 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = method23(v437, v367, v297, v227)
    let v439 : string = "futures::executor::block_on($0)"
    let v440 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr v438 v439 
    let v441 : (Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> -> US37) = method170()
    let v442 : (std_string_String -> US37) = method171()
    let v444 : US37 = match v440 with Ok x -> v441 x | Error x -> v442 x
    match v444 with
    | US37_1(v575) -> (* Error *)
        let v636 : unit = ()
        let v637 : (unit -> unit) = closure90(v575)
        let v638 : unit = (fun () -> v637 (); v636) ()
        1
    | US37_0(v447) -> (* Ok *)
        let v510 : unit = ()
        let v511 : (unit -> unit) = closure91(v447)
        let v512 : unit = (fun () -> v511 (); v510) ()
        0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
