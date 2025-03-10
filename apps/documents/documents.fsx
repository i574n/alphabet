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
    let v67 : US5 = US5_1
    let v68 : US5 = v53 |> Option.defaultValue v67 
    let v75 : string =
        match v68 with
        | US5_1 -> (* None *)
            let v73 : string = ""
            v73
        | US5_0(v72) -> (* Some *)
            v72
    let _run_target_args'_v5 = v75 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v76 : US3 = US3_1
    let v77 : US4 = US4_1(v76)
    let v78 : string = $"env.get_environment_variable / target: {v77} / var: {v0}"
    let v79 : string = failwith<string> v78
    let _run_target_args'_v5 = v79 
    #endif
#else
    let v80 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v81 : string = v80 v0
    let mutable _v81 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v83 : (string -> string option) = Option.ofObj
    let v84 : string option = v83 v81
    v84 
    #else
    Some v81 
    #endif
    |> fun x -> _v81 <- Some x
    let v85 : string option = match _v81 with Some x -> x | None -> failwith "optionm'.of_obj / _v81=None"
    let v90 : (string -> US5) = method6()
    let v91 : US5 option = v85 |> Option.map v90 
    let v105 : US5 = US5_1
    let v106 : US5 = v91 |> Option.defaultValue v105 
    let v113 : string =
        match v106 with
        | US5_1 -> (* None *)
            let v111 : string = ""
            v111
        | US5_0(v110) -> (* Some *)
            v110
    let _run_target_args'_v5 = v113 
    #endif
    let v114 : string = _run_target_args'_v5 
    v114
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
    let v167 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v170 : (int64 -> US2) = method9()
    let v171 : US2 option = v5 |> Option.map v170 
    let v185 : US2 = US2_1
    let v186 : US2 = v171 |> Option.defaultValue v185 
    let v304 : System.DateTime =
        match v186 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v287 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v288 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v287 = v288 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v289 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v287 = v289 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v291 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v287 = v291 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v294 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v287 = v294 
            #endif
#if FABLE_COMPILER_PYTHON
            let v295 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v287 = v295 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v296 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v287 = v296 
            #endif
