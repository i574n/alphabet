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
    let v52 : (string -> US5) = method6()
    let v53 : US5 option = v47 |> Option.map v52 
    let v73 : US5 = US5_1
    let v74 : US5 = v53 |> Option.defaultValue v73 
    let v81 : string =
        match v74 with
        | US5_1 -> (* None *)
            let v79 : string = ""
            v79
        | US5_0(v78) -> (* Some *)
            v78
    let _run_target_args'_v5 = v81 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v82 : US3 = US3_1
    let v83 : US4 = US4_1(v82)
    let v84 : string = $"env.get_environment_variable / target: {v83} / var: {v0}"
    let v85 : string = failwith<string> v84
    let _run_target_args'_v5 = v85 
    #endif
#else
    let v86 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v87 : string = v86 v0
    let mutable _v87 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v89 : (string -> string option) = Option.ofObj
    let v90 : string option = v89 v87
    v90 
    #else
    Some v87 
    #endif
    |> fun x -> _v87 <- Some x
    let v91 : string option = match _v87 with Some x -> x | None -> failwith "optionm'.of_obj / _v87=None"
    let v96 : (string -> US5) = method6()
    let v97 : US5 option = v91 |> Option.map v96 
    let v117 : US5 = US5_1
    let v118 : US5 = v97 |> Option.defaultValue v117 
    let v125 : string =
        match v118 with
        | US5_1 -> (* None *)
            let v123 : string = ""
            v123
        | US5_0(v122) -> (* Some *)
            v122
    let _run_target_args'_v5 = v125 
    #endif
    let v126 : string = _run_target_args'_v5 
    v126
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
    let v200 : US2 =
        if v133 then
            US2_1
        else
            (* run_target_args'
            let v139 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v140 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v139 = v140 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v141 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v139 = v141 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v143 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v139 = v143 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v146 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v139 = v146 
            #endif
#if FABLE_COMPILER_PYTHON
            let v147 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v139 = v147 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v148 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v139 = v148 
            #endif
#else
            let v149 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v139 = v149 
            #endif
            let v150 : System.DateTime = _run_target_args'_v139 
            (* run_target_args'
            let v158 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v159 : (System.DateTime -> int64) = _.Ticks
            let v160 : int64 = v159 v150
            let _run_target_args'_v158 = v160 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v161 : (System.DateTime -> int64) = _.Ticks
            let v162 : int64 = v161 v150
            let _run_target_args'_v158 = v162 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v164 : int64 = null |> unbox<int64>
            let _run_target_args'_v158 = v164 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v167 : (System.DateTime -> int64) = _.Ticks
            let v168 : int64 = v167 v150
            let _run_target_args'_v158 = v168 
            #endif
#if FABLE_COMPILER_PYTHON
            let v169 : (System.DateTime -> int64) = _.Ticks
            let v170 : int64 = v169 v150
            let _run_target_args'_v158 = v170 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v171 : (System.DateTime -> int64) = _.Ticks
            let v172 : int64 = v171 v150
            let _run_target_args'_v158 = v172 
            #endif
#else
            let v173 : (System.DateTime -> int64) = _.Ticks
            let v174 : int64 = v173 v150
            let _run_target_args'_v158 = v174 
            #endif
            let v175 : int64 = _run_target_args'_v158 
            let v196 : int64 = v175 |> int64 
            US2_0(v196)
    struct (v127, v200)
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
    let v173 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v176 : (int64 -> US2) = method9()
    let v177 : US2 option = v5 |> Option.map v176 
    let v197 : US2 = US2_1
    let v198 : US2 = v177 |> Option.defaultValue v197 
    let v316 : System.DateTime =
        match v198 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v299 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v300 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v299 = v300 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v301 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v299 = v301 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v303 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v299 = v303 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v306 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v299 = v306 
            #endif
#if FABLE_COMPILER_PYTHON
            let v307 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v299 = v307 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v308 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v299 = v308 
            #endif
#else
            let v309 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v299 = v309 
            #endif
            let v310 : System.DateTime = _run_target_args'_v299 
            v310
        | US2_0(v202) -> (* Some *)
            (* run_target_args'
            let v205 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v206 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v205 = v206 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v207 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v205 = v207 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v209 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v205 = v209 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v212 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v205 = v212 
            #endif
#if FABLE_COMPILER_PYTHON
            let v213 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v205 = v213 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v214 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v205 = v214 
            #endif
#else
            let v215 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v205 = v215 
            #endif
            let v216 : System.DateTime = _run_target_args'_v205 
            (* run_target_args'
            let v224 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v225 : (System.DateTime -> int64) = _.Ticks
            let v226 : int64 = v225 v216
            let _run_target_args'_v224 = v226 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v227 : (System.DateTime -> int64) = _.Ticks
            let v228 : int64 = v227 v216
            let _run_target_args'_v224 = v228 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v230 : int64 = null |> unbox<int64>
            let _run_target_args'_v224 = v230 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v233 : (System.DateTime -> int64) = _.Ticks
            let v234 : int64 = v233 v216
            let _run_target_args'_v224 = v234 
            #endif
#if FABLE_COMPILER_PYTHON
            let v235 : (System.DateTime -> int64) = _.Ticks
            let v236 : int64 = v235 v216
            let _run_target_args'_v224 = v236 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v237 : (System.DateTime -> int64) = _.Ticks
            let v238 : int64 = v237 v216
            let _run_target_args'_v224 = v238 
            #endif
#else
            let v239 : (System.DateTime -> int64) = _.Ticks
            let v240 : int64 = v239 v216
            let _run_target_args'_v224 = v240 
            #endif
            let v241 : int64 = _run_target_args'_v224 
            let v262 : int64 = v241 |> int64 
            let v265 : int64 = v262 - v202
            let v268 : System.TimeSpan = v265 |> System.TimeSpan 
            let v274 : (System.TimeSpan -> int32) = _.Hours
            let v275 : int32 = v274 v268
            let v279 : (System.TimeSpan -> int32) = _.Minutes
            let v280 : int32 = v279 v268
            let v284 : (System.TimeSpan -> int32) = _.Seconds
            let v285 : int32 = v284 v268
            let v289 : (System.TimeSpan -> int32) = _.Milliseconds
            let v290 : int32 = v289 v268
            let v294 : System.DateTime = System.DateTime (1, 1, 1, v275, v280, v285, v290)
            v294
    let v318 : string = method10()
    let v322 : bool = v318 = ""
    let v324 : string =
        if v322 then
            let v323 : string = "M-d-y hh:mm:ss tt"
            v323
        else
            v318
    let v325 : (string -> string) = v316.ToString
    let v326 : string = v325 v324
    let _run_target_args'_v173 = v326 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v343 : (int64 -> US2) = method9()
    let v344 : US2 option = v5 |> Option.map v343 
    let v364 : US2 = US2_1
    let v365 : US2 = v344 |> Option.defaultValue v364 
    let v483 : System.DateTime =
        match v365 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v466 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v467 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v466 = v467 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v468 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v466 = v468 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v470 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v466 = v470 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v473 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v466 = v473 
            #endif
#if FABLE_COMPILER_PYTHON
            let v474 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v466 = v474 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v475 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v466 = v475 
            #endif
#else
            let v476 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v466 = v476 
            #endif
            let v477 : System.DateTime = _run_target_args'_v466 
            v477
        | US2_0(v369) -> (* Some *)
            (* run_target_args'
            let v372 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v373 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v372 = v373 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v374 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v372 = v374 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v376 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v372 = v376 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v379 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v372 = v379 
            #endif
#if FABLE_COMPILER_PYTHON
            let v380 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v372 = v380 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v381 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v372 = v381 
            #endif
#else
            let v382 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v372 = v382 
            #endif
            let v383 : System.DateTime = _run_target_args'_v372 
            (* run_target_args'
            let v391 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v392 : (System.DateTime -> int64) = _.Ticks
            let v393 : int64 = v392 v383
            let _run_target_args'_v391 = v393 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v394 : (System.DateTime -> int64) = _.Ticks
            let v395 : int64 = v394 v383
            let _run_target_args'_v391 = v395 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v397 : int64 = null |> unbox<int64>
            let _run_target_args'_v391 = v397 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v400 : (System.DateTime -> int64) = _.Ticks
            let v401 : int64 = v400 v383
            let _run_target_args'_v391 = v401 
            #endif
#if FABLE_COMPILER_PYTHON
            let v402 : (System.DateTime -> int64) = _.Ticks
            let v403 : int64 = v402 v383
            let _run_target_args'_v391 = v403 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v404 : (System.DateTime -> int64) = _.Ticks
            let v405 : int64 = v404 v383
            let _run_target_args'_v391 = v405 
            #endif
#else
            let v406 : (System.DateTime -> int64) = _.Ticks
            let v407 : int64 = v406 v383
            let _run_target_args'_v391 = v407 
            #endif
            let v408 : int64 = _run_target_args'_v391 
            let v429 : int64 = v408 |> int64 
            let v432 : int64 = v429 - v369
            let v435 : System.TimeSpan = v432 |> System.TimeSpan 
            let v441 : (System.TimeSpan -> int32) = _.Hours
            let v442 : int32 = v441 v435
            let v446 : (System.TimeSpan -> int32) = _.Minutes
            let v447 : int32 = v446 v435
            let v451 : (System.TimeSpan -> int32) = _.Seconds
            let v452 : int32 = v451 v435
            let v456 : (System.TimeSpan -> int32) = _.Milliseconds
            let v457 : int32 = v456 v435
            let v461 : System.DateTime = System.DateTime (1, 1, 1, v442, v447, v452, v457)
            v461
    let v485 : string = method10()
    let v489 : bool = v485 = ""
    let v491 : string =
        if v489 then
            let v490 : string = "M-d-y hh:mm:ss tt"
            v490
        else
            v485
    let v492 : (string -> string) = v483.ToString
    let v493 : string = v492 v491
    let _run_target_args'_v173 = v493 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v508 : string = $"near_sdk::env::block_timestamp()"
    let v509 : uint64 = Fable.Core.RustInterop.emitRustExpr () v508 
    let v512 : (int64 -> US2) = method9()
    let v513 : US2 option = v5 |> Option.map v512 
    let v533 : US2 = US2_1
    let v534 : US2 = v513 |> Option.defaultValue v533 
    let v546 : uint64 =
        match v534 with
        | US2_1 -> (* None *)
            v509
        | US2_0(v538) -> (* Some *)
            let v540 : (int64 -> uint64) = uint64
            let v541 : uint64 = v540 v538
            let v544 : uint64 = v509 - v541
            v544
    let v547 : uint64 = v546 / 1000000000UL
    let v548 : uint64 = v547 % 60UL
    let v549 : uint64 = v547 / 60UL
    let v550 : uint64 = v549 % 60UL
    let v551 : uint64 = v547 / 3600UL
    let v552 : uint64 = v551 % 24UL
    let v553 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v554 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v552, v550, v548) v553 
    let v555 : string = "fable_library_rust::String_::fromString($0)"
    let v556 : string = Fable.Core.RustInterop.emitRustExpr v554 v555 
    let _run_target_args'_v173 = v556 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v559 : (int64 -> US2) = method9()
    let v560 : US2 option = v5 |> Option.map v559 
    let v580 : US2 = US2_1
    let v581 : US2 = v560 |> Option.defaultValue v580 
    let v699 : System.DateTime =
        match v581 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v682 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v683 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v682 = v683 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v684 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v682 = v684 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v686 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v682 = v686 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v689 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v682 = v689 
            #endif
#if FABLE_COMPILER_PYTHON
            let v690 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v682 = v690 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v691 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v682 = v691 
            #endif
#else
            let v692 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v682 = v692 
            #endif
            let v693 : System.DateTime = _run_target_args'_v682 
            v693
        | US2_0(v585) -> (* Some *)
            (* run_target_args'
            let v588 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v589 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v588 = v589 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v590 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v588 = v590 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v592 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v588 = v592 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v595 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v588 = v595 
            #endif
#if FABLE_COMPILER_PYTHON
            let v596 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v588 = v596 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v597 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v588 = v597 
            #endif
#else
            let v598 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v588 = v598 
            #endif
            let v599 : System.DateTime = _run_target_args'_v588 
            (* run_target_args'
            let v607 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v608 : (System.DateTime -> int64) = _.Ticks
            let v609 : int64 = v608 v599
            let _run_target_args'_v607 = v609 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v610 : (System.DateTime -> int64) = _.Ticks
            let v611 : int64 = v610 v599
            let _run_target_args'_v607 = v611 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v613 : int64 = null |> unbox<int64>
            let _run_target_args'_v607 = v613 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v616 : (System.DateTime -> int64) = _.Ticks
            let v617 : int64 = v616 v599
            let _run_target_args'_v607 = v617 
            #endif
#if FABLE_COMPILER_PYTHON
            let v618 : (System.DateTime -> int64) = _.Ticks
            let v619 : int64 = v618 v599
            let _run_target_args'_v607 = v619 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v620 : (System.DateTime -> int64) = _.Ticks
            let v621 : int64 = v620 v599
            let _run_target_args'_v607 = v621 
            #endif
#else
            let v622 : (System.DateTime -> int64) = _.Ticks
            let v623 : int64 = v622 v599
            let _run_target_args'_v607 = v623 
            #endif
            let v624 : int64 = _run_target_args'_v607 
            let v645 : int64 = v624 |> int64 
            let v648 : int64 = v645 - v585
            let v651 : System.TimeSpan = v648 |> System.TimeSpan 
            let v657 : (System.TimeSpan -> int32) = _.Hours
            let v658 : int32 = v657 v651
            let v662 : (System.TimeSpan -> int32) = _.Minutes
            let v663 : int32 = v662 v651
            let v667 : (System.TimeSpan -> int32) = _.Seconds
            let v668 : int32 = v667 v651
            let v672 : (System.TimeSpan -> int32) = _.Milliseconds
            let v673 : int32 = v672 v651
            let v677 : System.DateTime = System.DateTime (1, 1, 1, v658, v663, v668, v673)
            v677
    let v701 : string = method11()
    let v705 : bool = v701 = ""
    let v707 : string =
        if v705 then
            let v706 : string = "M-d-y hh:mm:ss tt"
            v706
        else
            v701
    let v708 : (string -> string) = v699.ToString
    let v709 : string = v708 v707
    let _run_target_args'_v173 = v709 
    #endif
#if FABLE_COMPILER_PYTHON
    let v726 : (int64 -> US2) = method9()
    let v727 : US2 option = v5 |> Option.map v726 
    let v747 : US2 = US2_1
    let v748 : US2 = v727 |> Option.defaultValue v747 
    let v866 : System.DateTime =
        match v748 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v849 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v850 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v849 = v850 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v851 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v849 = v851 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v853 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v849 = v853 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v856 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v849 = v856 
            #endif
#if FABLE_COMPILER_PYTHON
            let v857 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v849 = v857 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v858 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v849 = v858 
            #endif
#else
            let v859 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v849 = v859 
            #endif
            let v860 : System.DateTime = _run_target_args'_v849 
            v860
        | US2_0(v752) -> (* Some *)
            (* run_target_args'
            let v755 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v756 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v755 = v756 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v757 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v755 = v757 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v759 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v755 = v759 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v762 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v755 = v762 
            #endif
#if FABLE_COMPILER_PYTHON
            let v763 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v755 = v763 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v764 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v755 = v764 
            #endif
#else
            let v765 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v755 = v765 
            #endif
            let v766 : System.DateTime = _run_target_args'_v755 
            (* run_target_args'
            let v774 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v775 : (System.DateTime -> int64) = _.Ticks
            let v776 : int64 = v775 v766
            let _run_target_args'_v774 = v776 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v777 : (System.DateTime -> int64) = _.Ticks
            let v778 : int64 = v777 v766
            let _run_target_args'_v774 = v778 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v780 : int64 = null |> unbox<int64>
            let _run_target_args'_v774 = v780 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v783 : (System.DateTime -> int64) = _.Ticks
            let v784 : int64 = v783 v766
            let _run_target_args'_v774 = v784 
            #endif
#if FABLE_COMPILER_PYTHON
            let v785 : (System.DateTime -> int64) = _.Ticks
            let v786 : int64 = v785 v766
            let _run_target_args'_v774 = v786 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v787 : (System.DateTime -> int64) = _.Ticks
            let v788 : int64 = v787 v766
            let _run_target_args'_v774 = v788 
            #endif
#else
            let v789 : (System.DateTime -> int64) = _.Ticks
            let v790 : int64 = v789 v766
            let _run_target_args'_v774 = v790 
            #endif
            let v791 : int64 = _run_target_args'_v774 
            let v812 : int64 = v791 |> int64 
            let v815 : int64 = v812 - v752
            let v818 : System.TimeSpan = v815 |> System.TimeSpan 
            let v824 : (System.TimeSpan -> int32) = _.Hours
            let v825 : int32 = v824 v818
            let v829 : (System.TimeSpan -> int32) = _.Minutes
            let v830 : int32 = v829 v818
            let v834 : (System.TimeSpan -> int32) = _.Seconds
            let v835 : int32 = v834 v818
            let v839 : (System.TimeSpan -> int32) = _.Milliseconds
            let v840 : int32 = v839 v818
            let v844 : System.DateTime = System.DateTime (1, 1, 1, v825, v830, v835, v840)
            v844
    let v868 : string = method11()
    let v872 : bool = v868 = ""
    let v874 : string =
        if v872 then
            let v873 : string = "M-d-y hh:mm:ss tt"
            v873
        else
            v868
    let v875 : (string -> string) = v866.ToString
    let v876 : string = v875 v874
    let _run_target_args'_v173 = v876 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v893 : (int64 -> US2) = method9()
    let v894 : US2 option = v5 |> Option.map v893 
    let v914 : US2 = US2_1
    let v915 : US2 = v894 |> Option.defaultValue v914 
    let v1033 : System.DateTime =
        match v915 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v1016 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1017 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1016 = v1017 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1018 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1016 = v1018 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1020 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1016 = v1020 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1023 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1016 = v1023 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1024 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1016 = v1024 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1025 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1016 = v1025 
            #endif
#else
            let v1026 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1016 = v1026 
            #endif
            let v1027 : System.DateTime = _run_target_args'_v1016 
            v1027
        | US2_0(v919) -> (* Some *)
            (* run_target_args'
            let v922 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v923 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v922 = v923 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v924 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v922 = v924 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v926 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v922 = v926 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v929 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v922 = v929 
            #endif
#if FABLE_COMPILER_PYTHON
            let v930 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v922 = v930 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v931 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v922 = v931 
            #endif
#else
            let v932 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v922 = v932 
            #endif
            let v933 : System.DateTime = _run_target_args'_v922 
            (* run_target_args'
            let v941 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v942 : (System.DateTime -> int64) = _.Ticks
            let v943 : int64 = v942 v933
            let _run_target_args'_v941 = v943 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v944 : (System.DateTime -> int64) = _.Ticks
            let v945 : int64 = v944 v933
            let _run_target_args'_v941 = v945 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v947 : int64 = null |> unbox<int64>
            let _run_target_args'_v941 = v947 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v950 : (System.DateTime -> int64) = _.Ticks
            let v951 : int64 = v950 v933
            let _run_target_args'_v941 = v951 
            #endif
#if FABLE_COMPILER_PYTHON
            let v952 : (System.DateTime -> int64) = _.Ticks
            let v953 : int64 = v952 v933
            let _run_target_args'_v941 = v953 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v954 : (System.DateTime -> int64) = _.Ticks
            let v955 : int64 = v954 v933
            let _run_target_args'_v941 = v955 
            #endif
#else
            let v956 : (System.DateTime -> int64) = _.Ticks
            let v957 : int64 = v956 v933
            let _run_target_args'_v941 = v957 
            #endif
            let v958 : int64 = _run_target_args'_v941 
            let v979 : int64 = v958 |> int64 
            let v982 : int64 = v979 - v919
            let v985 : System.TimeSpan = v982 |> System.TimeSpan 
            let v991 : (System.TimeSpan -> int32) = _.Hours
            let v992 : int32 = v991 v985
            let v996 : (System.TimeSpan -> int32) = _.Minutes
            let v997 : int32 = v996 v985
            let v1001 : (System.TimeSpan -> int32) = _.Seconds
            let v1002 : int32 = v1001 v985
            let v1006 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1007 : int32 = v1006 v985
            let v1011 : System.DateTime = System.DateTime (1, 1, 1, v992, v997, v1002, v1007)
            v1011
    let v1035 : string = method11()
    let v1039 : bool = v1035 = ""
    let v1041 : string =
        if v1039 then
            let v1040 : string = "M-d-y hh:mm:ss tt"
            v1040
        else
            v1035
    let v1042 : (string -> string) = v1033.ToString
    let v1043 : string = v1042 v1041
    let _run_target_args'_v173 = v1043 
    #endif
#else
    let v1060 : (int64 -> US2) = method9()
    let v1061 : US2 option = v5 |> Option.map v1060 
    let v1081 : US2 = US2_1
    let v1082 : US2 = v1061 |> Option.defaultValue v1081 
    let v1200 : System.DateTime =
        match v1082 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v1183 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1184 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1183 = v1184 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1185 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1183 = v1185 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1187 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1183 = v1187 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1190 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1183 = v1190 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1191 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1183 = v1191 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1192 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1183 = v1192 
            #endif
#else
            let v1193 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1183 = v1193 
            #endif
            let v1194 : System.DateTime = _run_target_args'_v1183 
            v1194
        | US2_0(v1086) -> (* Some *)
            (* run_target_args'
            let v1089 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1090 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1089 = v1090 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1091 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1089 = v1091 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1093 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1089 = v1093 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1096 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1089 = v1096 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1097 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1089 = v1097 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1098 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1089 = v1098 
            #endif
#else
            let v1099 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1089 = v1099 
            #endif
            let v1100 : System.DateTime = _run_target_args'_v1089 
            (* run_target_args'
            let v1108 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1109 : (System.DateTime -> int64) = _.Ticks
            let v1110 : int64 = v1109 v1100
            let _run_target_args'_v1108 = v1110 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1111 : (System.DateTime -> int64) = _.Ticks
            let v1112 : int64 = v1111 v1100
            let _run_target_args'_v1108 = v1112 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1114 : int64 = null |> unbox<int64>
            let _run_target_args'_v1108 = v1114 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1117 : (System.DateTime -> int64) = _.Ticks
            let v1118 : int64 = v1117 v1100
            let _run_target_args'_v1108 = v1118 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1119 : (System.DateTime -> int64) = _.Ticks
            let v1120 : int64 = v1119 v1100
            let _run_target_args'_v1108 = v1120 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1121 : (System.DateTime -> int64) = _.Ticks
            let v1122 : int64 = v1121 v1100
            let _run_target_args'_v1108 = v1122 
            #endif
#else
            let v1123 : (System.DateTime -> int64) = _.Ticks
            let v1124 : int64 = v1123 v1100
            let _run_target_args'_v1108 = v1124 
            #endif
            let v1125 : int64 = _run_target_args'_v1108 
            let v1146 : int64 = v1125 |> int64 
            let v1149 : int64 = v1146 - v1086
            let v1152 : System.TimeSpan = v1149 |> System.TimeSpan 
            let v1158 : (System.TimeSpan -> int32) = _.Hours
            let v1159 : int32 = v1158 v1152
            let v1163 : (System.TimeSpan -> int32) = _.Minutes
            let v1164 : int32 = v1163 v1152
            let v1168 : (System.TimeSpan -> int32) = _.Seconds
            let v1169 : int32 = v1168 v1152
            let v1173 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1174 : int32 = v1173 v1152
            let v1178 : System.DateTime = System.DateTime (1, 1, 1, v1159, v1164, v1169, v1174)
            v1178
    let v1202 : string = method11()
    let v1206 : bool = v1202 = ""
    let v1208 : string =
        if v1206 then
            let v1207 : string = "M-d-y hh:mm:ss tt"
            v1207
        else
            v1202
    let v1209 : (string -> string) = v1200.ToString
    let v1210 : string = v1209 v1208
    let _run_target_args'_v173 = v1210 
    #endif
    let v1225 : string = _run_target_args'_v173 
    v1225
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
    
    
    
    
    
    let v2 : string = "Info"
    let v3 : (unit -> string) = v2.ToLower
    let v4 : string = v3 ()
    let v7 : char = v4.[int 0]
    let v8 : string = method13(v7)
    (* run_target_args'
    let v13 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = "inline_colorization::color_bright_green"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v14 
    (* run_target_args'
    let v20 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : string = "&*$0"
    let v22 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v21 
    let _run_target_args'_v20 = v22 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v23 : string = "&*$0"
    let v24 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v23 
    let _run_target_args'_v20 = v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : string = "&*$0"
    let v26 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v25 
    let _run_target_args'_v20 = v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v28 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v32 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v36 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v36 
    #endif
#else
    let v40 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v40 
    #endif
    let v43 : Ref<Str> = _run_target_args'_v20 
    let v49 : string = "inline_colorization::color_reset"
    let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v49 
    let v51 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v15, v43, v50) v51 
    let v53 : string = "fable_library_rust::String_::fromString($0)"
    let v54 : string = Fable.Core.RustInterop.emitRustExpr v52 v53 
    let _run_target_args'_v13 = v54 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v55 : string = "inline_colorization::color_bright_green"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v55 
    (* run_target_args'
    let v61 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v62 : string = "&*$0"
    let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v62 
    let _run_target_args'_v61 = v63 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v64 : string = "&*$0"
    let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v64 
    let _run_target_args'_v61 = v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v66 : string = "&*$0"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v66 
    let _run_target_args'_v61 = v67 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v69 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v69 
    #endif
#if FABLE_COMPILER_PYTHON
    let v73 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v73 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v77 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v77 
    #endif
#else
    let v81 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v81 
    #endif
    let v84 : Ref<Str> = _run_target_args'_v61 
    let v90 : string = "inline_colorization::color_reset"
    let v91 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v90 
    let v92 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v93 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v56, v84, v91) v92 
    let v94 : string = "fable_library_rust::String_::fromString($0)"
    let v95 : string = Fable.Core.RustInterop.emitRustExpr v93 v94 
    let _run_target_args'_v13 = v95 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v96 : string = "inline_colorization::color_bright_green"
    let v97 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v96 
    (* run_target_args'
    let v102 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v103 : string = "&*$0"
    let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v103 
    let _run_target_args'_v102 = v104 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v105 : string = "&*$0"
    let v106 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v105 
    let _run_target_args'_v102 = v106 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v107 : string = "&*$0"
    let v108 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v107 
    let _run_target_args'_v102 = v108 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v110 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v114 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v114 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v118 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v118 
    #endif
#else
    let v122 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v122 
    #endif
    let v125 : Ref<Str> = _run_target_args'_v102 
    let v131 : string = "inline_colorization::color_reset"
    let v132 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v131 
    let v133 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v134 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v97, v125, v132) v133 
    let v135 : string = "fable_library_rust::String_::fromString($0)"
    let v136 : string = Fable.Core.RustInterop.emitRustExpr v134 v135 
    let _run_target_args'_v13 = v136 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v137 : string = "\u001b[92m"
    let v138 : string = method15()
    let v139 : string = v137 + v8 
    let v140 : string = v139 + v138 
    let _run_target_args'_v13 = v140 
    #endif
#if FABLE_COMPILER_PYTHON
    let v141 : string = "\u001b[92m"
    let v142 : string = method15()
    let v143 : string = v141 + v8 
    let v144 : string = v143 + v142 
    let _run_target_args'_v13 = v144 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v145 : string = "\u001b[92m"
    let v146 : string = method15()
    let v147 : string = v145 + v8 
    let v148 : string = v147 + v146 
    let _run_target_args'_v13 = v148 
    #endif
#else
    let v149 : string = "\u001b[92m"
    let v150 : string = method15()
    let v151 : string = v149 + v8 
    let v152 : string = v151 + v150 
    let _run_target_args'_v13 = v152 
    #endif
    let v153 : string = _run_target_args'_v13 
    v153
and method17 (v0 : (string [])) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure8(v2, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v16 : string = "args"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure8(v2, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v27 : string = " = "
    let v28 : string = $"{v27}"
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure8(v2, v28)
    let v33 : unit = (fun () -> v32 (); v31) ()
    let v37 : string = $"%A{v0}"
    let v41 : string = $"{v37}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure8(v2, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v51 : string = " }"
    let v52 : string = $"{v51}"
    let v55 : unit = ()
    let v56 : (unit -> unit) = closure8(v2, v52)
    let v57 : unit = (fun () -> v56 (); v55) ()
    let v60 : string = v2.l0
    v60
and method18 (v0 : string) : string =
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
and method34 (v0 : string, v1 : string, v2 : bool, v3 : (string -> bool), v4 : string) : US8 =
    let v5 : string = method28(v4, v0)
    let v6 : bool = v3 v5
    if v6 then
        US8_0(v4)
    else
        let v8 : string option = method33(v4)
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
            method34(v0, v1, v2, v3, v37)
and method32 (v0 : string, v1 : string, v2 : bool, v3 : (string -> bool)) : US8 =
    let v4 : string = method28(v1, v0)
    let v5 : bool = v3 v4
    if v5 then
        US8_0(v1)
    else
        let v7 : string option = method33(v1)
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
            method34(v0, v1, v2, v3, v36)
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
    
    
    
    
    
    let v2 : string = "Warning"
    let v3 : (unit -> string) = v2.ToLower
    let v4 : string = v3 ()
    let v7 : char = v4.[int 0]
    let v8 : string = method13(v7)
    (* run_target_args'
    let v13 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = "inline_colorization::color_yellow"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v14 
    (* run_target_args'
    let v20 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : string = "&*$0"
    let v22 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v21 
    let _run_target_args'_v20 = v22 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v23 : string = "&*$0"
    let v24 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v23 
    let _run_target_args'_v20 = v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : string = "&*$0"
    let v26 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v25 
    let _run_target_args'_v20 = v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v28 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v32 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v36 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v36 
    #endif
#else
    let v40 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v40 
    #endif
    let v43 : Ref<Str> = _run_target_args'_v20 
    let v49 : string = "inline_colorization::color_reset"
    let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v49 
    let v51 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v15, v43, v50) v51 
    let v53 : string = "fable_library_rust::String_::fromString($0)"
    let v54 : string = Fable.Core.RustInterop.emitRustExpr v52 v53 
    let _run_target_args'_v13 = v54 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v55 : string = "inline_colorization::color_yellow"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v55 
    (* run_target_args'
    let v61 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v62 : string = "&*$0"
    let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v62 
    let _run_target_args'_v61 = v63 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v64 : string = "&*$0"
    let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v64 
    let _run_target_args'_v61 = v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v66 : string = "&*$0"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v66 
    let _run_target_args'_v61 = v67 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v69 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v69 
    #endif
#if FABLE_COMPILER_PYTHON
    let v73 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v73 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v77 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v77 
    #endif
#else
    let v81 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v81 
    #endif
    let v84 : Ref<Str> = _run_target_args'_v61 
    let v90 : string = "inline_colorization::color_reset"
    let v91 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v90 
    let v92 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v93 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v56, v84, v91) v92 
    let v94 : string = "fable_library_rust::String_::fromString($0)"
    let v95 : string = Fable.Core.RustInterop.emitRustExpr v93 v94 
    let _run_target_args'_v13 = v95 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v96 : string = "inline_colorization::color_yellow"
    let v97 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v96 
    (* run_target_args'
    let v102 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v103 : string = "&*$0"
    let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v103 
    let _run_target_args'_v102 = v104 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v105 : string = "&*$0"
    let v106 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v105 
    let _run_target_args'_v102 = v106 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v107 : string = "&*$0"
    let v108 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v107 
    let _run_target_args'_v102 = v108 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v110 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v114 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v114 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v118 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v118 
    #endif
#else
    let v122 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v122 
    #endif
    let v125 : Ref<Str> = _run_target_args'_v102 
    let v131 : string = "inline_colorization::color_reset"
    let v132 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v131 
    let v133 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v134 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v97, v125, v132) v133 
    let v135 : string = "fable_library_rust::String_::fromString($0)"
    let v136 : string = Fable.Core.RustInterop.emitRustExpr v134 v135 
    let _run_target_args'_v13 = v136 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v137 : string = "\u001b[93m"
    let v138 : string = method15()
    let v139 : string = v137 + v8 
    let v140 : string = v139 + v138 
    let _run_target_args'_v13 = v140 
    #endif
#if FABLE_COMPILER_PYTHON
    let v141 : string = "\u001b[93m"
    let v142 : string = method15()
    let v143 : string = v141 + v8 
    let v144 : string = v143 + v142 
    let _run_target_args'_v13 = v144 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v145 : string = "\u001b[93m"
    let v146 : string = method15()
    let v147 : string = v145 + v8 
    let v148 : string = v147 + v146 
    let _run_target_args'_v13 = v148 
    #endif
#else
    let v149 : string = "\u001b[93m"
    let v150 : string = method15()
    let v151 : string = v149 + v8 
    let v152 : string = v151 + v150 
    let _run_target_args'_v13 = v152 
    #endif
    let v153 : string = _run_target_args'_v13 
    v153
and method37 (v0 : string, v1 : string) : string =
    let v2 : string = method14()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure8(v3, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v17 : string = "dir"
    let v18 : string = $"{v17}"
    let v21 : unit = ()
    let v22 : (unit -> unit) = closure8(v3, v18)
    let v23 : unit = (fun () -> v22 (); v21) ()
    let v28 : string = " = "
    let v29 : string = $"{v28}"
    let v32 : unit = ()
    let v33 : (unit -> unit) = closure8(v3, v29)
    let v34 : unit = (fun () -> v33 (); v32) ()
    let v38 : string = $"{v0}"
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure8(v3, v38)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v48 : string = "; "
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure8(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v59 : string = "error"
    let v60 : string = $"{v59}"
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure8(v3, v60)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v69 : string = $"{v28}"
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure8(v3, v69)
    let v74 : unit = (fun () -> v73 (); v72) ()
    let v78 : string = $"{v1}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure8(v3, v78)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v88 : string = " }"
    let v89 : string = $"{v88}"
    let v92 : unit = ()
    let v93 : (unit -> unit) = closure8(v3, v89)
    let v94 : unit = (fun () -> v93 (); v92) ()
    let v97 : string = v3.l0
    v97
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
    let v9 : (string -> US5) = method6()
    let v10 : US5 option = v6 |> Option.map v9 
    let v30 : US5 = US5_1
    let v31 : US5 = v10 |> Option.defaultValue v30 
    let v35 : string = method48(v3)
    let v36 : bool = v2 >= 11uy
    if v36 then
        let v37 : string = $"file_system.read_link / "
        let v38 : string = $"path: {v0} / n: {v2} / path': {v4} / name: {v5}"
        let v39 : string = v37 + v38 
        (* run_target_args'
        let v44 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v45 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v46 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v39 v45 
        let _run_target_args'_v44 = v46 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v47 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v48 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v39 v47 
        let _run_target_args'_v44 = v48 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v49 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v50 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v39 v49 
        let _run_target_args'_v44 = v50 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v52 : std_io_Error = v39 |> unbox<std_io_Error>
        let _run_target_args'_v44 = v52 
        #endif
#if FABLE_COMPILER_PYTHON
        let v56 : std_io_Error = v39 |> unbox<std_io_Error>
        let _run_target_args'_v44 = v56 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v60 : std_io_Error = v39 |> unbox<std_io_Error>
        let _run_target_args'_v44 = v60 
        #endif
#else
        let v64 : std_io_Error = v39 |> unbox<std_io_Error>
        let _run_target_args'_v44 = v64 
        #endif
        let v67 : std_io_Error = _run_target_args'_v44 
        (* run_target_args'
        let v74 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v75 : string = "Err($0)"
        let v76 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v67 v75 
        let _run_target_args'_v74 = v76 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v77 : string = "Err($0)"
        let v78 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v67 v77 
        let _run_target_args'_v74 = v78 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v79 : string = "Err($0)"
        let v80 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v67 v79 
        let _run_target_args'_v74 = v80 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v81 : Result<std_path_PathBuf, std_io_Error> = v67 |> Error
        let _run_target_args'_v74 = v81 
        #endif
#if FABLE_COMPILER_PYTHON
        let v82 : Result<std_path_PathBuf, std_io_Error> = v67 |> Error
        let _run_target_args'_v74 = v82 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v83 : Result<std_path_PathBuf, std_io_Error> = v67 |> Error
        let _run_target_args'_v74 = v83 
        #endif
#else
        let v84 : Result<std_path_PathBuf, std_io_Error> = v67 |> Error
        let _run_target_args'_v74 = v84 
        #endif
        let v85 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v74 
        v85
    else
        match v31 with
        | US5_0(v88) -> (* Some *)
            let v91 : string = ""
            let v92 : bool = v4 <> v91 
            if v92 then
                let v95 : uint8 = v2 + 1uy
                let v96 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v95
                let v97 : Result<std_path_PathBuf, std_io_Error> = v96 v88
                let v98 : (std_io_Error -> string) = method41()
                (* run_target_args'
                let v100 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v101 : string = "$0.map_err(|x| $1(x))"
                let v102 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v97, v98) v101 
                let _run_target_args'_v100 = v102 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v103 : string = "$0.map_err(|x| $1(x))"
                let v104 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v97, v98) v103 
                let _run_target_args'_v100 = v104 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v105 : string = "$0.map_err(|x| $1(x))"
                let v106 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v97, v98) v105 
                let _run_target_args'_v100 = v106 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v107 : Result<std_path_PathBuf, string> = match v97 with Ok x -> Ok x | Error x -> Error (v98 x)
                let _run_target_args'_v100 = v107 
                #endif
#if FABLE_COMPILER_PYTHON
                let v108 : Result<std_path_PathBuf, string> = match v97 with Ok x -> Ok x | Error x -> Error (v98 x)
                let _run_target_args'_v100 = v108 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v109 : Result<std_path_PathBuf, string> = match v97 with Ok x -> Ok x | Error x -> Error (v98 x)
                let _run_target_args'_v100 = v109 
                #endif
#else
                let v110 : Result<std_path_PathBuf, string> = match v97 with Ok x -> Ok x | Error x -> Error (v98 x)
                let _run_target_args'_v100 = v110 
                #endif
                let v111 : Result<std_path_PathBuf, string> = _run_target_args'_v100 
                let v114 : (std_path_PathBuf -> US9) = method43()
                let v115 : (string -> US9) = method44()
                let v117 : US9 = match v111 with Ok x -> v114 x | Error x -> v115 x
                match v117 with
                | US9_1(v273) -> (* Error *)
                    let v274 : string = $"file_system.read_link / "
                    let v275 : string = $"error': {v273} / error: {v35} / name: {v5}"
                    let v276 : string = v274 + v275 
                    (* run_target_args'
                    let v281 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v282 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v283 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v276 v282 
                    let _run_target_args'_v281 = v283 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v284 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v285 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v276 v284 
                    let _run_target_args'_v281 = v285 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v286 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v287 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v276 v286 
                    let _run_target_args'_v281 = v287 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v289 : std_io_Error = v276 |> unbox<std_io_Error>
                    let _run_target_args'_v281 = v289 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v293 : std_io_Error = v276 |> unbox<std_io_Error>
                    let _run_target_args'_v281 = v293 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v297 : std_io_Error = v276 |> unbox<std_io_Error>
                    let _run_target_args'_v281 = v297 
                    #endif
#else
                    let v301 : std_io_Error = v276 |> unbox<std_io_Error>
                    let _run_target_args'_v281 = v301 
                    #endif
                    let v304 : std_io_Error = _run_target_args'_v281 
                    (* run_target_args'
                    let v311 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v312 : string = "Err($0)"
                    let v313 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v304 v312 
                    let _run_target_args'_v311 = v313 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v314 : string = "Err($0)"
                    let v315 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v304 v314 
                    let _run_target_args'_v311 = v315 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v316 : string = "Err($0)"
                    let v317 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v304 v316 
                    let _run_target_args'_v311 = v317 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v318 : Result<std_path_PathBuf, std_io_Error> = v304 |> Error
                    let _run_target_args'_v311 = v318 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v319 : Result<std_path_PathBuf, std_io_Error> = v304 |> Error
                    let _run_target_args'_v311 = v319 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v320 : Result<std_path_PathBuf, std_io_Error> = v304 |> Error
                    let _run_target_args'_v311 = v320 
                    #endif
#else
                    let v321 : Result<std_path_PathBuf, std_io_Error> = v304 |> Error
                    let _run_target_args'_v311 = v321 
                    #endif
                    let v322 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v311 
                    v322
                | US9_0(v120) -> (* Ok *)
                    (* run_target_args'
                    let v125 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v126 : string = "$0.display()"
                    let v127 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v120 v126 
                    let _run_target_args'_v125 = v127 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v128 : string = "$0.display()"
                    let v129 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v120 v128 
                    let _run_target_args'_v125 = v129 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v130 : string = "$0.display()"
                    let v131 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v120 v130 
                    let _run_target_args'_v125 = v131 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v133 : std_path_Display = v120 |> unbox<std_path_Display>
                    let _run_target_args'_v125 = v133 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v137 : std_path_Display = v120 |> unbox<std_path_Display>
                    let _run_target_args'_v125 = v137 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v141 : std_path_Display = v120 |> unbox<std_path_Display>
                    let _run_target_args'_v125 = v141 
                    #endif
#else
                    let v145 : std_path_Display = v120 |> unbox<std_path_Display>
                    let _run_target_args'_v125 = v145 
                    #endif
                    let v148 : std_path_Display = _run_target_args'_v125 
                    let v155 : string = v148 |> string 
                    let v158 : string = method28(v155, v5)
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
                    (* run_target_args'
                    let v196 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v197 : string = "String::from($0)"
                    let v198 : std_string_String = Fable.Core.RustInterop.emitRustExpr v186 v197 
                    let _run_target_args'_v196 = v198 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v199 : string = "String::from($0)"
                    let v200 : std_string_String = Fable.Core.RustInterop.emitRustExpr v186 v199 
                    let _run_target_args'_v196 = v200 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v201 : string = "String::from($0)"
                    let v202 : std_string_String = Fable.Core.RustInterop.emitRustExpr v186 v201 
                    let _run_target_args'_v196 = v202 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v204 : std_string_String = v186 |> unbox<std_string_String>
                    let _run_target_args'_v196 = v204 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v208 : std_string_String = v186 |> unbox<std_string_String>
                    let _run_target_args'_v196 = v208 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v212 : std_string_String = v186 |> unbox<std_string_String>
                    let _run_target_args'_v196 = v212 
                    #endif
#else
                    let v216 : std_string_String = v186 |> unbox<std_string_String>
                    let _run_target_args'_v196 = v216 
                    #endif
                    let v219 : std_string_String = _run_target_args'_v196 
                    (* run_target_args'
                    let v229 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v230 : string = "std::path::PathBuf::from($0)"
                    let v231 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v219 v230 
                    let _run_target_args'_v229 = v231 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v232 : string = "std::path::PathBuf::from($0)"
                    let v233 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v219 v232 
                    let _run_target_args'_v229 = v233 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v234 : string = "std::path::PathBuf::from($0)"
                    let v235 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v219 v234 
                    let _run_target_args'_v229 = v235 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v237 : std_path_PathBuf = v219 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v229 = v237 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v241 : std_path_PathBuf = v219 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v229 = v241 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v245 : std_path_PathBuf = v219 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v229 = v245 
                    #endif
#else
                    let v249 : std_path_PathBuf = v219 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v229 = v249 
                    #endif
                    let v252 : std_path_PathBuf = _run_target_args'_v229 
                    (* run_target_args'
                    let v259 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v260 : string = "Ok($0)"
                    let v261 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v252 v260 
                    let _run_target_args'_v259 = v261 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v262 : string = "Ok($0)"
                    let v263 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v252 v262 
                    let _run_target_args'_v259 = v263 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v264 : string = "Ok($0)"
                    let v265 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v252 v264 
                    let _run_target_args'_v259 = v265 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v266 : Result<std_path_PathBuf, std_io_Error> = v252 |> Ok
                    let _run_target_args'_v259 = v266 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v267 : Result<std_path_PathBuf, std_io_Error> = v252 |> Ok
                    let _run_target_args'_v259 = v267 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v268 : Result<std_path_PathBuf, std_io_Error> = v252 |> Ok
                    let _run_target_args'_v259 = v268 
                    #endif
#else
                    let v269 : Result<std_path_PathBuf, std_io_Error> = v252 |> Ok
                    let _run_target_args'_v259 = v269 
                    #endif
                    let v270 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v259 
                    v270
            else
                let v327 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v328 : string = $"path: {v0} / error: {v35} / path': {v4} / name: {v5}"
                let v329 : string = v327 + v328 
                (* run_target_args'
                let v334 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v335 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v336 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v329 v335 
                let _run_target_args'_v334 = v336 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v337 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v338 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v329 v337 
                let _run_target_args'_v334 = v338 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v339 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v340 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v329 v339 
                let _run_target_args'_v334 = v340 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v342 : std_io_Error = v329 |> unbox<std_io_Error>
                let _run_target_args'_v334 = v342 
                #endif
#if FABLE_COMPILER_PYTHON
                let v346 : std_io_Error = v329 |> unbox<std_io_Error>
                let _run_target_args'_v334 = v346 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v350 : std_io_Error = v329 |> unbox<std_io_Error>
                let _run_target_args'_v334 = v350 
                #endif
#else
                let v354 : std_io_Error = v329 |> unbox<std_io_Error>
                let _run_target_args'_v334 = v354 
                #endif
                let v357 : std_io_Error = _run_target_args'_v334 
                (* run_target_args'
                let v364 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v365 : string = "Err($0)"
                let v366 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v357 v365 
                let _run_target_args'_v364 = v366 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v367 : string = "Err($0)"
                let v368 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v357 v367 
                let _run_target_args'_v364 = v368 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v369 : string = "Err($0)"
                let v370 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v357 v369 
                let _run_target_args'_v364 = v370 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v371 : Result<std_path_PathBuf, std_io_Error> = v357 |> Error
                let _run_target_args'_v364 = v371 
                #endif
#if FABLE_COMPILER_PYTHON
                let v372 : Result<std_path_PathBuf, std_io_Error> = v357 |> Error
                let _run_target_args'_v364 = v372 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v373 : Result<std_path_PathBuf, std_io_Error> = v357 |> Error
                let _run_target_args'_v364 = v373 
                #endif
#else
                let v374 : Result<std_path_PathBuf, std_io_Error> = v357 |> Error
                let _run_target_args'_v364 = v374 
                #endif
                let v375 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v364 
                v375
        | _ ->
            let v379 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v380 : string = $"path: {v0} / error: {v35} / path': {v4} / name: {v5}"
            let v381 : string = v379 + v380 
            (* run_target_args'
            let v386 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v387 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v388 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v381 v387 
            let _run_target_args'_v386 = v388 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v389 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v390 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v381 v389 
            let _run_target_args'_v386 = v390 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v391 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v392 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v381 v391 
            let _run_target_args'_v386 = v392 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v394 : std_io_Error = v381 |> unbox<std_io_Error>
            let _run_target_args'_v386 = v394 
            #endif
#if FABLE_COMPILER_PYTHON
            let v398 : std_io_Error = v381 |> unbox<std_io_Error>
            let _run_target_args'_v386 = v398 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v402 : std_io_Error = v381 |> unbox<std_io_Error>
            let _run_target_args'_v386 = v402 
            #endif
#else
            let v406 : std_io_Error = v381 |> unbox<std_io_Error>
            let _run_target_args'_v386 = v406 
            #endif
            let v409 : std_io_Error = _run_target_args'_v386 
            (* run_target_args'
            let v416 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v417 : string = "Err($0)"
            let v418 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v409 v417 
            let _run_target_args'_v416 = v418 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v419 : string = "Err($0)"
            let v420 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v409 v419 
            let _run_target_args'_v416 = v420 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v421 : string = "Err($0)"
            let v422 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v409 v421 
            let _run_target_args'_v416 = v422 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v423 : Result<std_path_PathBuf, std_io_Error> = v409 |> Error
            let _run_target_args'_v416 = v423 
            #endif
#if FABLE_COMPILER_PYTHON
            let v424 : Result<std_path_PathBuf, std_io_Error> = v409 |> Error
            let _run_target_args'_v416 = v424 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v425 : Result<std_path_PathBuf, std_io_Error> = v409 |> Error
            let _run_target_args'_v416 = v425 
            #endif
#else
            let v426 : Result<std_path_PathBuf, std_io_Error> = v409 |> Error
            let _run_target_args'_v416 = v426 
            #endif
            let v427 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v416 
            v427
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
    let v29 : US9 = match v23 with Ok x -> v26 x | Error x -> v27 x
    let v52 : Result<std_path_PathBuf, std_io_Error> =
        match v29 with
        | US9_1(v48) -> (* Error *)
            let v49 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method46(v0, v49, v1, v48, v2)
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
    let v55 : (std_io_Error -> string) = method41()
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
    let v71 : (std_path_PathBuf -> US9) = method43()
    let v72 : (string -> US9) = method44()
    let v74 : US9 = match v68 with Ok x -> v71 x | Error x -> v72 x
    let v97 : Result<std_path_PathBuf, std_io_Error> =
        match v74 with
        | US9_1(v93) -> (* Error *)
            let v94 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method46(v0, v94, v1, v93, v2)
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
    let v100 : (std_io_Error -> string) = method41()
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
    let v116 : (std_path_PathBuf -> US9) = method43()
    let v117 : (string -> US9) = method44()
    let v119 : US9 = match v113 with Ok x -> v116 x | Error x -> v117 x
    let v142 : Result<std_path_PathBuf, std_io_Error> =
        match v119 with
        | US9_1(v138) -> (* Error *)
            let v139 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method46(v0, v139, v1, v138, v2)
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
    method45(v0, v1, v2)
and closure19 (v0 : string) (v1 : uint8) : (string -> Result<std_path_PathBuf, std_io_Error>) =
    closure20(v0, v1)
and method49 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v4 : string = method47(v0)
    let v5 : string option = method33(v0)
    let v8 : (string -> US5) = method6()
    let v9 : US5 option = v5 |> Option.map v8 
    let v29 : US5 = US5_1
    let v30 : US5 = v9 |> Option.defaultValue v29 
    let v34 : string = method48(v3)
    let v35 : bool = v2 >= 11uy
    if v35 then
        let v36 : string = $"file_system.read_link / "
        let v37 : string = $"path: {v0} / n: {v2} / path': {v0} / name: {v4}"
        let v38 : string = v36 + v37 
        (* run_target_args'
        let v43 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v44 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v45 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v38 v44 
        let _run_target_args'_v43 = v45 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v46 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v47 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v38 v46 
        let _run_target_args'_v43 = v47 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v48 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v49 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v38 v48 
        let _run_target_args'_v43 = v49 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v51 : std_io_Error = v38 |> unbox<std_io_Error>
        let _run_target_args'_v43 = v51 
        #endif
#if FABLE_COMPILER_PYTHON
        let v55 : std_io_Error = v38 |> unbox<std_io_Error>
        let _run_target_args'_v43 = v55 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v59 : std_io_Error = v38 |> unbox<std_io_Error>
        let _run_target_args'_v43 = v59 
        #endif
#else
        let v63 : std_io_Error = v38 |> unbox<std_io_Error>
        let _run_target_args'_v43 = v63 
        #endif
        let v66 : std_io_Error = _run_target_args'_v43 
        (* run_target_args'
        let v73 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v74 : string = "Err($0)"
        let v75 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v66 v74 
        let _run_target_args'_v73 = v75 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v76 : string = "Err($0)"
        let v77 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v66 v76 
        let _run_target_args'_v73 = v77 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v78 : string = "Err($0)"
        let v79 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v66 v78 
        let _run_target_args'_v73 = v79 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v80 : Result<std_path_PathBuf, std_io_Error> = v66 |> Error
        let _run_target_args'_v73 = v80 
        #endif
#if FABLE_COMPILER_PYTHON
        let v81 : Result<std_path_PathBuf, std_io_Error> = v66 |> Error
        let _run_target_args'_v73 = v81 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v82 : Result<std_path_PathBuf, std_io_Error> = v66 |> Error
        let _run_target_args'_v73 = v82 
        #endif
#else
        let v83 : Result<std_path_PathBuf, std_io_Error> = v66 |> Error
        let _run_target_args'_v73 = v83 
        #endif
        let v84 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v73 
        v84
    else
        match v30 with
        | US5_0(v87) -> (* Some *)
            let v90 : string = ""
            let v91 : bool = v0 <> v90 
            if v91 then
                let v94 : uint8 = v2 + 1uy
                let v95 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v94
                let v96 : Result<std_path_PathBuf, std_io_Error> = v95 v87
                let v97 : (std_io_Error -> string) = method41()
                (* run_target_args'
                let v99 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v100 : string = "$0.map_err(|x| $1(x))"
                let v101 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v96, v97) v100 
                let _run_target_args'_v99 = v101 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v102 : string = "$0.map_err(|x| $1(x))"
                let v103 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v96, v97) v102 
                let _run_target_args'_v99 = v103 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v104 : string = "$0.map_err(|x| $1(x))"
                let v105 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v96, v97) v104 
                let _run_target_args'_v99 = v105 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v106 : Result<std_path_PathBuf, string> = match v96 with Ok x -> Ok x | Error x -> Error (v97 x)
                let _run_target_args'_v99 = v106 
                #endif
#if FABLE_COMPILER_PYTHON
                let v107 : Result<std_path_PathBuf, string> = match v96 with Ok x -> Ok x | Error x -> Error (v97 x)
                let _run_target_args'_v99 = v107 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v108 : Result<std_path_PathBuf, string> = match v96 with Ok x -> Ok x | Error x -> Error (v97 x)
                let _run_target_args'_v99 = v108 
                #endif
#else
                let v109 : Result<std_path_PathBuf, string> = match v96 with Ok x -> Ok x | Error x -> Error (v97 x)
                let _run_target_args'_v99 = v109 
                #endif
                let v110 : Result<std_path_PathBuf, string> = _run_target_args'_v99 
                let v113 : (std_path_PathBuf -> US9) = method43()
                let v114 : (string -> US9) = method44()
                let v116 : US9 = match v110 with Ok x -> v113 x | Error x -> v114 x
                match v116 with
                | US9_1(v272) -> (* Error *)
                    let v273 : string = $"file_system.read_link / "
                    let v274 : string = $"error': {v272} / error: {v34} / name: {v4}"
                    let v275 : string = v273 + v274 
                    (* run_target_args'
                    let v280 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v281 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v282 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v275 v281 
                    let _run_target_args'_v280 = v282 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v283 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v284 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v275 v283 
                    let _run_target_args'_v280 = v284 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v285 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v286 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v275 v285 
                    let _run_target_args'_v280 = v286 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v288 : std_io_Error = v275 |> unbox<std_io_Error>
                    let _run_target_args'_v280 = v288 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v292 : std_io_Error = v275 |> unbox<std_io_Error>
                    let _run_target_args'_v280 = v292 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v296 : std_io_Error = v275 |> unbox<std_io_Error>
                    let _run_target_args'_v280 = v296 
                    #endif
#else
                    let v300 : std_io_Error = v275 |> unbox<std_io_Error>
                    let _run_target_args'_v280 = v300 
                    #endif
                    let v303 : std_io_Error = _run_target_args'_v280 
                    (* run_target_args'
                    let v310 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v311 : string = "Err($0)"
                    let v312 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v303 v311 
                    let _run_target_args'_v310 = v312 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v313 : string = "Err($0)"
                    let v314 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v303 v313 
                    let _run_target_args'_v310 = v314 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v315 : string = "Err($0)"
                    let v316 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v303 v315 
                    let _run_target_args'_v310 = v316 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v317 : Result<std_path_PathBuf, std_io_Error> = v303 |> Error
                    let _run_target_args'_v310 = v317 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v318 : Result<std_path_PathBuf, std_io_Error> = v303 |> Error
                    let _run_target_args'_v310 = v318 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v319 : Result<std_path_PathBuf, std_io_Error> = v303 |> Error
                    let _run_target_args'_v310 = v319 
                    #endif
#else
                    let v320 : Result<std_path_PathBuf, std_io_Error> = v303 |> Error
                    let _run_target_args'_v310 = v320 
                    #endif
                    let v321 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v310 
                    v321
                | US9_0(v119) -> (* Ok *)
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
                    let v154 : string = v147 |> string 
                    let v157 : string = method28(v154, v4)
                    (* run_target_args'
                    let v162 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v163 : string = "&*$0"
                    let v164 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v157 v163 
                    let _run_target_args'_v162 = v164 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v165 : string = "&*$0"
                    let v166 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v157 v165 
                    let _run_target_args'_v162 = v166 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v167 : string = "&*$0"
                    let v168 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v157 v167 
                    let _run_target_args'_v162 = v168 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v170 : Ref<Str> = v157 |> unbox<Ref<Str>>
                    let _run_target_args'_v162 = v170 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v174 : Ref<Str> = v157 |> unbox<Ref<Str>>
                    let _run_target_args'_v162 = v174 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v178 : Ref<Str> = v157 |> unbox<Ref<Str>>
                    let _run_target_args'_v162 = v178 
                    #endif
#else
                    let v182 : Ref<Str> = v157 |> unbox<Ref<Str>>
                    let _run_target_args'_v162 = v182 
                    #endif
                    let v185 : Ref<Str> = _run_target_args'_v162 
                    (* run_target_args'
                    let v195 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v196 : string = "String::from($0)"
                    let v197 : std_string_String = Fable.Core.RustInterop.emitRustExpr v185 v196 
                    let _run_target_args'_v195 = v197 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v198 : string = "String::from($0)"
                    let v199 : std_string_String = Fable.Core.RustInterop.emitRustExpr v185 v198 
                    let _run_target_args'_v195 = v199 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v200 : string = "String::from($0)"
                    let v201 : std_string_String = Fable.Core.RustInterop.emitRustExpr v185 v200 
                    let _run_target_args'_v195 = v201 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v203 : std_string_String = v185 |> unbox<std_string_String>
                    let _run_target_args'_v195 = v203 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v207 : std_string_String = v185 |> unbox<std_string_String>
                    let _run_target_args'_v195 = v207 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v211 : std_string_String = v185 |> unbox<std_string_String>
                    let _run_target_args'_v195 = v211 
                    #endif
#else
                    let v215 : std_string_String = v185 |> unbox<std_string_String>
                    let _run_target_args'_v195 = v215 
                    #endif
                    let v218 : std_string_String = _run_target_args'_v195 
                    (* run_target_args'
                    let v228 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v229 : string = "std::path::PathBuf::from($0)"
                    let v230 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v218 v229 
                    let _run_target_args'_v228 = v230 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v231 : string = "std::path::PathBuf::from($0)"
                    let v232 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v218 v231 
                    let _run_target_args'_v228 = v232 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v233 : string = "std::path::PathBuf::from($0)"
                    let v234 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v218 v233 
                    let _run_target_args'_v228 = v234 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v236 : std_path_PathBuf = v218 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v228 = v236 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v240 : std_path_PathBuf = v218 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v228 = v240 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v244 : std_path_PathBuf = v218 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v228 = v244 
                    #endif
#else
                    let v248 : std_path_PathBuf = v218 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v228 = v248 
                    #endif
                    let v251 : std_path_PathBuf = _run_target_args'_v228 
                    (* run_target_args'
                    let v258 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v259 : string = "Ok($0)"
                    let v260 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v251 v259 
                    let _run_target_args'_v258 = v260 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v261 : string = "Ok($0)"
                    let v262 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v251 v261 
                    let _run_target_args'_v258 = v262 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v263 : string = "Ok($0)"
                    let v264 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v251 v263 
                    let _run_target_args'_v258 = v264 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v265 : Result<std_path_PathBuf, std_io_Error> = v251 |> Ok
                    let _run_target_args'_v258 = v265 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v266 : Result<std_path_PathBuf, std_io_Error> = v251 |> Ok
                    let _run_target_args'_v258 = v266 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v267 : Result<std_path_PathBuf, std_io_Error> = v251 |> Ok
                    let _run_target_args'_v258 = v267 
                    #endif
#else
                    let v268 : Result<std_path_PathBuf, std_io_Error> = v251 |> Ok
                    let _run_target_args'_v258 = v268 
                    #endif
                    let v269 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v258 
                    v269
            else
                let v326 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v327 : string = $"path: {v0} / error: {v34} / path': {v0} / name: {v4}"
                let v328 : string = v326 + v327 
                (* run_target_args'
                let v333 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v334 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v335 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v328 v334 
                let _run_target_args'_v333 = v335 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v336 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v337 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v328 v336 
                let _run_target_args'_v333 = v337 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v338 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v339 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v328 v338 
                let _run_target_args'_v333 = v339 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v341 : std_io_Error = v328 |> unbox<std_io_Error>
                let _run_target_args'_v333 = v341 
                #endif
#if FABLE_COMPILER_PYTHON
                let v345 : std_io_Error = v328 |> unbox<std_io_Error>
                let _run_target_args'_v333 = v345 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v349 : std_io_Error = v328 |> unbox<std_io_Error>
                let _run_target_args'_v333 = v349 
                #endif
#else
                let v353 : std_io_Error = v328 |> unbox<std_io_Error>
                let _run_target_args'_v333 = v353 
                #endif
                let v356 : std_io_Error = _run_target_args'_v333 
                (* run_target_args'
                let v363 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v364 : string = "Err($0)"
                let v365 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v356 v364 
                let _run_target_args'_v363 = v365 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v366 : string = "Err($0)"
                let v367 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v356 v366 
                let _run_target_args'_v363 = v367 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v368 : string = "Err($0)"
                let v369 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v356 v368 
                let _run_target_args'_v363 = v369 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v370 : Result<std_path_PathBuf, std_io_Error> = v356 |> Error
                let _run_target_args'_v363 = v370 
                #endif
#if FABLE_COMPILER_PYTHON
                let v371 : Result<std_path_PathBuf, std_io_Error> = v356 |> Error
                let _run_target_args'_v363 = v371 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v372 : Result<std_path_PathBuf, std_io_Error> = v356 |> Error
                let _run_target_args'_v363 = v372 
                #endif
#else
                let v373 : Result<std_path_PathBuf, std_io_Error> = v356 |> Error
                let _run_target_args'_v363 = v373 
                #endif
                let v374 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v363 
                v374
        | _ ->
            let v378 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v379 : string = $"path: {v0} / error: {v34} / path': {v0} / name: {v4}"
            let v380 : string = v378 + v379 
            (* run_target_args'
            let v385 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v386 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v387 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v380 v386 
            let _run_target_args'_v385 = v387 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v388 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v389 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v380 v388 
            let _run_target_args'_v385 = v389 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v390 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v391 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v380 v390 
            let _run_target_args'_v385 = v391 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v393 : std_io_Error = v380 |> unbox<std_io_Error>
            let _run_target_args'_v385 = v393 
            #endif
#if FABLE_COMPILER_PYTHON
            let v397 : std_io_Error = v380 |> unbox<std_io_Error>
            let _run_target_args'_v385 = v397 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v401 : std_io_Error = v380 |> unbox<std_io_Error>
            let _run_target_args'_v385 = v401 
            #endif
#else
            let v405 : std_io_Error = v380 |> unbox<std_io_Error>
            let _run_target_args'_v385 = v405 
            #endif
            let v408 : std_io_Error = _run_target_args'_v385 
            (* run_target_args'
            let v415 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v416 : string = "Err($0)"
            let v417 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v408 v416 
            let _run_target_args'_v415 = v417 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v418 : string = "Err($0)"
            let v419 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v408 v418 
            let _run_target_args'_v415 = v419 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v420 : string = "Err($0)"
            let v421 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v408 v420 
            let _run_target_args'_v415 = v421 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v422 : Result<std_path_PathBuf, std_io_Error> = v408 |> Error
            let _run_target_args'_v415 = v422 
            #endif
#if FABLE_COMPILER_PYTHON
            let v423 : Result<std_path_PathBuf, std_io_Error> = v408 |> Error
            let _run_target_args'_v415 = v423 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v424 : Result<std_path_PathBuf, std_io_Error> = v408 |> Error
            let _run_target_args'_v415 = v424 
            #endif
#else
            let v425 : Result<std_path_PathBuf, std_io_Error> = v408 |> Error
            let _run_target_args'_v415 = v425 
            #endif
            let v426 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v415 
            v426
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
    let v28 : US9 = match v22 with Ok x -> v25 x | Error x -> v26 x
    let v51 : Result<std_path_PathBuf, std_io_Error> =
        match v28 with
        | US9_1(v47) -> (* Error *)
            let v48 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method49(v0, v48, v1, v47)
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
    let v54 : (std_io_Error -> string) = method41()
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
    let v70 : (std_path_PathBuf -> US9) = method43()
    let v71 : (string -> US9) = method44()
    let v73 : US9 = match v67 with Ok x -> v70 x | Error x -> v71 x
    let v96 : Result<std_path_PathBuf, std_io_Error> =
        match v73 with
        | US9_1(v92) -> (* Error *)
            let v93 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method49(v0, v93, v1, v92)
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
    let v99 : (std_io_Error -> string) = method41()
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
    let v115 : (std_path_PathBuf -> US9) = method43()
    let v116 : (string -> US9) = method44()
    let v118 : US9 = match v112 with Ok x -> v115 x | Error x -> v116 x
    let v141 : Result<std_path_PathBuf, std_io_Error> =
        match v118 with
        | US9_1(v137) -> (* Error *)
            let v138 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method49(v0, v138, v1, v137)
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
    let v9 : (string -> US5) = method6()
    let v10 : US5 option = v6 |> Option.map v9 
    let v30 : US5 = US5_1
    let v31 : US5 = v10 |> Option.defaultValue v30 
    let v35 : string = method42(v3)
    let v36 : bool = v2 >= 11uy
    if v36 then
        let v37 : string = $"file_system.read_link / "
        let v38 : string = $"path: {v0} / n: {v2} / path': {v4} / name: {v5}"
        let v39 : string = v37 + v38 
        (* run_target_args'
        let v44 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v45 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v46 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v39 v45 
        let _run_target_args'_v44 = v46 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v47 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v48 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v39 v47 
        let _run_target_args'_v44 = v48 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v49 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v50 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v39 v49 
        let _run_target_args'_v44 = v50 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v52 : std_io_Error = v39 |> unbox<std_io_Error>
        let _run_target_args'_v44 = v52 
        #endif
#if FABLE_COMPILER_PYTHON
        let v56 : std_io_Error = v39 |> unbox<std_io_Error>
        let _run_target_args'_v44 = v56 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v60 : std_io_Error = v39 |> unbox<std_io_Error>
        let _run_target_args'_v44 = v60 
        #endif
#else
        let v64 : std_io_Error = v39 |> unbox<std_io_Error>
        let _run_target_args'_v44 = v64 
        #endif
        let v67 : std_io_Error = _run_target_args'_v44 
        (* run_target_args'
        let v74 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v75 : string = "Err($0)"
        let v76 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v67 v75 
        let _run_target_args'_v74 = v76 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v77 : string = "Err($0)"
        let v78 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v67 v77 
        let _run_target_args'_v74 = v78 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v79 : string = "Err($0)"
        let v80 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v67 v79 
        let _run_target_args'_v74 = v80 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v81 : Result<std_path_PathBuf, std_io_Error> = v67 |> Error
        let _run_target_args'_v74 = v81 
        #endif
#if FABLE_COMPILER_PYTHON
        let v82 : Result<std_path_PathBuf, std_io_Error> = v67 |> Error
        let _run_target_args'_v74 = v82 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v83 : Result<std_path_PathBuf, std_io_Error> = v67 |> Error
        let _run_target_args'_v74 = v83 
        #endif
#else
        let v84 : Result<std_path_PathBuf, std_io_Error> = v67 |> Error
        let _run_target_args'_v74 = v84 
        #endif
        let v85 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v74 
        v85
    else
        match v31 with
        | US5_0(v88) -> (* Some *)
            let v91 : string = ""
            let v92 : bool = v4 <> v91 
            if v92 then
                let v95 : uint8 = v2 + 1uy
                let v96 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v95
                let v97 : Result<std_path_PathBuf, std_io_Error> = v96 v88
                let v98 : (std_io_Error -> string) = method41()
                (* run_target_args'
                let v100 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v101 : string = "$0.map_err(|x| $1(x))"
                let v102 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v97, v98) v101 
                let _run_target_args'_v100 = v102 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v103 : string = "$0.map_err(|x| $1(x))"
                let v104 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v97, v98) v103 
                let _run_target_args'_v100 = v104 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v105 : string = "$0.map_err(|x| $1(x))"
                let v106 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v97, v98) v105 
                let _run_target_args'_v100 = v106 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v107 : Result<std_path_PathBuf, string> = match v97 with Ok x -> Ok x | Error x -> Error (v98 x)
                let _run_target_args'_v100 = v107 
                #endif
#if FABLE_COMPILER_PYTHON
                let v108 : Result<std_path_PathBuf, string> = match v97 with Ok x -> Ok x | Error x -> Error (v98 x)
                let _run_target_args'_v100 = v108 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v109 : Result<std_path_PathBuf, string> = match v97 with Ok x -> Ok x | Error x -> Error (v98 x)
                let _run_target_args'_v100 = v109 
                #endif
#else
                let v110 : Result<std_path_PathBuf, string> = match v97 with Ok x -> Ok x | Error x -> Error (v98 x)
                let _run_target_args'_v100 = v110 
                #endif
                let v111 : Result<std_path_PathBuf, string> = _run_target_args'_v100 
                let v114 : (std_path_PathBuf -> US9) = method43()
                let v115 : (string -> US9) = method44()
                let v117 : US9 = match v111 with Ok x -> v114 x | Error x -> v115 x
                match v117 with
                | US9_1(v273) -> (* Error *)
                    let v274 : string = $"file_system.read_link / "
                    let v275 : string = $"error': {v273} / error: {v35} / name: {v5}"
                    let v276 : string = v274 + v275 
                    (* run_target_args'
                    let v281 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v282 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v283 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v276 v282 
                    let _run_target_args'_v281 = v283 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v284 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v285 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v276 v284 
                    let _run_target_args'_v281 = v285 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v286 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v287 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v276 v286 
                    let _run_target_args'_v281 = v287 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v289 : std_io_Error = v276 |> unbox<std_io_Error>
                    let _run_target_args'_v281 = v289 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v293 : std_io_Error = v276 |> unbox<std_io_Error>
                    let _run_target_args'_v281 = v293 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v297 : std_io_Error = v276 |> unbox<std_io_Error>
                    let _run_target_args'_v281 = v297 
                    #endif
#else
                    let v301 : std_io_Error = v276 |> unbox<std_io_Error>
                    let _run_target_args'_v281 = v301 
                    #endif
                    let v304 : std_io_Error = _run_target_args'_v281 
                    (* run_target_args'
                    let v311 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v312 : string = "Err($0)"
                    let v313 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v304 v312 
                    let _run_target_args'_v311 = v313 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v314 : string = "Err($0)"
                    let v315 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v304 v314 
                    let _run_target_args'_v311 = v315 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v316 : string = "Err($0)"
                    let v317 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v304 v316 
                    let _run_target_args'_v311 = v317 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v318 : Result<std_path_PathBuf, std_io_Error> = v304 |> Error
                    let _run_target_args'_v311 = v318 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v319 : Result<std_path_PathBuf, std_io_Error> = v304 |> Error
                    let _run_target_args'_v311 = v319 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v320 : Result<std_path_PathBuf, std_io_Error> = v304 |> Error
                    let _run_target_args'_v311 = v320 
                    #endif
#else
                    let v321 : Result<std_path_PathBuf, std_io_Error> = v304 |> Error
                    let _run_target_args'_v311 = v321 
                    #endif
                    let v322 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v311 
                    v322
                | US9_0(v120) -> (* Ok *)
                    (* run_target_args'
                    let v125 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v126 : string = "$0.display()"
                    let v127 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v120 v126 
                    let _run_target_args'_v125 = v127 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v128 : string = "$0.display()"
                    let v129 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v120 v128 
                    let _run_target_args'_v125 = v129 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v130 : string = "$0.display()"
                    let v131 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v120 v130 
                    let _run_target_args'_v125 = v131 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v133 : std_path_Display = v120 |> unbox<std_path_Display>
                    let _run_target_args'_v125 = v133 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v137 : std_path_Display = v120 |> unbox<std_path_Display>
                    let _run_target_args'_v125 = v137 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v141 : std_path_Display = v120 |> unbox<std_path_Display>
                    let _run_target_args'_v125 = v141 
                    #endif
#else
                    let v145 : std_path_Display = v120 |> unbox<std_path_Display>
                    let _run_target_args'_v125 = v145 
                    #endif
                    let v148 : std_path_Display = _run_target_args'_v125 
                    let v155 : string = v148 |> string 
                    let v158 : string = method28(v155, v5)
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
                    (* run_target_args'
                    let v196 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v197 : string = "String::from($0)"
                    let v198 : std_string_String = Fable.Core.RustInterop.emitRustExpr v186 v197 
                    let _run_target_args'_v196 = v198 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v199 : string = "String::from($0)"
                    let v200 : std_string_String = Fable.Core.RustInterop.emitRustExpr v186 v199 
                    let _run_target_args'_v196 = v200 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v201 : string = "String::from($0)"
                    let v202 : std_string_String = Fable.Core.RustInterop.emitRustExpr v186 v201 
                    let _run_target_args'_v196 = v202 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v204 : std_string_String = v186 |> unbox<std_string_String>
                    let _run_target_args'_v196 = v204 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v208 : std_string_String = v186 |> unbox<std_string_String>
                    let _run_target_args'_v196 = v208 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v212 : std_string_String = v186 |> unbox<std_string_String>
                    let _run_target_args'_v196 = v212 
                    #endif
#else
                    let v216 : std_string_String = v186 |> unbox<std_string_String>
                    let _run_target_args'_v196 = v216 
                    #endif
                    let v219 : std_string_String = _run_target_args'_v196 
                    (* run_target_args'
                    let v229 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v230 : string = "std::path::PathBuf::from($0)"
                    let v231 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v219 v230 
                    let _run_target_args'_v229 = v231 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v232 : string = "std::path::PathBuf::from($0)"
                    let v233 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v219 v232 
                    let _run_target_args'_v229 = v233 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v234 : string = "std::path::PathBuf::from($0)"
                    let v235 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v219 v234 
                    let _run_target_args'_v229 = v235 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v237 : std_path_PathBuf = v219 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v229 = v237 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v241 : std_path_PathBuf = v219 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v229 = v241 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v245 : std_path_PathBuf = v219 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v229 = v245 
                    #endif
#else
                    let v249 : std_path_PathBuf = v219 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v229 = v249 
                    #endif
                    let v252 : std_path_PathBuf = _run_target_args'_v229 
                    (* run_target_args'
                    let v259 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v260 : string = "Ok($0)"
                    let v261 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v252 v260 
                    let _run_target_args'_v259 = v261 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v262 : string = "Ok($0)"
                    let v263 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v252 v262 
                    let _run_target_args'_v259 = v263 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v264 : string = "Ok($0)"
                    let v265 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v252 v264 
                    let _run_target_args'_v259 = v265 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v266 : Result<std_path_PathBuf, std_io_Error> = v252 |> Ok
                    let _run_target_args'_v259 = v266 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v267 : Result<std_path_PathBuf, std_io_Error> = v252 |> Ok
                    let _run_target_args'_v259 = v267 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v268 : Result<std_path_PathBuf, std_io_Error> = v252 |> Ok
                    let _run_target_args'_v259 = v268 
                    #endif
#else
                    let v269 : Result<std_path_PathBuf, std_io_Error> = v252 |> Ok
                    let _run_target_args'_v259 = v269 
                    #endif
                    let v270 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v259 
                    v270
            else
                let v327 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v328 : string = $"path: {v0} / error: {v35} / path': {v4} / name: {v5}"
                let v329 : string = v327 + v328 
                (* run_target_args'
                let v334 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v335 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v336 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v329 v335 
                let _run_target_args'_v334 = v336 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v337 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v338 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v329 v337 
                let _run_target_args'_v334 = v338 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v339 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v340 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v329 v339 
                let _run_target_args'_v334 = v340 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v342 : std_io_Error = v329 |> unbox<std_io_Error>
                let _run_target_args'_v334 = v342 
                #endif
#if FABLE_COMPILER_PYTHON
                let v346 : std_io_Error = v329 |> unbox<std_io_Error>
                let _run_target_args'_v334 = v346 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v350 : std_io_Error = v329 |> unbox<std_io_Error>
                let _run_target_args'_v334 = v350 
                #endif
#else
                let v354 : std_io_Error = v329 |> unbox<std_io_Error>
                let _run_target_args'_v334 = v354 
                #endif
                let v357 : std_io_Error = _run_target_args'_v334 
                (* run_target_args'
                let v364 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v365 : string = "Err($0)"
                let v366 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v357 v365 
                let _run_target_args'_v364 = v366 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v367 : string = "Err($0)"
                let v368 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v357 v367 
                let _run_target_args'_v364 = v368 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v369 : string = "Err($0)"
                let v370 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v357 v369 
                let _run_target_args'_v364 = v370 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v371 : Result<std_path_PathBuf, std_io_Error> = v357 |> Error
                let _run_target_args'_v364 = v371 
                #endif
#if FABLE_COMPILER_PYTHON
                let v372 : Result<std_path_PathBuf, std_io_Error> = v357 |> Error
                let _run_target_args'_v364 = v372 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v373 : Result<std_path_PathBuf, std_io_Error> = v357 |> Error
                let _run_target_args'_v364 = v373 
                #endif
#else
                let v374 : Result<std_path_PathBuf, std_io_Error> = v357 |> Error
                let _run_target_args'_v364 = v374 
                #endif
                let v375 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v364 
                v375
        | _ ->
            let v379 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v380 : string = $"path: {v0} / error: {v35} / path': {v4} / name: {v5}"
            let v381 : string = v379 + v380 
            (* run_target_args'
            let v386 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v387 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v388 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v381 v387 
            let _run_target_args'_v386 = v388 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v389 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v390 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v381 v389 
            let _run_target_args'_v386 = v390 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v391 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v392 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v381 v391 
            let _run_target_args'_v386 = v392 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v394 : std_io_Error = v381 |> unbox<std_io_Error>
            let _run_target_args'_v386 = v394 
            #endif
#if FABLE_COMPILER_PYTHON
            let v398 : std_io_Error = v381 |> unbox<std_io_Error>
            let _run_target_args'_v386 = v398 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v402 : std_io_Error = v381 |> unbox<std_io_Error>
            let _run_target_args'_v386 = v402 
            #endif
#else
            let v406 : std_io_Error = v381 |> unbox<std_io_Error>
            let _run_target_args'_v386 = v406 
            #endif
            let v409 : std_io_Error = _run_target_args'_v386 
            (* run_target_args'
            let v416 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v417 : string = "Err($0)"
            let v418 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v409 v417 
            let _run_target_args'_v416 = v418 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v419 : string = "Err($0)"
            let v420 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v409 v419 
            let _run_target_args'_v416 = v420 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v421 : string = "Err($0)"
            let v422 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v409 v421 
            let _run_target_args'_v416 = v422 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v423 : Result<std_path_PathBuf, std_io_Error> = v409 |> Error
            let _run_target_args'_v416 = v423 
            #endif
#if FABLE_COMPILER_PYTHON
            let v424 : Result<std_path_PathBuf, std_io_Error> = v409 |> Error
            let _run_target_args'_v416 = v424 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v425 : Result<std_path_PathBuf, std_io_Error> = v409 |> Error
            let _run_target_args'_v416 = v425 
            #endif
#else
            let v426 : Result<std_path_PathBuf, std_io_Error> = v409 |> Error
            let _run_target_args'_v416 = v426 
            #endif
            let v427 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v416 
            v427
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
    let v8 : (string -> US5) = method6()
    let v9 : US5 option = v5 |> Option.map v8 
    let v29 : US5 = US5_1
    let v30 : US5 = v9 |> Option.defaultValue v29 
    let v34 : string = method42(v3)
    let v35 : bool = v2 >= 11uy
    if v35 then
        let v36 : string = $"file_system.read_link / "
        let v37 : string = $"path: {v0} / n: {v2} / path': {v0} / name: {v4}"
        let v38 : string = v36 + v37 
        (* run_target_args'
        let v43 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v44 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v45 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v38 v44 
        let _run_target_args'_v43 = v45 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v46 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v47 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v38 v46 
        let _run_target_args'_v43 = v47 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v48 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v49 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v38 v48 
        let _run_target_args'_v43 = v49 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v51 : std_io_Error = v38 |> unbox<std_io_Error>
        let _run_target_args'_v43 = v51 
        #endif
#if FABLE_COMPILER_PYTHON
        let v55 : std_io_Error = v38 |> unbox<std_io_Error>
        let _run_target_args'_v43 = v55 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v59 : std_io_Error = v38 |> unbox<std_io_Error>
        let _run_target_args'_v43 = v59 
        #endif
#else
        let v63 : std_io_Error = v38 |> unbox<std_io_Error>
        let _run_target_args'_v43 = v63 
        #endif
        let v66 : std_io_Error = _run_target_args'_v43 
        (* run_target_args'
        let v73 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v74 : string = "Err($0)"
        let v75 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v66 v74 
        let _run_target_args'_v73 = v75 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v76 : string = "Err($0)"
        let v77 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v66 v76 
        let _run_target_args'_v73 = v77 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v78 : string = "Err($0)"
        let v79 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v66 v78 
        let _run_target_args'_v73 = v79 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v80 : Result<std_path_PathBuf, std_io_Error> = v66 |> Error
        let _run_target_args'_v73 = v80 
        #endif
#if FABLE_COMPILER_PYTHON
        let v81 : Result<std_path_PathBuf, std_io_Error> = v66 |> Error
        let _run_target_args'_v73 = v81 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v82 : Result<std_path_PathBuf, std_io_Error> = v66 |> Error
        let _run_target_args'_v73 = v82 
        #endif
#else
        let v83 : Result<std_path_PathBuf, std_io_Error> = v66 |> Error
        let _run_target_args'_v73 = v83 
        #endif
        let v84 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v73 
        v84
    else
        match v30 with
        | US5_0(v87) -> (* Some *)
            let v90 : string = ""
            let v91 : bool = v0 <> v90 
            if v91 then
                let v94 : uint8 = v2 + 1uy
                let v95 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v94
                let v96 : Result<std_path_PathBuf, std_io_Error> = v95 v87
                let v97 : (std_io_Error -> string) = method41()
                (* run_target_args'
                let v99 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v100 : string = "$0.map_err(|x| $1(x))"
                let v101 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v96, v97) v100 
                let _run_target_args'_v99 = v101 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v102 : string = "$0.map_err(|x| $1(x))"
                let v103 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v96, v97) v102 
                let _run_target_args'_v99 = v103 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v104 : string = "$0.map_err(|x| $1(x))"
                let v105 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v96, v97) v104 
                let _run_target_args'_v99 = v105 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v106 : Result<std_path_PathBuf, string> = match v96 with Ok x -> Ok x | Error x -> Error (v97 x)
                let _run_target_args'_v99 = v106 
                #endif
#if FABLE_COMPILER_PYTHON
                let v107 : Result<std_path_PathBuf, string> = match v96 with Ok x -> Ok x | Error x -> Error (v97 x)
                let _run_target_args'_v99 = v107 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v108 : Result<std_path_PathBuf, string> = match v96 with Ok x -> Ok x | Error x -> Error (v97 x)
                let _run_target_args'_v99 = v108 
                #endif
#else
                let v109 : Result<std_path_PathBuf, string> = match v96 with Ok x -> Ok x | Error x -> Error (v97 x)
                let _run_target_args'_v99 = v109 
                #endif
                let v110 : Result<std_path_PathBuf, string> = _run_target_args'_v99 
                let v113 : (std_path_PathBuf -> US9) = method43()
                let v114 : (string -> US9) = method44()
                let v116 : US9 = match v110 with Ok x -> v113 x | Error x -> v114 x
                match v116 with
                | US9_1(v272) -> (* Error *)
                    let v273 : string = $"file_system.read_link / "
                    let v274 : string = $"error': {v272} / error: {v34} / name: {v4}"
                    let v275 : string = v273 + v274 
                    (* run_target_args'
                    let v280 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v281 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v282 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v275 v281 
                    let _run_target_args'_v280 = v282 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v283 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v284 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v275 v283 
                    let _run_target_args'_v280 = v284 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v285 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v286 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v275 v285 
                    let _run_target_args'_v280 = v286 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v288 : std_io_Error = v275 |> unbox<std_io_Error>
                    let _run_target_args'_v280 = v288 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v292 : std_io_Error = v275 |> unbox<std_io_Error>
                    let _run_target_args'_v280 = v292 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v296 : std_io_Error = v275 |> unbox<std_io_Error>
                    let _run_target_args'_v280 = v296 
                    #endif
#else
                    let v300 : std_io_Error = v275 |> unbox<std_io_Error>
                    let _run_target_args'_v280 = v300 
                    #endif
                    let v303 : std_io_Error = _run_target_args'_v280 
                    (* run_target_args'
                    let v310 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v311 : string = "Err($0)"
                    let v312 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v303 v311 
                    let _run_target_args'_v310 = v312 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v313 : string = "Err($0)"
                    let v314 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v303 v313 
                    let _run_target_args'_v310 = v314 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v315 : string = "Err($0)"
                    let v316 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v303 v315 
                    let _run_target_args'_v310 = v316 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v317 : Result<std_path_PathBuf, std_io_Error> = v303 |> Error
                    let _run_target_args'_v310 = v317 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v318 : Result<std_path_PathBuf, std_io_Error> = v303 |> Error
                    let _run_target_args'_v310 = v318 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v319 : Result<std_path_PathBuf, std_io_Error> = v303 |> Error
                    let _run_target_args'_v310 = v319 
                    #endif
#else
                    let v320 : Result<std_path_PathBuf, std_io_Error> = v303 |> Error
                    let _run_target_args'_v310 = v320 
                    #endif
                    let v321 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v310 
                    v321
                | US9_0(v119) -> (* Ok *)
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
                    let v154 : string = v147 |> string 
                    let v157 : string = method28(v154, v4)
                    (* run_target_args'
                    let v162 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v163 : string = "&*$0"
                    let v164 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v157 v163 
                    let _run_target_args'_v162 = v164 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v165 : string = "&*$0"
                    let v166 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v157 v165 
                    let _run_target_args'_v162 = v166 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v167 : string = "&*$0"
                    let v168 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v157 v167 
                    let _run_target_args'_v162 = v168 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v170 : Ref<Str> = v157 |> unbox<Ref<Str>>
                    let _run_target_args'_v162 = v170 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v174 : Ref<Str> = v157 |> unbox<Ref<Str>>
                    let _run_target_args'_v162 = v174 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v178 : Ref<Str> = v157 |> unbox<Ref<Str>>
                    let _run_target_args'_v162 = v178 
                    #endif
#else
                    let v182 : Ref<Str> = v157 |> unbox<Ref<Str>>
                    let _run_target_args'_v162 = v182 
                    #endif
                    let v185 : Ref<Str> = _run_target_args'_v162 
                    (* run_target_args'
                    let v195 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v196 : string = "String::from($0)"
                    let v197 : std_string_String = Fable.Core.RustInterop.emitRustExpr v185 v196 
                    let _run_target_args'_v195 = v197 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v198 : string = "String::from($0)"
                    let v199 : std_string_String = Fable.Core.RustInterop.emitRustExpr v185 v198 
                    let _run_target_args'_v195 = v199 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v200 : string = "String::from($0)"
                    let v201 : std_string_String = Fable.Core.RustInterop.emitRustExpr v185 v200 
                    let _run_target_args'_v195 = v201 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v203 : std_string_String = v185 |> unbox<std_string_String>
                    let _run_target_args'_v195 = v203 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v207 : std_string_String = v185 |> unbox<std_string_String>
                    let _run_target_args'_v195 = v207 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v211 : std_string_String = v185 |> unbox<std_string_String>
                    let _run_target_args'_v195 = v211 
                    #endif
#else
                    let v215 : std_string_String = v185 |> unbox<std_string_String>
                    let _run_target_args'_v195 = v215 
                    #endif
                    let v218 : std_string_String = _run_target_args'_v195 
                    (* run_target_args'
                    let v228 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v229 : string = "std::path::PathBuf::from($0)"
                    let v230 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v218 v229 
                    let _run_target_args'_v228 = v230 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v231 : string = "std::path::PathBuf::from($0)"
                    let v232 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v218 v231 
                    let _run_target_args'_v228 = v232 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v233 : string = "std::path::PathBuf::from($0)"
                    let v234 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v218 v233 
                    let _run_target_args'_v228 = v234 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v236 : std_path_PathBuf = v218 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v228 = v236 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v240 : std_path_PathBuf = v218 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v228 = v240 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v244 : std_path_PathBuf = v218 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v228 = v244 
                    #endif
#else
                    let v248 : std_path_PathBuf = v218 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v228 = v248 
                    #endif
                    let v251 : std_path_PathBuf = _run_target_args'_v228 
                    (* run_target_args'
                    let v258 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v259 : string = "Ok($0)"
                    let v260 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v251 v259 
                    let _run_target_args'_v258 = v260 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v261 : string = "Ok($0)"
                    let v262 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v251 v261 
                    let _run_target_args'_v258 = v262 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v263 : string = "Ok($0)"
                    let v264 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v251 v263 
                    let _run_target_args'_v258 = v264 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v265 : Result<std_path_PathBuf, std_io_Error> = v251 |> Ok
                    let _run_target_args'_v258 = v265 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v266 : Result<std_path_PathBuf, std_io_Error> = v251 |> Ok
                    let _run_target_args'_v258 = v266 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v267 : Result<std_path_PathBuf, std_io_Error> = v251 |> Ok
                    let _run_target_args'_v258 = v267 
                    #endif
#else
                    let v268 : Result<std_path_PathBuf, std_io_Error> = v251 |> Ok
                    let _run_target_args'_v258 = v268 
                    #endif
                    let v269 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v258 
                    v269
            else
                let v326 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v327 : string = $"path: {v0} / error: {v34} / path': {v0} / name: {v4}"
                let v328 : string = v326 + v327 
                (* run_target_args'
                let v333 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v334 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v335 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v328 v334 
                let _run_target_args'_v333 = v335 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v336 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v337 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v328 v336 
                let _run_target_args'_v333 = v337 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v338 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v339 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v328 v338 
                let _run_target_args'_v333 = v339 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v341 : std_io_Error = v328 |> unbox<std_io_Error>
                let _run_target_args'_v333 = v341 
                #endif
#if FABLE_COMPILER_PYTHON
                let v345 : std_io_Error = v328 |> unbox<std_io_Error>
                let _run_target_args'_v333 = v345 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v349 : std_io_Error = v328 |> unbox<std_io_Error>
                let _run_target_args'_v333 = v349 
                #endif
#else
                let v353 : std_io_Error = v328 |> unbox<std_io_Error>
                let _run_target_args'_v333 = v353 
                #endif
                let v356 : std_io_Error = _run_target_args'_v333 
                (* run_target_args'
                let v363 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v364 : string = "Err($0)"
                let v365 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v356 v364 
                let _run_target_args'_v363 = v365 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v366 : string = "Err($0)"
                let v367 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v356 v366 
                let _run_target_args'_v363 = v367 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v368 : string = "Err($0)"
                let v369 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v356 v368 
                let _run_target_args'_v363 = v369 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v370 : Result<std_path_PathBuf, std_io_Error> = v356 |> Error
                let _run_target_args'_v363 = v370 
                #endif
#if FABLE_COMPILER_PYTHON
                let v371 : Result<std_path_PathBuf, std_io_Error> = v356 |> Error
                let _run_target_args'_v363 = v371 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v372 : Result<std_path_PathBuf, std_io_Error> = v356 |> Error
                let _run_target_args'_v363 = v372 
                #endif
#else
                let v373 : Result<std_path_PathBuf, std_io_Error> = v356 |> Error
                let _run_target_args'_v363 = v373 
                #endif
                let v374 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v363 
                v374
        | _ ->
            let v378 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v379 : string = $"path: {v0} / error: {v34} / path': {v0} / name: {v4}"
            let v380 : string = v378 + v379 
            (* run_target_args'
            let v385 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v386 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v387 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v380 v386 
            let _run_target_args'_v385 = v387 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v388 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v389 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v380 v388 
            let _run_target_args'_v385 = v389 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v390 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v391 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v380 v390 
            let _run_target_args'_v385 = v391 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v393 : std_io_Error = v380 |> unbox<std_io_Error>
            let _run_target_args'_v385 = v393 
            #endif
#if FABLE_COMPILER_PYTHON
            let v397 : std_io_Error = v380 |> unbox<std_io_Error>
            let _run_target_args'_v385 = v397 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v401 : std_io_Error = v380 |> unbox<std_io_Error>
            let _run_target_args'_v385 = v401 
            #endif
#else
            let v405 : std_io_Error = v380 |> unbox<std_io_Error>
            let _run_target_args'_v385 = v405 
            #endif
            let v408 : std_io_Error = _run_target_args'_v385 
            (* run_target_args'
            let v415 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v416 : string = "Err($0)"
            let v417 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v408 v416 
            let _run_target_args'_v415 = v417 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v418 : string = "Err($0)"
            let v419 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v408 v418 
            let _run_target_args'_v415 = v419 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v420 : string = "Err($0)"
            let v421 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v408 v420 
            let _run_target_args'_v415 = v421 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v422 : Result<std_path_PathBuf, std_io_Error> = v408 |> Error
            let _run_target_args'_v415 = v422 
            #endif
#if FABLE_COMPILER_PYTHON
            let v423 : Result<std_path_PathBuf, std_io_Error> = v408 |> Error
            let _run_target_args'_v415 = v423 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v424 : Result<std_path_PathBuf, std_io_Error> = v408 |> Error
            let _run_target_args'_v415 = v424 
            #endif
#else
            let v425 : Result<std_path_PathBuf, std_io_Error> = v408 |> Error
            let _run_target_args'_v415 = v425 
            #endif
            let v426 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v415 
            v426
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
        let v21 : (std_path_PathBuf -> US10) = method57()
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
        let v91 : string = method58(v89, v90, v88)
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
    let v297 : string =
        if v107 then
            let v108 : string = method26()
            let v109 : string = method28(v108, v0)
            let v110 : string = method38(v109)
            let v118 : string = "/"
            let v119 : (string []) = v110.Split v118 
            let v122 : (string []) = [||]
            let v123 : int32 = v119.Length
            let v124 : Mut5 = {l0 = 0; l1 = 0; l2 = v122} : Mut5
            while method62(v123, v124) do
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
                                    while method63(v147, v149) do
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
                                    while method63(v161, v163) do
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
            let v197 : char = method64()
            let v199 : (char -> string) = _.ToString()
            let v200 : string = v199 v197
            let v204 : bool = v200 = "\n"
            let v206 : string =
                if v204 then
                    method65(v200)
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
and method66 () : string =
    
    
    
    
    
    let v2 : string = "Debug"
    let v3 : (unit -> string) = v2.ToLower
    let v4 : string = v3 ()
    let v7 : char = v4.[int 0]
    let v8 : string = method13(v7)
    (* run_target_args'
    let v13 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = "inline_colorization::color_bright_blue"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v14 
    (* run_target_args'
    let v20 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : string = "&*$0"
    let v22 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v21 
    let _run_target_args'_v20 = v22 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v23 : string = "&*$0"
    let v24 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v23 
    let _run_target_args'_v20 = v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : string = "&*$0"
    let v26 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v25 
    let _run_target_args'_v20 = v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v28 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v32 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v36 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v36 
    #endif
#else
    let v40 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v40 
    #endif
    let v43 : Ref<Str> = _run_target_args'_v20 
    let v49 : string = "inline_colorization::color_reset"
    let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v49 
    let v51 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v15, v43, v50) v51 
    let v53 : string = "fable_library_rust::String_::fromString($0)"
    let v54 : string = Fable.Core.RustInterop.emitRustExpr v52 v53 
    let _run_target_args'_v13 = v54 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v55 : string = "inline_colorization::color_bright_blue"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v55 
    (* run_target_args'
    let v61 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v62 : string = "&*$0"
    let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v62 
    let _run_target_args'_v61 = v63 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v64 : string = "&*$0"
    let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v64 
    let _run_target_args'_v61 = v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v66 : string = "&*$0"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v66 
    let _run_target_args'_v61 = v67 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v69 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v69 
    #endif
#if FABLE_COMPILER_PYTHON
    let v73 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v73 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v77 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v77 
    #endif
#else
    let v81 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v81 
    #endif
    let v84 : Ref<Str> = _run_target_args'_v61 
    let v90 : string = "inline_colorization::color_reset"
    let v91 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v90 
    let v92 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v93 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v56, v84, v91) v92 
    let v94 : string = "fable_library_rust::String_::fromString($0)"
    let v95 : string = Fable.Core.RustInterop.emitRustExpr v93 v94 
    let _run_target_args'_v13 = v95 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v96 : string = "inline_colorization::color_bright_blue"
    let v97 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v96 
    (* run_target_args'
    let v102 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v103 : string = "&*$0"
    let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v103 
    let _run_target_args'_v102 = v104 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v105 : string = "&*$0"
    let v106 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v105 
    let _run_target_args'_v102 = v106 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v107 : string = "&*$0"
    let v108 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v107 
    let _run_target_args'_v102 = v108 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v110 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v114 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v114 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v118 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v118 
    #endif
#else
    let v122 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v122 
    #endif
    let v125 : Ref<Str> = _run_target_args'_v102 
    let v131 : string = "inline_colorization::color_reset"
    let v132 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v131 
    let v133 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v134 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v97, v125, v132) v133 
    let v135 : string = "fable_library_rust::String_::fromString($0)"
    let v136 : string = Fable.Core.RustInterop.emitRustExpr v134 v135 
    let _run_target_args'_v13 = v136 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v137 : string = "\u001b[94m"
    let v138 : string = method15()
    let v139 : string = v137 + v8 
    let v140 : string = v139 + v138 
    let _run_target_args'_v13 = v140 
    #endif
#if FABLE_COMPILER_PYTHON
    let v141 : string = "\u001b[94m"
    let v142 : string = method15()
    let v143 : string = v141 + v8 
    let v144 : string = v143 + v142 
    let _run_target_args'_v13 = v144 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v145 : string = "\u001b[94m"
    let v146 : string = method15()
    let v147 : string = v145 + v8 
    let v148 : string = v147 + v146 
    let _run_target_args'_v13 = v148 
    #endif
#else
    let v149 : string = "\u001b[94m"
    let v150 : string = method15()
    let v151 : string = v149 + v8 
    let v152 : string = v151 + v150 
    let _run_target_args'_v13 = v152 
    #endif
    let v153 : string = _run_target_args'_v13 
    v153
and method68 (v0 : string, v1 : string, v2 : string, v3 : string) : string =
    let v4 : string = method14()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v8 : string = "{ "
    let v9 : string = $"{v8}"
    let v12 : unit = ()
    let v13 : (unit -> unit) = closure8(v5, v9)
    let v14 : unit = (fun () -> v13 (); v12) ()
    let v19 : string = "source_dir"
    let v20 : string = $"{v19}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure8(v5, v20)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v30 : string = " = "
    let v31 : string = $"{v30}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure8(v5, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v40 : string = $"{v0}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure8(v5, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v50 : string = "; "
    let v51 : string = $"{v50}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure8(v5, v51)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v61 : string = "dist_dir"
    let v62 : string = $"{v61}"
    let v65 : unit = ()
    let v66 : (unit -> unit) = closure8(v5, v62)
    let v67 : unit = (fun () -> v66 (); v65) ()
    let v71 : string = $"{v30}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure8(v5, v71)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v80 : string = $"{v1}"
    let v83 : unit = ()
    let v84 : (unit -> unit) = closure8(v5, v80)
    let v85 : unit = (fun () -> v84 (); v83) ()
    let v89 : string = $"{v50}"
    let v92 : unit = ()
    let v93 : (unit -> unit) = closure8(v5, v89)
    let v94 : unit = (fun () -> v93 (); v92) ()
    let v99 : string = "cache_dir"
    let v100 : string = $"{v99}"
    let v103 : unit = ()
    let v104 : (unit -> unit) = closure8(v5, v100)
    let v105 : unit = (fun () -> v104 (); v103) ()
    let v109 : string = $"{v30}"
    let v112 : unit = ()
    let v113 : (unit -> unit) = closure8(v5, v109)
    let v114 : unit = (fun () -> v113 (); v112) ()
    let v118 : string = $"{v2}"
    let v121 : unit = ()
    let v122 : (unit -> unit) = closure8(v5, v118)
    let v123 : unit = (fun () -> v122 (); v121) ()
    let v127 : string = $"{v50}"
    let v130 : unit = ()
    let v131 : (unit -> unit) = closure8(v5, v127)
    let v132 : unit = (fun () -> v131 (); v130) ()
    let v137 : string = "hangul_spec"
    let v138 : string = $"{v137}"
    let v141 : unit = ()
    let v142 : (unit -> unit) = closure8(v5, v138)
    let v143 : unit = (fun () -> v142 (); v141) ()
    let v147 : string = $"{v30}"
    let v150 : unit = ()
    let v151 : (unit -> unit) = closure8(v5, v147)
    let v152 : unit = (fun () -> v151 (); v150) ()
    let v156 : string = $"{v3}"
    let v159 : unit = ()
    let v160 : (unit -> unit) = closure8(v5, v156)
    let v161 : unit = (fun () -> v160 (); v159) ()
    let v166 : string = " }"
    let v167 : string = $"{v166}"
    let v170 : unit = ()
    let v171 : (unit -> unit) = closure8(v5, v167)
    let v172 : unit = (fun () -> v171 (); v170) ()
    let v175 : string = v5.l0
    v175
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
    
    
    
    
    
    let v2 : string = "Critical"
    let v3 : (unit -> string) = v2.ToLower
    let v4 : string = v3 ()
    let v7 : char = v4.[int 0]
    let v8 : string = method13(v7)
    (* run_target_args'
    let v13 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = "inline_colorization::color_bright_red"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v14 
    (* run_target_args'
    let v20 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : string = "&*$0"
    let v22 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v21 
    let _run_target_args'_v20 = v22 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v23 : string = "&*$0"
    let v24 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v23 
    let _run_target_args'_v20 = v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : string = "&*$0"
    let v26 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v25 
    let _run_target_args'_v20 = v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v28 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v32 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v36 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v36 
    #endif
#else
    let v40 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v40 
    #endif
    let v43 : Ref<Str> = _run_target_args'_v20 
    let v49 : string = "inline_colorization::color_reset"
    let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v49 
    let v51 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v15, v43, v50) v51 
    let v53 : string = "fable_library_rust::String_::fromString($0)"
    let v54 : string = Fable.Core.RustInterop.emitRustExpr v52 v53 
    let _run_target_args'_v13 = v54 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v55 : string = "inline_colorization::color_bright_red"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v55 
    (* run_target_args'
    let v61 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v62 : string = "&*$0"
    let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v62 
    let _run_target_args'_v61 = v63 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v64 : string = "&*$0"
    let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v64 
    let _run_target_args'_v61 = v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v66 : string = "&*$0"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v66 
    let _run_target_args'_v61 = v67 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v69 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v69 
    #endif
#if FABLE_COMPILER_PYTHON
    let v73 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v73 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v77 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v77 
    #endif
#else
    let v81 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v81 
    #endif
    let v84 : Ref<Str> = _run_target_args'_v61 
    let v90 : string = "inline_colorization::color_reset"
    let v91 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v90 
    let v92 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v93 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v56, v84, v91) v92 
    let v94 : string = "fable_library_rust::String_::fromString($0)"
    let v95 : string = Fable.Core.RustInterop.emitRustExpr v93 v94 
    let _run_target_args'_v13 = v95 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v96 : string = "inline_colorization::color_bright_red"
    let v97 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v96 
    (* run_target_args'
    let v102 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v103 : string = "&*$0"
    let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v103 
    let _run_target_args'_v102 = v104 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v105 : string = "&*$0"
    let v106 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v105 
    let _run_target_args'_v102 = v106 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v107 : string = "&*$0"
    let v108 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v107 
    let _run_target_args'_v102 = v108 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v110 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v114 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v114 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v118 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v118 
    #endif
#else
    let v122 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v122 
    #endif
    let v125 : Ref<Str> = _run_target_args'_v102 
    let v131 : string = "inline_colorization::color_reset"
    let v132 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v131 
    let v133 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v134 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v97, v125, v132) v133 
    let v135 : string = "fable_library_rust::String_::fromString($0)"
    let v136 : string = Fable.Core.RustInterop.emitRustExpr v134 v135 
    let _run_target_args'_v13 = v136 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v137 : string = "\u001b[91m"
    let v138 : string = method15()
    let v139 : string = v137 + v8 
    let v140 : string = v139 + v138 
    let _run_target_args'_v13 = v140 
    #endif
#if FABLE_COMPILER_PYTHON
    let v141 : string = "\u001b[91m"
    let v142 : string = method15()
    let v143 : string = v141 + v8 
    let v144 : string = v143 + v142 
    let _run_target_args'_v13 = v144 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v145 : string = "\u001b[91m"
    let v146 : string = method15()
    let v147 : string = v145 + v8 
    let v148 : string = v147 + v146 
    let _run_target_args'_v13 = v148 
    #endif
#else
    let v149 : string = "\u001b[91m"
    let v150 : string = method15()
    let v151 : string = v149 + v8 
    let v152 : string = v151 + v150 
    let _run_target_args'_v13 = v152 
    #endif
    let v153 : string = _run_target_args'_v13 
    v153
and method78 (v0 : std_string_String) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure8(v2, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v16 : string = "error"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure8(v2, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v27 : string = " = "
    let v28 : string = $"{v27}"
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure8(v2, v28)
    let v33 : unit = (fun () -> v32 (); v31) ()
    (* run_target_args'
    let v40 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v41 : string = "format!(\"{:#?}\", $0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v41 
    let v43 : string = "fable_library_rust::String_::fromString($0)"
    let v44 : string = Fable.Core.RustInterop.emitRustExpr v42 v43 
    let _run_target_args'_v40 = v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : string = "format!(\"{:#?}\", $0)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v45 
    let v47 : string = "fable_library_rust::String_::fromString($0)"
    let v48 : string = Fable.Core.RustInterop.emitRustExpr v46 v47 
    let _run_target_args'_v40 = v48 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v49 : string = "format!(\"{:#?}\", $0)"
    let v50 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v49 
    let v51 : string = "fable_library_rust::String_::fromString($0)"
    let v52 : string = Fable.Core.RustInterop.emitRustExpr v50 v51 
    let _run_target_args'_v40 = v52 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v54 : string = $"%A{v0}"
    let _run_target_args'_v40 = v54 
    #endif
#if FABLE_COMPILER_PYTHON
    let v58 : string = $"%A{v0}"
    let _run_target_args'_v40 = v58 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v62 : string = $"%A{v0}"
    let _run_target_args'_v40 = v62 
    #endif
#else
    let v66 : string = $"%A{v0}"
    let _run_target_args'_v40 = v66 
    #endif
    let v69 : string = _run_target_args'_v40 
    let v76 : string = $"{v69}"
    let v79 : unit = ()
    let v80 : (unit -> unit) = closure8(v2, v76)
    let v81 : unit = (fun () -> v80 (); v79) ()
    let v86 : string = " }"
    let v87 : string = $"{v86}"
    let v90 : unit = ()
    let v91 : (unit -> unit) = closure8(v2, v87)
    let v92 : unit = (fun () -> v91 (); v90) ()
    let v95 : string = v2.l0
    v95
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
    let v20 : US13 = match v14 with Ok x -> v17 x | Error x -> v18 x
    let v147 : US5 =
        match v20 with
        | US13_1(v95) -> (* Error *)
            let v96 : unit = ()
            let v97 : (unit -> unit) = closure33(v95)
            let v98 : unit = (fun () -> v97 (); v96) ()
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
    match v147 with
    | US5_1 -> (* None *)
        let v154 : string option = None
        v154
    | US5_0(v148) -> (* Some *)
        let v150 : string option = Some v148 
        v150
and method72 () : (Result<async_walkdir_DirEntry, async_walkdir_Error> -> string option) =
    closure29()
and method80 (v0 : unativeint) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure8(v2, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v16 : string = "files_len"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure8(v2, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v27 : string = " = "
    let v28 : string = $"{v27}"
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure8(v2, v28)
    let v33 : unit = (fun () -> v32 (); v31) ()
    (* run_target_args'
    let v40 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v41 : string = "format!(\"{:#?}\", $0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v41 
    let v43 : string = "fable_library_rust::String_::fromString($0)"
    let v44 : string = Fable.Core.RustInterop.emitRustExpr v42 v43 
    let _run_target_args'_v40 = v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : string = "format!(\"{:#?}\", $0)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v45 
    let v47 : string = "fable_library_rust::String_::fromString($0)"
    let v48 : string = Fable.Core.RustInterop.emitRustExpr v46 v47 
    let _run_target_args'_v40 = v48 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v49 : string = "format!(\"{:#?}\", $0)"
    let v50 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v49 
    let v51 : string = "fable_library_rust::String_::fromString($0)"
    let v52 : string = Fable.Core.RustInterop.emitRustExpr v50 v51 
    let _run_target_args'_v40 = v52 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v54 : string = $"%A{v0}"
    let _run_target_args'_v40 = v54 
    #endif
#if FABLE_COMPILER_PYTHON
    let v58 : string = $"%A{v0}"
    let _run_target_args'_v40 = v58 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v62 : string = $"%A{v0}"
    let _run_target_args'_v40 = v62 
    #endif
#else
    let v66 : string = $"%A{v0}"
    let _run_target_args'_v40 = v66 
    #endif
    let v69 : string = _run_target_args'_v40 
    let v76 : string = $"{v69}"
    let v79 : unit = ()
    let v80 : (unit -> unit) = closure8(v2, v76)
    let v81 : unit = (fun () -> v80 (); v79) ()
    let v86 : string = " }"
    let v87 : string = $"{v86}"
    let v90 : unit = ()
    let v91 : (unit -> unit) = closure8(v2, v87)
    let v92 : unit = (fun () -> v91 (); v90) ()
    let v95 : string = v2.l0
    v95
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
and method87 (v0 : int64, v1 : string, v2 : int64) : UH0 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : char = v1.[int v2]
        let v5 : int64 = v2 + 1L
        let v6 : UH0 = method87(v0, v1, v5)
        UH0_1(v4, v6)
    else
        UH0_0
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
and closure37 (v0 : int32, v1 : int32) (v2 : string) : string =
    let v3 : bool = v1 >= v0
    if v3 then
        v2
    else
        let v4 : int32 = v1 + 1
        let v5 : (string -> string) = method89(v0, v4)
        let v8 : string = " "
        let v9 : string = v2 + v8 
        v5 v9
and method89 (v0 : int32, v1 : int32) : (string -> string) =
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
            let v56 : UH0 = method87(v54, v51, v55)
            let struct (v57 : System.Text.StringBuilder, v58 : int32, v59 : int32) = method88(v56, v1, v2, v3)
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
            let v114 : (string -> string) = method89(v112, v113)
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
            let v56 : UH0 = method87(v54, v51, v55)
            let struct (v57 : System.Text.StringBuilder, v58 : int32, v59 : int32) = method88(v56, v1, v2, v3)
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
            let v114 : (string -> string) = method89(v112, v113)
            let v115 : string = ""
            let v116 : string = v114 v115
            let v117 : string = "^"
            let v118 : string = v116 + v117 
            let v120 : string = $"{v109}
{v118}
"
            US15_1(v120)
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
                let v71 : int64 = System.Convert.ToInt64 v68.Length
                let v72 : int64 = 0L
                let v73 : UH0 = method87(v71, v68, v72)
                let struct (v74 : System.Text.StringBuilder, v75 : int32, v76 : int32) = method88(v73, v2, v3, v4)
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
        method92(v121, v112, v113, v114, v115)
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
                let v75 : int64 = System.Convert.ToInt64 v72.Length
                let v76 : int64 = 0L
                let v77 : UH0 = method87(v75, v72, v76)
                let struct (v78 : System.Text.StringBuilder, v79 : int32, v80 : int32) = method88(v77, v2, v3, v4)
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
        method95(v129, v120, v121, v122, v123)
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
            let v61 : UH0 = method87(v59, v56, v60)
            let struct (v62 : System.Text.StringBuilder, v63 : int32, v64 : int32) = method88(v61, v2, v3, v4)
            US15_0(v16, v50, v62, v63, v64)
    match v66 with
    | US15_1(v83) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US15_0(v67, v68, v69, v70, v71) -> (* Ok *)
        let v73 : (char -> string) = _.ToString()
        let v74 : string = v73 v67
        let v77 : string = v0 + v74 
        method97(v77, v68, v69, v70, v71)
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
    let v9 : string = ""
    let v10 : string = v4 |> Option.defaultValue v9 
    let v13 : string = method86()
    let v15 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v16 : System.Text.StringBuilder = v15 v13
    let v19 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US15) = closure36()
    let v20 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US15) = closure38()
    let v21 : UH1 = UH1_0
    let v22 : UH1 = UH1_1(v20, v21)
    let v23 : UH1 = UH1_1(v19, v22)
    let v24 : US15 = method90(v10, v16, v23)
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
                    let v52 : bool = method91(v50, v51)
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
                        let v98 : UH0 = method87(v96, v93, v97)
                        let struct (v99 : System.Text.StringBuilder, v100 : int32, v101 : int32) = method88(v98, v27, v28, v29)
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
                    let struct (v146 : string, v147 : string, v148 : System.Text.StringBuilder, v149 : int32, v150 : int32) = method92(v143, v137, v138, v139, v140)
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
                let v174 : US15 = method93(v167, v168, v169, v170, v173)
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
                    let v230 : bool = method94(v228, v229)
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
                        let v276 : UH0 = method87(v274, v271, v275)
                        let v277 : int32 = 1
                        let v278 : int32 = 1
                        let struct (v279 : System.Text.StringBuilder, v280 : int32, v281 : int32) = method88(v276, v16, v277, v278)
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
                    let struct (v330 : string, v331 : string, v332 : System.Text.StringBuilder, v333 : int32, v334 : int32) = method95(v327, v321, v322, v323, v324)
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
                    let v370 : int32 = method96(v365, v369)
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
                        let v474 : UH0 = method87(v472, v469, v473)
                        let struct (v475 : System.Text.StringBuilder, v476 : int32, v477 : int32) = method88(v474, v419, v420, v421)
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
                        let v532 : (string -> string) = method89(v530, v531)
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
                            let v616 : UH0 = method87(v614, v611, v615)
                            let struct (v617 : System.Text.StringBuilder, v618 : int32, v619 : int32) = method88(v616, v557, v558, v559)
                            US15_0(v571, v605, v617, v618, v619)
                    match v621 with
                    | US15_1(v638) -> (* Error *)
                        US16_1(v638)
                    | US15_0(v622, v623, v624, v625, v626) -> (* Ok *)
                        let v628 : (char -> string) = _.ToString()
                        let v629 : string = v628 v622
                        let struct (v632 : string, v633 : string, v634 : System.Text.StringBuilder, v635 : int32, v636 : int32) = method97(v629, v623, v624, v625, v626)
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
                let v79 : int64 = System.Convert.ToInt64 v76.Length
                let v80 : int64 = 0L
                let v81 : UH0 = method87(v79, v76, v80)
                let struct (v82 : System.Text.StringBuilder, v83 : int32, v84 : int32) = method88(v81, v2, v3, v4)
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
        method101(v125, v116, v117, v118, v119)
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
                let v56 : UH0 = method87(v54, v51, v55)
                let struct (v57 : System.Text.StringBuilder, v58 : int32, v59 : int32) = method88(v56, v1, v2, v3)
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
                let v114 : (string -> string) = method89(v112, v113)
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
                let v187 : UH0 = method87(v185, v182, v186)
                let struct (v188 : System.Text.StringBuilder, v189 : int32, v190 : int32) = method88(v187, v128, v129, v130)
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
                let v56 : UH0 = method87(v54, v51, v55)
                let struct (v57 : System.Text.StringBuilder, v58 : int32, v59 : int32) = method88(v56, v1, v2, v3)
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
                let v114 : (string -> string) = method89(v112, v113)
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
                let v187 : UH0 = method87(v185, v182, v186)
                let struct (v188 : System.Text.StringBuilder, v189 : int32, v190 : int32) = method88(v187, v128, v129, v130)
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
                let v75 : int64 = System.Convert.ToInt64 v72.Length
                let v76 : int64 = 0L
                let v77 : UH0 = method87(v75, v72, v76)
                let struct (v78 : System.Text.StringBuilder, v79 : int32, v80 : int32) = method88(v77, v2, v3, v4)
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
            method104(v1, v2, v3, v4, v132)
        | US16_0(v122, v123, v124, v125, v126) -> (* Ok *)
            v121
    match v135 with
    | US16_1(v143) -> (* Error *)
        let v144 : UH2 = UH2_0
        let v145 : UH2 = method105(v0, v144)
        US23_0(v145, v1, v2, v3, v4)
    | US16_0(v136, v137, v138, v139, v140) -> (* Ok *)
        let v141 : UH2 = UH2_1(v136, v0)
        method102(v141, v137, v138, v139, v140)
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
                let v75 : int64 = System.Convert.ToInt64 v72.Length
                let v76 : int64 = 0L
                let v77 : UH0 = method87(v75, v72, v76)
                let struct (v78 : System.Text.StringBuilder, v79 : int32, v80 : int32) = method88(v77, v2, v3, v4)
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
        let v131 : UH2 = method105(v0, v130)
        US23_0(v131, v1, v2, v3, v4)
    | US16_0(v122, v123, v124, v125, v126) -> (* Ok *)
        let v127 : UH2 = UH2_1(v122, v0)
        method107(v127, v123, v124, v125, v126)
and method99 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US23 =
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
                let v79 : int64 = System.Convert.ToInt64 v76.Length
                let v80 : int64 = 0L
                let v81 : UH0 = method87(v79, v76, v80)
                let struct (v82 : System.Text.StringBuilder, v83 : int32, v84 : int32) = method88(v81, v2, v3, v4)
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
            let struct (v125 : string, v126 : string, v127 : System.Text.StringBuilder, v128 : int32, v129 : int32) = method101(v122, v116, v117, v118, v119)
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
                        let v192 : UH0 = method87(v190, v187, v191)
                        let struct (v193 : System.Text.StringBuilder, v194 : int32, v195 : int32) = method88(v192, v2, v3, v4)
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
                        let v250 : (string -> string) = method89(v248, v249)
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
                    let v268 : US23 = method102(v267, v263, v264, v265, v266)
                    let v301 : US16 =
                        match v268 with
                        | US23_1(v298) -> (* Error *)
                            US16_1(v298)
                        | US23_0(v269, v270, v271, v272, v273) -> (* Ok *)
                            let v274 : string list = []
                            let v275 : string list = method106(v269, v274)
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
                                    let v359 : UH0 = method87(v357, v354, v358)
                                    let struct (v360 : System.Text.StringBuilder, v361 : int32, v362 : int32) = method88(v359, v304, v305, v306)
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
                                    let v417 : (string -> string) = method89(v415, v416)
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
                let v463 : US16 = method104(v1, v2, v3, v4, v462)
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
                        method107(v480, v476, v477, v478, v479)
                match v485 with
                | US23_1(v515) -> (* Error *)
                    US16_1(v515)
                | US23_0(v486, v487, v488, v489, v490) -> (* Ok *)
                    let v491 : string list = []
                    let v492 : string list = method106(v486, v491)
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
        let v587 : UH2 = method105(v0, v586)
        US23_0(v587, v1, v2, v3, v4)
    | US16_0(v523, v524, v525, v526, v527) -> (* Ok *)
        let v528 : int32 = 0
        let v529 : int32 = method96(v524, v528)
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
            let v581 : UH2 = method105(v0, v580)
            US23_0(v581, v524, v525, v526, v527)
        | US18_0(v572, v573, v574, v575) -> (* Ok *)
            let v576 : UH2 = UH2_1(v523, v0)
            method99(v576, v572, v573, v574, v575)
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
    let v9 : string = ""
    let v10 : string = v4 |> Option.defaultValue v9 
    let v13 : string = method86()
    let v15 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v16 : System.Text.StringBuilder = v15 v13
    let v19 : UH2 = UH2_0
    let v20 : int32 = 1
    let v21 : int32 = 1
    let v22 : US23 = method99(v19, v10, v16, v20, v21)
    match v22 with
    | US23_1(v36) -> (* Error *)
        US22_1(v36)
    | US23_0(v23, v24, v25, v26, v27) -> (* Ok *)
        let v28 : string list = []
        let v29 : string list = method106(v23, v28)
        let v31 : (string list -> (string [])) = List.toArray
        let v32 : (string []) = v31 v29
        US22_0(v32)
and method109 (v0 : string, v1 : string, v2 : string, v3 : System.Threading.CancellationToken option, v4 : (struct (string * string) []), v5 : (struct (int32 * string * bool) -> Async<unit>) option, v6 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v7 : bool, v8 : string option) : string =
    let v9 : string = method14()
    let v10 : Mut3 = {l0 = v9} : Mut3
    let v13 : string = "{ "
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure8(v10, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v24 : string = "file_name"
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure8(v10, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v35 : string = " = "
    let v36 : string = $"{v35}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure8(v10, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v45 : string = $"{v0}"
    let v48 : unit = ()
    let v49 : (unit -> unit) = closure8(v10, v45)
    let v50 : unit = (fun () -> v49 (); v48) ()
    let v55 : string = "; "
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure8(v10, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v66 : string = "arguments"
    let v67 : string = $"{v66}"
    let v70 : unit = ()
    let v71 : (unit -> unit) = closure8(v10, v67)
    let v72 : unit = (fun () -> v71 (); v70) ()
    let v76 : string = $"{v35}"
    let v79 : unit = ()
    let v80 : (unit -> unit) = closure8(v10, v76)
    let v81 : unit = (fun () -> v80 (); v79) ()
    let v85 : string = $"{v1}"
    let v88 : unit = ()
    let v89 : (unit -> unit) = closure8(v10, v85)
    let v90 : unit = (fun () -> v89 (); v88) ()
    let v94 : string = $"{v55}"
    let v97 : unit = ()
    let v98 : (unit -> unit) = closure8(v10, v94)
    let v99 : unit = (fun () -> v98 (); v97) ()
    let v104 : string = "options"
    let v105 : string = $"{v104}"
    let v108 : unit = ()
    let v109 : (unit -> unit) = closure8(v10, v105)
    let v110 : unit = (fun () -> v109 (); v108) ()
    let v114 : string = $"{v35}"
    let v117 : unit = ()
    let v118 : (unit -> unit) = closure8(v10, v114)
    let v119 : unit = (fun () -> v118 (); v117) ()
    let v123 : string = $"{v13}"
    let v126 : unit = ()
    let v127 : (unit -> unit) = closure8(v10, v123)
    let v128 : unit = (fun () -> v127 (); v126) ()
    let v133 : string = "command"
    let v134 : string = $"{v133}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure8(v10, v134)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v143 : string = $"{v35}"
    let v146 : unit = ()
    let v147 : (unit -> unit) = closure8(v10, v143)
    let v148 : unit = (fun () -> v147 (); v146) ()
    let v152 : string = $"{v2}"
    let v155 : unit = ()
    let v156 : (unit -> unit) = closure8(v10, v152)
    let v157 : unit = (fun () -> v156 (); v155) ()
    let v161 : string = $"{v55}"
    let v164 : unit = ()
    let v165 : (unit -> unit) = closure8(v10, v161)
    let v166 : unit = (fun () -> v165 (); v164) ()
    let v171 : string = "cancellation_token"
    let v172 : string = $"{v171}"
    let v175 : unit = ()
    let v176 : (unit -> unit) = closure8(v10, v172)
    let v177 : unit = (fun () -> v176 (); v175) ()
    let v181 : string = $"{v35}"
    let v184 : unit = ()
    let v185 : (unit -> unit) = closure8(v10, v181)
    let v186 : unit = (fun () -> v185 (); v184) ()
    (* run_target_args'
    let v193 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v194 : string = "format!(\"{:#?}\", $0)"
    let v195 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v194 
    let v196 : string = "fable_library_rust::String_::fromString($0)"
    let v197 : string = Fable.Core.RustInterop.emitRustExpr v195 v196 
    let _run_target_args'_v193 = v197 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v198 : string = "format!(\"{:#?}\", $0)"
    let v199 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v198 
    let v200 : string = "fable_library_rust::String_::fromString($0)"
    let v201 : string = Fable.Core.RustInterop.emitRustExpr v199 v200 
    let _run_target_args'_v193 = v201 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v202 : string = "format!(\"{:#?}\", $0)"
    let v203 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v202 
    let v204 : string = "fable_library_rust::String_::fromString($0)"
    let v205 : string = Fable.Core.RustInterop.emitRustExpr v203 v204 
    let _run_target_args'_v193 = v205 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v207 : string = $"%A{v3}"
    let _run_target_args'_v193 = v207 
    #endif
#if FABLE_COMPILER_PYTHON
    let v211 : string = $"%A{v3}"
    let _run_target_args'_v193 = v211 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v215 : string = $"%A{v3}"
    let _run_target_args'_v193 = v215 
    #endif
#else
    let v219 : string = $"%A{v3}"
    let _run_target_args'_v193 = v219 
    #endif
    let v222 : string = _run_target_args'_v193 
    let v229 : string = $"{v222}"
    let v232 : unit = ()
    let v233 : (unit -> unit) = closure8(v10, v229)
    let v234 : unit = (fun () -> v233 (); v232) ()
    let v238 : string = $"{v55}"
    let v241 : unit = ()
    let v242 : (unit -> unit) = closure8(v10, v238)
    let v243 : unit = (fun () -> v242 (); v241) ()
    let v248 : string = "environment_variables"
    let v249 : string = $"{v248}"
    let v252 : unit = ()
    let v253 : (unit -> unit) = closure8(v10, v249)
    let v254 : unit = (fun () -> v253 (); v252) ()
    let v258 : string = $"{v35}"
    let v261 : unit = ()
    let v262 : (unit -> unit) = closure8(v10, v258)
    let v263 : unit = (fun () -> v262 (); v261) ()
    let v267 : string = $"%A{v4}"
    let v271 : string = $"{v267}"
    let v274 : unit = ()
    let v275 : (unit -> unit) = closure8(v10, v271)
    let v276 : unit = (fun () -> v275 (); v274) ()
    let v280 : string = $"{v55}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure8(v10, v280)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v290 : string = "on_line"
    let v291 : string = $"{v290}"
    let v294 : unit = ()
    let v295 : (unit -> unit) = closure8(v10, v291)
    let v296 : unit = (fun () -> v295 (); v294) ()
    let v300 : string = $"{v35}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure8(v10, v300)
    let v305 : unit = (fun () -> v304 (); v303) ()
    (* run_target_args'
    let v312 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v313 : string = "format!(\"{:#?}\", $0)"
    let v314 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v313 
    let v315 : string = "fable_library_rust::String_::fromString($0)"
    let v316 : string = Fable.Core.RustInterop.emitRustExpr v314 v315 
    let _run_target_args'_v312 = v316 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v317 : string = "format!(\"{:#?}\", $0)"
    let v318 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v317 
    let v319 : string = "fable_library_rust::String_::fromString($0)"
    let v320 : string = Fable.Core.RustInterop.emitRustExpr v318 v319 
    let _run_target_args'_v312 = v320 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v321 : string = "format!(\"{:#?}\", $0)"
    let v322 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v321 
    let v323 : string = "fable_library_rust::String_::fromString($0)"
    let v324 : string = Fable.Core.RustInterop.emitRustExpr v322 v323 
    let _run_target_args'_v312 = v324 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v326 : string = $"%A{v5}"
    let _run_target_args'_v312 = v326 
    #endif
#if FABLE_COMPILER_PYTHON
    let v330 : string = $"%A{v5}"
    let _run_target_args'_v312 = v330 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v334 : string = $"%A{v5}"
    let _run_target_args'_v312 = v334 
    #endif
#else
    let v338 : string = $"%A{v5}"
    let _run_target_args'_v312 = v338 
    #endif
    let v341 : string = _run_target_args'_v312 
    let v348 : string = $"{v341}"
    let v351 : unit = ()
    let v352 : (unit -> unit) = closure8(v10, v348)
    let v353 : unit = (fun () -> v352 (); v351) ()
    let v357 : string = $"{v55}"
    let v360 : unit = ()
    let v361 : (unit -> unit) = closure8(v10, v357)
    let v362 : unit = (fun () -> v361 (); v360) ()
    let v367 : string = "stdin"
    let v368 : string = $"{v367}"
    let v371 : unit = ()
    let v372 : (unit -> unit) = closure8(v10, v368)
    let v373 : unit = (fun () -> v372 (); v371) ()
    let v377 : string = $"{v35}"
    let v380 : unit = ()
    let v381 : (unit -> unit) = closure8(v10, v377)
    let v382 : unit = (fun () -> v381 (); v380) ()
    (* run_target_args'
    let v389 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v390 : string = "format!(\"{:#?}\", $0)"
    let v391 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v390 
    let v392 : string = "fable_library_rust::String_::fromString($0)"
    let v393 : string = Fable.Core.RustInterop.emitRustExpr v391 v392 
    let _run_target_args'_v389 = v393 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v394 : string = "format!(\"{:#?}\", $0)"
    let v395 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v394 
    let v396 : string = "fable_library_rust::String_::fromString($0)"
    let v397 : string = Fable.Core.RustInterop.emitRustExpr v395 v396 
    let _run_target_args'_v389 = v397 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v398 : string = "format!(\"{:#?}\", $0)"
    let v399 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v398 
    let v400 : string = "fable_library_rust::String_::fromString($0)"
    let v401 : string = Fable.Core.RustInterop.emitRustExpr v399 v400 
    let _run_target_args'_v389 = v401 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v403 : string = $"%A{v6}"
    let _run_target_args'_v389 = v403 
    #endif
#if FABLE_COMPILER_PYTHON
    let v407 : string = $"%A{v6}"
    let _run_target_args'_v389 = v407 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v411 : string = $"%A{v6}"
    let _run_target_args'_v389 = v411 
    #endif
#else
    let v415 : string = $"%A{v6}"
    let _run_target_args'_v389 = v415 
    #endif
    let v418 : string = _run_target_args'_v389 
    let v425 : string = $"{v418}"
    let v428 : unit = ()
    let v429 : (unit -> unit) = closure8(v10, v425)
    let v430 : unit = (fun () -> v429 (); v428) ()
    let v434 : string = $"{v55}"
    let v437 : unit = ()
    let v438 : (unit -> unit) = closure8(v10, v434)
    let v439 : unit = (fun () -> v438 (); v437) ()
    let v444 : string = "trace"
    let v445 : string = $"{v444}"
    let v448 : unit = ()
    let v449 : (unit -> unit) = closure8(v10, v445)
    let v450 : unit = (fun () -> v449 (); v448) ()
    let v454 : string = $"{v35}"
    let v457 : unit = ()
    let v458 : (unit -> unit) = closure8(v10, v454)
    let v459 : unit = (fun () -> v458 (); v457) ()
    let v464 : string =
        if v7 then
            let v462 : string = "true"
            v462
        else
            let v463 : string = "false"
            v463
    let v466 : string = $"{v464}"
    let v469 : unit = ()
    let v470 : (unit -> unit) = closure8(v10, v466)
    let v471 : unit = (fun () -> v470 (); v469) ()
    let v475 : string = $"{v55}"
    let v478 : unit = ()
    let v479 : (unit -> unit) = closure8(v10, v475)
    let v480 : unit = (fun () -> v479 (); v478) ()
    let v485 : string = "working_directory"
    let v486 : string = $"{v485}"
    let v489 : unit = ()
    let v490 : (unit -> unit) = closure8(v10, v486)
    let v491 : unit = (fun () -> v490 (); v489) ()
    let v495 : string = $"{v35}"
    let v498 : unit = ()
    let v499 : (unit -> unit) = closure8(v10, v495)
    let v500 : unit = (fun () -> v499 (); v498) ()
    (* run_target_args'
    let v507 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v508 : string = "format!(\"{:#?}\", $0)"
    let v509 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v508 
    let v510 : string = "fable_library_rust::String_::fromString($0)"
    let v511 : string = Fable.Core.RustInterop.emitRustExpr v509 v510 
    let _run_target_args'_v507 = v511 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v512 : string = "format!(\"{:#?}\", $0)"
    let v513 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v512 
    let v514 : string = "fable_library_rust::String_::fromString($0)"
    let v515 : string = Fable.Core.RustInterop.emitRustExpr v513 v514 
    let _run_target_args'_v507 = v515 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v516 : string = "format!(\"{:#?}\", $0)"
    let v517 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v516 
    let v518 : string = "fable_library_rust::String_::fromString($0)"
    let v519 : string = Fable.Core.RustInterop.emitRustExpr v517 v518 
    let _run_target_args'_v507 = v519 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v521 : string = $"%A{v8}"
    let _run_target_args'_v507 = v521 
    #endif
#if FABLE_COMPILER_PYTHON
    let v525 : string = $"%A{v8}"
    let _run_target_args'_v507 = v525 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v529 : string = $"%A{v8}"
    let _run_target_args'_v507 = v529 
    #endif
#else
    let v533 : string = $"%A{v8}"
    let _run_target_args'_v507 = v533 
    #endif
    let v536 : string = _run_target_args'_v507 
    let v543 : string = $"{v536}"
    let v546 : unit = ()
    let v547 : (unit -> unit) = closure8(v10, v543)
    let v548 : unit = (fun () -> v547 (); v546) ()
    let v553 : string = " }"
    let v554 : string = $"{v553}"
    let v557 : unit = ()
    let v558 : (unit -> unit) = closure8(v10, v554)
    let v559 : unit = (fun () -> v558 (); v557) ()
    let v563 : string = $"{v553}"
    let v566 : unit = ()
    let v567 : (unit -> unit) = closure8(v10, v563)
    let v568 : unit = (fun () -> v567 (); v566) ()
    let v571 : string = v10.l0
    v571
and method108 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option) : string =
    let v17 : string = method109(v8, v9, v10, v11, v12, v13, v14, v15, v16)
    let v18 : int64 = v0.l0
    let v20 : string = "runtime.execute_with_options"
    let v21 : string = $"{v6} {v7} #{v18} %s{v20} / {v17}"
    method18(v21)
and closure41 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : string, v8 : Vec<std_string_String>) () : unit =
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
and closure42 () (v0 : std_process_Child option) : std_process_Child option =
    v0
and method110 () : (std_process_Child option -> std_process_Child option) =
    closure42()
and closure43 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : US24 =
    US24_0(v0)
and method111 () : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US24) =
    closure43()
and closure44 () (v0 : std_string_String) : US24 =
    US24_1(v0)
and method112 () : (std_string_String -> US24) =
    closure44()
and method114 (v0 : std_string_String, v1 : string, v2 : string, v3 : string, v4 : System.Threading.CancellationToken option, v5 : (struct (string * string) []), v6 : (struct (int32 * string * bool) -> Async<unit>) option, v7 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v8 : bool, v9 : string option) : string =
    let v10 : string = method14()
    let v11 : Mut3 = {l0 = v10} : Mut3
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure8(v11, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v25 : string = "error"
    let v26 : string = $"{v25}"
    let v29 : unit = ()
    let v30 : (unit -> unit) = closure8(v11, v26)
    let v31 : unit = (fun () -> v30 (); v29) ()
    let v36 : string = " = "
    let v37 : string = $"{v36}"
    let v40 : unit = ()
    let v41 : (unit -> unit) = closure8(v11, v37)
    let v42 : unit = (fun () -> v41 (); v40) ()
    (* run_target_args'
    let v49 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v50 : string = "format!(\"{:#?}\", $0)"
    let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v50 
    let v52 : string = "fable_library_rust::String_::fromString($0)"
    let v53 : string = Fable.Core.RustInterop.emitRustExpr v51 v52 
    let _run_target_args'_v49 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "format!(\"{:#?}\", $0)"
    let v55 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v54 
    let v56 : string = "fable_library_rust::String_::fromString($0)"
    let v57 : string = Fable.Core.RustInterop.emitRustExpr v55 v56 
    let _run_target_args'_v49 = v57 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v58 : string = "format!(\"{:#?}\", $0)"
    let v59 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v58 
    let v60 : string = "fable_library_rust::String_::fromString($0)"
    let v61 : string = Fable.Core.RustInterop.emitRustExpr v59 v60 
    let _run_target_args'_v49 = v61 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v63 : string = $"%A{v0}"
    let _run_target_args'_v49 = v63 
    #endif
#if FABLE_COMPILER_PYTHON
    let v67 : string = $"%A{v0}"
    let _run_target_args'_v49 = v67 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v71 : string = $"%A{v0}"
    let _run_target_args'_v49 = v71 
    #endif
#else
    let v75 : string = $"%A{v0}"
    let _run_target_args'_v49 = v75 
    #endif
    let v78 : string = _run_target_args'_v49 
    let v85 : string = $"{v78}"
    let v88 : unit = ()
    let v89 : (unit -> unit) = closure8(v11, v85)
    let v90 : unit = (fun () -> v89 (); v88) ()
    let v95 : string = "; "
    let v96 : string = $"{v95}"
    let v99 : unit = ()
    let v100 : (unit -> unit) = closure8(v11, v96)
    let v101 : unit = (fun () -> v100 (); v99) ()
    let v106 : string = "file_name"
    let v107 : string = $"{v106}"
    let v110 : unit = ()
    let v111 : (unit -> unit) = closure8(v11, v107)
    let v112 : unit = (fun () -> v111 (); v110) ()
    let v116 : string = $"{v36}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure8(v11, v116)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v125 : string = $"{v1}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure8(v11, v125)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v134 : string = $"{v95}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure8(v11, v134)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v144 : string = "arguments"
    let v145 : string = $"{v144}"
    let v148 : unit = ()
    let v149 : (unit -> unit) = closure8(v11, v145)
    let v150 : unit = (fun () -> v149 (); v148) ()
    let v154 : string = $"{v36}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure8(v11, v154)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v163 : string = $"{v2}"
    let v166 : unit = ()
    let v167 : (unit -> unit) = closure8(v11, v163)
    let v168 : unit = (fun () -> v167 (); v166) ()
    let v172 : string = $"{v95}"
    let v175 : unit = ()
    let v176 : (unit -> unit) = closure8(v11, v172)
    let v177 : unit = (fun () -> v176 (); v175) ()
    let v182 : string = "options"
    let v183 : string = $"{v182}"
    let v186 : unit = ()
    let v187 : (unit -> unit) = closure8(v11, v183)
    let v188 : unit = (fun () -> v187 (); v186) ()
    let v192 : string = $"{v36}"
    let v195 : unit = ()
    let v196 : (unit -> unit) = closure8(v11, v192)
    let v197 : unit = (fun () -> v196 (); v195) ()
    let v201 : string = $"{v14}"
    let v204 : unit = ()
    let v205 : (unit -> unit) = closure8(v11, v201)
    let v206 : unit = (fun () -> v205 (); v204) ()
    let v211 : string = "command"
    let v212 : string = $"{v211}"
    let v215 : unit = ()
    let v216 : (unit -> unit) = closure8(v11, v212)
    let v217 : unit = (fun () -> v216 (); v215) ()
    let v221 : string = $"{v36}"
    let v224 : unit = ()
    let v225 : (unit -> unit) = closure8(v11, v221)
    let v226 : unit = (fun () -> v225 (); v224) ()
    let v230 : string = $"{v3}"
    let v233 : unit = ()
    let v234 : (unit -> unit) = closure8(v11, v230)
    let v235 : unit = (fun () -> v234 (); v233) ()
    let v239 : string = $"{v95}"
    let v242 : unit = ()
    let v243 : (unit -> unit) = closure8(v11, v239)
    let v244 : unit = (fun () -> v243 (); v242) ()
    let v249 : string = "cancellation_token"
    let v250 : string = $"{v249}"
    let v253 : unit = ()
    let v254 : (unit -> unit) = closure8(v11, v250)
    let v255 : unit = (fun () -> v254 (); v253) ()
    let v259 : string = $"{v36}"
    let v262 : unit = ()
    let v263 : (unit -> unit) = closure8(v11, v259)
    let v264 : unit = (fun () -> v263 (); v262) ()
    (* run_target_args'
    let v271 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v272 : string = "format!(\"{:#?}\", $0)"
    let v273 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v272 
    let v274 : string = "fable_library_rust::String_::fromString($0)"
    let v275 : string = Fable.Core.RustInterop.emitRustExpr v273 v274 
    let _run_target_args'_v271 = v275 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v276 : string = "format!(\"{:#?}\", $0)"
    let v277 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v276 
    let v278 : string = "fable_library_rust::String_::fromString($0)"
    let v279 : string = Fable.Core.RustInterop.emitRustExpr v277 v278 
    let _run_target_args'_v271 = v279 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v280 : string = "format!(\"{:#?}\", $0)"
    let v281 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v280 
    let v282 : string = "fable_library_rust::String_::fromString($0)"
    let v283 : string = Fable.Core.RustInterop.emitRustExpr v281 v282 
    let _run_target_args'_v271 = v283 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v285 : string = $"%A{v4}"
    let _run_target_args'_v271 = v285 
    #endif
#if FABLE_COMPILER_PYTHON
    let v289 : string = $"%A{v4}"
    let _run_target_args'_v271 = v289 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v293 : string = $"%A{v4}"
    let _run_target_args'_v271 = v293 
    #endif
#else
    let v297 : string = $"%A{v4}"
    let _run_target_args'_v271 = v297 
    #endif
    let v300 : string = _run_target_args'_v271 
    let v307 : string = $"{v300}"
    let v310 : unit = ()
    let v311 : (unit -> unit) = closure8(v11, v307)
    let v312 : unit = (fun () -> v311 (); v310) ()
    let v316 : string = $"{v95}"
    let v319 : unit = ()
    let v320 : (unit -> unit) = closure8(v11, v316)
    let v321 : unit = (fun () -> v320 (); v319) ()
    let v326 : string = "environment_variables"
    let v327 : string = $"{v326}"
    let v330 : unit = ()
    let v331 : (unit -> unit) = closure8(v11, v327)
    let v332 : unit = (fun () -> v331 (); v330) ()
    let v336 : string = $"{v36}"
    let v339 : unit = ()
    let v340 : (unit -> unit) = closure8(v11, v336)
    let v341 : unit = (fun () -> v340 (); v339) ()
    let v345 : string = $"%A{v5}"
    let v349 : string = $"{v345}"
    let v352 : unit = ()
    let v353 : (unit -> unit) = closure8(v11, v349)
    let v354 : unit = (fun () -> v353 (); v352) ()
    let v358 : string = $"{v95}"
    let v361 : unit = ()
    let v362 : (unit -> unit) = closure8(v11, v358)
    let v363 : unit = (fun () -> v362 (); v361) ()
    let v368 : string = "on_line"
    let v369 : string = $"{v368}"
    let v372 : unit = ()
    let v373 : (unit -> unit) = closure8(v11, v369)
    let v374 : unit = (fun () -> v373 (); v372) ()
    let v378 : string = $"{v36}"
    let v381 : unit = ()
    let v382 : (unit -> unit) = closure8(v11, v378)
    let v383 : unit = (fun () -> v382 (); v381) ()
    (* run_target_args'
    let v390 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v391 : string = "format!(\"{:#?}\", $0)"
    let v392 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v391 
    let v393 : string = "fable_library_rust::String_::fromString($0)"
    let v394 : string = Fable.Core.RustInterop.emitRustExpr v392 v393 
    let _run_target_args'_v390 = v394 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v395 : string = "format!(\"{:#?}\", $0)"
    let v396 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v395 
    let v397 : string = "fable_library_rust::String_::fromString($0)"
    let v398 : string = Fable.Core.RustInterop.emitRustExpr v396 v397 
    let _run_target_args'_v390 = v398 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v399 : string = "format!(\"{:#?}\", $0)"
    let v400 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v399 
    let v401 : string = "fable_library_rust::String_::fromString($0)"
    let v402 : string = Fable.Core.RustInterop.emitRustExpr v400 v401 
    let _run_target_args'_v390 = v402 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v404 : string = $"%A{v6}"
    let _run_target_args'_v390 = v404 
    #endif
#if FABLE_COMPILER_PYTHON
    let v408 : string = $"%A{v6}"
    let _run_target_args'_v390 = v408 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v412 : string = $"%A{v6}"
    let _run_target_args'_v390 = v412 
    #endif
#else
    let v416 : string = $"%A{v6}"
    let _run_target_args'_v390 = v416 
    #endif
    let v419 : string = _run_target_args'_v390 
    let v426 : string = $"{v419}"
    let v429 : unit = ()
    let v430 : (unit -> unit) = closure8(v11, v426)
    let v431 : unit = (fun () -> v430 (); v429) ()
    let v435 : string = $"{v95}"
    let v438 : unit = ()
    let v439 : (unit -> unit) = closure8(v11, v435)
    let v440 : unit = (fun () -> v439 (); v438) ()
    let v445 : string = "stdin"
    let v446 : string = $"{v445}"
    let v449 : unit = ()
    let v450 : (unit -> unit) = closure8(v11, v446)
    let v451 : unit = (fun () -> v450 (); v449) ()
    let v455 : string = $"{v36}"
    let v458 : unit = ()
    let v459 : (unit -> unit) = closure8(v11, v455)
    let v460 : unit = (fun () -> v459 (); v458) ()
    (* run_target_args'
    let v467 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v468 : string = "format!(\"{:#?}\", $0)"
    let v469 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v468 
    let v470 : string = "fable_library_rust::String_::fromString($0)"
    let v471 : string = Fable.Core.RustInterop.emitRustExpr v469 v470 
    let _run_target_args'_v467 = v471 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v472 : string = "format!(\"{:#?}\", $0)"
    let v473 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v472 
    let v474 : string = "fable_library_rust::String_::fromString($0)"
    let v475 : string = Fable.Core.RustInterop.emitRustExpr v473 v474 
    let _run_target_args'_v467 = v475 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v476 : string = "format!(\"{:#?}\", $0)"
    let v477 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v476 
    let v478 : string = "fable_library_rust::String_::fromString($0)"
    let v479 : string = Fable.Core.RustInterop.emitRustExpr v477 v478 
    let _run_target_args'_v467 = v479 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v481 : string = $"%A{v7}"
    let _run_target_args'_v467 = v481 
    #endif
#if FABLE_COMPILER_PYTHON
    let v485 : string = $"%A{v7}"
    let _run_target_args'_v467 = v485 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v489 : string = $"%A{v7}"
    let _run_target_args'_v467 = v489 
    #endif
#else
    let v493 : string = $"%A{v7}"
    let _run_target_args'_v467 = v493 
    #endif
    let v496 : string = _run_target_args'_v467 
    let v503 : string = $"{v496}"
    let v506 : unit = ()
    let v507 : (unit -> unit) = closure8(v11, v503)
    let v508 : unit = (fun () -> v507 (); v506) ()
    let v512 : string = $"{v95}"
    let v515 : unit = ()
    let v516 : (unit -> unit) = closure8(v11, v512)
    let v517 : unit = (fun () -> v516 (); v515) ()
    let v522 : string = "trace"
    let v523 : string = $"{v522}"
    let v526 : unit = ()
    let v527 : (unit -> unit) = closure8(v11, v523)
    let v528 : unit = (fun () -> v527 (); v526) ()
    let v532 : string = $"{v36}"
    let v535 : unit = ()
    let v536 : (unit -> unit) = closure8(v11, v532)
    let v537 : unit = (fun () -> v536 (); v535) ()
    let v542 : string =
        if v8 then
            let v540 : string = "true"
            v540
        else
            let v541 : string = "false"
            v541
    let v544 : string = $"{v542}"
    let v547 : unit = ()
    let v548 : (unit -> unit) = closure8(v11, v544)
    let v549 : unit = (fun () -> v548 (); v547) ()
    let v553 : string = $"{v95}"
    let v556 : unit = ()
    let v557 : (unit -> unit) = closure8(v11, v553)
    let v558 : unit = (fun () -> v557 (); v556) ()
    let v563 : string = "working_directory"
    let v564 : string = $"{v563}"
    let v567 : unit = ()
    let v568 : (unit -> unit) = closure8(v11, v564)
    let v569 : unit = (fun () -> v568 (); v567) ()
    let v573 : string = $"{v36}"
    let v576 : unit = ()
    let v577 : (unit -> unit) = closure8(v11, v573)
    let v578 : unit = (fun () -> v577 (); v576) ()
    (* run_target_args'
    let v585 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v586 : string = "format!(\"{:#?}\", $0)"
    let v587 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v586 
    let v588 : string = "fable_library_rust::String_::fromString($0)"
    let v589 : string = Fable.Core.RustInterop.emitRustExpr v587 v588 
    let _run_target_args'_v585 = v589 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v590 : string = "format!(\"{:#?}\", $0)"
    let v591 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v590 
    let v592 : string = "fable_library_rust::String_::fromString($0)"
    let v593 : string = Fable.Core.RustInterop.emitRustExpr v591 v592 
    let _run_target_args'_v585 = v593 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v594 : string = "format!(\"{:#?}\", $0)"
    let v595 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v594 
    let v596 : string = "fable_library_rust::String_::fromString($0)"
    let v597 : string = Fable.Core.RustInterop.emitRustExpr v595 v596 
    let _run_target_args'_v585 = v597 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v599 : string = $"%A{v9}"
    let _run_target_args'_v585 = v599 
    #endif
#if FABLE_COMPILER_PYTHON
    let v603 : string = $"%A{v9}"
    let _run_target_args'_v585 = v603 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v607 : string = $"%A{v9}"
    let _run_target_args'_v585 = v607 
    #endif
#else
    let v611 : string = $"%A{v9}"
    let _run_target_args'_v585 = v611 
    #endif
    let v614 : string = _run_target_args'_v585 
    let v621 : string = $"{v614}"
    let v624 : unit = ()
    let v625 : (unit -> unit) = closure8(v11, v621)
    let v626 : unit = (fun () -> v625 (); v624) ()
    let v631 : string = " }"
    let v632 : string = $"{v631}"
    let v635 : unit = ()
    let v636 : (unit -> unit) = closure8(v11, v632)
    let v637 : unit = (fun () -> v636 (); v635) ()
    let v641 : string = $"{v631}"
    let v644 : unit = ()
    let v645 : (unit -> unit) = closure8(v11, v641)
    let v646 : unit = (fun () -> v645 (); v644) ()
    let v649 : string = v11.l0
    v649
and method113 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String, v9 : string, v10 : string, v11 : string, v12 : System.Threading.CancellationToken option, v13 : (struct (string * string) []), v14 : (struct (int32 * string * bool) -> Async<unit>) option, v15 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v16 : bool, v17 : string option) : string =
    let v18 : string = method114(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17)
    let v19 : int64 = v0.l0
    let v21 : string = "runtime.execute_with_options / child error"
    let v22 : string = $"{v6} {v7} #{v19} %s{v21} / {v18}"
    method18(v22)
and closure45 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : string, v8 : Vec<std_string_String>, v9 : std_string_String) () : unit =
    let v10 : US0 = US0_4
    let v11 : bool = method7(v10)
    if v11 then
        let v12 : unit = ()
        let v13 : (unit -> unit) = closure6()
        let v14 : unit = (fun () -> v13 (); v12) ()
        let struct (v35 : Mut0, v36 : Mut1, v37 : Mut2, v38 : Mut3, v39 : Mut4, v40 : int64 option) = TraceState.trace_state.Value
        let v53 : string = method8(v35, v36, v37, v38, v39, v40)
        let v54 : string = method76()
        let v56 : string = $"%A{v8}"
        let v59 : string = method113(v35, v36, v37, v38, v39, v40, v53, v54, v9, v7, v56, v0, v1, v2, v3, v4, v5, v6)
        method19(v59)
and method115 (v0 : std_sync_MutexGuard<std_process_Child option>) : std_sync_MutexGuard<std_process_Child option> =
    v0
and closure46 () (v0 : std_process_ChildStdin option) : std_process_ChildStdin option =
    v0
and method116 () : (std_process_ChildStdin option -> std_process_ChildStdin option) =
    closure46()
and closure47 () (v0 : std_sync_mpsc_Sender<std_string_String>) : std_sync_mpsc_Sender<std_string_String> =
    v0
and method117 () : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) =
    closure47()
and method118 () : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) =
    closure47()
and closure48 () (v0 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> =
    v0
and method119 () : (std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> -> std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) =
    closure48()
and closure49 () (v0 : std_string_String) : US26 =
    US26_0(v0)
and method120 () : (std_string_String -> US26) =
    closure49()
and closure50 () (v0 : std_string_String) : US26 =
    US26_1(v0)
and method121 () : (std_string_String -> US26) =
    closure50()
and method123 (v0 : bool, v1 : std_string_String) : string =
    let v2 : string = method14()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure8(v3, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v17 : string = "trace'"
    let v18 : string = $"{v17}"
    let v21 : unit = ()
    let v22 : (unit -> unit) = closure8(v3, v18)
    let v23 : unit = (fun () -> v22 (); v21) ()
    let v28 : string = " = "
    let v29 : string = $"{v28}"
    let v32 : unit = ()
    let v33 : (unit -> unit) = closure8(v3, v29)
    let v34 : unit = (fun () -> v33 (); v32) ()
    let v39 : string =
        if v0 then
            let v37 : string = "true"
            v37
        else
            let v38 : string = "false"
            v38
    let v41 : string = $"{v39}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure8(v3, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v51 : string = "; "
    let v52 : string = $"{v51}"
    let v55 : unit = ()
    let v56 : (unit -> unit) = closure8(v3, v52)
    let v57 : unit = (fun () -> v56 (); v55) ()
    let v62 : string = "e"
    let v63 : string = $"{v62}"
    let v66 : unit = ()
    let v67 : (unit -> unit) = closure8(v3, v63)
    let v68 : unit = (fun () -> v67 (); v66) ()
    let v72 : string = $"{v28}"
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure8(v3, v72)
    let v77 : unit = (fun () -> v76 (); v75) ()
    (* run_target_args'
    let v84 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v85 : string = "format!(\"{:#?}\", $0)"
    let v86 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v85 
    let v87 : string = "fable_library_rust::String_::fromString($0)"
    let v88 : string = Fable.Core.RustInterop.emitRustExpr v86 v87 
    let _run_target_args'_v84 = v88 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v89 : string = "format!(\"{:#?}\", $0)"
    let v90 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v89 
    let v91 : string = "fable_library_rust::String_::fromString($0)"
    let v92 : string = Fable.Core.RustInterop.emitRustExpr v90 v91 
    let _run_target_args'_v84 = v92 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v93 : string = "format!(\"{:#?}\", $0)"
    let v94 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v93 
    let v95 : string = "fable_library_rust::String_::fromString($0)"
    let v96 : string = Fable.Core.RustInterop.emitRustExpr v94 v95 
    let _run_target_args'_v84 = v96 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v98 : string = $"%A{v1}"
    let _run_target_args'_v84 = v98 
    #endif
#if FABLE_COMPILER_PYTHON
    let v102 : string = $"%A{v1}"
    let _run_target_args'_v84 = v102 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v106 : string = $"%A{v1}"
    let _run_target_args'_v84 = v106 
    #endif
#else
    let v110 : string = $"%A{v1}"
    let _run_target_args'_v84 = v110 
    #endif
    let v113 : string = _run_target_args'_v84 
    let v120 : string = $"{v113}"
    let v123 : unit = ()
    let v124 : (unit -> unit) = closure8(v3, v120)
    let v125 : unit = (fun () -> v124 (); v123) ()
    let v130 : string = " }"
    let v131 : string = $"{v130}"
    let v134 : unit = ()
    let v135 : (unit -> unit) = closure8(v3, v131)
    let v136 : unit = (fun () -> v135 (); v134) ()
    let v139 : string = v3.l0
    v139
and method122 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : bool, v9 : std_string_String) : string =
    let v10 : string = method123(v8, v9)
    let v11 : int64 = v0.l0
    let v13 : string = "runtime.stdio_line"
    let v14 : string = $"{v6} {v7} #{v11} %s{v13} / {v10}"
    method18(v14)
and closure51 (v0 : bool, v1 : std_string_String) () : unit =
    let v2 : US0 = US0_4
    let v3 : bool = method7(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method8(v27, v28, v29, v30, v31, v32)
        let v46 : string = method76()
        let v47 : string = method122(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method19(v47)
and method124 () : string =
    
    
    
    
    
    let v2 : string = "Verbose"
    let v3 : (unit -> string) = v2.ToLower
    let v4 : string = v3 ()
    let v7 : char = v4.[int 0]
    let v8 : string = method13(v7)
    (* run_target_args'
    let v13 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = "inline_colorization::color_bright_black"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v14 
    (* run_target_args'
    let v20 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : string = "&*$0"
    let v22 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v21 
    let _run_target_args'_v20 = v22 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v23 : string = "&*$0"
    let v24 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v23 
    let _run_target_args'_v20 = v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : string = "&*$0"
    let v26 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v25 
    let _run_target_args'_v20 = v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v28 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v32 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v36 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v36 
    #endif
#else
    let v40 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v40 
    #endif
    let v43 : Ref<Str> = _run_target_args'_v20 
    let v49 : string = "inline_colorization::color_reset"
    let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v49 
    let v51 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v15, v43, v50) v51 
    let v53 : string = "fable_library_rust::String_::fromString($0)"
    let v54 : string = Fable.Core.RustInterop.emitRustExpr v52 v53 
    let _run_target_args'_v13 = v54 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v55 : string = "inline_colorization::color_bright_black"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v55 
    (* run_target_args'
    let v61 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v62 : string = "&*$0"
    let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v62 
    let _run_target_args'_v61 = v63 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v64 : string = "&*$0"
    let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v64 
    let _run_target_args'_v61 = v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v66 : string = "&*$0"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v66 
    let _run_target_args'_v61 = v67 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v69 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v69 
    #endif
#if FABLE_COMPILER_PYTHON
    let v73 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v73 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v77 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v77 
    #endif
#else
    let v81 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v81 
    #endif
    let v84 : Ref<Str> = _run_target_args'_v61 
    let v90 : string = "inline_colorization::color_reset"
    let v91 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v90 
    let v92 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v93 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v56, v84, v91) v92 
    let v94 : string = "fable_library_rust::String_::fromString($0)"
    let v95 : string = Fable.Core.RustInterop.emitRustExpr v93 v94 
    let _run_target_args'_v13 = v95 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v96 : string = "inline_colorization::color_bright_black"
    let v97 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v96 
    (* run_target_args'
    let v102 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v103 : string = "&*$0"
    let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v103 
    let _run_target_args'_v102 = v104 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v105 : string = "&*$0"
    let v106 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v105 
    let _run_target_args'_v102 = v106 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v107 : string = "&*$0"
    let v108 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v107 
    let _run_target_args'_v102 = v108 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v110 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v114 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v114 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v118 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v118 
    #endif
#else
    let v122 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v122 
    #endif
    let v125 : Ref<Str> = _run_target_args'_v102 
    let v131 : string = "inline_colorization::color_reset"
    let v132 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v131 
    let v133 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v134 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v97, v125, v132) v133 
    let v135 : string = "fable_library_rust::String_::fromString($0)"
    let v136 : string = Fable.Core.RustInterop.emitRustExpr v134 v135 
    let _run_target_args'_v13 = v136 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v137 : string = "\u001b[90m"
    let v138 : string = method15()
    let v139 : string = v137 + v8 
    let v140 : string = v139 + v138 
    let _run_target_args'_v13 = v140 
    #endif
#if FABLE_COMPILER_PYTHON
    let v141 : string = "\u001b[90m"
    let v142 : string = method15()
    let v143 : string = v141 + v8 
    let v144 : string = v143 + v142 
    let _run_target_args'_v13 = v144 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v145 : string = "\u001b[90m"
    let v146 : string = method15()
    let v147 : string = v145 + v8 
    let v148 : string = v147 + v146 
    let _run_target_args'_v13 = v148 
    #endif
#else
    let v149 : string = "\u001b[90m"
    let v150 : string = method15()
    let v151 : string = v149 + v8 
    let v152 : string = v151 + v150 
    let _run_target_args'_v13 = v152 
    #endif
    let v153 : string = _run_target_args'_v13 
    v153
and method126 () : string =
    let v0 : string = method14()
    let v1 : Mut3 = {l0 = v0} : Mut3
    let v2 : string = v1.l0
    v2
and method125 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method126()
    let v10 : int64 = v0.l0
    let v12 : string = $"{v6} {v7} #{v10} %s{v8} / {v9}"
    method18(v12)
and closure52 (v0 : string) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method124()
        let v46 : bool = v0 = ""
        let v49 : string =
            if v46 then
                let v47 : string = ""
                v47
            else
                method125(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method19(v49)
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
and method127 () : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) =
    closure53()
and method128 (v0 : Result<unit, string>) : Result<unit, string> =
    v0
and closure54 () (v0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)) : US27 =
    US27_0(v0)
and method129 () : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US27) =
    closure54()
and method130 (v0 : std_sync_MutexGuard<std_process_ChildStdin option>) : std_sync_MutexGuard<std_process_ChildStdin option> =
    v0
and closure55 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : US28 =
    US28_0(v0)
and method131 () : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US28) =
    closure55()
and method132 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure56 () (v0 : std_process_Output) : US29 =
    US29_0(v0)
and method133 () : (std_process_Output -> US29) =
    closure56()
and closure57 () (v0 : std_string_String) : US29 =
    US29_1(v0)
and method134 () : (std_string_String -> US29) =
    closure57()
and method135 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String, v9 : string, v10 : string, v11 : string, v12 : System.Threading.CancellationToken option, v13 : (struct (string * string) []), v14 : (struct (int32 * string * bool) -> Async<unit>) option, v15 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v16 : bool, v17 : string option) : string =
    let v18 : string = method114(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17)
    let v19 : int64 = v0.l0
    let v21 : string = "runtime.execute_with_options / output error"
    let v22 : string = $"{v6} {v7} #{v19} %s{v21} / {v18}"
    method18(v22)
and closure58 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : string, v8 : Vec<std_string_String>, v9 : std_string_String) () : unit =
    let v10 : US0 = US0_4
    let v11 : bool = method7(v10)
    if v11 then
        let v12 : unit = ()
        let v13 : (unit -> unit) = closure6()
        let v14 : unit = (fun () -> v13 (); v12) ()
        let struct (v35 : Mut0, v36 : Mut1, v37 : Mut2, v38 : Mut3, v39 : Mut4, v40 : int64 option) = TraceState.trace_state.Value
        let v53 : string = method8(v35, v36, v37, v38, v39, v40)
        let v54 : string = method76()
        let v56 : string = $"%A{v8}"
        let v59 : string = method135(v35, v36, v37, v38, v39, v40, v53, v54, v9, v7, v56, v0, v1, v2, v3, v4, v5, v6)
        method19(v59)
and closure59 () (v0 : int32) : US30 =
    US30_0(v0)
and method136 () : (int32 -> US30) =
    closure59()
and method137 () : string =
    let v0 : string = "\n"
    v0
and method139 (v0 : int32, v1 : int32) : string =
    let v2 : string = method14()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure8(v3, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v17 : string = "exit_code"
    let v18 : string = $"{v17}"
    let v21 : unit = ()
    let v22 : (unit -> unit) = closure8(v3, v18)
    let v23 : unit = (fun () -> v22 (); v21) ()
    let v28 : string = " = "
    let v29 : string = $"{v28}"
    let v32 : unit = ()
    let v33 : (unit -> unit) = closure8(v3, v29)
    let v34 : unit = (fun () -> v33 (); v32) ()
    let v38 : string = $"{v0}"
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure8(v3, v38)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v48 : string = "; "
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure8(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v59 : string = "std_trace_length"
    let v60 : string = $"{v59}"
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure8(v3, v60)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v69 : string = $"{v28}"
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure8(v3, v69)
    let v74 : unit = (fun () -> v73 (); v72) ()
    let v78 : string = $"{v1}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure8(v3, v78)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v88 : string = " }"
    let v89 : string = $"{v88}"
    let v92 : unit = ()
    let v93 : (unit -> unit) = closure8(v3, v89)
    let v94 : unit = (fun () -> v93 (); v92) ()
    let v97 : string = v3.l0
    v97
and method138 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32) : string =
    let v10 : string = method139(v8, v9)
    let v11 : int64 = v0.l0
    let v13 : string = "runtime.execute_with_options / result"
    let v14 : string = $"{v6} {v7} #{v11} %s{v13} / {v10}"
    method18(v14)
and closure60 (v0 : int32, v1 : string) () : unit =
    let v2 : US0 = US0_0
    let v3 : bool = method7(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method8(v27, v28, v29, v30, v31, v32)
        let v46 : string = method124()
        let v47 : int32 = v1.Length
        let v48 : string = method138(v27, v28, v29, v30, v31, v32, v45, v46, v0, v47)
        method19(v48)
and method143 (v0 : string, v1 : US5, v2 : string, v3 : System.Threading.CancellationToken option, v4 : (struct (string * string) []), v5 : (struct (int32 * string * bool) -> Async<unit>) option, v6 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v7 : bool, v8 : string option) : string =
    let v9 : string = method14()
    let v10 : Mut3 = {l0 = v9} : Mut3
    let v13 : string = "{ "
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure8(v10, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v24 : string = "file_name"
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure8(v10, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v35 : string = " = "
    let v36 : string = $"{v35}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure8(v10, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v45 : string = $"{v0}"
    let v48 : unit = ()
    let v49 : (unit -> unit) = closure8(v10, v45)
    let v50 : unit = (fun () -> v49 (); v48) ()
    let v55 : string = "; "
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure8(v10, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v66 : string = "arguments"
    let v67 : string = $"{v66}"
    let v70 : unit = ()
    let v71 : (unit -> unit) = closure8(v10, v67)
    let v72 : unit = (fun () -> v71 (); v70) ()
    let v76 : string = $"{v35}"
    let v79 : unit = ()
    let v80 : (unit -> unit) = closure8(v10, v76)
    let v81 : unit = (fun () -> v80 (); v79) ()
    let v85 : string = $"%A{v1}"
    let v89 : string = $"{v85}"
    let v92 : unit = ()
    let v93 : (unit -> unit) = closure8(v10, v89)
    let v94 : unit = (fun () -> v93 (); v92) ()
    let v98 : string = $"{v55}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure8(v10, v98)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v108 : string = "options"
    let v109 : string = $"{v108}"
    let v112 : unit = ()
    let v113 : (unit -> unit) = closure8(v10, v109)
    let v114 : unit = (fun () -> v113 (); v112) ()
    let v118 : string = $"{v35}"
    let v121 : unit = ()
    let v122 : (unit -> unit) = closure8(v10, v118)
    let v123 : unit = (fun () -> v122 (); v121) ()
    let v127 : string = $"{v13}"
    let v130 : unit = ()
    let v131 : (unit -> unit) = closure8(v10, v127)
    let v132 : unit = (fun () -> v131 (); v130) ()
    let v137 : string = "command"
    let v138 : string = $"{v137}"
    let v141 : unit = ()
    let v142 : (unit -> unit) = closure8(v10, v138)
    let v143 : unit = (fun () -> v142 (); v141) ()
    let v147 : string = $"{v35}"
    let v150 : unit = ()
    let v151 : (unit -> unit) = closure8(v10, v147)
    let v152 : unit = (fun () -> v151 (); v150) ()
    let v156 : string = $"{v2}"
    let v159 : unit = ()
    let v160 : (unit -> unit) = closure8(v10, v156)
    let v161 : unit = (fun () -> v160 (); v159) ()
    let v165 : string = $"{v55}"
    let v168 : unit = ()
    let v169 : (unit -> unit) = closure8(v10, v165)
    let v170 : unit = (fun () -> v169 (); v168) ()
    let v175 : string = "cancellation_token"
    let v176 : string = $"{v175}"
    let v179 : unit = ()
    let v180 : (unit -> unit) = closure8(v10, v176)
    let v181 : unit = (fun () -> v180 (); v179) ()
    let v185 : string = $"{v35}"
    let v188 : unit = ()
    let v189 : (unit -> unit) = closure8(v10, v185)
    let v190 : unit = (fun () -> v189 (); v188) ()
    (* run_target_args'
    let v197 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v198 : string = "format!(\"{:#?}\", $0)"
    let v199 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v198 
    let v200 : string = "fable_library_rust::String_::fromString($0)"
    let v201 : string = Fable.Core.RustInterop.emitRustExpr v199 v200 
    let _run_target_args'_v197 = v201 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v202 : string = "format!(\"{:#?}\", $0)"
    let v203 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v202 
    let v204 : string = "fable_library_rust::String_::fromString($0)"
    let v205 : string = Fable.Core.RustInterop.emitRustExpr v203 v204 
    let _run_target_args'_v197 = v205 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v206 : string = "format!(\"{:#?}\", $0)"
    let v207 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v206 
    let v208 : string = "fable_library_rust::String_::fromString($0)"
    let v209 : string = Fable.Core.RustInterop.emitRustExpr v207 v208 
    let _run_target_args'_v197 = v209 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v211 : string = $"%A{v3}"
    let _run_target_args'_v197 = v211 
    #endif
#if FABLE_COMPILER_PYTHON
    let v215 : string = $"%A{v3}"
    let _run_target_args'_v197 = v215 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v219 : string = $"%A{v3}"
    let _run_target_args'_v197 = v219 
    #endif
#else
    let v223 : string = $"%A{v3}"
    let _run_target_args'_v197 = v223 
    #endif
    let v226 : string = _run_target_args'_v197 
    let v233 : string = $"{v226}"
    let v236 : unit = ()
    let v237 : (unit -> unit) = closure8(v10, v233)
    let v238 : unit = (fun () -> v237 (); v236) ()
    let v242 : string = $"{v55}"
    let v245 : unit = ()
    let v246 : (unit -> unit) = closure8(v10, v242)
    let v247 : unit = (fun () -> v246 (); v245) ()
    let v252 : string = "environment_variables"
    let v253 : string = $"{v252}"
    let v256 : unit = ()
    let v257 : (unit -> unit) = closure8(v10, v253)
    let v258 : unit = (fun () -> v257 (); v256) ()
    let v262 : string = $"{v35}"
    let v265 : unit = ()
    let v266 : (unit -> unit) = closure8(v10, v262)
    let v267 : unit = (fun () -> v266 (); v265) ()
    let v271 : string = $"%A{v4}"
    let v275 : string = $"{v271}"
    let v278 : unit = ()
    let v279 : (unit -> unit) = closure8(v10, v275)
    let v280 : unit = (fun () -> v279 (); v278) ()
    let v284 : string = $"{v55}"
    let v287 : unit = ()
    let v288 : (unit -> unit) = closure8(v10, v284)
    let v289 : unit = (fun () -> v288 (); v287) ()
    let v294 : string = "on_line"
    let v295 : string = $"{v294}"
    let v298 : unit = ()
    let v299 : (unit -> unit) = closure8(v10, v295)
    let v300 : unit = (fun () -> v299 (); v298) ()
    let v304 : string = $"{v35}"
    let v307 : unit = ()
    let v308 : (unit -> unit) = closure8(v10, v304)
    let v309 : unit = (fun () -> v308 (); v307) ()
    (* run_target_args'
    let v316 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v317 : string = "format!(\"{:#?}\", $0)"
    let v318 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v317 
    let v319 : string = "fable_library_rust::String_::fromString($0)"
    let v320 : string = Fable.Core.RustInterop.emitRustExpr v318 v319 
    let _run_target_args'_v316 = v320 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v321 : string = "format!(\"{:#?}\", $0)"
    let v322 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v321 
    let v323 : string = "fable_library_rust::String_::fromString($0)"
    let v324 : string = Fable.Core.RustInterop.emitRustExpr v322 v323 
    let _run_target_args'_v316 = v324 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v325 : string = "format!(\"{:#?}\", $0)"
    let v326 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v325 
    let v327 : string = "fable_library_rust::String_::fromString($0)"
    let v328 : string = Fable.Core.RustInterop.emitRustExpr v326 v327 
    let _run_target_args'_v316 = v328 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v330 : string = $"%A{v5}"
    let _run_target_args'_v316 = v330 
    #endif
#if FABLE_COMPILER_PYTHON
    let v334 : string = $"%A{v5}"
    let _run_target_args'_v316 = v334 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v338 : string = $"%A{v5}"
    let _run_target_args'_v316 = v338 
    #endif
#else
    let v342 : string = $"%A{v5}"
    let _run_target_args'_v316 = v342 
    #endif
    let v345 : string = _run_target_args'_v316 
    let v352 : string = $"{v345}"
    let v355 : unit = ()
    let v356 : (unit -> unit) = closure8(v10, v352)
    let v357 : unit = (fun () -> v356 (); v355) ()
    let v361 : string = $"{v55}"
    let v364 : unit = ()
    let v365 : (unit -> unit) = closure8(v10, v361)
    let v366 : unit = (fun () -> v365 (); v364) ()
    let v371 : string = "stdin"
    let v372 : string = $"{v371}"
    let v375 : unit = ()
    let v376 : (unit -> unit) = closure8(v10, v372)
    let v377 : unit = (fun () -> v376 (); v375) ()
    let v381 : string = $"{v35}"
    let v384 : unit = ()
    let v385 : (unit -> unit) = closure8(v10, v381)
    let v386 : unit = (fun () -> v385 (); v384) ()
    (* run_target_args'
    let v393 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v394 : string = "format!(\"{:#?}\", $0)"
    let v395 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v394 
    let v396 : string = "fable_library_rust::String_::fromString($0)"
    let v397 : string = Fable.Core.RustInterop.emitRustExpr v395 v396 
    let _run_target_args'_v393 = v397 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v398 : string = "format!(\"{:#?}\", $0)"
    let v399 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v398 
    let v400 : string = "fable_library_rust::String_::fromString($0)"
    let v401 : string = Fable.Core.RustInterop.emitRustExpr v399 v400 
    let _run_target_args'_v393 = v401 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v402 : string = "format!(\"{:#?}\", $0)"
    let v403 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v402 
    let v404 : string = "fable_library_rust::String_::fromString($0)"
    let v405 : string = Fable.Core.RustInterop.emitRustExpr v403 v404 
    let _run_target_args'_v393 = v405 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v407 : string = $"%A{v6}"
    let _run_target_args'_v393 = v407 
    #endif
#if FABLE_COMPILER_PYTHON
    let v411 : string = $"%A{v6}"
    let _run_target_args'_v393 = v411 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v415 : string = $"%A{v6}"
    let _run_target_args'_v393 = v415 
    #endif
#else
    let v419 : string = $"%A{v6}"
    let _run_target_args'_v393 = v419 
    #endif
    let v422 : string = _run_target_args'_v393 
    let v429 : string = $"{v422}"
    let v432 : unit = ()
    let v433 : (unit -> unit) = closure8(v10, v429)
    let v434 : unit = (fun () -> v433 (); v432) ()
    let v438 : string = $"{v55}"
    let v441 : unit = ()
    let v442 : (unit -> unit) = closure8(v10, v438)
    let v443 : unit = (fun () -> v442 (); v441) ()
    let v448 : string = "trace"
    let v449 : string = $"{v448}"
    let v452 : unit = ()
    let v453 : (unit -> unit) = closure8(v10, v449)
    let v454 : unit = (fun () -> v453 (); v452) ()
    let v458 : string = $"{v35}"
    let v461 : unit = ()
    let v462 : (unit -> unit) = closure8(v10, v458)
    let v463 : unit = (fun () -> v462 (); v461) ()
    let v468 : string =
        if v7 then
            let v466 : string = "true"
            v466
        else
            let v467 : string = "false"
            v467
    let v470 : string = $"{v468}"
    let v473 : unit = ()
    let v474 : (unit -> unit) = closure8(v10, v470)
    let v475 : unit = (fun () -> v474 (); v473) ()
    let v479 : string = $"{v55}"
    let v482 : unit = ()
    let v483 : (unit -> unit) = closure8(v10, v479)
    let v484 : unit = (fun () -> v483 (); v482) ()
    let v489 : string = "working_directory"
    let v490 : string = $"{v489}"
    let v493 : unit = ()
    let v494 : (unit -> unit) = closure8(v10, v490)
    let v495 : unit = (fun () -> v494 (); v493) ()
    let v499 : string = $"{v35}"
    let v502 : unit = ()
    let v503 : (unit -> unit) = closure8(v10, v499)
    let v504 : unit = (fun () -> v503 (); v502) ()
    (* run_target_args'
    let v511 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v512 : string = "format!(\"{:#?}\", $0)"
    let v513 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v512 
    let v514 : string = "fable_library_rust::String_::fromString($0)"
    let v515 : string = Fable.Core.RustInterop.emitRustExpr v513 v514 
    let _run_target_args'_v511 = v515 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v516 : string = "format!(\"{:#?}\", $0)"
    let v517 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v516 
    let v518 : string = "fable_library_rust::String_::fromString($0)"
    let v519 : string = Fable.Core.RustInterop.emitRustExpr v517 v518 
    let _run_target_args'_v511 = v519 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v520 : string = "format!(\"{:#?}\", $0)"
    let v521 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v520 
    let v522 : string = "fable_library_rust::String_::fromString($0)"
    let v523 : string = Fable.Core.RustInterop.emitRustExpr v521 v522 
    let _run_target_args'_v511 = v523 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v525 : string = $"%A{v8}"
    let _run_target_args'_v511 = v525 
    #endif
#if FABLE_COMPILER_PYTHON
    let v529 : string = $"%A{v8}"
    let _run_target_args'_v511 = v529 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v533 : string = $"%A{v8}"
    let _run_target_args'_v511 = v533 
    #endif
#else
    let v537 : string = $"%A{v8}"
    let _run_target_args'_v511 = v537 
    #endif
    let v540 : string = _run_target_args'_v511 
    let v547 : string = $"{v540}"
    let v550 : unit = ()
    let v551 : (unit -> unit) = closure8(v10, v547)
    let v552 : unit = (fun () -> v551 (); v550) ()
    let v557 : string = " }"
    let v558 : string = $"{v557}"
    let v561 : unit = ()
    let v562 : (unit -> unit) = closure8(v10, v558)
    let v563 : unit = (fun () -> v562 (); v561) ()
    let v567 : string = $"{v557}"
    let v570 : unit = ()
    let v571 : (unit -> unit) = closure8(v10, v567)
    let v572 : unit = (fun () -> v571 (); v570) ()
    let v575 : string = v10.l0
    v575
and method142 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : US5, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option) : string =
    let v17 : string = method143(v8, v9, v10, v11, v12, v13, v14, v15, v16)
    let v18 : int64 = v0.l0
    let v20 : string = "runtime.execute_with_options_async"
    let v21 : string = $"{v6} {v7} #{v18} %s{v20} / {v17}"
    method18(v21)
and closure61 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : US5, v8 : string) () : unit =
    let v9 : US0 = US0_1
    let v10 : bool = method7(v9)
    if v10 then
        let v11 : unit = ()
        let v12 : (unit -> unit) = closure6()
        let v13 : unit = (fun () -> v12 (); v11) ()
        let struct (v34 : Mut0, v35 : Mut1, v36 : Mut2, v37 : Mut3, v38 : Mut4, v39 : int64 option) = TraceState.trace_state.Value
        let v52 : string = method8(v34, v35, v36, v37, v38, v39)
        let v53 : string = method66()
        let v54 : string = method142(v34, v35, v36, v37, v38, v39, v52, v53, v8, v7, v0, v1, v2, v3, v4, v5, v6)
        method19(v54)
and method144 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : (struct (string * string) []) =
    v2
and method147 (v0 : System.Diagnostics.DataReceivedEventArgs) : string =
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
and method148 () : ((struct (int32 * string * bool) -> Async<unit>) -> US31) =
    closure63()
and method149 (v0 : System.Diagnostics.Process) : int32 =
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
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method124()
        let v46 : bool = v0 = ""
        let v49 : string =
            if v46 then
                let v47 : string = ""
                v47
            else
                method125(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method19(v49)
and method146 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>, v9 : bool, v10 : System.Diagnostics.DataReceivedEventArgs) : Async<unit> =
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
            let v32 : string = method147(v10)
            let v34 : string = null |> unbox<string>
            let v37 : bool = v32 = v34
            let v38 : bool = v37 <> true
            if v38 then
                let v41 : ((struct (int32 * string * bool) -> Async<unit>) -> US31) = method148()
                let v42 : US31 option = v3 |> Option.map v41 
                let v62 : US31 = US31_1
                let v63 : US31 = v42 |> Option.defaultValue v62 
                match v63 with
                | US31_1 -> (* None *)
                    ()
                | US31_0(v67) -> (* Some *)
                    let v68 : int32 = method149(v7)
                    let v69 : Async<unit> = v67 struct (v68, v32, v9)
                    do! v69 
                    ()
                let v72 : string =
                    if v9 then
                        let v70 : string = $"! {v32}"
                        v70
                    else
                        let v71 : string = $"> {v32}"
                        v71
                if v5 then
                    let v73 : unit = ()
                    let v74 : (unit -> unit) = closure64(v72)
                    let v75 : unit = (fun () -> v74 (); v73) ()
                    ()
                else
                    let v125 : unit = ()
                    let v126 : (unit -> unit) = closure11(v72)
                    let v127 : unit = (fun () -> v126 (); v125) ()
                    ()
                let v131 : string =
                    if v9 then
                        let v129 : string = "\u001b[7;4m"
                        v129
                    else
                        let v130 : string = ""
                        v130
                let v134 : string =
                    if v9 then
                        let v132 : string = "\u001b[0m"
                        v132
                    else
                        let v133 : string = ""
                        v133
                let v135 : string = $"{v131}{v32}{v134}"
                (* run_target_args'
                let v136 : unit = ()
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
                let v137 : (string -> unit) = v8.Push
                v137 v135
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
    let v880 : Async<unit> = _let'_v29 
    let _run_target_args'_v15 = v880 
    #endif
#if FABLE_COMPILER_PYTHON
    let v882 : unit = ()
    let _let'_v882 =
        async {
            let v885 : string = method147(v10)
            let v887 : string = null |> unbox<string>
            let v890 : bool = v885 = v887
            let v891 : bool = v890 <> true
            if v891 then
                let v894 : ((struct (int32 * string * bool) -> Async<unit>) -> US31) = method148()
                let v895 : US31 option = v3 |> Option.map v894 
                let v915 : US31 = US31_1
                let v916 : US31 = v895 |> Option.defaultValue v915 
                match v916 with
                | US31_1 -> (* None *)
                    ()
                | US31_0(v920) -> (* Some *)
                    let v921 : int32 = method149(v7)
                    let v922 : Async<unit> = v920 struct (v921, v885, v9)
                    do! v922 
                    ()
                let v925 : string =
                    if v9 then
                        let v923 : string = $"! {v885}"
                        v923
                    else
                        let v924 : string = $"> {v885}"
                        v924
                if v5 then
                    let v926 : unit = ()
                    let v927 : (unit -> unit) = closure64(v925)
                    let v928 : unit = (fun () -> v927 (); v926) ()
                    ()
                else
                    let v978 : unit = ()
                    let v979 : (unit -> unit) = closure11(v925)
                    let v980 : unit = (fun () -> v979 (); v978) ()
                    ()
                let v984 : string =
                    if v9 then
                        let v982 : string = "\u001b[7;4m"
                        v982
                    else
                        let v983 : string = ""
                        v983
                let v987 : string =
                    if v9 then
                        let v985 : string = "\u001b[0m"
                        v985
                    else
                        let v986 : string = ""
                        v986
                let v988 : string = $"{v984}{v885}{v987}"
                (* run_target_args'
                let v989 : unit = ()
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
                let v990 : (string -> unit) = v8.Push
                v990 v988
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
    let v1733 : Async<unit> = _let'_v882 
    let _run_target_args'_v15 = v1733 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1735 : unit = ()
    let _let'_v1735 =
        async {
            let v1738 : string = method147(v10)
            let v1740 : string = null |> unbox<string>
            let v1743 : bool = v1738 = v1740
            let v1744 : bool = v1743 <> true
            if v1744 then
                let v1747 : ((struct (int32 * string * bool) -> Async<unit>) -> US31) = method148()
                let v1748 : US31 option = v3 |> Option.map v1747 
                let v1768 : US31 = US31_1
                let v1769 : US31 = v1748 |> Option.defaultValue v1768 
                match v1769 with
                | US31_1 -> (* None *)
                    ()
                | US31_0(v1773) -> (* Some *)
                    let v1774 : int32 = method149(v7)
                    let v1775 : Async<unit> = v1773 struct (v1774, v1738, v9)
                    do! v1775 
                    ()
                let v1778 : string =
                    if v9 then
                        let v1776 : string = $"! {v1738}"
                        v1776
                    else
                        let v1777 : string = $"> {v1738}"
                        v1777
                if v5 then
                    let v1779 : unit = ()
                    let v1780 : (unit -> unit) = closure64(v1778)
                    let v1781 : unit = (fun () -> v1780 (); v1779) ()
                    ()
                else
                    let v1831 : unit = ()
                    let v1832 : (unit -> unit) = closure11(v1778)
                    let v1833 : unit = (fun () -> v1832 (); v1831) ()
                    ()
                let v1837 : string =
                    if v9 then
                        let v1835 : string = "\u001b[7;4m"
                        v1835
                    else
                        let v1836 : string = ""
                        v1836
                let v1840 : string =
                    if v9 then
                        let v1838 : string = "\u001b[0m"
                        v1838
                    else
                        let v1839 : string = ""
                        v1839
                let v1841 : string = $"{v1837}{v1738}{v1840}"
                (* run_target_args'
                let v1842 : unit = ()
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
                let v1843 : (string -> unit) = v8.Push
                v1843 v1841
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
    let v2586 : Async<unit> = _let'_v1735 
    let _run_target_args'_v15 = v2586 
    #endif
#else
    let v2588 : unit = ()
    let _let'_v2588 =
        async {
            let v2591 : string = method147(v10)
            let v2593 : string = null |> unbox<string>
            let v2596 : bool = v2591 = v2593
            let v2597 : bool = v2596 <> true
            if v2597 then
                let v2600 : ((struct (int32 * string * bool) -> Async<unit>) -> US31) = method148()
                let v2601 : US31 option = v3 |> Option.map v2600 
                let v2621 : US31 = US31_1
                let v2622 : US31 = v2601 |> Option.defaultValue v2621 
                match v2622 with
                | US31_1 -> (* None *)
                    ()
                | US31_0(v2626) -> (* Some *)
                    let v2627 : int32 = method149(v7)
                    let v2628 : Async<unit> = v2626 struct (v2627, v2591, v9)
                    do! v2628 
                    ()
                let v2631 : string =
                    if v9 then
                        let v2629 : string = $"! {v2591}"
                        v2629
                    else
                        let v2630 : string = $"> {v2591}"
                        v2630
                if v5 then
                    let v2632 : unit = ()
                    let v2633 : (unit -> unit) = closure64(v2631)
                    let v2634 : unit = (fun () -> v2633 (); v2632) ()
                    ()
                else
                    let v2684 : unit = ()
                    let v2685 : (unit -> unit) = closure11(v2631)
                    let v2686 : unit = (fun () -> v2685 (); v2684) ()
                    ()
                let v2690 : string =
                    if v9 then
                        let v2688 : string = "\u001b[7;4m"
                        v2688
                    else
                        let v2689 : string = ""
                        v2689
                let v2693 : string =
                    if v9 then
                        let v2691 : string = "\u001b[0m"
                        v2691
                    else
                        let v2692 : string = ""
                        v2692
                let v2694 : string = $"{v2690}{v2591}{v2693}"
                (* run_target_args'
                let v2695 : unit = ()
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
                let v2696 : (string -> unit) = v8.Push
                v2696 v2694
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
    let v3439 : Async<unit> = _let'_v2588 
    let _run_target_args'_v15 = v3439 
    #endif
    let v3440 : Async<unit> = _run_target_args'_v15 
    v3440
and method145 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>, v9 : bool, v10 : System.Diagnostics.DataReceivedEventArgs) : Async<unit> =
    method146(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
and closure62 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>, v9 : bool) (v10 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v11 : Async<unit> = method145(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
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
and method150 () : (System.Threading.CancellationToken -> US32) =
    closure65()
and method151 (v0 : System.Threading.CancellationToken) : Async<System.Threading.CancellationToken> =
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
and method152 (v0 : System.Diagnostics.Process) : bool =
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
and method153 (v0 : System.Diagnostics.Process) : unit =
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
    let v1 : bool = method152(v0)
    let v2 : bool = v1 = false
    if v2 then
        method153(v0)
and method156 (v0 : System.Threading.Tasks.TaskCanceledException) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure8(v2, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v16 : string = "ex"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure8(v2, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v27 : string = " = "
    let v28 : string = $"{v27}"
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure8(v2, v28)
    let v33 : unit = (fun () -> v32 (); v31) ()
    (* run_target_args'
    let v40 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v41 : string = "format!(\"{:#?}\", $0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v41 
    let v43 : string = "fable_library_rust::String_::fromString($0)"
    let v44 : string = Fable.Core.RustInterop.emitRustExpr v42 v43 
    let _run_target_args'_v40 = v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : string = "format!(\"{:#?}\", $0)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v45 
    let v47 : string = "fable_library_rust::String_::fromString($0)"
    let v48 : string = Fable.Core.RustInterop.emitRustExpr v46 v47 
    let _run_target_args'_v40 = v48 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v49 : string = "format!(\"{:#?}\", $0)"
    let v50 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v49 
    let v51 : string = "fable_library_rust::String_::fromString($0)"
    let v52 : string = Fable.Core.RustInterop.emitRustExpr v50 v51 
    let _run_target_args'_v40 = v52 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v54 : string = $"%A{v0}"
    let _run_target_args'_v40 = v54 
    #endif
#if FABLE_COMPILER_PYTHON
    let v58 : string = $"%A{v0}"
    let _run_target_args'_v40 = v58 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v62 : string = $"%A{v0}"
    let _run_target_args'_v40 = v62 
    #endif
#else
    let v66 : string = $"%A{v0}"
    let _run_target_args'_v40 = v66 
    #endif
    let v69 : string = _run_target_args'_v40 
    let v76 : string = $"{v69}"
    let v79 : unit = ()
    let v80 : (unit -> unit) = closure8(v2, v76)
    let v81 : unit = (fun () -> v80 (); v79) ()
    let v86 : string = " }"
    let v87 : string = $"{v86}"
    let v90 : unit = ()
    let v91 : (unit -> unit) = closure8(v2, v87)
    let v92 : unit = (fun () -> v91 (); v90) ()
    let v95 : string = v2.l0
    v95
and method155 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : System.Threading.Tasks.TaskCanceledException) : string =
    let v9 : string = method156(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "runtime.execute_with_options_async / WaitForExitAsync"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method18(v13)
and closure67 (v0 : System.Threading.Tasks.TaskCanceledException) () : unit =
    let v1 : US0 = US0_3
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method35()
        let v46 : string = method155(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method19(v46)
and method154 (v0 : System.Diagnostics.Process, v1 : System.Collections.Concurrent.ConcurrentStack<string>, v2 : System.Threading.CancellationToken) : Async<int32> =
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
                let v274 : (unit -> unit) = closure67(v270)
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
                let v3399 : (unit -> unit) = closure67(v3395)
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
                let v6524 : (unit -> unit) = closure67(v6520)
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
                let v9649 : (unit -> unit) = closure67(v9645)
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
and method158 (v0 : int32, v1 : int32, v2 : string, v3 : System.Threading.CancellationToken option, v4 : (struct (string * string) []), v5 : (struct (int32 * string * bool) -> Async<unit>) option, v6 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v7 : bool, v8 : string option) : string =
    let v9 : string = method14()
    let v10 : Mut3 = {l0 = v9} : Mut3
    let v13 : string = "{ "
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure8(v10, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v24 : string = "exit_code"
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure8(v10, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v35 : string = " = "
    let v36 : string = $"{v35}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure8(v10, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v45 : string = $"{v0}"
    let v48 : unit = ()
    let v49 : (unit -> unit) = closure8(v10, v45)
    let v50 : unit = (fun () -> v49 (); v48) ()
    let v55 : string = "; "
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure8(v10, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v66 : string = "output_length"
    let v67 : string = $"{v66}"
    let v70 : unit = ()
    let v71 : (unit -> unit) = closure8(v10, v67)
    let v72 : unit = (fun () -> v71 (); v70) ()
    let v76 : string = $"{v35}"
    let v79 : unit = ()
    let v80 : (unit -> unit) = closure8(v10, v76)
    let v81 : unit = (fun () -> v80 (); v79) ()
    let v85 : string = $"{v1}"
    let v88 : unit = ()
    let v89 : (unit -> unit) = closure8(v10, v85)
    let v90 : unit = (fun () -> v89 (); v88) ()
    let v94 : string = $"{v55}"
    let v97 : unit = ()
    let v98 : (unit -> unit) = closure8(v10, v94)
    let v99 : unit = (fun () -> v98 (); v97) ()
    let v104 : string = "options"
    let v105 : string = $"{v104}"
    let v108 : unit = ()
    let v109 : (unit -> unit) = closure8(v10, v105)
    let v110 : unit = (fun () -> v109 (); v108) ()
    let v114 : string = $"{v35}"
    let v117 : unit = ()
    let v118 : (unit -> unit) = closure8(v10, v114)
    let v119 : unit = (fun () -> v118 (); v117) ()
    let v123 : string = $"{v13}"
    let v126 : unit = ()
    let v127 : (unit -> unit) = closure8(v10, v123)
    let v128 : unit = (fun () -> v127 (); v126) ()
    let v133 : string = "command"
    let v134 : string = $"{v133}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure8(v10, v134)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v143 : string = $"{v35}"
    let v146 : unit = ()
    let v147 : (unit -> unit) = closure8(v10, v143)
    let v148 : unit = (fun () -> v147 (); v146) ()
    let v152 : string = $"{v2}"
    let v155 : unit = ()
    let v156 : (unit -> unit) = closure8(v10, v152)
    let v157 : unit = (fun () -> v156 (); v155) ()
    let v161 : string = $"{v55}"
    let v164 : unit = ()
    let v165 : (unit -> unit) = closure8(v10, v161)
    let v166 : unit = (fun () -> v165 (); v164) ()
    let v171 : string = "cancellation_token"
    let v172 : string = $"{v171}"
    let v175 : unit = ()
    let v176 : (unit -> unit) = closure8(v10, v172)
    let v177 : unit = (fun () -> v176 (); v175) ()
    let v181 : string = $"{v35}"
    let v184 : unit = ()
    let v185 : (unit -> unit) = closure8(v10, v181)
    let v186 : unit = (fun () -> v185 (); v184) ()
    (* run_target_args'
    let v193 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v194 : string = "format!(\"{:#?}\", $0)"
    let v195 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v194 
    let v196 : string = "fable_library_rust::String_::fromString($0)"
    let v197 : string = Fable.Core.RustInterop.emitRustExpr v195 v196 
    let _run_target_args'_v193 = v197 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v198 : string = "format!(\"{:#?}\", $0)"
    let v199 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v198 
    let v200 : string = "fable_library_rust::String_::fromString($0)"
    let v201 : string = Fable.Core.RustInterop.emitRustExpr v199 v200 
    let _run_target_args'_v193 = v201 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v202 : string = "format!(\"{:#?}\", $0)"
    let v203 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v202 
    let v204 : string = "fable_library_rust::String_::fromString($0)"
    let v205 : string = Fable.Core.RustInterop.emitRustExpr v203 v204 
    let _run_target_args'_v193 = v205 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v207 : string = $"%A{v3}"
    let _run_target_args'_v193 = v207 
    #endif
#if FABLE_COMPILER_PYTHON
    let v211 : string = $"%A{v3}"
    let _run_target_args'_v193 = v211 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v215 : string = $"%A{v3}"
    let _run_target_args'_v193 = v215 
    #endif
#else
    let v219 : string = $"%A{v3}"
    let _run_target_args'_v193 = v219 
    #endif
    let v222 : string = _run_target_args'_v193 
    let v229 : string = $"{v222}"
    let v232 : unit = ()
    let v233 : (unit -> unit) = closure8(v10, v229)
    let v234 : unit = (fun () -> v233 (); v232) ()
    let v238 : string = $"{v55}"
    let v241 : unit = ()
    let v242 : (unit -> unit) = closure8(v10, v238)
    let v243 : unit = (fun () -> v242 (); v241) ()
    let v248 : string = "environment_variables"
    let v249 : string = $"{v248}"
    let v252 : unit = ()
    let v253 : (unit -> unit) = closure8(v10, v249)
    let v254 : unit = (fun () -> v253 (); v252) ()
    let v258 : string = $"{v35}"
    let v261 : unit = ()
    let v262 : (unit -> unit) = closure8(v10, v258)
    let v263 : unit = (fun () -> v262 (); v261) ()
    let v267 : string = $"%A{v4}"
    let v271 : string = $"{v267}"
    let v274 : unit = ()
    let v275 : (unit -> unit) = closure8(v10, v271)
    let v276 : unit = (fun () -> v275 (); v274) ()
    let v280 : string = $"{v55}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure8(v10, v280)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v290 : string = "on_line"
    let v291 : string = $"{v290}"
    let v294 : unit = ()
    let v295 : (unit -> unit) = closure8(v10, v291)
    let v296 : unit = (fun () -> v295 (); v294) ()
    let v300 : string = $"{v35}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure8(v10, v300)
    let v305 : unit = (fun () -> v304 (); v303) ()
    (* run_target_args'
    let v312 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v313 : string = "format!(\"{:#?}\", $0)"
    let v314 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v313 
    let v315 : string = "fable_library_rust::String_::fromString($0)"
    let v316 : string = Fable.Core.RustInterop.emitRustExpr v314 v315 
    let _run_target_args'_v312 = v316 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v317 : string = "format!(\"{:#?}\", $0)"
    let v318 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v317 
    let v319 : string = "fable_library_rust::String_::fromString($0)"
    let v320 : string = Fable.Core.RustInterop.emitRustExpr v318 v319 
    let _run_target_args'_v312 = v320 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v321 : string = "format!(\"{:#?}\", $0)"
    let v322 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v321 
    let v323 : string = "fable_library_rust::String_::fromString($0)"
    let v324 : string = Fable.Core.RustInterop.emitRustExpr v322 v323 
    let _run_target_args'_v312 = v324 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v326 : string = $"%A{v5}"
    let _run_target_args'_v312 = v326 
    #endif
#if FABLE_COMPILER_PYTHON
    let v330 : string = $"%A{v5}"
    let _run_target_args'_v312 = v330 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v334 : string = $"%A{v5}"
    let _run_target_args'_v312 = v334 
    #endif
#else
    let v338 : string = $"%A{v5}"
    let _run_target_args'_v312 = v338 
    #endif
    let v341 : string = _run_target_args'_v312 
    let v348 : string = $"{v341}"
    let v351 : unit = ()
    let v352 : (unit -> unit) = closure8(v10, v348)
    let v353 : unit = (fun () -> v352 (); v351) ()
    let v357 : string = $"{v55}"
    let v360 : unit = ()
    let v361 : (unit -> unit) = closure8(v10, v357)
    let v362 : unit = (fun () -> v361 (); v360) ()
    let v367 : string = "stdin"
    let v368 : string = $"{v367}"
    let v371 : unit = ()
    let v372 : (unit -> unit) = closure8(v10, v368)
    let v373 : unit = (fun () -> v372 (); v371) ()
    let v377 : string = $"{v35}"
    let v380 : unit = ()
    let v381 : (unit -> unit) = closure8(v10, v377)
    let v382 : unit = (fun () -> v381 (); v380) ()
    (* run_target_args'
    let v389 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v390 : string = "format!(\"{:#?}\", $0)"
    let v391 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v390 
    let v392 : string = "fable_library_rust::String_::fromString($0)"
    let v393 : string = Fable.Core.RustInterop.emitRustExpr v391 v392 
    let _run_target_args'_v389 = v393 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v394 : string = "format!(\"{:#?}\", $0)"
    let v395 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v394 
    let v396 : string = "fable_library_rust::String_::fromString($0)"
    let v397 : string = Fable.Core.RustInterop.emitRustExpr v395 v396 
    let _run_target_args'_v389 = v397 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v398 : string = "format!(\"{:#?}\", $0)"
    let v399 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v398 
    let v400 : string = "fable_library_rust::String_::fromString($0)"
    let v401 : string = Fable.Core.RustInterop.emitRustExpr v399 v400 
    let _run_target_args'_v389 = v401 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v403 : string = $"%A{v6}"
    let _run_target_args'_v389 = v403 
    #endif
#if FABLE_COMPILER_PYTHON
    let v407 : string = $"%A{v6}"
    let _run_target_args'_v389 = v407 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v411 : string = $"%A{v6}"
    let _run_target_args'_v389 = v411 
    #endif
#else
    let v415 : string = $"%A{v6}"
    let _run_target_args'_v389 = v415 
    #endif
    let v418 : string = _run_target_args'_v389 
    let v425 : string = $"{v418}"
    let v428 : unit = ()
    let v429 : (unit -> unit) = closure8(v10, v425)
    let v430 : unit = (fun () -> v429 (); v428) ()
    let v434 : string = $"{v55}"
    let v437 : unit = ()
    let v438 : (unit -> unit) = closure8(v10, v434)
    let v439 : unit = (fun () -> v438 (); v437) ()
    let v444 : string = "trace"
    let v445 : string = $"{v444}"
    let v448 : unit = ()
    let v449 : (unit -> unit) = closure8(v10, v445)
    let v450 : unit = (fun () -> v449 (); v448) ()
    let v454 : string = $"{v35}"
    let v457 : unit = ()
    let v458 : (unit -> unit) = closure8(v10, v454)
    let v459 : unit = (fun () -> v458 (); v457) ()
    let v464 : string =
        if v7 then
            let v462 : string = "true"
            v462
        else
            let v463 : string = "false"
            v463
    let v466 : string = $"{v464}"
    let v469 : unit = ()
    let v470 : (unit -> unit) = closure8(v10, v466)
    let v471 : unit = (fun () -> v470 (); v469) ()
    let v475 : string = $"{v55}"
    let v478 : unit = ()
    let v479 : (unit -> unit) = closure8(v10, v475)
    let v480 : unit = (fun () -> v479 (); v478) ()
    let v485 : string = "working_directory"
    let v486 : string = $"{v485}"
    let v489 : unit = ()
    let v490 : (unit -> unit) = closure8(v10, v486)
    let v491 : unit = (fun () -> v490 (); v489) ()
    let v495 : string = $"{v35}"
    let v498 : unit = ()
    let v499 : (unit -> unit) = closure8(v10, v495)
    let v500 : unit = (fun () -> v499 (); v498) ()
    (* run_target_args'
    let v507 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v508 : string = "format!(\"{:#?}\", $0)"
    let v509 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v508 
    let v510 : string = "fable_library_rust::String_::fromString($0)"
    let v511 : string = Fable.Core.RustInterop.emitRustExpr v509 v510 
    let _run_target_args'_v507 = v511 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v512 : string = "format!(\"{:#?}\", $0)"
    let v513 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v512 
    let v514 : string = "fable_library_rust::String_::fromString($0)"
    let v515 : string = Fable.Core.RustInterop.emitRustExpr v513 v514 
    let _run_target_args'_v507 = v515 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v516 : string = "format!(\"{:#?}\", $0)"
    let v517 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v516 
    let v518 : string = "fable_library_rust::String_::fromString($0)"
    let v519 : string = Fable.Core.RustInterop.emitRustExpr v517 v518 
    let _run_target_args'_v507 = v519 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v521 : string = $"%A{v8}"
    let _run_target_args'_v507 = v521 
    #endif
#if FABLE_COMPILER_PYTHON
    let v525 : string = $"%A{v8}"
    let _run_target_args'_v507 = v525 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v529 : string = $"%A{v8}"
    let _run_target_args'_v507 = v529 
    #endif
#else
    let v533 : string = $"%A{v8}"
    let _run_target_args'_v507 = v533 
    #endif
    let v536 : string = _run_target_args'_v507 
    let v543 : string = $"{v536}"
    let v546 : unit = ()
    let v547 : (unit -> unit) = closure8(v10, v543)
    let v548 : unit = (fun () -> v547 (); v546) ()
    let v553 : string = " }"
    let v554 : string = $"{v553}"
    let v557 : unit = ()
    let v558 : (unit -> unit) = closure8(v10, v554)
    let v559 : unit = (fun () -> v558 (); v557) ()
    let v563 : string = $"{v553}"
    let v566 : unit = ()
    let v567 : (unit -> unit) = closure8(v10, v563)
    let v568 : unit = (fun () -> v567 (); v566) ()
    let v571 : string = v10.l0
    v571
and method157 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option) : string =
    let v17 : string = method158(v8, v9, v10, v11, v12, v13, v14, v15, v16)
    let v18 : int64 = v0.l0
    let v20 : string = "runtime.execute_with_options_async"
    let v21 : string = $"{v6} {v7} #{v18} %s{v20} / {v17}"
    method18(v21)
and closure68 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : int32, v8 : string) () : unit =
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
        let v55 : string = method157(v34, v35, v36, v37, v38, v39, v52, v53, v7, v54, v0, v1, v2, v3, v4, v5, v6)
        method19(v55)
and method141 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
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
            let v101 : (string -> US5) = method6()
            let v102 : US5 option = v6 |> Option.map v101 
            let v122 : US5 = US5_1
            let v123 : US5 = v102 |> Option.defaultValue v122 
            let v130 : string =
                match v123 with
                | US5_1 -> (* None *)
                    let v128 : string = ""
                    v128
                | US5_0(v127) -> (* Some *)
                    v127
            let v131 : unit = ()
            let v132 : (unit -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v98, v97)
            let v133 : unit = (fun () -> v132 (); v131) ()
            let v180 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v184 : string =
                match v98 with
                | US5_1 -> (* None *)
                    let v182 : string = ""
                    v182
                | US5_0(v181) -> (* Some *)
                    v181
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v184,
              StandardOutputEncoding = v180,
              WorkingDirectory = v130,
              FileName = v97,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v185 : System.Diagnostics.ProcessStartInfo = start_info
            let v186 : (struct (string * string) []) = method144(v0, v1, v2, v3, v4, v5, v6)
            let v187 : int32 = v186.Length
            let v188 : Mut6 = {l0 = 0} : Mut6
            while method63(v187, v188) do
                let v190 : int32 = v188.l0
                let struct (v191 : string, v192 : string) = v186.[int v190]
                v185.EnvironmentVariables.[v191] <- v192 
                let v193 : int32 = v190 + 1
                v188.l0 <- v193
                ()
            let v194 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v185)
            use v194 = v194 
            let v195 : System.Diagnostics.Process = v194 
            let v196 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v197 : System.Collections.Concurrent.ConcurrentStack<string> = v196 ()
            let v198 : bool = false
            let v199 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v195, v197, v198)
            v195.OutputDataReceived.Add v199 
            let v200 : bool = true
            let v201 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v195, v197, v200)
            v195.ErrorDataReceived.Add v201 
            let v202 : (unit -> bool) = v195.Start
            let v203 : bool = v202 ()
            let v204 : bool = v203 = false
            if v204 then
                let v205 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v205
            let v206 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v206 v195
            let v207 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v207 v195
            let v210 : (System.Threading.CancellationToken -> US32) = method150()
            let v211 : US32 option = v1 |> Option.map v210 
            let v231 : US32 = US32_1
            let v232 : US32 = v211 |> Option.defaultValue v231 
            let v239 : System.Threading.CancellationToken =
                match v232 with
                | US32_1 -> (* None *)
                    let v237 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v237
                | US32_0(v236) -> (* Some *)
                    v236
            let v240 : Async<System.Threading.CancellationToken> = method151(v239)
            let! v240 = v240 
            let v241 : System.Threading.CancellationToken = v240 
            let v242 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v241.Register
            let v243 : (unit -> unit) = closure66(v195)
            let v244 : System.Threading.CancellationTokenRegistration = v242 v243
            use v244 = v244 
            let v245 : System.Threading.CancellationTokenRegistration = v244 
            let v246 : Async<int32> = method154(v195, v197, v241)
            let! v246 = v246 
            let v247 : int32 = v246 
            let v249 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v250 : string seq = v249 v197
            let v254 : (string seq -> string seq) = Seq.rev
            let v255 : string seq = v254 v250
            let v260 : string = method137()
            let v261 : (string -> (string seq -> string)) = String.concat
            let v262 : (string seq -> string) = v261 v260
            let v263 : string = v262 v255
            let v267 : unit = ()
            let v268 : (unit -> unit) = closure68(v0, v1, v2, v3, v4, v5, v6, v247, v263)
            let v269 : unit = (fun () -> v268 (); v267) ()
            return struct (v247, v263) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2404 : Async<struct (int32 * string)> = _let'_v25 
    let _run_target_args'_v11 = v2404 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2406 : unit = ()
    let _let'_v2406 =
        async {
            (* run_target_args'
            let v2417 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v2420 : int32, v2421 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2420, v2421) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v2428 : int32, v2429 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2428, v2429) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v2436 : int32, v2437 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2436, v2437) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v2444 : int32, v2445 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2444, v2445) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v2452 : int32, v2453 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2452, v2453) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v2460 : int32, v2461 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2460, v2461) 
            #endif
#else
            let v2466 : US14 = method85(v0)
            let struct (v2478 : string, v2479 : US5) =
                match v2466 with
                | US14_1(v2469) -> (* Error *)
                    let v2471 : string = $"resultm.get / Result value was Error: {v2469}"
                    failwith<struct (string * US5)> v2471
                | US14_0(v2467, v2468) -> (* Ok *)
                    struct (v2467, v2468)
            let v2482 : (string -> US5) = method6()
            let v2483 : US5 option = v6 |> Option.map v2482 
            let v2503 : US5 = US5_1
            let v2504 : US5 = v2483 |> Option.defaultValue v2503 
            let v2511 : string =
                match v2504 with
                | US5_1 -> (* None *)
                    let v2509 : string = ""
                    v2509
                | US5_0(v2508) -> (* Some *)
                    v2508
            let v2512 : unit = ()
            let v2513 : (unit -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v2479, v2478)
            let v2514 : unit = (fun () -> v2513 (); v2512) ()
            let v2561 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v2565 : string =
                match v2479 with
                | US5_1 -> (* None *)
                    let v2563 : string = ""
                    v2563
                | US5_0(v2562) -> (* Some *)
                    v2562
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v2565,
              StandardOutputEncoding = v2561,
              WorkingDirectory = v2511,
              FileName = v2478,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v2566 : System.Diagnostics.ProcessStartInfo = start_info
            let v2567 : (struct (string * string) []) = method144(v0, v1, v2, v3, v4, v5, v6)
            let v2568 : int32 = v2567.Length
            let v2569 : Mut6 = {l0 = 0} : Mut6
            while method63(v2568, v2569) do
                let v2571 : int32 = v2569.l0
                let struct (v2572 : string, v2573 : string) = v2567.[int v2571]
                v2566.EnvironmentVariables.[v2572] <- v2573 
                let v2574 : int32 = v2571 + 1
                v2569.l0 <- v2574
                ()
            let v2575 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v2566)
            use v2575 = v2575 
            let v2576 : System.Diagnostics.Process = v2575 
            let v2577 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v2578 : System.Collections.Concurrent.ConcurrentStack<string> = v2577 ()
            let v2579 : bool = false
            let v2580 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v2576, v2578, v2579)
            v2576.OutputDataReceived.Add v2580 
            let v2581 : bool = true
            let v2582 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v2576, v2578, v2581)
            v2576.ErrorDataReceived.Add v2582 
            let v2583 : (unit -> bool) = v2576.Start
            let v2584 : bool = v2583 ()
            let v2585 : bool = v2584 = false
            if v2585 then
                let v2586 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v2586
            let v2587 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v2587 v2576
            let v2588 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v2588 v2576
            let v2591 : (System.Threading.CancellationToken -> US32) = method150()
            let v2592 : US32 option = v1 |> Option.map v2591 
            let v2612 : US32 = US32_1
            let v2613 : US32 = v2592 |> Option.defaultValue v2612 
            let v2620 : System.Threading.CancellationToken =
                match v2613 with
                | US32_1 -> (* None *)
                    let v2618 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v2618
                | US32_0(v2617) -> (* Some *)
                    v2617
            let v2621 : Async<System.Threading.CancellationToken> = method151(v2620)
            let! v2621 = v2621 
            let v2622 : System.Threading.CancellationToken = v2621 
            let v2623 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v2622.Register
            let v2624 : (unit -> unit) = closure66(v2576)
            let v2625 : System.Threading.CancellationTokenRegistration = v2623 v2624
            use v2625 = v2625 
            let v2626 : System.Threading.CancellationTokenRegistration = v2625 
            let v2627 : Async<int32> = method154(v2576, v2578, v2622)
            let! v2627 = v2627 
            let v2628 : int32 = v2627 
            let v2630 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v2631 : string seq = v2630 v2578
            let v2635 : (string seq -> string seq) = Seq.rev
            let v2636 : string seq = v2635 v2631
            let v2641 : string = method137()
            let v2642 : (string -> (string seq -> string)) = String.concat
            let v2643 : (string seq -> string) = v2642 v2641
            let v2644 : string = v2643 v2636
            let v2648 : unit = ()
            let v2649 : (unit -> unit) = closure68(v0, v1, v2, v3, v4, v5, v6, v2628, v2644)
            let v2650 : unit = (fun () -> v2649 (); v2648) ()
            return struct (v2628, v2644) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v4785 : Async<struct (int32 * string)> = _let'_v2406 
    let _run_target_args'_v11 = v4785 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v4787 : unit = ()
    let _let'_v4787 =
        async {
            (* run_target_args'
            let v4798 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v4801 : int32, v4802 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4801, v4802) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v4809 : int32, v4810 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4809, v4810) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v4817 : int32, v4818 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4817, v4818) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v4825 : int32, v4826 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4825, v4826) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v4833 : int32, v4834 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4833, v4834) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v4841 : int32, v4842 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4841, v4842) 
            #endif
#else
            let v4847 : US14 = method85(v0)
            let struct (v4859 : string, v4860 : US5) =
                match v4847 with
                | US14_1(v4850) -> (* Error *)
                    let v4852 : string = $"resultm.get / Result value was Error: {v4850}"
                    failwith<struct (string * US5)> v4852
                | US14_0(v4848, v4849) -> (* Ok *)
                    struct (v4848, v4849)
            let v4863 : (string -> US5) = method6()
            let v4864 : US5 option = v6 |> Option.map v4863 
            let v4884 : US5 = US5_1
            let v4885 : US5 = v4864 |> Option.defaultValue v4884 
            let v4892 : string =
                match v4885 with
                | US5_1 -> (* None *)
                    let v4890 : string = ""
                    v4890
                | US5_0(v4889) -> (* Some *)
                    v4889
            let v4893 : unit = ()
            let v4894 : (unit -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v4860, v4859)
            let v4895 : unit = (fun () -> v4894 (); v4893) ()
            let v4942 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v4946 : string =
                match v4860 with
                | US5_1 -> (* None *)
                    let v4944 : string = ""
                    v4944
                | US5_0(v4943) -> (* Some *)
                    v4943
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v4946,
              StandardOutputEncoding = v4942,
              WorkingDirectory = v4892,
              FileName = v4859,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v4947 : System.Diagnostics.ProcessStartInfo = start_info
            let v4948 : (struct (string * string) []) = method144(v0, v1, v2, v3, v4, v5, v6)
            let v4949 : int32 = v4948.Length
            let v4950 : Mut6 = {l0 = 0} : Mut6
            while method63(v4949, v4950) do
                let v4952 : int32 = v4950.l0
                let struct (v4953 : string, v4954 : string) = v4948.[int v4952]
                v4947.EnvironmentVariables.[v4953] <- v4954 
                let v4955 : int32 = v4952 + 1
                v4950.l0 <- v4955
                ()
            let v4956 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v4947)
            use v4956 = v4956 
            let v4957 : System.Diagnostics.Process = v4956 
            let v4958 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v4959 : System.Collections.Concurrent.ConcurrentStack<string> = v4958 ()
            let v4960 : bool = false
            let v4961 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v4957, v4959, v4960)
            v4957.OutputDataReceived.Add v4961 
            let v4962 : bool = true
            let v4963 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v4957, v4959, v4962)
            v4957.ErrorDataReceived.Add v4963 
            let v4964 : (unit -> bool) = v4957.Start
            let v4965 : bool = v4964 ()
            let v4966 : bool = v4965 = false
            if v4966 then
                let v4967 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v4967
            let v4968 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v4968 v4957
            let v4969 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v4969 v4957
            let v4972 : (System.Threading.CancellationToken -> US32) = method150()
            let v4973 : US32 option = v1 |> Option.map v4972 
            let v4993 : US32 = US32_1
            let v4994 : US32 = v4973 |> Option.defaultValue v4993 
            let v5001 : System.Threading.CancellationToken =
                match v4994 with
                | US32_1 -> (* None *)
                    let v4999 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v4999
                | US32_0(v4998) -> (* Some *)
                    v4998
            let v5002 : Async<System.Threading.CancellationToken> = method151(v5001)
            let! v5002 = v5002 
            let v5003 : System.Threading.CancellationToken = v5002 
            let v5004 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v5003.Register
            let v5005 : (unit -> unit) = closure66(v4957)
            let v5006 : System.Threading.CancellationTokenRegistration = v5004 v5005
            use v5006 = v5006 
            let v5007 : System.Threading.CancellationTokenRegistration = v5006 
            let v5008 : Async<int32> = method154(v4957, v4959, v5003)
            let! v5008 = v5008 
            let v5009 : int32 = v5008 
            let v5011 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v5012 : string seq = v5011 v4959
            let v5016 : (string seq -> string seq) = Seq.rev
            let v5017 : string seq = v5016 v5012
            let v5022 : string = method137()
            let v5023 : (string -> (string seq -> string)) = String.concat
            let v5024 : (string seq -> string) = v5023 v5022
            let v5025 : string = v5024 v5017
            let v5029 : unit = ()
            let v5030 : (unit -> unit) = closure68(v0, v1, v2, v3, v4, v5, v6, v5009, v5025)
            let v5031 : unit = (fun () -> v5030 (); v5029) ()
            return struct (v5009, v5025) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v7166 : Async<struct (int32 * string)> = _let'_v4787 
    let _run_target_args'_v11 = v7166 
    #endif
#else
    let v7168 : unit = ()
    let _let'_v7168 =
        async {
            (* run_target_args'
            let v7179 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v7182 : int32, v7183 : string) = null |> unbox<struct (int32 * string)>
            return struct (v7182, v7183) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v7190 : int32, v7191 : string) = null |> unbox<struct (int32 * string)>
            return struct (v7190, v7191) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v7198 : int32, v7199 : string) = null |> unbox<struct (int32 * string)>
            return struct (v7198, v7199) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v7206 : int32, v7207 : string) = null |> unbox<struct (int32 * string)>
            return struct (v7206, v7207) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v7214 : int32, v7215 : string) = null |> unbox<struct (int32 * string)>
            return struct (v7214, v7215) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v7222 : int32, v7223 : string) = null |> unbox<struct (int32 * string)>
            return struct (v7222, v7223) 
            #endif
#else
            let v7228 : US14 = method85(v0)
            let struct (v7240 : string, v7241 : US5) =
                match v7228 with
                | US14_1(v7231) -> (* Error *)
                    let v7233 : string = $"resultm.get / Result value was Error: {v7231}"
                    failwith<struct (string * US5)> v7233
                | US14_0(v7229, v7230) -> (* Ok *)
                    struct (v7229, v7230)
            let v7244 : (string -> US5) = method6()
            let v7245 : US5 option = v6 |> Option.map v7244 
            let v7265 : US5 = US5_1
            let v7266 : US5 = v7245 |> Option.defaultValue v7265 
            let v7273 : string =
                match v7266 with
                | US5_1 -> (* None *)
                    let v7271 : string = ""
                    v7271
                | US5_0(v7270) -> (* Some *)
                    v7270
            let v7274 : unit = ()
            let v7275 : (unit -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v7241, v7240)
            let v7276 : unit = (fun () -> v7275 (); v7274) ()
            let v7323 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v7327 : string =
                match v7241 with
                | US5_1 -> (* None *)
                    let v7325 : string = ""
                    v7325
                | US5_0(v7324) -> (* Some *)
                    v7324
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v7327,
              StandardOutputEncoding = v7323,
              WorkingDirectory = v7273,
              FileName = v7240,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v7328 : System.Diagnostics.ProcessStartInfo = start_info
            let v7329 : (struct (string * string) []) = method144(v0, v1, v2, v3, v4, v5, v6)
            let v7330 : int32 = v7329.Length
            let v7331 : Mut6 = {l0 = 0} : Mut6
            while method63(v7330, v7331) do
                let v7333 : int32 = v7331.l0
                let struct (v7334 : string, v7335 : string) = v7329.[int v7333]
                v7328.EnvironmentVariables.[v7334] <- v7335 
                let v7336 : int32 = v7333 + 1
                v7331.l0 <- v7336
                ()
            let v7337 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v7328)
            use v7337 = v7337 
            let v7338 : System.Diagnostics.Process = v7337 
            let v7339 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v7340 : System.Collections.Concurrent.ConcurrentStack<string> = v7339 ()
            let v7341 : bool = false
            let v7342 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v7338, v7340, v7341)
            v7338.OutputDataReceived.Add v7342 
            let v7343 : bool = true
            let v7344 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v7338, v7340, v7343)
            v7338.ErrorDataReceived.Add v7344 
            let v7345 : (unit -> bool) = v7338.Start
            let v7346 : bool = v7345 ()
            let v7347 : bool = v7346 = false
            if v7347 then
                let v7348 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v7348
            let v7349 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v7349 v7338
            let v7350 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v7350 v7338
            let v7353 : (System.Threading.CancellationToken -> US32) = method150()
            let v7354 : US32 option = v1 |> Option.map v7353 
            let v7374 : US32 = US32_1
            let v7375 : US32 = v7354 |> Option.defaultValue v7374 
            let v7382 : System.Threading.CancellationToken =
                match v7375 with
                | US32_1 -> (* None *)
                    let v7380 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v7380
                | US32_0(v7379) -> (* Some *)
                    v7379
            let v7383 : Async<System.Threading.CancellationToken> = method151(v7382)
            let! v7383 = v7383 
            let v7384 : System.Threading.CancellationToken = v7383 
            let v7385 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v7384.Register
            let v7386 : (unit -> unit) = closure66(v7338)
            let v7387 : System.Threading.CancellationTokenRegistration = v7385 v7386
            use v7387 = v7387 
            let v7388 : System.Threading.CancellationTokenRegistration = v7387 
            let v7389 : Async<int32> = method154(v7338, v7340, v7384)
            let! v7389 = v7389 
            let v7390 : int32 = v7389 
            let v7392 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v7393 : string seq = v7392 v7340
            let v7397 : (string seq -> string seq) = Seq.rev
            let v7398 : string seq = v7397 v7393
            let v7403 : string = method137()
            let v7404 : (string -> (string seq -> string)) = String.concat
            let v7405 : (string seq -> string) = v7404 v7403
            let v7406 : string = v7405 v7398
            let v7410 : unit = ()
            let v7411 : (unit -> unit) = closure68(v0, v1, v2, v3, v4, v5, v6, v7390, v7406)
            let v7412 : unit = (fun () -> v7411 (); v7410) ()
            return struct (v7390, v7406) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v9547 : Async<struct (int32 * string)> = _let'_v7168 
    let _run_target_args'_v11 = v9547 
    #endif
    let v9548 : Async<struct (int32 * string)> = _run_target_args'_v11 
    v9548
and method140 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    method141(v0, v1, v2, v3, v4, v5, v6)
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
    let v122 : (unit -> unit) = closure41(v0, v1, v2, v3, v4, v5, v6, v29, v120)
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
    let v210 : (string -> US5) = method6()
    let v211 : US5 option = v6 |> Option.map v210 
    let v231 : US5 = US5_1
    let v232 : US5 = v211 |> Option.defaultValue v231 
    let v246 : std_process_Command =
        match v232 with
        | US5_1 -> (* None *)
            let v243 : string = $"v207"
            let v244 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v243 
            v244
        | US5_0(v236) -> (* Some *)
            let v237 : string = "true; let mut v207 = v207"
            let v238 : bool = Fable.Core.RustInterop.emitRustExpr () v237 
            let v239 : string = "true; std::process::Command::current_dir(&mut v207, &*$0)"
            let v240 : bool = Fable.Core.RustInterop.emitRustExpr v236 v239 
            let v241 : string = $"v207"
            let v242 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v241 
            v242
    let v247 : uint64 = System.Convert.ToUInt64 v2.Length
    let v248 : bool = v247 = 0UL
    let v268 : std_process_Command =
        if v248 then
            v246
        else
            let v249 : string = "$0.to_vec()"
            let v250 : Vec<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr v2 v249 
            let v251 : string = "true; let _vec_fold_ = $0.into_iter().fold(v246, |acc, x| { //"
            let v252 : bool = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "acc"
            let v254 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v253 
            let v255 : string = "x"
            let struct (v256 : string, v257 : string) = Fable.Core.RustInterop.emitRustExpr () v255 
            let v258 : string = "true; let mut v254 = v254"
            let v259 : bool = Fable.Core.RustInterop.emitRustExpr () v258 
            let v260 : string = "true; std::process::Command::env(&mut v254, &*$0, &*$1)"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr struct (v256, v257) v260 
            let v262 : string = "$0"
            let v263 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v254 v262 
            let v264 : string = "true; $0 })"
            let v265 : bool = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v266 : string = "_vec_fold_"
            let v267 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v266 
            v267
    let v269 : string = "true; let mut v268 = v268"
    let v270 : bool = Fable.Core.RustInterop.emitRustExpr () v269 
    let v271 : string = "std::process::Command::spawn(&mut v268)"
    let v272 : Result<std_process_Child, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v271 
    let v273 : (std_io_Error -> std_string_String) = method69()
    (* run_target_args'
    let v275 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v276 : string = "$0.map_err(|x| $1(x))"
    let v277 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v272, v273) v276 
    let _run_target_args'_v275 = v277 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v278 : string = "$0.map_err(|x| $1(x))"
    let v279 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v272, v273) v278 
    let _run_target_args'_v275 = v279 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v280 : string = "$0.map_err(|x| $1(x))"
    let v281 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v272, v273) v280 
    let _run_target_args'_v275 = v281 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v282 : Result<std_process_Child, std_string_String> = match v272 with Ok x -> Ok x | Error x -> Error (v273 x)
    let _run_target_args'_v275 = v282 
    #endif
#if FABLE_COMPILER_PYTHON
    let v283 : Result<std_process_Child, std_string_String> = match v272 with Ok x -> Ok x | Error x -> Error (v273 x)
    let _run_target_args'_v275 = v283 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v284 : Result<std_process_Child, std_string_String> = match v272 with Ok x -> Ok x | Error x -> Error (v273 x)
    let _run_target_args'_v275 = v284 
    #endif
#else
    let v285 : Result<std_process_Child, std_string_String> = match v272 with Ok x -> Ok x | Error x -> Error (v273 x)
    let _run_target_args'_v275 = v285 
    #endif
    let v286 : Result<std_process_Child, std_string_String> = _run_target_args'_v275 
    let v289 : (std_process_Child option -> std_process_Child option) = method110()
    let v290 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v291 : bool = Fable.Core.RustInterop.emitRustExpr v286 v290 
    let v292 : string = "x"
    let v293 : std_process_Child = Fable.Core.RustInterop.emitRustExpr () v292 
    let v295 : std_process_Child option = Some v293 
    let v298 : std_process_Child option = v289 v295
    let v299 : string = "std::sync::Mutex::new(v298)"
    let v300 : std_sync_Mutex<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr () v299 
    let v301 : string = "std::sync::Arc::new(v300)"
    let v302 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr () v301 
    let v303 : string = "true; $0 })"
    let v304 : bool = Fable.Core.RustInterop.emitRustExpr v302 v303 
    let v305 : string = "_result_map_"
    let v306 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v305 
    let v307 : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US24) = method111()
    let v308 : (std_string_String -> US24) = method112()
    let v309 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
    let v310 : US24 = Fable.Core.RustInterop.emitRustExpr struct (v307, v308, v306) v309 
    let struct (v1639 : int32, v1640 : US6, v1641 : US25) =
        match v310 with
        | US24_1(v1580) -> (* Error *)
            let v1581 : unit = ()
            let v1582 : (unit -> unit) = closure45(v0, v1, v2, v3, v4, v5, v6, v29, v120, v1580)
            let v1583 : unit = (fun () -> v1582 (); v1581) ()
            let v1634 : US6 = US6_0(v1580)
            let v1635 : US25 = US25_1
            struct (-1, v1634, v1635)
        | US24_0(v311) -> (* Ok *)
            let v312 : string = "true; let _capture = (|| { //"
            let v313 : bool = Fable.Core.RustInterop.emitRustExpr () v312 
            let v314 : string = "$0"
            let v315 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v311 v314 
            let v316 : string = "v315.lock()"
            let v317 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v316 
            (* run_target_args'
            let v319 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v320 : string = "$0.unwrap()"
            let v321 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v317 v320 
            let _run_target_args'_v319 = v321 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v322 : string = "$0.unwrap()"
            let v323 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v317 v322 
            let _run_target_args'_v319 = v323 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v324 : string = "$0.unwrap()"
            let v325 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v317 v324 
            let _run_target_args'_v319 = v325 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v326 : std_sync_MutexGuard<std_process_Child option> = match v317 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v319 = v326 
            #endif
#if FABLE_COMPILER_PYTHON
            let v327 : std_sync_MutexGuard<std_process_Child option> = match v317 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v319 = v327 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v328 : std_sync_MutexGuard<std_process_Child option> = match v317 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v319 = v328 
            #endif
#else
            let v329 : std_sync_MutexGuard<std_process_Child option> = match v317 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v319 = v329 
            #endif
            let v330 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v319 
            let v333 : std_sync_MutexGuard<std_process_Child option> = method115(v330)
            let v334 : string = "true; let mut v333 = v333"
            let v335 : bool = Fable.Core.RustInterop.emitRustExpr () v334 
            let v336 : string = "&mut $0"
            let v337 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v333 v336 
            let v338 : string = "$0.as_mut()"
            let v339 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v337 v338 
            let v340 : string = "$0.unwrap()"
            let v341 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v339 v340 
            let v342 : string = "&mut $0.stdout"
            let v343 : Ref<Mut<std_process_ChildStdout option>> = Fable.Core.RustInterop.emitRustExpr v341 v342 
            let v344 : string = "Option::take($0)"
            let v345 : std_process_ChildStdout option = Fable.Core.RustInterop.emitRustExpr v343 v344 
            let v346 : string = "$0.unwrap()"
            let v347 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr v345 v346 
            let v348 : string = "true; $0 })()"
            let v349 : bool = Fable.Core.RustInterop.emitRustExpr v347 v348 
            let v350 : string = "_capture"
            let v351 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr () v350 
            let v352 : string = "true; let _capture = (|| { //"
            let v353 : bool = Fable.Core.RustInterop.emitRustExpr () v352 
            let v354 : string = "$0"
            let v355 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v311 v354 
            let v356 : string = "v355.lock()"
            let v357 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v356 
            (* run_target_args'
            let v359 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v360 : string = "$0.unwrap()"
            let v361 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v357 v360 
            let _run_target_args'_v359 = v361 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v362 : string = "$0.unwrap()"
            let v363 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v357 v362 
            let _run_target_args'_v359 = v363 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v364 : string = "$0.unwrap()"
            let v365 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v357 v364 
            let _run_target_args'_v359 = v365 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v366 : std_sync_MutexGuard<std_process_Child option> = match v357 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v359 = v366 
            #endif
#if FABLE_COMPILER_PYTHON
            let v367 : std_sync_MutexGuard<std_process_Child option> = match v357 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v359 = v367 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v368 : std_sync_MutexGuard<std_process_Child option> = match v357 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v359 = v368 
            #endif
#else
            let v369 : std_sync_MutexGuard<std_process_Child option> = match v357 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v359 = v369 
            #endif
            let v370 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v359 
            let v373 : std_sync_MutexGuard<std_process_Child option> = method115(v370)
            let v374 : string = "true; let mut v373 = v373"
            let v375 : bool = Fable.Core.RustInterop.emitRustExpr () v374 
            let v376 : string = "&mut $0"
            let v377 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v373 v376 
            let v378 : string = "$0.as_mut()"
            let v379 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v377 v378 
            let v380 : string = "$0.unwrap()"
            let v381 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v379 v380 
            let v382 : string = "&mut $0.stderr"
            let v383 : Ref<Mut<std_process_ChildStderr option>> = Fable.Core.RustInterop.emitRustExpr v381 v382 
            let v384 : string = "Option::take($0)"
            let v385 : std_process_ChildStderr option = Fable.Core.RustInterop.emitRustExpr v383 v384 
            let v386 : string = "$0.unwrap()"
            let v387 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr v385 v386 
            let v388 : string = "true; $0 })()"
            let v389 : bool = Fable.Core.RustInterop.emitRustExpr v387 v388 
            let v390 : string = "_capture"
            let v391 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr () v390 
            let v392 : string = "true; let _capture = (|| { //"
            let v393 : bool = Fable.Core.RustInterop.emitRustExpr () v392 
            let v394 : string = "$0"
            let v395 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v311 v394 
            let v396 : string = "v395.lock()"
            let v397 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v396 
            (* run_target_args'
            let v399 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v400 : string = "$0.unwrap()"
            let v401 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v397 v400 
            let _run_target_args'_v399 = v401 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v402 : string = "$0.unwrap()"
            let v403 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v397 v402 
            let _run_target_args'_v399 = v403 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v404 : string = "$0.unwrap()"
            let v405 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v397 v404 
            let _run_target_args'_v399 = v405 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v406 : std_sync_MutexGuard<std_process_Child option> = match v397 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v399 = v406 
            #endif
#if FABLE_COMPILER_PYTHON
            let v407 : std_sync_MutexGuard<std_process_Child option> = match v397 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v399 = v407 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v408 : std_sync_MutexGuard<std_process_Child option> = match v397 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v399 = v408 
            #endif
#else
            let v409 : std_sync_MutexGuard<std_process_Child option> = match v397 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v399 = v409 
            #endif
            let v410 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v399 
            let v413 : std_sync_MutexGuard<std_process_Child option> = method115(v410)
            let v414 : string = "true; let mut v413 = v413"
            let v415 : bool = Fable.Core.RustInterop.emitRustExpr () v414 
            let v416 : string = "&mut $0"
            let v417 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v413 v416 
            let v418 : string = "$0.as_mut()"
            let v419 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v417 v418 
            let v420 : string = "$0.unwrap()"
            let v421 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v419 v420 
            let v422 : string = "&mut $0.stdin"
            let v423 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v421 v422 
            let v424 : string = "Option::take($0)"
            let v425 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v423 v424 
            let v426 : string = "$0.unwrap()"
            let v427 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr v425 v426 
            let v429 : std_process_ChildStdin option = Some v427 
            let v432 : (std_process_ChildStdin option -> std_process_ChildStdin option) = method116()
            let v433 : std_process_ChildStdin option = v432 v429
            let v434 : string = "std::sync::Mutex::new(v433)"
            let v435 : std_sync_Mutex<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr () v434 
            let v436 : string = "std::sync::Arc::new(v435)"
            let v437 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v436 
            let v438 : string = "true; $0 })()"
            let v439 : bool = Fable.Core.RustInterop.emitRustExpr v437 v438 
            let v440 : string = "_capture"
            let v441 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v440 
            let v442 : string = "{ let (sender, receiver) = std::sync::mpsc::channel(); (sender, std::sync::Arc::new(receiver)) }"
            let struct (v443 : std_sync_mpsc_Sender<std_string_String>, v444 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = Fable.Core.RustInterop.emitRustExpr () v442 
            let v445 : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) = method117()
            let v446 : std_sync_mpsc_Sender<std_string_String> = v445 v443
            let v447 : string = "std::sync::Mutex::new(v446)"
            let v448 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v447 
            let v449 : string = "std::sync::Arc::new(v448)"
            let v450 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v449 
            let v451 : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) = method118()
            let v452 : std_sync_mpsc_Sender<std_string_String> = v451 v443
            let v453 : string = "std::sync::Mutex::new(v452)"
            let v454 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v453 
            let v455 : string = "std::sync::Arc::new(v454)"
            let v456 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v455 
            let v457 : (std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> -> std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = method119()
            let v458 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> = v457 v444
            let v459 : string = "std::sync::Mutex::new(v458)"
            let v460 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v459 
            let v461 : string = "std::sync::Arc::new(v460)"
            let v462 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v461 
            let v463 : string = "true; let __spawn = std::thread::spawn(move || { //"
            let v464 : bool = Fable.Core.RustInterop.emitRustExpr () v463 
            let v465 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v466 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v351 v465 
            let v467 : string = "std::io::BufReader::new($0)"
            let v468 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr v466 v467 
            let v469 : string = "std::io::BufRead::lines(v468)"
            let v470 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v469 
            let v471 : string = "true; let mut v470 = v470; let _iter_try_for_each = v470.try_for_each(|x| { //"
            let v472 : bool = Fable.Core.RustInterop.emitRustExpr () v471 
            let v473 : string = "x"
            let v474 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v473 
            let v475 : string = "$0.clone()"
            let v476 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v450 v475 
            let v477 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v479 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v480 : string = "$0.map_err(|x| $1(x))"
            let v481 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v474, v477) v480 
            let _run_target_args'_v479 = v481 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v482 : string = "$0.map_err(|x| $1(x))"
            let v483 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v474, v477) v482 
            let _run_target_args'_v479 = v483 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v484 : string = "$0.map_err(|x| $1(x))"
            let v485 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v474, v477) v484 
            let _run_target_args'_v479 = v485 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v486 : Result<std_string_String, std_string_String> = match v474 with Ok x -> Ok x | Error x -> Error (v477 x)
            let _run_target_args'_v479 = v486 
            #endif
#if FABLE_COMPILER_PYTHON
            let v487 : Result<std_string_String, std_string_String> = match v474 with Ok x -> Ok x | Error x -> Error (v477 x)
            let _run_target_args'_v479 = v487 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v488 : Result<std_string_String, std_string_String> = match v474 with Ok x -> Ok x | Error x -> Error (v477 x)
            let _run_target_args'_v479 = v488 
            #endif
#else
            let v489 : Result<std_string_String, std_string_String> = match v474 with Ok x -> Ok x | Error x -> Error (v477 x)
            let _run_target_args'_v479 = v489 
            #endif
            let v490 : Result<std_string_String, std_string_String> = _run_target_args'_v479 
            let v493 : (std_string_String -> US26) = method120()
            let v494 : (std_string_String -> US26) = method121()
            let v495 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v496 : US26 = Fable.Core.RustInterop.emitRustExpr struct (v493, v494, v490) v495 
            let v733 : std_string_String =
                match v496 with
                | US26_1(v615) -> (* Error *)
                    let v616 : unit = ()
                    let v617 : (unit -> unit) = closure51(v5, v615)
                    let v618 : unit = (fun () -> v617 (); v616) ()
                    let v665 : string = $"\u001b[4;7m{v615}\u001b[0m"
                    (* run_target_args'
                    let v670 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v671 : string = "&*$0"
                    let v672 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v665 v671 
                    let _run_target_args'_v670 = v672 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v673 : string = "&*$0"
                    let v674 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v665 v673 
                    let _run_target_args'_v670 = v674 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v675 : string = "&*$0"
                    let v676 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v665 v675 
                    let _run_target_args'_v670 = v676 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v678 : Ref<Str> = v665 |> unbox<Ref<Str>>
                    let _run_target_args'_v670 = v678 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v682 : Ref<Str> = v665 |> unbox<Ref<Str>>
                    let _run_target_args'_v670 = v682 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v686 : Ref<Str> = v665 |> unbox<Ref<Str>>
                    let _run_target_args'_v670 = v686 
                    #endif
#else
                    let v690 : Ref<Str> = v665 |> unbox<Ref<Str>>
                    let _run_target_args'_v670 = v690 
                    #endif
                    let v693 : Ref<Str> = _run_target_args'_v670 
                    (* run_target_args'
                    let v703 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v704 : string = "String::from($0)"
                    let v705 : std_string_String = Fable.Core.RustInterop.emitRustExpr v693 v704 
                    let _run_target_args'_v703 = v705 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v706 : string = "String::from($0)"
                    let v707 : std_string_String = Fable.Core.RustInterop.emitRustExpr v693 v706 
                    let _run_target_args'_v703 = v707 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v708 : string = "String::from($0)"
                    let v709 : std_string_String = Fable.Core.RustInterop.emitRustExpr v693 v708 
                    let _run_target_args'_v703 = v709 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v711 : std_string_String = v693 |> unbox<std_string_String>
                    let _run_target_args'_v703 = v711 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v715 : std_string_String = v693 |> unbox<std_string_String>
                    let _run_target_args'_v703 = v715 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v719 : std_string_String = v693 |> unbox<std_string_String>
                    let _run_target_args'_v703 = v719 
                    #endif
#else
                    let v723 : std_string_String = v693 |> unbox<std_string_String>
                    let _run_target_args'_v703 = v723 
                    #endif
                    let v726 : std_string_String = _run_target_args'_v703 
                    v726
                | US26_0(v497) -> (* Ok *)
                    let v498 : string = "fable_library_rust::String_::fromString($0)"
                    let v499 : string = Fable.Core.RustInterop.emitRustExpr v497 v498 
                    let v500 : string = "encoding_rs::UTF_8"
                    let v501 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v500 
                    let v502 : string = "$0.encode(&*$1).0"
                    let v503 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v501, v499) v502 
                    let v504 : string = "$0.as_ref()"
                    let v505 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v503 v504 
                    let v506 : string = "std::str::from_utf8($0)"
                    let v507 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr v505 v506 
                    (* run_target_args'
                    let v509 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v510 : string = "$0.unwrap()"
                    let v511 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v507 v510 
                    let _run_target_args'_v509 = v511 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v512 : string = "$0.unwrap()"
                    let v513 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v507 v512 
                    let _run_target_args'_v509 = v513 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v514 : string = "$0.unwrap()"
                    let v515 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v507 v514 
                    let _run_target_args'_v509 = v515 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v516 : Ref<Str> = match v507 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v509 = v516 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v517 : Ref<Str> = match v507 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v509 = v517 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v518 : Ref<Str> = match v507 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v509 = v518 
                    #endif
#else
                    let v519 : Ref<Str> = match v507 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v509 = v519 
                    #endif
                    let v520 : Ref<Str> = _run_target_args'_v509 
                    (* run_target_args'
                    let v527 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v528 : string = "String::from($0)"
                    let v529 : std_string_String = Fable.Core.RustInterop.emitRustExpr v520 v528 
                    let _run_target_args'_v527 = v529 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v530 : string = "String::from($0)"
                    let v531 : std_string_String = Fable.Core.RustInterop.emitRustExpr v520 v530 
                    let _run_target_args'_v527 = v531 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v532 : string = "String::from($0)"
                    let v533 : std_string_String = Fable.Core.RustInterop.emitRustExpr v520 v532 
                    let _run_target_args'_v527 = v533 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v535 : std_string_String = v520 |> unbox<std_string_String>
                    let _run_target_args'_v527 = v535 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v539 : std_string_String = v520 |> unbox<std_string_String>
                    let _run_target_args'_v527 = v539 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v543 : std_string_String = v520 |> unbox<std_string_String>
                    let _run_target_args'_v527 = v543 
                    #endif
#else
                    let v547 : std_string_String = v520 |> unbox<std_string_String>
                    let _run_target_args'_v527 = v547 
                    #endif
                    let v550 : std_string_String = _run_target_args'_v527 
                    let v556 : string = "fable_library_rust::String_::fromString($0)"
                    let v557 : string = Fable.Core.RustInterop.emitRustExpr v550 v556 
                    let v558 : string = $"> {v557}"
                    if v5 then
                        let v559 : unit = ()
                        let v560 : (unit -> unit) = closure52(v558)
                        let v561 : unit = (fun () -> v560 (); v559) ()
                        ()
                    else
                        let v611 : unit = ()
                        let v612 : (unit -> unit) = closure11(v558)
                        let v613 : unit = (fun () -> v612 (); v611) ()
                        ()
                    v550
            let v734 : string = "$0"
            let v735 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v476 v734 
            let v736 : string = "v735.lock()"
            let v737 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v736 
            (* run_target_args'
            let v739 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v740 : string = "$0.unwrap()"
            let v741 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v737 v740 
            let _run_target_args'_v739 = v741 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v742 : string = "$0.unwrap()"
            let v743 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v737 v742 
            let _run_target_args'_v739 = v743 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v744 : string = "$0.unwrap()"
            let v745 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v737 v744 
            let _run_target_args'_v739 = v745 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v746 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v737 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v739 = v746 
            #endif
#if FABLE_COMPILER_PYTHON
            let v747 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v737 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v739 = v747 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v748 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v737 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v739 = v748 
            #endif
#else
            let v749 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v737 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v739 = v749 
            #endif
            let v750 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = _run_target_args'_v739 
            let v753 : string = "&$0"
            let v754 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v750 v753 
            let v755 : string = "$0.send($1)"
            let v756 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v754, v733) v755 
            let v757 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method127()
            (* run_target_args'
            let v759 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v760 : string = "$0.map_err(|x| $1(x))"
            let v761 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v756, v757) v760 
            let _run_target_args'_v759 = v761 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v762 : string = "$0.map_err(|x| $1(x))"
            let v763 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v756, v757) v762 
            let _run_target_args'_v759 = v763 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v764 : string = "$0.map_err(|x| $1(x))"
            let v765 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v756, v757) v764 
            let _run_target_args'_v759 = v765 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v766 : Result<unit, std_string_String> = match v756 with Ok x -> Ok x | Error x -> Error (v757 x)
            let _run_target_args'_v759 = v766 
            #endif
#if FABLE_COMPILER_PYTHON
            let v767 : Result<unit, std_string_String> = match v756 with Ok x -> Ok x | Error x -> Error (v757 x)
            let _run_target_args'_v759 = v767 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Result<unit, std_string_String> = match v756 with Ok x -> Ok x | Error x -> Error (v757 x)
            let _run_target_args'_v759 = v768 
            #endif
#else
            let v769 : Result<unit, std_string_String> = match v756 with Ok x -> Ok x | Error x -> Error (v757 x)
            let _run_target_args'_v759 = v769 
            #endif
            let v770 : Result<unit, std_string_String> = _run_target_args'_v759 
            let v773 : string = "$0"
            let v774 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v770 v773 
            let v775 : string = "true; $0 }); //"
            let v776 : bool = Fable.Core.RustInterop.emitRustExpr v774 v775 
            let v777 : string = "_iter_try_for_each.map_err(|x| x.into())"
            let v778 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v777 
            let v779 : Result<unit, string> = method128(v778)
            let v780 : string = ""
            let v781 : string = "}"
            let v782 : string = v780 + v781 
            let x = v779 //
            let v783 : _ = x
            let v784 : unit = ()
            (* run_target_args'
            let v785 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v786 : string = $"true; let _fix_closure_v784 = $0"
            let v787 : bool = Fable.Core.RustInterop.emitRustExpr v783 v786 
            let _run_target_args'_v785 = true 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v788 : string = $"true; let _fix_closure_v784 = $0"
            let v789 : bool = Fable.Core.RustInterop.emitRustExpr v783 v788 
            let _run_target_args'_v785 = true 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v790 : string = $"true; let _fix_closure_v784 = $0"
            let v791 : bool = Fable.Core.RustInterop.emitRustExpr v783 v790 
            let _run_target_args'_v785 = true 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let _run_target_args'_v785 = false 
            #endif
#if FABLE_COMPILER_PYTHON
            let _run_target_args'_v785 = false 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let _run_target_args'_v785 = false 
            #endif
#else
            let _run_target_args'_v785 = false 
            #endif
            let v792 : bool = _run_target_args'_v785 
            let v794 : string = $"true; _fix_closure_v784 " + v782 + "); " + v780 + " // rust.fix_closure'"
            let v795 : bool = Fable.Core.RustInterop.emitRustExpr () v794 
            let v796 : string = "__spawn"
            let v797 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v796 
            let v798 : string = "true; let __spawn = std::thread::spawn(move || { //"
            let v799 : bool = Fable.Core.RustInterop.emitRustExpr () v798 
            let v800 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v801 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v391 v800 
            let v802 : string = "std::io::BufReader::new($0)"
            let v803 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr v801 v802 
            let v804 : string = "std::io::BufRead::lines(v803)"
            let v805 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v804 
            let v806 : string = "true; let mut v805 = v805; let _iter_try_for_each = v805.try_for_each(|x| { //"
            let v807 : bool = Fable.Core.RustInterop.emitRustExpr () v806 
            let v808 : string = "x"
            let v809 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v808 
            let v810 : string = "$0.clone()"
            let v811 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v456 v810 
            let v812 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v814 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v815 : string = "$0.map_err(|x| $1(x))"
            let v816 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v809, v812) v815 
            let _run_target_args'_v814 = v816 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v817 : string = "$0.map_err(|x| $1(x))"
            let v818 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v809, v812) v817 
            let _run_target_args'_v814 = v818 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v819 : string = "$0.map_err(|x| $1(x))"
            let v820 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v809, v812) v819 
            let _run_target_args'_v814 = v820 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v821 : Result<std_string_String, std_string_String> = match v809 with Ok x -> Ok x | Error x -> Error (v812 x)
            let _run_target_args'_v814 = v821 
            #endif
#if FABLE_COMPILER_PYTHON
            let v822 : Result<std_string_String, std_string_String> = match v809 with Ok x -> Ok x | Error x -> Error (v812 x)
            let _run_target_args'_v814 = v822 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v823 : Result<std_string_String, std_string_String> = match v809 with Ok x -> Ok x | Error x -> Error (v812 x)
            let _run_target_args'_v814 = v823 
            #endif
#else
            let v824 : Result<std_string_String, std_string_String> = match v809 with Ok x -> Ok x | Error x -> Error (v812 x)
            let _run_target_args'_v814 = v824 
            #endif
            let v825 : Result<std_string_String, std_string_String> = _run_target_args'_v814 
            let v828 : (std_string_String -> US26) = method120()
            let v829 : (std_string_String -> US26) = method121()
            let v830 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v831 : US26 = Fable.Core.RustInterop.emitRustExpr struct (v828, v829, v825) v830 
            let v1134 : std_string_String =
                match v831 with
                | US26_1(v1016) -> (* Error *)
                    let v1017 : unit = ()
                    let v1018 : (unit -> unit) = closure51(v5, v1016)
                    let v1019 : unit = (fun () -> v1018 (); v1017) ()
                    let v1066 : string = $"\u001b[4;7m{v1016}\u001b[0m"
                    (* run_target_args'
                    let v1071 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1072 : string = "&*$0"
                    let v1073 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1066 v1072 
                    let _run_target_args'_v1071 = v1073 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1074 : string = "&*$0"
                    let v1075 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1066 v1074 
                    let _run_target_args'_v1071 = v1075 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1076 : string = "&*$0"
                    let v1077 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1066 v1076 
                    let _run_target_args'_v1071 = v1077 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1079 : Ref<Str> = v1066 |> unbox<Ref<Str>>
                    let _run_target_args'_v1071 = v1079 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1083 : Ref<Str> = v1066 |> unbox<Ref<Str>>
                    let _run_target_args'_v1071 = v1083 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1087 : Ref<Str> = v1066 |> unbox<Ref<Str>>
                    let _run_target_args'_v1071 = v1087 
                    #endif
#else
                    let v1091 : Ref<Str> = v1066 |> unbox<Ref<Str>>
                    let _run_target_args'_v1071 = v1091 
                    #endif
                    let v1094 : Ref<Str> = _run_target_args'_v1071 
                    (* run_target_args'
                    let v1104 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1105 : string = "String::from($0)"
                    let v1106 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1094 v1105 
                    let _run_target_args'_v1104 = v1106 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1107 : string = "String::from($0)"
                    let v1108 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1094 v1107 
                    let _run_target_args'_v1104 = v1108 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1109 : string = "String::from($0)"
                    let v1110 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1094 v1109 
                    let _run_target_args'_v1104 = v1110 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1112 : std_string_String = v1094 |> unbox<std_string_String>
                    let _run_target_args'_v1104 = v1112 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1116 : std_string_String = v1094 |> unbox<std_string_String>
                    let _run_target_args'_v1104 = v1116 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1120 : std_string_String = v1094 |> unbox<std_string_String>
                    let _run_target_args'_v1104 = v1120 
                    #endif
#else
                    let v1124 : std_string_String = v1094 |> unbox<std_string_String>
                    let _run_target_args'_v1104 = v1124 
                    #endif
                    let v1127 : std_string_String = _run_target_args'_v1104 
                    v1127
                | US26_0(v832) -> (* Ok *)
                    let v833 : string = "fable_library_rust::String_::fromString($0)"
                    let v834 : string = Fable.Core.RustInterop.emitRustExpr v832 v833 
                    let v835 : string = "encoding_rs::UTF_8"
                    let v836 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v835 
                    let v837 : string = "$0.encode(&*$1).0"
                    let v838 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v836, v834) v837 
                    let v839 : string = "$0.as_ref()"
                    let v840 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v838 v839 
                    let v841 : string = "std::str::from_utf8($0)"
                    let v842 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr v840 v841 
                    (* run_target_args'
                    let v844 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v845 : string = "$0.unwrap()"
                    let v846 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v842 v845 
                    let _run_target_args'_v844 = v846 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v847 : string = "$0.unwrap()"
                    let v848 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v842 v847 
                    let _run_target_args'_v844 = v848 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v849 : string = "$0.unwrap()"
                    let v850 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v842 v849 
                    let _run_target_args'_v844 = v850 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v851 : Ref<Str> = match v842 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v844 = v851 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v852 : Ref<Str> = match v842 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v844 = v852 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v853 : Ref<Str> = match v842 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v844 = v853 
                    #endif
#else
                    let v854 : Ref<Str> = match v842 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v844 = v854 
                    #endif
                    let v855 : Ref<Str> = _run_target_args'_v844 
                    (* run_target_args'
                    let v862 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v863 : string = "String::from($0)"
                    let v864 : std_string_String = Fable.Core.RustInterop.emitRustExpr v855 v863 
                    let _run_target_args'_v862 = v864 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v865 : string = "String::from($0)"
                    let v866 : std_string_String = Fable.Core.RustInterop.emitRustExpr v855 v865 
                    let _run_target_args'_v862 = v866 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v867 : string = "String::from($0)"
                    let v868 : std_string_String = Fable.Core.RustInterop.emitRustExpr v855 v867 
                    let _run_target_args'_v862 = v868 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v870 : std_string_String = v855 |> unbox<std_string_String>
                    let _run_target_args'_v862 = v870 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v874 : std_string_String = v855 |> unbox<std_string_String>
                    let _run_target_args'_v862 = v874 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v878 : std_string_String = v855 |> unbox<std_string_String>
                    let _run_target_args'_v862 = v878 
                    #endif
#else
                    let v882 : std_string_String = v855 |> unbox<std_string_String>
                    let _run_target_args'_v862 = v882 
                    #endif
                    let v885 : std_string_String = _run_target_args'_v862 
                    let v891 : string = "fable_library_rust::String_::fromString($0)"
                    let v892 : string = Fable.Core.RustInterop.emitRustExpr v885 v891 
                    let v893 : string = $"! {v892}"
                    if v5 then
                        let v894 : unit = ()
                        let v895 : (unit -> unit) = closure52(v893)
                        let v896 : unit = (fun () -> v895 (); v894) ()
                        ()
                    else
                        let v945 : unit = ()
                        let v946 : (unit -> unit) = closure11(v893)
                        let v947 : unit = (fun () -> v946 (); v945) ()
                        ()
                    let v949 : string = $"\u001b[4;7m{v885}\u001b[0m"
                    (* run_target_args'
                    let v954 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v955 : string = "&*$0"
                    let v956 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v949 v955 
                    let _run_target_args'_v954 = v956 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v957 : string = "&*$0"
                    let v958 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v949 v957 
                    let _run_target_args'_v954 = v958 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v959 : string = "&*$0"
                    let v960 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v949 v959 
                    let _run_target_args'_v954 = v960 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v962 : Ref<Str> = v949 |> unbox<Ref<Str>>
                    let _run_target_args'_v954 = v962 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v966 : Ref<Str> = v949 |> unbox<Ref<Str>>
                    let _run_target_args'_v954 = v966 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v970 : Ref<Str> = v949 |> unbox<Ref<Str>>
                    let _run_target_args'_v954 = v970 
                    #endif
#else
                    let v974 : Ref<Str> = v949 |> unbox<Ref<Str>>
                    let _run_target_args'_v954 = v974 
                    #endif
                    let v977 : Ref<Str> = _run_target_args'_v954 
                    (* run_target_args'
                    let v987 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v988 : string = "String::from($0)"
                    let v989 : std_string_String = Fable.Core.RustInterop.emitRustExpr v977 v988 
                    let _run_target_args'_v987 = v989 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v990 : string = "String::from($0)"
                    let v991 : std_string_String = Fable.Core.RustInterop.emitRustExpr v977 v990 
                    let _run_target_args'_v987 = v991 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v992 : string = "String::from($0)"
                    let v993 : std_string_String = Fable.Core.RustInterop.emitRustExpr v977 v992 
                    let _run_target_args'_v987 = v993 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v995 : std_string_String = v977 |> unbox<std_string_String>
                    let _run_target_args'_v987 = v995 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v999 : std_string_String = v977 |> unbox<std_string_String>
                    let _run_target_args'_v987 = v999 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1003 : std_string_String = v977 |> unbox<std_string_String>
                    let _run_target_args'_v987 = v1003 
                    #endif
#else
                    let v1007 : std_string_String = v977 |> unbox<std_string_String>
                    let _run_target_args'_v987 = v1007 
                    #endif
                    let v1010 : std_string_String = _run_target_args'_v987 
                    v1010
            let v1135 : string = "$0"
            let v1136 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v811 v1135 
            let v1137 : string = "v1136.lock()"
            let v1138 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v1137 
            (* run_target_args'
            let v1140 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1141 : string = "$0.unwrap()"
            let v1142 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1138 v1141 
            let _run_target_args'_v1140 = v1142 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1143 : string = "$0.unwrap()"
            let v1144 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1138 v1143 
            let _run_target_args'_v1140 = v1144 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1145 : string = "$0.unwrap()"
            let v1146 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1138 v1145 
            let _run_target_args'_v1140 = v1146 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1147 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1138 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1140 = v1147 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1148 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1138 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1140 = v1148 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1149 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1138 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1140 = v1149 
            #endif
#else
            let v1150 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1138 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1140 = v1150 
            #endif
            let v1151 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = _run_target_args'_v1140 
            let v1154 : string = "&$0"
            let v1155 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1151 v1154 
            let v1156 : string = "$0.send($1)"
            let v1157 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v1155, v1134) v1156 
            let v1158 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method127()
            (* run_target_args'
            let v1160 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1161 : string = "$0.map_err(|x| $1(x))"
            let v1162 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1157, v1158) v1161 
            let _run_target_args'_v1160 = v1162 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1163 : string = "$0.map_err(|x| $1(x))"
            let v1164 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1157, v1158) v1163 
            let _run_target_args'_v1160 = v1164 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1165 : string = "$0.map_err(|x| $1(x))"
            let v1166 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1157, v1158) v1165 
            let _run_target_args'_v1160 = v1166 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1167 : Result<unit, std_string_String> = match v1157 with Ok x -> Ok x | Error x -> Error (v1158 x)
            let _run_target_args'_v1160 = v1167 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1168 : Result<unit, std_string_String> = match v1157 with Ok x -> Ok x | Error x -> Error (v1158 x)
            let _run_target_args'_v1160 = v1168 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1169 : Result<unit, std_string_String> = match v1157 with Ok x -> Ok x | Error x -> Error (v1158 x)
            let _run_target_args'_v1160 = v1169 
            #endif
#else
            let v1170 : Result<unit, std_string_String> = match v1157 with Ok x -> Ok x | Error x -> Error (v1158 x)
            let _run_target_args'_v1160 = v1170 
            #endif
            let v1171 : Result<unit, std_string_String> = _run_target_args'_v1160 
            let v1174 : string = "$0"
            let v1175 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v1171 v1174 
            let v1176 : string = "true; $0 }); //"
            let v1177 : bool = Fable.Core.RustInterop.emitRustExpr v1175 v1176 
            let v1178 : string = "_iter_try_for_each.map_err(|x| x.into())"
            let v1179 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v1178 
            let v1180 : Result<unit, string> = method128(v1179)
            let v1181 : string = v780 + v781 
            let x = v1180 //
            let v1182 : _ = x
            let v1183 : unit = ()
            (* run_target_args'
            let v1184 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1185 : string = $"true; let _fix_closure_v1183 = $0"
            let v1186 : bool = Fable.Core.RustInterop.emitRustExpr v1182 v1185 
            let _run_target_args'_v1184 = true 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1187 : string = $"true; let _fix_closure_v1183 = $0"
            let v1188 : bool = Fable.Core.RustInterop.emitRustExpr v1182 v1187 
            let _run_target_args'_v1184 = true 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1189 : string = $"true; let _fix_closure_v1183 = $0"
            let v1190 : bool = Fable.Core.RustInterop.emitRustExpr v1182 v1189 
            let _run_target_args'_v1184 = true 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let _run_target_args'_v1184 = false 
            #endif
#if FABLE_COMPILER_PYTHON
            let _run_target_args'_v1184 = false 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let _run_target_args'_v1184 = false 
            #endif
#else
            let _run_target_args'_v1184 = false 
            #endif
            let v1191 : bool = _run_target_args'_v1184 
            let v1193 : string = $"true; _fix_closure_v1183 " + v1181 + "); " + v780 + " // rust.fix_closure'"
            let v1194 : bool = Fable.Core.RustInterop.emitRustExpr () v1193 
            let v1195 : string = "__spawn"
            let v1196 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v1195 
            let v1199 : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US27) = method129()
            let v1200 : US27 option = v4 |> Option.map v1199 
            let v1220 : US27 = US27_1
            let v1221 : US27 = v1200 |> Option.defaultValue v1220 
            match v1221 with
            | US27_1 -> (* None *)
                ()
            | US27_0(v1225) -> (* Some *)
                let v1226 : string = "$0"
                let v1227 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v441 v1226 
                let v1228 : string = "v1227.lock()"
                let v1229 : Result<std_sync_MutexGuard<std_process_ChildStdin option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin option>>> = Fable.Core.RustInterop.emitRustExpr () v1228 
                (* run_target_args'
                let v1231 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1232 : string = "$0.unwrap()"
                let v1233 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1229 v1232 
                let _run_target_args'_v1231 = v1233 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1234 : string = "$0.unwrap()"
                let v1235 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1229 v1234 
                let _run_target_args'_v1231 = v1235 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1236 : string = "$0.unwrap()"
                let v1237 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1229 v1236 
                let _run_target_args'_v1231 = v1237 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1238 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1229 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1231 = v1238 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1239 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1229 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1231 = v1239 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v1240 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1229 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1231 = v1240 
                #endif
#else
                let v1241 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1229 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1231 = v1241 
                #endif
                let v1242 : std_sync_MutexGuard<std_process_ChildStdin option> = _run_target_args'_v1231 
                let v1245 : std_sync_MutexGuard<std_process_ChildStdin option> = method130(v1242)
                let v1246 : string = "true; let mut v1245 = v1245"
                let v1247 : bool = Fable.Core.RustInterop.emitRustExpr () v1246 
                let v1248 : string = "&mut $0"
                let v1249 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v1245 v1248 
                let v1250 : string = "Option::take($0)"
                let v1251 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v1249 v1250 
                let v1252 : string = "true; let _optionm_map_ = $0.map(|x| { //"
                let v1253 : bool = Fable.Core.RustInterop.emitRustExpr v1251 v1252 
                let v1254 : string = "x"
                let v1255 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr () v1254 
                let v1256 : string = "std::sync::Mutex::new(v1255)"
                let v1257 : std_sync_Mutex<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr () v1256 
                let v1258 : string = "std::sync::Arc::new(v1257)"
                let v1259 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr () v1258 
                let v1260 : string = "true; $0 })"
                let v1261 : bool = Fable.Core.RustInterop.emitRustExpr v1259 v1260 
                let v1262 : string = "_optionm_map_"
                let v1263 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> option = Fable.Core.RustInterop.emitRustExpr () v1262 
                let v1266 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US28) = method131()
                let v1267 : US28 option = v1263 |> Option.map v1266 
                let v1287 : US28 = US28_1
                let v1288 : US28 = v1267 |> Option.defaultValue v1287 
                match v1288 with
                | US28_1 -> (* None *)
                    ()
                | US28_0(v1292) -> (* Some *)
                    v1225 v1292
                    let v1293 : string = "$0"
                    let v1294 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr v1292 v1293 
                    let v1295 : string = "v1294.lock()"
                    let v1296 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr () v1295 
                    (* run_target_args'
                    let v1298 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1299 : string = "$0.unwrap()"
                    let v1300 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1296 v1299 
                    let _run_target_args'_v1298 = v1300 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1301 : string = "$0.unwrap()"
                    let v1302 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1296 v1301 
                    let _run_target_args'_v1298 = v1302 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1303 : string = "$0.unwrap()"
                    let v1304 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1296 v1303 
                    let _run_target_args'_v1298 = v1304 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1305 : std_sync_MutexGuard<std_process_ChildStdin> = match v1296 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1298 = v1305 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1306 : std_sync_MutexGuard<std_process_ChildStdin> = match v1296 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1298 = v1306 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1307 : std_sync_MutexGuard<std_process_ChildStdin> = match v1296 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1298 = v1307 
                    #endif
#else
                    let v1308 : std_sync_MutexGuard<std_process_ChildStdin> = match v1296 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1298 = v1308 
                    #endif
                    let v1309 : std_sync_MutexGuard<std_process_ChildStdin> = _run_target_args'_v1298 
                    let v1312 : std_sync_MutexGuard<std_process_ChildStdin> = method132(v1309)
                    let v1313 : string = "true; let mut v1312 = v1312"
                    let v1314 : bool = Fable.Core.RustInterop.emitRustExpr () v1313 
                    let v1315 : string = "true; std::io::Write::flush(&mut *$0).unwrap()"
                    let v1316 : bool = Fable.Core.RustInterop.emitRustExpr v1312 v1315 
                    ()
            let v1317 : string = "$0"
            let v1318 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v311 v1317 
            let v1319 : string = "v1318.lock()"
            let v1320 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v1319 
            (* run_target_args'
            let v1322 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1323 : string = "$0.unwrap()"
            let v1324 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1320 v1323 
            let _run_target_args'_v1322 = v1324 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1325 : string = "$0.unwrap()"
            let v1326 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1320 v1325 
            let _run_target_args'_v1322 = v1326 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1327 : string = "$0.unwrap()"
            let v1328 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1320 v1327 
            let _run_target_args'_v1322 = v1328 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1329 : std_sync_MutexGuard<std_process_Child option> = match v1320 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1322 = v1329 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1330 : std_sync_MutexGuard<std_process_Child option> = match v1320 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1322 = v1330 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1331 : std_sync_MutexGuard<std_process_Child option> = match v1320 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1322 = v1331 
            #endif
#else
            let v1332 : std_sync_MutexGuard<std_process_Child option> = match v1320 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1322 = v1332 
            #endif
            let v1333 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v1322 
            let v1336 : std_sync_MutexGuard<std_process_Child option> = method115(v1333)
            let v1337 : string = "true; let mut v1336 = v1336"
            let v1338 : bool = Fable.Core.RustInterop.emitRustExpr () v1337 
            let v1339 : string = "&mut $0"
            let v1340 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v1336 v1339 
            let v1341 : string = "Option::take($0)"
            let v1342 : std_process_Child option = Fable.Core.RustInterop.emitRustExpr v1340 v1341 
            let v1343 : string = "$0.unwrap()"
            let v1344 : std_process_Child = Fable.Core.RustInterop.emitRustExpr v1342 v1343 
            let v1345 : string = "$0.wait_with_output()"
            let v1346 : Result<std_process_Output, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1344 v1345 
            let v1347 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v1349 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1350 : string = "$0.map_err(|x| $1(x))"
            let v1351 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1346, v1347) v1350 
            let _run_target_args'_v1349 = v1351 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1352 : string = "$0.map_err(|x| $1(x))"
            let v1353 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1346, v1347) v1352 
            let _run_target_args'_v1349 = v1353 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1354 : string = "$0.map_err(|x| $1(x))"
            let v1355 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1346, v1347) v1354 
            let _run_target_args'_v1349 = v1355 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1356 : Result<std_process_Output, std_string_String> = match v1346 with Ok x -> Ok x | Error x -> Error (v1347 x)
            let _run_target_args'_v1349 = v1356 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1357 : Result<std_process_Output, std_string_String> = match v1346 with Ok x -> Ok x | Error x -> Error (v1347 x)
            let _run_target_args'_v1349 = v1357 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1358 : Result<std_process_Output, std_string_String> = match v1346 with Ok x -> Ok x | Error x -> Error (v1347 x)
            let _run_target_args'_v1349 = v1358 
            #endif
#else
            let v1359 : Result<std_process_Output, std_string_String> = match v1346 with Ok x -> Ok x | Error x -> Error (v1347 x)
            let _run_target_args'_v1349 = v1359 
            #endif
            let v1360 : Result<std_process_Output, std_string_String> = _run_target_args'_v1349 
            let v1363 : string = "v1196"
            let v1364 : string = v1363 + v780 
            let v1365 : string = v1364 + v780 
            let v1366 : string = "v797"
            let v1367 : string = ", "
            let v1368 : string = v1366 + v1367 
            let v1369 : string = v1368 + v1365 
            let v1370 : string = "vec![" + v1369 + "]"
            let v1371 : Vec<std_thread_JoinHandle<Result<unit, string>>> = Fable.Core.RustInterop.emitRustExpr () v1370 
            let v1372 : string = "true; $0.into_iter().for_each(|x| { //"
            let v1373 : bool = Fable.Core.RustInterop.emitRustExpr v1371 v1372 
            let v1374 : string = "x"
            let v1375 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v1374 
            let v1376 : string = "std::thread::JoinHandle::join($0)"
            let v1377 : Result<Result<unit, string>, Box<LifetimeRef<Dyn<LifetimeJoin<core_any_Any, LifetimeRef<LifetimeJoin<StaticLifetime, Send<StaticLifetime>>>>>>>> = Fable.Core.RustInterop.emitRustExpr v1375 v1376 
            (* run_target_args'
            let v1379 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1380 : string = "$0.unwrap()"
            let v1381 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1377 v1380 
            let _run_target_args'_v1379 = v1381 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1382 : string = "$0.unwrap()"
            let v1383 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1377 v1382 
            let _run_target_args'_v1379 = v1383 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1384 : string = "$0.unwrap()"
            let v1385 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1377 v1384 
            let _run_target_args'_v1379 = v1385 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1386 : Result<unit, string> = match v1377 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1379 = v1386 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1387 : Result<unit, string> = match v1377 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1379 = v1387 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1388 : Result<unit, string> = match v1377 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1379 = v1388 
            #endif
#else
            let v1389 : Result<unit, string> = match v1377 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1379 = v1389 
            #endif
            let v1390 : Result<unit, string> = _run_target_args'_v1379 
            (* run_target_args'
            let v1393 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1394 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1390 v1394 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1395 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1390 v1395 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1396 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1390 v1396 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            match v1390 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#if FABLE_COMPILER_PYTHON
            match v1390 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            match v1390 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#else
            match v1390 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
            // run_target_args' is_unit
            let v1397 : string = $"true"
            let v1398 : bool = Fable.Core.RustInterop.emitRustExpr () v1397 
            let v1399 : string = "true; }}); { //"
            let v1400 : bool = Fable.Core.RustInterop.emitRustExpr () v1399 
            let v1401 : (std_process_Output -> US29) = method133()
            let v1402 : (std_string_String -> US29) = method134()
            let v1404 : US29 = match v1360 with Ok x -> v1401 x | Error x -> v1402 x
            match v1404 with
            | US29_1(v1518) -> (* Error *)
                let v1519 : unit = ()
                let v1520 : (unit -> unit) = closure58(v0, v1, v2, v3, v4, v5, v6, v29, v120, v1518)
                let v1521 : unit = (fun () -> v1520 (); v1519) ()
                let v1572 : US6 = US6_0(v1518)
                let v1573 : US25 = US25_1
                struct (-2, v1572, v1573)
            | US29_0(v1407) -> (* Ok *)
                let v1408 : string = "$0.status"
                let v1409 : std_process_ExitStatus = Fable.Core.RustInterop.emitRustExpr v1407 v1408 
                let v1410 : string = "$0.code()"
                let v1411 : int32 option = Fable.Core.RustInterop.emitRustExpr v1409 v1410 
                let v1414 : (int32 -> US30) = method136()
                let v1415 : US30 option = v1411 |> Option.map v1414 
                let v1435 : US30 = US30_1
                let v1436 : US30 = v1415 |> Option.defaultValue v1435 
                match v1436 with
                | US30_1 -> (* None *)
                    let v1443 : string = "runtime.execute_with_options / exit_code=None"
                    (* run_target_args'
                    let v1448 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1449 : string = "&*$0"
                    let v1450 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1443 v1449 
                    let _run_target_args'_v1448 = v1450 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1451 : string = "&*$0"
                    let v1452 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1443 v1451 
                    let _run_target_args'_v1448 = v1452 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1453 : string = "&*$0"
                    let v1454 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1443 v1453 
                    let _run_target_args'_v1448 = v1454 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1456 : Ref<Str> = v1443 |> unbox<Ref<Str>>
                    let _run_target_args'_v1448 = v1456 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1460 : Ref<Str> = v1443 |> unbox<Ref<Str>>
                    let _run_target_args'_v1448 = v1460 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1464 : Ref<Str> = v1443 |> unbox<Ref<Str>>
                    let _run_target_args'_v1448 = v1464 
                    #endif
#else
                    let v1468 : Ref<Str> = v1443 |> unbox<Ref<Str>>
                    let _run_target_args'_v1448 = v1468 
                    #endif
                    let v1471 : Ref<Str> = _run_target_args'_v1448 
                    (* run_target_args'
                    let v1481 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1482 : string = "String::from($0)"
                    let v1483 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1471 v1482 
                    let _run_target_args'_v1481 = v1483 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1484 : string = "String::from($0)"
                    let v1485 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1471 v1484 
                    let _run_target_args'_v1481 = v1485 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1486 : string = "String::from($0)"
                    let v1487 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1471 v1486 
                    let _run_target_args'_v1481 = v1487 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1489 : std_string_String = v1471 |> unbox<std_string_String>
                    let _run_target_args'_v1481 = v1489 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1493 : std_string_String = v1471 |> unbox<std_string_String>
                    let _run_target_args'_v1481 = v1493 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1497 : std_string_String = v1471 |> unbox<std_string_String>
                    let _run_target_args'_v1481 = v1497 
                    #endif
#else
                    let v1501 : std_string_String = v1471 |> unbox<std_string_String>
                    let _run_target_args'_v1481 = v1501 
                    #endif
                    let v1504 : std_string_String = _run_target_args'_v1481 
                    let v1510 : US6 = US6_0(v1504)
                    let v1511 : US25 = US25_0(v462)
                    struct (-1, v1510, v1511)
                | US30_0(v1440) -> (* Some *)
                    let v1441 : US6 = US6_1
                    let v1442 : US25 = US25_0(v462)
                    struct (v1440, v1441, v1442)
    let v1652 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option =
        match v1641 with
        | US25_1 -> (* None *)
            let v1648 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = None
            v1648
        | US25_0(v1642) -> (* Some *)
            let v1644 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = Some v1642 
            v1644
    let v1653 : string = "true; let _optionm_map_ = $0.map(|x| { //"
    let v1654 : bool = Fable.Core.RustInterop.emitRustExpr v1652 v1653 
    let v1655 : string = "x"
    let v1656 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v1655 
    let v1657 : string = "$0"
    let v1658 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr v1656 v1657 
    let v1659 : string = "v1658.lock()"
    let v1660 : Result<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v1659 
    (* run_target_args'
    let v1662 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1663 : string = "$0.unwrap()"
    let v1664 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v1660 v1663 
    let _run_target_args'_v1662 = v1664 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1665 : string = "$0.unwrap()"
    let v1666 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v1660 v1665 
    let _run_target_args'_v1662 = v1666 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1667 : string = "$0.unwrap()"
    let v1668 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v1660 v1667 
    let _run_target_args'_v1662 = v1668 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1669 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1660 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1662 = v1669 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1670 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1660 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1662 = v1670 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1671 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1660 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1662 = v1671 
    #endif
#else
    let v1672 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1660 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1662 = v1672 
    #endif
    let v1673 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = _run_target_args'_v1662 
    let v1676 : string = "$0.iter()"
    let v1677 : _ = Fable.Core.RustInterop.emitRustExpr v1673 v1676 
    let v1678 : string = "$0.collect::<Vec<_>>()"
    let v1679 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v1677 v1678 
    let v1680 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v1681 : bool = Fable.Core.RustInterop.emitRustExpr v1679 v1680 
    let v1682 : string = "x"
    let v1683 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1682 
    let v1684 : string = "fable_library_rust::String_::fromString($0)"
    let v1685 : string = Fable.Core.RustInterop.emitRustExpr v1683 v1684 
    let v1686 : string = "true; $0 }).collect::<Vec<_>>()"
    let v1687 : bool = Fable.Core.RustInterop.emitRustExpr v1685 v1686 
    let v1688 : string = "_vec_map"
    let v1689 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v1688 
    let v1690 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v1691 : (string []) = Fable.Core.RustInterop.emitRustExpr v1689 v1690 
    let v1693 : string seq = v1691 |> Seq.ofArray
    let v1698 : string = method137()
    let v1699 : (string -> (string seq -> string)) = String.concat
    let v1700 : (string seq -> string) = v1699 v1698
    let v1701 : string = v1700 v1693
    let v1705 : string = "true; $0 })"
    let v1706 : bool = Fable.Core.RustInterop.emitRustExpr v1701 v1705 
    let v1707 : string = "_optionm_map_"
    let v1708 : string option = Fable.Core.RustInterop.emitRustExpr () v1707 
    let v1715 : US5 =
        match v1640 with
        | US6_1 -> (* None *)
            US5_1
        | US6_0(v1709) -> (* Some *)
            let v1710 : string = "fable_library_rust::String_::fromString($0)"
            let v1711 : string = Fable.Core.RustInterop.emitRustExpr v1709 v1710 
            US5_0(v1711)
    let v1719 : string =
        match v1715 with
        | US5_1 -> (* None *)
            let v1717 : string = ""
            v1717
        | US5_0(v1716) -> (* Some *)
            v1716
    let v1721 : string = v1708 |> Option.defaultValue v1719 
    let v1724 : unit = ()
    let v1725 : (unit -> unit) = closure60(v1639, v1721)
    let v1726 : unit = (fun () -> v1725 (); v1724) ()
    let v1775 : (int32 * string) = v1639, v1721 
    v1775 
    )
    |> fun x -> x ()
    ) () )
    |> fun x -> _capture_v175 <- Some x
    let v1778 : (int32 * string) = match _capture_v175 with Some x -> x | None -> failwith "base.capture / _capture_v175=None"
    let (a, b) = v1778 
    let v3382 : int32 = a
    let v3383 : string = b
    let _run_target_args'_v15 = struct (v3382, v3383) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v3390 : int32, v3391 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v3390, v3391) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v3398 : int32, v3399 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v3398, v3399) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v3406 : int32, v3407 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v3406, v3407) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v3414 : int32, v3415 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v3414, v3415) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v3422 : int32, v3423 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v3422, v3423) 
    #endif
#else
    let v3428 : Async<struct (int32 * string)> = method140(v0, v1, v2, v3, v4, v5, v6)
    (* run_target_args'
    let v3437 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v3440 : int32, v3441 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v3437 = struct (v3440, v3441) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v3448 : int32, v3449 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v3437 = struct (v3448, v3449) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v3456 : int32, v3457 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v3437 = struct (v3456, v3457) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v3464 : int32, v3465 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v3437 = struct (v3464, v3465) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3470 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v3471 : int32, v3472 : string) = v3470 v3428
    let _run_target_args'_v3437 = struct (v3471, v3472) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v3473 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v3474 : int32, v3475 : string) = v3473 v3428
    let _run_target_args'_v3437 = struct (v3474, v3475) 
    #endif
#else
    let v3476 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v3477 : int32, v3478 : string) = v3476 v3428
    let _run_target_args'_v3437 = struct (v3477, v3478) 
    #endif
    let struct (v3479 : int32, v3480 : string) = _run_target_args'_v3437 
    let _run_target_args'_v15 = struct (v3479, v3480) 
    #endif
    let struct (v3485 : int32, v3486 : string) = _run_target_args'_v15 
    struct (v3485, v3486)
and method159 (v0 : string, v1 : string, v2 : string) : struct (string * string) =
    let v3 : string = method47(v1)
    let v4 : string = method28(v2, v3)
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
and method160 () : string =
    let v0 : string = ""
    v0
and closure69 () (v0 : string) : US34 =
    US34_0(v0)
and method161 () : (string -> US34) =
    closure69()
and closure70 () (v0 : std_string_String) : US34 =
    US34_1(v0)
and method162 () : (std_string_String -> US34) =
    closure70()
and method164 (v0 : string, v1 : string, v2 : string, v3 : int32, v4 : string, v5 : int32, v6 : string, v7 : string, v8 : US5, v9 : string, v10 : string) : string =
    let v11 : string = method14()
    let v12 : Mut3 = {l0 = v11} : Mut3
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure8(v12, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v26 : string = "file"
    let v27 : string = $"{v26}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure8(v12, v27)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v37 : string = " = "
    let v38 : string = $"{v37}"
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure8(v12, v38)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v47 : string = $"{v0}"
    let v50 : unit = ()
    let v51 : (unit -> unit) = closure8(v12, v47)
    let v52 : unit = (fun () -> v51 (); v50) ()
    let v57 : string = "; "
    let v58 : string = $"{v57}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure8(v12, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v68 : string = "real_path"
    let v69 : string = $"{v68}"
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure8(v12, v69)
    let v74 : unit = (fun () -> v73 (); v72) ()
    let v78 : string = $"{v37}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure8(v12, v78)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v87 : string = $"{v1}"
    let v90 : unit = ()
    let v91 : (unit -> unit) = closure8(v12, v87)
    let v92 : unit = (fun () -> v91 (); v90) ()
    let v96 : string = $"{v57}"
    let v99 : unit = ()
    let v100 : (unit -> unit) = closure8(v12, v96)
    let v101 : unit = (fun () -> v100 (); v99) ()
    let v106 : string = "relative_path"
    let v107 : string = $"{v106}"
    let v110 : unit = ()
    let v111 : (unit -> unit) = closure8(v12, v107)
    let v112 : unit = (fun () -> v111 (); v110) ()
    let v116 : string = $"{v37}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure8(v12, v116)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v125 : string = $"{v2}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure8(v12, v125)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v134 : string = $"{v57}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure8(v12, v134)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v144 : string = "origin_hash_exit_code"
    let v145 : string = $"{v144}"
    let v148 : unit = ()
    let v149 : (unit -> unit) = closure8(v12, v145)
    let v150 : unit = (fun () -> v149 (); v148) ()
    let v154 : string = $"{v37}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure8(v12, v154)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v163 : string = $"{v3}"
    let v166 : unit = ()
    let v167 : (unit -> unit) = closure8(v12, v163)
    let v168 : unit = (fun () -> v167 (); v166) ()
    let v172 : string = $"{v57}"
    let v175 : unit = ()
    let v176 : (unit -> unit) = closure8(v12, v172)
    let v177 : unit = (fun () -> v176 (); v175) ()
    let v182 : string = "origin_hash"
    let v183 : string = $"{v182}"
    let v186 : unit = ()
    let v187 : (unit -> unit) = closure8(v12, v183)
    let v188 : unit = (fun () -> v187 (); v186) ()
    let v192 : string = $"{v37}"
    let v195 : unit = ()
    let v196 : (unit -> unit) = closure8(v12, v192)
    let v197 : unit = (fun () -> v196 (); v195) ()
    let v201 : string = $"{v4}"
    let v204 : unit = ()
    let v205 : (unit -> unit) = closure8(v12, v201)
    let v206 : unit = (fun () -> v205 (); v204) ()
    let v210 : string = $"{v57}"
    let v213 : unit = ()
    let v214 : (unit -> unit) = closure8(v12, v210)
    let v215 : unit = (fun () -> v214 (); v213) ()
    let v220 : string = "local_git_hash_exit_code"
    let v221 : string = $"{v220}"
    let v224 : unit = ()
    let v225 : (unit -> unit) = closure8(v12, v221)
    let v226 : unit = (fun () -> v225 (); v224) ()
    let v230 : string = $"{v37}"
    let v233 : unit = ()
    let v234 : (unit -> unit) = closure8(v12, v230)
    let v235 : unit = (fun () -> v234 (); v233) ()
    let v239 : string = $"{v5}"
    let v242 : unit = ()
    let v243 : (unit -> unit) = closure8(v12, v239)
    let v244 : unit = (fun () -> v243 (); v242) ()
    let v248 : string = $"{v57}"
    let v251 : unit = ()
    let v252 : (unit -> unit) = closure8(v12, v248)
    let v253 : unit = (fun () -> v252 (); v251) ()
    let v258 : string = "local_git_hash"
    let v259 : string = $"{v258}"
    let v262 : unit = ()
    let v263 : (unit -> unit) = closure8(v12, v259)
    let v264 : unit = (fun () -> v263 (); v262) ()
    let v268 : string = $"{v37}"
    let v271 : unit = ()
    let v272 : (unit -> unit) = closure8(v12, v268)
    let v273 : unit = (fun () -> v272 (); v271) ()
    let v277 : string = $"{v6}"
    let v280 : unit = ()
    let v281 : (unit -> unit) = closure8(v12, v277)
    let v282 : unit = (fun () -> v281 (); v280) ()
    let v286 : string = $"{v57}"
    let v289 : unit = ()
    let v290 : (unit -> unit) = closure8(v12, v286)
    let v291 : unit = (fun () -> v290 (); v289) ()
    let v296 : string = "hash1"
    let v297 : string = $"{v296}"
    let v300 : unit = ()
    let v301 : (unit -> unit) = closure8(v12, v297)
    let v302 : unit = (fun () -> v301 (); v300) ()
    let v306 : string = $"{v37}"
    let v309 : unit = ()
    let v310 : (unit -> unit) = closure8(v12, v306)
    let v311 : unit = (fun () -> v310 (); v309) ()
    let v315 : string = $"{v7}"
    let v318 : unit = ()
    let v319 : (unit -> unit) = closure8(v12, v315)
    let v320 : unit = (fun () -> v319 (); v318) ()
    let v324 : string = $"{v57}"
    let v327 : unit = ()
    let v328 : (unit -> unit) = closure8(v12, v324)
    let v329 : unit = (fun () -> v328 (); v327) ()
    let v334 : string = "hash2"
    let v335 : string = $"{v334}"
    let v338 : unit = ()
    let v339 : (unit -> unit) = closure8(v12, v335)
    let v340 : unit = (fun () -> v339 (); v338) ()
    let v344 : string = $"{v37}"
    let v347 : unit = ()
    let v348 : (unit -> unit) = closure8(v12, v344)
    let v349 : unit = (fun () -> v348 (); v347) ()
    let v353 : string = $"%A{v8}"
    let v357 : string = $"{v353}"
    let v360 : unit = ()
    let v361 : (unit -> unit) = closure8(v12, v357)
    let v362 : unit = (fun () -> v361 (); v360) ()
    let v366 : string = $"{v57}"
    let v369 : unit = ()
    let v370 : (unit -> unit) = closure8(v12, v366)
    let v371 : unit = (fun () -> v370 (); v369) ()
    let v376 : string = "dist_path"
    let v377 : string = $"{v376}"
    let v380 : unit = ()
    let v381 : (unit -> unit) = closure8(v12, v377)
    let v382 : unit = (fun () -> v381 (); v380) ()
    let v386 : string = $"{v37}"
    let v389 : unit = ()
    let v390 : (unit -> unit) = closure8(v12, v386)
    let v391 : unit = (fun () -> v390 (); v389) ()
    let v395 : string = $"{v9}"
    let v398 : unit = ()
    let v399 : (unit -> unit) = closure8(v12, v395)
    let v400 : unit = (fun () -> v399 (); v398) ()
    let v404 : string = $"{v57}"
    let v407 : unit = ()
    let v408 : (unit -> unit) = closure8(v12, v404)
    let v409 : unit = (fun () -> v408 (); v407) ()
    let v414 : string = "cache_path"
    let v415 : string = $"{v414}"
    let v418 : unit = ()
    let v419 : (unit -> unit) = closure8(v12, v415)
    let v420 : unit = (fun () -> v419 (); v418) ()
    let v424 : string = $"{v37}"
    let v427 : unit = ()
    let v428 : (unit -> unit) = closure8(v12, v424)
    let v429 : unit = (fun () -> v428 (); v427) ()
    let v433 : string = $"{v10}"
    let v436 : unit = ()
    let v437 : (unit -> unit) = closure8(v12, v433)
    let v438 : unit = (fun () -> v437 (); v436) ()
    let v443 : string = " }"
    let v444 : string = $"{v443}"
    let v447 : unit = ()
    let v448 : (unit -> unit) = closure8(v12, v444)
    let v449 : unit = (fun () -> v448 (); v447) ()
    let v452 : string = v12.l0
    v452
and method163 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : string, v12 : int32, v13 : string, v14 : int32, v15 : string, v16 : string, v17 : US5, v18 : string, v19 : string) : string =
    let v20 : string = method164(v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19)
    let v21 : int64 = v0.l0
    let v23 : string = $"{v6} {v7} #{v21} %s{v8} / {v20}"
    method18(v23)
and closure71 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : int32, v5 : string, v6 : string, v7 : int32, v8 : string, v9 : string, v10 : US5) () : unit =
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
                method163(v36, v37, v38, v39, v40, v41, v54, v55, v60, v1, v2, v0, v4, v3, v7, v6, v9, v10, v5, v8)
        method19(v64)
and closure72 () (v0 : uint64) : US35 =
    US35_0(v0)
and method166 () : (uint64 -> US35) =
    closure72()
and closure73 () (v0 : std_string_String) : US35 =
    US35_1(v0)
and method167 () : (std_string_String -> US35) =
    closure73()
and method169 (v0 : string, v1 : string, v2 : std_string_String) : string =
    let v3 : string = method14()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v11 : unit = ()
    let v12 : (unit -> unit) = closure8(v4, v8)
    let v13 : unit = (fun () -> v12 (); v11) ()
    let v18 : string = "old_path"
    let v19 : string = $"{v18}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure8(v4, v19)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v29 : string = " = "
    let v30 : string = $"{v29}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure8(v4, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v39 : string = $"{v0}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure8(v4, v39)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v49 : string = "; "
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure8(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v60 : string = "new_path"
    let v61 : string = $"{v60}"
    let v64 : unit = ()
    let v65 : (unit -> unit) = closure8(v4, v61)
    let v66 : unit = (fun () -> v65 (); v64) ()
    let v70 : string = $"{v29}"
    let v73 : unit = ()
    let v74 : (unit -> unit) = closure8(v4, v70)
    let v75 : unit = (fun () -> v74 (); v73) ()
    let v79 : string = $"{v1}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure8(v4, v79)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v88 : string = $"{v49}"
    let v91 : unit = ()
    let v92 : (unit -> unit) = closure8(v4, v88)
    let v93 : unit = (fun () -> v92 (); v91) ()
    let v98 : string = "error"
    let v99 : string = $"{v98}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure8(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v108 : string = $"{v29}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure8(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    (* run_target_args'
    let v120 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v121 : string = "format!(\"{:#?}\", $0)"
    let v122 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v121 
    let v123 : string = "fable_library_rust::String_::fromString($0)"
    let v124 : string = Fable.Core.RustInterop.emitRustExpr v122 v123 
    let _run_target_args'_v120 = v124 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v125 : string = "format!(\"{:#?}\", $0)"
    let v126 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v125 
    let v127 : string = "fable_library_rust::String_::fromString($0)"
    let v128 : string = Fable.Core.RustInterop.emitRustExpr v126 v127 
    let _run_target_args'_v120 = v128 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v129 : string = "format!(\"{:#?}\", $0)"
    let v130 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v129 
    let v131 : string = "fable_library_rust::String_::fromString($0)"
    let v132 : string = Fable.Core.RustInterop.emitRustExpr v130 v131 
    let _run_target_args'_v120 = v132 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v134 : string = $"%A{v2}"
    let _run_target_args'_v120 = v134 
    #endif
#if FABLE_COMPILER_PYTHON
    let v138 : string = $"%A{v2}"
    let _run_target_args'_v120 = v138 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v142 : string = $"%A{v2}"
    let _run_target_args'_v120 = v142 
    #endif
#else
    let v146 : string = $"%A{v2}"
    let _run_target_args'_v120 = v146 
    #endif
    let v149 : string = _run_target_args'_v120 
    let v156 : string = $"{v149}"
    let v159 : unit = ()
    let v160 : (unit -> unit) = closure8(v4, v156)
    let v161 : unit = (fun () -> v160 (); v159) ()
    let v166 : string = " }"
    let v167 : string = $"{v166}"
    let v170 : unit = ()
    let v171 : (unit -> unit) = closure8(v4, v167)
    let v172 : unit = (fun () -> v171 (); v170) ()
    let v175 : string = v4.l0
    v175
and method168 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : std_string_String) : string =
    let v11 : string = method169(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v14 : string = "file_system.file_copy"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method18(v15)
and closure74 (v0 : string, v1 : string, v2 : std_string_String) () : unit =
    let v3 : US0 = US0_3
    let v4 : bool = method7(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut0, v29 : Mut1, v30 : Mut2, v31 : Mut3, v32 : Mut4, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method8(v28, v29, v30, v31, v32, v33)
        let v47 : string = method35()
        let v48 : string = method168(v28, v29, v30, v31, v32, v33, v46, v47, v1, v0, v2)
        method19(v48)
and method171 (v0 : string, v1 : string, v2 : uint64) : string =
    let v3 : string = method14()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v11 : unit = ()
    let v12 : (unit -> unit) = closure8(v4, v8)
    let v13 : unit = (fun () -> v12 (); v11) ()
    let v18 : string = "old_path"
    let v19 : string = $"{v18}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure8(v4, v19)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v29 : string = " = "
    let v30 : string = $"{v29}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure8(v4, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v39 : string = $"{v0}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure8(v4, v39)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v49 : string = "; "
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure8(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v60 : string = "new_path"
    let v61 : string = $"{v60}"
    let v64 : unit = ()
    let v65 : (unit -> unit) = closure8(v4, v61)
    let v66 : unit = (fun () -> v65 (); v64) ()
    let v70 : string = $"{v29}"
    let v73 : unit = ()
    let v74 : (unit -> unit) = closure8(v4, v70)
    let v75 : unit = (fun () -> v74 (); v73) ()
    let v79 : string = $"{v1}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure8(v4, v79)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v88 : string = $"{v49}"
    let v91 : unit = ()
    let v92 : (unit -> unit) = closure8(v4, v88)
    let v93 : unit = (fun () -> v92 (); v91) ()
    let v98 : string = "result"
    let v99 : string = $"{v98}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure8(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v108 : string = $"{v29}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure8(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v117 : string = $"{v2}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure8(v4, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v127 : string = " }"
    let v128 : string = $"{v127}"
    let v131 : unit = ()
    let v132 : (unit -> unit) = closure8(v4, v128)
    let v133 : unit = (fun () -> v132 (); v131) ()
    let v136 : string = v4.l0
    v136
and method170 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : uint64) : string =
    let v11 : string = method171(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v14 : string = "file_system.file_copy"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method18(v15)
and closure75 (v0 : string, v1 : string, v2 : uint64) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method7(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut0, v29 : Mut1, v30 : Mut2, v31 : Mut3, v32 : Mut4, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method8(v28, v29, v30, v31, v32, v33)
        let v47 : string = method66()
        let v48 : string = method170(v28, v29, v30, v31, v32, v33, v46, v47, v1, v0, v2)
        method19(v48)
and method165 (v0 : string, v1 : string) : unit =
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
    let v21 : (uint64 -> US35) = method166()
    let v22 : (std_string_String -> US35) = method167()
    let v24 : US35 = match v18 with Ok x -> v21 x | Error x -> v22 x
    match v24 with
    | US35_1(v77) -> (* Error *)
        let v78 : unit = ()
        let v79 : (unit -> unit) = closure74(v0, v1, v77)
        let v80 : unit = (fun () -> v79 (); v78) ()
        ()
    | US35_0(v27) -> (* Ok *)
        let v28 : unit = ()
        let v29 : (unit -> unit) = closure75(v0, v1, v27)
        let v30 : unit = (fun () -> v29 (); v28) ()
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
and method173 (v0 : Vec<uint8>) : Vec<uint8> =
    v0
and method174 (v0 : int32, v1 : Mut7) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method175 (v0 : string) : string =
    v0
and method176 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
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
    let v21 : string = method175(v0)
    let v22 : string = "v21.as_bytes()"
    let v23 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : std_sync_MutexGuard<std_process_ChildStdin> = method176(v18)
    let v25 : string = "true; let mut v24 = v24"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr () v25 
    let v27 : string = "true; std::io::Write::write_all(&mut *$0, v23).unwrap()"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v24 v27 
    ()
and method177 (v0 : int32, v1 : Mut8) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method179 (v0 : int32, v1 : int32, v2 : string) : string =
    let v3 : string = method14()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v11 : unit = ()
    let v12 : (unit -> unit) = closure8(v4, v8)
    let v13 : unit = (fun () -> v12 (); v11) ()
    let v18 : string = "exit_code"
    let v19 : string = $"{v18}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure8(v4, v19)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v29 : string = " = "
    let v30 : string = $"{v29}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure8(v4, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v39 : string = $"{v0}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure8(v4, v39)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v49 : string = "; "
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure8(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v60 : string = "result_len"
    let v61 : string = $"{v60}"
    let v64 : unit = ()
    let v65 : (unit -> unit) = closure8(v4, v61)
    let v66 : unit = (fun () -> v65 (); v64) ()
    let v70 : string = $"{v29}"
    let v73 : unit = ()
    let v74 : (unit -> unit) = closure8(v4, v70)
    let v75 : unit = (fun () -> v74 (); v73) ()
    let v79 : string = $"{v1}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure8(v4, v79)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v88 : string = $"{v49}"
    let v91 : unit = ()
    let v92 : (unit -> unit) = closure8(v4, v88)
    let v93 : unit = (fun () -> v92 (); v91) ()
    let v98 : string = "output_path"
    let v99 : string = $"{v98}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure8(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v108 : string = $"{v29}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure8(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v117 : string = $"{v2}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure8(v4, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v127 : string = " }"
    let v128 : string = $"{v127}"
    let v131 : unit = ()
    let v132 : (unit -> unit) = closure8(v4, v128)
    let v133 : unit = (fun () -> v132 (); v131) ()
    let v136 : string = v4.l0
    v136
and method178 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32, v10 : string) : string =
    let v11 : string = method179(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v14 : string = "documents.hangul"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method18(v15)
and closure79 (v0 : string, v1 : int32, v2 : string) () : unit =
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
        let v49 : string = method178(v28, v29, v30, v31, v32, v33, v46, v47, v1, v48, v0)
        method19(v49)
and method172 (v0 : string, v1 : string, v2 : string, v3 : string) : US36 =
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
    let v60 : Vec<uint8> = method173(v54)
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
    while method63(v118, v120) do
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
    while method174(v130, v132) do
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
    while method63(v146, v148) do
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
    let v167 : string = method137()
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
    let v195 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v196 : string = "cfg!(windows)"
    let v197 : bool = Fable.Core.RustInterop.emitRustExpr () v196 
    let _run_target_args'_v195 = v197 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v198 : string = "cfg!(windows)"
    let v199 : bool = Fable.Core.RustInterop.emitRustExpr () v198 
    let _run_target_args'_v195 = v199 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v200 : string = "cfg!(windows)"
    let v201 : bool = Fable.Core.RustInterop.emitRustExpr () v200 
    let _run_target_args'_v195 = v201 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v202 : US3 = US3_0
    let v203 : US4 = US4_4(v202)
    let v204 : string = $"platform.is_windows / target: {v203}"
    let v205 : bool = failwith<bool> v204
    let _run_target_args'_v195 = v205 
    #endif
#if FABLE_COMPILER_PYTHON
    let v206 : US3 = US3_0
    let v207 : US4 = US4_5(v206)
    let v208 : string = $"platform.is_windows / target: {v207}"
    let v209 : bool = failwith<bool> v208
    let _run_target_args'_v195 = v209 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v210 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v211 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v212 : bool = v211 v210
    let _run_target_args'_v195 = v212 
    #endif
#else
    let v213 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v214 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v215 : bool = v214 v213
    let _run_target_args'_v195 = v215 
    #endif
    let v216 : bool = _run_target_args'_v195 
    let v224 : string =
        if v216 then
            let v222 : string = ".exe"
            v222
        else
            let v223 : string = ""
            v223
    let v225 : string = $"../alphabet/deps/hangulize/cmd/hangulize/hangulize{v224}"
    let v226 : string = method28(v0, v225)
    let v227 : string = $"{v226} {v1}"
    let v230 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) = closure78(v173)
    let v231 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = Some v230 
    let v234 : bool = true
    let struct (v235 : int32, v236 : string) = method83(v227, v175, v178, v180, v231, v234, v188)
    let v243 : (string []) = v236.Split v114 
    let v246 : int32 = v243.Length
    let v247 : string = ""
    let v248 : Mut8 = {l0 = 0; l1 = v247; l2 = 0; l3 = 0} : Mut8
    while method177(v130, v248) do
        let v250 : int32 = v248.l0
        let struct (v251 : string, v252 : int32, v253 : int32) = v248.l1, v248.l2, v248.l3
        let v254 : string = v119.[int v250]
        let v255 : bool = v254 = ""
        let struct (v279 : string, v280 : int32, v281 : int32) =
            if v255 then
                let v256 : string = $"{v251}
"
                let v257 : int32 = v252 + 1
                let v258 : int32 = v253 + 1
                struct (v256, v257, v258)
            else
                let v259 : int32 = v252 - v253
                let v260 : bool = v259 >= v246
                let v277 : string =
                    if v260 then
                        v251
                    else
                        let v262 : string = v243.[int v259]
                        let v267 : string = "://"
                        let v268 : bool = v262.Contains v267 
                        let v271 : string =
                            if v268 then
                                v254
                            else
                                v262
                        let v272 : int32 = v246 - 1
                        let v273 : bool = v259 = v272
                        if v273 then
                            let v274 : string = $"{v251}{v271}"
                            v274
                        else
                            let v275 : string = $"{v251}{v271}
"
                            v275
                let v278 : int32 = v252 + 1
                struct (v277, v278, v253)
        let v282 : int32 = v250 + 1
        v248.l0 <- v282
        v248.l1 <- v279
        v248.l2 <- v280
        v248.l3 <- v281
        ()
    let struct (v283 : string, v284 : int32, v285 : int32) = v248.l1, v248.l2, v248.l3
    (* run_target_args'
    let v286 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v287 : string = "std::fs::write(&*$0, &*$1).unwrap()"
    Fable.Core.RustInterop.emitRustExpr struct (v2, v283) v287 
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
    System.IO.File.WriteAllText (v2, v283)
    #endif
    // run_target_args' is_unit
    let v288 : unit = ()
    let v289 : (unit -> unit) = closure79(v2, v235, v283)
    let v290 : unit = (fun () -> v289 (); v288) ()
    US36_0(v235, v283)
and method181 (v0 : int32, v1 : string) : string =
    let v2 : string = method14()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure8(v3, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v17 : string = "exit_code"
    let v18 : string = $"{v17}"
    let v21 : unit = ()
    let v22 : (unit -> unit) = closure8(v3, v18)
    let v23 : unit = (fun () -> v22 (); v21) ()
    let v28 : string = " = "
    let v29 : string = $"{v28}"
    let v32 : unit = ()
    let v33 : (unit -> unit) = closure8(v3, v29)
    let v34 : unit = (fun () -> v33 (); v32) ()
    let v38 : string = $"{v0}"
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure8(v3, v38)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v48 : string = "; "
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure8(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v59 : string = "result"
    let v60 : string = $"{v59}"
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure8(v3, v60)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v69 : string = $"{v28}"
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure8(v3, v69)
    let v74 : unit = (fun () -> v73 (); v72) ()
    let v78 : string = $"{v1}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure8(v3, v78)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v88 : string = " }"
    let v89 : string = $"{v88}"
    let v92 : unit = ()
    let v93 : (unit -> unit) = closure8(v3, v89)
    let v94 : unit = (fun () -> v93 (); v92) ()
    let v97 : string = v3.l0
    v97
and method180 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method181(v8, v9)
    let v11 : int64 = v0.l0
    let v13 : string = "documents.files_fn / error"
    let v14 : string = $"{v6} {v7} #{v11} %s{v13} / {v10}"
    method18(v14)
and closure80 (v0 : string, v1 : int32) () : unit =
    let v2 : US0 = US0_2
    let v3 : bool = method7(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method8(v27, v28, v29, v30, v31, v32)
        let v46 : string = method12()
        let v47 : string = method180(v27, v28, v29, v30, v31, v32, v45, v46, v1, v0)
        method19(v47)
and closure77 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) (v5 : string) : US33 =
    let struct (v6 : string, v7 : string) = method159(v5, v4, v0)
    let v8 : bool = method30(v6)
    let v9 : bool = v8 = false
    let v12 : bool =
        if v9 then
            true
        else
            let v10 : bool = method30(v7)
            let v11 : bool = v10 = false
            v11
    let v346 : bool =
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
            let v136 : string = method160()
            let v138 : bool = v136 = "\n"
            let v140 : string =
                if v138 then
                    method65(v136)
                else
                    v136
            let v141 : (string -> (string seq -> string)) = String.concat
            let v142 : (string seq -> string) = v141 v140
            let v143 : string = v142 v130
            let v147 : Result<string, std_io_Error> = Ok v143 
            let v150 : (std_io_Error -> std_string_String) = method69()
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
            let v166 : (string -> US34) = method161()
            let v167 : (std_string_String -> US34) = method162()
            let v168 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v169 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v166, v167, v163) v168 
            let v178 : string =
                match v169 with
                | US34_1(v171) -> (* Error *)
                    let v173 : string = $"resultm.get / Result value was Error: {v171}"
                    failwith<string> v173
                | US34_0(v170) -> (* Ok *)
                    v170
            let v179 : string = method38(v7)
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
            let v302 : string = method160()
            let v304 : bool = v302 = "\n"
            let v306 : string =
                if v304 then
                    method65(v302)
                else
                    v302
            let v307 : (string -> (string seq -> string)) = String.concat
            let v308 : (string seq -> string) = v307 v306
            let v309 : string = v308 v296
            let v313 : Result<string, std_io_Error> = Ok v309 
            let v316 : (std_io_Error -> std_string_String) = method69()
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
            let v332 : (string -> US34) = method161()
            let v333 : (std_string_String -> US34) = method162()
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
        let v348 : US36 = method172(v2, v3, v6, v4)
        match v348 with
        | US36_1(v421, v422) -> (* Error *)
            let v424 : (string * string) = v6, v422 
            let v428 : Result<string, (string * string)> = Error v424 
            US33_0(v428)
        | US36_0(v349, v350) -> (* Ok *)
            let v352 : bool = v349 <> 0 
            if v352 then
                let v355 : unit = ()
                let v356 : (unit -> unit) = closure80(v350, v349)
                let v357 : unit = (fun () -> v356 (); v355) ()
                let v405 : (string * string) = v6, v350 
                let v409 : Result<string, (string * string)> = Error v405 
                US33_0(v409)
            else
                let v413 : bool = method30(v6)
                if v413 then
                    method165(v7, v6)
                else
                    let v414 : string = $"documents.files_fn / {v6} should exist"
                    failwith<unit> v414
                let v416 : Result<string, (string * string)> = Ok v6 
                US33_0(v416)
and closure76 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : string) : (string -> US33) =
    closure77(v0, v1, v2, v3, v4)
and method184 (v0 : int32, v1 : string, v2 : string) : string =
    let v3 : string = method14()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v11 : unit = ()
    let v12 : (unit -> unit) = closure8(v4, v8)
    let v13 : unit = (fun () -> v12 (); v11) ()
    let v18 : string = "exit_code"
    let v19 : string = $"{v18}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure8(v4, v19)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v29 : string = " = "
    let v30 : string = $"{v29}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure8(v4, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v39 : string = $"{v0}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure8(v4, v39)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v49 : string = "; "
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure8(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v60 : string = "output_path"
    let v61 : string = $"{v60}"
    let v64 : unit = ()
    let v65 : (unit -> unit) = closure8(v4, v61)
    let v66 : unit = (fun () -> v65 (); v64) ()
    let v70 : string = $"{v29}"
    let v73 : unit = ()
    let v74 : (unit -> unit) = closure8(v4, v70)
    let v75 : unit = (fun () -> v74 (); v73) ()
    let v79 : string = $"{v1}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure8(v4, v79)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v88 : string = $"{v49}"
    let v91 : unit = ()
    let v92 : (unit -> unit) = closure8(v4, v88)
    let v93 : unit = (fun () -> v92 (); v91) ()
    let v98 : string = "result"
    let v99 : string = $"{v98}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure8(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v108 : string = $"{v29}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure8(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v117 : string = $"{v2}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure8(v4, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v127 : string = " }"
    let v128 : string = $"{v127}"
    let v131 : unit = ()
    let v132 : (unit -> unit) = closure8(v4, v128)
    let v133 : unit = (fun () -> v132 (); v131) ()
    let v136 : string = v4.l0
    v136
and method183 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string, v10 : string) : string =
    let v11 : string = method184(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v14 : string = "documents.crowbook / result contains ERROR"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method18(v15)
and closure83 (v0 : string, v1 : string, v2 : int32) () : unit =
    let v3 : US0 = US0_3
    let v4 : bool = method7(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut0, v29 : Mut1, v30 : Mut2, v31 : Mut3, v32 : Mut4, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method8(v28, v29, v30, v31, v32, v33)
        let v47 : string = method35()
        let v48 : string = method183(v28, v29, v30, v31, v32, v33, v46, v47, v2, v0, v1)
        method19(v48)
and method182 (v0 : bool, v1 : string, v2 : string, v3 : string, v4 : string) : US36 =
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
    let struct (v87 : int32, v88 : string) = method83(v81, v63, v66, v68, v72, v86, v83)
    let v91 : string = "ERROR"
    let v92 : bool = v88.Contains v91 
    let v95 : bool = v92 = false
    if v95 then
        US36_0(v87, v88)
    else
        let v97 : unit = ()
        let v98 : (unit -> unit) = closure83(v1, v88, v87)
        let v99 : unit = (fun () -> v98 (); v97) ()
        US36_1(v87, v88)
and closure82 (v0 : string, v1 : string, v2 : bool, v3 : string) (v4 : string) : US33 =
    let struct (v5 : string, v6 : string) = method159(v4, v3, v0)
    let v7 : bool = method30(v5)
    let v8 : bool = v7 = false
    let v11 : bool =
        if v8 then
            true
        else
            let v9 : bool = method30(v6)
            let v10 : bool = v9 = false
            v10
    let v345 : bool =
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
            let v135 : string = method160()
            let v137 : bool = v135 = "\n"
            let v139 : string =
                if v137 then
                    method65(v135)
                else
                    v135
            let v140 : (string -> (string seq -> string)) = String.concat
            let v141 : (string seq -> string) = v140 v139
            let v142 : string = v141 v129
            let v146 : Result<string, std_io_Error> = Ok v142 
            let v149 : (std_io_Error -> std_string_String) = method69()
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
            let v165 : (string -> US34) = method161()
            let v166 : (std_string_String -> US34) = method162()
            let v167 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v168 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v165, v166, v162) v167 
            let v177 : string =
                match v168 with
                | US34_1(v170) -> (* Error *)
                    let v172 : string = $"resultm.get / Result value was Error: {v170}"
                    failwith<string> v172
                | US34_0(v169) -> (* Ok *)
                    v169
            let v178 : string = method38(v6)
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
            let v301 : string = method160()
            let v303 : bool = v301 = "\n"
            let v305 : string =
                if v303 then
                    method65(v301)
                else
                    v301
            let v306 : (string -> (string seq -> string)) = String.concat
            let v307 : (string seq -> string) = v306 v305
            let v308 : string = v307 v295
            let v312 : Result<string, std_io_Error> = Ok v308 
            let v315 : (std_io_Error -> std_string_String) = method69()
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
            let v331 : (string -> US34) = method161()
            let v332 : (std_string_String -> US34) = method162()
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
        let v347 : US36 = method182(v2, v5, v3, v1, v4)
        match v347 with
        | US36_1(v420, v421) -> (* Error *)
            let v423 : (string * string) = v5, v421 
            let v427 : Result<string, (string * string)> = Error v423 
            US33_0(v427)
        | US36_0(v348, v349) -> (* Ok *)
            let v351 : bool = v348 <> 0 
            if v351 then
                let v354 : unit = ()
                let v355 : (unit -> unit) = closure80(v349, v348)
                let v356 : unit = (fun () -> v355 (); v354) ()
                let v404 : (string * string) = v5, v349 
                let v408 : Result<string, (string * string)> = Error v404 
                US33_0(v408)
            else
                let v412 : bool = method30(v5)
                if v412 then
                    method165(v6, v5)
                else
                    let v413 : string = $"documents.files_fn / {v5} should exist"
                    failwith<unit> v413
                let v415 : Result<string, (string * string)> = Ok v5 
                US33_0(v415)
and closure81 (v0 : string, v1 : string, v2 : bool) (v3 : string) : (string -> US33) =
    closure82(v0, v1, v2, v3)
and method186 (v0 : string, v1 : string) : string =
    let v2 : string = method14()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure8(v3, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v17 : string = "output_path"
    let v18 : string = $"{v17}"
    let v21 : unit = ()
    let v22 : (unit -> unit) = closure8(v3, v18)
    let v23 : unit = (fun () -> v22 (); v21) ()
    let v28 : string = " = "
    let v29 : string = $"{v28}"
    let v32 : unit = ()
    let v33 : (unit -> unit) = closure8(v3, v29)
    let v34 : unit = (fun () -> v33 (); v32) ()
    let v38 : string = $"{v0}"
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure8(v3, v38)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v48 : string = "; "
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure8(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v59 : string = "output_cache_path"
    let v60 : string = $"{v59}"
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure8(v3, v60)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v69 : string = $"{v28}"
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure8(v3, v69)
    let v74 : unit = (fun () -> v73 (); v72) ()
    let v78 : string = $"{v1}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure8(v3, v78)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v88 : string = " }"
    let v89 : string = $"{v88}"
    let v92 : unit = ()
    let v93 : (unit -> unit) = closure8(v3, v89)
    let v94 : unit = (fun () -> v93 (); v92) ()
    let v97 : string = v3.l0
    v97
and method185 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string) : string =
    let v10 : string = method186(v8, v9)
    let v11 : int64 = v0.l0
    let v13 : string = "documents.run / par_map / files' = [] / listm.iter"
    let v14 : string = $"{v6} {v7} #{v11} %s{v13} / {v10}"
    method18(v14)
and closure84 (v0 : string, v1 : string) () : unit =
    let v2 : US0 = US0_2
    let v3 : bool = method7(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method8(v27, v28, v29, v30, v31, v32)
        let v46 : string = method12()
        let v47 : string = method185(v27, v28, v29, v30, v31, v32, v45, v46, v1, v0)
        method19(v47)
and method187 (v0 : UH4, v1 : UH5 list) : UH5 list =
    match v0 with
    | UH4_1(v2, v3) -> (* Cons *)
        let v4 : UH5 list = method187(v3, v1)
        let v6 : UH5 list = v2 :: v4 
        v6
    | UH4_0 -> (* Nil *)
        v1
and closure86 (v0 : UH5) (v1 : UH4) : UH4 =
    UH4_1(v0, v1)
and closure85 () (v0 : UH5) : (UH4 -> UH4) =
    closure86(v0)
and method188 () : (UH5 -> (UH4 -> UH4)) =
    closure85()
and method190 (v0 : UH5, v1 : struct (string * string * (string -> (string -> US33))) list) : struct (string * string * (string -> (string -> US33))) list =
    match v0 with
    | UH5_1(v2, v3, v4, v5) -> (* Cons *)
        let v6 : struct (string * string * (string -> (string -> US33))) list = method190(v5, v1)
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
and method191 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and method192 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and method189 (v0 : UH4, v1 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    match v0 with
    | UH4_1(v2, v3) -> (* Cons *)
        let v4 : struct (string * string * (string -> (string -> US33))) list = []
        let v5 : struct (string * string * (string -> (string -> US33))) list = method190(v2, v4)
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
        let v20 : Vec<Result<string, (string * string)> option> = method191(v19)
        let v21 : Vec<Result<string, (string * string)> option> = method192(v1)
        let v22 : string = "true; let mut v21 = v21"
        let v23 : bool = Fable.Core.RustInterop.emitRustExpr () v22 
        let v24 : string = "true; v21.extend(v20)"
        let v25 : bool = Fable.Core.RustInterop.emitRustExpr () v24 
        let v26 : string = "v21"
        let v27 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr () v26 
        method189(v3, v27)
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
    let v184 : System.Threading.CancellationToken option = None
    let v187 : (struct (string * string) []) = [||]
    let v189 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v193 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v197 : string option = None
    let v200 : string = $"git ls-tree --format='%%(objectname)' origin/gh-pages \"{v182}\""
    let v202 : string option = Some v2 
    let v205 : bool = true
    let struct (v206 : int32, v207 : string) = method83(v200, v184, v187, v189, v193, v205, v202)
    let v208 : string = method28(v3, v179)
    let v209 : string = method82(v208)
    let v211 : System.Threading.CancellationToken option = None
    let v214 : (struct (string * string) []) = [||]
    let v216 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v220 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v224 : string option = None
    let v227 : string = $"git hash-object \"{v209}\""
    let v229 : string option = Some v3 
    let v232 : bool = true
    let struct (v233 : int32, v234 : string) = method83(v227, v211, v214, v216, v220, v232, v229)
    let v235 : string = method28(v4, v179)
    let v236 : string = method82(v235)
    let v237 : string = "hangul.md"
    let struct (v238 : string, v239 : string) = method159(v237, v209, v4)
    let v240 : bool = false
    let v241 : bool = false
    let v242 : bool = false
    let v243 : bool = true
    let v244 : bool = true
    let v245 : bool = true
    let v247 : bool = v207.Contains v234 
    let v747 : UH4 =
        if v247 then
            UH4_0
        else
            let v251 : string = method38(v209)
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
            let v374 : string = method160()
            let v376 : bool = v374 = "\n"
            let v378 : string =
                if v376 then
                    method65(v374)
                else
                    v374
            let v379 : (string -> (string seq -> string)) = String.concat
            let v380 : (string seq -> string) = v379 v378
            let v381 : string = v380 v368
            let v385 : Result<string, std_io_Error> = Ok v381 
            let v388 : (std_io_Error -> std_string_String) = method69()
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
            let v404 : (string -> US34) = method161()
            let v405 : (std_string_String -> US34) = method162()
            let v406 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v407 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v404, v405, v401) v406 
            let v416 : string =
                match v407 with
                | US34_1(v409) -> (* Error *)
                    let v411 : string = $"resultm.get / Result value was Error: {v409}"
                    failwith<string> v411
                | US34_0(v408) -> (* Ok *)
                    v408
            let v417 : bool = method30(v236)
            let v418 : bool = v417 = false
            let v583 : US5 =
                if v418 then
                    US5_1
                else
                    let v420 : string = method38(v236)
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
                    let v543 : string = method160()
                    let v545 : bool = v543 = "\n"
                    let v547 : string =
                        if v545 then
                            method65(v543)
                        else
                            v543
                    let v548 : (string -> (string seq -> string)) = String.concat
                    let v549 : (string seq -> string) = v548 v547
                    let v550 : string = v549 v537
                    let v554 : Result<string, std_io_Error> = Ok v550 
                    let v557 : (std_io_Error -> std_string_String) = method69()
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
                    let v573 : (string -> US34) = method161()
                    let v574 : (std_string_String -> US34) = method162()
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
                    let v587 : unit = ()
                    let v588 : (unit -> unit) = closure71(v179, v180, v182, v207, v206, v209, v234, v233, v236, v416, v583)
                    let v589 : unit = (fun () -> v588 (); v587) ()
                    method165(v236, v209)
                    let v644 : (string -> (string -> US33)) = closure76(v4, v3, v1, v0)
                    let v645 : UH5 = UH5_0
                    let v646 : UH5 = UH5_1(v237, v209, v644, v645)
                    let v647 : string = "html"
                    let v648 : (string -> (string -> US33)) = closure81(v4, v3, v240)
                    let v649 : string = "pdf"
                    let v650 : (string -> (string -> US33)) = closure81(v4, v3, v241)
                    let v651 : string = "epub"
                    let v652 : (string -> (string -> US33)) = closure81(v4, v3, v242)
                    let v653 : (string -> (string -> US33)) = closure81(v4, v3, v243)
                    let v654 : (string -> (string -> US33)) = closure81(v4, v3, v244)
                    let v655 : (string -> (string -> US33)) = closure81(v4, v3, v245)
                    let v656 : UH5 = UH5_0
                    let v657 : UH5 = UH5_1(v651, v238, v655, v656)
                    let v658 : UH5 = UH5_1(v649, v238, v654, v657)
                    let v659 : UH5 = UH5_1(v647, v238, v653, v658)
                    let v660 : UH5 = UH5_1(v651, v209, v652, v659)
                    let v661 : UH5 = UH5_1(v649, v209, v650, v660)
                    let v662 : UH5 = UH5_1(v647, v209, v648, v661)
                    let v663 : UH4 = UH4_0
                    let v664 : UH4 = UH4_1(v662, v663)
                    UH4_1(v646, v664)
            | _ ->
                let v667 : unit = ()
                let v668 : (unit -> unit) = closure71(v179, v180, v182, v207, v206, v209, v234, v233, v236, v416, v583)
                let v669 : unit = (fun () -> v668 (); v667) ()
                method165(v236, v209)
                let v724 : (string -> (string -> US33)) = closure76(v4, v3, v1, v0)
                let v725 : UH5 = UH5_0
                let v726 : UH5 = UH5_1(v237, v209, v724, v725)
                let v727 : string = "html"
                let v728 : (string -> (string -> US33)) = closure81(v4, v3, v240)
                let v729 : string = "pdf"
                let v730 : (string -> (string -> US33)) = closure81(v4, v3, v241)
                let v731 : string = "epub"
                let v732 : (string -> (string -> US33)) = closure81(v4, v3, v242)
                let v733 : (string -> (string -> US33)) = closure81(v4, v3, v243)
                let v734 : (string -> (string -> US33)) = closure81(v4, v3, v244)
                let v735 : (string -> (string -> US33)) = closure81(v4, v3, v245)
                let v736 : UH5 = UH5_0
                let v737 : UH5 = UH5_1(v731, v238, v735, v736)
                let v738 : UH5 = UH5_1(v729, v238, v734, v737)
                let v739 : UH5 = UH5_1(v727, v238, v733, v738)
                let v740 : UH5 = UH5_1(v731, v209, v732, v739)
                let v741 : UH5 = UH5_1(v729, v209, v730, v740)
                let v742 : UH5 = UH5_1(v727, v209, v728, v741)
                let v743 : UH4 = UH4_0
                let v744 : UH4 = UH4_1(v742, v743)
                UH4_1(v726, v744)
    let v748 : bool =
        match v747 with
        | UH4_0 -> (* Nil *)
            true
        | _ ->
            false
    let v749 : bool = v748 <> true
    let v1173 : UH4 =
        if v749 then
            v747
        else
            let v750 : string = "epub"
            let struct (v751 : string, v752 : string) = method159(v750, v238, v4)
            let v753 : bool = method30(v751)
            let v806 : bool =
                if v753 then
                    true
                else
                    let v754 : bool = method30(v752)
                    let v755 : bool = v754 = false
                    if v755 then
                        true
                    else
                        let v756 : unit = ()
                        let v757 : (unit -> unit) = closure84(v752, v751)
                        let v758 : unit = (fun () -> v757 (); v756) ()
                        method165(v751, v752)
                        false
            let v811 : UH5 =
                if v806 then
                    let v807 : (string -> (string -> US33)) = closure81(v4, v3, v245)
                    let v808 : UH5 = UH5_0
                    UH5_1(v750, v238, v807, v808)
                else
                    UH5_0
            let v812 : string = "pdf"
            let struct (v813 : string, v814 : string) = method159(v812, v238, v4)
            let v815 : bool = method30(v813)
            let v868 : bool =
                if v815 then
                    true
                else
                    let v816 : bool = method30(v814)
                    let v817 : bool = v816 = false
                    if v817 then
                        true
                    else
                        let v818 : unit = ()
                        let v819 : (unit -> unit) = closure84(v814, v813)
                        let v820 : unit = (fun () -> v819 (); v818) ()
                        method165(v813, v814)
                        false
            let v871 : UH5 =
                if v868 then
                    let v869 : (string -> (string -> US33)) = closure81(v4, v3, v244)
                    UH5_1(v812, v238, v869, v811)
                else
                    v811
            let v872 : string = "html"
            let struct (v873 : string, v874 : string) = method159(v872, v238, v4)
            let v875 : bool = method30(v873)
            let v928 : bool =
                if v875 then
                    true
                else
                    let v876 : bool = method30(v874)
                    let v877 : bool = v876 = false
                    if v877 then
                        true
                    else
                        let v878 : unit = ()
                        let v879 : (unit -> unit) = closure84(v874, v873)
                        let v880 : unit = (fun () -> v879 (); v878) ()
                        method165(v873, v874)
                        false
            let v931 : UH5 =
                if v928 then
                    let v929 : (string -> (string -> US33)) = closure81(v4, v3, v243)
                    UH5_1(v872, v238, v929, v871)
                else
                    v871
            let struct (v932 : string, v933 : string) = method159(v750, v209, v4)
            let v934 : bool = method30(v932)
            let v987 : bool =
                if v934 then
                    true
                else
                    let v935 : bool = method30(v933)
                    let v936 : bool = v935 = false
                    if v936 then
                        true
                    else
                        let v937 : unit = ()
                        let v938 : (unit -> unit) = closure84(v933, v932)
                        let v939 : unit = (fun () -> v938 (); v937) ()
                        method165(v932, v933)
                        false
            let v990 : UH5 =
                if v987 then
                    let v988 : (string -> (string -> US33)) = closure81(v4, v3, v242)
                    UH5_1(v750, v209, v988, v931)
                else
                    v931
            let struct (v991 : string, v992 : string) = method159(v812, v209, v4)
            let v993 : bool = method30(v991)
            let v1046 : bool =
                if v993 then
                    true
                else
                    let v994 : bool = method30(v992)
                    let v995 : bool = v994 = false
                    if v995 then
                        true
                    else
                        let v996 : unit = ()
                        let v997 : (unit -> unit) = closure84(v992, v991)
                        let v998 : unit = (fun () -> v997 (); v996) ()
                        method165(v991, v992)
                        false
            let v1049 : UH5 =
                if v1046 then
                    let v1047 : (string -> (string -> US33)) = closure81(v4, v3, v241)
                    UH5_1(v812, v209, v1047, v990)
                else
                    v990
            let struct (v1050 : string, v1051 : string) = method159(v872, v209, v4)
            let v1052 : bool = method30(v1050)
            let v1105 : bool =
                if v1052 then
                    true
                else
                    let v1053 : bool = method30(v1051)
                    let v1054 : bool = v1053 = false
                    if v1054 then
                        true
                    else
                        let v1055 : unit = ()
                        let v1056 : (unit -> unit) = closure84(v1051, v1050)
                        let v1057 : unit = (fun () -> v1056 (); v1055) ()
                        method165(v1050, v1051)
                        false
            let v1108 : UH5 =
                if v1105 then
                    let v1106 : (string -> (string -> US33)) = closure81(v4, v3, v240)
                    UH5_1(v872, v209, v1106, v1049)
                else
                    v1049
            let struct (v1109 : string, v1110 : string) = method159(v237, v209, v4)
            let v1111 : bool = method30(v1109)
            let v1164 : bool =
                if v1111 then
                    true
                else
                    let v1112 : bool = method30(v1110)
                    let v1113 : bool = v1112 = false
                    if v1113 then
                        true
                    else
                        let v1114 : unit = ()
                        let v1115 : (unit -> unit) = closure84(v1110, v1109)
                        let v1116 : unit = (fun () -> v1115 (); v1114) ()
                        method165(v1109, v1110)
                        false
            let v1169 : UH5 =
                if v1164 then
                    let v1165 : (string -> (string -> US33)) = closure76(v4, v3, v1, v0)
                    let v1166 : UH5 = UH5_0
                    UH5_1(v237, v209, v1165, v1166)
                else
                    UH5_0
            let v1170 : UH4 = UH4_0
            let v1171 : UH4 = UH4_1(v1108, v1170)
            UH4_1(v1169, v1171)
    let v1174 : UH5 list = []
    let v1175 : UH5 list = method187(v1173, v1174)
    let v1177 : (UH5 list -> (UH5 [])) = List.toArray
    let v1178 : (UH5 []) = v1177 v1175
    let v1181 : string = "$0.to_vec()"
    let v1182 : Vec<UH5> = Fable.Core.RustInterop.emitRustExpr v1178 v1181 
    let v1183 : (Result<string, (string * string)> option []) = [||]
    let v1184 : string = "$0.to_vec()"
    let v1185 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1183 v1184 
    let v1186 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v1187 : (UH5 []) = Fable.Core.RustInterop.emitRustExpr v1182 v1186 
    let v1189 : UH5 list = v1187 |> Array.toList
    let v1197 : ((UH5 -> (UH4 -> UH4)) -> (UH5 list -> (UH4 -> UH4))) = List.foldBack
    let v1198 : (UH5 -> (UH4 -> UH4)) = method188()
    let v1199 : (UH5 list -> (UH4 -> UH4)) = v1197 v1198
    let v1200 : (UH4 -> UH4) = v1199 v1189
    let v1201 : UH4 = UH4_0
    let v1202 : UH4 = v1200 v1201
    let v1231 : Vec<Result<string, (string * string)> option> = method189(v1202, v1185)
    let v1233 : (string * Vec<Result<string, (string * string)> option>) = v180, v1231 
    let v1237 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = Ok v1233 
    v1237
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
    let v166 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Ok v164 
    let v169 : string = ""
    let v170 : string = "}"
    let v171 : string = v169 + v170 
    let x = v166 //
    let v172 : _ = x
    let v173 : unit = ()
    (* run_target_args'
    let v174 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v175 : string = $"true; let _fix_closure_v173 = $0"
    let v176 : bool = Fable.Core.RustInterop.emitRustExpr v172 v175 
    let _run_target_args'_v174 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v177 : string = $"true; let _fix_closure_v173 = $0"
    let v178 : bool = Fable.Core.RustInterop.emitRustExpr v172 v177 
    let _run_target_args'_v174 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v179 : string = $"true; let _fix_closure_v173 = $0"
    let v180 : bool = Fable.Core.RustInterop.emitRustExpr v172 v179 
    let _run_target_args'_v174 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v174 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v174 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v174 = false 
    #endif
#else
    let _run_target_args'_v174 = false 
    #endif
    let v181 : bool = _run_target_args'_v174 
    let v183 : string = $"true; _fix_closure_v173 " + v171 + "); " + v169 + " // rust.fix_closure'"
    let v184 : bool = Fable.Core.RustInterop.emitRustExpr () v183 
    let v185 : string = "__future_init"
    let v186 : _ = Fable.Core.RustInterop.emitRustExpr () v185 
    let v187 : string = "v186"
    let v188 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v187 
    v188
and closure88 () (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) : US37 =
    US37_0(v0)
and method193 () : (Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> -> US37) =
    closure88()
and closure89 () (v0 : std_string_String) : US37 =
    US37_1(v0)
and method194 () : (std_string_String -> US37) =
    closure89()
and method195 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method78(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "documents.main"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method18(v13)
and closure90 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_4
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method76()
        let v46 : string = method195(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method19(v46)
and method197 (v0 : unativeint) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure8(v2, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v16 : string = "result_len"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure8(v2, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v27 : string = " = "
    let v28 : string = $"{v27}"
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure8(v2, v28)
    let v33 : unit = (fun () -> v32 (); v31) ()
    (* run_target_args'
    let v40 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v41 : string = "format!(\"{:#?}\", $0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v41 
    let v43 : string = "fable_library_rust::String_::fromString($0)"
    let v44 : string = Fable.Core.RustInterop.emitRustExpr v42 v43 
    let _run_target_args'_v40 = v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : string = "format!(\"{:#?}\", $0)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v45 
    let v47 : string = "fable_library_rust::String_::fromString($0)"
    let v48 : string = Fable.Core.RustInterop.emitRustExpr v46 v47 
    let _run_target_args'_v40 = v48 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v49 : string = "format!(\"{:#?}\", $0)"
    let v50 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v49 
    let v51 : string = "fable_library_rust::String_::fromString($0)"
    let v52 : string = Fable.Core.RustInterop.emitRustExpr v50 v51 
    let _run_target_args'_v40 = v52 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v54 : string = $"%A{v0}"
    let _run_target_args'_v40 = v54 
    #endif
#if FABLE_COMPILER_PYTHON
    let v58 : string = $"%A{v0}"
    let _run_target_args'_v40 = v58 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v62 : string = $"%A{v0}"
    let _run_target_args'_v40 = v62 
    #endif
#else
    let v66 : string = $"%A{v0}"
    let _run_target_args'_v40 = v66 
    #endif
    let v69 : string = _run_target_args'_v40 
    let v76 : string = $"{v69}"
    let v79 : unit = ()
    let v80 : (unit -> unit) = closure8(v2, v76)
    let v81 : unit = (fun () -> v80 (); v79) ()
    let v86 : string = " }"
    let v87 : string = $"{v86}"
    let v90 : unit = ()
    let v91 : (unit -> unit) = closure8(v2, v87)
    let v92 : unit = (fun () -> v91 (); v90) ()
    let v95 : string = v2.l0
    v95
and method196 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : unativeint) : string =
    let v9 : string = method197(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "documents.main"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method18(v13)
and closure91 (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) () : unit =
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
        let v48 : string = method196(v26, v27, v28, v29, v30, v31, v44, v45, v47)
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
    let v108 : (std_string_String -> US6) = method21()
    let v109 : US6 option = v105 |> Option.map v108 
    let v129 : US6 = US6_1
    let v130 : US6 = v109 |> Option.defaultValue v129 
    let v137 : std_string_String =
        match v130 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v134) -> (* Some *)
            v134
    let v138 : string = "fable_library_rust::String_::fromString($0)"
    let v139 : string = Fable.Core.RustInterop.emitRustExpr v137 v138 
    let v140 : string = method22()
    (* run_target_args'
    let v145 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v146 : string = "&*$0"
    let v147 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v140 v146 
    let _run_target_args'_v145 = v147 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v148 : string = "&*$0"
    let v149 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v140 v148 
    let _run_target_args'_v145 = v149 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v150 : string = "&*$0"
    let v151 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v140 v150 
    let _run_target_args'_v145 = v151 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v153 : Ref<Str> = v140 |> unbox<Ref<Str>>
    let _run_target_args'_v145 = v153 
    #endif
#if FABLE_COMPILER_PYTHON
    let v157 : Ref<Str> = v140 |> unbox<Ref<Str>>
    let _run_target_args'_v145 = v157 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v161 : Ref<Str> = v140 |> unbox<Ref<Str>>
    let _run_target_args'_v145 = v161 
    #endif
#else
    let v165 : Ref<Str> = v140 |> unbox<Ref<Str>>
    let _run_target_args'_v145 = v165 
    #endif
    let v168 : Ref<Str> = _run_target_args'_v145 
    let v174 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v175 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v69, v168) v174 
    let v178 : (std_string_String -> US6) = method21()
    let v179 : US6 option = v175 |> Option.map v178 
    let v199 : US6 = US6_1
    let v200 : US6 = v179 |> Option.defaultValue v199 
    let v207 : std_string_String =
        match v200 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v204) -> (* Some *)
            v204
    let v208 : string = "fable_library_rust::String_::fromString($0)"
    let v209 : string = Fable.Core.RustInterop.emitRustExpr v207 v208 
    let v210 : string = method23()
    (* run_target_args'
    let v215 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v216 : string = "&*$0"
    let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
    let _run_target_args'_v215 = v217 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v218 : string = "&*$0"
    let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
    let _run_target_args'_v215 = v219 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v220 : string = "&*$0"
    let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
    let _run_target_args'_v215 = v221 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
    let _run_target_args'_v215 = v223 
    #endif
#if FABLE_COMPILER_PYTHON
    let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
    let _run_target_args'_v215 = v227 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
    let _run_target_args'_v215 = v231 
    #endif
#else
    let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
    let _run_target_args'_v215 = v235 
    #endif
    let v238 : Ref<Str> = _run_target_args'_v215 
    let v244 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v245 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v69, v238) v244 
    let v248 : (std_string_String -> US6) = method21()
    let v249 : US6 option = v245 |> Option.map v248 
    let v269 : US6 = US6_1
    let v270 : US6 = v249 |> Option.defaultValue v269 
    let v277 : std_string_String =
        match v270 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v274) -> (* Some *)
            v274
    let v278 : string = "fable_library_rust::String_::fromString($0)"
    let v279 : string = Fable.Core.RustInterop.emitRustExpr v277 v278 
    let v280 : string = method24()
    (* run_target_args'
    let v285 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v286 : string = "&*$0"
    let v287 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v280 v286 
    let _run_target_args'_v285 = v287 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v288 : string = "&*$0"
    let v289 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v280 v288 
    let _run_target_args'_v285 = v289 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v290 : string = "&*$0"
    let v291 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v280 v290 
    let _run_target_args'_v285 = v291 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v293 : Ref<Str> = v280 |> unbox<Ref<Str>>
    let _run_target_args'_v285 = v293 
    #endif
#if FABLE_COMPILER_PYTHON
    let v297 : Ref<Str> = v280 |> unbox<Ref<Str>>
    let _run_target_args'_v285 = v297 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v301 : Ref<Str> = v280 |> unbox<Ref<Str>>
    let _run_target_args'_v285 = v301 
    #endif
#else
    let v305 : Ref<Str> = v280 |> unbox<Ref<Str>>
    let _run_target_args'_v285 = v305 
    #endif
    let v308 : Ref<Str> = _run_target_args'_v285 
    let v314 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v315 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v69, v308) v314 
    let v318 : (std_string_String -> US6) = method21()
    let v319 : US6 option = v315 |> Option.map v318 
    let v339 : US6 = US6_1
    let v340 : US6 = v319 |> Option.defaultValue v339 
    let v347 : std_string_String =
        match v340 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v344) -> (* Some *)
            v344
    let v348 : string = "fable_library_rust::String_::fromString($0)"
    let v349 : string = Fable.Core.RustInterop.emitRustExpr v347 v348 
    let v350 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = method25(v349, v279, v209, v139)
    let v351 : string = "futures::executor::block_on($0)"
    let v352 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr v350 v351 
    let v353 : (Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> -> US37) = method193()
    let v354 : (std_string_String -> US37) = method194()
    let v356 : US37 = match v352 with Ok x -> v353 x | Error x -> v354 x
    match v356 with
    | US37_1(v411) -> (* Error *)
        let v412 : unit = ()
        let v413 : (unit -> unit) = closure90(v411)
        let v414 : unit = (fun () -> v413 (); v412) ()
        1
    | US37_0(v359) -> (* Ok *)
        let v360 : unit = ()
        let v361 : (unit -> unit) = closure91(v359)
        let v362 : unit = (fun () -> v361 (); v360) ()
        0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