#else
            let v297 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v287 = v297 
            #endif
            let v298 : System.DateTime = _run_target_args'_v287 
            v298
        | US2_0(v190) -> (* Some *)
            (* run_target_args'
            let v193 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v194 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v193 = v194 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v195 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v193 = v195 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v197 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v193 = v197 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v200 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v193 = v200 
            #endif
#if FABLE_COMPILER_PYTHON
            let v201 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v193 = v201 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v202 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v193 = v202 
            #endif
#else
            let v203 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v193 = v203 
            #endif
            let v204 : System.DateTime = _run_target_args'_v193 
            (* run_target_args'
            let v212 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v213 : (System.DateTime -> int64) = _.Ticks
            let v214 : int64 = v213 v204
            let _run_target_args'_v212 = v214 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v215 : (System.DateTime -> int64) = _.Ticks
            let v216 : int64 = v215 v204
            let _run_target_args'_v212 = v216 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v218 : int64 = null |> unbox<int64>
            let _run_target_args'_v212 = v218 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v221 : (System.DateTime -> int64) = _.Ticks
            let v222 : int64 = v221 v204
            let _run_target_args'_v212 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v223 : (System.DateTime -> int64) = _.Ticks
            let v224 : int64 = v223 v204
            let _run_target_args'_v212 = v224 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v225 : (System.DateTime -> int64) = _.Ticks
            let v226 : int64 = v225 v204
            let _run_target_args'_v212 = v226 
            #endif
#else
            let v227 : (System.DateTime -> int64) = _.Ticks
            let v228 : int64 = v227 v204
            let _run_target_args'_v212 = v228 
            #endif
            let v229 : int64 = _run_target_args'_v212 
            let v250 : int64 = v229 |> int64 
            let v253 : int64 = v250 - v190
            let v256 : System.TimeSpan = v253 |> System.TimeSpan 
            let v262 : (System.TimeSpan -> int32) = _.Hours
            let v263 : int32 = v262 v256
            let v267 : (System.TimeSpan -> int32) = _.Minutes
            let v268 : int32 = v267 v256
            let v272 : (System.TimeSpan -> int32) = _.Seconds
            let v273 : int32 = v272 v256
            let v277 : (System.TimeSpan -> int32) = _.Milliseconds
            let v278 : int32 = v277 v256
            let v282 : System.DateTime = System.DateTime (1, 1, 1, v263, v268, v273, v278)
            v282
    let v306 : string = method10()
    let v310 : bool = v306 = ""
    let v312 : string =
        if v310 then
            let v311 : string = "M-d-y hh:mm:ss tt"
            v311
        else
            v306
    let v313 : (string -> string) = v304.ToString
    let v314 : string = v313 v312
    let _run_target_args'_v167 = v314 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v331 : (int64 -> US2) = method9()
    let v332 : US2 option = v5 |> Option.map v331 
    let v346 : US2 = US2_1
    let v347 : US2 = v332 |> Option.defaultValue v346 
    let v465 : System.DateTime =
        match v347 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v448 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v449 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v448 = v449 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v450 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v448 = v450 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v452 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v448 = v452 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v455 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v448 = v455 
            #endif
#if FABLE_COMPILER_PYTHON
            let v456 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v448 = v456 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v457 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v448 = v457 
            #endif
#else
            let v458 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v448 = v458 
            #endif
            let v459 : System.DateTime = _run_target_args'_v448 
            v459
        | US2_0(v351) -> (* Some *)
            (* run_target_args'
            let v354 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v355 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v354 = v355 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v356 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v354 = v356 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v358 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v354 = v358 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v361 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v354 = v361 
            #endif
#if FABLE_COMPILER_PYTHON
            let v362 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v354 = v362 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v363 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v354 = v363 
            #endif
#else
            let v364 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v354 = v364 
            #endif
            let v365 : System.DateTime = _run_target_args'_v354 
            (* run_target_args'
            let v373 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v374 : (System.DateTime -> int64) = _.Ticks
            let v375 : int64 = v374 v365
            let _run_target_args'_v373 = v375 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v376 : (System.DateTime -> int64) = _.Ticks
            let v377 : int64 = v376 v365
            let _run_target_args'_v373 = v377 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v379 : int64 = null |> unbox<int64>
            let _run_target_args'_v373 = v379 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v382 : (System.DateTime -> int64) = _.Ticks
            let v383 : int64 = v382 v365
            let _run_target_args'_v373 = v383 
            #endif
#if FABLE_COMPILER_PYTHON
            let v384 : (System.DateTime -> int64) = _.Ticks
            let v385 : int64 = v384 v365
            let _run_target_args'_v373 = v385 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v386 : (System.DateTime -> int64) = _.Ticks
            let v387 : int64 = v386 v365
            let _run_target_args'_v373 = v387 
            #endif
#else
            let v388 : (System.DateTime -> int64) = _.Ticks
            let v389 : int64 = v388 v365
            let _run_target_args'_v373 = v389 
            #endif
            let v390 : int64 = _run_target_args'_v373 
            let v411 : int64 = v390 |> int64 
            let v414 : int64 = v411 - v351
            let v417 : System.TimeSpan = v414 |> System.TimeSpan 
            let v423 : (System.TimeSpan -> int32) = _.Hours
            let v424 : int32 = v423 v417
            let v428 : (System.TimeSpan -> int32) = _.Minutes
            let v429 : int32 = v428 v417
            let v433 : (System.TimeSpan -> int32) = _.Seconds
            let v434 : int32 = v433 v417
            let v438 : (System.TimeSpan -> int32) = _.Milliseconds
            let v439 : int32 = v438 v417
            let v443 : System.DateTime = System.DateTime (1, 1, 1, v424, v429, v434, v439)
            v443
    let v467 : string = method10()
    let v471 : bool = v467 = ""
    let v473 : string =
        if v471 then
            let v472 : string = "M-d-y hh:mm:ss tt"
            v472
        else
            v467
    let v474 : (string -> string) = v465.ToString
    let v475 : string = v474 v473
    let _run_target_args'_v167 = v475 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v490 : string = $"near_sdk::env::block_timestamp()"
    let v491 : uint64 = Fable.Core.RustInterop.emitRustExpr () v490 
    let v494 : (int64 -> US2) = method9()
    let v495 : US2 option = v5 |> Option.map v494 
    let v509 : US2 = US2_1
    let v510 : US2 = v495 |> Option.defaultValue v509 
    let v522 : uint64 =
        match v510 with
        | US2_1 -> (* None *)
            v491
        | US2_0(v514) -> (* Some *)
            let v516 : (int64 -> uint64) = uint64
            let v517 : uint64 = v516 v514
            let v520 : uint64 = v491 - v517
            v520
    let v523 : uint64 = v522 / 1000000000UL
    let v524 : uint64 = v523 % 60UL
    let v525 : uint64 = v523 / 60UL
    let v526 : uint64 = v525 % 60UL
    let v527 : uint64 = v523 / 3600UL
    let v528 : uint64 = v527 % 24UL
    let v529 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v530 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v528, v526, v524) v529 
    let v531 : string = "fable_library_rust::String_::fromString($0)"
    let v532 : string = Fable.Core.RustInterop.emitRustExpr v530 v531 
    let _run_target_args'_v167 = v532 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v535 : (int64 -> US2) = method9()
    let v536 : US2 option = v5 |> Option.map v535 
    let v550 : US2 = US2_1
    let v551 : US2 = v536 |> Option.defaultValue v550 
    let v669 : System.DateTime =
        match v551 with
        | US2_1 -> (* None *)
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
            v663
        | US2_0(v555) -> (* Some *)
            (* run_target_args'
            let v558 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v559 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v558 = v559 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v560 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v558 = v560 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v562 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v558 = v562 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v565 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v558 = v565 
            #endif
#if FABLE_COMPILER_PYTHON
            let v566 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v558 = v566 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v567 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v558 = v567 
            #endif
#else
            let v568 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v558 = v568 
            #endif
            let v569 : System.DateTime = _run_target_args'_v558 
            (* run_target_args'
            let v577 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v578 : (System.DateTime -> int64) = _.Ticks
            let v579 : int64 = v578 v569
            let _run_target_args'_v577 = v579 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v580 : (System.DateTime -> int64) = _.Ticks
            let v581 : int64 = v580 v569
            let _run_target_args'_v577 = v581 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v583 : int64 = null |> unbox<int64>
            let _run_target_args'_v577 = v583 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v586 : (System.DateTime -> int64) = _.Ticks
            let v587 : int64 = v586 v569
            let _run_target_args'_v577 = v587 
            #endif
#if FABLE_COMPILER_PYTHON
            let v588 : (System.DateTime -> int64) = _.Ticks
            let v589 : int64 = v588 v569
            let _run_target_args'_v577 = v589 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v590 : (System.DateTime -> int64) = _.Ticks
            let v591 : int64 = v590 v569
            let _run_target_args'_v577 = v591 
            #endif
#else
            let v592 : (System.DateTime -> int64) = _.Ticks
            let v593 : int64 = v592 v569
            let _run_target_args'_v577 = v593 
            #endif
            let v594 : int64 = _run_target_args'_v577 
            let v615 : int64 = v594 |> int64 
            let v618 : int64 = v615 - v555
            let v621 : System.TimeSpan = v618 |> System.TimeSpan 
            let v627 : (System.TimeSpan -> int32) = _.Hours
            let v628 : int32 = v627 v621
            let v632 : (System.TimeSpan -> int32) = _.Minutes
            let v633 : int32 = v632 v621
            let v637 : (System.TimeSpan -> int32) = _.Seconds
            let v638 : int32 = v637 v621
            let v642 : (System.TimeSpan -> int32) = _.Milliseconds
            let v643 : int32 = v642 v621
            let v647 : System.DateTime = System.DateTime (1, 1, 1, v628, v633, v638, v643)
            v647
    let v671 : string = method11()
    let v675 : bool = v671 = ""
    let v677 : string =
        if v675 then
            let v676 : string = "M-d-y hh:mm:ss tt"
            v676
        else
            v671
    let v678 : (string -> string) = v669.ToString
    let v679 : string = v678 v677
    let _run_target_args'_v167 = v679 
    #endif
#if FABLE_COMPILER_PYTHON
    let v696 : (int64 -> US2) = method9()
    let v697 : US2 option = v5 |> Option.map v696 
    let v711 : US2 = US2_1
    let v712 : US2 = v697 |> Option.defaultValue v711 
    let v830 : System.DateTime =
        match v712 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v813 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v814 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v813 = v814 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v815 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v813 = v815 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v817 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v813 = v817 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v820 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v813 = v820 
            #endif
#if FABLE_COMPILER_PYTHON
            let v821 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v813 = v821 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v822 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v813 = v822 
            #endif
#else
            let v823 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v813 = v823 
            #endif
            let v824 : System.DateTime = _run_target_args'_v813 
            v824
        | US2_0(v716) -> (* Some *)
            (* run_target_args'
            let v719 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v720 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v719 = v720 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v721 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v719 = v721 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v723 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v719 = v723 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v726 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v719 = v726 
            #endif
#if FABLE_COMPILER_PYTHON
            let v727 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v719 = v727 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v728 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v719 = v728 
            #endif
#else
            let v729 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v719 = v729 
            #endif
            let v730 : System.DateTime = _run_target_args'_v719 
            (* run_target_args'
            let v738 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v739 : (System.DateTime -> int64) = _.Ticks
            let v740 : int64 = v739 v730
            let _run_target_args'_v738 = v740 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v741 : (System.DateTime -> int64) = _.Ticks
            let v742 : int64 = v741 v730
            let _run_target_args'_v738 = v742 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v744 : int64 = null |> unbox<int64>
            let _run_target_args'_v738 = v744 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v747 : (System.DateTime -> int64) = _.Ticks
            let v748 : int64 = v747 v730
            let _run_target_args'_v738 = v748 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : (System.DateTime -> int64) = _.Ticks
            let v750 : int64 = v749 v730
            let _run_target_args'_v738 = v750 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v751 : (System.DateTime -> int64) = _.Ticks
            let v752 : int64 = v751 v730
            let _run_target_args'_v738 = v752 
            #endif
#else
            let v753 : (System.DateTime -> int64) = _.Ticks
            let v754 : int64 = v753 v730
            let _run_target_args'_v738 = v754 
            #endif
            let v755 : int64 = _run_target_args'_v738 
            let v776 : int64 = v755 |> int64 
            let v779 : int64 = v776 - v716
            let v782 : System.TimeSpan = v779 |> System.TimeSpan 
            let v788 : (System.TimeSpan -> int32) = _.Hours
            let v789 : int32 = v788 v782
            let v793 : (System.TimeSpan -> int32) = _.Minutes
            let v794 : int32 = v793 v782
            let v798 : (System.TimeSpan -> int32) = _.Seconds
            let v799 : int32 = v798 v782
            let v803 : (System.TimeSpan -> int32) = _.Milliseconds
            let v804 : int32 = v803 v782
            let v808 : System.DateTime = System.DateTime (1, 1, 1, v789, v794, v799, v804)
            v808
    let v832 : string = method11()
    let v836 : bool = v832 = ""
    let v838 : string =
        if v836 then
            let v837 : string = "M-d-y hh:mm:ss tt"
            v837
        else
            v832
    let v839 : (string -> string) = v830.ToString
    let v840 : string = v839 v838
    let _run_target_args'_v167 = v840 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v857 : (int64 -> US2) = method9()
    let v858 : US2 option = v5 |> Option.map v857 
    let v872 : US2 = US2_1
    let v873 : US2 = v858 |> Option.defaultValue v872 
    let v991 : System.DateTime =
        match v873 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v974 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v975 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v974 = v975 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v976 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v974 = v976 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v978 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v974 = v978 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v981 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v974 = v981 
            #endif
#if FABLE_COMPILER_PYTHON
            let v982 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v974 = v982 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v983 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v974 = v983 
            #endif
#else
            let v984 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v974 = v984 
            #endif
            let v985 : System.DateTime = _run_target_args'_v974 
            v985
        | US2_0(v877) -> (* Some *)
            (* run_target_args'
            let v880 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v881 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v880 = v881 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v882 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v880 = v882 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v884 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v880 = v884 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v887 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v880 = v887 
            #endif
#if FABLE_COMPILER_PYTHON
            let v888 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v880 = v888 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v889 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v880 = v889 
            #endif
#else
            let v890 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v880 = v890 
            #endif
            let v891 : System.DateTime = _run_target_args'_v880 
            (* run_target_args'
            let v899 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v900 : (System.DateTime -> int64) = _.Ticks
            let v901 : int64 = v900 v891
            let _run_target_args'_v899 = v901 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v902 : (System.DateTime -> int64) = _.Ticks
            let v903 : int64 = v902 v891
            let _run_target_args'_v899 = v903 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v905 : int64 = null |> unbox<int64>
            let _run_target_args'_v899 = v905 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v908 : (System.DateTime -> int64) = _.Ticks
            let v909 : int64 = v908 v891
            let _run_target_args'_v899 = v909 
            #endif
#if FABLE_COMPILER_PYTHON
            let v910 : (System.DateTime -> int64) = _.Ticks
            let v911 : int64 = v910 v891
            let _run_target_args'_v899 = v911 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v912 : (System.DateTime -> int64) = _.Ticks
            let v913 : int64 = v912 v891
            let _run_target_args'_v899 = v913 
            #endif
#else
            let v914 : (System.DateTime -> int64) = _.Ticks
            let v915 : int64 = v914 v891
            let _run_target_args'_v899 = v915 
            #endif
            let v916 : int64 = _run_target_args'_v899 
            let v937 : int64 = v916 |> int64 
            let v940 : int64 = v937 - v877
            let v943 : System.TimeSpan = v940 |> System.TimeSpan 
            let v949 : (System.TimeSpan -> int32) = _.Hours
            let v950 : int32 = v949 v943
            let v954 : (System.TimeSpan -> int32) = _.Minutes
            let v955 : int32 = v954 v943
            let v959 : (System.TimeSpan -> int32) = _.Seconds
            let v960 : int32 = v959 v943
            let v964 : (System.TimeSpan -> int32) = _.Milliseconds
            let v965 : int32 = v964 v943
            let v969 : System.DateTime = System.DateTime (1, 1, 1, v950, v955, v960, v965)
            v969
    let v993 : string = method11()
    let v997 : bool = v993 = ""
    let v999 : string =
        if v997 then
            let v998 : string = "M-d-y hh:mm:ss tt"
            v998
        else
            v993
    let v1000 : (string -> string) = v991.ToString
    let v1001 : string = v1000 v999
    let _run_target_args'_v167 = v1001 
    #endif
#else
    let v1018 : (int64 -> US2) = method9()
    let v1019 : US2 option = v5 |> Option.map v1018 
    let v1033 : US2 = US2_1
    let v1034 : US2 = v1019 |> Option.defaultValue v1033 
    let v1152 : System.DateTime =
        match v1034 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v1135 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1136 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1135 = v1136 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1137 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1135 = v1137 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1139 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1135 = v1139 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1142 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1135 = v1142 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1143 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1135 = v1143 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1144 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1135 = v1144 
            #endif
#else
            let v1145 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1135 = v1145 
            #endif
            let v1146 : System.DateTime = _run_target_args'_v1135 
            v1146
        | US2_0(v1038) -> (* Some *)
            (* run_target_args'
            let v1041 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1042 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1041 = v1042 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1043 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1041 = v1043 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1045 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1041 = v1045 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1048 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1041 = v1048 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1049 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1041 = v1049 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1050 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1041 = v1050 
            #endif
#else
            let v1051 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1041 = v1051 
            #endif
            let v1052 : System.DateTime = _run_target_args'_v1041 
            (* run_target_args'
            let v1060 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1061 : (System.DateTime -> int64) = _.Ticks
            let v1062 : int64 = v1061 v1052
            let _run_target_args'_v1060 = v1062 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1063 : (System.DateTime -> int64) = _.Ticks
            let v1064 : int64 = v1063 v1052
            let _run_target_args'_v1060 = v1064 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1066 : int64 = null |> unbox<int64>
            let _run_target_args'_v1060 = v1066 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1069 : (System.DateTime -> int64) = _.Ticks
            let v1070 : int64 = v1069 v1052
            let _run_target_args'_v1060 = v1070 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1071 : (System.DateTime -> int64) = _.Ticks
            let v1072 : int64 = v1071 v1052
            let _run_target_args'_v1060 = v1072 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1073 : (System.DateTime -> int64) = _.Ticks
            let v1074 : int64 = v1073 v1052
            let _run_target_args'_v1060 = v1074 
            #endif
#else
            let v1075 : (System.DateTime -> int64) = _.Ticks
            let v1076 : int64 = v1075 v1052
            let _run_target_args'_v1060 = v1076 
            #endif
            let v1077 : int64 = _run_target_args'_v1060 
            let v1098 : int64 = v1077 |> int64 
            let v1101 : int64 = v1098 - v1038
            let v1104 : System.TimeSpan = v1101 |> System.TimeSpan 
            let v1110 : (System.TimeSpan -> int32) = _.Hours
            let v1111 : int32 = v1110 v1104
            let v1115 : (System.TimeSpan -> int32) = _.Minutes
            let v1116 : int32 = v1115 v1104
            let v1120 : (System.TimeSpan -> int32) = _.Seconds
            let v1121 : int32 = v1120 v1104
            let v1125 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1126 : int32 = v1125 v1104
            let v1130 : System.DateTime = System.DateTime (1, 1, 1, v1111, v1116, v1121, v1126)
            v1130
    let v1154 : string = method11()
    let v1158 : bool = v1154 = ""
    let v1160 : string =
        if v1158 then
            let v1159 : string = "M-d-y hh:mm:ss tt"
            v1159
        else
            v1154
    let v1161 : (string -> string) = v1152.ToString
    let v1162 : string = v1161 v1160
    let _run_target_args'_v167 = v1162 
    #endif
    let v1177 : string = _run_target_args'_v167 
    v1177
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
        let v11 : (string -> US5) = method6()
        let v12 : US5 option = v8 |> Option.map v11 
        let v26 : US5 = US5_1
        let v27 : US5 = v12 |> Option.defaultValue v26 
        match v27 with
        | US5_1 -> (* None *)
            let v33 : string = $"""file_system.find_parent / No parent for {if v2 then "file" else "dir"}"""
            let v34 : string = $" '{v0}' at '{v1}' (until '{v4}')"
            let v35 : string = v33 + v34 
            US8_1(v35)
        | US5_0(v31) -> (* Some *)
            method34(v0, v1, v2, v3, v31)
and method32 (v0 : string, v1 : string, v2 : bool, v3 : (string -> bool)) : US8 =
    let v4 : string = method28(v1, v0)
    let v5 : bool = v3 v4
    if v5 then
        US8_0(v1)
    else
        let v7 : string option = method33(v1)
        let v10 : (string -> US5) = method6()
        let v11 : US5 option = v7 |> Option.map v10 
        let v25 : US5 = US5_1
        let v26 : US5 = v11 |> Option.defaultValue v25 
        match v26 with
        | US5_1 -> (* None *)
            let v32 : string = $"""file_system.find_parent / No parent for {if v2 then "file" else "dir"}"""
            let v33 : string = $" '{v0}' at '{v1}' (until '{v1}')"
            let v34 : string = v32 + v33 
            US8_1(v34)
        | US5_0(v30) -> (* Some *)
            method34(v0, v1, v2, v3, v30)
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
    let v173 : US5 = US5_1
    let v174 : US5 = v159 |> Option.defaultValue v173 
    let v181 : string =
        match v174 with
        | US5_1 -> (* None *)
            let v179 : string = ""
            v179
        | US5_0(v178) -> (* Some *)
            v178
    let _run_target_args'_v5 = v181 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v182 : US3 = US3_1
    let v183 : US4 = US4_3(v182)
    let v184 : string = $"file_system.get_file_name / target: {v183} / path: {v0}"
    let v185 : string = failwith<string> v184
    let _run_target_args'_v5 = v185 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v187 : string = null |> unbox<string>
    let _run_target_args'_v5 = v187 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v190 : string = "path"
    let v191 : IPathBasename = Fable.Core.JsInterop.importAll v190 
    let v192 : string = "v191.basename($0)"
    let v193 : string = Fable.Core.JsInterop.emitJsExpr v0 v192 
    let _run_target_args'_v5 = v193 
    #endif
#if FABLE_COMPILER_PYTHON
    let v194 : US3 = US3_0
    let v195 : US4 = US4_5(v194)
    let v196 : string = $"file_system.get_file_name / target: {v195} / path: {v0}"
    let v197 : string = failwith<string> v196
    let _run_target_args'_v5 = v197 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v198 : US3 = US3_1
    let v199 : US4 = US4_1(v198)
    let v200 : string = $"file_system.get_file_name / target: {v199} / path: {v0}"
    let v201 : string = failwith<string> v200
    let _run_target_args'_v5 = v201 
    #endif
#else
    let v202 : (string -> string) = System.IO.Path.GetFileName
    let v203 : string = v202 v0
    let _run_target_args'_v5 = v203 
    #endif
    let v204 : string = _run_target_args'_v5 
    v204
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
    let v24 : US5 = US5_1
    let v25 : US5 = v10 |> Option.defaultValue v24 
    let v29 : string = method48(v3)
    let v30 : bool = v2 >= 11uy
    if v30 then
        let v31 : string = $"file_system.read_link / "
        let v32 : string = $"path: {v0} / n: {v2} / path': {v4} / name: {v5}"
        let v33 : string = v31 + v32 
        (* run_target_args'
        let v38 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v39 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v40 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v33 v39 
        let _run_target_args'_v38 = v40 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v41 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v42 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v33 v41 
        let _run_target_args'_v38 = v42 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v43 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v44 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v33 v43 
        let _run_target_args'_v38 = v44 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v46 : std_io_Error = v33 |> unbox<std_io_Error>
        let _run_target_args'_v38 = v46 
        #endif
#if FABLE_COMPILER_PYTHON
        let v50 : std_io_Error = v33 |> unbox<std_io_Error>
        let _run_target_args'_v38 = v50 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v54 : std_io_Error = v33 |> unbox<std_io_Error>
        let _run_target_args'_v38 = v54 
        #endif
#else
        let v58 : std_io_Error = v33 |> unbox<std_io_Error>
        let _run_target_args'_v38 = v58 
        #endif
        let v61 : std_io_Error = _run_target_args'_v38 
        (* run_target_args'
        let v68 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v69 : string = "Err($0)"
        let v70 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v61 v69 
        let _run_target_args'_v68 = v70 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v71 : string = "Err($0)"
        let v72 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v61 v71 
        let _run_target_args'_v68 = v72 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v73 : string = "Err($0)"
        let v74 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v61 v73 
        let _run_target_args'_v68 = v74 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v75 : Result<std_path_PathBuf, std_io_Error> = v61 |> Error
        let _run_target_args'_v68 = v75 
        #endif
#if FABLE_COMPILER_PYTHON
        let v76 : Result<std_path_PathBuf, std_io_Error> = v61 |> Error
        let _run_target_args'_v68 = v76 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v77 : Result<std_path_PathBuf, std_io_Error> = v61 |> Error
        let _run_target_args'_v68 = v77 
        #endif
#else
        let v78 : Result<std_path_PathBuf, std_io_Error> = v61 |> Error
        let _run_target_args'_v68 = v78 
        #endif
        let v79 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v68 
        v79
    else
        match v25 with
        | US5_0(v82) -> (* Some *)
            let v85 : string = ""
            let v86 : bool = v4 <> v85 
            if v86 then
                let v89 : uint8 = v2 + 1uy
                let v90 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v89
                let v91 : Result<std_path_PathBuf, std_io_Error> = v90 v82
                let v92 : (std_io_Error -> string) = method41()
                (* run_target_args'
                let v94 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v95 : string = "$0.map_err(|x| $1(x))"
                let v96 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v91, v92) v95 
                let _run_target_args'_v94 = v96 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v97 : string = "$0.map_err(|x| $1(x))"
                let v98 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v91, v92) v97 
                let _run_target_args'_v94 = v98 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v99 : string = "$0.map_err(|x| $1(x))"
                let v100 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v91, v92) v99 
                let _run_target_args'_v94 = v100 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v101 : Result<std_path_PathBuf, string> = match v91 with Ok x -> Ok x | Error x -> Error (v92 x)
                let _run_target_args'_v94 = v101 
                #endif
#if FABLE_COMPILER_PYTHON
                let v102 : Result<std_path_PathBuf, string> = match v91 with Ok x -> Ok x | Error x -> Error (v92 x)
                let _run_target_args'_v94 = v102 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v103 : Result<std_path_PathBuf, string> = match v91 with Ok x -> Ok x | Error x -> Error (v92 x)
                let _run_target_args'_v94 = v103 
                #endif
#else
                let v104 : Result<std_path_PathBuf, string> = match v91 with Ok x -> Ok x | Error x -> Error (v92 x)
                let _run_target_args'_v94 = v104 
                #endif
                let v105 : Result<std_path_PathBuf, string> = _run_target_args'_v94 
                let v108 : (std_path_PathBuf -> US9) = method43()
                let v109 : (string -> US9) = method44()
                let v111 : US9 = match v105 with Ok x -> v108 x | Error x -> v109 x
                match v111 with
                | US9_1(v267) -> (* Error *)
                    let v268 : string = $"file_system.read_link / "
                    let v269 : string = $"error': {v267} / error: {v29} / name: {v5}"
                    let v270 : string = v268 + v269 
                    (* run_target_args'
                    let v275 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v276 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v277 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v270 v276 
                    let _run_target_args'_v275 = v277 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v278 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v279 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v270 v278 
                    let _run_target_args'_v275 = v279 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v280 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v281 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v270 v280 
                    let _run_target_args'_v275 = v281 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v283 : std_io_Error = v270 |> unbox<std_io_Error>
                    let _run_target_args'_v275 = v283 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v287 : std_io_Error = v270 |> unbox<std_io_Error>
                    let _run_target_args'_v275 = v287 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v291 : std_io_Error = v270 |> unbox<std_io_Error>
                    let _run_target_args'_v275 = v291 
                    #endif
#else
                    let v295 : std_io_Error = v270 |> unbox<std_io_Error>
                    let _run_target_args'_v275 = v295 
                    #endif
                    let v298 : std_io_Error = _run_target_args'_v275 
                    (* run_target_args'
                    let v305 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v306 : string = "Err($0)"
                    let v307 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v298 v306 
                    let _run_target_args'_v305 = v307 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v308 : string = "Err($0)"
                    let v309 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v298 v308 
                    let _run_target_args'_v305 = v309 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v310 : string = "Err($0)"
                    let v311 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v298 v310 
                    let _run_target_args'_v305 = v311 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v312 : Result<std_path_PathBuf, std_io_Error> = v298 |> Error
                    let _run_target_args'_v305 = v312 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v313 : Result<std_path_PathBuf, std_io_Error> = v298 |> Error
                    let _run_target_args'_v305 = v313 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v314 : Result<std_path_PathBuf, std_io_Error> = v298 |> Error
                    let _run_target_args'_v305 = v314 
                    #endif
#else
                    let v315 : Result<std_path_PathBuf, std_io_Error> = v298 |> Error
                    let _run_target_args'_v305 = v315 
                    #endif
                    let v316 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v305 
                    v316
                | US9_0(v114) -> (* Ok *)
                    (* run_target_args'
                    let v119 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v120 : string = "$0.display()"
                    let v121 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v114 v120 
                    let _run_target_args'_v119 = v121 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v122 : string = "$0.display()"
                    let v123 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v114 v122 
                    let _run_target_args'_v119 = v123 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v124 : string = "$0.display()"
                    let v125 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v114 v124 
                    let _run_target_args'_v119 = v125 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v127 : std_path_Display = v114 |> unbox<std_path_Display>
                    let _run_target_args'_v119 = v127 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v131 : std_path_Display = v114 |> unbox<std_path_Display>
                    let _run_target_args'_v119 = v131 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v135 : std_path_Display = v114 |> unbox<std_path_Display>
                    let _run_target_args'_v119 = v135 
                    #endif
#else
                    let v139 : std_path_Display = v114 |> unbox<std_path_Display>
                    let _run_target_args'_v119 = v139 
                    #endif
                    let v142 : std_path_Display = _run_target_args'_v119 
                    let v149 : string = v142 |> string 
                    let v152 : string = method28(v149, v5)
                    (* run_target_args'
                    let v157 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v158 : string = "&*$0"
                    let v159 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v152 v158 
                    let _run_target_args'_v157 = v159 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v160 : string = "&*$0"
                    let v161 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v152 v160 
                    let _run_target_args'_v157 = v161 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v162 : string = "&*$0"
                    let v163 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v152 v162 
                    let _run_target_args'_v157 = v163 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v165 : Ref<Str> = v152 |> unbox<Ref<Str>>
                    let _run_target_args'_v157 = v165 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v169 : Ref<Str> = v152 |> unbox<Ref<Str>>
                    let _run_target_args'_v157 = v169 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v173 : Ref<Str> = v152 |> unbox<Ref<Str>>
                    let _run_target_args'_v157 = v173 
                    #endif
#else
                    let v177 : Ref<Str> = v152 |> unbox<Ref<Str>>
                    let _run_target_args'_v157 = v177 
                    #endif
                    let v180 : Ref<Str> = _run_target_args'_v157 
                    (* run_target_args'
                    let v190 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v191 : string = "String::from($0)"
                    let v192 : std_string_String = Fable.Core.RustInterop.emitRustExpr v180 v191 
                    let _run_target_args'_v190 = v192 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v193 : string = "String::from($0)"
                    let v194 : std_string_String = Fable.Core.RustInterop.emitRustExpr v180 v193 
                    let _run_target_args'_v190 = v194 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v195 : string = "String::from($0)"
                    let v196 : std_string_String = Fable.Core.RustInterop.emitRustExpr v180 v195 
                    let _run_target_args'_v190 = v196 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v198 : std_string_String = v180 |> unbox<std_string_String>
                    let _run_target_args'_v190 = v198 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v202 : std_string_String = v180 |> unbox<std_string_String>
                    let _run_target_args'_v190 = v202 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v206 : std_string_String = v180 |> unbox<std_string_String>
                    let _run_target_args'_v190 = v206 
                    #endif
#else
                    let v210 : std_string_String = v180 |> unbox<std_string_String>
                    let _run_target_args'_v190 = v210 
                    #endif
                    let v213 : std_string_String = _run_target_args'_v190 
                    (* run_target_args'
                    let v223 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v224 : string = "std::path::PathBuf::from($0)"
                    let v225 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v213 v224 
                    let _run_target_args'_v223 = v225 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v226 : string = "std::path::PathBuf::from($0)"
                    let v227 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v213 v226 
                    let _run_target_args'_v223 = v227 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v228 : string = "std::path::PathBuf::from($0)"
                    let v229 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v213 v228 
                    let _run_target_args'_v223 = v229 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v231 : std_path_PathBuf = v213 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v223 = v231 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v235 : std_path_PathBuf = v213 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v223 = v235 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v239 : std_path_PathBuf = v213 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v223 = v239 
                    #endif
#else
                    let v243 : std_path_PathBuf = v213 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v223 = v243 
                    #endif
                    let v246 : std_path_PathBuf = _run_target_args'_v223 
                    (* run_target_args'
                    let v253 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v254 : string = "Ok($0)"
                    let v255 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v246 v254 
                    let _run_target_args'_v253 = v255 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v256 : string = "Ok($0)"
                    let v257 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v246 v256 
                    let _run_target_args'_v253 = v257 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v258 : string = "Ok($0)"
                    let v259 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v246 v258 
                    let _run_target_args'_v253 = v259 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v260 : Result<std_path_PathBuf, std_io_Error> = v246 |> Ok
                    let _run_target_args'_v253 = v260 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v261 : Result<std_path_PathBuf, std_io_Error> = v246 |> Ok
                    let _run_target_args'_v253 = v261 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v262 : Result<std_path_PathBuf, std_io_Error> = v246 |> Ok
                    let _run_target_args'_v253 = v262 
                    #endif
#else
                    let v263 : Result<std_path_PathBuf, std_io_Error> = v246 |> Ok
                    let _run_target_args'_v253 = v263 
                    #endif
                    let v264 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v253 
                    v264
            else
                let v321 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v322 : string = $"path: {v0} / error: {v29} / path': {v4} / name: {v5}"
                let v323 : string = v321 + v322 
                (* run_target_args'
                let v328 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v329 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v330 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v323 v329 
                let _run_target_args'_v328 = v330 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v331 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v332 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v323 v331 
                let _run_target_args'_v328 = v332 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v333 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v334 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v323 v333 
                let _run_target_args'_v328 = v334 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v336 : std_io_Error = v323 |> unbox<std_io_Error>
                let _run_target_args'_v328 = v336 
                #endif
#if FABLE_COMPILER_PYTHON
                let v340 : std_io_Error = v323 |> unbox<std_io_Error>
                let _run_target_args'_v328 = v340 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v344 : std_io_Error = v323 |> unbox<std_io_Error>
                let _run_target_args'_v328 = v344 
                #endif
#else
                let v348 : std_io_Error = v323 |> unbox<std_io_Error>
                let _run_target_args'_v328 = v348 
                #endif
                let v351 : std_io_Error = _run_target_args'_v328 
                (* run_target_args'
                let v358 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v359 : string = "Err($0)"
                let v360 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v351 v359 
                let _run_target_args'_v358 = v360 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v361 : string = "Err($0)"
                let v362 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v351 v361 
                let _run_target_args'_v358 = v362 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v363 : string = "Err($0)"
                let v364 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v351 v363 
                let _run_target_args'_v358 = v364 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v365 : Result<std_path_PathBuf, std_io_Error> = v351 |> Error
                let _run_target_args'_v358 = v365 
                #endif
#if FABLE_COMPILER_PYTHON
                let v366 : Result<std_path_PathBuf, std_io_Error> = v351 |> Error
                let _run_target_args'_v358 = v366 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v367 : Result<std_path_PathBuf, std_io_Error> = v351 |> Error
                let _run_target_args'_v358 = v367 
                #endif
#else
                let v368 : Result<std_path_PathBuf, std_io_Error> = v351 |> Error
                let _run_target_args'_v358 = v368 
                #endif
                let v369 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v358 
                v369
        | _ ->
            let v373 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v374 : string = $"path: {v0} / error: {v29} / path': {v4} / name: {v5}"
            let v375 : string = v373 + v374 
            (* run_target_args'
            let v380 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v381 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v382 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v375 v381 
            let _run_target_args'_v380 = v382 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v383 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v384 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v375 v383 
            let _run_target_args'_v380 = v384 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v385 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v386 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v375 v385 
            let _run_target_args'_v380 = v386 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v388 : std_io_Error = v375 |> unbox<std_io_Error>
            let _run_target_args'_v380 = v388 
            #endif
#if FABLE_COMPILER_PYTHON
            let v392 : std_io_Error = v375 |> unbox<std_io_Error>
            let _run_target_args'_v380 = v392 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v396 : std_io_Error = v375 |> unbox<std_io_Error>
            let _run_target_args'_v380 = v396 
            #endif
#else
            let v400 : std_io_Error = v375 |> unbox<std_io_Error>
            let _run_target_args'_v380 = v400 
            #endif
            let v403 : std_io_Error = _run_target_args'_v380 
            (* run_target_args'
            let v410 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v411 : string = "Err($0)"
            let v412 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v403 v411 
            let _run_target_args'_v410 = v412 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v413 : string = "Err($0)"
            let v414 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v403 v413 
            let _run_target_args'_v410 = v414 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v415 : string = "Err($0)"
            let v416 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v403 v415 
            let _run_target_args'_v410 = v416 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v417 : Result<std_path_PathBuf, std_io_Error> = v403 |> Error
            let _run_target_args'_v410 = v417 
            #endif
#if FABLE_COMPILER_PYTHON
            let v418 : Result<std_path_PathBuf, std_io_Error> = v403 |> Error
            let _run_target_args'_v410 = v418 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v419 : Result<std_path_PathBuf, std_io_Error> = v403 |> Error
            let _run_target_args'_v410 = v419 
            #endif
#else
            let v420 : Result<std_path_PathBuf, std_io_Error> = v403 |> Error
            let _run_target_args'_v410 = v420 
            #endif
            let v421 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v410 
            v421
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
    let v23 : US5 = US5_1
    let v24 : US5 = v9 |> Option.defaultValue v23 
    let v28 : string = method48(v3)
    let v29 : bool = v2 >= 11uy
    if v29 then
        let v30 : string = $"file_system.read_link / "
        let v31 : string = $"path: {v0} / n: {v2} / path': {v0} / name: {v4}"
        let v32 : string = v30 + v31 
        (* run_target_args'
        let v37 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v38 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v39 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v32 v38 
        let _run_target_args'_v37 = v39 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v40 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v41 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v32 v40 
        let _run_target_args'_v37 = v41 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v42 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v43 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v32 v42 
        let _run_target_args'_v37 = v43 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v45 : std_io_Error = v32 |> unbox<std_io_Error>
        let _run_target_args'_v37 = v45 
        #endif
#if FABLE_COMPILER_PYTHON
        let v49 : std_io_Error = v32 |> unbox<std_io_Error>
        let _run_target_args'_v37 = v49 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v53 : std_io_Error = v32 |> unbox<std_io_Error>
        let _run_target_args'_v37 = v53 
        #endif
#else
        let v57 : std_io_Error = v32 |> unbox<std_io_Error>
        let _run_target_args'_v37 = v57 
        #endif
        let v60 : std_io_Error = _run_target_args'_v37 
        (* run_target_args'
        let v67 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v68 : string = "Err($0)"
        let v69 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v60 v68 
        let _run_target_args'_v67 = v69 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v70 : string = "Err($0)"
        let v71 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v60 v70 
        let _run_target_args'_v67 = v71 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v72 : string = "Err($0)"
        let v73 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v60 v72 
        let _run_target_args'_v67 = v73 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v74 : Result<std_path_PathBuf, std_io_Error> = v60 |> Error
        let _run_target_args'_v67 = v74 
        #endif
#if FABLE_COMPILER_PYTHON
        let v75 : Result<std_path_PathBuf, std_io_Error> = v60 |> Error
        let _run_target_args'_v67 = v75 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v76 : Result<std_path_PathBuf, std_io_Error> = v60 |> Error
        let _run_target_args'_v67 = v76 
        #endif
#else
        let v77 : Result<std_path_PathBuf, std_io_Error> = v60 |> Error
        let _run_target_args'_v67 = v77 
        #endif
        let v78 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v67 
        v78
    else
        match v24 with
        | US5_0(v81) -> (* Some *)
            let v84 : string = ""
            let v85 : bool = v0 <> v84 
            if v85 then
                let v88 : uint8 = v2 + 1uy
                let v89 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v88
                let v90 : Result<std_path_PathBuf, std_io_Error> = v89 v81
                let v91 : (std_io_Error -> string) = method41()
                (* run_target_args'
                let v93 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v94 : string = "$0.map_err(|x| $1(x))"
                let v95 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v90, v91) v94 
                let _run_target_args'_v93 = v95 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v96 : string = "$0.map_err(|x| $1(x))"
                let v97 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v90, v91) v96 
                let _run_target_args'_v93 = v97 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v98 : string = "$0.map_err(|x| $1(x))"
                let v99 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v90, v91) v98 
                let _run_target_args'_v93 = v99 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v100 : Result<std_path_PathBuf, string> = match v90 with Ok x -> Ok x | Error x -> Error (v91 x)
                let _run_target_args'_v93 = v100 
                #endif
#if FABLE_COMPILER_PYTHON
                let v101 : Result<std_path_PathBuf, string> = match v90 with Ok x -> Ok x | Error x -> Error (v91 x)
                let _run_target_args'_v93 = v101 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v102 : Result<std_path_PathBuf, string> = match v90 with Ok x -> Ok x | Error x -> Error (v91 x)
                let _run_target_args'_v93 = v102 
                #endif
#else
                let v103 : Result<std_path_PathBuf, string> = match v90 with Ok x -> Ok x | Error x -> Error (v91 x)
                let _run_target_args'_v93 = v103 
                #endif
                let v104 : Result<std_path_PathBuf, string> = _run_target_args'_v93 
                let v107 : (std_path_PathBuf -> US9) = method43()
                let v108 : (string -> US9) = method44()
                let v110 : US9 = match v104 with Ok x -> v107 x | Error x -> v108 x
                match v110 with
                | US9_1(v266) -> (* Error *)
                    let v267 : string = $"file_system.read_link / "
                    let v268 : string = $"error': {v266} / error: {v28} / name: {v4}"
                    let v269 : string = v267 + v268 
                    (* run_target_args'
                    let v274 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v275 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v276 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v269 v275 
                    let _run_target_args'_v274 = v276 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v277 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v278 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v269 v277 
                    let _run_target_args'_v274 = v278 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v279 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v280 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v269 v279 
                    let _run_target_args'_v274 = v280 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v282 : std_io_Error = v269 |> unbox<std_io_Error>
                    let _run_target_args'_v274 = v282 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v286 : std_io_Error = v269 |> unbox<std_io_Error>
                    let _run_target_args'_v274 = v286 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v290 : std_io_Error = v269 |> unbox<std_io_Error>
                    let _run_target_args'_v274 = v290 
                    #endif
#else
                    let v294 : std_io_Error = v269 |> unbox<std_io_Error>
                    let _run_target_args'_v274 = v294 
                    #endif
                    let v297 : std_io_Error = _run_target_args'_v274 
                    (* run_target_args'
                    let v304 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v305 : string = "Err($0)"
                    let v306 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v297 v305 
                    let _run_target_args'_v304 = v306 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v307 : string = "Err($0)"
                    let v308 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v297 v307 
                    let _run_target_args'_v304 = v308 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v309 : string = "Err($0)"
                    let v310 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v297 v309 
                    let _run_target_args'_v304 = v310 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v311 : Result<std_path_PathBuf, std_io_Error> = v297 |> Error
                    let _run_target_args'_v304 = v311 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v312 : Result<std_path_PathBuf, std_io_Error> = v297 |> Error
                    let _run_target_args'_v304 = v312 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v313 : Result<std_path_PathBuf, std_io_Error> = v297 |> Error
                    let _run_target_args'_v304 = v313 
                    #endif
#else
                    let v314 : Result<std_path_PathBuf, std_io_Error> = v297 |> Error
                    let _run_target_args'_v304 = v314 
                    #endif
                    let v315 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v304 
                    v315
                | US9_0(v113) -> (* Ok *)
                    (* run_target_args'
                    let v118 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v119 : string = "$0.display()"
                    let v120 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v113 v119 
                    let _run_target_args'_v118 = v120 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v121 : string = "$0.display()"
                    let v122 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v113 v121 
                    let _run_target_args'_v118 = v122 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v123 : string = "$0.display()"
                    let v124 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v113 v123 
                    let _run_target_args'_v118 = v124 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v126 : std_path_Display = v113 |> unbox<std_path_Display>
                    let _run_target_args'_v118 = v126 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v130 : std_path_Display = v113 |> unbox<std_path_Display>
                    let _run_target_args'_v118 = v130 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v134 : std_path_Display = v113 |> unbox<std_path_Display>
                    let _run_target_args'_v118 = v134 
                    #endif
#else
                    let v138 : std_path_Display = v113 |> unbox<std_path_Display>
                    let _run_target_args'_v118 = v138 
                    #endif
                    let v141 : std_path_Display = _run_target_args'_v118 
                    let v148 : string = v141 |> string 
                    let v151 : string = method28(v148, v4)
                    (* run_target_args'
                    let v156 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v157 : string = "&*$0"
                    let v158 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v151 v157 
                    let _run_target_args'_v156 = v158 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v159 : string = "&*$0"
                    let v160 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v151 v159 
                    let _run_target_args'_v156 = v160 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v161 : string = "&*$0"
                    let v162 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v151 v161 
                    let _run_target_args'_v156 = v162 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v164 : Ref<Str> = v151 |> unbox<Ref<Str>>
                    let _run_target_args'_v156 = v164 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v168 : Ref<Str> = v151 |> unbox<Ref<Str>>
                    let _run_target_args'_v156 = v168 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v172 : Ref<Str> = v151 |> unbox<Ref<Str>>
                    let _run_target_args'_v156 = v172 
                    #endif
#else
                    let v176 : Ref<Str> = v151 |> unbox<Ref<Str>>
                    let _run_target_args'_v156 = v176 
                    #endif
                    let v179 : Ref<Str> = _run_target_args'_v156 
                    (* run_target_args'
                    let v189 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v190 : string = "String::from($0)"
                    let v191 : std_string_String = Fable.Core.RustInterop.emitRustExpr v179 v190 
                    let _run_target_args'_v189 = v191 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v192 : string = "String::from($0)"
                    let v193 : std_string_String = Fable.Core.RustInterop.emitRustExpr v179 v192 
                    let _run_target_args'_v189 = v193 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v194 : string = "String::from($0)"
                    let v195 : std_string_String = Fable.Core.RustInterop.emitRustExpr v179 v194 
                    let _run_target_args'_v189 = v195 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v197 : std_string_String = v179 |> unbox<std_string_String>
                    let _run_target_args'_v189 = v197 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v201 : std_string_String = v179 |> unbox<std_string_String>
                    let _run_target_args'_v189 = v201 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v205 : std_string_String = v179 |> unbox<std_string_String>
                    let _run_target_args'_v189 = v205 
                    #endif
#else
                    let v209 : std_string_String = v179 |> unbox<std_string_String>
                    let _run_target_args'_v189 = v209 
                    #endif
                    let v212 : std_string_String = _run_target_args'_v189 
                    (* run_target_args'
                    let v222 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v223 : string = "std::path::PathBuf::from($0)"
                    let v224 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v212 v223 
                    let _run_target_args'_v222 = v224 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v225 : string = "std::path::PathBuf::from($0)"
                    let v226 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v212 v225 
                    let _run_target_args'_v222 = v226 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v227 : string = "std::path::PathBuf::from($0)"
                    let v228 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v212 v227 
                    let _run_target_args'_v222 = v228 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v230 : std_path_PathBuf = v212 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v222 = v230 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v234 : std_path_PathBuf = v212 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v222 = v234 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v238 : std_path_PathBuf = v212 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v222 = v238 
                    #endif
#else
                    let v242 : std_path_PathBuf = v212 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v222 = v242 
                    #endif
                    let v245 : std_path_PathBuf = _run_target_args'_v222 
                    (* run_target_args'
                    let v252 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v253 : string = "Ok($0)"
                    let v254 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v245 v253 
                    let _run_target_args'_v252 = v254 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v255 : string = "Ok($0)"
                    let v256 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v245 v255 
                    let _run_target_args'_v252 = v256 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v257 : string = "Ok($0)"
                    let v258 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v245 v257 
                    let _run_target_args'_v252 = v258 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v259 : Result<std_path_PathBuf, std_io_Error> = v245 |> Ok
                    let _run_target_args'_v252 = v259 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v260 : Result<std_path_PathBuf, std_io_Error> = v245 |> Ok
                    let _run_target_args'_v252 = v260 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v261 : Result<std_path_PathBuf, std_io_Error> = v245 |> Ok
                    let _run_target_args'_v252 = v261 
                    #endif
#else
                    let v262 : Result<std_path_PathBuf, std_io_Error> = v245 |> Ok
                    let _run_target_args'_v252 = v262 
                    #endif
                    let v263 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v252 
                    v263
            else
                let v320 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v321 : string = $"path: {v0} / error: {v28} / path': {v0} / name: {v4}"
                let v322 : string = v320 + v321 
                (* run_target_args'
                let v327 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v328 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v329 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v322 v328 
                let _run_target_args'_v327 = v329 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v330 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v331 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v322 v330 
                let _run_target_args'_v327 = v331 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v332 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v333 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v322 v332 
                let _run_target_args'_v327 = v333 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v335 : std_io_Error = v322 |> unbox<std_io_Error>
                let _run_target_args'_v327 = v335 
                #endif
#if FABLE_COMPILER_PYTHON
                let v339 : std_io_Error = v322 |> unbox<std_io_Error>
                let _run_target_args'_v327 = v339 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v343 : std_io_Error = v322 |> unbox<std_io_Error>
                let _run_target_args'_v327 = v343 
                #endif
#else
                let v347 : std_io_Error = v322 |> unbox<std_io_Error>
                let _run_target_args'_v327 = v347 
                #endif
                let v350 : std_io_Error = _run_target_args'_v327 
                (* run_target_args'
                let v357 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v358 : string = "Err($0)"
                let v359 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v350 v358 
                let _run_target_args'_v357 = v359 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v360 : string = "Err($0)"
                let v361 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v350 v360 
                let _run_target_args'_v357 = v361 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v362 : string = "Err($0)"
                let v363 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v350 v362 
                let _run_target_args'_v357 = v363 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v364 : Result<std_path_PathBuf, std_io_Error> = v350 |> Error
                let _run_target_args'_v357 = v364 
                #endif
#if FABLE_COMPILER_PYTHON
                let v365 : Result<std_path_PathBuf, std_io_Error> = v350 |> Error
                let _run_target_args'_v357 = v365 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v366 : Result<std_path_PathBuf, std_io_Error> = v350 |> Error
                let _run_target_args'_v357 = v366 
                #endif
#else
                let v367 : Result<std_path_PathBuf, std_io_Error> = v350 |> Error
                let _run_target_args'_v357 = v367 
                #endif
                let v368 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v357 
                v368
        | _ ->
            let v372 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v373 : string = $"path: {v0} / error: {v28} / path': {v0} / name: {v4}"
            let v374 : string = v372 + v373 
            (* run_target_args'
            let v379 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v380 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v381 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v374 v380 
            let _run_target_args'_v379 = v381 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v382 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v383 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v374 v382 
            let _run_target_args'_v379 = v383 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v384 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v385 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v374 v384 
            let _run_target_args'_v379 = v385 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v387 : std_io_Error = v374 |> unbox<std_io_Error>
            let _run_target_args'_v379 = v387 
            #endif
#if FABLE_COMPILER_PYTHON
            let v391 : std_io_Error = v374 |> unbox<std_io_Error>
            let _run_target_args'_v379 = v391 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v395 : std_io_Error = v374 |> unbox<std_io_Error>
            let _run_target_args'_v379 = v395 
            #endif
#else
            let v399 : std_io_Error = v374 |> unbox<std_io_Error>
            let _run_target_args'_v379 = v399 
            #endif
            let v402 : std_io_Error = _run_target_args'_v379 
            (* run_target_args'
            let v409 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v410 : string = "Err($0)"
            let v411 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v402 v410 
            let _run_target_args'_v409 = v411 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v412 : string = "Err($0)"
            let v413 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v402 v412 
            let _run_target_args'_v409 = v413 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v414 : string = "Err($0)"
            let v415 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v402 v414 
            let _run_target_args'_v409 = v415 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v416 : Result<std_path_PathBuf, std_io_Error> = v402 |> Error
            let _run_target_args'_v409 = v416 
            #endif
#if FABLE_COMPILER_PYTHON
            let v417 : Result<std_path_PathBuf, std_io_Error> = v402 |> Error
            let _run_target_args'_v409 = v417 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v418 : Result<std_path_PathBuf, std_io_Error> = v402 |> Error
            let _run_target_args'_v409 = v418 
            #endif
#else
            let v419 : Result<std_path_PathBuf, std_io_Error> = v402 |> Error
            let _run_target_args'_v409 = v419 
            #endif
            let v420 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v409 
            v420
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
    let v24 : US5 = US5_1
    let v25 : US5 = v10 |> Option.defaultValue v24 
    let v29 : string = method42(v3)
    let v30 : bool = v2 >= 11uy
    if v30 then
        let v31 : string = $"file_system.read_link / "
        let v32 : string = $"path: {v0} / n: {v2} / path': {v4} / name: {v5}"
        let v33 : string = v31 + v32 
        (* run_target_args'
        let v38 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v39 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v40 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v33 v39 
        let _run_target_args'_v38 = v40 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v41 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v42 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v33 v41 
        let _run_target_args'_v38 = v42 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v43 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v44 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v33 v43 
        let _run_target_args'_v38 = v44 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v46 : std_io_Error = v33 |> unbox<std_io_Error>
        let _run_target_args'_v38 = v46 
        #endif
#if FABLE_COMPILER_PYTHON
        let v50 : std_io_Error = v33 |> unbox<std_io_Error>
        let _run_target_args'_v38 = v50 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v54 : std_io_Error = v33 |> unbox<std_io_Error>
        let _run_target_args'_v38 = v54 
        #endif
#else
        let v58 : std_io_Error = v33 |> unbox<std_io_Error>
        let _run_target_args'_v38 = v58 
        #endif
        let v61 : std_io_Error = _run_target_args'_v38 
        (* run_target_args'
        let v68 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v69 : string = "Err($0)"
        let v70 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v61 v69 
        let _run_target_args'_v68 = v70 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v71 : string = "Err($0)"
        let v72 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v61 v71 
        let _run_target_args'_v68 = v72 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v73 : string = "Err($0)"
        let v74 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v61 v73 
        let _run_target_args'_v68 = v74 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v75 : Result<std_path_PathBuf, std_io_Error> = v61 |> Error
        let _run_target_args'_v68 = v75 
        #endif
#if FABLE_COMPILER_PYTHON
        let v76 : Result<std_path_PathBuf, std_io_Error> = v61 |> Error
        let _run_target_args'_v68 = v76 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v77 : Result<std_path_PathBuf, std_io_Error> = v61 |> Error
        let _run_target_args'_v68 = v77 
        #endif
#else
        let v78 : Result<std_path_PathBuf, std_io_Error> = v61 |> Error
        let _run_target_args'_v68 = v78 
        #endif
        let v79 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v68 
        v79
    else
        match v25 with
        | US5_0(v82) -> (* Some *)
            let v85 : string = ""
            let v86 : bool = v4 <> v85 
            if v86 then
                let v89 : uint8 = v2 + 1uy
                let v90 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v89
                let v91 : Result<std_path_PathBuf, std_io_Error> = v90 v82
                let v92 : (std_io_Error -> string) = method41()
                (* run_target_args'
                let v94 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v95 : string = "$0.map_err(|x| $1(x))"
                let v96 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v91, v92) v95 
                let _run_target_args'_v94 = v96 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v97 : string = "$0.map_err(|x| $1(x))"
                let v98 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v91, v92) v97 
                let _run_target_args'_v94 = v98 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v99 : string = "$0.map_err(|x| $1(x))"
                let v100 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v91, v92) v99 
                let _run_target_args'_v94 = v100 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v101 : Result<std_path_PathBuf, string> = match v91 with Ok x -> Ok x | Error x -> Error (v92 x)
                let _run_target_args'_v94 = v101 
                #endif
#if FABLE_COMPILER_PYTHON
                let v102 : Result<std_path_PathBuf, string> = match v91 with Ok x -> Ok x | Error x -> Error (v92 x)
                let _run_target_args'_v94 = v102 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v103 : Result<std_path_PathBuf, string> = match v91 with Ok x -> Ok x | Error x -> Error (v92 x)
                let _run_target_args'_v94 = v103 
                #endif
#else
                let v104 : Result<std_path_PathBuf, string> = match v91 with Ok x -> Ok x | Error x -> Error (v92 x)
                let _run_target_args'_v94 = v104 
                #endif
                let v105 : Result<std_path_PathBuf, string> = _run_target_args'_v94 
                let v108 : (std_path_PathBuf -> US9) = method43()
                let v109 : (string -> US9) = method44()
                let v111 : US9 = match v105 with Ok x -> v108 x | Error x -> v109 x
                match v111 with
                | US9_1(v267) -> (* Error *)
                    let v268 : string = $"file_system.read_link / "
                    let v269 : string = $"error': {v267} / error: {v29} / name: {v5}"
                    let v270 : string = v268 + v269 
                    (* run_target_args'
                    let v275 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v276 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v277 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v270 v276 
                    let _run_target_args'_v275 = v277 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v278 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v279 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v270 v278 
                    let _run_target_args'_v275 = v279 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v280 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v281 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v270 v280 
                    let _run_target_args'_v275 = v281 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v283 : std_io_Error = v270 |> unbox<std_io_Error>
                    let _run_target_args'_v275 = v283 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v287 : std_io_Error = v270 |> unbox<std_io_Error>
                    let _run_target_args'_v275 = v287 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v291 : std_io_Error = v270 |> unbox<std_io_Error>
                    let _run_target_args'_v275 = v291 
                    #endif
#else
                    let v295 : std_io_Error = v270 |> unbox<std_io_Error>
                    let _run_target_args'_v275 = v295 
                    #endif
                    let v298 : std_io_Error = _run_target_args'_v275 
                    (* run_target_args'
                    let v305 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v306 : string = "Err($0)"
                    let v307 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v298 v306 
                    let _run_target_args'_v305 = v307 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v308 : string = "Err($0)"
                    let v309 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v298 v308 
                    let _run_target_args'_v305 = v309 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v310 : string = "Err($0)"
                    let v311 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v298 v310 
                    let _run_target_args'_v305 = v311 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v312 : Result<std_path_PathBuf, std_io_Error> = v298 |> Error
                    let _run_target_args'_v305 = v312 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v313 : Result<std_path_PathBuf, std_io_Error> = v298 |> Error
                    let _run_target_args'_v305 = v313 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v314 : Result<std_path_PathBuf, std_io_Error> = v298 |> Error
                    let _run_target_args'_v305 = v314 
                    #endif
#else
                    let v315 : Result<std_path_PathBuf, std_io_Error> = v298 |> Error
                    let _run_target_args'_v305 = v315 
                    #endif
                    let v316 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v305 
                    v316
                | US9_0(v114) -> (* Ok *)
                    (* run_target_args'
                    let v119 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v120 : string = "$0.display()"
                    let v121 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v114 v120 
                    let _run_target_args'_v119 = v121 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v122 : string = "$0.display()"
                    let v123 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v114 v122 
                    let _run_target_args'_v119 = v123 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v124 : string = "$0.display()"
                    let v125 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v114 v124 
                    let _run_target_args'_v119 = v125 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v127 : std_path_Display = v114 |> unbox<std_path_Display>
                    let _run_target_args'_v119 = v127 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v131 : std_path_Display = v114 |> unbox<std_path_Display>
                    let _run_target_args'_v119 = v131 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v135 : std_path_Display = v114 |> unbox<std_path_Display>
                    let _run_target_args'_v119 = v135 
                    #endif
#else
                    let v139 : std_path_Display = v114 |> unbox<std_path_Display>
                    let _run_target_args'_v119 = v139 
                    #endif
                    let v142 : std_path_Display = _run_target_args'_v119 
                    let v149 : string = v142 |> string 
                    let v152 : string = method28(v149, v5)
                    (* run_target_args'
                    let v157 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v158 : string = "&*$0"
                    let v159 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v152 v158 
                    let _run_target_args'_v157 = v159 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v160 : string = "&*$0"
                    let v161 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v152 v160 
                    let _run_target_args'_v157 = v161 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v162 : string = "&*$0"
                    let v163 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v152 v162 
                    let _run_target_args'_v157 = v163 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v165 : Ref<Str> = v152 |> unbox<Ref<Str>>
                    let _run_target_args'_v157 = v165 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v169 : Ref<Str> = v152 |> unbox<Ref<Str>>
                    let _run_target_args'_v157 = v169 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v173 : Ref<Str> = v152 |> unbox<Ref<Str>>
                    let _run_target_args'_v157 = v173 
                    #endif
#else
                    let v177 : Ref<Str> = v152 |> unbox<Ref<Str>>
                    let _run_target_args'_v157 = v177 
                    #endif
                    let v180 : Ref<Str> = _run_target_args'_v157 
                    (* run_target_args'
                    let v190 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v191 : string = "String::from($0)"
                    let v192 : std_string_String = Fable.Core.RustInterop.emitRustExpr v180 v191 
                    let _run_target_args'_v190 = v192 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v193 : string = "String::from($0)"
                    let v194 : std_string_String = Fable.Core.RustInterop.emitRustExpr v180 v193 
                    let _run_target_args'_v190 = v194 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v195 : string = "String::from($0)"
                    let v196 : std_string_String = Fable.Core.RustInterop.emitRustExpr v180 v195 
                    let _run_target_args'_v190 = v196 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v198 : std_string_String = v180 |> unbox<std_string_String>
                    let _run_target_args'_v190 = v198 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v202 : std_string_String = v180 |> unbox<std_string_String>
                    let _run_target_args'_v190 = v202 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v206 : std_string_String = v180 |> unbox<std_string_String>
                    let _run_target_args'_v190 = v206 
                    #endif
#else
                    let v210 : std_string_String = v180 |> unbox<std_string_String>
                    let _run_target_args'_v190 = v210 
                    #endif
                    let v213 : std_string_String = _run_target_args'_v190 
                    (* run_target_args'
                    let v223 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v224 : string = "std::path::PathBuf::from($0)"
                    let v225 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v213 v224 
                    let _run_target_args'_v223 = v225 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v226 : string = "std::path::PathBuf::from($0)"
                    let v227 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v213 v226 
                    let _run_target_args'_v223 = v227 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v228 : string = "std::path::PathBuf::from($0)"
                    let v229 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v213 v228 
                    let _run_target_args'_v223 = v229 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v231 : std_path_PathBuf = v213 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v223 = v231 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v235 : std_path_PathBuf = v213 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v223 = v235 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v239 : std_path_PathBuf = v213 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v223 = v239 
                    #endif
#else
                    let v243 : std_path_PathBuf = v213 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v223 = v243 
                    #endif
                    let v246 : std_path_PathBuf = _run_target_args'_v223 
                    (* run_target_args'
                    let v253 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v254 : string = "Ok($0)"
                    let v255 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v246 v254 
                    let _run_target_args'_v253 = v255 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v256 : string = "Ok($0)"
                    let v257 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v246 v256 
                    let _run_target_args'_v253 = v257 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v258 : string = "Ok($0)"
                    let v259 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v246 v258 
                    let _run_target_args'_v253 = v259 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v260 : Result<std_path_PathBuf, std_io_Error> = v246 |> Ok
                    let _run_target_args'_v253 = v260 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v261 : Result<std_path_PathBuf, std_io_Error> = v246 |> Ok
                    let _run_target_args'_v253 = v261 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v262 : Result<std_path_PathBuf, std_io_Error> = v246 |> Ok
                    let _run_target_args'_v253 = v262 
                    #endif
#else
                    let v263 : Result<std_path_PathBuf, std_io_Error> = v246 |> Ok
                    let _run_target_args'_v253 = v263 
                    #endif
                    let v264 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v253 
                    v264
            else
                let v321 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v322 : string = $"path: {v0} / error: {v29} / path': {v4} / name: {v5}"
                let v323 : string = v321 + v322 
                (* run_target_args'
                let v328 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v329 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v330 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v323 v329 
                let _run_target_args'_v328 = v330 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v331 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v332 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v323 v331 
                let _run_target_args'_v328 = v332 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v333 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v334 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v323 v333 
                let _run_target_args'_v328 = v334 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v336 : std_io_Error = v323 |> unbox<std_io_Error>
                let _run_target_args'_v328 = v336 
                #endif
#if FABLE_COMPILER_PYTHON
                let v340 : std_io_Error = v323 |> unbox<std_io_Error>
                let _run_target_args'_v328 = v340 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v344 : std_io_Error = v323 |> unbox<std_io_Error>
                let _run_target_args'_v328 = v344 
                #endif
#else
                let v348 : std_io_Error = v323 |> unbox<std_io_Error>
                let _run_target_args'_v328 = v348 
                #endif
                let v351 : std_io_Error = _run_target_args'_v328 
                (* run_target_args'
                let v358 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v359 : string = "Err($0)"
                let v360 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v351 v359 
                let _run_target_args'_v358 = v360 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v361 : string = "Err($0)"
                let v362 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v351 v361 
                let _run_target_args'_v358 = v362 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v363 : string = "Err($0)"
                let v364 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v351 v363 
                let _run_target_args'_v358 = v364 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v365 : Result<std_path_PathBuf, std_io_Error> = v351 |> Error
                let _run_target_args'_v358 = v365 
                #endif
#if FABLE_COMPILER_PYTHON
                let v366 : Result<std_path_PathBuf, std_io_Error> = v351 |> Error
                let _run_target_args'_v358 = v366 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v367 : Result<std_path_PathBuf, std_io_Error> = v351 |> Error
                let _run_target_args'_v358 = v367 
                #endif
#else
                let v368 : Result<std_path_PathBuf, std_io_Error> = v351 |> Error
                let _run_target_args'_v358 = v368 
                #endif
                let v369 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v358 
                v369
        | _ ->
            let v373 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v374 : string = $"path: {v0} / error: {v29} / path': {v4} / name: {v5}"
            let v375 : string = v373 + v374 
            (* run_target_args'
            let v380 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v381 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v382 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v375 v381 
            let _run_target_args'_v380 = v382 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v383 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v384 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v375 v383 
            let _run_target_args'_v380 = v384 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v385 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v386 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v375 v385 
            let _run_target_args'_v380 = v386 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v388 : std_io_Error = v375 |> unbox<std_io_Error>
            let _run_target_args'_v380 = v388 
            #endif
#if FABLE_COMPILER_PYTHON
            let v392 : std_io_Error = v375 |> unbox<std_io_Error>
            let _run_target_args'_v380 = v392 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v396 : std_io_Error = v375 |> unbox<std_io_Error>
            let _run_target_args'_v380 = v396 
            #endif
#else
            let v400 : std_io_Error = v375 |> unbox<std_io_Error>
            let _run_target_args'_v380 = v400 
            #endif
            let v403 : std_io_Error = _run_target_args'_v380 
            (* run_target_args'
            let v410 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v411 : string = "Err($0)"
            let v412 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v403 v411 
            let _run_target_args'_v410 = v412 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v413 : string = "Err($0)"
            let v414 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v403 v413 
            let _run_target_args'_v410 = v414 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v415 : string = "Err($0)"
            let v416 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v403 v415 
            let _run_target_args'_v410 = v416 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v417 : Result<std_path_PathBuf, std_io_Error> = v403 |> Error
            let _run_target_args'_v410 = v417 
            #endif
#if FABLE_COMPILER_PYTHON
            let v418 : Result<std_path_PathBuf, std_io_Error> = v403 |> Error
            let _run_target_args'_v410 = v418 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v419 : Result<std_path_PathBuf, std_io_Error> = v403 |> Error
            let _run_target_args'_v410 = v419 
            #endif
#else
            let v420 : Result<std_path_PathBuf, std_io_Error> = v403 |> Error
            let _run_target_args'_v410 = v420 
            #endif
            let v421 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v410 
            v421
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
    let v23 : US5 = US5_1
    let v24 : US5 = v9 |> Option.defaultValue v23 
    let v28 : string = method42(v3)
    let v29 : bool = v2 >= 11uy
    if v29 then
        let v30 : string = $"file_system.read_link / "
        let v31 : string = $"path: {v0} / n: {v2} / path': {v0} / name: {v4}"
        let v32 : string = v30 + v31 
        (* run_target_args'
        let v37 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v38 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v39 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v32 v38 
        let _run_target_args'_v37 = v39 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v40 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v41 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v32 v40 
        let _run_target_args'_v37 = v41 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v42 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v43 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v32 v42 
        let _run_target_args'_v37 = v43 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v45 : std_io_Error = v32 |> unbox<std_io_Error>
        let _run_target_args'_v37 = v45 
        #endif
#if FABLE_COMPILER_PYTHON
        let v49 : std_io_Error = v32 |> unbox<std_io_Error>
        let _run_target_args'_v37 = v49 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v53 : std_io_Error = v32 |> unbox<std_io_Error>
        let _run_target_args'_v37 = v53 
        #endif
#else
        let v57 : std_io_Error = v32 |> unbox<std_io_Error>
        let _run_target_args'_v37 = v57 
        #endif
        let v60 : std_io_Error = _run_target_args'_v37 
        (* run_target_args'
        let v67 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v68 : string = "Err($0)"
        let v69 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v60 v68 
        let _run_target_args'_v67 = v69 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v70 : string = "Err($0)"
        let v71 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v60 v70 
        let _run_target_args'_v67 = v71 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v72 : string = "Err($0)"
        let v73 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v60 v72 
        let _run_target_args'_v67 = v73 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v74 : Result<std_path_PathBuf, std_io_Error> = v60 |> Error
        let _run_target_args'_v67 = v74 
        #endif
#if FABLE_COMPILER_PYTHON
        let v75 : Result<std_path_PathBuf, std_io_Error> = v60 |> Error
        let _run_target_args'_v67 = v75 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v76 : Result<std_path_PathBuf, std_io_Error> = v60 |> Error
        let _run_target_args'_v67 = v76 
        #endif
#else
        let v77 : Result<std_path_PathBuf, std_io_Error> = v60 |> Error
        let _run_target_args'_v67 = v77 
        #endif
        let v78 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v67 
        v78
    else
        match v24 with
        | US5_0(v81) -> (* Some *)
            let v84 : string = ""
            let v85 : bool = v0 <> v84 
            if v85 then
                let v88 : uint8 = v2 + 1uy
                let v89 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v88
                let v90 : Result<std_path_PathBuf, std_io_Error> = v89 v81
                let v91 : (std_io_Error -> string) = method41()
                (* run_target_args'
                let v93 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v94 : string = "$0.map_err(|x| $1(x))"
                let v95 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v90, v91) v94 
                let _run_target_args'_v93 = v95 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v96 : string = "$0.map_err(|x| $1(x))"
                let v97 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v90, v91) v96 
                let _run_target_args'_v93 = v97 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v98 : string = "$0.map_err(|x| $1(x))"
                let v99 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v90, v91) v98 
                let _run_target_args'_v93 = v99 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v100 : Result<std_path_PathBuf, string> = match v90 with Ok x -> Ok x | Error x -> Error (v91 x)
                let _run_target_args'_v93 = v100 
                #endif
#if FABLE_COMPILER_PYTHON
                let v101 : Result<std_path_PathBuf, string> = match v90 with Ok x -> Ok x | Error x -> Error (v91 x)
                let _run_target_args'_v93 = v101 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v102 : Result<std_path_PathBuf, string> = match v90 with Ok x -> Ok x | Error x -> Error (v91 x)
                let _run_target_args'_v93 = v102 
                #endif
#else
                let v103 : Result<std_path_PathBuf, string> = match v90 with Ok x -> Ok x | Error x -> Error (v91 x)
                let _run_target_args'_v93 = v103 
                #endif
                let v104 : Result<std_path_PathBuf, string> = _run_target_args'_v93 
                let v107 : (std_path_PathBuf -> US9) = method43()
                let v108 : (string -> US9) = method44()
                let v110 : US9 = match v104 with Ok x -> v107 x | Error x -> v108 x
                match v110 with
                | US9_1(v266) -> (* Error *)
                    let v267 : string = $"file_system.read_link / "
                    let v268 : string = $"error': {v266} / error: {v28} / name: {v4}"
                    let v269 : string = v267 + v268 
                    (* run_target_args'
                    let v274 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v275 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v276 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v269 v275 
                    let _run_target_args'_v274 = v276 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v277 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v278 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v269 v277 
                    let _run_target_args'_v274 = v278 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v279 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v280 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v269 v279 
                    let _run_target_args'_v274 = v280 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v282 : std_io_Error = v269 |> unbox<std_io_Error>
                    let _run_target_args'_v274 = v282 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v286 : std_io_Error = v269 |> unbox<std_io_Error>
                    let _run_target_args'_v274 = v286 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v290 : std_io_Error = v269 |> unbox<std_io_Error>
                    let _run_target_args'_v274 = v290 
                    #endif
#else
                    let v294 : std_io_Error = v269 |> unbox<std_io_Error>
                    let _run_target_args'_v274 = v294 
                    #endif
                    let v297 : std_io_Error = _run_target_args'_v274 
                    (* run_target_args'
                    let v304 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v305 : string = "Err($0)"
                    let v306 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v297 v305 
                    let _run_target_args'_v304 = v306 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v307 : string = "Err($0)"
                    let v308 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v297 v307 
                    let _run_target_args'_v304 = v308 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v309 : string = "Err($0)"
                    let v310 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v297 v309 
                    let _run_target_args'_v304 = v310 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v311 : Result<std_path_PathBuf, std_io_Error> = v297 |> Error
                    let _run_target_args'_v304 = v311 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v312 : Result<std_path_PathBuf, std_io_Error> = v297 |> Error
                    let _run_target_args'_v304 = v312 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v313 : Result<std_path_PathBuf, std_io_Error> = v297 |> Error
                    let _run_target_args'_v304 = v313 
                    #endif
#else
                    let v314 : Result<std_path_PathBuf, std_io_Error> = v297 |> Error
                    let _run_target_args'_v304 = v314 
                    #endif
                    let v315 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v304 
                    v315
                | US9_0(v113) -> (* Ok *)
                    (* run_target_args'
                    let v118 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v119 : string = "$0.display()"
                    let v120 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v113 v119 
                    let _run_target_args'_v118 = v120 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v121 : string = "$0.display()"
                    let v122 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v113 v121 
                    let _run_target_args'_v118 = v122 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v123 : string = "$0.display()"
                    let v124 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v113 v123 
                    let _run_target_args'_v118 = v124 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v126 : std_path_Display = v113 |> unbox<std_path_Display>
                    let _run_target_args'_v118 = v126 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v130 : std_path_Display = v113 |> unbox<std_path_Display>
                    let _run_target_args'_v118 = v130 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v134 : std_path_Display = v113 |> unbox<std_path_Display>
                    let _run_target_args'_v118 = v134 
                    #endif
#else
                    let v138 : std_path_Display = v113 |> unbox<std_path_Display>
                    let _run_target_args'_v118 = v138 
                    #endif
                    let v141 : std_path_Display = _run_target_args'_v118 
                    let v148 : string = v141 |> string 
                    let v151 : string = method28(v148, v4)
                    (* run_target_args'
                    let v156 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v157 : string = "&*$0"
                    let v158 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v151 v157 
                    let _run_target_args'_v156 = v158 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v159 : string = "&*$0"
                    let v160 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v151 v159 
                    let _run_target_args'_v156 = v160 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v161 : string = "&*$0"
                    let v162 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v151 v161 
                    let _run_target_args'_v156 = v162 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v164 : Ref<Str> = v151 |> unbox<Ref<Str>>
                    let _run_target_args'_v156 = v164 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v168 : Ref<Str> = v151 |> unbox<Ref<Str>>
                    let _run_target_args'_v156 = v168 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v172 : Ref<Str> = v151 |> unbox<Ref<Str>>
                    let _run_target_args'_v156 = v172 
                    #endif
#else
                    let v176 : Ref<Str> = v151 |> unbox<Ref<Str>>
                    let _run_target_args'_v156 = v176 
                    #endif
                    let v179 : Ref<Str> = _run_target_args'_v156 
                    (* run_target_args'
                    let v189 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v190 : string = "String::from($0)"
                    let v191 : std_string_String = Fable.Core.RustInterop.emitRustExpr v179 v190 
                    let _run_target_args'_v189 = v191 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v192 : string = "String::from($0)"
                    let v193 : std_string_String = Fable.Core.RustInterop.emitRustExpr v179 v192 
                    let _run_target_args'_v189 = v193 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v194 : string = "String::from($0)"
                    let v195 : std_string_String = Fable.Core.RustInterop.emitRustExpr v179 v194 
                    let _run_target_args'_v189 = v195 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v197 : std_string_String = v179 |> unbox<std_string_String>
                    let _run_target_args'_v189 = v197 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v201 : std_string_String = v179 |> unbox<std_string_String>
                    let _run_target_args'_v189 = v201 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v205 : std_string_String = v179 |> unbox<std_string_String>
                    let _run_target_args'_v189 = v205 
                    #endif
#else
                    let v209 : std_string_String = v179 |> unbox<std_string_String>
                    let _run_target_args'_v189 = v209 
                    #endif
                    let v212 : std_string_String = _run_target_args'_v189 
                    (* run_target_args'
                    let v222 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v223 : string = "std::path::PathBuf::from($0)"
                    let v224 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v212 v223 
                    let _run_target_args'_v222 = v224 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v225 : string = "std::path::PathBuf::from($0)"
                    let v226 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v212 v225 
                    let _run_target_args'_v222 = v226 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v227 : string = "std::path::PathBuf::from($0)"
                    let v228 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v212 v227 
                    let _run_target_args'_v222 = v228 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v230 : std_path_PathBuf = v212 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v222 = v230 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v234 : std_path_PathBuf = v212 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v222 = v234 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v238 : std_path_PathBuf = v212 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v222 = v238 
                    #endif
#else
                    let v242 : std_path_PathBuf = v212 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v222 = v242 
                    #endif
                    let v245 : std_path_PathBuf = _run_target_args'_v222 
                    (* run_target_args'
                    let v252 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v253 : string = "Ok($0)"
                    let v254 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v245 v253 
                    let _run_target_args'_v252 = v254 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v255 : string = "Ok($0)"
                    let v256 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v245 v255 
                    let _run_target_args'_v252 = v256 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v257 : string = "Ok($0)"
                    let v258 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v245 v257 
                    let _run_target_args'_v252 = v258 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v259 : Result<std_path_PathBuf, std_io_Error> = v245 |> Ok
                    let _run_target_args'_v252 = v259 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v260 : Result<std_path_PathBuf, std_io_Error> = v245 |> Ok
                    let _run_target_args'_v252 = v260 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v261 : Result<std_path_PathBuf, std_io_Error> = v245 |> Ok
                    let _run_target_args'_v252 = v261 
                    #endif
#else
                    let v262 : Result<std_path_PathBuf, std_io_Error> = v245 |> Ok
                    let _run_target_args'_v252 = v262 
                    #endif
                    let v263 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v252 
                    v263
            else
                let v320 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v321 : string = $"path: {v0} / error: {v28} / path': {v0} / name: {v4}"
                let v322 : string = v320 + v321 
                (* run_target_args'
                let v327 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v328 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v329 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v322 v328 
                let _run_target_args'_v327 = v329 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v330 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v331 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v322 v330 
                let _run_target_args'_v327 = v331 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v332 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v333 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v322 v332 
                let _run_target_args'_v327 = v333 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v335 : std_io_Error = v322 |> unbox<std_io_Error>
                let _run_target_args'_v327 = v335 
                #endif
#if FABLE_COMPILER_PYTHON
                let v339 : std_io_Error = v322 |> unbox<std_io_Error>
                let _run_target_args'_v327 = v339 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v343 : std_io_Error = v322 |> unbox<std_io_Error>
                let _run_target_args'_v327 = v343 
                #endif
#else
                let v347 : std_io_Error = v322 |> unbox<std_io_Error>
                let _run_target_args'_v327 = v347 
                #endif
                let v350 : std_io_Error = _run_target_args'_v327 
                (* run_target_args'
                let v357 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v358 : string = "Err($0)"
                let v359 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v350 v358 
                let _run_target_args'_v357 = v359 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v360 : string = "Err($0)"
                let v361 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v350 v360 
                let _run_target_args'_v357 = v361 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v362 : string = "Err($0)"
                let v363 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v350 v362 
                let _run_target_args'_v357 = v363 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v364 : Result<std_path_PathBuf, std_io_Error> = v350 |> Error
                let _run_target_args'_v357 = v364 
                #endif
#if FABLE_COMPILER_PYTHON
                let v365 : Result<std_path_PathBuf, std_io_Error> = v350 |> Error
                let _run_target_args'_v357 = v365 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v366 : Result<std_path_PathBuf, std_io_Error> = v350 |> Error
                let _run_target_args'_v357 = v366 
                #endif
#else
                let v367 : Result<std_path_PathBuf, std_io_Error> = v350 |> Error
                let _run_target_args'_v357 = v367 
                #endif
                let v368 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v357 
                v368
        | _ ->
            let v372 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v373 : string = $"path: {v0} / error: {v28} / path': {v0} / name: {v4}"
            let v374 : string = v372 + v373 
            (* run_target_args'
            let v379 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v380 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v381 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v374 v380 
            let _run_target_args'_v379 = v381 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v382 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v383 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v374 v382 
            let _run_target_args'_v379 = v383 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v384 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v385 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v374 v384 
            let _run_target_args'_v379 = v385 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v387 : std_io_Error = v374 |> unbox<std_io_Error>
            let _run_target_args'_v379 = v387 
            #endif
#if FABLE_COMPILER_PYTHON
            let v391 : std_io_Error = v374 |> unbox<std_io_Error>
            let _run_target_args'_v379 = v391 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v395 : std_io_Error = v374 |> unbox<std_io_Error>
            let _run_target_args'_v379 = v395 
            #endif
#else
            let v399 : std_io_Error = v374 |> unbox<std_io_Error>
            let _run_target_args'_v379 = v399 
            #endif
            let v402 : std_io_Error = _run_target_args'_v379 
            (* run_target_args'
            let v409 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v410 : string = "Err($0)"
            let v411 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v402 v410 
            let _run_target_args'_v409 = v411 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v412 : string = "Err($0)"
            let v413 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v402 v412 
            let _run_target_args'_v409 = v413 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v414 : string = "Err($0)"
            let v415 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v402 v414 
            let _run_target_args'_v409 = v415 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v416 : Result<std_path_PathBuf, std_io_Error> = v402 |> Error
            let _run_target_args'_v409 = v416 
            #endif
#if FABLE_COMPILER_PYTHON
            let v417 : Result<std_path_PathBuf, std_io_Error> = v402 |> Error
            let _run_target_args'_v409 = v417 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v418 : Result<std_path_PathBuf, std_io_Error> = v402 |> Error
            let _run_target_args'_v409 = v418 
            #endif
#else
            let v419 : Result<std_path_PathBuf, std_io_Error> = v402 |> Error
            let _run_target_args'_v409 = v419 
            #endif
            let v420 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v409 
            v420
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
        let v36 : US10 = US10_1
        let v37 : US10 = v22 |> Option.defaultValue v36 
        let v80 : string =
            match v37 with
            | US10_1 -> (* None *)
                v0
            | US10_0(v41) -> (* Some *)
                (* run_target_args'
                let v46 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v47 : string = "$0.display()"
                let v48 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v41 v47 
                let _run_target_args'_v46 = v48 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v49 : string = "$0.display()"
                let v50 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v41 v49 
                let _run_target_args'_v46 = v50 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v51 : string = "$0.display()"
                let v52 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v41 v51 
                let _run_target_args'_v46 = v52 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v54 : std_path_Display = v41 |> unbox<std_path_Display>
                let _run_target_args'_v46 = v54 
                #endif
#if FABLE_COMPILER_PYTHON
                let v58 : std_path_Display = v41 |> unbox<std_path_Display>
                let _run_target_args'_v46 = v58 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v62 : std_path_Display = v41 |> unbox<std_path_Display>
                let _run_target_args'_v46 = v62 
                #endif
#else
                let v66 : std_path_Display = v41 |> unbox<std_path_Display>
                let _run_target_args'_v46 = v66 
                #endif
                let v69 : std_path_Display = _run_target_args'_v46 
                let v76 : string = v69 |> string 
                v76
        let v81 : bool = v80 = ""
        let v82 : string =
            if v81 then
                v0
            else
                v80
        let v83 : string = "^\\\\\\\\\\?\\\\"
        let v84 : string = ""
        let v85 : string = method58(v83, v84, v82)
        let v86 : int32 = v85.Length
        let v87 : bool = v86 < 2
        if v87 then
            v0
        else
            let v88 : string = $"{v85.[0] |> string |> _.ToLower()}{v85.[1..]}"
            let v89 : string = "\\"
            let v90 : string = "/"
            let v91 : string = v88.Replace (v89, v90)
            v91
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
        let v153 : string option = None
        v153
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
and method113 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method78(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "runtime.execute_with_options / child error"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method18(v13)
and closure45 (v0 : std_string_String) () : unit =
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
and closure46 () (v0 : std_process_ChildStdin option) : std_process_ChildStdin option =
    v0
and method115 () : (std_process_ChildStdin option -> std_process_ChildStdin option) =
    closure46()
and closure47 () (v0 : std_sync_mpsc_Sender<std_string_String>) : std_sync_mpsc_Sender<std_string_String> =
    v0
and method116 () : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) =
    closure47()
and method117 () : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) =
    closure47()
and closure48 () (v0 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> =
    v0
and method118 () : (std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> -> std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) =
    closure48()
and closure49 () (v0 : std_string_String) : US26 =
    US26_0(v0)
and method119 () : (std_string_String -> US26) =
    closure49()
and closure50 () (v0 : std_string_String) : US26 =
    US26_1(v0)
and method120 () : (std_string_String -> US26) =
    closure50()
and method122 (v0 : bool, v1 : std_string_String) : string =
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
and method121 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : bool, v9 : std_string_String) : string =
    let v10 : string = method122(v8, v9)
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
        let v47 : string = method121(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method19(v47)
and method123 () : string =
    
    
    
    
    
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
and closure52 (v0 : string) () : unit =
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
and method126 () : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) =
    closure53()
and method127 (v0 : Result<unit, string>) : Result<unit, string> =
    v0
and closure54 () (v0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)) : US27 =
    US27_0(v0)
and method128 () : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US27) =
    closure54()
and method129 (v0 : std_sync_MutexGuard<std_process_ChildStdin option>) : std_sync_MutexGuard<std_process_ChildStdin option> =
    v0
and closure55 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : US28 =
    US28_0(v0)
and method130 () : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US28) =
    closure55()
and method131 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure56 () (v0 : std_process_Output) : US29 =
    US29_0(v0)
and method132 () : (std_process_Output -> US29) =
    closure56()
and closure57 () (v0 : std_string_String) : US29 =
    US29_1(v0)
and method133 () : (std_string_String -> US29) =
    closure57()
and method134 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method78(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "runtime.execute_with_options / output error"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method18(v13)
and closure58 (v0 : std_string_String) () : unit =
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
and closure59 () (v0 : int32) : US30 =
    US30_0(v0)
and method135 () : (int32 -> US30) =
    closure59()
and method136 () : string =
    let v0 : string = "\n"
    v0
and method138 (v0 : int32, v1 : int32) : string =
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
and method137 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32) : string =
    let v10 : string = method138(v8, v9)
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
        let v46 : string = method123()
        let v47 : int32 = v1.Length
        let v48 : string = method137(v27, v28, v29, v30, v31, v32, v45, v46, v0, v47)
        method19(v48)
and method142 (v0 : string, v1 : US5, v2 : string, v3 : System.Threading.CancellationToken option, v4 : (struct (string * string) []), v5 : (struct (int32 * string * bool) -> Async<unit>) option, v6 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v7 : bool, v8 : string option) : string =
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
and method141 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : US5, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option) : string =
    let v17 : string = method142(v8, v9, v10, v11, v12, v13, v14, v15, v16)
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
and closure63 () (v0 : (struct (int32 * string * bool) -> Async<unit>)) : US31 =
    US31_0(v0)
and method147 () : ((struct (int32 * string * bool) -> Async<unit>) -> US31) =
    closure63()
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
and closure64 (v0 : string) () : unit =
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
                let v41 : ((struct (int32 * string * bool) -> Async<unit>) -> US31) = method147()
                let v42 : US31 option = v3 |> Option.map v41 
                let v56 : US31 = US31_1
                let v57 : US31 = v42 |> Option.defaultValue v56 
                match v57 with
                | US31_1 -> (* None *)
                    ()
                | US31_0(v61) -> (* Some *)
                    let v62 : int32 = method148(v7)
                    let v63 : Async<unit> = v61 struct (v62, v32, v9)
                    do! v63 
                    ()
                let v66 : string =
                    if v9 then
                        let v64 : string = $"! {v32}"
                        v64
                    else
                        let v65 : string = $"> {v32}"
                        v65
                if v5 then
                    let v67 : unit = ()
                    let v68 : (unit -> unit) = closure64(v66)
                    let v69 : unit = (fun () -> v68 (); v67) ()
                    ()
                else
                    let v119 : unit = ()
                    let v120 : (unit -> unit) = closure11(v66)
                    let v121 : unit = (fun () -> v120 (); v119) ()
                    ()
                let v125 : string =
                    if v9 then
                        let v123 : string = "\u001b[7;4m"
                        v123
                    else
                        let v124 : string = ""
                        v124
                let v128 : string =
                    if v9 then
                        let v126 : string = "\u001b[0m"
                        v126
                    else
                        let v127 : string = ""
                        v127
                let v129 : string = $"{v125}{v32}{v128}"
                (* run_target_args'
                let v130 : unit = ()
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
                let v131 : (string -> unit) = v8.Push
                v131 v129
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
    let v832 : Async<unit> = _let'_v29 
    let _run_target_args'_v15 = v832 
    #endif
#if FABLE_COMPILER_PYTHON
    let v834 : unit = ()
    let _let'_v834 =
        async {
            let v837 : string = method146(v10)
            let v839 : string = null |> unbox<string>
            let v842 : bool = v837 = v839
            let v843 : bool = v842 <> true
            if v843 then
                let v846 : ((struct (int32 * string * bool) -> Async<unit>) -> US31) = method147()
                let v847 : US31 option = v3 |> Option.map v846 
                let v861 : US31 = US31_1
                let v862 : US31 = v847 |> Option.defaultValue v861 
                match v862 with
                | US31_1 -> (* None *)
                    ()
                | US31_0(v866) -> (* Some *)
                    let v867 : int32 = method148(v7)
                    let v868 : Async<unit> = v866 struct (v867, v837, v9)
                    do! v868 
                    ()
                let v871 : string =
                    if v9 then
                        let v869 : string = $"! {v837}"
                        v869
                    else
                        let v870 : string = $"> {v837}"
                        v870
                if v5 then
                    let v872 : unit = ()
                    let v873 : (unit -> unit) = closure64(v871)
                    let v874 : unit = (fun () -> v873 (); v872) ()
                    ()
                else
                    let v924 : unit = ()
                    let v925 : (unit -> unit) = closure11(v871)
                    let v926 : unit = (fun () -> v925 (); v924) ()
                    ()
                let v930 : string =
                    if v9 then
                        let v928 : string = "\u001b[7;4m"
                        v928
                    else
                        let v929 : string = ""
                        v929
                let v933 : string =
                    if v9 then
                        let v931 : string = "\u001b[0m"
                        v931
                    else
                        let v932 : string = ""
                        v932
                let v934 : string = $"{v930}{v837}{v933}"
                (* run_target_args'
                let v935 : unit = ()
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
                let v936 : (string -> unit) = v8.Push
                v936 v934
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
    let v1637 : Async<unit> = _let'_v834 
    let _run_target_args'_v15 = v1637 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1639 : unit = ()
    let _let'_v1639 =
        async {
            let v1642 : string = method146(v10)
            let v1644 : string = null |> unbox<string>
            let v1647 : bool = v1642 = v1644
            let v1648 : bool = v1647 <> true
            if v1648 then
                let v1651 : ((struct (int32 * string * bool) -> Async<unit>) -> US31) = method147()
                let v1652 : US31 option = v3 |> Option.map v1651 
                let v1666 : US31 = US31_1
                let v1667 : US31 = v1652 |> Option.defaultValue v1666 
                match v1667 with
                | US31_1 -> (* None *)
                    ()
                | US31_0(v1671) -> (* Some *)
                    let v1672 : int32 = method148(v7)
                    let v1673 : Async<unit> = v1671 struct (v1672, v1642, v9)
                    do! v1673 
                    ()
                let v1676 : string =
                    if v9 then
                        let v1674 : string = $"! {v1642}"
                        v1674
                    else
                        let v1675 : string = $"> {v1642}"
                        v1675
                if v5 then
                    let v1677 : unit = ()
                    let v1678 : (unit -> unit) = closure64(v1676)
                    let v1679 : unit = (fun () -> v1678 (); v1677) ()
                    ()
                else
                    let v1729 : unit = ()
                    let v1730 : (unit -> unit) = closure11(v1676)
                    let v1731 : unit = (fun () -> v1730 (); v1729) ()
                    ()
                let v1735 : string =
                    if v9 then
                        let v1733 : string = "\u001b[7;4m"
                        v1733
                    else
                        let v1734 : string = ""
                        v1734
                let v1738 : string =
                    if v9 then
                        let v1736 : string = "\u001b[0m"
                        v1736
                    else
                        let v1737 : string = ""
                        v1737
                let v1739 : string = $"{v1735}{v1642}{v1738}"
                (* run_target_args'
                let v1740 : unit = ()
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
                let v1741 : (string -> unit) = v8.Push
                v1741 v1739
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
    let v2442 : Async<unit> = _let'_v1639 
    let _run_target_args'_v15 = v2442 
    #endif
#else
    let v2444 : unit = ()
    let _let'_v2444 =
        async {
            let v2447 : string = method146(v10)
            let v2449 : string = null |> unbox<string>
            let v2452 : bool = v2447 = v2449
            let v2453 : bool = v2452 <> true
            if v2453 then
                let v2456 : ((struct (int32 * string * bool) -> Async<unit>) -> US31) = method147()
                let v2457 : US31 option = v3 |> Option.map v2456 
                let v2471 : US31 = US31_1
                let v2472 : US31 = v2457 |> Option.defaultValue v2471 
                match v2472 with
                | US31_1 -> (* None *)
                    ()
                | US31_0(v2476) -> (* Some *)
                    let v2477 : int32 = method148(v7)
                    let v2478 : Async<unit> = v2476 struct (v2477, v2447, v9)
                    do! v2478 
                    ()
                let v2481 : string =
                    if v9 then
                        let v2479 : string = $"! {v2447}"
                        v2479
                    else
                        let v2480 : string = $"> {v2447}"
                        v2480
                if v5 then
                    let v2482 : unit = ()
                    let v2483 : (unit -> unit) = closure64(v2481)
                    let v2484 : unit = (fun () -> v2483 (); v2482) ()
                    ()
                else
                    let v2534 : unit = ()
                    let v2535 : (unit -> unit) = closure11(v2481)
                    let v2536 : unit = (fun () -> v2535 (); v2534) ()
                    ()
                let v2540 : string =
                    if v9 then
                        let v2538 : string = "\u001b[7;4m"
                        v2538
                    else
                        let v2539 : string = ""
                        v2539
                let v2543 : string =
                    if v9 then
                        let v2541 : string = "\u001b[0m"
                        v2541
                    else
                        let v2542 : string = ""
                        v2542
                let v2544 : string = $"{v2540}{v2447}{v2543}"
                (* run_target_args'
                let v2545 : unit = ()
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
                let v2546 : (string -> unit) = v8.Push
                v2546 v2544
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
    let v3247 : Async<unit> = _let'_v2444 
    let _run_target_args'_v15 = v3247 
    #endif
    let v3248 : Async<unit> = _run_target_args'_v15 
    v3248
and method144 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>, v9 : bool, v10 : System.Diagnostics.DataReceivedEventArgs) : Async<unit> =
    method145(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
and closure62 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>, v9 : bool) (v10 : System.Diagnostics.DataReceivedEventArgs) : unit =
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
and closure65 () (v0 : System.Threading.CancellationToken) : US32 =
    US32_0(v0)
and method149 () : (System.Threading.CancellationToken -> US32) =
    closure65()
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
and closure66 (v0 : System.Diagnostics.Process) () : unit =
    let v1 : bool = method151(v0)
    let v2 : bool = v1 = false
    if v2 then
        method152(v0)
and method155 (v0 : System.Threading.Tasks.TaskCanceledException) : string =
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
and method154 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : System.Threading.Tasks.TaskCanceledException) : string =
    let v9 : string = method155(v8)
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
and method157 (v0 : int32, v1 : int32, v2 : string, v3 : System.Threading.CancellationToken option, v4 : (struct (string * string) []), v5 : (struct (int32 * string * bool) -> Async<unit>) option, v6 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v7 : bool, v8 : string option) : string =
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
and method156 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option) : string =
    let v17 : string = method157(v8, v9, v10, v11, v12, v13, v14, v15, v16)
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
            let v101 : (string -> US5) = method6()
            let v102 : US5 option = v6 |> Option.map v101 
            let v116 : US5 = US5_1
            let v117 : US5 = v102 |> Option.defaultValue v116 
            let v124 : string =
                match v117 with
                | US5_1 -> (* None *)
                    let v122 : string = ""
                    v122
                | US5_0(v121) -> (* Some *)
                    v121
            let v125 : unit = ()
            let v126 : (unit -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v98, v97)
            let v127 : unit = (fun () -> v126 (); v125) ()
            let v174 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v178 : string =
                match v98 with
                | US5_1 -> (* None *)
                    let v176 : string = ""
                    v176
                | US5_0(v175) -> (* Some *)
                    v175
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v178,
              StandardOutputEncoding = v174,
              WorkingDirectory = v124,
              FileName = v97,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v179 : System.Diagnostics.ProcessStartInfo = start_info
            let v180 : (struct (string * string) []) = method143(v0, v1, v2, v3, v4, v5, v6)
            let v181 : int32 = v180.Length
            let v182 : Mut6 = {l0 = 0} : Mut6
            while method63(v181, v182) do
                let v184 : int32 = v182.l0
                let struct (v185 : string, v186 : string) = v180.[int v184]
                v179.EnvironmentVariables.[v185] <- v186 
                let v187 : int32 = v184 + 1
                v182.l0 <- v187
                ()
            let v188 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v179)
            use v188 = v188 
            let v189 : System.Diagnostics.Process = v188 
            let v190 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v191 : System.Collections.Concurrent.ConcurrentStack<string> = v190 ()
            let v192 : bool = false
            let v193 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v189, v191, v192)
            v189.OutputDataReceived.Add v193 
            let v194 : bool = true
            let v195 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v189, v191, v194)
            v189.ErrorDataReceived.Add v195 
            let v196 : (unit -> bool) = v189.Start
            let v197 : bool = v196 ()
            let v198 : bool = v197 = false
            if v198 then
                let v199 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v199
            let v200 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v200 v189
            let v201 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v201 v189
            let v204 : (System.Threading.CancellationToken -> US32) = method149()
            let v205 : US32 option = v1 |> Option.map v204 
            let v219 : US32 = US32_1
            let v220 : US32 = v205 |> Option.defaultValue v219 
            let v227 : System.Threading.CancellationToken =
                match v220 with
                | US32_1 -> (* None *)
                    let v225 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v225
                | US32_0(v224) -> (* Some *)
                    v224
            let v228 : Async<System.Threading.CancellationToken> = method150(v227)
            let! v228 = v228 
            let v229 : System.Threading.CancellationToken = v228 
            let v230 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v229.Register
            let v231 : (unit -> unit) = closure66(v189)
            let v232 : System.Threading.CancellationTokenRegistration = v230 v231
            use v232 = v232 
            let v233 : System.Threading.CancellationTokenRegistration = v232 
            let v234 : Async<int32> = method153(v189, v191, v229)
            let! v234 = v234 
            let v235 : int32 = v234 
            let v237 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v238 : string seq = v237 v191
            let v242 : (string seq -> string seq) = Seq.rev
            let v243 : string seq = v242 v238
            let v248 : string = method136()
            let v249 : (string -> (string seq -> string)) = String.concat
            let v250 : (string seq -> string) = v249 v248
            let v251 : string = v250 v243
            let v255 : unit = ()
            let v256 : (unit -> unit) = closure68(v0, v1, v2, v3, v4, v5, v6, v235, v251)
            let v257 : unit = (fun () -> v256 (); v255) ()
            return struct (v235, v251) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2308 : Async<struct (int32 * string)> = _let'_v25 
    let _run_target_args'_v11 = v2308 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2310 : unit = ()
    let _let'_v2310 =
        async {
            (* run_target_args'
            let v2321 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v2324 : int32, v2325 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2324, v2325) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v2332 : int32, v2333 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2332, v2333) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v2340 : int32, v2341 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2340, v2341) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v2348 : int32, v2349 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2348, v2349) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v2356 : int32, v2357 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2356, v2357) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v2364 : int32, v2365 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2364, v2365) 
            #endif
#else
            let v2370 : US14 = method85(v0)
            let struct (v2382 : string, v2383 : US5) =
                match v2370 with
                | US14_1(v2373) -> (* Error *)
                    let v2375 : string = $"resultm.get / Result value was Error: {v2373}"
                    failwith<struct (string * US5)> v2375
                | US14_0(v2371, v2372) -> (* Ok *)
                    struct (v2371, v2372)
            let v2386 : (string -> US5) = method6()
            let v2387 : US5 option = v6 |> Option.map v2386 
            let v2401 : US5 = US5_1
            let v2402 : US5 = v2387 |> Option.defaultValue v2401 
            let v2409 : string =
                match v2402 with
                | US5_1 -> (* None *)
                    let v2407 : string = ""
                    v2407
                | US5_0(v2406) -> (* Some *)
                    v2406
            let v2410 : unit = ()
            let v2411 : (unit -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v2383, v2382)
            let v2412 : unit = (fun () -> v2411 (); v2410) ()
            let v2459 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v2463 : string =
                match v2383 with
                | US5_1 -> (* None *)
                    let v2461 : string = ""
                    v2461
                | US5_0(v2460) -> (* Some *)
                    v2460
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v2463,
              StandardOutputEncoding = v2459,
              WorkingDirectory = v2409,
              FileName = v2382,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v2464 : System.Diagnostics.ProcessStartInfo = start_info
            let v2465 : (struct (string * string) []) = method143(v0, v1, v2, v3, v4, v5, v6)
            let v2466 : int32 = v2465.Length
            let v2467 : Mut6 = {l0 = 0} : Mut6
            while method63(v2466, v2467) do
                let v2469 : int32 = v2467.l0
                let struct (v2470 : string, v2471 : string) = v2465.[int v2469]
                v2464.EnvironmentVariables.[v2470] <- v2471 
                let v2472 : int32 = v2469 + 1
                v2467.l0 <- v2472
                ()
            let v2473 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v2464)
            use v2473 = v2473 
            let v2474 : System.Diagnostics.Process = v2473 
            let v2475 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v2476 : System.Collections.Concurrent.ConcurrentStack<string> = v2475 ()
            let v2477 : bool = false
            let v2478 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v2474, v2476, v2477)
            v2474.OutputDataReceived.Add v2478 
            let v2479 : bool = true
            let v2480 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v2474, v2476, v2479)
            v2474.ErrorDataReceived.Add v2480 
            let v2481 : (unit -> bool) = v2474.Start
            let v2482 : bool = v2481 ()
            let v2483 : bool = v2482 = false
            if v2483 then
                let v2484 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v2484
            let v2485 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v2485 v2474
            let v2486 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v2486 v2474
            let v2489 : (System.Threading.CancellationToken -> US32) = method149()
            let v2490 : US32 option = v1 |> Option.map v2489 
            let v2504 : US32 = US32_1
            let v2505 : US32 = v2490 |> Option.defaultValue v2504 
            let v2512 : System.Threading.CancellationToken =
                match v2505 with
                | US32_1 -> (* None *)
                    let v2510 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v2510
                | US32_0(v2509) -> (* Some *)
                    v2509
            let v2513 : Async<System.Threading.CancellationToken> = method150(v2512)
            let! v2513 = v2513 
            let v2514 : System.Threading.CancellationToken = v2513 
            let v2515 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v2514.Register
            let v2516 : (unit -> unit) = closure66(v2474)
            let v2517 : System.Threading.CancellationTokenRegistration = v2515 v2516
            use v2517 = v2517 
            let v2518 : System.Threading.CancellationTokenRegistration = v2517 
            let v2519 : Async<int32> = method153(v2474, v2476, v2514)
            let! v2519 = v2519 
            let v2520 : int32 = v2519 
            let v2522 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v2523 : string seq = v2522 v2476
            let v2527 : (string seq -> string seq) = Seq.rev
            let v2528 : string seq = v2527 v2523
            let v2533 : string = method136()
            let v2534 : (string -> (string seq -> string)) = String.concat
            let v2535 : (string seq -> string) = v2534 v2533
            let v2536 : string = v2535 v2528
            let v2540 : unit = ()
            let v2541 : (unit -> unit) = closure68(v0, v1, v2, v3, v4, v5, v6, v2520, v2536)
            let v2542 : unit = (fun () -> v2541 (); v2540) ()
            return struct (v2520, v2536) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v4593 : Async<struct (int32 * string)> = _let'_v2310 
    let _run_target_args'_v11 = v4593 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v4595 : unit = ()
    let _let'_v4595 =
        async {
            (* run_target_args'
            let v4606 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v4609 : int32, v4610 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4609, v4610) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v4617 : int32, v4618 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4617, v4618) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v4625 : int32, v4626 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4625, v4626) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v4633 : int32, v4634 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4633, v4634) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v4641 : int32, v4642 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4641, v4642) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v4649 : int32, v4650 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4649, v4650) 
            #endif
#else
            let v4655 : US14 = method85(v0)
            let struct (v4667 : string, v4668 : US5) =
                match v4655 with
                | US14_1(v4658) -> (* Error *)
                    let v4660 : string = $"resultm.get / Result value was Error: {v4658}"
                    failwith<struct (string * US5)> v4660
                | US14_0(v4656, v4657) -> (* Ok *)
                    struct (v4656, v4657)
            let v4671 : (string -> US5) = method6()
            let v4672 : US5 option = v6 |> Option.map v4671 
            let v4686 : US5 = US5_1
            let v4687 : US5 = v4672 |> Option.defaultValue v4686 
            let v4694 : string =
                match v4687 with
                | US5_1 -> (* None *)
                    let v4692 : string = ""
                    v4692
                | US5_0(v4691) -> (* Some *)
                    v4691
            let v4695 : unit = ()
            let v4696 : (unit -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v4668, v4667)
            let v4697 : unit = (fun () -> v4696 (); v4695) ()
            let v4744 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v4748 : string =
                match v4668 with
                | US5_1 -> (* None *)
                    let v4746 : string = ""
                    v4746
                | US5_0(v4745) -> (* Some *)
                    v4745
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v4748,
              StandardOutputEncoding = v4744,
              WorkingDirectory = v4694,
              FileName = v4667,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v4749 : System.Diagnostics.ProcessStartInfo = start_info
            let v4750 : (struct (string * string) []) = method143(v0, v1, v2, v3, v4, v5, v6)
            let v4751 : int32 = v4750.Length
            let v4752 : Mut6 = {l0 = 0} : Mut6
            while method63(v4751, v4752) do
                let v4754 : int32 = v4752.l0
                let struct (v4755 : string, v4756 : string) = v4750.[int v4754]
                v4749.EnvironmentVariables.[v4755] <- v4756 
                let v4757 : int32 = v4754 + 1
                v4752.l0 <- v4757
                ()
            let v4758 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v4749)
            use v4758 = v4758 
            let v4759 : System.Diagnostics.Process = v4758 
            let v4760 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v4761 : System.Collections.Concurrent.ConcurrentStack<string> = v4760 ()
            let v4762 : bool = false
            let v4763 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v4759, v4761, v4762)
            v4759.OutputDataReceived.Add v4763 
            let v4764 : bool = true
            let v4765 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v4759, v4761, v4764)
            v4759.ErrorDataReceived.Add v4765 
            let v4766 : (unit -> bool) = v4759.Start
            let v4767 : bool = v4766 ()
            let v4768 : bool = v4767 = false
            if v4768 then
                let v4769 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v4769
            let v4770 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v4770 v4759
            let v4771 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v4771 v4759
            let v4774 : (System.Threading.CancellationToken -> US32) = method149()
            let v4775 : US32 option = v1 |> Option.map v4774 
            let v4789 : US32 = US32_1
            let v4790 : US32 = v4775 |> Option.defaultValue v4789 
            let v4797 : System.Threading.CancellationToken =
                match v4790 with
                | US32_1 -> (* None *)
                    let v4795 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v4795
                | US32_0(v4794) -> (* Some *)
                    v4794
            let v4798 : Async<System.Threading.CancellationToken> = method150(v4797)
            let! v4798 = v4798 
            let v4799 : System.Threading.CancellationToken = v4798 
            let v4800 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v4799.Register
            let v4801 : (unit -> unit) = closure66(v4759)
            let v4802 : System.Threading.CancellationTokenRegistration = v4800 v4801
            use v4802 = v4802 
            let v4803 : System.Threading.CancellationTokenRegistration = v4802 
            let v4804 : Async<int32> = method153(v4759, v4761, v4799)
            let! v4804 = v4804 
            let v4805 : int32 = v4804 
            let v4807 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v4808 : string seq = v4807 v4761
            let v4812 : (string seq -> string seq) = Seq.rev
            let v4813 : string seq = v4812 v4808
            let v4818 : string = method136()
            let v4819 : (string -> (string seq -> string)) = String.concat
            let v4820 : (string seq -> string) = v4819 v4818
            let v4821 : string = v4820 v4813
            let v4825 : unit = ()
            let v4826 : (unit -> unit) = closure68(v0, v1, v2, v3, v4, v5, v6, v4805, v4821)
            let v4827 : unit = (fun () -> v4826 (); v4825) ()
            return struct (v4805, v4821) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v6878 : Async<struct (int32 * string)> = _let'_v4595 
    let _run_target_args'_v11 = v6878 
    #endif
#else
    let v6880 : unit = ()
    let _let'_v6880 =
        async {
            (* run_target_args'
            let v6891 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v6894 : int32, v6895 : string) = null |> unbox<struct (int32 * string)>
            return struct (v6894, v6895) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v6902 : int32, v6903 : string) = null |> unbox<struct (int32 * string)>
            return struct (v6902, v6903) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v6910 : int32, v6911 : string) = null |> unbox<struct (int32 * string)>
            return struct (v6910, v6911) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v6918 : int32, v6919 : string) = null |> unbox<struct (int32 * string)>
            return struct (v6918, v6919) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v6926 : int32, v6927 : string) = null |> unbox<struct (int32 * string)>
            return struct (v6926, v6927) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v6934 : int32, v6935 : string) = null |> unbox<struct (int32 * string)>
            return struct (v6934, v6935) 
            #endif
#else
            let v6940 : US14 = method85(v0)
            let struct (v6952 : string, v6953 : US5) =
                match v6940 with
                | US14_1(v6943) -> (* Error *)
                    let v6945 : string = $"resultm.get / Result value was Error: {v6943}"
                    failwith<struct (string * US5)> v6945
                | US14_0(v6941, v6942) -> (* Ok *)
                    struct (v6941, v6942)
            let v6956 : (string -> US5) = method6()
            let v6957 : US5 option = v6 |> Option.map v6956 
            let v6971 : US5 = US5_1
            let v6972 : US5 = v6957 |> Option.defaultValue v6971 
            let v6979 : string =
                match v6972 with
                | US5_1 -> (* None *)
                    let v6977 : string = ""
                    v6977
                | US5_0(v6976) -> (* Some *)
                    v6976
            let v6980 : unit = ()
            let v6981 : (unit -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v6953, v6952)
            let v6982 : unit = (fun () -> v6981 (); v6980) ()
            let v7029 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v7033 : string =
                match v6953 with
                | US5_1 -> (* None *)
                    let v7031 : string = ""
                    v7031
                | US5_0(v7030) -> (* Some *)
                    v7030
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v7033,
              StandardOutputEncoding = v7029,
              WorkingDirectory = v6979,
              FileName = v6952,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v7034 : System.Diagnostics.ProcessStartInfo = start_info
            let v7035 : (struct (string * string) []) = method143(v0, v1, v2, v3, v4, v5, v6)
            let v7036 : int32 = v7035.Length
            let v7037 : Mut6 = {l0 = 0} : Mut6
            while method63(v7036, v7037) do
                let v7039 : int32 = v7037.l0
                let struct (v7040 : string, v7041 : string) = v7035.[int v7039]
                v7034.EnvironmentVariables.[v7040] <- v7041 
                let v7042 : int32 = v7039 + 1
                v7037.l0 <- v7042
                ()
            let v7043 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v7034)
            use v7043 = v7043 
            let v7044 : System.Diagnostics.Process = v7043 
            let v7045 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v7046 : System.Collections.Concurrent.ConcurrentStack<string> = v7045 ()
            let v7047 : bool = false
            let v7048 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v7044, v7046, v7047)
            v7044.OutputDataReceived.Add v7048 
            let v7049 : bool = true
            let v7050 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v7044, v7046, v7049)
            v7044.ErrorDataReceived.Add v7050 
            let v7051 : (unit -> bool) = v7044.Start
            let v7052 : bool = v7051 ()
            let v7053 : bool = v7052 = false
            if v7053 then
                let v7054 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v7054
            let v7055 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v7055 v7044
            let v7056 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v7056 v7044
            let v7059 : (System.Threading.CancellationToken -> US32) = method149()
            let v7060 : US32 option = v1 |> Option.map v7059 
            let v7074 : US32 = US32_1
            let v7075 : US32 = v7060 |> Option.defaultValue v7074 
            let v7082 : System.Threading.CancellationToken =
                match v7075 with
                | US32_1 -> (* None *)
                    let v7080 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v7080
                | US32_0(v7079) -> (* Some *)
                    v7079
            let v7083 : Async<System.Threading.CancellationToken> = method150(v7082)
            let! v7083 = v7083 
            let v7084 : System.Threading.CancellationToken = v7083 
            let v7085 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v7084.Register
            let v7086 : (unit -> unit) = closure66(v7044)
            let v7087 : System.Threading.CancellationTokenRegistration = v7085 v7086
            use v7087 = v7087 
            let v7088 : System.Threading.CancellationTokenRegistration = v7087 
            let v7089 : Async<int32> = method153(v7044, v7046, v7084)
            let! v7089 = v7089 
            let v7090 : int32 = v7089 
            let v7092 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v7093 : string seq = v7092 v7046
            let v7097 : (string seq -> string seq) = Seq.rev
            let v7098 : string seq = v7097 v7093
            let v7103 : string = method136()
            let v7104 : (string -> (string seq -> string)) = String.concat
            let v7105 : (string seq -> string) = v7104 v7103
            let v7106 : string = v7105 v7098
            let v7110 : unit = ()
            let v7111 : (unit -> unit) = closure68(v0, v1, v2, v3, v4, v5, v6, v7090, v7106)
            let v7112 : unit = (fun () -> v7111 (); v7110) ()
            return struct (v7090, v7106) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v9163 : Async<struct (int32 * string)> = _let'_v6880 
    let _run_target_args'_v11 = v9163 
    #endif
    let v9164 : Async<struct (int32 * string)> = _run_target_args'_v11 
    v9164
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
    let v225 : US5 = US5_1
    let v226 : US5 = v211 |> Option.defaultValue v225 
    let v240 : std_process_Command =
        match v226 with
        | US5_1 -> (* None *)
            let v237 : string = $"v207"
            let v238 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v237 
            v238
        | US5_0(v230) -> (* Some *)
            let v231 : string = "true; let mut v207 = v207"
            let v232 : bool = Fable.Core.RustInterop.emitRustExpr () v231 
            let v233 : string = "true; std::process::Command::current_dir(&mut v207, &*$0)"
            let v234 : bool = Fable.Core.RustInterop.emitRustExpr v230 v233 
            let v235 : string = $"v207"
            let v236 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v235 
            v236
    let v241 : uint64 = System.Convert.ToUInt64 v2.Length
    let v242 : bool = v241 = 0UL
    let v262 : std_process_Command =
        if v242 then
            v240
        else
            let v243 : string = "$0.to_vec()"
            let v244 : Vec<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr v2 v243 
            let v245 : string = "true; let _vec_fold_ = $0.into_iter().fold(v240, |acc, x| { //"
            let v246 : bool = Fable.Core.RustInterop.emitRustExpr v244 v245 
            let v247 : string = "acc"
            let v248 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v247 
            let v249 : string = "x"
            let struct (v250 : string, v251 : string) = Fable.Core.RustInterop.emitRustExpr () v249 
            let v252 : string = "true; let mut v248 = v248"
            let v253 : bool = Fable.Core.RustInterop.emitRustExpr () v252 
            let v254 : string = "true; std::process::Command::env(&mut v248, &*$0, &*$1)"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr struct (v250, v251) v254 
            let v256 : string = "$0"
            let v257 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v248 v256 
            let v258 : string = "true; $0 })"
            let v259 : bool = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "_vec_fold_"
            let v261 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v260 
            v261
    let v263 : string = "true; let mut v262 = v262"
    let v264 : bool = Fable.Core.RustInterop.emitRustExpr () v263 
    let v265 : string = "std::process::Command::spawn(&mut v262)"
    let v266 : Result<std_process_Child, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v265 
    let v267 : (std_io_Error -> std_string_String) = method69()
    (* run_target_args'
    let v269 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v270 : string = "$0.map_err(|x| $1(x))"
    let v271 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v266, v267) v270 
    let _run_target_args'_v269 = v271 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v272 : string = "$0.map_err(|x| $1(x))"
    let v273 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v266, v267) v272 
    let _run_target_args'_v269 = v273 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v274 : string = "$0.map_err(|x| $1(x))"
    let v275 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v266, v267) v274 
    let _run_target_args'_v269 = v275 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v276 : Result<std_process_Child, std_string_String> = match v266 with Ok x -> Ok x | Error x -> Error (v267 x)
    let _run_target_args'_v269 = v276 
    #endif
#if FABLE_COMPILER_PYTHON
    let v277 : Result<std_process_Child, std_string_String> = match v266 with Ok x -> Ok x | Error x -> Error (v267 x)
    let _run_target_args'_v269 = v277 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v278 : Result<std_process_Child, std_string_String> = match v266 with Ok x -> Ok x | Error x -> Error (v267 x)
    let _run_target_args'_v269 = v278 
    #endif
#else
    let v279 : Result<std_process_Child, std_string_String> = match v266 with Ok x -> Ok x | Error x -> Error (v267 x)
    let _run_target_args'_v269 = v279 
    #endif
    let v280 : Result<std_process_Child, std_string_String> = _run_target_args'_v269 
    let v283 : (std_process_Child option -> std_process_Child option) = method110()
    let v284 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v285 : bool = Fable.Core.RustInterop.emitRustExpr v280 v284 
    let v286 : string = "x"
    let v287 : std_process_Child = Fable.Core.RustInterop.emitRustExpr () v286 
    let v289 : std_process_Child option = Some v287 
    let v292 : std_process_Child option = v283 v289
    let v293 : string = "std::sync::Mutex::new(v292)"
    let v294 : std_sync_Mutex<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr () v293 
    let v295 : string = "std::sync::Arc::new(v294)"
    let v296 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr () v295 
    let v297 : string = "true; $0 })"
    let v298 : bool = Fable.Core.RustInterop.emitRustExpr v296 v297 
    let v299 : string = "_result_map_"
    let v300 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v299 
    let v301 : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US24) = method111()
    let v302 : (std_string_String -> US24) = method112()
    let v303 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
    let v304 : US24 = Fable.Core.RustInterop.emitRustExpr struct (v301, v302, v300) v303 
    let struct (v1607 : int32, v1608 : US6, v1609 : US25) =
        match v304 with
        | US24_1(v1552) -> (* Error *)
            let v1553 : unit = ()
            let v1554 : (unit -> unit) = closure45(v1552)
            let v1555 : unit = (fun () -> v1554 (); v1553) ()
            let v1602 : US6 = US6_0(v1552)
            let v1603 : US25 = US25_1
            struct (-1, v1602, v1603)
        | US24_0(v305) -> (* Ok *)
            let v306 : string = "true; let _capture = (|| { //"
            let v307 : bool = Fable.Core.RustInterop.emitRustExpr () v306 
            let v308 : string = "$0"
            let v309 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v305 v308 
            let v310 : string = "v309.lock()"
            let v311 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v310 
            (* run_target_args'
            let v313 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v314 : string = "$0.unwrap()"
            let v315 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v311 v314 
            let _run_target_args'_v313 = v315 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v316 : string = "$0.unwrap()"
            let v317 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v311 v316 
            let _run_target_args'_v313 = v317 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v318 : string = "$0.unwrap()"
            let v319 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v311 v318 
            let _run_target_args'_v313 = v319 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v320 : std_sync_MutexGuard<std_process_Child option> = match v311 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v313 = v320 
            #endif
#if FABLE_COMPILER_PYTHON
            let v321 : std_sync_MutexGuard<std_process_Child option> = match v311 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v313 = v321 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v322 : std_sync_MutexGuard<std_process_Child option> = match v311 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v313 = v322 
            #endif
#else
            let v323 : std_sync_MutexGuard<std_process_Child option> = match v311 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v313 = v323 
            #endif
            let v324 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v313 
            let v327 : std_sync_MutexGuard<std_process_Child option> = method114(v324)
            let v328 : string = "true; let mut v327 = v327"
            let v329 : bool = Fable.Core.RustInterop.emitRustExpr () v328 
            let v330 : string = "&mut $0"
            let v331 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v327 v330 
            let v332 : string = "$0.as_mut()"
            let v333 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v331 v332 
            let v334 : string = "$0.unwrap()"
            let v335 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v333 v334 
            let v336 : string = "&mut $0.stdout"
            let v337 : Ref<Mut<std_process_ChildStdout option>> = Fable.Core.RustInterop.emitRustExpr v335 v336 
            let v338 : string = "Option::take($0)"
            let v339 : std_process_ChildStdout option = Fable.Core.RustInterop.emitRustExpr v337 v338 
            let v340 : string = "$0.unwrap()"
            let v341 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr v339 v340 
            let v342 : string = "true; $0 })()"
            let v343 : bool = Fable.Core.RustInterop.emitRustExpr v341 v342 
            let v344 : string = "_capture"
            let v345 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr () v344 
            let v346 : string = "true; let _capture = (|| { //"
            let v347 : bool = Fable.Core.RustInterop.emitRustExpr () v346 
            let v348 : string = "$0"
            let v349 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v305 v348 
            let v350 : string = "v349.lock()"
            let v351 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v350 
            (* run_target_args'
            let v353 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v354 : string = "$0.unwrap()"
            let v355 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v351 v354 
            let _run_target_args'_v353 = v355 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v356 : string = "$0.unwrap()"
            let v357 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v351 v356 
            let _run_target_args'_v353 = v357 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v358 : string = "$0.unwrap()"
            let v359 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v351 v358 
            let _run_target_args'_v353 = v359 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v360 : std_sync_MutexGuard<std_process_Child option> = match v351 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v353 = v360 
            #endif
#if FABLE_COMPILER_PYTHON
            let v361 : std_sync_MutexGuard<std_process_Child option> = match v351 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v353 = v361 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v362 : std_sync_MutexGuard<std_process_Child option> = match v351 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v353 = v362 
            #endif
#else
            let v363 : std_sync_MutexGuard<std_process_Child option> = match v351 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v353 = v363 
            #endif
            let v364 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v353 
            let v367 : std_sync_MutexGuard<std_process_Child option> = method114(v364)
            let v368 : string = "true; let mut v367 = v367"
            let v369 : bool = Fable.Core.RustInterop.emitRustExpr () v368 
            let v370 : string = "&mut $0"
            let v371 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v367 v370 
            let v372 : string = "$0.as_mut()"
            let v373 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v371 v372 
            let v374 : string = "$0.unwrap()"
            let v375 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v373 v374 
            let v376 : string = "&mut $0.stderr"
            let v377 : Ref<Mut<std_process_ChildStderr option>> = Fable.Core.RustInterop.emitRustExpr v375 v376 
            let v378 : string = "Option::take($0)"
            let v379 : std_process_ChildStderr option = Fable.Core.RustInterop.emitRustExpr v377 v378 
            let v380 : string = "$0.unwrap()"
            let v381 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr v379 v380 
            let v382 : string = "true; $0 })()"
            let v383 : bool = Fable.Core.RustInterop.emitRustExpr v381 v382 
            let v384 : string = "_capture"
            let v385 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr () v384 
            let v386 : string = "true; let _capture = (|| { //"
            let v387 : bool = Fable.Core.RustInterop.emitRustExpr () v386 
            let v388 : string = "$0"
            let v389 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v305 v388 
            let v390 : string = "v389.lock()"
            let v391 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v390 
            (* run_target_args'
            let v393 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v394 : string = "$0.unwrap()"
            let v395 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v391 v394 
            let _run_target_args'_v393 = v395 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v396 : string = "$0.unwrap()"
            let v397 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v391 v396 
            let _run_target_args'_v393 = v397 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v398 : string = "$0.unwrap()"
            let v399 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v391 v398 
            let _run_target_args'_v393 = v399 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v400 : std_sync_MutexGuard<std_process_Child option> = match v391 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v393 = v400 
            #endif
#if FABLE_COMPILER_PYTHON
            let v401 : std_sync_MutexGuard<std_process_Child option> = match v391 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v393 = v401 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v402 : std_sync_MutexGuard<std_process_Child option> = match v391 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v393 = v402 
            #endif
#else
            let v403 : std_sync_MutexGuard<std_process_Child option> = match v391 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v393 = v403 
            #endif
            let v404 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v393 
            let v407 : std_sync_MutexGuard<std_process_Child option> = method114(v404)
            let v408 : string = "true; let mut v407 = v407"
            let v409 : bool = Fable.Core.RustInterop.emitRustExpr () v408 
            let v410 : string = "&mut $0"
            let v411 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v407 v410 
            let v412 : string = "$0.as_mut()"
            let v413 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v411 v412 
            let v414 : string = "$0.unwrap()"
            let v415 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v413 v414 
            let v416 : string = "&mut $0.stdin"
            let v417 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v415 v416 
            let v418 : string = "Option::take($0)"
            let v419 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v417 v418 
            let v420 : string = "$0.unwrap()"
            let v421 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr v419 v420 
            let v423 : std_process_ChildStdin option = Some v421 
            let v426 : (std_process_ChildStdin option -> std_process_ChildStdin option) = method115()
            let v427 : std_process_ChildStdin option = v426 v423
            let v428 : string = "std::sync::Mutex::new(v427)"
            let v429 : std_sync_Mutex<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr () v428 
            let v430 : string = "std::sync::Arc::new(v429)"
            let v431 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v430 
            let v432 : string = "true; $0 })()"
            let v433 : bool = Fable.Core.RustInterop.emitRustExpr v431 v432 
            let v434 : string = "_capture"
            let v435 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v434 
            let v436 : string = "{ let (sender, receiver) = std::sync::mpsc::channel(); (sender, std::sync::Arc::new(receiver)) }"
            let struct (v437 : std_sync_mpsc_Sender<std_string_String>, v438 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = Fable.Core.RustInterop.emitRustExpr () v436 
            let v439 : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) = method116()
            let v440 : std_sync_mpsc_Sender<std_string_String> = v439 v437
            let v441 : string = "std::sync::Mutex::new(v440)"
            let v442 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v441 
            let v443 : string = "std::sync::Arc::new(v442)"
            let v444 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v443 
            let v445 : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) = method117()
            let v446 : std_sync_mpsc_Sender<std_string_String> = v445 v437
            let v447 : string = "std::sync::Mutex::new(v446)"
            let v448 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v447 
            let v449 : string = "std::sync::Arc::new(v448)"
            let v450 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v449 
            let v451 : (std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> -> std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = method118()
            let v452 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> = v451 v438
            let v453 : string = "std::sync::Mutex::new(v452)"
            let v454 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v453 
            let v455 : string = "std::sync::Arc::new(v454)"
            let v456 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v455 
            let v457 : string = "true; let __spawn = std::thread::spawn(move || { //"
            let v458 : bool = Fable.Core.RustInterop.emitRustExpr () v457 
            let v459 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v460 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v345 v459 
            let v461 : string = "std::io::BufReader::new($0)"
            let v462 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr v460 v461 
            let v463 : string = "std::io::BufRead::lines(v462)"
            let v464 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v463 
            let v465 : string = "true; let mut v464 = v464; let _iter_try_for_each = v464.try_for_each(|x| { //"
            let v466 : bool = Fable.Core.RustInterop.emitRustExpr () v465 
            let v467 : string = "x"
            let v468 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v467 
            let v469 : string = "$0.clone()"
            let v470 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v444 v469 
            let v471 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v473 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v474 : string = "$0.map_err(|x| $1(x))"
            let v475 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v468, v471) v474 
            let _run_target_args'_v473 = v475 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v476 : string = "$0.map_err(|x| $1(x))"
            let v477 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v468, v471) v476 
            let _run_target_args'_v473 = v477 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v478 : string = "$0.map_err(|x| $1(x))"
            let v479 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v468, v471) v478 
            let _run_target_args'_v473 = v479 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v480 : Result<std_string_String, std_string_String> = match v468 with Ok x -> Ok x | Error x -> Error (v471 x)
            let _run_target_args'_v473 = v480 
            #endif
#if FABLE_COMPILER_PYTHON
            let v481 : Result<std_string_String, std_string_String> = match v468 with Ok x -> Ok x | Error x -> Error (v471 x)
            let _run_target_args'_v473 = v481 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v482 : Result<std_string_String, std_string_String> = match v468 with Ok x -> Ok x | Error x -> Error (v471 x)
            let _run_target_args'_v473 = v482 
            #endif
#else
            let v483 : Result<std_string_String, std_string_String> = match v468 with Ok x -> Ok x | Error x -> Error (v471 x)
            let _run_target_args'_v473 = v483 
            #endif
            let v484 : Result<std_string_String, std_string_String> = _run_target_args'_v473 
            let v487 : (std_string_String -> US26) = method119()
            let v488 : (std_string_String -> US26) = method120()
            let v489 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v490 : US26 = Fable.Core.RustInterop.emitRustExpr struct (v487, v488, v484) v489 
            let v727 : std_string_String =
                match v490 with
                | US26_1(v609) -> (* Error *)
                    let v610 : unit = ()
                    let v611 : (unit -> unit) = closure51(v5, v609)
                    let v612 : unit = (fun () -> v611 (); v610) ()
                    let v659 : string = $"\u001b[4;7m{v609}\u001b[0m"
                    (* run_target_args'
                    let v664 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v665 : string = "&*$0"
                    let v666 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v659 v665 
                    let _run_target_args'_v664 = v666 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v667 : string = "&*$0"
                    let v668 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v659 v667 
                    let _run_target_args'_v664 = v668 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v669 : string = "&*$0"
                    let v670 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v659 v669 
                    let _run_target_args'_v664 = v670 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v672 : Ref<Str> = v659 |> unbox<Ref<Str>>
                    let _run_target_args'_v664 = v672 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v676 : Ref<Str> = v659 |> unbox<Ref<Str>>
                    let _run_target_args'_v664 = v676 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v680 : Ref<Str> = v659 |> unbox<Ref<Str>>
                    let _run_target_args'_v664 = v680 
                    #endif
#else
                    let v684 : Ref<Str> = v659 |> unbox<Ref<Str>>
                    let _run_target_args'_v664 = v684 
                    #endif
                    let v687 : Ref<Str> = _run_target_args'_v664 
                    (* run_target_args'
                    let v697 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v698 : string = "String::from($0)"
                    let v699 : std_string_String = Fable.Core.RustInterop.emitRustExpr v687 v698 
                    let _run_target_args'_v697 = v699 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v700 : string = "String::from($0)"
                    let v701 : std_string_String = Fable.Core.RustInterop.emitRustExpr v687 v700 
                    let _run_target_args'_v697 = v701 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v702 : string = "String::from($0)"
                    let v703 : std_string_String = Fable.Core.RustInterop.emitRustExpr v687 v702 
                    let _run_target_args'_v697 = v703 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v705 : std_string_String = v687 |> unbox<std_string_String>
                    let _run_target_args'_v697 = v705 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v709 : std_string_String = v687 |> unbox<std_string_String>
                    let _run_target_args'_v697 = v709 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v713 : std_string_String = v687 |> unbox<std_string_String>
                    let _run_target_args'_v697 = v713 
                    #endif
#else
                    let v717 : std_string_String = v687 |> unbox<std_string_String>
                    let _run_target_args'_v697 = v717 
                    #endif
                    let v720 : std_string_String = _run_target_args'_v697 
                    v720
                | US26_0(v491) -> (* Ok *)
                    let v492 : string = "fable_library_rust::String_::fromString($0)"
                    let v493 : string = Fable.Core.RustInterop.emitRustExpr v491 v492 
                    let v494 : string = "encoding_rs::UTF_8"
                    let v495 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v494 
                    let v496 : string = "$0.encode(&*$1).0"
                    let v497 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v495, v493) v496 
                    let v498 : string = "$0.as_ref()"
                    let v499 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v497 v498 
                    let v500 : string = "std::str::from_utf8($0)"
                    let v501 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr v499 v500 
                    (* run_target_args'
                    let v503 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v504 : string = "$0.unwrap()"
                    let v505 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v501 v504 
                    let _run_target_args'_v503 = v505 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v506 : string = "$0.unwrap()"
                    let v507 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v501 v506 
                    let _run_target_args'_v503 = v507 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v508 : string = "$0.unwrap()"
                    let v509 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v501 v508 
                    let _run_target_args'_v503 = v509 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v510 : Ref<Str> = match v501 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v503 = v510 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v511 : Ref<Str> = match v501 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v503 = v511 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v512 : Ref<Str> = match v501 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v503 = v512 
                    #endif
#else
                    let v513 : Ref<Str> = match v501 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v503 = v513 
                    #endif
                    let v514 : Ref<Str> = _run_target_args'_v503 
                    (* run_target_args'
                    let v521 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v522 : string = "String::from($0)"
                    let v523 : std_string_String = Fable.Core.RustInterop.emitRustExpr v514 v522 
                    let _run_target_args'_v521 = v523 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v524 : string = "String::from($0)"
                    let v525 : std_string_String = Fable.Core.RustInterop.emitRustExpr v514 v524 
                    let _run_target_args'_v521 = v525 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v526 : string = "String::from($0)"
                    let v527 : std_string_String = Fable.Core.RustInterop.emitRustExpr v514 v526 
                    let _run_target_args'_v521 = v527 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v529 : std_string_String = v514 |> unbox<std_string_String>
                    let _run_target_args'_v521 = v529 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v533 : std_string_String = v514 |> unbox<std_string_String>
                    let _run_target_args'_v521 = v533 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v537 : std_string_String = v514 |> unbox<std_string_String>
                    let _run_target_args'_v521 = v537 
                    #endif
#else
                    let v541 : std_string_String = v514 |> unbox<std_string_String>
                    let _run_target_args'_v521 = v541 
                    #endif
                    let v544 : std_string_String = _run_target_args'_v521 
                    let v550 : string = "fable_library_rust::String_::fromString($0)"
                    let v551 : string = Fable.Core.RustInterop.emitRustExpr v544 v550 
                    let v552 : string = $"> {v551}"
                    if v5 then
                        let v553 : unit = ()
                        let v554 : (unit -> unit) = closure52(v552)
                        let v555 : unit = (fun () -> v554 (); v553) ()
                        ()
                    else
                        let v605 : unit = ()
                        let v606 : (unit -> unit) = closure11(v552)
                        let v607 : unit = (fun () -> v606 (); v605) ()
                        ()
                    v544
            let v728 : string = "$0"
            let v729 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v470 v728 
            let v730 : string = "v729.lock()"
            let v731 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v730 
            (* run_target_args'
            let v733 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v734 : string = "$0.unwrap()"
            let v735 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v731 v734 
            let _run_target_args'_v733 = v735 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v736 : string = "$0.unwrap()"
            let v737 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v731 v736 
            let _run_target_args'_v733 = v737 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v738 : string = "$0.unwrap()"
            let v739 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v731 v738 
            let _run_target_args'_v733 = v739 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v740 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v731 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v733 = v740 
            #endif
#if FABLE_COMPILER_PYTHON
            let v741 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v731 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v733 = v741 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v742 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v731 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v733 = v742 
            #endif
#else
            let v743 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v731 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v733 = v743 
            #endif
            let v744 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = _run_target_args'_v733 
            let v747 : string = "&$0"
            let v748 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v744 v747 
            let v749 : string = "$0.send($1)"
            let v750 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v748, v727) v749 
            let v751 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method126()
            (* run_target_args'
            let v753 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v754 : string = "$0.map_err(|x| $1(x))"
            let v755 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v750, v751) v754 
            let _run_target_args'_v753 = v755 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v756 : string = "$0.map_err(|x| $1(x))"
            let v757 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v750, v751) v756 
            let _run_target_args'_v753 = v757 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v758 : string = "$0.map_err(|x| $1(x))"
            let v759 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v750, v751) v758 
            let _run_target_args'_v753 = v759 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v760 : Result<unit, std_string_String> = match v750 with Ok x -> Ok x | Error x -> Error (v751 x)
            let _run_target_args'_v753 = v760 
            #endif
#if FABLE_COMPILER_PYTHON
            let v761 : Result<unit, std_string_String> = match v750 with Ok x -> Ok x | Error x -> Error (v751 x)
            let _run_target_args'_v753 = v761 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v762 : Result<unit, std_string_String> = match v750 with Ok x -> Ok x | Error x -> Error (v751 x)
            let _run_target_args'_v753 = v762 
            #endif
#else
            let v763 : Result<unit, std_string_String> = match v750 with Ok x -> Ok x | Error x -> Error (v751 x)
            let _run_target_args'_v753 = v763 
            #endif
            let v764 : Result<unit, std_string_String> = _run_target_args'_v753 
            let v767 : string = "$0"
            let v768 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v764 v767 
            let v769 : string = "true; $0 }); //"
            let v770 : bool = Fable.Core.RustInterop.emitRustExpr v768 v769 
            let v771 : string = "_iter_try_for_each.map_err(|x| x.into())"
            let v772 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v771 
            let v773 : Result<unit, string> = method127(v772)
            let v774 : string = ""
            let v775 : string = "}"
            let v776 : string = v774 + v775 
            let x = v773 //
            let v777 : _ = x
            let v778 : unit = ()
            (* run_target_args'
            let v779 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v780 : string = $"true; let _fix_closure_v778 = $0"
            let v781 : bool = Fable.Core.RustInterop.emitRustExpr v777 v780 
            let _run_target_args'_v779 = true 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v782 : string = $"true; let _fix_closure_v778 = $0"
            let v783 : bool = Fable.Core.RustInterop.emitRustExpr v777 v782 
            let _run_target_args'_v779 = true 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v784 : string = $"true; let _fix_closure_v778 = $0"
            let v785 : bool = Fable.Core.RustInterop.emitRustExpr v777 v784 
            let _run_target_args'_v779 = true 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let _run_target_args'_v779 = false 
            #endif
#if FABLE_COMPILER_PYTHON
            let _run_target_args'_v779 = false 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let _run_target_args'_v779 = false 
            #endif
#else
            let _run_target_args'_v779 = false 
            #endif
            let v786 : bool = _run_target_args'_v779 
            let v788 : string = $"true; _fix_closure_v778 " + v776 + "); " + v774 + " // rust.fix_closure'"
            let v789 : bool = Fable.Core.RustInterop.emitRustExpr () v788 
            let v790 : string = "__spawn"
            let v791 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v790 
            let v792 : string = "true; let __spawn = std::thread::spawn(move || { //"
            let v793 : bool = Fable.Core.RustInterop.emitRustExpr () v792 
            let v794 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v795 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v385 v794 
            let v796 : string = "std::io::BufReader::new($0)"
            let v797 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr v795 v796 
            let v798 : string = "std::io::BufRead::lines(v797)"
            let v799 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v798 
            let v800 : string = "true; let mut v799 = v799; let _iter_try_for_each = v799.try_for_each(|x| { //"
            let v801 : bool = Fable.Core.RustInterop.emitRustExpr () v800 
            let v802 : string = "x"
            let v803 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v802 
            let v804 : string = "$0.clone()"
            let v805 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v450 v804 
            let v806 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v808 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v809 : string = "$0.map_err(|x| $1(x))"
            let v810 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v803, v806) v809 
            let _run_target_args'_v808 = v810 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v811 : string = "$0.map_err(|x| $1(x))"
            let v812 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v803, v806) v811 
            let _run_target_args'_v808 = v812 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v813 : string = "$0.map_err(|x| $1(x))"
            let v814 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v803, v806) v813 
            let _run_target_args'_v808 = v814 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v815 : Result<std_string_String, std_string_String> = match v803 with Ok x -> Ok x | Error x -> Error (v806 x)
            let _run_target_args'_v808 = v815 
            #endif
#if FABLE_COMPILER_PYTHON
            let v816 : Result<std_string_String, std_string_String> = match v803 with Ok x -> Ok x | Error x -> Error (v806 x)
            let _run_target_args'_v808 = v816 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v817 : Result<std_string_String, std_string_String> = match v803 with Ok x -> Ok x | Error x -> Error (v806 x)
            let _run_target_args'_v808 = v817 
            #endif
#else
            let v818 : Result<std_string_String, std_string_String> = match v803 with Ok x -> Ok x | Error x -> Error (v806 x)
            let _run_target_args'_v808 = v818 
            #endif
            let v819 : Result<std_string_String, std_string_String> = _run_target_args'_v808 
            let v822 : (std_string_String -> US26) = method119()
            let v823 : (std_string_String -> US26) = method120()
            let v824 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v825 : US26 = Fable.Core.RustInterop.emitRustExpr struct (v822, v823, v819) v824 
            let v1128 : std_string_String =
                match v825 with
                | US26_1(v1010) -> (* Error *)
                    let v1011 : unit = ()
                    let v1012 : (unit -> unit) = closure51(v5, v1010)
                    let v1013 : unit = (fun () -> v1012 (); v1011) ()
                    let v1060 : string = $"\u001b[4;7m{v1010}\u001b[0m"
                    (* run_target_args'
                    let v1065 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1066 : string = "&*$0"
                    let v1067 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1060 v1066 
                    let _run_target_args'_v1065 = v1067 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1068 : string = "&*$0"
                    let v1069 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1060 v1068 
                    let _run_target_args'_v1065 = v1069 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1070 : string = "&*$0"
                    let v1071 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1060 v1070 
                    let _run_target_args'_v1065 = v1071 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1073 : Ref<Str> = v1060 |> unbox<Ref<Str>>
                    let _run_target_args'_v1065 = v1073 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1077 : Ref<Str> = v1060 |> unbox<Ref<Str>>
                    let _run_target_args'_v1065 = v1077 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1081 : Ref<Str> = v1060 |> unbox<Ref<Str>>
                    let _run_target_args'_v1065 = v1081 
                    #endif
#else
                    let v1085 : Ref<Str> = v1060 |> unbox<Ref<Str>>
                    let _run_target_args'_v1065 = v1085 
                    #endif
                    let v1088 : Ref<Str> = _run_target_args'_v1065 
                    (* run_target_args'
                    let v1098 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1099 : string = "String::from($0)"
                    let v1100 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1088 v1099 
                    let _run_target_args'_v1098 = v1100 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1101 : string = "String::from($0)"
                    let v1102 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1088 v1101 
                    let _run_target_args'_v1098 = v1102 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1103 : string = "String::from($0)"
                    let v1104 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1088 v1103 
                    let _run_target_args'_v1098 = v1104 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1106 : std_string_String = v1088 |> unbox<std_string_String>
                    let _run_target_args'_v1098 = v1106 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1110 : std_string_String = v1088 |> unbox<std_string_String>
                    let _run_target_args'_v1098 = v1110 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1114 : std_string_String = v1088 |> unbox<std_string_String>
                    let _run_target_args'_v1098 = v1114 
                    #endif
#else
                    let v1118 : std_string_String = v1088 |> unbox<std_string_String>
                    let _run_target_args'_v1098 = v1118 
                    #endif
                    let v1121 : std_string_String = _run_target_args'_v1098 
                    v1121
                | US26_0(v826) -> (* Ok *)
                    let v827 : string = "fable_library_rust::String_::fromString($0)"
                    let v828 : string = Fable.Core.RustInterop.emitRustExpr v826 v827 
                    let v829 : string = "encoding_rs::UTF_8"
                    let v830 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v829 
                    let v831 : string = "$0.encode(&*$1).0"
                    let v832 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v830, v828) v831 
                    let v833 : string = "$0.as_ref()"
                    let v834 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v832 v833 
                    let v835 : string = "std::str::from_utf8($0)"
                    let v836 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr v834 v835 
                    (* run_target_args'
                    let v838 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v839 : string = "$0.unwrap()"
                    let v840 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v836 v839 
                    let _run_target_args'_v838 = v840 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v841 : string = "$0.unwrap()"
                    let v842 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v836 v841 
                    let _run_target_args'_v838 = v842 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v843 : string = "$0.unwrap()"
                    let v844 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v836 v843 
                    let _run_target_args'_v838 = v844 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v845 : Ref<Str> = match v836 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v838 = v845 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v846 : Ref<Str> = match v836 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v838 = v846 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v847 : Ref<Str> = match v836 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v838 = v847 
                    #endif
#else
                    let v848 : Ref<Str> = match v836 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v838 = v848 
                    #endif
                    let v849 : Ref<Str> = _run_target_args'_v838 
                    (* run_target_args'
                    let v856 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v857 : string = "String::from($0)"
                    let v858 : std_string_String = Fable.Core.RustInterop.emitRustExpr v849 v857 
                    let _run_target_args'_v856 = v858 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v859 : string = "String::from($0)"
                    let v860 : std_string_String = Fable.Core.RustInterop.emitRustExpr v849 v859 
                    let _run_target_args'_v856 = v860 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v861 : string = "String::from($0)"
                    let v862 : std_string_String = Fable.Core.RustInterop.emitRustExpr v849 v861 
                    let _run_target_args'_v856 = v862 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v864 : std_string_String = v849 |> unbox<std_string_String>
                    let _run_target_args'_v856 = v864 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v868 : std_string_String = v849 |> unbox<std_string_String>
                    let _run_target_args'_v856 = v868 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v872 : std_string_String = v849 |> unbox<std_string_String>
                    let _run_target_args'_v856 = v872 
                    #endif
#else
                    let v876 : std_string_String = v849 |> unbox<std_string_String>
                    let _run_target_args'_v856 = v876 
                    #endif
                    let v879 : std_string_String = _run_target_args'_v856 
                    let v885 : string = "fable_library_rust::String_::fromString($0)"
                    let v886 : string = Fable.Core.RustInterop.emitRustExpr v879 v885 
                    let v887 : string = $"! {v886}"
                    if v5 then
                        let v888 : unit = ()
                        let v889 : (unit -> unit) = closure52(v887)
                        let v890 : unit = (fun () -> v889 (); v888) ()
                        ()
                    else
                        let v939 : unit = ()
                        let v940 : (unit -> unit) = closure11(v887)
                        let v941 : unit = (fun () -> v940 (); v939) ()
                        ()
                    let v943 : string = $"\u001b[4;7m{v879}\u001b[0m"
                    (* run_target_args'
                    let v948 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v949 : string = "&*$0"
                    let v950 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v943 v949 
                    let _run_target_args'_v948 = v950 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v951 : string = "&*$0"
                    let v952 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v943 v951 
                    let _run_target_args'_v948 = v952 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v953 : string = "&*$0"
                    let v954 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v943 v953 
                    let _run_target_args'_v948 = v954 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v956 : Ref<Str> = v943 |> unbox<Ref<Str>>
                    let _run_target_args'_v948 = v956 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v960 : Ref<Str> = v943 |> unbox<Ref<Str>>
                    let _run_target_args'_v948 = v960 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v964 : Ref<Str> = v943 |> unbox<Ref<Str>>
                    let _run_target_args'_v948 = v964 
                    #endif
#else
                    let v968 : Ref<Str> = v943 |> unbox<Ref<Str>>
                    let _run_target_args'_v948 = v968 
                    #endif
                    let v971 : Ref<Str> = _run_target_args'_v948 
                    (* run_target_args'
                    let v981 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v982 : string = "String::from($0)"
                    let v983 : std_string_String = Fable.Core.RustInterop.emitRustExpr v971 v982 
                    let _run_target_args'_v981 = v983 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v984 : string = "String::from($0)"
                    let v985 : std_string_String = Fable.Core.RustInterop.emitRustExpr v971 v984 
                    let _run_target_args'_v981 = v985 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v986 : string = "String::from($0)"
                    let v987 : std_string_String = Fable.Core.RustInterop.emitRustExpr v971 v986 
                    let _run_target_args'_v981 = v987 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v989 : std_string_String = v971 |> unbox<std_string_String>
                    let _run_target_args'_v981 = v989 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v993 : std_string_String = v971 |> unbox<std_string_String>
                    let _run_target_args'_v981 = v993 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v997 : std_string_String = v971 |> unbox<std_string_String>
                    let _run_target_args'_v981 = v997 
                    #endif
#else
                    let v1001 : std_string_String = v971 |> unbox<std_string_String>
                    let _run_target_args'_v981 = v1001 
                    #endif
                    let v1004 : std_string_String = _run_target_args'_v981 
                    v1004
            let v1129 : string = "$0"
            let v1130 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v805 v1129 
            let v1131 : string = "v1130.lock()"
            let v1132 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v1131 
            (* run_target_args'
            let v1134 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1135 : string = "$0.unwrap()"
            let v1136 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1132 v1135 
            let _run_target_args'_v1134 = v1136 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1137 : string = "$0.unwrap()"
            let v1138 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1132 v1137 
            let _run_target_args'_v1134 = v1138 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1139 : string = "$0.unwrap()"
            let v1140 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1132 v1139 
            let _run_target_args'_v1134 = v1140 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1141 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1132 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1134 = v1141 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1142 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1132 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1134 = v1142 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1143 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1132 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1134 = v1143 
            #endif
#else
            let v1144 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1132 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1134 = v1144 
            #endif
            let v1145 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = _run_target_args'_v1134 
            let v1148 : string = "&$0"
            let v1149 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1145 v1148 
            let v1150 : string = "$0.send($1)"
            let v1151 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v1149, v1128) v1150 
            let v1152 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method126()
            (* run_target_args'
            let v1154 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1155 : string = "$0.map_err(|x| $1(x))"
            let v1156 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1151, v1152) v1155 
            let _run_target_args'_v1154 = v1156 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1157 : string = "$0.map_err(|x| $1(x))"
            let v1158 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1151, v1152) v1157 
            let _run_target_args'_v1154 = v1158 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1159 : string = "$0.map_err(|x| $1(x))"
            let v1160 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1151, v1152) v1159 
            let _run_target_args'_v1154 = v1160 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1161 : Result<unit, std_string_String> = match v1151 with Ok x -> Ok x | Error x -> Error (v1152 x)
            let _run_target_args'_v1154 = v1161 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1162 : Result<unit, std_string_String> = match v1151 with Ok x -> Ok x | Error x -> Error (v1152 x)
            let _run_target_args'_v1154 = v1162 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1163 : Result<unit, std_string_String> = match v1151 with Ok x -> Ok x | Error x -> Error (v1152 x)
            let _run_target_args'_v1154 = v1163 
            #endif
#else
            let v1164 : Result<unit, std_string_String> = match v1151 with Ok x -> Ok x | Error x -> Error (v1152 x)
            let _run_target_args'_v1154 = v1164 
            #endif
            let v1165 : Result<unit, std_string_String> = _run_target_args'_v1154 
            let v1168 : string = "$0"
            let v1169 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v1165 v1168 
            let v1170 : string = "true; $0 }); //"
            let v1171 : bool = Fable.Core.RustInterop.emitRustExpr v1169 v1170 
            let v1172 : string = "_iter_try_for_each.map_err(|x| x.into())"
            let v1173 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v1172 
            let v1174 : Result<unit, string> = method127(v1173)
            let v1175 : string = v774 + v775 
            let x = v1174 //
            let v1176 : _ = x
            let v1177 : unit = ()
            (* run_target_args'
            let v1178 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1179 : string = $"true; let _fix_closure_v1177 = $0"
            let v1180 : bool = Fable.Core.RustInterop.emitRustExpr v1176 v1179 
            let _run_target_args'_v1178 = true 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1181 : string = $"true; let _fix_closure_v1177 = $0"
            let v1182 : bool = Fable.Core.RustInterop.emitRustExpr v1176 v1181 
            let _run_target_args'_v1178 = true 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1183 : string = $"true; let _fix_closure_v1177 = $0"
            let v1184 : bool = Fable.Core.RustInterop.emitRustExpr v1176 v1183 
            let _run_target_args'_v1178 = true 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let _run_target_args'_v1178 = false 
            #endif
#if FABLE_COMPILER_PYTHON
            let _run_target_args'_v1178 = false 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let _run_target_args'_v1178 = false 
            #endif
#else
            let _run_target_args'_v1178 = false 
            #endif
            let v1185 : bool = _run_target_args'_v1178 
            let v1187 : string = $"true; _fix_closure_v1177 " + v1175 + "); " + v774 + " // rust.fix_closure'"
            let v1188 : bool = Fable.Core.RustInterop.emitRustExpr () v1187 
            let v1189 : string = "__spawn"
            let v1190 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v1189 
            let v1193 : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US27) = method128()
            let v1194 : US27 option = v4 |> Option.map v1193 
            let v1208 : US27 = US27_1
            let v1209 : US27 = v1194 |> Option.defaultValue v1208 
            match v1209 with
            | US27_1 -> (* None *)
                ()
            | US27_0(v1213) -> (* Some *)
                let v1214 : string = "$0"
                let v1215 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v435 v1214 
                let v1216 : string = "v1215.lock()"
                let v1217 : Result<std_sync_MutexGuard<std_process_ChildStdin option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin option>>> = Fable.Core.RustInterop.emitRustExpr () v1216 
                (* run_target_args'
                let v1219 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1220 : string = "$0.unwrap()"
                let v1221 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1217 v1220 
                let _run_target_args'_v1219 = v1221 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1222 : string = "$0.unwrap()"
                let v1223 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1217 v1222 
                let _run_target_args'_v1219 = v1223 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1224 : string = "$0.unwrap()"
                let v1225 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1217 v1224 
                let _run_target_args'_v1219 = v1225 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1226 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1217 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1219 = v1226 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1227 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1217 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1219 = v1227 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v1228 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1217 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1219 = v1228 
                #endif
#else
                let v1229 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1217 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1219 = v1229 
                #endif
                let v1230 : std_sync_MutexGuard<std_process_ChildStdin option> = _run_target_args'_v1219 
                let v1233 : std_sync_MutexGuard<std_process_ChildStdin option> = method129(v1230)
                let v1234 : string = "true; let mut v1233 = v1233"
                let v1235 : bool = Fable.Core.RustInterop.emitRustExpr () v1234 
                let v1236 : string = "&mut $0"
                let v1237 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v1233 v1236 
                let v1238 : string = "Option::take($0)"
                let v1239 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v1237 v1238 
                let v1240 : string = "true; let _optionm_map_ = $0.map(|x| { //"
                let v1241 : bool = Fable.Core.RustInterop.emitRustExpr v1239 v1240 
                let v1242 : string = "x"
                let v1243 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr () v1242 
                let v1244 : string = "std::sync::Mutex::new(v1243)"
                let v1245 : std_sync_Mutex<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr () v1244 
                let v1246 : string = "std::sync::Arc::new(v1245)"
                let v1247 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr () v1246 
                let v1248 : string = "true; $0 })"
                let v1249 : bool = Fable.Core.RustInterop.emitRustExpr v1247 v1248 
                let v1250 : string = "_optionm_map_"
                let v1251 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> option = Fable.Core.RustInterop.emitRustExpr () v1250 
                let v1254 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US28) = method130()
                let v1255 : US28 option = v1251 |> Option.map v1254 
                let v1269 : US28 = US28_1
                let v1270 : US28 = v1255 |> Option.defaultValue v1269 
                match v1270 with
                | US28_1 -> (* None *)
                    ()
                | US28_0(v1274) -> (* Some *)
                    v1213 v1274
                    let v1275 : string = "$0"
                    let v1276 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr v1274 v1275 
                    let v1277 : string = "v1276.lock()"
                    let v1278 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr () v1277 
                    (* run_target_args'
                    let v1280 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1281 : string = "$0.unwrap()"
                    let v1282 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1278 v1281 
                    let _run_target_args'_v1280 = v1282 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1283 : string = "$0.unwrap()"
                    let v1284 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1278 v1283 
                    let _run_target_args'_v1280 = v1284 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1285 : string = "$0.unwrap()"
                    let v1286 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1278 v1285 
                    let _run_target_args'_v1280 = v1286 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1287 : std_sync_MutexGuard<std_process_ChildStdin> = match v1278 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1280 = v1287 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1288 : std_sync_MutexGuard<std_process_ChildStdin> = match v1278 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1280 = v1288 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1289 : std_sync_MutexGuard<std_process_ChildStdin> = match v1278 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1280 = v1289 
                    #endif
#else
                    let v1290 : std_sync_MutexGuard<std_process_ChildStdin> = match v1278 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1280 = v1290 
                    #endif
                    let v1291 : std_sync_MutexGuard<std_process_ChildStdin> = _run_target_args'_v1280 
                    let v1294 : std_sync_MutexGuard<std_process_ChildStdin> = method131(v1291)
                    let v1295 : string = "true; let mut v1294 = v1294"
                    let v1296 : bool = Fable.Core.RustInterop.emitRustExpr () v1295 
                    let v1297 : string = "true; std::io::Write::flush(&mut *$0).unwrap()"
                    let v1298 : bool = Fable.Core.RustInterop.emitRustExpr v1294 v1297 
                    ()
            let v1299 : string = "$0"
            let v1300 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v305 v1299 
            let v1301 : string = "v1300.lock()"
            let v1302 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v1301 
            (* run_target_args'
            let v1304 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1305 : string = "$0.unwrap()"
            let v1306 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1302 v1305 
            let _run_target_args'_v1304 = v1306 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1307 : string = "$0.unwrap()"
            let v1308 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1302 v1307 
            let _run_target_args'_v1304 = v1308 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1309 : string = "$0.unwrap()"
            let v1310 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1302 v1309 
            let _run_target_args'_v1304 = v1310 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1311 : std_sync_MutexGuard<std_process_Child option> = match v1302 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1304 = v1311 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1312 : std_sync_MutexGuard<std_process_Child option> = match v1302 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1304 = v1312 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1313 : std_sync_MutexGuard<std_process_Child option> = match v1302 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1304 = v1313 
            #endif
#else
            let v1314 : std_sync_MutexGuard<std_process_Child option> = match v1302 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1304 = v1314 
            #endif
            let v1315 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v1304 
            let v1318 : std_sync_MutexGuard<std_process_Child option> = method114(v1315)
            let v1319 : string = "true; let mut v1318 = v1318"
            let v1320 : bool = Fable.Core.RustInterop.emitRustExpr () v1319 
            let v1321 : string = "&mut $0"
            let v1322 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v1318 v1321 
            let v1323 : string = "Option::take($0)"
            let v1324 : std_process_Child option = Fable.Core.RustInterop.emitRustExpr v1322 v1323 
            let v1325 : string = "$0.unwrap()"
            let v1326 : std_process_Child = Fable.Core.RustInterop.emitRustExpr v1324 v1325 
            let v1327 : string = "$0.wait_with_output()"
            let v1328 : Result<std_process_Output, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1326 v1327 
            let v1329 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v1331 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1332 : string = "$0.map_err(|x| $1(x))"
            let v1333 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1328, v1329) v1332 
            let _run_target_args'_v1331 = v1333 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1334 : string = "$0.map_err(|x| $1(x))"
            let v1335 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1328, v1329) v1334 
            let _run_target_args'_v1331 = v1335 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1336 : string = "$0.map_err(|x| $1(x))"
            let v1337 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1328, v1329) v1336 
            let _run_target_args'_v1331 = v1337 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1338 : Result<std_process_Output, std_string_String> = match v1328 with Ok x -> Ok x | Error x -> Error (v1329 x)
            let _run_target_args'_v1331 = v1338 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1339 : Result<std_process_Output, std_string_String> = match v1328 with Ok x -> Ok x | Error x -> Error (v1329 x)
            let _run_target_args'_v1331 = v1339 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1340 : Result<std_process_Output, std_string_String> = match v1328 with Ok x -> Ok x | Error x -> Error (v1329 x)
            let _run_target_args'_v1331 = v1340 
            #endif
#else
            let v1341 : Result<std_process_Output, std_string_String> = match v1328 with Ok x -> Ok x | Error x -> Error (v1329 x)
            let _run_target_args'_v1331 = v1341 
            #endif
            let v1342 : Result<std_process_Output, std_string_String> = _run_target_args'_v1331 
            let v1345 : string = "v1190"
            let v1346 : string = v1345 + v774 
            let v1347 : string = v1346 + v774 
            let v1348 : string = "v791"
            let v1349 : string = ", "
            let v1350 : string = v1348 + v1349 
            let v1351 : string = v1350 + v1347 
            let v1352 : string = "vec![" + v1351 + "]"
            let v1353 : Vec<std_thread_JoinHandle<Result<unit, string>>> = Fable.Core.RustInterop.emitRustExpr () v1352 
            let v1354 : string = "true; $0.into_iter().for_each(|x| { //"
            let v1355 : bool = Fable.Core.RustInterop.emitRustExpr v1353 v1354 
            let v1356 : string = "x"
            let v1357 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v1356 
            let v1358 : string = "std::thread::JoinHandle::join($0)"
            let v1359 : Result<Result<unit, string>, Box<LifetimeRef<Dyn<LifetimeJoin<core_any_Any, LifetimeRef<LifetimeJoin<StaticLifetime, Send<StaticLifetime>>>>>>>> = Fable.Core.RustInterop.emitRustExpr v1357 v1358 
            (* run_target_args'
            let v1361 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1362 : string = "$0.unwrap()"
            let v1363 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1359 v1362 
            let _run_target_args'_v1361 = v1363 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1364 : string = "$0.unwrap()"
            let v1365 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1359 v1364 
            let _run_target_args'_v1361 = v1365 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1366 : string = "$0.unwrap()"
            let v1367 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1359 v1366 
            let _run_target_args'_v1361 = v1367 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1368 : Result<unit, string> = match v1359 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1361 = v1368 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1369 : Result<unit, string> = match v1359 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1361 = v1369 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1370 : Result<unit, string> = match v1359 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1361 = v1370 
            #endif
#else
            let v1371 : Result<unit, string> = match v1359 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1361 = v1371 
            #endif
            let v1372 : Result<unit, string> = _run_target_args'_v1361 
            (* run_target_args'
            let v1375 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1376 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1372 v1376 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1377 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1372 v1377 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1378 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1372 v1378 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            match v1372 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#if FABLE_COMPILER_PYTHON
            match v1372 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            match v1372 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#else
            match v1372 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
            // run_target_args' is_unit
            let v1379 : string = $"true"
            let v1380 : bool = Fable.Core.RustInterop.emitRustExpr () v1379 
            let v1381 : string = "true; }}); { //"
            let v1382 : bool = Fable.Core.RustInterop.emitRustExpr () v1381 
            let v1383 : (std_process_Output -> US29) = method132()
            let v1384 : (std_string_String -> US29) = method133()
            let v1386 : US29 = match v1342 with Ok x -> v1383 x | Error x -> v1384 x
            match v1386 with
            | US29_1(v1494) -> (* Error *)
                let v1495 : unit = ()
                let v1496 : (unit -> unit) = closure58(v1494)
                let v1497 : unit = (fun () -> v1496 (); v1495) ()
                let v1544 : US6 = US6_0(v1494)
                let v1545 : US25 = US25_1
                struct (-2, v1544, v1545)
            | US29_0(v1389) -> (* Ok *)
                let v1390 : string = "$0.status"
                let v1391 : std_process_ExitStatus = Fable.Core.RustInterop.emitRustExpr v1389 v1390 
                let v1392 : string = "$0.code()"
                let v1393 : int32 option = Fable.Core.RustInterop.emitRustExpr v1391 v1392 
                let v1396 : (int32 -> US30) = method135()
                let v1397 : US30 option = v1393 |> Option.map v1396 
                let v1411 : US30 = US30_1
                let v1412 : US30 = v1397 |> Option.defaultValue v1411 
                match v1412 with
                | US30_1 -> (* None *)
                    let v1419 : string = "runtime.execute_with_options / exit_code=None"
                    (* run_target_args'
                    let v1424 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1425 : string = "&*$0"
                    let v1426 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1419 v1425 
                    let _run_target_args'_v1424 = v1426 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1427 : string = "&*$0"
                    let v1428 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1419 v1427 
                    let _run_target_args'_v1424 = v1428 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1429 : string = "&*$0"
                    let v1430 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1419 v1429 
                    let _run_target_args'_v1424 = v1430 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1432 : Ref<Str> = v1419 |> unbox<Ref<Str>>
                    let _run_target_args'_v1424 = v1432 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1436 : Ref<Str> = v1419 |> unbox<Ref<Str>>
                    let _run_target_args'_v1424 = v1436 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1440 : Ref<Str> = v1419 |> unbox<Ref<Str>>
                    let _run_target_args'_v1424 = v1440 
                    #endif
#else
                    let v1444 : Ref<Str> = v1419 |> unbox<Ref<Str>>
                    let _run_target_args'_v1424 = v1444 
                    #endif
                    let v1447 : Ref<Str> = _run_target_args'_v1424 
                    (* run_target_args'
                    let v1457 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1458 : string = "String::from($0)"
                    let v1459 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1447 v1458 
                    let _run_target_args'_v1457 = v1459 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1460 : string = "String::from($0)"
                    let v1461 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1447 v1460 
                    let _run_target_args'_v1457 = v1461 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1462 : string = "String::from($0)"
                    let v1463 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1447 v1462 
                    let _run_target_args'_v1457 = v1463 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1465 : std_string_String = v1447 |> unbox<std_string_String>
                    let _run_target_args'_v1457 = v1465 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1469 : std_string_String = v1447 |> unbox<std_string_String>
                    let _run_target_args'_v1457 = v1469 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1473 : std_string_String = v1447 |> unbox<std_string_String>
                    let _run_target_args'_v1457 = v1473 
                    #endif
#else
                    let v1477 : std_string_String = v1447 |> unbox<std_string_String>
                    let _run_target_args'_v1457 = v1477 
                    #endif
                    let v1480 : std_string_String = _run_target_args'_v1457 
                    let v1486 : US6 = US6_0(v1480)
                    let v1487 : US25 = US25_0(v456)
                    struct (-1, v1486, v1487)
                | US30_0(v1416) -> (* Some *)
                    let v1417 : US6 = US6_1
                    let v1418 : US25 = US25_0(v456)
                    struct (v1416, v1417, v1418)
    let v1617 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option =
        match v1609 with
        | US25_1 -> (* None *)
            let v1615 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = None
            v1615
        | US25_0(v1610) -> (* Some *)
            let v1612 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = Some v1610 
            v1612
    let v1618 : string = "true; let _optionm_map_ = $0.map(|x| { //"
    let v1619 : bool = Fable.Core.RustInterop.emitRustExpr v1617 v1618 
    let v1620 : string = "x"
    let v1621 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v1620 
    let v1622 : string = "$0"
    let v1623 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr v1621 v1622 
    let v1624 : string = "v1623.lock()"
    let v1625 : Result<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v1624 
    (* run_target_args'
    let v1627 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1628 : string = "$0.unwrap()"
    let v1629 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v1625 v1628 
    let _run_target_args'_v1627 = v1629 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1630 : string = "$0.unwrap()"
    let v1631 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v1625 v1630 
    let _run_target_args'_v1627 = v1631 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1632 : string = "$0.unwrap()"
    let v1633 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v1625 v1632 
    let _run_target_args'_v1627 = v1633 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1634 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1625 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1627 = v1634 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1635 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1625 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1627 = v1635 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1636 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1625 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1627 = v1636 
    #endif
#else
    let v1637 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1625 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1627 = v1637 
    #endif
    let v1638 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = _run_target_args'_v1627 
    let v1641 : string = "$0.iter()"
    let v1642 : _ = Fable.Core.RustInterop.emitRustExpr v1638 v1641 
    let v1643 : string = "$0.collect::<Vec<_>>()"
    let v1644 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v1642 v1643 
    let v1645 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v1646 : bool = Fable.Core.RustInterop.emitRustExpr v1644 v1645 
    let v1647 : string = "x"
    let v1648 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1647 
    let v1649 : string = "fable_library_rust::String_::fromString($0)"
    let v1650 : string = Fable.Core.RustInterop.emitRustExpr v1648 v1649 
    let v1651 : string = "true; $0 }).collect::<Vec<_>>()"
    let v1652 : bool = Fable.Core.RustInterop.emitRustExpr v1650 v1651 
    let v1653 : string = "_vec_map"
    let v1654 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v1653 
    let v1655 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v1656 : (string []) = Fable.Core.RustInterop.emitRustExpr v1654 v1655 
    let v1658 : string seq = v1656 |> Seq.ofArray
    let v1663 : string = method136()
    let v1664 : (string -> (string seq -> string)) = String.concat
    let v1665 : (string seq -> string) = v1664 v1663
    let v1666 : string = v1665 v1658
    let v1670 : string = "true; $0 })"
    let v1671 : bool = Fable.Core.RustInterop.emitRustExpr v1666 v1670 
    let v1672 : string = "_optionm_map_"
    let v1673 : string option = Fable.Core.RustInterop.emitRustExpr () v1672 
    let v1680 : US5 =
        match v1608 with
        | US6_1 -> (* None *)
            US5_1
        | US6_0(v1674) -> (* Some *)
            let v1675 : string = "fable_library_rust::String_::fromString($0)"
            let v1676 : string = Fable.Core.RustInterop.emitRustExpr v1674 v1675 
            US5_0(v1676)
    let v1684 : string =
        match v1680 with
        | US5_1 -> (* None *)
            let v1682 : string = ""
            v1682
        | US5_0(v1681) -> (* Some *)
            v1681
    let v1686 : string = v1673 |> Option.defaultValue v1684 
    let v1689 : unit = ()
    let v1690 : (unit -> unit) = closure60(v1607, v1686)
    let v1691 : unit = (fun () -> v1690 (); v1689) ()
    let v1740 : (int32 * string) = v1607, v1686 
    v1740 
    )
    |> fun x -> x ()
    ) () )
    |> fun x -> _capture_v175 <- Some x
    let v1743 : (int32 * string) = match _capture_v175 with Some x -> x | None -> failwith "base.capture / _capture_v175=None"
    let (a, b) = v1743 
    let v3312 : int32 = a
    let v3313 : string = b
    let _run_target_args'_v15 = struct (v3312, v3313) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v3320 : int32, v3321 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v3320, v3321) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v3328 : int32, v3329 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v3328, v3329) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v3336 : int32, v3337 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v3336, v3337) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v3344 : int32, v3345 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v3344, v3345) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v3352 : int32, v3353 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v3352, v3353) 
    #endif
#else
    let v3358 : Async<struct (int32 * string)> = method139(v0, v1, v2, v3, v4, v5, v6)
    (* run_target_args'
    let v3367 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v3370 : int32, v3371 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v3367 = struct (v3370, v3371) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v3378 : int32, v3379 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v3367 = struct (v3378, v3379) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v3386 : int32, v3387 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v3367 = struct (v3386, v3387) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v3394 : int32, v3395 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v3367 = struct (v3394, v3395) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3400 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v3401 : int32, v3402 : string) = v3400 v3358
    let _run_target_args'_v3367 = struct (v3401, v3402) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v3403 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v3404 : int32, v3405 : string) = v3403 v3358
    let _run_target_args'_v3367 = struct (v3404, v3405) 
    #endif
#else
    let v3406 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v3407 : int32, v3408 : string) = v3406 v3358
    let _run_target_args'_v3367 = struct (v3407, v3408) 
    #endif
    let struct (v3409 : int32, v3410 : string) = _run_target_args'_v3367 
    let _run_target_args'_v15 = struct (v3409, v3410) 
    #endif
    let struct (v3415 : int32, v3416 : string) = _run_target_args'_v15 
    struct (v3415, v3416)
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
and method159 () : string =
    let v0 : string = ""
    v0
and closure69 () (v0 : string) : US34 =
    US34_0(v0)
and method160 () : (string -> US34) =
    closure69()
and closure70 () (v0 : std_string_String) : US34 =
    US34_1(v0)
and method161 () : (std_string_String -> US34) =
    closure70()
and method163 (v0 : string, v1 : string, v2 : string, v3 : int32, v4 : string, v5 : int32, v6 : string, v7 : string, v8 : US5, v9 : string, v10 : string) : string =
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
and method162 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : string, v12 : int32, v13 : string, v14 : int32, v15 : string, v16 : string, v17 : US5, v18 : string, v19 : string) : string =
    let v20 : string = method163(v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19)
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
                method162(v36, v37, v38, v39, v40, v41, v54, v55, v60, v1, v2, v0, v4, v3, v7, v6, v9, v10, v5, v8)
        method19(v64)
and closure72 () (v0 : uint64) : US35 =
    US35_0(v0)
and method165 () : (uint64 -> US35) =
    closure72()
and closure73 () (v0 : std_string_String) : US35 =
    US35_1(v0)
and method166 () : (std_string_String -> US35) =
    closure73()
and method168 (v0 : string, v1 : string, v2 : std_string_String) : string =
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
and method167 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : std_string_String) : string =
    let v11 : string = method168(v8, v9, v10)
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
        let v48 : string = method167(v28, v29, v30, v31, v32, v33, v46, v47, v1, v0, v2)
        method19(v48)
and method170 (v0 : string, v1 : string, v2 : uint64) : string =
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
and method169 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : uint64) : string =
    let v11 : string = method170(v8, v9, v10)
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
and method177 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32, v10 : string) : string =
    let v11 : string = method178(v8, v9, v10)
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
    while method173(v130, v132) do
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
    let v167 : string = method136()
    let v168 : (string -> (string seq -> string)) = String.concat
    let v169 : (string seq -> string) = v168 v167
    let v170 : string = v169 v160
    let v173 : string = $"{v170}

"
    let v174 : System.Threading.CancellationToken option = None
    let v175 : (struct (string * string) []) = [||]
    let v176 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v177 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v178 : string option = None
    (* run_target_args'
    let v183 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v184 : string = "cfg!(windows)"
    let v185 : bool = Fable.Core.RustInterop.emitRustExpr () v184 
    let _run_target_args'_v183 = v185 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v186 : string = "cfg!(windows)"
    let v187 : bool = Fable.Core.RustInterop.emitRustExpr () v186 
    let _run_target_args'_v183 = v187 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v188 : string = "cfg!(windows)"
    let v189 : bool = Fable.Core.RustInterop.emitRustExpr () v188 
    let _run_target_args'_v183 = v189 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v190 : US3 = US3_0
    let v191 : US4 = US4_4(v190)
    let v192 : string = $"platform.is_windows / target: {v191}"
    let v193 : bool = failwith<bool> v192
    let _run_target_args'_v183 = v193 
    #endif
#if FABLE_COMPILER_PYTHON
    let v194 : US3 = US3_0
    let v195 : US4 = US4_5(v194)
    let v196 : string = $"platform.is_windows / target: {v195}"
    let v197 : bool = failwith<bool> v196
    let _run_target_args'_v183 = v197 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v198 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v199 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v200 : bool = v199 v198
    let _run_target_args'_v183 = v200 
    #endif
#else
    let v201 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v202 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v203 : bool = v202 v201
    let _run_target_args'_v183 = v203 
    #endif
    let v204 : bool = _run_target_args'_v183 
    let v212 : string =
        if v204 then
            let v210 : string = ".exe"
            v210
        else
            let v211 : string = ""
            v211
    let v213 : string = $"../alphabet/deps/hangulize/cmd/hangulize/hangulize{v212}"
    let v214 : string = method28(v0, v213)
    let v215 : string = $"{v214} {v1}"
    let v218 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) = closure78(v173)
    let v219 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = Some v218 
    let v222 : bool = true
    let struct (v223 : int32, v224 : string) = method83(v215, v174, v175, v176, v219, v222, v178)
    let v231 : (string []) = v224.Split v114 
    let v234 : int32 = v231.Length
    let v235 : string = ""
    let v236 : Mut8 = {l0 = 0; l1 = v235; l2 = 0; l3 = 0} : Mut8
    while method176(v130, v236) do
        let v238 : int32 = v236.l0
        let struct (v239 : string, v240 : int32, v241 : int32) = v236.l1, v236.l2, v236.l3
        let v242 : string = v119.[int v238]
        let v243 : bool = v242 = ""
        let struct (v267 : string, v268 : int32, v269 : int32) =
            if v243 then
                let v244 : string = $"{v239}
"
                let v245 : int32 = v240 + 1
                let v246 : int32 = v241 + 1
                struct (v244, v245, v246)
            else
                let v247 : int32 = v240 - v241
                let v248 : bool = v247 >= v234
                let v265 : string =
                    if v248 then
                        v239
                    else
                        let v250 : string = v231.[int v247]
                        let v255 : string = "://"
                        let v256 : bool = v250.Contains v255 
                        let v259 : string =
                            if v256 then
                                v242
                            else
                                v250
                        let v260 : int32 = v234 - 1
                        let v261 : bool = v247 = v260
                        if v261 then
                            let v262 : string = $"{v239}{v259}"
                            v262
                        else
                            let v263 : string = $"{v239}{v259}
"
                            v263
                let v266 : int32 = v240 + 1
                struct (v265, v266, v241)
        let v270 : int32 = v238 + 1
        v236.l0 <- v270
        v236.l1 <- v267
        v236.l2 <- v268
        v236.l3 <- v269
        ()
    let struct (v271 : string, v272 : int32, v273 : int32) = v236.l1, v236.l2, v236.l3
    (* run_target_args'
    let v274 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v275 : string = "std::fs::write(&*$0, &*$1).unwrap()"
    Fable.Core.RustInterop.emitRustExpr struct (v2, v271) v275 
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
    System.IO.File.WriteAllText (v2, v271)
    #endif
    // run_target_args' is_unit
    let v276 : unit = ()
    let v277 : (unit -> unit) = closure79(v2, v223, v271)
    let v278 : unit = (fun () -> v277 (); v276) ()
    US36_0(v223, v271)
and method180 (v0 : int32, v1 : string) : string =
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
and method179 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method180(v8, v9)
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
        let v47 : string = method179(v27, v28, v29, v30, v31, v32, v45, v46, v1, v0)
        method19(v47)
and closure77 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) (v5 : string) : US33 =
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
            let v136 : string = method159()
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
            let v166 : (string -> US34) = method160()
            let v167 : (std_string_String -> US34) = method161()
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
            let v302 : string = method159()
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
            let v332 : (string -> US34) = method160()
            let v333 : (std_string_String -> US34) = method161()
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
        let v348 : US36 = method171(v2, v3, v6, v4)
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
                    method164(v7, v6)
                else
                    let v414 : string = $"documents.files_fn / {v6} should exist"
                    failwith<unit> v414
                let v416 : Result<string, (string * string)> = Ok v6 
                US33_0(v416)
and closure76 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : string) : (string -> US33) =
    closure77(v0, v1, v2, v3, v4)
and method183 (v0 : int32, v1 : string, v2 : string) : string =
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
and method182 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string, v10 : string) : string =
    let v11 : string = method183(v8, v9, v10)
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
    let v79 : string = "ERROR"
    let v80 : bool = v76.Contains v79 
    let v83 : bool = v80 = false
    if v83 then
        US36_0(v75, v76)
    else
        let v85 : unit = ()
        let v86 : (unit -> unit) = closure83(v1, v76, v75)
        let v87 : unit = (fun () -> v86 (); v85) ()
        US36_1(v75, v76)
and closure82 (v0 : string, v1 : string, v2 : bool, v3 : string) (v4 : string) : US33 =
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
            let v165 : (string -> US34) = method160()
            let v166 : (std_string_String -> US34) = method161()
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
            let v301 : string = method159()
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
            let v331 : (string -> US34) = method160()
            let v332 : (std_string_String -> US34) = method161()
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
        let v347 : US36 = method181(v2, v5, v3, v1, v4)
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
                    method164(v6, v5)
                else
                    let v413 : string = $"documents.files_fn / {v5} should exist"
                    failwith<unit> v413
                let v415 : Result<string, (string * string)> = Ok v5 
                US33_0(v415)
and closure81 (v0 : string, v1 : string, v2 : bool) (v3 : string) : (string -> US33) =
    closure82(v0, v1, v2, v3)
and method185 (v0 : string, v1 : string) : string =
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
and method184 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string) : string =
    let v10 : string = method185(v8, v9)
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
and closure86 (v0 : UH5) (v1 : UH4) : UH4 =
    UH4_1(v0, v1)
and closure85 () (v0 : UH5) : (UH4 -> UH4) =
    closure86(v0)
and method187 () : (UH5 -> (UH4 -> UH4)) =
    closure85()
and method189 (v0 : UH5, v1 : struct (string * string * (string -> (string -> US33))) list) : struct (string * string * (string -> (string -> US33))) list =
    match v0 with
    | UH5_1(v2, v3, v4, v5) -> (* Cons *)
        let v6 : struct (string * string * (string -> (string -> US33))) list = method189(v5, v1)
        let v8 : struct (string * string * (string -> (string -> US33))) list = struct (v2, v3, v4) :: v6 
        v8
    | UH5_0 -> (* Nil *)
        v1
and closure87 () struct (v0 : string, v1 : string, v2 : (string -> (string -> US33))) : Result<string, (string * string)> option =
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
        let v16 : (struct (string * string * (string -> (string -> US33))) -> Result<string, (string * string)> option) = closure87()
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
    let v723 : UH4 =
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
            let v341 : unit = ()
            let _let'_v341 =
                seq {
                    for i = 0 to v336.Length - 1 do yield v336.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v344 : string seq = _let'_v341 
            let v350 : string = method159()
            let v352 : bool = v350 = "\n"
            let v354 : string =
                if v352 then
                    method65(v350)
                else
                    v350
            let v355 : (string -> (string seq -> string)) = String.concat
            let v356 : (string seq -> string) = v355 v354
            let v357 : string = v356 v344
            let v361 : Result<string, std_io_Error> = Ok v357 
            let v364 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v366 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v367 : string = "$0.map_err(|x| $1(x))"
            let v368 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v361, v364) v367 
            let _run_target_args'_v366 = v368 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v369 : string = "$0.map_err(|x| $1(x))"
            let v370 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v361, v364) v369 
            let _run_target_args'_v366 = v370 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v371 : string = "$0.map_err(|x| $1(x))"
            let v372 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v361, v364) v371 
            let _run_target_args'_v366 = v372 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v373 : Result<string, std_string_String> = match v361 with Ok x -> Ok x | Error x -> Error (v364 x)
            let _run_target_args'_v366 = v373 
            #endif
#if FABLE_COMPILER_PYTHON
            let v374 : Result<string, std_string_String> = match v361 with Ok x -> Ok x | Error x -> Error (v364 x)
            let _run_target_args'_v366 = v374 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v375 : Result<string, std_string_String> = match v361 with Ok x -> Ok x | Error x -> Error (v364 x)
            let _run_target_args'_v366 = v375 
            #endif
#else
            let v376 : Result<string, std_string_String> = match v361 with Ok x -> Ok x | Error x -> Error (v364 x)
            let _run_target_args'_v366 = v376 
            #endif
            let v377 : Result<string, std_string_String> = _run_target_args'_v366 
            let v380 : (string -> US34) = method160()
            let v381 : (std_string_String -> US34) = method161()
            let v382 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v383 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v380, v381, v377) v382 
            let v392 : string =
                match v383 with
                | US34_1(v385) -> (* Error *)
                    let v387 : string = $"resultm.get / Result value was Error: {v385}"
                    failwith<string> v387
                | US34_0(v384) -> (* Ok *)
                    v384
            let v393 : bool = method30(v212)
            let v394 : bool = v393 = false
            let v559 : US5 =
                if v394 then
                    US5_1
                else
                    let v396 : string = method38(v212)
                    let v397 : string = "std::fs::File::open(&*v396)"
                    let v398 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v397 
                    (* run_target_args'
                    let v400 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v401 : string = "$0.unwrap()"
                    let v402 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v398 v401 
                    let _run_target_args'_v400 = v402 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v403 : string = "$0.unwrap()"
                    let v404 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v398 v403 
                    let _run_target_args'_v400 = v404 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v405 : string = "$0.unwrap()"
                    let v406 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v398 v405 
                    let _run_target_args'_v400 = v406 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v407 : std_fs_File = match v398 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v400 = v407 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v408 : std_fs_File = match v398 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v400 = v408 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v409 : std_fs_File = match v398 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v400 = v409 
                    #endif
#else
                    let v410 : std_fs_File = match v398 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v400 = v410 
                    #endif
                    let v411 : std_fs_File = _run_target_args'_v400 
                    let v414 : string = "std::io::BufReader::new($0)"
                    let v415 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v411 v414 
                    let v416 : string = "std::io::BufReader::new($0)"
                    let v417 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v415 v416 
                    let v418 : string = "true; let mut v417 = v417"
                    let v419 : bool = Fable.Core.RustInterop.emitRustExpr () v418 
                    let v420 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
                    Fable.Core.RustInterop.emitRustExpr () v420 
                    let v421 : string = "result"
                    let v422 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v421 
                    let v423 : string = "true; let mut v422 = v422"
                    let v424 : bool = Fable.Core.RustInterop.emitRustExpr () v423 
                    let v426 : unativeint = 0 |> unativeint 
                    let v429 : string = "[$0; 1024]"
                    let v430 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v429 
                    let v431 : string = "true; loop { // rust.loop"
                    let v432 : bool = Fable.Core.RustInterop.emitRustExpr () v431 
                    let v433 : string = "true; let mut v430 = v430"
                    let v434 : bool = Fable.Core.RustInterop.emitRustExpr () v433 
                    let v435 : string = "std::io::Read::read(&mut v417, &mut v430)"
                    let v436 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v435 
                    (* run_target_args'
                    let v438 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v439 : string = "$0.unwrap()"
                    let v440 : unativeint = Fable.Core.RustInterop.emitRustExpr v436 v439 
                    let _run_target_args'_v438 = v440 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v441 : string = "$0.unwrap()"
                    let v442 : unativeint = Fable.Core.RustInterop.emitRustExpr v436 v441 
                    let _run_target_args'_v438 = v442 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v443 : string = "$0.unwrap()"
                    let v444 : unativeint = Fable.Core.RustInterop.emitRustExpr v436 v443 
                    let _run_target_args'_v438 = v444 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v445 : unativeint = match v436 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v438 = v445 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v446 : unativeint = match v436 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v438 = v446 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v447 : unativeint = match v436 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v438 = v447 
                    #endif
#else
                    let v448 : unativeint = match v436 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v438 = v448 
                    #endif
                    let v449 : unativeint = _run_target_args'_v438 
                    let v453 : bool = v449 = v426 
                    if v453 then
                        let v456 : string = "true; break"
                        let v457 : bool = Fable.Core.RustInterop.emitRustExpr () v456 
                        ()
                    let v459 : unativeint = v449 |> unativeint 
                    let v463 : unativeint = v459 |> unbox<unativeint>
                    let v466 : string = "v430.len()"
                    let v467 : unativeint = Fable.Core.RustInterop.emitRustExpr () v466 
                    let v469 : bool = v463 = v467 
                    let v476 : Ref<Slice'<uint8>> =
                        if v469 then
                            let v472 : string = "&v430[v426..]"
                            let v473 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v472 
                            v473
                        else
                            let v474 : string = "&v430[$0..$1]"
                            let v475 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v426, v459) v474 
                            v475
                    let v477 : string = "sha2::Digest::update(&mut v422, v476)"
                    Fable.Core.RustInterop.emitRustExpr () v477 
                    let v478 : string = "true; } // rust.loop"
                    let v479 : bool = Fable.Core.RustInterop.emitRustExpr () v478 
                    let v480 : string = "true; } // rust.loop"
                    let v481 : bool = Fable.Core.RustInterop.emitRustExpr () v480 
                    let v482 : string = "true; } // rust.loop"
                    let v483 : bool = Fable.Core.RustInterop.emitRustExpr () v482 
                    let v484 : string = "true; { // rust.loop"
                    let v485 : bool = Fable.Core.RustInterop.emitRustExpr () v484 
                    let v486 : string = "true; { // rust.loop"
                    let v487 : bool = Fable.Core.RustInterop.emitRustExpr () v486 
                    let v488 : string = "&sha2::Digest::finalize(v422)"
                    let v489 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v488 
                    let v490 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
                    let v491 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v489 v490 
                    let v492 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
                    let v493 : bool = Fable.Core.RustInterop.emitRustExpr v491 v492 
                    let v494 : string = "x"
                    let v495 : uint8 = Fable.Core.RustInterop.emitRustExpr () v494 
                    let v496 : string = "format!(\"{:02x}\", $0)"
                    let v497 : std_string_String = Fable.Core.RustInterop.emitRustExpr v495 v496 
                    let v498 : string = "fable_library_rust::String_::fromString($0)"
                    let v499 : string = Fable.Core.RustInterop.emitRustExpr v497 v498 
                    let v500 : string = "true; $0 }).collect::<Vec<_>>()"
                    let v501 : bool = Fable.Core.RustInterop.emitRustExpr v499 v500 
                    let v502 : string = "_vec_map"
                    let v503 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v502 
                    let v504 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
                    let v505 : (string []) = Fable.Core.RustInterop.emitRustExpr v503 v504 
                    let v510 : unit = ()
                    let _let'_v510 =
                        seq {
                            for i = 0 to v505.Length - 1 do yield v505.[i]
                            (* indent
                            ()
                        indent *)
                        }
                        (* indent
                        ()
                    indent *)
                    let v513 : string seq = _let'_v510 
                    let v519 : string = method159()
                    let v521 : bool = v519 = "\n"
                    let v523 : string =
                        if v521 then
                            method65(v519)
                        else
                            v519
                    let v524 : (string -> (string seq -> string)) = String.concat
                    let v525 : (string seq -> string) = v524 v523
                    let v526 : string = v525 v513
                    let v530 : Result<string, std_io_Error> = Ok v526 
                    let v533 : (std_io_Error -> std_string_String) = method69()
                    (* run_target_args'
                    let v535 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v536 : string = "$0.map_err(|x| $1(x))"
                    let v537 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v530, v533) v536 
                    let _run_target_args'_v535 = v537 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v538 : string = "$0.map_err(|x| $1(x))"
                    let v539 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v530, v533) v538 
                    let _run_target_args'_v535 = v539 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v540 : string = "$0.map_err(|x| $1(x))"
                    let v541 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v530, v533) v540 
                    let _run_target_args'_v535 = v541 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v542 : Result<string, std_string_String> = match v530 with Ok x -> Ok x | Error x -> Error (v533 x)
                    let _run_target_args'_v535 = v542 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v543 : Result<string, std_string_String> = match v530 with Ok x -> Ok x | Error x -> Error (v533 x)
                    let _run_target_args'_v535 = v543 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v544 : Result<string, std_string_String> = match v530 with Ok x -> Ok x | Error x -> Error (v533 x)
                    let _run_target_args'_v535 = v544 
                    #endif
#else
                    let v545 : Result<string, std_string_String> = match v530 with Ok x -> Ok x | Error x -> Error (v533 x)
                    let _run_target_args'_v535 = v545 
                    #endif
                    let v546 : Result<string, std_string_String> = _run_target_args'_v535 
                    let v549 : (string -> US34) = method160()
                    let v550 : (std_string_String -> US34) = method161()
                    let v551 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
                    let v552 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v549, v550, v546) v551 
                    match v552 with
                    | US34_1(v555) -> (* Error *)
                        US5_1
                    | US34_0(v553) -> (* Ok *)
                        US5_0(v553)
            match v559 with
            | US5_0(v560) -> (* Some *)
                let v561 : bool = v392 = v560
                if v561 then
                    UH4_0
                else
                    let v563 : unit = ()
                    let v564 : (unit -> unit) = closure71(v179, v180, v182, v195, v194, v197, v210, v209, v212, v392, v559)
                    let v565 : unit = (fun () -> v564 (); v563) ()
                    method164(v212, v197)
                    let v620 : (string -> (string -> US33)) = closure76(v4, v3, v1, v0)
                    let v621 : UH5 = UH5_0
                    let v622 : UH5 = UH5_1(v213, v197, v620, v621)
                    let v623 : string = "html"
                    let v624 : (string -> (string -> US33)) = closure81(v4, v3, v216)
                    let v625 : string = "pdf"
                    let v626 : (string -> (string -> US33)) = closure81(v4, v3, v217)
                    let v627 : string = "epub"
                    let v628 : (string -> (string -> US33)) = closure81(v4, v3, v218)
                    let v629 : (string -> (string -> US33)) = closure81(v4, v3, v219)
                    let v630 : (string -> (string -> US33)) = closure81(v4, v3, v220)
                    let v631 : (string -> (string -> US33)) = closure81(v4, v3, v221)
                    let v632 : UH5 = UH5_0
                    let v633 : UH5 = UH5_1(v627, v214, v631, v632)
                    let v634 : UH5 = UH5_1(v625, v214, v630, v633)
                    let v635 : UH5 = UH5_1(v623, v214, v629, v634)
                    let v636 : UH5 = UH5_1(v627, v197, v628, v635)
                    let v637 : UH5 = UH5_1(v625, v197, v626, v636)
                    let v638 : UH5 = UH5_1(v623, v197, v624, v637)
                    let v639 : UH4 = UH4_0
                    let v640 : UH4 = UH4_1(v638, v639)
                    UH4_1(v622, v640)
            | _ ->
                let v643 : unit = ()
                let v644 : (unit -> unit) = closure71(v179, v180, v182, v195, v194, v197, v210, v209, v212, v392, v559)
                let v645 : unit = (fun () -> v644 (); v643) ()
                method164(v212, v197)
                let v700 : (string -> (string -> US33)) = closure76(v4, v3, v1, v0)
                let v701 : UH5 = UH5_0
                let v702 : UH5 = UH5_1(v213, v197, v700, v701)
                let v703 : string = "html"
                let v704 : (string -> (string -> US33)) = closure81(v4, v3, v216)
                let v705 : string = "pdf"
                let v706 : (string -> (string -> US33)) = closure81(v4, v3, v217)
                let v707 : string = "epub"
                let v708 : (string -> (string -> US33)) = closure81(v4, v3, v218)
                let v709 : (string -> (string -> US33)) = closure81(v4, v3, v219)
                let v710 : (string -> (string -> US33)) = closure81(v4, v3, v220)
                let v711 : (string -> (string -> US33)) = closure81(v4, v3, v221)
                let v712 : UH5 = UH5_0
                let v713 : UH5 = UH5_1(v707, v214, v711, v712)
                let v714 : UH5 = UH5_1(v705, v214, v710, v713)
                let v715 : UH5 = UH5_1(v703, v214, v709, v714)
                let v716 : UH5 = UH5_1(v707, v197, v708, v715)
                let v717 : UH5 = UH5_1(v705, v197, v706, v716)
                let v718 : UH5 = UH5_1(v703, v197, v704, v717)
                let v719 : UH4 = UH4_0
                let v720 : UH4 = UH4_1(v718, v719)
                UH4_1(v702, v720)
    let v724 : bool =
        match v723 with
        | UH4_0 -> (* Nil *)
            true
        | _ ->
            false
    let v725 : bool = v724 <> true
    let v1149 : UH4 =
        if v725 then
            v723
        else
            let v726 : string = "epub"
            let struct (v727 : string, v728 : string) = method158(v726, v214, v4)
            let v729 : bool = method30(v727)
            let v782 : bool =
                if v729 then
                    true
                else
                    let v730 : bool = method30(v728)
                    let v731 : bool = v730 = false
                    if v731 then
                        true
                    else
                        let v732 : unit = ()
                        let v733 : (unit -> unit) = closure84(v728, v727)
                        let v734 : unit = (fun () -> v733 (); v732) ()
                        method164(v727, v728)
                        false
            let v787 : UH5 =
                if v782 then
                    let v783 : (string -> (string -> US33)) = closure81(v4, v3, v221)
                    let v784 : UH5 = UH5_0
                    UH5_1(v726, v214, v783, v784)
                else
                    UH5_0
            let v788 : string = "pdf"
            let struct (v789 : string, v790 : string) = method158(v788, v214, v4)
            let v791 : bool = method30(v789)
            let v844 : bool =
                if v791 then
                    true
                else
                    let v792 : bool = method30(v790)
                    let v793 : bool = v792 = false
                    if v793 then
                        true
                    else
                        let v794 : unit = ()
                        let v795 : (unit -> unit) = closure84(v790, v789)
                        let v796 : unit = (fun () -> v795 (); v794) ()
                        method164(v789, v790)
                        false
            let v847 : UH5 =
                if v844 then
                    let v845 : (string -> (string -> US33)) = closure81(v4, v3, v220)
                    UH5_1(v788, v214, v845, v787)
                else
                    v787
            let v848 : string = "html"
            let struct (v849 : string, v850 : string) = method158(v848, v214, v4)
            let v851 : bool = method30(v849)
            let v904 : bool =
                if v851 then
                    true
                else
                    let v852 : bool = method30(v850)
                    let v853 : bool = v852 = false
                    if v853 then
                        true
                    else
                        let v854 : unit = ()
                        let v855 : (unit -> unit) = closure84(v850, v849)
                        let v856 : unit = (fun () -> v855 (); v854) ()
                        method164(v849, v850)
                        false
            let v907 : UH5 =
                if v904 then
                    let v905 : (string -> (string -> US33)) = closure81(v4, v3, v219)
                    UH5_1(v848, v214, v905, v847)
                else
                    v847
            let struct (v908 : string, v909 : string) = method158(v726, v197, v4)
            let v910 : bool = method30(v908)
            let v963 : bool =
                if v910 then
                    true
                else
                    let v911 : bool = method30(v909)
                    let v912 : bool = v911 = false
                    if v912 then
                        true
                    else
                        let v913 : unit = ()
                        let v914 : (unit -> unit) = closure84(v909, v908)
                        let v915 : unit = (fun () -> v914 (); v913) ()
                        method164(v908, v909)
                        false
            let v966 : UH5 =
                if v963 then
                    let v964 : (string -> (string -> US33)) = closure81(v4, v3, v218)
                    UH5_1(v726, v197, v964, v907)
                else
                    v907
            let struct (v967 : string, v968 : string) = method158(v788, v197, v4)
            let v969 : bool = method30(v967)
            let v1022 : bool =
                if v969 then
                    true
                else
                    let v970 : bool = method30(v968)
                    let v971 : bool = v970 = false
                    if v971 then
                        true
                    else
                        let v972 : unit = ()
                        let v973 : (unit -> unit) = closure84(v968, v967)
                        let v974 : unit = (fun () -> v973 (); v972) ()
                        method164(v967, v968)
                        false
            let v1025 : UH5 =
                if v1022 then
                    let v1023 : (string -> (string -> US33)) = closure81(v4, v3, v217)
                    UH5_1(v788, v197, v1023, v966)
                else
                    v966
            let struct (v1026 : string, v1027 : string) = method158(v848, v197, v4)
            let v1028 : bool = method30(v1026)
            let v1081 : bool =
                if v1028 then
                    true
                else
                    let v1029 : bool = method30(v1027)
                    let v1030 : bool = v1029 = false
                    if v1030 then
                        true
                    else
                        let v1031 : unit = ()
                        let v1032 : (unit -> unit) = closure84(v1027, v1026)
                        let v1033 : unit = (fun () -> v1032 (); v1031) ()
                        method164(v1026, v1027)
                        false
            let v1084 : UH5 =
                if v1081 then
                    let v1082 : (string -> (string -> US33)) = closure81(v4, v3, v216)
                    UH5_1(v848, v197, v1082, v1025)
                else
                    v1025
            let struct (v1085 : string, v1086 : string) = method158(v213, v197, v4)
            let v1087 : bool = method30(v1085)
            let v1140 : bool =
                if v1087 then
                    true
                else
                    let v1088 : bool = method30(v1086)
                    let v1089 : bool = v1088 = false
                    if v1089 then
                        true
                    else
                        let v1090 : unit = ()
                        let v1091 : (unit -> unit) = closure84(v1086, v1085)
                        let v1092 : unit = (fun () -> v1091 (); v1090) ()
                        method164(v1085, v1086)
                        false
            let v1145 : UH5 =
                if v1140 then
                    let v1141 : (string -> (string -> US33)) = closure76(v4, v3, v1, v0)
                    let v1142 : UH5 = UH5_0
                    UH5_1(v213, v197, v1141, v1142)
                else
                    UH5_0
            let v1146 : UH4 = UH4_0
            let v1147 : UH4 = UH4_1(v1084, v1146)
            UH4_1(v1145, v1147)
    let v1150 : UH5 list = []
    let v1151 : UH5 list = method186(v1149, v1150)
    let v1153 : (UH5 list -> (UH5 [])) = List.toArray
    let v1154 : (UH5 []) = v1153 v1151
    let v1157 : string = "$0.to_vec()"
    let v1158 : Vec<UH5> = Fable.Core.RustInterop.emitRustExpr v1154 v1157 
    let v1159 : (Result<string, (string * string)> option []) = [||]
    let v1160 : string = "$0.to_vec()"
    let v1161 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1159 v1160 
    let v1162 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v1163 : (UH5 []) = Fable.Core.RustInterop.emitRustExpr v1158 v1162 
    let v1165 : UH5 list = v1163 |> Array.toList
    let v1173 : ((UH5 -> (UH4 -> UH4)) -> (UH5 list -> (UH4 -> UH4))) = List.foldBack
    let v1174 : (UH5 -> (UH4 -> UH4)) = method187()
    let v1175 : (UH5 list -> (UH4 -> UH4)) = v1173 v1174
    let v1176 : (UH4 -> UH4) = v1175 v1165
    let v1177 : UH4 = UH4_0
    let v1178 : UH4 = v1176 v1177
    let v1207 : Vec<Result<string, (string * string)> option> = method188(v1178, v1161)
    let v1209 : (string * Vec<Result<string, (string * string)> option>) = v180, v1207 
    let v1213 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = Ok v1209 
    v1213
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
and method192 () : (Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> -> US37) =
    closure88()
and closure89 () (v0 : std_string_String) : US37 =
    US37_1(v0)
and method193 () : (std_string_String -> US37) =
    closure89()
and method194 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
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
        let v46 : string = method194(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method19(v46)
and method196 (v0 : unativeint) : string =
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
and method195 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : unativeint) : string =
    let v9 : string = method196(v8)
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
    let v108 : (std_string_String -> US6) = method21()
    let v109 : US6 option = v105 |> Option.map v108 
    let v123 : US6 = US6_1
    let v124 : US6 = v109 |> Option.defaultValue v123 
    let v131 : std_string_String =
        match v124 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v128) -> (* Some *)
            v128
    let v132 : string = "fable_library_rust::String_::fromString($0)"
    let v133 : string = Fable.Core.RustInterop.emitRustExpr v131 v132 
    let v134 : string = method22()
    (* run_target_args'
    let v139 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v140 : string = "&*$0"
    let v141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v134 v140 
    let _run_target_args'_v139 = v141 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v142 : string = "&*$0"
    let v143 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v134 v142 
    let _run_target_args'_v139 = v143 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v144 : string = "&*$0"
    let v145 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v134 v144 
    let _run_target_args'_v139 = v145 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v147 : Ref<Str> = v134 |> unbox<Ref<Str>>
    let _run_target_args'_v139 = v147 
    #endif
#if FABLE_COMPILER_PYTHON
    let v151 : Ref<Str> = v134 |> unbox<Ref<Str>>
    let _run_target_args'_v139 = v151 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v155 : Ref<Str> = v134 |> unbox<Ref<Str>>
    let _run_target_args'_v139 = v155 
    #endif
#else
    let v159 : Ref<Str> = v134 |> unbox<Ref<Str>>
    let _run_target_args'_v139 = v159 
    #endif
    let v162 : Ref<Str> = _run_target_args'_v139 
    let v168 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v169 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v69, v162) v168 
    let v172 : (std_string_String -> US6) = method21()
    let v173 : US6 option = v169 |> Option.map v172 
    let v187 : US6 = US6_1
    let v188 : US6 = v173 |> Option.defaultValue v187 
    let v195 : std_string_String =
        match v188 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v192) -> (* Some *)
            v192
    let v196 : string = "fable_library_rust::String_::fromString($0)"
    let v197 : string = Fable.Core.RustInterop.emitRustExpr v195 v196 
    let v198 : string = method23()
    (* run_target_args'
    let v203 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v204 : string = "&*$0"
    let v205 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v198 v204 
    let _run_target_args'_v203 = v205 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v206 : string = "&*$0"
    let v207 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v198 v206 
    let _run_target_args'_v203 = v207 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v208 : string = "&*$0"
    let v209 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v198 v208 
    let _run_target_args'_v203 = v209 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v211 : Ref<Str> = v198 |> unbox<Ref<Str>>
    let _run_target_args'_v203 = v211 
    #endif
#if FABLE_COMPILER_PYTHON
    let v215 : Ref<Str> = v198 |> unbox<Ref<Str>>
    let _run_target_args'_v203 = v215 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v219 : Ref<Str> = v198 |> unbox<Ref<Str>>
    let _run_target_args'_v203 = v219 
    #endif
#else
    let v223 : Ref<Str> = v198 |> unbox<Ref<Str>>
    let _run_target_args'_v203 = v223 
    #endif
    let v226 : Ref<Str> = _run_target_args'_v203 
    let v232 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v233 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v69, v226) v232 
    let v236 : (std_string_String -> US6) = method21()
    let v237 : US6 option = v233 |> Option.map v236 
    let v251 : US6 = US6_1
    let v252 : US6 = v237 |> Option.defaultValue v251 
    let v259 : std_string_String =
        match v252 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v256) -> (* Some *)
            v256
    let v260 : string = "fable_library_rust::String_::fromString($0)"
    let v261 : string = Fable.Core.RustInterop.emitRustExpr v259 v260 
    let v262 : string = method24()
    (* run_target_args'
    let v267 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v268 : string = "&*$0"
    let v269 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v262 v268 
    let _run_target_args'_v267 = v269 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v270 : string = "&*$0"
    let v271 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v262 v270 
    let _run_target_args'_v267 = v271 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v272 : string = "&*$0"
    let v273 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v262 v272 
    let _run_target_args'_v267 = v273 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v275 : Ref<Str> = v262 |> unbox<Ref<Str>>
    let _run_target_args'_v267 = v275 
    #endif
#if FABLE_COMPILER_PYTHON
    let v279 : Ref<Str> = v262 |> unbox<Ref<Str>>
    let _run_target_args'_v267 = v279 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v283 : Ref<Str> = v262 |> unbox<Ref<Str>>
    let _run_target_args'_v267 = v283 
    #endif
#else
    let v287 : Ref<Str> = v262 |> unbox<Ref<Str>>
    let _run_target_args'_v267 = v287 
    #endif
    let v290 : Ref<Str> = _run_target_args'_v267 
    let v296 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v297 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v69, v290) v296 
    let v300 : (std_string_String -> US6) = method21()
    let v301 : US6 option = v297 |> Option.map v300 
    let v315 : US6 = US6_1
    let v316 : US6 = v301 |> Option.defaultValue v315 
    let v323 : std_string_String =
        match v316 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v320) -> (* Some *)
            v320
    let v324 : string = "fable_library_rust::String_::fromString($0)"
    let v325 : string = Fable.Core.RustInterop.emitRustExpr v323 v324 
    let v326 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = method25(v325, v261, v197, v133)
    let v327 : string = "futures::executor::block_on($0)"
    let v328 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr v326 v327 
    let v329 : (Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> -> US37) = method192()
    let v330 : (std_string_String -> US37) = method193()
    let v332 : US37 = match v328 with Ok x -> v329 x | Error x -> v330 x
    match v332 with
    | US37_1(v387) -> (* Error *)
        let v388 : unit = ()
        let v389 : (unit -> unit) = closure90(v387)
        let v390 : unit = (fun () -> v389 (); v388) ()
        1
    | US37_0(v335) -> (* Ok *)
        let v336 : unit = ()
        let v337 : (unit -> unit) = closure91(v335)
        let v338 : unit = (fun () -> v337 (); v336) ()
        0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
